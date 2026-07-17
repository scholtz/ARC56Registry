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

namespace Arc56.Generated.NotIncorecc.AlgoBharat.PlonkZKVerifierContract_1142cb62
{


    //
    // 
    //    Trustless PLONK ZK verifier for ConsentLedger.
    //
    //    This contract does NOT perform the proof verification itself — the AVM
    //    cannot afford the ~145k opcode budget inline. Instead:
    //
    //    1. The AlgoPlonk-generated LOGICSIG verifier (a separate .teal file) runs as
    //       the transaction signer for calls to this contract.
    //    2. If the PLONK proof is valid, the logicsig approves → this method executes.
    //    3. This method records the verified consent commitment on-chain.
    //    4. ConsentLedger reads is_consent_zk_verified() before granting access.
    //
    //    The security guarantee: this method can ONLY be called if the logicsig
    //    approved the transaction, which requires a valid PLONK proof as input.
    //    No backend can forge this — it's enforced by the AVM itself.
    //
    //    Box key = sha256(user_address(32) || commitment(32)) — 32 bytes, AVM-safe.
    //    
    //
    public class PlonkZKVerifierContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PlonkZKVerifierContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VerifiedConsentRecord : AVMObjectType
            {
                public byte CircuitType { get; set; }

                public byte[] Commitment { get; set; }

                public ulong VerifiedRound { get; set; }

                public ulong ConsentAppId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vCircuitType.From(CircuitType);
                    ret.AddRange(vCircuitType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCommitment.From(Commitment);
                    ret.AddRange(vCommitment.Encode());
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

                public static VerifiedConsentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VerifiedConsentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCircuitType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vCircuitType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCircuitType = vCircuitType.ToValue();
                    if (valueCircuitType is byte vCircuitTypeValue) { ret.CircuitType = vCircuitTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCommitment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitment = vCommitment.ToValue();
                    if (valueCommitment is byte[] vCommitmentValue) { ret.Commitment = vCommitmentValue; }
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
                    return Equals(obj as VerifiedConsentRecord);
                }
                public bool Equals(VerifiedConsentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifiedConsentRecord left, VerifiedConsentRecord right)
                {
                    return EqualityComparer<VerifiedConsentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifiedConsentRecord left, VerifiedConsentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Link to the ConsentLedger contract. Creator-only.
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
        ///Register the AlgoPlonk verifier app IDs. Creator-only.
        ///</summary>
        /// <param name="age_range_app"> </param>
        /// <param name="consent_commit_app"> </param>
        /// <param name="nullifier_app"> </param>
        public async Task SetVerifierApps(ulong age_range_app, ulong consent_commit_app, ulong nullifier_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 207, 68, 111 };
            var age_range_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); age_range_appAbi.From(age_range_app);
            var consent_commit_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_commit_appAbi.From(consent_commit_app);
            var nullifier_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nullifier_appAbi.From(nullifier_app);

            var result = await base.CallApp(new List<object> { abiHandle, age_range_appAbi, consent_commit_appAbi, nullifier_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVerifierApps_Transactions(ulong age_range_app, ulong consent_commit_app, ulong nullifier_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 207, 68, 111 };
            var age_range_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); age_range_appAbi.From(age_range_app);
            var consent_commit_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_commit_appAbi.From(consent_commit_app);
            var nullifier_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nullifier_appAbi.From(nullifier_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, age_range_appAbi, consent_commit_appAbi, nullifier_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a ZK-verified consent on-chain.
        ///IMPORTANT: `proof` and `public_inputs` MUST be the first two parameters so the AlgoPlonk-generated logicsig finds them at app_args[1] and app_args[2]. The logicsig verifies the PLONK proof before approving this transaction. If we reach this line, the proof was cryptographically valid — no trusted oracle.
        ///Duplicate submissions are rejected via the box key.
        ///</summary>
        /// <param name="proof"> </param>
        /// <param name="public_inputs"> </param>
        /// <param name="circuit_type"> </param>
        /// <param name="commitment"> </param>
        /// <param name="consent_app_id"> </param>
        public async Task SubmitZkConsent(byte[] proof, byte[] public_inputs, byte circuit_type, byte[] commitment, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 113, 17, 57 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_inputsAbi.From(public_inputs);
            var circuit_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); circuit_typeAbi.From(circuit_type);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, proofAbi, public_inputsAbi, circuit_typeAbi, commitmentAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitZkConsent_Transactions(byte[] proof, byte[] public_inputs, byte circuit_type, byte[] commitment, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 113, 17, 57 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_inputsAbi.From(public_inputs);
            var circuit_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); circuit_typeAbi.From(circuit_type);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofAbi, public_inputsAbi, circuit_typeAbi, commitmentAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a ZK-verified nullifier to prevent consent replay attacks.
        ///Called via AlgoPlonk nullifier logicsig transaction group. The nullifier = MiMC(IdentitySecret, ConsentID) is stored on-chain; subsequent attempts with the same nullifier will revert.
        ///</summary>
        /// <param name="proof"> </param>
        /// <param name="public_inputs"> </param>
        /// <param name="nullifier"> </param>
        /// <param name="consent_hash"> </param>
        /// <param name="consent_app_id"> </param>
        public async Task SubmitZkNullifier(byte[] proof, byte[] public_inputs, byte[] nullifier, byte[] consent_hash, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 105, 58, 143 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_inputsAbi.From(public_inputs);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); consent_hashAbi.From(consent_hash);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, proofAbi, public_inputsAbi, nullifierAbi, consent_hashAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitZkNullifier_Transactions(byte[] proof, byte[] public_inputs, byte[] nullifier, byte[] consent_hash, ulong consent_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 105, 58, 143 };
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proofAbi.From(proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_inputsAbi.From(public_inputs);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); consent_hashAbi.From(consent_hash);
            var consent_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); consent_app_idAbi.From(consent_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proofAbi, public_inputsAbi, nullifierAbi, consent_hashAbi, consent_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns True if the user has a ZK-verified consent with this commitment.
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="commitment"> </param>
        public async Task<bool> IsConsentZkVerified(Algorand.Address user, byte[] commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 254, 38, 20 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi, commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsConsentZkVerified_Transactions(Algorand.Address user, byte[] commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 254, 38, 20 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns True if this nullifier has already been used (replay protection).
        ///</summary>
        /// <param name="nullifier"> </param>
        /// <param name="consent_hash"> </param>
        public async Task<bool> IsNullifierUsed(byte[] nullifier, byte[] consent_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 222, 95, 187 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); consent_hashAbi.From(consent_hash);

            var result = await base.SimApp(new List<object> { abiHandle, nullifierAbi, consent_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsNullifierUsed_Transactions(byte[] nullifier, byte[] consent_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 222, 95, 187 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); consent_hashAbi.From(consent_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, nullifierAbi, consent_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the round at which the consent was ZK-verified (0 if not verified).
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="commitment"> </param>
        public async Task<ulong> GetVerifiedRound(Algorand.Address user, byte[] commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 128, 57, 6 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi, commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetVerifiedRound_Transactions(Algorand.Address user, byte[] commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 128, 57, 6 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGxvbmtaS1ZlcmlmaWVyQ29udHJhY3QiLCJkZXNjIjoiXG4gICAgVHJ1c3RsZXNzIFBMT05LIFpLIHZlcmlmaWVyIGZvciBDb25zZW50TGVkZ2VyLlxuXG4gICAgVGhpcyBjb250cmFjdCBkb2VzIE5PVCBwZXJmb3JtIHRoZSBwcm9vZiB2ZXJpZmljYXRpb24gaXRzZWxmIOKAlCB0aGUgQVZNXG4gICAgY2Fubm90IGFmZm9yZCB0aGUgfjE0NWsgb3Bjb2RlIGJ1ZGdldCBpbmxpbmUuIEluc3RlYWQ6XG5cbiAgICAxLiBUaGUgQWxnb1Bsb25rLWdlbmVyYXRlZCBMT0dJQ1NJRyB2ZXJpZmllciAoYSBzZXBhcmF0ZSAudGVhbCBmaWxlKSBydW5zIGFzXG4gICAgICAgdGhlIHRyYW5zYWN0aW9uIHNpZ25lciBmb3IgY2FsbHMgdG8gdGhpcyBjb250cmFjdC5cbiAgICAyLiBJZiB0aGUgUExPTksgcHJvb2YgaXMgdmFsaWQsIHRoZSBsb2dpY3NpZyBhcHByb3ZlcyDihpIgdGhpcyBtZXRob2QgZXhlY3V0ZXMuXG4gICAgMy4gVGhpcyBtZXRob2QgcmVjb3JkcyB0aGUgdmVyaWZpZWQgY29uc2VudCBjb21taXRtZW50IG9uLWNoYWluLlxuICAgIDQuIENvbnNlbnRMZWRnZXIgcmVhZHMgaXNfY29uc2VudF96a192ZXJpZmllZCgpIGJlZm9yZSBncmFudGluZyBhY2Nlc3MuXG5cbiAgICBUaGUgc2VjdXJpdHkgZ3VhcmFudGVlOiB0aGlzIG1ldGhvZCBjYW4gT05MWSBiZSBjYWxsZWQgaWYgdGhlIGxvZ2ljc2lnXG4gICAgYXBwcm92ZWQgdGhlIHRyYW5zYWN0aW9uLCB3aGljaCByZXF1aXJlcyBhIHZhbGlkIFBMT05LIHByb29mIGFzIGlucHV0LlxuICAgIE5vIGJhY2tlbmQgY2FuIGZvcmdlIHRoaXMg4oCUIGl0J3MgZW5mb3JjZWQgYnkgdGhlIEFWTSBpdHNlbGYuXG5cbiAgICBCb3gga2V5ID0gc2hhMjU2KHVzZXJfYWRkcmVzcygzMikgfHwgY29tbWl0bWVudCgzMikpIOKAlCAzMiBieXRlcywgQVZNLXNhZmUuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlZlcmlmaWVkQ29uc2VudFJlY29yZCI6W3sibmFtZSI6ImNpcmN1aXRfdHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImNvbW1pdG1lbnQiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoidmVyaWZpZWRfcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29uc2VudF9hcHBfaWQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF9jb25zZW50X2xlZGdlcl9hcHAiLCJkZXNjIjoiTGluayB0byB0aGUgQ29uc2VudExlZGdlciBjb250cmFjdC4gQ3JlYXRvci1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3ZlcmlmaWVyX2FwcHMiLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIEFsZ29QbG9uayB2ZXJpZmllciBhcHAgSURzLiBDcmVhdG9yLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZV9yYW5nZV9hcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnNlbnRfY29tbWl0X2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVsbGlmaWVyX2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfemtfY29uc2VudCIsImRlc2MiOiJSZWNvcmQgYSBaSy12ZXJpZmllZCBjb25zZW50IG9uLWNoYWluLlxuSU1QT1JUQU5UOiBgcHJvb2ZgIGFuZCBgcHVibGljX2lucHV0c2AgTVVTVCBiZSB0aGUgZmlyc3QgdHdvIHBhcmFtZXRlcnMgc28gdGhlIEFsZ29QbG9uay1nZW5lcmF0ZWQgbG9naWNzaWcgZmluZHMgdGhlbSBhdCBhcHBfYXJnc1sxXSBhbmQgYXBwX2FyZ3NbMl0uIFRoZSBsb2dpY3NpZyB2ZXJpZmllcyB0aGUgUExPTksgcHJvb2YgYmVmb3JlIGFwcHJvdmluZyB0aGlzIHRyYW5zYWN0aW9uLiBJZiB3ZSByZWFjaCB0aGlzIGxpbmUsIHRoZSBwcm9vZiB3YXMgY3J5cHRvZ3JhcGhpY2FsbHkgdmFsaWQg4oCUIG5vIHRydXN0ZWQgb3JhY2xlLlxuRHVwbGljYXRlIHN1Ym1pc3Npb25zIGFyZSByZWplY3RlZCB2aWEgdGhlIGJveCBrZXkuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNfaW5wdXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNpcmN1aXRfdHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWl0bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc2VudF9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0X3prX251bGxpZmllciIsImRlc2MiOiJSZWNvcmQgYSBaSy12ZXJpZmllZCBudWxsaWZpZXIgdG8gcHJldmVudCBjb25zZW50IHJlcGxheSBhdHRhY2tzLlxuQ2FsbGVkIHZpYSBBbGdvUGxvbmsgbnVsbGlmaWVyIGxvZ2ljc2lnIHRyYW5zYWN0aW9uIGdyb3VwLiBUaGUgbnVsbGlmaWVyID0gTWlNQyhJZGVudGl0eVNlY3JldCwgQ29uc2VudElEKSBpcyBzdG9yZWQgb24tY2hhaW47IHN1YnNlcXVlbnQgYXR0ZW1wdHMgd2l0aCB0aGUgc2FtZSBudWxsaWZpZXIgd2lsbCByZXZlcnQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJsaWNfaW5wdXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWxsaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnNlbnRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc2VudF9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfY29uc2VudF96a192ZXJpZmllZCIsImRlc2MiOiJSZXR1cm5zIFRydWUgaWYgdGhlIHVzZXIgaGFzIGEgWkstdmVyaWZpZWQgY29uc2VudCB3aXRoIHRoaXMgY29tbWl0bWVudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pdG1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19udWxsaWZpZXJfdXNlZCIsImRlc2MiOiJSZXR1cm5zIFRydWUgaWYgdGhpcyBudWxsaWZpZXIgaGFzIGFscmVhZHkgYmVlbiB1c2VkIChyZXBsYXkgcHJvdGVjdGlvbikuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc2VudF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZlcmlmaWVkX3JvdW5kIiwiZGVzYyI6IlJldHVybnMgdGhlIHJvdW5kIGF0IHdoaWNoIHRoZSBjb25zZW50IHdhcyBaSy12ZXJpZmllZCAoMCBpZiBub3QgdmVyaWZpZWQpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWl0bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNDBdLCJlcnJvck1lc3NhZ2UiOiJDb25zZW50IGFscmVhZHkgcmVjb3JkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjFdLCJlcnJvck1lc3NhZ2UiOiJOdWxsaWZpZXIgYWxyZWFkeSB1c2VkIChyZXBsYXkgYXR0YWNrKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMCwyNTZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZlcmlmaWVkX2NvbnNlbnRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MSwyOTQsMzYyLDM3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OCwzMDEsMzY5LDM4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTcsMzkwLDM5OCw0NDYsNDU0LDQ4OCw0OTYsNTMwLDUzOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTQsMjM0LDI0MiwyNTAsMzI1LDQwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBek1pQXdJREVnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURkaE5tSXpZU0F3ZURFMU1XWTNZemMxSUNKamIyNXpaVzUwWDJ4bFpHZGxjbDloY0hBaUlDSmhaMlZmY21GdVoyVmZkbVZ5YVdacFpYSmZZWEJ3SWlBaVkyOXVjMlZ1ZEY5amIyMXRhWFJmZG1WeWFXWnBaWEpmWVhCd0lpQWliblZzYkdsbWFXVnlYM1psY21sbWFXVnlYMkZ3Y0NJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUbzRNUzA0TWdvZ0lDQWdMeThnSXlCTWFXNXJaV1FnUTI5dWMyVnVkRXhsWkdkbGNpQmhjSEF1SUZObGRDQndiM04wTFdSbGNHeHZlU0IyYVdFZ2MyVjBYMk52Ym5ObGJuUmZiR1ZrWjJWeVgyRndjQ2dwTGdvZ0lDQWdMeThnYzJWc1ppNWpiMjV6Wlc1MFgyeGxaR2RsY2w5aGNIQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU52Ym5ObGJuUmZiR1ZrWjJWeVgyRndjQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qZzNMVGt3Q2lBZ0lDQXZMeUFqSUZCbGNpMWphWEpqZFdsMElHeHZaMmxqYzJsbklIWmxjbWxtYVdWeUlHRndjQ0JKUkhNdUNpQWdJQ0F2THlBaklGUm9aWE5sSUdGeVpTQjBhR1VnUVd4bmIxQnNiMjVyTFdkbGJtVnlZWFJsWkNCc2IyZHBZM05wWnlCaGNIQnpJR1JsY0d4dmVXVmtJSFJ2SUhSb1pTQnVaWFIzYjNKckxnb2dJQ0FnTHk4Z0l5QlRaWFFnWW5rZ2RHaGxJR055WldGMGIzSWdZV1owWlhJZ1pHVndiRzk1YVc1bklHVmhZMmdnZG1WeWFXWnBaWEl1Q2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVjl5WVc1blpWOTJaWEpwWm1sbGNsOWhjSEFnSUNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRm5aVjl5WVc1blpWOTJaWEpwWm1sbGNsOWhjSEFpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdjMlZzWmk1amIyNXpaVzUwWDJOdmJXMXBkRjkyWlhKcFptbGxjbDloY0hBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltTnZibk5sYm5SZlkyOXRiV2wwWDNabGNtbG1hV1Z5WDJGd2NDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCelpXeG1MbTUxYkd4cFptbGxjbDkyWlhKcFptbGxjbDloY0hBZ0lDQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbTUxYkd4cFptbGxjbDkyWlhKcFptbGxjbDloY0hBaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWJHOXVhMXBMVm1WeWFXWnBaWEpEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFlLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGxpT0RJeU1HSmtJREI0WlRSalpqUTBObVlnTUhnd01EY3hNVEV6T1NBd2VHRTJOamt6WVRobUlEQjRZelJtWlRJMk1UUWdNSGc0T0dSbE5XWmlZaUF3ZURReE9EQXpPVEEySUM4dklHMWxkR2h2WkNBaWMyVjBYMk52Ym5ObGJuUmZiR1ZrWjJWeVgyRndjQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYM1psY21sbWFXVnlYMkZ3Y0hNb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMzVmliV2wwWDNwclgyTnZibk5sYm5Rb1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME9DeDFhVzUwT0Zzek1sMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OMVltMXBkRjk2YTE5dWRXeHNhV1pwWlhJb1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnBjMTlqYjI1elpXNTBYM3ByWDNabGNtbG1hV1ZrS0dGa1pISmxjM01zZFdsdWREaGJNekpkS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWx6WDI1MWJHeHBabWxsY2w5MWMyVmtLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwWDNabGNtbG1hV1ZrWDNKdmRXNWtLR0ZrWkhKbGMzTXNkV2x1ZERoYk16SmRLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSE5sZEY5amIyNXpaVzUwWDJ4bFpHZGxjbDloY0hBZ2MyVjBYM1psY21sbWFXVnlYMkZ3Y0hNZ2MzVmliV2wwWDNwclgyTnZibk5sYm5RZ2MzVmliV2wwWDNwclgyNTFiR3hwWm1sbGNpQnBjMTlqYjI1elpXNTBYM3ByWDNabGNtbG1hV1ZrSUdselgyNTFiR3hwWm1sbGNsOTFjMlZrSUdkbGRGOTJaWEpwWm1sbFpGOXliM1Z1WkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeHZibXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1VUd4dmJtdGFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVjMlYwWDJOdmJuTmxiblJmYkdWa1oyVnlYMkZ3Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlqYjI1elpXNTBYMnhsWkdkbGNsOWhjSEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3h2Ym10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0JqY21WaGRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnYzJWc1ppNWpiMjV6Wlc1MFgyeGxaR2RsY2w5aGNIQWdQU0JoY0hCZmFXUXVibUYwYVhabENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamIyNXpaVzUwWDJ4bFpHZGxjbDloY0hBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0d4dmJtdGZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVVR3h2Ym10YVMxWmxjbWxtYVdWeVEyOXVkSEpoWTNRdWMyVjBYM1psY21sbWFXVnlYMkZ3Y0hOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmZG1WeWFXWnBaWEpmWVhCd2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklITmxiR1l1WVdkbFgzSmhibWRsWDNabGNtbG1hV1Z5WDJGd2NDQWdJQ0FnUFNCaFoyVmZjbUZ1WjJWZllYQndMbTVoZEdsMlpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poWjJWZmNtRnVaMlZmZG1WeWFXWnBaWEpmWVhCd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklITmxiR1l1WTI5dWMyVnVkRjlqYjIxdGFYUmZkbVZ5YVdacFpYSmZZWEJ3SUQwZ1kyOXVjMlZ1ZEY5amIyMXRhWFJmWVhCd0xtNWhkR2wyWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTI5dWMyVnVkRjlqYjIxdGFYUmZkbVZ5YVdacFpYSmZZWEJ3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Ykc5dWExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TVRNS0lDQWdJQzh2SUhObGJHWXViblZzYkdsbWFXVnlYM1psY21sbWFXVnlYMkZ3Y0NBZ0lDQWdQU0J1ZFd4c2FXWnBaWEpmWVhCd0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYm5Wc2JHbG1hV1Z5WDNabGNtbG1hV1Z5WDJGd2NDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeHZibXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1VUd4dmJtdGFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVjM1ZpYldsMFgzcHJYMk52Ym5ObGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKdGFYUmZlbXRmWTI5dWMyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Ykc5dWExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUd0bGVTQTlJRzl3TG5Ob1lUSTFOaWhVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnWTI5dGJXbDBiV1Z1ZEM1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnWVhOelpYSjBJR3RsZVNCdWIzUWdhVzRnYzJWc1ppNTJaWEpwWm1sbFpGOWpiMjV6Wlc1MGN5d2dJa052Ym5ObGJuUWdZV3h5WldGa2VTQnlaV052Y21SbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNZVFppTTJFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNXpaVzUwSUdGc2NtVmhaSGtnY21WamIzSmtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hORFlLSUNBZ0lDOHZJSFpsY21sbWFXVmtYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Ykc5dWExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TkRNdE1UUTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQldaWEpwWm1sbFpFTnZibk5sYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1kybHlZM1ZwZEY5MGVYQmxQV05wY21OMWFYUmZkSGx3WlN3S0lDQWdJQzh2SUNBZ0lDQmpiMjF0YVhSdFpXNTBQV052YlcxcGRHMWxiblF1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhabGNtbG1hV1ZrWDNKdmRXNWtQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnWTI5dWMyVnVkRjloY0hCZmFXUTlZMjl1YzJWdWRGOWhjSEJmYVdRc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UUTVDaUFnSUNBdkx5QnpaV3htTG5abGNtbG1hV1ZrWDJOdmJuTmxiblJ6VzJ0bGVWMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1URTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeHZibXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1VUd4dmJtdGFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVjM1ZpYldsMFgzcHJYMjUxYkd4cFptbGxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMVltMXBkRjk2YTE5dWRXeHNhV1pwWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4dmJtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4dmJtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjeExURTNNZ29nSUNBZ0x5OGdJeUJPZFd4c2FXWnBaWElnYTJWNU9pQnphR0V5TlRZb2JuVnNiR2xtYVdWeUtETXlLU0I4ZkNCamIyNXpaVzUwWDJoaGMyZ29NeklwS1FvZ0lDQWdMeThnYTJWNUlEMGdiM0F1YzJoaE1qVTJLRzUxYkd4cFptbGxjaTVpZVhSbGN5QXJJR052Ym5ObGJuUmZhR0Z6YUM1aWVYUmxjeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3h2Ym10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVGN6Q2lBZ0lDQXZMeUJoYzNObGNuUWdhMlY1SUc1dmRDQnBiaUJ6Wld4bUxuWmxjbWxtYVdWa1gyTnZibk5sYm5SekxDQWlUblZzYkdsbWFXVnlJR0ZzY21WaFpIa2dkWE5sWkNBb2NtVndiR0Y1SUdGMGRHRmpheWtpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TjJFMllqTmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUblZzYkdsbWFXVnlJR0ZzY21WaFpIa2dkWE5sWkNBb2NtVndiR0Y1SUdGMGRHRmpheWtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJSFpsY21sbWFXVmtYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Ykc5dWExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TnpZS0lDQWdJQzh2SUdOcGNtTjFhWFJmZEhsd1pUMWhjbU0wTGxWSmJuUTRLRElwTENBZ0l5QnVkV3hzYVdacFpYSWdZMmx5WTNWcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE56VXRNVGd3Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JXWlhKcFptbGxaRU52Ym5ObGJuUlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZMmx5WTNWcGRGOTBlWEJsUFdGeVl6UXVWVWx1ZERnb01pa3NJQ0FqSUc1MWJHeHBabWxsY2lCamFYSmpkV2wwQ2lBZ0lDQXZMeUFnSUNBZ1kyOXRiV2wwYldWdWREMXVkV3hzYVdacFpYSXVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSFpsY21sbWFXVmtYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdZMjl1YzJWdWRGOWhjSEJmYVdROVkyOXVjMlZ1ZEY5aGNIQmZhV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qRTRNUW9nSUNBZ0x5OGdjMlZzWmk1MlpYSnBabWxsWkY5amIyNXpaVzUwYzF0clpYbGRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNiMjVyWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnNiMjVyWDNabGNtbG1hV1Z5TG1OdmJuUnlZV04wTGxCc2IyNXJXa3RXWlhKcFptbGxja052Ym5SeVlXTjBMbWx6WDJOdmJuTmxiblJmZW10ZmRtVnlhV1pwWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMTlqYjI1elpXNTBYM3ByWDNabGNtbG1hV1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakU0TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklHdGxlU0E5SUc5d0xuTm9ZVEkxTmloMWMyVnlMbUo1ZEdWeklDc2dZMjl0YldsMGJXVnVkQzVpZVhSbGN5a0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3h2Ym10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJwWmlCclpYa2dibTkwSUdsdUlITmxiR1l1ZG1WeWFXWnBaV1JmWTI5dWMyVnVkSE02Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TjJFMllqTmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHbHpYMk52Ym5ObGJuUmZlbXRmZG1WeWFXWnBaV1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0NtbHpYMk52Ym5ObGJuUmZlbXRmZG1WeWFXWnBaV1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeHZibXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1VUd4dmJtdGFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVhWE5mWTI5dWMyVnVkRjk2YTE5MlpYSnBabWxsWkVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FYTmZZMjl1YzJWdWRGOTZhMTkyWlhKcFptbGxaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UazFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakU0TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQnBjMTlqYjI1elpXNTBYM3ByWDNabGNtbG1hV1ZrWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuQnNiMjVyWDNabGNtbG1hV1Z5TG1OdmJuUnlZV04wTGxCc2IyNXJXa3RXWlhKcFptbGxja052Ym5SeVlXTjBMbWx6WDJOdmJuTmxiblJmZW10ZmRtVnlhV1pwWldSQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3Ykc5dWExOTJaWEpwWm1sbGNpNWpiMjUwY21GamRDNVFiRzl1YTFwTFZtVnlhV1pwWlhKRGIyNTBjbUZqZEM1cGMxOXVkV3hzYVdacFpYSmZkWE5sWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpYMjUxYkd4cFptbGxjbDkxYzJWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pFNU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJR3RsZVNBOUlHOXdMbk5vWVRJMU5paHVkV3hzYVdacFpYSXVZbmwwWlhNZ0t5QmpiMjV6Wlc1MFgyaGhjMmd1WW5sMFpYTXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakl3TlFvZ0lDQWdMeThnYVdZZ2EyVjVJRzV2ZENCcGJpQnpaV3htTG5abGNtbG1hV1ZrWDJOdmJuTmxiblJ6T2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURkaE5tSXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQnBjMTl1ZFd4c2FXWnBaWEpmZFhObFpGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Ykc5dWExOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG95TURZS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9LYVhOZmJuVnNiR2xtYVdWeVgzVnpaV1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeHZibXRmZG1WeWFXWnBaWEl1WTI5dWRISmhZM1F1VUd4dmJtdGFTMVpsY21sbWFXVnlRMjl1ZEhKaFkzUXVhWE5mYm5Wc2JHbG1hV1Z5WDNWelpXUkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWx6WDI1MWJHeHBabWxsY2w5MWMyVmtYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHOXVhMTkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EY0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3h2Ym10ZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVGszQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlHbHpYMjUxYkd4cFptbGxjbDkxYzJWa1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJzYjI1clgzWmxjbWxtYVdWeUxtTnZiblJ5WVdOMExsQnNiMjVyV2t0V1pYSnBabWxsY2tOdmJuUnlZV04wTG1selgyNTFiR3hwWm1sbGNsOTFjMlZrUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjR3h2Ym10ZmRtVnlhV1pwWlhJdVkyOXVkSEpoWTNRdVVHeHZibXRhUzFabGNtbG1hV1Z5UTI5dWRISmhZM1F1WjJWMFgzWmxjbWxtYVdWa1gzSnZkVzVrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1psY21sbWFXVmtYM0p2ZFc1a09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pJd09Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiRzl1YTE5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3lNVFlLSUNBZ0lDOHZJR3RsZVNBOUlHOXdMbk5vWVRJMU5paDFjMlZ5TG1KNWRHVnpJQ3NnWTI5dGJXbDBiV1Z1ZEM1aWVYUmxjeWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4dmJtdGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCcFppQnJaWGtnYm05MElHbHVJSE5sYkdZdWRtVnlhV1pwWldSZlkyOXVjMlZ1ZEhNNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE4yRTJZak5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2daMlYwWDNabGNtbG1hV1ZrWDNKdmRXNWtYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0NncG5aWFJmZG1WeWFXWnBaV1JmY205MWJtUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y0d4dmJtdGZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVVR3h2Ym10YVMxWmxjbWxtYVdWeVEyOXVkSEpoWTNRdVoyVjBYM1psY21sbWFXVmtYM0p2ZFc1a1FEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeHZibXRmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qQTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmZG1WeWFXWnBaV1JmY205MWJtUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc2IyNXJYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkbVZ5YVdacFpXUmZZMjl1YzJWdWRITmJhMlY1WFM1MlpYSnBabWxsWkY5eWIzVnVaQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyWlhKcFptbGxaRjlqYjI1elpXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR1Y0ZEhKaFkzUWdNek1nT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzYjI1clgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQm5aWFJmZG1WeWFXWnBaV1JmY205MWJtUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y0d4dmJtdGZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVVR3h2Ym10YVMxWmxjbWxtYVdWeVEyOXVkSEpoWTNRdVoyVjBYM1psY21sbWFXVmtYM0p2ZFc1a1FEUUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFSUFBQkNDWUdBM3ByT2dRVkgzeDFFbU52Ym5ObGJuUmZiR1ZrWjJWeVgyRndjQlpoWjJWZmNtRnVaMlZmZG1WeWFXWnBaWEpmWVhCd0cyTnZibk5sYm5SZlkyOXRiV2wwWDNabGNtbG1hV1Z5WDJGd2NCWnVkV3hzYVdacFpYSmZkbVZ5YVdacFpYSmZZWEJ3TVJoQUFBNHFJMmNySTJjbkJDTm5Kd1VqWnpFYlFRQkFNUmtVUkRFWVJJSUhCSnVDSUwwRTVNOUVid1FBY1JFNUJLWnBPbzhFeFA0bUZBU0kzbCs3QkVHQU9RWTJHZ0NPQndBSkFCMEFUZ0NmQVBFQkd3RkZBREVaRkRFWUZCQkROaG9CU1JVbEVrUXhBRElKRWtRWEtreG5KRU0yR2dGSkZTVVNSRFlhQWtrVkpSSkVOaG9EU1JVbEVrUXhBRElKRWtSUEFoY3JUR2RNRnljRVRHY1hKd1ZNWnlSRE5ob0JTU05aZ1FJSVRCVVNSRFlhQWtraldZRUNDRXdWRWtRMkdnTkpGU1FTUkRZYUJFa1ZJaEpFTmhvRlNSVWxFa1F4QUVzQ1VBRW9URkJKdlVVQkZFUXlCaFpQQkU4RVVFeFFUd0pRdnlSRE5ob0JTU05aZ1FJSVRCVVNSRFlhQWtraldZRUNDRXdWRWtRMkdnTkpGU0lTUkRZYUJFa1ZJaEpFTmhvRlNSVWxFa1JMQWs4Q1VBRW9URkJKdlVVQkZFUXlCaGFBQVFKUEJGQk1VRThDVUw4a1F6WWFBVWtWSWhKRU5ob0NTUlVpRWtSUUFTaE1VTDFGQVVBQUNZQUJBQ2xNVUxBa1E0QUJnRUwvOURZYUFVa1ZJaEpFTmhvQ1NSVWlFa1JRQVNoTVVMMUZBVUFBQ1lBQkFDbE1VTEFrUTRBQmdFTC85RFlhQVVrVkloSkVOaG9DU1JVaUVrUlFBU2hNVUVtOVJRRkFBQkNBQ0FBQUFBQUFBQUFBS1V4UXNDUkRTYjVFVnlFSVF2L3giLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
