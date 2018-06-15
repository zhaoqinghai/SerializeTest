using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;
using ProtoBuf;
using System.IO;
using MessagePack;
using BenchmarkDotNet.Attributes.Columns;

namespace Serilize
{
    [AllStatisticsColumn]
    [MemoryDiagnoser]
    public class Test
    {
        IEnumerable<Person> persons => Persons();
        public IEnumerable<Person> Persons()
        {
            for(var i = 0; i < 200; i++)
            {
                yield return new Person() { Name = "123214", Address = new Address() { Line1 = "sadf", Line2 = "sadfsadf" }, Age = 12, Hobby = Hobby.Basketball | Hobby.Game };
            }
        }
        [Benchmark]
        public void NewtonJsonSerializeTest()
        {
            var str = JsonConvert.SerializeObject(persons);
        }
        [Benchmark]
        public void NewtonJsonTest()
        {
            var str = JsonConvert.SerializeObject(persons);
            JsonConvert.DeserializeObject(str);
        }
        [Benchmark]
        public void MsgPackSerializeTest()
        {
            var str = TypeSerializer.SerializeToString(persons, persons.GetType());
        }
        [Benchmark]
        public void MsgPackTest()
        {
            var str = TypeSerializer.SerializeToString(persons, persons.GetType());
            TypeSerializer.DeserializeFromString(str, persons.GetType());
        }
        [Benchmark]
        public void ProtobufSerializeTest()
        {
            using(MemoryStream ms = new MemoryStream())
            {
               Serializer.Serialize(ms, persons);
            }
        }
        [Benchmark]
        public void ProtobufTest()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Serializer.Serialize(ms, persons);
                Serializer.Deserialize<IEnumerable<Person>>(ms);
            }
        }
        [Benchmark]
        public void MessagePackSerializeTest()
        {
            MessagePackSerializer.Serialize(persons);
        }
        [Benchmark]
        public void MessagePackTest()
        {
            var bytes = MessagePackSerializer.Serialize(persons);
            MessagePackSerializer.Deserialize<IEnumerable<Person>>(bytes);
        }
    }
}
