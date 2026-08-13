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

namespace Arc56.Generated.sarika_akhil.blockchain.AIAnalysisPayment_ffd290b3
{


    //
    // 
    //    FixChain AI Algorand Smart Contract for x402 AI Analysis Payment Registry.
    //    Maintains on-chain registry & state for paid AI-analysis access.
    //    - Records USDC payment IDs to prevent duplicate replay attacks using BoxMap storage.
    //    - Manages service pricing (microUSDC) and merchant treasury routing.
    //    - Toggles service availability.
    //    
    //
    public class AIAnalysisPaymentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AIAnalysisPaymentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the AI payment smart contract application.
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Configure the treasury, accepted USDC ASA ID, and initial AI analysis price.
        ///</summary>
        /// <param name="treasury"> </param>
        /// <param name="usdc_asset"> </param>
        /// <param name="ai_price"> </param>
        public async Task Initialize(Algorand.Address treasury, ulong usdc_asset, ulong ai_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 221, 39, 162 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var usdc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_assetAbi.From(usdc_asset);
            var ai_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ai_priceAbi.From(ai_price);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAbi, usdc_assetAbi, ai_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address treasury, ulong usdc_asset, ulong ai_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 221, 39, 162 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var usdc_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_assetAbi.From(usdc_asset);
            var ai_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ai_priceAbi.From(ai_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAbi, usdc_assetAbi, ai_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the AI analysis service price in microUSDC.
        ///</summary>
        /// <param name="new_price"> </param>
        public async Task SetServicePrice(ulong new_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 98, 225, 5 };
            var new_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_priceAbi.From(new_price);

            var result = await base.CallApp(new List<object> { abiHandle, new_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetServicePrice_Transactions(ulong new_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 98, 225, 5 };
            var new_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_priceAbi.From(new_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Toggle service availability on/off.
        ///</summary>
        /// <param name="enabled"> </param>
        public async Task SetServiceEnabled(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 209, 193, 200 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetServiceEnabled_Transactions(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 209, 193, 200 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the treasury address.
        ///</summary>
        /// <param name="new_treasury"> </param>
        public async Task SetTreasury(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            var result = await base.CallApp(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record verified x402 AI payment on-chain.
        ///Prevents duplicate payment IDs using BoxMap storage.
        ///</summary>
        /// <param name="payment_id"> </param>
        /// <param name="payer"> </param>
        /// <param name="amount"> </param>
        /// <param name="service_type"> </param>
        public async Task RecordPayment(string payment_id, Algorand.Address payer, ulong amount, string service_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 203, 121, 64 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); payment_idAbi.From(payment_id);
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var service_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_typeAbi.From(service_type);

            var result = await base.CallApp(new List<object> { abiHandle, payment_idAbi, payerAbi, amountAbi, service_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordPayment_Transactions(string payment_id, Algorand.Address payer, ulong amount, string service_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 203, 121, 64 };
            var payment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); payment_idAbi.From(payment_id);
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var service_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_typeAbi.From(service_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_idAbi, payerAbi, amountAbi, service_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQUlBbmFseXNpc1BheW1lbnQiLCJkZXNjIjoiXG4gICAgRml4Q2hhaW4gQUkgQWxnb3JhbmQgU21hcnQgQ29udHJhY3QgZm9yIHg0MDIgQUkgQW5hbHlzaXMgUGF5bWVudCBSZWdpc3RyeS5cbiAgICBNYWludGFpbnMgb24tY2hhaW4gcmVnaXN0cnkgJiBzdGF0ZSBmb3IgcGFpZCBBSS1hbmFseXNpcyBhY2Nlc3MuXG4gICAgLSBSZWNvcmRzIFVTREMgcGF5bWVudCBJRHMgdG8gcHJldmVudCBkdXBsaWNhdGUgcmVwbGF5IGF0dGFja3MgdXNpbmcgQm94TWFwIHN0b3JhZ2UuXG4gICAgLSBNYW5hZ2VzIHNlcnZpY2UgcHJpY2luZyAobWljcm9VU0RDKSBhbmQgbWVyY2hhbnQgdHJlYXN1cnkgcm91dGluZy5cbiAgICAtIFRvZ2dsZXMgc2VydmljZSBhdmFpbGFiaWxpdHkuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBBSSBwYXltZW50IHNtYXJ0IGNvbnRyYWN0IGFwcGxpY2F0aW9uLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkNvbmZpZ3VyZSB0aGUgdHJlYXN1cnksIGFjY2VwdGVkIFVTREMgQVNBIElELCBhbmQgaW5pdGlhbCBBSSBhbmFseXNpcyBwcmljZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyZWFzdXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2RjX2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhaV9wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfc2VydmljZV9wcmljZSIsImRlc2MiOiJVcGRhdGUgdGhlIEFJIGFuYWx5c2lzIHNlcnZpY2UgcHJpY2UgaW4gbWljcm9VU0RDLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3NlcnZpY2VfZW5hYmxlZCIsImRlc2MiOiJUb2dnbGUgc2VydmljZSBhdmFpbGFiaWxpdHkgb24vb2ZmLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF90cmVhc3VyeSIsImRlc2MiOiJVcGRhdGUgdGhlIHRyZWFzdXJ5IGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfdHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX3BheW1lbnQiLCJkZXNjIjoiUmVjb3JkIHZlcmlmaWVkIHg0MDIgQUkgcGF5bWVudCBvbi1jaGFpbi5cblByZXZlbnRzIGR1cGxpY2F0ZSBwYXltZW50IElEcyB1c2luZyBCb3hNYXAgc3RvcmFnZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZpY2VfdHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM1MV0sImVycm9yTWVzc2FnZSI6IkFJIGFuYWx5c2lzIHNlcnZpY2UgaXMgZGlzYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTJdLCJlcnJvck1lc3NhZ2UiOiJEdXBsaWNhdGUgcGF5bWVudCBJRCBhbHJlYWR5IHJlY29yZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gaW5pdGlhbGl6ZSBjb25maWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB0b2dnbGUgc2VydmljZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVwZGF0ZSBwcmljZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVwZGF0ZSB0cmVhc3VyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Nl0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgSUQgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYwXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBhbW91bnQgZG9lcyBub3QgbWF0Y2ggY3VycmVudCBBSSBwcmljZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NiwyNDIsMjY1LDI4Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5haV9wcmljZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNlcnZpY2VfZW5hYmxlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2FuYWx5c2VzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfdXNkY19yZWNlaXZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDAsMzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4LDM0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzIsMjgwLDMxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODAsMTg5LDIzNSwyNTgsMzI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVdSdGFXNGlJQ0p6WlhKMmFXTmxYMlZ1WVdKc1pXUWlJQ0owYjNSaGJGOWhibUZzZVhObGN5SWdJblJ2ZEdGc1gzVnpaR05mY21WalpXbDJaV1FpSUNKaGFWOXdjbWxqWlNJZ0luUnlaV0Z6ZFhKNUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyRnVZV3g1YzJselgzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJR05zWVhOeklFRkpRVzVoYkhsemFYTlFZWGx0Wlc1MEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXhDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNMkprWkRJM1lUSWdNSGc0WlRZeVpURXdOU0F3ZURNMlpERmpNV000SURCNFptTmtPR05oWVdZZ01IaGtOV05pTnprME1DQXZMeUJ0WlhSb2IyUWdJbWx1YVhScFlXeHBlbVVvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOXpaWEoyYVdObFgzQnlhV05sS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYzJWeWRtbGpaVjlsYm1GaWJHVmtLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUmZkSEpsWVhOMWNua29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmY0dGNWJXVnVkQ2h6ZEhKcGJtY3NZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JwYm1sMGFXRnNhWHBsSUhObGRGOXpaWEoyYVdObFgzQnlhV05sSUhObGRGOXpaWEoyYVdObFgyVnVZV0pzWldRZ2MyVjBYM1J5WldGemRYSjVJSEpsWTI5eVpGOXdZWGx0Wlc1MENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZZVzVoYkhsemFYTmZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWTJ4aGMzTWdRVWxCYm1Gc2VYTnBjMUJoZVcxbGJuUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjMU1tTXpZV013SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUNpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2xmWVc1aGJIbHphWE5mY0dGNWJXVnVkQzVqYjI1MGNtRmpkQzVCU1VGdVlXeDVjMmx6VUdGNWJXVnVkQzVqY21WaGRHVmZZWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ6Wld4bUxuTmxjblpwWTJWZlpXNWhZbXhsWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMyVnlkbWxqWlY5bGJtRmliR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmWVc1aGJIbHphWE5mY0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWhibUZzZVhObGN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZllXNWhiSGx6WlhNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1Z6WkdOZmNtVmpaV2wyWldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDNWelpHTmZjbVZqWldsMlpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM1amIyNTBjbUZqZEM1QlNVRnVZV3g1YzJselVHRjViV1Z1ZEM1cGJtbDBhV0ZzYVhwbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVwZEdsaGJHbDZaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjloYm1Gc2VYTnBjMTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyRnVZV3g1YzJselgzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0c0lDSlBibXg1SUdGa2JXbHVJR05oYmlCcGJtbDBhV0ZzYVhwbElHTnZibVpwWnlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQmpZVzRnYVc1cGRHbGhiR2w2WlNCamIyNW1hV2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjloYm1Gc2VYTnBjMTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVJRDBnZEhKbFlYTjFjbmtLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ5WldGemRYSjVJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGcFgyRnVZV3g1YzJselgzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdWRYTmtZMTloYzNObGRDQTlJSFZ6WkdOZllYTnpaWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkWE5rWTE5aGMzTmxkQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJ6Wld4bUxtRnBYM0J5YVdObElEMGdZV2xmY0hKcFkyVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRnBYM0J5YVdObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJ6Wld4bUxuTmxjblpwWTJWZlpXNWhZbXhsWkNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMyVnlkbWxqWlY5bGJtRmliR1ZrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmWVc1aGJIbHphWE5mY0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRnBYMkZ1WVd4NWMybHpYM0JoZVcxbGJuUXVZMjl1ZEhKaFkzUXVRVWxCYm1Gc2VYTnBjMUJoZVcxbGJuUXVjMlYwWDNObGNuWnBZMlZmY0hKcFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmMyVnlkbWxqWlY5d2NtbGpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjloYm1Gc2VYTnBjMTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnZFhCa1lYUmxJSEJ5YVdObElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCMWNHUmhkR1VnY0hKcFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJ6Wld4bUxtRnBYM0J5YVdObElEMGdibVYzWDNCeWFXTmxDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhhVjl3Y21salpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZZVzVoYkhsemFYTmZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GcFgyRnVZV3g1YzJselgzQmhlVzFsYm5RdVkyOXVkSEpoWTNRdVFVbEJibUZzZVhOcGMxQmhlVzFsYm5RdWMyVjBYM05sY25acFkyVmZaVzVoWW14bFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5elpYSjJhV05sWDJWdVlXSnNaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2xmWVc1aGJIbHphWE5mY0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhSdloyZHNaU0J6WlhKMmFXTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjBiMmRuYkdVZ2MyVnlkbWxqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZwWDJGdVlXeDVjMmx6WDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklITmxiR1l1YzJWeWRtbGpaVjlsYm1GaWJHVmtJRDBnWlc1aFlteGxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljMlZ5ZG1salpWOWxibUZpYkdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGFWOWhibUZzZVhOcGMxOXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM1amIyNTBjbUZqZEM1QlNVRnVZV3g1YzJselVHRjViV1Z1ZEM1elpYUmZkSEpsWVhOMWNubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmRISmxZWE4xY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzJPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnZFhCa1lYUmxJSFJ5WldGemRYSjVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjFjR1JoZEdVZ2RISmxZWE4xY25rS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QnpaV3htTG5SeVpXRnpkWEo1SUQwZ2JtVjNYM1J5WldGemRYSjVDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBjbVZoYzNWeWVTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZZVzVoYkhsemFYTmZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GcFgyRnVZV3g1YzJselgzQmhlVzFsYm5RdVkyOXVkSEpoWTNRdVFVbEJibUZzZVhOcGMxQmhlVzFsYm5RdWNtVmpiM0prWDNCaGVXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnZjbVJmY0dGNWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhhVjloYm1Gc2VYTnBjMTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXbGZZVzVoYkhsemFYTmZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMyVnlkbWxqWlY5bGJtRmliR1ZrSUQwOUlGVkpiblEyTkNneEtTd2dJa0ZKSUdGdVlXeDVjMmx6SUhObGNuWnBZMlVnYVhNZ1pHbHpZV0pzWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzJWeWRtbGpaVjlsYm1GaWJHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5ObGNuWnBZMlZmWlc1aFlteGxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZKSUdGdVlXeDVjMmx6SUhObGNuWnBZMlVnYVhNZ1pHbHpZV0pzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwSUQwOUlITmxiR1l1WVdsZmNISnBZMlVzSUNKUVlYbHRaVzUwSUdGdGIzVnVkQ0JrYjJWeklHNXZkQ0J0WVhSamFDQmpkWEp5Wlc1MElFRkpJSEJ5YVdObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1GcFgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnBYM0J5YVdObElHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQmhiVzkxYm5RZ1pHOWxjeUJ1YjNRZ2JXRjBZMmdnWTNWeWNtVnVkQ0JCU1NCd2NtbGpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnBYMkZ1WVd4NWMybHpYM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYMmxrSUNFOUlGTjBjbWx1WnlnaUlpa3NJQ0pRWVhsdFpXNTBJRWxFSUdOaGJtNXZkQ0JpWlNCbGJYQjBlU0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCSlJDQmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qa3dMVGt4Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJR1IxY0d4cFkyRjBaU0J3WVhsdFpXNTBJRWxFSUhacFlTQkNiM2hOWVhBZ2MzUnZjbUZuWlFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUmZhV1FnYm05MElHbHVJSE5sYkdZdWNHRjViV1Z1ZEY5eVpXTnZjbVJ6TENBaVJIVndiR2xqWVhSbElIQmhlVzFsYm5RZ1NVUWdZV3h5WldGa2VTQnlaV052Y21SbFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBaWNHRjViV1Z1ZEY5eVpXTnZjbVJ6SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSSFZ3YkdsallYUmxJSEJoZVcxbGJuUWdTVVFnWVd4eVpXRmtlU0J5WldOdmNtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnBYMkZ1WVd4NWMybHpYM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T1RNdE9UUUtJQ0FnSUM4dklDTWdUV0Z5YXlCd1lYbHRaVzUwSUVsRUlHRnpJSEpsWTI5eVpHVmtJR2x1SUVKdmVFMWhjQ0J6ZEc5eVlXZGxDaUFnSUNBdkx5QnpaV3htTG5CaGVXMWxiblJmY21WamIzSmtjMXR3WVhsdFpXNTBYMmxrWFNBOUlITmxjblpwWTJWZmRIbHdaUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMkZ1WVd4NWMyVnpJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gyRnVZV3g1YzJWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyRnVZV3g1YzJWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJGdVlXeDVjMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYVY5aGJtRnNlWE5wYzE5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1Z6WkdOZmNtVmpaV2wyWldRZ0t6MGdZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZkWE5rWTE5eVpXTmxhWFpsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MWMyUmpYM0psWTJWcGRtVmtJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZkWE5rWTE5eVpXTmxhWFpsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdsZllXNWhiSGx6YVhOZmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUlDWUdCV0ZrYldsdUQzTmxjblpwWTJWZlpXNWhZbXhsWkE1MGIzUmhiRjloYm1Gc2VYTmxjeE4wYjNSaGJGOTFjMlJqWDNKbFkyVnBkbVZrQ0dGcFgzQnlhV05sQ0hSeVpXRnpkWEo1TVJrVVJERVlRUUFyZ2dVRU85MG5vZ1NPWXVFRkJEYlJ3Y2dFL05qS3J3VFZ5M2xBTmhvQWpnVUFIZ0JkQUhRQWlnQ2dBSUFFZFN3NndEWWFBSTRCQUFFQUtERUFaeWtpWnlvaVp5c2laeU5ETmhvQlNSVWxFa1EyR2dKSkZTUVNSQmMyR2dOSkZTUVNSQmN4QUNJb1pVUVNSQ2NGVHdObmdBcDFjMlJqWDJGemMyVjBUd0puSndSTVp5a2paeU5ETmhvQlNSVWtFa1FYTVFBaUtHVkVFa1FuQkV4bkkwTTJHZ0ZKRlNRU1JCY3hBQ0lvWlVRU1JDbE1aeU5ETmhvQlNSVWxFa1F4QUNJb1pVUVNSQ2NGVEdjalF6WWFBVWtpV1lFQ0NFc0JGUkpFVndJQU5ob0NGU1VTUkRZYUEwa1ZKQkpFRnpZYUJFa2lXWUVDQ0VzQkZSSkVWd0lBSWlsbFJDTVNSQ0luQkdWRVN3SVNSRXNDZ0FBVFJJQVBjR0Y1YldWdWRGOXlaV052Y21SelR3TlFTYjFGQVJSRVNieElUTDhpS21WRUl3Z3FUR2NpSzJWRUNDdE1aeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
