namespace WindowsFormsApp1
{
    partial class Form08_좌석배치도
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form08_좌석배치도));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(687, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = "Let\'s corail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 8);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 8);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 8);
            this.label2.TabIndex = 12;
            // 
            // label_top
            // 
            this.label_top.BackColor = System.Drawing.Color.Blue;
            this.label_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_top.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_top.ForeColor = System.Drawing.Color.Yellow;
            this.label_top.Location = new System.Drawing.Point(0, 75);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(687, 48);
            this.label_top.TabIndex = 15;
            this.label_top.Text = "1호차";
            this.label_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(87, 152);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(513, 165);
            this.flowLayoutPanel.TabIndex = 17;
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_left.Enabled = false;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_left.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_left.ForeColor = System.Drawing.Color.Yellow;
            this.button_left.Location = new System.Drawing.Point(-1, 152);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(47, 165);
            this.button_left.TabIndex = 18;
            this.button_left.Text = "1";
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Visible = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_right.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_right.ForeColor = System.Drawing.Color.Yellow;
            this.button_right.Location = new System.Drawing.Point(641, 152);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(47, 165);
            this.button_right.TabIndex = 19;
            this.button_right.Text = "2";
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // label_left
            // 
            this.label_left.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_left.Location = new System.Drawing.Point(46, 227);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(41, 13);
            this.label_left.TabIndex = 20;
            this.label_left.Visible = false;
            // 
            // label_right
            // 
            this.label_right.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_right.Location = new System.Drawing.Point(600, 227);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(41, 13);
            this.label_right.TabIndex = 21;
            // 
            // Form좌석배치도
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 379);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_top);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form좌석배치도";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "좌석배치도";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
    }
}