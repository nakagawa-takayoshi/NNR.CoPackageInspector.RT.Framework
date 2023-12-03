using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Runner.Factory
{
    internal class MainAppModelAbstractFactory
    {
        MainAppModelFactory _factory = new MainAppModelFactory();

        public static MainAppModelAbstractFactory Create()
        {
            return new MainAppModelAbstractFactory();
        }

        private MainAppModelAbstractFactory() { }

        internal void Add(StationCollection stations)
        {
            _factory.StationCollection = stations;
        }

        internal MainAppModelFactory CreteFactory()
        {
            return _factory;
        }

    }
}
