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
        private int distanceY = 75;
        private int count = 0;
        private void ListPeaple_Paint(object sender, PaintEventArgs e)
        {
            if(Global.Peaple!=null)
            {
                foreach (var item in Global.Peaple)
                {
                    count++;
                    ItemPerson person = new ItemPerson();
                    person.Set_Component(count, item.FirstName, item.LastName,item.Code, item.BirthDate, item.BirthPlace, item.Job);
                    person.Dock = DockStyle.Top;
                }
            }
        }
    }
}
