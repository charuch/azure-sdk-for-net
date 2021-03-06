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

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// A data slice is subset of table bounded by time.
    /// </summary>
    public partial class DataSlice
    {
        private DateTime _end;
        
        /// <summary>
        /// Optional. Data slice end time.
        /// </summary>
        public DateTime End
        {
            get { return this._end; }
            set { this._end = value; }
        }
        
        private string _latencyStatus;
        
        /// <summary>
        /// Optional. Data slice latency status.
        /// </summary>
        public string LatencyStatus
        {
            get { return this._latencyStatus; }
            set { this._latencyStatus = value; }
        }
        
        private int _longRetryCount;
        
        /// <summary>
        /// Optional. longRetryCount.
        /// </summary>
        public int LongRetryCount
        {
            get { return this._longRetryCount; }
            set { this._longRetryCount = value; }
        }
        
        private int _retryCount;
        
        /// <summary>
        /// Optional. retryCount.
        /// </summary>
        public int RetryCount
        {
            get { return this._retryCount; }
            set { this._retryCount = value; }
        }
        
        private DateTime _start;
        
        /// <summary>
        /// Optional. Data slice start time.
        /// </summary>
        public DateTime Start
        {
            get { return this._start; }
            set { this._start = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Data slice status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataSlice class.
        /// </summary>
        public DataSlice()
        {
        }
    }
}
