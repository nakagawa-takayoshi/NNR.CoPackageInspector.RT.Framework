using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;

namespace NNR.CoPackageInspector.RT.Framework.Interface.EventArguments
{
    public class WorkSizeChanedEventArg : System.EventArgs
    {
        private IWorkpieceSize _size;

        public IWorkpieceSize Size => _size;

        public WorkSizeChanedEventArg(IWorkpieceSize size)
        {
            _size = size;
        }
    }
}
