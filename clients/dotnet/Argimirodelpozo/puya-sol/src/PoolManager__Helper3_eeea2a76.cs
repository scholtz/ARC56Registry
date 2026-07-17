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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper3_eeea2a76
{


    //
    // Helper contract 3 for PoolManager
    //
    public class PoolManager__Helper3Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper3Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
                public byte[] Slot0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeGrowthGlobal0X128 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeGrowthGlobal1X128 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Liquidity { get; set; }

                public byte[] Ticks { get; set; }

                public byte[] TickBitmap { get; set; }

                public byte[] Positions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlot0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vSlot0.From(Slot0);
                    ret.AddRange(vSlot0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeGrowthGlobal0X128 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeGrowthGlobal0X128.From(FeeGrowthGlobal0X128);
                    ret.AddRange(vFeeGrowthGlobal0X128.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeGrowthGlobal1X128 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeGrowthGlobal1X128.From(FeeGrowthGlobal1X128);
                    ret.AddRange(vFeeGrowthGlobal1X128.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidity.From(Liquidity);
                    ret.AddRange(vLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vTicks.From(Ticks);
                    ret.AddRange(vTicks.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickBitmap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vTickBitmap.From(TickBitmap);
                    ret.AddRange(vTickBitmap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vPositions.From(Positions);
                    ret.AddRange(vPositions.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlot0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSlot0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSlot0 = vSlot0.ToValue();
                    if (valueSlot0 is byte[] vSlot0Value) { ret.Slot0 = vSlot0Value; }
                    var vFeeGrowthGlobal0X128 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeGrowthGlobal0X128.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeGrowthGlobal0X128 = vFeeGrowthGlobal0X128;
                    var vFeeGrowthGlobal1X128 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeGrowthGlobal1X128.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeGrowthGlobal1X128 = vFeeGrowthGlobal1X128;
                    var vLiquidity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Liquidity = vLiquidity;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vTicks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTicks = vTicks.ToValue();
                    if (valueTicks is byte[] vTicksValue) { ret.Ticks = vTicksValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickBitmap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vTickBitmap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickBitmap = vTickBitmap.ToValue();
                    if (valueTickBitmap is byte[] vTickBitmapValue) { ret.TickBitmap = vTickBitmapValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vPositions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePositions = vPositions.ToValue();
                    if (valuePositions is byte[] vPositionsValue) { ret.Positions = vPositionsValue; }
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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="self"> State</param>
        /// <param name="params"> ModifyLiquidityParams</param>
        /// <param name="delta"> </param>
        /// <param name="feeDelta"> </param>
        /// <param name="liquidityDelta"> </param>
        /// <param name="state"> ModifyLiquidityState</param>
        /// <param name="tickLower"> </param>
        /// <param name="tickUpper"> </param>
        public async Task PoolModifyLiquidityChunk1Chunk0(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 208, 30, 85 };
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);

            var result = await base.CallApp(new List<object> { abiHandle, self, @params, delta, feeDelta, liquidityDelta, state, tickLowerAbi, tickUpperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PoolModifyLiquidityChunk1Chunk0_Transactions(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 208, 30, 85 };
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);

            return await base.MakeTransactionList(new List<object> { abiHandle, self, @params, delta, feeDelta, liquidityDelta, state, tickLowerAbi, tickUpperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjMiLCJkZXNjIjoiSGVscGVyIGNvbnRyYWN0IDMgZm9yIFBvb2xNYW5hZ2VyIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1vZGlmeUxpcXVpZGl0eVBhcmFtcyI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6InRpY2tMb3dlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWNrVXBwZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlxdWlkaXR5RGVsdGEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNhbHQiLCJ0eXBlIjoidWludDhbMzJdIn1dLCJNb2RpZnlMaXF1aWRpdHlTdGF0ZSI6W3sibmFtZSI6ImZsaXBwZWRMb3dlciIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImxpcXVpZGl0eUdyb3NzQWZ0ZXJMb3dlciIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmxpcHBlZFVwcGVyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGlxdWlkaXR5R3Jvc3NBZnRlclVwcGVyIiwidHlwZSI6InVpbnQyNTYifV0sIlN0YXRlIjpbeyJuYW1lIjoic2xvdDAiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiZmVlR3Jvd3RoR2xvYmFsMFgxMjgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZlZUdyb3d0aEdsb2JhbDFYMTI4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJsaXF1aWRpdHkiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InRpY2tCaXRtYXAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoicG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJQb29sLm1vZGlmeUxpcXVpZGl0eV9fY2h1bmtfMV9fY2h1bmtfMCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LGJ5dGVbXSxieXRlW10sYnl0ZVtdKSIsInN0cnVjdCI6IlN0YXRlIiwibmFtZSI6InNlbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50MjU2LHVpbnQ2NCx1aW50OFszMl0pIiwic3RydWN0IjoiTW9kaWZ5TGlxdWlkaXR5UGFyYW1zIiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlRGVsdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXF1aWRpdHlEZWx0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ4LHVpbnQyNTYsdWludDgsdWludDI1NikiLCJzdHJ1Y3QiOiJNb2RpZnlMaXF1aWRpdHlTdGF0ZSIsIm5hbWUiOiJzdGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja0xvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrVXBwZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2ODNdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIzXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBtdXN0IGJlIGNhbGxlZCBpbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzhdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzFdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzU1XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IGNodW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2OF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjAzLDEyMjUsMTI0NywxNjY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBNb2RpZnlMaXF1aWRpdHlQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE1vZGlmeUxpcXVpZGl0eVN0YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBTdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2OSwxMjc2LDEyODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwMSwxMzEwLDE2NTEsMTY2MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICh1aW50OFszMl0sdWludDI1Nix1aW50MjU2LHVpbnQyNTYsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDUgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNiBvZiAodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODksMTIxMiwxMjM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTYsMTQ0MiwxNDg3LDE1MTNdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4NiwxMDU2LDExMzNdLCJlcnJvck1lc3NhZ2UiOiJyZXZlcnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pNdVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTRJRE15SURFZ01UTXdJREV6TWlBNU1qSXpNemN5TURNMk9EVTBOemMxT0RBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElEQjRNREVnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUlEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1ESWdNSGc0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd01DQXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01EQXdNREFnTUhobVptWm1abVlnSW04aUlEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZZ0luQWlJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh3b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNU1hWEYxYVdScGRIbE5ZWFJvTG1Ga1pFUmxiSFJoS0hnNklHSjVkR1Z6TENCNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNreHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0U2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNZ29nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1RHbHhkV2xrYVhSNVRXRjBhQzVoWkdSRVpXeDBZVjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW53S0NreHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVjJaWEowQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NreHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdZaUJNYVhGMWFXUnBkSGxOWVhSb0xtRmtaRVJsYkhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOcktIUnBZMnRUY0dGamFXNW5PaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01nb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lIQjFjMmhwYm5RZ01UZzBORFkzTkRRd056TTNNRGcyTmpRek5EUUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpUGowS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCaWVpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU1URUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpZWlCUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZlptRnNjMlZBT1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlLd29LVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREV3T2dvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpc0tDbEJ2YjJ3dWRHbGphMU53WVdOcGJtZFViMDFoZUV4cGNYVnBaR2wwZVZCbGNsUnBZMnRmZEdWeWJtRnllVjl0WlhKblpVQXhPRG9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCaWVpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU16RUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlzS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krUFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCd2RYTm9hVzUwSURnNE56STNNZ29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWW5vZ1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyWmhiSE5sUURReENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZbm9nVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE01Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSXJDZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFOREE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lpOEtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCemQyRndDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUt3b0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFEUTRPZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpTHdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpSUZCdmIyd3VkR2xqYTFOd1lXTnBibWRVYjAxaGVFeHBjWFZwWkdsMGVWQmxjbFJwWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTUFvS1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyWmhiSE5sUURReE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR0o2SUZCdmIyd3VkR2xqYTFOd1lXTnBibWRVYjAxaGVFeHBjWFZwWkdsMGVWQmxjbFJwWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTmdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlLd29LVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRFEzT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHSXZDaUFnSUNCaUlGQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9Bb0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFEUTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdJZ1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURRM0NncFFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU16RTZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWlCUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpJS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR0lnVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREV3Q2dwUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZlptRnNjMlZBTVRFNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZbm9nVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRREUyQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSXJDZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNVGM2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpOEtJQ0FnSUdJZ1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURFNENncFFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU1UWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWlCUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRjS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VHWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzTG5Wd1pHRjBaVlJwWTJzb2MyVnNaam9nWW5sMFpYTXNJSFJwWTJzNklIVnBiblEyTkN3Z2JHbHhkV2xrYVhSNVJHVnNkR0U2SUdKNWRHVnpMQ0IxY0hCbGNqb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWekxDQmllWFJsY3pvS1VHOXZiQzUxY0dSaGRHVlVhV05yT2dvZ0lDQWdjSEp2ZEc4Z05DQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGIySUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ2NIVnphR0o1ZEdWeklDSjBhV05yY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJNYVhGMWFXUnBkSGxOWVhSb0xtRmtaRVJsYkhSaENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWowOUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaVBUMEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBaFBRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5vZ1VHOXZiQzUxY0dSaGRHVlVhV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGJuUmpJRFlnTHk4Z09USXlNek0zTWpBek5qZzFORGMzTlRnd09Bb2dJQ0FnWGdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHTmhiR3h6ZFdJZ1UyeHZkREJNYVdKeVlYSjVMblJwWTJzS0lDQWdJR2x1ZEdNZ05pQXZMeUE1TWpJek16Y3lNRE0yT0RVME56YzFPREE0Q2lBZ0lDQmVDaUFnSUNBOFBRb2dJQ0FnWW5vZ1VHOXZiQzUxY0dSaGRHVlVhV05yWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXdkWFFLQ2xCdmIyd3VkWEJrWVhSbFZHbGphMTloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxOc2IzUXdUR2xpY21GeWVTNTBhV05yS0Y5d1lXTnJaV1E2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2xOc2IzUXdUR2xpY21GeWVTNTBhV05yT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURJS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRk5zYjNRd1RHbGljbUZ5ZVM1MGFXTnJYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TURBd01EQUtJQ0FnSUdKOENncFRiRzkwTUV4cFluSmhjbmt1ZEdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2xOc2IzUXdUR2xpY21GeWVTNTBhV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGhtWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpSUZOc2IzUXdUR2xpY21GeWVTNTBhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVVYVdOclFtbDBiV0Z3TG1ac2FYQlVhV05yS0hObGJHWTZJR0o1ZEdWekxDQjBhV05yT2lCMWFXNTBOalFzSUhScFkydFRjR0ZqYVc1bk9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNsUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkyczZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3TUFvZ0lDQWdZaThLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TWdvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2dWR2xqYTBKcGRHMWhjQzVtYkdsd1ZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptTURBd01EQXdDaUFnSUNCaWZBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncFVhV05yUW1sMGJXRndMbVpzYVhCVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01nb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nVkdsamEwSnBkRzFoY0M1bWJHbHdWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFVLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BVYVdOclFtbDBiV0Z3TG1ac2FYQlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqNDlDaUFnSUNCa2RYQUtJQ0FnSUdKNklGUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Bb2dJQ0FnWW5vZ1ZHbGphMEpwZEcxaGNDNW1iR2x3VkdsamExOTBaWEp1WVhKNVgyWmhiSE5sUURrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LVkdsamEwSnBkRzFoY0M1bWJHbHdWR2xqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREV3T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGc0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQajBLSUNBZ0lHSjZJRlJwWTJ0Q2FYUnRZWEF1Wm14cGNGUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQXhNZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaUt3b0tWR2xqYTBKcGRHMWhjQzVtYkdsd1ZHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFERXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlzS0NsUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1Ub0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJSEpsZG1WeWRBb2dJQ0FnY21WMGMzVmlDZ3BVYVdOclFtbDBiV0Z3TG1ac2FYQlVhV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1lpQlVhV05yUW1sMGJXRndMbVpzYVhCVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU1UTUtDbFJwWTJ0Q2FYUnRZWEF1Wm14cGNGUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQTVPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCVWFXTnJRbWwwYldGd0xtWnNhWEJVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRBS0NsUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Eb0tJQ0FnSUdKNklGUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwVWFXTnJRbWwwYldGd0xtWnNhWEJVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRjNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krUFFvZ0lDQWdZbm9nVkdsamEwSnBkRzFoY0M1bWJHbHdWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRREU1Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSXJDZ3BVYVdOclFtbDBiV0Z3TG1ac2FYQlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNakE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lpVUtJQ0FnSUdJZ1ZHbGphMEpwZEcxaGNDNW1iR2x3VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURJeENncFVhV05yUW1sMGJXRndMbVpzYVhCVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU1UazZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWlCVWFXTnJRbWwwYldGd0xtWnNhWEJVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpBS0NsUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnVkdsamEwSnBkRzFoY0M1bWJHbHdWR2xqYTE5MFpYSnVZWEo1WDIxbGNtZGxRREUzQ2dwVWFXTnJRbWwwYldGd0xtWnNhWEJVYVdOclgzUmxjbTVoY25sZlptRnNjMlZBTlRvS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhobVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdJZ1ZHbGphMEpwZEcxaGNDNW1iR2x3VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURZS0NsUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VHWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1lpQlVhV05yUW1sMGJXRndMbVpzYVhCVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNURkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYUNneUtWOHhLSE5sYkdWamRHOXlPaUJpZVhSbGN5d2dkbUZzZFdVNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1EzVnpkRzl0VW1WMlpYSjBMbkpsZG1WeWRGZHBkR2c2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdWeWNpQXZMeUJ5WlhabGNuUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak11WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZbUZ5WlY5amNtVmhkR1ZmWDBBNENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMU9XUXdNV1UxTlNBd2VHRTVObVZtT1RnNUlDOHZJRzFsZEdodlpDQWlVRzl2YkM1dGIyUnBabmxNYVhGMWFXUnBkSGxmWDJOb2RXNXJYekZmWDJOb2RXNXJYekFvS0hWcGJuUTRXek15WFN4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXhpZVhSbFcxMHNZbmwwWlZ0ZExHSjVkR1ZiWFNrc0tIVnBiblE0V3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUXlOVFlzZFdsdWREWTBMSFZwYm5RNFd6TXlYU2tzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNLSFZwYm5RNExIVnBiblF5TlRZc2RXbHVkRGdzZFdsdWRESTFOaWtzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKZlgybHVhWFJmWHloMWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1VHOXZiQzV0YjJScFpubE1hWEYxYVdScGRIbGZYMk5vZFc1clh6RmZYMk5vZFc1clh6QWdYMTlwYm1sMFgxOEtJQ0FnSUdWeWNnb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRRGc2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU15NVFiMjlzTG0xdlpHbG1lVXhwY1hWcFpHbDBlVjlmWTJoMWJtdGZNVjlmWTJoMWJtdGZNRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2xCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV5T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNelFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dOQ0J2WmlBb2RXbHVkRGhiTXpKZExIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N3b2JHVnVLM1ZwYm5RNFcxMHBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhNellLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJRFFnTHk4Z01UTXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQTFJRzltSUNoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3BDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqSURVZ0x5OGdNVE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0EySUc5bUlDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2twQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCVGRHRjBaUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRJd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJOYjJScFpubE1hWEYxYVdScGRIbFFZWEpoYlhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUUxdlpHbG1lVXhwY1hWcFpHbDBlVk4wWVhSbENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUZCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlCUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dwUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR1JwWnlBMENpQWdJQ0JpSVQwS0lDQWdJR0o2SUZCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjS0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCUWIyOXNMblZ3WkdGMFpWUnBZMnNLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJRYjI5c0xuVndaR0YwWlZScFkyc0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEY2dNUW9nSUNBZ1pHbG5JRFlLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlGQnZiMnd1ZFhCa1lYUmxWR2xqYXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnVUc5dmJDNTFjR1JoZEdWVWFXTnJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0J1SURJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJR05oYkd4emRXSWdVRzl2YkM1MWNHUmhkR1ZVYVdOckNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2IzQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pYaDBjbUZqZENBM0lERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNek1LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0JqWVd4c2MzVmlJRkJ2YjJ3dWRYQmtZWFJsVkdsamF3b2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0J5WlhCc1lXTmxNaUF6TkFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JrYVdjZ053b2dJQ0FnWWo0OUNpQWdJQ0JpZWlCUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR05oYkd4emRXSWdVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERWdNeklLSUNBZ0lHSThDaUFnSUNCaWVpQlFiMjlzTG0xdlpHbG1lVXhwY1hWcFpHbDBlVjlmWTJoMWJtdGZNVjlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCRGRYTjBiMjFTWlhabGNuUXVjbVYyWlhKMFYybDBhQW9LVUc5dmJDNXRiMlJwWm5sTWFYRjFhV1JwZEhsZlgyTm9kVzVyWHpGZlgyTm9kVzVyWHpCZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRE0wSURNeUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWWo0S0lDQWdJR0o2SUZCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRU4xYzNSdmJWSmxkbVZ5ZEM1eVpYWmxjblJYYVhSb0NncFFiMjlzTG0xdlpHbG1lVXhwY1hWcFpHbDBlVjlmWTJoMWJtdGZNVjlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklGQnZiMnd1Ylc5a2FXWjVUR2x4ZFdsa2FYUjVYMTlqYUhWdWExOHhYMTlqYUhWdWExOHdYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE16QUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUExSUM4dklERXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRlJwWTJ0Q2FYUnRZWEF1Wm14cGNGUnBZMnNLQ2xCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F6TXlBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUZCdmIyd3ViVzlrYVdaNVRHbHhkV2xrYVhSNVgxOWphSFZ1YTE4eFgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjS0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TXpBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTFJQzh2SURFek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGUnBZMnRDYVhSdFlYQXVabXhwY0ZScFkyc0tDbEJ2YjJ3dWJXOWthV1o1VEdseGRXbGthWFI1WDE5amFIVnVhMTh4WDE5amFIVnVhMTh3WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGM2Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJekxsOWZhVzVwZEY5ZlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYMTlwYm1sMFgxODZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nWVd4eVpXRmtlU0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYnlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0p3SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBSEFBZ2dBWUlCaEFHQWdJQ0FnSUNBZ0lBQkpnMEFBUUVnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOGhBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRSWdnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FBQUFnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy84QUFBQUQvLy8vQVc4US8vLy8vLy8vLy8vLy8vLy8vLy8vL3dGd2dBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUlERG9vQ0FZditKd3FzaS8rQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQUFBQUFBQUFBQUFBQUFBQUFBQUFBb2ljRXFpaXBRUUJVaS8rQUlQLy8vLy8vLy8vLy8vLy8vLy8vLy84QUFBQUFBQUFBQUFBQUFBQUFBQUFBcTRzQW9DdXFTWUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2lLS2tVUkV5SmkvOG5DcXhDLzhtS0FRRWlSd1FvU1l2L0Zra25CcUluQktvb3FVRUF6aWNIcTR3RGdaanN5Zi8vLy8vLy93RVdqQUtMQXljRnAwbU1CU2dwVHdKTktLbEpqQVpCQUkrTEJVRUFoU3FMQTZFcG9Jc0NUS0lxVEtFcG9DdWdqQVNMQlVFQWFDcUxBNkVwb0lzQ1RLb25CYWNvS1U4Q1RZc0VUS0VycW93QWdlaVROaGFNQVlzR1FRQXJpd1ZCQUNFcWl3T2hLYUNMQVV5aUtreWhLYUFyb0lzQW9TdXFLYUFycWljS1RLS01BSW1MQTBMLzRJc0ZRUUFOS29zRG9TbWdpd0ZNb2tMLzE0c0RRdi8waXdOQy81bUxBMEwvZklzRlFRQU5Lb3NEb1NtZ2l3Sk1va0wvYzRzRFF2LzBKd2lzakFOQy95K0tCQU9ML1JZQmdBVjBhV05yYzB4UVNiNG5ERTRDVFZjQUlFbUwvb2orWWtsT0FpSVdURXNCcUU0Q3FFeExBUk5NUVFCYmkvMGhCaHVML0ZjQUlJZ0FXeUVHR3c1QkFFZUwvRmNnSUNTdlRFc0JxNHNBU1U0RHZpY01UZ0pOU1ZkZ0lFc0JWd0FnVHdKWElDQlFUd0pRVEZCSlYwQWdpL3hYUUNCUEE2dExBbGNBSUU4RFZ5QWdVRThDVUV4UXY0c0Npd0dML0U4RlR3VlBCWW1LQVFFanI0di9nQ0FBQUFBQUFBQUFBQUFBQUFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFLSkpKd2FpSndTcUtLbEJBQTRuQjZ1TEFFeFFTUlVqQ1Z0TWlTY0lyRUwvNzRvREFDSkhBNHYrRmtrbkJxSW5CS29vcVVFQWlTY0hxNHdDaS84V1NTY0dvaWNFcWlpcFFRQnRKd2VyakFPTEFpY0ZwMGxCQUROQkFDa3Fpd0toS2FDTUFJc0RKd1duUVFBVUtvc0RvU21naXdCTXFpcE1vU21nS0trVVJJbUxBMEwvN1lzQ2pBQkMvOWhCQUNJcWl3S2hLYUNNQVlzREp3V25RUUFOS29zRG9TbWdpd0ZNcWtML3o0c0RRdi8waXdLTUFVTC8zeWNJckl3RFF2K1FKd2lzakFKQy8zU0tBZ0FBTVJ0QkFCMHhHUlJFTVJoRWdnSUVXZEFlVlFTcGJ2bUpOaG9BamdJQUNRSGRBREVaRkRFWUZCQkRJa2syR2dGSEFoVkxBWUdBQVZsSmdZWUJFa1JMQWt4TEFsSWlXWUdJQVFoTEFpRUVXVWxMQWhKRVN3Tk1Td05TSWxtQkFnZ0lTd0loQlZsSlN3SVNSRThEVEVzRFVpSlpnUUlJQ0JKRU5ob0NTUldCZUJKRU5ob0RGU1FTUkRZYUJCVWtFa1EyR2dWSkZTUVNSRFlhQmtrVmdVSVNSRFlhQjBrVkl4SkVGellhQ0VrVkl4SkVGeWNKWkVFQU16SUVnUUlQUkRNQUdDY0paQkpFTXdBQU1RQVNSQ2NMWkVFQUdERVdKUWs0R0NjTFpCSkVNUllsQ1RrYUFJQUJjMlFTUkNJV1NVVUlTd1NwUVFFR1N3VkxBa2xPQWtzR1NVNEVJb2o5YWs0Q1JnSkxBVXNESW9qOVhrNENTQlpKa3lNT1JGY0hBVXNHVEZ3QVRFOENTd01paVAxRVRnSkZBVWtWSkE1RUpLOU1Td0dyVHdOTVhBRlBBa3NFU1U0Q1N3VWxpUDBqVGdKR0Frc0JTd1VsaVAwWFRnSklGa21USXc1RVZ3Y0JUd05NWENGTVR3SkxCQ1dJL1AxRkMwVUJTUlVrRGtSUEFxdGNJa1VFU3dlblFRQXJTd1NCVUZ1SSsvSkpSUWxMQTFjQklLUkJBQVlvU3dLSS9sbExBbGNpSUVzSXBVRUFCaWhMQVlqK1NFc0NWd0FCS0tsQkFCcExCVWtoQkZsTEFTRUZXVkpYQWdCTEJZRlFXMHNEVElqOWZrc0NWeUVCS0tsQkFCcExCVWtoQkZsTEFTRUZXVkpYQWdCTEJZRlFXMHNDVElqOVdpVkROaG9CU1JVakVrUVhOaG9DU1JVakVrUVhOaG9EU1NKWmdRSUlTd0VWRWtSWEFnQW5DV1FVUkNjSlR3Tm5Kd3RQQW1lQUFYTk1aeVZEIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
