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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper7_dc3e29bc
{


    //
    // Helper contract 7 for PoolManager
    //
    public class PoolManager__Helper7Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper7Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ModifyLiquidityParams : AVMObjectType
            {
                public byte[] Owner { get; set; }

                public ulong TickLower { get; set; }

                public ulong TickUpper { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LiquidityDelta { get; set; }

                public ulong TickSpacing { get; set; }

                public byte[] Salt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickLower.From(TickLower);
                    ret.AddRange(vTickLower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickUpper.From(TickUpper);
                    ret.AddRange(vTickUpper.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidityDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidityDelta.From(LiquidityDelta);
                    ret.AddRange(vLiquidityDelta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickSpacing.From(TickSpacing);
                    ret.AddRange(vTickSpacing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ModifyLiquidityParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ModifyLiquidityParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickLower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickLower = vTickLower.ToValue();
                    if (valueTickLower is ulong vTickLowerValue) { ret.TickLower = vTickLowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickUpper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickUpper = vTickUpper.ToValue();
                    if (valueTickUpper is ulong vTickUpperValue) { ret.TickUpper = vTickUpperValue; }
                    var vLiquidityDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidityDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LiquidityDelta = vLiquidityDelta;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickSpacing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickSpacing = vTickSpacing.ToValue();
                    if (valueTickSpacing is ulong vTickSpacingValue) { ret.TickSpacing = vTickSpacingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ModifyLiquidityParams);
                }
                public bool Equals(ModifyLiquidityParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ModifyLiquidityParams left, ModifyLiquidityParams right)
                {
                    return EqualityComparer<ModifyLiquidityParams>.Default.Equals(left, right);
                }
                public static bool operator !=(ModifyLiquidityParams left, ModifyLiquidityParams right)
                {
                    return !(left == right);
                }

            }

            public class ModifyLiquidityState : AVMObjectType
            {
                public byte FlippedLower { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LiquidityGrossAfterLower { get; set; }

                public byte FlippedUpper { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LiquidityGrossAfterUpper { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlippedLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vFlippedLower.From(FlippedLower);
                    ret.AddRange(vFlippedLower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidityGrossAfterLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidityGrossAfterLower.From(LiquidityGrossAfterLower);
                    ret.AddRange(vLiquidityGrossAfterLower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlippedUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vFlippedUpper.From(FlippedUpper);
                    ret.AddRange(vFlippedUpper.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidityGrossAfterUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidityGrossAfterUpper.From(LiquidityGrossAfterUpper);
                    ret.AddRange(vLiquidityGrossAfterUpper.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ModifyLiquidityState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ModifyLiquidityState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlippedLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vFlippedLower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlippedLower = vFlippedLower.ToValue();
                    if (valueFlippedLower is byte vFlippedLowerValue) { ret.FlippedLower = vFlippedLowerValue; }
                    var vLiquidityGrossAfterLower = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidityGrossAfterLower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LiquidityGrossAfterLower = vLiquidityGrossAfterLower;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlippedUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vFlippedUpper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlippedUpper = vFlippedUpper.ToValue();
                    if (valueFlippedUpper is byte vFlippedUpperValue) { ret.FlippedUpper = vFlippedUpperValue; }
                    var vLiquidityGrossAfterUpper = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidityGrossAfterUpper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LiquidityGrossAfterUpper = vLiquidityGrossAfterUpper;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ModifyLiquidityState);
                }
                public bool Equals(ModifyLiquidityState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ModifyLiquidityState left, ModifyLiquidityState right)
                {
                    return EqualityComparer<ModifyLiquidityState>.Default.Equals(left, right);
                }
                public static bool operator !=(ModifyLiquidityState left, ModifyLiquidityState right)
                {
                    return !(left == right);
                }

            }

            public class State : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Liquidity { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeGrowthInside0LastX128 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeGrowthInside1LastX128 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidity.From(Liquidity);
                    ret.AddRange(vLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeGrowthInside0LastX128 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeGrowthInside0LastX128.From(FeeGrowthInside0LastX128);
                    ret.AddRange(vFeeGrowthInside0LastX128.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeGrowthInside1LastX128 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeGrowthInside1LastX128.From(FeeGrowthInside1LastX128);
                    ret.AddRange(vFeeGrowthInside1LastX128.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static State Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new State();
                    uint count = 0;
                    var vLiquidity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Liquidity = vLiquidity;
                    var vFeeGrowthInside0LastX128 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeGrowthInside0LastX128.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeGrowthInside0LastX128 = vFeeGrowthInside0LastX128;
                    var vFeeGrowthInside1LastX128 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeGrowthInside1LastX128.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeGrowthInside1LastX128 = vFeeGrowthInside1LastX128;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as State);
                }
                public bool Equals(State? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(State left, State right)
                {
                    return EqualityComparer<State>.Default.Equals(left, right);
                }
                public static bool operator !=(State left, State right)
                {
                    return !(left == right);
                }

            }

            public class PoolModifyLiquidityChunk3Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolModifyLiquidityChunk3Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolModifyLiquidityChunk3Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolModifyLiquidityChunk3Return);
                }
                public bool Equals(PoolModifyLiquidityChunk3Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolModifyLiquidityChunk3Return left, PoolModifyLiquidityChunk3Return right)
                {
                    return EqualityComparer<PoolModifyLiquidityChunk3Return>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolModifyLiquidityChunk3Return left, PoolModifyLiquidityChunk3Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="self"> State</param>
        /// <param name="params"> ModifyLiquidityParams</param>
        /// <param name="delta"> </param>
        /// <param name="feeDelta"> </param>
        /// <param name="feeGrowthInside0X128"> </param>
        /// <param name="feeGrowthInside1X128"> </param>
        /// <param name="feesOwed0"> </param>
        /// <param name="liquidityDelta"> </param>
        /// <param name="position"> State</param>
        /// <param name="state"> ModifyLiquidityState</param>
        /// <param name="tickLower"> </param>
        /// <param name="tickUpper"> </param>
        public async Task<Structs.PoolModifyLiquidityChunk3Return> PoolModifyLiquidityChunk3(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeGrowthInside0X128, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeGrowthInside1X128, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feesOwed0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.State position, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 150, 191, 10 };
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);

            var result = await base.CallApp(new List<object> { abiHandle, self, @params, delta, feeDelta, feeGrowthInside0X128, feeGrowthInside1X128, feesOwed0, liquidityDelta, position, state, tickLowerAbi, tickUpperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolModifyLiquidityChunk3Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PoolModifyLiquidityChunk3_Transactions(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeGrowthInside0X128, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeGrowthInside1X128, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feesOwed0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.State position, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 150, 191, 10 };
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);

            return await base.MakeTransactionList(new List<object> { abiHandle, self, @params, delta, feeDelta, feeGrowthInside0X128, feeGrowthInside1X128, feesOwed0, liquidityDelta, position, state, tickLowerAbi, tickUpperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjciLCJkZXNjIjoiSGVscGVyIGNvbnRyYWN0IDcgZm9yIFBvb2xNYW5hZ2VyIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1vZGlmeUxpcXVpZGl0eVBhcmFtcyI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6InRpY2tMb3dlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWNrVXBwZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlxdWlkaXR5RGVsdGEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNhbHQiLCJ0eXBlIjoidWludDhbMzJdIn1dLCJNb2RpZnlMaXF1aWRpdHlTdGF0ZSI6W3sibmFtZSI6ImZsaXBwZWRMb3dlciIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImxpcXVpZGl0eUdyb3NzQWZ0ZXJMb3dlciIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmxpcHBlZFVwcGVyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGlxdWlkaXR5R3Jvc3NBZnRlclVwcGVyIiwidHlwZSI6InVpbnQyNTYifV0sIlN0YXRlIjpbeyJuYW1lIjoibGlxdWlkaXR5IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmZWVHcm93dGhJbnNpZGUwTGFzdFgxMjgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZlZUdyb3d0aEluc2lkZTFMYXN0WDEyOCIsInR5cGUiOiJ1aW50MjU2In1dLCJQb29sTW9kaWZ5TGlxdWlkaXR5Q2h1bmszUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiUG9vbC5tb2RpZnlMaXF1aWRpdHlfX2NodW5rXzMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NixieXRlW10sYnl0ZVtdLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJTdGF0ZSIsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDI1Nix1aW50NjQsdWludDhbMzJdKSIsInN0cnVjdCI6Ik1vZGlmeUxpcXVpZGl0eVBhcmFtcyIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWx0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZURlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlR3Jvd3RoSW5zaWRlMFgxMjgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVHcm93dGhJbnNpZGUxWDEyOCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZXNPd2VkMCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpcXVpZGl0eURlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiU3RhdGUiLCJuYW1lIjoicG9zaXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OCx1aW50MjU2LHVpbnQ4LHVpbnQyNTYpIiwic3RydWN0IjoiTW9kaWZ5TGlxdWlkaXR5U3RhdGUiLCJuYW1lIjoic3RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tMb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja1VwcGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBvb2xNb2RpZnlMaXF1aWRpdHlDaHVuazNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIyMV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDddLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyMl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxNV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgY2h1bmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDU0XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1Myw4NzYsODk4LDEyMDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgTW9kaWZ5TGlxdWlkaXR5UGFyYW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE1vZGlmeUxpcXVpZGl0eVN0YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTAzLDk2OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBTdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIwLDkyNyw5MzUsOTQzLDk1MSw5NjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTg2LDk5NSwxMTkwLDExOTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICh1aW50OFszMl0sdWludDI1Nix1aW50MjU2LHVpbnQyNTYsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNSBvZiAodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDYgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzksODYzLDg4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDEsNjcwLDcxNSwxMTMzLDExNDcsMTE1Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMyLDc4NF0sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjamN1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTXpJZ01DQXlJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ2dNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmlBaWJ5SWdNSGd3TVNBaWNDSWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1R2RXeHNUV0YwYUM1dGRXeEVhWFlvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6TENCa1pXNXZiV2x1WVhSdmNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncEdkV3hzVFdGMGFDNXRkV3hFYVhZNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaUtnb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaVBBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJR0o2SUVaMWJHeE5ZWFJvTG0xMWJFUnBkbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWk4S0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncEdkV3hzVFdGMGFDNXRkV3hFYVhaZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JpUGdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1JwWnlBeENpQWdJQ0JpTHdvZ0lDQWdabkpoYldWZlluVnllU0F0TVFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0l2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSXZDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0o4Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbDRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VEdseGRXbGthWFI1VFdGMGFDNWhaR1JFWld4MFlTaDRPaUJpZVhSbGN5d2dlVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BNYVhGMWFXUnBkSGxOWVhSb0xtRmtaRVJsYkhSaE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQk1hWEYxYVdScGRIbE5ZWFJvTG1Ga1pFUmxiSFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWZBb0tUR2x4ZFdsa2FYUjVUV0YwYUM1aFpHUkVaV3gwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUx3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjbVYyWlhKMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDa3hwY1hWcFpHbDBlVTFoZEdndVlXUmtSR1ZzZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpSUV4cGNYVnBaR2wwZVUxaGRHZ3VZV1JrUkdWc2RHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnd1WTJ4bFlYSlVhV05yS0hObGJHWTZJR0o1ZEdWekxDQjBhV05yT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwUWIyOXNMbU5zWldGeVZHbGphem9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUhCMWMyaGllWFJsY3lBaWRHbGphM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl6YVhScGIyNHVkWEJrWVhSbEtITmxiR1k2SUdKNWRHVnpMQ0JzYVhGMWFXUnBkSGxFWld4MFlUb2dZbmwwWlhNc0lHWmxaVWR5YjNkMGFFbHVjMmxrWlRCWU1USTRPaUJpZVhSbGN5d2dabVZsUjNKdmQzUm9TVzV6YVdSbE1WZ3hNamc2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTXNJR0o1ZEdWek9ncFFiM05wZEdsdmJpNTFjR1JoZEdVNkNpQWdJQ0J3Y205MGJ5QTBJRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVUc5emFYUnBiMjR1ZFhCa1lYUmxYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ1VHOXphWFJwYjI0dWRYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCRGRYTjBiMjFTWlhabGNuUXVjbVYyWlhKMFYybDBhQW9LVUc5emFYUnBiMjR1ZFhCa1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQkdkV3hzVFdGMGFDNXRkV3hFYVhZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJHZFd4c1RXRjBhQzV0ZFd4RWFYWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzAwQ2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnlaWFJ6ZFdJS0NsQnZjMmwwYVc5dUxuVndaR0YwWlY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpZV3hzYzNWaUlFeHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0VLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMDBDaUFnSUNCaUlGQnZjMmwwYVc5dUxuVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRGNLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VTJGbVpVTmhjM1F1ZEc5SmJuUXhNamdvTVNsZk1TaDRPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbE5oWm1WRFlYTjBMblJ2U1c1ME1USTRPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaVBqMEtJQ0FnSUdKNklGTmhabVZEWVhOMExuUnZTVzUwTVRJNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZMkZzYkhOMVlpQkRkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYUFvS1UyRm1aVU5oYzNRdWRHOUpiblF4TWpoZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VkRzlDWVd4aGJtTmxSR1ZzZEdFb1gyRnRiM1Z1ZERBNklHSjVkR1Z6TENCZllXMXZkVzUwTVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMGIwSmhiR0Z1WTJWRVpXeDBZVG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpWUtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnb01Ta29jMlZzWldOMGIzSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncERkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYURvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1pYSnlJQzh2SUhKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5Tnk1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFEZ0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRTFPVFppWmpCaElEQjRZVGsyWldZNU9Ea2dMeThnYldWMGFHOWtJQ0pRYjI5c0xtMXZaR2xtZVV4cGNYVnBaR2wwZVY5ZlkyaDFibXRmTXlnb2RXbHVkRGhiTXpKZExIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEdKNWRHVmJYU3hpZVhSbFcxMHNZbmwwWlZ0ZEtTd29kV2x1ZERoYk16SmRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkREkxTml4MWFXNTBOalFzZFdsdWREaGJNekpkS1N4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pd29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwT0N4MWFXNTBNalUyTEhWcGJuUTRMSFZwYm5ReU5UWXBMSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0pmWDJsdWFYUmZYeWgxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnVUc5dmJDNXRiMlJwWm5sTWFYRjFhV1JwZEhsZlgyTm9kVzVyWHpNZ1gxOXBibWwwWDE4S0lDQWdJR1Z5Y2dvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFEZzZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5Tnk1UWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk0xdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbEJ2YjJ3dWJXOWthV1o1VEdseGRXbGthWFI1WDE5amFIVnVhMTh6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNamdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UTTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEUWdiMllnS0hWcGJuUTRXek15WFN4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXdvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFhVzUwT0Z0ZEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UTTJDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TXpBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURVZ2IyWWdLSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1NrS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeE16SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEWWdiMllnS0hWcGJuUTRXek15WFN4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXdvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFhVzUwT0Z0ZEtTa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVTNSaGRHVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TWpBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRTF2WkdsbWVVeHBjWFZwWkdsMGVWQmhjbUZ0Y3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTVOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1UzUmhkR1VLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVFc5a2FXWjVUR2x4ZFdsa2FYUjVVM1JoZEdVS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlCUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk0xOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklGQnZiMnd1Ylc5a2FXWjVUR2x4ZFdsa2FYUjVYMTlqYUhWdWExOHpYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ3BRYjI5c0xtMXZaR2xtZVV4cGNYVnBaR2wwZVY5ZlkyaDFibXRmTTE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHTmhiR3h6ZFdJZ1VHOXphWFJwYjI0dWRYQmtZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaR2xuSURnS0lDQWdJR05oYkd4emRXSWdVMkZtWlVOaGMzUXVkRzlKYm5ReE1qZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1F1ZEc5SmJuUXhNamdLSUNBZ0lHTmhiR3h6ZFdJZ2RHOUNZV3hoYm1ObFJHVnNkR0VLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlQQW9nSUNBZ1lub2dVRzl2YkM1dGIyUnBabmxNYVhGMWFXUnBkSGxmWDJOb2RXNXJYek5mWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklGQnZiMnd1Ylc5a2FXWjVUR2x4ZFdsa2FYUjVYMTlqYUhWdWExOHpYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCUWIyOXNMbU5zWldGeVZHbGphd29nSUNBZ1luVnllU0F4TWdvS1VHOXZiQzV0YjJScFpubE1hWEYxYVdScGRIbGZYMk5vZFc1clh6TmZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTXpNZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk0xOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUZCdmIyd3VZMnhsWVhKVWFXTnJDaUFnSUNCd2IzQUtDbEJ2YjJ3dWJXOWthV1o1VEdseGRXbGthWFI1WDE5amFIVnVhMTh6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEk2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU55NWZYMmx1YVhSZlgxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmYVc1cGRGOWZPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJ5SUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5BaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqY3VZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUlBQUNDQ1lKSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNFUC8vLy8vLy8vLy8vLy8vLy8vLy8vOEJid0VCQVhBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFSQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUJDQW5hS0F3R0wvWXYrbzBjQ0tLcEpUd0tBSVAvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy9xa2tvb0VzQ29TaXFLS0JNVHdLa0tTY0ZUd0pOb1NpcVNVNENpLzlMQWFWRUl4YW9RUUFHaS8raWpBQ0ppd0NMLzZxTEFTaWdTd0ZQQTBsT0E2VXBKd1ZQQWsyaEtLcE1LS0JQQXFFb3FpaUwvNkVvcW92L3JJdi9Td0dpalA5TVN3R2lLRXNDb1NpcVR3S2lKd1dnS0twUEFxTW9xcXVCQXhhTC82TW9xaVFXcll2L1N3R2pLS29xVEtFb3FxTW9xb3YvU3dHaktLb3FUS0VvcXFNb3Fvdi9Td0dqS0tvcVRLRW9xcU1vcW92L1N3R2pLS29xVEtFb3FxTW9xb3YvU3dHaktLb3FUS0VvcXFNb3Fvdi9Td0dqS0tvcVRLRW9xcU1vcXFNb3Fvd0FpWW9DQVl2K0s2eUwvNEFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2lnQUVDcWltcFFRQTBpLytBSVAvLy8vLy8vLy8vLy8vLy8vLy8vLzhBQUFBQUFBQUFBQUFBQUFBQUFBQUFxNHNBb0NpcVNTY0hvaW1wRkVSTWlZdi9LNnhDLytxS0FnR0wveFlCZ0FWMGFXTnJjMHhRdkVpTC9vbUtCQU9ML0ZjQUlDTVdTWXY5cUVFQWNvc0Fpd0dvUVFBRUtZZ0F2WXYrS0tDTC9GY2dJS0VvcW9zQVNVNENKd2lJL2pXTC95aWdpL3hYUUNCTVN3R2hLS3BQQXljSWlQNGZpLzRWSWc1RUlxK0wva3NCcTR2OFZ3QWdURkJQQTFCSmpQeFhJQ0NML3hVaURrU0wvMDhDcTR2OFZ3QWdUd0pRVEZCSmpQeFBCRThFaVl2OFZ5QWdpL3hYUUNDTEFJdjlpUDduU1JVaURrUWlyNnRQQWxCTVVJejhRdjkzaWdFQmkvK0FFSUFBQUFBQUFBQUFBQUFBQUFBQUFBQ25RUUFFS1lnQUZZdi9LNnlKaWdJQmkvNG5CNk1vcWl1TC82eXJpWW9CQUFBeEcwRUFIVEVaRkVReEdFU0NBZ1NsbHI4S0JLbHUrWWsyR2dDT0FnQUpBVzBBTVJrVU1SZ1VFRU1qTmhvQlJ3SVZTd0dCZ0FGWlNZR0dBUkpFU3dKTVN3SlNJMW1CaUFFSVN3S0JnZ0ZaU1VzQ0VrUkxBMHhMQTFJaldTUUlDRXNDZ1lRQldVbExBaEpFVHdOTVN3TlNJMWtrQ0FnU1JEWWFBaFdCZUJKRU5ob0RTUlZKSWhKRU5ob0VGU0lTUkRZYUJVa1ZJaEpFTmhvR1NSVWlFa1EyR2dkSkZTSVNSRFlhQ0VrVlNTSVNSRFlhQ1VrVmdXQVNSRFlhQ2trVmdVSVNSRFlhQzBrVkpSSkVGellhREVrVkpSSkVGeWNFWkVFQU5ESUVKQTlFTXdBWUp3UmtFa1F6QUFBeEFCSkVKd1prUVFBYU1SYUJBUWs0R0NjR1pCSkVNUmFCQVFrNUdnQ0FBWE5rRWtSTEEwc0dTVTRDU3d0TEM0aitCa2hGQVVzSWlQNmtUSWorb0lqK3dVVU9JeGFrUVFBbFN3SlhBQUVwcVVFQUNVc0xTd0tJL2NsRkRFc0NWeUVCS2FsQkFBaExDMHNCaVAyMlNFc0pJZzVFSXE5TEMwc0JxMHNPU1JVaURrUkxBcXRRU3dZaURrUkxCMDhDcTFCTEFoWlFTd0VXVUlBRUZSOThkVXhRc0lFQlF6WWFBVWtWSlJKRUZ6WWFBa2tWSlJKRUZ6WWFBMGtqV1NRSVN3RVZFa1JYQWdBbkJHUVVSQ2NFVHdObkp3WlBBbWVBQVhOTVo0RUJRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
