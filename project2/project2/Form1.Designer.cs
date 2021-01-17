namespace project2
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
            this.menu = new System.Windows.Forms.Panel();
            this.btnAddSim = new System.Windows.Forms.Button();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.btnAddHome = new System.Windows.Forms.Button();
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.addInfo = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.header.SuspendLayout();
            this.panelDesk.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.menu.Controls.Add(this.btnAddSim);
            this.menu.Controls.Add(this.btnAddCars);
            this.menu.Controls.Add(this.btnAddHome);
            this.menu.Controls.Add(this.btnAddAcount);
            this.menu.Controls.Add(this.btnAddPerson);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.btnPerson);
            this.menu.Controls.Add(this.panelIcon);
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(1237, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(302, 991);
            this.menu.TabIndex = 0;
            // 
            // btnAddSim
            // 
            this.btnAddSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnAddSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddSim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSim.FlatAppearance.BorderSize = 0;
            this.btnAddSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSim.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddSim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddSim.Image = global::project2.Properties.Resources.add_folder;
            this.btnAddSim.Location = new System.Drawing.Point(0, 890);
            this.btnAddSim.Name = "btnAddSim";
            this.btnAddSim.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddSim.Size = new System.Drawing.Size(302, 110);
            this.btnAddSim.TabIndex = 10;
            this.btnAddSim.Text = "اضافه کردن سیم کارت";
            this.btnAddSim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddSim.UseVisualStyleBackColor = false;
            this.btnAddSim.Visible = false;
            this.btnAddSim.Click += new System.EventHandler(this.btnAddSim_Click);
            // 
            // btnAddCars
            // 
            this.btnAddCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnAddCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCars.FlatAppearance.BorderSize = 0;
            this.btnAddCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCars.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCars.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCars.Image = global::project2.Properties.Resources.add_folder;
            this.btnAddCars.Location = new System.Drawing.Point(0, 780);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddCars.Size = new System.Drawing.Size(302, 110);
            this.btnAddCars.TabIndex = 9;
            this.btnAddCars.Text = "اضافه کردن ماشین ها";
            this.btnAddCars.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddCars.UseVisualStyleBackColor = false;
            this.btnAddCars.Visible = false;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // btnAddHome
            // 
            this.btnAddHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnAddHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHome.FlatAppearance.BorderSize = 0;
            this.btnAddHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHome.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddHome.Image = global::project2.Properties.Resources.add_folder;
            this.btnAddHome.Location = new System.Drawing.Point(0, 670);
            this.btnAddHome.Name = "btnAddHome";
            this.btnAddHome.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddHome.Size = new System.Drawing.Size(302, 110);
            this.btnAddHome.TabIndex = 8;
            this.btnAddHome.Text = "اضافه کردن خانه ها";
            this.btnAddHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddHome.UseVisualStyleBackColor = false;
            this.btnAddHome.Visible = false;
            this.btnAddHome.Click += new System.EventHandler(this.btnAddHome_Click);
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnAddAcount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAcount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAcount.FlatAppearance.BorderSize = 0;
            this.btnAddAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcount.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddAcount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddAcount.Image = global::project2.Properties.Resources.add_folder;
            this.btnAddAcount.Location = new System.Drawing.Point(0, 560);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddAcount.Size = new System.Drawing.Size(302, 110);
            this.btnAddAcount.TabIndex = 7;
            this.btnAddAcount.Text = "اضافه کردن حساب های بانکی";
            this.btnAddAcount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddAcount.UseVisualStyleBackColor = false;
            this.btnAddAcount.Visible = false;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPerson.Image = global::project2.Properties.Resources.add_folder;
            this.btnAddPerson.Location = new System.Drawing.Point(0, 450);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddPerson.Size = new System.Drawing.Size(302, 110);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "اضافه کردن شخص";
            this.btnAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Visible = false;
            this.btnAddPerson.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::project2.Properties.Resources.sim1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(0, 380);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.button4.Size = new System.Drawing.Size(302, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "اظلاعات شماره تلفن همراه";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::project2.Properties.Resources.home2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 310);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.button3.Size = new System.Drawing.Size(302, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "اطلاعات املاک مسکونی";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::project2.Properties.Resources.carin;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 240);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.button2.Size = new System.Drawing.Size(302, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "اطلاعات ماشین ها";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::project2.Properties.Resources.bank_account1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.button1.Size = new System.Drawing.Size(302, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "اطلاعات حساب های بانکی";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPerson.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerson.Image = global::project2.Properties.Resources.person3;
            this.btnPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerson.Location = new System.Drawing.Point(0, 100);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnPerson.Size = new System.Drawing.Size(302, 70);
            this.btnPerson.TabIndex = 1;
            this.btnPerson.Text = "اطلاعات اشخاص";
            this.btnPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPerson.UseVisualStyleBackColor = false;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.panelIcon.Controls.Add(this.label2);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(302, 100);
            this.panelIcon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SkaterDudes", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(102, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "OWL";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DimGray;
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1237, 72);
            this.header.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Narm", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(318, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "صفحه نخست";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesk
            // 
            this.panelDesk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesk.Controls.Add(this.statusPanel);
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(0, 72);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(1237, 919);
            this.panelDesk.TabIndex = 2;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.SlateGray;
            this.statusPanel.Controls.Add(this.lblStatus);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(0, 871);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1237, 48);
            this.statusPanel.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatus.Location = new System.Drawing.Point(1205, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 38);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "   ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1539, 991);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.panelIcon.ResumeLayout(false);
            this.panelIcon.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panelDesk.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.OpenFileDialog addInfo;
        private System.Windows.Forms.Button btnAddAcount;
        private System.Windows.Forms.Button btnAddSim;
        private System.Windows.Forms.Button btnAddCars;
        private System.Windows.Forms.Button btnAddHome;
    }
}

