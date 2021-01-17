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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListPeaple = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 58);
            this.panel1.TabIndex = 0;
            // 
            // ListPeaple
            // 
            this.ListPeaple.BackColor = System.Drawing.SystemColors.Highlight;
            this.ListPeaple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPeaple.Location = new System.Drawing.Point(0, 58);
            this.ListPeaple.Name = "ListPeaple";
            this.ListPeaple.Size = new System.Drawing.Size(1057, 560);
            this.ListPeaple.TabIndex = 1;
            // 
            // Peaple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 618);
            this.Controls.Add(this.ListPeaple);
            this.Controls.Add(this.panel1);
            this.Name = "Peaple";
            this.Text = "Peaple";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ListPeaple;
    }
}