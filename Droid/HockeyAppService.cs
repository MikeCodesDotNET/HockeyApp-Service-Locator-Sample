using Android.App;
using HockeyApp.Android;

namespace HockeyAppSample.Droid
{
	public class HockeyAppService : IHockeyAppService
	{
		public void ShowFeedbackList()
		{
			FeedbackManager.ShowFeedbackActivity(Application.Context);
		}
	}
}
