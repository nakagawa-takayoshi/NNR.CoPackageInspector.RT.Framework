using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model
{
    public interface IMainAppModel
    {
        IStationCollection Stations { get; }

        IApplicationCondition AppCondition { get; }
    }
}
