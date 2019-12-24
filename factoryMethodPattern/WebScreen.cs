using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD_PATTERN
{
    class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web Ekranı");
        }

    }
}
