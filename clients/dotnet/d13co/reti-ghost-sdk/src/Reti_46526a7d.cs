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

namespace Arc56.Generated.d13co.reti_ghost_sdk.Reti_46526a7d
{


    public class RetiProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RetiProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class GetPoolsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ushort Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
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

                public static GetPoolsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPoolsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ushort vField1Value) { ret.Field1 = vField1Value; }
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
                    return Equals(obj as GetPoolsReturn);
                }
                public bool Equals(GetPoolsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPoolsReturn left, GetPoolsReturn right)
                {
                    return EqualityComparer<GetPoolsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPoolsReturn left, GetPoolsReturn right)
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
        /// <param name="validatorId"> </param>
        public async Task<Structs.ValidatorConfig> GetValidatorConfig(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 175, 246, 29 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.SimApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidatorConfig_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 175, 246, 29 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.ValidatorCurState> GetValidatorState(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 47, 1, 9 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.SimApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorCurState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidatorState_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 47, 1, 9 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.GetPoolsReturn[]> GetPools(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 14, 148, 172 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.SimApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetPoolsReturn>(x => Structs.GetPoolsReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPools_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 14, 148, 172 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.NodePoolAssignmentConfig> GetNodePoolAssignments(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 187, 108, 141 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.SimApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NodePoolAssignmentConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetNodePoolAssignments_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 187, 108, 141 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.MbrAmounts> GetMbrAmounts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 135, 20, 45 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MbrAmounts.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMbrAmounts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 135, 20, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Constraints> GetProtocolConstraints(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 54, 108, 195 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Constraints.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProtocolConstraints_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 54, 108, 195 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmV0aSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDb25zdHJhaW50cyI6W3sibmFtZSI6ImVwb2NoUGF5b3V0Um91bmRzTWluIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVwb2NoUGF5b3V0Um91bmRzTWF4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1pblBjdFRvVmFsaWRhdG9yV0ZvdXJEZWNpbWFscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhQY3RUb1ZhbGlkYXRvcldGb3VyRGVjaW1hbHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWluRW50cnlTdGFrZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhBbGdvUGVyUG9vbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhBbGdvUGVyVmFsaWRhdG9yIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFtdENvbnNpZGVyZWRTYXR1cmF0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4Tm9kZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4UG9vbHNQZXJOb2RlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heFN0YWtlcnNQZXJQb29sIiwidHlwZSI6InVpbnQ2NCJ9XSwiTWJyQW1vdW50cyI6W3sibmFtZSI6ImFkZFZhbGlkYXRvck1iciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZGRQb29sTWJyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2xJbml0TWJyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkZFN0YWtlck1iciIsInR5cGUiOiJ1aW50NjQifV0sIk5vZGVQb29sQXNzaWdubWVudENvbmZpZyI6W3sibmFtZSI6Im5vZGVzIiwidHlwZSI6Ik5vZGVQb29sQXNzaWdubWVudENvbmZpZ05vZGVzWzhdIn1dLCJWYWxpZGF0b3JDb25maWciOlt7Im5hbWUiOiJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibWFuYWdlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmZkRm9ySW5mbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbnRyeUdhdGluZ1R5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJlbnRyeUdhdGluZ0FkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVudHJ5R2F0aW5nQXNzZXRzIiwidHlwZSI6InVpbnQ2NFs0XSJ9LHsibmFtZSI6ImdhdGluZ0Fzc2V0TWluQmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXdhcmRUb2tlbklkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFBlclBheW91dCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlcG9jaFJvdW5kTGVuZ3RoIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6InBlcmNlbnRUb1ZhbGlkYXRvciIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJ2YWxpZGF0b3JDb21taXNzaW9uQWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibWluRW50cnlTdGFrZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhBbGdvUGVyUG9vbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb29sc1Blck5vZGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJzdW5zZXR0aW5nT24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3Vuc2V0dGluZ1RvIiwidHlwZSI6InVpbnQ2NCJ9XSwiVmFsaWRhdG9yQ3VyU3RhdGUiOlt7Im5hbWUiOiJudW1Qb29scyIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJ0b3RhbFN0YWtlcnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBbGdvU3Rha2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFRva2VuSGVsZEJhY2siLCJ0eXBlIjoidWludDY0In1dLCJHZXRQb29sc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDE2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnTm9kZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0WzNdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldFZhbGlkYXRvckNvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDgsYWRkcmVzcyx1aW50NjRbNF0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDMyLHVpbnQzMixhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3JDb25maWciLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFZhbGlkYXRvclN0YXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MTYsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmFsaWRhdG9yQ3VyU3RhdGUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBvb2xzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDE2LHVpbnQ2NClbXSIsInN0cnVjdCI6IkdldFBvb2xzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXROb2RlUG9vbEFzc2lnbm1lbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDY0WzNdKVs4XSkiLCJzdHJ1Y3QiOiJOb2RlUG9vbEFzc2lnbm1lbnRDb25maWciLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE1ickFtb3VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJNYnJBbW91bnRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm90b2NvbENvbnN0cmFpbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkNvbnN0cmFpbnRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NSw5MywxMDEsMTA5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYsNjcsODYsOTQsMTAyLDExMF0sImVycm9yTWVzc2FnZSI6InN0dWIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1WMGFTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnM05XRm1aall4WkNBd2VERm1NbVl3TVRBNUlEQjRPVEV3WlRrMFlXTWdNSGczWW1KaU5tTTRaQ0F3ZURoaE9EY3hOREprSURCNFpERXpOalpqWXpNZ0x5OGdiV1YwYUc5a0lDSm5aWFJXWVd4cFpHRjBiM0pEYjI1bWFXY29kV2x1ZERZMEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME9DeGhaR1J5WlhOekxIVnBiblEyTkZzMFhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME16SXNkV2x1ZERNeUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBWbUZzYVdSaGRHOXlVM1JoZEdVb2RXbHVkRFkwS1NoMWFXNTBNVFlzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJRYjI5c2N5aDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBNVFlzZFdsdWREWTBLVnRkSWl3Z2JXVjBhRzlrSUNKblpYUk9iMlJsVUc5dmJFRnpjMmxuYm0xbGJuUnpLSFZwYm5RMk5Da29LSFZwYm5RMk5Gc3pYU2xiT0YwcElpd2diV1YwYUc5a0lDSm5aWFJOWW5KQmJXOTFiblJ6S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwVUhKdmRHOWpiMnhEYjI1emRISmhhVzUwY3lncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1oyVjBWbUZzYVdSaGRHOXlRMjl1Wm1sbklHZGxkRlpoYkdsa1lYUnZjbE4wWVhSbElHZGxkRkJ2YjJ4eklHZGxkRTV2WkdWUWIyOXNRWE56YVdkdWJXVnVkSE1nYldGcGJsOW5aWFJOWW5KQmJXOTFiblJ6WDNKdmRYUmxRRGdnYldGcGJsOW5aWFJRY205MGIyTnZiRU52Ym5OMGNtRnBiblJ6WDNKdmRYUmxRRGtLSUNBZ0lHVnljZ29LYldGcGJsOW5aWFJRY205MGIyTnZiRU52Ym5OMGNtRnBiblJ6WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCbGNuSW9Jbk4wZFdJaUtUc0tJQ0FnSUdWeWNpQXZMeUJ6ZEhWaUNncHRZV2x1WDJkbGRFMWlja0Z0YjNWdWRITmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR1Z5Y2lnaWMzUjFZaUlwT3dvZ0lDQWdaWEp5SUM4dklITjBkV0lLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVjBhU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2t2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VW1WMGFTNW5aWFJXWVd4cFpHRjBiM0pEYjI1bWFXZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSV1lXeHBaR0YwYjNKRGIyNW1hV2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGNuSW9Jbk4wZFdJaUtUc0tJQ0FnSUdWeWNpQXZMeUJ6ZEhWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVtVjBhUzVuWlhSV1lXeHBaR0YwYjNKVGRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGWmhiR2xrWVhSdmNsTjBZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1pYSnlLQ0p6ZEhWaUlpazdDaUFnSUNCbGNuSWdMeThnYzNSMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxkR2t1WjJWMFVHOXZiSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlFiMjlzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklHVnljaWdpYzNSMVlpSXBPd29nSUNBZ1pYSnlJQzh2SUhOMGRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFNaWFJwTG1kbGRFNXZaR1ZRYjI5c1FYTnphV2R1YldWdWRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhST2IyUmxVRzl2YkVGemMybG5ibTFsYm5Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdaWEp5S0NKemRIVmlJaWs3Q2lBZ0lDQmxjbklnTHk4Z2MzUjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQ0RFYlFRQTdNUmtVUkRFWVJJSUdCSFd2OWgwRUh5OEJDUVNSRHBTc0JIdTdiSTBFaW9jVUxRVFJObXpETmhvQWpnWUFEZ0FXQUI0QUpnQUNBQUVBQUFBeEdSUXhHQlFRUklFQlF6WWFBUlVpRWtRQU5ob0JGU0lTUkFBMkdnRVZJaEpFQURZYUFSVWlFa1FBIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
