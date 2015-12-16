using QuikApp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikApp.UI
{
    public class UIRepository
    {
        private static UIRepository instance;

        private UIUpdater uiUpdater = new UIUpdater();

        private UIRepository() { }

        public static UIRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UIRepository();
                }

                return instance;
            }
        }


        public UIUpdater UIUpdater
        {
            get
            {
                return uiUpdater;
            }
        }
    }
}
