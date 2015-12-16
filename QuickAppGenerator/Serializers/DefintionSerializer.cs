using QuickApp.Generator.Definitions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickApp.Generator.Serializers
{
    public class DefintionSerializer
    {
        public ModelDef Load(String file)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ModelDef));
            using (StreamReader sr = new StreamReader(file))
            {
                ModelDef def = (ModelDef)ser.Deserialize(sr);
                return def;
            }
        }


        public void Save(ModelDef def, String file)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ModelDef));
            using (Stream st = new FileStream(file, FileMode.Create))
            {
                ser.Serialize(st, def);
            }
        }
    }
}
