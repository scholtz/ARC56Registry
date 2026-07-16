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

namespace Arc56.Generated.Algorand_Developer_Retreat.abel.AssetLabeling_9d1ec9f4
{


    public class AssetLabelingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssetLabelingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AssetFull : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public string Url { get; set; }

                public ulong Total { get; set; }

                public byte Decimals { get; set; }

                public Algorand.Address Creator { get; set; }

                public Algorand.Address Manager { get; set; }

                public Algorand.Address Freeze { get; set; }

                public Algorand.Address Clawback { get; set; }

                public Algorand.Address Reserve { get; set; }

                public bool DefaultFrozen { get; set; }

                public byte[] MetadataHash { get; set; }

                public ulong ReserveBalance { get; set; }

                public string[] Labels { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.From(Url);
                    stringRef[ret.Count] = vUrl.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotal.From(Total);
                    ret.AddRange(vTotal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vManager.From(Manager);
                    ret.AddRange(vManager.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFreeze = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFreeze.From(Freeze);
                    ret.AddRange(vFreeze.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClawback = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vClawback.From(Clawback);
                    ret.AddRange(vClawback.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReserve.From(Reserve);
                    ret.AddRange(vReserve.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultFrozen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vDefaultFrozen.From(DefaultFrozen);
                    ret.AddRange(vDefaultFrozen.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vMetadataHash.From(MetadataHash);
                    ret.AddRange(vMetadataHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReserveBalance.From(ReserveBalance);
                    ret.AddRange(vReserveBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vLabels.From(Labels);
                    ret.AddRange(vLabels.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetFull Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetFull();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    var indexUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.Decode(bytes.Skip(indexUrl + prefixOffset).ToArray());
                    var valueUrl = vUrl.ToValue();
                    if (valueUrl is string vUrlValue) { ret.Url = vUrlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotal = vTotal.ToValue();
                    if (valueTotal is ulong vTotalValue) { ret.Total = vTotalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vManager.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueManager = vManager.ToValue();
                    if (valueManager is Algorand.Address vManagerValue) { ret.Manager = vManagerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFreeze = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFreeze.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFreeze = vFreeze.ToValue();
                    if (valueFreeze is Algorand.Address vFreezeValue) { ret.Freeze = vFreezeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClawback = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vClawback.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClawback = vClawback.ToValue();
                    if (valueClawback is Algorand.Address vClawbackValue) { ret.Clawback = vClawbackValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReserve.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReserve = vReserve.ToValue();
                    if (valueReserve is Algorand.Address vReserveValue) { ret.Reserve = vReserveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultFrozen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vDefaultFrozen.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDefaultFrozen = vDefaultFrozen.ToValue();
                    if (valueDefaultFrozen is bool vDefaultFrozenValue) { ret.DefaultFrozen = vDefaultFrozenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vMetadataHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetadataHash = vMetadataHash.ToValue();
                    if (valueMetadataHash is byte[] vMetadataHashValue) { ret.MetadataHash = vMetadataHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserveBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReserveBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReserveBalance = vReserveBalance.ToValue();
                    if (valueReserveBalance is ulong vReserveBalanceValue) { ret.ReserveBalance = vReserveBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vLabels.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLabels = vLabels.ToValue();
                    if (valueLabels is string[] vLabelsValue) { ret.Labels = vLabelsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetFull);
                }
                public bool Equals(AssetFull? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetFull left, AssetFull right)
                {
                    return EqualityComparer<AssetFull>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetFull left, AssetFull right)
                {
                    return !(left == right);
                }

            }

            public class AssetMicro : AVMObjectType
            {
                public string UnitName { get; set; }

                public byte Decimals { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetMicro Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetMicro();
                    uint count = 0;
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetMicro);
                }
                public bool Equals(AssetMicro? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetMicro left, AssetMicro right)
                {
                    return EqualityComparer<AssetMicro>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetMicro left, AssetMicro right)
                {
                    return !(left == right);
                }

            }

            public class AssetMicroLabels : AVMObjectType
            {
                public string UnitName { get; set; }

                public byte Decimals { get; set; }

                public string[] Labels { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vLabels.From(Labels);
                    ret.AddRange(vLabels.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetMicroLabels Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetMicroLabels();
                    uint count = 0;
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vLabels.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLabels = vLabels.ToValue();
                    if (valueLabels is string[] vLabelsValue) { ret.Labels = vLabelsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetMicroLabels);
                }
                public bool Equals(AssetMicroLabels? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetMicroLabels left, AssetMicroLabels right)
                {
                    return EqualityComparer<AssetMicroLabels>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetMicroLabels left, AssetMicroLabels right)
                {
                    return !(left == right);
                }

            }

            public class AssetSmall : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public byte Decimals { get; set; }

                public ulong Total { get; set; }

                public bool HasFreeze { get; set; }

                public bool HasClawback { get; set; }

                public string[] Labels { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotal.From(Total);
                    ret.AddRange(vTotal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasFreeze = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHasFreeze.From(HasFreeze);
                    ret.AddRange(vHasFreeze.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasClawback = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHasClawback.From(HasClawback);
                    ret.AddRange(vHasClawback.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vLabels.From(Labels);
                    ret.AddRange(vLabels.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetSmall Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetSmall();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotal = vTotal.ToValue();
                    if (valueTotal is ulong vTotalValue) { ret.Total = vTotalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasFreeze = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHasFreeze.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasFreeze = vHasFreeze.ToValue();
                    if (valueHasFreeze is bool vHasFreezeValue) { ret.HasFreeze = vHasFreezeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasClawback = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHasClawback.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasClawback = vHasClawback.ToValue();
                    if (valueHasClawback is bool vHasClawbackValue) { ret.HasClawback = vHasClawbackValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vLabels.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLabels = vLabels.ToValue();
                    if (valueLabels is string[] vLabelsValue) { ret.Labels = vLabelsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetSmall);
                }
                public bool Equals(AssetSmall? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetSmall left, AssetSmall right)
                {
                    return EqualityComparer<AssetSmall>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetSmall left, AssetSmall right)
                {
                    return !(left == right);
                }

            }

            public class AssetText : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public string Url { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.From(Url);
                    stringRef[ret.Count] = vUrl.Encode();
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

                public static AssetText Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetText();
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    var indexUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.Decode(bytes.Skip(indexUrl + prefixOffset).ToArray());
                    var valueUrl = vUrl.ToValue();
                    if (valueUrl is string vUrlValue) { ret.Url = vUrlValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetText);
                }
                public bool Equals(AssetText? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetText left, AssetText right)
                {
                    return EqualityComparer<AssetText>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetText left, AssetText right)
                {
                    return !(left == right);
                }

            }

            public class AssetTextLabels : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public string Url { get; set; }

                public string[] Labels { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.From(Url);
                    stringRef[ret.Count] = vUrl.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vLabels.From(Labels);
                    ret.AddRange(vLabels.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetTextLabels Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetTextLabels();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    var indexUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.Decode(bytes.Skip(indexUrl + prefixOffset).ToArray());
                    var valueUrl = vUrl.ToValue();
                    if (valueUrl is string vUrlValue) { ret.Url = vUrlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vLabels.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLabels = vLabels.ToValue();
                    if (valueLabels is string[] vLabelsValue) { ret.Labels = vLabelsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetTextLabels);
                }
                public bool Equals(AssetTextLabels? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetTextLabels left, AssetTextLabels right)
                {
                    return EqualityComparer<AssetTextLabels>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetTextLabels left, AssetTextLabels right)
                {
                    return !(left == right);
                }

            }

            public class AssetTiny : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public byte Decimals { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetTiny Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetTiny();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetTiny);
                }
                public bool Equals(AssetTiny? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetTiny left, AssetTiny right)
                {
                    return EqualityComparer<AssetTiny>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetTiny left, AssetTiny right)
                {
                    return !(left == right);
                }

            }

            public class AssetTinyLabels : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public byte Decimals { get; set; }

                public string[] Labels { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vLabels.From(Labels);
                    ret.AddRange(vLabels.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AssetTinyLabels Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetTinyLabels();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is byte vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabels = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vLabels.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLabels = vLabels.ToValue();
                    if (valueLabels is string[] vLabelsValue) { ret.Labels = vLabelsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetTinyLabels);
                }
                public bool Equals(AssetTinyLabels? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetTinyLabels left, AssetTinyLabels right)
                {
                    return EqualityComparer<AssetTinyLabels>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetTinyLabels left, AssetTinyLabels right)
                {
                    return !(left == right);
                }

            }

            public class LabelDescriptor : AVMObjectType
            {
                public string Name { get; set; }

                public string Url { get; set; }

                public ulong NumAssets { get; set; }

                public ulong NumOperators { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.From(Url);
                    stringRef[ret.Count] = vUrl.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNumAssets.From(NumAssets);
                    ret.AddRange(vNumAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumOperators = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNumOperators.From(NumOperators);
                    ret.AddRange(vNumOperators.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LabelDescriptor Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LabelDescriptor();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrl.Decode(bytes.Skip(indexUrl + prefixOffset).ToArray());
                    var valueUrl = vUrl.ToValue();
                    if (valueUrl is string vUrlValue) { ret.Url = vUrlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumAssets = vNumAssets.ToValue();
                    if (valueNumAssets is ulong vNumAssetsValue) { ret.NumAssets = vNumAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumOperators = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumOperators.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumOperators = vNumOperators.ToValue();
                    if (valueNumOperators is ulong vNumOperatorsValue) { ret.NumOperators = vNumOperatorsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LabelDescriptor);
                }
                public bool Equals(LabelDescriptor? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LabelDescriptor left, LabelDescriptor right)
                {
                    return EqualityComparer<LabelDescriptor>.Default.Equals(left, right);
                }
                public static bool operator !=(LabelDescriptor left, LabelDescriptor right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task ChangeAdmin(Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_admin });
            byte new_adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 143, 13, 125, 142 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeAdmin_Transactions(Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { new_admin });
            byte new_adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 143, 13, 125, 142 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="name"> </param>
        /// <param name="url"> </param>
        public async Task AddLabel(string id, string name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 162, 226, 247 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddLabel_Transactions(string id, string name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 162, 226, 247 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<ulong> HasLabel(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 43, 183, 143 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasLabel_Transactions(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 43, 183, 143 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="name"> </param>
        /// <param name="url"> </param>
        public async Task ChangeLabel(string id, string name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 108, 222, 100 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeLabel_Transactions(string id, string name, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 108, 222, 100 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, nameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task RemoveLabel(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 230, 145, 174 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveLabel_Transactions(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 230, 145, 174 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<Structs.LabelDescriptor> GetLabel(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 101, 210, 180 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LabelDescriptor.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLabel_Transactions(string id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 101, 210, 180 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ids"> </param>
        public async Task LogLabels(string[] ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 86, 22, 231 };
            var idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); idsAbi.From(ids);

            var result = await base.SimApp(new List<object> { abiHandle, idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogLabels_Transactions(string[] ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 86, 22, 231 };
            var idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); idsAbi.From(ids);

            return await base.MakeTransactionList(new List<object> { abiHandle, idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        /// <param name="label"> </param>
        public async Task AddOperatorToLabel(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 250, 193, 207, 27 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            var result = await base.CallApp(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddOperatorToLabel_Transactions(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 250, 193, 207, 27 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        /// <param name="label"> </param>
        public async Task<ulong> HasOperatorLabel(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 111, 216, 20, 140 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            var result = await base.SimApp(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasOperatorLabel_Transactions(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 111, 216, 20, 140 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        /// <param name="label"> </param>
        public async Task RemoveOperatorFromLabel(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 180, 197, 11, 159 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            var result = await base.CallApp(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveOperatorFromLabel_Transactions(Address @operator, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 180, 197, 11, 159 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorRefIndex, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        public async Task<string[]> GetOperatorLabels(Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 162, 221, 34, 71 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            var result = await base.SimApp(new List<object> { abiHandle, operatorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToStringArray();

        }

        public async Task<List<Transaction>> GetOperatorLabels_Transactions(Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { @operator });
            byte operatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 162, 221, 34, 71 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="label"> </param>
        /// <param name="asset"> </param>
        public async Task AddLabelToAsset(ulong asset, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 163, 125, 234, 17 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, labelAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddLabelToAsset_Transactions(ulong asset, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 163, 125, 234, 17 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, labelAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="label"> </param>
        /// <param name="assets"> </param>
        public async Task AddLabelToAssets(string label, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 90, 178, 30 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, labelAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddLabelToAssets_Transactions(string label, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 90, 178, 30 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, labelAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="label"> </param>
        /// <param name="asset"> </param>
        public async Task RemoveLabelFromAsset(ulong asset, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 104, 241, 142, 250 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, labelAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveLabelFromAsset_Transactions(ulong asset, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 104, 241, 142, 250 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, labelAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="label"> </param>
        public async Task<ulong> HasAssetLabel(ulong asset_id, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 244, 10, 138 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idAbi, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasAssetLabel_Transactions(ulong asset_id, string label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 244, 10, 138 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<string[]> GetAssetLabels(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 194, 237, 116, 63 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToStringArray();

        }

        public async Task<List<Transaction>> GetAssetLabels_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 194, 237, 116, 63 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task<string[][]> GetAssetsLabels(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 127, 3, 194 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetAssetsLabels_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 127, 3, 194 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task LogAssetsLabels(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 163, 33, 35 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogAssetsLabels_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 163, 33, 35 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetMicro> GetAssetMicro(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 238, 12, 97 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetMicro.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetMicro_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 238, 12, 97 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsMicro(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 195, 159, 104 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsMicro_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 195, 159, 104 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetMicroLabels> GetAssetMicroLabels(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 91, 227, 98 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetMicroLabels.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetMicroLabels_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 91, 227, 98 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsMicroLabels(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 147, 177, 13 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsMicroLabels_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 147, 177, 13 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetTiny> GetAssetTiny(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 172, 153, 173 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetTiny.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetTiny_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 172, 153, 173 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsTiny(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 162, 189, 156 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsTiny_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 162, 189, 156 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetTinyLabels> GetAssetTinyLabels(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 198, 82, 142 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetTinyLabels.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetTinyLabels_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 198, 82, 142 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsTinyLabels(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 247, 123, 255 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsTinyLabels_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 247, 123, 255 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetText> GetAssetText(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 217, 242, 76 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetText.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetText_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 217, 242, 76 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsText(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 64, 184, 10 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsText_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 64, 184, 10 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetTextLabels> GetAssetTextLabels(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 16, 229, 196 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetTextLabels.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetTextLabels_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 16, 229, 196 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsTextLabels(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 23, 205, 213 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsTextLabels_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 23, 205, 213 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetSmall> GetAssetSmall(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 76, 228, 185 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetSmall.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetSmall_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 76, 228, 185 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsSmall(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 108, 81, 175 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsSmall_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 108, 81, 175 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task<Structs.AssetFull> GetAssetFull(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 164, 143, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetFull.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetFull_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 164, 143, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task GetAssetsFull(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 186, 152, 219 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GetAssetsFull_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 186, 152, 219 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 2;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXRMYWJlbGluZyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBc3NldEZ1bGwiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InVuaXRfbmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1cmwiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidG90YWwiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGVjaW1hbHMiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJjcmVhdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJtYW5hZ2VyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmcmVlemUiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImNsYXdiYWNrIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZXNlcnZlIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJkZWZhdWx0X2Zyb3plbiIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibWV0YWRhdGFfaGFzaCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJyZXNlcnZlX2JhbGFuY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFiZWxzIiwidHlwZSI6InN0cmluZ1tdIn1dLCJBc3NldE1pY3JvIjpbeyJuYW1lIjoidW5pdF9uYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRlY2ltYWxzIiwidHlwZSI6InVpbnQ4In1dLCJBc3NldE1pY3JvTGFiZWxzIjpbeyJuYW1lIjoidW5pdF9uYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRlY2ltYWxzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGFiZWxzIiwidHlwZSI6InN0cmluZ1tdIn1dLCJBc3NldFNtYWxsIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZGVjaW1hbHMiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJ0b3RhbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJoYXNfZnJlZXplIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJoYXNfY2xhd2JhY2siLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImxhYmVscyIsInR5cGUiOiJzdHJpbmdbXSJ9XSwiQXNzZXRUZXh0IjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidXJsIiwidHlwZSI6InN0cmluZyJ9XSwiQXNzZXRUZXh0TGFiZWxzIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidXJsIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImxhYmVscyIsInR5cGUiOiJzdHJpbmdbXSJ9XSwiQXNzZXRUaW55IjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZGVjaW1hbHMiLCJ0eXBlIjoidWludDgifV0sIkFzc2V0VGlueUxhYmVscyI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidW5pdF9uYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRlY2ltYWxzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGFiZWxzIiwidHlwZSI6InN0cmluZ1tdIn1dLCJMYWJlbERlc2NyaXB0b3IiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InVybCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJudW1fYXNzZXRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im51bV9vcGVyYXRvcnMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNoYW5nZV9hZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc19sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hhbmdlX2xhYmVsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX2xhYmVsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkxhYmVsRGVzY3JpcHRvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nX2xhYmVscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmdbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9vcGVyYXRvcl90b19sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc19vcGVyYXRvcl9sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfb3BlcmF0b3JfZnJvbV9sYWJlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcGVyYXRvcl9sYWJlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZ1tdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9sYWJlbF90b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfbGFiZWxfdG9fYXNzZXRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfbGFiZWxfZnJvbV9hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYWJlbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNfYXNzZXRfbGFiZWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfbGFiZWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0c19sYWJlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2dfYXNzZXRzX2xhYmVscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldF9taWNybyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ4KSIsInN0cnVjdCI6IkFzc2V0TWljcm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldHNfbWljcm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfbWljcm9fbGFiZWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDgsc3RyaW5nW10pIiwic3RydWN0IjoiQXNzZXRNaWNyb0xhYmVscyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0c19taWNyb19sYWJlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfdGlueSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50OCkiLCJzdHJ1Y3QiOiJBc3NldFRpbnkiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldHNfdGlueSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldF90aW55X2xhYmVscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50OCxzdHJpbmdbXSkiLCJzdHJ1Y3QiOiJBc3NldFRpbnlMYWJlbHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldHNfdGlueV9sYWJlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfdGV4dCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiQXNzZXRUZXh0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRzX3RleHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfdGV4dF9sYWJlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZ1tdKSIsInN0cnVjdCI6IkFzc2V0VGV4dExhYmVscyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0c190ZXh0X2xhYmVscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldF9zbWFsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50OCx1aW50NjQsYm9vbCxib29sLHN0cmluZ1tdKSIsInN0cnVjdCI6IkFzc2V0U21hbGwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc3NldHNfc21hbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfZnVsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcsdWludDY0LHVpbnQ4LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sLGJ5dGVbXSx1aW50NjQsc3RyaW5nW10pIiwic3RydWN0IjoiQXNzZXRGdWxsIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRzX2Z1bGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJVcGRhdGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2MjcsMTY0NCwyMTI2LDIxNDUsMjY3Ml0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc2LDM5MSw0MTEsNDI2LDQ0Niw0NjEsNDgxLDQ5Niw1MTYsNTMxLDU1MSw1NjYsNTg2LDYwMSw2MjEsNjM2LDY1Niw2NzEsNjkwLDcxMiw3MzksNzYzLDc4NCw4MDgsODMwLDg1NCw4ODMsOTA3LDkyMiw5NDQsOTYyLDk5MiwxMDE1LDEwNDVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTM4XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBvcHRlZCBpbnRvIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1NiwzMDY0LDMxNTYsMzE2NiwzMjkxLDMyOTksMzMwNywzNDEyLDM0MjIsMzQzMiwzNTc5LDM1ODcsMzU5NSwzNzA5LDM3MTksMzcyOSwzODkwLDM5MDAsMzkxMCwzOTI2LDM5MzQsMzk1MCw0MTIyLDQxNDMsNDE1Myw0MTYzLDQxNzMsNDE4MSw0MjAwLDQyMDgsNDIxNiw0MjI0LDQyMzIsNDIzNyw0MjUwXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3OSwzOTQsNDE0LDQyOSw0NDksNDY0LDQ4NCw0OTksNTE5LDUzNCw1NTQsNTY5LDU4OSw2MDQsNjI0LDYzOSw2NTksNjc0LDY5Myw3MTUsNzQyLDc2Niw3ODcsODExLDgzMyw4NTcsODg2LDkxMCw5MjUsOTQ3LDk2NSw5OTUsMTAxOCwxMDQ4LDEwODEsMTA4OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzY0LDE3NDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNjIsMjQ4NCwyNjUzLDI2NjQsMjc0NSwyODc0LDI5MjEsMzAyMSwzMTkzLDM0NTksMzc1MCwzOTc3LDQyNzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTEzLDE2MjYsMTY0MywxNjc5LDE3MjIsMTk1NCwyMTI1LDI1MDcsMjcwOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGFiZWxzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MTksMTkyOCwyMTg0LDIyMDksMjMxM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3BlcmF0b3JzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNzAsMzE3MiwzMzEzLDM0MzgsMzkxNiw0MTg3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNElEUXlPVFE1TmpjeU9UVWdOREk1TkRrMk56STVOZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0SUNKRlVsSTZUazlGV0VsVFZDSWdNSGd3TURBd0lEQjRNREF3TURBd01EQXdNREF3TURBd01DQWlZV1J0YVc0aUlDSkZVbEk2VEVWT1IxUklJaUFpUlZKU09rVllTVk5VVXlJZ0lrVlNVanBPVDBWTlVGUlpJaUF3ZURBd01ESWdNSGd3TUNBaVJWSlNPbFZPUVZWVVNDSWdNSGd3TURBeElEQjRNREF3TlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR05zWVhOeklFRnpjMlYwVEdGaVpXeHBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXpPUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGhtTUdRM1pEaGxJREI0TXpOaE1tVXlaamNnTUhoaU56SmlZamM0WmlBd2VEazNObU5rWlRZMElEQjRNVGRsTmpreFlXVWdNSGczTmpZMVpESmlOQ0F3ZURjeU5UWXhObVUzSURCNFptRmpNV05tTVdJZ01IZzJabVE0TVRRNFl5QXdlR0kwWXpVd1lqbG1JREI0WVRKa1pESXlORGNnTUhoaE16ZGtaV0V4TVNBd2VERXpOV0ZpTWpGbElEQjROamhtTVRobFptRWdNSGc1TjJZME1HRTRZU0F3ZUdNeVpXUTNORE5tSURCNFlUWTNaakF6WXpJZ01IZzVOMkV6TWpFeU15QXdlR0ZoWldVd1l6WXhJREI0WWpaak16bG1OamdnTUhnMk16VmlaVE0yTWlBd2VEY3dPVE5pTVRCa0lEQjROekJoWXprNVlXUWdNSGhrT1dFeVltUTVZeUF3ZURjMll6WTFNamhsSURCNE5URm1OemRpWm1ZZ01IZ3lNR1E1WmpJMFl5QXdlRFUxTkRCaU9EQmhJREI0TURjeE1HVTFZelFnTUhnMlpqRTNZMlJrTlNBd2VEZGhOR05sTkdJNUlEQjRNelkyWXpVeFlXWWdNSGd6TkdFME9HWmlZeUF3ZURBelltRTVPR1JpSUM4dklHMWxkR2h2WkNBaVkyaGhibWRsWDJGa2JXbHVLR0ZqWTI5MWJuUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlXUmtYMnhoWW1Wc0tITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltaGhjMTlzWVdKbGJDaHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamFHRnVaMlZmYkdGaVpXd29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ0YjNabFgyeGhZbVZzS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmYkdGaVpXd29jM1J5YVc1bktTaHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0pzYjJkZmJHRmlaV3h6S0hOMGNtbHVaMXRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkY5dmNHVnlZWFJ2Y2w5MGIxOXNZV0psYkNoaFkyTnZkVzUwTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm9ZWE5mYjNCbGNtRjBiM0pmYkdGaVpXd29ZV05qYjNWdWRDeHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpXMXZkbVZmYjNCbGNtRjBiM0pmWm5KdmJWOXNZV0psYkNoaFkyTnZkVzUwTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmYjNCbGNtRjBiM0pmYkdGaVpXeHpLR0ZqWTI5MWJuUXBjM1J5YVc1blcxMGlMQ0J0WlhSb2IyUWdJbUZrWkY5c1lXSmxiRjkwYjE5aGMzTmxkQ2h6ZEhKcGJtY3NZWE56WlhRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwY3loemRISnBibWNzZFdsdWREWTBXMTBwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ0YjNabFgyeGhZbVZzWDJaeWIyMWZZWE56WlhRb2MzUnlhVzVuTEdGemMyVjBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltaGhjMTloYzNObGRGOXNZV0psYkNoMWFXNTBOalFzYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDJGemMyVjBYMnhoWW1Wc2N5aGhjM05sZENsemRISnBibWRiWFNJc0lHMWxkR2h2WkNBaVoyVjBYMkZ6YzJWMGMxOXNZV0psYkhNb2RXbHVkRFkwVzEwcGMzUnlhVzVuVzExYlhTSXNJRzFsZEdodlpDQWliRzluWDJGemMyVjBjMTlzWVdKbGJITW9kV2x1ZERZMFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMkZ6YzJWMFgyMXBZM0p2S0hWcGJuUTJOQ2tvYzNSeWFXNW5MSFZwYm5RNEtTSXNJRzFsZEdodlpDQWlaMlYwWDJGemMyVjBjMTl0YVdOeWJ5aDFhVzUwTmpSYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZWE56WlhSZmJXbGpjbTlmYkdGaVpXeHpLSFZwYm5RMk5Da29jM1J5YVc1bkxIVnBiblE0TEhOMGNtbHVaMXRkS1NJc0lHMWxkR2h2WkNBaVoyVjBYMkZ6YzJWMGMxOXRhV055YjE5c1lXSmxiSE1vZFdsdWREWTBXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJGemMyVjBYM1JwYm5rb2RXbHVkRFkwS1NoemRISnBibWNzYzNSeWFXNW5MSFZwYm5RNEtTSXNJRzFsZEdodlpDQWlaMlYwWDJGemMyVjBjMTkwYVc1NUtIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWhjM05sZEY5MGFXNTVYMnhoWW1Wc2N5aDFhVzUwTmpRcEtITjBjbWx1Wnl4emRISnBibWNzZFdsdWREZ3NjM1J5YVc1blcxMHBJaXdnYldWMGFHOWtJQ0puWlhSZllYTnpaWFJ6WDNScGJubGZiR0ZpWld4ektIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWhjM05sZEY5MFpYaDBLSFZwYm5RMk5Da29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwSWl3Z2JXVjBhRzlrSUNKblpYUmZZWE56WlhSelgzUmxlSFFvZFdsdWREWTBXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJGemMyVjBYM1JsZUhSZmJHRmlaV3h6S0hWcGJuUTJOQ2tvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuVzEwcElpd2diV1YwYUc5a0lDSm5aWFJmWVhOelpYUnpYM1JsZUhSZmJHRmlaV3h6S0hWcGJuUTJORnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aGMzTmxkRjl6YldGc2JDaDFhVzUwTmpRcEtITjBjbWx1Wnl4emRISnBibWNzZFdsdWREZ3NkV2x1ZERZMExHSnZiMndzWW05dmJDeHpkSEpwYm1kYlhTa2lMQ0J0WlhSb2IyUWdJbWRsZEY5aGMzTmxkSE5mYzIxaGJHd29kV2x1ZERZMFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMkZ6YzJWMFgyWjFiR3dvZFdsdWREWTBLU2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREZ3NZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKdmIyd3NZbmwwWlZ0ZExIVnBiblEyTkN4emRISnBibWRiWFNraUxDQnRaWFJvYjJRZ0ltZGxkRjloYzNObGRITmZablZzYkNoMWFXNTBOalJiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWphR0Z1WjJWZllXUnRhVzVmY205MWRHVkFOU0J0WVdsdVgyRmtaRjlzWVdKbGJGOXliM1YwWlVBMklHMWhhVzVmYUdGelgyeGhZbVZzWDNKdmRYUmxRRGNnYldGcGJsOWphR0Z1WjJWZmJHRmlaV3hmY205MWRHVkFPQ0J0WVdsdVgzSmxiVzkyWlY5c1lXSmxiRjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBYMnhoWW1Wc1gzSnZkWFJsUURFd0lHMWhhVzVmYkc5blgyeGhZbVZzYzE5eWIzVjBaVUF4TVNCdFlXbHVYMkZrWkY5dmNHVnlZWFJ2Y2w5MGIxOXNZV0psYkY5eWIzVjBaVUF4TWlCdFlXbHVYMmhoYzE5dmNHVnlZWFJ2Y2w5c1lXSmxiRjl5YjNWMFpVQXhNeUJ0WVdsdVgzSmxiVzkyWlY5dmNHVnlZWFJ2Y2w5bWNtOXRYMnhoWW1Wc1gzSnZkWFJsUURFMElHMWhhVzVmWjJWMFgyOXdaWEpoZEc5eVgyeGhZbVZzYzE5eWIzVjBaVUF4TlNCdFlXbHVYMkZrWkY5c1lXSmxiRjkwYjE5aGMzTmxkRjl5YjNWMFpVQXhOaUJ0WVdsdVgyRmtaRjlzWVdKbGJGOTBiMTloYzNObGRITmZjbTkxZEdWQU1UY2diV0ZwYmw5eVpXMXZkbVZmYkdGaVpXeGZabkp2YlY5aGMzTmxkRjl5YjNWMFpVQXhPQ0J0WVdsdVgyaGhjMTloYzNObGRGOXNZV0psYkY5eWIzVjBaVUF4T1NCdFlXbHVYMmRsZEY5aGMzTmxkRjlzWVdKbGJITmZjbTkxZEdWQU1qQWdiV0ZwYmw5blpYUmZZWE56WlhSelgyeGhZbVZzYzE5eWIzVjBaVUF5TVNCdFlXbHVYMnh2WjE5aGMzTmxkSE5mYkdGaVpXeHpYM0p2ZFhSbFFESXlJRzFoYVc1ZloyVjBYMkZ6YzJWMFgyMXBZM0p2WDNKdmRYUmxRREl6SUcxaGFXNWZaMlYwWDJGemMyVjBjMTl0YVdOeWIxOXliM1YwWlVBeU5DQnRZV2x1WDJkbGRGOWhjM05sZEY5dGFXTnliMTlzWVdKbGJITmZjbTkxZEdWQU1qVWdiV0ZwYmw5blpYUmZZWE56WlhSelgyMXBZM0p2WDJ4aFltVnNjMTl5YjNWMFpVQXlOaUJ0WVdsdVgyZGxkRjloYzNObGRGOTBhVzU1WDNKdmRYUmxRREkzSUcxaGFXNWZaMlYwWDJGemMyVjBjMTkwYVc1NVgzSnZkWFJsUURJNElHMWhhVzVmWjJWMFgyRnpjMlYwWDNScGJubGZiR0ZpWld4elgzSnZkWFJsUURJNUlHMWhhVzVmWjJWMFgyRnpjMlYwYzE5MGFXNTVYMnhoWW1Wc2MxOXliM1YwWlVBek1DQnRZV2x1WDJkbGRGOWhjM05sZEY5MFpYaDBYM0p2ZFhSbFFETXhJRzFoYVc1ZloyVjBYMkZ6YzJWMGMxOTBaWGgwWDNKdmRYUmxRRE15SUcxaGFXNWZaMlYwWDJGemMyVjBYM1JsZUhSZmJHRmlaV3h6WDNKdmRYUmxRRE16SUcxaGFXNWZaMlYwWDJGemMyVjBjMTkwWlhoMFgyeGhZbVZzYzE5eWIzVjBaVUF6TkNCdFlXbHVYMmRsZEY5aGMzTmxkRjl6YldGc2JGOXliM1YwWlVBek5TQnRZV2x1WDJkbGRGOWhjM05sZEhOZmMyMWhiR3hmY205MWRHVkFNellnYldGcGJsOW5aWFJmWVhOelpYUmZablZzYkY5eWIzVjBaVUF6TnlCdFlXbHVYMmRsZEY5aGMzTmxkSE5mWm5Wc2JGOXliM1YwWlVBek9Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjloYzNObGRITmZablZzYkY5eWIzVjBaVUF6T0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8xTlRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmpiR0Z6Y3lCQmMzTmxkRXhoWW1Wc2FXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYzNObGRITmZablZzYkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZllYTnpaWFJmWm5Wc2JGOXliM1YwWlVBek56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UVTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5aGMzTmxkRjltZFd4c0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWhjM05sZEhOZmMyMWhiR3hmY205MWRHVkFNelk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1kyeGhjM01nUVhOelpYUk1ZV0psYkdsdVp5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV4T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZZWE56WlhSelgzTnRZV3hzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5aGMzTmxkRjl6YldGc2JGOXliM1YwWlVBek5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5URTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5aGMzTmxkRjl6YldGc2JBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZZWE56WlhSelgzUmxlSFJmYkdGaVpXeHpYM0p2ZFhSbFFETTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTVNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdOc1lYTnpJRUZ6YzJWMFRHRmlaV3hwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBPVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRnpjMlYwYzE5MFpYaDBYMnhoWW1Wc2N3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZZWE56WlhSZmRHVjRkRjlzWVdKbGJITmZjbTkxZEdWQU16TTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EZzVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnWTJ4aGMzTWdRWE56WlhSTVlXSmxiR2x1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTRPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSZllYTnpaWFJmZEdWNGRGOXNZV0psYkhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyRnpjMlYwYzE5MFpYaDBYM0p2ZFhSbFFETXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTNNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdOc1lYTnpJRUZ6YzJWMFRHRmlaV3hwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRnpjMlYwYzE5MFpYaDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjloYzNObGRGOTBaWGgwWDNKdmRYUmxRRE14T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEyTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHTnNZWE56SUVGemMyVjBUR0ZpWld4cGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTmpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMkZ6YzJWMFgzUmxlSFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJGemMyVjBjMTkwYVc1NVgyeGhZbVZzYzE5eWIzVjBaVUF6TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTkRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmpiR0Z6Y3lCQmMzTmxkRXhoWW1Wc2FXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYzNObGRITmZkR2x1ZVY5c1lXSmxiSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6WDNKdmRYUmxRREk1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHTnNZWE56SUVGemMyVjBUR0ZpWld4cGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTkRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMkZ6YzJWMFgzUnBibmxmYkdGaVpXeHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjloYzNObGRITmZkR2x1ZVY5eWIzVjBaVUF5T0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmpiR0Z6Y3lCQmMzTmxkRXhoWW1Wc2FXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRJMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYzNObGRITmZkR2x1ZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZllYTnpaWFJmZEdsdWVWOXliM1YwWlVBeU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ESXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5aGMzTmxkRjkwYVc1NUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWhjM05sZEhOZmJXbGpjbTlmYkdGaVpXeHpYM0p2ZFhSbFFESTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXdNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdOc1lYTnpJRUZ6YzJWMFRHRmlaV3hwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNRE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRnpjMlYwYzE5dGFXTnliMTlzWVdKbGJITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkZ6YzJWMFgyMXBZM0p2WDJ4aFltVnNjMTl5YjNWMFpVQXlOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pPVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCamJHRnpjeUJCYzNObGRFeGhZbVZzYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNems1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGOWhjM05sZEY5dGFXTnliMTlzWVdKbGJITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkZ6YzJWMGMxOXRhV055YjE5eWIzVjBaVUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96T0RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmpiR0Z6Y3lCQmMzTmxkRXhoWW1Wc2FXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpneENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYzNObGRITmZiV2xqY204S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyRnpjMlYwWDIxcFkzSnZYM0p2ZFhSbFFESXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTNOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdOc1lYTnpJRUZ6YzJWMFRHRmlaV3hwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRnpjMlYwWDIxcFkzSnZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyeHZaMTloYzNObGRITmZiR0ZpWld4elgzSnZkWFJsUURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNMU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR05zWVhOeklFRnpjMlYwVEdGaVpXeHBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek5USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdiRzluWDJGemMyVjBjMTlzWVdKbGJITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMkZ6YzJWMGMxOXNZV0psYkhOZmNtOTFkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpNNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZMnhoYzNNZ1FYTnpaWFJNWVdKbGJHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWVhOelpYUnpYMnhoWW1Wc2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZZWE56WlhSZmJHRmlaV3h6WDNKdmRYUmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPak16TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHTnNZWE56SUVGemMyVjBUR0ZpWld4cGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPak16TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZZWE56WlhSZmJHRmlaV3h6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhoYzE5aGMzTmxkRjlzWVdKbGJGOXliM1YwWlVBeE9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek1qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNeU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm9ZWE5mWVhOelpYUmZiR0ZpWld3S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WdGIzWmxYMnhoWW1Wc1gyWnliMjFmWVhOelpYUmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qa3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmpiR0Z6Y3lCQmMzTmxkRXhoWW1Wc2FXNW5LRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNamt3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdjbVZ0YjNabFgyeGhZbVZzWDJaeWIyMWZZWE56WlhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwYzE5eWIzVjBaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95T0RJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUdOc1lYTnpJRUZ6YzJWMFRHRmlaV3hwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZ3lDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtYMnhoWW1Wc1gzUnZYMkZ6YzJWMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpHUmZiR0ZpWld4ZmRHOWZZWE56WlhSZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpjM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCamJHRnpjeUJCYzNObGRFeGhZbVZzYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhOelpYUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qYzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtYMnhoWW1Wc1gzUnZYMkZ6YzJWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXZjR1Z5WVhSdmNsOXNZV0psYkhOZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZMnhoYzNNZ1FYTnpaWFJNWVdKbGJHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDI5d1pYSmhkRzl5WDJ4aFltVnNjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaVzF2ZG1WZmIzQmxjbUYwYjNKZlpuSnZiVjlzWVdKbGJGOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHTnNZWE56SUVGemMyVjBUR0ZpWld4cGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsYlc5MlpWOXZjR1Z5WVhSdmNsOW1jbTl0WDJ4aFltVnNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyaGhjMTl2Y0dWeVlYUnZjbDlzWVdKbGJGOXliM1YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QkJjM05sZEV4aFltVnNhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdhR0Z6WDI5d1pYSmhkRzl5WDJ4aFltVnNDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRmtaRjl2Y0dWeVlYUnZjbDkwYjE5c1lXSmxiRjl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR05zWVhOeklFRnpjMlYwVEdGaVpXeHBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdGa1pGOXZjR1Z5WVhSdmNsOTBiMTlzWVdKbGJBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5c2IyZGZiR0ZpWld4elgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR05zWVhOeklFRnpjMlYwVEdGaVpXeHBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdiRzluWDJ4aFltVnNjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYkdGaVpXeGZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnWTJ4aGMzTWdRWE56WlhSTVlXSmxiR2x1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJ4aFltVnNDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxiVzkyWlY5c1lXSmxiRjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXhOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZMnhoYzNNZ1FYTnpaWFJNWVdKbGJHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ5WlcxdmRtVmZiR0ZpWld3S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJoaGJtZGxYMnhoWW1Wc1gzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCamJHRnpjeUJCYzNObGRFeGhZbVZzYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTJoaGJtZGxYMnhoWW1Wc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJoaGMxOXNZV0psYkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHTnNZWE56SUVGemMyVjBUR0ZpWld4cGJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEF3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdoaGMxOXNZV0psYkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWkdSZmJHRmlaV3hmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZMnhoYzNNZ1FYTnpaWFJNWVdKbGJHbHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtYMnhoWW1Wc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOb1lXNW5aVjloWkcxcGJsOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCamJHRnpjeUJCYzNObGRFeGhZbVZzYVc1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZMmhoYm1kbFgyRmtiV2x1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBek9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1kyeGhjM01nUVhOelpYUk1ZV0psYkdsdVp5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYzNkcGRHTm9JRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTkRJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEUXpJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEwTXlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5ETWdiV0ZwYmw5MWNHUmhkR1ZBTkRBZ2JXRnBibDlrWld4bGRHVkFOREVLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFF6Q2dwdFlXbHVYMlJsYkdWMFpVQTBNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFNnaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aUxDa3BDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaR1ZzWlhSbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVUEwTURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBTZ2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlMQ2twQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURReU9nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtLR0Z5Y21GNU9pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgySjVkR1Z6T2lCaWVYUmxjeXdnYm1WM1gybDBaVzF6WDJOdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWVYUmxYMnhsYm1kMGFGOW9aV0ZrT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1lucGxjbThLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1JmWm05eVgyaGxZV1JsY2tBeUNncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MEtHRnljbUY1WDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHRnljbUY1WDJobFlXUmZZVzVrWDNSaGFXdzZJR0o1ZEdWekxDQnVaWGRmYVhSbGJYTmZZMjkxYm5RNklIVnBiblEyTkN3Z2JtVjNYMmhsWVdSZllXNWtYM1JoYVd3NklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1ME9nb2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURFS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTlFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExtSXljM1J5S0dJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1lqSnpkSEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEl0TlRNS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdZakp6ZEhJb1lqb2dRbmwwWlhNcElDMCtJR0Z5WXpRdVUzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jdVpuSnZiVjlpZVhSbGN5aGlLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxuVndaR0YwWlNncElDMCtJSFp2YVdRNkNuVndaR0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmw5dmJteDVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lXUnRhVzVmYjI1c2VRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdVpHVnNaWFJsS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1WDI5dWJIa29LUW9nSUNBZ1kyRnNiSE4xWWlCaFpHMXBibDl2Ym14NUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1aFpHMXBibDl2Ym14NUtDa2dMVDRnZG05cFpEb0tZV1J0YVc1ZmIyNXNlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdaVzV6ZFhKbEtGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z1V5Z2lSVkpTT2xWT1FWVlVTQ0lwS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z2FXWWdibTkwSUdOdmJtUTZDaUFnSUNCaWJub2dZV1J0YVc1ZmIyNXNlVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1pXNXpkWEpsS0ZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnVXlnaVJWSlNPbFZPUVZWVVNDSXBLUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJa1ZTVWpwVlRrRlZWRWdpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR3h2WnlodGMyY3BDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzQXVaWEp5S0NrS0lDQWdJR1Z5Y2dvS1lXUnRhVzVmYjI1c2VWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1amFHRnVaMlZmWVdSdGFXNG9ibVYzWDJGa2JXbHVPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZMmhoYm1kbFgyRmtiV2x1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPamd6TFRnMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJqYUdGdVoyVmZZV1J0YVc0b2MyVnNaaXdnYm1WM1gyRmtiV2x1T2lCQlkyTnZkVzUwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNWZiMjVzZVNncENpQWdJQ0JqWVd4c2MzVmlJR0ZrYldsdVgyOXViSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaUE5SUc1bGQxOWhaRzFwYmdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdSdGFXNGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NWhaR1JmYkdGaVpXd29hV1E2SUdKNWRHVnpMQ0J1WVcxbE9pQmllWFJsY3l3Z2RYSnNPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZV1JrWDJ4aFltVnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qZzRMVGc1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmhaR1JmYkdGaVpXd29jMlZzWml3Z2FXUTZJRk4wY21sdVp5d2dibUZ0WlRvZ1UzUnlhVzVuTENCMWNtdzZJRk4wY21sdVp5a2dMVDRnVG05dVpUb2dJQ01nYm05eFlTQkJNREF5Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJsOXZibXg1S0NrS0lDQWdJR05oYkd4emRXSWdZV1J0YVc1ZmIyNXNlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5Qmxibk4xY21Vb2FXUWdibTkwSUdsdUlITmxiR1l1YkdGaVpXeHpMQ0JUS0NKRlVsSTZSVmhKVTFSVElpa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJwWmlCdWIzUWdZMjl1WkRvS0lDQWdJR0o2SUdGa1pGOXNZV0psYkY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdaVzV6ZFhKbEtHbGtJRzV2ZENCcGJpQnpaV3htTG14aFltVnNjeXdnVXlnaVJWSlNPa1ZZU1ZOVVV5SXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlSVkpTT2tWWVNWTlVVeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdiRzluS0cxelp5a0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCdmNDNWxjbklvS1FvZ0lDQWdaWEp5Q2dwaFpHUmZiR0ZpWld4ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJsYm5OMWNtVW9hV1F1WW5sMFpYTXViR1Z1WjNSb0lEMDlJRElzSUZNb0lrVlNVanBNUlU1SFZFZ2lLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYVdZZ2JtOTBJR052Ym1RNkNpQWdJQ0JpYm5vZ1lXUmtYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJsYm5OMWNtVW9hV1F1WW5sMFpYTXViR1Z1WjNSb0lEMDlJRElzSUZNb0lrVlNVanBNUlU1SFZFZ2lLU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJa1ZTVWpwTVJVNUhWRWdpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR3h2WnlodGMyY3BDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzQXVaWEp5S0NrS0lDQWdJR1Z5Y2dvS1lXUmtYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWVhKak5DNVRkSEpwYm1jb2JtRnRaU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklHRnlZelF1VTNSeWFXNW5LSFZ5YkNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZPVE10T1RnS0lDQWdJQzh2SUhObGJHWXViR0ZpWld4elcybGtYU0E5SUV4aFltVnNSR1Z6WTNKcGNIUnZjaWdLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbE4wY21sdVp5aHVZVzFsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWgxY213cExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5TUNBdkx5QXlNQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZPVE10T1RnS0lDQWdJQzh2SUhObGJHWXViR0ZpWld4elcybGtYU0E5SUV4aFltVnNSR1Z6WTNKcGNIUnZjaWdLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbE4wY21sdVp5aHVZVzFsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWgxY213cExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNeTA1T0FvZ0lDQWdMeThnYzJWc1ppNXNZV0psYkhOYmFXUmRJRDBnVEdGaVpXeEVaWE5qY21sd2RHOXlLQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktHNWhiV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VTNSeWFXNW5LSFZ5YkNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhjM05sZEY5c1lXSmxiR2x1Wnk1amIyNTBjbUZqZEM1QmMzTmxkRXhoWW1Wc2FXNW5MbWhoYzE5c1lXSmxiQ2hwWkRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FHRnpYMnhoWW1Wc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd01DMHhNREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJvWVhOZmJHRmlaV3dvYzJWc1ppd2dhV1E2SUZOMGNtbHVaeWtnTFQ0Z1ZVbHVkRFkwT2lBZ0l5QnViM0ZoSUVFd01ESUtJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnWlc1emRYSmxLR2xrTG1KNWRHVnpMbXhsYm1kMGFDQTlQU0F5TENCVEtDSkZVbEk2VEVWT1IxUklJaWtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUdsbUlHNXZkQ0JqYjI1a09nb2dJQ0FnWW01NklHaGhjMTlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TURJS0lDQWdJQzh2SUdWdWMzVnlaU2hwWkM1aWVYUmxjeTVzWlc1bmRHZ2dQVDBnTWl3Z1V5Z2lSVkpTT2t4RlRrZFVTQ0lwS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUlZKU09reEZUa2RVU0NJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYkc5bktHMXpaeWtLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnZjQzVsY25Jb0tRb2dJQ0FnWlhKeUNncG9ZWE5mYkdGaVpXeGZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2hwWkNCcGJpQnpaV3htTG14aFltVnNjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1amFHRnVaMlZmYkdGaVpXd29hV1E2SUdKNWRHVnpMQ0J1WVcxbE9pQmllWFJsY3l3Z2RYSnNPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZMmhoYm1kbFgyeGhZbVZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3TlMweE1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdOb1lXNW5aVjlzWVdKbGJDaHpaV3htTENCcFpEb2dVM1J5YVc1bkxDQnVZVzFsT2lCVGRISnBibWNzSUhWeWJEb2dVM1J5YVc1bktTQXRQaUJPYjI1bE9pQWdJeUJ1YjNGaElFRXdNRElLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJsOXZibXg1S0NrS0lDQWdJR05oYkd4emRXSWdZV1J0YVc1ZmIyNXNlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdaVzV6ZFhKbEtHbGtJR2x1SUhObGJHWXViR0ZpWld4ekxDQlRLQ0pGVWxJNlRrOUZXRWxUVkNJcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdhV1lnYm05MElHTnZibVE2Q2lBZ0lDQmlibm9nWTJoaGJtZGxYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3T0FvZ0lDQWdMeThnWlc1emRYSmxLR2xrSUdsdUlITmxiR1l1YkdGaVpXeHpMQ0JUS0NKRlVsSTZUazlGV0VsVFZDSXBLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlSVkpTT2s1UFJWaEpVMVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR3h2WnlodGMyY3BDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzQXVaWEp5S0NrS0lDQWdJR1Z5Y2dvS1kyaGhibWRsWDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklHeGhZbVZzWDJSbGMyTnlhWEIwYjNJZ1BTQnpaV3htTG14aFltVnNjMXRwWkYwdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14aFltVnNjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym1GdFpTQTlJR0Z5WXpRdVUzUnlhVzVuS0c1aGJXVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRFS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1ZFhKc0lEMGdZWEpqTkM1VGRISnBibWNvZFhKc0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QnpaV3htTG14aFltVnNjMXRwWkYwZ1BTQnNZV0psYkY5a1pYTmpjbWx3ZEc5eUxtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdWNtVnRiM1psWDJ4aFltVnNLR2xrT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LY21WdGIzWmxYMnhoWW1Wc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE5DMHhNVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxiVzkyWlY5c1lXSmxiQ2h6Wld4bUxDQnBaRG9nVTNSeWFXNW5LU0F0UGlCT2IyNWxPaUFnSXlCdWIzRmhJRUV3TURJS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBibDl2Ym14NUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVdSdGFXNWZiMjVzZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnWlc1emRYSmxLR2xrSUdsdUlITmxiR1l1YkdGaVpXeHpMQ0JUS0NKRlVsSTZUazlGV0VsVFZDSXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYVdZZ2JtOTBJR052Ym1RNkNpQWdJQ0JpYm5vZ2NtVnRiM1psWDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z1pXNXpkWEpsS0dsa0lHbHVJSE5sYkdZdWJHRmlaV3h6TENCVEtDSkZVbEk2VGs5RldFbFRWQ0lwS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpUlZKU09rNVBSVmhKVTFRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUd4dlp5aHRjMmNwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdiM0F1WlhKeUtDa0tJQ0FnSUdWeWNnb0tjbVZ0YjNabFgyeGhZbVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJR1Z1YzNWeVpTaHpaV3htTG14aFltVnNjMXRwWkYwdWJuVnRYMjl3WlhKaGRHOXljeUE5UFNBd0xDQlRLQ0pGVWxJNlRrOUZUVkJVV1NJcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNZV0psYkhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCbGVIUnlZV04wSURFeUlEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZajA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJR2xtSUc1dmRDQmpiMjVrT2dvZ0lDQWdZbTU2SUhKbGJXOTJaVjlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUdWdWMzVnlaU2h6Wld4bUxteGhZbVZzYzF0cFpGMHViblZ0WDI5d1pYSmhkRzl5Y3lBOVBTQXdMQ0JUS0NKRlVsSTZUazlGVFZCVVdTSXBLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlSVkpTT2s1UFJVMVFWRmtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR3h2WnlodGMyY3BDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzQXVaWEp5S0NrS0lDQWdJR1Z5Y2dvS2NtVnRiM1psWDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHVnVjM1Z5WlNoelpXeG1MbXhoWW1Wc2MxdHBaRjB1Ym5WdFgyRnpjMlYwY3lBOVBTQXdMQ0JUS0NKRlVsSTZUazlGVFZCVVdTSXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzWVdKbGJITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQmxlSFJ5WVdOMElEUWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYVdZZ2JtOTBJR052Ym1RNkNpQWdJQ0JpYm5vZ2NtVnRiM1psWDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHVnVjM1Z5WlNoelpXeG1MbXhoWW1Wc2MxdHBaRjB1Ym5WdFgyRnpjMlYwY3lBOVBTQXdMQ0JUS0NKRlVsSTZUazlGVFZCVVdTSXBLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlSVkpTT2s1UFJVMVFWRmtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR3h2WnlodGMyY3BDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z2IzQXVaWEp5S0NrS0lDQWdJR1Z5Y2dvS2NtVnRiM1psWDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXNZV0psYkhOYmFXUmRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnpjMlYwWDJ4aFltVnNhVzVuTG1OdmJuUnlZV04wTGtGemMyVjBUR0ZpWld4cGJtY3VaMlYwWDJ4aFltVnNLR2xrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGOXNZV0psYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TWpJdE1USXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJ4aFltVnNLSE5sYkdZc0lHbGtPaUJUZEhKcGJtY3BJQzArSUV4aFltVnNSR1Z6WTNKcGNIUnZjam9nSUNNZ2JtOXhZU0JCTURBeUNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNalFLSUNBZ0lDOHZJR1Z1YzNWeVpTaHBaQ0JwYmlCelpXeG1MbXhoWW1Wc2N5d2dVeWdpUlZKU09rNVBSVmhKVTFRaUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJR2xtSUc1dmRDQmpiMjVrT2dvZ0lDQWdZbTU2SUdkbGRGOXNZV0psYkY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNalFLSUNBZ0lDOHZJR1Z1YzNWeVpTaHBaQ0JwYmlCelpXeG1MbXhoWW1Wc2N5d2dVeWdpUlZKU09rNVBSVmhKVTFRaUtTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lrVlNVanBPVDBWWVNWTlVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnNiMmNvYlhObktRb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUc5d0xtVnljaWdwQ2lBZ0lDQmxjbklLQ21kbGRGOXNZV0psYkY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1c1lXSmxiSE5iYVdSZENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteGhZbVZzY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxteHZaMTlzWVdKbGJITW9hV1J6T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LYkc5blgyeGhZbVZzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TWpjdE1USTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdiRzluWDJ4aFltVnNjeWh6Wld4bUxDQnBaSE02SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVVM1J5YVc1blhTa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnWm05eUlGOXBaSGdzSUd4aFltVnNYMmxrSUdsdUlIVmxiblZ0WlhKaGRHVW9hV1J6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LYkc5blgyeGhZbVZzYzE5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5Qm1iM0lnWDJsa2VDd2diR0ZpWld4ZmFXUWdhVzRnZFdWdWRXMWxjbUYwWlNocFpITXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJzYjJkZmJHRmlaV3h6WDJGbWRHVnlYMlp2Y2tBMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2RYQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5QnNiMmNvYzJWc1ppNXNZV0psYkhOYmJHRmlaV3hmYVdRdWJtRjBhWFpsWFNrS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c1lXSmxiSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ2JHOW5YMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREVLQ214dloxOXNZV0psYkhOZllXWjBaWEpmWm05eVFEUTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NWhaRzFwYmw5dmNsOXZjR1Z5WVhSdmNsOXZibXg1S0d4aFltVnNPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZV1J0YVc1ZmIzSmZiM0JsY21GMGIzSmZiMjVzZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TXpZdE1UTTNDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUdGa2JXbHVYMjl5WDI5d1pYSmhkRzl5WDI5dWJIa29jMlZzWml3Z2JHRmlaV3c2SUZOMGNtbHVaeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFek9Bb2dJQ0FnTHk4Z2FXWWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdU9nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSjZJR0ZrYldsdVgyOXlYMjl3WlhKaGRHOXlYMjl1YkhsZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJ5WlhSMWNtNEtJQ0FnSUhKbGRITjFZZ29LWVdSdGFXNWZiM0pmYjNCbGNtRjBiM0pmYjI1c2VWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCelpXeG1MbTl3WlhKaGRHOXlYMjl1Ykhrb2JHRmlaV3dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ2IzQmxjbUYwYjNKZmIyNXNlUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnpjMlYwWDJ4aFltVnNhVzVuTG1OdmJuUnlZV04wTGtGemMyVjBUR0ZpWld4cGJtY3ViM0JsY21GMGIzSmZiMjVzZVNoc1lXSmxiRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbTl3WlhKaGRHOXlYMjl1YkhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRReUxURTBNd29nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCdmNHVnlZWFJ2Y2w5dmJteDVLSE5sYkdZc0lHeGhZbVZzT2lCVGRISnBibWNwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5EUUtJQ0FnSUM4dklHOXdaWEpoZEc5eVgybHVaR1Y0SUQwZ2MyVnNaaTVuWlhSZmIzQmxjbUYwYjNKZmJHRmlaV3hmYVc1a1pYZ29WSGh1TG5ObGJtUmxjaXdnYkdGaVpXd3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdaMlYwWDI5d1pYSmhkRzl5WDJ4aFltVnNYMmx1WkdWNENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TkRZS0lDQWdJQzh2SUc5d1pYSmhkRzl5WDJsdVpHVjRJQ0U5SUZWSmJuUTJOQ2hPVDFSZlJrOVZUa1JmUzBWWktRb2dJQ0FnYVc1MFl5QTFJQzh2SURReU9UUTVOamN5T1RZS0lDQWdJQ0U5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFEyTFRFME53b2dJQ0FnTHk4Z2IzQmxjbUYwYjNKZmFXNWtaWGdnSVQwZ1ZVbHVkRFkwS0U1UFZGOUdUMVZPUkY5TFJWa3BDaUFnSUNBdkx5QmhibVFnYjNCbGNtRjBiM0pmYVc1a1pYZ2dJVDBnVlVsdWREWTBLRTVQVkY5R1QxVk9SRjlXUVV4VlJTa3NDaUFnSUNCaWVpQnZjR1Z5WVhSdmNsOXZibXg1WDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFME53b2dJQ0FnTHk4Z1lXNWtJRzl3WlhKaGRHOXlYMmx1WkdWNElDRTlJRlZKYm5RMk5DaE9UMVJmUms5VlRrUmZWa0ZNVlVVcExBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQWhQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTBOaTB4TkRjS0lDQWdJQzh2SUc5d1pYSmhkRzl5WDJsdVpHVjRJQ0U5SUZWSmJuUTJOQ2hPVDFSZlJrOVZUa1JmUzBWWktRb2dJQ0FnTHk4Z1lXNWtJRzl3WlhKaGRHOXlYMmx1WkdWNElDRTlJRlZKYm5RMk5DaE9UMVJmUms5VlRrUmZWa0ZNVlVVcExBb2dJQ0FnWW5vZ2IzQmxjbUYwYjNKZmIyNXNlVjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwdmNHVnlZWFJ2Y2w5dmJteDVYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYVdZZ2JtOTBJR052Ym1RNkNpQWdJQ0JpYm5vZ2IzQmxjbUYwYjNKZmIyNXNlVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5EZ0tJQ0FnSUM4dklGTW9Ja1ZTVWpwVlRrRlZWRWdpS1N3S0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKRlVsSTZWVTVCVlZSSUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCc2IyY29iWE5uS1FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRzl3TG1WeWNpZ3BDaUFnSUNCbGNuSUtDbTl3WlhKaGRHOXlYMjl1YkhsZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdjbVYwYzNWaUNncHZjR1Z5WVhSdmNsOXZibXg1WDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUc5d1pYSmhkRzl5WDI5dWJIbGZZbTl2YkY5dFpYSm5aVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnpjMlYwWDJ4aFltVnNhVzVuTG1OdmJuUnlZV04wTGtGemMyVjBUR0ZpWld4cGJtY3VaMlYwWDI5d1pYSmhkRzl5WDJ4aFltVnNYMmx1WkdWNEtHOXdaWEpoZEc5eU9pQmllWFJsY3l3Z2JHRmlaV3c2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGOXZjR1Z5WVhSdmNsOXNZV0psYkY5cGJtUmxlRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVEV0TVRVeUNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5dmNHVnlZWFJ2Y2w5c1lXSmxiRjlwYm1SbGVDaHpaV3htTENCdmNHVnlZWFJ2Y2pvZ1FXTmpiM1Z1ZEN3Z2JHRmlaV3c2SUZOMGNtbHVaeWtnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaUlnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCcFppQnZjR1Z5WVhSdmNpQnViM1FnYVc0Z2MyVnNaaTV2Y0dWeVlYUnZjbk02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHZGxkRjl2Y0dWeVlYUnZjbDlzWVdKbGJGOXBibVJsZUY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb1RrOVVYMFpQVlU1RVgwdEZXU2tLSUNBZ0lHbHVkR01nTlNBdkx5QTBNamswT1RZM01qazJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgyOXdaWEpoZEc5eVgyeGhZbVZzWDJsdVpHVjRYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklHWnZjaUJwWkhnc0lITjBiM0psWkY5c1lXSmxiQ0JwYmlCMVpXNTFiV1Z5WVhSbEtITmxiR1l1YjNCbGNtRjBiM0p6VzI5d1pYSmhkRzl5WFNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZjR1Z5WVhSdmNuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0taMlYwWDI5d1pYSmhkRzl5WDJ4aFltVnNYMmx1WkdWNFgyWnZjbDlvWldGa1pYSkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVFVLSUNBZ0lDOHZJR1p2Y2lCcFpIZ3NJSE4wYjNKbFpGOXNZV0psYkNCcGJpQjFaVzUxYldWeVlYUmxLSE5sYkdZdWIzQmxjbUYwYjNKelcyOXdaWEpoZEc5eVhTazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5dmNHVnlZWFJ2Y2w5c1lXSmxiRjlwYm1SbGVGOWhablJsY2w5bWIzSkFPQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTFOZ29nSUNBZ0x5OGdhV1lnYzNSdmNtVmtYMnhoWW1Wc0lEMDlJR3hoWW1Wc09nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR2RsZEY5dmNHVnlZWFJ2Y2w5c1lXSmxiRjlwYm1SbGVGOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUhKbGRIVnliaUJwWkhnS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMjl3WlhKaGRHOXlYMnhoWW1Wc1gybHVaR1Y0WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmlJR2RsZEY5dmNHVnlZWFJ2Y2w5c1lXSmxiRjlwYm1SbGVGOW1iM0pmYUdWaFpHVnlRRE1LQ21kbGRGOXZjR1Z5WVhSdmNsOXNZV0psYkY5cGJtUmxlRjloWm5SbGNsOW1iM0pBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG94TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9UazlVWDBaUFZVNUVYMVpCVEZWRktRb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WVdSa1gyOXdaWEpoZEc5eVgzUnZYMnhoWW1Wc0tHOXdaWEpoZEc5eU9pQmllWFJsY3l3Z2JHRmlaV3c2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoWkdSZmIzQmxjbUYwYjNKZmRHOWZiR0ZpWld3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZd0xURTJNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1lXUmtYMjl3WlhKaGRHOXlYM1J2WDJ4aFltVnNLSE5sYkdZc0lHOXdaWEpoZEc5eU9pQkJZMk52ZFc1MExDQnNZV0psYkRvZ1UzUnlhVzVuS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVYMjl5WDI5d1pYSmhkRzl5WDI5dWJIa29iR0ZpWld3cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdZV1J0YVc1ZmIzSmZiM0JsY21GMGIzSmZiMjVzZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyTXdvZ0lDQWdMeThnWlc1emRYSmxLR3hoWW1Wc0lHbHVJSE5sYkdZdWJHRmlaV3h6TENCVEtDSkZVbEk2VGs5RldFbFRWQ0lwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z2FXWWdibTkwSUdOdmJtUTZDaUFnSUNCaWJub2dZV1JrWDI5d1pYSmhkRzl5WDNSdlgyeGhZbVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJR1Z1YzNWeVpTaHNZV0psYkNCcGJpQnpaV3htTG14aFltVnNjeXdnVXlnaVJWSlNPazVQUlZoSlUxUWlLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJa1ZTVWpwT1QwVllTVk5VSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJzYjJjb2JYTm5LUW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklHOXdMbVZ5Y2lncENpQWdJQ0JsY25JS0NtRmtaRjl2Y0dWeVlYUnZjbDkwYjE5c1lXSmxiRjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJOQzB4TmpVS0lDQWdJQzh2SUNNZ1kyaGxZMnNnYVdZZ2IzQmxjbUYwYjNJZ1pYaHBjM1J6SUdGc2NtVmhaSGtLSUNBZ0lDOHZJR2xtSUc5d1pYSmhkRzl5SUdsdUlITmxiR1l1YjNCbGNtRjBiM0p6T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRmtaRjl2Y0dWeVlYUnZjbDkwYjE5c1lXSmxiRjlsYkhObFgySnZaSGxBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyT0FvZ0lDQWdMeThnYzJWc1ppNW5aWFJmYjNCbGNtRjBiM0pmYkdGaVpXeGZhVzVrWlhnb2IzQmxjbUYwYjNJc0lHeGhZbVZzS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjl3WlhKaGRHOXlYMnhoWW1Wc1gybHVaR1Y0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFk1Q2lBZ0lDQXZMeUE5UFNCVlNXNTBOalFvVGs5VVgwWlBWVTVFWDFaQlRGVkZLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UWTRMVEUyT1FvZ0lDQWdMeThnYzJWc1ppNW5aWFJmYjNCbGNtRjBiM0pmYkdGaVpXeGZhVzVrWlhnb2IzQmxjbUYwYjNJc0lHeGhZbVZzS1FvZ0lDQWdMeThnUFQwZ1ZVbHVkRFkwS0U1UFZGOUdUMVZPUkY5V1FVeFZSU2tzQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnBaaUJ1YjNRZ1kyOXVaRG9LSUNBZ0lHSnVlaUJoWkdSZmIzQmxjbUYwYjNKZmRHOWZiR0ZpWld4ZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGN3Q2lBZ0lDQXZMeUJUS0NKRlVsSTZSVmhKVTFSVElpa3NDaUFnSUNCaWVYUmxZeUEzSUM4dklDSkZVbEk2UlZoSlUxUlRJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnNiMmNvYlhObktRb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUc5d0xtVnljaWdwQ2lBZ0lDQmxjbklLQ21Ga1pGOXZjR1Z5WVhSdmNsOTBiMTlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjekxURTNOQW9nSUNBZ0x5OGdJeUJoWkdRZ2JHRmlaV3dnZEc4Z2IzQmxjbUYwYjNJS0lDQWdJQzh2SUdWNGFYTjBhVzVuSUQwZ2MyVnNaaTV2Y0dWeVlYUnZjbk5iYjNCbGNtRjBiM0pkTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y0dWeVlYUnZjbk1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCbGVHbHpkR2x1Wnk1aGNIQmxibVFvWVhKak5DNVRkSEpwYm1jb2JHRmlaV3dwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakUzTmdvZ0lDQWdMeThnYzJWc1ppNXZjR1Z5WVhSdmNuTmJiM0JsY21GMGIzSmRJRDBnWlhocGMzUnBibWN1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2dwaFpHUmZiM0JsY21GMGIzSmZkRzlmYkdGaVpXeGZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE1TMHhPRElLSUNBZ0lDOHZJQ01nYVc1amNtVnRaVzUwSUd4aFltVnNJRzl3WlhKaGRHOXljd29nSUNBZ0x5OGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpQTlJSE5sYkdZdWJHRmlaV3h6VzJ4aFltVnNYUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR0ZpWld4eklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTROQW9nSUNBZ0x5OGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpNXVkVzFmYjNCbGNtRjBiM0p6TG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXlJQzh2SURFeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPRE10TVRnMUNpQWdJQ0F2THlCc1lXSmxiRjlrWlhOamNtbHdkRzl5TG01MWJWOXZjR1Z5WVhSdmNuTWdQU0JoY21NMExsVkpiblEyTkNnS0lDQWdJQzh2SUNBZ0lDQnNZV0psYkY5a1pYTmpjbWx3ZEc5eUxtNTFiVjl2Y0dWeVlYUnZjbk11Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdjMlZzWmk1c1lXSmxiSE5iYkdGaVpXeGRJRDBnYkdGaVpXeGZaR1Z6WTNKcGNIUnZjaTVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS1lXUmtYMjl3WlhKaGRHOXlYM1J2WDJ4aFltVnNYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakUzT0MweE56a0tJQ0FnSUM4dklDTWdibVYzSUc5d1pYSmhkRzl5TENCamNtVmhkR1VnYm1WM0lHSnZlQW9nSUNBZ0x5OGdjMlZzWmk1dmNHVnlZWFJ2Y25OYmIzQmxjbUYwYjNKZElEMGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYa29ZWEpqTkM1VGRISnBibWNvYkdGaVpXd3BLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01EQXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0lnWVdSa1gyOXdaWEpoZEc5eVgzUnZYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhjM05sZEY5c1lXSmxiR2x1Wnk1amIyNTBjbUZqZEM1QmMzTmxkRXhoWW1Wc2FXNW5MbWhoYzE5dmNHVnlZWFJ2Y2w5c1lXSmxiQ2h2Y0dWeVlYUnZjam9nWW5sMFpYTXNJR3hoWW1Wc09pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncG9ZWE5mYjNCbGNtRjBiM0pmYkdGaVpXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEU0T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdoaGMxOXZjR1Z5WVhSdmNsOXNZV0psYkNoelpXeG1MQ0J2Y0dWeVlYUnZjam9nUVdOamIzVnVkQ3dnYkdGaVpXdzZJRk4wY21sdVp5a2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrd0NpQWdJQ0F2THlCbGJuTjFjbVVvYkdGaVpXd3VZbmwwWlhNdWJHVnVaM1JvSUQwOUlESXNJRk1vSWtWU1VqcE1SVTVIVkVnaUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdhV1lnYm05MElHTnZibVE2Q2lBZ0lDQmlibm9nYUdGelgyOXdaWEpoZEc5eVgyeGhZbVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTVNQW9nSUNBZ0x5OGdaVzV6ZFhKbEtHeGhZbVZzTG1KNWRHVnpMbXhsYm1kMGFDQTlQU0F5TENCVEtDSkZVbEk2VEVWT1IxUklJaWtwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pGVWxJNlRFVk9SMVJJSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJzYjJjb2JYTm5LUW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklHOXdMbVZ5Y2lncENpQWdJQ0JsY25JS0NtaGhjMTl2Y0dWeVlYUnZjbDlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCcFpIZ2dQU0J6Wld4bUxtZGxkRjl2Y0dWeVlYUnZjbDlzWVdKbGJGOXBibVJsZUNodmNHVnlZWFJ2Y2l3Z2JHRmlaV3dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZiM0JsY21GMGIzSmZiR0ZpWld4ZmFXNWtaWGdLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1Ua3lDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0dsa2VDQWhQU0JPVDFSZlJrOVZUa1JmUzBWWklHRnVaQ0JwWkhnZ0lUMGdUazlVWDBaUFZVNUVYMVpCVEZWRktRb2dJQ0FnYVc1MFl5QTFJQzh2SURReU9UUTVOamN5T1RZS0lDQWdJQ0U5Q2lBZ0lDQmllaUJvWVhOZmIzQmxjbUYwYjNKZmJHRmlaV3hmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDRTlDaUFnSUNCaWVpQm9ZWE5mYjNCbGNtRjBiM0pmYkdGaVpXeGZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYUdGelgyOXdaWEpoZEc5eVgyeGhZbVZzWDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvYVdSNElDRTlJRTVQVkY5R1QxVk9SRjlMUlZrZ1lXNWtJR2xrZUNBaFBTQk9UMVJmUms5VlRrUmZWa0ZNVlVVcENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWhoYzE5dmNHVnlZWFJ2Y2w5c1lXSmxiRjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJvWVhOZmIzQmxjbUYwYjNKZmJHRmlaV3hmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1Y21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3dvYjNCbGNtRjBiM0k2SUdKNWRHVnpMQ0JzWVdKbGJEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuSmxiVzkyWlY5dmNHVnlZWFJ2Y2w5bWNtOXRYMnhoWW1Wc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNU5DMHhPVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxiVzkyWlY5dmNHVnlZWFJ2Y2w5bWNtOXRYMnhoWW1Wc0tITmxiR1lzSUc5d1pYSmhkRzl5T2lCQlkyTnZkVzUwTENCc1lXSmxiRG9nVTNSeWFXNW5LU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9UWUtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNWZiM0pmYjNCbGNtRjBiM0pmYjI1c2VTaHNZV0psYkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmhaRzFwYmw5dmNsOXZjR1Z5WVhSdmNsOXZibXg1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGs0Q2lBZ0lDQXZMeUJsYm5OMWNtVW9iR0ZpWld3Z2FXNGdjMlZzWmk1c1lXSmxiSE1zSUZNb0lrVlNVanBPVDBWWVNWTlVJaWtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCcFppQnViM1FnWTI5dVpEb0tJQ0FnSUdKdWVpQnlaVzF2ZG1WZmIzQmxjbUYwYjNKZlpuSnZiVjlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURJNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCbGJuTjFjbVVvYkdGaVpXd2dhVzRnYzJWc1ppNXNZV0psYkhNc0lGTW9Ja1ZTVWpwT1QwVllTVk5VSWlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKRlVsSTZUazlGV0VsVFZDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2JHOW5LRzF6WnlrS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJ2Y0M1bGNuSW9LUW9nSUNBZ1pYSnlDZ3B5WlcxdmRtVmZiM0JsY21GMGIzSmZabkp2YlY5c1lXSmxiRjloWm5SbGNsOXBabDlsYkhObFFESTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdaVzV6ZFhKbEtHOXdaWEpoZEc5eUlHbHVJSE5sYkdZdWIzQmxjbUYwYjNKekxDQlRLQ0pGVWxJNlRrOUZXRWxUVkNJcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdhV1lnYm05MElHTnZibVE2Q2lBZ0lDQmlibm9nY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWVdaMFpYSmZhV1pmWld4elpVQXpNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdaVzV6ZFhKbEtHOXdaWEpoZEc5eUlHbHVJSE5sYkdZdWIzQmxjbUYwYjNKekxDQlRLQ0pGVWxJNlRrOUZXRWxUVkNJcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVJWSlNPazVQUlZoSlUxUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklHeHZaeWh0YzJjcENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnYjNBdVpYSnlLQ2tLSUNBZ0lHVnljZ29LY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWVdaMFpYSmZhV1pmWld4elpVQXpNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNREV0TWpBeUNpQWdJQ0F2THlBaklHVnVjM1Z5WlNCc1lXSmxiQ0JsZUdsemRITWdhVzRnYjNCbGNtRjBiM0lLSUNBZ0lDOHZJR3hoWW1Wc1gybGtlQ0E5SUhObGJHWXVaMlYwWDI5d1pYSmhkRzl5WDJ4aFltVnNYMmx1WkdWNEtHOXdaWEpoZEc5eUxDQnNZV0psYkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl2Y0dWeVlYUnZjbDlzWVdKbGJGOXBibVJsZUFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJR3hoWW1Wc1gybGtlQ0FoUFNCVlNXNTBOalFvVGs5VVgwWlBWVTVFWDFaQlRGVkZLUW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMExUSXdOZ29nSUNBZ0x5OGdiR0ZpWld4ZmFXUjRJQ0U5SUZWSmJuUTJOQ2hPVDFSZlJrOVZUa1JmVmtGTVZVVXBDaUFnSUNBdkx5QmhibVFnYkdGaVpXeGZhV1I0Q2lBZ0lDQXZMeUFoUFNCVlNXNTBOalFvVGs5VVgwWlBWVTVFWDB0RldTa3NJQ0FqSUd0bGVTQmphR1ZqYXlCeVpXUjFibVJoYm5Rc0lHTm9aV05yWldRZ1lXSnZkbVVLSUNBZ0lHSjZJSEpsYlc5MlpWOXZjR1Z5WVhSdmNsOW1jbTl0WDJ4aFltVnNYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakl3TlMweU1EWUtJQ0FnSUM4dklHRnVaQ0JzWVdKbGJGOXBaSGdLSUNBZ0lDOHZJQ0U5SUZWSmJuUTJOQ2hPVDFSZlJrOVZUa1JmUzBWWktTd2dJQ01nYTJWNUlHTm9aV05ySUhKbFpIVnVaR0Z1ZEN3Z1kyaGxZMnRsWkNCaFltOTJaUW9nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklDRTlJRlZKYm5RMk5DaE9UMVJmUms5VlRrUmZTMFZaS1N3Z0lDTWdhMlY1SUdOb1pXTnJJSEpsWkhWdVpHRnVkQ3dnWTJobFkydGxaQ0JoWW05MlpRb2dJQ0FnYVc1MFl5QTFJQzh2SURReU9UUTVOamN5T1RZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TURVdE1qQTJDaUFnSUNBdkx5QmhibVFnYkdGaVpXeGZhV1I0Q2lBZ0lDQXZMeUFoUFNCVlNXNTBOalFvVGs5VVgwWlBWVTVFWDB0RldTa3NJQ0FqSUd0bGVTQmphR1ZqYXlCeVpXUjFibVJoYm5Rc0lHTm9aV05yWldRZ1lXSnZkbVVLSUNBZ0lDRTlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qQTBMVEl3TmdvZ0lDQWdMeThnYkdGaVpXeGZhV1I0SUNFOUlGVkpiblEyTkNoT1QxUmZSazlWVGtSZlZrRk1WVVVwQ2lBZ0lDQXZMeUJoYm1RZ2JHRmlaV3hmYVdSNENpQWdJQ0F2THlBaFBTQlZTVzUwTmpRb1RrOVVYMFpQVlU1RVgwdEZXU2tzSUNBaklHdGxlU0JqYUdWamF5QnlaV1IxYm1SaGJuUXNJR05vWldOclpXUWdZV0p2ZG1VS0lDQWdJR0o2SUhKbGJXOTJaVjl2Y0dWeVlYUnZjbDltY205dFgyeGhZbVZzWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuSmxiVzkyWlY5dmNHVnlZWFJ2Y2w5bWNtOXRYMnhoWW1Wc1gySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdhV1lnYm05MElHTnZibVE2Q2lBZ0lDQmlibm9nY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWVdaMFpYSmZhV1pmWld4elpVQXlOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXdOd29nSUNBZ0x5OGdVeWdpUlZKU09rNVBSVmhKVTFRaUtTd0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lrVlNVanBPVDBWWVNWTlVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnNiMmNvYlhObktRb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUc5d0xtVnljaWdwQ2lBZ0lDQmxjbklLQ25KbGJXOTJaVjl2Y0dWeVlYUnZjbDltY205dFgyeGhZbVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNalE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNakV3TFRJeE1Rb2dJQ0FnTHk4Z0l5Qmxibk4xY21VZ2IyNXNlU0JsYlhCMGVTQnNZV0psYkhNZ1kyRnVJR0psSUd4bFpuUWdiM0JsY21GMGIzSXRiR1Z6Y3dvZ0lDQWdMeThnYkdGaVpXeGZaR1Z6WTNKcGNIUnZjaUE5SUhObGJHWXViR0ZpWld4elcyeGhZbVZzWFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14aFltVnNjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TVRNS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym5WdFgyOXdaWEpoZEc5eWN5QStJREVnYjNJZ2JHRmlaV3hmWkdWelkzSnBjSFJ2Y2k1dWRXMWZZWE56WlhSeklEMDlJREFzQ2lBZ0lDQmxlSFJ5WVdOMElERXlJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0JpUGdvZ0lDQWdZbTU2SUhKbGJXOTJaVjl2Y0dWeVlYUnZjbDltY205dFgyeGhZbVZzWDJKdmIyeGZkSEoxWlVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaWGgwY21GamRDQTBJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWowOUNpQWdJQ0JpZWlCeVpXMXZkbVZmYjNCbGNtRjBiM0pmWm5KdmJWOXNZV0psYkY5aWIyOXNYMlpoYkhObFFEY0tDbkpsYlc5MlpWOXZjR1Z5WVhSdmNsOW1jbTl0WDJ4aFltVnNYMkp2YjJ4ZmRISjFaVUEyT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25KbGJXOTJaVjl2Y0dWeVlYUnZjbDltY205dFgyeGhZbVZzWDJKdmIyeGZiV1Z5WjJWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z2FXWWdibTkwSUdOdmJtUTZDaUFnSUNCaWJub2djbVZ0YjNabFgyOXdaWEpoZEc5eVgyWnliMjFmYkdGaVpXeGZZV1owWlhKZmFXWmZaV3h6WlVBeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeE5Bb2dJQ0FnTHk4Z1V5Z2lSVkpTT2s1UFJVMVFWRmtpS1N3S0lDQWdJR0o1ZEdWaklEZ2dMeThnSWtWU1VqcE9UMFZOVUZSWklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCc2IyY29iWE5uS1FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRzl3TG1WeWNpZ3BDaUFnSUNCbGNuSUtDbkpsYlc5MlpWOXZjR1Z5WVhSdmNsOW1jbTl0WDJ4aFltVnNYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTRDaUFnSUNBdkx5QnNZV0psYkY5a1pYTmpjbWx3ZEc5eUxtNTFiVjl2Y0dWeVlYUnZjbk11Ym1GMGFYWmxJQzBnVlVsdWREWTBLREVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeUlDOHZJREV5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1UWXRNakU1Q2lBZ0lDQXZMeUFqSUdSbFkzSWdiM0JsY21GMGIzSWdZMjkxYm5RS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym5WdFgyOXdaWEpoZEc5eWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lHeGhZbVZzWDJSbGMyTnlhWEIwYjNJdWJuVnRYMjl3WlhKaGRHOXljeTV1WVhScGRtVWdMU0JWU1c1ME5qUW9NU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qSXdDaUFnSUNBdkx5QnpaV3htTG14aFltVnNjMXRzWVdKbGJGMGdQU0JzWVdKbGJGOWtaWE5qY21sd2RHOXlMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlNZ29nSUNBZ0x5OGdhV1lnYzJWc1ppNXZjR1Z5WVhSdmNuTmJiM0JsY21GMGIzSmRMbXhsYm1kMGFDQTlQU0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNHVnlZWFJ2Y25NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWld4elpWOWliMlI1UURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpJekNpQWdJQ0F2THlCa1pXd2djMlZzWmk1dmNHVnlZWFJ2Y25OYmIzQmxjbUYwYjNKZENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnY21WMGMzVmlDZ3B5WlcxdmRtVmZiM0JsY21GMGIzSmZabkp2YlY5c1lXSmxiRjlsYkhObFgySnZaSGxBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCdVpYaDBYMnhwYzNRZ1BTQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxOMGNtbHVaMTBvS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU5pMHlNamtLSUNBZ0lDOHZJQ01nZDJGc2F5d2djSFZ6YUNCbGRtVnllWFJvYVc1bklHVjRZMlZ3ZENCcGJtUmxlQW9nSUNBZ0x5OGdJeUIwYUdseklHbHRjR3hsYldWdWRHRjBhVzl1SUhkaGJHdHpJSFIzYVdObElDaHZibU5sSUdsdUlHZGxkRjl2Y0dWeVlYUnZjbDlzWVdKbGJGOXBibVJsZUNrS0lDQWdJQzh2SUNNZ1kyOTFiR1FnWW1VZ2JXOXlaU0JsWm1acFkybGxiblFLSUNBZ0lDOHZJR1p2Y2lCcFpIZ3NJSE4wYjNKbFpGOXNZV0psYkNCcGJpQjFaVzUxYldWeVlYUmxLSE5sYkdZdWIzQmxjbUYwYjNKelcyOXdaWEpoZEc5eVhTazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y0dWeVlYUnZjbk1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29LY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWm05eVgyaGxZV1JsY2tBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1qWXRNakk1Q2lBZ0lDQXZMeUFqSUhkaGJHc3NJSEIxYzJnZ1pYWmxjbmwwYUdsdVp5QmxlR05sY0hRZ2FXNWtaWGdLSUNBZ0lDOHZJQ01nZEdocGN5QnBiWEJzWlcxbGJuUmhkR2x2YmlCM1lXeHJjeUIwZDJsalpTQW9iMjVqWlNCcGJpQm5aWFJmYjNCbGNtRjBiM0pmYkdGaVpXeGZhVzVrWlhncENpQWdJQ0F2THlBaklHTnZkV3hrSUdKbElHMXZjbVVnWldabWFXTnBaVzUwQ2lBZ0lDQXZMeUJtYjNJZ2FXUjRMQ0J6ZEc5eVpXUmZiR0ZpWld3Z2FXNGdkV1Z1ZFcxbGNtRjBaU2h6Wld4bUxtOXdaWEpoZEc5eWMxdHZjR1Z5WVhSdmNsMHBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJ5WlcxdmRtVmZiM0JsY21GMGIzSmZabkp2YlY5c1lXSmxiRjloWm5SbGNsOW1iM0pBTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNd0NpQWdJQ0F2THlCcFppQnNZV0psYkY5cFpIZ2dJVDBnYVdSNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURjS0lDQWdJQ0U5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCaWVpQnlaVzF2ZG1WZmIzQmxjbUYwYjNKZlpuSnZiVjlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNeENpQWdJQ0F2THlCdVpYaDBYMnhwYzNRdVlYQndaVzVrS0hOMGIzSmxaRjlzWVdKbGJDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbmwwWlY5c1pXNW5kR2hmYUdWaFpBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNncHlaVzF2ZG1WZmIzQmxjbUYwYjNKZlpuSnZiVjlzWVdKbGJGOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURZS0lDQWdJR0lnY21WdGIzWmxYMjl3WlhKaGRHOXlYMlp5YjIxZmJHRmlaV3hmWm05eVgyaGxZV1JsY2tBeE1Rb0tjbVZ0YjNabFgyOXdaWEpoZEc5eVgyWnliMjFmYkdGaVpXeGZZV1owWlhKZlptOXlRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TXdvZ0lDQWdMeThnYzJWc1ppNXZjR1Z5WVhSdmNuTmJiM0JsY21GMGIzSmRJRDBnYm1WNGRGOXNhWE4wTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS2NtVnRiM1psWDI5d1pYSmhkRzl5WDJaeWIyMWZiR0ZpWld4ZlltOXZiRjltWVd4elpVQTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2NtVnRiM1psWDI5d1pYSmhkRzl5WDJaeWIyMWZiR0ZpWld4ZlltOXZiRjl0WlhKblpVQTRDZ3B5WlcxdmRtVmZiM0JsY21GMGIzSmZabkp2YlY5c1lXSmxiRjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ5WlcxdmRtVmZiM0JsY21GMGIzSmZabkp2YlY5c1lXSmxiRjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE56WlhSZmJHRmlaV3hwYm1jdVkyOXVkSEpoWTNRdVFYTnpaWFJNWVdKbGJHbHVaeTVuWlhSZmIzQmxjbUYwYjNKZmJHRmlaV3h6S0c5d1pYSmhkRzl5T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGOXZjR1Z5WVhSdmNsOXNZV0psYkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNMUxUSXpOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5dmNHVnlZWFJ2Y2w5c1lXSmxiSE1vYzJWc1ppd2diM0JsY21GMGIzSTZJRUZqWTI5MWJuUXBJQzArSUV4aFltVnNUR2x6ZERvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdhV1lnYjNCbGNtRjBiM0lnYVc0Z2MyVnNaaTV2Y0dWeVlYUnZjbk02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBYMjl3WlhKaGRHOXlYMnhoWW1Wc2MxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TXpnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtOXdaWEpoZEc5eWMxdHZjR1Z5WVhSdmNsMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM0JsY21GMGIzSnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNncG5aWFJmYjNCbGNtRjBiM0pmYkdGaVpXeHpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVVM1J5YVc1blhTZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6T1MweU5EQUtJQ0FnSUM4dklDTWdjbVYwZFhKdUlHVnRjSFI1SUd4cGMzUUtJQ0FnSUM4dklISmxkSFZ5YmlCbGJYQjBlVjlzYVhOMEtDa0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxtZGxkRjloYzNObGRGOXNZV0psYkY5cGJtUmxlQ2hoYzNObGREb2dkV2x1ZERZMExDQnNZV0psYkRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1oyVjBYMkZ6YzJWMFgyeGhZbVZzWDJsdVpHVjRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTBNaTB5TkRNS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdaMlYwWDJGemMyVjBYMnhoWW1Wc1gybHVaR1Y0S0hObGJHWXNJR0Z6YzJWME9pQkJjM05sZEN3Z2JHRmlaV3c2SUZOMGNtbHVaeWtnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TkRRS0lDQWdJQzh2SUdWdWMzVnlaU2hzWVdKbGJDNWllWFJsY3k1c1pXNW5kR2dnUFQwZ01pd2dVeWdpUlZKU09reEZUa2RVU0NJcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnBaaUJ1YjNRZ1kyOXVaRG9LSUNBZ0lHSnVlaUJuWlhSZllYTnpaWFJmYkdGaVpXeGZhVzVrWlhoZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkwTkFvZ0lDQWdMeThnWlc1emRYSmxLR3hoWW1Wc0xtSjVkR1Z6TG14bGJtZDBhQ0E5UFNBeUxDQlRLQ0pGVWxJNlRFVk9SMVJJSWlrcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKRlVsSTZURVZPUjFSSUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCc2IyY29iWE5uS1FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRzl3TG1WeWNpZ3BDaUFnSUNCbGNuSUtDbWRsZEY5aGMzTmxkRjlzWVdKbGJGOXBibVJsZUY5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkwTlFvZ0lDQWdMeThnYVdZZ1lYTnpaWFFnYm05MElHbHVJSE5sYkdZdVlYTnpaWFJ6T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1oyVjBYMkZ6YzJWMFgyeGhZbVZzWDJsdVpHVjRYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJME5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2hPVDFSZlJrOVZUa1JmUzBWWktRb2dJQ0FnYVc1MFl5QTFJQzh2SURReU9UUTVOamN5T1RZS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncG5aWFJmWVhOelpYUmZiR0ZpWld4ZmFXNWtaWGhmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTBOd29nSUNBZ0x5OGdabTl5SUdsa2VDd2djM1J2Y21Wa1gyeGhZbVZzSUdsdUlIVmxiblZ0WlhKaGRHVW9jMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhOelpYUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbWRsZEY5aGMzTmxkRjlzWVdKbGJGOXBibVJsZUY5bWIzSmZhR1ZoWkdWeVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qUTNDaUFnSUNBdkx5Qm1iM0lnYVdSNExDQnpkRzl5WldSZmJHRmlaV3dnYVc0Z2RXVnVkVzFsY21GMFpTaHpaV3htTG1GemMyVjBjMXRoYzNObGRGMHBPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJuWlhSZllYTnpaWFJmYkdGaVpXeGZhVzVrWlhoZllXWjBaWEpmWm05eVFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklHbG1JSE4wYjNKbFpGOXNZV0psYkNBOVBTQnNZV0psYkRvS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVpQm5aWFJmWVhOelpYUmZiR0ZpWld4ZmFXNWtaWGhmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qUTVDaUFnSUNBdkx5QnlaWFIxY200Z2FXUjRDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEY5aGMzTmxkRjlzWVdKbGJGOXBibVJsZUY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdZaUJuWlhSZllYTnpaWFJmYkdGaVpXeGZhVzVrWlhoZlptOXlYMmhsWVdSbGNrQXpDZ3BuWlhSZllYTnpaWFJmYkdGaVpXeGZhVzVrWlhoZllXWjBaWEpmWm05eVFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qVXdDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0U1UFZGOUdUMVZPUkY5V1FVeFZSU2tLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxsOWhaR1JmYkdGaVpXeGZkRzlmWVhOelpYUW9iR0ZpWld3NklHSjVkR1Z6TENCaGMzTmxkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BmWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkxTWkweU5UTUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDJGa1pGOXNZV0psYkY5MGIxOWhjM05sZENoelpXeG1MQ0JzWVdKbGJEb2dVM1J5YVc1bkxDQmhjM05sZERvZ1FYTnpaWFFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUY5MkxDQmxlR2x6ZEhNZ1BTQnZjQzVCYzNObGRGQmhjbUZ0YzBkbGRDNWhjM05sZEY5amNtVmhkRzl5S0dGemMyVjBYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUTNKbFlYUnZjZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJR2xtSUc1dmRDQmpiMjVrT2dvZ0lDQWdZbTU2SUY5aFpHUmZiR0ZpWld4ZmRHOWZZWE56WlhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkxTkFvZ0lDQWdMeThnWlc1emRYSmxLRzV2ZENCaGMzTmxkRjlwYzE5a1pXeGxkR1ZrS0dGemMyVjBMbWxrS1N3Z1V5Z2lSVkpTT2s1UFJWaEpVMVFpS1NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSWtWU1VqcE9UMFZZU1ZOVUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCc2IyY29iWE5uS1FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRzl3TG1WeWNpZ3BDaUFnSUNCbGNuSUtDbDloWkdSZmJHRmlaV3hmZEc5ZllYTnpaWFJmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOVFVLSUNBZ0lDOHZJR1Z1YzNWeVpTaHNZV0psYkNCcGJpQnpaV3htTG14aFltVnNjeXdnVXlnaVJWSlNPazVQUlZoSlUxUWlLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUdsbUlHNXZkQ0JqYjI1a09nb2dJQ0FnWW01NklGOWhaR1JmYkdGaVpXeGZkRzlmWVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBeE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMU5Rb2dJQ0FnTHk4Z1pXNXpkWEpsS0d4aFltVnNJR2x1SUhObGJHWXViR0ZpWld4ekxDQlRLQ0pGVWxJNlRrOUZXRWxUVkNJcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVJWSlNPazVQUlZoSlUxUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklHeHZaeWh0YzJjcENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnYjNBdVpYSnlLQ2tLSUNBZ0lHVnljZ29LWDJGa1pGOXNZV0psYkY5MGIxOWhjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkxTmdvZ0lDQWdMeThnYVdZZ1lYTnpaWFFnYVc0Z2MyVnNaaTVoYzNObGRITTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRjloWkdSZmJHRmlaV3hmZEc5ZllYTnpaWFJmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUhObGJHWXVaMlYwWDJGemMyVjBYMnhoWW1Wc1gybHVaR1Y0S0dGemMyVjBMQ0JzWVdKbGJDa2dQVDBnVlVsdWREWTBLRTVQVkY5R1QxVk9SRjlXUVV4VlJTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJuWlhSZllYTnpaWFJmYkdGaVpXeGZhVzVrWlhnS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnBaaUJ1YjNRZ1kyOXVaRG9LSUNBZ0lHSnVlaUJmWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTJNQW9nSUNBZ0x5OGdVeWdpUlZKU09rVllTVk5VVXlJcExBb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVJWSlNPa1ZZU1ZOVVV5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2JHOW5LRzF6WnlrS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJ2Y0M1bGNuSW9LUW9nSUNBZ1pYSnlDZ3BmWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOakl0TWpZekNpQWdJQ0F2THlBaklHRmtaQ0JzWVdKbGJDQjBieUJoYzNObGRBb2dJQ0FnTHk4Z1pYaHBjM1JwYm1jZ1BTQnpaV3htTG1GemMyVjBjMXRoYzNObGRGMHVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMENpQWdJQ0F2THlCbGVHbHpkR2x1Wnk1aGNIQmxibVFvWVhKak5DNVRkSEpwYm1jb2JHRmlaV3dwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZllubDBaVjlzWlc1bmRHaGZhR1ZoWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakkyTlFvZ0lDQWdMeThnYzJWc1ppNWhjM05sZEhOYllYTnpaWFJkSUQwZ1pYaHBjM1JwYm1jdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDZ3BmWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOekF0TWpjeENpQWdJQ0F2THlBaklHbHVZM0lnWVhOelpYUWdZMjkxYm5RS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0lnUFNCelpXeG1MbXhoWW1Wc2MxdHNZV0psYkYwdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14aFltVnNjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym5WdFgyRnpjMlYwY3k1dVlYUnBkbVVnS3lCVlNXNTBOalFvTVNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTNNaTB5TnpRS0lDQWdJQzh2SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym5WdFgyRnpjMlYwY3lBOUlHRnlZelF1VlVsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1Ym5WdFgyRnpjMlYwY3k1dVlYUnBkbVVnS3lCVlNXNTBOalFvTVNrS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOelVLSUNBZ0lDOHZJSE5sYkdZdWJHRmlaV3h6VzJ4aFltVnNYU0E5SUd4aFltVnNYMlJsYzJOeWFYQjBiM0l1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0NsOWhaR1JmYkdGaVpXeGZkRzlmWVhOelpYUmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNalkzTFRJMk9Bb2dJQ0FnTHk4Z0l5QnVaWGNnWVhOelpYUXNJR055WldGMFpTQnVaWGNnWW05NENpQWdJQ0F2THlCelpXeG1MbUZ6YzJWMGMxdGhjM05sZEYwZ1BTQmhjbU0wTGtSNWJtRnRhV05CY25KaGVTaGhjbU0wTGxOMGNtbHVaeWhzWVdKbGJDa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURBd01ERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJRjloWkdSZmJHRmlaV3hmZEc5ZllYTnpaWFJmWVdaMFpYSmZhV1pmWld4elpVQXpDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdVlXUmtYMnhoWW1Wc1gzUnZYMkZ6YzJWMEtHeGhZbVZzT2lCaWVYUmxjeXdnWVhOelpYUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZV1JrWDJ4aFltVnNYM1J2WDJGemMyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTNOeTB5TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR0ZrWkY5c1lXSmxiRjkwYjE5aGMzTmxkQ2h6Wld4bUxDQnNZV0psYkRvZ1UzUnlhVzVuTENCaGMzTmxkRG9nUVhOelpYUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG95TnprS0lDQWdJQzh2SUhObGJHWXViM0JsY21GMGIzSmZiMjVzZVNoc1lXSmxiQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCdmNHVnlZWFJ2Y2w5dmJteDVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZ3dDaUFnSUNBdkx5QnpaV3htTGw5aFpHUmZiR0ZpWld4ZmRHOWZZWE56WlhRb2JHRmlaV3dzSUdGemMyVjBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJGa1pGOXNZV0psYkY5MGIxOWhjM05sZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwY3loc1lXSmxiRG9nWW5sMFpYTXNJR0Z6YzJWMGN6b2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRmtaRjlzWVdKbGJGOTBiMTloYzNObGRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZ3lMVEk0TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdZV1JrWDJ4aFltVnNYM1J2WDJGemMyVjBjeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQ0JzWVdKbGJEb2dVM1J5YVc1bkxDQmhjM05sZEhNNklHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VlVsdWREWTBYUW9nSUNBZ0x5OGdLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpnMkNpQWdJQ0F2THlCelpXeG1MbTl3WlhKaGRHOXlYMjl1Ykhrb2JHRmlaV3dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ2IzQmxjbUYwYjNKZmIyNXNlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTROd29nSUNBZ0x5OGdabTl5SUY5cExDQmhjM05sZENCcGJpQjFaVzUxYldWeVlYUmxLR0Z6YzJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtRmtaRjlzWVdKbGJGOTBiMTloYzNObGRITmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakk0TndvZ0lDQWdMeThnWm05eUlGOXBMQ0JoYzNObGRDQnBiaUIxWlc1MWJXVnlZWFJsS0dGemMyVjBjeWs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUR3S0lDQWdJR0o2SUdGa1pGOXNZV0psYkY5MGIxOWhjM05sZEhOZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qZzRDaUFnSUNBdkx5QnpaV3htTGw5aFpHUmZiR0ZpWld4ZmRHOWZZWE56WlhRb2JHRmlaV3dzSUVGemMyVjBLR0Z6YzJWMExtNWhkR2wyWlNrcENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjloWkdSZmJHRmlaV3hmZEc5ZllYTnpaWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWVdSa1gyeGhZbVZzWDNSdlgyRnpjMlYwYzE5bWIzSmZhR1ZoWkdWeVFERUtDbUZrWkY5c1lXSmxiRjkwYjE5aGMzTmxkSE5mWVdaMFpYSmZabTl5UURRNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1eVpXMXZkbVZmYkdGaVpXeGZabkp2YlY5aGMzTmxkQ2hzWVdKbGJEb2dZbmwwWlhNc0lHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25KbGJXOTJaVjlzWVdKbGJGOW1jbTl0WDJGemMyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qSTVNQzB5T1RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSEpsYlc5MlpWOXNZV0psYkY5bWNtOXRYMkZ6YzJWMEtITmxiR1lzSUd4aFltVnNPaUJUZEhKcGJtY3NJR0Z6YzJWME9pQkJjM05sZENrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNd29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNamt5Q2lBZ0lDQXZMeUJsYm5OMWNtVW9iR0ZpWld3Z2FXNGdjMlZzWmk1c1lXSmxiSE1zSUZNb0lrVlNVanBPVDBWWVNWTlVJaWtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCcFppQnViM1FnWTI5dVpEb0tJQ0FnSUdKdWVpQnlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNamt5Q2lBZ0lDQXZMeUJsYm5OMWNtVW9iR0ZpWld3Z2FXNGdjMlZzWmk1c1lXSmxiSE1zSUZNb0lrVlNVanBPVDBWWVNWTlVJaWtwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pGVWxJNlRrOUZXRWxUVkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYkc5bktHMXpaeWtLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnZjQzVsY25Jb0tRb2dJQ0FnWlhKeUNncHlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPakk1TkFvZ0lDQWdMeThnYzJWc1ppNXZjR1Z5WVhSdmNsOXZibXg1S0d4aFltVnNLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUc5d1pYSmhkRzl5WDI5dWJIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU9UWUtJQ0FnSUM4dklHWnZkVzVrSUQwZ1JtRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU9UY0tJQ0FnSUM4dklHbG1JSE5sYkdZdVlYTnpaWFJ6VzJGemMyVjBYUzVzWlc1bmRHZ2dQVDBnTVRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5bGJITmxYMkp2WkhsQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJNU9Bb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRXekJkSUQwOUlHeGhZbVZzT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1lYTnpaWEowSUM4dklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsYlc5MlpWOXNZV0psYkY5bWNtOXRYMkZ6YzJWMFgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qazVDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNWhjM05sZEhOYllYTnpaWFJkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNekF3Q2lBZ0lDQXZMeUJtYjNWdVpDQTlJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLQ25KbGJXOTJaVjlzWVdKbGJGOW1jbTl0WDJGemMyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklHbG1JRzV2ZENCamIyNWtPZ29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdKdWVpQnlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNekUxQ2lBZ0lDQXZMeUJsYm5OMWNtVW9abTkxYm1Rc0lGTW9Ja1ZTVWpwT1QwVllTVk5VSWlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKRlVsSTZUazlGV0VsVFZDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2JHOW5LRzF6WnlrS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJ2Y0M1bGNuSW9LUW9nSUNBZ1pYSnlDZ3B5WlcxdmRtVmZiR0ZpWld4ZlpuSnZiVjloYzNObGRGOWhablJsY2w5cFpsOWxiSE5sUURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNeE55MHpNVGdLSUNBZ0lDOHZJQ01nWkdWamNpQmhjM05sZENCamIzVnVkQW9nSUNBZ0x5OGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpQTlJSE5sYkdZdWJHRmlaV3h6VzJ4aFltVnNYUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR0ZpWld4eklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTXlNQW9nSUNBZ0x5OGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpNXVkVzFmWVhOelpYUnpMbTVoZEdsMlpTQXRJRlZKYm5RMk5DZ3hLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpFNUxUTXlNUW9nSUNBZ0x5OGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpNXVkVzFmWVhOelpYUnpJRDBnWVhKak5DNVZTVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpNXVkVzFmWVhOelpYUnpMbTVoZEdsMlpTQXRJRlZKYm5RMk5DZ3hLUW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNeU1nb2dJQ0FnTHk4Z2MyVnNaaTVzWVdKbGJITmJiR0ZpWld4ZElEMGdiR0ZpWld4ZlpHVnpZM0pwY0hSdmNpNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LY21WdGIzWmxYMnhoWW1Wc1gyWnliMjFmWVhOelpYUmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNekF5Q2lBZ0lDQXZMeUJtYjNWdVpDQTlJRVpoYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0EyQ2lBZ0lDQmlJSEpsYlc5MlpWOXNZV0psYkY5bWNtOXRYMkZ6YzJWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0NuSmxiVzkyWlY5c1lXSmxiRjltY205dFgyRnpjMlYwWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNd05Bb2dJQ0FnTHk4Z2JtVjRkRjlzYVhOMElEMGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJZWEpqTkM1VGRISnBibWRkS0NrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek1EVXRNekEzQ2lBZ0lDQXZMeUFqSUhkaGJHc3NJSEIxYzJnZ1pYWmxjbmwwYUdsdVp5QjBieUJ1WlhjZ1ltOTRJR1Y0WTJWd2RDQnNZV0psYkFvZ0lDQWdMeThnSXlCellYWmxJQ1JtYjNWdVpDQjBieUIwYUhKdmR5QnBaaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR1p2Y2lCZmFXUjRMQ0J6ZEc5eVpXUmZiR0ZpWld3Z2FXNGdkV1Z1ZFcxbGNtRjBaU2h6Wld4bUxtRnpjMlYwYzF0aGMzTmxkRjBwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9LY21WdGIzWmxYMnhoWW1Wc1gyWnliMjFmWVhOelpYUmZabTl5WDJobFlXUmxja0EyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPak13TlMwek1EY0tJQ0FnSUM4dklDTWdkMkZzYXl3Z2NIVnphQ0JsZG1WeWVYUm9hVzVuSUhSdklHNWxkeUJpYjNnZ1pYaGpaWEIwSUd4aFltVnNDaUFnSUNBdkx5QWpJSE5oZG1VZ0pHWnZkVzVrSUhSdklIUm9jbTkzSUdsbUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z1ptOXlJRjlwWkhnc0lITjBiM0psWkY5c1lXSmxiQ0JwYmlCMVpXNTFiV1Z5WVhSbEtITmxiR1l1WVhOelpYUnpXMkZ6YzJWMFhTazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJSEpsYlc5MlpWOXNZV0psYkY5bWNtOXRYMkZ6YzJWMFgyRm1kR1Z5WDJadmNrQXhNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek1EZ0tJQ0FnSUM4dklHbG1JSE4wYjNKbFpGOXNZV0psYkNBaFBTQnNZV0psYkRvS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDRTlDaUFnSUNCaWVpQnlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5bGJITmxYMkp2WkhsQU9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNd09Rb2dJQ0FnTHk4Z2JtVjRkRjlzYVhOMExtRndjR1Z1WkNoemRHOXlaV1JmYkdGaVpXd3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMko1ZEdWZmJHVnVaM1JvWDJobFlXUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0tjbVZ0YjNabFgyeGhZbVZzWDJaeWIyMWZZWE56WlhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JpSUhKbGJXOTJaVjlzWVdKbGJGOW1jbTl0WDJGemMyVjBYMlp2Y2w5b1pXRmtaWEpBTmdvS2NtVnRiM1psWDJ4aFltVnNYMlp5YjIxZllYTnpaWFJmWld4elpWOWliMlI1UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpFeENpQWdJQ0F2THlCbWIzVnVaQ0E5SUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURZS0lDQWdJR0lnY21WdGIzWmxYMnhoWW1Wc1gyWnliMjFmWVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tjbVZ0YjNabFgyeGhZbVZzWDJaeWIyMWZZWE56WlhSZllXWjBaWEpmWm05eVFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTXhNd29nSUNBZ0x5OGdjMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRJRDBnYm1WNGRGOXNhWE4wTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQnlaVzF2ZG1WZmJHRmlaV3hmWm5KdmJWOWhjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnpjMlYwWDJ4aFltVnNhVzVuTG1OdmJuUnlZV04wTGtGemMyVjBUR0ZpWld4cGJtY3VhR0Z6WDJGemMyVjBYMnhoWW1Wc0tHRnpjMlYwWDJsa09pQjFhVzUwTmpRc0lHeGhZbVZzT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwb1lYTmZZWE56WlhSZmJHRmlaV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNekkwTFRNeU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHaGhjMTloYzNObGRGOXNZV0psYkNoelpXeG1MQ0JoYzNObGRGOXBaRG9nVlVsdWREWTBMQ0JzWVdKbGJEb2dVM1J5YVc1bktTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96TWpjS0lDQWdJQzh2SUdsa2VDQTlJSE5sYkdZdVoyVjBYMkZ6YzJWMFgyeGhZbVZzWDJsdVpHVjRLR0Z6YzJWMExDQnNZV0psYkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjloYzNObGRGOXNZV0psYkY5cGJtUmxlQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16STRDaUFnSUNBdkx5QnBaaUJwWkhnZ0lUMGdUazlVWDBaUFZVNUVYMHRGV1NCaGJtUWdhV1I0SUNFOUlFNVBWRjlHVDFWT1JGOVdRVXhWUlRvS0lDQWdJR2x1ZEdNZ05TQXZMeUEwTWprME9UWTNNamsyQ2lBZ0lDQWhQUW9nSUNBZ1lub2dhR0Z6WDJGemMyVjBYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBaFBRb2dJQ0FnWW5vZ2FHRnpYMkZ6YzJWMFgyeGhZbVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thR0Z6WDJGemMyVjBYMnhoWW1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96TXpBS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NW5aWFJmWVhOelpYUmZiR0ZpWld4ektHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUmZZWE56WlhSZmJHRmlaV3h6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPak16TWkwek16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmWVhOelpYUmZiR0ZpWld4ektITmxiR1lzSUdGemMyVjBPaUJCYzNObGRDa2dMVDRnVEdGaVpXeE1hWE4wT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16TTBDaUFnSUNBdkx5QnBaaUJoYzNObGRDQnBiaUJ6Wld4bUxtRnpjMlYwY3pvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRjloYzNObGRGOXNZV0psYkhOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNek0xQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhSeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUmZZWE56WlhSZmJHRmlaV3h6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VTNSeWFXNW5YU2dwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNek5pMHpNemNLSUNBZ0lDOHZJQ01nY21WMGRYSnVJR1Z0Y0hSNUNpQWdJQ0F2THlCeVpYUjFjbTRnWlcxd2RIbGZiR2x6ZENncENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1blpYUmZZWE56WlhSelgyeGhZbVZzY3loaGMzTmxkSE02SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFgyRnpjMlYwYzE5c1lXSmxiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNek01TFRNME1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjloYzNObGRITmZiR0ZpWld4ektBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0lHRnpjMlYwY3pvZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYllYSmpOQzVWU1c1ME5qUmRDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzB4aFltVnNUR2x6ZEYwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16UXpDaUFnSUNBdkx5QnZkWFFnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0TVlXSmxiRXhwYzNSZEtDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNelEwQ2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgyRnpjMlYwYzE5c1lXSmxiSE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNME5Bb2dJQ0FnTHk4Z1ptOXlJRjlwTENCaGMzTmxkRjlwWkNCcGJpQjFaVzUxYldWeVlYUmxLR0Z6YzJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aGMzTmxkSE5mYkdGaVpXeHpYMkZtZEdWeVgyWnZja0EzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pORFVLSUNBZ0lDOHZJR0Z6YzJWMElEMGdRWE56WlhRb1lYTnpaWFJmYVdRdWJtRjBhWFpsS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96TkRZS0lDQWdJQzh2SUdsbUlHRnpjMlYwSUdsdUlITmxiR1l1WVhOelpYUnpPZ29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFgyRnpjMlYwYzE5c1lXSmxiSE5mWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96TkRjS0lDQWdJQzh2SUc5MWRDNWhjSEJsYm1Rb2MyVnNaaTVoYzNObGRITmJZWE56WlhSZExtTnZjSGtvS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwblpYUmZZWE56WlhSelgyeGhZbVZzYzE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdZaUJuWlhSZllYTnpaWFJ6WDJ4aFltVnNjMTltYjNKZmFHVmhaR1Z5UURFS0NtZGxkRjloYzNObGRITmZiR0ZpWld4elgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTBPUW9nSUNBZ0x5OGdiM1YwTG1Gd2NHVnVaQ2hsYlhCMGVWOXNhWE4wS0NrcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNakF3TURBS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ1oyVjBYMkZ6YzJWMGMxOXNZV0psYkhOZllXWjBaWEpmYVdaZlpXeHpaVUExQ2dwblpYUmZZWE56WlhSelgyeGhZbVZzYzE5aFpuUmxjbDltYjNKQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek5UQUtJQ0FnSUM4dklISmxkSFZ5YmlCdmRYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYzNObGRGOXNZV0psYkdsdVp5NWpiMjUwY21GamRDNUJjM05sZEV4aFltVnNhVzVuTG14dloxOWhjM05sZEhOZmJHRmlaV3h6S0dGemMyVjBjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbXh2WjE5aGMzTmxkSE5mYkdGaVpXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTFNaTB6TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCc2IyZGZZWE56WlhSelgyeGhZbVZzY3loelpXeG1MQ0JoYzNObGRITTZJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVXMkZ5WXpRdVZVbHVkRFkwWFNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek5UUUtJQ0FnSUM4dklHWnZjaUJmYVN3Z1lYTnpaWFJmYVdRZ2FXNGdkV1Z1ZFcxbGNtRjBaU2hoYzNObGRITXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncHNiMmRmWVhOelpYUnpYMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNelUwQ2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1BBb2dJQ0FnWW5vZ2JHOW5YMkZ6YzJWMGMxOXNZV0psYkhOZllXWjBaWEpmWm05eVFEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNMU5Rb2dJQ0FnTHk4Z1lYTnpaWFFnUFNCQmMzTmxkQ2hoYzNObGRGOXBaQzV1WVhScGRtVXBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTFOZ29nSUNBZ0x5OGdhV1lnWVhOelpYUWdhVzRnYzJWc1ppNWhjM05sZEhNNkNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnNiMmRmWVhOelpYUnpYMnhoWW1Wc2MxOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTFOd29nSUNBZ0x5OGdiRzluS0hObGJHWXVZWE56WlhSelcyRnpjMlYwWFNrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JzYjJjS0NteHZaMTloYzNObGRITmZiR0ZpWld4elgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUd4dloxOWhjM05sZEhOZmJHRmlaV3h6WDJadmNsOW9aV0ZrWlhKQU1Rb0tiRzluWDJGemMyVjBjMTlzWVdKbGJITmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxOMGNtbHVaMTBvS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvek5Ua0tJQ0FnSUM4dklHeHZaeWhsYlhCMGVWOXNhWE4wS0NrcENpQWdJQ0JzYjJjS0lDQWdJR0lnYkc5blgyRnpjMlYwYzE5c1lXSmxiSE5mWVdaMFpYSmZhV1pmWld4elpVQTFDZ3BzYjJkZllYTnpaWFJ6WDJ4aFltVnNjMTloWm5SbGNsOW1iM0pBTnpvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYzNObGRGOXNZV0psYkdsdVp5NWpiMjUwY21GamRDNUJjM05sZEV4aFltVnNhVzVuTGw5blpYUmZZWE56WlhSZmJXbGpjbThvWVhOelpYUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q2w5blpYUmZZWE56WlhSZmJXbGpjbTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNelkzTFRNMk9Bb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWjJWMFgyRnpjMlYwWDIxcFkzSnZLSE5sYkdZc0lHRnpjMlYwWDJsa09pQlZTVzUwTmpRcElDMCtJRUZ6YzJWMFRXbGpjbTg2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1gzWXNJR1Y0YVhOMGN5QTlJRzl3TGtGemMyVjBVR0Z5WVcxelIyVjBMbUZ6YzJWMFgyTnlaV0YwYjNJb1lYTnpaWFJmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRGNtVmhkRzl5Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96TmprS0lDQWdJQzh2SUdsbUlHRnpjMlYwWDJselgyUmxiR1YwWldRb1lYTnpaWFJmYVdRcE9nb2dJQ0FnWW01NklGOW5aWFJmWVhOelpYUmZiV2xqY205ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemN3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRWE56WlhSTmFXTnlieTVtY205dFgySjVkR1Z6S0dJaUlpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUhKbGRITjFZZ29LWDJkbGRGOWhjM05sZEY5dGFXTnliMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16Y3pDaUFnSUNBdkx5QjFibWwwWDI1aGJXVTlZakp6ZEhJb1lYTnpaWFF1ZFc1cGRGOXVZVzFsS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlHSXljM1J5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemMwQ2lBZ0lDQXZMeUJrWldOcGJXRnNjejFoY21NMExsVkpiblE0S0dGemMyVjBMbVJsWTJsdFlXeHpLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKcGRHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ055QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16Y3lMVE0zTlFvZ0lDQWdMeThnY21WMGRYSnVJRUZ6YzJWMFRXbGpjbThvQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBXSXljM1J5S0dGemMyVjBMblZ1YVhSZmJtRnRaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVlYSmpOQzVWU1c1ME9DaGhjM05sZEM1a1pXTnBiV0ZzY3lrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WjJWMFgyRnpjMlYwWDIxcFkzSnZLR0Z6YzJWME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncG5aWFJmWVhOelpYUmZiV2xqY204NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpjM0xUTTNPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5aGMzTmxkRjl0YVdOeWJ5aHpaV3htTENCaGMzTmxkRG9nVlVsdWREWTBLU0F0UGlCQmMzTmxkRTFwWTNKdk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemM1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1ZloyVjBYMkZ6YzJWMFgyMXBZM0p2S0dGemMyVjBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5blpYUmZZWE56WlhSZmJXbGpjbThLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhjM05sZEY5c1lXSmxiR2x1Wnk1amIyNTBjbUZqZEM1QmMzTmxkRXhoWW1Wc2FXNW5MbWRsZEY5aGMzTmxkSE5mYldsamNtOG9ZWE56WlhSek9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1oyVjBYMkZ6YzJWMGMxOXRhV055YnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96T0RFdE16Z3lDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJGemMyVjBjMTl0YVdOeWJ5aHpaV3htTENCaGMzTmxkSE02SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVWVWx1ZERZMFhTa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPak00TXdvZ0lDQWdMeThnWm05eUlGOXBMQ0JoYzNObGRGOXBaQ0JwYmlCMVpXNTFiV1Z5WVhSbEtHRnpjMlYwY3lrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21kbGRGOWhjM05sZEhOZmJXbGpjbTlmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNNE13b2dJQ0FnTHk4Z1ptOXlJRjlwTENCaGMzTmxkRjlwWkNCcGJpQjFaVzUxYldWeVlYUmxLR0Z6YzJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aGMzTmxkSE5mYldsamNtOWZZV1owWlhKZlptOXlRRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemcwQ2lBZ0lDQXZMeUJzYjJjb2MyVnNaaTVmWjJWMFgyRnpjMlYwWDIxcFkzSnZLR0Z6YzJWMFgybGtMbTVoZEdsMlpTa3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBYMkZ6YzJWMFgyMXBZM0p2Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWjJWMFgyRnpjMlYwYzE5dGFXTnliMTltYjNKZmFHVmhaR1Z5UURFS0NtZGxkRjloYzNObGRITmZiV2xqY205ZllXWjBaWEpmWm05eVFEUTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NWZaMlYwWDJGemMyVjBYMjFwWTNKdlgyeGhZbVZzY3loaGMzTmxkRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1gyZGxkRjloYzNObGRGOXRhV055YjE5c1lXSmxiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemc0TFRNNE9Rb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWjJWMFgyRnpjMlYwWDIxcFkzSnZYMnhoWW1Wc2N5aHpaV3htTENCaGMzTmxkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQkJjM05sZEUxcFkzSnZUR0ZpWld4ek9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJRjkyTENCbGVHbHpkSE1nUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjlqY21WaGRHOXlLR0Z6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBRM0psWVhSdmNnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk16a3dDaUFnSUNBdkx5QnBaaUJoYzNObGRGOXBjMTlrWld4bGRHVmtLR0Z6YzJWMFgybGtLVG9LSUNBZ0lHSnVlaUJmWjJWMFgyRnpjMlYwWDIxcFkzSnZYMnhoWW1Wc2MxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96T1RFS0lDQWdJQzh2SUhKbGRIVnliaUJCYzNObGRFMXBZM0p2VEdGaVpXeHpMbVp5YjIxZllubDBaWE1vWWlJaUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbDluWlhSZllYTnpaWFJmYldsamNtOWZiR0ZpWld4elgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG96T1RRS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQxaU1uTjBjaWhoYzNObGRDNTFibWwwWDI1aGJXVXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnWWpKemRISUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNNU5Rb2dJQ0FnTHk4Z1pHVmphVzFoYkhNOVlYSmpOQzVWU1c1ME9DaGhjM05sZEM1a1pXTnBiV0ZzY3lrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JsZUhSeVlXTjBJRGNnTVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemsyQ2lBZ0lDQXZMeUJzWVdKbGJITTljMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRMbU52Y0hrb0tTQnBaaUJoYzNObGRDQnBiaUJ6Wld4bUxtRnpjMlYwY3lCbGJITmxJR1Z0Y0hSNVgyeHBjM1FvS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gyZGxkRjloYzNObGRGOXRhV055YjE5c1lXSmxiSE5mZEdWeWJtRnllVjltWVd4elpVQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhSeklHVnVkSEo1SUdWNGFYTjBjd29LWDJkbGRGOWhjM05sZEY5dGFXTnliMTlzWVdKbGJITmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pNNU15MHpPVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQkJjM05sZEUxcFkzSnZUR0ZpWld4ektBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFpTW5OMGNpaGhjM05sZEM1MWJtbDBYMjVoYldVcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQV0Z5WXpRdVZVbHVkRGdvWVhOelpYUXVaR1ZqYVcxaGJITXBMQW9nSUNBZ0x5OGdJQ0FnSUd4aFltVnNjejF6Wld4bUxtRnpjMlYwYzF0aGMzTmxkRjB1WTI5d2VTZ3BJR2xtSUdGemMyVjBJR2x1SUhObGJHWXVZWE56WlhSeklHVnNjMlVnWlcxd2RIbGZiR2x6ZENncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdLd29nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGd3TURBMUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2w5blpYUmZZWE56WlhSZmJXbGpjbTlmYkdGaVpXeHpYM1JsY201aGNubGZabUZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVVM1J5YVc1blhTZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TUFvZ0lDQWdZaUJmWjJWMFgyRnpjMlYwWDIxcFkzSnZYMnhoWW1Wc2MxOTBaWEp1WVhKNVgyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE56WlhSZmJHRmlaV3hwYm1jdVkyOXVkSEpoWTNRdVFYTnpaWFJNWVdKbGJHbHVaeTVuWlhSZllYTnpaWFJmYldsamNtOWZiR0ZpWld4ektHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUmZZWE56WlhSZmJXbGpjbTlmYkdGaVpXeHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTVPUzAwTURBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZZWE56WlhSZmJXbGpjbTlmYkdGaVpXeHpLSE5sYkdZc0lHRnpjMlYwT2lCVlNXNTBOalFwSUMwK0lFRnpjMlYwVFdsamNtOU1ZV0psYkhNNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTGw5blpYUmZZWE56WlhSZmJXbGpjbTlmYkdGaVpXeHpLR0Z6YzJWMEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllYTnpaWFJmYldsamNtOWZiR0ZpWld4ekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1blpYUmZZWE56WlhSelgyMXBZM0p2WDJ4aFltVnNjeWhoYzNObGRITTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncG5aWFJmWVhOelpYUnpYMjFwWTNKdlgyeGhZbVZzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTURNdE5EQTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJGemMyVjBjMTl0YVdOeWIxOXNZV0psYkhNb2MyVnNaaXdnWVhOelpYUnpPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRoY21NMExsVkpiblEyTkYwcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNRFVLSUNBZ0lDOHZJR1p2Y2lCZmFTd2dZWE56WlhSZmFXUWdhVzRnZFdWdWRXMWxjbUYwWlNoaGMzTmxkSE1wT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSZllYTnpaWFJ6WDIxcFkzSnZYMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOREExQ2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYMkZ6YzJWMGMxOXRhV055YjE5c1lXSmxiSE5mWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRBMkNpQWdJQ0F2THlCc2IyY29jMlZzWmk1ZloyVjBYMkZ6YzJWMFgyMXBZM0p2WDJ4aFltVnNjeWhoYzNObGRGOXBaQzV1WVhScGRtVXBLUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRjloYzNObGRGOXRhV055YjE5c1lXSmxiSE1LSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUJuWlhSZllYTnpaWFJ6WDIxcFkzSnZYMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREVLQ21kbGRGOWhjM05sZEhOZmJXbGpjbTlmYkdGaVpXeHpYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WDJkbGRGOWhjM05sZEY5MGFXNTVLR0Z6YzJWMFgybGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BmWjJWMFgyRnpjMlYwWDNScGJuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ERXdMVFF4TVFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZaMlYwWDJGemMyVjBYM1JwYm5rb2MyVnNaaXdnWVhOelpYUmZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1FYTnpaWFJVYVc1NU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJRjkyTENCbGVHbHpkSE1nUFNCdmNDNUJjM05sZEZCaGNtRnRjMGRsZEM1aGMzTmxkRjlqY21WaGRHOXlLR0Z6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBRM0psWVhSdmNnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5ERXlDaUFnSUNBdkx5QnBaaUJoYzNObGRGOXBjMTlrWld4bGRHVmtLR0Z6YzJWMFgybGtLVG9LSUNBZ0lHSnVlaUJmWjJWMFgyRnpjMlYwWDNScGJubGZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRFekNpQWdJQ0F2THlCeVpYUjFjbTRnUVhOelpYUlVhVzU1TG1aeWIyMWZZbmwwWlhNb1lpSWlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ2NtVjBjM1ZpQ2dwZloyVjBYMkZ6YzJWMFgzUnBibmxmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXhOZ29nSUNBZ0x5OGdibUZ0WlQxaU1uTjBjaWhoYzNObGRDNXVZVzFsS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEU1aGJXVUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnWWpKemRISUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1UY0tJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMWlNbk4wY2loaGMzTmxkQzUxYm1sMFgyNWhiV1VwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1lqSnpkSElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNVGdLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQV0Z5WXpRdVZVbHVkRGdvWVhOelpYUXVaR1ZqYVcxaGJITXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pYaDBjbUZqZENBM0lERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1UVXROREU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRWE56WlhSVWFXNTVLQW9nSUNBZ0x5OGdJQ0FnSUc1aGJXVTlZakp6ZEhJb1lYTnpaWFF1Ym1GdFpTa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJeWMzUnlLR0Z6YzJWMExuVnVhWFJmYm1GdFpTa3NDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05WVhKak5DNVZTVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRNREF3TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxtZGxkRjloYzNObGRGOTBhVzU1S0dGemMyVjBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSZllYTnpaWFJmZEdsdWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1qRXROREl5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWjJWMFgyRnpjMlYwWDNScGJua29jMlZzWml3Z1lYTnpaWFE2SUZWSmJuUTJOQ2tnTFQ0Z1FYTnpaWFJVYVc1NU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOREl6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1ZloyVjBYMkZ6YzJWMFgzUnBibmtvWVhOelpYUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOWhjM05sZEY5MGFXNTVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NW5aWFJmWVhOelpYUnpYM1JwYm5rb1lYTnpaWFJ6T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWjJWMFgyRnpjMlYwYzE5MGFXNTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXlOUzAwTWpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZZWE56WlhSelgzUnBibmtvYzJWc1ppd2dZWE56WlhSek9pQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxWSmJuUTJORjBwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME1qY0tJQ0FnSUM4dklHWnZjaUJmYVN3Z1lYTnpaWFJmYVdRZ2FXNGdkV1Z1ZFcxbGNtRjBaU2hoYzNObGRITXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncG5aWFJmWVhOelpYUnpYM1JwYm5sZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUXlOd29nSUNBZ0x5OGdabTl5SUY5cExDQmhjM05sZEY5cFpDQnBiaUIxWlc1MWJXVnlZWFJsS0dGemMyVjBjeWs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUR3S0lDQWdJR0o2SUdkbGRGOWhjM05sZEhOZmRHbHVlVjloWm5SbGNsOW1iM0pBTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTWpnS0lDQWdJQzh2SUd4dlp5aHpaV3htTGw5blpYUmZZWE56WlhSZmRHbHVlU2hoYzNObGRGOXBaQzV1WVhScGRtVXBLUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRjloYzNObGRGOTBhVzU1Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWjJWMFgyRnpjMlYwYzE5MGFXNTVYMlp2Y2w5b1pXRmtaWEpBTVFvS1oyVjBYMkZ6YzJWMGMxOTBhVzU1WDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdVgyZGxkRjloYzNObGRGOTBhVzU1WDJ4aFltVnNjeWhoYzNObGRGOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWDJkbGRGOWhjM05sZEY5MGFXNTVYMnhoWW1Wc2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME16SXRORE16Q2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlGOW5aWFJmWVhOelpYUmZkR2x1ZVY5c1lXSmxiSE1vYzJWc1ppd2dZWE56WlhSZmFXUTZJRlZKYm5RMk5Da2dMVDRnUVhOelpYUlVhVzU1VEdGaVpXeHpPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUY5MkxDQmxlR2x6ZEhNZ1BTQnZjQzVCYzNObGRGQmhjbUZ0YzBkbGRDNWhjM05sZEY5amNtVmhkRzl5S0dGemMyVjBYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUTNKbFlYUnZjZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORE0wQ2lBZ0lDQXZMeUJwWmlCaGMzTmxkRjlwYzE5a1pXeGxkR1ZrS0dGemMyVjBYMmxrS1RvS0lDQWdJR0p1ZWlCZloyVjBYMkZ6YzJWMFgzUnBibmxmYkdGaVpXeHpYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGemMyVjBWR2x1ZVV4aFltVnNjeTVtY205dFgySjVkR1Z6S0dJaUlpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BmWjJWMFgyRnpjMlYwWDNScGJubGZiR0ZpWld4elgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTXpnS0lDQWdJQzh2SUc1aGJXVTlZakp6ZEhJb1lYTnpaWFF1Ym1GdFpTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUk9ZVzFsQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlHSXljM1J5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNemtLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDFpTW5OMGNpaGhjM05sZEM1MWJtbDBYMjVoYldVcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdZakp6ZEhJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwTUFvZ0lDQWdMeThnWkdWamFXMWhiSE05WVhKak5DNVZTVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJFWldOcGJXRnNjd29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEY2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EUXhDaUFnSUNBdkx5QnNZV0psYkhNOWMyVnNaaTVoYzNObGRITmJZWE56WlhSZExtTnZjSGtvS1NCcFppQmhjM05sZENCcGJpQnpaV3htTG1GemMyVjBjeUJsYkhObElHVnRjSFI1WDJ4cGMzUW9LU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWDJkbGRGOWhjM05sZEY5MGFXNTVYMnhoWW1Wc2MxOTBaWEp1WVhKNVgyWmhiSE5sUURRS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNncGZaMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6WDNSbGNtNWhjbmxmYldWeVoyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBNemN0TkRReUNpQWdJQ0F2THlCeVpYUjFjbTRnUVhOelpYUlVhVzU1VEdGaVpXeHpLQW9nSUNBZ0x5OGdJQ0FnSUc1aGJXVTlZakp6ZEhJb1lYTnpaWFF1Ym1GdFpTa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJeWMzUnlLR0Z6YzJWMExuVnVhWFJmYm1GdFpTa3NDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05WVhKak5DNVZTVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2JHRmlaV3h6UFhObGJHWXVZWE56WlhSelcyRnpjMlYwWFM1amIzQjVLQ2tnYVdZZ1lYTnpaWFFnYVc0Z2MyVnNaaTVoYzNObGRITWdaV3h6WlNCbGJYQjBlVjlzYVhOMEtDa3NDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOeUF2THlBM0NpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BmWjJWMFgyRnpjMlYwWDNScGJubGZiR0ZpWld4elgzUmxjbTVoY25sZlptRnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVXMkZ5WXpRdVUzUnlhVzVuWFNncENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNQW9nSUNBZ1lpQmZaMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6WDNSbGNtNWhjbmxmYldWeVoyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxtZGxkRjloYzNObGRGOTBhVzU1WDJ4aFltVnNjeWhoYzNObGREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalEwTkMwME5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmWVhOelpYUmZkR2x1ZVY5c1lXSmxiSE1vYzJWc1ppd2dZWE56WlhRNklGVkpiblEyTkNrZ0xUNGdRWE56WlhSVWFXNTVUR0ZpWld4ek9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1ZloyVjBYMkZ6YzJWMFgzUnBibmxmYkdGaVpXeHpLR0Z6YzJWMEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllYTnpaWFJmZEdsdWVWOXNZV0psYkhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYzNObGRGOXNZV0psYkdsdVp5NWpiMjUwY21GamRDNUJjM05sZEV4aFltVnNhVzVuTG1kbGRGOWhjM05sZEhOZmRHbHVlVjlzWVdKbGJITW9ZWE56WlhSek9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1oyVjBYMkZ6YzJWMGMxOTBhVzU1WDJ4aFltVnNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBORGd0TkRRNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMkZ6YzJWMGMxOTBhVzU1WDJ4aFltVnNjeWh6Wld4bUxDQmhjM05sZEhNNklHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VlVsdWREWTBYU2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMU1Bb2dJQ0FnTHk4Z1ptOXlJRjlwTENCaGMzTmxkRjlwWkNCcGJpQjFaVzUxYldWeVlYUmxLR0Z6YzJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtZGxkRjloYzNObGRITmZkR2x1ZVY5c1lXSmxiSE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMU1Bb2dJQ0FnTHk4Z1ptOXlJRjlwTENCaGMzTmxkRjlwWkNCcGJpQjFaVzUxYldWeVlYUmxLR0Z6YzJWMGN5azZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aGMzTmxkSE5mZEdsdWVWOXNZV0psYkhOZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EVXhDaUFnSUNBdkx5QnNiMmNvYzJWc1ppNWZaMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6S0dGemMyVjBYMmxrTG01aGRHbDJaU2twQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwWDJGemMyVjBYM1JwYm5sZmJHRmlaV3h6Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWjJWMFgyRnpjMlYwYzE5MGFXNTVYMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREVLQ21kbGRGOWhjM05sZEhOZmRHbHVlVjlzWVdKbGJITmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE56WlhSZmJHRmlaV3hwYm1jdVkyOXVkSEpoWTNRdVFYTnpaWFJNWVdKbGJHbHVaeTVmWjJWMFgyRnpjMlYwWDNSbGVIUW9ZWE56WlhSZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbDluWlhSZllYTnpaWFJmZEdWNGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5UVXRORFUyQ2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlGOW5aWFJmWVhOelpYUmZkR1Y0ZENoelpXeG1MQ0JoYzNObGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCQmMzTmxkRlJsZUhRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdYM1lzSUdWNGFYTjBjeUE5SUc5d0xrRnpjMlYwVUdGeVlXMXpSMlYwTG1GemMyVjBYMk55WldGMGIzSW9ZWE56WlhSZmFXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkRjbVZoZEc5eUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5UY0tJQ0FnSUM4dklHbG1JR0Z6YzJWMFgybHpYMlJsYkdWMFpXUW9ZWE56WlhSZmFXUXBPZ29nSUNBZ1ltNTZJRjluWlhSZllYTnpaWFJmZEdWNGRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTlRnS0lDQWdJQzh2SUhKbGRIVnliaUJCYzNObGRGUmxlSFF1Wm5KdmJWOWllWFJsY3loaUlpSXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCeVpYUnpkV0lLQ2w5blpYUmZZWE56WlhSZmRHVjRkRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EWXhDaUFnSUNBdkx5QnVZVzFsUFdJeWMzUnlLR0Z6YzJWMExtNWhiV1VwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVG1GdFpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJpTW5OMGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMk1nb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBXSXljM1J5S0dGemMyVjBMblZ1YVhSZmJtRnRaU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCaU1uTjBjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTJNd29nSUNBZ0x5OGdkWEpzUFdJeWMzUnlLR0Z6YzJWMExuVnliQ2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJWVWt3S0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdZakp6ZEhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTmpBdE5EWTBDaUFnSUNBdkx5QnlaWFIxY200Z1FYTnpaWFJVWlhoMEtBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOVlqSnpkSElvWVhOelpYUXVibUZ0WlNrc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQV0l5YzNSeUtHRnpjMlYwTG5WdWFYUmZibUZ0WlNrc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFdJeWMzUnlLR0Z6YzJWMExuVnliQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnTmdvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE56WlhSZmJHRmlaV3hwYm1jdVkyOXVkSEpoWTNRdVFYTnpaWFJNWVdKbGJHbHVaeTVuWlhSZllYTnpaWFJmZEdWNGRDaGhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMkZ6YzJWMFgzUmxlSFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFkyTFRRMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjloYzNObGRGOTBaWGgwS0hObGJHWXNJR0Z6YzJWME9pQlZTVzUwTmpRcElDMCtJRUZ6YzJWMFZHVjRkRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMk9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYMmRsZEY5aGMzTmxkRjkwWlhoMEtHRnpjMlYwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmWVhOelpYUmZkR1Y0ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WjJWMFgyRnpjMlYwYzE5MFpYaDBLR0Z6YzJWMGN6b2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtZGxkRjloYzNObGRITmZkR1Y0ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTnpBdE5EY3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJGemMyVjBjMTkwWlhoMEtITmxiR1lzSUdGemMyVjBjem9nWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNVZTVzUwTmpSZEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORGN5Q2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgyRnpjMlYwYzE5MFpYaDBYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wTnpJS0lDQWdJQzh2SUdadmNpQmZhU3dnWVhOelpYUmZhV1FnYVc0Z2RXVnVkVzFsY21GMFpTaGhjM05sZEhNcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmWVhOelpYUnpYM1JsZUhSZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EY3pDaUFnSUNBdkx5QnNiMmNvYzJWc1ppNWZaMlYwWDJGemMyVjBYM1JsZUhRb1lYTnpaWFJmYVdRdWJtRjBhWFpsS1NrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllYTnpaWFJmZEdWNGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaUlHZGxkRjloYzNObGRITmZkR1Y0ZEY5bWIzSmZhR1ZoWkdWeVFERUtDbWRsZEY5aGMzTmxkSE5mZEdWNGRGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhjM05sZEY5c1lXSmxiR2x1Wnk1amIyNTBjbUZqZEM1QmMzTmxkRXhoWW1Wc2FXNW5MbDluWlhSZllYTnpaWFJmZEdWNGRGOXNZV0psYkhNb1lYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNsOW5aWFJmWVhOelpYUmZkR1Y0ZEY5c1lXSmxiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORGMzTFRRM09Bb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWjJWMFgyRnpjMlYwWDNSbGVIUmZiR0ZpWld4ektITmxiR1lzSUdGemMyVjBYMmxrT2lCVlNXNTBOalFwSUMwK0lFRnpjMlYwVkdWNGRFeGhZbVZzY3pvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmZkaXdnWlhocGMzUnpJRDBnYjNBdVFYTnpaWFJRWVhKaGJYTkhaWFF1WVhOelpYUmZZM0psWVhSdmNpaGhjM05sZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnlaV0YwYjNJS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRM09Rb2dJQ0FnTHk4Z2FXWWdZWE56WlhSZmFYTmZaR1ZzWlhSbFpDaGhjM05sZEY5cFpDazZDaUFnSUNCaWJub2dYMmRsZEY5aGMzTmxkRjkwWlhoMFgyeGhZbVZzYzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBPREFLSUNBZ0lDOHZJSEpsZEhWeWJpQkJjM05sZEZSbGVIUk1ZV0psYkhNdVpuSnZiVjlpZVhSbGN5aGlJaUlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gyZGxkRjloYzNObGRGOTBaWGgwWDJ4aFltVnNjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EZ3pDaUFnSUNBdkx5QnVZVzFsUFdJeWMzUnlLR0Z6YzJWMExtNWhiV1VwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVG1GdFpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJpTW5OMGNnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRnMENpQWdJQ0F2THlCMWJtbDBYMjVoYldVOVlqSnpkSElvWVhOelpYUXVkVzVwZEY5dVlXMWxLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUdJeWMzUnlDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9EVUtJQ0FnSUM4dklIVnliRDFpTW5OMGNpaGhjM05sZEM1MWNtd3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBWVkpNQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlHSXljM1J5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzBPRFlLSUNBZ0lDOHZJR3hoWW1Wc2N6MXpaV3htTG1GemMyVjBjMXRoYzNObGRGMHVZMjl3ZVNncElHbG1JR0Z6YzJWMElHbHVJSE5sYkdZdVlYTnpaWFJ6SUdWc2MyVWdaVzF3ZEhsZmJHbHpkQ2dwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCZloyVjBYMkZ6YzJWMFgzUmxlSFJmYkdGaVpXeHpYM1JsY201aGNubGZabUZzYzJWQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpjMlYwY3lCbGJuUnllU0JsZUdsemRITUtDbDluWlhSZllYTnpaWFJmZEdWNGRGOXNZV0psYkhOZmRHVnlibUZ5ZVY5dFpYSm5aVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalE0TWkwME9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCQmMzTmxkRlJsZUhSTVlXSmxiSE1vQ2lBZ0lDQXZMeUFnSUNBZ2JtRnRaVDFpTW5OMGNpaGhjM05sZEM1dVlXMWxLU3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBYMjVoYldVOVlqSnpkSElvWVhOelpYUXVkVzVwZEY5dVlXMWxLU3dLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlZakp6ZEhJb1lYTnpaWFF1ZFhKc0tTd0tJQ0FnSUM4dklDQWdJQ0JzWVdKbGJITTljMlZzWmk1aGMzTmxkSE5iWVhOelpYUmRMbU52Y0hrb0tTQnBaaUJoYzNObGRDQnBiaUJ6Wld4bUxtRnpjMlYwY3lCbGJITmxJR1Z0Y0hSNVgyeHBjM1FvS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURnS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOW5aWFJmWVhOelpYUmZkR1Y0ZEY5c1lXSmxiSE5mZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYllYSmpOQzVUZEhKcGJtZGRLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd0NpQWdJQ0JpSUY5blpYUmZZWE56WlhSZmRHVjRkRjlzWVdKbGJITmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ6YzJWMFgyeGhZbVZzYVc1bkxtTnZiblJ5WVdOMExrRnpjMlYwVEdGaVpXeHBibWN1WjJWMFgyRnpjMlYwWDNSbGVIUmZiR0ZpWld4ektHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUmZZWE56WlhSZmRHVjRkRjlzWVdKbGJITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EZzVMVFE1TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOWhjM05sZEY5MFpYaDBYMnhoWW1Wc2N5aHpaV3htTENCaGMzTmxkRG9nVlVsdWREWTBLU0F0UGlCQmMzTmxkRlJsZUhSTVlXSmxiSE02Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9URUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDluWlhSZllYTnpaWFJmZEdWNGRGOXNZV0psYkhNb1lYTnpaWFFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRjloYzNObGRGOTBaWGgwWDJ4aFltVnNjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnpjMlYwWDJ4aFltVnNhVzVuTG1OdmJuUnlZV04wTGtGemMyVjBUR0ZpWld4cGJtY3VaMlYwWDJGemMyVjBjMTkwWlhoMFgyeGhZbVZzY3loaGMzTmxkSE02SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BuWlhSZllYTnpaWFJ6WDNSbGVIUmZiR0ZpWld4ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRNU15MDBPVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZllYTnpaWFJ6WDNSbGVIUmZiR0ZpWld4ektITmxiR1lzSUdGemMyVjBjem9nWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNVZTVzUwTmpSZEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORGsxQ2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgyRnpjMlYwYzE5MFpYaDBYMnhoWW1Wc2MxOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZORGsxQ2lBZ0lDQXZMeUJtYjNJZ1gya3NJR0Z6YzJWMFgybGtJR2x1SUhWbGJuVnRaWEpoZEdVb1lYTnpaWFJ6S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYMkZ6YzJWMGMxOTBaWGgwWDJ4aFltVnNjMTloWm5SbGNsOW1iM0pBTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wT1RZS0lDQWdJQzh2SUd4dlp5aHpaV3htTGw5blpYUmZZWE56WlhSZmRHVjRkRjlzWVdKbGJITW9ZWE56WlhSZmFXUXVibUYwYVhabEtTa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCallXeHNjM1ZpSUY5blpYUmZZWE56WlhSZmRHVjRkRjlzWVdKbGJITUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQm5aWFJmWVhOelpYUnpYM1JsZUhSZmJHRmlaV3h6WDJadmNsOW9aV0ZrWlhKQU1Rb0taMlYwWDJGemMyVjBjMTkwWlhoMFgyeGhZbVZzYzE5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMzTmxkRjlzWVdKbGJHbHVaeTVqYjI1MGNtRmpkQzVCYzNObGRFeGhZbVZzYVc1bkxsOW5aWFJmWVhOelpYUmZjMjFoYkd3b1lYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNsOW5aWFJmWVhOelpYUmZjMjFoYkd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRBd0xUVXdNUW9nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCZloyVjBYMkZ6YzJWMFgzTnRZV3hzS0hObGJHWXNJR0Z6YzJWMFgybGtPaUJWU1c1ME5qUXBJQzArSUVGemMyVjBVMjFoYkd3NkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdYM1lzSUdWNGFYTjBjeUE5SUc5d0xrRnpjMlYwVUdGeVlXMXpSMlYwTG1GemMyVjBYMk55WldGMGIzSW9ZWE56WlhSZmFXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkRjbVZoZEc5eUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1ESUtJQ0FnSUM4dklHbG1JR0Z6YzJWMFgybHpYMlJsYkdWMFpXUW9ZWE56WlhSZmFXUXBPZ29nSUNBZ1ltNTZJRjluWlhSZllYTnpaWFJmYzIxaGJHeGZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRBekNpQWdJQ0F2THlCeVpYUjFjbTRnUVhOelpYUlRiV0ZzYkM1bWNtOXRYMko1ZEdWektHSWlJaWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZloyVjBYMkZ6YzJWMFgzTnRZV3hzWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFNRFlLSUNBZ0lDOHZJRzVoYldVOVlqSnpkSElvWVhOelpYUXVibUZ0WlNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhST1lXMWxDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUdJeWMzUnlDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1EY0tJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMWlNbk4wY2loaGMzTmxkQzUxYm1sMFgyNWhiV1VwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1lqSnpkSElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVXdPQW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlZWEpqTkM1VlNXNTBPQ2hoYzNObGRDNWtaV05wYldGc2N5a3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURjZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRBNUNpQWdJQ0F2THlCMGIzUmhiRDFoY21NMExsVkpiblEyTkNoaGMzTmxkQzUwYjNSaGJDa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUlViM1JoYkFvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlluVnllU0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEV3Q2lBZ0lDQXZMeUJvWVhOZlpuSmxaWHBsUFdGeVl6UXVRbTl2YkNoaGMzTmxkQzVtY21WbGVtVWdJVDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSR2NtVmxlbVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEV4Q2lBZ0lDQXZMeUJvWVhOZlkyeGhkMkpoWTJzOVlYSmpOQzVDYjI5c0tHRnpjMlYwTG1Oc1lYZGlZV05ySUNFOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBRMnhoZDJKaFkyc0tJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5URXlDaUFnSUNBdkx5QnNZV0psYkhNOWMyVnNaaTVoYzNObGRITmJZWE56WlhSZExtTnZjSGtvS1NCcFppQmhjM05sZENCcGJpQnpaV3htTG1GemMyVjBjeUJsYkhObElHVnRjSFI1WDJ4cGMzUW9LU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWDJkbGRGOWhjM05sZEY5emJXRnNiRjkwWlhKdVlYSjVYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhjM05sZEhNZ1pXNTBjbmtnWlhocGMzUnpDZ3BmWjJWMFgyRnpjMlYwWDNOdFlXeHNYM1JsY201aGNubGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1EVXROVEV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRWE56WlhSVGJXRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCdVlXMWxQV0l5YzNSeUtHRnpjMlYwTG01aGJXVXBMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxaU1uTjBjaWhoYzNObGRDNTFibWwwWDI1aGJXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFdGeVl6UXVWVWx1ZERnb1lYTnpaWFF1WkdWamFXMWhiSE1wTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFdGeVl6UXVWVWx1ZERZMEtHRnpjMlYwTG5SdmRHRnNLU3dLSUNBZ0lDOHZJQ0FnSUNCb1lYTmZabkpsWlhwbFBXRnlZelF1UW05dmJDaGhjM05sZEM1bWNtVmxlbVVnSVQwZ1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJQ0FnYUdGelgyTnNZWGRpWVdOclBXRnlZelF1UW05dmJDaGhjM05sZEM1amJHRjNZbUZqYXlBaFBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpLU3dLSUNBZ0lDOHZJQ0FnSUNCc1lXSmxiSE05YzJWc1ppNWhjM05sZEhOYllYTnpaWFJkTG1OdmNIa29LU0JwWmlCaGMzTmxkQ0JwYmlCelpXeG1MbUZ6YzJWMGN5QmxiSE5sSUdWdGNIUjVYMnhwYzNRb0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOaUF2THlBeE5nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNVEExSUM4dklERXdOUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGZaMlYwWDJGemMyVjBYM050WVd4c1gzUmxjbTVoY25sZlptRnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVXMkZ5WXpRdVUzUnlhVzVuWFNncENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNQW9nSUNBZ1lpQmZaMlYwWDJGemMyVjBYM050WVd4c1gzUmxjbTVoY25sZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhjM05sZEY5c1lXSmxiR2x1Wnk1amIyNTBjbUZqZEM1QmMzTmxkRXhoWW1Wc2FXNW5MbWRsZEY5aGMzTmxkRjl6YldGc2JDaGhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBYMkZ6YzJWMFgzTnRZV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV4TlMwMU1UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmWVhOelpYUmZjMjFoYkd3b2MyVnNaaXdnWVhOelpYUTZJRlZKYm5RMk5Da2dMVDRnUVhOelpYUlRiV0ZzYkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVXhOd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDJkbGRGOWhjM05sZEY5emJXRnNiQ2hoYzNObGRDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFgyRnpjMlYwWDNOdFlXeHNDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlYTnpaWFJmYkdGaVpXeHBibWN1WTI5dWRISmhZM1F1UVhOelpYUk1ZV0psYkdsdVp5NW5aWFJmWVhOelpYUnpYM050WVd4c0tHRnpjMlYwY3pvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21kbGRGOWhjM05sZEhOZmMyMWhiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEU1TFRVeU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjloYzNObGRITmZjMjFoYkd3b2MyVnNaaXdnWVhOelpYUnpPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRoY21NMExsVkpiblEyTkYwcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjM05sZEY5c1lXSmxiR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFNakVLSUNBZ0lDOHZJR1p2Y2lCZmFTd2dZWE56WlhSZmFXUWdhVzRnZFdWdWRXMWxjbUYwWlNoaGMzTmxkSE1wT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSZllYTnpaWFJ6WDNOdFlXeHNYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8xTWpFS0lDQWdJQzh2SUdadmNpQmZhU3dnWVhOelpYUmZhV1FnYVc0Z2RXVnVkVzFsY21GMFpTaGhjM05sZEhNcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmWVhOelpYUnpYM050WVd4c1gyRm1kR1Z5WDJadmNrQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVXlNZ29nSUNBZ0x5OGdiRzluS0hObGJHWXVYMmRsZEY5aGMzTmxkRjl6YldGc2JDaGhjM05sZEY5cFpDNXVZWFJwZG1VcEtRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGOWhjM05sZEY5emJXRnNiQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmlJR2RsZEY5aGMzTmxkSE5mYzIxaGJHeGZabTl5WDJobFlXUmxja0F4Q2dwblpYUmZZWE56WlhSelgzTnRZV3hzWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdVgyZGxkRjloYzNObGRGOW1kV3hzS0dGemMyVjBYMmxrT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwZloyVjBYMkZ6YzJWMFgyWjFiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEkyTFRVeU53b2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWjJWMFgyRnpjMlYwWDJaMWJHd29jMlZzWml3Z1lYTnpaWFJmYVdRNklGVkpiblEyTkNrZ0xUNGdRWE56WlhSR2RXeHNPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCZmRpd2daWGhwYzNSeklEMGdiM0F1UVhOelpYUlFZWEpoYlhOSFpYUXVZWE56WlhSZlkzSmxZWFJ2Y2loaGMzTmxkRjlwWkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVOeVpXRjBiM0lLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV5T0FvZ0lDQWdMeThnYVdZZ1lYTnpaWFJmYVhOZlpHVnNaWFJsWkNoaGMzTmxkRjlwWkNrNkNpQWdJQ0JpYm5vZ1gyZGxkRjloYzNObGRGOW1kV3hzWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFRnpjMlYwUm5Wc2JDNW1jbTl0WDJKNWRHVnpLR0lpSWlrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGZaMlYwWDJGemMyVjBYMloxYkd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV6TVFvZ0lDQWdMeThnY21WelpYSjJaVjloWTJOMElEMGdRV05qYjNWdWRDaGhjM05sZEM1eVpYTmxjblpsTG1KNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU16UUtJQ0FnSUM4dklHbG1JSEpsYzJWeWRtVmZZV05qZEM1cGMxOXZjSFJsWkY5cGJpaGhjM05sZENrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8xTXpNdE5UTTFDaUFnSUNBdkx5QmhjM05sZEM1aVlXeGhibU5sS0hKbGMyVnlkbVZmWVdOamRDa0tJQ0FnSUM4dklHbG1JSEpsYzJWeWRtVmZZV05qZEM1cGMxOXZjSFJsWkY5cGJpaGhjM05sZENrS0lDQWdJQzh2SUdWc2MyVWdWVWx1ZERZMEtEQXBDaUFnSUNCaWVpQmZaMlYwWDJGemMyVjBYMloxYkd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVE16Q2lBZ0lDQXZMeUJoYzNObGRDNWlZV3hoYm1ObEtISmxjMlZ5ZG1WZllXTmpkQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnYjNCMFpXUWdhVzUwYnlCaGMzTmxkQW9LWDJkbGRGOWhjM05sZEY5bWRXeHNYM1JsY201aGNubGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU16Z0tJQ0FnSUM4dklHNWhiV1U5WWpKemRISW9ZWE56WlhRdWJtRnRaU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJPWVcxbENpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJR0l5YzNSeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8xTXprS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQxaU1uTjBjaWhoYzNObGRDNTFibWwwWDI1aGJXVXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnWWpKemRISUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVME1Bb2dJQ0FnTHk4Z2RYSnNQV0l5YzNSeUtHRnpjMlYwTG5WeWJDa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUlZVa3dLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1lqSnpkSElLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTBNUW9nSUNBZ0x5OGdkRzkwWVd3OVlYSmpOQzVWU1c1ME5qUW9ZWE56WlhRdWRHOTBZV3dwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVkc5MFlXd0tJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMkoxY25rZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVME1nb2dJQ0FnTHk4Z1pHVmphVzFoYkhNOVlYSmpOQzVWU1c1ME9DaGhjM05sZEM1a1pXTnBiV0ZzY3lrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JsZUhSeVlXTjBJRGNnTVFvZ0lDQWdabkpoYldWZlluVnllU0EzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVFF6Q2lBZ0lDQXZMeUJqY21WaGRHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loaGMzTmxkQzVqY21WaGRHOXlLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRU55WldGMGIzSUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01USUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5EUUtJQ0FnSUM4dklHMWhibUZuWlhJOVlYSmpOQzVCWkdSeVpYTnpLR0Z6YzJWMExtMWhibUZuWlhJcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFRXRnVZV2RsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F4TXdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalUwTlFvZ0lDQWdMeThnWm5KbFpYcGxQV0Z5WXpRdVFXUmtjbVZ6Y3loaGMzTmxkQzVtY21WbGVtVXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBSbkpsWlhwbENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFMENpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRRMkNpQWdJQ0F2THlCamJHRjNZbUZqYXoxaGNtTTBMa0ZrWkhKbGMzTW9ZWE56WlhRdVkyeGhkMkpoWTJzcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRBS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzNObGRGOXNZV0psYkdsdVp5OWpiMjUwY21GamRDNXdlVG8xTkRjS0lDQWdJQzh2SUhKbGMyVnlkbVU5WVhKak5DNUJaR1J5WlhOektHRnpjMlYwTG5KbGMyVnlkbVVwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVW1WelpYSjJaUW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhNUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTBPQW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVlYSmpOQzVDYjI5c0tHRnpjMlYwTG1SbFptRjFiSFJmWm5KdmVtVnVLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVFV3Q2lBZ0lDQXZMeUJ0WlhSaFpHRjBZVjlvWVhOb1BXRnlZelF1UkhsdVlXMXBZMEo1ZEdWektHRnpjMlYwTG0xbGRHRmtZWFJoWDJoaGMyZ3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUV1YwWVdSaGRHRklZWE5vQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTnpaWFJmYkdGaVpXeHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UUTVDaUFnSUNBdkx5QnlaWE5sY25abFgySmhiR0Z1WTJVOVlYSmpOQzVWU1c1ME5qUW9jbVZ6WlhKMlpWOWlZV3hoYm1ObEtTd0tJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMkoxY25rZ09Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGemMyVjBYMnhoWW1Wc2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVMU1Rb2dJQ0FnTHk4Z2JHRmlaV3h6UFhObGJHWXVZWE56WlhSelcyRnpjMlYwWFM1amIzQjVLQ2tnYVdZZ1lYTnpaWFFnYVc0Z2MyVnNaaTVoYzNObGRITWdaV3h6WlNCbGJYQjBlVjlzYVhOMEtDa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMkNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRjluWlhSZllYTnpaWFJmWm5Wc2JGOTBaWEp1WVhKNVgyWmhiSE5sUURjS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkSE1nWlc1MGNua2daWGhwYzNSekNncGZaMlYwWDJGemMyVjBYMloxYkd4ZmRHVnlibUZ5ZVY5dFpYSm5aVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV6TnkwMU5USUtJQ0FnSUM4dklISmxkSFZ5YmlCQmMzTmxkRVoxYkd3b0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlQxaU1uTjBjaWhoYzNObGRDNXVZVzFsS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlZakp6ZEhJb1lYTnpaWFF1ZFc1cGRGOXVZVzFsS1N3S0lDQWdJQzh2SUNBZ0lDQjFjbXc5WWpKemRISW9ZWE56WlhRdWRYSnNLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFoY21NMExsVkpiblEyTkNoaGMzTmxkQzUwYjNSaGJDa3NDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05WVhKak5DNVZTVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJ2Y2oxaGNtTTBMa0ZrWkhKbGMzTW9ZWE56WlhRdVkzSmxZWFJ2Y2lrc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMWhjbU0wTGtGa1pISmxjM01vWVhOelpYUXViV0Z1WVdkbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQV0Z5WXpRdVFXUmtjbVZ6Y3loaGMzTmxkQzVtY21WbGVtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFdGeVl6UXVRV1JrY21WemN5aGhjM05sZEM1amJHRjNZbUZqYXlrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMWhjbU0wTGtGa1pISmxjM01vWVhOelpYUXVjbVZ6WlhKMlpTa3NDaUFnSUNBdkx5QWdJQ0FnWkdWbVlYVnNkRjltY205NlpXNDlZWEpqTkM1Q2IyOXNLR0Z6YzJWMExtUmxabUYxYkhSZlpuSnZlbVZ1S1N3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFgySmhiR0Z1WTJVOVlYSmpOQzVWU1c1ME5qUW9jbVZ6WlhKMlpWOWlZV3hoYm1ObEtTd0tJQ0FnSUM4dklDQWdJQ0J0WlhSaFpHRjBZVjlvWVhOb1BXRnlZelF1UkhsdVlXMXBZMEo1ZEdWektHRnpjMlYwTG0xbGRHRmtZWFJoWDJoaGMyZ3BMQW9nSUNBZ0x5OGdJQ0FnSUd4aFltVnNjejF6Wld4bUxtRnpjMlYwYzF0aGMzTmxkRjB1WTI5d2VTZ3BJR2xtSUdGemMyVjBJR2x1SUhObGJHWXVZWE56WlhSeklHVnNjMlVnWlcxd2RIbGZiR2x6ZENncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTRPQ0F2THlBeE9EZ0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3WW1NS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JREV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF4TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTVRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWDJkbGRGOWhjM05sZEY5bWRXeHNYM1JsY201aGNubGZabUZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVVM1J5YVc1blhTZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TUFvZ0lDQWdZaUJmWjJWMFgyRnpjMlYwWDJaMWJHeGZkR1Z5Ym1GeWVWOXRaWEpuWlVBNENncGZaMlYwWDJGemMyVjBYMloxYkd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6YzJWMFgyeGhZbVZzYVc1bkwyTnZiblJ5WVdOMExuQjVPalV6TlFvZ0lDQWdMeThnWld4elpTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUY5blpYUmZZWE56WlhSZlpuVnNiRjkwWlhKdVlYSjVYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOelpYUmZiR0ZpWld4cGJtY3VZMjl1ZEhKaFkzUXVRWE56WlhSTVlXSmxiR2x1Wnk1blpYUmZZWE56WlhSZlpuVnNiQ2hoYzNObGREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwWDJGemMyVjBYMloxYkd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRVMExUVTFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5aGMzTmxkRjltZFd4c0tITmxiR1lzSUdGemMyVjBPaUJWU1c1ME5qUXBJQzArSUVGemMyVjBSblZzYkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpjMlYwWDJ4aFltVnNhVzVuTDJOdmJuUnlZV04wTG5CNU9qVTFOZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDJkbGRGOWhjM05sZEY5bWRXeHNLR0Z6YzJWMEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllYTnpaWFJmWm5Wc2JBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GemMyVjBYMnhoWW1Wc2FXNW5MbU52Ym5SeVlXTjBMa0Z6YzJWMFRHRmlaV3hwYm1jdVoyVjBYMkZ6YzJWMGMxOW1kV3hzS0dGemMyVjBjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbWRsZEY5aGMzTmxkSE5mWm5Wc2JEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5UZ3ROVFU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWjJWMFgyRnpjMlYwYzE5bWRXeHNLSE5sYkdZc0lHRnpjMlYwY3pvZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYllYSmpOQzVWU1c1ME5qUmRLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOelpYUmZiR0ZpWld4cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRZd0NpQWdJQ0F2THlCbWIzSWdYMmtzSUdGemMyVjBYMmxrSUdsdUlIVmxiblZ0WlhKaGRHVW9ZWE56WlhSektUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1oyVjBYMkZ6YzJWMGMxOW1kV3hzWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMzTmxkRjlzWVdKbGJHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5qQUtJQ0FnSUM4dklHWnZjaUJmYVN3Z1lYTnpaWFJmYVdRZ2FXNGdkV1Z1ZFcxbGNtRjBaU2hoYzNObGRITXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJuWlhSZllYTnpaWFJ6WDJaMWJHeGZZV1owWlhKZlptOXlRRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE56WlhSZmJHRmlaV3hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVFl4Q2lBZ0lDQXZMeUJzYjJjb2MyVnNaaTVmWjJWMFgyRnpjMlYwWDJaMWJHd29ZWE56WlhSZmFXUXVibUYwYVhabEtTa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCallXeHNjM1ZpSUY5blpYUmZZWE56WlhSZlpuVnNiQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmlJR2RsZEY5aGMzTmxkSE5mWm5Wc2JGOW1iM0pmYUdWaFpHVnlRREVLQ21kbGRGOWhjM05sZEhOZlpuVnNiRjloWm5SbGNsOW1iM0pBTkRvS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBR0FBRUNDUC8vLy84UGdJQ0FnQkFtRGdRVkgzeDFBQXRGVWxJNlRrOUZXRWxUVkFJQUFBZ0FBQUFBQUFBQUFBVmhaRzFwYmdwRlVsSTZURVZPUjFSSUNrVlNVanBGV0VsVFZGTUxSVkpTT2s1UFJVMVFWRmtDQUFJQkFBcEZVbEk2VlU1QlZWUklBZ0FCQWdBRk1SaEFBQVVuQlRFQVp6RWJRUU9tZ2lJRWp3MTlqZ1F6b3VMM0JMY3J0NDhFbDJ6ZVpBUVg1cEd1QkhabDByUUVjbFlXNXdUNndjOGJCRy9ZRkl3RXRNVUxud1NpM1NKSEJLTjk2aEVFRTFxeUhnUm84WTc2QkpmMENvb0V3dTEwUHdTbWZ3UENCSmVqSVNNRXF1NE1ZUVMydzU5b0JHTmI0MklFY0pPeERRUndySm10Qk5taXZad0Vkc1pTamdSUjkzdi9CQ0RaOGt3RVZVQzRDZ1FIRU9YRUJHOFh6ZFVFZWt6a3VRUTJiRkd2QkRTa2o3d0VBN3FZMnpZYUFJNGlBcDhDZ1FKcUFrd0NPZ0lrQWhVQi9RSGdBY2dCc2dHYUFZVUJiUUZTQVR3QktRRWFBUVlBOXdEakFOUUF3QUN4QUowQWpnQjZBR3NBVndCSUFEUUFKUUFSQUFJaVF6RVpGRVF4R0VRMkdnR0lEN2dqUXpFWkZFUXhHRVEyR2dFWGlBK2ZLRXhRc0NORE1Sa1VSREVZUkRZYUFZZ09MeU5ETVJrVVJERVlSRFlhQVJlSURoWW9URkN3STBNeEdSUkVNUmhFTmhvQmlBMHFJME14R1JSRU1SaEVOaG9CRjRnTkVTaE1VTEFqUXpFWkZFUXhHRVEyR2dHSURGSWpRekVaRkVReEdFUTJHZ0VYaUF3NUtFeFFzQ05ETVJrVVJERVlSRFlhQVlnTHNpTkRNUmtVUkRFWVJEWWFBUmVJQzVrb1RGQ3dJME14R1JSRU1SaEVOaG9CaUFyakkwTXhHUlJFTVJoRU5ob0JGNGdLeWloTVVMQWpRekVaRkVReEdFUTJHZ0dJQ2t3alF6RVpGRVF4R0VRMkdnRVhpQW96S0V4UXNDTkRNUmtVUkRFWVJEWWFBWWdKblNORE1Sa1VSREVZUkRZYUFSZUlDWVFvVEZDd0kwTXhHUlJFTVJoRU5ob0JpQWtMSTBNeEdSUkVNUmhFTmhvQmlBaVhLRXhRc0NORE1Sa1VSREVZUkRZYUFSZkFNSWdJYXloTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ1Z3SUFpQWd5RmloTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVh3RENJQjBRalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dLSUJ2OGpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVh3RENJQnRjalF6RVpGRVF4R0VRMkdnRVh3QnlJQmNZb1RGQ3dJME14R1JSRU1SaEVOaG9CRjhBY05ob0NWd0lBaUFTd0kwTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ1Z3SUFpQVJwRmloTVVMQWpRekVaRkVReEdFUTJHZ0VYd0J3MkdnSlhBZ0NJQTlNalF6RVpGRVF4R0VRMkdnR0lBdndqUXpFWkZFUXhHRVEyR2dGWEFnQ0lBdGNvVEZDd0kwTXhHUlJFTVJoRU5ob0JWd0lBaUFLSkkwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQWlBSDZJME14R1JSRU1SaEVOaG9CVndJQWlBSFRGaWhNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ05YQWdDSUFWb2pRekVaRkVReEdFUTJHZ0VYd0J5SUFUd2pRekVaalFZQUUvMC8vVC85UHdBTEFBTkMvVHd4R0VTSUFRMGpRekVZUklnQkFTTkRNUmdVUkNORGlnTUJpLzBpV1VtTC93aE1KQXNrQ0VzQkZsY0dBazRDaS8wa1N3SlNpLzhrQzY5UWkvMFZpLzFQQTA4Q1VsQ0wvbEJNSkF0SklreUxBNHNDREVFQUk0c0VTUlpYQmdLTEFZc0RTVTRFVHdKZFNZd0JTd0ZaSkFnSWpBUWtDSXdEUXYvVml3Q0xBVkNNQUltS0JBRXBTWXYrSkF1TC9DUUxJb3NFaXdNTVFRQWNpLzJMQkVsT0FsbUxBZ2dXVndZQ2l3Rk1VSXdCSkFpTUJFTC8zSXY5Rll3QUlvd0Vpd1NMQWd4QkFCeUwvNHNFU1U0Q1dZc0FDQlpYQmdLTEFVeFFqQUVrQ0l3RVF2L2NpL3lML2dnV1Z3WUNpd0ZRaS8yTEE0c0FVbENML3hXTC80c0NUd0pTVUl3QWlZb0JBWXYvRlJaWEJnS0wvMUNKaUFBRmlZZ0FBWWt4QUNJbkJXVkVFa0FBQkNjTHNBQ0ppZ0VBaVAvcUp3V0wvMmVKaWdNQWlQL2VpLzI5UlFGQkFBUW5CN0FBaS8wVkpCSkFBQVFuQnJBQWkvNFZGbGNHQW92K1VJdi9GUlpYQmdLTC8xQkxBUldCRkFnV1Z3WUNnQUlBRkV4UUp3UlFKd1JRVHdKUVRGQ0wvYnhJaS8xTXY0bUtBUUdML3hVa0VrQUFCQ2NHc0FDTC83MUZBWW1LQXdDSS8zT0wvYjFGQVVBQUF5cXdBSXY5dmtTTC9oVVdWd1lDaS81UVN3RWlXVXNDSWtzQ1dFc0RKRmxMQkJWUEJVc0NUd0pTVHdKTEJGQk1VRXhQQWdsUEFoVkxBaVJaQ0V3SkZsY0dBbHdDaS84VkZsY0dBb3YvVUVzQkpGbFBBaUpQQWxoTVVJdjl2RWlML1V5L2lZb0JBSWovQW92L3ZVVUJRQUFES3JBQWkvKytSRmNNQ0NjRXFFQUFCQ2NJc0FDTC83NUVWd1FJSndTb1FBQUVKd2l3QUl2L3ZFaUppZ0VCaS8rOVJRRkFBQU1xc0FDTC83NUVpWW9CQUl2L0lsa2lpd0dMQUF4QkFDS0wvMWNDQUlzQlNVNENKQXRMQVV4WlNsa2tDRmhYQWdDK1JMQWpDSXdCUXYvV2lZb0JBREVBSWljRlpVUVNRUUFCaVl2L2lBQUJpWW9CQURFQWkvK0lBQnhKSVFVVFFRQVJpd0FoQkJOQkFBa2pRQUFFSnd1d0FJa2lRdi8waWdJQklpbEppLzY5UlFGQUFBVWhCWXdBaVl2K3ZreEpUZ0tNQUVRaVdZd0JJb3dDaXdLTEFReEJBQ21MQUZjQ0FJc0NKQXRMQVV4WlNsa2tDRmhYQWdDTC94SkJBQVdMQW93QWlZc0NJd2lNQWtML3p5RUVqQUNKaWdJQWkvK0kvMk9MLzcxRkFVQUFBeXF3QUl2K3ZVVUJRUUJCaS82TC80ai9oQ0VFRWtBQUJDY0hzQUNML3I1RWkvOFZGbGNHQW92L1VDT0kvTGFML3J4SWkvNU12NHYvdmtSSmdReGJJd2dXWEF5TC83eElpLzlNdjRtTC94VVdWd1lDaS85UUp3bE1VQ2NNVEZDTC9yeElpLzVNdjBML3pZb0NBU21ML3hVa0VrQUFCQ2NHc0FDTC9vdi9pUDhXU1l3QUlRVVRRUUFMaXdBaEJCTkJBQU1qVElraVF2LzZpZ0lBSWtjRUtVY0NpLytJL3JXTC83MUZBVUFBQXlxd0FJdit2VVVCUUFBREtyQUFpLzZMLzRqKzAwbU1CeUVFRTBFQXdvc0hJUVVUUVFDNkkwQUFBeXF3QUl2L3ZreEpUZ0tNQUVSWERBaUFDQUFBQUFBQUFBQUJwVUFBQzRzQVZ3UUlKd1NvUVFDSkkwQUFCQ2NJc0FDTEFFbUJERnNqQ1JaY0RJdi92RWlMLzB5L2kvNitSQ0paSXhKQkFBV0wvcnhJaVN1TUFvdit2a3hKVGdLTUFVUWlXWXdGSW93R2l3YUxCUXhCQURpTEFWY0NBSXNHU1U0Q0pBdExBVXhaU2xra0NGaU1CSXNIRTRzQ2pBTkJBQXFMQW9zRUk0ajdjNHdEaXdPTUFvc0dJd2lNQmtML3dJdit2RWlML29zQ3Y0a2lRdjkwSWtML1E0b0JBWXYvdlVVQlFRQUZpLysrUklrcmlZb0NBU0pKS1VtTC94VWtFa0FBQkNjR3NBQ0wvaFpKakFHOVJRRkFBQVVoQll3QWlZc0J2a3hKVGdLTUFFUWlXWXdDSW93RGl3T0xBZ3hCQUNtTEFGY0NBSXNESkF0TEFVeFpTbGtrQ0ZoWEFnQ0wveEpCQUFXTEE0d0FpWXNESXdpTUEwTC96eUVFakFDSmlnSUFJb3YvY1F0RkFVQUFBeXF3QUl2K3ZVVUJRQUFES3JBQWkvOFdTWXdBdlVVQlFRQS9pLytML29qL1p5RUVFa0FBQkNjSHNBQ0xBRW0rUkl2K0ZSWlhCZ0tML2xBamlQcUtTd0c4U0wrTC9yNUVTWUVFV3lNSUZsd0VpLzY4U0l2K1RMK0ppLzRWRmxjR0FvditVQ2NKVEZBbkRFeFFpd0JKdkVoTXYwTC96b29DQUl2K2lQelhpLzZMLzRqL2I0bUtBZ0NML29qOHg0di9JbGtpaXdHTEFBeEJBQnFMLzFjQ0FJc0JTVTRDSlF0YmkvNU1pUDlHSXdpTUFVTC8zb21LQWdBaVJ3TXBSd0tML3IxRkFVQUFBeXF3QUl2K2lQeUdJb3dHaS84V1NZd0R2a1FpV1NNU1FRQklpd08rUkVsWEFnQk1JbGxFU1NKWlNsa2tDRmhYQWdDTC9oSkJBQ1dMQTd4SUk0d0dpd1pBQUFNcXNBQ0wvcjVFU1lFRVd5TUpGbHdFaS82OFNJditUTCtKSW93R1F2L2NLNHdCaXdPK1RFbE9Bb3dBUkNKWmpBVWlqQVNMQklzRkRFRUFONHNBVndJQWl3UWtDMHNCVEZsS1dTUUlXRW1NQWxjQ0FJditFMEVBRTRzQml3SWppUGxlakFHTEJDTUlqQVJDLzhjampBWkMvL0dMQTBtOFNJc0J2MEwvZm9vQ0FZditpLytJL2ZoSklRVVRRUUFMaXdBaEJCTkJBQU1qVElraVRJbUtBUUdML3haSnZVVUJRUUFHaXdDK1JFeUpLMHlKaWdFQklpdUwveUpaSW9zRGl3SU1RUUJPaS85WEFnQ0xBeVVMV3haSmpBQzlSUUZCQUNLTEFMNUVKd2xNVUlzQlNTSlpURmNDQUNOUEE0ajVPNHdCaXdNakNJd0RRdi9DaXdGSklsbE1Wd0lBSTRBRUFBSUFBSWo1SFl3QlF2L2Zpd0dNQUltS0FRQWlpLzhpV1NLTEFvc0JERUVBSjR2L1Z3SUFpd0lsQzFzV1NZd0F2VVVCUVFBT2l3QytSTENMQWlNSWpBSkMvOVlyc0VMLzhvbUtBUUdMLzNFTFJRRkFBQUlwaVl2L2NRTkVpUGxFaS85eEFVUVdTWk1sRGtSWEJ3R0FBZ0FEVEZCTVVJbUtBUUdMLzRqL3k0bUtBUUNML3lKWklvc0Jpd0FNUVFBWWkvOVhBZ0NMQVVsT0FpVUxXNGovcXJBakNJd0JRdi9naVlvQkFTSkhBb3YvY1F0RkFVQUFCQ21NQUltTC8zRURSSWo0NEl3QWkvOXhBVVFXU1pNbERrUlhCd0dNQW92L0ZrbU1BYjFGQVVFQUhZc0J2a1NMQUVrVmdRVUlKdzJMQWxCTUZsY0dBbEJNVUV4UWpBQ0pLMEwvNDRvQkFZdi9pUCtlaVlvQkFJdi9JbGtpaXdHTEFBeEJBQmlMLzFjQ0FJc0JTVTRDSlF0YmlQOTlzQ01JakFGQy8rQ0ppZ0VCaS85eEMwVUJRQUFDS1ltTC8zRUVSSWo0V1l2L2NRTkVpUGhSaS85eEFVUVdTWk1sRGtSWEJ3RkxBaFdCQlFnV1Z3WUNKdzFNVUV4UVR3SlFURkNKaWdFQmkvK0kvN2FKaWdFQWkvOGlXU0tMQVlzQURFRUFHSXYvVndJQWl3RkpUZ0lsQzF1SS81V3dJd2lNQVVMLzRJbUtBUUVpUndPTC8zRUxSUUZBQUFRcGpBQ0ppLzl4QkVTSTkrQ01BSXYvY1FORWlQZldqQUdMLzNFQlJCWkpreVVPUkZjSEFZd0RpLzhXU1l3Q3ZVVUJRUUF6aXdLK1JJc0FTUldCQndoSkZsY0dBb0FDQUFkTVVJc0JTVTRERlU4Q0NFeUxBMUJNRmxjR0FsQlBBbEJNVUV4UWpBQ0pLMEwvellvQkFZdi9pUDkraVlvQkFJdi9JbGtpaXdHTEFBeEJBQmlMLzFjQ0FJc0JTVTRDSlF0YmlQOWRzQ01JakFGQy8rQ0ppZ0VCaS85eEMwVUJRQUFDS1ltTC8zRUVSSWozT1l2L2NRTkVpUGN4aS85eEJVU0k5eWxMQWhXQkJnaEpGbGNHQW9BQ0FBWk1VRXNERlU4Q0NCWlhCZ0pRVHdOUVR3SlFURkNKaWdFQmkvK0kvNjJKaWdFQWkvOGlXU0tMQVlzQURFRUFHSXYvVndJQWl3RkpUZ0lsQzF1SS80eXdJd2lNQVVMLzRJbUtBUUVpUndPTC8zRUxSUUZBQUFRcGpBQ0ppLzl4QkVTSTlyZU1BSXYvY1FORWlQYXRqQUdMLzNFRlJJajJvNHdDaS84V1NZd0R2VVVCUVFCQ2l3TytSSXNBU1JVbENFa1dWd1lDZ0FJQUNFeFFpd0ZKVGdNVlR3SUlTUlpYQmdKUEFreFFpd0pKVGdNVlR3SUlGbGNHQWxCUEExQlBBbEJNVUV4UWpBQ0pLMEwvdm9vQkFZdi9pUDkxaVlvQkFJdi9JbGtpaXdHTEFBeEJBQmlMLzFjQ0FJc0JTVTRDSlF0YmlQOVVzQ01JakFGQy8rQ0ppZ0VCSWtjR2kvOXhDMFVCUUFBRUtZd0FpWXYvY1FSRWlQWUNqQUtMLzNFRFJJajErSXdEaS85eEFVUVdTWk1sRGtSWEJ3R01CWXYvY1FCRUZvd0dpLzl4Q1VReUF4TW5DaUpQQWxTTUFJdi9jUXBFTWdNVEp3b2lUd0pVakFHTC94WkpqQVM5UlFGQkFFR0xCTDVFaXdKSkZZRVFDRWtXVndZQ2dBSUFFRXhRaXdOSlRnTVZUd0lJVElzRlVJc0dVSXNBVUlzQklsT0JhVXhVVEJaWEJnSlFUd0pRVEZCTVVJd0FpU3RDLzcrS0FRR0wvNGovU0ltS0FRQ0wveUpaSW9zQml3QU1RUUFZaS85WEFnQ0xBVWxPQWlVTFc0ai9KN0FqQ0l3QlF2L2dpWW9CQVNKSERvdi9jUXRGQVVBQUJDbU1BSW1MLzNFSVRFbE9Bb3dDUkl2L2NBQkZBVUVCQ1lzQ2kvOXdBRVNMLzNFRVJJajFCWXdEaS85eEEwU0k5UHVNQkl2L2NRVkVpUFR4akFXTC8zRUFSQmFNQ0l2L2NRRkVGa21USlE1RVZ3Y0JqQWVMLzNFTFRJd01SSXYvY1FkTWpBMUVpLzl4Q1V5TURrU0wvM0VLVEl3S1JJdi9jUWhNakF0RWkvOXhBa1FuQ2lKUEFsU01BSXYvY1FaRVNSVVdWd1lDVEZDTUFSYU1DWXYvRmttTUJyMUZBVUVBZFlzR3ZrU0xBMGtWZ2J3QkNFa1dWd1lDZ0FJQXZFeFFpd1JKVGdNVlR3SUlTUlpYQmdKUEFreFFpd1ZKVGdNVlR3SUlUSXNJVUlzSFVJc01VSXNOVUlzT1VJc0tVSXNMVUlzQVVFc0JGbGNHQWxDTEFVbE9BeFZQQWdoTWl3bFFUQlpYQmdKUVR3UlFUd05RVHdKUVRGQk1VSXdBaVN0Qy80c2lRdjc2aWdFQmkvK0kvc1NKaWdFQWkvOGlXU0tMQVlzQURFRUFHSXYvVndJQWl3RkpUZ0lsQzF1SS9xT3dJd2lNQVVMLzRJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo2LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
