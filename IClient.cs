using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Model.Interfaces
{
    internal interface IClient:IHuman
    {
        ISubscription Subscription { get; }
        void OnAdded(bool personal);
    }
}
