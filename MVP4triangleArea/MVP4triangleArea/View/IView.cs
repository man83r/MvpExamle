using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP4triangleArea.View
{
    public interface IView
    {
        string Side1 { get; set; }

        string Side2 { get; set; }

        string Side3 { get; set; }

        string Area { get; set; }
    }
}
