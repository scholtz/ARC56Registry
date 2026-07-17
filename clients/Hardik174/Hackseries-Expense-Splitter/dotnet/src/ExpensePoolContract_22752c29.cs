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

namespace Arc56.Generated.Hardik174.Hackseries_Expense_Splitter.ExpensePoolContract_22752c29
{


    public class ExpensePoolContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ExpensePoolContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovalKey : AVMObjectType
            {
                public ulong ExpenseId { get; set; }

                public Algorand.Address Member { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpenseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpenseId.From(ExpenseId);
                    ret.AddRange(vExpenseId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vMember.From(Member);
                    ret.AddRange(vMember.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApprovalKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovalKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpenseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpenseId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpenseId = vExpenseId.ToValue();
                    if (valueExpenseId is ulong vExpenseIdValue) { ret.ExpenseId = vExpenseIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vMember.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMember = vMember.ToValue();
                    if (valueMember is Algorand.Address vMemberValue) { ret.Member = vMemberValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovalKey);
                }
                public bool Equals(ApprovalKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovalKey left, ApprovalKey right)
                {
                    return EqualityComparer<ApprovalKey>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovalKey left, ApprovalKey right)
                {
                    return !(left == right);
                }

            }

            public class ExpenseRecord : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public ulong Amount { get; set; }

                public string Description { get; set; }

                public ulong ApprovalCount { get; set; }

                public bool Settled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovalCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApprovalCount.From(ApprovalCount);
                    ret.AddRange(vApprovalCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSettled.From(Settled);
                    ret.AddRange(vSettled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ExpenseRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ExpenseRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovalCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApprovalCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApprovalCount = vApprovalCount.ToValue();
                    if (valueApprovalCount is ulong vApprovalCountValue) { ret.ApprovalCount = vApprovalCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettled = vSettled.ToValue();
                    if (valueSettled is bool vSettledValue) { ret.Settled = vSettledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ExpenseRecord);
                }
                public bool Equals(ExpenseRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ExpenseRecord left, ExpenseRecord right)
                {
                    return EqualityComparer<ExpenseRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ExpenseRecord left, ExpenseRecord right)
                {
                    return !(left == right);
                }

            }

            public class GetGroupInfoReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetGroupInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetGroupInfoReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetGroupInfoReturn);
                }
                public bool Equals(GetGroupInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetGroupInfoReturn left, GetGroupInfoReturn right)
                {
                    return EqualityComparer<GetGroupInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetGroupInfoReturn left, GetGroupInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="group_name"> </param>
        /// <param name="member_addresses"> </param>
        /// <param name="approval_threshold"> </param>
        public async Task CreateGroup(string group_name, Algorand.Address[] member_addresses, ulong approval_threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 129, 204, 151 };
            var group_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); group_nameAbi.From(group_name);
            var member_addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); member_addressesAbi.From(member_addresses);
            var approval_thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_thresholdAbi.From(approval_threshold);

            var result = await base.CallApp(new List<object> { abiHandle, group_nameAbi, member_addressesAbi, approval_thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateGroup_Transactions(string group_name, Algorand.Address[] member_addresses, ulong approval_threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 129, 204, 151 };
            var group_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); group_nameAbi.From(group_name);
            var member_addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); member_addressesAbi.From(member_addresses);
            var approval_thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_thresholdAbi.From(approval_threshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, group_nameAbi, member_addressesAbi, approval_thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member_addresses"> </param>
        public async Task RegisterMembers(Algorand.Address[] member_addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 158, 18, 181 };
            var member_addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); member_addressesAbi.From(member_addresses);

            var result = await base.CallApp(new List<object> { abiHandle, member_addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterMembers_Transactions(Algorand.Address[] member_addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 158, 18, 181 };
            var member_addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); member_addressesAbi.From(member_addresses);

            return await base.MakeTransactionList(new List<object> { abiHandle, member_addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_txn"> </param>
        public async Task DepositToPool(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 131, 190, 68, 73 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositToPool_Transactions(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 131, 190, 68, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="description"> </param>
        public async Task AddExpense(ulong amount, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 120, 13, 13 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddExpense_Transactions(ulong amount, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 120, 13, 13 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expense_id"> </param>
        public async Task ApproveExpense(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 156, 116, 26 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            var result = await base.CallApp(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveExpense_Transactions(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 156, 116, 26 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expense_id"> </param>
        public async Task SettleExpense(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 1, 139, 253 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            var result = await base.CallApp(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SettleExpense_Transactions(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 1, 139, 253 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetGroupInfoReturn> GetGroupInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 76, 148, 232 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetGroupInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGroupInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 76, 148, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expense_id"> </param>
        public async Task<Structs.ExpenseRecord> GetExpenseInfo(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 51, 233, 140 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            var result = await base.SimApp(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ExpenseRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetExpenseInfo_Transactions(ulong expense_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 51, 233, 140 };
            var expense_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expense_idAbi.From(expense_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, expense_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXhwZW5zZVBvb2xDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcHByb3ZhbEtleSI6W3sibmFtZSI6ImV4cGVuc2VfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWVtYmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkV4cGVuc2VSZWNvcmQiOlt7Im5hbWUiOiJwYXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlc2NyaXB0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFwcHJvdmFsX2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNldHRsZWQiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0R3JvdXBJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2dyb3VwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imdyb3VwX25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlcl9hZGRyZXNzZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFsX3RocmVzaG9sZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3Rlcl9tZW1iZXJzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlcl9hZGRyZXNzZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdF90b19wb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX2V4cGVuc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2V4cGVuc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZW5zZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXR0bGVfZXhwZW5zZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlbnNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncm91cF9pbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldEdyb3VwSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2V4cGVuc2VfaW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlbnNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxzdHJpbmcsdWludDY0LGJvb2wpIiwic3RydWN0IjoiRXhwZW5zZVJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjUsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2NThdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGFwcHJvdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3XSwiZXJyb3JNZXNzYWdlIjoiYW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzcsNjgyLDc2NCw5NjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFwcHJvdmFsX3RocmVzaG9sZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDYsNzczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5leHBlbnNlX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXhwZW5zZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ncm91cF9uYW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Myw3NjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1lbWJlcl9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1lbWJlcnNfaW5pdGlhbGl6ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxLDc2OCw5NjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBvb2xfYmFsYW5jZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDddLCJlcnJvck1lc3NhZ2UiOiJjbG9zZSByZW1haW5kZXIgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzJdLCJlcnJvck1lc3NhZ2UiOiJkZXBvc2l0IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDFdLCJlcnJvck1lc3NhZ2UiOiJkZXNjcmlwdGlvbiByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NV0sImVycm9yTWVzc2FnZSI6ImR1cGxpY2F0ZSBtZW1iZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDIsOTUxXSwiZXJyb3JNZXNzYWdlIjoiZXhwZW5zZSBhbHJlYWR5IHNldHRsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjgsNzM2LDgzMV0sImVycm9yTWVzc2FnZSI6ImV4cGVuc2Ugbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI4LDQwOCw0ODksNjEwLDcyMSw3NTBdLCJlcnJvck1lc3NhZ2UiOiJncm91cCBub3QgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTVdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzOCw2NjUsNzAzLDgzNSw4NDAsODY4LDg3NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTczXSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IHBvb2wgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNywyNDQsMzEwLDQ3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NSwzMjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzUsNDgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2Myw0NjUsNjAyLDcxNCw4MjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzBdLCJlcnJvck1lc3NhZ2UiOiJtZW1iZXJzIG5vdCBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NywzMzNdLCJlcnJvck1lc3NhZ2UiOiJtZW1iZXJzIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMyXSwiZXJyb3JNZXNzYWdlIjoib25seSBjcmVhdG9yIGNhbiByZWdpc3RlciBtZW1iZXJzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM5XSwiZXJyb3JNZXNzYWdlIjoib25seSBtZW1iZXJzIGNhbiBjYWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBtdXN0IGdvIHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMF0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQwXSwiZXJyb3JNZXNzYWdlIjoicmVrZXkgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzhdLCJlcnJvck1lc3NhZ2UiOiJ0aHJlc2hvbGQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4M10sImVycm9yTWVzc2FnZSI6InRocmVzaG9sZCB0b28gaGlnaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWTNKbFlYUnZjaUlnSW5CdmIyeGZZbUZzWVc1alpTSWdJbUZ3Y0hKdmRtRnNYM1JvY21WemFHOXNaQ0lnTUhnMk5UYzROekEyTlRabE56TTJOVFZtSUNKdFpXMWlaWEpmWTI5MWJuUWlJQ0psZUhCbGJuTmxYMk52ZFc1MElpQWliV1Z0WW1WeWMxOXBibWwwYVdGc2FYcGxaQ0lnSW1keWIzVndYMjVoYldVaUlEQjRObVEyTlRaa05qSTJOVGN5TldZZ01IZ3dNRE16SURCNE5qRTNNRGN3TnpJMlpqYzJOakUyWXpWbUlEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCamJHRnpjeUJGZUhCbGJuTmxVRzl2YkVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFekNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9HTTVaVEV5WWpVZ01IZzRNMkpsTkRRME9TQXdlR00xTnpnd1pEQmtJREI0TkdZNVl6YzBNV0VnTUhobE16QXhPR0ptWkNBd2VETTBOR001TkdVNElEQjROakF6TTJVNU9HTWdMeThnYldWMGFHOWtJQ0p5WldkcGMzUmxjbDl0WlcxaVpYSnpLR0ZrWkhKbGMzTmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmtaWEJ2YzJsMFgzUnZYM0J2YjJ3b2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjlsZUhCbGJuTmxLSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhCd2NtOTJaVjlsZUhCbGJuTmxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUjBiR1ZmWlhod1pXNXpaU2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMmR5YjNWd1gybHVabThvS1NoemRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYMlY0Y0dWdWMyVmZhVzVtYnloMWFXNTBOalFwS0dGa1pISmxjM01zZFdsdWREWTBMSE4wY21sdVp5eDFhVzUwTmpRc1ltOXZiQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2w5dFpXMWlaWEp6SUdSbGNHOXphWFJmZEc5ZmNHOXZiQ0JoWkdSZlpYaHdaVzV6WlNCaGNIQnliM1psWDJWNGNHVnVjMlVnYzJWMGRHeGxYMlY0Y0dWdWMyVWdaMlYwWDJkeWIzVndYMmx1Wm04Z1oyVjBYMlY0Y0dWdWMyVmZhVzVtYndvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRVY0Y0dWdWMyVlFiMjlzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTTVPREZqWXprM0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyZHliM1Z3S0hOMGNtbHVaeXhoWkdSeVpYTnpXMTBzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZlozSnZkWEFLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNTBjbUZqZEY5dFlXbHVMbU52Ym5SeVlXTjBMa1Y0Y0dWdWMyVlFiMjlzUTI5dWRISmhZM1F1WTNKbFlYUmxYMmR5YjNWd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFgyZHliM1Z3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajQrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnWVhOelpYSjBJRzFsYldKbGNsOWhaR1J5WlhOelpYTXViR1Z1WjNSb0lENGdNQ3dnSW0xbGJXSmxjbk1nY21WeGRXbHlaV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzFsYldKbGNuTWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCelpXeG1MbU55WldGMGIzSXVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJ6Wld4bUxtZHliM1Z3WDI1aGJXVXVkbUZzZFdVZ1BTQm5jbTkxY0Y5dVlXMWxDaUFnSUNCaWVYUmxZeUEzSUM4dklDSm5jbTkxY0Y5dVlXMWxJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUdGemMyVnlkQ0JoY0hCeWIzWmhiRjkwYUhKbGMyaHZiR1FnUGlBd0xDQWlkR2h5WlhOb2IyeGtJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCMGFISmxjMmh2YkdRZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEJ5YjNaaGJGOTBhSEpsYzJodmJHUWdQRDBnZFc1cGNYVmxYMjFsYldKbGNuTXNJQ0owYUhKbGMyaHZiR1FnZEc5dklHaHBaMmdpQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwYUhKbGMyaHZiR1FnZEc5dklHaHBaMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QnpaV3htTG0xbGJXSmxjbDlqYjNWdWRDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJXVnRZbVZ5WDJOdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z2MyVnNaaTV0WlcxaVpYSnpYMmx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p0WlcxaVpYSnpYMmx1YVhScFlXeHBlbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1poYkY5MGFISmxjMmh2YkdRdWRtRnNkV1VnUFNCaGNIQnliM1poYkY5MGFISmxjMmh2YkdRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Gd2NISnZkbUZzWDNSb2NtVnphRzlzWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnYzJWc1ppNXdiMjlzWDJKaGJHRnVZMlV1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkJ2YjJ4ZlltRnNZVzVqWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJSE5sYkdZdVpYaHdaVzV6WlY5amIzVnVkQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWGh3Wlc1elpWOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVkSEpoWTNSZmJXRnBiaTVqYjI1MGNtRmpkQzVGZUhCbGJuTmxVRzl2YkVOdmJuUnlZV04wTG5KbFoybHpkR1Z5WDIxbGJXSmxjbk5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5dFpXMWlaWEp6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0K0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG8wT0FvZ0lDQWdMeThnWTNKbFlYUnZjbDkyWVd4MVpTd2dZM0psWVhSdmNsOWxlR2x6ZEhNZ1BTQnpaV3htTG1OeVpXRjBiM0l1YldGNVltVW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCamNtVmhkRzl5WDJWNGFYTjBjeXdnSW1keWIzVndJRzV2ZENCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCbmNtOTFjQ0J1YjNRZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXNJQ0p2Ym14NUlHTnlaV0YwYjNJZ1kyRnVJSEpsWjJsemRHVnlJRzFsYldKbGNuTWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdjbVZuYVhOMFpYSWdiV1Z0WW1WeWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0J0WlcxaVpYSmZZV1JrY21WemMyVnpMbXhsYm1kMGFDQStJREFzSUNKdFpXMWlaWEp6SUhKbGNYVnBjbVZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRzFsYldKbGNuTWdjbVZ4ZFdseVpXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncHlaV2RwYzNSbGNsOXRaVzFpWlhKelgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5Qm1iM0lnYldWdFltVnlJR2x1SUcxbGJXSmxjbDloWkdSeVpYTnpaWE02Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnlaV2RwYzNSbGNsOXRaVzFpWlhKelgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCaGMzTmxjblFnYldWdFltVnlYMkZqWTI5MWJuUWdibTkwSUdsdUlITmxiR1l1YldWdFltVnljeXdnSW1SMWNHeHBZMkYwWlNCdFpXMWlaWElpQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0Tm1RMk5UWmtOakkyTlRjeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmtkWEJzYVdOaGRHVWdiV1Z0WW1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUhObGJHWXViV1Z0WW1WeWMxdHRaVzFpWlhKZllXTmpiM1Z1ZEYwZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklITmxiR1l1YldWdFltVnlYMk52ZFc1MExuWmhiSFZsSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xbGJXSmxjbDlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WlcxaVpYSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJXVnRZbVZ5WDJOdmRXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2NtVm5hWE4wWlhKZmJXVnRZbVZ5YzE5bWIzSmZhR1ZoWkdWeVFESUtDbkpsWjJsemRHVnlYMjFsYldKbGNuTmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJSE5sYkdZdWJXVnRZbVZ5YzE5cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXVnRZbVZ5YzE5cGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1ZEhKaFkzUmZiV0ZwYmk1amIyNTBjbUZqZEM1RmVIQmxibk5sVUc5dmJFTnZiblJ5WVdOMExtUmxjRzl6YVhSZmRHOWZjRzl2YkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjRzl6YVhSZmRHOWZjRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z1kzSmxZWFJ2Y2w5MllXeDFaU3dnWTNKbFlYUnZjbDlsZUdsemRITWdQU0J6Wld4bUxtTnlaV0YwYjNJdWJXRjVZbVVvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnWVhOelpYSjBJR055WldGMGIzSmZaWGhwYzNSekxDQWlaM0p2ZFhBZ2JtOTBJR2x1YVhScFlXeHBlbVZrSWdvZ0lDQWdZWE56WlhKMElDOHZJR2R5YjNWd0lHNXZkQ0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVEE0Q2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmJXVnRZbVZ5S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZmJXVnRZbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGxmZEhodUxuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlMQ0FpY0dGNWJXVnVkQ0J6Wlc1a1pYSWdiV2x6YldGMFkyZ2lDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx0Wlc1MElITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJ3WVhsZmRIaHVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk1URXhMVEV4TXdvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbGZkSGh1TG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSndZWGx0Wlc1MElHMTFjM1FnWjI4Z2RHOGdZWEJ3SWdvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVcxbGJuUWdiWFZ6ZENCbmJ5QjBieUJoY0hBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVZVzF2ZFc1MElENGdNQ3dnSW1SbGNHOXphWFFnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCa1pYQnZjMmwwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVjkwZUc0dWNtVnJaWGxmZEc4Z1BUMGdSMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeXdnSW5KbGEyVjVJRzV2ZENCaGJHeHZkMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGSmxhMlY1Vkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCeVpXdGxlU0J1YjNRZ1lXeHNiM2RsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJ3WVhsZmRIaHVMbU5zYjNObFgzSmxiV0ZwYm1SbGNsOTBieUE5UFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkRiRzl6WlZKbGJXRnBibVJsY2xSdkNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1UWXRNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVWOTBlRzR1WTJ4dmMyVmZjbVZ0WVdsdVpHVnlYM1J2SUQwOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pqYkc5elpTQnlaVzFoYVc1a1pYSWdibTkwSUdGc2JHOTNaV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMnh2YzJVZ2NtVnRZV2x1WkdWeUlHNXZkQ0JoYkd4dmQyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1qQUtJQ0FnSUM4dklITmxiR1l1Y0c5dmJGOWlZV3hoYm1ObExuWmhiSFZsSUNzOUlIQmhlVjkwZUc0dVlXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljRzl2YkY5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnZiMnhmWW1Gc1lXNWpaU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CdmIyeGZZbUZzWVc1alpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWRISmhZM1JmYldGcGJpNWpiMjUwY21GamRDNUZlSEJsYm5ObFVHOXZiRU52Ym5SeVlXTjBMbUZrWkY5bGVIQmxibk5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYMlY0Y0dWdWMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJR055WldGMGIzSmZkbUZzZFdVc0lHTnlaV0YwYjNKZlpYaHBjM1J6SUQwZ2MyVnNaaTVqY21WaGRHOXlMbTFoZVdKbEtDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCamNtVmhkRzl5WDJWNGFYTjBjeXdnSW1keWIzVndJRzV2ZENCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCbmNtOTFjQ0J1YjNRZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z2MyVnNaaTVmWVhOelpYSjBYMjFsYldKbGNpaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMjFsYldKbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnTUN3Z0ltRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCaGMzTmxjblFnWkdWelkzSnBjSFJwYjI0dVlubDBaWE11YkdWdVozUm9JRDRnTUN3Z0ltUmxjMk55YVhCMGFXOXVJSEpsY1hWcGNtVmtJZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdSbGMyTnlhWEIwYVc5dUlISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG94TXpBS0lDQWdJQzh2SUdWNGNHVnVjMlZmYVdRZ1BTQnpaV3htTG1WNGNHVnVjMlZmWTI5MWJuUXVkbUZzZFdVZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbGVIQmxibk5sWDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1WNGNHVnVjMlZmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJSE5sYkdZdVpYaHdaVzV6WlY5amIzVnVkQzUyWVd4MVpTQTlJR1Y0Y0dWdWMyVmZhV1FLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbVY0Y0dWdWMyVmZZMjkxYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2NHRjVaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXpNeTB4TXprS0lDQWdJQzh2SUhObGJHWXVaWGh3Wlc1elpYTmJaWGh3Wlc1elpWOXBaRjBnUFNCRmVIQmxibk5sVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJqMWtaWE5qY21sd2RHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkY5amIzVnVkRDFWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ2MyVjBkR3hsWkQxR1lXeHpaU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3TXpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCaGNIQnliM1poYkY5amIzVnVkRDFWU1c1ME5qUW9NU2tzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UTXpMVEV6T1FvZ0lDQWdMeThnYzJWc1ppNWxlSEJsYm5ObGMxdGxlSEJsYm5ObFgybGtYU0E5SUVWNGNHVnVjMlZTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdSbGMyTnlhWEIwYVc5dVBXUmxjMk55YVhCMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzWDJOdmRXNTBQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCelpYUjBiR1ZrUFVaaGJITmxMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnYzJWc1ppNWxlSEJsYm5ObGMxdGxlSEJsYm5ObFgybGtYU0E5SUVWNGNHVnVjMlZTWldOdmNtUW9DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk5UYzROekEyTlRabE56TTJOVFZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFek15MHhNemtLSUNBZ0lDOHZJSE5sYkdZdVpYaHdaVzV6WlhOYlpYaHdaVzV6WlY5cFpGMGdQU0JGZUhCbGJuTmxVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JrWlhOamNtbHdkR2x2Ymoxa1pYTmpjbWx3ZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCeWIzWmhiRjlqYjNWdWREMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnYzJWMGRHeGxaRDFHWVd4elpTd0tJQ0FnSUM4dklDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFME1Rb2dJQ0FnTHk4Z2MyVnNaaTVoY0hCeWIzWmhiSE5iUVhCd2NtOTJZV3hMWlhrb1pYaHdaVzV6WlY5cFpEMWxlSEJsYm5ObFgybGtMQ0J0WlcxaVpYSTlWSGh1TG5ObGJtUmxjaWxkSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE5qRTNNRGN3TnpJMlpqYzJOakUyWXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdhV1lnYzJWc1ppNWhjSEJ5YjNaaGJGOTBhSEpsYzJodmJHUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRndjSEp2ZG1Gc1gzUm9jbVZ6YUc5c1pDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoY0hCeWIzWmhiRjkwYUhKbGMyaHZiR1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdGa1pGOWxlSEJsYm5ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVFEwQ2lBZ0lDQXZMeUJsZUhCbGJuTmxJRDBnYzJWc1ppNWxlSEJsYm5ObGMxdGxlSEJsYm5ObFgybGtYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWGh3Wlc1elpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJSE5sYkdZdVgyTnZiWEJzWlhSbFgyVjRjR1Z1YzJVb1pYaHdaVzV6WlY5cFpDd2daWGh3Wlc1elpTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5amIyMXdiR1YwWlY5bGVIQmxibk5sQ2lBZ0lDQndiM0FLQ21Ga1pGOWxlSEJsYm5ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakV5TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjUwY21GamRGOXRZV2x1TG1OdmJuUnlZV04wTGtWNGNHVnVjMlZRYjI5c1EyOXVkSEpoWTNRdVlYQndjbTkyWlY5bGVIQmxibk5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlY5bGVIQmxibk5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJqY21WaGRHOXlYM1poYkhWbExDQmpjbVZoZEc5eVgyVjRhWE4wY3lBOUlITmxiR1l1WTNKbFlYUnZjaTV0WVhsaVpTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmhjM05sY25RZ1kzSmxZWFJ2Y2w5bGVHbHpkSE1zSUNKbmNtOTFjQ0J1YjNRZ2FXNXBkR2xoYkdsNlpXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1ozSnZkWEFnYm05MElHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjl0WlcxaVpYSW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDJGemMyVnlkRjl0WlcxaVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGNHVnVjMlZmYVdRZ2FXNGdjMlZzWmk1bGVIQmxibk5sY3l3Z0ltVjRjR1Z1YzJVZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTFOemczTURZMU5tVTNNelkxTldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbGJuTmxJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QmxlSEJsYm5ObElEMGdjMlZzWmk1bGVIQmxibk5sYzF0bGVIQmxibk5sWDJsa1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5UTXRNVFUwQ2lBZ0lDQXZMeUJsZUhCbGJuTmxJRDBnYzJWc1ppNWxlSEJsYm5ObGMxdGxlSEJsYm5ObFgybGtYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdaWGh3Wlc1elpTNXpaWFIwYkdWa0xDQWlaWGh3Wlc1elpTQmhiSEpsWVdSNUlITmxkSFJzWldRaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdWNGNHVnVjMlV1YzJWMGRHeGxaQ3dnSW1WNGNHVnVjMlVnWVd4eVpXRmtlU0J6WlhSMGJHVmtJZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVnVjMlVnWVd4eVpXRmtlU0J6WlhSMGJHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5UWUtJQ0FnSUM4dklHRndjSEp2ZG1Gc1gydGxlU0E5SUVGd2NISnZkbUZzUzJWNUtHVjRjR1Z1YzJWZmFXUTlaWGh3Wlc1elpWOXBaQ3dnYldWdFltVnlQVlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRVM0NpQWdJQ0F2THlCaGNIQnliM1poYkY5eVpYTjFiSFFnUFNCelpXeG1MbUZ3Y0hKdmRtRnNjeTV0WVhsaVpTaGhjSEJ5YjNaaGJGOXJaWGtwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURZeE56QTNNRGN5Tm1ZM05qWXhObU0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UVTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR0ZzY21WaFpIbGZZWEJ3Y205MlpXUXNJQ0poYkhKbFlXUjVJR0Z3Y0hKdmRtVmtJZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGc2NtVmhaSGtnWVhCd2NtOTJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1poYkhOYllYQndjbTkyWVd4ZmEyVjVYU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakUyTWdvZ0lDQWdMeThnWlhod1pXNXpaUzVoY0hCeWIzWmhiRjlqYjNWdWRDQXJQU0F4Q2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhKbGNHeGhZMlV5SURReUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnYVdZZ1pYaHdaVzV6WlM1aGNIQnliM1poYkY5amIzVnVkQ0ErUFNCelpXeG1MbUZ3Y0hKdmRtRnNYM1JvY21WemFHOXNaQzUyWVd4MVpUb0tJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhCd2NtOTJZV3hmZEdoeVpYTm9iMnhrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjSEp2ZG1Gc1gzUm9jbVZ6YUc5c1pDQmxlR2x6ZEhNS0lDQWdJRDQ5Q2lBZ0lDQmllaUJoY0hCeWIzWmxYMlY0Y0dWdWMyVmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJOUW9nSUNBZ0x5OGdjMlZzWmk1ZlkyOXRjR3hsZEdWZlpYaHdaVzV6WlNobGVIQmxibk5sWDJsa0xDQmxlSEJsYm5ObEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUY5amIyMXdiR1YwWlY5bGVIQmxibk5sQ2lBZ0lDQndiM0FLQ21Gd2NISnZkbVZmWlhod1pXNXpaVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUZ3Y0hKdmRtVmZaWGh3Wlc1elpWOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdaWGh3Wlc1elpTNWhjSEJ5YjNaaGJGOWpiM1Z1ZENBclBTQXhDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBME1nb2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOXlaWEJzWVdObElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlJR0Z3Y0hKdmRtVmZaWGh3Wlc1elpWOWhablJsY2w5cFpsOWxiSE5sUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1ZEhKaFkzUmZiV0ZwYmk1amIyNTBjbUZqZEM1RmVIQmxibk5sVUc5dmJFTnZiblJ5WVdOMExuTmxkSFJzWlY5bGVIQmxibk5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBkR3hsWDJWNGNHVnVjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJqY21WaGRHOXlYM1poYkhWbExDQmpjbVZoZEc5eVgyVjRhWE4wY3lBOUlITmxiR1l1WTNKbFlYUnZjaTV0WVhsaVpTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmhjM05sY25RZ1kzSmxZWFJ2Y2w5bGVHbHpkSE1zSUNKbmNtOTFjQ0J1YjNRZ2FXNXBkR2xoYkdsNlpXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1ozSnZkWEFnYm05MElHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjl0WlcxaVpYSW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDJGemMyVnlkRjl0WlcxaVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFM05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGNHVnVjMlZmYVdRZ2FXNGdjMlZzWmk1bGVIQmxibk5sY3l3Z0ltVjRjR1Z1YzJVZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5qVTNPRGN3TmpVMlpUY3pOalUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1Z1YzJVZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUdWNGNHVnVjMlVnUFNCelpXeG1MbVY0Y0dWdWMyVnpXMlY0Y0dWdWMyVmZhV1JkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hOellLSUNBZ0lDOHZJSE5sYkdZdVgyTnZiWEJzWlhSbFgyVjRjR1Z1YzJVb1pYaHdaVzV6WlY5cFpDd2daWGh3Wlc1elpTa0tJQ0FnSUdOaGJHeHpkV0lnWDJOdmJYQnNaWFJsWDJWNGNHVnVjMlVLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuUnlZV04wWDIxaGFXNHVZMjl1ZEhKaFkzUXVSWGh3Wlc1elpWQnZiMnhEYjI1MGNtRmpkQzVuWlhSZlozSnZkWEJmYVc1bWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5bmNtOTFjRjlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUdOeVpXRjBiM0pmZG1Gc2RXVXNJR055WldGMGIzSmZaWGhwYzNSeklEMGdjMlZzWmk1amNtVmhkRzl5TG0xaGVXSmxLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpjbVZoZEc5eVgyVjRhWE4wY3l3Z0ltZHliM1Z3SUc1dmRDQnBibWwwYVdGc2FYcGxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm5jbTkxY0NCdWIzUWdhVzVwZEdsaGJHbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdjMlZzWmk1bmNtOTFjRjl1WVcxbExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbWR5YjNWd1gyNWhiV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVozSnZkWEJmYm1GdFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakU0TXdvZ0lDQWdMeThnYzJWc1ppNXRaVzFpWlhKZlkyOTFiblF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWJXVnRZbVZ5WDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xbGJXSmxjbDlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnYzJWc1ppNWhjSEJ5YjNaaGJGOTBhSEpsYzJodmJHUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhCd2NtOTJZV3hmZEdoeVpYTm9iMnhrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjSEp2ZG1Gc1gzUm9jbVZ6YUc5c1pDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakU0TlFvZ0lDQWdMeThnYzJWc1ppNXdiMjlzWDJKaGJHRnVZMlV1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNHOXZiRjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CdmIyeGZZbUZzWVc1alpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPakU0TmdvZ0lDQWdMeThnYzJWc1ppNWxlSEJsYm5ObFgyTnZkVzUwTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltVjRjR1Z1YzJWZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYaHdaVzV6WlY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01qSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1MGNtRmpkRjl0WVdsdUxtTnZiblJ5WVdOMExrVjRjR1Z1YzJWUWIyOXNRMjl1ZEhKaFkzUXVaMlYwWDJWNGNHVnVjMlZmYVc1bWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5bGVIQmxibk5sWDJsdVptODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE9Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEY5dFlXbHVMMk52Ym5SeVlXTjBMbkI1T2pFNU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGNHVnVjMlZmYVdRZ2FXNGdjMlZzWmk1bGVIQmxibk5sY3l3Z0ltVjRjR1Z1YzJVZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTFOemczTURZMU5tVTNNelkxTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsYm5ObElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9aWGh3Wlc1elpTNXdZWGxsY2lrc0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG94T1RjS0lDQWdJQzh2SUdWNGNHVnVjMlV1WVcxdmRXNTBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hPVGdLSUNBZ0lDOHZJR1Y0Y0dWdWMyVXVaR1Z6WTNKcGNIUnBiMjRzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRITWdOVEVnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdOVEVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hPVGtLSUNBZ0lDOHZJR1Y0Y0dWdWMyVXVZWEJ3Y205MllXeGZZMjkxYm5Rc0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EwTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG95TURBS0lDQWdJQzh2SUdWNGNHVnVjMlV1YzJWMGRHeGxaQ3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnY0hWemFHbHVkQ0ExTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3TXpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1MGNtRmpkRjl0WVdsdUxtTnZiblJ5WVdOMExrVjRjR1Z1YzJWUWIyOXNRMjl1ZEhKaFkzUXVYMkZ6YzJWeWRGOXRaVzFpWlhJb1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2w5aGMzTmxjblJmYldWdFltVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklHUmxaaUJmWVhOelpYSjBYMjFsYldKbGNpaHpaV3htTENCaFkyTnZkVzUwT2lCQlkyTnZkVzUwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNSZmJXRnBiaTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXViV1Z0WW1WeWMxOXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NU2tzSUNKdFpXMWlaWEp6SUc1dmRDQnBibWwwYVdGc2FYcGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnRaVzFpWlhKelgybHVhWFJwWVd4cGVtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xbGJXSmxjbk5mYVc1cGRHbGhiR2w2WldRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFpXMWlaWEp6SUc1dmRDQnBibWwwYVdGc2FYcGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFkyTnZkVzUwSUdsdUlITmxiR1l1YldWdFltVnljeXdnSW05dWJIa2diV1Z0WW1WeWN5QmpZVzRnWTJGc2JDSUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzJaRFkxTm1RMk1qWTFOekkxWmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnYldWdFltVnljeUJqWVc0Z1kyRnNiQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZiblJ5WVdOMFgyMWhhVzR1WTI5dWRISmhZM1F1Ulhod1pXNXpaVkJ2YjJ4RGIyNTBjbUZqZEM1ZlkyOXRjR3hsZEdWZlpYaHdaVzV6WlNobGVIQmxibk5sWDJsa09pQjFhVzUwTmpRc0lHVjRjR1Z1YzJVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gyTnZiWEJzWlhSbFgyVjRjR1Z1YzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1JmYldGcGJpOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWkdWbUlGOWpiMjF3YkdWMFpWOWxlSEJsYm5ObEtITmxiR1lzSUdWNGNHVnVjMlZmYVdRNklGVkpiblEyTkN3Z1pYaHdaVzV6WlRvZ1JYaHdaVzV6WlZKbFkyOXlaQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wWDIxaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1pYaHdaVzV6WlM1elpYUjBiR1ZrTENBaVpYaHdaVzV6WlNCaGJISmxZV1I1SUhObGRIUnNaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05EQXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxibk5sSUdGc2NtVmhaSGtnYzJWMGRHeGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMFgyMWhhVzR2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHVjRjR1Z1YzJVdVlYQndjbTkyWVd4ZlkyOTFiblFnUGowZ2MyVnNaaTVoY0hCeWIzWmhiRjkwYUhKbGMyaHZiR1F1ZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0EwTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY0hCeWIzWmhiRjkwYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYQndjbTkyWVd4ZmRHaHlaWE5vYjJ4a0lHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qVTNMVFU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHVnVjMlV1WVhCd2NtOTJZV3hmWTI5MWJuUWdQajBnYzJWc1ppNWhjSEJ5YjNaaGJGOTBhSEpsYzJodmJHUXVkbUZzZFdVS0lDQWdJQzh2SUNrc0lDSnBibk4xWm1acFkybGxiblFnWVhCd2NtOTJZV3h6SWdvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZENCaGNIQnliM1poYkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1d2IyOXNYMkpoYkdGdVkyVXVkbUZzZFdVZ1BqMGdaWGh3Wlc1elpTNWhiVzkxYm5Rc0lDSnBibk4xWm1acFkybGxiblFnY0c5dmJDQmlZV3hoYm1ObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CdmIyeGZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3YjI5c1gySmhiR0Z1WTJVZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNXpkV1ptYVdOcFpXNTBJSEJ2YjJ3Z1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBYMjFoYVc0dlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENoaGJXOTFiblE5Wlhod1pXNXpaUzVoYlc5MWJuUXNJSEpsWTJWcGRtVnlQV1Y0Y0dWdWMyVXVjR0Y1WlhJc0lHWmxaVDB3S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRGOXRZV2x1TDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QnpaV3htTG5CdmIyeGZZbUZzWVc1alpTNTJZV3gxWlNBdFBTQmxlSEJsYm5ObExtRnRiM1Z1ZEFvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljRzl2YkY5aVlXeGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkRjl0WVdsdUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJsZUhCbGJuTmxMbk5sZEhSc1pXUWdQU0JVY25WbENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUmZiV0ZwYmk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1bGVIQmxibk5sYzF0bGVIQmxibk5sWDJsa1hTQTlJR1Y0Y0dWdWMyVXVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk5UYzROekEyTlRabE56TTJOVFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lNQjJOeVpXRjBiM0lNY0c5dmJGOWlZV3hoYm1ObEVtRndjSEp2ZG1Gc1gzUm9jbVZ6YUc5c1pBaGxlSEJsYm5ObFh3eHRaVzFpWlhKZlkyOTFiblFOWlhod1pXNXpaVjlqYjNWdWRCTnRaVzFpWlhKelgybHVhWFJwWVd4cGVtVmtDbWR5YjNWd1gyNWhiV1VIYldWdFltVnlYd0lBTXdsaGNIQnliM1poYkY4RUZSOThkVEVaRkVReEdFRUFPWUlIQkl5ZUVyVUVnNzVFU1FURmVBME5CRStjZEJvRTR3R0wvUVEwVEpUb0JHQXo2WXcyR2dDT0J3QmhBTG9BK3dHRUFmUUNHZ0pmQUlBRXlZSE1sellhQUk0QkFBRUFOaG9CU1NKWmdRSUlTd0VWRWtSWEFnQTJHZ0pKSWxsSkpRdUJBZ2hQQWhVU1JEWWFBMGtWSkJKRUYwc0JSQ2d4QUdjbkIwOERaMGxFU1U4Q0RrUW5CQ0puSndZaVp5cE1aeWtpWnljRkltY2pRellhQVVjQ0lsbEpUZ0pKSlF1QkFnaFBBaFVTUkNJb1pVUXhBQkpFUkNKSlN3SU1RUUF0U3dKWEFnQkxBVWxPQWlVTEpWZ25DRXhRU2IxRkFSUkVJeGEvSWljRVpVUWpDQ2NFVEdjakNFVUJRdi9NSndZalp5TkRNUllqQ1VrNEVDTVNSQ0lvWlVVQlJERUFpQUg2U1RnQU1RQVNSRWs0QnpJS0VrUkpPQWhKUkVzQk9DQXlBeEpFVERnSk1nTVNSQ0lwWlVRSUtVeG5JME0yR2dGSkZTUVNSQmMyR2dKSklsbUJBZ2hMQVJVU1JGY0NBQ0lvWlVVQlJERUFpQUdwU3dGRVNSVkpSQ0luQldWRUl3aEpUZ1FuQlVzQlp6RUFUd1FXVUU4Q0ZsY0dBazhEVUV3bkNWQWpGa3hMQVZDQUFRQlFUd0pRVHdJV0swc0JVRWxPQkVtOFNFOEN2ekVBVUNjS1RGQk12eUlxWlVRakVrRUFDa20rUkVzQ1RJZ0JYVWdqUXpZYUFVa1ZKQkpFRjBraUtHVkZBVVF4QUlnQk1CWXJTd0ZRU1U0Q1NiMUZBVVJKdmtoT0FrbUJNaU82SWxNVVJERUFUd0pNVUNjS1RGQkp2VVVCRkVRakZyK0JLaVM2RnlNSUZrbE9BbHdxU1lFcVd5SXFaVVFQUVFBS1N3TkxBWWdBOTBnalEwc0NnU3BMQTd0Qy8vUTJHZ0ZKRlNRU1JCY2lLR1ZGQVVReEFJZ0F3VWtXSzB4UVNiMUZBVVMrU0lnQXgwZ2pReUlvWlVVQlJDSW5CMlZFSWljRVpVUWlLbVZFSWlsbFJDSW5CV1ZFU3dRVkZsY0dBazhGVUU4RUZvQUNBQ0pNVUU4RUZsQlBBeFpRVHdJV1VFeFFKd3RNVUxBalF6WWFBVWtWSkJKRUZ4WXJURkJKdlVVQlJFa2lKYnBMQVNVa3VoZExBb01DTXdLNkY0RUNDRXNEZ1ROUEFycFhBZ0JMQTRFcUpMb1hUd1NCTWlPNklsTlBBeFpQQkV4UVN3TVZGbGNHQWs4RVVFd25DVkJQQXhaUWdBRUFJazhFVkZCTVVDY0xURkN3STBPS0FRQWlKd1psUkNNU1JDY0lpLzlRdlVVQlJJbUtBZ0dMLzRHUUExTVVSSXYvZ1NwYklpcGxSQTlFSWlsbFJJdi9KVnRLRDBTeGkvOVhBQ0N5QjBteUNDT3lFQ0t5QWJNSktVeG5pLytCa0FNalZJei9pLzRXSzB4UVNieElpLysvaS8rSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
