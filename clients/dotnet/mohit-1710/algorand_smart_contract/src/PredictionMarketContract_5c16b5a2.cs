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

namespace Arc56.Generated.mohit_1710.algorand_smart_contract.PredictionMarketContract_5c16b5a2
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
        ///Initialize the contract with admin and minimum liquidity requirement
        ///</summary>
        /// <param name="min_liquidity"> </param>
        public async Task InitializeContract(ulong min_liquidity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 192, 33, 4 };
            var min_liquidityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_liquidityAbi.From(min_liquidity);

            var result = await base.CallApp(new List<object> { abiHandle, min_liquidityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeContract_Transactions(ulong min_liquidity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 192, 33, 4 };
            var min_liquidityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_liquidityAbi.From(min_liquidity);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_liquidityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new prediction market
        ///TRANSACTION REQUIREMENTS: 1. Payment transaction must be sent TO the contract address 2. Payment amount must be >= 2x min_liquidity (2 ALGO minimum) 3. App call and payment must be in same group 4. Only admin can create markets
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGlvbk1hcmtldENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldE1hcmtldFBvb2xzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRNYXJrZXRTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dLCJHZXRVc2VyU2hhcmVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldENvbnRyYWN0RGVidWdJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldEJveE5hbWVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn1dLCJHZXRVc2VyQm94TmFtZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiVmFsaWRhdGVUcmFkaW5nUGFyYW1zUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemVfY29udHJhY3QiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgY29udHJhY3Qgd2l0aCBhZG1pbiBhbmQgbWluaW11bSBsaXF1aWRpdHkgcmVxdWlyZW1lbnQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2xpcXVpZGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfbWFya2V0IiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBwcmVkaWN0aW9uIG1hcmtldFxuVFJBTlNBQ1RJT04gUkVRVUlSRU1FTlRTOiAxLiBQYXltZW50IHRyYW5zYWN0aW9uIG11c3QgYmUgc2VudCBUTyB0aGUgY29udHJhY3QgYWRkcmVzcyAyLiBQYXltZW50IGFtb3VudCBtdXN0IGJlID49IDJ4IG1pbl9saXF1aWRpdHkgKDIgQUxHTyBtaW5pbXVtKSAzLiBBcHAgY2FsbCBhbmQgcGF5bWVudCBtdXN0IGJlIGluIHNhbWUgZ3JvdXAgNC4gT25seSBhZG1pbiBjYW4gY3JlYXRlIG1hcmtldHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb25fdGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX3JhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X3F1ZXN0aW9uIiwiZGVzYyI6IkdldCBtYXJrZXQgcXVlc3Rpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hcmtldF9wb29scyIsImRlc2MiOiJHZXQgbWFya2V0IHBvb2xzOiAoeWVzX3Bvb2wsIG5vX3Bvb2wsIHRvdGFsX3ZvbHVtZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNYXJrZXRQb29sc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXRfc3RhdHVzIiwiZGVzYyI6IkdldCBtYXJrZXQgc3RhdHVzOiAoaXNfcmVzb2x2ZWQsIHdpbm5pbmdfb3V0Y29tZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wpIiwic3RydWN0IjoiR2V0TWFya2V0U3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlX3llc19wcmljZSIsImRlc2MiOiJDYWxjdWxhdGUgY3VycmVudCBZZXMgcHJpY2UgKHNjYWxlZCBieSAxMDAwKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfeWVzX3NoYXJlcyIsImRlc2MiOiJCdXkgWWVzIHNoYXJlcyBpbiBhIG1hcmtldFxuVFJBTlNBQ1RJT04gUkVRVUlSRU1FTlRTOiAxLiBQYXltZW50IHRyYW5zYWN0aW9uIG11c3QgYmUgc2VudCBUTyB0aGUgY29udHJhY3QgYWRkcmVzcyAyLiBQYXltZW50IG11c3QgYmUgZnJvbSB0aGUgc2FtZSBzZW5kZXIgYXMgYXBwIGNhbGwgMy4gTWluaW11bSBwYXltZW50OiAxMDAwIG1pY3JvQUxHT3MgNC4gTWFya2V0IG11c3QgYmUgYWN0aXZlIGFuZCBub3QgcmVzb2x2ZWQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5X25vX3NoYXJlcyIsImRlc2MiOiJCdXkgTm8gc2hhcmVzIGluIGEgbWFya2V0IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc29sdmVfbWFya2V0IiwiZGVzYyI6IlJlc29sdmUgYSBtYXJrZXQgd2l0aCB0aGUgd2lubmluZyBvdXRjb21lIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Inllc193aW5zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9tYXJrZXRzIiwiZGVzYyI6IkdldCB0b3RhbCBudW1iZXIgb2YgbWFya2V0cyBjcmVhdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BsYXRmb3JtX2ZlZXMiLCJkZXNjIjoiR2V0IHRvdGFsIHBsYXRmb3JtIGZlZXMgY29sbGVjdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfZmVlcyIsImRlc2MiOiJXaXRoZHJhdyBjb2xsZWN0ZWQgcGxhdGZvcm0gZmVlcyAoYWRtaW4gb25seSkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zaGFyZXMiLCJkZXNjIjoiR2V0IHVzZXIncyBZZXMgYW5kIE5vIHNoYXJlcyBmb3IgYSBtYXJrZXQiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyU2hhcmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVkZWVtX3dpbm5pbmdfc2hhcmVzIiwiZGVzYyI6IlJlZGVlbSB3aW5uaW5nIHNoYXJlcyBmb3IgYSByZXNvbHZlZCBtYXJrZXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X2RlYnVnX2luZm8iLCJkZXNjIjoiR2V0IGNvbnRyYWN0IHN0YXRlIGZvciBkZWJ1Z2dpbmciLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Q29udHJhY3REZWJ1Z0luZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9jcmVhdGVfbWFya2V0X3BhcmFtcyIsImRlc2MiOiJWYWxpZGF0ZSBtYXJrZXQgY3JlYXRpb24gcGFyYW1ldGVycyB3aXRob3V0IGNyZWF0aW5nIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1ZXN0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNvbHV0aW9uX3RpbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZV9yYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5fY3JlYXRlX21hcmtldCIsImRlc2MiOiJDaGVjayBpZiBzZW5kZXIgY2FuIGNyZWF0ZSBtYXJrZXRzIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVpcmVkX3BheW1lbnRfZm9yX21hcmtldCIsImRlc2MiOiJDYWxjdWxhdGUgcmVxdWlyZWQgcGF5bWVudCBmb3IgbWFya2V0IGNyZWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya2V0X2V4aXN0cyIsImRlc2MiOiJDaGVjayBpZiBtYXJrZXQgZXhpc3RzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X2NyZWF0b3IiLCJkZXNjIjoiR2V0IG1hcmtldCBjcmVhdG9yIGFkZHJlc3MiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlX3llc190cmFkZSIsImRlc2MiOiJTaW11bGF0ZSBZRVMgdHJhZGUgd2l0aG91dCBleGVjdXRpbmcgLSBSZXR1cm5zIChzaGFyZXNfcmVjZWl2ZWQsIGZlZV9hbW91bnQpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclNoYXJlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbXVsYXRlX25vX3RyYWRlIiwiZGVzYyI6IlNpbXVsYXRlIE5PIHRyYWRlIHdpdGhvdXQgZXhlY3V0aW5nIC0gUmV0dXJucyAoc2hhcmVzX3JlY2VpdmVkLCBmZWVfYW1vdW50KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJTaGFyZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWFya2V0X29kZHMiLCJkZXNjIjoiR2V0IG1hcmtldCBvZGRzIGFzIHBlcmNlbnRhZ2VzIC0gUmV0dXJucyAoeWVzX3BlcmNlbnRhZ2UsIG5vX3BlcmNlbnRhZ2UpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyU2hhcmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfcG9zaXRpb25fdmFsdWUiLCJkZXNjIjoiR2V0IGVzdGltYXRlZCB2YWx1ZSBvZiB1c2VyJ3MgcG9zaXRpb24gLSBSZXR1cm5zICh5ZXNfdmFsdWUsIG5vX3ZhbHVlKSBpbiBtaWNyb0FMR09zIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlclNoYXJlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ib3hfbmFtZXMiLCJkZXNjIjoiR2V0IGJveCBuYW1lcyBmb3IgYSBtYXJrZXQgLSBSZXR1cm5zIChxdWVzdGlvbl9ib3gsIHBvb2xzX2JveCwgY3JlYXRvcl9ib3gpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR2V0Qm94TmFtZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9ib3hfbmFtZXMiLCJkZXNjIjoiR2V0IHVzZXIgYm94IG5hbWVzIGZvciBhIG1hcmtldCAtIFJldHVybnMgKHllc19ib3gsIG5vX2JveCkiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZykiLCJzdHJ1Y3QiOiJHZXRVc2VyQm94TmFtZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV90cmFkaW5nX3BhcmFtcyIsImRlc2MiOiJWYWxpZGF0ZSB0cmFkaW5nIHBhcmFtZXRlcnMgLSBSZXR1cm5zIChpc192YWxpZCwgZXJyb3JfbWVzc2FnZSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxzdHJpbmcpIiwic3RydWN0IjoiVmFsaWRhdGVUcmFkaW5nUGFyYW1zUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FsbF9tYXJrZXRzX3N1bW1hcnkiLCJkZXNjIjoiR2V0IHN1bW1hcnkgb2YgYWxsIG1hcmtldHMgLSBSZXR1cm5zICh0b3RhbF9tYXJrZXRzLCB0b3RhbF92b2x1bWUsIHRvdGFsX2ZlZXMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNYXJrZXRQb29sc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjA1MSwyMjM5XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzUzXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXNvbHZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjFdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDE6IE9ubHkgYWRtaW4gY2FuIGNyZWF0ZSBtYXJrZXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNl0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzEwMjogRmVlIHJhdGUgY2Fubm90IGV4Y2VlZCAxMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM0XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTAzOiBQYXltZW50IG11c3QgYmUgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUwXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMTA0OiBJbnN1ZmZpY2llbnQgbGlxdWlkaXR5IChuZWVkIDIgQUxHTyBtaW4pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MF0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzEwNTogUmVzb2x1dGlvbiB0aW1lIG11c3QgYmUgYXQgbGVhc3QgMSBob3VyIGluIGZ1dHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjldLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8xMDY6IFJlc29sdXRpb24gdGltZSB0b28gZmFyIGluIGZ1dHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNDIsMTU0NF0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzIwMTogTWFya2V0IGlzIHJlc29sdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0OCwxNTUwXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjAyOiBUcmFkaW5nIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1NiwxNTU4XSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjAzOiBQYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIGFwcCBjYWxsIHNlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNjQsMTU2Nl0sImVycm9yTWVzc2FnZSI6IkVSUk9SXzIwNDogUGF5bWVudCBtdXN0IGJlIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3MCwxNTcyXSwiZXJyb3JNZXNzYWdlIjoiRVJST1JfMjA1OiBQYXltZW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzc0LDE1NzZdLCJlcnJvck1lc3NhZ2UiOiJFUlJPUl8yMDY6IE1pbmltdW0gdHJhZGUgYW1vdW50IGlzIDEwMDAgbWljcm9BTEdPcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMTZdLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgSUQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjMxXSwiZXJyb3JNZXNzYWdlIjoiTWFya2V0IGNyZWF0b3IgZGF0YSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjY2LDIzMzJdLCJlcnJvck1lc3NhZ2UiOiJNYXJrZXQgZGF0YSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUwLDExNzEsMTIxOCwxMzA5LDE1MTEsMTcyMSwxOTI3LDIyNTEsMjMxNywyMzgzXSwiZXJyb3JNZXNzYWdlIjoiTWFya2V0IGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0MV0sImVycm9yTWVzc2FnZSI6Ik1hcmtldCBub3QgcmVzb2x2ZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxNV0sImVycm9yTWVzc2FnZSI6Ik5vIGZlZXMgdG8gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTkxXSwiZXJyb3JNZXNzYWdlIjoiTm8gd2lubmluZyBzaGFyZXMgdG8gcmVkZWVtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQxLDM1NywzODEsNDA3LDQyNyw0NTMsNDczLDQ5Nyw1MjEsNTQxLDU2MSw1NzgsNjAwLDYzNCw2NTAsNjcxLDY5Nyw3MTQsNzMxLDc0OCw3NjcsNzk4LDgyOSw4NTAsODcwLDg5MCw5MTgsOTU5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcwNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHJlc29sdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODA4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzU5XSwiZXJyb3JNZXNzYWdlIjoiVG9vIGVhcmx5IHRvIHJlc29sdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDQsMzYwLDM4NCw0MTAsNDMwLDQ1Niw0NzYsNTAwLDUyNCw1NDQsNTY0LDU4MSw2MDMsNjM3LDY1Myw2NzQsNzAwLDcxNyw3MzQsNzUxLDc3MCw4MDEsODMyLDg1Myw4NzMsODkzLDkyMSw5NjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0OSwxMTcwLDEyMTcsMTMwOCwxNDY2LDE1MTAsMTY2OCwxNzIwLDE4NjMsMTg4NiwxOTI2LDE5ODAsMjAyOCwyMTk4LDIyMzAsMjI2NSwyMzMxLDI3NjQsMjk0Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEJveFJlZiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE5LDE3MDQsMTgwNiwyMDQ1LDIxNTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDMsMjA2NywyMDk3LDIxNjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbl9saXF1aWRpdHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0MywxNjQ1LDE3OTgsMTgxMywyMDYxLDI5MTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBsYXRmb3JtX2ZlZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3MywxNzkyLDIwNTUsMjE3NiwyMjEyLDIyNDcsMjMxMywyMzc5LDI2NjAsMjkxMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfbWFya2V0cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODQsODE1LDk0NV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVYMTloYkdkdmNIbGZaVzUwY25sd2IybHVkRjkzYVhSb1gybHVhWFFvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ01UQXdNQ0F4TURBd01DQXpNVFV6TmpBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlEQjRObVEyTVRjeU5tSTJOVGMwTldZZ01IZzFaaUFpZEc5MFlXeGZiV0Z5YTJWMGN5SWdNSGczTURabU5tWTJZemN6SUNKd2JHRjBabTl5YlY5bVpXVnpJaUF3ZURBd0lDSmhaRzFwYmlJZ01IZzNOVGN6TmpVM01qVm1JREI0TldZMlpEWXhOekkyWWpZMU56UTFaaUFpYldsdVgyeHBjWFZwWkdsMGVTSWdNSGczTVRjMU5qVTNNemMwTmprMlpqWmxJREI0TldZM09UWTFOek1nTUhnMVpqWmxObVlnTUhnMk16Y3lOalUyTVRjME5tWTNNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURNekNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9XTmpNREl4TURRZ01IaGhOREEwTWpFek1pQXdlRGxrWkdRMVkyWmpJREI0T1dFMVpqY3lOMllnTUhnNE5HVXlOakJoTnlBd2VEazNOV0UxTWpFNUlEQjRZak0yTlRJMFpHTWdNSGhsT1dRM1pqZGlNaUF3ZURCbVpUVXlaR1ppSURCNE5HWmlObUZtWkdNZ01IZzRZemxrTkdGaU1TQXdlR0ZrWkdNNU5tRmlJREI0TVdFell6WTJOVE1nTUhnM01qYzROVE14WlNBd2VEY3lNREU0T1RabUlEQjRZbVZqTWpsalkyRWdNSGd3TnpVek0ySTVOU0F3ZUdZM1lUQm1aREk1SURCNE5qVTBZemxoWVdNZ01IaGhOekppTldNMVpDQXdlRGsxWTJOaE9EVmtJREI0WmpCaVlUazFaVFlnTUhneU5EZ3lZamd4TVNBd2VHWXhZMk5tTnpSaklEQjRORGMxTVRobE5qUWdNSGhsWXpoaE9HVm1ZaUF3ZURObE5UZzVZemN5SURCNE4yVXhNR1U0WXpZZ0x5OGdiV1YwYUc5a0lDSnBibWwwYVdGc2FYcGxYMk52Ym5SeVlXTjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZmYldGeWEyVjBLSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwTEhCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl0WVhKclpYUmZjWFZsYzNScGIyNG9kV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBYMjFoY210bGRGOXdiMjlzY3loMWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDIxaGNtdGxkRjl6ZEdGMGRYTW9kV2x1ZERZMEtTaGliMjlzTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0pqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUoxZVY5NVpYTmZjMmhoY21WektIVnBiblEyTkN4d1lYa3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmlkWGxmYm05ZmMyaGhjbVZ6S0hWcGJuUTJOQ3h3WVhrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpYTnZiSFpsWDIxaGNtdGxkQ2gxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmYldGeWEyVjBjeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmNHeGhkR1p2Y20xZlptVmxjeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkMTltWldWektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkxYzJWeVgzTm9ZWEpsY3loaFkyTnZkVzUwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbkpsWkdWbGJWOTNhVzV1YVc1blgzTm9ZWEpsY3loMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZlkyOXVkSEpoWTNSZlpHVmlkV2RmYVc1bWJ5Z3BLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5amNtVmhkR1ZmYldGeWEyVjBYM0JoY21GdGN5aHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaVkyRnVYMk55WldGMFpWOXRZWEpyWlhRb1lXTmpiM1Z1ZENsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZmNtVnhkV2x5WldSZmNHRjViV1Z1ZEY5bWIzSmZiV0Z5YTJWMEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltMWhjbXRsZEY5bGVHbHpkSE1vZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRjl0WVhKclpYUmZZM0psWVhSdmNpaDFhVzUwTmpRcFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWMybHRkV3hoZEdWZmVXVnpYM1J5WVdSbEtIVnBiblEyTkN4MWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p6YVcxMWJHRjBaVjl1YjE5MGNtRmtaU2gxYVc1ME5qUXNkV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYMjFoY210bGRGOXZaR1J6S0hWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5MWMyVnlYM0J2YzJsMGFXOXVYM1poYkhWbEtHRmpZMjkxYm5Rc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgySnZlRjl1WVcxbGN5aDFhVzUwTmpRcEtITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LU0lzSUcxbGRHaHZaQ0FpWjJWMFgzVnpaWEpmWW05NFgyNWhiV1Z6S0dGalkyOTFiblFzZFdsdWREWTBLU2h6ZEhKcGJtY3NjM1J5YVc1bktTSXNJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZkSEpoWkdsdVoxOXdZWEpoYlhNb2RXbHVkRFkwTEhWcGJuUTJOQ2tvWW05dmJDeHpkSEpwYm1jcElpd2diV1YwYUc5a0lDSm5aWFJmWVd4c1gyMWhjbXRsZEhOZmMzVnRiV0Z5ZVNncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZhVzVwZEdsaGJHbDZaVjlqYjI1MGNtRmpkRjl5YjNWMFpVQTFJRzFoYVc1ZlkzSmxZWFJsWDIxaGNtdGxkRjl5YjNWMFpVQTJJRzFoYVc1ZloyVjBYMjFoY210bGRGOXhkV1Z6ZEdsdmJsOXliM1YwWlVBM0lHMWhhVzVmWjJWMFgyMWhjbXRsZEY5d2IyOXNjMTl5YjNWMFpVQTRJRzFoYVc1ZloyVjBYMjFoY210bGRGOXpkR0YwZFhOZmNtOTFkR1ZBT1NCdFlXbHVYMk5oYkdOMWJHRjBaVjk1WlhOZmNISnBZMlZmY205MWRHVkFNVEFnYldGcGJsOWlkWGxmZVdWelgzTm9ZWEpsYzE5eWIzVjBaVUF4TVNCdFlXbHVYMkoxZVY5dWIxOXphR0Z5WlhOZmNtOTFkR1ZBTVRJZ2JXRnBibDl5WlhOdmJIWmxYMjFoY210bGRGOXliM1YwWlVBeE15QnRZV2x1WDJkbGRGOTBiM1JoYkY5dFlYSnJaWFJ6WDNKdmRYUmxRREUwSUcxaGFXNWZaMlYwWDNCc1lYUm1iM0p0WDJabFpYTmZjbTkxZEdWQU1UVWdiV0ZwYmw5M2FYUm9aSEpoZDE5bVpXVnpYM0p2ZFhSbFFERTJJRzFoYVc1ZloyVjBYM1Z6WlhKZmMyaGhjbVZ6WDNKdmRYUmxRREUzSUcxaGFXNWZjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6WDNKdmRYUmxRREU0SUcxaGFXNWZaMlYwWDJOdmJuUnlZV04wWDJSbFluVm5YMmx1Wm05ZmNtOTFkR1ZBTVRrZ2JXRnBibDkyWVd4cFpHRjBaVjlqY21WaGRHVmZiV0Z5YTJWMFgzQmhjbUZ0YzE5eWIzVjBaVUF5TUNCdFlXbHVYMk5oYmw5amNtVmhkR1ZmYldGeWEyVjBYM0p2ZFhSbFFESXhJRzFoYVc1ZloyVjBYM0psY1hWcGNtVmtYM0JoZVcxbGJuUmZabTl5WDIxaGNtdGxkRjl5YjNWMFpVQXlNaUJ0WVdsdVgyMWhjbXRsZEY5bGVHbHpkSE5mY205MWRHVkFNak1nYldGcGJsOW5aWFJmYldGeWEyVjBYMk55WldGMGIzSmZjbTkxZEdWQU1qUWdiV0ZwYmw5emFXMTFiR0YwWlY5NVpYTmZkSEpoWkdWZmNtOTFkR1ZBTWpVZ2JXRnBibDl6YVcxMWJHRjBaVjl1YjE5MGNtRmtaVjl5YjNWMFpVQXlOaUJ0WVdsdVgyZGxkRjl0WVhKclpYUmZiMlJrYzE5eWIzVjBaVUF5TnlCdFlXbHVYMmRsZEY5MWMyVnlYM0J2YzJsMGFXOXVYM1poYkhWbFgzSnZkWFJsUURJNElHMWhhVzVmWjJWMFgySnZlRjl1WVcxbGMxOXliM1YwWlVBeU9TQnRZV2x1WDJkbGRGOTFjMlZ5WDJKdmVGOXVZVzFsYzE5eWIzVjBaVUF6TUNCdFlXbHVYM1poYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxelgzSnZkWFJsUURNeElHMWhhVzVmWjJWMFgyRnNiRjl0WVhKclpYUnpYM04xYlcxaGNubGZjbTkxZEdWQU16SUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkZzYkY5dFlYSnJaWFJ6WDNOMWJXMWhjbmxmY205MWRHVkFNekk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOWhiR3hmYldGeWEyVjBjMTl6ZFcxdFlYSjVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6WDNKdmRYUmxRRE14T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNWelpYSmZZbTk0WDI1aGJXVnpYM0p2ZFhSbFFETXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdkbGRGOTFjMlZ5WDJKdmVGOXVZVzFsY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlltOTRYMjVoYldWelgzSnZkWFJsUURJNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFkzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklHTnNZWE56SUZCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFkzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJKdmVGOXVZVzFsY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRYTmxjbDl3YjNOcGRHbHZibDkyWVd4MVpWOXliM1YwWlVBeU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUxTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJuWlhSZmRYTmxjbDl3YjNOcGRHbHZibDkyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiV0Z5YTJWMFgyOWtaSE5mY205MWRHVkFNamM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU16RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU16RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiV0Z5YTJWMFgyOWtaSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMmx0ZFd4aGRHVmZibTlmZEhKaFpHVmZjbTkxZEdWQU1qWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTURrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTURrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6YVcxMWJHRjBaVjl1YjE5MGNtRmtaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXphVzExYkdGMFpWOTVaWE5mZEhKaFpHVmZjbTkxZEdWQU1qVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6YVcxMWJHRjBaVjk1WlhOZmRISmhaR1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDIxaGNtdGxkRjlqY21WaGRHOXlYM0p2ZFhSbFFESTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRjMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJR05zWVhOeklGQnlaV1JwWTNScGIyNU5ZWEpyWlhSRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRjMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyMWhjbXRsZEY5amNtVmhkRzl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjFoY210bGRGOWxlR2x6ZEhOZmNtOTFkR1ZBTWpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnRZWEpyWlhSZlpYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5eVpYRjFhWEpsWkY5d1lYbHRaVzUwWDJadmNsOXRZWEpyWlhSZmNtOTFkR1ZBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl5WlhGMWFYSmxaRjl3WVhsdFpXNTBYMlp2Y2w5dFlYSnJaWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1WDJOeVpXRjBaVjl0WVhKclpYUmZjbTkxZEdWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTlRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRVMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTJGdVgyTnlaV0YwWlY5dFlYSnJaWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbUZzYVdSaGRHVmZZM0psWVhSbFgyMWhjbXRsZEY5d1lYSmhiWE5mY205MWRHVkFNakE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME16WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRNMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmWTNKbFlYUmxYMjFoY210bGRGOXdZWEpoYlhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyTnZiblJ5WVdOMFgyUmxZblZuWDJsdVptOWZjbTkxZEdWQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTWpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5amIyNTBjbUZqZEY5a1pXSjFaMTlwYm1adkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOXliM1YwWlVBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsWkdWbGJWOTNhVzV1YVc1blgzTm9ZWEpsY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRYTmxjbDl6YUdGeVpYTmZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzVnpaWEpmYzJoaGNtVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzZHBkR2hrY21GM1gyWmxaWE5mY205MWRHVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhkcGRHaGtjbUYzWDJabFpYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM0JzWVhSbWIzSnRYMlpsWlhOZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl3YkdGMFptOXliVjltWldWekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOTBiM1JoYkY5dFlYSnJaWFJ6WDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16STFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZkRzkwWVd4ZmJXRnlhMlYwY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WlhOdmJIWmxYMjFoY210bGRGOXliM1YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakk1TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakk1TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsYzI5c2RtVmZiV0Z5YTJWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWVWOXViMTl6YUdGeVpYTmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TWpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHSjFlVjl1YjE5emFHRnlaWE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZblY1WDNsbGMxOXphR0Z5WlhOZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFMU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdKMWVWOTVaWE5mYzJoaGNtVnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTmhiR04xYkdGMFpWOTVaWE5mY0hKcFkyVmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqWVd4amRXeGhkR1ZmZVdWelgzQnlhV05sQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5dFlYSnJaWFJmYzNSaGRIVnpYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJuWlhSZmJXRnlhMlYwWDNOMFlYUjFjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYldGeWEyVjBYM0J2YjJ4elgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nVUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmYldGeWEyVjBYM0J2YjJ4ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXRZWEpyWlhSZmNYVmxjM1JwYjI1ZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiV0Z5YTJWMFgzRjFaWE4wYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZiV0Z5YTJWMFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFgyMWhjbXRsZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYm1sMGFXRnNhWHBsWDJOdmJuUnlZV04wWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYVc1cGRHbGhiR2w2WlY5amIyNTBjbUZqZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU16TTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWTJ4aGMzTWdVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETTFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVwYm1sMGFXRnNhWHBsWDJOdmJuUnlZV04wS0cxcGJsOXNhWEYxYVdScGRIazZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0thVzVwZEdsaGJHbDZaVjlqYjI1MGNtRmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJNUxUTXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCcGJtbDBhV0ZzYVhwbFgyTnZiblJ5WVdOMEtITmxiR1lzSUcxcGJsOXNhWEYxYVdScGRIazZJRlZKYm5RMk5Da2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVWlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnBibWwwYVdGc2FYcGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1Ga2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyMWhjbXRsZEhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnpaV3htTG5Cc1lYUm1iM0p0WDJabFpYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQnNZWFJtYjNKdFgyWmxaWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCelpXeG1MbTFwYmw5c2FYRjFhV1JwZEhrdWRtRnNkV1VnUFNCdGFXNWZiR2x4ZFdsa2FYUjVDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWliV2x1WDJ4cGNYVnBaR2wwZVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVqY21WaGRHVmZiV0Z5YTJWMEtIRjFaWE4wYVc5dU9pQmllWFJsY3l3Z2NtVnpiMngxZEdsdmJsOTBhVzFsT2lCMWFXNTBOalFzSUdabFpWOXlZWFJsT2lCMWFXNTBOalFzSUhCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwamNtVmhkR1ZmYldGeWEyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpndE5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdOeVpXRjBaVjl0WVhKclpYUW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J4ZFdWemRHbHZiam9nVTNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkWFJwYjI1ZmRHbHRaVG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpWOXlZWFJsT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRzQ2lBZ0lDQXZMeUFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSkZVbEpQVWw4eE1ERTZJRTl1YkhrZ1lXUnRhVzRnWTJGdUlHTnlaV0YwWlNCdFlYSnJaWFJ6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURFNklFOXViSGtnWVdSdGFXNGdZMkZ1SUdOeVpXRjBaU0J0WVhKclpYUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWVhOelpYSjBJR1psWlY5eVlYUmxJRHc5SUZWSmJuUTJOQ2d4TURBd0tTd2dJa1ZTVWs5U1h6RXdNam9nUm1WbElISmhkR1VnWTJGdWJtOTBJR1Y0WTJWbFpDQXhNQ1VpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd01qb2dSbVZsSUhKaGRHVWdZMkZ1Ym05MElHVjRZMlZsWkNBeE1DVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpUlZKU1QxSmZNVEF6T2lCUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKUFVsOHhNRE02SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCelpXeG1MbTFwYmw5c2FYRjFhV1JwZEhrdWRtRnNkV1VnS2lBeUxDQWlSVkpTVDFKZk1UQTBPaUJKYm5OMVptWnBZMmxsYm5RZ2JHbHhkV2xrYVhSNUlDaHVaV1ZrSURJZ1FVeEhUeUJ0YVc0cElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYldsdVgyeHBjWFZwWkdsMGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVc1ZmJHbHhkV2xrYVhSNUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpFd05Eb2dTVzV6ZFdabWFXTnBaVzUwSUd4cGNYVnBaR2wwZVNBb2JtVmxaQ0F5SUVGTVIwOGdiV2x1S1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTnZiSFYwYVc5dVgzUnBiV1VnUGlCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUZWSmJuUTJOQ2d6TmpBd0tTd2dJa1ZTVWs5U1h6RXdOVG9nVW1WemIyeDFkR2x2YmlCMGFXMWxJRzExYzNRZ1ltVWdZWFFnYkdWaGMzUWdNU0JvYjNWeUlHbHVJR1oxZEhWeVpTSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhCMWMyaHBiblFnTXpZd01DQXZMeUF6TmpBd0NpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh4TURVNklGSmxjMjlzZFhScGIyNGdkR2x0WlNCdGRYTjBJR0psSUdGMElHeGxZWE4wSURFZ2FHOTFjaUJwYmlCbWRYUjFjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCaGMzTmxjblFnY21WemIyeDFkR2x2Ymw5MGFXMWxJRHc5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnVlVsdWREWTBLRE14TlRNMk1EQXdLU3dnSWtWU1VrOVNYekV3TmpvZ1VtVnpiMngxZEdsdmJpQjBhVzFsSUhSdmJ5Qm1ZWElnYVc0Z1puVjBkWEpsSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWXlBMUlDOHZJRE14TlRNMk1EQXdDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTVDFKZk1UQTJPaUJTWlhOdmJIVjBhVzl1SUhScGJXVWdkRzl2SUdaaGNpQnBiaUJtZFhSMWNtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJ0WVhKclpYUmZhV1FnUFNCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5dFlYSnJaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTXkwMk5Rb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCdFlYSnJaWFFnWkdGMFlTQnBiaUJ6WlhCaGNtRjBaU0JpYjNobGN5Qm1iM0lnWldGamFDQm1hV1ZzWkFvZ0lDQWdMeThnSXlCVWFHbHpJR0YyYjJsa2N5QnpkSEoxWTNRZ1kyOXRjR3hsZUdsMGVTQnBjM04xWlhNS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QnhkV1Z6ZEdsdmJsOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluRjFaWE4wYVc5dUlpa0tJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZzNNVGMxTmpVM016YzBOamsyWmpabENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJ4ZFdWemRHbHZibDlpYjNndWNIVjBLSEYxWlhOMGFXOXVMbUo1ZEdWektRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnM01EWm1ObVkyWXpjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJwYm1sMGFXRnNYM0J2YjJ3Z1BTQndZWGx0Wlc1MExtRnRiM1Z1ZENBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qYzBMVGMxQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJeUI1WlhOZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDTWdibTlmY0c5dmJBb2dJQ0FnWkhWd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3dLU2tnS3lBZ0lDQWdJeUIwYjNSaGJGOTJiMngxYldVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM05DMDNOZ29nSUNBZ0x5OGdiM0F1YVhSdllpaHBibWwwYVdGc1gzQnZiMndwSUNzZ0lDTWdlV1Z6WDNCdmIyd0tJQ0FnSUM4dklHOXdMbWwwYjJJb2FXNXBkR2xoYkY5d2IyOXNLU0FySUNBaklHNXZYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvVlVsdWREWTBLREFwS1NBcklDQWdJQ0FqSUhSdmRHRnNYM1p2YkhWdFpRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzZ0lDQWdJQ0FqSUdabFpWOXlZWFJsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjMExUYzNDaUFnSUNBdkx5QnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0l5QjVaWE5mY0c5dmJBb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNNZ2JtOWZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NQ2twSUNzZ0lDQWdJQ01nZEc5MFlXeGZkbTlzZFcxbENpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBcklDQWdJQ0FnSXlCbVpXVmZjbUYwWlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc2dJeUJ5WlhOdmJIVjBhVzl1WDNScGJXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOelF0TnpnS0lDQWdJQzh2SUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FqSUhsbGMxOXdiMjlzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR2x1YVhScFlXeGZjRzl2YkNrZ0t5QWdJeUJ1YjE5d2IyOXNDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0l5QjBiM1JoYkY5MmIyeDFiV1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9abVZsWDNKaGRHVXBJQ3NnSUNBZ0lDQWpJR1psWlY5eVlYUmxDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t5QWpJSEpsYzI5c2RYUnBiMjVmZEdsdFpRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8zTkMwM09Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJQzh2SUc5d0xtbDBiMklvYVc1cGRHbGhiRjl3YjI5c0tTQXJJQ0FqSUc1dlgzQnZiMndLSUNBZ0lDOHZJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWpJSFJ2ZEdGc1gzWnZiSFZ0WlFvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3lBZ0lDQWdJQ01nWm1WbFgzSmhkR1VLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtTQXJJQ01nY21WemIyeDFkR2x2Ymw5MGFXMWxDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dLeUFnSUNBZ0l5QnBjMTl5WlhOdmJIWmxaQ0FvTUQxR1lXeHpaU3dnTVQxVWNuVmxLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56SXRPREVLSUNBZ0lDOHZJQ01nVTNSdmNtVTZJSGxsYzE5d2IyOXNLRGdwSUNzZ2JtOWZjRzl2YkNnNEtTQXJJSFJ2ZEdGc1gzWnZiSFZ0WlNnNEtTQXJJR1psWlY5eVlYUmxLRGdwSUNzZ2NtVnpiMngxZEdsdmJsOTBhVzFsS0RncElDc2dhWE5mY21WemIyeDJaV1FvT0NrZ0t5QjNhVzV1YVc1blgyOTFkR052YldVb09Da0tJQ0FnSUM4dklIQnZiMnh6WDJSaGRHRWdQU0FvQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWlocGJtbDBhV0ZzWDNCdmIyd3BJQ3NnSUNNZ2VXVnpYM0J2YjJ3S0lDQWdJQzh2SUNBZ0lDQnZjQzVwZEc5aUtHbHVhWFJwWVd4ZmNHOXZiQ2tnS3lBZ0l5QnViMTl3YjI5c0NpQWdJQ0F2THlBZ0lDQWdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t5QWdJQ0FnSUNNZ1ptVmxYM0poZEdVS0lDQWdJQzh2SUNBZ0lDQnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t5QWpJSEpsYzI5c2RYUnBiMjVmZEdsdFpRb2dJQ0FnTHk4Z0lDQWdJRzl3TG1sMGIySW9WVWx1ZERZMEtEQXBLU0FySUNBZ0lDQWpJR2x6WDNKbGMyOXNkbVZrSUNnd1BVWmhiSE5sTENBeFBWUnlkV1VwQ2lBZ0lDQXZMeUFnSUNBZ2IzQXVhWFJ2WWloVlNXNTBOalFvTUNrcElDQWdJQ0FnSUNNZ2QybHVibWx1WjE5dmRYUmpiMjFsSUNnd1BVNXZMQ0F4UFZsbGN5a0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamMwTFRnd0NpQWdJQ0F2THlCdmNDNXBkRzlpS0dsdWFYUnBZV3hmY0c5dmJDa2dLeUFnSXlCNVpYTmZjRzl2YkFvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYm1sMGFXRnNYM0J2YjJ3cElDc2dJQ01nYm05ZmNHOXZiQW9nSUNBZ0x5OGdiM0F1YVhSdllpaFZTVzUwTmpRb01Da3BJQ3NnSUNBZ0lDTWdkRzkwWVd4ZmRtOXNkVzFsQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FySUNBZ0lDQWdJeUJtWldWZmNtRjBaUW9nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc2dJeUJ5WlhOdmJIVjBhVzl1WDNScGJXVUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RBcEtTQXJJQ0FnSUNBaklHbHpYM0psYzI5c2RtVmtJQ2d3UFVaaGJITmxMQ0F4UFZSeWRXVXBDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNnd0tTa2dJQ0FnSUNBZ0l5QjNhVzV1YVc1blgyOTFkR052YldVZ0tEQTlUbThzSURFOVdXVnpLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NExuQjFkQ2h3YjI5c2MxOWtZWFJoS1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJR055WldGMGIzSmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSmpjbVZoZEc5eUlpa0tJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjROak0zTWpZMU5qRTNORFptTnpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR055WldGMGIzSmZZbTk0TG5CMWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWektRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeTUyWVd4MVpTQTlJRzFoY210bGRGOXBaQ0FySURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCdFlYSnJaWFJmYVdRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVuWlhSZmJXRnlhMlYwWDNGMVpYTjBhVzl1S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMjFoY210bGRGOXhkV1Z6ZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamt4TFRreUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmJXRnlhMlYwWDNGMVpYTjBhVzl1S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPamswQ2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvNU5Rb2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKeGRXVnpkR2x2YmlJcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEY3hOelUyTlRjek56UTJPVFptTm1VS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnhkV1Z6ZEdsdmJsOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCeGRXVnpkR2x2Ymw5aWVYUmxjeXdnWDJWNGFYTjBjeUE5SUhGMVpYTjBhVzl1WDJKdmVDNXRZWGxpWlNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9jWFZsYzNScGIyNWZZbmwwWlhNcENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WjJWMFgyMWhjbXRsZEY5d2IyOXNjeWh0WVhKclpYUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXRZWEpyWlhSZmNHOXZiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1ERXRNVEF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmYldGeWEyVjBYM0J2YjJ4ektITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5Dd2dZWEpqTkM1VlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdjRzl2YkhOZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKd2IyOXNjeUlwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TnpBMlpqWm1ObU0zTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQndiMjlzYzE5aWIzZ3ViR1Z1WjNSb0lENGdNQ3dnSWsxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVGSmxaaUJsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCTllYSnJaWFFnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV3T0FvZ0lDQWdMeThnY0c5dmJITmZaR0YwWVN3Z1gyVjRhWE4wY3lBOUlIQnZiMnh6WDJKdmVDNXRZWGxpWlNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnZVdWelgzQnZiMndnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEQXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z2JtOWZjRzl2YkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9PQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJSFJ2ZEdGc1gzWnZiSFZ0WlNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NVFlwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvWVhKak5DNVZTVzUwTmpRb2VXVnpYM0J2YjJ3cExDQmhjbU0wTGxWSmJuUTJOQ2h1YjE5d2IyOXNLU3dnWVhKak5DNVZTVzUwTmpRb2RHOTBZV3hmZG05c2RXMWxLU2twQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG1kbGRGOXRZWEpyWlhSZmMzUmhkSFZ6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMjFoY210bGRGOXpkR0YwZFhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNVFl0TVRFM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmJXRnlhMlYwWDNOMFlYUjFjeWh6Wld4bUxDQnRZWEpyWlhSZmFXUTZJRlZKYm5RMk5Da2dMVDRnWVhKak5DNVVkWEJzWlZ0aGNtTTBMa0p2YjJ3c0lHRnlZelF1UW05dmJGMDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXhPUW9nSUNBZ0x5OGdiV0Z5YTJWMFgzQnlaV1pwZUNBOUlHSWliV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJaRFl4TnpJMllqWTFOelExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCd2IyOXNjMTlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQVzFoY210bGRGOXdjbVZtYVhnZ0t5QmlJbkJ2YjJ4eklpa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzNNRFptTm1ZMll6Y3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmIyeHpYMkp2ZUM1c1pXNW5kR2dnUGlBd0xDQWlUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QndiMjlzYzE5a1lYUmhMQ0JmWlhocGMzUnpJRDBnY0c5dmJITmZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QnBjMTl5WlhOdmJIWmxaRjkyWVd3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRFF3S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwTUNBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z2QybHVibWx1WjE5dmRYUmpiMjFsWDNaaGJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTkRncExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBME9DQXZMeUEwT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdZWEpqTkM1Q2IyOXNLR2x6WDNKbGMyOXNkbVZrWDNaaGJDQTlQU0JWU1c1ME5qUW9NU2twTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVE13Q2lBZ0lDQXZMeUJoY21NMExrSnZiMndvZDJsdWJtbHVaMTl2ZFhSamIyMWxYM1poYkNBOVBTQlZTVzUwTmpRb01Ta3BDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1qZ3RNVE14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVDYjI5c0tHbHpYM0psYzI5c2RtVmtYM1poYkNBOVBTQlZTVzUwTmpRb01Ta3BMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRbTl2YkNoM2FXNXVhVzVuWDI5MWRHTnZiV1ZmZG1Gc0lEMDlJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lDOHZJQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVZMkZzWTNWc1lYUmxYM2xsYzE5d2NtbGpaU2h0WVhKclpYUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwallXeGpkV3hoZEdWZmVXVnpYM0J5YVdObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVE16TFRFek5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWTJGc1kzVnNZWFJsWDNsbGMxOXdjbWxqWlNoelpXeG1MQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUhCdmIyeHpJRDBnYzJWc1ppNW5aWFJmYldGeWEyVjBYM0J2YjJ4ektHMWhjbXRsZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJuWlhSZmJXRnlhMlYwWDNCdmIyeHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUhsbGMxOXdiMjlzSUQwZ2NHOXZiSE5iTUYwdWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCdWIxOXdiMjlzSUQwZ2NHOXZiSE5iTVYwdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUwTWdvZ0lDQWdMeThnSXlCRGIyNXpkR0Z1ZENCd2NtOWtkV04wSUVGTlRUb2dlV1Z6WDNCeWFXTmxJRDBnYm05ZmNHOXZiQ0F2SUNoNVpYTmZjRzl2YkNBcklHNXZYM0J2YjJ3cENpQWdJQ0F2THlBaklGTmpZV3hsWkNCaWVTQXhNREF3SUdadmNpQndjbVZqYVhOcGIyNGdLRFV3SlNBOUlEVXdNQ3dnT1RrbElEMGdPVGt3S1FvZ0lDQWdMeThnZEc5MFlXeGZiR2x4ZFdsa2FYUjVJRDBnZVdWelgzQnZiMndnS3lCdWIxOXdiMjlzQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUwTkFvZ0lDQWdMeThnYVdZZ2RHOTBZV3hmYkdseGRXbGthWFI1SUQwOUlGVkpiblEyTkNnd0tUb0tJQ0FnSUdKdWVpQmpZV3hqZFd4aGRHVmZlV1Z6WDNCeWFXTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEVXdNQ2tnSUNNZ1JHVm1ZWFZzZENBMU1DVUtJQ0FnSUhCMWMyaHBiblFnTlRBd0lDOHZJRFV3TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtTmhiR04xYkdGMFpWOTVaWE5mY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUI1WlhOZmNISnBZMlVnUFNBb2JtOWZjRzl2YkNBcUlERXdNREFwSUM4dklIUnZkR0ZzWDJ4cGNYVnBaR2wwZVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREF3Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnlaWFIxY200Z2VXVnpYM0J5YVdObENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzVpZFhsZmVXVnpYM05vWVhKbGN5aHRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Dd2djR0Y1YldWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbUoxZVY5NVpYTmZjMmhoY21Wek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFV3TFRFMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWW5WNVgzbGxjMTl6YUdGeVpYTW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TmpRdE1UWTFDaUFnSUNBdkx5QWpJRU5vWldOcklHMWhjbXRsZENCbGVHbHpkSE1nWVc1a0lHZGxkQ0JrWVhSaENpQWdJQ0F2THlCdFlYSnJaWFJmY0hKbFptbDRJRDBnWWlKdFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURaa05qRTNNalppTmpVM05EVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFkyQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluQnZiMnh6SWlrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnM01EWm1ObVkyWXpjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnWVhOelpYSjBJSEJ2YjJ4elgySnZlQzVzWlc1bmRHZ2dQaUF3TENBaVRXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBJZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRVbVZtSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFMWhjbXRsZENCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCd2IyOXNjMTlrWVhSaExDQmZaWGhwYzNSeklEMGdjRzl2YkhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TnpFdE1UY3lDaUFnSUNBdkx5QWpJRVY0ZEhKaFkzUWdZM1Z5Y21WdWRDQnpkR0YwWlFvZ0lDQWdMeThnZVdWelgzQnZiMndnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEQXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFM013b2dJQ0FnTHk4Z2JtOWZjRzl2YkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9PQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSFJ2ZEdGc1gzWnZiSFZ0WlNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9NVFlwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE56VUtJQ0FnSUM4dklHWmxaVjl5WVhSbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d5TkNrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBeU5DQXZMeUF5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdjbVZ6YjJ4MWRHbHZibDkwYVcxbElEMGdiM0F1WW5SdmFTaHZjQzVsZUhSeVlXTjBLSEJ2YjJ4elgyUmhkR0VzSUZWSmJuUTJOQ2d6TWlrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTNOd29nSUNBZ0x5OGdhWE5mY21WemIyeDJaV1FnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEUXdLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRjNUNpQWdJQ0F2THlCaGMzTmxjblFnYVhOZmNtVnpiMngyWldRZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpUlZKU1QxSmZNakF4T2lCTllYSnJaWFFnYVhNZ2NtVnpiMngyWldRaUNpQWdJQ0JrZFhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1ERTZJRTFoY210bGRDQnBjeUJ5WlhOdmJIWmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQQ0J5WlhOdmJIVjBhVzl1WDNScGJXVXNJQ0pGVWxKUFVsOHlNREk2SUZSeVlXUnBibWNnWlc1a1pXUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VrOVNYekl3TWpvZ1ZISmhaR2x1WnlCbGJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2l3Z0lrVlNVazlTWHpJd016b2dVR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQmhjSEFnWTJGc2JDQnpaVzVrWlhJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSlBVbDh5TURNNklGQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxMWMzUWdiV0YwWTJnZ1lYQndJR05oYkd3Z2MyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSkZVbEpQVWw4eU1EUTZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJqYjI1MGNtRmpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd05Eb2dVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStJREFzSUNKRlVsSlBVbDh5TURVNklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpQVWw4eU1EVTZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdWVWx1ZERZMEtERXdNREFwTENBaVJWSlNUMUpmTWpBMk9pQk5hVzVwYlhWdElIUnlZV1JsSUdGdGIzVnVkQ0JwY3lBeE1EQXdJRzFwWTNKdlFVeEhUM01pQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd05qb2dUV2x1YVcxMWJTQjBjbUZrWlNCaGJXOTFiblFnYVhNZ01UQXdNQ0J0YVdOeWIwRk1SMDl6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE9EWXRNVGczQ2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCd2JHRjBabTl5YlNCbVpXVUtJQ0FnSUM4dklHWmxaVjloYlc5MWJuUWdQU0FvY0dGNWJXVnVkQzVoYlc5MWJuUWdLaUJtWldWZmNtRjBaU2tnTHk4Z01UQXdNREFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lDb0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNQW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUIwY21Ga1pWOWhiVzkxYm5RZ1BTQndZWGx0Wlc1MExtRnRiM1Z1ZENBdElHWmxaVjloYlc5MWJuUUtJQ0FnSUdSMWNESUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTVNQzB4T1RFS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElITm9ZWEpsY3lCMWMybHVaeUJqYjI1emRHRnVkQ0J3Y205a2RXTjBJR1p2Y20xMWJHRUtJQ0FnSUM4dklITm9ZWEpsYzE5eVpXTmxhWFpsWkNBOUlDaDBjbUZrWlY5aGJXOTFiblFnS2lCdWIxOXdiMjlzS1NBdkx5QW9lV1Z6WDNCdmIyd2dLeUIwY21Ga1pWOWhiVzkxYm5RcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBNENpQWdJQ0FxQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lDOEtJQ0FnSUdOdmRtVnlJREV4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE9UVUtJQ0FnSUM4dklHNWxkMTkwYjNSaGJGOTJiMngxYldVZ1BTQjBiM1JoYkY5MmIyeDFiV1VnS3lCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakU1TnkweE9UZ0tJQ0FnSUM4dklDTWdVM1J2Y21VZ2RYQmtZWFJsWkNCa1lYUmhDaUFnSUNBdkx5QjNhVzV1YVc1blgyOTFkR052YldVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRFE0S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdjSFZ6YUdsdWRDQTBPQ0F2THlBME9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3TUFvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmVXVnpYM0J2YjJ3cElDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXhDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXdMVEl3TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmVXVnpYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtOWZjRzl2YkNrZ0t3b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURJS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURBdE1qQXlDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNWxkMTk1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1YjE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5MGIzUmhiRjkyYjJ4MWJXVXBJQ3NLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdNQzB5TURNS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM1J2ZEdGc1gzWnZiSFZ0WlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t3b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TURRS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WemIyeDFkR2x2Ymw5MGFXMWxLU0FyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3TUMweU1EUUtJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM2xsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaG1aV1ZmY21GMFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHlaWE52YkhWMGFXOXVYM1JwYldVcElDc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dselgzSmxjMjlzZG1Wa0tTQXJDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXdNQzB5TURVS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYM1J2ZEdGc1gzWnZiSFZ0WlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobVpXVmZjbUYwWlNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWloeVpYTnZiSFYwYVc5dVgzUnBiV1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYVhOZmNtVnpiMngyWldRcElDc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCdmNDNXBkRzlpS0hkcGJtNXBibWRmYjNWMFkyOXRaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJd01DMHlNRFlLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNsbGMxOXdiMjlzS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0c1dlgzQnZiMndwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvYm1WM1gzUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh5WlhOdmJIVjBhVzl1WDNScGJXVXBJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9hWE5mY21WemIyeDJaV1FwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvZDJsdWJtbHVaMTl2ZFhSamIyMWxLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1EZ0tJQ0FnSUM4dklIQnZiMnh6WDJKdmVDNXdkWFFvYm1WM1gzQnZiMnh6WDJSaGRHRXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnYzJWc1ppNXdiR0YwWm05eWJWOW1aV1Z6TG5aaGJIVmxJQ3M5SUdabFpWOWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3YkdGMFptOXliVjltWldWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUExSUM4dklDSndiR0YwWm05eWJWOW1aV1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSXhNUzB5TVRJS0lDQWdJQzh2SUNNZ1ZISmhZMnNnZFhObGNpQlpaWE1nYzJoaGNtVnpDaUFnSUNBdkx5QjFjMlZ5WDNOb1lYSmxjMTlyWlhrZ1BTQmlJblZ6WlhKZklpQXJJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdLeUJpSWw5dFlYSnJaWFJmSWlBcklHOXdMbWwwYjJJb2JXRnlhMlYwWDJsa0tTQXJJR0lpWDNsbGN5SUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzNOVGN6TmpVM01qVm1DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzFaalprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGcxWmpjNU5qVTNNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJeE5Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emFHRnlaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU1UWUtJQ0FnSUM4dklHbG1JSFZ6WlhKZmMyaGhjbVZ6WDJKdmVDNXNaVzVuZEdnZ1BpQXdPZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHSjZJR0oxZVY5NVpYTmZjMmhoY21WelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QmxlR2x6ZEdsdVoxOXphR0Z5WlhOZlpHRjBZU3dnWDJWNGFYTjBjeUE5SUhWelpYSmZjMmhoY21WelgySnZlQzV0WVhsaVpTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TVRnS0lDQWdJQzh2SUdOMWNuSmxiblJmYzJoaGNtVnpJRDBnYjNBdVluUnZhU2hsZUdsemRHbHVaMTl6YUdGeVpYTmZaR0YwWVNrS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvS1luVjVYM2xsYzE5emFHRnlaWE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCMWMyVnlYM05vWVhKbGMxOWliM2d1Y0hWMEtHOXdMbWwwYjJJb1kzVnljbVZ1ZEY5emFHRnlaWE1nS3lCemFHRnlaWE5mY21WalpXbDJaV1FwS1FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUhKbGRIVnliaUJ6YUdGeVpYTmZjbVZqWldsMlpXUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG1KMWVWOXViMTl6YUdGeVpYTW9iV0Z5YTJWMFgybGtPaUIxYVc1ME5qUXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BpZFhsZmJtOWZjMmhoY21Wek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNakkwTFRJeU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWW5WNVgyNXZYM05vWVhKbGN5Z0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJRzFoY210bGRGOXBaRG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl6TVMweU16SUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2JXRnlhMlYwSUdWNGFYTjBjeUJoYm1RZ1oyVjBJR1JoZEdFS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcxWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNek1LSUNBZ0lDOHZJSEJ2YjJ4elgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOWJXRnlhMlYwWDNCeVpXWnBlQ0FySUdJaWNHOXZiSE1pS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjd05tWTJaalpqTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdjRzl2YkhOZlltOTRMbXhsYm1kMGFDQStJREFzSUNKTllYSnJaWFFnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRnlhMlYwSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUhCdmIyeHpYMlJoZEdFc0lGOWxlR2x6ZEhNZ1BTQndiMjlzYzE5aWIzZ3ViV0Y1WW1Vb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakl6T0MweU16a0tJQ0FnSUM4dklDTWdSWGgwY21GamRDQmpkWEp5Wlc1MElITjBZWFJsQ2lBZ0lDQXZMeUI1WlhOZmNHOXZiQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb01Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpRd0NpQWdJQ0F2THlCdWIxOXdiMjlzSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZzRLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTBNUW9nSUNBZ0x5OGdkRzkwWVd4ZmRtOXNkVzFsSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3hOaWtzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJME1nb2dJQ0FnTHk4Z1ptVmxYM0poZEdVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREkwS1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qUXpDaUFnSUNBdkx5QnlaWE52YkhWMGFXOXVYM1JwYldVZ1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLRE15S1N3Z1ZVbHVkRFkwS0RncEtTa0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qUTBDaUFnSUNBdkx5QnBjMTl5WlhOdmJIWmxaQ0E5SUc5d0xtSjBiMmtvYjNBdVpYaDBjbUZqZENod2IyOXNjMTlrWVhSaExDQlZTVzUwTmpRb05EQXBMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdOREFnTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5eVpYTnZiSFpsWkNBOVBTQlZTVzUwTmpRb01Da3NJQ0pGVWxKUFVsOHlNREU2SUUxaGNtdGxkQ0JwY3lCeVpYTnZiSFpsWkNJS0lDQWdJR1IxY0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd01Ub2dUV0Z5YTJWMElHbHpJSEpsYzI5c2RtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TkRjS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQThJSEpsYzI5c2RYUnBiMjVmZEdsdFpTd2dJa1ZTVWs5U1h6SXdNam9nVkhKaFpHbHVaeUJsYm1SbFpDSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1QxSmZNakF5T2lCVWNtRmthVzVuSUdWdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TkRnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbk5sYm1SbGNpQTlQU0JVZUc0dWMyVnVaR1Z5TENBaVJWSlNUMUpmTWpBek9pQlFZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lHRndjQ0JqWVd4c0lITmxibVJsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VrOVNYekl3TXpvZ1VHRjViV1Z1ZENCelpXNWtaWElnYlhWemRDQnRZWFJqYUNCaGNIQWdZMkZzYkNCelpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJME9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lrVlNVazlTWHpJd05Eb2dVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTWpBME9pQlFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkxTUFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENGdNQ3dnSWtWU1VrOVNYekl3TlRvZ1VHRjViV1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFVlNVazlTWHpJd05Ub2dVR0Y1YldWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQlZTVzUwTmpRb01UQXdNQ2tzSUNKRlVsSlBVbDh5TURZNklFMXBibWx0ZFcwZ2RISmhaR1VnWVcxdmRXNTBJR2x6SURFd01EQWdiV2xqY205QlRFZFBjeUlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNUMUpmTWpBMk9pQk5hVzVwYlhWdElIUnlZV1JsSUdGdGIzVnVkQ0JwY3lBeE1EQXdJRzFwWTNKdlFVeEhUM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJMU15MHlOVFFLSUNBZ0lDOHZJQ01nUTJGc1kzVnNZWFJsSUhCc1lYUm1iM0p0SUdabFpRb2dJQ0FnTHk4Z1ptVmxYMkZ0YjNWdWRDQTlJQ2h3WVhsdFpXNTBMbUZ0YjNWdWRDQXFJR1psWlY5eVlYUmxLU0F2THlBeE1EQXdNQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ0tnb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOVFVLSUNBZ0lDOHZJSFJ5WVdSbFgyRnRiM1Z1ZENBOUlIQmhlVzFsYm5RdVlXMXZkVzUwSUMwZ1ptVmxYMkZ0YjNWdWRBb2dJQ0FnWkhWd01nb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qVTNMVEkxT0FvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2MyaGhjbVZ6SUhWemFXNW5JR052Ym5OMFlXNTBJSEJ5YjJSMVkzUWdabTl5YlhWc1lRb2dJQ0FnTHk4Z2MyaGhjbVZ6WDNKbFkyVnBkbVZrSUQwZ0tIUnlZV1JsWDJGdGIzVnVkQ0FxSUhsbGMxOXdiMjlzS1NBdkx5QW9ibTlmY0c5dmJDQXJJSFJ5WVdSbFgyRnRiM1Z1ZENrS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURrS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0x3b2dJQ0FnWTI5MlpYSWdNVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJMk1nb2dJQ0FnTHk4Z2JtVjNYM1J2ZEdGc1gzWnZiSFZ0WlNBOUlIUnZkR0ZzWDNadmJIVnRaU0FySUhCaGVXMWxiblF1WVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalkwTFRJMk5Rb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCMWNHUmhkR1ZrSUdSaGRHRUtJQ0FnSUM4dklIZHBibTVwYm1kZmIzVjBZMjl0WlNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9ORGdwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQndkWE5vYVc1MElEUTRJQzh2SURRNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalkzQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSGxsYzE5d2IyOXNLU0FyQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkyT0FvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmJtOWZjRzl2YkNrZ0t3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU5qY3RNalk0Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSGxsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzVsZDE5dWIxOXdiMjlzS1NBckNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkyT1FvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmRHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkyTnkweU5qa0tJQ0FnSUM4dklHOXdMbWwwYjJJb2VXVnpYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2JtVjNYMjV2WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibVYzWDNSdmRHRnNYM1p2YkhWdFpTa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU56QUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ptVmxYM0poZEdVcElDc0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qWTNMVEkzTUFvZ0lDQWdMeThnYjNBdWFYUnZZaWg1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmJtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZkRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBckNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakkzTVFvZ0lDQWdMeThnYjNBdWFYUnZZaWh5WlhOdmJIVjBhVzl1WDNScGJXVXBJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNalkzTFRJM01Rb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZibTlmY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmZEc5MFlXeGZkbTlzZFcxbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHWmxaVjl5WVhSbEtTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtISmxjMjlzZFhScGIyNWZkR2x0WlNrZ0t3b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TnpJS0lDQWdJQzh2SUc5d0xtbDBiMklvYVhOZmNtVnpiMngyWldRcElDc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qWTNMVEkzTWdvZ0lDQWdMeThnYjNBdWFYUnZZaWg1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmJtOWZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodVpYZGZkRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhwYzE5eVpYTnZiSFpsWkNrZ0t3b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUc5d0xtbDBiMklvZDJsdWJtbHVaMTl2ZFhSamIyMWxLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TWpZM0xUSTNNd29nSUNBZ0x5OGdiM0F1YVhSdllpaDVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHVaWGRmYm05ZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1WlhkZmRHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHBjMTl5WlhOdmJIWmxaQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWgzYVc1dWFXNW5YMjkxZEdOdmJXVXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJM05Rb2dJQ0FnTHk4Z2NHOXZiSE5mWW05NExuQjFkQ2h1WlhkZmNHOXZiSE5mWkdGMFlTa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNamMyQ2lBZ0lDQXZMeUJ6Wld4bUxuQnNZWFJtYjNKdFgyWmxaWE11ZG1Gc2RXVWdLejBnWm1WbFgyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR3hoZEdadmNtMWZabVZsY3lCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQnNZWFJtYjNKdFgyWmxaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qYzRMVEkzT1FvZ0lDQWdMeThnSXlCVWNtRmpheUIxYzJWeUlFNXZJSE5vWVhKbGN3b2dJQ0FnTHk4Z2RYTmxjbDl6YUdGeVpYTmZhMlY1SUQwZ1lpSjFjMlZ5WHlJZ0t5QlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklDc2dZaUpmYldGeWEyVjBYeUlnS3lCdmNDNXBkRzlpS0cxaGNtdGxkRjlwWkNrZ0t5QmlJbDl1YnlJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnM05UY3pOalUzTWpWbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnMVpqWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z01IZzFaalpsTm1ZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lPRElLSUNBZ0lDOHZJR04xY25KbGJuUmZjMmhoY21WeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNamd6Q2lBZ0lDQXZMeUJwWmlCMWMyVnlYM05vWVhKbGMxOWliM2d1YkdWdVozUm9JRDRnTURvS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJDYjNoU1pXWWdaWGhwYzNSekNpQWdJQ0JpZWlCaWRYbGZibTlmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNamcwQ2lBZ0lDQXZMeUJsZUdsemRHbHVaMTl6YUdGeVpYTmZaR0YwWVN3Z1gyVjRhWE4wY3lBOUlIVnpaWEpmYzJoaGNtVnpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9EVUtJQ0FnSUM4dklHTjFjbkpsYm5SZmMyaGhjbVZ6SUQwZ2IzQXVZblJ2YVNobGVHbHpkR2x1WjE5emFHRnlaWE5mWkdGMFlTa0tJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0tZblY1WDI1dlgzTm9ZWEpsYzE5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9EY0tJQ0FnSUM4dklIVnpaWEpmYzJoaGNtVnpYMkp2ZUM1d2RYUW9iM0F1YVhSdllpaGpkWEp5Wlc1MFgzTm9ZWEpsY3lBcklITm9ZWEpsYzE5eVpXTmxhWFpsWkNrcENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pJNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhOb1lYSmxjMTl5WldObGFYWmxaQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdWNtVnpiMngyWlY5dFlYSnJaWFFvYldGeWEyVjBYMmxrT2lCMWFXNTBOalFzSUhsbGMxOTNhVzV6T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVjl0WVhKclpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95T1RFdE1qa3lDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCeVpYTnZiSFpsWDIxaGNtdGxkQ2h6Wld4bUxDQnRZWEpyWlhSZmFXUTZJRlZKYm5RMk5Dd2dlV1Z6WDNkcGJuTTZJR0Z5WXpRdVFtOXZiQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNamswQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnY21WemIyeDJaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmlCallXNGdjbVZ6YjJ4MlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNamsyQ2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU9UY0tJQ0FnSUM4dklIQnZiMnh6WDJKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YldGeWEyVjBYM0J5WldacGVDQXJJR0lpY0c5dmJITWlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qazRDaUFnSUNBdkx5QmhjM05sY25RZ2NHOXZiSE5mWW05NExteGxibWQwYUNBK0lEQXNJQ0pOWVhKclpYUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJDYjNoU1pXWWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNREFLSUNBZ0lDOHZJSEJ2YjJ4elgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCd2IyOXNjMTlpYjNndWJXRjVZbVVvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXdNaTB6TURNS0lDQWdJQzh2SUNNZ1JYaDBjbUZqZENCamRYSnlaVzUwSUhOMFlYUmxDaUFnSUNBdkx5QjVaWE5mY0c5dmJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTUNrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekEwQ2lBZ0lDQXZMeUJ1YjE5d2IyOXNJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnNEtTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNd05Rb2dJQ0FnTHk4Z2RHOTBZV3hmZG05c2RXMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNneE5pa3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhOaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak13TmdvZ0lDQWdMeThnWm1WbFgzSmhkR1VnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtESTBLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpBM0NpQWdJQ0F2THlCeVpYTnZiSFYwYVc5dVgzUnBiV1VnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtETXlLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpBNENpQWdJQ0F2THlCcGMxOXlaWE52YkhabFpDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTkRBcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpFd0NpQWdJQ0F2THlCaGMzTmxjblFnYVhOZmNtVnpiMngyWldRZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpUVd4eVpXRmtlU0J5WlhOdmJIWmxaQ0lLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUhKbGMyOXNkbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErUFNCeVpYTnZiSFYwYVc5dVgzUnBiV1VzSUNKVWIyOGdaV0Z5YkhrZ2RHOGdjbVZ6YjJ4MlpTSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdScFp5QXhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZSdmJ5QmxZWEpzZVNCMGJ5QnlaWE52YkhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNVFVLSUNBZ0lDOHZJRzl3TG1sMGIySW9lV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekUyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNekUxTFRNeE5nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloNVpYTmZjRzl2YkNrZ0t3b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlodWIxOXdiMjlzS1NBckNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak14TndvZ0lDQWdMeThnYjNBdWFYUnZZaWgwYjNSaGJGOTJiMngxYldVcElDc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16RTFMVE14TndvZ0lDQWdMeThnYjNBdWFYUnZZaWg1WlhOZmNHOXZiQ2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWh1YjE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSFJ2ZEdGc1gzWnZiSFZ0WlNrZ0t3b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TVRnS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpFMUxUTXhPQW9nSUNBZ0x5OGdiM0F1YVhSdllpaDVaWE5mY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaHViMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtIUnZkR0ZzWDNadmJIVnRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhtWldWZmNtRjBaU2tnS3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pNVGtLSUNBZ0lDOHZJRzl3TG1sMGIySW9jbVZ6YjJ4MWRHbHZibDkwYVcxbEtTQXJDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TVRVdE16RTVDaUFnSUNBdkx5QnZjQzVwZEc5aUtIbGxjMTl3YjI5c0tTQXJDaUFnSUNBdkx5QnZjQzVwZEc5aUtHNXZYM0J2YjJ3cElDc0tJQ0FnSUM4dklHOXdMbWwwYjJJb2RHOTBZV3hmZG05c2RXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR1psWlY5eVlYUmxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSEpsYzI5c2RYUnBiMjVmZEdsdFpTa2dLd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1qQUtJQ0FnSUM4dklHOXdMbWwwYjJJb1ZVbHVkRFkwS0RFcEtTQXJJQ0FqSUdselgzSmxjMjlzZG1Wa0lEMGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNeE5TMHpNakFLSUNBZ0lDOHZJRzl3TG1sMGIySW9lV1Z6WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9ibTlmY0c5dmJDa2dLd29nSUNBZ0x5OGdiM0F1YVhSdllpaDBiM1JoYkY5MmIyeDFiV1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvWm1WbFgzSmhkR1VwSUNzS0lDQWdJQzh2SUc5d0xtbDBiMklvY21WemIyeDFkR2x2Ymw5MGFXMWxLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRlZKYm5RMk5DZ3hLU2tnS3lBZ0l5QnBjMTl5WlhOdmJIWmxaQ0E5SUZSeWRXVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpJeENpQWdJQ0F2THlCdmNDNXBkRzlpS0ZWSmJuUTJOQ2d4S1NCcFppQjVaWE5mZDJsdWN5NXVZWFJwZG1VZ1pXeHpaU0JWU1c1ME5qUW9NQ2twSUNBaklIZHBibTVwYm1kZmIzVjBZMjl0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1UVXRNekl4Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSGxsYzE5d2IyOXNLU0FyQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRzV2WDNCdmIyd3BJQ3NLSUNBZ0lDOHZJRzl3TG1sMGIySW9kRzkwWVd4ZmRtOXNkVzFsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0dabFpWOXlZWFJsS1NBckNpQWdJQ0F2THlCdmNDNXBkRzlpS0hKbGMyOXNkWFJwYjI1ZmRHbHRaU2tnS3dvZ0lDQWdMeThnYjNBdWFYUnZZaWhWU1c1ME5qUW9NU2twSUNzZ0lDTWdhWE5mY21WemIyeDJaV1FnUFNCVWNuVmxDaUFnSUNBdkx5QnZjQzVwZEc5aUtGVkpiblEyTkNneEtTQnBaaUI1WlhOZmQybHVjeTV1WVhScGRtVWdaV3h6WlNCVlNXNTBOalFvTUNrcElDQWpJSGRwYm01cGJtZGZiM1YwWTI5dFpRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TWpNS0lDQWdJQzh2SUhCdmIyeHpYMkp2ZUM1d2RYUW9ibVYzWDNCdmIyeHpYMlJoZEdFcENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYM1J2ZEdGc1gyMWhjbXRsZEhNb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5MGIzUmhiRjl0WVhKclpYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpJNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmYldGeWEyVjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG1kbGRGOXdiR0YwWm05eWJWOW1aV1Z6S0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJmY0d4aGRHWnZjbTFmWm1WbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak16TXdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWNHeGhkR1p2Y20xZlptVmxjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5Cc1lYUm1iM0p0WDJabFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0d4aGRHWnZjbTFmWm1WbGN5QmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzUzYVhSb1pISmhkMTltWldWektDa2dMVDRnZFdsdWREWTBPZ3AzYVhSb1pISmhkMTltWldWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNek00Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnZDJsMGFHUnlZWGNpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSGRwZEdoa2NtRjNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TkRBS0lDQWdJQzh2SUdabFpYTmZkRzlmZDJsMGFHUnlZWGNnUFNCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSndiR0YwWm05eWJWOW1aV1Z6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnNZWFJtYjNKdFgyWmxaWE1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JtWldWelgzUnZYM2RwZEdoa2NtRjNJRDRnTUN3Z0lrNXZJR1psWlhNZ2RHOGdkMmwwYUdSeVlYY2lDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5Qm1aV1Z6SUhSdklIZHBkR2hrY21GM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pORE1LSUNBZ0lDOHZJSE5sYkdZdWNHeGhkR1p2Y20xZlptVmxjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWljR3hoZEdadmNtMWZabVZsY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16UTFMVE0wT1FvZ0lDQWdMeThnSXlCVFpXNWtJSEJoZVcxbGJuUWdkRzhnWVdSdGFXNEtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMW1aV1Z6WDNSdlgzZHBkR2hrY21GM0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16UTNDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TkRVdE16UTJDaUFnSUNBdkx5QWpJRk5sYm1RZ2NHRjViV1Z1ZENCMGJ5QmhaRzFwYmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5EVXRNelE1Q2lBZ0lDQXZMeUFqSUZObGJtUWdjR0Y1YldWdWRDQjBieUJoWkcxcGJnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXWmxaWE5mZEc5ZmQybDBhR1J5WVhjc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16VXhDaUFnSUNBdkx5QnlaWFIxY200Z1ptVmxjMTkwYjE5M2FYUm9aSEpoZHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbWRsZEY5MWMyVnlYM05vWVhKbGN5aDFjMlZ5T2lCaWVYUmxjeXdnYldGeWEyVjBYMmxrT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUmZkWE5sY2w5emFHRnlaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5UTXRNelUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmZFhObGNsOXphR0Z5WlhNb2MyVnNaaXdnZFhObGNqb2dRV05qYjNWdWRDd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUdGeVl6UXVWSFZ3YkdWYllYSmpOQzVWU1c1ME5qUXNJR0Z5WXpRdVZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelUyTFRNMU53b2dJQ0FnTHk4Z0l5QkhaWFFnV1dWeklITm9ZWEpsY3dvZ0lDQWdMeThnZVdWelgzTm9ZWEpsYzE5clpYa2dQU0JpSW5WelpYSmZJaUFySUhWelpYSXVZbmwwWlhNZ0t5QmlJbDl0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYM2xsY3lJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnM05UY3pOalUzTWpWbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEVm1ObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZzFaamM1TmpVM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0yTUFvZ0lDQWdMeThnZVdWelgzTm9ZWEpsY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTJNUW9nSUNBZ0x5OGdhV1lnZVdWelgzTm9ZWEpsYzE5aWIzZ3ViR1Z1WjNSb0lENGdNRG9LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmllaUJuWlhSZmRYTmxjbDl6YUdGeVpYTmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pOaklLSUNBZ0lDOHZJSGxsYzE5emFHRnlaWE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSGxsYzE5emFHRnlaWE5mWW05NExtMWhlV0psS0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTJNd29nSUNBZ0x5OGdlV1Z6WDNOb1lYSmxjeUE5SUc5d0xtSjBiMmtvZVdWelgzTm9ZWEpsYzE5a1lYUmhLUW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDZ3BuWlhSZmRYTmxjbDl6YUdGeVpYTmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelkxTFRNMk5nb2dJQ0FnTHk4Z0l5QkhaWFFnVG04Z2MyaGhjbVZ6Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE5mYTJWNUlEMGdZaUoxYzJWeVh5SWdLeUIxYzJWeUxtSjVkR1Z6SUNzZ1lpSmZiV0Z5YTJWMFh5SWdLeUJ2Y0M1cGRHOWlLRzFoY210bGRGOXBaQ2tnS3lCaUlsOXVieUlLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlRFZtTm1VMlpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNelk1Q2lBZ0lDQXZMeUJ1YjE5emFHRnlaWE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNM01Bb2dJQ0FnTHk4Z2FXWWdibTlmYzJoaGNtVnpYMkp2ZUM1c1pXNW5kR2dnUGlBd09nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVGSmxaaUJsZUdsemRITUtJQ0FnSUdKNklHZGxkRjkxYzJWeVgzTm9ZWEpsYzE5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNM01Rb2dJQ0FnTHk4Z2JtOWZjMmhoY21WelgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCdWIxOXphR0Z5WlhOZlltOTRMbTFoZVdKbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zTWdvZ0lDQWdMeThnYm05ZmMyaGhjbVZ6SUQwZ2IzQXVZblJ2YVNodWIxOXphR0Z5WlhOZlpHRjBZU2tLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9LWjJWMFgzVnpaWEpmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak0zTkFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0dGeVl6UXVWVWx1ZERZMEtIbGxjMTl6YUdGeVpYTXBMQ0JoY21NMExsVkpiblEyTkNodWIxOXphR0Z5WlhNcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzV5WldSbFpXMWZkMmx1Ym1sdVoxOXphR0Z5WlhNb2JXRnlhMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16YzJMVE0zTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjbVZrWldWdFgzZHBibTVwYm1kZmMyaGhjbVZ6S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTNPUzB6T0RBS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYldGeWEyVjBJR1Y0YVhOMGN5QmhibVFnYVhNZ2NtVnpiMngyWldRS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWkRZeE56STJZalkxTnpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk16Z3hDaUFnSUNBdkx5QndiMjlzYzE5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFcxaGNtdGxkRjl3Y21WbWFYZ2dLeUJpSW5CdmIyeHpJaWtLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURabU5tWTJZemN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTRNZ29nSUNBZ0x5OGdZWE56WlhKMElIQnZiMnh6WDJKdmVDNXNaVzVuZEdnZ1BpQXdMQ0FpVFdGeWEyVjBJR1J2WlhNZ2JtOTBJR1Y0YVhOMElnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUW05NFVtVm1JR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemcwQ2lBZ0lDQXZMeUJ3YjI5c2MxOWtZWFJoTENCZlpYaHBjM1J6SUQwZ2NHOXZiSE5mWW05NExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNemcxQ2lBZ0lDQXZMeUJwYzE5eVpYTnZiSFpsWkNBOUlHOXdMbUowYjJrb2IzQXVaWGgwY21GamRDaHdiMjlzYzE5a1lYUmhMQ0JWU1c1ME5qUW9OREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpnMkNpQWdJQ0F2THlCM2FXNXVhVzVuWDI5MWRHTnZiV1VnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEUTRLU3dnVlVsdWREWTBLRGdwS1NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdORGdnTHk4Z05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5eVpYTnZiSFpsWkNBOVBTQlZTVzUwTmpRb01Ta3NJQ0pOWVhKclpYUWdibTkwSUhKbGMyOXNkbVZrSUhsbGRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFoY210bGRDQnViM1FnY21WemIyeDJaV1FnZVdWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pPVEF0TXpreENpQWdJQ0F2THlBaklFZGxkQ0IxYzJWeUozTWdjMmhoY21WekNpQWdJQ0F2THlCMWMyVnlYM05vWVhKbGN5QTlJSE5sYkdZdVoyVjBYM1Z6WlhKZmMyaGhjbVZ6S0ZSNGJpNXpaVzVrWlhJc0lHMWhjbXRsZEY5cFpDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZFhObGNsOXphR0Z5WlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVNZ29nSUNBZ0x5OGdlV1Z6WDNOb1lYSmxjeUE5SUhWelpYSmZjMmhoY21Weld6QmRMbTVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPak01TXdvZ0lDQWdMeThnYm05ZmMyaGhjbVZ6SUQwZ2RYTmxjbDl6YUdGeVpYTmJNVjB1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNNU53b2dJQ0FnTHk4Z2FXWWdkMmx1Ym1sdVoxOXZkWFJqYjIxbElEMDlJRlZKYm5RMk5DZ3hLVG9nSUNNZ1dXVnpJSGR2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaV1JsWlcxZmQybHVibWx1WjE5emFHRnlaWE5mWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTTVPUzAwTURBS0lDQWdJQzh2SUNNZ1EyeGxZWElnV1dWeklITm9ZWEpsY3dvZ0lDQWdMeThnZVdWelgzTm9ZWEpsYzE5clpYa2dQU0JpSW5WelpYSmZJaUFySUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nS3lCaUlsOXRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVgzbGxjeUlLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGczTlRjek5qVTNNalZtQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGcxWmpaa05qRTNNalppTmpVM05EVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnMVpqYzVOalUzTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EQXlDaUFnSUNBdkx5QnBaaUI1WlhOZmMyaGhjbVZ6WDJKdmVDNXNaVzVuZEdnZ1BpQXdPZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHSjZJSEpsWkdWbGJWOTNhVzV1YVc1blgzTm9ZWEpsYzE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRd013b2dJQ0FnTHk4Z2VXVnpYM05vWVhKbGMxOWliM2d1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ25KbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvS2NtVmtaV1Z0WDNkcGJtNXBibWRmYzJoaGNtVnpYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF4TWdvZ0lDQWdMeThnWVhOelpYSjBJSGRwYm01cGJtZGZjMmhoY21WeklENGdWVWx1ZERZMEtEQXBMQ0FpVG04Z2QybHVibWx1WnlCemFHRnlaWE1nZEc4Z2NtVmtaV1Z0SWdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnZDJsdWJtbHVaeUJ6YUdGeVpYTWdkRzhnY21Wa1pXVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTVRjdE5ESXdDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1YjNWMFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReE9Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREUzQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pReE55MDBNakFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXlNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIQmhlVzkxZEY5aGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dweVpXUmxaVzFmZDJsdWJtbHVaMTl6YUdGeVpYTmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1EWXROREEzQ2lBZ0lDQXZMeUFqSUVOc1pXRnlJRTV2SUhOb1lYSmxjd29nSUNBZ0x5OGdibTlmYzJoaGNtVnpYMnRsZVNBOUlHSWlkWE5sY2w4aUlDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QXJJR0lpWDIxaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmYm04aUNpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE56VTNNelkxTnpJMVpnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE5XWTJaRFl4TnpJMllqWTFOelExWmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjROV1kyWlRabUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNRGtLSUNBZ0lDOHZJR2xtSUc1dlgzTm9ZWEpsYzE5aWIzZ3ViR1Z1WjNSb0lENGdNRG9LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkNiM2hTWldZZ1pYaHBjM1J6Q2lBZ0lDQmllaUJ5WldSbFpXMWZkMmx1Ym1sdVoxOXphR0Z5WlhOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME1UQUtJQ0FnSUM4dklHNXZYM05vWVhKbGMxOWliM2d1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ25KbFpHVmxiVjkzYVc1dWFXNW5YM05vWVhKbGMxOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZaUJ5WldSbFpXMWZkMmx1Ym1sdVoxOXphR0Z5WlhOZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVVSEpsWkdsamRHbHZiazFoY210bGRFTnZiblJ5WVdOMExtZGxkRjlqYjI1MGNtRmpkRjlrWldKMVoxOXBibVp2S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjlqYjI1MGNtRmpkRjlrWldKMVoxOXBibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ETXdDaUFnSUNBdkx5QmhjbU0wTGtGa1pISmxjM01vYzJWc1ppNWhaRzFwYmk1MllXeDFaUzVpZVhSbGN5a3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5ETXhDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDIxaGNtdGxkSE11ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalF6TWdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV3YkdGMFptOXliVjltWldWekxuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3YkdGMFptOXliVjltWldWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJzWVhSbWIzSnRYMlpsWlhNZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME16TUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWJXbHVYMnhwY1hWcFpHbDBlUzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWJXbHVYMnhwY1hWcFpHbDBlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOREk1TFRRek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loelpXeG1MbUZrYldsdUxuWmhiSFZsTG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYMjFoY210bGRITXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjR3hoZEdadmNtMWZabVZsY3k1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1dGFXNWZiR2x4ZFdsa2FYUjVMblpoYkhWbEtRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNTJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjeWh4ZFdWemRHbHZiam9nWW5sMFpYTXNJSEpsYzI5c2RYUnBiMjVmZEdsdFpUb2dkV2x1ZERZMExDQm1aV1ZmY21GMFpUb2dkV2x1ZERZMExDQndZWGx0Wlc1MFgyRnRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2RtRnNhV1JoZEdWZlkzSmxZWFJsWDIxaGNtdGxkRjl3WVhKaGJYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTXpZdE5EUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCMllXeHBaR0YwWlY5amNtVmhkR1ZmYldGeWEyVjBYM0JoY21GdGN5Z0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJSEYxWlhOMGFXOXVPaUJUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY21WemIyeDFkR2x2Ymw5MGFXMWxPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFgzSmhkR1U2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwWDJGdGIzVnVkRG9nVlVsdWREWTBDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVRbTl2YkRvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRRMUNpQWdJQ0F2THlCcFppQm1aV1ZmY21GMFpTQStJRlZKYm5RMk5DZ3hNREF3S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eklDOHZJREV3TURBS0lDQWdJRDRLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYMk55WldGMFpWOXRZWEpyWlhSZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRRMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgyTnlaV0YwWlY5dFlYSnJaWFJmY0dGeVlXMXpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEwTndvZ0lDQWdMeThnYVdZZ2NHRjViV1Z1ZEY5aGJXOTFiblFnUENCelpXeG1MbTFwYmw5c2FYRjFhV1JwZEhrdWRtRnNkV1VnS2lBeU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKdGFXNWZiR2x4ZFdsa2FYUjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xcGJsOXNhWEYxYVdScGRIa2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalEwT0FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5amNtVmhkR1ZmYldGeWEyVjBYM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBORGtLSUNBZ0lDOHZJR2xtSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0E4UFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUZWSmJuUTJOQ2d6TmpBd0tUb0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhCMWMyaHBiblFnTXpZd01DQXZMeUF6TmpBd0NpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lENDlDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalExTUFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5amNtVmhkR1ZmYldGeWEyVjBYM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOVEVLSUNBZ0lDOHZJR2xtSUhKbGMyOXNkWFJwYjI1ZmRHbHRaU0ErSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnVlVsdWREWTBLRE14TlRNMk1EQXdLVG9LSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR01nTlNBdkx5QXpNVFV6TmpBd01Bb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQThDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOWpjbVZoZEdWZmJXRnlhMlYwWDNCaGNtRnRjMTloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalExTWdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5amNtVmhkR1ZmYldGeWEyVjBYM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WTJGdVgyTnlaV0YwWlY5dFlYSnJaWFFvYzJWdVpHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU5oYmw5amNtVmhkR1ZmYldGeWEyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRVMUxUUTFOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1kyRnVYMk55WldGMFpWOXRZWEpyWlhRb2MyVnNaaXdnYzJWdVpHVnlPaUJCWTJOdmRXNTBLU0F0UGlCaGNtTTBMa0p2YjJ3NkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoelpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYM0psY1hWcGNtVmtYM0JoZVcxbGJuUmZabTl5WDIxaGNtdGxkQ2dwSUMwK0lIVnBiblEyTkRvS1oyVjBYM0psY1hWcGNtVmtYM0JoZVcxbGJuUmZabTl5WDIxaGNtdGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMk13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXViV2x1WDJ4cGNYVnBaR2wwZVM1MllXeDFaU0FxSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYldsdVgyeHBjWFZwWkdsMGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVc1ZmJHbHhkV2xrYVhSNUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ29LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMbU52Ym5SeVlXTjBMbEJ5WldScFkzUnBiMjVOWVhKclpYUkRiMjUwY21GamRDNXRZWEpyWlhSZlpYaHBjM1J6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2JXRnlhMlYwWDJWNGFYTjBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRMk5TMDBOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHMWhjbXRsZEY5bGVHbHpkSE1vYzJWc1ppd2diV0Z5YTJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUdGeVl6UXVRbTl2YkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TkRZNENpQWdJQ0F2THlCcFppQnRZWEpyWlhSZmFXUWdQajBnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6TG5aaGJIVmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDIxaGNtdGxkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUEQwS0lDQWdJR0o2SUcxaGNtdGxkRjlsZUdsemRITmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOamtLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29SbUZzYzJVcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQUtJQ0FnSUhKbGRITjFZZ29LYldGeWEyVjBYMlY0YVhOMGMxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBOekVLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pRM01nb2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRJRDBnUW05NFVtVm1LR3RsZVQxdFlYSnJaWFJmY0hKbFptbDRJQ3NnWWlKeGRXVnpkR2x2YmlJcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEY3hOelUyTlRjek56UTJPVFptTm1VS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGN6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSEYxWlhOMGFXOXVYMkp2ZUM1c1pXNW5kR2dnUGlBd0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVGSmxaaUJsZUdsemRITUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WjJWMFgyMWhjbXRsZEY5amNtVmhkRzl5S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMjFoY210bGRGOWpjbVZoZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGMxTFRRM05nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWjJWMFgyMWhjbXRsZEY5amNtVmhkRzl5S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCQlkyTnZkVzUwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wTnpnS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhKclpYUmZhV1FnUENCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VzSUNKTllYSnJaWFFnU1VRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmJXRnlhMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5dFlYSnJaWFJ6SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJRWxFSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT0RBS0lDQWdJQzh2SUcxaGNtdGxkRjl3Y21WbWFYZ2dQU0JpSW0xaGNtdGxkRjhpSUNzZ2IzQXVhWFJ2WWlodFlYSnJaWFJmYVdRcElDc2dZaUpmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1RMk1UY3lObUkyTlRjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTRNUW9nSUNBZ0x5OGdZM0psWVhSdmNsOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUltTnlaV0YwYjNJaUtRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZzJNemN5TmpVMk1UYzBObVkzTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpjbVZoZEc5eVgySnZlQzVzWlc1bmRHZ2dQaUF3TENBaVRXRnlhMlYwSUdOeVpXRjBiM0lnWkdGMFlTQnViM1FnWm05MWJtUWlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRnlhMlYwSUdOeVpXRjBiM0lnWkdGMFlTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalE0TkFvZ0lDQWdMeThnWTNKbFlYUnZjbDlpZVhSbGN5d2dYMlY0YVhOMGN5QTlJR055WldGMGIzSmZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EZzFDaUFnSUNBdkx5QnlaWFIxY200Z1FXTmpiM1Z1ZENoamNtVmhkRzl5WDJKNWRHVnpLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCc1pXNW5kR2dnYVhNZ016SWdZbmwwWlhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGxCeVpXUnBZM1JwYjI1TllYSnJaWFJEYjI1MGNtRmpkQzV6YVcxMWJHRjBaVjk1WlhOZmRISmhaR1VvYldGeWEyVjBYMmxrT2lCMWFXNTBOalFzSUhCaGVXMWxiblJmWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B6YVcxMWJHRjBaVjk1WlhOZmRISmhaR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME9EY3RORGc0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnphVzExYkdGMFpWOTVaWE5mZEhKaFpHVW9jMlZzWml3Z2JXRnlhMlYwWDJsa09pQlZTVzUwTmpRc0lIQmhlVzFsYm5SZllXMXZkVzUwT2lCVlNXNTBOalFwSUMwK0lHRnlZelF1VkhWd2JHVmJZWEpqTkM1VlNXNTBOalFzSUdGeVl6UXVWVWx1ZERZMFhUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Ea3dDaUFnSUNBdkx5QmhjM05sY25RZ2JXRnlhMlYwWDJsa0lEd2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbExDQWlUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyMWhjbXRsZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJXRnlhMlYwY3lCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORGt5Q2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYldGeWEyVjBYMmxrS1NBcklHSWlYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvME9UTUtJQ0FnSUM4dklIQnZiMnh6WDJKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YldGeWEyVjBYM0J5WldacGVDQXJJR0lpY0c5dmJITWlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EazBDaUFnSUNBdkx5QmhjM05sY25RZ2NHOXZiSE5mWW05NExteGxibWQwYUNBK0lEQXNJQ0pOWVhKclpYUWdaR0YwWVNCdWIzUWdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJDYjNoU1pXWWdaWGhwYzNSekNpQWdJQ0JoYzNObGNuUWdMeThnVFdGeWEyVjBJR1JoZEdFZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPVFlLSUNBZ0lDOHZJSEJ2YjJ4elgyUmhkR0VzSUY5bGVHbHpkSE1nUFNCd2IyOXNjMTlpYjNndWJXRjVZbVVvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBPVGdLSUNBZ0lDOHZJSGxsYzE5d2IyOXNJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnd0tTd2dWVWx1ZERZMEtEZ3BLU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wT1RrS0lDQWdJQzh2SUc1dlgzQnZiMndnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2NHOXZiSE5mWkdGMFlTd2dWVWx1ZERZMEtEZ3BMQ0JWU1c1ME5qUW9PQ2twS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UQXdDaUFnSUNBdkx5Qm1aV1ZmY21GMFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTWpRcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRBeUxUVXdNd29nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnZEhKaFpHVWdjMmx0ZFd4aGRHbHZiZ29nSUNBZ0x5OGdabVZsWDJGdGIzVnVkQ0E5SUNod1lYbHRaVzUwWDJGdGIzVnVkQ0FxSUdabFpWOXlZWFJsS1NBdkx5QXhNREF3TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREFLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV3TkFvZ0lDQWdMeThnZEhKaFpHVmZZVzF2ZFc1MElEMGdjR0Y1YldWdWRGOWhiVzkxYm5RZ0xTQm1aV1ZmWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNRFVLSUNBZ0lDOHZJSE5vWVhKbGMxOXlaV05sYVhabFpDQTlJQ2gwY21Ga1pWOWhiVzkxYm5RZ0tpQnViMTl3YjI5c0tTQXZMeUFvZVdWelgzQnZiMndnS3lCMGNtRmtaVjloYlc5MWJuUXBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXdOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVZVbHVkRFkwS0hOb1lYSmxjMTl5WldObGFYWmxaQ2tzSUdGeVl6UXVWVWx1ZERZMEtHWmxaVjloYlc5MWJuUXBLU2tLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbk5wYlhWc1lYUmxYMjV2WDNSeVlXUmxLRzFoY210bGRGOXBaRG9nZFdsdWREWTBMQ0J3WVhsdFpXNTBYMkZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tjMmx0ZFd4aGRHVmZibTlmZEhKaFpHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTURrdE5URXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCemFXMTFiR0YwWlY5dWIxOTBjbUZrWlNoelpXeG1MQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ3dnY0dGNWJXVnVkRjloYlc5MWJuUTZJRlZKYm5RMk5Da2dMVDRnWVhKak5DNVVkWEJzWlZ0aGNtTTBMbFZKYm5RMk5Dd2dZWEpqTkM1VlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTVRJS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhKclpYUmZhV1FnUENCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNdWRtRnNkV1VzSUNKTllYSnJaWFFnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmYldGeWEyVjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Z5YTJWMElHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU1UUUtJQ0FnSUM4dklHMWhjbXRsZEY5d2NtVm1hWGdnUFNCaUltMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tUTJNVGN5Tm1JMk5UYzBOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURWbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV4TlFvZ0lDQWdMeThnY0c5dmJITmZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMXRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE56QTJaalptTm1NM013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTVRZS0lDQWdJQzh2SUdGemMyVnlkQ0J3YjI5c2MxOWliM2d1YkdWdVozUm9JRDRnTUN3Z0lrMWhjbXRsZENCa1lYUmhJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFSnZlRkpsWmlCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWEpyWlhRZ1pHRjBZU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVeE9Bb2dJQ0FnTHk4Z2NHOXZiSE5mWkdGMFlTd2dYMlY0YVhOMGN5QTlJSEJ2YjJ4elgySnZlQzV0WVhsaVpTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVeU1Bb2dJQ0FnTHk4Z2VXVnpYM0J2YjJ3Z1BTQnZjQzVpZEc5cEtHOXdMbVY0ZEhKaFkzUW9jRzl2YkhOZlpHRjBZU3dnVlVsdWREWTBLREFwTENCVlNXNTBOalFvT0NrcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXlNUW9nSUNBZ0x5OGdibTlmY0c5dmJDQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvT0Nrc0lGVkpiblEyTkNnNEtTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTWpJS0lDQWdJQzh2SUdabFpWOXlZWFJsSUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIQnZiMnh6WDJSaGRHRXNJRlZKYm5RMk5DZ3lOQ2tzSUZWSmJuUTJOQ2c0S1NrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01qUWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFNalF0TlRJMUNpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQjBjbUZrWlNCemFXMTFiR0YwYVc5dUNpQWdJQ0F2THlCbVpXVmZZVzF2ZFc1MElEMGdLSEJoZVcxbGJuUmZZVzF2ZFc1MElDb2dabVZsWDNKaGRHVXBJQzh2SURFd01EQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNvS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01Bb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5USTJDaUFnSUNBdkx5QjBjbUZrWlY5aGJXOTFiblFnUFNCd1lYbHRaVzUwWDJGdGIzVnVkQ0F0SUdabFpWOWhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVeU53b2dJQ0FnTHk4Z2MyaGhjbVZ6WDNKbFkyVnBkbVZrSUQwZ0tIUnlZV1JsWDJGdGIzVnVkQ0FxSUhsbGMxOXdiMjlzS1NBdkx5QW9ibTlmY0c5dmJDQXJJSFJ5WVdSbFgyRnRiM1Z1ZENrS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNBcUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdMd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRJNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVWU1c1ME5qUW9jMmhoY21WelgzSmxZMlZwZG1Wa0tTd2dZWEpqTkM1VlNXNTBOalFvWm1WbFgyRnRiM1Z1ZENrcEtRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDNWpiMjUwY21GamRDNVFjbVZrYVdOMGFXOXVUV0Z5YTJWMFEyOXVkSEpoWTNRdVoyVjBYMjFoY210bGRGOXZaR1J6S0cxaGNtdGxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMjFoY210bGRGOXZaR1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UTXhMVFV6TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdaMlYwWDIxaGNtdGxkRjl2WkdSektITmxiR1lzSUcxaGNtdGxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5GMDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVXpOQW9nSUNBZ0x5OGdZWE56WlhKMElHMWhjbXRsZEY5cFpDQThJSE5sYkdZdWRHOTBZV3hmYldGeWEyVjBjeTUyWVd4MVpTd2dJazFoY210bGRDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXRZWEpyWlhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyMWhjbXRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCTllYSnJaWFFnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV6TmdvZ0lDQWdMeThnY0c5dmJITWdQU0J6Wld4bUxtZGxkRjl0WVhKclpYUmZjRzl2YkhNb2JXRnlhMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5dFlYSnJaWFJmY0c5dmJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalV6TndvZ0lDQWdMeThnZVdWelgzQnZiMndnUFNCd2IyOXNjMXN3WFM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5UTTRDaUFnSUNBdkx5QnViMTl3YjI5c0lEMGdjRzl2YkhOYk1WMHVibUYwYVhabENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFF3Q2lBZ0lDQXZMeUIwYjNSaGJGOXNhWEYxYVdScGRIa2dQU0I1WlhOZmNHOXZiQ0FySUc1dlgzQnZiMndLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVFF4Q2lBZ0lDQXZMeUJwWmlCMGIzUmhiRjlzYVhGMWFXUnBkSGtnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW01NklHZGxkRjl0WVhKclpYUmZiMlJrYzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1VlVsdWREWTBLRFV3S1N3Z1lYSmpOQzVWU1c1ME5qUW9OVEFwS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNekl3TURBd01EQXdNREF3TURBd01ETXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgyMWhjbXRsZEY5dlpHUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUwTkMwMU5EVUtJQ0FnSUM4dklDTWdRMjkxYm5SbGNpMXBiblIxYVhScGRtVWdRVTFOSUhCeWFXTnBibWM2SUd4aGNtZGxjaUJPVHlCd2IyOXNJRDBnYUdsbmFHVnlJRmxGVXlCd2NtOWlZV0pwYkdsMGVRb2dJQ0FnTHk4Z2VXVnpYM0JsY21ObGJuUmhaMlVnUFNBb2JtOWZjRzl2YkNBcUlERXdNQ2tnTHk4Z2RHOTBZV3hmYkdseGRXbGthWFI1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0FxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTkRZS0lDQWdJQzh2SUc1dlgzQmxjbU5sYm5SaFoyVWdQU0FvZVdWelgzQnZiMndnS2lBeE1EQXBJQzh2SUhSdmRHRnNYMnhwY1hWcFpHbDBlUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaHBiblFnTVRBd0lDOHZJREV3TUFvZ0lDQWdLZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDaGhjbU0wTGxWSmJuUTJOQ2g1WlhOZmNHVnlZMlZ1ZEdGblpTa3NJR0Z5WXpRdVZVbHVkRFkwS0c1dlgzQmxjbU5sYm5SaFoyVXBLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVaMlYwWDNWelpYSmZjRzl6YVhScGIyNWZkbUZzZFdVb2RYTmxjam9nWW5sMFpYTXNJRzFoY210bGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWjJWMFgzVnpaWEpmY0c5emFYUnBiMjVmZG1Gc2RXVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTlRBdE5UVXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZkWE5sY2w5d2IzTnBkR2x2Ymw5MllXeDFaU2h6Wld4bUxDQjFjMlZ5T2lCQlkyTnZkVzUwTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdZWEpqTkM1VWRYQnNaVnRoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUmRPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOVE1LSUNBZ0lDOHZJSFZ6WlhKZmMyaGhjbVZ6SUQwZ2MyVnNaaTVuWlhSZmRYTmxjbDl6YUdGeVpYTW9kWE5sY2l3Z2JXRnlhMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdaMlYwWDNWelpYSmZjMmhoY21WekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOVFFLSUNBZ0lDOHZJRzlrWkhNZ1BTQnpaV3htTG1kbGRGOXRZWEpyWlhSZmIyUmtjeWh0WVhKclpYUmZhV1FwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjFoY210bGRGOXZaR1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5UWUtJQ0FnSUM4dklIbGxjMTl6YUdGeVpYTWdQU0IxYzJWeVgzTm9ZWEpsYzFzd1hTNXVZWFJwZG1VS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTFOd29nSUNBZ0x5OGdibTlmYzJoaGNtVnpJRDBnZFhObGNsOXphR0Z5WlhOYk1WMHVibUYwYVhabENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRVNENpQWdJQ0F2THlCNVpYTmZiMlJrY3lBOUlHOWtaSE5iTUYwdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5Ua0tJQ0FnSUM4dklHNXZYMjlrWkhNZ1BTQnZaR1J6V3pGZExtNWhkR2wyWlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPalUyTVMwMU5qSUtJQ0FnSUM4dklDTWdSWE4wYVcxaGRHVmtJSFpoYkhWbElHSmhjMlZrSUc5dUlHTjFjbkpsYm5RZ2IyUmtjeUFvYm05MElHZDFZWEpoYm5SbFpXUWdjR0Y1YjNWMEtRb2dJQ0FnTHk4Z2VXVnpYM1poYkhWbElEMGdLSGxsYzE5emFHRnlaWE1nS2lCNVpYTmZiMlJrY3lrZ0x5OGdNVEF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5qTUtJQ0FnSUM4dklHNXZYM1poYkhWbElEMGdLRzV2WDNOb1lYSmxjeUFxSUc1dlgyOWtaSE1wSUM4dklERXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5qVUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDaGhjbU0wTGxWSmJuUTJOQ2g1WlhOZmRtRnNkV1VwTENCaGNtTTBMbFZKYm5RMk5DaHViMTkyWVd4MVpTa3BLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVRY21Wa2FXTjBhVzl1VFdGeWEyVjBRMjl1ZEhKaFkzUXVaMlYwWDJKdmVGOXVZVzFsY3lodFlYSnJaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjlpYjNoZmJtRnRaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU5qY3ROVFk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQm5aWFJmWW05NFgyNWhiV1Z6S0hObGJHWXNJRzFoY210bGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCaGNtTTBMbFIxY0d4bFcyRnlZelF1VTNSeWFXNW5MQ0JoY21NMExsTjBjbWx1Wnl3Z1lYSmpOQzVUZEhKcGJtZGRPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFOekFLSUNBZ0lDOHZJRzFoY210bGRGOXdjbVZtYVhnZ1BTQmlJbTFoY210bGRGOGlJQ3NnYjNBdWFYUnZZaWh0WVhKclpYUmZhV1FwSUNzZ1lpSmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRObVEyTVRjeU5tSTJOVGMwTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM01nb2dJQ0FnTHk4Z2NYVmxjM1JwYjI1ZlltOTRYMjVoYldVZ1BTQmhjbU0wTGxOMGNtbHVaeWhUZEhKcGJtY3Vabkp2YlY5aWVYUmxjeWh0WVhKclpYUmZjSEpsWm1sNElDc2dZaUp4ZFdWemRHbHZiaUlwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURjeE56VTJOVGN6TnpRMk9UWm1ObVVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM013b2dJQ0FnTHk4Z2NHOXZiSE5mWW05NFgyNWhiV1VnUFNCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jdVpuSnZiVjlpZVhSbGN5aHRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSndiMjlzY3lJcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzNNRFptTm1ZMll6Y3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNlVzFoY210bGRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xTnpRS0lDQWdJQzh2SUdOeVpXRjBiM0pmWW05NFgyNWhiV1VnUFNCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jdVpuSnZiVjlpZVhSbGN5aHRZWEpyWlhSZmNISmxabWw0SUNzZ1lpSmpjbVZoZEc5eUlpa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWaklERTBJQzh2SURCNE5qTTNNalkxTmpFM05EWm1OeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tIRjFaWE4wYVc5dVgySnZlRjl1WVcxbExDQndiMjlzYzE5aWIzaGZibUZ0WlN3Z1kzSmxZWFJ2Y2w5aWIzaGZibUZ0WlNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z05nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1UWNtVmthV04wYVc5dVRXRnlhMlYwUTI5dWRISmhZM1F1WjJWMFgzVnpaWEpmWW05NFgyNWhiV1Z6S0hWelpYSTZJR0o1ZEdWekxDQnRZWEpyWlhSZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEY5MWMyVnlYMkp2ZUY5dVlXMWxjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM09DMDFOemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjkxYzJWeVgySnZlRjl1WVcxbGN5aHpaV3htTENCMWMyVnlPaUJCWTJOdmRXNTBMQ0J0WVhKclpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVVZFhCc1pWdGhjbU0wTGxOMGNtbHVaeXdnWVhKak5DNVRkSEpwYm1kZE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU9ERUtJQ0FnSUM4dklIbGxjMTlpYjNoZmJtRnRaU0E5SUdGeVl6UXVVM1J5YVc1bktGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektHSWlkWE5sY2w4aUlDc2dkWE5sY2k1aWVYUmxjeUFySUdJaVgyMWhjbXRsZEY4aUlDc2diM0F1YVhSdllpaHRZWEpyWlhSZmFXUXBJQ3NnWWlKZmVXVnpJaWtwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TnpVM016WTFOekkxWmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnMVpqWmtOakUzTWpaaU5qVTNORFZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE5XWTNPVFkxTnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qVTRNZ29nSUNBZ0x5OGdibTlmWW05NFgyNWhiV1VnUFNCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jdVpuSnZiVjlpZVhSbGN5aGlJblZ6WlhKZklpQXJJSFZ6WlhJdVlubDBaWE1nS3lCaUlsOXRZWEpyWlhSZklpQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLU0FySUdJaVgyNXZJaWtwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURWbU5tVTJaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TlRnMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb2VXVnpYMkp2ZUY5dVlXMWxMQ0J1YjE5aWIzaGZibUZ0WlNrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVVISmxaR2xqZEdsdmJrMWhjbXRsZEVOdmJuUnlZV04wTG5aaGJHbGtZWFJsWDNSeVlXUnBibWRmY0dGeVlXMXpLRzFoY210bGRGOXBaRG9nZFdsdWREWTBMQ0J3WVhsdFpXNTBYMkZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tkbUZzYVdSaGRHVmZkSEpoWkdsdVoxOXdZWEpoYlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPRFl0TlRnM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUIyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGN5aHpaV3htTENCdFlYSnJaWFJmYVdRNklGVkpiblEyTkN3Z2NHRjViV1Z1ZEY5aGJXOTFiblE2SUZWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVVZFhCc1pWdGhjbU0wTGtKdmIyd3NJR0Z5WXpRdVUzUnlhVzVuWFRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGc1Q2lBZ0lDQXZMeUJwWmlCdFlYSnJaWFJmYVdRZ1BqMGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMjFoY210bGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiV0Z5YTJWMGN5QmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQRDBLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Ua3dDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29ZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd2dZWEpqTkM1VGRISnBibWNvSWsxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRDSXBLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd016QXdNVFUwWkRZeE56STJZalkxTnpReU1EWTBObVkyTlRjek1qQTJaVFptTnpReU1EWTFOemcyT1Rjek56UUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWVd4cFpHRjBaVjkwY21Ga2FXNW5YM0JoY21GdGMxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPVElLSUNBZ0lDOHZJR2xtSUhCaGVXMWxiblJmWVcxdmRXNTBJRHdnVlVsdWREWTBLREV3TURBcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6TWdMeThnTVRBd01Bb2dJQ0FnUEFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmZEhKaFpHbHVaMTl3WVhKaGJYTmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExrSnZiMndvUm1Gc2MyVXBMQ0JoY21NMExsTjBjbWx1WnlnaVRXbHVhVzExYlNCd1lYbHRaVzUwSUdseklERXdNREFnYldsamNtOUJURWRQY3lJcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TXpBd01qSTBaRFk1Tm1VMk9UWmtOelUyWkRJd056QTJNVGM1Tm1RMk5UWmxOelF5TURZNU56TXlNRE14TXpBek1ETXdNakEyWkRZNU5qTTNNalptTkRFMFl6UTNOR1kzTXdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgzUnlZV1JwYm1kZmNHRnlZVzF6WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVNU5Rb2dJQ0FnTHk4Z2JXRnlhMlYwWDNCeVpXWnBlQ0E5SUdJaWJXRnlhMlYwWHlJZ0t5QnZjQzVwZEc5aUtHMWhjbXRsZEY5cFpDa2dLeUJpSWw4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMlpEWXhOekkyWWpZMU56UTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TldZS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOVGsyQ2lBZ0lDQXZMeUJ3YjI5c2MxOWliM2dnUFNCQ2IzaFNaV1lvYTJWNVBXMWhjbXRsZEY5d2NtVm1hWGdnS3lCaUluQnZiMnh6SWlrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnM01EWm1ObVkyWXpjekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPVGNLSUNBZ0lDOHZJR2xtSUhCdmIyeHpYMkp2ZUM1c1pXNW5kR2dnUFQwZ01Eb0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzaFNaV1lnWlhocGMzUnpDaUFnSUNCaWJub2dkbUZzYVdSaGRHVmZkSEpoWkdsdVoxOXdZWEpoYlhOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMU9UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDaGhjbU0wTGtKdmIyd29SbUZzYzJVcExDQmhjbU0wTGxOMGNtbHVaeWdpVFdGeWEyVjBJR1JoZEdFZ2JtOTBJR1p2ZFc1a0lpa3BLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBek1EQXhOVFJrTmpFM01qWmlOalUzTkRJd05qUTJNVGMwTmpFeU1EWmxObVkzTkRJd05qWTJaamMxTm1VMk5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXdNQW9nSUNBZ0x5OGdjRzl2YkhOZlpHRjBZU3dnWDJWNGFYTjBjeUE5SUhCdmIyeHpYMkp2ZUM1dFlYbGlaU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1ERUtJQ0FnSUM4dklHbHpYM0psYzI5c2RtVmtJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNnME1Da3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EQWdMeThnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2VXMWhjbXRsZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJNRElLSUNBZ0lDOHZJSEpsYzI5c2RYUnBiMjVmZEdsdFpTQTlJRzl3TG1KMGIya29iM0F1WlhoMGNtRmpkQ2h3YjI5c2MxOWtZWFJoTENCVlNXNTBOalFvTXpJcExDQlZTVzUwTmpRb09Da3BLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qQTBDaUFnSUNBdkx5QnBaaUJwYzE5eVpYTnZiSFpsWkNBaFBTQlZTVzUwTmpRb01DazZDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOTBjbUZrYVc1blgzQmhjbUZ0YzE5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZd05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tHRnlZelF1UW05dmJDaEdZV3h6WlNrc0lHRnlZelF1VTNSeWFXNW5LQ0pOWVhKclpYUWdhWE1nWVd4eVpXRmtlU0J5WlhOdmJIWmxaQ0lwS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNekF3TVdFMFpEWXhOekkyWWpZMU56UXlNRFk1TnpNeU1EWXhObU0zTWpZMU5qRTJORGM1TWpBM01qWTFOek0yWmpaak56WTJOVFkwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2RtRnNhV1JoZEdWZmRISmhaR2x1WjE5d1lYSmhiWE5mWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpBM0NpQWdJQ0F2THlCcFppQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBK1BTQnlaWE52YkhWMGFXOXVYM1JwYldVNkNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdQajBLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYM1J5WVdScGJtZGZjR0Z5WVcxelgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXdPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NJR0Z5WXpRdVUzUnlhVzVuS0NKVWNtRmthVzVuSUdoaGN5QmxibVJsWkNJcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TXpBd01URTFORGN5TmpFMk5EWTVObVUyTnpJd05qZzJNVGN6TWpBMk5UWmxOalEyTlRZMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tkbUZzYVdSaGRHVmZkSEpoWkdsdVoxOXdZWEpoYlhOZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4NWJXRnlhMlYwWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWXhNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVFtOXZiQ2hVY25WbEtTd2dZWEpqTkM1VGRISnBibWNvSWxaaGJHbGtJaWtwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBd01EQXpNREF3TlRVMk5qRTJZelk1TmpRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F1WTI5dWRISmhZM1F1VUhKbFpHbGpkR2x2YmsxaGNtdGxkRU52Ym5SeVlXTjBMbWRsZEY5aGJHeGZiV0Z5YTJWMGMxOXpkVzF0WVhKNUtDa2dMVDRnWW5sMFpYTTZDbWRsZEY5aGJHeGZiV0Z5YTJWMGMxOXpkVzF0WVhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakV5TFRZeE13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWjJWMFgyRnNiRjl0WVhKclpYUnpYM04xYlcxaGNua29jMlZzWmlrZ0xUNGdZWEpqTkM1VWRYQnNaVnRoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVWU1c1ME5qUXNJR0Z5WXpRdVZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakUxQ2lBZ0lDQXZMeUIwYjNSaGJGOXRZWEpyWlhSeklEMGdjMlZzWmk1MGIzUmhiRjl0WVhKclpYUnpMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZiV0Z5YTJWMGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXRZWEpyWlhSeklHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qRTJDaUFnSUNBdkx5QjBiM1JoYkY5bVpXVnpJRDBnYzJWc1ppNXdiR0YwWm05eWJWOW1aV1Z6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNHeGhkR1p2Y20xZlptVmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2JHRjBabTl5YlY5bVpXVnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakU0TFRZeE9Rb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdkRzkwWVd3Z2RtOXNkVzFsSUdGamNtOXpjeUJoYkd3Z2JXRnlhMlYwY3dvZ0lDQWdMeThnZEc5MFlXeGZkbTlzZFcxbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakl3Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9kRzkwWVd4ZmJXRnlhMlYwY3lrNkNpQWdJQ0JrZFhBS0NtZGxkRjloYkd4ZmJXRnlhMlYwYzE5emRXMXRZWEo1WDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeDViV0Z5YTJWMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPall5TUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSFJ2ZEdGc1gyMWhjbXRsZEhNcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmWVd4c1gyMWhjbXRsZEhOZmMzVnRiV0Z5ZVY5aFpuUmxjbDltYjNKQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakl4Q2lBZ0lDQXZMeUJ0WVhKclpYUmZjSEpsWm1sNElEMGdZaUp0WVhKclpYUmZJaUFySUc5d0xtbDBiMklvYVNrZ0t5QmlJbDhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFprTmpFM01qWmlOalUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1qSUtJQ0FnSUM4dklIQnZiMnh6WDJKdmVDQTlJRUp2ZUZKbFppaHJaWGs5YldGeWEyVjBYM0J5WldacGVDQXJJR0lpY0c5dmJITWlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGN3Tm1ZMlpqWmpOek1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeU13b2dJQ0FnTHk4Z2FXWWdjRzl2YkhOZlltOTRMbXhsYm1kMGFDQStJREE2Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lub2daMlYwWDJGc2JGOXRZWEpyWlhSelgzTjFiVzFoY25sZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk1qUUtJQ0FnSUM4dklIQnZiMnh6WDJSaGRHRXNJRjlsZUdsemRITWdQU0J3YjI5c2MxOWliM2d1YldGNVltVW9LUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJMUNpQWdJQ0F2THlCdFlYSnJaWFJmZG05c2RXMWxJRDBnYjNBdVluUnZhU2h2Y0M1bGVIUnlZV04wS0hCdmIyeHpYMlJoZEdFc0lGVkpiblEyTkNneE5pa3NJRlZKYm5RMk5DZzRLU2twQ2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJIbHRZWEpyWlhSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZOakkyQ2lBZ0lDQXZMeUIwYjNSaGJGOTJiMngxYldVZ0t6MGdiV0Z5YTJWMFgzWnZiSFZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0taMlYwWDJGc2JGOXRZWEpyWlhSelgzTjFiVzFoY25sZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJd0NpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvZEc5MFlXeGZiV0Z5YTJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ1lpQm5aWFJmWVd4c1gyMWhjbXRsZEhOZmMzVnRiV0Z5ZVY5bWIzSmZhR1ZoWkdWeVFERUtDbWRsZEY5aGJHeGZiV0Z5YTJWMGMxOXpkVzF0WVhKNVgyRm1kR1Z5WDJadmNrQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiSGx0WVhKclpYUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpJNUNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaDBiM1JoYkY5dFlYSnJaWFJ6S1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzZVcxaGNtdGxkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMk16QUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSFJ2ZEdGc1gzWnZiSFZ0WlNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YkhsdFlYSnJaWFJmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5qTXhDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOW1aV1Z6S1FvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMng1YldGeWEyVjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeU9DMDJNeklLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaDBiM1JoYkY5dFlYSnJaWFJ6S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOTJiMngxYldVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hSdmRHRnNYMlpsWlhNcENpQWdJQ0F2THlBcEtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBR0FBRUk2QWVRVG9EbmhBOG1Ed1FWSDN4MUIyMWhjbXRsZEY4Qlh3MTBiM1JoYkY5dFlYSnJaWFJ6QlhCdmIyeHpEWEJzWVhSbWIzSnRYMlpsWlhNQkFBVmhaRzFwYmdWMWMyVnlYd2hmYldGeWEyVjBYdzF0YVc1ZmJHbHhkV2xrYVhSNUNIRjFaWE4wYVc5dUJGOTVaWE1EWDI1dkIyTnlaV0YwYjNJeEcwRURSNEljQkp6QUlRUUVwQVFoTWdTZDNWejhCSnBmY244RWhPSmdwd1NYV2xJWkJMTmxKTndFNmRmM3NnUVA1UzM3QkUrMnI5d0VqSjFLc1FTdDNKYXJCQm84WmxNRWNuaFRIZ1J5QVlsdkJMN0NuTW9FQjFNN2xRVDNvUDBwQkdWTW1xd0VweXRjWFFTVnpLaGRCUEM2bGVZRUpJSzRFUVR4elBkTUJFZFJqbVFFN0lxTyt3UStXSnh5Qkg0UTZNWTJHZ0NPSEFKc0FrTUNKd0lUQWY4QjZnSExBYXdCbVFHSUFYY0JaZ0ZNQVRjQkp3RUZBTzhBM2dES0FMWUFuZ0NHQUhJQVdBQkVBQ29BRWdBQ0lrTXhHUlJFTVJoRWlBbjZLRXhRc0NORE1Sa1VSREVZUkRZYUFSYzJHZ0lYaUFqbktFeFFzQ05ETVJrVVJERVlSRFlhQVJmQUhEWWFBaGVJQ0pBb1RGQ3dJME14R1JSRU1SaEVOaG9CRjRnSUppaE1VTEFqUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0lYaUFmWktFeFFzQ05ETVJrVVJERVlSRFlhQVJlSUIzVW9URkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQnhzb1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFoZUlCc0VvVEZDd0kwTXhHUlJFTVJoRU5ob0JGNGdHaWloTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFaU0tFeFFzQ05ETVJrVVJERVlSSWdHT1JZb1RGQ3dJME14R1JSRU1SaEVOaG9CRjhBY2lBWVFLRXhRc0NORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWhjMkdnTVhOaG9FRjRnRnJ5aE1VTEFqUXpFWkZFUXhHRVNJQlhnb1RGQ3dJME14R1JSRU1SaEVOaG9CRjRnRTNoWW9URkN3STBNeEdSUkVNUmhFTmhvQkY4QWNOaG9DRjRnRWZTaE1VTEFqUXpFWkZFUXhHRVNJQkVnV0tFeFFzQ05ETVJrVVJERVlSSWdFTVJZb1RGQ3dJME14R1JSRU1SaEVpQVFiRmloTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ2lBT2xJME14R1JSRU1SaEVOaG9CRnpFV0l3bEpPQkFqRWtTSUFzRVdLRXhRc0NORE1Sa1VSREVZUkRZYUFSY3hGaU1KU1RnUUl4SkVpQUhZRmloTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFHZEZpaE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBRlVLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlBUkVvVEZDd0kwTXhHUlJFTVJoRU5ob0JGNGdBNkVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQURZYUFoYzJHZ01YTVJZakNVazRFQ01TUklnQVBSWW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0FEU05ETVJsQS9YOHhHQlJFSTBPS0FRQXlDVEVBRWtRbkJ6RUFaeXNpWnljRkltY25Db3YvWjRtS0JBRXhBQ0luQjJWRUVrU0wvaVVPUkl2L09BY3lDaEpFaS84NENDSW5DbVZFZ1FJTFN3RU9SRElIZ1pBY0NJdjlERVF5QnlFRkNJdjlEMFFpSzJWRVNSWXBURkFxVUVrbkMxQ0wvTDlKSndSUVR3T0JBZ29XU1ZBaUZreExBVkNML2haUWkvMFdVRXNCVUV4UXZ5Y09VREVBdjBrakNDdE1aNG1LQVFHTC94WXBURkFxVUNjTFVFbTlSRVMrU0ltS0FRR0wveFlwVEZBcVVDY0VVRW05UkVTK1NFa2lXMHNCSkZ0UEFvRVFXMDhDRms4Q0ZrOENGazRDVUV4UWlZb0JBWXYvRmlsTVVDcFFKd1JRU2IxRVJMNUlTWUVvVzB5Qk1GdE1JeEluQmlKUEFsUk1JeEluQmlKUEFsUWlVeU5NVkltS0FRR0wvNGovbFVraVcwd2tXMGxPQWdoSlFBQUdnZlFEakFDSml3QWxDNHNCQ293QWlZb0NBWXYrRmlsTEFWQXFVQ2NFVUVtOVJFUkp2a2hKSWx0TEFTUmJTd0tCRUZ0TEE0RVlXMHNFZ1NCYlN3V0JLRnRKRkVReUIwc0NERVNML3pnQU1RQVNSSXYvT0FjeUNoSkVpLzg0Q0VsRVNTVVBSRWxMQkFzaEJBcEtDVWxMQ0F0UENVOENDRXhMQVFwT0MwOEdUd01JVHdlQk1GdFBBaFpQQnhaUVR3SVdVRThGRmxCUEJCWlFUd01XVUV3V1VFOENUTDhpSndWbFJBZ25CVXhuSndneEFGQW5DVkJNVUNjTVVFa2lUTDFFUVFBSGl3RytTQmVNQW9zQ2l3QkpUZ0lJRm9zQlRMK01BSW1LQWdHTC9oWXBTd0ZRS2xBbkJGQkp2VVJFU2I1SVNTSmJTd0VrVzBzQ2dSQmJTd09CR0Z0TEJJRWdXMHNGZ1NoYlNSUkVNZ2RMQWd4RWkvODRBREVBRWtTTC96Z0hNZ29TUkl2L09BaEpSRWtsRDBSSlN3UUxJUVFLU2dsSlN3a0xUd2hQQWdoTVN3RUtUZ3RQQms4RENFOEhnVEJiVHdjV1R3TVdVRThDRmxCUEJSWlFUd1FXVUU4REZsQk1GbEJQQWt5L0lpY0ZaVVFJSndWTVp5Y0lNUUJRSndsUVRGQW5EVkJKSWt5OVJFRUFCNHNCdmtnWGpBS0xBb3NBU1U0Q0NCYUxBVXkvakFDSmlnSUFNUUFpSndkbFJCSkVpLzRXS1V4UUtsQW5CRkJKdlVSRVNiNUlTU0piU3dFa1cwc0NnUkJiU3dPQkdGdExCSUVnVzA4RmdTaGJGRVF5QjBzQkQwUlBCQlpQQkJaUVR3TVdVRThDRmxCTUZsQWpGbENML3lKVEZsQy9pU0lyWlVTSklpY0ZaVVNKTVFBaUp3ZGxSQkpFSWljRlpVUkpSQ2NGSW1leE1RQkxBYklJc2djanNoQWlzZ0d6aVlvQ0FTS0FBQ2NJaS81UUp3bFFpLzhXVUVrbkRGQkpJa3k5UkVFQUI0c0R2a2dYakFTTEFpY05VRW1NQUNLTUFiMUVRUUFIaXdDK1NCZU1BWXNFRm9zQkZsQ01BSW1LQVFFaVNZdi9Ga2twVEZBcVVDY0VVRW05UkVTK1NFbUJLRnRNZ1RCYlRDTVNSREVBaS8rSS81QkpJbHRPQXlSYlRnSWpFa0VBTUNjSU1RQlFKd2xRVEZBbkRGQkpqQUc5UkVFQUJJc0J2RWlMQWtsRXNURUFTd0d5Q0xJSEk3SVFJcklCczR3QWlTY0lNUUJRSndsUVRGQW5EVkJKakFDOVJFRUFCSXNBdkVpTEEwTC96U0luQjJWRVNSV0JJQkpFSWl0bFJCWWlKd1ZsUkJZaUp3cGxSQlpQQTA4RFVFOENVRXhRaVlvRUFZditKUTFCQUFNbkJva2lKd3BsUklFQ0M0di9EVUVBQXljR2lUSUhnWkFjQ0l2OUQwRUFBeWNHaVRJSElRVUlpLzBNUVFBREp3YUpnQUdBaVlvQkFTSW5CMlZFaS84U0p3WWlUd0pVaVNJbkNtVkVnUUlMaVlvQkFTSXJaVVNML3c1QkFBTW5Cb21ML3hZcFRGQXFVQ2NMVUwxRUp3WWlUd0pVaVlvQkFTSXJaVVNML3cxRWkvOFdLVXhRS2xBbkRsQkp2VVJFdmtoSkZZRWdFa1NKaWdJQklpdGxSSXYrRFVTTC9oWXBURkFxVUNjRVVFbTlSRVMrU0VraVcwc0JKRnRQQW9FWVc0di9DeUVFQ292L1N3RUpTVThEQzA4RFR3SUlDaFpNRmxDSmlnSUJJaXRsUkl2K0RVU0wvaFlwVEZBcVVDY0VVRW05UkVTK1NFa2lXMHNCSkZ0UEFvRVlXNHYvQ3lFRUNvdi9Td0VKU1U4RUMwOERUd0lJQ2haTUZsQ0ppZ0VCSWl0bFJJdi9EVVNMLzRqN0xVa2lXMGxQQWlSYlNVNENDRWxBQUJXQUVBQUFBQUFBQUFBeUFBQUFBQUFBQURLTUFJbUxBWUZrQzRzQ1NVNENDb3NBZ1dRTFR3SUtUQlpNRmxDTUFJbUtBZ0dML292L2lQMk9pLytJLzZGTEFTSmJUd0lrVzBzQ0lsdFBBeVJiVHdOUEFndUJaQXBPQWd1QlpBcE1Ga3dXVUltS0FRR0wveFlwVEZBcVVFa25DMUJKRlJaWEJnSk1VRXNCSndSUVNSVVdWd1lDVEZCUEFpY09VRWtWRmxjR0FreFFTd0lWZ1FZSVNSWlhCZ0tBQWdBR1RGQkxBeFZQQWdnV1Z3WUNVRThEVUU4Q1VFeFFpWW9DQVNjSWkvNVFKd2xRaS84V1VFa25ERkJKRlJaWEJnSk1VRXduRFZCSkZSWlhCZ0pNVUVzQkZZRUVDQlpYQmdLQUFnQUVURkJQQWxCTVVJbUtBZ0VpZ0FBaUsyVkVpLzRPUVFBZmdCb0FBQU1BRlUxaGNtdGxkQ0JrYjJWeklHNXZkQ0JsZUdsemRJd0FpWXYvSlF4QkFDeUFKd0FBQXdBaVRXbHVhVzExYlNCd1lYbHRaVzUwSUdseklERXdNREFnYldsamNtOUJURWRQYzR3QWlZditGaWxNVUNwUUp3UlFTWXdBdlVSQUFCK0FHZ0FBQXdBVlRXRnlhMlYwSUdSaGRHRWdibTkwSUdadmRXNWtqQUNKaXdDK1NFbUJLRnRNZ1NCYmpBRkJBQ1NBSHdBQUF3QWFUV0Z5YTJWMElHbHpJR0ZzY21WaFpIa2djbVZ6YjJ4MlpXU01BSWt5QjRzQkQwRUFHNEFXQUFBREFCRlVjbUZrYVc1bklHaGhjeUJsYm1SbFpJd0FpWUFLZ0FBREFBVldZV3hwWkl3QWlZb0FBU0tBQUNJclpVUWlKd1ZsUkNKSml3V0xBZ3hCQURDTEJSWXBURkFxVUNjRVVFbU1BTDFFaXdTTUFVRUFESXNBdmtpQkVGdUxCQWlNQVlzQmpBU0xCU01JakFWQy84aUxBaGFMQkJhTEF4Wk9BbEJNVUl3QWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
