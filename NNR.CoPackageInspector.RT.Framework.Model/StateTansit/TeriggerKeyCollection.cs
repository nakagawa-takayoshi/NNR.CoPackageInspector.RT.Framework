using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.StateTansit
{
    public class TeriggerKeyCollection
    {
        private List<ITriggerKey> _triggerKeys;

        public IEnumerable<ITriggerKey> TriggerKeys => _triggerKeys;

        public TeriggerKeyCollection()
        {
        }

        public void Add(ITriggerKey triggerKey)
        {
            _triggerKeys.Add(triggerKey);
        }
    }
}
