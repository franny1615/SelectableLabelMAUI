using Microsoft.Maui.Handlers;

namespace SelectableLabelMAUI.Controls.Handlers;

public partial class SelectableLabelHandler
{
    public static IPropertyMapper<SelectableLabel, SelectableLabelHandler> PropertyMapper = new PropertyMapper<SelectableLabel, SelectableLabelHandler>(ViewHandler.ViewMapper)
    {
        [nameof(SelectableLabel.Text)] = MapText,
        [nameof(SelectableLabel.TextColor)] = MapTextColor,
        [nameof(SelectableLabel.FontSize)] = MapFont,
        [nameof(SelectableLabel.FontFamily)] = MapFont,
        [nameof(SelectableLabel.HorizontalTextAlignment)] = MapHorizontalTextAlignment 
    };

    public static CommandMapper<SelectableLabel, SelectableLabelHandler> CommandMapper = new(ViewCommandMapper);

    public SelectableLabelHandler() : base(PropertyMapper, CommandMapper)
    {
    }
}
