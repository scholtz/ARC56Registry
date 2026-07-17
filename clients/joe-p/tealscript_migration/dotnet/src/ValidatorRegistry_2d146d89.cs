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

namespace Arc56.Generated.joe_p.tealscript_migration.ValidatorRegistry_2d146d89
{


    //
    // ValidatorRegistry is the 'master contract' for the reti pooling protocol.
    //A single immutable instance of this is deployed.  All state for all validators including information about their
    //pools and nodes is stored via this contract in global state and box storage.  Data in the pools themselves is stored
    //within the StakingPool contract instance, also in global state and box storage.
    //See the StakingPool contract comments for details on how this contract creates new instances of them.
    //
    public class ValidatorRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ValidatorRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class PoolInfo : AVMObjectType
            {
                public ulong PoolAppId { get; set; }

                public ulong TotalStakers { get; set; }

                public ulong TotalAlgoStaked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolAppId.From(PoolAppId);
                    ret.AddRange(vPoolAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStakers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

            public class PoolTokenPayoutRatio : AVMObjectType
            {
                public ulong[] PoolPctOfWhole { get; set; }

                public ulong UpdatedForPayout { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolPctOfWhole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[24]");
                    vPoolPctOfWhole.From(PoolPctOfWhole);
                    ret.AddRange(vPoolPctOfWhole.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedForPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedForPayout.From(UpdatedForPayout);
                    ret.AddRange(vUpdatedForPayout.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolTokenPayoutRatio Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolTokenPayoutRatio();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolPctOfWhole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[24]");
                    count = vPoolPctOfWhole.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolPctOfWhole = vPoolPctOfWhole.ToValue();
                    if (valuePoolPctOfWhole is ulong[] vPoolPctOfWholeValue) { ret.PoolPctOfWhole = vPoolPctOfWholeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedForPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedForPayout.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedForPayout = vUpdatedForPayout.ToValue();
                    if (valueUpdatedForPayout is ulong vUpdatedForPayoutValue) { ret.UpdatedForPayout = vUpdatedForPayoutValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolTokenPayoutRatio);
                }
                public bool Equals(PoolTokenPayoutRatio? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolTokenPayoutRatio left, PoolTokenPayoutRatio right)
                {
                    return EqualityComparer<PoolTokenPayoutRatio>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolTokenPayoutRatio left, PoolTokenPayoutRatio right)
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

                public ulong EntryGatingType { get; set; }

                public Algorand.Address EntryGatingAddress { get; set; }

                public ulong[] EntryGatingAssets { get; set; }

                public ulong GatingAssetMinBalance { get; set; }

                public ulong RewardTokenId { get; set; }

                public ulong RewardPerPayout { get; set; }

                public ulong EpochRoundLength { get; set; }

                public ulong PercentToValidator { get; set; }

                public Algorand.Address ValidatorCommissionAddress { get; set; }

                public ulong MinEntryStake { get; set; }

                public ulong MaxAlgoPerPool { get; set; }

                public ulong PoolsPerNode { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochRoundLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpochRoundLength.From(EpochRoundLength);
                    ret.AddRange(vEpochRoundLength.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentToValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryGatingType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntryGatingType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryGatingType = vEntryGatingType.ToValue();
                    if (valueEntryGatingType is ulong vEntryGatingTypeValue) { ret.EntryGatingType = vEntryGatingTypeValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpochRoundLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpochRoundLength.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpochRoundLength = vEpochRoundLength.ToValue();
                    if (valueEpochRoundLength is ulong vEpochRoundLengthValue) { ret.EpochRoundLength = vEpochRoundLengthValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentToValidator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPercentToValidator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePercentToValidator = vPercentToValidator.ToValue();
                    if (valuePercentToValidator is ulong vPercentToValidatorValue) { ret.PercentToValidator = vPercentToValidatorValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolsPerNode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolsPerNode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolsPerNode = vPoolsPerNode.ToValue();
                    if (valuePoolsPerNode is ulong vPoolsPerNodeValue) { ret.PoolsPerNode = vPoolsPerNodeValue; }
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
                public ulong NumPools { get; set; }

                public ulong TotalStakers { get; set; }

                public ulong TotalAlgoStaked { get; set; }

                public ulong RewardTokenHeldBack { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumPools = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNumPools = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNumPools.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNumPools = vNumPools.ToValue();
                    if (valueNumPools is ulong vNumPoolsValue) { ret.NumPools = vNumPoolsValue; }
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

            public class ValidatorInfo : AVMObjectType
            {
                public Structs.ValidatorConfig Config { get; set; } = new Structs.ValidatorConfig();

                public Structs.ValidatorCurState State { get; set; } = new Structs.ValidatorCurState();

                public Structs.PoolInfo[] Pools { get; set; }

                public Structs.PoolTokenPayoutRatio TokenPayoutRatio { get; set; } = new Structs.PoolTokenPayoutRatio();

                public Structs.NodePoolAssignmentConfig NodePoolAssignments { get; set; } = new Structs.NodePoolAssignmentConfig();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Config.ToByteArray());
                    ret.AddRange(State.ToByteArray());
                    var arrPools = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = true, FixedLength = 24 };
                    arrPools.Value = (Pools ?? Array.Empty<Structs.PoolInfo>()).ToList();
                    ret.AddRange(arrPools.Encode());
                    ret.AddRange(TokenPayoutRatio.ToByteArray());
                    ret.AddRange(NodePoolAssignments.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidatorInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidatorInfo();
                    ret.Config = Structs.ValidatorConfig.Parse(queue.ToArray());
                    { var consumedConfig = ret.Config.ToByteArray().Length; for (int i = 0; i < consumedConfig && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.State = Structs.ValidatorCurState.Parse(queue.ToArray());
                    { var consumedState = ret.State.ToByteArray().Length; for (int i = 0; i < consumedState && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var arrPools = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = true, FixedLength = 24 };
                    { var consumedPools = (int)arrPools.Decode(queue.ToArray()); for (int i = 0; i < consumedPools && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Pools = arrPools.Value.ToArray();
                    ret.TokenPayoutRatio = Structs.PoolTokenPayoutRatio.Parse(queue.ToArray());
                    { var consumedTokenPayoutRatio = ret.TokenPayoutRatio.ToByteArray().Length; for (int i = 0; i < consumedTokenPayoutRatio && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.NodePoolAssignments = Structs.NodePoolAssignmentConfig.Parse(queue.ToArray());
                    { var consumedNodePoolAssignments = ret.NodePoolAssignments.ToByteArray().Length; for (int i = 0; i < consumedNodePoolAssignments && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidatorInfo);
                }
                public bool Equals(ValidatorInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidatorInfo left, ValidatorInfo right)
                {
                    return EqualityComparer<ValidatorInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidatorInfo left, ValidatorInfo right)
                {
                    return !(left == right);
                }

            }

            public class ValidatorPoolKey : AVMObjectType
            {
                public ulong Id { get; set; }

                public ulong PoolId { get; set; }

                public ulong PoolAppId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolId.From(PoolId);
                    ret.AddRange(vPoolId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolAppId.From(PoolAppId);
                    ret.AddRange(vPoolAppId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ValidatorPoolKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ValidatorPoolKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolId = vPoolId.ToValue();
                    if (valuePoolId is ulong vPoolIdValue) { ret.PoolId = vPoolIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolAppId = vPoolAppId.ToValue();
                    if (valuePoolAppId is ulong vPoolAppIdValue) { ret.PoolAppId = vPoolAppIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ValidatorPoolKey);
                }
                public bool Equals(ValidatorPoolKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ValidatorPoolKey left, ValidatorPoolKey right)
                {
                    return EqualityComparer<ValidatorPoolKey>.Default.Equals(left, right);
                }
                public static bool operator !=(ValidatorPoolKey left, ValidatorPoolKey right)
                {
                    return !(left == right);
                }

            }

            public class GetValidatorOwnerAndManagerReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static GetValidatorOwnerAndManagerReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetValidatorOwnerAndManagerReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetValidatorOwnerAndManagerReturn);
                }
                public bool Equals(GetValidatorOwnerAndManagerReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetValidatorOwnerAndManagerReturn left, GetValidatorOwnerAndManagerReturn right)
                {
                    return EqualityComparer<GetValidatorOwnerAndManagerReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetValidatorOwnerAndManagerReturn left, GetValidatorOwnerAndManagerReturn right)
                {
                    return !(left == right);
                }

            }

            public class FindPoolForStakerReturn : AVMObjectType
            {
                public Structs.PoolInfo Field0 { get; set; } = new Structs.PoolInfo();

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static FindPoolForStakerReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FindPoolForStakerReturn();
                    uint count = 0;
                    ret.Field0 = Structs.PoolInfo.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FindPoolForStakerReturn);
                }
                public bool Equals(FindPoolForStakerReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FindPoolForStakerReturn left, FindPoolForStakerReturn right)
                {
                    return EqualityComparer<FindPoolForStakerReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(FindPoolForStakerReturn left, FindPoolForStakerReturn right)
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
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="approvalProgramSize"> </param>
        public async Task InitStakingContract(ulong approvalProgramSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 94, 130, 198 };
            var approvalProgramSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalProgramSizeAbi.From(approvalProgramSize);

            var result = await base.CallApp(new List<object> { abiHandle, approvalProgramSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitStakingContract_Transactions(ulong approvalProgramSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 94, 130, 198 };
            var approvalProgramSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalProgramSizeAbi.From(approvalProgramSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, approvalProgramSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="offset"> </param>
        /// <param name="data"> </param>
        public async Task LoadStakingContractData(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 71, 45, 131 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LoadStakingContractData_Transactions(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 71, 45, 131 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task FinalizeStakingContract(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 122, 207, 217 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FinalizeStakingContract_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 122, 207, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Gas(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Gas_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
        ///
        ///</summary>
        public async Task<ulong> GetNumValidators(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 4, 92, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNumValidators_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 4, 92, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 59, 171, 92, 34 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 59, 171, 92, 34 };
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
            byte[] abiHandle = { 154, 124, 34, 72 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 154, 124, 34, 72 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.GetValidatorOwnerAndManagerReturn> GetValidatorOwnerAndManager(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 162, 44, 75 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetValidatorOwnerAndManagerReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetValidatorOwnerAndManager_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 162, 44, 75 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.PoolInfo[]> GetPools(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 42, 125, 228 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
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
            byte[] abiHandle = { 119, 42, 125, 228 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="poolId"> </param>
        public async Task<ulong> GetPoolAppId(ulong validatorId, ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 39, 103, 209 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPoolAppId_Transactions(ulong validatorId, ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 39, 103, 209 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolKey"> ValidatorPoolKey</param>
        public async Task<Structs.PoolInfo> GetPoolInfo(Structs.ValidatorPoolKey poolKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 84, 133, 185 };

            var result = await base.CallApp(new List<object> { abiHandle, poolKey }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoolInfo_Transactions(Structs.ValidatorPoolKey poolKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 84, 133, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle, poolKey }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<ulong> GetCurMaxStakePerPool(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 198, 49, 120 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCurMaxStakePerPool_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 198, 49, 120 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="staker"> </param>
        public async Task<bool> DoesStakerNeedToPayMbr(Algorand.Address staker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 73, 140, 244 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);

            var result = await base.CallApp(new List<object> { abiHandle, stakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DoesStakerNeedToPayMbr_Transactions(Algorand.Address staker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 73, 140, 244 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);

            return await base.MakeTransactionList(new List<object> { abiHandle, stakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="staker"> </param>
        public async Task<Structs.PoolInfo[]> GetStakedPoolsForAccount(Algorand.Address staker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 70, 221, 122 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);

            var result = await base.CallApp(new List<object> { abiHandle, stakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PoolInfo>(x => Structs.PoolInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetStakedPoolsForAccount_Transactions(Algorand.Address staker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 70, 221, 122 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);

            return await base.MakeTransactionList(new List<object> { abiHandle, stakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.PoolTokenPayoutRatio> GetTokenPayoutRatio(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 5, 5, 1 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolTokenPayoutRatio.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTokenPayoutRatio_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 5, 5, 1 };
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

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
        public async Task<ulong> GetNfdRegistryId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 57, 65, 74 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNfdRegistryId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 57, 65, 74 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="config"> ValidatorConfig</param>
        public async Task<ulong> AddValidator(byte[] nfdName, Structs.ValidatorConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 215, 55, 255 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nfdNameAbi.From(nfdName);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddValidator_Transactions(byte[] nfdName, Structs.ValidatorConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 215, 55, 255 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nfdNameAbi.From(nfdName);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="manager"> </param>
        public async Task ChangeValidatorManager(ulong validatorId, Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 40, 137, 114 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeValidatorManager_Transactions(ulong validatorId, Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 40, 137, 114 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="sunsettingOn"> </param>
        /// <param name="sunsettingTo"> </param>
        public async Task ChangeValidatorSunsetInfo(ulong validatorId, ulong sunsettingOn, ulong sunsettingTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 95, 170, 218 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var sunsettingOnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sunsettingOnAbi.From(sunsettingOn);
            var sunsettingToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sunsettingToAbi.From(sunsettingTo);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, sunsettingOnAbi, sunsettingToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeValidatorSunsetInfo_Transactions(ulong validatorId, ulong sunsettingOn, ulong sunsettingTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 95, 170, 218 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var sunsettingOnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sunsettingOnAbi.From(sunsettingOn);
            var sunsettingToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sunsettingToAbi.From(sunsettingTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, sunsettingOnAbi, sunsettingToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="nfdAppID"> </param>
        /// <param name="nfdName"> </param>
        public async Task ChangeValidatorNfd(ulong validatorId, ulong nfdAppID, byte[] nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 67, 215, 191 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var nfdAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIDAbi.From(nfdAppID);
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nfdNameAbi.From(nfdName);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, nfdAppIDAbi, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeValidatorNfd_Transactions(ulong validatorId, ulong nfdAppID, byte[] nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 67, 215, 191 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var nfdAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIDAbi.From(nfdAppID);
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nfdNameAbi.From(nfdName);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, nfdAppIDAbi, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="commissionAddress"> </param>
        public async Task ChangeValidatorCommissionAddress(ulong validatorId, Algorand.Address commissionAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 158, 245, 77 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var commissionAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commissionAddressAbi.From(commissionAddress);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, commissionAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeValidatorCommissionAddress_Transactions(ulong validatorId, Algorand.Address commissionAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 158, 245, 77 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var commissionAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commissionAddressAbi.From(commissionAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, commissionAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="EntryGatingType"> </param>
        /// <param name="EntryGatingAddress"> </param>
        /// <param name="EntryGatingAssets"> </param>
        /// <param name="GatingAssetMinBalance"> </param>
        /// <param name="RewardPerPayout"> </param>
        public async Task ChangeValidatorRewardInfo(ulong validatorId, ulong EntryGatingType, Algorand.Address EntryGatingAddress, ulong[] EntryGatingAssets, ulong GatingAssetMinBalance, ulong RewardPerPayout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 127, 199, 227 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var EntryGatingTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); EntryGatingTypeAbi.From(EntryGatingType);
            var EntryGatingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); EntryGatingAddressAbi.From(EntryGatingAddress);
            var EntryGatingAssetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(4, "uint64"); EntryGatingAssetsAbi.From(EntryGatingAssets);
            var GatingAssetMinBalanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); GatingAssetMinBalanceAbi.From(GatingAssetMinBalance);
            var RewardPerPayoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); RewardPerPayoutAbi.From(RewardPerPayout);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, EntryGatingTypeAbi, EntryGatingAddressAbi, EntryGatingAssetsAbi, GatingAssetMinBalanceAbi, RewardPerPayoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeValidatorRewardInfo_Transactions(ulong validatorId, ulong EntryGatingType, Algorand.Address EntryGatingAddress, ulong[] EntryGatingAssets, ulong GatingAssetMinBalance, ulong RewardPerPayout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 127, 199, 227 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var EntryGatingTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); EntryGatingTypeAbi.From(EntryGatingType);
            var EntryGatingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); EntryGatingAddressAbi.From(EntryGatingAddress);
            var EntryGatingAssetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(4, "uint64"); EntryGatingAssetsAbi.From(EntryGatingAssets);
            var GatingAssetMinBalanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); GatingAssetMinBalanceAbi.From(GatingAssetMinBalance);
            var RewardPerPayoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); RewardPerPayoutAbi.From(RewardPerPayout);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, EntryGatingTypeAbi, EntryGatingAddressAbi, EntryGatingAssetsAbi, GatingAssetMinBalanceAbi, RewardPerPayoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="nodeNum"> </param>
        public async Task<Structs.ValidatorPoolKey> AddPool(ulong validatorId, ulong nodeNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 136, 155, 132 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var nodeNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nodeNumAbi.From(nodeNum);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, nodeNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorPoolKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> AddPool_Transactions(ulong validatorId, ulong nodeNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 136, 155, 132 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var nodeNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nodeNumAbi.From(nodeNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, nodeNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="valueToVerify"> </param>
        public async Task<Structs.ValidatorPoolKey> AddStake(ulong validatorId, ulong valueToVerify, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 107, 59, 64 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var valueToVerifyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueToVerifyAbi.From(valueToVerify);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, valueToVerifyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ValidatorPoolKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> AddStake_Transactions(ulong validatorId, ulong valueToVerify, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 107, 59, 64 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var valueToVerifyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueToVerifyAbi.From(valueToVerify);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, valueToVerifyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        public async Task<Structs.PoolTokenPayoutRatio> SetTokenPayoutRatio(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 248, 216, 110 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolTokenPayoutRatio.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SetTokenPayoutRatio_Transactions(ulong validatorId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 248, 216, 110 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolKey"> ValidatorPoolKey</param>
        /// <param name="algoToAdd"> </param>
        /// <param name="rewardTokenAmountReserved"> </param>
        /// <param name="validatorCommission"> </param>
        /// <param name="saturatedBurnToFeeSink"> </param>
        public async Task StakeUpdatedViaRewards(Structs.ValidatorPoolKey poolKey, ulong algoToAdd, ulong rewardTokenAmountReserved, ulong validatorCommission, ulong saturatedBurnToFeeSink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 143, 206, 252 };
            var algoToAddAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); algoToAddAbi.From(algoToAdd);
            var rewardTokenAmountReservedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardTokenAmountReservedAbi.From(rewardTokenAmountReserved);
            var validatorCommissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorCommissionAbi.From(validatorCommission);
            var saturatedBurnToFeeSinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saturatedBurnToFeeSinkAbi.From(saturatedBurnToFeeSink);

            var result = await base.CallApp(new List<object> { abiHandle, poolKey, algoToAddAbi, rewardTokenAmountReservedAbi, validatorCommissionAbi, saturatedBurnToFeeSinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StakeUpdatedViaRewards_Transactions(Structs.ValidatorPoolKey poolKey, ulong algoToAdd, ulong rewardTokenAmountReserved, ulong validatorCommission, ulong saturatedBurnToFeeSink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 143, 206, 252 };
            var algoToAddAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); algoToAddAbi.From(algoToAdd);
            var rewardTokenAmountReservedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardTokenAmountReservedAbi.From(rewardTokenAmountReserved);
            var validatorCommissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorCommissionAbi.From(validatorCommission);
            var saturatedBurnToFeeSinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saturatedBurnToFeeSinkAbi.From(saturatedBurnToFeeSink);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolKey, algoToAddAbi, rewardTokenAmountReservedAbi, validatorCommissionAbi, saturatedBurnToFeeSinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolKey"> ValidatorPoolKey</param>
        /// <param name="staker"> </param>
        /// <param name="amountRemoved"> </param>
        /// <param name="rewardRemoved"> </param>
        /// <param name="stakerRemoved"> </param>
        public async Task StakeRemoved(Structs.ValidatorPoolKey poolKey, Algorand.Address staker, ulong amountRemoved, ulong rewardRemoved, bool stakerRemoved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 220, 81, 181 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);
            var amountRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountRemovedAbi.From(amountRemoved);
            var rewardRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardRemovedAbi.From(rewardRemoved);
            var stakerRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); stakerRemovedAbi.From(stakerRemoved);

            var result = await base.CallApp(new List<object> { abiHandle, poolKey, stakerAbi, amountRemovedAbi, rewardRemovedAbi, stakerRemovedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StakeRemoved_Transactions(Structs.ValidatorPoolKey poolKey, Algorand.Address staker, ulong amountRemoved, ulong rewardRemoved, bool stakerRemoved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 220, 81, 181 };
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);
            var amountRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountRemovedAbi.From(amountRemoved);
            var rewardRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardRemovedAbi.From(rewardRemoved);
            var stakerRemovedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); stakerRemovedAbi.From(stakerRemoved);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolKey, stakerAbi, amountRemovedAbi, rewardRemovedAbi, stakerRemovedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="staker"> </param>
        /// <param name="amountToStake"> </param>
        public async Task<Structs.FindPoolForStakerReturn> FindPoolForStaker(ulong validatorId, Algorand.Address staker, ulong amountToStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 115, 245, 4 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);
            var amountToStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountToStakeAbi.From(amountToStake);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, stakerAbi, amountToStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FindPoolForStakerReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FindPoolForStaker_Transactions(ulong validatorId, Algorand.Address staker, ulong amountToStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 115, 245, 4 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var stakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); stakerAbi.From(staker);
            var amountToStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountToStakeAbi.From(amountToStake);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, stakerAbi, amountToStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="poolAppId"> </param>
        /// <param name="nodeNum"> </param>
        public async Task MovePoolToNode(ulong validatorId, ulong poolAppId, ulong nodeNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 71, 244, 254 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var poolAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAppIdAbi.From(poolAppId);
            var nodeNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nodeNumAbi.From(nodeNum);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, poolAppIdAbi, nodeNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MovePoolToNode_Transactions(ulong validatorId, ulong poolAppId, ulong nodeNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 71, 244, 254 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var poolAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAppIdAbi.From(poolAppId);
            var nodeNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nodeNumAbi.From(nodeNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, poolAppIdAbi, nodeNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="validatorId"> </param>
        /// <param name="receiver"> </param>
        public async Task<ulong> EmptyTokenRewards(ulong validatorId, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 102, 131, 88 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, validatorIdAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EmptyTokenRewards_Transactions(ulong validatorId, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 102, 131, 88 };
            var validatorIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validatorIdAbi.From(validatorId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, validatorIdAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmFsaWRhdG9yUmVnaXN0cnkiLCJkZXNjIjoiVmFsaWRhdG9yUmVnaXN0cnkgaXMgdGhlICdtYXN0ZXIgY29udHJhY3QnIGZvciB0aGUgcmV0aSBwb29saW5nIHByb3RvY29sLlxuQSBzaW5nbGUgaW1tdXRhYmxlIGluc3RhbmNlIG9mIHRoaXMgaXMgZGVwbG95ZWQuICBBbGwgc3RhdGUgZm9yIGFsbCB2YWxpZGF0b3JzIGluY2x1ZGluZyBpbmZvcm1hdGlvbiBhYm91dCB0aGVpclxucG9vbHMgYW5kIG5vZGVzIGlzIHN0b3JlZCB2aWEgdGhpcyBjb250cmFjdCBpbiBnbG9iYWwgc3RhdGUgYW5kIGJveCBzdG9yYWdlLiAgRGF0YSBpbiB0aGUgcG9vbHMgdGhlbXNlbHZlcyBpcyBzdG9yZWRcbndpdGhpbiB0aGUgU3Rha2luZ1Bvb2wgY29udHJhY3QgaW5zdGFuY2UsIGFsc28gaW4gZ2xvYmFsIHN0YXRlIGFuZCBib3ggc3RvcmFnZS5cblNlZSB0aGUgU3Rha2luZ1Bvb2wgY29udHJhY3QgY29tbWVudHMgZm9yIGRldGFpbHMgb24gaG93IHRoaXMgY29udHJhY3QgY3JlYXRlcyBuZXcgaW5zdGFuY2VzIG9mIHRoZW0uIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNvbnN0cmFpbnRzIjpbeyJuYW1lIjoiZXBvY2hQYXlvdXRSb3VuZHNNaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXBvY2hQYXlvdXRSb3VuZHNNYXgiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWluUGN0VG9WYWxpZGF0b3JXRm91ckRlY2ltYWxzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heFBjdFRvVmFsaWRhdG9yV0ZvdXJEZWNpbWFscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5FbnRyeVN0YWtlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heEFsZ29QZXJQb29sIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heEFsZ29QZXJWYWxpZGF0b3IiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW10Q29uc2lkZXJlZFNhdHVyYXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhOb2RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhQb29sc1Blck5vZGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4U3Rha2Vyc1BlclBvb2wiLCJ0eXBlIjoidWludDY0In1dLCJNYnJBbW91bnRzIjpbeyJuYW1lIjoiYWRkVmFsaWRhdG9yTWJyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkZFBvb2xNYnIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicG9vbEluaXRNYnIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRkU3Rha2VyTWJyIiwidHlwZSI6InVpbnQ2NCJ9XSwiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnIjpbeyJuYW1lIjoibm9kZXMiLCJ0eXBlIjoiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnTm9kZXNbOF0ifV0sIlBvb2xJbmZvIjpbeyJuYW1lIjoicG9vbEFwcElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsU3Rha2VycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbEFsZ29TdGFrZWQiLCJ0eXBlIjoidWludDY0In1dLCJQb29sVG9rZW5QYXlvdXRSYXRpbyI6W3sibmFtZSI6InBvb2xQY3RPZldob2xlIiwidHlwZSI6InVpbnQ2NFsyNF0ifSx7Im5hbWUiOiJ1cGRhdGVkRm9yUGF5b3V0IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmFsaWRhdG9yQ29uZmlnIjpbeyJuYW1lIjoiaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1hbmFnZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im5mZEZvckluZm8iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW50cnlHYXRpbmdUeXBlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVudHJ5R2F0aW5nQWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZW50cnlHYXRpbmdBc3NldHMiLCJ0eXBlIjoidWludDY0WzRdIn0seyJuYW1lIjoiZ2F0aW5nQXNzZXRNaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFRva2VuSWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmV3YXJkUGVyUGF5b3V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVwb2NoUm91bmRMZW5ndGgiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVyY2VudFRvVmFsaWRhdG9yIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZhbGlkYXRvckNvbW1pc3Npb25BZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJtaW5FbnRyeVN0YWtlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heEFsZ29QZXJQb29sIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2xzUGVyTm9kZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdW5zZXR0aW5nT24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3Vuc2V0dGluZ1RvIiwidHlwZSI6InVpbnQ2NCJ9XSwiVmFsaWRhdG9yQ3VyU3RhdGUiOlt7Im5hbWUiOiJudW1Qb29scyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbFN0YWtlcnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBbGdvU3Rha2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZFRva2VuSGVsZEJhY2siLCJ0eXBlIjoidWludDY0In1dLCJWYWxpZGF0b3JJbmZvIjpbeyJuYW1lIjoiY29uZmlnIiwidHlwZSI6IlZhbGlkYXRvckNvbmZpZyJ9LHsibmFtZSI6InN0YXRlIiwidHlwZSI6IlZhbGlkYXRvckN1clN0YXRlIn0seyJuYW1lIjoicG9vbHMiLCJ0eXBlIjoiUG9vbEluZm9bMjRdIn0seyJuYW1lIjoidG9rZW5QYXlvdXRSYXRpbyIsInR5cGUiOiJQb29sVG9rZW5QYXlvdXRSYXRpbyJ9LHsibmFtZSI6Im5vZGVQb29sQXNzaWdubWVudHMiLCJ0eXBlIjoiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnIn1dLCJWYWxpZGF0b3JQb29sS2V5IjpbeyJuYW1lIjoiaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicG9vbElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2xBcHBJZCIsInR5cGUiOiJ1aW50NjQifV0sIkdldFZhbGlkYXRvck93bmVyQW5kTWFuYWdlclJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifV0sIkZpbmRQb29sRm9yU3Rha2VyUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6IlBvb2xJbmZvIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYm9vbCJ9XSwiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnTm9kZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0WzNdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InVwZGF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0U3Rha2luZ0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFsUHJvZ3JhbVNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9hZFN0YWtpbmdDb250cmFjdERhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpbmFsaXplU3Rha2luZ0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRNYnJBbW91bnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTWJyQW1vdW50cyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFByb3RvY29sQ29uc3RyYWludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQ29uc3RyYWludHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXROdW1WYWxpZGF0b3JzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VmFsaWRhdG9yQ29uZmlnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsYWRkcmVzcyx1aW50NjRbNF0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmFsaWRhdG9yQ29uZmlnIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VmFsaWRhdG9yU3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3JDdXJTdGF0ZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFZhbGlkYXRvck93bmVyQW5kTWFuYWdlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzKSIsInN0cnVjdCI6IkdldFZhbGlkYXRvck93bmVyQW5kTWFuYWdlclJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBvb2xzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IlBvb2xJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbEFwcElkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQb29sSW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmFsaWRhdG9yUG9vbEtleSIsIm5hbWUiOiJwb29sS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQb29sSW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEN1ck1heFN0YWtlUGVyUG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRvZXNTdGFrZXJOZWVkVG9QYXlNQlIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTdGFrZWRQb29sc0ZvckFjY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJQb29sSW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRva2VuUGF5b3V0UmF0aW8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NFsyNF0sdWludDY0KSIsInN0cnVjdCI6IlBvb2xUb2tlblBheW91dFJhdGlvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Tm9kZVBvb2xBc3NpZ25tZW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKHVpbnQ2NFszXSlbOF0pIiwic3RydWN0IjoiTm9kZVBvb2xBc3NpZ25tZW50Q29uZmlnIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TkZEUmVnaXN0cnlJRCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZFZhbGlkYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LGFkZHJlc3MsdWludDY0WzRdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZhbGlkYXRvckNvbmZpZyIsIm5hbWUiOiJjb25maWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGFuZ2VWYWxpZGF0b3JNYW5hZ2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGFuZ2VWYWxpZGF0b3JTdW5zZXRJbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdW5zZXR0aW5nT24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1bnNldHRpbmdUbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGFuZ2VWYWxpZGF0b3JORkQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5mZEFwcElEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoYW5nZVZhbGlkYXRvckNvbW1pc3Npb25BZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWlzc2lvbkFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hhbmdlVmFsaWRhdG9yUmV3YXJkSW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiRW50cnlHYXRpbmdUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiRW50cnlHYXRpbmdBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJFbnRyeUdhdGluZ0Fzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiR2F0aW5nQXNzZXRNaW5CYWxhbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJSZXdhcmRQZXJQYXlvdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkUG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9kZU51bSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmFsaWRhdG9yUG9vbEtleSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZFN0YWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbGlkYXRvcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZVRvVmVyaWZ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3JQb29sS2V5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VG9rZW5QYXlvdXRSYXRpbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0WzI0XSx1aW50NjQpIiwic3RydWN0IjoiUG9vbFRva2VuUGF5b3V0UmF0aW8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFrZVVwZGF0ZWRWaWFSZXdhcmRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWYWxpZGF0b3JQb29sS2V5IiwibmFtZSI6InBvb2xLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFsZ29Ub0FkZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV3YXJkVG9rZW5BbW91bnRSZXNlcnZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9yQ29tbWlzc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2F0dXJhdGVkQnVyblRvRmVlU2luayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFrZVJlbW92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZhbGlkYXRvclBvb2xLZXkiLCJuYW1lIjoicG9vbEtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50UmVtb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV3YXJkUmVtb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlclJlbW92ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmluZFBvb2xGb3JTdGFrZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFrZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudFRvU3Rha2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsdWludDY0LHVpbnQ2NCksYm9vbCxib29sKSIsInN0cnVjdCI6IkZpbmRQb29sRm9yU3Rha2VyUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibW92ZVBvb2xUb05vZGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9ySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9kZU51bSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbXB0eVRva2VuUmV3YXJkcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWxpZGF0b3JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjExLDEyMjYsMTI0MiwxMjY5LDEzNTAsMTM2NywxNDAwLDE0MzAsMTUzNCwxNjE0LDE4MDUsMTgzNSwxODc5LDE5MTEsMTk0MV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsMzg1LDM5NCw0MzUsNDQ0LDQ1Myw0NzMsNDg1LDQ5Nyw1MzEsNTUwLDU3Myw1OTcsNjE2LDYzOSw2NTEsNjcxLDY5MSw3MTAsNzM2LDc1Nyw3NzYsODAxLDgyMSw4NDEsODYxLDg4MSw4OTgsMTAwMiwxMDUwLDEwNTksMTA3MSwxMDkzLDExMDldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBVcGRhdGVBcHBsaWNhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzYsMzg4LDM5Nyw0MzgsNDQ3LDQ1Niw0NzYsNDg4LDUwMCw1MzQsNTUzLDU3Niw2MDAsNjE5LDY0Miw2NTQsNjc0LDY5NCw3MTMsNzM5LDc2MCw3NzksODA0LDgyNCw4NDQsODY0LDg4NCw5MDEsMTAwNSwxMDUzLDEwNjIsMTA3NCwxMDk2LDExMjddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4OCwxMTk5LDE3NDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkxLDEzODAsMTQxNiwxNTU0XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzA1LDE1NzJdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJMk5DQXlOQ0F5T1RZZ05UYzJJREU1TWlBeE1EQXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0oySWlBd2VERTFNV1kzWXpjMUlDSnBibWwwSWlBaWJuVnRWaUlnTUhnd01EQXdJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0luQnZiMnhVWlcxd2JHRjBaVUZ3Y0hKdmRtRnNRbmwwWlhNaUlDSnpjSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnME5tWTNOalV6TXlBd2VHSTRORFEzWWpNMklEQjRNV0kxWlRneVl6WWdNSGczT1RRM01tUTRNeUF3ZURWbU4yRmpabVE1SURCNE16RTNNbU5oT1dRZ01IZzRZVGczTVRReVpDQXdlR1F4TXpZMlkyTXpJREI0TTJJd05EVmpOV01nTUhnelltRmlOV015TWlBd2VEbGhOMk15TWpRNElEQjRNbVpoTWpKak5HSWdNSGczTnpKaE4yUmxOQ0F3ZURVM01qYzJOMlF4SURCNE16UTFORGcxWWprZ01IaG1ZbU0yTXpFM09DQXdlREkwTkRrNFkyWTBJREI0WmpnME5tUmtOMkVnTUhnNE16QTFNRFV3TVNBd2VEZGlZbUkyWXpoa0lEQjRaamd6T1RReE5HRWdNSGd4TVdRM016ZG1aaUF3ZURObE1qZzRPVGN5SURCNFpHUTFabUZoWkdFZ01IaGtaRFF6WkRkaVppQXdlR1k1T1dWbU5UUmtJREI0WW1ZM1ptTTNaVE1nTUhnellqZzRPV0k0TkNBd2VHSXhObUl6WWpRd0lEQjROR1JtT0dRNE5tVWdNSGcwTVRobVkyVm1ZeUF3ZUdFeVpHTTFNV0kxSURCNE1qZzNNMlkxTURRZ01IZ3dOVFEzWmpSbVpTQXdlR05pTmpZNE16VTRJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnBibWwwVTNSaGEybHVaME52Ym5SeVlXTjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKc2IyRmtVM1JoYTJsdVowTnZiblJ5WVdOMFJHRjBZU2gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1acGJtRnNhWHBsVTNSaGEybHVaME52Ym5SeVlXTjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5ZWE1vS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEUxaWNrRnRiM1Z1ZEhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSUWNtOTBiMk52YkVOdmJuTjBjbUZwYm5SektDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRTUxYlZaaGJHbGtZWFJ2Y25Nb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBWbUZzYVdSaGRHOXlRMjl1Wm1sbktIVnBiblEyTkNrb2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwV3pSZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBWbUZzYVdSaGRHOXlVM1JoZEdVb2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJXWVd4cFpHRjBiM0pQZDI1bGNrRnVaRTFoYm1GblpYSW9kV2x1ZERZMEtTaGhaR1J5WlhOekxHRmtaSEpsYzNNcElpd2diV1YwYUc5a0lDSm5aWFJRYjI5c2N5aDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLVnRkSWl3Z2JXVjBhRzlrSUNKblpYUlFiMjlzUVhCd1NXUW9kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGQnZiMnhKYm1adktDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2twS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwUTNWeVRXRjRVM1JoYTJWUVpYSlFiMjlzS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVJ2WlhOVGRHRnJaWEpPWldWa1ZHOVFZWGxOUWxJb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSVGRHRnJaV1JRYjI5c2MwWnZja0ZqWTI5MWJuUW9ZV1JrY21WemN5a29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwVzEwaUxDQnRaWFJvYjJRZ0ltZGxkRlJ2YTJWdVVHRjViM1YwVW1GMGFXOG9kV2x1ZERZMEtTaDFhVzUwTmpSYk1qUmRMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEU1dlpHVlFiMjlzUVhOemFXZHViV1Z1ZEhNb2RXbHVkRFkwS1Nnb2RXbHVkRFkwV3pOZEtWczRYU2tpTENCdFpYUm9iMlFnSW1kbGRFNUdSRkpsWjJsemRISjVTVVFvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVdSa1ZtRnNhV1JoZEc5eUtHSjVkR1ZiWFN3b2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwV3pSZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Ob1lXNW5aVlpoYkdsa1lYUnZjazFoYm1GblpYSW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJoaGJtZGxWbUZzYVdSaGRHOXlVM1Z1YzJWMFNXNW1ieWgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYUdGdVoyVldZV3hwWkdGMGIzSk9Sa1FvZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJoaGJtZGxWbUZzYVdSaGRHOXlRMjl0YldsemMybHZia0ZrWkhKbGMzTW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJoaGJtZGxWbUZzYVdSaGRHOXlVbVYzWVhKa1NXNW1ieWgxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwV3pSZExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrVUc5dmJDaDFhVzUwTmpRc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbUZrWkZOMFlXdGxLSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpYzJWMFZHOXJaVzVRWVhsdmRYUlNZWFJwYnloMWFXNTBOalFwS0hWcGJuUTJORnN5TkYwc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWMzUmhhMlZWY0dSaGRHVmtWbWxoVW1WM1lYSmtjeWdvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRHRnJaVkpsYlc5MlpXUW9LSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1N4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0ptYVc1a1VHOXZiRVp2Y2xOMFlXdGxjaWgxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRcEtDaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tzWW05dmJDeGliMjlzS1NJc0lHMWxkR2h2WkNBaWJXOTJaVkJ2YjJ4VWIwNXZaR1VvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlcxd2RIbFViMnRsYmxKbGQyRnlaSE1vZFdsdWREWTBMR0ZrWkhKbGMzTXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MWNHUmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6SUcxaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU5DQnRZV2x1WDJsdWFYUlRkR0ZyYVc1blEyOXVkSEpoWTNSZmNtOTFkR1ZBTlNCdFlXbHVYMnh2WVdSVGRHRnJhVzVuUTI5dWRISmhZM1JFWVhSaFgzSnZkWFJsUURZZ2JXRnBibDltYVc1aGJHbDZaVk4wWVd0cGJtZERiMjUwY21GamRGOXliM1YwWlVBM0lHMWhhVzVmWjJGelgzSnZkWFJsUURnZ2JXRnBibDluWlhSTlluSkJiVzkxYm5SelgzSnZkWFJsUURrZ2JXRnBibDluWlhSUWNtOTBiMk52YkVOdmJuTjBjbUZwYm5SelgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFRuVnRWbUZzYVdSaGRHOXljMTl5YjNWMFpVQXhNU0J0WVdsdVgyZGxkRlpoYkdsa1lYUnZja052Ym1acFoxOXliM1YwWlVBeE1pQnRZV2x1WDJkbGRGWmhiR2xrWVhSdmNsTjBZWFJsWDNKdmRYUmxRREV6SUcxaGFXNWZaMlYwVm1Gc2FXUmhkRzl5VDNkdVpYSkJibVJOWVc1aFoyVnlYM0p2ZFhSbFFERTBJRzFoYVc1ZloyVjBVRzl2YkhOZmNtOTFkR1ZBTVRVZ2JXRnBibDluWlhSUWIyOXNRWEJ3U1dSZmNtOTFkR1ZBTVRZZ2JXRnBibDluWlhSUWIyOXNTVzVtYjE5eWIzVjBaVUF4TnlCdFlXbHVYMmRsZEVOMWNrMWhlRk4wWVd0bFVHVnlVRzl2YkY5eWIzVjBaVUF4T0NCdFlXbHVYMlJ2WlhOVGRHRnJaWEpPWldWa1ZHOVFZWGxOUWxKZmNtOTFkR1ZBTVRrZ2JXRnBibDluWlhSVGRHRnJaV1JRYjI5c2MwWnZja0ZqWTI5MWJuUmZjbTkxZEdWQU1qQWdiV0ZwYmw5blpYUlViMnRsYmxCaGVXOTFkRkpoZEdsdlgzSnZkWFJsUURJeElHMWhhVzVmWjJWMFRtOWtaVkJ2YjJ4QmMzTnBaMjV0Wlc1MGMxOXliM1YwWlVBeU1pQnRZV2x1WDJkbGRFNUdSRkpsWjJsemRISjVTVVJmY205MWRHVkFNak1nYldGcGJsOWhaR1JXWVd4cFpHRjBiM0pmY205MWRHVkFNalFnYldGcGJsOWphR0Z1WjJWV1lXeHBaR0YwYjNKTllXNWhaMlZ5WDNKdmRYUmxRREkxSUcxaGFXNWZZMmhoYm1kbFZtRnNhV1JoZEc5eVUzVnVjMlYwU1c1bWIxOXliM1YwWlVBeU5pQnRZV2x1WDJOb1lXNW5aVlpoYkdsa1lYUnZjazVHUkY5eWIzVjBaVUF5TnlCdFlXbHVYMk5vWVc1blpWWmhiR2xrWVhSdmNrTnZiVzFwYzNOcGIyNUJaR1J5WlhOelgzSnZkWFJsUURJNElHMWhhVzVmWTJoaGJtZGxWbUZzYVdSaGRHOXlVbVYzWVhKa1NXNW1iMTl5YjNWMFpVQXlPU0J0WVdsdVgyRmtaRkJ2YjJ4ZmNtOTFkR1ZBTXpBZ2JXRnBibDloWkdSVGRHRnJaVjl5YjNWMFpVQXpNU0J0WVdsdVgzTmxkRlJ2YTJWdVVHRjViM1YwVW1GMGFXOWZjbTkxZEdWQU16SWdiV0ZwYmw5emRHRnJaVlZ3WkdGMFpXUldhV0ZTWlhkaGNtUnpYM0p2ZFhSbFFETXpJRzFoYVc1ZmMzUmhhMlZTWlcxdmRtVmtYM0p2ZFhSbFFETTBJRzFoYVc1ZlptbHVaRkJ2YjJ4R2IzSlRkR0ZyWlhKZmNtOTFkR1ZBTXpVZ2JXRnBibDl0YjNabFVHOXZiRlJ2VG05a1pWOXliM1YwWlVBek5pQnRZV2x1WDJWdGNIUjVWRzlyWlc1U1pYZGhjbVJ6WDNKdmRYUmxRRE0zQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5ERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QldZV3hwWkdGMGIzSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXMXdkSGxVYjJ0bGJsSmxkMkZ5WkhOZmNtOTFkR1ZBTXpjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3pPRFVLSUNBZ0lDOHZJR1Z0Y0hSNVZHOXJaVzVTWlhkaGNtUnpLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VzSUhKbFkyVnBkbVZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYlc5MlpWQnZiMnhVYjA1dlpHVmZjbTkxZEdWQU16WTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96T0RNS0lDQWdJQzh2SUcxdmRtVlFiMjlzVkc5T2IyUmxLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VzSUhCdmIyeEJjSEJKWkRvZ2RXbHVkRFkwTENCdWIyUmxUblZ0T2lCMWFXNTBOalFwT2lCMmIybGtJSHQ5Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZabWx1WkZCdmIyeEdiM0pUZEdGclpYSmZjbTkxZEdWQU16VTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TmpjdE16Y3hDaUFnSUNBdkx5Qm1hVzVrVUc5dmJFWnZjbE4wWVd0bGNpZ0tJQ0FnSUM4dklDQWdkbUZzYVdSaGRHOXlTV1E2SUZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dLSUNBZ0lDOHZJQ0FnYzNSaGEyVnlPaUJoY21NMExrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEZSdlUzUmhhMlU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ2s2SUZ0V1lXeHBaR0YwYjNKUWIyOXNTMlY1TENCaWIyOXNaV0Z1TENCaWIyOXNaV0Z1WFNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emRHRnJaVkpsYlc5MlpXUmZjbTkxZEdWQU16UTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TlRrdE16WTFDaUFnSUNBdkx5QnpkR0ZyWlZKbGJXOTJaV1FvQ2lBZ0lDQXZMeUFnSUhCdmIyeExaWGs2SUZaaGJHbGtZWFJ2Y2xCdmIyeExaWGtzQ2lBZ0lDQXZMeUFnSUhOMFlXdGxjam9nWVhKak5DNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5SU1pXMXZkbVZrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKbGQyRnlaRkpsYlc5MlpXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjM1JoYTJWeVVtVnRiM1psWkRvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNrNklIWnZhV1FnZTMwS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6ZEdGclpWVndaR0YwWldSV2FXRlNaWGRoY21SelgzSnZkWFJsUURNek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNelV4TFRNMU53b2dJQ0FnTHk4Z2MzUmhhMlZWY0dSaGRHVmtWbWxoVW1WM1lYSmtjeWdLSUNBZ0lDOHZJQ0FnY0c5dmJFdGxlVG9nVm1Gc2FXUmhkRzl5VUc5dmJFdGxlU3dLSUNBZ0lDOHZJQ0FnWVd4bmIxUnZRV1JrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKbGQyRnlaRlJ2YTJWdVFXMXZkVzUwVW1WelpYSjJaV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZG1Gc2FXUmhkRzl5UTI5dGJXbHpjMmx2YmpvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCellYUjFjbUYwWldSQ2RYSnVWRzlHWldWVGFXNXJPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIdDlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBWRzlyWlc1UVlYbHZkWFJTWVhScGIxOXliM1YwWlVBek1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPak0wTkFvZ0lDQWdMeThnYzJWMFZHOXJaVzVRWVhsdmRYUlNZWFJwYnloMllXeHBaR0YwYjNKSlpEb2dWbUZzYVdSaGRHOXlTV1JVZVhCbEtUb2dVRzl2YkZSdmEyVnVVR0Y1YjNWMFVtRjBhVzhnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNME5Bb2dJQ0FnTHk4Z2MyVjBWRzlyWlc1UVlYbHZkWFJTWVhScGJ5aDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxLVG9nVUc5dmJGUnZhMlZ1VUdGNWIzVjBVbUYwYVc4Z2V3b2dJQ0FnWTJGc2JITjFZaUJ6WlhSVWIydGxibEJoZVc5MWRGSmhkR2x2Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZrWkZOMFlXdGxYM0p2ZFhSbFFETXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TXpNMkNpQWdJQ0F2THlCaFpHUlRkR0ZyWlNoMllXeHBaR0YwYjNKSlpEb2dWbUZzYVdSaGRHOXlTV1JVZVhCbExDQjJZV3gxWlZSdlZtVnlhV1o1T2lCMWFXNTBOalFwT2lCV1lXeHBaR0YwYjNKUWIyOXNTMlY1SUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdSa1VHOXZiRjl5YjNWMFpVQXpNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNeU9Bb2dJQ0FnTHk4Z1lXUmtVRzl2YkNoMllXeHBaR0YwYjNKSlpEb2dWbUZzYVdSaGRHOXlTV1JVZVhCbExDQnViMlJsVG5WdE9pQjFhVzUwTmpRcE9pQldZV3hwWkdGMGIzSlFiMjlzUzJWNUlIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyaGhibWRsVm1Gc2FXUmhkRzl5VW1WM1lYSmtTVzVtYjE5eWIzVjBaVUF5T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXhNaTB6TVRrS0lDQWdJQzh2SUdOb1lXNW5aVlpoYkdsa1lYUnZjbEpsZDJGeVpFbHVabThvQ2lBZ0lDQXZMeUFnSUhaaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVc0NpQWdJQ0F2THlBZ0lFVnVkSEo1UjJGMGFXNW5WSGx3WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCRmJuUnllVWRoZEdsdVowRmtaSEpsYzNNNklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnUlc1MGNubEhZWFJwYm1kQmMzTmxkSE02SUVacGVHVmtRWEp5WVhrOGRXbHVkRFkwTENBMFBpd0tJQ0FnSUM4dklDQWdSMkYwYVc1blFYTnpaWFJOYVc1Q1lXeGhibU5sT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUZKbGQyRnlaRkJsY2xCaGVXOTFkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNekV5TFRNeE9Rb2dJQ0FnTHk4Z1kyaGhibWRsVm1Gc2FXUmhkRzl5VW1WM1lYSmtTVzVtYnlnS0lDQWdJQzh2SUNBZ2RtRnNhV1JoZEc5eVNXUTZJRlpoYkdsa1lYUnZja2xrVkhsd1pTd0tJQ0FnSUM4dklDQWdSVzUwY25sSFlYUnBibWRVZVhCbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lFVnVkSEo1UjJGMGFXNW5RV1JrY21WemN6b2dZWEpqTkM1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCRmJuUnllVWRoZEdsdVowRnpjMlYwY3pvZ1JtbDRaV1JCY25KaGVUeDFhVzUwTmpRc0lEUStMQW9nSUNBZ0x5OGdJQ0JIWVhScGJtZEJjM05sZEUxcGJrSmhiR0Z1WTJVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1VtVjNZWEprVUdWeVVHRjViM1YwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kyaGhibWRsVm1Gc2FXUmhkRzl5VW1WM1lYSmtTVzVtYndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYUdGdVoyVldZV3hwWkdGMGIzSkRiMjF0YVhOemFXOXVRV1JrY21WemMxOXliM1YwWlVBeU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPak13TndvZ0lDQWdMeThnWTJoaGJtZGxWbUZzYVdSaGRHOXlRMjl0YldsemMybHZia0ZrWkhKbGMzTW9kbUZzYVdSaGRHOXlTV1E2SUZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dnWTI5dGJXbHpjMmx2YmtGa1pISmxjM002SUdGeVl6UXVRV1JrY21WemN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXdOd29nSUNBZ0x5OGdZMmhoYm1kbFZtRnNhV1JoZEc5eVEyOXRiV2x6YzJsdmJrRmtaSEpsYzNNb2RtRnNhV1JoZEc5eVNXUTZJRlpoYkdsa1lYUnZja2xrVkhsd1pTd2dZMjl0YldsemMybHZia0ZrWkhKbGMzTTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQmphR0Z1WjJWV1lXeHBaR0YwYjNKRGIyMXRhWE56YVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYUdGdVoyVldZV3hwWkdGMGIzSk9Sa1JmY205MWRHVkFNamM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvek1ESUtJQ0FnSUM4dklHTm9ZVzVuWlZaaGJHbGtZWFJ2Y2s1R1JDaDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxMQ0J1Wm1SQmNIQkpSRG9nZFdsdWREWTBMQ0J1Wm1ST1lXMWxPaUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QldZV3hwWkdGMGIzSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPak13TWdvZ0lDQWdMeThnWTJoaGJtZGxWbUZzYVdSaGRHOXlUa1pFS0haaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVc0lHNW1aRUZ3Y0VsRU9pQjFhVzUwTmpRc0lHNW1aRTVoYldVNklHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0JqWVd4c2MzVmlJR05vWVc1blpWWmhiR2xrWVhSdmNrNUdSQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWphR0Z1WjJWV1lXeHBaR0YwYjNKVGRXNXpaWFJKYm1adlgzSnZkWFJsUURJMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNamsyQ2lBZ0lDQXZMeUJqYUdGdVoyVldZV3hwWkdGMGIzSlRkVzV6WlhSSmJtWnZLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VzSUhOMWJuTmxkSFJwYm1kUGJqb2dkV2x1ZERZMExDQnpkVzV6WlhSMGFXNW5WRzg2SUZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QldZV3hwWkdGMGIzSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakk1TmdvZ0lDQWdMeThnWTJoaGJtZGxWbUZzYVdSaGRHOXlVM1Z1YzJWMFNXNW1ieWgyWVd4cFpHRjBiM0pKWkRvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsTENCemRXNXpaWFIwYVc1blQyNDZJSFZwYm5RMk5Dd2djM1Z1YzJWMGRHbHVaMVJ2T2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VwT2lCMmIybGtJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kyaGhibWRsVm1Gc2FXUmhkRzl5VTNWdWMyVjBTVzVtYndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYUdGdVoyVldZV3hwWkdGMGIzSk5ZVzVoWjJWeVgzSnZkWFJsUURJMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNamt4Q2lBZ0lDQXZMeUJqYUdGdVoyVldZV3hwWkdGMGIzSk5ZVzVoWjJWeUtIWmhiR2xrWVhSdmNrbGtPaUJXWVd4cFpHRjBiM0pKWkZSNWNHVXNJRzFoYm1GblpYSTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJNU1Rb2dJQ0FnTHk4Z1kyaGhibWRsVm1Gc2FXUmhkRzl5VFdGdVlXZGxjaWgyWVd4cFpHRjBiM0pKWkRvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsTENCdFlXNWhaMlZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUIyYjJsa0lIc0tJQ0FnSUdOaGJHeHpkV0lnWTJoaGJtZGxWbUZzYVdSaGRHOXlUV0Z1WVdkbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpHUldZV3hwWkdGMGIzSmZjbTkxZEdWQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TnpnS0lDQWdJQzh2SUdGa1pGWmhiR2xrWVhSdmNpaHVabVJPWVcxbE9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d2dZMjl1Wm1sbk9pQldZV3hwWkdGMGIzSkRiMjVtYVdjcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTNPQW9nSUNBZ0x5OGdZV1JrVm1Gc2FXUmhkRzl5S0c1bVpFNWhiV1U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6TENCamIyNW1hV2M2SUZaaGJHbGtZWFJ2Y2tOdmJtWnBaeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlHRmtaRlpoYkdsa1lYUnZjZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJPUmtSU1pXZHBjM1J5ZVVsRVgzSnZkWFJsUURJek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNamMwQ2lBZ0lDQXZMeUJuWlhST1JrUlNaV2RwYzNSeWVVbEVLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUk9iMlJsVUc5dmJFRnpjMmxuYm0xbGJuUnpYM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpZNUNpQWdJQ0F2THlCblpYUk9iMlJsVUc5dmJFRnpjMmxuYm0xbGJuUnpLSFpoYkdsa1lYUnZja2xrT2lCMWFXNTBOalFwT2lCT2IyUmxVRzl2YkVGemMybG5ibTFsYm5SRGIyNW1hV2NnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMk9Rb2dJQ0FnTHk4Z1oyVjBUbTlrWlZCdmIyeEJjM05wWjI1dFpXNTBjeWgyWVd4cFpHRjBiM0pKWkRvZ2RXbHVkRFkwS1RvZ1RtOWtaVkJ2YjJ4QmMzTnBaMjV0Wlc1MFEyOXVabWxuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVG05a1pWQnZiMnhCYzNOcFoyNXRaVzUwY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVWIydGxibEJoZVc5MWRGSmhkR2x2WDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qWTFDaUFnSUNBdkx5Qm5aWFJVYjJ0bGJsQmhlVzkxZEZKaGRHbHZLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VwT2lCUWIyOXNWRzlyWlc1UVlYbHZkWFJTWVhScGJ5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNalkxQ2lBZ0lDQXZMeUJuWlhSVWIydGxibEJoZVc5MWRGSmhkR2x2S0haaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVcE9pQlFiMjlzVkc5clpXNVFZWGx2ZFhSU1lYUnBieUI3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlJ2YTJWdVVHRjViM1YwVW1GMGFXOEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVM1JoYTJWa1VHOXZiSE5HYjNKQlkyTnZkVzUwWDNKdmRYUmxRREl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qVXhDaUFnSUNBdkx5Qm5aWFJUZEdGclpXUlFiMjlzYzBadmNrRmpZMjkxYm5Rb2MzUmhhMlZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUJXWVd4cFpHRjBiM0pRYjI5c1MyVjVXMTBnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMU1Rb2dJQ0FnTHk4Z1oyVjBVM1JoYTJWa1VHOXZiSE5HYjNKQlkyTnZkVzUwS0hOMFlXdGxjam9nWVhKak5DNUJaR1J5WlhOektUb2dWbUZzYVdSaGRHOXlVRzl2YkV0bGVWdGRJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVM1JoYTJWa1VHOXZiSE5HYjNKQlkyTnZkVzUwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlJ2WlhOVGRHRnJaWEpPWldWa1ZHOVFZWGxOUWxKZmNtOTFkR1ZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lORGNLSUNBZ0lDOHZJR1J2WlhOVGRHRnJaWEpPWldWa1ZHOVFZWGxOUWxJb2MzUmhhMlZ5T2lCaGNtTTBMa0ZrWkhKbGMzTXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWbUZzYVdSaGRHOXlVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TkRjS0lDQWdJQzh2SUdSdlpYTlRkR0ZyWlhKT1pXVmtWRzlRWVhsTlFsSW9jM1JoYTJWeU9pQmhjbU0wTGtGa1pISmxjM01wT2lCaWIyOXNaV0Z1SUhzS0lDQWdJR05oYkd4emRXSWdaRzlsYzFOMFlXdGxjazVsWldSVWIxQmhlVTFDVWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJEZFhKTllYaFRkR0ZyWlZCbGNsQnZiMnhmY205MWRHVkFNVGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU16UUtJQ0FnSUM4dklHZGxkRU4xY2sxaGVGTjBZV3RsVUdWeVVHOXZiQ2gyWVd4cFpHRjBiM0pKWkRvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVm1Gc2FXUmhkRzl5VW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU16UUtJQ0FnSUM4dklHZGxkRU4xY2sxaGVGTjBZV3RsVUdWeVVHOXZiQ2gyWVd4cFpHRjBiM0pKWkRvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwUTNWeVRXRjRVM1JoYTJWUVpYSlFiMjlzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZCdmIyeEpibVp2WDNKdmRYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qTXdDaUFnSUNBdkx5Qm5aWFJRYjI5c1NXNW1ieWh3YjI5c1MyVjVPaUJXWVd4cFpHRjBiM0pRYjI5c1MyVjVLVG9nVUc5dmJFbHVabThnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJek1Bb2dJQ0FnTHk4Z1oyVjBVRzl2YkVsdVptOG9jRzl2YkV0bGVUb2dWbUZzYVdSaGRHOXlVRzl2YkV0bGVTazZJRkJ2YjJ4SmJtWnZJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVRzl2YkVsdVptOEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVRzl2YkVGd2NFbGtYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpJMUNpQWdJQ0F2THlCblpYUlFiMjlzUVhCd1NXUW9kbUZzYVdSaGRHOXlTV1E2SUhWcGJuUTJOQ3dnY0c5dmJFbGtPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QldZV3hwWkdGMGIzSlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakl5TlFvZ0lDQWdMeThnWjJWMFVHOXZiRUZ3Y0Vsa0tIWmhiR2xrWVhSdmNrbGtPaUIxYVc1ME5qUXNJSEJ2YjJ4SlpEb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVHOXZiRUZ3Y0Vsa0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGQnZiMnh6WDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qRXpDaUFnSUNBdkx5Qm5aWFJRYjI5c2N5aDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxLVG9nVUc5dmJFbHVabTliWFNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qRXpDaUFnSUNBdkx5Qm5aWFJRYjI5c2N5aDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxLVG9nVUc5dmJFbHVabTliWFNCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZCdmIyeHpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlpoYkdsa1lYUnZjazkzYm1WeVFXNWtUV0Z1WVdkbGNsOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakl3T0FvZ0lDQWdMeThnWjJWMFZtRnNhV1JoZEc5eVQzZHVaWEpCYm1STllXNWhaMlZ5S0haaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVcE9pQmJZWEpqTkM1QlpHUnlaWE56TENCaGNtTTBMa0ZrWkhKbGMzTmRJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWbUZzYVdSaGRHOXlVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUdkbGRGWmhiR2xrWVhSdmNrOTNibVZ5UVc1a1RXRnVZV2RsY2loMllXeHBaR0YwYjNKSlpEb2dWbUZzYVdSaGRHOXlTV1JVZVhCbEtUb2dXMkZ5WXpRdVFXUmtjbVZ6Y3l3Z1lYSmpOQzVCWkdSeVpYTnpYU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlpoYkdsa1lYUnZjazkzYm1WeVFXNWtUV0Z1WVdkbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUldZV3hwWkdGMGIzSlRkR0YwWlY5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdaMlYwVm1Gc2FXUmhkRzl5VTNSaGRHVW9kbUZzYVdSaGRHOXlTV1E2SUZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU2s2SUZaaGJHbGtZWFJ2Y2tOMWNsTjBZWFJsSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVm1Gc2FXUmhkRzl5VW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU1EUUtJQ0FnSUM4dklHZGxkRlpoYkdsa1lYUnZjbE4wWVhSbEtIWmhiR2xrWVhSdmNrbGtPaUJXWVd4cFpHRjBiM0pKWkZSNWNHVXBPaUJXWVd4cFpHRjBiM0pEZFhKVGRHRjBaU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlpoYkdsa1lYUnZjbE4wWVhSbENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGWmhiR2xrWVhSdmNrTnZibVpwWjE5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXdNQW9nSUNBZ0x5OGdaMlYwVm1Gc2FXUmhkRzl5UTI5dVptbG5LSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VwT2lCV1lXeHBaR0YwYjNKRGIyNW1hV2NnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJd01Bb2dJQ0FnTHk4Z1oyVjBWbUZzYVdSaGRHOXlRMjl1Wm1sbktIWmhiR2xrWVhSdmNrbGtPaUJXWVd4cFpHRjBiM0pKWkZSNWNHVXBPaUJXWVd4cFpHRjBiM0pEYjI1bWFXY2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUldZV3hwWkdGMGIzSkRiMjVtYVdjS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFRuVnRWbUZzYVdSaGRHOXljMTl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNU5nb2dJQ0FnTHk4Z1oyVjBUblZ0Vm1Gc2FXUmhkRzl5Y3lncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEU1MWJWWmhiR2xrWVhSdmNuTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVSEp2ZEc5amIyeERiMjV6ZEhKaGFXNTBjMTl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNE1Bb2dJQ0FnTHk4Z1oyVjBVSEp2ZEc5amIyeERiMjV6ZEhKaGFXNTBjeWdwT2lCRGIyNXpkSEpoYVc1MGN5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd1pqUXlOREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREJtTkRJME1EQXdNREF3TURBd01EQXdaalF5TkRBd01EQXdNMlpoWVRJMU1qSTJNREF3TURBd01URXdaRGt6TVRabFl6QXdNREF3TURCaU5XVTJNakJtTkRnd01EQXdNREF3TURBd01EQXdNREF3TURBNE1EQXdNREF3TURBd01EQXdNREF3TXpBd01EQXdNREF3TURBd01EQXdZemdLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJOWW5KQmJXOTFiblJ6WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE56RUtJQ0FnSUM4dklHZGxkRTFpY2tGdGIzVnVkSE1vS1RvZ1RXSnlRVzF2ZFc1MGN5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQTJNekkxTkRBd01EQXdNREF3TURBeE16bGlPRGd3TURBd01EQXdNREEwWXpZMFpqVTBNREF3TURBd01EQXdNREF4TWpFM05Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkaGMxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJuWVhNb0tUb2dkbTlwWkNCN2ZRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJacGJtRnNhWHBsVTNSaGEybHVaME52Ym5SeVlXTjBYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmpVS0lDQWdJQzh2SUdacGJtRnNhWHBsVTNSaGEybHVaME52Ym5SeVlXTjBLQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdacGJtRnNhWHBsVTNSaGEybHVaME52Ym5SeVlXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyeHZZV1JUZEdGcmFXNW5RMjl1ZEhKaFkzUkVZWFJoWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklHeHZZV1JUZEdGcmFXNW5RMjl1ZEhKaFkzUkVZWFJoS0c5bVpuTmxkRG9nZFdsdWREWTBMQ0JrWVhSaE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJXWVd4cFpHRjBiM0pTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmpBS0lDQWdJQzh2SUd4dllXUlRkR0ZyYVc1blEyOXVkSEpoWTNSRVlYUmhLRzltWm5ObGREb2dkV2x1ZERZMExDQmtZWFJoT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ1kyRnNiSE4xWWlCc2IyRmtVM1JoYTJsdVowTnZiblJ5WVdOMFJHRjBZUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBibWwwVTNSaGEybHVaME52Ym5SeVlXTjBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUdsdWFYUlRkR0ZyYVc1blEyOXVkSEpoWTNRb1lYQndjbTkyWVd4UWNtOW5jbUZ0VTJsNlpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QnBibWwwVTNSaGEybHVaME52Ym5SeVlXTjBLR0Z3Y0hKdmRtRnNVSEp2WjNKaGJWTnBlbVU2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ1kyRnNiSE4xWWlCcGJtbDBVM1JoYTJsdVowTnZiblJ5WVdOMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5Ea0tJQ0FnSUM4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakUwTXdvZ0lDQWdMeThnZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JWY0dSaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJSFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZPbFpoYkdsa1lYUnZjbEpsWjJsemRISjVMblZ3WkdGMFpVRndjR3hwWTJGMGFXOXVLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxRWEJ3YkdsallYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklITjBZV3RwYm1kUWIyOXNRWEJ3Y205MllXeFFjbTluY21GdElEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKM0J2YjJ4VVpXMXdiR0YwWlVGd2NISnZkbUZzUW5sMFpYTW5JSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p3YjI5c1ZHVnRjR3hoZEdWQmNIQnliM1poYkVKNWRHVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRRMUNpQWdJQ0F2THlCMGFHbHpMbk4wWVd0cGJtZFFiMjlzUVhCd2NtOTJZV3hRY205bmNtRnRMbVJsYkdWMFpTZ3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFek5nb2dJQ0FnTHk4Z2MzUmhhMmx1WjFCdmIyeEpibWwwYVdGc2FYcGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhMlY1T2lBbmFXNXBkQ2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sdWFYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRZS0lDQWdJQzh2SUhSb2FYTXVjM1JoYTJsdVoxQnZiMnhKYm1sMGFXRnNhWHBsWkM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPanBXWVd4cFpHRjBiM0pTWldkcGMzUnllUzVqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QnpkR0ZyYVc1blVHOXZiRWx1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZHBibWwwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWFXNXBkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGcmFXNW5VRzl2YkVsdWFYUnBZV3hwZW1Wa0xuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCdWRXMVdZV3hwWkdGMGIzSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjI1MWJWWW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p1ZFcxV0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFV4Q2lBZ0lDQXZMeUIwYUdsekxtNTFiVlpoYkdsa1lYUnZjbk11ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFek9Bb2dJQ0FnTHk4Z2JuVnRVM1JoYTJWeWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R1ZFcxVGRHRnJaWEp6SnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdWRXMVRkR0ZyWlhKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUIwYUdsekxtNTFiVk4wWVd0bGNuTXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnZEc5MFlXeEJiR2R2VTNSaGEyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNOMFlXdGxaQ2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpYzNSaGEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1FXeG5iMU4wWVd0bFpDNTJZV3gxWlNBOUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZPbFpoYkdsa1lYUnZjbEpsWjJsemRISjVMbWx1YVhSVGRHRnJhVzVuUTI5dWRISmhZM1FvWVhCd2NtOTJZV3hRY205bmNtRnRVMmw2WlRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwcGJtbDBVM1JoYTJsdVowTnZiblJ5WVdOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUJwYm1sMFUzUmhhMmx1WjBOdmJuUnlZV04wS0dGd2NISnZkbUZzVUhKdlozSmhiVk5wZW1VNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUhOMFlXdHBibWRRYjI5c1FYQndjbTkyWVd4UWNtOW5jbUZ0SUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0ozQnZiMnhVWlcxd2JHRjBaVUZ3Y0hKdmRtRnNRbmwwWlhNbklIMHBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSndiMjlzVkdWdGNHeGhkR1ZCY0hCeWIzWmhiRUo1ZEdWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFUzQ2lBZ0lDQXZMeUIwYUdsekxuTjBZV3RwYm1kUWIyOXNRWEJ3Y205MllXeFFjbTluY21GdExtTnlaV0YwWlNoN0lITnBlbVU2SUdGd2NISnZkbUZzVUhKdlozSmhiVk5wZW1VZ2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlZtRnNhV1JoZEc5eVVtVm5hWE4wY25rdWJHOWhaRk4wWVd0cGJtZERiMjUwY21GamRFUmhkR0VvYjJabWMyVjBPaUIxYVc1ME5qUXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwc2IyRmtVM1JoYTJsdVowTnZiblJ5WVdOMFJHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMk1Bb2dJQ0FnTHk4Z2JHOWhaRk4wWVd0cGJtZERiMjUwY21GamRFUmhkR0VvYjJabWMyVjBPaUIxYVc1ME5qUXNJR1JoZEdFNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnYzNSaGEybHVaMUJ2YjJ4SmJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0hzZ2EyVjVPaUFuYVc1cGRDY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnBibWwwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbk4wWVd0cGJtZFFiMjlzU1c1cGRHbGhiR2w2WldRdWRtRnNkV1VwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1bWFXNWhiR2w2WlZOMFlXdHBibWREYjI1MGNtRmpkQ2dwSUMwK0lIWnZhV1E2Q21acGJtRnNhWHBsVTNSaGEybHVaME52Ym5SeVlXTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNMkNpQWdJQ0F2THlCemRHRnJhVzVuVUc5dmJFbHVhWFJwWVd4cGVtVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b2V5QnJaWGs2SUNkcGJtbDBKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYVc1cGRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakUyTmdvZ0lDQWdMeThnZEdocGN5NXpkR0ZyYVc1blVHOXZiRWx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDBnZEhKMVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZWbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VaMlYwVG5WdFZtRnNhV1JoZEc5eWN5Z3BJQzArSUhWcGJuUTJORG9LWjJWMFRuVnRWbUZzYVdSaGRHOXljem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z2JuVnRWbUZzYVdSaGRHOXljeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkdWRXMVdKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTUxYlZZaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UazNDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV1ZFcxV1lXeHBaR0YwYjNKekxuWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlZtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVoyVjBWbUZzYVdSaGRHOXlRMjl1Wm1sbktIWmhiR2xrWVhSdmNrbGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSV1lXeHBaR0YwYjNKRGIyNW1hV2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklHZGxkRlpoYkdsa1lYUnZja052Ym1acFp5aDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxLVG9nVm1Gc2FXUmhkRzl5UTI5dVptbG5JSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNakF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSFpoYkdsa1lYUnZja2xrS1M1MllXeDFaUzVqYjI1bWFXY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUIyWVd4cFpHRjBiM0pNYVhOMElEMGdRbTk0VFdGd1BGWmhiR2xrWVhSdmNrbGtWSGx3WlN3Z1ZtRnNhV1JoZEc5eVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZDJKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZGlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNakF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSFpoYkdsa1lYUnZja2xrS1M1MllXeDFaUzVqYjI1bWFXY0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1blpYUldZV3hwWkdGMGIzSlRkR0YwWlNoMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwVm1Gc2FXUmhkRzl5VTNSaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUdkbGRGWmhiR2xrWVhSdmNsTjBZWFJsS0haaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVcE9pQldZV3hwWkdGMGIzSkRkWEpUZEdGMFpTQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXdOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZG1Gc2FXUmhkRzl5VEdsemRDaDJZV3hwWkdGMGIzSkpaQ2t1ZG1Gc2RXVXVjM1JoZEdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QjJZV3hwWkdGMGIzSk1hWE4wSUQwZ1FtOTRUV0Z3UEZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dnVm1Gc2FXUmhkRzl5U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkMkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qQTFDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUyWVd4cFpHRjBiM0pNYVhOMEtIWmhiR2xrWVhSdmNrbGtLUzUyWVd4MVpTNXpkR0YwWlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdOZk1pQXZMeUF5TmpRS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlZtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVoyVjBWbUZzYVdSaGRHOXlUM2R1WlhKQmJtUk5ZVzVoWjJWeUtIWmhiR2xrWVhSdmNrbGtPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSV1lXeHBaR0YwYjNKUGQyNWxja0Z1WkUxaGJtRm5aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU1EZ0tJQ0FnSUM4dklHZGxkRlpoYkdsa1lYUnZjazkzYm1WeVFXNWtUV0Z1WVdkbGNpaDJZV3hwWkdGMGIzSkpaRG9nVm1Gc2FXUmhkRzl5U1dSVWVYQmxLVG9nVzJGeVl6UXVRV1JrY21WemN5d2dZWEpqTkM1QlpHUnlaWE56WFNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJd09Rb2dJQ0FnTHk4Z1kyOXVjM1FnZG1Gc2FXUmhkRzl5SUQwZ1kyeHZibVVvZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QjJZV3hwWkdGMGIzSk1hWE4wSUQwZ1FtOTRUV0Z3UEZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dnVm1Gc2FXUmhkRzl5U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkMkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qQTVDaUFnSUNBdkx5QmpiMjV6ZENCMllXeHBaR0YwYjNJZ1BTQmpiRzl1WlNoMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMblpoYkhWbEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakl4TUFvZ0lDQWdMeThnY21WMGRYSnVJRnQyWVd4cFpHRjBiM0l1WTI5dVptbG5MbTkzYm1WeUxDQjJZV3hwWkdGMGIzSXVZMjl1Wm1sbkxtMWhibUZuWlhKZENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREkyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0E0SURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRFF3SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPanBXWVd4cFpHRjBiM0pTWldkcGMzUnllUzVuWlhSUWIyOXNjeWgyWVd4cFpHRjBiM0pKWkRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBVRzl2YkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNVE1LSUNBZ0lDOHZJR2RsZEZCdmIyeHpLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VwT2lCUWIyOXNTVzVtYjF0ZElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJeE5Bb2dJQ0FnTHk4Z1kyOXVjM1FnY21WMFJHRjBZVG9nVUc5dmJFbHVabTliWFNBOUlGdGRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qRTFDaUFnSUNBdkx5QmpiMjV6ZENCd2IyOXNVMlYwSUQwZ1kyeHZibVVvZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1d2IyOXNjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRRd0NpQWdJQ0F2THlCMllXeHBaR0YwYjNKTWFYTjBJRDBnUW05NFRXRndQRlpoYkdsa1lYUnZja2xrVkhsd1pTd2dWbUZzYVdSaGRHOXlTVzVtYno0b2V5QnJaWGxRY21WbWFYZzZJQ2QySnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpFMUNpQWdJQ0F2THlCamIyNXpkQ0J3YjI5c1UyVjBJRDBnWTJ4dmJtVW9kR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSFpoYkdsa1lYUnZja2xrS1M1MllXeDFaUzV3YjI5c2N5a0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCcGJuUmpJRFFnTHk4Z01qazJDaUFnSUNCcGJuUmpJRFVnTHk4Z05UYzJDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qRTJDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2djRzl2YkZObGRDNXNaVzVuZEdnN0lHa2dLejBnTVNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtZGxkRkJ2YjJ4elgzZG9hV3hsWDNSdmNFQXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpFMkNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2NHOXZiRk5sZEM1c1pXNW5kR2c3SUdrZ0t6MGdNU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXlOQW9nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBVRzl2YkhOZllteHZZMnRBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qRTNDaUFnSUNBdkx5QnBaaUFvY0c5dmJGTmxkRnRwWFM1d2IyOXNRWEJ3U1dRZ1BUMDlJREFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZbm9nWjJWMFVHOXZiSE5mWW14dlkydEFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpJd0NpQWdJQ0F2THlCeVpYUkVZWFJoTG5CMWMyZ29jRzl2YkZObGRGdHBYU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUWdMeThnYjI0Z1pYSnliM0k2SUcxaGVDQmhjbkpoZVNCc1pXNW5kR2dnWlhoalpXVmtaV1FLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakl4TmdvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUhCdmIyeFRaWFF1YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQmlJR2RsZEZCdmIyeHpYM2RvYVd4bFgzUnZjRUF4Q2dwblpYUlFiMjlzYzE5aWJHOWphMEEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qSXlDaUFnSUNBdkx5QnlaWFIxY200Z2NtVjBSR0YwWVFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2xaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1kbGRGQnZiMnhCY0hCSlpDaDJZV3hwWkdGMGIzSkpaRG9nZFdsdWREWTBMQ0J3YjI5c1NXUTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BuWlhSUWIyOXNRWEJ3U1dRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNalVLSUNBZ0lDOHZJR2RsZEZCdmIyeEJjSEJKWkNoMllXeHBaR0YwYjNKSlpEb2dkV2x1ZERZMExDQndiMjlzU1dRNklIVnBiblEyTkNrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJeU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCdmIyeEpaQ0FoUFQwZ01DQW1KaUJ3YjI5c1NXUWdQRDBnZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1d2IyOXNjeTVzWlc1bmRHZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNklHZGxkRkJ2YjJ4QmNIQkpaRjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QjJZV3hwWkdGMGIzSk1hWE4wSUQwZ1FtOTRUV0Z3UEZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dnVm1Gc2FXUmhkRzl5U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkMkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qSTJDaUFnSUNBdkx5QmhjM05sY25Rb2NHOXZiRWxrSUNFOVBTQXdJQ1ltSUhCdmIyeEpaQ0E4UFNCMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMblpoYkhWbExuQnZiMnh6TG14bGJtZDBhQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQThQUW9nSUNBZ1lub2daMlYwVUc5dmJFRndjRWxrWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtZGxkRkJ2YjJ4QmNIQkpaRjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNallLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdiMjlzU1dRZ0lUMDlJREFnSmlZZ2NHOXZiRWxrSUR3OUlIUm9hWE11ZG1Gc2FXUmhkRzl5VEdsemRDaDJZV3hwWkdGMGIzSkpaQ2t1ZG1Gc2RXVXVjRzl2YkhNdWJHVnVaM1JvS1FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNamNLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9kbUZzYVdSaGRHOXlTV1FwTG5aaGJIVmxMbkJ2YjJ4elczQnZiMnhKWkNBdElERmRMbkJ2YjJ4QmNIQkpaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhaaGJHbGtZWFJ2Y2t4cGMzUWdQU0JDYjNoTllYQThWbUZzYVdSaGRHOXlTV1JVZVhCbExDQldZV3hwWkdGMGIzSkpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TWpjS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuWmhiR2xrWVhSdmNreHBjM1FvZG1Gc2FXUmhkRzl5U1dRcExuWmhiSFZsTG5CdmIyeHpXM0J2YjJ4SlpDQXRJREZkTG5CdmIyeEJjSEJKWkFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdNZ05DQXZMeUF5T1RZS0lDQWdJR2x1ZEdNZ05TQXZMeUExTnpZS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNalFLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeU5Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhKbGRITjFZZ29LWjJWMFVHOXZiRUZ3Y0Vsa1gySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHZGxkRkJ2YjJ4QmNIQkpaRjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlZtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVoyVjBVRzl2YkVsdVptOG9jRzl2YkV0bGVUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJRYjI5c1NXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJek1Bb2dJQ0FnTHk4Z1oyVjBVRzl2YkVsdVptOG9jRzl2YkV0bGVUb2dWbUZzYVdSaGRHOXlVRzl2YkV0bGVTazZJRkJ2YjJ4SmJtWnZJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNak14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSEJ2YjJ4TFpYa3VhV1FwTG5aaGJIVmxMbkJ2YjJ4elczQnZiMnhMWlhrdWNHOXZiRWxrSUMwZ01WMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJSFpoYkdsa1lYUnZja3hwYzNRZ1BTQkNiM2hOWVhBOFZtRnNhV1JoZEc5eVNXUlVlWEJsTENCV1lXeHBaR0YwYjNKSmJtWnZQaWg3SUd0bGVWQnlaV1pwZURvZ0ozWW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oySWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9jRzl2YkV0bGVTNXBaQ2t1ZG1Gc2RXVXVjRzl2YkhOYmNHOXZiRXRsZVM1d2IyOXNTV1FnTFNBeFhRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdsdWRHTWdOQ0F2THlBeU9UWUtJQ0FnSUdsdWRHTWdOU0F2THlBMU56WUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNeUF2THlBeU5Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcFdZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNW5aWFJEZFhKTllYaFRkR0ZyWlZCbGNsQnZiMndvZG1Gc2FXUmhkRzl5U1dRNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncG5aWFJEZFhKTllYaFRkR0ZyWlZCbGNsQnZiMnc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU16UUtJQ0FnSUM4dklHZGxkRU4xY2sxaGVGTjBZV3RsVUdWeVVHOXZiQ2gyWVd4cFpHRjBiM0pKWkRvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TXpVS0lDQWdJQzh2SUdOdmJuTjBJRzUxYlZCdmIyeHpPaUIxYVc1ME5qUWdQU0IwYUdsekxuWmhiR2xrWVhSdmNreHBjM1FvZG1Gc2FXUmhkRzl5U1dRcExuWmhiSFZsTG5OMFlYUmxMbTUxYlZCdmIyeHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakUwTUFvZ0lDQWdMeThnZG1Gc2FXUmhkRzl5VEdsemRDQTlJRUp2ZUUxaGNEeFdZV3hwWkdGMGIzSkpaRlI1Y0dVc0lGWmhiR2xrWVhSdmNrbHVabTgrS0hzZ2EyVjVVSEpsWm1sNE9pQW5kaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakl6TlFvZ0lDQWdMeThnWTI5dWMzUWdiblZ0VUc5dmJITTZJSFZwYm5RMk5DQTlJSFJvYVhNdWRtRnNhV1JoZEc5eVRHbHpkQ2gyWVd4cFpHRjBiM0pKWkNrdWRtRnNkV1V1YzNSaGRHVXViblZ0VUc5dmJITUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeU5qUUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlDaHZibXhwYm1VZ0tpQk5RVmhmVmtGTVNVUkJWRTlTWDBoQlVrUmZVRU5VWDA5R1gwOU9URWxPUlY4eFJFVkRTVTFCVENrZ0x5QXhNREF3Q2lBZ0lDQndkWE5vYVc1MElETXdNREF3TURBd01EQXdNREF3TUNBdkx5QXpNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXpOZ29nSUNBZ0x5OGdZMjl1YzNRZ2FHRnlaRTFoZUVScGRtbGtaV1JDWlhSM1pXVnVVRzl2YkhNNklIVnBiblEyTkNBOUlIUm9hWE11YldGNFFXeHNiM2RsWkZOMFlXdGxLQ2tnTHlCdWRXMVFiMjlzY3dvZ0lDQWdjM2RoY0FvZ0lDQWdMd29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpNM0NpQWdJQ0F2THlCc1pYUWdiV0Y0VUdWeVVHOXZiRG9nZFdsdWREWTBJRDBnZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1amIyNW1hV2N1YldGNFFXeG5iMUJsY2xCdmIyd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTWpZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR2x1ZENBeU16SWdMeThnTWpNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNemdLSUNBZ0lDOHZJR2xtSUNodFlYaFFaWEpRYjI5c0lEMDlQU0F3S1NCN0NpQWdJQ0JpYm5vZ1oyVjBRM1Z5VFdGNFUzUmhhMlZRWlhKUWIyOXNYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZORE0zQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdOekJmTURBd1h6QXdNRjh3TURCZk1EQXdJQzh2SURjd2JTQkJURWRQSUdsdUlHMXBZM0p2UVd4bmJ3b2dJQ0FnY0hWemFHbHVkQ0EzTURBd01EQXdNREF3TURBd01DQXZMeUEzTURBd01EQXdNREF3TURBd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncG5aWFJEZFhKTllYaFRkR0ZyWlZCbGNsQnZiMnhmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOREVLSUNBZ0lDOHZJR2xtSUNob1lYSmtUV0Y0UkdsMmFXUmxaRUpsZEhkbFpXNVFiMjlzY3lBOElHMWhlRkJsY2xCdmIyd3BJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNBK0NpQWdJQ0JpZWlCblpYUkRkWEpOWVhoVGRHRnJaVkJsY2xCdmIyeGZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwblpYUkRkWEpOWVhoVGRHRnJaVkJsY2xCdmIyeGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNalEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiV0Y0VUdWeVVHOXZiQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2xaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1SdlpYTlRkR0ZyWlhKT1pXVmtWRzlRWVhsTlFsSW9jM1JoYTJWeU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGtiMlZ6VTNSaGEyVnlUbVZsWkZSdlVHRjVUVUpTT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qUTNDaUFnSUNBdkx5QmtiMlZ6VTNSaGEyVnlUbVZsWkZSdlVHRjVUVUpTS0hOMFlXdGxjam9nWVhKak5DNUJaR1J5WlhOektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTBNUW9nSUNBZ0x5OGdjM1JoYTJWeVVHOXZiRk5sZENBOUlFSnZlRTFoY0R4aGNtTTBMa0ZrWkhKbGMzTXNJRVpwZUdWa1FYSnlZWGs4Vm1Gc2FXUmhkRzl5VUc5dmJFdGxlU3dnZEhsd1pXOW1JRTFCV0Y5UVQwOU1VMTlRUlZKZlUxUkJTMFZTUGo0b2V5QnJaWGxRY21WbWFYZzZJQ2R6Y0hNbklIMHBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnpjSE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qUTRDaUFnSUNBdkx5QnlaWFIxY200Z0lYUm9hWE11YzNSaGEyVnlVRzl2YkZObGRDaHpkR0ZyWlhJcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZWbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VaMlYwVTNSaGEyVmtVRzl2YkhOR2IzSkJZMk52ZFc1MEtITjBZV3RsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUlRkR0ZyWldSUWIyOXNjMFp2Y2tGalkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5URUtJQ0FnSUM4dklHZGxkRk4wWVd0bFpGQnZiMnh6Um05eVFXTmpiM1Z1ZENoemRHRnJaWEk2SUdGeVl6UXVRV1JrY21WemN5azZJRlpoYkdsa1lYUnZjbEJ2YjJ4TFpYbGJYU0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFF4Q2lBZ0lDQXZMeUJ6ZEdGclpYSlFiMjlzVTJWMElEMGdRbTk0VFdGd1BHRnlZelF1UVdSa2NtVnpjeXdnUm1sNFpXUkJjbkpoZVR4V1lXeHBaR0YwYjNKUWIyOXNTMlY1TENCMGVYQmxiMllnVFVGWVgxQlBUMHhUWDFCRlVsOVRWRUZMUlZJK1BpaDdJR3RsZVZCeVpXWnBlRG9nSjNOd2N5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbk53Y3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTFNZ29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbk4wWVd0bGNsQnZiMnhUWlhRb2MzUmhhMlZ5S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR2RsZEZOMFlXdGxaRkJ2YjJ4elJtOXlRV05qYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTFNd29nSUNBZ0x5OGdjbVYwZFhKdUlGdGRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtZGxkRk4wWVd0bFpGQnZiMnh6Um05eVFXTmpiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5UVUtJQ0FnSUM4dklHTnZibk4wSUhKbGRFUmhkR0U2SUZaaGJHbGtZWFJ2Y2xCdmIyeExaWGxiWFNBOUlGdGRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TUFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5UWUtJQ0FnSUM4dklHTnZibk4wSUhCdmIyeFRaWFFnUFNCamJHOXVaU2gwYUdsekxuTjBZV3RsY2xCdmIyeFRaWFFvYzNSaGEyVnlLUzUyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOVGNLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0J3YjI5c1UyVjBMbXhsYm1kMGFEc2dhU0FyUFNBeEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENncG5aWFJUZEdGclpXUlFiMjlzYzBadmNrRmpZMjkxYm5SZmQyaHBiR1ZmZEc5d1FETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TlRjS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCd2IyOXNVMlYwTG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBMklDOHZJRFlLSUNBZ0lEd0tJQ0FnSUdKNklHZGxkRk4wWVd0bFpGQnZiMnh6Um05eVFXTmpiM1Z1ZEY5aFpuUmxjbDkzYUdsc1pVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TlRnS0lDQWdJQzh2SUdsbUlDaHdiMjlzVTJWMFcybGRMbWxrSUNFOVBTQXdLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2FXNTBZMTh6SUM4dklESTBDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdKNklHZGxkRk4wWVd0bFpGQnZiMnh6Um05eVFXTmpiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMU9Rb2dJQ0FnTHk4Z2NtVjBSR0YwWVM1d2RYTm9LSEJ2YjJ4VFpYUmJhVjBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBJQzh2SUc5dUlHVnljbTl5T2lCdFlYZ2dZWEp5WVhrZ2JHVnVaM1JvSUdWNFkyVmxaR1ZrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BuWlhSVGRHRnJaV1JRYjI5c2MwWnZja0ZqWTI5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qVTNDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2djRzl2YkZObGRDNXNaVzVuZEdnN0lHa2dLejBnTVNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ1oyVjBVM1JoYTJWa1VHOXZiSE5HYjNKQlkyTnZkVzUwWDNkb2FXeGxYM1J2Y0VBekNncG5aWFJUZEdGclpXUlFiMjlzYzBadmNrRmpZMjkxYm5SZllXWjBaWEpmZDJocGJHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMk1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGRFUmhkR0VLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPanBXWVd4cFpHRjBiM0pTWldkcGMzUnllUzVuWlhSVWIydGxibEJoZVc5MWRGSmhkR2x2S0haaGJHbGtZWFJ2Y2tsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncG5aWFJVYjJ0bGJsQmhlVzkxZEZKaGRHbHZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpZMUNpQWdJQ0F2THlCblpYUlViMnRsYmxCaGVXOTFkRkpoZEdsdktIWmhiR2xrWVhSdmNrbGtPaUJXWVd4cFpHRjBiM0pKWkZSNWNHVXBPaUJRYjI5c1ZHOXJaVzVRWVhsdmRYUlNZWFJwYnlCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdWRHOXJaVzVRWVhsdmRYUlNZWFJwYndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIWmhiR2xrWVhSdmNreHBjM1FnUFNCQ2IzaE5ZWEE4Vm1Gc2FXUmhkRzl5U1dSVWVYQmxMQ0JXWVd4cFpHRjBiM0pKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNZbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjJJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMblpoYkhWbExuUnZhMlZ1VUdGNWIzVjBVbUYwYVc4S0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0J3ZFhOb2FXNTBjeUE0TnpJZ01qQXdJQzh2SURnM01pd2dNakF3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZPbFpoYkdsa1lYUnZjbEpsWjJsemRISjVMbWRsZEU1dlpHVlFiMjlzUVhOemFXZHViV1Z1ZEhNb2RtRnNhV1JoZEc5eVNXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEU1dlpHVlFiMjlzUVhOemFXZHViV1Z1ZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOamtLSUNBZ0lDOHZJR2RsZEU1dlpHVlFiMjlzUVhOemFXZHViV1Z1ZEhNb2RtRnNhV1JoZEc5eVNXUTZJSFZwYm5RMk5DazZJRTV2WkdWUWIyOXNRWE56YVdkdWJXVnVkRU52Ym1acFp5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTNNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZG1Gc2FXUmhkRzl5VEdsemRDaDJZV3hwWkdGMGIzSkpaQ2t1WlhocGMzUnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhaaGJHbGtZWFJ2Y2t4cGMzUWdQU0JDYjNoTllYQThWbUZzYVdSaGRHOXlTV1JVZVhCbExDQldZV3hwWkdGMGIzSkpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TnpBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuWmhiR2xrWVhSdmNreHBjM1FvZG1Gc2FXUmhkRzl5U1dRcExtVjRhWE4wY3lrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJM01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdWJtOWtaVkJ2YjJ4QmMzTnBaMjV0Wlc1MGN3b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCd2RYTm9hVzUwSURFd056SWdMeThnTVRBM01nb2dJQ0FnYVc1MFl5QTJJQzh2SURFNU1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aFpHUldZV3hwWkdGMGIzSW9ibVprVG1GdFpUb2dZbmwwWlhNc0lHTnZibVpwWnpvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1lXUmtWbUZzYVdSaGRHOXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpjNENpQWdJQ0F2THlCaFpHUldZV3hwWkdGMGIzSW9ibVprVG1GdFpUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXNJR052Ym1acFp6b2dWbUZzYVdSaGRHOXlRMjl1Wm1sbktUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOdmJtWnBaeTVsYm5SeWVVZGhkR2x1WjFSNWNHVWdQajBnUjBGVVNVNUhYMVJaVUVWZlRrOU9SU0FtSmlCamIyNW1hV2N1Wlc1MGNubEhZWFJwYm1kVWVYQmxJRHc5SUVkQlZFbE9SMTlVV1ZCRlgwTlBUbE5VWDAxQldDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E0TUNBdkx5QTRNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQThQUW9nSUNBZ1lub2dZV1JrVm1Gc2FXUmhkRzl5WDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtRmtaRlpoYkdsa1lYUnZjbDlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3pPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpiMjVtYVdjdVpXNTBjbmxIWVhScGJtZFVlWEJsSUQ0OUlFZEJWRWxPUjE5VVdWQkZYMDVQVGtVZ0ppWWdZMjl1Wm1sbkxtVnVkSEo1UjJGMGFXNW5WSGx3WlNBOFBTQkhRVlJKVGtkZlZGbFFSVjlEVDA1VFZGOU5RVmdwQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTTVOUW9nSUNBZ0x5OGdZWE56WlhKMEtHTnZibVpwWnk1bGNHOWphRkp2ZFc1a1RHVnVaM1JvSUQ0OUlFMUpUbDlGVUU5RFNGOU1SVTVIVkVnZ0ppWWdZMjl1Wm1sbkxtVndiMk5vVW05MWJtUk1aVzVuZEdnZ1BEMGdUVUZZWDBWUVQwTklYMHhGVGtkVVNDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F4TnpZZ0x5OGdNVGMyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSjZJR0ZrWkZaaGJHbGtZWFJ2Y2w5aWIyOXNYMlpoYkhObFFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwYm5SaklEY2dMeThnTVRBd01EQXdNQW9nSUNBZ1BEMEtJQ0FnSUdKNklHRmtaRlpoYkdsa1lYUnZjbDlpYjI5c1gyWmhiSE5sUURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwaFpHUldZV3hwWkdGMGIzSmZZbTl2YkY5dFpYSm5aVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16azFDaUFnSUNBdkx5QmhjM05sY25Rb1kyOXVabWxuTG1Wd2IyTm9VbTkxYm1STVpXNW5kR2dnUGowZ1RVbE9YMFZRVDBOSVgweEZUa2RVU0NBbUppQmpiMjVtYVdjdVpYQnZZMmhTYjNWdVpFeGxibWQwYUNBOFBTQk5RVmhmUlZCUFEwaGZURVZPUjFSSUtRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96T1RZS0lDQWdJQzh2SUdGemMyVnlkQ2hqYjI1bWFXY3VjR1Z5WTJWdWRGUnZWbUZzYVdSaGRHOXlJRDQ5SUUxSlRsOVFRMVJmVkU5ZlZrRk1TVVJCVkU5U0lDWW1JR052Ym1acFp5NXdaWEpqWlc1MFZHOVdZV3hwWkdGMGIzSWdQRDBnVFVGWVgxQkRWRjlVVDE5V1FVeEpSRUZVVDFJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNVGcwSUM4dklERTROQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR01nTnlBdkx5QXhNREF3TURBd0NpQWdJQ0E4UFFvZ0lDQWdZbm9nWVdSa1ZtRnNhV1JoZEc5eVgySnZiMnhmWm1Gc2MyVkFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3BoWkdSV1lXeHBaR0YwYjNKZlltOXZiRjl0WlhKblpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNNU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOdmJtWnBaeTV3WlhKalpXNTBWRzlXWVd4cFpHRjBiM0lnUGowZ1RVbE9YMUJEVkY5VVQxOVdRVXhKUkVGVVQxSWdKaVlnWTI5dVptbG5MbkJsY21ObGJuUlViMVpoYkdsa1lYUnZjaUE4UFNCTlFWaGZVRU5VWDFSUFgxWkJURWxFUVZSUFVpa0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TXprM0NpQWdJQ0F2THlCaGMzTmxjblFvWTI5dVptbG5MbTFwYmtWdWRISjVVM1JoYTJVZ1BqMGdUVWxPWDBGTVIwOWZVMVJCUzBWZlVFVlNYMUJQVDB3cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNakkwSUM4dklESXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR01nTnlBdkx5QXhNREF3TURBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3pPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpiMjVtYVdjdWNHOXZiSE5RWlhKT2IyUmxJRDRnTUNBbUppQmpiMjVtYVdjdWNHOXZiSE5RWlhKT2IyUmxJRHc5SUUxQldGOVFUMDlNVTE5UVJWSmZUazlFUlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXlOREFnTHk4Z01qUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdKNklHRmtaRlpoYkdsa1lYUnZjbDlpYjI5c1gyWmhiSE5sUURFMkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SURNS0lDQWdJRHc5Q2lBZ0lDQmllaUJoWkdSV1lXeHBaR0YwYjNKZlltOXZiRjltWVd4elpVQXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbUZrWkZaaGJHbGtZWFJ2Y2w5aWIyOXNYMjFsY21kbFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TXprNENpQWdJQ0F2THlCaGMzTmxjblFvWTI5dVptbG5MbkJ2YjJ4elVHVnlUbTlrWlNBK0lEQWdKaVlnWTI5dVptbG5MbkJ2YjJ4elVHVnlUbTlrWlNBOFBTQk5RVmhmVUU5UFRGTmZVRVZTWDA1UFJFVXBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJNE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlHTnZibVpwWnk1dmQyNWxjaTVpZVhSbGN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQTRJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16Y0tJQ0FnSUM4dklHNTFiVlpoYkdsa1lYUnZjbk1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJuVnRWaWNnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p1ZFcxV0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTRNZ29nSUNBZ0x5OGdZMjl1YzNRZ2RtRnNhV1JoZEc5eVNXUTZJSFZwYm5RMk5DQTlJSFJvYVhNdWJuVnRWbUZzYVdSaGRHOXljeTUyWVd4MVpTQXJJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNemNLSUNBZ0lDOHZJRzUxYlZaaGJHbGtZWFJ2Y25NZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5iblZ0VmljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNTFiVllpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU9ETUtJQ0FnSUM4dklIUm9hWE11Ym5WdFZtRnNhV1JoZEc5eWN5NTJZV3gxWlNBOUlIWmhiR2xrWVhSdmNrbGtDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJNE5Rb2dJQ0FnTHk4Z2RHaHBjeTUyWVd4cFpHRjBiM0pNYVhOMEtIWmhiR2xrWVhSdmNrbGtLUzVqY21WaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhaaGJHbGtZWFJ2Y2t4cGMzUWdQU0JDYjNoTllYQThWbUZzYVdSaGRHOXlTV1JVZVhCbExDQldZV3hwWkdGMGIzSkpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpnMUNpQWdJQ0F2THlCMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMbU55WldGMFpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRJMk5DQXZMeUF4TWpZMENpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJNE5nb2dJQ0FnTHk4Z2RHaHBjeTUyWVd4cFpHRjBiM0pNYVhOMEtIWmhiR2xrWVhSdmNrbGtLUzUyWVd4MVpTNWpiMjVtYVdjZ1BTQmpiRzl1WlNoamIyNW1hV2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lPRGNLSUNBZ0lDOHZJSFJvYVhNdWRtRnNhV1JoZEc5eVRHbHpkQ2gyWVd4cFpHRjBiM0pKWkNrdWRtRnNkV1V1WTI5dVptbG5MbWxrSUQwZ2RtRnNhV1JoZEc5eVNXUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95T0RrS0lDQWdJQzh2SUhKbGRIVnliaUIyWVd4cFpHRjBiM0pKWkFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtRmtaRlpoYkdsa1lYUnZjbDlpYjI5c1gyWmhiSE5sUURFMk9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnWVdSa1ZtRnNhV1JoZEc5eVgySnZiMnhmYldWeVoyVkFNVGNLQ21Ga1pGWmhiR2xrWVhSdmNsOWliMjlzWDJaaGJITmxRREV5T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdZV1JrVm1Gc2FXUmhkRzl5WDJKdmIyeGZiV1Z5WjJWQU1UTUtDbUZrWkZaaGJHbGtZWFJ2Y2w5aWIyOXNYMlpoYkhObFFEZzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCaFpHUldZV3hwWkdGMGIzSmZZbTl2YkY5dFpYSm5aVUE1Q2dwaFpHUldZV3hwWkdGMGIzSmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdZV1JrVm1Gc2FXUmhkRzl5WDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcFdZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWphR0Z1WjJWV1lXeHBaR0YwYjNKTllXNWhaMlZ5S0haaGJHbGtZWFJ2Y2tsa09pQjFhVzUwTmpRc0lHMWhibUZuWlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamFHRnVaMlZXWVd4cFpHRjBiM0pOWVc1aFoyVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpreENpQWdJQ0F2THlCamFHRnVaMlZXWVd4cFpHRjBiM0pOWVc1aFoyVnlLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VzSUcxaGJtRm5aWEk2SUdGeVl6UXVRV1JrY21WemN5azZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU9USUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9kbUZzYVdSaGRHOXlTV1FwTG5aaGJIVmxMbU52Ym1acFp5NXZkMjVsY2k1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUIyWVd4cFpHRjBiM0pNYVhOMElEMGdRbTk0VFdGd1BGWmhiR2xrWVhSdmNrbGtWSGx3WlN3Z1ZtRnNhV1JoZEc5eVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZDJKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZGlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNamt5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1amIyNW1hV2N1YjNkdVpYSXVZbmwwWlhNcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREkyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU9UTUtJQ0FnSUM4dklIUm9hWE11ZG1Gc2FXUmhkRzl5VEdsemRDaDJZV3hwWkdGMGIzSkpaQ2t1ZG1Gc2RXVXVZMjl1Wm1sbkxtMWhibUZuWlhJZ1BTQnRZVzVoWjJWeUNpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZWbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZMmhoYm1kbFZtRnNhV1JoZEc5eVUzVnVjMlYwU1c1bWJ5aDJZV3hwWkdGMGIzSkpaRG9nZFdsdWREWTBMQ0J6ZFc1elpYUjBhVzVuVDI0NklIVnBiblEyTkN3Z2MzVnVjMlYwZEdsdVoxUnZPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbU5vWVc1blpWWmhiR2xrWVhSdmNsTjFibk5sZEVsdVptODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95T1RZS0lDQWdJQzh2SUdOb1lXNW5aVlpoYkdsa1lYUnZjbE4xYm5ObGRFbHVabThvZG1Gc2FXUmhkRzl5U1dRNklGWmhiR2xrWVhSdmNrbGtWSGx3WlN3Z2MzVnVjMlYwZEdsdVowOXVPaUIxYVc1ME5qUXNJSE4xYm5ObGRIUnBibWRVYnpvZ1ZtRnNhV1JoZEc5eVNXUlVlWEJsS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakk1TndvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdVkyOXVabWxuTG05M2JtVnlMbUo1ZEdWektRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIWmhiR2xrWVhSdmNreHBjM1FnUFNCQ2IzaE5ZWEE4Vm1Gc2FXUmhkRzl5U1dSVWVYQmxMQ0JXWVd4cFpHRjBiM0pKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNZbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjJJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU9UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9kbUZzYVdSaGRHOXlTV1FwTG5aaGJIVmxMbU52Ym1acFp5NXZkMjVsY2k1aWVYUmxjeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z01qWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaWGgwY21GamRDQTRJRE15Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPakk1T0FvZ0lDQWdMeThnZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1amIyNW1hV2N1YzNWdWMyVjBkR2x1WjA5dUlEMGdjM1Z1YzJWMGRHbHVaMDl1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESTBPQ0F2THlBeU5EZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJNU9Rb2dJQ0FnTHk4Z2RHaHBjeTUyWVd4cFpHRjBiM0pNYVhOMEtIWmhiR2xrWVhSdmNrbGtLUzUyWVd4MVpTNWpiMjVtYVdjdWMzVnVjMlYwZEdsdVoxUnZJRDBnYzNWdWMyVjBkR2x1WjFSdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJocGJuUWdNalUySUM4dklESTFOZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPanBXWVd4cFpHRjBiM0pTWldkcGMzUnllUzVqYUdGdVoyVldZV3hwWkdGMGIzSk9Sa1FvZG1Gc2FXUmhkRzl5U1dRNklIVnBiblEyTkN3Z2JtWmtRWEJ3U1VRNklIVnBiblEyTkN3Z2JtWmtUbUZ0WlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21Ob1lXNW5aVlpoYkdsa1lYUnZjazVHUkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXdNZ29nSUNBZ0x5OGdZMmhoYm1kbFZtRnNhV1JoZEc5eVRrWkVLSFpoYkdsa1lYUnZja2xrT2lCV1lXeHBaR0YwYjNKSlpGUjVjR1VzSUc1bVpFRndjRWxFT2lCMWFXNTBOalFzSUc1bVpFNWhiV1U2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPak13TXdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdVkyOXVabWxuTG05M2JtVnlMbUo1ZEdWektRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIWmhiR2xrWVhSdmNreHBjM1FnUFNCQ2IzaE5ZWEE4Vm1Gc2FXUmhkRzl5U1dSVWVYQmxMQ0JXWVd4cFpHRjBiM0pKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNZbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjJJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvek1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9kbUZzYVdSaGRHOXlTV1FwTG5aaGJIVmxMbU52Ym1acFp5NXZkMjVsY2k1aWVYUmxjeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z01qWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaWGgwY21GamRDQTRJRE15Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYUnBYM1poYkdsa1lYUnZjbDl5WldkcGMzUnllUzkyWVd4cFpHRjBiM0pTWldkcGMzUnllUzVoYkdkdkxuUnpPak13TkFvZ0lDQWdMeThnZEdocGN5NTJZV3hwWkdGMGIzSk1hWE4wS0haaGJHbGtZWFJ2Y2tsa0tTNTJZV3gxWlM1amIyNW1hV2N1Ym1aa1JtOXlTVzVtYnlBOUlHNW1aRUZ3Y0VsRUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJocGJuUWdOeklnTHk4Z056SUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WMGFWOTJZV3hwWkdGMGIzSmZjbVZuYVhOMGNua3ZkbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZWbUZzYVdSaGRHOXlVbVZuYVhOMGNua3VZMmhoYm1kbFZtRnNhV1JoZEc5eVEyOXRiV2x6YzJsdmJrRmtaSEpsYzNNb2RtRnNhV1JoZEc5eVNXUTZJSFZwYm5RMk5Dd2dZMjl0YldsemMybHZia0ZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGphR0Z1WjJWV1lXeHBaR0YwYjNKRGIyMXRhWE56YVc5dVFXUmtjbVZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXdOd29nSUNBZ0x5OGdZMmhoYm1kbFZtRnNhV1JoZEc5eVEyOXRiV2x6YzJsdmJrRmtaSEpsYzNNb2RtRnNhV1JoZEc5eVNXUTZJRlpoYkdsa1lYUnZja2xrVkhsd1pTd2dZMjl0YldsemMybHZia0ZrWkhKbGMzTTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TURnS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMblpoYkhWbExtTnZibVpwWnk1dmQyNWxjaTVpZVhSbGN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QjJZV3hwWkdGMGIzSk1hWE4wSUQwZ1FtOTRUV0Z3UEZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU3dnVm1Gc2FXUmhkRzl5U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkMkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16QTRDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSFpoYkdsa1lYUnZja2xrS1M1MllXeDFaUzVqYjI1bWFXY3ViM2R1WlhJdVlubDBaWE1wQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklESTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1Y0ZEhKaFkzUWdPQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TURrS0lDQWdJQzh2SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdVkyOXVabWxuTG5aaGJHbGtZWFJ2Y2tOdmJXMXBjM05wYjI1QlpHUnlaWE56SUQwZ1kyOXRiV2x6YzJsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdNZ05pQXZMeUF4T1RJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWFJwWDNaaGJHbGtZWFJ2Y2w5eVpXZHBjM1J5ZVM5MllXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwV1lXeHBaR0YwYjNKU1pXZHBjM1J5ZVM1amFHRnVaMlZXWVd4cFpHRjBiM0pTWlhkaGNtUkpibVp2S0haaGJHbGtZWFJ2Y2tsa09pQjFhVzUwTmpRc0lFVnVkSEo1UjJGMGFXNW5WSGx3WlRvZ2RXbHVkRFkwTENCRmJuUnllVWRoZEdsdVowRmtaSEpsYzNNNklHSjVkR1Z6TENCRmJuUnllVWRoZEdsdVowRnpjMlYwY3pvZ1lubDBaWE1zSUVkaGRHbHVaMEZ6YzJWMFRXbHVRbUZzWVc1alpUb2dkV2x1ZERZMExDQlNaWGRoY21SUVpYSlFZWGx2ZFhRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1kyaGhibWRsVm1Gc2FXUmhkRzl5VW1WM1lYSmtTVzVtYnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXhNaTB6TVRrS0lDQWdJQzh2SUdOb1lXNW5aVlpoYkdsa1lYUnZjbEpsZDJGeVpFbHVabThvQ2lBZ0lDQXZMeUFnSUhaaGJHbGtZWFJ2Y2tsa09pQldZV3hwWkdGMGIzSkpaRlI1Y0dVc0NpQWdJQ0F2THlBZ0lFVnVkSEo1UjJGMGFXNW5WSGx3WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCRmJuUnllVWRoZEdsdVowRmtaSEpsYzNNNklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnUlc1MGNubEhZWFJwYm1kQmMzTmxkSE02SUVacGVHVmtRWEp5WVhrOGRXbHVkRFkwTENBMFBpd0tJQ0FnSUM4dklDQWdSMkYwYVc1blFYTnpaWFJOYVc1Q1lXeGhibU5sT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUZKbGQyRnlaRkJsY2xCaGVXOTFkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUEySURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXlNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMDlJSFJvYVhNdWRtRnNhV1JoZEc5eVRHbHpkQ2gyWVd4cFpHRjBiM0pKWkNrdWRtRnNkV1V1WTI5dVptbG5MbTkzYm1WeUxtSjVkR1Z6S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhaaGJHbGtZWFJ2Y2t4cGMzUWdQU0JDYjNoTllYQThWbUZzYVdSaGRHOXlTV1JVZVhCbExDQldZV3hwWkdGMGIzSkpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKM1luSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TWpBS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMblpoYkdsa1lYUnZja3hwYzNRb2RtRnNhV1JoZEc5eVNXUXBMblpoYkhWbExtTnZibVpwWnk1dmQyNWxjaTVpZVhSbGN5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTWpZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pYaDBjbUZqZENBNElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhScFgzWmhiR2xrWVhSdmNsOXlaV2RwYzNSeWVTOTJZV3hwWkdGMGIzSlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTXlNUW9nSUNBZ0x5OGdkR2hwY3k1MllXeHBaR0YwYjNKTWFYTjBLSFpoYkdsa1lYUnZja2xrS1M1MllXeDFaUzVqYjI1bWFXY3VaVzUwY25sSFlYUnBibWRVZVhCbElEMGdSVzUwY25sSFlYUnBibWRVZVhCbENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGd3SUM4dklEZ3dDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvek1qSUtJQ0FnSUM4dklIUm9hWE11ZG1Gc2FXUmhkRzl5VEdsemRDaDJZV3hwWkdGMGIzSkpaQ2t1ZG1Gc2RXVXVZMjl1Wm1sbkxtVnVkSEo1UjJGMGFXNW5RV1JrY21WemN5QTlJRVZ1ZEhKNVIyRjBhVzVuUVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURnNElDOHZJRGc0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TWpNS0lDQWdJQzh2SUhSb2FYTXVkbUZzYVdSaGRHOXlUR2x6ZENoMllXeHBaR0YwYjNKSlpDa3VkbUZzZFdVdVkyOXVabWxuTG1WdWRISjVSMkYwYVc1blFYTnpaWFJ6SUQwZ1kyeHZibVVvUlc1MGNubEhZWFJwYm1kQmMzTmxkSE1wQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01USXdJQzh2SURFeU1Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16STBDaUFnSUNBdkx5QjBhR2x6TG5aaGJHbGtZWFJ2Y2t4cGMzUW9kbUZzYVdSaGRHOXlTV1FwTG5aaGJIVmxMbU52Ym1acFp5NW5ZWFJwYm1kQmMzTmxkRTFwYmtKaGJHRnVZMlVnUFNCSFlYUnBibWRCYzNObGRFMXBia0poYkdGdVkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRVeUlDOHZJREUxTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGRHbGZkbUZzYVdSaGRHOXlYM0psWjJsemRISjVMM1poYkdsa1lYUnZjbEpsWjJsemRISjVMbUZzWjI4dWRITTZNekkxQ2lBZ0lDQXZMeUIwYUdsekxuWmhiR2xrWVhSdmNreHBjM1FvZG1Gc2FXUmhkRzl5U1dRcExuWmhiSFZsTG1OdmJtWnBaeTV5WlhkaGNtUlFaWEpRWVhsdmRYUWdQU0JTWlhkaGNtUlFaWEpRWVhsdmRYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHbHVkQ0F4TmpnZ0x5OGdNVFk0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxkR2xmZG1Gc2FXUmhkRzl5WDNKbFoybHpkSEo1TDNaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2xaaGJHbGtZWFJ2Y2xKbFoybHpkSEo1TG5ObGRGUnZhMlZ1VUdGNWIzVjBVbUYwYVc4b2RtRnNhV1JoZEc5eVNXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbk5sZEZSdmEyVnVVR0Y1YjNWMFVtRjBhVzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVYwYVY5MllXeHBaR0YwYjNKZmNtVm5hWE4wY25rdmRtRnNhV1JoZEc5eVVtVm5hWE4wY25rdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklITmxkRlJ2YTJWdVVHRjViM1YwVW1GMGFXOG9kbUZzYVdSaGRHOXlTV1E2SUZaaGJHbGtZWFJ2Y2tsa1ZIbHdaU2s2SUZCdmIyeFViMnRsYmxCaGVXOTFkRkpoZEdsdklIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16UTJDaUFnSUNBdkx5QndiMjlzVUdOMFQyWlhhRzlzWlRvZ2JtVjNJRVpwZUdWa1FYSnlZWGs4ZFdsdWREWTBMQ0F5TkQ0b0tTd0tJQ0FnSUdsdWRHTWdOaUF2THlBeE9USUtJQ0FnSUdKNlpYSnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVjBhVjkyWVd4cFpHRjBiM0pmY21WbmFYTjBjbmt2ZG1Gc2FXUmhkRzl5VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TkRjS0lDQWdJQzh2SUhWd1pHRjBaV1JHYjNKUVlYbHZkWFE2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psZEdsZmRtRnNhV1JoZEc5eVgzSmxaMmx6ZEhKNUwzWmhiR2xrWVhSdmNsSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16UTFMVE0wT0FvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnY0c5dmJGQmpkRTltVjJodmJHVTZJRzVsZHlCR2FYaGxaRUZ5Y21GNVBIVnBiblEyTkN3Z01qUStLQ2tzQ2lBZ0lDQXZMeUFnSUhWd1pHRjBaV1JHYjNKUVlYbHZkWFE2SURBc0NpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFJQVFDSUFoaW9Bc0FFd0FIQWhEMG1DUUYyQkJVZmZIVUVhVzVwZEFSdWRXMVdBZ0FBREJVZmZIVUFBQUFBQUFBQUFCd1ZIM3gxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFHWEJ2YjJ4VVpXMXdiR0YwWlVGd2NISnZkbUZzUW5sMFpYTURjM0J6TVJ0QkFQeUNJd1JHOTJVekJMaEVlellFRzE2Q3hnUjVSeTJEQkY5Nno5a0VNWExLblFTS2h4UXRCTkUyYk1NRU93UmNYQVE3cTF3aUJKcDhJa2dFTDZJc1N3UjNLbjNrQkZjblo5RUVORlNGdVFUN3hqRjRCQ1JKalBRRStFYmRlZ1NEQlFVQkJIdTdiSTBFK0RsQlNnUVIxemYvQkQ0b2lYSUUzVitxMmdUZFE5ZS9CUG1lOVUwRXYzL0g0d1E3aUp1RUJMRnJPMEFFVGZqWWJnUkJqODc4QktMY1ViVUVLSFAxQkFRRlIvVCtCTXRtZzFnMkdnQ09Jd0x2QXVJQzBnSzhBckFDcHdKM0FnOEIvZ0hxQWRZQndnR3VBWlVCZ2dGdEFWTUJRQUVzQVJnQkRBRDFBT0lBeWdDekFLQUFmZ0J5QUdZQVVnQkpBRUFBRndBT0FBSWpRekVaRkVReEdFUW5CYkFpUXpFWkZFUXhHRVFpUXpFWkZFUXhHRVNBSFJVZmZIVUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQXNDSkRNUmtVUkRFWVJDSkRNUmtVUkRFWVJDSkRNUmtVUkRFWVJEWWFBUmVJQmZvcFRGQ3dJa014R1JSRU1SaEVKd2F3SWtNeEdSUkVNUmhFSndhd0lrTXhHUlJFTVJoRU5ob0JGellhQWhjMkdnTTJHZ1EyR2dVWE5ob0dGNGdGZWlKRE1Sa1VSREVZUkRZYUFSYzJHZ0tJQlVraVF6RVpGRVF4R0VRMkdnRVhOaG9DRnpZYUE0Z0ZFaUpETVJrVVJERVlSRFlhQVJjMkdnSVhOaG9ERjRnRXppSkRNUmtVUkRFWVJEWWFBUmMyR2dLSUJKMGlRekVaRkVReEdFUTJHZ0UyR2dLSUEva1dLVXhRc0NKRE1Sa1VSREVZUkNjRnNDSkRNUmtVUkRFWVJEWWFBUmVJQThFcFRGQ3dJa014R1JSRU1SaEVOaG9CRjRnRG1pbE1VTEFpUXpFWkZFUXhHRVEyR2dHSUF4NHBURkN3SWtNeEdSUkVNUmhFTmhvQmlBTCtnQUVBSTA4Q1ZDbE1VTEFpUXpFWkZFUXhHRVEyR2dFWGlBS2ZGaWxNVUxBaVF6RVpGRVF4R0VRMkdnR0lBbTBwVEZDd0lrTXhHUlJFTVJoRU5ob0JGellhQWhlSUFoNFdLVXhRc0NKRE1Sa1VSREVZUkRZYUFSZUlBYndwVEZDd0lrTXhHUlJFTVJoRU5ob0JGNGdCa0NsTVVMQWlRekVaRkVReEdFUTJHZ0VYaUFGc0tVeFFzQ0pETVJrVVJERVlSRFlhQVJlSUFVa3BURkN3SWtNeEdSUkVNUmhFaUFFMEZpbE1VTEFpUXpFWkZFUXhHRVNBWEJVZmZIVUFBQUFBQUFBQUFRQUFBQUFBRDBKQUFBQUFBQUFBQUFBQUFBQUFBQTlDUUFBQUFBQUFEMEpBQUFBL3FpVWlZQUFBQVJEWk1XN0FBQUFBdGVZZzlJQUFBQUFBQUFBQUFBZ0FBQUFBQUFBQUF3QUFBQUFBQUFESXNDSkRNUmtVUkRFWVJJQWtGUjk4ZFFBQUFBQUFCakpVQUFBQUFBQVRtNGdBQUFBQUJNWlBWQUFBQUFBQUFTRjBzQ0pETVJrVVJERVlSQ0pETVJrVVJERVlSSWdBZmlKRE1Sa1VSREVZUkRZYUFSYzJHZ0pYQWdDSUFGNGlRekVaRkVReEdFUTJHZ0VYaUFCRUlrTXhHUlJFTVJnVVJJZ0FHQ0pETVJtQkJCSkVNUmhFaUFBQ0lrTW5CN3hJS2lObmlTb2paeXNqWjRBS2JuVnRVM1JoYTJWeWN5Tm5nQVp6ZEdGclpXUWpaNG1LQVFBbkI0di91VWlKaWdJQUl5cGxSQlJFaVNvaVo0a2pLMlZFaVlvQkFZdi9GaWhNVUw1RUl5UllpWW9CQVl2L0ZpaE1VTDVFSklFZ1dJbUtBUUdML3hZb1RGQytSQ01rV0VsWENDQk1WeWdnVUltS0FRRWpKd1NML3hZb1RGQytSQ0VFSVFWWUk0c0RKUXhCQUMyTEF5VUxpd0pNSlZoSmpBQWpXMEVBSElzQlNZc0FVRXdqV1NJSUZsY0dBbHdBakFHTEF5SUlqQU5DLzh5TEFZd0FpWW9DQVl2L1FRQXJpLzRXS0V4UXZVVUJSSXYvSlE1QkFCb2lSSXYrRmloTVVMNUVJUVFoQlZpTC95SUpKUXNsV0NOYmlTTkMvK09LQVFHTC95TmJGaWhNVUw1RUlRUWhCVmlMLzRFSVd5SUpKUXNsV0ltS0FRR0FBSXYvRmloTVVMNUVTU1NCSUZnalc0R0FnTHVMazV0RVRBcE1JeVJZZ2VnQlcwbEFBQXFCZ01DSnFhTDFENHdDaXdKSmpBQ0xBUTFCQUFTTEFZd0FpWW9CQVNjSWkvOVF2VVVCRkltS0FRRWpSd09BQUNjSWkvOVFTYjFGQVVBQUJTY0VqQUNKSndTTUFvc0Z2a3lNQVVRampBU0xCSUVHREVFQU5Zc0VKUXVMQVV3bFdFbU1BQ05iaXdLTUEwRUFFNHNDU1lzQVVFd2pXU0lJRmxjR0Fsd0FqQU9MQTR3Q2l3UWlDSXdFUXYvRGl3S01BSW1LQVFHTC94WW9URkMrUklNQzZBYklBVmlKaWdFQmkvOFdLRXhRU2IxRkFVUytTSUd3Q0NFR1dJbUtBZ0dBQUVtTC80RlFXNEVFRGtFQWZTSkVpLytCc0FGYlNZd0FRUUJyaXdBaEJ3NUJBR01pUkl2L2diZ0JXeUVIRGtFQVVTSkVpLytCNEFGYklRY1BSSXYvZ2ZBQlcwbU1BVUVBTllzQmdRTU9RUUF0SWtReEFJdi9Wd2dnRWtRaksyVkVJZ2dyU3dGblNSWW9Td0ZRU1lId0NibElTU09MLzdzalR3SzdqQUNKSTBMLzBDTkMvNndqUXYrYUkwTC9nSW9DQURFQWkvNFdLRXhRU2I1RUl5UllWd2dnVHdJU1JJRW9pLys3aVlvREFERUFpLzBXS0V4UVNiNUVJeVJZVndnZ1R3SVNSSXYrRmtzQmdmZ0JUd0s3aS84V2dZQUNUTHVKaWdNQU1RQ0wvUllvVEZCSnZrUWpKRmhYQ0NCUEFoSkVpLzRXZ1VoTXU0bUtBZ0F4QUl2K0ZpaE1VRW0rUkNNa1dGY0lJRThDRWtRaEJvdi91NG1LQmdBeEFJdjZGaWhNVUVtK1JDTWtXRmNJSUU4Q0VrU0wreFpMQVlGUVR3SzdTWUZZaS95N1NZRjRpLzI3aS80V1N3R0JtQUZQQXJ1TC94YUJxQUZNdTRtS0FRRWhCcThqRmxDSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
