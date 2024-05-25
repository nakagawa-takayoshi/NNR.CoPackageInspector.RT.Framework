using NNR.CoPackageInspector.CustomControl.Interface;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NNR.CoPackageInspector.CustomControl.Model.UserPanels
{
    public class TitleBarChildPolygon : ITitleBarPolygon
    {
        private const float penSizeF = 1.0f;
        public GraphicsPath PolygonPath { get; } = new GraphicsPath();

        public GraphicsPath BoarderPath { get; } = new GraphicsPath();

        public Brush BackGroundBrash => Brushes.White;

        public Pen PathPen { get; } =  new Pen(Brushes.DarkGray, penSizeF);

        public Brush DrawBrush { get; } = Brushes.DarkGray;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBarChildPolygon(Point startPoint, Point endPoint,int index)
        {
            int widthMargin = 20;

            BoarderPath.AddLine(new Point(startPoint.X, startPoint.Y),
                                new Point((startPoint.X + widthMargin), (endPoint.Y / 2)));
            BoarderPath.AddLine(new Point((startPoint.X + widthMargin), (endPoint.Y / 2)),
                                new Point(startPoint.X, endPoint.Y));
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
