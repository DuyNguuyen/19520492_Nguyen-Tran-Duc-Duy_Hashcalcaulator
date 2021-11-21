using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19520492_Nguyen_Tran_Duc_Duy_Hashcalcaulator
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_browser_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_file_data.Text = openFileDialog1.FileName.ToString();
            }
            Console.WriteLine(result);
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {

            string dataType = tabControl_Data_Input.SelectedTab.Name.ToString();
            switch (dataType)
            {
                case "tabPage_Text":
                    {
                        byte[]  dataBytes = Encoding.UTF8.GetBytes(textBox_text_data.Text.ToString().Trim());
                        HashCalculate(dataBytes);
                        break;
                    }
                case "tabPage_File":
                    {
                        string filename = textBox_file_data.Text.ToString().Trim();
                        try
                        {
                            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                            {
                                byte[] dataBytes = new byte[file.Length];
                                file.Read(dataBytes, 0, (int)file.Length);
                                HashCalculate(dataBytes);
                            }                          
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("File không hợp lệ\nVui lòng chọn lại", "Error");
                        }
                        break;
                    }
                case "tabPage_Hex":
                    {
                        string hex = textBox_hex_data.Text.ToString();
                        if (OnlyHexInString(hex))
                        {
                            try
                            {                               
                                byte[] dataBytes = Enumerable.Range(0, hex.Length)
                                    .Where(x => x % 2 == 0)
                                    .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                                    .ToArray();

                                HashCalculate(dataBytes);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Số kỹ tự chuỗi hex phải chẵn.", "Error");             
                            }
                        }
                        else
                        {                          
                            MessageBox.Show("Chuỗi nhập vào không phải chuỗi hex", "Error");                          
                        }
                        break;
                    }
            }

        }

        public bool OnlyHexInString(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public void HashCalculate(byte[] dataBytes)
        {
            using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                Byte[] hashBytes = md5.ComputeHash(dataBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox_MD5.Text = stringBuilder.ToString();
            }

            using (System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider())
            {
                Byte[] hashBytes = sha1.ComputeHash(dataBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox_SHA1.Text = stringBuilder.ToString();
            }

            using (System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider())
            {
                Byte[] hashBytes = sha1.ComputeHash(dataBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox_SHA1.Text = stringBuilder.ToString();
            }

            using (System.Security.Cryptography.SHA256CryptoServiceProvider sha256 = new System.Security.Cryptography.SHA256CryptoServiceProvider())
            {
                Byte[] hashBytes = sha256.ComputeHash(dataBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox_SHA256.Text = stringBuilder.ToString();
            }

            using (System.Security.Cryptography.SHA384CryptoServiceProvider sha384 = new System.Security.Cryptography.SHA384CryptoServiceProvider())
            {
                Byte[] hashBytes = sha384.ComputeHash(dataBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                    stringBuilder.Append(b.ToString("X2"));
                textBox_SHA384.Text = stringBuilder.ToString();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_file_data.Text = "";
            textBox_text_data.Text = "";
            textBox_hex_data.Text = "";
            textBox_MD5.Text = "";
            textBox_SHA1.Text = "";
            textBox_SHA256.Text = "";
            textBox_SHA384.Text = "";
        }

        private void textBox_SHA384_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

