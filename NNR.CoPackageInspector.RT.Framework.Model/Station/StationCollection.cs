using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Station
{
    public class StationCollection : IStationCollection
    {
        private List<StationCollectionItem> _stations = new List<StationCollectionItem>();

        public List<StationCollectionItem> Items => _stations;

        public IStationItem PortInStation
        {
            get
            {
                foreach (StationCollectionItem item in _stations)
                {
                    if (item.Function == FunctionStationDiscriptor.PortInStation)
                    {
                        return item;
                    }
                }

                throw new InvalidOperationException();
            }
        }


        /// <summary>
        /// ステーションクラス
        /// </summary>
        public StationCollection(List<StationCollectionItem> stations)
        {
            _stations = stations;
        }

        /// <summary>
        /// ステーションを原点復帰します。
        /// </summary>
        public void ResetToOrigin()
        {
            foreach (var station in _stations)
            {
            }
        }

        /// <summary>
        /// 機能をローテート
        /// </summary>
        public void RoateFunction()
        {
            foreach(var station in _stations)
            {
                station.RotateFunction();
            }
        }
    }
}

