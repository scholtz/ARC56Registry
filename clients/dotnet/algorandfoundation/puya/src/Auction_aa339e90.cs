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

namespace Arc56.Generated.algorandfoundation.puya.Auction_aa339e90
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
            byte[] abiHandle = { 216, 246, 45, 154 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIntoAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 246, 45, 154 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 89, 178, 171, 38 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 178, 171, 38 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXVjdGlvbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRfaW50b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFydF9hdWN0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0aW5nX3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1fYmlkcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4Nl0sImVycm9yTWVzc2FnZSI6IkFTQSBhbHJlYWR5IG9wdGVkIGluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3XSwiZXJyb3JNZXNzYWdlIjoiQmlkIG11c3QgYmUgaGlnaGVyIHRoYW4gcHJldmlvdXMgYmlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBvcHQgaW4gdG8gQVNBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3XSwiZXJyb3JNZXNzYWdlIjoiYXVjdGlvbiBhbHJlYWR5IHN0YXJ0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJhdWN0aW9uIGhhcyBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NV0sImVycm9yTWVzc2FnZSI6ImF1Y3Rpb24gaGFzIG5vdCBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MV0sImVycm9yTWVzc2FnZSI6ImF1Y3Rpb24gbXVzdCBiZSBzdGFydGVkIGJ5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTRdLCJlcnJvck1lc3NhZ2UiOiJheGZlciBtdXN0IHRyYW5zZmVyIHRvIHRoaXMgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc2FfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NSwyODYsMzkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdWN0aW9uX2VuZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNsYWltYWJsZV9hbW91bnQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzLDM3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJldmlvdXNfYmlkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNyw0MDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByZXZpb3VzX2JpZGRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzIsMjE1LDIyNCwzODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTZdLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIHRyYW5zYWN0aW9uIHNlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBMENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaGRXTjBhVzl1WDJWdVpDSWdJbkJ5WlhacGIzVnpYMkpwWkNJZ0luQnlaWFpwYjNWelgySnBaR1JsY2lJZ0ltRnpZVjloYlc5MWJuUWlJQ0poYzJFaUlDSmpiR0ZwYlNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRnS0lDQWdJQzh2SUhObGJHWXVZWFZqZEdsdmJsOWxibVFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GMVkzUnBiMjVmWlc1a0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTVDaUFnSUNBdkx5QnpaV3htTG5CeVpYWnBiM1Z6WDJKcFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljSEpsZG1sdmRYTmZZbWxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCelpXeG1MbUZ6WVY5aGJXOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1GellWOWhiVzkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklITmxiR1l1WVhOaElEMGdRWE56WlhRb0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlYTmhJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJ6Wld4bUxuQnlaWFpwYjNWelgySnBaR1JsY2lBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNISmxkbWx2ZFhOZlltbGtaR1Z5SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRXTjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkRobU5qSmtPV0VnTUhobU1HRmhOekF5TXlBd2VETXdZelprTlRoaElEQjRaR0kzWm1VNE5ETWdNSGhsTmpVME5qSTFZaUF3ZURVNVlqSmhZakkySUM4dklHMWxkR2h2WkNBaWIzQjBYMmx1ZEc5ZllYTnpaWFFvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjBZWEowWDJGMVkzUnBiMjRvZFdsdWREWTBMSFZwYm5RMk5DeGhlR1psY2lsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0hSZmFXNG9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltSnBaQ2h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJ4aGFXMWZZbWxrY3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJ4aGFXMWZZWE56WlhRb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J2Y0hSZmFXNTBiMTloYzNObGRDQnpkR0Z5ZEY5aGRXTjBhVzl1SUcxaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURnZ1ltbGtJR05zWVdsdFgySnBaSE1nWTJ4aGFXMWZZWE56WlhRS0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11WVhWamRHbHZiaTVqYjI1MGNtRmpkQzVCZFdOMGFXOXVMbTl3ZEY5cGJuUnZYMkZ6YzJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwWDJsdWRHOWZZWE56WlhRNkNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNamN0TWpnS0lDQWdJQzh2SUNNZ1QyNXNlU0JoYkd4dmR5QmhjSEFnWTNKbFlYUnZjaUIwYnlCdmNIUWdkR2hsSUdGd2NDQmhZMk52ZFc1MElHbHVkRzhnWVNCQlUwRUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHOXdkQ0JwYmlCMGJ5QkJVMEVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ2Y0hRZ2FXNGdkRzhnUVZOQkNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTVMVE13Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0JoSUVGVFFTQm9ZWE51SjNRZ1lXeHlaV0ZrZVNCaVpXVnVJRzl3ZEdWa0lHbHVkRzhLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1GellTNXBaQ0E5UFNBd0xDQWlRVk5CSUdGc2NtVmhaSGtnYjNCMFpXUWdhVzRpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZWE5oSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpZU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCVTBFZ1lXeHlaV0ZrZVNCdmNIUmxaQ0JwYmdvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek1TMHpNZ29nSUNBZ0x5OGdJeUJUWVhabElFRlRRU0JKUkNCcGJpQm5iRzlpWVd3Z2MzUmhkR1VLSUNBZ0lDOHZJSE5sYkdZdVlYTmhJRDBnWVhOelpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRnpZU0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek5DMHpPQW9nSUNBZ0x5OGdJeUJUZFdKdGFYUWdiM0IwTFdsdUlIUnlZVzV6WVdOMGFXOXVPaUF3SUdGemMyVjBJSFJ5WVc1elptVnlJSFJ2SUhObGJHWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16UXRNelVLSUNBZ0lDOHZJQ01nVTNWaWJXbDBJRzl3ZEMxcGJpQjBjbUZ1YzJGamRHbHZiam9nTUNCaGMzTmxkQ0IwY21GdWMyWmxjaUIwYnlCelpXeG1DaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3pOQzB6T0FvZ0lDQWdMeThnSXlCVGRXSnRhWFFnYjNCMExXbHVJSFJ5WVc1ellXTjBhVzl1T2lBd0lHRnpjMlYwSUhSeVlXNXpabVZ5SUhSdklITmxiR1lLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1pYaGhiWEJzWlhNdVlYVmpkR2x2Ymk1amIyNTBjbUZqZEM1QmRXTjBhVzl1TG5OMFlYSjBYMkYxWTNScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEdGeWRGOWhkV04wYVc5dU9nb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVlYVmpkR2x2YmlCdGRYTjBJR0psSUhOMFlYSjBaV1FnWW5rZ1kzSmxZWFJ2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGRXTjBhVzl1SUcxMWMzUWdZbVVnYzNSaGNuUmxaQ0JpZVNCamNtVmhkRzl5Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRNUxUVXdDaUFnSUNBdkx5QWpJRVZ1YzNWeVpTQjBhR1VnWVhWamRHbHZiaUJvWVhOdUozUWdZV3h5WldGa2VTQmlaV1Z1SUhOMFlYSjBaV1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1GMVkzUnBiMjVmWlc1a0lEMDlJREFzSUNKaGRXTjBhVzl1SUdGc2NtVmhaSGtnYzNSaGNuUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhkV04wYVc5dVgyVnVaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGRXTjBhVzl1WDJWdVpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhkV04wYVc5dUlHRnNjbVZoWkhrZ2MzUmhjblJsWkFvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYaG1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5USXROVFVLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJR0Y0Wm1WeUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lHRjRabVZ5TG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUNKaGVHWmxjaUJ0ZFhOMElIUnlZVzV6Wm1WeUlIUnZJSFJvYVhNZ1lYQndJZ29nSUNBZ1lYTnpaWEowSUM4dklHRjRabVZ5SUcxMWMzUWdkSEpoYm5ObVpYSWdkRzhnZEdocGN5QmhjSEFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRjdE5UZ0tJQ0FnSUM4dklDTWdVMlYwSUdkc2IySmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTVoYzJGZllXMXZkVzUwSUQwZ1lYaG1aWEl1WVhOelpYUmZZVzF2ZFc1MENpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWE5oWDJGdGIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCelpXeG1MbUYxWTNScGIyNWZaVzVrSUQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnS3lCc1pXNW5kR2dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRjFZM1JwYjI1ZlpXNWtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUhObGJHWXVjSEpsZG1sdmRYTmZZbWxrSUQwZ2MzUmhjblJwYm1kZmNISnBZMlVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkJ5WlhacGIzVnpYMkpwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJsZUdGdGNHeGxjeTVoZFdOMGFXOXVMbU52Ym5SeVlXTjBMa0YxWTNScGIyNHVZbWxrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltbGtPZ29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5qZ3ROamtLSUNBZ0lDOHZJQ01nUlc1emRYSmxJR0YxWTNScGIyNGdhR0Z6YmlkMElHVnVaR1ZrQ2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BDQnpaV3htTG1GMVkzUnBiMjVmWlc1a0xDQWlZWFZqZEdsdmJpQm9ZWE1nWlc1a1pXUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYVmpkR2x2Ymw5bGJtUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhWamRHbHZibDlsYm1RZ1pYaHBjM1J6Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1lYVmpkR2x2YmlCb1lYTWdaVzVrWldRS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56RXROeklLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJSEJoZVcxbGJuUWdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGt1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSndZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lIUnlZVzV6WVdOMGFXOXVJSE5sYm1SbGNpSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViV1Z1ZENCelpXNWtaWElnYlhWemRDQnRZWFJqYUNCMGNtRnVjMkZqZEdsdmJpQnpaVzVrWlhJS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYa3VZVzF2ZFc1MElENGdjMlZzWmk1d2NtVjJhVzkxYzE5aWFXUXNJQ0pDYVdRZ2JYVnpkQ0JpWlNCb2FXZG9aWElnZEdoaGJpQndjbVYyYVc5MWN5QmlhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndjbVYyYVc5MWMxOWlhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNISmxkbWx2ZFhOZlltbGtJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJDYVdRZ2JYVnpkQ0JpWlNCb2FXZG9aWElnZEdoaGJpQndjbVYyYVc5MWN5QmlhV1FLSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TnpVdE56WUtJQ0FnSUM4dklDTWdjMlYwSUdkc2IySmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyVnNaaTV3Y21WMmFXOTFjMTlpYVdRZ1BTQndZWGt1WVcxdmRXNTBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndjbVYyYVc5MWMxOWlhV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklITmxiR1l1Y0hKbGRtbHZkWE5mWW1sa1pHVnlJRDBnY0dGNUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0hKbGRtbHZkWE5mWW1sa1pHVnlJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNPUzA0TUFvZ0lDQWdMeThnSXlCVmNHUmhkR1VnWTJ4aGFXMWhZbXhsSUdGdGIzVnVkQW9nSUNBZ0x5OGdjMlZzWmk1amJHRnBiV0ZpYkdWZllXMXZkVzUwVzFSNGJpNXpaVzVrWlhKZElEMGdjR0Y1TG1GdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVkyeGhhVzBpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWNFlXMXdiR1Z6TG1GMVkzUnBiMjR1WTI5dWRISmhZM1F1UVhWamRHbHZiaTVqYkdGcGJWOWlhV1J6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyeGhhVzFmWW1sa2N6b0tJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJR0Z0YjNWdWRDQTlJRzl5YVdkcGJtRnNYMkZ0YjNWdWRDQTlJSE5sYkdZdVkyeGhhVzFoWW14bFgyRnRiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU5zWVdsdElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMnhoYVcxaFlteGxYMkZ0YjNWdWRDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklHRjFZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZPRFl0T0RjS0lDQWdJQzh2SUNNZ2MzVmlkSEpoWTNRZ2NISmxkbWx2ZFhNZ1ltbGtJR2xtSUhObGJtUmxjaUJwY3lCd2NtVjJhVzkxY3lCaWFXUmtaWElLSUNBZ0lDOHZJR2xtSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1d2NtVjJhVzkxYzE5aWFXUmtaWEk2Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNISmxkbWx2ZFhOZlltbGtaR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnlaWFpwYjNWelgySnBaR1JsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dZMnhoYVcxZlltbGtjMTlwWmw5aWIyUjVRRElLSUNBZ0lHUjFjQW9LWTJ4aGFXMWZZbWxrYzE5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prd0xUa3pDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWVhWamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVNQzA1TXdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJ6Wld4bUxtTnNZV2x0WVdKc1pWOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMGdQU0J2Y21sbmFXNWhiRjloYlc5MWJuUWdMU0JoYlc5MWJuUUtJQ0FnSUMwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU5zWVdsdElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Oc1lXbHRYMkpwWkhOZmFXWmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z1lYVmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdZVzF2ZFc1MElDMDlJSE5sYkdZdWNISmxkbWx2ZFhOZlltbGtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNISmxkbWx2ZFhOZlltbGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeVpYWnBiM1Z6WDJKcFpDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmlJR05zWVdsdFgySnBaSE5mWVdaMFpYSmZhV1pmWld4elpVQXpDZ29LTHk4Z1pYaGhiWEJzWlhNdVlYVmpkR2x2Ymk1amIyNTBjbUZqZEM1QmRXTjBhVzl1TG1Oc1lXbHRYMkZ6YzJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhoYVcxZllYTnpaWFE2Q2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdGMVkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErSUhObGJHWXVZWFZqZEdsdmJsOWxibVFzSUNKaGRXTjBhVzl1SUdoaGN5QnViM1FnWlc1a1pXUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYVmpkR2x2Ymw5bGJtUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhWamRHbHZibDlsYm1RZ1pYaHBjM1J6Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1lYVmpkR2x2YmlCb1lYTWdibTkwSUdWdVpHVmtDaUFnSUNBdkx5QmhkV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TUMweE1EWUtJQ0FnSUM4dklDTWdVMlZ1WkNCQlUwRWdkRzhnY0hKbGRtbHZkWE1nWW1sa1pHVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjlqYkc5elpWOTBiejF6Wld4bUxuQnlaWFpwYjNWelgySnBaR1JsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MbkJ5WlhacGIzVnpYMkpwWkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWMyVnNaaTVoYzJGZllXMXZkVzUwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUdGemMyVjBYMk5zYjNObFgzUnZQWE5sYkdZdWNISmxkbWx2ZFhOZlltbGtaR1Z5TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5WlhacGIzVnpYMkpwWkdSbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y21WMmFXOTFjMTlpYVdSa1pYSWdaWGhwYzNSekNpQWdJQ0F2THlCaGRXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFhObGJHWXVZWE5oWDJGdGIzVnVkQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjMkZmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GellWOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFTnNiM05sVkc4S0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd01DMHhNREVLSUNBZ0lDOHZJQ01nVTJWdVpDQkJVMEVnZEc4Z2NISmxkbWx2ZFhNZ1ltbGtaR1Z5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZWFZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURBdE1UQTJDaUFnSUNBdkx5QWpJRk5sYm1RZ1FWTkJJSFJ2SUhCeVpYWnBiM1Z6SUdKcFpHUmxjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWTJ4dmMyVmZkRzg5YzJWc1ppNXdjbVYyYVc5MWMxOWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMyVnNaaTV3Y21WMmFXOTFjMTlpYVdSa1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYTmxiR1l1WVhOaFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJoZFdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJsZUdGdGNHeGxjeTVoZFdOMGFXOXVMbU52Ym5SeVlXTjBMa0YxWTNScGIyNHVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lDOHZJR0YxWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRFMkNpQWdJQ0F2THlCeVpYUjFjbTRnVkhKMVpRb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJQkNZR0MyRjFZM1JwYjI1ZlpXNWtESEJ5WlhacGIzVnpYMkpwWkE5d2NtVjJhVzkxYzE5aWFXUmtaWElLWVhOaFgyRnRiM1Z1ZEFOaGMyRUZZMnhoYVcweEdFQUFFU2dpWnlraVp5c2laeWNFSW1jcU1nTm5NUnRCQURzeEdSUkVNUmhFZ2dZRTJQWXRtZ1R3cW5BakJEREcxWW9FMjMvb1F3VG1WR0piQkZteXF5WTJHZ0NPQmdBTEFEWUFBUUIxQUtzQTRRQWpRekVaRkRFWUZCQkROaG9CU1JVa0VrUVhNUUF5Q1JKRUlpY0VaVVFVUkNjRVN3Rm5zVElLc2hTeUVTV3lFQ0t5QWJNalF6WWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUZ6RVdJd2xKT0JBbEVrUXhBRElKRWtRaUtHVkVGRVJKT0JReUNoSkVPQklyVEdjeUJ3Z29UR2NwVEdjalF6RVdJd2xKT0JBakVrUXlCeUlvWlVRTVJFazRBRWt4QUJKRVREZ0lJaWxsUkVzQkRFUXBTd0ZuS2s4Q1p6RUFKd1ZQQW1ZalF6RUFJaWNGWTBReEFDSXFaVVFTUUFBYVNiRXhBTElIU2JJSUk3SVFJcklCc3dreEFDY0ZUd0ptSTBNaUtXVkVTd0ZNQ1VMLzNEWWFBVWtWSkJKRUZ6SUhJaWhsUkExRXNTSXFaVVFpSzJWRXNoSkpzaFN5RmJJUkpiSVFJcklCc3lORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
