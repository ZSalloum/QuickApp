using QuickApp.Generator.Definitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitTestData();
        }

        #region Test data init
        private void InitTestData()
        {
            ModelDef m = CreateExampleClassDef();
            modelDefTree.FillTreeFromModels(new ModelDef[] { m });
        }

        private static ModelDef CreateExampleClassDef()
        {
            ModelDef def = new ModelDef();
            def.Name = "Sample";
            def.DataClassName = "SampleData";
            def.WrapperClassName = "Sample";
            def.CollectionClassName = "Samples";
            def.Namespace = "com.generator.samples";
            //def.BaseClass = "BaseSample";
            def.UndoSupport = true;

            def.Properties = new List<PropertyDef>();
            PropertyDef pdef = new PropertyDef();
            pdef.Type = "String";
            pdef.Name = "FirstName";
            pdef.Accessor = PropertyAccessor.ReadWrite;
            SetAllOptions(pdef);
            def.Properties.Add(pdef);

            pdef = new PropertyDef();
            pdef.Type = "String";
            pdef.Name = "LastName";
            pdef.Accessor = PropertyAccessor.ReadWrite;
            SetAllOptions(pdef);
            def.Properties.Add(pdef);

            pdef = new PropertyDef();
            pdef.Type = "DateTime";
            pdef.Name = "Birthday";
            pdef.Accessor = PropertyAccessor.ReadWrite;
            SetAllOptions(pdef);
            def.Properties.Add(pdef);



            return def;
        }

        private static void SetAllOptions(PropertyDef pdef)
        {
            pdef.BubblesChangeEvent = true;
            pdef.CustomHandling = true;
            pdef.RaisesChangeEvent = PropertySupportValues.Yes;
            //pdef.UndoSupport = true;
            pdef.ValidatesInput = true;
        }
        #endregion
    }
}
