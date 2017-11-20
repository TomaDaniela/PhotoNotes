using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelNamespace;

namespace ControllerNamespace
{
    public class Controller
    {
        public Model model;
     public   Controller()
        {
            model = new Model();
            model.addButtonClick();
        }
           
        
    }
}
