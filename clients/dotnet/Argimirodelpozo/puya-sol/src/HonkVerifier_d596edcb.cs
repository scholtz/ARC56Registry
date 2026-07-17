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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier_d596edcb
{


    //
    // Orchestrator (entrypoint) for HonkVerifier — receives calls, dispatches to helper chain via group txns
    //
    public class HonkVerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class G1Point : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 X { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
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
                    var vX = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X = vX;
                    var vY = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
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

            public class VerificationKey : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 CircuitSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LogCircuitSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 PublicInputsSize { get; set; }

                public Structs.G1Point Qm { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qc { get; set; } = new Structs.G1Point();

                public Structs.G1Point Ql { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qr { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qo { get; set; } = new Structs.G1Point();

                public Structs.G1Point Q4 { get; set; } = new Structs.G1Point();

                public Structs.G1Point QLookup { get; set; } = new Structs.G1Point();

                public Structs.G1Point QArith { get; set; } = new Structs.G1Point();

                public Structs.G1Point QDeltaRange { get; set; } = new Structs.G1Point();

                public Structs.G1Point QAux { get; set; } = new Structs.G1Point();

                public Structs.G1Point QElliptic { get; set; } = new Structs.G1Point();

                public Structs.G1Point QPoseidon2External { get; set; } = new Structs.G1Point();

                public Structs.G1Point QPoseidon2Internal { get; set; } = new Structs.G1Point();

                public Structs.G1Point S1 { get; set; } = new Structs.G1Point();

                public Structs.G1Point S2 { get; set; } = new Structs.G1Point();

                public Structs.G1Point S3 { get; set; } = new Structs.G1Point();

                public Structs.G1Point S4 { get; set; } = new Structs.G1Point();

                public Structs.G1Point Id1 { get; set; } = new Structs.G1Point();

                public Structs.G1Point Id2 { get; set; } = new Structs.G1Point();

                public Structs.G1Point Id3 { get; set; } = new Structs.G1Point();

                public Structs.G1Point Id4 { get; set; } = new Structs.G1Point();

                public Structs.G1Point T1 { get; set; } = new Structs.G1Point();

                public Structs.G1Point T2 { get; set; } = new Structs.G1Point();

                public Structs.G1Point T3 { get; set; } = new Structs.G1Point();

                public Structs.G1Point T4 { get; set; } = new Structs.G1Point();

                public Structs.G1Point LagrangeFirst { get; set; } = new Structs.G1Point();

                public Structs.G1Point LagrangeLast { get; set; } = new Structs.G1Point();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vCircuitSize.From(CircuitSize);
                    ret.AddRange(vCircuitSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLogCircuitSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLogCircuitSize.From(LogCircuitSize);
                    ret.AddRange(vLogCircuitSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicInputsSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vPublicInputsSize.From(PublicInputsSize);
                    ret.AddRange(vPublicInputsSize.Encode());
                    ret.AddRange(Qm.ToByteArray());
                    ret.AddRange(Qc.ToByteArray());
                    ret.AddRange(Ql.ToByteArray());
                    ret.AddRange(Qr.ToByteArray());
                    ret.AddRange(Qo.ToByteArray());
                    ret.AddRange(Q4.ToByteArray());
                    ret.AddRange(QLookup.ToByteArray());
                    ret.AddRange(QArith.ToByteArray());
                    ret.AddRange(QDeltaRange.ToByteArray());
                    ret.AddRange(QAux.ToByteArray());
                    ret.AddRange(QElliptic.ToByteArray());
                    ret.AddRange(QPoseidon2External.ToByteArray());
                    ret.AddRange(QPoseidon2Internal.ToByteArray());
                    ret.AddRange(S1.ToByteArray());
                    ret.AddRange(S2.ToByteArray());
                    ret.AddRange(S3.ToByteArray());
                    ret.AddRange(S4.ToByteArray());
                    ret.AddRange(Id1.ToByteArray());
                    ret.AddRange(Id2.ToByteArray());
                    ret.AddRange(Id3.ToByteArray());
                    ret.AddRange(Id4.ToByteArray());
                    ret.AddRange(T1.ToByteArray());
                    ret.AddRange(T2.ToByteArray());
                    ret.AddRange(T3.ToByteArray());
                    ret.AddRange(T4.ToByteArray());
                    ret.AddRange(LagrangeFirst.ToByteArray());
                    ret.AddRange(LagrangeLast.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerificationKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VerificationKey();
                    uint count = 0;
                    var vCircuitSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vCircuitSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.CircuitSize = vCircuitSize;
                    var vLogCircuitSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLogCircuitSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LogCircuitSize = vLogCircuitSize;
                    var vPublicInputsSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vPublicInputsSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.PublicInputsSize = vPublicInputsSize;
                    ret.Qm = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQm = ret.Qm.ToByteArray().Length; for (int i = 0; i < consumedQm && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Qc = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQc = ret.Qc.ToByteArray().Length; for (int i = 0; i < consumedQc && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Ql = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQl = ret.Ql.ToByteArray().Length; for (int i = 0; i < consumedQl && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Qr = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQr = ret.Qr.ToByteArray().Length; for (int i = 0; i < consumedQr && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Qo = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQo = ret.Qo.ToByteArray().Length; for (int i = 0; i < consumedQo && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Q4 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQ4 = ret.Q4.ToByteArray().Length; for (int i = 0; i < consumedQ4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QLookup = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQLookup = ret.QLookup.ToByteArray().Length; for (int i = 0; i < consumedQLookup && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QArith = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQArith = ret.QArith.ToByteArray().Length; for (int i = 0; i < consumedQArith && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QDeltaRange = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQDeltaRange = ret.QDeltaRange.ToByteArray().Length; for (int i = 0; i < consumedQDeltaRange && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QAux = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQAux = ret.QAux.ToByteArray().Length; for (int i = 0; i < consumedQAux && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QElliptic = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQElliptic = ret.QElliptic.ToByteArray().Length; for (int i = 0; i < consumedQElliptic && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QPoseidon2External = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQPoseidon2External = ret.QPoseidon2External.ToByteArray().Length; for (int i = 0; i < consumedQPoseidon2External && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QPoseidon2Internal = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQPoseidon2Internal = ret.QPoseidon2Internal.ToByteArray().Length; for (int i = 0; i < consumedQPoseidon2Internal && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.S1 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedS1 = ret.S1.ToByteArray().Length; for (int i = 0; i < consumedS1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.S2 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedS2 = ret.S2.ToByteArray().Length; for (int i = 0; i < consumedS2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.S3 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedS3 = ret.S3.ToByteArray().Length; for (int i = 0; i < consumedS3 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.S4 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedS4 = ret.S4.ToByteArray().Length; for (int i = 0; i < consumedS4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Id1 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedId1 = ret.Id1.ToByteArray().Length; for (int i = 0; i < consumedId1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Id2 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedId2 = ret.Id2.ToByteArray().Length; for (int i = 0; i < consumedId2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Id3 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedId3 = ret.Id3.ToByteArray().Length; for (int i = 0; i < consumedId3 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Id4 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedId4 = ret.Id4.ToByteArray().Length; for (int i = 0; i < consumedId4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.T1 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedT1 = ret.T1.ToByteArray().Length; for (int i = 0; i < consumedT1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.T2 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedT2 = ret.T2.ToByteArray().Length; for (int i = 0; i < consumedT2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.T3 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedT3 = ret.T3.ToByteArray().Length; for (int i = 0; i < consumedT3 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.T4 = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedT4 = ret.T4.ToByteArray().Length; for (int i = 0; i < consumedT4 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LagrangeFirst = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedLagrangeFirst = ret.LagrangeFirst.ToByteArray().Length; for (int i = 0; i < consumedLagrangeFirst && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.LagrangeLast = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedLagrangeLast = ret.LagrangeLast.ToByteArray().Length; for (int i = 0; i < consumedLagrangeLast && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerificationKey);
                }
                public bool Equals(VerificationKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerificationKey left, VerificationKey right)
                {
                    return EqualityComparer<VerificationKey>.Default.Equals(left, right);
                }
                public static bool operator !=(VerificationKey left, VerificationKey right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.VerificationKey> FinishLoadVerificationKey(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 210, 231, 28 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerificationKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FinishLoadVerificationKey_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 210, 231, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proof"> </param>
        /// <param name="__arc4_publicInputs"> </param>
        public async Task<bool> Verify(byte[] proof, byte[][] __arc4_publicInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 147, 224, 239 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var __arc4_publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_publicInputsAbi.From(__arc4_publicInputs);

            var result = await base.SimApp(new List<object> { abiHandle, proofAbi, __arc4_publicInputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Verify_Transactions(byte[] proof, byte[][] __arc4_publicInputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 147, 224, 239 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var __arc4_publicInputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_publicInputsAbi.From(__arc4_publicInputs);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofAbi, __arc4_publicInputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> FinishVerify(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 124, 128, 253 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinishVerify_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 124, 128, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FinishComputePublicInputDelta(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 180, 56, 42 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FinishComputePublicInputDelta_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 180, 56, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> FinishVerifySumcheck(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 116, 185, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinishVerifySumcheck_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 116, 185, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FinishComputeNextTargetSum(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 3, 28, 1 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FinishComputeNextTargetSum_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 3, 28, 1 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> FinishVerifyShplemini(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 185, 63, 22 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinishVerifyShplemini_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 185, 63, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> FinishCheckEvalsConsistency(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 10, 54, 39 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinishCheckEvalsConsistency_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 10, 54, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.G1Point> FinishBatchMul(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 190, 66, 220 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.G1Point.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FinishBatchMul_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 190, 66, 220 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Auth(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 82, 160, 254 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Auth_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 82, 160, 254 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyIiwiZGVzYyI6Ik9yY2hlc3RyYXRvciAoZW50cnlwb2ludCkgZm9yIEhvbmtWZXJpZmllciDigJQgcmVjZWl2ZXMgY2FsbHMsIGRpc3BhdGNoZXMgdG8gaGVscGVyIGNoYWluIHZpYSBncm91cCB0eG5zIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkcxUG9pbnQiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQyNTYifV0sIlZlcmlmaWNhdGlvbktleSI6W3sibmFtZSI6ImNpcmN1aXRTaXplIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJsb2dDaXJjdWl0U2l6ZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoicHVibGljSW5wdXRzU2l6ZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoicW0iLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFjIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxbCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicXIiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFvIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxNCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicUxvb2t1cCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicUFyaXRoIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxRGVsdGFSYW5nZSIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicUF1eCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicUVsbGlwdGljIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxUG9zZWlkb24yRXh0ZXJuYWwiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFQb3NlaWRvbjJJbnRlcm5hbCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiczEiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InMyIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJzMyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiczQiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImlkMSIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiaWQyIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJpZDMiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImlkNCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoidDEiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InQyIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJ0MyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoidDQiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImxhZ3JhbmdlRmlyc3QiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImxhZ3JhbmdlTGFzdCIsInR5cGUiOiJHMVBvaW50In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fZmluaXNoX2xvYWRWZXJpZmljYXRpb25LZXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpKSIsInN0cnVjdCI6IlZlcmlmaWNhdGlvbktleSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9vZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcHVibGljSW5wdXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19maW5pc2hfdmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9fZmluaXNoX2NvbXB1dGVQdWJsaWNJbnB1dERlbHRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9fZmluaXNoX3ZlcmlmeVN1bWNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9fZmluaXNoX2NvbXB1dGVOZXh0VGFyZ2V0U3VtIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9fZmluaXNoX3ZlcmlmeVNocGxlbWluaSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2ZpbmlzaF9jaGVja0V2YWxzQ29uc2lzdGVuY3kiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19maW5pc2hfYmF0Y2hNdWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJHMVBvaW50IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19hdXRoX18iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0NywxNjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2LDIwMSwyMjksMjU3LDI4NSwzMTMsMzQxLDM2OV0sImVycm9yTWVzc2FnZSI6Im9yY2hlc3RyYXRvcjogbm8gYWN0aXZlIGNhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOiJvcmNoZXN0cmF0b3I6IHJlZW50cmFudCBjYWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzLDI5OV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEl1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lETXlJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbVlpSURCNElEQjRNVFV4Wmpkak56VWdNSGd3TUFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xraHZibXRXWlhKcFptbGxjaTVmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHlncElDMCtJSFZwYm5RMk5Eb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTg2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlgxOWlZWEpsWDJOeVpXRjBaVjlmUURFMkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNE5tUXlaVGN4WXlBd2VETmhPVE5sTUdWbUlEQjROamMzWXpnd1ptUWdNSGhsWm1JME16Z3lZU0F3ZUdaak56UmlPV1U0SURCNE9HVXdNekZqTURFZ01IZ3lObUk1TTJZeE5pQXdlR1V4TUdFek5qSTNJREI0TURoaVpUUXlaR01nTUhnd01UVXlZVEJtWlNBdkx5QnRaWFJvYjJRZ0lsOWZabWx1YVhOb1gyeHZZV1JXWlhKcFptbGpZWFJwYjI1TFpYa29LU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTa2lMQ0J0WlhSb2IyUWdJblpsY21sbWVTaGllWFJsVzEwc2RXbHVkRGhiTXpKZFcxMHBZbTl2YkNJc0lHMWxkR2h2WkNBaVgxOW1hVzVwYzJoZmRtVnlhV1o1S0NsaWIyOXNJaXdnYldWMGFHOWtJQ0pmWDJacGJtbHphRjlqYjIxd2RYUmxVSFZpYkdsalNXNXdkWFJFWld4MFlTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlYMTltYVc1cGMyaGZkbVZ5YVdaNVUzVnRZMmhsWTJzb0tXSnZiMndpTENCdFpYUm9iMlFnSWw5ZlptbHVhWE5vWDJOdmJYQjFkR1ZPWlhoMFZHRnlaMlYwVTNWdEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmZYMlpwYm1semFGOTJaWEpwWm5sVGFIQnNaVzFwYm1rb0tXSnZiMndpTENCdFpYUm9iMlFnSWw5ZlptbHVhWE5vWDJOb1pXTnJSWFpoYkhORGIyNXphWE4wWlc1amVTZ3BZbTl2YkNJc0lHMWxkR2h2WkNBaVgxOW1hVzVwYzJoZlltRjBZMmhOZFd3b0tTaDFhVzUwTWpVMkxIVnBiblF5TlRZcElpd2diV1YwYUc5a0lDSmZYMkYxZEdoZlh5Z3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lGOWZabWx1YVhOb1gyeHZZV1JXWlhKcFptbGpZWFJwYjI1TFpYa2dkbVZ5YVdaNUlGOWZabWx1YVhOb1gzWmxjbWxtZVNCZlgyWnBibWx6YUY5amIyMXdkWFJsVUhWaWJHbGpTVzV3ZFhSRVpXeDBZU0JmWDJacGJtbHphRjkyWlhKcFpubFRkVzFqYUdWamF5QmZYMlpwYm1semFGOWpiMjF3ZFhSbFRtVjRkRlJoY21kbGRGTjFiU0JmWDJacGJtbHphRjkyWlhKcFpubFRhSEJzWlcxcGJta2dYMTltYVc1cGMyaGZZMmhsWTJ0RmRtRnNjME52Ym5OcGMzUmxibU41SUY5ZlptbHVhWE5vWDJKaGRHTm9UWFZzSUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZWFYwYUY5ZlgzSnZkWFJsUURFeUNpQWdJQ0JsY25JS0NsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMTlmWVhWMGFGOWZYM0p2ZFhSbFFERXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlgxOWlZWEpsWDJOeVpXRjBaVjlmUURFMk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhJdVgxOW1hVzVwYzJoZmJHOWhaRlpsY21sbWFXTmhkR2x2Ymt0bGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmWm1sdWFYTm9YMnh2WVdSV1pYSnBabWxqWVhScGIyNUxaWGs2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ptSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM0pqYUdWemRISmhkRzl5T2lCdWJ5QmhZM1JwZG1VZ1kyRnNiQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaaUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkc2IyRmtjeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVNHOXVhMVpsY21sbWFXVnlMblpsY21sbWVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStQZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlaaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXlZMmhsYzNSeVlYUnZjam9nY21WbGJuUnlZVzUwSUdOaGJHd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltWWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2MzUnZjbVVnTVFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5TGw5ZlptbHVhWE5vWDNabGNtbG1lVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZlptbHVhWE5vWDNabGNtbG1lVG9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZjbU5vWlhOMGNtRjBiM0k2SUc1dklHRmpkR2wyWlNCallXeHNDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm1JZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjJ4dllXUnpJREFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEl1WDE5bWFXNXBjMmhmWTI5dGNIVjBaVkIxWW14cFkwbHVjSFYwUkdWc2RHRmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BmWDJacGJtbHphRjlqYjIxd2RYUmxVSFZpYkdsalNXNXdkWFJFWld4MFlUb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltWWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmNtTm9aWE4wY21GMGIzSTZJRzV2SUdGamRHbDJaU0JqWVd4c0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbUlnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaMnh2WVdSeklEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5TGw5ZlptbHVhWE5vWDNabGNtbG1lVk4xYldOb1pXTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDE5bWFXNXBjMmhmZG1WeWFXWjVVM1Z0WTJobFkyczZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm1JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzSmphR1Z6ZEhKaGRHOXlPaUJ1YnlCaFkzUnBkbVVnWTJGc2JBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVppSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2RzYjJGa2N5QXdDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVNHOXVhMVpsY21sbWFXVnlMbDlmWm1sdWFYTm9YMk52YlhCMWRHVk9aWGgwVkdGeVoyVjBVM1Z0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1gxOW1hVzVwYzJoZlkyOXRjSFYwWlU1bGVIUlVZWEpuWlhSVGRXMDZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm1JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzSmphR1Z6ZEhKaGRHOXlPaUJ1YnlCaFkzUnBkbVVnWTJGc2JBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVppSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2RzYjJGa2N5QXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2k1ZlgyWnBibWx6YUY5MlpYSnBabmxUYUhCc1pXMXBibWxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwZlgyWnBibWx6YUY5MlpYSnBabmxUYUhCc1pXMXBibWs2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ptSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM0pqYUdWemRISmhkRzl5T2lCdWJ5QmhZM1JwZG1VZ1kyRnNiQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaaUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkc2IyRmtjeUF3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5TGw5ZlptbHVhWE5vWDJOb1pXTnJSWFpoYkhORGIyNXphWE4wWlc1amVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmWm1sdWFYTm9YMk5vWldOclJYWmhiSE5EYjI1emFYTjBaVzVqZVRvS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1ZaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Y21Ob1pYTjBjbUYwYjNJNklHNXZJR0ZqZEdsMlpTQmpZV3hzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ptSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1oyeHZZV1J6SURBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhJdVgxOW1hVzVwYzJoZlltRjBZMmhOZFd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZYMlpwYm1semFGOWlZWFJqYUUxMWJEb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltWWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmNtTm9aWE4wY21GMGIzSTZJRzV2SUdGamRHbDJaU0JqWVd4c0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbUlnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaMnh2WVdSeklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQWdBaVlFQVdZQUJCVWZmSFVCQUVJQUFERWJRUUJYTVJrVVJERVlSSUlLQkliUzV4d0VPcFBnN3dSbmZJRDlCTyswT0NvRS9IUzU2QVNPQXh3QkJDYTVQeFlFNFFvMkp3UUl2a0xjQkFGU29QNDJHZ0NPQ2dBTEFCOEFWZ0J5QUk0QXFnREdBT0lBL2dBQkFDSkRNUmtVTVJnVUVFTW9aQ2tUUkNncFp6RVdJZ2s3QUNwTVVMQWlRellhQVVraldTVUlTd0VWRWtSWEFnQTJHZ0pKSTFra0N5VUlTd0VWRWtRb1pDa1NSQ2cyR2dCbk5RRTFBSUFGRlI5OGRZQ3dJa01vWkNrVFJDZ3BaekVXSWdrN0FCY2pFeXNqVHdKVUtreFFzQ0pES0dRcEUwUW9LV2N4RmlJSk93QkpGU1FPUkNTdnF5cE1VTEFpUXloa0tSTkVLQ2xuTVJZaUNUc0FGeU1US3lOUEFsUXFURkN3SWtNb1pDa1RSQ2dwWnpFV0lnazdBRWtWSkE1RUpLK3JLa3hRc0NKREtHUXBFMFFvS1djeEZpSUpPd0FYSXhNckkwOENWQ3BNVUxBaVF5aGtLUk5FS0Nsbk1SWWlDVHNBRnlNVEt5TlBBbFFxVEZDd0lrTW9aQ2tUUkNncFp6RVdJZ2s3QUNwTVVMQWlRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
