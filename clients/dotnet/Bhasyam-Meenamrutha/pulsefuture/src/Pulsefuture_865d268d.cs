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

namespace Arc56.Generated.Bhasyam_Meenamrutha.pulsefuture.Pulsefuture_865d268d
{


    public class PulsefutureProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PulsefutureProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Bill : AVMObjectType
            {
                public Algorand.Address UserAddress { get; set; }

                public Algorand.Address ReceiverAddress { get; set; }

                public ulong Amount { get; set; }

                public ulong DueDate { get; set; }

                public byte Status { get; set; }

                public string Description { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vUserAddress.From(UserAddress);
                    ret.AddRange(vUserAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiverAddress.From(ReceiverAddress);
                    ret.AddRange(vReceiverAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDueDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDueDate.From(DueDate);
                    ret.AddRange(vDueDate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
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

                public static Bill Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Bill();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vUserAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUserAddress = vUserAddress.ToValue();
                    if (valueUserAddress is Algorand.Address vUserAddressValue) { ret.UserAddress = vUserAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiverAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiverAddress = vReceiverAddress.ToValue();
                    if (valueReceiverAddress is Algorand.Address vReceiverAddressValue) { ret.ReceiverAddress = vReceiverAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDueDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDueDate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDueDate = vDueDate.ToValue();
                    if (valueDueDate is ulong vDueDateValue) { ret.DueDate = vDueDateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
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

        }

        ///<summary>
        ///Get the locked funds for a single user
        ///</summary>
        /// <param name="user_address"> </param>
        public async Task<ulong> GetLockedFunds(Algorand.Address user_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 6, 190, 80 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);

            var result = await base.CallApp(new List<object> { abiHandle, user_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLockedFunds_Transactions(Algorand.Address user_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 6, 190, 80 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lock funds for a user (store the locked amount per address)
        ///</summary>
        /// <param name="user_address"> </param>
        /// <param name="amount"> </param>
        public async Task<string> LockFunds(Algorand.Address user_address, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 122, 1 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, user_addressAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> LockFunds_Transactions(Algorand.Address user_address, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 122, 1 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_addressAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Store a bill for a user (multiple bills per user)
        ///</summary>
        /// <param name="user_address"> </param>
        /// <param name="description"> </param>
        /// <param name="amount"> </param>
        /// <param name="payee_address"> </param>
        /// <param name="due_date"> </param>
        public async Task<ulong> StoreBill(Address user_address, Address payee_address, string description, ulong amount, ulong due_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user_address, payee_address });
            byte user_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte payee_addressRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 229, 161, 6, 61 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var payee_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payee_addressAbi.From(payee_address);
            var due_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); due_dateAbi.From(due_date);

            var result = await base.CallApp(new List<object> { abiHandle, user_addressRefIndex, descriptionAbi, amountAbi, payee_addressRefIndex, due_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> StoreBill_Transactions(Address user_address, Address payee_address, string description, ulong amount, ulong due_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user_address, payee_address });
            byte user_addressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte payee_addressRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 229, 161, 6, 61 };
            var user_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); user_addressAbi.From(user_address);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var payee_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payee_addressAbi.From(payee_address);
            var due_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); due_dateAbi.From(due_date);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_addressRefIndex, descriptionAbi, amountAbi, payee_addressRefIndex, due_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark a bill as paid (just a stub for now)
        ///</summary>
        /// <param name="bill_id"> </param>
        public async Task<string> MarkBillPaid(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 107, 53, 68 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MarkBillPaid_Transactions(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 107, 53, 68 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get specific bill details for a user and bill ID
        ///</summary>
        /// <param name="bill_id"> </param>
        public async Task<Structs.Bill> GetBillDetails(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 50, 53, 152 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            var result = await base.CallApp(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Bill.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBillDetails_Transactions(ulong bill_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 50, 53, 152 };
            var bill_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_idAbi.From(bill_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, bill_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHVsc2VmdXR1cmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmlsbCI6W3sibmFtZSI6InVzZXJfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVjZWl2ZXJfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImR1ZV9kYXRlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImRlc2NyaXB0aW9uIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfbG9ja2VkX2Z1bmRzIiwiZGVzYyI6IkdldCB0aGUgbG9ja2VkIGZ1bmRzIGZvciBhIHNpbmdsZSB1c2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2NrX2Z1bmRzIiwiZGVzYyI6IkxvY2sgZnVuZHMgZm9yIGEgdXNlciAoc3RvcmUgdGhlIGxvY2tlZCBhbW91bnQgcGVyIGFkZHJlc3MpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdG9yZV9iaWxsIiwiZGVzYyI6IlN0b3JlIGEgYmlsbCBmb3IgYSB1c2VyIChtdWx0aXBsZSBiaWxscyBwZXIgdXNlcikiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVlX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR1ZV9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19iaWxsX3BhaWQiLCJkZXNjIjoiTWFyayBhIGJpbGwgYXMgcGFpZCAoanVzdCBhIHN0dWIgZm9yIG5vdykiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmlsbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9iaWxsX2RldGFpbHMiLCJkZXNjIjoiR2V0IHNwZWNpZmljIGJpbGwgZGV0YWlscyBmb3IgYSB1c2VyIGFuZCBiaWxsIElEIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ4LHN0cmluZykiLCJzdHJ1Y3QiOiJCaWxsIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMjZdLCJlcnJvck1lc3NhZ2UiOiJBbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MCw1NDJdLCJlcnJvck1lc3NhZ2UiOiJCaWxsIElEIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1LDE0NSwxNzMsMjE2LDI0NiwyNjhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjgsMTQ4LDE3NiwyMTksMjQ5LDI3MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODMsNTQ0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iaWxscyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTMsMzQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sb2NrZWRfZnVuZHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9iaWxsc19jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNIVnNjMlZtZFhSMWNtVXVZMjl1ZEhKaFkzUXVVSFZzYzJWbWRYUjFjbVV1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0luUnZkR0ZzWDJKcGJHeHpYMk52ZFc1MElpQXdlREF3TURBd01EQXdNREF3TURBd01EQWdJbUpwYkd4eklpQWliRzlqYTJWa1gyWjFibVJ6SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pNMUxUTTJDaUFnSUNBdkx5QWpJRWRzYjJKaGJDQnpkR0YwWlNCMGJ5QjBjbUZqYXlCMGIzUmhiQ0JpYVd4c2N5QmpiM1Z1ZEFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5aWFXeHNjMTlqYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMkpwYkd4elgyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSFZzYzJWbWRYUjFjbVVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGxpTURaaVpUVXdJREI0WlRObFlqZGhNREVnTUhnd01tSmxZMlV4TVNBd2VHVTFZVEV3TmpOa0lEQjRNakEyWWpNMU5EUWdNSGd4WXpNeU16VTVPQ0F2THlCdFpYUm9iMlFnSW1kbGRGOXNiMk5yWldSZlpuVnVaSE1vWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbXh2WTJ0ZlpuVnVaSE1vWVdSa2NtVnpjeXgxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm9aV3hzYnloemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZEc5eVpWOWlhV3hzS0dGalkyOTFiblFzYzNSeWFXNW5MSFZwYm5RMk5DeGhZMk52ZFc1MExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW0xaGNtdGZZbWxzYkY5d1lXbGtLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRjlpYVd4c1gyUmxkR0ZwYkhNb2RXbHVkRFkwS1NoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0N4emRISnBibWNwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDluWlhSZmJHOWphMlZrWDJaMWJtUnpYM0p2ZFhSbFFEVWdiV0ZwYmw5c2IyTnJYMloxYm1SelgzSnZkWFJsUURZZ2JXRnBibDlvWld4c2IxOXliM1YwWlVBM0lHMWhhVzVmYzNSdmNtVmZZbWxzYkY5eWIzVjBaVUE0SUcxaGFXNWZiV0Z5YTE5aWFXeHNYM0JoYVdSZmNtOTFkR1ZBT1NCdFlXbHVYMmRsZEY5aWFXeHNYMlJsZEdGcGJITmZjbTkxZEdWQU1UQUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VIVnNjMlZtZFhSMWNtVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgySnBiR3hmWkdWMFlXbHNjMTl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObFpuVjBkWEpsTDJOdmJuUnlZV04wTG5CNU9qRXhDaUFnSUNBdkx5QmpiR0Z6Y3lCUWRXeHpaV1oxZEhWeVpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObFpuVjBkWEpsTDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJuWlhSZlltbHNiRjlrWlhSaGFXeHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyMWhjbXRmWW1sc2JGOXdZV2xrWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFZzYzJWbWRYUjFjbVV2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VIVnNjMlZtZFhSMWNtVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYldGeWExOWlhV3hzWDNCaGFXUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMGIzSmxYMkpwYkd4ZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMWJITmxablYwZFhKbEwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QlFkV3h6WldaMWRIVnlaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMWJITmxablYwZFhKbEwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCemRHOXlaVjlpYVd4c0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJobGJHeHZYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhWc2MyVm1kWFIxY21Vb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHaGxiR3h2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXNiMk5yWDJaMWJtUnpYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhWc2MyVm1kWFIxY21Vb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdiRzlqYTE5bWRXNWtjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYkc5amEyVmtYMloxYm1SelgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hWc2MyVm1kWFIxY21VdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdVSFZzYzJWbWRYUjFjbVVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMnh2WTJ0bFpGOW1kVzVrY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TVRFS0lDQWdJQzh2SUdOc1lYTnpJRkIxYkhObFpuVjBkWEpsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFekNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdkV3h6WldaMWRIVnlaUzVqYjI1MGNtRmpkQzVRZFd4elpXWjFkSFZ5WlM1blpYUmZiRzlqYTJWa1gyWjFibVJ6S0hWelpYSmZZV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmYkc5amEyVmtYMloxYm1Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMWJITmxablYwZFhKbEwyTnZiblJ5WVdOMExuQjVPakV5TFRFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjlzYjJOclpXUmZablZ1WkhNb2MyVnNaaXdnZFhObGNsOWhaR1J5WlhOek9pQmhjbU0wTGtGa1pISmxjM01wSUMwK0lHRnlZelF1VlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hWc2MyVm1kWFIxY21VdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR2xtSUhWelpYSmZZV1JrY21WemN5QnBiaUJ6Wld4bUxteHZZMnRsWkY5bWRXNWtjem9LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WTJ0bFpGOW1kVzVrY3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwWDJ4dlkydGxaRjltZFc1a2MxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Ykc5amEyVmtYMloxYm1SelczVnpaWEpmWVdSa2NtVnpjMTBLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYjJOclpXUmZablZ1WkhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXNiMk5yWldSZlpuVnVaSE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hWc2MyVm1kWFIxY21VdVkyOXVkSEpoWTNRdVVIVnNjMlZtZFhSMWNtVXViRzlqYTE5bWRXNWtjeWgxYzJWeVgyRmtaSEpsYzNNNklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYkc5amExOW1kVzVrY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3lNQzB5TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCc2IyTnJYMloxYm1SektITmxiR1lzSUhWelpYSmZZV1JrY21WemN6b2dZWEpqTkM1QlpHUnlaWE56TENCaGJXOTFiblE2SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJoY21NMExsTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnWVhKak5DNVZTVzUwTmpRb01Da3NJQ0pCYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3lOaTB5TndvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCMWMyVnlJR0ZzY21WaFpIa2dhR0Z6SUd4dlkydGxaQ0JtZFc1a2N5d2dhV1lnYm05MElITjBZWEowSUhkcGRHZ2dNQW9nSUNBZ0x5OGdhV1lnZFhObGNsOWhaR1J5WlhOeklHbHVJSE5sYkdZdWJHOWphMlZrWDJaMWJtUnpPZ29nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqYTJWa1gyWjFibVJ6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnNiMk5yWDJaMWJtUnpYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFZzYzJWbWRYUjFjbVV2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklIQnlaWFlnUFNCelpXeG1MbXh2WTJ0bFpGOW1kVzVrYzF0MWMyVnlYMkZrWkhKbGMzTmRDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViRzlqYTJWa1gyWjFibVJ6SUdWdWRISjVJR1Y0YVhOMGN3b0tiRzlqYTE5bWRXNWtjMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TXpFdE16SUtJQ0FnSUM4dklDTWdRV1JrSUhSb1pTQnVaWGNnWVcxdmRXNTBJSFJ2SUdWNGFYTjBhVzVuSUd4dlkydGxaQ0JtZFc1a2N3b2dJQ0FnTHk4Z2MyVnNaaTVzYjJOclpXUmZablZ1WkhOYmRYTmxjbDloWkdSeVpYTnpYU0E5SUdGeVl6UXVWVWx1ZERZMEtIQnlaWFl1Ym1GMGFYWmxJQ3NnWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VTNSeWFXNW5LQ0pHZFc1a2N5QnNiMk5yWldRZ2MzVmpZMlZ6YzJaMWJHeDVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVRrME5qYzFObVUyTkRjek1qQTJZelptTmpNMllqWTFOalF5TURjek56VTJNell6TmpVM016Y3pOalkzTlRaak5tTTNPUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwc2IyTnJYMloxYm1SelgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCd2NtVjJJRDBnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSUd4dlkydGZablZ1WkhOZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQjFiSE5sWm5WMGRYSmxMbU52Ym5SeVlXTjBMbEIxYkhObFpuVjBkWEpsTG1obGJHeHZLRzVoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FHVnNiRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFZzYzJWbWRYUjFjbVV2WTI5dWRISmhZM1F1Y0hrNk5ERXRORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnYUdWc2JHOG9jMlZzWml3Z2JtRnRaVG9nVTNSeWFXNW5LU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnY21WMGRYSnVJQ0pJWld4c2J5d2dJaUFySUc1aGJXVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVNHVnNiRzhzSUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hWc2MyVm1kWFIxY21VdVkyOXVkSEpoWTNRdVVIVnNjMlZtZFhSMWNtVXVjM1J2Y21WZlltbHNiQ2gxYzJWeVgyRmtaSEpsYzNNNklHSjVkR1Z6TENCa1pYTmpjbWx3ZEdsdmJqb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCd1lYbGxaVjloWkdSeVpYTnpPaUJpZVhSbGN5d2daSFZsWDJSaGRHVTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3B6ZEc5eVpWOWlhV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObFpuVjBkWEpsTDJOdmJuUnlZV04wTG5CNU9qUTFMVFV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhOMGIzSmxYMkpwYkd3b0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5WDJGa1pISmxjM002SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVnpZM0pwY0hScGIyNDZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J3WVhsbFpWOWhaR1J5WlhOek9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1IxWlY5a1lYUmxPaUJWU1c1ME5qUUtJQ0FnSUM4dklDa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hWc2MyVm1kWFIxY21VdlkyOXVkSEpoWTNRdWNIazZOVGN0TlRnS0lDQWdJQzh2SUNNZ1IyVjBJR04xY25KbGJuUWdZbWxzYkNCamIzVnVkQ0JtYjNJZ2RHaHBjeUIxYzJWeUNpQWdJQ0F2THlCamRYSnlaVzUwWDJsa0lEMGdjMlZzWmk1MGIzUmhiRjlpYVd4c2MxOWpiM1Z1ZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJKcGJHeHpYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gySnBiR3h6WDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMWJITmxablYwZFhKbEwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJoYlc5MWJuUTlZWEpqTkM1VlNXNTBOalFvWVcxdmRXNTBLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCa2RXVmZaR0YwWlQxaGNtTTBMbFZKYm5RMk5DaGtkV1ZmWkdGMFpTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnWkdWelkzSnBjSFJwYjI0OVlYSmpOQzVUZEhKcGJtY29aR1Z6WTNKcGNIUnBiMjRwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TlRrdE5qWUtJQ0FnSUM4dklHSnBiR3dnUFNCQ2FXeHNLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSmZZV1JrY21WemN6MWhjbU0wTGtGa1pISmxjM01vZFhObGNsOWhaR1J5WlhOektTd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjbDloWkdSeVpYTnpQV0Z5WXpRdVFXUmtjbVZ6Y3lod1lYbGxaVjloWkdSeVpYTnpLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb1lXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ0lDQmtkV1ZmWkdGMFpUMWhjbU0wTGxWSmJuUTJOQ2hrZFdWZlpHRjBaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb01Da3NJQ0FqSURBZ1BTQjFibkJoYVdRc0lERWdQU0J3WVdsa0NpQWdJQ0F2THlBZ0lDQWdaR1Z6WTNKcGNIUnBiMjQ5WVhKak5DNVRkSEpwYm1jb1pHVnpZM0pwY0hScGIyNHBDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29NQ2tzSUNBaklEQWdQU0IxYm5CaGFXUXNJREVnUFNCd1lXbGtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pVNUxUWTJDaUFnSUNBdkx5QmlhV3hzSUQwZ1FtbHNiQ2dLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlYMkZrWkhKbGMzTTlZWEpqTkM1QlpHUnlaWE56S0hWelpYSmZZV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEpmWVdSa2NtVnpjejFoY21NMExrRmtaSEpsYzNNb2NHRjVaV1ZmWVdSa2NtVnpjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdaSFZsWDJSaGRHVTlZWEpqTkM1VlNXNTBOalFvWkhWbFgyUmhkR1VwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtEQXBMQ0FnSXlBd0lEMGdkVzV3WVdsa0xDQXhJRDBnY0dGcFpBb2dJQ0FnTHk4Z0lDQWdJR1JsYzJOeWFYQjBhVzl1UFdGeVl6UXVVM1J5YVc1bktHUmxjMk55YVhCMGFXOXVLUW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURVekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MbUpwYkd4elcyTjFjbkpsYm5SZmFXUmRJRDBnWW1sc2JDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWFXeHNjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaV1oxZEhWeVpTOWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5aWFXeHNjMTlqYjNWdWRDNTJZV3gxWlNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gySnBiR3h6WDJOdmRXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdOMWNuSmxiblJmYVdRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3ZFd4elpXWjFkSFZ5WlM1amIyNTBjbUZqZEM1UWRXeHpaV1oxZEhWeVpTNXRZWEpyWDJKcGJHeGZjR0ZwWkNoaWFXeHNYMmxrT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwdFlYSnJYMkpwYkd4ZmNHRnBaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRvM01TMDNNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJ0WVhKclgySnBiR3hmY0dGcFpDaHpaV3htTENCaWFXeHNYMmxrT2lCVlNXNTBOalFwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sWm5WMGRYSmxMMk52Ym5SeVlXTjBMbkI1T2pjMkNpQWdJQ0F2THlCaGMzTmxjblFnWW1sc2JGOXBaQ0JwYmlCelpXeG1MbUpwYkd4ekxDQWlRbWxzYkNCSlJDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW1sc2JITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUW1sc2JDQkpSQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCMWJITmxablYwZFhKbEwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJ1WlhkZlltbHNiQ0E5SUhObGJHWXVZbWxzYkhOYlltbHNiRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KcGJHeHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObFpuVjBkWEpsTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnVaWGRmWW1sc2JDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTRLREVwSUNBaklFMWhjbXNnWVhNZ2NHRnBaQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lISmxjR3hoWTJVeUlEZ3dDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlZtZFhSMWNtVXZZMjl1ZEhKaFkzUXVjSGs2TnprS0lDQWdJQzh2SUhObGJHWXVZbWxzYkhOYlltbHNiRjlwWkYwZ1BTQnVaWGRmWW1sc2JDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUW1sc2JDQnRZWEpyWldRZ1lYTWdjR0ZwWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkNhV3hzSUcxaGNtdGxaQ0JoY3lCd1lXbGtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3ZFd4elpXWjFkSFZ5WlM1amIyNTBjbUZqZEM1UWRXeHpaV1oxZEhWeVpTNW5aWFJmWW1sc2JGOWtaWFJoYVd4ektHSnBiR3hmYVdRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjlpYVd4c1gyUmxkR0ZwYkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hWc2MyVm1kWFIxY21VdlkyOXVkSEpoWTNRdWNIazZPREl0T0RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMkpwYkd4ZlpHVjBZV2xzY3loelpXeG1MQ0JpYVd4c1gybGtPaUJWU1c1ME5qUXBJQzArSUVKcGJHdzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdZWE56WlhKMElHSnBiR3hmYVdRZ2FXNGdjMlZzWmk1aWFXeHNjeXdnSWtKcGJHd2dTVVFnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSnBiR3h6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFSnBiR3dnU1VRZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WldaMWRIVnlaUzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1ltbHNiQ0E5SUhObGJHWXVZbWxzYkhOYlltbHNiRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWFXeHNjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpXWjFkSFZ5WlM5amIyNTBjbUZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHSnBiR3dLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJRUVZIM3gxRVhSdmRHRnNYMkpwYkd4elgyTnZkVzUwQ0FBQUFBQUFBQUFBQldKcGJHeHpER3h2WTJ0bFpGOW1kVzVrY3pFWVFBQURLU05uTVJ0QkFOV0NCZ1NiQnI1UUJPUHJlZ0VFQXI3T0VRVGxvUVk5QkNCck5VUUVIREkxbURZYUFJNEdBSkVBZXdCZEFESUFGZ0FDSTBNeEdSUkVNUmhFTmhvQkY0Z0JpU2hNVUxBaVF6RVpGRVF4R0VRMkdnRVhpQUUzU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ1Z3SUFOaG9ERnpZYUJCZkFIRFlhQlJlSUFNWVdLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdBbjBrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQW9nQVBDaE1VTEFpUXpFWkZFUXhHRVEyR2dHSUFCRW9URkN3SWtNeEdVRC9WekVZRkVRaVE0b0JBU2NFaS85UVNiMUZBVUVBQm9zQXZrUk1pU3BNaVlvQ0FZdi9LcVZFSndTTC9sQkp2VVVCUVFBdGl3QytSQmVML3hjSUZvc0FUTCtBR3dBWlJuVnVaSE1nYkc5amEyVmtJSE4xWTJObGMzTm1kV3hzZVV5SktrTC8wNG9CQVlBSFNHVnNiRzhzSUl2L1VJbUtCUUVqS1dWRWkvMFdpLzhXaS93VkZsY0dBb3Y4VUl2N2kvNVFUd05RVHdKUWdBRUFVSUFDQUZOUVRGQkxBUllyVEZCSnZFaE12MGtpQ0NsTVo0bUtBUUdML3hZclRGQkp2VVVCUkVtK1JJQUJBVnhRU3dHOFNMK0FJRUpwYkd3Z2JXRnlhMlZrSUdGeklIQmhhV1FnYzNWalkyVnpjMloxYkd4NWlZb0JBWXYvRml0TVVFbTlSUUZFdmtTSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
