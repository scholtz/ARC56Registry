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

namespace Arc56.Generated.algorandfoundation.puya_ts.ContractTwo_b7246a81
{


    public class ContractTwoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractTwoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task RenamedSomeMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 140, 100, 243 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenamedSomeMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 140, 100, 243 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        /// <param name="asset"> </param>
        /// <param name="account"> </param>
        /// <param name="app"> </param>
        /// <param name="appTxn"> </param>
        public async Task ReferenceTypesIndex(PaymentTransaction pay, ApplicationCallTransaction appTxn, ulong app, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay, appTxn });
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 109, 98, 10, 196 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, pay, assetRefIndex, accountRefIndex, appRefIndex, appTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReferenceTypesIndex_Transactions(PaymentTransaction pay, ApplicationCallTransaction appTxn, ulong app, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay, appTxn });
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 109, 98, 10, 196 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay, assetRefIndex, accountRefIndex, appRefIndex, appTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        /// <param name="asset"> </param>
        /// <param name="account"> </param>
        /// <param name="app"> </param>
        /// <param name="appTxn"> </param>
        public async Task ReferenceTypesValue(PaymentTransaction pay, ApplicationCallTransaction appTxn, ulong asset, Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay, appTxn });
            byte[] abiHandle = { 70, 150, 17, 146 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, pay, assetAbi, accountAbi, appAbi, appTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReferenceTypesValue_Transactions(PaymentTransaction pay, ApplicationCallTransaction appTxn, ulong asset, Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay, appTxn });
            byte[] abiHandle = { 70, 150, 17, 146 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay, assetAbi, accountAbi, appAbi, appTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3RUd28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoicmVuYW1lZFNvbWVNZXRob2QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZlcmVuY2VUeXBlc0luZGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmVyZW5jZVR5cGVzVmFsdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcFR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjEsMjgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg5LDIwMCwyMTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwyOTFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODEsMjUyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRElnTmdvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUdNeVpUazFPVFpsQ2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREVLQ20xaGFXNWZZbXh2WTJ0QU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZEZSM2J5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXhDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJR05zWVhOeklFTnZiblJ5WVdOMFZIZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBT1FvZ0lDQWdZaUJ0WVdsdVgyTmhiR3hmVG05UGNFQXpDZ3B0WVdsdVgyTmhiR3hmVG05UGNFQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJR05zWVhOeklFTnZiblJ5WVdOMFZIZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORE00WXpZMFpqTWdMeThnYldWMGFHOWtJQ0p5Wlc1aGJXVmtVMjl0WlUxbGRHaHZaQ2dwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWTFPV1V6WTJNMElDOHZJRzFsZEdodlpDQWlkR1Z6ZENncFltOXZiQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFprTmpJd1lXTTBJQzh2SUcxbGRHaHZaQ0FpY21WbVpYSmxibU5sVkhsd1pYTkpibVJsZUNod1lYa3NZWE56WlhRc1lXTmpiM1Z1ZEN4aGNIQnNhV05oZEdsdmJpeGhjSEJzS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBOamsyTVRFNU1pQXZMeUJ0WlhSb2IyUWdJbkpsWm1WeVpXNWpaVlI1Y0dWelZtRnNkV1VvY0dGNUxIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJOQ3hoY0hCc0tYWnZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmNtVnVZVzFsWkZOdmJXVk5aWFJvYjJSZmNtOTFkR1ZBTkNCdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTlNCdFlXbHVYM0psWm1WeVpXNWpaVlI1Y0dWelNXNWtaWGhmY205MWRHVkFOaUJ0WVdsdVgzSmxabVZ5Wlc1alpWUjVjR1Z6Vm1Gc2RXVmZjbTkxZEdWQU53b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXMWxkR2h2WkMxelpXeGxZM1J2Y2k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCamJHRnpjeUJEYjI1MGNtRmpkRlIzYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDl5WldabGNtVnVZMlZVZVhCbGMxWmhiSFZsWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxdFpYUm9iMlF0YzJWc1pXTjBiM0l1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxjMjkxY21ObFJXNWpiMlJwYm1jNklDZDJZV3gxWlNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnY21WbVpYSmxibU5sVkhsd1pYTldZV3gxWlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5eVpXWmxjbVZ1WTJWVWVYQmxjMGx1WkdWNFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsYzI5MWNtTmxSVzVqYjJScGJtYzZJQ2RwYm1SbGVDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2NtVm1aWEpsYm1ObFZIbHdaWE5KYm1SbGVBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOTBaWE4wWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxdFpYUm9iMlF0YzJWc1pXTjBiM0l1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnZEdWemRDZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDl5Wlc1aGJXVmtVMjl0WlUxbGRHaHZaRjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdVlXMWxPaUFuY21WdVlXMWxaRk52YldWTlpYUm9iMlFuSUgwcENpQWdJQ0JqWVd4c2MzVmlJSE52YldWTlpYUm9iMlFLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Ub0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyNTBjbUZqZEZSM2J5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlVkMjh1YzI5dFpVMWxkR2h2WkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTnZiV1ZOWlhSb2IyUTZDaUFnSUNCaUlITnZiV1ZOWlhSb2IyUmZZbXh2WTJ0QU1Bb0tjMjl0WlUxbGRHaHZaRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdVlXMWxPaUFuY21WdVlXMWxaRk52YldWTlpYUm9iMlFuSUgwcENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1emIyMWxUV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVkhkdkxuUmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBPZ29nSUNBZ1lpQjBaWE4wWDJKc2IyTnJRREFLQ25SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QjBaWE4wS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxdFpYUm9iMlF0YzJWc1pXTjBiM0l1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JVZDI4dWRHVnpkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlVkMjh1Y21WbVpYSmxibU5sVkhsd1pYTkpibVJsZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxabVZ5Wlc1alpWUjVjR1Z6U1c1a1pYZzZDaUFnSUNCaUlISmxabVZ5Wlc1alpWUjVjR1Z6U1c1a1pYaGZZbXh2WTJ0QU1Bb0tjbVZtWlhKbGJtTmxWSGx3WlhOSmJtUmxlRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpYTnZkWEpqWlVWdVkyOWthVzVuT2lBbmFXNWtaWGduSUgwcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZ3Y0d4cFkyRjBhVzl1Y3dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRndjR3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXMWxkR2h2WkMxelpXeGxZM1J2Y2k1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEZSM2J5NXlaV1psY21WdVkyVlVlWEJsYzBsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFZIZHZMbkpsWm1WeVpXNWpaVlI1Y0dWelZtRnNkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXWmxjbVZ1WTJWVWVYQmxjMVpoYkhWbE9nb2dJQ0FnWWlCeVpXWmxjbVZ1WTJWVWVYQmxjMVpoYkhWbFgySnNiMk5yUURBS0NuSmxabVZ5Wlc1alpWUjVjR1Z6Vm1Gc2RXVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WemIzVnlZMlZGYm1OdlpHbHVaem9nSjNaaGJIVmxKeUI5S1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoY0hCc0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlVkMjh1Y21WbVpYSmxibU5sVkhsd1pYTldZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1emIyMWxUV1YwYUc5a0tDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBWSGR2TG5OdmJXVk5aWFJvYjJRNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXMWxkR2h2WkMxelpXeGxZM1J2Y2k1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEZSM2J5NXpiMjFsVFdWMGFHOWtYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1emIyMWxUV1YwYUc5a1gySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSVWQyOHVkR1Z6ZENncElDMCtJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBWSGR2TG5SbGMzUTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qcERiMjUwY21GamRGUjNieTUwWlhOMFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMVzFsZEdodlpDMXpaV3hsWTNSdmNpNWhiR2R2TG5Sek9qcERiMjUwY21GamRGUjNieTUwWlhOMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUcxbGRHaHZaRk5sYkdWamRHOXlLRU52Ym5SeVlXTjBUMjVsTG5CeWIzUnZkSGx3WlM1emIyMWxUV1YwYUc5a0tTQTlQVDBnYldWMGFHOWtVMlZzWldOMGIzSW9KM052YldWTlpYUm9iMlFvS1hWcGJuUTJOQ2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJRzFsZEdodlpDQWljMjl0WlUxbGRHaHZaQ2dwZFdsdWREWTBJZ29nSUNBZ1lubDBaV05mTUNBdkx5QnRaWFJvYjJRZ0luTnZiV1ZOWlhSb2IyUW9LWFZwYm5RMk5DSUtJQ0FnSUQwOUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXRaWFJvYjJRdGMyVnNaV04wYjNJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSVWQyOHVjbVZtWlhKbGJtTmxWSGx3WlhOSmJtUmxlQ2h3WVhrNklIVnBiblEyTkN3Z1lYTnpaWFE2SUhWcGJuUTJOQ3dnWVdOamIzVnVkRG9nWW5sMFpYTXNJR0Z3Y0RvZ2RXbHVkRFkwTENCaGNIQlVlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVkhkdkxuSmxabVZ5Wlc1alpWUjVjR1Z6U1c1a1pYZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6b3pNeTB6TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxjMjkxY21ObFJXNWpiMlJwYm1jNklDZHBibVJsZUNjZ2ZTa0tJQ0FnSUM4dklISmxabVZ5Wlc1alpWUjVjR1Z6U1c1a1pYZ29jR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGemMyVjBPaUJCYzNObGRDd2dZV05qYjNWdWREb2dRV05qYjNWdWRDd2dZWEJ3T2lCQmNIQnNhV05oZEdsdmJpd2dZWEJ3VkhodU9pQm5kSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiRlI0YmlrZ2UzMEtJQ0FnSUhCeWIzUnZJRFVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxdFpYUm9iMlF0YzJWc1pXTjBiM0l1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JVZDI4dWNtVm1aWEpsYm1ObFZIbHdaWE5KYm1SbGVGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF0WlhSb2IyUXRjMlZzWldOMGIzSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlVkMjh1Y21WbVpYSmxibU5sVkhsd1pYTkpibVJsZUY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGJXVjBhRzlrTFhObGJHVmpkRzl5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVkhkdkxuSmxabVZ5Wlc1alpWUjVjR1Z6Vm1Gc2RXVW9jR0Y1T2lCMWFXNTBOalFzSUdGemMyVjBPaUIxYVc1ME5qUXNJR0ZqWTI5MWJuUTZJR0o1ZEdWekxDQmhjSEE2SUhWcGJuUTJOQ3dnWVhCd1ZIaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1eVpXWmxjbVZ1WTJWVWVYQmxjMVpoYkhWbE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk16WXRNemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpYTnZkWEpqWlVWdVkyOWthVzVuT2lBbmRtRnNkV1VuSUgwcENpQWdJQ0F2THlCeVpXWmxjbVZ1WTJWVWVYQmxjMVpoYkhWbEtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoYzNObGREb2dRWE56WlhRc0lHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHRndjRG9nUVhCd2JHbGpZWFJwYjI0c0lHRndjRlI0YmpvZ1ozUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHeFVlRzRwSUh0OUNpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YldWMGFHOWtMWE5sYkdWamRHOXlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBWSGR2TG5KbFptVnlaVzVqWlZSNWNHVnpWbUZzZFdWZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRiV1YwYUc5a0xYTmxiR1ZqZEc5eUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFZIZHZMbkpsWm1WeVpXNWpaVlI1Y0dWelZtRnNkV1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFcxbGRHaHZaQzF6Wld4bFkzUnZjaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VvS1NBdFBpQjJiMmxrT2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1U2Q2lBZ0lDQmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd0NncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTURvS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQmlZQkJNTHBXVzVDQUFCQ0FBQXhHeU1UUVFCZVFnQUFNUmtqRWtReEdDTVRRUUJNUWdBQU5ob0FnQVJEakdUemdBVDFuanpFZ0FSdFlnckVnQVJHbGhHU1R3U09CQUFjQUJZQUVBQUtRZ0FBUWdBQVFnQUFBSWdBajBMLzg0Z0FRa0wvN1lnQUkwTC81NGdBRlVMLzRVTC80VEVaSXhJeEdDTVNFRVNJQU1ZaVEwSUFBSWdBcFNKRFFnQUFpQUNoZ0FFQUkwOENWSUFFRlI5OGRVOEJVTEFpUTBJQUFERVdKQWxKT0JBaUVrUTJHZ0ZKRlNJU1JCZkFNRFlhQWtrVkloSkVGOEFjTmhvRFNSVWlFa1FYd0RJeEZpSUpTVGdRSlJKRVR3UlBCRThFVHdSUEJJZ0FVQ0pEUWdBQU1SWWtDVWs0RUNJU1JEWWFBVWtWZ1FnU1JCYzJHZ0pKRllFZ0VrUTJHZ05KRllFSUVrUVhNUllpQ1VrNEVDVVNSRThFVHdSUEJFOEVUd1NJQUJRaVEwSUFBSWxDQUFBb0tCS0ppZ1VBUWdBQWlZb0ZBRUlBQUlsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
