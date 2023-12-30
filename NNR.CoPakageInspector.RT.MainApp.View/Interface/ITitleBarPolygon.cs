using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.View.Interface
{
    internal interface ITitleBarPolygon
    {
        GraphicsPath PolygonPath { get; }

        Brush BackGroundBrash  { get; }

        GraphicsPath BoarderPath { get; }

        Pen PathPen { get; }

        Brush DrawBrush { get; }
    }
}
