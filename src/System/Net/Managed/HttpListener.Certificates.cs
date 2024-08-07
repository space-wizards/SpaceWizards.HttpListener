// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SpaceWizards.HttpListener
{
    public partial class HttpListener
    {
        internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback)
        {
            return new SslStream(innerStream, ownsStream, callback);
        }

        internal X509Certificate? LoadCertificateAndKey(IPAddress addr, int port)
        {
            return _certificate;
        }
    }
}
