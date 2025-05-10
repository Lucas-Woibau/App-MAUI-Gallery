using App_Gallery.Views.Lists.Models;

namespace App_Gallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ListViewControl.ItemsSource = MovieList.GetGroupList();
    }

    private void ListViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
       var movie = (Movie)e.SelectedItem;

        App.Current.MainPage.DisplayAlert("Filme selecionado!", "Filme selecionado é " + movie.Name, "OK");
    }

    private async void ListViewControl_Refreshing(object sender, EventArgs e)
    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControl.ItemsSource = MovieList.GetGroupList();

        ListViewControl.IsRefreshing = false;
    }
}