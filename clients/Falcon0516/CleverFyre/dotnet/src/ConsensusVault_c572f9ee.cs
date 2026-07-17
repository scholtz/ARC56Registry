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

namespace Arc56.Generated.Falcon0516.CleverFyre.ConsensusVault_c572f9ee
{


    //
    // 
    //    M-of-N on-chain consent gating for payments above consensus_threshold_algo.
    //
    //    Workflow:
    //      1. SentinelEscrow calls open_consensus()  -> creates ConsensusRecord.
    //      2. Each peer agent calls submit_consent()  -> increments collected.
    //      3. Any party calls execute_if_consensus()  -> triggers escrow release.
    //      4. After deadline, anyone calls timeout_reject() -> triggers refund.
    //
    //    Note prefix on all inner txns: b"x402:axiom:consensus"
    //    
    //
    public class ConsensusVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConsensusVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConsensusRecord : AVMObjectType
            {
                public byte[] EscrowId { get; set; }

                public ulong RequiredApprovals { get; set; }

                public ulong Collected { get; set; }

                public ulong DeadlineRound { get; set; }

                public ulong Resolved { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vEscrowId.From(EscrowId);
                    ret.AddRange(vEscrowId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequiredApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRequiredApprovals.From(RequiredApprovals);
                    ret.AddRange(vRequiredApprovals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCollected.From(Collected);
                    ret.AddRange(vCollected.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadlineRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDeadlineRound.From(DeadlineRound);
                    ret.AddRange(vDeadlineRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResolved.From(Resolved);
                    ret.AddRange(vResolved.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConsensusRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ConsensusRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vEscrowId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowId = vEscrowId.ToValue();
                    if (valueEscrowId is byte[] vEscrowIdValue) { ret.EscrowId = vEscrowIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequiredApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRequiredApprovals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequiredApprovals = vRequiredApprovals.ToValue();
                    if (valueRequiredApprovals is ulong vRequiredApprovalsValue) { ret.RequiredApprovals = vRequiredApprovalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCollected.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollected = vCollected.ToValue();
                    if (valueCollected is ulong vCollectedValue) { ret.Collected = vCollectedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadlineRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDeadlineRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeadlineRound = vDeadlineRound.ToValue();
                    if (valueDeadlineRound is ulong vDeadlineRoundValue) { ret.DeadlineRound = vDeadlineRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolved = vResolved.ToValue();
                    if (valueResolved is ulong vResolvedValue) { ret.Resolved = vResolvedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConsensusRecord);
                }
                public bool Equals(ConsensusRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConsensusRecord left, ConsensusRecord right)
                {
                    return EqualityComparer<ConsensusRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ConsensusRecord left, ConsensusRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sentinel_escrow_app_id"> </param>
        public async Task Create(ulong sentinel_escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, sentinel_escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong sentinel_escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, sentinel_escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new consensus record.
        ///deadline_round = Global.round + 30  (~2 minutes on Algorand). Only SentinelEscrow or the contract creator should call this.
        ///</summary>
        /// <param name="payment_id"> </param>
        /// <param name="escrow_id"> </param>
        /// <param name="required"> </param>
        public async Task OpenConsensus(byte[] payment_id, byte[] escrow_id, ulong required, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 151, 190, 73 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredAbi.From(required);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi, escrow_idAbi, requiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenConsensus_Transactions(byte[] payment_id, byte[] escrow_id, ulong required, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 151, 190, 73 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredAbi.From(required);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi, escrow_idAbi, requiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///A peer agent submits consent for the payment.
        ///Each address may only consent once (bitmap check via BoxMap). consent_hash : sha256(payment_id + peer_address) — prevents replay.
        ///</summary>
        /// <param name="payment_id"> </param>
        /// <param name="consent_hash"> </param>
        public async Task SubmitConsent(byte[] payment_id, byte[] consent_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 219, 253, 158 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); consent_hashAbi.From(consent_hash);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi, consent_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitConsent_Transactions(byte[] payment_id, byte[] consent_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 219, 253, 158 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);
            var consent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); consent_hashAbi.From(consent_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi, consent_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if collected >= required; if so, mark resolved=1.
        ///Returns 1 if consensus was reached, 0 if still waiting. The SDK layer then calls SentinelEscrow.release() in the same atomic group.
        ///</summary>
        /// <param name="payment_id"> </param>
        public async Task<ulong> ExecuteIfConsensus(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 246, 119, 35 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExecuteIfConsensus_Transactions(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 246, 119, 35 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///After deadline passes, mark resolved=2 (timed out / rejected).
        ///SDK layer then calls SentinelEscrow.refund() atomically.
        ///</summary>
        /// <param name="payment_id"> </param>
        public async Task TimeoutReject(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 54, 33, 0 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TimeoutReject_Transactions(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 54, 33, 0 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns resolved field: 0=pending, 1=executed, 2=rejected/timed-out.
        ///</summary>
        /// <param name="payment_id"> </param>
        public async Task<ulong> GetConsensusStatus(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 231, 48, 77 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetConsensusStatus_Transactions(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 231, 48, 77 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns how many consents have been collected so far.
        ///</summary>
        /// <param name="payment_id"> </param>
        public async Task<ulong> GetCollected(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 63, 89, 55 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCollected_Transactions(byte[] payment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 63, 89, 55 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payment_idAbi.From(payment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc2Vuc3VzVmF1bHQiLCJkZXNjIjoiXG4gICAgTS1vZi1OIG9uLWNoYWluIGNvbnNlbnQgZ2F0aW5nIGZvciBwYXltZW50cyBhYm92ZSBjb25zZW5zdXNfdGhyZXNob2xkX2FsZ28uXG5cbiAgICBXb3JrZmxvdzpcbiAgICAgIDEuIFNlbnRpbmVsRXNjcm93IGNhbGxzIG9wZW5fY29uc2Vuc3VzKCkgIC0+IGNyZWF0ZXMgQ29uc2Vuc3VzUmVjb3JkLlxuICAgICAgMi4gRWFjaCBwZWVyIGFnZW50IGNhbGxzIHN1Ym1pdF9jb25zZW50KCkgIC0+IGluY3JlbWVudHMgY29sbGVjdGVkLlxuICAgICAgMy4gQW55IHBhcnR5IGNhbGxzIGV4ZWN1dGVfaWZfY29uc2Vuc3VzKCkgIC0+IHRyaWdnZXJzIGVzY3JvdyByZWxlYXNlLlxuICAgICAgNC4gQWZ0ZXIgZGVhZGxpbmUsIGFueW9uZSBjYWxscyB0aW1lb3V0X3JlamVjdCgpIC0+IHRyaWdnZXJzIHJlZnVuZC5cblxuICAgIE5vdGUgcHJlZml4IG9uIGFsbCBpbm5lciB0eG5zOiBiXCJ4NDAyOmF4aW9tOmNvbnNlbnN1c1wiXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNvbnNlbnN1c1JlY29yZCI6W3sibmFtZSI6ImVzY3Jvd19pZCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJyZXF1aXJlZF9hcHByb3ZhbHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29sbGVjdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlYWRsaW5lX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlc29sdmVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VudGluZWxfZXNjcm93X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuX2NvbnNlbnN1cyIsImRlc2MiOiJDcmVhdGUgYSBuZXcgY29uc2Vuc3VzIHJlY29yZC5cbmRlYWRsaW5lX3JvdW5kID0gR2xvYmFsLnJvdW5kICsgMzAgICh+MiBtaW51dGVzIG9uIEFsZ29yYW5kKS4gT25seSBTZW50aW5lbEVzY3JvdyBvciB0aGUgY29udHJhY3QgY3JlYXRvciBzaG91bGQgY2FsbCB0aGlzLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVpcmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9jb25zZW50IiwiZGVzYyI6IkEgcGVlciBhZ2VudCBzdWJtaXRzIGNvbnNlbnQgZm9yIHRoZSBwYXltZW50LlxuRWFjaCBhZGRyZXNzIG1heSBvbmx5IGNvbnNlbnQgb25jZSAoYml0bWFwIGNoZWNrIHZpYSBCb3hNYXApLiBjb25zZW50X2hhc2ggOiBzaGEyNTYocGF5bWVudF9pZCArIHBlZXJfYWRkcmVzcykg4oCUIHByZXZlbnRzIHJlcGxheS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc2VudF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfaWZfY29uc2Vuc3VzIiwiZGVzYyI6IkNoZWNrIGlmIGNvbGxlY3RlZCA+PSByZXF1aXJlZDsgaWYgc28sIG1hcmsgcmVzb2x2ZWQ9MS5cblJldHVybnMgMSBpZiBjb25zZW5zdXMgd2FzIHJlYWNoZWQsIDAgaWYgc3RpbGwgd2FpdGluZy4gVGhlIFNESyBsYXllciB0aGVuIGNhbGxzIFNlbnRpbmVsRXNjcm93LnJlbGVhc2UoKSBpbiB0aGUgc2FtZSBhdG9taWMgZ3JvdXAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0aW1lb3V0X3JlamVjdCIsImRlc2MiOiJBZnRlciBkZWFkbGluZSBwYXNzZXMsIG1hcmsgcmVzb2x2ZWQ9MiAodGltZWQgb3V0IC8gcmVqZWN0ZWQpLlxuU0RLIGxheWVyIHRoZW4gY2FsbHMgU2VudGluZWxFc2Nyb3cucmVmdW5kKCkgYXRvbWljYWxseS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29uc2Vuc3VzX3N0YXR1cyIsImRlc2MiOiJSZXR1cm5zIHJlc29sdmVkIGZpZWxkOiAwPXBlbmRpbmcsIDE9ZXhlY3V0ZWQsIDI9cmVqZWN0ZWQvdGltZWQtb3V0LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbGxlY3RlZCIsImRlc2MiOiJSZXR1cm5zIGhvdyBtYW55IGNvbnNlbnRzIGhhdmUgYmVlbiBjb2xsZWN0ZWQgc28gZmFyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MzcsNTY4XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSByZXNvbHZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6ImNvbnNlbnN1cyBhbHJlYWR5IG9wZW4gZm9yIHRoaXMgcGF5bWVudF9pZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwM10sImVycm9yTWVzc2FnZSI6ImNvbnNlbnN1cyBhbHJlYWR5IHJlc29sdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3XSwiZXJyb3JNZXNzYWdlIjoiY29uc2Vuc3VzIGRlYWRsaW5lIHBhc3NlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Nl0sImVycm9yTWVzc2FnZSI6ImNvbnNlbnRfaGFzaCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgyXSwiZXJyb3JNZXNzYWdlIjoiZGVhZGxpbmUgbm90IHlldCBwYXNzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJlc2Nyb3dfaWQgbXVzdCBiZSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMCwzMTEsMzU4LDM2NSw0MzQsNDQyLDQ0OSw0ODMsNTY1LDU3Niw2MDYsNjEzLDY3OCw3MTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3LDE1MywyNDcsMjYzLDQxMCw1NDIsNjU2LDY5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NCwxNjAsMjU0LDI3MCw0MTcsNTQ5LDY2Myw2OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1LDE3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwOF0sImVycm9yTWVzc2FnZSI6Im5vIGNvbnNlbnN1cyByZWNvcmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTUsNDI5LDU2MCw2NzRdLCJlcnJvck1lc3NhZ2UiOiJubyBjb25zZW5zdXMgcmVjb3JkIGZvciB0aGlzIHBheW1lbnRfaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzksMjgwXSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudF9pZCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjoicmVxdWlyZWQgbXVzdCBiZSA+PSAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMxXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb25zZW50IGFscmVhZHkgc3VibWl0dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeUlEZ2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TmpNM05qTmhJREI0TURBeU1pQXdlREUxTVdZM1l6YzFJQ0p6Wlc1MGFXNWxiRjloY0hCZmFXUWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNNUxUUXdDaUFnSUNBdkx5QWpJRlJ5ZFhOMFpXUWdjMlZ1ZEdsdVpXd2dZWEJ3SUNoelpYUWdiMjRnWTNKbFlYUmxLUW9nSUNBZ0x5OGdjMlZzWmk1elpXNTBhVzVsYkY5aGNIQmZhV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5ObGJuUnBibVZzWDJGd2NGOXBaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCamJHRnpjeUJEYjI1elpXNXpkWE5XWVhWc2RDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE5pT1RkaVpUUTVJREI0TkRSa1ltWmtPV1VnTUhneFlXWTJOemN5TXlBd2VEQTRNell5TVRBd0lEQjROelJsTnpNd05HUWdNSGhoTnpObU5Ua3pOeUF2THlCdFpYUm9iMlFnSW05d1pXNWZZMjl1YzJWdWMzVnpLR0o1ZEdWYlhTeGllWFJsVzEwc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW0xcGRGOWpiMjV6Wlc1MEtHSjVkR1ZiWFN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaWGhsWTNWMFpWOXBabDlqYjI1elpXNXpkWE1vWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR2x0Wlc5MWRGOXlaV3BsWTNRb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5amIyNXpaVzV6ZFhOZmMzUmhkSFZ6S0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5amIyeHNaV04wWldRb1lubDBaVnRkS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUc5d1pXNWZZMjl1YzJWdWMzVnpJSE4xWW0xcGRGOWpiMjV6Wlc1MElHVjRaV04xZEdWZmFXWmZZMjl1YzJWdWMzVnpJSFJwYldWdmRYUmZjbVZxWldOMElHZGxkRjlqYjI1elpXNXpkWE5mYzNSaGRIVnpJR2RsZEY5amIyeHNaV04wWldRS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuTmxibk4xYzFaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU5EQmtNbVkyTnlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNoMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuTjFjMTkyWVhWc2RDNWpiMjUwY21GamRDNURiMjV6Wlc1emRYTldZWFZzZEM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCelpXeG1Mbk5sYm5ScGJtVnNYMkZ3Y0Y5cFpDQTlJSE5sYm5ScGJtVnNYMlZ6WTNKdmQxOWhjSEJmYVdRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5ObGJuUnBibVZzWDJGd2NGOXBaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5OMWMxOTJZWFZzZEM1amIyNTBjbUZqZEM1RGIyNXpaVzV6ZFhOV1lYVnNkQzV2Y0dWdVgyTnZibk5sYm5OMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3Wlc1ZlkyOXVjMlZ1YzNWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1emRYTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgybGtMbXhsYm1kMGFDQTlQU0F6TWl3Z0luQmhlVzFsYm5SZmFXUWdiWFZ6ZENCaVpTQXpNaUJpZVhSbGN5SUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRGOXBaQ0J0ZFhOMElHSmxJRE15SUdKNWRHVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmhjM05sY25RZ1pYTmpjbTkzWDJsa0xteGxibWQwYUNBOVBTQXpNaXdnSW1WelkzSnZkMTlwWkNCdGRYTjBJR0psSURNeUlHSjVkR1Z6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWelkzSnZkMTlwWkNCdGRYTjBJR0psSURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ4ZFdseVpXUWdQajBnVlVsdWREWTBLREVwTENBaWNtVnhkV2x5WldRZ2JYVnpkQ0JpWlNBK1BTQXhJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaWEYxYVhKbFpDQnRkWE4wSUdKbElENDlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1emRYTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJR1Y0YVhOMGN5QTlJSEJoZVcxbGJuUmZhV1FnYVc0Z2MyVnNaaTVqYjI1elpXNXpkWE5mY21WamIzSmtjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl6TnpZellRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR1Y0YVhOMGN5d2dJbU52Ym5ObGJuTjFjeUJoYkhKbFlXUjVJRzl3Wlc0Z1ptOXlJSFJvYVhNZ2NHRjViV1Z1ZEY5cFpDSUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYjI1elpXNXpkWE1nWVd4eVpXRmtlU0J2Y0dWdUlHWnZjaUIwYUdseklIQmhlVzFsYm5SZmFXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklHUmxZV1JzYVc1bFgzSnZkVzVrUFVkc2IySmhiQzV5YjNWdVpDQXJJRlZKYm5RMk5DZ3pNQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lIQjFjMmhwYm5RZ016QUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TmprdE56VUtJQ0FnSUM4dklITmxiR1l1WTI5dWMyVnVjM1Z6WDNKbFkyOXlaSE5iY0dGNWJXVnVkRjlwWkYwZ1BTQkRiMjV6Wlc1emRYTlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdaWE5qY205M1gybGtQV1Z6WTNKdmQxOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpYRjFhWEpsWkY5aGNIQnliM1poYkhNOWNtVnhkV2x5WldRc0NpQWdJQ0F2THlBZ0lDQWdZMjlzYkdWamRHVmtQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXRmtiR2x1WlY5eWIzVnVaRDFIYkc5aVlXd3VjbTkxYm1RZ0t5QlZTVzUwTmpRb016QXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkbVZrUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURJeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklHTnZiR3hsWTNSbFpEMVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvMk9TMDNOUW9nSUNBZ0x5OGdjMlZzWmk1amIyNXpaVzV6ZFhOZmNtVmpiM0prYzF0d1lYbHRaVzUwWDJsa1hTQTlJRU52Ym5ObGJuTjFjMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JsYzJOeWIzZGZhV1E5WlhOamNtOTNYMmxrTEFvZ0lDQWdMeThnSUNBZ0lISmxjWFZwY21Wa1gyRndjSEp2ZG1Gc2N6MXlaWEYxYVhKbFpDd0tJQ0FnSUM4dklDQWdJQ0JqYjJ4c1pXTjBaV1E5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHUmxZV1JzYVc1bFgzSnZkVzVrUFVkc2IySmhiQzV5YjNWdVpDQXJJRlZKYm5RMk5DZ3pNQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiMngyWldROVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1YzNWelgzWmhkV3gwTG1OdmJuUnlZV04wTGtOdmJuTmxibk4xYzFaaGRXeDBMbk4xWW0xcGRGOWpiMjV6Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjM1ZpYldsMFgyTnZibk5sYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblJmYVdRdWJHVnVaM1JvSUQwOUlETXlMQ0FpY0dGNWJXVnVkRjlwWkNCdGRYTjBJR0psSURNeUlHSjVkR1Z6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCd1lYbHRaVzUwWDJsa0lHMTFjM1FnWW1VZ016SWdZbmwwWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVnlkQ0JqYjI1elpXNTBYMmhoYzJndWJHVnVaM1JvSUQwOUlETXlMQ0FpWTI5dWMyVnVkRjlvWVhOb0lHMTFjM1FnWW1VZ016SWdZbmwwWlhNaUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCamIyNXpaVzUwWDJoaGMyZ2diWFZ6ZENCaVpTQXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ2NHRjViV1Z1ZEY5cFpDQnBiaUJ6Wld4bUxtTnZibk5sYm5OMWMxOXlaV052Y21SekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qTTNOak5oQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0p1YnlCamIyNXpaVzV6ZFhNZ2NtVmpiM0prSUdadmNpQjBhR2x6SUhCaGVXMWxiblJmYVdRaUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1kyOXVjMlZ1YzNWeklISmxZMjl5WkNCbWIzSWdkR2hwY3lCd1lYbHRaVzUwWDJsa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnNUxUa3dDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1OdmJuTmxibk4xYzE5eVpXTnZjbVJ6VzNCaGVXMWxiblJmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXlaWE52YkhabFpDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKamIyNXpaVzV6ZFhNZ1lXeHlaV0ZrZVNCeVpYTnZiSFpsWkNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlOZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuSmxjMjlzZG1Wa0lEMDlJRlZKYm5RMk5DZ3dLU3dnSW1OdmJuTmxibk4xY3lCaGJISmxZV1I1SUhKbGMyOXNkbVZrSWdvZ0lDQWdZblJ2YVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTnZibk5sYm5OMWN5QmhiSEpsWVdSNUlISmxjMjlzZG1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbkp2ZFc1a0lEdzlJSEpsWTI5eVpDNWtaV0ZrYkdsdVpWOXliM1Z1WkN3Z0ltTnZibk5sYm5OMWN5QmtaV0ZrYkdsdVpTQndZWE56WldRaUNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREU0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJR052Ym5ObGJuTjFjeUJrWldGa2JHbHVaU0J3WVhOelpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9UTXRPVFFLSUNBZ0lDOHZJQ01nVlhObElHTnZibk5sYm5SZmFHRnphQ0JoY3lCa1pXUjFjQ0JyWlhrZ0tIQmxaWElnWTJGdUozUWdkbTkwWlNCMGQybGpaU0IzYVhSb0lITmhiV1VnYUdGemFDa0tJQ0FnSUM4dklHRnNjbVZoWkhsZmRtOTBaV1FnUFNCamIyNXpaVzUwWDJoaGMyZ2dhVzRnYzJWc1ppNXpkV0p0YVhSMFpXUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWXpOek16WVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCaGMzTmxjblFnYm05MElHRnNjbVZoWkhsZmRtOTBaV1FzSUNKMGFHbHpJR052Ym5ObGJuUWdZV3h5WldGa2VTQnpkV0p0YVhSMFpXUWlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnZEdocGN5QmpiMjV6Wlc1MElHRnNjbVZoWkhrZ2MzVmliV2wwZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCelpXeG1Mbk4xWW0xcGRIUmxaRnRqYjI1elpXNTBYMmhoYzJoZElEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5OMWMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJR1Z6WTNKdmQxOXBaRDF5WldOdmNtUXVaWE5qY205M1gybGtMQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016UUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURNMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklISmxjWFZwY21Wa1gyRndjSEp2ZG1Gc2N6MXlaV052Y21RdWNtVnhkV2x5WldSZllYQndjbTkyWVd4ekxBb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmpiMnhzWldOMFpXUTljbVZqYjNKa0xtTnZiR3hsWTNSbFpDQXJJRlZKYm5RMk5DZ3hLU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2prNUxURXdOUW9nSUNBZ0x5OGdjMlZzWmk1amIyNXpaVzV6ZFhOZmNtVmpiM0prYzF0d1lYbHRaVzUwWDJsa1hTQTlJRU52Ym5ObGJuTjFjMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JsYzJOeWIzZGZhV1E5Y21WamIzSmtMbVZ6WTNKdmQxOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpYRjFhWEpsWkY5aGNIQnliM1poYkhNOWNtVmpiM0prTG5KbGNYVnBjbVZrWDJGd2NISnZkbUZzY3l3S0lDQWdJQzh2SUNBZ0lDQmpiMnhzWldOMFpXUTljbVZqYjNKa0xtTnZiR3hsWTNSbFpDQXJJRlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXRmtiR2x1WlY5eWIzVnVaRDF5WldOdmNtUXVaR1ZoWkd4cGJtVmZjbTkxYm1Rc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6YjJ4MlpXUTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURJeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuTjFjMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUhKbGMyOXNkbVZrUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPams1TFRFd05Rb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1elpXNXpkWE5mY21WamIzSmtjMXR3WVhsdFpXNTBYMmxrWFNBOUlFTnZibk5sYm5OMWMxSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmxjMk55YjNkZmFXUTljbVZqYjNKa0xtVnpZM0p2ZDE5cFpDd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMWFYSmxaRjloY0hCeWIzWmhiSE05Y21WamIzSmtMbkpsY1hWcGNtVmtYMkZ3Y0hKdmRtRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCamIyeHNaV04wWldROWNtVmpiM0prTG1OdmJHeGxZM1JsWkNBcklGVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0JrWldGa2JHbHVaVjl5YjNWdVpEMXlaV052Y21RdVpHVmhaR3hwYm1WZmNtOTFibVFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiMngyWldROVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzV6ZFhOZmRtRjFiSFF1WTI5dWRISmhZM1F1UTI5dWMyVnVjM1Z6Vm1GMWJIUXVaWGhsWTNWMFpWOXBabDlqYjI1elpXNXpkWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHVmpkWFJsWDJsbVgyTnZibk5sYm5OMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ2NHRjViV1Z1ZEY5cFpDQnBiaUJ6Wld4bUxtTnZibk5sYm5OMWMxOXlaV052Y21SekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qTTNOak5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbTV2SUdOdmJuTmxibk4xY3lCeVpXTnZjbVFnWm05eUlIUm9hWE1nY0dGNWJXVnVkRjlwWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YnlCamIyNXpaVzV6ZFhNZ2NtVmpiM0prSUdadmNpQjBhR2x6SUhCaGVXMWxiblJmYVdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXhOd29nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1amIyNXpaVzV6ZFhOZmNtVmpiM0prYzF0d1lYbHRaVzUwWDJsa1hTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjbVZ6YjJ4MlpXUWdQVDBnVlVsdWREWTBLREFwTENBaVlXeHlaV0ZrZVNCeVpYTnZiSFpsWkNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlOZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXlaWE52YkhabFpDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKaGJISmxZV1I1SUhKbGMyOXNkbVZrSWdvZ0lDQWdZblJ2YVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2NtVnpiMngyWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRFNUNpQWdJQ0F2THlCcFppQnlaV052Y21RdVkyOXNiR1ZqZEdWa0lENDlJSEpsWTI5eVpDNXlaWEYxYVhKbFpGOWhjSEJ5YjNaaGJITTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdQajBLSUNBZ0lHSjZJR1Y0WldOMWRHVmZhV1pmWTI5dWMyVnVjM1Z6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5OMWMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJR1Z6WTNKdmQxOXBaRDF5WldOdmNtUXVaWE5qY205M1gybGtMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z1pHVmhaR3hwYm1WZmNtOTFibVE5Y21WamIzSmtMbVJsWVdSc2FXNWxYM0p2ZFc1a0xBb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRnS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1qQXRNVEkyQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZibk5sYm5OMWMxOXlaV052Y21SelczQmhlVzFsYm5SZmFXUmRJRDBnUTI5dWMyVnVjM1Z6VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdWelkzSnZkMTlwWkQxeVpXTnZjbVF1WlhOamNtOTNYMmxrTEFvZ0lDQWdMeThnSUNBZ0lISmxjWFZwY21Wa1gyRndjSEp2ZG1Gc2N6MXlaV052Y21RdWNtVnhkV2x5WldSZllYQndjbTkyWVd4ekxBb2dJQ0FnTHk4Z0lDQWdJR052Ykd4bFkzUmxaRDF5WldOdmNtUXVZMjlzYkdWamRHVmtMQW9nSUNBZ0x5OGdJQ0FnSUdSbFlXUnNhVzVsWDNKdmRXNWtQWEpsWTI5eVpDNWtaV0ZrYkdsdVpWOXliM1Z1WkN3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpEMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXlNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuTjFjMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUhKbGMyOXNkbVZrUFZWSmJuUTJOQ2d4S1N3S0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV5TUMweE1qWUtJQ0FnSUM4dklITmxiR1l1WTI5dWMyVnVjM1Z6WDNKbFkyOXlaSE5iY0dGNWJXVnVkRjlwWkYwZ1BTQkRiMjV6Wlc1emRYTlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdaWE5qY205M1gybGtQWEpsWTI5eVpDNWxjMk55YjNkZmFXUXNDaUFnSUNBdkx5QWdJQ0FnY21WeGRXbHlaV1JmWVhCd2NtOTJZV3h6UFhKbFkyOXlaQzV5WlhGMWFYSmxaRjloY0hCeWIzWmhiSE1zQ2lBZ0lDQXZMeUFnSUNBZ1kyOXNiR1ZqZEdWa1BYSmxZMjl5WkM1amIyeHNaV04wWldRc0NpQWdJQ0F2THlBZ0lDQWdaR1ZoWkd4cGJtVmZjbTkxYm1ROWNtVmpiM0prTG1SbFlXUnNhVzVsWDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkbVZrUFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lHSjFjbmtnTWdvS1pYaGxZM1YwWlY5cFpsOWpiMjV6Wlc1emRYTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVjM1Z6WDNaaGRXeDBMbU52Ym5SeVlXTjBMa052Ym5ObGJuTjFjMVpoZFd4MExtVjRaV04xZEdWZmFXWmZZMjl1YzJWdWMzVnpRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taWGhsWTNWMFpWOXBabDlqYjI1elpXNXpkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5OMWMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdaWGhsWTNWMFpWOXBabDlqYjI1elpXNXpkWE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1YzNWelgzWmhkV3gwTG1OdmJuUnlZV04wTGtOdmJuTmxibk4xYzFaaGRXeDBMbVY0WldOMWRHVmZhV1pmWTI5dWMyVnVjM1Z6UURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWMzVnpYM1poZFd4MExtTnZiblJ5WVdOMExrTnZibk5sYm5OMWMxWmhkV3gwTG5ScGJXVnZkWFJmY21WcVpXTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdsdFpXOTFkRjl5WldwbFkzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXpNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHVjRhWE4wY3lBOUlIQmhlVzFsYm5SZmFXUWdhVzRnYzJWc1ppNWpiMjV6Wlc1emRYTmZjbVZqYjNKa2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXpOell6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5OMWMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSnVieUJqYjI1elpXNXpkWE1nY21WamIzSmtJR1p2Y2lCMGFHbHpJSEJoZVcxbGJuUmZhV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdibThnWTI5dWMyVnVjM1Z6SUhKbFkyOXlaQ0JtYjNJZ2RHaHBjeUJ3WVhsdFpXNTBYMmxrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV6T0MweE16a0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WTI5dWMyVnVjM1Z6WDNKbFkyOXlaSE5iY0dGNWJXVnVkRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuSmxjMjlzZG1Wa0lEMDlJRlZKYm5RMk5DZ3dLU3dnSW1Gc2NtVmhaSGtnY21WemIyeDJaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01qWUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5OMWMxOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWNtVnpiMngyWldRZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpWVd4eVpXRmtlU0J5WlhOdmJIWmxaQ0lLSUNBZ0lHSjBiMmtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCaGJISmxZV1I1SUhKbGMyOXNkbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXliM1Z1WkNBK0lISmxZMjl5WkM1a1pXRmtiR2x1WlY5eWIzVnVaQ3dnSW1SbFlXUnNhVzVsSUc1dmRDQjVaWFFnY0dGemMyVmtJZ29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdSbFlXUnNhVzVsSUc1dmRDQjVaWFFnY0dGemMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdaWE5qY205M1gybGtQWEpsWTI5eVpDNWxjMk55YjNkZmFXUXNDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTXpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z2NtVnhkV2x5WldSZllYQndjbTkyWVd4elBYSmxZMjl5WkM1eVpYRjFhWEpsWkY5aGNIQnliM1poYkhNc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklHTnZiR3hsWTNSbFpEMXlaV052Y21RdVkyOXNiR1ZqZEdWa0xBb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5ESXRNVFE0Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZibk5sYm5OMWMxOXlaV052Y21SelczQmhlVzFsYm5SZmFXUmRJRDBnUTI5dWMyVnVjM1Z6VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdWelkzSnZkMTlwWkQxeVpXTnZjbVF1WlhOamNtOTNYMmxrTEFvZ0lDQWdMeThnSUNBZ0lISmxjWFZwY21Wa1gyRndjSEp2ZG1Gc2N6MXlaV052Y21RdWNtVnhkV2x5WldSZllYQndjbTkyWVd4ekxBb2dJQ0FnTHk4Z0lDQWdJR052Ykd4bFkzUmxaRDF5WldOdmNtUXVZMjlzYkdWamRHVmtMQW9nSUNBZ0x5OGdJQ0FnSUdSbFlXUnNhVzVsWDNKdmRXNWtQWEpsWTI5eVpDNWtaV0ZrYkdsdVpWOXliM1Z1WkN3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpEMVZTVzUwTmpRb01pa3NDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TWpJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWMzVnpYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnY21WemIyeDJaV1E5VlVsdWREWTBLRElwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1emRYTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVFF5TFRFME9Bb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1elpXNXpkWE5mY21WamIzSmtjMXR3WVhsdFpXNTBYMmxrWFNBOUlFTnZibk5sYm5OMWMxSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmxjMk55YjNkZmFXUTljbVZqYjNKa0xtVnpZM0p2ZDE5cFpDd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMWFYSmxaRjloY0hCeWIzWmhiSE05Y21WamIzSmtMbkpsY1hWcGNtVmtYMkZ3Y0hKdmRtRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCamIyeHNaV04wWldROWNtVmpiM0prTG1OdmJHeGxZM1JsWkN3S0lDQWdJQzh2SUNBZ0lDQmtaV0ZrYkdsdVpWOXliM1Z1WkQxeVpXTnZjbVF1WkdWaFpHeHBibVZmY205MWJtUXNDaUFnSUNBdkx5QWdJQ0FnY21WemIyeDJaV1E5VlVsdWREWTBLRElwTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVjM1Z6WDNaaGRXeDBMbU52Ym5SeVlXTjBMa052Ym5ObGJuTjFjMVpoZFd4MExtZGxkRjlqYjI1elpXNXpkWE5mYzNSaGRIVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTnZibk5sYm5OMWMxOXpkR0YwZFhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFMU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuTjFjMTkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUhCaGVXMWxiblJmYVdRZ2FXNGdjMlZzWmk1amIyNXpaVzV6ZFhOZmNtVmpiM0prY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZek56WXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKdWJ5QmpiMjV6Wlc1emRYTWdjbVZqYjNKa0lHWnZjaUIwYUdseklIQmhlVzFsYm5SZmFXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdZMjl1YzJWdWMzVnpJSEpsWTI5eVpDQm1iM0lnZEdocGN5QndZWGx0Wlc1MFgybGtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTFPUzB4TmpBS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVZMjl1YzJWdWMzVnpYM0psWTI5eVpITmJjR0Y1YldWdWRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnlaWFIxY200Z2NtVmpiM0prTG5KbGMyOXNkbVZrQ2lBZ0lDQndkWE5vYVc1MElESTJDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1emRYTmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWMzVnpYM1poZFd4MExtTnZiblJ5WVdOMExrTnZibk5sYm5OMWMxWmhkV3gwTG1kbGRGOWpiMnhzWldOMFpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlkyOXNiR1ZqZEdWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxibk4xYzE5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNXpkWE5mZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCbGVHbHpkSE1nUFNCd1lYbHRaVzUwWDJsa0lHbHVJSE5sYkdZdVkyOXVjMlZ1YzNWelgzSmxZMjl5WkhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk16YzJNMkVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzV6ZFhOZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UWTJDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaWJtOGdZMjl1YzJWdWMzVnpJSEpsWTI5eVpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCdWJ5QmpiMjV6Wlc1emRYTWdjbVZqYjNKa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVjM1Z6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFMk55MHhOamdLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVkyOXVjMlZ1YzNWelgzSmxZMjl5WkhOYmNHRjViV1Z1ZEY5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCeVpYUjFjbTRnY21WamIzSmtMbU52Ykd4bFkzUmxaQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1YzNWelgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBZ2dBQVNZRUEyTjJPZ0lBSWdRVkgzeDFEM05sYm5ScGJtVnNYMkZ3Y0Y5cFpERVlRQUFES3lSbk1Sa1VSREVZUVFBeWdnWUVPNWUrU1FSRTIvMmVCQnIyZHlNRUNEWWhBQVIwNXpCTkJLYy9XVGMyR2dDT0JnQWRBSXNCTGdHeUFpUUNSZ0NBQkNRTkwyYzJHZ0NPQVFBQkFEWWFBVWtWSXhKRUZ5dE1aeVZETmhvQlNTUlpJZ2hMQVJVU1JGY0NBRFlhQWtra1dTSUlTd0VWRWtSWEFnQTJHZ05KRlNNU1JCZExBaFdCSUJKRVN3RVZTWUVnRWtSTEFVUW9Ud1JRU2IxRkFSUkVNZ2FCSGdoUEFoWlhCZ0pQQkZCUEF4WXBURkFrRmt4TEFWQlBBeFpRVEZCTVVFc0J2RWkvSlVNMkdnRkpKRmtpQ0VzQkZSSkVWd0lBTmhvQ1NTUlpJZ2hMQVJVU1JGY0NBRXNCRllFZ0VrUkpGWUVnRWtRb1R3SlFTYjFGQVVSSmdSb2p1aGNVUkRJR1N3R0JFaU82RjB4TEFRNUVnQU5qY3pwUEExQkp2VVVCRkVRbEZyOUxBWUVpSXJvWElnaExBb0VpVHdLNlZ3SUFTd0lpSTdvWFN3T0JDaU82RnlVSVN3SVZGbGNHQWs4RFVFOENGaWxNVUU4Q0ZsQlBBaFpRSkJaUVRGQkxBYnhJdnlWRE5ob0JTU1JaSWdoTEFSVVNSRmNDQUNoTVVFY0N2VVVCUkVtQkdpTzZGeFJFU1lFS0k3b1hTVThDSWlPNkYwbE9BZzlCQUVsTEFrbUJJaUs2RnlJSVN3R0JJazhDdWxjQ0FFc0JnUklqdWhkTEFSVVdWd1lDVHdKUVN3TVdLVXhRU3dVV1VFOENGbEFsRmxCTVVFc0J2RWkvSlVVQ1N3RVdLa3hRc0NWREpFVUNRdi94TmhvQlNTUlpJZ2hMQVJVU1JGY0NBQ2hNVUVtOVJRRkVTWUVhSTdvWEZFUXlCa3NCZ1JJanVoZE1Td0VOUkVzQmdTSWl1aGNpQ0VzQ2dTSlBBcnBYQWdCTEFpSWp1aGRMQTRFS0k3b1hTd0lWRmxjR0FrOERVRThDRmlsTVVFOENGbEJQQWhaUUloWlFURkJMQWJ4SXZ5VkROaG9CU1NSWklnaExBUlVTUkZjQ0FDaE1VRW05UlFGRWdSb2p1aXBNVUxBbFF6WWFBVWtrV1NJSVN3RVZFa1JYQWdBb1RGQkp2VVVCUklFS0k3b3FURkN3SlVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
