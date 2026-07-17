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

namespace Arc56.Generated.mohit_1710.AlgoArena.PredictionMarketContract_0d5736c1
{


    public class PredictionMarketContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PredictionMarketContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetMarketPoolsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetMarketPoolsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetMarketPoolsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMarketPoolsReturn);
                }
                public bool Equals(GetMarketPoolsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMarketPoolsReturn left, GetMarketPoolsReturn right)
                {
                    return EqualityComparer<GetMarketPoolsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMarketPoolsReturn left, GetMarketPoolsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetMarketStatusReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetMarketStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetMarketStatusReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMarketStatusReturn);
                }
                public bool Equals(GetMarketStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMarketStatusReturn left, GetMarketStatusReturn right)
                {
                    return EqualityComparer<GetMarketStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMarketStatusReturn left, GetMarketStatusReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserSharesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUserSharesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserSharesReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUserSharesReturn);
                }
                public bool Equals(GetUserSharesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserSharesReturn left, GetUserSharesReturn right)
                {
                    return EqualityComparer<GetUserSharesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserSharesReturn left, GetUserSharesReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetContractDebugInfoReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetContractDebugInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetContractDebugInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetContractDebugInfoReturn);
                }
                public bool Equals(GetContractDebugInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetContractDebugInfoReturn left, GetContractDebugInfoReturn right)
                {
                    return EqualityComparer<GetContractDebugInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetContractDebugInfoReturn left, GetContractDebugInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetContractStatusReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetContractStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetContractStatusReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetContractStatusReturn);
                }
                public bool Equals(GetContractStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetContractStatusReturn left, GetContractStatusReturn right)
                {
                    return EqualityComparer<GetContractStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetContractStatusReturn left, GetContractStatusReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetBoxNamesReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public string Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
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

                public static GetBoxNamesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetBoxNamesReturn();
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
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBoxNamesReturn);
                }
                public bool Equals(GetBoxNamesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBoxNamesReturn left, GetBoxNamesReturn right)
                {
                    return EqualityComparer<GetBoxNamesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBoxNamesReturn left, GetBoxNamesReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserBoxNamesReturn : AVMObjectType
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

                public static GetUserBoxNamesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetUserBoxNamesReturn();
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
                    return Equals(obj as GetUserBoxNamesReturn);
                }
                public bool Equals(GetUserBoxNamesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserBoxNamesReturn left, GetUserBoxNamesReturn right)
                {
                    return EqualityComparer<GetUserBoxNamesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserBoxNamesReturn left, GetUserBoxNamesReturn right)
                {
                    return !(left == right);
                }

            }

            public class ValidateTradingParamsReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
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

                public static ValidateTradingParamsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ValidateTradingParamsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as ValidateTradingParamsReturn);
                }
                public bool Equals(ValidateTradingParamsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidateTradingParamsReturn left, ValidateTradingParamsReturn right)
                {
                    return EqualityComparer<ValidateTradingParamsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidateTradingParamsReturn left, ValidateTradingParamsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize contract and create first market in one call (FRONTEND FRIENDLY)
        ///SIMPLE REQUIREMENTS: 1. Only contract creator can call this (first time only) 2. Payment TO contract >= 2 ALGO 3. Resolution time: 1 hour to 1 year from now 4. Fee rate: 0-1000 (0% to 10%)
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="resolution_time"> </param>
        /// <param name="fee_rate"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> InitializeAndCreateFirstMarket(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 83, 231, 6, 155 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InitializeAndCreateFirstMarket_Transactions(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 83, 231, 6, 155 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Frontend-friendly single-call: auto-initialize (if needed) and create market.
        ///- Accepts resolution_time in seconds or milliseconds (auto-detected). - Requires a payment to the app address with >= 2 * min_liquidity (defaults to 1 ALGO). - For the very first call, the caller becomes admin automatically. - After initialization, only admin can create new markets. Returns: market_id (UInt64).
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="resolution_time"> </param>
        /// <param name="fee_rate"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> CreateMarketSimple(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 144, 248, 212, 232 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateMarketSimple_Transactions(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 144, 248, 212, 232 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create additional markets (after contract is initialized)
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="resolution_time"> </param>
        /// <param name="fee_rate"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> CreateMarket(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 164, 4, 33, 50 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateMarket_Transactions(PaymentTransaction payment, string question, ulong resolution_time, ulong fee_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 164, 4, 33, 50 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market question
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<string> GetMarketQuestion(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 221, 92, 252 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetMarketQuestion_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 221, 92, 252 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market pools: (yes_pool, no_pool, total_volume)
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetMarketPoolsReturn> GetMarketPools(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 95, 114, 127 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMarketPoolsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarketPools_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 95, 114, 127 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market status: (is_resolved, winning_outcome)
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetMarketStatusReturn> GetMarketStatus(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 226, 96, 167 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMarketStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarketStatus_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 226, 96, 167 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate current Yes price (scaled by 1000)
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<ulong> CalculateYesPrice(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 90, 82, 25 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateYesPrice_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 90, 82, 25 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy Yes shares in a market
        ///TRANSACTION REQUIREMENTS: 1. Payment transaction must be sent TO the contract address 2. Payment must be from the same sender as app call 3. Minimum payment: 1000 microALGOs 4. Market must be active and not resolved
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> BuyYesShares(PaymentTransaction payment, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 179, 101, 36, 220 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyYesShares_Transactions(PaymentTransaction payment, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 179, 101, 36, 220 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy No shares in a market
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> BuyNoShares(PaymentTransaction payment, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 233, 215, 247, 178 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyNoShares_Transactions(PaymentTransaction payment, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 233, 215, 247, 178 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resolve a market with the winning outcome
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="yes_wins"> </param>
        public async Task ResolveMarket(ulong market_id, bool yes_wins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 229, 45, 251 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var yes_winsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); yes_winsAbi.From(yes_wins);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, yes_winsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveMarket_Transactions(ulong market_id, bool yes_wins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 229, 45, 251 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var yes_winsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); yes_winsAbi.From(yes_wins);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, yes_winsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total number of markets created
        ///</summary>
        public async Task<ulong> GetTotalMarkets(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 182, 175, 220 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalMarkets_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 182, 175, 220 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total platform fees collected
        ///</summary>
        public async Task<ulong> GetPlatformFees(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 157, 74, 177 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformFees_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 157, 74, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw collected platform fees (admin only)
        ///</summary>
        public async Task<ulong> WithdrawFees(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 220, 150, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> WithdrawFees_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 220, 150, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's Yes and No shares for a market
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetUserSharesReturn> GetUserShares(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 26, 60, 102, 83 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserSharesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserShares_Transactions(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 26, 60, 102, 83 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Redeem winning shares for a resolved market
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<ulong> RedeemWinningShares(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 120, 83, 30 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RedeemWinningShares_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 120, 83, 30 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract state for debugging
        ///</summary>
        public async Task<Structs.GetContractDebugInfoReturn> GetContractDebugInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 1, 137, 111 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetContractDebugInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetContractDebugInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 1, 137, 111 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if contract is initialized (FRONTEND HELPER)
        ///</summary>
        public async Task<bool> IsContractInitialized(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 88, 128, 113 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsContractInitialized_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 88, 128, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract initialization status - Returns (is_initialized, admin, total_markets)
        ///</summary>
        public async Task<Structs.GetContractStatusReturn> GetContractStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 124, 169, 221 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetContractStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetContractStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 124, 169, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validate market creation parameters without creating
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="resolution_time"> </param>
        /// <param name="fee_rate"> </param>
        /// <param name="payment_amount"> </param>
        public async Task<bool> ValidateCreateMarketParams(string question, ulong resolution_time, ulong fee_rate, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 194, 156, 202 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidateCreateMarketParams_Transactions(string question, ulong resolution_time, ulong fee_rate, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 194, 156, 202 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeAbi.From(resolution_time);
            var fee_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_rateAbi.From(fee_rate);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, resolution_timeAbi, fee_rateAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if sender can create markets
        ///</summary>
        /// <param name="sender"> </param>
        public async Task<bool> CanCreateMarket(Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 7, 83, 59, 149 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, senderRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanCreateMarket_Transactions(Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 7, 83, 59, 149 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate required payment for market creation
        ///</summary>
        public async Task<ulong> GetRequiredPaymentForMarket(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 160, 253, 41 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRequiredPaymentForMarket_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 160, 253, 41 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if market exists
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<bool> MarketExists(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 76, 154, 172 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MarketExists_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 76, 154, 172 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market creator address
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Algorand.Address> GetMarketCreator(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 43, 92, 93 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetMarketCreator_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 43, 92, 93 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simulate YES trade without executing - Returns (shares_received, fee_amount)
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="payment_amount"> </param>
        public async Task<Structs.GetUserSharesReturn> SimulateYesTrade(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 204, 168, 93 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserSharesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SimulateYesTrade_Transactions(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 204, 168, 93 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simulate NO trade without executing - Returns (shares_received, fee_amount)
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="payment_amount"> </param>
        public async Task<Structs.GetUserSharesReturn> SimulateNoTrade(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 186, 149, 230 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserSharesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SimulateNoTrade_Transactions(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 186, 149, 230 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get market odds as percentages - Returns (yes_percentage, no_percentage)
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetUserSharesReturn> GetMarketOdds(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 130, 184, 17 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserSharesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarketOdds_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 130, 184, 17 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get estimated value of user's position - Returns (yes_value, no_value) in microALGOs
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetUserSharesReturn> GetUserPositionValue(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 241, 204, 247, 76 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserSharesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserPositionValue_Transactions(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 241, 204, 247, 76 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get box names for a market - Returns (question_box, pools_box, creator_box)
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetBoxNamesReturn> GetBoxNames(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 81, 142, 100 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBoxNamesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoxNames_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 81, 142, 100 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user box names for a market - Returns (yes_box, no_box)
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="market_id"> </param>
        public async Task<Structs.GetUserBoxNamesReturn> GetUserBoxNames(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 236, 138, 142, 251 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.CallApp(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserBoxNamesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserBoxNames_Transactions(Address user, ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 236, 138, 142, 251 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validate trading parameters - Returns (is_valid, error_message)
        ///</summary>
        /// <param name="market_id"> </param>
        /// <param name="payment_amount"> </param>
        public async Task<Structs.ValidateTradingParamsReturn> ValidateTradingParams(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 88, 156, 114 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            var result = await base.CallApp(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidateTradingParamsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ValidateTradingParams_Transactions(ulong market_id, ulong payment_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 88, 156, 114 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);
            var payment_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payment_amountAbi.From(payment_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi, payment_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get summary of all markets - Returns (total_markets, total_volume, total_fees)
        ///</summary>
        public async Task<Structs.GetMarketPoolsReturn> GetAllMarketsSummary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 16, 232, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMarketPoolsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAllMarketsSummary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 16, 232, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGlvbk1hcmtldENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldE1hcmtldFBvb2xzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRNYXJrZXRTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dLCJHZXRVc2VyU2hhcmVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbnRyYWN0RGVidWdJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbnRyYWN0U3RhdHVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIkdldEJveE5hbWVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn1dLCJHZXRVc2VyQm94TmFtZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiVmFsaWRhdGVUcmFkaW5nUGFyYW1zUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemVfYW5kX2NyZWF0ZV9maXJzdF9tYXJrZXQiLCJkZXNjIjoiSW5pdGlhbGl6ZSBjb250cmFjdCBhbmQgY3JlYXRlIGZpcnN0IG1hcmtldCBpbiBvbmUgY2FsbCAoRlJPTlRFTkQgRlJJRU5ETFkpXG5TSU1QTEUgUkVRVUlSRU1FTlRTOiAxLiBPbmx5IGNvbnRyYWN0IGNyZWF0b3IgY2FuIGNhbGwgdGhpcyAoZmlyc3QgdGltZSBvbmx5KSAyLiBQYXltZW50IFRPIGNvbnRyYWN0ID49IDIgQUxHTyAzLiBSZXNvbHV0aW9uIHRpbWU6IDEgaG91ciB0byAxIHllYXIgZnJvbSBub3cgNC4gRmVlIHJhdGU6IDAtMTAwMCAoMCUgdG8gMTAlKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVzdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x1dGlvbl90aW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9tYXJrZXRfc2ltcGxlIiwiZGVzYyI6IkZyb250ZW5kLWZyaWVuZGx5IHNpbmdsZS1jYWxsOiBhdXRvLWluaXRpYWxpemUgKGlmIG5lZWRlZCkgYW5kIGNyZWF0ZSBtYXJrZXQuXG4tIEFjY2VwdHMgcmVzb2x1dGlvbl90aW1lIGluIHNlY29uZHMgb3IgbWlsbGlzZWNvbmRzIChhdXRvLWRldGVjdGVkKS4gLSBSZXF1aXJlcyBhIHBheW1lbnQgdG8gdGhlIGFwcCBhZGRyZXNzIHdpdGggPj0gMiAqIG1pbl9saXF1aWRpdHkgKGRlZmF1bHRzIHRvIDEgQUxHTykuIC0gRm9yIHRoZSB2ZXJ5IGZpcnN0IGNhbGwsIHRoZSBjYWxsZXIgYmVjb21lcyBhZG1pbiBhdXRvbWF0aWNhbGx5LiAtIEFmdGVyIGluaXRpYWxpemF0aW9uLCBvbmx5IGFkbWluIGNhbiBjcmVhdGUgbmV3IG1hcmtldHMuIFJldHVybnM6IG1hcmtldF9pZCAoVUludDY0KS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb25fdGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX3JhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfbWFya2V0IiwiZGVzYyI6IkNyZWF0ZSBhZGRpdGlvbmFsIG1hcmtldHMgKGFmdGVyIGNvbnRyYWN0IGlzIGluaXRpYWxpemVkKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVzdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x1dGlvbl90aW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXRfcXVlc3Rpb24iLCJkZXNjIjoiR2V0IG1hcmtldCBxdWVzdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X3Bvb2xzIiwiZGVzYyI6IkdldCBtYXJrZXQgcG9vbHM6ICh5ZXNfcG9vbCwgbm9fcG9vbCwgdG90YWxfdm9sdW1lKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldE1hcmtldFBvb2xzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hcmtldF9zdGF0dXMiLCJkZXNjIjoiR2V0IG1hcmtldCBzdGF0dXM6IChpc19yZXNvbHZlZCwgd2lubmluZ19vdXRjb21lKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJHZXRNYXJrZXRTdGF0dXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfeWVzX3ByaWNlIiwiZGVzYyI6IkNhbGN1bGF0ZSBjdXJyZW50IFllcyBwcmljZSAoc2NhbGVkIGJ5IDEwMDApIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eV95ZXNfc2hhcmVzIiwiZGVzYyI6IkJ1eSBZZXMgc2hhcmVzIGluIGEgbWFya2V0XG5UUkFOU0FDVElPTiBSRVFVSVJFTUVOVFM6IDEuIFBheW1lbnQgdHJhbnNhY3Rpb24gbXVzdCBiZSBzZW50IFRPIHRoZSBjb250cmFjdCBhZGRyZXNzIDIuIFBheW1lbnQgbXVzdCBiZSBmcm9tIHRoZSBzYW1lIHNlbmRlciBhcyBhcHAgY2FsbCAzLiBNaW5pbXVtIHBheW1lbnQ6IDEwMDAgbWljcm9BTEdPcyA0LiBNYXJrZXQgbXVzdCBiZSBhY3RpdmUgYW5kIG5vdCByZXNvbHZlZCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfbm9fc2hhcmVzIiwiZGVzYyI6IkJ1eSBObyBzaGFyZXMgaW4gYSBtYXJrZXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9tYXJrZXQiLCJkZXNjIjoiUmVzb2x2ZSBhIG1hcmtldCB3aXRoIHRoZSB3aW5uaW5nIG91dGNvbWUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoieWVzX3dpbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX21hcmtldHMiLCJkZXNjIjoiR2V0IHRvdGFsIG51bWJlciBvZiBtYXJrZXRzIGNyZWF0ZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcGxhdGZvcm1fZmVlcyIsImRlc2MiOiJHZXQgdG90YWwgcGxhdGZvcm0gZmVlcyBjb2xsZWN0ZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19mZWVzIiwiZGVzYyI6IldpdGhkcmF3IGNvbGxlY3RlZCBwbGF0Zm9ybSBmZWVzIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX3NoYXJlcyIsImRlc2MiOiJHZXQgdXNlcidzIFllcyBhbmQgTm8gc2hhcmVzIGZvciBhIG1hcmtldCIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJTaGFyZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1fd2lubmluZ19zaGFyZXMiLCJkZXNjIjoiUmVkZWVtIHdpbm5pbmcgc2hhcmVzIGZvciBhIHJlc29sdmVkIG1hcmtldCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29udHJhY3RfZGVidWdfaW5mbyIsImRlc2MiOiJHZXQgY29udHJhY3Qgc3RhdGUgZm9yIGRlYnVnZ2luZyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDb250cmFjdERlYnVnSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2NvbnRyYWN0X2luaXRpYWxpemVkIiwiZGVzYyI6IkNoZWNrIGlmIGNvbnRyYWN0IGlzIGluaXRpYWxpemVkIChGUk9OVEVORCBIRUxQRVIpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb250cmFjdF9zdGF0dXMiLCJkZXNjIjoiR2V0IGNvbnRyYWN0IGluaXRpYWxpemF0aW9uIHN0YXR1cyAtIFJldHVybnMgKGlzX2luaXRpYWxpemVkLCBhZG1pbiwgdG90YWxfbWFya2V0cykiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYWRkcmVzcyx1aW50NjQpIiwic3RydWN0IjoiR2V0Q29udHJhY3RTdGF0dXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9jcmVhdGVfbWFya2V0X3BhcmFtcyIsImRlc2MiOiJWYWxpZGF0ZSBtYXJrZXQgY3JlYXRpb24gcGFyYW1ldGVycyB3aXRob3V0IGNyZWF0aW5nIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXN0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNvbHV0aW9uX3RpbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZV9yYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5fY3JlYXRlX21hcmtldCIsImRlc2MiOiJDaGVjayBpZiBzZW5kZXIgY2FuIGNyZWF0ZSBtYXJrZXRzIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVpcmVkX3BheW1lbnRfZm9yX21hcmtldCIsImRlc2MiOiJDYWxjdWxhdGUgcmVxdWlyZWQgcGF5bWVudCBmb3IgbWFya2V0IGNyZWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya2V0X2V4aXN0cyIsImRlc2MiOiJDaGVjayBpZiBtYXJrZXQgZXhpc3RzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X2NyZWF0b3IiLCJkZXNjIjoiR2V0IG1hcmtldCBjcmVhdG9yIGFkZHJlc3MiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlX3llc190cmFkZSIsImRlc2MiOiJTaW11bGF0ZSBZRVMgdHJhZGUgd2l0aG91dCBleGVjdXRpbmcgLSBSZXR1cm5zIChzaGFyZXNfcmVjZWl2ZWQsIGZlZV9hbW91bnQpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclNoYXJlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlX25vX3RyYWRlIiwiZGVzYyI6IlNpbXVsYXRlIE5PIHRyYWRlIHdpdGhvdXQgZXhlY3V0aW5nIC0gUmV0dXJucyAoc2hhcmVzX3JlY2VpdmVkLCBmZWVfYW1vdW50KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJTaGFyZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X29kZHMiLCJkZXNjIjoiR2V0IG1hcmtldCBvZGRzIGFzIHBlcmNlbnRhZ2VzIC0gUmV0dXJucyAoeWVzX3BlcmNlbnRhZ2UsIG5vX3BlcmNlbnRhZ2UpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyU2hhcmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfcG9zaXRpb25fdmFsdWUiLCJkZXNjIjoiR2V0IGVzdGltYXRlZCB2YWx1ZSBvZiB1c2VyJ3MgcG9zaXRpb24gLSBSZXR1cm5zICh5ZXNfdmFsdWUsIG5vX3ZhbHVlKSBpbiBtaWNyb0FMR09zIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclNoYXJlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ib3hfbmFtZXMiLCJkZXNjIjoiR2V0IGJveCBuYW1lcyBmb3IgYSBtYXJrZXQgLSBSZXR1cm5zIChxdWVzdGlvbl9ib3gsIHBvb2xzX2JveCwgY3JlYXRvcl9ib3gpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR2V0Qm94TmFtZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9ib3hfbmFtZXMiLCJkZXNjIjoiR2V0IHVzZXIgYm94IG5hbWVzIGZvciBhIG1hcmtldCAtIFJldHVybnMgKHllc19ib3gsIG5vX2JveCkiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZykiLCJzdHJ1Y3QiOiJHZXRVc2VyQm94TmFtZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV90cmFkaW5nX3BhcmFtcyIsImRlc2MiOiJWYWxpZGF0ZSB0cmFkaW5nIHBhcmFtZXRlcnMgLSBSZXR1cm5zIChpc192YWxpZCwgZXJyb3JfbWVzc2FnZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxzdHJpbmcpIiwic3RydWN0IjoiVmFsaWRhdGVUcmFkaW5nUGFyYW1zUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FsbF9tYXJrZXRzX3N1bW1hcnkiLCJkZXNjIjoiR2V0IHN1bW1hcnkgb2YgYWxsIG1hcmtldHMgLSBSZXR1cm5zICh0b3RhbF9tYXJrZXRzLCB0b3RhbF92b2x1bWUsIHRvdGFsX2ZlZXMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNYXJrZXRQb29sc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjUwMiwyNTc3LDI3NTVdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIGxlbmd0aCBpcyAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMDRdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHJlc29sdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2OV0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzEwMDogTm90IGluaXRpYWxpemVkOyBjYWxsIGluaXRpYWxpemVfYW5kX2NyZWF0ZV9maXJzdF9tYXJrZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDUzLDE0NzNdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDE6IE9ubHkgYWRtaW4gY2FuIGNyZWF0ZSBtYXJrZXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3OF0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzEwMTogT25seSBjcmVhdG9yL2FkbWluIGNhbiBjcmVhdGUgbWFya2V0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NzhdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDI6IEZlZSByYXRlIG1heCAxMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgzLDEzMzJdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDI6IEZlZSByYXRlIG1heCAxMCUgKDEwMDApIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5MSwxMzQwLDE0ODZdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDM6IFBheW1lbnQgbXVzdCBnbyBUTyBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNTZdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDQ6IE5lZWQgYXQgbGVhc3QgMiAqIG1pbl9saXF1aWRpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDk1XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA0OiBOZWVkIGF0IGxlYXN0IDIgQUxHTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMDBdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDQ6IE5lZWQgYXQgbGVhc3QgMiBBTEdPICgyMDAwMDAwIG1pY3JvQWxnb3MpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxNCwxMzcwLDE1MDldLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDU6IFJlc29sdXRpb24gdGltZSBtdXN0IGJlIDErIGhvdXJzIGZyb20gbm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyMywxMzc5LDE1MThdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDY6IFJlc29sdXRpb24gdGltZSBtYXggMSB5ZWFyIGZyb20gbm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5MywxOTk1XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjAxOiBNYXJrZXQgaXMgcmVzb2x2ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzk5LDIwMDFdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8yMDI6IFRyYWRpbmcgZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODA3LDIwMDldLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8yMDM6IFBheW1lbnQgc2VuZGVyIG11c3QgbWF0Y2ggYXBwIGNhbGwgc2VuZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxNSwyMDE3XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjA0OiBQYXltZW50IG11c3QgYmUgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODIxLDIwMjNdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8yMDU6IFBheW1lbnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MjUsMjAyN10sImVycm9yTWVzc2FnZSI6IkVSUk9SXzIwNjogTWluaW11bSB0cmFkZSBhbW91bnQgaXMgMTAwMCBtaWNyb0FMR09zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczMl0sImVycm9yTWVzc2FnZSI6Ik1hcmtldCBJRCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NDddLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgY3JlYXRvciBkYXRhIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3ODIsMjg0OF0sImVycm9yTWVzc2FnZSI6Ik1hcmtldCBkYXRhIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MDEsMTYyMiwxNjY5LDE3NjAsMTk2MiwyMTcyLDIzNzgsMjc2NywyODMzLDI4OTldLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzkyXSwiZXJyb3JNZXNzYWdlIjoiTWFya2V0IG5vdCByZXNvbHZlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjY2XSwiZXJyb3JNZXNzYWdlIjoiTm8gZmVlcyB0byB3aXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NDJdLCJlcnJvck1lc3NhZ2UiOiJObyB3aW5uaW5nIHNoYXJlcyB0byByZWRlZW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzAsMzg2LDQxMCw0MzYsNDU2LDQ4Miw1MDIsNTI2LDU1MCw1NzAsNTkwLDYwNyw2MjksNjYzLDY3OSw2OTUsNzExLDczMiw3NTgsNzc1LDc5Miw4MDksODI4LDg1OSw4OTAsOTExLDkzMSw5NTEsOTc5LDEwMjAsMTA2MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiByZXNvbHZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxMF0sImVycm9yTWVzc2FnZSI6IlRvbyBlYXJseSB0byByZXNvbHZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MywzODksNDEzLDQzOSw0NTksNDg1LDUwNSw1MjksNTUzLDU3Myw1OTMsNjEwLDYzMiw2NjYsNjgyLDY5OCw3MTQsNzM1LDc2MSw3NzgsNzk1LDgxMiw4MzEsODYyLDg5Myw5MTQsOTM0LDk1NCw5ODIsMTAyMywxMDY0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MDAsMTYyMSwxNjY4LDE3NTksMTkxNywxOTYxLDIxMTksMjE3MSwyMzE0LDIzMzcsMjM3NywyNDMxLDI0NzksMjcxNCwyNzQ2LDI3ODEsMjg0NywzMjgwLDM0NThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBCb3hSZWYgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0MCwxMTczLDEyOTYsMTQ1MSwxNDY0LDIxNTUsMjI1NywyNDk2LDI1MzUsMjU1MywyNTcxLDI2NjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMTksMTM0OSwyNTE4LDI2MTQsMjY4MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWluX2xpcXVpZGl0eSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODk0LDIwOTYsMjI0OSwyMjY0LDI1MTIsMzQzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGxhdGZvcm1fZmVlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjI3LDEzODMsMTUyMiwyMjQzLDI1MDYsMjU4MSwyNjkyLDI3MjgsMjc2MywyODI5LDI4OTUsMzE3NiwzNDI3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9tYXJrZXRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0NSw4NzYsMTAwNiwxMDQ3LDEwODhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ2dNVEF3TUNBek5qQXdJRE14TlRNMk1EQXdJREV3TURBd0lERXdNREF3TURBZ01qQXdNREF3TUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKMGIzUmhiRjl0WVhKclpYUnpJaUF3ZURaa05qRTNNalppTmpVM05EVm1JREI0TldZZ0ltRmtiV2x1SWlBd2VEY3dObVkyWmpaak56TWdJbkJzWVhSbWIzSnRYMlpsWlhNaUlEQjRNREFnSW0xcGJsOXNhWEYxYVdScGRIa2lJREI0TnpFM05UWTFOek0zTkRZNU5tWTJaU0F3ZURjMU56TTJOVGN5TldZZ01IZzFaalprTmpFM01qWmlOalUzTkRWbUlEQjROak0zTWpZMU5qRTNORFptTnpJZ01IZzFaamM1TmpVM015QXdlRFZtTm1VMlpnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRE0yQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TlRObE56QTJPV0lnTUhnNU1HWTRaRFJsT0NBd2VHRTBNRFF5TVRNeUlEQjRPV1JrWkRWalptTWdNSGc1WVRWbU56STNaaUF3ZURnMFpUSTJNR0UzSURCNE9UYzFZVFV5TVRrZ01IaGlNelkxTWpSa1l5QXdlR1U1WkRkbU4ySXlJREI0TUdabE5USmtabUlnTUhnMFptSTJZV1prWXlBd2VEaGpPV1EwWVdJeElEQjRZV1JrWXprMllXSWdNSGd4WVROak5qWTFNeUF3ZURjeU56ZzFNekZsSURCNE56SXdNVGc1Tm1ZZ01IaGxZelU0T0RBM01TQXdlREF6TjJOaE9XUmtJREI0WW1Wak1qbGpZMkVnTUhnd056VXpNMkk1TlNBd2VHWTNZVEJtWkRJNUlEQjROalUwWXpsaFlXTWdNSGhoTnpKaU5XTTFaQ0F3ZURrMVkyTmhPRFZrSURCNFpqQmlZVGsxWlRZZ01IZ3lORGd5WWpneE1TQXdlR1l4WTJObU56UmpJREI0TkRjMU1UaGxOalFnTUhobFl6aGhPR1ZtWWlBd2VETmxOVGc1WXpjeUlEQjROMlV4TUdVNFl6WWdMeThnYldWMGFHOWtJQ0pwYm1sMGFXRnNhWHBsWDJGdVpGOWpjbVZoZEdWZlptbHljM1JmYldGeWEyVjBLSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwTEhCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlY5dFlYSnJaWFJmYzJsdGNHeGxLSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwTEhCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlY5dFlYSnJaWFFvYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRc2NHRjVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDIxaGNtdGxkRjl4ZFdWemRHbHZiaWgxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmYldGeWEyVjBYM0J2YjJ4ektIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmJXRnlhMlYwWDNOMFlYUjFjeWgxYVc1ME5qUXBLR0p2YjJ3c1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1OaGJHTjFiR0YwWlY5NVpYTmZjSEpwWTJVb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWW5WNVgzbGxjMTl6YUdGeVpYTW9kV2x1ZERZMExIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUoxZVY5dWIxOXphR0Z5WlhNb2RXbHVkRFkwTEhCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxjMjlzZG1WZmJXRnlhMlYwS0hWcGJuUTJOQ3hpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOTBiM1JoYkY5dFlYSnJaWFJ6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXdiR0YwWm05eWJWOW1aV1Z6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzWDJabFpYTW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNWelpYSmZjMmhoY21WektHRmpZMjkxYm5Rc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpY21Wa1pXVnRYM2RwYm01cGJtZGZjMmhoY21WektIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWpiMjUwY21GamRGOWtaV0oxWjE5cGJtWnZLQ2tvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltbHpYMk52Ym5SeVlXTjBYMmx1YVhScFlXeHBlbVZrS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZlkyOXVkSEpoWTNSZmMzUmhkSFZ6S0Nrb1ltOXZiQ3hoWkdSeVpYTnpMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6S0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0pqWVc1ZlkzSmxZWFJsWDIxaGNtdGxkQ2hoWTJOdmRXNTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRjl5WlhGMWFYSmxaRjl3WVhsdFpXNTBYMlp2Y2w5dFlYSnJaWFFvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYldGeWEyVjBYMlY0YVhOMGN5aDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyMWhjbXRsZEY5amNtVmhkRzl5S0hWcGJuUTJOQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0p6YVcxMWJHRjBaVjk1WlhOZmRISmhaR1VvZFdsdWREWTBMSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTnBiWFZzWVhSbFgyNXZYM1J5WVdSbEtIVnBiblEyTkN4MWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmJXRnlhMlYwWDI5a1pITW9kV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYM1Z6WlhKZmNHOXphWFJwYjI1ZmRtRnNkV1VvWVdOamIzVnVkQ3gxYVc1ME5qUXBLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmWW05NFgyNWhiV1Z6S0hWcGJuUTJOQ2tvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcElpd2diV1YwYUc5a0lDSm5aWFJmZFhObGNsOWliM2hmYm1GdFpYTW9ZV05qYjNWdWRDeDFhVzUwTmpRcEtITjBjbWx1Wnl4emRISnBibWNwSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjeWgxYVc1ME5qUXNkV2x1ZERZMEtTaGliMjlzTEhOMGNtbHVaeWtpTENCdFpYUm9iMlFnSW1kbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5cGJtbDBhV0ZzYVhwbFgyRnVaRjlqY21WaGRHVmZabWx5YzNSZmJXRnlhMlYwWDNKdmRYUmxRRFVnYldGcGJsOWpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjl5YjNWMFpVQTJJRzFoYVc1ZlkzSmxZWFJsWDIxaGNtdGxkRjl5YjNWMFpVQTNJRzFoYVc1ZloyVjBYMjFoY210bGRGOXhkV1Z6ZEdsdmJsOXliM1YwWlVBNElHMWhhVzVmWjJWMFgyMWhjbXRsZEY5d2IyOXNjMTl5YjNWMFpVQTVJRzFoYVc1ZloyVjBYMjFoY210bGRGOXpkR0YwZFhOZmNtOTFkR1ZBTVRBZ2JXRnBibDlqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sWDNKdmRYUmxRREV4SUcxaGFXNWZZblY1WDNsbGMxOXphR0Z5WlhOZmNtOTFkR1ZBTVRJZ2JXRnBibDlpZFhsZmJtOWZjMmhoY21WelgzSnZkWFJsUURFeklHMWhhVzVmY21WemIyeDJaVjl0WVhKclpYUmZjbTkxZEdWQU1UUWdiV0ZwYmw5blpYUmZkRzkwWVd4ZmJXRnlhMlYwYzE5eWIzVjBaVUF4TlNCdFlXbHVYMmRsZEY5d2JHRjBabTl5YlY5bVpXVnpYM0p2ZFhSbFFERTJJRzFoYVc1ZmQybDBhR1J5WVhkZlptVmxjMTl5YjNWMFpVQXhOeUJ0WVdsdVgyZGxkRjkxYzJWeVgzTm9ZWEpsYzE5eWIzVjBaVUF4T0NCdFlXbHVYM0psWkdWbGJWOTNhVzV1YVc1blgzTm9ZWEpsYzE5eWIzVjBaVUF4T1NCdFlXbHVYMmRsZEY5amIyNTBjbUZqZEY5a1pXSjFaMTlwYm1adlgzSnZkWFJsUURJd0lHMWhhVzVmYVhOZlkyOXVkSEpoWTNSZmFXNXBkR2xoYkdsNlpXUmZjbTkxZEdWQU1qRWdiV0ZwYmw5blpYUmZZMjl1ZEhKaFkzUmZjM1JoZEhWelgzSnZkWFJsUURJeUlHMWhhVzVmZG1Gc2FXUmhkR1ZmWTNKbFlYUmxYMjFoY210bGRGOXdZWEpoYlhOZmNtOTFkR1ZBTWpNZ2JXRnBibDlqWVc1ZlkzSmxZWFJsWDIxaGNtdGxkRjl5YjNWMFpVQXlOQ0J0WVdsdVgyZGxkRjl5WlhGMWFYSmxaRjl3WVhsdFpXNTBYMlp2Y2w5dFlYSnJaWFJmY205MWRHVkFNalVnYldGcGJsOXRZWEpyWlhSZlpYaHBjM1J6WDNKdmRYUmxRREkySUcxaGFXNWZaMlYwWDIxaGNtdGxkRjlqY21WaGRHOXlYM0p2ZFhSbFFESTNJRzFoYVc1ZmMybHRkV3hoZEdWZmVXVnpYM1J5WVdSbFgzSnZkWFJsUURJNElHMWhhVzVmYzJsdGRXeGhkR1ZmYm05ZmRISmhaR1ZmY205MWRHVkFNamtnYldGcGJsOW5aWFJmYldGeWEyVjBYMjlrWkhOZmNtOTFkR1ZBTXpBZ2JXRnBibDluWlhSZmRYTmxjbDl3YjNOcGRHbHZibDkyWVd4MVpWOXliM1YwWlVBek1TQnRZV2x1WDJkbGRGOWliM2hmYm1GdFpYTmZjbTkxZEdWQU16SWdiV0ZwYmw5blpYUmZkWE5sY2w5aWIzaGZibUZ0WlhOZmNtOTFkR1ZBTXpNZ2JXRnBibDkyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGMxOXliM1YwWlVBek5DQnRZV2x1WDJkbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVYM0p2ZFhSbFFETTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjloYkd4ZmJXRnlhMlYwYzE5emRXMXRZWEo1WDNKdmRYUmxRRE0xT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56WXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTJZV3hwWkdGMFpWOTBjbUZrYVc1blgzQmhjbUZ0YzE5eWIzVjBaVUF6TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3pOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3pOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlIWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MWMyVnlYMkp2ZUY5dVlXMWxjMTl5YjNWMFpVQXpNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM01qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZkWE5sY2w5aWIzaGZibUZ0WlhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgySnZlRjl1WVcxbGMxOXliM1YwWlVBek1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5aWIzaGZibUZ0WlhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzVnpaWEpmY0c5emFYUnBiMjVmZG1Gc2RXVmZjbTkxZEdWQU16RTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT1RRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmprMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzVnpaWEpmY0c5emFYUnBiMjVmZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMjFoY210bGRGOXZaR1J6WDNKdmRYUmxRRE13T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qYzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qYzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjFoY210bGRGOXZaR1J6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05wYlhWc1lYUmxYMjV2WDNSeVlXUmxYM0p2ZFhSbFFESTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYzJsdGRXeGhkR1ZmYm05ZmRISmhaR1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMmx0ZFd4aGRHVmZlV1Z6WDNSeVlXUmxYM0p2ZFhSbFFESTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYzJsdGRXeGhkR1ZmZVdWelgzUnlZV1JsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5dFlYSnJaWFJmWTNKbFlYUnZjbDl5YjNWMFpVQXlOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeE9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeE9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRZWEpyWlhSZlkzSmxZWFJ2Y2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl0WVhKclpYUmZaWGhwYzNSelgzSnZkWFJsUURJMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakE1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakE1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdiV0Z5YTJWMFgyVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmNtVnhkV2x5WldSZmNHRjViV1Z1ZEY5bWIzSmZiV0Z5YTJWMFgzSnZkWFJsUURJMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmY21WeGRXbHlaV1JmY0dGNWJXVnVkRjltYjNKZmJXRnlhMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYmw5amNtVmhkR1ZmYldGeWEyVjBYM0p2ZFhSbFFESTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdOaGJsOWpjbVZoZEdWZmJXRnlhMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1poYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDNKdmRYUmxRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UZ3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhaaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWpiMjUwY21GamRGOXpkR0YwZFhOZmNtOTFkR1ZBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGRYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFYTmZZMjl1ZEhKaFkzUmZhVzVwZEdsaGJHbDZaV1JmY205MWRHVkFNakU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdselgyTnZiblJ5WVdOMFgybHVhWFJwWVd4cGVtVmtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjlqYjI1MGNtRmpkRjlrWldKMVoxOXBibVp2WDNKdmRYUmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UVTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZZMjl1ZEhKaFkzUmZaR1ZpZFdkZmFXNW1id29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE5mY205MWRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCeVpXUmxaVzFmZDJsdWJtbHVaMTl6YUdGeVpYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM1Z6WlhKZmMyaGhjbVZ6WDNKdmRYUmxRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EZ3lDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTRNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjkxYzJWeVgzTm9ZWEpsY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkzYVhSb1pISmhkMTltWldWelgzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQjNhWFJvWkhKaGQxOW1aV1Z6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5d2JHRjBabTl5YlY5bVpXVnpYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmNHeGhkR1p2Y20xZlptVmxjd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZEc5MFlXeGZiV0Z5YTJWMGMxOXliM1YwWlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalExTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDNSdmRHRnNYMjFoY210bGRITUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVnpiMngyWlY5dFlYSnJaWFJmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCeVpYTnZiSFpsWDIxaGNtdGxkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlkWGxmYm05ZmMyaGhjbVZ6WDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16VXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZFhsZmJtOWZjMmhoY21WekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWVWOTVaWE5mYzJoaGNtVnpYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpjNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmlkWGxmZVdWelgzTm9ZWEpsY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sWDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnNZM1ZzWVhSbFgzbGxjMTl3Y21salpRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiV0Z5YTJWMFgzTjBZWFIxYzE5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl0WVhKclpYUmZjM1JoZEhWekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXRZWEpyWlhSZmNHOXZiSE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJek1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJek1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRZWEpyWlhSZmNHOXZiSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDIxaGNtdGxkRjl4ZFdWemRHbHZibDl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyMWhjbXRsZEY5eGRXVnpkR2x2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgyMWhjbXRsZEY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFgyMWhjbXRsZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZiV0Z5YTJWMFgzTnBiWEJzWlY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UQTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFgyMWhjbXRsZEY5emFXMXdiR1VLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhVzVwZEdsaGJHbDZaVjloYm1SZlkzSmxZWFJsWDJacGNuTjBYMjFoY210bGRGOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2x1YVhScFlXeHBlbVZmWVc1a1gyTnlaV0YwWlY5bWFYSnpkRjl0WVhKclpYUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRE0yT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6T0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVgzUnZYM05sWTI5dVpITW9kRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q2w5MGIxOXpaV052Ym1Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekF0TXpFS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYM1J2WDNObFkyOXVaSE1vYzJWc1ppd2dkRG9nVlVsdWREWTBLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJwWmlCMElENGdWVWx1ZERZMEtERXdYekF3TUY4d01EQmZNREF3S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd01EQXdNQ0F2THlBeE1EQXdNREF3TURBd01Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDNSdlgzTmxZMjl1WkhOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhRZ0x5OGdWVWx1ZERZMEtERXdNREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREF3Q2lBZ0lDQXZDaUFnSUNCeVpYUnpkV0lLQ2w5MGIxOXpaV052Ym1SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QnlaWFIxY200Z2RBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1YVc1cGRHbGhiR2w2WlY5aGJtUmZZM0psWVhSbFgyWnBjbk4wWDIxaGNtdGxkQ2h4ZFdWemRHbHZiam9nWW5sMFpYTXNJSEpsYzI5c2RYUnBiMjVmZEdsdFpUb2dkV2x1ZERZMExDQm1aV1ZmY21GMFpUb2dkV2x1ZERZMExDQndZWGx0Wlc1ME9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0thVzVwZEdsaGJHbDZaVjloYm1SZlkzSmxZWFJsWDJacGNuTjBYMjFoY210bGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak01TFRRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJwYm1sMGFXRnNhWHBsWDJGdVpGOWpjbVZoZEdWZlptbHljM1JmYldGeWEyVjBLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnY1hWbGMzUnBiMjQ2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTnZiSFYwYVc5dVgzUnBiV1U2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVmZjbUYwWlRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVMUxUVTJDaUFnSUNBdkx5QWpJRUYxZEc4dGFXNXBkR2xoYkdsNlpTQnBaaUJ1YjNRZ1pHOXVaU0I1WlhRS0lDQWdJQzh2SUdsbUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVdVlubDBaWE1nUFQwZ1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5NWllWFJsY3pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKNklHbHVhWFJwWVd4cGVtVmZZVzVrWDJOeVpXRjBaVjltYVhKemRGOXRZWEpyWlhSZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMjFoY210bGRITWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJ6Wld4bUxuQnNZWFJtYjNKdFgyWmxaWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa3VkbUZzZFdVZ1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTQWdJeUF4SUVGTVIwOGdaR1ZtWVhWc2RBb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJXbHVYMnhwY1hWcFpHbDBlU0lLSUNBZ0lHbHVkR01nTnlBdkx5QXhNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0thVzVwZEdsaGJHbDZaVjloYm1SZlkzSmxZWFJsWDJacGNuTjBYMjFoY210bGRGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNaTAyTXdvZ0lDQWdMeThnSXlCV1lXeHBaR0YwWlNCallXeHNaWElnYVhNZ1lXUnRhVzR2WTNKbFlYUnZjZ29nSUNBZ0x5OGdhWE5mWTNKbFlYUnZjaUE5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTWdQVDBnVkhodUxuTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJR2x6WDJGa2JXbHVJRDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5UFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5amNtVmhkRzl5SUc5eUlHbHpYMkZrYldsdUxDQWlSVkpTVDFKZk1UQXhPaUJQYm14NUlHTnlaV0YwYjNJdllXUnRhVzRnWTJGdUlHTnlaV0YwWlNCdFlYSnJaWFJ6SWdvZ0lDQWdmSHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eE1ERTZJRTl1YkhrZ1kzSmxZWFJ2Y2k5aFpHMXBiaUJqWVc0Z1kzSmxZWFJsSUcxaGNtdGxkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZM0xUWTRDaUFnSUNBdkx5QWpJRk5wYlhCc1pTQjJZV3hwWkdGMGFXOXVjd29nSUNBZ0x5OGdZWE56WlhKMElHWmxaVjl5WVhSbElEdzlJRlZKYm5RMk5DZ3hNREF3S1N3Z0lrVlNVazlTWHpFd01qb2dSbVZsSUhKaGRHVWdiV0Y0SURFd0pTQW9NVEF3TUNraUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdNam9nUm1WbElISmhkR1VnYldGNElERXdKU0FvTVRBd01Da0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpUlZKU1QxSmZNVEF6T2lCUVlYbHRaVzUwSUcxMWMzUWdaMjhnVkU4Z1kyOXVkSEpoWTNRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHhNRE02SUZCaGVXMWxiblFnYlhWemRDQm5ieUJVVHlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCVlNXNTBOalFvTWw4d01EQmZNREF3S1N3Z0tBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBNElDOHZJREl3TURBd01EQUtJQ0FnSUQ0OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNNQzAzTWdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJRlZKYm5RMk5DZ3lYekF3TUY4d01EQXBMQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lrVlNVazlTWHpFd05Eb2dUbVZsWkNCaGRDQnNaV0Z6ZENBeUlFRk1SMDhnS0RJd01EQXdNREFnYldsamNtOUJiR2R2Y3lraUNpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEEwT2lCT1pXVmtJR0YwSUd4bFlYTjBJRElnUVV4SFR5QW9NakF3TURBd01DQnRhV055YjBGc1oyOXpLUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUhKbGMxOTBhVzFsWDNObFl5QTlJSE5sYkdZdVgzUnZYM05sWTI5dVpITW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqWVd4c2MzVmlJRjkwYjE5elpXTnZibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMxOTBhVzFsWDNObFl5QStJQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQXJJRlZKYm5RMk5DZ3pOakF3S1Nrc0lDZ0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBek5qQXdDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56UXROellLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWE5mZEdsdFpWOXpaV01nUGlBb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnS3lCVlNXNTBOalFvTXpZd01Da3BMQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lrVlNVazlTWHpFd05Ub2dVbVZ6YjJ4MWRHbHZiaUIwYVcxbElHMTFjM1FnWW1VZ01Tc2dhRzkxY25NZ1puSnZiU0J1YjNjaUNpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEExT2lCU1pYTnZiSFYwYVc5dUlIUnBiV1VnYlhWemRDQmlaU0F4S3lCb2IzVnljeUJtY205dElHNXZkd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhOZmRHbHRaVjl6WldNZ1BEMGdLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2dWVWx1ZERZMEtETXhYelV6Tmw4d01EQXBLU3dnS0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWXlBMUlDOHZJRE14TlRNMk1EQXdDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qYzNMVGM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ6WDNScGJXVmZjMlZqSUR3OUlDaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklGVkpiblEyTkNnek1WODFNelpmTURBd0tTa3NJQ2dLSUNBZ0lDOHZJQ0FnSUNBaVJWSlNUMUpmTVRBMk9pQlNaWE52YkhWMGFXOXVJSFJwYldVZ2JXRjRJREVnZVdWaGNpQm1jbTl0SUc1dmR5SUtJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURZNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdFlYZ2dNU0I1WldGeUlHWnliMjBnYm05M0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdiV0Z5YTJWMFgybGtJRDBnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYldGeWEyVjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pnMExUZzFDaUFnSUNBdkx5QWpJRk4wYjNKbElHMWhjbXRsZENCeGRXVnpkR2x2YmdvZ0lDQWdMeThnY1hWbGMzUnBiMjVmWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp4ZFdWemRHbHZiaUlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGczTVRjMU5qVTNNemMwTmprMlpqWmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCeGRXVnpkR2x2Ymw5aWIzZ3VjSFYwS0hGMVpYTjBhVzl1TG1KNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE9DMDRPUW9nSUNBZ0x5OGdJeUJUZEc5eVpTQnRZWEpyWlhRZ2NHOXZiSE1nWVc1a0lHMWxkR0ZrWVhSaENpQWdJQ0F2THlCcGJtbDBhV0ZzWDNCdmIyd2dQU0J3WVhsdFpXNTBMbUZ0YjNWdWRDQXZMeUJWU1c1ME5qUW9NaWtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nZVdWelgzQnZiMndLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2preExUa3lDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nZVdWelgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCdWIxOXdiMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTQXJJQ0FnSUNBZ0lDQWdJeUIwYjNSaGJGOTJiMngxYldVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNU1TMDVNd29nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2JtOWZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzZ0lDQWdJQ0FnSUNBaklIUnZkR0ZzWDNadmJIVnRaUW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2dJQ0FnSUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG81TVMwNU5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNBZ0lDQWpJSGxsYzE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nYm05ZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDQWdJQ0FqSUhSdmRHRnNYM1p2YkhWdFpRb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t5QWdJQ0FnSUNBZ0lDQWpJR1psWlY5eVlYUmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMxOTBhVzFsWDNObFl5a2dLeUFnSUNBZ0lDTWdjbVZ6YjJ4MWRHbHZibDkwYVcxbENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2preExUazFDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nZVdWelgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCdWIxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lBZ0lDQWdJQ0FnSUNNZ2RHOTBZV3hmZG05c2RXMWxDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJJQ0FnSUNBZ0lDQWdJQ01nWm1WbFgzSmhkR1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6WDNScGJXVmZjMlZqS1NBcklDQWdJQ0FnSXlCeVpYTnZiSFYwYVc5dVgzUnBiV1VLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9URXRPVFlLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCNVpYTmZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklHNXZYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1NBcklDQWdJQ0FnSUNBZ0l5QjBiM1JoYkY5MmIyeDFiV1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NnSUNBZ0lDQWdJQ0FnSXlCbVpXVmZjbUYwWlFvZ0lDQWdMeThnYjNBdWFYUnZZaWh5WlhOZmRHbHRaVjl6WldNcElDc2dJQ0FnSUNBaklISmxjMjlzZFhScGIyNWZkR2x0WlFvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzZ0lDQWdJQ0FnSUNBaklHbHpYM0psYzI5c2RtVmtJQ2d3UFVaaGJITmxLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UQXRPVGdLSUNBZ0lDOHZJSEJ2YjJ4elgyUmhkR0VnUFNBb0NpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNBZ0lDQWpJRzV2WDNCdmIyd0tJQ0FnSUM4dklDQWdJQ0J2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lBZ0lDQWdJQ0FnSUNNZ2RHOTBZV3hmZG05c2RXMWxDaUFnSUNBdkx5QWdJQ0FnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lBZ0lDQWdJQ0FnSUNBaklHWmxaVjl5WVhSbENpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ0lDQWdJQ0FqSUhKbGMyOXNkWFJwYjI1ZmRHbHRaUW9nSUNBZ0x5OGdJQ0FnSUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1NBcklDQWdJQ0FnSUNBZ0l5QnBjMTl5WlhOdmJIWmxaQ0FvTUQxR1lXeHpaU2tLSUNBZ0lDOHZJQ0FnSUNCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0lDQWdJQ0FnSUNBZ0lDTWdkMmx1Ym1sdVoxOXZkWFJqYjIxbElDZ3dQVTV2TENBeFBWbGxjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2preExUazNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nZVdWelgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCdWIxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lBZ0lDQWdJQ0FnSUNNZ2RHOTBZV3hmZG05c2RXMWxDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJJQ0FnSUNBZ0lDQWdJQ01nWm1WbFgzSmhkR1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6WDNScGJXVmZjMlZqS1NBcklDQWdJQ0FnSXlCeVpYTnZiSFYwYVc5dVgzUnBiV1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWdJQ0FnSXlCcGMxOXlaWE52YkhabFpDQW9NRDFHWVd4elpTa0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTQWdJQ0FnSUNBZ0lDQWdJeUIzYVc1dWFXNW5YMjkxZEdOdmJXVWdLREE5VG04c0lERTlXV1Z6S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzVPUW9nSUNBZ0x5OGdjRzl2YkhOZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKd2IyOXNjeUlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd05tWTJaalpqTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEF3Q2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2d1Y0hWMEtIQnZiMnh6WDJSaGRHRXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1ESXRNVEF6Q2lBZ0lDQXZMeUFqSUZOMGIzSmxJR055WldGMGIzSUtJQ0FnSUM4dklHTnlaV0YwYjNKZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKamNtVmhkRzl5SWlrS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE5qTTNNalkxTmpFM05EWm1OeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QmpjbVZoZEc5eVgySnZlQzV3ZFhRb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbElEMGdiV0Z5YTJWMFgybGtJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUcxaGNtdGxkRjlwWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbU55WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsS0hGMVpYTjBhVzl1T2lCaWVYUmxjeXdnY21WemIyeDFkR2x2Ymw5MGFXMWxPaUIxYVc1ME5qUXNJR1psWlY5eVlYUmxPaUIxYVc1ME5qUXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BqY21WaGRHVmZiV0Z5YTJWMFgzTnBiWEJzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdPUzB4TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2NYVmxjM1JwYjI0NklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhWMGFXOXVYM1JwYldVNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1ZmY21GMFpUb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUxBb2dJQ0FnTHk4Z0tTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlOQzB4TWpVS0lDQWdJQzh2SUNNZ1FYVjBieTFwYm1sMGFXRnNhWHBsSUc5dUlHWnBjbk4wSUhWelpRb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMbUo1ZEdWek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZM0psWVhSbFgyMWhjbXRsZEY5emFXMXdiR1ZmWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlOd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5dFlYSnJaWFJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1qZ0tJQ0FnSUM4dklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5NTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHeGhkR1p2Y20xZlptVmxjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCcFppQnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa3VkbUZzZFdVZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUdKdWVpQmpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV6TUFvZ0lDQWdMeThnYzJWc1ppNXRhVzVmYkdseGRXbGthWFI1TG5aaGJIVmxJRDBnVlVsdWREWTBLREZmTURBd1h6QXdNQ2tnSUNNZ01TQkJURWRQSUdSbFptRjFiSFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTFwYmw5c2FYRjFhV1JwZEhraUNpQWdJQ0JwYm5SaklEY2dMeThnTVRBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ21OeVpXRjBaVjl0WVhKclpYUmZjMmx0Y0d4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpOQzB4TXpVS0lDQWdJQzh2SUNNZ1ZtRnNhV1JoZEdVZ2FXNXdkWFJ6Q2lBZ0lDQXZMeUJoYzNObGNuUWdabVZsWDNKaGRHVWdQRDBnVlVsdWREWTBLREV3TURBcExDQWlSVkpTVDFKZk1UQXlPaUJHWldVZ2NtRjBaU0J0WVhnZ01UQWxJQ2d4TURBd0tTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEF5T2lCR1pXVWdjbUYwWlNCdFlYZ2dNVEFsSUNneE1EQXdLUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVJWSlNUMUpmTVRBek9pQlFZWGx0Wlc1MElHMTFjM1FnWjI4Z1ZFOGdZMjl1ZEhKaFkzUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURNNklGQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCVVR5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdLSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlUzUyWVd4MVpTQXFJRlZKYm5RMk5DZ3lLU2tzSUNKRlVsSlBVbDh4TURRNklFNWxaV1FnWVhRZ2JHVmhjM1FnTWlBcUlHMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHhNRFE2SUU1bFpXUWdZWFFnYkdWaGMzUWdNaUFxSUcxcGJsOXNhWEYxYVdScGRIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnY21WelgzUnBiV1ZmYzJWaklEMGdjMlZzWmk1ZmRHOWZjMlZqYjI1a2N5aHlaWE52YkhWMGFXOXVYM1JwYldVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdYM1J2WDNObFkyOXVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMxOTBhVzFsWDNObFl5QStJQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQXJJRlZKYm5RMk5DZ3pOakF3S1Nrc0lDZ0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBek5qQXdDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUwTWdvZ0lDQWdMeThnWVhOelpYSjBJSEpsYzE5MGFXMWxYM05sWXlBK0lDaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklGVkpiblEyTkNnek5qQXdLU2tzSUNnS0lDQWdJQzh2SUNBZ0lDQWlSVkpTVDFKZk1UQTFPaUJTWlhOdmJIVjBhVzl1SUhScGJXVWdiWFZ6ZENCaVpTQXhLeUJvYjNWeWN5Qm1jbTl0SUc1dmR5SUtJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURVNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdGRYTjBJR0psSURFcklHaHZkWEp6SUdaeWIyMGdibTkzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTmZkR2x0WlY5elpXTWdQRDBnS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnVlVsdWREWTBLRE14WHpVek5sOHdNREFwS1N3Z0tBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFl5QTFJQzh2SURNeE5UTTJNREF3Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUwTXkweE5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTmZkR2x0WlY5elpXTWdQRDBnS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnVlVsdWREWTBLRE14WHpVek5sOHdNREFwS1N3Z0tBb2dJQ0FnTHk4Z0lDQWdJQ0pGVWxKUFVsOHhNRFk2SUZKbGMyOXNkWFJwYjI0Z2RHbHRaU0J0WVhnZ01TQjVaV0Z5SUdaeWIyMGdibTkzSWdvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdOam9nVW1WemIyeDFkR2x2YmlCMGFXMWxJRzFoZUNBeElIbGxZWElnWm5KdmJTQnViM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME55MHhORGdLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJRzFoY210bGRBb2dJQ0FnTHk4Z2JXRnlhMlYwWDJsa0lEMGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiV0Z5YTJWMGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSeklHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUTVDaUFnSUNBdkx5QnRZWEpyWlhSZmNISmxabWw0SUQwZ1lpSnRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVh5SUtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMVpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TlRFdE1UVXlDaUFnSUNBdkx5QWpJRk4wYjNKbElHMWhjbXRsZENCeGRXVnpkR2x2YmdvZ0lDQWdMeThnY1hWbGMzUnBiMjVmWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp4ZFdWemRHbHZiaUlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGczTVRjMU5qVTNNemMwTmprMlpqWmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRMbkIxZENoeGRXVnpkR2x2Ymk1aWVYUmxjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UVTFMVEUxTmdvZ0lDQWdMeThnSXlCVGRHOXlaU0J0WVhKclpYUWdjRzl2YkhNZ1lXNWtJRzFsZEdGa1lYUmhDaUFnSUNBdkx5QnBibWwwYVdGc1gzQnZiMndnUFNCd1lYbHRaVzUwTG1GdGIzVnVkQ0F2THlCVlNXNTBOalFvTWlrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklIbGxjMTl3YjI5c0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOVGd0TVRVNUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdlV1Z6WDNCdmIyd0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUJ1YjE5d2IyOXNDaUFnSUNCa2RYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVNExURTJNQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2JtOWZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzZ0lDQWdJQ0FnSUNBaklIUnZkR0ZzWDNadmJIVnRaUW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UWXhDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJJQ0FnSUNBZ0lDQWdJQ01nWm1WbFgzSmhkR1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVNExURTJNUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2JtOWZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzZ0lDQWdJQ0FnSUNBaklIUnZkR0ZzWDNadmJIVnRaUW9nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLeUFnSUNBZ0lDQWdJQ0FqSUdabFpWOXlZWFJsQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ0lDQWdJQ0FqSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0FvYzJWamIyNWtjeWtLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFU0TFRFMk1nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNBZ0lDQWpJSGxsYzE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nYm05ZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDQWdJQ0FqSUhSdmRHRnNYM1p2YkhWdFpRb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t5QWdJQ0FnSUNBZ0lDQWpJR1psWlY5eVlYUmxDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMTkwYVcxbFgzTmxZeWtnS3lBZ0lDQWdJQ01nY21WemIyeDFkR2x2Ymw5MGFXMWxJQ2h6WldOdmJtUnpLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5UZ3RNVFl6Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FnSUNBZ0l5QnViMTl3YjI5c0NpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FySUNBZ0lDQWdJQ0FnSUNNZ1ptVmxYM0poZEdVS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WelgzUnBiV1ZmYzJWaktTQXJJQ0FnSUNBZ0l5QnlaWE52YkhWMGFXOXVYM1JwYldVZ0tITmxZMjl1WkhNcENpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdhWE5mY21WemIyeDJaV1FnS0RBOVJtRnNjMlVwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOVGN0TVRZMUNpQWdJQ0F2THlCd2IyOXNjMTlrWVhSaElEMGdLQW9nSUNBZ0x5OGdJQ0FnSUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FnSUNBZ0l5QjVaWE5mY0c5dmJBb2dJQ0FnTHk4Z0lDQWdJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCdWIxOXdiMjlzQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2dJQ0FnSUNBZ0lDQWpJSFJ2ZEdGc1gzWnZiSFZ0WlFvZ0lDQWdMeThnSUNBZ0lHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2dJQ0FnSUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ0x5OGdJQ0FnSUc5d0xtbDBiMklvY21WelgzUnBiV1ZmYzJWaktTQXJJQ0FnSUNBZ0l5QnlaWE52YkhWMGFXOXVYM1JwYldVZ0tITmxZMjl1WkhNcENpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDQWdJQ0FqSUdselgzSmxjMjlzZG1Wa0lDZ3dQVVpoYkhObEtRb2dJQ0FnTHk4Z0lDQWdJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FnSUNBZ0lDQWdJQ0FnSXlCM2FXNXVhVzVuWDI5MWRHTnZiV1VnS0RBOVRtOHNJREU5V1dWektRb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFU0TFRFMk5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNBZ0lDQWpJSGxsYzE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nYm05ZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDQWdJQ0FqSUhSdmRHRnNYM1p2YkhWdFpRb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t5QWdJQ0FnSUNBZ0lDQWpJR1psWlY5eVlYUmxDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMTkwYVcxbFgzTmxZeWtnS3lBZ0lDQWdJQ01nY21WemIyeDFkR2x2Ymw5MGFXMWxJQ2h6WldOdmJtUnpLUW9nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDQWdJQ0FqSUdselgzSmxjMjlzZG1Wa0lDZ3dQVVpoYkhObEtRb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDQWdJQ0FnSUNBZ0lDQWpJSGRwYm01cGJtZGZiM1YwWTI5dFpTQW9NRDFPYnl3Z01UMVpaWE1wQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTJOZ29nSUNBZ0x5OGdjRzl2YkhOZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKd2IyOXNjeUlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd05tWTJaalpqTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFkzQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2d1Y0hWMEtIQnZiMnh6WDJSaGRHRXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5qa3RNVGN3Q2lBZ0lDQXZMeUFqSUZOMGIzSmxJR055WldGMGIzSUtJQ0FnSUM4dklHTnlaV0YwYjNKZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKamNtVmhkRzl5SWlrS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE5qTTNNalkxTmpFM05EWm1OeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UY3hDaUFnSUNBdkx5QmpjbVZoZEc5eVgySnZlQzV3ZFhRb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbElEMGdiV0Z5YTJWMFgybGtJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFM05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUcxaGNtdGxkRjlwWkFvZ0lDQWdjbVYwYzNWaUNncGpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjlsYkhObFgySnZaSGxBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpNZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWtWU1VrOVNYekV3TVRvZ1QyNXNlU0JoWkcxcGJpQmpZVzRnWTNKbFlYUmxJRzFoY210bGRITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdNVG9nVDI1c2VTQmhaRzFwYmlCallXNGdZM0psWVhSbElHMWhjbXRsZEhNS0lDQWdJR0lnWTNKbFlYUmxYMjFoY210bGRGOXphVzF3YkdWZllXWjBaWEpmYVdaZlpXeHpaVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtTnlaV0YwWlY5dFlYSnJaWFFvY1hWbGMzUnBiMjQ2SUdKNWRHVnpMQ0J5WlhOdmJIVjBhVzl1WDNScGJXVTZJSFZwYm5RMk5Dd2dabVZsWDNKaGRHVTZJSFZwYm5RMk5Dd2djR0Y1YldWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbU55WldGMFpWOXRZWEpyWlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOell0TVRnekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZiV0Z5YTJWMEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdjWFZsYzNScGIyNDZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0J5WlhOdmJIVjBhVzl1WDNScGJXVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JtWldWZmNtRjBaVG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU0TlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXVZbmwwWlhNZ0lUMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeTVpZVhSbGN5d2dLQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE9EVXRNVGczQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lBaFBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMbUo1ZEdWekxDQW9DaUFnSUNBdkx5QWdJQ0FnSWtWU1VrOVNYekV3TURvZ1RtOTBJR2x1YVhScFlXeHBlbVZrT3lCallXeHNJR2x1YVhScFlXeHBlbVZmWVc1a1gyTnlaV0YwWlY5bWFYSnpkRjl0WVhKclpYUWlDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTVRBd09pQk9iM1FnYVc1cGRHbGhiR2w2WldRN0lHTmhiR3dnYVc1cGRHbGhiR2w2WlY5aGJtUmZZM0psWVhSbFgyWnBjbk4wWDIxaGNtdGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRnNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlSVkpTVDFKZk1UQXhPaUJQYm14NUlHRmtiV2x1SUdOaGJpQmpjbVZoZEdVZ2JXRnlhMlYwY3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTVRBeE9pQlBibXg1SUdGa2JXbHVJR05oYmlCamNtVmhkR1VnYldGeWEyVjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCaGMzTmxjblFnWm1WbFgzSmhkR1VnUEQwZ1ZVbHVkRFkwS0RFd01EQXBMQ0FpUlZKU1QxSmZNVEF5T2lCR1pXVWdjbUYwWlNCdFlYZ2dNVEFsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eE1ESTZJRVpsWlNCeVlYUmxJRzFoZUNBeE1DVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWtWU1VrOVNYekV3TXpvZ1VHRjViV1Z1ZENCdGRYTjBJR2R2SUZSUElHTnZiblJ5WVdOMElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEF6T2lCUVlYbHRaVzUwSUcxMWMzUWdaMjhnVkU4Z1kyOXVkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdVlXMXZkVzUwSUQ0OUlGVkpiblEyTkNneVh6QXdNRjh3TURBcExDQWlSVkpTVDFKZk1UQTBPaUJPWldWa0lHRjBJR3hsWVhOMElESWdRVXhIVHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nT0NBdkx5QXlNREF3TURBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdORG9nVG1WbFpDQmhkQ0JzWldGemRDQXlJRUZNUjA4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVNZ29nSUNBZ0x5OGdjbVZ6WDNScGJXVmZjMlZqSUQwZ2MyVnNaaTVmZEc5ZmMyVmpiMjVrY3loeVpYTnZiSFYwYVc5dVgzUnBiV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTmhiR3h6ZFdJZ1gzUnZYM05sWTI5dVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU1TXdvZ0lDQWdMeThnWVhOelpYSjBJSEpsYzE5MGFXMWxYM05sWXlBK0lDaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklGVkpiblEyTkNnek5qQXdLU2tzSUNnS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdNZ05DQXZMeUF6TmpBd0NpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRrekxURTVOUW9nSUNBZ0x5OGdZWE56WlhKMElISmxjMTkwYVcxbFgzTmxZeUErSUNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUZWSmJuUTJOQ2d6TmpBd0tTa3NJQ2dLSUNBZ0lDOHZJQ0FnSUNBaVJWSlNUMUpmTVRBMU9pQlNaWE52YkhWMGFXOXVJSFJwYldVZ2JYVnpkQ0JpWlNBeEt5Qm9iM1Z5Y3lCbWNtOXRJRzV2ZHlJS0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHhNRFU2SUZKbGMyOXNkWFJwYjI0Z2RHbHRaU0J0ZFhOMElHSmxJREVySUdodmRYSnpJR1p5YjIwZ2JtOTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhOZmRHbHRaVjl6WldNZ1BEMGdLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2dWVWx1ZERZMEtETXhYelV6Tmw4d01EQXBLU3dnS0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWXlBMUlDOHZJRE14TlRNMk1EQXdDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVOaTB4T1RnS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhOZmRHbHRaVjl6WldNZ1BEMGdLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2dWVWx1ZERZMEtETXhYelV6Tmw4d01EQXBLU3dnS0FvZ0lDQWdMeThnSUNBZ0lDSkZVbEpQVWw4eE1EWTZJRkpsYzI5c2RYUnBiMjRnZEdsdFpTQnRZWGdnTVNCNVpXRnlJR1p5YjIwZ2JtOTNJZ29nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd05qb2dVbVZ6YjJ4MWRHbHZiaUIwYVcxbElHMWhlQ0F4SUhsbFlYSWdabkp2YlNCdWIzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3TUFvZ0lDQWdMeThnYldGeWEyVjBYMmxrSUQwZ2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBeENpQWdJQ0F2THlCdFlYSnJaWFJmY0hKbFptbDRJRDBnWWlKdFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWHlJS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURaa05qRTNNalppTmpVM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcxWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJSEYxWlhOMGFXOXVYMkp2ZUNBOUlFSnZlRkpsWmloclpYazliV0Z5YTJWMFgzQnlaV1pwZUNBcklHSWljWFZsYzNScGIyNGlLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjROekUzTlRZMU56TTNORFk1Tm1ZMlpRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURRS0lDQWdJQzh2SUhGMVpYTjBhVzl1WDJKdmVDNXdkWFFvY1hWbGMzUnBiMjR1WW5sMFpYTXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJd05nb2dJQ0FnTHk4Z2FXNXBkR2xoYkY5d2IyOXNJRDBnY0dGNWJXVnVkQzVoYlc5MWJuUWdMeThnVlVsdWREWTBLRElwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNRGdLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1NBckNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lCdmNDNXBkRzlpS0hKbGMxOTBhVzFsWDNObFl5a2dLeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQTRMVEl3T1FvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2diM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJd09Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t5QnZjQzVwZEc5aUtISmxjMTkwYVcxbFgzTmxZeWtnS3lCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQTRMVEl3T1FvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2diM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdOeTB5TVRBS0lDQWdJQzh2SUhCdmIyeHpYMlJoZEdFZ1BTQW9DaUFnSUNBdkx5QWdJQ0FnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklDQWdJQ0J2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FySUc5d0xtbDBiMklvY21WelgzUnBiV1ZmYzJWaktTQXJJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1FvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQTRMVEl3T1FvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2diM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeE1Rb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ3VjSFYwS0hCdmIyeHpYMlJoZEdFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVRRS0lDQWdJQzh2SUdOeVpXRjBiM0pmWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUpqY21WaGRHOXlJaWtLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TmpNM01qWTFOakUzTkRabU56SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFMUNpQWdJQ0F2THlCamNtVmhkRzl5WDJKdmVDNXdkWFFvVkhodUxuTmxibVJsY2k1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeE53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsSUQwZ2JXRnlhMlYwWDJsa0lDc2dWVWx1ZERZMEtERXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnY21WMGRYSnVJRzFoY210bGRGOXBaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtZGxkRjl0WVhKclpYUmZjWFZsYzNScGIyNG9iV0Z5YTJWMFgybGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSZmJXRnlhMlYwWDNGMVpYTjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qSXdMVEl5TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdaMlYwWDIxaGNtdGxkRjl4ZFdWemRHbHZiaWh6Wld4bUxDQnRZWEpyWlhSZmFXUTZJRlZKYm5RMk5Da2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNak1LSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKeGRXVnpkR2x2YmlJcENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE56RTNOVFkxTnpNM05EWTVObVkyWlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnhkV1Z6ZEdsdmJsOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeU53b2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZllubDBaWE1zSUY5bGVHbHpkSE1nUFNCeGRXVnpkR2x2Ymw5aWIzZ3ViV0Y1WW1Vb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TWpnS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY3Vabkp2YlY5aWVYUmxjeWh4ZFdWemRHbHZibDlpZVhSbGN5a0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1blpYUmZiV0Z5YTJWMFgzQnZiMnh6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMjFoY210bGRGOXdiMjlzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXpNQzB5TXpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5dFlYSnJaWFJmY0c5dmJITW9jMlZzWml3Z2JXRnlhMlYwWDJsa09pQlZTVzUwTmpRcElDMCtJR0Z5WXpRdVZIVndiR1ZiWVhKak5DNVZTVzUwTmpRc0lHRnlZelF1VlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJek13b2dJQ0FnTHk4Z2JXRnlhMlYwWDNCeVpXWnBlQ0E5SUdJaWJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluQnZiMnh6SWlrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnM01EWm1ObVkyWXpjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl6TlFvZ0lDQWdMeThnWVhOelpYSjBJSEJ2YjJ4elgySnZlQzVzWlc1bmRHZ2dQaUF3TENBaVRXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBJZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRVbVZtSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpNM0NpQWdJQ0F2THlCd2IyOXNjMTlrWVhSaExDQmZaWGhwYzNSeklEMGdjRzl2YkhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpNNUNpQWdJQ0F2THlCNVpYTmZjRzl2YkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qUXdDaUFnSUNBdkx5QnViMTl3YjI5c0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2c0S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkwTVFvZ0lDQWdMeThnZEc5MFlXeGZkbTlzZFcxbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d4Tmlrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TkRNS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoaGNtTTBMbFZKYm5RMk5DaDVaWE5mY0c5dmJDa3NJR0Z5WXpRdVZVbHVkRFkwS0c1dlgzQnZiMndwTENCaGNtTTBMbFZKYm5RMk5DaDBiM1JoYkY5MmIyeDFiV1VwS1NrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYMjFoY210bGRGOXpkR0YwZFhNb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncG5aWFJmYldGeWEyVjBYM04wWVhSMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkwTlMweU5EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOXRZWEpyWlhSZmMzUmhkSFZ6S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCaGNtTTBMbFIxY0d4bFcyRnlZelF1UW05dmJDd2dZWEpqTkM1Q2IyOXNYVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalE0Q2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU5Ea0tJQ0FnSUM4dklIQnZiMnh6WDJKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YldGeWEyVjBYM0J5WldacGVDQXJJR0lpY0c5dmJITWlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qVXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHOXZiSE5mWW05NExteGxibWQwYUNBK0lEQXNJQ0pOWVhKclpYUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJDYjNoU1pXWWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOVElLSUNBZ0lDOHZJSEJ2YjJ4elgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCd2IyOXNjMTlpYjNndWJXRjVZbVVvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOVFFLSUNBZ0lDOHZJR2x6WDNKbGMyOXNkbVZrWDNaaGJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTkRBcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRd0lDOHZJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qVTFDaUFnSUNBdkx5QjNhVzV1YVc1blgyOTFkR052YldWZmRtRnNJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnME9Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEUTRJQzh2SURRNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalU0Q2lBZ0lDQXZMeUJoY21NMExrSnZiMndvYVhOZmNtVnpiMngyWldSZmRtRnNJRDA5SUZWSmJuUTJOQ2d4S1Nrc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUdGeVl6UXVRbTl2YkNoM2FXNXVhVzVuWDI5MWRHTnZiV1ZmZG1Gc0lEMDlJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTFOeTB5TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtKdmIyd29hWE5mY21WemIyeDJaV1JmZG1Gc0lEMDlJRlZKYm5RMk5DZ3hLU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVDYjI5c0tIZHBibTVwYm1kZmIzVjBZMjl0WlY5MllXd2dQVDBnVlVsdWREWTBLREVwS1FvZ0lDQWdMeThnS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sS0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtTmhiR04xYkdGMFpWOTVaWE5mY0hKcFkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TmpJdE1qWXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCallXeGpkV3hoZEdWZmVXVnpYM0J5YVdObEtITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJMk5Rb2dJQ0FnTHk4Z2NHOXZiSE1nUFNCelpXeG1MbWRsZEY5dFlYSnJaWFJmY0c5dmJITW9iV0Z5YTJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRZWEpyWlhSZmNHOXZiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJMk5nb2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQndiMjlzYzFzd1hTNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU5qY0tJQ0FnSUM4dklHNXZYM0J2YjJ3Z1BTQndiMjlzYzFzeFhTNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOamt0TWpjeENpQWdJQ0F2THlBaklFTnZibk4wWVc1MElIQnliMlIxWTNRZ1FVMU5PaUI1WlhOZmNISnBZMlVnUFNCdWIxOXdiMjlzSUM4Z0tIbGxjMTl3YjI5c0lDc2dibTlmY0c5dmJDa0tJQ0FnSUM4dklDTWdVMk5oYkdWa0lHSjVJREV3TURBZ1ptOXlJSEJ5WldOcGMybHZiaUFvTlRBbElEMGdOVEF3TENBNU9TVWdQU0E1T1RBcENpQWdJQ0F2THlCMGIzUmhiRjlzYVhGMWFXUnBkSGtnUFNCNVpYTmZjRzl2YkNBcklHNXZYM0J2YjJ3S0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpjekNpQWdJQ0F2THlCcFppQjBiM1JoYkY5c2FYRjFhV1JwZEhrZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJR05oYkdOMWJHRjBaVjk1WlhOZmNISnBZMlZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TnpRS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9OVEF3S1NBZ0l5QkVaV1poZFd4MElEVXdKUW9nSUNBZ2NIVnphR2x1ZENBMU1EQWdMeThnTlRBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tZMkZzWTNWc1lYUmxYM2xsYzE5d2NtbGpaVjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TnpZS0lDQWdJQzh2SUhsbGMxOXdjbWxqWlNBOUlDaHViMTl3YjI5c0lDb2dWVWx1ZERZMEtERXdNREFwS1NBdkx5QjBiM1JoYkY5c2FYRjFhV1JwZEhrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TUFvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTNOd29nSUNBZ0x5OGdjbVYwZFhKdUlIbGxjMTl3Y21salpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WW5WNVgzbGxjMTl6YUdGeVpYTW9iV0Z5YTJWMFgybGtPaUIxYVc1ME5qUXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BpZFhsZmVXVnpYM05vWVhKbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkzT1MweU9EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdKMWVWOTVaWE5mYzJoaGNtVnpLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnYldGeWEyVjBYMmxrT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRzQ2lBZ0lDQXZMeUFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWprekxUSTVOQW9nSUNBZ0x5OGdJeUJEYUdWamF5QnRZWEpyWlhRZ1pYaHBjM1J6SUdGdVpDQm5aWFFnWkdGMFlRb2dJQ0FnTHk4Z2JXRnlhMlYwWDNCeVpXWnBlQ0E5SUdJaWJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakk1TlFvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95T1RZS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjI5c2MxOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJNU9Bb2dJQ0FnTHk4Z2NHOXZiSE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSEJ2YjJ4elgySnZlQzV0WVhsaVpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpBd0xUTXdNUW9nSUNBZ0x5OGdJeUJGZUhSeVlXTjBJR04xY25KbGJuUWdjM1JoZEdVS0lDQWdJQzh2SUhsbGMxOXdiMjlzSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3dLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1ESUtJQ0FnSUM4dklHNXZYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRGdwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekF6Q2lBZ0lDQXZMeUIwYjNSaGJGOTJiMngxYldVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREUyS1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFMklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16QTBDaUFnSUNBdkx5Qm1aV1ZmY21GMFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTWpRcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qUWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNRFVLSUNBZ0lDOHZJSEpsYzI5c2RYUnBiMjVmZEdsdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTXpJcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNRFlLSUNBZ0lDOHZJR2x6WDNKbGMyOXNkbVZrSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZzBNQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0EwTUNBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNd09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdselgzSmxjMjlzZG1Wa0lEMDlJRlZKYm5RMk5DZ3dLU3dnSWtWU1VrOVNYekl3TVRvZ1RXRnlhMlYwSUdseklISmxjMjlzZG1Wa0lnb2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1qQXhPaUJOWVhKclpYUWdhWE1nY21WemIyeDJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNd09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRHdnY21WemIyeDFkR2x2Ymw5MGFXMWxMQ0FpUlZKU1QxSmZNakF5T2lCVWNtRmthVzVuSUdWdVpHVmtJZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh5TURJNklGUnlZV1JwYm1jZ1pXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNeE1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSkZVbEpQVWw4eU1ETTZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dZWEJ3SUdOaGJHd2djMlZ1WkdWeUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTWpBek9pQlFZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lHRndjQ0JqWVd4c0lITmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16RXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlSVkpTVDFKZk1qQTBPaUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1EUTZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpFeUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzVoYlc5MWJuUWdQaUF3TENBaVJWSlNUMUpmTWpBMU9pQlFZWGx0Wlc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1qQTFPaUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak14TXdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJRlZKYm5RMk5DZ3hNREF3S1N3Z0lrVlNVazlTWHpJd05qb2dUV2x1YVcxMWJTQjBjbUZrWlNCaGJXOTFiblFnYVhNZ01UQXdNQ0J0YVdOeWIwRk1SMDl6SWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TUFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1EWTZJRTFwYm1sdGRXMGdkSEpoWkdVZ1lXMXZkVzUwSUdseklERXdNREFnYldsamNtOUJURWRQY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16RTFMVE14TmdvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2NHeGhkR1p2Y20wZ1ptVmxDaUFnSUNBdkx5Qm1aV1ZmWVcxdmRXNTBJRDBnS0hCaGVXMWxiblF1WVcxdmRXNTBJQ29nWm1WbFgzSmhkR1VwSUM4dklGVkpiblEyTkNneE1GOHdNREFwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpJRFlnTHk4Z01UQXdNREFLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak14TndvZ0lDQWdMeThnZEhKaFpHVmZZVzF2ZFc1MElEMGdjR0Y1YldWdWRDNWhiVzkxYm5RZ0xTQm1aV1ZmWVcxdmRXNTBDaUFnSUNCa2RYQXlDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNVGt0TXpJd0NpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQnphR0Z5WlhNZ2RYTnBibWNnWTI5dWMzUmhiblFnY0hKdlpIVmpkQ0JtYjNKdGRXeGhDaUFnSUNBdkx5QnphR0Z5WlhOZmNtVmpaV2wyWldRZ1BTQW9kSEpoWkdWZllXMXZkVzUwSUNvZ2JtOWZjRzl2YkNrZ0x5OGdLSGxsYzE5d2IyOXNJQ3NnZEhKaFpHVmZZVzF2ZFc1MEtRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZDaUFnSUNCamIzWmxjaUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16STBDaUFnSUNBdkx5QnVaWGRmZEc5MFlXeGZkbTlzZFcxbElEMGdkRzkwWVd4ZmRtOXNkVzFsSUNzZ2NHRjViV1Z1ZEM1aGJXOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TWpZdE16STNDaUFnSUNBdkx5QWpJRk4wYjNKbElIVndaR0YwWldRZ1pHRjBZUW9nSUNBZ0x5OGdkMmx1Ym1sdVoxOXZkWFJqYjIxbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2cwT0Nrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSEIxYzJocGJuUWdORGdnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TWprS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzbGxjMTl3YjI5c0tTQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXpNQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXlPUzB6TXpBS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpNeENpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpJNUxUTXpNUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmZVdWelgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm05ZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmRHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXpNZ29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNamt0TXpNeUNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTkwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpNekNpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TWprdE16TXpDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTk1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1YjE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5MGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtTQXJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNek5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGMxOXlaWE52YkhabFpDa2dLd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNamt0TXpNMENpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTkwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dselgzSmxjMjlzZG1Wa0tTQXJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNek5Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloM2FXNXVhVzVuWDI5MWRHTnZiV1VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1qa3RNek0xQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5NVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodWIxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WemIyeDFkR2x2Ymw5MGFXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x6WDNKbGMyOXNkbVZrS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hkcGJtNXBibWRmYjNWMFkyOXRaU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16TTNDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ3VjSFYwS0c1bGQxOXdiMjlzYzE5a1lYUmhLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TXpnS0lDQWdJQzh2SUhObGJHWXVjR3hoZEdadmNtMWZabVZsY3k1MllXeDFaU0FyUFNCbVpXVmZZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0d4aGRHWnZjbTFmWm1WbGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3YkdGMFptOXliVjltWldWeklHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV01nTmlBdkx5QWljR3hoZEdadmNtMWZabVZsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pOREF0TXpReENpQWdJQ0F2THlBaklGUnlZV05ySUhWelpYSWdXV1Z6SUhOb1lYSmxjd29nSUNBZ0x5OGdkWE5sY2w5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnWWlKZmJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw5NVpYTWlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlRGMxTnpNMk5UY3lOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGcxWmpaa05qRTNNalppTmpVM05EVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UTWdMeThnTUhnMVpqYzVOalUzTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTBOQW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOXphR0Z5WlhNZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pORFVLSUNBZ0lDOHZJR2xtSUhWelpYSmZjMmhoY21WelgySnZlQzVzWlc1bmRHZ2dQaUF3T2dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0o2SUdKMWVWOTVaWE5mYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelEyQ2lBZ0lDQXZMeUJsZUdsemRHbHVaMTl6YUdGeVpYTmZaR0YwWVN3Z1gyVjRhWE4wY3lBOUlIVnpaWEpmYzJoaGNtVnpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5EY0tJQ0FnSUM4dklHTjFjbkpsYm5SZmMyaGhjbVZ6SUQwZ2IzQXVZblJ2YVNobGVHbHpkR2x1WjE5emFHRnlaWE5mWkdGMFlTa0tJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0tZblY1WDNsbGMxOXphR0Z5WlhOZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16UTVDaUFnSUNBdkx5QjFjMlZ5WDNOb1lYSmxjMTlpYjNndWNIVjBLRzl3TG1sMGIySW9ZM1Z5Y21WdWRGOXphR0Z5WlhNZ0t5QnphR0Z5WlhOZmNtVmpaV2wyWldRcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5URUtJQ0FnSUM4dklISmxkSFZ5YmlCemFHRnlaWE5mY21WalpXbDJaV1FLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtSjFlVjl1YjE5emFHRnlaWE1vYldGeWEyVjBYMmxrT2lCMWFXNTBOalFzSUhCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwaWRYbGZibTlmYzJoaGNtVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpVekxUTTFPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1luVjVYMjV2WDNOb1lYSmxjeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMk1DMHpOakVLSUNBZ0lDOHZJQ01nUTJobFkyc2diV0Z5YTJWMElHVjRhWE4wY3lCaGJtUWdaMlYwSUdSaGRHRUtJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMVpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TmpJS0lDQWdJQzh2SUhCdmIyeHpYMkp2ZUNBOUlFSnZlRkpsWmloclpYazliV0Z5YTJWMFgzQnlaV1pwZUNBcklHSWljRzl2YkhNaUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEY3dObVkyWmpaak56TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpZekNpQWdJQ0F2THlCaGMzTmxjblFnY0c5dmJITmZZbTk0TG14bGJtZDBhQ0ErSURBc0lDSk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5qVUtJQ0FnSUM4dklIQnZiMnh6WDJSaGRHRXNJRjlsZUdsemRITWdQU0J3YjI5c2MxOWliM2d1YldGNVltVW9LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMk55MHpOamdLSUNBZ0lDOHZJQ01nUlhoMGNtRmpkQ0JqZFhKeVpXNTBJSE4wWVhSbENpQWdJQ0F2THlCNVpYTmZjRzl2YkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16WTVDaUFnSUNBdkx5QnViMTl3YjI5c0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2c0S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zTUFvZ0lDQWdMeThnZEc5MFlXeGZkbTlzZFcxbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d4Tmlrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeE5pQXZMeUF4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTNNUW9nSUNBZ0x5OGdabVZsWDNKaGRHVWdQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RJMEtTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElESTBJQzh2SURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemN5Q2lBZ0lDQXZMeUJ5WlhOdmJIVjBhVzl1WDNScGJXVWdQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RNeUtTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemN6Q2lBZ0lDQXZMeUJwYzE5eVpYTnZiSFpsWkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9OREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTkRBZ0x5OGdOREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56VUtJQ0FnSUM4dklHRnpjMlZ5ZENCcGMxOXlaWE52YkhabFpDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKRlVsSlBVbDh5TURFNklFMWhjbXRsZENCcGN5QnlaWE52YkhabFpDSUtJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6SXdNVG9nVFdGeWEyVjBJR2x6SUhKbGMyOXNkbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56WUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0E4SUhKbGMyOXNkWFJwYjI1ZmRHbHRaU3dnSWtWU1VrOVNYekl3TWpvZ1ZISmhaR2x1WnlCbGJtUmxaQ0lLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTWpBeU9pQlVjbUZrYVc1bklHVnVaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUxDQWlSVkpTVDFKZk1qQXpPaUJRWVhsdFpXNTBJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JR0Z3Y0NCallXeHNJSE5sYm1SbGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd016b2dVR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQmhjSEFnWTJGc2JDQnpaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTNPQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJa1ZTVWs5U1h6SXdORG9nVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdOdmJuUnlZV04wSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1qQTBPaUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDRnTUN3Z0lrVlNVazlTWHpJd05Ub2dVR0Y1YldWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6SXdOVG9nVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96T0RBS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStQU0JWU1c1ME5qUW9NVEF3TUNrc0lDSkZVbEpQVWw4eU1EWTZJRTFwYm1sdGRXMGdkSEpoWkdVZ1lXMXZkVzUwSUdseklERXdNREFnYldsamNtOUJURWRQY3lJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREV3TURBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1qQTJPaUJOYVc1cGJYVnRJSFJ5WVdSbElHRnRiM1Z1ZENCcGN5QXhNREF3SUcxcFkzSnZRVXhIVDNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTRNaTB6T0RNS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElIQnNZWFJtYjNKdElHWmxaUW9nSUNBZ0x5OGdabVZsWDJGdGIzVnVkQ0E5SUNod1lYbHRaVzUwTG1GdGIzVnVkQ0FxSUdabFpWOXlZWFJsS1NBdkx5QlZTVzUwTmpRb01UQmZNREF3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZeUEySUM4dklERXdNREF3Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96T0RRS0lDQWdJQzh2SUhSeVlXUmxYMkZ0YjNWdWRDQTlJSEJoZVcxbGJuUXVZVzF2ZFc1MElDMGdabVZsWDJGdGIzVnVkQW9nSUNBZ1pIVndNZ29nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemcyTFRNNE53b2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdjMmhoY21WeklIVnphVzVuSUdOdmJuTjBZVzUwSUhCeWIyUjFZM1FnWm05eWJYVnNZUW9nSUNBZ0x5OGdjMmhoY21WelgzSmxZMlZwZG1Wa0lEMGdLSFJ5WVdSbFgyRnRiM1Z1ZENBcUlIbGxjMTl3YjI5c0tTQXZMeUFvYm05ZmNHOXZiQ0FySUhSeVlXUmxYMkZ0YjNWdWRDa0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEa0tJQ0FnSUNvS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMd29nSUNBZ1kyOTJaWElnTVRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVNUW9nSUNBZ0x5OGdibVYzWDNSdmRHRnNYM1p2YkhWdFpTQTlJSFJ2ZEdGc1gzWnZiSFZ0WlNBcklIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprekxUTTVOQW9nSUNBZ0x5OGdJeUJUZEc5eVpTQjFjR1JoZEdWa0lHUmhkR0VLSUNBZ0lDOHZJSGRwYm01cGJtZGZiM1YwWTI5dFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTkRncExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0J3ZFhOb2FXNTBJRFE0SUM4dklEUTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprMkNpQWdJQ0F2THlCdmNDNXBkRzlpS0hsbGMxOXdiMjlzS1NBckNpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNNU53b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZibTlmY0c5dmJDa2dLd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pPVFl0TXprM0NpQWdJQ0F2THlCdmNDNXBkRzlpS0hsbGMxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOXViMTl3YjI5c0tTQXJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNNU9Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZkRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNNU5pMHpPVGdLSUNBZ0lDOHZJRzl3TG1sMGIySW9lV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDI1dlgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pPVGtLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemsyTFRNNU9Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZibTlmY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmZEc5MFlXeGZkbTlzZFcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRd01Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprMkxUUXdNQW9nSUNBZ0x5OGdiM0F1YVhSdllpaDVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmYm05ZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmRHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1ERUtJQ0FnSUM4dklHOXdMbWwwYjJJb2FYTmZjbVZ6YjJ4MlpXUXBJQ3NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemsyTFRRd01Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZibTlmY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmZEc5MFlXeGZkbTlzZFcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGMxOXlaWE52YkhabFpDa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1ESUtJQ0FnSUM4dklHOXdMbWwwYjJJb2QybHVibWx1WjE5dmRYUmpiMjFsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16azJMVFF3TWdvZ0lDQWdMeThnYjNBdWFYUnZZaWg1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmJtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZkRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYzE5eVpYTnZiSFpsWkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWloM2FXNXVhVzVuWDI5MWRHTnZiV1VwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXdOQW9nSUNBZ0x5OGdjRzl2YkhOZlltOTRMbkIxZENodVpYZGZjRzl2YkhOZlpHRjBZU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRBMUNpQWdJQ0F2THlCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNdWRtRnNkV1VnS3owZ1ptVmxYMkZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5Cc1lYUm1iM0p0WDJabFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5QmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREEzTFRRd09Bb2dJQ0FnTHk4Z0l5QlVjbUZqYXlCMWMyVnlJRTV2SUhOb1lYSmxjd29nSUNBZ0x5OGdkWE5sY2w5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnWWlKZmJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw5dWJ5SUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjROelUzTXpZMU56STFaZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlRFZtTm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUF3ZURWbU5tVTJaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReE1Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emFHRnlaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1USUtJQ0FnSUM4dklHbG1JSFZ6WlhKZmMyaGhjbVZ6WDJKdmVDNXNaVzVuZEdnZ1BpQXdPZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHSjZJR0oxZVY5dWIxOXphR0Z5WlhOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1UTUtJQ0FnSUM4dklHVjRhWE4wYVc1blgzTm9ZWEpsYzE5a1lYUmhMQ0JmWlhocGMzUnpJRDBnZFhObGNsOXphR0Z5WlhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF4TkFvZ0lDQWdMeThnWTNWeWNtVnVkRjl6YUdGeVpYTWdQU0J2Y0M1aWRHOXBLR1Y0YVhOMGFXNW5YM05vWVhKbGMxOWtZWFJoS1FvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dwaWRYbGZibTlmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF4TmdvZ0lDQWdMeThnZFhObGNsOXphR0Z5WlhOZlltOTRMbkIxZENodmNDNXBkRzlpS0dOMWNuSmxiblJmYzJoaGNtVnpJQ3NnYzJoaGNtVnpYM0psWTJWcGRtVmtLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMmhoY21WelgzSmxZMlZwZG1Wa0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzV5WlhOdmJIWmxYMjFoY210bGRDaHRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Dd2dlV1Z6WDNkcGJuTTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHlaWE52YkhabFgyMWhjbXRsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXlNQzAwTWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSEpsYzI5c2RtVmZiV0Z5YTJWMEtITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwTENCNVpYTmZkMmx1Y3pvZ1lYSmpOQzVDYjI5c0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SUdOaGJpQnlaWE52YkhabElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCeVpYTnZiSFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1qVUtJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF5TmdvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTWpjS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjI5c2MxOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReU9Rb2dJQ0FnTHk4Z2NHOXZiSE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSEJ2YjJ4elgySnZlQzV0WVhsaVpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRNeExUUXpNZ29nSUNBZ0x5OGdJeUJGZUhSeVlXTjBJR04xY25KbGJuUWdjM1JoZEdVS0lDQWdJQzh2SUhsbGMxOXdiMjlzSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3dLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME16TUtJQ0FnSUM4dklHNXZYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRGdwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORE0wQ2lBZ0lDQXZMeUIwYjNSaGJGOTJiMngxYldVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREUyS1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFMklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ETTFDaUFnSUNBdkx5Qm1aV1ZmY21GMFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTWpRcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qUWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNellLSUNBZ0lDOHZJSEpsYzI5c2RYUnBiMjVmZEdsdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTXpJcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNemNLSUNBZ0lDOHZJR2x6WDNKbGMyOXNkbVZrSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZzBNQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIQjFjMmhwYm5RZ05EQWdMeThnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjMTl5WlhOdmJIWmxaQ0E5UFNCVlNXNTBOalFvTUNrc0lDSkJiSEpsWVdSNUlISmxjMjlzZG1Wa0lnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2djbVZ6YjJ4MlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEwTUFvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSEpsYzI5c2RYUnBiMjVmZEdsdFpTd2dJbFJ2YnlCbFlYSnNlU0IwYnlCeVpYTnZiSFpsSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURFS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWRzl2SUdWaGNteDVJSFJ2SUhKbGMyOXNkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRME5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME5EVUtJQ0FnSUM4dklHOXdMbWwwYjJJb2JtOWZjRzl2YkNrZ0t3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME5EUXRORFExQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSGxsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EUTJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTkRRdE5EUTJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2RHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTBOd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBORFF0TkRRM0NpQWdJQ0F2THlCdmNDNXBkRzlpS0hsbGMxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1dlgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvZEc5MFlXeGZkbTlzZFcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRME9Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTBOQzAwTkRnS0lDQWdJQzh2SUc5d0xtbDBiMklvZVdWelgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm05ZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWgwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBckNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEwT1FvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NU2twSUNzZ0lDTWdhWE5mY21WemIyeDJaV1FnUFNCVWNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFEwTFRRME9Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodWIxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RFcEtTQXJJQ0FqSUdselgzSmxjMjlzZG1Wa0lEMGdWSEoxWlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOVEFLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtERXBJR2xtSUhsbGMxOTNhVzV6TG01aGRHbDJaU0JsYkhObElGVkpiblEyTkNnd0tTa2dJQ01nZDJsdWJtbHVaMTl2ZFhSamIyMWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEwTkMwME5UQUtJQ0FnSUM4dklHOXdMbWwwYjJJb2VXVnpYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWloMGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNneEtTa2dLeUFnSXlCcGMxOXlaWE52YkhabFpDQTlJRlJ5ZFdVS0lDQWdJQzh2SUc5d0xtbDBiMklvVlVsdWREWTBLREVwSUdsbUlIbGxjMTkzYVc1ekxtNWhkR2wyWlNCbGJITmxJRlZKYm5RMk5DZ3dLU2tnSUNNZ2QybHVibWx1WjE5dmRYUmpiMjFsQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTFNZ29nSUNBZ0x5OGdjRzl2YkhOZlltOTRMbkIxZENodVpYZGZjRzl2YkhOZlpHRjBZU2tLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVuWlhSZmRHOTBZV3hmYldGeWEyVjBjeWdwSUMwK0lIVnBiblEyTkRvS1oyVjBYM1J2ZEdGc1gyMWhjbXRsZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVaMlYwWDNCc1lYUm1iM0p0WDJabFpYTW9LU0F0UGlCMWFXNTBOalE2Q21kbGRGOXdiR0YwWm05eWJWOW1aV1Z6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EWXlDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV3YkdGMFptOXliVjltWldWekxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR3hoZEdadmNtMWZabVZsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdiR0YwWm05eWJWOW1aV1Z6SUdWNGFYTjBjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExuZHBkR2hrY21GM1gyWmxaWE1vS1NBdFBpQjFhVzUwTmpRNkNuZHBkR2hrY21GM1gyWmxaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SUdOaGJpQjNhWFJvWkhKaGR5SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiaUJqWVc0Z2QybDBhR1J5WVhjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTJPUW9nSUNBZ0x5OGdabVZsYzE5MGIxOTNhWFJvWkhKaGR5QTlJSE5sYkdZdWNHeGhkR1p2Y20xZlptVmxjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5Cc1lYUm1iM0p0WDJabFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5QmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTNNQW9nSUNBZ0x5OGdZWE56WlhKMElHWmxaWE5mZEc5ZmQybDBhR1J5WVhjZ1BpQXdMQ0FpVG04Z1ptVmxjeUIwYnlCM2FYUm9aSEpoZHlJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUdabFpYTWdkRzhnZDJsMGFHUnlZWGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRM01nb2dJQ0FnTHk4Z2MyVnNaaTV3YkdGMFptOXliVjltWldWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd2JHRjBabTl5YlY5bVpXVnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTnpRdE5EYzRDaUFnSUNBdkx5QWpJRk5sYm1RZ2NHRjViV1Z1ZENCMGJ5QmhaRzFwYmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdabFpYTmZkRzlmZDJsMGFHUnlZWGNzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTnpZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTNOQzAwTnpVS0lDQWdJQzh2SUNNZ1UyVnVaQ0J3WVhsdFpXNTBJSFJ2SUdGa2JXbHVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEzTkMwME56Z0tJQ0FnSUM4dklDTWdVMlZ1WkNCd1lYbHRaVzUwSUhSdklHRmtiV2x1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Wm1WbGMxOTBiMTkzYVhSb1pISmhkeXdLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT0RBS0lDQWdJQzh2SUhKbGRIVnliaUJtWldWelgzUnZYM2RwZEdoa2NtRjNDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYM1Z6WlhKZmMyaGhjbVZ6S0hWelpYSTZJR0o1ZEdWekxDQnRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEY5MWMyVnlYM05vWVhKbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalE0TWkwME9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOTFjMlZ5WDNOb1lYSmxjeWh6Wld4bUxDQjFjMlZ5T2lCQlkyTnZkVzUwTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdZWEpqTkM1VWRYQnNaVnRoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME9EVXRORGcyQ2lBZ0lDQXZMeUFqSUVkbGRDQlpaWE1nYzJoaGNtVnpDaUFnSUNBdkx5QjVaWE5mYzJoaGNtVnpYMnRsZVNBOUlHSWlkWE5sY2w4aUlDc2dkWE5sY2k1aWVYUmxjeUFySUdJaVgyMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZmVXVnpJZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGczTlRjek5qVTNNalZtQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhnMVpqWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklERXpJQzh2SURCNE5XWTNPVFkxTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPRGtLSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME9UQUtJQ0FnSUM4dklHbG1JSGxsYzE5emFHRnlaWE5mWW05NExteGxibWQwYUNBK0lEQTZDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRVbVZtSUdWNGFYTjBjd29nSUNBZ1lub2daMlYwWDNWelpYSmZjMmhoY21WelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Ea3hDaUFnSUNBdkx5QjVaWE5mYzJoaGNtVnpYMlJoZEdFc0lGOWxlR2x6ZEhNZ1BTQjVaWE5mYzJoaGNtVnpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME9USUtJQ0FnSUM4dklIbGxjMTl6YUdGeVpYTWdQU0J2Y0M1aWRHOXBLSGxsYzE5emFHRnlaWE5mWkdGMFlTa0tJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb0taMlYwWDNWelpYSmZjMmhoY21WelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTVOQzAwT1RVS0lDQWdJQzh2SUNNZ1IyVjBJRTV2SUhOb1lYSmxjd29nSUNBZ0x5OGdibTlmYzJoaGNtVnpYMnRsZVNBOUlHSWlkWE5sY2w4aUlDc2dkWE5sY2k1aWVYUmxjeUFySUdJaVgyMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZmJtOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZzFaalpsTm1ZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTVPQW9nSUNBZ0x5OGdibTlmYzJoaGNtVnpJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT1RrS0lDQWdJQzh2SUdsbUlHNXZYM05vWVhKbGMxOWliM2d1YkdWdVozUm9JRDRnTURvS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJDYjNoU1pXWWdaWGhwYzNSekNpQWdJQ0JpZWlCblpYUmZkWE5sY2w5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTURBS0lDQWdJQzh2SUc1dlgzTm9ZWEpsYzE5a1lYUmhMQ0JmWlhocGMzUnpJRDBnYm05ZmMyaGhjbVZ6WDJKdmVDNXRZWGxpWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNREVLSUNBZ0lDOHZJRzV2WDNOb1lYSmxjeUE5SUc5d0xtSjBiMmtvYm05ZmMyaGhjbVZ6WDJSaGRHRXBDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbWRsZEY5MWMyVnlYM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNoNVpYTmZjMmhoY21WektTd2dZWEpqTkM1VlNXNTBOalFvYm05ZmMyaGhjbVZ6S1NrcENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNuSmxaR1ZsYlY5M2FXNXVhVzVuWDNOb1lYSmxjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVd05TMDFNRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxaR1ZsYlY5M2FXNXVhVzVuWDNOb1lYSmxjeWh6Wld4bUxDQnRZWEpyWlhSZmFXUTZJRlZKYm5RMk5Da2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1EZ3ROVEE1Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJRzFoY210bGRDQmxlR2x6ZEhNZ1lXNWtJR2x6SUhKbGMyOXNkbVZrQ2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVeE1Bb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekEyWmpabU5tTTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IyOXNjMTlpYjNndWJHVnVaM1JvSUQ0Z01Dd2dJazFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhKclpYUWdaRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXhNd29nSUNBZ0x5OGdjRzl2YkhOZlpHRjBZU3dnWDJWNGFYTjBjeUE5SUhCdmIyeHpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXhOQW9nSUNBZ0x5OGdhWE5mY21WemIyeDJaV1FnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEUXdLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNQ0F2THlBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV4TlFvZ0lDQWdMeThnZDJsdWJtbHVaMTl2ZFhSamIyMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnME9Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEUTRJQzh2SURRNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVEUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdhWE5mY21WemIyeDJaV1FnUFQwZ1ZVbHVkRFkwS0RFcExDQWlUV0Z5YTJWMElHNXZkQ0J5WlhOdmJIWmxaQ0I1WlhRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ2JtOTBJSEpsYzI5c2RtVmtJSGxsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5URTVMVFV5TUFvZ0lDQWdMeThnSXlCSFpYUWdkWE5sY2lkeklITm9ZWEpsY3dvZ0lDQWdMeThnZFhObGNsOXphR0Z5WlhNZ1BTQnpaV3htTG1kbGRGOTFjMlZ5WDNOb1lYSmxjeWhVZUc0dWMyVnVaR1Z5TENCdFlYSnJaWFJmYVdRcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM1Z6WlhKZmMyaGhjbVZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1qRUtJQ0FnSUM4dklIbGxjMTl6YUdGeVpYTWdQU0IxYzJWeVgzTm9ZWEpsYzFzd1hTNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNaklLSUNBZ0lDOHZJRzV2WDNOb1lYSmxjeUE5SUhWelpYSmZjMmhoY21Weld6RmRMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTWpZS0lDQWdJQzh2SUdsbUlIZHBibTVwYm1kZmIzVjBZMjl0WlNBOVBTQlZTVzUwTmpRb01TazZJQ0FqSUZsbGN5QjNiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1qZ3ROVEk1Q2lBZ0lDQXZMeUFqSUVOc1pXRnlJRmxsY3lCemFHRnlaWE1LSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnWWlKZmJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw5NVpYTWlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlRGMxTnpNMk5UY3lOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGcxWmpaa05qRTNNalppTmpVM05EVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UTWdMeThnTUhnMVpqYzVOalUzTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UTXhDaUFnSUNBdkx5QnBaaUI1WlhOZmMyaGhjbVZ6WDJKdmVDNXNaVzVuZEdnZ1BpQXdPZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHSjZJSEpsWkdWbGJWOTNhVzV1YVc1blgzTm9ZWEpsYzE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVek1nb2dJQ0FnTHk4Z2VXVnpYM05vWVhKbGMxOWliM2d1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ25KbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvS2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUwTVFvZ0lDQWdMeThnWVhOelpYSjBJSGRwYm01cGJtZGZjMmhoY21WeklENGdWVWx1ZERZMEtEQXBMQ0FpVG04Z2QybHVibWx1WnlCemFHRnlaWE1nZEc4Z2NtVmtaV1Z0SWdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnZDJsdWJtbHVaeUJ6YUdGeVpYTWdkRzhnY21Wa1pXVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTkRZdE5UUTVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1YjNWMFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVME53b2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFEyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVME5pMDFORGtLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTFNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIQmhlVzkxZEY5aGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dweVpXUmxaVzFmZDJsdWJtbHVaMTl6YUdGeVpYTmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU16VXROVE0yQ2lBZ0lDQXZMeUFqSUVOc1pXRnlJRTV2SUhOb1lYSmxjd29nSUNBZ0x5OGdibTlmYzJoaGNtVnpYMnRsZVNBOUlHSWlkWE5sY2w4aUlDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QXJJR0lpWDIxaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmYm04aUNpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEYzFOek0yTlRjeU5XWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZzFaalprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGcxWmpabE5tWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV6T0FvZ0lDQWdMeThnYVdZZ2JtOWZjMmhoY21WelgySnZlQzVzWlc1bmRHZ2dQaUF3T2dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0o2SUhKbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXpPUW9nSUNBZ0x5OGdibTlmYzJoaGNtVnpYMkp2ZUM1a1pXeGxkR1VvS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvS2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpSUhKbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVaMlYwWDJOdmJuUnlZV04wWDJSbFluVm5YMmx1Wm04b0tTQXRQaUJpZVhSbGN6b0taMlYwWDJOdmJuUnlZV04wWDJSbFluVm5YMmx1Wm04NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOVGtLSUNBZ0lDOHZJR0Z5WXpRdVFXUmtjbVZ6Y3loelpXeG1MbUZrYldsdUxuWmhiSFZsTG1KNWRHVnpLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOakFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3k1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRZeENpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5Cc1lYUm1iM0p0WDJabFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTJNZ29nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXRhVzVmYkdseGRXbGthWFI1TG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUxT0MwMU5qTUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb2MyVnNaaTVoWkcxcGJpNTJZV3gxWlM1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlUzUyWVd4MVpTa0tJQ0FnSUM4dklDa3BDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVhWE5mWTI5dWRISmhZM1JmYVc1cGRHbGhiR2w2WldRb0tTQXRQaUJpZVhSbGN6b0thWE5mWTI5dWRISmhZM1JmYVc1cGRHbGhiR2w2WldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOamdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29jMlZzWmk1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lBaFBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMbUo1ZEdWektRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1blpYUmZZMjl1ZEhKaFkzUmZjM1JoZEhWektDa2dMVDRnWW5sMFpYTTZDbWRsZEY5amIyNTBjbUZqZEY5emRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU56QXROVGN4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmWTI5dWRISmhZM1JmYzNSaGRIVnpLSE5sYkdZcElDMCtJR0Z5WXpRdVZIVndiR1ZiWVhKak5DNUNiMjlzTENCaGNtTTBMa0ZrWkhKbGMzTXNJR0Z5WXpRdVZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRjekNpQWdJQ0F2THlCcGMxOXBibWwwSUQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlM1aWVYUmxjeUFoUFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOelVLSUNBZ0lDOHZJR0Z5WXpRdVFtOXZiQ2hwYzE5cGJtbDBLU3dLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTNOZ29nSUNBZ0x5OGdZWEpqTkM1QlpHUnlaWE56S0hObGJHWXVZV1J0YVc0dWRtRnNkV1V1WW5sMFpYTWdhV1lnYVhOZmFXNXBkQ0JsYkhObElFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXVZbmwwWlhNcExBb2dJQ0FnWW5vZ1oyVjBYMk52Ym5SeVlXTjBYM04wWVhSMWMxOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0NtZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGRYTmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGMyQ2lBZ0lDQXZMeUJoY21NMExrRmtaSEpsYzNNb2MyVnNaaTVoWkcxcGJpNTJZV3gxWlM1aWVYUmxjeUJwWmlCcGMxOXBibWwwSUdWc2MyVWdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeTVpZVhSbGN5a3NDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UYzNDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYldGeWEyVjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGMwTFRVM09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFtOXZiQ2hwYzE5cGJtbDBLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9jMlZzWmk1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lCcFppQnBjMTlwYm1sMElHVnNjMlVnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3k1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbEtRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEY5amIyNTBjbUZqZEY5emRHRjBkWE5mZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRjMkNpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9jMlZzWmk1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lCcFppQnBjMTlwYm1sMElHVnNjMlVnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3k1aWVYUmxjeWtzQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdJZ1oyVjBYMk52Ym5SeVlXTjBYM04wWVhSMWMxOTBaWEp1WVhKNVgyMWxjbWRsUURNS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE1vY1hWbGMzUnBiMjQ2SUdKNWRHVnpMQ0J5WlhOdmJIVjBhVzl1WDNScGJXVTZJSFZwYm5RMk5Dd2dabVZsWDNKaGRHVTZJSFZwYm5RMk5Dd2djR0Y1YldWdWRGOWhiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuWmhiR2xrWVhSbFgyTnlaV0YwWlY5dFlYSnJaWFJmY0dGeVlXMXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRnd0xUVTROd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2RtRnNhV1JoZEdWZlkzSmxZWFJsWDIxaGNtdGxkRjl3WVhKaGJYTW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J4ZFdWemRHbHZiam9nVTNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkWFJwYjI1ZmRHbHRaVG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpWOXlZWFJsT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZEY5aGJXOTFiblE2SUZWSmJuUTJOQW9nSUNBZ0x5OGdLU0F0UGlCaGNtTTBMa0p2YjJ3NkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNE9Rb2dJQ0FnTHk4Z2FXWWdabVZsWDNKaGRHVWdQaUJWU1c1ME5qUW9NVEF3TUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBd0NpQWdJQ0ErQ2lBZ0lDQmllaUIyWVd4cFpHRjBaVjlqY21WaGRHVmZiV0Z5YTJWMFgzQmhjbUZ0YzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TUFvZ0lDQWdjbVYwYzNWaUNncDJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xT1RFS0lDQWdJQzh2SUdsbUlIQmhlVzFsYm5SZllXMXZkVzUwSUR3Z0tITmxiR1l1YldsdVgyeHBjWFZwWkdsMGVTNTJZV3gxWlNBcUlGVkpiblEyTkNneUtTazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJXbHVYMnhwY1hWcFpHbDBlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQZ29nSUNBZ1lub2dkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xT1RJS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREFLSUNBZ0lISmxkSE4xWWdvS2RtRnNhV1JoZEdWZlkzSmxZWFJsWDIxaGNtdGxkRjl3WVhKaGJYTmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGt6Q2lBZ0lDQXZMeUJwWmlCeVpYTnZiSFYwYVc5dVgzUnBiV1VnUEQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnS3lCVlNXNTBOalFvTXpZd01DazZDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpJRFFnTHk4Z016WXdNQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0ErUFFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmWTNKbFlYUmxYMjFoY210bGRGOXdZWEpoYlhOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU9UUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBS0lDQWdJSEpsZEhOMVlnb0tkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrMUNpQWdJQ0F2THlCcFppQnlaWE52YkhWMGFXOXVYM1JwYldVZ1BpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklGVkpiblEyTkNnek1UVXpOakF3TUNrNkNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5SaklEVWdMeThnTXpFMU16WXdNREFLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUEFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmWTNKbFlYUmxYMjFoY210bGRGOXdZWEpoYlhOZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBS0lDQWdJSEpsZEhOMVlnb0tkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrM0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtTmhibDlqY21WaGRHVmZiV0Z5YTJWMEtITmxibVJsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwallXNWZZM0psWVhSbFgyMWhjbXRsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTVPUzAyTURBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR05oYmw5amNtVmhkR1ZmYldGeWEyVjBLSE5sYkdZc0lITmxibVJsY2pvZ1FXTmpiM1Z1ZENrZ0xUNGdZWEpqTkM1Q2IyOXNPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29jMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbWRsZEY5eVpYRjFhWEpsWkY5d1lYbHRaVzUwWDJadmNsOXRZWEpyWlhRb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5eVpYRjFhWEpsWkY5d1lYbHRaVzUwWDJadmNsOXRZWEpyWlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa3VkbUZzZFdVZ0tpQlZTVzUwTmpRb01pa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKdGFXNWZiR2x4ZFdsa2FYUjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbTFoY210bGRGOWxlR2x6ZEhNb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHRZWEpyWlhSZlpYaHBjM1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qQTVMVFl4TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdiV0Z5YTJWMFgyVjRhWE4wY3loelpXeG1MQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVDYjI5c09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1USUtJQ0FnSUM4dklHbG1JRzFoY210bGRGOXBaQ0ErUFNCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1U2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOFBRb2dJQ0FnWW5vZ2JXRnlhMlYwWDJWNGFYTjBjMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall4TXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwdFlYSnJaWFJmWlhocGMzUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall4TlFvZ0lDQWdMeThnYldGeWEyVjBYM0J5WldacGVDQTlJR0lpYldGeWEyVjBYeUlnS3lCdmNDNXBkRzlpS0cxaGNtdGxkRjlwWkNrZ0t5QmlJbDhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qRTJDaUFnSUNBdkx5QnhkV1Z6ZEdsdmJsOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluRjFaWE4wYVc5dUlpa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzNNVGMxTmpVM016YzBOamsyWmpabENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall4TndvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2h4ZFdWemRHbHZibDlpYjNndWJHVnVaM1JvSUQ0Z01Da0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG1kbGRGOXRZWEpyWlhSZlkzSmxZWFJ2Y2lodFlYSnJaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl0WVhKclpYUmZZM0psWVhSdmNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall4T1MwMk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOXRZWEpyWlhSZlkzSmxZWFJ2Y2loelpXeG1MQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1FXTmpiM1Z1ZERvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJeUNpQWdJQ0F2THlCaGMzTmxjblFnYldGeWEyVjBYMmxrSUR3Z2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsTENBaVRXRnlhMlYwSUVsRUlHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyMWhjbXRsZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3lCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JKUkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJMENpQWdJQ0F2THlCdFlYSnJaWFJmY0hKbFptbDRJRDBnWWlKdFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURaa05qRTNNalppTmpVM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcxWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNalVLSUNBZ0lDOHZJR055WldGMGIzSmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSmpjbVZoZEc5eUlpa0tJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjROak0zTWpZMU5qRTNORFptTnpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZM0psWVhSdmNsOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCamNtVmhkRzl5SUdSaGRHRWdibTkwSUdadmRXNWtJZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRVbVZtSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFMWhjbXRsZENCamNtVmhkRzl5SUdSaGRHRWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTWpnS0lDQWdJQzh2SUdOeVpXRjBiM0pmWW5sMFpYTXNJRjlsZUdsemRITWdQU0JqY21WaGRHOXlYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFRmpZMjkxYm5Rb1kzSmxZWFJ2Y2w5aWVYUmxjeWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1YzJsdGRXeGhkR1ZmZVdWelgzUnlZV1JsS0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwTENCd1lYbHRaVzUwWDJGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LYzJsdGRXeGhkR1ZmZVdWelgzUnlZV1JsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qTXhMVFl6TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjMmx0ZFd4aGRHVmZlV1Z6WDNSeVlXUmxLSE5sYkdZc0lHMWhjbXRsZEY5cFpEb2dWVWx1ZERZMExDQndZWGx0Wlc1MFgyRnRiM1Z1ZERvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5GMDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXpOQW9nSUNBZ0x5OGdZWE56WlhKMElHMWhjbXRsZEY5cFpDQThJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeTUyWVd4MVpTd2dJazFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCTllYSnJaWFFnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall6TmdvZ0lDQWdMeThnYldGeWEyVjBYM0J5WldacGVDQTlJR0lpYldGeWEyVjBYeUlnS3lCdmNDNXBkRzlpS0cxaGNtdGxkRjlwWkNrZ0t5QmlJbDhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qTTNDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFcxaGNtdGxkRjl3Y21WbWFYZ2dLeUJpSW5CdmIyeHpJaWtLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGczTURabU5tWTJZemN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXpPQW9nSUNBZ0x5OGdZWE56WlhKMElIQnZiMnh6WDJKdmVDNXNaVzVuZEdnZ1BpQXdMQ0FpVFdGeWEyVjBJR1JoZEdFZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JrWVhSaElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalF3Q2lBZ0lDQXZMeUJ3YjI5c2MxOWtZWFJoTENCZlpYaHBjM1J6SUQwZ2NHOXZiSE5mWW05NExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalF5Q2lBZ0lDQXZMeUI1WlhOZmNHOXZiQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb01Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpRekNpQWdJQ0F2THlCdWIxOXdiMjlzSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZzRLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTBOQW9nSUNBZ0x5OGdabVZsWDNKaGRHVWdQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RJMEtTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TkNBdkx5QXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZME5pMDJORGNLSUNBZ0lDOHZJQ01nUTJGc1kzVnNZWFJsSUhSeVlXUmxJSE5wYlhWc1lYUnBiMjRLSUNBZ0lDOHZJR1psWlY5aGJXOTFiblFnUFNBb2NHRjViV1Z1ZEY5aGJXOTFiblFnS2lCbVpXVmZjbUYwWlNrZ0x5OGdNVEF3TURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLZ29nSUNBZ2FXNTBZeUEySUM4dklERXdNREF3Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTkRnS0lDQWdJQzh2SUhSeVlXUmxYMkZ0YjNWdWRDQTlJSEJoZVcxbGJuUmZZVzF2ZFc1MElDMGdabVZsWDJGdGIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalE1Q2lBZ0lDQXZMeUJ6YUdGeVpYTmZjbVZqWldsMlpXUWdQU0FvZEhKaFpHVmZZVzF2ZFc1MElDb2dibTlmY0c5dmJDa2dMeThnS0hsbGMxOXdiMjlzSUNzZ2RISmhaR1ZmWVcxdmRXNTBLUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNoemFHRnlaWE5mY21WalpXbDJaV1FwTENCaGNtTTBMbFZKYm5RMk5DaG1aV1ZmWVcxdmRXNTBLU2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzV6YVcxMWJHRjBaVjl1YjE5MGNtRmtaU2h0WVhKclpYUmZhV1E2SUhWcGJuUTJOQ3dnY0dGNWJXVnVkRjloYlc5MWJuUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbk5wYlhWc1lYUmxYMjV2WDNSeVlXUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVekxUWTFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2MybHRkV3hoZEdWZmJtOWZkSEpoWkdVb2MyVnNaaXdnYldGeWEyVjBYMmxrT2lCVlNXNTBOalFzSUhCaGVXMWxiblJmWVcxdmRXNTBPaUJWU1c1ME5qUXBJQzArSUdGeVl6UXVWSFZ3YkdWYllYSmpOQzVWU1c1ME5qUXNJR0Z5WXpRdVZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVMkNpQWdJQ0F2THlCaGMzTmxjblFnYldGeWEyVjBYMmxrSUR3Z2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsTENBaVRXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qVTRDaUFnSUNBdkx5QnRZWEpyWlhSZmNISmxabWw0SUQwZ1lpSnRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVh5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMVpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTlRrS0lDQWdJQzh2SUhCdmIyeHpYMkp2ZUNBOUlFSnZlRkpsWmloclpYazliV0Z5YTJWMFgzQnlaV1pwZUNBcklHSWljRzl2YkhNaUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEY3dObVkyWmpaak56TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpZd0NpQWdJQ0F2THlCaGMzTmxjblFnY0c5dmJITmZZbTk0TG14bGJtZDBhQ0ErSURBc0lDSk5ZWEpyWlhRZ1pHRjBZU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElHUmhkR0VnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk5qSUtJQ0FnSUM4dklIQnZiMnh6WDJSaGRHRXNJRjlsZUdsemRITWdQU0J3YjI5c2MxOWliM2d1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk5qUUtJQ0FnSUM4dklIbGxjMTl3YjI5c0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOalVLSUNBZ0lDOHZJRzV2WDNCdmIyd2dQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RncExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpZMkNpQWdJQ0F2THlCbVpXVmZjbUYwWlNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NalFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElESTBJQzh2SURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalk0TFRZMk9Rb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdkSEpoWkdVZ2MybHRkV3hoZEdsdmJnb2dJQ0FnTHk4Z1ptVmxYMkZ0YjNWdWRDQTlJQ2h3WVhsdFpXNTBYMkZ0YjNWdWRDQXFJR1psWlY5eVlYUmxLU0F2THlBeE1EQXdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBcUNpQWdJQ0JwYm5SaklEWWdMeThnTVRBd01EQUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTNNQW9nSUNBZ0x5OGdkSEpoWkdWZllXMXZkVzUwSUQwZ2NHRjViV1Z1ZEY5aGJXOTFiblFnTFNCbVpXVmZZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk56RUtJQ0FnSUM4dklITm9ZWEpsYzE5eVpXTmxhWFpsWkNBOUlDaDBjbUZrWlY5aGJXOTFiblFnS2lCNVpYTmZjRzl2YkNrZ0x5OGdLRzV2WDNCdmIyd2dLeUIwY21Ga1pWOWhiVzkxYm5RcENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ0tnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1VlVsdWREWTBLSE5vWVhKbGMxOXlaV05sYVhabFpDa3NJR0Z5WXpRdVZVbHVkRFkwS0dabFpWOWhiVzkxYm5RcEtTa0tJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtZGxkRjl0WVhKclpYUmZiMlJrY3lodFlYSnJaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl0WVhKclpYUmZiMlJrY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTNOUzAyTnpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5dFlYSnJaWFJmYjJSa2N5aHpaV3htTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdZWEpqTkM1VWRYQnNaVnRoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZWEpyWlhSZmFXUWdQQ0J6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVXNJQ0pOWVhKclpYUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiV0Z5YTJWMGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSeklHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT0RBS0lDQWdJQzh2SUhCdmIyeHpJRDBnYzJWc1ppNW5aWFJmYldGeWEyVjBYM0J2YjJ4ektHMWhjbXRsZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJuWlhSZmJXRnlhMlYwWDNCdmIyeHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT0RFS0lDQWdJQzh2SUhsbGMxOXdiMjlzSUQwZ2NHOXZiSE5iTUYwdWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTRNZ29nSUNBZ0x5OGdibTlmY0c5dmJDQTlJSEJ2YjJ4eld6RmRMbTVoZEdsMlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk0TkFvZ0lDQWdMeThnZEc5MFlXeGZiR2x4ZFdsa2FYUjVJRDBnZVdWelgzQnZiMndnS3lCdWIxOXdiMjlzQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk0TlFvZ0lDQWdMeThnYVdZZ2RHOTBZV3hmYkdseGRXbGthWFI1SUQwOUlGVkpiblEyTkNnd0tUb0tJQ0FnSUdKdWVpQm5aWFJmYldGeWEyVjBYMjlrWkhOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk9EWUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDaGhjbU0wTGxWSmJuUTJOQ2cxTUNrc0lHRnlZelF1VlVsdWREWTBLRFV3S1NrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNRE15TURBd01EQXdNREF3TURBd01EQXpNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXRZWEpyWlhSZmIyUmtjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT0RndE5qZzVDaUFnSUNBdkx5QWpJRU52ZFc1MFpYSXRhVzUwZFdsMGFYWmxJRUZOVFNCd2NtbGphVzVuT2lCc1lYSm5aWElnVGs4Z2NHOXZiQ0E5SUdocFoyaGxjaUJaUlZNZ2NISnZZbUZpYVd4cGRIa0tJQ0FnSUM4dklIbGxjMTl3WlhKalpXNTBZV2RsSUQwZ0tHNXZYM0J2YjJ3Z0tpQlZTVzUwTmpRb01UQXdLU2tnTHk4Z2RHOTBZV3hmYkdseGRXbGthWFI1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0FxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT1RBS0lDQWdJQzh2SUc1dlgzQmxjbU5sYm5SaFoyVWdQU0FvZVdWelgzQnZiMndnS2lCVlNXNTBOalFvTVRBd0tTa2dMeThnZEc5MFlXeGZiR2x4ZFdsa2FYUjVDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnY0hWemFHbHVkQ0F4TURBZ0x5OGdNVEF3Q2lBZ0lDQXFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZNU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1VlVsdWREWTBLSGxsYzE5d1pYSmpaVzUwWVdkbEtTd2dZWEpqTkM1VlNXNTBOalFvYm05ZmNHVnlZMlZ1ZEdGblpTa3BLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNW5aWFJmZFhObGNsOXdiM05wZEdsdmJsOTJZV3gxWlNoMWMyVnlPaUJpZVhSbGN5d2diV0Z5YTJWMFgybGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSZmRYTmxjbDl3YjNOcGRHbHZibDkyWVd4MVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk1TkMwMk9UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOTFjMlZ5WDNCdmMybDBhVzl1WDNaaGJIVmxLSE5sYkdZc0lIVnpaWEk2SUVGalkyOTFiblFzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5GMDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTVOd29nSUNBZ0x5OGdkWE5sY2w5emFHRnlaWE1nUFNCelpXeG1MbWRsZEY5MWMyVnlYM05vWVhKbGN5aDFjMlZ5TENCdFlYSnJaWFJmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZFhObGNsOXphR0Z5WlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTVPQW9nSUNBZ0x5OGdiMlJrY3lBOUlITmxiR1l1WjJWMFgyMWhjbXRsZEY5dlpHUnpLRzFoY210bGRGOXBaQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiV0Z5YTJWMFgyOWtaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjd01Bb2dJQ0FnTHk4Z2VXVnpYM05vWVhKbGN5QTlJSFZ6WlhKZmMyaGhjbVZ6V3pCZExtNWhkR2wyWlFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56QXhDaUFnSUNBdkx5QnViMTl6YUdGeVpYTWdQU0IxYzJWeVgzTm9ZWEpsYzFzeFhTNXVZWFJwZG1VS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTURJS0lDQWdJQzh2SUhsbGMxOXZaR1J6SUQwZ2IyUmtjMXN3WFM1dVlYUnBkbVVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjd013b2dJQ0FnTHk4Z2JtOWZiMlJrY3lBOUlHOWtaSE5iTVYwdWJtRjBhWFpsQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOekExTFRjd05nb2dJQ0FnTHk4Z0l5QkZjM1JwYldGMFpXUWdkbUZzZFdVZ1ltRnpaV1FnYjI0Z1kzVnljbVZ1ZENCdlpHUnpJQ2h1YjNRZ1ozVmhjbUZ1ZEdWbFpDQndZWGx2ZFhRcENpQWdJQ0F2THlCNVpYTmZkbUZzZFdVZ1BTQW9lV1Z6WDNOb1lYSmxjeUFxSUhsbGMxOXZaR1J6S1NBdkx5QXhNREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURFd01DQXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjd053b2dJQ0FnTHk4Z2JtOWZkbUZzZFdVZ1BTQW9ibTlmYzJoaGNtVnpJQ29nYm05ZmIyUmtjeWtnTHk4Z01UQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURFd01DQXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjd09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1VlVsdWREWTBLSGxsYzE5MllXeDFaU2tzSUdGeVl6UXVWVWx1ZERZMEtHNXZYM1poYkhWbEtTa3BDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNW5aWFJmWW05NFgyNWhiV1Z6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMkp2ZUY5dVlXMWxjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeE1TMDNNVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjlpYjNoZmJtRnRaWE1vYzJWc1ppd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUdGeVl6UXVWSFZ3YkdWYllYSmpOQzVUZEhKcGJtY3NJR0Z5WXpRdVUzUnlhVzVuTENCaGNtTTBMbE4wY21sdVoxMDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3hOQW9nSUNBZ0x5OGdiV0Z5YTJWMFgzQnlaV1pwZUNBOUlHSWliV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJaRFl4TnpJMllqWTFOelExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpFMkNpQWdJQ0F2THlCeGRXVnpkR2x2Ymw5aWIzaGZibUZ0WlNBOUlHRnlZelF1VTNSeWFXNW5LRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLRzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkYxWlhOMGFXOXVJaWtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGczTVRjMU5qVTNNemMwTmprMlpqWmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTVRjS0lDQWdJQzh2SUhCdmIyeHpYMkp2ZUY5dVlXMWxJRDBnWVhKak5DNVRkSEpwYm1jb1UzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb2JXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaWNHOXZiSE1pS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOekU0Q2lBZ0lDQXZMeUJqY21WaGRHOXlYMkp2ZUY5dVlXMWxJRDBnWVhKak5DNVRkSEpwYm1jb1UzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb2JXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaVkzSmxZWFJ2Y2lJcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURZek56STJOVFl4TnpRMlpqY3lDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTWpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoeGRXVnpkR2x2Ymw5aWIzaGZibUZ0WlN3Z2NHOXZiSE5mWW05NFgyNWhiV1VzSUdOeVpXRjBiM0pmWW05NFgyNWhiV1VwS1FvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SURZS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbWRsZEY5MWMyVnlYMkp2ZUY5dVlXMWxjeWgxYzJWeU9pQmllWFJsY3l3Z2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncG5aWFJmZFhObGNsOWliM2hmYm1GdFpYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTWpJdE56SXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZkWE5sY2w5aWIzaGZibUZ0WlhNb2MyVnNaaXdnZFhObGNqb2dRV05qYjNWdWRDd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUdGeVl6UXVWSFZ3YkdWYllYSmpOQzVUZEhKcGJtY3NJR0Z5WXpRdVUzUnlhVzVuWFRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpJM0NpQWdJQ0F2THlCaUluVnpaWEpmSWlBcklIVnpaWEl1WW5sMFpYTWdLeUJpSWw5dFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWDNsbGN5SUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjROelUzTXpZMU56STFaZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TldZMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURWbU56azJOVGN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3lOUzAzTWprS0lDQWdJQzh2SUhsbGMxOWliM2hmYm1GdFpTQTlJR0Z5WXpRdVUzUnlhVzVuS0FvZ0lDQWdMeThnSUNBZ0lGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaUluVnpaWEpmSWlBcklIVnpaWEl1WW5sMFpYTWdLeUJpSWw5dFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWDNsbGN5SUtJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpNd0NpQWdJQ0F2THlCdWIxOWliM2hmYm1GdFpTQTlJR0Z5WXpRdVUzUnlhVzVuS0ZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0dJaWRYTmxjbDhpSUNzZ2RYTmxjaTVpZVhSbGN5QXJJR0lpWDIxaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmYm04aUtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjROV1kyWlRabUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNNeklLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2g1WlhOZlltOTRYMjVoYldVc0lHNXZYMkp2ZUY5dVlXMWxLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVkbUZzYVdSaGRHVmZkSEpoWkdsdVoxOXdZWEpoYlhNb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRc0lIQmhlVzFsYm5SZllXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjek5DMDNNelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlIWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBMQ0J3WVhsdFpXNTBYMkZ0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVRbTl2YkN3Z1lYSmpOQzVUZEhKcGJtZGRPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM016Y0tJQ0FnSUM4dklHbG1JRzFoY210bGRGOXBaQ0ErUFNCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1U2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBOFBRb2dJQ0FnWW5vZ2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTXpnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTENCaGNtTTBMbE4wY21sdVp5Z2lUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wSWlrcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF6TURBeE5UUmtOakUzTWpaaU5qVTNOREl3TmpRMlpqWTFOek15TURabE5tWTNOREl3TmpVM09EWTVOek0zTkFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME1Bb2dJQ0FnTHk4Z2FXWWdjR0Y1YldWdWRGOWhiVzkxYm5RZ1BDQlZTVzUwTmpRb01UQXdNQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREF3Q2lBZ0lDQThDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOTBjbUZrYVc1blgzQmhjbUZ0YzE5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1UW05dmJDaEdZV3h6WlNrc0lHRnlZelF1VTNSeWFXNW5LQ0pOYVc1cGJYVnRJSEJoZVcxbGJuUWdhWE1nTVRBd01DQnRhV055YjBGTVIwOXpJaWtwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXpNREF5TWpSa05qazJaVFk1Tm1RM05UWmtNakEzTURZeE56azJaRFkxTm1VM05ESXdOamszTXpJd016RXpNRE13TXpBeU1EWmtOamsyTXpjeU5tWTBNVFJqTkRjMFpqY3pDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG1Gc2FXUmhkR1ZmZEhKaFpHbHVaMTl3WVhKaGJYTmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelF6Q2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05EUUtJQ0FnSUM4dklIQnZiMnh6WDJKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YldGeWEyVjBYM0J5WldacGVDQXJJR0lpY0c5dmJITWlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME5Rb2dJQ0FnTHk4Z2FXWWdjRzl2YkhOZlltOTRMbXhsYm1kMGFDQTlQU0F3T2dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0p1ZWlCMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMwTmdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVRbTl2YkNoR1lXeHpaU2tzSUdGeVl6UXVVM1J5YVc1bktDSk5ZWEpyWlhRZ1pHRjBZU0J1YjNRZ1ptOTFibVFpS1NrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNRE13TURFMU5HUTJNVGN5Tm1JMk5UYzBNakEyTkRZeE56UTJNVEl3Tm1VMlpqYzBNakEyTmpabU56VTJaVFkwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpRNENpQWdJQ0F2THlCd2IyOXNjMTlrWVhSaExDQmZaWGhwYzNSeklEMGdjRzl2YkhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMwT1FvZ0lDQWdMeThnYVhOZmNtVnpiMngyWldRZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRFF3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwTUNBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjMU1Bb2dJQ0FnTHk4Z2NtVnpiMngxZEdsdmJsOTBhVzFsSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3pNaWtzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTlRJS0lDQWdJQzh2SUdsbUlHbHpYM0psYzI5c2RtVmtJQ0U5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR0o2SUhaaGJHbGtZWFJsWDNSeVlXUnBibWRmY0dGeVlXMXpYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvWVhKak5DNUNiMjlzS0VaaGJITmxLU3dnWVhKak5DNVRkSEpwYm1jb0lrMWhjbXRsZENCcGN5QmhiSEpsWVdSNUlISmxjMjlzZG1Wa0lpa3BLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBek1EQXhZVFJrTmpFM01qWmlOalUzTkRJd05qazNNekl3TmpFMll6Y3lOalUyTVRZME56a3lNRGN5TmpVM016Wm1ObU0zTmpZMU5qUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOVFVLSUNBZ0lDOHZJR2xtSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDQ5SUhKbGMyOXNkWFJwYjI1ZmRHbHRaVG9LSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNBK1BRb2dJQ0FnWW5vZ2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpVMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVDYjI5c0tFWmhiSE5sS1N3Z1lYSmpOQzVUZEhKcGJtY29JbFJ5WVdScGJtY2dhR0Z6SUdWdVpHVmtJaWtwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXpNREF4TVRVME56STJNVFkwTmprMlpUWTNNakEyT0RZeE56TXlNRFkxTm1VMk5EWTFOalFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpVNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVDYjI5c0tGUnlkV1VwTENCaGNtTTBMbE4wY21sdVp5Z2lWbUZzYVdRaUtTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNREF3TURNd01EQTFOVFkyTVRaak5qazJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYMkZzYkY5dFlYSnJaWFJ6WDNOMWJXMWhjbmtvS1NBdFBpQmllWFJsY3pvS1oyVjBYMkZzYkY5dFlYSnJaWFJ6WDNOMWJXMWhjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05qQXROell4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmWVd4c1gyMWhjbXRsZEhOZmMzVnRiV0Z5ZVNoelpXeG1LU0F0UGlCaGNtTTBMbFIxY0d4bFcyRnlZelF1VlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTUNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05qTUtJQ0FnSUM4dklIUnZkR0ZzWDIxaGNtdGxkSE1nUFNCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5dFlYSnJaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTmpRS0lDQWdJQzh2SUhSdmRHRnNYMlpsWlhNZ1BTQnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p3YkdGMFptOXliVjltWldWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05qWXROelkzQ2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCMGIzUmhiQ0IyYjJ4MWJXVWdZV055YjNOeklHRnNiQ0J0WVhKclpYUnpDaUFnSUNBdkx5QjBiM1JoYkY5MmIyeDFiV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05qZ0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoMGIzUmhiRjl0WVhKclpYUnpLVG9LSUNBZ0lHUjFjQW9LWjJWMFgyRnNiRjl0WVhKclpYUnpYM04xYlcxaGNubGZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56WTRDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2RHOTBZV3hmYldGeWEyVjBjeWs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdkbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVYMkZtZEdWeVgyWnZja0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05qa0tJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHBLU0FySUdJaVh5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMzTUFvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOemN4Q2lBZ0lDQXZMeUJwWmlCd2IyOXNjMTlpYjNndWJHVnVaM1JvSUQ0Z01Eb0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMzTWdvZ0lDQWdMeThnY0c5dmJITmZaR0YwWVN3Z1gyVjRhWE4wY3lBOUlIQnZiMnh6WDJKdmVDNXRZWGxpWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOek1LSUNBZ0lDOHZJRzFoY210bGRGOTJiMngxYldVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREUyS1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM056UUtJQ0FnSUM4dklIUnZkR0ZzWDNadmJIVnRaU0FyUFNCdFlYSnJaWFJmZG05c2RXMWxDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwblpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOamdLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaDBiM1JoYkY5dFlYSnJaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNpQWdJQ0JpSUdkbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVYMlp2Y2w5b1pXRmtaWEpBTVFvS1oyVjBYMkZzYkY5dFlYSnJaWFJ6WDNOMWJXMWhjbmxmWVdaMFpYSmZabTl5UURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOemNLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hSdmRHRnNYMjFoY210bGRITXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMzT0FvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2RHOTBZV3hmZG05c2RXMWxLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTnprS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtIUnZkR0ZzWDJabFpYTXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOemMyTFRjNE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hSdmRHRnNYMjFoY210bGRITXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtIUnZkR0ZzWDNadmJIVnRaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9kRzkwWVd4ZlptVmxjeWtLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUpBQUVJNkFlUUhJRG5oQStRVHNDRVBZQ0plaVlQQkJVZmZIVU5kRzkwWVd4ZmJXRnlhMlYwY3dkdFlYSnJaWFJmQVY4RllXUnRhVzRGY0c5dmJITU5jR3hoZEdadmNtMWZabVZsY3dFQURXMXBibDlzYVhGMWFXUnBkSGtJY1hWbGMzUnBiMjRGZFhObGNsOElYMjFoY210bGRGOEhZM0psWVhSdmNnUmZlV1Z6QTE5dWJ6RWJRUU8rZ2g4RVUrY0dtd1NRK05Ub0JLUUVJVElFbmQxYy9BU2FYM0ovQklUaVlLY0VsMXBTR1FTelpTVGNCT25YOTdJRUQrVXQrd1JQdHEvY0JJeWRTckVFcmR5V3F3UWFQR1pUQkhKNFV4NEVjZ0dKYndUc1dJQnhCQU44cWQwRXZzS2N5Z1FIVXp1VkJQZWcvU2tFWlV5YXJBU25LMXhkQkpYTXFGMEU4THFWNWdRa2dyZ1JCUEhNOTB3RVIxR09aQVRzaW83N0JENVluSElFZmhEb3hqWWFBSTRmQXJVQ2pBSmpBa2NDTXdJZkFnb0I2d0hNQWJrQnFBR1hBWVlCYkFGWEFVY0JOd0VuQVFVQTd3RGVBTW9BdGdDZUFJWUFjZ0JZQUVRQUtnQVNBQUlpUXpFWkZFUXhHRVNJQytFb1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFoZUlDczRvVEZDd0kwTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ0Y0Z0tkeWhNVUxBalF6RVpGRVF4R0VRMkdnRVhpQW9OS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmZBSERZYUFoZUlDY0FvVEZDd0kwTXhHUlJFTVJoRU5ob0JGNGdKWENoTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Y0Z0pBaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhOaG9DRjRnSXFDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBaHhLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlDRGtvVEZDd0kwTXhHUlJFTVJoRWlBZ2dGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVh3QnlJQi9jb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhjMkdnUVhpQWVYS0V4UXNDTkRNUmtVUkRFWVJJZ0hWQ2hNVUxBalF6RVpGRVF4R0VTSUJ6VW9URkN3STBNeEdSUkVNUmhFaUFiK0tFeFFzQ05ETVJrVVJERVlSRFlhQVJlSUJtUVdLRXhRc0NORE1Sa1VSREVZUkRZYUFSZkFIRFlhQWhlSUJnTW9URkN3STBNeEdSUkVNUmhFaUFYT0ZpaE1VTEFqUXpFWkZFUXhHRVNJQmJjV0tFeFFzQ05ETVJrVVJERVlSSWdGb1JZb1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFvZ0ZLeU5ETVJrVVJERVlSRFlhQVJjeEZpTUpTVGdRSXhKRWlBUkhGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhNUllqQ1VrNEVDTVNSSWdEWGhZb1RGQ3dJME14R1JSRU1SaEVOaG9CRjRnREl4WW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0MyaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhpQUtYS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmVJQW01SkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhOaG9ERnpFV0l3bEpPQkFqRWtTSUFiOFdLRXhRc0NORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWhjMkdnTVhNUllqQ1VrNEVDTVNSSWdBN2hZb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhjeEZpTUpTVGdRSXhKRWlBQXBGaWhNVUxBalF6RVpRUDBkTVJnVVJDTkRpZ0VCaS8rQmdNaXZvQ1VOUVFBRmkvOGxDb21MLzRtS0JBRWlKd1JsUkRJREVrRUFFU2NFTVFCbktTSm5Kd1lpWnljSUlRZG5NZ2t4QUJJaUp3UmxSREVBRWhGRWkvNGxEa1NML3pnSE1nb1NSSXYvT0FoSklRZ1BSSXY5aVArZ01nY2hCQWhMQVF4RU1nY2hCUWhMQVE5RUlpbGxSRWtXS2t4UUsxQkpKd2xRaS95L1R3T0JBZ29XU1ZBaUZreExBVkNML2haUVR3UVdVRXNCVUV4UVN3RW5CVkJNdnljTVVERUF2MGtqQ0NsTVo0bUtCQUVpSndSbFJESURFa0VBamljRU1RQm5LU0puSndZaVp5SW5DR1ZFUUFBRkp3Z2hCMmVML2lVT1JJdi9PQWN5Q2hKRWkvODRDQ0luQ0dWRWdRSUxTd0VPUkl2OWlQOEVNZ2NoQkFoTEFReEVNZ2NoQlFoTEFROUVJaWxsUkVrV0treFFLMUJKSndsUWkveS9Ud09CQWdvV1NWQWlGa3hMQVZDTC9oWlFUd1FXVUVzQlVFeFFTd0VuQlZCTXZ5Y01VREVBdjBrakNDbE1aNGt4QUNJbkJHVkVFa1JDLzMrS0JBRWlKd1JsUkVreUF4TkVNUUFTUkl2K0pRNUVpLzg0QnpJS0VrU0wvemdJU1NFSUQwU0wvWWorZVRJSElRUUlTd0VNUkRJSElRVUlTd0VQUkNJcFpVUkpGaXBNVUN0UVNTY0pVSXY4djA4RGdRSUtGa2xRSWhaTVN3RlFpLzRXVUU4RUZsQkxBVkJNVUVzQkp3VlFUTDhuREZBeEFMOUpJd2dwVEdlSmlnRUJpLzhXS2t4UUsxQW5DVkJKdlVSRXZraUppZ0VCaS84V0treFFLMUFuQlZCSnZVUkV2a2hKSWx0TEFTUmJUd0tCRUZ0UEFoWlBBaFpQQWhaT0FsQk1VSW1LQVFHTC94WXFURkFyVUNjRlVFbTlSRVMrU0VtQktGdE1nVEJiVENNU0p3Y2lUd0pVVENNU0p3Y2lUd0pVSWxNalRGU0ppZ0VCaS8rSS81VkpJbHRNSkZ0SlRnSUlTVUFBQm9IMEE0d0FpWXNBSlF1TEFRcU1BSW1LQWdHTC9oWXFTd0ZRSzFBbkJWQkp2VVJFU2I1SVNTSmJTd0VrVzBzQ2dSQmJTd09CR0Z0TEJJRWdXMHNGZ1NoYlNSUkVNZ2RMQWd4RWkvODRBREVBRWtTTC96Z0hNZ29TUkl2L09BaEpSRWtsRDBSSlN3UUxJUVlLU2dsSlN3Z0xUd2xQQWdoTVN3RUtUZ3RQQms4RENFOEhnVEJiVHdJV1R3Y1dVRThDRmxCUEJSWlFUd1FXVUU4REZsQk1GbEJQQWt5L0lpY0daVVFJSndaTVp5Y0tNUUJRSnd0UVRGQW5EVkJKSWt5OVJFRUFCNHNCdmtnWGpBS0xBb3NBU1U0Q0NCYUxBVXkvakFDSmlnSUJpLzRXS2tzQlVDdFFKd1ZRU2IxRVJFbStTRWtpVzBzQkpGdExBb0VRVzBzRGdSaGJTd1NCSUZ0TEJZRW9XMGtVUkRJSFN3SU1SSXYvT0FBeEFCSkVpLzg0QnpJS0VrU0wvemdJU1VSSkpROUVTVXNFQ3lFR0Nrb0pTVXNKQzA4SVR3SUlURXNCQ2s0TFR3WlBBd2hQQjRFd1cwOEhGazhERmxCUEFoWlFUd1VXVUU4RUZsQlBBeFpRVEJaUVR3Sk12eUluQm1WRUNDY0dUR2NuQ2pFQVVDY0xVRXhRSnc1UVNTSk12VVJCQUFlTEFiNUlGNHdDaXdLTEFFbE9BZ2dXaXdGTXY0d0FpWW9DQURFQUlpY0VaVVFTUkl2K0ZpcE1VQ3RRSndWUVNiMUVSRW0rU0VraVcwc0JKRnRMQW9FUVcwc0RnUmhiU3dTQklGdFBCWUVvV3hSRU1nZExBUTlFVHdRV1R3UVdVRThERmxCUEFoWlFUQlpRSXhaUWkvOGlVeFpRdjRraUtXVkVpU0luQm1WRWlURUFJaWNFWlVRU1JDSW5CbVZFU1VRbkJpSm5zVEVBU3dHeUNMSUhJN0lRSXJJQnM0bUtBZ0VpZ0FBbkNvditVQ2NMVUl2L0ZsQkpKdzFRU1NKTXZVUkJBQWVMQTc1SUY0d0Vpd0luRGxCSmpBQWlqQUc5UkVFQUI0c0F2a2dYakFHTEJCYUxBUlpRakFDSmlnRUJJa21ML3haSktreFFLMUFuQlZCSnZVUkV2a2hKZ1NoYlRJRXdXMHdqRWtReEFJdi9pUCtRU1NKYlRnTWtXMDRDSXhKQkFEQW5DakVBVUNjTFVFeFFKdzFRU1l3QnZVUkJBQVNMQWJ4SWl3SkpSTEV4QUVzQnNnaXlCeU95RUNLeUFiT01BSWtuQ2pFQVVDY0xVRXhRSnc1UVNZd0F2VVJCQUFTTEFMeElpd05DLzgwaUp3UmxSRWtWZ1NBU1JDSXBaVVFXSWljR1pVUVdJaWNJWlVRV1R3TlBBMUJQQWxCTVVJa2lKd1JsUkRJREV5Y0hJazhDVkltS0FBRWlKd1JsUkRJREV5Y0hJa3NDVkV4QkFCa2lKd1JsUkVrVmdTQVNSQ0lwWlVRV2l3QlBBbEJNVUV5Sk1nTkMvK2VLQkFHTC9pVU5RUUFESndlSklpY0laVVNCQWd1TC93MUJBQU1uQjRreUJ5RUVDSXY5RDBFQUF5Y0hpVElISVFVSWkvME1RUUFESndlSmdBR0FpWW9CQVNJbkJHVkVpLzhTSndjaVR3SlVpU0luQ0dWRWdRSUxpWW9CQVNJcFpVU0wvdzVCQUFNbkI0bUwveFlxVEZBclVDY0pVTDFFSndjaVR3SlVpWW9CQVNJcFpVU0wvdzFFaS84V0treFFLMUFuREZCSnZVUkV2a2hKRllFZ0VrU0ppZ0lCSWlsbFJJditEVVNML2hZcVRGQXJVQ2NGVUVtOVJFUytTRWtpVzBzQkpGdFBBb0VZVzR2L0N5RUdDb3YvU3dFSlNVOERDMDhEVHdJSUNoWk1GbENKaWdJQklpbGxSSXYrRFVTTC9oWXFURkFyVUNjRlVFbTlSRVMrU0VraVcwc0JKRnRQQW9FWVc0di9DeUVHQ292L1N3RUpTVThFQzA4RFR3SUlDaFpNRmxDSmlnRUJJaWxsUkl2L0RVU0wvNGo2N0VraVcwbFBBaVJiU1U0Q0NFbEFBQldBRUFBQUFBQUFBQUF5QUFBQUFBQUFBREtNQUltTEFZRmtDNHNDU1U0Q0Nvc0FnV1FMVHdJS1RCWk1GbENNQUltS0FnR0wvb3YvaVAxTmkvK0kvNkZMQVNKYlR3SWtXMHNDSWx0UEF5UmJUd05QQWd1QlpBcE9BZ3VCWkFwTUZrd1dVSW1LQVFHTC94WXFURkFyVUVrbkNWQkpGUlpYQmdKTVVFc0JKd1ZRU1JVV1Z3WUNURkJQQWljTVVFa1ZGbGNHQWt4UVN3SVZnUVlJU1JaWEJnS0FBZ0FHVEZCTEF4VlBBZ2dXVndZQ1VFOERVRThDVUV4UWlZb0NBU2NLaS81UUp3dFFpLzhXVUVrbkRWQkpGUlpYQmdKTVVFd25EbEJKRlJaWEJnSk1VRXNCRllFRUNCWlhCZ0tBQWdBRVRGQlBBbEJNVUltS0FnRWlnQUFpS1dWRWkvNE9RUUFmZ0JvQUFBTUFGVTFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZEl3QWlZdi9KUXhCQUN5QUp3QUFBd0FpVFdsdWFXMTFiU0J3WVhsdFpXNTBJR2x6SURFd01EQWdiV2xqY205QlRFZFBjNHdBaVl2K0ZpcE1VQ3RRSndWUVNZd0F2VVJBQUIrQUdnQUFBd0FWVFdGeWEyVjBJR1JoZEdFZ2JtOTBJR1p2ZFc1a2pBQ0ppd0MrU0VtQktGdE1nU0JiakFGQkFDU0FId0FBQXdBYVRXRnlhMlYwSUdseklHRnNjbVZoWkhrZ2NtVnpiMngyWldTTUFJa3lCNHNCRDBFQUc0QVdBQUFEQUJGVWNtRmthVzVuSUdoaGN5QmxibVJsWkl3QWlZQUtnQUFEQUFWV1lXeHBaSXdBaVlvQUFTS0FBQ0lwWlVRaUp3WmxSQ0pKaXdXTEFneEJBRENMQlJZcVRGQXJVQ2NGVUVtTUFMMUVpd1NNQVVFQURJc0F2a2lCRUZ1TEJBaU1BWXNCakFTTEJTTUlqQVZDLzhpTEFoYUxCQmFMQXhaT0FsQk1VSXdBaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
