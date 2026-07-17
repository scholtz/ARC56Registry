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

namespace Arc56.Generated.rajshekar1206.algosplit.Algosplit_20064be4
{


    //
    // AlgoSplit - On-chain Split Bill Settlement Smart Contract
    //
    public class AlgosplitProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgosplitProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Bill : AVMObjectType
            {
                public Algorand.Address Creator { get; set; }

                public ulong TotalAmount { get; set; }

                public ulong MemberCount { get; set; }

                public ulong SettledCount { get; set; }

                public bool IsSettled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAmount.From(TotalAmount);
                    ret.AddRange(vTotalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemberCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMemberCount.From(MemberCount);
                    ret.AddRange(vMemberCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettledCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSettledCount.From(SettledCount);
                    ret.AddRange(vSettledCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsSettled.From(IsSettled);
                    ret.AddRange(vIsSettled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Bill Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Bill();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAmount = vTotalAmount.ToValue();
                    if (valueTotalAmount is ulong vTotalAmountValue) { ret.TotalAmount = vTotalAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemberCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMemberCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMemberCount = vMemberCount.ToValue();
                    if (valueMemberCount is ulong vMemberCountValue) { ret.MemberCount = vMemberCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettledCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSettledCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettledCount = vSettledCount.ToValue();
                    if (valueSettledCount is ulong vSettledCountValue) { ret.SettledCount = vSettledCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsSettled = vIsSettled.ToValue();
                    if (valueIsSettled is bool vIsSettledValue) { ret.IsSettled = vIsSettledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Bill);
                }
                public bool Equals(Bill? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Bill left, Bill right)
                {
                    return EqualityComparer<Bill>.Default.Equals(left, right);
                }
                public static bool operator !=(Bill left, Bill right)
                {
                    return !(left == right);
                }

            }

            public class Member : AVMObjectType
            {
                public ulong Share { get; set; }

                public bool Paid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vShare.From(Share);
                    ret.AddRange(vShare.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPaid.From(Paid);
                    ret.AddRange(vPaid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Member Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Member();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vShare.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueShare = vShare.ToValue();
                    if (valueShare is ulong vShareValue) { ret.Share = vShareValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaid = vPaid.ToValue();
                    if (valuePaid is bool vPaidValue) { ret.Paid = vPaidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Member);
                }
                public bool Equals(Member? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Member left, Member right)
                {
                    return EqualityComparer<Member>.Default.Equals(left, right);
                }
                public static bool operator !=(Member left, Member right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new bill with members and their shares
        ///</summary>
        /// <param name="members">List of member addresses </param>
        /// <param name="shares">List of share amounts for each member </param>
        /// <param name="mbr_payment">Payment transaction for box storage MBR </param>
        public async Task<ulong> CreateBill(PaymentTransaction mbr_payment, Algorand.Address[] members, ulong[] shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 99, 170, 97, 179 };
            var membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); membersAbi.From(members);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); sharesAbi.From(shares);

            var result = await base.CallApp(new List<object> { abiHandle, membersAbi, sharesAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateBill_Transactions(PaymentTransaction mbr_payment, Algorand.Address[] members, ulong[] shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 99, 170, 97, 179 };
            var membersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); membersAbi.From(members);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); sharesAbi.From(shares);

            return await base.MakeTransactionList(new List<object> { abiHandle, membersAbi, sharesAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pay a bill share (grouped with payment transaction)
        ///</summary>
        /// <param name="bill_id">The bill ID to pay </param>
        /// <param name="payment">Payment transaction to bill creator </param>
        public async Task<bool> PayBill(PaymentTransaction payment, ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 4, 32, 56, 150 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PayBill_Transactions(PaymentTransaction payment, ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 4, 32, 56, 150 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get bill details
        ///</summary>
        /// <param name="bill_id">The bill ID </param>
        public async Task<Structs.Bill> GetBill(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 79, 94, 220 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            var result = await base.SimApp(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Bill.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBill_Transactions(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 79, 94, 220 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get member details for a bill
        ///</summary>
        /// <param name="bill_id">The bill ID </param>
        /// <param name="member">Member address </param>
        public async Task<Structs.Member> GetMember(ulong bill_id, Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 74, 123, 103 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, bill_idAbi, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Member.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMember_Transactions(ulong bill_id, Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 74, 123, 103 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all bills for a user
        ///</summary>
        /// <param name="user">User address </param>
        public async Task<ulong[]> GetUserBills(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 130, 60, 232 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetUserBills_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 130, 60, 232 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current bill counter
        ///</summary>
        public async Task<ulong> GetBillCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 137, 147, 8 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBillCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 137, 147, 8 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel a bill (only creator can cancel, only if no payments made)
        ///</summary>
        /// <param name="bill_id">The bill ID to cancel </param>
        public async Task<bool> CancelBill(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 221, 44, 240 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CancelBill_Transactions(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 221, 44, 240 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update a member's share (only creator, only if member hasn't paid)
        ///</summary>
        /// <param name="bill_id">The bill ID </param>
        /// <param name="member">Member address to update </param>
        /// <param name="new_share">New share amount </param>
        public async Task<bool> UpdateMemberShare(ulong bill_id, Algorand.Address member, ulong new_share, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 172, 94, 192 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var new_shareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_shareAbi.From(new_share);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi, memberAbi, new_shareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateMemberShare_Transactions(ulong bill_id, Algorand.Address member, ulong new_share, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 172, 94, 192 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var new_shareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_shareAbi.From(new_share);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi, memberAbi, new_shareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove a member from bill (only creator, only if member hasn't paid)
        ///</summary>
        /// <param name="bill_id">The bill ID </param>
        /// <param name="member">Member address to remove </param>
        public async Task<bool> RemoveMember(ulong bill_id, Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 86, 159, 242 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RemoveMember_Transactions(ulong bill_id, Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 86, 159, 242 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a new member to existing bill (only creator, only if bill not settled)
        ///</summary>
        /// <param name="bill_id">The bill ID </param>
        /// <param name="member">New member address </param>
        /// <param name="share">Share amount for new member </param>
        /// <param name="mbr_payment">Payment for box storage MBR </param>
        public async Task<bool> AddMember(PaymentTransaction mbr_payment, ulong bill_id, Algorand.Address member, ulong share, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 45, 123, 14, 26 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var shareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shareAbi.From(share);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi, memberAbi, shareAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddMember_Transactions(PaymentTransaction mbr_payment, ulong bill_id, Algorand.Address member, ulong share, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 45, 123, 14, 26 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var shareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); shareAbi.From(share);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi, memberAbi, shareAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb3NwbGl0IiwiZGVzYyI6IkFsZ29TcGxpdCAtIE9uLWNoYWluIFNwbGl0IEJpbGwgU2V0dGxlbWVudCBTbWFydCBDb250cmFjdCIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJCaWxsIjpbeyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG90YWxfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1lbWJlcl9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZXR0bGVkX2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlzX3NldHRsZWQiLCJ0eXBlIjoiYm9vbCJ9XSwiTWVtYmVyIjpbeyJuYW1lIjoic2hhcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGFpZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9iaWxsIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBiaWxsIHdpdGggbWVtYmVycyBhbmQgdGhlaXIgc2hhcmVzIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlcnMiLCJkZXNjIjoiTGlzdCBvZiBtZW1iZXIgYWRkcmVzc2VzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOiJMaXN0IG9mIHNoYXJlIGFtb3VudHMgZm9yIGVhY2ggbWVtYmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5bWVudCIsImRlc2MiOiJQYXltZW50IHRyYW5zYWN0aW9uIGZvciBib3ggc3RvcmFnZSBNQlIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiQmlsbCBJRCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheV9iaWxsIiwiZGVzYyI6IlBheSBhIGJpbGwgc2hhcmUgKGdyb3VwZWQgd2l0aCBwYXltZW50IHRyYW5zYWN0aW9uKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2lkIiwiZGVzYyI6IlRoZSBiaWxsIElEIHRvIHBheSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJQYXltZW50IHRyYW5zYWN0aW9uIHRvIGJpbGwgY3JlYXRvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYmlsbCIsImRlc2MiOiJHZXQgYmlsbCBkZXRhaWxzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfaWQiLCJkZXNjIjoiVGhlIGJpbGwgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJCaWxsIiwiZGVzYyI6IkJpbGwgc3RydWN0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWVtYmVyIiwiZGVzYyI6IkdldCBtZW1iZXIgZGV0YWlscyBmb3IgYSBiaWxsIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfaWQiLCJkZXNjIjoiVGhlIGJpbGwgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIiLCJkZXNjIjoiTWVtYmVyIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxib29sKSIsInN0cnVjdCI6Ik1lbWJlciIsImRlc2MiOiJNZW1iZXIgc3RydWN0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9iaWxscyIsImRlc2MiOiJHZXQgYWxsIGJpbGxzIGZvciBhIHVzZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjoiVXNlciBhZGRyZXNzIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjoiQXJyYXkgb2YgYmlsbCBJRHMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9iaWxsX2NvdW50ZXIiLCJkZXNjIjoiR2V0IGN1cnJlbnQgYmlsbCBjb3VudGVyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxfYmlsbCIsImRlc2MiOiJDYW5jZWwgYSBiaWxsIChvbmx5IGNyZWF0b3IgY2FuIGNhbmNlbCwgb25seSBpZiBubyBwYXltZW50cyBtYWRlKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2lkIiwiZGVzYyI6IlRoZSBiaWxsIElEIHRvIGNhbmNlbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfbWVtYmVyX3NoYXJlIiwiZGVzYyI6IlVwZGF0ZSBhIG1lbWJlcidzIHNoYXJlIChvbmx5IGNyZWF0b3IsIG9ubHkgaWYgbWVtYmVyIGhhc24ndCBwYWlkKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2lkIiwiZGVzYyI6IlRoZSBiaWxsIElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6Ik1lbWJlciBhZGRyZXNzIHRvIHVwZGF0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3NoYXJlIiwiZGVzYyI6Ik5ldyBzaGFyZSBhbW91bnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3Mgc3RhdHVzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX21lbWJlciIsImRlc2MiOiJSZW1vdmUgYSBtZW1iZXIgZnJvbSBiaWxsIChvbmx5IGNyZWF0b3IsIG9ubHkgaWYgbWVtYmVyIGhhc24ndCBwYWlkKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2lkIiwiZGVzYyI6IlRoZSBiaWxsIElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6Ik1lbWJlciBhZGRyZXNzIHRvIHJlbW92ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfbWVtYmVyIiwiZGVzYyI6IkFkZCBhIG5ldyBtZW1iZXIgdG8gZXhpc3RpbmcgYmlsbCAob25seSBjcmVhdG9yLCBvbmx5IGlmIGJpbGwgbm90IHNldHRsZWQpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfaWQiLCJkZXNjIjoiVGhlIGJpbGwgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIiLCJkZXNjIjoiTmV3IG1lbWJlciBhZGRyZXNzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZSIsImRlc2MiOiJTaGFyZSBhbW91bnQgZm9yIG5ldyBtZW1iZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXltZW50IiwiZGVzYyI6IlBheW1lbnQgZm9yIGJveCBzdG9yYWdlIE1CUiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBzdGF0dXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgcGFpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6IkF0IGxlYXN0IG9uZSBtZW1iZXIgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MThdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIGFscmVhZHkgc2V0dGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNSw1MjYsNjIyLDY4NSw4MDAsMTA3NF0sImVycm9yTWVzc2FnZSI6IkJpbGwgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzddLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgY2FuY2VsIGJpbGwgd2l0aCBwYXltZW50cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMiwxMDk2XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IG1vZGlmeSBzZXR0bGVkIGJpbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjldLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgcmVtb3ZlIGxhc3QgbWVtYmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODUyXSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHJlbW92ZSBwYWlkIG1lbWJlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMF0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCB1cGRhdGUgcGFpZCBtZW1iZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDddLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgdXBkYXRlIHNldHRsZWQgYmlsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4MV0sImVycm9yTWVzc2FnZSI6IkZhaWxlZCB0byBkZWxldGUgbWVtYmVyIGJveCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDUsMTE4NV0sImVycm9yTWVzc2FnZSI6IkZhaWxlZCB0byBkZWxldGUgdXNlciBib3giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzQsMTA2NV0sImVycm9yTWVzc2FnZSI6Ik1CUiBwYXltZW50IG11c3QgZ28gdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMl0sImVycm9yTWVzc2FnZSI6Ik1lbWJlciBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MCw3MTcsODM5XSwiZXJyb3JNZXNzYWdlIjoiTWVtYmVyIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNl0sImVycm9yTWVzc2FnZSI6Ik1lbWJlcnMgYW5kIHNoYXJlcyBsZW5ndGggbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjldLCJlcnJvck1lc3NhZ2UiOiJOb3QgYSBtZW1iZXIgb2YgdGhpcyBiaWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gYWRkIG1lbWJlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGNhbmNlbCBiaWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiByZW1vdmUgbWVtYmVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gdXBkYXRlIHNoYXJlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgYW1vdW50IG11c3QgbWF0Y2ggc2hhcmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjFdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gYmlsbCBjcmVhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUwXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzAsNzMzLDEwOTldLCJlcnJvck1lc3NhZ2UiOiJTaGFyZSBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM5LDU5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmlsbF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNCwzNDUsOTU2XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMTk5LDg5Myw5ODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFjY291bnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDgsNTc0LDY2Myw3ODgsMTAzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODMsNTE5LDU0MCw2MTQsNjU1LDY3MSw3ODAsMTAyNSwxMDQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYyLDExNzBdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwLDM5MywxMDUxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNaUEwTkRnS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01DQXdlRFl5TmprMll6WmpOV1lnTUhnMVpqWmtOalUyWkRZeU5qVTNNalZtSURCNE1UVXhaamRqTnpVZ01IZ3hOVEZtTjJNM05UZ3dJQ0ppYVd4c1gyTnZkVzUwWlhJaUlEQjROelUzTXpZMU56STFaaUF3ZURBd01EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklITmxiR1l1WW1sc2JGOWpiM1Z1ZEdWeUlEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlhV3hzWDJOdmRXNTBaWElpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1FXeG5iM053YkdsMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE9Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5qTmhZVFl4WWpNZ01IZ3dOREl3TXpnNU5pQXdlRGhrTkdZMVpXUmpJREI0TVdJMFlUZGlOamNnTUhneFl6Z3lNMk5sT0NBd2VETmxPRGs1TXpBNElEQjRaV0ZrWkRKalpqQWdNSGc1Tm1Gak5XVmpNQ0F3ZURrM05UWTVabVl5SURCNE1tUTNZakJsTVdFZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWZlltbHNiQ2hoWkdSeVpYTnpXMTBzZFdsdWREWTBXMTBzY0dGNUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNHRjVYMkpwYkd3b2RXbHVkRFkwTEhCaGVTbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZZbWxzYkNoMWFXNTBOalFwS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1kbGRGOXRaVzFpWlhJb2RXbHVkRFkwTEdGa1pISmxjM01wS0hWcGJuUTJOQ3hpYjI5c0tTSXNJRzFsZEdodlpDQWlaMlYwWDNWelpYSmZZbWxzYkhNb1lXUmtjbVZ6Y3lsMWFXNTBOalJiWFNJc0lHMWxkR2h2WkNBaVoyVjBYMkpwYkd4ZlkyOTFiblJsY2lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKallXNWpaV3hmWW1sc2JDaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMjFsYldKbGNsOXphR0Z5WlNoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWNtVnRiM1psWDIxbGJXSmxjaWgxYVc1ME5qUXNZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKaFpHUmZiV1Z0WW1WeUtIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJOQ3h3WVhrcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjlpYVd4c0lIQmhlVjlpYVd4c0lHZGxkRjlpYVd4c0lHZGxkRjl0WlcxaVpYSWdaMlYwWDNWelpYSmZZbWxzYkhNZ1oyVjBYMkpwYkd4ZlkyOTFiblJsY2lCallXNWpaV3hmWW1sc2JDQjFjR1JoZEdWZmJXVnRZbVZ5WDNOb1lYSmxJSEpsYlc5MlpWOXRaVzFpWlhJZ1lXUmtYMjFsYldKbGNnb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU1T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2JHbDBMbU52Ym5SeVlXTjBMa0ZzWjI5emNHeHBkQzVqY21WaGRHVmZZbWxzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5aWFXeHNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZV05qYjNWdWRENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRFkwUGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalUyTFRVM0NpQWdJQ0F2THlBaklGWmhiR2xrWVhSbElHbHVjSFYwY3dvZ0lDQWdMeThnWVhOelpYSjBJRzFsYldKbGNuTXViR1Z1WjNSb0lEMDlJSE5vWVhKbGN5NXNaVzVuZEdnc0lDSk5aVzFpWlhKeklHRnVaQ0J6YUdGeVpYTWdiR1Z1WjNSb0lHMXBjMjFoZEdOb0lnb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5aVzFpWlhKeklHRnVaQ0J6YUdGeVpYTWdiR1Z1WjNSb0lHMXBjMjFoZEdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ2JXVnRZbVZ5Y3k1c1pXNW5kR2dnUGlBd0xDQWlRWFFnYkdWaGMzUWdiMjVsSUcxbGJXSmxjaUJ5WlhGMWFYSmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJkQ0JzWldGemRDQnZibVVnYldWdFltVnlJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPall3TFRZeENpQWdJQ0F2THlBaklGWmxjbWxtZVNCTlFsSWdjR0Y1YldWdWRBb2dJQ0FnTHk4Z1lYTnpaWEowSUcxaWNsOXdZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pOUWxJZ2NHRjViV1Z1ZENCdGRYTjBJR2R2SUhSdklHRndjQ0lLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5RbElnY0dGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUdGd2NBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzJNeTAyTkFvZ0lDQWdMeThnSXlCSmJtTnlaVzFsYm5RZ1ltbHNiQ0JqYjNWdWRHVnlDaUFnSUNBdkx5QnpaV3htTG1KcGJHeGZZMjkxYm5SbGNpQXJQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZbWxzYkY5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnBiR3hmWTI5MWJuUmxjaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUpwYkd4ZlkyOTFiblJsY2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qWTNMVFk0Q2lBZ0lDQXZMeUFqSUVOaGJHTjFiR0YwWlNCMGIzUmhiQ0JoYlc5MWJuUUtJQ0FnSUM4dklIUnZkR0ZzWDJGdGIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h0WlcxaVpYSnpMbXhsYm1kMGFDazZDaUFnSUNCa2RYQUtDbU55WldGMFpWOWlhV3hzWDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHRaVzFpWlhKekxteGxibWQwYUNrNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJqY21WaGRHVmZZbWxzYkY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdjMmhoY21WZllXMXZkVzUwSUQwZ2MyaGhjbVZ6VzJsZExtNWhkR2wyWlFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0J6YUdGeVpWOWhiVzkxYm5RZ1BpQXdMQ0FpVTJoaGNtVWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRk5vWVhKbElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpJS0lDQWdJQzh2SUhSdmRHRnNYMkZ0YjNWdWRDQXJQU0J6YUdGeVpWOWhiVzkxYm5RS0lDQWdJR1JwWnlBekNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNodFpXMWlaWEp6TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHTnlaV0YwWlY5aWFXeHNYMlp2Y2w5b1pXRmtaWEpBTWdvS1kzSmxZWFJsWDJKcGJHeGZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pRd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUVKNWRHVnpLR0lpWW1sc2JGOGlLU0FySUc5d0xtbDBiMklvWW1sc2JGOXBaQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeU5qazJZelpqTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZOemNLSUNBZ0lDOHZJR055WldGMGIzSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZOell0T0RJS0lDQWdJQzh2SUdKcGJHd2dQU0JDYVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR055WldGMGIzSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjloYlc5MWJuUTlkRzkwWVd4ZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHMWxiV0psY2w5amIzVnVkRDF0WlcxaVpYSnpMbXhsYm1kMGFDd0tJQ0FnSUM4dklDQWdJQ0J6WlhSMGJHVmtYMk52ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JwYzE5elpYUjBiR1ZrUFVKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z2MyVjBkR3hsWkY5amIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8zTmkwNE1nb2dJQ0FnTHk4Z1ltbHNiQ0E5SUVKcGJHd29DaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUnZjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJGdGIzVnVkRDEwYjNSaGJGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdiV1Z0WW1WeVgyTnZkVzUwUFcxbGJXSmxjbk11YkdWdVozUm9MQW9nSUNBZ0x5OGdJQ0FnSUhObGRIUnNaV1JmWTI5MWJuUTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdselgzTmxkSFJzWldROVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUdselgzTmxkSFJzWldROVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpZdE9ESUtJQ0FnSUM4dklHSnBiR3dnUFNCQ2FXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBiM0k5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5aGJXOTFiblE5ZEc5MFlXeGZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJRzFsYldKbGNsOWpiM1Z1ZEQxdFpXMWlaWEp6TG14bGJtZDBhQ3dLSUNBZ0lDOHZJQ0FnSUNCelpYUjBiR1ZrWDJOdmRXNTBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXpaWFIwYkdWa1BVSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCdmNDNUNiM2d1Y0hWMEtHSnBiR3hmYTJWNUxDQmlhV3hzTG1KNWRHVnpLUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvNE5TMDROZ29nSUNBZ0x5OGdJeUJEY21WaGRHVWdiV1Z0WW1WeUlHSnZlR1Z6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9iV1Z0WW1WeWN5NXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01Rb0tZM0psWVhSbFgySnBiR3hmWm05eVgyaGxZV1JsY2tBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzROUzA0TmdvZ0lDQWdMeThnSXlCRGNtVmhkR1VnYldWdFltVnlJR0p2ZUdWekNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYldWdFltVnljeTVzWlc1bmRHZ3BPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWW5vZ1kzSmxZWFJsWDJKcGJHeGZZV1owWlhKZlptOXlRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUcxbGJXSmxjbDloWkdSeVpYTnpJRDBnYldWdFltVnljMXRwWFFvZ0lDQWdaR2xuSURVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCemFHRnlaVjloYlc5MWJuUWdQU0J6YUdGeVpYTmJhVjB1Ym1GMGFYWmxDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvME1USUtJQ0FnSUM4dklISmxkSFZ5YmlCQ2VYUmxjeWhpSW1KcGJHeGZJaWtnS3lCdmNDNXBkRzlpS0dKcGJHeGZhV1FwSUNzZ1FubDBaWE1vWWlKZmJXVnRZbVZ5WHlJcElDc2diV1Z0WW1WeUxtSjVkR1Z6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMVpqWmtOalUyWkRZeU5qVTNNalZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZPVEV0T1RRS0lDQWdJQzh2SUcxbGJXSmxjaUE5SUUxbGJXSmxjaWdLSUNBZ0lDOHZJQ0FnSUNCemFHRnlaVDF6YUdGeVpWOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjR0ZwWkQxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJR2x6WDNObGRIUnNaV1E5UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZPVEV0T1RRS0lDQWdJQzh2SUcxbGJXSmxjaUE5SUUxbGJXSmxjaWdLSUNBZ0lDOHZJQ0FnSUNCemFHRnlaVDF6YUdGeVpWOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjR0ZwWkQxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnYjNBdVFtOTRMbkIxZENodFpXMWlaWEpmYTJWNUxDQnRaVzFpWlhJdVlubDBaWE1wQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qazNMVGs0Q2lBZ0lDQXZMeUFqSUVGa1pDQmlhV3hzSUhSdklIVnpaWEluY3lCd1lYSjBhV05wY0dGMGFXOXVJR3hwYzNRS0lDQWdJQzh2SUhObGJHWXVYMkZrWkY5aWFXeHNYM1J2WDNWelpYSW9iV1Z0WW1WeVgyRmtaSEpsYzNNc0lHSnBiR3hmYVdRcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTJGc2JITjFZaUJmWVdSa1gySnBiR3hmZEc5ZmRYTmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG80TlMwNE5nb2dJQ0FnTHk4Z0l5QkRjbVZoZEdVZ2JXVnRZbVZ5SUdKdmVHVnpDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2JXVnRZbVZ5Y3k1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQmpjbVZoZEdWZlltbHNiRjltYjNKZmFHVmhaR1Z5UURZS0NtTnlaV0YwWlY5aWFXeHNYMkZtZEdWeVgyWnZja0E1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUdScFp5QTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZjM0JzYVhRdVkyOXVkSEpoWTNRdVFXeG5iM053YkdsMExuQmhlVjlpYVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1WDJKcGJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QmlhV3hzWDJsa1gyNWhkR2wyWlNBOUlHSnBiR3hmYVdRdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pRd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUVKNWRHVnpLR0lpWW1sc2JGOGlLU0FySUc5d0xtbDBiMklvWW1sc2JGOXBaQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTWpZNU5tTTJZelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hNaklLSUNBZ0lDOHZJR0pwYkd4ZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltbHNiRjlyWlhrcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlRbWxzYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNhV3hzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakV5TmdvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCaWFXeHNMbWx6WDNObGRIUnNaV1F1Ym1GMGFYWmxMQ0FpUW1sc2JDQmhiSEpsWVdSNUlITmxkSFJzWldRaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTkRnS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNhV3hzSUdGc2NtVmhaSGtnYzJWMGRHeGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG94TWpndE1USTVDaUFnSUNBdkx5QWpJRXh2WVdRZ2JXVnRZbVZ5Q2lBZ0lDQXZMeUJ0WlcxaVpYSmZhMlY1SUQwZ2MyVnNaaTVmWjJWMFgyMWxiV0psY2w5clpYa29ZbWxzYkY5cFpGOXVZWFJwZG1Vc0lGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qUXhNZ29nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6S0dJaVltbHNiRjhpS1NBcklHOXdMbWwwYjJJb1ltbHNiRjlwWkNrZ0t5QkNlWFJsY3loaUlsOXRaVzFpWlhKZklpa2dLeUJ0WlcxaVpYSXVZbmwwWlhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFZtTm1RMk5UWmtOakkyTlRjeU5XWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2JXVnRZbVZ5WDJKNWRHVnpMQ0J0WlcxaVpYSmZaWGhwYzNSeklEMGdiM0F1UW05NExtZGxkQ2h0WlcxaVpYSmZhMlY1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdZWE56WlhKMElHMWxiV0psY2w5bGVHbHpkSE1zSUNKT2IzUWdZU0J0WlcxaVpYSWdiMllnZEdocGN5QmlhV3hzSWdvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCaElHMWxiV0psY2lCdlppQjBhR2x6SUdKcGJHd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUcxbGJXSmxjaTV3WVdsa0xtNWhkR2wyWlN3Z0lrRnNjbVZoWkhrZ2NHRnBaQ0lLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2djR0ZwWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVE0zQ2lBZ0lDQXZMeUFqSUZabGNtbG1lU0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjaXdnSWxCaGVXMWxiblFnYzJWdVpHVnlJRzFwYzIxaGRHTm9JZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJR0pwYkd3dVkzSmxZWFJ2Y2l3Z0lsQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCMGJ5QmlhV3hzSUdOeVpXRjBiM0lpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdkdklIUnZJR0pwYkd3Z1kzSmxZWFJ2Y2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0E5UFNCdFpXMWlaWEl1YzJoaGNtVXNJQ0pRWVhsdFpXNTBJR0Z0YjNWdWRDQnRkWE4wSUcxaGRHTm9JSE5vWVhKbElnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCaGJXOTFiblFnYlhWemRDQnRZWFJqYUNCemFHRnlaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG94TkRFdE1UUXlDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQnRaVzFpWlhJZ2MzUmhkSFZ6Q2lBZ0lDQXZMeUJ0WlcxaVpYSXVjR0ZwWkNBOUlFSnZiMndvVkhKMVpTa0tJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QnZjQzVDYjNndWNIVjBLRzFsYldKbGNsOXJaWGtzSUcxbGJXSmxjaTVpZVhSbGN5a0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRRMUxURTBOZ29nSUNBZ0x5OGdJeUJWY0dSaGRHVWdZbWxzYkNCemRHRjBkWE1LSUNBZ0lDOHZJR0pwYkd3dWMyVjBkR3hsWkY5amIzVnVkQ0FyUFNBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTkRnS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJR2xtSUdKcGJHd3VjMlYwZEd4bFpGOWpiM1Z1ZENBOVBTQmlhV3hzTG0xbGJXSmxjbDlqYjNWdWREb0tJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdQVDBLSUNBZ0lHSjZJSEJoZVY5aWFXeHNYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0pwYkd3dWFYTmZjMlYwZEd4bFpDQTlJRUp2YjJ3b1ZISjFaU2tLSUNBZ0lHbHVkR01nTkNBdkx5QTBORGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRReExURTBNZ29nSUNBZ0x5OGdJeUJWY0dSaGRHVWdiV1Z0WW1WeUlITjBZWFIxY3dvZ0lDQWdMeThnYldWdFltVnlMbkJoYVdRZ1BTQkNiMjlzS0ZSeWRXVXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0pwYkd3dWFYTmZjMlYwZEd4bFpDQTlJRUp2YjJ3b1ZISjFaU2tLSUNBZ0lITmxkR0pwZEFvS2NHRjVYMkpwYkd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHOXdMa0p2ZUM1d2RYUW9ZbWxzYkY5clpYa3NJR0pwYkd3dVlubDBaWE1wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhiR2R2YzNCc2FYUXVZMjl1ZEhKaFkzUXVRV3huYjNOd2JHbDBMbWRsZEY5aWFXeHNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgySnBiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR0pwYkd4ZmEyVjVJRDBnYzJWc1ppNWZaMlYwWDJKcGJHeGZhMlY1S0dKcGJHeGZhV1F1Ym1GMGFYWmxLUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8wTURjS0lDQWdJQzh2SUhKbGRIVnliaUJDZVhSbGN5aGlJbUpwYkd4Zklpa2dLeUJ2Y0M1cGRHOWlLR0pwYkd4ZmFXUXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROakkyT1Raak5tTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z1ltbHNiRjlpZVhSbGN5d2daWGhwYzNSeklEMGdiM0F1UW05NExtZGxkQ2hpYVd4c1gydGxlU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1UWTJDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVFtbHNiQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2FXeHNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmMzQnNhWFF1WTI5dWRISmhZM1F1UVd4bmIzTndiR2wwTG1kbGRGOXRaVzFpWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYldWdFltVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG94TmprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveE9ERUtJQ0FnSUM4dklHMWxiV0psY2w5clpYa2dQU0J6Wld4bUxsOW5aWFJmYldWdFltVnlYMnRsZVNoaWFXeHNYMmxrTG01aGRHbDJaU3dnYldWdFltVnlLUW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8wTVRJS0lDQWdJQzh2SUhKbGRIVnliaUJDZVhSbGN5aGlJbUpwYkd4Zklpa2dLeUJ2Y0M1cGRHOWlLR0pwYkd4ZmFXUXBJQ3NnUW5sMFpYTW9ZaUpmYldWdFltVnlYeUlwSUNzZ2JXVnRZbVZ5TG1KNWRHVnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROakkyT1Raak5tTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TldZMlpEWTFObVEyTWpZMU56STFaZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1UZ3lDaUFnSUNBdkx5QnRaVzFpWlhKZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2JXVnRZbVZ5WDJ0bGVTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRnekNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVFdWdFltVnlJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5aVzFpWlhJZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmMzQnNhWFF1WTI5dWRISmhZM1F1UVd4bmIzTndiR2wwTG1kbGRGOTFjMlZ5WDJKcGJHeHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzVnpaWEpmWW1sc2JITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakU0TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalF4TndvZ0lDQWdMeThnY21WMGRYSnVJRUo1ZEdWektHSWlkWE5sY2w4aUtTQXJJSFZ6WlhJdVlubDBaWE1LSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGczTlRjek5qVTNNalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1UazRDaUFnSUNBdkx5QjFjMlZ5WDJKcGJHeHpYMko1ZEdWekxDQmxlR2x6ZEhNZ1BTQnZjQzVDYjNndVoyVjBLSFZ6WlhKZmEyVjVLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveU1EQUtJQ0FnSUM4dklHbG1JRzV2ZENCbGVHbHpkSE02Q2lBZ0lDQmlibm9nWjJWMFgzVnpaWEpmWW1sc2JITmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qSXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlFUjVibUZ0YVdOQmNuSmhlVnRCVWtNMFZVbHVkRFkwWFNncENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNQW9LWjJWMFgzVnpaWEpmWW1sc2JITmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzTndiR2wwTG1OdmJuUnlZV04wTGtGc1oyOXpjR3hwZEM1blpYUmZkWE5sY2w5aWFXeHNjMEEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveE9EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjkxYzJWeVgySnBiR3h6WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG94T0RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDNWelpYSmZZbWxzYkhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2JHbDBMbU52Ym5SeVlXTjBMa0ZzWjI5emNHeHBkQzVuWlhSZmRYTmxjbDlpYVd4c2MwQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1Gc1oyOXpjR3hwZEM1amIyNTBjbUZqZEM1QmJHZHZjM0JzYVhRdVoyVjBYMkpwYkd4ZlkyOTFiblJsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlpYVd4c1gyTnZkVzUwWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qSXdPQW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9jMlZzWmk1aWFXeHNYMk52ZFc1MFpYSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVltbHNiRjlqYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KcGJHeGZZMjkxYm5SbGNpQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1qQTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZzWjI5emNHeHBkQzVqYjI1MGNtRmpkQzVCYkdkdmMzQnNhWFF1WTJGdVkyVnNYMkpwYkd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZVzVqWld4ZlltbHNiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpFd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpJeENpQWdJQ0F2THlCaWFXeHNYMmxrWDI1aGRHbDJaU0E5SUdKcGJHeGZhV1F1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalF3TndvZ0lDQWdMeThnY21WMGRYSnVJRUo1ZEdWektHSWlZbWxzYkY4aUtTQXJJRzl3TG1sMGIySW9ZbWxzYkY5cFpDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNalk1Tm1NMll6Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCaWFXeHNYMko1ZEdWekxDQmxlR2x6ZEhNZ1BTQnZjQzVDYjNndVoyVjBLR0pwYkd4ZmEyVjVLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pJeU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeXdnSWtKcGJHd2daRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JoYzNObGNuUWdMeThnUW1sc2JDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveU1qa3RNak13Q2lBZ0lDQXZMeUFqSUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnWTJGdVkyVnNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JpYVd4c0xtTnlaV0YwYjNJc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHTmhibU5sYkNCaWFXeHNJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR05oYm1ObGJDQmlhV3hzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pJek1pMHlNek1LSUNBZ0lDOHZJQ01nUTJGdUlHOXViSGtnWTJGdVkyVnNJR2xtSUc1dklIQmhlVzFsYm5SeklHMWhaR1VLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlhV3hzTG5ObGRIUnNaV1JmWTI5MWJuUWdQVDBnTUN3Z0lrTmhibTV2ZENCallXNWpaV3dnWW1sc2JDQjNhWFJvSUhCaGVXMWxiblJ6SWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0JqWVc1alpXd2dZbWxzYkNCM2FYUm9JSEJoZVcxbGJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakl6TlMweU16WUtJQ0FnSUM4dklDTWdUV0Z5YXlCaGN5QnpaWFIwYkdWa0lIUnZJSEJ5WlhabGJuUWdablYwZFhKbElIQmhlVzFsYm5SekNpQWdJQ0F2THlCaWFXeHNMbWx6WDNObGRIUnNaV1FnUFNCQ2IyOXNLRlJ5ZFdVcENpQWdJQ0JwYm5SaklEUWdMeThnTkRRNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hpYVd4c1gydGxlU3dnWW1sc2JDNWllWFJsY3lrS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNOd2JHbDBMbU52Ym5SeVlXTjBMa0ZzWjI5emNHeHBkQzUxY0dSaGRHVmZiV1Z0WW1WeVgzTm9ZWEpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsWDIxbGJXSmxjbDl6YUdGeVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNalF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUdKcGJHeGZhV1JmYm1GMGFYWmxJRDBnWW1sc2JGOXBaQzV1WVhScGRtVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRveU5qQUtJQ0FnSUM4dklHNWxkMTl6YUdGeVpWOXVZWFJwZG1VZ1BTQnVaWGRmYzJoaGNtVXVibUYwYVhabENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQkNlWFJsY3loaUltSnBiR3hmSWlrZ0t5QnZjQzVwZEc5aUtHSnBiR3hmYVdRcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qSTJPVFpqTm1NMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakkyTkFvZ0lDQWdMeThnWW1sc2JGOWllWFJsY3l3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG1kbGRDaGlhV3hzWDJ0bGVTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG95TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pDYVd4c0lHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdZWE56WlhKMElDOHZJRUpwYkd3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpZNExUSTJPUW9nSUNBZ0x5OGdJeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSFZ3WkdGMFpRb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdZbWxzYkM1amNtVmhkRzl5TENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCMWNHUmhkR1VnYzJoaGNtVnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSFZ3WkdGMFpTQnphR0Z5WlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk1qY3dDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR0pwYkd3dWFYTmZjMlYwZEd4bFpDNXVZWFJwZG1Vc0lDSkRZVzV1YjNRZ2RYQmtZWFJsSUhObGRIUnNaV1FnWW1sc2JDSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURRME9Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU5oYm01dmRDQjFjR1JoZEdVZ2MyVjBkR3hsWkNCaWFXeHNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalF4TWdvZ0lDQWdMeThnY21WMGRYSnVJRUo1ZEdWektHSWlZbWxzYkY4aUtTQXJJRzl3TG1sMGIySW9ZbWxzYkY5cFpDa2dLeUJDZVhSbGN5aGlJbDl0WlcxaVpYSmZJaWtnS3lCdFpXMWlaWEl1WW5sMFpYTUtJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROV1kyWkRZMU5tUTJNalkxTnpJMVpnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3lOelFLSUNBZ0lDOHZJRzFsYldKbGNsOWllWFJsY3l3Z2JXVnRZbVZ5WDJWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2JXVnRZbVZ5WDJ0bGVTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG95TnpVS0lDQWdJQzh2SUdGemMyVnlkQ0J0WlcxaVpYSmZaWGhwYzNSekxDQWlUV1Z0WW1WeUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCTlpXMWlaWElnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pJM09DMHlOemtLSUNBZ0lDOHZJQ01nUTJGdUlHOXViSGtnZFhCa1lYUmxJR2xtSUcxbGJXSmxjaUJvWVhOdUozUWdjR0ZwWkFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCdFpXMWlaWEpmWkdGMFlTNXdZV2xrTG01aGRHbDJaU3dnSWtOaGJtNXZkQ0IxY0dSaGRHVWdjR0ZwWkNCdFpXMWlaWElpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWVc1dWIzUWdkWEJrWVhSbElIQmhhV1FnYldWdFltVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakk0TUFvZ0lDQWdMeThnWVhOelpYSjBJRzVsZDE5emFHRnlaVjl1WVhScGRtVWdQaUF3TENBaVUyaGhjbVVnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DSUtJQ0FnSUdScFp5QTBDaUFnSUNCaGMzTmxjblFnTHk4Z1UyaGhjbVVnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3lPREl0TWpnekNpQWdJQ0F2THlBaklGVndaR0YwWlNCMGIzUmhiQ0JoYlc5MWJuUUtJQ0FnSUM4dklHOXNaRjl6YUdGeVpTQTlJRzFsYldKbGNsOWtZWFJoTG5Ob1lYSmxDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3lPRFFLSUNBZ0lDOHZJR0pwYkd3dWRHOTBZV3hmWVcxdmRXNTBJRDBnWW1sc2JDNTBiM1JoYkY5aGJXOTFiblFnTFNCdmJHUmZjMmhoY21VZ0t5QnVaWGRmYzJoaGNtVmZibUYwYVhabENpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakk0TmkweU9EY0tJQ0FnSUM4dklDTWdWWEJrWVhSbElHMWxiV0psY2lCemFHRnlaUW9nSUNBZ0x5OGdiV1Z0WW1WeVgyUmhkR0V1YzJoaGNtVWdQU0J1WlhkZmMyaGhjbVZmYm1GMGFYWmxDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpnNENpQWdJQ0F2THlCdmNDNUNiM2d1Y0hWMEtHMWxiV0psY2w5clpYa3NJRzFsYldKbGNsOWtZWFJoTG1KNWRHVnpLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPakk0T1FvZ0lDQWdMeThnYjNBdVFtOTRMbkIxZENoaWFXeHNYMnRsZVN3Z1ltbHNiQzVpZVhSbGN5a0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWpReENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIzTndiR2wwTG1OdmJuUnlZV04wTGtGc1oyOXpjR3hwZEM1eVpXMXZkbVZmYldWdFltVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxYMjFsYldKbGNqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qSTVNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16QTVDaUFnSUNBdkx5QmlhV3hzWDJsa1gyNWhkR2wyWlNBOUlHSnBiR3hmYVdRdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5EQTNDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vWWlKaWFXeHNYeUlwSUNzZ2IzQXVhWFJ2WWloaWFXeHNYMmxrS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeU5qazJZelpqTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pNVE1LSUNBZ0lDOHZJR0pwYkd4ZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltbHNiRjlyWlhrcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNekUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlRbWxzYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNhV3hzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPak14Tnkwek1UZ0tJQ0FnSUM4dklDTWdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnlaVzF2ZG1VS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlHSnBiR3d1WTNKbFlYUnZjaXdnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnY21WdGIzWmxJRzFsYldKbGNuTWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdjbVZ0YjNabElHMWxiV0psY25NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16RTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR0pwYkd3dWFYTmZjMlYwZEd4bFpDNXVZWFJwZG1Vc0lDSkRZVzV1YjNRZ2JXOWthV1o1SUhObGRIUnNaV1FnWW1sc2JDSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURRME9Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU5oYm01dmRDQnRiMlJwWm5rZ2MyVjBkR3hsWkNCaWFXeHNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPak15TUFvZ0lDQWdMeThnWVhOelpYSjBJR0pwYkd3dWJXVnRZbVZ5WDJOdmRXNTBJRDRnTVN3Z0lrTmhibTV2ZENCeVpXMXZkbVVnYkdGemRDQnRaVzFpWlhJaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0J5WlcxdmRtVWdiR0Z6ZENCdFpXMWlaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRFeUNpQWdJQ0F2THlCeVpYUjFjbTRnUW5sMFpYTW9ZaUppYVd4c1h5SXBJQ3NnYjNBdWFYUnZZaWhpYVd4c1gybGtLU0FySUVKNWRHVnpLR0lpWDIxbGJXSmxjbDhpS1NBcklHMWxiV0psY2k1aWVYUmxjd29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcxWmpaa05qVTJaRFl5TmpVM01qVm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16STBDaUFnSUNBdkx5QnRaVzFpWlhKZllubDBaWE1zSUcxbGJXSmxjbDlsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0cxbGJXSmxjbDlyWlhrcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNekkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV1Z0WW1WeVgyVjRhWE4wY3l3Z0lrMWxiV0psY2lCdWIzUWdabTkxYm1RaUNpQWdJQ0JoYzNObGNuUWdMeThnVFdWdFltVnlJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TWpndE16STVDaUFnSUNBdkx5QWpJRU5oYmlCdmJteDVJSEpsYlc5MlpTQnBaaUJ0WlcxaVpYSWdhR0Z6YmlkMElIQmhhV1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYldWdFltVnlYMlJoZEdFdWNHRnBaQzV1WVhScGRtVXNJQ0pEWVc1dWIzUWdjbVZ0YjNabElIQmhhV1FnYldWdFltVnlJZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMkZ1Ym05MElISmxiVzkyWlNCd1lXbGtJRzFsYldKbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pNekV0TXpNeUNpQWdJQ0F2THlBaklGVndaR0YwWlNCaWFXeHNDaUFnSUNBdkx5QmlhV3hzTG5SdmRHRnNYMkZ0YjNWdWRDQXRQU0J0WlcxaVpYSmZaR0YwWVM1emFHRnlaUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXpNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TXpNS0lDQWdJQzh2SUdKcGJHd3ViV1Z0WW1WeVgyTnZkVzUwSUMwOUlERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBME1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pNelFLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvWW1sc2JGOXJaWGtzSUdKcGJHd3VZbmwwWlhNcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16TTJMVE16TndvZ0lDQWdMeThnSXlCRVpXeGxkR1VnYldWdFltVnlJR0p2ZUFvZ0lDQWdMeThnWkdWc1pYUmxaQ0E5SUc5d0xrSnZlQzVrWld4bGRHVW9iV1Z0WW1WeVgydGxlU2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk16TTRDaUFnSUNBdkx5QmhjM05sY25RZ1pHVnNaWFJsWkN3Z0lrWmhhV3hsWkNCMGJ5QmtaV3hsZEdVZ2JXVnRZbVZ5SUdKdmVDSUtJQ0FnSUdGemMyVnlkQ0F2THlCR1lXbHNaV1FnZEc4Z1pHVnNaWFJsSUcxbGJXSmxjaUJpYjNnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5ERTNDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vWWlKMWMyVnlYeUlwSUNzZ2RYTmxjaTVpZVhSbGN3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEYzFOek0yTlRjeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalEwTXdvZ0lDQWdMeThnZFhObGNsOWlhV3hzYzE5aWVYUmxjeXdnWlhocGMzUnpJRDBnYjNBdVFtOTRMbWRsZENoMWMyVnlYMnRsZVNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZORFExQ2lBZ0lDQXZMeUJwWmlCbGVHbHpkSE02Q2lBZ0lDQmllaUJ5WlcxdmRtVmZiV1Z0WW1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5EUTRMVFEwT1FvZ0lDQWdMeThnSXlCR2FXNWtJR0Z1WkNCeVpXMXZkbVVnZEdobElHSnBiR3hmYVdRS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2gxYzJWeVgySnBiR3h6TG14bGJtZDBhQ2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JpZFhKNUlEWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEVUtDbkpsYlc5MlpWOXRaVzFpWlhKZlptOXlYMmhsWVdSbGNrQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8wTkRndE5EUTVDaUFnSUNBdkx5QWpJRVpwYm1RZ1lXNWtJSEpsYlc5MlpTQjBhR1VnWW1sc2JGOXBaQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtIVnpaWEpmWW1sc2JITXViR1Z1WjNSb0tUb0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dOZ29nSUNBZ1BBb2dJQ0FnWW5vZ2NtVnRiM1psWDIxbGJXSmxjbDloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPalExTUFvZ0lDQWdMeThnYVdZZ2RYTmxjbDlpYVd4c2MxdHBYUzV1WVhScGRtVWdQVDBnWW1sc2JGOXBaRG9LSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTVDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUhKbGJXOTJaVjl0WlcxaVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBOVEV0TkRVeUNpQWdJQ0F2THlBaklFTnlaV0YwWlNCdVpYY2dZWEp5WVhrZ2QybDBhRzkxZENCMGFHbHpJR0pwYkd3S0lDQWdJQzh2SUc1bGQxOWlhV3hzY3lBOUlFUjVibUZ0YVdOQmNuSmhlVnRCVWtNMFZVbHVkRFkwWFNncENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pRMU13b2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0hWelpYSmZZbWxzYkhNdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURRS0NuSmxiVzkyWlY5dFpXMWlaWEpmWm05eVgyaGxZV1JsY2tBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBOVE1LSUNBZ0lDOHZJR1p2Y2lCcUlHbHVJSFZ5WVc1blpTaDFjMlZ5WDJKcGJHeHpMbXhsYm1kMGFDazZDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRFlLSUNBZ0lEd0tJQ0FnSUdKNklISmxiVzkyWlY5dFpXMWlaWEpmWVdaMFpYSmZabTl5UURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qUTFOQW9nSUNBZ0x5OGdhV1lnYWlBaFBTQnBPZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQWhQUW9nSUNBZ1lub2djbVZ0YjNabFgyMWxiV0psY2w5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRVMUNpQWdJQ0F2THlCdVpYZGZZbWxzYkhNdVlYQndaVzVrS0hWelpYSmZZbWxzYkhOYmFsMHBDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1JwWnlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ053b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR0oxY25rZ053b0tjbVZ0YjNabFgyMWxiV0psY2w5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pRMU13b2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0hWelpYSmZZbWxzYkhNdWJHVnVaM1JvS1RvS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0EwQ2lBZ0lDQmlJSEpsYlc5MlpWOXRaVzFpWlhKZlptOXlYMmhsWVdSbGNrQTJDZ3B5WlcxdmRtVmZiV1Z0WW1WeVgyRm1kR1Z5WDJadmNrQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRVM0NpQWdJQ0F2THlCcFppQnVaWGRmWW1sc2JITXViR1Z1WjNSb0lENGdNRG9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWW5vZ2NtVnRiM1psWDIxbGJXSmxjbDlsYkhObFgySnZaSGxBTVRJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5EVTRDaUFnSUNBdkx5QnZjQzVDYjNndWNIVjBLSFZ6WlhKZmEyVjVMQ0J1WlhkZlltbHNiSE11WW5sMFpYTXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHSnZlRjl3ZFhRS0NuSmxiVzkyWlY5dFpXMWlaWEpmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TWprekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsYlc5MlpWOXRaVzFpWlhKZlpXeHpaVjlpYjJSNVFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8wTmpBdE5EWXhDaUFnSUNBdkx5QWpJRVJsYkdWMFpTQmliM2dnYVdZZ1pXMXdkSGtLSUNBZ0lDOHZJR1JsYkdWMFpXUWdQU0J2Y0M1Q2IzZ3VaR1ZzWlhSbEtIVnpaWEpmYTJWNUtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRZeUNpQWdJQ0F2THlCaGMzTmxjblFnWkdWc1pYUmxaQ3dnSWtaaGFXeGxaQ0IwYnlCa1pXeGxkR1VnZFhObGNpQmliM2dpQ2lBZ0lDQmhjM05sY25RZ0x5OGdSbUZwYkdWa0lIUnZJR1JsYkdWMFpTQjFjMlZ5SUdKdmVBb2dJQ0FnWWlCeVpXMXZkbVZmYldWdFltVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtDbkpsYlc5MlpWOXRaVzFpWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5EUTRMVFEwT1FvZ0lDQWdMeThnSXlCR2FXNWtJR0Z1WkNCeVpXMXZkbVVnZEdobElHSnBiR3hmYVdRS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2gxYzJWeVgySnBiR3h6TG14bGJtZDBhQ2s2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQnlaVzF2ZG1WZmJXVnRZbVZ5WDJadmNsOW9aV0ZrWlhKQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmMzQnNhWFF1WTI5dWRISmhZM1F1UVd4bmIzTndiR2wwTG1Ga1pGOXRaVzFpWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaR1JmYldWdFltVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNelkxQ2lBZ0lDQXZMeUJpYVd4c1gybGtYMjVoZEdsMlpTQTlJR0pwYkd4ZmFXUXVibUYwYVhabENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TXpZMkNpQWdJQ0F2THlCemFHRnlaVjl1WVhScGRtVWdQU0J6YUdGeVpTNXVZWFJwZG1VS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TmpndE16WTVDaUFnSUNBdkx5QWpJRlpsY21sbWVTQk5RbElnY0dGNWJXVnVkQW9nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKTlFsSWdjR0Y1YldWdWRDQnRkWE4wSUdkdklIUnZJR0Z3Y0NJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMUNVaUJ3WVhsdFpXNTBJRzExYzNRZ1oyOGdkRzhnWVhCd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qUXdOd29nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6S0dJaVltbHNiRjhpS1NBcklHOXdMbWwwYjJJb1ltbHNiRjlwWkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qSTJPVFpqTm1NMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPak0zTXdvZ0lDQWdMeThnWW1sc2JGOWllWFJsY3l3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG1kbGRDaGlhV3hzWDJ0bGVTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TnpRS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pDYVd4c0lHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdZWE56WlhKMElDOHZJRUpwYkd3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TXpjM0xUTTNPQW9nSUNBZ0x5OGdJeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR0ZrWkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1ltbHNiQzVqY21WaGRHOXlMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJoWkdRZ2JXVnRZbVZ5Y3lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCaFpHUWdiV1Z0WW1WeWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnWW1sc2JDNXBjMTl6WlhSMGJHVmtMbTVoZEdsMlpTd2dJa05oYm01dmRDQnRiMlJwWm5rZ2MyVjBkR3hsWkNCaWFXeHNJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05EUTRDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJRzF2WkdsbWVTQnpaWFIwYkdWa0lHSnBiR3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TXpnd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJoaGNtVmZibUYwYVhabElENGdNQ3dnSWxOb1lYSmxJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUZOb1lYSmxJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmMzQnNhWFF2WTI5dWRISmhZM1F1Y0hrNk5ERXlDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vWWlKaWFXeHNYeUlwSUNzZ2IzQXVhWFJ2WWloaWFXeHNYMmxrS1NBcklFSjVkR1Z6S0dJaVgyMWxiV0psY2w4aUtTQXJJRzFsYldKbGNpNWllWFJsY3dvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMVpqWmtOalUyWkRZeU5qVTNNalZtQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNemcwQ2lBZ0lDQXZMeUJsZUdsemRHbHVaMTl0WlcxaVpYSmZZbmwwWlhNc0lHMWxiV0psY2w5bGVHbHpkSE1nUFNCdmNDNUNiM2d1WjJWMEtHMWxiV0psY2w5clpYa3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvek9EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdiV1Z0WW1WeVgyVjRhWE4wY3l3Z0lrMWxiV0psY2lCaGJISmxZV1I1SUdWNGFYTjBjeUlLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCTlpXMWlaWElnWVd4eVpXRmtlU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZNemczTFRNNU1Rb2dJQ0FnTHk4Z0l5QkRjbVZoZEdVZ2JXVnRZbVZ5SUdKdmVBb2dJQ0FnTHk4Z2JtVjNYMjFsYldKbGNpQTlJRTFsYldKbGNpZ0tJQ0FnSUM4dklDQWdJQ0J6YUdGeVpUMXphR0Z5WlY5dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ2NHRnBaRDFDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qTTVNQW9nSUNBZ0x5OGdjR0ZwWkQxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96T0RjdE16a3hDaUFnSUNBdkx5QWpJRU55WldGMFpTQnRaVzFpWlhJZ1ltOTRDaUFnSUNBdkx5QnVaWGRmYldWdFltVnlJRDBnVFdWdFltVnlLQW9nSUNBZ0x5OGdJQ0FnSUhOb1lYSmxQWE5vWVhKbFgyNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQndZV2xrUFVKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM053YkdsMEwyTnZiblJ5WVdOMExuQjVPak01TWdvZ0lDQWdMeThnYjNBdVFtOTRMbkIxZENodFpXMWlaWEpmYTJWNUxDQnVaWGRmYldWdFltVnlMbUo1ZEdWektRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96T1RRdE16azFDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQmlhV3hzQ2lBZ0lDQXZMeUJpYVd4c0xuUnZkR0ZzWDJGdGIzVnVkQ0FyUFNCemFHRnlaVjl1WVhScGRtVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUb3pPVFlLSUNBZ0lDOHZJR0pwYkd3dWJXVnRZbVZ5WDJOdmRXNTBJQ3M5SURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUEwTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvek9UY0tJQ0FnSUM4dklHOXdMa0p2ZUM1d2RYUW9ZbWxzYkY5clpYa3NJR0pwYkd3dVlubDBaWE1wQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzTndiR2wwTDJOdmJuUnlZV04wTG5CNU9qTTVPUzAwTURBS0lDQWdJQzh2SUNNZ1FXUmtJR0pwYkd3Z2RHOGdkWE5sY2lkeklIQmhjblJwWTJsd1lYUnBiMjRnYkdsemRBb2dJQ0FnTHk4Z2MyVnNaaTVmWVdSa1gySnBiR3hmZEc5ZmRYTmxjaWh0WlcxaVpYSXNJR0pwYkd4ZmFXUmZibUYwYVhabEtRb2dJQ0FnWTJGc2JITjFZaUJmWVdSa1gySnBiR3hmZEc5ZmRYTmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG96TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdkdmMzQnNhWFF1WTI5dWRISmhZM1F1UVd4bmIzTndiR2wwTGw5aFpHUmZZbWxzYkY5MGIxOTFjMlZ5S0hWelpYSTZJR0o1ZEdWekxDQmlhV3hzWDJsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNsOWhaR1JmWW1sc2JGOTBiMTkxYzJWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBNVGt0TkRJd0NpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjloWkdSZlltbHNiRjkwYjE5MWMyVnlLSE5sYkdZc0lIVnpaWEk2SUVGalkyOTFiblFzSUdKcGJHeGZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBNVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQkNlWFJsY3loaUluVnpaWEpmSWlrZ0t5QjFjMlZ5TG1KNWRHVnpDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROelUzTXpZMU56STFaZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl6Y0d4cGRDOWpiMjUwY21GamRDNXdlVG8wTWpNS0lDQWdJQzh2SUhWelpYSmZZbWxzYkhOZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2RYTmxjbDlyWlhrcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNOd2JHbDBMMk52Ym5SeVlXTjBMbkI1T2pReU5Rb2dJQ0FnTHk4Z2FXWWdaWGhwYzNSek9nb2dJQ0FnWW5vZ1gyRmtaRjlpYVd4c1gzUnZYM1Z6WlhKZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZOREk0Q2lBZ0lDQXZMeUIxYzJWeVgySnBiR3h6TG1Gd2NHVnVaQ2hCVWtNMFZVbHVkRFkwS0dKcGJHeGZhV1FwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRDQXZMeUJ2YmlCbGNuSnZjam9nYldGNElHRnljbUY1SUd4bGJtZDBhQ0JsZUdObFpXUmxaQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZORE13TFRRek1Rb2dJQ0FnTHk4Z0l5QkVaV3hsZEdVZ2IyeGtJR0p2ZUNCaGJtUWdZM0psWVhSbElHNWxkeUJ2Ym1VZ2QybDBhQ0JzWVhKblpYSWdjMmw2WlFvZ0lDQWdMeThnWkdWc1pYUmxaQ0E5SUc5d0xrSnZlQzVrWld4bGRHVW9kWE5sY2w5clpYa3BDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2YzNCc2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRNeUNpQWdJQ0F2THlCaGMzTmxjblFnWkdWc1pYUmxaQ3dnSWtaaGFXeGxaQ0IwYnlCa1pXeGxkR1VnZFhObGNpQmliM2dpQ2lBZ0lDQmhjM05sY25RZ0x5OGdSbUZwYkdWa0lIUnZJR1JsYkdWMFpTQjFjMlZ5SUdKdmVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXpjR3hwZEM5amIyNTBjbUZqZEM1d2VUbzBNek1LSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvZFhObGNsOXJaWGtzSUhWelpYSmZZbWxzYkhNdVlubDBaWE1wQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDbDloWkdSZlltbHNiRjkwYjE5MWMyVnlYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5emNHeHBkQzlqYjI1MGNtRmpkQzV3ZVRvME16VXRORE0yQ2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0J1WlhjZ2JHbHpkQW9nSUNBZ0x5OGdkWE5sY2w5aWFXeHNjeUE5SUVSNWJtRnRhV05CY25KaGVWdEJVa00wVlVsdWREWTBYU2hCVWtNMFZVbHVkRFkwS0dKcGJHeGZhV1FwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjM0JzYVhRdlkyOXVkSEpoWTNRdWNIazZORE0zQ2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VjSFYwS0hWelpYSmZhMlY1TENCMWMyVnlYMkpwYkd4ekxtSjVkR1Z6S1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlJTUFESmdnQkFBVmlhV3hzWHdoZmJXVnRZbVZ5WHdRVkgzeDFCUlVmZkhXQURHSnBiR3hmWTI5MWJuUmxjZ1YxYzJWeVh3SUFBREVZUUFBRUp3VWlaekViUVFCVk1Sa1VSREVZUklJS0JHT3FZYk1FQkNBNGxnU05UMTdjQkJ0S2UyY0VISUk4NkFRK2laTUlCT3JkTFBBRWxxeGV3QVNYVnAveUJDMTdEaG8yR2dDT0NnQUpBTmtCWVFGMkFaZ0J0QUhBQWVrQ1lBTmJBREVaRkRFWUZCQkRJa2syR2dGSEFpSlpTVTRDU1NVTGdRSUlUd0lWRWtRMkdnSkpUZ0pKSWxsSkpBdUJBZ2hQQWhVU1JERVdJd2xKT0JBakVrUkxBazhDRWtSTVJEZ0hNZ29TUkNJbkJXVkVJd2hKSndWTVp5SkpTVXNGREVFQUcwc0RWd0lBU3dGSlRnSWtDMXRKUkVzRENFVURJd2hGQVVMLzNrc0NGa2xGQ0NsTVVFbEZDVEVBU3dNV1VFc0dGbEFpRmxBb1VMOGlSUUZKU3dVTVFRQXdTd1ZYQWdCTEFVbE9BaVVMSlZoTEJWY0NBRXNDSkFza1dFc0tLbEJMQWxCTUtGQy9Td1NJQXhBakNFVUJRdi9KSzBzSFVMQWpRellhQVVrVkpCSkVNUllqQ1VrNEVDTVNSRXdYRmlsTVVFbE9Ba20rUkVraEJGTW9JazhDVkNKVEZFUXhBRThDS2xCTVVFbStSRW1CUUZNb0lrOENWQ0pURkVSTEF6Z0FNUUFTUkVzRE9BZExBMWNBSUJKRVR3TTRDRXNCSWxzU1JJRkFJMVMvU1lFd1d5TUlGbHd3UndLQk1GdE1nU2hiRWtFQUJDRUVJMVJMQVV5L0p3U3dJME0yR2dGSkZTUVNSQmNXS1V4UXZrUXJURkN3STBNMkdnRkpGU1FTUkRZYUFra1ZKUkpFVEJjV0tVeFFLbEJNVUw1RUsweFFzQ05ETmhvQlNSVWxFa1FuQmt4UXZrQUFDQ2NISzB4UXNDTkRTVUwvOWlJbkJXVkVGaXRNVUxBalF6WWFBVWtWSkJKRUZ4WXBURkJKdmtReEFFc0JWd0FnRWtSSmdUQmJGRVFoQkNOVXZ5Y0VzQ05ETmhvQlNSVWtFa1EyR2dKSkZTVVNSRFlhQTBrVkpCSkVUd0lYU3dFWFRCWXBURkJKdmtReEFFc0JWd0FnRWtSSklRUlRLQ0pQQWxRaVV4UkVTd0VxVUU4RlVFbStSRW1CUUZNb0lrOENWQ0pURkVSTEJFUkpJbHRMQXlWYlRBbFBCUWdXVHdOTVhDQk1Ud1JjQUU4Q1RMKy9Kd1N3STBNaVNZQUFSd0kyR2dGSkZTUVNSRFlhQWtrVkpSSkVUQmRKVGdJV0tVeFFTYjVFTVFCTEFWY0FJQkpFU1NFRVV5Z2lUd0pVSWxNVVJFbUJLRnNqRFVSTEFTcFFTd05RU2I1RVNZRkFVeWdpVHdKVUlsTVVSRXNDSlZ0TUlsc0pGazhDVEZ3Z1NZRW9XeU1KRmx3b1R3Sk12N3hFSndaTVVFbStRUUJxU1NKWlJRWWlSUVZMQkVzR0RFRUFXa2xYQWdCSlJRbExCU1FMVzBzREVrRUFWQ2NIUlFjaVJRUkxBMHNHREVFQUxVc0RTd1VUUVFBY1N3TWtDMHNJVENSWVN3ZEpUd0pRVENKWkl3Z1dWd1lDWEFCRkIwc0RJd2hGQkVML3kwc0dJbGxCQUFwTEFVc0h2eWNFc0NORFN3RzhSRUwvOUVzRUl3aEZCVUwvaVRZYUFVa1ZKQkpFTmhvQ1NSVWxFa1EyR2dOSkZTUVNSREVXSXdsSk9CQWpFa1JQQXhkUEFoZFBBamdITWdvU1JFc0JGaWxNVUVtK1JERUFTd0ZYQUNBU1JFa2hCRk1vSWs4Q1ZDSlRGRVJMQWtSTEFTcFFTd1ZRU2IxRkFSUkVTd01XS0ZDL1NTVmJUd01JRmx3Z1NZRW9XeU1JRmx3b3Y0Z0FCU2NFc0NORGlnSUFKd2FML2xCSnZreE9Ba0VBRzR2L0Zvc0FTVThDVUV3aVdTTUlGbGNHQWx3QVRFbThSRXkvaVl2L0ZvQUNBQUZNVUwrSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
