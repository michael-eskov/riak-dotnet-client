// <copyright file="RiakPhaseLanguageErlang.cs" company="Basho Technologies, Inc.">
// Copyright 2011 - OJ Reeves & Jeremiah Peschka
// Copyright 2014 - Basho Technologies, Inc.
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

namespace RiakClient.Models.MapReduce.Languages
{
    using Extensions;
    using Newtonsoft.Json;

    internal class RiakPhaseLanguageErlang : IRiakPhaseLanguage
    {
        private string module;
        private string function;

        /// <summary>
        /// The Erlang Module:Function to execute for this phase.
        /// </summary>
        /// <param name="module">The module containing the <paramref name="function"/> to execute.</param>
        /// <param name="function">The function to execute for this phase.</param>
        public void ModFun(string module, string function)
        {
            this.module = module;
            this.function = function;
        }

        /// <inheritdoc/>
        public void WriteJson(JsonWriter writer)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(module), "Module must be set");
            System.Diagnostics.Debug.Assert(!string.IsNullOrWhiteSpace(function), "Function must be set");

            writer.WriteSpecifiedProperty("language", RiakConstants.MapReduceLanguage.Erlang)
                .WriteSpecifiedProperty("module", module)
                .WriteSpecifiedProperty("function", function);
        }
    }
}
