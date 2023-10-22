using FitnessCenter.Model.Interfaces;
using FitnessCenter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.ViewModel
{
    internal class DataClients
    {
        public static List<IClient> GetClients()
        {
            return new List<IClient>()
            {
                new Client("Oleg","Lobaevsky","0974266457","Akademika Yangelya 5 str.",new BronzeSub(DateTime.Now,"Gym")),
                new Client ("Dasha", "Shumko", "0501015301", "pros. Peremogy 10", new SilverSub(DateTime.Now, "Pool"))
            };
        }
    }
}
