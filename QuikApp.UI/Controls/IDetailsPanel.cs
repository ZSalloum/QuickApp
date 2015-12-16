using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuikApp.UI.Controls
{
    public interface IDetailsPanel
    {
        Type DetailsType { get; }
        
        void UpdateDetails(Object detailsObject);

        Control DetailsControl { get; }
    }
}
