using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace XZ_WPF
{
    public class XZTextBox:TextBox
    {



        public CornerRadius XZRadius
        {
            get { return (CornerRadius)GetValue(XZRadiusProperty); }
            set { SetValue(XZRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for XZRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XZRadiusProperty =
            DependencyProperty.Register("XZRadius", typeof(CornerRadius), typeof(XZTextBox), new PropertyMetadata(new CornerRadius(5)));



    }
}
