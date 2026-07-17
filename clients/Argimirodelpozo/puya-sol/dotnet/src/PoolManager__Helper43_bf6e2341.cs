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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper43_bf6e2341
{


    //
    // Helper contract 43 for PoolManager
    //
    public class PoolManager__Helper43Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper43Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ModifyLiquidityParams : AVMObjectType
            {
                public ulong TickLower { get; set; }

                public ulong TickUpper { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LiquidityDelta { get; set; }

                public byte[] Salt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickLower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickLower.From(TickLower);
                    ret.AddRange(vTickLower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickUpper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickUpper.From(TickUpper);
                    ret.AddRange(vTickUpper.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidityDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidityDelta.From(LiquidityDelta);
                    ret.AddRange(vLiquidityDelta.Encode());
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

            public class PoolKey : AVMObjectType
            {
                public byte[] Currency0 { get; set; }

                public byte[] Currency1 { get; set; }

                public ulong Fee { get; set; }

                public ulong TickSpacing { get; set; }

                public byte[] Hooks { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCurrency0.From(Currency0);
                    ret.AddRange(vCurrency0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCurrency1.From(Currency1);
                    ret.AddRange(vCurrency1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickSpacing.From(TickSpacing);
                    ret.AddRange(vTickSpacing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHooks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vHooks.From(Hooks);
                    ret.AddRange(vHooks.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCurrency0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrency0 = vCurrency0.ToValue();
                    if (valueCurrency0 is byte[] vCurrency0Value) { ret.Currency0 = vCurrency0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCurrency1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrency1 = vCurrency1.ToValue();
                    if (valueCurrency1 is byte[] vCurrency1Value) { ret.Currency1 = vCurrency1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFee = vFee.ToValue();
                    if (valueFee is ulong vFeeValue) { ret.Fee = vFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickSpacing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickSpacing = vTickSpacing.ToValue();
                    if (valueTickSpacing is ulong vTickSpacingValue) { ret.TickSpacing = vTickSpacingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHooks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vHooks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHooks = vHooks.ToValue();
                    if (valueHooks is byte[] vHooksValue) { ret.Hooks = vHooksValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolKey);
                }
                public bool Equals(PoolKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolKey left, PoolKey right)
                {
                    return EqualityComparer<PoolKey>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolKey left, PoolKey right)
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

            public class SwapParams : AVMObjectType
            {
                public byte ZeroForOne { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountSpecified { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceLimitX96 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vZeroForOne.From(ZeroForOne);
                    ret.AddRange(vZeroForOne.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountSpecified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountSpecified.From(AmountSpecified);
                    ret.AddRange(vAmountSpecified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceLimitX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceLimitX96.From(SqrtPriceLimitX96);
                    ret.AddRange(vSqrtPriceLimitX96.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SwapParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SwapParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vZeroForOne.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueZeroForOne = vZeroForOne.ToValue();
                    if (valueZeroForOne is byte vZeroForOneValue) { ret.ZeroForOne = vZeroForOneValue; }
                    var vAmountSpecified = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountSpecified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountSpecified = vAmountSpecified;
                    var vSqrtPriceLimitX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceLimitX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceLimitX96 = vSqrtPriceLimitX96;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SwapParams);
                }
                public bool Equals(SwapParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SwapParams left, SwapParams right)
                {
                    return EqualityComparer<SwapParams>.Default.Equals(left, right);
                }
                public static bool operator !=(SwapParams left, SwapParams right)
                {
                    return !(left == right);
                }

            }

            public class Tuple : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountToSwap { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 HookReturn { get; set; }

                public ulong LpFeeOverride { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToSwap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountToSwap.From(AmountToSwap);
                    ret.AddRange(vAmountToSwap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookReturn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vHookReturn.From(HookReturn);
                    ret.AddRange(vHookReturn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLpFeeOverride = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLpFeeOverride.From(LpFeeOverride);
                    ret.AddRange(vLpFeeOverride.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Tuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Tuple();
                    uint count = 0;
                    var vAmountToSwap = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountToSwap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountToSwap = vAmountToSwap;
                    var vHookReturn = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vHookReturn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.HookReturn = vHookReturn;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLpFeeOverride = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLpFeeOverride.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLpFeeOverride = vLpFeeOverride.ToValue();
                    if (valueLpFeeOverride is ulong vLpFeeOverrideValue) { ret.LpFeeOverride = vLpFeeOverrideValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Tuple);
                }
                public bool Equals(Tuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Tuple left, Tuple right)
                {
                    return EqualityComparer<Tuple>.Default.Equals(left, right);
                }
                public static bool operator !=(Tuple left, Tuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@notice calls beforeSwap hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="params"> SwapParams</param>
        /// <param name="hookData"> </param>
        public async Task<Structs.Tuple> HooksBeforeSwap(Algorand.Address self, Structs.PoolKey key, Structs.SwapParams @params, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 142, 87, 105 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, @params, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> HooksBeforeSwap_Transactions(Algorand.Address self, Structs.PoolKey key, Structs.SwapParams @params, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 142, 87, 105 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, @params, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="result"> </param>
        public async Task<ulong> ParseBytesParseFee(byte[] result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 62, 29, 10 };
            var resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); resultAbi.From(result);

            var result = await base.SimApp(new List<object> { abiHandle, resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ParseBytesParseFee_Transactions(byte[] result, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 62, 29, 10 };
            var resultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); resultAbi.From(result);

            return await base.MakeTransactionList(new List<object> { abiHandle, resultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice performs a hook call using the given calldata on the given hook
        /// @return int256 The delta returned by the hook
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="data"> </param>
        /// <param name="parseReturn"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> HooksCallHookWithReturnDelta(Algorand.Address self, byte[] data, bool parseReturn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 30, 206, 152 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var parseReturnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); parseReturnAbi.From(parseReturn);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, dataAbi, parseReturnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> HooksCallHookWithReturnDelta_Transactions(Algorand.Address self, byte[] data, bool parseReturn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 30, 206, 152 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var parseReturnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); parseReturnAbi.From(parseReturn);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, dataAbi, parseReturnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice calls beforeModifyLiquidity hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="params"> ModifyLiquidityParams</param>
        /// <param name="hookData"> </param>
        public async Task HooksBeforeModifyLiquidity(Algorand.Address self, Structs.PoolKey key, Structs.ModifyLiquidityParams @params, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 208, 40, 159 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, @params, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> HooksBeforeModifyLiquidity_Transactions(Algorand.Address self, Structs.PoolKey key, Structs.ModifyLiquidityParams @params, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 208, 40, 159 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, @params, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice calls beforeDonate hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="amount0"> </param>
        /// <param name="amount1"> </param>
        /// <param name="hookData"> </param>
        public async Task HooksBeforeDonate(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 74, 242, 202 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, amount0, amount1, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> HooksBeforeDonate_Transactions(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 74, 242, 202 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, amount0, amount1, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice calls afterDonate hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="amount0"> </param>
        /// <param name="amount1"> </param>
        /// <param name="hookData"> </param>
        public async Task HooksAfterDonate(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 127, 22, 4 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, amount0, amount1, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> HooksAfterDonate_Transactions(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, byte[] hookData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 127, 22, 4 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, amount0, amount1, hookDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice calls beforeInitialize hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="sqrtPriceX96"> </param>
        public async Task HooksBeforeInitialize(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceX96, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 66, 205, 206 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, sqrtPriceX96 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> HooksBeforeInitialize_Transactions(Algorand.Address self, Structs.PoolKey key, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceX96, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 66, 205, 206 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, sqrtPriceX96 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="self"> State</param>
        /// <param name="protocolFee"> </param>
        public async Task PoolSetProtocolFee(Structs.State self, ulong protocolFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 162, 200, 25 };
            var protocolFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolFeeAbi.From(protocolFee);

            var result = await base.CallApp(new List<object> { abiHandle, self, protocolFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PoolSetProtocolFee_Transactions(Structs.State self, ulong protocolFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 162, 200, 25 };
            var protocolFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolFeeAbi.From(protocolFee);

            return await base.MakeTransactionList(new List<object> { abiHandle, self, protocolFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjQzIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA0MyBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTW9kaWZ5TGlxdWlkaXR5UGFyYW1zIjpbeyJuYW1lIjoidGlja0xvd2VyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpY2tVcHBlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsaXF1aWRpdHlEZWx0YSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoic2FsdCIsInR5cGUiOiJ1aW50OFszMl0ifV0sIlBvb2xLZXkiOlt7Im5hbWUiOiJjdXJyZW5jeTAiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiY3VycmVuY3kxIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImZlZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWNrU3BhY2luZyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJob29rcyIsInR5cGUiOiJ1aW50OFszMl0ifV0sIlN0YXRlIjpbeyJuYW1lIjoic2xvdDAiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiZmVlR3Jvd3RoR2xvYmFsMFgxMjgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZlZUdyb3d0aEdsb2JhbDFYMTI4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJsaXF1aWRpdHkiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InRpY2tCaXRtYXAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoicG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XSwiU3dhcFBhcmFtcyI6W3sibmFtZSI6Inplcm9Gb3JPbmUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhbW91bnRTcGVjaWZpZWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InNxcnRQcmljZUxpbWl0WDk2IiwidHlwZSI6InVpbnQyNTYifV0sInR1cGxlIjpbeyJuYW1lIjoiYW1vdW50VG9Td2FwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJob29rUmV0dXJuIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJscEZlZU92ZXJyaWRlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJIb29rcy5iZWZvcmVTd2FwIiwiZGVzYyI6IkBub3RpY2UgY2FsbHMgYmVmb3JlU3dhcCBob29rIGlmIHBlcm1pc3Npb25lZCBhbmQgdmFsaWRhdGVzIHJldHVybiB2YWx1ZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50OFszMl0pIiwic3RydWN0IjoiUG9vbEtleSIsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OCx1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiU3dhcFBhcmFtcyIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhvb2tEYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDY0KSIsInN0cnVjdCI6InR1cGxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUGFyc2VCeXRlcy5wYXJzZUZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXN1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ikhvb2tzLmNhbGxIb29rV2l0aFJldHVybkRlbHRhIiwiZGVzYyI6IkBub3RpY2UgcGVyZm9ybXMgYSBob29rIGNhbGwgdXNpbmcgdGhlIGdpdmVuIGNhbGxkYXRhIG9uIHRoZSBnaXZlbiBob29rXG4gQHJldHVybiBpbnQyNTYgVGhlIGRlbHRhIHJldHVybmVkIGJ5IHRoZSBob29rIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFyc2VSZXR1cm4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiSG9va3MuYmVmb3JlTW9kaWZ5TGlxdWlkaXR5IiwiZGVzYyI6IkBub3RpY2UgY2FsbHMgYmVmb3JlTW9kaWZ5TGlxdWlkaXR5IGhvb2sgaWYgcGVybWlzc2lvbmVkIGFuZCB2YWxpZGF0ZXMgcmV0dXJuIHZhbHVlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ4WzMyXSkiLCJzdHJ1Y3QiOiJQb29sS2V5IiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDI1Nix1aW50OFszMl0pIiwic3RydWN0IjoiTW9kaWZ5TGlxdWlkaXR5UGFyYW1zIiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9va0RhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiSG9va3MuYmVmb3JlRG9uYXRlIiwiZGVzYyI6IkBub3RpY2UgY2FsbHMgYmVmb3JlRG9uYXRlIGhvb2sgaWYgcGVybWlzc2lvbmVkIGFuZCB2YWxpZGF0ZXMgcmV0dXJuIHZhbHVlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ4WzMyXSkiLCJzdHJ1Y3QiOiJQb29sS2V5IiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJIb29rcy5hZnRlckRvbmF0ZSIsImRlc2MiOiJAbm90aWNlIGNhbGxzIGFmdGVyRG9uYXRlIGhvb2sgaWYgcGVybWlzc2lvbmVkIGFuZCB2YWxpZGF0ZXMgcmV0dXJuIHZhbHVlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ4WzMyXSkiLCJzdHJ1Y3QiOiJQb29sS2V5IiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJIb29rcy5iZWZvcmVJbml0aWFsaXplIiwiZGVzYyI6IkBub3RpY2UgY2FsbHMgYmVmb3JlSW5pdGlhbGl6ZSBob29rIGlmIHBlcm1pc3Npb25lZCBhbmQgdmFsaWRhdGVzIHJldHVybiB2YWx1ZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50OFszMl0pIiwic3RydWN0IjoiUG9vbEtleSIsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcXJ0UHJpY2VYOTYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUG9vbC5zZXRQcm90b2NvbEZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LGJ5dGVbXSxieXRlW10sYnl0ZVtdKSIsInN0cnVjdCI6IlN0YXRlIiwibmFtZSI6InNlbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sRmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9faW5pdF9fIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODMzXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTUzLDEwNjYsMTE2MiwxMjc4LDEzOTIsMTUwNywxNTk4LDE3NDZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY3LDEwODAsMTE3NiwxMjkyLDE0MDYsMTUyMSwxNjEyLDE3NjBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2MCwxMDczLDExNjksMTI4NSwxMzk5LDE1MTQsMTYwNSwxNzUzXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB1bmF1dGhvcml6ZWQgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgyLDEwOTUsMTE5MSwxMzA3LDE0MjEsMTUzNiwxNjI3LDE3NzVdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgY2h1bmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTMsMTEwNiwxMjAyLDEzMTgsMTQzMiwxNTQ3LDE2MzgsMTc4Nl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzMsMTA0NiwxMTMyLDEyNTgsMTM3MiwxNDg3LDE2NzYsMTY5OSwxNzIxLDE4MTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE1vZGlmeUxpcXVpZGl0eVBhcmFtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxOCwxMjQzLDEzNTAsMTQ2NSwxNTgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFBvb2xLZXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFN0YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFN3YXBQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0MCwxMDUzLDExMzksMTI2NSwxMzc5LDE0OTQsMTgyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDksMTEyNiwxMjM0LDEzNDEsMTQ1NiwxNTcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNTgsMTM2NiwxNDczLDE0ODEsMTU4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzM1LDE4MDIsMTgxMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICh1aW50OFszMl0sdWludDI1Nix1aW50MjU2LHVpbnQyNTYsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDUgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNiBvZiAodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NjIsMTY4NiwxNzA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTQsMTAyNiwxMjE2XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTAsODEwXSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURFZ01DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnZJaUFpY0NJZ0luTWlJREI0SURCNE1UVXhaamRqTnpVZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUlGOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa0psWm05eVpWTjNZWEJFWld4MFlVeHBZbkpoY25rdVoyVjBVM0JsWTJsbWFXVmtSR1ZzZEdFb1pHVnNkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LUW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJUY0dWamFXWnBaV1JFWld4MFlUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlQajBLSUNBZ0lHSjZJRUpsWm05eVpWTjNZWEJFWld4MFlVeHBZbkpoY25rdVoyVjBVM0JsWTJsbWFXVmtSR1ZzZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LUW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJUY0dWamFXWnBaV1JFWld4MFlWOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xrTjFjM1J2YlZKbGRtVnlkQzVpZFdKaWJHVlZjRUZ1WkZKbGRtVnlkRmRwZEdnb2NtVjJaWEowYVc1blEyOXVkSEpoWTNRNklHSjVkR1Z6TENCeVpYWmxjblJwYm1kR2RXNWpkR2x2YmxObGJHVmpkRzl5T2lCaWVYUmxjeXdnWVdSa2FYUnBiMjVoYkVOdmJuUmxlSFE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BEZFhOMGIyMVNaWFpsY25RdVluVmlZbXhsVlhCQmJtUlNaWFpsY25SWGFYUm9PZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JsY25JZ0x5OGdjbVYyWlhKMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xraHZiMnR6TG1GbWRHVnlSRzl1WVhSbEtITmxiR1k2SUdKNWRHVnpMQ0JyWlhrNklHSjVkR1Z6TENCaGJXOTFiblF3T2lCaWVYUmxjeXdnWVcxdmRXNTBNVG9nWW5sMFpYTXNJR2h2YjJ0RVlYUmhPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDa2h2YjJ0ekxtRm1kR1Z5Ukc5dVlYUmxPZ29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011YUdGelVHVnliV2x6YzJsdmJnb2dJQ0FnWW5vZ1NHOXZhM011WVdaMFpYSkViMjVoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTmpWbE9UazBZU0F2THlCdFpYUm9iMlFnSW1GbWRHVnlSRzl1WVhSbEtHRmtaSEpsYzNNc2MzUnlkV04wSUZCdmIyeExaWGtzZFdsdWRESTFOaXgxYVc1ME1qVTJMR0o1ZEdWYlhTbGllWFJsV3pSZElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011WTJGc2JFaHZiMnNLSUNBZ0lIQnZjQW9LU0c5dmEzTXVZV1owWlhKRWIyNWhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1U0c5dmEzTXVZbVZtYjNKbFJHOXVZWFJsS0hObGJHWTZJR0o1ZEdWekxDQnJaWGs2SUdKNWRHVnpMQ0JoYlc5MWJuUXdPaUJpZVhSbGN5d2dZVzF2ZFc1ME1Ub2dZbmwwWlhNc0lHaHZiMnRFWVhSaE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNraHZiMnR6TG1KbFptOXlaVVJ2Ym1GMFpUb0tJQ0FnSUhCeWIzUnZJRFVnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011YUdGelVHVnliV2x6YzJsdmJnb2dJQ0FnWW5vZ1NHOXZhM011WW1WbWIzSmxSRzl1WVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdReVpXUmhaVElnTHk4Z2JXVjBhRzlrSUNKaVpXWnZjbVZFYjI1aGRHVW9ZV1JrY21WemN5eHpkSEoxWTNRZ1VHOXZiRXRsZVN4MWFXNTBNalUyTEhWcGJuUXlOVFlzWW5sMFpWdGRLV0o1ZEdWYk5GMGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkliMjlyY3k1allXeHNTRzl2YXdvZ0lDQWdjRzl3Q2dwSWIyOXJjeTVpWldadmNtVkViMjVoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVNHOXZhM011WW1WbWIzSmxTVzVwZEdsaGJHbDZaU2h6Wld4bU9pQmllWFJsY3l3Z2EyVjVPaUJpZVhSbGN5d2djM0Z5ZEZCeWFXTmxXRGsyT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2todmIydHpMbUpsWm05eVpVbHVhWFJwWVd4cGVtVTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJSEIxYzJocGJuUWdPREU1TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlFaHZiMnR6TG1oaGMxQmxjbTFwYzNOcGIyNEtJQ0FnSUdKNklFaHZiMnR6TG1KbFptOXlaVWx1YVhScFlXeHBlbVZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dOV05oTURVd1lTQXZMeUJ0WlhSb2IyUWdJbUpsWm05eVpVbHVhWFJwWVd4cGVtVW9ZV1JrY21WemN5eHpkSEoxWTNRZ1VHOXZiRXRsZVN4MWFXNTBNalUyS1dKNWRHVmJORjBpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011WTJGc2JFaHZiMnNLSUNBZ0lIQnZjQW9LU0c5dmEzTXVZbVZtYjNKbFNXNXBkR2xoYkdsNlpWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNUliMjlyY3k1aVpXWnZjbVZOYjJScFpubE1hWEYxYVdScGRIa29jMlZzWmpvZ1lubDBaWE1zSUd0bGVUb2dZbmwwWlhNc0lIQmhjbUZ0Y3pvZ1lubDBaWE1zSUdodmIydEVZWFJoT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpPZ3BJYjI5cmN5NWlaV1p2Y21WTmIyUnBabmxNYVhGMWFXUnBkSGs2Q2lBZ0lDQndjbTkwYnlBMElESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F4TmlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpUGdvZ0lDQWdZbm9nU0c5dmEzTXVZbVZtYjNKbFRXOWthV1o1VEdseGRXbGthWFI1WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0J3ZFhOb2FXNTBJREl3TkRnS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQkliMjlyY3k1b1lYTlFaWEp0YVhOemFXOXVDaUFnSUNCaWVpQkliMjlyY3k1aVpXWnZjbVZOYjJScFpubE1hWEYxYVdScGRIbGZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV3TkRrMll6TXpJQzh2SUcxbGRHaHZaQ0FpWW1WbWIzSmxRV1JrVEdseGRXbGthWFI1S0dGa1pISmxjM01zYzNSeWRXTjBJRkJ2YjJ4TFpYa3NjM1J5ZFdOMElFMXZaR2xtZVV4cGNYVnBaR2wwZVZCaGNtRnRjeXhpZVhSbFcxMHBZbmwwWlZzMFhTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUVodmIydHpMbU5oYkd4SWIyOXJDaUFnSUNCd2IzQUtDa2h2YjJ0ekxtSmxabTl5WlUxdlpHbG1lVXhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LU0c5dmEzTXVZbVZtYjNKbFRXOWthV1o1VEdseGRXbGthWFI1WDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmlQRDBLSUNBZ0lHSjZJRWh2YjJ0ekxtSmxabTl5WlUxdlpHbG1lVXhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUhCMWMyaHBiblFnTlRFeUNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdTRzl2YTNNdWFHRnpVR1Z5YldsemMybHZiZ29nSUNBZ1lub2dTRzl2YTNNdVltVm1iM0psVFc5a2FXWjVUR2x4ZFdsa2FYUjVYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EZ3paR1F4WW1ZZ0x5OGdiV1YwYUc5a0lDSmlaV1p2Y21WU1pXMXZkbVZNYVhGMWFXUnBkSGtvWVdSa2NtVnpjeXh6ZEhKMVkzUWdVRzl2YkV0bGVTeHpkSEoxWTNRZ1RXOWthV1o1VEdseGRXbGthWFI1VUdGeVlXMXpMR0o1ZEdWYlhTbGllWFJsV3pSZElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnU0c5dmEzTXVZMkZzYkVodmIyc0tJQ0FnSUhCdmNBb2dJQ0FnWWlCSWIyOXJjeTVpWldadmNtVk5iMlJwWm5sTWFYRjFhV1JwZEhsZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtodmIydHpMbUpsWm05eVpWTjNZWEFvYzJWc1pqb2dZbmwwWlhNc0lHdGxlVG9nWW5sMFpYTXNJSEJoY21GdGN6b2dZbmwwWlhNc0lHaHZiMnRFWVhSaE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6TENCMWFXNTBOalFzSUdKNWRHVnpMQ0JpZVhSbGN6b0tTRzl2YTNNdVltVm1iM0psVTNkaGNEb0tJQ0FnSUhCeWIzUnZJRFFnTlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBeElETXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJRDA5Q2lBZ0lDQmllaUJJYjI5cmN5NWlaV1p2Y21WVGQyRndYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NraHZiMnR6TG1KbFptOXlaVk4zWVhCZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdjSFZ6YUdsdWRDQXhNamdLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCSWIyOXJjeTVvWVhOUVpYSnRhWE56YVc5dUNpQWdJQ0JpZWlCSWIyOXJjeTVpWldadmNtVlRkMkZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJsTURnNVpUazJJQzh2SUcxbGRHaHZaQ0FpWW1WbWIzSmxVM2RoY0NoaFpHUnlaWE56TEhOMGNuVmpkQ0JRYjI5c1MyVjVMSE4wY25WamRDQlRkMkZ3VUdGeVlXMXpMR0o1ZEdWYlhTa29ZbmwwWlZzMFhTeDFhVzUwTWpVMkxIVnBiblEyTkNraUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJJYjI5cmN5NWpZV3hzU0c5dmF3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTVOZ29nSUNBZ0lUMEtJQ0FnSUdKNklFaHZiMnR6TG1KbFptOXlaVk4zWVhCZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzV5WlhabGNuUlhhWFJvQ2dwSWIyOXJjeTVpWldadmNtVlRkMkZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOaGJHeHpkV0lnVEZCR1pXVk1hV0p5WVhKNUxtbHpSSGx1WVcxcFkwWmxaUW9nSUNBZ1lub2dTRzl2YTNNdVltVm1iM0psVTNkaGNGOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGQmhjbk5sUW5sMFpYTXVjR0Z5YzJWR1pXVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb0tTRzl2YTNNdVltVm1iM0psVTNkaGNGOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCSWIyOXJjeTVvWVhOUVpYSnRhWE56YVc5dUNpQWdJQ0JpZWlCSWIyOXJjeTVpWldadmNtVlRkMkZ3WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGNLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCallXeHNjM1ZpSUZCaGNuTmxRbmwwWlhNdWNHRnljMlZTWlhSMWNtNUVaV3gwWVFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1FtVm1iM0psVTNkaGNFUmxiSFJoVEdsaWNtRnllUzVuWlhSVGNHVmphV1pwWldSRVpXeDBZUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJJYjI5cmN5NWlaV1p2Y21WVGQyRndYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmlQQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJR0o2SUVodmIydHpMbUpsWm05eVpWTjNZWEJmZEdWeWJtRnllVjltWVd4elpVQXhNUW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpUGdvS1NHOXZhM011WW1WbWIzSmxVM2RoY0Y5MFpYSnVZWEo1WDIxbGNtZGxRREV5T2dvZ0lDQWdZbm9nU0c5dmEzTXVZbVZtYjNKbFUzZGhjRjloWm5SbGNsOXBabDlsYkhObFFERTNDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUVOMWMzUnZiVkpsZG1WeWRDNXlaWFpsY25SWGFYUm9DZ3BJYjI5cmN5NWlaV1p2Y21WVGQyRndYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tTRzl2YTNNdVltVm1iM0psVTNkaGNGOTBaWEp1WVhKNVgyWmhiSE5sUURFeE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmlQQW9nSUNBZ1lpQkliMjlyY3k1aVpXWnZjbVZUZDJGd1gzUmxjbTVoY25sZmJXVnlaMlZBTVRJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVNHOXZhM011WTJGc2JFaHZiMnNvYzJWc1pqb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LU0c5dmEzTXVZMkZzYkVodmIyczZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzVpZFdKaWJHVlZjRUZ1WkZKbGRtVnlkRmRwZEdnS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VTRzl2YTNNdVkyRnNiRWh2YjJ0WGFYUm9VbVYwZFhKdVJHVnNkR0VvYzJWc1pqb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpMQ0J3WVhKelpWSmxkSFZ5YmpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1NHOXZhM011WTJGc2JFaHZiMnRYYVhSb1VtVjBkWEp1UkdWc2RHRTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlFaHZiMnR6TG1OaGJHeEliMjlyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnVlaUJJYjI5cmN5NWpZV3hzU0c5dmExZHBkR2hTWlhSMWNtNUVaV3gwWVY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2todmIydHpMbU5oYkd4SWIyOXJWMmwwYUZKbGRIVnlia1JsYkhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUNFOUNpQWdJQ0JpZWlCSWIyOXJjeTVqWVd4c1NHOXZhMWRwZEdoU1pYUjFjbTVFWld4MFlWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnS0NraHZiMnR6TG1OaGJHeEliMjlyVjJsMGFGSmxkSFZ5YmtSbGJIUmhYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqWVd4c2MzVmlJRkJoY25ObFFubDBaWE11Y0dGeWMyVlNaWFIxY201RVpXeDBZUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtodmIydHpMbWhoYzFCbGNtMXBjM05wYjI0b2MyVnNaam9nWW5sMFpYTXNJR1pzWVdjNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNraHZiMnR6TG1oaGMxQmxjbTFwYzNOcGIyNDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlKZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdJaFBRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa3hRUm1WbFRHbGljbUZ5ZVM1cGMwUjVibUZ0YVdOR1pXVW9jMlZzWmpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNreFFSbVZsVEdsaWNtRnllUzVwYzBSNWJtRnRhV05HWldVNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBNE16ZzROakE0Q2lBZ0lDQTlQUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCaGNuTmxRbmwwWlhNdWNHRnljMlZHWldVb2NtVnpkV3gwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwUVlYSnpaVUo1ZEdWekxuQmhjbk5sUm1WbE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCaGNuTmxRbmwwWlhNdWNHRnljMlZTWlhSMWNtNUVaV3gwWVNoeVpYTjFiSFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVUdGeWMyVkNlWFJsY3k1d1lYSnpaVkpsZEhWeWJrUmxiSFJoT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJDNWphR1ZqYTFCdmIyeEpibWwwYVdGc2FYcGxaQ2h6Wld4bU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsQnZiMnd1WTJobFkydFFiMjlzU1c1cGRHbGhiR2w2WldRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCallXeHNjM1ZpSUZOc2IzUXdUR2xpY21GeWVTNXpjWEowVUhKcFkyVllPVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaVBUMEtJQ0FnSUdKNklGQnZiMnd1WTJobFkydFFiMjlzU1c1cGRHbGhiR2w2WldSZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzV5WlhabGNuUlhhWFJvQ2dwUWIyOXNMbU5vWldOclVHOXZiRWx1YVhScFlXeHBlbVZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyd3VjMlYwVUhKdmRHOWpiMnhHWldVb2MyVnNaam9nWW5sMFpYTXNJSEJ5YjNSdlkyOXNSbVZsT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwUWIyOXNMbk5sZEZCeWIzUnZZMjlzUm1WbE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1VHOXZiQzVqYUdWamExQnZiMnhKYm1sMGFXRnNhWHBsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVUyeHZkREJNYVdKeVlYSjVMbk54Y25SUWNtbGpaVmc1TmloZmNHRmphMlZrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOc2IzUXdUR2xpY21GeWVTNXpjWEowVUhKcFkyVllPVFk2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVEZFhOMGIyMVNaWFpsY25RdWNtVjJaWEowVjJsMGFDZ3hLU2h6Wld4bFkzUnZjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDa04xYzNSdmJWSmxkbVZ5ZEM1eVpYWmxjblJYYVhSb09nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmxjbklnTHk4Z2NtVjJaWEowQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYeWdwSUMwK0lIVnBiblEyTkRvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxODZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2dYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRREUxQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpTlRobE5UYzJPU0F3ZURVME0yVXhaREJoSURCNE9ETXhaV05sT1RnZ01IaGtPR1F3TWpnNVppQXdlRGswTkdGbU1tTmhJREI0Wm1RM1pqRTJNRFFnTUhneFl6UXlZMlJqWlNBd2VEQTVZVEpqT0RFNUlEQjRZVGsyWldZNU9Ea2dMeThnYldWMGFHOWtJQ0pJYjI5cmN5NWlaV1p2Y21WVGQyRndLR0ZrWkhKbGMzTXNLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0Zzek1sMHBMQ2gxYVc1ME9DeDFhVzUwTWpVMkxIVnBiblF5TlRZcExHSjVkR1ZiWFNrb2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSWxCaGNuTmxRbmwwWlhNdWNHRnljMlZHWldVb1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpU0c5dmEzTXVZMkZzYkVodmIydFhhWFJvVW1WMGRYSnVSR1ZzZEdFb1lXUmtjbVZ6Y3l4aWVYUmxXMTBzWW05dmJDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSkliMjlyY3k1aVpXWnZjbVZOYjJScFpubE1hWEYxYVdScGRIa29ZV1JrY21WemN5d29kV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblE0V3pNeVhTa3NLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkREkxTml4MWFXNTBPRnN6TWwwcExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0pJYjI5cmN5NWlaV1p2Y21WRWIyNWhkR1VvWVdSa2NtVnpjeXdvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNFd6TXlYU2tzZFdsdWRESTFOaXgxYVc1ME1qVTJMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKSWIyOXJjeTVoWm5SbGNrUnZibUYwWlNoaFpHUnlaWE56TENoMWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREaGJNekpkS1N4MWFXNTBNalUyTEhWcGJuUXlOVFlzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0lraHZiMnR6TG1KbFptOXlaVWx1YVhScFlXeHBlbVVvWVdSa2NtVnpjeXdvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNFd6TXlYU2tzZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSlFiMjlzTG5ObGRGQnliM1J2WTI5c1JtVmxLQ2gxYVc1ME9Gc3pNbDBzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNZbmwwWlZ0ZExHSjVkR1ZiWFN4aWVYUmxXMTBwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmZYMmx1YVhSZlh5aDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1aVpXWnZjbVZUZDJGd1czSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRNdVVHRnljMlZDZVhSbGN5NXdZWEp6WlVabFpWdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRekxraHZiMnR6TG1OaGJHeEliMjlyVjJsMGFGSmxkSFZ5YmtSbGJIUmhXM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psVFc5a2FXWjVUR2x4ZFdsa2FYUjVXM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psUkc5dVlYUmxXM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVlXWjBaWEpFYjI1aGRHVmJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1aVpXWnZjbVZKYm1sMGFXRnNhWHBsVzNKdmRYUnBibWRkSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11VUc5dmJDNXpaWFJRY205MGIyTnZiRVpsWlZ0eWIzVjBhVzVuWFNCZlgybHVhWFJmWHdvZ0lDQWdaWEp5Q2dwZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU1UVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRNdVNHOXZhM011WW1WbWIzSmxVM2RoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRNdVNHOXZhM011WW1WbWIzSmxVM2RoY0Z0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01URXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCUWIyOXNTMlY1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVTNkaGNGQmhjbUZ0Y3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1aVpXWnZjbVZUZDJGd1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTXk1SWIyOXJjeTVpWldadmNtVlRkMkZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psVTNkaGNGdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1kyRnNiSE4xWWlCSWIyOXJjeTVpWldadmNtVlRkMkZ3Q2lBZ0lDQndiM0J1SURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbEJoY25ObFFubDBaWE11Y0dGeWMyVkdaV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalF6TGxCaGNuTmxRbmwwWlhNdWNHRnljMlZHWldWYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbEJoY25ObFFubDBaWE11Y0dGeWMyVkdaV1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbEJoY25ObFFubDBaWE11Y0dGeWMyVkdaV1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NVFZWEp6WlVKNWRHVnpMbkJoY25ObFJtVmxXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJRWVhKelpVSjVkR1Z6TG5CaGNuTmxSbVZsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1allXeHNTRzl2YTFkcGRHaFNaWFIxY201RVpXeDBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11U0c5dmEzTXVZMkZzYkVodmIydFhhWFJvVW1WMGRYSnVSR1ZzZEdGYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMa2h2YjJ0ekxtTmhiR3hJYjI5clYybDBhRkpsZEhWeWJrUmxiSFJoVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBNeTVJYjI5cmN5NWpZV3hzU0c5dmExZHBkR2hTWlhSMWNtNUVaV3gwWVZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMa2h2YjJ0ekxtTmhiR3hJYjI5clYybDBhRkpsZEhWeWJrUmxiSFJoVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdTRzl2YTNNdVkyRnNiRWh2YjJ0WGFYUm9VbVYwZFhKdVJHVnNkR0VLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTXk1SWIyOXJjeTVpWldadmNtVk5iMlJwWm5sTWFYRjFhV1JwZEhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRekxraHZiMnR6TG1KbFptOXlaVTF2WkdsbWVVeHBjWFZwWkdsMGVWdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVEV5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlFiMjlzUzJWNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1RXOWthV1o1VEdseGRXbGthWFI1VUdGeVlXMXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalF6TGtodmIydHpMbUpsWm05eVpVMXZaR2xtZVV4cGNYVnBaR2wwZVZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11U0c5dmEzTXVZbVZtYjNKbFRXOWthV1o1VEdseGRXbGthWFI1VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psVFc5a2FXWjVUR2x4ZFdsa2FYUjVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlFaHZiMnR6TG1KbFptOXlaVTF2WkdsbWVVeHBjWFZwWkdsMGVRb2dJQ0FnY0c5d2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTXk1SWIyOXJjeTVpWldadmNtVkViMjVoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRekxraHZiMnR6TG1KbFptOXlaVVJ2Ym1GMFpWdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVEV5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlFiMjlzUzJWNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBNeTVJYjI5cmN5NWlaV1p2Y21WRWIyNWhkR1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMa2h2YjJ0ekxtSmxabTl5WlVSdmJtRjBaVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRekxraHZiMnR6TG1KbFptOXlaVVJ2Ym1GMFpWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011WW1WbWIzSmxSRzl1WVhSbENpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMa2h2YjJ0ekxtRm1kR1Z5Ukc5dVlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBNeTVJYjI5cmN5NWhablJsY2tSdmJtRjBaVnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRFeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJRYjI5c1MyVjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTXk1SWIyOXJjeTVoWm5SbGNrUnZibUYwWlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11U0c5dmEzTXVZV1owWlhKRWIyNWhkR1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1aFpuUmxja1J2Ym1GMFpWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011WVdaMFpYSkViMjVoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psU1c1cGRHbGhiR2w2WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRNdVNHOXZhM011WW1WbWIzSmxTVzVwZEdsaGJHbDZaVnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRFeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJRYjI5c1MyVjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTXk1SWIyOXJjeTVpWldadmNtVkpibWwwYVdGc2FYcGxXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME15NUliMjlyY3k1aVpXWnZjbVZKYm1sMGFXRnNhWHBsVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVTRzl2YTNNdVltVm1iM0psU1c1cGRHbGhiR2w2WlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRWh2YjJ0ekxtSmxabTl5WlVsdWFYUnBZV3hwZW1VS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5ETXVVRzl2YkM1elpYUlFjbTkwYjJOdmJFWmxaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11VUc5dmJDNXpaWFJRY205MGIyTnZiRVpsWlZ0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TWpnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVE0wQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRFFnYjJZZ0tIVnBiblE0V3pNeVhTeDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVE0yQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeE16QUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEVWdiMllnS0hWcGJuUTRXek15WFN4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXdvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFhVzUwT0Z0ZEtTa0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRFlnYjJZZ0tIVnBiblE0V3pNeVhTeDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1UzUmhkR1VLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11VUc5dmJDNXpaWFJRY205MGIyTnZiRVpsWlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORE11VUc5dmJDNXpaWFJRY205MGIyTnZiRVpsWlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbEJ2YjJ3dWMyVjBVSEp2ZEc5amIyeEdaV1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndNZ29nSUNBZ1kyRnNiSE4xWWlCUWIyOXNMbk5sZEZCeWIzUnZZMjlzUm1WbENpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUXpMbDlmYVc1cGRGOWZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDE5cGJtbDBYMTg2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUdGc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalF6TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVJQUVBQWlZR0FXOEJjQUZ6QUFRVkgzeDFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFnTHlpZ0VCaS8rQUlJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBcDBFQUtZdi9Kd1dpZ0NELy8vLy8vLy8vLy8vLy8vLy8vLy8vQUFBQUFBQUFBQUFBQUFBQUFBQUFBS3VKaS84bkJhS0ppZ01BQUlvRkFZRVFGb3Y3VElnQ0lVRUFNWUFFVmw2WlNqRUFVSXY4VUNLdlNZdjlVRWtWSWdraVdFOENURkJNaS81UVNSVWlDU0pZVUl2L1VJdjdUSWdCdEVpTC9JbUtCUUVpRm92N1RJZ0IzMEVBTVlBRURTN2E0akVBVUl2OFVDS3ZTWXY5VUVrVklna2lXRThDVEZCTWkvNVFTUlVpQ1NKWVVJdi9VSXY3VElnQmNraUwvSW1LQXdHQmdFQVdpLzFNaUFHYlFRQWZnQVFGeWdVS01RQlFpLzVRSXErTC8xQkpGU0lKSWxoUWkvMU1pQUZBU0l2K2lZb0VBb3YrVnhBZ1NTUVdTVTRDcFVFQUw0R0FFQmFML0V5SUFWcEJBQ0tBQkZCSmJETXhBRkNML1ZDTC9sQ0wvMUNML0V5SUFRVklpLzJML2s4RFR3T0ppd0NMQWFaQi8rK0JnQVFXaS94TWlBRWpRZi9pZ0FSSVBkRy9NUUJRaS8xUWkvNVFpLzlRaS94TWlBRE9TRUwveG9vRUJTUkhBaXNraS81WEFTQXhBSXY4RWtFQUZTUVdpd1ZNSkl2OWkvNk1CSXdEakFLTUFZd0FpWUdBQVJhTC9FeUlBTkJCQUhhQUJBNElucFl4QUZDTC9WQ0wvbENMLzFDTC9FeUlBSHRKakFJVmdXQVRRUUFFSzRnQkNvdjlnVUJiaUFDclFRQUhpd0tJQUsrTUJJRUlGb3Y4VElnQWpFRUFNb3NDaUFDaFNZd0RpUDN6U1l3QUpCWkpqQUdwUVFBYml3Vkppd0drVElzQW9Jd0ZRUUFoaXdXTEFhVkJBQVFyaUFDNml3V0xBNHNFaS8yTC9vd0VqQU9NQW93QmpBQ0ppd1dMQWFSQy85eUtBZ0dML292L0s0ajkvaXVJQUk2QUFZQ0ppZ01CaS8yTC9vai80NHYvUUFBRUpCWk1pWXNBRllGQUUwRUFCQ3VJQUdxTEFJZ0FIMHlKaWdJQmkvNkwvNndrRnFtSmlnRUJpLytCZ0lDQUJCS0ppZ0VCSkltS0FRRXJpWW9CQVl2L1Z3QWdpQUFaSkJhb1FRQUVLNGdBTEl2L2lZb0NBWXYraVAvZ1NZeitpWW9CQVlBVS8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vK0wvNnlKaWdFQUFERWJRUUJPTVJrVVJERVlSSUlKQkxXT1Yya0VWRDRkQ2dTREhzNllCTmpRS0o4RWxFcnl5Z1Q5ZnhZRUJCeEN6YzRFQ2FMSUdRU3Bidm1KTmhvQWpna0FDUUNVQU9JQlRnRzVBaXdDbndMMkE0VUFNUmtVTVJnVUVFTTJHZ0ZKRlNJU1JEWWFBa2tWZ1hBU1JEWWFBMGtWZ1VFU1JEWWFCRWtrV1NVSVN3RVZFa1JYQWdBb1pFRUFMVElFSlE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJd2s0R0Nsa0VrUXhGaU1KT1JvQUttUVNSRXNEU3dOTEEwc0RpUDNUUmdKT0FreEpGU0lPUkNLdlRFc0JxMHNDRlNJT1JFNENxMUJNRmxBbkJFeFFzQ05ETmhvQlNTUlpKUWhMQVJVU1JGY0NBQ2hrUVFBdE1nUWxEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZakNUZ1lLV1FTUkRFV0l3azVHZ0FxWkJKRVNZaitoUlluQkV4UXNDTkROaG9CU1JVaUVrUTJHZ0pKSkZrbENFc0JGUkpFVndJQU5ob0RTUlVqRWtRa1V5aGtRUUF0TWdRbEQwUXpBQmdvWkJKRU13QUFNUUFTUkNsa1FRQVZNUllqQ1RnWUtXUVNSREVXSXdrNUdnQXFaQkpFU3dKTEFrc0NpUDNoU1JVaURrUWlyNnNuQkV4UXNDTkROaG9CU1JVaUVrUTJHZ0pKRllGd0VrUTJHZ05KRllGUUVrUTJHZ1JKSkZrbENFc0JGUkpFVndJQUtHUkJBQzB5QkNVUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaU1KT0JncFpCSkVNUllqQ1RrYUFDcGtFa1JMQTBzRFN3TkxBNGo4SEVZQ0kwTTJHZ0ZKRlNJU1JEWWFBa2tWZ1hBU1JEWWFBMGtWSWhKRU5ob0VTUlVpRWtRMkdnVkpKRmtsQ0VzQkZSSkVWd0lBS0dSQkFDMHlCQ1VQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNwa0VrUkxCRXNFU3dSTEJFc0VpUHMwU0NORE5ob0JTUlVpRWtRMkdnSkpGWUZ3RWtRMkdnTkpGU0lTUkRZYUJFa1ZJaEpFTmhvRlNTUlpKUWhMQVJVU1JGY0NBQ2hrUVFBdE1nUWxEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZakNUZ1lLV1FTUkRFV0l3azVHZ0FxWkJKRVN3UkxCRXNFU3dSTEJJajZma2dqUXpZYUFVa1ZJaEpFTmhvQ1NSV0JjQkpFTmhvRFNSVWlFa1FvWkVFQUxUSUVKUTlFTXdBWUtHUVNSRE1BQURFQUVrUXBaRUVBRlRFV0l3azRHQ2xrRWtReEZpTUpPUm9BS21RU1JFc0NTd0pMQW9qNnJFZ2pRellhQVVjQ0ZVc0JnWUFCV1VtQmhnRVNSRXNDVEVzQ1VpUlpnWWdCQ0VzQ2dZSUJXVWxMQWhKRVN3Tk1Td05TSkZrbENBaExBb0dFQVZsSlN3SVNSRThEVEVzRFVpUlpKUWdJRWtRMkdnSkpGWUVJRWtRWEtHUkJBQzB5QkNVUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaU1KT0JncFpCSkVNUllqQ1RrYUFDcGtFa1JLaVB2L1NDTkROaG9CU1JXQkNCSkVGellhQWtrVmdRZ1NSQmMyR2dOSkpGa2xDRXNCRlJKRVZ3SUFLR1FVUkNoUEEyY3BUd0puS2t4bkkwTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
