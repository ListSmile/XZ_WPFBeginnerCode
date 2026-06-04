using System.Windows;

namespace XZ_WPF.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        public LoginWindowViewModel()
        {
            LoginCommand = new DelegateCommand<object>((Frm) =>
            {
                if (UserName == "Admin" && PassWord == "123456")
                {
                    System.Windows.MessageBox.Show("登录成功！");
                    Application.Current.Dispatcher.Invoke(() => (Frm as Window).Close());
                }
                else
                {
                    System.Windows.MessageBox.Show("用户名或密码错误！");
                    UserName = string.Empty;
                    PassWord = string.Empty;
                }
            });
        }

        private string _username = "Admin";

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        private string _password = "123456";

        public string PassWord
        {
            get { return _password; }
            set
            {
                _password = value;
                this.RaisePropertyChanged("PassWord");
            }
        }
        public DelegateCommand<object> LoginCommand { get; set; }
    }
}
