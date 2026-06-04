using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace XZ_WPF.Common
{
    public class PassWordHelper
    {


        public static string GetXZPassWord(DependencyObject obj)
        {
            return (string)obj.GetValue(XZPassWordProperty);
        }

        public static void SetXZPassWord(DependencyObject obj, string value)
        {
            obj.SetValue(XZPassWordProperty, value);
        }

        // Using a DependencyProperty as the backing store for XZPassWord.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XZPassWordProperty =
            DependencyProperty.RegisterAttached("XZPassWord", typeof(string), typeof(PassWordHelper), new PropertyMetadata("", OnXZPassWordChanged));

        private static void OnXZPassWordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            if (password == null)
            {
                return;
            }
            password.PasswordChanged -= PwdBox_PasswordChanged;
            if (!_IsUpdating)
            {
                password.Password = e.NewValue?.ToString();
            }
            password.PasswordChanged += PwdBox_PasswordChanged;
        }

        public static bool GetAttach(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachProperty);
        }

        public static void SetAttach(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachProperty, value);
        }

        // Using a DependencyProperty as the backing store for Attach.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AttachProperty =
            DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PassWordHelper), new PropertyMetadata(false, OnAttachChanged));

        private static void OnAttachChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwdBox = d as PasswordBox;
            if (pwdBox == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                pwdBox.PasswordChanged += PwdBox_PasswordChanged;
            }
            else
            {
                pwdBox.PasswordChanged-= PwdBox_PasswordChanged;
            }
        }

        private static void PwdBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            _IsUpdating = true;
            SetXZPassWord(passwordBox, passwordBox.Password);
            _IsUpdating = false;
        }
        static bool _IsUpdating = false;
    }
}
