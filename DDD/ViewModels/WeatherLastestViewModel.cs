using DDD.Common;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.ViewModels
{
    public class WeatherLastestViewModel
    {
        private IWeatherRepository _weather;

        public WeatherLastestViewModel(IWeatherRepository weather)
        {
            _weather = weather;
        }

        public string AreaIDText { get; set; } = string.Empty;
        public string DataDateText { get; set; } = string.Empty;
        public string ConditionText { get; set; } = string.Empty;
        public string TemperatureText { get; set; } = string.Empty;

        public void Search()
        {
            var entity = _weather.GetLatest(Convert.ToInt32(AreaIDText));
            if (entity != null)
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText = entity.Condition.ToString();
                TemperatureText = CommonFunc.RoundString(entity.Temperature, CommonConst.TemperatureDecimalPoint).ToString() + " " +  CommonConst.TemperatureUnitName;
            }
        }
    }
}
