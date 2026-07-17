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

namespace Arc56.Generated.YashDiwan_16.hackseries_3_0.PoolFactory_96f929e0
{


    public class PoolFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PoolMetadata : AVMObjectType
            {
                public byte[] Creator { get; set; }

                public ulong StablecoinAssetId { get; set; }

                public ulong TargetLiquidity { get; set; }

                public ulong MaxBorrowAmount { get; set; }

                public ulong BaseApyBps { get; set; }

                public ulong MaturityTimestamp { get; set; }

                public ulong RiskTier { get; set; }

                public ulong BackstopRequirementBps { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStablecoinAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStablecoinAssetId.From(StablecoinAssetId);
                    ret.AddRange(vStablecoinAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTargetLiquidity.From(TargetLiquidity);
                    ret.AddRange(vTargetLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxBorrowAmount.From(MaxBorrowAmount);
                    ret.AddRange(vMaxBorrowAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseApyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBaseApyBps.From(BaseApyBps);
                    ret.AddRange(vBaseApyBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaturityTimestamp.From(MaturityTimestamp);
                    ret.AddRange(vMaturityTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRiskTier.From(RiskTier);
                    ret.AddRange(vRiskTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackstopRequirementBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBackstopRequirementBps.From(BackstopRequirementBps);
                    ret.AddRange(vBackstopRequirementBps.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolMetadata Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolMetadata();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is byte[] vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStablecoinAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStablecoinAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStablecoinAssetId = vStablecoinAssetId.ToValue();
                    if (valueStablecoinAssetId is ulong vStablecoinAssetIdValue) { ret.StablecoinAssetId = vStablecoinAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTargetLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTargetLiquidity = vTargetLiquidity.ToValue();
                    if (valueTargetLiquidity is ulong vTargetLiquidityValue) { ret.TargetLiquidity = vTargetLiquidityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxBorrowAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxBorrowAmount = vMaxBorrowAmount.ToValue();
                    if (valueMaxBorrowAmount is ulong vMaxBorrowAmountValue) { ret.MaxBorrowAmount = vMaxBorrowAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseApyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaseApyBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseApyBps = vBaseApyBps.ToValue();
                    if (valueBaseApyBps is ulong vBaseApyBpsValue) { ret.BaseApyBps = vBaseApyBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaturityTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaturityTimestamp = vMaturityTimestamp.ToValue();
                    if (valueMaturityTimestamp is ulong vMaturityTimestampValue) { ret.MaturityTimestamp = vMaturityTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRiskTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiskTier = vRiskTier.ToValue();
                    if (valueRiskTier is ulong vRiskTierValue) { ret.RiskTier = vRiskTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackstopRequirementBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBackstopRequirementBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBackstopRequirementBps = vBackstopRequirementBps.ToValue();
                    if (valueBackstopRequirementBps is ulong vBackstopRequirementBpsValue) { ret.BackstopRequirementBps = vBackstopRequirementBpsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolMetadata);
                }
                public bool Equals(PoolMetadata? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolMetadata left, PoolMetadata right)
                {
                    return EqualityComparer<PoolMetadata>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolMetadata left, PoolMetadata right)
                {
                    return !(left == right);
                }

            }

            public class PoolParams : AVMObjectType
            {
                public ulong StablecoinAssetId { get; set; }

                public ulong TargetLiquidity { get; set; }

                public ulong MaxBorrowAmount { get; set; }

                public ulong BaseApyBps { get; set; }

                public ulong MaturityTimestamp { get; set; }

                public ulong RiskTier { get; set; }

                public ulong BackstopRequirementBps { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStablecoinAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStablecoinAssetId.From(StablecoinAssetId);
                    ret.AddRange(vStablecoinAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTargetLiquidity.From(TargetLiquidity);
                    ret.AddRange(vTargetLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxBorrowAmount.From(MaxBorrowAmount);
                    ret.AddRange(vMaxBorrowAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseApyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBaseApyBps.From(BaseApyBps);
                    ret.AddRange(vBaseApyBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaturityTimestamp.From(MaturityTimestamp);
                    ret.AddRange(vMaturityTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRiskTier.From(RiskTier);
                    ret.AddRange(vRiskTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackstopRequirementBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBackstopRequirementBps.From(BackstopRequirementBps);
                    ret.AddRange(vBackstopRequirementBps.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStablecoinAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStablecoinAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStablecoinAssetId = vStablecoinAssetId.ToValue();
                    if (valueStablecoinAssetId is ulong vStablecoinAssetIdValue) { ret.StablecoinAssetId = vStablecoinAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTargetLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTargetLiquidity = vTargetLiquidity.ToValue();
                    if (valueTargetLiquidity is ulong vTargetLiquidityValue) { ret.TargetLiquidity = vTargetLiquidityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxBorrowAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxBorrowAmount = vMaxBorrowAmount.ToValue();
                    if (valueMaxBorrowAmount is ulong vMaxBorrowAmountValue) { ret.MaxBorrowAmount = vMaxBorrowAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseApyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaseApyBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseApyBps = vBaseApyBps.ToValue();
                    if (valueBaseApyBps is ulong vBaseApyBpsValue) { ret.BaseApyBps = vBaseApyBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaturityTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaturityTimestamp = vMaturityTimestamp.ToValue();
                    if (valueMaturityTimestamp is ulong vMaturityTimestampValue) { ret.MaturityTimestamp = vMaturityTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRiskTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiskTier = vRiskTier.ToValue();
                    if (valueRiskTier is ulong vRiskTierValue) { ret.RiskTier = vRiskTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackstopRequirementBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBackstopRequirementBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBackstopRequirementBps = vBackstopRequirementBps.ToValue();
                    if (valueBackstopRequirementBps is ulong vBackstopRequirementBpsValue) { ret.BackstopRequirementBps = vBackstopRequirementBpsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolParams);
                }
                public bool Equals(PoolParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolParams left, PoolParams right)
                {
                    return EqualityComparer<PoolParams>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolParams left, PoolParams right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class PoolCreatorUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 230, 158, 134, 216 };
                public const string Signature = "PoolCreatorUpdated(byte[32],bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field0 { get; set; }
                public bool Field1 { get; set; }

                public static PoolCreatorUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PoolCreatorUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class PoolCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 204, 83, 29, 48 };
                public const string Signature = "PoolCreated(uint64,byte[32],uint64,uint64,uint64,uint64,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong PoolId { get; set; }
                public byte[] Creator { get; set; }
                public ulong StablecoinAssetId { get; set; }
                public ulong TargetLiquidity { get; set; }
                public ulong MaxBorrowAmount { get; set; }
                public ulong BaseApyBps { get; set; }
                public ulong MaturityTimestamp { get; set; }
                public ulong RiskTier { get; set; }
                public ulong BackstopRequirementBps { get; set; }

                public static PoolCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PoolCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolId = vPoolId.ToValue();
                    if (valuePoolId is ulong vPoolIdValue) { ret.PoolId = vPoolIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is byte[] vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStablecoinAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStablecoinAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStablecoinAssetId = vStablecoinAssetId.ToValue();
                    if (valueStablecoinAssetId is ulong vStablecoinAssetIdValue) { ret.StablecoinAssetId = vStablecoinAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTargetLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTargetLiquidity = vTargetLiquidity.ToValue();
                    if (valueTargetLiquidity is ulong vTargetLiquidityValue) { ret.TargetLiquidity = vTargetLiquidityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxBorrowAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxBorrowAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxBorrowAmount = vMaxBorrowAmount.ToValue();
                    if (valueMaxBorrowAmount is ulong vMaxBorrowAmountValue) { ret.MaxBorrowAmount = vMaxBorrowAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseApyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaseApyBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseApyBps = vBaseApyBps.ToValue();
                    if (valueBaseApyBps is ulong vBaseApyBpsValue) { ret.BaseApyBps = vBaseApyBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaturityTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaturityTimestamp = vMaturityTimestamp.ToValue();
                    if (valueMaturityTimestamp is ulong vMaturityTimestampValue) { ret.MaturityTimestamp = vMaturityTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRiskTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiskTier = vRiskTier.ToValue();
                    if (valueRiskTier is ulong vRiskTierValue) { ret.RiskTier = vRiskTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackstopRequirementBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBackstopRequirementBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBackstopRequirementBps = vBackstopRequirementBps.ToValue();
                    if (valueBackstopRequirementBps is ulong vBackstopRequirementBpsValue) { ret.BackstopRequirementBps = vBackstopRequirementBpsValue; }
                    return ret;

                }

            }

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
        /// <param name="paused"> </param>
        public async Task SetPaused(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 55, 239, 189 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            var result = await base.CallApp(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPaused_Transactions(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 55, 239, 189 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            return await base.MakeTransactionList(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="creator"> </param>
        /// <param name="approved"> </param>
        public async Task SetPoolCreator(Algorand.Address creator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 252, 103, 94 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, creatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPoolCreator_Transactions(Algorand.Address creator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 252, 103, 94 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stablecoinAssetId"> </param>
        /// <param name="targetLiquidity"> </param>
        /// <param name="maxBorrowAmount"> </param>
        /// <param name="baseApyBps"> </param>
        /// <param name="maturityTimestamp"> </param>
        /// <param name="riskTier"> </param>
        /// <param name="backstopRequirementBps"> </param>
        public async Task<ulong> CreatePool(ulong stablecoinAssetId, ulong targetLiquidity, ulong maxBorrowAmount, ulong baseApyBps, ulong maturityTimestamp, ulong riskTier, ulong backstopRequirementBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 155, 159, 182 };
            var stablecoinAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoinAssetIdAbi.From(stablecoinAssetId);
            var targetLiquidityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetLiquidityAbi.From(targetLiquidity);
            var maxBorrowAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxBorrowAmountAbi.From(maxBorrowAmount);
            var baseApyBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); baseApyBpsAbi.From(baseApyBps);
            var maturityTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityTimestampAbi.From(maturityTimestamp);
            var riskTierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskTierAbi.From(riskTier);
            var backstopRequirementBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); backstopRequirementBpsAbi.From(backstopRequirementBps);

            var result = await base.CallApp(new List<object> { abiHandle, stablecoinAssetIdAbi, targetLiquidityAbi, maxBorrowAmountAbi, baseApyBpsAbi, maturityTimestampAbi, riskTierAbi, backstopRequirementBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePool_Transactions(ulong stablecoinAssetId, ulong targetLiquidity, ulong maxBorrowAmount, ulong baseApyBps, ulong maturityTimestamp, ulong riskTier, ulong backstopRequirementBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 155, 159, 182 };
            var stablecoinAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stablecoinAssetIdAbi.From(stablecoinAssetId);
            var targetLiquidityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetLiquidityAbi.From(targetLiquidity);
            var maxBorrowAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxBorrowAmountAbi.From(maxBorrowAmount);
            var baseApyBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); baseApyBpsAbi.From(baseApyBps);
            var maturityTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityTimestampAbi.From(maturityTimestamp);
            var riskTierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); riskTierAbi.From(riskTier);
            var backstopRequirementBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); backstopRequirementBpsAbi.From(backstopRequirementBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, stablecoinAssetIdAbi, targetLiquidityAbi, maxBorrowAmountAbi, baseApyBpsAbi, maturityTimestampAbi, riskTierAbi, backstopRequirementBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<Structs.PoolMetadata> GetPool(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 175, 127, 42 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            var result = await base.SimApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolMetadata.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPool_Transactions(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 175, 127, 42 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<bool> PoolExists(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 162, 83, 171 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            var result = await base.SimApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PoolExists_Transactions(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 162, 83, 171 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="creator"> </param>
        public async Task<bool> IsApprovedCreator(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 220, 133, 9 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            var result = await base.SimApp(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsApprovedCreator_Transactions(Algorand.Address creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 220, 133, 9 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbEZhY3RvcnkiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUG9vbE1ldGFkYXRhIjpbeyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InN0YWJsZWNvaW5Bc3NldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRhcmdldExpcXVpZGl0eSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhCb3Jyb3dBbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmFzZUFweUJwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXR1cml0eVRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyaXNrVGllciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYWNrc3RvcFJlcXVpcmVtZW50QnBzIiwidHlwZSI6InVpbnQ2NCJ9XSwiUG9vbFBhcmFtcyI6W3sibmFtZSI6InN0YWJsZWNvaW5Bc3NldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRhcmdldExpcXVpZGl0eSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhCb3Jyb3dBbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmFzZUFweUJwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXR1cml0eVRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyaXNrVGllciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYWNrc3RvcFJlcXVpcmVtZW50QnBzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdXNlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQb29sQ3JlYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQb29sQ3JlYXRvclVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVQb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZWNvaW5Bc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRMaXF1aWRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heEJvcnJvd0Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZUFweUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF0dXJpdHlUaW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tUaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYWNrc3RvcFJlcXVpcmVtZW50QnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBvb2xDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZWNvaW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0TGlxdWlkaXR5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4Qm9ycm93QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZUFweUJwcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5VGltZXN0YW1wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza1RpZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYWNrc3RvcFJlcXVpcmVtZW50QnBzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQb29sTWV0YWRhdGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBvb2xFeGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNBcHByb3ZlZENyZWF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU1Niw1NjAsNzQzXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MF0sImVycm9yTWVzc2FnZSI6ImJhY2tzdG9wIHJlcXVpcmVtZW50IGV4Y2VlZHMgbWF4IGJwcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NF0sImVycm9yTWVzc2FnZSI6ImJhY2tzdG9wIHJlcXVpcmVtZW50IGlzIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUzXSwiZXJyb3JNZXNzYWdlIjoiYmFzZSBBUFkgZXhjZWVkcyBtYXggYnBzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2XSwiZXJyb3JNZXNzYWdlIjoiYmFzZSBBUFkgaXMgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjAsMzc0LDQzMyw3MTYsNzYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIyXSwiZXJyb3JNZXNzYWdlIjoiZmFjdG9yeSBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzQsMjA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Myw2OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxLDI3MCwyNzksMjg4LDI5NywzMDYsMzE1LDUyMyw2NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHNpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTldLCJlcnJvck1lc3NhZ2UiOiJtYXR1cml0eSBtdXN0IGJlIGluIHRoZSBmdXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzddLCJlcnJvck1lc3NhZ2UiOiJtYXggYm9ycm93IGFtb3VudCBpcyByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0M10sImVycm9yTWVzc2FnZSI6Im1heCBib3Jyb3cgZXhjZWVkcyB0YXJnZXQgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzXSwiZXJyb3JNZXNzYWdlIjoicG9vbCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Ml0sImVycm9yTWVzc2FnZSI6InJpc2sgdGllciBpcyByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2NV0sImVycm9yTWVzc2FnZSI6InNlbmRlciBpcyBub3QgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjhdLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgaXMgbm90IGFuIGFwcHJvdmVkIHBvb2wgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6InN0YWJsZWNvaW4gYXNzZXQgaWQgaXMgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzRdLCJlcnJvck1lc3NhZ2UiOiJ0YXJnZXQgbGlxdWlkaXR5IGlzIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWlibVY0ZEZCdmIyeEpaQ0lnSW5CdmIyeERiM1Z1ZENJZ0luQmhkWE5sWkNJZ0ltRmtiV2x1SWlBaWNHOXZiRU55WldGMGIzSWlJQ0p3YjI5c0lpQWlZM0psWVhSdmNpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2JtVjRkRkJ2YjJ4SlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R1WlhoMFVHOXZiRWxrSnl3Z2FXNXBkR2xoYkZaaGJIVmxPaUJHU1ZKVFZGOVFUMDlNWDBsRUlIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnVaWGgwVUc5dmJFbGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEJ2YjJ4RGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkd2IyOXNRMjkxYm5RbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHOXZiRU52ZFc1MElnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHdZWFZ6WldRbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCdmIyeEdZV04wYjNKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5HVXpOMlZtWW1RZ01IZzVaR1pqTmpjMVpTQXdlRFU0T1dJNVptSTJJREI0TnpaaFpqZG1NbUVnTUhobU5XRXlOVE5oWWlBd2VHRXhaR000TlRBNUlDOHZJRzFsZEdodlpDQWljMlYwVUdGMWMyVmtLR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFVHOXZiRU55WldGMGIzSW9ZV1JrY21WemN5eGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpWQnZiMndvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBVRzl2YkNoMWFXNTBOalFwS0dKNWRHVmJNekpkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbkJ2YjJ4RmVHbHpkSE1vZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltbHpRWEJ3Y205MlpXUkRjbVZoZEc5eUtHRmtaSEpsYzNNcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRGQmhkWE5sWkNCelpYUlFiMjlzUTNKbFlYUnZjaUJqY21WaGRHVlFiMjlzSUdkbGRGQnZiMndnY0c5dmJFVjRhWE4wY3lCcGMwRndjSEp2ZG1Wa1EzSmxZWFJ2Y2dvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUc5dmJFWmhZM1J2Y25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUc5dmJFWmhZM1J2Y25rdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6d3pNajQrS0hzZ2EyVjVPaUFuWVdSdGFXNG5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCdmIyeEdZV04wYjNKNUxuTmxkRkJoZFhObFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZCaGRYTmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZCaGRYTmxaQ2h3WVhWelpXUTZJR0p2YjJ4bFlXNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSFJvYVhNdVlYTnpaWEowUVdSdGFXNG9LUW9nSUNBZ1kyRnNiSE4xWWlCaGMzTmxjblJCWkcxcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QndZWFZ6WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jR0YxYzJWa0p5d2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQmhkWE5sWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z2RHaHBjeTV3WVhWelpXUXVkbUZzZFdVZ1BTQndZWFZ6WldRZ1B5QlZhVzUwTmpRb01Ta2dPaUJWYVc1ME5qUW9NQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSUVlYVnpaV1FvY0dGMWMyVmtPaUJpYjI5c1pXRnVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiMjlzUm1GamRHOXllUzV6WlhSUWIyOXNRM0psWVhSdmNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZCdmIyeERjbVZoZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBVRzl2YkVOeVpXRjBiM0lvWTNKbFlYUnZjam9nUVdOamIzVnVkQ3dnWVhCd2NtOTJaV1E2SUdKdmIyeGxZVzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRUZrYldsdUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVhOelpYSjBRV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1lYQndjbTkyWldSRGNtVmhkRzl5Y3lBOUlFSnZlRTFoY0R4aWVYUmxjend6TWo0c0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqY21WaGRHOXlKeUI5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR2xtSUNoaGNIQnliM1psWkNrZ2V3b2dJQ0FnWW5vZ2MyVjBVRzl2YkVOeVpXRjBiM0pmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2tKdmVDNTJZV3gxWlNBOUlFRlFVRkpQVmtWRVgwTlNSVUZVVDFJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb0tjMlYwVUc5dmJFTnlaV0YwYjNKZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCbGJXbDBLQ2RRYjI5c1EzSmxZWFJ2Y2xWd1pHRjBaV1FuTENCamNtVmhkRzl5TG1KNWRHVnpMQ0JoY0hCeWIzWmxaQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobE5qbGxPRFprT0NBdkx5QnRaWFJvYjJRZ0lsQnZiMnhEY21WaGRHOXlWWEJrWVhSbFpDaGllWFJsV3pNeVhTeGliMjlzS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlFiMjlzUTNKbFlYUnZjaWhqY21WaGRHOXlPaUJCWTJOdmRXNTBMQ0JoY0hCeWIzWmxaRG9nWW05dmJHVmhiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFVHOXZiRU55WldGMGIzSmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUgwZ1pXeHpaU0JwWmlBb1kzSmxZWFJ2Y2tKdmVDNWxlR2x6ZEhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ6WlhSUWIyOXNRM0psWVhSdmNsOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2tKdmVDNWtaV3hsZEdVb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdJZ2MyVjBVRzl2YkVOeVpXRjBiM0pmWVdaMFpYSmZhV1pmWld4elpVQTJDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiMjlzUm1GamRHOXllUzVqY21WaGRHVlFiMjlzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsVUc5dmJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROaTA1TkFvZ0lDQWdMeThnY0hWaWJHbGpJR055WldGMFpWQnZiMndvQ2lBZ0lDQXZMeUFnSUhOMFlXSnNaV052YVc1QmMzTmxkRWxrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhSaGNtZGxkRXhwY1hWcFpHbDBlVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0WVhoQ2IzSnliM2RCYlc5MWJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZbUZ6WlVGd2VVSndjem9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0WVhSMWNtbDBlVlJwYldWemRHRnRjRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J5YVhOclZHbGxjam9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JpWVdOcmMzUnZjRkpsY1hWcGNtVnRaVzUwUW5Cek9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVWdQVDA5SUZWcGJuUTJOQ2d3S1N3Z0oyWmhZM1J2Y25rZ2FYTWdjR0YxYzJWa0p5a0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHdZWFZ6WldRbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXdZWFZ6WldRdWRtRnNkV1VnUFQwOUlGVnBiblEyTkNnd0tTd2dKMlpoWTNSdmNua2dhWE1nY0dGMWMyVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWm1GamRHOXllU0JwY3lCd1lYVnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFYTkJjSEJ5YjNabFpFTnlaV0YwYjNJb1ZIaHVMbk5sYm1SbGNpa3NJQ2R6Wlc1a1pYSWdhWE1nYm05MElHRnVJR0Z3Y0hKdmRtVmtJSEJ2YjJ3Z1kzSmxZWFJ2Y2ljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVRzl2YkVaaFkzUnZjbmt1YVhOQmNIQnliM1psWkVOeVpXRjBiM0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpaVzVrWlhJZ2FYTWdibTkwSUdGdUlHRndjSEp2ZG1Wa0lIQnZiMndnWTNKbFlYUnZjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TmdvZ0lDQWdMeThnWVhOelpYSjBLSE4wWVdKc1pXTnZhVzVCYzNObGRFbGtJRDRnVldsdWREWTBLREFwTENBbmMzUmhZbXhsWTI5cGJpQmhjM05sZENCcFpDQnBjeUJ5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdZWE56WlhKMElDOHZJSE4wWVdKc1pXTnZhVzRnWVhOelpYUWdhV1FnYVhNZ2NtVnhkV2x5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMFlYSm5aWFJNYVhGMWFXUnBkSGtnUGlCVmFXNTBOalFvTUNrc0lDZDBZWEpuWlhRZ2JHbHhkV2xrYVhSNUlHbHpJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUnBaeUExQ2lBZ0lDQmhjM05sY25RZ0x5OGdkR0Z5WjJWMElHeHBjWFZwWkdsMGVTQnBjeUJ5WlhGMWFYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0T0FvZ0lDQWdMeThnWVhOelpYSjBLRzFoZUVKdmNuSnZkMEZ0YjNWdWRDQStJRlZwYm5RMk5DZ3dLU3dnSjIxaGVDQmliM0p5YjNjZ1lXMXZkVzUwSUdseklISmxjWFZwY21Wa0p5a0tJQ0FnSUdScFp5QTBDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRjRJR0p2Y25KdmR5QmhiVzkxYm5RZ2FYTWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZWGhDYjNKeWIzZEJiVzkxYm5RZ1BEMGdkR0Z5WjJWMFRHbHhkV2xrYVhSNUxDQW5iV0Y0SUdKdmNuSnZkeUJsZUdObFpXUnpJSFJoY21kbGRDQnNhWEYxYVdScGRIa25LUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHMWhlQ0JpYjNKeWIzY2daWGhqWldWa2N5QjBZWEpuWlhRZ2JHbHhkV2xrYVhSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QmhjM05sY25Rb1ltRnpaVUZ3ZVVKd2N5QStJRlZwYm5RMk5DZ3dLU3dnSjJKaGMyVWdRVkJaSUdseklISmxjWFZwY21Wa0p5a0tJQ0FnSUdScFp5QXpDaUFnSUNCaGMzTmxjblFnTHk4Z1ltRnpaU0JCVUZrZ2FYTWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGlZWE5sUVhCNVFuQnpJRHc5SUUxQldGOUNVRk1zSUNkaVlYTmxJRUZRV1NCbGVHTmxaV1J6SUcxaGVDQmljSE1uS1FvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBZ0x5OGdNVEF3TURBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZbUZ6WlNCQlVGa2daWGhqWldWa2N5QnRZWGdnWW5CekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3lDaUFnSUNBdkx5QmhjM05sY25Rb2JXRjBkWEpwZEhsVWFXMWxjM1JoYlhBZ1BpQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3TENBbmJXRjBkWEpwZEhrZ2JYVnpkQ0JpWlNCcGJpQjBhR1VnWm5WMGRYSmxKeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRjBkWEpwZEhrZ2JYVnpkQ0JpWlNCcGJpQjBhR1VnWm5WMGRYSmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt6Q2lBZ0lDQXZMeUJoYzNObGNuUW9jbWx6YTFScFpYSWdQaUJWYVc1ME5qUW9NQ2tzSUNkeWFYTnJJSFJwWlhJZ2FYTWdjbVZ4ZFdseVpXUW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlhWE5ySUhScFpYSWdhWE1nY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2hpWVdOcmMzUnZjRkpsY1hWcGNtVnRaVzUwUW5CeklENGdWV2x1ZERZMEtEQXBMQ0FuWW1GamEzTjBiM0FnY21WeGRXbHlaVzFsYm5RZ2FYTWdjbVZ4ZFdseVpXUW5LUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1ltRmphM04wYjNBZ2NtVnhkV2x5WlcxbGJuUWdhWE1nY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUdGemMyVnlkQ2hpWVdOcmMzUnZjRkpsY1hWcGNtVnRaVzUwUW5CeklEdzlJRTFCV0Y5Q1VGTXNJQ2RpWVdOcmMzUnZjQ0J5WlhGMWFYSmxiV1Z1ZENCbGVHTmxaV1J6SUcxaGVDQmljSE1uS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3SUM4dklERXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHSmhZMnR6ZEc5d0lISmxjWFZwY21WdFpXNTBJR1Y0WTJWbFpITWdiV0Y0SUdKd2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdZMjl1YzNRZ2NHOXZiRWxrSUQwZ2RHaHBjeTV1WlhoMFVHOXZiRWxrTG5aaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QnVaWGgwVUc5dmJFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjI1bGVIUlFiMjlzU1dRbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUVaSlVsTlVYMUJQVDB4ZlNVUWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTVsZUhSUWIyOXNTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCamIyNXpkQ0J3YjI5c1NXUWdQU0IwYUdsekxtNWxlSFJRYjI5c1NXUXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNExURXhOZ29nSUNBZ0x5OGdZMjl1YzNRZ2NHRnlZVzF6T2lCUWIyOXNVR0Z5WVcxeklEMGdld29nSUNBZ0x5OGdJQ0J6ZEdGaWJHVmpiMmx1UVhOelpYUkpaQ3dLSUNBZ0lDOHZJQ0FnZEdGeVoyVjBUR2x4ZFdsa2FYUjVMQW9nSUNBZ0x5OGdJQ0J0WVhoQ2IzSnliM2RCYlc5MWJuUXNDaUFnSUNBdkx5QWdJR0poYzJWQmNIbENjSE1zQ2lBZ0lDQXZMeUFnSUcxaGRIVnlhWFI1VkdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnSUNCeWFYTnJWR2xsY2l3S0lDQWdJQzh2SUNBZ1ltRmphM04wYjNCU1pYRjFhWEpsYldWdWRFSndjeXdLSUNBZ0lDOHZJSDBLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Bb2dJQ0FnTHk4Z2RHaHBjeTV3YjI5c1EzSmxZWFJ2Y25Nb2NHOXZiRWxrS1M1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakVLSUNBZ0lDOHZJSEJ2YjJ4RGNtVmhkRzl5Y3lBOUlFSnZlRTFoY0R4MWFXNTBOalFzSUdKNWRHVnpQRE15UGo0b2V5QnJaWGxRY21WbWFYZzZJQ2R3YjI5c1EzSmxZWFJ2Y2ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQnZiMnhEY21WaGRHOXlJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Bb2dJQ0FnTHk4Z2RHaHBjeTV3YjI5c1EzSmxZWFJ2Y25Nb2NHOXZiRWxrS1M1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ3YjI5c1VHRnlZVzF6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVUc5dmJGQmhjbUZ0Y3o0b2V5QnJaWGxRY21WbWFYZzZJQ2R3YjI5c0p5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljRzl2YkNJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVGtLSUNBZ0lDOHZJSFJvYVhNdWNHOXZiRkJoY21GdGN5aHdiMjlzU1dRcExuWmhiSFZsSUQwZ1kyeHZibVVvY0dGeVlXMXpLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qQUtJQ0FnSUM4dklIUm9hWE11Ym1WNGRGQnZiMnhKWkM1MllXeDFaU0E5SUhCdmIyeEpaQ0FySUZWcGJuUTJOQ2d4S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCdVpYaDBVRzl2YkVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjVsZUhSUWIyOXNTV1FuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRVpKVWxOVVgxQlBUMHhmU1VRZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltNWxlSFJRYjI5c1NXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl3Q2lBZ0lDQXZMeUIwYUdsekxtNWxlSFJRYjI5c1NXUXVkbUZzZFdVZ1BTQndiMjlzU1dRZ0t5QlZhVzUwTmpRb01Ta0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUIwYUdsekxuQnZiMnhEYjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11Y0c5dmJFTnZkVzUwTG5aaGJIVmxJQ3NnVldsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJ3YjI5c1EyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmNHOXZiRU52ZFc1MEp5d2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQnZiMnhEYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJSFJvYVhNdWNHOXZiRU52ZFc1MExuWmhiSFZsSUQwZ2RHaHBjeTV3YjI5c1EyOTFiblF1ZG1Gc2RXVWdLeUJWYVc1ME5qUW9NU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2IyOXNRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jRzl2YkVOdmRXNTBKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ2YjJ4RGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpFS0lDQWdJQzh2SUhSb2FYTXVjRzl2YkVOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1d2IyOXNRMjkxYm5RdWRtRnNkV1VnS3lCVmFXNTBOalFvTVNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QmpjbVZoZEc5eU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5nb2dJQ0FnTHk4Z2MzUmhZbXhsWTI5cGJrRnpjMlYwU1dRNklIQmhjbUZ0Y3k1emRHRmliR1ZqYjJsdVFYTnpaWFJKWkN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU53b2dJQ0FnTHk4Z2RHRnlaMlYwVEdseGRXbGthWFI1T2lCd1lYSmhiWE11ZEdGeVoyVjBUR2x4ZFdsa2FYUjVMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk0Q2lBZ0lDQXZMeUJ0WVhoQ2IzSnliM2RCYlc5MWJuUTZJSEJoY21GdGN5NXRZWGhDYjNKeWIzZEJiVzkxYm5Rc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F4TmlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTVDaUFnSUNBdkx5QmlZWE5sUVhCNVFuQnpPaUJ3WVhKaGJYTXVZbUZ6WlVGd2VVSndjeXdLSUNBZ0lHUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElESTBJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpBS0lDQWdJQzh2SUcxaGRIVnlhWFI1VkdsdFpYTjBZVzF3T2lCd1lYSmhiWE11YldGMGRYSnBkSGxVYVcxbGMzUmhiWEFzQ2lBZ0lDQmthV2NnTmdvZ0lDQWdaWGgwY21GamRDQXpNaUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCeWFYTnJWR2xsY2pvZ2NHRnlZVzF6TG5KcGMydFVhV1Z5TEFvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdOREFnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek1nb2dJQ0FnTHk4Z1ltRmphM04wYjNCU1pYRjFhWEpsYldWdWRFSndjem9nY0dGeVlXMXpMbUpoWTJ0emRHOXdVbVZ4ZFdseVpXMWxiblJDY0hNc0NpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHVjRkSEpoWTNRZ05EZ2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TXkweE16TUtJQ0FnSUM4dklHTnZibk4wSUdWMlpXNTBPaUJRYjI5c1EzSmxZWFJsWkNBOUlIc0tJQ0FnSUM4dklDQWdjRzl2YkVsa0xBb2dJQ0FnTHk4Z0lDQmpjbVZoZEc5eU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQnpkR0ZpYkdWamIybHVRWE56WlhSSlpEb2djR0Z5WVcxekxuTjBZV0pzWldOdmFXNUJjM05sZEVsa0xBb2dJQ0FnTHk4Z0lDQjBZWEpuWlhSTWFYRjFhV1JwZEhrNklIQmhjbUZ0Y3k1MFlYSm5aWFJNYVhGMWFXUnBkSGtzQ2lBZ0lDQXZMeUFnSUcxaGVFSnZjbkp2ZDBGdGIzVnVkRG9nY0dGeVlXMXpMbTFoZUVKdmNuSnZkMEZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdZbUZ6WlVGd2VVSndjem9nY0dGeVlXMXpMbUpoYzJWQmNIbENjSE1zQ2lBZ0lDQXZMeUFnSUcxaGRIVnlhWFI1VkdsdFpYTjBZVzF3T2lCd1lYSmhiWE11YldGMGRYSnBkSGxVYVcxbGMzUmhiWEFzQ2lBZ0lDQXZMeUFnSUhKcGMydFVhV1Z5T2lCd1lYSmhiWE11Y21semExUnBaWElzQ2lBZ0lDQXZMeUFnSUdKaFkydHpkRzl3VW1WeGRXbHlaVzFsYm5SQ2NITTZJSEJoY21GdGN5NWlZV05yYzNSdmNGSmxjWFZwY21WdFpXNTBRbkJ6TEFvZ0lDQWdMeThnZlFvZ0lDQWdaR2xuSURnS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdWdGFYUThVRzl2YkVOeVpXRjBaV1ErS0dWMlpXNTBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZMk0xTXpGa016QWdMeThnYldWMGFHOWtJQ0pRYjI5c1EzSmxZWFJsWkNoMWFXNTBOalFzWW5sMFpWc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFl0T1RRS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVlFiMjlzS0FvZ0lDQWdMeThnSUNCemRHRmliR1ZqYjJsdVFYTnpaWFJKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMFlYSm5aWFJNYVhGMWFXUnBkSGs2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYldGNFFtOXljbTkzUVcxdmRXNTBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR0poYzJWQmNIbENjSE02SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYldGMGRYSnBkSGxVYVcxbGMzUmhiWEE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY21semExUnBaWEk2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWW1GamEzTjBiM0JTWlhGMWFYSmxiV1Z1ZEVKd2N6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnZiMnhHWVdOMGIzSjVMbWRsZEZCdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSUWIyOXNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1MweE5EQUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGQnZiMndvY0c5dmJFbGtPaUIxYVc1ME5qUXBPaUJRYjI5c1RXVjBZV1JoZEdFZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnWTI5dWMzUWdZM0psWVhSdmNrSnZlQ0E5SUhSb2FYTXVjRzl2YkVOeVpXRjBiM0p6S0hCdmIyeEpaQ2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY0c5dmJFTnlaV0YwYjNKeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1lubDBaWE04TXpJK1BpaDdJR3RsZVZCeVpXWnBlRG9nSjNCdmIyeERjbVZoZEc5eUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWljRzl2YkVOeVpXRjBiM0lpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ3YjI5c1VHRnlZVzF6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVUc5dmJGQmhjbUZ0Y3o0b2V5QnJaWGxRY21WbWFYZzZJQ2R3YjI5c0p5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljRzl2YkNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNd29nSUNBZ0x5OGdZWE56WlhKMEtHTnlaV0YwYjNKQ2IzZ3VaWGhwYzNSeklDWW1JSEJoY21GdGMwSnZlQzVsZUdsemRITXNJQ2R3YjI5c0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwVUc5dmJGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUlFiMjlzWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtZGxkRkJ2YjJ4ZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTXdvZ0lDQWdMeThnWVhOelpYSjBLR055WldGMGIzSkNiM2d1WlhocGMzUnpJQ1ltSUhCaGNtRnRjMEp2ZUM1bGVHbHpkSE1zSUNkd2IyOXNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdGemMyVnlkQ0F2THlCd2IyOXNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QmpiMjV6ZENCd1lYSmhiWE1nUFNCamJHOXVaU2h3WVhKaGJYTkNiM2d1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEzQ2lBZ0lDQXZMeUJqY21WaGRHOXlPaUJqYkc5dVpTaGpjbVZoZEc5eVFtOTRMblpoYkhWbEtTd0tJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnYzNSaFlteGxZMjlwYmtGemMyVjBTV1E2SUhCaGNtRnRjeTV6ZEdGaWJHVmpiMmx1UVhOelpYUkpaQ3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT1FvZ0lDQWdMeThnZEdGeVoyVjBUR2x4ZFdsa2FYUjVPaUJ3WVhKaGJYTXVkR0Z5WjJWMFRHbHhkV2xrYVhSNUxBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QnRZWGhDYjNKeWIzZEJiVzkxYm5RNklIQmhjbUZ0Y3k1dFlYaENiM0p5YjNkQmJXOTFiblFzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXhOaUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeENpQWdJQ0F2THlCaVlYTmxRWEI1UW5Cek9pQndZWEpoYlhNdVltRnpaVUZ3ZVVKd2N5d0tJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURJMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJRzFoZEhWeWFYUjVWR2x0WlhOMFlXMXdPaUJ3WVhKaGJYTXViV0YwZFhKcGRIbFVhVzFsYzNSaGJYQXNDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBek1pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUJ5YVhOclZHbGxjam9nY0dGeVlXMXpMbkpwYzJ0VWFXVnlMQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHVjRkSEpoWTNRZ05EQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkFvZ0lDQWdMeThnWW1GamEzTjBiM0JTWlhGMWFYSmxiV1Z1ZEVKd2N6b2djR0Z5WVcxekxtSmhZMnR6ZEc5d1VtVnhkV2x5WlcxbGJuUkNjSE1zQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdWNGRISmhZM1FnTkRnZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOaTB4TlRVS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUdOeVpXRjBiM0k2SUdOc2IyNWxLR055WldGMGIzSkNiM2d1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0J6ZEdGaWJHVmpiMmx1UVhOelpYUkpaRG9nY0dGeVlXMXpMbk4wWVdKc1pXTnZhVzVCYzNObGRFbGtMQW9nSUNBZ0x5OGdJQ0IwWVhKblpYUk1hWEYxYVdScGRIazZJSEJoY21GdGN5NTBZWEpuWlhSTWFYRjFhV1JwZEhrc0NpQWdJQ0F2THlBZ0lHMWhlRUp2Y25KdmQwRnRiM1Z1ZERvZ2NHRnlZVzF6TG0xaGVFSnZjbkp2ZDBGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWW1GelpVRndlVUp3Y3pvZ2NHRnlZVzF6TG1KaGMyVkJjSGxDY0hNc0NpQWdJQ0F2THlBZ0lHMWhkSFZ5YVhSNVZHbHRaWE4wWVcxd09pQndZWEpoYlhNdWJXRjBkWEpwZEhsVWFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBZ0lISnBjMnRVYVdWeU9pQndZWEpoYlhNdWNtbHphMVJwWlhJc0NpQWdJQ0F2THlBZ0lHSmhZMnR6ZEc5d1VtVnhkV2x5WlcxbGJuUkNjSE02SUhCaGNtRnRjeTVpWVdOcmMzUnZjRkpsY1hWcGNtVnRaVzUwUW5CekxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdjMmw2WlFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNemt0TVRRd0NpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSUWIyOXNLSEJ2YjJ4SlpEb2dkV2x1ZERZMEtUb2dVRzl2YkUxbGRHRmtZWFJoSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRkJ2YjJ4ZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ1oyVjBVRzl2YkY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnZiMnhHWVdOMGIzSjVMbkJ2YjJ4RmVHbHpkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2IyOXNSWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQzB4TlRrS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJSEJ2YjJ4RmVHbHpkSE1vY0c5dmJFbGtPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjI5c1gyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkJ2YjJ4RGNtVmhkRzl5Y3lod2IyOXNTV1FwTG1WNGFYTjBjeUFtSmlCMGFHbHpMbkJ2YjJ4UVlYSmhiWE1vY0c5dmJFbGtLUzVsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QndiMjlzUTNKbFlYUnZjbk1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JpZVhSbGN6d3pNajQrS0hzZ2EyVjVVSEpsWm1sNE9pQW5jRzl2YkVOeVpXRjBiM0luSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKd2IyOXNRM0psWVhSdmNpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTUFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWNHOXZiRU55WldGMGIzSnpLSEJ2YjJ4SlpDa3VaWGhwYzNSeklDWW1JSFJvYVhNdWNHOXZiRkJoY21GdGN5aHdiMjlzU1dRcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQndiMjlzUlhocGMzUnpYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCd2IyOXNVR0Z5WVcxeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1VHOXZiRkJoY21GdGN6NG9leUJyWlhsUWNtVm1hWGc2SUNkd2IyOXNKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0c5dmJDSUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpBS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuQnZiMnhEY21WaGRHOXljeWh3YjI5c1NXUXBMbVY0YVhOMGN5QW1KaUIwYUdsekxuQnZiMnhRWVhKaGJYTW9jRzl2YkVsa0tTNWxlR2x6ZEhNS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djRzl2YkVWNGFYTjBjMTlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwd2IyOXNSWGhwYzNSelgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRndE1UVTVDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCd2IyOXNSWGhwYzNSektIQnZiMnhKWkRvZ2RXbHVkRFkwS1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwd2IyOXNSWGhwYzNSelgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlIQnZiMnhGZUdsemRITmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYjI5c1JtRmpkRzl5ZVM1cGMwRndjSEp2ZG1Wa1EzSmxZWFJ2Y2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpRWEJ3Y205MlpXUkRjbVZoZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNeTB4TmpRS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR2x6UVhCd2NtOTJaV1JEY21WaGRHOXlLR055WldGMGIzSTZJRUZqWTI5MWJuUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5dmJGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnZiMnhHWVdOMGIzSjVMbWx6UVhCd2NtOTJaV1JEY21WaGRHOXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWIyOXNSbUZqZEc5eWVTNXBjMEZ3Y0hKdmRtVmtRM0psWVhSdmNpaGpjbVZoZEc5eU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ2YjJ4R1lXTjBiM0o1TG1selFYQndjbTkyWldSRGNtVmhkRzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk15MHhOalFLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHbHpRWEJ3Y205MlpXUkRjbVZoZEc5eUtHTnlaV0YwYjNJNklFRmpZMjkxYm5RcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpVS0lDQWdJQzh2SUdsbUlDaGpjbVZoZEc5eUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6d3pNajQrS0hzZ2EyVjVPaUFuWVdSdGFXNG5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOalVLSUNBZ0lDOHZJR2xtSUNoamNtVmhkRzl5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbUZrYldsdUxuWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lub2djMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiMnhmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYjI5c1JtRmpkRzl5ZVM1cGMwRndjSEp2ZG1Wa1EzSmxZWFJ2Y2w5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpZS0lDQWdJQzh2SUhKbGRIVnliaUIwY25WbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ2YjJ4R1lXTjBiM0o1TG1selFYQndjbTkyWldSRGNtVmhkRzl5WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhCd2NtOTJaV1JEY21WaGRHOXljeUE5SUVKdmVFMWhjRHhpZVhSbGN6d3pNajRzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGpjbVZoZEc5eUp5QjlLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnlaV0YwYjNKQ2IzZ3VaWGhwYzNSeklDWW1JR055WldGMGIzSkNiM2d1ZG1Gc2RXVWdQVDA5SUVGUVVGSlBWa1ZFWDBOU1JVRlVUMUlLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiMjlzUm1GamRHOXllUzVwYzBGd2NISnZkbVZrUTNKbFlYUnZjbDlpYjI5c1gyWmhiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXZiRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ2YjJ4R1lXTjBiM0o1TG1selFYQndjbTkyWldSRGNtVmhkRzl5WDJKdmIyeGZabUZzYzJWQU5Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NuTnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVRzl2YkVaaFkzUnZjbmt1YVhOQmNIQnliM1psWkVOeVpXRjBiM0pmWW05dmJGOXRaWEpuWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnlaV0YwYjNKQ2IzZ3VaWGhwYzNSeklDWW1JR055WldGMGIzSkNiM2d1ZG1Gc2RXVWdQVDA5SUVGUVVGSlBWa1ZFWDBOU1JVRlVUMUlLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmIyeGZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiMjlzUm1GamRHOXllUzVwYzBGd2NISnZkbVZrUTNKbFlYUnZjbDlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzl2YkY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCdmIyeEdZV04wYjNKNUxtbHpRWEJ3Y205MlpXUkRjbVZoZEc5eVgySnZiMnhmYldWeVoyVkFOZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyOXNYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVRzl2YkVaaFkzUnZjbmt1WVhOelpYSjBRV1J0YVc0b0tTQXRQaUIyYjJsa09ncGhjM05sY25SQlpHMXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMjlzWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbUZrYldsdUxuWmhiSFZsTENBbmMyVnVaR1Z5SUdseklHNXZkQ0JoWkcxcGJpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCaFpHMXBiaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UERNeVBqNG9leUJyWlhrNklDZGhaRzFwYmljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2YjJ4ZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0lDZHpaVzVrWlhJZ2FYTWdibTkwSUdGa2JXbHVKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhObGJtUmxjaUJwY3lCdWIzUWdZV1J0YVc0S0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJSUNZSUJCVWZmSFVLYm1WNGRGQnZiMnhKWkFsd2IyOXNRMjkxYm5RR2NHRjFjMlZrQldGa2JXbHVDM0J2YjJ4RGNtVmhkRzl5QkhCdmIyd0hZM0psWVhSdmNqRVlRQUFKS1NKbktpTm5LeU5uTVJrVVJERVlRUUF5Z2dZRVRqZnZ2UVNkL0dkZUJGaWJuN1lFZHE5L0tnVDFvbE9yQktIY2hRazJHZ0NPQmdBV0FDZ0FiUUZ6QWVrQ0d3Q0FCTGhFZXpZMkdnQ09BUUFCQUNjRU1RQm5Ja00yR2dGSkZTSVNSQ05UaUFKQksweG5Ja00yR2dGSEFoVWxFa1EyR2dKSlRnSkpGU0lTUkNOVGlBSWpKd2RQQWxCTVFRQVdJaFpMQVV5L1N3SkxBbENBQk9hZWh0aE1VTEFpUTBtOVJRRkIvK2xKdkVoQy8rTTJHZ0ZKRlNRU1JCYzJHZ0pKRlNRU1JCYzJHZ05KRlNRU1JCYzJHZ1JKRlNRU1JCYzJHZ1ZKRlNRU1JCYzJHZ1pKRlNRU1JCYzJHZ2RKRlNRU1JCY2pLMlZFRkVReEFJZ0JmRVJMQmtSTEJVUkxCRVJMQkVzR0RrUkxBMFJMQTRHUVRnNUVTd0l5QncxRVN3RkVTVVJKZ1pCT0RrUWpLV1ZFVHdjV1R3Y1dVRThHRmxCUEJSWlFUd1FXVUU4REZsQlBBaFpRTVFCTEFoWW5CVXNCVUU4Q3Z5Y0dTd0ZRU3dLL1R3SWlDQ2xNWnlNcVpVUWlDQ3BNWnpFQVN3SlhBQWhMQTFjSUNFc0VWeEFJU3dWWEdBaExCbGNnQ0VzSFZ5Z0lUd2hYTUFoTENFOElVRThIVUU4R1VFOEZVRThFVUU4RFVFOENVRXhRZ0FUTVV4MHdURkN3S0V4UXNDSkROaG9CU1JVa0VrUVhGaWNGU3dGUVNVOENKd1pNVUV5OVJRRkJBRlZKdlVVQlFRQk9Ja1JKdmtSTEFyNUVTd0ZYQUFoTEFsY0lDRXNEVnhBSVN3UlhHQWhMQlZjZ0NFc0dWeWdJVHdkWE1BaExCeFVsRWtSUEIwOEhVRThHVUU4RlVFOEVVRThEVUU4Q1VFeFFLRXhRc0NKREkwTC9yellhQVVrVkpCSkVGeFpKSndWTVVMMUZBVUVBR1NjR1N3RlF2VVVCUVFBT0lvQUJBQ05QQWxRb1RGQ3dJa01qUXYvdk5ob0JTUlVsRWtTSUFBMkFBUUFqVHdKVUtFeFFzQ0pEaWdFQkkwa25CR1ZFaS84U1FRQURJa3lKSndlTC8xQkpqQUM5UlFGQkFBMkxBTDVFRnlJU1FRQURJa3lKSTBMLytqRUFJeWNFWlVRU1JJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJQb29sQ3JlYXRvclVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBvb2xDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZWNvaW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0TGlxdWlkaXR5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4Qm9ycm93QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZUFweUJwcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5VGltZXN0YW1wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza1RpZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYWNrc3RvcFJlcXVpcmVtZW50QnBzIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
