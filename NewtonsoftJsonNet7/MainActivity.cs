using Android.Util;
using Newtonsoft.Json;

namespace NewtonsoftJsonNet7
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var tuple = new Tuple<decimal, string>(1, "one");
            var serialized = JsonConvert.SerializeObject(tuple);

            if (serialized != null)
            {
                Log.Info(nameof(MainActivity), "Serialized the object");
            }
        }
    }
}