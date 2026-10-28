namespace PasswordApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            vaultToolStripMenuItem = new ToolStripMenuItem();
            vaultSave = new ToolStripTextBox();
            viewSavedVaultToolStripMenuItem = new ToolStripMenuItem();
            clearVaultToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(209, 315);
            button2.Name = "button2";
            button2.Size = new Size(349, 44);
            button2.TabIndex = 1;
            button2.Text = "Copy to Clipboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(601, 237);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(180, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 59);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(169, 127);
            button1.Name = "button1";
            button1.Size = new Size(440, 72);
            button1.TabIndex = 4;
            button1.Text = "New Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(601, 214);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 7;
            label1.Text = "How long?";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { vaultToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // vaultToolStripMenuItem
            // 
            vaultToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vaultSave, viewSavedVaultToolStripMenuItem, clearVaultToolStripMenuItem });
            vaultToolStripMenuItem.Name = "vaultToolStripMenuItem";
            vaultToolStripMenuItem.Size = new Size(56, 24);
            vaultToolStripMenuItem.Text = "Vault";
            vaultToolStripMenuItem.Click += vaultToolStripMenuItem_Click;
            // 
            // vaultSave
            // 
            vaultSave.Name = "vaultSave";
            vaultSave.Size = new Size(243, 27);
            vaultSave.Text = "Save Password to Vault";
            vaultSave.Click += btnSave_Click;
            // 
            // viewSavedVaultToolStripMenuItem
            // 
            viewSavedVaultToolStripMenuItem.Name = "viewSavedVaultToolStripMenuItem";
            viewSavedVaultToolStripMenuItem.Size = new Size(317, 26);
            viewSavedVaultToolStripMenuItem.Text = "View Saved Vault";
            viewSavedVaultToolStripMenuItem.Click += viewSavedVaultToolStripMenuItem_Click;
            // 
            // clearVaultToolStripMenuItem
            // 
            clearVaultToolStripMenuItem.Name = "clearVaultToolStripMenuItem";
            clearVaultToolStripMenuItem.Size = new Size(317, 26);
            clearVaultToolStripMenuItem.Text = "Clear Vault";
            clearVaultToolStripMenuItem.Click += clearVaultToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Generate Password";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vaultToolStripMenuItem;
        private ToolStripMenuItem viewSavedVaultToolStripMenuItem;
        private ToolStripMenuItem clearVaultToolStripMenuItem;
        private ToolStripTextBox vaultSave;
    }
}
