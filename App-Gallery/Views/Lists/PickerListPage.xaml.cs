using App_Gallery.Views.Lists.Models;

namespace App_Gallery.Views.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		PickerControl.ItemsSource = MovieList.GetList();
    }
}