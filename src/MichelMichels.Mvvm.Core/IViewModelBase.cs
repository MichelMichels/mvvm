using CommunityToolkit.Mvvm.Input;

namespace MichelMichels.Mvvm.Core;

public interface IViewModelBase
{
    IAsyncRelayCommand LoadedCommand { get; }
    IAsyncRelayCommand AppearingCommand { get; }
    IAsyncRelayCommand DisappearingCommand { get; }
}
