using Foundation;
using UIKit;

namespace MTExample1_7 {
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate {
		UIWindow window;
		MTExample1_7ViewController viewController;

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			viewController = new MTExample1_7ViewController ();
			viewController.View.AddSubview (new DrawingView (window.Bounds));
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

