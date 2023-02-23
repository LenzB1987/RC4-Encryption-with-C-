using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RC4_Encryption_with_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(txtInput.Text);
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                txtEncrypt.Text = stringBuilder.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(textBox4.Text);
            using (System.Security.Cryptography.SHA384CryptoServiceProvider md5 = new System.Security.Cryptography.SHA384CryptoServiceProvider())
            {
               //hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox3.Text = stringBuilder.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] hashBytes = Encoding.Unicode.GetBytes(textBox6.Text);
            using (System.Security.Cryptography.SHA1CryptoServiceProvider md5 = new System.Security.Cryptography.SHA1CryptoServiceProvider())
            {
                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox5.Text = stringBuilder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// generating sha256 encryption
            byte[] hashBytes = Encoding.Unicode.GetBytes(textBox2.Text);
            using (System.Security.Cryptography.SHA256CryptoServiceProvider md5 = new System.Security.Cryptography.SHA256CryptoServiceProvider())
            {
                hashBytes = md5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox1.Text = stringBuilder.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(textBox8.Text);
            using (System.Security.Cryptography.SHA256CryptoServiceProvider sHA256 = new System.Security.Cryptography.SHA256CryptoServiceProvider())
            {
                hashBytes = sHA256.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox7.Text = stringBuilder.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] hashBytes = Encoding.Unicode.GetBytes(textBox12.Text);
            using (System.Security.Cryptography.SHA512CryptoServiceProvider MD5 = new System.Security.Cryptography.SHA512CryptoServiceProvider())
            {
                hashBytes = MD5.ComputeHash(hashBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox11.Text = stringBuilder.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
