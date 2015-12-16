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
using QuikApp.UI.Controls.DetailsPanels;

namespace QuikApp.UI.Controls
{
    public partial class DetailsManagerControl : UserControl
    {
        private List<IDetailsPanel> detailsPanel = new List<IDetailsPanel>();
        private IDetailsPanel current;

        public DetailsManagerControl()
        {
            InitializeComponent();

            RootDetailsPanel rootPanel = new RootDetailsPanel();
            detailsPanel.Add(rootPanel);

            ModelDetailsPanel modelPanel = new ModelDetailsPanel();
            detailsPanel.Add(modelPanel);

            PropertyDetailsPanel propertyPanel = new PropertyDetailsPanel();
            detailsPanel.Add(propertyPanel);

            UIRepository.Instance.UIUpdater.ModelSelectionChanged += UIUpdater_ModelSelectionChanged;
        }

        void UIUpdater_ModelSelectionChanged(object sender, ModelSelectionArgs args)
        {
            SwitchDetailsPanel(sender, args);
        }

        private void SwitchDetailsPanel(object sender, ModelSelectionArgs args)
        {
            Type type = null;
            Object data = null;
            if (args.SelectionType == ModelSelectionType.Root)
            {
                type = typeof(RootDef);
                data = args.RootDef;
            }
            else if (args.SelectionType == ModelSelectionType.Model)
            {
                type = typeof(ModelDef);
                data = args.ModelDef;
            }
            else if (args.SelectionType == ModelSelectionType.Property)
            {
                type = typeof(PropertyDef);
                data = args.PropertyDef;
            }

            SwitchDetailsPanel(sender, type, data);
        }


        private void SwitchDetailsPanel(object sender, Type type, Object data)
        {
            if (type == null)
            {
                return;
            }

            IDetailsPanel detailsPanel = FindDetailsPanelByType(type);
            if (detailsPanel != null)
            {
                if (current != null)
                {
                    Controls.Remove(current.DetailsControl);
                }
                current = detailsPanel;
                Controls.Add(current.DetailsControl);
                current.DetailsControl.Dock = DockStyle.Fill;
                current.UpdateDetails(data);
            }
        }

        private IDetailsPanel FindDetailsPanelByType(Type type)
        {
            foreach (IDetailsPanel p in detailsPanel)
            {
                if (p.DetailsType == type)
                {
                    return p;
                }
            }
            return null;
        }


    }
}
