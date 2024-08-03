namespace SelectableLabelMAUI;

public partial class MainPage : ContentPage
{
    public string Text { get; set; } = $@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean venenatis enim quis arcu rhoncus, vitae maximus sem ultricies. Maecenas faucibus gravida sem sed ultrices. In nec sem dignissim dui iaculis aliquet porta non enim. Mauris vulputate mauris eu sem blandit efficitur. Cras vehicula maximus ante vel iaculis. Proin diam dui, congue ut quam eu, tempus venenatis ex. Etiam placerat ipsum eget enim suscipit, nec tristique lacus porttitor. Integer egestas mollis maximus. Pellentesque justo magna, luctus nec ornare ut, egestas eu arcu. Nam sed mi quam. Cras tincidunt vulputate arcu, nec mollis enim consequat eu. Pellentesque consequat vel est in fermentum. Nam sit amet ex felis. Morbi et sem sit amet metus accumsan ornare id vel dolor. Etiam ornare, neque quis ultrices varius, odio lacus cursus mauris, non rhoncus est augue ac tortor. Aliquam sit amet elementum tellus.

Sed sodales lacus nec libero venenatis, non vehicula justo sollicitudin. Fusce imperdiet tempor cursus. Nullam eu tempus lectus. Mauris sit amet mi varius, viverra nisl a, tincidunt elit. Sed nisi erat, varius sit amet luctus et, consequat in urna. Duis interdum eget risus at imperdiet. Fusce cursus pharetra aliquet. Cras odio nisi, facilisis sollicitudin vulputate id, commodo ut urna. Duis urna est, congue non ultrices eget, consectetur sed neque. In egestas condimentum tortor, quis mattis ex molestie nec.

In hac habitasse platea dictumst. Vestibulum semper ante a consequat imperdiet. Nunc blandit finibus nunc eget faucibus. Aliquam ac augue ac eros rhoncus feugiat. Sed iaculis ex vitae dictum volutpat. Mauris dapibus eros non elit maximus, vitae mattis nisl consectetur. Cras elit lectus, gravida vitae mauris a, sodales euismod mi. Cras in ligula vel odio placerat vestibulum. Vestibulum ut magna nulla. Sed blandit elit a nibh hendrerit consequat.";

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}
