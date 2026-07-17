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

namespace Arc56.Generated.d13co.xgov_delegator.XGovProposalMock_7160d92a
{


    public class XGovProposalMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public XGovProposalMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="voterAddress"> </param>
        public async Task<Structs.GetVoterBoxReturn> GetVoterBox(Algorand.Address voterAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 97, 95, 144 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            var result = await base.SimApp(new List<object> { abiHandle, voterAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoterBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVoterBox_Transactions(Algorand.Address voterAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 97, 95, 144 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voter"> </param>
        /// <param name="approvals"> </param>
        /// <param name="rejections"> </param>
        public async Task<string> Vote(Algorand.Address voter, ulong approvals, ulong rejections, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 65, 160, 210 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);
            var rejectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejectionsAbi.From(rejections);

            var result = await base.CallApp(new List<object> { abiHandle, voterAbi, approvalsAbi, rejectionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Vote_Transactions(Algorand.Address voter, ulong approvals, ulong rejections, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 65, 160, 210 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);
            var rejectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejectionsAbi.From(rejections);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi, approvalsAbi, rejectionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposer"> </param>
        public async Task SetProposer(Algorand.Address proposer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 221, 61, 97 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);

            var result = await base.CallApp(new List<object> { abiHandle, proposerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetProposer_Transactions(Algorand.Address proposer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 221, 61, 97 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 46, 129, 85, 20 };
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
            byte[] abiHandle = { 46, 129, 85, 20 };
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="committeeId"> </param>
        public async Task SetCommitteeId(byte[] committeeId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 122, 52, 158 };
            var committeeIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); committeeIdAbi.From(committeeId);

            var result = await base.CallApp(new List<object> { abiHandle, committeeIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCommitteeId_Transactions(byte[] committeeId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 122, 52, 158 };
            var committeeIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); committeeIdAbi.From(committeeId);

            return await base.MakeTransactionList(new List<object> { abiHandle, committeeIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voteOpenTs"> </param>
        public async Task SetVoteOpenTs(ulong voteOpenTs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 204, 197, 185 };
            var voteOpenTsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voteOpenTsAbi.From(voteOpenTs);

            var result = await base.CallApp(new List<object> { abiHandle, voteOpenTsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVoteOpenTs_Transactions(ulong voteOpenTs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 204, 197, 185 };
            var voteOpenTsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voteOpenTsAbi.From(voteOpenTs);

            return await base.MakeTransactionList(new List<object> { abiHandle, voteOpenTsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="votingDuration"> </param>
        public async Task SetVotingDuration(ulong votingDuration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 159, 90, 207 };
            var votingDurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votingDurationAbi.From(votingDuration);

            var result = await base.CallApp(new List<object> { abiHandle, votingDurationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVotingDuration_Transactions(ulong votingDuration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 159, 90, 207 };
            var votingDurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votingDurationAbi.From(votingDuration);

            return await base.MakeTransactionList(new List<object> { abiHandle, votingDurationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterAddress"> </param>
        /// <param name="votes"> </param>
        public async Task SetVoterBox(Algorand.Address voterAddress, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 162, 213, 122 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            var result = await base.CallApp(new List<object> { abiHandle, voterAddressAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVoterBox_Transactions(Algorand.Address voterAddress, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 162, 213, 122 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAddressAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWEdvdlByb3Bvc2FsTW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRWb3RlckJveFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfdm90ZXJfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IkdldFZvdGVyQm94UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92YWxzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWplY3Rpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UHJvcG9zZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFN0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGF0dXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Q29tbWl0dGVlSWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXR0ZWVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRWb3RlT3BlblRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVPcGVuVHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Vm90aW5nRHVyYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90aW5nRHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Vm90ZXJCb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMzNdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1LDI2NSwyOTgsMzMxLDM4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsMjc5LDMxNCwzNDcsMzY0LDM5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbkJ5YjNCdmMyVnlJaUFpYzNSaGRIVnpJaUFpWTI5dGJXbDBkR1ZsWDJsa0lpQWlkbTkwWlY5dmNHVnVYM1J6SWlBaWRtOTBhVzVuWDJSMWNtRjBhVzl1SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y0hKdmNHOXpZV3d0Ylc5amF5OTRSMjkyVUhKdmNHOXpZV3hOYjJOckxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIQnliM0J2YzJWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlI0Ymk1elpXNWtaWElnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIzQnZjMlZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQjRSMjkyVUhKdmNHOXpZV3hUZEdGMGRYTkxaWGtzSUdsdWFYUnBZV3hXWVd4MVpUb2dVMVJCVkZWVFgwVk5VRlJaSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qSTFMVEk0Q2lBZ0lDQXZMeUJqYjIxdGFYUjBaV1ZKWkNBOUlFZHNiMkpoYkZOMFlYUmxQRU52YlcxcGRIUmxaVWxrUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nZUVkdmRsQnliM0J2YzJGc1EyOXRiV2wwZEdWbFNXUkxaWGtzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dibVYzSUZOMFlYUnBZMEo1ZEdWelBETXlQaWdwTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OdmJXMXBkSFJsWlY5cFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEJ5YjNCdmMyRnNMVzF2WTJzdmVFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcGJtbDBhV0ZzVm1Gc2RXVTZJRzVsZHlCVGRHRjBhV05DZVhSbGN6d3pNajRvS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPakkxTFRJNENpQWdJQ0F2THlCamIyMXRhWFIwWldWSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEVOdmJXMXBkSFJsWlVsa1BpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ2VFZHZkbEJ5YjNCdmMyRnNRMjl0YldsMGRHVmxTV1JMWlhrc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nYm1WM0lGTjBZWFJwWTBKNWRHVnpQRE15UGlncExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RtOTBaVTl3Wlc1VWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJSGhIYjNaUWNtOXdiM05oYkZadmRHVlBjR1Z1VkhOTFpYa3NJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkbTkwWlY5dmNHVnVYM1J6SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxd2NtOXdiM05oYkMxdGIyTnJMM2hIYjNaUWNtOXdiM05oYkUxdlkyc3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkbTkwYVc1blJIVnlZWFJwYjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQjRSMjkyVUhKdmNHOXpZV3hXYjNScGJtZEVkWEpoZEdsdmJrdGxlU3dnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0oyYjNScGJtZGZaSFZ5WVhScGIyNGlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCWVIyOTJVSEp2Y0c5ellXeE5iMk5ySUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTNDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREkwTmpFMVpqa3dJREI0TVRnME1XRXdaRElnTUhnNE5tUmtNMlEyTVNBd2VESmxPREUxTlRFMElEQjRaREEzWVRNME9XVWdNSGcwTldOall6VmlPU0F3ZURrMk9XWTFZV05tSURCNFlUTmhNbVExTjJFZ0x5OGdiV1YwYUc5a0lDSm5aWFJmZG05MFpYSmZZbTk0S0dGa1pISmxjM01wS0hWcGJuUTJOQ3hpYjI5c0tTSXNJRzFsZEdodlpDQWlkbTkwWlNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSnpaWFJRY205d2IzTmxjaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRk4wWVhSMWN5aDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFEyOXRiV2wwZEdWbFNXUW9ZbmwwWlZzek1sMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBWbTkwWlU5d1pXNVVjeWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBWbTkwYVc1blJIVnlZWFJwYjI0b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZadmRHVnlRbTk0S0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQm5aWFJXYjNSbGNrSnZlQ0IyYjNSbElITmxkRkJ5YjNCdmMyVnlJSE5sZEZOMFlYUjFjeUJ6WlhSRGIyMXRhWFIwWldWSlpDQnpaWFJXYjNSbFQzQmxibFJ6SUhObGRGWnZkR2x1WjBSMWNtRjBhVzl1SUhObGRGWnZkR1Z5UW05NENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCWVIyOTJVSEp2Y0c5ellXeE5iMk5ySUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pvNldFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1blpYUldiM1JsY2tKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZadmRHVnlRbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYm1GdFpUb2dKMmRsZEY5MmIzUmxjbDlpYjNnbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEJ5YjNCdmMyRnNMVzF2WTJzdmVFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCMmIzUmxjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oxWW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR052Ym5OMElIc2daWGhwYzNSeklIMGdQU0JpYjNnS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmpiMjV6ZENCMllXeDFaVG9nZFdsdWREWTBJRDBnWlhocGMzUnpJRDhnWW05NExuWmhiSFZsSURvZ01Bb2dJQ0FnWW5vZ1oyVjBWbTkwWlhKQ2IzaGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdKMGIya0tDbWRsZEZadmRHVnlRbTk0WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnlaWFIxY200Z1czWmhiSFZsTENCbGVHbHpkSE5kQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2JtRnRaVG9nSjJkbGRGOTJiM1JsY2w5aWIzZ25JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGWnZkR1Z5UW05NFgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJqYjI1emRDQjJZV3gxWlRvZ2RXbHVkRFkwSUQwZ1pYaHBjM1J6SUQ4Z1ltOTRMblpoYkhWbElEb2dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ1oyVjBWbTkwWlhKQ2IzaGZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZPbGhIYjNaUWNtOXdiM05oYkUxdlkyc3VkbTkwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWnZkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxd2NtOXdiM05oYkMxdGIyTnJMM2hIYjNaUWNtOXdiM05oYkUxdlkyc3VZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdjSFZpYkdsaklIWnZkR1VvZG05MFpYSTZJRUZqWTI5MWJuUXNJR0Z3Y0hKdmRtRnNjem9nZFdsdWREWTBMQ0J5WldwbFkzUnBiMjV6T2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qcFlSMjkyVUhKdmNHOXpZV3hOYjJOckxuTmxkRkJ5YjNCdmMyVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFVISnZjRzl6WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZCeWIzQnZjMlZ5S0hCeWIzQnZjMlZ5T2lCQlkyTnZkVzUwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxtVnVjM1Z5WlVOaGJHeGxja2x6VUhKdmNHOXpaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQmxibk4xY21WRFlXeHNaWEpKYzFCeWIzQnZjMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxd2NtOXdiM05oYkMxdGIyTnJMM2hIYjNaUWNtOXdiM05oYkUxdlkyc3VZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdjSEp2Y0c5elpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVkhodUxuTmxibVJsY2lCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZjRzl6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnZEdocGN5NXdjbTl3YjNObGNpNTJZV3gxWlNBOUlIQnliM0J2YzJWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSUWNtOXdiM05sY2lod2NtOXdiM05sY2pvZ1FXTmpiM1Z1ZENrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPanBZUjI5MlVISnZjRzl6WVd4TmIyTnJMbk5sZEZOMFlYUjFjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVTNSaGRIVnpLSE4wWVhSMWN6b2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTVsYm5OMWNtVkRZV3hzWlhKSmMxQnliM0J2YzJWeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWlc1emRYSmxRMkZzYkdWeVNYTlFjbTl3YjNObGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhOMFlYUjFjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUhoSGIzWlFjbTl3YjNOaGJGTjBZWFIxYzB0bGVTd2dhVzVwZEdsaGJGWmhiSFZsT2lCVFZFRlVWVk5mUlUxUVZGa2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEJ5YjNCdmMyRnNMVzF2WTJzdmVFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOUlITjBZWFIxY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVTNSaGRIVnpLSE4wWVhSMWN6b2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZPbGhIYjNaUWNtOXdiM05oYkUxdlkyc3VjMlYwUTI5dGJXbDBkR1ZsU1dSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJEYjIxdGFYUjBaV1ZKWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwUTI5dGJXbDBkR1ZsU1dRb1kyOXRiV2wwZEdWbFNXUTZJRU52YlcxcGRIUmxaVWxrS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QjBhR2x6TG1WdWMzVnlaVU5oYkd4bGNrbHpVSEp2Y0c5elpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCbGJuTjFjbVZEWVd4c1pYSkpjMUJ5YjNCdmMyVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pveU5TMHlPQW9nSUNBZ0x5OGdZMjl0YldsMGRHVmxTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeERiMjF0YVhSMFpXVkpaRDRvZXdvZ0lDQWdMeThnSUNCclpYazZJSGhIYjNaUWNtOXdiM05oYkVOdmJXMXBkSFJsWlVsa1MyVjVMQW9nSUNBZ0x5OGdJQ0JwYm1sMGFXRnNWbUZzZFdVNklHNWxkeUJUZEdGMGFXTkNlWFJsY3p3ek1qNG9LU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqYjIxdGFYUjBaV1ZmYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnZEdocGN5NWpiMjF0YVhSMFpXVkpaQzUyWVd4MVpTQTlJR052YlcxcGRIUmxaVWxrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJEYjIxdGFYUjBaV1ZKWkNoamIyMXRhWFIwWldWSlpEb2dRMjl0YldsMGRHVmxTV1FwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pvNldFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1elpYUldiM1JsVDNCbGJsUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFZtOTBaVTl3Wlc1VWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEJ5YjNCdmMyRnNMVzF2WTJzdmVFZHZkbEJ5YjNCdmMyRnNUVzlqYXk1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFZtOTBaVTl3Wlc1VWN5aDJiM1JsVDNCbGJsUnpPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QjBhR2x6TG1WdWMzVnlaVU5oYkd4bGNrbHpVSEp2Y0c5elpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCbGJuTjFjbVZEWVd4c1pYSkpjMUJ5YjNCdmMyVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RtOTBaVTl3Wlc1VWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJSGhIYjNaUWNtOXdiM05oYkZadmRHVlBjR1Z1VkhOTFpYa3NJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkbTkwWlY5dmNHVnVYM1J6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNISnZjRzl6WVd3dGJXOWpheTk0UjI5MlVISnZjRzl6WVd4TmIyTnJMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSFJvYVhNdWRtOTBaVTl3Wlc1VWN5NTJZV3gxWlNBOUlIWnZkR1ZQY0dWdVZITUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGWnZkR1ZQY0dWdVZITW9kbTkwWlU5d1pXNVVjem9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02T2xoSGIzWlFjbTl3YjNOaGJFMXZZMnN1YzJWMFZtOTBhVzVuUkhWeVlYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUldiM1JwYm1kRWRYSmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVm05MGFXNW5SSFZ5WVhScGIyNG9kbTkwYVc1blJIVnlZWFJwYjI0NklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSb2FYTXVaVzV6ZFhKbFEyRnNiR1Z5U1hOUWNtOXdiM05sY2lncENpQWdJQ0JqWVd4c2MzVmlJR1Z1YzNWeVpVTmhiR3hsY2tselVISnZjRzl6WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUIyYjNScGJtZEVkWEpoZEdsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJSGhIYjNaUWNtOXdiM05oYkZadmRHbHVaMFIxY21GMGFXOXVTMlY1TENCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5admRHbHVaMTlrZFhKaGRHbHZiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QjBhR2x6TG5admRHbHVaMFIxY21GMGFXOXVMblpoYkhWbElEMGdkbTkwYVc1blJIVnlZWFJwYjI0S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZadmRHbHVaMFIxY21GMGFXOXVLSFp2ZEdsdVowUjFjbUYwYVc5dU9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxd2NtOXdiM05oYkMxdGIyTnJMM2hIYjNaUWNtOXdiM05oYkUxdlkyc3VZV3huYnk1MGN6bzZXRWR2ZGxCeWIzQnZjMkZzVFc5amF5NXpaWFJXYjNSbGNrSnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGWnZkR1Z5UW05NE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSV2IzUmxja0p2ZUNoMmIzUmxja0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXNJSFp2ZEdWek9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUhSb2FYTXVaVzV6ZFhKbFEyRnNiR1Z5U1hOUWNtOXdiM05sY2lncENpQWdJQ0JqWVd4c2MzVmlJR1Z1YzNWeVpVTmhiR3hsY2tselVISnZjRzl6WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUIyYjNSbGNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjFZbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsWWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjSEp2Y0c5ellXd3RiVzlqYXk5NFIyOTJVSEp2Y0c5ellXeE5iMk5yTG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhSb2FYTXVkbTkwWlhKektIWnZkR1Z5UVdSa2NtVnpjeWt1ZG1Gc2RXVWdQU0IyYjNSbGN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y0hKdmNHOXpZV3d0Ylc5amF5OTRSMjkyVUhKdmNHOXpZV3hOYjJOckxtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUldiM1JsY2tKdmVDaDJiM1JsY2tGa1pISmxjM002SUVGalkyOTFiblFzSUhadmRHVnpPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem82V0VkdmRsQnliM0J2YzJGc1RXOWpheTVsYm5OMWNtVkRZV3hzWlhKSmMxQnliM0J2YzJWeUtDa2dMVDRnZG05cFpEb0taVzV6ZFhKbFEyRnNiR1Z5U1hOUWNtOXdiM05sY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYQnliM0J2YzJGc0xXMXZZMnN2ZUVkdmRsQnliM0J2YzJGc1RXOWpheTVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJqYjI1emRDQmpZV3hzWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnWlc1emRYSmxLR05oYkd4bGNpQTlQVDBnZEdocGN5NXdjbTl3YjNObGNpNTJZV3gxWlN3Z0owVlNVanBCVlZSSUp5a0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXdjbTl3YjNOaGJDMXRiMk5yTDNoSGIzWlFjbTl3YjNOaGJFMXZZMnN1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnY0hKdmNHOXpaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZIaHVMbk5sYm1SbGNpQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljSEp2Y0c5elpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF3Y205d2IzTmhiQzF0YjJOckwzaEhiM1pRY205d2IzTmhiRTF2WTJzdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1pXNXpkWEpsS0dOaGJHeGxjaUE5UFQwZ2RHaHBjeTV3Y205d2IzTmxjaTUyWVd4MVpTd2dKMFZTVWpwQlZWUklKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZkWFJwYkhNdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2FXWWdLQ0ZqYjI1a0tTQjdDaUFnSUNCaWJub2daVzV6ZFhKbFEyRnNiR1Z5U1hOUWNtOXdiM05sY2w5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhCeWIzQnZjMkZzTFcxdlkyc3ZlRWR2ZGxCeWIzQnZjMkZzVFc5amF5NWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5Qmxibk4xY21Vb1kyRnNiR1Z5SUQwOVBTQjBhR2x6TG5CeWIzQnZjMlZ5TG5aaGJIVmxMQ0FuUlZKU09rRlZWRWduS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlFWVlVTQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDNWMGFXeHpMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR3h2WnloamIyUmxLUW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzkxZEdsc2N5NWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmxjbklvS1FvZ0lDQWdaWEp5Q2dwbGJuTjFjbVZEWVd4c1pYSkpjMUJ5YjNCdmMyVnlYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUlDWUZDSEJ5YjNCdmMyVnlCbk4wWVhSMWN3eGpiMjF0YVhSMFpXVmZhV1FNZG05MFpWOXZjR1Z1WDNSekQzWnZkR2x1WjE5a2RYSmhkR2x2YmpFWVFBQXlLREVBWnlralp5cUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVp5c2paeWNFSTJjeEcwRUFSekVaRkVReEdFU0NDQVFrWVYrUUJCaEJvTklFaHQwOVlRUXVnVlVVQk5CNk5KNEVSY3pGdVFTV24xclBCS09pMVhvMkdnQ09DQUFMQUQ0QVhnQnVBSDhBandDZ0FMSUFNUmtVTVJnVUVFUWlRellhQVVrVkpSSkVnQUZXVEZCSnZVbFBBa2hCQUJsTEFiNUVGeGFBQVFBalN3TlVVSUFFRlI5OGRVeFFzQ0pESTBMLzZEWWFBUlVsRWtRMkdnSVZKQkpFTmhvREZTUVNSSUFHRlI5OGRRQUFzQ0pETmhvQlNSVWxFa1NJQUdnb1RHY2lRellhQVVrVkpCSkVGNGdBVnlsTVp5SkROaG9CU1JVbEVrU0lBRWNxVEdjaVF6WWFBVWtWSkJKRUY0Z0FOaXRNWnlKRE5ob0JTUlVrRWtRWGlBQWxKd1JNWnlKRE5ob0JTUlVsRWtRMkdnSkpGU1FTUkJlSUFBdUFBVlpQQWxCTUZyOGlRekVBSXlobFJCSkFBQXlBQ0VWU1VqcEJWVlJJc0FDSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
