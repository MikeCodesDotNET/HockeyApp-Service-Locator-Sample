using Xamarin.Forms;

namespace HockeyAppSample
{
	public partial class HockeyAppSamplePage : ContentPage
	{
		public HockeyAppSamplePage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var has = ServiceLocator.Instance.Resolve<IHockeyAppService>();
			has.ShowFeedbackList();
		}
	}
}
