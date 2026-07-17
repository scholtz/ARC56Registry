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

namespace Arc56.Generated.aorumbayev.puya.Auction_e30a50f3
{


    public class AuctionProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AuctionProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptIntoAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 40, 38, 178, 2 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIntoAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 40, 38, 178, 2 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="starting_price"> </param>
        /// <param name="length"> </param>
        /// <param name="axfer"> </param>
        public async Task StartAuction(AssetTransferTransaction axfer, ulong starting_price, ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 240, 170, 112, 35 };
            var starting_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); starting_priceAbi.From(starting_price);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, starting_priceAbi, lengthAbi, axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartAuction_Transactions(AssetTransferTransaction axfer, ulong starting_price, ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 240, 170, 112, 35 };
            var starting_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); starting_priceAbi.From(starting_price);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, starting_priceAbi, lengthAbi, axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task Bid(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 219, 127, 232, 67 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 219, 127, 232, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimBids(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 84, 98, 91 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimBids_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 84, 98, 91 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task ClaimAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 30, 193, 43, 239 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 30, 193, 43, 239 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXVjdGlvbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRfaW50b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YXJ0X2F1Y3Rpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnRpbmdfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheGZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9iaWRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODNdLCJlcnJvck1lc3NhZ2UiOiJBU0EgYWxyZWFkeSBvcHRlZCBpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MF0sImVycm9yTWVzc2FnZSI6IkJpZCBtdXN0IGJlIGhpZ2hlciB0aGFuIHByZXZpb3VzIGJpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MSwxNjksMTgxLDIwMywyMTIsMjQyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBvcHQgaW4gdG8gQVNBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjoiYXVjdGlvbiBhbHJlYWR5IHN0YXJ0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTldLCJlcnJvck1lc3NhZ2UiOiJhdWN0aW9uIGhhcyBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6ImF1Y3Rpb24gaGFzIG5vdCBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNF0sImVycm9yTWVzc2FnZSI6ImF1Y3Rpb24gbXVzdCBiZSBzdGFydGVkIGJ5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjhdLCJlcnJvck1lc3NhZ2UiOiJheGZlciBtdXN0IHRyYW5zZmVyIHRvIHRoaXMgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0LDE3MiwxODQsMjA2LDIxNSwyNDVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc2FfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOCwzNTcsNDY4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdWN0aW9uX2VuZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNsYWltYWJsZV9hbW91bnQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc2LDQyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJldmlvdXNfYmlkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNiw0NzUsNDc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcmV2aW91c19iaWRkZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY4XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBzZW5kZXIgbXVzdCBtYXRjaCB0cmFuc2FjdGlvbiBzZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmxlR0Z0Y0d4bGN5NWhkV04wYVc5dUxtTnZiblJ5WVdOMExrRjFZM1JwYjI0dVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUYxWTNScGIyNWZaVzVrSWlBaWNISmxkbWx2ZFhOZlltbGtJaUFpY0hKbGRtbHZkWE5mWW1sa1pHVnlJaUFpWVhOaFgyRnRiM1Z1ZENJZ0ltRnpZU0lnSW1Oc1lXbHRJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdjMlZzWmk1aGRXTjBhVzl1WDJWdVpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWFZqZEdsdmJsOWxibVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhObGJHWXVjSEpsZG1sdmRYTmZZbWxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2NtVjJhVzkxYzE5aWFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJSE5sYkdZdVlYTmhYMkZ0YjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWE5oWDJGdGIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TVFvZ0lDQWdMeThnYzJWc1ppNWhjMkVnUFNCQmMzTmxkQ2dwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poYzJFaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklITmxiR1l1Y0hKbGRtbHZkWE5mWW1sa1pHVnlJRDBnUVdOamIzVnVkQ2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3Y21WMmFXOTFjMTlpYVdSa1pYSWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUdOc1lYTnpJRUYxWTNScGIyNG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VESTRNalppTWpBeUlEQjRaakJoWVRjd01qTWdNSGd6TUdNMlpEVTRZU0F3ZUdSaU4yWmxPRFF6SURCNFpUWTFORFl5TldJZ01IZ3haV014TW1KbFppQXZMeUJ0WlhSb2IyUWdJbTl3ZEY5cGJuUnZYMkZ6YzJWMEtHRnpjMlYwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4wWVhKMFgyRjFZM1JwYjI0b2RXbHVkRFkwTEhWcGJuUTJOQ3hoZUdabGNpbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNIUmZhVzRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUpwWkNod1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeGhhVzFmWW1sa2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeGhhVzFmWVhOelpYUW9ZWE56WlhRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZiM0IwWDJsdWRHOWZZWE56WlhSZmNtOTFkR1ZBTlNCdFlXbHVYM04wWVhKMFgyRjFZM1JwYjI1ZmNtOTFkR1ZBTmlCdFlXbHVYMjl3ZEY5cGJsOXliM1YwWlVBM0lHMWhhVzVmWW1sa1gzSnZkWFJsUURnZ2JXRnBibDlqYkdGcGJWOWlhV1J6WDNKdmRYUmxRRGtnYldGcGJsOWpiR0ZwYlY5aGMzTmxkRjl5YjNWMFpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFek9nb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdZMnhoYzNNZ1FYVmpkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpiR0ZwYlY5aGMzTmxkRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakUyQ2lBZ0lDQXZMeUJqYkdGemN5QkJkV04wYVc5dUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCamJHRnBiVjloYzNObGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amJHRnBiVjlpYVdSelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmpiR0ZwYlY5aWFXUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnBaRjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJR05zWVhOeklFRjFZM1JwYjI0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0pwWkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMFlYSjBYMkYxWTNScGIyNWZjbTkxZEdWQU5qb0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRXTjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzNSaGNuUmZZWFZqZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dmNIUmZhVzUwYjE5aGMzTmxkRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJR05zWVhOeklFRjFZM1JwYjI0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUc5d2RGOXBiblJ2WDJGemMyVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TVRvS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWUtJQ0FnSUM4dklHTnNZWE56SUVGMVkzUnBiMjRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdaWGhoYlhCc1pYTXVZWFZqZEdsdmJpNWpiMjUwY21GamRDNUJkV04wYVc5dUxtOXdkRjlwYm5SdlgyRnpjMlYwS0dGemMyVjBPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbTl3ZEY5cGJuUnZYMkZ6YzJWME9nb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lOUzB5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYjNCMFgybHVkRzlmWVhOelpYUW9jMlZzWml3Z1lYTnpaWFE2SUVGemMyVjBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTNMVEk0Q2lBZ0lDQXZMeUFqSUU5dWJIa2dZV3hzYjNjZ1lYQndJR055WldGMGIzSWdkRzhnYjNCMElIUm9aU0JoY0hBZ1lXTmpiM1Z1ZENCcGJuUnZJR0VnUVZOQkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCdmNIUWdhVzRnZEc4Z1FWTkJJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdiM0IwSUdsdUlIUnZJRUZUUVFvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU9TMHpNQW9nSUNBZ0x5OGdJeUJXWlhKcFpua2dZU0JCVTBFZ2FHRnpiaWQwSUdGc2NtVmhaSGtnWW1WbGJpQnZjSFJsWkNCcGJuUnZDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoYzJFdWFXUWdQVDBnTUN3Z0lrRlRRU0JoYkhKbFlXUjVJRzl3ZEdWa0lHbHVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRnpZU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMyRWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRVk5CSUdGc2NtVmhaSGtnYjNCMFpXUWdhVzRLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpFdE16SUtJQ0FnSUM4dklDTWdVMkYyWlNCQlUwRWdTVVFnYVc0Z1oyeHZZbUZzSUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG1GellTQTlJR0Z6YzJWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaGMyRWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPak0wTFRNNENpQWdJQ0F2THlBaklGTjFZbTFwZENCdmNIUXRhVzRnZEhKaGJuTmhZM1JwYjI0NklEQWdZWE56WlhRZ2RISmhibk5tWlhJZ2RHOGdjMlZzWmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPak0wTFRNMUNpQWdJQ0F2THlBaklGTjFZbTFwZENCdmNIUXRhVzRnZEhKaGJuTmhZM1JwYjI0NklEQWdZWE56WlhRZ2RISmhibk5tWlhJZ2RHOGdjMlZzWmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpRdE16Z0tJQ0FnSUM4dklDTWdVM1ZpYldsMElHOXdkQzFwYmlCMGNtRnVjMkZqZEdsdmJqb2dNQ0JoYzNObGRDQjBjbUZ1YzJabGNpQjBieUJ6Wld4bUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG1GMVkzUnBiMjR1WTI5dWRISmhZM1F1UVhWamRHbHZiaTV6ZEdGeWRGOWhkV04wYVc5dUtITjBZWEowYVc1blgzQnlhV05sT2lCMWFXNTBOalFzSUd4bGJtZDBhRG9nZFdsdWREWTBMQ0JoZUdabGNqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncHpkR0Z5ZEY5aGRXTjBhVzl1T2dvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvME1DMDBOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdjM1JoY25SZllYVmpkR2x2YmlnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lITjBZWEowYVc1blgzQnlhV05sT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2JHVnVaM1JvT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lYaG1aWEk2SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSeVlXNXpZV04wYVc5dUxBb2dJQ0FnTHk4Z0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNeUF3Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVlYVmpkR2x2YmlCdGRYTjBJR0psSUhOMFlYSjBaV1FnWW5rZ1kzSmxZWFJ2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGRXTjBhVzl1SUcxMWMzUWdZbVVnYzNSaGNuUmxaQ0JpZVNCamNtVmhkRzl5Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRNUxUVXdDaUFnSUNBdkx5QWpJRVZ1YzNWeVpTQjBhR1VnWVhWamRHbHZiaUJvWVhOdUozUWdZV3h5WldGa2VTQmlaV1Z1SUhOMFlYSjBaV1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1GMVkzUnBiMjVmWlc1a0lEMDlJREFzSUNKaGRXTjBhVzl1SUdGc2NtVmhaSGtnYzNSaGNuUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhkV04wYVc5dVgyVnVaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGRXTjBhVzl1WDJWdVpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhkV04wYVc5dUlHRnNjbVZoWkhrZ2MzUmhjblJsWkFvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYaG1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5USXROVFVLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJR0Y0Wm1WeUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lHRjRabVZ5TG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUNKaGVHWmxjaUJ0ZFhOMElIUnlZVzV6Wm1WeUlIUnZJSFJvYVhNZ1lYQndJZ29nSUNBZ1lYTnpaWEowSUM4dklHRjRabVZ5SUcxMWMzUWdkSEpoYm5ObVpYSWdkRzhnZEdocGN5QmhjSEFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRjdE5UZ0tJQ0FnSUM4dklDTWdVMlYwSUdkc2IySmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTVoYzJGZllXMXZkVzUwSUQwZ1lYaG1aWEl1WVhOelpYUmZZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjMkZmWVcxdmRXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUhObGJHWXVZWFZqZEdsdmJsOWxibVFnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUd4bGJtZDBhQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGRXTjBhVzl1WDJWdVpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJ6Wld4bUxuQnlaWFpwYjNWelgySnBaQ0E5SUhOMFlYSjBhVzVuWDNCeWFXTmxDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndjbVYyYVc5MWMxOWlhV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTVoZFdOMGFXOXVMbU52Ym5SeVlXTjBMa0YxWTNScGIyNHVZbWxrS0hCaGVUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGlhV1E2Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZMkxUWTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmlhV1FvYzJWc1ppd2djR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzJPQzAyT1FvZ0lDQWdMeThnSXlCRmJuTjFjbVVnWVhWamRHbHZiaUJvWVhOdUozUWdaVzVrWldRS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQThJSE5sYkdZdVlYVmpkR2x2Ymw5bGJtUXNJQ0poZFdOMGFXOXVJR2hoY3lCbGJtUmxaQ0lLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhkV04wYVc5dVgyVnVaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGRXTjBhVzl1WDJWdVpDQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhkV04wYVc5dUlHaGhjeUJsYm1SbFpBb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNNUzAzTWdvZ0lDQWdMeThnSXlCV1pYSnBabmtnY0dGNWJXVnVkQ0IwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dkSEpoYm5OaFkzUnBiMjRnYzJWdVpHVnlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lIUnlZVzV6WVdOMGFXOXVJSE5sYm1SbGNnb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlUzVoYlc5MWJuUWdQaUJ6Wld4bUxuQnlaWFpwYjNWelgySnBaQ3dnSWtKcFpDQnRkWE4wSUdKbElHaHBaMmhsY2lCMGFHRnVJSEJ5WlhacGIzVnpJR0pwWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljSEpsZG1sdmRYTmZZbWxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnlaWFpwYjNWelgySnBaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnUW1sa0lHMTFjM1FnWW1VZ2FHbG5hR1Z5SUhSb1lXNGdjSEpsZG1sdmRYTWdZbWxrQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjMUxUYzJDaUFnSUNBdkx5QWpJSE5sZENCbmJHOWlZV3dnYzNSaGRHVUtJQ0FnSUM4dklITmxiR1l1Y0hKbGRtbHZkWE5mWW1sa0lEMGdjR0Y1TG1GdGIzVnVkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljSEpsZG1sdmRYTmZZbWxrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QnpaV3htTG5CeVpYWnBiM1Z6WDJKcFpHUmxjaUE5SUhCaGVTNXpaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeVpYWnBiM1Z6WDJKcFpHUmxjaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOemt0T0RBS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUdOc1lXbHRZV0pzWlNCaGJXOTFiblFLSUNBZ0lDOHZJSE5sYkdZdVkyeGhhVzFoWW14bFgyRnRiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhTQTlJSEJoZVM1aGJXOTFiblFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnNZV2x0SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NWhkV04wYVc5dUxtTnZiblJ5WVdOMExrRjFZM1JwYjI0dVkyeGhhVzFmWW1sa2N5Z3BJQzArSUhadmFXUTZDbU5zWVdsdFgySnBaSE02Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneUxUZ3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmpiR0ZwYlY5aWFXUnpLSE5sYkdZcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXdJREFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGdGIzVnVkQ0E5SUc5eWFXZHBibUZzWDJGdGIzVnVkQ0E5SUhObGJHWXVZMnhoYVcxaFlteGxYMkZ0YjNWdWRGdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Oc1lXbHRJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnNZV2x0WVdKc1pWOWhiVzkxYm5RZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZzJMVGczQ2lBZ0lDQXZMeUFqSUhOMVluUnlZV04wSUhCeVpYWnBiM1Z6SUdKcFpDQnBaaUJ6Wlc1a1pYSWdhWE1nY0hKbGRtbHZkWE1nWW1sa1pHVnlDaUFnSUNBdkx5QnBaaUJVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1Y0hKbGRtbHZkWE5mWW1sa1pHVnlPZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeVpYWnBiM1Z6WDJKcFpHUmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtVjJhVzkxYzE5aWFXUmtaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyeGhhVzFmWW1sa2MxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EZ0tJQ0FnSUM4dklHRnRiM1Z1ZENBdFBTQnpaV3htTG5CeVpYWnBiM1Z6WDJKcFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CeVpYWnBiM1Z6WDJKcFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y21WMmFXOTFjMTlpYVdRZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENncGpiR0ZwYlY5aWFXUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZPVEF0T1RNS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TUMwNU13b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCelpXeG1MbU5zWVdsdFlXSnNaVjloYlc5MWJuUmJWSGh1TG5ObGJtUmxjbDBnUFNCdmNtbG5hVzVoYkY5aGJXOTFiblFnTFNCaGJXOTFiblFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnNZV2x0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWlhoaGJYQnNaWE11WVhWamRHbHZiaTVqYjI1MGNtRmpkQzVCZFdOMGFXOXVMbU5zWVdsdFgyRnpjMlYwS0dGemMyVjBPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbU5zWVdsdFgyRnpjMlYwT2dvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU55MDVPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdZMnhoYVcxZllYTnpaWFFvYzJWc1ppd2dZWE56WlhRNklFRnpjMlYwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BpQnpaV3htTG1GMVkzUnBiMjVmWlc1a0xDQWlZWFZqZEdsdmJpQm9ZWE1nYm05MElHVnVaR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUYxWTNScGIyNWZaVzVrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRjFZM1JwYjI1ZlpXNWtJR1Y0YVhOMGN3b2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR0YxWTNScGIyNGdhR0Z6SUc1dmRDQmxibVJsWkFvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1EQXRNVEEyQ2lBZ0lDQXZMeUFqSUZObGJtUWdRVk5CSUhSdklIQnlaWFpwYjNWeklHSnBaR1JsY2dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZlkyeHZjMlZmZEc4OWMyVnNaaTV3Y21WMmFXOTFjMTlpYVdSa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljMlZzWmk1d2NtVjJhVzkxYzE5aWFXUmtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWE5sYkdZdVlYTmhYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QmhjM05sZEY5amJHOXpaVjkwYnoxelpXeG1MbkJ5WlhacGIzVnpYMkpwWkdSbGNpd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKd2NtVjJhVzkxYzE5aWFXUmtaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNISmxkbWx2ZFhOZlltbGtaR1Z5SUdWNGFYTjBjd29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdWNISmxkbWx2ZFhOZlltbGtaR1Z5TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5WlhacGIzVnpYMkpwWkdSbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y21WMmFXOTFjMTlpYVdSa1pYSWdaWGhwYzNSekNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFhObGJHWXVZWE5oWDJGdGIzVnVkQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjMkZmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GellWOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkRiRzl6WlZSdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd01DMHhNREVLSUNBZ0lDOHZJQ01nVTJWdVpDQkJVMEVnZEc4Z2NISmxkbWx2ZFhNZ1ltbGtaR1Z5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURBdE1UQTJDaUFnSUNBdkx5QWpJRk5sYm1RZ1FWTkJJSFJ2SUhCeVpYWnBiM1Z6SUdKcFpHUmxjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWTJ4dmMyVmZkRzg5YzJWc1ppNXdjbVYyYVc5MWMxOWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMyVnNaaTV3Y21WMmFXOTFjMTlpYVdSa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYTmxiR1l1WVhOaFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCbGVHRnRjR3hsY3k1aGRXTjBhVzl1TG1OdmJuUnlZV04wTGtGMVkzUnBiMjR1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVFSmdZTFlYVmpkR2x2Ymw5bGJtUU1jSEpsZG1sdmRYTmZZbWxrRDNCeVpYWnBiM1Z6WDJKcFpHUmxjZ3BoYzJGZllXMXZkVzUwQTJGellRVmpiR0ZwYlRFWVFBQVJLQ0puS1NKbkt5Sm5Kd1FpWnlveUEyY3hHMEVBb0lJR0JDZ21zZ0lFOEtwd0l3UXd4dFdLQk50LzZFTUU1bFJpV3dRZXdTdnZOaG9BamdZQVhRQS9BRFlBSUFBVUFBSWlRekVaRkVReEdFUTJHZ0VYd0RDSUFTZ2pRekVaRkVReEdFU0lBTjBqUXpFWkZFUXhHRVF4RmlNSlNUZ1FJeEpFaUFDWEkwTXhHUlJFTVJoRUkwTXhHUlJFTVJoRU5ob0JGellhQWhjeEZpTUpTVGdRSkJKRWlBQkZJME14R1JSRU1SaEVOaG9CRjhBd2lBQU5JME14R1VEL2pERVlGRVFqUTRvQkFERUFNZ2tTUkNJbkJHVkVGRVFuQkl2L1o3RXlDb3Yvc2hHeUZDU3lFQ0t5QWJPSmlnTUFNUUF5Q1JKRUlpaGxSQlJFaS84NEZESUtFa1NML3pnU0sweG5NZ2VML2dnb1RHY3BpLzFuaVlvQkFESUhJaWhsUkF4RWkvODRBRWt4QUJKRWkvODRDQ0lwWlVSTEFReEVLVXNCWnlwUEFtY3hBQ2NGVHdKbWlZb0FBREVBSWljRlkweEpUd0pFTVFBaUttVkVFa0VBQ2lJcFpVU0xBRXdKakFHeE1RQ3lCNHNCU2JJSUk3SVFJcklCc3pFQWl3QlBBZ2tuQlV4bWlZb0JBRElISWlobFJBMUVzU0lxWlVRaUttVkVJaXRsUkxJU3NoU3lGWXYvc2hFa3NoQWlzZ0d6aVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
