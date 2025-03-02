using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MichelMichels.Mvvm.Core;
using System.Threading.Tasks;

namespace MichelMichels.Mvvm.ViewModels;

public partial class ViewModelBase : ObservableValidator, IViewModelBase
{
    [RelayCommand]
    protected virtual Task OnLoaded()
    {
        return Task.CompletedTask;
    }

    [RelayCommand]
    protected virtual Task OnAppearing()
    {
        return Task.CompletedTask;
    }

    [RelayCommand]
    protected virtual Task OnDisappearing()
    {
        return Task.CompletedTask;
    }
}
