using GurCodesCustomRenderer.Controls;
using GurCodesCustomRenderer.Droid.CustomRenderer;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MyEntry), typeof(EntryRenderer_Android))]
namespace GurCodesCustomRenderer.Droid.CustomRenderer
{
    public class EntryRenderer_Android : Xamarin.Forms.Platform.Android.EntryRenderer
    {
        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Azure);
            }
        }
    }
}