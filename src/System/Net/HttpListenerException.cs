// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace ManagedHttpListener
{
    [Serializable]
    public class HttpListenerException : Win32Exception
    {
        public HttpListenerException() : base(Marshal.GetLastPInvokeError())
        {
            if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"{NativeErrorCode}:{Message}");
        }

        public HttpListenerException(int errorCode) : base(errorCode)
        {
            if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"{NativeErrorCode}:{Message}");
        }

        public HttpListenerException(int errorCode, string message) : base(errorCode, message)
        {
            if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"{NativeErrorCode}:{Message}");
        }

        protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"{NativeErrorCode}:{Message}");
        }

        // the base class returns the HResult with this property
        // we need the Win32 Error Code, hence the override.
        public override int ErrorCode => NativeErrorCode;
    }
}
