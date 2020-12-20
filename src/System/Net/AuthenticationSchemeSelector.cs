// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Net;

namespace ManagedHttpListener
{
    public delegate AuthenticationSchemes AuthenticationSchemeSelector(HttpListenerRequest httpRequest);
}
