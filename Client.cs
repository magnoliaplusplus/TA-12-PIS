using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model
{
    internal class Client:Human,IClient
    {
        ISubscription _subscription;
        public ISubscription Subscription { get { return _subscription; } }
        public Client(string name,string lastName,string number,string address,ISubscription subscription):base(name, lastName, number, address)
        {
            _subscription = subscription;
        }
        public override void Show()
        {
            Console.WriteLine("[Client]\n" +
                              $"Name: {_name}\n" +
                              $"Last Name: {_lastName}\n" +
                              $"Number: {_number}\n" +
                              $"Subscription: {_subscription.GetString()}");
        }
        public void OnAdded(bool personal)
        {
            Console.WriteLine($"{_name} added to {(personal?"personal":"group")} class");
        }
        public override string ToString()
        {
            return "[Client]\n" +
                   $"Name: {_name}\n" +
                   $"Last Name: {_lastName}\n" +
                   $"Number: {_number}\n" +
                   $"Subscription: {_subscription.GetString()}";
        }
    }
}
