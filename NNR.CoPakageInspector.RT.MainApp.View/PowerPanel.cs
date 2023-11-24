using NNR.CoPackageInspector.RT.MainApp.Interface;
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
            var mainContext = MainAppContextProvider.GetInstance();

            mainContext.MainAppForm.Close();
        }
    }
}
