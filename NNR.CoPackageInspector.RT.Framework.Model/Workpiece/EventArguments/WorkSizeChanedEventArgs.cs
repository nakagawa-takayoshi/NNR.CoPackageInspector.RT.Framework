using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using NNR.CopackageInspector.RT.Framework.Model.Workpiece;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model.EventArguments
{
    public class WorkSizeChanedEventArg : System.EventArgs
    {
        private WorkpieceSize _size;

        public WorkpieceSize Size => _size;

        public WorkSizeChanedEventArg(WorkpieceSize size)
        {
            _size = size;
        }
    }
}
