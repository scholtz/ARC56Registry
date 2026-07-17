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

namespace Arc56.Generated.VedKalantri.escrow_service.HelloWorld_8e71aa24
{


    public class HelloWorldProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HelloWorldProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyer"> </param>
        /// <param name="seller"> </param>
        /// <param name="amount"> </param>
        public async Task<string> CreateOrder(byte[] buyer, byte[] seller, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 12, 201, 169 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sellerAbi.From(seller);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi, sellerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateOrder_Transactions(byte[] buyer, byte[] seller, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 12, 201, 169 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sellerAbi.From(seller);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi, sellerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MarkFunded(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 65, 42, 67 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MarkFunded_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 65, 42, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MarkDelivered(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 167, 115, 240 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MarkDelivered_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 167, 115, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> ConfirmReceipt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 127, 223, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ConfirmReceipt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 127, 223, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> RefundBuyer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 242, 248, 250 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RefundBuyer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 242, 248, 250 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> RaiseDispute(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 149, 85, 242 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RaiseDispute_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 149, 85, 242 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVsbG9Xb3JsZCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVPcmRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXJrRnVuZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya0RlbGl2ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpcm1SZWNlaXB0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kQnV5ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyYWlzZURpc3B1dGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM4N10sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBkaXNwdXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzdGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OV0sImVycm9yTWVzc2FnZSI6Ik5vdCBkZWxpdmVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzldLCJlcnJvck1lc3NhZ2UiOiJOb3QgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzNdLCJlcnJvck1lc3NhZ2UiOiJSZWZ1bmQgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsMjM2LDI2NiwyNzQsMjc4LDMxNywzMjYsMzM4LDM0MiwzODRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIsMTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5LDE1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnTlFvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzNSaGRIVnpJaUFpWVcxdmRXNTBJaUFpWW5WNVpYSWlJQ0p6Wld4c1pYSWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMUxUZ0tJQ0FnSUM4dklHSjFlV1Z5SUQwZ1lXeG5iM1J6TGtkc2IySmhiRk4wWVhSbFBHRnNaMjkwY3k1aWVYUmxjejRvZXdvZ0lDQWdMeThnSUNCclpYazZJQ2RpZFhsbGNpY3NDaUFnSUNBdkx5QWdJR2x1YVhScFlXeFdZV3gxWlRvZ1lXeG5iM1J6TGtKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW5WNVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QnBibWwwYVdGc1ZtRnNkV1U2SUdGc1oyOTBjeTVDZVhSbGN5Z3BMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFMVGdLSUNBZ0lDOHZJR0oxZVdWeUlEMGdZV3huYjNSekxrZHNiMkpoYkZOMFlYUmxQR0ZzWjI5MGN5NWllWFJsY3o0b2V3b2dJQ0FnTHk4Z0lDQnJaWGs2SUNkaWRYbGxjaWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxrSjVkR1Z6S0Nrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdMVEV6Q2lBZ0lDQXZMeUJ6Wld4c1pYSWdQU0JoYkdkdmRITXVSMnh2WW1Gc1UzUmhkR1U4WVd4bmIzUnpMbUo1ZEdWelBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ0ozTmxiR3hsY2ljc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMa0o1ZEdWektDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljMlZzYkdWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMa0o1ZEdWektDa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdMVEV6Q2lBZ0lDQXZMeUJ6Wld4c1pYSWdQU0JoYkdkdmRITXVSMnh2WW1Gc1UzUmhkR1U4WVd4bmIzUnpMbUo1ZEdWelBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ0ozTmxiR3hsY2ljc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMa0o1ZEdWektDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTFRFNENpQWdJQ0F2THlCaGJXOTFiblFnUFNCaGJHZHZkSE11UjJ4dlltRnNVM1JoZEdVOFlXeG5iM1J6TG5WcGJuUTJORDRvZXdvZ0lDQWdMeThnSUNCclpYazZJQ2RoYlc5MWJuUW5MQW9nSUNBZ0x5OGdJQ0JwYm1sMGFXRnNWbUZzZFdVNklHRnNaMjkwY3k1VmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXMXZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxsVnBiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5TMHhPQW9nSUNBZ0x5OGdZVzF2ZFc1MElEMGdZV3huYjNSekxrZHNiMkpoYkZOMFlYUmxQR0ZzWjI5MGN5NTFhVzUwTmpRK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lBbllXMXZkVzUwSnl3S0lDQWdJQzh2SUNBZ2FXNXBkR2xoYkZaaGJIVmxPaUJoYkdkdmRITXVWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUMweU13b2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1lXeG5iM1J6TGtkc2IySmhiRk4wWVhSbFBHRnNaMjkwY3k1MWFXNTBOalErS0hzS0lDQWdJQzh2SUNBZ2EyVjVPaUFuYzNSaGRIVnpKeXdLSUNBZ0lDOHZJQ0FnYVc1cGRHbGhiRlpoYkhWbE9pQmhiR2R2ZEhNdVZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCcGJtbDBhV0ZzVm1Gc2RXVTZJR0ZzWjI5MGN5NVZhVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXRNak1LSUNBZ0lDOHZJSE4wWVhSMWN5QTlJR0ZzWjI5MGN5NUhiRzlpWVd4VGRHRjBaVHhoYkdkdmRITXVkV2x1ZERZMFBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ0ozTjBZWFIxY3ljc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMbFZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nU0dWc2JHOVhiM0pzWkNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TXpCall6bGhPU0F3ZUROaE5ERXlZVFF6SURCNE1qUmhOemN6WmpBZ01IZ3hZVGRtWkdZeE9TQXdlRFl4WmpKbU9HWmhJREI0TWpBNU5UVTFaaklnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZQY21SbGNpaGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbTFoY210R2RXNWtaV1FvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpYldGeWEwUmxiR2wyWlhKbFpDZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmpiMjVtYVhKdFVtVmpaV2x3ZENncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKeVpXWjFibVJDZFhsbGNpZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlZV2x6WlVScGMzQjFkR1VvS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVTl5WkdWeUlHMWhjbXRHZFc1a1pXUWdiV0Z5YTBSbGJHbDJaWEpsWkNCamIyNW1hWEp0VW1WalpXbHdkQ0J5WldaMWJtUkNkWGxsY2lCeVlXbHpaVVJwYzNCMWRHVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdTR1ZzYkc5WGIzSnNaQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9raGxiR3h2VjI5eWJHUXVZM0psWVhSbFQzSmtaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZQY21SbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpjbVZoZEdWUGNtUmxjaWhpZFhsbGNqb2dZV3huYjNSekxtSjVkR1Z6TENCelpXeHNaWEk2SUdGc1oyOTBjeTVpZVhSbGN5d2dZVzF2ZFc1ME9pQmhiR2R2ZEhNdWRXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUzA0Q2lBZ0lDQXZMeUJpZFhsbGNpQTlJR0ZzWjI5MGN5NUhiRzlpWVd4VGRHRjBaVHhoYkdkdmRITXVZbmwwWlhNK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lBblluVjVaWEluTEFvZ0lDQWdMeThnSUNCcGJtbDBhV0ZzVm1Gc2RXVTZJR0ZzWjI5MGN5NUNlWFJsY3lncExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSjFlV1Z5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhSb2FYTXVZblY1WlhJdWRtRnNkV1VnUFNCaWRYbGxjZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXRNVE1LSUNBZ0lDOHZJSE5sYkd4bGNpQTlJR0ZzWjI5MGN5NUhiRzlpWVd4VGRHRjBaVHhoYkdkdmRITXVZbmwwWlhNK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lBbmMyVnNiR1Z5Snl3S0lDQWdJQzh2SUNBZ2FXNXBkR2xoYkZaaGJIVmxPaUJoYkdkdmRITXVRbmwwWlhNb0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpaV3hzWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2RHaHBjeTV6Wld4c1pYSXVkbUZzZFdVZ1BTQnpaV3hzWlhJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTFRFNENpQWdJQ0F2THlCaGJXOTFiblFnUFNCaGJHZHZkSE11UjJ4dlltRnNVM1JoZEdVOFlXeG5iM1J6TG5WcGJuUTJORDRvZXdvZ0lDQWdMeThnSUNCclpYazZJQ2RoYlc5MWJuUW5MQW9nSUNBZ0x5OGdJQ0JwYm1sMGFXRnNWbUZzZFdVNklHRnNaMjkwY3k1VmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXMXZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhSb2FYTXVZVzF2ZFc1MExuWmhiSFZsSUQwZ1lXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBdE1qTUtJQ0FnSUM4dklITjBZWFIxY3lBOUlHRnNaMjkwY3k1SGJHOWlZV3hUZEdGMFpUeGhiR2R2ZEhNdWRXbHVkRFkwUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nSjNOMFlYUjFjeWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxsVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQmhiR2R2ZEhNdVZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCamNtVmhkR1ZQY21SbGNpaGlkWGxsY2pvZ1lXeG5iM1J6TG1KNWRHVnpMQ0J6Wld4c1pYSTZJR0ZzWjI5MGN5NWllWFJsY3l3Z1lXMXZkVzUwT2lCaGJHZHZkSE11ZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3WkRSbU5USTBORFExTlRJMVpqUXpOVEkwTlRReE5UUTBOVFEwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTR1ZzYkc5WGIzSnNaQzV0WVhKclJuVnVaR1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXRnlhMFoxYm1SbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmhiR2R2ZEhNdVlYTnpaWEowS0hSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQmhiR2R2ZEhNdVZXbHVkRFkwS0RBcExDQW5TVzUyWVd4cFpDQnpkR0YwWlNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBdE1qTUtJQ0FnSUM4dklITjBZWFIxY3lBOUlHRnNaMjkwY3k1SGJHOWlZV3hUZEdGMFpUeGhiR2R2ZEhNdWRXbHVkRFkwUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nSjNOMFlYUjFjeWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxsVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1lXeG5iM1J6TG1GemMyVnlkQ2gwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5UFQwZ1lXeG5iM1J6TGxWcGJuUTJOQ2d3S1N3Z0owbHVkbUZzYVdRZ2MzUmhkR1VuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhOMFlYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNQzB5TXdvZ0lDQWdMeThnYzNSaGRIVnpJRDBnWVd4bmIzUnpMa2RzYjJKaGJGTjBZWFJsUEdGc1oyOTBjeTUxYVc1ME5qUStLSHNLSUNBZ0lDOHZJQ0FnYTJWNU9pQW5jM1JoZEhWekp5d0tJQ0FnSUM4dklDQWdhVzVwZEdsaGJGWmhiSFZsT2lCaGJHZHZkSE11VldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUIwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5SUdGc1oyOTBjeTVWYVc1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRzFoY210R2RXNWtaV1FvS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd05qUTJOVFUwWlRRME5EVTBOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9raGxiR3h2VjI5eWJHUXViV0Z5YTBSbGJHbDJaWEpsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWhjbXRFWld4cGRtVnlaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnWVd4bmIzUnpMbUZ6YzJWeWRDaDBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnWVd4bmIzUnpMbFZwYm5RMk5DZ3hLU3dnSjA1dmRDQm1kVzVrWldRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0xUSXpDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQmhiR2R2ZEhNdVIyeHZZbUZzVTNSaGRHVThZV3huYjNSekxuVnBiblEyTkQ0b2V3b2dJQ0FnTHk4Z0lDQnJaWGs2SUNkemRHRjBkWE1uTEFvZ0lDQWdMeThnSUNCcGJtbDBhV0ZzVm1Gc2RXVTZJR0ZzWjI5MGN5NVZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHRnNaMjkwY3k1aGMzTmxjblFvZEdocGN5NXpkR0YwZFhNdWRtRnNkV1VnUFQwOUlHRnNaMjkwY3k1VmFXNTBOalFvTVNrc0lDZE9iM1FnWm5WdVpHVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ1puVnVaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUMweU13b2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1lXeG5iM1J6TGtkc2IySmhiRk4wWVhSbFBHRnNaMjkwY3k1MWFXNTBOalErS0hzS0lDQWdJQzh2SUNBZ2EyVjVPaUFuYzNSaGRIVnpKeXdLSUNBZ0lDOHZJQ0FnYVc1cGRHbGhiRlpoYkhWbE9pQmhiR2R2ZEhNdVZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOUlHRnNaMjkwY3k1VmFXNTBOalFvTWlrS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUcxaGNtdEVaV3hwZG1WeVpXUW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3T1RRME5EVTBZelE1TlRZME5UVXlORFUwTkFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa2hsYkd4dlYyOXliR1F1WTI5dVptbHliVkpsWTJWcGNIUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjI1bWFYSnRVbVZqWldsd2REb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmhiR2R2ZEhNdVlYTnpaWEowS0hSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQmhiR2R2ZEhNdVZXbHVkRFkwS0RJcExDQW5UbTkwSUdSbGJHbDJaWEpsWkNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBdE1qTUtJQ0FnSUM4dklITjBZWFIxY3lBOUlHRnNaMjkwY3k1SGJHOWlZV3hUZEdGMFpUeGhiR2R2ZEhNdWRXbHVkRFkwUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nSjNOMFlYUjFjeWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxsVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1lXeG5iM1J6TG1GemMyVnlkQ2gwYUdsekxuTjBZWFIxY3k1MllXeDFaU0E5UFQwZ1lXeG5iM1J6TGxWcGJuUTJOQ2d5S1N3Z0owNXZkQ0JrWld4cGRtVnlaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmtaV3hwZG1WeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRMVFV6Q2lBZ0lDQXZMeUJoYkdkdmRITXVhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSFJvYVhNdWMyVnNiR1Z5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZEdocGN5NWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbk5sYkd4bGNpNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUMweE13b2dJQ0FnTHk4Z2MyVnNiR1Z5SUQwZ1lXeG5iM1J6TGtkc2IySmhiRk4wWVhSbFBHRnNaMjkwY3k1aWVYUmxjejRvZXdvZ0lDQWdMeThnSUNCclpYazZJQ2R6Wld4c1pYSW5MQW9nSUNBZ0x5OGdJQ0JwYm1sMGFXRnNWbUZzZFdVNklHRnNaMjkwY3k1Q2VYUmxjeWdwTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5ObGJHeGxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nZEdocGN5NXpaV3hzWlhJdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR0Z0YjNWdWREb2dkR2hwY3k1aGJXOTFiblF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXRNVGdLSUNBZ0lDOHZJR0Z0YjNWdWRDQTlJR0ZzWjI5MGN5NUhiRzlpWVd4VGRHRjBaVHhoYkdkdmRITXVkV2x1ZERZMFBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ0oyRnRiM1Z1ZENjc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMbFZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYlc5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZVzF2ZFc1ME9pQjBhR2x6TG1GdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ3ROVElLSUNBZ0lDOHZJR0ZzWjI5MGN5NXBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkR2hwY3k1elpXeHNaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxtRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRMVFV6Q2lBZ0lDQXZMeUJoYkdkdmRITXVhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSFJvYVhNdWMyVnNiR1Z5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZEdocGN5NWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0xUSXpDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQmhiR2R2ZEhNdVIyeHZZbUZzVTNSaGRHVThZV3huYjNSekxuVnBiblEyTkQ0b2V3b2dJQ0FnTHk4Z0lDQnJaWGs2SUNkemRHRjBkWE1uTEFvZ0lDQWdMeThnSUNCcGJtbDBhV0ZzVm1Gc2RXVTZJR0ZzWjI5MGN5NVZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMGdZV3huYjNSekxsVnBiblEyTkNnektRb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdZMjl1Wm1seWJWSmxZMlZwY0hRb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdPVFF6TkdZMFpEVXdOR00wTlRVME5EVTBOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9raGxiR3h2VjI5eWJHUXVjbVZtZFc1a1FuVjVaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXWjFibVJDZFhsbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnWVd4bmIzUnpMbFZwYm5RMk5DZ3hLU0I4ZkNCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdZV3huYjNSekxsVnBiblEyTkNnMUtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1DMHlNd29nSUNBZ0x5OGdjM1JoZEhWeklEMGdZV3huYjNSekxrZHNiMkpoYkZOMFlYUmxQR0ZzWjI5MGN5NTFhVzUwTmpRK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lBbmMzUmhkSFZ6Snl3S0lDQWdJQzh2SUNBZ2FXNXBkR2xoYkZaaGJIVmxPaUJoYkdkdmRITXVWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnWVd4bmIzUnpMbFZwYm5RMk5DZ3hLU0I4ZkNCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdZV3huYjNSekxsVnBiblEyTkNnMUtTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldaMWJtUkNkWGxsY2w5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0xUSXpDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQmhiR2R2ZEhNdVIyeHZZbUZzVTNSaGRHVThZV3huYjNSekxuVnBiblEyTkQ0b2V3b2dJQ0FnTHk4Z0lDQnJaWGs2SUNkemRHRjBkWE1uTEFvZ0lDQWdMeThnSUNCcGJtbDBhV0ZzVm1Gc2RXVTZJR0ZzWjI5MGN5NVZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMDlQU0JoYkdkdmRITXVWV2x1ZERZMEtERXBJSHg4SUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQmhiR2R2ZEhNdVZXbHVkRFkwS0RVcExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk15QXZMeUExQ2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZtZFc1a1FuVjVaWEpmWW05dmJGOW1ZV3h6WlVBMENncHlaV1oxYm1SQ2RYbGxjbDlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dweVpXWjFibVJDZFhsbGNsOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUMwMk13b2dJQ0FnTHk4Z1lXeG5iM1J6TG1GemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnZEdocGN5NXpkR0YwZFhNdWRtRnNkV1VnUFQwOUlHRnNaMjkwY3k1VmFXNTBOalFvTVNrZ2ZId2dkR2hwY3k1emRHRjBkWE11ZG1Gc2RXVWdQVDA5SUdGc1oyOTBjeTVWYVc1ME5qUW9OU2tzQ2lBZ0lDQXZMeUFnSUNkU1pXWjFibVFnYm05MElHRnNiRzkzWldRbkNpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnVW1WbWRXNWtJRzV2ZENCaGJHeHZkMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlMwM01Bb2dJQ0FnTHk4Z1lXeG5iM1J6TG1sMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUoxZVdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTVoYlc5MWJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklISmxZMlZwZG1WeU9pQjBhR2x6TG1KMWVXVnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVdE9Bb2dJQ0FnTHk4Z1luVjVaWElnUFNCaGJHZHZkSE11UjJ4dlltRnNVM1JoZEdVOFlXeG5iM1J6TG1KNWRHVnpQaWg3Q2lBZ0lDQXZMeUFnSUd0bGVUb2dKMkoxZVdWeUp5d0tJQ0FnSUM4dklDQWdhVzVwZEdsaGJGWmhiSFZsT2lCaGJHZHZkSE11UW5sMFpYTW9LU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppZFhsbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dkR2hwY3k1aWRYbGxjaTUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1lXMXZkVzUwT2lCMGFHbHpMbUZ0YjNWdWRDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlMweE9Bb2dJQ0FnTHk4Z1lXMXZkVzUwSUQwZ1lXeG5iM1J6TGtkc2IySmhiRk4wWVhSbFBHRnNaMjkwY3k1MWFXNTBOalErS0hzS0lDQWdJQzh2SUNBZ2EyVjVPaUFuWVcxdmRXNTBKeXdLSUNBZ0lDOHZJQ0FnYVc1cGRHbGhiRlpoYkhWbE9pQmhiR2R2ZEhNdVZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnRiM1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCaGJXOTFiblE2SUhSb2FYTXVZVzF2ZFc1MExuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlMwMk9Rb2dJQ0FnTHk4Z1lXeG5iM1J6TG1sMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUoxZVdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTVoYlc5MWJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlMwM01Bb2dJQ0FnTHk4Z1lXeG5iM1J6TG1sMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUoxZVdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTVoYlc5MWJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdMVEl6Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JoYkdkdmRITXVSMnh2WW1Gc1UzUmhkR1U4WVd4bmIzUnpMblZwYm5RMk5ENG9ld29nSUNBZ0x5OGdJQ0JyWlhrNklDZHpkR0YwZFhNbkxBb2dJQ0FnTHk4Z0lDQnBibWwwYVdGc1ZtRnNkV1U2SUdGc1oyOTBjeTVWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJSFJvYVhNdWMzUmhkSFZ6TG5aaGJIVmxJRDBnWVd4bmIzUnpMbFZwYm5RMk5DZzBLUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnY21WbWRXNWtRblY1WlhJb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdPRFV5TkRVME5qVTFOR1UwTkRRMU5EUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZtZFc1a1FuVjVaWEpmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY21WbWRXNWtRblY1WlhKZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9raGxiR3h2VjI5eWJHUXVjbUZwYzJWRWFYTndkWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtRnBjMlZFYVhOd2RYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR0ZzWjI5MGN5NWhjM05sY25Rb2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BUMDlJR0ZzWjI5MGN5NVZhVzUwTmpRb01pa3NJQ2REWVc1dWIzUWdaR2x6Y0hWMFpTY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXRNak1LSUNBZ0lDOHZJSE4wWVhSMWN5QTlJR0ZzWjI5MGN5NUhiRzlpWVd4VGRHRjBaVHhoYkdkdmRITXVkV2x1ZERZMFBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ0ozTjBZWFIxY3ljc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4V1lXeDFaVG9nWVd4bmIzUnpMbFZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdZV3huYjNSekxtRnpjMlZ5ZENoMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdZV3huYjNSekxsVnBiblEyTkNneUtTd2dKME5oYm01dmRDQmthWE53ZFhSbEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRZVzV1YjNRZ1pHbHpjSFYwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBdE1qTUtJQ0FnSUM4dklITjBZWFIxY3lBOUlHRnNaMjkwY3k1SGJHOWlZV3hUZEdGMFpUeGhiR2R2ZEhNdWRXbHVkRFkwUGloN0NpQWdJQ0F2THlBZ0lHdGxlVG9nSjNOMFlYUjFjeWNzQ2lBZ0lDQXZMeUFnSUdsdWFYUnBZV3hXWVd4MVpUb2dZV3huYjNSekxsVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQmhiR2R2ZEhNdVZXbHVkRFkwS0RVcENpQWdJQ0JwYm5Salh6TWdMeThnTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCeVlXbHpaVVJwYzNCMWRHVW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3T0RRME5EazFNelV3TlRVMU5EUTFORFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0JTWUVCbk4wWVhSMWN3WmhiVzkxYm5RRlluVjVaWElHYzJWc2JHVnlNUmhBQUE0cWdBQm5LNEFBWnlraVp5Z2laekViUVFBNU1Sa1VSREVZUklJR0JBTU15YWtFT2tFcVF3UWtwM1B3QkJwLzN4a0VZZkw0K2dRZ2xWWHlOaG9BamdZQUN3QmJBSFVBa3dER0FRa0FNUmtVTVJnVUVFUWpRellhQVVraVdTUUlTd0VWRWtSWEFnQTJHZ0pKSWxra0NFc0JGUkpFVndJQU5ob0RTUldCQ0JKRUZ5cFBBMmNyVHdKbktVeG5LQ0puZ0JNVkgzeDFBQTFQVWtSRlVsOURVa1ZCVkVWRXNDTkRJaWhsUkJSRUtDTm5nQXdWSDN4MUFBWkdWVTVFUlVTd0kwTWlLR1ZFSXhKRUtDUm5nQThWSDN4MUFBbEVSVXhKVmtWU1JVU3dJME1pS0dWRUpCSkVzU0lyWlVRaUtXVkVzZ2l5QnlPeUVDS3lBYk1vZ1FObmdBOFZIM3gxQUFsRFQwMVFURVZVUlVTd0kwTWlLR1ZFSXhKQUFBa2lLR1ZFSlJKQkFDMGpSTEVpS21WRUlpbGxSTElJc2djanNoQWlzZ0d6S0lFRVo0QU9GUjk4ZFFBSVVrVkdWVTVFUlVTd0kwTWlRdi9RSWlobFJDUVNSQ2dsWjRBT0ZSOThkUUFJUkVsVFVGVlVSVVN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
