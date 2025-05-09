namespace App_Gallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
    public SliderPage()
    {
        InitializeComponent();
    }

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        LblStatus.Text = "Iniciou o arrasto";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        LblStatus.Text = "Completou o arrasto";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        LblStatus.Text = "Novo valor: " + e.NewValue;
    }
}