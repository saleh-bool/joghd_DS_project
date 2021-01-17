using project2.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        private Button buttonSelected;
        private Form currentForm;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void ActiveButton(object btn , int colorIndex)
        {
            if(btn!=null)
            {
                DisableButton();
                if(btn!=buttonSelected)
                {
                    Color color = ColorTranslator.FromHtml(Theme.ColorTheme[colorIndex]);
                    buttonSelected = (Button)btn;
                    buttonSelected.BackColor = color;
                    buttonSelected.ForeColor = Color.White;
                    buttonSelected.Font = new System.Drawing.Font("B Koodak", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    header.BackColor = color;
                    color = Color.FromArgb(color.R-20, color.G-18, color.B-10);
                    panelIcon.BackColor = color;
                }
            }
        }
        public void DisableButton()
        {
            foreach (Control item in menu.Controls)
            {
                if(item.GetType()== typeof(Button))
                {
                    item.BackColor = Color.FromArgb(46, 46, 67);
                    item.ForeColor = Color.Gainsboro;
                    item.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

                }
            }
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 0);
            index = 0;
            if (header.BackColor.R<150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 1);
            index = 1;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 2);
            index = 2;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 3);
            index = 3;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 4);
            index = 4;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void OpenNewForm(Form frm , object btn)
        {
            if (frm == null)
                frm.Close();
            ActiveButton(btn,index);
            currentForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(frm);
            this.panelDesk.Tag = frm;
            frm.BringToFront();
            frm.Show();
            lblTitle.Text = frm.Text;
        }

    }
}
