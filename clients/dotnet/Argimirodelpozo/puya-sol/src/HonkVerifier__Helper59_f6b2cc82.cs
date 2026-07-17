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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.HonkVerifier__Helper59_f6b2cc82
{


    //
    // Helper contract 59 for HonkVerifier
    //
    public class HonkVerifier__Helper59Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HonkVerifier__Helper59Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<Structs.VerificationKey> HonkVerificationKeyLoadVerificationKey(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 229, 174, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerificationKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> HonkVerificationKeyLoadVerificationKey_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 229, 174, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rhs"> G1Point</param>
        /// <param name="lhs"> G1Point</param>
        public async Task<bool> Pairing(Structs.G1Point rhs, Structs.G1Point lhs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 24, 172, 126 };

            var result = await base.CallApp(new List<object> { abiHandle, rhs, lhs }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pairing_Transactions(Structs.G1Point rhs, Structs.G1Point lhs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 24, 172, 126 };

            return await base.MakeTransactionList(new List<object> { abiHandle, rhs, lhs }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="base"> </param>
        /// <param name="v"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FrLibPow(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 @base, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 2, 150, 166 };

            var result = await base.CallApp(new List<object> { abiHandle, @base, v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FrLibPow_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 @base, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 2, 150, 166 };

            return await base.MakeTransactionList(new List<object> { abiHandle, @base, v }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSG9ua1ZlcmlmaWVyX19IZWxwZXI1OSIsImRlc2MiOiJIZWxwZXIgY29udHJhY3QgNTkgZm9yIEhvbmtWZXJpZmllciIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHMVBvaW50IjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50MjU2In1dLCJWZXJpZmljYXRpb25LZXkiOlt7Im5hbWUiOiJjaXJjdWl0U2l6ZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoibG9nQ2lyY3VpdFNpemUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InB1YmxpY0lucHV0c1NpemUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InFtIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxYyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicWwiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFyIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxbyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicTQiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFMb29rdXAiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFBcml0aCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicURlbHRhUmFuZ2UiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFBdXgiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFFbGxpcHRpYyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicVBvc2VpZG9uMkV4dGVybmFsIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxUG9zZWlkb24ySW50ZXJuYWwiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InMxIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJzMiIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiczMiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InM0IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJpZDEiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImlkMiIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiaWQzIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJpZDQiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InQxIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJ0MiIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoidDMiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InQ0IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJsYWdyYW5nZUZpcnN0IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJsYWdyYW5nZUxhc3QiLCJ0eXBlIjoiRzFQb2ludCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJIb25rVmVyaWZpY2F0aW9uS2V5LmxvYWRWZXJpZmljYXRpb25LZXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpLCh1aW50MjU2LHVpbnQyNTYpKSIsInN0cnVjdCI6IlZlcmlmaWNhdGlvbktleSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFpcmluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IkcxUG9pbnQiLCJuYW1lIjoicmhzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IkcxUG9pbnQiLCJuYW1lIjoibGhzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkZyTGliLnBvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2ODZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDIzLDI0OTksMjU4Nl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDM3LDI1MTMsMjYwMF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzMCwyNTA2LDI1OTNdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDUyLDI1MjgsMjYxNV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NjMsMjUzOSwyNjI2XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDgxLDI0ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgRzFQb2ludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2OCwyNTc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NTQsMjY2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MzVdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pVNUxsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklETXlJREVnTWlBMk5Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWJ5SWdJbkFpSUNKeklpQXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVnTUhneE5URm1OMk0zTlFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xrWnlUR2xpTG5CdmR5aGlZWE5sT2lCaWVYUmxjeXdnZGpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwR2NreHBZaTV3YjNjNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDZ3BHY2t4cFlpNXdiM2RmZDJocGJHVmZkRzl3UURFNkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2dSbkpNYVdJdWNHOTNYMkZtZEdWeVgzZG9hV3hsUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQkdja3hwWWk1d2IzZGZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNekEyTkRSbE56SmxNVE14WVRBeU9XSTROVEEwTldJMk9ERTRNVFU0TldReU9ETXpaVGcwT0RjNVlqazNNRGt4TkRObE1XWTFPVE5tTURBd01EQXdNUW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0tSbkpNYVdJdWNHOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01nb2dJQ0FnWWk4S0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpSUVaeVRHbGlMbkJ2ZDE5M2FHbHNaVjkwYjNCQU1Rb0tSbkpNYVdJdWNHOTNYMkZtZEdWeVgzZG9hV3hsUURVNkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWTJGMGFXOXVTMlY1TG14dllXUldaWEpwWm1sallYUnBiMjVMWlhrb0tTQXRQaUJpZVhSbGN6b0tTRzl1YTFabGNtbG1hV05oZEdsdmJrdGxlUzVzYjJGa1ZtVnlhV1pwWTJGMGFXOXVTMlY1T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURVd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU1XUTBaVEppTmpZeVkyWTNOVFU1T0dGbE56VmpPREJqWWpZeE9UQmtObVE0Tm1Kak9USm1aRFk1WmpFME1qQm1ZemxsTm1RMVltVTRZbUV3T1dVeVl6TXdNakV3WkdWa016UXpPVGhtTlRSbE16QTBPR1kyTldNelpqRmtZV00zTkRsall6VXdNakk0TWpnMk5qaGhObUl6TkRVM01USmhaamN6TmpsalltSXhZek0zTXpabU1qZGlZek0wWVdabE9HVmlNVEF5TVRjd05EVTFOVGN4TjJVM05qQXlOREV3TUdNeE5EUTVNek16TXpCa1pqVmtPV0UyWm1JM1pUZG1NakUxTmpFeVlqRTJPR1ZqWmpReU1qa3hZalprWmpRd1pHRXlOREEyT1dRMVlUQmtOV1l5TlRrNVpEaGlaVEZsWXpNMFl6VXdPVFZsTURreU1qRTFNVEExT1dGbFkyUXdZbUpoTnpabFpHUTBaR1U1TWpsa05UZzNOVGMxWWpVd1l6VXdaalJpWlRrNVlUUTJNVFZpWm1Ka05HVmpaVGc1WTJJeE5EUXlaakV4TWpGaU1USmlPR0ptWVRZM05ESTFPREV4TmpJeFlURmlaVGd5Tm1Kall6VmhaR1EwTVdWa1lqVXhabVJqWlRaak1UTTBZemhsTTJabU5XSXhOVGM0TW1Ga05tWTRPR1JrT0dFeU5UVTVNR013TmpWaFpEUXpZV1JpTm1ZelpEUmpZMkpoTldFM016RXlaakkzWkdRMU5qUmlNVEl6TWpWaE1qVTVOR0ZsTlRBek9HTXdZell3WVROa1ptVmtORE5oTWpSbFpXWmpZekF6TXpGbU1EZ3dOelJpWldFM1ltSTFZemRtTmpVeE9URmxZekpqTTJabE5UbGhNak01WTJNeE4ySmxZbU01TmpZMk1UVTJOR0ZqWXpObU5XTTFPVFkwTjJVNU1qY3dOVGN3WlRCak1qTTRPVEUyWkdZMk16a3dZemcxT1RBME5EVm1NalUyWkRGa01HSm1Nak0zTkRFME5EUmhPV0ptTVRVd1pETXpaakU1WkRjd1lUTXhPRFl6TWpVMlpUY3haREppWWpGaFpHWTVObUl3TkdRMk1XWXlZemsxWVRKak5ERmlPREExT0dSaU0yRTFZams0T1RCaU1qUmtNalUwTldJM1pHUTBZV05oTXpjNE5EUmlZakE1TmpRMk9URTRNVEZoTTJSbVpUZGlPV1prTWpSbU9HWXlPRE0yTWpnMk1Ua3dOR1UwWWpZNU1UWXhaRGRtTkRNeU1ERmpPVEl4TTJWa1pUWmxOelJsWWpZek9EQXdNVEl6WWpneVl6Y3pZV1F3TVRVMll6UXdNekExT0dJM1pqWXlZMkpqWW1Sak9EYzJNMkl3TlRrek5XVTVPVFkxWW1WaE9EWmpaREl3TlRJNE1XUXpNekZtWWpReU5tVm1OREl6TW1abVpUVmpOVEppTXpFeVpqRXpabVZoTmpVeE56WmlZekJtWlRBMllXVm1PRGN5TkdZeU5UWTRPVGhrTWpFMVl6YzRPRE0xWmpRd1ltWmxOVFptWW1ZelpqQmtaVE13WVdNMll6UTRZakEyTTJJM05EUmlZbVZsWTJJeU9XTTRPVFl5WTJZeU56ZzFNMkZsTnpnNE5qQXhZVGt5WVRBME1qQmlZVEEwTjJFM1pqZGhOalF6TWpZMVlUaGhaamt3TnpCbU9HSmtOV1V4T0dKak9UZGhNVE5qT1RnMVpETTFZVFU1WXpFNE9HUXpaRFZsWlRZeU5tSmlZelExT0RsaVltRTVabVk1WmpBeU5ESXpObUprWVRFeU5qWTFNR1ppTlRJeU9HTm1OREkwWVRBNE56ZzNOelUwT1RsbE5qbGxPR0prTW1Nek9XRm1Nek5pWkRWbVlUQmlOREEzT1dFeU16TmpaR0U1TWpreVltVXdNbU5tWVRKa1lUbGtNR1pqTjJJd1pXRmlNR1ZpTVdFNE5qZGlNRFk0TlRRd05qWTFPRGxpT1RZM05EVTFNalU1WWpNeU1EbGtabVF5T1RreVlXTXhOekE0WmpCa1pERmtNamhqTW1Ga09URXdaRGxqWmpJeFlURTFNVEE1TkRnMU9EQm1OREEyWW1NNU5ERTJNVEV6WkRZeU1ESXdOV1kzTm1WbFltUmhNVEptTlRZMVl6azRZemMzTldNMFpUUm1NelV6TkdJMVpHTmpNamxsTlRkbFpXUTRPVGxpTVdFeFlUZzRNRFV6TkdSallqa3dZMkV3WW1NMFlqRmpaRGxsWVdSaVltWTBPV1ZoWlRVMllUazVZVFExTURKbFpqRXpaRGsyTlRJeU5tRTJNelJrTURrNE1UVTFOV1UwWVRSa1lUVTJNV0U0WVRneE9HVTJZell4WmpZNFkyVm1ZVE15T1dZeVptRmlZemsxWXpnd1lXUTFObUUxTXpoa09EVXlaamMxWldSaE9EVTRaV1F4WVRZeE5tTTNOREZpT0dGbVlXUTNOalJrTW1OaVpUWTNZemswTWpRNU5UTTFZbUpoTjJaalltUXpaalF4TW1ZNE5qZzBPRGN5TWpKaFlUVTBaak15TmpoaFlqWTBZVEl3TVdJM01HRTVNR0V6TXpSak9XSmtOVEE1Tm1GaFpEaGhNR05qTldRMFl6RmtNV05rWWpCbVpUUXhOVFEwTldKa01HTTRORE13T1dOaFlXWXlNVE5sTVRNeU5EQm1PVGRoTlRnMFlqUTFNVGcwWXpobFl6TXhNekU1WWpWbU5tTXdOR1ZsTVRsbFl6RmtabVZqT0RkbFpEUTNaRFprTURSaFlURTFPR1JsTWpKa1lXUXlNakF5TWpFeU1XUTJPRGxtTlRkbVlqTTRZMkV5TVRNME9XTmxabUkxWkRJME1HSXdOMk5sWWpSaVpUSTJaV0UwTWpsaU5tUmpPV1E1WlRBeVpHSmxZVFZqWVdWa1pXUTJOelE1WkRKbFpqSmxNakEzTkdSaVpXRTFObU00WkRVMFptRXdORE5oTlRSak5tVTJZVFF3TWpNNFptSXdZVFV5WXpobE1XWXlPVGxpTnpSbE16ZzJOMlU0WXpoaVl6RTBPV1ZtTTJFek1EZ3dNRGRoTTJKa05tWTVPVE0xTURnNFpXTXlORGRqWTJVNU9USmpNek5oTlRNek5qQTJOalV5WXpKaE56SmpZamd4TWpnMFlqRTVNR1V5TXpWbFpUQXlPV0U1TkRZelpqTTJZakpsTWpsaE1UYzNOV001T0RSaU9XUTVZakkzTVRSaVlXSXlOamhsT0dReFpUWXhPV1prWlRnMVlUY3haVFF6TUdJM056azNORE15Tm1RM09UQmpZalkwWXpnM05UVTRNRGcxTXpNeVpHWTJNemxpT0dObE5ERXdNamcwT1dObE9XWTNOelkyT1RFNU1HVmtOak16T0RoaU0yTmpOR0UyWkRSbE1HUTRPVFZqTmpnellXVXdNRFUzWmpNMllUQXdaVFl5TkRFMlpHVTFaVEptT0dRMU9HUXdPR1EwWWpSaVlqTmhOak5sTWpObE1Ea3haVGRoTVdZeE0yTTFPREZqT0dFNU9HTTNOVEF4TkdRMVpXTTRZVEl3T0Rrd1l6WXlZVFV3Wm1abU0ySTBaVFE1WVRKbE5tVXdOV0pqTmpOa09EUXpPRE0yT0RFNE1qWXpPV1ZtTkRNMVl6ZzVaak13WlROaE0yRTVNRFV6WkRrM1ltVmhOV1l5TVRneU1HTmhabVUzWm1aaVpXWXhORGc0TURVMk5XVmtPVGMyWkRVelpXUXpNV000TkRReE9EYzBORGRrTWpGbU1Ea3hNREJsT0dVMU5qbGtNMkZsWXpKbE9EbGxaV0kyTmpCallXTTRNakJrWlRVd1ltVTBZelV6WWpZd09HUmtOamRqTmprM04yWTFaakUzTkRabVkyWXdabUkyTkRjMVpEZ3hZMk5rT1RNeE9HTmhOVGt6T1RVM1pESTJOemMwTWpBeU16WXhNemhpTXpZMU9XRTJZamsxWWpVNE1HSmpZekE1WVROa1ptSmtZV1JtWVRVNFlUTTRNakl5WXpFMU1HTTNOVFppWVRaaE1HTTJObUl3TlRZMU5UTTBPV1l3TkdNMk1XUm1aamswWkdSa1pqTmhOR1F3TVRFM1ptRm1aR0UzTkRGbU9UVXhPR00wTW1Zd01EQm1PRGRoTVRJd01XVmlZV1E1WW1ReU0yWmxaRE16T0RJMFlXVTBZbUV5WVRGaE16QTNZVFExWm1JeE5UVTVOR1k0WkRVMU0yUXlaV0ptT1dNeU9EVXlORGcwTmpBMk5UWmxZemxpWXpCaFpEazBNREExTVdVellqQTNOVEZrTWpWaVlqazNPRGcxWkRoaVl6TTJNbVZpTURaaU9UWmxZVGM0WkRneVpqZzBNR0UxWldWaVl6VXpPR1JqTkRBeE9EVTROalEzTURabE1qSmtPRFV3WlROak1ESmpaVE00WlRNeU5UYzJNV0UxT1RFek1tSmtZamxsT1dRM09UVmlaVEUyTVdWa1pEZzNOek5oTTJJM05HTXdOVFV6WWpZNU1HSTBZamd3WWpKaE5XTmlaRFJoTVdFeU5XWmtZVEE1TjJKbFpqSXpaVE0wT1RVek1XSTBNMlV5T0RjeE16bGtZVGc1TlRJeE5XTXlNVFpoWldKbE9HTmpaVGRrTTJJNU5EUm1OR0V6WWpBMU1XSmtOREEzTVRJMk1EQTNPVEl4WTJJeFptSmpOV1pqTWpCa05qY3hNall6WTJGa09EaGpNVEU1WkRCaE5XUXhOekkyTnprek1Ea3dPRGRsTXpnMVpqaGxOelprTkdObVlUZ3pOR1poWWpZeFpXSmtOall3TXpCbU9XVTJaR1prTTJVMlpqUTFPRFJpTWpobE1tTmlNREEwT0ROa1l6Sm1abVE1WW1ZMVpqZGhaVEpqWXpObU1XVmhNRGcyT1dNMVlXVTNNV1E1WVRFeE1ERmxNalkzWWpVNE5qQTRPV0U0WW1JME5EZGxPRE5oWWpOaU56QXlPV1ZrTnpnNFkyTXlNVFJsTUdKbE5EUTBPRFZsTW1Zek9XRm1ZbUkzWVdVMk1UTTBNVEJrTmpoaVkyVTBNamxrWXpNMlpUSXpNREl6WTJabE1qRmpOV1l5WTJWa04yVXhNelkxTWpsaE5HSmpaRFF6TVRjeU16Sm1NbVpqTVRaaU5qRXdOVFJoTWpaaFpUTmhaV1ZsWldSak5qVXpZMlkxWXpWbE0yTXdPV1V5TWpVNE1UUXhaVFkzWmpSaE5XRTBPR0kxTUdOaVpqUTRPVFU0WWpRd1ltUXlaREUwTVRrd1pXUmpaamxpTW1GaE5qazNZalkzTjJNM056a3dPRE5oWVdZd01UVXhZMk0wWmpZM00yUmpaalJpWkdKaE16a3laRFl5T0RCbE16YzJNbVU1WlRjMk1tRTJObVpsWkRjM1pXSXdaVGN5TmpRMVpUVmlZVFUwWmpNeVl6RmtNV0ptWW1NMFltUTROakl6TmpGa1lXWmtOMlZpWkRaak5qaGtaREJpTkdFd01USm1ZbU00TnpabU5UZGtZVFkyT1RJeE5UTTRNMll6TlRrMU16Z3paamM0TjJKallURTFNMlU1TnpKbE5tTm1ZamxrWm1WaVpXRmhNV0l3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpCaFpqTTRPRFJsWTJGa016TXpNVFF5T1dGbU9UazFOemM1WXpJMk1ESmxPVE5qWVRGbFlUazNObVU1WlRGaVl6WTBZbUpqWkdKaU9XWmxOemt5TVRJeFpqRTRPREF6WVdSa09HRmtOamcyWlRFelpHTXlZVGs0T1dSalptSXdNVEJqWWpZNVlqQmlNemd5TURCa1pqVXhOemczWWpjeE1EUmlZemMwWm1JMkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzV3WVdseWFXNW5LSEpvY3pvZ1lubDBaWE1zSUd4b2N6b2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dwd1lXbHlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01pQXpDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTVPR1U1TXprek9USXdaRFE0TTJFM01qWXdZbVppTnpNeFptSTFaREkxWmpGaFlUUTVNek16TldFNVpUY3hNamszWlRRNE5XSTNZV1ZtTXpFeVl6SXhPREF3WkdWbFpqRXlNV1l4WlRjMk5ESTJZVEF3TmpZMVpUVmpORFEzT1RZM05ETXlNbVEwWmpjMVpXUmhaR1EwTm1SbFltUTFZMlE1T1RKbU5tVmtNRGt3TmpnNVpEQTFPRFZtWmpBM05XVmpPV1U1T1dGa05qa3dZek16T1RWaVl6UmlNekV6TXpjd1lqTTRaV1l6TlRWaFkyUmhaR05rTVRJeU9UYzFZakV5WXpnMVpXRTFaR0k0WXpaa1pXSTBZV0ZpTnpFNE1EaGtZMkkwTURobVpUTmtNV1UzTmprd1l6UXpaRE0zWWpSalpUWmpZekF4TmpabVlUZGtZV0VLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lOakJsTURGaU1qVXhaalptTVdNM1pUZG1aalJsTlRnd056a3haR1ZsT0dWaE5URmtPRGRoTXpVNFpUQXpPR0kwWldabE16Qm1ZV013T1RNNE0yTXhNREV4T0dNMFpEVmlPRE0zWW1Oak1tSmpPRGxpTldJek9UaGlOVGszTkdVNVpqVTVORFF3TnpOaU16SXdOemhpTjJVeU16Rm1aV001TXpnNE9ETmlNREEwWm1NMk16WTVaamN4TVRCbVpUTmtNalV4TlRaak1XSmlPV0UzTWpnMU9XTm1NbUV3TkRZME1XWTVPV0poTkdWbE5ERXpZemd3WkdFMllUVm1aVFF5TW1abFltUmhNMk13WXpBMk16SmhOVFkwTnpWaU5ESXhOR1UxTmpFMVpURXhaVFprWkRObU9UWmxObU5sWVRJNE5UUmhPRGRrTkdSaFkyTTFaVFUxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXhPVElnTmpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElERTJNQ0F6TWdvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTXpVeUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSEIxYzJocGJuUWdNekl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmxZMTl3WVdseWFXNW5YMk5vWldOcklFSk9NalUwWnpFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ1ltQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzSjFjM1F0YUc5dWF5OWpiMjUwY21GamRITXZlbXRXWlhKcFptbGxjaTV6YjJ3dVNHOXVhMVpsY21sbWFXVnlYMTlJWld4d1pYSTFPUzVmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHlncElDMCtJSFZwYm5RMk5Eb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTg2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlgxOWlZWEpsWDJOeVpXRjBaVjlmUURFd0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU5XVTFZV1ZsWmlBd2VHVXhNVGhoWXpkbElEQjRZakV3TWprMllUWWdNSGhoT1RabFpqazRPU0F2THlCdFpYUm9iMlFnSWtodmJtdFdaWEpwWm1sallYUnBiMjVMWlhrdWJHOWhaRlpsY21sbWFXTmhkR2x2Ymt0bGVTZ3BLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcExDaDFhVzUwTWpVMkxIVnBiblF5TlRZcEtTSXNJRzFsZEdodlpDQWljR0ZwY21sdVp5Z29kV2x1ZERJMU5peDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMktTbGliMjlzSWl3Z2JXVjBhRzlrSUNKR2NreHBZaTV3YjNjb2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSWw5ZmFXNXBkRjlmS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pVNUxraHZibXRXWlhKcFptbGpZWFJwYjI1TFpYa3ViRzloWkZabGNtbG1hV05oZEdsdmJrdGxlVnR5YjNWMGFXNW5YU0F2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjalU1TG5CaGFYSnBibWRiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEkxT1M1R2NreHBZaTV3YjNkYmNtOTFkR2x1WjEwZ1gxOXBibWwwWDE4S0lDQWdJR1Z5Y2dvS1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFERXdPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqVTVMa2h2Ym10V1pYSnBabWxqWVhScGIyNUxaWGt1Ykc5aFpGWmxjbWxtYVdOaGRHbHZia3RsZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5eWRYTjBMV2h2Ym1zdlkyOXVkSEpoWTNSekwzcHJWbVZ5YVdacFpYSXVjMjlzTGtodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU5Ua3VTRzl1YTFabGNtbG1hV05oZEdsdmJrdGxlUzVzYjJGa1ZtVnlhV1pwWTJGMGFXOXVTMlY1VzNKdmRYUnBibWRkT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Y25WemRDMW9iMjVyTDJOdmJuUnlZV04wY3k5NmExWmxjbWxtYVdWeUxuTnZiQzVJYjI1clZtVnlhV1pwWlhKZlgwaGxiSEJsY2pVNUxraHZibXRXWlhKcFptbGpZWFJwYjI1TFpYa3ViRzloWkZabGNtbG1hV05oZEdsdmJrdGxlVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYlhWemRDQmlaU0JqWVd4c1pXUWdhVzRnWjNKdmRYQUtJQ0FnSUdkMGVHNGdNQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIxYm1GMWRHaHZjbWw2WldRZ1kyRnNiR1Z5Q2lBZ0lDQm5kSGh1SURBZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xraHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlOVGt1U0c5dWExWmxjbWxtYVdOaGRHbHZia3RsZVM1c2IyRmtWbVZ5YVdacFkyRjBhVzl1UzJWNVczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVNHOXVhMVpsY21sbWFXTmhkR2x2Ymt0bGVTNXNiMkZrVm1WeWFXWnBZMkYwYVc5dVMyVjVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdOaGJHeHpkV0lnU0c5dWExWmxjbWxtYVdOaGRHbHZia3RsZVM1c2IyRmtWbVZ5YVdacFkyRjBhVzl1UzJWNUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM0oxYzNRdGFHOXVheTlqYjI1MGNtRmpkSE12ZW10V1pYSnBabWxsY2k1emIyd3VTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEkxT1M1d1lXbHlhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1U0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJMU9TNXdZV2x5YVc1blczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdSekZRYjJsdWRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdSekZRYjJsdWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqVTVMbkJoYVhKcGJtZGJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHbHVJR2R5YjNWd0NpQWdJQ0JuZEhodUlEQWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkVzVoZFhSb2IzSnBlbVZrSUdOaGJHeGxjZ29nSUNBZ1ozUjRiaUF3SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqVTVMbkJoYVhKcGJtZGJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1U0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJMU9TNXdZV2x5YVc1blczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdjR0ZwY21sdVp3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2NIVnphR2x1ZENBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXlkWE4wTFdodmJtc3ZZMjl1ZEhKaFkzUnpMM3ByVm1WeWFXWnBaWEl1YzI5c0xraHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlOVGt1Um5KTWFXSXVjRzkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNKMWMzUXRhRzl1YXk5amIyNTBjbUZqZEhNdmVtdFdaWEpwWm1sbGNpNXpiMnd1U0c5dWExWmxjbWxtYVdWeVgxOUlaV3h3WlhJMU9TNUdja3hwWWk1d2IzZGJjbTkxZEdsdVoxMDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjblZ6ZEMxb2IyNXJMMk52Ym5SeVlXTjBjeTk2YTFabGNtbG1hV1Z5TG5OdmJDNUliMjVyVm1WeWFXWnBaWEpmWDBobGJIQmxjalU1TGtaeVRHbGlMbkJ2ZDF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVJuSk1hV0l1Y0c5M1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVJuSk1hV0l1Y0c5M1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdSbkpNYVdJdWNHOTNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl5ZFhOMExXaHZibXN2WTI5dWRISmhZM1J6TDNwclZtVnlhV1pwWlhJdWMyOXNMa2h2Ym10V1pYSnBabWxsY2w5ZlNHVnNjR1Z5TlRrdVgxOXBibWwwWDE5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGZYMmx1YVhSZlh6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmNuVnpkQzFvYjI1ckwyTnZiblJ5WVdOMGN5OTZhMVpsY21sbWFXVnlMbk52YkM1SWIyNXJWbVZ5YVdacFpYSmZYMGhsYkhCbGNqVTVMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUlBRUNRQ1lGQVc4QmNBRnpJREJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQkJCVWZmSFZDQ1A2S0FnR0FBUUdML2l1cWkvK0xBb0FBcFVFQUtJc0NnQUVCcklBQXFVRUFDWXNBaXdHaks2cU1BSXNDZ0FFQ29vd0Npd0ZKb3l1cWpBRkMvOUNKZ0tBT0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDSFU0clppejNWWml1ZGNnTXRoa05iWWE4a3YxcDhVSVB5ZWJWdm91Z25pd3dJUTN0TkRtUFZPTUVqMlhEOGRySFNjeFFJb0tHYUthelJYRXE5emFjdXh3M052Sjd3MHIranJFQ0Z3UlZWeGZuWUNRUURCUkpNek1OOWRtbSszNS9JVllTc1dqczlDS1J0dDlBMmlRR25Wb05YeVdaMkw0ZXcweFFsZUNTSVZFRm11elF1NmR1M1UzcEtkV0hWMXRReFE5TDZacEdGYis5VHM2Snl4UkM4UkliRXJpL3BuUWxnUllob2I2Q2E4eGEzVUh0dFIvYzVzRTB5T1AvV3hWNEt0YjRqZGlpVlpEQVphMURyYmJ6MU15NlduTVM4bjNWWkxFakphSlpTdVVEakF4Z285L3RRNkpPNzh3RE1mQ0FkTDZudTF4L1pSa2V3c1ArV2FJNXpCZSt2SlptRldTc3cvWEZsa2ZwSndWdzRNSTRrVzMyT1F5RmtFUmZKVzBkQy9JM1FVUkttL0ZRMHo4WjF3b3hoakpXNXgwcnNhMzVhd1RXSHl5Vm9zUWJnRmpiT2x1WWtMSk5KVVczM1VyS040UkxzSlpHa1lFYVBmNTduOUpQanlnMktHR1FUa3RwRmgxL1F5QWNraFB0NXVkT3RqZ0FFanVDeHpyUUZXeEFNRmkzOWl5OHZjaDJPd1dUWHBsbHZxaHMwZ1VvSFRNZnRDYnZRakwvNWNVck1TOFQvcVpSZHJ3UDRHcnZoeVR5Vm9tTklWeDRnMTlBditWdnZ6OE40d3JHeElzR08zUkx2dXl5bklsaXp5ZUZPdWVJWUJxU29FSUxvRWVuOTZaREpscUsrUWNQaTlYaGk4bDZFOG1GMDFwWndZalQxZTVpYTd4RmlidXAvNThDUWphOW9TWmxEN1VpalBRa29JZUhkVW1lYWVpOUxEbXZNNzFmb0xRSG1pTTgycEtTdmdMUG90cWREOGV3NnJEckdvWjdCb1ZBWmxpYmxuUlZKWnN5Q2QvU21TckJjSThOMGRLTUt0a1EyYzhob1ZFSlNGZ1BRR3ZKUVdFVDFpQWdYM2J1dmFFdlZseVl4M1hFNVBOVFMxM01LZVYrN1ltYkdocUlCVFRjdVF5Z3ZFc2MyZXJidjBucTVXcVpwRkF1OFQyV1VpYW1OTkNZRlZYa3BOcFdHb3FCam14aDlvenZveW55K3J5VnlBclZhbE9OaFM5MTdhaFk3UnBoYkhRYml2clhaTkxMNW55VUpKVTF1NmY4dlQ5Qkw0YUVoeUlxcFU4eWFLdGtvZ0czQ3BDak5NbTlVSmFxMktETVhVd2RITnNQNUJWRVc5RElRd25LcnlFK0V5UVBsNldFdEZHRXlPd3hNWnRmYkFUdUdld2Qvc2grMUgxdEJLb1ZqZUl0clNJQ0lTSFdpZlYvczR5aUUwbk8rMTBrQ3dmT3RMNG02a0tiYmNuWjRDMitwY3J0N1dkSjB1OHVJSFRiNmxiSTFVK2dRNlZNYm1wQUk0K3dwU3lPSHltYmRPT0dmb3lMd1Vudk9qQ0FCNk85YjVrMUNJN0NSOHpwa3NNNlV6WUdaU3dxY3N1QktFc1pEaU5lNENtcFJqODJzdUthRjNYSmhMblpzbkZMcXlhT2pSNWhuOTZGcHg1REMzZVhReWJYa010a3lIVllDRk15MzJPYmpPUVFLRW5PbjNkbWtaRHRZemlMUE1TbTFPRFlsY2FEcmdCWDgyb0E1aVFXM2w0dmpWalFqVXRMczZZK0krQ1I1Nkh4UEZnY2lwakhVQlRWN0lvZ2lReGlwUS8vTzA1Sm91YmdXOFk5aERnMmdZSmpudlExeUo4dzQ2T3BCVDJYdnFYeUdDREsvbi83N3hTSUJXWHRsMjFUN1RISVJCaDBSOUlmQ1JBT2psYWRPdXd1aWU2MllNcklJTjVRdmt4VHRnamRaOGFYZjE4WFJ2encrMlIxMkJ6Tmt4aktXVGxYMG1kMElDTmhPTE5sbW11VnRZQzh3Sm85KzlyZnBZbzRJaXdWREhWcnBxREdhd1ZsVTBud1RHSGYrVTNkODZUUUVYK3YyblFmbFJqRUx3QVBoNkVnSHJyWnZTUCswemdrcmt1aW9hTUhwRit4VlpUNDFWUFM2L25DaFNTRVlHVnV5YndLMlVBRkhqc0hVZEpidVhpRjJMdzJMckJybHVwNDJDK0VDbDdyeFRqY1FCaFlaSEJ1SXRoUTQ4QXM0NDR5VjJHbGtUSzl1ZW5YbGI0V0h0MkhjNk8zVEFWVHRwQzB1QXNxWEwxS0dpWDlvSmUrOGo0MGxURzBQaWh4T2RxSlVoWENGcTYrak01OU81UlBTanNGRzlRSEVtQUhraHl4KzhYOElOWnhKanl0aU1FWjBLWFJjbWVUQ1FoK09GK09kdFRQcURUNnRoNjlaZ01Qbm0zOVBtOUZoTEtPTExBRWc5d3YvWnYxOTY0c3cvSHFDR25Gcm5IWm9SQWVKbnRZWUltb3UwUitnNnM3Y0NudGVJekNGT0MrUkVoZUx6bXZ1M3JtRTBFTmFMemtLZHcyNGpBanorSWNYeXp0ZmhObEthUzgxREZ5TXZMOEZyWVFWS0pxNDY3dTdjWlR6MXhlUEFuaUpZRkI1bjlLV2tpMURMOUlsWXRBdlMwVUdRN2MrYktxYVh0bmZIZVFnNnJ3RlJ6RTluUGM5TDI2T1MxaWdPTjJMcDUyS21iKzEzNnc1eVpGNWJwVTh5d2RHL3ZFdllZallkcjlmcjFzYU4wTFNnRXZ2SWR2VjlwbWtoVTRQeldWT0Q5NGU4b1ZQcGN1YlB1ZC9yNnFHd0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlLODRoT3l0TXpGQ212bVZkNXdtQXVrOG9lcVhicDRieGt1ODI3bitlU0VoOFlnRHJkaXRhRzRUM0NxWW5jK3dFTXRwc0xPQ0FOOVJlSHR4Qkx4MCsyaVlvQ0F5S3ZpLzVYQUNCTEFVeFFTUlVpQ1NKWWkvNVhJQ0JMQWt4UVNSVWlDU0pZVUlDQUFSbU9rNU9TRFVnNmNtQy90ekg3WFNYeHFra3pOYW5uRXBma2hiZXU4eExDR0FEZTd4SWZIblpDYWdCbVhseEVlV2RESXRUM1h0cmRSdDY5WE5tUzl1MEpCb25RV0Yvd2RleWVtYTFwRERPVnZFc3hNM0N6anZOVnJOcmMwU0tYV3hMSVhxWGJqRzNyU3F0eGdJM0xRSS9qMGVkcERFUFRlMHptekFGbStuMnFVSXYvVndBZ1N3Sk1VRWtWSWdraVdGQ0wvMWNnSUU4Q1RGQkpGU0lKSWxoUWdJQUJKZzRCc2xIMjhjZm4vMDVZQjVIZTZPcFIySG8xamdPTFR2NHcrc0NUZzhFQkdNVFZ1RGU4d3J5SnRiT1l0WmRPbjFsRUJ6c3lCNHQrSXgvc2s0aURzQVQ4WTJuM0VRL2owbEZXd2J1YWNvV2M4cUJHUWZtYnBPNUJQSURhYWwva0l2NjlvOERBWXlwV1IxdENGT1ZoWGhIbTNUK1c1czZpaFVxSDFOck1YbFZRZ1JpdlN3RlhBRUJMQWxmQVFGQkxBbGRnSUVzRFYwQWdVRXNEVjZBZ1N3UlhnQ0JRVUVzRGdhQUNJbGhMQklHQUFpSllVRXNFZ2VBQ0lsaFBCWUhBQWlKWVVGQlE0Z0FXVUJjakVJditpLytKTVJ0QkFDc3hHUlJFTVJoRWdnUUVsZVd1N3dUaEdLeCtCTEVDbHFZRXFXNzVpVFlhQUk0RUFBa0FSUUNjQVBFQU1Sa1VNUmdVRUVNb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJd2s0R0Nsa0VrUXhGaU1KT1JvQUttUVNSSWoyMGljRVRGQ3dJME0yR2dGSkZTVVNSRFlhQWtrVkpSSkVLR1JCQUMweUJDUVBSRE1BR0Noa0VrUXpBQUF4QUJKRUtXUkJBQlV4RmlNSk9CZ3BaQkpFTVJZakNUa2FBQ3BrRWtSS2lQMnBSZ0tBQVFDQkFFOENWQ2NFVEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRUtHUkJBQzB5QkNRUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaU1KT0JncFpCSkVNUllqQ1RrYUFDcGtFa1JLaVBYeFNSVWlEa1FpcjZzbkJFeFFzQ05ETmhvQlNSV0JDQkpFRnpZYUFra1ZnUWdTUkJjMkdnTkpnUUJaSkFoTEFSVVNSRmNDQUNoa0ZFUW9Ud05uS1U4Q1p5cE1aeU5EIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
