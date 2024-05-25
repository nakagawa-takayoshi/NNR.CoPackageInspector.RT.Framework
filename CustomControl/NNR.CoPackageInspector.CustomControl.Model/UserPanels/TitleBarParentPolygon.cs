
using NNR.CoPackageInspector.CustomControl.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.CustomControl.Model.UserPanels
{
    public class TitleBarParentPolygon : ITitleBarPolygon
    {
        private const float penSizeF = 0.0f;
        public GraphicsPath PolygonPath { get; } = new GraphicsPath();
        public GraphicsPath BoarderPath { get; } = new GraphicsPath();

        public Brush BackGroundBrash => Brushes.SkyBlue;

        public Pen PathPen { get; } = new Pen(Brushes.SkyBlue, penSizeF);

        public Brush DrawBrush { get; } = Brushes.Black;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBarParentPolygon(Point startPoint, Point endPoint, int index)
        {
            int widthMargin = 20;

            PolygonPath.AddPolygon(new Point[] {
                        new Point(startPoint.X,startPoint.Y),
                        new Point(endPoint.X, startPoint.Y),
                        new Point((endPoint.X + widthMargin), endPoint.Y / 2),
                        new Point(endPoint.X, endPoint.Y),
                        new Point(startPoint.X, endPoint.Y),
                        new Point((startPoint.X + widthMargin), endPoint.Y / 2),
                        new Point(startPoint.X,startPoint.Y),
                    });
        }
    }
}
