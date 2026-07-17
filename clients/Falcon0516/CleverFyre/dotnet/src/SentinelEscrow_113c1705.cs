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

namespace Arc56.Generated.Falcon0516.CleverFyre.SentinelEscrow_113c1705
{


    //
    // 
    //    Payment hub — ALL ALGO for AXIOM-governed payments flows through here.
    //
    //    Deposit -> (oracle evaluates SLA) -> Release  OR  Refund
    //                                      -> Quarantine -> admin_resolve
    //
    //    Note prefix on all inner transactions: b"x402:axiom:"
    //    
    //
    public class SentinelEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SentinelEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BlockedEvent : AVMObjectType
            {
                public byte[] EscrowId { get; set; }

                public ulong ReasonCode { get; set; }

                public ulong BlockedRound { get; set; }

                public Algorand.Address Payer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vEscrowId.From(EscrowId);
                    ret.AddRange(vEscrowId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReasonCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReasonCode.From(ReasonCode);
                    ret.AddRange(vReasonCode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBlockedRound.From(BlockedRound);
                    ret.AddRange(vBlockedRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BlockedEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BlockedEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vEscrowId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowId = vEscrowId.ToValue();
                    if (valueEscrowId is byte[] vEscrowIdValue) { ret.EscrowId = vEscrowIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReasonCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReasonCode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReasonCode = vReasonCode.ToValue();
                    if (valueReasonCode is ulong vReasonCodeValue) { ret.ReasonCode = vReasonCodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBlockedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBlockedRound = vBlockedRound.ToValue();
                    if (valueBlockedRound is ulong vBlockedRoundValue) { ret.BlockedRound = vBlockedRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BlockedEvent);
                }
                public bool Equals(BlockedEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BlockedEvent left, BlockedEvent right)
                {
                    return EqualityComparer<BlockedEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(BlockedEvent left, BlockedEvent right)
                {
                    return !(left == right);
                }

            }

            public class EscrowRecord : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public Algorand.Address Provider { get; set; }

                public ulong Amount { get; set; }

                public ulong DeadlineRound { get; set; }

                public ulong QuarantineFlag { get; set; }

                public ulong ConsensusRequired { get; set; }

                public byte[] IntentHash { get; set; }

                public ulong Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProvider.From(Provider);
                    ret.AddRange(vProvider.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadlineRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDeadlineRound.From(DeadlineRound);
                    ret.AddRange(vDeadlineRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuarantineFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vQuarantineFlag.From(QuarantineFlag);
                    ret.AddRange(vQuarantineFlag.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsensusRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vConsensusRequired.From(ConsensusRequired);
                    ret.AddRange(vConsensusRequired.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIntentHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vIntentHash.From(IntentHash);
                    ret.AddRange(vIntentHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EscrowRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProvider.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProvider = vProvider.ToValue();
                    if (valueProvider is Algorand.Address vProviderValue) { ret.Provider = vProviderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadlineRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDeadlineRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeadlineRound = vDeadlineRound.ToValue();
                    if (valueDeadlineRound is ulong vDeadlineRoundValue) { ret.DeadlineRound = vDeadlineRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuarantineFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vQuarantineFlag.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueQuarantineFlag = vQuarantineFlag.ToValue();
                    if (valueQuarantineFlag is ulong vQuarantineFlagValue) { ret.QuarantineFlag = vQuarantineFlagValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsensusRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vConsensusRequired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConsensusRequired = vConsensusRequired.ToValue();
                    if (valueConsensusRequired is ulong vConsensusRequiredValue) { ret.ConsensusRequired = vConsensusRequiredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIntentHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vIntentHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIntentHash = vIntentHash.ToValue();
                    if (valueIntentHash is byte[] vIntentHashValue) { ret.IntentHash = vIntentHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowRecord);
                }
                public bool Equals(EscrowRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowRecord left, EscrowRecord right)
                {
                    return EqualityComparer<EscrowRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowRecord left, EscrowRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Called once on deploy. Records the PolicyVault app ID.
        ///</summary>
        /// <param name="policy_vault_app_id"> </param>
        public async Task Create(ulong policy_vault_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var policy_vault_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_vault_app_idAbi.From(policy_vault_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, policy_vault_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong policy_vault_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var policy_vault_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_vault_app_idAbi.From(policy_vault_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_vault_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Accept an incoming ALGO payment and open an escrow record.
        ///The caller must attach a PaymentTransaction (inner group) whose receiver is this app's address.  Amount is read from that txn.
        ///Returns the 32-byte escrow_id = sha256(payer_bytes + intent_hash + round_bytes).
        ///</summary>
        /// <param name="provider"> </param>
        /// <param name="intent_hash"> </param>
        /// <param name="deadline_rounds"> </param>
        /// <param name="requires_consensus"> </param>
        public async Task<byte[]> Deposit(Algorand.Address provider, byte[] intent_hash, ulong deadline_rounds, ulong requires_consensus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 81, 91, 97 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var intent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); intent_hashAbi.From(intent_hash);
            var deadline_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadline_roundsAbi.From(deadline_rounds);
            var requires_consensusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requires_consensusAbi.From(requires_consensus);

            var result = await base.CallApp(new List<object> { abiHandle, providerAbi, intent_hashAbi, deadline_roundsAbi, requires_consensusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Deposit_Transactions(Algorand.Address provider, byte[] intent_hash, ulong deadline_rounds, ulong requires_consensus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 81, 91, 97 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var intent_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); intent_hashAbi.From(intent_hash);
            var deadline_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadline_roundsAbi.From(deadline_rounds);
            var requires_consensusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requires_consensusAbi.From(requires_consensus);

            return await base.MakeTransactionList(new List<object> { abiHandle, providerAbi, intent_hashAbi, deadline_roundsAbi, requires_consensusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///SLA passed — transfer ALGO to provider.
        ///Oracle calls this when HTTP 200 + latency within threshold. Emits b"x402:axiom:RELEASE" in inner-txn note.
        ///</summary>
        /// <param name="escrow_id"> </param>
        public async Task Release(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 67, 6, 130 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Release_Transactions(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 67, 6, 130 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///SLA failed or deadline passed — return ALGO to payer.
        ///Emits b"x402:axiom:REFUND" in inner-txn note.
        ///</summary>
        /// <param name="escrow_id"> </param>
        public async Task Refund(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 121, 245, 108 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refund_Transactions(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 121, 245, 108 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Flag a payment for human review.
        ///Triggered by: anomaly detector, burst check, DNA drift > threshold. reason_code:   1 = anomaly detected   2 = burst rate exceeded   3 = DNA drift > 0.30   4 = reputation too low   5 = semantic mismatch   6 = policy expired
        ///</summary>
        /// <param name="escrow_id"> </param>
        /// <param name="reason_code"> </param>
        public async Task Quarantine(byte[] escrow_id, ulong reason_code, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 52, 110, 235 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var reason_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reason_codeAbi.From(reason_code);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi, reason_codeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Quarantine_Transactions(byte[] escrow_id, ulong reason_code, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 52, 110, 235 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var reason_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reason_codeAbi.From(reason_code);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi, reason_codeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Operator approves or rejects a quarantined payment.
        ///approved=1 -> release()  |  approved=0 -> refund() Must be called by the contract creator (org admin).
        ///</summary>
        /// <param name="escrow_id"> </param>
        /// <param name="approved"> </param>
        public async Task AdminResolve(byte[] escrow_id, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 10, 229, 20 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminResolve_Transactions(byte[] escrow_id, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 10, 229, 20 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns status: 0=open, 1=released, 2=refunded, 3=quarantined.
        ///</summary>
        /// <param name="escrow_id"> </param>
        public async Task<ulong> GetEscrowStatus(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 96, 22, 46 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEscrowStatus_Transactions(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 96, 22, 46 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the escrowed microALGO amount.
        ///</summary>
        /// <param name="escrow_id"> </param>
        public async Task<ulong> GetEscrowAmount(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 49, 41, 171 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEscrowAmount_Transactions(byte[] escrow_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 49, 41, 171 };
            var escrow_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); escrow_idAbi.From(escrow_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2VudGluZWxFc2Nyb3ciLCJkZXNjIjoiXG4gICAgUGF5bWVudCBodWIg4oCUIEFMTCBBTEdPIGZvciBBWElPTS1nb3Zlcm5lZCBwYXltZW50cyBmbG93cyB0aHJvdWdoIGhlcmUuXG5cbiAgICBEZXBvc2l0IC0+IChvcmFjbGUgZXZhbHVhdGVzIFNMQSkgLT4gUmVsZWFzZSAgT1IgIFJlZnVuZFxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAtPiBRdWFyYW50aW5lIC0+IGFkbWluX3Jlc29sdmVcblxuICAgIE5vdGUgcHJlZml4IG9uIGFsbCBpbm5lciB0cmFuc2FjdGlvbnM6IGJcIng0MDI6YXhpb206XCJcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmxvY2tlZEV2ZW50IjpbeyJuYW1lIjoiZXNjcm93X2lkIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InJlYXNvbl9jb2RlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJsb2NrZWRfcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGF5ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiRXNjcm93UmVjb3JkIjpbeyJuYW1lIjoicGF5ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InByb3ZpZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGVhZGxpbmVfcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicXVhcmFudGluZV9mbGFnIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvbnNlbnN1c19yZXF1aXJlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbnRlbnRfaGFzaCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDYWxsZWQgb25jZSBvbiBkZXBsb3kuIFJlY29yZHMgdGhlIFBvbGljeVZhdWx0IGFwcCBJRC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9saWN5X3ZhdWx0X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IkFjY2VwdCBhbiBpbmNvbWluZyBBTEdPIHBheW1lbnQgYW5kIG9wZW4gYW4gZXNjcm93IHJlY29yZC5cblRoZSBjYWxsZXIgbXVzdCBhdHRhY2ggYSBQYXltZW50VHJhbnNhY3Rpb24gKGlubmVyIGdyb3VwKSB3aG9zZSByZWNlaXZlciBpcyB0aGlzIGFwcCdzIGFkZHJlc3MuICBBbW91bnQgaXMgcmVhZCBmcm9tIHRoYXQgdHhuLlxuUmV0dXJucyB0aGUgMzItYnl0ZSBlc2Nyb3dfaWQgPSBzaGEyNTYocGF5ZXJfYnl0ZXMgKyBpbnRlbnRfaGFzaCArIHJvdW5kX2J5dGVzKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3ZpZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmVfcm91bmRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1aXJlc19jb25zZW5zdXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlIiwiZGVzYyI6IlNMQSBwYXNzZWQg4oCUIHRyYW5zZmVyIEFMR08gdG8gcHJvdmlkZXIuXG5PcmFjbGUgY2FsbHMgdGhpcyB3aGVuIEhUVFAgMjAwICsgbGF0ZW5jeSB3aXRoaW4gdGhyZXNob2xkLiBFbWl0cyBiXCJ4NDAyOmF4aW9tOlJFTEVBU0VcIiBpbiBpbm5lci10eG4gbm90ZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZCIsImRlc2MiOiJTTEEgZmFpbGVkIG9yIGRlYWRsaW5lIHBhc3NlZCDigJQgcmV0dXJuIEFMR08gdG8gcGF5ZXIuXG5FbWl0cyBiXCJ4NDAyOmF4aW9tOlJFRlVORFwiIGluIGlubmVyLXR4biBub3RlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicXVhcmFudGluZSIsImRlc2MiOiJGbGFnIGEgcGF5bWVudCBmb3IgaHVtYW4gcmV2aWV3LlxuVHJpZ2dlcmVkIGJ5OiBhbm9tYWx5IGRldGVjdG9yLCBidXJzdCBjaGVjaywgRE5BIGRyaWZ0ID4gdGhyZXNob2xkLiByZWFzb25fY29kZTogICAxID0gYW5vbWFseSBkZXRlY3RlZCAgIDIgPSBidXJzdCByYXRlIGV4Y2VlZGVkICAgMyA9IEROQSBkcmlmdCA+IDAuMzAgICA0ID0gcmVwdXRhdGlvbiB0b28gbG93ICAgNSA9IHNlbWFudGljIG1pc21hdGNoICAgNiA9IHBvbGljeSBleHBpcmVkIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uX2NvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRtaW5fcmVzb2x2ZSIsImRlc2MiOiJPcGVyYXRvciBhcHByb3ZlcyBvciByZWplY3RzIGEgcXVhcmFudGluZWQgcGF5bWVudC5cbmFwcHJvdmVkPTEgLT4gcmVsZWFzZSgpICB8ICBhcHByb3ZlZD0wIC0+IHJlZnVuZCgpIE11c3QgYmUgY2FsbGVkIGJ5IHRoZSBjb250cmFjdCBjcmVhdG9yIChvcmcgYWRtaW4pLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9lc2Nyb3dfc3RhdHVzIiwiZGVzYyI6IlJldHVybnMgc3RhdHVzOiAwPW9wZW4sIDE9cmVsZWFzZWQsIDI9cmVmdW5kZWQsIDM9cXVhcmFudGluZWQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9lc2Nyb3dfYW1vdW50IiwiZGVzYyI6IlJldHVybnMgdGhlIGVzY3Jvd2VkIG1pY3JvQUxHTyBhbW91bnQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjY2XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQsODMzLDEwMDRdLCJlcnJvck1lc3NhZ2UiOiJlc2Nyb3cgYWxyZWFkeSBzZXR0bGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI1XSwiZXJyb3JNZXNzYWdlIjoiZXNjcm93IGlzIG5vdCBxdWFyYW50aW5lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0Ml0sImVycm9yTWVzc2FnZSI6ImVzY3JvdyBpcyBxdWFyYW50aW5lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNiw2MTUsNzYyLDc5Niw4MjUsOTk2XSwiZXJyb3JNZXNzYWdlIjoiZXNjcm93IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMSw0MjksNDM1LDQ0MSw0NDgsNDU1LDYyMCw2MzAsNjM2LDY0Miw2NDksNjU2LDc2Niw4MDAsODMwLDgzOCw4NDksODU1LDg5OCw5MDQsOTExLDEwMDEsMTAxMSwxMDM3LDEwNDMsMTA4NSwxMDkxLDEwOThdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ1XSwiZXJyb3JNZXNzYWdlIjoiaW50ZW50X2hhc2ggbXVzdCBiZSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOSwzMzgsMzU5LDM4MCw1ODAsNzQ0LDc3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNyw4MTYsOTg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBlc2Nyb3dfaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTYsMzQ1LDM2NiwzODcsNTg3LDc1MSw3ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NywyMjcsMjM2LDM5OCw1OTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI5XSwiZXJyb3JNZXNzYWdlIjoibm90IHlldCBvdmVyZHVlIGFuZCBjYWxsZXIgaXMgbm90IG9yYWNsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNl0sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4gY2FuIHJlc29sdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURBZ01pQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROalUzTXpOaElEQjRNREEyWVNBaWNHOXNhV041WDNaaGRXeDBYMkZ3Y0Y5cFpDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk1pMDJNd29nSUNBZ0x5OGdJeUJCY0hBZ1NVUnpJRzltSUhSeWRYTjBaV1FnWTJGc2JHVnljeUFvYzJWMElHbHVJR055WldGMFpTa0tJQ0FnSUM4dklITmxiR1l1Y0c5c2FXTjVYM1poZFd4MFgyRndjRjlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHOXNhV041WDNaaGRXeDBYMkZ3Y0Y5cFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z2MyVnNaaTV5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjbDloY0hCZmFXUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljbVZ3ZFhSaGRHbHZibDlzWldSblpYSmZZWEJ3WDJsa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCelpXeG1MbVJ1WVY5eVpXZHBjM1J5ZVY5aGNIQmZhV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWkc1aFgzSmxaMmx6ZEhKNVgyRndjRjlwWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmpiR0Z6Y3lCVFpXNTBhVzVsYkVWelkzSnZkeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdVM05URTFZall4SURCNFpEWTBNekEyT0RJZ01IaGhZemM1WmpVMll5QXdlRGhpTXpRMlpXVmlJREI0WlRjd1lXVTFNVFFnTUhnMU1EWXdNVFl5WlNBd2VHUmxNekV5T1dGaUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaGhaR1J5WlhOekxHSjVkR1ZiWFN4MWFXNTBOalFzZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWljbVZzWldGelpTaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbWRXNWtLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeGRXRnlZVzUwYVc1bEtHSjVkR1ZiWFN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1J0YVc1ZmNtVnpiMngyWlNoaWVYUmxXMTBzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjlsYzJOeWIzZGZjM1JoZEhWektHSjVkR1ZiWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWxjMk55YjNkZllXMXZkVzUwS0dKNWRHVmJYU2wxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWlhCdmMybDBJSEpsYkdWaGMyVWdjbVZtZFc1a0lIRjFZWEpoYm5ScGJtVWdZV1J0YVc1ZmNtVnpiMngyWlNCblpYUmZaWE5qY205M1gzTjBZWFIxY3lCblpYUmZaWE5qY205M1gyRnRiM1Z1ZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1kyeGhjM01nVTJWdWRHbHVaV3hGYzJOeWIzY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJME1HUXlaalkzSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ1ZEdsdVpXeGZaWE5qY205M0xtTnZiblJ5WVdOMExsTmxiblJwYm1Wc1JYTmpjbTkzTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUhObGJHWXVjRzlzYVdONVgzWmhkV3gwWDJGd2NGOXBaQ0E5SUhCdmJHbGplVjkyWVhWc2RGOWhjSEJmYVdRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CdmJHbGplVjkyWVhWc2RGOWhjSEJmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Wlc1MGFXNWxiRjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVVMlZ1ZEdsdVpXeEZjMk55YjNjdVpHVndiM05wZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjRzl6YVhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0JwYm5SbGJuUmZhR0Z6YUM1c1pXNW5kR2dnUFQwZ016SXNJQ0pwYm5SbGJuUmZhR0Z6YUNCdGRYTjBJR0psSURNeUlHSjVkR1Z6SWdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRHVnVkRjlvWVhOb0lHMTFjM1FnWW1VZ016SWdZbmwwWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUhCaGVXVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdZVzF2ZFc1MElEMGdWSGh1TG1abFpTQWdJeUJ3YkdGalpXaHZiR1JsY2lEaWdKUWdjbVZoYkNCaGJXOTFiblFnWm5KdmJTQmhkSFJoWTJobFpDQndZWGtnZEhodUNpQWdJQ0IwZUc0Z1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXdNQzB4TURFS0lDQWdJQzh2SUNNZ1JHVnlhWFpsSUdSbGRHVnliV2x1YVhOMGFXTWdaWE5qY205M1gybGtDaUFnSUNBdkx5QnliM1Z1WkY5aWVYUmxjeUE5SUc5d0xtbDBiMklvUjJ4dlltRnNMbkp2ZFc1a0tRb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBcklHbHVkR1Z1ZEY5b1lYTm9JQ3NnY205MWJtUmZZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1ESXRNVEEwQ2lBZ0lDQXZMeUJsYzJOeWIzZGZhV1FnUFNCdmNDNXphR0V5TlRZb0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QXJJR2x1ZEdWdWRGOW9ZWE5vSUNzZ2NtOTFibVJmWW5sMFpYTUtJQ0FnSUM4dklDa0tJQ0FnSUhOb1lUSTFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJSEJ5YjNacFpHVnlQVUZqWTI5MWJuUW9jSEp2ZG1sa1pYSXVZbmwwWlhNcExBb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnWkdWaFpHeHBibVZmY205MWJtUTlSMnh2WW1Gc0xuSnZkVzVrSUNzZ1pHVmhaR3hwYm1WZmNtOTFibVJ6TEFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMkxURXhOUW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2R6VzJWelkzSnZkMTlwWkYwZ1BTQkZjMk55YjNkU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEk5UVdOamIzVnVkQ2h3WVhsbGNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2ZG1sa1pYSTlRV05qYjNWdWRDaHdjbTkyYVdSbGNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmtaV0ZrYkdsdVpWOXliM1Z1WkQxSGJHOWlZV3d1Y205MWJtUWdLeUJrWldGa2JHbHVaVjl5YjNWdVpITXNDaUFnSUNBdkx5QWdJQ0FnY1hWaGNtRnVkR2x1WlY5bWJHRm5QVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCamIyNXpaVzV6ZFhOZmNtVnhkV2x5WldROWNtVnhkV2x5WlhOZlkyOXVjMlZ1YzNWekxBb2dJQ0FnTHk4Z0lDQWdJR2x1ZEdWdWRGOW9ZWE5vUFdsdWRHVnVkRjlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnY1hWaGNtRnVkR2x1WlY5bWJHRm5QVlZKYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXdOaTB4TVRVS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdGxjMk55YjNkZmFXUmRJRDBnUlhOamNtOTNVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBVRmpZMjkxYm5Rb2NHRjVaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzWnBaR1Z5UFVGalkyOTFiblFvY0hKdmRtbGtaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWkdWaFpHeHBibVZmY205MWJtUTlSMnh2WW1Gc0xuSnZkVzVrSUNzZ1pHVmhaR3hwYm1WZmNtOTFibVJ6TEFvZ0lDQWdMeThnSUNBZ0lIRjFZWEpoYm5ScGJtVmZabXhoWnoxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtQWEpsY1hWcGNtVnpYMk52Ym5ObGJuTjFjeXdLSUNBZ0lDOHZJQ0FnSUNCcGJuUmxiblJmYUdGemFEMXBiblJsYm5SZmFHRnphQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQTJZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYzJWc1ppNWxjMk55YjNkelcyVnpZM0p2ZDE5cFpGMGdQU0JGYzJOeWIzZFNaV052Y21Rb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qVTNNek5oQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd05pMHhNVFVLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0bGMyTnliM2RmYVdSZElEMGdSWE5qY205M1VtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIQmhlV1Z5UFVGalkyOTFiblFvY0dGNVpYSXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNacFpHVnlQVUZqWTI5MWJuUW9jSEp2ZG1sa1pYSXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaR1ZoWkd4cGJtVmZjbTkxYm1ROVIyeHZZbUZzTG5KdmRXNWtJQ3NnWkdWaFpHeHBibVZmY205MWJtUnpMQW9nSUNBZ0x5OGdJQ0FnSUhGMVlYSmhiblJwYm1WZlpteGhaejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVjMlZ1YzNWelgzSmxjWFZwY21Wa1BYSmxjWFZwY21WelgyTnZibk5sYm5OMWN5d0tJQ0FnSUM4dklDQWdJQ0JwYm5SbGJuUmZhR0Z6YUQxcGJuUmxiblJmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TnprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ESXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elpXNTBhVzVsYkY5bGMyTnliM2N1WTI5dWRISmhZM1F1VTJWdWRHbHVaV3hGYzJOeWIzY3VjbVZzWldGelpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYkdWaGMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXhPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ1ZEdsdVpXeGZaWE5qY205M0xtTnZiblJ5WVdOMExsTmxiblJwYm1Wc1JYTmpjbTkzTG5KbGJHVmhjMlVLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyVnVkR2x1Wld4ZlpYTmpjbTkzTG1OdmJuUnlZV04wTGxObGJuUnBibVZzUlhOamNtOTNMbkpsWm5WdVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWm5WdVpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXNTBhVzVsYkY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqWVd4c2MzVmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpaVzUwYVc1bGJGOWxjMk55YjNjdVkyOXVkSEpoWTNRdVUyVnVkR2x1Wld4RmMyTnliM2N1Y21WbWRXNWtDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXhkV0Z5WVc1MGFXNWxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY1hWaGNtRnVkR2x1WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUdWelkzSnZkMTlwWkM1c1pXNW5kR2dnUFQwZ016SXNJQ0pwYm5aaGJHbGtJR1Z6WTNKdmQxOXBaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJR1Z6WTNKdmQxOXBaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJR1Y0YVhOMGN5QTlJR1Z6WTNKdmQxOXBaQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJOVGN6TTJFS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbVZ6WTNKdmR5QnViM1FnWm05MWJtUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYTmpjbTkzSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TURVdE1qQTJDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iWlhOamNtOTNYMmxrWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlGVkpiblEyTkNnd0tTd2dJbVZ6WTNKdmR5QmhiSEpsWVdSNUlITmxkSFJzWldRaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPVGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TURZS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DZ3dLU3dnSW1WelkzSnZkeUJoYkhKbFlXUjVJSE5sZEhSc1pXUWlDaUFnSUNCaWRHOXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWlhOamNtOTNJR0ZzY21WaFpIa2djMlYwZEd4bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklIQmhlV1Z5UFhKbFkyOXlaQzV3WVhsbGNpd0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeE1Bb2dJQ0FnTHk4Z2NISnZkbWxrWlhJOWNtVmpiM0prTG5CeWIzWnBaR1Z5TEFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpFeENpQWdJQ0F2THlCaGJXOTFiblE5Y21WamIzSmtMbUZ0YjNWdWRDd0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXNTBhVzVsYkY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5QmtaV0ZrYkdsdVpWOXliM1Z1WkQxeVpXTnZjbVF1WkdWaFpHeHBibVZmY205MWJtUXNDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXhOQW9nSUNBZ0x5OGdZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtQWEpsWTI5eVpDNWpiMjV6Wlc1emRYTmZjbVZ4ZFdseVpXUXNDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBNE9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdhVzUwWlc1MFgyaGhjMmc5Y21WamIzSmtMbWx1ZEdWdWRGOW9ZWE5vTEFvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdNVEEyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdsdWRDQXhNRFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl3T0MweU1UY0tJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNjMXRsYzJOeWIzZGZhV1JkSUQwZ1JYTmpjbTkzVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlQWEpsWTI5eVpDNXdZWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQndjbTkyYVdSbGNqMXlaV052Y21RdWNISnZkbWxrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYSmxZMjl5WkM1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmhaR3hwYm1WZmNtOTFibVE5Y21WamIzSmtMbVJsWVdSc2FXNWxYM0p2ZFc1a0xBb2dJQ0FnTHk4Z0lDQWdJSEYxWVhKaGJuUnBibVZmWm14aFp6MVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWTI5dWMyVnVjM1Z6WDNKbGNYVnBjbVZrUFhKbFkyOXlaQzVqYjI1elpXNXpkWE5mY21WeGRXbHlaV1FzQ2lBZ0lDQXZMeUFnSUNBZ2FXNTBaVzUwWDJoaGMyZzljbVZqYjNKa0xtbHVkR1Z1ZEY5b1lYTm9MQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFWU1c1ME5qUW9NeWtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1UTUtJQ0FnSUM4dklIRjFZWEpoYm5ScGJtVmZabXhoWnoxVlNXNTBOalFvTVNrc0NpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TURndE1qRTNDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkM05iWlhOamNtOTNYMmxrWFNBOUlFVnpZM0p2ZDFKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjajF5WldOdmNtUXVjR0Y1WlhJc0NpQWdJQ0F2THlBZ0lDQWdjSEp2ZG1sa1pYSTljbVZqYjNKa0xuQnliM1pwWkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaV052Y21RdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHUmxZV1JzYVc1bFgzSnZkVzVrUFhKbFkyOXlaQzVrWldGa2JHbHVaVjl5YjNWdVpDd0tJQ0FnSUM4dklDQWdJQ0J4ZFdGeVlXNTBhVzVsWDJac1lXYzlWVWx1ZERZMEtERXBMQW9nSUNBZ0x5OGdJQ0FnSUdOdmJuTmxibk4xYzE5eVpYRjFhWEpsWkQxeVpXTnZjbVF1WTI5dWMyVnVjM1Z6WDNKbGNYVnBjbVZrTEFvZ0lDQWdMeThnSUNBZ0lHbHVkR1Z1ZEY5b1lYTm9QWEpsWTI5eVpDNXBiblJsYm5SZmFHRnphQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05VlVsdWREWTBLRE1wTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREEyWVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeE5nb2dJQ0FnTHk4Z2MzUmhkSFZ6UFZWSmJuUTJOQ2d6S1N3S0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNRGd0TWpFM0NpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQzTmJaWE5qY205M1gybGtYU0E5SUVWelkzSnZkMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0J3WVhsbGNqMXlaV052Y21RdWNHRjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NISnZkbWxrWlhJOWNtVmpiM0prTG5CeWIzWnBaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxeVpXTnZjbVF1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFlXUnNhVzVsWDNKdmRXNWtQWEpsWTI5eVpDNWtaV0ZrYkdsdVpWOXliM1Z1WkN3S0lDQWdJQzh2SUNBZ0lDQnhkV0Z5WVc1MGFXNWxYMlpzWVdjOVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJR052Ym5ObGJuTjFjMTl5WlhGMWFYSmxaRDF5WldOdmNtUXVZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRHVnVkRjlvWVhOb1BYSmxZMjl5WkM1cGJuUmxiblJmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlWVWx1ZERZMEtETXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1Ua3RNakl3Q2lBZ0lDQXZMeUFqSUZkeWFYUmxJR0YxWkdsMElHeHZaeUIwYnlCaWJHOWphMlZrWDJ4dlp5QmliM2dLSUNBZ0lDOHZJR3h2WjE5clpYa2dQU0J2Y0M1emFHRXlOVFlvWlhOamNtOTNYMmxrSUNzZ2IzQXVhWFJ2WWloSGJHOWlZV3d1Y205MWJtUXBLUW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMENpQWdJQ0F2THlCaWJHOWphMlZrWDNKdmRXNWtQVWRzYjJKaGJDNXliM1Z1WkN3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TWpFdE1qSTJDaUFnSUNBdkx5QnpaV3htTG1Kc2IyTnJaV1JmYkc5blcyeHZaMTlyWlhsZElEMGdRbXh2WTJ0bFpFVjJaVzUwS0FvZ0lDQWdMeThnSUNBZ0lHVnpZM0p2ZDE5cFpEMWxjMk55YjNkZmFXUXNDaUFnSUNBdkx5QWdJQ0FnY21WaGMyOXVYMk52WkdVOWNtVmhjMjl1WDJOdlpHVXNDaUFnSUNBdkx5QWdJQ0FnWW14dlkydGxaRjl5YjNWdVpEMUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEk5Y21WamIzSmtMbkJoZVdWeUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklITmxiR1l1WW14dlkydGxaRjlzYjJkYmJHOW5YMnRsZVYwZ1BTQkNiRzlqYTJWa1JYWmxiblFvQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyTWpaak0yRUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeU1TMHlNallLSUNBZ0lDOHZJSE5sYkdZdVlteHZZMnRsWkY5c2IyZGJiRzluWDJ0bGVWMGdQU0JDYkc5amEyVmtSWFpsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdaWE5qY205M1gybGtQV1Z6WTNKdmQxOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXRnpiMjVmWTI5a1pUMXlaV0Z6YjI1ZlkyOWtaU3dLSUNBZ0lDOHZJQ0FnSUNCaWJHOWphMlZrWDNKdmRXNWtQVWRzYjJKaGJDNXliM1Z1WkN3S0lDQWdJQzh2SUNBZ0lDQndZWGxsY2oxeVpXTnZjbVF1Y0dGNVpYSXNDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Wlc1MGFXNWxiRjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVVMlZ1ZEdsdVpXeEZjMk55YjNjdVlXUnRhVzVmY21WemIyeDJaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ga2JXbHVYM0psYzI5c2RtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXlPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXpOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJbTl1YkhrZ1lXUnRhVzRnWTJGdUlISmxjMjlzZG1VaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJpQmpZVzRnY21WemIyeDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNellLSUNBZ0lDOHZJR1Y0YVhOMGN5QTlJR1Z6WTNKdmQxOXBaQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJOVGN6TTJFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKbGMyTnliM2NnYm05MElHWnZkVzVrSWdvZ0lDQWdZWE56WlhKMElDOHZJR1Z6WTNKdmR5QnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXNTBhVzVsYkY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qTTRMVEl6T1FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWxjMk55YjNkelcyVnpZM0p2ZDE5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NeWtzSUNKbGMyTnliM2NnYVhNZ2JtOTBJSEYxWVhKaGJuUnBibVZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEazRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNak01Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQlZTVzUwTmpRb015a3NJQ0psYzJOeWIzY2dhWE1nYm05MElIRjFZWEpoYm5ScGJtVmtJZ29nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Z6WTNKdmR5QnBjeUJ1YjNRZ2NYVmhjbUZ1ZEdsdVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXNTBhVzVsYkY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qUXpDaUFnSUNBdkx5QndZWGxsY2oxeVpXTnZjbVF1Y0dGNVpYSXNDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5EUUtJQ0FnSUM4dklIQnliM1pwWkdWeVBYSmxZMjl5WkM1d2NtOTJhV1JsY2l3S0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJME5Rb2dJQ0FnTHk4Z1lXMXZkVzUwUFhKbFkyOXlaQzVoYlc5MWJuUXNDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSTBOZ29nSUNBZ0x5OGdaR1ZoWkd4cGJtVmZjbTkxYm1ROWNtVmpiM0prTG1SbFlXUnNhVzVsWDNKdmRXNWtMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ056SUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lORGdLSUNBZ0lDOHZJR052Ym5ObGJuTjFjMTl5WlhGMWFYSmxaRDF5WldOdmNtUXVZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lORGtLSUNBZ0lDOHZJR2x1ZEdWdWRGOW9ZWE5vUFhKbFkyOXlaQzVwYm5SbGJuUmZhR0Z6YUN3S0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJREV3TmdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdNVEEyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRFdE1qVXhDaUFnSUNBdkx5QWpJRU5zWldGeUlIRjFZWEpoYm5ScGJtVWdabXhoWnlCemJ5QnlaV3hsWVhObEwzSmxablZ1WkNCallXNGdjSEp2WTJWbFpBb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZHpXMlZ6WTNKdmQxOXBaRjBnUFNCRmMyTnliM2RTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVpYSTljbVZqYjNKa0xuQmhlV1Z5TEFvZ0lDQWdMeThnSUNBZ0lIQnliM1pwWkdWeVBYSmxZMjl5WkM1d2NtOTJhV1JsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVmpiM0prTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCa1pXRmtiR2x1WlY5eWIzVnVaRDF5WldOdmNtUXVaR1ZoWkd4cGJtVmZjbTkxYm1Rc0NpQWdJQ0F2THlBZ0lDQWdjWFZoY21GdWRHbHVaVjltYkdGblBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqYjI1elpXNXpkWE5mY21WeGRXbHlaV1E5Y21WamIzSmtMbU52Ym5ObGJuTjFjMTl5WlhGMWFYSmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCcGJuUmxiblJmYUdGemFEMXlaV052Y21RdWFXNTBaVzUwWDJoaGMyZ3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJSEYxWVhKaGJuUnBibVZmWm14aFp6MVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5ERXRNalV4Q2lBZ0lDQXZMeUFqSUVOc1pXRnlJSEYxWVhKaGJuUnBibVVnWm14aFp5QnpieUJ5Wld4bFlYTmxMM0psWm5WdVpDQmpZVzRnY0hKdlkyVmxaQW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2R6VzJWelkzSnZkMTlwWkYwZ1BTQkZjMk55YjNkU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEk5Y21WamIzSmtMbkJoZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNacFpHVnlQWEpsWTI5eVpDNXdjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljbVZqYjNKa0xtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmtaV0ZrYkdsdVpWOXliM1Z1WkQxeVpXTnZjbVF1WkdWaFpHeHBibVZmY205MWJtUXNDaUFnSUNBdkx5QWdJQ0FnY1hWaGNtRnVkR2x1WlY5bWJHRm5QVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCamIyNXpaVzV6ZFhOZmNtVnhkV2x5WldROWNtVmpiM0prTG1OdmJuTmxibk4xYzE5eVpYRjFhWEpsWkN3S0lDQWdJQzh2SUNBZ0lDQnBiblJsYm5SZmFHRnphRDF5WldOdmNtUXVhVzUwWlc1MFgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURaaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVekNpQWdJQ0F2THlCcFppQmhjSEJ5YjNabFpDQTlQU0JWU1c1ME5qUW9NU2s2Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklHRmtiV2x1WDNKbGMyOXNkbVZmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCelpXeG1MbkpsYkdWaGMyVW9aWE5qY205M1gybGtLUW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJWdWRHbHVaV3hmWlhOamNtOTNMbU52Ym5SeVlXTjBMbE5sYm5ScGJtVnNSWE5qY205M0xuSmxiR1ZoYzJVS0NtRmtiV2x1WDNKbGMyOXNkbVZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1lXUnRhVzVmY21WemIyeDJaVjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVMkNpQWdJQ0F2THlCelpXeG1MbkpsWm5WdVpDaGxjMk55YjNkZmFXUXBDaUFnSUNCallXeHNjM1ZpSUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Wlc1MGFXNWxiRjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVVMlZ1ZEdsdVpXeEZjMk55YjNjdWNtVm1kVzVrQ2lBZ0lDQmlJR0ZrYldsdVgzSmxjMjlzZG1WZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmxiblJwYm1Wc1gyVnpZM0p2ZHk1amIyNTBjbUZqZEM1VFpXNTBhVzVsYkVWelkzSnZkeTVuWlhSZlpYTmpjbTkzWDNOMFlYUjFjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWxjMk55YjNkZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalkxQ2lBZ0lDQXZMeUJsZUdsemRITWdQU0JsYzJOeWIzZGZhV1FnYVc0Z2MyVnNaaTVsYzJOeWIzZHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROalUzTXpOaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakkyTmdvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbVZ6WTNKdmR5QnViM1FnWm05MWJtUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYTmpjbTkzSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TmpjdE1qWTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iWlhOamNtOTNYMmxrWFM1amIzQjVLQ2tLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaV052Y21RdWMzUmhkSFZ6Q2lBZ0lDQndkWE5vYVc1MElEazRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNall5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ1ZEdsdVpXeGZaWE5qY205M0xtTnZiblJ5WVdOMExsTmxiblJwYm1Wc1JYTmpjbTkzTG1kbGRGOWxjMk55YjNkZllXMXZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMlZ6WTNKdmQxOWhiVzkxYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJM01Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUdWelkzSnZkMTlwWkNCcGJpQnpaV3htTG1WelkzSnZkM01LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTlRjek0yRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpjMENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpWlhOamNtOTNJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxjMk55YjNjZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJM05TMHlOellLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpYTmpjbTkzYzF0bGMyTnliM2RmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTI5eVpDNWhiVzkxYm5RS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TnpBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6Wlc1MGFXNWxiRjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVVMlZ1ZEdsdVpXeEZjMk55YjNjdWNtVnNaV0Z6WlNobGMyTnliM2RmYVdRNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwemJXRnlkRjlqYjI1MGNtRmpkSE11YzJWdWRHbHVaV3hmWlhOamNtOTNMbU52Ym5SeVlXTjBMbE5sYm5ScGJtVnNSWE5qY205M0xuSmxiR1ZoYzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFeE9TMHhNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxiR1ZoYzJVb2MyVnNaaXdnWlhOamNtOTNYMmxrT2lCQ2VYUmxjeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGMyTnliM2RmYVdRdWJHVnVaM1JvSUQwOUlETXlMQ0FpYVc1MllXeHBaQ0JsYzJOeWIzZGZhV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJR1Z6WTNKdmQxOXBaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNamNLSUNBZ0lDOHZJR1Y0YVhOMGN5QTlJR1Z6WTNKdmQxOXBaQ0JwYmlCelpXeG1MbVZ6WTNKdmQzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJOVGN6TTJFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSmxjMk55YjNjZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWVhOelpYSjBJQzh2SUdWelkzSnZkeUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEk1TFRFek1Bb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVsYzJOeWIzZHpXMlZ6WTNKdmQxOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvTUNrc0lDSmxjMk55YjNjZ1lXeHlaV0ZrZVNCelpYUjBiR1ZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEazRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVE13Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQlZTVzUwTmpRb01Da3NJQ0psYzJOeWIzY2dZV3h5WldGa2VTQnpaWFIwYkdWa0lnb2dJQ0FnWW5SdmFRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR1Z6WTNKdmR5QmhiSEpsWVdSNUlITmxkSFJzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbkYxWVhKaGJuUnBibVZmWm14aFp5QTlQU0JWU1c1ME5qUW9NQ2tzSUNKbGMyTnliM2NnYVhNZ2NYVmhjbUZ1ZEdsdVpXUWlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWE5qY205M0lHbHpJSEYxWVhKaGJuUnBibVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV6TXkweE16a0tJQ0FnSUM4dklDTWdTVzV1WlhJZ2NHRjViV1Z1ZENCMGJ5QndjbTkyYVdSbGNnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhKbFkyOXlaQzV3Y205MmFXUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y21WamIzSmtMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBVRllTVTlOWDFCU1JVWkpXQ0FySUdJaVVrVk1SVUZUUlNJc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJ5WldObGFYWmxjajF5WldOdmNtUXVjSEp2ZG1sa1pYSXNDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNellLSUNBZ0lDOHZJR0Z0YjNWdWREMXlaV052Y21RdVlXMXZkVzUwTEFvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUc1dmRHVTlRVmhKVDAxZlVGSkZSa2xZSUNzZ1lpSlNSVXhGUVZORklpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzRNelF6TURNeU0yRTJNVGM0TmprMlpqWmtNMkUxTWpRMU5HTTBOVFF4TlRNME5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNek10TVRNMENpQWdJQ0F2THlBaklFbHVibVZ5SUhCaGVXMWxiblFnZEc4Z2NISnZkbWxrWlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNeUF2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXpNeTB4TXprS0lDQWdJQzh2SUNNZ1NXNXVaWElnY0dGNWJXVnVkQ0IwYnlCd2NtOTJhV1JsY2dvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEpsWTI5eVpDNXdjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljbVZqYjNKa0xtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFVGWVNVOU5YMUJTUlVaSldDQXJJR0lpVWtWTVJVRlRSU0lzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdjR0Y1WlhJOWNtVmpiM0prTG5CaGVXVnlMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hORFlLSUNBZ0lDOHZJR1JsWVdSc2FXNWxYM0p2ZFc1a1BYSmxZMjl5WkM1a1pXRmtiR2x1WlY5eWIzVnVaQ3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJqYjI1elpXNXpkWE5mY21WeGRXbHlaV1E5Y21WamIzSmtMbU52Ym5ObGJuTjFjMTl5WlhGMWFYSmxaQ3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElEZzRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFE1Q2lBZ0lDQXZMeUJwYm5SbGJuUmZhR0Z6YUQxeVpXTnZjbVF1YVc1MFpXNTBYMmhoYzJnc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHbHVkQ0F4TURZS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJREV3TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRReExURTFNUW9nSUNBZ0x5OGdJeUJOWVhKcklITmxkSFJzWldRS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M2MxdGxjMk55YjNkZmFXUmRJRDBnUlhOamNtOTNVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBYSmxZMjl5WkM1d1lYbGxjaXdLSUNBZ0lDOHZJQ0FnSUNCd2NtOTJhV1JsY2oxeVpXTnZjbVF1Y0hKdmRtbGtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhKbFkyOXlaQzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWkdWaFpHeHBibVZmY205MWJtUTljbVZqYjNKa0xtUmxZV1JzYVc1bFgzSnZkVzVrTEFvZ0lDQWdMeThnSUNBZ0lIRjFZWEpoYm5ScGJtVmZabXhoWnoxeVpXTnZjbVF1Y1hWaGNtRnVkR2x1WlY5bWJHRm5MQW9nSUNBZ0x5OGdJQ0FnSUdOdmJuTmxibk4xYzE5eVpYRjFhWEpsWkQxeVpXTnZjbVF1WTI5dWMyVnVjM1Z6WDNKbGNYVnBjbVZrTEFvZ0lDQWdMeThnSUNBZ0lHbHVkR1Z1ZEY5b1lYTm9QWEpsWTI5eVpDNXBiblJsYm5SZmFHRnphQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd05tRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJSE4wWVhSMWN6MVZTVzUwTmpRb01Ta3NDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5ERXRNVFV4Q2lBZ0lDQXZMeUFqSUUxaGNtc2djMlYwZEd4bFpBb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZHpXMlZ6WTNKdmQxOXBaRjBnUFNCRmMyTnliM2RTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVpYSTljbVZqYjNKa0xuQmhlV1Z5TEFvZ0lDQWdMeThnSUNBZ0lIQnliM1pwWkdWeVBYSmxZMjl5WkM1d2NtOTJhV1JsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVmpiM0prTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCa1pXRmtiR2x1WlY5eWIzVnVaRDF5WldOdmNtUXVaR1ZoWkd4cGJtVmZjbTkxYm1Rc0NpQWdJQ0F2THlBZ0lDQWdjWFZoY21GdWRHbHVaVjltYkdGblBYSmxZMjl5WkM1eGRXRnlZVzUwYVc1bFgyWnNZV2NzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVjMlZ1YzNWelgzSmxjWFZwY21Wa1BYSmxZMjl5WkM1amIyNXpaVzV6ZFhOZmNtVnhkV2x5WldRc0NpQWdJQ0F2THlBZ0lDQWdhVzUwWlc1MFgyaGhjMmc5Y21WamIzSmtMbWx1ZEdWdWRGOW9ZWE5vTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBcENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1Rb1pYTmpjbTkzWDJsa09pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFMU15MHhOVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxablZ1WkNoelpXeG1MQ0JsYzJOeWIzZGZhV1E2SUVKNWRHVnpLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdWelkzSnZkMTlwWkM1c1pXNW5kR2dnUFQwZ016SXNJQ0pwYm5aaGJHbGtJR1Z6WTNKdmQxOXBaQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdaWE5qY205M1gybGtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJNQW9nSUNBZ0x5OGdaWGhwYzNSeklEMGdaWE5qY205M1gybGtJR2x1SUhObGJHWXVaWE5qY205M2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTFOek16WVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbVZ6WTNKdmR5QnViM1FnWm05MWJtUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYTmpjbTkzSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TmpJdE1UWXpDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1WelkzSnZkM05iWlhOamNtOTNYMmxrWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlGVkpiblEyTkNnd0tTd2dJbVZ6WTNKdmR5QmhiSEpsWVdSNUlITmxkSFJzWldRaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPVGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DZ3dLU3dnSW1WelkzSnZkeUJoYkhKbFlXUjVJSE5sZEhSc1pXUWlDaUFnSUNCaWRHOXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWlhOamNtOTNJR0ZzY21WaFpIa2djMlYwZEd4bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNObGJuUnBibVZzWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5qVXRNVFkyQ2lBZ0lDQXZMeUFqSUVGc2JHOTNJSEpsWm5WdVpDQnBaam9nWkdWaFpHeHBibVVnY0dGemMyVmtJRTlTSUc5eVlXTnNaU0JsZUhCc2FXTnBkR3g1SUdOaGJHeHpDaUFnSUNBdkx5QnBjMTl2ZG1WeVpIVmxJRDBnUjJ4dlltRnNMbkp2ZFc1a0lENGdjbVZqYjNKa0xtUmxZV1JzYVc1bFgzSnZkVzVrQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ056SUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdZWE56WlhKMElHbHpYMjkyWlhKa2RXVWdiM0lnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBb0NpQWdJQ0JpYm5vZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1SZlltOXZiRjkwY25WbFFESUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHSjZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpaVzUwYVc1bGJGOWxjMk55YjNjdVkyOXVkSEpoWTNRdVUyVnVkR2x1Wld4RmMyTnliM2N1Y21WbWRXNWtYMkp2YjJ4ZlptRnNjMlZBTXdvS2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1SZlltOXZiRjkwY25WbFFESTZDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb0tjMjFoY25SZlkyOXVkSEpoWTNSekxuTmxiblJwYm1Wc1gyVnpZM0p2ZHk1amIyNTBjbUZqZEM1VFpXNTBhVzVsYkVWelkzSnZkeTV5WldaMWJtUmZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TmpjdE1UWTVDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZiM1psY21SMVpTQnZjaUJVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNnS0lDQWdJQzh2SUNBZ0lDQWlibTkwSUhsbGRDQnZkbVZ5WkhWbElHRnVaQ0JqWVd4c1pYSWdhWE1nYm05MElHOXlZV05zWlNJS0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2VXVjBJRzkyWlhKa2RXVWdZVzVrSUdOaGJHeGxjaUJwY3lCdWIzUWdiM0poWTJ4bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFM01TMHhOellLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXlaV052Y21RdWNHRjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhKbFkyOXlaQzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMUJXRWxQVFY5UVVrVkdTVmdnS3lCaUlsSkZSbFZPUkNJc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVGN5Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajF5WldOdmNtUXVjR0Y1WlhJc0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpaVzUwYVc1bGJGOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVGN6Q2lBZ0lDQXZMeUJoYlc5MWJuUTljbVZqYjNKa0xtRnRiM1Z1ZEN3S0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6Wlc1MGFXNWxiRjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjMENpQWdJQ0F2THlCdWIzUmxQVUZZU1U5TlgxQlNSVVpKV0NBcklHSWlVa1ZHVlU1RUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzRNelF6TURNeU0yRTJNVGM0TmprMlpqWmtNMkUxTWpRMU5EWTFOVFJsTkRRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elpXNTBhVzVsYkY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UY3hDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTNOUW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05sYm5ScGJtVnNYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TnpFdE1UYzJDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWNtVmpiM0prTG5CaGVXVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF5WldOdmNtUXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVFWaEpUMDFmVUZKRlJrbFlJQ3NnWWlKU1JVWlZUa1FpTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmxiblJwYm1Wc1gyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hPREFLSUNBZ0lDOHZJSEJ5YjNacFpHVnlQWEpsWTI5eVpDNXdjbTkyYVdSbGNpd0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTRNd29nSUNBZ0x5OGdjWFZoY21GdWRHbHVaVjltYkdGblBYSmxZMjl5WkM1eGRXRnlZVzUwYVc1bFgyWnNZV2NzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnWTI5dWMyVnVjM1Z6WDNKbGNYVnBjbVZrUFhKbFkyOXlaQzVqYjI1elpXNXpkWE5mY21WeGRXbHlaV1FzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMlZ1ZEdsdVpXeGZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakU0TlFvZ0lDQWdMeThnYVc1MFpXNTBYMmhoYzJnOWNtVmpiM0prTG1sdWRHVnVkRjlvWVhOb0xBb2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTVRBMkNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHbHVkQ0F4TURZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFM09DMHhPRGNLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0bGMyTnliM2RmYVdSZElEMGdSWE5qY205M1VtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIQmhlV1Z5UFhKbFkyOXlaQzV3WVhsbGNpd0tJQ0FnSUM4dklDQWdJQ0J3Y205MmFXUmxjajF5WldOdmNtUXVjSEp2ZG1sa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEpsWTI5eVpDNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaR1ZoWkd4cGJtVmZjbTkxYm1ROWNtVmpiM0prTG1SbFlXUnNhVzVsWDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhGMVlYSmhiblJwYm1WZlpteGhaejF5WldOdmNtUXVjWFZoY21GdWRHbHVaVjltYkdGbkxBb2dJQ0FnTHk4Z0lDQWdJR052Ym5ObGJuTjFjMTl5WlhGMWFYSmxaRDF5WldOdmNtUXVZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRHVnVkRjlvWVhOb1BYSmxZMjl5WkM1cGJuUmxiblJmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlWVWx1ZERZMEtESXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBMllRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyVnVkR2x1Wld4ZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdjM1JoZEhWelBWVkpiblEyTkNneUtTd0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJWdWRHbHVaV3hmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFM09DMHhPRGNLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzYzF0bGMyTnliM2RmYVdSZElEMGdSWE5qY205M1VtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIQmhlV1Z5UFhKbFkyOXlaQzV3WVhsbGNpd0tJQ0FnSUM4dklDQWdJQ0J3Y205MmFXUmxjajF5WldOdmNtUXVjSEp2ZG1sa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEpsWTI5eVpDNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaR1ZoWkd4cGJtVmZjbTkxYm1ROWNtVmpiM0prTG1SbFlXUnNhVzVsWDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhGMVlYSmhiblJwYm1WZlpteGhaejF5WldOdmNtUXVjWFZoY21GdWRHbHVaVjltYkdGbkxBb2dJQ0FnTHk4Z0lDQWdJR052Ym5ObGJuTjFjMTl5WlhGMWFYSmxaRDF5WldOdmNtUXVZMjl1YzJWdWMzVnpYM0psY1hWcGNtVmtMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRHVnVkRjlvWVhOb1BYSmxZMjl5WkM1cGJuUmxiblJmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlWVWx1ZERZMEtESXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1SZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5ObGJuUnBibVZzWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVUWlc1MGFXNWxiRVZ6WTNKdmR5NXlaV1oxYm1SZlltOXZiRjl0WlhKblpVQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBQUNBU1lFQTJWek9nSUFhaE53YjJ4cFkzbGZkbUYxYkhSZllYQndYMmxrQkJVZmZIVXhHRUFBTmlvalo0QVljbVZ3ZFhSaGRHbHZibDlzWldSblpYSmZZWEJ3WDJsa0kyZUFFMlJ1WVY5eVpXZHBjM1J5ZVY5aGNIQmZhV1FqWnpFWkZFUXhHRUVBT1lJSEJPZFJXMkVFMWtNR2dnU3NlZlZzQklzMGJ1c0U1d3JsRkFSUVlCWXVCTjR4S2FzMkdnQ09Cd0FkQUtnQXZRRFNBWm9DUGdKZ0FJQUVKQTB2WnpZYUFJNEJBQUVBTmhvQlNSVWlFa1FYS2t4bkpVTTJHZ0ZKRlVtQklCSkVOaG9DU1NOWkpBaExBUlVTUkZjQ0FEWWFBMGtWSWhKRUZ6WWFCRWtWSWhKRUYwc0NGVW1CSUJKRU1RQXhBVElHRmpFQVN3ZFFURkFCZ1NCUENCSkVNZ1pQQmdoUEEwOEhVRThERmxCTUZsQWpGa3hMQVZCUEJCWlFUd01XVndZQ1R3UlFUQ2xRVHdKUVRGQW9Td0pRU2J4SVRMK0FCaFVmZkhVQUlFeFFzQ1ZETmhvQlNTTlpKQWhMQVJVU1JGY0NBSWdCeHlWRE5ob0JTU05aSkFoTEFSVVNSRmNDQUlnQ1hDVkROaG9CU1NOWkpBaExBUlVTUkZjQ0FEWWFBa2tWSWhKRUYwc0JGVW1CSUJKRUtFc0RVRW05UlFGRVNZRmlJcm9YRkVSSkk0RWd1a3NCZ1NCSnVrc0NnVUFpdWhkTEE0RklJcm9YU3dTQldDSzZGMHNGZ1dva3VoY2tDRXNHZ1dwUEFycFhBZ0JMQlU4RlVFOEVGbEJQQXhaUUpSWlFUd0lXVUVzQkZSWlhCZ0pQQWxCTUtWQ0JBeFpRVEZCTEFyeElUd0pNdnpJR0Zrc0VURkFCTWdaUEF4WlhCZ0pQQlZCUEJCYUFBZ0F5VEZCUEFoWlFUd05RVEZDQUEySnNPazhDVUVtOFNFeS9KVU0yR2dGSkkxa2tDRXNCRlJKRVZ3SUFTVFlhQWtrVkloSkVGekVBTWdrU1JDaFBBbEJKdlVVQlJFbUJZaUs2RjRFREVrUkpJNEVndWtzQmdTQkp1a3NDZ1VBaXVoZExBNEZJSXJvWFN3U0JXQ0s2RjBzRmdXb2t1aGNrQ0VzR2dXcFBBcnBYQWdCUEJVOEZVRThFRmxCUEF4WlFJeFpNU3dGUVR3TVdVRXNDRlJaWEJnSlBBMUJNS1ZCUEFsQk1VRXNCdkVpL0pSSkJBQVdJQUV3bFE0Z0E4VUwvK0RZYUFVa2pXU1FJU3dFVkVrUlhBZ0FvVEZCSnZVVUJSSUZpSXJvclRGQ3dKVU0yR2dGSkkxa2tDRXNCRlJKRVZ3SUFLRXhRU2IxRkFVU0JRQ0s2SzB4UXNDVkRpZ0VBaS84VmdTQVNSQ2lMLzFCSnZVVUJSRW1CWWlLNkZ4UkVTWUZRSXJvWFNSUkVzVXNCZ1NCSnVrc0NnVUFpdWhlQUVuZzBNREk2WVhocGIyMDZVa1ZNUlVGVFJiSUZTYklJU3dHeUJ5V3lFQ095QWJOTEF5T0JJTHBMQklGSUlyb1hTd1dCV0NLNkYwc0dnV29rdWhja0NFc0hnV3BQQXJwWEFnQlBBMDhGVUU4RUZsQlBBeFpRVHdNV1VFOENGbEJMQVJVV1Z3WUNUd0pRVENsUUpSWlFURkJMQWJ4SXY0bUtBUUNML3hXQklCSkVLSXYvVUVjQ3ZVVUJSRW1CWWlLNkZ4UkVNZ1pNZ1VnaXVoZEpUZ0lOUUFBSU1RQXlDUkpCQUlnbFJMR0xBRWtqZ1NDNlN3R0JRQ0s2RjRBUmVEUXdNanBoZUdsdmJUcFNSVVpWVGtTeUJVbXlDRXNCc2djbHNoQWpzZ0d6U3dLQklFbTZTd09CVUNLNkYwc0VnVmdpdWhkTEJZRnFKTG9YSkFoTEJvRnFUd0s2VndJQVR3VlBCRkJQQkJaUWl3RVdVRThERmxCUEFoWlFTd0VWRmxjR0FrOENVRXdwVUNRV1VFeFFTd0c4U0wrSkkwTC9kUT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
