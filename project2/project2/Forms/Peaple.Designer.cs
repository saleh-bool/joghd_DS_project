namespace project2
{
    partial class Peaple
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
            this.ListPeaple = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListPeaple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListPeaple
            // 
            this.ListPeaple.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListPeaple.Controls.Add(this.dataGridView1);
            this.ListPeaple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPeaple.Location = new System.Drawing.Point(0, 0);
            this.ListPeaple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListPeaple.Name = "ListPeaple";
            this.ListPeaple.Size = new System.Drawing.Size(929, 664);
            this.ListPeaple.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.FirstName,
            this.LastName,
            this.Code,
            this.BirthDate,
            this.BirthPlace,
            this.Job});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 664);
            this.dataGridView1.TabIndex = 0;
            // 
            // number
            // 
            this.number.HeaderText = "ردیف";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "نام";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Code
            // 
            this.Code.HeaderText = "کد ملی";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "تاریخ نولد";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 125;
            // 
            // BirthPlace
            // 
            this.BirthPlace.HeaderText = "محل تولد";
            this.BirthPlace.MinimumWidth = 6;
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Width = 125;
            // 
            // Job
            // 
            this.Job.HeaderText = "شغل";
            this.Job.MinimumWidth = 6;
            this.Job.Name = "Job";
            this.Job.Width = 125;
            // 
            // Peaple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 664);
            this.Controls.Add(this.ListPeaple);
            this.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Peaple";
            this.Text = "اطلاعات افراد";
            this.Load += new System.EventHandler(this.Peaple_Load);
            this.ListPeaple.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ListPeaple;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
    }
}