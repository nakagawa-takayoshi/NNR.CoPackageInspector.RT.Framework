using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller
{
    public static class TriggerKeyController
    {
        public static void Trigger(ITriggerKey triggerKey)
        {
            triggerKey.TriggerHandle.Set();
        }
    }
}
