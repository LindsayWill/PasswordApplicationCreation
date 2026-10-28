using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing.Text;


namespace PasswordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Generate Password Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Get Length dynamically from the NumericUpDown control
            int length = (int)numericUpDown1.Value;
            if (length < 4) length = 8; //Safety Minimum

            //Grab any custom text from textBox2 (optional)
            string customInput = button2.Text;

            //Character pool for the secure password
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890!@#$%^&*()_+-=[]{};:,.<>?";
            StringBuilder result = new StringBuilder();

            //Generate cryptographically secure random characters
            for (int i = 0; i < length; i++)
            {
                int index = RandomNumberGenerator.GetInt32(validChars.Length);
                result.Append(validChars[index]);
            }

            //Display the final generated password in textBox1 (optional
            textBox1.Text = result.ToString();
        }
        //Copy to Clipboard button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Password copied to clipboard!");
            }
        }
        //Save to Password Keeper Button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string accountLabel = vaultSave.Text.Trim();
            string generatedPassword = textBox1.Text;

            //Validation Checks
            if (string.IsNullOrEmpty(accountLabel))
            {
                MessageBox.Show("Please enter a label for what this password is for (e.g., 'Gmail'");
                return;
            }
            if (string.IsNullOrEmpty(generatedPassword))
            {
                MessageBox.Show("Please generate a password first!");
                return;
            }
            //Format the vault entry cleanly
            string vaultEntry = $"Account: {accountLabel} | Password: {generatedPassword} | Saved {DateTime.Now}\n";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PasswordVaultManager.PasswordToSave(textBox1.Text);
            MessageBox.Show("Password Saved Successfully!");
            textBox1.Clear();
        }


        private void savePasswordToVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string accountLabel = vaultSave.Text.Trim();
            string generatedPassword = textBox1.Text;

            if (string.IsNullOrEmpty(accountLabel))
            {
                MessageBox.Show("Please generate a password first!");
                return;
            }
            //FormatException the entry cleanly with just the password and timestamp
            string vaultEntry = $"Password; {generatedPassword} | Saved: {DateTime.Now}\n";

            try
            {
                //Convert string into bytes
                byte[] plainBytes = Encoding.UTF8.GetBytes(vaultEntry);

                //Encrypt using Windows DPAPI (locked specifically for Windows user account
                byte[] encryptedBytes = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);

                //Convert to a secure Base64 string so it can be saved in a text file
                string encryptedBase64 = Convert.ToBase64String(encryptedBytes);

                //Set file path in Documents
                string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "passwordAppVault.txt");
                Directory.CreateDirectory(folderPath);// Creates folder if it doesn't exist.
                string filePath = Path.Combine(folderPath, "password_vault.text");

                File.AppendAllText(filePath, encryptedBase64 + Environment.NewLine);

                MessageBox.Show("Successfully encrypted ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption ERROR: " + ex.Message);
            }
        }
        private string GetVaultFilePath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PasswordAppVault");
            Directory.CreateDirectory(folderPath);
            return Path.Combine(folderPath, "password_vault.txt");
        }
       
        private void viewSavedVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PasswordAppVault");
            string filePath = Path.Combine(folderPath, "Password_vault.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No password vault found yet! Save a password first.");
                return;
            }
            try
            {
                string[] encryptedLines = File.ReadAllLines(filePath);
                string decryptedVaultContents = "";

                foreach (string encryptedBase64 in encryptedLines)
                {
                    if (string.IsNullOrWhiteSpace(encryptedBase64)) continue;

                    byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
                    byte[] plainBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
                    string decryptedEntry = Encoding.UTF8.GetString(plainBytes);

                    decryptedVaultContents += decryptedEntry + "\n-----------------------------------------\n";
                }
                MessageBox.Show(decryptedVaultContents, "Your Decrypted Password Vault");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error: " + ex.Message);
            }
        }

        private void vaultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearVaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordVaultManager.ClearVault();
            MessageBox.Show("Vault cleared successfully!");
        }
    }
}