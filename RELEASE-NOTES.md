# Release Notes

## Master

## Current (0.2.0)

* `HttpListener.SetCertificate()` allows specifying a certificate for HTTPS prefixes.
* POST requests with an empty request body no longer always respond with a 411 error.

## 0.1.1

* Fix race condition exception if a connection comes in at an exact moment during listener set up.

## 0.1.0

This is the first release. Changes over base `System.Net.HttpListener` (bugfixes are for the managed impl, of course):
* Properly shut down sockets on connection close. This avoids connection resets in the middle of long downloads, if the server closes the connection before the data is fully received on the client. 
  * Fixes [dotnet/runtime#63236](https://github.com/dotnet/runtime/issues/63236)
* Avoid rogue ignored finalizer thread exception from Begin/End socket API usage if socket connection gets terminated for any reason.
  * This is actually a `Socket` API bug in .NET runtime not specific to `HttpListener` but I'm still gonna work around it.
  * Fixes [dotnet/runtime#63247](https://github.com/dotnet/runtime/issues/63247)
* Added IPv6 support.
* Fixed certain invalid & subsequently denied and closed requests still getting passed through to consuming code as if valid, resulting in many easily null reference exceptions.
* Fixed 0-byte asynchronous writes over a chunked response stream causing an unwarranted protocol violation and early response termination.
