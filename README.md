# SpaceWizards.HttpListener [![Nuget](https://img.shields.io/nuget/v/SpaceWizards.HttpListener)](https://www.nuget.org/packages/SpaceWizards.HttpListener)

A relatively lightweight and embeddable HTTP server for .NET. `SpaceWizards.HttpListener` is a maintained, updated, and unprofessionally butchered fork of the managed implementation of `System.Net.HttpListener` straight out of https://github.com/dotnet/runtime. This means:

* Will always use the fully managed implementation of `HttpListener`. On Windows, `System.Net.HttpListener` uses a different backend than Mac/Linux, namely the original `http.sys` backend. This functions very differently in behavior and bugs, which is unsuitable for cross-platform apps. Furthermore, binding something like `0.0.0.0:1212` with it requires admin even if a plain TCP socket would be fine otherwise.
* Bugfixes over the .NET Runtime implementation, which is basically unmaintained short of being kept around for compatibility. The original Mono implementation Mac/Linux `HttpListener` uses is quite buggy.
* You may expect some more modern innovations and maybe breaking changes. We're primarily maintaining this for [RobustToolbox](https://github.com/space-wizards/RobustToolbox) so there you go.

## Release Notes

See [RELEASE-NOTES.md](./RELEASE-NOTES.md).

## Examples

Literally any of the tutorials for `System.Net.HttpListener` will probably do. There are also our usages in Robust:
* [Simple HTTP server for game server control and querying APIs](https://github.com/space-wizards/RobustToolbox/tree/4d707c86cbfa5814cfa8b406dfd315fd1ad9948b/Robust.Server/ServerStatus)
* [Alternative HTTP server implementation for prometheus-net](https://github.com/space-wizards/RobustToolbox/blob/4d707c86cbfa5814cfa8b406dfd315fd1ad9948b/Robust.Server/DataMetrics/MetricsManager.MetricsServer.cs)