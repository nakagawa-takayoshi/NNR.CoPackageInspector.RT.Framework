using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit
{
    public interface IStateTransitionObsavable
    {
        IDisposable Subscribe(Action action);
    }
}
