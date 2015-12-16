using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickApp.Generator.Generators
{
    public interface IPropertyGenerator
    {
        void Generate(TextWriter wrt);
    }
}
