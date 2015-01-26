// Copyright (c) 2011 - OJ Reeves & Jeremiah Peschka
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

namespace RiakClient.Models.Search
{
    public class UnaryTerm : Term
    {
        private readonly Token _value;

        public UnaryTerm(RiakFluentSearch search, string field, string value)
            : this(search, field, Token.Is(value))
        {
        }

        public UnaryTerm(RiakFluentSearch search, string field, Token value)
            : base(search, field)
        {
            _value = value;
        }

        public override string ToString()
        {
            return Prefix() + Field() + _value + Suffix();
        }
    }
}