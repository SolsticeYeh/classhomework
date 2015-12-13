using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace hwk
{
   public  class iConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if((String)value!="")
                return value.ToString() + "牌";
            else
                return value.ToString();

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
