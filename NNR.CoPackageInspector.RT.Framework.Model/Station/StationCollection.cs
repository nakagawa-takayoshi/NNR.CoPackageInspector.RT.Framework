using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR.Inspector.RT.Framework.Model
{
    public class StationCollection
    {
        private List<StationCollectionItem> _stations = new List<StationCollectionItem>();

        public List<StationCollectionItem> Items => _stations;


        /// <summary>
        /// ステーションクラス
        /// </summary>
        public StationCollection(List<StationCollectionItem> stations)
        {
            _stations = stations;
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

