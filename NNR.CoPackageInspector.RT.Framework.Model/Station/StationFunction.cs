using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.Station
{
    public class StationFunction : IStationFunction
    {
        public FunctionStationDiscriptor Discriptor { get; private set; }

        public StationFunction(FunctionStationDiscriptor desctiptor)
        {
            Discriptor = desctiptor;
        }
    }
}
