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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper38_4c74b95d
{


    //
    // Helper contract 38 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper38Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper38Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class TranscriptLibGenerateTranscriptChunk5Return : AVMObjectType
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

                public static TranscriptLibGenerateTranscriptChunk5Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TranscriptLibGenerateTranscriptChunk5Return();
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
                    return Equals(obj as TranscriptLibGenerateTranscriptChunk5Return);
                }
                public bool Equals(TranscriptLibGenerateTranscriptChunk5Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TranscriptLibGenerateTranscriptChunk5Return left, TranscriptLibGenerateTranscriptChunk5Return right)
                {
                    return EqualityComparer<TranscriptLibGenerateTranscriptChunk5Return>.Default.Equals(left, right);
                }
                public static bool operator !=(TranscriptLibGenerateTranscriptChunk5Return left, TranscriptLibGenerateTranscriptChunk5Return right)
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
        public async Task<Structs.TranscriptLibGenerateTranscriptChunk5Return> TranscriptLibGenerateTranscriptChunk5(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 242, 109, 123 };
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); publicInputsAbi.From(publicInputs);

            var result = await base.CallApp(new List<object> { abiHandle, proof, publicInputsAbi, publicInputsSize, previousChallenge, t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TranscriptLibGenerateTranscriptChunk5Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TranscriptLibGenerateTranscriptChunk5_Transactions(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 242, 109, 123 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjM4IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAzOCBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRzFQcm9vZlBvaW50IjpbeyJuYW1lIjoieF8wIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ4XzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieV8xIiwidHlwZSI6InVpbnQ1MTIifV0sIlByb29mIjpbeyJuYW1lIjoiY2lyY3VpdFNpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c1NpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c09mZnNldCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidzEiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzIiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoielBlcm0iLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZENvdW50cyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBSZWFkVGFncyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBJbnZlcnNlcyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJzdW1jaGVja1VuaXZhcmlhdGVzIiwidHlwZSI6InVpbnQ1MTJbOF1bMjhdIn0seyJuYW1lIjoic3VtY2hlY2tFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50NTEyWzQ0XSJ9LHsibmFtZSI6ImdlbWluaUZvbGRDb21tcyIsInR5cGUiOiJHMVByb29mUG9pbnRbMjddIn0seyJuYW1lIjoiZ2VtaW5pQUV2YWx1YXRpb25zIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic2hwbG9ua1EiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoia3pnUXVvdGllbnQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In1dLCJUcmFuc2NyaXB0IjpbeyJuYW1lIjoiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUd28iLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImV0YVRocmVlIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnYW1tYSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWxwaGFzIiwidHlwZSI6InVpbnQ1MTJbMjVdIn0seyJuYW1lIjoiZ2F0ZUNoYWxsZW5nZXMiLCJ0eXBlIjoidWludDUxMlsyOF0ifSx7Im5hbWUiOiJzdW1DaGVja1VDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoicmhvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnZW1pbmlSIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rTnUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InNocGxvbmtaIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNEZWx0YSIsInR5cGUiOiJ1aW50NTEyIn1dLCJUcmFuc2NyaXB0TGliR2VuZXJhdGVUcmFuc2NyaXB0Q2h1bms1UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVHJhbnNjcmlwdCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJUcmFuc2NyaXB0TGliLmdlbmVyYXRlVHJhbnNjcmlwdF9fY2h1bmtfNSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyWzhdWzI4XSx1aW50NTEyWzQ0XSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMilbMjddLHVpbnQ1MTJbMjhdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiUHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNDaGFsbGVuZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTJbMjVdLHVpbnQ1MTJbMjhdLHVpbnQ1MTJbMjhdLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiVHJhbnNjcmlwdExpYkdlbmVyYXRlVHJhbnNjcmlwdENodW5rNVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDgyLDUwOCw1MjUsNTQyLDU1OCw1ODQsNjAxLDYxOCw2MzYsNjYzLDY4Myw3MDMsNzIyLDcyNCw3MzksNzU1LDc3MSw3ODcsODAzLDgxOSw4MzUsODUzLDg2OSw4ODcsOTA1LDkyMl0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFRyYW5zY3JpcHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMSwxMTIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTQsMTE3MF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNemd1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTXpJZ01qVTJJRFkwSURJNE9Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YUc5dWF5OWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxMMFZqWkhOaFNHOXVhMVpsY21sbWFXVnlMbk52YkM1VWNtRnVjMk55YVhCMFRHbGlMbWRsYm1WeVlYUmxRbVYwWVVGdVpFZGhiVzFoUTJoaGJHeGxibWRsY3lod2NtVjJhVzkxYzBOb1lXeHNaVzVuWlRvZ1lubDBaWE1zSUhCeWIyOW1PaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE02Q2xSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVkNaWFJoUVc1a1IyRnRiV0ZEYUdGc2JHVnVaMlZ6T2dvZ0lDQWdjSEp2ZEc4Z01pQTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0lDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERTBOeklLSUNBZ0lHbHVkR05mTVNBdkx5QXlOVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBek1pQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURZMENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUEyTkNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUSWdPVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURFNU1pQTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVndiR0ZqWlRJZ01USTRJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJREUzTWpnS0lDQWdJR2x1ZEdOZk1TQXZMeUF5TlRZS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXhOakFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVndiR0ZqWlRJZ01Ua3lJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRJNElEWTBDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBeU1qUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREU1TWlBMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHhJQzh2SURJMU5nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnT1RZd0NpQWdJQ0JwYm5Salh6RWdMeThnTWpVMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05qUUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eklDOHZJREk0T0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRFkwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQndkWE5vYVc1MElETXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhNamdnTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEIxYzJocGJuUWdNelV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNVGt5SURZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J3ZFhOb2FXNTBJRE00TkFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUTWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1pQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTVRZd0lETXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE9USWdNeklnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESXlOQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5TlRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpNakFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE0xTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F6T0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elkzSnBjSFJNYVdJdWMzQnNhWFJEYUdGc2JHVnVaMlVLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGUnlZVzV6WTNKcGNIUk1hV0l1YzNCc2FYUkRhR0ZzYkdWdVoyVUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRlJ5WVc1elkzSnBjSFJNYVdJdWMzQnNhWFJEYUdGc2JHVnVaMlVLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVVY21GdWMyTnlhWEIwVEdsaUxuTndiR2wwUTJoaGJHeGxibWRsS0dOb1lXeHNaVzVuWlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjem9LVkhKaGJuTmpjbWx3ZEV4cFlpNXpjR3hwZEVOb1lXeHNaVzVuWlRvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdScFp5QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURNd05qUTBaVGN5WlRFek1XRXdNamxpT0RVd05EVmlOamd4T0RFMU9EVmtNamd6TTJVNE5EZzNPV0k1TnpBNU1UUXpaVEZtTlRrelpqQXdNREF3TURFS0lDQWdJR0lsQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnek1EWTBOR1UzTW1VeE16RmhNREk1WWpnMU1EUTFZalk0TVRneE5UZzFaREk0TXpObE9EUTROemxpT1Rjd09URTBNMlV4WmpVNU0yWXdNREF3TURBeENpQWdJQ0JpSlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMmh2Ym1zdlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpTOUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNpNXpiMnd1UldOa2MyRkliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjak00TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3BmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHpvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCalpqSTJaRGRpSUM4dklHMWxkR2h2WkNBaVZISmhibk5qY21sd2RFeHBZaTVuWlc1bGNtRjBaVlJ5WVc1elkzSnBjSFJmWDJOb2RXNXJYelVvS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcExDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzZFdsdWREVXhNbHM0WFZzeU9GMHNkV2x1ZERVeE1sczBORjBzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBXekkzWFN4MWFXNTBOVEV5V3pJNFhTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwS1N4aWVYUmxXek15WFZ0ZExIVnBiblExTVRJc2RXbHVkRFV4TWl3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USmJNalZkTEhWcGJuUTFNVEpiTWpoZExIVnBiblExTVRKYk1qaGRMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrcEtIVnBiblExTVRJc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlXekkxWFN4MWFXNTBOVEV5V3pJNFhTeDFhVzUwTlRFeVd6STRYU3gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmWDFSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVlVjbUZ1YzJOeWFYQjBYMTlqYUhWdWExODFYM0p2ZFhSbFFERUtJQ0FnSUdWeWNnb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpWUnlZVzV6WTNKcGNIUmZYMk5vZFc1clh6VmZjbTkxZEdWQU1Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJRlJ5WVc1elkzSnBjSFJNYVdJdVoyVnVaWEpoZEdWVWNtRnVjMk55YVhCMFgxOWphSFZ1YTE4MUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMmh2Ym1zdlkyOXVkSEpoWTNSekwzSmxabVZ5Wlc1alpTOUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNpNXpiMnd1UldOa2MyRkliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjak00TGxSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVlVjbUZ1YzJOeWFYQjBYMTlqYUhWdWExODFXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpWUnlZVzV6WTNKcGNIUmZYMk5vZFc1clh6VTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5T0RZd09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVUhKdmIyWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQajRLSUNBZ0lIQjFjMmhwYm5SeklESWdNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEJ2Y0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVTRNalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGUnlZVzV6WTNKcGNIUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdWSEpoYm5OamNtbHdkRXhwWWk1blpXNWxjbUYwWlVKbGRHRkJibVJIWVcxdFlVTm9ZV3hzWlc1blpYTUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lIQnZjRzRnTXdvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdWSEpoYm5OamNtbHdkRXhwWWk1blpXNWxjbUYwWlVKbGRHRkJibVJIWVcxdFlVTm9ZV3hzWlc1blpYTUtJQ0FnSUhCdmNHNGdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREU1TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNemd1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVJSUFDUUtBQ0pnRWdNR1JPY3VFeG9DbTRVRVcyZ1lGWVhTZ3o2RWg1dVhDUlErSDFrL0FBQUFGQ0EraUtBZ1FpcjBtTC9sQkpGU0lKSWxpQW9BTUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRXhjQUl2L2djQUxJMWhKVndCQVN3Tk1VRWtWSWdraVdFOENURndnU3dGWFFFQkxBMHhRU1JVaUNTSllYRUJMQVZlQVFFc0RURkJKRlNJSklsaGNZRXhYd0VCTEFreFFTUlVpQ1NKWVhJQ0wvNEhBRFNOWVNWY0FRRXNEVEZCSkZTSUpJbGhQQWt4Y29Fc0JWMEJBU3dOTVVFa1ZJZ2tpV0Z6QVN3RlhnRUJMQTB4UVNSVWlDU0pZWE9CTVY4QkFTd0pNVUVrVklna2lXQ05NWFl2L2djQUhJMWhKVndCQVN3Tk1VRWtWSWdraVdFOENKVThDWFVzQlYwQkFTd05NVUVrVklna2lXSUhBQWt4ZFN3RlhnRUJMQTB4UVNSVWlDU0pZZ2VBQ1RGMU1WOEJBU3dKTVVFa1ZJZ2tpV0lHQUEweGRTVmNBSUVzQ1RGQkpGU0lKSWxoTEFWY2dJRXNEVEZCSkZTSUpJbGhRU3dGWFFDQkxBMHhRU1JVaUNTSllVRXNCVjJBZ1N3Tk1VRWtWSWdraVdGQkxBVmVBSUVzRFRGQkpGU0lKSWxoUVN3RlhvQ0JMQTB4UVNSVWlDU0pZVUVzQlY4QWdTd05NVUVrVklna2lXRkJMQVZmZ0lFc0RURkJKRlNJSklsaFFTd0VqSWxoTEEweFFTUlVpQ1NKWVVFc0JKU0pZU3dOTVVFa1ZJZ2tpV0ZCTEFZSEFBaUpZU3dOTVVFa1ZJZ2tpV0ZCTEFZSGdBaUpZU3dOTVVFa1ZJZ2tpV0ZCTWdZQURJbGhQQWt4UVNSVWlDU0pZVUFJb3FrbUlBQkpHQWttSUFBeElURW1JQUFaRkFVeUwvNG1LQVFLTC80QVEvLy8vLy8vLy8vLy8vLy8vLy8vLy82d2lyNHYvZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBS0pMQVU4RFVFa1ZJZ2tpV0NpcVRnSlFTUlVpQ1NKWUtLcUpnQVFNOG0xN05ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBQU5ob0JTUldCd044QkVrUTJHZ0pKZ1FCWklndUJBZ2hMQVJVU1JJTUNBZ0JZU0RZYUF4VWtFa1EyR2dSSkZVa2tFa1EyR2dWSkZZSEFMUkpFU3dKUEJJajd2VTREUmdOTEEweUkrN05HQTBrVkpBNUVKSzlNU3dHclR3Sk1YTUJQQWlRT1JFNENxMHhRZ0FRVkgzeDFURkN3Z1FGRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
