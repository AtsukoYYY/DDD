using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Common
{
    public static class CommonConst
    {
        public const string TemperatureUnitName = "℃";
        public const int TemperatureDecimalPoint = 2;

        public const string sql = @"select DataDate, Condition, Temperature from Weather where AreaID = @AreaID order by DataDate desc LIMIT 1";
    }
}
