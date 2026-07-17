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

namespace Arc56.Generated.mohit_1710.AlgoArena.PredictionMarketContract_7dc203a7
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
        ///SIMPLE REQUIREMENTS: 1. Only contract creator can call this (first time only) 2. Payment TO contract >= 2 ALGO  3. Resolution time: 1 hour to 1 year from now 4. Fee rate: 0-1000 (0% to 10%)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGlvbk1hcmtldENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldE1hcmtldFBvb2xzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRNYXJrZXRTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dLCJHZXRVc2VyU2hhcmVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbnRyYWN0RGVidWdJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbnRyYWN0U3RhdHVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIkdldEJveE5hbWVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn1dLCJHZXRVc2VyQm94TmFtZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiVmFsaWRhdGVUcmFkaW5nUGFyYW1zUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemVfYW5kX2NyZWF0ZV9maXJzdF9tYXJrZXQiLCJkZXNjIjoiSW5pdGlhbGl6ZSBjb250cmFjdCBhbmQgY3JlYXRlIGZpcnN0IG1hcmtldCBpbiBvbmUgY2FsbCAoRlJPTlRFTkQgRlJJRU5ETFkpXG5TSU1QTEUgUkVRVUlSRU1FTlRTOiAxLiBPbmx5IGNvbnRyYWN0IGNyZWF0b3IgY2FuIGNhbGwgdGhpcyAoZmlyc3QgdGltZSBvbmx5KSAyLiBQYXltZW50IFRPIGNvbnRyYWN0ID49IDIgQUxHTyAgMy4gUmVzb2x1dGlvbiB0aW1lOiAxIGhvdXIgdG8gMSB5ZWFyIGZyb20gbm93IDQuIEZlZSByYXRlOiAwLTEwMDAgKDAlIHRvIDEwJSkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb25fdGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX3JhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfbWFya2V0X3NpbXBsZSIsImRlc2MiOiJGcm9udGVuZC1mcmllbmRseSBzaW5nbGUtY2FsbDogYXV0by1pbml0aWFsaXplIChpZiBuZWVkZWQpIGFuZCBjcmVhdGUgbWFya2V0LlxuLSBBY2NlcHRzIHJlc29sdXRpb25fdGltZSBpbiBzZWNvbmRzIG9yIG1pbGxpc2Vjb25kcyAoYXV0by1kZXRlY3RlZCkuIC0gUmVxdWlyZXMgYSBwYXltZW50IHRvIHRoZSBhcHAgYWRkcmVzcyB3aXRoID49IDIgKiBtaW5fbGlxdWlkaXR5IChkZWZhdWx0cyB0byAxIEFMR08pLiAtIEZvciB0aGUgdmVyeSBmaXJzdCBjYWxsLCB0aGUgY2FsbGVyIGJlY29tZXMgYWRtaW4gYXV0b21hdGljYWxseS4gLSBBZnRlciBpbml0aWFsaXphdGlvbiwgb25seSBhZG1pbiBjYW4gY3JlYXRlIG5ldyBtYXJrZXRzLiBSZXR1cm5zOiBtYXJrZXRfaWQgKFVJbnQ2NCkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXN0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNvbHV0aW9uX3RpbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZV9yYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX21hcmtldCIsImRlc2MiOiJDcmVhdGUgYWRkaXRpb25hbCBtYXJrZXRzIChhZnRlciBjb250cmFjdCBpcyBpbml0aWFsaXplZCkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb25fdGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX3JhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X3F1ZXN0aW9uIiwiZGVzYyI6IkdldCBtYXJrZXQgcXVlc3Rpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hcmtldF9wb29scyIsImRlc2MiOiJHZXQgbWFya2V0IHBvb2xzOiAoeWVzX3Bvb2wsIG5vX3Bvb2wsIHRvdGFsX3ZvbHVtZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNYXJrZXRQb29sc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXRfc3RhdHVzIiwiZGVzYyI6IkdldCBtYXJrZXQgc3RhdHVzOiAoaXNfcmVzb2x2ZWQsIHdpbm5pbmdfb3V0Y29tZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wpIiwic3RydWN0IjoiR2V0TWFya2V0U3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlX3llc19wcmljZSIsImRlc2MiOiJDYWxjdWxhdGUgY3VycmVudCBZZXMgcHJpY2UgKHNjYWxlZCBieSAxMDAwKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfeWVzX3NoYXJlcyIsImRlc2MiOiJCdXkgWWVzIHNoYXJlcyBpbiBhIG1hcmtldFxuVFJBTlNBQ1RJT04gUkVRVUlSRU1FTlRTOiAxLiBQYXltZW50IHRyYW5zYWN0aW9uIG11c3QgYmUgc2VudCBUTyB0aGUgY29udHJhY3QgYWRkcmVzcyAyLiBQYXltZW50IG11c3QgYmUgZnJvbSB0aGUgc2FtZSBzZW5kZXIgYXMgYXBwIGNhbGwgMy4gTWluaW11bSBwYXltZW50OiAxMDAwIG1pY3JvQUxHT3MgNC4gTWFya2V0IG11c3QgYmUgYWN0aXZlIGFuZCBub3QgcmVzb2x2ZWQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5X25vX3NoYXJlcyIsImRlc2MiOiJCdXkgTm8gc2hhcmVzIGluIGEgbWFya2V0IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc29sdmVfbWFya2V0IiwiZGVzYyI6IlJlc29sdmUgYSBtYXJrZXQgd2l0aCB0aGUgd2lubmluZyBvdXRjb21lIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Inllc193aW5zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9tYXJrZXRzIiwiZGVzYyI6IkdldCB0b3RhbCBudW1iZXIgb2YgbWFya2V0cyBjcmVhdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BsYXRmb3JtX2ZlZXMiLCJkZXNjIjoiR2V0IHRvdGFsIHBsYXRmb3JtIGZlZXMgY29sbGVjdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfZmVlcyIsImRlc2MiOiJXaXRoZHJhdyBjb2xsZWN0ZWQgcGxhdGZvcm0gZmVlcyAoYWRtaW4gb25seSkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zaGFyZXMiLCJkZXNjIjoiR2V0IHVzZXIncyBZZXMgYW5kIE5vIHNoYXJlcyBmb3IgYSBtYXJrZXQiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyU2hhcmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZWVtX3dpbm5pbmdfc2hhcmVzIiwiZGVzYyI6IlJlZGVlbSB3aW5uaW5nIHNoYXJlcyBmb3IgYSByZXNvbHZlZCBtYXJrZXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X2RlYnVnX2luZm8iLCJkZXNjIjoiR2V0IGNvbnRyYWN0IHN0YXRlIGZvciBkZWJ1Z2dpbmciLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Q29udHJhY3REZWJ1Z0luZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19jb250cmFjdF9pbml0aWFsaXplZCIsImRlc2MiOiJDaGVjayBpZiBjb250cmFjdCBpcyBpbml0aWFsaXplZCAoRlJPTlRFTkQgSEVMUEVSKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29udHJhY3Rfc3RhdHVzIiwiZGVzYyI6IkdldCBjb250cmFjdCBpbml0aWFsaXphdGlvbiBzdGF0dXMgLSBSZXR1cm5zIChpc19pbml0aWFsaXplZCwgYWRtaW4sIHRvdGFsX21hcmtldHMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iihib29sLGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IkdldENvbnRyYWN0U3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfY3JlYXRlX21hcmtldF9wYXJhbXMiLCJkZXNjIjoiVmFsaWRhdGUgbWFya2V0IGNyZWF0aW9uIHBhcmFtZXRlcnMgd2l0aG91dCBjcmVhdGluZyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVzdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x1dGlvbl90aW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuX2NyZWF0ZV9tYXJrZXQiLCJkZXNjIjoiQ2hlY2sgaWYgc2VuZGVyIGNhbiBjcmVhdGUgbWFya2V0cyIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yZXF1aXJlZF9wYXltZW50X2Zvcl9tYXJrZXQiLCJkZXNjIjoiQ2FsY3VsYXRlIHJlcXVpcmVkIHBheW1lbnQgZm9yIG1hcmtldCBjcmVhdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtldF9leGlzdHMiLCJkZXNjIjoiQ2hlY2sgaWYgbWFya2V0IGV4aXN0cyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hcmtldF9jcmVhdG9yIiwiZGVzYyI6IkdldCBtYXJrZXQgY3JlYXRvciBhZGRyZXNzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzaW11bGF0ZV95ZXNfdHJhZGUiLCJkZXNjIjoiU2ltdWxhdGUgWUVTIHRyYWRlIHdpdGhvdXQgZXhlY3V0aW5nIC0gUmV0dXJucyAoc2hhcmVzX3JlY2VpdmVkLCBmZWVfYW1vdW50KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJTaGFyZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzaW11bGF0ZV9ub190cmFkZSIsImRlc2MiOiJTaW11bGF0ZSBOTyB0cmFkZSB3aXRob3V0IGV4ZWN1dGluZyAtIFJldHVybnMgKHNoYXJlc19yZWNlaXZlZCwgZmVlX2Ftb3VudCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyU2hhcmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hcmtldF9vZGRzIiwiZGVzYyI6IkdldCBtYXJrZXQgb2RkcyBhcyBwZXJjZW50YWdlcyAtIFJldHVybnMgKHllc19wZXJjZW50YWdlLCBub19wZXJjZW50YWdlKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclNoYXJlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX3Bvc2l0aW9uX3ZhbHVlIiwiZGVzYyI6IkdldCBlc3RpbWF0ZWQgdmFsdWUgb2YgdXNlcidzIHBvc2l0aW9uIC0gUmV0dXJucyAoeWVzX3ZhbHVlLCBub192YWx1ZSkgaW4gbWljcm9BTEdPcyIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJTaGFyZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYm94X25hbWVzIiwiZGVzYyI6IkdldCBib3ggbmFtZXMgZm9yIGEgbWFya2V0IC0gUmV0dXJucyAocXVlc3Rpb25fYm94LCBwb29sc19ib3gsIGNyZWF0b3JfYm94KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nKSIsInN0cnVjdCI6IkdldEJveE5hbWVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfYm94X25hbWVzIiwiZGVzYyI6IkdldCB1c2VyIGJveCBuYW1lcyBmb3IgYSBtYXJrZXQgLSBSZXR1cm5zICh5ZXNfYm94LCBub19ib3gpIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR2V0VXNlckJveE5hbWVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfdHJhZGluZ19wYXJhbXMiLCJkZXNjIjoiVmFsaWRhdGUgdHJhZGluZyBwYXJhbWV0ZXJzIC0gUmV0dXJucyAoaXNfdmFsaWQsIGVycm9yX21lc3NhZ2UpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsc3RyaW5nKSIsInN0cnVjdCI6IlZhbGlkYXRlVHJhZGluZ1BhcmFtc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hbGxfbWFya2V0c19zdW1tYXJ5IiwiZGVzYyI6IkdldCBzdW1tYXJ5IG9mIGFsbCBtYXJrZXRzIC0gUmV0dXJucyAodG90YWxfbWFya2V0cywgdG90YWxfdm9sdW1lLCB0b3RhbF9mZWVzKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0TWFya2V0UG9vbHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0ODksMjU2NCwyNzQyXSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTkxXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXNvbHZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NjFdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDA6IENvbnRyYWN0IG5vdCBpbml0aWFsaXplZCAtIHVzZSBpbml0aWFsaXplX2FuZF9jcmVhdGVfZmlyc3RfbWFya2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0NSwxNDY1XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTAxOiBPbmx5IGFkbWluIGNhbiBjcmVhdGUgbWFya2V0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTVdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDE6IE9ubHkgY3JlYXRvci9hZG1pbiBjYW4gY3JlYXRlIG1hcmtldHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDcwXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTAyOiBGZWUgcmF0ZSBtYXggMTAlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2MCwxMzA2XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTAyOiBGZWUgcmF0ZSBtYXggMTAlICgxMDAwKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNjgsMTMxNCwxNDc4XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTAzOiBQYXltZW50IG11c3QgZ28gVE8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzMxXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA0OiBOZWVkIGF0IGxlYXN0IDIgKiBtaW5fbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4N10sImVycm9yTWVzc2FnZSI6IkVSUk9SXzEwNDogTmVlZCBhdCBsZWFzdCAyIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTc3XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA0OiBOZWVkIGF0IGxlYXN0IDIgQUxHTyAoMjAwMDAwMCBtaWNyb0FsZ29zKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODYsMTM1NiwxNDk2XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA1OiBSZXNvbHV0aW9uIHRpbWUgbXVzdCBiZSAxKyBob3VycyBmcm9tIG5vdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOTUsMTM2NSwxNTA1XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA2OiBSZXNvbHV0aW9uIHRpbWUgbWF4IDEgeWVhciBmcm9tIG5vdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3ODAsMTk4Ml0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzIwMTogTWFya2V0IGlzIHJlc29sdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4NiwxOTg4XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjAyOiBUcmFkaW5nIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5NCwxOTk2XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjAzOiBQYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIGFwcCBjYWxsIHNlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MDIsMjAwNF0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzIwNDogUGF5bWVudCBtdXN0IGJlIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwOCwyMDEwXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjA1OiBQYXltZW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODEyLDIwMTRdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8yMDY6IE1pbmltdW0gdHJhZGUgYW1vdW50IGlzIDEwMDAgbWljcm9BTEdPcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MTldLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgSUQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzM0XSwiZXJyb3JNZXNzYWdlIjoiTWFya2V0IGNyZWF0b3IgZGF0YSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzY5LDI4MzVdLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgZGF0YSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTg4LDE2MDksMTY1NiwxNzQ3LDE5NDksMjE1OSwyMzY1LDI3NTQsMjgyMCwyODg2XSwiZXJyb3JNZXNzYWdlIjoiTWFya2V0IGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3OV0sImVycm9yTWVzc2FnZSI6Ik1hcmtldCBub3QgcmVzb2x2ZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1M10sImVycm9yTWVzc2FnZSI6Ik5vIGZlZXMgdG8gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDI5XSwiZXJyb3JNZXNzYWdlIjoiTm8gd2lubmluZyBzaGFyZXMgdG8gcmVkZWVtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcwLDM4Niw0MTAsNDM2LDQ1Niw0ODIsNTAyLDUyNiw1NTAsNTcwLDU5MCw2MDcsNjI5LDY2Myw2NzksNjk1LDcxMSw3MzIsNzU4LDc3NSw3OTIsODA5LDgyOCw4NTksODkwLDkxMSw5MzEsOTUxLDk3OSwxMDIwLDEwNjFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTQ0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gcmVzb2x2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNDZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB3aXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOTddLCJlcnJvck1lc3NhZ2UiOiJUb28gZWFybHkgdG8gcmVzb2x2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsMzg5LDQxMyw0MzksNDU5LDQ4NSw1MDUsNTI5LDU1Myw1NzMsNTkzLDYxMCw2MzIsNjY2LDY4Miw2OTgsNzE0LDczNSw3NjEsNzc4LDc5NSw4MTIsODMxLDg2Miw4OTMsOTE0LDkzNCw5NTQsOTgyLDEwMjMsMTA2NF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTg3LDE2MDgsMTY1NSwxNzQ2LDE5MDQsMTk0OCwyMTA2LDIxNTgsMjMwMSwyMzI0LDIzNjQsMjQxOCwyNDY2LDI3MDEsMjczMywyNzY4LDI4MzQsMzI2NywzNDQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQm94UmVmIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTcsMTE1MCwxMjcwLDE0NDMsMTQ1NiwyMTQyLDIyNDQsMjQ4MywyNTIyLDI1NDAsMjU1OCwyNjUzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkzLDEzMjYsMjUwNSwyNjAxLDI2NjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbl9saXF1aWRpdHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4MSwyMDgzLDIyMzYsMjI1MSwyNDk5LDM0MTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBsYXRmb3JtX2ZlZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5OSwxMzY5LDE1MDksMjIzMCwyNDkzLDI1NjgsMjY3OSwyNzE1LDI3NTAsMjgxNiwyODgyLDMxNjMsMzQxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfbWFya2V0cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDUsODc2LDEwMDYsMTA0NywxMDg4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTVRBd01DQXpOakF3SURNeE5UTTJNREF3SURFd01EQXdJREV3TURBd01EQWdNakF3TURBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSjBiM1JoYkY5dFlYSnJaWFJ6SWlBd2VEWmtOakUzTWpaaU5qVTNORFZtSURCNE5XWWdJbUZrYldsdUlpQXdlRGN3Tm1ZMlpqWmpOek1nSW5Cc1lYUm1iM0p0WDJabFpYTWlJREI0TURBZ0ltMXBibDlzYVhGMWFXUnBkSGtpSURCNE56RTNOVFkxTnpNM05EWTVObVkyWlNBd2VEYzFOek0yTlRjeU5XWWdNSGcxWmpaa05qRTNNalppTmpVM05EVm1JREI0TmpNM01qWTFOakUzTkRabU56SWdNSGcxWmpjNU5qVTNNeUF3ZURWbU5tVTJaZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURNMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5UTmxOekEyT1dJZ01IZzVNR1k0WkRSbE9DQXdlR0UwTURReU1UTXlJREI0T1dSa1pEVmpabU1nTUhnNVlUVm1OekkzWmlBd2VEZzBaVEkyTUdFM0lEQjRPVGMxWVRVeU1Ua2dNSGhpTXpZMU1qUmtZeUF3ZUdVNVpEZG1OMkl5SURCNE1HWmxOVEprWm1JZ01IZzBabUkyWVdaa1l5QXdlRGhqT1dRMFlXSXhJREI0WVdSa1l6azJZV0lnTUhneFlUTmpOalkxTXlBd2VEY3lOemcxTXpGbElEQjROekl3TVRnNU5tWWdNSGhsWXpVNE9EQTNNU0F3ZURBek4yTmhPV1JrSURCNFltVmpNamxqWTJFZ01IZ3dOelV6TTJJNU5TQXdlR1kzWVRCbVpESTVJREI0TmpVMFl6bGhZV01nTUhoaE56SmlOV00xWkNBd2VEazFZMk5oT0RWa0lEQjRaakJpWVRrMVpUWWdNSGd5TkRneVlqZ3hNU0F3ZUdZeFkyTm1OelJqSURCNE5EYzFNVGhsTmpRZ01IaGxZemhoT0dWbVlpQXdlRE5sTlRnNVl6Y3lJREI0TjJVeE1HVTRZellnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbFgyRnVaRjlqY21WaGRHVmZabWx5YzNSZmJXRnlhMlYwS0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsS0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpWOXRZWEpyWlhRb2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNjR0Y1S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyMWhjbXRsZEY5eGRXVnpkR2x2YmloMWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmJXRnlhMlYwWDNCdmIyeHpLSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZiV0Z5YTJWMFgzTjBZWFIxY3loMWFXNTBOalFwS0dKdmIyd3NZbTl2YkNraUxDQnRaWFJvYjJRZ0ltTmhiR04xYkdGMFpWOTVaWE5mY0hKcFkyVW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVluVjVYM2xsYzE5emFHRnlaWE1vZFdsdWREWTBMSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1KMWVWOXViMTl6YUdGeVpYTW9kV2x1ZERZMExIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsYzI5c2RtVmZiV0Z5YTJWMEtIVnBiblEyTkN4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYjNSaGJGOXRZWEpyWlhSektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl3YkdGMFptOXliVjltWldWektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luZHBkR2hrY21GM1gyWmxaWE1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzVnpaWEpmYzJoaGNtVnpLR0ZqWTI5MWJuUXNkV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWNtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjlqYjI1MGNtRmpkRjlrWldKMVoxOXBibVp2S0Nrb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWx6WDJOdmJuUnlZV04wWDJsdWFYUnBZV3hwZW1Wa0tDbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZZMjl1ZEhKaFkzUmZjM1JoZEhWektDa29ZbTl2YkN4aFpHUnlaWE56TEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxektITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKallXNWZZM0psWVhSbFgyMWhjbXRsZENoaFkyTnZkVzUwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEY5eVpYRjFhWEpsWkY5d1lYbHRaVzUwWDJadmNsOXRZWEpyWlhRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWJXRnlhMlYwWDJWNGFYTjBjeWgxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYMjFoY210bGRGOWpjbVZoZEc5eUtIVnBiblEyTkNsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKemFXMTFiR0YwWlY5NVpYTmZkSEpoWkdVb2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbk5wYlhWc1lYUmxYMjV2WDNSeVlXUmxLSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZiV0Z5YTJWMFgyOWtaSE1vZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDNWelpYSmZjRzl6YVhScGIyNWZkbUZzZFdVb1lXTmpiM1Z1ZEN4MWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZlltOTRYMjVoYldWektIVnBiblEyTkNrb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0puWlhSZmRYTmxjbDlpYjNoZmJtRnRaWE1vWVdOamIzVnVkQ3gxYVc1ME5qUXBLSE4wY21sdVp5eHpkSEpwYm1jcElpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOTBjbUZrYVc1blgzQmhjbUZ0Y3loMWFXNTBOalFzZFdsdWREWTBLU2hpYjI5c0xITjBjbWx1WnlraUxDQnRaWFJvYjJRZ0ltZGxkRjloYkd4ZmJXRnlhMlYwYzE5emRXMXRZWEo1S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXBibWwwYVdGc2FYcGxYMkZ1WkY5amNtVmhkR1ZmWm1seWMzUmZiV0Z5YTJWMFgzSnZkWFJsUURVZ2JXRnBibDlqY21WaGRHVmZiV0Z5YTJWMFgzTnBiWEJzWlY5eWIzVjBaVUEySUcxaGFXNWZZM0psWVhSbFgyMWhjbXRsZEY5eWIzVjBaVUEzSUcxaGFXNWZaMlYwWDIxaGNtdGxkRjl4ZFdWemRHbHZibDl5YjNWMFpVQTRJRzFoYVc1ZloyVjBYMjFoY210bGRGOXdiMjlzYzE5eWIzVjBaVUE1SUcxaGFXNWZaMlYwWDIxaGNtdGxkRjl6ZEdGMGRYTmZjbTkxZEdWQU1UQWdiV0ZwYmw5allXeGpkV3hoZEdWZmVXVnpYM0J5YVdObFgzSnZkWFJsUURFeElHMWhhVzVmWW5WNVgzbGxjMTl6YUdGeVpYTmZjbTkxZEdWQU1USWdiV0ZwYmw5aWRYbGZibTlmYzJoaGNtVnpYM0p2ZFhSbFFERXpJRzFoYVc1ZmNtVnpiMngyWlY5dFlYSnJaWFJmY205MWRHVkFNVFFnYldGcGJsOW5aWFJmZEc5MFlXeGZiV0Z5YTJWMGMxOXliM1YwWlVBeE5TQnRZV2x1WDJkbGRGOXdiR0YwWm05eWJWOW1aV1Z6WDNKdmRYUmxRREUySUcxaGFXNWZkMmwwYUdSeVlYZGZabVZsYzE5eWIzVjBaVUF4TnlCdFlXbHVYMmRsZEY5MWMyVnlYM05vWVhKbGMxOXliM1YwWlVBeE9DQnRZV2x1WDNKbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOXliM1YwWlVBeE9TQnRZV2x1WDJkbGRGOWpiMjUwY21GamRGOWtaV0oxWjE5cGJtWnZYM0p2ZFhSbFFESXdJRzFoYVc1ZmFYTmZZMjl1ZEhKaFkzUmZhVzVwZEdsaGJHbDZaV1JmY205MWRHVkFNakVnYldGcGJsOW5aWFJmWTI5dWRISmhZM1JmYzNSaGRIVnpYM0p2ZFhSbFFESXlJRzFoYVc1ZmRtRnNhV1JoZEdWZlkzSmxZWFJsWDIxaGNtdGxkRjl3WVhKaGJYTmZjbTkxZEdWQU1qTWdiV0ZwYmw5allXNWZZM0psWVhSbFgyMWhjbXRsZEY5eWIzVjBaVUF5TkNCdFlXbHVYMmRsZEY5eVpYRjFhWEpsWkY5d1lYbHRaVzUwWDJadmNsOXRZWEpyWlhSZmNtOTFkR1ZBTWpVZ2JXRnBibDl0WVhKclpYUmZaWGhwYzNSelgzSnZkWFJsUURJMklHMWhhVzVmWjJWMFgyMWhjbXRsZEY5amNtVmhkRzl5WDNKdmRYUmxRREkzSUcxaGFXNWZjMmx0ZFd4aGRHVmZlV1Z6WDNSeVlXUmxYM0p2ZFhSbFFESTRJRzFoYVc1ZmMybHRkV3hoZEdWZmJtOWZkSEpoWkdWZmNtOTFkR1ZBTWprZ2JXRnBibDluWlhSZmJXRnlhMlYwWDI5a1pITmZjbTkxZEdWQU16QWdiV0ZwYmw5blpYUmZkWE5sY2w5d2IzTnBkR2x2Ymw5MllXeDFaVjl5YjNWMFpVQXpNU0J0WVdsdVgyZGxkRjlpYjNoZmJtRnRaWE5mY205MWRHVkFNeklnYldGcGJsOW5aWFJmZFhObGNsOWliM2hmYm1GdFpYTmZjbTkxZEdWQU16TWdiV0ZwYmw5MllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTl5YjNWMFpVQXpOQ0J0WVdsdVgyZGxkRjloYkd4ZmJXRnlhMlYwYzE5emRXMXRZWEo1WDNKdmRYUmxRRE0xQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16ZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5aGJHeGZiV0Z5YTJWMGMxOXpkVzF0WVhKNVgzSnZkWFJsUURNMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOek00Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWVd4c1gyMWhjbXRsZEhOZmMzVnRiV0Z5ZVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGMxOXliM1YwWlVBek5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSFpoYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOTFjMlZ5WDJKdmVGOXVZVzFsYzE5eWIzVjBaVUF6TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3dOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNNRFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZFhObGNsOWliM2hmYm1GdFpYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkp2ZUY5dVlXMWxjMTl5YjNWMFpVQXpNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZNU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZNU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdkbGRGOWliM2hmYm1GdFpYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM1Z6WlhKZmNHOXphWFJwYjI1ZmRtRnNkV1ZmY205MWRHVkFNekU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk56WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qYzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM1Z6WlhKZmNHOXphWFJwYjI1ZmRtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDIxaGNtdGxkRjl2WkdSelgzSnZkWFJsUURNd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaMlYwWDIxaGNtdGxkRjl2WkdSekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOcGJYVnNZWFJsWDI1dlgzUnlZV1JsWDNKdmRYUmxRREk1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qTTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qTTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2MybHRkV3hoZEdWZmJtOWZkSEpoWkdVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJsdGRXeGhkR1ZmZVdWelgzUnlZV1JsWDNKdmRYUmxRREk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qRXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qRXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2MybHRkV3hoZEdWZmVXVnpYM1J5WVdSbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXRZWEpyWlhSZlkzSmxZWFJ2Y2w5eWIzVjBaVUF5TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXdNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXdNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl0WVhKclpYUmZZM0psWVhSdmNnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dFlYSnJaWFJmWlhocGMzUnpYM0p2ZFhSbFFESTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRreENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRreENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYldGeWEyVjBYMlY0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZjbVZ4ZFdseVpXUmZjR0Y1YldWdWRGOW1iM0pmYldGeWEyVjBYM0p2ZFhSbFFESTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRnMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmNtVnhkV2x5WldSZmNHRjViV1Z1ZEY5bWIzSmZiV0Z5YTJWMENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJsOWpjbVZoZEdWZmJXRnlhMlYwWDNKdmRYUmxRREkwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UZ3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTRNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHTmhibDlqY21WaGRHVmZiV0Z5YTJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNaaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxelgzSnZkWFJsUURJek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFl5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTJNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlIWmhiR2xrWVhSbFgyTnlaV0YwWlY5dFlYSnJaWFJmY0dGeVlXMXpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGRYTmZjbTkxZEdWQU1qSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5amIyNTBjbUZqZEY5emRHRjBkWE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhWE5mWTI5dWRISmhZM1JmYVc1cGRHbGhiR2w2WldSZmNtOTFkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFORGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHbHpYMk52Ym5SeVlXTjBYMmx1YVhScFlXeHBlbVZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5amIyNTBjbUZqZEY5a1pXSjFaMTlwYm1adlgzSnZkWFJsUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVE0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWTI5dWRISmhZM1JmWkdWaWRXZGZhVzVtYndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldSbFpXMWZkMmx1Ym1sdVoxOXphR0Z5WlhOZmNtOTFkR1ZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPRGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPRGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNWelpYSmZjMmhoY21WelgzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEyTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MWMyVnlYM05vWVhKbGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5M2FYUm9aSEpoZDE5bVpXVnpYM0p2ZFhSbFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUIzYVhSb1pISmhkMTltWldWekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXdiR0YwWm05eWJWOW1aV1Z6WDNKdmRYUmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZjR3hoZEdadmNtMWZabVZsY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRHOTBZV3hmYldGeWEyVjBjMTl5YjNWMFpVQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzUnZkR0ZzWDIxaGNtdGxkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjbVZ6YjJ4MlpWOXRZWEpyWlhSZmNtOTFkR1ZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaWE52YkhabFgyMWhjbXRsZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpZFhsZmJtOWZjMmhoY21WelgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNek0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaWRYbGZibTlmYzJoaGNtVnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySjFlVjk1WlhOZmMyaGhjbVZ6WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qWXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TmpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZFhsZmVXVnpYM05vWVhKbGN3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5allXeGpkV3hoZEdWZmVXVnpYM0J5YVdObFgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxYM2xsYzE5d2NtbGpaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYldGeWEyVjBYM04wWVhSMWMxOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl5TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl5TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5dFlYSnJaWFJmYzNSaGRIVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl0WVhKclpYUmZjRzl2YkhOZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl0WVhKclpYUmZjRzl2YkhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyMWhjbXRsZEY5eGRXVnpkR2x2Ymw5eWIzVjBaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjFoY210bGRGOXhkV1Z6ZEdsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxYMjFoY210bGRGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFkxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxYMjFoY210bGRBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmYldGeWEyVjBYM05wYlhCc1pWOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxYMjFoY210bGRGOXphVzF3YkdVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1cGRHbGhiR2w2WlY5aGJtUmZZM0psWVhSbFgyWnBjbk4wWDIxaGNtdGxkRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdsdWFYUnBZV3hwZW1WZllXNWtYMk55WldGMFpWOW1hWEp6ZEY5dFlYSnJaWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURNMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek9Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVhVzVwZEdsaGJHbDZaVjloYm1SZlkzSmxZWFJsWDJacGNuTjBYMjFoY210bGRDaHhkV1Z6ZEdsdmJqb2dZbmwwWlhNc0lISmxjMjlzZFhScGIyNWZkR2x0WlRvZ2RXbHVkRFkwTENCbVpXVmZjbUYwWlRvZ2RXbHVkRFkwTENCd1lYbHRaVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS2FXNXBkR2xoYkdsNlpWOWhibVJmWTNKbFlYUmxYMlpwY25OMFgyMWhjbXRsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVMVFEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnBibWwwYVdGc2FYcGxYMkZ1WkY5amNtVmhkR1ZmWm1seWMzUmZiV0Z5YTJWMEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdjWFZsYzNScGIyNDZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0J5WlhOdmJIVjBhVzl1WDNScGJXVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JtWldWZmNtRjBaVG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUxTFRVMkNpQWdJQ0F2THlBaklFRjFkRzh0YVc1cGRHbGhiR2w2WlNCcFppQnViM1FnWkc5dVpTQjVaWFFLSUNBZ0lDOHZJR2xtSUhObGJHWXVZV1J0YVc0dWRtRnNkV1V1WW5sMFpYTWdQVDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3k1aWVYUmxjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0o2SUdsdWFYUnBZV3hwZW1WZllXNWtYMk55WldGMFpWOW1hWEp6ZEY5dFlYSnJaWFJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTndvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyMWhjbXRsZEhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luQnNZWFJtYjNKdFgyWmxaWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCelpXeG1MbTFwYmw5c2FYRjFhV1JwZEhrdWRtRnNkV1VnUFNCVlNXNTBOalFvTVRBd01EQXdNQ2tnSUNNZ01TQkJURWRQSUdSbFptRjFiSFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTFwYmw5c2FYRjFhV1JwZEhraUNpQWdJQ0JwYm5SaklEY2dMeThnTVRBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ21sdWFYUnBZV3hwZW1WZllXNWtYMk55WldGMFpWOW1hWEp6ZEY5dFlYSnJaWFJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJdE5qTUtJQ0FnSUM4dklDTWdWbUZzYVdSaGRHVWdZMkZzYkdWeUlHbHpJR0ZrYldsdUwyTnlaV0YwYjNJS0lDQWdJQzh2SUdselgyTnlaV0YwYjNJZ1BTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56SUQwOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCcGMxOWhaRzFwYmlBOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ1BUMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZZM0psWVhSdmNpQnZjaUJwYzE5aFpHMXBiaXdnSWtWU1VrOVNYekV3TVRvZ1QyNXNlU0JqY21WaGRHOXlMMkZrYldsdUlHTmhiaUJqY21WaGRHVWdiV0Z5YTJWMGN5SUtJQ0FnSUh4OENpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEF4T2lCUGJteDVJR055WldGMGIzSXZZV1J0YVc0Z1kyRnVJR055WldGMFpTQnRZWEpyWlhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOeTAyT0FvZ0lDQWdMeThnSXlCVGFXMXdiR1VnZG1Gc2FXUmhkR2x2Ym5NS0lDQWdJQzh2SUdGemMyVnlkQ0JtWldWZmNtRjBaU0E4UFNCVlNXNTBOalFvTVRBd01Da3NJQ0pGVWxKUFVsOHhNREk2SUVabFpTQnlZWFJsSUcxaGVDQXhNQ1VnS0RFd01EQXBJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURJNklFWmxaU0J5WVhSbElHMWhlQ0F4TUNVZ0tERXdNREFwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lrVlNVazlTWHpFd016b2dVR0Y1YldWdWRDQnRkWE4wSUdkdklGUlBJR052Ym5SeVlXTjBJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTVRBek9pQlFZWGx0Wlc1MElHMTFjM1FnWjI4Z1ZFOGdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdWVWx1ZERZMEtESXdNREF3TURBcExDQWlSVkpTVDFKZk1UQTBPaUJPWldWa0lHRjBJR3hsWVhOMElESWdRVXhIVHlBb01qQXdNREF3TUNCdGFXTnliMEZzWjI5ektTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TURBd01EQXdDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VrOVNYekV3TkRvZ1RtVmxaQ0JoZENCc1pXRnpkQ0F5SUVGTVIwOGdLREl3TURBd01EQWdiV2xqY205QmJHZHZjeWtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCaGMzTmxjblFnY21WemIyeDFkR2x2Ymw5MGFXMWxJRDRnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJWU1c1ME5qUW9Nell3TUNrc0lDSkZVbEpQVWw4eE1EVTZJRkpsYzI5c2RYUnBiMjRnZEdsdFpTQnRkWE4wSUdKbElERXJJR2h2ZFhKeklHWnliMjBnYm05M0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFl5QTBJQzh2SURNMk1EQUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd05Ub2dVbVZ6YjJ4MWRHbHZiaUIwYVcxbElHMTFjM1FnWW1VZ01Tc2dhRzkxY25NZ1puSnZiU0J1YjNjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnpiMngxZEdsdmJsOTBhVzFsSUR3OUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUNzZ1ZVbHVkRFkwS0RNeE5UTTJNREF3S1N3Z0lrVlNVazlTWHpFd05qb2dVbVZ6YjJ4MWRHbHZiaUIwYVcxbElHMWhlQ0F4SUhsbFlYSWdabkp2YlNCdWIzY2lDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpJRFVnTHk4Z016RTFNell3TURBS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURZNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdFlYZ2dNU0I1WldGeUlHWnliMjBnYm05M0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdiV0Z5YTJWMFgybGtJRDBnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYldGeWEyVjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjM0xUYzRDaUFnSUNBdkx5QWpJRk4wYjNKbElHMWhjbXRsZENCeGRXVnpkR2x2YmdvZ0lDQWdMeThnY1hWbGMzUnBiMjVmWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp4ZFdWemRHbHZiaUlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGczTVRjMU5qVTNNemMwTmprMlpqWmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCeGRXVnpkR2x2Ymw5aWIzZ3VjSFYwS0hGMVpYTjBhVzl1TG1KNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE1TMDRNZ29nSUNBZ0x5OGdJeUJUZEc5eVpTQnRZWEpyWlhRZ2NHOXZiSE1nWVc1a0lHMWxkR0ZrWVhSaENpQWdJQ0F2THlCcGJtbDBhV0ZzWDNCdmIyd2dQU0J3WVhsdFpXNTBMbUZ0YjNWdWRDQXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE5DMDROUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2JtOWZjRzl2YkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0lDQWdJQ01nZEc5MFlXeGZkbTlzZFcxbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9EUXRPRFlLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCNVpYTmZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklHNXZYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1NBcklDQWdJQ0FnSUNBZ0l5QjBiM1JoYkY5MmIyeDFiV1VLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJJQ0FnSUNBZ0lDQWdJQ01nWm1WbFgzSmhkR1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2T0RRdE9EY0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUI1WlhOZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUc1dlgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWdJQ0FnSXlCMGIzUmhiRjkyYjJ4MWJXVUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2dJQ0FnSUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzZ0lDQWpJSEpsYzI5c2RYUnBiMjVmZEdsdFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzROQzA0T0FvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklIbGxjMTl3YjI5c0NpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdibTlmY0c5dmJBb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2dJQ0FnSUNBZ0lDQWpJSFJ2ZEdGc1gzWnZiSFZ0WlFvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lBZ0lDQWdJQ0FnSUNBaklHWmxaVjl5WVhSbENpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3lBZ0lDTWdjbVZ6YjJ4MWRHbHZibDkwYVcxbENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamcwTFRnNUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdlV1Z6WDNCdmIyd0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUJ1YjE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0lDQWdJQ01nZEc5MFlXeGZkbTlzZFcxbENpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBcklDQWdJQ0FnSUNBZ0lDTWdabVZsWDNKaGRHVUtJQ0FnSUM4dklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBcklDQWdJeUJ5WlhOdmJIVjBhVzl1WDNScGJXVUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTQXJJQ0FnSUNBZ0lDQWdJeUJwYzE5eVpYTnZiSFpsWkNBb01EMUdZV3h6WlNrS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamd6TFRreENpQWdJQ0F2THlCd2IyOXNjMTlrWVhSaElEMGdLQW9nSUNBZ0x5OGdJQ0FnSUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FnSUNBZ0l5QjVaWE5mY0c5dmJBb2dJQ0FnTHk4Z0lDQWdJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCdWIxOXdiMjlzQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2dJQ0FnSUNBZ0lDQWpJSFJ2ZEdGc1gzWnZiSFZ0WlFvZ0lDQWdMeThnSUNBZ0lHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2dJQ0FnSUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ0x5OGdJQ0FnSUc5d0xtbDBiMklvY21WemIyeDFkR2x2Ymw5MGFXMWxLU0FySUNBZ0l5QnlaWE52YkhWMGFXOXVYM1JwYldVS0lDQWdJQzh2SUNBZ0lDQnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0lDQWdJQ01nYVhOZmNtVnpiMngyWldRZ0tEQTlSbUZzYzJVcENpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ0FnSUNBZ0lDQWdJQ0FqSUhkcGJtNXBibWRmYjNWMFkyOXRaU0FvTUQxT2J5d2dNVDFaWlhNcENpQWdJQ0F2THlBcENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzROQzA1TUFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklIbGxjMTl3YjI5c0NpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdibTlmY0c5dmJBb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2dJQ0FnSUNBZ0lDQWpJSFJ2ZEdGc1gzWnZiSFZ0WlFvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lBZ0lDQWdJQ0FnSUNBaklHWmxaVjl5WVhSbENpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3lBZ0lDTWdjbVZ6YjJ4MWRHbHZibDkwYVcxbENpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdhWE5mY21WemIyeDJaV1FnS0RBOVJtRnNjMlVwQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnSUNBZ0lDQWdJQ0FnSUNNZ2QybHVibWx1WjE5dmRYUmpiMjFsSUNnd1BVNXZMQ0F4UFZsbGN5a0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUhCdmIyeHpYMkp2ZUNBOUlFSnZlRkpsWmloclpYazliV0Z5YTJWMFgzQnlaV1pwZUNBcklHSWljRzl2YkhNaUtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzNNRFptTm1ZMll6Y3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCd2IyOXNjMTlpYjNndWNIVjBLSEJ2YjJ4elgyUmhkR0VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzVOUzA1TmdvZ0lDQWdMeThnSXlCVGRHOXlaU0JqY21WaGRHOXlDaUFnSUNBdkx5QmpjbVZoZEc5eVgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWJXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaVkzSmxZWFJ2Y2lJcENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEWXpOekkyTlRZeE56UTJaamN5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QmpjbVZoZEc5eVgySnZlQzV3ZFhRb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVZ1BTQnRZWEpyWlhSZmFXUWdLeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUcxaGNtdGxkRjlwWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbU55WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsS0hGMVpYTjBhVzl1T2lCaWVYUmxjeXdnY21WemIyeDFkR2x2Ymw5MGFXMWxPaUIxYVc1ME5qUXNJR1psWlY5eVlYUmxPaUIxYVc1ME5qUXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BqY21WaGRHVmZiV0Z5YTJWMFgzTnBiWEJzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdNaTB4TURrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2NYVmxjM1JwYjI0NklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhWMGFXOXVYM1JwYldVNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1ZmY21GMFpUb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUxBb2dJQ0FnTHk4Z0tTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1URTNMVEV4T0FvZ0lDQWdMeThnSXlCQmRYUnZMV2x1YVhScFlXeHBlbVVnYjI0Z1ptbHljM1FnZFhObENpQWdJQ0F2THlCcFppQnpaV3htTG1Ga2JXbHVMblpoYkhWbExtSjVkR1Z6SUQwOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXVZbmwwWlhNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaWVpQmpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjlsYkhObFgySnZaSGxBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z2MyVnNaaTV3YkdGMFptOXliVjltWldWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd2JHRjBabTl5YlY5bVpXVnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUdsbUlITmxiR1l1YldsdVgyeHBjWFZwWkdsMGVTNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01DazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJXbHVYMnhwY1hWcFpHbDBlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVJR1Y0YVhOMGN3b2dJQ0FnWW01NklHTnlaV0YwWlY5dFlYSnJaWFJmYzJsdGNHeGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJ6Wld4bUxtMXBibDlzYVhGMWFXUnBkSGt1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NVjh3TURCZk1EQXdLU0FnSXlBeElFRk1SMDhnWkdWbVlYVnNkQW9nSUNBZ1lubDBaV01nT0NBdkx5QWliV2x1WDJ4cGNYVnBaR2wwZVNJS0lDQWdJR2x1ZEdNZ055QXZMeUF4TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWTNKbFlYUmxYMjFoY210bGRGOXphVzF3YkdWZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USTNMVEV5T0FvZ0lDQWdMeThnSXlCV1lXeHBaR0YwWlNCcGJuQjFkSE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQm1aV1ZmY21GMFpTQThQU0JWU1c1ME5qUW9NVEF3TUNrc0lDSkZVbEpQVWw4eE1ESTZJRVpsWlNCeVlYUmxJRzFoZUNBeE1DVWdLREV3TURBcElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHhNREk2SUVabFpTQnlZWFJsSUcxaGVDQXhNQ1VnS0RFd01EQXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKRlVsSlBVbDh4TURNNklGQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCVVR5QmpiMjUwY21GamRDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VrOVNYekV3TXpvZ1VHRjViV1Z1ZENCdGRYTjBJR2R2SUZSUElHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQW9jMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVMblpoYkhWbElDb2dWVWx1ZERZMEtESXBLU3dnSWtWU1VrOVNYekV3TkRvZ1RtVmxaQ0JoZENCc1pXRnpkQ0F5SUNvZ2JXbHVYMnhwY1hWcFpHbDBlU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW0xcGJsOXNhWEYxYVdScGRIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldsdVgyeHBjWFZwWkdsMGVTQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd05Eb2dUbVZsWkNCaGRDQnNaV0Z6ZENBeUlDb2diV2x1WDJ4cGNYVnBaR2wwZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHbG1JSFFnUGlCVlNXNTBOalFvTVRCZk1EQXdYekF3TUY4d01EQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNREF3TURBd0lDOHZJREV3TURBd01EQXdNREF3Q2lBZ0lDQStDaUFnSUNCaWVpQmpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkQ0F2THlCVlNXNTBOalFvTVRBd01Da0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQUtJQ0FnSUM4S0NtTnlaV0YwWlY5dFlYSnJaWFJmYzJsdGNHeGxYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTGw5MGIxOXpaV052Ym1SelFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhOZmRHbHRaVjl6WldNZ1BpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklGVkpiblEyTkNnek5qQXdLU3dnSWtWU1VrOVNYekV3TlRvZ1VtVnpiMngxZEdsdmJpQjBhVzFsSUcxMWMzUWdZbVVnTVNzZ2FHOTFjbk1nWm5KdmJTQnViM2NpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqSURRZ0x5OGdNell3TUFvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURVNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdGRYTjBJR0psSURFcklHaHZkWEp6SUdaeWIyMGdibTkzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTmZkR2x0WlY5elpXTWdQRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJWU1c1ME5qUW9NekUxTXpZd01EQXBMQ0FpUlZKU1QxSmZNVEEyT2lCU1pYTnZiSFYwYVc5dUlIUnBiV1VnYldGNElERWdlV1ZoY2lCbWNtOXRJRzV2ZHlJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF6TVRVek5qQXdNQW9nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEEyT2lCU1pYTnZiSFYwYVc5dUlIUnBiV1VnYldGNElERWdlV1ZoY2lCbWNtOXRJRzV2ZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UTTJMVEV6TndvZ0lDQWdMeThnSXlCRGNtVmhkR1VnYldGeWEyVjBDaUFnSUNBdkx5QnRZWEpyWlhSZmFXUWdQU0J6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMjFoY210bGRITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME1DMHhOREVLSUNBZ0lDOHZJQ01nVTNSdmNtVWdiV0Z5YTJWMElIRjFaWE4wYVc5dUNpQWdJQ0F2THlCeGRXVnpkR2x2Ymw5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFcxaGNtdGxkRjl3Y21WbWFYZ2dLeUJpSW5GMVpYTjBhVzl1SWlrS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURjeE56VTJOVGN6TnpRMk9UWm1ObVVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUXlDaUFnSUNBdkx5QnhkV1Z6ZEdsdmJsOWliM2d1Y0hWMEtIRjFaWE4wYVc5dUxtSjVkR1Z6S1FvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hORFF0TVRRMUNpQWdJQ0F2THlBaklGTjBiM0psSUcxaGNtdGxkQ0J3YjI5c2N5QmhibVFnYldWMFlXUmhkR0VLSUNBZ0lDOHZJR2x1YVhScFlXeGZjRzl2YkNBOUlIQmhlVzFsYm5RdVlXMXZkVzUwSUM4dklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0lDQWdJQ01nZVdWelgzQnZiMndLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME55MHhORGdLSUNBZ0lDOHZJRzl3TG1sMGIySW9hVzVwZEdsaGJGOXdiMjlzS1NBcklDQWdJQ0FnSXlCNVpYTmZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ0FnSUNBaklHNXZYM0J2YjJ3S0lDQWdJR1IxY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWdJQ0FnSXlCMGIzUmhiRjkyYjJ4MWJXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hORGN0TVRRNUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdlV1Z6WDNCdmIyd0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUJ1YjE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0lDQWdJQ01nZEc5MFlXeGZkbTlzZFcxbENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzZ0lDQWdJQ0FnSUNBZ0l5Qm1aV1ZmY21GMFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hORGN0TVRVd0NpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSUNBZ0lDTWdlV1Z6WDNCdmIyd0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUJ1YjE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0lDQWdJQ01nZEc5MFlXeGZkbTlzZFcxbENpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBcklDQWdJQ0FnSUNBZ0lDTWdabVZsWDNKaGRHVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMxOTBhVzFsWDNObFl5a2dLeUFnSUNBZ0lDTWdjbVZ6YjJ4MWRHbHZibDkwYVcxbElDaHpaV052Ym1SektRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5EY3RNVFV4Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FnSUNBZ0l5QnViMTl3YjI5c0NpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FySUNBZ0lDQWdJQ0FnSUNNZ1ptVmxYM0poZEdVS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WelgzUnBiV1ZmYzJWaktTQXJJQ0FnSUNBZ0l5QnlaWE52YkhWMGFXOXVYM1JwYldVZ0tITmxZMjl1WkhNcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUwTnkweE5USUtJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBZ0lDQWdJeUI1WlhOZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUc1dlgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWdJQ0FnSXlCMGIzUmhiRjkyYjJ4MWJXVUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2dJQ0FnSUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ0lDQWdJQ0FqSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0FvYzJWamIyNWtjeWtLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWdJQ0FnSXlCcGMxOXlaWE52YkhabFpDQW9NRDFHWVd4elpTa0tJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME5pMHhOVFFLSUNBZ0lDOHZJSEJ2YjJ4elgyUmhkR0VnUFNBb0NpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDQWdJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNBZ0lDQWpJRzV2WDNCdmIyd0tJQ0FnSUM4dklDQWdJQ0J2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lBZ0lDQWdJQ0FnSUNNZ2RHOTBZV3hmZG05c2RXMWxDaUFnSUNBdkx5QWdJQ0FnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lBZ0lDQWdJQ0FnSUNBaklHWmxaVjl5WVhSbENpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaHlaWE5mZEdsdFpWOXpaV01wSUNzZ0lDQWdJQ0FqSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0FvYzJWamIyNWtjeWtLSUNBZ0lDOHZJQ0FnSUNCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdhWE5mY21WemIyeDJaV1FnS0RBOVJtRnNjMlVwQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDQWdJQ0FnSUNBZ0lDQWpJSGRwYm01cGJtZGZiM1YwWTI5dFpTQW9NRDFPYnl3Z01UMVpaWE1wQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5EY3RNVFV6Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJQ0FnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FnSUNBZ0l5QnViMTl3YjI5c0NpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FySUNBZ0lDQWdJQ0FnSUNNZ1ptVmxYM0poZEdVS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WelgzUnBiV1ZmYzJWaktTQXJJQ0FnSUNBZ0l5QnlaWE52YkhWMGFXOXVYM1JwYldVZ0tITmxZMjl1WkhNcENpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrZ0t5QWdJQ0FnSUNBZ0lDTWdhWE5mY21WemIyeDJaV1FnS0RBOVJtRnNjMlVwQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnSUNBZ0lDQWdJQ0FnSUNNZ2QybHVibWx1WjE5dmRYUmpiMjFsSUNnd1BVNXZMQ0F4UFZsbGN5a0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVMUNpQWdJQ0F2THlCd2IyOXNjMTlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkJ2YjJ4eklpa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekEyWmpabU5tTTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5UWUtJQ0FnSUM4dklIQnZiMnh6WDJKdmVDNXdkWFFvY0c5dmJITmZaR0YwWVNrS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUxT0MweE5Ua0tJQ0FnSUM4dklDTWdVM1J2Y21VZ1kzSmxZWFJ2Y2dvZ0lDQWdMeThnWTNKbFlYUnZjbDlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbU55WldGMGIzSWlLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGcyTXpjeU5qVTJNVGMwTm1ZM01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUdOeVpXRjBiM0pmWW05NExuQjFkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZeUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VnUFNCdFlYSnJaWFJmYVdRZ0t5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUyTXdvZ0lDQWdMeThnY21WMGRYSnVJRzFoY210bGRGOXBaQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwamNtVmhkR1ZmYldGeWEyVjBYM05wYlhCc1pWOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpNZ29nSUNBZ0x5OGdjbVZ6WDNScGJXVmZjMlZqSUQwZ2MyVnNaaTVmZEc5ZmMyVmpiMjVrY3loeVpYTnZiSFYwYVc5dVgzUnBiV1VwQ2lBZ0lDQmlJR055WldGMFpWOXRZWEpyWlhSZmMybHRjR3hsWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExsOTBiMTl6WldOdmJtUnpRRGtLQ21OeVpXRjBaVjl0WVhKclpYUmZjMmx0Y0d4bFgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlSVkpTVDFKZk1UQXhPaUJQYm14NUlHRmtiV2x1SUdOaGJpQmpjbVZoZEdVZ2JXRnlhMlYwY3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTVRBeE9pQlBibXg1SUdGa2JXbHVJR05oYmlCamNtVmhkR1VnYldGeWEyVjBjd29nSUNBZ1lpQmpjbVZoZEdWZmJXRnlhMlYwWDNOcGJYQnNaVjloWm5SbGNsOXBabDlsYkhObFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WTNKbFlYUmxYMjFoY210bGRDaHhkV1Z6ZEdsdmJqb2dZbmwwWlhNc0lISmxjMjlzZFhScGIyNWZkR2x0WlRvZ2RXbHVkRFkwTENCbVpXVmZjbUYwWlRvZ2RXbHVkRFkwTENCd1lYbHRaVzUwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1kzSmxZWFJsWDIxaGNtdGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFMk5TMHhOeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHTnlaV0YwWlY5dFlYSnJaWFFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCeGRXVnpkR2x2YmpvZ1UzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lISmxjMjlzZFhScGIyNWZkR2x0WlRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVjl5WVhSbE9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0c0NpQWdJQ0F2THlBcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UYzBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlM1aWVYUmxjeUFoUFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxtSjVkR1Z6TENBaVJWSlNUMUpmTVRBd09pQkRiMjUwY21GamRDQnViM1FnYVc1cGRHbGhiR2w2WldRZ0xTQjFjMlVnYVc1cGRHbGhiR2w2WlY5aGJtUmZZM0psWVhSbFgyWnBjbk4wWDIxaGNtdGxkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdNRG9nUTI5dWRISmhZM1FnYm05MElHbHVhWFJwWVd4cGVtVmtJQzBnZFhObElHbHVhWFJwWVd4cGVtVmZZVzVrWDJOeVpXRjBaVjltYVhKemRGOXRZWEpyWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTNOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWtWU1VrOVNYekV3TVRvZ1QyNXNlU0JoWkcxcGJpQmpZVzRnWTNKbFlYUmxJRzFoY210bGRITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6RXdNVG9nVDI1c2VTQmhaRzFwYmlCallXNGdZM0psWVhSbElHMWhjbXRsZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdZWE56WlhKMElHWmxaVjl5WVhSbElEdzlJRlZKYm5RMk5DZ3hNREF3S1N3Z0lrVlNVazlTWHpFd01qb2dSbVZsSUhKaGRHVWdiV0Y0SURFd0pTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEF5T2lCR1pXVWdjbUYwWlNCdFlYZ2dNVEFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSkZVbEpQVWw4eE1ETTZJRkJoZVcxbGJuUWdiWFZ6ZENCbmJ5QlVUeUJqYjI1MGNtRmpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd016b2dVR0Y1YldWdWRDQnRkWE4wSUdkdklGUlBJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TnpnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStQU0JWU1c1ME5qUW9NakF3TURBd01Da3NJQ0pGVWxKUFVsOHhNRFE2SUU1bFpXUWdZWFFnYkdWaGMzUWdNaUJCVEVkUElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBNElDOHZJREl3TURBd01EQUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEEwT2lCT1pXVmtJR0YwSUd4bFlYTjBJRElnUVV4SFR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ6YjJ4MWRHbHZibDkwYVcxbElENGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ0t5QlZTVzUwTmpRb016WXdNQ2tzSUNKRlVsSlBVbDh4TURVNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdGRYTjBJR0psSURFcklHaHZkWEp6SUdaeWIyMGdibTkzSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWXlBMElDOHZJRE0yTURBS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VrOVNYekV3TlRvZ1VtVnpiMngxZEdsdmJpQjBhVzFsSUcxMWMzUWdZbVVnTVNzZ2FHOTFjbk1nWm5KdmJTQnViM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFNE1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0E4UFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUZWSmJuUTJOQ2d6TVRVek5qQXdNQ2tzSUNKRlVsSlBVbDh4TURZNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdFlYZ2dNU0I1WldGeUlHWnliMjBnYm05M0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFl5QTFJQzh2SURNeE5UTTJNREF3Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNVEEyT2lCU1pYTnZiSFYwYVc5dUlIUnBiV1VnYldGNElERWdlV1ZoY2lCbWNtOXRJRzV2ZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UZ3lDaUFnSUNBdkx5QnRZWEpyWlhSZmFXUWdQU0J6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMjFoY210bGRITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKeGRXVnpkR2x2YmlJcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnM01UYzFOalUzTXpjME5qazJaalpsQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdjWFZsYzNScGIyNWZZbTk0TG5CMWRDaHhkV1Z6ZEdsdmJpNWllWFJsY3lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUJwYm1sMGFXRnNYM0J2YjJ3Z1BTQndZWGx0Wlc1MExtRnRiM1Z1ZENBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE9UQUtJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1Ua3dMVEU1TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2diM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1Ua3dMVEU1TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc2diM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU0T1MweE9USUtJQ0FnSUM4dklIQnZiMnh6WDJSaGRHRWdQU0FvQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NLSUNBZ0lDOHZJQ0FnSUNCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBcklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBcklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTQXJJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLUW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRrd0xURTVNUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzZ2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDc2diM0F1YVhSdllpaFZTVzUwTmpRb01Da3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFNU13b2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ3VjSFYwS0hCdmIyeHpYMlJoZEdFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUdOeVpXRjBiM0pmWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUpqY21WaGRHOXlJaWtLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TmpNM01qWTFOakUzTkRabU56SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCamNtVmhkRzl5WDJKdmVDNXdkWFFvVkhodUxuTmxibVJsY2k1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFNU9Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsSUQwZ2JXRnlhMlYwWDJsa0lDc2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiV0Z5YTJWMGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURBS0lDQWdJQzh2SUhKbGRIVnliaUJ0WVhKclpYUmZhV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNW5aWFJmYldGeWEyVjBYM0YxWlhOMGFXOXVLRzFoY210bGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWjJWMFgyMWhjbXRsZEY5eGRXVnpkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdNaTB5TURNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5dFlYSnJaWFJmY1hWbGMzUnBiMjRvYzJWc1ppd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakExQ2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklIRjFaWE4wYVc5dVgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWJXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaWNYVmxjM1JwYjI0aUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEY3hOelUyTlRjek56UTJPVFptTm1VS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjWFZsYzNScGIyNWZZbTk0TG14bGJtZDBhQ0ErSURBc0lDSk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklIRjFaWE4wYVc5dVgySjVkR1Z6TENCZlpYaHBjM1J6SUQwZ2NYVmxjM1JwYjI1ZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpFd0NpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vY1hWbGMzUnBiMjVmWW5sMFpYTXBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYMjFoY210bGRGOXdiMjlzY3lodFlYSnJaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl0WVhKclpYUmZjRzl2YkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNVEl0TWpFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmJXRnlhMlYwWDNCdmIyeHpLSE5sYkdZc0lHMWhjbXRsZEY5cFpEb2dWVWx1ZERZMEtTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVWVWx1ZERZMExDQmhjbU0wTGxWSmJuUTJOQ3dnWVhKak5DNVZTVzUwTmpSZE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1UVUtJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl4TmdvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVRjS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjI5c2MxOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2NHOXZiSE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSEJ2YjJ4elgySnZlQzV0WVhsaVpTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeU1Rb2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXlNZ29nSUNBZ0x5OGdibTlmY0c5dmJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvT0Nrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TWpNS0lDQWdJQzh2SUhSdmRHRnNYM1p2YkhWdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTVRZcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVWU1c1ME5qUW9lV1Z6WDNCdmIyd3BMQ0JoY21NMExsVkpiblEyTkNodWIxOXdiMjlzS1N3Z1lYSmpOQzVWU1c1ME5qUW9kRzkwWVd4ZmRtOXNkVzFsS1NrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtZGxkRjl0WVhKclpYUmZjM1JoZEhWektHMWhjbXRsZEY5cFpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwWDIxaGNtdGxkRjl6ZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TWpjdE1qSTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZiV0Z5YTJWMFgzTjBZWFIxY3loelpXeG1MQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVVZFhCc1pWdGhjbU0wTGtKdmIyd3NJR0Z5WXpRdVFtOXZiRjA2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnYldGeWEyVjBYM0J5WldacGVDQTlJR0lpYldGeWEyVjBYeUlnS3lCdmNDNXBkRzlpS0cxaGNtdGxkRjlwWkNrZ0t5QmlJbDhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qTXhDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFcxaGNtdGxkRjl3Y21WbWFYZ2dLeUJpSW5CdmIyeHpJaWtLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGczTURabU5tWTJZemN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdZWE56WlhKMElIQnZiMnh6WDJKdmVDNXNaVzVuZEdnZ1BpQXdMQ0FpVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMElnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJ3YjI5c2MxOWtZWFJoTENCZlpYaHBjM1J6SUQwZ2NHOXZiSE5mWW05NExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNak0yQ2lBZ0lDQXZMeUJwYzE5eVpYTnZiSFpsWkY5MllXd2dQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RRd0tTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME1DQXZMeUEwTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdkMmx1Ym1sdVoxOXZkWFJqYjIxbFgzWmhiQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb05EZ3BMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQTBPQ0F2THlBME9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkwTUFvZ0lDQWdMeThnWVhKak5DNUNiMjlzS0dselgzSmxjMjlzZG1Wa1gzWmhiQ0E5UFNCVlNXNTBOalFvTVNrcExBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpReENpQWdJQ0F2THlCaGNtTTBMa0p2YjJ3b2QybHVibWx1WjE5dmRYUmpiMjFsWDNaaGJDQTlQU0JWU1c1ME5qUW9NU2twQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNemt0TWpReUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1Q2IyOXNLR2x6WDNKbGMyOXNkbVZrWDNaaGJDQTlQU0JWU1c1ME5qUW9NU2twTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UW05dmJDaDNhVzV1YVc1blgyOTFkR052YldWZmRtRnNJRDA5SUZWSmJuUTJOQ2d4S1NrS0lDQWdJQzh2SUNrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WTJGc1kzVnNZWFJsWDNsbGMxOXdjbWxqWlNodFlYSnJaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncGpZV3hqZFd4aGRHVmZlV1Z6WDNCeWFXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpRMExUSTBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1kyRnNZM1ZzWVhSbFgzbGxjMTl3Y21salpTaHpaV3htTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU5EY0tJQ0FnSUM4dklIQnZiMnh6SUQwZ2MyVnNaaTVuWlhSZmJXRnlhMlYwWDNCdmIyeHpLRzFoY210bGRGOXBaQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiV0Z5YTJWMFgzQnZiMnh6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklIbGxjMTl3YjI5c0lEMGdjRzl2YkhOYk1GMHVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qUTVDaUFnSUNBdkx5QnViMTl3YjI5c0lEMGdjRzl2YkhOYk1WMHVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalV4TFRJMU13b2dJQ0FnTHk4Z0l5QkRiMjV6ZEdGdWRDQndjbTlrZFdOMElFRk5UVG9nZVdWelgzQnlhV05sSUQwZ2JtOWZjRzl2YkNBdklDaDVaWE5mY0c5dmJDQXJJRzV2WDNCdmIyd3BDaUFnSUNBdkx5QWpJRk5qWVd4bFpDQmllU0F4TURBd0lHWnZjaUJ3Y21WamFYTnBiMjRnS0RVd0pTQTlJRFV3TUN3Z09Ua2xJRDBnT1Rrd0tRb2dJQ0FnTHk4Z2RHOTBZV3hmYkdseGRXbGthWFI1SUQwZ2VXVnpYM0J2YjJ3Z0t5QnViMTl3YjI5c0NpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJMU5Rb2dJQ0FnTHk4Z2FXWWdkRzkwWVd4ZmJHbHhkV2xrYVhSNUlEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpVMkNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLRFV3TUNrZ0lDTWdSR1ZtWVhWc2RDQTFNQ1VLSUNBZ0lIQjFjMmhwYm5RZ05UQXdJQzh2SURVd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbU5oYkdOMWJHRjBaVjk1WlhOZmNISnBZMlZmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpVNENpQWdJQ0F2THlCNVpYTmZjSEpwWTJVZ1BTQW9ibTlmY0c5dmJDQXFJREV3TURBcElDOHZJSFJ2ZEdGc1gyeHBjWFZwWkdsMGVRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBd0NpQWdJQ0FxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdlV1Z6WDNCeWFXTmxDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1aWRYbGZlV1Z6WDNOb1lYSmxjeWh0WVhKclpYUmZhV1E2SUhWcGJuUTJOQ3dnY0dGNWJXVnVkRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21KMWVWOTVaWE5mYzJoaGNtVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpZeExUSTJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1luVjVYM2xsYzE5emFHRnlaWE1vQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCdFlYSnJaWFJmYVdRNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQndZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Yml3S0lDQWdJQzh2SUNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU56VXRNamMyQ2lBZ0lDQXZMeUFqSUVOb1pXTnJJRzFoY210bGRDQmxlR2x6ZEhNZ1lXNWtJR2RsZENCa1lYUmhDaUFnSUNBdkx5QnRZWEpyWlhSZmNISmxabWw0SUQwZ1lpSnRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVh5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpjM0NpQWdJQ0F2THlCd2IyOXNjMTlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkJ2YjJ4eklpa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzNNRFptTm1ZMll6Y3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJM09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmIyeHpYMkp2ZUM1c1pXNW5kR2dnUGlBd0xDQWlUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qZ3dDaUFnSUNBdkx5QndiMjlzYzE5a1lYUmhMQ0JmWlhocGMzUnpJRDBnY0c5dmJITmZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9ESXRNamd6Q2lBZ0lDQXZMeUFqSUVWNGRISmhZM1FnWTNWeWNtVnVkQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTROQW9nSUNBZ0x5OGdibTlmY0c5dmJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvT0Nrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95T0RVS0lDQWdJQzh2SUhSdmRHRnNYM1p2YkhWdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTVRZcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UWWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lPRFlLSUNBZ0lDOHZJR1psWlY5eVlYUmxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNneU5Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXlOQ0F2THlBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakk0TndvZ0lDQWdMeThnY21WemIyeDFkR2x2Ymw5MGFXMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnek1pa3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakk0T0FvZ0lDQWdMeThnYVhOZmNtVnpiMngyWldRZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRFF3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURRd0lDOHZJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qa3dDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZjbVZ6YjJ4MlpXUWdQVDBnVlVsdWREWTBLREFwTENBaVJWSlNUMUpmTWpBeE9pQk5ZWEpyWlhRZ2FYTWdjbVZ6YjJ4MlpXUWlDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHlNREU2SUUxaGNtdGxkQ0JwY3lCeVpYTnZiSFpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qa3hDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUENCeVpYTnZiSFYwYVc5dVgzUnBiV1VzSUNKRlVsSlBVbDh5TURJNklGUnlZV1JwYm1jZ1pXNWtaV1FpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd01qb2dWSEpoWkdsdVp5QmxibVJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qa3lDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJa1ZTVWs5U1h6SXdNem9nVUdGNWJXVnVkQ0J6Wlc1a1pYSWdiWFZ6ZENCdFlYUmphQ0JoY0hBZ1kyRnNiQ0J6Wlc1a1pYSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1ETTZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dZWEJ3SUdOaGJHd2djMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pGVWxKUFVsOHlNRFE2SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6SXdORG9nVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErSURBc0lDSkZVbEpQVWw4eU1EVTZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHlNRFU2SUZCaGVXMWxiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWprMUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzVoYlc5MWJuUWdQajBnVlVsdWREWTBLREV3TURBcExDQWlSVkpTVDFKZk1qQTJPaUJOYVc1cGJYVnRJSFJ5WVdSbElHRnRiM1Z1ZENCcGN5QXhNREF3SUcxcFkzSnZRVXhIVDNNaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWs5U1h6SXdOam9nVFdsdWFXMTFiU0IwY21Ga1pTQmhiVzkxYm5RZ2FYTWdNVEF3TUNCdGFXTnliMEZNUjA5ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lPVGN0TWprNENpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQndiR0YwWm05eWJTQm1aV1VLSUNBZ0lDOHZJR1psWlY5aGJXOTFiblFnUFNBb2NHRjViV1Z1ZEM1aGJXOTFiblFnS2lCbVpXVmZjbUYwWlNrZ0x5OGdNVEF3TURBS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJQ29LSUNBZ0lHbHVkR01nTmlBdkx5QXhNREF3TUFvZ0lDQWdMd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWprNUNpQWdJQ0F2THlCMGNtRmtaVjloYlc5MWJuUWdQU0J3WVhsdFpXNTBMbUZ0YjNWdWRDQXRJR1psWlY5aGJXOTFiblFLSUNBZ0lHUjFjRElLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak13TVMwek1ESUtJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSE5vWVhKbGN5QjFjMmx1WnlCamIyNXpkR0Z1ZENCd2NtOWtkV04wSUdadmNtMTFiR0VLSUNBZ0lDOHZJSE5vWVhKbGMxOXlaV05sYVhabFpDQTlJQ2gwY21Ga1pWOWhiVzkxYm5RZ0tpQnViMTl3YjI5c0tTQXZMeUFvZVdWelgzQnZiMndnS3lCMGNtRmtaVjloYlc5MWJuUXBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTRDaUFnSUNBcUNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJQzhLSUNBZ0lHTnZkbVZ5SURFeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNRFlLSUNBZ0lDOHZJRzVsZDE5MGIzUmhiRjkyYjJ4MWJXVWdQU0IwYjNSaGJGOTJiMngxYldVZ0t5QndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNd09DMHpNRGtLSUNBZ0lDOHZJQ01nVTNSdmNtVWdkWEJrWVhSbFpDQmtZWFJoQ2lBZ0lDQXZMeUIzYVc1dWFXNW5YMjkxZEdOdmJXVWdQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RRNEtTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnY0hWemFHbHVkQ0EwT0NBdkx5QTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNeE1Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZlV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekV5Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekV4TFRNeE1nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZlV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibTlmY0c5dmJDa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1UTUtJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM1J2ZEdGc1gzWnZiSFZ0WlNrZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1URXRNekV6Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5NVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodWIxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekUwQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak14TVMwek1UUUtJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM2xsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1UVUtJQ0FnSUM4dklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBckNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNeE1TMHpNVFVLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNsbGMxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1dlgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh5WlhOdmJIVjBhVzl1WDNScGJXVXBJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16RTJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHpYM0psYzI5c2RtVmtLU0FyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak14TVMwek1UWUtJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM2xsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FYTmZjbVZ6YjJ4MlpXUXBJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16RTNDaUFnSUNBdkx5QnZjQzVwZEc5aUtIZHBibTVwYm1kZmIzVjBZMjl0WlNrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXhNUzB6TVRjS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM1J2ZEdGc1gzWnZiSFZ0WlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYVhOZmNtVnpiMngyWldRcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2QybHVibWx1WjE5dmRYUmpiMjFsS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNVGtLSUNBZ0lDOHZJSEJ2YjJ4elgySnZlQzV3ZFhRb2JtVjNYM0J2YjJ4elgyUmhkR0VwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNeU1Bb2dJQ0FnTHk4Z2MyVnNaaTV3YkdGMFptOXliVjltWldWekxuWmhiSFZsSUNzOUlHWmxaVjloYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd2JHRjBabTl5YlY5bVpXVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p3YkdGMFptOXliVjltWldWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak15TWkwek1qTUtJQ0FnSUM4dklDTWdWSEpoWTJzZ2RYTmxjaUJaWlhNZ2MyaGhjbVZ6Q2lBZ0lDQXZMeUIxYzJWeVgzTm9ZWEpsYzE5clpYa2dQU0JpSW5WelpYSmZJaUFySUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nS3lCaUlsOXRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVgzbGxjeUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TnpVM016WTFOekkxWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURWbU5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEVm1OemsyTlRjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekkyQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM05vWVhKbGN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak15TndvZ0lDQWdMeThnYVdZZ2RYTmxjbDl6YUdGeVpYTmZZbTk0TG14bGJtZDBhQ0ErSURBNkNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWW5vZ1luVjVYM2xsYzE5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TWpnS0lDQWdJQzh2SUdWNGFYTjBhVzVuWDNOb1lYSmxjMTlrWVhSaExDQmZaWGhwYzNSeklEMGdkWE5sY2w5emFHRnlaWE5mWW05NExtMWhlV0psS0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXlPUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOXphR0Z5WlhNZ1BTQnZjQzVpZEc5cEtHVjRhWE4wYVc1blgzTm9ZWEpsYzE5a1lYUmhLUW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3BpZFhsZmVXVnpYM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNekVLSUNBZ0lDOHZJSFZ6WlhKZmMyaGhjbVZ6WDJKdmVDNXdkWFFvYjNBdWFYUnZZaWhqZFhKeVpXNTBYM05vWVhKbGN5QXJJSE5vWVhKbGMxOXlaV05sYVhabFpDa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlITm9ZWEpsYzE5eVpXTmxhWFpsWkFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVZblY1WDI1dlgzTm9ZWEpsY3lodFlYSnJaWFJmYVdRNklIVnBiblEyTkN3Z2NHRjViV1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtSjFlVjl1YjE5emFHRnlaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek16VXRNelF3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmlkWGxmYm05ZmMyaGhjbVZ6S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhMlYwWDJsa09pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0c0NpQWdJQ0F2THlBcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16UXlMVE0wTXdvZ0lDQWdMeThnSXlCRGFHVmpheUJ0WVhKclpYUWdaWGhwYzNSeklHRnVaQ0JuWlhRZ1pHRjBZUW9nSUNBZ0x5OGdiV0Z5YTJWMFgzQnlaV1pwZUNBOUlHSWliV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJaRFl4TnpJMllqWTFOelExWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNME5Bb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekEyWmpabU5tTTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IyOXNjMTlpYjNndWJHVnVaM1JvSUQ0Z01Dd2dJazFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhKclpYUWdaRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTBOd29nSUNBZ0x5OGdjRzl2YkhOZlpHRjBZU3dnWDJWNGFYTjBjeUE5SUhCdmIyeHpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16UTVMVE0xTUFvZ0lDQWdMeThnSXlCRmVIUnlZV04wSUdOMWNuSmxiblFnYzNSaGRHVUtJQ0FnSUM4dklIbGxjMTl3YjI5c0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pOVEVLSUNBZ0lDOHZJRzV2WDNCdmIyd2dQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RncExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpVeUNpQWdJQ0F2THlCMGIzUmhiRjkyYjJ4MWJXVWdQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RFMktTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelV6Q2lBZ0lDQXZMeUJtWldWZmNtRjBaU0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb01qUXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TlRRS0lDQWdJQzh2SUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb016SXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TlRVS0lDQWdJQzh2SUdselgzSmxjMjlzZG1Wa0lEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2cwTUNrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBME1DQXZMeUEwTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTFOd29nSUNBZ0x5OGdZWE56WlhKMElHbHpYM0psYzI5c2RtVmtJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lrVlNVazlTWHpJd01Ub2dUV0Z5YTJWMElHbHpJSEpsYzI5c2RtVmtJZ29nSUNBZ1pIVndDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNakF4T2lCTllYSnJaWFFnYVhNZ2NtVnpiMngyWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTFPQW9nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3Z2NtVnpiMngxZEdsdmJsOTBhVzFsTENBaVJWSlNUMUpmTWpBeU9pQlVjbUZrYVc1bklHVnVaR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1ESTZJRlJ5WVdScGJtY2daVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTFPUW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWMyVnVaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0pGVWxKUFVsOHlNRE02SUZCaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnWVhCd0lHTmhiR3dnYzJWdVpHVnlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1qQXpPaUJRWVhsdFpXNTBJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JR0Z3Y0NCallXeHNJSE5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNell3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpUlZKU1QxSmZNakEwT2lCUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHlNRFE2SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16WXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUGlBd0xDQWlSVkpTVDFKZk1qQTFPaUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNakExT2lCUVlYbHRaVzUwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMk1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDQ5SUZWSmJuUTJOQ2d4TURBd0tTd2dJa1ZTVWs5U1h6SXdOam9nVFdsdWFXMTFiU0IwY21Ga1pTQmhiVzkxYm5RZ2FYTWdNVEF3TUNCdGFXTnliMEZNUjA5eklnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHlNRFk2SUUxcGJtbHRkVzBnZEhKaFpHVWdZVzF2ZFc1MElHbHpJREV3TURBZ2JXbGpjbTlCVEVkUGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelkwTFRNMk5Rb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdjR3hoZEdadmNtMGdabVZsQ2lBZ0lDQXZMeUJtWldWZllXMXZkVzUwSUQwZ0tIQmhlVzFsYm5RdVlXMXZkVzUwSUNvZ1ptVmxYM0poZEdVcElDOHZJREV3TURBd0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0FxQ2lBZ0lDQnBiblJqSURZZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMk5nb2dJQ0FnTHk4Z2RISmhaR1ZmWVcxdmRXNTBJRDBnY0dGNWJXVnVkQzVoYlc5MWJuUWdMU0JtWldWZllXMXZkVzUwQ2lBZ0lDQmtkWEF5Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TmpndE16WTVDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0J6YUdGeVpYTWdkWE5wYm1jZ1kyOXVjM1JoYm5RZ2NISnZaSFZqZENCbWIzSnRkV3hoQ2lBZ0lDQXZMeUJ6YUdGeVpYTmZjbVZqWldsMlpXUWdQU0FvZEhKaFpHVmZZVzF2ZFc1MElDb2dlV1Z6WDNCdmIyd3BJQzh2SUNodWIxOXdiMjlzSUNzZ2RISmhaR1ZmWVcxdmRXNTBLUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dPUW9nSUNBZ0tnb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0F2Q2lBZ0lDQmpiM1psY2lBeE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemN6Q2lBZ0lDQXZMeUJ1WlhkZmRHOTBZV3hmZG05c2RXMWxJRDBnZEc5MFlXeGZkbTlzZFcxbElDc2djR0Y1YldWdWRDNWhiVzkxYm5RS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56VXRNemMyQ2lBZ0lDQXZMeUFqSUZOMGIzSmxJSFZ3WkdGMFpXUWdaR0YwWVFvZ0lDQWdMeThnZDJsdWJtbHVaMTl2ZFhSamIyMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnME9Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUhCMWMyaHBiblFnTkRnZ0x5OGdORGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56Z0tJQ0FnSUM4dklHOXdMbWwwYjJJb2VXVnpYM0J2YjJ3cElDc0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16YzVDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTl1YjE5d2IyOXNLU0FyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zT0Mwek56a0tJQ0FnSUM4dklHOXdMbWwwYjJJb2VXVnpYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYMjV2WDNCdmIyd3BJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16Z3dDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTkwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16YzRMVE00TUFvZ0lDQWdMeThnYjNBdWFYUnZZaWg1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmJtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZkRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak00TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3dvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TnpndE16Z3hDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTl1YjE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5MGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16Z3lDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek56Z3RNemd5Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSGxsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5dWIxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOTBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WemIyeDFkR2x2Ymw5MGFXMWxLU0FyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTRNd29nSUNBZ0x5OGdiM0F1YVhSdllpaHBjMTl5WlhOdmJIWmxaQ2tnS3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TnpndE16Z3pDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTl1YjE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5MGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHpYM0psYzI5c2RtVmtLU0FyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTROQW9nSUNBZ0x5OGdiM0F1YVhSdllpaDNhVzV1YVc1blgyOTFkR052YldVcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pOemd0TXpnMENpQWdJQ0F2THlCdmNDNXBkRzlpS0hsbGMxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1bGQxOXViMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTkwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2NtVnpiMngxZEdsdmJsOTBhVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dselgzSmxjMjlzZG1Wa0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIZHBibTVwYm1kZmIzVjBZMjl0WlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemcyQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2d1Y0hWMEtHNWxkMTl3YjI5c2MxOWtZWFJoS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek9EY0tJQ0FnSUM4dklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5NTJZV3gxWlNBclBTQm1aV1ZmWVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHeGhkR1p2Y20xZlptVmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2JHRjBabTl5YlY5bVpXVnpJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0d4aGRHWnZjbTFmWm1WbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96T0RrdE16a3dDaUFnSUNBdkx5QWpJRlJ5WVdOcklIVnpaWElnVG04Z2MyaGhjbVZ6Q2lBZ0lDQXZMeUIxYzJWeVgzTm9ZWEpsYzE5clpYa2dQU0JpSW5WelpYSmZJaUFySUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nS3lCaUlsOXRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVgyNXZJZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGczTlRjek5qVTNNalZtQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TldZMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE5XWTJaVFptQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16a3pDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzTm9ZWEpsY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVOQW9nSUNBZ0x5OGdhV1lnZFhObGNsOXphR0Z5WlhOZlltOTRMbXhsYm1kMGFDQStJREE2Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZbm9nWW5WNVgyNXZYM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVOUW9nSUNBZ0x5OGdaWGhwYzNScGJtZGZjMmhoY21WelgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCMWMyVnlYM05vWVhKbGMxOWliM2d1YldGNVltVW9LUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprMkNpQWdJQ0F2THlCamRYSnlaVzUwWDNOb1lYSmxjeUE5SUc5d0xtSjBiMmtvWlhocGMzUnBibWRmYzJoaGNtVnpYMlJoZEdFcENpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0NtSjFlVjl1YjE5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprNENpQWdJQ0F2THlCMWMyVnlYM05vWVhKbGMxOWliM2d1Y0hWMEtHOXdMbWwwYjJJb1kzVnljbVZ1ZEY5emFHRnlaWE1nS3lCemFHRnlaWE5mY21WalpXbDJaV1FwS1FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTURBS0lDQWdJQzh2SUhKbGRIVnliaUJ6YUdGeVpYTmZjbVZqWldsMlpXUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG5KbGMyOXNkbVZmYldGeWEyVjBLRzFoY210bGRGOXBaRG9nZFdsdWREWTBMQ0I1WlhOZmQybHVjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbkpsYzI5c2RtVmZiV0Z5YTJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREF5TFRRd013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnY21WemIyeDJaVjl0WVhKclpYUW9jMlZzWml3Z2JXRnlhMlYwWDJsa09pQlZTVzUwTmpRc0lIbGxjMTkzYVc1ek9pQmhjbU0wTGtKdmIyd3BJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXdOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0Z1kyRnVJSEpsYzI5c2RtVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnWTJGdUlISmxjMjlzZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXdOd29nSUNBZ0x5OGdiV0Z5YTJWMFgzQnlaV1pwZUNBOUlHSWliV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJaRFl4TnpJMllqWTFOelExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRBNENpQWdJQ0F2THlCd2IyOXNjMTlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkJ2YjJ4eklpa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzNNRFptTm1ZMll6Y3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRd09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmIyeHpYMkp2ZUM1c1pXNW5kR2dnUGlBd0xDQWlUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ERXhDaUFnSUNBdkx5QndiMjlzYzE5a1lYUmhMQ0JmWlhocGMzUnpJRDBnY0c5dmJITmZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1UTXROREUwQ2lBZ0lDQXZMeUFqSUVWNGRISmhZM1FnWTNWeWNtVnVkQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXhOUW9nSUNBZ0x5OGdibTlmY0c5dmJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvT0Nrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTVRZS0lDQWdJQzh2SUhSdmRHRnNYM1p2YkhWdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTVRZcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UWWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNVGNLSUNBZ0lDOHZJR1psWlY5eVlYUmxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNneU5Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXlOQ0F2THlBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF4T0FvZ0lDQWdMeThnY21WemIyeDFkR2x2Ymw5MGFXMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnek1pa3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF4T1FvZ0lDQWdMeThnYVhOZmNtVnpiMngyWldRZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRFF3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdjSFZ6YUdsdWRDQTBNQ0F2THlBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF5TVFvZ0lDQWdMeThnWVhOelpYSjBJR2x6WDNKbGMyOXNkbVZrSUQwOUlGVkpiblEyTkNnd0tTd2dJa0ZzY21WaFpIa2djbVZ6YjJ4MlpXUWlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUVd4eVpXRmtlU0J5WlhOdmJIWmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRJeUNpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQajBnY21WemIyeDFkR2x2Ymw5MGFXMWxMQ0FpVkc5dklHVmhjbXg1SUhSdklISmxjMjlzZG1VaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYjI4Z1pXRnliSGtnZEc4Z2NtVnpiMngyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ESTJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXlOd29nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXlOaTAwTWpjS0lDQWdJQzh2SUc5d0xtbDBiMklvZVdWelgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm05ZmNHOXZiQ2tnS3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNamdLSUNBZ0lDOHZJRzl3TG1sMGIySW9kRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReU5pMDBNamdLSUNBZ0lDOHZJRzl3TG1sMGIySW9lV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibTlmY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaDBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREk1Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF5TmkwME1qa0tJQ0FnSUM4dklHOXdMbWwwYjJJb2VXVnpYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWloMGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ETXdDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREkyTFRRek1Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodWIxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRNeENpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d4S1NrZ0t5QWdJeUJwYzE5eVpYTnZiSFpsWkNBOUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTWpZdE5ETXhDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2RHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Ta3BJQ3NnSUNNZ2FYTmZjbVZ6YjJ4MlpXUWdQU0JVY25WbENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF6TWdvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NU2tnYVdZZ2VXVnpYM2RwYm5NdWJtRjBhWFpsSUdWc2MyVWdWVWx1ZERZMEtEQXBLU0FnSXlCM2FXNXVhVzVuWDI5MWRHTnZiV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRJMkxUUXpNZ29nSUNBZ0x5OGdiM0F1YVhSdllpaDVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh5WlhOdmJIVjBhVzl1WDNScGJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtERXBLU0FySUNBaklHbHpYM0psYzI5c2RtVmtJRDBnVkhKMVpRb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloVlNXNTBOalFvTVNrZ2FXWWdlV1Z6WDNkcGJuTXVibUYwYVhabElHVnNjMlVnVlVsdWREWTBLREFwS1NBZ0l5QjNhVzV1YVc1blgyOTFkR052YldVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORE0wQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2d1Y0hWMEtHNWxkMTl3YjI5c2MxOWtZWFJoS1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG1kbGRGOTBiM1JoYkY5dFlYSnJaWFJ6S0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJmZEc5MFlXeGZiV0Z5YTJWMGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF6T1FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMjFoY210bGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiV0Z5YTJWMGN5QmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVuWlhSZmNHeGhkR1p2Y20xZlptVmxjeWdwSUMwK0lIVnBiblEyTkRvS1oyVjBYM0JzWVhSbWIzSnRYMlpsWlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBORFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p3YkdGMFptOXliVjltWldWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVkMmwwYUdSeVlYZGZabVZsY3lncElDMCtJSFZwYm5RMk5Eb0tkMmwwYUdSeVlYZGZabVZsY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTBPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0Z1kyRnVJSGRwZEdoa2NtRjNJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjNhWFJvWkhKaGR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFV4Q2lBZ0lDQXZMeUJtWldWelgzUnZYM2RwZEdoa2NtRjNJRDBnYzJWc1ppNXdiR0YwWm05eWJWOW1aV1Z6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHeGhkR1p2Y20xZlptVmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2JHRjBabTl5YlY5bVpXVnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdabVZsYzE5MGIxOTNhWFJvWkhKaGR5QStJREFzSUNKT2J5Qm1aV1Z6SUhSdklIZHBkR2hrY21GM0lnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1ptVmxjeUIwYnlCM2FYUm9aSEpoZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EVTBDaUFnSUNBdkx5QnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luQnNZWFJtYjNKdFgyWmxaWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMU5pMDBOakFLSUNBZ0lDOHZJQ01nVTJWdVpDQndZWGx0Wlc1MElIUnZJR0ZrYldsdUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVptVmxjMTkwYjE5M2FYUm9aSEpoZHl3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMU9Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORFUyTFRRMU53b2dJQ0FnTHk4Z0l5QlRaVzVrSUhCaGVXMWxiblFnZEc4Z1lXUnRhVzRLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRVMkxUUTJNQW9nSUNBZ0x5OGdJeUJUWlc1a0lIQmhlVzFsYm5RZ2RHOGdZV1J0YVc0S0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxbVpXVnpYM1J2WDNkcGRHaGtjbUYzTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMk1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdabFpYTmZkRzlmZDJsMGFHUnlZWGNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNW5aWFJmZFhObGNsOXphR0Z5WlhNb2RYTmxjam9nWW5sMFpYTXNJRzFoY210bGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWjJWMFgzVnpaWEpmYzJoaGNtVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRZMExUUTJOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM1Z6WlhKZmMyaGhjbVZ6S0hObGJHWXNJSFZ6WlhJNklFRmpZMjkxYm5Rc0lHMWhjbXRsZEY5cFpEb2dWVWx1ZERZMEtTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVWVWx1ZERZMExDQmhjbU0wTGxWSmJuUTJORjA2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTJOeTAwTmpnS0lDQWdJQzh2SUNNZ1IyVjBJRmxsY3lCemFHRnlaWE1LSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUIxYzJWeUxtSjVkR1Z6SUNzZ1lpSmZiV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOTVaWE1pQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURjMU56TTJOVGN5TldZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEVm1ObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z01IZzFaamM1TmpVM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEzTVFvZ0lDQWdMeThnZVdWelgzTm9ZWEpsY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTNNZ29nSUNBZ0x5OGdhV1lnZVdWelgzTm9ZWEpsYzE5aWIzZ3ViR1Z1WjNSb0lENGdNRG9LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmllaUJuWlhSZmRYTmxjbDl6YUdGeVpYTmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOek1LSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSGxsYzE5emFHRnlaWE5mWW05NExtMWhlV0psS0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTNOQW9nSUNBZ0x5OGdlV1Z6WDNOb1lYSmxjeUE5SUc5d0xtSjBiMmtvZVdWelgzTm9ZWEpsYzE5a1lYUmhLUW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDZ3BuWlhSZmRYTmxjbDl6YUdGeVpYTmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGMyTFRRM053b2dJQ0FnTHk4Z0l5QkhaWFFnVG04Z2MyaGhjbVZ6Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUIxYzJWeUxtSjVkR1Z6SUNzZ1lpSmZiV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOXVieUlLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlRFZtTm1VMlpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGd3Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRNE1Rb2dJQ0FnTHk4Z2FXWWdibTlmYzJoaGNtVnpYMkp2ZUM1c1pXNW5kR2dnUGlBd09nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVGSmxaaUJsZUdsemRITUtJQ0FnSUdKNklHZGxkRjkxYzJWeVgzTm9ZWEpsYzE5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRNE1nb2dJQ0FnTHk4Z2JtOWZjMmhoY21WelgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCdWIxOXphR0Z5WlhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalE0TXdvZ0lDQWdMeThnYm05ZmMyaGhjbVZ6SUQwZ2IzQXVZblJ2YVNodWIxOXphR0Z5WlhOZlpHRjBZU2tLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9LWjJWMFgzVnpaWEpmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalE0TlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVWVWx1ZERZMEtIbGxjMTl6YUdGeVpYTXBMQ0JoY21NMExsVkpiblEyTkNodWIxOXphR0Z5WlhNcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzV5WldSbFpXMWZkMmx1Ym1sdVoxOXphR0Z5WlhNb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EZzNMVFE0T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTVNQzAwT1RFS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYldGeWEyVjBJR1Y0YVhOMGN5QmhibVFnYVhNZ2NtVnpiMngyWldRS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Ea3lDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFcxaGNtdGxkRjl3Y21WbWFYZ2dLeUJpSW5CdmIyeHpJaWtLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGczTURabU5tWTJZemN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTVNd29nSUNBZ0x5OGdZWE56WlhKMElIQnZiMnh6WDJKdmVDNXNaVzVuZEdnZ1BpQXdMQ0FpVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMElnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGsxQ2lBZ0lDQXZMeUJ3YjI5c2MxOWtZWFJoTENCZlpYaHBjM1J6SUQwZ2NHOXZiSE5mWW05NExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGsyQ2lBZ0lDQXZMeUJwYzE5eVpYTnZiSFpsWkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9OREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRrM0NpQWdJQ0F2THlCM2FXNXVhVzVuWDI5MWRHTnZiV1VnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEUTRLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdORGdnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT1RrS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5eVpYTnZiSFpsWkNBOVBTQlZTVzUwTmpRb01Ta3NJQ0pOWVhKclpYUWdibTkwSUhKbGMyOXNkbVZrSUhsbGRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQnViM1FnY21WemIyeDJaV1FnZVdWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNREV0TlRBeUNpQWdJQ0F2THlBaklFZGxkQ0IxYzJWeUozTWdjMmhoY21WekNpQWdJQ0F2THlCMWMyVnlYM05vWVhKbGN5QTlJSE5sYkdZdVoyVjBYM1Z6WlhKZmMyaGhjbVZ6S0ZSNGJpNXpaVzVrWlhJc0lHMWhjbXRsZEY5cFpDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZFhObGNsOXphR0Z5WlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXdNd29nSUNBZ0x5OGdlV1Z6WDNOb1lYSmxjeUE5SUhWelpYSmZjMmhoY21Weld6QmRMbTVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV3TkFvZ0lDQWdMeThnYm05ZmMyaGhjbVZ6SUQwZ2RYTmxjbDl6YUdGeVpYTmJNVjB1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVd09Bb2dJQ0FnTHk4Z2FXWWdkMmx1Ym1sdVoxOXZkWFJqYjIxbElEMDlJRlZKYm5RMk5DZ3hLVG9nSUNNZ1dXVnpJSGR2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE5mWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXhNQzAxTVRFS0lDQWdJQzh2SUNNZ1EyeGxZWElnV1dWeklITm9ZWEpsY3dvZ0lDQWdMeThnZVdWelgzTm9ZWEpsYzE5clpYa2dQU0JpSW5WelpYSmZJaUFySUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nS3lCaUlsOXRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVgzbGxjeUlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TnpVM016WTFOekkxWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURWbU5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEVm1OemsyTlRjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNVE1LSUNBZ0lDOHZJR2xtSUhsbGMxOXphR0Z5WlhOZlltOTRMbXhsYm1kMGFDQStJREE2Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZbm9nY21Wa1pXVnRYM2RwYm01cGJtZGZjMmhoY21WelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5URTBDaUFnSUNBdkx5QjVaWE5mYzJoaGNtVnpYMkp2ZUM1a1pXeGxkR1VvS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvS2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNncHlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRJekNpQWdJQ0F2THlCaGMzTmxjblFnZDJsdWJtbHVaMTl6YUdGeVpYTWdQaUJWU1c1ME5qUW9NQ2tzSUNKT2J5QjNhVzV1YVc1bklITm9ZWEpsY3lCMGJ5QnlaV1JsWlcwaUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCM2FXNXVhVzVuSUhOb1lYSmxjeUIwYnlCeVpXUmxaVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVeU9DMDFNekVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5USTVDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTWpnS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5USTRMVFV6TVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCaGVXOTFkRjloYlc5MWJuUXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVE16Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjR0Y1YjNWMFgyRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxaR1ZsYlY5M2FXNXVhVzVuWDNOb1lYSmxjMTlsYkhObFgySnZaSGxBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXhOeTAxTVRnS0lDQWdJQzh2SUNNZ1EyeGxZWElnVG04Z2MyaGhjbVZ6Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnWWlKZmJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw5dWJ5SUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjROelUzTXpZMU56STFaZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlRFZtTm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUF3ZURWbU5tVTJaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRJd0NpQWdJQ0F2THlCcFppQnViMTl6YUdGeVpYTmZZbTk0TG14bGJtZDBhQ0ErSURBNkNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWW5vZ2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVEl4Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE5mWW05NExtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncHlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdJZ2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU53b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVuWlhSZlkyOXVkSEpoWTNSZlpHVmlkV2RmYVc1bWJ5Z3BJQzArSUdKNWRHVnpPZ3BuWlhSZlkyOXVkSEpoWTNSZlpHVmlkV2RmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUwTVFvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektITmxiR1l1WVdSdGFXNHVkbUZzZFdVdVlubDBaWE1wTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUwTWdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSekxuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5ETUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWNHeGhkR1p2Y20xZlptVmxjeTUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHeGhkR1p2Y20xZlptVmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2JHRjBabTl5YlY5bVpXVnpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFEwQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbTFwYmw5c2FYRjFhV1JwZEhrdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWliV2x1WDJ4cGNYVnBaR2wwZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhVzVmYkdseGRXbGthWFI1SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRRd0xUVTBOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRV1JrY21WemN5aHpaV3htTG1Ga2JXbHVMblpoYkhWbExtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5NTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXRhVzVmYkdseGRXbGthWFI1TG5aaGJIVmxLUW9nSUNBZ0x5OGdLU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVwYzE5amIyNTBjbUZqZEY5cGJtbDBhV0ZzYVhwbFpDZ3BJQzArSUdKNWRHVnpPZ3BwYzE5amIyNTBjbUZqZEY5cGJtbDBhV0ZzYVhwbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUxTUFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2h6Wld4bUxtRmtiV2x1TG5aaGJIVmxMbUo1ZEdWeklDRTlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM011WW5sMFpYTXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGRYTW9LU0F0UGlCaWVYUmxjem9LWjJWMFgyTnZiblJ5WVdOMFgzTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTFNaTAxTlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5amIyNTBjbUZqZEY5emRHRjBkWE1vYzJWc1ppa2dMVDRnWVhKak5DNVVkWEJzWlZ0aGNtTTBMa0p2YjJ3c0lHRnlZelF1UVdSa2NtVnpjeXdnWVhKak5DNVZTVzUwTmpSZE9nb2dJQ0FnY0hKdmRHOGdNQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5UVUtJQ0FnSUM4dklHbHpYMmx1YVhRZ1BTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExtSjVkR1Z6SUNFOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXVZbmwwWlhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUxTndvZ0lDQWdMeThnWVhKak5DNUNiMjlzS0dselgybHVhWFFwTEFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFU0Q2lBZ0lDQXZMeUJoY21NMExrRmtaSEpsYzNNb2MyVnNaaTVoWkcxcGJpNTJZV3gxWlM1aWVYUmxjeUJwWmlCcGMxOXBibWwwSUdWc2MyVWdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeTVpZVhSbGN5a3NDaUFnSUNCaWVpQm5aWFJmWTI5dWRISmhZM1JmYzNSaGRIVnpYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b0taMlYwWDJOdmJuUnlZV04wWDNOMFlYUjFjMTkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlRnS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aHpaV3htTG1Ga2JXbHVMblpoYkhWbExtSjVkR1Z6SUdsbUlHbHpYMmx1YVhRZ1pXeHpaU0JIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TG1KNWRHVnpLU3dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOVGtLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3k1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5dFlYSnJaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlRZdE5UWXdDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUNiMjlzS0dselgybHVhWFFwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWh6Wld4bUxtRmtiV2x1TG5aaGJIVmxMbUo1ZEdWeklHbG1JR2x6WDJsdWFYUWdaV3h6WlNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVXBDaUFnSUNBdkx5QXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgyTnZiblJ5WVdOMFgzTjBZWFIxYzE5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5UZ0tJQ0FnSUM4dklHRnlZelF1UVdSa2NtVnpjeWh6Wld4bUxtRmtiV2x1TG5aaGJIVmxMbUo1ZEdWeklHbG1JR2x6WDJsdWFYUWdaV3h6WlNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxtSjVkR1Z6S1N3S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lpQm5aWFJmWTI5dWRISmhZM1JmYzNSaGRIVnpYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzUyWVd4cFpHRjBaVjlqY21WaGRHVmZiV0Z5YTJWMFgzQmhjbUZ0Y3loeGRXVnpkR2x2YmpvZ1lubDBaWE1zSUhKbGMyOXNkWFJwYjI1ZmRHbHRaVG9nZFdsdWREWTBMQ0JtWldWZmNtRjBaVG9nZFdsdWREWTBMQ0J3WVhsdFpXNTBYMkZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5qSXROVFk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQjJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhGMVpYTjBhVzl1T2lCVGRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiMngxZEdsdmJsOTBhVzFsT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxYM0poZEdVNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQndZWGx0Wlc1MFgyRnRiM1Z1ZERvZ1ZVbHVkRFkwQ2lBZ0lDQXZMeUFwSUMwK0lHRnlZelF1UW05dmJEb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UY3hDaUFnSUNBdkx5QnBaaUJtWldWZmNtRjBaU0ErSUZWSmJuUTJOQ2d4TURBd0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQUtJQ0FnSUQ0S0lDQWdJR0o2SUhaaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UY3lDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM013b2dJQ0FnTHk4Z2FXWWdjR0Y1YldWdWRGOWhiVzkxYm5RZ1BDQnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa3VkbUZzZFdVZ0tpQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDRLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRjMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgyTnlaV0YwWlY5dFlYSnJaWFJmY0dGeVlXMXpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUzTlFvZ0lDQWdMeThnYVdZZ2NtVnpiMngxZEdsdmJsOTBhVzFsSUR3OUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUNzZ1ZVbHVkRFkwS0RNMk1EQXBPZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZeUEwSUM4dklETTJNREFLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnUGowS0lDQWdJR0o2SUhaaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UYzJDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM053b2dJQ0FnTHk4Z2FXWWdjbVZ6YjJ4MWRHbHZibDkwYVcxbElENGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ0t5QlZTVzUwTmpRb016RTFNell3TURBcE9nb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFl5QTFJQzh2SURNeE5UTTJNREF3Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUR3S0lDQWdJR0o2SUhaaGJHbGtZWFJsWDJOeVpXRjBaVjl0WVhKclpYUmZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UYzRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNWpZVzVmWTNKbFlYUmxYMjFoY210bGRDaHpaVzVrWlhJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kyRnVYMk55WldGMFpWOXRZWEpyWlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPREV0TlRneUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJqWVc1ZlkzSmxZWFJsWDIxaGNtdGxkQ2h6Wld4bUxDQnpaVzVrWlhJNklFRmpZMjkxYm5RcElDMCtJR0Z5WXpRdVFtOXZiRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSE5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVuWlhSZmNtVnhkV2x5WldSZmNHRjViV1Z1ZEY5bWIzSmZiV0Z5YTJWMEtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSZmNtVnhkV2x5WldSZmNHRjViV1Z1ZEY5bWIzSmZiV0Z5YTJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVMblpoYkhWbElDb2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltMXBibDlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1YldGeWEyVjBYMlY0YVhOMGN5aHRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbTFoY210bGRGOWxlR2x6ZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPVEV0TlRreUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJ0WVhKclpYUmZaWGhwYzNSektITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGtKdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTVOQW9nSUNBZ0x5OGdhV1lnYldGeWEyVjBYMmxrSUQ0OUlITmxiR1l1ZEc5MFlXeGZiV0Z5YTJWMGN5NTJZV3gxWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEdzlDaUFnSUNCaWVpQnRZWEpyWlhSZlpYaHBjM1J6WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3Q2lBZ0lDQnlaWFJ6ZFdJS0NtMWhjbXRsZEY5bGVHbHpkSE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrM0NpQWdJQ0F2THlCdFlYSnJaWFJmY0hKbFptbDRJRDBnWWlKdFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURaa05qRTNNalppTmpVM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcxWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPVGdLSUNBZ0lDOHZJSEYxWlhOMGFXOXVYMkp2ZUNBOUlFSnZlRkpsWmloclpYazliV0Z5YTJWMFgzQnlaV1pwZUNBcklHSWljWFZsYzNScGIyNGlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlRGN4TnpVMk5UY3pOelEyT1RabU5tVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRrNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0hGMVpYTjBhVzl1WDJKdmVDNXNaVzVuZEdnZ1BpQXdLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYMjFoY210bGRGOWpjbVZoZEc5eUtHMWhjbXRsZEY5cFpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwWDIxaGNtdGxkRjlqY21WaGRHOXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpBeExUWXdNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMjFoY210bGRGOWpjbVZoZEc5eUtITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQkJZMk52ZFc1ME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFlYSnJaWFJmYVdRZ1BDQnpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVc0lDSk5ZWEpyWlhRZ1NVUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiV0Z5YTJWMGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSeklHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRnlhMlYwSUVsRUlHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1EWUtJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall3TndvZ0lDQWdMeThnWTNKbFlYUnZjbDlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbU55WldGMGIzSWlLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGcyTXpjeU5qVTJNVGMwTm1ZM01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTURnS0lDQWdJQzh2SUdGemMyVnlkQ0JqY21WaGRHOXlYMkp2ZUM1c1pXNW5kR2dnUGlBd0xDQWlUV0Z5YTJWMElHTnlaV0YwYjNJZ1pHRjBZU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElHTnlaV0YwYjNJZ1pHRjBZU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeE1Bb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2w5aWVYUmxjeXdnWDJWNGFYTjBjeUE5SUdOeVpXRjBiM0pmWW05NExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRV05qYjNWdWRDaGpjbVZoZEc5eVgySjVkR1Z6S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1emFXMTFiR0YwWlY5NVpYTmZkSEpoWkdVb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRc0lIQmhlVzFsYm5SZllXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwemFXMTFiR0YwWlY5NVpYTmZkSEpoWkdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNVE10TmpFMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJ6YVcxMWJHRjBaVjk1WlhOZmRISmhaR1VvYzJWc1ppd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXNJSEJoZVcxbGJuUmZZVzF2ZFc1ME9pQlZTVzUwTmpRcElDMCtJR0Z5WXpRdVZIVndiR1ZiWVhKak5DNVZTVzUwTmpRc0lHRnlZelF1VlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV0Z5YTJWMFgybGtJRHdnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6TG5aaGJIVmxMQ0FpVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMjFoY210bGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiV0Z5YTJWMGN5QmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklFMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpFNENpQWdJQ0F2THlCdFlYSnJaWFJmY0hKbFptbDRJRDBnWWlKdFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURaa05qRTNNalppTmpVM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcxWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNVGtLSUNBZ0lDOHZJSEJ2YjJ4elgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWJXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaWNHOXZiSE1pS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd05tWTJaalpqTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjRzl2YkhOZlltOTRMbXhsYm1kMGFDQStJREFzSUNKTllYSnJaWFFnWkdGMFlTQnViM1FnWm05MWJtUWlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRnlhMlYwSUdSaGRHRWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTWpJS0lDQWdJQzh2SUhCdmIyeHpYMlJoZEdFc0lGOWxlR2x6ZEhNZ1BTQndiMjlzYzE5aWIzZ3ViV0Y1WW1Vb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTWpRS0lDQWdJQzh2SUhsbGMxOXdiMjlzSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3dLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1qVUtJQ0FnSUM4dklHNXZYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRGdwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakkyQ2lBZ0lDQXZMeUJtWldWZmNtRjBaU0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb01qUXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qSTRMVFl5T1FvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2RISmhaR1VnYzJsdGRXeGhkR2x2YmdvZ0lDQWdMeThnWm1WbFgyRnRiM1Z1ZENBOUlDaHdZWGx0Wlc1MFgyRnRiM1Z1ZENBcUlHWmxaVjl5WVhSbEtTQXZMeUF4TURBd01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQnBiblJqSURZZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZek1Bb2dJQ0FnTHk4Z2RISmhaR1ZmWVcxdmRXNTBJRDBnY0dGNWJXVnVkRjloYlc5MWJuUWdMU0JtWldWZllXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTXpFS0lDQWdJQzh2SUhOb1lYSmxjMTl5WldObGFYWmxaQ0E5SUNoMGNtRmtaVjloYlc5MWJuUWdLaUJ1YjE5d2IyOXNLU0F2THlBb2VXVnpYM0J2YjJ3Z0t5QjBjbUZrWlY5aGJXOTFiblFwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall6TXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVWVWx1ZERZMEtITm9ZWEpsYzE5eVpXTmxhWFpsWkNrc0lHRnlZelF1VlVsdWREWTBLR1psWlY5aGJXOTFiblFwS1NrS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG5OcGJYVnNZWFJsWDI1dlgzUnlZV1JsS0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwTENCd1lYbHRaVzUwWDJGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LYzJsdGRXeGhkR1ZmYm05ZmRISmhaR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk16VXROak0yQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnphVzExYkdGMFpWOXViMTkwY21Ga1pTaHpaV3htTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkN3Z2NHRjViV1Z1ZEY5aGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVVZFhCc1pWdGhjbU0wTGxWSmJuUTJOQ3dnWVhKak5DNVZTVzUwTmpSZE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCdFlYSnJaWFJmYVdRZ1BDQnpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVc0lDSk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOREFLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZME1Rb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekEyWmpabU5tTTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk5ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IyOXNjMTlpYjNndWJHVnVaM1JvSUQ0Z01Dd2dJazFoY210bGRDQmtZWFJoSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUp2ZUZKbFppQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhKclpYUWdaR0YwWVNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTBOQW9nSUNBZ0x5OGdjRzl2YkhOZlpHRjBZU3dnWDJWNGFYTjBjeUE5SUhCdmIyeHpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTBOZ29nSUNBZ0x5OGdlV1Z6WDNCdmIyd2dQU0J2Y0M1aWRHOXBLRzl3TG1WNGRISmhZM1FvY0c5dmJITmZaR0YwWVN3Z1ZVbHVkRFkwS0RBcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalkwTndvZ0lDQWdMeThnYm05ZmNHOXZiQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb09Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk5EZ0tJQ0FnSUM4dklHWmxaVjl5WVhSbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d5TkNrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTlRBdE5qVXhDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0IwY21Ga1pTQnphVzExYkdGMGFXOXVDaUFnSUNBdkx5Qm1aV1ZmWVcxdmRXNTBJRDBnS0hCaGVXMWxiblJmWVcxdmRXNTBJQ29nWm1WbFgzSmhkR1VwSUM4dklERXdNREF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUdsdWRHTWdOaUF2THlBeE1EQXdNQW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalV5Q2lBZ0lDQXZMeUIwY21Ga1pWOWhiVzkxYm5RZ1BTQndZWGx0Wlc1MFgyRnRiM1Z1ZENBdElHWmxaVjloYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTFNd29nSUNBZ0x5OGdjMmhoY21WelgzSmxZMlZwZG1Wa0lEMGdLSFJ5WVdSbFgyRnRiM1Z1ZENBcUlIbGxjMTl3YjI5c0tTQXZMeUFvYm05ZmNHOXZiQ0FySUhSeVlXUmxYMkZ0YjNWdWRDa0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQXFDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qVTFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29ZWEpqTkM1VlNXNTBOalFvYzJoaGNtVnpYM0psWTJWcGRtVmtLU3dnWVhKak5DNVZTVzUwTmpRb1ptVmxYMkZ0YjNWdWRDa3BLUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVaMlYwWDIxaGNtdGxkRjl2WkdSektHMWhjbXRsZEY5cFpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwWDIxaGNtdGxkRjl2WkdSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalUzTFRZMU9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWjJWMFgyMWhjbXRsZEY5dlpHUnpLSE5sYkdZc0lHMWhjbXRsZEY5cFpEb2dWVWx1ZERZMEtTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVWVWx1ZERZMExDQmhjbU0wTGxWSmJuUTJORjA2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalkyTUFvZ0lDQWdMeThnWVhOelpYSjBJRzFoY210bGRGOXBaQ0E4SUhObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3k1MllXeDFaU3dnSWsxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl0WVhKclpYUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMjFoY210bGRITWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZMk1nb2dJQ0FnTHk4Z2NHOXZiSE1nUFNCelpXeG1MbWRsZEY5dFlYSnJaWFJmY0c5dmJITW9iV0Z5YTJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRZWEpyWlhSZmNHOXZiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZMk13b2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQndiMjlzYzFzd1hTNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOalkwQ2lBZ0lDQXZMeUJ1YjE5d2IyOXNJRDBnY0c5dmJITmJNVjB1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpZMkNpQWdJQ0F2THlCMGIzUmhiRjlzYVhGMWFXUnBkSGtnUFNCNVpYTmZjRzl2YkNBcklHNXZYM0J2YjJ3S0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpZM0NpQWdJQ0F2THlCcFppQjBiM1JoYkY5c2FYRjFhV1JwZEhrZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJR2RsZEY5dFlYSnJaWFJmYjJSa2MxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVZVbHVkRFkwS0RVd0tTd2dZWEpqTkM1VlNXNTBOalFvTlRBcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TXpJd01EQXdNREF3TURBd01EQXdNRE15Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMjFoY210bGRGOXZaR1J6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZM01DMDJOekVLSUNBZ0lDOHZJQ01nUTI5MWJuUmxjaTFwYm5SMWFYUnBkbVVnUVUxTklIQnlhV05wYm1jNklHeGhjbWRsY2lCT1R5QndiMjlzSUQwZ2FHbG5hR1Z5SUZsRlV5QndjbTlpWVdKcGJHbDBlUW9nSUNBZ0x5OGdlV1Z6WDNCbGNtTmxiblJoWjJVZ1BTQW9ibTlmY0c5dmJDQXFJREV3TUNrZ0x5OGdkRzkwWVd4ZmJHbHhkV2xrYVhSNUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNREFnTHk4Z01UQXdDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk56SUtJQ0FnSUM4dklHNXZYM0JsY21ObGJuUmhaMlVnUFNBb2VXVnpYM0J2YjJ3Z0tpQXhNREFwSUM4dklIUnZkR0ZzWDJ4cGNYVnBaR2wwZVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhwYm5RZ01UQXdJQzh2SURFd01Bb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNoNVpYTmZjR1Z5WTJWdWRHRm5aU2tzSUdGeVl6UXVWVWx1ZERZMEtHNXZYM0JsY21ObGJuUmhaMlVwS1NrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WjJWMFgzVnpaWEpmY0c5emFYUnBiMjVmZG1Gc2RXVW9kWE5sY2pvZ1lubDBaWE1zSUcxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYM1Z6WlhKZmNHOXphWFJwYjI1ZmRtRnNkV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk56WXROamMzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmZFhObGNsOXdiM05wZEdsdmJsOTJZV3gxWlNoelpXeG1MQ0IxYzJWeU9pQkJZMk52ZFc1MExDQnRZWEpyWlhSZmFXUTZJRlZKYm5RMk5Da2dMVDRnWVhKak5DNVVkWEJzWlZ0aGNtTTBMbFZKYm5RMk5Dd2dZWEpqTkM1VlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTnprS0lDQWdJQzh2SUhWelpYSmZjMmhoY21WeklEMGdjMlZzWmk1blpYUmZkWE5sY2w5emFHRnlaWE1vZFhObGNpd2diV0Z5YTJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzVnpaWEpmYzJoaGNtVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT0RBS0lDQWdJQzh2SUc5a1pITWdQU0J6Wld4bUxtZGxkRjl0WVhKclpYUmZiMlJrY3lodFlYSnJaWFJmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdaMlYwWDIxaGNtdGxkRjl2WkdSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJPRElLSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE1nUFNCMWMyVnlYM05vWVhKbGMxc3dYUzV1WVhScGRtVUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk0TXdvZ0lDQWdMeThnYm05ZmMyaGhjbVZ6SUQwZ2RYTmxjbDl6YUdGeVpYTmJNVjB1Ym1GMGFYWmxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qZzBDaUFnSUNBdkx5QjVaWE5mYjJSa2N5QTlJRzlrWkhOYk1GMHVibUYwYVhabENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJPRFVLSUNBZ0lDOHZJRzV2WDI5a1pITWdQU0J2WkdSeld6RmRMbTVoZEdsMlpRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZNE55MDJPRGdLSUNBZ0lDOHZJQ01nUlhOMGFXMWhkR1ZrSUhaaGJIVmxJR0poYzJWa0lHOXVJR04xY25KbGJuUWdiMlJrY3lBb2JtOTBJR2QxWVhKaGJuUmxaV1FnY0dGNWIzVjBLUW9nSUNBZ0x5OGdlV1Z6WDNaaGJIVmxJRDBnS0hsbGMxOXphR0Z5WlhNZ0tpQjVaWE5mYjJSa2N5a2dMeThnTVRBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXhNREFnTHk4Z01UQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJPRGtLSUNBZ0lDOHZJRzV2WDNaaGJIVmxJRDBnS0c1dlgzTm9ZWEpsY3lBcUlHNXZYMjlrWkhNcElDOHZJREV3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXhNREFnTHk4Z01UQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJPVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNoNVpYTmZkbUZzZFdVcExDQmhjbU0wTGxWSmJuUTJOQ2h1YjE5MllXeDFaU2twS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WjJWMFgySnZlRjl1WVcxbGN5aHRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEY5aWIzaGZibUZ0WlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJPVE10TmprMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJuWlhSZlltOTRYMjVoYldWektITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVUzUnlhVzVuTENCaGNtTTBMbE4wY21sdVp5d2dZWEpqTkM1VGRISnBibWRkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yT1RZS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Tm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTVPQW9nSUNBZ0x5OGdjWFZsYzNScGIyNWZZbTk0WDI1aGJXVWdQU0JoY21NMExsTjBjbWx1WnloVGRISnBibWN1Wm5KdmJWOWllWFJsY3lodFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKeGRXVnpkR2x2YmlJcEtRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE56RTNOVFkxTnpNM05EWTVObVkyWlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qazVDaUFnSUNBdkx5QndiMjlzYzE5aWIzaGZibUZ0WlNBOUlHRnlZelF1VTNSeWFXNW5LRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLRzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkJ2YjJ4eklpa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjd01Bb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2w5aWIzaGZibUZ0WlNBOUlHRnlZelF1VTNSeWFXNW5LRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLRzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbU55WldGMGIzSWlLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZzJNemN5TmpVMk1UYzBObVkzTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56QXlDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29jWFZsYzNScGIyNWZZbTk0WDI1aGJXVXNJSEJ2YjJ4elgySnZlRjl1WVcxbExDQmpjbVZoZEc5eVgySnZlRjl1WVcxbEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QTJDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1blpYUmZkWE5sY2w5aWIzaGZibUZ0WlhNb2RYTmxjam9nWW5sMFpYTXNJRzFoY210bGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWjJWMFgzVnpaWEpmWW05NFgyNWhiV1Z6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56QTBMVGN3TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdaMlYwWDNWelpYSmZZbTk0WDI1aGJXVnpLSE5sYkdZc0lIVnpaWEk2SUVGalkyOTFiblFzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVUzUnlhVzVuTENCaGNtTTBMbE4wY21sdVoxMDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3dOd29nSUNBZ0x5OGdlV1Z6WDJKdmVGOXVZVzFsSUQwZ1lYSmpOQzVUZEhKcGJtY29VM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9ZaUoxYzJWeVh5SWdLeUIxYzJWeUxtSjVkR1Z6SUNzZ1lpSmZiV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOTVaWE1pS1NrS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE56VTNNelkxTnpJMVpnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjROV1kyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlRFZtTnprMk5UY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTURnS0lDQWdJQzh2SUc1dlgySnZlRjl1WVcxbElEMGdZWEpqTkM1VGRISnBibWNvVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vWWlKMWMyVnlYeUlnS3lCMWMyVnlMbUo1ZEdWeklDc2dZaUpmYldGeWEyVjBYeUlnS3lCdmNDNXBkRzlpS0cxaGNtdGxkRjlwWkNrZ0t5QmlJbDl1YnlJcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZzFaalpsTm1ZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3hNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LSGxsYzE5aWIzaGZibUZ0WlN3Z2JtOWZZbTk0WDI1aGJXVXBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNTJZV3hwWkdGMFpWOTBjbUZrYVc1blgzQmhjbUZ0Y3lodFlYSnJaWFJmYVdRNklIVnBiblEyTkN3Z2NHRjViV1Z1ZEY5aGJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25aaGJHbGtZWFJsWDNSeVlXUnBibWRmY0dGeVlXMXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpFeUxUY3hNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE1vYzJWc1ppd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXNJSEJoZVcxbGJuUmZZVzF2ZFc1ME9pQlZTVzUwTmpRcElDMCtJR0Z5WXpRdVZIVndiR1ZiWVhKak5DNUNiMjlzTENCaGNtTTBMbE4wY21sdVoxMDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeE5Rb2dJQ0FnTHk4Z2FXWWdiV0Z5YTJWMFgybGtJRDQ5SUhObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3k1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5dFlYSnJaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE1nWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUR3OUNpQWdJQ0JpZWlCMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4TmdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVRbTl2YkNoR1lXeHpaU2tzSUdGeVl6UXVVM1J5YVc1bktDSk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpS1NrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNRE13TURFMU5HUTJNVGN5Tm1JMk5UYzBNakEyTkRabU5qVTNNekl3Tm1VMlpqYzBNakEyTlRjNE5qazNNemMwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpFNENpQWdJQ0F2THlCcFppQndZWGx0Wlc1MFgyRnRiM1Z1ZENBOElGVkpiblEyTkNneE1EQXdLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNREFLSUNBZ0lEd0tJQ0FnSUdKNklIWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpFNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVDYjI5c0tFWmhiSE5sS1N3Z1lYSmpOQzVUZEhKcGJtY29JazFwYm1sdGRXMGdjR0Y1YldWdWRDQnBjeUF4TURBd0lHMXBZM0p2UVV4SFQzTWlLU2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01ETXdNREl5TkdRMk9UWmxOamsyWkRjMU5tUXlNRGN3TmpFM09UWmtOalUyWlRjME1qQTJPVGN6TWpBek1UTXdNekF6TURJd05tUTJPVFl6TnpJMlpqUXhOR00wTnpSbU56TUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNNakVLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeU1nb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NElEMGdRbTk0VW1WbUtHdGxlVDF0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp3YjI5c2N5SXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROekEyWmpabU5tTTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpJekNpQWdJQ0F2THlCcFppQndiMjlzYzE5aWIzZ3ViR1Z1WjNSb0lEMDlJREE2Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZbTU2SUhaaGJHbGtZWFJsWDNSeVlXUnBibWRmY0dGeVlXMXpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOekkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvWVhKak5DNUNiMjlzS0VaaGJITmxLU3dnWVhKak5DNVRkSEpwYm1jb0lrMWhjbXRsZENCa1lYUmhJRzV2ZENCbWIzVnVaQ0lwS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNekF3TVRVMFpEWXhOekkyWWpZMU56UXlNRFkwTmpFM05EWXhNakEyWlRabU56UXlNRFkyTm1ZM05UWmxOalFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTWpZS0lDQWdJQzh2SUhCdmIyeHpYMlJoZEdFc0lGOWxlR2x6ZEhNZ1BTQndiMjlzYzE5aWIzZ3ViV0Y1WW1Vb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOekkzQ2lBZ0lDQXZMeUJwYzE5eVpYTnZiSFpsWkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9OREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpJNENpQWdJQ0F2THlCeVpYTnZiSFYwYVc5dVgzUnBiV1VnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtETXlLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN6TUFvZ0lDQWdMeThnYVdZZ2FYTmZjbVZ6YjJ4MlpXUWdJVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmZEhKaFpHbHVaMTl3WVhKaGJYTmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExrSnZiMndvUm1Gc2MyVXBMQ0JoY21NMExsTjBjbWx1WnlnaVRXRnlhMlYwSUdseklHRnNjbVZoWkhrZ2NtVnpiMngyWldRaUtTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURNd01ERmhOR1EyTVRjeU5tSTJOVGMwTWpBMk9UY3pNakEyTVRaak56STJOVFl4TmpRM09USXdOekkyTlRjek5tWTJZemMyTmpVMk5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qY3pNd29nSUNBZ0x5OGdhV1lnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQajBnY21WemIyeDFkR2x2Ymw5MGFXMWxPZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCMllXeHBaR0YwWlY5MGNtRmthVzVuWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTXpRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTENCaGNtTTBMbE4wY21sdVp5Z2lWSEpoWkdsdVp5Qm9ZWE1nWlc1a1pXUWlLU2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01ETXdNREV4TlRRM01qWXhOalEyT1RabE5qY3lNRFk0TmpFM016SXdOalUyWlRZME5qVTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25aaGJHbGtZWFJsWDNSeVlXUnBibWRmY0dGeVlXMXpYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTXpZS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NoaGNtTTBMa0p2YjJ3b1ZISjFaU2tzSUdGeVl6UXVVM1J5YVc1bktDSldZV3hwWkNJcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dNREF3TXpBd01EVTFOall4Tm1NMk9UWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMExtTnZiblJ5WVdOMExsQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZEM1blpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllU2dwSUMwK0lHSjVkR1Z6T2dwblpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjek9DMDNNemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjloYkd4ZmJXRnlhMlYwYzE5emRXMXRZWEo1S0hObGJHWXBJQzArSUdGeVl6UXVWSFZ3YkdWYllYSmpOQzVWU1c1ME5qUXNJR0Z5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5GMDZDaUFnSUNCd2NtOTBieUF3SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME1Rb2dJQ0FnTHk4Z2RHOTBZV3hmYldGeWEyVjBjeUE5SUhObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3k1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMwTWdvZ0lDQWdMeThnZEc5MFlXeGZabVZsY3lBOUlITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR3hoZEdadmNtMWZabVZsY3lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME5DMDNORFVLSUNBZ0lDOHZJQ01nUTJGc1kzVnNZWFJsSUhSdmRHRnNJSFp2YkhWdFpTQmhZM0p2YzNNZ1lXeHNJRzFoY210bGRITUtJQ0FnSUM4dklIUnZkR0ZzWDNadmJIVnRaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hSdmRHRnNYMjFoY210bGRITXBPZ29nSUNBZ1pIVndDZ3BuWlhSZllXeHNYMjFoY210bGRITmZjM1Z0YldGeWVWOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05EWUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoMGIzUmhiRjl0WVhKclpYUnpLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFgyRnNiRjl0WVhKclpYUnpYM04xYlcxaGNubGZZV1owWlhKZlptOXlRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjME53b2dJQ0FnTHk4Z2JXRnlhMlYwWDNCeVpXWnBlQ0E5SUdJaWJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHa3BJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelE0Q2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluQnZiMnh6SWlrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnM01EWm1ObVkyWXpjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNORGtLSUNBZ0lDOHZJR2xtSUhCdmIyeHpYMkp2ZUM1c1pXNW5kR2dnUGlBd09nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVGSmxaaUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0o2SUdkbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelV3Q2lBZ0lDQXZMeUJ3YjI5c2MxOWtZWFJoTENCZlpYaHBjM1J6SUQwZ2NHOXZiSE5mWW05NExtMWhlV0psS0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qYzFNUW9nSUNBZ0x5OGdiV0Z5YTJWMFgzWnZiSFZ0WlNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NVFlwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjMU1nb2dJQ0FnTHk4Z2RHOTBZV3hmZG05c2RXMWxJQ3M5SUcxaGNtdGxkRjkyYjJ4MWJXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLQ21kbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qYzBOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtIUnZkR0ZzWDIxaGNtdGxkSE1wT2dvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJR0lnWjJWMFgyRnNiRjl0WVhKclpYUnpYM04xYlcxaGNubGZabTl5WDJobFlXUmxja0F4Q2dwblpYUmZZV3hzWDIxaGNtdGxkSE5mYzNWdGJXRnllVjloWm5SbGNsOW1iM0pBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qYzFOUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvZEc5MFlXeGZiV0Z5YTJWMGN5a3NDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelUyQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoMGIzUmhiRjkyYjJ4MWJXVXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMxTndvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2RHOTBZV3hmWm1WbGN5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOVFF0TnpVNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvZEc5MFlXeGZiV0Z5YTJWMGN5a3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2RHOTBZV3hmZG05c2RXMWxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaDBiM1JoYkY5bVpXVnpLUW9nSUNBZ0x5OGdLU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUpBQUVJNkFlUUhJRG5oQStRVHNDRVBZQ0plaVlQQkJVZmZIVU5kRzkwWVd4ZmJXRnlhMlYwY3dkdFlYSnJaWFJmQVY4RllXUnRhVzRGY0c5dmJITU5jR3hoZEdadmNtMWZabVZsY3dFQURXMXBibDlzYVhGMWFXUnBkSGtJY1hWbGMzUnBiMjRGZFhObGNsOElYMjFoY210bGRGOEhZM0psWVhSdmNnUmZlV1Z6QTE5dWJ6RWJRUU8rZ2g4RVUrY0dtd1NRK05Ub0JLUUVJVElFbmQxYy9BU2FYM0ovQklUaVlLY0VsMXBTR1FTelpTVGNCT25YOTdJRUQrVXQrd1JQdHEvY0JJeWRTckVFcmR5V3F3UWFQR1pUQkhKNFV4NEVjZ0dKYndUc1dJQnhCQU44cWQwRXZzS2N5Z1FIVXp1VkJQZWcvU2tFWlV5YXJBU25LMXhkQkpYTXFGMEU4THFWNWdRa2dyZ1JCUEhNOTB3RVIxR09aQVRzaW83N0JENVluSElFZmhEb3hqWWFBSTRmQXJVQ2pBSmpBa2NDTXdJZkFnb0I2d0hNQWJrQnFBR1hBWVlCYkFGWEFVY0JOd0VuQVFVQTd3RGVBTW9BdGdDZUFJWUFjZ0JZQUVRQUtnQVNBQUlpUXpFWkZFUXhHRVNJQzlRb1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFoZUlDc0VvVEZDd0kwTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ0Y0Z0thaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhpQW9BS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmZBSERZYUFoZUlDYk1vVEZDd0kwTXhHUlJFTVJoRU5ob0JGNGdKVHloTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Y0Z0k5U2hNVUxBalF6RVpGRVF4R0VRMkdnRVhOaG9DRjRnSW15aE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBaGtLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlDQ3dvVEZDd0kwTXhHUlJFTVJoRWlBZ1RGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVh3QnlJQitvb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhjMkdnUVhpQWVLS0V4UXNDTkRNUmtVUkRFWVJJZ0hSeWhNVUxBalF6RVpGRVF4R0VTSUJ5Z29URkN3STBNeEdSUkVNUmhFaUFieEtFeFFzQ05ETVJrVVJERVlSRFlhQVJlSUJsY1dLRXhRc0NORE1Sa1VSREVZUkRZYUFSZkFIRFlhQWhlSUJmWW9URkN3STBNeEdSUkVNUmhFaUFYQkZpaE1VTEFqUXpFWkZFUXhHRVNJQmFvV0tFeFFzQ05ETVJrVVJERVlSSWdGbEJZb1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFvZ0ZIaU5ETVJrVVJERVlSRFlhQVJjeEZpTUpTVGdRSXhKRWlBUTZGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhNUllqQ1VrNEVDTVNSSWdEVVJZb1RGQ3dJME14R1JSRU1SaEVOaG9CRjRnREZoWW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0N6U2hNVUxBalF6RVpGRVF4R0VRMkdnRVhpQUtLS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmVJQW1GSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhOaG9ERnpFV0l3bEpPQkFqRWtTSUFiY1dLRXhRc0NORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWhjMkdnTVhNUllqQ1VrNEVDTVNSSWdBMGhZb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhjeEZpTUpTVGdRSXhKRWlBQVNGaWhNVUxBalF6RVpRUDBkTVJnVVJDTkRpZ1FCSWljRVpVUXlBeEpCQUJFbkJERUFaeWtpWnljR0ltY25DQ0VIWnpJSk1RQVNJaWNFWlVReEFCSVJSSXYrSlE1RWkvODRCeklLRWtTTC96Z0lTU0VJRDBReUJ5RUVDSXY5REVReUJ5RUZDSXY5RDBRaUtXVkVTUllxVEZBclVFa25DVkNML0w5UEFvRUNDaFpKVUNJV1RFc0JVSXYrRmxDTC9SWlFTd0ZRVEZCTEFTY0ZVRXkvSnd4UU1RQy9TU01JS1V4bmlZb0VBWUFBSWljRVpVUXlBeEpCQUtBbkJERUFaeWtpWnljR0ltY2lKd2hsUkVBQUJTY0lJUWRuaS80bERrU0wvemdITWdvU1JJdi9PQWhKakFBaUp3aGxSSUVDQ3c5RWkvMkJnTWl2b0NVTlFRQllpLzBsQ2pJSElRUUlTd0VNUkRJSElRVUlTd0VQUkNJcFpVUkpGaXBNVUN0UVNTY0pVSXY4djRzQWdRSUtGa2xRSWhaTVN3RlFpLzRXVUU4RUZsQkxBVkJNVUVzQkp3VlFUTDhuREZBeEFMOUpJd2dwVEdkTWlZdjlRdituTVFBaUp3UmxSQkpFUXY5dGlnUUJJaWNFWlVSSk1nTVRSREVBRWtTTC9pVU9SSXYvT0FjeUNoSkVpLzg0Q0VraENBOUVNZ2NoQkFpTC9ReEVNZ2NoQlFpTC9ROUVJaWxsUkVrV0treFFLMUJKSndsUWkveS9Ud0tCQWdvV1NWQWlGa3hMQVZDTC9oWlFpLzBXVUVzQlVFeFFTd0VuQlZCTXZ5Y01VREVBdjBrakNDbE1aNG1LQVFHTC94WXFURkFyVUNjSlVFbTlSRVMrU0ltS0FRR0wveFlxVEZBclVDY0ZVRW05UkVTK1NFa2lXMHNCSkZ0UEFvRVFXMDhDRms4Q0ZrOENGazRDVUV4UWlZb0JBWXYvRmlwTVVDdFFKd1ZRU2IxRVJMNUlTWUVvVzB5Qk1GdE1JeEluQnlKUEFsUk1JeEluQnlKUEFsUWlVeU5NVkltS0FRR0wvNGovbFVraVcwd2tXMGxPQWdoSlFBQUdnZlFEakFDSml3QWxDNHNCQ293QWlZb0NBWXYrRmlwTEFWQXJVQ2NGVUVtOVJFUkp2a2hKSWx0TEFTUmJTd0tCRUZ0TEE0RVlXMHNFZ1NCYlN3V0JLRnRKRkVReUIwc0NERVNML3pnQU1RQVNSSXYvT0FjeUNoSkVpLzg0Q0VsRVNTVVBSRWxMQkFzaEJncEtDVWxMQ0F0UENVOENDRXhMQVFwT0MwOEdUd01JVHdlQk1GdFBBaFpQQnhaUVR3SVdVRThGRmxCUEJCWlFUd01XVUV3V1VFOENUTDhpSndabFJBZ25Ca3huSndveEFGQW5DMUJNVUNjTlVFa2lUTDFFUVFBSGl3RytTQmVNQW9zQ2l3QkpUZ0lJRm9zQlRMK01BSW1LQWdHTC9oWXFTd0ZRSzFBbkJWQkp2VVJFU2I1SVNTSmJTd0VrVzBzQ2dSQmJTd09CR0Z0TEJJRWdXMHNGZ1NoYlNSUkVNZ2RMQWd4RWkvODRBREVBRWtTTC96Z0hNZ29TUkl2L09BaEpSRWtsRDBSSlN3UUxJUVlLU2dsSlN3a0xUd2hQQWdoTVN3RUtUZ3RQQms4RENFOEhnVEJiVHdjV1R3TVdVRThDRmxCUEJSWlFUd1FXVUU4REZsQk1GbEJQQWt5L0lpY0daVVFJSndaTVp5Y0tNUUJRSnd0UVRGQW5EbEJKSWt5OVJFRUFCNHNCdmtnWGpBS0xBb3NBU1U0Q0NCYUxBVXkvakFDSmlnSUFNUUFpSndSbFJCSkVpLzRXS2t4UUsxQW5CVkJKdlVSRVNiNUlTU0piU3dFa1cwc0NnUkJiU3dPQkdGdExCSUVnVzA4RmdTaGJGRVF5QjBzQkQwUlBCQlpQQkJaUVR3TVdVRThDRmxCTUZsQWpGbENML3lKVEZsQy9pU0lwWlVTSklpY0daVVNKTVFBaUp3UmxSQkpFSWljR1pVUkpSQ2NHSW1leE1RQkxBYklJc2djanNoQWlzZ0d6aVlvQ0FTS0FBQ2NLaS81UUp3dFFpLzhXVUVrbkRWQkpJa3k5UkVFQUI0c0R2a2dYakFTTEFpY09VRW1NQUNLTUFiMUVRUUFIaXdDK1NCZU1BWXNFRm9zQkZsQ01BSW1LQVFFaVNZdi9Ga2txVEZBclVDY0ZVRW05UkVTK1NFbUJLRnRNZ1RCYlRDTVNSREVBaS8rSS81QkpJbHRPQXlSYlRnSWpFa0VBTUNjS01RQlFKd3RRVEZBbkRWQkpqQUc5UkVFQUJJc0J2RWlMQWtsRXNURUFTd0d5Q0xJSEk3SVFJcklCczR3QWlTY0tNUUJRSnd0UVRGQW5EbEJKakFDOVJFRUFCSXNBdkVpTEEwTC96U0luQkdWRVNSV0JJQkpFSWlsbFJCWWlKd1psUkJZaUp3aGxSQlpQQTA4RFVFOENVRXhRaVNJbkJHVkVNZ01USndjaVR3SlVpWW9BQVNJbkJHVkVNZ01USndjaVN3SlVURUVBR1NJbkJHVkVTUldCSUJKRUlpbGxSQmFMQUU4Q1VFeFFUSWt5QTBMLzU0b0VBWXYrSlExQkFBTW5CNGtpSndobFJJRUNDNHYvRFVFQUF5Y0hpVElISVFRSWkvMFBRUUFESndlSk1nY2hCUWlML1F4QkFBTW5CNG1BQVlDSmlnRUJJaWNFWlVTTC94SW5CeUpQQWxTSklpY0laVVNCQWd1SmlnRUJJaWxsUkl2L0RrRUFBeWNIaVl2L0ZpcE1VQ3RRSndsUXZVUW5CeUpQQWxTSmlnRUJJaWxsUkl2L0RVU0wveFlxVEZBclVDY01VRW05UkVTK1NFa1ZnU0FTUkltS0FnRWlLV1ZFaS80TlJJditGaXBNVUN0UUp3VlFTYjFFUkw1SVNTSmJTd0VrVzA4Q2dSaGJpLzhMSVFZS2kvOUxBUWxKVHdNTFR3TlBBZ2dLRmt3V1VJbUtBZ0VpS1dWRWkvNE5SSXYrRmlwTVVDdFFKd1ZRU2IxRVJMNUlTU0piU3dFa1cwOENnUmhiaS84TElRWUtpLzlMQVFsSlR3UUxUd05QQWdnS0Zrd1dVSW1LQVFFaUtXVkVpLzhOUkl2L2lQcnNTU0piU1U4Q0pGdEpUZ0lJU1VBQUZZQVFBQUFBQUFBQUFESUFBQUFBQUFBQU1vd0FpWXNCZ1dRTGl3SkpUZ0lLaXdDQlpBdFBBZ3BNRmt3V1VJd0FpWW9DQVl2K2kvK0kvVTJMLzRqL29Vc0JJbHRQQWlSYlN3SWlXMDhESkZ0UEEwOENDNEZrQ2s0Q0M0RmtDa3dXVEJaUWlZb0JBWXYvRmlwTVVDdFFTU2NKVUVrVkZsY0dBa3hRU3dFbkJWQkpGUlpYQmdKTVVFOENKd3hRU1JVV1Z3WUNURkJMQWhXQkJnaEpGbGNHQW9BQ0FBWk1VRXNERlU4Q0NCWlhCZ0pRVHdOUVR3SlFURkNKaWdJQkp3cUwvbEFuQzFDTC94WlFTU2NOVUVrVkZsY0dBa3hRVENjT1VFa1ZGbGNHQWt4UVN3RVZnUVFJRmxjR0FvQUNBQVJNVUU4Q1VFeFFpWW9DQVNLQUFDSXBaVVNML2c1QkFCK0FHZ0FBQXdBVlRXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBqQUNKaS84bERFRUFMSUFuQUFBREFDSk5hVzVwYlhWdElIQmhlVzFsYm5RZ2FYTWdNVEF3TUNCdGFXTnliMEZNUjA5empBQ0ppLzRXS2t4UUsxQW5CVkJKakFDOVJFQUFINEFhQUFBREFCVk5ZWEpyWlhRZ1pHRjBZU0J1YjNRZ1ptOTFibVNNQUltTEFMNUlTWUVvVzB5QklGdU1BVUVBSklBZkFBQURBQnBOWVhKclpYUWdhWE1nWVd4eVpXRmtlU0J5WlhOdmJIWmxaSXdBaVRJSGl3RVBRUUFiZ0JZQUFBTUFFVlJ5WVdScGJtY2dhR0Z6SUdWdVpHVmtqQUNKZ0FxQUFBTUFCVlpoYkdsa2pBQ0ppZ0FCSW9BQUlpbGxSQ0luQm1WRUlrbUxCWXNDREVFQU1Jc0ZGaXBNVUN0UUp3VlFTWXdBdlVTTEJJd0JRUUFNaXdDK1NJRVFXNHNFQ0l3Qml3R01CSXNGSXdpTUJVTC95SXNDRm9zRUZvc0RGazRDVUV4UWpBQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
