﻿using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPakageInspector.RT.MainApp.View.Dialogs;
using NNR.Liblary.Utility.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class PowerPanel : UserControl
    {
        public PowerPanel()
        {
            InitializeComponent();
        }

        private void _buttonPowerOff_Click(object sender, EventArgs e)
        {
            var dlg = new ApplicationExitAskForm();
            DialogResult dr = dlg.ShowDialog();

            if (dr == DialogResult.Cancel) return;

            var mainContext = MainAppContextProvider.GetInstance();

            mainContext.MainAppForm.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Black), new Point(ZeroTypes.IntZero, ZeroTypes.IntZero), new Point(Width, ZeroTypes.IntZero));

            base.OnPaint(e);
        }

    }
}
