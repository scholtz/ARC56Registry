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

namespace Arc56.Generated.LoafPickleWW.wen_tools.AgentChild_241df9a6
{


    public class AgentChildProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentChildProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="endpoint_url"> </param>
        /// <param name="price_algo"> </param>
        /// <param name="category"> </param>
        /// <param name="wallet_address"> </param>
        /// <param name="info_url"> </param>
        public async Task CreateApplication(string name, string description, string endpoint_url, ulong price_algo, string category, Algorand.Address wallet_address, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 149, 223, 83 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var wallet_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); wallet_addressAbi.From(wallet_address);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, wallet_addressAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(string name, string description, string endpoint_url, ulong price_algo, string category, Algorand.Address wallet_address, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 149, 223, 83 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var wallet_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); wallet_addressAbi.From(wallet_address);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, wallet_addressAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="endpoint_url"> </param>
        /// <param name="price_algo"> </param>
        /// <param name="category"> </param>
        /// <param name="info_url"> </param>
        public async Task UpdateListing(string name, string description, string endpoint_url, ulong price_algo, string category, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 199, 77, 125 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateListing_Transactions(string name, string description, string endpoint_url, ulong price_algo, string category, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 199, 77, 125 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeactivateListing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 25, 240, 151 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeactivateListing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 25, 240, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ActivateListing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 21, 234, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ActivateListing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 21, 234, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBZ2VudENoaWxkIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnRfdXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZV9hbGdvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXRlZ29yeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmZvX3VybCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidXBkYXRlX2xpc3RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuZHBvaW50X3VybCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VfYWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2F0ZWdvcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZm9fdXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJkZWFjdGl2YXRlX2xpc3RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImFjdGl2YXRlX2xpc3RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlbGV0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjo2fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURFd01DQXpNQ0ExTUNBeU1EQUtZbmwwWldOaWJHOWpheUF3ZURZeE5qTTNORFk1TnpZMk5TQXdlRFkxTm1VMk5EY3dObVkyT1RabE56UTFaamMxTnpJMll5QXdlRFkwTmpVM016WXpOekkyT1Rjd056UTJPVFptTm1VZ01IZzNNRGN5TmprMk16WTFOV1kyTVRaak5qYzJaaUF3ZURZek5qRTNORFkxTmpjMlpqY3lOemtnTUhnMk9UWmxOalkyWmpWbU56VTNNalpqSURCNE5tVTJNVFprTmpVS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqWVd4c1gwUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExITjBjbWx1Wnl4aFpHUnlaWE56TEhOMGNtbHVaeWwyYjJsa0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2t2THlCcGJtWnZYM1Z5YkRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJSGRoYkd4bGRGOWhaR1J5WlhOek9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2dsa2RYQUtDV3hsYmdvSmNIVnphR2x1ZENBek1nb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXhJQ2gzWVd4c1pYUmZZV1JrY21WemN5a2dabTl5SUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1SUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QmpZWFJsWjI5eWVUb2djM1J5YVc1bkNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2dsbGVIUnlZV04wSURJZ01Bb0tDUzh2SUhCeWFXTmxYMkZzWjI4NklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9KWW5SdmFRb0tDUzh2SUdWdVpIQnZhVzUwWDNWeWJEb2djM1J5YVc1bkNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2dsbGVIUnlZV04wSURJZ01Bb0tDUzh2SUdSbGMyTnlhWEIwYVc5dU9pQnpkSEpwYm1jS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ1dWNGRISmhZM1FnTWlBd0Nnb0pMeThnYm1GdFpUb2djM1J5YVc1bkNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsbGVIUnlZV04wSURJZ01Bb0tDUzh2SUdWNFpXTjFkR1VnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEhOMGNtbHVaeXhoWkdSeVpYTnpMSE4wY21sdVp5bDJiMmxrQ2dsallXeHNjM1ZpSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWh1WVcxbE9pQnpkSEpwYm1jc0lHUmxjMk55YVhCMGFXOXVPaUJ6ZEhKcGJtY3NJR1Z1WkhCdmFXNTBYM1Z5YkRvZ2MzUnlhVzVuTENCd2NtbGpaVjloYkdkdk9pQjFhVzUwTmpRc0lHTmhkR1ZuYjNKNU9pQnpkSEpwYm1jc0lIZGhiR3hsZEY5aFpHUnlaWE56T2lCQlpHUnlaWE56TENCcGJtWnZYM1Z5YkRvZ2MzUnlhVzVuS1RvZ2RtOXBaQXBqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1hCeWIzUnZJRGNnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qSXlDZ2t2THlCaGMzTmxjblFvYm1GdFpTNXNaVzVuZEdnZ1BEMGdOVEFwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYm1GdFpUb2djM1J5YVc1bkNnbHNaVzRLQ1dsdWRHTWdNeUF2THlBMU1Bb0pQRDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJaMlZ1ZEVOdmJuUnlZV04wY3k1aGJHZHZMblJ6T2pJekNna3ZMeUJoYzNObGNuUW9aR1Z6WTNKcGNIUnBiMjR1YkdWdVozUm9JRHc5SURJd01Da0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QmtaWE5qY21sd2RHbHZiam9nYzNSeWFXNW5DZ2xzWlc0S0NXbHVkR01nTkNBdkx5QXlNREFLQ1R3OUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6b3lOQW9KTHk4Z1lYTnpaWEowS0dWdVpIQnZhVzUwWDNWeWJDNXNaVzVuZEdnZ1BEMGdNVEF3S1FvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUdWdVpIQnZhVzUwWDNWeWJEb2djM1J5YVc1bkNnbHNaVzRLQ1dsdWRHTWdNU0F2THlBeE1EQUtDVHc5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pveU5Rb0pMeThnWVhOelpYSjBLR05oZEdWbmIzSjVMbXhsYm1kMGFDQThQU0F6TUNrS0NXWnlZVzFsWDJScFp5QXROU0F2THlCallYUmxaMjl5ZVRvZ2MzUnlhVzVuQ2dsc1pXNEtDV2x1ZEdNZ01pQXZMeUF6TUFvSlBEMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakkyQ2drdkx5QmhjM05sY25Rb2FXNW1iMTkxY213dWJHVnVaM1JvSUR3OUlERXdNQ2tLQ1daeVlXMWxYMlJwWnlBdE55QXZMeUJwYm1adlgzVnliRG9nYzNSeWFXNW5DZ2xzWlc0S0NXbHVkR01nTVNBdkx5QXhNREFLQ1R3OUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6b3lPQW9KTHk4Z2RHaHBjeTV1WVcxbExuWmhiSFZsSUQwZ2JtRnRaUW9KWW5sMFpXTWdOaUF2THlBZ0ltNWhiV1VpQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYm1GdFpUb2djM1J5YVc1bkNnbGtkWEFLQ1d4bGJnb0phWFJ2WWdvSlpYaDBjbUZqZENBMklESUtDWE4zWVhBS0NXTnZibU5oZEFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pveU9Rb0pMeThnZEdocGN5NWtaWE5qY21sd2RHbHZiaTUyWVd4MVpTQTlJR1JsYzJOeWFYQjBhVzl1Q2dsaWVYUmxZeUF5SUM4dklDQWlaR1Z6WTNKcGNIUnBiMjRpQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWkdWelkzSnBjSFJwYjI0NklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TXpBS0NTOHZJSFJvYVhNdVpXNWtjRzlwYm5SZmRYSnNMblpoYkhWbElEMGdaVzVrY0c5cGJuUmZkWEpzQ2dsaWVYUmxZeUF4SUM4dklDQWlaVzVrY0c5cGJuUmZkWEpzSWdvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUdWdVpIQnZhVzUwWDNWeWJEb2djM1J5YVc1bkNnbGtkWEFLQ1d4bGJnb0phWFJ2WWdvSlpYaDBjbUZqZENBMklESUtDWE4zWVhBS0NXTnZibU5oZEFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvek1Rb0pMeThnZEdocGN5NXdjbWxqWlY5aGJHZHZMblpoYkhWbElEMGdjSEpwWTJWZllXeG5id29KWW5sMFpXTWdNeUF2THlBZ0luQnlhV05sWDJGc1oyOGlDZ2xtY21GdFpWOWthV2NnTFRRZ0x5OGdjSEpwWTJWZllXeG5iem9nZFdsdWREWTBDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPak15Q2drdkx5QjBhR2x6TG1OaGRHVm5iM0o1TG5aaGJIVmxJRDBnWTJGMFpXZHZjbmtLQ1dKNWRHVmpJRFFnTHk4Z0lDSmpZWFJsWjI5eWVTSUtDV1p5WVcxbFgyUnBaeUF0TlNBdkx5QmpZWFJsWjI5eWVUb2djM1J5YVc1bkNnbGtkWEFLQ1d4bGJnb0phWFJ2WWdvSlpYaDBjbUZqZENBMklESUtDWE4zWVhBS0NXTnZibU5oZEFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvek13b0pMeThnZEdocGN5NTNZV3hzWlhSZllXUmtjbVZ6Y3k1MllXeDFaU0E5SUhkaGJHeGxkRjloWkdSeVpYTnpDZ2x3ZFhOb1lubDBaWE1nTUhnM056WXhObU0yWXpZMU56UTFaall4TmpRMk5EY3lOalUzTXpjeklDOHZJQ0ozWVd4c1pYUmZZV1JrY21WemN5SUtDV1p5WVcxbFgyUnBaeUF0TmlBdkx5QjNZV3hzWlhSZllXUmtjbVZ6Y3pvZ1FXUmtjbVZ6Y3dvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvek5Bb0pMeThnZEdocGN5NXBibVp2WDNWeWJDNTJZV3gxWlNBOUlHbHVabTlmZFhKc0NnbGllWFJsWXlBMUlDOHZJQ0FpYVc1bWIxOTFjbXdpQ2dsbWNtRnRaVjlrYVdjZ0xUY2dMeThnYVc1bWIxOTFjbXc2SUhOMGNtbHVad29KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV0Z3Y0Y5bmJHOWlZV3hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZNelVLQ1M4dklIUm9hWE11WVdOMGFYWmxMblpoYkhWbElEMGdNUW9KWW5sMFpXTWdNQ0F2THlBZ0ltRmpkR2wyWlNJS0NXbHVkR01nTUNBdkx5QXhDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0pjbVYwYzNWaUNnb3ZMeUIxY0dSaGRHVmZiR2x6ZEdsdVp5aHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNjM1J5YVc1bkxITjBjbWx1WnlsMmIybGtDaXBoWW1sZmNtOTFkR1ZmZFhCa1lYUmxYMnhwYzNScGJtYzZDZ2t2THlCcGJtWnZYM1Z5YkRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR05oZEdWbmIzSjVPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2NISnBZMlZmWVd4bmJ6b2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2dsaWRHOXBDZ29KTHk4Z1pXNWtjRzlwYm5SZmRYSnNPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvSlpYaDBjbUZqZENBeUlEQUtDZ2t2THlCdVlXMWxPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z1pYaGxZM1YwWlNCMWNHUmhkR1ZmYkdsemRHbHVaeWh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzYzNSeWFXNW5MSE4wY21sdVp5bDJiMmxrQ2dsallXeHNjM1ZpSUhWd1pHRjBaVjlzYVhOMGFXNW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QjFjR1JoZEdWZmJHbHpkR2x1WnlodVlXMWxPaUJ6ZEhKcGJtY3NJR1JsYzJOeWFYQjBhVzl1T2lCemRISnBibWNzSUdWdVpIQnZhVzUwWDNWeWJEb2djM1J5YVc1bkxDQndjbWxqWlY5aGJHZHZPaUIxYVc1ME5qUXNJR05oZEdWbmIzSjVPaUJ6ZEhKcGJtY3NJR2x1Wm05ZmRYSnNPaUJ6ZEhKcGJtY3BPaUIyYjJsa0NuVndaR0YwWlY5c2FYTjBhVzVuT2dvSmNISnZkRzhnTmlBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZORFlLQ1M4dklHRnpjMlZ5ZENoMGFHbHpMblI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVhCd0xtTnlaV0YwYjNJcENnbDBlRzRnVTJWdVpHVnlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVjeUF3Q2dsaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCRGNtVmhkRzl5Q2dsd2IzQUtDVDA5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvME53b0pMeThnWVhOelpYSjBLRzVoYldVdWJHVnVaM1JvSUR3OUlEVXdLUW9KWm5KaGJXVmZaR2xuSUMweElDOHZJRzVoYldVNklITjBjbWx1WndvSmJHVnVDZ2xwYm5SaklETWdMeThnTlRBS0NUdzlDZ2xoYzNObGNuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem8wT0FvSkx5OGdZWE56WlhKMEtHUmxjMk55YVhCMGFXOXVMbXhsYm1kMGFDQThQU0F5TURBcENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp3b0piR1Z1Q2dscGJuUmpJRFFnTHk4Z01qQXdDZ2s4UFFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk5Ea0tDUzh2SUdGemMyVnlkQ2hsYm1Sd2IybHVkRjkxY213dWJHVnVaM1JvSUR3OUlERXdNQ2tLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJsYm1Sd2IybHVkRjkxY213NklITjBjbWx1WndvSmJHVnVDZ2xwYm5SaklERWdMeThnTVRBd0NnazhQUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TlRBS0NTOHZJR0Z6YzJWeWRDaGpZWFJsWjI5eWVTNXNaVzVuZEdnZ1BEMGdNekFwQ2dsbWNtRnRaVjlrYVdjZ0xUVWdMeThnWTJGMFpXZHZjbms2SUhOMGNtbHVad29KYkdWdUNnbHBiblJqSURJZ0x5OGdNekFLQ1R3OUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6bzFNUW9KTHk4Z1lYTnpaWEowS0dsdVptOWZkWEpzTG14bGJtZDBhQ0E4UFNBeE1EQXBDZ2xtY21GdFpWOWthV2NnTFRZZ0x5OGdhVzVtYjE5MWNtdzZJSE4wY21sdVp3b0piR1Z1Q2dscGJuUmpJREVnTHk4Z01UQXdDZ2s4UFFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk5UTUtDUzh2SUhSb2FYTXVibUZ0WlM1MllXeDFaU0E5SUc1aGJXVUtDV0o1ZEdWaklEWWdMeThnSUNKdVlXMWxJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJRzVoYldVNklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TlRRS0NTOHZJSFJvYVhNdVpHVnpZM0pwY0hScGIyNHVkbUZzZFdVZ1BTQmtaWE5qY21sd2RHbHZiZ29KWW5sMFpXTWdNaUF2THlBZ0ltUmxjMk55YVhCMGFXOXVJZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR1JsYzJOeWFYQjBhVzl1T2lCemRISnBibWNLQ1dSMWNBb0piR1Z1Q2dscGRHOWlDZ2xsZUhSeVlXTjBJRFlnTWdvSmMzZGhjQW9KWTI5dVkyRjBDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPalUxQ2drdkx5QjBhR2x6TG1WdVpIQnZhVzUwWDNWeWJDNTJZV3gxWlNBOUlHVnVaSEJ2YVc1MFgzVnliQW9KWW5sMFpXTWdNU0F2THlBZ0ltVnVaSEJ2YVc1MFgzVnliQ0lLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJsYm1Sd2IybHVkRjkxY213NklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TlRZS0NTOHZJSFJvYVhNdWNISnBZMlZmWVd4bmJ5NTJZV3gxWlNBOUlIQnlhV05sWDJGc1oyOEtDV0o1ZEdWaklETWdMeThnSUNKd2NtbGpaVjloYkdkdklnb0pabkpoYldWZlpHbG5JQzAwSUM4dklIQnlhV05sWDJGc1oyODZJSFZwYm5RMk5Bb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6bzFOd29KTHk4Z2RHaHBjeTVqWVhSbFoyOXllUzUyWVd4MVpTQTlJR05oZEdWbmIzSjVDZ2xpZVhSbFl5QTBJQzh2SUNBaVkyRjBaV2R2Y25raUNnbG1jbUZ0WlY5a2FXY2dMVFVnTHk4Z1kyRjBaV2R2Y25rNklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TlRnS0NTOHZJSFJvYVhNdWFXNW1iMTkxY213dWRtRnNkV1VnUFNCcGJtWnZYM1Z5YkFvSllubDBaV01nTlNBdkx5QWdJbWx1Wm05ZmRYSnNJZ29KWm5KaGJXVmZaR2xuSUMwMklDOHZJR2x1Wm05ZmRYSnNPaUJ6ZEhKcGJtY0tDV1IxY0FvSmJHVnVDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KYzNkaGNBb0pZMjl1WTJGMENnbGhjSEJmWjJ4dlltRnNYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qVTVDZ2t2THlCMGFHbHpMbUZqZEdsMlpTNTJZV3gxWlNBOUlERUtDV0o1ZEdWaklEQWdMeThnSUNKaFkzUnBkbVVpQ2dscGJuUmpJREFnTHk4Z01Rb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0NYSmxkSE4xWWdvS0x5OGdaR1ZoWTNScGRtRjBaVjlzYVhOMGFXNW5LQ2wyYjJsa0NpcGhZbWxmY205MWRHVmZaR1ZoWTNScGRtRjBaVjlzYVhOMGFXNW5PZ29KTHk4Z1pYaGxZM1YwWlNCa1pXRmpkR2wyWVhSbFgyeHBjM1JwYm1jb0tYWnZhV1FLQ1dOaGJHeHpkV0lnWkdWaFkzUnBkbUYwWlY5c2FYTjBhVzVuQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJrWldGamRHbDJZWFJsWDJ4cGMzUnBibWNvS1RvZ2RtOXBaQXBrWldGamRHbDJZWFJsWDJ4cGMzUnBibWM2Q2dsd2NtOTBieUF3SURBS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6bzJNd29KTHk4Z1lYTnpaWEowS0hSb2FYTXVkSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoY0hBdVkzSmxZWFJ2Y2lrS0NYUjRiaUJUWlc1a1pYSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNXpJREFLQ1dGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VOeVpXRjBiM0lLQ1hCdmNBb0pQVDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJaMlZ1ZEVOdmJuUnlZV04wY3k1aGJHZHZMblJ6T2pZMENna3ZMeUIwYUdsekxtRmpkR2wyWlM1MllXeDFaU0E5SURBS0NXSjVkR1ZqSURBZ0x5OGdJQ0poWTNScGRtVWlDZ2x3ZFhOb2FXNTBJREFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ2x5WlhSemRXSUtDaTh2SUdGamRHbDJZWFJsWDJ4cGMzUnBibWNvS1hadmFXUUtLbUZpYVY5eWIzVjBaVjloWTNScGRtRjBaVjlzYVhOMGFXNW5PZ29KTHk4Z1pYaGxZM1YwWlNCaFkzUnBkbUYwWlY5c2FYTjBhVzVuS0NsMmIybGtDZ2xqWVd4c2MzVmlJR0ZqZEdsMllYUmxYMnhwYzNScGJtY0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHRmpkR2wyWVhSbFgyeHBjM1JwYm1jb0tUb2dkbTlwWkFwaFkzUnBkbUYwWlY5c2FYTjBhVzVuT2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZOamdLQ1M4dklHRnpjMlZ5ZENoMGFHbHpMblI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVhCd0xtTnlaV0YwYjNJcENnbDBlRzRnVTJWdVpHVnlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVjeUF3Q2dsaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCRGNtVmhkRzl5Q2dsd2IzQUtDVDA5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvMk9Rb0pMeThnZEdocGN5NWhZM1JwZG1VdWRtRnNkV1VnUFNBeENnbGllWFJsWXlBd0lDOHZJQ0FpWVdOMGFYWmxJZ29KYVc1MFl5QXdJQzh2SURFS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dseVpYUnpkV0lLQ2k4dklHUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlpHVnNaWFJsUVhCd2JHbGpZWFJwYjI0NkNna3ZMeUJsZUdWamRYUmxJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0NnbGpZV3hzYzNWaUlHUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCa1pXeGxkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrQ21SbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZOek1LQ1M4dklHRnpjMlZ5ZENoMGFHbHpMblI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVhCd0xtTnlaV0YwYjNJcENnbDBlRzRnVTJWdVpHVnlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVjeUF3Q2dsaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCRGNtVmhkRzl5Q2dsd2IzQUtDVDA5Q2dsaGMzTmxjblFLQ1hKbGRITjFZZ29LS21OeVpXRjBaVjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0TlRrNU5XUm1OVE1nTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2MzUnlhVzVuTEdGa1pISmxjM01zYzNSeWFXNW5LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhqTTJNM05HUTNaQ0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVjlzYVhOMGFXNW5LSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bktYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IaG1NREU1WmpBNU55QXZMeUJ0WlhSb2IyUWdJbVJsWVdOMGFYWmhkR1ZmYkdsemRHbHVaeWdwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZURSbU1UVmxZV1UxSUM4dklHMWxkR2h2WkNBaVlXTjBhWFpoZEdWZmJHbHpkR2x1WnlncGRtOXBaQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZkWEJrWVhSbFgyeHBjM1JwYm1jZ0ttRmlhVjl5YjNWMFpWOWtaV0ZqZEdsMllYUmxYMnhwYzNScGJtY2dLbUZpYVY5eWIzVjBaVjloWTNScGRtRjBaVjlzYVhOMGFXNW5DZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5RVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmpvS0NYQjFjMmhpZVhSbGN5QXdlREkwT0Rkak16SmpJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTmhiR3dnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
