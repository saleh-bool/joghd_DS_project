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
    public partial class frmSimPhone : Form
    {
        public frmSimPhone()
        {
            InitializeComponent();
        }
        private int numberOfRow = 0;
        private void frmSimPhone_Load(object sender, EventArgs e)
        {

            int count = 0;
            if (Global.SimPhones != null)
            {
                foreach (var item in Global.SimPhones)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.CodeMeli
                            , item.Number, item.OperatorName);
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
