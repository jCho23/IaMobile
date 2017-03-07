using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace IaMobile
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void IdNoPassword()
		{
			app.Tap("login_username");
			app.Screenshot("Let's start by Tapping on the Username Text Field");

			app.EnterText("IaMobile");
			app.Screenshot("We entered our username, 'IaMobile''");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("login_remember_id_checkbox");
			app.Screenshot("We checked the 'Remember Id' box");

			app.Tap("login_button");
			app.Screenshot("Then we Tapped on the Login Button");
		}

		[Test]
		public void PasswordNoId()
		{
			app.Tap("login_password");
			app.Screenshot("Let's start by Tapping on the Username Text Field");

			app.EnterText("Microsoft");
			app.Screenshot("Then we entered our password, 'Microsoft''");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("login_language_switch");
			app.Screenshot("We Tapped the Toggle Switch to French");

			app.Tap("login_button");
			app.Screenshot("We Tapped on the Login Button");
		}

	}
}
