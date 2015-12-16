using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickApp.Generator.Definitions;

namespace QuikApp.UI.Controls.DetailsPanels
{
    public partial class RootDetailsPanel : UserControl, IDetailsPanel
    {
        public RootDetailsPanel()
        {
            InitializeComponent();
        }

        public Type DetailsType
        {
            get { return typeof(RootDef); }
        }

        public void UpdateDetails(object detailObject)
        {
            throw new NotImplementedException();
        }

        public Control DetailsControl
        {
            get { return this; }
        }
    }
}
