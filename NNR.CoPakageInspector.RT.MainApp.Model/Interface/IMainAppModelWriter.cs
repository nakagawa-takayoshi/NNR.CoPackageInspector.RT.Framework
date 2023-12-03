using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Interface
{
    public interface IMainAppModelWriter
    {
        StationCollection Stations { set; }
    }
}
