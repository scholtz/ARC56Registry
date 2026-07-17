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

namespace Arc56.Generated.joe_p.closed_loop_payments.Payments_6654a7c3
{


    public class PaymentsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PaymentsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MultiTransferArgTransfers : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static MultiTransferArgTransfers Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MultiTransferArgTransfers();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as MultiTransferArgTransfers);
                }
                public bool Equals(MultiTransferArgTransfers? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MultiTransferArgTransfers left, MultiTransferArgTransfers right)
                {
                    return EqualityComparer<MultiTransferArgTransfers>.Default.Equals(left, right);
                }
                public static bool operator !=(MultiTransferArgTransfers left, MultiTransferArgTransfers right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="supply"> </param>
        public async Task CreateApplication(ulong supply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 59, 97, 111 };
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);

            var result = await base.CallApp(new List<object> { abiHandle, supplyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong supply, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 59, 97, 111 };
            var supplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyAbi.From(supply);

            return await base.MakeTransactionList(new List<object> { abiHandle, supplyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="receiver"> </param>
        public async Task AddToCirculation(ulong amount, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 35, 106, 195 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddToCirculation_Transactions(ulong amount, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 35, 106, 195 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task InstantiateAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 83, 231, 66 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InstantiateAccount_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 83, 231, 66 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="accounts"> </param>
        public async Task InstantiateAccounts(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 151, 119, 35 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.CallApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InstantiateAccounts_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 151, 119, 35 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task Transfer(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 238, 116, 24 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 238, 116, 24 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="transfers"> MultiTransferArgTransfers</param>
        public async Task MultiTransfer(Structs.MultiTransferArgTransfers[] transfers, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 75, 18, 36 };
            var transfersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.MultiTransferArgTransfers>(x => Structs.MultiTransferArgTransfers.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; transfersAbi.From(transfers);

            var result = await base.CallApp(new List<object> { abiHandle, transfersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MultiTransfer_Transactions(Structs.MultiTransferArgTransfers[] transfers, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 75, 18, 36 };
            var transfersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.MultiTransferArgTransfers>(x => Structs.MultiTransferArgTransfers.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; transfersAbi.From(transfers);

            return await base.MakeTransactionList(new List<object> { abiHandle, transfersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5bWVudHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTXVsdGlUcmFuc2ZlckFyZ1RyYW5zZmVycyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdXBwbHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVG9DaXJjdWxhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbnN0YW50aWF0ZUFjY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5zdGFudGlhdGVBY2NvdW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdWx0aVRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQ2NClbXSIsInN0cnVjdCI6Ik11bHRpVHJhbnNmZXJBcmdUcmFuc2ZlcnMiLCJuYW1lIjoidHJhbnNmZXJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDI0XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NywyMTEsMjIxLDQxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MiwzNzddLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OCwzNDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFjY291bnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxjb250cmFjdHMvcGF5bWVudHMuYWxnby50czo6VHJhbnNmZXI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxLDI0NiwzMTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxLDE4MiwzMjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTldLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIGNhbiBjaXJjdWxhdGUgdG9rZW5zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE0XSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBjYW4gaW5zdGFudGlhdGUgYWNjb3VudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDcsNDQ5XSwiZXJyb3JNZXNzYWdlIjoicmVjZWl2ZXIgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDBdLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltSWlJQ0poSWlBaWJpSWdJbU1pQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQmhlVzFsYm5SeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WVdZeU16WmhZek1nTUhneU56VXpaVGMwTWlBd2VEQmtPVGMzTnpJeklEQjRPV1psWlRjME1UZ2dNSGhrT1RSaU1USXlOQ0F2THlCdFpYUm9iMlFnSW1Ga1pGUnZRMmx5WTNWc1lYUnBiMjRvZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWFXNXpkR0Z1ZEdsaGRHVkJZMk52ZFc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVc1emRHRnVkR2xoZEdWQlkyTnZkVzUwY3loaFpHUnlaWE56VzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWElvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJYVnNkR2xVY21GdWMyWmxjaWdvWVdSa2NtVnpjeXgxYVc1ME5qUXBXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0ZrWkZSdlEybHlZM1ZzWVhScGIyNGdhVzV6ZEdGdWRHbGhkR1ZCWTJOdmRXNTBJR2x1YzNSaGJuUnBZWFJsUVdOamIzVnVkSE1nZEhKaGJuTm1aWElnYlhWc2RHbFVjbUZ1YzJabGNnb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEazZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCaGVXMWxiblJ6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RjellqWXhObVlnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCbGNuSUtDZ292THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNlkyOTJaWEpHWldVb0tTQXRQaUIyYjJsa09ncGpiM1psY2tabFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5Qm1kVzVqZEdsdmJpQmpiM1psY2tabFpTZ3BJSHNLSUNBZ0lIQnliM1J2SURBZ01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHTnZibk4wSUdabFpWQmhlVzFsYm5RZ1BTQm5kSGh1TGxCaGVXMWxiblJVZUc0b1ZIaHVMbWR5YjNWd1NXNWtaWGdnS3lBeEtUc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHWmxaVkJoZVcxbGJuUXVjMlZ1WkdWeUlEMDlQU0JVZUc0dWMyVnVaR1Z5SUNZbUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6b3lNUzB5TXdvZ0lDQWdMeThnWm1WbFVHRjViV1Z1ZEM1elpXNWtaWElnUFQwOUlGUjRiaTV6Wlc1a1pYSWdKaVlLSUNBZ0lDOHZJQzh2SUVOb1pXTnJhVzVuSUhSb1pTQnlaV05sYVhabGNpQnBjeUJ3Y205aVlXSnNlU0J6ZFhCbGNtWnNkVzkxY3lCemFXNWpaU0IzWlNCc1lYUmxjaUJqYUdWamF5QmpiRzl6WlN3Z1luVjBJRzFwWjJoMElHRnpJSGRsYkd3Z1ltVWdjMkZtWlFvZ0lDQWdMeThnWm1WbFVHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNZ0ppWUtJQ0FnSUdKNklHTnZkbVZ5Um1WbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUdabFpWQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOeklDWW1DaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk1qRXRNak1LSUNBZ0lDOHZJR1psWlZCaGVXMWxiblF1YzJWdVpHVnlJRDA5UFNCVWVHNHVjMlZ1WkdWeUlDWW1DaUFnSUNBdkx5QXZMeUJEYUdWamEybHVaeUIwYUdVZ2NtVmpaV2wyWlhJZ2FYTWdjSEp2WW1GaWJIa2djM1Z3WlhKbWJIVnZkWE1nYzJsdVkyVWdkMlVnYkdGMFpYSWdZMmhsWTJzZ1kyeHZjMlVzSUdKMWRDQnRhV2RvZENCaGN5QjNaV3hzSUdKbElITmhabVVLSUNBZ0lDOHZJR1psWlZCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56SUNZbUNpQWdJQ0JpZWlCamIzWmxja1psWlY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJtWldWUVlYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ01DQW1KZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk1qRXRNalVLSUNBZ0lDOHZJR1psWlZCaGVXMWxiblF1YzJWdVpHVnlJRDA5UFNCVWVHNHVjMlZ1WkdWeUlDWW1DaUFnSUNBdkx5QXZMeUJEYUdWamEybHVaeUIwYUdVZ2NtVmpaV2wyWlhJZ2FYTWdjSEp2WW1GaWJIa2djM1Z3WlhKbWJIVnZkWE1nYzJsdVkyVWdkMlVnYkdGMFpYSWdZMmhsWTJzZ1kyeHZjMlVzSUdKMWRDQnRhV2RvZENCaGN5QjNaV3hzSUdKbElITmhabVVLSUNBZ0lDOHZJR1psWlZCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56SUNZbUNpQWdJQ0F2THlBdkx5QkZibk4xY21VZ2RHaGxJR0Z0YjNWdWRDQnBjeUI2WlhKdklITnZJSGRsSUdOaGJpQmlaU0J6ZFhKbElIUm9aU0JoWTJOdmRXNTBJR2x6SUc1dmRDQnpjR1Z1WkdsdVp5QkJURWRQSUc5dUlHRnVlWFJvYVc1bklHVnNjMlVLSUNBZ0lDOHZJR1psWlZCaGVXMWxiblF1WVcxdmRXNTBJRDA5UFNBd0lDWW1DaUFnSUNCaWJub2dZMjkyWlhKR1pXVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1ptVmxVR0Y1YldWdWRDNWpiRzl6WlZKbGJXRnBibVJsY2xSdklEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2QwZUc1eklFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TWpFdE1qa0tJQ0FnSUM4dklHWmxaVkJoZVcxbGJuUXVjMlZ1WkdWeUlEMDlQU0JVZUc0dWMyVnVaR1Z5SUNZbUNpQWdJQ0F2THlBdkx5QkRhR1ZqYTJsdVp5QjBhR1VnY21WalpXbDJaWElnYVhNZ2NISnZZbUZpYkhrZ2MzVndaWEptYkhWdmRYTWdjMmx1WTJVZ2QyVWdiR0YwWlhJZ1kyaGxZMnNnWTJ4dmMyVXNJR0oxZENCdGFXZG9kQ0JoY3lCM1pXeHNJR0psSUhOaFptVUtJQ0FnSUM4dklHWmxaVkJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJQ1ltQ2lBZ0lDQXZMeUF2THlCRmJuTjFjbVVnZEdobElHRnRiM1Z1ZENCcGN5QjZaWEp2SUhOdklIZGxJR05oYmlCaVpTQnpkWEpsSUhSb1pTQmhZMk52ZFc1MElHbHpJRzV2ZENCemNHVnVaR2x1WnlCQlRFZFBJRzl1SUdGdWVYUm9hVzVuSUdWc2MyVUtJQ0FnSUM4dklHWmxaVkJoZVcxbGJuUXVZVzF2ZFc1MElEMDlQU0F3SUNZbUNpQWdJQ0F2THlBdkx5QkJiSGRoZVhNZ1kyeHZjMlVnZEc4Z2RHaGxJR0Z3Y0NCMGJ5Qmxibk4xY21VZ2FYUWdaMlYwY3lCaVlXTnJJR0Z1ZVNCbGVHTmxjM01nWm5KdmJTQjBhR1VnYzJWdVpHVnlDaUFnSUNBdkx5QXZMeUJVYUdseklHbHpJR1Z6Y0dWamFXRnNiSGtnYVcxd2IzSjBZVzUwSUhOcGJtTmxJSGRsSUdGc2QyRjVjeUJ6Wlc1a0lFZHNiMkpoYkM1dGFXNUNZV3hoYm1ObENpQWdJQ0F2THlBdkx5QlVhR2x6SUdseklHRnNjMjhnYVcxd2IzSjBZVzUwSUdadmNpQjBhR1VnWm5WMGRYSmxJSGRvWlc0Z1ptVmxjeUJ0WVhrZ1ltVWdjbVZtZFc1a1lXSnNaUW9nSUNBZ0x5OGdabVZsVUdGNWJXVnVkQzVqYkc5elpWSmxiV0ZwYm1SbGNsUnZJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lub2dZMjkyWlhKR1pXVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvek15MHpPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ0x5OGdWMlVnWVd4M1lYbHpJR0ZrWkNCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNCaGMzTjFiV2x1WnlCMGFHVWdZV05qYjNWdWRDQm9ZWE1nTUNCQlRFZFBDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FySUdabFpWQmhlVzFsYm5RdVptVmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FySUdabFpWQmhlVzFsYm5RdVptVmxMQW9nSUNBZ1oyeHZZbUZzSUUxcGJrSmhiR0Z1WTJVS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQm5kSGh1Y3lCR1pXVUtJQ0FnSUNzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvek15MHpPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ0x5OGdWMlVnWVd4M1lYbHpJR0ZrWkNCSGJHOWlZV3d1YldsdVFtRnNZVzVqWlNCaGMzTjFiV2x1WnlCMGFHVWdZV05qYjNWdWRDQm9ZWE1nTUNCQlRFZFBDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJIYkc5aVlXd3ViV2x1UW1Gc1lXNWpaU0FySUdabFpWQmhlVzFsYm5RdVptVmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk16TXRNemtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lDOHZJRmRsSUdGc2QyRjVjeUJoWkdRZ1IyeHZZbUZzTG0xcGJrSmhiR0Z1WTJVZ1lYTnpkVzFwYm1jZ2RHaGxJR0ZqWTI5MWJuUWdhR0Z6SURBZ1FVeEhUd29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nUjJ4dlltRnNMbTFwYmtKaGJHRnVZMlVnS3lCbVpXVlFZWGx0Wlc1MExtWmxaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtTnZkbVZ5Um1WbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wY3k5d1lYbHRaVzUwY3k1aGJHZHZMblJ6T2pwUVlYbHRaVzUwY3k1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtITjFjSEJzZVRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dJbUVpSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QjBhR2x6TG1Ga2JXbHVMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjanNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdibTl1UTJseVkzVnNZWFJwYm1kVGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBaWJpSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p1SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUhSb2FYTXVibTl1UTJseVkzVnNZWFJwYm1kVGRYQndiSGt1ZG1Gc2RXVWdQU0J6ZFhCd2JIazdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUnpMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR05wY21OMWJHRjBhVzVuVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSW1NaUlIMHBPd29nSUNBZ1lubDBaV05mTXlBdkx5QWlZeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUIwYUdsekxtTnBjbU4xYkdGMGFXNW5VM1Z3Y0d4NUxuWmhiSFZsSUQwZ01Ec0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtITjFjSEJzZVRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T2xCaGVXMWxiblJ6TG1Ga1pGUnZRMmx5WTNWc1lYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUlViME5wY21OMWJHRjBhVzl1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUdGa1pGUnZRMmx5WTNWc1lYUnBiMjRvWVcxdmRXNTBPaUIxYVc1ME5qUXNJSEpsWTJWcGRtVnlPaUJCWTJOdmRXNTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d1lYbHRaVzUwY3k1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRnWTJGdUlHTnBjbU4xYkdGMFpTQjBiMnRsYm5NaUtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSW1FaUlIMHBPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlN3Z0ltOXViSGtnWVdSdGFXNGdZMkZ1SUdOcGNtTjFiR0YwWlNCMGIydGxibk1pS1RzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWVdSdGFXNGdZMkZ1SUdOcGNtTjFiR0YwWlNCMGIydGxibk1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJpWVd4aGJtTmxjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBaVlpSWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbUZzWVc1alpYTW9jbVZqWldsMlpYSXBMbVY0YVhOMGN5d2dJbkpsWTJWcGRtVnlJR1J2WlhNZ2JtOTBJR1Y0YVhOMElpazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSEpsWTJWcGRtVnlJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVqYVhKamRXeGhkR2x1WjFOMWNIQnNlUzUyWVd4MVpTQXJQU0JoYlc5MWJuUTdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHTnBjbU4xYkdGMGFXNW5VM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dJbU1pSUgwcE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVl5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBhR2x6TG1OcGNtTjFiR0YwYVc1blUzVndjR3g1TG5aaGJIVmxJQ3M5SUdGdGIzVnVkRHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHTnBjbU4xYkdGMGFXNW5VM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dJbU1pSUgwcE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVl5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBhR2x6TG1OcGNtTjFiR0YwYVc1blUzVndjR3g1TG5aaGJIVmxJQ3M5SUdGdGIzVnVkRHNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnZEdocGN5NXViMjVEYVhKamRXeGhkR2x1WjFOMWNIQnNlUzUyWVd4MVpTQXRQU0JoYlc5MWJuUTdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHNXZia05wY21OMWJHRjBhVzVuVTNWd2NHeDVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSW00aUlIMHBPd29nSUNBZ1lubDBaV05mTWlBdkx5QWliaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxtNXZia05wY21OMWJHRjBhVzVuVTNWd2NHeDVMblpoYkhWbElDMDlJR0Z0YjNWdWREc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnTFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUc1dmJrTnBjbU4xYkdGMGFXNW5VM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dJbTRpSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QjBhR2x6TG01dmJrTnBjbU4xYkdGMGFXNW5VM1Z3Y0d4NUxuWmhiSFZsSUMwOUlHRnRiM1Z1ZERzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh5WldObGFYWmxjaWt1ZG1Gc2RXVWdLejBnWVcxdmRXNTBPd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHRmtaRlJ2UTJseVkzVnNZWFJwYjI0b1lXMXZkVzUwT2lCMWFXNTBOalFzSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T2xCaGVXMWxiblJ6TG1sdWMzUmhiblJwWVhSbFFXTmpiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVjM1JoYm5ScFlYUmxRV05qYjNWdWREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QnBibk4wWVc1MGFXRjBaVUZqWTI5MWJuUW9ZV05qYjNWdWREb2dRV05qYjNWdWRDa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUdOdmJuUnlZV04wY3k5d1lYbHRaVzUwY3k1aGJHZHZMblJ6T2pwUVlYbHRaVzUwY3k1cGJuTjBZVzUwYVdGMFpVRmpZMjkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem82VUdGNWJXVnVkSE11YVc1emRHRnVkR2xoZEdWQlkyTnZkVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVjM1JoYm5ScFlYUmxRV05qYjNWdWRITTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdhVzV6ZEdGdWRHbGhkR1ZCWTJOdmRXNTBjeWhoWTJOdmRXNTBjem9nUVdOamIzVnVkRnRkS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhZMk52ZFc1MFBnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtbHVjM1JoYm5ScFlYUmxRV05qYjNWdWRITmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lXTmpiM1Z1ZENCdlppQmhZMk52ZFc1MGN5a2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2FXNXpkR0Z1ZEdsaGRHVkJZMk52ZFc1MGMxOWhablJsY2w5bWIzSkFOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdkR2hwY3k1cGJuTjBZVzUwYVdGMFpVRmpZMjkxYm5Rb1lXTmpiM1Z1ZENrN0NpQWdJQ0JqWVd4c2MzVmlJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPanBRWVhsdFpXNTBjeTVwYm5OMFlXNTBhV0YwWlVGalkyOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2FXNXpkR0Z1ZEdsaGRHVkJZMk52ZFc1MGMxOW1iM0pmYUdWaFpHVnlRRElLQ21sdWMzUmhiblJwWVhSbFFXTmpiM1Z1ZEhOZllXWjBaWEpmWm05eVFEVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdhVzV6ZEdGdWRHbGhkR1ZCWTJOdmRXNTBjeWhoWTJOdmRXNTBjem9nUVdOamIzVnVkRnRkS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T2xCaGVXMWxiblJ6TG5SeVlXNXpabVZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RISmhibk5tWlhJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RISmhibk5tWlhJb2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QjBhR2x6TGw5MGNtRnVjMlpsY2loVWVHNHVjMlZ1WkdWeUxDQnlaV05sYVhabGNpd2dZVzF2ZFc1MEtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnWTI5MlpYSkdaV1VvS1RzS0lDQWdJR05oYkd4emRXSWdZMjkyWlhKR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QjBjbUZ1YzJabGNpaHlaV05sYVhabGNqb2dRV05qYjNWdWRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNlVHRjViV1Z1ZEhNdWJYVnNkR2xVY21GdWMyWmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xMWJIUnBWSEpoYm5ObVpYSTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdiWFZzZEdsVWNtRnVjMlpsY2loMGNtRnVjMlpsY25NNklGUnlZVzV6Wm1WeVcxMHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem82VkhKaGJuTm1aWEkrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYlhWc2RHbFVjbUZ1YzJabGNsOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCN0lISmxZMlZwZG1WeUxDQmhiVzkxYm5RZ2ZTQnZaaUJqYkc5dVpTaDBjbUZ1YzJabGNuTXBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnRkV3gwYVZSeVlXNXpabVZ5WDJGbWRHVnlYMlp2Y2tBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QjBhR2x6TGw5MGNtRnVjMlpsY2loVWVHNHVjMlZ1WkdWeUxDQnlaV05sYVhabGNpd2dZVzF2ZFc1MEtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHMTFiSFJwVkhKaGJuTm1aWEpmWm05eVgyaGxZV1JsY2tBeUNncHRkV3gwYVZSeVlXNXpabVZ5WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQmhlVzFsYm5SekxtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QmpiM1psY2tabFpTZ3BPd29nSUNBZ1kyRnNiSE4xWWlCamIzWmxja1psWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUcxMWJIUnBWSEpoYm5ObVpYSW9kSEpoYm5ObVpYSnpPaUJVY21GdWMyWmxjbHRkS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T2xCaGVXMWxiblJ6TG1sdWMzUmhiblJwWVhSbFFXTmpiM1Z1ZENoaFkyTnZkVzUwT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02T2xCaGVXMWxiblJ6TG1sdWMzUmhiblJwWVhSbFFXTmpiM1Z1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d1lYbHRaVzUwY3k1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCcGJuTjBZVzUwYVdGMFpVRmpZMjkxYm5Rb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZENrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSW1FaUlIMHBPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8zTUMwM013b2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtRmtiV2x1TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FpYjI1c2VTQmhaRzFwYmlCallXNGdhVzV6ZEdGdWRHbGhkR1VnWVdOamIzVnVkSE1pTEFvZ0lDQWdMeThnS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHRmtiV2x1SUdOaGJpQnBibk4wWVc1MGFXRjBaU0JoWTJOdmRXNTBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUnpMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNKaUlpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCaGVXMWxiblJ6TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NWlZV3hoYm1ObGN5aGhZMk52ZFc1MEtTNWxlR2x6ZEhNc0lDSmhZMk52ZFc1MElHRnNjbVZoWkhrZ1pYaHBjM1J6SWlrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWVd4eVpXRmtlU0JsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MGN5NWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBhR2x6TG1KaGJHRnVZMlZ6S0dGalkyOTFiblFwTG5aaGJIVmxJRDBnTURzS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNlVHRjViV1Z1ZEhNdVgzUnlZVzV6Wm1WeUtITmxibVJsY2pvZ1lubDBaWE1zSUhKbFkyVnBkbVZ5T2lCaWVYUmxjeXdnWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbDkwY21GdWMyWmxjam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3WVhsdFpXNTBjeTVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJRjkwY21GdWMyWmxjaWh6Wlc1a1pYSTZJRUZqWTI5MWJuUXNJSEpsWTJWcGRtVnlPaUJCWTJOdmRXNTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1ltRnNZVzVqWlhNZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dJbUlpSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR0Y1YldWdWRITXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW1Gc1lXNWpaWE1vYzJWdVpHVnlLUzVsZUdsemRITXNJQ0p6Wlc1a1pYSWdaRzlsY3lCdWIzUWdaWGhwYzNRaUtUc0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdjMlZ1WkdWeUlHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0dGNWJXVnVkSE11WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWW1Gc1lXNWpaWE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ltSWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbUZzWVc1alpYTW9jbVZqWldsMlpYSXBMbVY0YVhOMGN5d2dJbkpsWTJWcGRtVnlJR1J2WlhNZ2JtOTBJR1Y0YVhOMElpazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSEpsWTJWcGRtVnlJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh6Wlc1a1pYSXBMblpoYkhWbElDMDlJR0Z0YjNWdWREc0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHRjViV1Z1ZEhNdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh5WldObGFYWmxjaWt1ZG1Gc2RXVWdLejBnWVcxdmRXNTBPd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFnQ0NZRUFXSUJZUUZ1QVdNeEdSUkVNUmhCQUN1Q0JRU3ZJMnJEQkNkVDUwSUVEWmQzSXdTZjduUVlCTmxMRWlRMkdnQ09CUUJyQUtzQXVBRHRBUW9BZ0FTWE8yRnZOaG9BamdFQVNBQ0tBQUF4RmlJSVJ3STRFQ0lTUkRnQU1RQVNRUUF3aXdBNEJ6SUtFa0VBSm9zQU9BaEFBQitMQURnSk1nb1NRUUFWc1RFQU1nR0xBRGdCQ0xJSXNnY2lzaEFqc2dHemlUWWFBVWtWSlJKRUZ5a3hBR2NxVEdjckkyY2lRellhQVVrVkpSSkVGellhQWtrVkpCSkVNUUFqS1dWRUVrUW9URkJKdlVVQlJDTXJaVVJMQWdnclRHY2pLbVZFU3dJSktreG5TYjVJRjA4Q0NCYS9Ja00yR2dGSkZTUVNSSWdBbWlKRE5ob0JSd0lqV1VsT0FpUUxnUUlJVEJVU1JDTkpTd0lNUVFBWVN3SlhBZ0JMQVVsT0FpUUxKRmlJQUd3aUNFVUJRdi9oSWtNMkdnRkpGU1FTUkRZYUFra1ZKUkpFRnpFQVRnS0lBR1NJL3djaVF6WWFBVWNDSTFsSlRnS0JLQXVCQWdoTUZSSkVJMGxMQWd4QkFDVkxBbGNDQUVzQlNVNENnU2dMZ1NoWVNWY0FJRXdrV3pFQVRnS0lBQ1VpQ0VVQlF2L1VpUDdCSWtPS0FRQXhBQ01wWlVRU1JDaUwvMUJKdlVVQkZFUWpGcitKaWdNQUtJdjlVRW05UlFGRUtJditVRW05UlFGRVN3RytTQmVML3drV1R3Sk12MG0rU0JlTC93Z1d2NGs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
