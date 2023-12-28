using Lesson6.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson6
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			Lesson6.View.MainPage window = new Lesson6.View.MainPage();
			UserViewModel VM = new UserViewModel();
			window.DataContext = VM;
			window.Show();
		}
	}
}
