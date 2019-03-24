using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using loom.offer.Controller;

namespace loom.offer
{
    public partial class RibbonBar
    {
        private void RibbonBar_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void textbausteine_Click(object sender, RibbonControlEventArgs e)
        {
            ControllerTextBausteine textBausteine = new ControllerTextBausteine();
        }
    }
}
