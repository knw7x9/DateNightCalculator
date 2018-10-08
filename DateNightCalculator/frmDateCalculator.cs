// frmDateCalculator.cs, DateNightCalculator.sln
// CS 1181
// Katherine Wilsdon
// 7 October 2018
// Dr. Cody Permann
/* Description - Create a date night calculator. The user selects the costs of travel, dinner, dessert, and  
 * entertainment, the percentage of tip if needed, and inputs the tax rate.
 * The program calculates total cost by adding the travel cost, the dinner cost, the dessert cost,
 * the entertainment cost, the taxes on the dinner and dessert, and the tip on dinner cost with its associated taxes.
 * The output is the total cost of the date. */
/* WOW:
 * 1. Notifies the user about a missing entry
 * 2. Plan my date checkbox that randomizes the radio buttons and sets the tip to 20% */
/* Cited:
 * Seed generation for random number generator: https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values 
 * Book, Chapters 5, 6, and 7: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateNightCalculator {
    public partial class frmDateCalculator : Form {
        public frmDateCalculator() {
            InitializeComponent();
            // Sets tip value to 20%
            lblOutputTipValue.Text = 0.2.ToString("P0");
        }

        // delclare and assign total cost as field variable
        double totalCost = 0;

        /// <summary>
        /// Adds the travel cost to total cost
        /// </summary>
        private void GetTravelCost() {
            // created two lists: 1. which travel radio button is checked 2. the corresponding values of the travel radio button
            List<bool> whichTravel = new List<bool>() { rbBus.Checked, rbBicycle.Checked, rbCar.Checked, rbCarriageRide.Checked };
            List<int> travelCostList = new List<int>() { 1, 20, 5, 50 };

            // when the radiobutton is checked, add the travel cost to total cost
            for (int i = 0; i < whichTravel.Count; i++) {
                if (whichTravel[i] == true) {
                    totalCost += travelCostList[i];
                }
            }
        }

        /// <summary>
        /// Add the dinner cost, dinner tax, and tip on the dinner and tax to total cost
        /// </summary>
        private void GetDinnerCost() {
            // created two lists: 1. which dinner radio button is checked 2. the corresponding values of the dinner radio button
            List<bool> whichDinner = new List<bool>() { rbNoDinner.Checked, rbMcDonalds.Checked, rbApplebees.Checked, rbSandPipers.Checked };
            List<int> dinnerCostList = new List<int>() { 0, 10, 25, 50 };
            double dinnerCost = 0;

            // when the radiobutton is checked, add the dinner cost, the taxes, and tip to total cost
            for (int i = 0; i < whichDinner.Count; i++) {
                if (whichDinner[i] == true) {
                    dinnerCost += dinnerCostList[i];
                    dinnerCost += GetTaxes(dinnerCost);
                    dinnerCost += GetTip(dinnerCost);
                    totalCost += dinnerCost;
                }
            }
        }

        /// <summary>
        /// Add the dessert cost and dessert tax to total cost
        /// </summary>
        private void GetDessertCost() {
            // created two lists: 1. which dessert radio button is checked 2. the corresponding values of the dessert radio button
            List<bool> whichDessert = new List<bool>() { rbNoDessert.Checked, rbIceCreamCones.Checked, rbShakes.Checked, rbSmores.Checked };
            List<int> dessertCostList = new List<int>() { 0, 3, 8, 4 };
            double dessertCost = 0;

            // when the radiobutton is checked, add the dessert cost and the taxes to total cost
            for (int i = 0; i < whichDessert.Count; i++) {
                if (whichDessert[i] == true) {
                    dessertCost += dessertCostList[i];
                    dessertCost += GetTaxes(dessertCost);
                    totalCost += dessertCost;
                }
            }
        }

        /// <summary>
        /// Adds the entertainment cost to total cost
        /// </summary>
        private void GetEntertainmentCost() {
            // created two lists: 1. which entertainment radio button is checked 2. the corresponding values of the entertainment radio button
            List<bool> whichEnertainment = new List<bool>() { rbWalk.Checked, rbBowling.Checked, rbMovie.Checked, rbMiniGolf.Checked };
            List<int> entertainmentCostList = new List<int>() { 0, 6, 26, 10 };

            // when the radiobutton is checked, add the entertainment cost to total cost
            for (int i = 0; i < whichEnertainment.Count; i++) {
                if (whichEnertainment[i] == true) {
                    totalCost += entertainmentCostList[i];
                }
            }
        }
        /// <summary>
        /// Calculates the sales tax on the taxable value
        /// </summary>
        /// <param name="taxableValue">the value that will be taxed</param>
        /// <returns>the sales tax where the taxable value is multiplied by the tax rate</returns>
        private double GetTaxes(double taxableValue) {
            double taxRate = 0;
            if (int.TryParse(txtTaxRate.Text, out int taxRatePercentage)) {
                taxRate = taxRatePercentage;
                taxRate /= 100;
            }
            return taxableValue * taxRate;
        }
        /// <summary>
        /// Calculates the tip on the the value of the meal
        /// </summary>
        /// <param name="valueOfMeal">the cost of the meal</param>
        /// <returns>the tip where the value of the meal is multiplied by the tip percent</returns>
        private double GetTip(double valueOfMeal) {
            double tipPercentage = 0;
            // if no dinner or mcdonald's is checked, no tip is given; else the tip is calculated
            if (rbNoDinner.Checked || rbMcDonalds.Checked) {
                chkNoTip.Checked = true;
            } else if (rbApplebees.Checked || rbSandPipers.Checked) {
                tipPercentage = trTip.Value;
                tipPercentage /= 100;
            }
            return valueOfMeal * tipPercentage;
        }


        /// <summary>
        /// Notifies the user when an input is missing
        /// </summary>
        private void InvalidEntry() {
            // list of booleans that determines if none of the radiobuttons are checked in a groupbox
            List<bool> groupboxes = new List<bool>() {
                !rbBus.Checked && !rbBicycle.Checked && !rbCar.Checked && !rbCarriageRide.Checked,
                !rbNoDinner.Checked && !rbMcDonalds.Checked && !rbApplebees.Checked && !rbSandPipers.Checked,
                !rbNoDessert.Checked && !rbIceCreamCones.Checked && !rbShakes.Checked && !rbSmores.Checked,
                !rbWalk.Checked && !rbBowling.Checked && !rbMovie.Checked && !rbMiniGolf.Checked,
                (rbApplebees.Checked || rbSandPipers.Checked) && (lblOutputTipValue.Text == 0.ToString("P0") || lblOutputTipValue.Text == ""),
                !(int.TryParse(txtTaxRate.Text, out int taxRate)),
            };

            // list of asterisk labels
            List<Label> asterisks = new List<Label>() {
                lblInvalidTravel,
                lblInvalidDinner,
                lblInvalidDessert,
                lblInvalidEntertainment,
                lblInvalidTip,
                lblInvalidTaxRate
            };

            // list of booleans that determines if none of the radiobuttons are checked in a groupbox
            List<bool> travelEntertainmentGroupboxes = new List<bool>() {
                !rbBus.Checked && !rbBicycle.Checked && !rbCar.Checked && !rbCarriageRide.Checked,
                !rbWalk.Checked && !rbBowling.Checked && !rbMovie.Checked && !rbMiniGolf.Checked
            };

            // list of asterisk labels
            List<Label> asterisksTravelEntertainment = new List<Label>() {
                lblInvalidTravel,
                lblInvalidEntertainment
            };
            // purpose: when the user only checks plan my date, an invalid message appears to fill in the tax rate
            if (chkRandomize.Checked == true) {
                if (txtTaxRate.Text == "") {
                    lblInvalidMessage.Visible = true;
                    asterisks[5].Visible = true;
                    lblOutputTotalCost.Text = "";
                } else {
                    lblInvalidMessage.Visible = false;
                    asterisks[5].Visible = false;
                }
            } else if (rbNoDinner.Checked && rbNoDessert.Checked) {
                // purpose: when No Dinner and No Dessert are checked, the user does not have to input the tax rate
                asterisks[1].Visible = false;
                asterisks[2].Visible = false;
                for (int i = 0; i < travelEntertainmentGroupboxes.Count; i++) {
                    if (travelEntertainmentGroupboxes[i] == true) {
                        // if a radiobutton in travel or entertainment is not checked, make these labels visible and do not calculate the total cost
                        lblInvalidMessage.Visible = true;
                        asterisksTravelEntertainment[i].Visible = true;
                        lblOutputTotalCost.Text = "";
                    } else if (travelEntertainmentGroupboxes[i] == false) {
                        // if a radiobutton in travel or entertainment is checked, make these labels invisible
                        lblInvalidMessage.Visible = false;
                        asterisksTravelEntertainment[i].Visible = false;
                        // invalid tax rate label is invisible since no dinner and no dessert are checked
                        asterisks[5].Visible = false;
                    }
                }
            } else { 
                for (int i = 0; i < groupboxes.Count; i++) {
                    if (groupboxes[i] == true) {
                        // if a radiobutton in a groupbox is not checked, make these labels visible and do not calculate the total cost
                        lblInvalidMessage.Visible = true;
                        asterisks[i].Visible = true;
                        lblOutputTotalCost.Text = "";
                    } else if (groupboxes[i] == false) {
                        // if a radiobutton in the group box is checked, make these labels invisible
                        lblInvalidMessage.Visible = false;
                        asterisks[i].Visible = false;
                    }                
                }
            }            
        } 

        /// <summary>
        /// Randomizes the radio buttons in the travel groupbox
        /// </summary>
        private void RandomizeTravel() {
            // Clears the travel radiobuttons
            ClearTravel();
            
            // Creates a list of travel radiobuttons
            List<RadioButton> whichTravel = new List<RadioButton>() { rbBus, rbBicycle, rbCar, rbCarriageRide };
            
            // Creates a random number between 0 and 3 and checks the radio button at the random number position 
            Random randomTravel = new Random(Guid.NewGuid().GetHashCode());
            int number = randomTravel.Next(0, 4);
            whichTravel[number].Checked = true;
        }

        /// <summary>
        /// Randomizes the radio buttons in the dinner groupbox
        /// </summary>
        private void RandomizeDinner() {
            // Clears the dinner radiobuttons
            ClearDinner();
            
            // Creates a list of dinner radiobuttons
            List<RadioButton> whichDinner = new List<RadioButton>() { rbNoDinner, rbMcDonalds, rbApplebees, rbSandPipers };
            
            // Creates a random number between 0 and 3 and checks the radio button at the random number position 
            Random randomDinner = new Random(Guid.NewGuid().GetHashCode());
            int number = randomDinner.Next(0, 4);
            whichDinner[number].Checked = true;
        }

        /// <summary>
        /// Randomizes the radio buttons in the dessert groupbox
        /// </summary>
        private void RandomizeDessert() {
            // Clears the dessert radiobuttons
            ClearDessert();
            
            //// Creates a list of dessert radiobuttons
            List<RadioButton> whichDessert = new List<RadioButton>() { rbNoDessert, rbIceCreamCones, rbShakes, rbSmores };
            
            // Creates a random number between 0 and 3 and checks the radio button at the random number position 
            Random randomDessert = new Random(Guid.NewGuid().GetHashCode());
            int number = randomDessert.Next(0, 4);
            whichDessert[number].Checked = true;
        }

        /// <summary>
        /// Randomizes the radio buttons in the entertainment groupbox
        /// </summary>
        private void RandomizeEntertainment() {
            // Clears the entertainment radiobuttons
            ClearEntertainment();
            
            // // Creates a list of entertainment radiobuttons
            List<RadioButton> whichEnertainment = new List<RadioButton>() { rbWalk, rbBowling, rbMovie, rbMiniGolf };
            
            // Creates a random number between 0 and 3 and checks the radio button at the random number position 
            Random randomEntertainment = new Random(Guid.NewGuid().GetHashCode());
            int number = randomEntertainment.Next(0, 4);
            whichEnertainment[number].Checked = true;
        }
        /// <summary>
        /// Randomizes the all radio buttons in the groupboxes
        /// </summary>
        private void Randomize() {
            if (chkRandomize.Checked == true) {
                ClearTip();
                RandomizeTravel();
                RandomizeDinner();
                RandomizeDessert();
                RandomizeEntertainment(); 

                // Set the tip trackbar to 20% to avoid a missing tip entry
                if (rbApplebees.Checked || rbSandPipers.Checked) {
                    trTip.Value = 20;
                    lblOutputTipValue.Text = 0.2.ToString("P0");
                }

                // Clears randomized radio buttons if the user did not input a tax rate
                if (txtTaxRate.Text == "") {
                    ClearTravel();
                    ClearDinner();
                    ClearDessert();
                    ClearEntertainment();
                    ClearTip();
                }
            }
        }

        /// <summary>
        /// Clears the travel cost
        /// </summary>
        private void ClearTravel() {
            rbBus.Checked = false;
            rbBicycle.Checked = false;
            rbCar.Checked = false;
            rbCarriageRide.Checked = false;
        }

        /// <summary>
        /// Clears the dinner cost
        /// </summary>
        private void ClearDinner() {
            rbNoDinner.Checked = false;
            rbMcDonalds.Checked = false;
            rbApplebees.Checked = false;
            rbSandPipers.Checked = false;
        }

        /// <summary>
        /// Clear the dessert cost
        /// </summary>
        private void ClearDessert() {
            rbNoDessert.Checked = false;
            rbIceCreamCones.Checked = false;
            rbShakes.Checked = false;
            rbSmores.Checked = false;
        }

        /// <summary>
        /// Clears the entertainment cost
        /// </summary>
        private void ClearEntertainment() {
            rbWalk.Checked = false;
            rbBowling.Checked = false;
            rbMovie.Checked = false;
            rbMiniGolf.Checked = false;
        }

        /// <summary>
        /// Clears the tip groupbox
        /// </summary>
        private void ClearTip() {
            trTip.Value = 20;
            lblOutputTipValue.Text = 0.2.ToString("P0");
            chkNoTip.Checked = false;
        }
        /// <summary>
        /// Makes the invalid entries invisible
        /// </summary>
        private void ClearInvalidEntry() {
            lblInvalidTravel.Visible = false;
            lblInvalidDinner.Visible = false;
            lblInvalidDessert.Visible = false;
            lblInvalidEntertainment.Visible = false;
            lblInvalidTaxRate.Visible = false;
            lblInvalidTip.Visible = false;
            lblInvalidMessage.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            //Randomizes the radio buttons
            Randomize();
            // Add each cost to total cost
            GetTravelCost();
            GetDinnerCost();
            GetDessertCost();
            GetEntertainmentCost();
            // display the cost to the user
            lblOutputTotalCost.Text = totalCost.ToString("C");
            // display asterisks for each invalid entry
            InvalidEntry();
            // reset total cost to zero 
            totalCost = 0;
            
        }

        private void btnClear_Click(object sender, EventArgs e) {
            // Clear the radiobuttons, the tip, and the invalid entries
            ClearTravel();
            ClearDinner();
            ClearDessert();
            ClearEntertainment();
            ClearTip();
            ClearInvalidEntry();

            // Clears the plan my date checkbox
            chkRandomize.Checked = false;

            // Clears the tax rate
            txtTaxRate.Text = "";

            // Clears the total cost
            lblOutputTotalCost.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // close the form
            this.Close();
        }

        private void trTip_Scroll(object sender, EventArgs e) {
            //displays the trackbar value in a label
            double tipPercent = trTip.Value;
            tipPercent /= 100;
            lblOutputTipValue.Text = tipPercent.ToString("P0");
            
            //unchecks no tip checkbox if user moves tip trackbar
            if (lblOutputTipValue.Text != 0.ToString("P0")) {
                chkNoTip.Checked = false;
            }
        }

        private void chkNoTip_CheckedChanged(object sender, EventArgs e) {
            // when the user checks no tip, the tip trackbar resets and the output label is set to 0% 
            if (chkNoTip.Checked == true) {
                trTip.Value = 5;
                lblOutputTipValue.Text = 0.ToString("P0");
            }
        }
    }
}
