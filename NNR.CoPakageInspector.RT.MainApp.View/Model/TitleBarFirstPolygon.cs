using NNR.CoPakageInspector.RT.MainApp.View.Interface;
using NNR.Liblary.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.View.Model
{
    internal class TitleBarFirstPolygon : ITitleBarPolygon
    {
        private const float penSizeF = 2.0f;

        public GraphicsPath PolygonPath { get; } = new GraphicsPath();

        public Brush BackGroundBrash { get; }

        public GraphicsPath BoarderPath { get; } = new GraphicsPath();

        public Pen PathPen { get; }

        public Brush DrawBrush { get; }


        public TitleBarFirstPolygon(Point startPoint, Point endPoint, bool isTop)
        {
            const int widthMargin = 20;

            BackGroundBrash = (isTop) ? Brushes.SkyBlue : Brushes.White;

            PathPen = new Pen(((isTop) ? Brushes.Transparent : Brushes.DarkGray), penSizeF);

            BoarderPath.AddLine(new Point(endPoint.X , startPoint.Y),
                                new Point((endPoint.X + widthMargin), (endPoint.Y / 2)));
            BoarderPath.AddLine(new Point((endPoint.X + widthMargin), (endPoint.Y / 2)),
                                new Point(endPoint.X , endPoint.Y));

            PolygonPath.AddPolygon(new Point[] {
                        new Point(startPoint.X,startPoint.Y),
                        new Point(endPoint.X, startPoint.Y),
                        new Point((endPoint.X + widthMargin), endPoint.Y / 2),
                        new Point(endPoint.X, endPoint.Y),
                        new Point(startPoint.X, endPoint.Y),
                    });
            DrawBrush = (isTop) ? Brushes.Black : Brushes.DarkGray;
        }
    }
}
