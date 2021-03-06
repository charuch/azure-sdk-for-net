// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Server object.
    /// </summary>
    public partial class Server : ServiceResourceBase
    {
        private bool _connected;
        
        /// <summary>
        /// Required. Value indicating whether server is connected or not.
        /// </summary>
        public bool Connected
        {
            get { return this._connected; }
            set { this._connected = value; }
        }
        
        private DateTime _lastHeartbeat;
        
        /// <summary>
        /// Required. Last time server synced with the service.
        /// </summary>
        public DateTime LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _providerVersion;
        
        /// <summary>
        /// Required. Vesrion of the provider installed on the server.
        /// </summary>
        public string ProviderVersion
        {
            get { return this._providerVersion; }
            set { this._providerVersion = value; }
        }
        
        private string _serverVersion;
        
        /// <summary>
        /// Required. Version number of the server.
        /// </summary>
        public string ServerVersion
        {
            get { return this._serverVersion; }
            set { this._serverVersion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
        }
    }
}
