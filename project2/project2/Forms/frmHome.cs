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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private int numberOfRow = 0;
        private void frmHome_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Global.Homes != null)
            {
                foreach (var item in Global.Homes)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.CodeMeli
                            , item.Price, item.CodePosty,
                            item.Area,item.Address);
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
