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

namespace project2
{
    public partial class Peaple : Form
    {
        public Peaple()
        {
            InitializeComponent();
        }
        int numberOfRow = 0;
        private void Peaple_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Global.Peaple != null)
            {
                foreach (var item in Global.Peaple)
                {
                    if (count != 0)
                        this.dataGridView1.Rows.Add(count.ToString(), item.FirstName, item.LastName, item.Code,
                            item.BirthDate, item.BirthPlace, item.Job);
                    count++;
                }
            }
            numberOfRow = count-1;
        }
        public int GetNumberOfRow()
        {
            return numberOfRow;
        }
    }
}
