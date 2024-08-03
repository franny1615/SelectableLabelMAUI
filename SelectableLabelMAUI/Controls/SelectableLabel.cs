using SelectableLabelMAUI.Controls.Handlers;

namespace SelectableLabelMAUI.Controls;

public class SelectableLabel : View 
{
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(SelectableLabel));

    public static readonly BindableProperty TextColorProperty =
        BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(SelectableLabel));

    public static readonly BindableProperty FontFamilyProperty =
        BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(SelectableLabel));

    public static readonly BindableProperty FontSizeProperty =
        BindableProperty.Create(nameof(FontSize), typeof(float), typeof(SelectableLabel), 0f);

    public static readonly BindableProperty HorizontalTextAlignmentProperty =
        BindableProperty.Create(nameof(HorizontalTextAlignment), typeof(TextAlignment), typeof(SelectableLabel), TextAlignment.Start);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public float FontSize
    {
        get => (float)GetValue(FontSizeProperty);
        set => SetValue(FontSizeProperty, value);
    }

    public string FontFamily
    {
        get => (string)(GetValue(FontFamilyProperty));
        set => SetValue(FontFamilyProperty, value);
    }

    public TextAlignment HorizontalTextAlignment
    {
        get => (TextAlignment)GetValue(HorizontalTextAlignmentProperty);
        set => SetValue(HorizontalTextAlignmentProperty, value);
    }
}

public static class SelectableLabelExtensions
{
    public static MauiAppBuilder UseSelectableLabel(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers((handlers) =>
        {
            handlers.AddHandler(typeof(SelectableLabel), typeof(SelectableLabelHandler));
        });
        return builder;
    }
}