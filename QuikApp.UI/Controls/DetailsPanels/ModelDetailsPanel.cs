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
    public partial class ModelDetailsPanel : BaseDetailsPanel, IDetailsPanel
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
            SuppressEvents();
            modelDef = detailsObject as ModelDef;
            if (modelDef == null)
            {
                return;
            }
            txbModelName.Text = Str.NoNull(modelDef.Name);
            ResumeEvents();
        }

        public Control DetailsControl
        {
            get { return this; }
        }

        private void txbModelName_TextChanged(object sender, EventArgs e)
        {
            modelDef.Name = txbModelName.Text;
            if (!AreEventsSuppressed())
            {
                UIRepository.Instance.UIUpdater.FirePropertyChangedEvent(this, new PropertyChangedArgs(modelDef, PropertyChangedArgs.NAME, modelDef.Name));
            }
        }
    }
}
