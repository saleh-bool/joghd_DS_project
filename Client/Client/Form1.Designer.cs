namespace Client
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonInfo = new System.Windows.Forms.Button();
            this.btnBankAccount = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCarInfo = new System.Windows.Forms.Button();
            this.btnHomeInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnHomeInfo);
            this.panel1.Controls.Add(this.btnCarInfo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBankAccount);
            this.panel1.Controls.Add(this.btnPersonInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(883, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 704);
            this.panel1.TabIndex = 0;
            // 
            // btnPersonInfo
            // 
            this.btnPersonInfo.BackColor = System.Drawing.Color.Teal;
            this.btnPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfo.Font = new System.Drawing.Font("B Mitra", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)), true);
            this.btnPersonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.btnPersonInfo.Name = "btnPersonInfo";
            this.btnPersonInfo.Size = new System.Drawing.Size(288, 77);
            this.btnPersonInfo.TabIndex = 1;
            this.btnPersonInfo.Text = "اطلاعات اشخاص";
            this.btnPersonInfo.UseVisualStyleBackColor = false;
            this.btnPersonInfo.MouseLeave += new System.EventHandler(this.btnPersonInfo_MouseLeave);
            this.btnPersonInfo.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnBankAccount
            // 
            this.btnBankAccount.BackColor = System.Drawing.Color.Teal;
            this.btnBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBankAccount.Font = new System.Drawing.Font("B Mitra", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)), true);
            this.btnBankAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBankAccount.Location = new System.Drawing.Point(0, 76);
            this.btnBankAccount.Name = "btnBankAccount";
            this.btnBankAccount.Size = new System.Drawing.Size(288, 77);
            this.btnBankAccount.TabIndex = 2;
            this.btnBankAccount.Text = "حساب بانکی";
            this.btnBankAccount.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Mitra", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)), true);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "اطلاعات شماره تلفن همراه";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnCarInfo
            // 
            this.btnCarInfo.BackColor = System.Drawing.Color.Teal;
            this.btnCarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarInfo.Font = new System.Drawing.Font("B Mitra", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)), true);
            this.btnCarInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarInfo.Location = new System.Drawing.Point(0, 228);
            this.btnCarInfo.Name = "btnCarInfo";
            this.btnCarInfo.Size = new System.Drawing.Size(288, 77);
            this.btnCarInfo.TabIndex = 4;
            this.btnCarInfo.Text = "اطلاعات ماشین ها";
            this.btnCarInfo.UseVisualStyleBackColor = false;
            // 
            // btnHomeInfo
            // 
            this.btnHomeInfo.BackColor = System.Drawing.Color.Teal;
            this.btnHomeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomeInfo.Font = new System.Drawing.Font("B Mitra", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)), true);
            this.btnHomeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeInfo.Location = new System.Drawing.Point(0, 152);
            this.btnHomeInfo.Name = "btnHomeInfo";
            this.btnHomeInfo.Size = new System.Drawing.Size(288, 77);
            this.btnHomeInfo.TabIndex = 5;
            this.btnHomeInfo.Text = "اطلاعات املاک مسکونی";
            this.btnHomeInfo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1171, 704);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPersonInfo;
        private System.Windows.Forms.Button btnHomeInfo;
        private System.Windows.Forms.Button btnCarInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBankAccount;
    }
}

