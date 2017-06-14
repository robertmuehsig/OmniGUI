using CoreGraphics;
using OmniGui.Geometry;
using UIKit;

namespace OmniGui.iOS
{
    public class OmniGuiView : UIView
    {
        public Layout Layout { get; }

        public OmniGuiView(Layout layout)
        {
            Layout = layout;
        }

        public override void Draw(CGRect rect)
        {
            Layout.Measure(new Size(30, 30));
            Layout.Arrange(rect.ToOmniGui());
            using (var ctx = UIGraphics.GetCurrentContext())
            {
                Layout.Render(new iOSDrawingContext(ctx));
            }        
        }
    }
}