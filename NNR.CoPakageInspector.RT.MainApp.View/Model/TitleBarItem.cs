using NNR.CoPakageInspector.RT.MainApp.View.Interface;
using NNR.CoPakageInspector.RT.MainApp.View.Model;
using NNR.CoPakageInspector.RT.MainApp.View.Model.Factory;
using NNR.Liblary.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NNR.CoPakageInspector.RT.MainApp.View.Model
{
    internal class TitleBarItem : ITitleBarItem
    {
        private ITitleBarPolygon _titleBarPolygon;
        private readonly string _caption;
        private readonly Point _startPoint;
        private Graphics _graphics = null;
        private int _captionY;
        private int _drawX = 0;

        ////////////////////////////
        /// プロパティ
        ////////////////////////////
        public GraphicsPath PolygonPath => _titleBarPolygon.PolygonPath;

        public int CaptionWidth { get; } = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBarItem(Graphics g, string caption, Point startPoint, Size parentSize, int index, bool isTopTitle)
        {
            _caption = caption;
            _startPoint = startPoint;
            var font = new Font(@"Meiryo UI", 24, FontStyle.Bold);
            var stringSize = g.MeasureString(caption, font).ToSize();
            CaptionWidth = stringSize.Width;
            _drawX = (index == 0) ? 0 : (startPoint.X + 30);
            var endPoint = new Point((startPoint.X + stringSize.Width + 30), parentSize.Height);

            var polygonFactory = new TitleBarPolygonFactory(startPoint, endPoint);
            _titleBarPolygon = polygonFactory.Create(index, isTopTitle);
            _graphics = g;
            _captionY = (parentSize.Height / 2) - (stringSize.Height / 2);
        }

        /// <summary>
        /// 描画
        /// </summary>
        public void Draw()
        {
            _graphics.FillPath(_titleBarPolygon.BackGroundBrash, _titleBarPolygon.PolygonPath);

            // キャプションを描画
            var font = new Font(@"Meiryo UI", 24, FontStyle.Bold);
            _graphics.DrawString(_caption, font, _titleBarPolygon.DrawBrush, new Point(_drawX, _captionY));

            if (_titleBarPolygon is TitleBarParentPolygon) return;
            _graphics.DrawPath(_titleBarPolygon.PathPen, _titleBarPolygon.BoarderPath);

        }
    }
}
