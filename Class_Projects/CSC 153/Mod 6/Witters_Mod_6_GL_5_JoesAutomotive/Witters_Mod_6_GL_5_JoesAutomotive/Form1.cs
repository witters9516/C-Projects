using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witters_Mod_6_GL_5_JoesAutomotive
{
    public partial class Form1 : Form
    {
        const float NONROUTINE = 20.0f;
        const float TAX = .06f;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables
            float runningTotalCharges = 0.0f;
            int parts = 0;      //runningtotal
            float taxForDisplay = 0.0f;
            float services = 0.0f;
            if (int.TryParse(partsTextBox.Text, out parts))
            {
                if (oilChangeCheckBox.Checked == true)
                    parts++;
                if (lubeJobCheckBox.Checked == true)
                    parts++;
                if (radiatorFlushCheckBox.Checked == true)
                    parts++;
                if (transmissionFlushCheckBox.Checked == true)
                    parts++;
                if (inspectionCheckBox.Checked == true)
                    parts++;
                if (replaceMufflerCheckBox.Checked == true)
                    parts++;
                if (tireRotationCheckBox.Checked == true)
                    parts++;
            }
            
            //Call other Charge Functions
            runningTotalCharges += OilLubeCharges(runningTotalCharges);
            runningTotalCharges += FlushCharges(runningTotalCharges);
            runningTotalCharges += MiscCharges(runningTotalCharges);
            runningTotalCharges += OtherCharges(runningTotalCharges);
            
            //Set values for display later
            services = runningTotalCharges;

            //Call CalculateTax method
            if (parts > 0)
            {
                taxForDisplay = TaxCharges(runningTotalCharges);
                //Calc Tax
                runningTotalCharges += TaxCharges(runningTotalCharges);
            }
            
            //Display all values
            TotalCharges(runningTotalCharges, parts, taxForDisplay, services);

            MessageBox.Show("running total charge " + runningTotalCharges.ToString("c") +
                "\nParts total: " + parts.ToString());

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Call Clear functions
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this Form.
            this.Close();
        }

        //------------------------------------------------------------------
        //Value Returning methods
        private float OilLubeCharges(float tempTotal)
        {
            //Returns total charges for an oil change and/or lube job.

            //Variables
            float oilChangeCharge = 26.0f;
            float lubeJobCharge = 18.0f;
            tempTotal = 0.0f;

            if (oilChangeCheckBox.Checked == true)
                tempTotal += oilChangeCharge + NONROUTINE;
            if (lubeJobCheckBox.Checked == true)
                tempTotal += lubeJobCharge + NONROUTINE;

            return tempTotal;
        }
        private float FlushCharges(float tempTotal)
        {
            //Returns total charges for a radiator and/or transmission flush.

            //Variables
            float radiatorFlushCharge = 30.00f;
            float transmissionFlushCharge = 80.00f;
            tempTotal = 0.0f;

            if (radiatorFlushCheckBox.Checked == true)
                tempTotal += radiatorFlushCharge + NONROUTINE;
            if (transmissionFlushCheckBox.Checked == true)
                tempTotal += transmissionFlushCharge + NONROUTINE;

            return tempTotal;
        }
        private float MiscCharges(float tempTotal)
        {
            //Returns total charges for an inspection, 
            //muffler replacement, and/or tire rotation.

            //Variables
            float inspectionCharge = 15.0f;
            float replaceMufflerCharge = 100.0f;
            float tireRotationCharge = 20.0f;
            tempTotal = 0.0f;

            if (inspectionCheckBox.Checked == true)
                tempTotal += inspectionCharge + NONROUTINE;
            if (replaceMufflerCheckBox.Checked == true)
                tempTotal += replaceMufflerCharge + NONROUTINE;
            if (tireRotationCheckBox.Checked == true)
                tempTotal += tireRotationCharge + NONROUTINE;

            return tempTotal;

        }
        private float OtherCharges(float tempTotal)
        {
            //Returns total charges for other service(parts and labor).
            int parts;
            float labor;
            tempTotal = 0.0f;
            if (int.TryParse(partsTextBox.Text, out parts))
                tempTotal += parts * NONROUTINE;
            else
                MessageBox.Show("Error! Parts must be an integer.");

            if (float.TryParse(laborTextBox.Text, out labor))
                tempTotal += labor;
            else
                MessageBox.Show("Error! Parts must be an float.");

            return tempTotal;
        }
        private float TaxCharges(float totalBeforeTax)
        {
            //Returns amount of tax, if any. 
            //Sales tax = 6% and only is charged on parts.
            //If no parts are purchased, no tax is calculated.

            return totalBeforeTax * TAX;
        }
        private float TotalCharges(float total, int parts, float tax, float services)
        {
            //Returns total charges.
            ServiceAndLaborLabel.Text = services.ToString("c");
            partsLabel.Text = parts.ToString();
            taxLabel.Text = tax.ToString("c");
            totalFeeLabel.Text = total.ToString("c");

            return 0;
        }
        //------------------------------------------------------------------

        //------------------------------------------------------------------
        //Void functions
        private void ClearOilLube()
        {
            //Clear Section labeled, "Oil and Lube".
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }
        private void ClearFlushes()
        {
            //Clear Section labeled, "Flush".
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }
        private void ClearMisc()
        {
            //Clear Section labeled, "Misc".
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;

        }
        private void ClearOther()
        {
            //Clear Section labeled, "Parts and Labor".
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }
        private void ClearFees()
        {
            //Clear Section labeled, "Summary".
            ServiceAndLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalFeeLabel.Text = "";
        }
        //------------------------------------------------------------------
    }
}
