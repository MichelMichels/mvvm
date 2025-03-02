using MichelMichels.Mvvm.Core;

namespace MichelMichels.Mvvm.Maui;

public partial class ViewBase : ContentPage
{
    public ViewBase()
    {
        Loaded += ViewBase_Loaded;
    }

    private async void ViewBase_Loaded(object? sender, EventArgs e)
    {
        if (BindingContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.LoadedCommand.ExecuteAsync(null);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.AppearingCommand.ExecuteAsync(null);
    }
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();

        if (BindingContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.DisappearingCommand.ExecuteAsync(null);
    }
}
