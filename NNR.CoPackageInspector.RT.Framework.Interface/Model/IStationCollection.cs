using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model
{
    public interface IStationCollection
    {
        IStationItem PortInStation { get; }

        void ResetToOrigin();
    }
}
