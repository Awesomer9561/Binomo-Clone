using Android.Content;
using Binomo_Clone.Custom_Renderers;
using Binomo_Clone.Droid.Custom_Renderer_Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyCustomEntryRenderer))]

namespace Binomo_Clone.Droid.Custom_Renderer_Android
{
    class MyCustomEntryRenderer:EntryRenderer
    {
        public MyCustomEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Rgb(48, 48, 51));
                Control.SetTextColor(Android.Graphics.Color.White);
                Control.SetCursorVisible(false);
            }
        }
    }
}