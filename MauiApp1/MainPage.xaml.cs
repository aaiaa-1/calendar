using Calendar;
using Plugin.Maui.Calendar.Models;
using CommunityToolkit.Maui.Views;
namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public EventCollection Events { get; set; }  = new EventCollection();
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
    
    private async void OnAddEventClicked(object sender, EventArgs e)
    {
        var popup = new AddEventPopup(Events, App.Database);
        await this.ShowPopupAsync(popup);
    }

   
}