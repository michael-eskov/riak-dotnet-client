﻿// Copyright (c) 2011 - OJ Reeves & Jeremiah Peschka
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

using RiakClient.Extensions;
using RiakClient.Messages;

namespace RiakClient.Models.RiakDt
{
    public class RiakDtMapField
    {
        public enum RiakDtMapFieldType
        {
            Counter = MapField.MapFieldType.COUNTER,
            Set = MapField.MapFieldType.SET,
            Register = MapField.MapFieldType.REGISTER,
            Flag = MapField.MapFieldType.FLAG,
            Map = MapField.MapFieldType.MAP
        }

        public string Name { get; private set; }
        public RiakDtMapFieldType Type { get; private set; }

        internal RiakDtMapField(MapField mapField)
        {
            Name = mapField.name.FromRiakString();
            Type = (RiakDtMapFieldType)mapField.type;
        }

        public MapField ToMapField()
        {
            return new MapField {name = Name.ToRiakString(), type = (MapField.MapFieldType)Type};
        }
    }
}
