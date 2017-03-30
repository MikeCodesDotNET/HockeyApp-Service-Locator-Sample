using HockeyApp.iOS;

namespace HockeyAppSample.iOS
{
	public class HockeyAppService : IHockeyAppService
	{
		public void ShowFeedbackList()
		{
			var feedbackManager = BITHockeyManager.SharedHockeyManager.FeedbackManager;
			feedbackManager.ShowFeedbackListView();
		}
	}
}
