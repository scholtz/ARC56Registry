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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper59_960e2573
{


    //
    // Helper contract 59 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper59Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper59Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AuxParams : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 LimbSubproduct { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 NonNativeFieldGate1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 NonNativeFieldGate2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 NonNativeFieldGate3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 LimbAccumulator1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 LimbAccumulator2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 MemoryRecordCheck { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 PartialRecordCheck { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 NextGateAccessType { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RecordDelta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 IndexDelta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AdjacentValuesMatchIfAdjacentIndicesMatch { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AccessCheck { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 NextGateAccessTypeIsBoolean { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RomConsistencyCheckIdentity { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RamConsistencyCheckIdentity { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 TimestampDelta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RamTimestampCheckIdentity { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 MemoryIdentity { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 IndexIsMonotonicallyIncreasing { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AuxiliaryIdentity { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLimbSubproduct = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vLimbSubproduct.From(LimbSubproduct);
                    ret.AddRange(vLimbSubproduct.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonNativeFieldGate1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vNonNativeFieldGate1.From(NonNativeFieldGate1);
                    ret.AddRange(vNonNativeFieldGate1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonNativeFieldGate2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vNonNativeFieldGate2.From(NonNativeFieldGate2);
                    ret.AddRange(vNonNativeFieldGate2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonNativeFieldGate3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vNonNativeFieldGate3.From(NonNativeFieldGate3);
                    ret.AddRange(vNonNativeFieldGate3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLimbAccumulator1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vLimbAccumulator1.From(LimbAccumulator1);
                    ret.AddRange(vLimbAccumulator1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLimbAccumulator2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vLimbAccumulator2.From(LimbAccumulator2);
                    ret.AddRange(vLimbAccumulator2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemoryRecordCheck = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vMemoryRecordCheck.From(MemoryRecordCheck);
                    ret.AddRange(vMemoryRecordCheck.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPartialRecordCheck = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vPartialRecordCheck.From(PartialRecordCheck);
                    ret.AddRange(vPartialRecordCheck.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNextGateAccessType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vNextGateAccessType.From(NextGateAccessType);
                    ret.AddRange(vNextGateAccessType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecordDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRecordDelta.From(RecordDelta);
                    ret.AddRange(vRecordDelta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndexDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vIndexDelta.From(IndexDelta);
                    ret.AddRange(vIndexDelta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdjacentValuesMatchIfAdjacentIndicesMatch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAdjacentValuesMatchIfAdjacentIndicesMatch.From(AdjacentValuesMatchIfAdjacentIndicesMatch);
                    ret.AddRange(vAdjacentValuesMatchIfAdjacentIndicesMatch.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation.From(AdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation);
                    ret.AddRange(vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccessCheck = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAccessCheck.From(AccessCheck);
                    ret.AddRange(vAccessCheck.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNextGateAccessTypeIsBoolean = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vNextGateAccessTypeIsBoolean.From(NextGateAccessTypeIsBoolean);
                    ret.AddRange(vNextGateAccessTypeIsBoolean.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRomConsistencyCheckIdentity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRomConsistencyCheckIdentity.From(RomConsistencyCheckIdentity);
                    ret.AddRange(vRomConsistencyCheckIdentity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRamConsistencyCheckIdentity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRamConsistencyCheckIdentity.From(RamConsistencyCheckIdentity);
                    ret.AddRange(vRamConsistencyCheckIdentity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestampDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vTimestampDelta.From(TimestampDelta);
                    ret.AddRange(vTimestampDelta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRamTimestampCheckIdentity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRamTimestampCheckIdentity.From(RamTimestampCheckIdentity);
                    ret.AddRange(vRamTimestampCheckIdentity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemoryIdentity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vMemoryIdentity.From(MemoryIdentity);
                    ret.AddRange(vMemoryIdentity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndexIsMonotonicallyIncreasing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vIndexIsMonotonicallyIncreasing.From(IndexIsMonotonicallyIncreasing);
                    ret.AddRange(vIndexIsMonotonicallyIncreasing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuxiliaryIdentity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAuxiliaryIdentity.From(AuxiliaryIdentity);
                    ret.AddRange(vAuxiliaryIdentity.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AuxParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AuxParams();
                    uint count = 0;
                    var vLimbSubproduct = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vLimbSubproduct.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LimbSubproduct = vLimbSubproduct;
                    var vNonNativeFieldGate1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vNonNativeFieldGate1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.NonNativeFieldGate1 = vNonNativeFieldGate1;
                    var vNonNativeFieldGate2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vNonNativeFieldGate2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.NonNativeFieldGate2 = vNonNativeFieldGate2;
                    var vNonNativeFieldGate3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vNonNativeFieldGate3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.NonNativeFieldGate3 = vNonNativeFieldGate3;
                    var vLimbAccumulator1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vLimbAccumulator1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LimbAccumulator1 = vLimbAccumulator1;
                    var vLimbAccumulator2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vLimbAccumulator2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LimbAccumulator2 = vLimbAccumulator2;
                    var vMemoryRecordCheck = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vMemoryRecordCheck.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.MemoryRecordCheck = vMemoryRecordCheck;
                    var vPartialRecordCheck = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vPartialRecordCheck.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.PartialRecordCheck = vPartialRecordCheck;
                    var vNextGateAccessType = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vNextGateAccessType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.NextGateAccessType = vNextGateAccessType;
                    var vRecordDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRecordDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RecordDelta = vRecordDelta;
                    var vIndexDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vIndexDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.IndexDelta = vIndexDelta;
                    var vAdjacentValuesMatchIfAdjacentIndicesMatch = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAdjacentValuesMatchIfAdjacentIndicesMatch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AdjacentValuesMatchIfAdjacentIndicesMatch = vAdjacentValuesMatchIfAdjacentIndicesMatch;
                    var vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation = vAdjacentValuesMatchIfAdjacentIndicesMatchAndNextAccessIsAReadOperation;
                    var vAccessCheck = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAccessCheck.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AccessCheck = vAccessCheck;
                    var vNextGateAccessTypeIsBoolean = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vNextGateAccessTypeIsBoolean.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.NextGateAccessTypeIsBoolean = vNextGateAccessTypeIsBoolean;
                    var vRomConsistencyCheckIdentity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRomConsistencyCheckIdentity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RomConsistencyCheckIdentity = vRomConsistencyCheckIdentity;
                    var vRamConsistencyCheckIdentity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRamConsistencyCheckIdentity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RamConsistencyCheckIdentity = vRamConsistencyCheckIdentity;
                    var vTimestampDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vTimestampDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TimestampDelta = vTimestampDelta;
                    var vRamTimestampCheckIdentity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRamTimestampCheckIdentity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RamTimestampCheckIdentity = vRamTimestampCheckIdentity;
                    var vMemoryIdentity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vMemoryIdentity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.MemoryIdentity = vMemoryIdentity;
                    var vIndexIsMonotonicallyIncreasing = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vIndexIsMonotonicallyIncreasing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.IndexIsMonotonicallyIncreasing = vIndexIsMonotonicallyIncreasing;
                    var vAuxiliaryIdentity = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAuxiliaryIdentity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AuxiliaryIdentity = vAuxiliaryIdentity;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AuxParams);
                }
                public bool Equals(AuxParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AuxParams left, AuxParams right)
                {
                    return EqualityComparer<AuxParams>.Default.Equals(left, right);
                }
                public static bool operator !=(AuxParams left, AuxParams right)
                {
                    return !(left == right);
                }

            }

            public class G1Point : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 X { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static G1Point Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new G1Point();
                    uint count = 0;
                    var vX = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X = vX;
                    var vY = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Y = vY;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as G1Point);
                }
                public bool Equals(G1Point? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(G1Point left, G1Point right)
                {
                    return EqualityComparer<G1Point>.Default.Equals(left, right);
                }
                public static bool operator !=(G1Point left, G1Point right)
                {
                    return !(left == right);
                }

            }

            public class G1ProofPoint : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 X0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 X1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Y0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Y1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vX0.From(X0);
                    ret.AddRange(vX0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vX1.From(X1);
                    ret.AddRange(vX1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vY0.From(Y0);
                    ret.AddRange(vY0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vY1.From(Y1);
                    ret.AddRange(vY1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static G1ProofPoint Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new G1ProofPoint();
                    uint count = 0;
                    var vX0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vX0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X0 = vX0;
                    var vX1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vX1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X1 = vX1;
                    var vY0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vY0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Y0 = vY0;
                    var vY1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vY1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Y1 = vY1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as G1ProofPoint);
                }
                public bool Equals(G1ProofPoint? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(G1ProofPoint left, G1ProofPoint right)
                {
                    return EqualityComparer<G1ProofPoint>.Default.Equals(left, right);
                }
                public static bool operator !=(G1ProofPoint left, G1ProofPoint right)
                {
                    return !(left == right);
                }

            }

            public class PoseidonExternalParams : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 S1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 S2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 S3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 S4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 U1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 U2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 U3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 U4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 T0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 T1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 T2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 T3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 V1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 V2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 V3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 V4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 QPosByScaling { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vS1.From(S1);
                    ret.AddRange(vS1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vS2.From(S2);
                    ret.AddRange(vS2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vS3.From(S3);
                    ret.AddRange(vS3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vS4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vS4.From(S4);
                    ret.AddRange(vS4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vU1.From(U1);
                    ret.AddRange(vU1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vU2.From(U2);
                    ret.AddRange(vU2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vU3.From(U3);
                    ret.AddRange(vU3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vU4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vU4.From(U4);
                    ret.AddRange(vU4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vT0.From(T0);
                    ret.AddRange(vT0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vT1.From(T1);
                    ret.AddRange(vT1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vT2.From(T2);
                    ret.AddRange(vT2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vT3.From(T3);
                    ret.AddRange(vT3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vV1.From(V1);
                    ret.AddRange(vV1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vV2.From(V2);
                    ret.AddRange(vV2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vV3.From(V3);
                    ret.AddRange(vV3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vV4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vV4.From(V4);
                    ret.AddRange(vV4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQPosByScaling = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vQPosByScaling.From(QPosByScaling);
                    ret.AddRange(vQPosByScaling.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoseidonExternalParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoseidonExternalParams();
                    uint count = 0;
                    var vS1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vS1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.S1 = vS1;
                    var vS2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vS2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.S2 = vS2;
                    var vS3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vS3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.S3 = vS3;
                    var vS4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vS4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.S4 = vS4;
                    var vU1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vU1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.U1 = vU1;
                    var vU2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vU2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.U2 = vU2;
                    var vU3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vU3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.U3 = vU3;
                    var vU4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vU4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.U4 = vU4;
                    var vT0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vT0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.T0 = vT0;
                    var vT1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vT1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.T1 = vT1;
                    var vT2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vT2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.T2 = vT2;
                    var vT3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vT3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.T3 = vT3;
                    var vV1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vV1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.V1 = vV1;
                    var vV2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vV2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.V2 = vV2;
                    var vV3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vV3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.V3 = vV3;
                    var vV4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vV4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.V4 = vV4;
                    var vQPosByScaling = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vQPosByScaling.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.QPosByScaling = vQPosByScaling;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoseidonExternalParams);
                }
                public bool Equals(PoseidonExternalParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoseidonExternalParams left, PoseidonExternalParams right)
                {
                    return EqualityComparer<PoseidonExternalParams>.Default.Equals(left, right);
                }
                public static bool operator !=(PoseidonExternalParams left, PoseidonExternalParams right)
                {
                    return !(left == right);
                }

            }

            public class Transcript : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Eta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 EtaTwo { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 EtaThree { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Beta { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Gamma { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] Alphas { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] GateChallenges { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] SumCheckUChallenges { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Rho { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 GeminiR { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 ShplonkNu { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 ShplonkZ { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 PublicInputsDelta { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vEta.From(Eta);
                    ret.AddRange(vEta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEtaTwo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vEtaTwo.From(EtaTwo);
                    ret.AddRange(vEtaTwo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEtaThree = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vEtaThree.From(EtaThree);
                    ret.AddRange(vEtaThree.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vBeta.From(Beta);
                    ret.AddRange(vBeta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGamma = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vGamma.From(Gamma);
                    ret.AddRange(vGamma.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAlphas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[25]");
                    vAlphas.From(Alphas);
                    ret.AddRange(vAlphas.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateChallenges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    vGateChallenges.From(GateChallenges);
                    ret.AddRange(vGateChallenges.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumCheckUChallenges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    vSumCheckUChallenges.From(SumCheckUChallenges);
                    ret.AddRange(vSumCheckUChallenges.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRho = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRho.From(Rho);
                    ret.AddRange(vRho.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiR = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vGeminiR.From(GeminiR);
                    ret.AddRange(vGeminiR.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShplonkNu = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vShplonkNu.From(ShplonkNu);
                    ret.AddRange(vShplonkNu.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShplonkZ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vShplonkZ.From(ShplonkZ);
                    ret.AddRange(vShplonkZ.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicInputsDelta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vPublicInputsDelta.From(PublicInputsDelta);
                    ret.AddRange(vPublicInputsDelta.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Transcript Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Transcript();
                    uint count = 0;
                    var vEta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vEta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Eta = vEta;
                    var vEtaTwo = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vEtaTwo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EtaTwo = vEtaTwo;
                    var vEtaThree = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vEtaThree.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.EtaThree = vEtaThree;
                    var vBeta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vBeta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Beta = vBeta;
                    var vGamma = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vGamma.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Gamma = vGamma;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAlphas = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[25]");
                    count = vAlphas.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAlphas = vAlphas.ToValue();
                    if (valueAlphas is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] vAlphasValue) { ret.Alphas = vAlphasValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateChallenges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    count = vGateChallenges.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGateChallenges = vGateChallenges.ToValue();
                    if (valueGateChallenges is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] vGateChallengesValue) { ret.GateChallenges = vGateChallengesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumCheckUChallenges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    count = vSumCheckUChallenges.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSumCheckUChallenges = vSumCheckUChallenges.ToValue();
                    if (valueSumCheckUChallenges is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] vSumCheckUChallengesValue) { ret.SumCheckUChallenges = vSumCheckUChallengesValue; }
                    var vRho = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRho.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Rho = vRho;
                    var vGeminiR = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vGeminiR.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.GeminiR = vGeminiR;
                    var vShplonkNu = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vShplonkNu.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ShplonkNu = vShplonkNu;
                    var vShplonkZ = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vShplonkZ.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ShplonkZ = vShplonkZ;
                    var vPublicInputsDelta = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vPublicInputsDelta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.PublicInputsDelta = vPublicInputsDelta;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Transcript);
                }
                public bool Equals(Transcript? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Transcript left, Transcript right)
                {
                    return EqualityComparer<Transcript>.Default.Equals(left, right);
                }
                public static bool operator !=(Transcript left, Transcript right)
                {
                    return !(left == right);
                }

            }

            public class RelationsLibAccumulatePoseidonExternalRelationChunk1Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static RelationsLibAccumulatePoseidonExternalRelationChunk1Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulatePoseidonExternalRelationChunk1Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
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
                    return Equals(obj as RelationsLibAccumulatePoseidonExternalRelationChunk1Return);
                }
                public bool Equals(RelationsLibAccumulatePoseidonExternalRelationChunk1Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulatePoseidonExternalRelationChunk1Return left, RelationsLibAccumulatePoseidonExternalRelationChunk1Return right)
                {
                    return EqualityComparer<RelationsLibAccumulatePoseidonExternalRelationChunk1Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulatePoseidonExternalRelationChunk1Return left, RelationsLibAccumulatePoseidonExternalRelationChunk1Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tp"> Transcript</param>
        /// <param name="domainSep"> </param>
        /// <param name="ap"> AuxParams</param>
        /// <param name="limb_accumulator_identity"> </param>
        /// <param name="non_native_field_identity"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> RelationsLibAccumulateAuxillaryRelationChunk4(Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 domainSep, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 176, 201, 212 };

            var result = await base.SimApp(new List<object> { abiHandle, tp, domainSep, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RelationsLibAccumulateAuxillaryRelationChunk4_Transactions(Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 domainSep, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 176, 201, 212 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tp, domainSep, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tp"> Transcript</param>
        /// <param name="domainSep"> </param>
        /// <param name="ep"> PoseidonExternalParams</param>
        public async Task<Structs.RelationsLibAccumulatePoseidonExternalRelationChunk1Return> RelationsLibAccumulatePoseidonExternalRelationChunk1(Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 domainSep, Structs.PoseidonExternalParams ep, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 145, 91, 253 };

            var result = await base.SimApp(new List<object> { abiHandle, tp, domainSep, ep }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulatePoseidonExternalRelationChunk1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulatePoseidonExternalRelationChunk1_Transactions(Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 domainSep, Structs.PoseidonExternalParams ep, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 145, 91, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tp, domainSep, ep }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> G1ProofPoint</param>
        public async Task<Structs.G1Point> ConvertProofPoint(Structs.G1ProofPoint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 241, 154, 149 };

            var result = await base.SimApp(new List<object> { abiHandle, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.G1Point.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ConvertProofPoint_Transactions(Structs.G1ProofPoint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 241, 154, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle, input }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjU5IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA1OSBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXV4UGFyYW1zIjpbeyJuYW1lIjoibGltYl9zdWJwcm9kdWN0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJub25fbmF0aXZlX2ZpZWxkX2dhdGVfMSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibm9uX25hdGl2ZV9maWVsZF9nYXRlXzIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5vbl9uYXRpdmVfZmllbGRfZ2F0ZV8zIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJsaW1iX2FjY3VtdWxhdG9yXzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImxpbWJfYWNjdW11bGF0b3JfMiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibWVtb3J5X3JlY29yZF9jaGVjayIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicGFydGlhbF9yZWNvcmRfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicmVjb3JkX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJpbmRleF9kZWx0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWRqYWNlbnRfdmFsdWVzX21hdGNoX2lmX2FkamFjZW50X2luZGljZXNfbWF0Y2giLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFkamFjZW50X3ZhbHVlc19tYXRjaF9pZl9hZGphY2VudF9pbmRpY2VzX21hdGNoX2FuZF9uZXh0X2FjY2Vzc19pc19hX3JlYWRfb3BlcmF0aW9uIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhY2Nlc3NfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZV9pc19ib29sZWFuIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJST01fY29uc2lzdGVuY3lfY2hlY2tfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6IlJBTV9jb25zaXN0ZW5jeV9jaGVja19pZGVudGl0eSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidGltZXN0YW1wX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJSQU1fdGltZXN0YW1wX2NoZWNrX2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJtZW1vcnlfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImluZGV4X2lzX21vbm90b25pY2FsbHlfaW5jcmVhc2luZyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYXV4aWxpYXJ5X2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifV0sIkcxUG9pbnQiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ1MTIifV0sIkcxUHJvb2ZQb2ludCI6W3sibmFtZSI6InhfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieF8xIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ5XzAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMSIsInR5cGUiOiJ1aW50NTEyIn1dLCJQb3NlaWRvbkV4dGVybmFsUGFyYW1zIjpbeyJuYW1lIjoiczEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InMyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzMyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiczQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InUxIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ1MiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidTMiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InU0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ0MCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidDEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InQyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ0MyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidjEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InYyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ2MyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidjQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InFfcG9zX2J5X3NjYWxpbmciLCJ0eXBlIjoidWludDUxMiJ9XSwiVHJhbnNjcmlwdCI6W3sibmFtZSI6ImV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZXRhVHdvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUaHJlZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYmV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2FtbWEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFscGhhcyIsInR5cGUiOiJ1aW50NTEyWzI1XSJ9LHsibmFtZSI6ImdhdGVDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic3VtQ2hlY2tVQ2hhbGxlbmdlcyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InJobyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2VtaW5pUiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoic2hwbG9ua051IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rWiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicHVibGljSW5wdXRzRGVsdGEiLCJ0eXBlIjoidWludDUxMiJ9XSwiUmVsYXRpb25zTGliQWNjdW11bGF0ZVBvc2VpZG9uRXh0ZXJuYWxSZWxhdGlvbkNodW5rMVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDUxMiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJSZWxhdGlvbnNMaWIuYWNjdW11bGF0ZUF1eGlsbGFyeVJlbGF0aW9uX19jaHVua180IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkb21haW5TZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IkF1eFBhcmFtcyIsIm5hbWUiOiJhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpbWJfYWNjdW11bGF0b3JfaWRlbnRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25fbmF0aXZlX2ZpZWxkX2lkZW50aXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUmVsYXRpb25zTGliLmFjY3VtdWxhdGVQb3NlaWRvbkV4dGVybmFsUmVsYXRpb25fX2NodW5rXzEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyWzI1XSx1aW50NTEyWzI4XSx1aW50NTEyWzI4XSx1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiVHJhbnNjcmlwdCIsIm5hbWUiOiJ0cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvbWFpblNlcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikiLCJzdHJ1Y3QiOiJQb3NlaWRvbkV4dGVybmFsUGFyYW1zIiwibmFtZSI6ImVwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMikiLCJzdHJ1Y3QiOiJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUG9zZWlkb25FeHRlcm5hbFJlbGF0aW9uQ2h1bmsxUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb252ZXJ0UHJvb2ZQb2ludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikiLCJzdHJ1Y3QiOiJHMVByb29mUG9pbnQiLCJuYW1lIjoiaW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMikiLCJzdHJ1Y3QiOiJHMVBvaW50IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyMiw2ODUsNzI0LDc1N10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIEF1eFBhcmFtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBHMVByb29mUG9pbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUG9zZWlkb25FeHRlcm5hbFBhcmFtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OCw2NjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVHJhbnNjcmlwdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NiwxOTQsMjAyLDY2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjMsNDc4LDY0Myw3ODksODAyLDgxNCw4NTEsODc1XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU5Ua3VYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dOalFnTVRBeU5DQTVOakFnT0RNeUlERXlNVFlnTVRJNE1DQXlOVFlnT0RrMklERXdPRGdnTVRNME5Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERWdJaUlnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YUc5dWF5OWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxMMFZqWkhOaFNHOXVhMVpsY21sbWFXVnlMbk52YkM1U1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlNod09pQjFhVzUwTmpRc0lGOTNhWEpsT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4dllXUnpDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YUc5dWF5OWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxMMFZqWkhOaFNHOXVhMVpsY21sbWFXVnlMbk52YkM1RlkyUnpZVWh2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOG9LU0F0UGlCMWFXNTBOalE2Q2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5Zk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9EQmlNR001WkRRZ01IZzVZamt4TldKbVpDQXdlRE5rWmpFNVlUazFJQzh2SUcxbGRHaHZaQ0FpVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVkJkWGhwYkd4aGNubFNaV3hoZEdsdmJsOWZZMmgxYm10Zk5DZ29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVEpiTWpWZExIVnBiblExTVRKYk1qaGRMSFZwYm5RMU1USmJNamhkTEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NkV2x1ZERVeE1pd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1hWcGJuUTFNVElpTENCdFpYUm9iMlFnSWxKbGJHRjBhVzl1YzB4cFlpNWhZMk4xYlhWc1lYUmxVRzl6Wldsa2IyNUZlSFJsY201aGJGSmxiR0YwYVc5dVgxOWphSFZ1YTE4eEtDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNbHN5TlYwc2RXbHVkRFV4TWxzeU9GMHNkV2x1ZERVeE1sc3lPRjBzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTeDFhVzUwTlRFeUxDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBLU2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa2lMQ0J0WlhSb2IyUWdJbU52Ym5abGNuUlFjbTl2WmxCdmFXNTBLQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTa29kV2x1ZERVeE1peDFhVzUwTlRFeUtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRkpsYkdGMGFXOXVjMHhwWWk1aFkyTjFiWFZzWVhSbFFYVjRhV3hzWVhKNVVtVnNZWFJwYjI1ZlgyTm9kVzVyWHpRZ1VtVnNZWFJwYjI1elRHbGlMbUZqWTNWdGRXeGhkR1ZRYjNObGFXUnZia1Y0ZEdWeWJtRnNVbVZzWVhScGIyNWZYMk5vZFc1clh6RWdZMjl1ZG1WeWRGQnliMjltVUc5cGJuUUtJQ0FnSUdWeWNnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlvYjI1ckwyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVXZSV05rYzJGSWIyNXJWbVZ5YVdacFpYSXVjMjlzTGtWalpITmhTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEkxT1M1U1pXeGhkR2x2Ym5OTWFXSXVZV05qZFcxMWJHRjBaVUYxZUdsc2JHRnllVkpsYkdGMGFXOXVYMTlqYUhWdWExODBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVkJkWGhwYkd4aGNubFNaV3hoZEdsdmJsOWZZMmgxYm10Zk5Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0ExT0RJMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJVY21GdWMyTnlhWEIwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUwTURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRUYxZUZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJaUlLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01URTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1pQXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdsdWRDQTNNRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCcGJuUmpJRFVnTHk4Z01USTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0JwYm5SaklEWWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVElLSUNBZ0lIQjFjMmhwYm5RZ016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURFMENpQWdJQ0J3ZFhOb2FXNTBJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTFDaUFnSUNCd2RYTm9hVzUwSURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQnBiblJqSURjZ0x5OGdPRGsyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnY0hWemFHbHVkQ0EwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNUW9nSUNBZ2NIVnphR2x1ZENBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qSUtJQ0FnSUdsdWRHTWdPQ0F2THlBeE1EZzRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREV3TWpRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURFeE5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPVFl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdjSFZ6YUdsdWRDQTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEa2dMeThnTVRNME5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBNENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURjS0lDQWdJSEIxYzJocGJuUWdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QTFJQzh2SURFeU9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURZZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUhCMWMyaHBiblFnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEl4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXpDaUFnSUNCd2RYTm9hVzUwSURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQndkWE5vYVc1MElEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklEY2dMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ05qUUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2NIVnphR2x1ZENBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5TUFvZ0lDQWdjSFZ6YUdsdWRDQTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nT0NBdkx5QXhNRGc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWXlBNUlDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMa1ZqWkhOaFNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSTFPUzVTWld4aGRHbHZibk5NYVdJdVlXTmpkVzExYkdGMFpWQnZjMlZwWkc5dVJYaDBaWEp1WVd4U1pXeGhkR2x2Ymw5ZlkyaDFibXRmTVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNsSmxiR0YwYVc5dWMweHBZaTVoWTJOMWJYVnNZWFJsVUc5elpXbGtiMjVGZUhSbGNtNWhiRkpsYkdGMGFXOXVYMTlqYUhWdWExOHhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURVNE1qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZSeVlXNXpZM0pwY0hRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpJRGdnTHk4Z01UQTRPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1VHOXpaV2xrYjI1RmVIUmxjbTVoYkZCaGNtRnRjd29nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlJZ29nSUNBZ2JHOWhaSE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklERXlNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREV3TWpRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR0l0Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUExSUM4dklERXlPREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBM0lDOHZJRGc1TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTkRFS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCemQyRndDaUFnSUNCaUxRb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaR2xuSURNS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWXlBNUlDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTVOakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2NIVnphR2x1ZENBME1nb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMa1ZqWkhOaFNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSTFPUzVqYjI1MlpYSjBVSEp2YjJaUWIybHVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJuWmxjblJRY205dlpsQnZhVzUwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTmlBdkx5QXlOVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFY3hVSEp2YjJaUWIybHVkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElEWTBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpb0tJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUEyTkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lxQ2lBZ0lDQmlmQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YUc5dWF5OWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxMMFZqWkhOaFNHOXVhMVpsY21sbWFXVnlMbk52YkM1RlkyUnpZVWh2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFLUUlBSXdBZkFCc0FKZ0FxQUFvQUh3QWpBQ2lZRUlEQmtUbkxoTWFBcHVGQkZ0b0dCV0Ywb00raEllYmx3a1VQaDlaUHdBQUFCQUFRVkgzeDFJQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFnQVppZ0lCZ1FpdmkvOFdVRWtWZ1FnSlc0ditQa3dpQ3lKWWlURVpGRVF4R0VTQ0F3U0FzTW5VQkp1UlcvMEVQZkdhbFRZYUFJNERBQUVCN1FLYkFEWWFBUldCd0MwU1JEWWFBa2tWSWhKRU5ob0RTUldCZ0FzU1JEWWFCRWtWSWhKRU5ob0ZTUlVpRWtRcFRnTkxBaU1pV0VzRGdZQUpJbGhMQkNRaVdFc0ZKU0pZU3dhQndBVWlXRXNIZ1lBR0lsaExDQ0VFSWxoSlR3aWdLS3BQQ0tBb3Fra1ZJZzVFSXE5TVN3R3JTd21CZ0FVaVdFc0tJUVVpV0VzTElRWWlXRXNNZ2NBQ0lsaExEVmNBUUVzT2dZQURJbGhMRDRHQUJDSllTeEFoQnlKWVN4RlhRRUJMRWxlQVFFc1RWOEJBU3hTQndBTWlXRXNWZ2NBRUlsaFBGaUVJSWxoUENVOEdVRThGVUU4RVVFOElVRThIVUU4R1VFOERVRThFVUU4Q1VFOEVVRThJVUU4SFVFOEhVRThDVUU4R1VFOEhVRXhRVHdWUVR3UlFURkJNVUVraklsaExBWUdBQ1NKWVN3SWtJbGhMQXlVaVdFc0VnY0FGSWxoTEJZR0FCaUpZU3dZaENTSllUd21CQ1lqK2tVOEtveWlxb3lpcVNSVWlEa1JMQ0t0TEI0R0FCU0pZU3dnaEJTSllTd2toQmlKWVN3cUJ3QUlpV0VzTFZ3QkFTd3doQkNKWVN3MkJnQU1pV0VzT2dZQUVJbGhMRHlFSElsaExFRmRBUUVzUlY0QkFTeEpYd0VCTEU0SEFBeUpZU3hTQndBUWlXRThWSVFnaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZBaENTSllTUlVpRGtTcktreFFzSUVCUXpZYUFSV0J3QzBTUkRZYUFoVWlFa1EyR2dOSkZTRUlFa1FwVENrK1NTRUVJbGhMQWlNaVdFc0RKU0pZU3dXQktJajlwQ2hNb2FBb3Frc0JveWlxVHdLZ0tLcExBaUVGSWxoTEJDRUhJbGhMQm9FcGlQMkJLRXlob0NpcVN3T2pLS3FnS0twUEF5RUpJbGhQQkNRaVdFOEZnU3FJL1dFb1RLR2dLS3BQQktNb3FxQW9xa3NDRlNJT1JDS3ZUd05MQWF0TEF4VWlEa1JQQTBzQ3ExQkxBaFVpRGtST0FxdFFLa3hRc0lFQlF6WWFBVWtWSVFZU1JFbFhBRUJMQVZkQVFDdWpxMGtWSWc1RUlxOU1Td0dyU3dKWGdFQlBBMWZBUUN1anEwa1ZJZzVFVHdLclVDcE1VTENCQVVNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
