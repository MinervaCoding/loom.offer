using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loom.offer.Model;
using loom.offer.View;

namespace loom.offer.Controller
{
    class ControllerTextBausteine
    {


        public ControllerTextBausteine ()
        {

            SQLCon con = new SQLCon();
            TextBausteine bausteine = new TextBausteine();
            con.CreateLanguage();
            bausteine.Show();

        }


    }
}
