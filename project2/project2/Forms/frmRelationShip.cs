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
    public partial class frmRelationShip : Form
    {
        public frmRelationShip()
        {
            InitializeComponent();
        }
        private int numberOfRow = 0;
        private void frmRelationShip_Load(object sender, EventArgs e)
        {

            int count = 0;
            if (Global.RelationShips != null)
            {
                foreach (var item in Global.RelationShips)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.From
                            , item.To, item.Relation, item.StartRelationDate);
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
