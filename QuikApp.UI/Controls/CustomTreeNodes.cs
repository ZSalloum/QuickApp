using QuickApp.Generator.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuikApp.UI.Controls
{
    public class BaseModelDefNode : TreeNode
    {
        public BaseModelDefNode(string text)
            : base(text)
        {

        }
        public BaseModelDefNode(string text, TreeNode[] children)
            : base(text, children)
        {

        }
        public BaseModelDefNode(string text, int imageIndex, int selectedImageIndex)
            : base(text, imageIndex, selectedImageIndex)
        {

        }
        public BaseModelDefNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children)
            : base(text, imageIndex, selectedImageIndex, children)
        {

        }
    }


    public class RootModelDefNode : BaseModelDefNode
    {
        private const String TITLE = "Models";
        private RootDef rootDef;

        public RootModelDefNode(RootDef rootDef)
            : base(TITLE)
        {
            this.rootDef = rootDef;
        }

        public RootModelDefNode(RootDef rootDef, int imageIndex, int selectedImageIndex)
            : base(TITLE, imageIndex, selectedImageIndex)
        {
            this.rootDef = rootDef;
        }


        public RootDef RootDef
        {
            get
            {
                return rootDef;
            }
        }
    }



    public class ModelDefNode : BaseModelDefNode
    {
        private ModelDef modelDef;

        public ModelDefNode(ModelDef modelDef)
            : base(modelDef.Name)
        {
            this.modelDef = modelDef;
        }
        public ModelDefNode(ModelDef modelDef, int imageIndex, int selectedImageIndex)
            : base(modelDef.Name, imageIndex, selectedImageIndex)
        {
            this.modelDef = modelDef;
        }

        public ModelDef ModelDef
        {
            get
            {
                return modelDef;
            }

            set
            {
                modelDef = value;
                Text = modelDef.Name;
            }

        }
    }


    public class PropertyDefNode : BaseModelDefNode
    {
        private PropertyDef propertyDef;

        public PropertyDefNode(PropertyDef propertyDef)
            : base(propertyDef.Name)
        {
            this.propertyDef = propertyDef;
        }

        public PropertyDefNode(PropertyDef propertyDef, int imageIndex, int selectedImageIndex)
            : base(propertyDef.Name, imageIndex, selectedImageIndex)
        {
            this.propertyDef = propertyDef;
        }

        public PropertyDef PropertyDef
        {
            get
            {
                return propertyDef;
            }

            set
            {
                propertyDef = value;
                Text = propertyDef.Name;
            }

        }
    }
}
