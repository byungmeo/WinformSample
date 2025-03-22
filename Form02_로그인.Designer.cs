namespace WindowsFormsApp1
{
    partial class Form02_로그인
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form02_로그인));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_phoneLogin = new System.Windows.Forms.RadioButton();
            this.radioButton_emailLogin = new System.Windows.Forms.RadioButton();
            this.radioButton_idLogin = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s corail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 8);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 8);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 8);
            this.label4.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_id.Location = new System.Drawing.Point(25, 167);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(30, 22);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "PW";
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(115, 167);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(224, 21);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_pw
            // 
            this.textBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pw.Location = new System.Drawing.Point(115, 211);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(224, 21);
            this.textBox_pw.TabIndex = 7;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Blue;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(360, 167);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(92, 65);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_phoneLogin);
            this.panel1.Controls.Add(this.radioButton_emailLogin);
            this.panel1.Controls.Add(this.radioButton_idLogin);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 50);
            this.panel1.TabIndex = 9;
            // 
            // radioButton_phoneLogin
            // 
            this.radioButton_phoneLogin.AutoSize = true;
            this.radioButton_phoneLogin.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_phoneLogin.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_phoneLogin.Location = new System.Drawing.Point(312, 17);
            this.radioButton_phoneLogin.Name = "radioButton_phoneLogin";
            this.radioButton_phoneLogin.Size = new System.Drawing.Size(127, 19);
            this.radioButton_phoneLogin.TabIndex = 2;
            this.radioButton_phoneLogin.Text = "휴대폰 로그인";
            this.radioButton_phoneLogin.UseVisualStyleBackColor = true;
            this.radioButton_phoneLogin.CheckedChanged += new System.EventHandler(this.radioButton_phoneLogin_CheckedChanged);
            // 
            // radioButton_emailLogin
            // 
            this.radioButton_emailLogin.AutoSize = true;
            this.radioButton_emailLogin.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_emailLogin.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_emailLogin.Location = new System.Drawing.Point(161, 17);
            this.radioButton_emailLogin.Name = "radioButton_emailLogin";
            this.radioButton_emailLogin.Size = new System.Drawing.Size(118, 19);
            this.radioButton_emailLogin.TabIndex = 1;
            this.radioButton_emailLogin.Text = "Email 로그인";
            this.radioButton_emailLogin.UseVisualStyleBackColor = true;
            this.radioButton_emailLogin.CheckedChanged += new System.EventHandler(this.radioButton_emailLogin_CheckedChanged);
            // 
            // radioButton_idLogin
            // 
            this.radioButton_idLogin.AutoSize = true;
            this.radioButton_idLogin.Checked = true;
            this.radioButton_idLogin.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_idLogin.ForeColor = System.Drawing.Color.Blue;
            this.radioButton_idLogin.Location = new System.Drawing.Point(26, 17);
            this.radioButton_idLogin.Name = "radioButton_idLogin";
            this.radioButton_idLogin.Size = new System.Drawing.Size(94, 19);
            this.radioButton_idLogin.TabIndex = 0;
            this.radioButton_idLogin.TabStop = true;
            this.radioButton_idLogin.Text = "ID 로그인";
            this.radioButton_idLogin.UseVisualStyleBackColor = true;
            this.radioButton_idLogin.CheckedChanged += new System.EventHandler(this.radioButton_idLogin_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "로그인";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_idLogin;
        private System.Windows.Forms.RadioButton radioButton_phoneLogin;
        private System.Windows.Forms.RadioButton radioButton_emailLogin;
    }
}