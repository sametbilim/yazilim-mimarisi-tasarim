using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD_PATTERN
{
    class Creator
    {

        public Screen ScreenFactory(ScreenModel screenModel)
        {
            Screen screen = null;

            switch (screenModel)
            {
                case ScreenModel.Windows:
                    screen = new WinScreen();
                    break;

                case ScreenModel.Web:
                    screen = new WebScreen();
                    break;

                case ScreenModel.Mobile:
                    screen = new MobileScreen();
                    break;

            }

            return screen;
        }

    }
}
