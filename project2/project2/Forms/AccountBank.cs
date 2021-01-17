using project2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2.Forms
{
    public partial class frmAccountBank : Form
    {
        public frmAccountBank()
        {
            InitializeComponent();
        }
        private int numberOfRow = 0;
        private void AccountBank_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Global.Accounts != null)
            {
                foreach (var item in Global.Accounts)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.CodeMeli
                            , item.BankName, item.Shaba,
                            item.ShomareHesab);
                    count++;
                }
            }
            numberOfRow = count - 1;
        }
        public int GetNumberOfRow()
        {
            if (numberOfRow <= 0) return 0;
            return numberOfRow;
        }
    }
}

