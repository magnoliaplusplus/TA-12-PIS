using FitnessCenter.Model;
using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.ViewModel
{
    internal class DataStaff
    {
        public static List<IStaff> GetStaff()
        {
            return new List<IStaff>()
            {
                new Trainer("Ivan","Kopyto","0954722148","Halycka 21 str.",Sex.Male),
                new Trainer("Anastasiya","Grymko","0501333311","Shevchenka 1 str.",Sex.Female)
            };
        }
    }
}
