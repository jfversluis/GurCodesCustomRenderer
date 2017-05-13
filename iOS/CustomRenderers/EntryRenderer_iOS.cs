using GurCodesCustomRenderer.Controls;
using GurCodesCustomRenderer.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(MyEntry), typeof(EntryRenderer_iOS))]
namespace GurCodesCustomRenderer.iOS.CustomRenderers
{
    public class EntryRenderer_iOS : Xamarin.Forms.Platform.iOS.EntryRenderer
    {
        protected override void OnElementChanged(Xamarin.Forms.Platform.iOS.ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Bezel;

            }
        }
    }
}