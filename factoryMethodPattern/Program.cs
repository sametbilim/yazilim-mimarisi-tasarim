using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD_PATTERN
{
 
    enum ScreenModel
    {
        Windows,
        Web,
        Mobile
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();

            Screen screenWindows = creator.ScreenFactory(ScreenModel.Windows);
            Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
            Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

            screenWindows.Draw();
            screenWeb.Draw();
            screenMobile.Draw();

            Console.ReadKey();
        }
    }
}
