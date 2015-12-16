using QuickApp.Generator.Definitions;
//using QuickApp.Generator.Generators.CSharp;
using QuickApp.Generator.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelDef def = CreateExampleClassDef();
            DefintionSerializer ser = new DefintionSerializer();
            ser.Save(def, "example.xml");

            //using (StreamWriter sw = new StreamWriter("Sample.Data.cs"))
            //{
            //    CSharpDataClassGenerator gen = new CSharpDataClassGenerator(def);
            //    gen.Generate(sw);
            //}

            //using (StreamWriter sw = new StreamWriter("Sample.Wrapper.cs"))
            //{
            //    CSharpWrapperClassGenerator gen = new CSharpWrapperClassGenerator(def);
            //    gen.Generate(sw);
            //}
        }

        private static ModelDef CreateExampleClassDef(){
            ModelDef def = new ModelDef();
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

        private static  void SetAllOptions(PropertyDef pdef)
        {
            pdef.BubblesChangeEvent = true;
            pdef.CustomHandling = true;
            pdef.RaisesChangeEvent = PropertySupportValues.Yes;
            //pdef.UndoSupport = true;
            pdef.ValidatesInput = true;
        }
    }
}
