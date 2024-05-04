using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
{
    public class StationCollectionConcreteFactory
    {
        private List<StationCollectionItem> _stationModels;

        public StationCollectionConcreteFactory(List<StationCollectionItem> stationModels)
        {
            _stationModels = stationModels;
        }

        public StationCollection Create()
        {
            return new StationCollection(_stationModels);
        }

    }
}
