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
            // List of all panels
            var panels = new[] { pnlRegister, pnlStore, pnlPrice, pnlVendors, pnlUsers, pnlTime };

            foreach (var pnl in panels)
            {
                pnl.Cursor = Cursors.Hand;
                pnl.Click += Panel_Click;              // Single click handler for all
                pnl.MouseEnter += Panel_MouseEnter;
                pnl.MouseLeave += Panel_MouseLeave;
            }
        }

        // ================= SINGLE CLICK HANDLER =================
        private void Panel_Click(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
            {
                switch (pnl.Name)
                {
                    case "pnlRegister":
                        MessageBox.Show("Register clicked");
                        // new frmRegister().Show();        // Uncomment when form is created
                        break;

                    case "pnlStore":
                        // === This was causing your error ===
                        // frmStatusStore form = new frmStatusStore();
                        // form.Show();

                        MessageBox.Show("Store Status clicked\n\n(Form not created yet)");
                        break;

                    case "pnlPrice":
                        MessageBox.Show("Pricebook clicked");
                        // new frmPricebook().Show();
                        break;

                    case "pnlVendors":
                        MessageBox.Show("Vendors clicked");
                        // new frmVendors().Show();
                        break;

                    case "pnlUsers":
                        MessageBox.Show("Users clicked");
                        // new frmUsers().Show();
                        break;

                    case "pnlTime":
                        MessageBox.Show("Time Clock clicked");
                        // new frmTimeClock().Show();
                        break;

                    default:
                        MessageBox.Show(pnl.Name + " clicked");
                        break;
                }
            }
        }

        // ================= HOVER EFFECTS =================
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
                pnl.BackColor = Color.LightGray;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel pnl)
                pnl.BackColor = Color.White;   // Change to your original panel color if different
        }

        // ================= UNUSED PAINT EVENTS (keep if designer added them) =================
        private void pnlRegister_Paint(object sender, PaintEventArgs e) { }
        private void pnlStore_Paint(object sender, PaintEventArgs e) { }
        private void pnlPrice_Paint(object sender, PaintEventArgs e) { }
        private void pnlVendors_Paint(object sender, PaintEventArgs e) { }
        private void pnlUsers_Paint(object sender, PaintEventArgs e) { }
        private void pnlTime_Paint(object sender, PaintEventArgs e) { }
    }
}