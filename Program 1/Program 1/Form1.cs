// Tony Piccirilli
// CIS 199-01-4162
// Program 1
// Feburary 14, 2016
// In this program, you must put in entries for how many square feet,
// how many coats needed, and the cost of each gallon of paint. 
// Those entries will determine how many total square feet,
// how much paint gallons needed, the total number of labor hours needed,
// the total cost of paint and labor, plus the total overall cost of the paint job.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Constant Fields
                const double SQUARE_FEET = 325;
                const double LABOR_HOURS = 8;
                const double LABOR_COST = 10.50;

                //Variables
                double squareFeetinput;     // To hold number of square feet given.
                int coatsInput;         // To hold number of coats given.
                double gallonsCostinput;     // To hold cost per gallon.
                double squareFeettotal;     // To hold total square feet.
                double gallonsTotal;         // To hold total number of gallons.
                double laborHourstotal;     // To hold total number of labor hours.
                double paintCosttotal;     // To hold total cost of paint.
                double laborCosttotal;     // To hold total cost of labor.
                double finalTotal;     // To hold the final total of the paint job.

                // Get the entry values for the paint job.
                squareFeetinput = double.Parse(squareFeetentry.Text);
                coatsInput = int.Parse(coatsEntry.Text);
                gallonsCostinput = double.Parse(gallonCostentry.Text);

                // Calculate the total number of square feet.
                squareFeettotal = squareFeetinput * coatsInput;

                // Calculate the total number of gallons of paint.
                gallonsTotal = Math.Ceiling(squareFeettotal / SQUARE_FEET);

                //Caluclate the total number of labor hours.
                laborHourstotal = (squareFeettotal / SQUARE_FEET * LABOR_HOURS);

                // Calculate the total cost for paint. 
                paintCosttotal = (gallonsCostinput * gallonsTotal);

                // Calculate the total cost of labor.
                laborCosttotal = (laborHourstotal * LABOR_COST);

                // Calculate the final total cost.
                finalTotal = (paintCosttotal + laborCosttotal);

                // Display the outputs for the all the totals.
                totalSquarefeetAnswer.Text = squareFeettotal.ToString("n1");
                totalGallonsanswer.Text = gallonsTotal.ToString("n0");
                totalHoursanswer.Text = laborHourstotal.ToString("n1");
                totalCostforPaintanswer.Text = paintCosttotal.ToString("c");
                totalCostofLaboranswer.Text = laborCosttotal.ToString("c");
                fullTotalanswer.Text = finalTotal.ToString("c");
            }
            catch (Exception ex) 
            {
                // Display error message.
                MessageBox.Show(ex.Message);

            }


            }private void clearButton_Click(object sender, EventArgs e)
        { 
            // Clear the entries in each TextBox.
            squareFeetentry.Text = "";
            coatsEntry.Text = "";
            gallonCostentry.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();

        }
    }
}

