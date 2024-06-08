using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model
{
    public interface IMainAppModelWriter
    {
        IStationCollection Stations { set; }
    }
}
