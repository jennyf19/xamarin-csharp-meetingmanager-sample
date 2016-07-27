using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Identity.Client;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XamarinFormsMeetingManager;
using XamarinFormsMeetingManager.Droid;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]

namespace XamarinFormsMeetingManager.Droid
{
    class MainPageRenderer : PageRenderer
    {
        MainPage page;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as MainPage;
            var activity = this.Context as Activity;
            page.platformParameters = new PlatformParameters(activity);
        }

    }
}