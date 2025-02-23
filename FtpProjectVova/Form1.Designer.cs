namespace FtpProjectVova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.createFileTextBox = new System.Windows.Forms.TextBox();
            this.ftpString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtButtonCon = new System.Windows.Forms.Button();
            this.pathConString = new System.Windows.Forms.TextBox();
            this.loginSaveButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(959, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Instractions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create .txt File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "anonymous";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 26);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "user@example.com";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // createFileTextBox
            // 
            this.createFileTextBox.Location = new System.Drawing.Point(12, 432);
            this.createFileTextBox.Multiline = true;
            this.createFileTextBox.Name = "createFileTextBox";
            this.createFileTextBox.Size = new System.Drawing.Size(551, 30);
            this.createFileTextBox.TabIndex = 7;
            this.createFileTextBox.Text = "Here write your path to create .txt file (..\\..\\..\\text.txt)";
            this.createFileTextBox.TextChanged += new System.EventHandler(this.createFileTextBox_TextChanged);
            // 
            // ftpString
            // 
            this.ftpString.Location = new System.Drawing.Point(12, 221);
            this.ftpString.Multiline = true;
            this.ftpString.Name = "ftpString";
            this.ftpString.Size = new System.Drawing.Size(551, 37);
            this.ftpString.TabIndex = 8;
            this.ftpString.Text = "Here write your connection to FTP server";
            this.ftpString.TextChanged += new System.EventHandler(this.ftpString_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "FTP Link";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtButtonCon
            // 
            this.txtButtonCon.Location = new System.Drawing.Point(12, 390);
            this.txtButtonCon.Name = "txtButtonCon";
            this.txtButtonCon.Size = new System.Drawing.Size(154, 36);
            this.txtButtonCon.TabIndex = 12;
            this.txtButtonCon.Text = "Connect to .txt";
            this.txtButtonCon.UseMnemonic = false;
            this.txtButtonCon.UseVisualStyleBackColor = true;
            this.txtButtonCon.Click += new System.EventHandler(this.txtButtonCon_Click);
            // 
            // pathConString
            // 
            this.pathConString.Location = new System.Drawing.Point(12, 358);
            this.pathConString.Name = "pathConString";
            this.pathConString.Size = new System.Drawing.Size(551, 26);
            this.pathConString.TabIndex = 13;
            this.pathConString.Text = "Here write your .txt path";
            // 
            // loginSaveButt
            // 
            this.loginSaveButt.Location = new System.Drawing.Point(101, 131);
            this.loginSaveButt.Name = "loginSaveButt";
            this.loginSaveButt.Size = new System.Drawing.Size(130, 32);
            this.loginSaveButt.TabIndex = 14;
            this.loginSaveButt.Text = "Save Login";
            this.loginSaveButt.UseVisualStyleBackColor = true;
            this.loginSaveButt.Click += new System.EventHandler(this.loginSaveButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 600);
            this.Controls.Add(this.loginSaveButt);
            this.Controls.Add(this.pathConString);
            this.Controls.Add(this.txtButtonCon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ftpString);
            this.Controls.Add(this.createFileTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FTP Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox createFileTextBox;
        private System.Windows.Forms.TextBox ftpString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button txtButtonCon;
        private System.Windows.Forms.TextBox pathConString;
        private System.Windows.Forms.Button loginSaveButt;
    }
}

