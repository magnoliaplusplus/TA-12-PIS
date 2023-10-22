using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model
{
    internal class BronzeSub : ISubscription
    {
        DateTime _startDate;
        string _type;
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _startDate.AddMonths(1); } }

        public string Type {  get { return _type; } }
        public BronzeSub(DateTime startDate, string type)
        {
            _startDate = startDate;
            _type = type;
        }
        public string GetString()
        {
            return $"Bronze[{_type}]";
        }
    }
}
