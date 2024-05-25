using NNR.CoPackageInspector.CustomControl.Interface;
using NNR.CoPackageInspector.CustomControl.Model.UserPanels;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.CustomControl.View
{
    internal class TitleBarItem : ITitleBarItem
    {
        private ITitleBarPolygon _titleBarPolygon;
        private readonly string _caption;
        private readonly Point _startPoint;
        private Graphics _graphics = null;
        private int _captionY;
        private int _drawX = 0;
        private int _fontSize = 24;
        private Button _button;

        ////////////////////////////
        /// プロパティ
        ////////////////////////////
        public GraphicsPath PolygonPath => _titleBarPolygon.PolygonPath;

        public int CaptionWidth { get; } = 0;

        public Button Button => _button;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBarItem(Graphics g, string caption, Point startPoint, Size parentSize, int fontSize, int index, bool isTopTitle)
        {
            _caption = caption;
            _startPoint = startPoint;
            _fontSize = fontSize;
            var font = new Font(@"Meiryo UI", fontSize, FontStyle.Bold);
            var stringSize = g.MeasureString(caption, font).ToSize();
            CaptionWidth = stringSize.Width;
            _drawX = (index == 0) ? 0 : (startPoint.X + 20);
            int rightMargin = (index == 0) ? 0 : 20;
            var endPoint = new Point((startPoint.X + stringSize.Width + rightMargin), parentSize.Height);

            _button = new Button();
            _button.Visible = true;
            _button.Location = startPoint;
            _button.Size = new Size(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            _button.BackColor = Color.Transparent;
            _button.FlatStyle = FlatStyle.Flat;
            _button.Cursor = Cursors.Arrow;
            _button.FlatAppearance.BorderSize = 0;
            _button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            _button.FlatAppearance.MouseDownBackColor = Color.Transparent;

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
            var font = new Font(@"Meiryo UI", _fontSize, FontStyle.Bold);
            _graphics.DrawString(_caption, font, _titleBarPolygon.DrawBrush, new Point(_drawX, _captionY));

            if (_titleBarPolygon is TitleBarParentPolygon) return;
            _graphics.DrawPath(_titleBarPolygon.PathPen, _titleBarPolygon.BoarderPath);

        }
    }
}
