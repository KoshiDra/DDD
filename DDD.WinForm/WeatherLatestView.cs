using DDD.WinForm.Common;
using DDD.WinForm.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        public WeatherLatestView()
        {
            InitializeComponent();
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {

            int areaId = Convert.ToInt32(this.AreaIdTextBox.Text);

            DataTable dt = WetherSQLite.SearchLatest(areaId);

            if (dt.Rows.Count > 0)
            {
                this.DataDateLabel.Text = dt.Rows[0]["DataDate"].ToString();
                this.ConditionLabel.Text = dt.Rows[0]["Condition"].ToString();
                this.TemperatureLabel.Text =
                    string.Format("{0}{1}"
                        , CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"].ToString()), CommonConst.TemperatuerDecimalPoint)
                        , CommonConst.TemperatuerUnitName);
            }
        }
    }
}
