using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model.Interfaces
{
    internal enum Positions
    {
        Administrator,
        Trainer,
        Cleaner,
        Bartender
    }
    internal enum Sex
    {
        Male,
        Female
    }
    internal interface IStaff:IHuman
    {
        Sex Sex { get; }
        Positions Position {  get; }
    }
}
