# Managed & Maintained `System.Net.HttpListener`

`System.Net.HttpListener` allows you to (relatively) easily get a HTTP server in  your .NET app, without having to include heavyweight ASP.NET Core and such. This is nice on paper, except...

* `HttpListener` is no longer maintained and is basically on "we provide this for compatibility only" in upstream. The API is very crufty and kinda sucks to use in some areas.
* On Windows, `HttpListener` is implemented on top of `http.sys`. This means that (among many other things) it does not directly bind to a socket, and to bind to anything except `localhost`, you need admin privileges at least once. This kinda sucks for many programs.
* Outside Windows, a fully managed implementation originally from Mono is used. This implementation is old, leaves some things to be desires and has a bunch of bugs too.
* The fragmentation between these two backends means the API is a mess and many things don't work equally cross plat. All I'm saying is that if you want Windows built-in authentication and `http.sys` routing... well you probably don't want a cross plat library.

This repo is a maintained, updated, and unprofessionally butchered fork of the original managed version, straight out of https://github.com/dotnet/runtime. It should work completely consistently on Windows/Linux. You may expect some more modern innovations and maybe breaking changes. We're primarily developing this for [RobustToolbox](https://github.com/space-wizards/RobustToolbox) so there you go.
