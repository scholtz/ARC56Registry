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

namespace Arc56.Generated.Algorand_Developer_Retreat.weDAO.YesNoDao_c9fdb393
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWWVzTm9EYW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvcG9zYWxEYXRhVHlwZSI6W3sibmFtZSI6InByb3Bvc2FsX2V4cGlyeV90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zYWxfc3RhcnRfdGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3RvdGFsX3ZvdGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2FsX3llc192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3NhbF9jcmVhdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwcm9wb3NhbF90aXRsZV9hbmRfZGVzY3JpcHRpb24iLCJ0eXBlIjoic3RyaW5nIn1dLCJWb3RlRGF0YVR5cGUiOlt7Im5hbWUiOiJ2b3RlX3RpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFueW9uZV9jYW5fY3JlYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5pbXVtX2hvbGRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbnlvbmVfY2FuX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluaW11bV9ob2xkaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZVByb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX3RpdGxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9kZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc19pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlUHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc1ZvdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6IlByb3Bvc2FsRGF0YVR5cGUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTI5LDY0M10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMsMTg0LDIxOCwyNDksMjg3LDMxMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIG1hbmFnZXIgY2FuIGNvbmZpZ3VyZSB0aGUgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBtYW5hZ2VyIGNhbiBjcmVhdGUgcHJvcG9zYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE4LDU2Ml0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byB0aGUgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgdGhlIGJveCBNQlIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTRdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgdGhlIHZvdGUgYm94IE1CUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4M10sImVycm9yTWVzc2FnZSI6IlByb3Bvc2FsIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiVGhlIG1hbmFnZXIgY2Fubm90IHZvdGUgb24gcHJvcG9zYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM5XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHByb3Bvc2FsIGhhcyBleHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA5XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHByb3Bvc2FsIHRoZSB1c2VyIGlzIHRyeWluZyB0byB2b3RlIG9uIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHVzZXIgZG9lcyBub3QgaGF2ZSBlbm91Z2ggYXNzZXQgdG8gdm90ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNV0sImVycm9yTWVzc2FnZSI6IlRoZSB1c2VyIGhhcyBhbHJlYWR5IHZvdGVkIG9uIHRoaXMgcHJvcG9zYWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTZdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMTg3LDIyMSwyNTIsMjkwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NSwzOTAsMzk3LDQ2OSw1NDUsNTY5LDU3Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MCwyNzhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERTJORGt3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p0WVc1aFoyVnlYMkZrWkhKbGMzTWlJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSWdJbUZ1ZVc5dVpWOWpZVzVmWTNKbFlYUmxJaUFpYldsdWFXMTFiVjlvYjJ4a2FXNW5JaUFpWVhOelpYUmZhV1FpSUNKZmNDSWdNSGd4TlRGbU4yTTNOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREFnSWw5Mklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWXhOV1UxTTJJeUlEQjRNakZpT0Rsa1pHVWdNSGhsWmpCbVptTTJPQ0F3ZURaaU5UQTVPVEEzSURCNE9UZGtOV05sWTJRZ01IaG1PREV5Wm1RelpDQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiMjVtYVdkMWNtVkRiMjUwY21GamRDaGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsVUhKdmNHOXpZV3dvYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWnZkR1ZRY205d2IzTmhiQ2gxYVc1ME5qUXNZbTl2YkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWFHRnpWbTkwWldRb2RXbHVkRFkwTEdGalkyOTFiblFwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwVUhKdmNHOXpZV3dvZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXh6ZEhKcGJtY3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeklHMWhhVzVmWTI5dVptbG5kWEpsUTI5dWRISmhZM1JmY205MWRHVkFOQ0J0WVdsdVgyTnlaV0YwWlZCeWIzQnZjMkZzWDNKdmRYUmxRRFVnYldGcGJsOTJiM1JsVUhKdmNHOXpZV3hmY205MWRHVkFOaUJ0WVdsdVgyaGhjMVp2ZEdWa1gzSnZkWFJsUURjZ2JXRnBibDluWlhSUWNtOXdiM05oYkY5eWIzVjBaVUE0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1dXVnpUbTlFWVc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGQnliM0J2YzJGc1gzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nV1dWelRtOUVZVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJRY205d2IzTmhiQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW9ZWE5XYjNSbFpGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5d2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0Njc0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR2hoYzFadmRHVmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNadmRHVlFjbTl3YjNOaGJGOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1dXVnpUbTlFWVc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbTkwWlZCeWIzQnZjMkZzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWQnliM0J2YzJGc1gzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0NjZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZsbGMwNXZSR0Z2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVlFjbTl3YjNOaGJBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amIyNW1hV2QxY21WRGIyNTBjbUZqZEY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJaWlhOT2IwUmhieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkT2IwOXdKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQmpiMjVtYVdkMWNtVkRiMjUwY21GamRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGbGxjMDV2UkdGdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNldXVnpUbTlFWVc4dVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1lXNTViMjVsWDJOaGJsOWpjbVZoZEdVNklIVnBiblEyTkN3Z2JXbHVhVzExYlY5b2IyeGthVzVuT2lCMWFXNTBOalFzSUdGemMyVjBYMmxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9TMDBNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDV2VDNBbkxDQnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZVzU1YjI1bFgyTmhibDlqY21WaGRHVTZJR0p2YjJ4bFlXNHNJRzFwYm1sdGRXMWZhRzlzWkdsdVp6b2dkV2x1ZERZMExDQmhjM05sZEY5cFpEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUcxaGJtRm5aWEpmWVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhibUZuWlhKZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIUm9hWE11YldGdVlXZGxjbDloWkdSeVpYTnpMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNYMk52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJvYVhNdWNISnZjRzl6WVd4ZlkyOTFiblF1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUdGdWVXOXVaVjlqWVc1ZlkzSmxZWFJsSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZVzU1YjI1bFgyTmhibDlqY21WaGRHVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUIwYUdsekxtRnVlVzl1WlY5allXNWZZM0psWVhSbExuWmhiSFZsSUQwZ1lXNTViMjVsWDJOaGJsOWpjbVZoZEdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHMXBibWx0ZFcxZmFHOXNaR2x1WnlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliV2x1YVcxMWJWOW9iMnhrYVc1bklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkR2hwY3k1dGFXNXBiWFZ0WDJodmJHUnBibWN1ZG1Gc2RXVWdQU0J0YVc1cGJYVnRYMmh2YkdScGJtY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR0Z6YzJWMFgybGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGMzTmxkRjlwWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklIUm9hWE11WVhOelpYUmZhV1F1ZG1Gc2RXVWdQU0JoYzNObGRGOXBaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem82V1dWelRtOUVZVzh1WTI5dVptbG5kWEpsUTI5dWRISmhZM1FvWVc1NWIyNWxYMk5oYmw5amNtVmhkR1U2SUhWcGJuUTJOQ3dnYldsdWFXMTFiVjlvYjJ4a2FXNW5PaUIxYVc1ME5qUXNJR0Z6YzJWMFNXUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZMjl1Wm1sbmRYSmxRMjl1ZEhKaFkzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyTFRVM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJQzh2SUhCMVlteHBZeUJqYjI1bWFXZDFjbVZEYjI1MGNtRmpkQ2hoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaVG9nWW05dmJHVmhiaXdnYldsdWFXMTFiVjlvYjJ4a2FXNW5PaUIxYVc1ME5qUXNJR0Z6YzJWMFNXUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCdFlXNWhaMlZ5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRnVZV2RsY2w5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhibUZuWlhKZllXUmtjbVZ6Y3k1MllXeDFaU0E5UFQwZ1ZIaHVMbk5sYm1SbGNpd2dKMDl1YkhrZ2RHaGxJRzFoYm1GblpYSWdZMkZ1SUdOdmJtWnBaM1Z5WlNCMGFHVWdZMjl1ZEhKaFkzUW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0J0WVc1aFoyVnlJR05oYmlCamIyNW1hV2QxY21VZ2RHaGxJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRnVlVzl1WlY5allXNWZZM0psWVhSbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkR2hwY3k1aGJubHZibVZmWTJGdVgyTnlaV0YwWlM1MllXeDFaU0E5SUdGdWVXOXVaVjlqWVc1ZlkzSmxZWFJsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCdGFXNXBiWFZ0WDJodmJHUnBibWNnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltMXBibWx0ZFcxZmFHOXNaR2x1WnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklIUm9hWE11YldsdWFXMTFiVjlvYjJ4a2FXNW5MblpoYkhWbElEMGdiV2x1YVcxMWJWOW9iMnhrYVc1bkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QmhjM05sZEY5cFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVhOelpYUmZhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWMFgybGtMblpoYkhWbElEMGdZWE56WlhSSlpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZXV1Z6VG05RVlXOHVZM0psWVhSbFVISnZjRzl6WVd3b2NISnZjRzl6WVd4ZmRHbDBiR1U2SUdKNWRHVnpMQ0J3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2YmpvZ1lubDBaWE1zSUdWNGNHbHlaWE5mYVc0NklIVnBiblEyTkN3Z2JXSnlYM1I0YmpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZRY205d2IzTmhiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBdE56WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVkJ5YjNCdmMyRnNLQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYVhSc1pUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWtaWE5qY21sd2RHbHZiam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JsZUhCcGNtVnpYMmx1T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUcxaWNsOTBlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTkNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5Qmhibmx2Ym1WZlkyRnVYMk55WldGMFpTQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poYm5sdmJtVmZZMkZ1WDJOeVpXRjBaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTVoYm5sdmJtVmZZMkZ1WDJOeVpXRjBaUzUyWVd4MVpTQTlQVDBnWm1Gc2MyVXBJSHNLSUNBZ0lHSnVlaUJqY21WaGRHVlFjbTl3YjNOaGJGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHMWhibUZuWlhKZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnRZVzVoWjJWeVgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViV0Z1WVdkbGNsOWhaR1J5WlhOekxuWmhiSFZsSUQwOVBTQlVlRzR1YzJWdVpHVnlMQ0FuVDI1c2VTQjBhR1VnYldGdVlXZGxjaUJqWVc0Z1kzSmxZWFJsSUhCeWIzQnZjMkZzY3ljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEdobElHMWhibUZuWlhJZ1kyRnVJR055WldGMFpTQndjbTl3YjNOaGJITUtDbU55WldGMFpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHTnZibk4wSUdOMWNuSmxiblJVYVcxbGMzUmhiWEE2SUhWcGJuUTJOQ0E5SUc5d0xrZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdGemMyVnlkQ2h0WW5KZmRIaHVMbUZ0YjNWdWRDQStQU0F4TmpRNU1Dd2dKMUJoZVcxbGJuUWdiWFZ6ZENCamIzWmxjaUIwYUdVZ1ltOTRJRTFDVWljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyTkRrd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCamIzWmxjaUIwYUdVZ1ltOTRJRTFDVWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaWNsOTBlRzR1Y21WalpXbDJaWElnUFQwOUlHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQW5VR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJSFJvWlNCamIyNTBjbUZqZENjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnZEdobElHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOXdiM05oYkY5bGVIQnBjbmxmZEdsdFpYTjBZVzF3T2lCMWFXNTBOalFnUFNCamRYSnlaVzUwVkdsdFpYTjBZVzF3SUNzZ1pYaHdhWEpsYzE5cGJnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJWNGNHbHllVjkwYVcxbGMzUmhiWEE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCd2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmYzNSaGNuUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJOeVpXRjBiM0k2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2NISnZjRzl6WVd4ZmRHbDBiR1ZmWVc1a1gyUmxjMk55YVhCMGFXOXVPaUJ1WlhjZ1lYSmpOQzVUZEhJb2NISnZjRzl6WVd4ZmRHbDBiR1VnS3lBbk9pY2dLeUJ3Y205d2IzTmhiRjlrWlhOamNtbHdkR2x2Ymlrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSEIxYzJoaWVYUmxjeUFpT2lJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qazBMVEV3TVFvZ0lDQWdMeThnWTI5dWMzUWdjSEp2Y0c5ellXdzZJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVWdQU0J1WlhjZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNoN0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZlpYaHdhWEo1WDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzTjBZWEowWDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGIzUmhiRjkyYjNSbGN6b2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZVdWelgzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWpjbVZoZEc5eU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYVhSc1pWOWhibVJmWkdWelkzSnBjSFJwYjI0NklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjkwYVhSc1pTQXJJQ2M2SnlBcklIQnliM0J2YzJGc1gyUmxjMk55YVhCMGFXOXVLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QndjbTl3YjNOaGJGOTBiM1JoYkY5MmIzUmxjem9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1N3S0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMExURXdNUW9nSUNBZ0x5OGdZMjl1YzNRZ2NISnZjRzl6WVd3NklGQnliM0J2YzJGc1JHRjBZVlI1Y0dVZ1BTQnVaWGNnVUhKdmNHOXpZV3hFWVhSaFZIbHdaU2g3Q2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDJWNGNHbHllVjkwYVcxbGMzUmhiWEE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvY0hKdmNHOXpZV3hmWlhod2FYSjVYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDNOMFlYSjBYM1JwYldWemRHRnRjRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjl6ZEdGeWRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYjNSaGJGOTJiM1JsY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdjSEp2Y0c5ellXeGZlV1Z6WDNadmRHVnpPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLREFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5amNtVmhkRzl5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOTBhWFJzWlY5aGJtUmZaR1Z6WTNKcGNIUnBiMjQ2SUc1bGR5QmhjbU0wTGxOMGNpaHdjbTl3YjNOaGJGOTBhWFJzWlNBcklDYzZKeUFySUhCeWIzQnZjMkZzWDJSbGMyTnlhWEIwYVc5dUtTd0tJQ0FnSUM4dklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDNsbGMxOTJiM1JsY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qazBMVEV3TVFvZ0lDQWdMeThnWTI5dWMzUWdjSEp2Y0c5ellXdzZJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVWdQU0J1WlhjZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNoN0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZlpYaHdhWEo1WDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lIQnliM0J2YzJGc1gzTjBZWEowWDNScGJXVnpkR0Z0Y0RvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5emRHRnlkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkY5MGIzUmhiRjkyYjNSbGN6b2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnY0hKdmNHOXpZV3hmZVdWelgzWnZkR1Z6T2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOWpjbVZoZEc5eU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiRjkwYVhSc1pWOWhibVJmWkdWelkzSnBjSFJwYjI0NklHNWxkeUJoY21NMExsTjBjaWh3Y205d2IzTmhiRjkwYVhSc1pTQXJJQ2M2SnlBcklIQnliM0J2YzJGc1gyUmxjMk55YVhCMGFXOXVLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURReUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnY0hKdmNHOXpZV3hmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOQW9nSUNBZ0x5OGdZMjl1YzNRZ2JtVjNVSEp2Y0c5ellXeE9iMjVqWlNBOUlGVnBiblEyTkNoMGFHbHpMbkJ5YjNCdmMyRnNYMk52ZFc1MExuWmhiSFZsSUNzZ01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbkJ5YjNCdmMyRnNLRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9ibVYzVUhKdmNHOXpZV3hPYjI1alpTa3BMbVY0YVhOMGN5d2dKMUJ5YjNCdmMyRnNJR0ZzY21WaFpIa2daWGhwYzNSekp5a0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSEp2Y0c5ellXd2dQU0JDYjNoTllYQThVSEp2Y0c5ellXeEpaRlI1Y0dVc0lGQnliM0J2YzJGc1JHRjBZVlI1Y0dVK0tIc2dhMlY1VUhKbFptbDRPaUFuWDNBbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTV3Y205d2IzTmhiQ2h1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRzVsZDFCeWIzQnZjMkZzVG05dVkyVXBLUzVsZUdsemRITXNJQ2RRY205d2IzTmhiQ0JoYkhKbFlXUjVJR1Y0YVhOMGN5Y3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGQnliM0J2YzJGc0lHRnNjbVZoWkhrZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCd2NtOXdiM05oYkY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNISnZjRzl6WVd4ZlkyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z2RHaHBjeTV3Y205d2IzTmhiRjlqYjNWdWRDNTJZV3gxWlNBOUlHNWxkMUJ5YjNCdmMyRnNUbTl1WTJVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCMGFHbHpMbkJ5YjNCdmMyRnNLRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9ibVYzVUhKdmNHOXpZV3hPYjI1alpTa3BMblpoYkhWbElEMGdjSEp2Y0c5ellXd3VZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem82V1dWelRtOUVZVzh1ZG05MFpWQnliM0J2YzJGc0tIQnliM0J2YzJGc1gybGtPaUIxYVc1ME5qUXNJSFp2ZEdVNklIVnBiblEyTkN3Z2JXSnlYM1I0YmpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMmIzUmxVSEp2Y0c5ellXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TnkweE1UZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3SnlCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUhadmRHVlFjbTl3YjNOaGJDaHdjbTl3YjNOaGJGOXBaRG9nZFdsdWREWTBMQ0IyYjNSbE9pQmliMjlzWldGdUxDQnRZbkpmZEhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpFS0lDQWdJQzh2SUhSb2FYTXVjSEp2Y0c5ellXd29ibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaHdjbTl3YjNOaGJGOXBaQ2twTG1WNGFYTjBjeXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hKdmNHOXpZV3dnUFNCQ2IzaE5ZWEE4VUhKdmNHOXpZV3hKWkZSNWNHVXNJRkJ5YjNCdmMyRnNSR0YwWVZSNWNHVStLSHNnYTJWNVVISmxabWw0T2lBblgzQW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmY0NJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUIwYUdsekxuQnliM0J2YzJGc0tHNWxkeUJoY21NMExsVnBiblJPTmpRb2NISnZjRzl6WVd4ZmFXUXBLUzVsZUdsemRITXNDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qQXRNVEl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSFJvYVhNdWNISnZjRzl6WVd3b2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNod2NtOXdiM05oYkY5cFpDa3BMbVY0YVhOMGN5d0tJQ0FnSUM4dklDQWdKMVJvWlNCd2NtOXdiM05oYkNCMGFHVWdkWE5sY2lCcGN5QjBjbmxwYm1jZ2RHOGdkbTkwWlNCdmJpQmtiMlZ6SUc1dmRDQmxlR2x6ZENjc0NpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnVkdobElIQnliM0J2YzJGc0lIUm9aU0IxYzJWeUlHbHpJSFJ5ZVdsdVp5QjBieUIyYjNSbElHOXVJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdkbTkwWlhKZllXUmtjbVZ6Y3pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTJMVEV5T1FvZ0lDQWdMeThnWTI5dWMzUWdkbTkwWlVsa0lEMGdibVYzSUZadmRHVkpaRlI1Y0dVb2V3b2dJQ0FnTHk4Z0lDQndjbTl3YjNOaGJGOXBaRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlwWkNrc0NpQWdJQ0F2THlBZ0lIWnZkR1Z5WDJGa1pISmxjM002SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIWnZkR1VnUFNCQ2IzaE5ZWEE4Vm05MFpVbGtWSGx3WlN3Z1ZtOTBaVVJoZEdGVWVYQmxQaWg3SUd0bGVWQnlaV1pwZURvZ0oxOTJKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWDNZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWRtOTBaU2gyYjNSbFNXUXBMbVY0YVhOMGN5d2dKMVJvWlNCMWMyVnlJR2hoY3lCaGJISmxZV1I1SUhadmRHVmtJRzl1SUhSb2FYTWdjSEp2Y0c5ellXd25LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR1VnZFhObGNpQm9ZWE1nWVd4eVpXRmtlU0IyYjNSbFpDQnZiaUIwYUdseklIQnliM0J2YzJGc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdZMjl1YzNRZ1kzVnljbVZ1ZEZCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkVSaGRHRlVlWEJsSUQwZ2RHaHBjeTV3Y205d2IzTmhiQ2h1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLSEJ5YjNCdmMyRnNYMmxrS1NrdWRtRnNkV1V1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNNENpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBWR2x0WlNBOUlHOXdMa2RzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTVDaUFnSUNBdkx5QmpiMjV6ZENCbGVIQnBjbmxVYVcxbElEMGdZM1Z5Y21WdWRGQnliM0J2YzJGc0xuQnliM0J2YzJGc1gyVjRjR2x5ZVY5MGFXMWxjM1JoYlhBdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOMWNuSmxiblJVYVcxbElEd2daWGh3YVhKNVZHbHRaU3dnSjFSb1pTQndjbTl3YjNOaGJDQm9ZWE1nWlhod2FYSmxaQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklGUm9aU0J3Y205d2IzTmhiQ0JvWVhNZ1pYaHdhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlDRTlQU0IwYUdsekxtMWhibUZuWlhKZllXUmtjbVZ6Y3k1MllXeDFaU3dnSjFSb1pTQnRZVzVoWjJWeUlHTmhibTV2ZENCMmIzUmxJRzl1SUhCeWIzQnZjMkZzY3ljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCdFlXNWhaMlZ5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRnVZV2RsY2w5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBaFBUMGdkR2hwY3k1dFlXNWhaMlZ5WDJGa1pISmxjM011ZG1Gc2RXVXNJQ2RVYUdVZ2JXRnVZV2RsY2lCallXNXViM1FnZG05MFpTQnZiaUJ3Y205d2IzTmhiSE1uS1FvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR1VnYldGdVlXZGxjaUJqWVc1dWIzUWdkbTkwWlNCdmJpQndjbTl3YjNOaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5WDNSNGJpNWhiVzkxYm5RZ1BqMGdNVFkwT1RBc0lDZFFZWGx0Wlc1MElHMTFjM1FnWTI5MlpYSWdkR2hsSUhadmRHVWdZbTk0SUUxQ1VpY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFMk5Ea3dDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmpiM1psY2lCMGFHVWdkbTkwWlNCaWIzZ2dUVUpTQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaWNsOTBlRzR1Y21WalpXbDJaWElnUFQwOUlHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQW5VR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJSFJvWlNCamIyNTBjbUZqZENjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnZEdobElHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdZMjl1YzNRZ1cyRnpjMlYwUW1Gc1lXNWpaU3dnYUdGelFYTnpaWFJkSUQwZ2IzQXVRWE56WlhSSWIyeGthVzVuTG1GemMyVjBRbUZzWVc1alpTaFVlRzR1YzJWdVpHVnlMQ0IwYUdsekxtRnpjMlYwWDJsa0xuWmhiSFZsS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWVhOelpYUmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMlZmWkdGdkwzbGxjMTl1YjE5a1lXOHZXV1Z6VG05RGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGemMyVjBRbUZzWVc1alpTd2dhR0Z6UVhOelpYUmRJRDBnYjNBdVFYTnpaWFJJYjJ4a2FXNW5MbUZ6YzJWMFFtRnNZVzVqWlNoVWVHNHVjMlZ1WkdWeUxDQjBhR2x6TG1GemMyVjBYMmxrTG5aaGJIVmxLUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJRzFwYm1sdGRXMWZhRzlzWkdsdVp5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTFwYm1sdGRXMWZhRzlzWkdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOQW9nSUNBZ0x5OGdZWE56WlhKMEtHRnpjMlYwUW1Gc1lXNWpaU0ErUFNCMGFHbHpMbTFwYm1sdGRXMWZhRzlzWkdsdVp5NTJZV3gxWlN3Z0oxUm9aU0IxYzJWeUlHUnZaWE1nYm05MElHaGhkbVVnWlc1dmRXZG9JR0Z6YzJWMElIUnZJSFp2ZEdVbktRb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYUdVZ2RYTmxjaUJrYjJWeklHNXZkQ0JvWVhabElHVnViM1ZuYUNCaGMzTmxkQ0IwYnlCMmIzUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnZG05MFpWOTBhVzFsYzNSaGJYQTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9ZM1Z5Y21WdWRGUnBiV1VwTEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklHTnZibk4wSUhWd1pHRjBaV1JXYjNSbGN5QTlJRlZwYm5RMk5DaGpkWEp5Wlc1MFVISnZjRzl6WVd3dWNISnZjRzl6WVd4ZmRHOTBZV3hmZG05MFpYTXVibUYwYVhabElDc2dNU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZekNpQWdJQ0F2THlCamIyNXpkQ0IxY0dSaGRHVmtXV1Z6Vm05MFpYTWdQU0JWYVc1ME5qUW9ZM1Z5Y21WdWRGQnliM0J2YzJGc0xuQnliM0J2YzJGc1gzbGxjMTkyYjNSbGN5NXVZWFJwZG1VZ0t5QW9kbTkwWlNBL0lERWdPaUF3S1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJWZlpHRnZMM2xsYzE5dWIxOWtZVzh2V1dWelRtOURiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdkWEJrWVhSbFpGQnliM0J2YzJGc0xuQnliM0J2YzJGc1gzUnZkR0ZzWDNadmRHVnpJRDBnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2gxY0dSaGRHVmtWbTkwWlhNcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlERTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyVmZaR0Z2TDNsbGMxOXViMTlrWVc4dldXVnpUbTlEYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyT0FvZ0lDQWdMeThnZFhCa1lYUmxaRkJ5YjNCdmMyRnNMbkJ5YjNCdmMyRnNYM2xsYzE5MmIzUmxjeUE5SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvZFhCa1lYUmxaRmxsYzFadmRHVnpLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN4Q2lBZ0lDQXZMeUIwYUdsekxuWnZkR1VvZG05MFpVbGtLUzUyWVd4MVpTQTlJSFp2ZEdWRVlYUmhMbU52Y0hrb0tRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklIUm9hWE11Y0hKdmNHOXpZV3dvYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlwWkNrcExuWmhiSFZsSUQwZ2RYQmtZWFJsWkZCeWIzQnZjMkZzTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkbFgyUmhieTk1WlhOZmJtOWZaR0Z2TDFsbGMwNXZRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZXV1Z6VG05RVlXOHVhR0Z6Vm05MFpXUW9jSEp2Y0c5ellXeGZhV1E2SUhWcGJuUTJOQ3dnZG05MFpYSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbWhoYzFadmRHVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpjdE1UYzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UbTlQY0Njc0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nYUdGelZtOTBaV1FvY0hKdmNHOXpZV3hmYVdRNklIVnBiblEyTkN3Z2RtOTBaWEk2SUVGalkyOTFiblFwT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RBS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJsa09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGxYMlJoYnk5NVpYTmZibTlmWkdGdkwxbGxjMDV2UTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnprdE1UZ3lDaUFnSUNBdkx5QmpiMjV6ZENCMmIzUmxTV1FnUFNCdVpYY2dWbTkwWlVsa1ZIbHdaU2g3Q2lBZ0lDQXZMeUFnSUhCeWIzQnZjMkZzWDJsa09pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtIQnliM0J2YzJGc1gybGtLU3dLSUNBZ0lDOHZJQ0FnZG05MFpYSmZZV1JrY21WemN6b2dibVYzSUdGeVl6UXVRV1JrY21WemN5aDJiM1JsY2lrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSFp2ZEdVZ1BTQkNiM2hOWVhBOFZtOTBaVWxrVkhsd1pTd2dWbTkwWlVSaGRHRlVlWEJsUGloN0lHdGxlVkJ5WldacGVEb2dKMTkySnlCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVgzWWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTJiM1JsS0hadmRHVkpaQ2t1WlhocGMzUnpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sbGxjMDV2UkdGdkxtZGxkRkJ5YjNCdmMyRnNLSEJ5YjNCdmMyRnNYMmxrT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUlFjbTl3YjNOaGJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGczTFRFNE9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzWDJsa09pQjFhVzUwTmpRcE9pQlFjbTl3YjNOaGJFUmhkR0ZVZVhCbElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RsWDJSaGJ5OTVaWE5mYm05ZlpHRnZMMWxsYzA1dlEyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Ea0tJQ0FnSUM4dklHTnZibk4wSUhCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkVSaGRHRlVlWEJsSUQwZ2RHaHBjeTV3Y205d2IzTmhiQ2h1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLSEJ5YjNCdmMyRnNYMmxrS1NrdWRtRnNkV1V1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1pWOWtZVzh2ZVdWelgyNXZYMlJoYnk5WlpYTk9iME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNJRDBnUW05NFRXRndQRkJ5YjNCdmMyRnNTV1JVZVhCbExDQlFjbTl3YjNOaGJFUmhkR0ZVZVhCbFBpaDdJR3RsZVZCeVpXWnBlRG9nSjE5d0p5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlYM0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWlY5a1lXOHZlV1Z6WDI1dlgyUmhieTlaWlhOT2IwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOXdiM05oYkRvZ1VISnZjRzl6WVd4RVlYUmhWSGx3WlNBOUlIUm9hWE11Y0hKdmNHOXpZV3dvYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y205d2IzTmhiRjlwWkNrcExuWmhiSFZsTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNaVjlrWVc4dmVXVnpYMjV2WDJSaGJ5OVpaWE5PYjBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrd0NpQWdJQ0F2THlCeVpYUjFjbTRnY0hKdmNHOXpZV3dLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBSHFnQUVtQ1E5dFlXNWhaMlZ5WDJGa1pISmxjM01PY0hKdmNHOXpZV3hmWTI5MWJuUVJZVzU1YjI1bFgyTmhibDlqY21WaGRHVVBiV2x1YVcxMWJWOW9iMnhrYVc1bkNHRnpjMlYwWDJsa0FsOXdCQlVmZkhVSUFBQUFBQUFBQUFBQ1gzWXhHMEVBTVlJR0JQRmVVN0lFSWJpZDNnVHZEL3hvQkd0UW1RY0VsOVhPelFUNEV2MDlOaG9BamdZQWx3QitBRmdBT1FBWEFBSWlRekVaRkVReEdFUTJHZ0VYaUFIS0p3Wk1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGOEFjaUFHZWdBRUFJazhDVkNjR1RGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFpSlRNUllqQ1VrNEVDTVNSSWdBK2lORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBeGN4RmlNSlNUZ1FJeEpFaUFCbUkwTXhHUlJFTVJoRU5ob0JJbE0yR2dJWE5ob0RGNGdBTkNORE1Sa1VSREVZRkVRMkdnRWlVellhQWhjMkdnTVhpQUFDSTBPS0F3QW9NUUJuS1NKbktvdjlaeXVML21jbkJJdi9aNG1LQXdBaUtHVkVNUUFTUkNxTC9XY3JpLzVuSndTTC8yZUppZ1FBSWlwbFJFQUFDQ0lvWlVReEFCSkVNZ2VML3pnSUpBOUVpLzg0QnpJS0VrUkppLzRJRmt3V01RQ0wvSUFCT2xDTC9WQkpGUlpYQmdKTVVFOERUd05RSndkUUp3ZFFUd0pRZ0FJQVFsQk1VQ0lwWlVRakNFa1dKd1ZNVUVtOVJRRVVSQ2xQQW1kSnZFaE12NG1LQXdDTC9SWW5CVXNCVUVtOVJRRkVNUUJQQWt4UUp3aE1VRW05UlFFVVJFc0J2a1F5QjBzQklsdExBUTFFTVFBaUtHVkVFMFNML3pnSUpBOUVpLzg0QnpJS0VrUXhBQ0luQkdWRWNBQklJaXRsUkE5RUZrc0JnUkJiSXdoTEFvRVlXNHYrQ0V3V1R3Tk1YQkJNRmx3WVRnSy9Td0c4U0wrSmlnSUJpLzRXaS85UUp3aE1VTDFGQVltS0FRR0wveFluQlV4UXZrU0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo1LCJwYXRjaCI6MywiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
