using Android.Graphics;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace SelectableLabelMAUI.Controls.Handlers;

public partial class SelectableLabelHandler : ViewHandler<SelectableLabel, MauiTextView>
{
    protected override MauiTextView CreatePlatformView()
    {
        return new MauiTextView(Context);
    }

    protected override void ConnectHandler(MauiTextView platformView)
    {
        base.ConnectHandler(platformView);
        // these are the properties that make it selectable on android
        platformView.Enabled = true;
        platformView.Focusable = true;
        platformView.LongClickable = true;
        platformView.SetTextIsSelectable(true);
    }

    protected override void DisconnectHandler(MauiTextView platformView)
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
        if (handler.PlatformView != null && label.TextColor != null)
        {
            handler.PlatformView.SetTextColor(label.TextColor.ToPlatform());
        }
    }

    public static void MapFont(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            handler.PlatformView.Typeface = Typeface.Create(label.FontFamily, TypefaceStyle.Normal);
            handler.PlatformView.TextSize = label.FontSize;
        }
    }

    public static void MapHorizontalTextAlignment(SelectableLabelHandler handler, SelectableLabel label)
    {
        if (handler.PlatformView != null)
        {
            switch (label.HorizontalTextAlignment)
            {
                case TextAlignment.Start:
                    handler.PlatformView.TextAlignment = Android.Views.TextAlignment.ViewStart;
                    break;
                case TextAlignment.Center:
                    handler.PlatformView.TextAlignment = Android.Views.TextAlignment.Center;
                    break;
                case TextAlignment.End:
                    handler.PlatformView.TextAlignment = Android.Views.TextAlignment.ViewEnd;
                    break;
            }
        }
    }
}
