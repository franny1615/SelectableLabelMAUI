using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace SelectableLabelMAUI.Controls.Handlers;

public partial class SelectableLabelHandler : ViewHandler<SelectableLabel, UITextView>
{
    protected override UITextView CreatePlatformView()
    {
        return new UITextView();
    }

    protected override void ConnectHandler(UITextView platformView)
    {
        base.ConnectHandler(platformView);
        // these are the properties that make it selectable on android
        platformView.Selectable = true;
        platformView.Editable = false;
        platformView.ScrollEnabled = false;
        platformView.TextContainerInset = UIEdgeInsets.Zero;
        platformView.TextContainer.LineFragmentPadding = 0;
        platformView.BackgroundColor = UIColor.Clear;
    }

    protected override void DisconnectHandler(UITextView platformView)
    {
        platformView.Dispose();
        base.DisconnectHandler(platformView);
    }

    public static void MapText(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            handler.PlatformView.Text = label.Text;
        }
    }

    public static void MapTextColor(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            handler.PlatformView.TextColor = label.TextColor.ToPlatform();
        }
    }

    public static void MapFont(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            handler.PlatformView.Font = UIFont.FromName(label.FontFamily, label.FontSize);
        }
    }

    public static void MapHorizontalTextAlignment(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            switch (label.HorizontalTextAlignment)
            {
                case TextAlignment.Start:
                    handler.PlatformView.TextAlignment = UITextAlignment.Left;
                    break;
                case TextAlignment.Center:
                    handler.PlatformView.TextAlignment = UITextAlignment.Center;
                    break;
                case TextAlignment.End:
                    handler.PlatformView.TextAlignment = UITextAlignment.Right;
                    break;
            }
        }
    }
}