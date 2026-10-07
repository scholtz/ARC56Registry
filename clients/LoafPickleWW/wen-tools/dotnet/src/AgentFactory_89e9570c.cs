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

namespace Arc56.Generated.LoafPickleWW.wen_tools.AgentFactory_89e9570c
{


    public class AgentFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="endpoint_url"> </param>
        /// <param name="price_algo"> </param>
        /// <param name="category"> </param>
        /// <param name="info_url"> </param>
        public async Task<ulong> CreateListing(PaymentTransaction mbrPayment, string name, string description, string endpoint_url, ulong price_algo, string category, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 141, 221, 116, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateListing_Transactions(PaymentTransaction mbrPayment, string name, string description, string endpoint_url, ulong price_algo, string category, string info_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 141, 221, 116, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpoint_urlAbi.From(endpoint_url);
            var price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_algoAbi.From(price_algo);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var info_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); info_urlAbi.From(info_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, nameAbi, descriptionAbi, endpoint_urlAbi, price_algoAbi, categoryAbi, info_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="nonce"> </param>
        public async Task<ulong> GetListingApp(Algorand.Address wallet, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 194, 186, 68 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetListingApp_Transactions(Algorand.Address wallet, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 194, 186, 68 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nonce"> </param>
        public async Task DeleteListing(ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 136, 233, 209 };
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteListing_Transactions(ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 136, 233, 209 };
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBZ2VudEZhY3RvcnkiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVfbGlzdGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnRfdXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZV9hbGdvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXRlZ29yeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5mb191cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0X2xpc3RpbmdfYXBwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlbGV0ZV9saXN0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJkZWxldGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InVwZGF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURBZ05pQTBOemhmTnpBd0NtSjVkR1ZqWW14dlkyc2dNSGdnTUhnM05EWm1OelEyTVRaak5XWTJZelk1TnpNM05EWTVObVUyTnpjeklEQjRObVUyTlRjNE56UTFaalpsTm1ZMlpUWXpOalVnTUhneE5URm1OMk0zTlNBd2VESTBPRGRqTXpKakNnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXBwYm5SaklESWdMeThnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVkyRnNiRjlWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaUFxWTJGc2JGOUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0pMeThnVkdobElISmxjWFZsYzNSbFpDQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvYVhNZ1kyOXVkSEpoWTNRdUlFRnlaU0I1YjNVZ2RYTnBibWNnZEdobElHTnZjbkpsWTNRZ1QyNURiMjF3YkdWMFpUOGdSR2xrSUhsdmRTQnpaWFFnZVc5MWNpQmhjSEFnU1VRL0NnbGxjbklLQ2k4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNna3ZMeUJsZUdWamRYUmxJR055WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0NnbGpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrQ21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZPRE1LQ1M4dklIUm9hWE11ZEc5MFlXeGZiR2x6ZEdsdVozTXVkbUZzZFdVZ1BTQXdDZ2xpZVhSbFl5QXhJQzh2SUNBaWRHOTBZV3hmYkdsemRHbHVaM01pQ2dscGJuUmpJREVnTHk4Z01Bb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6bzROQW9KTHk4Z2RHaHBjeTV1WlhoMFgyNXZibU5sTG5aaGJIVmxJRDBnTVFvSllubDBaV01nTWlBdkx5QWdJbTVsZUhSZmJtOXVZMlVpQ2dscGJuUmpJREFnTHk4Z01Rb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0NYSmxkSE4xWWdvS0x5OGdZM0psWVhSbFgyeHBjM1JwYm1jb2NHRjVMSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bktYVnBiblEyTkFvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlY5c2FYTjBhVzVuT2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsaWVYUmxZeUF6SUM4dklEQjRNVFV4Wmpkak56VUtDZ2t2THlCcGJtWnZYM1Z5YkRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR05oZEdWbmIzSjVPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2NISnBZMlZmWVd4bmJ6b2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2dsaWRHOXBDZ29KTHk4Z1pXNWtjRzlwYm5SZmRYSnNPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvSlpYaDBjbUZqZENBeUlEQUtDZ2t2THlCdVlXMWxPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2JXSnlVR0Y1YldWdWREb2djR0Y1Q2dsMGVHNGdSM0p2ZFhCSmJtUmxlQW9KYVc1MFl5QXdJQzh2SURFS0NTMEtDV1IxY0FvSlozUjRibk1nVkhsd1pVVnVkVzBLQ1dsdWRHTWdNQ0F2THlBZ2NHRjVDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJRFlnS0cxaWNsQmhlVzFsYm5RcElHWnZjaUJqY21WaGRHVmZiR2x6ZEdsdVp5QnRkWE4wSUdKbElHRWdjR0Y1SUhSeVlXNXpZV04wYVc5dUNnbGhjM05sY25RS0Nna3ZMeUJsZUdWamRYUmxJR055WldGMFpWOXNhWE4wYVc1bktIQmhlU3h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzYzNSeWFXNW5MSE4wY21sdVp5bDFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1kzSmxZWFJsWDJ4cGMzUnBibWNLQ1dsMGIySUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJqY21WaGRHVmZiR2x6ZEdsdVp5aHRZbkpRWVhsdFpXNTBPaUJRWVhsVWVHNHNJRzVoYldVNklITjBjbWx1Wnl3Z1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d2daVzVrY0c5cGJuUmZkWEpzT2lCemRISnBibWNzSUhCeWFXTmxYMkZzWjI4NklIVnBiblEyTkN3Z1kyRjBaV2R2Y25rNklITjBjbWx1Wnl3Z2FXNW1iMTkxY213NklITjBjbWx1WnlrNklIVnBiblEyTkFwamNtVmhkR1ZmYkdsemRHbHVaem9LQ1hCeWIzUnZJRGNnTVFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbGllWFJsWXlBd0lDOHZJREI0Q2dsa2RYQnVJRElLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pvNU5nb0pMeThnYm05dVkyVWdQU0IwYUdsekxtNWxlSFJmYm05dVkyVXVkbUZzZFdVS0NXSjVkR1ZqSURJZ0x5OGdJQ0p1WlhoMFgyNXZibU5sSWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJ1YjI1alpUb2dkV2x1ZERZMENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZPVGNLQ1M4dklHSnZlRXRsZVNBOUlHTnZibU5oZENoMGFHbHpMblI0Ymk1elpXNWtaWElzSUdsMGIySW9ibTl1WTJVcEtRb0pkSGh1SUZObGJtUmxjZ29KWm5KaGJXVmZaR2xuSURBZ0x5OGdibTl1WTJVNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xtY21GdFpWOWlkWEo1SURFZ0x5OGdZbTk0UzJWNU9pQmllWFJsVzEwS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6bzVPQW9KTHk4Z1lYTnpaWEowS0NGMGFHbHpMbXhwYzNScGJtZHpLR0p2ZUV0bGVTa3VaWGhwYzNSektRb0pabkpoYldWZlpHbG5JREVnTHk4Z1ltOTRTMlY1T2lCaWVYUmxXMTBLQ1dKdmVGOXNaVzRLQ1hOM1lYQUtDWEJ2Y0FvSklRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZNVEEwQ2drdkx5QjJaWEpwWm5sUVlYbFVlRzRvYldKeVVHRjViV1Z1ZEN3Z2V3b0pMeThnSUNBZ0lDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVlYQndMbUZrWkhKbGMzTXNDZ2t2THlBZ0lDQWdJQ0JoYlc5MWJuUTZJSHNnWjNKbFlYUmxjbFJvWVc1RmNYVmhiRlJ2T2lBME56aGZOekF3SUgwc0Nna3ZMeUFnSUNBZ2ZTa0tDUzh2SUhabGNtbG1lU0J5WldObGFYWmxjZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJRzFpY2xCaGVXMWxiblE2SUZCaGVWUjRiZ29KWjNSNGJuTWdVbVZqWldsMlpYSUtDV2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNnazlQUW9LQ1M4dklIUnlZVzV6WVdOMGFXOXVJSFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1E2SUhzaWRIaHVJam9pYldKeVVHRjViV1Z1ZENJc0ltWnBaV3hrSWpvaWNtVmpaV2wyWlhJaUxDSmxlSEJsWTNSbFpDSTZJblJvYVhNdVlYQndMbUZrWkhKbGMzTWlmUW9KWVhOelpYSjBDZ29KTHk4Z2RtVnlhV1o1SUdGdGIzVnVkQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJRzFpY2xCaGVXMWxiblE2SUZCaGVWUjRiZ29KWjNSNGJuTWdRVzF2ZFc1MENnbHBiblJqSURNZ0x5OGdORGM0WHpjd01Bb0pQajBLQ2drdkx5QjBjbUZ1YzJGamRHbHZiaUIyWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrT2lCN0luUjRiaUk2SW0xaWNsQmhlVzFsYm5RaUxDSm1hV1ZzWkNJNkltRnRiM1Z1ZENJc0ltTnZibVJwZEdsdmJpSTZJbWR5WldGMFpYSlVhR0Z1UlhGMVlXeFVieUlzSW1WNGNHVmpkR1ZrSWpvaVBqMDBOemhmTnpBd0luMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakV3T1FvSkx5OGdjMlZ1WkUxbGRHaHZaRU5oYkd3OGRIbHdaVzltSUVGblpXNTBRMmhwYkdRdWNISnZkRzkwZVhCbExtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVBpaDdDZ2t2THlBZ0lDQWdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJRUZuWlc1MFEyaHBiR1F1WVhCd2NtOTJZV3hRY205bmNtRnRLQ2tzQ2drdkx5QWdJQ0FnSUNCamJHVmhjbE4wWVhSbFVISnZaM0poYlRvZ1FXZGxiblJEYUdsc1pDNWpiR1ZoY2xCeWIyZHlZVzBvS1N3S0NTOHZJQ0FnSUNBZ0lHMWxkR2h2WkVGeVozTTZJRnR1WVcxbExDQmtaWE5qY21sd2RHbHZiaXdnWlc1a2NHOXBiblJmZFhKc0xDQndjbWxqWlY5aGJHZHZMQ0JqWVhSbFoyOXllU3dnZEdocGN5NTBlRzR1YzJWdVpHVnlMQ0JwYm1adlgzVnliRjBzQ2drdkx5QWdJQ0FnSUNCbVpXVTZJREFzQ2drdkx5QWdJQ0FnSUNCbmJHOWlZV3hPZFcxQ2VYUmxVMnhwWTJVNklEWXNDZ2t2THlBZ0lDQWdJQ0JuYkc5aVlXeE9kVzFWYVc1ME9pQXlMQW9KTHk4Z0lDQWdJSDBwQ2dscGRIaHVYMkpsWjJsdUNnbHBiblJqSURJZ0x5OGdJR0Z3Y0d3S0NXbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtDWEIxYzJoaWVYUmxjeUF3ZURVNU9UVmtaalV6SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExITjBjbWx1Wnl4aFpHUnlaWE56TEhOMGNtbHVaeWwyYjJsa0lnb0phWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TVRBS0NTOHZJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJUb2dRV2RsYm5SRGFHbHNaQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LUW9KVUVWT1JFbE9SMTlEVDAxUVNVeEZYMEZRVUZKUFZrRk1PaUJCWjJWdWRFTm9hV3hrQ2dscGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qRXhNUW9KTHk4Z1kyeGxZWEpUZEdGMFpWQnliMmR5WVcwNklFRm5aVzUwUTJocGJHUXVZMnhsWVhKUWNtOW5jbUZ0S0NrS0NWQkZUa1JKVGtkZlEwOU5VRWxNUlY5RFRFVkJVam9nUVdkbGJuUkRhR2xzWkFvSmFYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakV4TWdvSkx5OGdiV1YwYUc5a1FYSm5jem9nVzI1aGJXVXNJR1JsYzJOeWFYQjBhVzl1TENCbGJtUndiMmx1ZEY5MWNtd3NJSEJ5YVdObFgyRnNaMjhzSUdOaGRHVm5iM0o1TENCMGFHbHpMblI0Ymk1elpXNWtaWElzSUdsdVptOWZkWEpzWFFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUc1aGJXVTZJSE4wY21sdVp3b0paSFZ3Q2dsc1pXNEtDV2wwYjJJS0NXVjRkSEpoWTNRZ05pQXlDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp3b0paSFZ3Q2dsc1pXNEtDV2wwYjJJS0NXVjRkSEpoWTNRZ05pQXlDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNnbG1jbUZ0WlY5a2FXY2dMVFFnTHk4Z1pXNWtjRzlwYm5SZmRYSnNPaUJ6ZEhKcGJtY0tDV1IxY0FvSmJHVnVDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KYzNkaGNBb0pZMjl1WTJGMENnbHBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b0pabkpoYldWZlpHbG5JQzAxSUM4dklIQnlhV05sWDJGc1oyODZJSFZwYm5RMk5Bb0phWFJ2WWdvSmFYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0NXWnlZVzFsWDJScFp5QXROaUF2THlCallYUmxaMjl5ZVRvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LQ1hSNGJpQlRaVzVrWlhJS0NXbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNnbG1jbUZ0WlY5a2FXY2dMVGNnTHk4Z2FXNW1iMTkxY213NklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk1URXpDZ2t2THlCbVpXVTZJREFLQ1dsdWRHTWdNU0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qRXhOQW9KTHk4Z1oyeHZZbUZzVG5WdFFubDBaVk5zYVdObE9pQTJDZ2xwYm5SaklESWdMeThnTmdvSmFYUjRibDltYVdWc1pDQkhiRzlpWVd4T2RXMUNlWFJsVTJ4cFkyVUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TVRVS0NTOHZJR2RzYjJKaGJFNTFiVlZwYm5RNklESUtDWEIxYzJocGJuUWdNZ29KYVhSNGJsOW1hV1ZzWkNCSGJHOWlZV3hPZFcxVmFXNTBDZ29KTHk4Z1UzVmliV2wwSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2dscGRIaHVYM04xWW0xcGRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakV4T0FvSkx5OGdZMmhwYkdSQmNIQWdQU0IwYUdsekxtbDBlRzR1WTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0NXbDBlRzRnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0NXWnlZVzFsWDJKMWNua2dNaUF2THlCamFHbHNaRUZ3Y0RvZ2RXbHVkRFkwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk1USXdDZ2t2THlCMGFHbHpMbXhwYzNScGJtZHpLR0p2ZUV0bGVTa3VkbUZzZFdVZ1BTQmphR2xzWkVGd2NBb0pabkpoYldWZlpHbG5JREVnTHk4Z1ltOTRTMlY1T2lCaWVYUmxXMTBLQ1daeVlXMWxYMlJwWnlBeUlDOHZJR05vYVd4a1FYQndPaUIxYVc1ME5qUUtDV2wwYjJJS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdkbGJuUkRiMjUwY21GamRITXVZV3huYnk1MGN6b3hNakVLQ1M4dklIUm9hWE11ZEc5MFlXeGZiR2x6ZEdsdVozTXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNYMnhwYzNScGJtZHpMblpoYkhWbElDc2dNUW9KWW5sMFpXTWdNU0F2THlBZ0luUnZkR0ZzWDJ4cGMzUnBibWR6SWdvSlpIVndDZ2xoY0hCZloyeHZZbUZzWDJkbGRBb0phVzUwWXlBd0lDOHZJREVLQ1NzS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk1USXlDZ2t2THlCMGFHbHpMbTVsZUhSZmJtOXVZMlV1ZG1Gc2RXVWdQU0J1YjI1alpTQXJJREVLQ1dKNWRHVmpJRElnTHk4Z0lDSnVaWGgwWDI1dmJtTmxJZ29KWm5KaGJXVmZaR2xuSURBZ0x5OGdibTl1WTJVNklIVnBiblEyTkFvSmFXNTBZeUF3SUM4dklERUtDU3NLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TVRJMENna3ZMeUJ5WlhSMWNtNGdibTl1WTJVN0NnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCdWIyNWpaVG9nZFdsdWREWTBDZ29KTHk4Z2MyVjBJSFJvWlNCemRXSnliM1YwYVc1bElISmxkSFZ5YmlCMllXeDFaUW9KWm5KaGJXVmZZblZ5ZVNBd0Nnb0pMeThnY0c5d0lHRnNiQ0JzYjJOaGJDQjJZWEpwWVdKc1pYTWdabkp2YlNCMGFHVWdjM1JoWTJzS0NYQnZjRzRnTWdvSmNtVjBjM1ZpQ2dvdkx5Qm5aWFJmYkdsemRHbHVaMTloY0hBb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZFdsdWREWTBDaXBoWW1sZmNtOTFkR1ZmWjJWMFgyeHBjM1JwYm1kZllYQndPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2xpZVhSbFl5QXpJQzh2SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJ1YjI1alpUb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2dsaWRHOXBDZ29KTHk4Z2QyRnNiR1YwT2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xrZFhBS0NXeGxiZ29KY0hWemFHbHVkQ0F6TWdvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBeElDaDNZV3hzWlhRcElHWnZjaUJuWlhSZmJHbHpkR2x1WjE5aGNIQWdiWFZ6ZENCaVpTQmhJR0ZrWkhKbGMzTUtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnWjJWMFgyeHBjM1JwYm1kZllYQndLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYVnBiblEyTkFvSlkyRnNiSE4xWWlCblpYUmZiR2x6ZEdsdVoxOWhjSEFLQ1dsMGIySUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJuWlhSZmJHbHpkR2x1WjE5aGNIQW9kMkZzYkdWME9pQkJaR1J5WlhOekxDQnViMjVqWlRvZ2RXbHVkRFkwS1RvZ1FYQndTVVFLWjJWMFgyeHBjM1JwYm1kZllYQndPZ29KY0hKdmRHOGdNaUF4Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NXSjVkR1ZqSURBZ0x5OGdNSGdLQ2drdkx5QmpiMjUwY21GamRITmNRV2RsYm5SRGIyNTBjbUZqZEhNdVlXeG5ieTUwY3pveE1qZ0tDUzh2SUdKdmVFdGxlU0E5SUdOdmJtTmhkQ2gzWVd4c1pYUXNJR2wwYjJJb2JtOXVZMlVwS1FvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUhkaGJHeGxkRG9nUVdSa2NtVnpjd29KWm5KaGJXVmZaR2xuSUMweUlDOHZJRzV2Ym1ObE9pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJR0p2ZUV0bGVUb2dZbmwwWlZ0ZENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZNVEk1Q2drdkx5QmhjM05sY25Rb2RHaHBjeTVzYVhOMGFXNW5jeWhpYjNoTFpYa3BMbVY0YVhOMGN5a0tDV1p5WVcxbFgyUnBaeUF3SUM4dklHSnZlRXRsZVRvZ1lubDBaVnRkQ2dsaWIzaGZiR1Z1Q2dsemQyRndDZ2x3YjNBS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qRXpNQW9KTHk4Z2NtVjBkWEp1SUhSb2FYTXViR2x6ZEdsdVozTW9ZbTk0UzJWNUtTNTJZV3gxWlRzS0NXWnlZVzFsWDJScFp5QXdJQzh2SUdKdmVFdGxlVG9nWW5sMFpWdGRDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbXhwYzNScGJtZHpLR0p2ZUV0bGVTa3VkbUZzZFdVS0NXRnpjMlZ5ZEFvSlluUnZhUW9LQ1M4dklITmxkQ0IwYUdVZ2MzVmljbTkxZEdsdVpTQnlaWFIxY200Z2RtRnNkV1VLQ1daeVlXMWxYMkoxY25rZ01Bb0pjbVYwYzNWaUNnb3ZMeUJrWld4bGRHVmZiR2x6ZEdsdVp5aDFhVzUwTmpRcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJSbGJHVjBaVjlzYVhOMGFXNW5PZ29KTHk4Z2JtOXVZMlU2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdaR1ZzWlhSbFgyeHBjM1JwYm1jb2RXbHVkRFkwS1hadmFXUUtDV05oYkd4emRXSWdaR1ZzWlhSbFgyeHBjM1JwYm1jS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdSbGJHVjBaVjlzYVhOMGFXNW5LRzV2Ym1ObE9pQjFhVzUwTmpRcE9pQjJiMmxrQ21SbGJHVjBaVjlzYVhOMGFXNW5PZ29KY0hKdmRHOGdNU0F3Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NXSjVkR1ZqSURBZ0x5OGdNSGdLQ1dSMWNBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakV6TkFvSkx5OGdZbTk0UzJWNUlEMGdZMjl1WTJGMEtIUm9hWE11ZEhodUxuTmxibVJsY2l3Z2FYUnZZaWh1YjI1alpTa3BDZ2wwZUc0Z1UyVnVaR1Z5Q2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYm05dVkyVTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWW05NFMyVjVPaUJpZVhSbFcxMEtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TXpVS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG14cGMzUnBibWR6S0dKdmVFdGxlU2t1WlhocGMzUnpLUW9KWm5KaGJXVmZaR2xuSURBZ0x5OGdZbTk0UzJWNU9pQmllWFJsVzEwS0NXSnZlRjlzWlc0S0NYTjNZWEFLQ1hCdmNBb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZNVE0yQ2drdkx5QmphR2xzWkVGd2NDQTlJSFJvYVhNdWJHbHpkR2x1WjNNb1ltOTRTMlY1S1M1MllXeDFaUW9KWm5KaGJXVmZaR2xuSURBZ0x5OGdZbTk0UzJWNU9pQmllWFJsVzEwS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdWJHbHpkR2x1WjNNb1ltOTRTMlY1S1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbG1jbUZ0WlY5aWRYSjVJREVnTHk4Z1kyaHBiR1JCY0hBNklIVnBiblEyTkFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWjJWdWRFTnZiblJ5WVdOMGN5NWhiR2R2TG5Sek9qRXpPUW9KTHk4Z2MyVnVaRTFsZEdodlpFTmhiR3c4ZEhsd1pXOW1JRUZuWlc1MFEyaHBiR1F1Y0hKdmRHOTBlWEJsTG1SbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1UGloN0Nna3ZMeUFnSUNBZ0lDQmhjSEJzYVdOaGRHbHZia2xFT2lCamFHbHNaRUZ3Y0N3S0NTOHZJQ0FnSUNBZ0lHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwYVc5dUxrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUxBb0pMeThnSUNBZ0lDQWdabVZsT2lBd0xDQXZMeUJHWldVZ2NHOXZiR1ZrSUdaeWIyMGdiM1YwWlhJZ2RIaHVDZ2t2THlBZ0lDQWdmU2tLQ1dsMGVHNWZZbVZuYVc0S0NXbHVkR01nTWlBdkx5QWdZWEJ3YkFvSmFYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb0pZbmwwWldNZ05DQXZMeUFnYldWMGFHOWtJQ0prWld4bGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDV2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRm5aVzUwUTI5dWRISmhZM1J6TG1Gc1oyOHVkSE02TVRRd0Nna3ZMeUJoY0hCc2FXTmhkR2x2YmtsRU9pQmphR2xzWkVGd2NBb0pabkpoYldWZlpHbG5JREVnTHk4Z1kyaHBiR1JCY0hBNklIVnBiblEyTkFvSmFYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZuWlc1MFEyOXVkSEpoWTNSekxtRnNaMjh1ZEhNNk1UUXhDZ2t2THlCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvSmNIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDZ2xwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakUwTWdvSkx5OGdabVZsT2lBd0NnbHBiblJqSURFZ0x5OGdNQW9KYVhSNGJsOW1hV1ZzWkNCR1pXVUtDZ2t2THlCVGRXSnRhWFFnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRLQ1dsMGVHNWZjM1ZpYldsMENnb0pMeThnWTI5dWRISmhZM1J6WEVGblpXNTBRMjl1ZEhKaFkzUnpMbUZzWjI4dWRITTZNVFEyQ2drdkx5QnpaVzVrVUdGNWJXVnVkQ2g3Q2drdkx5QWdJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTUwZUc0dWMyVnVaR1Z5TEFvSkx5OGdJQ0FnSUNBZ1lXMXZkVzUwT2lBME56aGZOekF3TEFvSkx5OGdJQ0FnSUNBZ1ptVmxPaUF3TEFvSkx5OGdJQ0FnSUgwcENnbHBkSGh1WDJKbFoybHVDZ2xwYm5SaklEQWdMeThnSUhCaGVRb0phWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJaMlZ1ZEVOdmJuUnlZV04wY3k1aGJHZHZMblJ6T2pFME53b0pMeThnY21WalpXbDJaWEk2SUhSb2FYTXVkSGh1TG5ObGJtUmxjZ29KZEhodUlGTmxibVJsY2dvSmFYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakUwT0FvSkx5OGdZVzF2ZFc1ME9pQTBOemhmTnpBd0NnbHBiblJqSURNZ0x5OGdORGM0WHpjd01Bb0phWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TkRrS0NTOHZJR1psWlRvZ01Bb0phVzUwWXlBeElDOHZJREFLQ1dsMGVHNWZabWxsYkdRZ1JtVmxDZ29KTHk4Z1UzVmliV2wwSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2dscGRIaHVYM04xWW0xcGRBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakUxTWdvSkx5OGdkR2hwY3k1c2FYTjBhVzVuY3loaWIzaExaWGtwTG1SbGJHVjBaU2dwQ2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJpYjNoTFpYazZJR0o1ZEdWYlhRb0pZbTk0WDJSbGJBb0tDUzh2SUdOdmJuUnlZV04wYzF4QloyVnVkRU52Ym5SeVlXTjBjeTVoYkdkdkxuUnpPakUxTXdvSkx5OGdkR2hwY3k1MGIzUmhiRjlzYVhOMGFXNW5jeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hmYkdsemRHbHVaM011ZG1Gc2RXVWdMU0F4Q2dsaWVYUmxZeUF4SUM4dklDQWlkRzkwWVd4ZmJHbHpkR2x1WjNNaUNnbGtkWEFLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xwYm5SaklEQWdMeThnTVFvSkxRb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0NYSmxkSE4xWWdvS0x5OGdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRS0ttRmlhVjl5YjNWMFpWOWtaV3hsZEdWQmNIQnNhV05oZEdsdmJqb0tDUzh2SUdWNFpXTjFkR1VnWkdWc1pYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUUtDV05oYkd4emRXSWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUtDazZJSFp2YVdRS1pHVnNaWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHdjbTkwYnlBd0lEQUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TlRjS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5SNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlYQndMbU55WldGMGIzSXBDZ2wwZUc0Z1UyVnVaR1Z5Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1Y3lBd0NnbGhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRjbVZoZEc5eUNnbHdiM0FLQ1QwOUNnbGhjM05sY25RS0NYSmxkSE4xWWdvS0x5OGdkWEJrWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRS0ttRmlhVjl5YjNWMFpWOTFjR1JoZEdWQmNIQnNhV05oZEdsdmJqb0tDUzh2SUdWNFpXTjFkR1VnZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUUtDV05oYkd4emRXSWdkWEJrWVhSbFFYQndiR2xqWVhScGIyNEtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklIVndaR0YwWlVGd2NHeHBZMkYwYVc5dUtDazZJSFp2YVdRS2RYQmtZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHdjbTkwYnlBd0lEQUtDZ2t2THlCamIyNTBjbUZqZEhOY1FXZGxiblJEYjI1MGNtRmpkSE11WVd4bmJ5NTBjem94TmpFS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5SNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlYQndMbU55WldGMGIzSXBDZ2wwZUc0Z1UyVnVaR1Z5Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1Y3lBd0NnbGhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRjbVZoZEc5eUNnbHdiM0FLQ1QwOUNnbGhjM05sY25RS0NYSmxkSE4xWWdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRGhrWkdRM05HSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMnhwYzNScGJtY29jR0Y1TEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNzYzNSeWFXNW5LWFZwYm5RMk5DSUtDWEIxYzJoaWVYUmxjeUF3ZUdNeVl6SmlZVFEwSUM4dklHMWxkR2h2WkNBaVoyVjBYMnhwYzNScGJtZGZZWEJ3S0dGa1pISmxjM01zZFdsdWREWTBLWFZwYm5RMk5DSUtDWEIxYzJoaWVYUmxjeUF3ZURVNU9EaGxPV1F4SUM4dklHMWxkR2h2WkNBaVpHVnNaWFJsWDJ4cGMzUnBibWNvZFdsdWREWTBLWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVjlzYVhOMGFXNW5JQ3BoWW1sZmNtOTFkR1ZmWjJWMFgyeHBjM1JwYm1kZllYQndJQ3BoWW1sZmNtOTFkR1ZmWkdWc1pYUmxYMnhwYzNScGJtY0tDZ2t2THlCMGFHbHpJR052Ym5SeVlXTjBJR1J2WlhNZ2JtOTBJR2x0Y0d4bGJXVnVkQ0IwYUdVZ1oybDJaVzRnUVVKSklHMWxkR2h2WkNCbWIzSWdZMkZzYkNCT2IwOXdDZ2xsY25JS0NpcGpZV3hzWDFWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmNIVnphR0o1ZEdWeklEQjRORFptTnpZMU16TWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZmRYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JWY0dSaGRHVkJjSEJzYVdOaGRHbHZiZ29KWlhKeUNnb3FZMkZzYkY5RVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmpvS0NXSjVkR1ZqSURRZ0x5OGdJRzFsZEdodlpDQWlaR1ZzWlhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtDV1Z5Y2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOm51bGwsImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
