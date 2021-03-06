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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// The List Profiles operation response.
    /// </summary>
    public partial class ProfilesListResponse : OperationResponse, IEnumerable<Profile>
    {
        private IList<Profile> _profiles;
        
        /// <summary>
        /// Optional. The profiles associated with the specified subscription.
        /// </summary>
        public IList<Profile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfilesListResponse class.
        /// </summary>
        public ProfilesListResponse()
        {
            this.Profiles = new LazyList<Profile>();
        }
        
        /// <summary>
        /// Gets the sequence of Profiles.
        /// </summary>
        public IEnumerator<Profile> GetEnumerator()
        {
            return this.Profiles.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Profiles.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
