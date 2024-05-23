using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View.UserPanels
{
    public partial class ReadOnlyWorkpiecePanel : UserControl
    {
        public ReadOnlyWorkpiecePanel()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Parent is System.Windows.Forms.Button button)
            {
                button.PerformClick();
            }
        }


        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            BackColor = SystemColors.ControlDark;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = SystemColors.ButtonFace;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            BackColor = SystemColors.ButtonFace;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            BackColor = SystemColors.ControlDark;
        }
    }
}
