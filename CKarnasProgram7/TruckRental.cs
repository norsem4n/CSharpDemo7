/* Assignment       HW3 - Program 7
 * Created by       Christopher Karnas
 * Date Created:    September, 2020
 * Last Modified:   10.8.20
 * Class Name:      TruckRental
 * Description:     The calculation of the cost to rent a truck
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram7
{
    class TruckRental
    {

        #region "Variables/Fields"

        // select fields

        private int beginningMileage, endingMileage, daysRented;

        #endregion

        #region "Properties"

        // instance properties 

        public string CustomerName { get; set; }

        public decimal RentalCharge { get; private set; }


        public int BeginningMileage {get { return beginningMileage; } set { beginningMileage = value; CalculateRental(); }}
        
        public int EndingMileage { get { return endingMileage; } set { endingMileage = value; CalculateRental(); }}

        public int DaysRented { get { return daysRented; } set { daysRented = value; CalculateRental();  }}


        #endregion

        #region "Constructors"

        // default constructor 
        public TruckRental() { }

        // overloaded constructor
        public TruckRental(string customerName, int beginningMileage, int endingMileage, int daysRented)
        {
            CustomerName = customerName;
            BeginningMileage = beginningMileage;
            EndingMileage = endingMileage;
            DaysRented = daysRented;
        }

        #endregion

        #region "Methods"

        // an instance method to calculate and return the rental cost of a truck
        // Rental charge = $52.75 per day + $0.69 per mile

        private void CalculateRental()
        {
            // constants and variables

            const decimal dailyRental = 52.75M;
            const decimal mileRate = 0.69M;

            // calculate and return the cost of a rental tuck

            RentalCharge = (dailyRental * DaysRented) + (mileRate * (EndingMileage - BeginningMileage));
        }

        #endregion

    }
}
