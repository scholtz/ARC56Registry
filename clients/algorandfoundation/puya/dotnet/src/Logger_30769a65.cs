using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.algorandfoundation.puya.Logger_30769a65
{


    public class LoggerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoggerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LogMessage : AVMObjectType
            {
                public ulong Level { get; set; }

                public string Message { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLevel.From(Level);
                    ret.AddRange(vLevel.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.From(Message);
                    stringRef[ret.Count] = vMessage.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LogMessage Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LogMessage();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLevel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLevel = vLevel.ToValue();
                    if (valueLevel is ulong vLevelValue) { ret.Level = vLevelValue; }
                    var indexMessage = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.Decode(bytes.Skip(indexMessage + prefixOffset).ToArray());
                    var valueMessage = vMessage.ToValue();
                    if (valueMessage is string vMessageValue) { ret.Message = vMessageValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LogMessage);
                }
                public bool Equals(LogMessage? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LogMessage left, LogMessage right)
                {
                    return EqualityComparer<LogMessage>.Default.Equals(left, right);
                }
                public static bool operator !=(LogMessage left, LogMessage right)
                {
                    return !(left == right);
                }

            }

            public class LogStruct : AVMObjectType
            {
                public ulong Level { get; set; }

                public string Message { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLevel.From(Level);
                    ret.AddRange(vLevel.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.From(Message);
                    stringRef[ret.Count] = vMessage.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LogStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LogStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLevel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLevel = vLevel.ToValue();
                    if (valueLevel is ulong vLevelValue) { ret.Level = vLevelValue; }
                    var indexMessage = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.Decode(bytes.Skip(indexMessage + prefixOffset).ToArray());
                    var valueMessage = vMessage.ToValue();
                    if (valueMessage is string vMessageValue) { ret.Message = vMessageValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LogStruct);
                }
                public bool Equals(LogStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LogStruct left, LogStruct right)
                {
                    return EqualityComparer<LogStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(LogStruct left, LogStruct right)
                {
                    return !(left == right);
                }

            }

            public class EchoResourceByIndexReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoResourceByIndexReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EchoResourceByIndexReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoResourceByIndexReturn);
                }
                public bool Equals(EchoResourceByIndexReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return EqualityComparer<EchoResourceByIndexReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return !(left == right);
                }

            }

            public class EchoNativeTupleReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public ulong Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNativeTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNativeTupleReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNativeTupleReturn);
                }
                public bool Equals(EchoNativeTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNativeTupleReturn left, EchoNativeTupleReturn right)
                {
                    return EqualityComparer<EchoNativeTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNativeTupleReturn left, EchoNativeTupleReturn right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuples : AVMObjectType
            {
                public Structs.EchoNestedTupleArgTupleOfTuplesField0 Field0 { get; set; } = new Structs.EchoNestedTupleArgTupleOfTuplesField0();

                public Structs.EchoNestedTupleArgTupleOfTuplesField1 Field1 { get; set; } = new Structs.EchoNestedTupleArgTupleOfTuplesField1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Field0.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field1.ToByteArray();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuples Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNestedTupleArgTupleOfTuples();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.EchoNestedTupleArgTupleOfTuplesField0.Parse(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.EchoNestedTupleArgTupleOfTuplesField1.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuples);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuples? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuples left, EchoNestedTupleArgTupleOfTuples right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuples>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuples left, EchoNestedTupleArgTupleOfTuples right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuplesField0 : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuplesField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNestedTupleArgTupleOfTuplesField0();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuplesField0);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuplesField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuplesField0 left, EchoNestedTupleArgTupleOfTuplesField0 right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuplesField0>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuplesField0 left, EchoNestedTupleArgTupleOfTuplesField0 right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuplesField1 : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuplesField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EchoNestedTupleArgTupleOfTuplesField1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuplesField1);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuplesField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuplesField1 left, EchoNestedTupleArgTupleOfTuplesField1 right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuplesField1>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuplesField1 left, EchoNestedTupleArgTupleOfTuplesField1 right)
                {
                    return !(left == right);
                }

            }

            public class ReturnArgsAfter14ThArgA19 : AVMObjectType
            {
                public byte Field0 { get; set; }

                public byte Field1 { get; set; }

                public byte Field2 { get; set; }

                public byte Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReturnArgsAfter14ThArgA19 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReturnArgsAfter14ThArgA19();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReturnArgsAfter14ThArgA19);
                }
                public bool Equals(ReturnArgsAfter14ThArgA19? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReturnArgsAfter14ThArgA19 left, ReturnArgsAfter14ThArgA19 right)
                {
                    return EqualityComparer<ReturnArgsAfter14ThArgA19>.Default.Equals(left, right);
                }
                public static bool operator !=(ReturnArgsAfter14ThArgA19 left, ReturnArgsAfter14ThArgA19 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task IsAB(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 114, 18, 188 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IsAB_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 114, 18, 188 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> Echo(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 248, 25, 19 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Echo_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 248, 25, 19 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NoArgs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 98, 238, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NoArgs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 98, 238, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 16, 88, 217 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 16, 88, 217 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 244, 89, 48 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 244, 89, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 180, 51, 78 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 180, 51, 78 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 237, 126, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 237, 126, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 0, 225, 17 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 0, 225, 17 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="account"> </param>
        /// <param name="app"> </param>
        public async Task Log(ulong asset, Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 181, 15, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, accountAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(ulong asset, Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 181, 15, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, accountAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task Log(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 55, 177, 126 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 55, 177, 126 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> EchoNativeString(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 68, 76, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EchoNativeString_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 68, 76, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<byte[]> EchoNativeBytes(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 89, 232, 24 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> EchoNativeBytes_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 89, 232, 24 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> EchoNativeUint64(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 251, 108, 241 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EchoNativeUint64_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 251, 108, 241 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> EchoNativeBiguint(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 204, 54, 59 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> EchoNativeBiguint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 204, 54, 59 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByIndex(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 214, 194, 172, 127 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByIndex_Transactions(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 214, 194, 172, 127 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByValue(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 20, 45, 94 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByValue_Transactions(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 20, 45, 94 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="s"> </param>
        /// <param name="b"> </param>
        /// <param name="u"> </param>
        /// <param name="bu"> </param>
        public async Task<Structs.EchoNativeTupleReturn> EchoNativeTuple(string s, byte[] b, ulong u, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 bu, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 224, 57, 25 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            var result = await base.CallApp(new List<object> { abiHandle, sAbi, bAbi, uAbi, bu }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoNativeTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoNativeTuple_Transactions(string s, byte[] b, ulong u, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 bu, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 224, 57, 25 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            return await base.MakeTransactionList(new List<object> { abiHandle, sAbi, bAbi, uAbi, bu }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tuple_of_tuples"> EchoNestedTupleArgTupleOfTuples</param>
        public async Task<Structs.EchoNestedTupleArgTupleOfTuples> EchoNestedTuple(Structs.EchoNestedTupleArgTupleOfTuples tuple_of_tuples, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 39, 28, 228 };

            var result = await base.CallApp(new List<object> { abiHandle, tuple_of_tuples }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoNestedTupleArgTupleOfTuples.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoNestedTuple_Transactions(Structs.EchoNestedTupleArgTupleOfTuples tuple_of_tuples, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 39, 28, 228 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tuple_of_tuples }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_a1"> </param>
        /// <param name="_a2"> </param>
        /// <param name="_a3"> </param>
        /// <param name="_a4"> </param>
        /// <param name="_a5"> </param>
        /// <param name="_a6"> </param>
        /// <param name="_a7"> </param>
        /// <param name="_a8"> </param>
        /// <param name="_a9"> </param>
        /// <param name="_a10"> </param>
        /// <param name="_a11"> </param>
        /// <param name="_a12"> </param>
        /// <param name="_a13"> </param>
        /// <param name="_a14"> </param>
        /// <param name="a15"> </param>
        /// <param name="a16"> </param>
        /// <param name="a17"> </param>
        /// <param name="a18"> </param>
        /// <param name="a19"> ReturnArgsAfter14ThArgA19</param>
        /// <param name="a20"> </param>
        public async Task<byte[]> ReturnArgsAfter14Th(ulong _a1, ulong _a2, ulong _a3, ulong _a4, ulong _a5, ulong _a6, ulong _a7, ulong _a8, ulong _a9, ulong _a10, ulong _a11, ulong _a12, ulong _a13, ulong _a14, byte a15, byte a16, byte a17, byte a18, Structs.ReturnArgsAfter14ThArgA19 a19, byte a20, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 11, 67, 129 };
            var _a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a1Abi.From(_a1);
            var _a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a2Abi.From(_a2);
            var _a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a3Abi.From(_a3);
            var _a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a4Abi.From(_a4);
            var _a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a5Abi.From(_a5);
            var _a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a6Abi.From(_a6);
            var _a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a7Abi.From(_a7);
            var _a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a8Abi.From(_a8);
            var _a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a9Abi.From(_a9);
            var _a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a10Abi.From(_a10);
            var _a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a11Abi.From(_a11);
            var _a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a12Abi.From(_a12);
            var _a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a13Abi.From(_a13);
            var _a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a14Abi.From(_a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a18Abi.From(a18);
            var a20Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a20Abi.From(a20);

            var result = await base.CallApp(new List<object> { abiHandle, _a1Abi, _a2Abi, _a3Abi, _a4Abi, _a5Abi, _a6Abi, _a7Abi, _a8Abi, _a9Abi, _a10Abi, _a11Abi, _a12Abi, _a13Abi, _a14Abi, a15Abi, a16Abi, a17Abi, a18Abi, a19, a20Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ReturnArgsAfter14Th_Transactions(ulong _a1, ulong _a2, ulong _a3, ulong _a4, ulong _a5, ulong _a6, ulong _a7, ulong _a8, ulong _a9, ulong _a10, ulong _a11, ulong _a12, ulong _a13, ulong _a14, byte a15, byte a16, byte a17, byte a18, Structs.ReturnArgsAfter14ThArgA19 a19, byte a20, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 11, 67, 129 };
            var _a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a1Abi.From(_a1);
            var _a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a2Abi.From(_a2);
            var _a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a3Abi.From(_a3);
            var _a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a4Abi.From(_a4);
            var _a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a5Abi.From(_a5);
            var _a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a6Abi.From(_a6);
            var _a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a7Abi.From(_a7);
            var _a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a8Abi.From(_a8);
            var _a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a9Abi.From(_a9);
            var _a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a10Abi.From(_a10);
            var _a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a11Abi.From(_a11);
            var _a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a12Abi.From(_a12);
            var _a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a13Abi.From(_a13);
            var _a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a14Abi.From(_a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a18Abi.From(a18);
            var a20Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a20Abi.From(a20);

            return await base.MakeTransactionList(new List<object> { abiHandle, _a1Abi, _a2Abi, _a3Abi, _a4Abi, _a5Abi, _a6Abi, _a7Abi, _a8Abi, _a9Abi, _a10Abi, _a11Abi, _a12Abi, _a13Abi, _a14Abi, a15Abi, a16Abi, a17Abi, a18Abi, a19, a20Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="log_1"> LogMessage</param>
        /// <param name="log_2"> LogMessage</param>
        public async Task<bool> LogsAreEqual(Structs.LogMessage log_1, Structs.LogMessage log_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 208, 113, 133 };

            var result = await base.CallApp(new List<object> { abiHandle, log_1, log_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LogsAreEqual_Transactions(Structs.LogMessage log_1, Structs.LogMessage log_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 208, 113, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle, log_1, log_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="log"> LogStruct</param>
        public async Task<Structs.LogStruct> EchoLogStruct(Structs.LogStruct log, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 79, 25, 146 };

            var result = await base.CallApp(new List<object> { abiHandle, log }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LogStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoLogStruct_Transactions(Structs.LogStruct log, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 79, 25, 146 };

            return await base.MakeTransactionList(new List<object> { abiHandle, log }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkxvZ01lc3NhZ2UiOlt7Im5hbWUiOiJsZXZlbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtZXNzYWdlIiwidHlwZSI6InN0cmluZyJ9XSwiTG9nU3RydWN0IjpbeyJuYW1lIjoibGV2ZWwiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWVzc2FnZSIsInR5cGUiOiJzdHJpbmcifV0sIkVjaG9SZXNvdXJjZUJ5SW5kZXhSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJhZGRyZXNzIn1dLCJFY2hvTmF0aXZlVHVwbGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDUxMiJ9XSwiRWNob05lc3RlZFR1cGxlQXJnVHVwbGVPZlR1cGxlcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJFY2hvTmVzdGVkVHVwbGVBcmdUdXBsZU9mVHVwbGVzRmllbGQwIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6IkVjaG9OZXN0ZWRUdXBsZUFyZ1R1cGxlT2ZUdXBsZXNGaWVsZDEifV0sIkVjaG9OZXN0ZWRUdXBsZUFyZ1R1cGxlT2ZUdXBsZXNGaWVsZDAiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiRWNob05lc3RlZFR1cGxlQXJnVHVwbGVPZlR1cGxlc0ZpZWxkMSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJ5dGVbXSJ9XSwiUmV0dXJuQXJnc0FmdGVyMTRUaEFyZ0ExOSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50OCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpc19hX2IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibm9fYXJncyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fbmF0aXZlX3N0cmluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fbmF0aXZlX2J5dGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uYXRpdmVfdWludDY0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uYXRpdmVfYmlndWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19yZXNvdXJjZV9ieV9pbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsaWNhdGlvbiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkVjaG9SZXNvdXJjZUJ5SW5kZXhSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvX3Jlc291cmNlX2J5X3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJFY2hvUmVzb3VyY2VCeUluZGV4UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uYXRpdmVfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsYnl0ZVtdLHVpbnQ2NCx1aW50NTEyKSIsInN0cnVjdCI6IkVjaG9OYXRpdmVUdXBsZVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fbmVzdGVkX3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iigoc3RyaW5nLHN0cmluZyksKHVpbnQ2NCx1aW50NjQsYnl0ZVtdKSkiLCJzdHJ1Y3QiOiJFY2hvTmVzdGVkVHVwbGVBcmdUdXBsZU9mVHVwbGVzIiwibmFtZSI6InR1cGxlX29mX3R1cGxlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKHN0cmluZyxzdHJpbmcpLCh1aW50NjQsdWludDY0LGJ5dGVbXSkpIiwic3RydWN0IjoiRWNob05lc3RlZFR1cGxlQXJnVHVwbGVPZlR1cGxlcyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldHVybl9hcmdzX2FmdGVyXzE0dGgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hMyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2E0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hNiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2E3IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hOSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExMCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExMyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2ExNCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTE2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExNyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OCx1aW50OCx1aW50OCx1aW50OCkiLCJzdHJ1Y3QiOiJSZXR1cm5BcmdzQWZ0ZXIxNFRoQXJnQTE5IiwibmFtZSI6ImExOSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMjAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2dzX2FyZV9lcXVhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJMb2dNZXNzYWdlIiwibmFtZSI6ImxvZ18xIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJMb2dNZXNzYWdlIiwibmFtZSI6ImxvZ18yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fbG9nX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJMb2dTdHJ1Y3QiLCJuYW1lIjoibG9nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkxvZ1N0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjY0XSwiZXJyb3JNZXNzYWdlIjoiYSBpcyBub3QgYSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6ImFzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OV0sImVycm9yTWVzc2FnZSI6ImIgaXMgbm90IGIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhY2NvdW50IHRvIGJlIHBhc3NlZCBieSBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5M10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFjY291bnQgdG8gYmUgcGFzc2VkIGJ5IHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE5XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwbGljYXRpb24gdG8gYmUgcGFzc2VkIGJ5IGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwbGljYXRpb24gdG8gYmUgcGFzc2VkIGJ5IHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA5XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXNzZXQgdG8gYmUgcGFzc2VkIGJ5IGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc5XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXNzZXQgdG8gYmUgcGFzc2VkIGJ5IHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyLDI0OCwyNzcsMzM5LDM4Nyw0NjEsNDk0LDcxNCw3MzAsODc5LDg5OSw5NDIsMTAwNiwxMzQxLDEzNzgsMTQzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzksMjU1LDI4NSwzNDYsMzk0LDQ2OCw1MDEsNzIxLDczN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTgsNDUyLDY3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTxhcmM0LnR1cGxlPGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PixhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4+LGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50NjQsYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjE4LDEyMzAsMTI0MiwxMjU0LDEyNjYsMTI3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDgsYXJjNC51aW50OCxhcmM0LnVpbnQ4LGFyYzQudWludDgsYXJjNC50dXBsZTxhcmM0LnVpbnQ4LGFyYzQudWludDgsYXJjNC51aW50OCxhcmM0LnVpbnQ4PixhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMCw1NDgsNzU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOCw0MDgsNDI2LDUyOSw2NTIsNjYxLDc0OCwxMTE4LDExMjUsMTEzMiwxMTM5LDExNDYsMTE1MywxMTYwLDExNjcsMTE3NCwxMTgxLDExODgsMTE5NSwxMjAyLDEyMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzQsNTg1LDU5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0OCwxMzg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMudHlwZWRfYWJpX2NhbGwubG9nZ2VyLkxvZ01lc3NhZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMudHlwZWRfYWJpX2NhbGwubG9nZ2VyLkxvZ1N0cnVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKCgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pKSwodWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKCgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pKSwodWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzIsMTM2OSwxNDI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsdWludDY0LChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQ4LDg2Niw4ODYsOTA5LDkyOCwxMzI3LDEzNjQsMTQyM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTYsODIxXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURnZ01DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGcyTlRZek5qZzJaak5oTWpBZ01IZ3dNREEyTmpVMk16WTRObVl6WVRJd0lEQjRNREVnTUhnd01EQTBDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk16RUtJQ0FnSUM4dklHTnNZWE56SUV4dloyZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNamdLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR00zTnpJeE1tSmpJREI0T1dKbU9ERTVNVE1nTUhoaU9EWXlaV1V4T1NBd2VETmpNVEExT0dRNUlEQjRObUZtTkRVNU16QWdNSGhpTkdJME16TTBaU0F3ZURabFpXUTNaV016SURCNFlqVXdNR1V4TVRFZ01IZzBObUkxTUdaaFppQXdlREEwTXpkaU1UZGxJREI0TkdFME5EUmpOemNnTUhneU5qVTVaVGd4T0NBd2VHRTVabUkyWTJZeElEQjRaRGhqWXpNMk0ySWdNSGhrTm1NeVlXTTNaaUF3ZURRNE1UUXlaRFZsSURCNE1UWmxNRE01TVRrZ01IaGhZakkzTVdObE5DQXdlR0poTUdJME16Z3hJREI0WkdSa01EY3hPRFVnTUhoa1l6Um1NVGs1TWlBdkx5QnRaWFJvYjJRZ0ltbHpYMkZmWWloaWVYUmxXMTBzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVmphRzhvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlibTlmWVhKbmN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnNiMmNvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZaeWgxYVc1ME5URXlLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZaeWh6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWJHOW5LR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYkc5bktHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0pzYjJjb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZaeWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVmphRzlmYm1GMGFYWmxYM04wY21sdVp5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbFkyaHZYMjVoZEdsMlpWOWllWFJsY3loaWVYUmxXMTBwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0psWTJodlgyNWhkR2wyWlY5MWFXNTBOalFvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaV05vYjE5dVlYUnBkbVZmWW1sbmRXbHVkQ2gxYVc1ME5URXlLWFZwYm5RMU1USWlMQ0J0WlhSb2IyUWdJbVZqYUc5ZmNtVnpiM1Z5WTJWZllubGZhVzVrWlhnb1lYTnpaWFFzWVhCd2JHbGpZWFJwYjI0c1lXTmpiM1Z1ZENrb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLU0lzSUcxbGRHaHZaQ0FpWldOb2IxOXlaWE52ZFhKalpWOWllVjkyWVd4MVpTaDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5a2lMQ0J0WlhSb2IyUWdJbVZqYUc5ZmJtRjBhWFpsWDNSMWNHeGxLSE4wY21sdVp5eGllWFJsVzEwc2RXbHVkRFkwTEhWcGJuUTFNVElwS0hOMGNtbHVaeXhpZVhSbFcxMHNkV2x1ZERZMExIVnBiblExTVRJcElpd2diV1YwYUc5a0lDSmxZMmh2WDI1bGMzUmxaRjkwZFhCc1pTZ29LSE4wY21sdVp5eHpkSEpwYm1jcExDaDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU2twS1Nnb2MzUnlhVzVuTEhOMGNtbHVaeWtzS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtTa2lMQ0J0WlhSb2IyUWdJbkpsZEhWeWJsOWhjbWR6WDJGbWRHVnlYekUwZEdnb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME9DeDFhVzUwT0N4MWFXNTBPQ3dvZFdsdWREZ3NkV2x1ZERnc2RXbHVkRGdzZFdsdWREZ3BMSFZwYm5RNEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWJHOW5jMTloY21WZlpYRjFZV3dvS0hWcGJuUTJOQ3h6ZEhKcGJtY3BMQ2gxYVc1ME5qUXNjM1J5YVc1bktTbGliMjlzSWl3Z2JXVjBhRzlrSUNKbFkyaHZYMnh2WjE5emRISjFZM1FvS0hWcGJuUTJOQ3h6ZEhKcGJtY3BLU2gxYVc1ME5qUXNjM1J5YVc1bktTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2x6WDJGZllpQmxZMmh2SUcxaGFXNWZibTlmWVhKbmMxOXliM1YwWlVBMklHeHZaMTkxYVc1ME5qUWdiRzluWDNWcGJuUTFNVElnYkc5blgzTjBjbWx1WnlCc2IyZGZZbTl2YkNCc2IyZGZZbmwwWlhNZ2JHOW5YMkZ6YzJWMFgyRmpZMjkxYm5SZllYQndJR3h2WjE5aFpHUnlaWE56SUdWamFHOWZibUYwYVhabFgzTjBjbWx1WnlCbFkyaHZYMjVoZEdsMlpWOWllWFJsY3lCbFkyaHZYMjVoZEdsMlpWOTFhVzUwTmpRZ1pXTm9iMTl1WVhScGRtVmZZbWxuZFdsdWRDQmxZMmh2WDNKbGMyOTFjbU5sWDJKNVgybHVaR1Y0SUdWamFHOWZjbVZ6YjNWeVkyVmZZbmxmZG1Gc2RXVWdaV05vYjE5dVlYUnBkbVZmZEhWd2JHVWdaV05vYjE5dVpYTjBaV1JmZEhWd2JHVWdjbVYwZFhKdVgyRnlaM05mWVdaMFpYSmZNVFIwYUNCc2IyZHpYMkZ5WlY5bGNYVmhiQ0JsWTJodlgyeHZaMTl6ZEhKMVkzUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5dWIxOWhjbWR6WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREpoQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qZzZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd3dWJHOW5aMlZ5TGt4dloyZGxjaTVwYzE5aFgySmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzE5aFgySTZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk16SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhJRDA5SUdJaVlTSXNJQ0poSUdseklHNXZkQ0JoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZU0JwY3lCdWIzUWdZUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qTTFDaUFnSUNBdkx5QmhjM05sY25RZ1lpQTlQU0JpSW1JaUxDQWlZaUJwY3lCdWIzUWdZaUlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFl5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHSWdhWE1nYm05MElHSUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvek1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JDNXNiMmRuWlhJdVRHOW5aMlZ5TG1WamFHOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsWTJodk9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pNM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pNNUNpQWdJQ0F2THlCeVpYUjFjbTRnSW1WamFHODZJQ0lnS3lCMllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPak01Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdJbVZqYUc4NklDSWdLeUIyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNRFkyTlRZek5qZzJaak5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXViRzluWDNWcGJuUTJORnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dloxOTFhVzUwTmpRNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TkRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvME53b2dJQ0FnTHk4Z2JHOW5LSFpoYkhWbEtRb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TkRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmRuWlhJdWJHOW5YM1ZwYm5RMU1USmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjJkZmRXbHVkRFV4TWpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG8wT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOVRFOUhYMDFGVkVoUFJGOU9RVTFGS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pVeENpQWdJQ0F2THlCc2IyY29kbUZzZFdVcENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG8wT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOVRFOUhYMDFGVkVoUFJGOU9RVTFGS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHd3ViRzluWjJWeUxreHZaMmRsY2k1c2IyZGZjM1J5YVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiRzluWDNOMGNtbHVaem9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzFNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5VEU5SFgwMUZWRWhQUkY5T1FVMUZLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pVMUNpQWdJQ0F2THlCc2IyY29kbUZzZFdVdWJtRjBhWFpsS1NBZ0l5QmtaV052WkdVZ2RHOGdjbVZ0YjNabElHaGxZV1JsY2dvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHeHZad29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qVXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDFNVDBkZlRVVlVTRTlFWDA1QlRVVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBlWEJsWkY5aFltbGZZMkZzYkM1c2IyZG5aWEl1VEc5bloyVnlMbXh2WjE5aWIyOXNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5blgySnZiMnc2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOVGtLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWxSeWRXVWlLU0JwWmlCMllXeDFaUzV1WVhScGRtVWdaV3h6WlNCQ2VYUmxjeWhpSWtaaGJITmxJaWtwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TkRZMk1UWmpOek0yTlNBd2VEVTBOekkzTlRZMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblI1Y0dWa1gyRmlhVjlqWVd4c0xteHZaMmRsY2k1TWIyZG5aWEl1Ykc5blgySjVkR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JHOW5YMko1ZEdWek9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pZeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvYm1GdFpUMU1UMGRmVFVWVVNFOUVYMDVCVFVVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOak1LSUNBZ0lDOHZJR3h2WnloMllXeDFaUzV1WVhScGRtVXBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmRuWlhJdWJHOW5YMkZ6YzJWMFgyRmpZMjkxYm5SZllYQndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5blgyRnpjMlYwWDJGalkyOTFiblJmWVhCd09nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvYm1GdFpUMU1UMGRmVFVWVVNFOUVYMDVCVFVVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5qY0tJQ0FnSUM4dklHeHZaeWhoYzNObGRDNXVZVzFsTENCaFkyTnZkVzUwTG1KNWRHVnpMQ0JoY0hBdVlXUmtjbVZ6Y3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRTVoYldVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPalkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQxTVQwZGZUVVZVU0U5RVgwNUJUVVVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JDNXNiMmRuWlhJdVRHOW5aMlZ5TG14dloxOWhaR1J5WlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiRzluWDJGa1pISmxjM002Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvM01Rb2dJQ0FnTHk4Z2JHOW5LR0ZrWkhKbGMzTXBDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvMk9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0c1aGJXVTlURTlIWDAxRlZFaFBSRjlPUVUxRktRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmWVdKcFgyTmhiR3d1Ykc5bloyVnlMa3h2WjJkbGNpNWxZMmh2WDI1aGRHbDJaVjl6ZEhKcGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsWTJodlgyNWhkR2wyWlY5emRISnBibWM2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzNOUW9nSUNBZ0x5OGdjbVYwZFhKdUlDSmxZMmh2T2lBaUlDc2dkbUZzZFdVS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1WamFHODZJQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamN6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGVYQmxaRjloWW1sZlkyRnNiQzVzYjJkblpYSXVURzluWjJWeUxtVmphRzlmYm1GMGFYWmxYMko1ZEdWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taV05vYjE5dVlYUnBkbVZmWW5sMFpYTTZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvM09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdJaVpXTm9iem9nSWlBcklIWmhiSFZsQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmpVMk16WTRObVl6WVRJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd3dWJHOW5aMlZ5TGt4dloyZGxjaTVsWTJodlgyNWhkR2wyWlY5MWFXNTBOalJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbFkyaHZYMjVoZEdsMlpWOTFhVzUwTmpRNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamd6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkbUZzZFdVZ0t5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamd4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXVaV05vYjE5dVlYUnBkbVZmWW1sbmRXbHVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WamFHOWZibUYwYVhabFgySnBaM1ZwYm5RNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamczQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkbUZzZFdVZ0t5QXhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREVLSUNBZ0lHSXJDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk9EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmWVdKcFgyTmhiR3d1Ykc5bloyVnlMa3h2WjJkbGNpNWxZMmh2WDNKbGMyOTFjbU5sWDJKNVgybHVaR1Y0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pXTm9iMTl5WlhOdmRYSmpaVjlpZVY5cGJtUmxlRG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzRPUzA1TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJjSEJzYVdOaGRHbHZibk1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG81TlFvZ0lDQWdMeThnWVhOelpYUmZhV1I0SUQwZ2IzQXVZblJ2YVNoVWVHNHVZWEJ3YkdsallYUnBiMjVmWVhKbmN5Z3hLU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzVOZ29nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwSUQwOUlGUjRiaTVoYzNObGRITW9ZWE56WlhSZmFXUjRLU3dnSW1WNGNHVmpkR1ZrSUdGemMyVjBJSFJ2SUdKbElIQmhjM05sWkNCaWVTQnBibVJsZUNJS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZWE56WlhRZ2RHOGdZbVVnY0dGemMyVmtJR0o1SUdsdVpHVjRDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk9UY0tJQ0FnSUM4dklHRndjRjlwWkhnZ1BTQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5aGNtZHpLRElwS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPams0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3SUQwOUlGUjRiaTVoY0hCc2FXTmhkR2x2Ym5Nb1lYQndYMmxrZUNrc0lDSmxlSEJsWTNSbFpDQmhjSEJzYVdOaGRHbHZiaUIwYnlCaVpTQndZWE56WldRZ1lua2dhVzVrWlhnaUNpQWdJQ0IwZUc1aGN5QkJjSEJzYVdOaGRHbHZibk1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHRndjR3hwWTJGMGFXOXVJSFJ2SUdKbElIQmhjM05sWkNCaWVTQnBibVJsZUFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPams1Q2lBZ0lDQXZMeUJoWTJOZmFXUjRJRDBnYjNBdVluUnZhU2hVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lnektTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFkyTWdQVDBnVkhodUxtRmpZMjkxYm5SektHRmpZMTlwWkhncExDQWlaWGh3WldOMFpXUWdZV05qYjNWdWRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2FXNWtaWGdpQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZV05qYjNWdWRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2FXNWtaWGdLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzRPUzA1TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXVaV05vYjE5eVpYTnZkWEpqWlY5aWVWOTJZV3gxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtVmphRzlmY21WemIzVnlZMlZmWW5sZmRtRnNkV1U2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNVEF6TFRFd05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0FvZ0lDQWdMeThnSUNBZ0lISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSjJZV3gxWlNJc0NpQWdJQ0F2THlBcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1UQTVDaUFnSUNBdkx5QmhjM05sZEY5cFpDQTlJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRFd0NpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUXVhV1FnUFQwZ1lYTnpaWFJmYVdRc0lDSmxlSEJsWTNSbFpDQmhjM05sZENCMGJ5QmlaU0J3WVhOelpXUWdZbmtnZG1Gc2RXVWlDaUFnSUNCa2FXY2dNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCaGMzTmxkQ0IwYnlCaVpTQndZWE56WldRZ1lua2dkbUZzZFdVS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG94TVRFS0lDQWdJQzh2SUdGd2NGOXBaQ0E5SUc5d0xtSjBiMmtvVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01pa3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1URXlDaUFnSUNBdkx5QmhjM05sY25RZ1lYQndMbWxrSUQwOUlHRndjRjlwWkN3Z0ltVjRjR1ZqZEdWa0lHRndjR3hwWTJGMGFXOXVJSFJ2SUdKbElIQmhjM05sWkNCaWVTQjJZV3gxWlNJS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z3Y0d4cFkyRjBhVzl1SUhSdklHSmxJSEJoYzNObFpDQmllU0IyWVd4MVpRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGall5NWllWFJsY3lBOVBTQmhaR1J5WlhOekxDQWlaWGh3WldOMFpXUWdZV05qYjNWdWRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3hNVE1LSUNBZ0lDOHZJR0ZrWkhKbGMzTWdQU0JVZUc0dVlYQndiR2xqWVhScGIyNWZZWEpuY3lnektRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGall5NWllWFJsY3lBOVBTQmhaR1J5WlhOekxDQWlaWGh3WldOMFpXUWdZV05qYjNWdWRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHRmpZMjkxYm5RZ2RHOGdZbVVnY0dGemMyVmtJR0o1SUhaaGJIVmxDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1UQXpMVEV3TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKMllXeDFaU0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXVaV05vYjE5dVlYUnBkbVZmZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsWTJodlgyNWhkR2wyWlY5MGRYQnNaVG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3hNVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNVEl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdJbVZqYUc4NklDSWdLeUJ6TENCaUltVmphRzg2SUNJZ0t5QmlMQ0IxSUNzZ01Td2dZblVnS3lBeENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbFkyaHZPaUFpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFkxTmpNMk9EWm1NMkV5TUFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pFeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGMyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURSakNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBlWEJsWkY5aFltbGZZMkZzYkM1c2IyZG5aWEl1VEc5bloyVnlMbVZqYUc5ZmJtVnpkR1ZrWDNSMWNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWldOb2IxOXVaWE4wWldSZmRIVndiR1U2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1Nrc0tIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNQ0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNnb2JHVnVLM1YwWmpoYlhTa3NLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElERWdiMllnS0Nnb2JHVnVLM1YwWmpoYlhTa3NLR3hsYml0MWRHWTRXMTBwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ3dvYkdWdUszVnBiblE0VzEwcEtTa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXlJRzltSUNoMWFXNTBOalFzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESXdDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuUjFjR3hsUEdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBpeGhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDQrTEdGeVl6UXVkSFZ3YkdVOFlYSmpOQzUxYVc1ME5qUXNZWEpqTkM1MWFXNTBOalFzWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK1BqNEtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE1qZ0tJQ0FnSUM4dklISmxkSFZ5YmlBb0ltVmphRzg2SUNJZ0t5QnpkSEpwYm1jc0lDSmxZMmh2T2lBaUlDc2dZWEpqTkY5emRISnBibWNwTENBb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbFkyaHZPaUFpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1USTRDaUFnSUNBdkx5QnlaWFIxY200Z0tDSmxZMmh2T2lBaUlDc2djM1J5YVc1bkxDQWlaV05vYnpvZ0lpQXJJR0Z5WXpSZmMzUnlhVzVuS1N3Z0tBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNRFkyTlRZek5qZzJaak5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakV5T1FvZ0lDQWdMeThnZFRZMElDc2dNU3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3hNekFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0dGeVl6UmZkVFkwTG1GelgzVnBiblEyTkNncElDc2dNU2tzQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3hNekFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0dGeVl6UmZkVFkwTG1GelgzVnBiblEyTkNncElDc2dNU2tzQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE16RUtJQ0FnSUM4dklHSWlaV05vYnpvZ0lpQXJJR0o1ZEdWNkxBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWTFOak0yT0RabU0yRXlNQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmRuWlhJdWNtVjBkWEp1WDJGeVozTmZZV1owWlhKZk1UUjBhRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGRIVnlibDloY21kelgyRm1kR1Z5WHpFMGRHZzZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1UTTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTBkWEJzWlR4aGNtTTBMblZwYm5RNExHRnlZelF1ZFdsdWREZ3NZWEpqTkM1MWFXNTBPQ3hoY21NMExuVnBiblE0TEdGeVl6UXVkSFZ3YkdVOFlYSmpOQzUxYVc1ME9DeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRXbHVkRGdzWVhKak5DNTFhVzUwT0Q0c1lYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUwZFhCc1pUeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRXbHVkRGdzWVhKak5DNTFhVzUwT0N4aGNtTTBMblZwYm5RNExHRnlZelF1ZEhWd2JHVThZWEpqTkM1MWFXNTBPQ3hoY21NMExuVnBiblE0TEdGeVl6UXVkV2x1ZERnc1lYSmpOQzUxYVc1ME9ENHNZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01TQXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuVnBiblE0TEdGeVl6UXVkV2x1ZERnc1lYSmpOQzUxYVc1ME9DeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwT0N4aGNtTTBMblZwYm5RNExHRnlZelF1ZFdsdWREZ3NZWEpqTkM1MWFXNTBPRDRzWVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTBkWEJzWlR4aGNtTTBMblZwYm5RNExHRnlZelF1ZFdsdWREZ3NZWEpqTkM1MWFXNTBPQ3hoY21NMExuVnBiblE0TEdGeVl6UXVkSFZ3YkdVOFlYSmpOQzUxYVc1ME9DeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRXbHVkRGdzWVhKak5DNTFhVzUwT0Q0c1lYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTXlBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUwZFhCc1pUeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRXbHVkRGdzWVhKak5DNTFhVzUwT0N4aGNtTTBMblZwYm5RNExHRnlZelF1ZEhWd2JHVThZWEpqTkM1MWFXNTBPQ3hoY21NMExuVnBiblE0TEdGeVl6UXVkV2x1ZERnc1lYSmpOQzUxYVc1ME9ENHNZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ05DQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuVnBiblE0TEdGeVl6UXVkV2x1ZERnc1lYSmpOQzUxYVc1ME9DeGhjbU0wTG5WcGJuUTRMR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwT0N4aGNtTTBMblZwYm5RNExHRnlZelF1ZFdsdWREZ3NZWEpqTkM1MWFXNTBPRDRzWVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdPQ0F4Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNVFU0Q2lBZ0lDQXZMeUJzWVhOMFgyRnlaeUE5SUdGeVl6UXVWSFZ3YkdVb0tHRXhOU3dnWVRFMkxDQmhNVGNzSUdFeE9Dd2dZVEU1TENCaE1qQXBLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1UVTVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1WDJGeVozTW9NVFVwSUQwOUlHeGhjM1JmWVhKbkxtSjVkR1Z6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TlFvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG94TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWhzWVhOMFgyRnlaeTVpZVhSbGN5a0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblI1Y0dWa1gyRmlhVjlqWVd4c0xteHZaMmRsY2k1TWIyZG5aWEl1Ykc5bmMxOWhjbVZmWlhGMVlXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjJkelgyRnlaVjlsY1hWaGJEb0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE5qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHd3ViRzluWjJWeUxreHZaMDFsYzNOaFoyVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREWTBMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmROWlhOellXZGxDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRZMENpQWdJQ0F2THlCeVpYUjFjbTRnYkc5blh6RWdQVDBnYkc5blh6SUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRZeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXVaV05vYjE5c2IyZGZjM1J5ZFdOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taV05vYjE5c2IyZGZjM1J5ZFdOME9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pFMk5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLSFZwYm5RMk5Dd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkVGRISjFZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FBaVlGQkJVZmZIVUdaV05vYnpvZ0NBQUdaV05vYnpvZ0FRRUNBQVF4RzBFQXN6RVpGRVF4R0VTQ0ZRVEhjaEs4Qkp2NEdSTUV1R0x1R1FROEVGalpCR3IwV1RBRXRMUXpUZ1J1N1g3REJMVUE0UkVFUnJVUHJ3UUVON0YrQkVwRVRIY0VKbG5vR0FTcCsyenhCTmpNTmpzRTFzS3Nmd1JJRkMxZUJCYmdPUmtFcXljYzVBUzZDME9CQk4zUWNZVUUzRThaa2pZYUFJNFZBQm9BUndBQkFHNEFlUUNGQUpnQXRRRElBUE1BL3dFZ0FVRUJVd0Z1QWJ3Qi9BSi9BNDhFWGdTK0FJQU1GUjk4ZFFBQUFBQUFBQUFxc0NKRE1Sa1VNUmdVRUVNMkdnRkpKRmtsQ0VzQkZSSkVWd0lBTmhvQ1NTUlpKUWhMQVJVU1JGY0NBRXlBQVdFU1JJQUJZaEpFSWtNMkdnRkpKRmxKSlFoTEFoVVNSRXhYQWdDQkJrOENDQlpYQmdBcVRGd0FURkFvVEZDd0lrTTJHZ0ZKRlNNU1JMQWlRellhQVVrVmdVQVNSTEFpUXpZYUFVa2tXU1VJU3dFVkVrUlhBZ0N3SWtNMkdnRkpGU0lTUkNSVGdnSUZSbUZzYzJVRVZISjFaVThDVGJBaVF6WWFBVWtrV1NVSVN3RVZFa1JYQWdDd0lrTTJHZ0ZKRlNNU1JCYzJHZ0pKRllFZ0VrUTJHZ05KRlNNU1JCZFBBbkVFUkU4Q1VFeHlDRVJRc0NKRE5ob0JTUldCSUJKRXNDSkROaG9CU1NSWkpRaExBUlVTUkZjQ0FDbE1VRWtWRmxjR0FreFFLRXhRc0NKRE5ob0JTU1JaSlFoTEFSVVNSRmNDQUNsTVVFa1ZGbGNHQWt4UUtFeFFzQ0pETmhvQlNSVWpFa1FYSWdnV0tFeFFzQ0pETmhvQlNSV0JRQkpFSzZCSkZZRkFEa1NCUUsrcktFeFFzQ0pETmhvQlNSVWlFa1FYd0RBMkdnSkpGU0lTUkJmQU1qWWFBMGtWSWhKRUY4QWNOaG9CRjhBd1N3TVNSRFlhQWhmQU1rc0NFa1EyR2dNWHdCeExBUkpFVHdJV1R3SVdVRXhRS0V4UXNDSkROaG9CU1JVakVrUVhOaG9DU1JVakVrUVhOaG9EU1JXQklCSkVOaG9CRjBzREVrUTJHZ0lYU3dJU1JFazJHZ01TUkU4Q0ZrOENGbEJNVUNoTVVMQWlRellhQVVra1dTVUlTd0VWRWtSWEFnQTJHZ0pKSkZrbENFc0JGUkpFVndJQU5ob0RTUlVqRWtRWE5ob0VTUldCUUJKRUtVOEVVQ2xQQkZCUEF5SUlUd01yb0VzREZSWlhCZ0pQQkZCSkZZRk1DRXNFRlJaWEJnSlBCVkJNRmxjR0FvQUNBRXhNVUU4RUZsQkxBeFdCUUE1RWdVQ3ZUd1NyVUU4Q1VFeFFLRXhRc0NKRE5ob0JTUlZMQVNSWlNZRUVFa1JMQWtzQlN3TlNTUlZMQVNSWlNZRUVFa1JMQWt4TEFsSWtXWUVHQ0VzQ0pWbEpTd0lTUkU4RFRFOERVaVJaSlFnSWdRUUlTd01sV1VsTEFoSkVTd1JMQVVzRlVra1ZTd0dCRUZsSmdSSVNSRXNDVEU4Q1Vra2tXWUVVQ0U4RUNFOEZFa1JPQkU0RVVra2tXVXNCSlZsTEFrOENTd0pTVndJQVN3SVZUd05QQTA4Q1Vrc0RKRnRQQTFjQ0FDbFBCRkJMQTFjQ0FFOEVKRm1CQmdnV1Z3WUFLa3hjQUV4UVR3TWlDRThFSTFzaUNCWXBUd1ZRU3dRVkZsY0dBazhGVUVrVmdRUUlGbGNHQWljRVRGQk1VRThFVUVrVmdRUUlUd1FXVHdSUVN3TVZGbGNHQWs4RVVFeUFBZ0FTVUV4UVRCWlhCZ0luQkV4UVR3SlFURkFvVEZDd0lrTTJHZ0VWSXhKRU5ob0NGU01TUkRZYUF4VWpFa1EyR2dRVkl4SkVOaG9GRlNNU1JEWWFCaFVqRWtRMkdnY1ZJeEpFTmhvSUZTTVNSRFlhQ1JVakVrUTJHZ29WSXhKRU5ob0xGU01TUkRZYURCVWpFa1EyR2cwVkl4SkVOaG9PRlNNU1JEWWFEMGtWZ1FrU1JGY0FBVFlhRDBrVmdRa1NSRmNCQVRZYUQwa1ZnUWtTUkZjQ0FUWWFEMGtWZ1FrU1JGY0RBVFlhRDBrVmdRa1NSRmNFQkRZYUQwa1ZnUWtTUkZjSUFVOEZUd1ZRVHdSUVR3TlFUd0pRVEZBMkdnOUxBUkpFU1JVV1Z3WUNURkFvVEZDd0lrTTJHZ0ZKRlVzQkkxbEpnUW9TUkVzQ1RFc0NVa2trV1lFTUNFOENFa1JNSkZ0TVZ3SUFOaG9DU1JWTEFTTlpTWUVLRWtSTEFreExBbEpKSkZtQkRBaFBBaEpFVENSYlRGY0NBRThEVHdJU1RnSVNFSUFCQUNSUEFsUW9URkN3SWtNMkdnRkpGVXNCSTFsSmdRb1NSRXNDVEVzQ1VpUlpnUXdJRWtRb1RGQ3dJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
