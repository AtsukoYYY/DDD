using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Common;
using DDD.Data;
using DDD.Domain.ValueObjects;
using DDD.ViewModels;

namespace DDD
{
    public partial class WeatherLatestView : Form
    {
        
        public WeatherLatestView()
        {
            InitializeComponent();
        }


        private void LatestButton_Click(object sender, EventArgs e)
        {

            DataTable dt = WeatherSQLite.GetLatest(Convert.ToInt32(this.AreaIDTextBox.Text));
            if(dt.Rows.Count > 0)
            {
                DataDateLabel.Text = dt.Rows[0]["DataDate"].ToString();
                ConditionLabel.Text = dt.Rows[0]["Condition"].ToString();
                var temperature = new Temperature(Convert.ToSingle(dt.Rows[0]["Temperature"]));
                TemperatureLabel.Text = temperature.DisplayValue;
                
            }
        }

        
    }
}
