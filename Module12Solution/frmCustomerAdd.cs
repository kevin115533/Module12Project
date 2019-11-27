using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Kevin Tran
 * ITD 1253
 * Fall 2019
 */


namespace Module12Solution
{
    public partial class frmCustomerAdd : Form
    {
        List<Customer> customerList = new List<Customer>();
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress1.Text + txtAddress2.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;
            customerList.Add(new Customer(firstName, lastName, address, city, state, zip));
            btnClear.PerformClick();
            printCustomer();
        }

        private void printCustomer()
        {
            string info = "";
            for(int i = 0; i < customerList.Count; i++)
            {
                info = (i+1) + " " + customerList[i].FirstName + " " + customerList[i].LastName + "\r\n" + customerList[i].Address1 + "\r\n"+
                     customerList[i].City + ", " + customerList[i].State + " " + customerList[i].Zip;
            }
            txtDisplay.AppendText(info + "\r\n");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int removeIndex = Int32.Parse(txtRemove.Text);
            customerList.RemoveAt(removeIndex - 1);
            printCustomer();
        }
    }
}
