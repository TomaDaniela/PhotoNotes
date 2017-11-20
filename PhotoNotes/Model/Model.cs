using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModelNamespace
{
    public class Model
    {
       public MessageBoxResult result;
     public  void addButtonClick()
        {
            result = MessageBox.Show("Message", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }

    
}
