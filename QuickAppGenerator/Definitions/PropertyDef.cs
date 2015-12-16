using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickApp.Generator.Definitions
{
    public enum PropertyAccessor {Readonly, ReadWrite};
    public enum PropertyCardinality { Single, List, Array};
    public enum PropertySupportValues {Default, Yes, No};
    public enum InvalidInputOptions{Exception, Ignore};

    public class PropertyDef
    {
        public const String PROP_CONST_PREFIX = "PROP_";
        private String constPropretyName = "";
        private String name;

        public String Name {
            get
            {
                return name;
            }
            set{
                name = value;
                constPropretyName = String.Format("{0}{1}", PROP_CONST_PREFIX, name.ToUpper());
            }
        }

        public String Description
        {
            get;
            set;
        }

        public String Type { get; set; }

        public PropertyAccessor Accessor {get; set;}

        public PropertyCardinality Cardinality { get; set; }

        public PropertySupportValues RaisesChangeEvent { get; set; }
        public bool BubblesChangeEvent{get; set;}
        public bool ValidatesInput { get; set; }
        public bool CustomHandling { get; set; }
        public InvalidInputOptions OnInvalidInput {get; set;}
        public PropertySupportValues ScriptSupport { get; set; }
        //public bool UndoSupport { get; set; }

        public String ConstantPropertyName
        {
            get
            {
                return constPropretyName;
            }
        }

    }
}
