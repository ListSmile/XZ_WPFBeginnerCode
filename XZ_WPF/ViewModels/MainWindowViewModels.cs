using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XZ_WPF.ViewModels
{
    class MainWindowViewModels:BindableBase
    {
		public DelegateCommand ClickCommand { get; set; }
		public DelegateCommand CloseCommand { get; set; }
		public MainWindowViewModels()
		{
            ClickCommand = new DelegateCommand(() =>
			{
                MessageBox.Show(_name+"点击了按钮");
                Name = "测试";
            });
            CloseCommand = new DelegateCommand(() =>
			{
				Application.Current.Shutdown();
			});
        }
		private string _name = "李航";

		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value);}
		}

	}
}
