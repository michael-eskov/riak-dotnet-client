﻿// <copyright file="FetchCommandOptions.cs" company="Basho Technologies, Inc.">
// Copyright 2015 - Basho Technologies, Inc.
//
// This file is provided to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file
// except in compliance with the License.  You may obtain
// a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>

namespace RiakClient.Commands.CRDT
{
    /// <summary>
    /// Represents options for a CRDT command that fetches data.
    /// </summary>
    public abstract class FetchCommandOptions : CommandOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCommandOptions"/> class.
        /// </summary>
        /// <param name="bucketType">The bucket type in Riak. Required.</param>
        /// <param name="bucket">The bucket in Riak. Required.</param>
        /// <param name="key">The key in Riak. Required.</param>
        public FetchCommandOptions(string bucketType, string bucket, string key)
            : base(bucketType, bucket, key, true)
        {
            // ensure default values
            this.NotFoundOK = false;
            this.UseBasicQuorum = false;
            this.IncludeContext = true;
        }

        /// <summary>
        /// The R (read) value to use.
        /// </summary>
        public Quorum R { get; set; }

        /// <summary>
        /// The PR (primary vnode read) value to use.
        /// </summary>
        public Quorum PR { get; set; }

        /// <summary>
        /// If true, a <c>not_found</c> response from Riak is not an error.
        /// </summary>
        public bool NotFoundOK { get; set; }

        /// <summary>
        /// Controls whether a read request should return early in some failure cases.
        /// </summary>
        public bool UseBasicQuorum { get; set; }

        /// <summary>
        /// Set to <b>false</b> to not return context. Default (and recommended value) is <b>true</b>.
        /// </summary>
        public bool IncludeContext { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = base.GetHashCode();
                result = (result * 397) ^ NotFoundOK.GetHashCode();
                result = (result * 397) ^ UseBasicQuorum.GetHashCode();
                result = (result * 397) ^ IncludeContext.GetHashCode();
                result = (result * 397) ^ (R != null ? R.GetHashCode() : 0);
                result = (result * 397) ^ (PR != null ? PR.GetHashCode() : 0);
                return result;
            }
        }
    }
}