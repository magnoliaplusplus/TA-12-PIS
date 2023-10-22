using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Model.Interfaces;

namespace FitnessCenter.Model
{
    internal class PersonalClass : IClasses
    {
        IClient _client;
        IStaff _trainer;
        public string Type { get; set; }
        public List<IClient> Clients { get { return new List<IClient> { _client }; } }
        public IStaff Trainer { get { return _trainer; } }
        public DateTime Date { get; set; }
        public bool IsPersonal { get { return true; } }
        public bool IsFinished { get; set; }
        public PersonalClass(IClient client, IStaff trainer, DateTime date, string type)
        {
            _client = client;
            _trainer = trainer;
            Date = date;
            Type = type;
            AddedToClass = OnAdded;
            AddedToClass?.Invoke();
        }
        void OnAdded()
        {
            _client.OnAdded(true);
        }
        public event ClientNotify AddedToClass;
        public string GetString()
        {
            return $"Personal Class\n" +
                   $"Client:{_client}\n" +
                   $"Date:{Date}\n" +
                   $"Type:{Type}";
        }
    }
}
