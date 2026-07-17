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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper5_410afb7d
{


    //
    // Helper contract 5 for PoolManager
    //
    public class PoolManager__Helper5Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper5Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class PoolModifyLiquidityChunk2Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public Structs.PoolModifyLiquidityChunk2ReturnField6 Field6 { get; set; } = new Structs.PoolModifyLiquidityChunk2ReturnField6();

                public Structs.ModifyLiquidityState Field7 { get; set; } = new Structs.ModifyLiquidityState();

                public ulong Field8 { get; set; }

                public ulong Field9 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    ret.AddRange(Field6.ToByteArray());
                    ret.AddRange(Field7.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField9.From(Field9);
                    ret.AddRange(vField9.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolModifyLiquidityChunk2Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolModifyLiquidityChunk2Return();
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
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    ret.Field6 = Structs.PoolModifyLiquidityChunk2ReturnField6.Parse(queue.ToArray());
                    { var consumedField6 = ret.Field6.ToByteArray().Length; for (int i = 0; i < consumedField6 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Field7 = Structs.ModifyLiquidityState.Parse(queue.ToArray());
                    { var consumedField7 = ret.Field7.ToByteArray().Length; for (int i = 0; i < consumedField7 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField9.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is ulong vField9Value) { ret.Field9 = vField9Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolModifyLiquidityChunk2Return);
                }
                public bool Equals(PoolModifyLiquidityChunk2Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolModifyLiquidityChunk2Return left, PoolModifyLiquidityChunk2Return right)
                {
                    return EqualityComparer<PoolModifyLiquidityChunk2Return>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolModifyLiquidityChunk2Return left, PoolModifyLiquidityChunk2Return right)
                {
                    return !(left == right);
                }

            }

            public class PoolModifyLiquidityChunk2ReturnField6 : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolModifyLiquidityChunk2ReturnField6 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolModifyLiquidityChunk2ReturnField6();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolModifyLiquidityChunk2ReturnField6);
                }
                public bool Equals(PoolModifyLiquidityChunk2ReturnField6? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolModifyLiquidityChunk2ReturnField6 left, PoolModifyLiquidityChunk2ReturnField6 right)
                {
                    return EqualityComparer<PoolModifyLiquidityChunk2ReturnField6>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolModifyLiquidityChunk2ReturnField6 left, PoolModifyLiquidityChunk2ReturnField6 right)
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
        public async Task<Structs.PoolModifyLiquidityChunk2Return> PoolModifyLiquidityChunk2(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 115, 170, 32 };
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);

            var result = await base.CallApp(new List<object> { abiHandle, self, @params, delta, feeDelta, liquidityDelta, state, tickLowerAbi, tickUpperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolModifyLiquidityChunk2Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PoolModifyLiquidityChunk2_Transactions(Structs.State self, Structs.ModifyLiquidityParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 feeDelta, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidityDelta, Structs.ModifyLiquidityState state, ulong tickLower, ulong tickUpper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 115, 170, 32 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjUiLCJkZXNjIjoiSGVscGVyIGNvbnRyYWN0IDUgZm9yIFBvb2xNYW5hZ2VyIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1vZGlmeUxpcXVpZGl0eVBhcmFtcyI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6InRpY2tMb3dlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWNrVXBwZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlxdWlkaXR5RGVsdGEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNhbHQiLCJ0eXBlIjoidWludDhbMzJdIn1dLCJNb2RpZnlMaXF1aWRpdHlTdGF0ZSI6W3sibmFtZSI6ImZsaXBwZWRMb3dlciIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImxpcXVpZGl0eUdyb3NzQWZ0ZXJMb3dlciIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmxpcHBlZFVwcGVyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGlxdWlkaXR5R3Jvc3NBZnRlclVwcGVyIiwidHlwZSI6InVpbnQyNTYifV0sIlN0YXRlIjpbeyJuYW1lIjoic2xvdDAiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiZmVlR3Jvd3RoR2xvYmFsMFgxMjgiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZlZUdyb3d0aEdsb2JhbDFYMTI4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJsaXF1aWRpdHkiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRpY2tzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InRpY2tCaXRtYXAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoicG9zaXRpb25zIiwidHlwZSI6ImJ5dGVbXSJ9XSwiUG9vbE1vZGlmeUxpcXVpZGl0eUNodW5rMlJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJQb29sTW9kaWZ5TGlxdWlkaXR5Q2h1bmsyUmV0dXJuRmllbGQ2In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6Ik1vZGlmeUxpcXVpZGl0eVN0YXRlIn0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkOSIsInR5cGUiOiJ1aW50NjQifV0sIlBvb2xNb2RpZnlMaXF1aWRpdHlDaHVuazJSZXR1cm5GaWVsZDYiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiUG9vbC5tb2RpZnlMaXF1aWRpdHlfX2NodW5rXzIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NixieXRlW10sYnl0ZVtdLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJTdGF0ZSIsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDI1Nix1aW50NjQsdWludDhbMzJdKSIsInN0cnVjdCI6Ik1vZGlmeUxpcXVpZGl0eVBhcmFtcyIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWx0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZURlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlxdWlkaXR5RGVsdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OCx1aW50MjU2LHVpbnQ4LHVpbnQyNTYpIiwic3RydWN0IjoiTW9kaWZ5TGlxdWlkaXR5U3RhdGUiLCJuYW1lIjoic3RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tMb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja1VwcGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiwodWludDI1Nix1aW50MjU2LHVpbnQyNTYpLCh1aW50OCx1aW50MjU2LHVpbnQ4LHVpbnQyNTYpLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUG9vbE1vZGlmeUxpcXVpZGl0eUNodW5rMlJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9faW5pdF9fIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODY1XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwM10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjE4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjExXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB1bmF1dGhvcml6ZWQgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NTBdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3OSwxNTAyLDE1MjQsMTg1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgTW9kaWZ5TGlxdWlkaXR5UGFyYW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBNb2RpZnlMaXF1aWRpdHlTdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgU3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODU3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDcsMTU1NiwxNTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1ODIsMTU5MSwxODM0LDE4NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNCBvZiAodWludDhbMzJdLHVpbnQyNTYsdWludDI1Nix1aW50MjU2LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA1IG9mICh1aW50OFszMl0sdWludDI1Nix1aW50MjU2LHVpbnQyNTYsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDYgb2YgKHVpbnQ4WzMyXSx1aW50MjU2LHVpbnQyNTYsdWludDI1NiwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDY1LDE0ODksMTUxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQwLDExNjksMTIxNCwxNzM3LDE3NDksMTc2MSwxNzczLDE3ODUsMTc5Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc4LDEzNzNdLCJlcnJvck1lc3NhZ2UiOiJyZXZlcnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pVdVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNQ0E0SURJZ09USXlNek0zTWpBek5qZzFORGMzTlRnd09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZUNBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNaUFpZEdsamEzTWlJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQWlieUlnTUhnd01TQWljQ0lnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aaUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWdYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1Um5Wc2JFMWhkR2d1YlhWc1JHbDJLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeXdnWkdWdWIyMXBibUYwYjNJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1JuVnNiRTFoZEdndWJYVnNSR2wyT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlvS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRElLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWWp3S0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1JwWnlBeENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZajA5Q2lBZ0lDQmllaUJHZFd4c1RXRjBhQzV0ZFd4RWFYWmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1JuVnNiRTFoZEdndWJYVnNSR2wyWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZajRLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpSmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZaThLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVEVLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlMd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdaR2xuSURJS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUx3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmlmQW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSmVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa3hwY1hWcFpHbDBlVTFoZEdndVlXUmtSR1ZzZEdFb2VEb2dZbmwwWlhNc0lIazZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tUR2x4ZFdsa2FYUjVUV0YwYUM1aFpHUkVaV3gwWVRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNZ29nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1RHbHhkV2xrYVhSNVRXRjBhQzVoWkdSRVpXeDBZVjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW53S0NreHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVjJaWEowQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NreHBjWFZwWkdsMGVVMWhkR2d1WVdSa1JHVnNkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmlJRXhwY1hWcFpHbDBlVTFoZEdndVlXUmtSR1ZzZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyd3VaMlYwUm1WbFIzSnZkM1JvU1c1emFXUmxLSE5sYkdZNklHSjVkR1Z6TENCMGFXTnJURzkzWlhJNklIVnBiblEyTkN3Z2RHbGphMVZ3Y0dWeU9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE02Q2xCdmIyd3VaMlYwUm1WbFIzSnZkM1JvU1c1emFXUmxPZ29nSUNBZ2NISnZkRzhnTXlBekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHTmhiR3h6ZFdJZ1UyeHZkREJNYVdKeVlYSjVMblJwWTJzS0lDQWdJR2x1ZEdNZ05DQXZMeUE1TWpJek16Y3lNRE0yT0RVME56YzFPREE0Q2lBZ0lDQmVDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFl5QTBJQzh2SURreU1qTXpOekl3TXpZNE5UUTNOelU0TURnS0lDQWdJRjRLSUNBZ0lEd0tJQ0FnSUdKNklGQnZiMnd1WjJWMFJtVmxSM0p2ZDNSb1NXNXphV1JsWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHbGphM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBhV05yY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEazJJRE15Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2dwUWIyOXNMbWRsZEVabFpVZHliM2QwYUVsdWMybGtaVjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnY21WMGMzVmlDZ3BRYjI5c0xtZGxkRVpsWlVkeWIzZDBhRWx1YzJsa1pWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZeUEwSUM4dklEa3lNak16TnpJd016WTROVFEzTnpVNE1EZ0tJQ0FnSUY0S0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQThQUW9nSUNBZ1lub2dVRzl2YkM1blpYUkdaV1ZIY205M2RHaEpibk5wWkdWZlpXeHpaVjlpYjJSNVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBhV05yY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJwWTJ0eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0lnVUc5dmJDNW5aWFJHWldWSGNtOTNkR2hKYm5OcFpHVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNncFFiMjlzTG1kbGRFWmxaVWR5YjNkMGFFbHVjMmxrWlY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBhV05yY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGFXTnJjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlzS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZaUJRYjI5c0xtZGxkRVpsWlVkeWIzZDBhRWx1YzJsa1pWOWhablJsY2w5cFpsOWxiSE5sUURZS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXphWFJwYjI0dVoyVjBLSE5sYkdZNklHSjVkR1Z6TENCdmQyNWxjam9nWW5sMFpYTXNJSFJwWTJ0TWIzZGxjam9nZFdsdWREWTBMQ0IwYVdOclZYQndaWEk2SUhWcGJuUTJOQ3dnYzJGc2REb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFFiM05wZEdsdmJpNW5aWFE2Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQlFiM05wZEdsdmJpNWpZV3hqZFd4aGRHVlFiM05wZEdsdmJrdGxlUW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk5sYkdZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5emFYUnBiMjR1ZFhCa1lYUmxLSE5sYkdZNklHSjVkR1Z6TENCc2FYRjFhV1JwZEhsRVpXeDBZVG9nWW5sMFpYTXNJR1psWlVkeWIzZDBhRWx1YzJsa1pUQllNVEk0T2lCaWVYUmxjeXdnWm1WbFIzSnZkM1JvU1c1emFXUmxNVmd4TWpnNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ3BRYjNOcGRHbHZiaTUxY0dSaGRHVTZDaUFnSUNCd2NtOTBieUEwSURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ1VHOXphWFJwYjI0dWRYQmtZWFJsWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSTlQUW9nSUNBZ1lub2dVRzl6YVhScGIyNHVkWEJrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZMkZzYkhOMVlpQkRkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYUFvS1VHOXphWFJwYjI0dWRYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJHZFd4c1RXRjBhQzV0ZFd4RWFYWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyRnNiSE4xWWlCR2RXeHNUV0YwYUM1dGRXeEVhWFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMwMENpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J5WlhSemRXSUtDbEJ2YzJsMGFXOXVMblZ3WkdGMFpWOWxiSE5sWDJKdlpIbEFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqWVd4c2MzVmlJRXhwY1hWcFpHbDBlVTFoZEdndVlXUmtSR1ZzZEdFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzAwQ2lBZ0lDQmlJRkJ2YzJsMGFXOXVMblZ3WkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURjS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVUyeHZkREJNYVdKeVlYSjVMblJwWTJzb1gzQmhZMnRsWkRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1UyeHZkREJNYVdKeVlYSjVMblJwWTJzNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUx3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURJS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRk5zYjNRd1RHbGljbUZ5ZVM1MGFXTnJYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aakF3TURBd01Bb2dJQ0FnWW53S0NsTnNiM1F3VEdsaWNtRnllUzUwYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LVTJ4dmREQk1hV0p5WVhKNUxuUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdZaUJUYkc5ME1FeHBZbkpoY25rdWRHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnb01Ta29jMlZzWldOMGIzSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncERkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYURvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1pYSnlJQzh2SUhKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjNOcGRHbHZiaTVqWVd4amRXeGhkR1ZRYjNOcGRHbHZia3RsZVNodmQyNWxjam9nWW5sMFpYTXNJSFJwWTJ0TWIzZGxjam9nZFdsdWREWTBMQ0IwYVdOclZYQndaWEk2SUhWcGJuUTJOQ3dnYzJGc2REb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFFiM05wZEdsdmJpNWpZV3hqZFd4aGRHVlFiM05wZEdsdmJrdGxlVG9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qa3daR1ZqWkRrMU5EaGlOakpoT0dRMk1ETTBOV0U1T0Rnek9EWm1ZemcwWW1FMlltTTVOVFE0TkRBd09HWTJNell5Wmprek1UWXdaV1l6WlRVMk13b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkxTGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3BmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHpvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU9Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlUSTNNMkZoTWpBZ01IaGhPVFpsWmprNE9TQXZMeUJ0WlhSb2IyUWdJbEJ2YjJ3dWJXOWthV1o1VEdseGRXbGthWFI1WDE5amFIVnVhMTh5S0NoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzWW5sMFpWdGRMR0o1ZEdWYlhTeGllWFJsVzEwcExDaDFhVzUwT0Zzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBNalUyTEhWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBwTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMQ2gxYVc1ME9DeDFhVzUwTWpVMkxIVnBiblE0TEhWcGJuUXlOVFlwTEhWcGJuUTJOQ3gxYVc1ME5qUXBLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTENoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtzS0hWcGJuUTRMSFZwYm5ReU5UWXNkV2x1ZERnc2RXbHVkREkxTmlrc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSWw5ZmFXNXBkRjlmS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCUWIyOXNMbTF2WkdsbWVVeHBjWFZwWkdsMGVWOWZZMmgxYm10Zk1pQmZYMmx1YVhSZlh3b2dJQ0FnWlhKeUNncGZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYMTlmWDJKaGNtVmZZM0psWVhSbFgxOUFPRG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJMUxsQnZiMnd1Ylc5a2FXWjVUR2x4ZFdsa2FYUjVYMTlqYUhWdWExOHlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LVUc5dmJDNXRiMlJwWm5sTWFYRjFhV1JwZEhsZlgyTm9kVzVyWHpJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRJNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV6TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0EwSUc5bUlDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV6TmdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UTXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQTFJRzltSUNoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3BDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNVE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0EySUc5bUlDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2twQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGTjBZWFJsQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1qQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUUxdlpHbG1lVXhwY1hWcFpHbDBlVkJoY21GdGN3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRTF2WkdsbWVVeHBjWFZwWkdsMGVWTjBZWFJsQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJRkJ2YjJ3dWJXOWthV1o1VEdseGRXbGthWFI1WDE5amFIVnVhMTh5WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nVUc5dmJDNXRiMlJwWm5sTWFYRjFhV1JwZEhsZlgyTm9kVzVyWHpKZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NsQnZiMnd1Ylc5a2FXWjVUR2x4ZFdsa2FYUjVYMTlqYUhWdWExOHlYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJRYjI5c0xtZGxkRVpsWlVkeWIzZDBhRWx1YzJsa1pRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdVRzl2YkM1blpYUkdaV1ZIY205M2RHaEpibk5wWkdVS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEZzRJRE15Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQlFiM05wZEdsdmJpNW5aWFFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR1JwWnlBMkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJRYjNOcGRHbHZiaTUxY0dSaGRHVUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lIQnZjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEZ0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TlM1ZlgybHVhWFJmWDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNsOWZhVzVwZEY5Zk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nWVd4eVpXRmtlU0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYnlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbkFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pVdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGSUFBSUFvQ0FnSUNBZ0lDQWdBRW1DaUVCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnVjBhV05yYzRBQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJid0VCQVhBUS8vLy8vLy8vLy8vLy8vLy8vLy8vL3hFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUVJRWVJb0RBWXY5aS82alJ3SW9xa2xQQW9BZy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLytxU1NpZ1N3S2hLS29vb0V4UEFxUXBKd1pQQWsyaEtLcEpUZ0tMLzBzQnBVUWpGcWhCQUFhTC82S01BSW1MQUl2L3Fvc0JLS0JMQVU4RFNVNERwU2tuQms4Q1RhRW9xa3dvb0U4Q29TaXFLSXYvb1NpcWkvK3NpLzlMQWFLTS8weExBYUlvU3dLaEtLcFBBcUluQnFBb3FrOENveWlxcTRFREZvdi9veWlxSlJhdGkvOUxBYU1vcWlwTW9TaXFveWlxaS85TEFhTW9xaXBNb1NpcW95aXFpLzlMQWFNb3FpcE1vU2lxb3lpcWkvOUxBYU1vcWlwTW9TaXFveWlxaS85TEFhTW9xaXBNb1NpcW95aXFpLzlMQWFNb3FpcE1vU2lxb3lpcW95aXFqQUNKaWdJQmkvNG5DS3lMLzRBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUNpZ0FFQ3FpbXBRUUJVaS8rQUlQLy8vLy8vLy8vLy8vLy8vLy8vLy84QUFBQUFBQUFBQUFBQUFBQUFBQUFBcTRzQW9DaXFTWUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2lLYWtVUkV5SmkvOG5DS3hDLzhtS0F3TWppLzFYQUNDSUFnOGhCQnRKaS80aEJCc01RUUJEaS80V0FTdE1VTDRuQkU0Q1RVbFhRQ0Fvb0l2L0ZnRXJURkMrSndST0FrMUpWMEFnVHdKTW9TaXFqQUJNVjJBZ0tLQk1WMkFnb1NpcWl3Qk1pLzFQQkU4RWlZdi9JUVFiaXdFT1FRQThpLzhXQVN0TVVMNG5CRTRDVFVsWFFDQW9vSXYrRmdFclRGQytKd1JPQWsxSlYwQWdUd0pNb1NpcWpBQk1WMkFnS0tCTVYyQWdvU2lxUXYrdmkvMVhJQ0Fvb0l2K0ZnRXJURkMrSndST0FrMUpWMEFnVHdKTW9TaXFLS0NML3hZQksweFF2aWNFVGdKTlNWZEFJRThDVEtFb3Fvd0FpLzFYUUNBb29FOENWMkFnb1NpcUtLQk1WMkFnb1NpcVF2OWJpZ1VCaS95TC9ZditpLytJQWFnQmdBUnpaV3htVEZDK2dHQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCT0FrMkppZ1FEaS94WEFDQWpGa21ML2FoQkFIS0xBSXNCcUVFQUJDbUlBUmVML2lpZ2kveFhJQ0NoS0txTEFFbE9BaWNKaVB5emkvOG9vSXY4VjBBZ1RFc0JvU2lxVHdNbkNZajhuWXYrRlNJT1JDS3ZpLzVMQWF1TC9GY0FJRXhRVHdOUVNZejhWeUFnaS84VklnNUVpLzlQQXF1TC9GY0FJRThDVUV4UVNZejhUd1JQQkltTC9GY2dJSXY4VjBBZ2l3Q0wvWWo5WlVrVklnNUVJcStyVHdKUVRGQ00vRUwvZDRvQkFTU3ZpLytBSUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFva21BSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBQUFvb0FCQXFvcHFVRUFMb0FnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy84QUFBQ3Jpd0JNVUVrVkpBbGJUSW1BQS8vLy82eEMvK3lLQVFBQWlnUUJnQ0FwRGV6WlZJdGlxTllEUmFtSU9HL0lTNmE4bFVoQUNQWTJMNU1XRHZQbFk0a3hHMEVBSFRFWkZFUXhHRVNDQWdTaWM2b2dCS2x1K1lrMkdnQ09BZ0FKQVg0QU1Sa1VNUmdVRUVNMkdnRkhBaFZMQVlHQUFWbEpnWVlCRWtSTEFreExBbElqV1lHSUFRaExBb0dDQVZsSlN3SVNSRXNEVEVzRFVpTlpKUWdJU3dLQmhBRlpTVXNDRWtSUEEweExBMUlqV1NVSUNCSkVOaG9DU1JXQmVCSkVOaG9EU1JWSkloSkVOaG9FU1JWSkloSkVOaG9GU1JWSkloSkVOaG9HU1JXQlFoSkVOaG9IU1JVa0VrUVhOaG9JU1JVa0VrUVhKd1ZrUVFBME1nUWxEMFF6QUJnbkJXUVNSRE1BQURFQUVrUW5CMlJCQUJveEZvRUJDVGdZSndka0VrUXhGb0VCQ1RrYUFJQUJjMlFTUkVzS1N3SkpUZ0pMQTBsT0JJajhMMDRDU0U0RFN3RkxBNGo4STA0Q1RnUklTWUdFQVZsTEFSVlNWd0lBU3c1SlZ3QWdURmRZSUU0Q1N3TkxCVThFaVB6MFN3bEpUZ1JMQmtzR2lQMW1UZ1ZJVGdKTERpSU9SQ0t2U3hCTEFhdExEaUlPUkVzUFN3S3JVRXNJRlNJT1JFOElTd0tyVUVzSEZTSU9SRThIU3dLclVFc0VGU0lPUkU4RVN3S3JVRXNKSWc1RVR3UlBBcXRRVHdOUVN3VlFUQlpRVEJaUWdBUVZIM3gxVEZDd2dRRkROaG9CU1JVa0VrUVhOaG9DU1JVa0VrUVhOaG9EU1NOWkpRaExBUlVTUkZjQ0FDY0ZaQlJFSndWUEEyY25CMDhDWjRBQmMweG5nUUZEIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
