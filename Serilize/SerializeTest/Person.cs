using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProtoBuf;
using MessagePack;

namespace SerializeTest
{
    [ProtoContract, MessagePackObject]
    public class Person
    {
        [Key(0)]
        [ProtoMember(1)]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        [JsonProperty("age")]
        public int Age { get; set; }
        [Key(2)]
        [ProtoMember(3)]
        [JsonProperty("hobby")]
        public Hobby Hobby { get; set; } = Hobby.Football | Hobby.Game;
        [JsonIgnore]
        [IgnoreMember]
        public string Mail => $"{Name}++++++";
        [Key(3)]
        [ProtoMember(4)]
        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    [Flags]
    public enum Hobby
    {
        Football = 0x0001,
        Basketball = 0x0002,
        PingPong = 0x0004,
        Game = 0x0008,
        Sleep = 0x0010
    }
    [ProtoContract, MessagePackObject]
    public class Address
    {
        [Key(0)]
        [ProtoMember(1)]
        [JsonProperty("line1")]
        public string Line1 { get; set; }
        [Key(1)]
        [ProtoMember(2)]
        [JsonProperty("line2")]
        public string Line2 { get; set; }
    }
}
