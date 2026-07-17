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

namespace Arc56.Generated.Prajjwaldevops.ALgoRand_Frontend.BountyEscrow_e42785bd
{


    //
    // 
    //    ARC4-compliant Bounty Escrow Smart Contract — v3.3
    //
    //    The contract App Account IS the escrow.
    //    ALGO flows:
    //      Creator → App Account (via grouped Payment + create_bounty)
    //      App Account → Freelancer (approve_payout or resolve_dao_dispute freelancer win)
    //      App Account → Creator (reject all, let_go_bounty, dao tie/creator win,
    //                              refund_expired, cancel_bounty)
    //    
    //
    public class BountyEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BountyEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetBountyInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetBountyInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBountyInfoReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBountyInfoReturn);
                }
                public bool Equals(GetBountyInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBountyInfoReturn left, GetBountyInfoReturn right)
                {
                    return EqualityComparer<GetBountyInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBountyInfoReturn left, GetBountyInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetVoterStatusReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetVoterStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetVoterStatusReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetVoterStatusReturn);
                }
                public bool Equals(GetVoterStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetVoterStatusReturn left, GetVoterStatusReturn right)
                {
                    return EqualityComparer<GetVoterStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetVoterStatusReturn left, GetVoterStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new bounty with locked ALGO reward.
        ///Atomic group: Payment(→ app_address) + ApplicationCall(create_bounty).
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="deadline"> </param>
        /// <param name="max_submissions"> </param>
        public async Task<string> CreateBounty(PaymentTransaction payment, ulong deadline, ulong max_submissions, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 249, 59, 227, 253 };
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var max_submissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_submissionsAbi.From(max_submissions);

            var result = await base.CallApp(new List<object> { abiHandle, payment, deadlineAbi, max_submissionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateBounty_Transactions(PaymentTransaction payment, ulong deadline, ulong max_submissions, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 249, 59, 227, 253 };
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var max_submissionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_submissionsAbi.From(max_submissions);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, deadlineAbi, max_submissionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Initialize local state for a user (freelancers/voters).
        ///</summary>
        public async Task<string> OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 34, 56, 242 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 34, 56, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit work proof. work_hash = SHA256(mega_nz_link + key).
        ///mega_link_hash = SHA256(mega_nz_link).
        ///</summary>
        /// <param name="work_hash"> </param>
        /// <param name="mega_link_hash"> </param>
        public async Task<string> SubmitProof(byte[] work_hash, byte[] mega_link_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 245, 101, 242 };
            var work_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); work_hashAbi.From(work_hash);
            var mega_link_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); mega_link_hashAbi.From(mega_link_hash);

            var result = await base.CallApp(new List<object> { abiHandle, work_hashAbi, mega_link_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SubmitProof_Transactions(byte[] work_hash, byte[] mega_link_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 245, 101, 242 };
            var work_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); work_hashAbi.From(work_hash);
            var mega_link_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); mega_link_hashAbi.From(mega_link_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, work_hashAbi, mega_link_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creator approves work → ALGO payout via InnerTransaction.
        ///</summary>
        /// <param name="freelancer"> </param>
        public async Task<string> ApprovePayout(Algorand.Address freelancer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 25, 84, 167 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);

            var result = await base.CallApp(new List<object> { abiHandle, freelancerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ApprovePayout_Transactions(Algorand.Address freelancer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 25, 84, 167 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);

            return await base.MakeTransactionList(new List<object> { abiHandle, freelancerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creator rejects a submission. Decrements submissions_remaining.
        ///remaining > 0: resets worker to NONE (allows resubmission). remaining == 0: sets EXPIRED status.
        ///</summary>
        /// <param name="freelancer"> </param>
        public async Task<string> RejectSubmission(Algorand.Address freelancer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 231, 103, 200 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);

            var result = await base.CallApp(new List<object> { abiHandle, freelancerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RejectSubmission_Transactions(Algorand.Address freelancer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 231, 103, 200 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);

            return await base.MakeTransactionList(new List<object> { abiHandle, freelancerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer raises dispute after all rejections exhausted. DAO Court 48hr.
        ///</summary>
        public async Task<string> InitiateDispute(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 254, 154, 202 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InitiateDispute_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 254, 154, 202 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Vote in DAO court. vote_for: 1=creator, 2=freelancer.
        ///</summary>
        /// <param name="vote_for"> </param>
        public async Task<string> CastDaoVote(ulong vote_for, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 68, 169, 222 };
            var vote_forAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_forAbi.From(vote_for);

            var result = await base.CallApp(new List<object> { abiHandle, vote_forAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CastDaoVote_Transactions(ulong vote_for, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 68, 169, 222 };
            var vote_forAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_forAbi.From(vote_for);

            return await base.MakeTransactionList(new List<object> { abiHandle, vote_forAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Permissionless after dao_deadline.
        ///freelancer votes > creator → pay freelancer. tie or creator wins → refund creator.
        ///</summary>
        public async Task<string> ResolveDaoDispute(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 134, 41, 177 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ResolveDaoDispute_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 134, 41, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer forfeits claim. Refunds creator.
        ///</summary>
        public async Task<string> LetGoBounty(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 214, 75, 23 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> LetGoBounty_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 214, 75, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Permissionless refund if deadline passed and bounty OPEN/IN_PROGRESS.
        ///</summary>
        public async Task<string> RefundExpired(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 47, 232, 163 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RefundExpired_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 47, 232, 163 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creator cancels bounty before any submissions.
        ///</summary>
        public async Task<string> CancelBounty(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 152, 45, 170 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CancelBounty_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 152, 45, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get full bounty state — used by frontend.
        ///</summary>
        public async Task<Structs.GetBountyInfoReturn> GetBountyInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 244, 252, 136 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBountyInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBountyInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 244, 252, 136 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a voter's DAO vote status.
        ///</summary>
        /// <param name="voter"> </param>
        public async Task<Structs.GetVoterStatusReturn> GetVoterStatus(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 117, 10, 12 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            var result = await base.SimApp(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoterStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVoterStatus_Transactions(Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 117, 10, 12 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a worker's submission state.
        ///</summary>
        /// <param name="worker"> </param>
        public async Task<Structs.GetVoterStatusReturn> GetWorkerInfo(Algorand.Address worker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 43, 94, 68 };
            var workerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); workerAbi.From(worker);

            var result = await base.SimApp(new List<object> { abiHandle, workerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoterStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetWorkerInfo_Transactions(Algorand.Address worker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 43, 94, 68 };
            var workerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); workerAbi.From(worker);

            return await base.MakeTransactionList(new List<object> { abiHandle, workerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm91bnR5RXNjcm93IiwiZGVzYyI6IlxuICAgIEFSQzQtY29tcGxpYW50IEJvdW50eSBFc2Nyb3cgU21hcnQgQ29udHJhY3Qg4oCUIHYzLjNcblxuICAgIFRoZSBjb250cmFjdCBBcHAgQWNjb3VudCBJUyB0aGUgZXNjcm93LlxuICAgIEFMR08gZmxvd3M6XG4gICAgICBDcmVhdG9yIOKGkiBBcHAgQWNjb3VudCAodmlhIGdyb3VwZWQgUGF5bWVudCArIGNyZWF0ZV9ib3VudHkpXG4gICAgICBBcHAgQWNjb3VudCDihpIgRnJlZWxhbmNlciAoYXBwcm92ZV9wYXlvdXQgb3IgcmVzb2x2ZV9kYW9fZGlzcHV0ZSBmcmVlbGFuY2VyIHdpbilcbiAgICAgIEFwcCBBY2NvdW50IOKGkiBDcmVhdG9yIChyZWplY3QgYWxsLCBsZXRfZ29fYm91bnR5LCBkYW8gdGllL2NyZWF0b3Igd2luLFxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgcmVmdW5kX2V4cGlyZWQsIGNhbmNlbF9ib3VudHkpXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldEJvdW50eUluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0Vm90ZXJTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYm91bnR5IiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBib3VudHkgd2l0aCBsb2NrZWQgQUxHTyByZXdhcmQuXG5BdG9taWMgZ3JvdXA6IFBheW1lbnQo4oaSIGFwcF9hZGRyZXNzKSArIEFwcGxpY2F0aW9uQ2FsbChjcmVhdGVfYm91bnR5KS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heF9zdWJtaXNzaW9ucyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOiJJbml0aWFsaXplIGxvY2FsIHN0YXRlIGZvciBhIHVzZXIgKGZyZWVsYW5jZXJzL3ZvdGVycykuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9wcm9vZiIsImRlc2MiOiJTdWJtaXQgd29yayBwcm9vZi4gd29ya19oYXNoID0gU0hBMjU2KG1lZ2FfbnpfbGluayArIGtleSkuXG5tZWdhX2xpbmtfaGFzaCA9IFNIQTI1NihtZWdhX256X2xpbmspLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3b3JrX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lZ2FfbGlua19oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZV9wYXlvdXQiLCJkZXNjIjoiQ3JlYXRvciBhcHByb3ZlcyB3b3JrIOKGkiBBTEdPIHBheW91dCB2aWEgSW5uZXJUcmFuc2FjdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyZWVsYW5jZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3Rfc3VibWlzc2lvbiIsImRlc2MiOiJDcmVhdG9yIHJlamVjdHMgYSBzdWJtaXNzaW9uLiBEZWNyZW1lbnRzIHN1Ym1pc3Npb25zX3JlbWFpbmluZy5cbnJlbWFpbmluZyA+IDA6IHJlc2V0cyB3b3JrZXIgdG8gTk9ORSAoYWxsb3dzIHJlc3VibWlzc2lvbikuIHJlbWFpbmluZyA9PSAwOiBzZXRzIEVYUElSRUQgc3RhdHVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJlZWxhbmNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRpYXRlX2Rpc3B1dGUiLCJkZXNjIjoiRnJlZWxhbmNlciByYWlzZXMgZGlzcHV0ZSBhZnRlciBhbGwgcmVqZWN0aW9ucyBleGhhdXN0ZWQuIERBTyBDb3VydCA0OGhyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhc3RfZGFvX3ZvdGUiLCJkZXNjIjoiVm90ZSBpbiBEQU8gY291cnQuIHZvdGVfZm9yOiAxPWNyZWF0b3IsIDI9ZnJlZWxhbmNlci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZV9mb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2Rhb19kaXNwdXRlIiwiZGVzYyI6IlBlcm1pc3Npb25sZXNzIGFmdGVyIGRhb19kZWFkbGluZS5cbmZyZWVsYW5jZXIgdm90ZXMgPiBjcmVhdG9yIOKGkiBwYXkgZnJlZWxhbmNlci4gdGllIG9yIGNyZWF0b3Igd2lucyDihpIgcmVmdW5kIGNyZWF0b3IuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGV0X2dvX2JvdW50eSIsImRlc2MiOiJGcmVlbGFuY2VyIGZvcmZlaXRzIGNsYWltLiBSZWZ1bmRzIGNyZWF0b3IuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kX2V4cGlyZWQiLCJkZXNjIjoiUGVybWlzc2lvbmxlc3MgcmVmdW5kIGlmIGRlYWRsaW5lIHBhc3NlZCBhbmQgYm91bnR5IE9QRU4vSU5fUFJPR1JFU1MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsX2JvdW50eSIsImRlc2MiOiJDcmVhdG9yIGNhbmNlbHMgYm91bnR5IGJlZm9yZSBhbnkgc3VibWlzc2lvbnMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JvdW50eV9pbmZvIiwiZGVzYyI6IkdldCBmdWxsIGJvdW50eSBzdGF0ZSDigJQgdXNlZCBieSBmcm9udGVuZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0Qm91bnR5SW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZvdGVyX3N0YXR1cyIsImRlc2MiOiJHZXQgYSB2b3RlcidzIERBTyB2b3RlIHN0YXR1cy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFZvdGVyU3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfd29ya2VyX2luZm8iLCJkZXNjIjoiR2V0IGEgd29ya2VyJ3Mgc3VibWlzc2lvbiBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndvcmtlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRWb3RlclN0YXR1c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjksImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3MjZdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHN1Ym1pdHRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTZdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHZvdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3Nl0sImVycm9yTWVzc2FnZSI6IkJvdW50eSBtdXN0IGJlIGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODJdLCJlcnJvck1lc3NhZ2UiOiJCb3VudHkgbm90IGFjY2VwdGluZyBzdWJtaXNzaW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxOCw5NDNdLCJlcnJvck1lc3NhZ2UiOiJCb3VudHkgbm90IGluIHByb2dyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3N10sImVycm9yTWVzc2FnZSI6IkJvdW50eSBub3QgcmVmdW5kYWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OTJdLCJlcnJvck1lc3NhZ2UiOiJDYW4gb25seSBjYW5jZWwgb3BlbiBib3VudGllcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2ODZdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgY2FuY2VsIHdpdGggc3VibWlzc2lvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDVdLCJlcnJvck1lc3NhZ2UiOiJDcmVhdG9yIGNhbm5vdCBzdWJtaXQgd29yayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzhdLCJlcnJvck1lc3NhZ2UiOiJDcmVhdG9yIGNhbm5vdCB2b3RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjkxXSwiZXJyb3JNZXNzYWdlIjoiRGVhZGxpbmUgaGFzIHBhc3NlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OV0sImVycm9yTWVzc2FnZSI6IkRlYWRsaW5lIG11c3QgYmUgYXQgbGVhc3QgMSBob3VyIGZyb20gbm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4Nl0sImVycm9yTWVzc2FnZSI6IkRlYWRsaW5lIG5vdCB5ZXQgcGFzc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzNF0sImVycm9yTWVzc2FnZSI6IkRpc3B1dGUgb25seSBhZnRlciBhbGwgcmVqZWN0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDddLCJlcnJvck1lc3NhZ2UiOiJEaXNwdXRpbmcgZnJlZWxhbmNlciBjYW5ub3Qgdm90ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyNiw5NTBdLCJlcnJvck1lc3NhZ2UiOiJGcmVlbGFuY2VyIGhhcyBub3Qgc3VibWl0dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg5XSwiZXJyb3JNZXNzYWdlIjoiTWluaW11bSByZXdhcmQgaXMgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwNiwxMjM0XSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIGRpc3B1dGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTddLCJlcnJvck1lc3NhZ2UiOiJObyBzdWJtaXNzaW9uIHNsb3RzIHJlbWFpbmluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gYXBwcm92ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGNhbmNlbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gcmVqZWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2MV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcmVqZWN0ZWQgZnJlZWxhbmNlciBjYW4gbGV0IGdvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcmVqZWN0ZWQgZnJlZWxhbmNlcnMgY2FuIGRpc3B1dGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzhdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gZXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNiwxNDY4XSwiZXJyb3JNZXNzYWdlIjoiU2xvdHMgbXVzdCBiZSBleGhhdXN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTE1XSwiZXJyb3JNZXNzYWdlIjoiVm90aW5nIHBlcmlvZCBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDNdLCJlcnJvck1lc3NhZ2UiOiJWb3RpbmcgcGVyaW9kIG5vdCBvdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAzLDgwOSw5MzQsMTEzNiwxMzY4LDE0ODUsMTU5NSwxNjc3LDE3MDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMywxMjQxLDE4MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRhb19kZWFkbGluZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODksMTU4NCwxNzg1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWFkbGluZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ1LDEyNjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRpc3B1dGVfZnJlZWxhbmNlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTU0LDE4NjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmhhc192b3RlZCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDMsMTI3MCwxMzcyLDE0ODksMTU5OSwxNzA1LDE3NzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJld2FyZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjgsNjc1LDc2MCw4MTUsOTQwLDEwMzAsMTEwMiwxMjMwLDE0NzIsMTU2MywxNTcwLDE2OTAsMTc5MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhdHVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1MCwxNjg0LDE4MDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN1Ym1pc3Npb25fY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3VibWlzc2lvbl90aW1lIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5Niw5NTUsMTAyNCwxNDY2LDE3OTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN1Ym1pc3Npb25zX3JlbWFpbmluZyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52b3RlX2Nob2ljZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTc4LDEyNTMsMTgwOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90ZXNfY3JlYXRvciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjEzLDEyNDgsMTgxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90ZXNfZnJlZWxhbmNlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjQsODIzLDk0NywxMDE1LDE0NTcsMTkwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud29ya2VyX3N0YXR1cyBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzgsNjU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ1LDY2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDMsOTI4LDE4NTgsMTg5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTksNDY5LDEwOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDhdLCJlcnJvck1lc3NhZ2UiOiJtYXhfc3VibWlzc2lvbnMgbXVzdCBiZSA8PSA1MCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMl0sImVycm9yTWVzc2FnZSI6Im1heF9zdWJtaXNzaW9ucyBtdXN0IGJlID49IDEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MThdLCJlcnJvck1lc3NhZ2UiOiJtZWdhX2xpbmtfaGFzaCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMwXSwiZXJyb3JNZXNzYWdlIjoidm90ZV9mb3IgbXVzdCBiZSAxIG9yIDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTJdLCJlcnJvck1lc3NhZ2UiOiJ3b3JrX2hhc2ggbXVzdCBiZSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWMzUmhkSFZ6SWlBaVkzSmxZWFJ2Y2lJZ0luZHZjbXRsY2w5emRHRjBkWE1pSUNKeVpYZGhjbVFpSUNKemRXSnRhWE56YVc5dWMxOXlaVzFoYVc1cGJtY2lJQ0oyYjNSbGMxOWpjbVZoZEc5eUlpQWlkbTkwWlhOZlpuSmxaV3hoYm1ObGNpSWdJbVJoYjE5a1pXRmtiR2x1WlNJZ0luTjFZbTFwYzNOcGIyNWZZMjkxYm5RaUlDSmtaV0ZrYkdsdVpTSWdJbVJwYzNCMWRHVmZabkpsWld4aGJtTmxjaUlnSW1oaGMxOTJiM1JsWkNJZ01IZ3hOVEZtTjJNM05TQWlZWEJ3Y205MlpXUmZabkpsWld4aGJtTmxjaUlnSW5OMVltMXBjM05wYjI1ZmRHbHRaU0lnSW5admRHVmZZMmh2YVdObElpQWliV0Y0WDNOMVltMXBjM05wYjI1eklpQWlkMjl5YTE5b1lYTm9JZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPalU0TFRZeENpQWdJQ0F2THlBaklEMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFFvZ0lDQWdMeThnSXlCSGJHOWlZV3dnVTNSaGRHVUtJQ0FnSUM4dklDTWdQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOUNpQWdJQ0F2THlCelpXeG1MbU55WldGMGIzSWdQU0JCWTJOdmRXNTBLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJSE5sYkdZdWNtVjNZWEprSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKeVpYZGhjbVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z2MyVnNaaTVrWldGa2JHbHVaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z2MyVnNaaTVrWVc5ZlpHVmhaR3hwYm1VZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltUmhiMTlrWldGa2JHbHVaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCelpXeG1Mbk4wWVhSMWN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdWJXRjRYM04xWW0xcGMzTnBiMjV6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBaWJXRjRYM04xWW0xcGMzTnBiMjV6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1YzNWaWJXbHpjMmx2Ym5OZmNtVnRZV2x1YVc1bklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZFdKdGFYTnphVzl1WDJOdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p6ZFdKdGFYTnphVzl1WDJOdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUhObGJHWXVZWEJ3Y205MlpXUmZabkpsWld4aGJtTmxjaUE5SUVGalkyOTFiblFvS1FvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW1Gd2NISnZkbVZrWDJaeVpXVnNZVzVqWlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklITmxiR1l1ZG05MFpYTmZZM0psWVhSdmNpQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkbTkwWlhOZlkzSmxZWFJ2Y2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QnpaV3htTG5admRHVnpYMlp5WldWc1lXNWpaWElnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5admRHVnpYMlp5WldWc1lXNWpaWElpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z2MyVnNaaTVrYVhOd2RYUmxYMlp5WldWc1lXNWpaWElnUFNCQlkyTnZkVzUwS0NrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKa2FYTndkWFJsWDJaeVpXVnNZVzVqWlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnWTJ4aGMzTWdRbTkxYm5SNVJYTmpjbTkzS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRJeU1qTTRaaklnTHk4Z2JXVjBhRzlrSUNKdmNIUmZhVzRvS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURVS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QmpiR0Z6Y3lCQ2IzVnVkSGxGYzJOeWIzY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZNU0ySmxNMlprSURCNE4ySm1OVFkxWmpJZ01IaGhNVEU1TlRSaE55QXdlRFZoWlRjMk4yTTRJREI0T1dGbVpUbGhZMkVnTUhnMk9UUTBZVGxrWlNBd2VHVm1PRFl5T1dJeElEQjROVGRrTmpSaU1UY2dNSGhtWWpKbVpUaGhNeUF3ZUdVM09UZ3laR0ZoSURCNFlqUm1OR1pqT0RnZ01IaGtZamMxTUdFd1l5QXdlRFpqTW1JMVpUUTBJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMkp2ZFc1MGVTaHdZWGtzZFdsdWREWTBMSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTjFZbTFwZEY5d2NtOXZaaWhpZVhSbFcxMHNZbmwwWlZ0ZEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVlYQndjbTkyWlY5d1lYbHZkWFFvWVdSa2NtVnpjeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbkpsYW1WamRGOXpkV0p0YVhOemFXOXVLR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSnBibWwwYVdGMFpWOWthWE53ZFhSbEtDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTmhjM1JmWkdGdlgzWnZkR1VvZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWljbVZ6YjJ4MlpWOWtZVzlmWkdsemNIVjBaU2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pzWlhSZloyOWZZbTkxYm5SNUtDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luSmxablZ1WkY5bGVIQnBjbVZrS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1OaGJtTmxiRjlpYjNWdWRIa29LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwWDJKdmRXNTBlVjlwYm1adktDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1kbGRGOTJiM1JsY2w5emRHRjBkWE1vWVdSa2NtVnpjeWtvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5M2IzSnJaWEpmYVc1bWJ5aGhaR1J5WlhOektTaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlY5aWIzVnVkSGtnYzNWaWJXbDBYM0J5YjI5bUlHRndjSEp2ZG1WZmNHRjViM1YwSUhKbGFtVmpkRjl6ZFdKdGFYTnphVzl1SUdsdWFYUnBZWFJsWDJScGMzQjFkR1VnWTJGemRGOWtZVzlmZG05MFpTQnlaWE52YkhabFgyUmhiMTlrYVhOd2RYUmxJR3hsZEY5bmIxOWliM1Z1ZEhrZ2NtVm1kVzVrWDJWNGNHbHlaV1FnWTJGdVkyVnNYMkp2ZFc1MGVTQm5aWFJmWW05MWJuUjVYMmx1Wm04Z1oyVjBYM1p2ZEdWeVgzTjBZWFIxY3lCblpYUmZkMjl5YTJWeVgybHVabThLSUNBZ0lHVnljZ29LYldGcGJsOXZjSFJmYVc1ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hNVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazl3ZEVsdUlsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdUM0IwU1c0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCdmNIUmZhVzRLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qUTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1b1pXeHNiMTkzYjNKc1pDNWpiMjUwY21GamRDNUNiM1Z1ZEhsRmMyTnliM2N1WTNKbFlYUmxYMkp2ZFc1MGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOWliM1Z1ZEhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lsQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCMGJ5QmxjMk55YjNjaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQm5ieUIwYnlCbGMyTnliM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDQ5SUZWSmJuUTJOQ2hOU1U1ZlVrVlhRVkpFS1N3Z0lrMXBibWx0ZFcwZ2NtVjNZWEprSUdseklERWdRVXhIVHlJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmFXNXBiWFZ0SUhKbGQyRnlaQ0JwY3lBeElFRk1SMDhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCa1pXRmtiR2x1WlNBK0lFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUNzZ1ZVbHVkRFkwS0U5T1JWOUlUMVZTS1N3Z0lrUmxZV1JzYVc1bElHMTFjM1FnWW1VZ1lYUWdiR1ZoYzNRZ01TQm9iM1Z5SUdaeWIyMGdibTkzSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdjSFZ6YUdsdWRDQXpOakF3Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUVSbFlXUnNhVzVsSUcxMWMzUWdZbVVnWVhRZ2JHVmhjM1FnTVNCb2IzVnlJR1p5YjIwZ2JtOTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnYldGNFgzTjFZbTFwYzNOcGIyNXpJRDQ5SUZWSmJuUTJOQ2d4S1N3Z0ltMWhlRjl6ZFdKdGFYTnphVzl1Y3lCdGRYTjBJR0psSUQ0OUlERWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHMWhlRjl6ZFdKdGFYTnphVzl1Y3lCdGRYTjBJR0psSUQ0OUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TURJS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhoZmMzVmliV2x6YzJsdmJuTWdQRDBnVlVsdWREWTBLRFV3S1N3Z0ltMWhlRjl6ZFdKdGFYTnphVzl1Y3lCdGRYTjBJR0psSUR3OUlEVXdJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYldGNFgzTjFZbTFwYzNOcGIyNXpJRzExYzNRZ1ltVWdQRDBnTlRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJSE5sYkdZdVkzSmxZWFJ2Y2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdjMlZzWmk1eVpYZGhjbVFnUFNCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljbVYzWVhKa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUhObGJHWXVaR1ZoWkd4cGJtVWdQU0JrWldGa2JHbHVaUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlaR1ZoWkd4cGJtVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVEEzQ2lBZ0lDQXZMeUJ6Wld4bUxtUmhiMTlrWldGa2JHbHVaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpWkdGdlgyUmxZV1JzYVc1bElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVEE0Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlGVkpiblEyTkNoVFZFRlVWVk5mVDFCRlRpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdjMlZzWmk1dFlYaGZjM1ZpYldsemMybHZibk1nUFNCdFlYaGZjM1ZpYldsemMybHZibk1LSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0p0WVhoZmMzVmliV2x6YzJsdmJuTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklITmxiR1l1YzNWaWJXbHpjMmx2Ym5OZmNtVnRZV2x1YVc1bklEMGdiV0Y0WDNOMVltMXBjM05wYjI1ekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKemRXSnRhWE56YVc5dWMxOXlaVzFoYVc1cGJtY2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZFdKdGFYTnphVzl1WDJOdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p6ZFdKdGFYTnphVzl1WDJOdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCelpXeG1MbUZ3Y0hKdmRtVmtYMlp5WldWc1lXNWpaWElnUFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVlYQndjbTkyWldSZlpuSmxaV3hoYm1ObGNpSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJSE5sYkdZdWRtOTBaWE5mWTNKbFlYUnZjaUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZG05MFpYTmZZM0psWVhSdmNpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnYzJWc1ppNTJiM1JsYzE5bWNtVmxiR0Z1WTJWeUlEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklDSjJiM1JsYzE5bWNtVmxiR0Z1WTJWeUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJ6Wld4bUxtUnBjM0IxZEdWZlpuSmxaV3hoYm1ObGNpQTlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01LSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0prYVhOd2RYUmxYMlp5WldWc1lXNWpaWElpQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQmxOakkyWmpjMU5tVTNORGM1TldZMk16Y3lOalUyTVRjME5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1obGJHeHZYM2R2Y214a0xtTnZiblJ5WVdOMExrSnZkVzUwZVVWelkzSnZkeTV2Y0hSZmFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSZmFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCelpXeG1MbmR2Y210ZmFHRnphRnRVZUc0dWMyVnVaR1Z5WFNBOUlFSjVkR1Z6S0dJaUlpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKM2IzSnJYMmhoYzJnaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hNak1LSUNBZ0lDOHZJSE5sYkdZdWMzVmliV2x6YzJsdmJsOTBhVzFsVzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaWMzVmliV2x6YzJsdmJsOTBhVzFsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklITmxiR1l1ZDI5eWEyVnlYM04wWVhSMWMxdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2hYVDFKTFJWSmZUazlPUlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmR2Y210bGNsOXpkR0YwZFhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdjMlZzWmk1b1lYTmZkbTkwWldSYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSm9ZWE5mZG05MFpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakV5TmdvZ0lDQWdMeThnYzJWc1ppNTJiM1JsWDJOb2IybGpaVnRVZUc0dWMyVnVaR1Z5WFNBOUlGVkpiblEyTkNoV1QxUkZYMDVQVGtVcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpZG05MFpWOWphRzlwWTJVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRXhPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdPRFptTnpBM05EWTFOalExWmpZNU5tVUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVvWld4c2IxOTNiM0pzWkM1amIyNTBjbUZqZEM1Q2IzVnVkSGxGYzJOeWIzY3VjM1ZpYldsMFgzQnliMjltVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDNCeWIyOW1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3lBOVBTQlZTVzUwTmpRb1UxUkJWRlZUWDA5UVJVNHBJRzl5SUhObGJHWXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DaFRWRUZVVlZOZlNVNWZVRkpQUjFKRlUxTXBMQ0FpUW05MWJuUjVJRzV2ZENCaFkyTmxjSFJwYm1jZ2MzVmliV2x6YzJsdmJuTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFIxY3lCbGVHbHpkSE1LSUNBZ0lHSjZJSE4xWW0xcGRGOXdjbTl2Wmw5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRHRjBkWE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhOMVltMXBkRjl3Y205dlpsOWliMjlzWDJaaGJITmxRRFFLQ25OMVltMXBkRjl3Y205dlpsOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3B6ZFdKdGFYUmZjSEp2YjJaZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DaFRWRUZVVlZOZlQxQkZUaWtnYjNJZ2MyVnNaaTV6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRk5VUVZSVlUxOUpUbDlRVWs5SFVrVlRVeWtzSUNKQ2IzVnVkSGtnYm05MElHRmpZMlZ3ZEdsdVp5QnpkV0p0YVhOemFXOXVjeUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM1Z1ZEhrZ2JtOTBJR0ZqWTJWd2RHbHVaeUJ6ZFdKdGFYTnphVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3OUlITmxiR1l1WkdWaFpHeHBibVVzSUNKRVpXRmtiR2x1WlNCb1lYTWdjR0Z6YzJWa0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1SbFlXUnNhVzVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxZV1JzYVc1bElHVjRhWE4wY3dvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZrYkdsdVpTQm9ZWE1nY0dGemMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNnUGlCVlNXNTBOalFvTUNrc0lDSk9ieUJ6ZFdKdGFYTnphVzl1SUhOc2IzUnpJSEpsYldGcGJtbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzVmliV2x6YzJsdmJuTmZjbVZ0WVdsdWFXNW5JR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUU1dklITjFZbTFwYzNOcGIyNGdjMnh2ZEhNZ2NtVnRZV2x1YVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUFoUFNCelpXeG1MbU55WldGMGIzSXNJQ0pEY21WaGRHOXlJR05oYm01dmRDQnpkV0p0YVhRZ2QyOXlheUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV0YwYjNJZ1pYaHBjM1J6Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnlaV0YwYjNJZ1kyRnVibTkwSUhOMVltMXBkQ0IzYjNKckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJoYzNObGNuUWdkMjl5YTE5b1lYTm9MbXhsYm1kMGFDQTlQU0JWU1c1ME5qUW9NeklwTENBaWQyOXlhMTlvWVhOb0lHMTFjM1FnWW1VZ016SWdZbmwwWlhNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjNiM0pyWDJoaGMyZ2diWFZ6ZENCaVpTQXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnWVhOelpYSjBJRzFsWjJGZmJHbHVhMTlvWVhOb0xteGxibWQwYUNBOVBTQlZTVzUwTmpRb016SXBMQ0FpYldWbllWOXNhVzVyWDJoaGMyZ2diWFZ6ZENCaVpTQXpNaUJpZVhSbGN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0WldkaFgyeHBibXRmYUdGemFDQnRkWE4wSUdKbElETXlJR0o1ZEdWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUIzYjNKclpYSmZjM1JoZEhWelgzWmhiQ0E5SUhObGJHWXVkMjl5YTJWeVgzTjBZWFIxYzF0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmR2Y210bGNsOXpkR0YwZFhNaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTNiM0pyWlhKZmMzUmhkSFZ6SUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdZWE56WlhKMElIZHZjbXRsY2w5emRHRjBkWE5mZG1Gc0lEMDlJRlZKYm5RMk5DaFhUMUpMUlZKZlRrOU9SU2tzSUNKQmJISmxZV1I1SUhOMVltMXBkSFJsWkNJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiSEpsWVdSNUlITjFZbTFwZEhSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUwTlFvZ0lDQWdMeThnYzJWc1ppNTNiM0pyWDJoaGMyaGJWSGh1TG5ObGJtUmxjbDBnUFNCM2IzSnJYMmhoYzJnS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0ozYjNKclgyaGhjMmdpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TkRZS0lDQWdJQzh2SUhObGJHWXVjM1ZpYldsemMybHZibDkwYVcxbFcxUjRiaTV6Wlc1a1pYSmRJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKemRXSnRhWE56YVc5dVgzUnBiV1VpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QnpaV3htTG5kdmNtdGxjbDl6ZEdGMGRYTmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvVjA5U1MwVlNYMU5WUWsxSlZGUkZSQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luZHZjbXRsY2w5emRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZFdKdGFYTnphVzl1WDJOdmRXNTBJRDBnYzJWc1ppNXpkV0p0YVhOemFXOXVYMk52ZFc1MElDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWMzVmliV2x6YzJsdmJsOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkV0p0YVhOemFXOXVYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luTjFZbTFwYzNOcGIyNWZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnYVdZZ2MyVnNaaTV6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRk5VUVZSVlUxOVBVRVZPS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGRIVnpJR1Y0YVhOMGN3b2dJQ0FnWW01NklITjFZbTFwZEY5d2NtOXZabDloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TlRFS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWeklEMGdWVWx1ZERZMEtGTlVRVlJWVTE5SlRsOVFVazlIVWtWVFV5a0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2MzVmliV2wwWDNCeWIyOW1YMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQmxOemMyWmpjeU5tSTFaamN6TnpVMk1qWmtOamszTkRjME5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6ZFdKdGFYUmZjSEp2YjJaZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MzVmliV2wwWDNCeWIyOW1YMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW9aV3hzYjE5M2IzSnNaQzVqYjI1MGNtRmpkQzVDYjNWdWRIbEZjMk55YjNjdVlYQndjbTkyWlY5d1lYbHZkWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNIQnliM1psWDNCaGVXOTFkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1OeVpXRjBiM0lzSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUdGd2NISnZkbVVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZoZEc5eUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHRndjSEp2ZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvVTFSQlZGVlRYMGxPWDFCU1QwZFNSVk5US1N3Z0lrSnZkVzUwZVNCdWIzUWdhVzRnY0hKdlozSmxjM01pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSnZkVzUwZVNCdWIzUWdhVzRnY0hKdlozSmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklIZHZjbXRsY2w5emRHRjBkWE5mZG1Gc0lEMGdjMlZzWmk1M2IzSnJaWEpmYzNSaGRIVnpXMlp5WldWc1lXNWpaWEpkQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjNiM0pyWlhKZmMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWQyOXlhMlZ5WDNOMFlYUjFjeUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCM2IzSnJaWEpmYzNSaGRIVnpYM1poYkNBOVBTQlZTVzUwTmpRb1YwOVNTMFZTWDFOVlFrMUpWRlJGUkNrc0lDSkdjbVZsYkdGdVkyVnlJR2hoY3lCdWIzUWdjM1ZpYldsMGRHVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUm5KbFpXeGhibU5sY2lCb1lYTWdibTkwSUhOMVltMXBkSFJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTJOQW9nSUNBZ0x5OGdjMlZzWmk1M2IzSnJaWEpmYzNSaGRIVnpXMlp5WldWc1lXNWpaWEpkSUQwZ1ZVbHVkRFkwS0ZkUFVrdEZVbDlCUTBORlVGUkZSQ2tLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkMjl5YTJWeVgzTjBZWFIxY3lJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QnpaV3htTG1Gd2NISnZkbVZrWDJaeVpXVnNZVzVqWlhJZ1BTQm1jbVZsYkdGdVkyVnlDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlZWEJ3Y205MlpXUmZabkpsWld4aGJtTmxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTJOZ29nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE1nUFNCVlNXNTBOalFvVTFSQlZGVlRYME5QVFZCTVJWUkZSQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUyT0MweE56TUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxbWNtVmxiR0Z1WTJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpaV3htTG5KbGQyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlRbmwwWlhNb1lpSkNiM1Z1ZEhsV1lYVnNkRHB6ZFdKdGFYTnphVzl1WDJGd2NISnZkbVZrSWlrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UY3dDaUFnSUNBdkx5QmhiVzkxYm5ROWMyVnNaaTV5WlhkaGNtUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVjNZWEprSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxkMkZ5WkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklHNXZkR1U5UW5sMFpYTW9ZaUpDYjNWdWRIbFdZWFZzZERwemRXSnRhWE56YVc5dVgyRndjSEp2ZG1Wa0lpa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNalptTnpVMlpUYzBOemsxTmpZeE56VTJZemMwTTJFM016YzFOakkyWkRZNU56TTNNelk1Tm1ZMlpUVm1OakUzTURjd056STJaamMyTmpVMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFMk9Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUzTVFvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakUyT0MweE56TUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxbWNtVmxiR0Z1WTJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpaV3htTG5KbGQyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlRbmwwWlhNb1lpSkNiM1Z1ZEhsV1lYVnNkRHB6ZFdKdGFYTnphVzl1WDJGd2NISnZkbVZrSWlrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVRNM016YzFOakkyWkRZNU56TTNNelk1Tm1ZMlpUVm1OakUzTURjd056STJaamMyTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhsYkd4dlgzZHZjbXhrTG1OdmJuUnlZV04wTGtKdmRXNTBlVVZ6WTNKdmR5NXlaV3BsWTNSZmMzVmliV2x6YzJsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYW1WamRGOXpkV0p0YVhOemFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFM053b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVkzSmxZWFJ2Y2l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2NtVnFaV04wSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnlaV3BsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvVTFSQlZGVlRYMGxPWDFCU1QwZFNSVk5US1N3Z0lrSnZkVzUwZVNCdWIzUWdhVzRnY0hKdlozSmxjM01pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSnZkVzUwZVNCdWIzUWdhVzRnY0hKdlozSmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveE9EY0tJQ0FnSUM4dklIZHZjbXRsY2w5emRHRjBkWE5mZG1Gc0lEMGdjMlZzWmk1M2IzSnJaWEpmYzNSaGRIVnpXMlp5WldWc1lXNWpaWEpkQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkMjl5YTJWeVgzTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuZHZjbXRsY2w5emRHRjBkWE1nWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UZzRDaUFnSUNBdkx5QmhjM05sY25RZ2QyOXlhMlZ5WDNOMFlYUjFjMTkyWVd3Z1BUMGdWVWx1ZERZMEtGZFBVa3RGVWw5VFZVSk5TVlJVUlVRcExDQWlSbkpsWld4aGJtTmxjaUJvWVhNZ2JtOTBJSE4xWW0xcGRIUmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVaeVpXVnNZVzVqWlhJZ2FHRnpJRzV2ZENCemRXSnRhWFIwWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3hPVEFLSUNBZ0lDOHZJSE5sYkdZdWMzVmliV2x6YzJsdmJuTmZjbVZ0WVdsdWFXNW5JRDBnYzJWc1ppNXpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNnTFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p6ZFdKdGFYTnphVzl1YzE5eVpXMWhhVzVwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1ZpYldsemMybHZibk5mY21WdFlXbHVhVzVuSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5OMVltMXBjM05wYjI1elgzSmxiV0ZwYm1sdVp5SUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFNU1nb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1emRXSnRhWE56YVc5dWMxOXlaVzFoYVc1cGJtY2dQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdZbTU2SUhKbGFtVmpkRjl6ZFdKdGFYTnphVzl1WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJ6Wld4bUxuZHZjbXRsY2w5emRHRjBkWE5iWm5KbFpXeGhibU5sY2wwZ1BTQlZTVzUwTmpRb1YwOVNTMFZTWDFKRlNrVkRWRVZFS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZDI5eWEyVnlYM04wWVhSMWN5SUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTVOQW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE1nUFNCVlNXNTBOalFvVTFSQlZGVlRYMFZZVUVsU1JVUXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dweVpXcGxZM1JmYzNWaWJXbHpjMmx2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF4TXpjek56VTJNalprTmprM016Y3pOamsyWmpabE5XWTNNalkxTm1FMk5UWXpOelEyTlRZMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxhbVZqZEY5emRXSnRhWE56YVc5dVgyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z2MyVnNaaTUzYjNKclpYSmZjM1JoZEhWelcyWnlaV1ZzWVc1alpYSmRJRDBnVlVsdWREWTBLRmRQVWt0RlVsOU9UMDVGS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZDI5eWEyVnlYM04wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0JpSUhKbGFtVmpkRjl6ZFdKdGFYTnphVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1b1pXeHNiMTkzYjNKc1pDNWpiMjUwY21GamRDNUNiM1Z1ZEhsRmMyTnliM2N1YVc1cGRHbGhkR1ZmWkdsemNIVjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUnBZWFJsWDJScGMzQjFkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qQTNDaUFnSUNBdkx5QjNiM0pyWlhKZmMzUmhkSFZ6WDNaaGJDQTlJSE5sYkdZdWQyOXlhMlZ5WDNOMFlYUjFjMXRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luZHZjbXRsY2w5emRHRjBkWE1pQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1M2IzSnJaWEpmYzNSaGRIVnpJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhkdmNtdGxjbDl6ZEdGMGRYTmZkbUZzSUQwOUlGVkpiblEyTkNoWFQxSkxSVkpmVWtWS1JVTlVSVVFwTENBaVQyNXNlU0J5WldwbFkzUmxaQ0JtY21WbGJHRnVZMlZ5Y3lCallXNGdaR2x6Y0hWMFpTSUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhKbGFtVmpkR1ZrSUdaeVpXVnNZVzVqWlhKeklHTmhiaUJrYVhOd2RYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpBNUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNnUFQwZ1ZVbHVkRFkwS0RBcExDQWlVMnh2ZEhNZ2JYVnpkQ0JpWlNCbGVHaGhkWE4wWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzNWaWJXbHpjMmx2Ym5OZmNtVnRZV2x1YVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4xWW0xcGMzTnBiMjV6WDNKbGJXRnBibWx1WnlCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVGJHOTBjeUJ0ZFhOMElHSmxJR1Y0YUdGMWMzUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJeE1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DaFRWRUZVVlZOZlJWaFFTVkpGUkNrc0lDSkVhWE53ZFhSbElHOXViSGtnWVdaMFpYSWdZV3hzSUhKbGFtVmpkR2x2Ym5NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVhWE53ZFhSbElHOXViSGtnWVdaMFpYSWdZV3hzSUhKbGFtVmpkR2x2Ym5NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lNVElLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6SUQwZ1ZVbHVkRFkwS0ZOVVFWUlZVMTlFU1ZOUVZWUkZSQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSE5sYkdZdVpHRnZYMlJsWVdSc2FXNWxJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJWU1c1ME5qUW9SazlTVkZsZlJVbEhTRlJmU0U5VlVsTXBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCd2RYTm9hVzUwSURFM01qZ3dNQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOeUF2THlBaVpHRnZYMlJsWVdSc2FXNWxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU1UUUtJQ0FnSUM4dklITmxiR1l1ZG05MFpYTmZZM0psWVhSdmNpQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkbTkwWlhOZlkzSmxZWFJ2Y2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdjMlZzWmk1MmIzUmxjMTltY21WbGJHRnVZMlZ5SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMmIzUmxjMTltY21WbGJHRnVZMlZ5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QnpaV3htTG1ScGMzQjFkR1ZmWm5KbFpXeGhibU5sY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmthWE53ZFhSbFgyWnlaV1ZzWVc1alpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01HVTJORFk1TnpNM01EYzFOelEyTlRWbU56STJNVFk1TnpNMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YUdWc2JHOWZkMjl5YkdRdVkyOXVkSEpoWTNRdVFtOTFiblI1UlhOamNtOTNMbU5oYzNSZlpHRnZYM1p2ZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZWE4wWDJSaGIxOTJiM1JsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSXlNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qSXpDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRk5VUVZSVlUxOUVTVk5RVlZSRlJDa3NJQ0pPYnlCaFkzUnBkbVVnWkdsemNIVjBaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHRmpkR2wyWlNCa2FYTndkWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUENCelpXeG1MbVJoYjE5a1pXRmtiR2x1WlN3Z0lsWnZkR2x1WnlCd1pYSnBiMlFnWlc1a1pXUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVpHRnZYMlJsWVdSc2FXNWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SaGIxOWtaV0ZrYkdsdVpTQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QldiM1JwYm1jZ2NHVnlhVzlrSUdWdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCaGMzTmxjblFnZG05MFpWOW1iM0lnUFQwZ1ZVbHVkRFkwS0ZaUFZFVmZRMUpGUVZSUFVpa2diM0lnZG05MFpWOW1iM0lnUFQwZ1ZVbHVkRFkwS0ZaUFZFVmZSbEpGUlV4QlRrTkZVaWtzSUNKMmIzUmxYMlp2Y2lCdGRYTjBJR0psSURFZ2IzSWdNaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWkhWd0NpQWdJQ0JpYm5vZ1kyRnpkRjlrWVc5ZmRtOTBaVjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMkZ6ZEY5a1lXOWZkbTkwWlY5aWIyOXNYMlpoYkhObFFEUUtDbU5oYzNSZlpHRnZYM1p2ZEdWZlltOXZiRjkwY25WbFFETTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tZMkZ6ZEY5a1lXOWZkbTkwWlY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCaGMzTmxjblFnZG05MFpWOW1iM0lnUFQwZ1ZVbHVkRFkwS0ZaUFZFVmZRMUpGUVZSUFVpa2diM0lnZG05MFpWOW1iM0lnUFQwZ1ZVbHVkRFkwS0ZaUFZFVmZSbEpGUlV4QlRrTkZVaWtzSUNKMmIzUmxYMlp2Y2lCdGRYTjBJR0psSURFZ2IzSWdNaUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJiM1JsWDJadmNpQnRkWE4wSUdKbElERWdiM0lnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSXlOd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdJVDBnYzJWc1ppNWpjbVZoZEc5eUxDQWlRM0psWVhSdmNpQmpZVzV1YjNRZ2RtOTBaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV0YwYjNJZ1pYaHBjM1J6Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnlaV0YwYjNJZ1kyRnVibTkwSUhadmRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG95TWpnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUNFOUlITmxiR1l1WkdsemNIVjBaVjltY21WbGJHRnVZMlZ5TENBaVJHbHpjSFYwYVc1bklHWnlaV1ZzWVc1alpYSWdZMkZ1Ym05MElIWnZkR1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltUnBjM0IxZEdWZlpuSmxaV3hoYm1ObGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrYVhOd2RYUmxYMlp5WldWc1lXNWpaWElnWlhocGMzUnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVScGMzQjFkR2x1WnlCbWNtVmxiR0Z1WTJWeUlHTmhibTV2ZENCMmIzUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpNd0NpQWdJQ0F2THlCb1lYTmZkbTkwWldSZmRtRnNJRDBnYzJWc1ppNW9ZWE5mZG05MFpXUmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWFHRnpYM1p2ZEdWa0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhR0Z6WDNadmRHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJek1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdoaGMxOTJiM1JsWkY5MllXd2dQVDBnVlVsdWREWTBLREFwTENBaVFXeHlaV0ZrZVNCMmIzUmxaQ0lLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUhadmRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpNekNpQWdJQ0F2THlCelpXeG1MbWhoYzE5MmIzUmxaRnRVZUc0dWMyVnVaR1Z5WFNBOUlGVkpiblEyTkNneEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1oaGMxOTJiM1JsWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qTTBDaUFnSUNBdkx5QnpaV3htTG5admRHVmZZMmh2YVdObFcxUjRiaTV6Wlc1a1pYSmRJRDBnZG05MFpWOW1iM0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSjJiM1JsWDJOb2IybGpaU0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qTTJDaUFnSUNBdkx5QnBaaUIyYjNSbFgyWnZjaUE5UFNCVlNXNTBOalFvVms5VVJWOURVa1ZCVkU5U0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWW5vZ1kyRnpkRjlrWVc5ZmRtOTBaVjlsYkhObFgySnZaSGxBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdjMlZzWmk1MmIzUmxjMTlqY21WaGRHOXlJRDBnYzJWc1ppNTJiM1JsYzE5amNtVmhkRzl5SUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZG05MFpYTmZZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyYjNSbGMxOWpjbVZoZEc5eUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luWnZkR1Z6WDJOeVpXRjBiM0lpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1kyRnpkRjlrWVc5ZmRtOTBaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdaRFkwTmpFMlpqVm1OelkyWmpjME5qVTFaall6TmpFM016YzBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5oYzNSZlpHRnZYM1p2ZEdWZlpXeHpaVjlpYjJSNVFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpNNUNpQWdJQ0F2THlCelpXeG1Mblp2ZEdWelgyWnlaV1ZzWVc1alpYSWdQU0J6Wld4bUxuWnZkR1Z6WDJaeVpXVnNZVzVqWlhJZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMmIzUmxjMTltY21WbGJHRnVZMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuWnZkR1Z6WDJaeVpXVnNZVzVqWlhJZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRtOTBaWE5mWm5KbFpXeGhibU5sY2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUdOaGMzUmZaR0Z2WDNadmRHVmZZV1owWlhKZmFXWmZaV3h6WlVBNENncGpZWE4wWDJSaGIxOTJiM1JsWDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOaGMzUmZaR0Z2WDNadmRHVmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtaGxiR3h2WDNkdmNteGtMbU52Ym5SeVlXTjBMa0p2ZFc1MGVVVnpZM0p2ZHk1eVpYTnZiSFpsWDJSaGIxOWthWE53ZFhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ6YjJ4MlpWOWtZVzlmWkdsemNIVjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5QTlQU0JWU1c1ME5qUW9VMVJCVkZWVFgwUkpVMUJWVkVWRUtTd2dJazV2SUdGamRHbDJaU0JrYVhOd2RYUmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1lXTjBhWFpsSUdScGMzQjFkR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU5URUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErUFNCelpXeG1MbVJoYjE5a1pXRmtiR2x1WlN3Z0lsWnZkR2x1WnlCd1pYSnBiMlFnYm05MElHOTJaWElpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlaR0Z2WDJSbFlXUnNhVzVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmhiMTlrWldGa2JHbHVaU0JsZUdsemRITUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnVm05MGFXNW5JSEJsY21sdlpDQnViM1FnYjNabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakkxTXdvZ0lDQWdMeThnYVdZZ2MyVnNaaTUyYjNSbGMxOW1jbVZsYkdGdVkyVnlJRDRnYzJWc1ppNTJiM1JsYzE5amNtVmhkRzl5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblp2ZEdWelgyWnlaV1ZzWVc1alpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MFpYTmZabkpsWld4aGJtTmxjaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMmIzUmxjMTlqY21WaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5admRHVnpYMk55WldGMGIzSWdaWGhwYzNSekNpQWdJQ0ErQ2lBZ0lDQmllaUJ5WlhOdmJIWmxYMlJoYjE5a2FYTndkWFJsWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNalUwQ2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlGVkpiblEyTkNoVFZFRlVWVk5mUTA5TlVFeEZWRVZFS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpVMUxUSTJNQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1WkdsemNIVjBaVjltY21WbGJHRnVZMlZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxelpXeG1MbkpsZDJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVFubDBaWE1vWWlKQ2IzVnVkSGxXWVhWc2REcGtZVzlmY21WemIyeDJaV1JmWm5KbFpXeGhibU5sY2lJcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSTFOZ29nSUNBZ0x5OGdjbVZqWldsMlpYSTljMlZzWmk1a2FYTndkWFJsWDJaeVpXVnNZVzVqWlhJc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1ScGMzQjFkR1ZmWm5KbFpXeGhibU5sY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWthWE53ZFhSbFgyWnlaV1ZzWVc1alpYSWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNalUzQ2lBZ0lDQXZMeUJoYlc5MWJuUTljMlZzWmk1eVpYZGhjbVFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljbVYzWVhKa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsZDJGeVpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lOVGtLSUNBZ0lDOHZJRzV2ZEdVOVFubDBaWE1vWWlKQ2IzVnVkSGxXWVhWc2REcGtZVzlmY21WemIyeDJaV1JmWm5KbFpXeGhibU5sY2lJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5ESTJaamMxTm1VM05EYzVOVFkyTVRjMU5tTTNORE5oTmpRMk1UWm1OV1kzTWpZMU56TTJaalpqTnpZMk5UWTBOV1kyTmpjeU5qVTJOVFpqTmpFMlpUWXpOalUzTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JPYjNSbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakkxTlFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSTFPQW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSTFOUzB5TmpBS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtUnBjM0IxZEdWZlpuSmxaV3hoYm1ObGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMlZzWmk1eVpYZGhjbVFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQVUo1ZEdWektHSWlRbTkxYm5SNVZtRjFiSFE2WkdGdlgzSmxjMjlzZG1Wa1gyWnlaV1ZzWVc1alpYSWlLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpZeENpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GTjBjbWx1WnlnaVpHRnZYM0psYzI5c2RtVmtYMlp5WldWc1lXNWpaWEpmZDJsdWN5SXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZqTmpRMk1UWm1OV1kzTWpZMU56TTJaalpqTnpZMk5UWTBOV1kyTmpjeU5qVTJOVFpqTmpFMlpUWXpOalUzTWpWbU56YzJPVFpsTnpNS0NuSmxjMjlzZG1WZlpHRnZYMlJwYzNCMWRHVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11YUdWc2JHOWZkMjl5YkdRdVkyOXVkSEpoWTNRdVFtOTFiblI1UlhOamNtOTNMbkpsYzI5c2RtVmZaR0Z2WDJScGMzQjFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxjMjlzZG1WZlpHRnZYMlJwYzNCMWRHVmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qWXpDaUFnSUNBdkx5QnpaV3htTG5OMFlYUjFjeUE5SUZWSmJuUTJOQ2hUVkVGVVZWTmZSVmhRU1ZKRlJDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU5qUXRNalk1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxelpXeG1MbkpsZDJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVFubDBaWE1vWWlKQ2IzVnVkSGxXWVhWc2REcGtZVzlmY21WemIyeDJaV1JmWTNKbFlYUnZjaUlwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJMk5Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lOallLSUNBZ0lDOHZJR0Z0YjNWdWREMXpaV3htTG5KbGQyRnlaQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnlaWGRoY21RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVYzWVhKa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSTJPQW9nSUNBZ0x5OGdibTkwWlQxQ2VYUmxjeWhpSWtKdmRXNTBlVlpoZFd4ME9tUmhiMTl5WlhOdmJIWmxaRjlqY21WaGRHOXlJaWtzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTWpabU56VTJaVGMwTnprMU5qWXhOelUyWXpjME0yRTJORFl4Tm1ZMVpqY3lOalUzTXpabU5tTTNOalkxTmpRMVpqWXpOekkyTlRZeE56UTJaamN5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNalkwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qWTNDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qWTBMVEkyT1FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdVkzSmxZWFJ2Y2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyVnNaaTV5WlhkaGNtUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBVSjVkR1Z6S0dJaVFtOTFiblI1Vm1GMWJIUTZaR0Z2WDNKbGMyOXNkbVZrWDJOeVpXRjBiM0lpS1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qY3dDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORk4wY21sdVp5Z2laR0Z2WDNKbGMyOXNkbVZrWDJOeVpXRjBiM0pmZDJsdWN5SXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREU1TmpRMk1UWm1OV1kzTWpZMU56TTJaalpqTnpZMk5UWTBOV1kyTXpjeU5qVTJNVGMwTm1ZM01qVm1OemMyT1RabE56TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG95TkRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWWlCeVpYTnZiSFpsWDJSaGIxOWthWE53ZFhSbFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhsYkd4dlgzZHZjbXhrTG1OdmJuUnlZV04wTGtKdmRXNTBlVVZ6WTNKdmR5NXlaWE52YkhabFgyUmhiMTlrYVhOd2RYUmxRRFlLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHVnNiRzlmZDI5eWJHUXVZMjl1ZEhKaFkzUXVRbTkxYm5SNVJYTmpjbTkzTG14bGRGOW5iMTlpYjNWdWRIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzWlhSZloyOWZZbTkxYm5SNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakkzTlFvZ0lDQWdMeThnZDI5eWEyVnlYM04wWVhSMWMxOTJZV3dnUFNCelpXeG1MbmR2Y210bGNsOXpkR0YwZFhOYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ozYjNKclpYSmZjM1JoZEhWeklnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkMjl5YTJWeVgzTjBZWFIxY3lCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lOellLSUNBZ0lDOHZJR0Z6YzJWeWRDQjNiM0pyWlhKZmMzUmhkSFZ6WDNaaGJDQTlQU0JWU1c1ME5qUW9WMDlTUzBWU1gxSkZTa1ZEVkVWRUtTd2dJazl1YkhrZ2NtVnFaV04wWldRZ1puSmxaV3hoYm1ObGNpQmpZVzRnYkdWMElHZHZJZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NtVnFaV04wWldRZ1puSmxaV3hoYm1ObGNpQmpZVzRnYkdWMElHZHZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpjM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNnUFQwZ1ZVbHVkRFkwS0RBcExDQWlVMnh2ZEhNZ2JYVnpkQ0JpWlNCbGVHaGhkWE4wWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzNWaWJXbHpjMmx2Ym5OZmNtVnRZV2x1YVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4xWW0xcGMzTnBiMjV6WDNKbGJXRnBibWx1WnlCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVGJHOTBjeUJ0ZFhOMElHSmxJR1Y0YUdGMWMzUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJM09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjM1JoZEhWeklEMDlJRlZKYm5RMk5DaFRWRUZVVlZOZlJWaFFTVkpGUkNrc0lDSkNiM1Z1ZEhrZ2JYVnpkQ0JpWlNCbGVIQnBjbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTFiblI1SUcxMWMzUWdZbVVnWlhod2FYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJNE1Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTWdQU0JWU1c1ME5qUW9VMVJCVkZWVFgwTkJUa05GVEV4RlJDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU9ESXRNamczQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxelpXeG1MbkpsZDJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVFubDBaWE1vWWlKQ2IzVnVkSGxXWVhWc2REcG1jbVZsYkdGdVkyVnlYMnhsZEdkdklpa3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNamd6Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajF6Wld4bUxtTnlaV0YwYjNJc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amNtVmhkRzl5SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJNE5Bb2dJQ0FnTHk4Z1lXMXZkVzUwUFhObGJHWXVjbVYzWVhKa0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGQyRnlaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYZGhjbVFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TWpnMkNpQWdJQ0F2THlCdWIzUmxQVUo1ZEdWektHSWlRbTkxYm5SNVZtRjFiSFE2Wm5KbFpXeGhibU5sY2w5c1pYUm5ieUlwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRJMlpqYzFObVUzTkRjNU5UWTJNVGMxTm1NM05ETmhOalkzTWpZMU5qVTJZell4Tm1VMk16WTFOekkxWmpaak5qVTNORFkzTm1ZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG95T0RJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lPRFVLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3lPREl0TWpnM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNWpjbVZoZEc5eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpaV3htTG5KbGQyRnlaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlRbmwwWlhNb1lpSkNiM1Z1ZEhsV1lYVnNkRHBtY21WbGJHRnVZMlZ5WDJ4bGRHZHZJaWtzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pJM01nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNVEEyTmpjeU5qVTJOVFpqTmpFMlpUWXpOalUzTWpWbU5tTTJOVGMwTmpjMlpnb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhsYkd4dlgzZHZjbXhrTG1OdmJuUnlZV04wTGtKdmRXNTBlVVZ6WTNKdmR5NXlaV1oxYm1SZlpYaHdhWEpsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxablZ1WkY5bGVIQnBjbVZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qSTVPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YzNSaGRIVnpJRDA5SUZWSmJuUTJOQ2hUVkVGVVZWTmZUMUJGVGlrZ2IzSWdjMlZzWmk1emRHRjBkWE1nUFQwZ1ZVbHVkRFkwS0ZOVVFWUlZVMTlKVGw5UVVrOUhVa1ZUVXlrc0lDSkNiM1Z1ZEhrZ2JtOTBJSEpsWm5WdVpHRmliR1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR0o2SUhKbFpuVnVaRjlsZUhCcGNtVmtYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZtZFc1a1gyVjRjR2x5WldSZlltOXZiRjltWVd4elpVQTBDZ3B5WldaMWJtUmZaWGh3YVhKbFpGOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3B5WldaMWJtUmZaWGh3YVhKbFpGOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qazRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRk5VUVZSVlUxOVBVRVZPS1NCdmNpQnpaV3htTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvVTFSQlZGVlRYMGxPWDFCU1QwZFNSVk5US1N3Z0lrSnZkVzUwZVNCdWIzUWdjbVZtZFc1a1lXSnNaU0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM1Z1ZEhrZ2JtOTBJSEpsWm5WdVpHRmliR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRveU9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErSUhObGJHWXVaR1ZoWkd4cGJtVXNJQ0pFWldGa2JHbHVaU0J1YjNRZ2VXVjBJSEJoYzNObFpDSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKa1pXRmtiR2x1WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtaV0ZrYkdsdVpTQmxlR2x6ZEhNS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZrYkdsdVpTQnViM1FnZVdWMElIQmhjM05sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTXdNUW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE1nUFNCVlNXNTBOalFvVTFSQlZGVlRYMFZZVUVsU1JVUXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk16QXpMVE13T0FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdVkzSmxZWFJ2Y2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyVnNaaTV5WlhkaGNtUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBVSjVkR1Z6S0dJaVFtOTFiblI1Vm1GMWJIUTZZbTkxYm5SNVgzSmxablZ1WkdWa0lpa3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNekEwQ2lBZ0lDQXZMeUJ5WldObGFYWmxjajF6Wld4bUxtTnlaV0YwYjNJc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amNtVmhkRzl5SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pNd05Rb2dJQ0FnTHk4Z1lXMXZkVzUwUFhObGJHWXVjbVYzWVhKa0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGQyRnlaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYZGhjbVFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpBM0NpQWdJQ0F2THlCdWIzUmxQVUo1ZEdWektHSWlRbTkxYm5SNVZtRjFiSFE2WW05MWJuUjVYM0psWm5WdVpHVmtJaWtzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTWpabU56VTJaVGMwTnprMU5qWXhOelUyWXpjME0yRTJNalptTnpVMlpUYzBOemsxWmpjeU5qVTJOamMxTm1VMk5EWTFOalFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUbTkwWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3pNRE1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek1EWUtJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek1ETXRNekE0Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxelpXeG1MbkpsZDJGeVpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVFubDBaWE1vWWlKQ2IzVnVkSGxXWVhWc2REcGliM1Z1ZEhsZmNtVm1kVzVrWldRaUtTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNamsxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd1pqWXlObVkzTlRabE56UTNPVFZtTnpJMk5UWTJOelUyWlRZME5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldaMWJtUmZaWGh3YVhKbFpGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnlaV1oxYm1SZlpYaHdhWEpsWkY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YUdWc2JHOWZkMjl5YkdRdVkyOXVkSEpoWTNRdVFtOTFiblI1UlhOamNtOTNMbU5oYm1ObGJGOWliM1Z1ZEhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZVzVqWld4ZlltOTFiblI1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTXhOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWpjbVZoZEc5eUxDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQmpZVzVqWld3aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqY21WaGRHOXlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR05oYm1ObGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak14TmdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMzVmliV2x6YzJsdmJsOWpiM1Z1ZENBOVBTQlZTVzUwTmpRb01Da3NJQ0pEWVc1dWIzUWdZMkZ1WTJWc0lIZHBkR2dnYzNWaWJXbHpjMmx2Ym5NaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYzNWaWJXbHpjMmx2Ymw5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRXSnRhWE56YVc5dVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0JqWVc1alpXd2dkMmwwYUNCemRXSnRhWE56YVc5dWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak14TndvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMzUmhkSFZ6SUQwOUlGVkpiblEyTkNoVFZFRlVWVk5mVDFCRlRpa3NJQ0pEWVc0Z2IyNXNlU0JqWVc1alpXd2diM0JsYmlCaWIzVnVkR2xsY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGRIVnpJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU5oYmlCdmJteDVJR05oYm1ObGJDQnZjR1Z1SUdKdmRXNTBhV1Z6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk16RTVDaUFnSUNBdkx5QnpaV3htTG5OMFlYUjFjeUE5SUZWSmJuUTJOQ2hUVkVGVVZWTmZRMEZPUTBWTVRFVkVLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTXlNUzB6TWpZS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtTnlaV0YwYjNJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTmxiR1l1Y21WM1lYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMUNlWFJsY3loaUlrSnZkVzUwZVZaaGRXeDBPbUp2ZFc1MGVWOWpZVzVqWld4c1pXUWlLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG96TWpJS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFhObGJHWXVZM0psWVhSdmNpd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV0YwYjNJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk16SXpDaUFnSUNBdkx5QmhiVzkxYm5ROWMyVnNaaTV5WlhkaGNtUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVjNZWEprSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxkMkZ5WkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek1qVUtJQ0FnSUM4dklHNXZkR1U5UW5sMFpYTW9ZaUpDYjNWdWRIbFdZWFZzZERwaWIzVnVkSGxmWTJGdVkyVnNiR1ZrSWlrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME1qWm1OelUyWlRjME56azFOall4TnpVMll6YzBNMkUyTWpabU56VTJaVGMwTnprMVpqWXpOakUyWlRZek5qVTJZelpqTmpVMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pNeU1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak15TkFvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak15TVMwek1qWUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbU55WldGMGIzSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWE5sYkdZdWNtVjNZWEprTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDFDZVhSbGN5aGlJa0p2ZFc1MGVWWmhkV3gwT21KdmRXNTBlVjlqWVc1alpXeHNaV1FpS1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk16RXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF4TURZeU5tWTNOVFpsTnpRM09UVm1Oak0yTVRabE5qTTJOVFpqTm1NMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YUdWc2JHOWZkMjl5YkdRdVkyOXVkSEpoWTNRdVFtOTFiblI1UlhOamNtOTNMbWRsZEY5aWIzVnVkSGxmYVc1bWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aWIzVnVkSGxmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG96TkRjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WM1lYSmtLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnlaWGRoY21RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVYzWVhKa0lHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTTBPQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWtaV0ZrYkdsdVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVpHVmhaR3hwYm1VaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaR1ZoWkd4cGJtVWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNelE1Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1Mbk4wWVhSMWN5a3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFIxY3lCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek5UQUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWMzVmliV2x6YzJsdmJuTmZjbVZ0WVdsdWFXNW5LU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzVmliV2x6YzJsdmJuTmZjbVZ0WVdsdWFXNW5JR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak0xTVFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV6ZFdKdGFYTnphVzl1WDJOdmRXNTBLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnpkV0p0YVhOemFXOXVYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4xWW0xcGMzTnBiMjVmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNelV5Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1Mblp2ZEdWelgyTnlaV0YwYjNJcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5admRHVnpYMk55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MFpYTmZZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3pOVE1LSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkbTkwWlhOZlpuSmxaV3hoYm1ObGNpa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRtOTBaWE5mWm5KbFpXeGhibU5sY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JsYzE5bWNtVmxiR0Z1WTJWeUlHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTTFOQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWtZVzlmWkdWaFpHeHBibVVwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbVJoYjE5a1pXRmtiR2x1WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtZVzlmWkdWaFpHeHBibVVnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpRMkxUTTFOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WM1lYSmtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1SbFlXUnNhVzVsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuTjBZWFIxY3lrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXpkV0p0YVhOemFXOXVjMTl5WlcxaGFXNXBibWNwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWMzVmliV2x6YzJsdmJsOWpiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTJiM1JsYzE5amNtVmhkRzl5S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuWnZkR1Z6WDJaeVpXVnNZVzVqWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVaR0Z2WDJSbFlXUnNhVzVsS1N3S0lDQWdJQzh2SUNrcENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pNek5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhR1ZzYkc5ZmQyOXliR1F1WTI5dWRISmhZM1F1UW05MWJuUjVSWE5qY205M0xtZGxkRjkyYjNSbGNsOXpkR0YwZFhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmZG05MFpYSmZjM1JoZEhWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPak0xTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpZekNpQWdJQ0F2THlCMmIzUmxaQ0E5SUhObGJHWXVhR0Z6WDNadmRHVmtXM1p2ZEdWeVhRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1oaGMxOTJiM1JsWkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtaGhjMTkyYjNSbFpDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG96TmpRS0lDQWdJQzh2SUdOb2IybGpaU0E5SUhObGJHWXVkbTkwWlY5amFHOXBZMlZiZG05MFpYSmRDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0luWnZkR1ZmWTJodmFXTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MFpWOWphRzlwWTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNelkyQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoMmIzUmxaQ2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk16WTNDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2hqYUc5cFkyVXBMQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pNMk5TMHpOamdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaDJiM1JsWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvWTJodmFXTmxLU3dLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3pOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1obGJHeHZYM2R2Y214a0xtTnZiblJ5WVdOMExrSnZkVzUwZVVWelkzSnZkeTVuWlhSZmQyOXlhMlZ5WDJsdVptOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmQyOXlhMlZ5WDJsdVptODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpjd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek56WUtJQ0FnSUM4dklITjFZbDkwYVcxbElEMGdjMlZzWmk1emRXSnRhWE56YVc5dVgzUnBiV1ZiZDI5eWEyVnlYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luTjFZbTFwYzNOcGIyNWZkR2x0WlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjFZbTFwYzNOcGIyNWZkR2x0WlNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUb3pOemNLSUNBZ0lDOHZJSGRmYzNSaGRIVnpJRDBnYzJWc1ppNTNiM0pyWlhKZmMzUmhkSFZ6VzNkdmNtdGxjbDBLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjNiM0pyWlhKZmMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWQyOXlhMlZ5WDNOMFlYUjFjeUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek56a0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE4xWWw5MGFXMWxLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek9EQUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSGRmYzNSaGRIVnpLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek56Z3RNemd4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jM1ZpWDNScGJXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtIZGZjM1JoZEhWektTd0tJQ0FnSUM4dklDa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzV3ZVRvek56QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0lDWVNCbk4wWVhSMWN3ZGpjbVZoZEc5eURYZHZjbXRsY2w5emRHRjBkWE1HY21WM1lYSmtGWE4xWW0xcGMzTnBiMjV6WDNKbGJXRnBibWx1WncxMmIzUmxjMTlqY21WaGRHOXlFSFp2ZEdWelgyWnlaV1ZzWVc1alpYSU1aR0Z2WDJSbFlXUnNhVzVsRUhOMVltMXBjM05wYjI1ZlkyOTFiblFJWkdWaFpHeHBibVVTWkdsemNIVjBaVjltY21WbGJHRnVZMlZ5Q1doaGMxOTJiM1JsWkFRVkgzeDFFMkZ3Y0hKdmRtVmtYMlp5WldWc1lXNWpaWElQYzNWaWJXbHpjMmx2Ymw5MGFXMWxDM1p2ZEdWZlkyaHZhV05sRDIxaGVGOXpkV0p0YVhOemFXOXVjd2wzYjNKclgyaGhjMmd4R0VBQU1Da3lBMmNySW1jbkNTSm5Kd2NpWnlnaVp5Y1FJbWNuQkNKbkp3Z2laeWNOTWdObkp3VWlaeWNHSW1jbkNqSURaekViUVFDQ2dBUVNJamp5TmhvQWpnRUFhakVaRkVReEdFU0NEUVQ1TytQOUJIdjFaZklFb1JsVXB3UmE1MmZJQkpyK21zb0VhVVNwM2dUdmhpbXhCRmZXU3hjRSt5L29vd1RubUMycUJMVDAvSWdFMjNVS0RBUnNLMTVFTmhvQWpnMEFGQURVQVhjQjh3Sk5BcHNESmdRSEJITUU0d1ZMQlpZRnRnQXhHU01TTVJnUVJFSUFsekVaRkRFWUZCQkRNUllqQ1VrNEVDTVNSRFlhQVVrVmdRZ1NSQmMyR2dKSkZZRUlFa1FYU3dJNEJ6SUtFa1JQQWpnSVNZSEFoRDBQUkRJSGdaQWNDRXNEREVSTEFVUkxBWUV5RGtRcE1RQm5LMHhuSndsUEFtY25CeUpuS0NKbkp4QkxBV2NuQkV4bkp3Z2laeWNOTWdObkp3VWlaeWNHSW1jbkNqSURaNEFVRlI5OGRRQU9ZbTkxYm5SNVgyTnlaV0YwWldTd0kwTXhBQ2NSZ0FCbU1RQW5EaUptTVFBcUltWXhBQ2NMSW1ZeEFDY1BJbWFBRGhVZmZIVUFDRzl3ZEdWa1gybHVzQ05ETmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtraVdTUUlTd0VWRWtSWEFnQWlLR1ZFUVFBSklpaGxSQ01TUVFCdkkwUXlCeUluQ1dWRURrUWlKd1JsUkVReEFDSXBaVVFUUkVzQlNSVWxFa1JMQVJVbEVrUXhBQ0lxWTBRVVJERUFKeEZQQW1ZeEFDY09NZ2RtTVFBcUkyWWlKd2hsUkNNSUp3aE1aeUlvWlVSQUFBTW9JMmVBRkJVZmZIVUFEbmR2Y210ZmMzVmliV2wwZEdWa3NDTkRJa0wvampZYUFVa1ZKUkpFTVFBaUtXVkVFa1FpS0dWRUl4SkVTU0lxWTBRakVrUkpLaVJtSncxTEFXY29KR2V4SWl0bFJJQWZRbTkxYm5SNVZtRjFiSFE2YzNWaWJXbHpjMmx2Ymw5aGNIQnliM1psWkxJRnNnaXlCeU95RUNLeUFiT0FHUlVmZkhVQUUzTjFZbTFwYzNOcGIyNWZZWEJ3Y205MlpXU3dJME0yR2dGSEFoVWxFa1F4QUNJcFpVUVNSQ0lvWlVRakVrUWlLbU5FSXhKRUlpY0VaVVFqQ1NjRVN3Rm5RQUFtS29FRFppaUJCR2VBR1JVZmZIVUFFM04xWW0xcGMzTnBiMjVmY21WcVpXTjBaV1N3STBNcUltWkMvOXd4QUNJcVkwU0JBeEpFSWljRVpVUVVSQ0lvWlVTQkJCSkVLSUVEWnpJSGdZREdDZ2duQjB4bkp3VWlaeWNHSW1jbkNqRUFaNEFVRlI5OGRRQU9aR2x6Y0hWMFpWOXlZV2x6WldTd0kwTTJHZ0ZKRllFSUVrUVhTU0lvWlVTQkF4SkVNZ2NpSndkbFJBeEVJeEpKUUFBSFN3RWtFa0VBWGlORU1RQWlLV1ZFRTBReEFDSW5DbVZFRTBReEFDSW5DMk5FRkVReEFDY0xJMll4QUNjUFN3Tm1TVUVBSXlJbkJXVkVJd2duQlV4bmdCTVZIM3gxQUExa1lXOWZkbTkwWlY5allYTjBzQ05ESWljR1pVUWpDQ2NHVEdkQy85b2lRditmSWlobFJJRURFa1F5QnlJbkIyVkVEMFFpSndabFJDSW5CV1ZFRFVFQVppZ2taN0VpSndwbFJDSXJaVVNBSTBKdmRXNTBlVlpoZFd4ME9tUmhiMTl5WlhOdmJIWmxaRjltY21WbGJHRnVZMlZ5c2dXeUNMSUhJN0lRSXJJQnM0QWVBQnhrWVc5ZmNtVnpiMngyWldSZlpuSmxaV3hoYm1ObGNsOTNhVzV6Snd4TVVMQWpReWlCQkdleElpbGxSQ0lyWlVTQUlFSnZkVzUwZVZaaGRXeDBPbVJoYjE5eVpYTnZiSFpsWkY5amNtVmhkRzl5c2dXeUNMSUhJN0lRSXJJQnM0QWJBQmxrWVc5ZmNtVnpiMngyWldSZlkzSmxZWFJ2Y2w5M2FXNXpRditkTVFBaUttTkVnUU1TUkNJbkJHVkVGRVFpS0dWRWdRUVNSQ2lCQldleElpbGxSQ0lyWlVTQUhFSnZkVzUwZVZaaGRXeDBPbVp5WldWc1lXNWpaWEpmYkdWMFoyK3lCYklJc2djanNoQWlzZ0d6Z0JZVkgzeDFBQkJtY21WbGJHRnVZMlZ5WDJ4bGRHZHZzQ05ESWlobFJFRUFDU0lvWlVRakVrRUFYQ05FTWdjaUp3bGxSQTFFS0lFRVo3RWlLV1ZFSWl0bFJJQWJRbTkxYm5SNVZtRjFiSFE2WW05MWJuUjVYM0psWm5WdVpHVmtzZ1d5Q0xJSEk3SVFJcklCczRBVkZSOThkUUFQWW05MWJuUjVYM0psWm5WdVpHVmtzQ05ESWtML29URUFJaWxsUkJKRUlpY0laVVFVUkNJb1pVUVVSQ2lCQldleElpbGxSQ0lyWlVTQUhFSnZkVzUwZVZaaGRXeDBPbUp2ZFc1MGVWOWpZVzVqWld4c1pXU3lCYklJc2djanNoQWlzZ0d6Z0JZVkgzeDFBQkJpYjNWdWRIbGZZMkZ1WTJWc2JHVmtzQ05ESWl0bFJCWWlKd2xsUkJZaUtHVkVGaUluQkdWRUZpSW5DR1ZFRmlJbkJXVkVGaUluQm1WRUZpSW5CMlZFRms4SFR3ZFFUd1pRVHdWUVR3UlFUd05RVHdKUVRGQW5ERXhRc0NORE5ob0JTUlVsRWtSSklpY0xZMFJNSWljUFkwUk1Ga3dXVUNjTVRGQ3dJME0yR2dGSkZTVVNSRWtpSnc1alJFd2lLbU5FVEJaTUZsQW5ERXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
