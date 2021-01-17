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
    public partial class frmOwnerShip : Form
    {
        public frmOwnerShip()
        {
            InitializeComponent();
        }
        private int numberOfRow = 0;
        private void frmOwnerShip_Load(object sender, EventArgs e)
        {

            int count = 0;
            if (Global.OwnerShips != null)
            {
                foreach (var item in Global.OwnerShips)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.CodeMeli
                            , item.Key, item.Id,item.TimeOfOwnership,item.Price);
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
