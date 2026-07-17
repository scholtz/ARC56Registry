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

namespace Arc56.Generated.ValarStaking.xgov_delegation.ProposalMock_4ee0190e
{


    public class ProposalMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ProposalMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetVoterBoxReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
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

                public static GetVoterBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetVoterBoxReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as GetVoterBoxReturn);
                }
                public bool Equals(GetVoterBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetVoterBoxReturn left, GetVoterBoxReturn right)
                {
                    return EqualityComparer<GetVoterBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetVoterBoxReturn left, GetVoterBoxReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="status"> </param>
        public async Task SetStatus(ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 148, 204, 60 };
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetStatus_Transactions(ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 148, 204, 60 };
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="vote_open_ts"> </param>
        public async Task SetVoteOpenTs(ulong vote_open_ts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 90, 193, 15 };
            var vote_open_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_open_tsAbi.From(vote_open_ts);

            var result = await base.CallApp(new List<object> { abiHandle, vote_open_tsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVoteOpenTs_Transactions(ulong vote_open_ts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 90, 193, 15 };
            var vote_open_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_open_tsAbi.From(vote_open_ts);

            return await base.MakeTransactionList(new List<object> { abiHandle, vote_open_tsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voting_duration"> </param>
        public async Task SetVotingDuration(ulong voting_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 244, 249, 169 };
            var voting_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voting_durationAbi.From(voting_duration);

            var result = await base.CallApp(new List<object> { abiHandle, voting_durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVotingDuration_Transactions(ulong voting_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 244, 249, 169 };
            var voting_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voting_durationAbi.From(voting_duration);

            return await base.MakeTransactionList(new List<object> { abiHandle, voting_durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voter"> </param>
        /// <param name="approvals"> </param>
        /// <param name="rejections"> </param>
        public async Task Vote(Algorand.Address voter, ulong approvals, ulong rejections, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 142, 29, 104 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);
            var rejectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejectionsAbi.From(rejections);

            var result = await base.CallApp(new List<object> { abiHandle, voterAbi, approvalsAbi, rejectionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Vote_Transactions(Algorand.Address voter, ulong approvals, ulong rejections, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 142, 29, 104 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);
            var rejectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejectionsAbi.From(rejections);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi, approvalsAbi, rejectionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the Voter box for the given address.
        ///</summary>
        /// <param name="voter_address">The address of the Voter </param>
        /// <param name="votes">The voter's votes </param>
        public async Task SetVoterBox(Algorand.Address voter_address, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 15, 251, 186 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            var result = await base.CallApp(new List<object> { abiHandle, voter_addressAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVoterBox_Transactions(Algorand.Address voter_address, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 15, 251, 186 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            return await base.MakeTransactionList(new List<object> { abiHandle, voter_addressAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the Voter box for the given address.
        ///</summary>
        /// <param name="voter_address">The address of the Voter </param>
        public async Task DelVoterBox(Algorand.Address voter_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 135, 71, 54 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);

            var result = await base.CallApp(new List<object> { abiHandle, voter_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelVoterBox_Transactions(Algorand.Address voter_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 135, 71, 54 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, voter_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the Voter box for the given address.
        ///</summary>
        /// <param name="voter_address">The address of the Voter </param>
        public async Task<Structs.GetVoterBoxReturn> GetVoterBox(Algorand.Address voter_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 97, 95, 144 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);

            var result = await base.SimApp(new List<object> { abiHandle, voter_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoterBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVoterBox_Transactions(Algorand.Address voter_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 97, 95, 144 };
            var voter_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voter_addressAbi.From(voter_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, voter_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJvcG9zYWxNb2NrIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFZvdGVyQm94UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdm90ZV9vcGVuX3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVfb3Blbl90cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdm90aW5nX2R1cmF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGluZ19kdXJhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92YWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWplY3Rpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF92b3Rlcl9ib3giLCJkZXNjIjoiU2V0IHRoZSBWb3RlciBib3ggZm9yIHRoZSBnaXZlbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJfYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgVm90ZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVzIiwiZGVzYyI6IlRoZSB2b3RlcidzIHZvdGVzIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbF92b3Rlcl9ib3giLCJkZXNjIjoiRGVsZXRlIHRoZSBWb3RlciBib3ggZm9yIHRoZSBnaXZlbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJfYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgVm90ZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZvdGVyX2JveCIsImRlc2MiOiJSZXR1cm5zIHRoZSBWb3RlciBib3ggZm9yIHRoZSBnaXZlbiBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJfYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgVm90ZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IkdldFZvdGVyQm94UmV0dXJuIiwiZGVzYyI6IlRoZSB2b3RlcidzIHZvdGVzIGJvb2w6IGBUcnVlYCBpZiB2b3RlcidzIGJveCBleGlzdHMsIGVsc2UgYEZhbHNlYCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGVycyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjYsMjUwLDI3NiwyOTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0LDE5OCwyMTIsMjMzLDI0MCwyNThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlWaUlnTUhnM01qWTFOamMyT1Rjek56UTNNamM1TldZMk1UY3dOekExWmpZNU5qUWdNSGczTXpjME5qRTNORGMxTnpNZ01IZzNOalptTnpRMk5UVm1ObVkzTURZMU5tVTJPVFpsTmpjMVpqYzBOamsyWkRZMU56TTNORFl4Tm1RM01DQXdlRGMyTm1ZM05EWTVObVUyTnpWbU5qUTNOVGN5TmpFM05EWTVObVkyWlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnliM0J2YzJGc1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHdGxlVDF3Y205d1gyTm1aeTVIVTE5TFJWbGZVa1ZIU1ZOVVVsbGZRVkJRWDBsRUxBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3lOalUyTnpZNU56TTNORGN5TnprMVpqWXhOekEzTURWbU5qazJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnliM0J2YzJGc1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklGVkpiblEyTkNncExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y205d2IzTmhiRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakU1TFRJeUNpQWdJQ0F2THlCelpXeG1MbkpsWjJsemRISjVYMkZ3Y0Y5cFpDQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxd2NtOXdYMk5tWnk1SFUxOUxSVmxmVWtWSFNWTlVVbGxmUVZCUVgwbEVMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbTl3YjNOaGJGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QnJaWGs5Y0hKdmNGOWpabWN1UjFOZlMwVlpYMU5VUVZSVlV5d0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNemMwTmpFM05EYzFOek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbTl3YjNOaGJGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QlZTVzUwTmpRb1pXNXRMbE5VUVZSVlUxOUZUVkJVV1Nrc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YjNCdmMyRnNYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNak10TWpZS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWeklEMGdSMnh2WW1Gc1UzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0dWdWJTNVRWRUZVVlZOZlJVMVFWRmtwTEFvZ0lDQWdMeThnSUNBZ0lHdGxlVDF3Y205d1gyTm1aeTVIVTE5TFJWbGZVMVJCVkZWVExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtOXdiM05oYkY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCclpYazljSEp2Y0Y5alptY3VSMU5mUzBWWlgxWlBWRVZmVDFCRlRsOVVVeXdLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGczTmpabU56UTJOVFZtTm1ZM01EWTFObVUyT1RabE5qYzFaamMwTmprMlpEWTFOek0zTkRZeE5tUTNNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnliM0J2YzJGc1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklGVkpiblEyTkNncExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y205d2IzTmhiRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakkzTFRNd0NpQWdJQ0F2THlCelpXeG1Mblp2ZEdWZmIzQmxibDkwY3lBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lHdGxlVDF3Y205d1gyTm1aeTVIVTE5TFJWbGZWazlVUlY5UFVFVk9YMVJUTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y205d2IzTmhiRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJyWlhrOWNISnZjRjlqWm1jdVIxTmZTMFZaWDFaUFZFbE9SMTlFVlZKQlZFbFBUaXdLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTmpabU56UTJPVFpsTmpjMVpqWTBOelUzTWpZeE56UTJPVFptTm1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y205d2IzTmhiRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJWU1c1ME5qUW9LU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnZjRzl6WVd4ZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek1TMHpOQW9nSUNBZ0x5OGdjMlZzWmk1MmIzUnBibWRmWkhWeVlYUnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCclpYazljSEp2Y0Y5alptY3VSMU5mUzBWWlgxWlBWRWxPUjE5RVZWSkJWRWxQVGl3S0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbTl3YjNOaGJGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtOXdiM05oYkUxdlkyc29RVkpETkVOdmJuUnlZV04wTENCaGRtMWZkbVZ5YzJsdmJqMHhNQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd4TXprMFkyTXpZeUF3ZUdGbE5XRmpNVEJtSURCNFlqUm1OR1k1WVRrZ01IaGlZamhsTVdRMk9DQXdlR1l6TUdabVltSmhJREI0TldRNE56UTNNellnTUhneU5EWXhOV1k1TUNBdkx5QnRaWFJvYjJRZ0luTmxkRjl6ZEdGMGRYTW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOTJiM1JsWDI5d1pXNWZkSE1vZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjkyYjNScGJtZGZaSFZ5WVhScGIyNG9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5admRHVW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5MmIzUmxjbDlpYjNnb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1ZzWDNadmRHVnlYMkp2ZUNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MmIzUmxjbDlpYjNnb1lXUmtjbVZ6Y3lrb2RXbHVkRFkwTEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFgzTjBZWFIxY3lCelpYUmZkbTkwWlY5dmNHVnVYM1J6SUhObGRGOTJiM1JwYm1kZlpIVnlZWFJwYjI0Z2RtOTBaU0J6WlhSZmRtOTBaWEpmWW05NElHUmxiRjkyYjNSbGNsOWliM2dnWjJWMFgzWnZkR1Z5WDJKdmVBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnliM0J2YzJGc1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHTnNZWE56SUZCeWIzQnZjMkZzVFc5amF5aEJVa00wUTI5dWRISmhZM1FzSUdGMmJWOTJaWEp6YVc5dVBURXdLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSEp2Y0c5ellXeGZiVzlqYXk1amIyNTBjbUZqZEM1UWNtOXdiM05oYkUxdlkyc3VZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzWDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUhObGJHWXVjbVZuYVhOMGNubGZZWEJ3WDJsa0xuWmhiSFZsSUQwZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3lOalUyTnpZNU56TTNORGN5TnprMVpqWXhOekEzTURWbU5qazJOQW9nSUNBZ1oyeHZZbUZzSUVOaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKdmNHOXpZV3hmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CeWIzQnZjMkZzWDIxdlkyc3VZMjl1ZEhKaFkzUXVVSEp2Y0c5ellXeE5iMk5yTG5ObGRGOXpkR0YwZFhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmYzNSaGRIVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnliM0J2YzJGc1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnZjRzl6WVd4ZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQnpkR0YwZFhNS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM016YzBOakUzTkRjMU56TUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnZjRzl6WVd4ZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSEp2Y0c5ellXeGZiVzlqYXk1amIyNTBjbUZqZEM1UWNtOXdiM05oYkUxdlkyc3VjMlYwWDNadmRHVmZiM0JsYmw5MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5MmIzUmxYMjl3Wlc1ZmRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnZjRzl6WVd4ZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtOXdiM05oYkY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCelpXeG1Mblp2ZEdWZmIzQmxibDkwY3k1MllXeDFaU0E5SUhadmRHVmZiM0JsYmw5MGN3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEYzJObVkzTkRZMU5XWTJaamN3TmpVMlpUWTVObVUyTnpWbU56UTJPVFprTmpVM016YzBOakUyWkRjd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzWDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnliM0J2YzJGc1gyMXZZMnN1WTI5dWRISmhZM1F1VUhKdmNHOXpZV3hOYjJOckxuTmxkRjkyYjNScGJtZGZaSFZ5WVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmRtOTBhVzVuWDJSMWNtRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YjNCdmMyRnNYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEp2Y0c5ellXeGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdjMlZzWmk1MmIzUnBibWRmWkhWeVlYUnBiMjR1ZG1Gc2RXVWdQU0IyYjNScGJtZGZaSFZ5WVhScGIyNEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzNOalptTnpRMk9UWmxOamMxWmpZME56VTNNall4TnpRMk9UWm1ObVVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEp2Y0c5ellXeGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hKdmNHOXpZV3hmYlc5amF5NWpiMjUwY21GamRDNVFjbTl3YjNOaGJFMXZZMnN1ZG05MFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblp2ZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKdmNHOXpZV3hmYlc5amF5OWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2NtOXdiM05oYkY5dGIyTnJMbU52Ym5SeVlXTjBMbEJ5YjNCdmMyRnNUVzlqYXk1elpYUmZkbTkwWlhKZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzWnZkR1Z5WDJKdmVEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtOXdiM05oYkY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKdmNHOXpZV3hmYlc5amF5OWpiMjUwY21GamRDNXdlVG80TXdvZ0lDQWdMeThnYzJWc1ppNTJiM1JsY25OYmRtOTBaWEpmWVdSa2NtVnpjeTV1WVhScGRtVmRJRDBnZG05MFpYTXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbFlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YjNCdmMyRnNYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CeWIzQnZjMkZzWDIxdlkyc3VZMjl1ZEhKaFkzUXVVSEp2Y0c5ellXeE5iMk5yTG1SbGJGOTJiM1JsY2w5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4ZmRtOTBaWEpmWW05NE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzWDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbTl3YjNOaGJGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNTJiM1JsY25OYmRtOTBaWEpmWVdSa2NtVnpjeTV1WVhScGRtVmRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSldJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y205d2IzTmhiRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2NtOXdiM05oYkY5dGIyTnJMbU52Ym5SeVlXTjBMbEJ5YjNCdmMyRnNUVzlqYXk1blpYUmZkbTkwWlhKZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzWnZkR1Z5WDJKdmVEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtOXdiM05oYkY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtOXdiM05oYkY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ2RtOTBaWEpmWVdSa2NtVnpjeTV1WVhScGRtVWdhVzRnYzJWc1ppNTJiM1JsY25NS0lDQWdJR0o1ZEdWalh6QWdMeThnSWxZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YjNCdmMyRnNYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJwWmlCbGVHbHpkSE02Q2lBZ0lDQmllaUJuWlhSZmRtOTBaWEpmWW05NFgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnZjRzl6WVd4ZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklIWnZkR1Z6SUQwZ2MyVnNaaTUyYjNSbGNuTmJkbTkwWlhKZllXUmtjbVZ6Y3k1dVlYUnBkbVZkQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBaWEp6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb0taMlYwWDNadmRHVnlYMkp2ZUY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEp2Y0c5ellXeGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hNakFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2gyYjNSbGN5a3NJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzWDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOTJiM1JsY2w5aWIzaGZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEp2Y0c5ellXeGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJSFp2ZEdWeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCblpYUmZkbTkwWlhKZlltOTRYMkZtZEdWeVgybG1YMlZzYzJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUlJQ1lGQVZZUGNtVm5hWE4wY25sZllYQndYMmxrQm5OMFlYUjFjeFoyYjNSbFgyOXdaVzVwYm1kZmRHbHRaWE4wWVcxd0QzWnZkR2x1WjE5a2RYSmhkR2x2YmpFWVFBQU5LU05uS2lObkt5Tm5Kd1FqWnpFWkZFUXhHRUVBT1lJSEJCT1V6RHdFcmxyQkR3UzA5UG1wQkx1T0hXZ0U4dy83dWdSZGgwYzJCQ1JoWDVBMkdnQ09Cd0FWQUNNQU1RQkFBRmNBY1FDQUFJQUVURnhodWpZYUFJNEJBQUVBS1RJTlp5SkROaG9CU1JVa0VrUVhLa3huSWtNMkdnRkpGU1FTUkJjclRHY2lRellhQVVrVkpCSkVGeWNFVEdjaVF6WWFBUlVsRWtRMkdnSVZKQkpFTmhvREZTUVNSQ0pETmhvQlNSVWxFa1EyR2dKSkZTUVNSQmNvVHdKUVRCYS9Ja00yR2dGSkZTVVNSQ2hNVUx4SUlrTTJHZ0ZKRlNVU1JDaE1VRW05U1U4Q1NFRUFHVXNCdmtRWEZvQUJBQ05MQTFSUWdBUVZIM3gxVEZDd0lrTWpRdi9vIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
