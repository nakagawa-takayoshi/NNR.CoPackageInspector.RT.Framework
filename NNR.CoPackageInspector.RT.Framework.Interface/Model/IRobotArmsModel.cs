using NNR.Liblary.Utility.Maybe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model
{
    public interface IRobotArmsModel
    {
        IDisposable Disposable { get; }

        SemaphoreSlim Owned { get; }

        void AttachWorkpiece(IWorkpieceModel workpieceModel);

        void DettachWorkpiece(out IMaybe<IWorkpieceModel> workpiece);
    }
}
