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

namespace Arc56.Generated.p2arthur.weDev.WeDao_003027bc
{


    public class WeDaoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public WeDaoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProposalDataType : AVMObjectType
            {
                public string ProposalTitle { get; set; }

                public string ProposalDescription { get; set; }

                public ulong ProposalExpiryTimestamp { get; set; }

                public ulong ProposalStartTimestamp { get; set; }

                public ulong ProposalTotalVotes { get; set; }

                public ulong ProposalYesVotes { get; set; }

                public ulong ProposalPrizePool { get; set; }

                public ulong ProposalAsset { get; set; }

                public ulong VotePrice { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitle.From(ProposalTitle);
                    stringRef[ret.Count] = vProposalTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalDescription.From(ProposalDescription);
                    stringRef[ret.Count] = vProposalDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalExpiryTimestamp.From(ProposalExpiryTimestamp);
                    ret.AddRange(vProposalExpiryTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalStartTimestamp.From(ProposalStartTimestamp);
                    ret.AddRange(vProposalStartTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalTotalVotes.From(ProposalTotalVotes);
                    ret.AddRange(vProposalTotalVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalYesVotes.From(ProposalYesVotes);
                    ret.AddRange(vProposalYesVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalPrizePool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalPrizePool.From(ProposalPrizePool);
                    ret.AddRange(vProposalPrizePool.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalAsset.From(ProposalAsset);
                    ret.AddRange(vProposalAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotePrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotePrice.From(VotePrice);
                    ret.AddRange(vVotePrice.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalDataType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalDataType();
                    uint count = 0;
                    var indexProposalTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitle.Decode(bytes.Skip(indexProposalTitle + prefixOffset).ToArray());
                    var valueProposalTitle = vProposalTitle.ToValue();
                    if (valueProposalTitle is string vProposalTitleValue) { ret.ProposalTitle = vProposalTitleValue; }
                    var indexProposalDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalDescription.Decode(bytes.Skip(indexProposalDescription + prefixOffset).ToArray());
                    var valueProposalDescription = vProposalDescription.ToValue();
                    if (valueProposalDescription is string vProposalDescriptionValue) { ret.ProposalDescription = vProposalDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalExpiryTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalExpiryTimestamp = vProposalExpiryTimestamp.ToValue();
                    if (valueProposalExpiryTimestamp is ulong vProposalExpiryTimestampValue) { ret.ProposalExpiryTimestamp = vProposalExpiryTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalStartTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalStartTimestamp = vProposalStartTimestamp.ToValue();
                    if (valueProposalStartTimestamp is ulong vProposalStartTimestampValue) { ret.ProposalStartTimestamp = vProposalStartTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalTotalVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalTotalVotes = vProposalTotalVotes.ToValue();
                    if (valueProposalTotalVotes is ulong vProposalTotalVotesValue) { ret.ProposalTotalVotes = vProposalTotalVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalYesVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalYesVotes = vProposalYesVotes.ToValue();
                    if (valueProposalYesVotes is ulong vProposalYesVotesValue) { ret.ProposalYesVotes = vProposalYesVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalPrizePool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalPrizePool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalPrizePool = vProposalPrizePool.ToValue();
                    if (valueProposalPrizePool is ulong vProposalPrizePoolValue) { ret.ProposalPrizePool = vProposalPrizePoolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalAsset = vProposalAsset.ToValue();
                    if (valueProposalAsset is ulong vProposalAssetValue) { ret.ProposalAsset = vProposalAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotePrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotePrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotePrice = vVotePrice.ToValue();
                    if (valueVotePrice is ulong vVotePriceValue) { ret.VotePrice = vVotePriceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalDataType);
                }
                public bool Equals(ProposalDataType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalDataType left, ProposalDataType right)
                {
                    return EqualityComparer<ProposalDataType>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalDataType left, ProposalDataType right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="anyone_can_create"> </param>
        public async Task CreateApplication(bool anyone_can_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 74, 191, 181 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);

            var result = await base.CallApp(new List<object> { abiHandle, anyone_can_createAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(bool anyone_can_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 74, 191, 181 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);

            return await base.MakeTransactionList(new List<object> { abiHandle, anyone_can_createAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_title"> </param>
        /// <param name="proposal_description"> </param>
        /// <param name="expires_in"> </param>
        /// <param name="mbr_txn"> </param>
        public async Task CreateProposal(PaymentTransaction mbr_txn, string proposal_title, string proposal_description, ulong expires_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_txn });
            byte[] abiHandle = { 239, 15, 252, 104 };
            var proposal_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposal_titleAbi.From(proposal_title);
            var proposal_descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposal_descriptionAbi.From(proposal_description);
            var expires_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_inAbi.From(expires_in);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_titleAbi, proposal_descriptionAbi, expires_inAbi, mbr_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(PaymentTransaction mbr_txn, string proposal_title, string proposal_description, ulong expires_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_txn });
            byte[] abiHandle = { 239, 15, 252, 104 };
            var proposal_titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposal_titleAbi.From(proposal_title);
            var proposal_descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposal_descriptionAbi.From(proposal_description);
            var expires_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_inAbi.From(expires_in);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_titleAbi, proposal_descriptionAbi, expires_inAbi, mbr_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="vote"> </param>
        /// <param name="mbr_txn"> </param>
        public async Task VoteProposal(PaymentTransaction mbr_txn, ulong proposal_id, bool vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_txn });
            byte[] abiHandle = { 107, 80, 153, 7 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, voteAbi, mbr_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteProposal_Transactions(PaymentTransaction mbr_txn, ulong proposal_id, bool vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_txn });
            byte[] abiHandle = { 107, 80, 153, 7 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, voteAbi, mbr_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiV2VEYW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvcG9zYWxEYXRhVHlwZSI6W3sibmFtZSI6InByb3Bvc2FsX3RpdGxlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InByb3Bvc2FsX2Rlc2NyaXB0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InByb3Bvc2FsX2V4cGlyeV90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zYWxfc3RhcnRfdGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3RvdGFsX3ZvdGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3llc192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3NhbF9wcml6ZV9wb29sIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX2Fzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZvdGVfcHJpY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbnlvbmVfY2FuX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVQcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF90aXRsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNfaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZVByb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMzNl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDYsMTM3LDE3NV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIG1hbmFnZXIgY2FuIGNyZWF0ZSBwcm9wb3NhbHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJQcm9wb3NhbCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MF0sImVycm9yTWVzc2FnZSI6IlRoZSBtYW5hZ2VyIGNhbm5vdCB2b3RlIG9uIHByb3Bvc2FscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzM10sImVycm9yTWVzc2FnZSI6IlRoZSBwcm9wb3NhbCB0aGUgdXNlciBpcyB0cnlpbmcgdG8gdm90ZSBvbiBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOSwxNDBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExLDIxOCwyOTQsMzQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4LDE2Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURBd01EQXdNREF3TURBd01EQXdNQ0FpYldGdVlXZGxjbDloWkdSeVpYTnpJaUFpY0hKdmNHOXpZV3hmWTI5MWJuUWlJQ0poYm5sdmJtVmZZMkZ1WDJOeVpXRjBaU0lnSWw5d0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmRsUkdGdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZMkkwWVdKbVlqVWdNSGhsWmpCbVptTTJPQ0F3ZURaaU5UQTVPVEEzSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWUWNtOXdiM05oYkNoemRISnBibWNzYzNSeWFXNW5MSFZwYm5RMk5DeHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWlkbTkwWlZCeWIzQnZjMkZzS0hWcGJuUTJOQ3hpYjI5c0xIQmhlU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6SUcxaGFXNWZZM0psWVhSbFVISnZjRzl6WVd4ZmNtOTFkR1ZBTkNCdFlXbHVYM1p2ZEdWUWNtOXdiM05oYkY5eWIzVjBaVUExQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJYWlVSaGJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRtOTBaVkJ5YjNCdmMyRnNYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0NjZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmRsUkdGdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtOTBaVkJ5YjNCdmMyRnNDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlZCeWIzQnZjMkZzWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY2dmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZkbFJHRnZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDNKbGQyRnlaSE5mWkdGdkwxbGxjMDV2VW1WM1lYSmtMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZRY205d2IzTmhiQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZkbFJHRnZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem82VjJWRVlXOHVZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZVzU1YjI1bFgyTmhibDlqY21WaGRHVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qTXdMVE14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY3NJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWhoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaVG9nWW05dmJHVmhiaWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCdFlXNWhaMlZ5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRZVzVoWjJWeVgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCMGFHbHpMbTFoYm1GblpYSmZZV1JrY21WemN5NTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCd2NtOXdiM05oYkY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNISnZjRzl6WVd4ZlkyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUIwYUdsekxuQnliM0J2YzJGc1gyTnZkVzUwTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRnVlVzl1WlY5allXNWZZM0psWVhSbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2RHaHBjeTVoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaUzUyWVd4MVpTQTlJR0Z1ZVc5dVpWOWpZVzVmWTNKbFlYUmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qcFhaVVJoYnk1amNtVmhkR1ZRY205d2IzTmhiQ2h3Y205d2IzTmhiRjkwYVhSc1pUb2dZbmwwWlhNc0lIQnliM0J2YzJGc1gyUmxjMk55YVhCMGFXOXVPaUJpZVhSbGN5d2daWGh3YVhKbGMxOXBiam9nZFdsdWREWTBMQ0J0WW5KZmRIaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbU55WldGMFpWQnliM0J2YzJGc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvME1pMDBPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbklIMHBDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsVUhKdmNHOXpZV3dvQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDNScGRHeGxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYMlJsYzJOeWFYQjBhVzl1T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUdWNGNHbHlaWE5mYVc0NklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXSnlYM1I0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHRnVlVzl1WlY5allXNWZZM0psWVhSbElEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ1ZVc5dVpWOWpZVzVmWTNKbFlYUmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxtRnVlVzl1WlY5allXNWZZM0psWVhSbExuWmhiSFZsSUQwOVBTQm1ZV3h6WlNrZ2V3b2dJQ0FnWW01NklHTnlaV0YwWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdiV0Z1WVdkbGNsOWhaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTFoYm1GblpYSmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXRZVzVoWjJWeVgyRmtaSEpsYzNNdWRtRnNkV1VnUFQwOUlGUjRiaTV6Wlc1a1pYSXNJQ2RQYm14NUlIUm9aU0J0WVc1aFoyVnlJR05oYmlCamNtVmhkR1VnY0hKdmNHOXpZV3h6SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwYUdVZ2JXRnVZV2RsY2lCallXNGdZM0psWVhSbElIQnliM0J2YzJGc2N3b0tZM0psWVhSbFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWTI5dWMzUWdZM1Z5Y21WdWRGUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMElEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjRG9nZFdsdWREWTBJRDBnWTNWeWNtVnVkRlJwYldWemRHRnRjQ0FySUdWNGNHbHlaWE5mYVc0S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QndjbTl3YjNOaGJGOTBhWFJzWlRvZ2JtVjNJR0Z5WXpRdVUzUnlLSEJ5YjNCdmMyRnNYM1JwZEd4bEtTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgzSmxkMkZ5WkhOZlpHRnZMMWxsYzA1dlVtVjNZWEprTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJSbGMyTnlhWEIwYVc5dU9pQnVaWGNnWVhKak5DNVRkSElvY0hKdmNHOXpZV3hmWkdWelkzSnBjSFJwYjI0cExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnY0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlsZUhCcGNubGZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2NISnZjRzl6WVd4ZmMzUmhjblJmZEdsdFpYTjBZVzF3T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDNOMFlYSjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk5qRXROekVLSUNBZ0lDOHZJR052Ym5OMElIQnliM0J2YzJGc09pQlFjbTl3YjNOaGJFUmhkR0ZVZVhCbElEMGdibVYzSUZCeWIzQnZjMkZzUkdGMFlWUjVjR1VvZXdvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGFYUnNaVG9nYm1WM0lHRnlZelF1VTNSeUtIQnliM0J2YzJGc1gzUnBkR3hsS1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZlpHVnpZM0pwY0hScGIyNDZJRzVsZHlCaGNtTTBMbE4wY2lod2NtOXdiM05oYkY5a1pYTmpjbWx3ZEdsdmJpa3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYMlY0Y0dseWVWOTBhVzFsYzNSaGJYQTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9jSEp2Y0c5ellXeGZaWGh3YVhKNVgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM04wWVhKMFgzUnBiV1Z6ZEdGdGNEb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaHdjbTl3YjNOaGJGOXpkR0Z5ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOTBiM1JoYkY5MmIzUmxjem9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZmVXVnpYM1p2ZEdWek9pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjloYzNObGREb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmY0hKcGVtVmZjRzl2YkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdkbTkwWlY5d2NtbGpaVG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUgwcENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFl3SUM4dklEWXdDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBell3b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QndjbTl3YjNOaGJGOTBiM1JoYkY5MmIzUmxjem9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPall4TFRjeENpQWdJQ0F2THlCamIyNXpkQ0J3Y205d2IzTmhiRG9nVUhKdmNHOXpZV3hFWVhSaFZIbHdaU0E5SUc1bGR5QlFjbTl3YjNOaGJFUmhkR0ZVZVhCbEtIc0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZkR2wwYkdVNklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjkwYVhSc1pTa3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYMlJsYzJOeWFYQjBhVzl1T2lCdVpYY2dZWEpqTkM1VGRISW9jSEp2Y0c5ellXeGZaR1Z6WTNKcGNIUnBiMjRwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5bGVIQnBjbmxmZEdsdFpYTjBZVzF3T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDJWNGNHbHllVjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYzNSaGNuUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZEc5MFlXeGZkbTkwWlhNNklHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM2xsYzE5MmIzUmxjem9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZllYTnpaWFE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzQnlhWHBsWDNCdmIydzZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhadmRHVmZjSEpwWTJVNklHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJ3Y205d2IzTmhiRjk1WlhOZmRtOTBaWE02SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem8yTVMwM01Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKdmNHOXpZV3c2SUZCeWIzQnZjMkZzUkdGMFlWUjVjR1VnUFNCdVpYY2dVSEp2Y0c5ellXeEVZWFJoVkhsd1pTaDdDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM1JwZEd4bE9pQnVaWGNnWVhKak5DNVRkSElvY0hKdmNHOXpZV3hmZEdsMGJHVXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2YmpvZ2JtVjNJR0Z5WXpRdVUzUnlLSEJ5YjNCdmMyRnNYMlJsYzJOeWFYQjBhVzl1S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZlpYaHdhWEo1WDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5bGVIQnBjbmxmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZmMzUmhjblJmZEdsdFpYTjBZVzF3T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDNOMFlYSjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDNSdmRHRnNYM1p2ZEdWek9pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjk1WlhOZmRtOTBaWE02SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gyRnpjMlYwT2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOXdjbWw2WlY5d2IyOXNPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLREFwTEFvZ0lDQWdMeThnSUNCMmIzUmxYM0J5YVdObE9pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtEQXBMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnY0hKdmNHOXpZV3hmY0hKcGVtVmZjRzl2YkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pZeExUY3hDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOXdiM05oYkRvZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNBOUlHNWxkeUJRY205d2IzTmhiRVJoZEdGVWVYQmxLSHNLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZEdsMGJHVTZJRzVsZHlCaGNtTTBMbE4wY2lod2NtOXdiM05oYkY5MGFYUnNaU2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDJSbGMyTnlhWEIwYVc5dU9pQnVaWGNnWVhKak5DNVRkSElvY0hKdmNHOXpZV3hmWkdWelkzSnBjSFJwYjI0cExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWxlSEJwY25sZmRHbHRaWE4wWVcxd09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOXpkR0Z5ZEY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmMzUmhjblJmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZmRHOTBZV3hmZG05MFpYTTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDNsbGMxOTJiM1JsY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZZWE56WlhRNklHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM0J5YVhwbFgzQnZiMnc2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lIWnZkR1ZmY0hKcFkyVTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2NtOXdiM05oYkY5aGMzTmxkRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPall4TFRjeENpQWdJQ0F2THlCamIyNXpkQ0J3Y205d2IzTmhiRG9nVUhKdmNHOXpZV3hFWVhSaFZIbHdaU0E5SUc1bGR5QlFjbTl3YjNOaGJFUmhkR0ZVZVhCbEtIc0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZkR2wwYkdVNklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjkwYVhSc1pTa3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYMlJsYzJOeWFYQjBhVzl1T2lCdVpYY2dZWEpqTkM1VGRISW9jSEp2Y0c5ellXeGZaR1Z6WTNKcGNIUnBiMjRwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5bGVIQnBjbmxmZEdsdFpYTjBZVzF3T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDJWNGNHbHllVjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYzNSaGNuUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZEc5MFlXeGZkbTkwWlhNNklHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM2xsYzE5MmIzUmxjem9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZllYTnpaWFE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzQnlhWHBsWDNCdmIydzZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhadmRHVmZjSEpwWTJVNklHNWxkeUJoY21NMExsVnBiblJPTmpRb01Da3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUIyYjNSbFgzQnlhV05sT2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgzSmxkMkZ5WkhOZlpHRnZMMWxsYzA1dlVtVjNZWEprTG1Gc1oyOHVkSE02TmpFdE56RUtJQ0FnSUM4dklHTnZibk4wSUhCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkVSaGRHRlVlWEJsSUQwZ2JtVjNJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVW9ld29nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYVhSc1pUb2dibVYzSUdGeVl6UXVVM1J5S0hCeWIzQnZjMkZzWDNScGRHeGxLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmWkdWelkzSnBjSFJwYjI0NklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2Ymlrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZlpYaHdhWEo1WDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzTjBZWEowWDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGIzUmhiRjkyYjNSbGN6b2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZVdWelgzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWhjM05sZERvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZjSEpwZW1WZmNHOXZiRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2RtOTBaVjl3Y21salpUb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgzSmxkMkZ5WkhOZlpHRnZMMWxsYzA1dlVtVjNZWEprTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0hKdmNHOXpZV3hmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1VISnZjRzl6WVd4T2IyNWpaU0E5SUZWcGJuUTJOQ2gwYUdsekxuQnliM0J2YzJGc1gyTnZkVzUwTG5aaGJIVmxJQ3NnTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11Y0hKdmNHOXpZV3dvYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h1WlhkUWNtOXdiM05oYkU1dmJtTmxLU2t1WlhocGMzUnpMQ0FuVUhKdmNHOXpZV3dnWVd4eVpXRmtlU0JsZUdsemRITW5LUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QndjbTl3YjNOaGJDQTlJRUp2ZUUxaGNEeFFjbTl3YjNOaGJFbGtWSGx3WlN3Z1VISnZjRzl6WVd4RVlYUmhWSGx3WlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RmY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lsOXdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNISnZjRzl6WVd3b2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNodVpYZFFjbTl3YjNOaGJFNXZibU5sS1NrdVpYaHBjM1J6TENBblVISnZjRzl6WVd3Z1lXeHlaV0ZrZVNCbGVHbHpkSE1uS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205d2IzTmhiQ0JoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2NISnZjRzl6WVd4ZlkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQnliM0J2YzJGc1gyTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnZEdocGN5NXdjbTl3YjNOaGJGOWpiM1Z1ZEM1MllXeDFaU0E5SUc1bGQxQnliM0J2YzJGc1RtOXVZMlVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklIUm9hWE11Y0hKdmNHOXpZV3dvYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h1WlhkUWNtOXdiM05oYkU1dmJtTmxLU2t1ZG1Gc2RXVWdQU0J3Y205d2IzTmhiQzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPanBYWlVSaGJ5NTJiM1JsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hmYVdRNklIVnBiblEyTkN3Z2RtOTBaVG9nZFdsdWREWTBMQ0J0WW5KZmRIaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblp2ZEdWUWNtOXdiM05oYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgzSmxkMkZ5WkhOZlpHRnZMMWxsYzA1dlVtVjNZWEprTG1Gc1oyOHVkSE02T0RZdE9EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUhadmRHVlFjbTl3YjNOaGJDaHdjbTl3YjNOaGJGOXBaRG9nZFdsdWREWTBMQ0IyYjNSbE9pQmliMjlzWldGdUxDQnRZbkpmZEhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdkR2hwY3k1d2NtOXdiM05oYkNodVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDJsa0tTa3VaWGhwYzNSekxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCd2NtOXdiM05oYkNBOUlFSnZlRTFoY0R4UWNtOXdiM05oYkVsa1ZIbHdaU3dnVUhKdmNHOXpZV3hFWVhSaFZIbHdaVDRvZXlCclpYbFFjbVZtYVhnNklDZGZjQ2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSWw5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QjBhR2x6TG5CeWIzQnZjMkZzS0c1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYVdRcEtTNWxlR2x6ZEhNc0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmY21WM1lYSmtjMTlrWVc4dldXVnpUbTlTWlhkaGNtUXVZV3huYnk1MGN6bzRPUzA1TWdvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0IwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmFXUXBLUzVsZUdsemRITXNDaUFnSUNBdkx5QWdJQ2RVYUdVZ2NISnZjRzl6WVd3Z2RHaGxJSFZ6WlhJZ2FYTWdkSEo1YVc1bklIUnZJSFp2ZEdVZ2IyNGdaRzlsY3lCdWIzUWdaWGhwYzNRbkxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBJQzh2SUZSb1pTQndjbTl3YjNOaGJDQjBhR1VnZFhObGNpQnBjeUIwY25scGJtY2dkRzhnZG05MFpTQnZiaUJrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZjbVYzWVhKa2MxOWtZVzh2V1dWelRtOVNaWGRoY21RdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTNWeWNtVnVkRkJ5YjNCdmMyRnNPaUJRY205d2IzTmhiRVJoZEdGVWVYQmxJRDBnZEdocGN5NXdjbTl3YjNOaGJDaHVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU2t1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOXlaWGRoY21SelgyUmhieTlaWlhOT2IxSmxkMkZ5WkM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1kyOXVjM1FnZFhCa1lYUmxaRlp2ZEdWeklEMGdWV2x1ZERZMEtHTjFjbkpsYm5SUWNtOXdiM05oYkM1d2NtOXdiM05oYkY5MGIzUmhiRjkyYjNSbGN5NXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJd0lDOHZJREl3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQWhQVDBnZEdocGN5NXRZVzVoWjJWeVgyRmtaSEpsYzNNdWRtRnNkV1VzSUNkVWFHVWdiV0Z1WVdkbGNpQmpZVzV1YjNRZ2RtOTBaU0J2YmlCd2NtOXdiM05oYkhNbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZmNtVjNZWEprYzE5a1lXOHZXV1Z6VG05U1pYZGhjbVF1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnYldGdVlXZGxjbDloWkdSeVpYTnpJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xaGJtRm5aWEpmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTl5WlhkaGNtUnpYMlJoYnk5WlpYTk9iMUpsZDJGeVpDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdJVDA5SUhSb2FYTXViV0Z1WVdkbGNsOWhaR1J5WlhOekxuWmhiSFZsTENBblZHaGxJRzFoYm1GblpYSWdZMkZ1Ym05MElIWnZkR1VnYjI0Z2NISnZjRzl6WVd4ekp5a0tJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVkdobElHMWhibUZuWlhJZ1kyRnVibTkwSUhadmRHVWdiMjRnY0hKdmNHOXpZV3h6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5eVpYZGhjbVJ6WDJSaGJ5OVpaWE5PYjFKbGQyRnlaQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnZFhCa1lYUmxaRkJ5YjNCdmMyRnNMbkJ5YjNCdmMyRnNYM1J2ZEdGc1gzWnZkR1Z6SUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoMWNHUmhkR1ZrVm05MFpYTXBDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01qQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYM0psZDJGeVpITmZaR0Z2TDFsbGMwNXZVbVYzWVhKa0xtRnNaMjh1ZEhNNk1UQTNDaUFnSUNBdkx5QjFjR1JoZEdWa1VISnZjRzl6WVd3dWNISnZjRzl6WVd4ZmVXVnpYM1p2ZEdWeklEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaGpkWEp5Wlc1MFVISnZjRzl6WVd3dWNISnZjRzl6WVd4ZmVXVnpYM1p2ZEdWekxtNWhkR2wyWlNBcklDaDJiM1JsSUQ4Z01TQTZJREFwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXlPQ0F2THlBeU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNamdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDNKbGQyRnlaSE5mWkdGdkwxbGxjMDV2VW1WM1lYSmtMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUIwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmFXUXBLUzUyWVd4MVpTQTlJSFZ3WkdGMFpXUlFjbTl3YjNOaGJDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1CUWdBQUFBQUFBQUFBQTl0WVc1aFoyVnlYMkZrWkhKbGMzTU9jSEp2Y0c5ellXeGZZMjkxYm5RUllXNTViMjVsWDJOaGJsOWpjbVZoZEdVQ1gzQXhHMEVBSElJREJNdEt2N1VFN3cvOGFBUnJVSmtITmhvQWpnTUFSd0FoQUFJalF6RVpGRVF4R0VRMkdnRVhOaG9DSTFNeEZpSUpTVGdRSWhKRWlBQzdJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBTmhvREZ6RVdJZ2xKT0JBaUVrU0lBQ01pUXpFWkZFUXhHQlJFTmhvQkkxT0lBQUlpUTRvQkFDa3hBR2NxSTJjcmkvOW5pWW9FQUNNclpVUkFBQWdqS1dWRU1RQVNSRElIU1l2K0NJdjhGUlpYQmdLTC9GQ0wvUlVXVndZQ2kvMVFUd0lXVHdNV1N3TVZnVHdJRmxjR0FvQUNBRHhNVUU4Q1VFeFFLRkFvVUNoUUtGQW9VRThDVUV4UUl5cGxSQ0lJU1JZbkJFeFFTYjFGQVJSRUtrOENaMG04U0V5L2lZb0RBSXY5RmljRVRGQkp2VVVCUkVtK1JFbUJGRnNpQ0RFQUl5bGxSQk5FRmtzQlRGd1VUSUVjVzR2K0NCWmNIRXNCdkVpL2lRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo1LCJwYXRjaCI6MywiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
