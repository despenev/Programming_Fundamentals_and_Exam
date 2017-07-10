using Xamarin.Forms;

namespace Proba
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new ProbaPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
