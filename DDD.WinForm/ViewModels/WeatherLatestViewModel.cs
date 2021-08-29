using DDD.Domain.Repositories;
using DDD.Infrastructure.SQLite;
using System;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel : ViweModelBase
    {
        private IWeatherRepositoty _weather;

        public WeatherLatestViewModel()
            : this(new WeatherSQLite())
        {
        }

        public WeatherLatestViewModel(IWeatherRepositoty weather)
        {
            _weather = weather;
        }

        public string _areaIdText = string.Empty;
        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }

            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }

        public string _dataDateText = string.Empty;
        public string DataDateText
        {
            get
            {
                return _dataDateText;
            }

            set
            {
                SetProperty(ref _dataDateText, value);
            }
        }

        public string _conditionText = string.Empty;
        public string ConditionText
        {
            get
            {
                return _conditionText;
            }

            set
            {
                SetProperty(ref _conditionText, value);
            }
        }

        public string _temperatureText = string.Empty;
        public string TemperatureText
        {
            get
            {
                return _temperatureText;
            }

            set
            {
                SetProperty(ref _temperatureText, value);
            }
        }

        public void Search()
        {
            var entity = _weather.SearchLatest(Convert.ToInt32(AreaIdText));

            if (entity != null)
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.DisplayValue;
                TemperatureText = entity.Temperature.DiaplayValueWithUnit;
            }
        }
    }
}
