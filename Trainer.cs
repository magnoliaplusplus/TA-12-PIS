using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model
{
    internal class Trainer:Human,IStaff
    {
        Sex _sex;
        Positions _position = Positions.Trainer;
        public Sex Sex { get { return _sex; } }
        public Positions Position { get { return _position; } }
        public Trainer(string name,string lastName,string number,string address,Sex sex):base(name, lastName, number, address)
        {
            _sex = sex;
        }
        public override string ToString()
        {
            return "[Trainer]\n" +
                   $"Name: {_name}\n" +
                   $"Last Name: {_lastName}\n" +
                   $"Number: {_number}";
        }
        public override void Show()
        {
            Console.WriteLine("[Trainer]\n" +
                              $"Name: {_name}\n" +
                              $"Last Name: {_lastName}\n" +
                              $"Number: {_number}");
        }
    }
}
