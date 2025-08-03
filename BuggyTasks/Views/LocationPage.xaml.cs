using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;
using System;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = GetLocation(); 
    }

    private async Task GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location != null)
            {
                string message = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}";
                Console.WriteLine(message);
                LocationLabel.Text = message;
            }
            else
            {
                LocationLabel.Text = "Failed to get last known location";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"LOCATION ERROR: {ex.Message}");
            LocationLabel.Text = "Error getting last known location.";
        }
    }
}