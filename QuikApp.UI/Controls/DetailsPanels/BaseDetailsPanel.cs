using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuikApp.UI.Controls.DetailsPanels
{
    public class BaseDetailsPanel : UserControl
    {
        private int suppressEvents;

        protected void SuppressEvents()
        {
            suppressEvents++;
        }

        protected void ResumeEvents()
        {
            suppressEvents = Math.Max(--suppressEvents, 0);
        }

        protected bool AreEventsSuppressed()
        {
            return suppressEvents > 0;
        }
    }
}
