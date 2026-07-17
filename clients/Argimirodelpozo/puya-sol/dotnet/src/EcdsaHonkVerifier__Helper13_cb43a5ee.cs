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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper13_cb43a5ee
{


    //
    // Helper contract 13 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper13Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper13Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class Proof : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 CircuitSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 PublicInputsSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 PublicInputsOffset { get; set; }

                public Structs.G1ProofPoint W1 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W2 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W3 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W4 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint ZPerm { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupReadCounts { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupReadTags { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupInverses { get; set; } = new Structs.G1ProofPoint();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[][] SumcheckUnivariates { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] SumcheckEvaluations { get; set; }

                public Structs.G1ProofPoint[] GeminiFoldComms { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] GeminiAEvaluations { get; set; }

                public Structs.G1ProofPoint ShplonkQ { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint KzgQuotient { get; set; } = new Structs.G1ProofPoint();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vCircuitSize.From(CircuitSize);
                    ret.AddRange(vCircuitSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicInputsSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vPublicInputsSize.From(PublicInputsSize);
                    ret.AddRange(vPublicInputsSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicInputsOffset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vPublicInputsOffset.From(PublicInputsOffset);
                    ret.AddRange(vPublicInputsOffset.Encode());
                    ret.AddRange(W1.ToByteArray());
                    ret.AddRange(W2.ToByteArray());
                    ret.AddRange(W3.ToByteArray());
                    ret.AddRange(W4.ToByteArray());
                    ret.AddRange(ZPerm.ToByteArray());
                    ret.AddRange(LookupReadCounts.ToByteArray());
                    ret.AddRange(LookupReadTags.ToByteArray());
                    ret.AddRange(LookupInverses.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckUnivariates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[8][28]");
                    vSumcheckUnivariates.From(SumcheckUnivariates);
                    ret.AddRange(vSumcheckUnivariates.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[44]");
                    vSumcheckEvaluations.From(SumcheckEvaluations);
                    ret.AddRange(vSumcheckEvaluations.Encode());
                    var arrGeminiFoldComms = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 27 };
                    arrGeminiFoldComms.Value = (GeminiFoldComms ?? Array.Empty<Structs.G1ProofPoint>()).ToList();
                    ret.AddRange(arrGeminiFoldComms.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiAEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    vGeminiAEvaluations.From(GeminiAEvaluations);
                    ret.AddRange(vGeminiAEvaluations.Encode());
                    ret.AddRange(ShplonkQ.ToByteArray());
                    ret.AddRange(KzgQuotient.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Proof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Proof();
                    uint count = 0;
                    var vCircuitSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vCircuitSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.CircuitSize = vCircuitSize;
                    var vPublicInputsSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vPublicInputsSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.PublicInputsSize = vPublicInputsSize;
                    var vPublicInputsOffset = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vPublicInputsOffset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.PublicInputsOffset = vPublicInputsOffset;
                    ret.W1 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW1 = ret.W1.ToByteArray().Length; for (int i = 0; i < consumedW1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W2 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW2 = ret.W2.ToByteArray().Length; for (int i = 0; i < consumedW2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W3 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW3 = ret.W3.ToByteArray().Length; for (int i = 0; i < consumedW3 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W4 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW4 = ret.W4.ToByteArray().Length; for (int i = 0; i < consumedW4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.ZPerm = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedZPerm = ret.ZPerm.ToByteArray().Length; for (int i = 0; i < consumedZPerm && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupReadCounts = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupReadCounts = ret.LookupReadCounts.ToByteArray().Length; for (int i = 0; i < consumedLookupReadCounts && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupReadTags = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupReadTags = ret.LookupReadTags.ToByteArray().Length; for (int i = 0; i < consumedLookupReadTags && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupInverses = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupInverses = ret.LookupInverses.ToByteArray().Length; for (int i = 0; i < consumedLookupInverses && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckUnivariates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[8][28]");
                    count = vSumcheckUnivariates.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSumcheckUnivariates = vSumcheckUnivariates.ToValue();
                    if (valueSumcheckUnivariates is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[][] vSumcheckUnivariatesValue) { ret.SumcheckUnivariates = vSumcheckUnivariatesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[44]");
                    count = vSumcheckEvaluations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSumcheckEvaluations = vSumcheckEvaluations.ToValue();
                    if (valueSumcheckEvaluations is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] vSumcheckEvaluationsValue) { ret.SumcheckEvaluations = vSumcheckEvaluationsValue; }
                    var arrGeminiFoldComms = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 27 };
                    { var consumedGeminiFoldComms = (int)arrGeminiFoldComms.Decode(queue.ToArray()); for (int i = 0; i < consumedGeminiFoldComms && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.GeminiFoldComms = arrGeminiFoldComms.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiAEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512[28]");
                    count = vGeminiAEvaluations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGeminiAEvaluations = vGeminiAEvaluations.ToValue();
                    if (valueGeminiAEvaluations is AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] vGeminiAEvaluationsValue) { ret.GeminiAEvaluations = vGeminiAEvaluationsValue; }
                    ret.ShplonkQ = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedShplonkQ = ret.ShplonkQ.ToByteArray().Length; for (int i = 0; i < consumedShplonkQ && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.KzgQuotient = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedKzgQuotient = ret.KzgQuotient.ToByteArray().Length; for (int i = 0; i < consumedKzgQuotient && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Proof);
                }
                public bool Equals(Proof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Proof left, Proof right)
                {
                    return EqualityComparer<Proof>.Default.Equals(left, right);
                }
                public static bool operator !=(Proof left, Proof right)
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

            public class RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public Structs.AuxParams Field4 { get; set; } = new Structs.AuxParams();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field6 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    ret.AddRange(Field4.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return();
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
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    ret.Field4 = Structs.AuxParams.Parse(queue.ToArray());
                    { var consumedField4 = ret.Field4.ToByteArray().Length; for (int i = 0; i < consumedField4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return left, RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return left, RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proof"> Proof</param>
        /// <param name="tp"> Transcript</param>
        /// <param name="powPartialEval"> </param>
        /// <param name="accumulator"> </param>
        /// <param name="evaluations"> </param>
        /// <param name="purportedEvaluations"> </param>
        /// <param name="_evals_13"> </param>
        /// <param name="_evals_14"> </param>
        /// <param name="_evals_15"> </param>
        /// <param name="ap"> AuxParams</param>
        /// <param name="limb_accumulator_identity"> </param>
        /// <param name="non_native_field_identity"> </param>
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return> RelationsLibAccumulateRelationEvaluationsChunk2Chunk13(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_13, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_14, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_15, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 5, 152, 8 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            var result = await base.CallApp(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, _evals_13, _evals_14, _evals_15, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk2Chunk13Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk2Chunk13_Transactions(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_13, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_14, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _evals_15, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 5, 152, 8 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, _evals_13, _evals_14, _evals_15, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjEzIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAxMyBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXV4UGFyYW1zIjpbeyJuYW1lIjoibGltYl9zdWJwcm9kdWN0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJub25fbmF0aXZlX2ZpZWxkX2dhdGVfMSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibm9uX25hdGl2ZV9maWVsZF9nYXRlXzIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5vbl9uYXRpdmVfZmllbGRfZ2F0ZV8zIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJsaW1iX2FjY3VtdWxhdG9yXzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImxpbWJfYWNjdW11bGF0b3JfMiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibWVtb3J5X3JlY29yZF9jaGVjayIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicGFydGlhbF9yZWNvcmRfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicmVjb3JkX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJpbmRleF9kZWx0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWRqYWNlbnRfdmFsdWVzX21hdGNoX2lmX2FkamFjZW50X2luZGljZXNfbWF0Y2giLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFkamFjZW50X3ZhbHVlc19tYXRjaF9pZl9hZGphY2VudF9pbmRpY2VzX21hdGNoX2FuZF9uZXh0X2FjY2Vzc19pc19hX3JlYWRfb3BlcmF0aW9uIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhY2Nlc3NfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZV9pc19ib29sZWFuIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJST01fY29uc2lzdGVuY3lfY2hlY2tfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6IlJBTV9jb25zaXN0ZW5jeV9jaGVja19pZGVudGl0eSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidGltZXN0YW1wX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJSQU1fdGltZXN0YW1wX2NoZWNrX2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJtZW1vcnlfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImluZGV4X2lzX21vbm90b25pY2FsbHlfaW5jcmVhc2luZyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYXV4aWxpYXJ5X2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifV0sIkcxUHJvb2ZQb2ludCI6W3sibmFtZSI6InhfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieF8xIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ5XzAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMSIsInR5cGUiOiJ1aW50NTEyIn1dLCJQcm9vZiI6W3sibmFtZSI6ImNpcmN1aXRTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNPZmZzZXQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6IncxIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6IncyIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InczIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Inc0IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InpQZXJtIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imxvb2t1cFJlYWRDb3VudHMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZFRhZ3MiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwSW52ZXJzZXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoic3VtY2hlY2tVbml2YXJpYXRlcyIsInR5cGUiOiJ1aW50NTEyWzhdWzI4XSJ9LHsibmFtZSI6InN1bWNoZWNrRXZhbHVhdGlvbnMiLCJ0eXBlIjoidWludDUxMls0NF0ifSx7Im5hbWUiOiJnZW1pbmlGb2xkQ29tbXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50WzI3XSJ9LHsibmFtZSI6ImdlbWluaUFFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InNocGxvbmtRIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imt6Z1F1b3RpZW50IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9XSwiVHJhbnNjcmlwdCI6W3sibmFtZSI6ImV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZXRhVHdvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUaHJlZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYmV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2FtbWEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFscGhhcyIsInR5cGUiOiJ1aW50NTEyWzI1XSJ9LHsibmFtZSI6ImdhdGVDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic3VtQ2hlY2tVQ2hhbGxlbmdlcyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InJobyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2VtaW5pUiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoic2hwbG9ua051IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rWiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicHVibGljSW5wdXRzRGVsdGEiLCJ0eXBlIjoidWludDUxMiJ9XSwiUmVsYXRpb25zTGliQWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNDaHVuazJDaHVuazEzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoiQXV4UGFyYW1zIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDUxMiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJSZWxhdGlvbnNMaWIuYWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNfX2NodW5rXzJfX2NodW5rXzEzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLHVpbnQ1MTJbOF1bMjhdLHVpbnQ1MTJbNDRdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKVsyN10sdWludDUxMlsyOF0sKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSkiLCJzdHJ1Y3QiOiJQcm9vZiIsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyWzI1XSx1aW50NTEyWzI4XSx1aW50NTEyWzI4XSx1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiVHJhbnNjcmlwdCIsIm5hbWUiOiJ0cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvd1BhcnRpYWxFdmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjdW11bGF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTJbMjZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZhbHVhdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTJbNDRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9ydGVkRXZhbHVhdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZXZhbHNfMTMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZXZhbHNfMTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZXZhbHNfMTUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IkF1eFBhcmFtcyIsIm5hbWUiOiJhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpbWJfYWNjdW11bGF0b3JfaWRlbnRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25fbmF0aXZlX2ZpZWxkX2lkZW50aXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiUmVsYXRpb25zTGliQWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNDaHVuazJDaHVuazEzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBBdXhQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVHJhbnNjcmlwdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ1MTIsIDI2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ1MTIsIDQ0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NiwxOTMsMjIwLDIyOSwyMzgsMjU3LDI2Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsNTkwLDgwMSwxMDA3LDEyMDgsMTQ1NSwxNjE4LDE5MjIsMjAzNywyMjc0LDI0OTQsMjcyMCwyOTEyLDMwMzIsMzA0MiwzMDUzLDMwNjUsMzA3OCwzMDg5XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU1UTXVYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dOalFnT1RZd0lEZ3pNaUEzTURRZ01UTTBOQ0EyTkRBZ01USTRNQ0F5TlRZZ016SXdJRE00TkNBME5EZ2dOVGMySURFd01qUWdNVEUxTWlBM05qZ2dNVEl4TmlBNE9UWWdNVEE0T0NBMU1USUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TUFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMbEpsYkdGMGFXOXVjMHhwWWk1M2FYSmxLSEE2SUhWcGJuUTJOQ3dnWDNkcGNtVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbEpsYkdGMGFXOXVjMHhwWWk1M2FYSmxPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiRzloWkhNS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMa1ZqWkhOaFNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSXhNeTVmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHlncElDMCtJSFZwYm5RMk5Eb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTg2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1TkRBMU9UZ3dPQ0F2THlCdFpYUm9iMlFnSWxKbGJHRjBhVzl1YzB4cFlpNWhZMk4xYlhWc1lYUmxVbVZzWVhScGIyNUZkbUZzZFdGMGFXOXVjMTlmWTJoMWJtdGZNbDlmWTJoMWJtdGZNVE1vS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzZFdsdWREVXhNbHM0WFZzeU9GMHNkV2x1ZERVeE1sczBORjBzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBXekkzWFN4MWFXNTBOVEV5V3pJNFhTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwS1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USmJNalZkTEhWcGJuUTFNVEpiTWpoZExIVnBiblExTVRKYk1qaGRMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVEpiTWpaZExIVnBiblExTVRKYk5EUmRMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N4MWFXNTBOVEV5TEhWcGJuUTFNVElwS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExIVnBiblExTVRJc2RXbHVkRFV4TWlraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYMTlTWld4aGRHbHZibk5NYVdJdVlXTmpkVzExYkdGMFpWSmxiR0YwYVc5dVJYWmhiSFZoZEdsdmJuTmZYMk5vZFc1clh6SmZYMk5vZFc1clh6RXpYM0p2ZFhSbFFERUtJQ0FnSUdWeWNnb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHlYMTlqYUhWdWExOHhNMTl5YjNWMFpVQXhPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHlYMTlqYUhWdWExOHhNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5b2IyNXJMMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlV2UldOa2MyRkliMjVyVm1WeWFXWnBaWEl1YzI5c0xrVmpaSE5oU0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJeE15NVNaV3hoZEdsdmJuTk1hV0l1WVdOamRXMTFiR0YwWlZKbGJHRjBhVzl1UlhaaGJIVmhkR2x2Ym5OZlgyTm9kVzVyWHpKZlgyTm9kVzVyWHpFelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eVgxOWphSFZ1YTE4eE16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5T0RZd09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVUhKdmIyWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFU0TWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRlJ5WVc1elkzSnBjSFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOalkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTFNVElzSURJMlBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREk0TVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRFV4TWl3Z05EUStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UUXdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1FYVjRVR0Z5WVcxekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE1Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklERXlJQzh2SURFd01qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURFeklDOHZJREV4TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpYekVnTHk4Z09UWXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhVzUwWTE4eUlDOHZJRGd6TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCcGJuUmpYek1nTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR2x1ZEdNZ01UUWdMeThnTnpZNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTkNBdkx5QXhNelEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdOU0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBMklDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUEzSUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwYm5SaklEZ2dMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQnBiblJqSURFMUlDOHZJREV5TVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0J3ZFhOb2FXNTBJRFF4Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JrYVdjZ01qZ0tJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeU1nb2dJQ0FnYVc1MFl5QXhOaUF2THlBNE9UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5TXdvZ0lDQWdaWGgwY21GamRDQTJOQ0EyTkFvZ0lDQWdaR2xuSURJMENpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklESTFDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JREkyQ2lBZ0lDQnBiblJqSURFd0lDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESTNDaUFnSUNCcGJuUmpJREV4SUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlPQW9nSUNBZ2FXNTBZeUF4TnlBdkx5QXhNRGc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV4Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUF4TWlBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QXhNeUF2THlBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNaUF2THlBNE16SUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhOQ0F2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVE0wTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdOU0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOeUF2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBNElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUF4TlNBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdPU0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBeE9DQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhPQW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JRE13Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdhVzUwWXlBeE1DQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4TVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTVRjZ0x5OGdNVEE0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBeE1pQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUF4TXlBdkx5QXhNVFV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTWlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6TWdMeThnTnpBMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZeUF4TkNBdkx5QTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEUWdMeThnTVRNME5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTlNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklEWWdMeThnTVRJNE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nTnlBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVc1MFl5QTRJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOalFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWXlBeE5TQXZMeUF4TWpFMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHbHVkR01nT1NBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFl5QXhPQ0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4T0FvZ0lDQWdjSFZ6YUdsdWRDQXpPUW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdkVzVqYjNabGNpQXpNQW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRZS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01UWWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ05qUUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qRUtJQ0FnSUdsdWRHTWdNVGNnTHk4Z01UQTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUF4TWlBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QXhNeUF2THlBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNaUF2THlBNE16SUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhOQ0F2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVE0wTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdOU0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOeUF2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBNElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUF4TlNBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdPU0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TndvZ0lDQWdjSFZ6YUdsdWRDQTBNZ29nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERTRJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdhVzUwWXlBeE1DQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4TVNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTVRjZ0x5OGdNVEE0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRFF4Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0F5T1FvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdENpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBeE1pQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUF4TXlBdkx5QXhNVFV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5Salh6TWdMeThnTnpBMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZeUExSUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXhDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREU0SUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TUFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nTkNBdkx5QXhNelEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdOaUF2THlBeE1qZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR2x1ZEdNZ055QXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUE0SUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFl5QXhOU0F2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ2FXNTBZeUF4TmlBdkx5QTRPVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0EyTkNBMk5Bb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURFeU9DQTJOQW9nSUNBZ1pHbG5JREU1Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUEyTkFvZ0lDQWdaR2xuSURJd0NpQWdJQ0JwYm5SaklERXdJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREl4Q2lBZ0lDQnBiblJqSURFeElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TWdvZ0lDQWdhVzUwWXlBeE55QXZMeUF4TURnNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ01USWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR01nTVRNZ0x5OGdNVEUxTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNU0F2THlBNU5qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURjd05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nTVRRZ0x5OGdOelk0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFl5QTBJQzh2SURFek5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURVZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QTJJQzh2SURFeU9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURjZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdPQ0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdNZ01UVWdMeThnTVRJeE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqSURrZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTWdNVGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSXRDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBeE1qZ2dOalFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ01UY2dMeThnTVRBNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QXhOQ0F2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1JwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklERTJJQzh2SURnNU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBeENpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZbndLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURFeklDOHZJREV4TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpYekVnTHk4Z09UWXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWTE4eklDOHZJRGN3TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE16UTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ05TQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUEzSUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5SaklEZ2dMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqSURFMUlDOHZJREV5TVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUE1SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwYm5SaklERTRJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTVRnS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTVRreUlEWTBDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRBZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXlDaUFnSUNCcGJuUmpJREUzSUM4dklERXdPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QXhNaUF2THlBeE1ESTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBeE15QXZMeUF4TVRVeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklEazJNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1pQXZMeUE0TXpJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTBDaUFnSUNCcGJuUmpYek1nTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBeE5DQXZMeUEzTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJRFFnTHk4Z01UTTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdNZ05TQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJRFlnTHk4Z01USTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ055QXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2FXNTBZeUE0SUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhOU0F2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdNZ09TQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOQW9nSUNBZ2FXNTBZeUF4T0NBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhOaUF2THlBNE9UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQTJOQ0EyTkFvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JREU1Q2lBZ0lDQnBiblJqSURFd0lDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TUFvZ0lDQWdhVzUwWXlBeE1TQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlOUW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JREkyQ2lBZ0lDQndkWE5vYVc1MElESTRDaUFnSUNCallXeHNjM1ZpSUZKbGJHRjBhVzl1YzB4cFlpNTNhWEpsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXlOQW9nSUNBZ1lud0tJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ01USWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR01nTlNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURBS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdNZ01UY2dMeThnTVRBNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTRDaUFnSUNCd2RYTm9hVzUwSURJNUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lpMEtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYeklnTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWTE4eklDOHZJRGN3TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdNVFFnTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFlnTHk4Z01USTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5SaklEY2dMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHbHVkR01nT0NBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdNVFVnTHk4Z01USXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5SaklEa2dMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRnZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUF5TUFvZ0lDQWdhVzUwWXlBeE1DQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR2x1ZEdNZ01URWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUF4TWlBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QXhNeUF2THlBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNaUF2THlBNE16SUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhOQ0F2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVE0wTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdOU0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOeUF2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBNElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJREU0SUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERTJJQzh2SURnNU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnTVRreUlEWTBDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHbHVkR01nTVRBZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJREUzSUM4dklERXdPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTVRJZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01URTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eklDOHZJRGN3TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdNVFFnTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJRFVnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBMklDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGNnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTVRVZ0x5OGdNVEl4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTNDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdScFp5QXhPQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ01USUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWXlBNUlDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJREU0SUM4dklEVXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERTJJQzh2SURnNU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUyQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTVRjS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdWNGRISmhZM1FnTVRreUlEWTBDaUFnSUNCa2FXY2dNVGtLSUNBZ0lHbHVkR01nTVRBZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJREUzSUM4dklERXdPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTVRJZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z01URTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eklDOHZJRGN3TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdNVFFnTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJRFVnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBMklDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGNnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09DQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTVRVZ0x5OGdNVEl4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXpDaUFnSUNCcGJuUmpJRGtnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRnS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdkVzVqYjNabGNpQXhPUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdsdWRHTWdNVGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01UWWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ05qUUtJQ0FnSUdScFp5QXhPUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnYVc1MFl5QXhNU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01qRUtJQ0FnSUdsdWRHTWdNVGNnTHk4Z01UQTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUF4TWlBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QXhNeUF2THlBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNaUF2THlBNE16SUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhOQ0F2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVE0wTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTWdOU0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOeUF2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBNElDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUF4TlNBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFl5QTVJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqSURFNElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJREUySUM4dklEZzVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR2x1ZEdNZ01UQWdMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRFZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURFM0lDOHZJREV3T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNVEVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YUc5dWF5OWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxMMFZqWkhOaFNHOXVhMVpsY21sbWFXVnlMbk52YkM1RlkyUnpZVWh2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TVRNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFUUU1BSHdBYkFCY0FLZ0FXQUNvQUN3QUtBQThBRHdBU0FDSUFKZ0FiQUNZQUh3QWlBQkNZQ0lEQmtUbkxoTWFBcHVGQkZ0b0dCV0Ywb00raEllYmx3a1VQaDlaUHdBQUFCSURCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUFRZ0FaaWdJQmdRaXZpLzhXVUVrVmdRZ0pXNHYrUGt3aUN5SllpWUFFbEFXWUNEWWFBSTRCQUFFQU1Sa1VNUmdRUkVJQUFEWWFBUldCd044QkVrUTJHZ0pKRllIQUxSSkVOaG9ERlNJU1JEWWFCQlVpRWtRMkdnVVZnWUFORWtRMkdnWVZnWUFXRWtRMkdnZEpGVWtpRWtRMkdnaEpGVWtpRWtRMkdnbEpGVWtpRWtRMkdncEpGWUdBQ3hKRU5ob0xTUlZKSWhKRU5ob01TUlZKSWhKRWdRQk9Bb0FBVEVzR0lRd2lXRXNISVEwaVdFc0lJeUpZU3dra0lsaExDaVVpV0VzTElRNGlXRXNNSVFRaVdFc05JUVVpV0VzT0lRWWlXRXNQSVFjaVdFc1FJUWdpV0VzUlZ3QkFTeEloRHlKWVN4TWhDU0pZU3crQktZai9Ca3NjVjRCQW95aXFTUlVpRGtRaXIweExBYXRMRmlFUUlsaExGMWRBUUVzWVY0QkFTeGxYd0VCTEdpRUtJbGhMR3lFTElsaFBIQ0VSSWxoUEMwOEdVRThGVUU4RVVFOEtVRThKVUU4SFVFOERVRThFVUU4Q1VFOEdVRThJVUU4SFVFOEhVRThDVUU4R1VFOEhVRXhRVHdWUVR3SlFUd0pRVHdKUVNTRU1JbGhMQVNFTklsaExBaU1pV0VzREpDSllTd1FsSWxoTEJTRU9JbGhMQmlFRUlsaExCeUVGSWxoTENDRUdJbGhMQ1NFSElsaExDaUVJSWxoTEMxY0FRRXNNSVE4aVdFc05JUWtpV0VzT0lSSWlXRXNTZ1NpSS9qQkxIbGRBUUtNb3FxQW9xa2tWSWc1RVN4Q3JTdzhoRUNKWVN4QlhRRUJMRVZlQVFFc1NWOEJBU3hNaENpSllTeFFoQ3lKWVR4VWhFU0pZVHdwUEJsQlBCVkJQQkZCUENWQlBDRkJQQmxCUEExQlBCRkJQQWxCUEJWQlBCMUJQQmxCUEJsQlBBbEJQQlZCUEJsQk1VRThFVUV4UVRGQk1VRWtoRENKWVN3RWhEU0pZU3dJaklsaExBeVFpV0VzRUpTSllTd1VoRGlKWVN3WWhCQ0pZU3djaEJTSllTd2doQmlKWVN3a2hCeUpZU3dvaENDSllTd3RYQUVCTERDRVBJbGhMRFNFSklsaExEaUVTSWxoTEVvRW5pUDFkVHg1WEFFQ2pLS3FnS0twSkZTSU9SRXNRcTBzUElSQWlXRXNRVjBCQVN4RlhnRUJMRWxmQVFFc1RJUW9pV0VzVUlRc2lXRThWSVJFaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRd2lXRXNCSVEwaVdFc0NJeUpZU3dNa0lsaExCQ1VpV0VzRklRNGlXRXNHSVFRaVdFc0hJUVVpV0VzSUlRWWlXRXNKSVFjaVdFc0tJUWdpV0VzTFZ3QkFTd3doRHlKWVN3MGhDU0pZU3hHQktvajhrRXNQSVJJaVdDaE1vYUFvcWtrVklnNUVTeENyU3c4aEVDSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhDaUpZU3hRaEN5SllUeFVoRVNKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVzRGdTbUkvQkZMQklFZGlQd0tLRXlob0NpcVN3RWhEQ0pZU3dJaERTSllTd01qSWxoTEJDUWlXRXNGSlNKWVN3WWhCU0pZZ1FFV1N3RXBveWlxU3dHZ0tLcFBDS01vcWtzSUlSSWlXRWtwb3lpcVN3T2dLS3BQQXFNb3Fra1ZJZzVFU3dxclN3a2hCQ0pZU3dvaEJpSllTd3NoQnlKWVN3d2hDQ0pZU3cxWEFFQkxEaUVQSWxoTER5RUpJbGhMRUNFUUlsaExFVmRBUUVzU1Y0QkFTeE5Yd0VCTEZDRUtJbGhMRlNFTElsaFBGaUVSSWxoUENVOEdVRThGVUU4RVVFOElVRThIVUU4RlVFOERVRThJVUU4Q1VFOElVRThJVUU4R1VFOEhVRThDVUU4R1VFOEhVRXhRVHdWUVRGQk1VRXhRU1NFTUlsaExBU0VOSWxoTEFpTWlXRXNESkNKWVN3UWxJbGhMQlNFT0lsaExCaUVFSWxoTEJ5RUZJbGhMQ0NFR0lsaExDU0VISWxoTENpRUlJbGhMQzFjQVFFc01JUThpV0VzTklRa2lXRXNPSVJJaVdFbExBYU1vcWloTEFxR2dLS3BKRlNJT1JFc1NxMHNRVjBCQVN4RlhnRUJMRWxmQVFFc1RJUW9pV0VzVUlRc2lXRThWSVJFaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRNGlXRXNCSVFZaVdFc0dnUWFJK2t4TEFhTW9xa3NIZ1FtSStrQlBDcU1vcXFNb3Frc0RJUkFpV0VzRUpDSllTd21CQm9qNkprc0JveWlxU1JVaURrUkxDS3RMQmlFTklsaExCeU1pV0VzSUpTSllTd2toQkNKWVN3b2hCU0pZU3dzaEJ5SllTd3doQ0NKWVN3MVhBRUJMRGlFUElsaExEeUVKSWxoTEVDRVNJbGhMRVZkQVFFc1NWNEJBU3hOWHdFQkxGQ0VLSWxoTEZTRUxJbGhQRmlFUklsaFBDVThHVUU4RlVFOEVVRThJVUU4SFVFOEZVRThEVUU4RFVFOENVRThEVUU4RVVFOExVRThIVUU4SFVFOEVVRThGVUV4UVR3TlFURkJQQTFCTVVFa2hEQ0pZU3dFaERTSllTd0lqSWxoTEF5UWlXRXNFSlNKWVN3VWhEaUpZU3dZaEJDSllTd2NoQlNKWVN3Z2hCaUpZU3draEJ5SllTd29oQ0NKWVN3dFhBRUJMRENFUElsaExEU0VKSWxoTERpRVNJbGhMRHlFUUlsaExFRmRBUUVzUlY0QkFTeEpYd0VCTEV5RUtJbGhQRkNFTElsaExHWUVvaVBqK1N4cUJISWo0OXloTW9hQW9xa2tWSWc1RVN4aXJUd3BQQmxCUEJWQlBCRkJQQ1ZCUENGQlBCbEJQQTFCUEJGQlBBbEJQQlZCUEIxQlBCbEJQQmxCUEFsQlBCVkJQQmxCTVVFOEVVRXhRVEZCTVVFa2hEQ0pZU3dFaEJTSllTU21qS0twUEJhQW9xa3NESVJFaVdFeExBYU1vcWtzSWdSMkkrSVFvVEtHZ0tLcEpGU0lPUkVzR3Ewc0VJeUpZU3dVa0lsaExCaVVpV0VzSElRNGlXRXNJSVFRaVdFc0pJUVlpV0VzS0lRY2lXRXNMSVFnaVdFc01Wd0JBU3cwaER5SllTdzRoQ1NKWVN3OGhFaUpZU3hBaEVDSllTeEZYUUVCTEVsZUFRRXNUVjhCQVN4UWhDaUpZVHhVaEN5SllUd2xQQlZCUEJGQlBBMUJQQ0ZCUEIxQlBCVkJQQWxCUEExQk1VRThMVUU4R1VFOEZVRThGVUV4UVR3UlFUd1pRVHdWUVR3UlFURkJNVUV4UVNTRU1JbGhMQVNFTklsaExBaU1pV0VzREpDSllTd1FsSWxoTEJTRU9JbGhMQmlFRUlsaExCeUVGSWxoTENDRUdJbGhMQ1NFSElsaExDaUVJSWxoTEMxY0FRRXNKRlNJT1JFc0pTdytyU3cwaENTSllTdzRoRWlKWVN3OGhFQ0pZU3hCWFFFQkxFVmVBUUVzU1Y4QkFTeE1oQ2lKWVN4UWhDeUpZVHhVaEVTSllUd3BQQmxCUEJWQlBCRkJQQ1ZCUENGQlBCbEJQQTFCUEJGQlBBbEJQQlZCUEIxQlBCbEJQQmxCUEFsQlBCVkJQQmxCTVVFOEVVRXhRVEZCTVVFa2hEQ0pZU3dFaERTSllTd0lqSWxoTEF5UWlXRXNFSlNKWVN3VWhEaUpZU3dZaEJDSllTd2NoQlNKWVN3Z2hCaUpZU3draEJ5SllTd29oQ0NKWVN3dFhBRUJMRENFUElsaExFWUVGaVBiSFN4S0JBb2oyd0tNb3Frc01veWlxb0NpcVNSVWlEa1JMRDZ0TERTRUpJbGhMRGlFU0lsaExEeUVRSWxoTEVGZEFRRXNSVjRCQVN4Slh3RUJMRXlFS0lsaExGQ0VMSWxoUEZTRVJJbGhQQ2s4R1VFOEZVRThFVUU4SlVFOElVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU0VNSWxoTEFTRU5JbGhMQWlNaVdFc0RKQ0pZU3dRbElsaExCU0VPSWxoTEJpRUVJbGhMQnlFRklsaExDQ0VHSWxoTENTRUhJbGhMQ2lFSUlsaExDMWNBUUVzTUlROGlXRXNOSVFraVdFc1NnUUNJOWVkUEU0RUNpUFhnb3lpcVN3R2pLS3BQQXFBb3Fra1ZJZzVFU3hDclN3NGhFaUpZU3c4aEVDSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhDaUpZU3hRaEN5SllUeFVoRVNKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEIxQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraERDSllTd0VoRFNKWVN3SWpJbGhMQXlRaVdFc0VKU0pZU3dVaERpSllTd1loQkNKWVN3Y2hCU0pZU3dnaEJpSllTd2toQnlKWVN3b2hDQ0pZU3d0WEFFQkxEQ0VQSWxoTERLQW9xa2tWSWc1RVN3K3JTdzBoQ1NKWVN3NGhFaUpZU3c4aEVDSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhDaUpZU3hRaEN5SllUeFVoRVNKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUU4TElnNUVUd3RMQTZ0UENpSU9SRThLU3dTclVFOElJZzVFVHdoTEJLdFFTd0lWSWc1RVR3SkxBNnRRVEZCUEJDSU9SRThFU3dLclVFOENJZzVFVGdLclVJQUVGUjk4ZFV4UXNJRUJRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
