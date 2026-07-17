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

namespace Arc56.Generated.ShreyashDabhade.PayStream.PayStream_e3c1b65f
{


    public class PayStreamProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PayStreamProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Vault must opt-in to USDCa to hold it.
        ///Only admin can trigger this to prevent spam.
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInToAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 37, 118, 152, 78 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 37, 118, 152, 78 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Log a deposit.
        ///The actual money transfer happens in the atomic group,  this method just validates it went to the vault.
        ///</summary>
        /// <param name="txn"> </param>
        public async Task Deposit(AssetTransferTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 147, 53, 49, 134 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(AssetTransferTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 147, 53, 49, 134 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///The PayStream Core: Release funds to a contractor.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task Payout(Address recipient, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 127, 102, 50, 152 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, recipientRefIndex, assetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Payout_Transactions(Address recipient, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 127, 102, 50, 152 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientRefIndex, assetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Rug pull protection? No, just letting the employer get their money back.
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task WithdrawAdmin(ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 202, 7, 78, 146 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawAdmin_Transactions(ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 202, 7, 78, 146 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5U3RyZWFtIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOiJWYXVsdCBtdXN0IG9wdC1pbiB0byBVU0RDYSB0byBob2xkIGl0LlxuT25seSBhZG1pbiBjYW4gdHJpZ2dlciB0aGlzIHRvIHByZXZlbnQgc3BhbS4iLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOiJMb2cgYSBkZXBvc2l0LlxuVGhlIGFjdHVhbCBtb25leSB0cmFuc2ZlciBoYXBwZW5zIGluIHRoZSBhdG9taWMgZ3JvdXAsICB0aGlzIG1ldGhvZCBqdXN0IHZhbGlkYXRlcyBpdCB3ZW50IHRvIHRoZSB2YXVsdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5b3V0IiwiZGVzYyI6IlRoZSBQYXlTdHJlYW0gQ29yZTogUmVsZWFzZSBmdW5kcyB0byBhIGNvbnRyYWN0b3IuIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19hZG1pbiIsImRlc2MiOiJSdWcgcHVsbCBwcm90ZWN0aW9uPyBObywganVzdCBsZXR0aW5nIHRoZSBlbXBsb3llciBnZXQgdGhlaXIgbW9uZXkgYmFjay4iLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjI3XSwiZXJyb3JNZXNzYWdlIjoiRGVwb3NpdCBtdXN0IGJlIHRvIHRoaXMgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NywxMDksMTM3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBPcHRJbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIGluaXRpYXRlIHBheW91dHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBvcHQtaW4gdG8gYXNzZXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MCwxMTIsMTQwLDE2M10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsMjQ5LDI4MSwyODhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZGVwb3NpdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHRjVYM04wY21WaGJTNWpiMjUwY21GamRDNVFZWGxUZEhKbFlXMHVYMTloYkdkdmNIbGZaVzUwY25sd2IybHVkRjkzYVhSb1gybHVhWFFvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURRS0lDQWdJR0o1ZEdWallteHZZMnNnSW1Ga2JXbHVJaUFpZEc5MFlXeGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVWOXpkSEpsWVcwdlkyOXVkSEpoWTNRdWNIazZNVEVLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzRnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaFpHMXBiaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwWldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QlFZWGxUZEhKbFlXMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1qVTNOams0TkdVZ01IZzVNek0xTXpFNE5pQXdlRGRtTmpZek1qazRJREI0WTJFd056UmxPVElnTHk4Z2JXVjBhRzlrSUNKdmNIUmZhVzVmZEc5ZllYTnpaWFFvWVhOelpYUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVndiM05wZENoaGVHWmxjaWwyYjJsa0lpd2diV1YwYUc5a0lDSndZWGx2ZFhRb1lXTmpiM1Z1ZEN4aGMzTmxkQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhkZllXUnRhVzRvWVhOelpYUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjl3ZEY5cGJsOTBiMTloYzNObGRGOXliM1YwWlVBMUlHMWhhVzVmWkdWd2IzTnBkRjl5YjNWMFpVQTJJRzFoYVc1ZmNHRjViM1YwWDNKdmRYUmxRRGNnYldGcGJsOTNhWFJvWkhKaGQxOWhaRzFwYmw5eWIzVjBaVUE0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QlFZWGxUZEhKbFlXMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZDJsMGFHUnlZWGRmWVdSdGFXNWZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbGZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGxmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRkJoZVZOMGNtVmhiU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRWE56WlhSekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCM2FYUm9aSEpoZDE5aFpHMXBiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXdZWGx2ZFhSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbGZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklGQmhlVk4wY21WaGJTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVY5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnY0dGNWIzVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxjRzl6YVhSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbGZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklGQmhlVk4wY21WaGJTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVY5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWkdWd2IzTnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJmYVc1ZmRHOWZZWE56WlhSZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFOXdkRWx1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUM0IwU1c0S0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVjl6ZEhKbFlXMHZZMjl1ZEhKaFkzUXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdVR0Y1VTNSeVpXRnRLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJjM05sZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnWTJGc2JITjFZaUJ2Y0hSZmFXNWZkRzlmWVhOelpYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJRWVhsVGRISmxZVzBvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQmhlVjl6ZEhKbFlXMHVZMjl1ZEhKaFkzUXVVR0Y1VTNSeVpXRnRMbTl3ZEY5cGJsOTBiMTloYzNObGRDaGhjM05sZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwdmNIUmZhVzVmZEc5ZllYTnpaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRveE5DMHhOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUM4dklHUmxaaUJ2Y0hSZmFXNWZkRzlmWVhOelpYUW9jMlZzWml3Z1lYTnpaWFE2SUVGemMyVjBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUc5d2RDMXBiaUIwYnlCaGMzTmxkSE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJRzl3ZEMxcGJpQjBieUJoYzNObGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbGZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPakl4TFRJMkNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0lDTWdSbVZsSUcxMWMzUWdZbVVnWTI5MlpYSmxaQ0JpZVNCMGFHVWdiM1YwWlhJZ2RISmhibk5oWTNScGIyNEtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGxmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6SWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5Qm1aV1U5TUNBaklFWmxaU0J0ZFhOMElHSmxJR052ZG1WeVpXUWdZbmtnZEdobElHOTFkR1Z5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSXhMVEkyQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3SUNNZ1JtVmxJRzExYzNRZ1ltVWdZMjkyWlhKbFpDQmllU0IwYUdVZ2IzVjBaWElnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjR0Y1WDNOMGNtVmhiUzVqYjI1MGNtRmpkQzVRWVhsVGRISmxZVzB1WkdWd2IzTnBkQ2gwZUc0NklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1pHVndiM05wZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTRMVEk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1pHVndiM05wZENoelpXeG1MQ0IwZUc0NklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUnlZVzV6WVdOMGFXOXVLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpUkdWd2IzTnBkQ0J0ZFhOMElHSmxJSFJ2SUhSb2FYTWdZMjl1ZEhKaFkzUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVJsY0c5emFYUWdiWFZ6ZENCaVpTQjBieUIwYUdseklHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlrWlhCdmMybDBaV1FnS3owZ2RIaHVMbUZ6YzJWMFgyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWtaWEJ2YzJsMFpXUWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlrWlhCdmMybDBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJoZVY5emRISmxZVzB1WTI5dWRISmhZM1F1VUdGNVUzUnlaV0Z0TG5CaGVXOTFkQ2h5WldOcGNHbGxiblE2SUdKNWRHVnpMQ0JoYzNObGREb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2NHRjViM1YwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVY5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk16Z3RNemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCd1lYbHZkWFFvYzJWc1ppd2djbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRc0lHRnRiM1Z1ZERvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlHbHVhWFJwWVhSbElIQmhlVzkxZEhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUdsdWFYUnBZWFJsSUhCaGVXOTFkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGxmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pRMUxUVXhDaUFnSUNBdkx5QWpJRWx1Ym1WeUlGUnlZVzV6WVdOMGFXOXVPaUJUWlc1a0lGVlRSRU5oSUhSdklHTnZiblJ5WVdOMGIzSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0lDTWdSVzF3Ykc5NVpYSWdjR0Y1Y3lCMGFHVWdabVZsQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUbzBOUzAwTmdvZ0lDQWdMeThnSXlCSmJtNWxjaUJVY21GdWMyRmpkR2x2YmpvZ1UyVnVaQ0JWVTBSRFlTQjBieUJqYjI1MGNtRmpkRzl5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGxmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCbVpXVTlNQ0FqSUVWdGNHeHZlV1Z5SUhCaGVYTWdkR2hsSUdabFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUbzBOUzAxTVFvZ0lDQWdMeThnSXlCSmJtNWxjaUJVY21GdWMyRmpkR2x2YmpvZ1UyVnVaQ0JWVTBSRFlTQjBieUJqYjI1MGNtRmpkRzl5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ0FqSUVWdGNHeHZlV1Z5SUhCaGVYTWdkR2hsSUdabFpRb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3WVhsZmMzUnlaV0Z0TG1OdmJuUnlZV04wTGxCaGVWTjBjbVZoYlM1M2FYUm9aSEpoZDE5aFpHMXBiaWhoYzNObGREb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2QybDBhR1J5WVhkZllXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMU15MDFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhkcGRHaGtjbUYzWDJGa2JXbHVLSE5sYkdZc0lHRnpjMlYwT2lCQmMzTmxkQ3dnWVcxdmRXNTBPaUJWU1c1ME5qUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnZDJsMGFHUnlZWGNpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSGRwZEdoa2NtRjNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8xT1MwMk5Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljMlZzWmk1aFpHMXBiaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5YzJWc1ppNWhaRzFwYml3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHlJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdabVZsUFRBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVY5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk5Ua3ROalFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhObGJHWXVZV1J0YVc0c0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVFSmdJRllXUnRhVzRQZEc5MFlXeGZaR1Z3YjNOcGRHVmtNUmhBQUFjb01RQm5LU0puTVJ0QkFJQ0NCQVFsZHBoT0JKTTFNWVlFZjJZeW1BVEtCMDZTTmhvQWpnUUFTZ0EwQUJnQUFpSkRNUmtVUkRFWVJEWWFBUmZBTURZYUFoZUlBS2tqUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0lYd0RBMkdnTVhpQUJ0STBNeEdSUkVNUmhFTVJZakNVazRFQ1FTUklnQVB5TkRNUmtqRWtReEdFUTJHZ0VYd0RDSUFBMGpRekVaUVArZU1SZ1VSQ05EaWdFQU1RQWlLR1ZFRWtTeE1nb2lzaEt5Rkl2L3NoRWtzaEFpc2dHemlZb0JBSXYvT0JReUNoSkVJaWxsUkl2L09CSUlLVXhuaVlvREFERUFJaWhsUkJKRXNZdi9zaEtML2JJVWkvNnlFU1N5RUNLeUFiT0ppZ0lBTVFBaUtHVkVFa1N4SWlobFJJdi9zaEt5Rkl2K3NoRWtzaEFpc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
