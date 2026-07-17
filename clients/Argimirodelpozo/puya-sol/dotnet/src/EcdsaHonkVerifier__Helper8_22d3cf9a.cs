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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper8_22d3cf9a
{


    //
    // Helper contract 8 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper8Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper8Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public Structs.PoseidonExternalParams Field2 { get; set; } = new Structs.PoseidonExternalParams();

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
                    ret.AddRange(Field2.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    ret.Field2 = Structs.PoseidonExternalParams.Parse(queue.ToArray());
                    { var consumedField2 = ret.Field2.ToByteArray().Length; for (int i = 0; i < consumedField2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return);
                }
                public bool Equals(RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return left, RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return right)
                {
                    return EqualityComparer<RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return>.Default.Equals(left, right);
                }
                public static bool operator !=(RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return left, RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return right)
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
        /// <param name="ep"> PoseidonExternalParams</param>
        public async Task<Structs.RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return> RelationsLibAccumulateRelationEvaluationsChunk3Chunk1(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, Structs.PoseidonExternalParams ep, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 81, 196, 201 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            var result = await base.CallApp(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, ep }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RelationsLibAccumulateRelationEvaluationsChunk3Chunk1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RelationsLibAccumulateRelationEvaluationsChunk3Chunk1_Transactions(Structs.Proof proof, Structs.Transcript tp, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 powPartialEval, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 accumulator, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] evaluations, AVM.ClientGenerator.ABI.ARC4.Types.UInt512[] purportedEvaluations, Structs.PoseidonExternalParams ep, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 81, 196, 201 };
            var evaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(26, "uint512"); evaluationsAbi.From(evaluations);
            var purportedEvaluationsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt512>(44, "uint512"); purportedEvaluationsAbi.From(purportedEvaluations);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof, tp, powPartialEval, accumulator, evaluationsAbi, purportedEvaluationsAbi, ep }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 2;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjgiLCJkZXNjIjoiSGVscGVyIGNvbnRyYWN0IDggZm9yIEVjZHNhSG9ua1ZlcmlmaWVyIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkcxUHJvb2ZQb2ludCI6W3sibmFtZSI6InhfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieF8xIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ5XzAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMSIsInR5cGUiOiJ1aW50NTEyIn1dLCJQb3NlaWRvbkV4dGVybmFsUGFyYW1zIjpbeyJuYW1lIjoiczEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InMyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzMyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiczQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InUxIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ1MiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidTMiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InU0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ0MCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidDEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InQyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ0MyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidjEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InYyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ2MyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidjQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InFfcG9zX2J5X3NjYWxpbmciLCJ0eXBlIjoidWludDUxMiJ9XSwiUHJvb2YiOlt7Im5hbWUiOiJjaXJjdWl0U2l6ZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicHVibGljSW5wdXRzU2l6ZSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoicHVibGljSW5wdXRzT2Zmc2V0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ3MSIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJ3MiIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJ3MyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJ3NCIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJ6UGVybSIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBSZWFkQ291bnRzIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imxvb2t1cFJlYWRUYWdzIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imxvb2t1cEludmVyc2VzIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InN1bWNoZWNrVW5pdmFyaWF0ZXMiLCJ0eXBlIjoidWludDUxMls4XVsyOF0ifSx7Im5hbWUiOiJzdW1jaGVja0V2YWx1YXRpb25zIiwidHlwZSI6InVpbnQ1MTJbNDRdIn0seyJuYW1lIjoiZ2VtaW5pRm9sZENvbW1zIiwidHlwZSI6IkcxUHJvb2ZQb2ludFsyN10ifSx7Im5hbWUiOiJnZW1pbmlBRXZhbHVhdGlvbnMiLCJ0eXBlIjoidWludDUxMlsyOF0ifSx7Im5hbWUiOiJzaHBsb25rUSIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJremdRdW90aWVudCIsInR5cGUiOiJHMVByb29mUG9pbnQifV0sIlRyYW5zY3JpcHQiOlt7Im5hbWUiOiJldGEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImV0YVR3byIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZXRhVGhyZWUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImJldGEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImdhbW1hIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhbHBoYXMiLCJ0eXBlIjoidWludDUxMlsyNV0ifSx7Im5hbWUiOiJnYXRlQ2hhbGxlbmdlcyIsInR5cGUiOiJ1aW50NTEyWzI4XSJ9LHsibmFtZSI6InN1bUNoZWNrVUNoYWxsZW5nZXMiLCJ0eXBlIjoidWludDUxMlsyOF0ifSx7Im5hbWUiOiJyaG8iLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImdlbWluaVIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InNocGxvbmtOdSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoic2hwbG9ua1oiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c0RlbHRhIiwidHlwZSI6InVpbnQ1MTIifV0sIlJlbGF0aW9uc0xpYkFjY3VtdWxhdGVSZWxhdGlvbkV2YWx1YXRpb25zQ2h1bmszQ2h1bmsxUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJQb3NlaWRvbkV4dGVybmFsUGFyYW1zIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IlJlbGF0aW9uc0xpYi5hY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc19fY2h1bmtfM19fY2h1bmtfMSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyWzhdWzI4XSx1aW50NTEyWzQ0XSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMilbMjddLHVpbnQ1MTJbMjhdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiUHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3dQYXJ0aWFsRXZhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY3VtdWxhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyWzI2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyWzQ0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvcnRlZEV2YWx1YXRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlBvc2VpZG9uRXh0ZXJuYWxQYXJhbXMiLCJuYW1lIjoiZXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSkiLCJzdHJ1Y3QiOiJSZWxhdGlvbnNMaWJBY2N1bXVsYXRlUmVsYXRpb25FdmFsdWF0aW9uc0NodW5rM0NodW5rMVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTIsNDA4Miw0MTE5XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUG9zZWlkb25FeHRlcm5hbFBhcmFtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBUcmFuc2NyaXB0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDUxMiwgMjY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDUxMiwgNDQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzLDE1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMsMTI2OCwxNDM1LDE2MDIsMTc5OCwxOTcwLDIxNDIsMjMxNCwyNDMyLDI1ODYsMjc0MSwyOTAyLDMwOTMsMzI1MiwzMzkyLDM1NTEsMzcwMywzODY2LDM5MzMsNDE1NCw0MTY0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU9DNWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYeWdwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QTJOQ0F4TURJMElEYzJPQ0E0TXpJZ05URXlJRFUzTmlBMk5EQWdOekEwSURJMU5pQXpNakFnTXpnMElEUTBPQ0E0T1RZZ09UWXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNU0FpSWdvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMbEpsYkdGMGFXOXVjMHhwWWk1M2FYSmxLSEE2SUhWcGJuUTJOQ3dnWDNkcGNtVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbEpsYkdGMGFXOXVjMHhwWWk1M2FYSmxPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiRzloWkhNS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW9iMjVyTDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJVdlJXTmtjMkZJYjI1clZtVnlhV1pwWlhJdWMyOXNMa1ZqWkhOaFNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSTRMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncGZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYem9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0UyTlRGak5HTTVJQzh2SUcxbGRHaHZaQ0FpVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHpYMTlqYUhWdWExOHhLQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBMSFZwYm5RMU1USmJPRjFiTWpoZExIVnBiblExTVRKYk5EUmRMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtWc3lOMTBzZFdsdWREVXhNbHN5T0Ywc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU2tzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeVd6STFYU3gxYVc1ME5URXlXekk0WFN4MWFXNTBOVEV5V3pJNFhTeDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlXekkyWFN4MWFXNTBOVEV5V3pRMFhTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU2tvZFdsdWREVXhNaXgxYVc1ME5URXlMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lGOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMUpsYkdGMGFXOXVjMHhwWWk1aFkyTjFiWFZzWVhSbFVtVnNZWFJwYjI1RmRtRnNkV0YwYVc5dWMxOWZZMmgxYm10Zk0xOWZZMmgxYm10Zk1WOXliM1YwWlVBeENpQWdJQ0JsY25JS0NsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMUpsYkdGMGFXOXVjMHhwWWk1aFkyTjFiWFZzWVhSbFVtVnNZWFJwYjI1RmRtRnNkV0YwYVc5dWMxOWZZMmgxYm10Zk0xOWZZMmgxYm10Zk1WOXliM1YwWlVBeE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdVbVZzWVhScGIyNXpUR2xpTG1GalkzVnRkV3hoZEdWU1pXeGhkR2x2YmtWMllXeDFZWFJwYjI1elgxOWphSFZ1YTE4elgxOWphSFZ1YTE4eENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMmh2Ym1zdlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpTOUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNpNXpiMnd1UldOa2MyRkliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjamd1VW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHpYMTlqYUhWdWExOHhXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LVW1Wc1lYUnBiMjV6VEdsaUxtRmpZM1Z0ZFd4aGRHVlNaV3hoZEdsdmJrVjJZV3gxWVhScGIyNXpYMTlqYUhWdWExOHpYMTlqYUhWdWExOHhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJNE5qQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCUWNtOXZaZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURVNE1qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZSeVlXNXpZM0pwY0hRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmpZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblExTVRJc0lESTJQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJNE1UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERVeE1pd2dORFErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1EZzRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCUWIzTmxhV1J2YmtWNGRHVnlibUZzVUdGeVlXMXpDaUFnSUNCaWVYUmxZMTh4SUM4dklDSWlDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWlJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklEUUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nTkNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEVWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUEySUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ055QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGdnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09TQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eUlDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURJNUNpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JqWVd4c2MzVmlJRkpsYkdGMGFXOXVjMHhwWWk1M2FYSmxDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURVZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QTJJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTnlBdkx5QTNNRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklEZ2dMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR01nT1NBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWXlBeE1TQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZMTh5SUM4dklEYzJPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMENpQWdJQ0JwYm5Salh6TWdMeThnT0RNeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR01nTVRJZ0x5OGdPRGsyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJREUyQ2lBZ0lDQnBiblJqSURFeklDOHZJRGsyTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01UQXlOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTXpBS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdScFp5QTNDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR05oYkd4emRXSWdVbVZzWVhScGIyNXpUR2xpTG5kcGNtVUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdNZ05DQXZMeUExTVRJS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpJRFVnTHk4Z05UYzJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWXlBMklDOHZJRFkwTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsdWRHTWdOeUF2THlBM01EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBiblJqSURnZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdPU0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWXlBeE1DQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFkxOHlJQzh2SURjMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERTJDaUFnSUNCcGJuUmpJREV6SUM4dklEazJNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTBJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTlNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEWWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUEzSUM4dklEY3dOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURjS0lDQWdJR1JwWnlBNENpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRGdLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTRDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01URUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdPU0F2THlBek1qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWXlBeE1DQXZMeUF6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FXNTBZeUF4TVNBdkx5QTBORGdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnYVc1MFkxOHlJQzh2SURjMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdsdWRHTWdNVElnTHk4Z09EazJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERTJDaUFnSUNCcGJuUmpJREV6SUM4dklEazJNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTBJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTlNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEWWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUEzSUM4dklEY3dOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTNDaUFnSUNCa2FXY2dPQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1JwWnlBNENpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQnBiblJqSURFd0lDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpJREV4SUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6SWdMeThnTnpZNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR05mTXlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBNE9UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01UWUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z09UWXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERTFDaUFnSUNCMWJtTnZkbVZ5SURFMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01USTRJRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5SaklEUWdMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZeUExSUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdNZ05pQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJRGNnTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhVzUwWXlBNElDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCcGJuUmpJRGtnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURnS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dPQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW53S0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eUlDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURFeU9DQTJOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBMElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURZZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QTNJQzh2SURjd05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nT0NBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVc1MFl5QTVJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQnBiblJqSURFd0lDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEY0tJQ0FnSUdScFp5QTRDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaR2xuSURnS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHbHVkR05mTWlBdkx5QTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqSURFeUlDOHZJRGc1TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TmdvZ0lDQWdhVzUwWXlBeE15QXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRVS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdNalFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nT0NBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEa2dMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQXlDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ09Rb2dJQ0FnWW53S0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklEVWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPUW9nSUNBZ2FXNTBZeUEySUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5SaklEY2dMeThnTnpBMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHbHVkR01nTVRBZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdOZk1pQXZMeUEzTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ3pNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JwYm5SaklERXlJQzh2SURnNU5nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5nb2dJQ0FnYVc1MFl5QXhNeUF2THlBNU5qQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01UVUtJQ0FnSUhWdVkyOTJaWElnTVRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTBJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTVRBZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjRElLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1lud0tJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRFlnTHk4Z05qUXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ055QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUE0SUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5SaklEa2dMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHbHVkR05mTWlBdkx5QTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqSURFeUlDOHZJRGc1TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TmdvZ0lDQWdhVzUwWXlBeE15QXZMeUE1TmpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRVS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdNalFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nTkNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEVWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUE1SUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1lud0tJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGNnTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eUlDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURFeU9DQTJOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBMElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURZZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTBDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01URUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdsdWRHTWdPQ0F2THlBeU5UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWXlBNUlDOHZJRE15TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpJREV3SUM4dklETTROQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6SWdMeThnTnpZNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR05mTXlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnYVc1MFl5QXhNaUF2THlBNE9UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ01UWUtJQ0FnSUdsdWRHTWdNVE1nTHk4Z09UWXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlERTFDaUFnSUNCMWJtTnZkbVZ5SURFMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TURJMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01USTRJRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5SaklEUWdMeThnTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZeUExSUM4dklEVTNOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdNZ05pQXZMeUEyTkRBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpJRGNnTHk4Z056QTBDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhVzUwWXlBNElDOHZJREkxTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCcGJuUmpJRGtnTHk4Z016SXdDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR2x1ZEdNZ01UQWdMeThnTXpnMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR01nTVRFZ0x5OGdORFE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdsdWRHTmZNaUF2THlBM05qZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TkFvZ0lDQWdhVzUwWTE4eklDOHZJRGd6TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdhVzUwWXlBeE1pQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXhOd29nSUNBZ1lud0tJQ0FnSUhWdVkyOTJaWElnTVRVS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdNalFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nTkNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEVWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUEySUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ055QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGdnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09TQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eUlDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFM0NpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRBeU5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFl5QTBJQzh2SURVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lHbHVkR01nTlNBdkx5QTFOellLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEWWdMeThnTmpRd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZeUEzSUM4dklEY3dOQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2FXNTBZeUE1SUM4dklETXlNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0JwYm5SaklERXdJQzh2SURNNE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqSURFeElDOHZJRFEwT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXpDaUFnSUNCcGJuUmpYeklnTHk4Z056WTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdaR2xuSURrS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZaVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdZbndLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdhVzUwWXlBeE1pQXZMeUE0T1RZS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTVRZS0lDQWdJR2x1ZEdNZ01UTWdMeThnT1RZd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMUNpQWdJQ0IxYm1OdmRtVnlJREUxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBMk5Bb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqSURRZ0x5OGdOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFl5QTFJQzh2SURVM05nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGNLSUNBZ0lHbHVkR01nTmlBdkx5QTJOREFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5SaklEY2dMeThnTnpBMENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPUW9nSUNBZ2FXNTBZeUE0SUM4dklESTFOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5SaklEa2dMeThnTXpJd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHbHVkR01nTVRBZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTWdNVEVnTHk4Z05EUTRDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2x1ZEdOZk1pQXZMeUEzTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhOQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ3pNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOd29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERTJDaUFnSUNCaWZBb2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpJREV5SUM4dklEZzVOZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXhOZ29nSUNBZ2FXNTBZeUF4TXlBdkx5QTVOakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lIVnVZMjkyWlhJZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFd01qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTWdOQ0F2THlBMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqSURVZ0x5OGdOVGMyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFl5QTJJQzh2SURZME1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbHVkR01nTnlBdkx5QTNNRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBNUNpQWdJQ0JwYm5SaklEZ2dMeThnTWpVMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR01nT1NBdkx5QXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnYVc1MFl5QXhNQ0F2THlBek9EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWXlBeE1TQXZMeUEwTkRnS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNd29nSUNBZ2FXNTBZMTh6SUM4dklEZ3pNZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURVS0lDQWdJR1JwWnlBeENpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTVRZS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ05qUUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURFeU9DQTJOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWXlBMElDOHZJRFV4TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTWdOU0F2THlBMU56WUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqSURZZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFl5QTNJQzh2SURjd05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRGtLSUNBZ0lHbHVkR01nT0NBdkx5QXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVc1MFl5QTVJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQnBiblJqSURFd0lDOHZJRE00TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpJREV4SUM4dklEUTBPQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JwYm5Salh6SWdMeThnTnpZNENpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbHVkR05mTXlBdkx5QTRNeklLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lHbHVkR01nTVRNZ0x5OGdPVFl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE53b2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lIVnVZMjkyWlhJZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNUW9nSUNBZ1kyRnNiSE4xWWlCU1pXeGhkR2x2Ym5OTWFXSXVkMmx5WlFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR01nTkNBdkx5QTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMkNpQWdJQ0JwYm5SaklEVWdMeThnTlRjMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOd29nSUNBZ2FXNTBZeUEySUM4dklEWTBNQW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURnS0lDQWdJR2x1ZEdNZ055QXZMeUEzTURRS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QTVDaUFnSUNCcGJuUmpJRGdnTHk4Z01qVTJDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdNZ09TQXZMeUF6TWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNUW9nSUNBZ2FXNTBZeUF4TUNBdkx5QXpPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFl5QXhNU0F2THlBME5EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TXdvZ0lDQWdhVzUwWTE4eUlDOHZJRGMyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYek1nTHk4Z09ETXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR2x1ZEdNZ01USWdMeThnT0RrMkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURFMkNpQWdJQ0JwYm5SaklERXpJQzh2SURrMk1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCc2IyRmtjd29nSUNBZ2NIVnphR2x1ZENBeE1UVXlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QXhNREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTNOamdLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2NIVnphR2x1ZENBek9Rb2dJQ0FnWTJGc2JITjFZaUJTWld4aGRHbHZibk5NYVdJdWQybHlaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHSXRDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0JpS2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh4SUM4dklDSWlDaUFnSUNCa2RYQUtJQ0FnSUd4dllXUnpDaUFnSUNCd2RYTm9hVzUwSURFeU1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdNalFLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5Salh6TWdMeThnT0RNeUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEIxYzJocGJuUWdOREFLSUNBZ0lHTmhiR3h6ZFdJZ1VtVnNZWFJwYjI1elRHbGlMbmRwY21VS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlPQzVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBT1FJQUlnQWJBQm9BRXdBU0FCY0FGZ0FMQUFvQUR3QU9BQjhBSEpnSWdNR1JPY3VFeG9DbTRVRVcyZ1lGWVhTZ3o2RWg1dVhDUlErSDFrL0FBQUFFQVFnQVppZ0lCZ1FpdmkvOFdVRWtWZ1FnSlc0ditQa3dpQ3lKWWlZQUVwbEhFeVRZYUFJNEJBQUVBTVJrVU1SZ1FSRUlBQURZYUFSV0J3TjhCRWtRMkdnSVZnY0F0RWtRMkdnTVZJaEpFTmhvRUZTSVNSRFlhQlJXQmdBMFNSRFlhQmhXQmdCWVNSRFlhQjBrVmdjQUlFa1FwZ1FBcFNZRWJpUCtJU3dHQkFvai9nYUFvcWtrVklnNUVJcTlNU3dHcmdJQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGQkpJeUpZU3dGWEFFQkxCSUVjaVB0ZlN3V0JBNGo3V0tBb3Fra1ZJZzVFU3dTclN3TlhnRUJMQkZmQVFFc0ZJUVFpV0VzR0lRVWlXRXNISVFZaVdFc0lJUWNpV0VzSklRZ2lXRXNLSVFraVdFc0xJUW9pV0VzTUlRc2lXRXNOSkNKWVN3NGxJbGhMRHlFTUlsaFBFQ0VOSWxoUEQwOFBVRThPVUU4TlVFOElVRThIVUU4R1VFOEZVRThJVUU4SFVFOEdVRThGVUU4RVVFOERVRThDVUV4UVRGQkpJeUpZU3dGWEFFQkxBbGRBUUVzRmdSMkkrcmhMQm9FRWlQcXhvQ2lxU1JVaURrUkxCYXRMQkZmQVFFc0ZJUVFpV0VzR0lRVWlXRXNISVFZaVdFc0lJUWNpV0VzSklRZ2lXRXNLSVFraVdFc0xJUW9pV0VzTUlRc2lXRXNOSkNKWVN3NGxJbGhMRHlFTUlsaFBFQ0VOSWxoUEQwOFBVRThPVUU4TlVFOElVRThIVUU4R1VFOEZVRThJVUU4SFVFOEdVRThGVUU4RVVFOERVRThDVUV4UVRGQkpJeUpZU3dGWEFFQkxBbGRBUUVzRFY0QkFTd2FCSG9qNkVVc0hnUVdJK2dxZ0tLcEpGU0lPUkVzR3Ewc0ZJUVFpV0VzR0lRVWlXRXNISVFZaVdFc0lJUWNpV0VzSklRZ2lXRXNLSVFraVdFc0xJUW9pV0VzTUlRc2lXRXNOSkNKWVN3NGxJbGhMRHlFTUlsaFBFQ0VOSWxoUEQwOFBVRThPVUU4TlVFOElVRThIVUU4R1VFOEZVRThJVUU4SFVFOEdVRThGVUU4RVVFOERVRThDVUV4UVRGQkpJeUpZU3dGWEFFQkxBbGRBUUVzRFY0QkFTd1JYd0VCTEJTRUVJbGhMQmlFRklsaExCeUVHSWxoTENDRUhJbGhMQjBzSW95aXFTd2lqS0twTENLTW9xa3NJb3lpcVNSVWlEa1JMQzZ0TENpRUpJbGhMQ3lFS0lsaExEQ0VMSWxoTERTUWlXRXNPSlNKWVN3OGhEQ0pZVHhBaERTSllUdzlQRDFCUERsQlBEVkJQQ0ZCUEIxQlBCbEJQQlZCUENGQlBCMUJQQmxCUEJWQlBCRkJQQTFCUEFsQk1VRXhRU1NNaVdFc0JWd0JBU3dKWFFFQkxBMWVBUUVzRVY4QkFTd1VoQkNKWVN3WWhCU0pZU3djaEJpSllTd2doQnlKWVN3a2hDQ0pZU3dkTENLTW9xa3NJb3lpcVN3aWpLS3BMQ0tNb3Fra1ZJZzVFU3d5clN3c2hDaUpZU3d3aEN5SllTdzBrSWxoTERpVWlXRXNQSVF3aVdFOFFJUTBpV0U4UFR3OVFUdzVRVHcxUVR3aFFUd2RRVHdaUVR3VlFUd2hRVHdkUVR3WlFUd1ZRVHdSUVR3TlFUd0pRVEZCTVVFa2pJbGhMQVZjQVFFc0NWMEJBU3dOWGdFQkxCRmZBUUVzRklRUWlXRXNHSVFVaVdFc0hJUVlpV0VzSUlRY2lXRXNKSVFnaVdFc0tJUWtpV0VzSFN3aWpLS3BMQ0tNb3Frc0lveWlxU3dpaktLcEpGU0lPUkVzTnEwc01JUXNpV0VzTkpDSllTdzRsSWxoTER5RU1JbGhQRUNFTklsaFBEMDhQVUU4T1VFOE5VRThJVUU4SFVFOEdVRThGVUU4SVVFOEhVRThHVUU4RlVFOEVVRThEVUU4Q1VFeFFURkJKSXlKWVN3RlhBRUJMQWxkQVFFc0RWNEJBU3dSWHdFQkxCU0VFSWxoTEJpRUZJbGhMQnlFR0lsaExDQ0VISWxoTENTRUlJbGhMQ2lFSklsaExDeUVLSWxoTEIwc0lveWlxU3dpaktLcExDS01vcWtzSW95aXFTUlVpRGtSTERxdExEU1FpV0VzT0pTSllTdzhoRENKWVR4QWhEU0pZVHc5UEQxQlBEbEJQRFZCUENGQlBCMUJQQmxCUEJWQlBDRkJQQjFCUEJsQlBCVkJQQkZCUEExQlBBbEJNVUV4UVNTTWlXRXNCVndCQVN3SlhRRUJMQTFlQVFFc0VWOEJBU3dVaENDSllTd1loQ1NKWVNxQW9xa2tWSWc1RVN3bXJTd2doQlNKWVN3a2hCaUpZU3dvaEJ5SllTd3NoQ2lKWVN3d2hDeUpZU3cwa0lsaExEaVVpV0VzUElRd2lXRThRSVEwaVdFOFBUdzlRVHc1UVR3MVFUd3hRVHd0UVR3WlFUd1ZRVHdoUVR3ZFFUd1pRVHdWUVR3UlFUd05RVHdKUVRGQk1VRWtqSWxoTEFWY0FRRXNDVjBCQVN3TlhnRUJMQkZmQVFFc0ZJUVFpV0VzR0lRb2lXRXNISVFzaVdFcWdLS3BKRlNJT1JFc0txMHNKSVFZaVdFc0tJUWNpV0VzTElRZ2lXRXNNSVFraVdFc05KQ0pZU3c0bElsaExEeUVNSWxoUEVDRU5JbGhQRDA4UFVFOE9VRThOVUU4R1VFOEZVRThKVUU4SVVFOElVRThIVUU4R1VFOEZVRThFVUU4RFVFOENVRXhRVEZCSkl5SllTd0ZYQUVCTEFsZEFRRXNEVjRCQVN3Ulh3RUJMQlNFRUlsaExCaUVGSWxoTEJ5RUpJbGhKU3dHZ0tLcExBcUFvcWtrVklnNUVTd3FyU3draEJ5SllTd29oQ0NKWVN3c2hDaUpZU3d3aEN5SllTdzBrSWxoTERpVWlXRXNQSVF3aVdFOFFJUTBpV0U4UFR3OVFUdzVRVHcxUVR3ZFFUd2xRVHdaUVR3VlFUd2hRVHdkUVR3WlFUd1ZRVHdSUVR3TlFUd0pRVEZCTVVFa2pJbGhMQVZjQVFFc0NWMEJBU3dOWGdFQkxCRmZBUUVzRklRUWlXRXNHSVFVaVdFc0hJUVlpV0VzSUlRc2lXRWxMQWFBb3Frc0VvQ2lxU1JVaURrUkxDNnRMQ2lFSUlsaExDeUVKSWxoTERDRUtJbGhMRFNRaVdFc09KU0pZU3c4aERDSllUeEFoRFNKWVR3OVBEMUJQRGxCUERWQlBCMUJQQmxCUEJWQlBCbEJQQ0ZCUEIxQlBCbEJQQlZCUEJGQlBBMUJQQWxCTVVFeFFTU01pV0VzQlZ3QkFTd0pYUUVCTEExZUFRRXNFVjhCQVN3VWhCQ0pZU3dZaEJTSllTd2NoQmlKWVN3Z2hCeUpZU3draENDSllTd29oQ1NKWVN3c2hDaUpZU3d3aEN5SllTdzBrSWxoTERpVWlXRThQSVF3aVdFc0pTd3FnS0twSkZTSU9SRXNScTA4UFR3OVFUdzVRVHcxUVR3aFFUd2RRVHdaUVR3VlFUd2hRVHdkUVR3WlFUd1ZRVHdSUVR3TlFUd0pRVEZCTVVFa2pJbGhMQVZjQVFFc0NWMEJBU3dOWGdFQkxCRmZBUUVzRklRUWlXRXNHSVFVaVdFc0hJUVlpV0VzSUlRY2lXRXNKSVFnaVdFc0tJUWtpV0VzTElRb2lXRXNNSVFzaVdFc05KQ0pZU3c0bElsaExEeUVNSWxoUEVDRU5JbGhKb0NpcVN3aWdLS3BKRlNJT1JFc1JxMDhQVHc5UVR3NVFUdzFRVHdoUVR3ZFFUd1pRVHdWUVR3aFFUd2RRVHdaUVR3VlFUd1JRVHdOUVR3SlFURkJNVUVraklsaExBVmNBUUVzQ1YwQkFTd05YZ0VCTEJGZkFRRXNGSVFRaVdFc0dJUVVpV0VzSElRWWlXRXNJSVFjaVdFc0pJUWdpV0VzS0lRa2lXRXNMSVFvaVdFc01JUXNpV0VzTkpDSllTd2hMQ2FBb3Fra1ZJZzVFU3hDclN3OGhEQ0pZVHhBaERTSllUdzlQRDFCUERsQlBEVkJQQ0ZCUEIxQlBCbEJQQlZCUENGQlBCMUJQQmxCUEJWQlBCRkJQQTFCUEFsQk1VRXhRU1NNaVdFc0JWd0JBU3dKWFFFQkxBMWVBUUVzRVY4QkFTd1VoQkNKWVN3WWhCU0pZU3djaEJpSllTd2doQnlKWVN3a2hDQ0pZU3dvaENTSllTd3NoQ2lKWVN3d2hDeUpZU3cwa0lsaExEaVVpV0VtZ0tLcExCNkFvcWtrVklnNUVTeENyU3c4aERDSllUeEFoRFNKWVR3OVBEMUJQRGxCUERWQlBDRkJQQjFCUEJsQlBCVkJQQ0ZCUEIxQlBCbEJQQlZCUEJGQlBBMUJQQWxCTVVFeFFTU01pV0VzQlZ3QkFTd0pYUUVCTEExZUFRRXNFVjhCQVN3VWhCQ0pZU3dZaEJTSllTd2NoQmlKWVN3Z2hCeUpZU3draENDSllTd29oQ1NKWVN3c2hDaUpZU3d3aEN5SllTdzBsSWxoTEJVc0JvQ2lxU1JVaURrUkxFS3RMRHlFTUlsaFBFQ0VOSWxoUEQwOFBVRThPVUU4TlVFOElVRThIVUU4R1VFOEZVRThJVUU4SFVFOEdVRThGVUU4RFVFOERVRThDVUV4UVRGQkpJeUpZU3dGWEFFQkxBbGRBUUVzRFY0QkFTd1JYd0VCTEJTRUVJbGhMQmlFRklsaExCeUVHSWxoTENDRUhJbGhMQ1NFSUlsaExDaUVKSWxoTEN5RUtJbGhMRENFTElsaExEU1FpV0VzT0pTSllUdzhoRFNKWVN3aExBYUFvcWtrVklnNUVTeEdyVHc5UEQxQlBEbEJQRFZCUENGQlBCMUJQQmxCUEJWQlBDRkJQQjFCUEJsQlBCVkJQQkZCUEExQk1VRXhRVEZCTEFvRUxpUER4VHdTaktLcEpGU0lPUkVzQ3Ewc0JWd0JBU3dKWFFFQkxBMWVBUUVzRVY4QkFTd1VoQkNKWVN3WWhCU0pZU3djaEJpSllTd2doQnlKWVN3a2hDQ0pZU3dvaENTSllTd3NoQ2lKWVN3d2hDeUpZU3cwa0lsaExEaVVpV0VzUElRd2lXRThRSVEwaVdFOFBUdzlRVHc1UVR3MVFUd2hRVHdkUVR3WlFUd1ZRVHdoUVR3ZFFUd1pRVHdWUVR3UlFUd05RVHdKUVRGQk1VRThEUG9HQUNTSllTd0VqSWxoUEFpUWlXRThFZ1NlSThFRW9US0dnS0txaktLcWdLS29wU1Q2QndBa2lXRXNFSXlKWVN3VWxJbGhQQTRFb2lQQWNLRXlob0NpcW95aXFvQ2lxU3dFVklnNUVURXNDcTBzQkZTSU9SRXhQQXF0UVRGQ0FCQlVmZkhWTVVMQ0JBVU09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
