using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NoToText
{
    public partial class Form1 : Form
    {
        public String text;
        public String H4ZKey = "MarHazKHensem";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                text = txtIn.Text;
                text = text.Replace("9999", "Z");
                text = text.Replace("999", "Y");
                text = text.Replace("99", "X");
                text = text.Replace("9", "W");
                text = text.Replace("888", "V");
                text = text.Replace("88", "U");
                text = text.Replace("8", "T");
                text = text.Replace("7777", "S");
                text = text.Replace("777", "R");
                text = text.Replace("77", "Q");
                text = text.Replace("7", "P");
                text = text.Replace("666", "O");
                text = text.Replace("66", "N");
                text = text.Replace("6", "M");
                text = text.Replace("555", "L");
                text = text.Replace("55", "K");
                text = text.Replace("5", "J");
                text = text.Replace("444", "I");
                text = text.Replace("44", "H");
                text = text.Replace("4", "G");
                text = text.Replace("333", "F");
                text = text.Replace("33", "E");
                text = text.Replace("3", "D");
                text = text.Replace("222", "C");
                text = text.Replace("22", "B");
                text = text.Replace("2", "A");
                text = text.Replace("111", ".");
                text = text.Replace("1", ".");
                text = text.Replace("000", ".");
                text = text.Replace("00", ".");
                text = text.Replace("0", " ");
                txtOut.Text = text;
            }
            catch
            {
                MessageBox.Show("ERROR: Invalid Num Code");
            }
        }

        private void btnGen2_Click(object sender, EventArgs e)
        {
            text = txtIn.Text.ToUpper();
            text = text.Replace("A", "2");
            text = text.Replace("B", "22");
            text = text.Replace("C", "222");
            text = text.Replace("D", "3");
            text = text.Replace("E", "33");
            text = text.Replace("F", "333");
            text = text.Replace("G", "4");
            text = text.Replace("H", "44");
            text = text.Replace("I", "444");
            text = text.Replace("J", "5");
            text = text.Replace("K", "55");
            text = text.Replace("L", "555");
            text = text.Replace("M", "6");
            text = text.Replace("N", "66");
            text = text.Replace("O", "666");
            text = text.Replace("P", "7");
            text = text.Replace("Q", "77");
            text = text.Replace("R", "777");
            text = text.Replace("S", "7777");
            text = text.Replace("T", "8");
            text = text.Replace("U", "88");
            text = text.Replace("V", "888");
            text = text.Replace("W", "9");
            text = text.Replace("X", "99");
            text = text.Replace("Y", "999");
            text = text.Replace("Z", "9999");
            text = text.Replace(" ", "0");
            text = text.Replace(".", "00");
            txtOut.Text = text;
        }

        private void btnGen3_Click(object sender, EventArgs e)
        {
            try
            {
                text = txtIn.Text;
                byte[] raw = new byte[text.Length / 2];
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
                }

                text = Encoding.ASCII.GetString(raw);
                txtOut.Text = text;
            }
            catch
            {
                MessageBox.Show("ERROR: Invalid HEX Code");
            }

        }

        private void btnGen4_Click(object sender, EventArgs e)
        {
            Encoding encoding = new System.Text.UTF8Encoding();
            text = txtIn.Text;
            txtOut.Clear();
            int len = text.Length;
            byte[] textB = encoding.GetBytes(text);
            text = BitConverter.ToString(textB);
            txtOut.Text = text.ToString().Replace("-", "");
        }

        private void btnGen6_Click(object sender, EventArgs e)
        {

            text = txtIn.Text;
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(text);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            txtOut.Text = s.ToString();
        }

        private void btnGen5_Click(object sender, EventArgs e)
        {
            text = txtIn.Text;
            //string cipherText = text.Trim();
            //string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            //txtOut.Text = decryptedText;
            MessageBox.Show("Still under construction");
            //test = (byte)("0x"+Convert.ToByte(text));
        }
        public static string EncryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                int leng = DataToDecrypt.Length;
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, leng);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }

        private void btnHaz_Click(object sender, EventArgs e)
        {
            try
            {
                text = txtIn.Text.ToUpper();
                byte[] raw = new byte[text.Length / 2];
                //for (int i = 0; i < raw.Length; i++)
                //{
                //    raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
                //}

                //text = Encoding.ASCII.GetString(raw);

                //text = text.ToString().Replace("-", "");
                text = txtIn.Text.ToUpper();
                string key = H4ZKey;
                key = key.ToUpper();
                text = text.Replace("9999" + key, "Z");
                text = text.Replace("999" + key, "Y");
                text = text.Replace("99" + key, "X");
                text = text.Replace("9" + key, "W");
                text = text.Replace("888" + key, "V");
                text = text.Replace("88" + key, "U");
                text = text.Replace("8" + key, "T");
                text = text.Replace("7777" + key, "S");
                text = text.Replace("777" + key, "R");
                text = text.Replace("77" + key, "Q");
                text = text.Replace("7" + key, "P");
                text = text.Replace("666" + key, "O");
                text = text.Replace("66" + key, "N");
                text = text.Replace("6" + key, "M");
                text = text.Replace("555" + key, "L");
                text = text.Replace("55" + key, "K");
                text = text.Replace("5" + key, "J");
                text = text.Replace("444" + key, "I");
                text = text.Replace("44" + key, "H");
                text = text.Replace("4" + key, "G");
                text = text.Replace("333" + key, "F");
                text = text.Replace("33" + key, "E");
                text = text.Replace("3" + key, "D");
                text = text.Replace("222" + key, "C");
                text = text.Replace("22" + key, "B");
                text = text.Replace("2" + key, "A");
                text = text.Replace("111" + key, ".");
                text = text.Replace("1" + key, ".");
                text = text.Replace("000" + key, ".");
                text = text.Replace("00" + key, ".");
                text = text.Replace("0" + key, " ");
                text = text.ToString().Replace("-", "");
                raw = new byte[text.Length / 2];
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
                }

                text = Encoding.ASCII.GetString(raw);
                text = txtIn.Text.ToUpper();
                txtOut.Clear();
                txtOut.Text = text;
            }
            catch
            {
                MessageBox.Show("ERROR: Invalid HEX Code");
            }
        }

        private void btnDHaz_Click(object sender, EventArgs e)
        {

            text = txtIn.Text.ToUpper();
            Encoding encoding = new System.Text.UTF8Encoding();
            txtOut.Clear();
            int len = text.Length;
            byte[] textB = encoding.GetBytes(text);
            text = BitConverter.ToString(textB);
            text = txtIn.Text.ToUpper();
            text = text.ToString().Replace("-", "");
            text = text.Replace("A", "2" + H4ZKey);
            text = text.Replace("B", "22" + H4ZKey);
            text = text.Replace("C", "222" + H4ZKey);
            text = text.Replace("D", "3" + H4ZKey);
            text = text.Replace("E", "33" + H4ZKey);
            text = text.Replace("F", "333" + H4ZKey);
            text = text.Replace("G", "4" + H4ZKey);
            text = text.Replace("H", "44" + H4ZKey);
            text = text.Replace("I", "444" + H4ZKey);
            text = text.Replace("J", "5" + H4ZKey);
            text = text.Replace("K", "55" + H4ZKey);
            text = text.Replace("L", "555" + H4ZKey);
            text = text.Replace("M", "6" + H4ZKey);
            text = text.Replace("N", "66" + H4ZKey);
            text = text.Replace("O", "666" + H4ZKey);
            text = text.Replace("P", "7" + H4ZKey);
            text = text.Replace("Q", "77" + H4ZKey);
            text = text.Replace("R", "777" + H4ZKey);
            text = text.Replace("S", "7777" + H4ZKey);
            text = text.Replace("T", "8" + H4ZKey);
            text = text.Replace("U", "88" + H4ZKey);
            text = text.Replace("V", "888" + H4ZKey);
            text = text.Replace("W", "9" + H4ZKey);
            text = text.Replace("X", "99" + H4ZKey);
            text = text.Replace("Y", "999" + H4ZKey);
            text = text.Replace("Z", "9999" + H4ZKey);
            text = text.Replace(" ", "0" + H4ZKey);
            //text = text.Replace(".", "00" + H4ZKey);
            //encoding = new System.Text.UTF8Encoding();
            //txtOut.Clear();
            //len = text.Length;
            //textB = encoding.GetBytes(text);
            //text = BitConverter.ToString(textB);
            //text = text.ToString().Replace("-", "");
            text = text.ToLower();
            txtOut.Text = text;
        }
    }
}