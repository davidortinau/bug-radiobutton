using CommunityToolkit.Maui.Views;
namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnButtonClicked(object sender, EventArgs e)
	{
		var popup = new FormPage();        
		// this.ShowPopup(popup);
        await App.Current.MainPage.ShowPopupAsync(popup);
	}

	

}