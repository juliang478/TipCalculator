using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class frmTipCalculator : Form
    {
        private Calculations calculate = new Calculations();
        private const String startTotal = "$0.00";

        public frmTipCalculator()
        {
            InitializeComponent();
        }

        private void btnCalcTip_Click(object sender, EventArgs e)
        {
            try
            {
                double billAmount = Convert.ToDouble(txtAmount.Text);
                double tipAmount;
                double total;

                if (rad15Percent.Checked && billAmount > 0)
                {
                    tipAmount = calculate.Calculate15PercentTip(billAmount);
                    total = calculate.CalculateBill(billAmount, tipAmount);
                    lbl15PecentTotal.Text = tipAmount.ToString("c");
                    lblTotal.Text = total.ToString("c");
                    lbl20PecentTotal.Text = startTotal;
                }
                else if (rad20Percent.Checked && billAmount > 0)
                {
                    tipAmount = calculate.Calculate20PercentTip(billAmount);
                    total = calculate.CalculateBill(billAmount, tipAmount);
                    lbl20PecentTotal.Text = tipAmount.ToString("c");
                    lblTotal.Text = total.ToString("c");
                    lbl15PecentTotal.Text = startTotal;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bill amount must be a number");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearLabels();
        }              

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearLabels()
        {
            lbl15PecentTotal.Text = startTotal;
            lbl20PecentTotal.Text = startTotal;
            lblTotal.Text = startTotal;
            txtAmount.Clear();
        }
       
    }
}
