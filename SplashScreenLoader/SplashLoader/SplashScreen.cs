using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Lsjwzh.Widget.Materialloadingprogressbar;

namespace SplashLoader
{
    [Activity(Theme = "@style/Theme.MyAppTheme", //Indicates the theme to use for this activity
         MainLauncher = true,Label = "Loader Splash")]
    public class SplashScreen : Activity
    {
        CircleProgressBar progressWithoutBg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.splash);

            progressWithoutBg = FindViewById<CircleProgressBar>(Resource.Id.progressWithoutBg);
            progressWithoutBg.SetColorSchemeResources(Android.Resource.Color.HoloRedLight);
            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();
            SimulateStartup();
            //Task startupWork = new Task(() => { SimulateStartup(); });
            //startupWork.Start();
            //StartActivity(new Intent(Application.Context, typeof(MainActivity)));

        }
        async void SimulateStartup()
        {

            await Task.Delay(10000); // Simulate a bit of startup work.

            StartActivity(new Intent(this, typeof(MainActivity)));

        }
    }
}