namespace App_Gallery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = (Picker)sender;
		String brandName = (String)component.SelectedItem;

		/*
		component.SelectedItem = component.ItemsSource[0];
		*/
		LblValue.Text = brandName;
    }
}