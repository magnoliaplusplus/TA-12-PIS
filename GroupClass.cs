using FitnessCenter.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace FitnessCenter.Model
{
    internal class GroupClass:IClasses
    {
        List<IClient> _group;
        IStaff _trainer;
        public string Type { get; set; }
        public List<IClient> Clients { get { return _group; } }
        public IStaff Trainer { get { return _trainer; } }
        public DateTime Date { get; set; }
        public bool IsPersonal { get { return false; } }
        public bool IsFinished { get; set; }
        public GroupClass(List<IClient> group, IStaff trainer, DateTime date, string type)
        {
            _group = group;
            _trainer = trainer;
            Date = date;
            AddedToClass += OnAdded;
            AddedToClass?.Invoke();
            Type = type;
        }
        void OnAdded()
        {
            foreach (IClient client in _group)
            {
                client.OnAdded(false);
            }
        }
        public event ClientNotify AddedToClass;
        public string GetString()
        {
            return $"Group Class\n" +
                   $"People:{Clients.Count}\n" +
                   $"Date:{Date}\n" +
                   $"Type:{Type}";
        }
        public override bool Equals(object obj)
        {
            if (obj is IClasses other)
            {
                return Type==other.Type&&
                       Clients==other.Clients&&
                       Trainer==other.Trainer&&
                       Date == other.Date&&
                       IsPersonal==other.IsPersonal&&
                       IsFinished==other.IsFinished;
            }
            return false;
        }
    }
}
