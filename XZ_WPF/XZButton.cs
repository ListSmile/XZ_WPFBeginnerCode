using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XZ_WPF
{
    public class XZButton:Button
    {
        public CornerRadius XZCornerRadius
        {
            get { return (CornerRadius)GetValue(XZCornerRadiusProperty); }
            set { SetValue(XZCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for XZCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XZCornerRadiusProperty =
            DependencyProperty.Register("XZCornerRadius", typeof(CornerRadius), typeof(XZButton));





        public Brush BackGroundHover
        {
            get { return (Brush)GetValue(BackGroundHoverProperty); }
            set { SetValue(BackGroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackGroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackGroundHoverProperty =
            DependencyProperty.Register("BackGroundHover", typeof(Brush), typeof(XZButton), new PropertyMetadata(Brushes.AliceBlue));


    }
}
