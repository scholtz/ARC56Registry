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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper20_219c8bff
{


    //
    // Helper contract 20 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper20Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper20Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public Structs.AuxParams Field1 { get; set; } = new Structs.AuxParams();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    ret.AddRange(Field1.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    ret.Field1 = Structs.AuxParams.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return left, RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return left, RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return right)
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
        /// <param name="ap"> AuxParams</param>
        /// <param name="limb_accumulator_identity"> </param>
        /// <param name="non_native_field_identity"> </param>
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return> RelationsLibAccumulateRelationEvaluationsChunk2Chunk7(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 50, 27, 45 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            var result = await base.CallApp(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk2Chunk7Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk2Chunk7_Transactions(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, Structs.AuxParams ap, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 limb_accumulator_identity, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 non_native_field_identity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 50, 27, 45 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, ap, limb_accumulator_identity, non_native_field_identity }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjIwIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAyMCBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXV4UGFyYW1zIjpbeyJuYW1lIjoibGltYl9zdWJwcm9kdWN0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJub25fbmF0aXZlX2ZpZWxkX2dhdGVfMSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibm9uX25hdGl2ZV9maWVsZF9nYXRlXzIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5vbl9uYXRpdmVfZmllbGRfZ2F0ZV8zIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJsaW1iX2FjY3VtdWxhdG9yXzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImxpbWJfYWNjdW11bGF0b3JfMiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoibWVtb3J5X3JlY29yZF9jaGVjayIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicGFydGlhbF9yZWNvcmRfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicmVjb3JkX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJpbmRleF9kZWx0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWRqYWNlbnRfdmFsdWVzX21hdGNoX2lmX2FkamFjZW50X2luZGljZXNfbWF0Y2giLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFkamFjZW50X3ZhbHVlc19tYXRjaF9pZl9hZGphY2VudF9pbmRpY2VzX21hdGNoX2FuZF9uZXh0X2FjY2Vzc19pc19hX3JlYWRfb3BlcmF0aW9uIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhY2Nlc3NfY2hlY2siLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6Im5leHRfZ2F0ZV9hY2Nlc3NfdHlwZV9pc19ib29sZWFuIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJST01fY29uc2lzdGVuY3lfY2hlY2tfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6IlJBTV9jb25zaXN0ZW5jeV9jaGVja19pZGVudGl0eSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidGltZXN0YW1wX2RlbHRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJSQU1fdGltZXN0YW1wX2NoZWNrX2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJtZW1vcnlfaWRlbnRpdHkiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImluZGV4X2lzX21vbm90b25pY2FsbHlfaW5jcmVhc2luZyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYXV4aWxpYXJ5X2lkZW50aXR5IiwidHlwZSI6InVpbnQ1MTIifV0sIkcxUHJvb2ZQb2ludCI6W3sibmFtZSI6InhfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieF8xIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ5XzAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMSIsInR5cGUiOiJ1aW50NTEyIn1dLCJQcm9vZiI6W3sibmFtZSI6ImNpcmN1aXRTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNPZmZzZXQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6IncxIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6IncyIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InczIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Inc0IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InpQZXJtIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imxvb2t1cFJlYWRDb3VudHMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZFRhZ3MiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwSW52ZXJzZXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoic3VtY2hlY2tVbml2YXJpYXRlcyIsInR5cGUiOiJ1aW50NTEyWzhdWzI4XSJ9LHsibmFtZSI6InN1bWNoZWNrRXZhbHVhdGlvbnMiLCJ0eXBlIjoidWludDUxMls0NF0ifSx7Im5hbWUiOiJnZW1pbmlGb2xkQ29tbXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50WzI3XSJ9LHsibmFtZSI6ImdlbWluaUFFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InNocGxvbmtRIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imt6Z1F1b3RpZW50IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9XSwiVHJhbnNjcmlwdCI6W3sibmFtZSI6ImV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZXRhVHdvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUaHJlZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYmV0YSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2FtbWEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFscGhhcyIsInR5cGUiOiJ1aW50NTEyWzI1XSJ9LHsibmFtZSI6ImdhdGVDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic3VtQ2hlY2tVQ2hhbGxlbmdlcyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InJobyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZ2VtaW5pUiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoic2hwbG9ua051IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rWiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicHVibGljSW5wdXRzRGVsdGEiLCJ0eXBlIjoidWludDUxMiJ9XSwiUmVsYXRpb25zTGliQWNjdW11bGF0ZVJlbGF0aW9uRXZhbHVhdGlvbnNDaHVuazJDaHVuazdSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJBdXhQYXJhbXMifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NTEyIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IlJlbGF0aW9uc0xpYi5hY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc19fY2h1bmtfMl9fY2h1bmtfNyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyWzhdWzI4XSx1aW50NTEyWzQ0XSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMilbMjddLHVpbnQ1MTJbMjhdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiUHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3dQYXJ0aWFsRXZhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY3VtdWxhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyWzI2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyWzQ0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvcnRlZEV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikiLCJzdHJ1Y3QiOiJBdXhQYXJhbXMiLCJuYW1lIjoiYXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaW1iX2FjY3VtdWxhdG9yX2lkZW50aXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uX25hdGl2ZV9maWVsZF9pZGVudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmsyQ2h1bms3UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBBdXhQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVHJhbnNjcmlwdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ1MTIsIDI2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ1MTIsIDQ0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MywxNjAsMTk3LDIwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTQsNTAyLDcyMSw5MzIsMTE0MywxMzQ2LDE1NjcsMTc0MiwxOTE0LDIxOTUsMjMyNywyNTU0LDI3OTQsMzAwNywzMTc0LDMxODUsMzE5Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNakF1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTmpRZ01UQXlOQ0F4TVRVeUlEYzJPQ0F4TXpRMElESTFOaUF6TWpBZ01USXhOaUExTVRJZ09EazJJREV3T0RnZ09UWXdJRGd6TWlBM01EUWdOalF3SURFeU9EQWdNemcwSURRME9DQTFOellLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlJRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyaHZibXN2WTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlM5RlkyUnpZVWh2Ym10V1pYSnBabWxsY2k1emIyd3VVbVZzWVhScGIyNXpUR2xpTG5kcGNtVW9jRG9nZFdsdWREWTBMQ0JmZDJseVpUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tVbVZzWVhScGIyNXpUR2xpTG5kcGNtVTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNiMkZrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyaHZibXN2WTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlM5RlkyUnpZVWh2Ym10V1pYSnBabWxsY2k1emIyd3VSV05rYzJGSWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqSXdMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncGZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYem9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUzTXpJeFlqSmtJQzh2SUcxbGRHaHZaQ0FpVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHlYMTlqYUhWdWExODNLQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBMSFZwYm5RMU1USmJPRjFiTWpoZExIVnBiblExTVRKYk5EUmRMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtWc3lOMTBzZFdsdWREVXhNbHN5T0Ywc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU2tzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeVd6STFYU3gxYVc1ME5URXlXekk0WFN4MWFXNTBOVEV5V3pJNFhTeDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlXekkyWFN4MWFXNTBOVEV5V3pRMFhTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1NoMWFXNTBOVEV5TENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3gxYVc1ME5URXlMSFZwYm5RMU1USXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlVtVnNZWFJwYjI1elRHbGlMbUZqWTNWdGRXeGhkR1ZTWld4aGRHbHZia1YyWVd4MVlYUnBiMjV6WDE5amFIVnVhMTh5WDE5amFIVnVhMTgzWDNKdmRYUmxRREVLSUNBZ0lHVnljZ29LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlVtVnNZWFJwYjI1elRHbGlMbUZqWTNWdGRXeGhkR1ZTWld4aGRHbHZia1YyWVd4MVlYUnBiMjV6WDE5amFIVnVhMTh5WDE5amFIVnVhMTgzWDNKdmRYUmxRREU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCU1pXeGhkR2x2Ym5OTWFXSXVZV05qZFcxMWJHRjBaVkpsYkdGMGFXOXVSWFpoYkhWaGRHbHZibk5mWDJOb2RXNXJYekpmWDJOb2RXNXJYemNLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU1qQXVVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eVgxOWphSFZ1YTE4M1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4eVgxOWphSFZ1YTE4M09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREk0TmpBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJRY205dlpnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOVGd5TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdWSEpoYm5OamNtbHdkQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTJOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREVXhNaXdnTWpZK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNamd4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOVEV5TENBME5ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUwTURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRUYxZUZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNU0F2THlBeE1ESTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWTE4eUlDOHZJREV4TlRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREV4SUM4dklEazJNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RNeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdsdWRHTmZNeUF2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZeUF4TkNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFl5QXhOU0F2THlBeE1qZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ05TQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ2FXNTBZeUEySUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeUNpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdhVzUwWXlBM0lDOHZJREV5TVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4TmlBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeU1Rb2dJQ0FnYVc1MFl5QTRJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREl5Q2lBZ0lDQnBiblJqSURrZ0x5OGdPRGsyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXlOQW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dOalFLSUNBZ0lHUnBaeUF5TlFvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR1JwWnlBeU5nb2dJQ0FnYVc1MFl5QXhOeUF2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5TndvZ0lDQWdhVzUwWXlBeE9DQXZMeUExTnpZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWpnS0lDQWdJR2x1ZEdNZ01UQWdMeThnTVRBNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01UQXlOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TVRVeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QTVOakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklERXlJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHpJQzh2SURjMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTkNBdkx5QXhNelEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhOQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFMUlDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ05pQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOQW9nSUNBZ2NIVnphR2x1ZENBd0NpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01USUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01URUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpJRGNnTHk4Z01USXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5SaklERTJJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqSURnZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdPU0F2THlBNE9UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQTJOQ0EyTkFvZ0lDQWdaR2xuSURFM0NpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklERTRDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JREU1Q2lBZ0lDQnBiblJqSURFM0lDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREU0SUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXhNRGc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURVZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTJJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURFeE5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURFeElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBeE15QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpYek1nTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJREUwSUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5SaklERTFJQzh2SURFeU9EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdNZ055QXZMeUF4TWpFMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lIQjFjMmhwYm5RZ01qa0tJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBNElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJRGtnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdhVzUwWXlBeE55QXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4T0NBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTVRBZ0x5OGdNVEE0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4T0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXhNVFV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QXhNU0F2THlBNU5qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURFeUlDOHZJRGd6TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWTE4eklDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE16UTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREUxSUM4dklERXlPREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklEVWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR01nTmlBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTWdOeUF2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdNZ01UWWdMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVGNLSUNBZ0lIQjFjMmhwYm5RZ01qZ0tJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdaWGgwY21GamRDQTJOQ0EyTkFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERTFDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJRGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ09TQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklERTVDaUFnSUNCcGJuUmpJREUzSUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JwYm5SaklERTRJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeU1Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBeE1EZzRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01UQXlOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TVRVeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QTVOakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklERXlJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHpJQzh2SURjMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTkNBdkx5QXhNelEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhOQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFMUlDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ05pQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTnlBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJSEIxYzJocGJuUWdNamNLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJSFZ1WTI5MlpYSWdNak1LSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5SaklEZ2dMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nT1NBdkx5QTRPVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBMk5Bb2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURFeU9DQTJOQW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElERTVNaUEyTkFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JwYm5SaklERTNJQzh2SURRME9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREl3Q2lBZ0lDQnBiblJqSURFNElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5TVFvZ0lDQWdhVzUwWXlBeE1DQXZMeUF4TURnNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXhNVFV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QXhNU0F2THlBNU5qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqSURFeUlDOHZJRGd6TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWTE4eklDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE16UTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBeE5DQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJREUxSUM4dklERXlPREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklEVWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR01nTmlBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTWdOeUF2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdNZ01UWWdMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVGNLSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERTFDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJRGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ09TQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklERTVDaUFnSUNCcGJuUmpJREUzSUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JwYm5SaklERTRJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeU1Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBeE1EZzRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01UQXlOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TVRVeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QTVOakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5SaklERXlJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR01nTVRNZ0x5OGdOekEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHpJQzh2SURjMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTkNBdkx5QXhNelEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhOQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFMUlDOHZJREV5T0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ05pQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTnlBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ09DQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUE1SUM4dklEZzVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMUNpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVGdnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJREV3SUM4dklERXdPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFeE5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqSURFeElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTWdNVElnTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWXlBeE15QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYek1nTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMElDOHZJREV6TkRRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpJREUwSUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ01UVWdMeThnTVRJNE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nTlNBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVc1MFl5QTJJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOalFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWXlBM0lDOHZJREV5TVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZeUF4TmlBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE53b2dJQ0FnY0hWemFHbHVkQ0F6TUFvZ0lDQWdZMkZzYkhOMVlpQlNaV3hoZEdsdmJuTk1hV0l1ZDJseVpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdENpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRVS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ09DQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUE1SUM4dklEZzVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR2x1ZEdNZ01UY2dMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRnZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURFd0lDOHZJREV3T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklERXhOVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5SaklERXhJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR01nTVRJZ0x5OGdPRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QXhNeUF2THlBM01EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOelk0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFl5QTBJQzh2SURFek5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdjSFZ6YUdsdWRDQXpPUW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdaR2xuSURFeENpQWdJQ0J3ZFhOb2FXNTBJREkzQ2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTVRVZ0x5OGdNVEk0TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdOU0F2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBMklDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUEzSUM4dklERXlNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFl5QXhOaUF2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWXlBNElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJRGtnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBeE53b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdhVzUwWXlBeE55QXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNQW9nSUNBZ2FXNTBZeUF4T0NBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNakVLSUNBZ0lHbHVkR01nTVRBZ0x5OGdNVEE0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREV3TWpRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01URTFNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdNZ01URWdMeThnT1RZd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZeUF4TWlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5SaklERXpJQzh2SURjd05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTXlBdkx5QTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEUWdMeThnTVRNME5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTVRRZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QXhOU0F2THlBeE1qZ3dDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhVzUwWXlBMUlDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCcGJuUmpJRFlnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5SaklEY2dMeThnTVRJeE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV6Q2lBZ0lDQnBiblJqSURFMklDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpJRGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ09TQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURFNENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklERTVDaUFnSUNCcGJuUmpJREUzSUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJekNpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQmpZV3hzYzNWaUlGSmxiR0YwYVc5dWMweHBZaTUzYVhKbENpQWdJQ0JrYVdjZ01qUUtJQ0FnSUhCMWMyaHBiblFnTXpBS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCemQyRndDaUFnSUNCaUxRb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURJeUNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXlNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXhNRGc0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWXlBeE1TQXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpJREV5SUM4dklEZ3pNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdNZ01UTWdMeThnTnpBMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZMTh6SUM4dklEYzJPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TXpRMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUF4TkNBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZaTBLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1lud0tJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFVnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ05pQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTnlBdkx5QXhNakUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdNVFlnTHk4Z016ZzBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ09DQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZeUE1SUM4dklEZzVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMkNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR2x1ZEdNZ01UY2dMeThnTkRRNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRnZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURFd0lDOHZJREV3T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklERXhOVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5SaklERXhJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR01nTVRJZ0x5OGdPRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QXhOQ0F2THlBMk5EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01EQUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURFNElDOHZJRFUzTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBNENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdOZk15QXZMeUEzTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJRFFnTHk4Z01UTTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ01UVWdMeThnTVRJNE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQnBiblJqSURVZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdsdWRHTWdOaUF2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdNZ055QXZMeUF4TWpFMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR01nTVRZZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdPQ0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdhVzUwWXlBNUlDOHZJRGc1TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTNDaUFnSUNCbGVIUnlZV04wSURZMElEWTBDaUFnSUNCa2FXY2dNVGdLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRFkwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdsdWRHTWdNVGNnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESXhDaUFnSUNCcGJuUmpJREV3SUM4dklERXdPRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUF4TXlBdkx5QTNNRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBNUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJREUxSUM4dklERXlPREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhNVFV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhOaUF2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdOaGJHeHpkV0lnVW1Wc1lYUnBiMjV6VEdsaUxuZHBjbVVLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCallXeHNjM1ZpSUZKbGJHRjBhVzl1YzB4cFlpNTNhWEpsQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdKOENpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhNaUF2THlBNE16SUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOelk0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYVc1MFl5QTBJQzh2SURFek5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWXlBeE5DQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUExSUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5SaklEWWdMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqSURjZ0x5OGdNVEl4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJRGdnTHk4Z05URXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR2x1ZEdNZ09TQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOd29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklESXdDaUFnSUNCcGJuUmpJREUzSUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJeENpQWdJQ0JwYm5SaklERTRJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeU1nb2dJQ0FnYVc1MFl5QXhNQ0F2THlBeE1EZzRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQndkWE5vYVc1MElETXdDaUFnSUNCallXeHNjM1ZpSUZKbGJHRjBhVzl1YzB4cFlpNTNhWEpsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBeE55QXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURFeE5USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqSURFeElDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QTBDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmlMUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklEY0tJQ0FnSUdKOENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QXhNeUF2THlBM01EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOelk0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QTBJQzh2SURFek5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBiblJqSURFMElDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEa0tJQ0FnSUdsdWRHTWdNVFVnTHk4Z01USTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5SaklEVWdMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHbHVkR01nTmlBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTWdOeUF2THlBeE1qRTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR2x1ZEdNZ01UWWdMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nT0NBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnYVc1MFl5QTVJQzh2SURnNU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUzQ2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTVRnS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdWNGRISmhZM1FnTVRreUlEWTBDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbHVkR01nTVRnZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREl4Q2lBZ0lDQnBiblJqSURFd0lDOHZJREV3T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCaWZBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNakF1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQVRRSUFJZ0FtQUJzQUtnQUxBQXNBSmdBU0FCOEFJd0FmQUJzQUZnQVdBQ29BRHdBUEFCQ1lCSURCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUJRZ0FaaWdJQmdRaXZpLzhXVUVrVmdRZ0pXNHYrUGt3aUN5SllpWUFFVnpJYkxUWWFBSTRCQUFFQU1Sa1VNUmdRUkVJQUFEWWFBUldCd044QkVrUTJHZ0pKRllIQUxSSkVOaG9ERlNJU1JEWWFCQlVpRWtRMkdnVVZnWUFORWtRMkdnWVZnWUFXRWtRMkdnZEpGWUdBQ3hKRU5ob0lTUlZKSWhKRU5ob0pTUlZKSWhKRWdRQk9Bb0FBVEVzR0l5SllTd2NrSWxoTENDRUxJbGhMQ1NFTUlsaExDaUVOSWxoTEN5VWlXRXNNSVFRaVdFc05JUTRpV0VzT0lROGlXRXNQSVFVaVdFc1FJUVlpV0VzTWdTcUkveklvVEtHZ0tLcEpGU0lPUkNLdlRFc0JxMHNTVndCQVN4TWhCeUpZU3hRaEVDSllTeFVoQ0NKWVN4WWhDU0pZU3hkWFFFQkxHRmVBUUVzWlY4QkFTeG9oRVNKWVN4c2hFaUpZVHh3aENpSllUd3BQQmxCUEJWQlBCRkJQQ2xCUENGQlBCbEJQQTFCUEJGQlBBbEJQQmxCUENGQlBCMUJQQjFCUEFsQlBCbEJQQjFCTVVFOEZVRXhRVHdKUVR3SlFTU01pV0VzQkpDSllTd0loQ3lKWVN3TWhEQ0pZU3dRaERTSllTd1VsSWxoTEJpRUVJbGhMQnlFT0lsaExDQ0VQSWxoTENTRUZJbGhMQ2lFR0lsaExEb0VBaVA1Zm95aXFTUlVpRGtSTERLdExDMWNBUUVzTUlRY2lXRXNOSVJBaVdFc09JUWdpV0VzUElRa2lXRXNRVjBCQVN4RlhnRUJMRWxmQVFFc1RJUkVpV0VzVUlSSWlXRThWSVFvaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSklRVWlXRXNCSVFZaVdFc0NJeUpZU3dNa0lsaExCQ0VMSWxoTEJTRU1JbGhMQmlFTklsaExCeVVpV0VzSUlRUWlXRXNKSVE0aVdFc0tJUThpV0VzTFZ3QkFTd3doQnlKWVN4Q0JIWWo5aVVzV1Y0QkFveWlxU1JVaURrUkxENnRMRGlFSUlsaExEeUVKSWxoTEVGZEFRRXNSVjRCQVN4Slh3RUJMRXlFUklsaExGQ0VTSWxoUEZTRUtJbGhQQ2s4R1VFOEZVRThFVUU4U1VFOFJVRThHVUU4RFVFOEVVRThDVUU4RlVFOEhVRThHVUU4R1VFOENVRThGVUU4R1VFeFFUd1JRVEZCTVVFeFFTU01pV0VzQkpDSllTd0loQ3lKWVN3TWhEQ0pZU3dRaERTSllTd1VsSWxoTEJpRUVJbGhMQnlFT0lsaExDQ0VQSWxoTENTRUZJbGhMQ2lFR0lsaExDMWNBUUVzTUlRY2lXRXNOSVJBaVdFc1JnUnlJL0xsTEYxZEFRS01vcXFBb3Fra1ZJZzVFU3crclN3NGhDQ0pZU3c4aENTSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhFU0pZU3hRaEVpSllUeFVoQ2lKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraklsaExBU1FpV0VzQ0lRc2lXRXNESVF3aVdFc0VJUTBpV0VzRkpTSllTd1loQkNKWVN3Y2hEaUpZU3dnaER5SllTd2toQlNKWVN3b2hCaUpZU3d0WEFFQkxEQ0VISWxoTERTRVFJbGhMRVlFYmlQdm1UeGRYQUVDaktLcWdLS3BKRlNJT1JFc1BxMHNPSVFnaVdFc1BJUWtpV0VzUVYwQkFTeEZYZ0VCTEVsZkFRRXNUSVJFaVdFc1VJUklpV0U4VklRb2lXRThLVHdaUVR3VlFUd1JRVHdsUVR3aFFUd1pRVHdOUVR3UlFUd0pRVHdWUVR3ZFFUd1pRVHdaUVR3SlFUd1ZRVHdaUVRGQlBCRkJNVUV4UVRGQkpJeUpZU3dFa0lsaExBaUVMSWxoTEF5RU1JbGhMQkNFTklsaExCU1VpV0VzR0lRUWlXRXNISVE0aVdFc0lJUThpV0VzSklRVWlXRXNLSVFZaVdFc0xWd0JBU3d3aEJ5SllTdzBoRUNKWVN4R0JBWWo3RTZBb3Fra1ZJZzVFU3crclN3NGhDQ0pZU3c4aENTSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhFU0pZU3hRaEVpSllUeFVoQ2lKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraklsaExBU1FpV0VzQ0lRc2lXRXNESVF3aVdFc0VJUTBpV0VzRkpTSllTd1loQkNKWVN3Y2hEaUpZU3dnaER5SllTd2toQlNKWVN3b2hCaUpZU3d0WEFFQkxEQ0VISWxoTERTRVFJbGhMRGlFSUlsaExEeUVKSWxoTEVGZEFRRXNSVjRCQVN4Slh3RUJMQlJVaURrUkxCVXNWcTBzVUlSSWlXRThWSVFvaVdFOEtUd1pRVHdWUVR3UlFUd2xRVHdoUVR3WlFUd05RVHdSUVR3SlFUd1ZRVHdkUVR3WlFUd1pRVHdKUVR3VlFUd1pRVEZCUEJGQk1VRXhRVEZCSkl5SllTd0VrSWxoTEFpRUxJbGhMQXlFTUlsaExCQ0VOSWxoTEJTVWlXRXNHSVFRaVdFc0hJUTRpV0VzSUlROGlXRXNKSVFVaVdFc0tJUVlpV0VzTFZ3QkFTd3doQnlKWVN3MGhFQ0pZU3hHQkhvajVpaWhNb2FBb3Fra1ZJZzVFU3crclN3NGhDQ0pZU3c4aENTSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhFU0pZU3hRaEVpSllUeFVoQ2lKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraklsaExBU1FpV0VzQ0lRc2lXRXNESVF3aVdFc0VJUTBpV0VzRkpTSllTd1loQkNKWVN3cUJKNGo0NVVzTGdSdUkrTjRvVEtHZ0tLcEpGU0lPUkVzSnEwc0lJUThpV0VzSklRVWlXRXNLSVFZaVdFc0xWd0JBU3d3aEJ5SllTdzBoRUNKWVN3NGhDQ0pZU3c4aENTSllTeEJYUUVCTEVWZUFRRXNTVjhCQVN4TWhFU0pZU3hRaEVpSllUeFVoQ2lKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraklsaExBU1FpV0VzQ0lRc2lXRXNESVF3aVdFc0VJUTBpV0VzRkpTSllTd1loQkNKWVN3Y2hEaUpZU3dnaER5SllTd2toQlNKWVN3b2hCaUpZU3d0WEFFQkxEQ0VISWxoTERTRVFJbGhMRGlFSUlsaExEeUVKSWxoTEVGZEFRRXNSVjRCQVN4Slh3RUJMRXlFUklsaExGNEVxaVBmTVN4aUJIb2ozeFNoTW9hQW9xa2tWSWc1RVN4YXJUeFVoQ2lKWVR3cFBCbEJQQlZCUEJGQlBDVkJQQ0ZCUEJsQlBBMUJQQkZCUEFsQlBCVkJQQjFCUEJsQlBCbEJQQWxCUEJWQlBCbEJNVUU4RVVFeFFURkJNVUVraklsaExBU1FpV0VzQ0lRc2lXRXNESVF3aVdFc0VJUTBpV0VzRkpTSllTd1loQkNKWVN3Y2hEaUpZU1VzQm95aXFLRXNDb2FBb3Fra1ZJZzVFU3dxclN3a2hCU0pZU3dvaEJpSllTd3RYQUVCTERDRUhJbGhMRFNFUUlsaExEaUVJSWxoTER5RUpJbGhMRUZkQVFFc1JWNEJBU3hKWHdFQkxFeUVSSWxoTEZDRVNJbGhQRlNFS0lsaFBDazhHVUU4RlVFOEVVRThKVUU4SVVFOEdVRThEVUU4RVVFOENVRThGVUU4SFVFOEdVRThHVUU4Q1VFOEZVRThHVUV4UVR3UlFURkJNVUV4UVNTTWlXRXNCSkNKWVN3SWhDeUpZU3dNaERDSllTd1FoRGlKWWdRRVdTd0dBSURCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUFveWlxb0NpcVN3WWhFaUpZVEVzQm95aXFTUlVpRGtSTENLdExCeVVpV0VzSUlRUWlXRXNKSVE4aVdFc0tJUVVpV0VzTElRWWlXRXNNVndCQVN3MGhCeUpZU3c0aEVDSllTdzhoQ0NKWVN4QWhDU0pZU3hGWFFFQkxFbGVBUUVzVFY4QkFTeFFoRVNKWVR4VWhDaUpZVHdsUEJWQlBCRkJQQTFCUENGQlBCMUJQQlZCUEFsQlBBMUJQQ0ZCUENGQlBCMUJQQmxCUEJsQlBBbEJQQlZCUEJsQk1VRThFVUV4UVRGQk1VRWtoRFNKWVN3U0JBb2oxc2tzRmdRT0k5YXVqS0twTEFhTW9xa3NGZ1FtSTlaeFBDS01vcXFNb3Frc0NJUThpV0VzREl5SllTd1FrSWxoTEJTRVFJbGhMQ1lFQ2lQVjNTd3FCQTRqMWNLTW9xa3NCb3lpcVNSVWlEa1JMQ0t0TEJ5RU1JbGhMQ0NVaVdFc0pJUVFpV0VzS0lRNGlXRXNMSVFVaVdFc01JUVlpV0VzTlZ3QkFTdzRoQnlKWVN3OGhDQ0pZU3hBaENTSllTeEZYUUVCTEVsZUFRRXNUVjhCQVN4UWhFU0pZU3hVaEVpSllUeFloQ2lKWVR3bFBCbEJQQlZCUEJGQlBDRkJQQjFCUERGQlBBMUJQQkZCUEFsQlBCRkJQREZCUEJWQlBCVkJQQWxCUEJGQlBCVkJNVUU4RFVFeFFUd0pRVEZCUEJJRWVpUFRBU3dFaEVTSllLRXNCb1U4Q29DaXFTd0lqSWxoTEF5UWlXRXNFSVFzaVdFc0RTd1NqS0tvb1R3V2hvQ2lxU1JVaURrUkxCNnRMQlNFTklsaExCaVVpV0VzSElRUWlXRXNJSVE0aVdFc0pJUThpV0VzS0lRVWlXRXNMSVFZaVdFc01Wd0JBU3cwaEJ5SllTdzRoRUNKWVN3OGhDQ0pZU3hBaENTSllTeEZYUUVCTEVsZUFRRXNUVjhCQVN4UWhFaUpZVHhVaENpSllUd2xQQlZCUEJGQlBBMUJQQ0ZCUEIxQlBCVkJQRDFCUEJGQlBBbEJQQlZCUEIxQlBCbEJQQmxCUEFsQlBCVkJQQmxCTVVFOEVVRXhRVEZCTVVFc0JGU0lPUkV4TEFxdE1VRThFSWc1RVR3UkxBcXRRVHdJaURrUk9BcXRRZ0FRVkgzeDFURkN3Z1FGRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
