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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper29_14ea3fee
{


    //
    // Helper contract 29 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper29Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper29Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class TranscriptLibGenerateTranscriptChunk4Return : AVMObjectType
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

                public static TranscriptLibGenerateTranscriptChunk4Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TranscriptLibGenerateTranscriptChunk4Return();
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
                    return Equals(obj as TranscriptLibGenerateTranscriptChunk4Return);
                }
                public bool Equals(TranscriptLibGenerateTranscriptChunk4Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TranscriptLibGenerateTranscriptChunk4Return left, TranscriptLibGenerateTranscriptChunk4Return right)
                {
                    return EqualityComparer<TranscriptLibGenerateTranscriptChunk4Return>.Default.Equals(left, right);
                }
                public static bool operator !=(TranscriptLibGenerateTranscriptChunk4Return left, TranscriptLibGenerateTranscriptChunk4Return right)
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
        public async Task<Structs.TranscriptLibGenerateTranscriptChunk4Return> TranscriptLibGenerateTranscriptChunk4(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 3, 228, 148 };
            var publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); publicInputsAbi.From(publicInputs);

            var result = await base.CallApp(new List<object> { abiHandle, proof, publicInputsAbi, publicInputsSize, previousChallenge, t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TranscriptLibGenerateTranscriptChunk4Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TranscriptLibGenerateTranscriptChunk4_Transactions(Structs.Proof proof, byte[][] publicInputs, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 publicInputsSize, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 previousChallenge, Structs.Transcript t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 3, 228, 148 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjI5IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAyOSBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRzFQcm9vZlBvaW50IjpbeyJuYW1lIjoieF8wIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ4XzEiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InlfMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoieV8xIiwidHlwZSI6InVpbnQ1MTIifV0sIlByb29mIjpbeyJuYW1lIjoiY2lyY3VpdFNpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c1NpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c09mZnNldCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidzEiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzIiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoidzQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoielBlcm0iLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZENvdW50cyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBSZWFkVGFncyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJsb29rdXBJbnZlcnNlcyIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJzdW1jaGVja1VuaXZhcmlhdGVzIiwidHlwZSI6InVpbnQ1MTJbOF1bMjhdIn0seyJuYW1lIjoic3VtY2hlY2tFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50NTEyWzQ0XSJ9LHsibmFtZSI6ImdlbWluaUZvbGRDb21tcyIsInR5cGUiOiJHMVByb29mUG9pbnRbMjddIn0seyJuYW1lIjoiZ2VtaW5pQUV2YWx1YXRpb25zIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoic2hwbG9ua1EiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoia3pnUXVvdGllbnQiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In1dLCJUcmFuc2NyaXB0IjpbeyJuYW1lIjoiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJldGFUd28iLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImV0YVRocmVlIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJiZXRhIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnYW1tYSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiYWxwaGFzIiwidHlwZSI6InVpbnQ1MTJbMjVdIn0seyJuYW1lIjoiZ2F0ZUNoYWxsZW5nZXMiLCJ0eXBlIjoidWludDUxMlsyOF0ifSx7Im5hbWUiOiJzdW1DaGVja1VDaGFsbGVuZ2VzIiwidHlwZSI6InVpbnQ1MTJbMjhdIn0seyJuYW1lIjoicmhvIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJnZW1pbmlSIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJzaHBsb25rTnUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InNocGxvbmtaIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNEZWx0YSIsInR5cGUiOiJ1aW50NTEyIn1dLCJUcmFuc2NyaXB0TGliR2VuZXJhdGVUcmFuc2NyaXB0Q2h1bms0UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVHJhbnNjcmlwdCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJUcmFuc2NyaXB0TGliLmdlbmVyYXRlVHJhbnNjcmlwdF9fY2h1bmtfNCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDUxMix1aW50NTEyLHVpbnQ1MTIsKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMiksKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSx1aW50NTEyWzhdWzI4XSx1aW50NTEyWzQ0XSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMilbMjddLHVpbnQ1MTJbMjhdLCh1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiUHJvb2YiLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNDaGFsbGVuZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMlsyNV0sdWludDUxMlsyOF0sdWludDUxMlsyOF0sdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlRyYW5zY3JpcHQiLCJuYW1lIjoidCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMiwodWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTJbMjVdLHVpbnQ1MTJbMjhdLHVpbnQ1MTJbMjhdLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiVHJhbnNjcmlwdExpYkdlbmVyYXRlVHJhbnNjcmlwdENodW5rNFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjg2LDMwMywzMjAsMzUyLDM3OSw0NDcsNDgxLDUxNSw1NDksNTk0LDYyOCw2NjIsNjk1LDc0MCw3NzQsODA4LDg0MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFByb29mIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFRyYW5zY3JpcHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzcsMjQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDUxMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwNl0sImVycm9yTWVzc2FnZSI6Im5vIGF2YWlsYWJsZSBzbG90cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNamt1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTXpJZ09DQXdJRFkwSURJMU5nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHSWdYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNVVjbUZ1YzJOeWFYQjBUR2xpTG5Od2JHbDBRMmhoYkd4bGJtZGxLR05vWVd4c1pXNW5aVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tWSEpoYm5OamNtbHdkRXhwWWk1emNHeHBkRU5vWVd4c1pXNW5aVG9LSUNBZ0lIQnliM1J2SURFZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyaHZibXN2WTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlM5RlkyUnpZVWh2Ym10V1pYSnBabWxsY2k1emIyd3VSV05rYzJGSWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqSTVMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncGZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYem9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ZtTURObE5EazBJQzh2SUcxbGRHaHZaQ0FpVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpWUnlZVzV6WTNKcGNIUmZYMk5vZFc1clh6UW9LSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxDaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1N3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBMQ2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWlrc0tIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwTENoMWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlLU3dvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NkV2x1ZERVeE1sczRYVnN5T0Ywc2RXbHVkRFV4TWxzME5GMHNLSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJcFd6STNYU3gxYVc1ME5URXlXekk0WFN3b2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBLU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTFNVElzZFdsdWREVXhNaXdvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRKYk1qVmRMSFZwYm5RMU1USmJNamhkTEhWcGJuUTFNVEpiTWpoZExIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaWtwS0hWcGJuUTFNVElzS0hWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeVd6STFYU3gxYVc1ME5URXlXekk0WFN4MWFXNTBOVEV5V3pJNFhTeDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lGOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMVJ5WVc1elkzSnBjSFJNYVdJdVoyVnVaWEpoZEdWVWNtRnVjMk55YVhCMFgxOWphSFZ1YTE4MFgzSnZkWFJsUURFS0lDQWdJR1Z5Y2dvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZWSEpoYm5OamNtbHdkRXhwWWk1blpXNWxjbUYwWlZSeVlXNXpZM0pwY0hSZlgyTm9kVzVyWHpSZmNtOTFkR1ZBTVRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlGUnlZVzV6WTNKcGNIUk1hV0l1WjJWdVpYSmhkR1ZVY21GdWMyTnlhWEIwWDE5amFIVnVhMTgwQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyaHZibXN2WTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlM5RlkyUnpZVWh2Ym10V1pYSnBabWxsY2k1emIyd3VSV05rYzJGSWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqSTVMbFJ5WVc1elkzSnBjSFJNYVdJdVoyVnVaWEpoZEdWVWNtRnVjMk55YVhCMFgxOWphSFZ1YTE4MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tWSEpoYm5OamNtbHdkRXhwWWk1blpXNWxjbUYwWlZSeVlXNXpZM0pwY0hSZlgyTm9kVzVyWHpRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5T0RZd09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVUhKdmIyWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrUGdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lITjNZWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTlRneU5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVkhKaGJuTmpjbWx3ZEFvZ0lDQWdZMkZzYkhOMVlpQmZjSFY1WVY5c2FXSXViV1Z0TG01bGQxOXpiRzkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTUNBMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ05qUWdOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxjR3hoWTJVeUlETXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0EyTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV5SURZMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM1J2Y21WekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFJ2WWdvS1ZISmhibk5qY21sd2RFeHBZaTVuWlc1bGNtRjBaVlJ5WVc1elkzSnBjSFJmWDJOb2RXNXJYelJmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0JpUEFvZ0lDQWdZbm9nVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpWUnlZVzV6WTNKcGNIUmZYMk5vZFc1clh6UmZZV1owWlhKZmQyaHBiR1ZBTkFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRGdLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJR0lyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkc5aFpITUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lITjBiM0psY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnVkhKaGJuTmpjbWx3ZEV4cFlpNW5aVzVsY21GMFpWUnlZVzV6WTNKcGNIUmZYMk5vZFc1clh6UmZkMmhwYkdWZmRHOXdRRElLQ2xSeVlXNXpZM0pwY0hSTWFXSXVaMlZ1WlhKaGRHVlVjbUZ1YzJOeWFYQjBYMTlqYUhWdWExODBYMkZtZEdWeVgzZG9hV3hsUURRNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREU1TWdvZ0lDQWdhVzUwWXlBMElDOHZJREkxTmdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURZMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURnS0lDQWdJR3h2WVdSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREEwQ2lBZ0lDQmlLd29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTFDaUFnSUNCaUt3b2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F4T1RJZ05qUUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dOZ29nSUNBZ1lpc0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTBORGdLSUNBZ0lHbHVkR01nTkNBdkx5QXlOVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EyTkFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBM0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBcUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQTJOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREE0Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREV5T0NBMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTVDaUFnSUNCaUt3b2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01Ua3lJRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdFS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQndkWE5vYVc1MElEY3dOQW9nSUNBZ2FXNTBZeUEwSUM4dklESTFOZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdJS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElEWTBDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR01LSUNBZ0lHSXJDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HUUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeE9USWdOalFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HVUtJQ0FnSUdJckNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjBiM0psY3dvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJVY21GdWMyTnlhWEIwVEdsaUxuTndiR2wwUTJoaGJHeGxibWRsQ2lBZ0lDQndiM0J1SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJVY21GdWMyTnlhWEIwVEdsaUxuTndiR2wwUTJoaGJHeGxibWRsQ2lBZ0lDQndiM0J1SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdYM0IxZVdGZmJHbGlMbTFsYlM1dVpYZGZjMnh2ZENncElDMCtJSFZwYm5RMk5Eb0tYM0IxZVdGZmJHbGlMbTFsYlM1dVpYZGZjMnh2ZERvS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWW1sMGJHVnVDaUFnSUNCc2IyRmtJREFLSUNBZ0lHbHVkR01nTkNBdkx5QXlOVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYzJWMFltbDBJQzh2SUc5dUlHVnljbTl5T2lCdWJ5QmhkbUZwYkdGaWJHVWdjMnh2ZEhNS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlNamt1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZJQWdBUUlBQ0pnRWdNR1JPY3VFeG9DbTRVRVcyZ1lGWVhTZ3o2RWg1dVhDUlErSDFrL0FBQUFHQUlILy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vTlFCQ0FGaUtBUUtMLzRBUS8vLy8vLy8vLy8vLy8vLy8vLy8vLzZ3aXI0di9nQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFLSkxBVThEVUVrVklna2lXQ2lxVGdKUVNSVWlDU0pZS0txSmdBVHZBK1NVTmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FBTmhvQlJ3SVZnY0RmQVJKRU5ob0NTU1JaSWd1QkFnaExBUlVTUklFQ0pGaE1OaG9EU1U0Q0ZTVVNSRFlhQkJVbEVrUTJHZ1ZKVGdJVmdjQXRFa1NJQW50SlRnSWlyMGxPQTBzQ1Z3QkFTd0ZNVUVrVklna2lXSUFBVEZ3QVN3TlhRRUJMQWt4UVNSVWlDU0pZWENCUEExZUFRRThDVEZCSkZTSUpJbGhjUUQ4a0ZrbExCYVJCQURvanIwbExBa2xPQWxCSkZTTUpXMHNJVENJTElsaUJBeFpMQXFCUEEweFFTUlVqQ1Z0TEJVbE9BajVNSWd0UEExMC9nQUVCb0VVQlF2Ky9Td1pKZ2NBQklRUllTVmNBUUVzRVNVNERURkJKRlNJSklsZ2pyNEVERmtzS1NVNEVvRXNCVEZCSkZTTUpXMHNKU1U0SVBrd2lDMDhEWFVzRFYwQkFTd1ZNVUVrVklna2lXRXNEZ0FFRW9Fc0RURkJKRlNNSld5SUxURjFMQTFlQVFFc0ZURkJKRlNJSklsaExBNEFCQmFCTEEweFFTUlVqQ1ZzaUMweGRUd05Yd0VCTEJFeFFTUlVpQ1NKWVN3T0FBUWFnU3dOTVVFa1ZJd2xiSWd0TVhVc0VnY0FESVFSWVNWY0FRRXNGVEZCSkZTSUpJbGhMQklBQkI2QkxCRXhRU1JVakNWc2lDMDhEVEU4Q1hVc0JWMEJBU3dWTVVFa1ZJZ2tpV0VzRWdBRUlvRXNFVEZCSkZTTUpXeUlMVEYxTEFWZUFRRXNGVEZCSkZTSUpJbGhMQklBQkNhQkxCRXhRU1JVakNWc2lDMHhkVEZmQVFFc0VURkJKRlNJSklsaExBNEFCQ3FCTEEweFFTUlVqQ1ZzaUMweGRUd1NCd0FVaEJGaEpWd0JBU3dWTVVFa1ZJZ2tpV0VzRWdBRUxvRXNFVEZCSkZTTUpXeUlMVHdOTVR3SmRTd0ZYUUVCTEJVeFFTUlVpQ1NKWVN3U0FBUXlnU3dSTVVFa1ZJd2xiSWd0TVhVc0JWNEJBU3dWTVVFa1ZJZ2tpV0VzRWdBRU5vRXNFVEZCSkZTTUpXeUlMVEYxTVY4QkFTd1JNVUVrVklna2lXRThEZ0FFT29FOERURkJKRlNNSld5SUxURjFQQWtzQlB3SW9xa21JL1AxR0FsQkpGU0lKSWxnQ0tLcEppUHp0UmdKSkZTVU9SQ1d2cTBzRVVJQUVGUjk4ZFV4UXNJRUJRelFBa3pRQUlRUkxBZ2trVkRVQWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
