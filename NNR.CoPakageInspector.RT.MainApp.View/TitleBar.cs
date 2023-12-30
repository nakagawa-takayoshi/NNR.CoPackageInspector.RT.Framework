using NNR.CoPakageInspector.RT.MainApp.View.Model;
using NNR.CoPakageInspector.RT.MainApp.View.Model.Factory;
using NNR.Liblary.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class TitleBar : UserControl
    {
        public string Captions { get; set; } = string.Empty;

        private CaptionCollection _captions = new CaptionCollection();
        private List<GraphicsPath> _titleBarPath = new List<GraphicsPath>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 描画
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            _captions.Clear();

            var font = new Font(@"Meiryo UI", 24, FontStyle.Bold);
            var splitedCaptions = Captions.Split(',');
            _captions.AddRange(splitedCaptions);
            int maxCaptions = (_captions.Count - 1);

            var g = e.Graphics;
            Point nextPoint = new Point(0, ZeroTypes.IntZero);

            int ii = 0;
            foreach(var caption in _captions)
            {
                bool isTop = (ii == _captions.Max);
                var titleBarItem = new TitleBarItem(g, caption, nextPoint, Size, ii, isTop);
                titleBarItem.Draw();

                nextPoint = new Point((nextPoint.X + titleBarItem.CaptionWidth + 30), ZeroTypes.IntZero);
                ii++;
            }

#if false
            if (_captions.Count > 0)
            {
                var size = g.MeasureString(_captions[0].ToString(), font).ToSize();
                var captionY = (Size.Height / 2) - (size.Height / 2);
                var endPoint = new Size(0, Size.Height);

                TitleBarPolygonFactory titleBarPolygonFactory = new TitleBarPolygonFactory(new Point(0, 0),
                                                                                            new Point(0, Size.Height));
                var polygon = titleBarPolygonFactory.Create((_captions.Count == 1));

                var firstBar = new GraphicsPath();
                firstBar.AddPolygon(new Point[] {
                        new Point(0,0),
                        new Point(size.Width, 0),
                        new Point((size.Width + 30), Size.Height / 2),
                        new Point((int)size.Width, Size.Height),
                        new Point(0,Size.Height),
                    });
                var fillBrush = (_captions.Count == 1) ? Brushes.SkyBlue : Brushes.White;
                g.FillPath(fillBrush, firstBar);
                var charBrush = (_captions.Count == 1) ? Brushes.Black : Brushes.DarkGray;
                g.DrawString(_captions[0].ToString(), font, charBrush, new Point(0, (int)captionY));
                nextPoint = new Point(size.Width + 1, Size.Height);
            }

            for(int ii=1; ii < _captions.Count; ii++)
            {
                var size = g.MeasureString(_captions[ii].ToString(), font).ToSize();
                var captionY = (Size.Height / 2) - (size.Height / 2);
                var currentEndPoint = new Point((nextPoint.X + (size.Width + 30)), Size.Height);
                var barBg = new GraphicsPath();

                barBg.AddPolygon(new Point[] {
                    new Point(nextPoint.X, ZeroTypes.IntZero),
                    new Point(currentEndPoint.X, ZeroTypes.IntZero),
                    new Point((currentEndPoint.X + 30), (currentEndPoint.Y / 2)),
                    new Point(currentEndPoint.X, currentEndPoint.Y),
                    new Point(nextPoint.X,currentEndPoint.Y),
                    new Point((nextPoint.X + 30), (currentEndPoint.Y / 2)),
                    new Point(nextPoint.X, ZeroTypes.IntZero),
                    });

                var fillBrush = (maxCaptions == ii) ? Brushes.SkyBlue : Brushes.White;
                var pen = new Pen(Brushes.DarkGray, 1.0f);
                if (maxCaptions > ii)
                {
                    g.FillPath(fillBrush, barBg);
                    g.DrawPath(pen, barBg);
                }
                else
                {
                    g.FillPath(fillBrush, barBg);
                }
                var charBrush = (maxCaptions == ii) ? Brushes.Black : Brushes.DarkGray;
                g.DrawString(_captions[ii].ToString(), font, charBrush, new Point((nextPoint.X + 25), (int)captionY));
                nextPoint = new Point((nextPoint.X + size.Width + 1), Size.Height);
            }

#endif
            base.OnPaint(e);
        }
    }
}
