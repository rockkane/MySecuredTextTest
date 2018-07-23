using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

namespace MySecuredTextTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            // Trim removes all the white space from the beginig and end of the string..
            // this is most important for Database.

            txtColorText.Text = Encrypt(txtPlain.Text.Trim(),txtKey.Text.Trim());

        }

        private void btnDecript_Click(object sender, EventArgs e)
        {
            txtPlain.Text = Decrypt(txtColorText.Text.Trim(), txtKey.Text.Trim());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static string Encrypt(string TextToBeEncripted, string PassWord)
        {// Access the manage version of the Rilndael algorithom.
            //This class cannot be inherited
            //Namespace :using System.Security.Cryptography;

            RijndaelManaged RijndaelCiper = new RijndaelManaged();

            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(TextToBeEncripted);
            byte[] Salt = Encoding.ASCII.GetBytes(PassWord.Length.ToString());
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(PassWord, Salt);

            //Symantic Encription Create

            ICryptoTransform Encryptor = RijndaelCiper.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream();

            //Cryptographic Transform

            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainText, 0, PlainText.Length);

            //Final State

            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();

            string EncryptedData = Convert.ToBase64String(CipherBytes);
            return EncryptedData;


        }



        public static string Decrypt(string TextToBeDecrypted, string Password)
        {
            // Access the managed version of the Rijndael algorithm.
            // This class cannot be inherit.
            // Namespace : using System.Security.Cryptography;

            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            string DecryptedData;

            try
            {
                byte[] EncryptedData = Convert.FromBase64String(TextToBeDecrypted);
                byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());
                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

                // Symetric Encryption Create
                ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
                MemoryStream memoryStream = new MemoryStream(EncryptedData);

                // Cryptographic  Transform (The stream contains decrypted data)
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

                byte[] PlainText = new byte[EncryptedData.Length];
                int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
                memoryStream.Close();
                cryptoStream.Close();

                // Converting to string
                DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            }

            catch
            {
                DecryptedData = TextToBeDecrypted;
            }

            return DecryptedData;
        }





    }
}
