using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincit.PM
{
    public partial class ControlJobBudget : UserControl
    {
        private JobBudget jobBudget;

        public ControlJobBudget(JobBudget JB)
        {
            InitializeComponent();

            try
            {
                jobBudget = JB;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void JobBudget_Load(object sender, EventArgs e)
        {
            PopulateJobBudget();
        }

        private void PopulateJobBudget()
        {
            LblOriginalLaborCost.Text = jobBudget.Original_HourlyLaborCost.ToString();
            LblOriginalEngineeringCost.Text = jobBudget.Original_EngineeringCost.ToString();
            LblOriginalMaterialCost.Text = jobBudget.Original_MaterialCost.ToString();
            LblOriginalTotalCost.Text = jobBudget.Original_TotalCost.ToString();
            LblOriginalPrice.Text = jobBudget.Original_SellPrice.ToString();
            LblOriginalMargin.Text = jobBudget.Original_Margin.ToString();
            LblOriginalMarginPercent.Text = jobBudget.Original_MarginPercent.ToString();

            LblCurrentLaborCost.Text = jobBudget.Current_HourlyLaborCost.ToString();
            LblCurrentEngineeringCost.Text = jobBudget.Current_EngineeringCost.ToString();
            LblCurrentMaterialCost.Text = jobBudget.Current_MaterialCost.ToString();
            LblCurrentTotalCost.Text = jobBudget.Current_TotalCost.ToString();
            LblCurrentPrice.Text = jobBudget.Current_SellPrice.ToString();
            LblCurrentMargin.Text = jobBudget.Current_Margin.ToString();
            LblCurrentMarginPercent.Text = jobBudget.Current_MarginPercent.ToString();

            LblActualLaborCost.Text = jobBudget.Actual_HourlyLaborCost.ToString();
            LblActualEngrCost.Text = jobBudget.Actual_EngineeringCost.ToString();
            LblActualMaterialCost.Text = jobBudget.Actual_MaterialCost.ToString();
            LblActualTotalCost.Text = jobBudget.Actual_TotalCost.ToString();
            LblActualPrice.Text = jobBudget.Actual_SellPrice.ToString();
            LblActualMargin.Text = jobBudget.Actual_Margin.ToString();
            LblActualMarginPercent.Text= jobBudget.Actual_MarginPercent.ToString();



            LblOULaborCost.Text = jobBudget.OverUnder_HourlyLaborCost.ToString();



        }


    }
}
