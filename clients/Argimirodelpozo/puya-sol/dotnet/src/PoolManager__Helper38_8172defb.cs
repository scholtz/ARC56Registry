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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper38_8172defb
{


    //
    // Helper contract 38 for PoolManager
    //
    public class PoolManager__Helper38Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper38Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class StepComputations : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceStartX96 { get; set; }

                public ulong TickNext { get; set; }

                public byte Initialized { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceNextX96 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountIn { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountOut { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeAmount { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 FeeGrowthGlobalX128 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceStartX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceStartX96.From(SqrtPriceStartX96);
                    ret.AddRange(vSqrtPriceStartX96.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickNext = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickNext.From(TickNext);
                    ret.AddRange(vTickNext.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vInitialized.From(Initialized);
                    ret.AddRange(vInitialized.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceNextX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceNextX96.From(SqrtPriceNextX96);
                    ret.AddRange(vSqrtPriceNextX96.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountIn.From(AmountIn);
                    ret.AddRange(vAmountIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountOut.From(AmountOut);
                    ret.AddRange(vAmountOut.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeAmount.From(FeeAmount);
                    ret.AddRange(vFeeAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeGrowthGlobalX128 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFeeGrowthGlobalX128.From(FeeGrowthGlobalX128);
                    ret.AddRange(vFeeGrowthGlobalX128.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StepComputations Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StepComputations();
                    uint count = 0;
                    var vSqrtPriceStartX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceStartX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceStartX96 = vSqrtPriceStartX96;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickNext = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickNext.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickNext = vTickNext.ToValue();
                    if (valueTickNext is ulong vTickNextValue) { ret.TickNext = vTickNextValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vInitialized.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialized = vInitialized.ToValue();
                    if (valueInitialized is byte vInitializedValue) { ret.Initialized = vInitializedValue; }
                    var vSqrtPriceNextX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceNextX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceNextX96 = vSqrtPriceNextX96;
                    var vAmountIn = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountIn = vAmountIn;
                    var vAmountOut = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountOut = vAmountOut;
                    var vFeeAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeAmount = vFeeAmount;
                    var vFeeGrowthGlobalX128 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFeeGrowthGlobalX128.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.FeeGrowthGlobalX128 = vFeeGrowthGlobalX128;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StepComputations);
                }
                public bool Equals(StepComputations? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StepComputations left, StepComputations right)
                {
                    return EqualityComparer<StepComputations>.Default.Equals(left, right);
                }
                public static bool operator !=(StepComputations left, StepComputations right)
                {
                    return !(left == right);
                }

            }

            public class SwapParams : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountSpecified { get; set; }

                public ulong TickSpacing { get; set; }

                public byte ZeroForOne { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceLimitX96 { get; set; }

                public ulong LpFeeOverride { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountSpecified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountSpecified.From(AmountSpecified);
                    ret.AddRange(vAmountSpecified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickSpacing.From(TickSpacing);
                    ret.AddRange(vTickSpacing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vZeroForOne.From(ZeroForOne);
                    ret.AddRange(vZeroForOne.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceLimitX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceLimitX96.From(SqrtPriceLimitX96);
                    ret.AddRange(vSqrtPriceLimitX96.Encode());
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

                public static SwapParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SwapParams();
                    uint count = 0;
                    var vAmountSpecified = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountSpecified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountSpecified = vAmountSpecified;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickSpacing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickSpacing = vTickSpacing.ToValue();
                    if (valueTickSpacing is ulong vTickSpacingValue) { ret.TickSpacing = vTickSpacingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vZeroForOne.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueZeroForOne = vZeroForOne.ToValue();
                    if (valueZeroForOne is byte vZeroForOneValue) { ret.ZeroForOne = vZeroForOneValue; }
                    var vSqrtPriceLimitX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceLimitX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceLimitX96 = vSqrtPriceLimitX96;
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

            public class SwapResult : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceX96 { get; set; }

                public ulong Tick { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Liquidity { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceX96.From(SqrtPriceX96);
                    ret.AddRange(vSqrtPriceX96.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTick = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTick.From(Tick);
                    ret.AddRange(vTick.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLiquidity.From(Liquidity);
                    ret.AddRange(vLiquidity.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SwapResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SwapResult();
                    uint count = 0;
                    var vSqrtPriceX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceX96 = vSqrtPriceX96;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTick = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTick.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTick = vTick.ToValue();
                    if (valueTick is ulong vTickValue) { ret.Tick = vTickValue; }
                    var vLiquidity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Liquidity = vLiquidity;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SwapResult);
                }
                public bool Equals(SwapResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SwapResult left, SwapResult right)
                {
                    return EqualityComparer<SwapResult>.Default.Equals(left, right);
                }
                public static bool operator !=(SwapResult left, SwapResult right)
                {
                    return !(left == right);
                }

            }

            public class Tuple : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SwapDelta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountToProtocol { get; set; }

                public ulong SwapFee { get; set; }

                public Structs.SwapResult Result { get; set; } = new Structs.SwapResult();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSwapDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSwapDelta.From(SwapDelta);
                    ret.AddRange(vSwapDelta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToProtocol = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountToProtocol.From(AmountToProtocol);
                    ret.AddRange(vAmountToProtocol.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSwapFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSwapFee.From(SwapFee);
                    ret.AddRange(vSwapFee.Encode());
                    ret.AddRange(Result.ToByteArray());
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
                    var vSwapDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSwapDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SwapDelta = vSwapDelta;
                    var vAmountToProtocol = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountToProtocol.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountToProtocol = vAmountToProtocol;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSwapFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSwapFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSwapFee = vSwapFee.ToValue();
                    if (valueSwapFee is ulong vSwapFeeValue) { ret.SwapFee = vSwapFeeValue; }
                    ret.Result = Structs.SwapResult.Parse(queue.ToArray());
                    { var consumedResult = ret.Result.ToByteArray().Length; for (int i = 0; i < consumedResult && queue.Count > 0; i++) { queue.Dequeue(); } }
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
        ///
        ///</summary>
        /// <param name="self"> State</param>
        /// <param name="params"> SwapParams</param>
        /// <param name="amountCalculated"> </param>
        /// <param name="amountSpecifiedRemaining"> </param>
        /// <param name="amountToProtocol"> </param>
        /// <param name="result"> SwapResult</param>
        /// <param name="slot0Start"> </param>
        /// <param name="step"> StepComputations</param>
        /// <param name="swapDelta"> </param>
        /// <param name="swapFee"> </param>
        /// <param name="zeroForOne"> </param>
        public async Task<Structs.Tuple> PoolSwapChunk2(Structs.State self, Structs.SwapParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountCalculated, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountSpecifiedRemaining, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountToProtocol, Structs.SwapResult result, byte[] slot0Start, Structs.StepComputations step, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 swapDelta, ulong swapFee, bool zeroForOne, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 236, 19, 1 };
            var slot0StartAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); slot0StartAbi.From(slot0Start);
            var swapFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); swapFeeAbi.From(swapFee);
            var zeroForOneAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); zeroForOneAbi.From(zeroForOne);

            var result = await base.CallApp(new List<object> { abiHandle, self, @params, amountCalculated, amountSpecifiedRemaining, amountToProtocol, result, slot0StartAbi, step, swapDelta, swapFeeAbi, zeroForOneAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PoolSwapChunk2_Transactions(Structs.State self, Structs.SwapParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountCalculated, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountSpecifiedRemaining, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountToProtocol, Structs.SwapResult result, byte[] slot0Start, Structs.StepComputations step, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 swapDelta, ulong swapFee, bool zeroForOne, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 236, 19, 1 };
            var slot0StartAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); slot0StartAbi.From(slot0Start);
            var swapFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); swapFeeAbi.From(swapFee);
            var zeroForOneAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); zeroForOneAbi.From(zeroForOne);

            return await base.MakeTransactionList(new List<object> { abiHandle, self, @params, amountCalculated, amountSpecifiedRemaining, amountToProtocol, result, slot0StartAbi, step, swapDelta, swapFeeAbi, zeroForOneAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Donates the given amount of currency0 and currency1 to the pool
        ///</summary>
        /// <param name="state"> State</param>
        /// <param name="amount0"> </param>
        /// <param name="amount1"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PoolDonate(Structs.State state, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 4, 193, 202 };

            var result = await base.CallApp(new List<object> { abiHandle, state, amount0, amount1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PoolDonate_Transactions(Structs.State state, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 4, 193, 202 };

            return await base.MakeTransactionList(new List<object> { abiHandle, state, amount0, amount1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Computes the sqrt price target for the next swap step
        /// @param zeroForOne The direction of the swap, true for currency0 to currency1, false for currency1 to currency0
        /// @param sqrtPriceNextX96 The Q64.96 sqrt price for the next initialized tick
        /// @param sqrtPriceLimitX96 The Q64.96 sqrt price limit. If zero for one, the price cannot be less than this value
        /// after the swap. If one for zero, the price cannot be greater than this value after the swap
        /// @return sqrtPriceTargetX96 The price target for the next swap step
        ///</summary>
        /// <param name="zeroForOne"> </param>
        /// <param name="sqrtPriceNextX96"> </param>
        /// <param name="sqrtPriceLimitX96"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SwapMathGetSqrtPriceTarget(bool zeroForOne, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceNextX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceLimitX96, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 103, 180, 43 };
            var zeroForOneAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); zeroForOneAbi.From(zeroForOne);

            var result = await base.SimApp(new List<object> { abiHandle, zeroForOneAbi, sqrtPriceNextX96, sqrtPriceLimitX96 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> SwapMathGetSqrtPriceTarget_Transactions(bool zeroForOne, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceNextX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceLimitX96, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 103, 180, 43 };
            var zeroForOneAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); zeroForOneAbi.From(zeroForOne);

            return await base.MakeTransactionList(new List<object> { abiHandle, zeroForOneAbi, sqrtPriceNextX96, sqrtPriceLimitX96 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="currency"> </param>
        /// <param name="other"> </param>
        public async Task<bool> GreaterThanOrEqualTo(Algorand.Address currency, Algorand.Address other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 19, 13, 243 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);

            var result = await base.SimApp(new List<object> { abiHandle, currencyAbi, otherAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GreaterThanOrEqualTo_Transactions(Algorand.Address currency, Algorand.Address other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 19, 13, 243 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);

            return await base.MakeTransactionList(new List<object> { abiHandle, currencyAbi, otherAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<bool> Neq(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 30, 214, 209 };

            var result = await base.SimApp(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Neq_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 a, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 30, 214, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle, a, b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjM4IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAzOCBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU3RhdGUiOlt7Im5hbWUiOiJzbG90MCIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJmZWVHcm93dGhHbG9iYWwwWDEyOCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmVlR3Jvd3RoR2xvYmFsMVgxMjgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImxpcXVpZGl0eSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoidGlja3MiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidGlja0JpdG1hcCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJwb3NpdGlvbnMiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJTdGVwQ29tcHV0YXRpb25zIjpbeyJuYW1lIjoic3FydFByaWNlU3RhcnRYOTYiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tOZXh0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImluaXRpYWxpemVkIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoic3FydFByaWNlTmV4dFg5NiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiYW1vdW50SW4iLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImFtb3VudE91dCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmVlQW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmZWVHcm93dGhHbG9iYWxYMTI4IiwidHlwZSI6InVpbnQyNTYifV0sIlN3YXBQYXJhbXMiOlt7Im5hbWUiOiJhbW91bnRTcGVjaWZpZWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Inplcm9Gb3JPbmUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJzcXJ0UHJpY2VMaW1pdFg5NiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoibHBGZWVPdmVycmlkZSIsInR5cGUiOiJ1aW50NjQifV0sIlN3YXBSZXN1bHQiOlt7Im5hbWUiOiJzcXJ0UHJpY2VYOTYiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2siLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlxdWlkaXR5IiwidHlwZSI6InVpbnQyNTYifV0sInR1cGxlIjpbeyJuYW1lIjoic3dhcERlbHRhIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJhbW91bnRUb1Byb3RvY29sIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJzd2FwRmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlc3VsdCIsInR5cGUiOiJTd2FwUmVzdWx0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IlBvb2wuc3dhcF9fY2h1bmtfMiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LGJ5dGVbXSxieXRlW10sYnl0ZVtdKSIsInN0cnVjdCI6IlN0YXRlIiwibmFtZSI6InNlbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50MjU2LHVpbnQ2NCx1aW50OCx1aW50MjU2LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTd2FwUGFyYW1zIiwibmFtZSI6InBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudENhbGN1bGF0ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRTcGVjaWZpZWRSZW1haW5pbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRUb1Byb3RvY29sIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDI1Nix1aW50NjQsdWludDI1NikiLCJzdHJ1Y3QiOiJTd2FwUmVzdWx0IiwibmFtZSI6InJlc3VsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbG90MFN0YXJ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDI1Nix1aW50NjQsdWludDgsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlN0ZXBDb21wdXRhdGlvbnMiLCJuYW1lIjoic3RlcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN3YXBEZWx0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3dhcEZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Inplcm9Gb3JPbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50NjQsKHVpbnQyNTYsdWludDY0LHVpbnQyNTYpKSIsInN0cnVjdCI6InR1cGxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUG9vbC5kb25hdGUiLCJkZXNjIjoiQG5vdGljZSBEb25hdGVzIHRoZSBnaXZlbiBhbW91bnQgb2YgY3VycmVuY3kwIGFuZCBjdXJyZW5jeTEgdG8gdGhlIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NixieXRlW10sYnl0ZVtdLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJTdGF0ZSIsIm5hbWUiOiJzdGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlN3YXBNYXRoLmdldFNxcnRQcmljZVRhcmdldCIsImRlc2MiOiJAbm90aWNlIENvbXB1dGVzIHRoZSBzcXJ0IHByaWNlIHRhcmdldCBmb3IgdGhlIG5leHQgc3dhcCBzdGVwXG4gQHBhcmFtIHplcm9Gb3JPbmUgVGhlIGRpcmVjdGlvbiBvZiB0aGUgc3dhcCwgdHJ1ZSBmb3IgY3VycmVuY3kwIHRvIGN1cnJlbmN5MSwgZmFsc2UgZm9yIGN1cnJlbmN5MSB0byBjdXJyZW5jeTBcbiBAcGFyYW0gc3FydFByaWNlTmV4dFg5NiBUaGUgUTY0Ljk2IHNxcnQgcHJpY2UgZm9yIHRoZSBuZXh0IGluaXRpYWxpemVkIHRpY2tcbiBAcGFyYW0gc3FydFByaWNlTGltaXRYOTYgVGhlIFE2NC45NiBzcXJ0IHByaWNlIGxpbWl0LiBJZiB6ZXJvIGZvciBvbmUsIHRoZSBwcmljZSBjYW5ub3QgYmUgbGVzcyB0aGFuIHRoaXMgdmFsdWVcbiBhZnRlciB0aGUgc3dhcC4gSWYgb25lIGZvciB6ZXJvLCB0aGUgcHJpY2UgY2Fubm90IGJlIGdyZWF0ZXIgdGhhbiB0aGlzIHZhbHVlIGFmdGVyIHRoZSBzd2FwXG4gQHJldHVybiBzcXJ0UHJpY2VUYXJnZXRYOTYgVGhlIHByaWNlIHRhcmdldCBmb3IgdGhlIG5leHQgc3dhcCBzdGVwIiwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ6ZXJvRm9yT25lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3FydFByaWNlTmV4dFg5NiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNxcnRQcmljZUxpbWl0WDk2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JlYXRlclRoYW5PckVxdWFsVG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbmN5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3RoZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1NzRdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjcsMTE5NywxMjk5LDEzOTAsMTQ3NV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODEsMTIxMSwxMzEzLDE0MDQsMTQ4OV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc0LDEyMDQsMTMwNiwxMzk3LDE0ODJdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTYsMTIyNiwxMzI4LDE0MTksMTUwNF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDgsMTIzOCwxMzQwLDE0MzEsMTUxNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjMsODQ1LDg2NiwxMTIzLDExNDUsMTE2NiwxNTYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcxLDExNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgU3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgU3RlcENvbXB1dGF0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBTd2FwUGFyYW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFN3YXBSZXN1bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTUsMTI3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyMSwxMzcyLDEzODBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg4LDg5Niw5MDUsOTM3LDExNzksMTE4NywxMjgxLDEyODksMTQ1NywxNDY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0NiwxNTQzLDE1NTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTUsMTExNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDQgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzcsMTEzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDUgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTgsMTE1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDYgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTAsODMyLDg1MywxMTEwLDExMzIsMTE1M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDEsMzgwLDEwNDcsMTA1OCwxMjUzLDEzNTRdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMF0sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak00TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURNeUlERWdNQ0F5SURFek1pQXhNekFnTVRJNElERXpOQW9nSUNBZ1lubDBaV05pYkc5amF5QWlieUlnSW5BaUlEQjRJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lDSnpJaUF3ZURFMU1XWTNZemMxSURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlnTUhnd01TQXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TURnMklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNMbVJ2Ym1GMFpTaHpkR0YwWlRvZ1lubDBaWE1zSUdGdGIzVnVkREE2SUdKNWRHVnpMQ0JoYlc5MWJuUXhPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncFFiMjlzTG1SdmJtRjBaVG9LSUNBZ0lIQnliM1J2SURNZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRkJ2YjJ3dVpHOXVZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCRGRYTjBiMjFTWlhabGNuUXVjbVYyWlhKMFYybDBhQW9LVUc5dmJDNWtiMjVoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZTVzUwTVRJNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZTVzUwTVRJNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdZMkZzYkhOMVlpQjBiMEpoYkdGdVkyVkVaV3gwWVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaVBnb2dJQ0FnWW5vZ1VHOXZiQzVrYjI1aGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHTmhiR3h6ZFdJZ1ZXNXpZV1psVFdGMGFDNXphVzF3YkdWTmRXeEVhWFlLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZeUExSUM4dklERXpNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZeUEySUM4dklERXlPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd01EZzJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTnlBdkx5QXhNelFLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVE1LQ2xCdmIyd3VaRzl1WVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSStDaUFnSUNCaWVpQlFiMjlzTG1SdmJtRjBaVjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1ZXNXpZV1psVFdGMGFDNXphVzF3YkdWTmRXeEVhWFlLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZeUExSUM4dklERXpNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZeUEySUM4dklERXlPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd01EZzJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTnlBdkx5QXhNelFLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVE1LQ2xCdmIyd3VaRzl1WVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxOaFptVkRZWE4wTG5SdlNXNTBNVEk0S0RFcFh6RW9lRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUWVdabFEyRnpkQzUwYjBsdWRERXlPRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqNDlDaUFnSUNCaWVpQlRZV1psUTJGemRDNTBiMGx1ZERFeU9GOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnS0NsTmhabVZEWVhOMExuUnZTVzUwTVRJNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbE4zWVhCTllYUm9MbWRsZEZOeGNuUlFjbWxqWlZSaGNtZGxkQ2g2WlhKdlJtOXlUMjVsT2lCMWFXNTBOalFzSUhOeGNuUlFjbWxqWlU1bGVIUllPVFk2SUdKNWRHVnpMQ0J6Y1hKMFVISnBZMlZNYVcxcGRGZzVOam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUZDJGd1RXRjBhQzVuWlhSVGNYSjBVSEpwWTJWVVlYSm5aWFE2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lqd0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSmVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWw0S0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlYZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxWdWMyRm1aVTFoZEdndWMybHRjR3hsVFhWc1JHbDJLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeXdnWkdWdWIyMXBibUYwYjNJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1ZXNXpZV1psVFdGMGFDNXphVzF3YkdWTmRXeEVhWFk2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaThLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1bmNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWJ5aGpkWEp5Wlc1amVUb2dZbmwwWlhNc0lHOTBhR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwbmNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWJ6b0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSStQUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTG01bGNTaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYm1WeE9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpRTlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1ZEc5Q1lXeGhibU5sUkdWc2RHRW9YMkZ0YjNWdWREQTZJR0o1ZEdWekxDQmZZVzF2ZFc1ME1Ub2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDBiMEpoYkdGdVkyVkVaV3gwWVRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlKZ29nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVUWVdabFEyRnpkQzUwYjBsdWRERXlPQ2d4S1Y4d0tIZzZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxOaFptVkRZWE4wTG5SdlNXNTBNVEk0S0RFcFh6QTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0loUFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsTmhabVZEWVhOMExuUnZTVzUwTVRJNEtERXBYekJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUVOMWMzUnZiVkpsZG1WeWRDNXlaWFpsY25SWGFYUm9DZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVUyRm1aVU5oYzNRdWRHOUpiblF4TWpnb01TbGZNRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa04xYzNSdmJWSmxkbVZ5ZEM1eVpYWmxjblJYYVhSb0tERXBLSE5sYkdWamRHOXlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHVnljaUF2THlCeVpYWmxjblFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pNNExsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh6b0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQmZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYMTlmWDJKaGNtVmZZM0psWVhSbFgxOUFNVElLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE5qWldNeE16QXhJREI0TVRZd05HTXhZMkVnTUhnNVlUWTNZalF5WWlBd2VETXpNVE13WkdZeklEQjRObVF4WldRMlpERWdNSGhoT1RabFpqazRPU0F2THlCdFpYUm9iMlFnSWxCdmIyd3VjM2RoY0Y5ZlkyaDFibXRmTWlnb2RXbHVkRGhiTXpKZExIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEdKNWRHVmJYU3hpZVhSbFcxMHNZbmwwWlZ0ZEtTd29kV2x1ZERJMU5peDFhVzUwTmpRc2RXbHVkRGdzZFdsdWRESTFOaXgxYVc1ME5qUXBMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxDaDFhVzUwTWpVMkxIVnBiblEyTkN4MWFXNTBNalUyS1N4aWVYUmxXek15WFN3b2RXbHVkREkxTml4MWFXNTBOalFzZFdsdWREZ3NkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1N4MWFXNTBNalUyTEhWcGJuUTJOQ3hpYjI5c0tTaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkRFkwTENoMWFXNTBNalUyTEhWcGJuUTJOQ3gxYVc1ME1qVTJLU2tpTENCdFpYUm9iMlFnSWxCdmIyd3VaRzl1WVhSbEtDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc1lubDBaVnRkTEdKNWRHVmJYU3hpZVhSbFcxMHBMSFZwYm5ReU5UWXNkV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSlRkMkZ3VFdGMGFDNW5aWFJUY1hKMFVISnBZMlZVWVhKblpYUW9ZbTl2YkN4MWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWjNKbFlYUmxjbFJvWVc1UGNrVnhkV0ZzVkc4b1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbTVsY1NoMWFXNTBNalUyTEhWcGJuUXlOVFlwWW05dmJDSXNJRzFsZEdodlpDQWlYMTlwYm1sMFgxOG9kV2x1ZERZMExIVnBiblEyTkN4aWVYUmxXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRkJ2YjJ3dWMzZGhjRjlmWTJoMWJtdGZNaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbEJ2YjJ3dVpHOXVZWFJsVzNKdmRYUnBibWRkSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNemd1VTNkaGNFMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFZHRnlaMlYwVzNKdmRYUnBibWRkSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNemd1WjNKbFlYUmxjbFJvWVc1UGNrVnhkV0ZzVkc5YmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl6T0M1dVpYRmJjbTkxZEdsdVoxMGdYMTlwYm1sMFgxOEtJQ0FnSUdWeWNnb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRREV5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbEJ2YjJ3dWMzZGhjRjlmWTJoMWJtdGZNbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2xCdmIyd3VjM2RoY0Y5ZlkyaDFibXRmTWpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBMklDOHZJREV5T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBM0lDOHZJREV6TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0EwSUc5bUlDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV6TmdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTlNBdkx5QXhNekFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRFVnYjJZZ0tIVnBiblE0V3pNeVhTeDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QTBJQzh2SURFek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ05pQnZaaUFvZFdsdWREaGJNekpkTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJUZEdGMFpRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGTjNZWEJRWVhKaGJYTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ056SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZOM1lYQlNaWE4xYkhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURjS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURnS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlNREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGTjBaWEJEYjIxd2RYUmhkR2x2Ym5NS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklGQnZiMnd1YzNkaGNGOWZZMmgxYm10Zk1sOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklGQnZiMnd1YzNkaGNGOWZZMmgxYm10Zk1sOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dwUWIyOXNMbk4zWVhCZlgyTm9kVzVyWHpKZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lqd0tJQ0FnSUdScFp5QXlDaUFnSUNBaFBRb2dJQ0FnWW5vZ1VHOXZiQzV6ZDJGd1gxOWphSFZ1YTE4eVgyVnNjMlZmWW05a2VVQXhNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbE5oWm1WRFlYTjBMblJ2U1c1ME1USTRLREVwWHpBS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ053b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1VFlXWmxRMkZ6ZEM1MGIwbHVkREV5T0NneEtWOHdDaUFnSUNCallXeHNjM1ZpSUhSdlFtRnNZVzVqWlVSbGJIUmhDZ3BRYjI5c0xuTjNZWEJmWDJOb2RXNXJYekpmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tVRzl2YkM1emQyRndYMTlqYUhWdWExOHlYMlZzYzJWZlltOWtlVUF4TXpvS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ05nb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1VFlXWmxRMkZ6ZEM1MGIwbHVkREV5T0NneEtWOHdDaUFnSUNCa2FXY2dOd29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVMkZtWlVOaGMzUXVkRzlKYm5ReE1qZ29NU2xmTUFvZ0lDQWdZMkZzYkhOMVlpQjBiMEpoYkdGdVkyVkVaV3gwWVFvZ0lDQWdZaUJRYjI5c0xuTjNZWEJmWDJOb2RXNXJYekpmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TXpndVVHOXZiQzVrYjI1aGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbEJ2YjJ3dVpHOXVZWFJsVzNKdmRYUnBibWRkT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5SaklEWWdMeThnTVRJNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEY2dMeThnTVRNMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURRZ2IyWWdLSFZwYm5RNFd6TXlYU3gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRNMkNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBMUlDOHZJREV6TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTlNCdlppQW9kV2x1ZERoYk16SmRMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJRFFnTHk4Z01UTXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQTJJRzltSUNoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3BDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZOMFlYUmxDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbEJ2YjJ3dVpHOXVZWFJsVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXpPQzVRYjI5c0xtUnZibUYwWlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbEJ2YjJ3dVpHOXVZWFJsVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdVRzl2YkM1a2IyNWhkR1VLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak00TGxOM1lYQk5ZWFJvTG1kbGRGTnhjblJRY21salpWUmhjbWRsZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TXpndVUzZGhjRTFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxWR0Z5WjJWMFczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU16Z3VVM2RoY0UxaGRHZ3VaMlYwVTNGeWRGQnlhV05sVkdGeVoyVjBXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJek9DNVRkMkZ3VFdGMGFDNW5aWFJUY1hKMFVISnBZMlZVWVhKblpYUmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl6T0M1VGQyRndUV0YwYUM1blpYUlRjWEowVUhKcFkyVlVZWEpuWlhSYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJUZDJGd1RXRjBhQzVuWlhSVGNYSjBVSEpwWTJWVVlYSm5aWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl6T0M1bmNtVmhkR1Z5VkdoaGJrOXlSWEYxWVd4VWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU16Z3VaM0psWVhSbGNsUm9ZVzVQY2tWeGRXRnNWRzliY205MWRHbHVaMTA2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbWR5WldGMFpYSlVhR0Z1VDNKRmNYVmhiRlJ2VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXpPQzVuY21WaGRHVnlWR2hoYms5eVJYRjFZV3hVYjF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbWR5WldGMFpYSlVhR0Z1VDNKRmNYVmhiRlJ2VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUjFjRElLSUNBZ0lHTmhiR3h6ZFdJZ1ozSmxZWFJsY2xSb1lXNVBja1Z4ZFdGc1ZHOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTTRMbTVsY1Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TXpndWJtVnhXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXpPQzV1WlhGYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak00TG01bGNWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak00TG01bGNWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBeUNpQWdJQ0JqWVd4c2MzVmlJRzVsY1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TXpndVgxOXBibWwwWDE5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZYMmx1YVhSZlh6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dZV3h5WldGa2VTQnBibWwwYVdGc2FYcGxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pNNExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFJSUFFQUFvUUJnZ0dBQVlZQkpnc0Jid0Z3QUNFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCY3dRVkgzeDFFUC8vLy8vLy8vLy8vLy8vLy8vLy8vOEJBUkVCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlBaGhULy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8wSUNYSW9EQWlTTC9WZGdJRWtrRmtsT0FxaEJBQVFxaUFKQmkvNklBWDBxVEtHTC80Z0JkU3BNb1lnQjVvd0FpLzZMQXFWQkFLbUwvVmNnSUl2K0p3aUxBVWxPQklnQnE2QkpGU0lPUkNLdnE0djlWMEFnaS8waEJGbUwvUldML1VzQ1R3SlNWd0lBaS8xWEFDQ0wvU0VGV1l2OVN3RlBCVkpYQWdDTC9TRUdXWXY5VEU4RFVsY0NBRThDVHdWUVR3UlFUd1JRU3dFVkZsY0dBazhDVUV3bkNWQkxBUlVoQndoTEF4VVdWd1lDVHdSUVN3RVdWd1lDVHdOTVVFc0JGVThEQ0VzRUZSWlhCZ0pQQlZCTUZsY0dBazhDVEZCUEExQlBBbEJNVUl6OWkvK0xBcVZCQUt1TC9WY2dJSXY5VjBBZ2kvOG5DSXNCaUFENG9Fa1ZJZzVFSXErcmkvMVhZQ0NML1NFRVdZdjlGWXY5U3dKUEFsSlhBZ0NML1ZjQUlJdjlJUVZaaS8xTEFVOEZVbGNDQUl2OUlRWlppLzFNVHdOU1Z3SUFUd0pQQmxCUEJWQlBCRkJMQVJVV1Z3WUNUd0pRVENjSlVFc0JGU0VIQ0VzREZSWlhCZ0pQQkZCTEFSWlhCZ0pQQTB4UVN3RVZUd01JU3dRVkZsY0dBazhGVUV3V1Z3WUNUd0pNVUU4RFVFOENVRXhRalAyTEFJdjlqQUdNQUltS0FRR0wvNEFRZ0FBQUFBQUFBQUFBQUFBQUFBQUFBS2RCQUFRcWlBQ2dpLzhuQnF5SmlnTUJpLzRuQ3F5TS9vdi9Kd3FzalArTC9vdi9wQ29uQjA4Q1RTb25CNHY5VFNjSHJLMkwvb3YvcmFNcnFvdi9yWW1LQXdHTC9ZditveXVxaS8raWlZb0NBWXYraS8rbmlZb0NBWXYraS8rcGlZb0NBWXYrZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBS01ycWljR2kvK3NxNG1LQVFHTC95Y0dyRW1MLzZsQkFBUXFpQUFFaXdCTWlZb0JBQUF4RzBFQU9URVpGRVF4R0VTQ0JnUTg3Qk1CQkJZRXdjb0VtbWUwS3dRekV3M3pCRzBlMXRFRXFXNzVpVFlhQUk0R0FBa0JOQUhZQWowQ2tnTG5BREVaRkRFWUZCQkROaG9CU1JWTEFTRUdXVWtoQnhKRVN3Sk1Td0pTSkZtQmlBRUlTd0loQlZsSlN3SVNSRXNEVEVzRFVpUlpKUWdJU3dJaEJGbEpTd0lTUkU4RFRFc0RVaVJaSlFnSUVrUTJHZ0pKRllGUkVrUTJHZ05KRlNJU1JEWWFCRWtWSWhKRU5ob0ZTUlZKSWhKRU5ob0dTUldCU0JKRU5ob0hGU0lTUkRZYUNCV0J5UUVTUkRZYUNSVWlFa1EyR2dwSkZZRUlFa1FYTmhvTFNSVWpFa1FrVXloa1FRQXVNZ1FsRDBRekFCZ29aQkpFTXdBQU1RQVNSQ2xrUVFBV01SWWpDVGdZS1dRU1JERVdJd2s1R2dBbkJHUVNSRXNIVndBZ1NTUVdwRXNDRTBFQU4wc0hpUDY3VEN1Z1N3ZWhLNnFJL3JDSS9ueEpGU0lPUkNLdlRFc0JxMHNGSWc1RVN3WlBBcXRRU3dJV1VFc0RVQ2NGVEZDd0kwTXJvRXNHb1N1cWlQNS9Td2VJL25xSS9rWkMvOGMyR2dGSEFoVkxBU0VHV1VraEJ4SkVTd0pNU3dKU0pGbUJpQUVJU3dJaEJWbEpTd0lTUkVzRFRFc0RVaVJaSlFnSVN3SWhCRmxKU3dJU1JFOERURXNEVWlSWkpRZ0lFa1EyR2dKSkZTSVNSRFlhQTBrVkloSkVLR1JCQUM0eUJDVVBSRE1BR0Noa0VrUXpBQUF4QUJKRUtXUkJBQll4RmlNSk9CZ3BaQkpFTVJZakNUa2FBQ2NFWkJKRVN3SkxBa3NDaVB1ZlNFa1ZJZzVFSXErckp3Vk1VTEFqUXpZYUFVa1ZJeEpFSkZNMkdnSkpGU0lTUkRZYUEwa1ZJaEpFS0dSQkFDNHlCQ1VQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJZeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNjRVpCSkVTd0pMQWtzQ2lQejNTUlVpRGtRaXI2c25CVXhRc0NORE5ob0JTUlVpRWtRMkdnSkpGU0lTUkNoa1FRQXVNZ1FsRDBRekFCZ29aQkpFTXdBQU1RQVNSQ2xrUVFBV01SWWpDVGdZS1dRU1JERVdJd2s1R2dBbkJHUVNSRXFJL09HQUFRQWtUd0pVSndWTVVMQWpRellhQVVrVkloSkVOaG9DU1JVaUVrUW9aRUVBTGpJRUpROUVNd0FZS0dRU1JETUFBREVBRWtRcFpFRUFGakVXSXdrNEdDbGtFa1F4RmlNSk9Sb0FKd1JrRWtSS2lQeVZnQUVBSkU4Q1ZDY0ZURkN3STBNMkdnRkpGWUVJRWtRWE5ob0NTUldCQ0JKRUZ6WWFBMGtrV1NVSVN3RVZFa1JYQWdBb1pCUkVLRThEWnlsUEFtY25CRXhuSTBNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
