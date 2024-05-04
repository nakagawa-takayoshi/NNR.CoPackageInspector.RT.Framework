using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Station
{
    public static class StationCollectionFactory
    {

        public static StationCollection Create()
        {
            var stationFunctionCollectionAbstractFactory = StationFunctionCollectionAbstractFactory.Create();

            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.NoFunctionStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.PortInStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.AlignmentStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.TwoDimCodeReaderStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.InsterctStaion);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.NoFunctionStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.LaserStampStation);
            stationFunctionCollectionAbstractFactory.Add(FunctionStationDiscriptor.PortOutStation);

            var stationFunctionCollectionFactory = stationFunctionCollectionAbstractFactory.CreateFactory();

            var stationFunctionCollection = stationFunctionCollectionFactory.Create();

            var stationCollectionAbstractFactory = StationCollectionAbstractFactory.Create();

            foreach(var stationFunction in stationFunctionCollection.Items)
            {
                stationCollectionAbstractFactory.Add(new StationCollectionItem(stationFunctionCollection.Clone(), stationFunction));
            }

            var stationCollectionConcreteFactory = stationCollectionAbstractFactory.CreateFactory();

            return stationCollectionConcreteFactory.Create();
        }
    }
}
