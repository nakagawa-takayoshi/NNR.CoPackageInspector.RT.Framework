using NNR.CoPackageInspector.RT.MainApp.Interface.Model;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public interface IMainAppContextWriter
    {

        IMainAppModel MainAppModel { set; }

        IMainAppControllers MainAppControllers { set; }
    }
}
