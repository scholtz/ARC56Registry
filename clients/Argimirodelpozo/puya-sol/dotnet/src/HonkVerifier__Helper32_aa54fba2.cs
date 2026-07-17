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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier__Helper32_aa54fba2
{


    //
    // Helper contract 32 for HonkVerifier
    //
    public class HonkVerifier__Helper32Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifier__Helper32Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class G1ProofPoint : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 X0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 X1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Y0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Y1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vX0.From(X0);
                    ret.AddRange(vX0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vX1.From(X1);
                    ret.AddRange(vX1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vY0.From(Y0);
                    ret.AddRange(vY0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
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
                    var vX0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vX0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X0 = vX0;
                    var vX1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vX1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X1 = vX1;
                    var vY0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vY0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Y0 = vY0;
                    var vY1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
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

            public class ZkProof : AVMObjectType
            {
                public Structs.G1ProofPoint W1 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W2 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W3 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint W4 { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupReadCounts { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupReadTags { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint LookupInverses { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint ZPerm { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint[] LibraCommitments { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LibraSum { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[][] SumcheckUnivariates { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] SumcheckEvaluations { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LibraEvaluation { get; set; }

                public Structs.G1ProofPoint GeminiMaskingPoly { get; set; } = new Structs.G1ProofPoint();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 GeminiMaskingEval { get; set; }

                public Structs.G1ProofPoint[] GeminiFoldComms { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] GeminiAEvaluations { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] LibraPolyEvals { get; set; }

                public Structs.G1ProofPoint ShplonkQ { get; set; } = new Structs.G1ProofPoint();

                public Structs.G1ProofPoint KzgQuotient { get; set; } = new Structs.G1ProofPoint();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(W1.ToByteArray());
                    ret.AddRange(W2.ToByteArray());
                    ret.AddRange(W3.ToByteArray());
                    ret.AddRange(W4.ToByteArray());
                    ret.AddRange(LookupReadCounts.ToByteArray());
                    ret.AddRange(LookupReadTags.ToByteArray());
                    ret.AddRange(LookupInverses.ToByteArray());
                    ret.AddRange(ZPerm.ToByteArray());
                    var arrLibraCommitments = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 3 };
                    arrLibraCommitments.Value = (LibraCommitments ?? Array.Empty<Structs.G1ProofPoint>()).ToList();
                    ret.AddRange(arrLibraCommitments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLibraSum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLibraSum.From(LibraSum);
                    ret.AddRange(vLibraSum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckUnivariates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[9][28]");
                    vSumcheckUnivariates.From(SumcheckUnivariates);
                    ret.AddRange(vSumcheckUnivariates.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[40]");
                    vSumcheckEvaluations.From(SumcheckEvaluations);
                    ret.AddRange(vSumcheckEvaluations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLibraEvaluation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLibraEvaluation.From(LibraEvaluation);
                    ret.AddRange(vLibraEvaluation.Encode());
                    ret.AddRange(GeminiMaskingPoly.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiMaskingEval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vGeminiMaskingEval.From(GeminiMaskingEval);
                    ret.AddRange(vGeminiMaskingEval.Encode());
                    var arrGeminiFoldComms = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 27 };
                    arrGeminiFoldComms.Value = (GeminiFoldComms ?? Array.Empty<Structs.G1ProofPoint>()).ToList();
                    ret.AddRange(arrGeminiFoldComms.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiAEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[28]");
                    vGeminiAEvaluations.From(GeminiAEvaluations);
                    ret.AddRange(vGeminiAEvaluations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLibraPolyEvals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[4]");
                    vLibraPolyEvals.From(LibraPolyEvals);
                    ret.AddRange(vLibraPolyEvals.Encode());
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

                public static ZkProof Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ZkProof();
                    uint count = 0;
                    ret.W1 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW1 = ret.W1.ToByteArray().Length; for (int i = 0; i < consumedW1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W2 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW2 = ret.W2.ToByteArray().Length; for (int i = 0; i < consumedW2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W3 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW3 = ret.W3.ToByteArray().Length; for (int i = 0; i < consumedW3 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.W4 = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedW4 = ret.W4.ToByteArray().Length; for (int i = 0; i < consumedW4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupReadCounts = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupReadCounts = ret.LookupReadCounts.ToByteArray().Length; for (int i = 0; i < consumedLookupReadCounts && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupReadTags = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupReadTags = ret.LookupReadTags.ToByteArray().Length; for (int i = 0; i < consumedLookupReadTags && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LookupInverses = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedLookupInverses = ret.LookupInverses.ToByteArray().Length; for (int i = 0; i < consumedLookupInverses && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.ZPerm = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedZPerm = ret.ZPerm.ToByteArray().Length; for (int i = 0; i < consumedZPerm && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var arrLibraCommitments = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 3 };
                    { var consumedLibraCommitments = (int)arrLibraCommitments.Decode(queue.ToArray()); for (int i = 0; i < consumedLibraCommitments && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LibraCommitments = arrLibraCommitments.Value.ToArray();
                    var vLibraSum = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLibraSum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LibraSum = vLibraSum;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckUnivariates = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[9][28]");
                    count = vSumcheckUnivariates.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSumcheckUnivariates = vSumcheckUnivariates.ToValue();
                    if (valueSumcheckUnivariates is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[][] vSumcheckUnivariatesValue) { ret.SumcheckUnivariates = vSumcheckUnivariatesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSumcheckEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[40]");
                    count = vSumcheckEvaluations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSumcheckEvaluations = vSumcheckEvaluations.ToValue();
                    if (valueSumcheckEvaluations is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vSumcheckEvaluationsValue) { ret.SumcheckEvaluations = vSumcheckEvaluationsValue; }
                    var vLibraEvaluation = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLibraEvaluation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LibraEvaluation = vLibraEvaluation;
                    ret.GeminiMaskingPoly = Structs.G1ProofPoint.Parse(queue.ToArray());
                    { var consumedGeminiMaskingPoly = ret.GeminiMaskingPoly.ToByteArray().Length; for (int i = 0; i < consumedGeminiMaskingPoly && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var vGeminiMaskingEval = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vGeminiMaskingEval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.GeminiMaskingEval = vGeminiMaskingEval;
                    var arrGeminiFoldComms = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.G1ProofPoint>(x => Structs.G1ProofPoint.Parse(x)) { IsFixedLength = true, FixedLength = 27 };
                    { var consumedGeminiFoldComms = (int)arrGeminiFoldComms.Decode(queue.ToArray()); for (int i = 0; i < consumedGeminiFoldComms && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.GeminiFoldComms = arrGeminiFoldComms.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGeminiAEvaluations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[28]");
                    count = vGeminiAEvaluations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGeminiAEvaluations = vGeminiAEvaluations.ToValue();
                    if (valueGeminiAEvaluations is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vGeminiAEvaluationsValue) { ret.GeminiAEvaluations = vGeminiAEvaluationsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLibraPolyEvals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[4]");
                    count = vLibraPolyEvals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLibraPolyEvals = vLibraPolyEvals.ToValue();
                    if (valueLibraPolyEvals is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vLibraPolyEvalsValue) { ret.LibraPolyEvals = vLibraPolyEvalsValue; }
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
                    return Equals(obj as ZkProof);
                }
                public bool Equals(ZkProof? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ZkProof left, ZkProof right)
                {
                    return EqualityComparer<ZkProof>.Default.Equals(left, right);
                }
                public static bool operator !=(ZkProof left, ZkProof right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proof"> </param>
        /// <param name="boundary"> </param>
        public async Task<Structs.ZkProof> ZkTranscriptLibLoadProofChunk1(byte[] proof, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 boundary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 14, 157, 127 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);

            var result = await base.SimApp(new List<object> { abiHandle, proofAbi, boundary }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ZkProof.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ZkTranscriptLibLoadProofChunk1_Transactions(byte[] proof, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 boundary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 14, 157, 127 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofAbi, boundary }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyX19IZWxwZXIzMiIsImRlc2MiOiJIZWxwZXIgY29udHJhY3QgMzIgZm9yIEhvbmtWZXJpZmllciIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHMVByb29mUG9pbnQiOlt7Im5hbWUiOiJ4XzAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InhfMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoieV8wIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJ5XzEiLCJ0eXBlIjoidWludDI1NiJ9XSwiWktQcm9vZiI6W3sibmFtZSI6IncxIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6IncyIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6InczIiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Inc0IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6Imxvb2t1cFJlYWRDb3VudHMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwUmVhZFRhZ3MiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibG9va3VwSW52ZXJzZXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoielBlcm0iLCJ0eXBlIjoiRzFQcm9vZlBvaW50In0seyJuYW1lIjoibGlicmFDb21taXRtZW50cyIsInR5cGUiOiJHMVByb29mUG9pbnRbM10ifSx7Im5hbWUiOiJsaWJyYVN1bSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoic3VtY2hlY2tVbml2YXJpYXRlcyIsInR5cGUiOiJ1aW50MjU2WzldWzI4XSJ9LHsibmFtZSI6InN1bWNoZWNrRXZhbHVhdGlvbnMiLCJ0eXBlIjoidWludDI1Nls0MF0ifSx7Im5hbWUiOiJsaWJyYUV2YWx1YXRpb24iLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImdlbWluaU1hc2tpbmdQb2x5IiwidHlwZSI6IkcxUHJvb2ZQb2ludCJ9LHsibmFtZSI6ImdlbWluaU1hc2tpbmdFdmFsIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJnZW1pbmlGb2xkQ29tbXMiLCJ0eXBlIjoiRzFQcm9vZlBvaW50WzI3XSJ9LHsibmFtZSI6ImdlbWluaUFFdmFsdWF0aW9ucyIsInR5cGUiOiJ1aW50MjU2WzI4XSJ9LHsibmFtZSI6ImxpYnJhUG9seUV2YWxzIiwidHlwZSI6InVpbnQyNTZbNF0ifSx7Im5hbWUiOiJzaHBsb25rUSIsInR5cGUiOiJHMVByb29mUG9pbnQifSx7Im5hbWUiOiJremdRdW90aWVudCIsInR5cGUiOiJHMVByb29mUG9pbnQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiWktUcmFuc2NyaXB0TGliLmxvYWRQcm9vZl9fY2h1bmtfMSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvdW5kYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiksKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSwodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiksKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSwodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NiksKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KVszXSx1aW50MjU2LHVpbnQyNTZbOV1bMjhdLHVpbnQyNTZbNDBdLHVpbnQyNTYsKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpLHVpbnQyNTYsKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpWzI3XSx1aW50MjU2WzI4XSx1aW50MjU2WzRdLCh1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2KSwodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikpIiwic3RydWN0IjoiWktQcm9vZiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk2OV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDNdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzksNDcwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTksOTU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3LDk2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM3LDk0Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwLDEwNiwxMTksMTMyLDM2OSw0NjBdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pNeUxsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklETXlJREV5T0NBNElEZzVOaUF6T0RRZ01UUTBNeklnTVRVek1qZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltOGlJQ0p3SWlBaWN5SWdNSGd3TVFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xrWnlUR2xpTG1aeWIyMUNlWFJsY3pNeUtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2taeVRHbGlMbVp5YjIxQ2VYUmxjek15T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVpZVhSbGMxUnZSbklvY0hKdmIyWlRaV04wYVc5dU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtSjVkR1Z6Vkc5R2Nqb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFWnlUR2xpTG1aeWIyMUNlWFJsY3pNeUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVpZVhSbGMxUnZSekZRY205dlpsQnZhVzUwS0hCeWIyOW1VMlZqZEdsdmJqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGllWFJsYzFSdlJ6RlFjbTl2WmxCdmFXNTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE4xWW5OMGNtbHVaeUF3SURNeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JRE15SURZMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JRFkwSURrMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JRGsySURFeU9Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmlmQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEl6TWk1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFEZ0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHTmtNR1U1WkRkbUlEQjRZVGsyWldZNU9Ea2dMeThnYldWMGFHOWtJQ0phUzFSeVlXNXpZM0pwY0hSTWFXSXViRzloWkZCeWIyOW1YMTlqYUhWdWExOHhLR0o1ZEdWYlhTeDFhVzUwTWpVMktTZ29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTmlrc0tIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwTENoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU3dvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa3NLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1N3b2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtzS0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBMQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktWc3pYU3gxYVc1ME1qVTJMSFZwYm5ReU5UWmJPVjFiTWpoZExIVnBiblF5TlRaYk5EQmRMSFZwYm5ReU5UWXNLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcExIVnBiblF5TlRZc0tIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwV3pJM1hTeDFhVzUwTWpVMld6STRYU3gxYVc1ME1qVTJXelJkTENoMWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLU3dvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa3BJaXdnYldWMGFHOWtJQ0pmWDJsdWFYUmZYeWgxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnV2t0VWNtRnVjMk55YVhCMFRHbGlMbXh2WVdSUWNtOXZabDlmWTJoMWJtdGZNU0JmWDJsdWFYUmZYd29nSUNBZ1pYSnlDZ3BmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWDE5ZlgySmhjbVZmWTNKbFlYUmxYMTlBT0RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEl6TWk1YVMxUnlZVzV6WTNKcGNIUk1hV0l1Ykc5aFpGQnliMjltWDE5amFIVnVhMTh4VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1drdFVjbUZ1YzJOeWFYQjBUR2xpTG14dllXUlFjbTl2Wmw5ZlkyaDFibXRmTVRvS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dXa3RVY21GdWMyTnlhWEIwVEdsaUxteHZZV1JRY205dlpsOWZZMmgxYm10Zk1WOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlCYVMxUnlZVzV6WTNKcGNIUk1hV0l1Ykc5aFpGQnliMjltWDE5amFIVnVhMTh4WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS1drdFVjbUZ1YzJOeWFYQjBUR2xpTG14dllXUlFjbTl2Wmw5ZlkyaDFibXRmTVY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQm5iRzloWkNBeElEQUtJQ0FnSUdkc2IyRmtJREVnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JuYkc5aFpDQXlJREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaMnh2WVdRZ01pQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1luVnllU0EwQ2dwYVMxUnlZVzV6WTNKcGNIUk1hV0l1Ykc5aFpGQnliMjltWDE5amFIVnVhMTh4WDNkb2FXeGxYM1J2Y0VBM09nb2dJQ0FnY0hWemFHbHVkQ0F5T0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURRS0lDQWdJR0krQ2lBZ0lDQmllaUJhUzFSeVlXNXpZM0pwY0hSTWFXSXViRzloWkZCeWIyOW1YMTlqYUhWdWExOHhYM2RvYVd4bFgzUnZjRUF4TUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0lyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHTmhiR3h6ZFdJZ1lubDBaWE5VYjBaeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFl5QTFJQzh2SURFME5ETXlDaUFnSUNCcGJuUmpYek1nTHk4Z09EazJDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1luVnllU0EwQ2lBZ0lDQmlJRnBMVkhKaGJuTmpjbWx3ZEV4cFlpNXNiMkZrVUhKdmIyWmZYMk5vZFc1clh6RmZkMmhwYkdWZmRHOXdRRGNLQ2xwTFZISmhibk5qY21sd2RFeHBZaTVzYjJGa1VISnZiMlpmWDJOb2RXNXJYekZmZDJocGJHVmZkRzl3UURFd09nb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZajRLSUNBZ0lHSjZJRnBMVkhKaGJuTmpjbWx3ZEV4cFlpNXNiMkZrVUhKdmIyWmZYMk5vZFc1clh6RmZZV1owWlhKZmQyaHBiR1ZBTVRJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpZV3hzYzNWaUlHSjVkR1Z6Vkc5R2Nnb2dJQ0FnWkdsbklEUUtJQ0FnSUdsdWRHTWdOaUF2THlBeE5UTXlPQW9nSUNBZ2FXNTBZMTh4SUM4dklERXlPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW53S0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdZaUJhUzFSeVlXNXpZM0pwY0hSTWFXSXViRzloWkZCeWIyOW1YMTlqYUhWdWExOHhYM2RvYVd4bFgzUnZjRUF4TUFvS1drdFVjbUZ1YzJOeWFYQjBUR2xpTG14dllXUlFjbTl2Wmw5ZlkyaDFibXRmTVY5aFpuUmxjbDkzYUdsc1pVQXhNam9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTlNBdkx5QXhORFF6TWdvZ0lDQWdhVzUwWTE4eklDOHZJRGc1TmdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwY3lBeE1EazNOaUF6TkRVMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UQTVORFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREV3T0RFMkNpQWdJQ0JwYm5Salh6RWdMeThnTVRJNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ01UVTFPRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhNamdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0F4TURJMENpQWdJQ0JwYm5SaklEUWdMeThnTXpnMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhwYm5RZ01UQTNPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEWWdMeThnTVRVek1qZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeE1qZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdjSFZ6YUdsdWRDQXhOREE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnY0hWemFHbHVkQ0EzTmpnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TWpnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lIQjFjMmhwYm5RZ05URXlDaUFnSUNCcGJuUmpYekVnTHk4Z01USTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0J3ZFhOb2FXNTBJRFkwTUFvZ0lDQWdhVzUwWTE4eElDOHZJREV5T0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVRJNENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF4TXdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWTJGc2JITjFZaUJpZVhSbGMxUnZSekZRY205dlpsQnZhVzUwQ2lBZ0lDQmthV2NnTVRnS0lDQWdJSEIxYzJocGJuUnpJRGsxTURRZ01USTRNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnY0hWemFHbHVkSE1nTVRRME1DQTRNRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESXdDaUFnSUNCbGVIUnlZV04wSURBZ01USTRDaUFnSUNCa2FXY2dNakVLSUNBZ0lHVjRkSEpoWTNRZ01USTRJREV5T0FvZ0lDQWdaR2xuSURJeUNpQWdJQ0J3ZFhOb2FXNTBJREkxTmdvZ0lDQWdhVzUwWTE4eElDOHZJREV5T0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXlNd29nSUNBZ2FXNTBZeUEwSUM4dklETTROQW9nSUNBZ2FXNTBZMTh4SUM4dklERXlPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNalFLSUNBZ0lHbHVkR05mTXlBdkx5QTRPVFlLSUNBZ0lHbHVkR05mTVNBdkx5QXhNamdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01URUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOU0F2THlBeE5EUXpNZ29nSUNBZ2FXNTBZMTh6SUM4dklEZzVOZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBjeUF4TURrM05pQXpORFUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRBNU5EUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElERXdPREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEk0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdJckNpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyRnNiSE4xWWlCaWVYUmxjMVJ2UnpGUWNtOXZabEJ2YVc1MENpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0F4TURJMENpQWdJQ0JwYm5SaklEUWdMeThnTXpnMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhwYm5RZ01UQTNPRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBM0NpQWdJQ0JwYm5SaklEWWdMeThnTVRVek1qZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeE1qZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnT0FvZ0lDQWdjSFZ6YUdsdWRDQXhOREE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ09Rb2dJQ0FnY0hWemFHbHVkQ0EzTmpnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4TWpnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVEFLSUNBZ0lIQjFjMmhwYm5RZ05URXlDaUFnSUNCcGJuUmpYekVnTHk4Z01USTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0J3ZFhOb2FXNTBJRFkwTUFvZ0lDQWdhVzUwWTE4eElDOHZJREV5T0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2NIVnphR2x1ZENBeE5UUTFOZ29nSUNBZ2FXNTBZMTh4SUM4dklERXlPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE13b2dJQ0FnY0hWemFHbHVkSE1nT1RVd05DQXhNamd3Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERTBDaUFnSUNCd2RYTm9hVzUwY3lBeE5EUXdJRGd3TmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHVjRkSEpoWTNRZ01DQXhNamdLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaWGgwY21GamRDQXhNamdnTVRJNENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUhCMWMyaHBiblFnTWpVMkNpQWdJQ0JwYm5Salh6RWdMeThnTVRJNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREU0Q2lBZ0lDQnBiblJqSURRZ0x5OGdNemcwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEk0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF4T1FvZ0lDQWdhVzUwWTE4eklDOHZJRGc1TmdvZ0lDQWdhVzUwWTE4eElDOHZJREV5T0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5eWRYTjBMV2h2Ym1zdlkyOXVkSEpoWTNSekwzcHJWbVZ5YVdacFpYSXVjMjlzTGtodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU16SXVYMTlwYm1sMFgxOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BmWDJsdWFYUmZYem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nWVd4eVpXRmtlU0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjak15TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUhJSUFCQ0lBSGdBUGdjT0IzSmdRQmJ3RndBWE1CQVVJQWQ0b0JBWXYvZ0NBd1pFNXk0VEdnS2JoUVJiYUJnVmhkS0RQb1NIbTVjSkZENGZXVDhBQUFBYXFKaWdFQmkvK0kvOCtKaWdFQmkvOVJBQ0JKRlNJT1JDS3ZURXNCcTR2L1VTQkFTUlVpRGtSTEFxdUwvMUZBWUVrVklnNUVTd09yaS85UllJQkpGU0lPUkU4RXEwOERUd05RVHdKUVRGQ0pNUnRCQUIweEdSUkVNUmhFZ2dJRXpRNmRmd1NwYnZtSk5ob0FqZ0lBQ1FMdUFERVpGREVZRkJCRGdRQkhBallhQVVtQkFGbUJBZ2hMQVJVU1JGY0NBRFlhQWtrVkloSkVLR1JCQURBeUJJRUNEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFYTVJhQkFRazRHQ2xrRWtReEZvRUJDVGthQUNwa0VrUTZBUUE2QVFGUU9nSUFVRG9DQVZCRkE0RUFGa2xGQmtVRWdSd1dTd1NsUVFCU0pLOUpTd0pKVGdKUVNSVWtDVnNpRms4Q29FbEZCRXNDVEZCSkZTUUpXMHNFVGdKU2lQN3NTd1FoQlNWWVR3SkxCa2xPQkZCSkZTUUpXMHNDRlNJT1JDS3ZUd09yVENJTFRGMUlLNkJGQkVML3BZRUVGa3NGcFVFQVVpU3ZTVXNDU1U0Q1VFa1ZKQWxiSWhaUEFxQkpSUVJMQWt4UVNSVWtDVnRMQkU0Q1VvaitrVXNFSVFZaldFOENTd2RKVGdSUVNSVWtDVnRMQWhVaURrUWlyMDhEcTB3aUMweGRTQ3VnUlFWQy82VkxBa2toQlNWWVN3R0RBdUJWZ0J0WVN3S0J3RlVpV0VzRGdjQlVJMWhMQklIZ2VTTllTd1dCZ0FnaEJGaExCb0dnVkNKWVN3Y2hCaU5ZU3dpQmdBc2lXRXNKZ1lBR0kxaExDb0dBQkNOWVN3dUJnQVVqV0NTdlNVc1BTVTRDVUVrVkpBbGJJeFpQQWtzQm9Fc0RTd0ZRU1JVa0NWdExFMGxPRFU4RVN3SlNpUDN0U3hLREFxQktnQXBZU3hPREFxQUxnRDlZU3hSWEFJQkxGVmVBZ0VzV2dZQUNJMWhMRnlFRUkxaFBHQ1VqV0U4RVR3UlFUd05RVHdKUVR3cFFUd2xRVHdsUVRGQlBDMUJQQ0ZCTVVFeFFUd2RRVHdsUVR3bFFUd2xRVHdsUVR3WlFURkJQQmxCSklRVWxXRXNCZ3dMZ1ZZQWJXRXNDZ2NCVklsaExBNEhBVkNOWVR3WlBCNkJQQjB4UVNSVWtDVnRQQjA4SFR3SlNpUDFVU3dXQmdBZ2hCRmhMQm9HZ1ZDSllTd2NoQmlOWVN3aUJnQXNpV0VzSmdZQUdJMWhMQ29HQUJDTllTd3VCZ0FValdFc01nZUI0STFoTERZTUNvRXFBQ2xoTERvTUNvQXVBUDFoTEQxY0FnRXNRVjRDQVN4R0JnQUlqV0VzU0lRUWpXRThUSlNOWVR3UlBCRkJQQTFCUEFsQlBCbEJQQlZCUEJWQk1VRThIVUU4RVVFeFFURkJQQTFCUEJGQlBCRkJQQkZCUEJGQlBBbEJNVUV4UWdBUVZIM3gxVEZDd2dRRkROaG9CU1JVa0VrUVhOaG9DU1JVa0VrUVhOaG9EU1lFQVdZRUNDRXNCRlJKRVZ3SUFLR1FVUkNoUEEyY3BUd0puS2t4bmdRRkQiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
