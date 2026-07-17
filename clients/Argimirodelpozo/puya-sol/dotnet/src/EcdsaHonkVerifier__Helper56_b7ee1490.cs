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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EcdsaHonkVerifier__Helper56_b7ee1490
{


    //
    // Helper contract 56 for EcdsaHonkVerifier
    //
    public class EcdsaHonkVerifier__Helper56Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EcdsaHonkVerifier__Helper56Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class VerificationKey : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 CircuitSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 LogCircuitSize { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 PublicInputsSize { get; set; }

                public Structs.G1Point Qm { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qc { get; set; } = new Structs.G1Point();

                public Structs.G1Point Ql { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qr { get; set; } = new Structs.G1Point();

                public Structs.G1Point Qo { get; set; } = new Structs.G1Point();

                public Structs.G1Point Q4 { get; set; } = new Structs.G1Point();

                public Structs.G1Point QArith { get; set; } = new Structs.G1Point();

                public Structs.G1Point QDeltaRange { get; set; } = new Structs.G1Point();

                public Structs.G1Point QAux { get; set; } = new Structs.G1Point();

                public Structs.G1Point QElliptic { get; set; } = new Structs.G1Point();

                public Structs.G1Point QLookup { get; set; } = new Structs.G1Point();

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vCircuitSize.From(CircuitSize);
                    ret.AddRange(vCircuitSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLogCircuitSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vLogCircuitSize.From(LogCircuitSize);
                    ret.AddRange(vLogCircuitSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicInputsSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vPublicInputsSize.From(PublicInputsSize);
                    ret.AddRange(vPublicInputsSize.Encode());
                    ret.AddRange(Qm.ToByteArray());
                    ret.AddRange(Qc.ToByteArray());
                    ret.AddRange(Ql.ToByteArray());
                    ret.AddRange(Qr.ToByteArray());
                    ret.AddRange(Qo.ToByteArray());
                    ret.AddRange(Q4.ToByteArray());
                    ret.AddRange(QArith.ToByteArray());
                    ret.AddRange(QDeltaRange.ToByteArray());
                    ret.AddRange(QAux.ToByteArray());
                    ret.AddRange(QElliptic.ToByteArray());
                    ret.AddRange(QLookup.ToByteArray());
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
                    var vCircuitSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vCircuitSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.CircuitSize = vCircuitSize;
                    var vLogCircuitSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vLogCircuitSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LogCircuitSize = vLogCircuitSize;
                    var vPublicInputsSize = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
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
                    ret.QArith = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQArith = ret.QArith.ToByteArray().Length; for (int i = 0; i < consumedQArith && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QDeltaRange = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQDeltaRange = ret.QDeltaRange.ToByteArray().Length; for (int i = 0; i < consumedQDeltaRange && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QAux = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQAux = ret.QAux.ToByteArray().Length; for (int i = 0; i < consumedQAux && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QElliptic = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQElliptic = ret.QElliptic.ToByteArray().Length; for (int i = 0; i < consumedQElliptic && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.QLookup = Structs.G1Point.Parse(queue.ToArray());
                    { var consumedQLookup = ret.QLookup.ToByteArray().Length; for (int i = 0; i < consumedQLookup && queue.Count > 0; i++) { queue.Dequeue(); } }
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
        public async Task<Structs.VerificationKey> EcdsaHonkVerificationKeyLoadVerificationKey(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 108, 104, 23 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerificationKey.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EcdsaHonkVerificationKeyLoadVerificationKey_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 108, 104, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> FrLibInvert(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 140, 87, 9 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FrLibInvert_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 140, 87, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWNkc2FIb25rVmVyaWZpZXJfX0hlbHBlcjU2IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA1NiBmb3IgRWNkc2FIb25rVmVyaWZpZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRzFQb2ludCI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDUxMiJ9XSwiVmVyaWZpY2F0aW9uS2V5IjpbeyJuYW1lIjoiY2lyY3VpdFNpemUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImxvZ0NpcmN1aXRTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJwdWJsaWNJbnB1dHNTaXplIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJxbSIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicWMiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFsIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxciIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicW8iLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InE0IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxQXJpdGgiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFEZWx0YVJhbmdlIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxQXV4IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJxRWxsaXB0aWMiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFMb29rdXAiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InFQb3NlaWRvbjJFeHRlcm5hbCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoicVBvc2VpZG9uMkludGVybmFsIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJzMSIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiczIiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InMzIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJzNCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiaWQxIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJpZDIiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6ImlkMyIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoiaWQ0IiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJ0MSIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoidDIiLCJ0eXBlIjoiRzFQb2ludCJ9LHsibmFtZSI6InQzIiwidHlwZSI6IkcxUG9pbnQifSx7Im5hbWUiOiJ0NCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoibGFncmFuZ2VGaXJzdCIsInR5cGUiOiJHMVBvaW50In0seyJuYW1lIjoibGFncmFuZ2VMYXN0IiwidHlwZSI6IkcxUG9pbnQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiRWNkc2FIb25rVmVyaWZpY2F0aW9uS2V5LmxvYWRWZXJpZmljYXRpb25LZXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ1MTIsdWludDUxMix1aW50NTEyLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpLCh1aW50NTEyLHVpbnQ1MTIpKSIsInN0cnVjdCI6IlZlcmlmaWNhdGlvbktleSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiRnJMaWIuaW52ZXJ0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM3NDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgyOV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZhRzl1YXk5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObEwwVmpaSE5oU0c5dWExWmxjbWxtYVdWeUxuTnZiQzVGWTJSellVaHZibXRXWlhKcFptbGxjbDlmU0dWc2NHVnlOVFl1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4b0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTmpRZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERWdNSGd3TVNBd2VBb2dJQ0FnWWlCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh3b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlvYjI1ckwyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVXZSV05rYzJGSWIyNXJWbVZ5YVdacFpYSXVjMjlzTGtWalpITmhTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEkxTmk1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoak56WmpOamd4TnlBd2VEUTVPR00xTnpBNUlDOHZJRzFsZEdodlpDQWlSV05rYzJGSWIyNXJWbVZ5YVdacFkyRjBhVzl1UzJWNUxteHZZV1JXWlhKcFptbGpZWFJwYjI1TFpYa29LU2gxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1pd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTd29kV2x1ZERVeE1peDFhVzUwTlRFeUtTa2lMQ0J0WlhSb2IyUWdJa1p5VEdsaUxtbHVkbVZ5ZENoMWFXNTBOVEV5S1hWcGJuUTFNVElpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOUZZMlJ6WVVodmJtdFdaWEpwWm1sallYUnBiMjVMWlhrdWJHOWhaRlpsY21sbWFXTmhkR2x2Ymt0bGVWOXliM1YwWlVBeUlFWnlUR2xpTG1sdWRtVnlkQW9nSUNBZ1pYSnlDZ3BmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWDE5RlkyUnpZVWh2Ym10V1pYSnBabWxqWVhScGIyNUxaWGt1Ykc5aFpGWmxjbWxtYVdOaGRHbHZia3RsZVY5eWIzVjBaVUF5T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EWXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNR1JrTWprNU5ETmlPVFl4WWpGak5qRTFZV0l5TW1SbU1HVTFZalUyTnpRNE9XRTNZemxoT1dGa00yRmpPVEpoWlRJNE1XUTJPR05oTmpBek16STJZekF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF5WVRVMU1qRTJOV1JqTlRsa1l6VmpOVE01T0dVMllqaGpNakl5TjJSak0yWXpObU5qWkdOak1USTFNR1UzWXpsaE9HTXhOak14WXprMk0yRm1aakptTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJd016YzROV1l6TUdObU56VmxaREpsT0RVMU9XWmhZVGM1TnpnNU56RTNOR0pqWVRFNVpXSmpZalEwTWpZMll6WmlZemczWVdWbE9HUmpPRFk1TmpRd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01URmhaVE5tWW1OalpqQmpNekF5WVdJeU9XRTRNVEl6WWpKbFpqWXpNV0UyTlRsaE16YzFNR1F5TjJSbU0yVmlOMk0wT1RKaFpUazNPR0ZqTTJZd056QXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdZakZoWTJSalpqY3pPV1V4WlRaak1qZGtaakEwTmpVM056RXlNbUV5T1RKaE56ZG1OR1pqWkdZNE1EVTJaRGhpT0dGbE1USm1NVEExWkROaE9EZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREUwTldSaFpETmlaR1E1WVRJMk1qUXhNV0ZoWVRZMU56RXlPV1JtTkRsa1ltWTBOR0UyTTJZMU1UQmxPV0ZpT0RFNU1UWXlNbU0yTkRObFltUTVZbVF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRrME1EZzNNbVl6TUdJek1qVXlNbVV5Tm1WbVpEQm1aRFJoTmpReU1qZzVZbU5sTW1NMU5qQTRNMlUzWVRBellXWTFOalJqTXpBNU5qa3dOalprT0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE9ERm1aREUzTXpBMU1XTmhNVGxsTXpkbU1EbGpOREl5T1Roak16WmtNbVU1T0RNMFpHWTFNRFV6TldRNE5XUTBNamxtTlRZeU16VXlZekJrT1RJME1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESmhNV0ZtWVRZek1XVTRZalpoWWpobVlqRTBORFJtWWpBeE5UUTJPRFpoTldFek5HTTNZVFJrWkdGbE5qWmlaR016TkRSbE56Z3lZVGd4TXpneVlqTXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNR05tWVRBNU16WmhOV1UyTTJVM01qTmhOV016TVRoak56UTJNV1JrWXpJeU9ESTBZV1F3WldVMk1tWmhNREJsTW1VNFlqa3laamxpTTJZeFkyUm1OakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4WVRBeE5qWTJZakpsT1RFMU1qSXhaV0l3WXpGaFpUWmlaamt4TXprMFpERTRZemN6WlRZNE9ESmtaREV5TkRGa01qUTBaamt6TWpZM09EazRNbVZqTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURJeE1tSXdORE0yWkRKa1lURmlOR0UyTlRBM01UUXlZamM1TkRBeU5HUmxaRFU0WlROa05ERm1aR1JsTW1ZNU5USTBPVFF3TldabVpHUXdNbUl6TWpRd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EVTVORFV6WVRnMll6SXpNVGcxWWpnNU56Z3pOams0WlRka1lUTXlZMlUxT1RJM01EWXhNV016TVRKak9ESmhNVFpqTkRKbE9ETmtOalptTTJFeE1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNelF3TTJKa1lURTNOelJrTVdVek56Sm1PVFJrWkRnMk5UY3haRE01TXpJNU1HUm1PV1F5TjJOak1XWXdNekpoTVdFeVltRXpZVEF5WW1WallqSTRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREU0T1dWak0yVTRZemM1TVdFeU9UTXpZVFJtTVRnNFlqSXhPRE5qTkdKbVpXSTVZVEpoT0dVMU1XSmlNVEJoTnpVM01XTXlORE0yTUROa1pETm1ZMlV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURCa016Qm1NVGd6T1dKa1pqSXlOV1F3TUdVeU1HSmpaamMyWVdSalpqSmlabU0yWldFNU9HRTBZMkV4TW1JMFpqTTJZelk0WmpSaE9EWTFabUUxT1RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1ERXhZamd4TldJME5UQTFaamcyT1RRME5qSXhPVGt3WW1RNE1XSmtORFF5Tnpnd01UZzJPVEEwTnpnME5UY3laRFV3TURnM09UUXlZV0U0TmpBM01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESTBaVFUzTldKbU5EWTBNVEV5T1dRME9USTNOVGxqTmpaaE5HRTFZekZrTTJSaE9EQmlOalEzWkRSbE5qZGhaR1psWVRJd1lXSTNNbVZpTmprNE5UUXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVFppTVRFMk5tUTVOV0U0WlRJME9UWmxZakV5TXpZelpHSm1ZamxqWVRWaFlUVmlZekE1TnpWbVl6UTVPVFJrWXpKak5qRmpZekEyTURsa09HVmlZVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4WVdSbFpEVTBaV05pTm1NeVpXTTBabVJsWVdWbU1HWTVaVE5pTW1SaFpUVmtZVEZsTVRrMU9HUTNObUk1TlROaU9XVXlPV1ZtWWpGbE9EazJNbUkwTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFellUVm1ObVE0WmpSa1pUQm1OalprWXpkbFlUQmtOelZsWm1FM1lXVTJOak15WlRZME5EaGpNVE5pWW1KbE5UTTFPRFF4TW1ZM1lUTTJOVEU0WkRZd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UUXlabVE0WmpNeU1qTTNPRFZtWW1Rek5tSXpPREJqTmpBMk5USXhOV1F4Tm1JNE1qRmlNMlJtTkdRNE5tUTFORFkwWmpGaVptWm1NbUV5T1RVME5EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXlaamsxWm1KaE16YzRaalk0WVRNNVlqa3dNR1UwTlRnek5EbGpNR1kzTnpoa1kyRTJOV1V5TmpJM1ltSXhZelZrTmpJNE5HTXlZakV5TmpCbFpqRXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVFU1TmpWa1l6WXlOR1U1WVRRd1pERm1abVV3TXpRelpqaG1aRFJqTW1GbVpHSTJZV000Tm1Vd1pqUTROMkZpT0dNMFptVXlZVGcxWkRFd016Wm1OREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4WXpJMk1HWTVNVE5oWWpZME1UYzBORFJqWmprMU1USmtZekkzTXpJd01XRmhNelE1TkRabE5ERmtOelZtWVRneFl6TTJNalpqT0RGbVpUY3hObVptTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFM05tVTNPREU0WWpOa1ptWm1PR0l5TnpRMFpqVmlOV1F5WXpCaE1tVmlaR0ZtWTJRNU1qZzJZemM1TlRJM01EQTVNbVJtWW1VeU5XRTVZekE0WVdZd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UWTVORFZrTTJReFpHTTFNMlJsTm1GbFlXWm1NVGc1WlRRd1l6Y3lZemxrWlRCaFl6RmtaRGM1TmpNME5UQTJOR013WVdZMVpUQTVNbVU0WlRObU1UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNV1kwT0dNMU1HTmhZMkU0TURNd01EbGhNREEzWW1NMk5qUXlNV1UzTVRNMVpXTmxPREUwWlRBeU56WTNZVFF6WTJJMVlUZGxZell3WWpSbE4yUTRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREU0TjJFell6aGhPR1poTmpoa09ESXdZMlJqWW1Sa1lUSmhaV015Wm1RMllXWTFORGsxWW1ObE0yVmpOVEZoT0RaaE9UQTBNMlZrT0RJNFkyRmpNVEl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURoa01UVmlNMkZsTjJKbE1HSXpOR1ZoWXpBME9UVmlOemN4WXpVNFpXTXhNR0l6T0RabE5HVTJNVFF6TURGaU5HSXdNR1V5WWpCbE16WXdaamhsTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ETmlabUUyT1RWbVlqRXlOV1V5WlRneE5XRmxNelUyTldFeVlqYzJOamRtWlRJeU5EQmxaR1prTkRaak16RXlabUUyWWpabFpEZzRNakkyWkRObU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNR000TldVeE56Z3pOV1pqWlRFMFpUQTBOV1ZsWWpVek1XVm1NbU15T0RkaFpEa3pNMkV5WTJFM1pqTTFaRE5qTjJSbU1ETmtNRE0yTjJaaU9XTXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVGMyTmpKbE5tSTJPV1V4WVRZM1pEZzJPREpoTldNd01HSTBaRE5qTlRkak9HWXpZMlUzWkRneVpHWXdNamRpWVRjeFl6VXdNekZoT1RRMlpUQTNNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TkdKa09ETXdPRE0wTWpjNVlXRTFaalJtWmpZME1UZ3hZV1kyT0dKbFpqa3hNakZqTmpNeU1tUXpOMlF5TldJMU5Ea3daall3WVRnellqYzFOV1k1TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBMVltTTRNMlZrWTJRME1HWTVOak5qTjJZMk9UZ3paakZqTm1FNU9UTmpaVE15WTJFNU4yRTJaVFExWXpBM05tUmpOR1V6T0RFNU5XSmhPRFUyTUdFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXlNemxtTkRKaVlXSXpZbU13WkRGall6UXhPVFJqWVRFM1ptRTNOakF6Tm1ObE1tVTBPRGczWVROa1l6UTVPV1psTnpGa1lUWTNaRGRoWmpsaE16QXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhZbU5pWkRVNVl6aGxPV1V5TkRFek1tUXpaRE5rWm1JeFpXRm1NakZtWVRSbFpEYzBaVGt5TW1KaU5HUTBOR1l6WXpoa01qSmxZbUkxTURFd05XUmhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREUwTjJJd01qRmpNVEEwTm1RMU9XUmpZelppT0dKbE5EQTBaV1l5Tmpjd1pqZGxObVl6TTJFd00yUmlZV1ZsWmprMk5tTTVZbVl6T0RneU16STBaalF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVdSa1l6bGxaamcyTlRnME16YzFaVFU1T1Roa09XWTJabU14Tm1FMFpUWTBObVJqTXpFMVlXSTRObUkwTnpkaFltTXlaakU0WVRjeU0yUmpNalJtTmpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd00yRXpZakV6TW1OaE5qVTVNR00wWm1aa1pqTTFaVEZoWTJRNU16SmtZVFk0TUdFME1qUTNZVFUxWXpnNFpHUXlNamcwWVdZM09HTmlNRFEzT1RBMk1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERmxOR05rWlRObE5ERXdOall3TVRrelltRmpaR1l4WkdJME9UaG1abUkyWW1ZeE5qRTRZelJrTjJJek5UVTBNVFU0TlRoa04yUTVPVFpsT0dKa01ETXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVGhrTjJZd016QXdaamsyTVRVeU1XVmhaREJqWWpOak9ERmhNbUUwTTJFeVpHVmhNR1prWTJJeE4ySmtOemN5WVdWbU5tTTNZamt3T0dKbE5ESTNNekF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3WlRjM1pqSTRZakEzWVdZMU5URm1aV0V4WVdRNE1XSXpNRFJtWkRReE1ERXpPRFV3WlRoaU16VXpPVE13T1dNeU1HSmlNbVpoTVRFMU1qZzVOalF5TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFMVpqa3labVJsTW1Zd1pEZGhOemRqTWpka1lXVmlNemszTXpNMk1qSXdabVpqTURkaU9UbG1OekV3T1Rnd01qVXpaVGcwWmpoaFpUazBZV1prTkdRd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01qSTROV1ZoTkRFeE5tTmhNREJpTmpjellqSmtZV0ZrWmpVNU5qQTFNbUkyWkRsaVlUWmtNak14WVRSaVpXRTRZV1kxWVROak1HWXlPR00wTkdGaE5EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdOelppWmpGbE1XWTJPREppWVdSbFltWmpZVEE0TTJVeU5XUTRNRGhsT0dSaFpUazJNemN5TmpNeFl6QTNNakZoTjJWbE1qTTRZek16TTJFNE5qSmhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeU9HSm1PR001WldWaFpUWTVORFk1TURKbFpUQTRNelV4TnpZNFlUTmxOR1kyTjJRNE1USmxOalEyTldZMU5XWXhObUptTmpsbVlXUXhObU5tTkRaa01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXlaR0ZpTVdNek1qWmlNek5sWVRZelpXTTJOalV4TXpJME1EYzNZekJsWVRKallqQmtaR1poWm1RMk0yWmlPR1k1Wm1Kall6Y3dZbVExTTJRM1pUQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTlvYjI1ckwyTnZiblJ5WVdOMGN5OXlaV1psY21WdVkyVXZSV05rYzJGSWIyNXJWbVZ5YVdacFpYSXVjMjlzTGtWalpITmhTRzl1YTFabGNtbG1hV1Z5WDE5SVpXeHdaWEkxTmk1R2NreHBZaTVwYm5abGNuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BHY2t4cFlpNXBiblpsY25RNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WldabVptWm1abVlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VETXdOalEwWlRjeVpURXpNV0V3TWpsaU9EVXdORFZpTmpneE9ERTFPRFZrTWpnek0yVTRORGczT1dJNU56QTVNVFF6WlRGbU5Ua3paakF3TURBd01ERUtJQ0FnSUdJbENpQWdJQ0J6ZDJGd0NncEdja3hwWWk1cGJuWmxjblJmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJHY2t4cFlpNXBiblpsY25SZllXWjBaWEpmZDJocGJHVkFOZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklFWnlUR2xpTG1sdWRtVnlkRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRFkwTkdVM01tVXhNekZoTURJNVlqZzFNRFExWWpZNE1UZ3hOVGcxWkRJNE16TmxPRFE0TnpsaU9UY3dPVEUwTTJVeFpqVTVNMll3TURBd01EQXhDaUFnSUNCaUpRb2dJQ0FnWW5WeWVTQXpDZ3BHY2t4cFlpNXBiblpsY25SZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TWdvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlKUW9nSUNBZ1luVnllU0F5Q2lBZ0lDQmlJRVp5VEdsaUxtbHVkbVZ5ZEY5M2FHbHNaVjkwYjNCQU1nb0tSbkpNYVdJdWFXNTJaWEowWDJGbWRHVnlYM2RvYVd4bFFEWTZDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmFHOXVheTlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sTDBWalpITmhTRzl1YTFabGNtbG1hV1Z5TG5OdmJDNUZZMlJ6WVVodmJtdFdaWEpwWm1sbGNsOWZTR1ZzY0dWeU5UWXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ1FBRW1BeUF3WkU1eTRUR2dLYmhRUmJhQmdWaGRLRFBvU0htNWNKRkQ0ZldUOEFBQUFRRUJBRUlBQURFWkZFUXhHRVNDQWdUSGJHZ1hCRW1NVndrMkdnQ09BZ0FCRGtzQWdNUWNGUjk4ZFFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRGRLWlE3bGhzY1lWcXlMZkRsdFdkSW1ueWFtdE9za3E0b0hXaktZRE1td0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNwVklXWGNXZHhjVTVqbXVNSWlmY1B6Yk0zTUVsRG55YWpCWXh5V092OHZBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZ040WHpEUGRlMHVoVm42cDVlSmNYUzhvWjY4dEVKbXhyeUhydWpjaHBaQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVhNC92TThNTUNxeW1vRWpzdTlqR21XYU4xRFNmZlByZkVrcTZYaXNQd2NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBc2F6Yzl6bmg1c0o5OEVaWGNTS2lrcWQvVDgzNEJXMkxpdUV2RUYwNmlJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVVYYTA3M1pvbUpCR3FwbGNTbmZTZHYwU21QMUVPbXJnWkZpTEdRK3ZadlFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFHVUNITHpDekpTTGlidjBQMUtaQ0tKdk9MRllJUG5vRHIxWk1NSmFRWnRnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQmdmMFhNRkhLR2VOL0NjUWltTU50THBnMDMxQlRYWVhVS2ZWaU5Td05ra0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFxR3ZwakhvdHF1UHNVUlBzQlZHaHFXalRIcE4ydVpyM0RST2VDcUJPQ3N3QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRFBvSk5xWG1Qbkk2WERHTWRHSGR3aWdrclE3bUw2QU9Mb3VTK2JQeHpmWUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJvQlptc3VrVkloNnd3YTVyK1JPVTBZeHo1b2d0MFNRZEpFK1RKbmlZTHNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBaEt3UTIwdG9iU21VSEZDdDVRQ1RlMVk0OVFmM2VMNVVrbEFYLzNRS3pKQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJaUlRxR3dqR0Z1SmVEYVk1OW95emxrbkJoSERFc2dxRnNRdWc5WnZPaEVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDTkFPOW9YZE5IamN2bE4yR1Z4MDVNcERmblNmTUh3TXFHaXVqb0N2c3NvQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVluc1BveDVHaWt6cFBHSXNoZzhTLzY1b3FqbEc3RUtkWEhDUTJBOTAvemdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTk1QR0RtOThpWFFEaUM4OTJyYzhyL0c2cGlreWhLMDgyeG85S2hsK2xrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkFSdUJXMFVGK0dsRVlobVF2WUc5UkNlQUdHa0VlRVZ5MVFDSGxDcW9ZSEFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFrNVhXL1JrRVNuVWtuV2NacVNsd2RQYWdMWkgxT1o2MytvZ3EzTHJhWVZBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRnJFV2JaV280a2x1c1NOajIvdWNwYXBid0pkZnhKbE53c1ljd0dDZGpyb0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJyZTFVN0xiQzdFL2VydkQ1NDdMYTVkb2VHVmpYYTVVN25pbnZzZWlXSzBBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVHBmYlk5TjRQWnR4K29OZGUrbnJtWXk1a1NNRTd1K1UxaEJMM28yVVkxZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZDL1k4eUkzaGZ2VGF6Z01ZR1VoWFJhNEliUGZUWWJWUms4Yi8vS2lsVVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTK1YrNk40OW9vNXVRRGtXRFNjRDNlTnltWGlZbnV4eGRZb1RDc1NZTzhRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRlpaZHhpVHBwQTBmL2dORCtQMU1LdjIyckliZzlJZXJqRS9pcUYwUU52UUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJ3bUQ1RTZ0a0YwUk0rVkV0d25NZ0dxTkpSdVFkZGZxQncySnNnZjV4Yi9BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBWGJuZ1lzOS8vaXlkRTliWFN3S0xyMnZ6WktHeDVVbkFKTGZ2aVdwd0lyd0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZwUmRQUjNGUGVhdXIvR0o1QXh5eWQ0S3dkMTVZMFVHVEFyMTRKTG80L0VBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDSDBqRkRLeW9Bd0NhQUh2R1pDSG5FMTdPZ1U0Q2RucER5MXAreGd0T2ZZQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVllanlLajZhTmdnemN2ZG9xN0MvV3IxU1Z2T1BzVWFocWtFUHRnb3lzRWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDTkZiT3VlK0N6VHF3RWxiZHh4WTdCQ3podVRtRkRBYlN3RGlzT05nK09BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUE3K21sZnNTWGk2Qld1TldXaXQyWi80aVFPMzlSc01TK210dTJJSW0wL0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJRElYaGVEWDg0VTRFWHV0VEh2TENoNjJUT2l5bjgxMDhmZkE5QTJmN25BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRjJZdWEybmhwbjJHZ3FYQUMwMDhWOGp6em4yQzN3SjdweHhRTWFsRzRIQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJTOWd3ZzBKNXFsOVA5a0dCcjJpKytSSWNZeUxUZlNXMVNROWdxRHQxWDVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRnZJUHR6VUQ1WThmMm1EOGNhcGs4NHl5cGVtNUZ3SGJjVGpnWlc2aFdDZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTT2ZRcnF6dkEwY3hCbE1vWCtuWURiT0xraUhvOXhKbitjZHBuMTYrYU1BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCdkwxWnlPbmlRVExUMDkreDZ2SWZwTzEwNlNLN1RVVHp5Tkl1dTFBUVhhQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVVld0ljRUViVm5jeHJpK1FFN3ladzkrYnpPZ1BicnUrV2JKdnppQ01rOUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFIZHllK0dXRU4xNVptTm4yL0JhazVrYmNNVnE0YTBkNnZDOFlweVBjSlBZQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQU9qc1RMS1paREUvOTgxNGF6Wk10cG9Da0pIcFZ5STNTS0VyM2pMQkhrR0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFlVE40K1FRWmdHVHVzM3gyMG1QKzJ2eFlZeE5lelZVRllXTmZabHVpOUF3QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBR05md01BK1dGU0hxME1zOGdhS2tPaTNxRDl5eGU5ZHlydmJIdVFpK1FuTUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUE1Mzhvc0hyMVVmNmhyWUd6QlAxQkFUaFE2TE5Ua3duQ0M3TDZFVktKWkNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVitTL2VMdzE2ZDhKOXJyT1hNMklnLzhCN21mY1FtQUpUNkUrSzZVcjlUUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlvWHFRUmJLQUxaenN0cXQ5WllGSzIyYnB0SXhwTDZvcjFvOER5akVTcVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZHI4ZUgyZ3JyZXY4b0lQaVhZQ09qYTZXTnlZeHdISWFmdUk0d3pPb1lxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2kvako3cTVwUnBBdTRJTlJkb28rVDJmWUV1WkdYMVh4YS9hZnJSYlBSdEFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTMnJIREpyTStwajdHWlJNa0Izd09vc3NOMzYvV1A3ajUrOHh3dlZQWDRMQWpRellhQVVrVkloSkVnQ0F3WkU1eTRUR2dLYmhRUmJhQmdWaGRLRFBvU0htNWNKRkQ0ZldUNy8vLy95bE9Ba3dvcWt4SktxVkJBQ05KS2F3cXFVRUFDVXNDU3dLaktLcEZBMG1BQVFLaVJRRkxBVW1qS0twRkFrTC8xMHNDU1JVaURrUWlyNnVBQkJVZmZIVk1VTEFqUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
