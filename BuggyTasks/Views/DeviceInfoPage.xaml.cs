using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();
        var model = DeviceInfo.Model;
        var platform = DeviceInfo.Platform.ToString();

        DeviceInfoLabel.Text = $"Model: {model}\nPlatform: {platform}";
    }
}