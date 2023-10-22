using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FitnessCenter.Model.Interfaces
{
    internal delegate void ClientNotify(); 
    internal interface IClasses
    {
        string Type { get; set; }
        List<IClient> Clients { get;}
        IStaff Trainer { get;}
        DateTime Date { get; set; }
        bool IsPersonal { get; }
        bool IsFinished { get; set; }
        string GetString();
        event ClientNotify AddedToClass;
    }
}
