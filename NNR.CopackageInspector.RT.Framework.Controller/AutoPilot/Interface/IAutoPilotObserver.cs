using NNR.CopackageInspector.RT.Framework.Model;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Controller.Interface
{
    public interface IAutoPilotObserver: IDisposable
    {
        Task<AutoPilotResult> PreExecute();

        Task<AutoPilotResult> Execute();

        void PushBackWorkpieceResult(WorkpieceInspectResult result);
    }
}
