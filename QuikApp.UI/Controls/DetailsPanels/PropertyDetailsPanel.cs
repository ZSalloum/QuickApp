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
    public partial class PropertyDetailsPanel : BaseDetailsPanel, IDetailsPanel
    {
        private PropertyDef propertyDef;
        private String[] types;

        public PropertyDetailsPanel()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            types = new String[]{"bool", 
                                "byte", 
                                "char", 
                                "DateTime", 
                                "decimal", 
                                "double", 
                                "float", 
                                "int", 
                                "long", 
                                "object", 
                                "sbyte", 
                                "short", 
                                "String", 
                                "uint", 
                                "ulong",
            "Reference"};

            cbxType.Items.AddRange(types);
        }

        public Type DetailsType
        {
            get { return typeof(PropertyDef); }
        }

        public void UpdateDetails(object detailsObject)
        {
            SuppressEvents();
            propertyDef = detailsObject as PropertyDef;
            if (propertyDef == null)
            {
                return;
            }
            txbPropertyName.Text = Str.NoNull(propertyDef.Name);
            cbxType.SelectedItem = propertyDef.Type;
            ResumeEvents();
        }

        public Control DetailsControl
        {
            get { return this; }
        }

        private void txbPropertyName_TextChanged(object sender, EventArgs e)
        {
            propertyDef.Name = txbPropertyName.Text;
            if (!AreEventsSuppressed())
            {
                UIRepository.Instance.UIUpdater.FirePropertyChangedEvent(this, new PropertyChangedArgs(propertyDef, PropertyChangedArgs.NAME, propertyDef.Name));
            }
        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {
            propertyDef.Description = txbPropertyName.Text;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyDef.Type = cbxType.SelectedItem as String;
        }

        private void rdbAccessReadonly_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.Accessor = PropertyAccessor.Readonly;
        }

        private void rdbAccessReadWrite_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.Accessor = PropertyAccessor.ReadWrite;
        }

        private void rdbCardinalitySingle_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.Cardinality = PropertyCardinality.Single;
        }

        private void rdbCardinalityList_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.Cardinality = PropertyCardinality.List;
        }

        private void rdbCarindalityArray_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.Cardinality = PropertyCardinality.Array;
        }

        private void rdbValidateValuesYes_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.ValidatesInput = true;
        }

        private void rdbValidateValuesNo_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.ValidatesInput = false;
        }

        private void txbAcceptableValues_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbChangeEventDefault_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.RaisesChangeEvent = PropertySupportValues.Default;
        }

        private void rdbChangeEventYes_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.RaisesChangeEvent = PropertySupportValues.Yes;
        }

        private void rdbChangeEventNo_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.RaisesChangeEvent = PropertySupportValues.No;
        }

        private void rdbScriptDefault_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.ScriptSupport = PropertySupportValues.Default;
        }

        private void rdbScriptYes_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.ScriptSupport = PropertySupportValues.Yes;
        }

        private void rdbScriptNo_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.ScriptSupport = PropertySupportValues.No;
        }

        private void rdbInvalidInputException_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.OnInvalidInput = InvalidInputOptions.Exception;
        }

        private void rdbInvalidInputIgnore_CheckedChanged(object sender, EventArgs e)
        {
            propertyDef.OnInvalidInput = InvalidInputOptions.Ignore;
        }
    }
}
