[![MichelMichels.Mvvm](https://img.shields.io/nuget/v/MichelMichels.Mvvm)](https://www.nuget.org/packages/MichelMichels.Mvvm/)

# MichelMichels.Mvvm

C# .NET library with MVVM boilerplate classes for ViewModels and Views on multiple platforms.

## Getting Started

This library is fully dependent on `CommunityToolkit.Mvvm`. It aims to be an easy drop in to connect events from Views to your ViewModels without doing the wire-up yourself.

The library is split into 2 core assemblies: 
- `MichelMichels.Mvvm.Core`: Contains the interface `IViewModelBase`
- `MichelMichels.Mvvm`: Contains the implementation `ViewModelBase`

If you want to do the wire-up yourself, all you need to know is the `IViewModelBase` interface:

```csharp
IAsyncRelayCommand LoadedCommand { get; }
IAsyncRelayCommand AppearingCommand { get; }
IAsyncRelayCommand DisappearingCommand { get; }
```

I also provide following basic wire-ups:

|Platform|Nuget|
|---|---|
|`MichelMichels.Mvvm.Maui`| [![Nuget](https://img.shields.io/nuget/v/MichelMichels.Mvvm.Maui)](https://www.nuget.org/packages/MichelMichels.Mvvm.Maui/) |
|`MichelMichels.Mvvm.Wpf`| [![Nuget](https://img.shields.io/nuget/v/MichelMichels.Mvvm.Wpf)](https://www.nuget.org/packages/MichelMichels.Mvvm.Wpf/) |