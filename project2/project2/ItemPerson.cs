using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class ItemPerson : UserControl
    {
        public ItemPerson()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Set_Component(int number,string firstName, string LastName,
            string Code, string birthDate, string BirthPlace, string job)
        {
            lblCount.Text = number.ToString();
            FirstName.Text = firstName;
            lblLastName.Text = LastName;
            lblCode.Text = Code;
            lblBirthDate.Text = birthDate;
            lblBirthPlace.Text = BirthPlace;
            lblJob.Text = job;
        }
    }
}
