using RoundRobin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class AutoPilotOperationPanel : UserControl
    {
        private RoundRobinList<Bitmap> raundRobinBitmap;

        private bool _isRotate = false;
        private bool _isResetToOrign = false;
        private object _isRotateLock = new object();

        public bool Rotate
        {
            get
            {
                lock (_isRotateLock)
                {
                    return _isRotate;
                }
            }

            set
            {
                lock (_isRotateLock)
                {
                    _isResetToOrign = false;
                    _isRotate = value;
                }
            }
        }

        public bool ResetToOrigin
        {
            get
            {
                lock (_isRotateLock)
                {
                    return _isResetToOrign;
                }
            }

            set
            {
                lock(_isRotateLock)
                {
                    _isResetToOrign = value;
                    _isRotate = value;
                }
            }
        }


        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AutoPilotOperationPanel()
        {
            InitializeComponent();
        }

        ~AutoPilotOperationPanel()
        {
            Dispose();
            raundRobinBitmap.Reset();
            var bitmap = raundRobinBitmap.Next();
            while (bitmap.GetHbitmap() != null)
            {
                bitmap.Dispose();
                bitmap = raundRobinBitmap.Next();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var bitmap1 = new Bitmap(_pictureBoxArc.Width, _pictureBoxArc.Height);
            using (var g = Graphics.FromImage(bitmap1))
            {
                Pen pen1 = new Pen(Brushes.DarkGreen, 10.0f);
                Pen pen2 = new Pen(Brushes.DarkGray, 10.0f);

                var rect = new Rectangle(0, 0, _pictureBoxArc.Width, _pictureBoxArc.Height);

                g.DrawArc(pen1, rect, 15.0f, 10.0f);
                g.DrawArc(pen2, rect, 60.0f, 15.0f);
                g.DrawArc(pen1, rect, 110.0f, 15.0f);
                g.DrawArc(pen2, rect, 155.0f, 10.0f);
                g.DrawArc(pen1, rect, 196.0f, 10.0f);
                g.DrawArc(pen2, rect, 235.0f, 15.0f);
                g.DrawArc(pen1, rect, 288.0f, 15.0f);
                g.DrawArc(pen2, rect, 334.0f, 10.0f);
            }

            var bitmap2 = new Bitmap(_pictureBoxArc.Width, _pictureBoxArc.Height);
            using (var g = Graphics.FromImage(bitmap2))
            {
                Pen pen1 = new Pen(Brushes.DarkGreen, 10.0f);
                Pen pen2 = new Pen(Brushes.DarkGray, 10.0f);

                var rect = new Rectangle(0, 0, _pictureBoxArc.Width, _pictureBoxArc.Height);

                g.DrawArc(pen2, rect, 15.0f, 10.0f);
                g.DrawArc(pen1, rect, 60.0f, 15.0f);
                g.DrawArc(pen2, rect, 110.0f, 15.0f);
                g.DrawArc(pen1, rect, 155.0f, 10.0f);
                g.DrawArc(pen2, rect, 196.0f, 10.0f);
                g.DrawArc(pen1, rect, 235.0f, 15.0f);
                g.DrawArc(pen2, rect, 288.0f, 15.0f);
                g.DrawArc(pen1, rect, 334.0f, 10.0f);
            }

            raundRobinBitmap = new RoundRobinList<Bitmap>(new List<Bitmap>() { bitmap1, bitmap2 });

            lock(_isRotateLock)
            {
                _isRotate = true;
                _isResetToOrign = false;
            }

            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        public new void Dispose()
        {
            base.Dispose();

            
        }

        private void _pictureBoxRotalyTable_Paint(object sender, PaintEventArgs e)
        {
            if (!_isRotate)
            {
                raundRobinBitmap.Reset();
                _pictureBoxArc.Image = raundRobinBitmap.Next();

            }
            else 
            {
                var task = Task.Run(() =>
                {
                    int count = (_isResetToOrign) ? int.MaxValue : 5;
                    int ii = 0;
                    raundRobinBitmap.Reset();
                    while (ii < count)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            _pictureBoxArc.Image = raundRobinBitmap.Next();
                        });
                        Thread.Sleep(200);
                        ii++;
                    }
                    lock(_isRotateLock)
                    {
                        _isRotate = false;
                        _isResetToOrign = false;
                    }
                });
            }

        }
    }
}
