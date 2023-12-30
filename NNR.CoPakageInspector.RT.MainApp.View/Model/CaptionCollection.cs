using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.View.Model
{
    internal class CaptionCollection : List<string>
    {
        public int Max => (base.Count == 0) ? 0 :  (base.Count - 1);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CaptionCollection()
        {

        }
        public new void Add(string caption)
        {
            base.Add(caption);
        }
    }
}
