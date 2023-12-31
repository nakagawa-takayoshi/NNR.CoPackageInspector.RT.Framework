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

        public int FontSize { get; set; } = 24;

        private CaptionCollection _captions = new CaptionCollection();
        private List<GraphicsPath> _titleBarPath = new List<GraphicsPath>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CaptionCollection captions = new CaptionCollection();
            var splitedCaptions = Captions.Split(',');
            captions.AddRange(splitedCaptions);
            int maxCaptions = (captions.Count - 1);

            var g = Graphics.FromHwnd(Handle);

            Point nextPoint = new Point(0, ZeroTypes.IntZero);

            int ii = 0;
            foreach (var caption in captions)
            {
                bool isTop = (ii == captions.Max);
                var titleBarItem = new TitleBarItem(g, caption, nextPoint, Size, FontSize, ii, isTop);

                Controls.Add(titleBarItem.Button);

                nextPoint = new Point((int)(nextPoint.X + titleBarItem.CaptionWidth + (titleBarItem.CaptionWidth * 0.1f)), ZeroTypes.IntZero);
                ii++;
            }

            base.OnLoad(e);
        }


        /// <summary>
        /// 描画
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            _captions.Clear();

            var splitedCaptions = Captions.Split(',');
            _captions.AddRange(splitedCaptions);
            int maxCaptions = (_captions.Count - 1);

            var g = e.Graphics;
            Point nextPoint = new Point(0, ZeroTypes.IntZero);

            int ii = 0;
            foreach(var caption in _captions)
            {
                bool isTop = (ii == _captions.Max);
                var titleBarItem = new TitleBarItem(g, caption, nextPoint, Size, FontSize, ii, isTop);
                titleBarItem.Draw();

                nextPoint = new Point((int)(nextPoint.X + titleBarItem.CaptionWidth + 30), ZeroTypes.IntZero);
                ii++;
            }

            base.OnPaint(e);
        }
    }
}
