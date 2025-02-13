﻿namespace project2.Forms
{
    partial class frmRelationShip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.From,
            this.To,
            this.relation,
            this.connectionDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(179, 1280, 179, 1280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 900);
            this.dataGridView1.TabIndex = 8;
            // 
            // number
            // 
            this.number.HeaderText = "ردیف";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // From
            // 
            this.From.HeaderText = "کد ملی فرد اول";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.Width = 125;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To.HeaderText = "کد ملی فرد دوم";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            // 
            // relation
            // 
            this.relation.HeaderText = "نسبت";
            this.relation.MinimumWidth = 6;
            this.relation.Name = "relation";
            this.relation.Width = 125;
            // 
            // connectionDate
            // 
            this.connectionDate.HeaderText = "زمان شروع رابطه";
            this.connectionDate.MinimumWidth = 6;
            this.connectionDate.Name = "connectionDate";
            this.connectionDate.Width = 125;
            // 
            // frmRelationShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRelationShip";
            this.Text = "اطلاعات خویشاوندی";
            this.Load += new System.EventHandler(this.frmRelationShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDate;
    }
}