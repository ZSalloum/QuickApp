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
using QuickApp.Runtime.Common.Tools;

namespace QuikApp.UI.Controls.DetailsPanels
{
    public partial class ModelDetailsPanel : UserControl, IDetailsPanel
    {
        private ModelDef modelDef;

        public ModelDetailsPanel()
        {
            InitializeComponent();
        }

        public Type DetailsType
        {
            get { return typeof(ModelDef); }
        }

        public void UpdateDetails(object detailsObject)
        {
            modelDef = detailsObject as ModelDef;
            if (modelDef == null)
            {
                return;
            }
            txbModelName.Text = Str.NoNull(modelDef.Name);
        }

        public Control DetailsControl
        {
            get { return this; }
        }
    }
}
