using NNR.CoPackageInspector.RT.Framework.Model.Station;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
{
    public class StationFunctionFactory
    {
        private FunctionStationDiscriptor _function;

        public StationFunctionFactory(FunctionStationDiscriptor function)
        {
            _function = function;
        }

        public IStationFunction Create()
        {
            return new StationFunction(_function);
        }

    }
}
