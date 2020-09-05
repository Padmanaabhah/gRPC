using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WpfClientCalulator
{
    /// <summary>
    /// Helper class for Http Client Handlers.
    /// </summary>
    public static class HttpClientHandlerHelper
    {
        /// <summary>
        /// Returns HttpClientHandler which allows Grpc connections with untrusted certificates.
        /// This should only be used during app development the function.
        /// </summary>
        /// <returns></returns>
        public static HttpClientHandler GetHandler()
        {
            var httpHandler = new HttpClientHandler();
            // Return `true` to allow certificates that are untrusted/invalid
            httpHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            return httpHandler;
        }
    }
}
