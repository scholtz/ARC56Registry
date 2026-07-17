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

namespace Arc56.Generated.NotIncorecc.AlgoBharat.ZKVerifierContract_cf4b9890
{


    //
    // 
    //    Staged Groth16 ZK proof verifier for ConsentLedger.
    //
    //    AVM cannot perform EC pairings natively within the ~70k opcode budget.
    //    Two-phase strategy:
    //      1. User submits proof_hash on-chain (cheap: ~1000 ops)
    //      2. Trusted backend (contract creator) verifies off-chain via gnark, then
    //         calls confirm_verification() to mark the proof valid on-chain.
    //      3. ConsentLedger reads is_proof_valid() before granting consent.
    //
    //    Box key = sha256(user_address || proof_hash) to fit within 64-byte AVM limit.
    //    
    //
    public class ZKVerifierContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ZKVerifierContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProofRecord : AVMObjectType
            {
                public byte[] ProofHash { get; set; }

                public byte CircuitType { get; set; }

                public bool IsVerified { get; set; }

                public ulong VerifiedRound { get; set; }

                public ulong ConsentAppId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vProofHash.From(ProofHash);
                    ret.AddRange(vProofHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vCircuitType.From(CircuitType);
                    ret.AddRange(vCircuitType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsVerified.From(IsVerified);
                    ret.AddRange(vIsVerified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifiedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVerifiedRound.From(VerifiedRound);
                    ret.AddRange(vVerifiedRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsentAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vConsentAppId.From(ConsentAppId);
                    ret.AddRange(vConsentAppId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProofRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProofRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vProofHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProofHash = vProofHash.ToValue();
                    if (valueProofHash is byte[] vProofHashValue) { ret.ProofHash = vProofHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vCircuitType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCircuitType = vCircuitType.ToValue();
                    if (valueCircuitType is byte vCircuitTypeValue) { ret.CircuitType = vCircuitTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsVerified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsVerified = vIsVerified.ToValue();
                    if (valueIsVerified is bool vIsVerifiedValue) { ret.IsVerified = vIsVerifiedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifiedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVerifiedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifiedRound = vVerifiedRound.ToValue();
                    if (valueVerifiedRound is ulong vVerifiedRoundValue) { ret.VerifiedRound = vVerifiedRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsentAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vConsentAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConsentAppId = vConsentAppId.ToValue();
                    if (valueConsentAppId is ulong vConsentAppIdValue) { ret.ConsentAppId = vConsentAppIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProofRecord);
                }
                public bool Equals(ProofRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProofRecord left, ProofRecord right)
                {
                    return EqualityComparer<ProofRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ProofRecord left, ProofRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Set the linked ConsentLedger app ID. Only the contract creator can call this.
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetConsentLedgerApp(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 130, 32, 189 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetConsentLedgerApp_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 130, 32, 189 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///User submits the SHA-256 hash of their ZK proof.
        ///The actual proof is verified off-chain by the trusted backend (creator). Box key = sha256(sender || proof_hash) — fits within AVM 64-byte limit.
        ///</summary>
        /// <param name="proof_hash"> </param>
        /// <param name="circuit_type"> </param>
        /// <param name="consent_app_id"> </param>
        public async Task SubmitProof(byte[] proof_hash, byte circuit_type, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 52, 113, 7 };
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);
            var circuit_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); circuit_typeAbi.From(circuit_type);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, proof_hashAbi, circuit_typeAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitProof_Transactions(byte[] proof_hash, byte circuit_type, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 52, 113, 7 };
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);
            var circuit_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); circuit_typeAbi.From(circuit_type);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proof_hashAbi, circuit_typeAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Marks a proof as verified after off-chain gnark verification.
        ///Only the contract creator (trusted backend deployer) can call this.
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="proof_hash"> </param>
        public async Task ConfirmVerification(Algorand.Address user, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 97, 83, 123 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfirmVerification_Transactions(Algorand.Address user, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 97, 83, 123 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns True if the proof has been confirmed by the trusted backend.
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="proof_hash"> </param>
        public async Task<bool> IsProofValid(Algorand.Address user, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 19, 120, 146 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsProofValid_Transactions(Algorand.Address user, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 19, 120, 146 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); proof_hashAbi.From(proof_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWktWZXJpZmllckNvbnRyYWN0IiwiZGVzYyI6IlxuICAgIFN0YWdlZCBHcm90aDE2IFpLIHByb29mIHZlcmlmaWVyIGZvciBDb25zZW50TGVkZ2VyLlxuXG4gICAgQVZNIGNhbm5vdCBwZXJmb3JtIEVDIHBhaXJpbmdzIG5hdGl2ZWx5IHdpdGhpbiB0aGUgfjcwayBvcGNvZGUgYnVkZ2V0LlxuICAgIFR3by1waGFzZSBzdHJhdGVneTpcbiAgICAgIDEuIFVzZXIgc3VibWl0cyBwcm9vZl9oYXNoIG9uLWNoYWluIChjaGVhcDogfjEwMDAgb3BzKVxuICAgICAgMi4gVHJ1c3RlZCBiYWNrZW5kIChjb250cmFjdCBjcmVhdG9yKSB2ZXJpZmllcyBvZmYtY2hhaW4gdmlhIGduYXJrLCB0aGVuXG4gICAgICAgICBjYWxscyBjb25maXJtX3ZlcmlmaWNhdGlvbigpIHRvIG1hcmsgdGhlIHByb29mIHZhbGlkIG9uLWNoYWluLlxuICAgICAgMy4gQ29uc2VudExlZGdlciByZWFkcyBpc19wcm9vZl92YWxpZCgpIGJlZm9yZSBncmFudGluZyBjb25zZW50LlxuXG4gICAgQm94IGtleSA9IHNoYTI1Nih1c2VyX2FkZHJlc3MgfHwgcHJvb2ZfaGFzaCkgdG8gZml0IHdpdGhpbiA2NC1ieXRlIEFWTSBsaW1pdC5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvb2ZSZWNvcmQiOlt7Im5hbWUiOiJwcm9vZl9oYXNoIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImNpcmN1aXRfdHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImlzX3ZlcmlmaWVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJ2ZXJpZmllZF9yb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb25zZW50X2FwcF9pZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0X2NvbnNlbnRfbGVkZ2VyX2FwcCIsImRlc2MiOiJTZXQgdGhlIGxpbmtlZCBDb25zZW50TGVkZ2VyIGFwcCBJRC4gT25seSB0aGUgY29udHJhY3QgY3JlYXRvciBjYW4gY2FsbCB0aGlzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0X3Byb29mIiwiZGVzYyI6IlVzZXIgc3VibWl0cyB0aGUgU0hBLTI1NiBoYXNoIG9mIHRoZWlyIFpLIHByb29mLlxuVGhlIGFjdHVhbCBwcm9vZiBpcyB2ZXJpZmllZCBvZmYtY2hhaW4gYnkgdGhlIHRydXN0ZWQgYmFja2VuZCAoY3JlYXRvcikuIEJveCBrZXkgPSBzaGEyNTYoc2VuZGVyIHx8IHByb29mX2hhc2gpIOKAlCBmaXRzIHdpdGhpbiBBVk0gNjQtYnl0ZSBsaW1pdC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2ZfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaXJjdWl0X3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnNlbnRfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpcm1fdmVyaWZpY2F0aW9uIiwiZGVzYyI6Ik1hcmtzIGEgcHJvb2YgYXMgdmVyaWZpZWQgYWZ0ZXIgb2ZmLWNoYWluIGduYXJrIHZlcmlmaWNhdGlvbi5cbk9ubHkgdGhlIGNvbnRyYWN0IGNyZWF0b3IgKHRydXN0ZWQgYmFja2VuZCBkZXBsb3llcikgY2FuIGNhbGwgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfcHJvb2ZfdmFsaWQiLCJkZXNjIjoiUmV0dXJucyBUcnVlIGlmIHRoZSBwcm9vZiBoYXMgYmVlbiBjb25maXJtZWQgYnkgdGhlIHRydXN0ZWQgYmFja2VuZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwN10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gY29uZmlndXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0cnVzdGVkIGJhY2tlbmQgY2FuIGNvbmZpcm0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMThdLCJlcnJvck1lc3NhZ2UiOiJQcm9vZiBhbHJlYWR5IGNvbmZpcm1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OV0sImVycm9yTWVzc2FnZSI6IlByb29mIGFscmVhZHkgc3VibWl0dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAxXSwiZXJyb3JNZXNzYWdlIjoiVW5rbm93biBwcm9vZiDigJQgY2FsbCBzdWJtaXRfcHJvb2YgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByb29mcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjEsMTgwLDE4OCwyNjAsMjY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMSwxMzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXdJQ0pqYjI1elpXNTBYMnhsWkdkbGNsOWhjSEFpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXprdE5ERUtJQ0FnSUM4dklDTWdZMjl1YzJWdWRGOXNaV1JuWlhKZllYQndJR3hwYm10eklIQnliMjltY3lCMGJ5QmhJSE53WldOcFptbGpJRU52Ym5ObGJuUk1aV1JuWlhJZ1pHVndiRzk1YldWdWRDNEtJQ0FnSUM4dklDTWdWWEJrWVhSbFpDQndiM04wTFdSbGNHeHZlU0IyYVdFZ2MyVjBYMk52Ym5ObGJuUmZiR1ZrWjJWeVgyRndjQ2dwSUdKNUlIUm9aU0JqY21WaGRHOXlMZ29nSUNBZ0x5OGdjMlZzWmk1amIyNXpaVzUwWDJ4bFpHZGxjbDloY0hBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnZibk5sYm5SZmJHVmtaMlZ5WDJGd2NDSUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklHTnNZWE56SUZwTFZtVnlhV1pwWlhKRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRNS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURsaU9ESXlNR0prSURCNE5qUXpORGN4TURjZ01IZzFaRFl4TlRNM1lpQXdlR00wTVRNM09Ea3lJQzh2SUcxbGRHaHZaQ0FpYzJWMFgyTnZibk5sYm5SZmJHVmtaMlZ5WDJGd2NDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNWaWJXbDBYM0J5YjI5bUtIVnBiblE0V3pNeVhTeDFhVzUwT0N4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMjl1Wm1seWJWOTJaWEpwWm1sallYUnBiMjRvWVdSa2NtVnpjeXgxYVc1ME9Gc3pNbDBwZG05cFpDSXNJRzFsZEdodlpDQWlhWE5mY0hKdmIyWmZkbUZzYVdRb1lXUmtjbVZ6Y3l4MWFXNTBPRnN6TWwwcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRGOWpiMjV6Wlc1MFgyeGxaR2RsY2w5aGNIQWdjM1ZpYldsMFgzQnliMjltSUdOdmJtWnBjbTFmZG1WeWFXWnBZMkYwYVc5dUlHbHpYM0J5YjI5bVgzWmhiR2xrQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UTTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NmExOTJaWEpwWm1sbGNpNWpiMjUwY21GamRDNWFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVjMlYwWDJOdmJuTmxiblJmYkdWa1oyVnlYMkZ3Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlqYjI1elpXNTBYMnhsWkdkbGNsOWhjSEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQmpiMjVtYVdkMWNtVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQmpiMjVtYVdkMWNtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnYzJWc1ppNWpiMjV6Wlc1MFgyeGxaR2RsY2w5aGNIQWdQU0JoY0hCZmFXUXVibUYwYVhabENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamIyNXpaVzUwWDJ4bFpHZGxjbDloY0hBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlbXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1V2t0V1pYSnBabWxsY2tOdmJuUnlZV04wTG5OMVltMXBkRjl3Y205dlpsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xWW0xcGRGOXdjbTl2WmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJyWlhrZ1BTQnZjQzV6YUdFeU5UWW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QXJJSEJ5YjI5bVgyaGhjMmd1WW5sMFpYTXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUd0bGVTQnViM1FnYVc0Z2MyVnNaaTV3Y205dlpuTXNJQ0pRY205dlppQmhiSEpsWVdSNUlITjFZbTFwZEhSbFpDSUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZiMllnWVd4eVpXRmtlU0J6ZFdKdGFYUjBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk5TMDNNUW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdVSEp2YjJaU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZiMlpmYUdGemFEMXdjbTl2Wmw5b1lYTm9MbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0JqYVhKamRXbDBYM1I1Y0dVOVkybHlZM1ZwZEY5MGVYQmxMQW9nSUNBZ0x5OGdJQ0FnSUdselgzWmxjbWxtYVdWa1BXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdkbVZ5YVdacFpXUmZjbTkxYm1ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVjMlZ1ZEY5aGNIQmZhV1E5WTI5dWMyVnVkRjloY0hCZmFXUXNDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z2MyVnNaaTV3Y205dlpuTmJhMlY1WFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxucHJYM1psY21sbWFXVnlMbU52Ym5SeVlXTjBMbHBMVm1WeWFXWnBaWEpEYjI1MGNtRmpkQzVqYjI1bWFYSnRYM1psY21sbWFXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnZibVpwY20xZmRtVnlhV1pwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlIUnlkWE4wWldRZ1ltRmphMlZ1WkNCallXNGdZMjl1Wm1seWJTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhSeWRYTjBaV1FnWW1GamEyVnVaQ0JqWVc0Z1kyOXVabWx5YlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QnJaWGtnUFNCdmNDNXphR0V5TlRZb2RYTmxjaTVpZVhSbGN5QXJJSEJ5YjI5bVgyaGhjMmd1WW5sMFpYTXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QmhjM05sY25RZ2EyVjVJR2x1SUhObGJHWXVjSEp2YjJaekxDQWlWVzVyYm05M2JpQndjbTl2WmlEaWdKUWdZMkZzYkNCemRXSnRhWFJmY0hKdmIyWWdabWx5YzNRaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVhMjV2ZDI0Z2NISnZiMllnNG9DVUlHTmhiR3dnYzNWaWJXbDBYM0J5YjI5bUlHWnBjbk4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1Y0hKdmIyWnpXMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSEpsWTI5eVpDNXBjMTkyWlhKcFptbGxaQzV1WVhScGRtVXNJQ0pRY205dlppQmhiSEpsWVdSNUlHTnZibVpwY20xbFpDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TmpRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbTl2WmlCaGJISmxZV1I1SUdOdmJtWnBjbTFsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QndjbTl2Wmw5b1lYTm9QWEpsWTI5eVpDNXdjbTl2Wmw5b1lYTm9MbU52Y0hrb0tTd0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJR05wY21OMWFYUmZkSGx3WlQxeVpXTnZjbVF1WTJseVkzVnBkRjkwZVhCbExBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUIyWlhKcFptbGxaRjl5YjNWdVpEMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJR052Ym5ObGJuUmZZWEJ3WDJsa1BYSmxZMjl5WkM1amIyNXpaVzUwWDJGd2NGOXBaQ3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0EwTWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPRGt0T1RVS0lDQWdJQzh2SUhObGJHWXVjSEp2YjJaelcydGxlVjBnUFNCUWNtOXZabEpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0J3Y205dlpsOW9ZWE5vUFhKbFkyOXlaQzV3Y205dlpsOW9ZWE5vTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCamFYSmpkV2wwWDNSNWNHVTljbVZqYjNKa0xtTnBjbU4xYVhSZmRIbHdaU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOTJaWEpwWm1sbFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBZ0lDQWdkbVZ5YVdacFpXUmZjbTkxYm1ROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQmpiMjV6Wlc1MFgyRndjRjlwWkQxeVpXTnZjbVF1WTI5dWMyVnVkRjloY0hCZmFXUXNDaUFnSUNBdkx5QXBMbU52Y0hrb0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCcGMxOTJaWEpwWm1sbFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwclgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPamc1TFRrMUNpQWdJQ0F2THlCelpXeG1MbkJ5YjI5bWMxdHJaWGxkSUQwZ1VISnZiMlpTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnY0hKdmIyWmZhR0Z6YUQxeVpXTnZjbVF1Y0hKdmIyWmZhR0Z6YUM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kybHlZM1ZwZEY5MGVYQmxQWEpsWTI5eVpDNWphWEpqZFdsMFgzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZkbVZ5YVdacFpXUTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQWdJSFpsY21sbWFXVmtYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdZMjl1YzJWdWRGOWhjSEJmYVdROWNtVmpiM0prTG1OdmJuTmxiblJmWVhCd1gybGtMQW9nSUNBZ0x5OGdLUzVqYjNCNUtDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVtdGZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVXa3RXWlhKcFptbGxja052Ym5SeVlXTjBMbWx6WDNCeWIyOW1YM1poYkdsa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5mY0hKdmIyWmZkbUZzYVdRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJyWlhrZ1BTQnZjQzV6YUdFeU5UWW9kWE5sY2k1aWVYUmxjeUFySUhCeWIyOW1YMmhoYzJndVlubDBaWE1wQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJwWmlCclpYa2dibTkwSUdsdUlITmxiR1l1Y0hKdmIyWnpPZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ2FYTmZjSEp2YjJaZmRtRnNhV1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2dwcGMxOXdjbTl2Wmw5MllXeHBaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1NmExOTJaWEpwWm1sbGNpNWpiMjUwY21GamRDNWFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVhWE5mY0hKdmIyWmZkbUZzYVdSQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYzE5d2NtOXZabDkyWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSE5sYkdZdWNISnZiMlp6VzJ0bGVWMHVhWE5mZG1WeWFXWnBaV1F1Ym1GMGFYWmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205dlpuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTJOQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2x6WDNCeWIyOW1YM1poYkdsa1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbnByWDNabGNtbG1hV1Z5TG1OdmJuUnlZV04wTGxwTFZtVnlhV1pwWlhKRGIyNTBjbUZqZEM1cGMxOXdjbTl2Wmw5MllXeHBaRUEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBU0FBQ0NZQ0FRQVNZMjl1YzJWdWRGOXNaV1JuWlhKZllYQndNUmhBQUFNcEpHY3hHMEVBS3pFWkZFUXhHRVNDQkFTYmdpQzlCR1EwY1FjRVhXRlRld1RFRTNpU05ob0FqZ1FBQ1FBZEFGZ0FxQUF4R1JReEdCUVFRellhQVVrVkpSSkVNUUF5Q1JKRUZ5bE1aeUpETmhvQlNSVWpFa1EyR2dKSkZTSVNSRFlhQTBrVkpSSkVNUUJMQTFBQlNiMUZBUlJFVHdOUEExQ0FDUUFBQUFBQUFBQUFBRkJQQWxDL0lrTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRU1RQXlDUkpFVUFGSnZVVUJSRW0rU0VtQmlBSlRLQ1JQQWxRa1V4UkVTVmNBSUVzQlZ5QUJNZ1lXVHdOWEtnaFBBMDhEVUlBQmdGQlBBbEJNVUw4aVF6WWFBVWtWSXhKRU5ob0NTUlVqRWtSUUFVbTlSUUZBQUF3b2dBUVZIM3gxVEZDd0lrTkp2a1NCaUFKVEtDUlBBbFJDLytZPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
