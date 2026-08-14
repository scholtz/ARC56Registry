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

namespace Arc56.Generated.ravi7657.Resume_to_Role_Match_Scorer.ResumeVerifier_172b93c0
{


    //
    // 
    //    ResumeVerifier — Resume Role Matcher on Algorand.
    //
    //    Contract account accumulates attestation fees (0.5 ALGO per attestation).
    //    Admin (deployer) can withdraw accumulated fees via withdraw_fees().
    //    
    //
    public class ResumeVerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ResumeVerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AttestationRecord : AVMObjectType
            {
                public string RoleId { get; set; }

                public ulong MatchScore { get; set; }

                public ulong AttestationRound { get; set; }

                public ulong FeePaid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRoleId.From(RoleId);
                    stringRef[ret.Count] = vRoleId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMatchScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMatchScore.From(MatchScore);
                    ret.AddRange(vMatchScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAttestationRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAttestationRound.From(AttestationRound);
                    ret.AddRange(vAttestationRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeePaid.From(FeePaid);
                    ret.AddRange(vFeePaid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AttestationRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AttestationRecord();
                    uint count = 0;
                    var indexRoleId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vRoleId.Decode(bytes.Skip(indexRoleId + prefixOffset).ToArray());
                    var valueRoleId = vRoleId.ToValue();
                    if (valueRoleId is string vRoleIdValue) { ret.RoleId = vRoleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMatchScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMatchScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMatchScore = vMatchScore.ToValue();
                    if (valueMatchScore is ulong vMatchScoreValue) { ret.MatchScore = vMatchScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAttestationRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAttestationRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAttestationRound = vAttestationRound.ToValue();
                    if (valueAttestationRound is ulong vAttestationRoundValue) { ret.AttestationRound = vAttestationRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeePaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeePaid = vFeePaid.ToValue();
                    if (valueFeePaid is ulong vFeePaidValue) { ret.FeePaid = vFeePaidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AttestationRecord);
                }
                public bool Equals(AttestationRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AttestationRecord left, AttestationRecord right)
                {
                    return EqualityComparer<AttestationRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AttestationRecord left, AttestationRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract on creation.  Must be the first call.
        ///Called by deploy_config.py immediately after contract creation.
        ///</summary>
        /// <param name="min_fee">Minimum payment required to register an attestation, in µALGO. For the MVP this is set to 500_000 (0.5 ALGO). </param>
        public async Task Bootstrap(ulong min_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 202, 223, 138 };
            var min_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_feeAbi.From(min_fee);

            var result = await base.CallApp(new List<object> { abiHandle, min_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong min_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 202, 223, 138 };
            var min_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_feeAbi.From(min_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a resume–role match attestation on-chain.
        ///This method MUST be called as part of an atomic transaction group:   Group[0]: PaymentTransaction → this contract address, ≥ min_fee µALGO   Group[1]: ApplicationCallTransaction → this method
        ///The AVM enforces atomicity: if any assertion fails, BOTH transactions in the group are rejected and the payment is not made.
        ///Only the resume SHA-256 hash (not the resume content) and attestation metadata are stored on-chain.  No PII is stored.
        ///A second attestation for the same (applicant, resume_hash) pair will overwrite the previous record (e.g. re-attesting after a score update).
        ///</summary>
        /// <param name="resume_hash">SHA-256 hash of the resume file (exactly 32 bytes). </param>
        /// <param name="role_id">Short identifier for the job role (e.g. "backend-engineer"). </param>
        /// <param name="match_score">Deterministic match score 0–100 computed by the scoring engine. </param>
        /// <param name="payment">Reference to the grouped PaymentTransaction (group index 0). </param>
        public async Task<string> RegisterAttestation(PaymentTransaction payment, byte[] resume_hash, string role_id, ulong match_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 31, 82, 25, 142 };
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); role_idAbi.From(role_id);
            var match_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); match_scoreAbi.From(match_score);

            var result = await base.CallApp(new List<object> { abiHandle, resume_hashAbi, role_idAbi, match_scoreAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterAttestation_Transactions(PaymentTransaction payment, byte[] resume_hash, string role_id, ulong match_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 31, 82, 25, 142 };
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);
            var role_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); role_idAbi.From(role_id);
            var match_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); match_scoreAbi.From(match_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, resume_hashAbi, role_idAbi, match_scoreAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve the full attestation record for a given applicant and resume hash.
        ///Callable by anyone (employer, auditor, third party). Reverts if no attestation exists.
        ///</summary>
        /// <param name="applicant">Wallet address of the applicant who registered the attestation. </param>
        /// <param name="resume_hash">SHA-256 hash of the resume file (32 bytes). </param>
        public async Task<Structs.AttestationRecord> GetAttestation(Algorand.Address applicant, byte[] resume_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 249, 20, 187 };
            var applicantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); applicantAbi.From(applicant);
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);

            var result = await base.SimApp(new List<object> { abiHandle, applicantAbi, resume_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AttestationRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAttestation_Transactions(Algorand.Address applicant, byte[] resume_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 249, 20, 187 };
            var applicantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); applicantAbi.From(applicant);
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, applicantAbi, resume_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Quick existence check: does an attestation exist for this (applicant, resume_hash)?
        ///Does NOT revert — returns False if not found. Useful for a simple verified / not-verified badge in the employer UI.
        ///</summary>
        /// <param name="applicant">Wallet address of the applicant. </param>
        /// <param name="resume_hash">SHA-256 hash of the resume file (32 bytes). </param>
        public async Task<bool> VerifyResumeHash(Algorand.Address applicant, byte[] resume_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 30, 178, 35 };
            var applicantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); applicantAbi.From(applicant);
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);

            var result = await base.SimApp(new List<object> { abiHandle, applicantAbi, resume_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyResumeHash_Transactions(Algorand.Address applicant, byte[] resume_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 30, 178, 35 };
            var applicantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); applicantAbi.From(applicant);
            var resume_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); resume_hashAbi.From(resume_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, applicantAbi, resume_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only: transfer accumulated attestation fees from the contract to admin.
        ///Sends an inner PaymentTransaction from the contract account to the admin address. Only the admin (the address set during bootstrap) may call this.
        ///</summary>
        /// <param name="amount">Amount in µALGO to withdraw from the contract account. </param>
        public async Task WithdrawFees(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 19, 23, 81 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawFees_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 19, 23, 81 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVzdW1lVmVyaWZpZXIiLCJkZXNjIjoiXG4gICAgUmVzdW1lVmVyaWZpZXIg4oCUIFJlc3VtZSBSb2xlIE1hdGNoZXIgb24gQWxnb3JhbmQuXG5cbiAgICBDb250cmFjdCBhY2NvdW50IGFjY3VtdWxhdGVzIGF0dGVzdGF0aW9uIGZlZXMgKDAuNSBBTEdPIHBlciBhdHRlc3RhdGlvbikuXG4gICAgQWRtaW4gKGRlcGxveWVyKSBjYW4gd2l0aGRyYXcgYWNjdW11bGF0ZWQgZmVlcyB2aWEgd2l0aGRyYXdfZmVlcygpLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBdHRlc3RhdGlvblJlY29yZCI6W3sibmFtZSI6InJvbGVfaWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibWF0Y2hfc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXR0ZXN0YXRpb25fcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlX3BhaWQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBjb250cmFjdCBvbiBjcmVhdGlvbi4gIE11c3QgYmUgdGhlIGZpcnN0IGNhbGwuXG5DYWxsZWQgYnkgZGVwbG95X2NvbmZpZy5weSBpbW1lZGlhdGVseSBhZnRlciBjb250cmFjdCBjcmVhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2ZlZSIsImRlc2MiOiJNaW5pbXVtIHBheW1lbnQgcmVxdWlyZWQgdG8gcmVnaXN0ZXIgYW4gYXR0ZXN0YXRpb24sIGluIMK1QUxHTy4gRm9yIHRoZSBNVlAgdGhpcyBpcyBzZXQgdG8gNTAwXzAwMCAoMC41IEFMR08pLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3Rlcl9hdHRlc3RhdGlvbiIsImRlc2MiOiJSZWdpc3RlciBhIHJlc3VtZeKAk3JvbGUgbWF0Y2ggYXR0ZXN0YXRpb24gb24tY2hhaW4uXG5UaGlzIG1ldGhvZCBNVVNUIGJlIGNhbGxlZCBhcyBwYXJ0IG9mIGFuIGF0b21pYyB0cmFuc2FjdGlvbiBncm91cDogICBHcm91cFswXTogUGF5bWVudFRyYW5zYWN0aW9uIOKGkiB0aGlzIGNvbnRyYWN0IGFkZHJlc3MsIOKJpSBtaW5fZmVlIMK1QUxHTyAgIEdyb3VwWzFdOiBBcHBsaWNhdGlvbkNhbGxUcmFuc2FjdGlvbiDihpIgdGhpcyBtZXRob2RcblRoZSBBVk0gZW5mb3JjZXMgYXRvbWljaXR5OiBpZiBhbnkgYXNzZXJ0aW9uIGZhaWxzLCBCT1RIIHRyYW5zYWN0aW9ucyBpbiB0aGUgZ3JvdXAgYXJlIHJlamVjdGVkIGFuZCB0aGUgcGF5bWVudCBpcyBub3QgbWFkZS5cbk9ubHkgdGhlIHJlc3VtZSBTSEEtMjU2IGhhc2ggKG5vdCB0aGUgcmVzdW1lIGNvbnRlbnQpIGFuZCBhdHRlc3RhdGlvbiBtZXRhZGF0YSBhcmUgc3RvcmVkIG9uLWNoYWluLiAgTm8gUElJIGlzIHN0b3JlZC5cbkEgc2Vjb25kIGF0dGVzdGF0aW9uIGZvciB0aGUgc2FtZSAoYXBwbGljYW50LCByZXN1bWVfaGFzaCkgcGFpciB3aWxsIG92ZXJ3cml0ZSB0aGUgcHJldmlvdXMgcmVjb3JkIChlLmcuIHJlLWF0dGVzdGluZyBhZnRlciBhIHNjb3JlIHVwZGF0ZSkuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzdW1lX2hhc2giLCJkZXNjIjoiU0hBLTI1NiBoYXNoIG9mIHRoZSByZXN1bWUgZmlsZSAoZXhhY3RseSAzMiBieXRlcykuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlX2lkIiwiZGVzYyI6IlNob3J0IGlkZW50aWZpZXIgZm9yIHRoZSBqb2Igcm9sZSAoZS5nLiBcImJhY2tlbmQtZW5naW5lZXJcIikuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXRjaF9zY29yZSIsImRlc2MiOiJEZXRlcm1pbmlzdGljIG1hdGNoIHNjb3JlIDDigJMxMDAgY29tcHV0ZWQgYnkgdGhlIHNjb3JpbmcgZW5naW5lLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJSZWZlcmVuY2UgdG8gdGhlIGdyb3VwZWQgUGF5bWVudFRyYW5zYWN0aW9uIChncm91cCBpbmRleCAwKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiXCJBVFRFU1RFRFwiIG9uIHN1Y2Nlc3MuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2F0dGVzdGF0aW9uIiwiZGVzYyI6IlJldHJpZXZlIHRoZSBmdWxsIGF0dGVzdGF0aW9uIHJlY29yZCBmb3IgYSBnaXZlbiBhcHBsaWNhbnQgYW5kIHJlc3VtZSBoYXNoLlxuQ2FsbGFibGUgYnkgYW55b25lIChlbXBsb3llciwgYXVkaXRvciwgdGhpcmQgcGFydHkpLiBSZXZlcnRzIGlmIG5vIGF0dGVzdGF0aW9uIGV4aXN0cy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGxpY2FudCIsImRlc2MiOiJXYWxsZXQgYWRkcmVzcyBvZiB0aGUgYXBwbGljYW50IHdobyByZWdpc3RlcmVkIHRoZSBhdHRlc3RhdGlvbi4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzdW1lX2hhc2giLCJkZXNjIjoiU0hBLTI1NiBoYXNoIG9mIHRoZSByZXN1bWUgZmlsZSAoMzIgYnl0ZXMpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkF0dGVzdGF0aW9uUmVjb3JkIiwiZGVzYyI6IlRoZSBBdHRlc3RhdGlvblJlY29yZDogcm9sZV9pZCwgbWF0Y2hfc2NvcmUsIGF0dGVzdGF0aW9uX3JvdW5kLCBmZWVfcGFpZC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9yZXN1bWVfaGFzaCIsImRlc2MiOiJRdWljayBleGlzdGVuY2UgY2hlY2s6IGRvZXMgYW4gYXR0ZXN0YXRpb24gZXhpc3QgZm9yIHRoaXMgKGFwcGxpY2FudCwgcmVzdW1lX2hhc2gpP1xuRG9lcyBOT1QgcmV2ZXJ0IOKAlCByZXR1cm5zIEZhbHNlIGlmIG5vdCBmb3VuZC4gVXNlZnVsIGZvciBhIHNpbXBsZSB2ZXJpZmllZCAvIG5vdC12ZXJpZmllZCBiYWRnZSBpbiB0aGUgZW1wbG95ZXIgVUkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBsaWNhbnQiLCJkZXNjIjoiV2FsbGV0IGFkZHJlc3Mgb2YgdGhlIGFwcGxpY2FudC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzdW1lX2hhc2giLCJkZXNjIjoiU0hBLTI1NiBoYXNoIG9mIHRoZSByZXN1bWUgZmlsZSAoMzIgYnl0ZXMpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiBhbiBhdHRlc3RhdGlvbiBleGlzdHMsIEZhbHNlIG90aGVyd2lzZS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2ZlZXMiLCJkZXNjIjoiQWRtaW4tb25seTogdHJhbnNmZXIgYWNjdW11bGF0ZWQgYXR0ZXN0YXRpb24gZmVlcyBmcm9tIHRoZSBjb250cmFjdCB0byBhZG1pbi5cblNlbmRzIGFuIGlubmVyIFBheW1lbnRUcmFuc2FjdGlvbiBmcm9tIHRoZSBjb250cmFjdCBhY2NvdW50IHRvIHRoZSBhZG1pbiBhZGRyZXNzLiBPbmx5IHRoZSBhZG1pbiAodGhlIGFkZHJlc3Mgc2V0IGR1cmluZyBib290c3RyYXApIG1heSBjYWxsIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgaW4gwrVBTEdPIHRvIHdpdGhkcmF3IGZyb20gdGhlIGNvbnRyYWN0IGFjY291bnQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjoiTWF0Y2ggc2NvcmUgbXVzdCBiZSBiZXR3ZWVuIDAgYW5kIDEwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6Ik5vIGF0dGVzdGF0aW9uIGZvdW5kIGZvciB0aGlzIGFwcGxpY2FudCBhbmQgcmVzdW1lIGhhc2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBhZG1pbiBtYXkgd2l0aGRyYXcgZmVlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgYW1vdW50IGlzIGJlbG93IHRoZSBtaW5pbXVtIGF0dGVzdGF0aW9uIGZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgcmVjZWl2ZXIgbXVzdCBiZSB0aGlzIGNvbnRyYWN0J3MgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taW5fZmVlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIsMjI2LDIzNCwyNTYsMjY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0LDEzNCwyODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlXUnRhVzRpSUNKdGFXNWZabVZsSWlBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemRXMWxYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCamJHRnpjeUJTWlhOMWJXVldaWEpwWm1sbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREZtTlRJeE9UaGxJREI0TW1KbU9URTBZbUlnTUhnNE5URmxZakl5TXlBd2VEQmtNVE14TnpVeElDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZWFIwWlhOMFlYUnBiMjRvWW5sMFpWc3pNbDBzYzNSeWFXNW5MSFZwYm5RMk5DeHdZWGtwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZllYUjBaWE4wWVhScGIyNG9ZV1JrY21WemN5eGllWFJsV3pNeVhTa29jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYM0psYzNWdFpWOW9ZWE5vS0dGa1pISmxjM01zWW5sMFpWc3pNbDBwWW05dmJDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZGZabVZsY3loMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWjJsemRHVnlYMkYwZEdWemRHRjBhVzl1SUdkbGRGOWhkSFJsYzNSaGRHbHZiaUIyWlhKcFpubGZjbVZ6ZFcxbFgyaGhjMmdnZDJsMGFHUnlZWGRmWm1WbGN3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdZMnhoYzNNZ1VtVnpkVzFsVm1WeWFXWnBaWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRXdZMkZrWmpoaElDOHZJRzFsZEdodlpDQWlZbTl2ZEhOMGNtRndLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0NpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ6ZFcxbFgzWmxjbWxtYVdWeUxtTnZiblJ5WVdOMExsSmxjM1Z0WlZabGNtbG1hV1Z5TG1KdmIzUnpkSEpoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE4xYldWZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMzVnRaVjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklITmxiR1l1YldsdVgyWmxaUzUyWVd4MVpTQTlJRzFwYmw5bVpXVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMXBibDltWldVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMzVnRaVjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOMWJXVmZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVVbVZ6ZFcxbFZtVnlhV1pwWlhJdWNtVm5hWE4wWlhKZllYUjBaWE4wWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjbDloZEhSbGMzUmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOMWJXVmZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hOVE1LSUNBZ0lDOHZJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpkVzFsWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qRTFNQzB4TlRRS0lDQWdJQzh2SUNNZ0xTMHRJRkJoZVcxbGJuUWdjbVZqWldsMlpYSWdkbUZzYVdSaGRHbHZiaUF0TFMwS0lDQWdJQzh2SUNNZ1ZHaGxJSEJoZVcxbGJuUWdUVlZUVkNCbmJ5QjBieUIwYUdseklITndaV05wWm1saklHTnZiblJ5WVdOMExDQnViM1FnWVc1NUlHOTBhR1Z5SUdGa1pISmxjM011Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lsQmhlVzFsYm5RZ2NtVmpaV2wyWlhJZ2JYVnpkQ0JpWlNCMGFHbHpJR052Ym5SeVlXTjBKM01nWVdSa2NtVnpjeUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElISmxZMlZwZG1WeUlHMTFjM1FnWW1VZ2RHaHBjeUJqYjI1MGNtRmpkQ2R6SUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE4xYldWZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJ3WVhsdFpXNTBMbUZ0YjNWdWRDQStQU0J6Wld4bUxtMXBibDltWldVdWRtRnNkV1VLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMXBibDltWldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV2x1WDJabFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzNWdFpWOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TlRZdE1UWXhDaUFnSUNBdkx5QWpJQzB0TFNCUVlYbHRaVzUwSUdGdGIzVnVkQ0IyWVd4cFpHRjBhVzl1SUMwdExRb2dJQ0FnTHk4Z0l5QlVhR1VnY0dGNWJXVnVkQ0JOVlZOVUlHMWxaWFFnZEdobElHMXBibWx0ZFcwZ1ptVmxJSE5sZENCaGRDQmliMjkwYzNSeVlYQWdkR2x0WlM0S0lDQWdJQzh2SUNNZ1ptVmxYM0JoYVdRZ2MzUnZjbVZ6SUhSb1pTQnlaV0ZzSUdGdGIzVnVkQ0JtY205dElIUm9aU0JoWTNSMVlXd2dVR0Y1YldWdWRGUjRiaURpZ0pRZ2JtOTBJR0VnWW05dmJHVmhiaTRLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkQzVoYlc5MWJuUWdQajBnYzJWc1ppNXRhVzVmWm1WbExuWmhiSFZsQ2lBZ0lDQXZMeUFwTENBaVVHRjViV1Z1ZENCaGJXOTFiblFnYVhNZ1ltVnNiM2NnZEdobElHMXBibWx0ZFcwZ1lYUjBaWE4wWVhScGIyNGdabVZsSWdvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdZVzF2ZFc1MElHbHpJR0psYkc5M0lIUm9aU0J0YVc1cGJYVnRJR0YwZEdWemRHRjBhVzl1SUdabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMzVnRaVjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5qTXRNVFkwQ2lBZ0lDQXZMeUFqSUMwdExTQlRZMjl5WlNCeVlXNW5aU0IyWVd4cFpHRjBhVzl1SUMwdExRb2dJQ0FnTHk4Z1lYTnpaWEowSUcxaGRHTm9YM05qYjNKbExtRnpYM1ZwYm5RMk5DZ3BJRHc5SUZWSmJuUTJOQ2d4TURBcExDQWlUV0YwWTJnZ2MyTnZjbVVnYlhWemRDQmlaU0JpWlhSM1pXVnVJREFnWVc1a0lERXdNQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElERXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCTllYUmphQ0J6WTI5eVpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01DQmhibVFnTVRBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemRXMWxYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pFMk5pMHhOamtLSUNBZ0lDOHZJQ01nTFMwdElFTnZibk4wY25WamRDQmliM2dnYTJWNUlDMHRMUW9nSUNBZ0x5OGdJeUJMWlhrZ1BTQmhjSEJzYVdOaGJuUWdkMkZzYkdWMElHRmtaSEpsYzNNZ1lubDBaWE1nS0RNeUtTQXJJSEpsYzNWdFpTQlRTRUV0TWpVMklHaGhjMmdnWW5sMFpYTWdLRE15S1NBOUlEWTBJR0o1ZEdWekNpQWdJQ0F2THlBaklGUm9hWE1nZFc1cGNYVmxiSGtnYVdSbGJuUnBabWxsY3lCbFlXTm9JQ2hoY0hCc2FXTmhiblFzSUhKbGMzVnRaU2tnWVhSMFpYTjBZWFJwYjI0dUNpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBcklISmxjM1Z0WlY5b1lYTm9MbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hOellLSUNBZ0lDOHZJR0YwZEdWemRHRjBhVzl1WDNKdmRXNWtQV0Z5WXpSVlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0tTd0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMzVnRaVjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE56Y0tJQ0FnSUM4dklHWmxaVjl3WVdsa1BXRnlZelJWU1c1ME5qUW9jR0Y1YldWdWRDNWhiVzkxYm5RcExDQWdJeUJTWldGc0lNSzFRVXhIVHlCbWNtOXRJSFJvWlNCUVlYbHRaVzUwVkhodUlPS0FsQ0J1YjNRZ1lTQm1iR0ZuQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UY3hMVEUzT0FvZ0lDQWdMeThnSXlBdExTMGdWM0pwZEdVZ1lYUjBaWE4wWVhScGIyNGdjbVZqYjNKa0lIUnZJRUp2ZUNCVGRHOXlZV2RsSUMwdExRb2dJQ0FnTHk4Z0l5QlBkbVZ5ZDNKcGRHVnpJR0Z1ZVNCbGVHbHpkR2x1WnlCeVpXTnZjbVFnWm05eUlIUm9hWE1nYTJWNUlDaHpZV1psSU9LQWxDQmhiR3h2ZDNNZ2NtVXRZWFIwWlhOMFlYUnBiMjRwTGdvZ0lDQWdMeThnYzJWc1ppNWhkSFJsYzNSaGRHbHZibk5iWW05NFgydGxlVjBnUFNCQmRIUmxjM1JoZEdsdmJsSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQnliMnhsWDJsa1BYSnZiR1ZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdiV0YwWTJoZmMyTnZjbVU5YldGMFkyaGZjMk52Y21Vc0NpQWdJQ0F2THlBZ0lDQWdZWFIwWlhOMFlYUnBiMjVmY205MWJtUTlZWEpqTkZWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJR1psWlY5d1lXbGtQV0Z5WXpSVlNXNTBOalFvY0dGNWJXVnVkQzVoYlc5MWJuUXBMQ0FnSXlCU1pXRnNJTUsxUVV4SFR5Qm1jbTl0SUhSb1pTQlFZWGx0Wlc1MFZIaHVJT0tBbENCdWIzUWdZU0JtYkdGbkNpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ERmhDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE4xYldWZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd09EUXhOVFExTkRRMU5UTTFORFExTkRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE4xYldWZmRtVnlhV1pwWlhJdVkyOXVkSEpoWTNRdVVtVnpkVzFsVm1WeWFXWnBaWEl1WjJWMFgyRjBkR1Z6ZEdGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyRjBkR1Z6ZEdGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemRXMWxYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pJd05Rb2dJQ0FnTHk4Z1ltOTRYMnRsZVNBOUlHRndjR3hwWTJGdWRDNWllWFJsY3lBcklISmxjM1Z0WlY5b1lYTm9MbUo1ZEdWekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qQTNDaUFnSUNBdkx5QmliM2hmYTJWNUlHbHVJSE5sYkdZdVlYUjBaWE4wWVhScGIyNXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzNWdFpWOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG95TURZdE1qQTRDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJR0p2ZUY5clpYa2dhVzRnYzJWc1ppNWhkSFJsYzNSaGRHbHZibk1LSUNBZ0lDOHZJQ2tzSUNKT2J5QmhkSFJsYzNSaGRHbHZiaUJtYjNWdVpDQm1iM0lnZEdocGN5QmhjSEJzYVdOaGJuUWdZVzVrSUhKbGMzVnRaU0JvWVhOb0lnb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHRjBkR1Z6ZEdGMGFXOXVJR1p2ZFc1a0lHWnZjaUIwYUdseklHRndjR3hwWTJGdWRDQmhibVFnY21WemRXMWxJR2hoYzJnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOMWJXVmZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWhkSFJsYzNSaGRHbHZibk5iWW05NFgydGxlVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE4xYldWZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNVGcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbGMzVnRaVjkyWlhKcFptbGxjaTVqYjI1MGNtRmpkQzVTWlhOMWJXVldaWEpwWm1sbGNpNTJaWEpwWm5sZmNtVnpkVzFsWDJoaGMyaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpubGZjbVZ6ZFcxbFgyaGhjMmc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6ZFcxbFgzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakl4TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qTXdDaUFnSUNBdkx5QmliM2hmYTJWNUlEMGdZWEJ3YkdsallXNTBMbUo1ZEdWeklDc2djbVZ6ZFcxbFgyaGhjMmd1WW5sMFpYTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3lNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQkNiMjlzS0dKdmVGOXJaWGtnYVc0Z2MyVnNaaTVoZEhSbGMzUmhkR2x2Ym5NcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qRXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsYzNWdFpWOTJaWEpwWm1sbGNpNWpiMjUwY21GamRDNVNaWE4xYldWV1pYSnBabWxsY2k1M2FYUm9aSEpoZDE5bVpXVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGRmWm1WbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTjFiV1ZmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qTTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOMWJXVmZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlUMjVzZVNCMGFHVWdZV1J0YVc0Z2JXRjVJSGRwZEdoa2NtRjNJR1psWlhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhSb1pTQmhaRzFwYmlCdFlYa2dkMmwwYUdSeVlYY2dabVZsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzNWdFpWOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG95TlRNdE1qVTRDaUFnSUNBdkx5QWpJRWx1Ym1WeUlIUnlZVzV6WVdOMGFXOXVPaUJqYjI1MGNtRmpkQ0JoWTJOdmRXNTBJT0tHa2lCaFpHMXBiZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1WVdSdGFXNHVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjM1Z0WlY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3lOVGNLSUNBZ0lDOHZJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0JuYkc5aVlXd2dUV2x1VkhodVJtVmxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemRXMWxYM1psY21sbWFXVnlMMk52Ym5SeVlXTjBMbkI1T2pJMU15MHlOVFFLSUNBZ0lDOHZJQ01nU1c1dVpYSWdkSEpoYm5OaFkzUnBiMjQ2SUdOdmJuUnlZV04wSUdGalkyOTFiblFnNG9hU0lHRmtiV2x1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzNWdFpWOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG95TlRNdE1qVTRDaUFnSUNBdkx5QWpJRWx1Ym1WeUlIUnlZVzV6WVdOMGFXOXVPaUJqYjI1MGNtRmpkQ0JoWTJOdmRXNTBJT0tHa2lCaFpHMXBiZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1WVdSdGFXNHVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE4xYldWZmRtVnlhV1pwWlhJdlkyOXVkSEpoWTNRdWNIazZNak0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBU0FBQ0NZREJXRmtiV2x1QjIxcGJsOW1aV1VFRlI5OGRURVpGRVF4R0VFQUpJSUVCQjlTR1k0RUsva1V1d1NGSHJJakJBMFRGMUUyR2dDT0JBQWhBSk1Bc1FEU0FJQUVvTXJmaWpZYUFJNEJBQUVBTmhvQlNSVWxFa1FYS0RFQVp5bE1aeUpETmhvQlNSVWpFa1EyR2dKSkpGbUJBZ2hMQVJVU1JEWWFBMGtWSlJKRU1SWWlDVWs0RUNJU1JFazRCeklLRWtRNENDUXBaVVJMQVE1RVN3RVhnV1FPUkRFQVR3UlFNZ1lXVHdJV2dBSUFHazhFVUU4Q1VFeFFUd0pRU3dHOFNMK0FEaFVmZkhVQUNFRlVWRVZUVkVWRXNDSkROaG9CU1JVakVrUTJHZ0pKRlNNU1JGQkp2VVVCUkw1SUtreFFzQ0pETmhvQlNSVWpFa1EyR2dKSkZTTVNSRkM5UlFHQUFRQWtUd0pVS2t4UXNDSkROaG9CU1JVbEVrUVhNUUFrS0dWRVRFc0JFa1N4TWdCUEFySUlUTElISXJJUXNnR3pJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
