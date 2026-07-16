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

namespace Arc56.Generated.akita_protocol.akita_sc.PluginDex_235232e5
{


    public class PluginDexProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PluginDexProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DexHookInput : AVMObjectType
            {
                public ulong AssetIn { get; set; }

                public ulong AssetOut { get; set; }

                public ulong AmountIn { get; set; }

                public ulong AmountOut { get; set; }

                public ulong FeeBps { get; set; }

                public ulong Price { get; set; }

                public ulong Liquidity { get; set; }

                public ulong Scratch { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetIn.From(AssetIn);
                    ret.AddRange(vAssetIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetOut.From(AssetOut);
                    ret.AddRange(vAssetOut.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountIn.From(AmountIn);
                    ret.AddRange(vAmountIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountOut.From(AmountOut);
                    ret.AddRange(vAmountOut.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBps.From(FeeBps);
                    ret.AddRange(vFeeBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLiquidity.From(Liquidity);
                    ret.AddRange(vLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScratch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScratch.From(Scratch);
                    ret.AddRange(vScratch.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DexHookInput Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DexHookInput();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetIn = vAssetIn.ToValue();
                    if (valueAssetIn is ulong vAssetInValue) { ret.AssetIn = vAssetInValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetOut = vAssetOut.ToValue();
                    if (valueAssetOut is ulong vAssetOutValue) { ret.AssetOut = vAssetOutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountIn = vAmountIn.ToValue();
                    if (valueAmountIn is ulong vAmountInValue) { ret.AmountIn = vAmountInValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountOut = vAmountOut.ToValue();
                    if (valueAmountOut is ulong vAmountOutValue) { ret.AmountOut = vAmountOutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBps = vFeeBps.ToValue();
                    if (valueFeeBps is ulong vFeeBpsValue) { ret.FeeBps = vFeeBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidity = vLiquidity.ToValue();
                    if (valueLiquidity is ulong vLiquidityValue) { ret.Liquidity = vLiquidityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScratch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScratch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScratch = vScratch.ToValue();
                    if (valueScratch is ulong vScratchValue) { ret.Scratch = vScratchValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DexHookInput);
                }
                public bool Equals(DexHookInput? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DexHookInput left, DexHookInput right)
                {
                    return EqualityComparer<DexHookInput>.Default.Equals(left, right);
                }
                public static bool operator !=(DexHookInput left, DexHookInput right)
                {
                    return !(left == right);
                }

            }

            public class DexHookOutput : AVMObjectType
            {
                public ulong AmountIn { get; set; }

                public ulong AmountOut { get; set; }

                public ulong FeeBps { get; set; }

                public ulong Price { get; set; }

                public ulong Liquidity { get; set; }

                public ulong Scratch { get; set; }

                public ulong Flags { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountIn.From(AmountIn);
                    ret.AddRange(vAmountIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountOut.From(AmountOut);
                    ret.AddRange(vAmountOut.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBps.From(FeeBps);
                    ret.AddRange(vFeeBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLiquidity.From(Liquidity);
                    ret.AddRange(vLiquidity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScratch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScratch.From(Scratch);
                    ret.AddRange(vScratch.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFlags.From(Flags);
                    ret.AddRange(vFlags.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DexHookOutput Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DexHookOutput();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountIn = vAmountIn.ToValue();
                    if (valueAmountIn is ulong vAmountInValue) { ret.AmountIn = vAmountInValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountOut = vAmountOut.ToValue();
                    if (valueAmountOut is ulong vAmountOutValue) { ret.AmountOut = vAmountOutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBps = vFeeBps.ToValue();
                    if (valueFeeBps is ulong vFeeBpsValue) { ret.FeeBps = vFeeBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLiquidity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidity = vLiquidity.ToValue();
                    if (valueLiquidity is ulong vLiquidityValue) { ret.Liquidity = vLiquidityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScratch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScratch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScratch = vScratch.ToValue();
                    if (valueScratch is ulong vScratchValue) { ret.Scratch = vScratchValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFlags.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlags = vFlags.ToValue();
                    if (valueFlags is ulong vFlagsValue) { ret.Flags = vFlagsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DexHookOutput);
                }
                public bool Equals(DexHookOutput? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DexHookOutput left, DexHookOutput right)
                {
                    return EqualityComparer<DexHookOutput>.Default.Equals(left, right);
                }
                public static bool operator !=(DexHookOutput left, DexHookOutput right)
                {
                    return !(left == right);
                }

            }

            public class PluginDexMbrData : AVMObjectType
            {
                public ulong Pool { get; set; }

                public ulong HookCount { get; set; }

                public ulong PoolHook { get; set; }

                public ulong Total { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPool.From(Pool);
                    ret.AddRange(vPool.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHookCount.From(HookCount);
                    ret.AddRange(vHookCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolHook = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolHook.From(PoolHook);
                    ret.AddRange(vPoolHook.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotal.From(Total);
                    ret.AddRange(vTotal.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PluginDexMbrData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PluginDexMbrData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePool = vPool.ToValue();
                    if (valuePool is ulong vPoolValue) { ret.Pool = vPoolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHookCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHookCount = vHookCount.ToValue();
                    if (valueHookCount is ulong vHookCountValue) { ret.HookCount = vHookCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolHook = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolHook.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolHook = vPoolHook.ToValue();
                    if (valuePoolHook is ulong vPoolHookValue) { ret.PoolHook = vPoolHookValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotal = vTotal.ToValue();
                    if (valueTotal is ulong vTotalValue) { ret.Total = vTotalValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PluginDexMbrData);
                }
                public bool Equals(PluginDexMbrData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PluginDexMbrData left, PluginDexMbrData right)
                {
                    return EqualityComparer<PluginDexMbrData>.Default.Equals(left, right);
                }
                public static bool operator !=(PluginDexMbrData left, PluginDexMbrData right)
                {
                    return !(left == right);
                }

            }

            public class PoolHookCountKey : AVMObjectType
            {
                public ulong PoolId { get; set; }

                public ulong HookPoint { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolId.From(PoolId);
                    ret.AddRange(vPoolId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookPoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHookPoint.From(HookPoint);
                    ret.AddRange(vHookPoint.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolHookCountKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolHookCountKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolId = vPoolId.ToValue();
                    if (valuePoolId is ulong vPoolIdValue) { ret.PoolId = vPoolIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookPoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHookPoint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHookPoint = vHookPoint.ToValue();
                    if (valueHookPoint is ulong vHookPointValue) { ret.HookPoint = vHookPointValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolHookCountKey);
                }
                public bool Equals(PoolHookCountKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolHookCountKey left, PoolHookCountKey right)
                {
                    return EqualityComparer<PoolHookCountKey>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolHookCountKey left, PoolHookCountKey right)
                {
                    return !(left == right);
                }

            }

            public class PoolHookInfo : AVMObjectType
            {
                public ulong App { get; set; }

                public bool Enabled { get; set; }

                public ulong Flags { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vEnabled.From(Enabled);
                    ret.AddRange(vEnabled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFlags.From(Flags);
                    ret.AddRange(vFlags.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolHookInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolHookInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vEnabled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEnabled = vEnabled.ToValue();
                    if (valueEnabled is bool vEnabledValue) { ret.Enabled = vEnabledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFlags.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlags = vFlags.ToValue();
                    if (valueFlags is ulong vFlagsValue) { ret.Flags = vFlagsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolHookInfo);
                }
                public bool Equals(PoolHookInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolHookInfo left, PoolHookInfo right)
                {
                    return EqualityComparer<PoolHookInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolHookInfo left, PoolHookInfo right)
                {
                    return !(left == right);
                }

            }

            public class PoolHookKey : AVMObjectType
            {
                public ulong PoolId { get; set; }

                public ulong HookPoint { get; set; }

                public ulong Index { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolId.From(PoolId);
                    ret.AddRange(vPoolId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookPoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHookPoint.From(HookPoint);
                    ret.AddRange(vHookPoint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIndex.From(Index);
                    ret.AddRange(vIndex.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolHookKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolHookKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolId = vPoolId.ToValue();
                    if (valuePoolId is ulong vPoolIdValue) { ret.PoolId = vPoolIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHookPoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHookPoint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHookPoint = vHookPoint.ToValue();
                    if (valueHookPoint is ulong vHookPointValue) { ret.HookPoint = vHookPointValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIndex = vIndex.ToValue();
                    if (valueIndex is ulong vIndexValue) { ret.Index = vIndexValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolHookKey);
                }
                public bool Equals(PoolHookKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolHookKey left, PoolHookKey right)
                {
                    return EqualityComparer<PoolHookKey>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolHookKey left, PoolHookKey right)
                {
                    return !(left == right);
                }

            }

            public class PoolInfo : AVMObjectType
            {
                public ulong AssetA { get; set; }

                public ulong AssetB { get; set; }

                public ulong FeeBps { get; set; }

                public Algorand.Address Creator { get; set; }

                public bool Active { get; set; }

                public Algorand.Address MbrPayor { get; set; }

                public ulong MbrAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetA.From(AssetA);
                    ret.AddRange(vAssetA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetB.From(AssetB);
                    ret.AddRange(vAssetB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBps.From(FeeBps);
                    ret.AddRange(vFeeBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMbrPayor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vMbrPayor.From(MbrPayor);
                    ret.AddRange(vMbrPayor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMbrAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMbrAmount.From(MbrAmount);
                    ret.AddRange(vMbrAmount.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetA = vAssetA.ToValue();
                    if (valueAssetA is ulong vAssetAValue) { ret.AssetA = vAssetAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetB = vAssetB.ToValue();
                    if (valueAssetB is ulong vAssetBValue) { ret.AssetB = vAssetBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBps = vFeeBps.ToValue();
                    if (valueFeeBps is ulong vFeeBpsValue) { ret.FeeBps = vFeeBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMbrPayor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vMbrPayor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMbrPayor = vMbrPayor.ToValue();
                    if (valueMbrPayor is Algorand.Address vMbrPayorValue) { ret.MbrPayor = vMbrPayorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMbrAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMbrAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMbrAmount = vMbrAmount.ToValue();
                    if (valueMbrAmount is ulong vMbrAmountValue) { ret.MbrAmount = vMbrAmountValue; }
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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="version"> </param>
        /// <param name="admin"> </param>
        public async Task Create(string version, Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 151, 41, 20 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string version, Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 151, 41, 20 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="assetA"> </param>
        /// <param name="assetB"> </param>
        /// <param name="feeBps"> </param>
        /// <param name="hookPoints"> </param>
        /// <param name="hookPlugins"> </param>
        public async Task<ulong> CreatePool(PaymentTransaction mbrPayment, ulong assetA, ulong assetB, ulong feeBps, ulong[] hookPoints, ulong[] hookPlugins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 11, 156, 80, 181 };
            var assetAAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAAbi.From(assetA);
            var assetBAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetBAbi.From(assetB);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var hookPointsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); hookPointsAbi.From(hookPoints);
            var hookPluginsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); hookPluginsAbi.From(hookPlugins);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, assetAAbi, assetBAbi, feeBpsAbi, hookPointsAbi, hookPluginsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePool_Transactions(PaymentTransaction mbrPayment, ulong assetA, ulong assetB, ulong feeBps, ulong[] hookPoints, ulong[] hookPlugins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 11, 156, 80, 181 };
            var assetAAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAAbi.From(assetA);
            var assetBAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetBAbi.From(assetB);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var hookPointsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); hookPointsAbi.From(hookPoints);
            var hookPluginsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); hookPluginsAbi.From(hookPlugins);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, assetAAbi, assetBAbi, feeBpsAbi, hookPointsAbi, hookPluginsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="active"> </param>
        public async Task SetPoolActive(ulong poolId, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 242, 205, 118 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPoolActive_Transactions(ulong poolId, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 242, 205, 118 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="hookPoint"> </param>
        /// <param name="index"> </param>
        /// <param name="enabled"> </param>
        public async Task SetHookEnabled(ulong poolId, ulong hookPoint, ulong index, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 173, 102, 120 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, hookPointAbi, indexAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetHookEnabled_Transactions(ulong poolId, ulong hookPoint, ulong index, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 173, 102, 120 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, hookPointAbi, indexAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Temporary execution surface while swap/liquidity methods are being built.
        ///The final DEX methods should call executeHooks internally at each lifecycle point.
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="hookPoint"> </param>
        /// <param name="input"> DexHookInput</param>
        public async Task<Structs.DexHookOutput> AdminRunHook(ulong poolId, ulong hookPoint, Structs.DexHookInput input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 185, 99, 145 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, hookPointAbi, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DexHookOutput.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> AdminRunHook_Transactions(ulong poolId, ulong hookPoint, Structs.DexHookInput input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 185, 99, 145 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, hookPointAbi, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<Structs.PoolInfo> GetPool(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 191, 76, 172 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            var result = await base.SimApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPool_Transactions(ulong poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 191, 76, 172 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="hookPoint"> </param>
        public async Task<ulong> GetHookCount(ulong poolId, ulong hookPoint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 80, 207, 160 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);

            var result = await base.SimApp(new List<object> { abiHandle, poolIdAbi, hookPointAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetHookCount_Transactions(ulong poolId, ulong hookPoint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 80, 207, 160 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, hookPointAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="hookPoint"> </param>
        /// <param name="index"> </param>
        public async Task<Structs.PoolHookInfo> GetHook(ulong poolId, ulong hookPoint, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 73, 46, 57 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, poolIdAbi, hookPointAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolHookInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetHook_Transactions(ulong poolId, ulong hookPoint, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 73, 46, 57 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolIdAbi.From(poolId);
            var hookPointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookPointAbi.From(hookPoint);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, hookPointAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="hookCount"> </param>
        public async Task<Structs.PluginDexMbrData> Mbr(ulong hookCount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 62, 104, 151 };
            var hookCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookCountAbi.From(hookCount);

            var result = await base.SimApp(new List<object> { abiHandle, hookCountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PluginDexMbrData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Mbr_Transactions(ulong hookCount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 62, 104, 151 };
            var hookCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hookCountAbi.From(hookCount);

            return await base.MakeTransactionList(new List<object> { abiHandle, hookCountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGx1Z2luRGV4IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkRleEhvb2tJbnB1dCI6W3sibmFtZSI6ImFzc2V0SW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXRPdXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50SW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50T3V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZlZUJwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsaXF1aWRpdHkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2NyYXRjaCIsInR5cGUiOiJ1aW50NjQifV0sIkRleEhvb2tPdXRwdXQiOlt7Im5hbWUiOiJhbW91bnRJbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbW91bnRPdXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlQnBzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxpcXVpZGl0eSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzY3JhdGNoIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZsYWdzIiwidHlwZSI6InVpbnQ2NCJ9XSwiUGx1Z2luRGV4TUJSRGF0YSI6W3sibmFtZSI6InBvb2wiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaG9va0NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2xIb29rIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsIiwidHlwZSI6InVpbnQ2NCJ9XSwiUG9vbEhvb2tDb3VudEtleSI6W3sibmFtZSI6InBvb2xJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJob29rUG9pbnQiLCJ0eXBlIjoidWludDY0In1dLCJQb29sSG9va0luZm8iOlt7Im5hbWUiOiJhcHAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5hYmxlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmxhZ3MiLCJ0eXBlIjoidWludDY0In1dLCJQb29sSG9va0tleSI6W3sibmFtZSI6InBvb2xJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJob29rUG9pbnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5kZXgiLCJ0eXBlIjoidWludDY0In1dLCJQb29sSW5mbyI6W3sibmFtZSI6ImFzc2V0QSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldEIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlQnBzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFjdGl2ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibWJyUGF5b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1ickFtb3VudCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVQb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0QSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRCIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9va1BvaW50cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rUGx1Z2lucyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFBvb2xBY3RpdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWN0aXZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEhvb2tFbmFibGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9va1BvaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuYWJsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRtaW5SdW5Ib29rIiwiZGVzYyI6IlRlbXBvcmFyeSBleGVjdXRpb24gc3VyZmFjZSB3aGlsZSBzd2FwL2xpcXVpZGl0eSBtZXRob2RzIGFyZSBiZWluZyBidWlsdC5cblRoZSBmaW5hbCBERVggbWV0aG9kcyBzaG91bGQgY2FsbCBleGVjdXRlSG9va3MgaW50ZXJuYWxseSBhdCBlYWNoIGxpZmVjeWNsZSBwb2ludC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rUG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkRleEhvb2tJbnB1dCIsIm5hbWUiOiJpbnB1dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkRleEhvb2tPdXRwdXQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYWRkcmVzcyxib29sLGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IlBvb2xJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRIb29rQ291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rUG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEhvb2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rUG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiUG9vbEhvb2tJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9va0NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUGx1Z2luRGV4TUJSRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1MjAsNzk3LDg1OCw5MTcsMTE5MCwxMzM5LDE0MDZdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6UERBQSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6UERBTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OSw1NDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6UERIQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNV0sImVycm9yTWVzc2FnZSI6IkVSUjpQREhEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE2LDkwN10sImVycm9yTWVzc2FnZSI6IkVSUjpQREhOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzOV0sImVycm9yTWVzc2FnZSI6IkVSUjpQREhQIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcxLDM4OF0sImVycm9yTWVzc2FnZSI6IkVSUjpQRElQIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODE2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOlBEUEkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzcsNDIwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOlBEUEwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjUsNzk0XSwiZXJyb3JNZXNzYWdlIjoiRVJSOlBEUE4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg4XSwiZXJyb3JNZXNzYWdlIjoiRVJSOlBEUkIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDYsMTA3MF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc1XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkzLDE0OTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODZdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzOSw3MjhdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxLDI5NiwzMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDQsNjgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXBwbGljYXRpb24+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjIsMjcyLDI4NCw1OTUsNjUzLDY2Miw2NzEsNzUwLDc2MiwxMTc1LDEzMDYsMTMxNSwxMzU5LDEzNjgsMTM3NywxNDQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9wbHVnaW4tZGV4L3R5cGVzLnRzOjpEZXhIb29rSW5wdXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9wbHVnaW4tZGV4L3R5cGVzLnRzOjpEZXhIb29rT3V0cHV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTRJREVnTnpBd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWliR0Z6ZEY5amFHRnVaMlVpSUNKd0lpQWlhQ0lnSW5CdmIyeGZZM1Z5YzI5eUlpQXdlRGd3SUNKaklpQWlZV1J0YVc0aUlDSkZVbEk2VUVSUVRDSWdJa1ZTVWpwUVJFaERJaUFpUlZKU09sQkVTVkFpSUNKRlVsSTZVRVJRVGlJZ0lrVlNVanBRUkVoT0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJzZFdkcGJrUmxlQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1USUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3dZamxqTlRCaU5TQXdlRFU0WmpKalpEYzJJREI0TVRCaFpEWTJOemdnTUhoa05HSTVOak01TVNBd2VEYzRZbVkwWTJGaklEQjRNalkxTUdObVlUQWdNSGhrTVRRNU1tVXpPU0F3ZUdFM00yVTJPRGszSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsVUc5dmJDaHdZWGtzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwVzEwc2RXbHVkRFkwVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKelpYUlFiMjlzUVdOMGFYWmxLSFZwYm5RMk5DeGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEVodmIydEZibUZpYkdWa0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSdGFXNVNkVzVJYjI5cktIVnBiblEyTkN4MWFXNTBOalFzS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlFiMjlzS0hWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aWIyOXNMR0ZrWkhKbGMzTXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwU0c5dmEwTnZkVzUwS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJJYjI5cktIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKdFluSW9kV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxVRzl2YkNCelpYUlFiMjlzUVdOMGFYWmxJSE5sZEVodmIydEZibUZpYkdWa0lHRmtiV2x1VW5WdVNHOXZheUJuWlhSUWIyOXNJR2RsZEVodmIydERiM1Z1ZENCblpYUkliMjlySUcxaWNnb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCc2RXZHBia1JsZUNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRMU9UY3lPVEUwSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hOMGNtbHVaeXhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJzZFdkcGJrUmxlQzVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCMlpYSnphVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR3RsZVRvZ1VHeDFaMmx1UkdWNFIyeHZZbUZzVTNSaGRHVkxaWGxXWlhKemFXOXVJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJblpsY25OcGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QjBhR2x6TG5abGNuTnBiMjR1ZG1Gc2RXVWdQU0IyWlhKemFXOXVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaFpHMXBiaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lCUWJIVm5hVzVFWlhoSGJHOWlZV3hUZEdGMFpVdGxlVUZrYldsdUlIMHBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnUFNCaFpHMXBiZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSEJ2YjJ4RGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lCUWJIVm5hVzVFWlhoSGJHOWlZV3hUZEdGMFpVdGxlVkJ2YjJ4RGRYSnpiM0lnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5CdmIyeGZZM1Z5YzI5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2RHaHBjeTV3YjI5c1EzVnljMjl5TG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJzWVhOMFEyaGhibWRsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ1VHeDFaMmx1UkdWNFIyeHZZbUZzVTNSaGRHVkxaWGxNWVhOMFEyaGhibWRsSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc1lYTjBYMk5vWVc1blpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUm9hWE11YkdGemRFTm9ZVzVuWlM1MllXeDFaU0E5SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCc2RXZHBia1JsZUM1amNtVmhkR1ZRYjI5c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFVHOXZiRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TXkweU1UQUtJQ0FnSUM4dklHTnlaV0YwWlZCdmIyd29DaUFnSUNBdkx5QWdJRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJPaUJCYzNObGRDd0tJQ0FnSUM4dklDQWdZWE56WlhSQ09pQkJjM05sZEN3S0lDQWdJQzh2SUNBZ1ptVmxRbkJ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdodmIydFFiMmx1ZEhNNklIVnBiblEyTkZ0ZExBb2dJQ0FnTHk4Z0lDQm9iMjlyVUd4MVoybHVjem9nUVhCd2JHbGpZWFJwYjI1YlhTd0tJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRndjR3hwWTJGMGFXOXVQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGemMyVjBRUzVwWkNBaFBUMGdZWE56WlhSQ0xtbGtMQ0JGVWxKZlNVNVdRVXhKUkY5UVQwOU1LUW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQmpjbVZoZEdWUWIyOXNYMkZtZEdWeVgyRnpjMlZ5ZEVBeU13b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVJWSlNPbEJFVUV3aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VUVSUVRBb0tZM0psWVhSbFVHOXZiRjloWm5SbGNsOWhjM05sY25SQU1qTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dodmIydFFiMmx1ZEhNdWJHVnVaM1JvSUQwOVBTQm9iMjlyVUd4MVoybHVjeTVzWlc1bmRHZ3NJRVZTVWw5SlRsWkJURWxFWDBoUFQwdGZRMDlPUmtsSEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWW01NklHTnlaV0YwWlZCdmIyeGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWaklEa2dMeThnSWtWU1VqcFFSRWhESWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbEJFU0VNS0NtTnlaV0YwWlZCdmIyeGZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCeVpYUjFjbTRnVUd4MVoybHVSR1Y0VFdsdVVHOXZiRTFDVWlBcklDaFFiSFZuYVc1RVpYaEliMjlyUTI5MWJuUk5RbElnS3lCUWJIVm5hVzVFWlhoUWIyOXNTRzl2YTAxQ1Vpa2dLaUJvYjI5clEyOTFiblFLSUNBZ0lHbHVkR05mTXlBdkx5QTNNREF3TUFvZ0lDQWdaR2xuSURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QTNNREF3TUFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRVS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnUlZKU1gwbE9Wa0ZNU1VSZlVFRlpUVVZPVkNrS0lDQWdJR1JwWnlBM0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1kzSmxZWFJsVUc5dmJGOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSWtWU1VqcFFSRWxRSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbEJFU1ZBS0NtTnlaV0YwWlZCdmIyeGZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1WVcxdmRXNTBJRDQ5SUhKbGNYVnBjbVZrVFdKeUxDQkZVbEpmU1U1V1FVeEpSRjlRUVZsTlJVNVVLUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQmthV2NnTVRBS0lDQWdJRDQ5Q2lBZ0lDQmlibm9nWTNKbFlYUmxVRzl2YkY5aFpuUmxjbDloYzNObGNuUkFOd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJa1ZTVWpwUVJFbFFJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09sQkVTVkFLQ21OeVpXRjBaVkJ2YjJ4ZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJqYjI1emRDQnBaQ0E5SUhSb2FYTXVjRzl2YkVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhCdmIyeERkWEp6YjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQlFiSFZuYVc1RVpYaEhiRzlpWVd4VGRHRjBaVXRsZVZCdmIyeERkWEp6YjNJZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQnZiMnhmWTNWeWMyOXlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxuQnZiMnhEZFhKemIzSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUIwYUdsekxuQnZiMnhEZFhKemIzSXVkbUZzZFdVZ1BTQnBaQ0FySURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQnZiMnhEZFhKemIzSWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUJRYkhWbmFXNUVaWGhIYkc5aVlXeFRkR0YwWlV0bGVWQnZiMnhEZFhKemIzSWdmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkJ2YjJ4ZlkzVnljMjl5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnZEdocGN5NXdiMjlzUTNWeWMyOXlMblpoYkhWbElEMGdhV1FnS3lBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ua0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doZEdocGN5NXdiMjlzY3lod2IyOXNTV1FwTG1WNGFYTjBjeXdnUlZKU1gwbE9Wa0ZNU1VSZlVFOVBUQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY0c5dmJITWdQU0JDYjNoTllYQThkV2x1ZERZMExDQlFiMjlzU1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUZCc2RXZHBia1JsZUVKdmVGQnlaV1pwZUZCdmIyeHpJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvSVhSb2FYTXVjRzl2YkhNb2NHOXZiRWxrS1M1bGVHbHpkSE1zSUVWU1VsOUpUbFpCVEVsRVgxQlBUMHdwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHTnlaV0YwWlZCdmIyeGZZV1owWlhKZllYTnpaWEowUURrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWtWU1VqcFFSRkJNSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbEJFVUV3S0NtTnlaV0YwWlZCdmIyeGZZV1owWlhKZllYTnpaWEowUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU5Rb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJM0NpQWdJQ0F2THlCdFluSlFZWGx2Y2pvZ2JXSnlVR0Y1YldWdWRDNXpaVzVrWlhJc0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU1TMHlNamtLSUNBZ0lDOHZJSFJvYVhNdWNHOXZiSE1vY0c5dmJFbGtLUzUyWVd4MVpTQTlJSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUkJPaUJoYzNObGRFRXVhV1FzQ2lBZ0lDQXZMeUFnSUdGemMyVjBRam9nWVhOelpYUkNMbWxrTEFvZ0lDQWdMeThnSUNCbVpXVkNjSE1zQ2lBZ0lDQXZMeUFnSUdOeVpXRjBiM0k2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRmpkR2wyWlRvZ2RISjFaU3dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViM0k2SUcxaWNsQmhlVzFsYm5RdWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCdFluSkJiVzkxYm5RNklHMWljbEJoZVcxbGJuUXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTRDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0T0RBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXhDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dhRzl2YTFCc2RXZHBibk11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREV5Q2dwamNtVmhkR1ZRYjI5c1gzZG9hV3hsWDNSdmNFQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak14Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnYUc5dmExQnNkV2RwYm5NdWJHVnVaM1JvT3lCcElDczlJREVwSUhzS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkdsbklERUtJQ0FnSUR3S0lDQWdJR0o2SUdOeVpXRjBaVkJ2YjJ4ZllXWjBaWEpmZDJocGJHVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak15Q2lBZ0lDQXZMeUIwYUdsekxtbHVjM1JoYkd4SWIyOXJLSEJ2YjJ4SlpDd2dhRzl2YTFCdmFXNTBjMXRwWFN3Z2FHOXZhMUJzZFdkcGJuTmJhVjBwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5QjBhR2x6TG5aaGJHbGtZWFJsU0c5dmExQnZhVzUwS0dodmIydFFiMmx1ZENrS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpVaHZiMnRRYjJsdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ETUtJQ0FnSUM4dklHTnZibk4wSUdOdmRXNTBTMlY1T2lCUWIyOXNTRzl2YTBOdmRXNTBTMlY1SUQwZ2V5QndiMjlzU1dRc0lHaHZiMnRRYjJsdWRDQjlDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNVFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5Bb2dJQ0FnTHk4Z2JHVjBJR2x1WkdWNE9pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdhRzl2YTBOdmRXNTBjeUE5SUVKdmVFMWhjRHhRYjI5c1NHOXZhME52ZFc1MFMyVjVMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCUWJIVm5hVzVFWlhoQ2IzaFFjbVZtYVhoSWIyOXJRMjkxYm5SeklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRMkNpQWdJQ0F2THlCcFppQW9kR2hwY3k1b2IyOXJRMjkxYm5SektHTnZkVzUwUzJWNUtTNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWTNKbFlYUmxVRzl2YkY5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTndvZ0lDQWdMeThnYVc1a1pYZ2dQU0IwYUdsekxtaHZiMnREYjNWdWRITW9ZMjkxYm5STFpYa3BMblpoYkhWbENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJREV4Q2dwamNtVmhkR1ZRYjI5c1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYUc5dmEwdGxlVG9nVUc5dmJFaHZiMnRMWlhrZ1BTQjdJSEJ2YjJ4SlpDd2dhRzl2YTFCdmFXNTBMQ0JwYm1SbGVDQjlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCd2IyOXNTRzl2YTNNZ1BTQkNiM2hOWVhBOFVHOXZiRWh2YjJ0TFpYa3NJRkJ2YjJ4SWIyOXJTVzVtYno0b2V5QnJaWGxRY21WbWFYZzZJRkJzZFdkcGJrUmxlRUp2ZUZCeVpXWnBlRkJ2YjJ4SWIyOXJjeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYUNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0NGMGFHbHpMbkJ2YjJ4SWIyOXJjeWhvYjI5clMyVjVLUzVsZUdsemRITXNJRVZTVWw5SlRsWkJURWxFWDBoUFQwdGZRMDlPUmtsSEtRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJqY21WaGRHVlFiMjlzWDJGbWRHVnlYMkZ6YzJWeWRFQXhOd29nSUNBZ1lubDBaV01nT1NBdkx5QWlSVkpTT2xCRVNFTWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlVFUklRd29LWTNKbFlYUmxVRzl2YkY5aFpuUmxjbDloYzNObGNuUkFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTXkweE5UY0tJQ0FnSUM4dklIUm9hWE11Y0c5dmJFaHZiMnR6S0dodmIydExaWGtwTG5aaGJIVmxJRDBnZXdvZ0lDQWdMeThnSUNCaGNIQTZJSEJzZFdkcGJpNXBaQ3dLSUNBZ0lDOHZJQ0FnWlc1aFlteGxaRG9nZEhKMVpTd0tJQ0FnSUM4dklDQWdabXhoWjNNNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGc0TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5nb2dJQ0FnTHk4Z1pteGhaM002SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRNdE1UVTNDaUFnSUNBdkx5QjBhR2x6TG5CdmIyeEliMjlyY3lob2IyOXJTMlY1S1M1MllXeDFaU0E5SUhzS0lDQWdJQzh2SUNBZ1lYQndPaUJ3YkhWbmFXNHVhV1FzQ2lBZ0lDQXZMeUFnSUdWdVlXSnNaV1E2SUhSeWRXVXNDaUFnSUNBdkx5QWdJR1pzWVdkek9pQXdMQW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRNS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QjBhR2x6TG1odmIydERiM1Z1ZEhNb1kyOTFiblJMWlhrcExuWmhiSFZsSUQwZ2FXNWtaWGdnS3lBeENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVRRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXhDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dhRzl2YTFCc2RXZHBibk11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSWdZM0psWVhSbFVHOXZiRjkzYUdsc1pWOTBiM0JBTVRBS0NtTnlaV0YwWlZCdmIyeGZZV1owWlhKZmQyaHBiR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCc1lYTjBRMmhoYm1kbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dVR3gxWjJsdVJHVjRSMnh2WW1Gc1UzUmhkR1ZMWlhsTVlYTjBRMmhoYm1kbElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnNZWE4wWDJOb1lXNW5aU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSFJvYVhNdWJHRnpkRU5vWVc1blpTNTJZV3gxWlNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TXkweU1UQUtJQ0FnSUM4dklHTnlaV0YwWlZCdmIyd29DaUFnSUNBdkx5QWdJRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJPaUJCYzNObGRDd0tJQ0FnSUM4dklDQWdZWE56WlhSQ09pQkJjM05sZEN3S0lDQWdJQzh2SUNBZ1ptVmxRbkJ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdodmIydFFiMmx1ZEhNNklIVnBiblEyTkZ0ZExBb2dJQ0FnTHk4Z0lDQm9iMjlyVUd4MVoybHVjem9nUVhCd2JHbGpZWFJwYjI1YlhTd0tJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUdScFp5QXhOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiSFZuYVc1RVpYZ3VjMlYwVUc5dmJFRmpkR2wyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRkJ2YjJ4QlkzUnBkbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6T1FvZ0lDQWdMeThnYzJWMFVHOXZiRUZqZEdsMlpTaHdiMjlzU1dRNklIVnBiblEyTkN3Z1lXTjBhWFpsT2lCaWIyOXNaV0Z1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EQUtJQ0FnSUM4dklIUm9hWE11Y21WeGRXbHlaVUZrYldsdUtDa0tJQ0FnSUdOaGJHeHpkV0lnY21WeGRXbHlaVUZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME1Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFJvYVhNdWNHOXZiSE1vY0c5dmJFbGtLUzVsZUdsemRITXNJRVZTVWw5UVQwOU1YMDVQVkY5R1QxVk9SQ2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakVLSUNBZ0lDOHZJSEJ2YjJ4eklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1VHOXZiRWx1Wm04K0tIc2dhMlY1VUhKbFptbDRPaUJRYkhWbmFXNUVaWGhDYjNoUWNtVm1hWGhRYjI5c2N5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Y0c5dmJITW9jRzl2YkVsa0tTNWxlR2x6ZEhNc0lFVlNVbDlRVDA5TVgwNVBWRjlHVDFWT1JDa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUhObGRGQnZiMnhCWTNScGRtVmZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKRlVsSTZVRVJRVGlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBRUkZCT0NncHpaWFJRYjI5c1FXTjBhWFpsWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORElLSUNBZ0lDOHZJSFJvYVhNdWNHOXZiSE1vY0c5dmJFbGtLUzUyWVd4MVpTNWhZM1JwZG1VZ1BTQmhZM1JwZG1VS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHbHVkQ0ExTmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBMU5nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR3hoYzNSRGFHRnVaMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lCUWJIVm5hVzVFWlhoSGJHOWlZV3hUZEdGMFpVdGxlVXhoYzNSRGFHRnVaMlVnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW14aGMzUmZZMmhoYm1kbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2RHaHBjeTVzWVhOMFEyaGhibWRsTG5aaGJIVmxJRDBnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTVDaUFnSUNBdkx5QnpaWFJRYjI5c1FXTjBhWFpsS0hCdmIyeEpaRG9nZFdsdWREWTBMQ0JoWTNScGRtVTZJR0p2YjJ4bFlXNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJIVm5hVzVFWlhndWMyVjBTRzl2YTBWdVlXSnNaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkliMjlyUlc1aFlteGxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalEyQ2lBZ0lDQXZMeUJ6WlhSSWIyOXJSVzVoWW14bFpDaHdiMjlzU1dRNklIVnBiblEyTkN3Z2FHOXZhMUJ2YVc1ME9pQjFhVzUwTmpRc0lHbHVaR1Y0T2lCMWFXNTBOalFzSUdWdVlXSnNaV1E2SUdKdmIyeGxZVzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME53b2dJQ0FnTHk4Z2RHaHBjeTV5WlhGMWFYSmxRV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJ5WlhGMWFYSmxRV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRNENpQWdJQ0F2THlCMGFHbHpMblpoYkdsa1lYUmxTRzl2YTFCdmFXNTBLR2h2YjJ0UWIybHVkQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlIWmhiR2xrWVhSbFNHOXZhMUJ2YVc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYUc5dmEwdGxlVG9nVUc5dmJFaHZiMnRMWlhrZ1BTQjdJSEJ2YjJ4SlpDd2dhRzl2YTFCdmFXNTBMQ0JwYm1SbGVDQjlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhCdmIyeEliMjlyY3lBOUlFSnZlRTFoY0R4UWIyOXNTRzl2YTB0bGVTd2dVRzl2YkVodmIydEpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dVR3gxWjJsdVJHVjRRbTk0VUhKbFptbDRVRzl2YkVodmIydHpJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pvSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVeENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1d2IyOXNTRzl2YTNNb2FHOXZhMHRsZVNrdVpYaHBjM1J6TENCRlVsSmZTRTlQUzE5T1QxUmZSazlWVGtRcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJ6WlhSSWIyOXJSVzVoWW14bFpGOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtWU1VqcFFSRWhPSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbEJFU0U0S0NuTmxkRWh2YjJ0RmJtRmliR1ZrWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVElLSUNBZ0lDOHZJSFJvYVhNdWNHOXZiRWh2YjJ0ektHaHZiMnRMWlhrcExuWmhiSFZsTG1WdVlXSnNaV1FnUFNCbGJtRmliR1ZrQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR3hoYzNSRGFHRnVaMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lCUWJIVm5hVzVFWlhoSGJHOWlZV3hUZEdGMFpVdGxlVXhoYzNSRGFHRnVaMlVnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW14aGMzUmZZMmhoYm1kbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2RHaHBjeTVzWVhOMFEyaGhibWRsTG5aaGJIVmxJRDBnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUTJDaUFnSUNBdkx5QnpaWFJJYjI5clJXNWhZbXhsWkNod2IyOXNTV1E2SUhWcGJuUTJOQ3dnYUc5dmExQnZhVzUwT2lCMWFXNTBOalFzSUdsdVpHVjRPaUIxYVc1ME5qUXNJR1Z1WVdKc1pXUTZJR0p2YjJ4bFlXNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJIVm5hVzVFWlhndVlXUnRhVzVTZFc1SWIyOXJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSdGFXNVNkVzVJYjI5ck9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z05nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXdDaUFnSUNBdkx5QmhaRzFwYmxKMWJraHZiMnNvY0c5dmJFbGtPaUIxYVc1ME5qUXNJR2h2YjJ0UWIybHVkRG9nZFdsdWREWTBMQ0JwYm5CMWREb2dSR1Y0U0c5dmEwbHVjSFYwS1RvZ1JHVjRTRzl2YTA5MWRIQjFkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOTBlWEJsY3k1MGN6bzZSR1Y0U0c5dmEwbHVjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTVFvZ0lDQWdMeThnZEdocGN5NXlaWEYxYVhKbFFXUnRhVzRvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaWEYxYVhKbFFXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNall5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RHaHBjeTV3YjI5c2N5aHdiMjlzU1dRcExtVjRhWE4wY3l3Z1JWSlNYMUJQVDB4ZlRrOVVYMFpQVlU1RUtRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCd2IyOXNjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRkJ2YjJ4SmJtWnZQaWg3SUd0bGVWQnlaV1pwZURvZ1VHeDFaMmx1UkdWNFFtOTRVSEpsWm1sNFVHOXZiSE1nZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5BaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qSUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwYUdsekxuQnZiMnh6S0hCdmIyeEpaQ2t1WlhocGMzUnpMQ0JGVWxKZlVFOVBURjlPVDFSZlJrOVZUa1FwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmhaRzFwYmxKMWJraHZiMnRmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSkZVbEk2VUVSUVRpSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwUVJGQk9DZ3BoWkcxcGJsSjFia2h2YjJ0ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTXdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Y0c5dmJITW9jRzl2YkVsa0tTNTJZV3gxWlM1aFkzUnBkbVVzSUVWU1VsOVFUMDlNWDBsT1FVTlVTVlpGS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdjSFZ6YUdsdWRDQTBORGdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbTU2SUdGa2JXbHVVblZ1U0c5dmExOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlVFUlFTU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcFFSRkJKQ2dwaFpHMXBibEoxYmtodmIydGZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1nb2dJQ0FnTHk4Z2RHaHBjeTUyWVd4cFpHRjBaVWh2YjJ0UWIybHVkQ2hvYjI5clVHOXBiblFwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlIWmhiR2xrWVhSbFNHOXZhMUJ2YVc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5MWJuUkxaWGs2SUZCdmIyeEliMjlyUTI5MWJuUkxaWGtnUFNCN0lIQnZiMnhKWkN3Z2FHOXZhMUJ2YVc1MElIMEtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnYUc5dmEwTnZkVzUwY3lBOUlFSnZlRTFoY0R4UWIyOXNTRzl2YTBOdmRXNTBTMlY1TENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQlFiSFZuYVc1RVpYaENiM2hRY21WbWFYaEliMjlyUTI5MWJuUnpJSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pqSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qVUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NW9iMjlyUTI5MWJuUnpLR052ZFc1MFMyVjVLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHRmtiV2x1VW5WdVNHOXZhMTloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV2ZFhSd2RYUkdjbTl0U1c1d2RYUW9hVzV3ZFhRcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJ2ZFhSd2RYUkdjbTl0U1c1d2RYUUtJQ0FnSUhCdmNBb0tZV1J0YVc1U2RXNUliMjlyWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVR3gxWjJsdVJHVjRMbVY0WldOMWRHVkliMjlyYzBBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXdDaUFnSUNBdkx5QmhaRzFwYmxKMWJraHZiMnNvY0c5dmJFbGtPaUIxYVc1ME5qUXNJR2h2YjJ0UWIybHVkRG9nZFdsdWREWTBMQ0JwYm5CMWREb2dSR1Y0U0c5dmEwbHVjSFYwS1RvZ1JHVjRTRzl2YTA5MWRIQjFkQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaFpHMXBibEoxYmtodmIydGZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qa0tJQ0FnSUM4dklHTnZibk4wSUdOdmRXNTBJRDBnZEdocGN5NW9iMjlyUTI5MWJuUnpLR052ZFc1MFMyVjVLUzUyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNUW9nSUNBZ0x5OGdiR1YwSUc5MWRIQjFkQ0E5SUhSb2FYTXViM1YwY0hWMFJuSnZiVWx1Y0hWMEtHTjFjbkpsYm5RcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJ2ZFhSd2RYUkdjbTl0U1c1d2RYUUtJQ0FnSUdKMWNua2dNVFFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjekNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcGJtUmxlRG9nZFdsdWREWTBJRDBnTURzZ2FXNWtaWGdnUENCamIzVnVkRHNnYVc1a1pYZ2dLejBnTVNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ09Bb0tZV1J0YVc1U2RXNUliMjlyWDNkb2FXeGxYM1J2Y0VBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHbHVaR1Y0T2lCMWFXNTBOalFnUFNBd095QnBibVJsZUNBOElHTnZkVzUwT3lCcGJtUmxlQ0FyUFNBeEtTQjdDaUFnSUNCa2FXY2dOd29nSUNBZ1pHbG5JRGtLSUNBZ0lEd0tJQ0FnSUdKNklHRmtiV2x1VW5WdVNHOXZhMTloWm5SbGNsOTNhR2xzWlVBeE9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklHTnZibk4wSUdodmIydExaWGs2SUZCdmIyeEliMjlyUzJWNUlEMGdleUJ3YjI5c1NXUXNJR2h2YjJ0UWIybHVkQ3dnYVc1a1pYZ2dmUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TndvZ0lDQWdaR2xuSURFMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIQnZiMnhJYjI5cmN5QTlJRUp2ZUUxaGNEeFFiMjlzU0c5dmEwdGxlU3dnVUc5dmJFaHZiMnRKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nVUd4MVoybHVSR1Y0UW05NFVISmxabWw0VUc5dmJFaHZiMnR6SUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKb0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMxQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RHaHBjeTV3YjI5c1NHOXZhM01vYUc5dmEwdGxlU2t1WlhocGMzUnpMQ0JGVWxKZlNFOVBTMTlPVDFSZlJrOVZUa1FwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmhaRzFwYmxKMWJraHZiMnRmWVdaMFpYSmZZWE56WlhKMFFERXlDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlSVkpTT2xCRVNFNGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlVFUklUZ29LWVdSdGFXNVNkVzVJYjI5clgyRm1kR1Z5WDJGemMyVnlkRUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjM0NpQWdJQ0F2THlCamIyNXpkQ0JvYjI5cklEMGdZMnh2Ym1Vb2RHaHBjeTV3YjI5c1NHOXZhM01vYUc5dmEwdGxlU2t1ZG1Gc2RXVXBDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXhOQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYUc5dmF5NWxibUZpYkdWa0xDQkZVbEpmU0U5UFMxOUVTVk5CUWt4RlJDa0tJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW01NklHRmtiV2x1VW5WdVNHOXZhMTloWm5SbGNsOWhjM05sY25SQU1UUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbEJFU0VRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VUVSSVJBb0tZV1J0YVc1U2RXNUliMjlyWDJGbWRHVnlYMkZ6YzJWeWRFQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd3Q2lBZ0lDQXZMeUJqYjI1emRDQndiSFZuYVc0Z1BTQkJjSEJzYVdOaGRHbHZiaWhvYjI5ckxtRndjQ2tLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlkWEo1SURjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNdVlYVjBhRUZrWkhKbGMzTWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JGVWxKZlFWVlVTRjlCUkVSU1gwMUpVMDFCVkVOSUtRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1lXUnRhVzVTZFc1SWIyOXJYMkZtZEdWeVgyRnpjMlZ5ZEVBeE5nb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZVRVJCUVNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBRUkVGQkNncGhaRzFwYmxKMWJraHZiMnRmWVdaMFpYSmZZWE56WlhKMFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamN0TVRNekNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEJzZFdkcGJpNWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTVDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16RUtJQ0FnSUM4dklISmxhMlY1Vkc4NklIQnNkV2RwYmk1aFpHUnlaWE56TEFvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXdGxlVlJ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnWVcxdmRXNTBPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TnkweE16SUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nY0d4MVoybHVMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU55MHhNek1LSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NHeDFaMmx1TG1Ga1pISmxjM01zQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnekxURTVOQW9nSUNBZ0x5OGdiM1YwY0hWMElEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1VHeDFaMmx1UkdWNFNHOXZheTV3Y205MGIzUjVjR1V1WkdWNFNHOXZhejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0d4MVoybHVMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkN3S0lDQWdJQzh2SUNBZ0lDQm9iMjlyVUc5cGJuUXNDaUFnSUNBdkx5QWdJQ0FnYVc1a1pYZ3NDaUFnSUNBdkx5QWdJQ0FnVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmpkWEp5Wlc1MExBb2dJQ0FnTHk4Z0lDQWdJSFJ5ZFdVc0NpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFlLSUNBZ0lDOHZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQ3dLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UQUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RNdE1UazBDaUFnSUNBdkx5QnZkWFJ3ZFhRZ1BTQmhZbWxEWVd4c1BIUjVjR1Z2WmlCUWJIVm5hVzVFWlhoSWIyOXJMbkJ5YjNSdmRIbHdaUzVrWlhoSWIyOXJQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3YkhWbmFXNHNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1FzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrTEFvZ0lDQWdMeThnSUNBZ0lHaHZiMnRRYjJsdWRDd0tJQ0FnSUM4dklDQWdJQ0JwYm1SbGVDd0tJQ0FnSUM4dklDQWdJQ0JVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHTjFjbkpsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdkSEoxWlN3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqTWpoa1pUQTRZU0F2THlCdFpYUm9iMlFnSW1SbGVFaHZiMnNvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcExHSnZiMndwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9USUtJQ0FnSUM4dklIUnlkV1VzQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0T0RBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNeTB4T1RRS0lDQWdJQzh2SUc5MWRIQjFkQ0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRkJzZFdkcGJrUmxlRWh2YjJzdWNISnZkRzkwZVhCbExtUmxlRWh2YjJzK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnNkV2RwYml3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDd0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUXNDaUFnSUNBdkx5QWdJQ0FnYUc5dmExQnZhVzUwTEFvZ0lDQWdMeThnSUNBZ0lHbHVaR1Y0TEFvZ0lDQWdMeThnSUNBZ0lGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWTNWeWNtVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCMGNuVmxMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZFhKNUlERXlDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTFOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndmRIbHdaWE11ZEhNNk9rUmxlRWh2YjJ0UGRYUndkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0zQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM011WVhWMGFFRmtaSEpsYzNNZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQkZVbEpmVFVsVFUwbE9SMTlTUlV0RldWOUNRVU5MS1FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUVhWMGFFRmtaSElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWVdSdGFXNVNkVzVJYjI5clgyRm1kR1Z5WDJGemMyVnlkRUF4T0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlVFUlNRaUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcFFSRkpDQ2dwaFpHMXBibEoxYmtodmIydGZZV1owWlhKZllYTnpaWEowUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHRnpjMlYwU1c0NklHbHVjSFYwTG1GemMyVjBTVzRzQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJoYzNObGRFOTFkRG9nYVc1d2RYUXVZWE56WlhSUGRYUXNDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnRiM1Z1ZEVsdU9pQnZkWFJ3ZFhRdVlXMXZkVzUwU1c0c0NpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCaGJXOTFiblJQZFhRNklHOTFkSEIxZEM1aGJXOTFiblJQZFhRc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1ptVmxRbkJ6T2lCdmRYUndkWFF1Wm1WbFFuQnpMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01qQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVGdLSUNBZ0lDOHZJSEJ5YVdObE9pQnZkWFJ3ZFhRdWNISnBZMlVzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlPQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnYkdseGRXbGthWFI1T2lCdmRYUndkWFF1YkdseGRXbGthWFI1TEFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNellnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUhOamNtRjBZMmc2SUc5MWRIQjFkQzV6WTNKaGRHTm9MQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JsZUhSeVlXTjBJRFEwSURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUxURXlNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdZWE56WlhSSmJqb2dhVzV3ZFhRdVlYTnpaWFJKYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJQZFhRNklHbHVjSFYwTG1GemMyVjBUM1YwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblJKYmpvZ2IzVjBjSFYwTG1GdGIzVnVkRWx1TEFvZ0lDQWdMeThnSUNCaGJXOTFiblJQZFhRNklHOTFkSEIxZEM1aGJXOTFiblJQZFhRc0NpQWdJQ0F2THlBZ0lHWmxaVUp3Y3pvZ2IzVjBjSFYwTG1abFpVSndjeXdLSUNBZ0lDOHZJQ0FnY0hKcFkyVTZJRzkxZEhCMWRDNXdjbWxqWlN3S0lDQWdJQzh2SUNBZ2JHbHhkV2xrYVhSNU9pQnZkWFJ3ZFhRdWJHbHhkV2xrYVhSNUxBb2dJQ0FnTHk4Z0lDQnpZM0poZEdOb09pQnZkWFJ3ZFhRdWMyTnlZWFJqYUN3S0lDQWdJQzh2SUgwS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVc1a1pYZzZJSFZwYm5RMk5DQTlJREE3SUdsdVpHVjRJRHdnWTI5MWJuUTdJR2x1WkdWNElDczlJREVwSUhzS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0E0Q2lBZ0lDQmlJR0ZrYldsdVVuVnVTRzl2YTE5M2FHbHNaVjkwYjNCQU9Rb0tZV1J0YVc1U2RXNUliMjlyWDJGbWRHVnlYM2RvYVd4bFFERTVPZ29nSUNBZ1pHbG5JRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1bGVHVmpkWFJsU0c5dmEzTW9jRzl2YkVsa0xDQm9iMjlyVUc5cGJuUXNJR2x1Y0hWMEtRb2dJQ0FnWWlCaFpHMXBibEoxYmtodmIydGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJIVm5hVzVFWlhndVpYaGxZM1YwWlVodmIydHpRREl3Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVR3gxWjJsdVJHVjRMbWRsZEZCdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSUWIyOXNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56QUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxuQnZiMnh6S0hCdmIyeEpaQ2t1WlhocGMzUnpLU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ3YjI5c2N5QTlJRUp2ZUUxaGNEeDFhVzUwTmpRc0lGQnZiMnhKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nVUd4MVoybHVSR1Y0UW05NFVISmxabWw0VUc5dmJITWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpBS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5CdmIyeHpLSEJ2YjJ4SlpDa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRGQnZiMnhmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y0c5dmJITW9jRzl2YkVsa0tTNTJZV3gxWlFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvS1oyVjBVRzl2YkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJzZFdkcGJrUmxlQzVuWlhSUWIyOXNRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJRYjI5c1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjMExUSTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdZWE56WlhSQk9pQXdMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFSTZJREFzQ2lBZ0lDQXZMeUFnSUdabFpVSndjem9nTUN3S0lDQWdJQzh2SUNBZ1kzSmxZWFJ2Y2pvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhZM1JwZG1VNklHWmhiSE5sTEFvZ0lDQWdMeThnSUNCdFluSlFZWGx2Y2pvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnRZbkpCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRU2tLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0lnWjJWMFVHOXZiRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnNkV2RwYmtSbGVDNW5aWFJRYjI5c1FEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJIVm5hVzVFWlhndVoyVjBTRzl2YTBOdmRXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFNHOXZhME52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EY0tJQ0FnSUM4dklIUm9hWE11ZG1Gc2FXUmhkR1ZJYjI5clVHOXBiblFvYUc5dmExQnZhVzUwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlIWmhiR2xrWVhSbFNHOXZhMUJ2YVc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5MWJuUkxaWGs2SUZCdmIyeEliMjlyUTI5MWJuUkxaWGtnUFNCN0lIQnZiMnhKWkN3Z2FHOXZhMUJ2YVc1MElIMEtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdhRzl2YTBOdmRXNTBjeUE5SUVKdmVFMWhjRHhRYjI5c1NHOXZhME52ZFc1MFMyVjVMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCUWJIVm5hVzVFWlhoQ2IzaFFjbVZtYVhoSWIyOXJRMjkxYm5SeklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt3Q2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTVvYjI5clEyOTFiblJ6S0dOdmRXNTBTMlY1S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwU0c5dmEwTnZkVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1odmIydERiM1Z1ZEhNb1kyOTFiblJMWlhrcExuWmhiSFZsQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2dwblpYUkliMjlyUTI5MWJuUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWJIVm5hVzVFWlhndVoyVjBTRzl2YTBOdmRXNTBRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJJYjI5clEyOTFiblJmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJJYjI5clEyOTFiblJmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFiSFZuYVc1RVpYZ3VaMlYwU0c5dmEwTnZkVzUwUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYkhWbmFXNUVaWGd1WjJWMFNHOXZhMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFaHZiMnM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU9Rb2dJQ0FnTHk4Z2RHaHBjeTUyWVd4cFpHRjBaVWh2YjJ0UWIybHVkQ2hvYjI5clVHOXBiblFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpVaHZiMnRRYjJsdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ERUtJQ0FnSUM4dklHTnZibk4wSUdodmIydExaWGs2SUZCdmIyeEliMjlyUzJWNUlEMGdleUJ3YjI5c1NXUXNJR2h2YjJ0UWIybHVkQ3dnYVc1a1pYZ2dmUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCd2IyOXNTRzl2YTNNZ1BTQkNiM2hOWVhBOFVHOXZiRWh2YjJ0TFpYa3NJRkJ2YjJ4SWIyOXJTVzVtYno0b2V5QnJaWGxRY21WbWFYZzZJRkJzZFdkcGJrUmxlRUp2ZUZCeVpXWnBlRkJ2YjJ4SWIyOXJjeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYUNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd01nb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWNHOXZiRWh2YjJ0ektHaHZiMnRMWlhrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSSWIyOXJYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkJ2YjJ4SWIyOXJjeWhvYjI5clMyVjVLUzUyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb0taMlYwU0c5dmExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCc2RXZHBia1JsZUM1blpYUkliMjlyUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSSWIyOXJYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QTJMVE14TUFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWVhCd09pQXdMQW9nSUNBZ0x5OGdJQ0JsYm1GaWJHVmtPaUJtWVd4elpTd0tJQ0FnSUM4dklDQWdabXhoWjNNNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaUlHZGxkRWh2YjJ0ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYkhWbmFXNUVaWGd1WjJWMFNHOXZhMEEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVR3gxWjJsdVJHVjRMbTFpY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWljam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCUWJIVm5hVzVFWlhoTmFXNVFiMjlzVFVKU0lDc2dLRkJzZFdkcGJrUmxlRWh2YjJ0RGIzVnVkRTFDVWlBcklGQnNkV2RwYmtSbGVGQnZiMnhJYjI5clRVSlNLU0FxSUdodmIydERiM1Z1ZEFvZ0lDQWdhVzUwWTE4eklDOHZJRGN3TURBd0NpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOekF3TURBS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekUxTFRNeU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2NHOXZiRG9nVUd4MVoybHVSR1Y0VFdsdVVHOXZiRTFDVWl3S0lDQWdJQzh2SUNBZ2FHOXZhME52ZFc1ME9pQlFiSFZuYVc1RVpYaEliMjlyUTI5MWJuUk5RbElzQ2lBZ0lDQXZMeUFnSUhCdmIyeEliMjlyT2lCUWJIVm5hVzVFWlhoUWIyOXNTRzl2YTAxQ1Vpd0tJQ0FnSUM4dklDQWdkRzkwWVd3NklIUm9hWE11Y0c5dmJFMWljaWhvYjI5clEyOTFiblFwTEFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01ERXhNVGN3TURBd01EQXdNREF3TURBd05HVXlNREF3TURBd01EQXdNREF3TUdNek5UQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2RXZHBiaTFrWlhndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVHeDFaMmx1UkdWNExuSmxjWFZwY21WQlpHMXBiaWdwSUMwK0lIWnZhV1E2Q25KbGNYVnBjbVZCWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExDQkZVbEpmUVVSTlNVNWZUMDVNV1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeDFaMmx1TFdSbGVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmhaRzFwYmlBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQlFiSFZuYVc1RVpYaEhiRzlpWVd4VGRHRjBaVXRsZVVGa2JXbHVJSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExDQkZVbEpmUVVSTlNVNWZUMDVNV1NrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsY1hWcGNtVkJaRzFwYmw5aFpuUmxjbDloYzNObGNuUkFNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2VUVSQlR5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwUVJFRlBDZ3B5WlhGMWFYSmxRV1J0YVc1ZllXWjBaWEpmWVhOelpYSjBRREk2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRYkhWbmFXNUVaWGd1ZG1Gc2FXUmhkR1ZJYjI5clVHOXBiblFvYUc5dmExQnZhVzUwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsU0c5dmExQnZhVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TVFvZ0lDQWdMeThnY0hKcGRtRjBaU0IyWVd4cFpHRjBaVWh2YjJ0UWIybHVkQ2hvYjI5clVHOXBiblE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9hRzl2YTFCdmFXNTBJRDQ5SUVodmIydFFiMmx1ZEUxcGJpQW1KaUJvYjI5clVHOXBiblFnUEQwZ1NHOXZhMUJ2YVc1MFRXRjRMQ0JGVWxKZlNVNVdRVXhKUkY5SVQwOUxYMUJQU1U1VUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZWlCMllXeHBaR0YwWlVodmIydFFiMmx1ZEY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdQRDBLSUNBZ0lHSjZJSFpoYkdsa1lYUmxTRzl2YTFCdmFXNTBYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ25aaGJHbGtZWFJsU0c5dmExQnZhVzUwWDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hvYjI5clVHOXBiblFnUGowZ1NHOXZhMUJ2YVc1MFRXbHVJQ1ltSUdodmIydFFiMmx1ZENBOFBTQkliMjlyVUc5cGJuUk5ZWGdzSUVWU1VsOUpUbFpCVEVsRVgwaFBUMHRmVUU5SlRsUXBDaUFnSUNCaWJub2dkbUZzYVdSaGRHVkliMjlyVUc5cGJuUmZZV1owWlhKZllYTnpaWEowUURZS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09sQkVTRkFpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZVRVJJVUFvS2RtRnNhV1JoZEdWSWIyOXJVRzlwYm5SZllXWjBaWEpmWVhOelpYSjBRRFk2Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFNHOXZhMUJ2YVc1MFgySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlIWmhiR2xrWVhSbFNHOXZhMUJ2YVc1MFgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnNkV2RwYmtSbGVDNXZkWFJ3ZFhSR2NtOXRTVzV3ZFhRb2FXNXdkWFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDbTkxZEhCMWRFWnliMjFKYm5CMWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JIVm5hVzR0WkdWNEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklIQnlhWFpoZEdVZ2IzVjBjSFYwUm5KdmJVbHVjSFYwS0dsdWNIVjBPaUJFWlhoSWIyOXJTVzV3ZFhRcE9pQkVaWGhJYjI5clQzVjBjSFYwSUhzS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJR0Z0YjNWdWRFbHVPaUJwYm5CMWRDNWhiVzkxYm5SSmJpd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TmlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4MVoybHVMV1JsZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1lXMXZkVzUwVDNWME9pQnBibkIxZEM1aGJXOTFiblJQZFhRc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNalFnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUdabFpVSndjem9nYVc1d2RYUXVabVZsUW5CekxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRE15SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCd2NtbGpaVG9nYVc1d2RYUXVjSEpwWTJVc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdOREFnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpMWtaWGd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUd4cGNYVnBaR2wwZVRvZ2FXNXdkWFF1YkdseGRXbGthWFI1TEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEUTRJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiSFZuYVc0dFpHVjRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJ6WTNKaGRHTm9PaUJwYm5CMWRDNXpZM0poZEdOb0xBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRFUySURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHRaR1Y0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBd0xURXdPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdZVzF2ZFc1MFNXNDZJR2x1Y0hWMExtRnRiM1Z1ZEVsdUxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5SUGRYUTZJR2x1Y0hWMExtRnRiM1Z1ZEU5MWRDd0tJQ0FnSUM4dklDQWdabVZsUW5Cek9pQnBibkIxZEM1bVpXVkNjSE1zQ2lBZ0lDQXZMeUFnSUhCeWFXTmxPaUJwYm5CMWRDNXdjbWxqWlN3S0lDQWdJQzh2SUNBZ2JHbHhkV2xrYVhSNU9pQnBibkIxZEM1c2FYRjFhV1JwZEhrc0NpQWdJQ0F2THlBZ0lITmpjbUYwWTJnNklHbHVjSFYwTG5OamNtRjBZMmdzQ2lBZ0lDQXZMeUFnSUdac1lXZHpPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3gxWjJsdUxXUmxlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnWm14aFozTTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNkV2RwYmkxa1pYZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREF0TVRBNENpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCaGJXOTFiblJKYmpvZ2FXNXdkWFF1WVcxdmRXNTBTVzRzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRTkxZERvZ2FXNXdkWFF1WVcxdmRXNTBUM1YwTEFvZ0lDQWdMeThnSUNCbVpXVkNjSE02SUdsdWNIVjBMbVpsWlVKd2N5d0tJQ0FnSUM4dklDQWdjSEpwWTJVNklHbHVjSFYwTG5CeWFXTmxMQW9nSUNBZ0x5OGdJQ0JzYVhGMWFXUnBkSGs2SUdsdWNIVjBMbXhwY1hWcFpHbDBlU3dLSUNBZ0lDOHZJQ0FnYzJOeVlYUmphRG9nYVc1d2RYUXVjMk55WVhSamFDd0tJQ0FnSUM4dklDQWdabXhoWjNNNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQWdCOEtJRUpnMEVGUjk4ZFF0c1lYTjBYMk5vWVc1blpRRndBV2dMY0c5dmJGOWpkWEp6YjNJQmdBRmpCV0ZrYldsdUNFVlNVanBRUkZCTUNFVlNVanBRUkVoRENFVlNVanBRUkVsUUNFVlNVanBRUkZCT0NFVlNVanBRUkVoT01Sa1VSREVZUVFCQWdnZ0VDNXhRdFFSWThzMTJCQkN0Wm5nRTFMbGprUVI0djB5c0JDWlF6NkFFMFVrdU9RU25QbWlYTmhvQWpnZ0FRd0doQWRzQ05BUGxCR2dFblFUd0FJQUUxWmNwRkRZYUFJNEJBQUVBTmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0EyR2dKSkZZRWdFa1NBQjNabGNuTnBiMjVQQW1jbkIweG5Kd1FpWnlreUIyY2tReUpIQklBQVJ3TXhGaVFKU1RnUUpCSkVOaG9CU1JVakVrUVhTVFlhQWtrVkl4SkVGMGxPQWpZYUEwa1ZJeEpFRjA0Q05ob0VTVTREU1NKWlNVNEVJd3VCQWdoTUZSSkVOaG9GU1U0RFNTSlpTVTRFSXd1QkFnaE1GUkpFRTBBQUJDY0lzQUJMQWtzQkVrQUFCQ2NKc0FBbFN3RUxKUWhGQ2tzSE9BY3lDaEpBQUFRbkNyQUFTd2M0Q0VsRkNrc0tEMEFBQkNjS3NBQWlKd1JsUkVra0NDY0VUR2NXU1VVUUtreFFTVVVQdlVVQlFRQUVKd2l3QURFQVN3ZzRBRXNJRmtzSUZsQkxCeFpRVHdKUUp3VlFURkJMQ1JaUVN3NU12eUpGREVzTFN3RU1RUUJ3U3dOWEFnQkxEQ01MVEVzQlcwc0RWd0lBVHdJaldFVVNTWWdEOXhaTEQweFFTVVVSSWtVTUp3Wk1VRWxGRDcxRkFVRUFCMHNOdmtRWFJRdExDaFpMRUV4UUsweFFTVVVPdlVVQlFRQUVKd213QUVzUUp3VlFJaFpRU3cxTXYwc0tKQWdXU3c1TXYwc0xKQWhGREVML2lDa3lCMmNvU3c5UXNDUkROaG9CU1JVakVrUVhOaG9DU1JVa0VrUWlVMHlJQTJrV0treFFTYjFGQVVBQUJDY0xzQUJIQW9FNEpMb2lTd1JVZ1RoTXV5a3lCMmNrUXpZYUFVa1ZJeEpFRnpZYUFra1ZJeEpFRnpZYUEwa1ZJeEpFRnpZYUJFa1ZKQkpFSWxOT0E0Z0RIRXNCaUFNdlR3SVdUd0lXVUV3V1VDdE1VRW05UlFGQUFBUW5ETEFBUndJakpMb2lTd1JVSTB5N0tUSUhaeVJESWtjR2dBQkhBallhQVVjQ0ZTTVNSQmMyR2dKSlRnSkpGU01TUkJkTU5ob0RTVTRDRllGQUVrU0lBc0VXU1NwTVVFbTlSUUZBQUFRbkM3QUFTYjVFZ2NBRFUwQUFESUFJUlZKU09sQkVVRW13QUVzRFNZZ0NyUlpMQWt4UVNVVVBKd1pNVUVsRkFyMUZBVUFBREVzQ2lBSzRTQ2hNVUxBa1EwbStSQmRGQ1VzQ2lBS21SUTVGQ2lKRkNFc0hTd2tNUVFFWlN3Y1dTVVVSU3c1TVVDdE1VRWxGREwxRkFVQUFCQ2NNc0FCTENyNU1TVTRDUlE1RWdVQlRRQUFNZ0FoRlVsSTZVRVJJUkxBQVN3c2lXMFVITWdwekFrUXlDaEpBQUF5QUNFVlNVanBRUkVGQnNBQ3hNZ3BMQjBsT0FuSUlSTElnSXJJSXNnY2tzaEFpc2dHenNUSUlGakVBVHdLeUdJQUV3bzNnaXJJYVRMSWFTd2F5R2tzRnNocExFTElhc2hwTERMSWFKd1d5R29FR3NoQWlzZ0d6dEQ1SlJSQkpWd1FBU1U0Q1JReFhBQVFvRWtRVmdUZ1NSRElLY3dKRU1nb1NRQUFNZ0FoRlVsSTZVRVJTUXJBQVN3eEpWd0FJVEZjSUNFc1FTVmNFQ0VzQlZ3d0lTd0pYRkFoTEExY2NDRXNFVnlRSVR3VlhMQWhQQjA4SFVFOEdVRThGVUU4RVVFOERVRThDVUV4UVJRMUxCeVFJUlFoQy90OUxDVUwrd2pZYUFVa1ZJeEpFRnhZcVRGQkp2VVVCUVFBSlNiNUVLRXhRc0NSRGdHRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVF2K1VOaG9CU1JVakVrUVhOaG9DU1JVakVrUVhTWWdBdTB3V1RCWlFKd1pNVUVtOVJRRkJBQXRKdmtRWEZpaE1VTEFrUXlKQy8vVTJHZ0ZKRlNNU1JCYzJHZ0pKRlNNU1JCYzJHZ05KRlNNU1JCZExBWWdBZkU4Q0ZrOENGbEJNRmxBclRGQkp2VVVCUVFBSlNiNUVLRXhRc0NSRGdCRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFTC81RFlhQVVrVkl4SkVGeVVMSlFnV2dCd1ZIM3gxQUFBQUFBQUJFWEFBQUFBQUFBQk9JQUFBQUFBQUFNTlFURkN3SkVNeEFDSW5CMlZFRWtBQURJQUlSVkpTT2xCRVFVK3dBSW1LQVFDTC8wRUFHWXYvZ1F3T1FRQVJKRUFBRElBSVJWSlNPbEJFU0ZDd0FJa2lRdi9zaWdFQ2kvOVhFQWlMLzFjWUNJdi9WeUFJaS85WEtBaUwvMWN3Q0l2L1Z6Z0lUd1ZQQlZCUEJGQlBBMUJQQWxCTVVDSVdVSXYvaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
