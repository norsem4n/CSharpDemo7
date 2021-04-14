/* Assignment       HW3 - Program 7
 * Created by       Christopher Karnas
 * Date Created:    September, 2020
 * Date             Last Modified: 10.8.20
 * Class Name:       Form1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare the local (method level) variables

            string customerName;
            int beginningMileage, endingMileage, daysRented;
            decimal rentalCharge;

            TruckRental aTruckRental;

            // assign data and input variables

            customerName = txtName.Text;

            beginningMileage = Convert.ToInt32(nudMileageBegin.Value);
            endingMileage = Convert.ToInt32(nudMileageEnd.Value);
            daysRented = Convert.ToInt32(nudDaysRented.Value);

            // instantiate a TruckRental Object and initialize its properties

            aTruckRental = new TruckRental(customerName, beginningMileage, endingMileage, daysRented);

            // access the property

            rentalCharge = aTruckRental.RentalCharge;

            lblTotal.Text = rentalCharge.ToString("C");

            // disable controls

            btnCreate.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form values

            txtName.Text = null;
            nudMileageBegin.Value = 0;
            nudMileageEnd.Value = 0;
            nudDaysRented.Value = 0;
            lblTotal.Text = null;

            // enable controls

            btnCreate.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit the form
            this.Close();
        }
    }
}
