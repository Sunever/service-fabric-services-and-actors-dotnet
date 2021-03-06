// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Services.Remoting.V2
{
    using Microsoft.ServiceFabric.Services.Remoting.V2.Runtime;

    /// <summary>
    /// Specifies the headers that are sent along with a ServiceRemoting message. This class is used with Service Independent Dispatcher <see cref="ServiceRemotingMessageDispatcher"/> 
    /// .e.g Short-Circuiting (Where client and service are in same process)
    /// </summary>
    public class ServiceRemotingDispatchHeaders
    {
        /// <summary>
        /// This is the Full Name for the user remoting service interface.
        /// </summary>
        public string ServiceInterfaceName { get; set; }

        /// <summary>
        /// This is the Method Name to which the request will be sent to .
        /// </summary>
        public string MethodName { get; set; }
    }
}
