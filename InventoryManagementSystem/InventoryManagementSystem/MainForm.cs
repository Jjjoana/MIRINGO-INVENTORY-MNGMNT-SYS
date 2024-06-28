using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customerButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerButton3_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
