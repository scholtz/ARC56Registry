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

namespace Arc56.Generated.quantalabss.algo_pqc_kit.PQCDao_9bfcce27
{


    public class PQCDaoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PQCDaoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class DaoProposalCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 6, 175, 197, 102 };
                public const string Signature = "DaoProposalCreated(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong ProposalId { get; set; }
                public ulong EndTime { get; set; }

                public static DaoProposalCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DaoProposalCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is ulong vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndTime = vEndTime.ToValue();
                    if (valueEndTime is ulong vEndTimeValue) { ret.EndTime = vEndTimeValue; }
                    return ret;

                }

            }

            public class DaoVoteSubmittedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 5, 4, 110, 218 };
                public const string Signature = "DaoVoteSubmitted(uint64,uint64,uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong ProposalId { get; set; }
                public ulong SignerIndex { get; set; }
                public byte VoteType { get; set; }

                public static DaoVoteSubmittedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DaoVoteSubmittedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is ulong vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignerIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignerIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignerIndex = vSignerIndex.ToValue();
                    if (valueSignerIndex is ulong vSignerIndexValue) { ret.SignerIndex = vSignerIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoteType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vVoteType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVoteType = vVoteType.ToValue();
                    if (valueVoteType is byte vVoteTypeValue) { ret.VoteType = vVoteTypeValue; }
                    return ret;

                }

            }

            public class DaoExecutedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 234, 189, 64, 158 };
                public const string Signature = "DaoExecuted(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong ProposalId { get; set; }

                public static DaoExecutedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DaoExecutedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is ulong vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="dao_name"> </param>
        /// <param name="threshold"> </param>
        /// <param name="num_members"> </param>
        /// <param name="voting_period"> </param>
        /// <param name="execution_delay"> </param>
        public async Task Create(string dao_name, ulong threshold, ulong num_members, ulong voting_period, ulong execution_delay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 250, 203, 95 };
            var dao_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dao_nameAbi.From(dao_name);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var num_membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_membersAbi.From(num_members);
            var voting_periodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voting_periodAbi.From(voting_period);
            var execution_delayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execution_delayAbi.From(execution_delay);

            var result = await base.CallApp(new List<object> { abiHandle, dao_nameAbi, thresholdAbi, num_membersAbi, voting_periodAbi, execution_delayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string dao_name, ulong threshold, ulong num_members, ulong voting_period, ulong execution_delay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 250, 203, 95 };
            var dao_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dao_nameAbi.From(dao_name);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var num_membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_membersAbi.From(num_members);
            var voting_periodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voting_periodAbi.From(voting_period);
            var execution_delayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execution_delayAbi.From(execution_delay);

            return await base.MakeTransactionList(new List<object> { abiHandle, dao_nameAbi, thresholdAbi, num_membersAbi, voting_periodAbi, execution_delayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="public_key"> </param>
        public async Task AddMember(ulong index, byte[] public_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 235, 231, 38 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var public_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_keyAbi.From(public_key);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, public_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddMember_Transactions(ulong index, byte[] public_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 235, 231, 38 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var public_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); public_keyAbi.From(public_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, public_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="description"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        public async Task<ulong> SubmitProposal(string description, Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 92, 195, 230 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitProposal_Transactions(string description, Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 92, 195, 230 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="signer_index"> </param>
        /// <param name="vote_type"> </param>
        /// <param name="signature"> </param>
        public async Task SubmitVote(ulong proposal_id, ulong signer_index, byte vote_type, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 36, 194, 187 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var signer_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); signer_indexAbi.From(signer_index);
            var vote_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); vote_typeAbi.From(vote_type);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, signer_indexAbi, vote_typeAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitVote_Transactions(ulong proposal_id, ulong signer_index, byte vote_type, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 36, 194, 187 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var signer_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); signer_indexAbi.From(signer_index);
            var vote_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); vote_typeAbi.From(vote_type);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, signer_indexAbi, vote_typeAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task ExecuteProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 139, 236, 35 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecuteProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 139, 236, 35 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetProposalCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 143, 186, 116 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetProposalCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 143, 186, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUFFDRGFvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYW9fbmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGhyZXNob2xkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1fbWVtYmVycyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90aW5nX3BlcmlvZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhlY3V0aW9uX2RlbGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9tZW1iZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY19rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0X3Byb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGFvUHJvcG9zYWxDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kX3RpbWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfdm90ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmVyX2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVfdHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmF0dXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEYW9Wb3RlU3VibWl0dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2lnbmVyX2luZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlX3R5cGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGVjdXRlX3Byb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJEYW9FeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wcm9wb3NhbF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RocmVzaG9sZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjUsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1OTBdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHZvdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMwXSwiZXJyb3JNZXNzYWdlIjoiREFPIHJlcXVpcmVzIGF0IGxlYXN0IDEgbWVtYmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMyLDc4NF0sImVycm9yTWVzc2FnZSI6IkV4ZWN1dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAxXSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTNdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHNpZ25hdHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMyw3NjhdLCJlcnJvck1lc3NhZ2UiOiJObyBwcm9wb3NhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMV0sImVycm9yTWVzc2FnZSI6IlF1b3J1bSBub3QgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNV0sImVycm9yTWVzc2FnZSI6IlJlamVjdGVkIGJ5IG1ham9yaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk3XSwiZXJyb3JNZXNzYWdlIjoiU2lnbmVyIGtleSBtaXNzaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3XSwiZXJyb3JNZXNzYWdlIjoiVGhyZXNob2xkIGNhbm5vdCBleGNlZWQgbWVtYmVyIGNvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxXSwiZXJyb3JNZXNzYWdlIjoiVGhyZXNob2xkIG11c3QgYmUgPj0gMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwM10sImVycm9yTWVzc2FnZSI6IlRpbWVsb2NrIGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2NF0sImVycm9yTWVzc2FnZSI6IlZvdGluZyBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0OF0sImVycm9yTWVzc2FnZSI6IlZvdGluZyBoYXNuJ3Qgc3RhcnRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXhlY3V0aW9uX2RlbGF5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nyw0OTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm51bV9tZW1iZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OCw5NjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByb3Bvc2FsX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxNyw5NzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRocmVzaG9sZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGluZ19wZXJpb2QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyLDI4MCwzMTcsNDg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5LDI4NywzMjQsNDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTAsMTk5LDIwOCwyMTcsMjczLDM0NCw0NTYsNDY4LDc1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSWdJblJvY21WemFHOXNaQ0lnSW01MWJWOXRaVzFpWlhKeklpQXdlRGN3TnpJMlpqY3dOV1lnTUhnd01EUmlJREI0TVRVeFpqZGpOelVnSW5admRHbHVaMTl3WlhKcGIyUWlJQ0psZUdWamRYUnBiMjVmWkdWc1lYa2lJREI0TnpBMllqVm1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG8wTXdvZ0lDQWdMeThnWTJ4aGMzTWdVRkZEUkdGdktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXlDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZVEZsWW1VM01qWWdNSGd3WkRWall6TmxOaUF3ZURRMk1qUmpNbUppSURCNE16TTRZbVZqTWpNZ01IZzJaRGhtWW1FM05DQXdlR00yTlRCa05XRTBJQzh2SUcxbGRHaHZaQ0FpWVdSa1gyMWxiV0psY2loMWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjFZbTFwZEY5d2NtOXdiM05oYkNoemRISnBibWNzWVdSa2NtVnpjeXgxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnpkV0p0YVhSZmRtOTBaU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblE0TEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmxlR1ZqZFhSbFgzQnliM0J2YzJGc0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmNISnZjRzl6WVd4ZlkyOTFiblFvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzUm9jbVZ6YUc5c1pDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZV1JrWDIxbGJXSmxjaUJ6ZFdKdGFYUmZjSEp2Y0c5ellXd2djM1ZpYldsMFgzWnZkR1VnWlhobFkzVjBaVjl3Y205d2IzTmhiQ0JuWlhSZmNISnZjRzl6WVd4ZlkyOTFiblFnWjJWMFgzUm9jbVZ6YUc5c1pBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TkRNS0lDQWdJQzh2SUdOc1lYTnpJRkJSUTBSaGJ5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpGbVlXTmlOV1lnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ3Y1dOZlpHRnZMbEJSUTBSaGJ5NWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzFNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBzSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TmpFS0lDQWdJQzh2SUdGemMyVnlkQ0IwYUhKbGMyaHZiR1FnUGowZ1ZVbHVkRFkwS0RFcExDQWlWR2h5WlhOb2IyeGtJRzExYzNRZ1ltVWdQajBnTVNJS0lDQWdJR1JwWnlBekNpQWdJQ0JoYzNObGNuUWdMeThnVkdoeVpYTm9iMnhrSUcxMWMzUWdZbVVnUGowZ01Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBhSEpsYzJodmJHUWdQRDBnYm5WdFgyMWxiV0psY25Nc0lDSlVhSEpsYzJodmJHUWdZMkZ1Ym05MElHVjRZMlZsWkNCdFpXMWlaWElnWTI5MWJuUWlDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaHlaWE5vYjJ4a0lHTmhibTV2ZENCbGVHTmxaV1FnYldWdFltVnlJR052ZFc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzJNd29nSUNBZ0x5OGdZWE56WlhKMElHNTFiVjl0WlcxaVpYSnpJRDQ5SUZWSmJuUTJOQ2d4S1N3Z0lrUkJUeUJ5WlhGMWFYSmxjeUJoZENCc1pXRnpkQ0F4SUcxbGJXSmxjaUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSRUZQSUhKbGNYVnBjbVZ6SUdGMElHeGxZWE4wSURFZ2JXVnRZbVZ5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRvMk5Rb2dJQ0FnTHk4Z2MyVnNaaTVrWVc5ZmJtRnRaUzUyWVd4MVpTQTlJR1JoYjE5dVlXMWxDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUmhiMTl1WVcxbElnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk5qWUtJQ0FnSUM4dklITmxiR1l1ZEdoeVpYTm9iMnhrTG5aaGJIVmxJRDBnZEdoeVpYTm9iMnhrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYUhKbGMyaHZiR1FpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG8yTndvZ0lDQWdMeThnYzJWc1ppNXVkVzFmYldWdFltVnljeTUyWVd4MVpTQTlJRzUxYlY5dFpXMWlaWEp6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p1ZFcxZmJXVnRZbVZ5Y3lJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pZNENpQWdJQ0F2THlCelpXeG1MbkJ5YjNCdmMyRnNYMk52ZFc1MExuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOXdiM05oYkY5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TmprS0lDQWdJQzh2SUhObGJHWXVkbTkwYVc1blgzQmxjbWx2WkM1MllXeDFaU0E5SUhadmRHbHVaMTl3WlhKcGIyUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luWnZkR2x1WjE5d1pYSnBiMlFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG8zTUFvZ0lDQWdMeThnYzJWc1ppNWxlR1ZqZFhScGIyNWZaR1ZzWVhrdWRtRnNkV1VnUFNCbGVHVmpkWFJwYjI1ZlpHVnNZWGtLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbVY0WldOMWRHbHZibDlrWld4aGVTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG8xTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hGalgyUmhieTVRVVVORVlXOHVZV1JrWDIxbGJXSmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ga1pGOXRaVzFpWlhJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzNNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzNOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdhVzVrWlhnZ1BDQnpaV3htTG01MWJWOXRaVzFpWlhKekxuWmhiSFZsTENBaVNXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdWRXMWZiV1Z0WW1WeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1ZFcxZmJXVnRZbVZ5Y3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZOellLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JpSW5Cclh5SWdLeUJ2Y0M1cGRHOWlLR2x1WkdWNEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEY3dObUkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzNOd29nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hpYjNoZmEyVjVMQ0J3ZFdKc2FXTmZhMlY1TG1KNWRHVnpLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk56SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEJ4WTE5a1lXOHVVRkZEUkdGdkxuTjFZbTFwZEY5d2NtOXdiM05oYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFZbTFwZEY5d2NtOXdiM05oYkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qYzVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG80TmdvZ0lDQWdMeThnY0hKdmNHOXpZV3hmYVdRZ1BTQnpaV3htTG5CeWIzQnZjMkZzWDJOdmRXNTBMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdmNHOXpZV3hmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmNHOXpZV3hmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzROd29nSUNBZ0x5OGdjMlZzWmk1d2NtOXdiM05oYkY5amIzVnVkQzUyWVd4MVpTQTlJSEJ5YjNCdmMyRnNYMmxrSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTl3YjNOaGJGOWpiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzRPUW9nSUNBZ0x5OGdaR1Z6WTE5b1lYTm9JRDBnYjNBdWMyaGhNalUyS0dSbGMyTnlhWEIwYVc5dUxtSjVkR1Z6S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2prd0NpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1lpSndjbTl3WHlJZ0t5QnZjQzVwZEc5aUtIQnliM0J2YzJGc1gybGtLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGN3TnpJMlpqY3dOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qa3lDaUFnSUNBdkx5QnpkR0Z5ZENBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRvNU13b2dJQ0FnTHk4Z1pXNWtJRDBnYzNSaGNuUWdLeUJ6Wld4bUxuWnZkR2x1WjE5d1pYSnBiMlF1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMmIzUnBibWRmY0dWeWFXOWtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5admRHbHVaMTl3WlhKcGIyUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk9UZ0tJQ0FnSUM4dklHUmxjMk5mYUdGemFEMWhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aGtaWE5qWDJoaGMyZ3BMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF5TUFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2prNUNpQWdJQ0F2THlCemRHRnlkRjkwYVcxbFBXRnlZelF1VlVsdWREWTBLSE4wWVhKMEtTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UQXdDaUFnSUNBdkx5QmxibVJmZEdsdFpUMWhjbU0wTGxWSmJuUTJOQ2hsYm1RcExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRvNU5TMHhNRFFLSUNBZ0lDOHZJSEJ5YjNBZ1BTQkVZVzlRY205d2IzTmhiQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnBjR2xsYm5ROWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2hoYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbGMyTmZhR0Z6YUQxaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3loa1pYTmpYMmhoYzJncExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhKMFgzUnBiV1U5WVhKak5DNVZTVzUwTmpRb2MzUmhjblFwTEFvZ0lDQWdMeThnSUNBZ0lHVnVaRjkwYVcxbFBXRnlZelF1VlVsdWREWTBLR1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdlV1Z6WDNadmRHVnpQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2WDNadmRHVnpQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR1Y0WldOMWRHVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURSaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hNRFVLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvWW05NFgydGxlU3dnY0hKdmNDNWllWFJsY3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UQTNMVEV4TUFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0VSaGIxQnliM0J2YzJGc1EzSmxZWFJsWkNnS0lDQWdJQzh2SUNBZ0lDQndjbTl3YjNOaGJGOXBaRDFoY21NMExsVkpiblEyTkNod2NtOXdiM05oYkY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWlc1a1gzUnBiV1U5WVhKak5DNVZTVzUwTmpRb1pXNWtLUW9nSUNBZ0x5OGdLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBMllXWmpOVFkySUM4dklHMWxkR2h2WkNBaVJHRnZVSEp2Y0c5ellXeERjbVZoZEdWa0tIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qYzVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3Y1dOZlpHRnZMbEJSUTBSaGJ5NXpkV0p0YVhSZmRtOTBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMVltMXBkRjkyYjNSbE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhOcFoyNWxjbDlwYm1SbGVDQThJSE5sYkdZdWJuVnRYMjFsYldKbGNuTXVkbUZzZFdVc0lDSkpiblpoYkdsa0lHbHVaR1Y0SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTUxYlY5dFpXMWlaWEp6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNTFiVjl0WlcxaVpYSnpJR1Y0YVhOMGN3b2dJQ0FnWkdsbklETUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJR2x1WkdWNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hNak1LSUNBZ0lDOHZJSEJ5YjNCZmEyVjVJRDBnWWlKd2NtOXdYeUlnS3lCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TnpBM01qWm1OekExWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TWpRS0lDQWdJQzh2SUhCeWIzQmZZbmwwWlhNc0lHVjRhWE4wY3lBOUlHOXdMa0p2ZUM1blpYUW9jSEp2Y0Y5clpYa3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKT2J5QndjbTl3YjNOaGJDSUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QndjbTl3YjNOaGJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVEk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhCeWIzQXVaWGhsWTNWMFpXUXVibUYwYVhabExDQWlSWGhsWTNWMFpXUWlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlRreUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVY0WldOMWRHVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TXpBS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQStQU0J3Y205d0xuTjBZWEowWDNScGJXVXVibUYwYVhabExDQWlWbTkwYVc1bklHaGhjMjRuZENCemRHRnlkR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdORElnT0FvZ0lDQWdZMjkyWlhJZ05nb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRlp2ZEdsdVp5Qm9ZWE51SjNRZ2MzUmhjblJsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UTXhDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUEQwZ2NISnZjQzVsYm1SZmRHbHRaUzV1WVhScGRtVXNJQ0pXYjNScGJtY2daVzVrWldRaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0ExTUNBNENpQWdJQ0JqYjNabGNpQTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVm05MGFXNW5JR1Z1WkdWa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hNek1LSUNBZ0lDOHZJSE5wWjE5clpYa2dQU0JpSW5OcFoxOGlJQ3NnYjNBdWFYUnZZaWh3Y205d2IzTmhiRjlwWkNrZ0t5QmlJbDhpSUNzZ2IzQXVhWFJ2WWloemFXZHVaWEpmYVc1a1pYZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNNelk1TmpjMVpnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROV1lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE16UUtJQ0FnSUM4dklITnBaMTlrWVhSaExDQnphV2RmWlhocGMzUnpJRDBnYjNBdVFtOTRMbWRsZENoemFXZGZhMlY1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakV6TlFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCemFXZGZaWGhwYzNSekxDQWlRV3h5WldGa2VTQjJiM1JsWkNJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiSEpsWVdSNUlIWnZkR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE16Y0tJQ0FnSUM4dklIQnJYMnRsZVNBOUlHSWljR3RmSWlBcklHOXdMbWwwYjJJb2MybG5ibVZ5WDJsdVpHVjRLUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlRGN3Tm1JMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRXpPQW9nSUNBZ0x5OGdjSFZpYTJWNUxDQndhMTlsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0hCclgydGxlU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRXpPUW9nSUNBZ0x5OGdZWE56WlhKMElIQnJYMlY0YVhOMGN5d2dJbE5wWjI1bGNpQnJaWGtnYldsemMybHVaeUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRhV2R1WlhJZ2EyVjVJRzFwYzNOcGJtY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUwTXdvZ0lDQWdMeThnS3lCd2NtOXdMbkpsWTJsd2FXVnVkQzVpZVhSbGN3b2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TkRJdE1UUXpDaUFnSUNBdkx5QnZjQzVwZEc5aUtIQnliM0J2YzJGc1gybGtLUW9nSUNBZ0x5OGdLeUJ3Y205d0xuSmxZMmx3YVdWdWRDNWllWFJsY3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFME5Bb2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtIQnliM0F1WVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURNeUlEZ0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRReUxURTBOQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHdjbTl3YjNOaGJGOXBaQ2tLSUNBZ0lDOHZJQ3NnY0hKdmNDNXlaV05wY0dsbGJuUXVZbmwwWlhNS0lDQWdJQzh2SUNzZ2IzQXVhWFJ2WWlod2NtOXdMbUZ0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUwTlFvZ0lDQWdMeThnS3lCd2NtOXdMbVJsYzJOZmFHRnphQzVpZVhSbGN3b2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TkRJdE1UUTFDaUFnSUNBdkx5QnZjQzVwZEc5aUtIQnliM0J2YzJGc1gybGtLUW9nSUNBZ0x5OGdLeUJ3Y205d0xuSmxZMmx3YVdWdWRDNWllWFJsY3dvZ0lDQWdMeThnS3lCdmNDNXBkRzlpS0hCeWIzQXVZVzF2ZFc1MExtNWhkR2wyWlNrS0lDQWdJQzh2SUNzZ2NISnZjQzVrWlhOalgyaGhjMmd1WW5sMFpYTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRRMkNpQWdJQ0F2THlBcklHOXdMbWwwYjJJb2RtOTBaVjkwZVhCbExtNWhkR2wyWlNrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFME1pMHhORFlLSUNBZ0lDOHZJRzl3TG1sMGIySW9jSEp2Y0c5ellXeGZhV1FwQ2lBZ0lDQXZMeUFySUhCeWIzQXVjbVZqYVhCcFpXNTBMbUo1ZEdWekNpQWdJQ0F2THlBcklHOXdMbWwwYjJJb2NISnZjQzVoYlc5MWJuUXVibUYwYVhabEtRb2dJQ0FnTHk4Z0t5QndjbTl3TG1SbGMyTmZhR0Z6YUM1aWVYUmxjd29nSUNBZ0x5OGdLeUJ2Y0M1cGRHOWlLSFp2ZEdWZmRIbHdaUzV1WVhScGRtVXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVFE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1Wm1Gc1kyOXVYM1psY21sbWVTaHRaWE56WVdkbExDQnphV2R1WVhSMWNtVXVZbmwwWlhNc0lIQjFZbXRsZVNrc0lDSkpiblpoYkdsa0lITnBaMjVoZEhWeVpTSUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbVlXeGpiMjVmZG1WeWFXWjVDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCemFXZHVZWFIxY21VS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTFNQW9nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2h6YVdkZmEyVjVMQ0JDZVhSbGN5aGlJakVpS1NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TlRJS0lDQWdJQzh2SUhrZ1BTQndjbTl3TG5sbGMxOTJiM1JsY3k1dVlYUnBkbVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEVTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UVXpDaUFnSUNBdkx5QnVJRDBnY0hKdmNDNXViMTkyYjNSbGN5NXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOallLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE5UUUtJQ0FnSUM4dklHbG1JSFp2ZEdWZmRIbHdaUzV1WVhScGRtVWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnpkV0p0YVhSZmRtOTBaVjlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UVTFDaUFnSUNBdkx5QjVJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRElLQ25OMVltMXBkRjkyYjNSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTJOUW9nSUNBZ0x5OGdlV1Z6WDNadmRHVnpQV0Z5WXpRdVZVbHVkRFkwS0hrcExBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUyTmdvZ0lDQWdMeThnYm05ZmRtOTBaWE05WVhKak5DNVZTVzUwTmpRb2Jpa3NDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRVNUxURTJPQW9nSUNBZ0x5OGdibVYzWDNCeWIzQWdQU0JFWVc5UWNtOXdiM05oYkNnS0lDQWdJQzh2SUNBZ0lDQnlaV05wY0dsbGJuUTljSEp2Y0M1eVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQnliM0F1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdSbGMyTmZhR0Z6YUQxd2NtOXdMbVJsYzJOZmFHRnphQzVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGNuUmZkR2x0WlQxd2NtOXdMbk4wWVhKMFgzUnBiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1pXNWtYM1JwYldVOWNISnZjQzVsYm1SZmRHbHRaU3dLSUNBZ0lDOHZJQ0FnSUNCNVpYTmZkbTkwWlhNOVlYSmpOQzVWU1c1ME5qUW9lU2tzQ2lBZ0lDQXZMeUFnSUNBZ2JtOWZkbTkwWlhNOVlYSmpOQzVWU1c1ME5qUW9iaWtzQ2lBZ0lDQXZMeUFnSUNBZ1pYaGxZM1YwWldROWNISnZjQzVsZUdWamRYUmxaQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EUmlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOamtLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvY0hKdmNGOXJaWGtzSUc1bGQxOXdjbTl3TG1KNWRHVnpLUW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOekV0TVRjMUNpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1JHRnZWbTkwWlZOMVltMXBkSFJsWkNnS0lDQWdJQzh2SUNBZ0lDQndjbTl3YjNOaGJGOXBaRDFoY21NMExsVkpiblEyTkNod2NtOXdiM05oYkY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnYzJsbmJtVnlYMmx1WkdWNFBXRnlZelF1VlVsdWREWTBLSE5wWjI1bGNsOXBibVJsZUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwWlY5MGVYQmxQWFp2ZEdWZmRIbHdaUW9nSUNBZ0x5OGdLU2tLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TlRBME5tVmtZU0F2THlCdFpYUm9iMlFnSWtSaGIxWnZkR1ZUZFdKdGFYUjBaV1FvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk4xWW0xcGRGOTJiM1JsWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVFUyQ2lBZ0lDQXZMeUJsYkdsbUlIWnZkR1ZmZEhsd1pTNXVZWFJwZG1VZ1BUMGdWVWx1ZERZMEtESXBPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MzVmliV2wwWDNadmRHVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOVGNLSUNBZ0lDOHZJRzRnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdjM1ZpYldsMFgzWnZkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTJDZ29LTHk4Z2NIRmpYMlJoYnk1UVVVTkVZVzh1WlhobFkzVjBaVjl3Y205d2IzTmhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WNFpXTjFkR1ZmY0hKdmNHOXpZV3c2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOemtLSUNBZ0lDOHZJSEJ5YjNCZmEyVjVJRDBnWWlKd2NtOXdYeUlnS3lCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEY3dOekkyWmpjd05XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFNE1Bb2dJQ0FnTHk4Z2NISnZjRjlpZVhSbGN5d2daWGhwYzNSeklEMGdiM0F1UW05NExtZGxkQ2h3Y205d1gydGxlU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UZ3hDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVRtOGdjSEp2Y0c5ellXd2lDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdjSEp2Y0c5ellXd0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakU0TkFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCd2NtOXdMbVY0WldOMWRHVmtMbTVoZEdsMlpTd2dJa1Y0WldOMWRHVmtJZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVNU1nb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSWGhsWTNWMFpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakU0TmdvZ0lDQWdMeThnWlhobFkzVjBZV0pzWlY5MGFXMWxJRDBnY0hKdmNDNWxibVJmZEdsdFpTNXVZWFJwZG1VZ0t5QnpaV3htTG1WNFpXTjFkR2x2Ymw5a1pXeGhlUzUyWVd4MVpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFV3SURnS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbVY0WldOMWRHbHZibDlrWld4aGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsZUdWamRYUnBiMjVmWkdWc1lYa2daWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErUFNCbGVHVmpkWFJoWW14bFgzUnBiV1VzSUNKVWFXMWxiRzlqYXlCaFkzUnBkbVVpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGUnBiV1ZzYjJOcklHRmpkR2wyWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UZzVDaUFnSUNBdkx5QmhjM05sY25RZ2NISnZjQzU1WlhOZmRtOTBaWE11Ym1GMGFYWmxJRDQ5SUhObGJHWXVkR2h5WlhOb2IyeGtMblpoYkhWbExDQWlVWFZ2Y25WdElHNXZkQ0J5WldGamFHVmtJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05UZ2dPQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ05UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHaHlaWE5vYjJ4a0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJvY21WemFHOXNaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZGMWIzSjFiU0J1YjNRZ2NtVmhZMmhsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1Ua3dDaUFnSUNBdkx5QmhjM05sY25RZ2NISnZjQzU1WlhOZmRtOTBaWE11Ym1GMGFYWmxJRDRnY0hKdmNDNXViMTkyYjNSbGN5NXVZWFJwZG1Vc0lDSlNaV3BsWTNSbFpDQmllU0J0WVdwdmNtbDBlU0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEWTJJRGdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZxWldOMFpXUWdZbmtnYldGcWIzSnBkSGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFNU13b2dJQ0FnTHk4Z2NtVmphWEJwWlc1MFBYQnliM0F1Y21WamFYQnBaVzUwTEFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UazBDaUFnSUNBdkx5QmhiVzkxYm5ROWNISnZjQzVoYlc5MWJuUXNDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBek1pQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94T1RVS0lDQWdJQzh2SUdSbGMyTmZhR0Z6YUQxd2NtOXdMbVJsYzJOZmFHRnphQzVqYjNCNUtDa3NDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTJDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QTNDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94T1RZS0lDQWdJQzh2SUhOMFlYSjBYM1JwYldVOWNISnZjQzV6ZEdGeWRGOTBhVzFsTEFvZ0lDQWdaR2xuSURZS0lDQWdJR1Y0ZEhKaFkzUWdORElnT0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1Ua3lMVEl3TVFvZ0lDQWdMeThnYm1WM1gzQnliM0FnUFNCRVlXOVFjbTl3YjNOaGJDZ0tJQ0FnSUM4dklDQWdJQ0J5WldOcGNHbGxiblE5Y0hKdmNDNXlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJ5YjNBdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHUmxjMk5mYUdGemFEMXdjbTl3TG1SbGMyTmZhR0Z6YUM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhjblJmZEdsdFpUMXdjbTl3TG5OMFlYSjBYM1JwYldVc0NpQWdJQ0F2THlBZ0lDQWdaVzVrWDNScGJXVTljSEp2Y0M1bGJtUmZkR2x0WlN3S0lDQWdJQzh2SUNBZ0lDQjVaWE5mZG05MFpYTTljSEp2Y0M1NVpYTmZkbTkwWlhNc0NpQWdJQ0F2THlBZ0lDQWdibTlmZG05MFpYTTljSEp2Y0M1dWIxOTJiM1JsY3l3S0lDQWdJQzh2SUNBZ0lDQmxlR1ZqZFhSbFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd05HSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3lNREFLSUNBZ0lDOHZJR1Y0WldOMWRHVmtQV0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakU1TWkweU1ERUtJQ0FnSUM4dklHNWxkMTl3Y205d0lEMGdSR0Z2VUhKdmNHOXpZV3dvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmphWEJwWlc1MFBYQnliM0F1Y21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxd2NtOXdMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JrWlhOalgyaGhjMmc5Y0hKdmNDNWtaWE5qWDJoaGMyZ3VZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhKMFgzUnBiV1U5Y0hKdmNDNXpkR0Z5ZEY5MGFXMWxMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpGOTBhVzFsUFhCeWIzQXVaVzVrWDNScGJXVXNDaUFnSUNBdkx5QWdJQ0FnZVdWelgzWnZkR1Z6UFhCeWIzQXVlV1Z6WDNadmRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUc1dlgzWnZkR1Z6UFhCeWIzQXVibTlmZG05MFpYTXNDaUFnSUNBdkx5QWdJQ0FnWlhobFkzVjBaV1E5WVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1qQXlDaUFnSUNBdkx5QnZjQzVDYjNndWNIVjBLSEJ5YjNCZmEyVjVMQ0J1WlhkZmNISnZjQzVpZVhSbGN5a0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNakEwQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvUkdGdlJYaGxZM1YwWldRb2NISnZjRzl6WVd4ZmFXUTlZWEpqTkM1VlNXNTBOalFvY0hKdmNHOXpZV3hmYVdRcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVmhZbVEwTURsbElDOHZJRzFsZEdodlpDQWlSR0Z2UlhobFkzVjBaV1FvZFdsdWREWTBLU0lLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakl3TmkweU1URUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxd2NtOXdMbkpsWTJsd2FXVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJ5YjNBdVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlZaUpoYkdkdkxYQnhZeTFyYVhRNlpHRnZPbkJ5YjNCdmMyRnNPaUlnS3lCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qSXdPUW9nSUNBZ0x5OGdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJR2RzYjJKaGJDQk5hVzVVZUc1R1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakl3T0FvZ0lDQWdMeThnWVcxdmRXNTBQWEJ5YjNBdVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVGswQ2lBZ0lDQXZMeUJoYlc5MWJuUTljSEp2Y0M1aGJXOTFiblFzQ2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG95TURnS0lDQWdJQzh2SUdGdGIzVnVkRDF3Y205d0xtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1qRXdDaUFnSUNBdkx5QnViM1JsUFdJaVlXeG5ieTF3Y1dNdGEybDBPbVJoYnpwd2NtOXdiM05oYkRvaUlDc2diM0F1YVhSdllpaHdjbTl3YjNOaGJGOXBaQ2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyTVRaak5qYzJaakprTnpBM01UWXpNbVEyWWpZNU56UXpZVFkwTmpFMlpqTmhOekEzTWpabU56QTJaamN6TmpFMll6TmhDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TWpBMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNakEyTFRJeE1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhCeWIzQXVjbVZqYVhCcFpXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljSEp2Y0M1aGJXOTFiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMWlJbUZzWjI4dGNIRmpMV3RwZERwa1lXODZjSEp2Y0c5ellXdzZJaUFySUc5d0xtbDBiMklvY0hKdmNHOXpZV3hmYVdRcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hGalgyUmhieTVRVVVORVlXOHVaMlYwWDNCeWIzQnZjMkZzWDJOdmRXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzQnliM0J2YzJGc1gyTnZkVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV3Y205d2IzTmhiRjlqYjNWdWRDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjNCdmMyRnNYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjNCdmMyRnNYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1qRXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjV05mWkdGdkxsQlJRMFJoYnk1blpYUmZkR2h5WlhOb2IyeGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUm9jbVZ6YUc5c1pEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakl4T1FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWRHaHlaWE5vYjJ4a0xuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkR2h5WlhOb2IyeGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Sb2NtVnphRzlzWkNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pJeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBRUFBRUlBaVlKRG5CeWIzQnZjMkZzWDJOdmRXNTBDWFJvY21WemFHOXNaQXR1ZFcxZmJXVnRZbVZ5Y3dWd2NtOXdYd0lBU3dRVkgzeDFEWFp2ZEdsdVoxOXdaWEpwYjJRUFpYaGxZM1YwYVc5dVgyUmxiR0Y1QTNCclh6RVpGRVF4R0VFQU1vSUdCS0hyNXlZRURWekQ1Z1JHSk1LN0JET0w3Q01FYlkrNmRBVEdVTldrTmhvQWpnWUFjZ0NnQVNnQ1Z3TWxBekVBZ0FUeCtzdGZOaG9BamdFQUFRQTJHZ0ZKSWxrbENFc0JGUkpFVndJQU5ob0NTUlVrRWtRWE5ob0RTUlVrRWtRWE5ob0VTUlVrRWtRWE5ob0ZTUlVrRWtRWFN3TkVTd05MQXc1RVN3SkVnQWhrWVc5ZmJtRnRaVThGWnlsUEJHY3FUd05uS0NKbkp3WlBBbWNuQjB4bkkwTTJHZ0ZKRlNRU1JCYzJHZ0pKSWxrbENFc0JGUkpFTVFBeUNSSkVJaXBsUkVzQ0RVUk1GaWNJVEZCTXZ5TkROaG9CU1NKWkpRaExBUlVTUkZjQ0FEWWFBa2tWZ1NBU1JEWWFBMGtWSkJKRUlpaGxSRWtqQ0NoTVowOERBVXdXSzBzQlVESUhJaWNHWlVSTEFRaUFBZ0FnVHdWUVR3SVdUd0lXVHdaUEJsQW5CRkJQQWxCTEFWQ0FFUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFVRThDVUU4Q1RMOUxBVXhRZ0FRR3I4Vm1URkN3SndWTVVMQWpRellhQVVjQ0ZTUVNSQmMyR2dKSlRnSkpGU1FTUkJjMkdnTkpUZ05KRlNNU1JEWWFCRWtpV1NVSVN3RVZFa1FpS21WRVN3TU5SRThERml0TEFWQkpUZ1crUkVtQjBBUlRnQUVBSWs4Q1ZFbE9CaUpURkVReUIwc0JWeW9JVGdaTEFZRXFXdzlFTWdkTEFWY3lDRTRHU3dHQk1sc09SSUFFYzJsblgwc0NVSUFCWDFCUEJSWk1Td0ZRU2IxRkFSUkVKd2hQQWxDK1JFc0NWd0FnU1U0SFR3Uk1VRXNEVnlBSVNVNEhVRXNEZ1NoWlN3UVZTd1ZPQWxKSlRnZFFUd1VYU1U0R1NSWlBBa3hRVHdWUEE0VkVUSUFCTWI5TEFZRTZXMDRDVElGQ1cwd2pFa0VBUEVzQkl3aEZBa3NCRmtzQkZrc0hTd2RRSndSUVN3cFFTd2xRVHdKUVRGQkxDVkJMQkZCTENreS9Td3hMREZCTEMxQ0FCQVVFYnRwTVVMQWpRMHNDSlJKQi84TkpJd2hGQVVML3V6WWFBVWtWSkJKRVNSY1dLMHNCVUVtK1JFbUIwQVJUZ0FFQUlrOENWQ0pURkVSSlZ6SUlTd0dCTWxzaUp3ZGxSQWd5Qnc1RVN3RlhPZ2hMQW9FNld5SXBaVVJMQVE1RVN3TlhRZ2hMQklGQ1cwOENERVJMQTFjQUlFc0VWeUFJU3dXQktGbExCaFZMQjA0Q1Vrc0dWeW9JU3dOUEExQW5CRkJNVUU4RlVFOEVVRThEVUlBQmdGQk1VRThEVEwrQUJPcTlRSjVQQkZDd3NUSUFUd0tCSUZ1QUdtRnNaMjh0Y0hGakxXdHBkRHBrWVc4NmNISnZjRzl6WVd3NlR3UlFzZ1d5Q0V5eUJ5T3lFTElCc3lORElpaGxSQlluQlV4UXNDTkRJaWxsUkJZbkJVeFFzQ05EIiwiY2xlYXIiOiJESUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRGFvUHJvcG9zYWxDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kX3RpbWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkRhb1ZvdGVTdWJtaXR0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduZXJfaW5kZXgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVfdHlwZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGFvRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
