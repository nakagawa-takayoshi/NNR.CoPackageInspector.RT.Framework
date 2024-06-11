using NNR.CoPackageInspector.CustomControl.Model;
using NNR.Liblary.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.CustomControl.View
{
    /// <summary>
    /// タイトルバーのユーザーコントロール
    /// </summary>
    public partial class TitleBar : UserControl
    {
        private bool _isReturnButton = false;
        public string Captions { get; set; } = string.Empty;

        public int FontSize { get; set; } = 24;

        private CaptionCollection _captions = new CaptionCollection();
        private List<GraphicsPath> _titleBarPath = new List<GraphicsPath>();

        public bool IsReturnButton { get => _isReturnButton;

            set
            {
                _isReturnButton = value;

                _returnButton.Visible = value;
            } 
        }

        public event EventHandler ReturnButtonClicked
        {
            add
            {
                _returnButton.Click += value;
            }

            remove
            {
                _returnButton.Click -= value;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TitleBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時のイベントハンドラ
        /// </summary>
        /// <param name="e"></param>
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

            _returnButton.Visible = _isReturnButton;

            base.OnLoad(e);
        }

        /// <summary>
        /// サイズ変更時のイベントハンドラ
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            if (!_isReturnButton) return;

            _returnButton.Width = (int)(Height * 2);   
            _returnButton.Height = Height;
            _returnButton.Location = new Point(Width - _returnButton.Width - (Margin.All*4) - (_returnButton.FlatAppearance.BorderSize*4) , 0);

            base.OnSizeChanged(e);
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
                int rightMargin = (ZeroTypes.IntZero == ii) ? ZeroTypes.IntZero : 30;
                nextPoint = new Point((int)(nextPoint.X + titleBarItem.CaptionWidth + rightMargin), ZeroTypes.IntZero);
                ii++;
            }

            base.OnPaint(e);
        }
    }
}
