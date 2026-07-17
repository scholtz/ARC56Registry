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

namespace Arc56.Generated.d13co.reti_ghost_sdk.RetiReader_bc163321
{


    public class RetiReaderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RetiReaderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AssetInfo : AVMObjectType
            {
                public ulong AssetId { get; set; }

                public Algorand.Address Creator { get; set; }

                public ulong Total { get; set; }

                public byte Decimals { get; set; }

                public string UnitName { get; set; }

                public string Name { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotal.From(Total);
                    ret.AddRange(vTotal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
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

                public static AssetInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AssetInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
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
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AssetInfo);
                }
                public bool Equals(AssetInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AssetInfo left, AssetInfo right)
                {
                    return EqualityComparer<AssetInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(AssetInfo left, AssetInfo right)
                {
                    return !(left == right);
                }

            }

            public class Constraints : AVMObjectType
            {
                public ulong EpochPayoutRoundsMin { get; set; }

                public ulong EpochPayoutRoundsMax { get; set; }

                public ulong MinPctToValidatorWFourDecimals { get; set; }

                public ulong MaxPctToValidatorWFourDecimals { get; set; }

                public ulong MinEntryStake { get; set; }

                public ulong MaxAlgoPerPool { get; set; }

                public ulong MaxAlgoPerValidator { get; set; }

                public ulong AmtConsideredSaturated { get; set; }

                public ulong MaxNodes { get; set; }

                public ulong MaxPoolsPerNode { get; set; }

                public ulong MaxStakersPerPool { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochPayoutRoundsMin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpochPayoutRoundsMin.From(EpochPayoutRoundsMin);
                    ret.AddRange(vEpochPayoutRoundsMin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochPayoutRoundsMax = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpochPayoutRoundsMax.From(EpochPayoutRoundsMax);
                    ret.AddRange(vEpochPayoutRoundsMax.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinPctToValidatorWFourDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinPctToValidatorWFourDecimals.From(MinPctToValidatorWFourDecimals);
                    ret.AddRange(vMinPctToValidatorWFourDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPctToValidatorWFourDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxPctToValidatorWFourDecimals.From(MaxPctToValidatorWFourDecimals);
                    ret.AddRange(vMaxPctToValidatorWFourDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinEntryStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinEntryStake.From(MinEntryStake);
                    ret.AddRange(vMinEntryStake.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxAlgoPerPool.From(MaxAlgoPerPool);
                    ret.AddRange(vMaxAlgoPerPool.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxAlgoPerValidator.From(MaxAlgoPerValidator);
                    ret.AddRange(vMaxAlgoPerValidator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmtConsideredSaturated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmtConsideredSaturated.From(AmtConsideredSaturated);
                    ret.AddRange(vAmtConsideredSaturated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxNodes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxNodes.From(MaxNodes);
                    ret.AddRange(vMaxNodes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxPoolsPerNode.From(MaxPoolsPerNode);
                    ret.AddRange(vMaxPoolsPerNode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxStakersPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxStakersPerPool.From(MaxStakersPerPool);
                    ret.AddRange(vMaxStakersPerPool.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Constraints Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Constraints();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochPayoutRoundsMin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpochPayoutRoundsMin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpochPayoutRoundsMin = vEpochPayoutRoundsMin.ToValue();
                    if (valueEpochPayoutRoundsMin is ulong vEpochPayoutRoundsMinValue) { ret.EpochPayoutRoundsMin = vEpochPayoutRoundsMinValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochPayoutRoundsMax = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpochPayoutRoundsMax.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpochPayoutRoundsMax = vEpochPayoutRoundsMax.ToValue();
                    if (valueEpochPayoutRoundsMax is ulong vEpochPayoutRoundsMaxValue) { ret.EpochPayoutRoundsMax = vEpochPayoutRoundsMaxValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinPctToValidatorWFourDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinPctToValidatorWFourDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinPctToValidatorWFourDecimals = vMinPctToValidatorWFourDecimals.ToValue();
                    if (valueMinPctToValidatorWFourDecimals is ulong vMinPctToValidatorWFourDecimalsValue) { ret.MinPctToValidatorWFourDecimals = vMinPctToValidatorWFourDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPctToValidatorWFourDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxPctToValidatorWFourDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxPctToValidatorWFourDecimals = vMaxPctToValidatorWFourDecimals.ToValue();
                    if (valueMaxPctToValidatorWFourDecimals is ulong vMaxPctToValidatorWFourDecimalsValue) { ret.MaxPctToValidatorWFourDecimals = vMaxPctToValidatorWFourDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinEntryStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinEntryStake.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinEntryStake = vMinEntryStake.ToValue();
                    if (valueMinEntryStake is ulong vMinEntryStakeValue) { ret.MinEntryStake = vMinEntryStakeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxAlgoPerPool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxAlgoPerPool = vMaxAlgoPerPool.ToValue();
                    if (valueMaxAlgoPerPool is ulong vMaxAlgoPerPoolValue) { ret.MaxAlgoPerPool = vMaxAlgoPerPoolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxAlgoPerValidator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxAlgoPerValidator = vMaxAlgoPerValidator.ToValue();
                    if (valueMaxAlgoPerValidator is ulong vMaxAlgoPerValidatorValue) { ret.MaxAlgoPerValidator = vMaxAlgoPerValidatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmtConsideredSaturated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmtConsideredSaturated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmtConsideredSaturated = vAmtConsideredSaturated.ToValue();
                    if (valueAmtConsideredSaturated is ulong vAmtConsideredSaturatedValue) { ret.AmtConsideredSaturated = vAmtConsideredSaturatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxNodes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxNodes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxNodes = vMaxNodes.ToValue();
                    if (valueMaxNodes is ulong vMaxNodesValue) { ret.MaxNodes = vMaxNodesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxPoolsPerNode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxPoolsPerNode = vMaxPoolsPerNode.ToValue();
                    if (valueMaxPoolsPerNode is ulong vMaxPoolsPerNodeValue) { ret.MaxPoolsPerNode = vMaxPoolsPerNodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxStakersPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxStakersPerPool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxStakersPerPool = vMaxStakersPerPool.ToValue();
                    if (valueMaxStakersPerPool is ulong vMaxStakersPerPoolValue) { ret.MaxStakersPerPool = vMaxStakersPerPoolValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Constraints);
                }
                public bool Equals(Constraints? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Constraints left, Constraints right)
                {
                    return EqualityComparer<Constraints>.Default.Equals(left, right);
                }
                public static bool operator !=(Constraints left, Constraints right)
                {
                    return !(left == right);
                }

            }

            public class MbrAmounts : AVMObjectType
            {
                public ulong AddValidatorMbr { get; set; }

                public ulong AddPoolMbr { get; set; }

                public ulong PoolInitMbr { get; set; }

                public ulong AddStakerMbr { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddValidatorMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAddValidatorMbr.From(AddValidatorMbr);
                    ret.AddRange(vAddValidatorMbr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddPoolMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAddPoolMbr.From(AddPoolMbr);
                    ret.AddRange(vAddPoolMbr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolInitMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolInitMbr.From(PoolInitMbr);
                    ret.AddRange(vPoolInitMbr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddStakerMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAddStakerMbr.From(AddStakerMbr);
                    ret.AddRange(vAddStakerMbr.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MbrAmounts Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MbrAmounts();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddValidatorMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAddValidatorMbr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddValidatorMbr = vAddValidatorMbr.ToValue();
                    if (valueAddValidatorMbr is ulong vAddValidatorMbrValue) { ret.AddValidatorMbr = vAddValidatorMbrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddPoolMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAddPoolMbr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddPoolMbr = vAddPoolMbr.ToValue();
                    if (valueAddPoolMbr is ulong vAddPoolMbrValue) { ret.AddPoolMbr = vAddPoolMbrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolInitMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolInitMbr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolInitMbr = vPoolInitMbr.ToValue();
                    if (valuePoolInitMbr is ulong vPoolInitMbrValue) { ret.PoolInitMbr = vPoolInitMbrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddStakerMbr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAddStakerMbr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddStakerMbr = vAddStakerMbr.ToValue();
                    if (valueAddStakerMbr is ulong vAddStakerMbrValue) { ret.AddStakerMbr = vAddStakerMbrValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MbrAmounts);
                }
                public bool Equals(MbrAmounts? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MbrAmounts left, MbrAmounts right)
                {
                    return EqualityComparer<MbrAmounts>.Default.Equals(left, right);
                }
                public static bool operator !=(MbrAmounts left, MbrAmounts right)
                {
                    return !(left == right);
                }

            }

            public class NodePoolAssignmentConfig : AVMObjectType
            {
                public Structs.NodePoolAssignmentConfigNodes[] Nodes { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    var arrNodes = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NodePoolAssignmentConfigNodes>(x => Structs.NodePoolAssignmentConfigNodes.Parse(x)) { IsFixedLength = true, FixedLength = 8 };
                    arrNodes.Value = (Nodes ?? Array.Empty<Structs.NodePoolAssignmentConfigNodes>()).ToList();
                    ret.AddRange(arrNodes.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NodePoolAssignmentConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NodePoolAssignmentConfig();
                    var arrNodes = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NodePoolAssignmentConfigNodes>(x => Structs.NodePoolAssignmentConfigNodes.Parse(x)) { IsFixedLength = true, FixedLength = 8 };
                    { var consumedNodes = (int)arrNodes.Decode(queue.ToArray()); for (int i = 0; i < consumedNodes && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Nodes = arrNodes.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NodePoolAssignmentConfig);
                }
                public bool Equals(NodePoolAssignmentConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NodePoolAssignmentConfig left, NodePoolAssignmentConfig right)
                {
                    return EqualityComparer<NodePoolAssignmentConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(NodePoolAssignmentConfig left, NodePoolAssignmentConfig right)
                {
                    return !(left == right);
                }

            }

            public class PoolInfo : AVMObjectType
            {
                public ulong PoolAppId { get; set; }

                public ushort TotalStakers { get; set; }

                public ulong TotalAlgoStaked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolAppId.From(PoolAppId);
                    ret.AddRange(vPoolAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStakers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vTotalStakers.From(TotalStakers);
                    ret.AddRange(vTotalStakers.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAlgoStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAlgoStaked.From(TotalAlgoStaked);
                    ret.AddRange(vTotalAlgoStaked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolAppId = vPoolAppId.ToValue();
                    if (valuePoolAppId is ulong vPoolAppIdValue) { ret.PoolAppId = vPoolAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStakers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vTotalStakers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalStakers = vTotalStakers.ToValue();
                    if (valueTotalStakers is ushort vTotalStakersValue) { ret.TotalStakers = vTotalStakersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAlgoStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAlgoStaked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAlgoStaked = vTotalAlgoStaked.ToValue();
                    if (valueTotalAlgoStaked is ulong vTotalAlgoStakedValue) { ret.TotalAlgoStaked = vTotalAlgoStakedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolInfo);
                }
                public bool Equals(PoolInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolInfo left, PoolInfo right)
                {
                    return EqualityComparer<PoolInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolInfo left, PoolInfo right)
                {
                    return !(left == right);
                }

            }

            public class ValidatorConfig : AVMObjectType
            {
                public ulong Id { get; set; }

                public Algorand.Address Owner { get; set; }

                public Algorand.Address Manager { get; set; }

                public ulong NfdForInfo { get; set; }

                public byte EntryGatingType { get; set; }

                public Algorand.Address EntryGatingAddress { get; set; }

                public ulong[] EntryGatingAssets { get; set; }

                public ulong GatingAssetMinBalance { get; set; }

                public ulong RewardTokenId { get; set; }

                public ulong RewardPerPayout { get; set; }

                public uint EpochRoundLength { get; set; }

                public uint PercentToValidator { get; set; }

                public Algorand.Address ValidatorCommissionAddress { get; set; }

                public ulong MinEntryStake { get; set; }

                public ulong MaxAlgoPerPool { get; set; }

                public byte PoolsPerNode { get; set; }

                public ulong SunsettingOn { get; set; }

                public ulong SunsettingTo { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vManager.From(Manager);
                    ret.AddRange(vManager.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNfdForInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNfdForInfo.From(NfdForInfo);
                    ret.AddRange(vNfdForInfo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vEntryGatingType.From(EntryGatingType);
                    ret.AddRange(vEntryGatingType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vEntryGatingAddress.From(EntryGatingAddress);
                    ret.AddRange(vEntryGatingAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    vEntryGatingAssets.From(EntryGatingAssets);
                    ret.AddRange(vEntryGatingAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGatingAssetMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGatingAssetMinBalance.From(GatingAssetMinBalance);
                    ret.AddRange(vGatingAssetMinBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRewardTokenId.From(RewardTokenId);
                    ret.AddRange(vRewardTokenId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardPerPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRewardPerPayout.From(RewardPerPayout);
                    ret.AddRange(vRewardPerPayout.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochRoundLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vEpochRoundLength.From(EpochRoundLength);
                    ret.AddRange(vEpochRoundLength.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentToValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vPercentToValidator.From(PercentToValidator);
                    ret.AddRange(vPercentToValidator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorCommissionAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vValidatorCommissionAddress.From(ValidatorCommissionAddress);
                    ret.AddRange(vValidatorCommissionAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinEntryStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinEntryStake.From(MinEntryStake);
                    ret.AddRange(vMinEntryStake.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxAlgoPerPool.From(MaxAlgoPerPool);
                    ret.AddRange(vMaxAlgoPerPool.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vPoolsPerNode.From(PoolsPerNode);
                    ret.AddRange(vPoolsPerNode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSunsettingOn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSunsettingOn.From(SunsettingOn);
                    ret.AddRange(vSunsettingOn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSunsettingTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSunsettingTo.From(SunsettingTo);
                    ret.AddRange(vSunsettingTo.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidatorConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidatorConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vManager.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueManager = vManager.ToValue();
                    if (valueManager is Algorand.Address vManagerValue) { ret.Manager = vManagerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNfdForInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNfdForInfo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNfdForInfo = vNfdForInfo.ToValue();
                    if (valueNfdForInfo is ulong vNfdForInfoValue) { ret.NfdForInfo = vNfdForInfoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vEntryGatingType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryGatingType = vEntryGatingType.ToValue();
                    if (valueEntryGatingType is byte vEntryGatingTypeValue) { ret.EntryGatingType = vEntryGatingTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vEntryGatingAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryGatingAddress = vEntryGatingAddress.ToValue();
                    if (valueEntryGatingAddress is Algorand.Address vEntryGatingAddressValue) { ret.EntryGatingAddress = vEntryGatingAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    count = vEntryGatingAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryGatingAssets = vEntryGatingAssets.ToValue();
                    if (valueEntryGatingAssets is ulong[] vEntryGatingAssetsValue) { ret.EntryGatingAssets = vEntryGatingAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGatingAssetMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGatingAssetMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGatingAssetMinBalance = vGatingAssetMinBalance.ToValue();
                    if (valueGatingAssetMinBalance is ulong vGatingAssetMinBalanceValue) { ret.GatingAssetMinBalance = vGatingAssetMinBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRewardTokenId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRewardTokenId = vRewardTokenId.ToValue();
                    if (valueRewardTokenId is ulong vRewardTokenIdValue) { ret.RewardTokenId = vRewardTokenIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardPerPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRewardPerPayout.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRewardPerPayout = vRewardPerPayout.ToValue();
                    if (valueRewardPerPayout is ulong vRewardPerPayoutValue) { ret.RewardPerPayout = vRewardPerPayoutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochRoundLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vEpochRoundLength.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpochRoundLength = vEpochRoundLength.ToValue();
                    if (valueEpochRoundLength is uint vEpochRoundLengthValue) { ret.EpochRoundLength = vEpochRoundLengthValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentToValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vPercentToValidator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePercentToValidator = vPercentToValidator.ToValue();
                    if (valuePercentToValidator is uint vPercentToValidatorValue) { ret.PercentToValidator = vPercentToValidatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorCommissionAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vValidatorCommissionAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidatorCommissionAddress = vValidatorCommissionAddress.ToValue();
                    if (valueValidatorCommissionAddress is Algorand.Address vValidatorCommissionAddressValue) { ret.ValidatorCommissionAddress = vValidatorCommissionAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinEntryStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinEntryStake.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinEntryStake = vMinEntryStake.ToValue();
                    if (valueMinEntryStake is ulong vMinEntryStakeValue) { ret.MinEntryStake = vMinEntryStakeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxAlgoPerPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxAlgoPerPool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxAlgoPerPool = vMaxAlgoPerPool.ToValue();
                    if (valueMaxAlgoPerPool is ulong vMaxAlgoPerPoolValue) { ret.MaxAlgoPerPool = vMaxAlgoPerPoolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vPoolsPerNode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolsPerNode = vPoolsPerNode.ToValue();
                    if (valuePoolsPerNode is byte vPoolsPerNodeValue) { ret.PoolsPerNode = vPoolsPerNodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSunsettingOn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSunsettingOn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSunsettingOn = vSunsettingOn.ToValue();
                    if (valueSunsettingOn is ulong vSunsettingOnValue) { ret.SunsettingOn = vSunsettingOnValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSunsettingTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSunsettingTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSunsettingTo = vSunsettingTo.ToValue();
                    if (valueSunsettingTo is ulong vSunsettingToValue) { ret.SunsettingTo = vSunsettingToValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidatorConfig);
                }
                public bool Equals(ValidatorConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidatorConfig left, ValidatorConfig right)
                {
                    return EqualityComparer<ValidatorConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidatorConfig left, ValidatorConfig right)
                {
                    return !(left == right);
                }

            }

            public class ValidatorCurState : AVMObjectType
            {
                public ushort NumPools { get; set; }

                public ulong TotalStakers { get; set; }

                public ulong TotalAlgoStaked { get; set; }

                public ulong RewardTokenHeldBack { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumPools = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vNumPools.From(NumPools);
                    ret.AddRange(vNumPools.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStakers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalStakers.From(TotalStakers);
                    ret.AddRange(vTotalStakers.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAlgoStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAlgoStaked.From(TotalAlgoStaked);
                    ret.AddRange(vTotalAlgoStaked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardTokenHeldBack = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRewardTokenHeldBack.From(RewardTokenHeldBack);
                    ret.AddRange(vRewardTokenHeldBack.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidatorCurState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidatorCurState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumPools = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vNumPools.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumPools = vNumPools.ToValue();
                    if (valueNumPools is ushort vNumPoolsValue) { ret.NumPools = vNumPoolsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStakers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalStakers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalStakers = vTotalStakers.ToValue();
                    if (valueTotalStakers is ulong vTotalStakersValue) { ret.TotalStakers = vTotalStakersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAlgoStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAlgoStaked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAlgoStaked = vTotalAlgoStaked.ToValue();
                    if (valueTotalAlgoStaked is ulong vTotalAlgoStakedValue) { ret.TotalAlgoStaked = vTotalAlgoStakedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewardTokenHeldBack = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRewardTokenHeldBack.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRewardTokenHeldBack = vRewardTokenHeldBack.ToValue();
                    if (valueRewardTokenHeldBack is ulong vRewardTokenHeldBackValue) { ret.RewardTokenHeldBack = vRewardTokenHeldBackValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidatorCurState);
                }
                public bool Equals(ValidatorCurState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidatorCurState left, ValidatorCurState right)
                {
                    return EqualityComparer<ValidatorCurState>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidatorCurState left, ValidatorCurState right)
                {
                    return !(left == right);
                }

            }

            public class MbrAmountsAndProtocolConstraints : AVMObjectType
            {
                public Structs.MbrAmounts MbrAmounts { get; set; } = new Structs.MbrAmounts();

                public Structs.Constraints Constraints { get; set; } = new Structs.Constraints();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(MbrAmounts.ToByteArray());
                    ret.AddRange(Constraints.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MbrAmountsAndProtocolConstraints Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MbrAmountsAndProtocolConstraints();
                    ret.MbrAmounts = Structs.MbrAmounts.Parse(queue.ToArray());
                    { var consumedMbrAmounts = ret.MbrAmounts.ToByteArray().Length; for (int i = 0; i < consumedMbrAmounts && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Constraints = Structs.Constraints.Parse(queue.ToArray());
                    { var consumedConstraints = ret.Constraints.ToByteArray().Length; for (int i = 0; i < consumedConstraints && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MbrAmountsAndProtocolConstraints);
                }
                public bool Equals(MbrAmountsAndProtocolConstraints? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MbrAmountsAndProtocolConstraints left, MbrAmountsAndProtocolConstraints right)
                {
                    return EqualityComparer<MbrAmountsAndProtocolConstraints>.Default.Equals(left, right);
                }
                public static bool operator !=(MbrAmountsAndProtocolConstraints left, MbrAmountsAndProtocolConstraints right)
                {
                    return !(left == right);
                }

            }

            public class Validator : AVMObjectType
            {
                public Structs.ValidatorConfig Config { get; set; } = new Structs.ValidatorConfig();

                public Structs.ValidatorCurState State { get; set; } = new Structs.ValidatorCurState();

                public Structs.PoolInfo[] PoolInfo { get; set; }

                public Structs.NodePoolAssignmentConfig NodeAssignment { get; set; } = new Structs.NodePoolAssignmentConfig();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Config.ToByteArray());
                    ret.AddRange(State.ToByteArray());
                    var arrPoolInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrPoolInfo.Value = (PoolInfo ?? Array.Empty<Structs.PoolInfo>()).ToList();
                    stringRef[ret.Count] = arrPoolInfo.Encode();
                    ret.AddRange(new byte[2]);
                    ret.AddRange(NodeAssignment.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Validator Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Validator();
                    ret.Config = Structs.ValidatorConfig.Parse(queue.ToArray());
                    { var consumedConfig = ret.Config.ToByteArray().Length; for (int i = 0; i < consumedConfig && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.State = Structs.ValidatorCurState.Parse(queue.ToArray());
                    { var consumedState = ret.State.ToByteArray().Length; for (int i = 0; i < consumedState && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var indexPoolInfo = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrPoolInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrPoolInfo.Decode(bytes.Skip(indexPoolInfo + prefixOffset).ToArray());
                    ret.PoolInfo = arrPoolInfo.Value.ToArray();
                    ret.NodeAssignment = Structs.NodePoolAssignmentConfig.Parse(queue.ToArray());
                    { var consumedNodeAssignment = ret.NodeAssignment.ToByteArray().Length; for (int i = 0; i < consumedNodeAssignment && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Validator);
                }
                public bool Equals(Validator? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Validator left, Validator right)
                {
                    return EqualityComparer<Validator>.Default.Equals(left, right);
                }
                public static bool operator !=(Validator left, Validator right)
                {
                    return !(left == right);
                }

            }

            public class ValidatorPoolInfo : AVMObjectType
            {
                public ulong ValidatorId { get; set; }

                public Structs.PoolInfo PoolInfo { get; set; } = new Structs.PoolInfo();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValidatorId.From(ValidatorId);
                    ret.AddRange(vValidatorId.Encode());
                    ret.AddRange(PoolInfo.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidatorPoolInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidatorPoolInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValidatorId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidatorId = vValidatorId.ToValue();
                    if (valueValidatorId is ulong vValidatorIdValue) { ret.ValidatorId = vValidatorIdValue; }
                    ret.PoolInfo = Structs.PoolInfo.Parse(queue.ToArray());
                    { var consumedPoolInfo = ret.PoolInfo.ToByteArray().Length; for (int i = 0; i < consumedPoolInfo && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidatorPoolInfo);
                }
                public bool Equals(ValidatorPoolInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidatorPoolInfo left, ValidatorPoolInfo right)
                {
                    return EqualityComparer<ValidatorPoolInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidatorPoolInfo left, ValidatorPoolInfo right)
                {
                    return !(left == right);
                }

            }

            public class GetPoolBalancesAndLastPayoutsReturn : AVMObjectType
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

                public static GetPoolBalancesAndLastPayoutsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPoolBalancesAndLastPayoutsReturn();
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
                    return Equals(obj as GetPoolBalancesAndLastPayoutsReturn);
                }
                public bool Equals(GetPoolBalancesAndLastPayoutsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPoolBalancesAndLastPayoutsReturn left, GetPoolBalancesAndLastPayoutsReturn right)
                {
                    return EqualityComparer<GetPoolBalancesAndLastPayoutsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPoolBalancesAndLastPayoutsReturn left, GetPoolBalancesAndLastPayoutsReturn right)
                {
                    return !(left == right);
                }

            }

            public class NodePoolAssignmentConfigNodes : AVMObjectType
            {
                public ulong[] Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NodePoolAssignmentConfigNodes Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NodePoolAssignmentConfigNodes();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong[] vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NodePoolAssignmentConfigNodes);
                }
                public bool Equals(NodePoolAssignmentConfigNodes? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NodePoolAssignmentConfigNodes left, NodePoolAssignmentConfigNodes right)
                {
                    return EqualityComparer<NodePoolAssignmentConfigNodes>.Default.Equals(left, right);
                }
                public static bool operator !=(NodePoolAssignmentConfigNodes left, NodePoolAssignmentConfigNodes right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        public async Task<Structs.MbrAmountsAndProtocolConstraints> GetMbrAmountsAndProtocolConstraints(ulong registryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 191, 132, 69 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MbrAmountsAndProtocolConstraints.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMbrAmountsAndProtocolConstraints_Transactions(ulong registryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 191, 132, 69 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        /// <param name="validatorIds"> </param>
        public async Task<Structs.ValidatorConfig> GetValidatorConfig(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 196, 66, 90 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidatorConfig_Transactions(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 196, 66, 90 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        /// <param name="validatorIds"> </param>
        public async Task<Structs.ValidatorCurState> GetValidatorStates(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 224, 12, 128 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorCurState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidatorStates_Transactions(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 224, 12, 128 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        /// <param name="validatorIds"> </param>
        public async Task<Structs.ValidatorPoolInfo> GetPools(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 136, 41, 39 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorPoolInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPools_Transactions(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 136, 41, 39 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        /// <param name="validatorIds"> </param>
        public async Task<Structs.NodePoolAssignmentConfig> GetNodePoolAssignments(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 47, 17, 50 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NodePoolAssignmentConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetNodePoolAssignments_Transactions(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 47, 17, 50 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryAppId"> </param>
        /// <param name="validatorIds"> </param>
        public async Task<Structs.Validator> GetValidators(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 201, 138, 107 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            var result = await base.SimApp(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Validator.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidators_Transactions(ulong registryAppId, ulong[] validatorIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 201, 138, 107 };
            var registryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAppIdAbi.From(registryAppId);
            var validatorIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); validatorIdsAbi.From(validatorIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAppIdAbi, validatorIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="num"> </param>
        public async Task<ulong> GetBlockTimestamps(ulong num, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 59, 139, 74 };
            var numAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numAbi.From(num);

            var result = await base.SimApp(new List<object> { abiHandle, numAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBlockTimestamps_Transactions(ulong num, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 59, 139, 74 };
            var numAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numAbi.From(num);

            return await base.MakeTransactionList(new List<object> { abiHandle, numAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolAppIds"> </param>
        public async Task<string> GetAlgodVersion(ulong[] poolAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 70, 11, 238 };
            var poolAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); poolAppIdsAbi.From(poolAppIds);

            var result = await base.SimApp(new List<object> { abiHandle, poolAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetAlgodVersion_Transactions(ulong[] poolAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 70, 11, 238 };
            var poolAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); poolAppIdsAbi.From(poolAppIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetIds"> </param>
        public async Task<Structs.AssetInfo> GetAssets(ulong[] assetIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 194, 157, 216 };
            var assetIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetIdsAbi.From(assetIds);

            var result = await base.SimApp(new List<object> { abiHandle, assetIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AssetInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAssets_Transactions(ulong[] assetIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 194, 157, 216 };
            var assetIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetIdsAbi.From(assetIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolAppIds"> </param>
        public async Task<Structs.GetPoolBalancesAndLastPayoutsReturn> GetPoolBalancesAndLastPayouts(ulong[] poolAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 148, 236, 121 };
            var poolAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); poolAppIdsAbi.From(poolAppIds);

            var result = await base.SimApp(new List<object> { abiHandle, poolAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPoolBalancesAndLastPayoutsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoolBalancesAndLastPayouts_Transactions(ulong[] poolAppIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 148, 236, 121 };
            var poolAppIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); poolAppIdsAbi.From(poolAppIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolAppIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmV0aVJlYWRlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBc3NldEluZm8iOlt7Im5hbWUiOiJhc3NldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRvdGFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlY2ltYWxzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoidW5pdE5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifV0sIkNvbnN0cmFpbnRzIjpbeyJuYW1lIjoiZXBvY2hQYXlvdXRSb3VuZHNNaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXBvY2hQYXlvdXRSb3VuZHNNYXgiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWluUGN0VG9WYWxpZGF0b3JXRm91ckRlY2ltYWxzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heFBjdFRvVmFsaWRhdG9yV0ZvdXJEZWNpbWFscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5FbnRyeVN0YWtlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heEFsZ29QZXJQb29sIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heEFsZ29QZXJWYWxpZGF0b3IiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW10Q29uc2lkZXJlZFNhdHVyYXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhOb2RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhQb29sc1Blck5vZGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4U3Rha2Vyc1BlclBvb2wiLCJ0eXBlIjoidWludDY0In1dLCJNYnJBbW91bnRzIjpbeyJuYW1lIjoiYWRkVmFsaWRhdG9yTWJyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkZFBvb2xNYnIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicG9vbEluaXRNYnIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRkU3Rha2VyTWJyIiwidHlwZSI6InVpbnQ2NCJ9XSwiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnIjpbeyJuYW1lIjoibm9kZXMiLCJ0eXBlIjoiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnTm9kZXNbOF0ifV0sIlBvb2xJbmZvIjpbeyJuYW1lIjoicG9vbEFwcElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsU3Rha2VycyIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJ0b3RhbEFsZ29TdGFrZWQiLCJ0eXBlIjoidWludDY0In1dLCJWYWxpZGF0b3JDb25maWciOlt7Im5hbWUiOiJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibWFuYWdlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmZkRm9ySW5mbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbnRyeUdhdGluZ1R5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJlbnRyeUdhdGluZ0FkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVudHJ5R2F0aW5nQXNzZXRzIiwidHlwZSI6InVpbnQ2NFs0XSJ9LHsibmFtZSI6ImdhdGluZ0Fzc2V0TWluQmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXdhcmRUb2tlbklkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFBlclBheW91dCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlcG9jaFJvdW5kTGVuZ3RoIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6InBlcmNlbnRUb1ZhbGlkYXRvciIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJ2YWxpZGF0b3JDb21taXNzaW9uQWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibWluRW50cnlTdGFrZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhBbGdvUGVyUG9vbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb29sc1Blck5vZGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJzdW5zZXR0aW5nT24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3Vuc2V0dGluZ1RvIiwidHlwZSI6InVpbnQ2NCJ9XSwiVmFsaWRhdG9yQ3VyU3RhdGUiOlt7Im5hbWUiOiJudW1Qb29scyIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJ0b3RhbFN0YWtlcnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBbGdvU3Rha2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFRva2VuSGVsZEJhY2siLCJ0eXBlIjoidWludDY0In1dLCJNYnJBbW91bnRzQW5kUHJvdG9jb2xDb25zdHJhaW50cyI6W3sibmFtZSI6Im1ickFtb3VudHMiLCJ0eXBlIjoiTWJyQW1vdW50cyJ9LHsibmFtZSI6ImNvbnN0cmFpbnRzIiwidHlwZSI6IkNvbnN0cmFpbnRzIn1dLCJWYWxpZGF0b3IiOlt7Im5hbWUiOiJjb25maWciLCJ0eXBlIjoiVmFsaWRhdG9yQ29uZmlnIn0seyJuYW1lIjoic3RhdGUiLCJ0eXBlIjoiVmFsaWRhdG9yQ3VyU3RhdGUifSx7Im5hbWUiOiJwb29sSW5mbyIsInR5cGUiOiJQb29sSW5mb1tdIn0seyJuYW1lIjoibm9kZUFzc2lnbm1lbnQiLCJ0eXBlIjoiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnIn1dLCJWYWxpZGF0b3JQb29sSW5mbyI6W3sibmFtZSI6InZhbGlkYXRvcklkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2xJbmZvIiwidHlwZSI6IlBvb2xJbmZvIn1dLCJHZXRQb29sQmFsYW5jZXNBbmRMYXN0UGF5b3V0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dLCJOb2RlUG9vbEFzc2lnbm1lbnRDb25maWdOb2RlcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjRbM10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0TWJyQW1vdW50c0FuZFByb3RvY29sQ29uc3RyYWludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCksKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpKSIsInN0cnVjdCI6Ik1ickFtb3VudHNBbmRQcm90b2NvbENvbnN0cmFpbnRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWYWxpZGF0b3JDb25maWciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ4LGFkZHJlc3MsdWludDY0WzRdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQzMix1aW50MzIsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmFsaWRhdG9yQ29uZmlnIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWYWxpZGF0b3JTdGF0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQxNix1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3JDdXJTdGF0ZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCwodWludDY0LHVpbnQxNix1aW50NjQpKSIsInN0cnVjdCI6IlZhbGlkYXRvclBvb2xJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXROb2RlUG9vbEFzc2lnbm1lbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5QXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDY0WzNdKVs4XSkiLCJzdHJ1Y3QiOiJOb2RlUG9vbEFzc2lnbm1lbnRDb25maWciLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFZhbGlkYXRvcnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCx1aW50OCxhZGRyZXNzLHVpbnQ2NFs0XSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50MzIsdWludDMyLGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0KSwodWludDE2LHVpbnQ2NCx1aW50NjQsdWludDY0KSwodWludDY0LHVpbnQxNix1aW50NjQpW10sKCh1aW50NjRbM10pWzhdKSkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3IiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEJsb2NrVGltZXN0YW1wcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFsZ29kVmVyc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xBcHBJZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFzc2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyx1aW50NjQsdWludDgsc3RyaW5nLHN0cmluZykiLCJzdHJ1Y3QiOiJBc3NldEluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBvb2xCYWxhbmNlc0FuZExhc3RQYXlvdXRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbEFwcElkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRQb29sQmFsYW5jZXNBbmRMYXN0UGF5b3V0c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTMsMjM1LDIwNTMsMjEwNiwyMTU4LDIyMTddLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgb25lIG9mIFVwZGF0ZUFwcGxpY2F0aW9uLCBEZWxldGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1NF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MTQsMTgxOSwxODMzLDE4MzhdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2Niw1ODAsNjUxLDY5NCw3NjQsMTAyOCwxNjY4LDE3NjAsMTkxOCwyMTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIENvbnN0cmFpbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE1ickFtb3VudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE5vZGVQb29sQXNzaWdubWVudENvbmZpZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVmFsaWRhdG9yQ29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBWYWxpZGF0b3JDdXJTdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PFBvb2xJbmZvPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFwcGxpY2F0aW9uPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFzc2V0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Nyw1OTEsNjYyLDc3NSwxMDM5LDE2NzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTYsMjU4LDU3Miw2NDMsNzU2LDEwMjAsMTYxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MjVdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBNElERWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZKbGRHbFNaV0ZrWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWkcxcGJrOXViSGxBTVRjS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaRGRpWmpnME5EVWdNSGc0TkdNME5ESTFZU0F3ZURJMFpUQXdZemd3SURCNFltSTRPREk1TWpjZ01IaGhOakptTVRFek1pQXdlR015WXprNFlUWmlJREI0TTJRellqaGlOR0VnTUhoaVlqUTJNR0psWlNBd2VEQmpZekk1WkdRNElEQjRaakU1TkdWak56a2dMeThnYldWMGFHOWtJQ0puWlhSTlluSkJiVzkxYm5SelFXNWtVSEp2ZEc5amIyeERiMjV6ZEhKaGFXNTBjeWgxYVc1ME5qUXBLQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2tpTENCdFpYUm9iMlFnSW1kbGRGWmhiR2xrWVhSdmNrTnZibVpwWnloMWFXNTBOalFzZFdsdWREWTBXMTBwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblE0TEdGa1pISmxjM01zZFdsdWREWTBXelJkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblF6TWl4MWFXNTBNeklzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSV1lXeHBaR0YwYjNKVGRHRjBaWE1vZFdsdWREWTBMSFZwYm5RMk5GdGRLU2gxYVc1ME1UWXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlFiMjlzY3loMWFXNTBOalFzZFdsdWREWTBXMTBwS0hWcGJuUTJOQ3dvZFdsdWREWTBMSFZwYm5ReE5peDFhVzUwTmpRcEtTSXNJRzFsZEdodlpDQWlaMlYwVG05a1pWQnZiMnhCYzNOcFoyNXRaVzUwY3loMWFXNTBOalFzZFdsdWREWTBXMTBwS0NoMWFXNTBOalJiTTEwcFd6aGRLU0lzSUcxbGRHaHZaQ0FpWjJWMFZtRnNhV1JoZEc5eWN5aDFhVzUwTmpRc2RXbHVkRFkwVzEwcEtDaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME9DeGhaR1J5WlhOekxIVnBiblEyTkZzMFhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME16SXNkV2x1ZERNeUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkREUyTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTd29kV2x1ZERZMExIVnBiblF4Tml4MWFXNTBOalFwVzEwc0tDaDFhVzUwTmpSYk0xMHBXemhkS1NraUxDQnRaWFJvYjJRZ0ltZGxkRUpzYjJOclZHbHRaWE4wWVcxd2N5aDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUkJiR2R2WkZabGNuTnBiMjRvZFdsdWREWTBXMTBwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSQmMzTmxkSE1vZFdsdWREWTBXMTBwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwT0N4emRISnBibWNzYzNSeWFXNW5LU0lzSUcxbGRHaHZaQ0FpWjJWMFVHOXZiRUpoYkdGdVkyVnpRVzVrVEdGemRGQmhlVzkxZEhNb2RXbHVkRFkwVzEwcEtIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1oyVjBUV0p5UVcxdmRXNTBjMEZ1WkZCeWIzUnZZMjlzUTI5dWMzUnlZV2x1ZEhNZ1oyVjBWbUZzYVdSaGRHOXlRMjl1Wm1sbklHZGxkRlpoYkdsa1lYUnZjbE4wWVhSbGN5Qm5aWFJRYjI5c2N5Qm5aWFJPYjJSbFVHOXZiRUZ6YzJsbmJtMWxiblJ6SUdkbGRGWmhiR2xrWVhSdmNuTWdaMlYwUW14dlkydFVhVzFsYzNSaGJYQnpJR2RsZEVGc1oyOWtWbVZ5YzJsdmJpQm5aWFJCYzNObGRITWdaMlYwVUc5dmJFSmhiR0Z1WTJWelFXNWtUR0Z6ZEZCaGVXOTFkSE1LSUNBZ0lHVnljZ29LYldGcGJsOWhaRzFwYms5dWJIbEFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnUUdKaGNtVnRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aUxDQWlSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU0I5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE5vYkFvZ0lDQWdjSFZ6YUdsdWRDQTBPQ0F2THlBME9Bb2dJQ0FnSmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ2IyNWxJRzltSUZWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1TENCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z1FHSmhjbVZ0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlMQ0FpUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRpWFNCOUtRb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxkR2xTWldGa1pYSXVaMlYwVFdKeVFXMXZkVzUwYzBGdVpGQnliM1J2WTI5c1EyOXVjM1J5WVdsdWRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSTlluSkJiVzkxYm5SelFXNWtVSEp2ZEc5amIyeERiMjV6ZEhKaGFXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBaVlXeHNiM2NpSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQzAyTUFvZ0lDQWdMeThnWTI5dWMzUWdiV0p5UVcxdmRXNTBjeUE5SUhKbGRHa3VZMkZzYkM1blpYUk5ZbkpCYlc5MWJuUnpLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSEpsWjJsemRISjVRWEJ3U1dRc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEaGhPRGN4TkRKa0lDOHZJRzFsZEdodlpDQWlaMlYwVFdKeVFXMXZkVzUwY3lncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdUV0p5UVcxdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakl0TmpRS0lDQWdJQzh2SUdOdmJuTjBJR052Ym5OMGNtRnBiblJ6SUQwZ2NtVjBhUzVqWVd4c0xtZGxkRkJ5YjNSdlkyOXNRMjl1YzNSeVlXbHVkSE1vZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY21WbmFYTjBjbmxCY0hCSlpDd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaREV6Tmpaall6TWdMeThnYldWMGFHOWtJQ0puWlhSUWNtOTBiMk52YkVOdmJuTjBjbUZwYm5SektDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0RnZ0x5OGdPRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFTnZibk4wY21GcGJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdiRzluS0dWdVkyOWtaVUZ5WXpRb2V5QnRZbkpCYlc5MWJuUnpMQ0JqYjI1emRISmhhVzUwY3lCOUtTazdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxMQ0J2YmtOeVpXRjBaVG9nSW1Gc2JHOTNJaUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWlhScFVtVmhaR1Z5TG1kbGRGWmhiR2xrWVhSdmNrTnZibVpwWjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRlpoYkdsa1lYUnZja052Ym1acFp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzl1UTNKbFlYUmxPaUFpWVd4c2IzY2lJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtZGxkRlpoYkdsa1lYUnZja052Ym1acFoxOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCMllXeHBaR0YwYjNKSlpDQnZaaUIyWVd4cFpHRjBiM0pKWkhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdkbGRGWmhiR2xrWVhSdmNrTnZibVpwWjE5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCc2IyY29aVzVqYjJSbFFYSmpOQ2gwYUdsekxtZGxkRkpsYlc5MFpWWmhiR2xrWVhSdmNrTnZibVpwWnloeVpXZHBjM1J5ZVVGd2NFbGtMQ0IyWVd4cFpHRjBiM0pKWkNrcEtUc0tJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdkbGRGSmxiVzkwWlZaaGJHbGtZWFJ2Y2tOdmJtWnBad29nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdkbGRGWmhiR2xrWVhSdmNrTnZibVpwWjE5bWIzSmZhR1ZoWkdWeVFESUtDbWRsZEZaaGJHbGtZWFJ2Y2tOdmJtWnBaMTloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQWlZV3hzYjNjaUlIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0VOVlVGaFpOVWxCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUVwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVYwYVZKbFlXUmxjaTVuWlhSV1lXeHBaR0YwYjNKVGRHRjBaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUldZV3hwWkdGMGIzSlRkR0YwWlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ0poYkd4dmR5SWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDFhVzUwTmpRK0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1oyVjBWbUZzYVdSaGRHOXlVM1JoZEdWelgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCMllXeHBaR0YwYjNKSlpDQnZaaUIyWVd4cFpHRjBiM0pKWkhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdkbGRGWmhiR2xrWVhSdmNsTjBZWFJsYzE5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2JHOW5LR1Z1WTI5a1pVRnlZelFvZEdocGN5NW5aWFJTWlcxdmRHVldZV3hwWkdGMGIzSlRkR0YwWlNoeVpXZHBjM1J5ZVVGd2NFbGtMQ0IyWVd4cFpHRjBiM0pKWkNrcEtUc0tJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdkbGRGSmxiVzkwWlZaaGJHbGtZWFJ2Y2xOMFlYUmxDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnWjJWMFZtRnNhV1JoZEc5eVUzUmhkR1Z6WDJadmNsOW9aV0ZrWlhKQU1nb0taMlYwVm1Gc2FXUmhkRzl5VTNSaGRHVnpYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQWlZV3hzYjNjaUlIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WMGFWSmxZV1JsY2k1blpYUlFiMjlzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkJ2YjJ4ek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ0poYkd4dmR5SWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDFhVzUwTmpRK0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1oyVjBVRzl2YkhOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhaaGJHbGtZWFJ2Y2tsa0lHOW1JSFpoYkdsa1lYUnZja2xrY3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFVHOXZiSE5mWVdaMFpYSmZabTl5UURrS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTUFvZ0lDQWdMeThnWTI5dWMzUWdjRzl2YkVsdVptOUJjbklnUFNCMGFHbHpMbWRsZEZKbGJXOTBaVkJ2YjJ4SmJtWnZLSEpsWjJsemRISjVRWEJ3U1dRc0lIWmhiR2xrWVhSdmNrbGtLVHNLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRkpsYlc5MFpWQnZiMnhKYm1adkNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSEJ2YjJ4SmJtWnZJRzltSUdOc2IyNWxLSEJ2YjJ4SmJtWnZRWEp5S1NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHSjFjbmtnTndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTmdvS1oyVjBVRzl2YkhOZlptOXlYMmhsWVdSbGNrQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF4Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhCdmIyeEpibVp2SUc5bUlHTnNiMjVsS0hCdmIyeEpibVp2UVhKeUtTa2dld29nSUNBZ1pHbG5JRFVLSUNBZ0lHUnBaeUEzQ2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJRYjI5c2MxOWhablJsY2w5bWIzSkFOd29nSUNBZ1pHbG5JRGNLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElERTRJQzh2SURFNENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElERTRJQzh2SURFNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNZ29nSUNBZ0x5OGdiRzluS0dWdVkyOWtaVUZ5WXpRb2V5QjJZV3hwWkdGMGIzSkpaQ3dnY0c5dmJFbHVabThnZlNrcE93b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpSUdkbGRGQnZiMnh6WDJadmNsOW9aV0ZrWlhKQU5Bb0taMlYwVUc5dmJITmZZV1owWlhKZlptOXlRRGM2Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1oyVjBVRzl2YkhOZlptOXlYMmhsWVdSbGNrQXlDZ3BuWlhSUWIyOXNjMTloWm5SbGNsOW1iM0pBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xKbGRHbFNaV0ZrWlhJdVoyVjBUbTlrWlZCdmIyeEJjM05wWjI1dFpXNTBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFNXZaR1ZRYjI5c1FYTnphV2R1YldWdWRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taMlYwVG05a1pWQnZiMnhCYzNOcFoyNXRaVzUwYzE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamtLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc2FXUmhkRzl5U1dRZ2IyWWdkbUZzYVdSaGRHOXlTV1J6S1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJuWlhST2IyUmxVRzl2YkVGemMybG5ibTFsYm5SelgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3dDaUFnSUNBdkx5QnNiMmNvWlc1amIyUmxRWEpqTkNoMGFHbHpMbWRsZEZKbGJXOTBaVTV2WkdWUWIyOXNRWE56YVdkdWJXVnVkSE1vY21WbmFYTjBjbmxCY0hCSlpDd2dkbUZzYVdSaGRHOXlTV1FwS1NrN0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJuWlhSU1pXMXZkR1ZPYjJSbFVHOXZiRUZ6YzJsbmJtMWxiblJ6Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1oyVjBUbTlrWlZCdmIyeEJjM05wWjI1dFpXNTBjMTltYjNKZmFHVmhaR1Z5UURJS0NtZGxkRTV2WkdWUWIyOXNRWE56YVdkdWJXVnVkSE5mWVdaMFpYSmZabTl5UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ0poYkd4dmR5SWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WMGFWSmxZV1JsY2k1blpYUldZV3hwWkdGMGIzSnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFZtRnNhV1JoZEc5eWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxMQ0J2YmtOeVpXRjBaVG9nSW1Gc2JHOTNJaUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncG5aWFJXWVd4cFpHRjBiM0p6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0IyWVd4cFpHRjBiM0pKWkNCdlppQjJZV3hwWkdGMGIzSkpaSE1wSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEZaaGJHbGtZWFJ2Y25OZllXWjBaWEpmWm05eVFEVUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UUUtJQ0FnSUM4dklHTnZibk4wSUdOdmJtWnBaeUE5SUhSb2FYTXVaMlYwVW1WdGIzUmxWbUZzYVdSaGRHOXlRMjl1Wm1sbktISmxaMmx6ZEhKNVFYQndTV1FzSUhaaGJHbGtZWFJ2Y2tsa0tUc0tJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRkpsYlc5MFpWWmhiR2xrWVhSdmNrTnZibVpwWndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCamIyNXpkQ0J6ZEdGMFpTQTlJSFJvYVhNdVoyVjBVbVZ0YjNSbFZtRnNhV1JoZEc5eVUzUmhkR1VvY21WbmFYTjBjbmxCY0hCSlpDd2dkbUZzYVdSaGRHOXlTV1FwT3dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZKbGJXOTBaVlpoYkdsa1lYUnZjbE4wWVhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UWUtJQ0FnSUM4dklHTnZibk4wSUhCdmIyeEpibVp2SUQwZ2RHaHBjeTVuWlhSU1pXMXZkR1ZRYjI5c1NXNW1ieWh5WldkcGMzUnllVUZ3Y0Vsa0xDQjJZV3hwWkdGMGIzSkpaQ2s3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdaMlYwVW1WdGIzUmxVRzl2YkVsdVptOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOd29nSUNBZ0x5OGdZMjl1YzNRZ2JtOWtaVUZ6YzJsbmJtMWxiblFnUFNCMGFHbHpMbWRsZEZKbGJXOTBaVTV2WkdWUWIyOXNRWE56YVdkdWJXVnVkSE1vY21WbmFYTjBjbmxCY0hCSlpDd2dkbUZzYVdSaGRHOXlTV1FwT3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdaMlYwVW1WdGIzUmxUbTlrWlZCdmIyeEJjM05wWjI1dFpXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGs1TFRJd05Bb2dJQ0FnTHk4Z1kyOXVjM1FnWVd4c1VHOXZiRWx1Wm04NklGWmhiR2xrWVhSdmNpQTlJSHNLSUNBZ0lDOHZJQ0FnWTI5dVptbG5PaUJqYkc5dVpTaGpiMjVtYVdjcExBb2dJQ0FnTHk4Z0lDQnpkR0YwWlRvZ1kyeHZibVVvYzNSaGRHVXBMQW9nSUNBZ0x5OGdJQ0J3YjI5c1NXNW1iem9nWTJ4dmJtVW9jRzl2YkVsdVptOHBMQW9nSUNBZ0x5OGdJQ0J1YjJSbFFYTnphV2R1YldWdWREb2dZMnh2Ym1Vb2JtOWtaVUZ6YzJsbmJtMWxiblFwTEFvZ0lDQWdMeThnZlRzS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhZMlVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOUW9nSUNBZ0x5OGdiRzluS0dWdVkyOWtaVUZ5WXpRb1lXeHNVRzl2YkVsdVptOHBLVHNLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCblpYUldZV3hwWkdGMGIzSnpYMlp2Y2w5b1pXRmtaWEpBTWdvS1oyVjBWbUZzYVdSaGRHOXljMTloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWloRFZWQllXVFZKUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJSRlJSUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlEwRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxkR2xTWldGa1pYSXVaMlYwUW14dlkydFVhVzFsYzNSaGJYQnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFFteHZZMnRVYVcxbGMzUmhiWEJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQWlZV3hzYjNjaUlIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdadmNpQW9iR1YwSUhKdmRXNWtPaUIxYVc1ME5qUWdQU0JVZUc0dWJHRnpkRlpoYkdsa0lDMGdiblZ0SUMwZ01Uc2djbTkxYm1RZ1BDQlVlRzR1Wm1seWMzUldZV3hwWkNBdElERTdJSEp2ZFc1a0t5c3BJSHNLSUNBZ0lIUjRiaUJNWVhOMFZtRnNhV1FLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2dwblpYUkNiRzlqYTFScGJXVnpkR0Z0Y0hOZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVGdLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJSEp2ZFc1a09pQjFhVzUwTmpRZ1BTQlVlRzR1YkdGemRGWmhiR2xrSUMwZ2JuVnRJQzBnTVRzZ2NtOTFibVFnUENCVWVHNHVabWx5YzNSV1lXeHBaQ0F0SURFN0lISnZkVzVrS3lzcElIc0tJQ0FnSUhSNGJpQkdhWEp6ZEZaaGJHbGtDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaR2xuSURFS0lDQWdJRDRLSUNBZ0lHSjZJR2RsZEVKc2IyTnJWR2x0WlhOMFlXMXdjMTloWm5SbGNsOTNhR2xzWlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ua0tJQ0FnSUM4dklHeHZaeWh2Y0M1Q2JHOWpheTVpYkd0VWFXMWxjM1JoYlhBb2NtOTFibVFwS1RzS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW14dlkyc2dRbXhyVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnWm05eUlDaHNaWFFnY205MWJtUTZJSFZwYm5RMk5DQTlJRlI0Ymk1c1lYTjBWbUZzYVdRZ0xTQnVkVzBnTFNBeE95QnliM1Z1WkNBOElGUjRiaTVtYVhKemRGWmhiR2xrSUMwZ01Uc2djbTkxYm1Rckt5a2dld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCblpYUkNiRzlqYTFScGJXVnpkR0Z0Y0hOZmQyaHBiR1ZmZEc5d1FESUtDbWRsZEVKc2IyTnJWR2x0WlhOMFlXMXdjMTloWm5SbGNsOTNhR2xzWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzl1UTNKbFlYUmxPaUFpWVd4c2IzY2lJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pYUnBVbVZoWkdWeUxtZGxkRUZzWjI5a1ZtVnljMmx2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRUZzWjI5a1ZtVnljMmx2YmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDSmhiR3h2ZHlJZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taMlYwUVd4bmIyUldaWEp6YVc5dVgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCd2IyOXNRWEJ3U1dRZ2IyWWdjRzl2YkVGd2NFbGtjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2daMlYwUVd4bmIyUldaWEp6YVc5dVgyRm1kR1Z5WDJadmNrQTRDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU53b2dJQ0FnTHk4Z1kyOXVjM1FnVzJGc1oyOWtWbVZ5TENCbGVHbHpkSE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vY0c5dmJFRndjRWxrTENCQ2VYUmxjMkJoYkdkdlpGWmxjbUFwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poYkdkdlpGWmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlPQW9nSUNBZ0x5OGdhV1lnS0dWNGFYTjBjeWtnZXdvZ0lDQWdZbm9nWjJWMFFXeG5iMlJXWlhKemFXOXVYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWprS0lDQWdJQzh2SUd4dlp5aGxibU52WkdWQmNtTTBLR0ZzWjI5a1ZtVnlLU2s3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29LWjJWMFFXeG5iMlJXWlhKemFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJuWlhSQmJHZHZaRlpsY25OcGIyNWZabTl5WDJobFlXUmxja0F5Q2dwblpYUkJiR2R2WkZabGNuTnBiMjVmWld4elpWOWliMlI1UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16RUtJQ0FnSUM4dklHeHZaeWhsYm1OdlpHVkJjbU0wS0NJaUtTazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHSWdaMlYwUVd4bmIyUldaWEp6YVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvS1oyVjBRV3huYjJSV1pYSnphVzl1WDJGbWRHVnlYMlp2Y2tBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzl1UTNKbFlYUmxPaUFpWVd4c2IzY2lJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWlhScFVtVmhaR1Z5TG1kbGRFRnpjMlYwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRUZ6YzJWMGN6b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ0poYkd4dmR5SWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGMzTmxkRDRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSQmMzTmxkSE5mWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTVDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR0Z6YzJWMElHOW1JR0Z6YzJWMFNXUnpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJCYzNObGRITmZZV1owWlhKZlptOXlRRGdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EQUtJQ0FnSUM4dklHTnZibk4wSUZ0amNtVmhkRzl5TENCbGVHbHpkSE5kSUQwZ2IzQXVRWE56WlhSUVlYSmhiWE11WVhOelpYUkRjbVZoZEc5eUtHRnpjMlYwTG1sa0tUc0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkRjbVZoZEc5eUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBNUW9nSUNBZ0x5OGdhV1lnS0NGbGVHbHpkSE1wSUhzS0lDQWdJR0p1ZWlCblpYUkJjM05sZEhOZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBNZ29nSUNBZ0x5OGdiRzluS0dWdVkyOWtaVUZ5WXpRb2RHaHBjeTVuWlhSRmJYQjBlVUZ6YzJWMFNXNW1ieWhoYzNObGRDNXBaQ2twS1RzS0lDQWdJR05oYkd4emRXSWdaMlYwUlcxd2RIbEJjM05sZEVsdVptOEtJQ0FnSUd4dlp3b0taMlYwUVhOelpYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJuWlhSQmMzTmxkSE5mWm05eVgyaGxZV1JsY2tBeUNncG5aWFJCYzNObGRITmZaV3h6WlY5aWIyUjVRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRjS0lDQWdJQzh2SUhSdmRHRnNPaUJoYzNObGRDNTBiM1JoYkN3S0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEZSdmRHRnNDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGdLSUNBZ0lDOHZJR1JsWTJsdFlXeHpPaUJ1WlhjZ1ZXbHVkRGdvWVhOelpYUXVaR1ZqYVcxaGJITXBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJFWldOcGJXRnNjd29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEY2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalE1Q2lBZ0lDQXZMeUIxYm1sMFRtRnRaVG9nWVhOelpYUXVkVzVwZEU1aGJXVXVkRzlUZEhKcGJtY29LU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTUFvZ0lDQWdMeThnYm1GdFpUb2dZWE56WlhRdWJtRnRaUzUwYjFOMGNtbHVaeWdwTEFvZ0lDQWdaR2xuSURNS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhST1lXMWxDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORFF0TWpVeENpQWdJQ0F2THlCamIyNXpkQ0JoYzNObGRFbHVabTg2SUVGemMyVjBTVzVtYnlBOUlIc0tJQ0FnSUM4dklDQWdZWE56WlhSSlpEb2dZWE56WlhRdWFXUXNDaUFnSUNBdkx5QWdJR055WldGMGIzSTZJR055WldGMGIzSXNDaUFnSUNBdkx5QWdJSFJ2ZEdGc09pQmhjM05sZEM1MGIzUmhiQ3dLSUNBZ0lDOHZJQ0FnWkdWamFXMWhiSE02SUc1bGR5QlZhVzUwT0NoaGMzTmxkQzVrWldOcGJXRnNjeWtzQ2lBZ0lDQXZMeUFnSUhWdWFYUk9ZVzFsT2lCaGMzTmxkQzUxYm1sMFRtRnRaUzUwYjFOMGNtbHVaeWdwTEFvZ0lDQWdMeThnSUNCdVlXMWxPaUJoYzNObGRDNXVZVzFsTG5SdlUzUnlhVzVuS0Nrc0NpQWdJQ0F2THlCOU93b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVXpJQzh2SURVekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVeUNpQWdJQ0F2THlCc2IyY29aVzVqYjJSbFFYSmpOQ2hoYzNObGRFbHVabThwS1RzS0lDQWdJR3h2WndvZ0lDQWdZaUJuWlhSQmMzTmxkSE5mWVdaMFpYSmZhV1pmWld4elpVQTJDZ3BuWlhSQmMzTmxkSE5mWVdaMFpYSmZabTl5UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbWRsZEVWdGNIUjVRWE56WlhSSmJtWnZLREFwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBSVzF3ZEhsQmMzTmxkRWx1Wm04S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dJbUZzYkc5M0lpQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFNaWFJwVW1WaFpHVnlMbWRsZEZCdmIyeENZV3hoYm1ObGMwRnVaRXhoYzNSUVlYbHZkWFJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVRzl2YkVKaGJHRnVZMlZ6UVc1a1RHRnpkRkJoZVc5MWRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjSEJzYVdOaGRHbHZiajRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSUWIyOXNRbUZzWVc1alpYTkJibVJNWVhOMFVHRjViM1YwYzE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOekVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnY0c5dmJFRndjQ0J2WmlCd2IyOXNRWEJ3U1dSektTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCblpYUlFiMjlzUW1Gc1lXNWpaWE5CYm1STVlYTjBVR0Y1YjNWMGMxOWhablJsY2w5bWIzSkFOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNZ29nSUNBZ0x5OGdZMjl1YzNRZ1ltRnNZVzVqWlNBOUlHOXdMbUpoYkdGdVkyVW9jRzl2YkVGd2NDNWhaR1J5WlhOektUc0tJQ0FnSUdSMWNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamN6Q2lBZ0lDQXZMeUJqYjI1emRDQmJiR0Z6ZEZCaGVXOTFkRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvY0c5dmJFRndjQ3dnUW5sMFpYTmdiR0Z6ZEZCaGVXOTFkR0FwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pzWVhOMFVHRjViM1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qYzBDaUFnSUNBdkx5QnNiMmNvWlc1amIyUmxRWEpqTkNoYlltRnNZVzVqWlN3Z2JHRnpkRkJoZVc5MWRGMGdZWE1nUW1Gc1lXNWpaVUZ1WkV4aGMzUlFZWGx2ZFhRcEtUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdkbGRGQnZiMnhDWVd4aGJtTmxjMEZ1WkV4aGMzUlFZWGx2ZFhSelgyWnZjbDlvWldGa1pYSkFNZ29LWjJWMFVHOXZiRUpoYkdGdVkyVnpRVzVrVEdGemRGQmhlVzkxZEhOZllXWjBaWEpmWm05eVFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNKaGJHeHZkeUlnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pYUnBVbVZoWkdWeUxtZGxkRkpsYlc5MFpWWmhiR2xrWVhSdmNrTnZibVpwWnloeVpXZHBjM1J5ZVVGd2NFbGtPaUIxYVc1ME5qUXNJSFpoYkdsa1lYUnZja2xrT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUlNaVzF2ZEdWV1lXeHBaR0YwYjNKRGIyNW1hV2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnY0hKcGRtRjBaU0JuWlhSU1pXMXZkR1ZXWVd4cFpHRjBiM0pEYjI1bWFXY29jbVZuYVhOMGNubEJjSEJKWkRvZ2RXbHVkRFkwTENCMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMEtUb2dWbUZzYVdSaGRHOXlRMjl1Wm1sbklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RNdE9EWUtJQ0FnSUM4dklISmxkSFZ5YmlCamIyMXdhV3hsUVhKak5DaFNaWFJwS1M1allXeHNMbWRsZEZaaGJHbGtZWFJ2Y2tOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ5WldkcGMzUnllVUZ3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRtRnNhV1JoZEc5eVNXUmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWVhKbmN6b2dXM1poYkdsa1lYUnZja2xrWFN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RNdE9EWUtJQ0FnSUM4dklISmxkSFZ5YmlCamIyMXdhV3hsUVhKak5DaFNaWFJwS1M1allXeHNMbWRsZEZaaGJHbGtZWFJ2Y2tOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ5WldkcGMzUnllVUZ3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRtRnNhV1JoZEc5eVNXUmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM05XRm1aall4WkNBdkx5QnRaWFJvYjJRZ0ltZGxkRlpoYkdsa1lYUnZja052Ym1acFp5aDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RNExHRmtaSEpsYzNNc2RXbHVkRFkwV3pSZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5Rek1peDFhVzUwTXpJc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJME1pQXZMeUF5TkRJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRlpoYkdsa1lYUnZja052Ym1acFp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxkR2xTWldGa1pYSXVaMlYwVW1WdGIzUmxWbUZzYVdSaGRHOXlVM1JoZEdVb2NtVm5hWE4wY25sQmNIQkpaRG9nZFdsdWREWTBMQ0IyWVd4cFpHRjBiM0pKWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBVbVZ0YjNSbFZtRnNhV1JoZEc5eVUzUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUhCeWFYWmhkR1VnWjJWMFVtVnRiM1JsVm1Gc2FXUmhkRzl5VTNSaGRHVW9jbVZuYVhOMGNubEJjSEJKWkRvZ2RXbHVkRFkwTENCMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMEtUb2dWbUZzYVdSaGRHOXlRM1Z5VTNSaGRHVWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRXRNVEkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMjl0Y0dsc1pVRnlZelFvVW1WMGFTa3VZMkZzYkM1blpYUldZV3hwWkdGMGIzSlRkR0YwWlNoN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCeVpXZHBjM1J5ZVVGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJkbUZzYVdSaGRHOXlTV1JkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVTdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklHRnlaM002SUZ0MllXeHBaR0YwYjNKSlpGMHNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNUzB4TWpRS0lDQWdJQzh2SUhKbGRIVnliaUJqYjIxd2FXeGxRWEpqTkNoU1pYUnBLUzVqWVd4c0xtZGxkRlpoYkdsa1lYUnZjbE4wWVhSbEtIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklISmxaMmx6ZEhKNVFYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnQyWVd4cFpHRjBiM0pKWkYwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREZtTW1Zd01UQTVJQzh2SUcxbGRHaHZaQ0FpWjJWMFZtRnNhV1JoZEc5eVUzUmhkR1VvZFdsdWREWTBLU2gxYVc1ME1UWXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJMklDOHZJREkyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQldZV3hwWkdGMGIzSkRkWEpUZEdGMFpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxkR2xTWldGa1pYSXVaMlYwVW1WdGIzUmxVRzl2YkVsdVptOG9jbVZuYVhOMGNubEJjSEJKWkRvZ2RXbHVkRFkwTENCMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwVW1WdGIzUmxVRzl2YkVsdVptODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGtLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdaMlYwVW1WdGIzUmxVRzl2YkVsdVptOG9jbVZuYVhOMGNubEJjSEJKWkRvZ2RXbHVkRFkwTENCMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMEtUb2dVRzl2YkVsdVptOWJYU0I3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNQzB4TlRNS0lDQWdJQzh2SUhKbGRIVnliaUJqYjIxd2FXeGxRWEpqTkNoU1pYUnBLUzVqWVd4c0xtZGxkRkJ2YjJ4ektIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklISmxaMmx6ZEhKNVFYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnQyWVd4cFpHRjBiM0pKWkYwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM0psWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdZWEpuY3pvZ1czWmhiR2xrWVhSdmNrbGtYU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV3TFRFMU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdOdmJYQnBiR1ZCY21NMEtGSmxkR2twTG1OaGJHd3VaMlYwVUc5dmJITW9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djbVZuYVhOMGNubEJjSEJKWkN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzNaaGJHbGtZWFJ2Y2tsa1hTd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RFd1pUazBZV01nTHk4Z2JXVjBhRzlrSUNKblpYUlFiMjlzY3loMWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME1UWXNkV2x1ZERZMEtWdGRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UZ2dMeThnTVRnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4VUc5dmJFbHVabTgrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5eVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WMGFWSmxZV1JsY2k1blpYUlNaVzF2ZEdWT2IyUmxVRzl2YkVGemMybG5ibTFsYm5SektISmxaMmx6ZEhKNVFYQndTV1E2SUhWcGJuUTJOQ3dnZG1Gc2FXUmhkRzl5U1dRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRkpsYlc5MFpVNXZaR1ZRYjI5c1FYTnphV2R1YldWdWRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdaMlYwVW1WdGIzUmxUbTlrWlZCdmIyeEJjM05wWjI1dFpXNTBjeWh5WldkcGMzUnllVUZ3Y0Vsa09pQjFhVzUwTmpRc0lIWmhiR2xrWVhSdmNrbGtPaUIxYVc1ME5qUXBPaUJPYjJSbFVHOXZiRUZ6YzJsbmJtMWxiblJEYjI1bWFXY2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56WXRNVGM1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMjl0Y0dsc1pVRnlZelFvVW1WMGFTa3VZMkZzYkM1blpYUk9iMlJsVUc5dmJFRnpjMmxuYm0xbGJuUnpLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSEpsWjJsemRISjVRWEJ3U1dRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0MllXeHBaR0YwYjNKSlpGMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlRzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT0FvZ0lDQWdMeThnWVhKbmN6b2dXM1poYkdsa1lYUnZja2xrWFN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMkxURTNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnZiWEJwYkdWQmNtTTBLRkpsZEdrcExtTmhiR3d1WjJWMFRtOWtaVkJ2YjJ4QmMzTnBaMjV0Wlc1MGN5aDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnlaV2RwYzNSeWVVRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiZG1Gc2FXUmhkRzl5U1dSZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1U3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczWW1KaU5tTTRaQ0F2THlCdFpYUm9iMlFnSW1kbGRFNXZaR1ZRYjI5c1FYTnphV2R1YldWdWRITW9kV2x1ZERZMEtTZ29kV2x1ZERZMFd6TmRLVnM0WFNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01Ua3lJQzh2SURFNU1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVG05a1pWQnZiMnhCYzNOcFoyNXRaVzUwUTI5dVptbG5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVYwYVZKbFlXUmxjaTVuWlhSRmJYQjBlVUZ6YzJWMFNXNW1ieWhoYzNObGRFbGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSRmJYQjBlVUZ6YzJWMFNXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxT0FvZ0lDQWdMeThnY0hKcGRtRjBaU0JuWlhSRmJYQjBlVUZ6YzJWMFNXNW1ieWhoYzNObGRFbGtPaUIxYVc1ME5qUXBPaUJCYzNObGRFbHVabThnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOakVLSUNBZ0lDOHZJR055WldGMGIzSTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVTVMVEkyTmdvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUkpaRG9nWVhOelpYUkpaQ3dLSUNBZ0lDOHZJQ0FnWTNKbFlYUnZjam9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCMGIzUmhiRG9nTUN3S0lDQWdJQzh2SUNBZ1pHVmphVzFoYkhNNklHNWxkeUJWYVc1ME9DZ3dLU3dLSUNBZ0lDOHZJQ0FnZFc1cGRFNWhiV1U2SUNJaUxBb2dJQ0FnTHk4Z0lDQnVZVzFsT2lBaUlpd0tJQ0FnSUM4dklIMDdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmY21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNall5Q2lBZ0lDQXZMeUIwYjNSaGJEb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjl5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVGt0TWpZMkNpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCaGMzTmxkRWxrT2lCaGMzTmxkRWxrTEFvZ0lDQWdMeThnSUNCamNtVmhkRzl5T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzT2lBd0xBb2dJQ0FnTHk4Z0lDQmtaV05wYldGc2N6b2dibVYzSUZWcGJuUTRLREFwTEFvZ0lDQWdMeThnSUNCMWJtbDBUbUZ0WlRvZ0lpSXNDaUFnSUNBdkx5QWdJRzVoYldVNklDSWlMQW9nSUNBZ0x5OGdmVHNLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01ETTFNREF6TnpBd01EQXdNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQWdCQWlZQ0JCVWZmSFVlRlI5OGRRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQU1SdEJBRkl4R1JSRWdnb0UxNytFUlFTRXhFSmFCQ1RnRElBRXU0Z3BKd1NtTHhFeUJNTEppbXNFUFR1TFNnUzdSZ3Z1QkF6Q25kZ0U4WlRzZVRZYUFJNEtBQklBZUFHeUFmUUNhZ055QmNNRitnWldCdlVBSkRFWmtJRXdHakVZRUVReEFESUpFa00yR2dGSkZTTVNSQmV4Z0FTS2h4UXRzaG9pc2hsSnNoaUJCcklRSXJJQnM3UStTVmNFQUV4WEFBUW9Fa1JKRllFZ0VrU3hnQVRSTm16RHNob2lzaGxNc2hpQkJySVFJcklCczdRK1NWY0VBRXhYQUFRb0VrUkpGWUZZRWtSUVNiQW9URkN3SkVNMkdnRkpGU01TUkJjMkdnSkhBaUpaU1U0Q0l3c2xDRXdWRWtRaVNVc0NERUVBRzBzQ1Z3SUFTd0ZKVGdJakMxdExCVXlJQnFpd0pBaEZBVUwvM29EMkFSVWZmSFVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTEFrUXpZYUFVa1ZJeEpFRnpZYUFrY0NJbGxKVGdJakN5VUlUQlVTUkNKSlN3SU1RUUFiU3dKWEFnQkxBVWxPQWlNTFcwc0ZUSWdGbzdBa0NFVUJRdi9lS2JBa1F5S0FBRWNDTmhvQlNSVWpFa1FYTmhvQ1J3SWlXVWxPQWlNTEpRaE1GUkpFSWtsTEFneEJBRXBMQWxjQ0FFc0JJd3RiU1VVR1N3Uk1pQVdRU1VVSklsbEZCeUpGQmtzRlN3Y01RUUFkU3dkWEFnQkxCa2xPQW9FU0M0RVNXRXNHRmt4UXNDUUlSUVpDLzl0SkpBaEZBVUwvcnltd0pFTTJHZ0ZKRlNNU1JCYzJHZ0pIQWlKWlNVNENJd3NsQ0V3VkVrUWlTVXNDREVFQUcwc0NWd0lBU3dGSlRnSWpDMXRMQlV5SUJWcXdKQWhGQVVMLzNvREVBUlVmZkhVQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ3dKRU0yR2dGSkZTTVNSQmMyR2dKSEFpSlpTVTRDSXdzbENFd1ZFa1FpU1VzQ0RFRUFRa3NDVndJQVN3RkpUZ0lqQzF0TEJVbE9Ba3NCaUFPcVN3SkxBb2dEMkVzRFN3T0lCQVZQQkU4RWlBUTVUd05QQTFDQUFnSE9VRXhRVEZDd0pBaEZBVUwvdDREbUF4VWZmSFVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBYzRBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFMQWtRellhQVVrVkl4SkVGekVFVEFra0NURUNKQWxMQVExQkFBMUhBdEVCRnJBa0NFVUJRdi9wZ0F3VkgzeDFBQUFBQUFBQUFBQ3dKRU1pTmhvQlJ3SWlXVWxPQWlNTEpRaE1GUkpFSWtsTEFneEJBRFpMQWxjQ0FFc0JJd3RiZ0FoaGJHZHZaRlpsY21WTVJRVkJBQk5MQTBrVkZsY0dBa3hRc0Vra0NFVUJRdi9MZ0FJQUFMQkMvL0NBQmhVZmZIVUFBTEFrUXlJMkdnRkhBaUpaU1U0Q0l3c2xDRXdWRWtRaVNVc0NERUVBZWtzQ1Z3SUFTd0VqQzF0SmNRdE1SUVpBQUF5SUFhaXdTU1FJUlFGQy85cEpjUUJFU3dGeEFVUVdTWk1qRGtSWEJ3RkxBbkVEUkVzRGNRUkVUd1FXU3doUVR3UVdVRThEVUVzQ0ZSWlhCZ0pQQTFCTWdBSUFOVkJMQVJXQk5RaExBeFVXVndZQ1R3UlFUQlpYQmdKUEFreFFUd0pRVEZDd1F2K2RJb2dCUUNoTVVMQWtRellhQVVjQ0lsbEpUZ0lqQ3lVSVRCVVNSQ0pKU3dJTVFRQXVTd0pYQWdCTEFVbE9BaU1MVzBseUNFUmdUSUFLYkdGemRGQmhlVzkxZEdWSVRCWk1GbEN3SkFoRkFVTC95NEFVRlI5OGRRQUFBQUFBQUFBQUFBQUFBQUFBQUFDd0pFT0tBZ0d4aS84V2dBUjFyL1lkc2hxeUdpS3lHWXYrc2hpQkJySVFJcklCczdRK1NWY0VBRXhYQUFRb0VrUkpGWUh5QVJKRWlZb0NBYkdML3hhQUJCOHZBUW15R3JJYUlySVppLzZ5R0lFR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNnU1JFa1ZnUm9TUkltS0FnR3hpLzhXZ0FTUkRwU3NzaHF5R2lLeUdZditzaGlCQnJJUUlySUJzN1ErU1ZjRUFFeFhBQVFvRWtSSklsbUJFZ3NsQ0VzQkZSSkVpWW9DQWJHTC94YUFCSHU3YkkyeUdySWFJcklaaS82eUdJRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWZ2NBQkVrU0ppZ0VCTWdPTC94Wk1VQ0lXVUlBSkFBQTFBRGNBQUFBQVVJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
