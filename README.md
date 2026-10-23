**Secure C# Password Generator & Vault**
A sleek, lightweight, and secure Wind# for creating a strong password and safely storing it locally using OS-level encryption.

**Key Features**
>>Custom Password Generation: Generates a secure, randomized password that is customizable by length.
>>One-Click Clipboard Copying: Easily copy generated passwords to the system clipboard for immediate use.
>>Per User Local Vault Encryption: Uses Windows Data Protection API (DPAPI) (System.Security.Cryptography.ProtectedData) to encrypt passwords before writing to disk.
>>Zero Master Password Overhead: Encryption keys are tied directly to the Windows user account (No seperate master password required).
>>Streamlined UI: Minimalist interact featuring a clean MenuStrip dropdown bar to eliminate screen clutter.
>>On the Fly Decryption: Safely view stored vault items in app on demand.

**Sacurity Architecture**
Unlike simple password tools that store entries in plain text or rely on hardcoded applicaton keys, this vault uses Windows DPAPI (DataProtectionScope.CurrentUser).
>>Storage Location: Encrypted records are saved locally at Documents/PasswordAppVault/password_vault.txt.
>>Data Security: The stored data consists exclusively of Base64 encoded encrypted byte streams.
>>Access Control: Even if the file is moved or copied to another machine or user account, it cannot be decrypted without your specific Windows login credentials.

