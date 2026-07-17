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

namespace Arc56.Generated.ValarStaking.xgov_delegation.XgovRegistryMock_1b118fbf
{


    public class XgovRegistryMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public XgovRegistryMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class XGovBoxValue : AVMObjectType
            {
                public Algorand.Address VotingAddress { get; set; }

                public ulong VotedProposals { get; set; }

                public ulong LastVoteTimestamp { get; set; }

                public ulong SubscriptionRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVotingAddress.From(VotingAddress);
                    ret.AddRange(vVotingAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotedProposals.From(VotedProposals);
                    ret.AddRange(vVotedProposals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastVoteTimestamp.From(LastVoteTimestamp);
                    ret.AddRange(vLastVoteTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSubscriptionRound.From(SubscriptionRound);
                    ret.AddRange(vSubscriptionRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static XGovBoxValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new XGovBoxValue();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVotingAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotingAddress = vVotingAddress.ToValue();
                    if (valueVotingAddress is Algorand.Address vVotingAddressValue) { ret.VotingAddress = vVotingAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotedProposals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotedProposals = vVotedProposals.ToValue();
                    if (valueVotedProposals is ulong vVotedProposalsValue) { ret.VotedProposals = vVotedProposalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastVoteTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastVoteTimestamp = vLastVoteTimestamp.ToValue();
                    if (valueLastVoteTimestamp is ulong vLastVoteTimestampValue) { ret.LastVoteTimestamp = vLastVoteTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSubscriptionRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSubscriptionRound = vSubscriptionRound.ToValue();
                    if (valueSubscriptionRound is ulong vSubscriptionRoundValue) { ret.SubscriptionRound = vSubscriptionRoundValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as XGovBoxValue);
                }
                public bool Equals(XGovBoxValue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(XGovBoxValue left, XGovBoxValue right)
                {
                    return EqualityComparer<XGovBoxValue>.Default.Equals(left, right);
                }
                public static bool operator !=(XGovBoxValue left, XGovBoxValue right)
                {
                    return !(left == right);
                }

            }

            public class GetXgovBoxReturn : AVMObjectType
            {
                public Structs.XGovBoxValue Field0 { get; set; } = new Structs.XGovBoxValue();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetXgovBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetXgovBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.XGovBoxValue.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetXgovBoxReturn);
                }
                public bool Equals(GetXgovBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return EqualityComparer<GetXgovBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create an empty proposal.
        ///</summary>
        public async Task<ulong> CreateProposal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 205, 118, 33 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 205, 118, 33 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Vote on a proposal
        ///</summary>
        /// <param name="proposal_id">The application ID of the Proposal app being voted on </param>
        /// <param name="xgov_address">(arc4.Address): The address of the xGov being voted on behalf of </param>
        /// <param name="approval_votes">(arc4.UInt64): The number of approvals votes allocated </param>
        /// <param name="rejection_votes">(arc4.UInt64): The number of rejections votes allocated </param>
        public async Task VoteProposal(ulong proposal_id, Algorand.Address xgov_address, ulong approval_votes, ulong rejection_votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 143, 141, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var approval_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_votesAbi.From(approval_votes);
            var rejection_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejection_votesAbi.From(rejection_votes);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, xgov_addressAbi, approval_votesAbi, rejection_votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteProposal_Transactions(ulong proposal_id, Algorand.Address xgov_address, ulong approval_votes, ulong rejection_votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 143, 141, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var approval_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_votesAbi.From(approval_votes);
            var rejection_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejection_votesAbi.From(rejection_votes);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, xgov_addressAbi, approval_votesAbi, rejection_votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the Voting Address for the xGov.
        ///</summary>
        /// <param name="xgov_address">The xGov address delegating voting power </param>
        /// <param name="voting_address">The voting account address to delegate voting power to </param>
        public async Task SetVotingAccount(Algorand.Address xgov_address, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 162, 120, 133 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVotingAccount_Transactions(Algorand.Address xgov_address, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 162, 120, 133 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the xGov box for the given address.
        ///</summary>
        /// <param name="xgov_address">The address of the xGov </param>
        public async Task<Structs.GetXgovBoxReturn> GetXgovBox(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            var result = await base.SimApp(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetXgovBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetXgovBox_Transactions(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the xGov box for the given address.
        ///</summary>
        /// <param name="xgov_address">The address of the xGov. </param>
        /// <param name="xgov_box">The xgov box content. XGovBoxValue</param>
        public async Task SetXgovBox(Algorand.Address xgov_address, Structs.XGovBoxValue xgov_box, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 250, 205, 243 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi, xgov_box }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXgovBox_Transactions(Algorand.Address xgov_address, Structs.XGovBoxValue xgov_box, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 250, 205, 243 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi, xgov_box }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes the xGov box for the given address.
        ///</summary>
        /// <param name="xgov_address">The address of the xGov. </param>
        public async Task DelXgovBox(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 145, 118, 113 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelXgovBox_Transactions(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 145, 118, 113 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWGdvdlJlZ2lzdHJ5TW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJYR292Qm94VmFsdWUiOlt7Im5hbWUiOiJ2b3RpbmdfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidm90ZWRfcHJvcG9zYWxzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3Rfdm90ZV90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3Vic2NyaXB0aW9uX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0WGdvdkJveFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJYR292Qm94VmFsdWUifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfcHJvcG9zYWwiLCJkZXNjIjoiQ3JlYXRlIGFuIGVtcHR5IHByb3Bvc2FsLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgSUQgb2YgdGhlIGNyZWF0ZWQgcHJvcG9zYWwuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZV9wcm9wb3NhbCIsImRlc2MiOiJWb3RlIG9uIGEgcHJvcG9zYWwiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjoiVGhlIGFwcGxpY2F0aW9uIElEIG9mIHRoZSBQcm9wb3NhbCBhcHAgYmVpbmcgdm90ZWQgb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4Z292X2FkZHJlc3MiLCJkZXNjIjoiKGFyYzQuQWRkcmVzcyk6IFRoZSBhZGRyZXNzIG9mIHRoZSB4R292IGJlaW5nIHZvdGVkIG9uIGJlaGFsZiBvZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92YWxfdm90ZXMiLCJkZXNjIjoiKGFyYzQuVUludDY0KTogVGhlIG51bWJlciBvZiBhcHByb3ZhbHMgdm90ZXMgYWxsb2NhdGVkIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWplY3Rpb25fdm90ZXMiLCJkZXNjIjoiKGFyYzQuVUludDY0KTogVGhlIG51bWJlciBvZiByZWplY3Rpb25zIHZvdGVzIGFsbG9jYXRlZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdm90aW5nX2FjY291bnQiLCJkZXNjIjoiU2V0cyB0aGUgVm90aW5nIEFkZHJlc3MgZm9yIHRoZSB4R292LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6IlRoZSB4R292IGFkZHJlc3MgZGVsZWdhdGluZyB2b3RpbmcgcG93ZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RpbmdfYWRkcmVzcyIsImRlc2MiOiJUaGUgdm90aW5nIGFjY291bnQgYWRkcmVzcyB0byBkZWxlZ2F0ZSB2b3RpbmcgcG93ZXIgdG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3hnb3ZfYm94IiwiZGVzYyI6IlJldHVybnMgdGhlIHhHb3YgYm94IGZvciB0aGUgZ2l2ZW4gYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Inhnb3ZfYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgeEdvdiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpLGJvb2wpIiwic3RydWN0IjoiR2V0WGdvdkJveFJldHVybiIsImRlc2MiOiJUaGUgeEdvdiBib3ggdmFsdWUgYm9vbDogYFRydWVgIGlmIHhHb3YgYm94IGV4aXN0cywgZWxzZSBgRmFsc2VgIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfeGdvdl9ib3giLCJkZXNjIjoiU2V0cyB0aGUgeEdvdiBib3ggZm9yIHRoZSBnaXZlbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSB4R292LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiWEdvdkJveFZhbHVlIiwibmFtZSI6Inhnb3ZfYm94IiwiZGVzYyI6IlRoZSB4Z292IGJveCBjb250ZW50LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxfeGdvdl9ib3giLCJkZXNjIjoiRGVsZXRlcyB0aGUgeEdvdiBib3ggZm9yIHRoZSBnaXZlbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSB4R292LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjFdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnhnb3ZfYm94IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Nyw1NTQsNTYyLDU4MCw2NzksNzA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OSw1MDUsNTEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy5jb21tb24uYWJpX3R5cGVzLlhHb3ZCb3hWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEYzRJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUdOc1lYTnpJRmhuYjNaU1pXZHBjM1J5ZVUxdlkyc29RVkpETkVOdmJuUnlZV04wTENCaGRtMWZkbVZ5YzJsdmJqMHhNQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhNV05rTnpZeU1TQXdlREUxT0dZNFpHUTJJREI0TUdSaE1qYzRPRFVnTUhneU56WXpNR1EyTlNBd2VHSTRabUZqWkdZeklEQjRZVFU1TVRjMk56RWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZjSEp2Y0c5ellXd29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkbTkwWlY5d2NtOXdiM05oYkNoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOTJiM1JwYm1kZllXTmpiM1Z1ZENoaFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNobmIzWmZZbTk0S0dGa1pISmxjM01wS0NoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTeGliMjlzS1NJc0lHMWxkR2h2WkNBaWMyVjBYM2huYjNaZlltOTRLR0ZrWkhKbGMzTXNLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkY5NFoyOTJYMkp2ZUNoaFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVmZjSEp2Y0c5ellXd2dkbTkwWlY5d2NtOXdiM05oYkNCelpYUmZkbTkwYVc1blgyRmpZMjkxYm5RZ1oyVjBYM2huYjNaZlltOTRJSE5sZEY5NFoyOTJYMkp2ZUNCa1pXeGZlR2R2ZGw5aWIzZ0tJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxtTnlaV0YwWlY5d2NtOXdiM05oYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5d2NtOXdiM05oYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16Z3ROREFLSUNBZ0lDOHZJSEpsY3lBOUlHRnlZelF1WVhKak5GOWpjbVZoZEdVb0NpQWdJQ0F2THlBZ0lDQWdVSEp2Y0c5ellXeE5iMk5yTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSMnh2WW1Gc1RuVnRWV2x1ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVMk5DaERiMFZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlUyTkNoRGFVRkZRVkZCU1VsRFdVWkJWbGxRWTIxV2JtRllUakJqYm14bVdWaENkMWd5Ykd0Q2JrNHdXVmhTTVdONFdqSmlNMUpzV0RJNWQxcFhOWEJpYldSbVpFZHNkRnBZVGpCWlZ6RjNSRE5hZG1SSGJIVmFNVGxyWkZoS2FHUkhiSFppYWtWWlVVRkJUa3RUVG01TGFVNXVTM2xPYmtwM1VXcGFla1ZhUmtWUmVFZEZSVUZQV1VsSVFrSlBWWHBFZDBWeWJISkNSSGRUTURsUWJYQkNUSFZQU0ZkblJUaDNMemQxWjFKa2FEQmpNa0pEVW1oWU5VRXlSMmREVDBKM1FWWkJRMDFCVFZGQ1FVRkdZMEZqVVVOQlFVbEJSVlJHZUdoMWFsbGhRVWswUWtGQlJVRkxWRWxPV25sS1JFNW9iMEpUVWxWclJXdFJXRXRyZUc1SmEwMHlSMmRHU2taVFVWTlNRbU55VkVkamFWRjZXV0ZCVld0V1NrSktSVVo1WTBWVVIyTnBVWHBaWVVGU1ZXeEZhMUV5UjJkSlZrcENTa1ZPYUc5RVJsTlJVMUpEU2tST2FHOUNVMUpWYkVWclVUSkhaMHBLUmxOUlUxSkNZMjlVZDBwUlZFSmhMMGxyVFRKSFowWktSbE5WVTFKRGFFMVZUSGhKU1d0Tk1rZG5Sa3BHVTFWVFVrTm9UVlZGYlRsVFZUaERVMFZGUVVkVmMwSjJhMUZZUm05QlFrRkRUa3hCTVZKUlowRlJWa2d6ZURGVVJrTjNTV3ROYWxGMkwyOHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlZCaFoyVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak01Q2lBZ0lDQXZMeUJRY205d2IzTmhiRTF2WTJzc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTRMVFF3Q2lBZ0lDQXZMeUJ5WlhNZ1BTQmhjbU0wTG1GeVl6UmZZM0psWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRkJ5YjNCdmMyRnNUVzlqYXl3S0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUXlMVFExQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljbVZ6TG1OeVpXRjBaV1JmWVhCd0xtRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBVZHNiMkpoYkM1dGFXNWZZbUZzWVc1alpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklISmxZMlZwZG1WeVBYSmxjeTVqY21WaGRHVmtYMkZ3Y0M1aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCaGJXOTFiblE5UjJ4dlltRnNMbTFwYmw5aVlXeGhibU5sTEFvZ0lDQWdaMnh2WW1Gc0lFMXBia0poYkdGdVkyVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRJdE5EVUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxeVpYTXVZM0psWVhSbFpGOWhjSEF1WVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5UjJ4dlltRnNMbTFwYmw5aVlXeGhibU5sTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxuWnZkR1ZmY0hKdmNHOXpZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMmIzUmxYM0J5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8yTmkwM01nb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCUWNtOXdiM05oYkUxdlkyc3VkbTkwWlN3S0lDQWdJQzh2SUNBZ0lDQjRaMjkyWDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYQndjbTkyWVd4ZmRtOTBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnFaV04wYVc5dVgzWnZkR1Z6TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxd2NtOXdiM05oYkY5cFpDNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR0Z3Y0Y5cFpEMXdjbTl3YjNOaGJGOXBaQzVoYzE5MWFXNTBOalFvS1N3S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pZMkxUY3lDaUFnSUNBdkx5QmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lGQnliM0J2YzJGc1RXOWpheTUyYjNSbExBb2dJQ0FnTHk4Z0lDQWdJSGhuYjNaZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjSEJ5YjNaaGJGOTJiM1JsY3l3S0lDQWdJQzh2SUNBZ0lDQnlaV3BsWTNScGIyNWZkbTkwWlhNc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BYQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WW1JNFpURmtOamdnTHk4Z2JXVjBhRzlrSUNKMmIzUmxLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxuTmxkRjkyYjNScGJtZGZZV05qYjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5MmIzUnBibWRmWVdOamIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TnpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG80TlFvZ0lDQWdMeThnYzJWc1ppNTRaMjkyWDJKdmVGdDRaMjkyWDJGa1pISmxjM011Ym1GMGFYWmxYUzUyYjNScGJtZGZZV1JrY21WemN5QTlJSFp2ZEdsdVoxOWhaR1J5WlhOekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56Z0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTG1OdmJuUnlZV04wTGxobmIzWlNaV2RwYzNSeWVVMXZZMnN1WjJWMFgzaG5iM1pmWW05NFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNobmIzWmZZbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJsZUdsemRITWdQU0I0WjI5MlgyRmtaSEpsYzNNdWJtRjBhWFpsSUdsdUlITmxiR1l1ZUdkdmRsOWliM2dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczT0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCcFppQmxlR2x6ZEhNNkNpQWdJQ0JpZWlCblpYUmZlR2R2ZGw5aWIzaGZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCMllXd2dQU0J6Wld4bUxuaG5iM1pmWW05NFczaG5iM1pmWVdSa2NtVnpjeTV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbmhuYjNaZlltOTRJR1Z1ZEhKNUlHVjRhWE4wY3dvS1oyVjBYM2huYjNaZlltOTRYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5NFoyOTJYMkp2ZUY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVEExTFRFeE1Bb2dJQ0FnTHk4Z2RtRnNJRDBnZEhsd0xsaEhiM1pDYjNoV1lXeDFaU2dLSUNBZ0lDOHZJQ0FnSUNCMmIzUnBibWRmWVdSa2NtVnpjejFoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUM4dklDQWdJQ0IyYjNSbFpGOXdjbTl3YjNOaGJITTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MmIzUmxYM1JwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZFdKelkzSnBjSFJwYjI1ZmNtOTFibVE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVNrS0lDQWdJR0lnWjJWMFgzaG5iM1pmWW05NFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NXpaWFJmZUdkdmRsOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZlR2R2ZGw5aWIzZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTlRZZ0x5OGdOVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k1amIyMXRiMjR1WVdKcFgzUjVjR1Z6TGxoSGIzWkNiM2hXWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hNamNLSUNBZ0lDOHZJSE5sYkdZdWVHZHZkbDlpYjNoYmVHZHZkbDloWkdSeVpYTnpMbTVoZEdsMlpWMGdQU0I0WjI5MlgySnZlQzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NWtaV3hmZUdkdmRsOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGZlR2R2ZGw5aWIzZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TkRJS0lDQWdJQzh2SUdSbGJDQnpaV3htTG5obmIzWmZZbTk0VzNobmIzWmZZV1JrY21WemN5NXVZWFJwZG1WZENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56Z0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVNBQUNDWUNBWGdFRlI5OGRURWJRUUE1TVJrVVJERVlSSUlHQktITmRpRUVGWStOMWdRTm9uaUZCQ2RqRFdVRXVQck44d1Nsa1haeE5ob0FqZ1lBQ3dHVkFkWUI4QUpUQW13QU1Sa1VNUmdVRUVRaVE3R0JCTEkwZ0FRS2dRRkRza0tBelFJS0lBUUJBQWdnSmdVQlZnOXlaV2RwYzNSeWVWOWhjSEJmYVdRR2MzUmhkSFZ6Rm5admRHVmZiM0JsYm1sdVoxOTBhVzFsYzNSaGJYQVBkbTkwYVc1blgyUjFjbUYwYVc5dU1SaEFBQTBwSTJjcUkyY3JJMmNuQkNObk1Sa1VSREVZUVFBNWdnY0VFNVRNUEFTdVdzRVBCTFQwK2FrRXU0NGRhQVR6RC91NkJGMkhSellFSkdGZmtEWWFBSTRIQUJVQUl3QXhBRUFBVndCeEFJQUFnQVJNWEdHNk5ob0FqZ0VBQVFBcE1nMW5Ja00yR2dGSkZTUVNSQmNxVEdjaVF6WWFBVWtWSkJKRUZ5dE1aeUpETmhvQlNSVWtFa1FYSndSTVp5SkROaG9CRlNVU1JEWWFBaFVrRWtRMkdnTVZKQkpFSWtNMkdnRkpGU1VTUkRZYUFra1ZKQkpFRnloUEFsQk1GcjhpUXpZYUFVa1ZKUkpFS0V4UXZFZ2lRellhQVVrVkpSSkVLRXhRU2IxSlR3SklRUUFaU3dHK1JCY1dnQUVBSTBzRFZGQ0FCQlVmZkhWTVVMQWlReU5DLytpeVFJQUVURnhodXJJYWdRYXlFQ1N5QWJPMFBiRkpjZ2hFTWdHeUNMSUhJcklRSkxJQnN4WXBURkN3SWtNMkdnRkpGU1VTUkRZYUFra1ZJeEpFTmhvRFNSVWxFa1EyR2dSSkZTVVNSTEZQQXhleUdJQUV1NDRkYUxJYVR3S3lHa3l5R3JJYWdRYXlFQ1N5QWJNaVF6WWFBVWtWSXhKRU5ob0NTUlVqRWtRb1R3SlFKRThDdXlKRE5ob0JTUlVqRWtRb1RGQkp2VWxQQWtoQkFCSkxBYjVFZ0FFQUpFc0RWRkFwVEZDd0lrT0FPQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUXYrMU5ob0JTUlVqRWtRMkdnSkpGWUU0RWtRb1R3SlFUTDhpUXpZYUFVa1ZJeEpFS0V4UXZFZ2lRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
