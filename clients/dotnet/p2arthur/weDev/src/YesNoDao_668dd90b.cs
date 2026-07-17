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

namespace Arc56.Generated.p2arthur.weDev.YesNoDao_668dd90b
{


    public class YesNoDaoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public YesNoDaoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProposalDataType : AVMObjectType
            {
                public ulong ProposalExpiryTimestamp { get; set; }

                public ulong ProposalStartTimestamp { get; set; }

                public ulong ProposalTotalVotes { get; set; }

                public ulong ProposalYesVotes { get; set; }

                public Algorand.Address ProposalCreator { get; set; }

                public string ProposalTitleAndDescription { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProposalCreator.From(ProposalCreator);
                    ret.AddRange(vProposalCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitleAndDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitleAndDescription.From(ProposalTitleAndDescription);
                    stringRef[ret.Count] = vProposalTitleAndDescription.Encode();
                    ret.AddRange(new byte[2]);
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProposalCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalCreator = vProposalCreator.ToValue();
                    if (valueProposalCreator is Algorand.Address vProposalCreatorValue) { ret.ProposalCreator = vProposalCreatorValue; }
                    var indexProposalTitleAndDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitleAndDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitleAndDescription.Decode(bytes.Skip(indexProposalTitleAndDescription + prefixOffset).ToArray());
                    var valueProposalTitleAndDescription = vProposalTitleAndDescription.ToValue();
                    if (valueProposalTitleAndDescription is string vProposalTitleAndDescriptionValue) { ret.ProposalTitleAndDescription = vProposalTitleAndDescriptionValue; }
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

            public class VoteDataType : AVMObjectType
            {
                public ulong VoteTimestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVoteTimestamp.From(VoteTimestamp);
                    ret.AddRange(vVoteTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VoteDataType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VoteDataType();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVoteTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVoteTimestamp = vVoteTimestamp.ToValue();
                    if (valueVoteTimestamp is ulong vVoteTimestampValue) { ret.VoteTimestamp = vVoteTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VoteDataType);
                }
                public bool Equals(VoteDataType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VoteDataType left, VoteDataType right)
                {
                    return EqualityComparer<VoteDataType>.Default.Equals(left, right);
                }
                public static bool operator !=(VoteDataType left, VoteDataType right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="anyone_can_create"> </param>
        /// <param name="minimum_holding"> </param>
        /// <param name="asset_id"> </param>
        public async Task CreateApplication(bool anyone_can_create, ulong minimum_holding, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 94, 83, 178 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);
            var minimum_holdingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minimum_holdingAbi.From(minimum_holding);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, anyone_can_createAbi, minimum_holdingAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(bool anyone_can_create, ulong minimum_holding, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 94, 83, 178 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);
            var minimum_holdingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minimum_holdingAbi.From(minimum_holding);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, anyone_can_createAbi, minimum_holdingAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="anyone_can_create"> </param>
        /// <param name="minimum_holding"> </param>
        /// <param name="assetId"> </param>
        public async Task ConfigureContract(bool anyone_can_create, ulong minimum_holding, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 184, 157, 222 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);
            var minimum_holdingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minimum_holdingAbi.From(minimum_holding);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.CallApp(new List<object> { abiHandle, anyone_can_createAbi, minimum_holdingAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureContract_Transactions(bool anyone_can_create, ulong minimum_holding, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 184, 157, 222 };
            var anyone_can_createAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); anyone_can_createAbi.From(anyone_can_create);
            var minimum_holdingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minimum_holdingAbi.From(minimum_holding);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, anyone_can_createAbi, minimum_holdingAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="voter"> </param>
        public async Task<bool> HasVoted(Address voter, ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { voter });
            byte voterRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 151, 213, 206, 205 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            var result = await base.SimApp(new List<object> { abiHandle, proposal_idAbi, voterRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasVoted_Transactions(Address voter, ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { voter });
            byte voterRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 151, 213, 206, 205 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, voterRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task<Structs.ProposalDataType> GetProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 18, 253, 61 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.SimApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalDataType.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 18, 253, 61 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWWVzTm9EYW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvcG9zYWxEYXRhVHlwZSI6W3sibmFtZSI6InByb3Bvc2FsX2V4cGlyeV90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zYWxfc3RhcnRfdGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3RvdGFsX3ZvdGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3llc192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3NhbF9jcmVhdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwcm9wb3NhbF90aXRsZV9hbmRfZGVzY3JpcHRpb24iLCJ0eXBlIjoic3RyaW5nIn1dLCJWb3RlRGF0YVR5cGUiOlt7Im5hbWUiOiJ2b3RlX3RpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFueW9uZV9jYW5fY3JlYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5pbXVtX2hvbGRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbnlvbmVfY2FuX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluaW11bV9ob2xkaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZVByb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX3RpdGxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9kZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc19pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlUHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1ZvdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6IlByb3Bvc2FsRGF0YVR5cGUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTc4LDY5Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMsMTg0LDIxOCwyNDksMjg3LDMxMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIG1hbmFnZXIgY2FuIGNvbmZpZ3VyZSB0aGUgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBtYW5hZ2VyIGNhbiBjcmVhdGUgcHJvcG9zYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY3LDYxMV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byB0aGUgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTldLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgdGhlIGJveCBNQlIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDNdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgdGhlIHZvdGUgYm94IE1CUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMl0sImVycm9yTWVzc2FnZSI6IlByb3Bvc2FsIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk2XSwiZXJyb3JNZXNzYWdlIjoiVGhlIG1hbmFnZXIgY2Fubm90IHZvdGUgb24gcHJvcG9zYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHByb3Bvc2FsIGhhcyBleHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHByb3Bvc2FsIHRoZSB1c2VyIGlzIHRyeWluZyB0byB2b3RlIG9uIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI3XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHVzZXIgZG9lcyBub3QgaGF2ZSBlbm91Z2ggYXNzZXQgdG8gdm90ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NF0sImVycm9yTWVzc2FnZSI6IlRoZSB1c2VyIGhhcyBhbHJlYWR5IHZvdGVkIG9uIHRoaXMgcHJvcG9zYWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTZdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMTg3LDIyMSwyNTIsMjkwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNCw0MzksNDQ2LDUxOCw1OTQsNjE4LDYyNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MCwyNzhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERTJORGt3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p0WVc1aFoyVnlYMkZrWkhKbGMzTWlJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSWdJbUZ1ZVc5dVpWOWpZVzVmWTNKbFlYUmxJaUFpYldsdWFXMTFiVjlvYjJ4a2FXNW5JaUFpWVhOelpYUmZhV1FpSUNKZmNDSWdNSGd4TlRGbU4yTTNOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREFnSWw5Mklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWXhOV1UxTTJJeUlEQjRNakZpT0Rsa1pHVWdNSGhsWmpCbVptTTJPQ0F3ZURaaU5UQTVPVEEzSURCNE9UZGtOV05sWTJRZ01IaG1PREV5Wm1RelpDQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiMjVtYVdkMWNtVkRiMjUwY21GamRDaGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsVUhKdmNHOXpZV3dvYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWnZkR1ZRY205d2IzTmhiQ2gxYVc1ME5qUXNZbTl2YkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWFHRnpWbTkwWldRb2RXbHVkRFkwTEdGalkyOTFiblFwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVUhKdmNHOXpZV3dvZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXh6ZEhKcGJtY3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeklHMWhhVzVmWTI5dVptbG5kWEpsUTI5dWRISmhZM1JmY205MWRHVkFOQ0J0WVdsdVgyTnlaV0YwWlZCeWIzQnZjMkZzWDNKdmRYUmxRRFVnYldGcGJsOTJiM1JsVUhKdmNHOXpZV3hmY205MWRHVkFOaUJ0WVdsdVgyaGhjMVp2ZEdWa1gzSnZkWFJsUURjZ2JXRnBibDluWlhSUWNtOXdiM05oYkY5eWIzVjBaVUE0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1dXVnpUbTlFWVc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGQnliM0J2YzJGc1gzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nV1dWelRtOUVZVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd05Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJRY205d2IzTmhiQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW9ZWE5XYjNSbFpGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5d2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0Njc0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR2hoYzFadmRHVmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNadmRHVlFjbTl3YjNOaGJGOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1dXVnpUbTlFWVc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbTkwWlZCeWIzQnZjMkZzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWQnliM0J2YzJGc1gzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0NjZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVlFjbTl3YjNOaGJBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amIyNW1hV2QxY21WRGIyNTBjbUZqZEY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJaWlhOT2IwUmhieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkT2IwOXdKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQmpiMjVtYVdkMWNtVkRiMjUwY21GamRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGbGxjMDV2UkdGdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNldXVnpUbTlFWVc4dVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1lXNTViMjVsWDJOaGJsOWpjbVZoZEdVNklIVnBiblEyTkN3Z2JXbHVhVzExYlY5b2IyeGthVzVuT2lCMWFXNTBOalFzSUdGemMyVjBYMmxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1TMDBNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZVzU1YjI1bFgyTmhibDlqY21WaGRHVTZJR0p2YjJ4bFlXNHNJRzFwYm1sdGRXMWZhRzlzWkdsdVp6b2dkV2x1ZERZMExDQmhjM05sZEY5cFpEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUcxaGJtRm5aWEpmWVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhibUZuWlhKZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklIUm9hWE11YldGdVlXZGxjbDloWkdSeVpYTnpMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNYMk52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJSFJvYVhNdWNISnZjRzl6WVd4ZlkyOTFiblF1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdGdWVXOXVaVjlqWVc1ZlkzSmxZWFJsSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZVzU1YjI1bFgyTmhibDlqY21WaGRHVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIwYUdsekxtRnVlVzl1WlY5allXNWZZM0psWVhSbExuWmhiSFZsSUQwZ1lXNTViMjVsWDJOaGJsOWpjbVZoZEdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHMXBibWx0ZFcxZmFHOXNaR2x1WnlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliV2x1YVcxMWJWOW9iMnhrYVc1bklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdkR2hwY3k1dGFXNXBiWFZ0WDJodmJHUnBibWN1ZG1Gc2RXVWdQU0J0YVc1cGJYVnRYMmh2YkdScGJtY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR0Z6YzJWMFgybGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGMzTmxkRjlwWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIUm9hWE11WVhOelpYUmZhV1F1ZG1Gc2RXVWdQU0JoYzNObGRGOXBaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT0MwM01Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NkamNtVmhkR1ZRY205cVpXTjBUV2xqY205RVlYQndLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ2NwTEFvZ0lDQWdMeThnSUNBZ0lDQWdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaEhiRzlpWVd3dVkyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlpDa3NDaUFnSUNBdkx5QWdJQ0FnSUNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJRjBzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Vsa09pQTNNemd4TlRNNU9ETXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdGalkyOTFiblJ6T2lCYlZIaHVMbk5sYm1SbGNsMHNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUpaQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1EyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdZV05qYjNWdWRITTZJRnRVZUc0dWMyVnVaR1Z5WFN3S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWVhCd1NXUTZJRGN6T0RFMU16azRNeXdLSUNBZ0lIQjFjMmhwYm5RZ056TTRNVFV6T1RneklDOHZJRGN6T0RFMU16azRNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduWTNKbFlYUmxVSEp2YW1WamRFMXBZM0p2UkdGd2NDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUW5LU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd5TkRaak5USTFJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxVSEp2YW1WamRFMXBZM0p2UkdGd2NDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NU2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9DMDJPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnSUNCaGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZGpjbVZoZEdWUWNtOXFaV04wVFdsamNtOUVZWEJ3S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNjcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUpaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtERXBMQW9nSUNBZ0x5OGdJQ0FnSUYwc0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFbGtPaUEzTXpneE5UTTVPRE1zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHRmpZMjkxYm5Sek9pQmJWSGh1TG5ObGJtUmxjbDBzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNExUY3dDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0FnSUdGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0oyTnlaV0YwWlZCeWIycGxZM1JOYVdOeWIwUmhjSEFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSnlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbGtLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHNWxkeUJoY21NMExsVnBiblJPTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWFN3S0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJRGN6T0RFMU16azRNeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1lXTmpiM1Z1ZEhNNklGdFVlRzR1YzJWdVpHVnlYU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNldXVnpUbTlFWVc4dVkyOXVabWxuZFhKbFEyOXVkSEpoWTNRb1lXNTViMjVsWDJOaGJsOWpjbVZoZEdVNklIVnBiblEyTkN3Z2JXbHVhVzExYlY5b2IyeGthVzVuT2lCMWFXNTBOalFzSUdGemMyVjBTV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWTI5dVptbG5kWEpsUTI5dWRISmhZM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjekxUYzBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0NjZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCamIyNW1hV2QxY21WRGIyNTBjbUZqZENoaGJubHZibVZmWTJGdVgyTnlaV0YwWlRvZ1ltOXZiR1ZoYml3Z2JXbHVhVzExYlY5b2IyeGthVzVuT2lCMWFXNTBOalFzSUdGemMyVjBTV1E2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QnRZVzVoWjJWeVgyRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliV0Z1WVdkbGNsOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbTFoYm1GblpYSmZZV1JrY21WemN5NTJZV3gxWlNBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjA5dWJIa2dkR2hsSUcxaGJtRm5aWElnWTJGdUlHTnZibVpwWjNWeVpTQjBhR1VnWTI5dWRISmhZM1FuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCdFlXNWhaMlZ5SUdOaGJpQmpiMjVtYVdkMWNtVWdkR2hsSUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCaGJubHZibVZmWTJGdVgyTnlaV0YwWlNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ1ZVc5dVpWOWpZVzVmWTNKbFlYUmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnZEdocGN5NWhibmx2Ym1WZlkyRnVYMk55WldGMFpTNTJZV3gxWlNBOUlHRnVlVzl1WlY5allXNWZZM0psWVhSbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QnRhVzVwYlhWdFgyaHZiR1JwYm1jZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTFwYm1sdGRXMWZhRzlzWkdsdVp5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSFJvYVhNdWJXbHVhVzExYlY5b2IyeGthVzVuTG5aaGJIVmxJRDBnYldsdWFXMTFiVjlvYjJ4a2FXNW5DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJoYzNObGRGOXBaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlYTnpaWFJmYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QjBhR2x6TG1GemMyVjBYMmxrTG5aaGJIVmxJRDBnWVhOelpYUkpaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem82V1dWelRtOUVZVzh1WTNKbFlYUmxVSEp2Y0c5ellXd29jSEp2Y0c5ellXeGZkR2wwYkdVNklHSjVkR1Z6TENCd2NtOXdiM05oYkY5a1pYTmpjbWx3ZEdsdmJqb2dZbmwwWlhNc0lHVjRjR2x5WlhOZmFXNDZJSFZwYm5RMk5Dd2diV0p5WDNSNGJqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGpjbVZoZEdWUWNtOXdiM05oYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY3RPVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlZCeWIzQnZjMkZzS0FvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGFYUnNaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2YmpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCbGVIQnBjbVZ6WDJsdU9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHMWljbDkwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z05DQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGJubHZibVZmWTJGdVgyTnlaV0YwWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCcFppQW9kR2hwY3k1aGJubHZibVZmWTJGdVgyTnlaV0YwWlM1MllXeDFaU0E5UFQwZ1ptRnNjMlVwSUhzS0lDQWdJR0p1ZWlCamNtVmhkR1ZRY205d2IzTmhiRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJRzFoYm1GblpYSmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGdVlXZGxjbDloWkdSeVpYTnpMblpoYkhWbElEMDlQU0JVZUc0dWMyVnVaR1Z5TENBblQyNXNlU0IwYUdVZ2JXRnVZV2RsY2lCallXNGdZM0psWVhSbElIQnliM0J2YzJGc2N5Y3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJRzFoYm1GblpYSWdZMkZ1SUdOeVpXRjBaU0J3Y205d2IzTmhiSE1LQ21OeVpXRjBaVkJ5YjNCdmMyRnNYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5SVWFXMWxjM1JoYlhBNklIVnBiblEyTkNBOUlHOXdMa2RzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QmhjM05sY25Rb2JXSnlYM1I0Ymk1aGJXOTFiblFnUGowZ01UWTBPVEFzSUNkUVlYbHRaVzUwSUcxMWMzUWdZMjkyWlhJZ2RHaGxJR0p2ZUNCTlFsSW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5qUTVNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZMjkyWlhJZ2RHaGxJR0p2ZUNCTlFsSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5WDNSNGJpNXlaV05sYVhabGNpQTlQVDBnYjNBdVIyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z2RHaGxJR052Ym5SeVlXTjBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QjBhR1VnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCamIyNXpkQ0J3Y205d2IzTmhiRjlsZUhCcGNubGZkR2x0WlhOMFlXMXdPaUIxYVc1ME5qUWdQU0JqZFhKeVpXNTBWR2x0WlhOMFlXMXdJQ3NnWlhod2FYSmxjMTlwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJ3Y205d2IzTmhiRjlsZUhCcGNubGZkR2x0WlhOMFlXMXdPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLSEJ5YjNCdmMyRnNYMlY0Y0dseWVWOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDNOMFlYSjBYM1JwYldWemRHRnRjRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjl6ZEdGeWRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJOeVpXRjBiM0k2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z2NISnZjRzl6WVd4ZmRHbDBiR1ZmWVc1a1gyUmxjMk55YVhCMGFXOXVPaUJ1WlhjZ1lYSmpOQzVUZEhJb2NISnZjRzl6WVd4ZmRHbDBiR1VnS3lBbk9pY2dLeUJ3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2Ymlrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSEIxYzJoaWVYUmxjeUFpT2lJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNUzB4TVRnS0lDQWdJQzh2SUdOdmJuTjBJSEJ5YjNCdmMyRnNPaUJRY205d2IzTmhiRVJoZEdGVWVYQmxJRDBnYm1WM0lGQnliM0J2YzJGc1JHRjBZVlI1Y0dVb2V3b2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWxlSEJwY25sZmRHbHRaWE4wWVcxd09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOXpkR0Z5ZEY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmMzUmhjblJmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ2NISnZjRzl6WVd4ZmRHOTBZV3hmZG05MFpYTTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDNsbGMxOTJiM1JsY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZZM0psWVhSdmNqb2dibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZEdsMGJHVmZZVzVrWDJSbGMyTnlhWEIwYVc5dU9pQnVaWGNnWVhKak5DNVRkSElvY0hKdmNHOXpZV3hmZEdsMGJHVWdLeUFuT2ljZ0t5QndjbTl3YjNOaGJGOWtaWE5qY21sd2RHbHZiaWtzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNYM1J2ZEdGc1gzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXhMVEV4T0FvZ0lDQWdMeThnWTI5dWMzUWdjSEp2Y0c5ellXdzZJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVWdQU0J1WlhjZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNoN0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZlpYaHdhWEo1WDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzTjBZWEowWDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGIzUmhiRjkyYjNSbGN6b2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZVdWelgzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWpjbVZoZEc5eU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYVhSc1pWOWhibVJmWkdWelkzSnBjSFJwYjI0NklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjkwYVhSc1pTQXJJQ2M2SnlBcklIQnliM0J2YzJGc1gyUmxjMk55YVhCMGFXOXVLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QndjbTl3YjNOaGJGOTVaWE5mZG05MFpYTTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRFdE1URTRDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOXdiM05oYkRvZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNBOUlHNWxkeUJRY205d2IzTmhiRVJoZEdGVWVYQmxLSHNLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlsZUhCcGNubGZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmYzNSaGNuUmZkR2x0WlhOMFlXMXdPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLSEJ5YjNCdmMyRnNYM04wWVhKMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJSEJ5YjNCdmMyRnNYM1J2ZEdGc1gzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOTVaWE5mZG05MFpYTTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDJOeVpXRjBiM0k2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzUnBkR3hsWDJGdVpGOWtaWE5qY21sd2RHbHZiam9nYm1WM0lHRnlZelF1VTNSeUtIQnliM0J2YzJGc1gzUnBkR3hsSUNzZ0p6b25JQ3NnY0hKdmNHOXpZV3hmWkdWelkzSnBjSFJwYjI0cExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdORElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QndjbTl3YjNOaGJGOWpiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQnliM0J2YzJGc1gyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeENpQWdJQ0F2THlCamIyNXpkQ0J1WlhkUWNtOXdiM05oYkU1dmJtTmxJRDBnVldsdWREWTBLSFJvYVhNdWNISnZjRzl6WVd4ZlkyOTFiblF1ZG1Gc2RXVWdLeUF4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNISnZjRzl6WVd3b2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNodVpYZFFjbTl3YjNOaGJFNXZibU5sS1NrdVpYaHBjM1J6TENBblVISnZjRzl6WVd3Z1lXeHlaV0ZrZVNCbGVHbHpkSE1uS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCd2NtOXdiM05oYkNBOUlFSnZlRTFoY0R4UWNtOXdiM05oYkVsa1ZIbHdaU3dnVUhKdmNHOXpZV3hFWVhSaFZIbHdaVDRvZXlCclpYbFFjbVZtYVhnNklDZGZjQ2NnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSWw5d0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2JtVjNVSEp2Y0c5ellXeE9iMjVqWlNrcExtVjRhWE4wY3l3Z0oxQnliM0J2YzJGc0lHRnNjbVZoWkhrZ1pYaHBjM1J6SnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVUhKdmNHOXpZV3dnWVd4eVpXRmtlU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNYMk52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUIwYUdsekxuQnliM0J2YzJGc1gyTnZkVzUwTG5aaGJIVmxJRDBnYm1WM1VISnZjRzl6WVd4T2IyNWpaUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNekFLSUNBZ0lDOHZJSFJvYVhNdWNISnZjRzl6WVd3b2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNodVpYZFFjbTl3YjNOaGJFNXZibU5sS1NrdWRtRnNkV1VnUFNCd2NtOXdiM05oYkM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qcFpaWE5PYjBSaGJ5NTJiM1JsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hmYVdRNklIVnBiblEyTkN3Z2RtOTBaVG9nZFdsdWREWTBMQ0J0WW5KZmRIaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblp2ZEdWUWNtOXdiM05oYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTBMVEV6TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5JSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkbTkwWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzWDJsa09pQjFhVzUwTmpRc0lIWnZkR1U2SUdKdmIyeGxZVzRzSUcxaWNsOTBlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdkR2hwY3k1d2NtOXdiM05oYkNodVpYY2dZWEpqTkM1VmFXNTBUalkwS0hCeWIzQnZjMkZzWDJsa0tTa3VaWGhwYzNSekxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QndjbTl3YjNOaGJDQTlJRUp2ZUUxaGNEeFFjbTl3YjNOaGJFbGtWSGx3WlN3Z1VISnZjRzl6WVd4RVlYUmhWSGx3WlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RmY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lsOXdJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklIUm9hWE11Y0hKdmNHOXpZV3dvYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlwWkNrcExtVjRhWE4wY3l3S0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TnkweE5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2RHaHBjeTV3Y205d2IzTmhiQ2h1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLSEJ5YjNCdmMyRnNYMmxrS1NrdVpYaHBjM1J6TEFvZ0lDQWdMeThnSUNBblZHaGxJSEJ5YjNCdmMyRnNJSFJvWlNCMWMyVnlJR2x6SUhSeWVXbHVaeUIwYnlCMmIzUmxJRzl1SUdSdlpYTWdibTkwSUdWNGFYTjBKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR1VnY0hKdmNHOXpZV3dnZEdobElIVnpaWElnYVhNZ2RISjVhVzVuSUhSdklIWnZkR1VnYjI0Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRMUNpQWdJQ0F2THlCMmIzUmxjbDloWkdSeVpYTnpPaUJ1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRNdE1UUTJDaUFnSUNBdkx5QmpiMjV6ZENCMmIzUmxTV1FnUFNCdVpYY2dWbTkwWlVsa1ZIbHdaU2g3Q2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDJsa09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU3dLSUNBZ0lDOHZJQ0FnZG05MFpYSmZZV1JrY21WemN6b2dibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnZG05MFpTQTlJRUp2ZUUxaGNEeFdiM1JsU1dSVWVYQmxMQ0JXYjNSbFJHRjBZVlI1Y0dVK0tIc2dhMlY1VUhKbFptbDRPaUFuWDNZbklIMHBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSmZkaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTUyYjNSbEtIWnZkR1ZKWkNrdVpYaHBjM1J6TENBblZHaGxJSFZ6WlhJZ2FHRnpJR0ZzY21WaFpIa2dkbTkwWldRZ2IyNGdkR2hwY3lCd2NtOXdiM05oYkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZSb1pTQjFjMlZ5SUdoaGN5QmhiSEpsWVdSNUlIWnZkR1ZrSUc5dUlIUm9hWE1nY0hKdmNHOXpZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBVSEp2Y0c5ellXdzZJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVWdQU0IwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmFXUXBLUzUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFVLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5SVWFXMWxJRDBnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUdOdmJuTjBJR1Y0Y0dseWVWUnBiV1VnUFNCamRYSnlaVzUwVUhKdmNHOXpZV3d1Y0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjQzV1WVhScGRtVUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z5Y21WdWRGUnBiV1VnUENCbGVIQnBjbmxVYVcxbExDQW5WR2hsSUhCeWIzQnZjMkZzSUdoaGN5QmxlSEJwY21Wa0p5a0tJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVkdobElIQnliM0J2YzJGc0lHaGhjeUJsZUhCcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnSVQwOUlIUm9hWE11YldGdVlXZGxjbDloWkdSeVpYTnpMblpoYkhWbExDQW5WR2hsSUcxaGJtRm5aWElnWTJGdWJtOTBJSFp2ZEdVZ2IyNGdjSEp2Y0c5ellXeHpKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJRzFoYm1GblpYSmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVc1aFoyVnlYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJQ0U5UFNCMGFHbHpMbTFoYm1GblpYSmZZV1JrY21WemN5NTJZV3gxWlN3Z0oxUm9aU0J0WVc1aFoyVnlJR05oYm01dmRDQjJiM1JsSUc5dUlIQnliM0J2YzJGc2N5Y3BDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZSb1pTQnRZVzVoWjJWeUlHTmhibTV2ZENCMmIzUmxJRzl1SUhCeWIzQnZjMkZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENodFluSmZkSGh1TG1GdGIzVnVkQ0ErUFNBeE5qUTVNQ3dnSjFCaGVXMWxiblFnYlhWemRDQmpiM1psY2lCMGFHVWdkbTkwWlNCaWIzZ2dUVUpTSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFkwT1RBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdOdmRtVnlJSFJvWlNCMmIzUmxJR0p2ZUNCTlFsSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5WDNSNGJpNXlaV05sYVhabGNpQTlQVDBnYjNBdVIyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z2RHaGxJR052Ym5SeVlXTjBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QjBhR1VnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZNUNpQWdJQ0F2THlCamIyNXpkQ0JiWVhOelpYUkNZV3hoYm1ObExDQm9ZWE5CYzNObGRGMGdQU0J2Y0M1QmMzTmxkRWh2YkdScGJtY3VZWE56WlhSQ1lXeGhibU5sS0ZSNGJpNXpaVzVrWlhJc0lIUm9hWE11WVhOelpYUmZhV1F1ZG1Gc2RXVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmhjM05sZEY5cFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZWE56WlhSQ1lXeGhibU5sTENCb1lYTkJjM05sZEYwZ1BTQnZjQzVCYzNObGRFaHZiR1JwYm1jdVlYTnpaWFJDWVd4aGJtTmxLRlI0Ymk1elpXNWtaWElzSUhSb2FYTXVZWE56WlhSZmFXUXVkbUZzZFdVcENpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2JXbHVhVzExYlY5b2IyeGthVzVuSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXbHVhVzExYlY5b2IyeGthVzVuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjeENpQWdJQ0F2THlCaGMzTmxjblFvWVhOelpYUkNZV3hoYm1ObElENDlJSFJvYVhNdWJXbHVhVzExYlY5b2IyeGthVzVuTG5aaGJIVmxMQ0FuVkdobElIVnpaWElnWkc5bGN5QnViM1FnYUdGMlpTQmxibTkxWjJnZ1lYTnpaWFFnZEc4Z2RtOTBaU2NwQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklGUm9aU0IxYzJWeUlHUnZaWE1nYm05MElHaGhkbVVnWlc1dmRXZG9JR0Z6YzJWMElIUnZJSFp2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QjJiM1JsWDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoamRYSnlaVzUwVkdsdFpTa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnWTI5dWMzUWdkWEJrWVhSbFpGWnZkR1Z6SUQwZ1ZXbHVkRFkwS0dOMWNuSmxiblJRY205d2IzTmhiQzV3Y205d2IzTmhiRjkwYjNSaGJGOTJiM1JsY3k1dVlYUnBkbVVnS3lBeEtRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPREFLSUNBZ0lDOHZJR052Ym5OMElIVndaR0YwWldSWlpYTldiM1JsY3lBOUlGVnBiblEyTkNoamRYSnlaVzUwVUhKdmNHOXpZV3d1Y0hKdmNHOXpZV3hmZVdWelgzWnZkR1Z6TG01aGRHbDJaU0FySUNoMmIzUmxJRDhnTVNBNklEQXBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01qUWdMeThnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCMWNHUmhkR1ZrVUhKdmNHOXpZV3d1Y0hKdmNHOXpZV3hmZEc5MFlXeGZkbTkwWlhNZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIVndaR0YwWldSV2IzUmxjeWtLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzFDaUFnSUNBdkx5QjFjR1JoZEdWa1VISnZjRzl6WVd3dWNISnZjRzl6WVd4ZmVXVnpYM1p2ZEdWeklEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaDFjR1JoZEdWa1dXVnpWbTkwWlhNcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF5TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EZ0tJQ0FnSUM4dklIUm9hWE11ZG05MFpTaDJiM1JsU1dRcExuWmhiSFZsSUQwZ2RtOTBaVVJoZEdFdVkyOXdlU2dwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnZEdocGN5NXdjbTl3YjNOaGJDaHVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU2t1ZG1Gc2RXVWdQU0IxY0dSaGRHVmtVSEp2Y0c5ellXd3VZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwWlpYTk9iMFJoYnk1b1lYTldiM1JsWkNod2NtOXdiM05oYkY5cFpEb2dkV2x1ZERZMExDQjJiM1JsY2pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FHRnpWbTkwWldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOQzB4T1RVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkT2IwOXdKeXdnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJSEIxWW14cFl5Qm9ZWE5XYjNSbFpDaHdjbTl3YjNOaGJGOXBaRG9nZFdsdWREWTBMQ0IyYjNSbGNqb2dRV05qYjNWdWRDazZJR0p2YjJ4bFlXNGdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOd29nSUNBZ0x5OGdjSEp2Y0c5ellXeGZhV1E2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYVdRcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOaTB4T1RrS0lDQWdJQzh2SUdOdmJuTjBJSFp2ZEdWSlpDQTlJRzVsZHlCV2IzUmxTV1JVZVhCbEtIc0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZhV1E2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYVdRcExBb2dJQ0FnTHk4Z0lDQjJiM1JsY2w5aFpHUnlaWE56T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0hadmRHVnlLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2RtOTBaU0E5SUVKdmVFMWhjRHhXYjNSbFNXUlVlWEJsTENCV2IzUmxSR0YwWVZSNWNHVStLSHNnYTJWNVVISmxabWw0T2lBblgzWW5JSDBwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pmZGlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNREVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5admRHVW9kbTkwWlVsa0tTNWxlR2x6ZEhNS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem82V1dWelRtOUVZVzh1WjJWMFVISnZjRzl6WVd3b2NISnZjRzl6WVd4ZmFXUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEZCeWIzQnZjMkZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EUXRNakExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY3NJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBVSEp2Y0c5ellXd29jSEp2Y0c5ellXeGZhV1E2SUhWcGJuUTJOQ2s2SUZCeWIzQnZjMkZzUkdGMFlWUjVjR1VnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnWTI5dWMzUWdjSEp2Y0c5ellXdzZJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVWdQU0IwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmFXUXBLUzUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NISnZjRzl6WVd3Z1BTQkNiM2hOWVhBOFVISnZjRzl6WVd4SlpGUjVjR1VzSUZCeWIzQnZjMkZzUkdGMFlWUjVjR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQW5YM0FuSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURZS0lDQWdJQzh2SUdOdmJuTjBJSEJ5YjNCdmMyRnNPaUJRY205d2IzTmhiRVJoZEdGVWVYQmxJRDBnZEdocGN5NXdjbTl3YjNOaGJDaHVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU2t1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQndjbTl3YjNOaGJBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFIcWdBRW1DUTl0WVc1aFoyVnlYMkZrWkhKbGMzTU9jSEp2Y0c5ellXeGZZMjkxYm5RUllXNTViMjVsWDJOaGJsOWpjbVZoZEdVUGJXbHVhVzExYlY5b2IyeGthVzVuQ0dGemMyVjBYMmxrQWw5d0JCVWZmSFVJQUFBQUFBQUFBQUFDWDNZeEcwRUFNWUlHQlBGZVU3SUVJYmlkM2dUdkQveG9CR3RRbVFjRWw5WE96UVQ0RXYwOU5ob0FqZ1lBbHdCK0FGZ0FPUUFYQUFJaVF6RVpGRVF4R0VRMkdnRVhpQUg3SndaTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Y4QWNpQUhQZ0FFQUlrOENWQ2NHVEZDd0kwTXhHUlJFTVJoRU5ob0JGellhQWlKVE1SWWpDVWs0RUNNU1JJZ0JLeU5ETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUF4Y3hGaU1KU1RnUUl4SkVpQUNYSTBNeEdSUkVNUmhFTmhvQklsTTJHZ0lYTmhvREY0Z0FaU05ETVJrVVJERVlGRVEyR2dFaVV6WWFBaGMyR2dNWGlBQUNJME9LQXdBb01RQm5LU0puS292OVp5dUwvbWNuQkl2L1o3RXlEUll4QUVteUhJSC9xLzNmQXJJWXNnQ0FCSUpHeFNXeUdySWFnQWdBQUFBQUFBQUFBYklhZ1FheUVDS3lBYk9KaWdNQUlpaGxSREVBRWtRcWkvMW5LNHYrWnljRWkvOW5pWW9FQUNJcVpVUkFBQWdpS0dWRU1RQVNSRElIaS84NENDUVBSSXYvT0FjeUNoSkVTWXYrQ0JaTUZqRUFpL3lBQVRwUWkvMVFTUlVXVndZQ1RGQlBBMDhEVUNjSFVDY0hVRThDVUlBQ0FFSlFURkFpS1dWRUl3aEpGaWNGVEZCSnZVVUJGRVFwVHdKblNieElUTCtKaWdNQWkvMFdKd1ZMQVZCSnZVVUJSREVBVHdKTVVDY0lURkJKdlVVQkZFUkxBYjVFTWdkTEFTSmJTd0VOUkRFQUlpaGxSQk5FaS84NENDUVBSSXYvT0FjeUNoSkVNUUFpSndSbFJIQUFTQ0lyWlVRUFJCWkxBWUVRV3lNSVN3S0JHRnVML2doTUZrOERURndRVEJaY0dFNEN2MHNCdkVpL2lZb0NBWXYrRm92L1VDY0lURkM5UlFHSmlnRUJpLzhXSndWTVVMNUVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NSwicGF0Y2giOjMsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
