using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model
{
    internal abstract class Human:IHuman
    {
        protected string _name;
        protected string _lastName;
        protected string _number;
        protected string _address;
        public string Name {  get { return _name; } }
        public string LastName { get { return _lastName; } }
        public string Number { get { return _number; } }
        public string Address { get { return _address; } }
        public Human(string name, string lastName, string number, string address)
        {
            _name = name;
            _lastName = lastName;
            _number = number;
            _address = address;
        }
        public abstract void Show();
        public abstract override string ToString();
        public override bool Equals(object obj)
        {
            if (obj is IHuman other)
            {
                return Number == other.Number;
            }
            return false;
        }
    }
}
