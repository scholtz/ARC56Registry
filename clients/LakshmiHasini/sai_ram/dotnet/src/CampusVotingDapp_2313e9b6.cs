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

namespace Arc56.Generated.LakshmiHasini.sai_ram.CampusVotingDapp_2313e9b6
{


    //
    // 
    //    Campus Voting DApp Smart Contract
    //    
    //    Supports:
    //    - Poll creation with up to 4 options and a deadline
    //    - One-person-one-vote enforcement via local state
    //    - Optional token-gating (require holding a specific ASA)
    //    - Transparent, tamper-proof vote counting
    //    - Public read methods for results & poll info
    //    
    //
    public class CampusVotingDappProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CampusVotingDappProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetResultsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetResultsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetResultsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetResultsReturn);
                }
                public bool Equals(GetResultsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetResultsReturn left, GetResultsReturn right)
                {
                    return EqualityComparer<GetResultsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetResultsReturn left, GetResultsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetPollInfoReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public string Field2 { get; set; }

                public string Field3 { get; set; }

                public string Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public ulong Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.From(Field4);
                    stringRef[ret.Count] = vField4.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPollInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetPollInfoReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    var indexField4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.Decode(bytes.Skip(indexField4 + prefixOffset).ToArray());
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is string vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPollInfoReturn);
                }
                public bool Equals(GetPollInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPollInfoReturn left, GetPollInfoReturn right)
                {
                    return EqualityComparer<GetPollInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPollInfoReturn left, GetPollInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new poll. Only callable by the app creator.
        ///Returns the poll end timestamp.
        ///</summary>
        /// <param name="question"> </param>
        /// <param name="option_a"> </param>
        /// <param name="option_b"> </param>
        /// <param name="option_c"> </param>
        /// <param name="option_d"> </param>
        /// <param name="num_options"> </param>
        /// <param name="duration_secs"> </param>
        /// <param name="token_id"> </param>
        public async Task<ulong> CreatePoll(string question, string option_a, string option_b, string option_c, string option_d, ulong num_options, ulong duration_secs, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 73, 175, 74 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var option_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_aAbi.From(option_a);
            var option_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_bAbi.From(option_b);
            var option_cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_cAbi.From(option_c);
            var option_dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_dAbi.From(option_d);
            var num_optionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_optionsAbi.From(num_options);
            var duration_secsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secsAbi.From(duration_secs);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            var result = await base.CallApp(new List<object> { abiHandle, questionAbi, option_aAbi, option_bAbi, option_cAbi, option_dAbi, num_optionsAbi, duration_secsAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePoll_Transactions(string question, string option_a, string option_b, string option_c, string option_d, ulong num_options, ulong duration_secs, ulong token_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 73, 175, 74 };
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var option_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_aAbi.From(option_a);
            var option_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_bAbi.From(option_b);
            var option_cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_cAbi.From(option_c);
            var option_dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); option_dAbi.From(option_d);
            var num_optionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); num_optionsAbi.From(num_options);
            var duration_secsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secsAbi.From(duration_secs);
            var token_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_idAbi.From(token_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, questionAbi, option_aAbi, option_bAbi, option_cAbi, option_dAbi, num_optionsAbi, duration_secsAbi, token_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cast a vote. Enforces:
        ///- Poll must be active - Voter must have opted in (has local state) - Voter must not have already voted - Option must be valid - If token_id > 0, sender must hold that ASA
        ///</summary>
        /// <param name="option"> </param>
        public async Task<string> Vote(ulong option, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 178, 151 };
            var optionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); optionAbi.From(option);

            var result = await base.CallApp(new List<object> { abiHandle, optionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Vote_Transactions(ulong option, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 178, 151 };
            var optionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); optionAbi.From(option);

            return await base.MakeTransactionList(new List<object> { abiHandle, optionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return vote counts for all 4 options.
        ///</summary>
        public async Task<Structs.GetResultsReturn> GetResults(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 226, 62, 246 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetResultsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetResults_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 226, 62, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return full poll info:
        ///(question, opt_a, opt_b, opt_c, opt_d, num_options, end_time, token_id, total_votes)
        ///</summary>
        public async Task<Structs.GetPollInfoReturn> GetPollInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 9, 20, 49 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPollInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPollInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 9, 20, 49 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the option a voter chose (0 = hasn't voted).
        ///</summary>
        /// <param name="voter"> </param>
        public async Task<ulong> GetVoterStatus(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 180, 26, 248 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            var result = await base.SimApp(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetVoterStatus_Transactions(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 180, 26, 248 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creator can manually close the poll before the deadline.
        ///</summary>
        public async Task<string> ClosePoll(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 29, 74, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClosePoll_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 29, 74, 92 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FtcHVzVm90aW5nRGFwcCIsImRlc2MiOiJcbiAgICBDYW1wdXMgVm90aW5nIERBcHAgU21hcnQgQ29udHJhY3RcbiAgICBcbiAgICBTdXBwb3J0czpcbiAgICAtIFBvbGwgY3JlYXRpb24gd2l0aCB1cCB0byA0IG9wdGlvbnMgYW5kIGEgZGVhZGxpbmVcbiAgICAtIE9uZS1wZXJzb24tb25lLXZvdGUgZW5mb3JjZW1lbnQgdmlhIGxvY2FsIHN0YXRlXG4gICAgLSBPcHRpb25hbCB0b2tlbi1nYXRpbmcgKHJlcXVpcmUgaG9sZGluZyBhIHNwZWNpZmljIEFTQSlcbiAgICAtIFRyYW5zcGFyZW50LCB0YW1wZXItcHJvb2Ygdm90ZSBjb3VudGluZ1xuICAgIC0gUHVibGljIHJlYWQgbWV0aG9kcyBmb3IgcmVzdWx0cyAmIHBvbGwgaW5mb1xuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRSZXN1bHRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UG9sbEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkOCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX3BvbGwiLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IHBvbGwuIE9ubHkgY2FsbGFibGUgYnkgdGhlIGFwcCBjcmVhdG9yLlxuUmV0dXJucyB0aGUgcG9sbCBlbmQgdGltZXN0YW1wLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWVzdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3B0aW9uX2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wdGlvbl9iIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcHRpb25fYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3B0aW9uX2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bV9vcHRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkdXJhdGlvbl9zZWNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZvdGUiLCJkZXNjIjoiQ2FzdCBhIHZvdGUuIEVuZm9yY2VzOlxuLSBQb2xsIG11c3QgYmUgYWN0aXZlIC0gVm90ZXIgbXVzdCBoYXZlIG9wdGVkIGluIChoYXMgbG9jYWwgc3RhdGUpIC0gVm90ZXIgbXVzdCBub3QgaGF2ZSBhbHJlYWR5IHZvdGVkIC0gT3B0aW9uIG11c3QgYmUgdmFsaWQgLSBJZiB0b2tlbl9pZCA+IDAsIHNlbmRlciBtdXN0IGhvbGQgdGhhdCBBU0EiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3B0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Jlc3VsdHMiLCJkZXNjIjoiUmV0dXJuIHZvdGUgY291bnRzIGZvciBhbGwgNCBvcHRpb25zLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFJlc3VsdHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb2xsX2luZm8iLCJkZXNjIjoiUmV0dXJuIGZ1bGwgcG9sbCBpbmZvOlxuKHF1ZXN0aW9uLCBvcHRfYSwgb3B0X2IsIG9wdF9jLCBvcHRfZCwgbnVtX29wdGlvbnMsIGVuZF90aW1lLCB0b2tlbl9pZCwgdG90YWxfdm90ZXMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRQb2xsSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZvdGVyX3N0YXR1cyIsImRlc2MiOiJSZXR1cm4gdGhlIG9wdGlvbiBhIHZvdGVyIGNob3NlICgwID0gaGFzbid0IHZvdGVkKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbG9zZV9wb2xsIiwiZGVzYyI6IkNyZWF0b3IgY2FuIG1hbnVhbGx5IGNsb3NlIHRoZSBwb2xsIGJlZm9yZSB0aGUgZGVhZGxpbmUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjksImJ5dGVzIjo2fSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk9wdEluIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTU5XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSB2b3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6IkR1cmF0aW9uIG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzhdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgY2FtcHVzIHRva2VuIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTBdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIG9wdGlvbiBudW1iZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjldLCJlcnJvck1lc3NhZ2UiOiJNYXhpbXVtIDQgb3B0aW9ucyBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc3XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBob2xkIGNhbXB1cyB0b2tlbiB0byB2b3RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIzXSwiZXJyb3JNZXNzYWdlIjoiTmVlZCBhdCBsZWFzdCAyIG9wdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzJdLCJlcnJvck1lc3NhZ2UiOiJObyBhY3RpdmUgcG9sbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gY2xvc2UgcG9sbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gY3JlYXRlIHBvbGxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQzXSwiZXJyb3JNZXNzYWdlIjoiT3B0aW9uIG11c3QgYmUgMS00IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQxXSwiZXJyb3JNZXNzYWdlIjoiUG9sbCBoYXMgZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDYsNTM5LDgxNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZW5kX3RpbWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5oYXNfdm90ZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ4LDgwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubnVtX29wdGlvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcHRpb25fYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9wdGlvbl9iIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3B0aW9uX2MgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcHRpb25fZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBvbGxfYWN0aXZlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucXVlc3Rpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY0LDU3NCw4MjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNyw4MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3ZvdGVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5Nyw3MDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGVzX2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYwLDcxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90ZXNfYiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzksNzE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52b3Rlc19jIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5Miw3MjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGVzX2QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzExLDMyNywzNDMsMzU5LDM3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOCwzMzQsMzUwLDM2NiwzODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Myw0MDIsNDExLDUyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNJaUlDSjJiM1JsYzE5aElpQWlkbTkwWlhOZllpSWdJblp2ZEdWelgyTWlJQ0oyYjNSbGMxOWtJaUFpWlc1a1gzUnBiV1VpSUNKMGIydGxibDlwWkNJZ0luUnZkR0ZzWDNadmRHVnpJaUFpYm5WdFgyOXdkR2x2Ym5NaUlDSndiMnhzWDJGamRHbDJaU0lnSW1oMklpQXdlREUxTVdZM1l6YzFJQ0p4ZFdWemRHbHZiaUlnSW05d2RHbHZibDloSWlBaWIzQjBhVzl1WDJJaUlDSnZjSFJwYjI1Zll5SWdJbTl3ZEdsdmJsOWtJaUFpWTNKbFlYUnZjaUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJSE5sYkdZdWNYVmxjM1JwYjI0Z1BTQlRkSEpwYm1jb0lpSXBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWljWFZsYzNScGIyNGlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnYzJWc1ppNXZjSFJwYjI1ZllTQTlJRk4wY21sdVp5Z2lJaWtLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p2Y0hScGIyNWZZU0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCelpXeG1MbTl3ZEdsdmJsOWlJRDBnVTNSeWFXNW5LQ0lpS1FvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW05d2RHbHZibDlpSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklITmxiR1l1YjNCMGFXOXVYMk1nUFNCVGRISnBibWNvSWlJcENpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWIzQjBhVzl1WDJNaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdjMlZzWmk1dmNIUnBiMjVmWkNBOUlGTjBjbWx1WnlnaUlpa0tJQ0FnSUdKNWRHVmpJREUySUM4dklDSnZjSFJwYjI1ZlpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJ6Wld4bUxtNTFiVjl2Y0hScGIyNXpJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p1ZFcxZmIzQjBhVzl1Y3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2MyVnNaaTUyYjNSbGMxOWhJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oyYjNSbGMxOWhJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJ6Wld4bUxuWnZkR1Z6WDJJZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luWnZkR1Z6WDJJaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklITmxiR1l1ZG05MFpYTmZZeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZG05MFpYTmZZeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNTJiM1JsYzE5a0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjJiM1JsYzE5a0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG1WdVpGOTBhVzFsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbGJtUmZkR2x0WlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z2MyVnNaaTVqY21WaGRHOXlJRDBnWVhKak5DNUJaR1J5WlhOektFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXBDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNWZhV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmEyVnVYMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzWnZkR1Z6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRjkyYjNSbGN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdjMlZzWmk1d2IyeHNYMkZqZEdsMlpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWljRzlzYkY5aFkzUnBkbVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnRjSFZ6Vm05MGFXNW5SR0Z3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREUxQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsWmpRNVlXWTBZU0F3ZUdZeE5EbGlNamszSURCNFpERmxNak5sWmpZZ01IZzJNakE1TVRRek1TQXdlR1kwWWpReFlXWTRJREI0WW1NeFpEUmhOV01nTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmY0c5c2JDaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkbTkwWlNoMWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZmNtVnpkV3gwY3lncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5d2IyeHNYMmx1Wm04b0tTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5MmIzUmxjbDl6ZEdGMGRYTW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTnNiM05sWDNCdmJHd29LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpWOXdiMnhzSUhadmRHVWdaMlYwWDNKbGMzVnNkSE1nWjJWMFgzQnZiR3hmYVc1bWJ5Qm5aWFJmZG05MFpYSmZjM1JoZEhWeklHTnNiM05sWDNCdmJHd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFNENpQWdJQ0F2THlCamJHRnpjeUJEWVcxd2RYTldiM1JwYm1kRVlYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQybDBZMmdnYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5pQnRZV2x1WDI5d2RGOXBia0F4TndvZ0lDQWdaWEp5Q2dwdFlXbHVYMjl3ZEY5cGJrQXhOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUVCaVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkS1FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnYzJWc1ppNW9ZWE5mZG05MFpXUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pvZGlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pZNENpQWdJQ0F2THlCQVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFk2Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzVqYjI1MGNtRmpkQzVEWVcxd2RYTldiM1JwYm1kRVlYQndMbU55WldGMFpWOXdiMnhzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDNCdmJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdZM0psWVhSbElIQnZiR3h6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnWTNKbFlYUmxJSEJ2Ykd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QmhjM05sY25RZ2JuVnRYMjl3ZEdsdmJuTWdQajBnVlVsdWREWTBLRElwTENBaVRtVmxaQ0JoZENCc1pXRnpkQ0F5SUc5d2RHbHZibk1pQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtVmxaQ0JoZENCc1pXRnpkQ0F5SUc5d2RHbHZibk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUdGemMyVnlkQ0J1ZFcxZmIzQjBhVzl1Y3lBOFBTQlZTVzUwTmpRb05Da3NJQ0pOWVhocGJYVnRJRFFnYjNCMGFXOXVjeUJoYkd4dmQyVmtJZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhocGJYVnRJRFFnYjNCMGFXOXVjeUJoYkd4dmQyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJoYzNObGNuUWdaSFZ5WVhScGIyNWZjMlZqY3lBK0lGVkpiblEyTkNnd0tTd2dJa1IxY21GMGFXOXVJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFUjFjbUYwYVc5dUlHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklITmxiR1l1Y1hWbGMzUnBiMjRnUFNCeGRXVnpkR2x2YmdvZ0lDQWdZbmwwWldNZ01USWdMeThnSW5GMVpYTjBhVzl1SWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnYzJWc1ppNXZjSFJwYjI1ZllTQTlJRzl3ZEdsdmJsOWhDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWliM0IwYVc5dVgyRWlDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QnpaV3htTG05d2RHbHZibDlpSUQwZ2IzQjBhVzl1WDJJS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKdmNIUnBiMjVmWWlJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUhObGJHWXViM0IwYVc5dVgyTWdQU0J2Y0hScGIyNWZZd29nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbTl3ZEdsdmJsOWpJZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdjMlZzWmk1dmNIUnBiMjVmWkNBOUlHOXdkR2x2Ymw5a0NpQWdJQ0JpZVhSbFl5QXhOaUF2THlBaWIzQjBhVzl1WDJRaUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCelpXeG1MbTUxYlY5dmNIUnBiMjV6SUQwZ2JuVnRYMjl3ZEdsdmJuTUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltNTFiVjl2Y0hScGIyNXpJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJSE5sYkdZdWRtOTBaWE5mWVNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRtOTBaWE5mWVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklITmxiR1l1ZG05MFpYTmZZaUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZG05MFpYTmZZaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TURJS0lDQWdJQzh2SUhObGJHWXVkbTkwWlhOZll5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkbTkwWlhOZll5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJSE5sYkdZdWRtOTBaWE5mWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRtOTBaWE5mWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklITmxiR1l1Wlc1a1gzUnBiV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUdSMWNtRjBhVzl1WDNObFkzTUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1lubDBaV01nTlNBdkx5QWlaVzVrWDNScGJXVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUhObGJHWXVZM0psWVhSdmNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpLUW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYzJWc1ppNTBiMnRsYmw5cFpDQTlJSFJ2YTJWdVgybGtDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMnRsYmw5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5MmIzUmxjeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5MFlXeGZkbTkwWlhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QnpaV3htTG5CdmJHeGZZV04wYVhabElEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSndiMnhzWDJGamRHbDJaU0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtVnVaRjkwYVcxbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWlc1a1gzUnBiV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpXNWtYM1JwYldVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M1amIyNTBjbUZqZEM1RFlXMXdkWE5XYjNScGJtZEVZWEJ3TG5admRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyYjNSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y0c5c2JGOWhZM1JwZG1VZ1BUMGdWVWx1ZERZMEtERXBMQ0FpVG04Z1lXTjBhWFpsSUhCdmJHd2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNHOXNiRjloWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0c5c2JGOWhZM1JwZG1VZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmhZM1JwZG1VZ2NHOXNiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQThJSE5sYkdZdVpXNWtYM1JwYldVc0lDSlFiMnhzSUdoaGN5QmxibVJsWkNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0psYm1SZmRHbHRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGJtUmZkR2x0WlNCbGVHbHpkSE1LSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCUWIyeHNJR2hoY3lCbGJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0hScGIyNGdQajBnVlVsdWREWTBLREVwTENBaVQzQjBhVzl1SUcxMWMzUWdZbVVnTVMwMElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVDNCMGFXOXVJRzExYzNRZ1ltVWdNUzAwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d2RHbHZiaUE4UFNCelpXeG1MbTUxYlY5dmNIUnBiMjV6TENBaVNXNTJZV3hwWkNCdmNIUnBiMjRnYm5WdFltVnlJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltNTFiVjl2Y0hScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01MWJWOXZjSFJwYjI1eklHVjRhWE4wY3dvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHOXdkR2x2YmlCdWRXMWlaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRJM0xURXlPQW9nSUNBZ0x5OGdJeUJEYUdWamF5QjJiM1JsY2lCb1lYTnVKM1FnWVd4eVpXRmtlU0IyYjNSbFpDQW9iRzlqWVd3Z2MzUmhkR1VwQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM1p2ZEdVZ1BTQnpaV3htTG1oaGMxOTJiM1JsWkZ0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pvZGlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtaGhjMTkyYjNSbFpDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZM1Z5Y21WdWRGOTJiM1JsSUQwOUlGVkpiblEyTkNnd0tTd2dJa0ZzY21WaFpIa2dkbTkwWldRaUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV3h5WldGa2VTQjJiM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE16RXRNVE15Q2lBZ0lDQXZMeUFqSUZSdmEyVnVMV2RoZEdsdVp5QmphR1ZqYXpvZ2FXWWdkRzlyWlc1ZmFXUWdQaUF3TENCeVpYRjFhWEpsSUVGVFFTQmlZV3hoYm1ObElENDlJREVLSUNBZ0lDOHZJR2xtSUhObGJHWXVkRzlyWlc1ZmFXUWdQaUJWU1c1ME5qUW9NQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzlyWlc1ZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5clpXNWZhV1FnWlhocGMzUnpDaUFnSUNCaWVpQjJiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TXpRS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJc0lITmxiR1l1ZEc5clpXNWZhV1FLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIydGxibDlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UTXpMVEV6TlFvZ0lDQWdMeThnWVhOelpYUmZZbUZzWVc1alpTd2dZWE56WlhSZlpYaHBjM1J6SUQwZ2IzQXVRWE56WlhSSWIyeGthVzVuUjJWMExtRnpjMlYwWDJKaGJHRnVZMlVvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpd2djMlZzWmk1MGIydGxibDlwWkFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBYMlY0YVhOMGN5d2dJazExYzNRZ2FHOXNaQ0JqWVcxd2RYTWdkRzlyWlc0Z2RHOGdkbTkwWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElHaHZiR1FnWTJGdGNIVnpJSFJ2YTJWdUlIUnZJSFp2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFJmWW1Gc1lXNWpaU0ErUFNCVlNXNTBOalFvTVNrc0lDSkpibk4xWm1acFkybGxiblFnWTJGdGNIVnpJSFJ2YTJWdUlHSmhiR0Z1WTJVaUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHTmhiWEIxY3lCMGIydGxiaUJpWVd4aGJtTmxDZ3AyYjNSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UTTVMVEUwTUFvZ0lDQWdMeThnSXlCU1pXTnZjbVFnZG05MFpTQnBiaUJzYjJOaGJDQnpkR0YwWlFvZ0lDQWdMeThnYzJWc1ppNW9ZWE5mZG05MFpXUmJWSGh1TG5ObGJtUmxjbDBnUFNCdmNIUnBiMjRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSm9kaUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UUXlMVEUwTXdvZ0lDQWdMeThnSXlCVVlXeHNlU0IyYjNSbENpQWdJQ0F2THlCcFppQnZjSFJwYjI0Z1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCMmIzUmxYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z2MyVnNaaTUyYjNSbGMxOWhJRDBnYzJWc1ppNTJiM1JsYzE5aElDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRtOTBaWE5mWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JsYzE5aElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luWnZkR1Z6WDJFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tkbTkwWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oYlhCMWMxOTJiM1JwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE5USUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZkbTkwWlhNZ1BTQnpaV3htTG5SdmRHRnNYM1p2ZEdWeklDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hmZG05MFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZkbTkwWlhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOTBZV3hmZG05MFpYTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TVRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ERmhOVFkyWmpjME5qVXlNRGN5TmpVMk16Wm1OekkyTkRZMU5qUXlNRGN6TnpVMk16WXpOalUzTXpjek5qWTNOVFpqTm1NM09Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDJiM1JsWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJR1ZzYVdZZ2IzQjBhVzl1SUQwOUlGVkpiblEyTkNneUtUb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmllaUIyYjNSbFgyVnNjMlZmWW05a2VVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnYzJWc1ppNTJiM1JsYzE5aUlEMGdjMlZzWmk1MmIzUmxjMTlpSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZG05MFpYTmZZaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MmIzUmxjMTlpSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5admRHVnpYMklpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZaUIyYjNSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NuWnZkR1ZmWld4elpWOWliMlI1UURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdaV3hwWmlCdmNIUnBiMjRnUFQwZ1ZVbHVkRFkwS0RNcE9nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEMDlDaUFnSUNCaWVpQjJiM1JsWDJWc2MyVmZZbTlrZVVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdjMlZzWmk1MmIzUmxjMTlqSUQwZ2MyVnNaaTUyYjNSbGMxOWpJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkbTkwWlhOZll5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyYjNSbGMxOWpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblp2ZEdWelgyTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lpQjJiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ25admRHVmZaV3h6WlY5aWIyUjVRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZ0Y0hWelgzWnZkR2x1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFMU1Bb2dJQ0FnTHk4Z2MyVnNaaTUyYjNSbGMxOWtJRDBnYzJWc1ppNTJiM1JsYzE5a0lDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRtOTBaWE5mWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JsYzE5a0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luWnZkR1Z6WDJRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWWlCMmIzUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TG1OdmJuUnlZV04wTGtOaGJYQjFjMVp2ZEdsdVowUmhjSEF1WjJWMFgzSmxjM1ZzZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY21WemRXeDBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5admRHVnpYMkVwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblp2ZEdWelgyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MFpYTmZZU0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1Mblp2ZEdWelgySXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luWnZkR1Z6WDJJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkbTkwWlhOZllpQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuWnZkR1Z6WDJNcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5admRHVnpYMk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBaWE5mWXlCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5admRHVnpYMlFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblp2ZEdWelgyUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MFpYTmZaQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVFU1TFRFMk5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkbTkwWlhOZllTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUyYjNSbGMxOWlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5admRHVnpYMk1wTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRtOTBaWE5mWkNrc0NpQWdJQ0F2THlBcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDNWpiMjUwY21GamRDNURZVzF3ZFhOV2IzUnBibWRFWVhCd0xtZGxkRjl3YjJ4c1gybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjRzlzYkY5cGJtWnZPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94T0RNS0lDQWdJQzh2SUdGeVl6UXVVM1J5YVc1bktITmxiR1l1Y1hWbGMzUnBiMjRwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p4ZFdWemRHbHZiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eGRXVnpkR2x2YmlCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnWVhKak5DNVRkSEpwYm1jb2MyVnNaaTV2Y0hScGIyNWZZU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbTl3ZEdsdmJsOWhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05d2RHbHZibDloSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGcxQ2lBZ0lDQXZMeUJoY21NMExsTjBjbWx1WnloelpXeG1MbTl3ZEdsdmJsOWlLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWliM0IwYVc5dVgySWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNCMGFXOXVYMklnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaGJYQjFjMTkyYjNScGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJR0Z5WXpRdVUzUnlhVzVuS0hObGJHWXViM0IwYVc5dVgyTXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSnZjSFJwYjI1Zll5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y0hScGIyNWZZeUJsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTROd29nSUNBZ0x5OGdZWEpqTkM1VGRISnBibWNvYzJWc1ppNXZjSFJwYjI1ZlpDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0ltOXdkR2x2Ymw5a0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTl3ZEdsdmJsOWtJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UZzRDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtNTFiVjl2Y0hScGIyNXpLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnVkVzFmYjNCMGFXOXVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dWRXMWZiM0IwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtVnVaRjkwYVcxbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbGJtUmZkR2x0WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxibVJmZEdsdFpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZhMlZ1WDJsa0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIydGxibDlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5cFpDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1Ua3hDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNadmRHVnpLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkY5MmIzUmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjkyYjNSbGN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UZ3lMVEU1TWdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0FvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VTNSeWFXNW5LSE5sYkdZdWNYVmxjM1JwYjI0cExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVUzUnlhVzVuS0hObGJHWXViM0IwYVc5dVgyRXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktITmxiR1l1YjNCMGFXOXVYMklwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VTNSeWFXNW5LSE5sYkdZdWIzQjBhVzl1WDJNcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVUzUnlhVzVuS0hObGJHWXViM0IwYVc5dVgyUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Ym5WdFgyOXdkR2x2Ym5NcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVaVzVrWDNScGJXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5clpXNWZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmZG05MFpYTXBMQW9nSUNBZ0x5OGdLU2tLSUNBZ0lHUnBaeUE0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TW1FS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEa0tJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURnS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpZVzF3ZFhOZmRtOTBhVzVuWDJSaGNIQXVZMjl1ZEhKaFkzUXVRMkZ0Y0hWelZtOTBhVzVuUkdGd2NDNW5aWFJmZG05MFpYSmZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNadmRHVnlYM04wWVhSMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXMXdkWE5mZG05MGFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGswQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdWFHRnpYM1p2ZEdWa0xtZGxkQ2gyYjNSbGNpNXVZWFJwZG1Vc0lHUmxabUYxYkhROVZVbHVkRFkwS0RBcEtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWFIWWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTVOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTJGdGNIVnpYM1p2ZEdsdVoxOWtZWEJ3TG1OdmJuUnlZV04wTGtOaGJYQjFjMVp2ZEdsdVowUmhjSEF1WTJ4dmMyVmZjRzlzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNiM05sWDNCdmJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRnRjSFZ6WDNadmRHbHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakl3TWdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnWTJ4dmMyVWdjRzlzYkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdOc2IzTmxJSEJ2Ykd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVcxd2RYTmZkbTkwYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QnpaV3htTG5CdmJHeGZZV04wYVhabElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSndiMnhzWDJGamRHbDJaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhiWEIxYzE5MmIzUnBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94T1RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQmlOVEEyWmpaak5tTXlNRFl6Tm1NMlpqY3pOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZU0FBZDJiM1JsYzE5aEIzWnZkR1Z6WDJJSGRtOTBaWE5mWXdkMmIzUmxjMTlrQ0dWdVpGOTBhVzFsQ0hSdmEyVnVYMmxrQzNSdmRHRnNYM1p2ZEdWekMyNTFiVjl2Y0hScGIyNXpDM0J2Ykd4ZllXTjBhWFpsQW1oMkJCVWZmSFVJY1hWbGMzUnBiMjRJYjNCMGFXOXVYMkVJYjNCMGFXOXVYMklJYjNCMGFXOXVYMk1JYjNCMGFXOXVYMlFIWTNKbFlYUnZjakVZUUFBNkp3d29aeWNOS0djbkRpaG5KdzhvWnljUUtHY25DQ0puS1NKbktpSm5LeUpuSndRaVp5Y0ZJbWNuRVRJRFp5Y0dJbWNuQnlKbkp3a2laekViUVFBNU1Sa1VSREVZUklJR0JPOUpyMG9FOFVteWx3VFI0ajcyQkdJSkZERUU5TFFhK0FTOEhVcGNOaG9BamdZQUdRRHFBYVVCeXdKK0FwY0FNUm1OQWdBTUFBRUFNUmhFTVFBbkNpSm1JME14R0JSRE5ob0JTU0paSkFoTEFSVVNSRmNDQURZYUFra2lXU1FJU3dFVkVrUlhBZ0EyR2dOSklsa2tDRXNCRlJKRVZ3SUFOaG9FU1NKWkpBaExBUlVTUkZjQ0FEWWFCVWtpV1NRSVN3RVZFa1JYQWdBMkdnWkpGU1VTUkJjMkdnZEpGU1VTUkJjMkdnaEpGU1VTUkJjeEFESUpFa1JMQWlRUFJFc0NnUVFPUkVzQlJDY01Ud2huSncxUEIyY25EazhHWnljUFR3Vm5KeEJQQkdjbkNFOERaeWtpWnlvaVp5c2laeWNFSW1jeUIwOENDQ2NGVEdjbkVUSUpaeWNHVEdjbkJ5Sm5Kd2tqWnlJbkJXVkVGaWNMVEZDd0kwTTJHZ0ZKRlNVU1JCZEpJaWNKWlVRakVrUXlCeUluQldWRURFUkpSQ0luQ0dWRURrUXhBQ0luQ21ORUZFUWlKd1psUkVFQUN6RUFJaWNHWlVSd0FFUkVNUUFuQ2tzQ1NVNERaaU1TUVFBNUlpbGxSQ01JS1V4bklpY0haVVFqQ0NjSFRHZUFJQlVmZkhVQUdsWnZkR1VnY21WamIzSmtaV1FnYzNWalkyVnpjMloxYkd4NXNDTkRTU1FTUVFBTUlpcGxSQ01JS2t4blF2KytTWUVERWtFQURDSXJaVVFqQ0N0TVowTC9xeUluQkdWRUl3Z25CRXhuUXYrZElpbGxSQllpS21WRUZpSXJaVVFXSWljRVpVUVdUd05QQTFCUEFsQk1VQ2NMVEZDd0kwTWlKd3hsUkVrVkZsY0dBa3hRSWljTlpVUkpGUlpYQmdKTVVDSW5EbVZFU1JVV1Z3WUNURkFpSnc5bFJFa1ZGbGNHQWt4UUlpY1FaVVJKRlJaWEJnSk1VQ0luQ0dWRUZpSW5CV1ZFRmlJbkJtVkVGaUluQjJWRUZrc0lGWUVxQ0VrV1Z3WUNnQUlBS2t4UVN3a1ZUd0lJU1JaWEJnSlBBa3hRU3dnVlR3SUlTUlpYQmdKUEFreFFTd2NWVHdJSUZsY0dBbEJQQkZCUEExQlBBbEJNVUU4RlVFOEVVRThEVUU4Q1VFeFFKd3RNVUxBalF6WWFBVWtWZ1NBU1JDSW5DbU1pVGdKTkZpY0xURkN3STBNeEFESUpFa1FuQ1NKbmdCRVZIM3gxQUF0UWIyeHNJR05zYjNObFpMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
