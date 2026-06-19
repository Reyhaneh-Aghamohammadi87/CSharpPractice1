using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the final visit cost of a patient by applying insurance discount and optional percentage discount.
        /// </summary>
        /// <param name="baseCost">The initial cost of the medical visit.</param>
        /// <param name="hasInsurance">Indicates whether the patient has supplementary insurance. If true, 30% discount is applied.</param>
        /// <param name="discountPercent">Additional discount percentage applied after insurance discount.</param>
        /// <returns>The final calculated visit cost after applying all discounts.</returns>
        decimal CalculateVisitCost(decimal baseCost, bool hasInsurance = false, int discountPercent = 0)
        {
            if (hasInsurance)
                baseCost -= (baseCost * 30) / 100;

            if (discountPercent > 0)
                baseCost -= (baseCost * discountPercent) / 100;

            return baseCost;

        }
        private void btnCheckVisit_Click(object sender, EventArgs e)
        {
            decimal baseCost;
            if (!decimal.TryParse(txtBaseCost.Text, out baseCost))
            {
                baseCost = 0;
            }
            bool hasInsurance = chkInsurance.Checked;
            int discountPercent;
            if (!int.TryParse(txtDiscount.Text, out discountPercent))
            {
                discountPercent = 0;
            }
            decimal resultVisit = CalculateVisitCost(baseCost: baseCost,
                                                hasInsurance: hasInsurance,
                                                discountPercent: discountPercent);
            lblResultVisit.Text = resultVisit.ToString();
        }



        /// <summary>
        /// Calculates the Body Mass Index (BMI) based on weight and height, and determines the health status of the patient.
        /// </summary>
        /// <param name="weight">The weight of the patient in kilograms.</param>
        /// <param name="height">The height of the patient in meters.</param>
        /// <param name="status">Outputs the health condition of the patient (Under Weight, Normal Weight, Over Weight).</param>
        /// <returns>The calculated BMI value.</returns>
        double CalculateBMI(double weight, double height, out string status)
        {
            double BMI = weight / (height * height);
            if (BMI < 18.5)
                status = "Under Weight";
            else if (BMI < 25)
                status = "Normal Weight";
            else
                status = "Over Weight";
            return BMI;
        }
        private void btnCheckBmi_Click(object sender, EventArgs e)
        {
            double weight;
            double.TryParse(txtWeight.Text, out weight);
            double height;
            double.TryParse(txtHeight.Text, out height);
            string status;
            double resultBMI = CalculateBMI(weight: weight, height: height,status:out status);
            if (txtHeight.Text != "" && txtWeight.Text != "")
            {
                lblResultBmi.Text = resultBMI.ToString("0.00");
                lblStatus.Text = status;
            }
        }



        bool ValidatePatientName(string patientName)
        {
            return !string.IsNullOrEmpty(patientName);
        }

        decimal CalculateTotalCost(params decimal[] costs)
        {
            decimal total = 0;
            foreach (var cost in costs)
            {
                total += cost;
            }
            return total;
        }

        void PrintInvoice(string patientName, decimal resultTotalCost)
        {
            lblDirtyResult.Text = string.Format("Invoice for: {0}\nTotal Amount to Pay: {1}", patientName, resultTotalCost);
        }
        private void btnDirtyCheck_Click(object sender, EventArgs e)
        {
            string patientName = txtPatient.Text;
            if (!ValidatePatientName(patientName))
            {
                MessageBox.Show("Patient name cannot be empty!");
                return;
            }
            decimal sugarTest;
            decimal.TryParse(txtSugarTest.Text, out sugarTest);
            decimal thyroidTest;
            decimal.TryParse(txtThyroidTest.Text, out thyroidTest);
            decimal bloodTest;
            decimal.TryParse(txtBloodTest.Text, out bloodTest);
            decimal resultTotalCost= CalculateTotalCost(sugarTest,bloodTest,thyroidTest);
            PrintInvoice(patientName, resultTotalCost);

        }

    }
}
