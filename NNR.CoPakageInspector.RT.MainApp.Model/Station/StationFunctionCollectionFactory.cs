using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
{
    public class StationFunctionCollectionFactory
    {
        IEnumerable<FunctionStationDiscriptor> _stationFunctions;

        public StationFunctionCollectionFactory(IEnumerable<FunctionStationDiscriptor> stationFunctions) 
        {
            _stationFunctions = stationFunctions;
        } 
        

        public StationFunctionCollection Create()
        {
            List<IStationFunction> functionModels = new List<IStationFunction>();
            foreach (var stationFunction in _stationFunctions) 
            {
                var stationFunctionFactory = new StationFunctionFactory(stationFunction);
                var stationFunctionModel = stationFunctionFactory.Create();
                functionModels.Add(stationFunctionModel);
            }

            return new StationFunctionCollection(functionModels);
        }
    }
}
