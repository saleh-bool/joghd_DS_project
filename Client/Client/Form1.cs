using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 0;
        private int YLocate = 35;
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnPersonInfo.BackColor = Color.Turquoise;
            btnPersonInfo.ForeColor = Color.Black;
        }

        private void btnPersonInfo_MouseLeave(object sender, EventArgs e)
        {
            btnPersonInfo.BackColor = Color.Teal;
            btnPersonInfo.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            panel3.Width = (this.Width*2)/ 3;   
        }

        private void btnBankAccount_MouseHover(object sender, EventArgs e)
        {
            btnBankAccount.BackColor = Color.Turquoise;
            btnBankAccount.ForeColor = Color.Black;
        }

        private void btnBankAccount_MouseLeave(object sender, EventArgs e)
        {
            btnBankAccount.BackColor = Color.Teal;
            btnBankAccount.ForeColor = Color.White;
        }

        private void btnHomeInfo_MouseHover(object sender, EventArgs e)
        {
            btnHomeInfo.BackColor = Color.Turquoise;
            btnHomeInfo.ForeColor = Color.Black;
        }

        private void btnHomeInfo_MouseLeave(object sender, EventArgs e)
        {
            btnHomeInfo.BackColor = Color.Teal;
            btnHomeInfo.ForeColor = Color.White;
        }

        private void btnCarInfo_MouseHover(object sender, EventArgs e)
        {
            btnCarInfo.BackColor = Color.Turquoise;
            btnCarInfo.ForeColor = Color.Black;
        }

        private void btnCarInfo_MouseLeave(object sender, EventArgs e)
        {
            btnCarInfo.BackColor = Color.Teal;
            btnCarInfo.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnCimInfo.BackColor = Color.Turquoise;
            btnCimInfo.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnCimInfo.BackColor = Color.Teal;
            btnCimInfo.ForeColor = Color.White;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            count++;
            Item it = new Item();
            it.Location = new Point(130, YLocate);
            YLocate += it.Height + 20;
            it.Set_Component(count);
            panel3.Controls.Add(it);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
