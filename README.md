# Managed `System.Net.HttpListener`

.NET's `HttpListener` uses Windows' built in HTTP routing thing called `http.sys` on Windows. This is problematic because it means that binding to ANY address except localhost requires either admin or the address to be allowed with `netsh http add urlacl`, which also requires admin.

BUT! .NET also has a fully MANAGED implementation that is used on non-Windows platforms. This implementation is totally OS agnostic and also works on Windows, except that they don't actually ship it there.

So this repo is the managed implementation straight out of https://github.com/dotnet/runtime, butchered a bit so that you can actually compile it. You get the API of `HttpListener` without the stupid permissions problem on Windows.

