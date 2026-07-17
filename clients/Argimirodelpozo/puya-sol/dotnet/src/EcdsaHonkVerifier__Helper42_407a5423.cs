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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper42_407a5423
{


    //
    // Helper contract 42 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper42Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper42Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class TranscriptLibGenerateTranscriptChunk7Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public Structs.Transcript Field1 { get; set; } = new Structs.Transcript();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    ret.AddRange(Field1.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TranscriptLibGenerateTranscriptChunk7Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TranscriptLibGenerateTranscriptChunk7Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    ret.Field1 = Structs.Transcript.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TranscriptLibGenerateTranscriptChunk7Return);
                }
                public bool Equals(TranscriptLibGenerateTranscriptChunk7Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TranscriptLibGenerateTranscriptChunk7Return left, TranscriptLibGenerateTranscriptChunk7Return right)
                {
                    return EqualityComparer<TranscriptLibGenerateTranscriptChunk7Return>.Default.Equals(left, right);
                }
                public static bool operator !=(TranscriptLibGenerateTranscriptChunk7Return left, TranscriptLibGenerateTranscriptChunk7Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proof"> Proof</param>
        /// <param name="publicInputs"> </param>
        /// <param name="publicInputsSize"> </param>
        /// <param name="previousChallenge"> </param>
        /// <param name="t"> Transcript</param>
        public async Task<Structs.TranscriptLibGenerateTranscriptChunk7Return> TranscriptLibGenerateTranscriptChunk7(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 114, 8, 4 };
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); publicInputsAbi.From(publicInputs);

            var result = await base.CallApp(new List<object> { abiHandle, proof, publicInputsAbi, publicInputsSize, previousChallenge, t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TranscriptLibGenerateTranscriptChunk7Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TranscriptLibGenerateTranscriptChunk7_Transactions(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 114, 8, 4 };
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); publicInputsAbi.From(publicInputs);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof, publicInputsAbi, publicInputsSize, previousChallenge, t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjQyIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA0MiBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRzFQcm9vZlBvaW50IjpbeyJuYW1lIjoieF8wIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ4XzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieV8xIiwidHlwZSI6InVpbnQ1MTIifV0sIlByb29mIjpbeyJuYW1lIjoiY2lyY3VpdFNpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c1NpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c09mZnNldCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidzEiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzIiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoielBlcm0iLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZENvdW50cyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBSZWFkVGFncyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBJbnZlcnNlcyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJzdW1jaGVja1VuaXZhcmlhdGVzIiwidHlwZSI6InVpbnQ1MTJbOF1bMjhdIn0seyJuYW1lIjoic3VtY2hlY2tFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50NTEyWzQ0XSJ9LHsibmFtZSI6ImdlbWluaUZvbGRDb21tcyIsInR5cGUiOiJHMVByb29mUG9pbnRbMjddIn0seyJuYW1lIjoiZ2VtaW5pQUV2YWx1YXRpb25zIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic2hwbG9ua1EiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoia3pnUXVvdGllbnQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In1dLCJUcmFuc2NyaXB0IjpbeyJuYW1lIjoiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUd28iLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImV0YVRocmVlIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnYW1tYSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWxwaGFzIiwidHlwZSI6InVpbnQ1MTJbMjVdIn0seyJuYW1lIjoiZ2F0ZUNoYWxsZW5nZXMiLCJ0eXBlIjoidWludDUxMlsyOF0ifSx7Im5hbWUiOiJzdW1DaGVja1VDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoicmhvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnZW1pbmlSIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rTnUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InNocGxvbmtaIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNEZWx0YSIsInR5cGUiOiJ1aW50NTEyIn1dLCJUcmFuc2NyaXB0TGliR2VuZXJhdGVUcmFuc2NyaXB0Q2h1bms3UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVHJhbnNjcmlwdCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJUcmFuc2NyaXB0TGliLmdlbmVyYXRlVHJhbnNjcmlwdF9fY2h1bmtfNyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyWzhdWzI4XSx1aW50NTEyWzQ0XSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMilbMjddLHVpbnQ1MTJbMjhdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiUHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNDaGFsbGVuZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTJbMjVdLHVpbnQ1MTJbMjhdLHVpbnQ1MTJbMjhdLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiVHJhbnNjcmlwdExpYkdlbmVyYXRlVHJhbnNjcmlwdENodW5rN1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjUxLDY3MCw2ODAsNjkwLDcwMSw3MjIsNzM1LDc0OCw3NjAsNzY5LDc4NCw4MDAsODE2LDgzNCw4NTEsODY5LDg4Nyw5MDQsOTQ1LDk2MSwxMDQ3LDExMDJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFByb29mIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBUcmFuc2NyaXB0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNjcsMTI3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NSw5MzcsOTU3LDEwMzAsMTA4NywxMzE0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU5ESXVYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNeklnTmpRZ01qVTJJREFnTXpJd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh3b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlvYjI1ckwyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVXZSV05rYzJGSWIyNXJWbVZ5YVdacFpYSXVjMjlzTGxSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVkJiSEJvWVVOb1lXeHNaVzVuWlhNb2NISmxkbWx2ZFhORGFHRnNiR1Z1WjJVNklHSjVkR1Z6TENCd2NtOXZaam9nWW5sMFpYTXBJQzArSUhWcGJuUTJOQ3dnWW5sMFpYTXNJR0o1ZEdWek9ncFVjbUZ1YzJOeWFYQjBUR2xpTG1kbGJtVnlZWFJsUVd4d2FHRkRhR0ZzYkdWdVoyVnpPZ29nSUNBZ2NISnZkRzhnTWlBekNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01DQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhPVGcwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNalUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMk5DQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJSEpsY0d4aFkyVXlJREV5T0NBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURNS0lDQWdJR0o4Q2lBZ0lDQnlaWEJzWVdObE1pQXhPVElnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjhDaUFnSUNCcGJuUmpYeklnTHk4Z01qVTJDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeE1qRTJDaUFnSUNCcGJuUmpYeklnTHk4Z01qVTJDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5SaklEUWdMeThnTXpJd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVeklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0JpZkFvZ0lDQWdjSFZ6YUdsdWRDQXpPRFFLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJSEIxYzJocGJuUWdORFE0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJSEIxYzJocGJuUWdOVEV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05qUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBMk5DQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNalUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTBJQzh2SURNeU1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016ZzBDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTBORGdLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOVEV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elkzSnBjSFJNYVdJdWMzQnNhWFJEYUdGc2JHVnVaMlVLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGUnlZVzV6WTNKcGNIUk1hV0l1YzNCc2FYUkRhR0ZzYkdWdVoyVUtJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklESUtJQ0FnSUdKOENpQWdJQ0JrYVdjZ013b2dJQ0FnYkc5aFpITUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURBZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGUnlZVzV6WTNKcGNIUk1hV0l1YzNCc2FYUkRhR0ZzYkdWdVoyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdjbVZ3YkdGalpUSWdOalFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemRHOXlaWE1LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NncFVjbUZ1YzJOeWFYQjBUR2xpTG1kbGJtVnlZWFJsUVd4d2FHRkRhR0ZzYkdWdVoyVnpYM2RvYVd4bFgzUnZjRUF4T2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1l3b2dJQ0FnWWp3S0lDQWdJR0o2SUZSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVkJiSEJvWVVOb1lXeHNaVzVuWlhOZllXWjBaWEpmZDJocGJHVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWTJGc2JITjFZaUJVY21GdWMyTnlhWEIwVEdsaUxuTndiR2wwUTJoaGJHeGxibWRsQ2lBZ0lDQmlkWEo1SURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCaUtnb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR0lyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpZkFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiRzloWkhNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBcUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVeklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM1J2Y21WekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdZaUJVY21GdWMyTnlhWEIwVEdsaUxtZGxibVZ5WVhSbFFXeHdhR0ZEYUdGc2JHVnVaMlZ6WDNkb2FXeGxYM1J2Y0VBeENncFVjbUZ1YzJOeWFYQjBUR2xpTG1kbGJtVnlZWFJsUVd4d2FHRkRhR0ZzYkdWdVoyVnpYMkZtZEdWeVgzZG9hV3hsUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01Rb2dJQ0FnWWlVS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQlVjbUZ1YzJOeWFYQjBUR2xpTG5Od2JHbDBRMmhoYkd4bGJtZGxDaUFnSUNCd2IzQnVJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCVWNtRnVjMk55YVhCMFRHbGlMbk53YkdsMFEyaGhiR3hsYm1kbENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHOWhaSE1LSUNBZ0lIQjFjMmhwYm5RZ01UVXpOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCemRHOXlaWE1LSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJodmJtc3ZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaUzlGWTJSellVaHZibXRXWlhKcFptbGxjaTV6YjJ3dVZISmhibk5qY21sd2RFeHBZaTV6Y0d4cGRFTm9ZV3hzWlc1blpTaGphR0ZzYkdWdVoyVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNNkNsUnlZVzV6WTNKcGNIUk1hV0l1YzNCc2FYUkRhR0ZzYkdWdVoyVTZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5b2IyNXJMMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlV2UldOa2MyRkliMjVyVm1WeWFXWnBaWEl1YzI5c0xrVmpaSE5oU0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJME1pNWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYeWdwSUMwK0lIVnBiblEyTkRvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxODZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hNVGN5TURnd05DQXZMeUJ0WlhSb2IyUWdJbFJ5WVc1elkzSnBjSFJNYVdJdVoyVnVaWEpoZEdWVWNtRnVjMk55YVhCMFgxOWphSFZ1YTE4M0tDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExIVnBiblExTVRKYk9GMWJNamhkTEhWcGJuUTFNVEpiTkRSZExDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1ZzeU4xMHNkV2x1ZERVeE1sc3lPRjBzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTa3NZbmwwWlZzek1sMWJYU3gxYVc1ME5URXlMSFZwYm5RMU1USXNLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5V3pJMVhTeDFhVzUwTlRFeVd6STRYU3gxYVc1ME5URXlXekk0WFN4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBLU2gxYVc1ME5URXlMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWxzeU5WMHNkV2x1ZERVeE1sc3lPRjBzZFdsdWREVXhNbHN5T0Ywc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOVVjbUZ1YzJOeWFYQjBUR2xpTG1kbGJtVnlZWFJsVkhKaGJuTmpjbWx3ZEY5ZlkyaDFibXRmTjE5eWIzVjBaVUF4Q2lBZ0lDQmxjbklLQ2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxUnlZVzV6WTNKcGNIUk1hV0l1WjJWdVpYSmhkR1ZVY21GdWMyTnlhWEIwWDE5amFIVnVhMTgzWDNKdmRYUmxRREU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCVWNtRnVjMk55YVhCMFRHbGlMbWRsYm1WeVlYUmxWSEpoYm5OamNtbHdkRjlmWTJoMWJtdGZOd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5b2IyNXJMMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlV2UldOa2MyRkliMjVyVm1WeWFXWnBaWEl1YzI5c0xrVmpaSE5oU0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJME1pNVVjbUZ1YzJOeWFYQjBUR2xpTG1kbGJtVnlZWFJsVkhKaGJuTmpjbWx3ZEY5ZlkyaDFibXRmTjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNsUnlZVzV6WTNKcGNIUk1hV0l1WjJWdVpYSmhkR1ZVY21GdWMyTnlhWEIwWDE5amFIVnVhMTgzT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qZzJNRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGQnliMjltQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBqNEtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J3YjNBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTFPREkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlVjbUZ1YzJOeWFYQjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elkzSnBjSFJNYVdJdVoyVnVaWEpoZEdWQmJIQm9ZVU5vWVd4c1pXNW5aWE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpVRnNjR2hoUTJoaGJHeGxibWRsY3dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JzYjJGa2N3b2dJQ0FnYVc1MFl5QTBJQzh2SURNeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU5ESXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRklFQ0FBZ0RBQWlZQklEQmtUbkxoTWFBcHVGQkZ0b0dCV0Ywb00raEllYmx3a1VQaDlaUHdBQUFCUWdTRmlnSURKWUFBU1NPdlNVNENpLzRWSXc1RWkvNUxBYXVBd0FRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVhBQ0wvNEhBRHlSWVNWY0FRRXNEcTA4Q1RGeEFTd0ZYUUVCTEE2dGNnRXNCVjRCQVN3T3JYTUJNVjhCQVN3S3JKRXhkaS8rQndBa2tXRWxYQUVCTEE2dFBBaUVFVHdKZFN3RlhRRUJMQTZ1QmdBTk1YVXNCVjRCQVN3T3JnY0FEVEYxTVY4QkFTd0tyZ1lBRVRGMGlyMGxPQWs0RVNWY0FRRXNDVEZCSkZTSUpJbGhMQVZkQVFFc0RURkJKRlNJSklsaFFTd0ZYZ0VCTEEweFFTUlVpQ1NKWVVFc0JWOEJBU3dOTVVFa1ZJZ2tpV0ZCTEFTUWpXRXNEVEZCSkZTSUpJbGhRU3dFaEJDTllTd05NVUVrVklna2lXRkJMQVlHQUF5TllTd05NVUVrVklna2lXRkJMQVlIQUF5TllTd05NVUVrVklna2lXRkJNZ1lBRUkxaFBBa3hRU1JVaUNTSllVQUlvcWtsT0EwbUlBTDlHQWttSUFMbElTUlVqRGtSTEFxdExBejVNWEFCTWlBQ21SUUZKRlNNT1JFOENxMXhBUDRFQkZrbUJBaGFNQUlzR2dBRU1wRUVBVElzRGl3UlFTUlVpQ1NKWUFpaXFTWXdFaUFCelJRR0JDSytMQUlzR1NVNEVvNHNGb0ZCSkZZRUlDVnRMQVJVakRrUk1pd0tyaXdGSlRnSStUd01qQzA4Q1hUK0FBUUdnakFaQy82YUxBNHNFVUVrVklna2lXQUlvcWttSUFDbEdBa21JQUNOSVNSVWpEa1NMQXF1TEFVbE9BajZCZ0F4UEFsMUxBVXcvVEl2L2pBS01BWXdBaVlvQkFvdi9nQkQvLy8vLy8vLy8vLy8vLy8vLy8vLy9yQ0t2aS8rQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBb2tzQlR3TlFTUlVpQ1NKWUtLcE9BbEJKRlNJSklsZ29xb21BQkJGeUNBUTJHZ0NPQVFBQkFERVpGREVZRUVSQ0FBQTJHZ0ZKRllIQTN3RVNSRFlhQWtrbFdTSUxnUUlJU3dFVkVrU0JBaVZZU0RZYUF4VWpFa1EyR2dSSkZVa2pFa1EyR2dWSkZZSEFMUkpFU3dKUEJJajdJazRDUmdKTEEweUkreGhHQWo0aEJFeGRUQ01PUkNPdlR3S3JURkNBQkJVZmZIVk1VTENCQVVNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
