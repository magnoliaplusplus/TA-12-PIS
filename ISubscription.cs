using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model.Interfaces
{
    internal interface ISubscription
    {
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        string Type {  get; }
        string GetString();
    }
}
