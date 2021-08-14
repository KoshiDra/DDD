using DDD.Domain.Repositories;
using DDD.WinForm.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel
    {
        private IWeatherRepositoty _weather;

        public WeatherLatestViewModel(IWeatherRepositoty weather)
        {
            _weather = weather;
        }

        public string AreaIdText { get; set; } = string.Empty;
        public string DataDateText { get; set; } = string.Empty;
        public string ConditionText { get; set; } = string.Empty;
        public string TemperatureText { get; set; } = string.Empty;

        public void Search()
        {
            var dt = _weather.SearchLatest(Convert.ToInt32(AreaIdText));

            if (dt.Rows.Count > 0)
            {
                DataDateText = dt.Rows[0]["DataDate"].ToString();
                ConditionText = dt.Rows[0]["Condition"].ToString();
                TemperatureText =
                    string.Format("{0}{1}"
                        , CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"].ToString()), CommonConst.TemperatuerDecimalPoint)
                        , CommonConst.TemperatuerUnitName);
            }
        }
    }
}
