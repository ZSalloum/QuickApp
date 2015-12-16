using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickApp.Generator.Definitions
{
    [XmlRoot("ClassDef")]
    public class ModelDef
    {
        public String Name { get; set; }
        public String BaseClass { get; set; }
        public String DataClassName { get; set; }
        public String WrapperClassName { get; set; }
        public String CollectionClassName { get; set; }
        public String Namespace { get; set; }

        public bool UndoSupport { get; set; }
        public bool ScriptSupport { get; set; }
        public bool EventSupport { get; set; }
        public bool DatabaseSupport { get; set; }

        public List<PropertyDef> Properties { get; set; }
    }
}
