using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        public WeatherEntity(int areaID, DateTime dataDate, int condition, float temperature)
        {
            AreaID = areaID;
            DataDate = dataDate;
            Condition = condition;
            Temperature = temperature;
        }

        public int AreaID { get; }
        public DateTime DataDate { get; }
        public int Condition { get; }
        public float Temperature { get; }

        public bool IsOK() 
        {
            if (DataDate > DateTime.Now.AddDays(1)) return false;
            if (Temperature < 10) return false;
            return true;
        }
    }
}
