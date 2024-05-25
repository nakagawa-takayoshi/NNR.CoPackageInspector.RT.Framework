using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit
{
    public interface ITriggerKey
    {
        EventWaitHandle TriggerHandle { get; }

        event Action Triggered;

        void OnTriggered();
    }
}
