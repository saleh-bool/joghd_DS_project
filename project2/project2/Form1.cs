﻿using project2.Class;
using project2.Forms;
using project2.Help;
using project2.Model;
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
    public partial class Form1 : Form
    {
        private Button buttonSelected;
        private Form currentForm;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void ActiveButton(object btn, int colorIndex)
        {
            if (btn != null)
            {
                DisableButton();
                if (btn != buttonSelected)
                {
                    Color color = ColorTranslator.FromHtml(Theme.ColorTheme[colorIndex]);
                    buttonSelected = (Button)btn;
                    buttonSelected.BackColor = color;
                    buttonSelected.ForeColor = Color.White;
                    buttonSelected.Font = new System.Drawing.Font("B Koodak", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    header.BackColor = color;
                    color = Color.FromArgb(color.R - 20>0? color.R - 20:0, color.G - 18>0? color.G - 18:0, color.B - 10>0? color.B - 10:0);
                    panelIcon.BackColor = color;
                }
            }
        }
        public void DisableButton()
        {
            foreach (Control item in menu.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.BackColor = Color.FromArgb(46, 46, 67);
                    item.ForeColor = Color.Gainsboro;
                    item.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

                }
            }
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 0);
            index = 0;
            Peaple peapleForm = new Peaple();
            OpenNewForm(peapleForm);
            lblStatus.Text = "تعداد افراد یافت شده : " + peapleForm.GetNumberOfRow().ToString();

            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            ShowAdder(btnAddPerson);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 1);
            frmAccountBank accountForm = new frmAccountBank();
            OpenNewForm(accountForm);
            index = 1;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;

            ShowAdder(btnAddAcount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 2);
            frmCar carForm = new frmCar();
            OpenNewForm(carForm);
            index = 2;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            btnAddPerson.Visible = false;
            ShowAdder(btnAddCars);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 3);
            frmHome homeForm = new frmHome();
            OpenNewForm(homeForm);
            index = 3;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            btnAddPerson.Visible = false;
            ShowAdder(btnAddHome);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 4);
            frmSimPhone simForm = new frmSimPhone();
            OpenNewForm(simForm);
            index = 4;
            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            btnAddPerson.Visible = false;
            ShowAdder(btnAddSim);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void OpenNewForm(Form frm)
        {
            if (frm == null)
                frm.Close();
            currentForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(frm);
            this.panelDesk.Tag = frm;
            frm.BringToFront();
            frm.Show();
            lblTitle.Text = frm.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    Person item = new Person();
                    item.FirstName = par[0].Replace("\"", "");
                    item.LastName = par[1].Replace("\"", "");
                    item.Code = par[2].Replace("\"", "");
                    item.BirthDate = par[3].Replace("\"", "");
                    item.BirthPlace = par[4].Replace("\"", "");
                    item.Job = par[5].Replace("\"", "");
                    Global.Peaple.Add(item);
                }
                lblStatus.Text = "";
                Peaple peapleForm = new Peaple();
                OpenNewForm(peapleForm);
                lblStatus.Text = "تعداد افراد یافت شده : " + peapleForm.GetNumberOfRow().ToString();

            }

        }
        public void ShowAdder(Button button)
        {
            foreach (Button item in menu.Controls.OfType<Button>())
            {
                if (!item.Name.Contains("Add") || item == button)
                    item.Visible = true;
                else
                    item.Visible = false;
            }
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {

            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    BankAccount item = new BankAccount();
                    item.CodeMeli = par[0].Replace("\"", "");
                    item.BankName = par[1].Replace("\"", "");
                    item.Shaba = par[2].Replace("\"", "");
                    item.ShomareHesab = par[3].Replace("\"", "");
                    Global.Accounts.Add(item);
                }
                lblStatus.Text = "";
                frmAccountBank acountForm = new frmAccountBank();
                OpenNewForm(acountForm);
                lblStatus.Text = "تعداد حساب های بانکی یافت شده : " + acountForm.GetNumberOfRow().ToString();

            }
        }

        private void btnAddHome_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    Home item = new Home();
                    item.CodeMeli = par[0].Replace("\"", "");
                    item.Price = par[1].Replace("\"", "");
                    item.CodePosty = par[2].Replace("\"", "");
                    item.Area = par[3].Replace("\"", "");
                    item.Address = par[3].Replace("\"", "");
                    Global.Homes.Add(item);
                }
                lblStatus.Text = "";
                frmHome homeForm = new frmHome();
                OpenNewForm(homeForm);
                lblStatus.Text = "تعداد خانه یافت شده : " + homeForm.GetNumberOfRow().ToString();
            }
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    Car item = new Car();
                    item.Plate = par[0].Replace("\"", "");
                    item.CodeMeli = par[1].Replace("\"", "");
                    item.Mode = par[2].Replace("\"", "");
                    item.Color = par[3].Replace("\"", "");
                    Global.cars.Add(item);
                }
                lblStatus.Text = "";
                frmCar carForm = new frmCar();
                OpenNewForm(carForm);
                lblStatus.Text = "تعداد ماشین ها یافت شده : " + carForm.GetNumberOfRow().ToString();
            }
        }

        private void btnAddSim_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    SimPhone item = new SimPhone();
                    item.CodeMeli = par[0].Replace("\"", "");
                    item.Number = par[1].Replace("\"", "");
                    item.OperatorName = par[2].Replace("\"", "");
                    Global.SimPhones.Add(item);
                }
                lblStatus.Text = "";
                frmSimPhone simForm = new frmSimPhone();
                OpenNewForm(simForm);
                lblStatus.Text = "تعداد سیم کارت های یافت شده : " + simForm.GetNumberOfRow().ToString();
            }
        }

        private void btnRelationShip_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 5);
            index = 5;
            frmOwnerShip ownerShipForm = new frmOwnerShip();
            OpenNewForm(ownerShipForm);
            lblStatus.Text = "تعداد اطلاعات یافت شده : " + ownerShipForm.GetNumberOfRow().ToString();

            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            ShowAdder(btnAddOwner);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    OwnerShip item = new OwnerShip();
                    item.CodeMeli = par[0].Replace("\"", "");
                    item.Key = par[1].Replace("\"", "");
                    item.Id = par[2].Replace("\"", "");
                    item.TimeOfOwnership = par[3].Replace("\"", "");
                    item.Price = par[4].Replace("\"", "");
                    Global.OwnerShips.Add(item);
                }
                lblStatus.Text = "";
                frmOwnerShip ownerForm = new frmOwnerShip();
                OpenNewForm(ownerForm);
                lblStatus.Text = "تعداد اطلاعات یافت شده : " + ownerForm.GetNumberOfRow().ToString();
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    Transaction item = new Transaction();
                    item.From = par[0].Replace("\"", "");
                    item.To = par[1].Replace("\"", "");
                    item.Id = par[2].Replace("\"", "");
                    item.TransactionsTime = par[3].Replace("\"", "");
                    item.Price = par[4].Replace("\"", "");
                    Global.Transactions.Add(item);
                }
                lblStatus.Text = "";
                frmTransaction callForm = new frmTransaction();
                OpenNewForm(callForm);
                lblStatus.Text = "تعداد اطلاعات تراکنش یافت شده : " + callForm.GetNumberOfRow().ToString();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 6);
            index = 6;
            frmTransaction TransactionForm = new frmTransaction();
            OpenNewForm(TransactionForm);
            lblStatus.Text = "تعداد اطلاعات تراکنش یافت شده : " + TransactionForm.GetNumberOfRow().ToString();

            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            ShowAdder(btnAddTransaction);
        }

        private void btnAddCall_Click(object sender, EventArgs e)
        {
            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    Call item = new Call();
                    item.From = par[0].Replace("\"", "");
                    item.To = par[1].Replace("\"", "");
                    item.Id = par[2].Replace("\"", "");
                    item.CallTime = par[3].Replace("\"", "");
                    item.duration = par[4].Replace("\"", "");
                    Global.Calls.Add(item);
                }
                lblStatus.Text = "";
                frmCall callForm = new frmCall();
                OpenNewForm(callForm);
                lblStatus.Text = "تعداد اطلاعات تماس یافت شده : " + callForm.GetNumberOfRow().ToString();
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 7);
            index = 7;
            frmCall TransactionForm = new frmCall();
            OpenNewForm(TransactionForm);
            lblStatus.Text = "تعداد اطلاعات تماس یافت شده : " + TransactionForm.GetNumberOfRow().ToString();

            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            ShowAdder(btnAddCall);
        }

        private void btnAddRelationShip_Click(object sender, EventArgs e)
        {

            addInfo.Title = "لطفا فایل خود را انتخاب نمایید";
            addInfo.Filter = "csv File (*.csv) |*.csv|  All files (*.*) |*.*";
            addInfo.FilterIndex = 1;

            if (addInfo.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "درحال بارگذاری ...";
                string strFileName = addInfo.FileName;
                var csv = new List<string[]>();
                var lines = System.IO.File.ReadAllLines(strFileName);
                foreach (string line in lines)
                {
                    var par = line.Split(',');
                    RelationShip item = new RelationShip();
                    item.From = par[0].Replace("\"", "");
                    item.To = par[1].Replace("\"", "");
                    item.Relation = par[2].Replace("\"", "");
                    item.StartRelationDate = par[3].Replace("\"", "");
                    Global.RelationShips.Add(item);
                }
                lblStatus.Text = "";
                frmRelationShip RelationForm = new frmRelationShip();
                OpenNewForm(RelationForm);
                lblStatus.Text = "تعداد اطلاعات خویشاوندی یافت شده : " + RelationForm.GetNumberOfRow().ToString();
            }
        }

        private void btnRalation_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, 8);
            index = 8;
            frmRelationShip RelationForm = new frmRelationShip();
            OpenNewForm(RelationForm);
            lblStatus.Text = "تعداد اطلاعات خویشاوندی یافت شده : " + RelationForm.GetNumberOfRow().ToString();

            if (header.BackColor.R < 150 && header.BackColor.G < 150 && header.BackColor.B < 150)
                lblTitle.ForeColor = Color.White;
            ShowAdder(btnAddRelationShip);
        }
    }
}
