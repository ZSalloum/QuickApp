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
using QuickApp.Generator.Generators.TT;
using System.IO;

namespace QuikApp.UI.Controls
{
    public partial class ModelDefTree : UserControl
    {
        private RootModelDefNode rootNode = new RootModelDefNode(new RootDef());

        public ModelDefTree()
        {
            InitializeComponent();
            UIRepository.Instance.UIUpdater.PropertyChanged += UIUpdater_PropertyChanged;
        }

        void UIUpdater_PropertyChanged(object sender, PropertyChangedArgs args)
        {
            if (args.PropertyName == PropertyChangedArgs.NAME)
            {
                TreeNode node = FindNode(rootNode, args.SourceObject);
                if (node != null)
                {
                    node.Text = args.NewValue.ToString();
                }
            }
        }


        public void FillTreeFromModels(ModelDef[] modelsDef)
        {
            trvModels.SuspendLayout();
            trvModels.Nodes.Clear();
            trvModels.Nodes.Add(rootNode);
            rootNode.Expand();

            foreach (ModelDef m in modelsDef)
            {
                AddModelToTree(m);
            }

            trvModels.ResumeLayout();
        }


        private void AddModelToTree(ModelDef modelDef)
        {
            ModelDefNode modelNode = new ModelDefNode(modelDef);
            rootNode.Nodes.Add(modelNode);

            foreach (PropertyDef p in modelDef.Properties)
            {
                AddPropertyToTree(modelNode, p);
            }
        }


        private void AddPropertyToTree(ModelDefNode modelNode, PropertyDef propertyDef){
            PropertyDefNode propertyNode = new PropertyDefNode(propertyDef);
            modelNode.Nodes.Add(propertyNode);
        }

        private void trvModels_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node is RootModelDefNode){
                UIRepository.Instance.UIUpdater.FireModelSelectionChangedEvent(e.Node, new ModelSelectionArgs(((RootModelDefNode)e.Node).RootDef));
            }
            else if(e.Node is ModelDefNode){
                UIRepository.Instance.UIUpdater.FireModelSelectionChangedEvent(e.Node, new ModelSelectionArgs(((ModelDefNode)e.Node).ModelDef));
            }
            else if(e.Node is PropertyDefNode){
                UIRepository.Instance.UIUpdater.FireModelSelectionChangedEvent(e.Node, new ModelSelectionArgs(((PropertyDefNode)e.Node).PropertyDef));
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RootDef rootDef = rootNode.RootDef;
            if (rootNode.Nodes.Count > 0)
            {
                ModelDefNode modelNode = (ModelDefNode)rootNode.Nodes[0];
                ModelTemplate modelTemplate = new ModelTemplate(modelNode.ModelDef);
                String srcCode = modelTemplate.TransformText();
                File.WriteAllText(String.Format("{0}.cs", modelNode.ModelDef.Name), srcCode);
            }
        }


        private TreeNode FindNode(TreeNode node, Object targetDef)
        {
            if (node is RootModelDefNode)
            {
                RootModelDefNode rootNode = (RootModelDefNode)node;
                if (rootNode.RootDef == targetDef)
                {
                    return rootNode;
                }
            }
            else if (node is ModelDefNode)
            {
                ModelDefNode modelNode = (ModelDefNode)node;
                if (modelNode.ModelDef == targetDef)
                {
                    return modelNode;
                }
            }
            else if (node is PropertyDefNode)
            {
                PropertyDefNode propertyNode = (PropertyDefNode)node;
                if (propertyNode.PropertyDef == targetDef)
                {
                    return propertyNode;
                }
            }


            foreach (TreeNode n in node.Nodes)
            {
                TreeNode found = FindNode(n, targetDef);
                if (found != null)
                {
                    return found;
                }
            }

            return null;
        }
    }

  
}
