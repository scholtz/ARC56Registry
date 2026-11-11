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

namespace Arc56.Generated.d13co.abel_ghost_sdk.AbelReader_2642c34c
{


    public class AbelReaderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbelReaderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class BalanceInfo : AVMObjectType
            {
                public ulong Balance { get; set; }

                public ulong MinBalance { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinBalance.From(MinBalance);
                    ret.AddRange(vMinBalance.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BalanceInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BalanceInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinBalance = vMinBalance.ToValue();
                    if (valueMinBalance is ulong vMinBalanceValue) { ret.MinBalance = vMinBalanceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BalanceInfo);
                }
                public bool Equals(BalanceInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BalanceInfo left, BalanceInfo right)
                {
                    return EqualityComparer<BalanceInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(BalanceInfo left, BalanceInfo right)
                {
                    return !(left == right);
                }

            }

            public class BlockTimeAndTc : AVMObjectType
            {
                public uint Ts { get; set; }

                public ulong Tc { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vTs.From(Ts);
                    ret.AddRange(vTs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTc.From(Tc);
                    ret.AddRange(vTc.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BlockTimeAndTc Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BlockTimeAndTc();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vTs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTs = vTs.ToValue();
                    if (valueTs is uint vTsValue) { ret.Ts = vTsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTc = vTc.ToValue();
                    if (valueTc is ulong vTcValue) { ret.Tc = vTcValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BlockTimeAndTc);
                }
                public bool Equals(BlockTimeAndTc? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BlockTimeAndTc left, BlockTimeAndTc right)
                {
                    return EqualityComparer<BlockTimeAndTc>.Default.Equals(left, right);
                }
                public static bool operator !=(BlockTimeAndTc left, BlockTimeAndTc right)
                {
                    return !(left == right);
                }

            }

            public class PactInfo : AVMObjectType
            {
                public byte Type { get; set; }

                public ulong Asset1Id { get; set; }

                public string Asset1UnitName { get; set; }

                public ulong Asset2Id { get; set; }

                public string Asset2UnitName { get; set; }

                public ulong FeeBps { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vType.From(Type);
                    ret.AddRange(vType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset1Id.From(Asset1Id);
                    ret.AddRange(vAsset1Id.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset1UnitName.From(Asset1UnitName);
                    stringRef[ret.Count] = vAsset1UnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset2Id.From(Asset2Id);
                    ret.AddRange(vAsset2Id.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset2UnitName.From(Asset2UnitName);
                    stringRef[ret.Count] = vAsset2UnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBps.From(FeeBps);
                    ret.AddRange(vFeeBps.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PactInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PactInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueType = vType.ToValue();
                    if (valueType is byte vTypeValue) { ret.Type = vTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset1Id.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset1Id = vAsset1Id.ToValue();
                    if (valueAsset1Id is ulong vAsset1IdValue) { ret.Asset1Id = vAsset1IdValue; }
                    var indexAsset1UnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset1UnitName.Decode(bytes.Skip(indexAsset1UnitName + prefixOffset).ToArray());
                    var valueAsset1UnitName = vAsset1UnitName.ToValue();
                    if (valueAsset1UnitName is string vAsset1UnitNameValue) { ret.Asset1UnitName = vAsset1UnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset2Id.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset2Id = vAsset2Id.ToValue();
                    if (valueAsset2Id is ulong vAsset2IdValue) { ret.Asset2Id = vAsset2IdValue; }
                    var indexAsset2UnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset2UnitName.Decode(bytes.Skip(indexAsset2UnitName + prefixOffset).ToArray());
                    var valueAsset2UnitName = vAsset2UnitName.ToValue();
                    if (valueAsset2UnitName is string vAsset2UnitNameValue) { ret.Asset2UnitName = vAsset2UnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBps = vFeeBps.ToValue();
                    if (valueFeeBps is ulong vFeeBpsValue) { ret.FeeBps = vFeeBpsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PactInfo);
                }
                public bool Equals(PactInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PactInfo left, PactInfo right)
                {
                    return EqualityComparer<PactInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PactInfo left, PactInfo right)
                {
                    return !(left == right);
                }

            }

            public class TinymanInfo : AVMObjectType
            {
                public bool ValidRekey { get; set; }

                public ulong Asset1Id { get; set; }

                public string Asset1UnitName { get; set; }

                public ulong Asset2Id { get; set; }

                public string Asset2UnitName { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidRekey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vValidRekey.From(ValidRekey);
                    ret.AddRange(vValidRekey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset1Id.From(Asset1Id);
                    ret.AddRange(vAsset1Id.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset1UnitName.From(Asset1UnitName);
                    stringRef[ret.Count] = vAsset1UnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset2Id.From(Asset2Id);
                    ret.AddRange(vAsset2Id.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset2UnitName.From(Asset2UnitName);
                    stringRef[ret.Count] = vAsset2UnitName.Encode();
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

                public static TinymanInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TinymanInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidRekey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vValidRekey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidRekey = vValidRekey.ToValue();
                    if (valueValidRekey is bool vValidRekeyValue) { ret.ValidRekey = vValidRekeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset1Id.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset1Id = vAsset1Id.ToValue();
                    if (valueAsset1Id is ulong vAsset1IdValue) { ret.Asset1Id = vAsset1IdValue; }
                    var indexAsset1UnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset1UnitName.Decode(bytes.Skip(indexAsset1UnitName + prefixOffset).ToArray());
                    var valueAsset1UnitName = vAsset1UnitName.ToValue();
                    if (valueAsset1UnitName is string vAsset1UnitNameValue) { ret.Asset1UnitName = vAsset1UnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2Id = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset2Id.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset2Id = vAsset2Id.ToValue();
                    if (valueAsset2Id is ulong vAsset2IdValue) { ret.Asset2Id = vAsset2IdValue; }
                    var indexAsset2UnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2UnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAsset2UnitName.Decode(bytes.Skip(indexAsset2UnitName + prefixOffset).ToArray());
                    var valueAsset2UnitName = vAsset2UnitName.ToValue();
                    if (valueAsset2UnitName is string vAsset2UnitNameValue) { ret.Asset2UnitName = vAsset2UnitNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TinymanInfo);
                }
                public bool Equals(TinymanInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TinymanInfo left, TinymanInfo right)
                {
                    return EqualityComparer<TinymanInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(TinymanInfo left, TinymanInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="accounts"> </param>
        public async Task<Structs.BalanceInfo> GetBalanceInfo(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 119, 169, 103 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.SimApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BalanceInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBalanceInfo_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 119, 169, 103 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetIds"> </param>
        /// <param name="abelAppId"> </param>
        public async Task<Structs.AssetTinyLabels> GetAssetsTiny(ulong[] assetIds, ulong abelAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 171, 51, 102 };
            var assetIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetIdsAbi.From(assetIds);
            var abelAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); abelAppIdAbi.From(abelAppId);

            var result = await base.SimApp(new List<object> { abiHandle, assetIdsAbi, abelAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetTinyLabels.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssetsTiny_Transactions(ulong[] assetIds, ulong abelAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 171, 51, 102 };
            var assetIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetIdsAbi.From(assetIds);
            var abelAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); abelAppIdAbi.From(abelAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdsAbi, abelAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetId"> </param>
        public async Task<string[]> GetAssetLabels(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { assetId });
            byte assetIdRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 194, 237, 116, 63 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetIdAbi.From(assetId);

            var result = await base.SimApp(new List<object> { abiHandle, assetIdRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToStringArray();

        }

        public async Task<List<Transaction>> GetAssetLabels_Transactions(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { assetId });
            byte assetIdRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 194, 237, 116, 63 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstRound"> </param>
        /// <param name="lastRound"> </param>
        public async Task<Structs.BlockTimeAndTc> GetBlockTimesAndTc(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 14, 98, 160 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            var result = await base.SimApp(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BlockTimeAndTc.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBlockTimesAndTc_Transactions(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 14, 98, 160 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="accounts"> </param>
        public async Task<Algorand.Address> GetAuthAddrs(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 248, 214, 23 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.SimApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAuthAddrs_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 248, 214, 23 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tinymanAppId"> </param>
        /// <param name="lpEscrows"> </param>
        public async Task<Structs.TinymanInfo> GetTinymanInfo(ulong tinymanAppId, Algorand.Address[] lpEscrows, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 43, 11, 186 };
            var tinymanAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tinymanAppIdAbi.From(tinymanAppId);
            var lpEscrowsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); lpEscrowsAbi.From(lpEscrows);

            var result = await base.SimApp(new List<object> { abiHandle, tinymanAppIdAbi, lpEscrowsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TinymanInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTinymanInfo_Transactions(ulong tinymanAppId, Algorand.Address[] lpEscrows, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 43, 11, 186 };
            var tinymanAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tinymanAppIdAbi.From(tinymanAppId);
            var lpEscrowsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); lpEscrowsAbi.From(lpEscrows);

            return await base.MakeTransactionList(new List<object> { abiHandle, tinymanAppIdAbi, lpEscrowsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="constantProductCreator"> </param>
        /// <param name="stableswapCreator"> </param>
        /// <param name="managedWeightedCreator"> </param>
        /// <param name="pactAppIds"> </param>
        public async Task<Structs.PactInfo> GetPactInfo(Algorand.Address constantProductCreator, Algorand.Address stableswapCreator, Algorand.Address managedWeightedCreator, ulong[] pactAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 40, 215, 144 };
            var constantProductCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); constantProductCreatorAbi.From(constantProductCreator);
            var stableswapCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stableswapCreatorAbi.From(stableswapCreator);
            var managedWeightedCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managedWeightedCreatorAbi.From(managedWeightedCreator);
            var pactAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); pactAppIdsAbi.From(pactAppIds);

            var result = await base.SimApp(new List<object> { abiHandle, constantProductCreatorAbi, stableswapCreatorAbi, managedWeightedCreatorAbi, pactAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PactInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPactInfo_Transactions(Algorand.Address constantProductCreator, Algorand.Address stableswapCreator, Algorand.Address managedWeightedCreator, ulong[] pactAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 40, 215, 144 };
            var constantProductCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); constantProductCreatorAbi.From(constantProductCreator);
            var stableswapCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stableswapCreatorAbi.From(stableswapCreator);
            var managedWeightedCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managedWeightedCreatorAbi.From(managedWeightedCreator);
            var pactAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); pactAppIdsAbi.From(pactAppIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, constantProductCreatorAbi, stableswapCreatorAbi, managedWeightedCreatorAbi, pactAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJlbFJlYWRlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBc3NldFRpbnlMYWJlbHMiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InVuaXRfbmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZWNpbWFscyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImxhYmVscyIsInR5cGUiOiJzdHJpbmdbXSJ9XSwiQmFsYW5jZUluZm8iOlt7Im5hbWUiOiJiYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1pbkJhbGFuY2UiLCJ0eXBlIjoidWludDY0In1dLCJCbG9ja1RpbWVBbmRUYyI6W3sibmFtZSI6InRzIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6InRjIiwidHlwZSI6InVpbnQ2NCJ9XSwiUGFjdEluZm8iOlt7Im5hbWUiOiJ0eXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYXNzZXQxSWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXQxVW5pdE5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYXNzZXQySWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXQyVW5pdE5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmVlQnBzIiwidHlwZSI6InVpbnQ2NCJ9XSwiVGlueW1hbkluZm8iOlt7Im5hbWUiOiJ2YWxpZFJla2V5IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJhc3NldDFJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldDFVbml0TmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhc3NldDJJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldDJVbml0TmFtZSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0QmFsYW5jZUluZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQmFsYW5jZUluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFzc2V0c1RpbnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWJlbEFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHVpbnQ4LHN0cmluZ1tdKSIsInN0cnVjdCI6IkFzc2V0VGlueUxhYmVscyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0X2xhYmVscyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QmxvY2tUaW1lc0FuZFRjIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDMyLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJCbG9ja1RpbWVBbmRUYyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QXV0aEFkZHJzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VGlueW1hbkluZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlueW1hbkFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJscEVzY3Jvd3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0LHN0cmluZyx1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IlRpbnltYW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQYWN0SW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc3RhbnRQcm9kdWN0Q3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZXN3YXBDcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFuYWdlZFdlaWdodGVkQ3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYWN0QXBwSWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50OCx1aW50NjQsc3RyaW5nLHVpbnQ2NCxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlBhY3RJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJVcGRhdGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM5M10sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgb25lIG9mIFVwZGF0ZUFwcGxpY2F0aW9uLCBEZWxldGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzYzXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA4LDQxNSw0MThdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzAsMjk3LDY3Miw3ODJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOSwyNTYsNjM4LDc0OCwxMDQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxLDY1MCw3NjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFjY291bnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXBwbGljYXRpb24+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhc3NldD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI1LDEwMzMsMTA0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzYsMzk4LDU2NSw1NzQsNzM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQsNTkzLDE0NTJdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdnVkUxUVRGOVZVRVJCVkVGQ1RFVUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lpSWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURGa01EQXdNREF3TURBd01EQXdNREF3TURBd01XWXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNREZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRmlaV3hTWldGa1pYSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aFpHMXBiazl1YkhsQU1UUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TkRnM04yRTVOamNnTUhoa05XRmlNek0yTmlBd2VHTXlaV1EzTkRObUlEQjRZVGN3WlRZeVlUQWdNSGhqTW1ZNFpEWXhOeUF3ZURjME1tSXdZbUpoSURCNE9UUXlPR1EzT1RBZ0x5OGdiV1YwYUc5a0lDSm5aWFJDWVd4aGJtTmxTVzVtYnloaFpHUnlaWE56VzEwcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUkJjM05sZEhOVWFXNTVLSFZwYm5RMk5GdGRMSFZwYm5RMk5Da29jM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBPQ3h6ZEhKcGJtZGJYU2tpTENCdFpYUm9iMlFnSW1kbGRGOWhjM05sZEY5c1lXSmxiSE1vWVhOelpYUXBjM1J5YVc1blcxMGlMQ0J0WlhSb2IyUWdJbWRsZEVKc2IyTnJWR2x0WlhOQmJtUlVZeWgxYVc1ME5qUXNkV2x1ZERZMEtTaDFhVzUwTXpJc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBRWFYwYUVGa1pISnpLR0ZrWkhKbGMzTmJYU2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0puWlhSVWFXNTViV0Z1U1c1bWJ5aDFhVzUwTmpRc1lXUmtjbVZ6YzF0ZEtTaGliMjlzTEhWcGJuUTJOQ3h6ZEhKcGJtY3NkV2x1ZERZMExITjBjbWx1WnlraUxDQnRaWFJvYjJRZ0ltZGxkRkJoWTNSSmJtWnZLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkZ0ZEtTaDFhVzUwT0N4MWFXNTBOalFzYzNSeWFXNW5MSFZwYm5RMk5DeHpkSEpwYm1jc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHZGxkRUpoYkdGdVkyVkpibVp2SUdkbGRFRnpjMlYwYzFScGJua2daMlYwUVhOelpYUk1ZV0psYkhNZ1oyVjBRbXh2WTJ0VWFXMWxjMEZ1WkZSaklHZGxkRUYxZEdoQlpHUnljeUJuWlhSVWFXNTViV0Z1U1c1bWJ5Qm5aWFJRWVdOMFNXNW1id29nSUNBZ1pYSnlDZ3B0WVdsdVgyRmtiV2x1VDI1c2VVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJBWW1GeVpXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlJc0lDSkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjMmhzQ2lBZ0lDQndkWE5vYVc1MElEUTRJQzh2SURRNENpQWdJQ0FtQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCdmJtVWdiMllnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRzSUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WR1Z0Y0d4aGRHVldZWEk4ZFdsdWREWTBQaWdpVlZCRVFWUkJRa3hGSWlrZ1BUMDlJREVnSmlZZ1ZIaHVMbk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOektUc0tJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZRUkVGVVFVSk1SUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBTVRnS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKNklHMWhhVzVmWW05dmJGOW1ZV3h6WlVBeE9Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCQVltRnlaVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5SlZjR1JoZEdWQmNIQnNhV05oZEdsdmJpSXNJQ0pFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkSUgwcENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZiRjltWVd4elpVQXhPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdRR0poY21WdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpTENBaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTQjlLUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbWRsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhSSlpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwUVhOelpYUlZibWwwVG1GdFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdOUW9nSUNBZ0x5OGdablZ1WTNScGIyNGdaMlYwUVhOelpYUlZibWwwVG1GdFpTaGhjM05sZEVsa09pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekEzQ2lBZ0lDQXZMeUJwWmlBb1lYTnpaWFJKWkNBOVBUMGdNQ2tnY21WMGRYSnVJQ0pCVEVkUElqc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW01NklHZGxkRUZ6YzJWMFZXNXBkRTVoYldWZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa0ZNUjA4aUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEVGemMyVjBWVzVwZEU1aGJXVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RXdDaUFnSUNBdkx5QmpiMjV6ZENCYmRXNXBkRTVoYldVc0lHVjRhWE4wYzEwZ1BTQnZjQzVCYzNObGRGQmhjbUZ0Y3k1aGMzTmxkRlZ1YVhST1lXMWxLR0Z6YzJWMFNXUXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RXhDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUQ4Z2RXNXBkRTVoYldVdWRHOVRkSEpwYm1jb0tTQTZJQ0lpT3dvZ0lDQWdZbm9nWjJWMFFYTnpaWFJWYm1sMFRtRnRaVjkwWlhKdVlYSjVYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NncG5aWFJCYzNObGRGVnVhWFJPWVcxbFgzUmxjbTVoY25sZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdWNGFYTjBjeUEvSUhWdWFYUk9ZVzFsTG5SdlUzUnlhVzVuS0NrZ09pQWlJanNLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1oyVjBRWE56WlhSVmJtbDBUbUZ0WlY5MFpYSnVZWEo1WDJaaGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVRFS0lDQWdJQzh2SUhKbGRIVnliaUJsZUdsemRITWdQeUIxYm1sMFRtRnRaUzUwYjFOMGNtbHVaeWdwSURvZ0lpSTdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaUlHZGxkRUZ6YzJWMFZXNXBkRTVoYldWZmRHVnlibUZ5ZVY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZpWld4U1pXRmtaWEl1WjJWMFFtRnNZVzVqWlVsdVptOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSQ1lXeGhibU5sU1c1bWJ6b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhZMk52ZFc1MFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklHWnZjaUFvYkdWMElHbGtlRG9nZFdsdWREWTBJRDBnTURzZ2FXUjRJRHdnWVdOamIzVnVkSE11YkdWdVozUm9PeUJwWkhnckt5a2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbWRsZEVKaGJHRnVZMlZKYm1adlgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2xrZURvZ2RXbHVkRFkwSUQwZ01Ec2dhV1I0SUR3Z1lXTmpiM1Z1ZEhNdWJHVnVaM1JvT3lCcFpIZ3JLeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2daMlYwUW1Gc1lXNWpaVWx1Wm05ZllXWjBaWEpmZDJocGJHVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR052Ym5OMElHRmpZMjkxYm5RZ1BTQmhZMk52ZFc1MGMxdHBaSGhkT3dvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJqYjI1emRDQmlZV3hoYm1ObElEMGdiM0F1WW1Gc1lXNWpaU2hoWTJOdmRXNTBLVHNLSUNBZ0lHSmhiR0Z1WTJVS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z2FXWWdLR0poYkdGdVkyVWdQaUF3S1NCN0NpQWdJQ0JpZWlCblpYUkNZV3hoYm1ObFNXNW1iMTlsYkhObFgySnZaSGxBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdOdmJuTjBJRzFwYmtKaGJHRnVZMlVnUFNCdmNDNXRhVzVDWVd4aGJtTmxLR0ZqWTI5MWJuUXBPd29nSUNBZ1pHbG5JRFFLSUNBZ0lHMXBibDlpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdZMjl1YzNRZ1ltRnNZVzVqWlVsdVptODZJRUpoYkdGdVkyVkpibVp2SUQwZ2V5QmlZV3hoYm1ObExDQnRhVzVDWVd4aGJtTmxJSDA3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2JHOW5LR1Z1WTI5a1pVRnlZelFvWW1Gc1lXNWpaVWx1Wm04cEtUc0tJQ0FnSUd4dlp3b0taMlYwUW1Gc1lXNWpaVWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdsa2VEb2dkV2x1ZERZMElEMGdNRHNnYVdSNElEd2dZV05qYjNWdWRITXViR1Z1WjNSb095QnBaSGdyS3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR2RsZEVKaGJHRnVZMlZKYm1adlgzZG9hV3hsWDNSdmNFQXlDZ3BuWlhSQ1lXeGhibU5sU1c1bWIxOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdleUJpWVd4aGJtTmxPaUF3TENCdGFXNUNZV3hoYm1ObE9pQXdJSDA3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHeHZaeWhsYm1OdlpHVkJjbU0wS0hSb2FYTXVaMlYwUlcxd2RIbENZV3hoYm1ObFNXNW1ieWdwS1NrN0NpQWdJQ0JzYjJjS0lDQWdJR0lnWjJWMFFtRnNZVzVqWlVsdVptOWZZV1owWlhKZmFXWmZaV3h6WlVBMkNncG5aWFJDWVd4aGJtTmxTVzVtYjE5aFpuUmxjbDkzYUdsc1pVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQlltVnNVbVZoWkdWeUxtZGxkRUZ6YzJWMGMxUnBibmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkJjM05sZEhOVWFXNTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNd29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoYzNObGRENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwWkhnNklIVnBiblEyTkNBOUlEQTdJR2xrZUNBOElHRnpjMlYwU1dSekxteGxibWQwYURzZ2FXUjRLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwblpYUkJjM05sZEhOVWFXNTVYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdsa2VEb2dkV2x1ZERZMElEMGdNRHNnYVdSNElEd2dZWE56WlhSSlpITXViR1Z1WjNSb095QnBaSGdyS3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFFYTnpaWFJ6VkdsdWVWOWhablJsY2w5M2FHbHNaVUF4TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUdOdmJuTjBJR0Z6YzJWMElEMGdZWE56WlhSSlpITmJhV1I0WFRzS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCa2RYQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCamIyNXpkQ0JiWHl3Z1pYaHBjM1J6WFNBOUlHOXdMa0Z6YzJWMFVHRnlZVzF6TG1GemMyVjBRM0psWVhSdmNpaGhjM05sZEM1cFpDazdDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBRM0psWVhSdmNnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdhV1lnS0NGbGVHbHpkSE1wSUhzS0lDQWdJR0p1ZWlCblpYUkJjM05sZEhOVWFXNTVYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVdE1USXdDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQnVZVzFsT2lBaUlpd0tJQ0FnSUM4dklDQWdkVzVwZEY5dVlXMWxPaUFpSWl3S0lDQWdJQzh2SUNBZ1pHVmphVzFoYkhNNklHNWxkeUJWYVc1ME9DZ3dLU3dLSUNBZ0lDOHZJQ0FnYkdGaVpXeHpPaUJiWFN3S0lDQWdJQzh2SUgwN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTNNREF3T1RBd01EQXdZakF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUd4dlp5aGxibU52WkdWQmNtTTBLSFJvYVhNdVoyVjBSVzF3ZEhsQmMzTmxkRlJwYm5sTVlXSmxiSE1vS1NrcE93b2dJQ0FnYkc5bkNncG5aWFJCYzNObGRITlVhVzU1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVdSNE9pQjFhVzUwTmpRZ1BTQXdPeUJwWkhnZ1BDQmhjM05sZEVsa2N5NXNaVzVuZEdnN0lHbGtlQ3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdaMlYwUVhOelpYUnpWR2x1ZVY5M2FHbHNaVjkwYjNCQU1nb0taMlYwUVhOelpYUnpWR2x1ZVY5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazFDaUFnSUNBdkx5QmhZbVZzUVhCd1NXUWdJVDA5SURBZ1B5QmpiMjF3YVd4bFFYSmpOQ2hCWW1Wc1UzUjFZaWt1WTJGc2JDNW9ZWE5mWVhOelpYUmZiR0ZpWld3b2V5QmhjSEJKWkRvZ1lXSmxiRUZ3Y0Vsa0xDQmhjbWR6T2lCYllYTnpaWFF1YVdRc0lDSndkaUpkSUgwcExuSmxkSFZ5YmxaaGJIVmxJRG9nTURzS0lDQWdJR1JwWnlBeENpQWdJQ0JpZWlCblpYUkJjM05sZEhOVWFXNTVYM1JsY201aGNubGZabUZzYzJWQU9Bb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RkbU5EQmhPR0VnTHk4Z2JXVjBhRzlrSUNKb1lYTmZZWE56WlhSZmJHRmlaV3dvZFdsdWREWTBMSE4wY21sdVp5bDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXlOekEzTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLQ21kbGRFRnpjMlYwYzFScGJubGZkR1Z5Ym1GeWVWOXRaWEpuWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklHNWhiV1U2SUdGemMyVjBMbTVoYldVdWRHOVRkSEpwYm1jb0tTd0tJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUk9ZVzFsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbE9pQmhjM05sZEM1MWJtbDBUbUZ0WlM1MGIxTjBjbWx1WnlncExBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklHUmxZMmx0WVd4ek9pQnVaWGNnVldsdWREZ29ZWE56WlhRdVpHVmphVzFoYkhNcExBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTnlBeENpQWdJQ0JpZFhKNUlEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdiR0ZpWld4ek9pQndkaUE5UFQwZ01DQS9JQ2hiWFNCaGN5QnpkSEpwYm1kYlhTa2dPaUJiSW5CMklsMHNDaUFnSUNCaWJub2daMlYwUVhOelpYUnpWR2x1ZVY5MFpYSnVZWEo1WDJaaGJITmxRREV4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NncG5aWFJCYzNObGRITlVhVzU1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TmkweE1ERUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBTVzVtYnpvZ1FYTnpaWFJVYVc1NVRHRmlaV3h6SUQwZ2V3b2dJQ0FnTHk4Z0lDQnVZVzFsT2lCaGMzTmxkQzV1WVcxbExuUnZVM1J5YVc1bktDa3NDaUFnSUNBdkx5QWdJSFZ1YVhSZmJtRnRaVG9nWVhOelpYUXVkVzVwZEU1aGJXVXVkRzlUZEhKcGJtY29LU3dLSUNBZ0lDOHZJQ0FnWkdWamFXMWhiSE02SUc1bGR5QlZhVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQXZMeUFnSUd4aFltVnNjem9nY0hZZ1BUMDlJREFnUHlBb1cxMGdZWE1nYzNSeWFXNW5XMTBwSURvZ1d5SndkaUpkTEFvZ0lDQWdMeThnZlRzS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ055QXZMeUEzQ2lBZ0lDQXJDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnYkc5bktHVnVZMjlrWlVGeVl6UW9ZWE56WlhSSmJtWnZLU2s3Q2lBZ0lDQnNiMmNLSUNBZ0lHSWdaMlYwUVhOelpYUnpWR2x1ZVY5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2dwblpYUkJjM05sZEhOVWFXNTVYM1JsY201aGNubGZabUZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREFLSUNBZ0lDOHZJR3hoWW1Wc2N6b2djSFlnUFQwOUlEQWdQeUFvVzEwZ1lYTWdjM1J5YVc1blcxMHBJRG9nV3lKd2RpSmRMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TVRBd01ESXdNREF5TnpBM05nb2dJQ0FnWWlCblpYUkJjM05sZEhOVWFXNTVYM1JsY201aGNubGZiV1Z5WjJWQU1USUtDbWRsZEVGemMyVjBjMVJwYm5sZmRHVnlibUZ5ZVY5bVlXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdGaVpXeEJjSEJKWkNBaFBUMGdNQ0EvSUdOdmJYQnBiR1ZCY21NMEtFRmlaV3hUZEhWaUtTNWpZV3hzTG1oaGMxOWhjM05sZEY5c1lXSmxiQ2g3SUdGd2NFbGtPaUJoWW1Wc1FYQndTV1FzSUdGeVozTTZJRnRoYzNObGRDNXBaQ3dnSW5CMklsMGdmU2t1Y21WMGRYSnVWbUZzZFdVZ09pQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1oyVjBRWE56WlhSelZHbHVlVjkwWlhKdVlYSjVYMjFsY21kbFFEa0tDbWRsZEVGemMyVjBjMVJwYm5sZllXWjBaWEpmZDJocGJHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdmJrTnlaV0YwWlRvZ0ltRnNiRzkzSWlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQTNNREF3T1RBd01EQXdZakF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZpWld4U1pXRmtaWEl1WjJWMFFYTnpaWFJNWVdKbGJITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSQmMzTmxkRXhoWW1Wc2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxMQ0J2YmtOeVpXRjBaVG9nSW1Gc2JHOTNJaXdnYm1GdFpUb2dJbWRsZEY5aGMzTmxkRjlzWVdKbGJITWlMQ0J5WlhOdmRYSmpaVVZ1WTI5a2FXNW5PaUFpYVc1a1pYZ2lJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQlltVnNVbVZoWkdWeUxtZGxkRUpzYjJOclZHbHRaWE5CYm1SVVkxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVKc2IyTnJWR2x0WlhOQmJtUlVZem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdmJrTnlaV0YwWlRvZ0ltRnNiRzkzSWlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvS1oyVjBRbXh2WTJ0VWFXMWxjMEZ1WkZSalgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0J5YjNWdVpEb2dkV2x1ZERZMElEMGdabWx5YzNSU2IzVnVaRHNnY205MWJtUWdQRDBnYkdGemRGSnZkVzVrT3lCeWIzVnVaQ3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4UFFvZ0lDQWdZbm9nWjJWMFFteHZZMnRVYVcxbGMwRnVaRlJqWDJGbWRHVnlYM2RvYVd4bFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdkSE02SUc1bGR5QlZhVzUwTXpJb2IzQXVRbXh2WTJzdVlteHJWR2x0WlhOMFlXMXdLSEp2ZFc1a0tTa3NDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnNiMk5ySUVKc2ExUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pYaDBjbUZqZENBMElEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdkR002SUc5d0xrSnNiMk5yTG1Kc2ExUjRia052ZFc1MFpYSW9jbTkxYm1RcExBb2dJQ0FnWkdsbklERUtJQ0FnSUdKc2IyTnJJRUpzYTFSNGJrTnZkVzUwWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5pMHhNamtLSUNBZ0lDOHZJR052Ym5OMElHSnNhMFJoZEdFNklFSnNiMk5yVkdsdFpVRnVaRlJqSUQwZ2V3b2dJQ0FnTHk4Z0lDQjBjem9nYm1WM0lGVnBiblF6TWlodmNDNUNiRzlqYXk1aWJHdFVhVzFsYzNSaGJYQW9jbTkxYm1RcEtTd0tJQ0FnSUM4dklDQWdkR002SUc5d0xrSnNiMk5yTG1Kc2ExUjRia052ZFc1MFpYSW9jbTkxYm1RcExBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13Q2lBZ0lDQXZMeUJzYjJjb1pXNWpiMlJsUVhKak5DaGliR3RFWVhSaEtTazdDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdabTl5SUNoc1pYUWdjbTkxYm1RNklIVnBiblEyTkNBOUlHWnBjbk4wVW05MWJtUTdJSEp2ZFc1a0lEdzlJR3hoYzNSU2IzVnVaRHNnY205MWJtUXJLeWtnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQm5aWFJDYkc5amExUnBiV1Z6UVc1a1ZHTmZkMmhwYkdWZmRHOXdRRElLQ21kbGRFSnNiMk5yVkdsdFpYTkJibVJVWTE5aFpuUmxjbDkzYUdsc1pVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRmlaV3hTWldGa1pYSXVaMlYwUVhWMGFFRmtaSEp6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRWFYwYUVGa1pISnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGalkyOTFiblErQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdsa2VEb2dkV2x1ZERZMElEMGdNRHNnYVdSNElEd2dZV05qYjNWdWRITXViR1Z1WjNSb095QnBaSGdyS3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtZGxkRUYxZEdoQlpHUnljMTkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FXUjRPaUIxYVc1ME5qUWdQU0F3T3lCcFpIZ2dQQ0JoWTJOdmRXNTBjeTVzWlc1bmRHZzdJR2xrZUNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCblpYUkJkWFJvUVdSa2NuTmZZV1owWlhKZmQyaHBiR1ZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNNENpQWdJQ0F2THlCamIyNXpkQ0JiWVhWMGFFRmtaSElzSUY5ZElEMGdiM0F1UVdOamRGQmhjbUZ0Y3k1aFkyTjBRWFYwYUVGa1pISW9ZV05qYjNWdWRITmJhV1I0WFNrN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUVhWMGFFRmtaSElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJzYjJjb1lYVjBhRUZrWkhJdVlubDBaWE1wT3dvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdsa2VEb2dkV2x1ZERZMElEMGdNRHNnYVdSNElEd2dZV05qYjNWdWRITXViR1Z1WjNSb095QnBaSGdyS3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJuWlhSQmRYUm9RV1JrY25OZmQyaHBiR1ZmZEc5d1FESUtDbWRsZEVGMWRHaEJaR1J5YzE5aFpuUmxjbDkzYUdsc1pVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRU5WVUZoWk5VbEJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVFcENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVdKbGJGSmxZV1JsY2k1blpYUlVhVzU1YldGdVNXNW1iMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGUnBibmx0WVc1SmJtWnZPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWkhWd2JpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGalkyOTFiblErQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRjS0lDQWdJQzh2SUdOdmJuTjBJSFJwYm5sdFlXNUZjMk55YjNjZ1BTQjBhVzU1YldGdVFYQndTV1F1WVdSa2NtVnpjenNLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSVWFXNTViV0Z1U1c1bWIxOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2JIQkZjMk55YjNjZ2IyWWdiSEJGYzJOeWIzZHpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJVYVc1NWJXRnVTVzVtYjE5aFpuUmxjbDltYjNKQU1UUUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QmpiMjV6ZENCYllYVjBhRUZrWkhJc0lGOWRJRDBnYjNBdVFXTmpkRkJoY21GdGN5NWhZMk4wUVhWMGFFRmtaSElvYkhCRmMyTnliM2NwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUYxZEdoQlpHUnlDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdZMjl1YzNRZ2RtRnNhV1JTWld0bGVTQTlJR0YxZEdoQlpHUnlJRDA5UFNCMGFXNTViV0Z1UlhOamNtOTNPd29nSUNBZ1pHbG5JRE1LSUNBZ0lEMDlDaUFnSUNCaWRYSjVJRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnYVdZZ0tHOXdMbUZ3Y0U5d2RHVmtTVzRvYkhCRmMyTnliM2NzSUhScGJubHRZVzVCY0hCSlpDa3BJSHNLSUNBZ0lHUnBaeUExQ2lBZ0lDQmhjSEJmYjNCMFpXUmZhVzRLSUNBZ0lHSjZJR2RsZEZScGJubHRZVzVKYm1adlgyVnNjMlZmWW05a2VVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWE56WlhReFNXUXNJR0Z6YzJWME1VVjRhWE4wYzEwZ1BTQnZjQzVCY0hCTWIyTmhiQzVuWlhSRmVGVnBiblEyTkNoc2NFVnpZM0p2ZHl3Z2RHbHVlVzFoYmtGd2NFbGtMQ0JDZVhSbGMyQmhjM05sZEY4eFgybGtZQ2s3Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnY0hWemFHSjVkR1Z6SUNKaGMzTmxkRjh4WDJsa0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYTnpaWFF5U1dRc0lHRnpjMlYwTWtWNGFYTjBjMTBnUFNCdmNDNUJjSEJNYjJOaGJDNW5aWFJGZUZWcGJuUTJOQ2hzY0VWelkzSnZkeXdnZEdsdWVXMWhia0Z3Y0Vsa0xDQkNlWFJsYzJCaGMzTmxkRjh5WDJsa1lDazdDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRnpjMlYwWHpKZmFXUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNUW9nSUNBZ0x5OGdZWE56WlhReFZXNXBkRTVoYldVNklHRnpjMlYwTVVWNGFYTjBjeUEvSUdkbGRFRnpjMlYwVlc1cGRFNWhiV1VvWVhOelpYUXhTV1FwSURvZ0lpSXNDaUFnSUNCaWVpQm5aWFJVYVc1NWJXRnVTVzVtYjE5MFpYSnVZWEo1WDJaaGJITmxRRFlLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRUZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJR0oxY25rZ01UQUtDbWRsZEZScGJubHRZVzVKYm1adlgzUmxjbTVoY25sZmJXVnlaMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk13b2dJQ0FnTHk4Z1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUdGemMyVjBNa1Y0YVhOMGN5QS9JR2RsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhReVNXUXBJRG9nSWlJc0NpQWdJQ0JrYVdjZ053b2dJQ0FnWW5vZ1oyVjBWR2x1ZVcxaGJrbHVabTlmZEdWeWJtRnllVjltWVd4elpVQTVDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyRnNiSE4xWWlCblpYUkJjM05sZEZWdWFYUk9ZVzFsQ2dwblpYUlVhVzU1YldGdVNXNW1iMTkwWlhKdVlYSjVYMjFsY21kbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFU0TFRFMk5Bb2dJQ0FnTHk4Z1pXNWpiMlJsUVhKak5DaDdDaUFnSUNBdkx5QWdJSFpoYkdsa1VtVnJaWGtzQ2lBZ0lDQXZMeUFnSUdGemMyVjBNVWxrTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZWYm1sMFRtRnRaVG9nWVhOelpYUXhSWGhwYzNSeklEOGdaMlYwUVhOelpYUlZibWwwVG1GdFpTaGhjM05sZERGSlpDa2dPaUFpSWl3S0lDQWdJQzh2SUNBZ1lYTnpaWFF5U1dRc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTWxWdWFYUk9ZVzFsT2lCaGMzTmxkREpGZUdsemRITWdQeUJuWlhSQmMzTmxkRlZ1YVhST1lXMWxLR0Z6YzJWME1rbGtLU0E2SUNJaUxBb2dJQ0FnTHk4Z2ZTQmhjeUJVYVc1NWJXRnVTVzVtYnlrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBNENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURFMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpFZ0x5OGdNakVLSUNBZ0lDc0tJQ0FnSUdScFp5QXhNQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRjdE1UWTFDaUFnSUNBdkx5QnNiMmNvQ2lBZ0lDQXZMeUFnSUdWdVkyOWtaVUZ5WXpRb2V3b2dJQ0FnTHk4Z0lDQWdJSFpoYkdsa1VtVnJaWGtzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFF4U1dRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhReFZXNXBkRTVoYldVNklHRnpjMlYwTVVWNGFYTjBjeUEvSUdkbGRFRnpjMlYwVlc1cGRFNWhiV1VvWVhOelpYUXhTV1FwSURvZ0lpSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUXlTV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUdGemMyVjBNa1Y0YVhOMGN5QS9JR2RsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhReVNXUXBJRG9nSWlJc0NpQWdJQ0F2THlBZ0lIMGdZWE1nVkdsdWVXMWhia2x1Wm04cExBb2dJQ0FnTHk4Z0tUc0tJQ0FnSUd4dlp3b0taMlYwVkdsdWVXMWhia2x1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQm5aWFJVYVc1NWJXRnVTVzVtYjE5bWIzSmZhR1ZoWkdWeVFESUtDbWRsZEZScGJubHRZVzVKYm1adlgzUmxjbTVoY25sZlptRnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk13b2dJQ0FnTHk4Z1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUdGemMyVjBNa1Y0YVhOMGN5QS9JR2RsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhReVNXUXBJRG9nSWlJc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0JpSUdkbGRGUnBibmx0WVc1SmJtWnZYM1JsY201aGNubGZiV1Z5WjJWQU1UQUtDbWRsZEZScGJubHRZVzVKYm1adlgzUmxjbTVoY25sZlptRnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z1lYTnpaWFF4Vlc1cGRFNWhiV1U2SUdGemMyVjBNVVY0YVhOMGN5QS9JR2RsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhReFNXUXBJRG9nSWlJc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0JpZFhKNUlERXdDaUFnSUNCaUlHZGxkRlJwYm5sdFlXNUpibVp2WDNSbGNtNWhjbmxmYldWeVoyVkFOd29LWjJWMFZHbHVlVzFoYmtsdVptOWZaV3h6WlY5aWIyUjVRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNExUSXdOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkbUZzYVdSU1pXdGxlVG9nWm1Gc2MyVXNDaUFnSUNBdkx5QWdJR0Z6YzJWME1VbGtPaUF3TEFvZ0lDQWdMeThnSUNCaGMzTmxkREZWYm1sMFRtRnRaVG9nSWlJc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTWtsa09pQXdMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESlZibWwwVG1GdFpUb2dJaUlzQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE5UQXdNREF3TURBd01EQXdNREF3TURBd01ERTNNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOZ29nSUNBZ0x5OGdmU0JsYkhObElHeHZaeWhsYm1OdlpHVkJjbU0wS0dkbGRFVnRjSFI1VkdsdWVXMWhia2x1Wm04b0tTa3BPd29nSUNBZ2JHOW5DaUFnSUNCaUlHZGxkRlJwYm5sdFlXNUpibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ21kbGRGUnBibmx0WVc1SmJtWnZYMkZtZEdWeVgyWnZja0F4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREUxTURBd01EQXdNREF3TURBd01EQXdNREF3TVRjd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZpWld4U1pXRmtaWEl1WjJWMFVHRmpkRWx1Wm05YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJRWVdOMFNXNW1iem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNVFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdmJrTnlaV0YwWlRvZ0ltRnNiRzkzSWlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z3Y0d4cFkyRjBhVzl1UGdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21kbGRGQmhZM1JKYm1adlgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TVFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCd1lXTjBRWEJ3U1dRZ2IyWWdjR0ZqZEVGd2NFbGtjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2daMlYwVUdGamRFbHVabTlmWVdaMFpYSmZabTl5UURVS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5T0FvZ0lDQWdMeThnYVdZZ0tHRndjQzVwWkNBOElESTFOaWtnY21WMGRYSnVJR2RsZEVWdGNIUjVVR0ZqZEVsdVptOG9LVHNLSUNBZ0lIQjFjMmhwYm5RZ01qVTJJQzh2SURJMU5nb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFVHRmpkRWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURndE1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjBlWEJsT2lCdVpYY2dWV2x1ZERnb1VFRkRWRjlVV1ZCRlgwNVBUa1VwTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZKWkRvZ01Dd0tJQ0FnSUM4dklDQWdZWE56WlhReFZXNXBkRTVoYldVNklDSWlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESkpaRG9nTUN3S0lDQWdJQzh2SUNBZ1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUNJaUxBb2dJQ0FnTHk4Z0lDQm1aV1ZDY0hNNklEQXNDaUFnSUNBdkx5QjlPd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdRd01EQXdNREF3TURBd01EQXdNREF3TURBeFpqQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvS1oyVjBVR0ZqZEVsdVptOWZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNloyVjBVR0ZqZEZCdmIyeEpibVp2UURNek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3lMVEU1TVFvZ0lDQWdMeThnYkc5bktBb2dJQ0FnTHk4Z0lDQmxibU52WkdWQmNtTTBLQW9nSUNBZ0x5OGdJQ0FnSUdkbGRGQmhZM1JRYjI5c1NXNW1ieWdLSUNBZ0lDOHZJQ0FnSUNBZ0lIQmhZM1JCY0hCSlpDd0tJQ0FnSUM4dklDQWdJQ0FnSUdOdmJuTjBZVzUwVUhKdlpIVmpkRU55WldGMGIzSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJQ0FnYzNSaFlteGxjM2RoY0VOeVpXRjBiM0l1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2JXRnVZV2RsWkZkbGFXZG9kR1ZrUTNKbFlYUnZjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0tTd0tJQ0FnSUM4dklDazdDaUFnSUNCc2IyY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJuWlhSUVlXTjBTVzVtYjE5bWIzSmZhR1ZoWkdWeVFESUtDbWRsZEZCaFkzUkpibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TWdvZ0lDQWdMeThnWTI5dWMzUWdXMk55WldGMGIzSXNJR0Z3Y0VWNGFYTjBjMTBnUFNCdmNDNUJjSEJRWVhKaGJYTXVZWEJ3UTNKbFlYUnZjaWhoY0hBcE93b2dJQ0FnWkdsbklEY0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VOeVpXRjBiM0lLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTWpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek13b2dJQ0FnTHk4Z2FXWWdLQ0ZoY0hCRmVHbHpkSE1wSUhKbGRIVnliaUJuWlhSRmJYQjBlVkJoWTNSSmJtWnZLQ2s3Q2lBZ0lDQmlibm9nWjJWMFVHRmpkRWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBNExUSXhOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkSGx3WlRvZ2JtVjNJRlZwYm5RNEtGQkJRMVJmVkZsUVJWOU9UMDVGS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFF4U1dRNklEQXNDaUFnSUNBdkx5QWdJR0Z6YzJWME1WVnVhWFJPWVcxbE9pQWlJaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUXlTV1E2SURBc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTWxWdWFYUk9ZVzFsT2lBaUlpd0tJQ0FnSUM4dklDQWdabVZsUW5Cek9pQXdMQW9nSUNBZ0x5OGdmVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURGa01EQXdNREF3TURBd01EQXdNREF3TURBd01XWXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5DMHhPRGtLSUNBZ0lDOHZJR2RsZEZCaFkzUlFiMjlzU1c1bWJ5Z0tJQ0FnSUM4dklDQWdjR0ZqZEVGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JqYjI1emRHRnVkRkJ5YjJSMVkzUkRjbVZoZEc5eUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ2MzUmhZbXhsYzNkaGNFTnlaV0YwYjNJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNCdFlXNWhaMlZrVjJWcFoyaDBaV1JEY21WaGRHOXlMbTVoZEdsMlpTd0tJQ0FnSUM4dklDa3NDaUFnSUNCaUlHZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9tZGxkRkJoWTNSUWIyOXNTVzVtYjBBek13b0taMlYwVUdGamRFbHVabTlmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TndvZ0lDQWdMeThnWTI5dWMzUWdhWE5EYjI1emRGQnliMlIxWTNRZ1BTQmpjbVZoZEc5eUlEMDlQU0JqYjI1emRHRnVkRkJ5YjJSMVkzUkRjbVZoZEc5eU93b2dJQ0FnWkdsbklESXhDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTNDaUFnSUNBOVBRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpnS0lDQWdJQzh2SUdOdmJuTjBJR2x6VTNSaFlteGxjM2RoY0VOeVpXRjBiM0lnUFNCamNtVmhkRzl5SUQwOVBTQnpkR0ZpYkdWemQyRndRM0psWVhSdmNqc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEY0tJQ0FnSUQwOUNpQWdJQ0JpZFhKNUlERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNemtLSUNBZ0lDOHZJR052Ym5OMElHbHpUV0Z1WVdkbFpGZGxhV2RvZEdWa0lEMGdZM0psWVhSdmNpQTlQVDBnYldGdVlXZGxaRmRsYVdkb2RHVmtRM0psWVhSdmNqc0tJQ0FnSUdScFp5QTFDaUFnSUNBOVBRb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalExQ2lBZ0lDQXZMeUJwWmlBb0lXbHpRMjl1YzNSUWNtOWtkV04wSUNZbUlDRnBjMU4wWVdKc1pYTjNZWEJEY21WaGRHOXlJQ1ltSUNGcGMwMWhibUZuWldSWFpXbG5hSFJsWkNrZ2NtVjBkWEp1SUdkbGRFVnRjSFI1VUdGamRFbHVabThvS1RzS0lDQWdJR0p1ZWlCblpYUlFZV04wU1c1bWIxOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0JrYVdjZ09Rb2dJQ0FnWW01NklHZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1ltNTZJR2RsZEZCaFkzUkpibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3T0MweU1UVUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIUjVjR1U2SUc1bGR5QlZhVzUwT0NoUVFVTlVYMVJaVUVWZlRrOU9SU2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBNVWxrT2lBd0xBb2dJQ0FnTHk4Z0lDQmhjM05sZERGVmJtbDBUbUZ0WlRvZ0lpSXNDaUFnSUNBdkx5QWdJR0Z6YzJWME1rbGtPaUF3TEFvZ0lDQWdMeThnSUNCaGMzTmxkREpWYm1sMFRtRnRaVG9nSWlJc0NpQWdJQ0F2THlBZ0lHWmxaVUp3Y3pvZ01Dd0tJQ0FnSUM4dklIMDdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4WkRBd01EQXdNREF3TURBd01EQXdNREF3TURGbU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RRdE1UZzVDaUFnSUNBdkx5Qm5aWFJRWVdOMFVHOXZiRWx1Wm04b0NpQWdJQ0F2THlBZ0lIQmhZM1JCY0hCSlpDd0tJQ0FnSUM4dklDQWdZMjl1YzNSaGJuUlFjbTlrZFdOMFEzSmxZWFJ2Y2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUhOMFlXSnNaWE4zWVhCRGNtVmhkRzl5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnYldGdVlXZGxaRmRsYVdkb2RHVmtRM0psWVhSdmNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcExBb2dJQ0FnWWlCblpYUlFZV04wU1c1bWIxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwblpYUlFZV04wVUc5dmJFbHVabTlBTXpNS0NtZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVElLSUNBZ0lDOHZJR052Ym5OMElGdHpkMkZ3Um1WbFFuQnpMQ0JvWVhOVGQyRndSbVZsUW5CelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaGhjSEFzSUVKNWRHVnpZSE4zWVhCZlptVmxYMkp3YzJBcE93b2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKemQyRndYMlpsWlY5aWNITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV6Q2lBZ0lDQXZMeUJqYjI1emRDQmJZWE56WlhSQkxDQm9ZWE5CYzNObGRFRmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLR0Z3Y0N3Z1FubDBaWE5nWVhOelpYUmZZV0FwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZ6YzJWMFgyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeU1Bb2dJQ0FnWW5WeWVTQXlNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalUwQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWE56WlhSQ0xDQm9ZWE5CYzNObGRFSmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLR0Z3Y0N3Z1FubDBaWE5nWVhOelpYUmZZbUFwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poYzNObGRGOWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUdKMWNua2dNakVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTlFvZ0lDQWdMeThnYVdZZ0tHaGhjMU4zWVhCR1pXVkNjSE1nSmlZZ2FHRnpRWE56WlhSQklDWW1JR2hoYzBGemMyVjBRaWtnZXdvZ0lDQWdZbm9nWjJWMFVHRmpkRWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JpZWlCblpYUlFZV04wU1c1bWIxOWhablJsY2w5cFpsOWxiSE5sUURJd0NpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdKNklHZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU1qQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFPUW9nSUNBZ0x5OGdhV1lnS0NGcGMwMWhibUZuWldSWFpXbG5hSFJsWkNrZ2NtVjBkWEp1SUdkbGRFVnRjSFI1VUdGamRFbHVabThvS1RzS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWW01NklHZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdPQzB5TVRVS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhSNWNHVTZJRzVsZHlCVmFXNTBPQ2hRUVVOVVgxUlpVRVZmVGs5T1JTa3NDaUFnSUNBdkx5QWdJR0Z6YzJWME1VbGtPaUF3TEFvZ0lDQWdMeThnSUNCaGMzTmxkREZWYm1sMFRtRnRaVG9nSWlJc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTWtsa09pQXdMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESlZibWwwVG1GdFpUb2dJaUlzQ2lBZ0lDQXZMeUFnSUdabFpVSndjem9nTUN3S0lDQWdJQzh2SUgwN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhaREF3TURBd01EQXdNREF3TURBd01EQXdNREZtTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFF0TVRnNUNpQWdJQ0F2THlCblpYUlFZV04wVUc5dmJFbHVabThvQ2lBZ0lDQXZMeUFnSUhCaFkzUkJjSEJKWkN3S0lDQWdJQzh2SUNBZ1kyOXVjM1JoYm5SUWNtOWtkV04wUTNKbFlYUnZjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJSE4wWVdKc1pYTjNZWEJEY21WaGRHOXlMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdiV0Z1WVdkbFpGZGxhV2RvZEdWa1EzSmxZWFJ2Y2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFwTEFvZ0lDQWdZaUJuWlhSUVlXTjBTVzVtYjE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBuWlhSUVlXTjBVRzl2YkVsdVptOUFNek1LQ21kbGRGQmhZM1JKYm1adlgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qTUtJQ0FnSUM4dklHRnpjMlYwTVZWdWFYUk9ZVzFsT2lCblpYUkJjM05sZEZWdWFYUk9ZVzFsS0dGemMyVjBRU2tzQ2lBZ0lDQmthV2NnTWpBS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qVUtJQ0FnSUM4dklHRnpjMlYwTWxWdWFYUk9ZVzFsT2lCblpYUkJjM05sZEZWdWFYUk9ZVzFsS0dGemMyVjBRaWtzQ2lBZ0lDQmthV2NnTWpFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJuWlhSQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOakF0TWpZM0NpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCMGVYQmxPaUJ1WlhjZ1ZXbHVkRGdvVUVGRFZGOVVXVkJGWDAxQlRrRkhSVVJmVjBWSlIwaFVSVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZKWkRvZ1lYTnpaWFJCTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZWYm1sMFRtRnRaVG9nWjJWMFFYTnpaWFJWYm1sMFRtRnRaU2hoYzNObGRFRXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESkpaRG9nWVhOelpYUkNMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESlZibWwwVG1GdFpUb2daMlYwUVhOelpYUlZibWwwVG1GdFpTaGhjM05sZEVJcExBb2dJQ0FnTHk4Z0lDQm1aV1ZDY0hNNklITjNZWEJHWldWQ2NITXNDaUFnSUNBdkx5QjlPd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qRUtJQ0FnSUM4dklIUjVjR1U2SUc1bGR5QlZhVzUwT0NoUVFVTlVYMVJaVUVWZlRVRk9RVWRGUkY5WFJVbEhTRlJGUkNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXdMVEkyTndvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dibVYzSUZWcGJuUTRLRkJCUTFSZlZGbFFSVjlOUVU1QlIwVkVYMWRGU1VkSVZFVkVLU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUXhTV1E2SUdGemMyVjBRU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUXhWVzVwZEU1aGJXVTZJR2RsZEVGemMyVjBWVzVwZEU1aGJXVW9ZWE56WlhSQktTd0tJQ0FnSUM4dklDQWdZWE56WlhReVNXUTZJR0Z6YzJWMFFpd0tJQ0FnSUM4dklDQWdZWE56WlhReVZXNXBkRTVoYldVNklHZGxkRUZ6YzJWMFZXNXBkRTVoYldVb1lYTnpaWFJDS1N3S0lDQWdJQzh2SUNBZ1ptVmxRbkJ6T2lCemQyRndSbVZsUW5CekxBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXhaQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTVJQzh2SURJNUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzBMVEU0T1FvZ0lDQWdMeThnWjJWMFVHRmpkRkJ2YjJ4SmJtWnZLQW9nSUNBZ0x5OGdJQ0J3WVdOMFFYQndTV1FzQ2lBZ0lDQXZMeUFnSUdOdmJuTjBZVzUwVUhKdlpIVmpkRU55WldGMGIzSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQnpkR0ZpYkdWemQyRndRM0psWVhSdmNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lHMWhibUZuWldSWFpXbG5hSFJsWkVOeVpXRjBiM0l1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdLU3dLSUNBZ0lHSWdaMlYwVUdGamRFbHVabTlmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZaMlYwVUdGamRGQnZiMnhKYm1adlFETXpDZ3BuWlhSUVlXTjBTVzVtYjE5aFpuUmxjbDlwWmw5bGJITmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjeUNpQWdJQ0F2THlCamIyNXpkQ0JiWTI5dVptbG5MQ0JvWVhORGIyNW1hV2RkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVhCd0xDQkNlWFJsYzJCRFQwNUdTVWRnS1RzS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpUTA5T1JrbEhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNalVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTXdvZ0lDQWdMeThnWTI5dWMzUWdXMTlzZEdsa0xDQm9ZWE5NZEdsa1hTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaGhjSEFzSUVKNWRHVnpZRXhVU1VSZ0tUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRGUkpSQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERTJDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNOQW9nSUNBZ0x5OGdhV1lnS0NGb1lYTkRiMjVtYVdjZ2ZId2dJV2hoYzB4MGFXUWdmSHdnWTI5dVptbG5MbXhsYm1kMGFDQThJREkwS1NCeVpYUjFjbTRnWjJWMFJXMXdkSGxRWVdOMFNXNW1ieWdwT3dvZ0lDQWdZbm9nWjJWMFVHRmpkRWx1Wm05ZmFXWmZZbTlrZVVBeU13b2dJQ0FnWkdsbklERXpDaUFnSUNCaWVpQm5aWFJRWVdOMFNXNW1iMTlwWmw5aWIyUjVRREl6Q2lBZ0lDQmthV2NnTWpJS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUR3S0lDQWdJR0o2SUdkbGRGQmhZM1JKYm1adlgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpRS0NtZGxkRkJoWTNSSmJtWnZYMmxtWDJKdlpIbEFNak02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURndE1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjBlWEJsT2lCdVpYY2dWV2x1ZERnb1VFRkRWRjlVV1ZCRlgwNVBUa1VwTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZKWkRvZ01Dd0tJQ0FnSUM4dklDQWdZWE56WlhReFZXNXBkRTVoYldVNklDSWlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESkpaRG9nTUN3S0lDQWdJQzh2SUNBZ1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUNJaUxBb2dJQ0FnTHk4Z0lDQm1aV1ZDY0hNNklEQXNDaUFnSUNBdkx5QjlPd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdRd01EQXdNREF3TURBd01EQXdNREF3TURBeFpqQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMExURTRPUW9nSUNBZ0x5OGdaMlYwVUdGamRGQnZiMnhKYm1adktBb2dJQ0FnTHk4Z0lDQndZV04wUVhCd1NXUXNDaUFnSUNBdkx5QWdJR052Ym5OMFlXNTBVSEp2WkhWamRFTnlaV0YwYjNJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNCemRHRmliR1Z6ZDJGd1EzSmxZWFJ2Y2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUcxaGJtRm5aV1JYWldsbmFIUmxaRU55WldGMGIzSXVibUYwYVhabExBb2dJQ0FnTHk4Z0tTd0tJQ0FnSUdJZ1oyVjBVR0ZqZEVsdVptOWZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNloyVjBVR0ZqZEZCdmIyeEpibVp2UURNekNncG5aWFJRWVdOMFNXNW1iMTloWm5SbGNsOXBabDlsYkhObFFESTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamM0Q2lBZ0lDQXZMeUJqYjI1emRDQmJYMmx1YVhScFlXeEJMQ0JvWVhOSmJtbDBhV0ZzUVYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb1lYQndMQ0JDZVhSbGMyQkpUa2xVU1VGTVgwRmdLVHNLSUNBZ0lHUnBaeUEzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa2xPU1ZSSlFVeGZRU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNPUW9nSUNBZ0x5OGdZMjl1YzNRZ2FYTlRkR0ZpYkdWemQyRndJRDBnWTI5dVptbG5MbXhsYm1kMGFDQStQU0F6TWlBbUppQm9ZWE5KYm1sMGFXRnNRVHNLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lENDlDaUFnSUNBbUpnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPRE1LSUNBZ0lDOHZJR2xtSUNocGMxTjBZV0pzWlhOM1lYQWdQeUFoYVhOVGRHRmliR1Z6ZDJGd1EzSmxZWFJ2Y2lBNklDRnBjME52Ym5OMFVISnZaSFZqZENrZ2NtVjBkWEp1SUdkbGRFVnRjSFI1VUdGamRFbHVabThvS1RzS0lDQWdJR0o2SUdkbGRGQmhZM1JKYm1adlgzUmxjbTVoY25sZlptRnNjMlZBTWpZS0lDQWdJR1JwWnlBNUNpQWdJQ0FoQ2dwblpYUlFZV04wU1c1bWIxOTBaWEp1WVhKNVgyMWxjbWRsUURJM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ3pDaUFnSUNBdkx5QnBaaUFvYVhOVGRHRmliR1Z6ZDJGd0lEOGdJV2x6VTNSaFlteGxjM2RoY0VOeVpXRjBiM0lnT2lBaGFYTkRiMjV6ZEZCeWIyUjFZM1FwSUhKbGRIVnliaUJuWlhSRmJYQjBlVkJoWTNSSmJtWnZLQ2s3Q2lBZ0lDQmllaUJuWlhSUVlXTjBTVzVtYjE5aFpuUmxjbDlwWmw5bGJITmxRREk1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0psYkY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURndE1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjBlWEJsT2lCdVpYY2dWV2x1ZERnb1VFRkRWRjlVV1ZCRlgwNVBUa1VwTEFvZ0lDQWdMeThnSUNCaGMzTmxkREZKWkRvZ01Dd0tJQ0FnSUM4dklDQWdZWE56WlhReFZXNXBkRTVoYldVNklDSWlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRESkpaRG9nTUN3S0lDQWdJQzh2SUNBZ1lYTnpaWFF5Vlc1cGRFNWhiV1U2SUNJaUxBb2dJQ0FnTHk4Z0lDQm1aV1ZDY0hNNklEQXNDaUFnSUNBdkx5QjlPd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdRd01EQXdNREF3TURBd01EQXdNREF3TURBeFpqQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMExURTRPUW9nSUNBZ0x5OGdaMlYwVUdGamRGQnZiMnhKYm1adktBb2dJQ0FnTHk4Z0lDQndZV04wUVhCd1NXUXNDaUFnSUNBdkx5QWdJR052Ym5OMFlXNTBVSEp2WkhWamRFTnlaV0YwYjNJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNCemRHRmliR1Z6ZDJGd1EzSmxZWFJ2Y2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUcxaGJtRm5aV1JYWldsbmFIUmxaRU55WldGMGIzSXVibUYwYVhabExBb2dJQ0FnTHk4Z0tTd0tJQ0FnSUdJZ1oyVjBVR0ZqZEVsdVptOWZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNloyVjBVR0ZqZEZCdmIyeEpibVp2UURNekNncG5aWFJRWVdOMFNXNW1iMTloWm5SbGNsOXBabDlsYkhObFFESTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamc0Q2lBZ0lDQXZMeUJqYjI1emRDQmpiMjVtYVdkR1pXVkNjSE1nUFNCdmNDNWxlSFJ5WVdOMFZXbHVkRFkwS0dOdmJtWnBaeXdnTVRZcE93b2dJQ0FnWkdsbklESXlDaUFnSUNCd2RYTm9hVzUwSURFMklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBeE9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZzVDaUFnSUNBdkx5QmpiMjV6ZENCYlptVmxRbkJ6TENCb1lYTkdaV1ZDY0hOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtHRndjQ3dnUW5sMFpYTmdSa1ZGWDBKUVUyQXBPd29nSUNBZ1pHbG5JRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSa1ZGWDBKUVV5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ01UY0tJQ0FnSUdKMWNua2dNVGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TUFvZ0lDQWdMeThnYVdZZ0tHaGhjMFpsWlVKd2N5QW1KaUJtWldWQ2NITWdJVDA5SUdOdmJtWnBaMFpsWlVKd2N5a2djbVYwZFhKdUlHZGxkRVZ0Y0hSNVVHRmpkRWx1Wm04b0tUc0tJQ0FnSUdKNklHZGxkRkJoWTNSSmJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU16SUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pHbG5JREU1Q2lBZ0lDQWhQUW9nSUNBZ1lub2daMlYwVUdGamRFbHVabTlmWVdaMFpYSmZhV1pmWld4elpVQXpNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakE0TFRJeE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2RIbHdaVG9nYm1WM0lGVnBiblE0S0ZCQlExUmZWRmxRUlY5T1QwNUZLU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUXhTV1E2SURBc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTVZWdWFYUk9ZVzFsT2lBaUlpd0tJQ0FnSUM4dklDQWdZWE56WlhReVNXUTZJREFzQ2lBZ0lDQXZMeUFnSUdGemMyVjBNbFZ1YVhST1lXMWxPaUFpSWl3S0lDQWdJQzh2SUNBZ1ptVmxRbkJ6T2lBd0xBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREZrTURBd01EQXdNREF3TURBd01EQXdNREF3TVdZd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbVZzWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TkMweE9Ea0tJQ0FnSUM4dklHZGxkRkJoWTNSUWIyOXNTVzVtYnlnS0lDQWdJQzh2SUNBZ2NHRmpkRUZ3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmpiMjV6ZEdGdWRGQnliMlIxWTNSRGNtVmhkRzl5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnYzNSaFlteGxjM2RoY0VOeVpXRjBiM0l1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0J0WVc1aFoyVmtWMlZwWjJoMFpXUkRjbVZoZEc5eUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNrc0NpQWdJQ0JpSUdkbGRGQmhZM1JKYm1adlgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpWld4ZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T21kbGRGQmhZM1JRYjI5c1NXNW1iMEF6TXdvS1oyVjBVR0ZqZEVsdVptOWZZV1owWlhKZmFXWmZaV3h6WlVBek1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVNZ29nSUNBZ0x5OGdZMjl1YzNRZ1lYTnpaWFF4U1dRZ1BTQnZjQzVsZUhSeVlXTjBWV2x1ZERZMEtHTnZibVpwWnl3Z01DazdDaUFnSUNCa2FXY2dNaklLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVE1LSUNBZ0lDOHZJR052Ym5OMElHRnpjMlYwTWtsa0lEMGdiM0F1WlhoMGNtRmpkRlZwYm5RMk5DaGpiMjVtYVdjc0lEZ3BPd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFVLSUNBZ0lDOHZJSFI1Y0dVNklHNWxkeUJWYVc1ME9DaHBjMU4wWVdKc1pYTjNZWEFnUHlCUVFVTlVYMVJaVUVWZlUxUkJRa3hGVTFkQlVDQTZJRkJCUTFSZlZGbFFSVjlEVDA1VFZFRk9WRjlRVWs5RVZVTlVLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWlhoMGNtRmpkQ0EzSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU9Bb2dJQ0FnTHk4Z1lYTnpaWFF4Vlc1cGRFNWhiV1U2SUdkbGRFRnpjMlYwVlc1cGRFNWhiV1VvWVhOelpYUXhTV1FwTEFvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdaMlYwUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QXdDaUFnSUNBdkx5QmhjM05sZERKVmJtbDBUbUZ0WlRvZ1oyVjBRWE56WlhSVmJtbDBUbUZ0WlNoaGMzTmxkREpKWkNrc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJuWlhSQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSmxiRjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNREVLSUNBZ0lDOHZJR1psWlVKd2N6b2dhR0Z6Um1WbFFuQnpJRDhnWm1WbFFuQnpJRG9nWTI5dVptbG5SbVZsUW5CekxBb2dJQ0FnWkdsbklESXpDaUFnSUNCa2FXY2dNak1LSUNBZ0lHUnBaeUF5TVFvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKbGJGOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UUXRNekF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0IwZVhCbE9pQnVaWGNnVldsdWREZ29hWE5UZEdGaWJHVnpkMkZ3SUQ4Z1VFRkRWRjlVV1ZCRlgxTlVRVUpNUlZOWFFWQWdPaUJRUVVOVVgxUlpVRVZmUTA5T1UxUkJUbFJmVUZKUFJGVkRWQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBNVWxrTEFvZ0lDQWdMeThnSUNBdkx5QmhjM05sZENCcFpDQXdJR2x6SUVGTVIwOGdZVzVrSUdseklIUm9aU0FxY0hKcGJXRnllU29nWVhOelpYUWdiMjRnVUVGRFZDd2dkVzVzYVd0bElIUnBibmx0WVc0Z2QyaGxjbVVnYVhRZ2FYTWdZWE56WlhRZ01nb2dJQ0FnTHk4Z0lDQmhjM05sZERGVmJtbDBUbUZ0WlRvZ1oyVjBRWE56WlhSVmJtbDBUbUZ0WlNoaGMzTmxkREZKWkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwTWtsa0xBb2dJQ0FnTHk4Z0lDQmhjM05sZERKVmJtbDBUbUZ0WlRvZ1oyVjBRWE56WlhSVmJtbDBUbUZ0WlNoaGMzTmxkREpKWkNrc0NpQWdJQ0F2THlBZ0lHWmxaVUp3Y3pvZ2FHRnpSbVZsUW5CeklEOGdabVZsUW5CeklEb2dZMjl1Wm1sblJtVmxRbkJ6TEFvZ0lDQWdMeThnZlRzS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01XUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU9TQXZMeUF5T1FvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFltVnNYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROQzB4T0RrS0lDQWdJQzh2SUdkbGRGQmhZM1JRYjI5c1NXNW1ieWdLSUNBZ0lDOHZJQ0FnY0dGamRFRndjRWxrTEFvZ0lDQWdMeThnSUNCamIyNXpkR0Z1ZEZCeWIyUjFZM1JEY21WaGRHOXlMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdjM1JoWW14bGMzZGhjRU55WldGMGIzSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQnRZVzVoWjJWa1YyVnBaMmgwWldSRGNtVmhkRzl5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQmlJR2RsZEZCaFkzUkpibVp2WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyRmlaV3hmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbWRsZEZCaFkzUlFiMjlzU1c1bWIwQXpNd29LWjJWMFVHRmpkRWx1Wm05ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW1Wc1gzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE13b2dJQ0FnTHk4Z2FXWWdLR2x6VTNSaFlteGxjM2RoY0NBL0lDRnBjMU4wWVdKc1pYTjNZWEJEY21WaGRHOXlJRG9nSVdselEyOXVjM1JRY205a2RXTjBLU0J5WlhSMWNtNGdaMlYwUlcxd2RIbFFZV04wU1c1bWJ5Z3BPd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQWhDaUFnSUNCaUlHZGxkRkJoWTNSSmJtWnZYM1JsY201aGNubGZiV1Z5WjJWQU1qY0tDbWRsZEZCaFkzUkpibVp2WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaVpXeGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzl1UTNKbFlYUmxPaUFpWVd4c2IzY2lJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdRd01EQXdNREF3TURBd01EQXdNREF3TURBeFpqQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRWdDQUFtQXdBaEFBQUFBQUFBQUFBQUFCMEFBQUFBQUFBQUFBQWZBQUFBQUFBQUFBQUFBQUFBQWdBZE1SdEJBRDB4R1JSRWdnY0VTSGVwWndUVnF6Tm1CTUx0ZEQ4RXB3NWlvQVRDK05ZWEJIUXJDN29FbENqWGtEWWFBSTRIQUVJQXRRSGJBZTBDTndLVUE3UUFJekVaa0lFd0dqRVlFRVFoQkNNU1FRQUtNUUF5Q1JKQkFBSWpReUpEaWdFQklvdi9RQUFJZ0FSQlRFZFBUSW1MLzNFRFRJd0FRUUFFaXdCTWlTaEMvL29pS0RZYUFVY0NJbGxKVGdJa0M0RUNDRXdWRWtRaVNVc0NERUVBUFVzQ1Z3SUFTd0VrQ3lSWVNVVUdZRWxGQlVFQUVrc0VlRXNFRmt3V1VMQkpJd2hGQVVMLzBvQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFMQkMvK0tBRkJVZmZIVUFBQUFBQUFBQUFBQUFBQUFBQUFBQXNDTkRJa2NES0RZYUFVY0NJbGxKVGdJbEM0RUNDRXdWRWtRMkdnSkpGU1VTUkJjaVNVc0RERUVBNkVzRFZ3SUFTd0VsQzBvbFdFVUxXMGxGQm5FTFJRRkFBQmlBRFFBSEFBa0FBQXNBQUFBQUFBQ3dTU01JUlFGQy84aExBVUVBcnJHQUJKZjBDb3F5R2tzSXNocUFCQUFDY0hheUdpS3lHVXNCc2hpQkJySVFJcklCczdRK1NWY0VBRXhYQUFTQUJCVWZmSFVTUkVrVkpSSkVGMHNGU1hFRVRFVUtSRWx4QTB4RkNVUnhBVVFXU1pNbERrUlhCd0ZGQ1VBQVJJQUNBQUJMQjBrVkZsY0dBa3hRU1JXQkJ3aExDRWtWRmxjR0FreFFTd0VXVndZQ2dBSUFCMHhRU3dFVlR3TUlURXNNVUV3V1Z3WUNVRThDVUV4UVRGQ3dRdjlTZ0FnQUFRQUNBQUp3ZGtML3N5SkMvNHFBRVJVZmZIVUFCd0FKQUFBTEFBQUFBQUFBc0NORE5ob0JGU01TUklBR0ZSOThkUUFBc0NORE5ob0JTUlVsRWtRWE5ob0NTUlVsRWtRWFRFbExBZzVCQUJ0SEF0RUJGa21USkE1RVZ3UUVTd0hSQ0JaUXNDTUlSUUZDLzk2QUVCVWZmSFVBQUFBQUFBQUFBQUFBQUFDd0kwTTJHZ0ZIQWlKWlNVNENKQXVCQWdoTUZSSkVJa2xMQWd4QkFCbExBbGNDQUVzQlNVNENKQXNrV0hNQ1NMQWpDRVVCUXYvZ2dDUVZIM3gxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ3dJME1pU1NoSEF6WWFBVWtWSlJKRUYwazJHZ0pKVGdKSklsbEpUZ01rQzRFQ0NFd1ZFa1J5Q0VRaVNVc0RERUVBejBzRFZ3SUFTd0VrQ3lSWVNVVU1TWE1DU0VzREVrVUhTd1ZoUVFDVFN3cEpTd1pKVGdPQUNtRnpjMlYwWHpGZmFXUmpUZ05GREV5QUNtRnpjMlYwWHpKZmFXUmpSUXBGQ0VFQVgwc0lpUDBNUlFwTEIwRUFUMHNHaVAwQWdBRUFJa3NJVkVzS0ZsQkxDMGtWRmxjR0FreFFUSUFDQUJWUVN3RVZnUlVJU3dvV1R3Sk1VRThEU1JVV1Z3WUNURkJQQWhaWEJnSlBBa3hRVHdKUVRGQ3dTU01JUlFGQy8xTW9Rdit5S0VVS1F2K2lnQmtBQUFBQUFBQUFBQUFBRlFBQUFBQUFBQUFBQUJjQUFBQUFzRUwvejRBZEZSOThkUUFBQUFBQUFBQUFBQUFWQUFBQUFBQUFBQUFBRndBQUFBQ3dJME1pU1NoSERqWWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGU1FTUkRZYUJFY0NJbGxKVGdJbEM0RUNDRXdWRWtRaVNVc0NERUVCMjBzQ1Z3SUFTd0VsQzF0SlJRbUJnQUlNUVFBS0tiQkpJd2hGQVVMLzIwc0hjZ2RNUlJkQUFBUXBRdi9wU3hWSlN3Y1NTVTRDUlE5SlN3Y1NSUXhMQlJKRkRVQUFEa3NKUUFBSlN3dEFBQVFwUXYvQ1N3ZEpnQXh6ZDJGd1gyWmxaVjlpY0hObFRnSkZDMG1BQjJGemMyVjBYMkZsUlJSRkY0QUhZWE56WlhSZlltVkZFa1VWUVFCalN4QkJBRjVMRDBFQVdVc0xRQUFFS1VML2VVc1VTWWo3a1VzVlNVNERpUHVKVHdJV2dBRURURkJMQWhVV1Z3WUNUd05RVENwUVN3RVZnUjBJVHdRV1R3Sk1VRXNERlJaWEJnSlBCRkJQQWhaWEJnSlBBa3hRU3dzV1VFOENVRXhRUXY4cFN3ZEpnQVpEVDA1R1NVZGxUZ0pGR1lBRVRGUkpSR1ZGRUVoQkFCRkxEVUVBREVzV0ZVbEZDSUVZREVFQUJDbEMvdmRMQjRBSlNVNUpWRWxCVEY5QlpVVUJTd2NrRHhCSlJReEJBSnhMQ1JSQkFBUXBRdjdTU3hhQkVGdEZFMHNIZ0FkR1JVVmZRbEJUWlVsT0FrVVJSUk5CQUF4TEVVc1RFMEVBQkNsQy9xbExGa2tpVzB3bFd5T0JBa3NPVFJaSmt5VU9SRmNIQVVzQ2lQcXJTd0tJK3FaTEYwc1hTeFZOVHdVV1R3Uk1VRXNERlJaWEJnSlBCRkJNS2xCTEFSV0JIUWhQQlJaUEFreFFTd1FWRmxjR0FrOEZVRThDRmxjR0FrOENURkJQQXhaUVR3SlFURkJDL2tCTERCUkMvMkdBSlJVZmZIVUFBQUFBQUFBQUFBQUFIUUFBQUFBQUFBQUFBQjhBQUFBQUFBQUFBQUFBQUFDd0kwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVUERBVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
