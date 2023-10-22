using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model.Interfaces
{
    internal interface IHuman
    {
        string Name { get; }
        string LastName {  get; }
        string Number {  get; }
        string Address {  get; }
        void Show();
    }
}
