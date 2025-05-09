namespace App_Gallery.Views.Components.Forms;

public partial class SearchBarPage : ContentPage
{
	public SearchBarPage()
	{
		InitializeComponent();
	}

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		var value = ((SearchBar)sender).Text;
		LblValue.Text = "Palavra parapesquisar: " + value;
    }
}