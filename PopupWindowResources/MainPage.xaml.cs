using CommunityToolkit.Maui.Views;
using Mopups.Services;

namespace PopupWindowResources;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPopupClicked(object sender, EventArgs e)
	{
		this.ShowPopup(new MyPopup());
	}

    private void OnMopupClicked(object sender, EventArgs e)
    {
		MopupService.Instance.PushAsync(new MyMopup());
    }
}

