
using Sport.Mobile.Droid;
using Sport.Mobile.Shared;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedFrame), typeof(BorderedFrameRender))]
namespace Sport.Mobile.Droid
{
    public class BorderedFrameRender : VisualElementRenderer<Frame>
    {             
        public BorderedFrameRender()
        {
            SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.abc_btn_colored_material));
        }
    }
}