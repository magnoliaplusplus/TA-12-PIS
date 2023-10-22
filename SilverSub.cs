using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model
{
    internal class SilverSub:ISubscription
    {
        DateTime _startDate;
        string _type;
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _startDate.AddMonths(6); } }
        public string Type { get { return _type; } }
        public SilverSub(DateTime startDate, string type)
        {
            _startDate = startDate;
            _type = type;
        }
        public string GetString()
        {
            return $"Silver[{_type}]";
        }
    }
}
