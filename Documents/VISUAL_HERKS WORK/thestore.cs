using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel[] panels = { pnlRegister, pnlStore, pnlPrice, pnlVendors, pnlUsers, pnlTime };

            foreach (Panel pnl in panels)
            {
                pnl.Cursor = Cursors.Hand;
                pnl.Click += Panel_Click;
                pnl.MouseEnter += Panel_MouseEnter;
                pnl.MouseLeave += Panel_MouseLeave;
            }
        }

        // reuse 
        private void OpenForm(Form f)
        {
            f.WindowState = FormWindowState.Maximized;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        // ================= CLICK =================
        private void Panel_Click(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
            {
                switch (pnl.Name)
                {
                    case "pnlRegister":
                        // options 
                        //open frm rg

                        MessageBox.Show("Register clicked");
                        break;

                    case "pnlStore":
                        // OpenForm new frmStatusStore
                        MessageBox.Show("Store Status clicked");
                        break;

                    case "pnlPrice":
                        // OpenForm new frmPricebook
                        MessageBox.Show("Pricebook clicked");
                        break;

                    case "pnlVendors":
                        // OpenForm new frmVendors
                        MessageBox.Show("Vendors clicked");
                        break;

                    case "pnlUsers":
                        // OpenForm new frmUsers
                        MessageBox.Show("Users clicked");
                        break;

                    case "pnlTime":
                        // OpenForm new frmTimeClock
                        MessageBox.Show("Time Clock clicked");
                        break;
                }
            }
        }

        // ================= HOVER =================
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
                pnl.BackColor = Color.LightGray;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
                pnl.BackColor = Color.White;
        }

        // ================= DESIGN EVENTS =================
        private void pnlRegister_Paint(object sender, PaintEventArgs e) { }
        private void pnlStore_Paint(object sender, PaintEventArgs e) { }
        private void pnlPrice_Paint(object sender, PaintEventArgs e) { }
        private void pnlVendors_Paint(object sender, PaintEventArgs e) { }
        private void pnlUsers_Paint(object sender, PaintEventArgs e) { }
        private void pnlTime_Paint(object sender, PaintEventArgs e) { }
    }
}