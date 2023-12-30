using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Interface
{
    public interface IMainAppModelWriter
    {
        IStationCollection Stations { set; }
    }
}
