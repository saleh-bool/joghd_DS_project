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
           
        }
    }
}
