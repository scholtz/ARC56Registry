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

namespace Arc56.Generated.osmndotdev.AlgorandPollsDapp.PollManager_a58643e6
{


    public class PollManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PollManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PollData : AVMObjectType
            {
                public ulong Id { get; set; }

                public string Question { get; set; }

                public string Option1 { get; set; }

                public string Option2 { get; set; }

                public string Option3 { get; set; }

                public string Option4 { get; set; }

                public string Option5 { get; set; }

                public ulong Option1Votes { get; set; }

                public ulong Option2Votes { get; set; }

                public ulong Option3Votes { get; set; }

                public ulong Option4Votes { get; set; }

                public ulong Option5Votes { get; set; }

                public Algorand.Address[] Voters { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuestion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vQuestion.From(Question);
                    stringRef[ret.Count] = vQuestion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption1.From(Option1);
                    stringRef[ret.Count] = vOption1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption2.From(Option2);
                    stringRef[ret.Count] = vOption2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption3.From(Option3);
                    stringRef[ret.Count] = vOption3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption4.From(Option4);
                    stringRef[ret.Count] = vOption4.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption5.From(Option5);
                    stringRef[ret.Count] = vOption5.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption1Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOption1Votes.From(Option1Votes);
                    ret.AddRange(vOption1Votes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption2Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOption2Votes.From(Option2Votes);
                    ret.AddRange(vOption2Votes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption3Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOption3Votes.From(Option3Votes);
                    ret.AddRange(vOption3Votes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption4Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOption4Votes.From(Option4Votes);
                    ret.AddRange(vOption4Votes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption5Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOption5Votes.From(Option5Votes);
                    ret.AddRange(vOption5Votes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoters = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    vVoters.From(Voters);
                    ret.AddRange(vVoters.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PollData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PollData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    var indexQuestion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuestion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vQuestion.Decode(bytes.Skip(indexQuestion + prefixOffset).ToArray());
                    var valueQuestion = vQuestion.ToValue();
                    if (valueQuestion is string vQuestionValue) { ret.Question = vQuestionValue; }
                    var indexOption1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption1.Decode(bytes.Skip(indexOption1 + prefixOffset).ToArray());
                    var valueOption1 = vOption1.ToValue();
                    if (valueOption1 is string vOption1Value) { ret.Option1 = vOption1Value; }
                    var indexOption2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption2.Decode(bytes.Skip(indexOption2 + prefixOffset).ToArray());
                    var valueOption2 = vOption2.ToValue();
                    if (valueOption2 is string vOption2Value) { ret.Option2 = vOption2Value; }
                    var indexOption3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption3.Decode(bytes.Skip(indexOption3 + prefixOffset).ToArray());
                    var valueOption3 = vOption3.ToValue();
                    if (valueOption3 is string vOption3Value) { ret.Option3 = vOption3Value; }
                    var indexOption4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption4.Decode(bytes.Skip(indexOption4 + prefixOffset).ToArray());
                    var valueOption4 = vOption4.ToValue();
                    if (valueOption4 is string vOption4Value) { ret.Option4 = vOption4Value; }
                    var indexOption5 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOption5.Decode(bytes.Skip(indexOption5 + prefixOffset).ToArray());
                    var valueOption5 = vOption5.ToValue();
                    if (valueOption5 is string vOption5Value) { ret.Option5 = vOption5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption1Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOption1Votes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOption1Votes = vOption1Votes.ToValue();
                    if (valueOption1Votes is ulong vOption1VotesValue) { ret.Option1Votes = vOption1VotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption2Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOption2Votes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOption2Votes = vOption2Votes.ToValue();
                    if (valueOption2Votes is ulong vOption2VotesValue) { ret.Option2Votes = vOption2VotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption3Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOption3Votes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOption3Votes = vOption3Votes.ToValue();
                    if (valueOption3Votes is ulong vOption3VotesValue) { ret.Option3Votes = vOption3VotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption4Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOption4Votes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOption4Votes = vOption4Votes.ToValue();
                    if (valueOption4Votes is ulong vOption4VotesValue) { ret.Option4Votes = vOption4VotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOption5Votes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOption5Votes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOption5Votes = vOption5Votes.ToValue();
                    if (valueOption5Votes is ulong vOption5VotesValue) { ret.Option5Votes = vOption5VotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoters = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address[]");
                    count = vVoters.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVoters = vVoters.ToValue();
                    if (valueVoters is Algorand.Address[] vVotersValue) { ret.Voters = vVotersValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PollData);
                }
                public bool Equals(PollData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PollData left, PollData right)
                {
                    return EqualityComparer<PollData>.Default.Equals(left, right);
                }
                public static bool operator !=(PollData left, PollData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_data"> PollData</param>
        public async Task CreatePoll(Structs.PollData poll_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 116, 217, 120 };

            var result = await base.CallApp(new List<object> { abiHandle, poll_data }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreatePoll_Transactions(Structs.PollData poll_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 116, 217, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_data }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task VoteOption1(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 2, 167, 155 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteOption1_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 2, 167, 155 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task VoteOption2(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 56, 90, 229 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteOption2_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 56, 90, 229 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task VoteOption3(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 177, 159, 97 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteOption3_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 177, 159, 97 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task VoteOption4(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 32, 84, 219 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteOption4_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 32, 84, 219 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task VoteOption5(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 250, 204, 47 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteOption5_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 250, 204, 47 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="poll_id"> </param>
        /// <param name="caller"> </param>
        public async Task<bool> DidVote(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 146, 106, 186 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DidVote_Transactions(ulong poll_id, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 146, 106, 186 };
            var poll_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poll_idAbi.From(poll_id);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, poll_idAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9sbE1hbmFnZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUG9sbERhdGEiOlt7Im5hbWUiOiJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJxdWVzdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fMiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fMyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fNCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fNSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25fMV92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcHRpb25fMl92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcHRpb25fM192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcHRpb25fNF92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcHRpb25fNV92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlcnMiLCJ0eXBlIjoiYWRkcmVzc1tdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfcG9sbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYWRkcmVzc1tdKSIsInN0cnVjdCI6IlBvbGxEYXRhIiwibmFtZSI6InBvbGxfZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlX29wdGlvbl8xIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvbGxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZV9vcHRpb25fMiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZvdGVfb3B0aW9uXzMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9sbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlX29wdGlvbl80IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvbGxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZV9vcHRpb25fNSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRpZF92b3RlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvbGxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNTgsNDM1LDUxMiw2MDYsNzAwXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSB2b3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyN10sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2LDE1NSwxNzMsMTkxLDIwOSwyMjcsMjQ1LDI2MF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNiw2MzAsNzIzXSwiZXJyb3JNZXNzYWdlIjoiT3B0aW9uIGRvZXNuJ3QgZXhpc3QgaW4gdGhpcyBwb2xsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5LDE1OCwxNzYsMTk0LDIxMiwyMzAsMjQ4LDI2M10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjUsNDQyLDUxOSw2MTMsNzA3LDc5M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X21hcF9zdHJ1Y3QgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uZXh0X3BvbGxfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjRzlzYkY5dFlXNWhaMlZ5TG1OdmJuUnlZV04wTGxCdmJHeE5ZVzVoWjJWeUxsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklERWdNQ0EyTUNBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNHOXNiSE1pSUNKdVpYaDBYM0J2Ykd4ZmFXUWlJREI0TURBd01DQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl6Q2lBZ0lDQXZMeUJ6Wld4bUxtNWxlSFJmY0c5c2JGOXBaQ0E5SUdGeVl6UXVWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnVaWGgwWDNCdmJHeGZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJqYkdGemN5QlFiMnhzVFdGdVlXZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXpDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREppWldObE1URWdNSGc1TlRjMFpEazNPQ0F3ZURVMU1ESmhOemxpSURCNE5EUXpPRFZoWlRVZ01IaGhObUl4T1dZMk1TQXdlREUzTWpBMU5HUmlJREI0WkRsbVlXTmpNbVlnTUhnNE5qa3lObUZpWVNBdkx5QnRaWFJvYjJRZ0ltaGxiR3h2S0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU55WldGMFpWOXdiMnhzS0NoMWFXNTBOalFzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOelcxMHBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWnZkR1ZmYjNCMGFXOXVYekVvZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRtOTBaVjl2Y0hScGIyNWZNaWgxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKMmIzUmxYMjl3ZEdsdmJsOHpLSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5admRHVmZiM0IwYVc5dVh6UW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG05MFpWOXZjSFJwYjI1Zk5TaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0prYVdSZmRtOTBaU2gxYVc1ME5qUXNZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlvWld4c2IxOXliM1YwWlVBMUlHMWhhVzVmWTNKbFlYUmxYM0J2Ykd4ZmNtOTFkR1ZBTmlCdFlXbHVYM1p2ZEdWZmIzQjBhVzl1WHpGZmNtOTFkR1ZBTnlCdFlXbHVYM1p2ZEdWZmIzQjBhVzl1WHpKZmNtOTFkR1ZBT0NCdFlXbHVYM1p2ZEdWZmIzQjBhVzl1WHpOZmNtOTFkR1ZBT1NCdFlXbHVYM1p2ZEdWZmIzQjBhVzl1WHpSZmNtOTFkR1ZBTVRBZ2JXRnBibDkyYjNSbFgyOXdkR2x2Ymw4MVgzSnZkWFJsUURFeElHMWhhVzVmWkdsa1gzWnZkR1ZmY205MWRHVkFNVElLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ2Ykd4TllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUnBaRjkyYjNSbFgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ2Ykd4TllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1pHbGtYM1p2ZEdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbTkwWlY5dmNIUnBiMjVmTlY5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJqYkdGemN5QlFiMnhzVFdGdVlXZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhadmRHVmZiM0IwYVc5dVh6VUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRtOTBaVjl2Y0hScGIyNWZORjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWIyeHNUV0Z1WVdkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2Ykd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFp2ZEdWZmIzQjBhVzl1WHpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZG05MFpWOXZjSFJwYjI1Zk0xOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRkJ2Ykd4TllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2RtOTBaVjl2Y0hScGIyNWZNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTJiM1JsWDI5d2RHbHZibDh5WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2Ykd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1VHOXNiRTFoYm1GblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUIyYjNSbFgyOXdkR2x2Ymw4eUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNadmRHVmZiM0IwYVc5dVh6RmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJRYjJ4c1RXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlIWnZkR1ZmYjNCMGFXOXVYekVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgzQnZiR3hmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCUWIyeHNUV0Z1WVdkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2Ykd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWOXdiMnhzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJRYjJ4c1RXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHaGxiR3h2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJqYkdGemN5QlFiMnhzVFdGdVlXZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHOXNiRjl0WVc1aFoyVnlMbU52Ym5SeVlXTjBMbEJ2Ykd4TllXNWhaMlZ5TG1obGJHeHZLRzVoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FHVnNiRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTFMVEkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdobGJHeHZLSE5sYkdZc0lHNWhiV1U2SUZOMGNtbHVaeWtnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCeVpYUjFjbTRnSWtobGJHeHZMQ0FpSUNzZ2JtRnRaUW9nSUNBZ2NIVnphR0o1ZEdWeklDSklaV3hzYnl3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeHNYMjFoYm1GblpYSXVZMjl1ZEhKaFkzUXVVRzlzYkUxaGJtRm5aWEl1WTNKbFlYUmxYM0J2Ykd3b2NHOXNiRjlrWVhSaE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDNCdmJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJNUxUTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmpjbVZoZEdWZmNHOXNiQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhCdmJHeGZaR0YwWVRvZ1VHOXNiRVJoZEdFc0NpQWdJQ0F2THlBcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklIQnZiR3hmWkdGMFlTNXBaQ0E5SUhObGJHWXVibVY0ZEY5d2IyeHNYMmxrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlibVY0ZEY5d2IyeHNYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNWxlSFJmY0c5c2JGOXBaQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiYzJWc1ppNXVaWGgwWDNCdmJHeGZhV1JkSUQwZ2NHOXNiRjlrWVhSaExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0c5c2JITWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ6Wld4bUxtNWxlSFJmY0c5c2JGOXBaQ0E5SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Ym1WNGRGOXdiMnhzWDJsa0xtNWhkR2wyWlNBcklERXBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYm1WNGRGOXdiMnhzWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2IyeHNYMjFoYm1GblpYSXVZMjl1ZEhKaFkzUXVVRzlzYkUxaGJtRm5aWEl1ZG05MFpWOXZjSFJwYjI1Zk1TaHdiMnhzWDJsa09pQmllWFJsY3l3Z1kyRnNiR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZG05MFpWOXZjSFJwYjI1Zk1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpndE16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlIWnZkR1ZmYjNCMGFXOXVYekVvYzJWc1ppd2djRzlzYkY5cFpEb2dZWEpqTkM1VlNXNTBOalFzSUdOaGJHeGxjam9nWVhKak5DNUJaR1J5WlhOektTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSE5sYkdZdVpHbGtYM1p2ZEdVb2NHOXNiRjlwWkN3Z1kyRnNiR1Z5S1N3Z0lrRnNjbVZoWkhrZ2RtOTBaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCa2FXUmZkbTkwWlFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ2RtOTBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklITmxiR1l1WW05NFgyMWhjRjl6ZEhKMVkzUmJjRzlzYkY5cFpGMHViM0IwYVc5dVh6RmZkbTkwWlhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtSnZlRjl0WVhCZmMzUnlkV04wVzNCdmJHeGZhV1JkTG05d2RHbHZibDh4WDNadmRHVnpMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3YjJ4c2N5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMElHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJd0lDOHZJREl3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURJd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnpaV3htTG1KdmVGOXRZWEJmYzNSeWRXTjBXM0J2Ykd4ZmFXUmRMblp2ZEdWeWN5NWhjSEJsYm1Rb1kyRnNiR1Z5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOakFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdiMnhzWDIxaGJtRm5aWEl1WTI5dWRISmhZM1F1VUc5c2JFMWhibUZuWlhJdWRtOTBaVjl2Y0hScGIyNWZNaWh3YjJ4c1gybGtPaUJpZVhSbGN5d2dZMkZzYkdWeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RtOTBaVjl2Y0hScGIyNWZNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5EUXRORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSFp2ZEdWZmIzQjBhVzl1WHpJb2MyVnNaaXdnY0c5c2JGOXBaRG9nWVhKak5DNVZTVzUwTmpRc0lHTmhiR3hsY2pvZ1lYSmpOQzVCWkdSeVpYTnpLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVaR2xrWDNadmRHVW9jRzlzYkY5cFpDd2dZMkZzYkdWeUtTd2dJa0ZzY21WaFpIa2dkbTkwWldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQmthV1JmZG05MFpRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2dkbTkwWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiY0c5c2JGOXBaRjB1YjNCMGFXOXVYekpmZG05MFpYTWdQU0JoY21NMExsVkpiblEyTkNoelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMFczQnZiR3hmYVdSZExtOXdkR2x2Ymw4eVgzWnZkR1Z6TG01aGRHbDJaU0FySURFcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2IyeHNjeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmVGOXRZWEJmYzNSeWRXTjBJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTRJQzh2SURJNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESTRDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl0WVhCZmMzUnlkV04wVzNCdmJHeGZhV1JkTG5admRHVnljeTVoY0hCbGJtUW9ZMkZzYkdWeUtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTmpBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YjJ4c1gyMWhibUZuWlhJdVkyOXVkSEpoWTNRdVVHOXNiRTFoYm1GblpYSXVkbTkwWlY5dmNIUnBiMjVmTXlod2IyeHNYMmxrT2lCaWVYUmxjeXdnWTJGc2JHVnlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkbTkwWlY5dmNIUnBiMjVmTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVEF0TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhadmRHVmZiM0IwYVc5dVh6TW9jMlZzWml3Z2NHOXNiRjlwWkRvZ1lYSmpOQzVWU1c1ME5qUXNJR05oYkd4bGNqb2dZWEpqTkM1QlpHUnlaWE56S1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCaGMzTmxjblFnYm05MElITmxiR1l1Wkdsa1gzWnZkR1VvY0c5c2JGOXBaQ3dnWTJGc2JHVnlLU3dnSWtGc2NtVmhaSGtnZG05MFpXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJrYVdSZmRtOTBaUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnZG05MFpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSnZlRjl0WVhCZmMzUnlkV04wVzNCdmJHeGZhV1JkTG05d2RHbHZibDh6SUNFOUlDSWlMQ0FpVDNCMGFXOXVJR1J2WlhOdUozUWdaWGhwYzNRZ2FXNGdkR2hwY3lCd2IyeHNJZ29nSUNBZ1lubDBaV05mTUNBdkx5QWljRzlzYkhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWliM2hmYldGd1gzTjBjblZqZENCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TkNBdkx5QXhOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXdkR2x2YmlCa2IyVnpiaWQwSUdWNGFYTjBJR2x1SUhSb2FYTWdjRzlzYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J2Ykd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdjMlZzWmk1aWIzaGZiV0Z3WDNOMGNuVmpkRnR3YjJ4c1gybGtYUzV2Y0hScGIyNWZNMTkyYjNSbGN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNSYmNHOXNiRjlwWkYwdWIzQjBhVzl1WHpOZmRtOTBaWE11Ym1GMGFYWmxJQ3NnTVNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpOaUF2THlBek5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXpOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnYzJWc1ppNWliM2hmYldGd1gzTjBjblZqZEZ0d2IyeHNYMmxrWFM1MmIzUmxjbk11WVhCd1pXNWtLR05oYkd4bGNpa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURZd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0c5c2JGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExsQnZiR3hOWVc1aFoyVnlMblp2ZEdWZmIzQjBhVzl1WHpRb2NHOXNiRjlwWkRvZ1lubDBaWE1zSUdOaGJHeGxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDblp2ZEdWZmIzQjBhVzl1WHpRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalUzTFRVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMmIzUmxYMjl3ZEdsdmJsODBLSE5sYkdZc0lIQnZiR3hmYVdRNklHRnlZelF1VlVsdWREWTBMQ0JqWVd4c1pYSTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1ScFpGOTJiM1JsS0hCdmJHeGZhV1FzSUdOaGJHeGxjaWtzSUNKQmJISmxZV1I1SUhadmRHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWkdsa1gzWnZkR1VLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUhadmRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHOXNiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2hmYldGd1gzTjBjblZqZEZ0d2IyeHNYMmxrWFM1dmNIUnBiMjVmTkNBaFBTQWlJaXdnSWs5d2RHbHZiaUJrYjJWemJpZDBJR1Y0YVhOMElHbHVJSFJvYVhNZ2NHOXNiQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ2Ykd4eklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhPQ0F2THlBeE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBjSFJwYjI0Z1pHOWxjMjRuZENCbGVHbHpkQ0JwYmlCMGFHbHpJSEJ2Ykd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiY0c5c2JGOXBaRjB1YjNCMGFXOXVYelJmZG05MFpYTWdQU0JoY21NMExsVkpiblEyTkNoelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMFczQnZiR3hmYVdSZExtOXdkR2x2Ymw4MFgzWnZkR1Z6TG01aGRHbDJaU0FySURFcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdORFFnTHk4Z05EUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdORFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1IxY0RJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2IyeHNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUhObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNSYmNHOXNiRjlwWkYwdWRtOTBaWEp6TG1Gd2NHVnVaQ2hqWVd4c1pYSXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBMk1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CdmJHeGZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNVFiMnhzVFdGdVlXZGxjaTUyYjNSbFgyOXdkR2x2Ymw4MUtIQnZiR3hmYVdRNklHSjVkR1Z6TENCallXeHNaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3AyYjNSbFgyOXdkR2x2Ymw4MU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8yTkMwMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2RtOTBaVjl2Y0hScGIyNWZOU2h6Wld4bUxDQndiMnhzWDJsa09pQmhjbU0wTGxWSmJuUTJOQ3dnWTJGc2JHVnlPaUJoY21NMExrRmtaSEpsYzNNcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdjMlZzWmk1a2FXUmZkbTkwWlNod2IyeHNYMmxrTENCallXeHNaWElwTENBaVFXeHlaV0ZrZVNCMmIzUmxaQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdScFpGOTJiM1JsQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCMmIzUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNSYmNHOXNiRjlwWkYwdWIzQjBhVzl1WHpVZ0lUMGdJaUlzSUNKUGNIUnBiMjRnWkc5bGMyNG5kQ0JsZUdsemRDQnBiaUIwYUdseklIQnZiR3dpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3YjJ4c2N5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMElHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFNElDOHZJREU0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGNIUnBiMjRnWkc5bGMyNG5kQ0JsZUdsemRDQnBiaUIwYUdseklIQnZiR3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiMnhzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklITmxiR1l1WW05NFgyMWhjRjl6ZEhKMVkzUmJjRzlzYkY5cFpGMHViM0IwYVc5dVh6VmZkbTkwWlhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtSnZlRjl0WVhCZmMzUnlkV04wVzNCdmJHeGZhV1JkTG05d2RHbHZibDgxWDNadmRHVnpMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05USWdMeThnTlRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05USUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiY0c5c2JGOXBaRjB1ZG05MFpYSnpMbUZ3Y0dWdVpDaGpZV3hzWlhJcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ2Ykd4ZmJXRnVZV2RsY2k1amIyNTBjbUZqZEM1UWIyeHNUV0Z1WVdkbGNpNWthV1JmZG05MFpTaHdiMnhzWDJsa09pQmllWFJsY3l3Z1kyRnNiR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwa2FXUmZkbTkwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YjJ4c1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOekV0TnpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdScFpGOTJiM1JsS0hObGJHWXNJSEJ2Ykd4ZmFXUTZJR0Z5WXpRdVZVbHVkRFkwTENCallXeHNaWEk2SUdGeVl6UXVRV1JrY21WemN5a2dMVDRnWW05dmJEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjRzlzYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5Qm1iM1Z1WkNBOUlFWmhiSE5sQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnZiR3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1ptOXlJSFp2ZEdWeUlHbHVJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiY0c5c2JGOXBaRjB1ZG05MFpYSnpPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWljRzlzYkhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBMk1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LWkdsa1gzWnZkR1ZmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnWm05eUlIWnZkR1Z5SUdsdUlITmxiR1l1WW05NFgyMWhjRjl6ZEhKMVkzUmJjRzlzYkY5cFpGMHVkbTkwWlhKek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQThDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpZWlCa2FXUmZkbTkwWlY5aFpuUmxjbDltYjNKQU5nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnYVdZZ1kyRnNiR1Z5SUQwOUlIWnZkR1Z5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lub2daR2xrWDNadmRHVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0c5c2JGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJtYjNWdVpDQTlJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ21ScFpGOTJiM1JsWDJGbWRHVnlYMlp2Y2tBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCdmJHeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnY21WMGRYSnVJR1p2ZFc1a0NpQWdJQ0J5WlhSemRXSUtDbVJwWkY5MmIzUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCaUlHUnBaRjkyYjNSbFgyWnZjbDlvWldGa1pYSkFNUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUUE4SUNZRUJYQnZiR3h6REc1bGVIUmZjRzlzYkY5cFpBSUFBQVFWSDN4MU1SaEFBQXdwZ0FnQUFBQUFBQUFBQVdjeEcwRUE1WUlJQkFLK3poRUVsWFRaZUFSVkFxZWJCRVE0V3VVRXByR2ZZUVFYSUZUYkJObjZ6QzhFaHBKcXVqWWFBSTRJQUlnQWVRQm5BRlVBUXdBeEFCOEFBaU5ETVJrVVJERVlSRFlhQVRZYUFvZ0NnNEFCQUNOUEFsUXJURkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NpQUlKSWtNeEdSUkVNUmhFTmhvQk5ob0NpQUdaSWtNeEdSUkVNUmhFTmhvQk5ob0NpQUVwSWtNeEdSUkVNUmhFTmhvQk5ob0NpQURLSWtNeEdSUkVNUmhFTmhvQk5ob0NpQUJySWtNeEdSUkVNUmhFTmhvQmlBQTdJa014R1JSRU1SaEVOaG9CVndJQWlBQVpTUlVXVndZQ1RGQXJURkN3SWtNeEdVRC9WVEVZRkVRaVE0b0JBWUFIU0dWc2JHOHNJSXYvVUltS0FRQWpLV1ZFaS85TEFWd0FqUDhvU3dGUVNieElpLysvRnlJSUZpbE1aNG1LQWdDTC9vdi9pQUdwRkVRb2kvNVFTYjVFU1lFVVd5SUlGbHdVU3dHOFNFcS9TU1JaU3dFVlN3SkxBazhDVWxjQ0FJdi9VRWtWSlFvV1Z3WUNURkJQQWlOUEExaE1VRXNCdkVpL2lZb0NBSXYraS8rSUFWd1VSQ2lML2xCSnZrUkpnUnhiSWdnV1hCeExBYnhJU3I5SkpGbExBUlZMQWtzQ1R3SlNWd0lBaS85UVNSVWxDaFpYQmdKTVVFOENJMDhEV0V4UVN3RzhTTCtKaWdJQWkvNkwvNGdCRHhSRUtJditVRW0rUkVtQkRsbExBWUVRV1VzQ1RnSlNLaE5FU1lFa1d5SUlGbHdrU3dHOFNFcS9TU1JaU3dFVlN3SkxBazhDVWxjQ0FJdi9VRWtWSlFvV1Z3WUNURkJQQWlOUEExaE1VRXNCdkVpL2lZb0NBSXYraS8rSUFMRVVSQ2lML2xCSnZrUkpnUkJaU3dHQkVsbExBazRDVWlvVFJFbUJMRnNpQ0JaY0xFc0J2RWhLdjBra1dVc0JGVXNDU3dKUEFsSlhBZ0NMLzFCSkZTVUtGbGNHQWt4UVR3SWpUd05ZVEZCTEFieEl2NG1LQWdDTC9vdi9pQUJURkVRb2kvNVFTYjVFU1lFU1dVc0JKRmxMQWs0Q1Vpb1RSRW1CTkZzaUNCWmNORXNCdkVoS3Ywa2tXVXNCRlVzQ1N3SlBBbEpYQWdDTC8xQkpGU1VLRmxjR0FreFFUd0lqVHdOWVRGQkxBYnhJdjRtS0FnR0FBQ01vaS81UXZrUkpKRmxMQVJWU1NTTlpJNHNFaXdNTWl3R01BRUVBRklzQ1Z3SUFpd1FsQ3lWWWkvOFNRUUFFSW93QWlZc0VJZ2lNQkVMLzFnPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
