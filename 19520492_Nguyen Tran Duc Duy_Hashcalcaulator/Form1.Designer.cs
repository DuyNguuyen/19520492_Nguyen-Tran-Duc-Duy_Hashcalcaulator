
namespace _19520492_Nguyen_Tran_Duc_Duy_Hashcalcaulator
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Data_Input = new System.Windows.Forms.TabControl();
            this.tabPage_Text = new System.Windows.Forms.TabPage();
            this.textBox_text_data = new System.Windows.Forms.TextBox();
            this.tabPage_Hex = new System.Windows.Forms.TabPage();
            this.textBox_hex_data = new System.Windows.Forms.TextBox();
            this.tabPage_File = new System.Windows.Forms.TabPage();
            this.button_browser = new System.Windows.Forms.Button();
            this.textBox_file_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MD5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SHA1 = new System.Windows.Forms.TextBox();
            this.textBox_SHA256 = new System.Windows.Forms.TextBox();
            this.textBox_SHA384 = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_Data_Input.SuspendLayout();
            this.tabPage_Text.SuspendLayout();
            this.tabPage_Hex.SuspendLayout();
            this.tabPage_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Data_Input
            // 
            this.tabControl_Data_Input.Controls.Add(this.tabPage_Text);
            this.tabControl_Data_Input.Controls.Add(this.tabPage_Hex);
            this.tabControl_Data_Input.Controls.Add(this.tabPage_File);
            this.tabControl_Data_Input.Location = new System.Drawing.Point(179, 12);
            this.tabControl_Data_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Data_Input.Name = "tabControl_Data_Input";
            this.tabControl_Data_Input.SelectedIndex = 0;
            this.tabControl_Data_Input.Size = new System.Drawing.Size(1331, 133);
            this.tabControl_Data_Input.TabIndex = 0;
            // 
            // tabPage_Text
            // 
            this.tabPage_Text.Controls.Add(this.textBox_text_data);
            this.tabPage_Text.Location = new System.Drawing.Point(10, 48);
            this.tabPage_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Text.Name = "tabPage_Text";
            this.tabPage_Text.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Text.Size = new System.Drawing.Size(1311, 75);
            this.tabPage_Text.TabIndex = 0;
            this.tabPage_Text.Text = "Text";
            this.tabPage_Text.UseVisualStyleBackColor = true;
            this.tabPage_Text.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox_text_data
            // 
            this.textBox_text_data.Location = new System.Drawing.Point(24, 20);
            this.textBox_text_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_text_data.Name = "textBox_text_data";
            this.textBox_text_data.Size = new System.Drawing.Size(1280, 38);
            this.textBox_text_data.TabIndex = 0;
            // 
            // tabPage_Hex
            // 
            this.tabPage_Hex.Controls.Add(this.textBox_hex_data);
            this.tabPage_Hex.Location = new System.Drawing.Point(10, 48);
            this.tabPage_Hex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Hex.Name = "tabPage_Hex";
            this.tabPage_Hex.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Hex.Size = new System.Drawing.Size(1311, 65);
            this.tabPage_Hex.TabIndex = 1;
            this.tabPage_Hex.Text = "Hex";
            this.tabPage_Hex.UseVisualStyleBackColor = true;
            // 
            // textBox_hex_data
            // 
            this.textBox_hex_data.Location = new System.Drawing.Point(24, 20);
            this.textBox_hex_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hex_data.Name = "textBox_hex_data";
            this.textBox_hex_data.Size = new System.Drawing.Size(1280, 38);
            this.textBox_hex_data.TabIndex = 1;
            // 
            // tabPage_File
            // 
            this.tabPage_File.Controls.Add(this.button_browser);
            this.tabPage_File.Controls.Add(this.textBox_file_data);
            this.tabPage_File.Location = new System.Drawing.Point(10, 48);
            this.tabPage_File.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_File.Name = "tabPage_File";
            this.tabPage_File.Size = new System.Drawing.Size(1311, 65);
            this.tabPage_File.TabIndex = 2;
            this.tabPage_File.Text = "File";
            this.tabPage_File.UseVisualStyleBackColor = true;
            // 
            // button_browser
            // 
            this.button_browser.Location = new System.Drawing.Point(1160, 9);
            this.button_browser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_browser.Name = "button_browser";
            this.button_browser.Size = new System.Drawing.Size(144, 64);
            this.button_browser.TabIndex = 3;
            this.button_browser.Text = "Browser";
            this.button_browser.UseVisualStyleBackColor = true;
            this.button_browser.Click += new System.EventHandler(this.button_browser_Click);
            // 
            // textBox_file_data
            // 
            this.textBox_file_data.Location = new System.Drawing.Point(24, 20);
            this.textBox_file_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_file_data.Name = "textBox_file_data";
            this.textBox_file_data.Size = new System.Drawing.Size(1120, 38);
            this.textBox_file_data.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHA-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "SHA-256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "SHA-384";
            // 
            // textBox_MD5
            // 
            this.textBox_MD5.Location = new System.Drawing.Point(213, 274);
            this.textBox_MD5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MD5.Name = "textBox_MD5";
            this.textBox_MD5.ReadOnly = true;
            this.textBox_MD5.Size = new System.Drawing.Size(1280, 38);
            this.textBox_MD5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data";
            // 
            // textBox_SHA1
            // 
            this.textBox_SHA1.Location = new System.Drawing.Point(213, 346);
            this.textBox_SHA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SHA1.Name = "textBox_SHA1";
            this.textBox_SHA1.ReadOnly = true;
            this.textBox_SHA1.Size = new System.Drawing.Size(1280, 38);
            this.textBox_SHA1.TabIndex = 7;
            // 
            // textBox_SHA256
            // 
            this.textBox_SHA256.Location = new System.Drawing.Point(213, 427);
            this.textBox_SHA256.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SHA256.Name = "textBox_SHA256";
            this.textBox_SHA256.ReadOnly = true;
            this.textBox_SHA256.Size = new System.Drawing.Size(1280, 38);
            this.textBox_SHA256.TabIndex = 8;
            // 
            // textBox_SHA384
            // 
            this.textBox_SHA384.Location = new System.Drawing.Point(213, 491);
            this.textBox_SHA384.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SHA384.Name = "textBox_SHA384";
            this.textBox_SHA384.ReadOnly = true;
            this.textBox_SHA384.Size = new System.Drawing.Size(1280, 38);
            this.textBox_SHA384.TabIndex = 9;
            this.textBox_SHA384.TextChanged += new System.EventHandler(this.textBox_SHA384_TextChanged);
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(729, 179);
            this.button_calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(176, 50);
            this.button_calculate.TabIndex = 10;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(910, 179);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(115, 50);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1522, 613);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.textBox_SHA384);
            this.Controls.Add(this.textBox_SHA256);
            this.Controls.Add(this.textBox_SHA1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_MD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl_Data_Input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.Text = "19520492_Hash Caculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Data_Input.ResumeLayout(false);
            this.tabPage_Text.ResumeLayout(false);
            this.tabPage_Text.PerformLayout();
            this.tabPage_Hex.ResumeLayout(false);
            this.tabPage_Hex.PerformLayout();
            this.tabPage_File.ResumeLayout(false);
            this.tabPage_File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Data_Input;
        private System.Windows.Forms.TabPage tabPage_Text;
        private System.Windows.Forms.TabPage tabPage_Hex;
        private System.Windows.Forms.TabPage tabPage_File;
        private System.Windows.Forms.TextBox textBox_text_data;
        private System.Windows.Forms.TextBox textBox_hex_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MD5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SHA1;
        private System.Windows.Forms.TextBox textBox_SHA256;
        private System.Windows.Forms.TextBox textBox_SHA384;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_browser;
        private System.Windows.Forms.TextBox textBox_file_data;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

