using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Lsjwzh.Widget.Materialloadingprogressbar;
using Android.Views;

namespace SplashLoader
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Handler handler;
        CircleProgressBar progress1;
        CircleProgressBar progress2;
        CircleProgressBar progressWithArrow;
        CircleProgressBar progressWithoutBg;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            progress1 = FindViewById<CircleProgressBar>(Resource.Id.progress1);
            progress2 = FindViewById<CircleProgressBar>(Resource.Id.progress2);
            progressWithArrow = FindViewById<CircleProgressBar>(Resource.Id.progressWithArrow);
            progressWithoutBg = FindViewById<CircleProgressBar>(Resource.Id.progressWithoutBg);


            //        progress1.setColorSchemeResources(android.R.color.holo_blue_bright);
            progress2.SetColorSchemeResources(Android.Resource.Color.HoloGreenLight,
                                              Android.Resource.Color.HoloOrangeLight,
                                              Android.Resource.Color.HoloRedLight);

            progressWithArrow.SetColorSchemeResources(Android.Resource.Color.HoloOrangeLight);
            progressWithoutBg.SetColorSchemeResources(Android.Resource.Color.HoloRedLight);

            handler = new Handler();
            for (int i = 0; i < 10; i++)
            {
                int finalI = i;
                handler.PostDelayed(() =>
                {
                    if (finalI * 10 >= 90)
                    {
                        progress1.Visibility = ViewStates.Visible;
                        progress2.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        progress2.Progress = finalI * 10;
                    }
                }, 1000 * (i + 1));
            }
        }
    }
}