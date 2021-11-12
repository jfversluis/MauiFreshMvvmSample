using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiFreshMvvmSample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabbedPage = new FreshMvvm.Maui.FreshTabbedNavigationContainer();
			tabbedPage.AddTab<MainPageModel>("Main", null);
			tabbedPage.AddTab<MainPageModel>("Main 1", null);

			MainPage = tabbedPage;
		}
	}
}
