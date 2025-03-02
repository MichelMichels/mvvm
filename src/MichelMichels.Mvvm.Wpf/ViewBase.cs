
using MichelMichels.Mvvm.Core;
using System.ComponentModel;
using System.Windows;

namespace MichelMichels.Mvvm.Wpf;

public abstract class ViewBase : Window
{
    public ViewBase()
    {
        Loaded += ViewBase_Loaded;
    }

    private async void ViewBase_Loaded(object sender, RoutedEventArgs e)
    {
        if (DataContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.LoadedCommand.ExecuteAsync(null);
    }
    protected override async void OnContentRendered(EventArgs e)
    {
        base.OnContentRendered(e);

        if (DataContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.AppearingCommand.ExecuteAsync(null);
    }
    protected override async void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        if (DataContext is not IViewModelBase ivmb)
        {
            return;
        }

        await ivmb.DisappearingCommand.ExecuteAsync(null);
    }
}
