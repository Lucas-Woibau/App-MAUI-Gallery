namespace App_Gallery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	bool buttonState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var poweOff = "poweroff.png";
		var powerOn = "powerOn.png";

		var button = (ImageButton)sender;

		button.Source = (buttonState == false) ? ImageSource.FromFile(poweOff) : ImageSource.FromFile(powerOn);

		
    }
}