﻿// Copyright (c) 2010 - OJ Reeves & Jeremiah Peschka
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

using System;
using CorrugatedIron.Extensions;
using Newtonsoft.Json;

namespace CorrugatedIron.Models.MapReduce
{
    public class RiakLinkPhase : RiakPhase
    {
        private const string EmptyRestPhase = "_,_,_";

        private string _bucket;
        private string _tag;
        private string _key;

        public RiakLinkPhase()
        {
            
        }

        public RiakLinkPhase(string restPhase)
        {
            if (string.IsNullOrEmpty(restPhase))
            {
                Empty();
            }

            if (restPhase == EmptyRestPhase)
            {
                Empty();
            }
            else
            {
                var phases = restPhase.Split(',');

                if (phases.Length != 3)
                {
                    throw new ArgumentException("When building a phase from a string, the phase must be in three parts <<bucket>>,<<key>>,<<tag>>.");
                }

                _bucket = !string.IsNullOrEmpty(phases[0]) ? phases[0] : default(string);
                _key = !string.IsNullOrEmpty(phases[1]) ? phases[1] : default(string);
                _tag = !string.IsNullOrEmpty(phases[2]) ? phases[2] : default(string);
            }
        }

        public RiakLinkPhase(RiakLink riakLink)
        {
            if (string.IsNullOrEmpty(riakLink.Bucket)
                && string.IsNullOrEmpty(riakLink.Key)
                && string.IsNullOrEmpty(riakLink.Tag))
            {
                Empty();
            }
            else
            {
                _bucket = riakLink.Bucket;
                _key = riakLink.Key;
                _tag = riakLink.Tag;
            }
        }

        public RiakLinkPhase FromRiakLink(RiakLink riakLink)
        {
            if (string.IsNullOrEmpty(riakLink.Bucket)
                && string.IsNullOrEmpty(riakLink.Key)
                && string.IsNullOrEmpty(riakLink.Tag))
            {
                Empty();
            }
            else
            {
                _bucket = riakLink.Bucket;
                _key = riakLink.Key;
                _tag = riakLink.Tag;
            }
            
            return this;
        }

        public override string PhaseType
        {
            get { return "link"; }
        }

        public RiakLinkPhase Bucket(string bucket)
        {
            _bucket = bucket;
            _empty = false;
            return this;
        }

        public RiakLinkPhase Tag(string tag)
        {
            _tag = tag;
            _empty = false;
            return this;
        }

        public RiakLinkPhase Key(string key)
        {
            _key = key;
            _empty = false;
            return this;
        }

        public RiakLinkPhase Empty()
        {
            _empty = true;
            _bucket = default(string);
            _key = default(string);
            _tag = default(string);
            return this;
        }

        protected override void WriteJson(JsonWriter writer)
        {
            writer.WriteSpecifiedProperty("bucket", _bucket)
                .WriteSpecifiedProperty("tag", _tag)
                .WriteSpecifiedProperty("key", _key);
        }
    }
}
