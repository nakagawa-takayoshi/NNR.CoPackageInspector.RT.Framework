using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class TitleBar : UserControl
    {

        public List<string> Captions { get; set; } = new List<string>();
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
            var font = new Font(@"Meiryo UI", 24, FontStyle.Bold);

            var firstBar = new GraphicsPath();
            var g = e.Graphics;

            if (Captions.Count == 1)
            {
                var size = g.MeasureString(Captions[0], font);
                var captionY = (Size.Height / 2) - (size.Height / 2);

                firstBar.AddPolygon(new Point[] {
                new Point(0,0),
                new Point((int)size.Width, 0),
                new Point((int)size.Width+30, Size.Height / 2),
                new Point((int)size.Width, Size.Height),
                new Point(0,Size.Height),
                    });
                g.FillPath(Brushes.SkyBlue, firstBar);
                g.DrawString(Captions[0], font, Brushes.Black, new Point(0, (int)captionY));
            }

            for(int ii=1; ii <Captions.Count; ii++)
            {

            }
            base.OnPaint(e);
        }
    }
}
