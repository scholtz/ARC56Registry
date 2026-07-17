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

namespace Arc56.Generated.Falcon0516.CleverFyre.ReputationLedger_1b15fb64
{


    //
    // 
    //    Social trust layer — score 0-1000 per agent.
    //
    //    Tier mapping:
    //      800+     EXCELLENT  — unlimited (within policy), auto-release
    //      600-799  GOOD       — up to 5 ALGO/call
    //      400-599  CAUTION    — up to 0.5 ALGO/call, intent logging mandatory
    //      200-399  RESTRICTED — quarantine, human review required
    //      0-199    BLACKLISTED — SentinelEscrow rejects all attempts
    //    
    //
    public class ReputationLedgerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReputationLedgerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReputationRecord : AVMObjectType
            {
                public ulong Score { get; set; }

                public ulong DriftEvents { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScore.From(Score);
                    ret.AddRange(vScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDriftEvents = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDriftEvents.From(DriftEvents);
                    ret.AddRange(vDriftEvents.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReputationRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReputationRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScore = vScore.ToValue();
                    if (valueScore is ulong vScoreValue) { ret.Score = vScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDriftEvents = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDriftEvents.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDriftEvents = vDriftEvents.ToValue();
                    if (valueDriftEvents is ulong vDriftEventsValue) { ret.DriftEvents = vDriftEventsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReputationRecord);
                }
                public bool Equals(ReputationRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReputationRecord left, ReputationRecord right)
                {
                    return EqualityComparer<ReputationRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ReputationRecord left, ReputationRecord right)
                {
                    return !(left == right);
                }

            }

            public class VouchRecord : AVMObjectType
            {
                public ulong StakeAmount { get; set; }

                public ulong RoundCreated { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeAmount.From(StakeAmount);
                    ret.AddRange(vStakeAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRoundCreated.From(RoundCreated);
                    ret.AddRange(vRoundCreated.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VouchRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VouchRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeAmount = vStakeAmount.ToValue();
                    if (valueStakeAmount is ulong vStakeAmountValue) { ret.StakeAmount = vStakeAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoundCreated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoundCreated = vRoundCreated.ToValue();
                    if (valueRoundCreated is ulong vRoundCreatedValue) { ret.RoundCreated = vRoundCreatedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VouchRecord);
                }
                public bool Equals(VouchRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VouchRecord left, VouchRecord right)
                {
                    return EqualityComparer<VouchRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(VouchRecord left, VouchRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Record the two trusted caller app IDs on deployment.
        ///</summary>
        /// <param name="sentinel_escrow_app_id"> </param>
        /// <param name="policy_vault_app_id"> </param>
        public async Task Create(ulong sentinel_escrow_app_id, ulong policy_vault_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 121, 255, 99 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);
            var policy_vault_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_vault_app_idAbi.From(policy_vault_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, sentinel_escrow_app_idAbi, policy_vault_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong sentinel_escrow_app_id, ulong policy_vault_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 121, 255, 99 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);
            var policy_vault_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_vault_app_idAbi.From(policy_vault_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, sentinel_escrow_app_idAbi, policy_vault_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a reputation record with neutral score = 500.
        ///Callable by anyone (idempotent guard inside).
        ///</summary>
        /// <param name="agent"> </param>
        public async Task RegisterAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 131, 90, 181 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 131, 90, 181 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Adjust agent's reputation score.
        ///delta       : amount to add or subtract. is_negative : 1 = subtract delta, 0 = add delta. Result is clamped to [0, 1000].
        ///ONLY callable by SentinelEscrow or PolicyVault app (via inner txn). On-chain caller verification uses Txn.sender being the trusted app address.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="delta"> </param>
        /// <param name="is_negative"> </param>
        public async Task UpdateScore(Algorand.Address agent, ulong delta, ulong is_negative, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 49, 251, 61 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);
            var is_negativeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_negativeAbi.From(is_negative);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, deltaAbi, is_negativeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScore_Transactions(Algorand.Address agent, ulong delta, ulong is_negative, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 49, 251, 61 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);
            var is_negativeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_negativeAbi.From(is_negative);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, deltaAbi, is_negativeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increment drift_events counter for a flagged agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task RecordDrift(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 136, 127, 32 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordDrift_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 136, 127, 32 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake 1 ALGO vouching for a peer agent's future behaviour.
        ///Slash conditions (enforced off-chain by oracle, then calls slash_voucher):   - vouchee score drops below 400 → slash 50% of stake. Reward condition (oracle calls reward_voucher):   - vouchee score rises above 800 → return stake + 10% bonus.
        ///</summary>
        /// <param name="voucher"> </param>
        /// <param name="vouchee"> </param>
        public async Task Vouch(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 63, 69, 139 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            var result = await base.CallApp(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Vouch_Transactions(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 63, 69, 139 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            return await base.MakeTransactionList(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Slash 50% of the voucher's stake because vouchee score dropped < 400.
        ///Called by oracle. Remaining 50% is refunded to voucher.
        ///</summary>
        /// <param name="voucher"> </param>
        /// <param name="vouchee"> </param>
        public async Task SlashVoucher(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 165, 106, 172 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            var result = await base.CallApp(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SlashVoucher_Transactions(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 165, 106, 172 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            return await base.MakeTransactionList(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return stake + 10% bonus when vouchee score exceeds 800.
        ///Called by the oracle.
        ///</summary>
        /// <param name="voucher"> </param>
        /// <param name="vouchee"> </param>
        public async Task RewardVoucher(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 63, 17, 39 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            var result = await base.CallApp(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RewardVoucher_Transactions(Algorand.Address voucher, Algorand.Address vouchee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 63, 17, 39 };
            var voucherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucherAbi.From(voucher);
            var voucheeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voucheeAbi.From(vouchee);

            return await base.MakeTransactionList(new List<object> { abiHandle, voucherAbi, voucheeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the current reputation score for an agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetScore(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetScore_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns tier: 0=BLACKLISTED, 1=RESTRICTED, 2=CAUTION, 3=GOOD, 4=EXCELLENT.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetTier(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 112, 115, 146 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTier_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 112, 115, 146 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total flagged drift events for forensic audit.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetDriftEvents(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 26, 45, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDriftEvents_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 26, 45, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvbkxlZGdlciIsImRlc2MiOiJcbiAgICBTb2NpYWwgdHJ1c3QgbGF5ZXIg4oCUIHNjb3JlIDAtMTAwMCBwZXIgYWdlbnQuXG5cbiAgICBUaWVyIG1hcHBpbmc6XG4gICAgICA4MDArICAgICBFWENFTExFTlQgIOKAlCB1bmxpbWl0ZWQgKHdpdGhpbiBwb2xpY3kpLCBhdXRvLXJlbGVhc2VcbiAgICAgIDYwMC03OTkgIEdPT0QgICAgICAg4oCUIHVwIHRvIDUgQUxHTy9jYWxsXG4gICAgICA0MDAtNTk5ICBDQVVUSU9OICAgIOKAlCB1cCB0byAwLjUgQUxHTy9jYWxsLCBpbnRlbnQgbG9nZ2luZyBtYW5kYXRvcnlcbiAgICAgIDIwMC0zOTkgIFJFU1RSSUNURUQg4oCUIHF1YXJhbnRpbmUsIGh1bWFuIHJldmlldyByZXF1aXJlZFxuICAgICAgMC0xOTkgICAgQkxBQ0tMSVNURUQg4oCUIFNlbnRpbmVsRXNjcm93IHJlamVjdHMgYWxsIGF0dGVtcHRzXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlJlcHV0YXRpb25SZWNvcmQiOlt7Im5hbWUiOiJzY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkcmlmdF9ldmVudHMiLCJ0eXBlIjoidWludDY0In1dLCJWb3VjaFJlY29yZCI6W3sibmFtZSI6InN0YWtlX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyb3VuZF9jcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiUmVjb3JkIHRoZSB0d28gdHJ1c3RlZCBjYWxsZXIgYXBwIElEcyBvbiBkZXBsb3ltZW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW50aW5lbF9lc2Nyb3dfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfdmF1bHRfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2FnZW50IiwiZGVzYyI6IkNyZWF0ZSBhIHJlcHV0YXRpb24gcmVjb3JkIHdpdGggbmV1dHJhbCBzY29yZSA9IDUwMC5cbkNhbGxhYmxlIGJ5IGFueW9uZSAoaWRlbXBvdGVudCBndWFyZCBpbnNpZGUpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Njb3JlIiwiZGVzYyI6IkFkanVzdCBhZ2VudCdzIHJlcHV0YXRpb24gc2NvcmUuXG5kZWx0YSAgICAgICA6IGFtb3VudCB0byBhZGQgb3Igc3VidHJhY3QuIGlzX25lZ2F0aXZlIDogMSA9IHN1YnRyYWN0IGRlbHRhLCAwID0gYWRkIGRlbHRhLiBSZXN1bHQgaXMgY2xhbXBlZCB0byBbMCwgMTAwMF0uXG5PTkxZIGNhbGxhYmxlIGJ5IFNlbnRpbmVsRXNjcm93IG9yIFBvbGljeVZhdWx0IGFwcCAodmlhIGlubmVyIHR4bikuIE9uLWNoYWluIGNhbGxlciB2ZXJpZmljYXRpb24gdXNlcyBUeG4uc2VuZGVyIGJlaW5nIHRoZSB0cnVzdGVkIGFwcCBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19uZWdhdGl2ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfZHJpZnQiLCJkZXNjIjoiSW5jcmVtZW50IGRyaWZ0X2V2ZW50cyBjb3VudGVyIGZvciBhIGZsYWdnZWQgYWdlbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3VjaCIsImRlc2MiOiJTdGFrZSAxIEFMR08gdm91Y2hpbmcgZm9yIGEgcGVlciBhZ2VudCdzIGZ1dHVyZSBiZWhhdmlvdXIuXG5TbGFzaCBjb25kaXRpb25zIChlbmZvcmNlZCBvZmYtY2hhaW4gYnkgb3JhY2xlLCB0aGVuIGNhbGxzIHNsYXNoX3ZvdWNoZXIpOiAgIC0gdm91Y2hlZSBzY29yZSBkcm9wcyBiZWxvdyA0MDAg4oaSIHNsYXNoIDUwJSBvZiBzdGFrZS4gUmV3YXJkIGNvbmRpdGlvbiAob3JhY2xlIGNhbGxzIHJld2FyZF92b3VjaGVyKTogICAtIHZvdWNoZWUgc2NvcmUgcmlzZXMgYWJvdmUgODAwIOKGkiByZXR1cm4gc3Rha2UgKyAxMCUgYm9udXMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3VjaGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm91Y2hlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzbGFzaF92b3VjaGVyIiwiZGVzYyI6IlNsYXNoIDUwJSBvZiB0aGUgdm91Y2hlcidzIHN0YWtlIGJlY2F1c2Ugdm91Y2hlZSBzY29yZSBkcm9wcGVkIDwgNDAwLlxuQ2FsbGVkIGJ5IG9yYWNsZS4gUmVtYWluaW5nIDUwJSBpcyByZWZ1bmRlZCB0byB2b3VjaGVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm91Y2hlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdWNoZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV3YXJkX3ZvdWNoZXIiLCJkZXNjIjoiUmV0dXJuIHN0YWtlICsgMTAlIGJvbnVzIHdoZW4gdm91Y2hlZSBzY29yZSBleGNlZWRzIDgwMC5cbkNhbGxlZCBieSB0aGUgb3JhY2xlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm91Y2hlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdWNoZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Njb3JlIiwiZGVzYyI6IlJldHVybiB0aGUgY3VycmVudCByZXB1dGF0aW9uIHNjb3JlIGZvciBhbiBhZ2VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RpZXIiLCJkZXNjIjoiUmV0dXJucyB0aWVyOiAwPUJMQUNLTElTVEVELCAxPVJFU1RSSUNURUQsIDI9Q0FVVElPTiwgMz1HT09ELCA0PUVYQ0VMTEVOVC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2RyaWZ0X2V2ZW50cyIsImRlc2MiOiJSZXR1cm4gdG90YWwgZmxhZ2dlZCBkcmlmdCBldmVudHMgZm9yIGZvcmVuc2ljIGF1ZGl0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6ImFnZW50IGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NCwzNjAsNjAyLDYyOSw3MDhdLCJlcnJvck1lc3NhZ2UiOiJhZ2VudCBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNF0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgdm91Y2hpbmcgZm9yIHRoaXMgYWdlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMsMjQzLDM1MiwzODUsMzkzLDQyOSw0MzcsNTExLDUxOSw1OTQsNjIxLDcwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzUsMTg0LDI1MSwyNjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTBdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGF0dGFjaCAxIEFMR08gdG8gdm91Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IG9yYWNsZS9hZG1pbiBjYW4gcmV3YXJkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQzXSwiZXJyb3JNZXNzYWdlIjoib25seSBvcmFjbGUvYWRtaW4gY2FuIHNsYXNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU2LDUzOF0sImVycm9yTWVzc2FnZSI6InZvdWNoIHJlY29yZCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURNeUlEQWdPQ0F4TURBd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROekkyTlRjd00yRWdNSGczTmpZek0yRWdNSGd4TlRGbU4yTTNOU0FpYzJWdWRHbHVaV3hmWVhCd1gybGtJaUFpY0c5c2FXTjVYM1poZFd4MFgyRndjRjlwWkNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG8yT1MwM01Bb2dJQ0FnTHk4Z0l5QlVjblZ6ZEdWa0lHTmhiR3hsY2lCaGNIQWdTVVJ6Q2lBZ0lDQXZMeUJ6Wld4bUxuTmxiblJwYm1Wc1gyRndjRjlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMyVnVkR2x1Wld4ZllYQndYMmxrSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUhObGJHWXVjRzlzYVdONVgzWmhkV3gwWDJGd2NGOXBaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpY0c5c2FXTjVYM1poZFd4MFgyRndjRjlwWkNJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJR05zWVhOeklGSmxjSFYwWVhScGIyNU1aV1JuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UVUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhZVGd6TldGaU5TQXdlR1kwTXpGbVlqTmtJREI0WldNNE9EZG1NakFnTUhobU1ETm1ORFU0WWlBd2VETmxZVFUyWVdGaklEQjRORFl6WmpFeE1qY2dNSGd5TURWaU56SXdZeUF3ZUdNNU56QTNNemt5SURCNE9UUXhZVEprTWpFZ0x5OGdiV1YwYUc5a0lDSnlaV2RwYzNSbGNsOWhaMlZ1ZENoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXpZMjl5WlNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmpiM0prWDJSeWFXWjBLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRtOTFZMmdvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTnNZWE5vWDNadmRXTm9aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxkMkZ5WkY5MmIzVmphR1Z5S0dGa1pISmxjM01zWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmYzJOdmNtVW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYVdWeUtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZaSEpwWm5SZlpYWmxiblJ6S0dGa1pISmxjM01wZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWEpmWVdkbGJuUWdkWEJrWVhSbFgzTmpiM0psSUhKbFkyOXlaRjlrY21sbWRDQjJiM1ZqYUNCemJHRnphRjkyYjNWamFHVnlJSEpsZDJGeVpGOTJiM1ZqYUdWeUlHZGxkRjl6WTI5eVpTQm5aWFJmZEdsbGNpQm5aWFJmWkhKcFpuUmZaWFpsYm5SekNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJR05zWVhOeklGSmxjSFYwWVhScGIyNU1aV1JuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGswTnpsbVpqWXpJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TG1OdmJuUnlZV04wTGxKbGNIVjBZWFJwYjI1TVpXUm5aWEl1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJSE5sYkdZdWMyVnVkR2x1Wld4ZllYQndYMmxrSUQwZ2MyVnVkR2x1Wld4ZlpYTmpjbTkzWDJGd2NGOXBaQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljMlZ1ZEdsdVpXeGZZWEJ3WDJsa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pneENpQWdJQ0F2THlCelpXeG1MbkJ2YkdsamVWOTJZWFZzZEY5aGNIQmZhV1FnUFNCd2IyeHBZM2xmZG1GMWJIUmZZWEJ3WDJsa0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKd2IyeHBZM2xmZG1GMWJIUmZZWEJ3WDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k1amIyNTBjbUZqZEM1U1pYQjFkR0YwYVc5dVRHVmtaMlZ5TG5KbFoybHpkR1Z5WDJGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpmWVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUdGblpXNTBJR2x1SUhObGJHWXVjbVZ3WDNKbFkyOXlaSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTWpZMU56QXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR1Y0YVhOMGN5d2dJbUZuWlc1MElHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzVOUzA1T0FvZ0lDQWdMeThnYzJWc1ppNXlaWEJmY21WamIzSmtjMXRoWjJWdWRGMGdQU0JTWlhCMWRHRjBhVzl1VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhOamIzSmxQVlZKYm5RMk5DZzFNREFwTEFvZ0lDQWdMeThnSUNBZ0lHUnlhV1owWDJWMlpXNTBjejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01XWTBNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXVZMjl1ZEhKaFkzUXVVbVZ3ZFhSaGRHbHZia3hsWkdkbGNpNTFjR1JoZEdWZmMyTnZjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZmYzJOdmNtVTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJsZUdsemRITWdQU0JoWjJWdWRDQnBiaUJ6Wld4bUxuSmxjRjl5WldOdmNtUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekkyTlRjd00yRUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpWVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JoYzNObGNuUWdMeThnWVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1Y21Wd1gzSmxZMjl5WkhOYllXZGxiblJkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklHTjFjbkpsYm5RZ1BTQnlaV052Y21RdWMyTnZjbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakV5TndvZ0lDQWdMeThnYVdZZ2FYTmZibVZuWVhScGRtVWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQjFjR1JoZEdWZmMyTnZjbVZmWld4elpWOWliMlI1UURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qZ0tJQ0FnSUM4dklHbG1JR04xY25KbGJuUWdQajBnWkdWc2RHRTZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnWW5vZ2RYQmtZWFJsWDNOamIzSmxYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCdVpYZGZjMk52Y21VZ1BTQmpkWEp5Wlc1MElDMGdaR1ZzZEdFS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTlFvS2RYQmtZWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJR1J5YVdaMFgyVjJaVzUwY3oxeVpXTnZjbVF1WkhKcFpuUmZaWFpsYm5SekxBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UTTNMVEUwTUFvZ0lDQWdMeThnYzJWc1ppNXlaWEJmY21WamIzSmtjMXRoWjJWdWRGMGdQU0JTWlhCMWRHRjBhVzl1VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhOamIzSmxQVzVsZDE5elkyOXlaU3dLSUNBZ0lDOHZJQ0FnSUNCa2NtbG1kRjlsZG1WdWRITTljbVZqYjNKa0xtUnlhV1owWDJWMlpXNTBjeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuVndaR0YwWlY5elkyOXlaVjlsYkhObFgySnZaSGxBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16RUtJQ0FnSUM4dklHNWxkMTl6WTI5eVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQjFjR1JoZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQTVDZ3AxY0dSaGRHVmZjMk52Y21WZlpXeHpaVjlpYjJSNVFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUJ1WlhkZmMyTnZjbVVnUFNCamRYSnlaVzUwSUNzZ1pHVnNkR0VLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJwWmlCdVpYZGZjMk52Y21VZ1BpQlZTVzUwTmpRb01UQXdNQ2s2Q2lBZ0lDQndkWE5vYVc1MElERXdNREFLSUNBZ0lENEtJQ0FnSUdKNklIVndaR0YwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNelVLSUNBZ0lDOHZJRzVsZDE5elkyOXlaU0E5SUZWSmJuUTJOQ2d4TURBd0tRb2dJQ0FnY0hWemFHbHVkQ0F4TURBd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdJZ2RYQmtZWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTVqYjI1MGNtRmpkQzVTWlhCMWRHRjBhVzl1VEdWa1oyVnlMbkpsWTI5eVpGOWtjbWxtZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjl5WkY5a2NtbG1kRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TkRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QmxlR2x6ZEhNZ1BTQmhaMlZ1ZENCcGJpQnpaV3htTG5KbGNGOXlaV052Y21SekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56STJOVGN3TTJFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0poWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFME53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV5WlhCZmNtVmpiM0prYzF0aFoyVnVkRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwT1FvZ0lDQWdMeThnYzJOdmNtVTljbVZqYjNKa0xuTmpiM0psTEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnWkhKcFpuUmZaWFpsYm5SelBYSmxZMjl5WkM1a2NtbG1kRjlsZG1WdWRITWdLeUJWU1c1ME5qUW9NU2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UUTRMVEUxTVFvZ0lDQWdMeThnYzJWc1ppNXlaWEJmY21WamIzSmtjMXRoWjJWdWRGMGdQU0JTWlhCMWRHRjBhVzl1VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhOamIzSmxQWEpsWTI5eVpDNXpZMjl5WlN3S0lDQWdJQzh2SUNBZ0lDQmtjbWxtZEY5bGRtVnVkSE05Y21WamIzSmtMbVJ5YVdaMFgyVjJaVzUwY3lBcklGVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFME1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TG1OdmJuUnlZV04wTGxKbGNIVjBZWFJwYjI1TVpXUm5aWEl1ZG05MVkyaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyYjNWamFEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TmpjS0lDQWdJQzh2SUhadmRXTm9YMnRsZVNBOUlHOXdMbk5vWVRJMU5paDJiM1ZqYUdWeUxtSjVkR1Z6SUNzZ2RtOTFZMmhsWlM1aWVYUmxjeWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTRDaUFnSUNBdkx5QmhiSEpsWVdSNVgzWnZkV05vYVc1bklEMGdkbTkxWTJoZmEyVjVJR2x1SUhObGJHWXVkbTkxWTJoZmMzUmhhMlZ6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TnpZMk16TmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR0ZzY21WaFpIbGZkbTkxWTJocGJtY3NJQ0poYkhKbFlXUjVJSFp2ZFdOb2FXNW5JR1p2Y2lCMGFHbHpJR0ZuWlc1MElnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIa2dkbTkxWTJocGJtY2dabTl5SUhSb2FYTWdZV2RsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE56RXRNVGN5Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0JoZEhSaFkyaGxaQ0F4SUVGTVIwOGdjR0Y1YldWdWRBb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNW1aV1VnUGowZ1ZVbHVkRFkwS0ZaUFZVTklYMEZOVDFWT1ZGOU5TVU5TVDBGTVIwOHBMQ0FpYlhWemRDQmhkSFJoWTJnZ01TQkJURWRQSUhSdklIWnZkV05vSWdvZ0lDQWdkSGh1SUVabFpRb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQXdNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JYVnpkQ0JoZEhSaFkyZ2dNU0JCVEVkUElIUnZJSFp2ZFdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UYzRDaUFnSUNBdkx5QnliM1Z1WkY5amNtVmhkR1ZrUFVkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTNOd29nSUNBZ0x5OGdjM1JoYTJWZllXMXZkVzUwUFZWSmJuUTJOQ2hXVDFWRFNGOUJUVTlWVGxSZlRVbERVazlCVEVkUEtTd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTNPUW9nSUNBZ0x5OGdjMlZzWmk1MmIzVmphRjl6ZEdGclpYTmJkbTkxWTJoZmEyVjVYU0E5SUZadmRXTm9VbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFgyRnRiM1Z1ZEQxVlNXNTBOalFvVms5VlEwaGZRVTFQVlU1VVgwMUpRMUpQUVV4SFR5a3NDaUFnSUNBdkx5QWdJQ0FnY205MWJtUmZZM0psWVhSbFpEMUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpNWpiMjUwY21GamRDNVNaWEIxZEdGMGFXOXVUR1ZrWjJWeUxuTnNZWE5vWDNadmRXTm9aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemJHRnphRjkyYjNWamFHVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE53b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltOXViSGtnYjNKaFkyeGxMMkZrYldsdUlHTmhiaUJ6YkdGemFDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUc5eVlXTnNaUzloWkcxcGJpQmpZVzRnYzJ4aGMyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hPRGdLSUNBZ0lDOHZJSFp2ZFdOb1gydGxlU0E5SUc5d0xuTm9ZVEkxTmloMmIzVmphR1Z5TG1KNWRHVnpJQ3NnZG05MVkyaGxaUzVpZVhSbGN5a0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE9Rb2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ2RtOTFZMmhmYTJWNUlHbHVJSE5sYkdZdWRtOTFZMmhmYzNSaGEyVnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROelkyTXpOaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRrd0NpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpZG05MVkyZ2djbVZqYjNKa0lHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCMmIzVmphQ0J5WldOdmNtUWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVGt4Q2lBZ0lDQXZMeUJ6ZEdGclpTQTlJSE5sYkdZdWRtOTFZMmhmYzNSaGEyVnpXM1p2ZFdOb1gydGxlVjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakU1TXdvZ0lDQWdMeThnYzJ4aGMyaGZZVzF2ZFc1MElEMGdjM1JoYTJVdWMzUmhhMlZmWVcxdmRXNTBJQzh2SUZWSmJuUTJOQ2d5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNU5Bb2dJQ0FnTHk4Z2NtVm1kVzVrWDJGdGIzVnVkQ0E5SUhOMFlXdGxMbk4wWVd0bFgyRnRiM1Z1ZENBdElITnNZWE5vWDJGdGIzVnVkQW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTVOaTB5TURJS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSUdoaGJHWWdkRzhnZG05MVkyaGxjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYWnZkV05vWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYSmxablZ1WkY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDFpSW5nME1ESTZZWGhwYjIwNlUweEJVMGdpTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJ1YjNSbFBXSWllRFF3TWpwaGVHbHZiVHBUVEVGVFNDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNPRE0wTXpBek1qTmhOakUzT0RZNU5tWTJaRE5oTlRNMFl6UXhOVE0wT0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JPYjNSbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTVOaTB4T1RjS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSUdoaGJHWWdkRzhnZG05MVkyaGxjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3TVFvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTVOaTB5TURJS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSUdoaGJHWWdkRzhnZG05MVkyaGxjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYWnZkV05vWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYSmxablZ1WkY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDFpSW5nME1ESTZZWGhwYjIwNlUweEJVMGdpTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnWkdWc0lITmxiR1l1ZG05MVkyaGZjM1JoYTJWelczWnZkV05vWDJ0bGVWMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsY0hWMFlYUnBiMjVmYkdWa1oyVnlMbU52Ym5SeVlXTjBMbEpsY0hWMFlYUnBiMjVNWldSblpYSXVjbVYzWVhKa1gzWnZkV05vWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWGRoY21SZmRtOTFZMmhsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0p2Ym14NUlHOXlZV05zWlM5aFpHMXBiaUJqWVc0Z2NtVjNZWEprSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2diM0poWTJ4bEwyRmtiV2x1SUdOaGJpQnlaWGRoY21RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1UTUtJQ0FnSUM4dklIWnZkV05vWDJ0bGVTQTlJRzl3TG5Ob1lUSTFOaWgyYjNWamFHVnlMbUo1ZEdWeklDc2dkbTkxWTJobFpTNWllWFJsY3lrS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakl4TkFvZ0lDQWdMeThnWlhocGMzUnpJRDBnZG05MVkyaGZhMlY1SUdsdUlITmxiR1l1ZG05MVkyaGZjM1JoYTJWekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE56WTJNek5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNakUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlkbTkxWTJnZ2NtVmpiM0prSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUIyYjNWamFDQnlaV052Y21RZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QnpkR0ZyWlNBOUlITmxiR1l1ZG05MVkyaGZjM1JoYTJWelczWnZkV05vWDJ0bGVWMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXhPQW9nSUNBZ0x5OGdZbTl1ZFhNZ1BTQnpkR0ZyWlM1emRHRnJaVjloYlc5MWJuUWdMeThnVlVsdWREWTBLREV3S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1Ua0tJQ0FnSUM4dklISmxkMkZ5WkNBOUlITjBZV3RsTG5OMFlXdGxYMkZ0YjNWdWRDQXJJR0p2Ym5WekNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpJeExUSXlOZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYWnZkV05vWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYSmxkMkZ5WkN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFdJaWVEUXdNanBoZUdsdmJUcFNSVmRCVWtRaUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpJMENpQWdJQ0F2THlCdWIzUmxQV0lpZURRd01qcGhlR2x2YlRwU1JWZEJVa1FpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Tnpnek5ETXdNekl6WVRZeE56ZzJPVFptTm1RellUVXlORFUxTnpReE5USTBOQW9nSUNBZ2FYUjRibDltYVdWc1pDQk9iM1JsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeU1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXlOUW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeU1TMHlNallLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMTJiM1ZqYUdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaWGRoY21Rc0NpQWdJQ0F2THlBZ0lDQWdibTkwWlQxaUluZzBNREk2WVhocGIyMDZVa1ZYUVZKRUlpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1qZ0tJQ0FnSUM4dklHUmxiQ0J6Wld4bUxuWnZkV05vWDNOMFlXdGxjMXQyYjNWamFGOXJaWGxkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k1amIyNTBjbUZqZEM1U1pYQjFkR0YwYVc5dVRHVmtaMlZ5TG1kbGRGOXpZMjl5WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl6WTI5eVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpNM0NpQWdJQ0F2THlCbGVHbHpkSE1nUFNCaFoyVnVkQ0JwYmlCelpXeG1MbkpsY0Y5eVpXTnZjbVJ6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpJMk5UY3dNMkVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakl6T1FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNXlaWEJmY21WamIzSmtjMXRoWjJWdWRGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3lOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaV052Y21RdWMyTnZjbVVLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNak0wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXVZMjl1ZEhKaFkzUXVVbVZ3ZFhSaGRHbHZia3hsWkdkbGNpNW5aWFJmZEdsbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MGFXVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakkwTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5EY0tJQ0FnSUM4dklHVjRhWE4wY3lBOUlHRm5aVzUwSUdsdUlITmxiR1l1Y21Wd1gzSmxZMjl5WkhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01qWTFOekF6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakkwT0FvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbUZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZWE56WlhKMElDOHZJR0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpRNUNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbkpsY0Y5eVpXTnZjbVJ6VzJGblpXNTBYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakkxTUFvZ0lDQWdMeThnYzJOdmNtVWdQU0J5WldOdmNtUXVjMk52Y21VS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVeUNpQWdJQ0F2THlCcFppQnpZMjl5WlNBK1BTQlZTVzUwTmpRb1ZFbEZVbDlGV0VORlRFeEZUbFFwT2dvZ0lDQWdjSFZ6YUdsdWRDQTRNREFLSUNBZ0lENDlDaUFnSUNCaWVpQm5aWFJmZEdsbGNsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UTUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTkNrS0lDQWdJSEIxYzJocGJuUWdOQW9LWjJWMFgzUnBaWEpmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdVkyOXVkSEpoWTNRdVVtVndkWFJoZEdsdmJreGxaR2RsY2k1blpYUmZkR2xsY2tBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYM1JwWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pJMU5Bb2dJQ0FnTHk4Z2FXWWdjMk52Y21VZ1BqMGdWVWx1ZERZMEtGUkpSVkpmUjA5UFJDazZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpBd0NpQWdJQ0ErUFFvZ0lDQWdZbm9nWjJWMFgzUnBaWEpmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNalUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtETXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQm5aWFJmZEdsbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTVqYjI1MGNtRmpkQzVTWlhCMWRHRjBhVzl1VEdWa1oyVnlMbWRsZEY5MGFXVnlRREV3Q2dwblpYUmZkR2xsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVMkNpQWdJQ0F2THlCcFppQnpZMjl5WlNBK1BTQlZTVzUwTmpRb1ZFbEZVbDlEUVZWVVNVOU9LVG9LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME1EQUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCblpYUmZkR2xsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG95TlRjS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NaWtLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTBNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmlJR2RsZEY5MGFXVnlYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5KbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TG1OdmJuUnlZV04wTGxKbGNIVjBZWFJwYjI1TVpXUm5aWEl1WjJWMFgzUnBaWEpBTVRBS0NtZGxkRjkwYVdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UZ0tJQ0FnSUM4dklHbG1JSE5qYjNKbElENDlJRlZKYm5RMk5DaFVTVVZTWDFKRlUxUlNTVU5VUlVRcE9nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREl3TUFvZ0lDQWdQajBLSUNBZ0lHSjZJR2RsZEY5MGFXVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTFPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQm5aWFJmZEdsbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCMWRHRjBhVzl1WDJ4bFpHZGxjaTVqYjI1MGNtRmpkQzVTWlhCMWRHRjBhVzl1VEdWa1oyVnlMbWRsZEY5MGFXVnlRREV3Q2dwblpYUmZkR2xsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpZd0NpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakkwTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpSUdkbGRGOTBhV1Z5WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUxtTnZiblJ5WVdOMExsSmxjSFYwWVhScGIyNU1aV1JuWlhJdVoyVjBYM1JwWlhKQU1UQUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl1WTI5dWRISmhZM1F1VW1Wd2RYUmhkR2x2Ymt4bFpHZGxjaTVuWlhSZlpISnBablJmWlhabGJuUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyUnlhV1owWDJWMlpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG95TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qWTFDaUFnSUNBdkx5QmxlR2x6ZEhNZ1BTQmhaMlZ1ZENCcGJpQnpaV3htTG5KbGNGOXlaV052Y21SekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56STJOVGN3TTJFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG95TmpZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0poWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pJMk53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV5WlhCZmNtVmpiM0prYzF0aFoyVnVkRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG95TmpnS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldOdmNtUXVaSEpwWm5SZlpYWmxiblJ6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVNBQUNNQ0VQU1lGQkhKbGNEb0RkbU02QkJVZmZIVVBjMlZ1ZEdsdVpXeGZZWEJ3WDJsa0UzQnZiR2xqZVY5MllYVnNkRjloY0hCZmFXUXhHRUFBQnlza1p5Y0VKR2N4R1JSRU1SaEJBRWVDQ1FTcWcxcTFCUFF4K3owRTdJaC9JQVR3UDBXTEJENmxhcXdFUmo4Ukp3UWdXM0lNQk1sd2M1SUVsQm90SVRZYUFJNEpBQ3NBVVFEQUFPRUJEUUZmQWJJQnpRSWNBSUFFbEhuL1l6WWFBSTRCQUFFQU5ob0JTUlVsRWtRWE5ob0NTUlVsRWtRWEswOENaeWNFVEdjaVF6WWFBVWtWSXhKRUtFeFFTYjFGQVJSRWdCQUFBQUFBQUFBQjlBQUFBQUFBQUFBQXZ5SkRnQUEyR2dGSkZTTVNSRFlhQWtrVkpSSkVGMHcyR2dOSkZTVVNSQmNvVHdKUVNVNENTYjFGQVVTK1NFbE9BaVJiVENJU1FRQWpTVXNFRDBFQUZrbExCQWxGQlVzQlZ3Z0lTd1VXVEZCTEEweS9Ja01rUlFWQy8rcEpTd1FJU1VVR2dlZ0hEVUgvM0lIb0IwVUZRdi9VTmhvQlNSVWpFa1FvVEZCSnZVVUJSRW0rU0VsWEFBaE1KVnNpQ0JaUXZ5SkROaG9CU1JVakVrUTJHZ0pKRlNNU1JGQUJLVXhRU2IxRkFSUkVNUUVoQkE5RU1nWWhCQlpNRmxDL0lrTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRU1RQXlDUkpFU3dGTVVBRXBURkJKdlVVQlJFbStTQ1JiU1lFQ0NnbXhnQkI0TkRBeU9tRjRhVzl0T2xOTVFWTklzZ1d5Q0V5eUJ5S3lFQ1N5QWJPOFNDSkROaG9CU1JVakVrUTJHZ0pKRlNNU1JERUFNZ2tTUkVzQlRGQUJLVXhRU2IxRkFVUkp2a2drVzBtQkNnb0lzWUFSZURRd01qcGhlR2x2YlRwU1JWZEJVa1N5QmJJSVRMSUhJcklRSkxJQnM3eElJa00yR2dGSkZTTVNSQ2hNVUVtOVJRRkV2a2hYQUFncVRGQ3dJa00yR2dGSkZTTVNSQ2hNVUVtOVJRRkV2a2drVzBtQm9BWVBRUUFKZ1FRV0treFFzQ0pEU1lIWUJBOUJBQVdCQTBMLzdFbUJrQU1QUVFBRmdRSkMvOTlKZ2NnQkQwRUFCQ0pDLzlNa1F2L1BOaG9CU1JVakVrUW9URkJKdlVVQlJMNUlWd2dJS2t4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
