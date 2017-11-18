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
        public void addButton_Click()
        {
            MessageBoxResult result = MessageBox.Show("Result","Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
