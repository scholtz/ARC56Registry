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

namespace Arc56.Generated.rushikesh2k04.medialgo.NFTContract_c2e45bec
{


    public class NFTContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFTContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task CreateApplication(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 60, 243, 27, 49 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 60, 243, 27, 49 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrpay"> </param>
        public async Task OptInToAsset(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AssetOptInSender(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 232, 167, 14, 83 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetOptInSender_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 232, 167, 14, 83 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        public async Task AssetTransferFromApp(Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 124, 99, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetTransferFromApp_Transactions(Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            _tx_accounts.AddRange(new List<Address> { receiver });
            byte receiverRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 124, 99, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, receiverRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTkZUQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icnBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldF9vcHRfaW5fc2VuZGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRfdHJhbnNmZXJfZnJvbV9hcHAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjEsODUsMTAzLDEyNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0LDg4LDEwNl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0aWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlYTnpaWFJwWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZOZ29nSUNBZ0x5OGdZMnhoYzNNZ1RrWlVRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pZMll6TVdJek1TQXdlREUxTnpRMU16VmhJREI0WlRoaE56QmxOVE1nTUhobFlqZGpOak5tWmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJpaGhjM05sZENsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0hSZmFXNWZkRzlmWVhOelpYUW9jR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ6YzJWMFgyOXdkRjlwYmw5elpXNWtaWElvWVhOelpYUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYTnpaWFJmZEhKaGJuTm1aWEpmWm5KdmJWOWhjSEFvWVhOelpYUXNZV05qYjNWdWRDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgyOXdkRjlwYmw5MGIxOWhjM05sZEY5eWIzVjBaVUEwSUcxaGFXNWZZWE56WlhSZmIzQjBYMmx1WDNObGJtUmxjbDl5YjNWMFpVQTFJRzFoYVc1ZllYTnpaWFJmZEhKaGJuTm1aWEpmWm5KdmJWOWhjSEJmY205MWRHVkFOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5Qk9SbFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGMzTmxkRjkwY21GdWMyWmxjbDltY205dFgyRndjRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRvME1pMDBNd29nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJCVTFORlZGOVVVa0ZPVTBaRlVnb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPallLSUNBZ0lDOHZJR05zWVhOeklFNUdWRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJjM05sZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPalF5TFRRekNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFRlRVMFZVWDFSU1FVNVRSa1ZTQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlYwWDNSeVlXNXpabVZ5WDJaeWIyMWZZWEJ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZ6YzJWMFgyOXdkRjlwYmw5elpXNWtaWEpmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5Qk9SbFJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRWE56WlhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlYwWDI5d2RGOXBibDl6Wlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQjBYMmx1WDNSdlgyRnpjMlYwWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qRTBMVEUxQ2lBZ0lDQXZMeUFnSXlCdmNIUWdhVzRnZEc4Z2RHaGxJR0Z6YzJWMElHbHVkRzhnZEdobElITnRZWEowSUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUbzJDaUFnSUNBdkx5QmpiR0Z6Y3lCT1JsUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pFMExURTFDaUFnSUNBdkx5QWdJeUJ2Y0hRZ2FXNGdkRzhnZEdobElHRnpjMlYwSUdsdWRHOGdkR2hsSUhOdFlYSjBJR052Ym5SeVlXTjBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2IzQjBYMmx1WDNSdlgyRnpjMlYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOWhjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRvNUxURXdDaUFnSUNBdkx5QWpZM0psWVhSbElIUm9aU0JoY0hBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qWUtJQ0FnSUM4dklHTnNZWE56SUU1R1ZFTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk9TMHhNQW9nSUNBZ0x5OGdJMk55WldGMFpTQjBhR1VnWVhCd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBzSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV1Wm5RdVkyOXVkSEpoWTNRdVRrWlVRMjl1ZEhKaFkzUXVZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVLR0Z6YzJWMFgybGtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbU55WldGMFpWOWhjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk9TMHhNUW9nSUNBZ0x5OGdJMk55WldGMFpTQjBhR1VnWVhCd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBzSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQXZMeUJrWldZZ1kzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtITmxiR1lzSUdGemMyVjBYMmxrT2lCQmMzTmxkQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnYzJWc1ppNWhjM05sZEdsa0lEMGdZWE56WlhSZmFXUXVhV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ6YzJWMGFXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJtWjBMbU52Ym5SeVlXTjBMazVHVkVOdmJuUnlZV04wTG05d2RGOXBibDkwYjE5aGMzTmxkQ2h0WW5Kd1lYazZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tiM0IwWDJsdVgzUnZYMkZ6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94TkMweE5nb2dJQ0FnTHk4Z0lDTWdiM0IwSUdsdUlIUnZJSFJvWlNCaGMzTmxkQ0JwYm5SdklIUm9aU0J6YldGeWRDQmpiMjUwY21GamRBb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnYjNCMFgybHVYM1J2WDJGemMyVjBLSE5sYkdZc0lHMWljbkJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG1selgyOXdkR1ZrWDJsdUtFRnpjMlYwS0hObGJHWXVZWE56WlhScFpDa3BDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnpjMlYwYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhScFpDQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5Y0dGNUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCaGMzTmxjblFnYldKeWNHRjVMbUZ0YjNWdWRDQTlQU0JIYkc5aVlXd3ViV2x1WDJKaGJHRnVZMlVnS3lCSGJHOWlZV3d1WVhOelpYUmZiM0IwWDJsdVgyMXBibDlpWVd4aGJtTmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWjJ4dlltRnNJRTFwYmtKaGJHRnVZMlVLSUNBZ0lHZHNiMkpoYkNCQmMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnS3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lOQzB5T1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlJSE5sYkdZdVlYTnpaWFJwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2owZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5SURBc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qSTJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2owZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMEwyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROUlEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRDOWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3lOQzB5T1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlJSE5sYkdZdVlYTnpaWFJwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2owZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5SURBc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbTVtZEM1amIyNTBjbUZqZEM1T1JsUkRiMjUwY21GamRDNWhjM05sZEY5dmNIUmZhVzVmYzJWdVpHVnlLR0Z6YzJWME9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtRnpjMlYwWDI5d2RGOXBibDl6Wlc1a1pYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pNeExUTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWVhOelpYUmZiM0IwWDJsdVgzTmxibVJsY2loelpXeG1MQ0JoYzNObGREb2dRWE56WlhRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablF2WTI5dWRISmhZM1F1Y0hrNk16UXRNemtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBMMk52Ym5SeVlXTjBMbkI1T2pNMExUTTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVablF1WTI5dWRISmhZM1F1VGtaVVEyOXVkSEpoWTNRdVlYTnpaWFJmZEhKaGJuTm1aWEpmWm5KdmJWOWhjSEFvWVhOelpYUTZJSFZwYm5RMk5Dd2djbVZqWldsMlpYSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhjM05sZEY5MGNtRnVjMlpsY2w5bWNtOXRYMkZ3Y0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZOREl0TkRRS0lDQWdJQzh2SUNNZ1pYaGhiWEJzWlRvZ1FWTlRSVlJmVkZKQlRsTkdSVklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaGMzTmxkRjkwY21GdWMyWmxjbDltY205dFgyRndjQ2h6Wld4bUxDQmhjM05sZERvZ1FYTnpaWFFzSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwSUNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kQzlqYjI1MGNtRmpkQzV3ZVRvME5TMDFNUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjaUE5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWElnUFNCeVpXTmxhWFpsY2l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBJRDBnWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MElEMGdNU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUhObGJtUmxjaUE5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwSUQwZ01Td0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUXZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5RdlkyOXVkSEpoWTNRdWNIazZORFV0TlRFS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeUlEMGdjbVZqWldsMlpYSXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZENBOUlHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkQ0E5SURFc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRUVKZ0VIWVhOelpYUnBaREViUVFBamdnUUVQUE1iTVFRVmRGTmFCT2luRGxNRTYzeGovellhQUk0RUFFSUFMQUFhQUFJaVF6RVpGRVF4R0VRMkdnRVh3REEyR2dJWHdCeUlBSmtqUXpFWkZFUXhHRVEyR2dFWHdEQ0lBSEFqUXpFWkZFUXhHRVF4RmlNSlNUZ1FJeEpFaUFBZEkwTXhHUlJFTVJnVVJEWWFBUmZBTUlnQUFpTkRpZ0VBS0l2L1o0bUtBUUF4QURJSkVrUXlDaUlvWlVSTVN3RndBRVVCRkVTTC96Z0hNZ29TUkl2L09BZ3lBVElRQ0JKRXNUSUtJcklTc2hTeUVTU3lFQ0t5QWJPSmlnRUFzVEVBSXJJU2kvK3lFYklVSkxJUUlySUJzNG1LQWdDeE1nb2pzaEtML3JJUmkvK3lGTElBSkxJUUlySUJzNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
