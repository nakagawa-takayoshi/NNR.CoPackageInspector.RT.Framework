using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections;
using System;
using System.Collections.Generic;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Collections
{
    public class PanelsCollection<T> : IPanelsCollection<T> where T : Enum
    {

        private Dictionary<T, Func<IDisposable>> _panels = new Dictionary<T, Func<IDisposable>>();

        public Func<IDisposable> this[T panelType]  => _panels[panelType];

        public PanelsCollection()
        {
        }

        public void Add(T panelType, Func<IDisposable> func)
        {
            _panels.Add(panelType, func);
        }

    }
}
