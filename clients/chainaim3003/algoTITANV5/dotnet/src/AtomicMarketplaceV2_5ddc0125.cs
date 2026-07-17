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

namespace Arc56.Generated.chainaim3003.algoTITANV5.AtomicMarketplaceV2_5ddc0125
{


    public class AtomicMarketplaceV2Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AtomicMarketplaceV2Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize marketplace with configuration
        ///</summary>
        /// <param name="adminAddress"> </param>
        /// <param name="blContractId"> </param>
        /// <param name="marketplaceFeeRate"> </param>
        /// <param name="usdcAssetId"> </param>
        /// <param name="usdtAssetId"> </param>
        public async Task<string> InitializeMarketplace(string adminAddress, ulong blContractId, ulong marketplaceFeeRate, ulong usdcAssetId, ulong usdtAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 192, 177, 65 };
            var adminAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); adminAddressAbi.From(adminAddress);
            var blContractIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blContractIdAbi.From(blContractId);
            var marketplaceFeeRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); marketplaceFeeRateAbi.From(marketplaceFeeRate);
            var usdcAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdcAssetIdAbi.From(usdcAssetId);
            var usdtAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdtAssetIdAbi.From(usdtAssetId);

            var result = await base.CallApp(new List<object> { abiHandle, adminAddressAbi, blContractIdAbi, marketplaceFeeRateAbi, usdcAssetIdAbi, usdtAssetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InitializeMarketplace_Transactions(string adminAddress, ulong blContractId, ulong marketplaceFeeRate, ulong usdcAssetId, ulong usdtAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 192, 177, 65 };
            var adminAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); adminAddressAbi.From(adminAddress);
            var blContractIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blContractIdAbi.From(blContractId);
            var marketplaceFeeRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); marketplaceFeeRateAbi.From(marketplaceFeeRate);
            var usdcAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdcAssetIdAbi.From(usdcAssetId);
            var usdtAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdtAssetIdAbi.From(usdtAssetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAddressAbi, blContractIdAbi, marketplaceFeeRateAbi, usdcAssetIdAbi, usdtAssetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create marketplace listing for fractionalized BL shares
        ///</summary>
        /// <param name="blId"> </param>
        /// <param name="pricePerShare"> </param>
        /// <param name="totalShares"> </param>
        /// <param name="minPurchase"> </param>
        /// <param name="maxPurchase"> </param>
        /// <param name="paymentMethods"> </param>
        public async Task<ulong> CreateListing(ulong blId, ulong pricePerShare, ulong totalShares, ulong minPurchase, ulong maxPurchase, ulong paymentMethods, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 133, 249, 148 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);
            var totalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSharesAbi.From(totalShares);
            var minPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minPurchaseAbi.From(minPurchase);
            var maxPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxPurchaseAbi.From(maxPurchase);
            var paymentMethodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodsAbi.From(paymentMethods);

            var result = await base.CallApp(new List<object> { abiHandle, blIdAbi, pricePerShareAbi, totalSharesAbi, minPurchaseAbi, maxPurchaseAbi, paymentMethodsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateListing_Transactions(ulong blId, ulong pricePerShare, ulong totalShares, ulong minPurchase, ulong maxPurchase, ulong paymentMethods, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 133, 249, 148 };
            var blIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blIdAbi.From(blId);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);
            var totalSharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalSharesAbi.From(totalShares);
            var minPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minPurchaseAbi.From(minPurchase);
            var maxPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxPurchaseAbi.From(maxPurchase);
            var paymentMethodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodsAbi.From(paymentMethods);

            return await base.MakeTransactionList(new List<object> { abiHandle, blIdAbi, pricePerShareAbi, totalSharesAbi, minPurchaseAbi, maxPurchaseAbi, paymentMethodsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///ATOMIC SETTLEMENT - The key innovation (simplified implementation)
        ///This eliminates manual intervention from the XDC version
        ///</summary>
        /// <param name="listingId"> </param>
        /// <param name="sharesPurchased"> </param>
        /// <param name="paymentMethod"> </param>
        /// <param name="maxSlippage"> </param>
        public async Task<ulong> AtomicPurchase(ulong listingId, ulong sharesPurchased, ulong paymentMethod, ulong maxSlippage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 56, 47, 103 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var sharesPurchasedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesPurchasedAbi.From(sharesPurchased);
            var paymentMethodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodAbi.From(paymentMethod);
            var maxSlippageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSlippageAbi.From(maxSlippage);

            var result = await base.CallApp(new List<object> { abiHandle, listingIdAbi, sharesPurchasedAbi, paymentMethodAbi, maxSlippageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AtomicPurchase_Transactions(ulong listingId, ulong sharesPurchased, ulong paymentMethod, ulong maxSlippage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 56, 47, 103 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var sharesPurchasedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesPurchasedAbi.From(sharesPurchased);
            var paymentMethodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodAbi.From(paymentMethod);
            var maxSlippageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSlippageAbi.From(maxSlippage);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingIdAbi, sharesPurchasedAbi, paymentMethodAbi, maxSlippageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cross-border atomic settlement (simplified)
        ///</summary>
        /// <param name="listingId"> </param>
        /// <param name="sharesPurchased"> </param>
        /// <param name="fromCurrency"> </param>
        /// <param name="toCurrency"> </param>
        /// <param name="exchangeRate"> </param>
        /// <param name="maxSlippage"> </param>
        public async Task<ulong> AtomicCrossBorderPurchase(ulong listingId, ulong sharesPurchased, ulong fromCurrency, ulong toCurrency, ulong exchangeRate, ulong maxSlippage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 7, 106, 2 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var sharesPurchasedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesPurchasedAbi.From(sharesPurchased);
            var fromCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fromCurrencyAbi.From(fromCurrency);
            var toCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); toCurrencyAbi.From(toCurrency);
            var exchangeRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); exchangeRateAbi.From(exchangeRate);
            var maxSlippageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSlippageAbi.From(maxSlippage);

            var result = await base.CallApp(new List<object> { abiHandle, listingIdAbi, sharesPurchasedAbi, fromCurrencyAbi, toCurrencyAbi, exchangeRateAbi, maxSlippageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AtomicCrossBorderPurchase_Transactions(ulong listingId, ulong sharesPurchased, ulong fromCurrency, ulong toCurrency, ulong exchangeRate, ulong maxSlippage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 7, 106, 2 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var sharesPurchasedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesPurchasedAbi.From(sharesPurchased);
            var fromCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fromCurrencyAbi.From(fromCurrency);
            var toCurrencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); toCurrencyAbi.From(toCurrency);
            var exchangeRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); exchangeRateAbi.From(exchangeRate);
            var maxSlippageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSlippageAbi.From(maxSlippage);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingIdAbi, sharesPurchasedAbi, fromCurrencyAbi, toCurrencyAbi, exchangeRateAbi, maxSlippageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get listing information (simplified)
        ///</summary>
        /// <param name="listingId"> </param>
        public async Task<string> GetListingInfo(ulong listingId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 59, 69, 119 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);

            var result = await base.CallApp(new List<object> { abiHandle, listingIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetListingInfo_Transactions(ulong listingId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 59, 69, 119 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get settlement information (simplified)
        ///</summary>
        /// <param name="settlementId"> </param>
        public async Task<string> GetSettlementInfo(ulong settlementId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 38, 238, 208 };
            var settlementIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); settlementIdAbi.From(settlementId);

            var result = await base.CallApp(new List<object> { abiHandle, settlementIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetSettlementInfo_Transactions(ulong settlementId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 38, 238, 208 };
            var settlementIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); settlementIdAbi.From(settlementId);

            return await base.MakeTransactionList(new List<object> { abiHandle, settlementIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get marketplace statistics
        ///</summary>
        public async Task<string> GetMarketplaceStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 195, 155, 164 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetMarketplaceStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 195, 155, 164 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user trading statistics (simplified)
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserStats(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 225, 43, 124 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserStats_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 225, 43, 124 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel listing (simplified)
        ///</summary>
        /// <param name="listingId"> </param>
        public async Task<string> CancelListing(ulong listingId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 121, 148, 109 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);

            var result = await base.CallApp(new List<object> { abiHandle, listingIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CancelListing_Transactions(ulong listingId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 121, 148, 109 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update listing parameters (simplified)
        ///</summary>
        /// <param name="listingId"> </param>
        /// <param name="newPricePerShare"> </param>
        /// <param name="newMinPurchase"> </param>
        /// <param name="newMaxPurchase"> </param>
        public async Task<string> UpdateListing(ulong listingId, ulong newPricePerShare, ulong newMinPurchase, ulong newMaxPurchase, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 86, 128, 141 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var newPricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPricePerShareAbi.From(newPricePerShare);
            var newMinPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMinPurchaseAbi.From(newMinPurchase);
            var newMaxPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMaxPurchaseAbi.From(newMaxPurchase);

            var result = await base.CallApp(new List<object> { abiHandle, listingIdAbi, newPricePerShareAbi, newMinPurchaseAbi, newMaxPurchaseAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateListing_Transactions(ulong listingId, ulong newPricePerShare, ulong newMinPurchase, ulong newMaxPurchase, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 86, 128, 141 };
            var listingIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listingIdAbi.From(listingId);
            var newPricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPricePerShareAbi.From(newPricePerShare);
            var newMinPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMinPurchaseAbi.From(newMinPurchase);
            var newMaxPurchaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newMaxPurchaseAbi.From(newMaxPurchase);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingIdAbi, newPricePerShareAbi, newMinPurchaseAbi, newMaxPurchaseAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause (simplified)
        ///</summary>
        public async Task<string> EmergencyPauseMarketplace(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 25, 205, 189 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyPauseMarketplace_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 25, 205, 189 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resume operations (simplified)
        ///</summary>
        public async Task<string> ResumeMarketplace(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 149, 196, 140 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ResumeMarketplace_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 149, 196, 140 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw collected fees (simplified)
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="paymentMethod"> </param>
        public async Task<string> WithdrawMarketplaceFees(ulong amount, ulong paymentMethod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 47, 211, 159 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var paymentMethodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodAbi.From(paymentMethod);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, paymentMethodAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WithdrawMarketplaceFees_Transactions(ulong amount, ulong paymentMethod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 47, 211, 159 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var paymentMethodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentMethodAbi.From(paymentMethod);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, paymentMethodAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXRvbWljTWFya2V0cGxhY2VWMiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplTWFya2V0cGxhY2UiLCJkZXNjIjoiSW5pdGlhbGl6ZSBtYXJrZXRwbGFjZSB3aXRoIGNvbmZpZ3VyYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW5BZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibENvbnRyYWN0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlRmVlUmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY0Fzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZHRBc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlTGlzdGluZyIsImRlc2MiOiJDcmVhdGUgbWFya2V0cGxhY2UgbGlzdGluZyBmb3IgZnJhY3Rpb25hbGl6ZWQgQkwgc2hhcmVzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlUGVyU2hhcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5QdXJjaGFzZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4UHVyY2hhc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRNZXRob2RzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXRvbWljUHVyY2hhc2UiLCJkZXNjIjoiQVRPTUlDIFNFVFRMRU1FTlQgLSBUaGUga2V5IGlubm92YXRpb24gKHNpbXBsaWZpZWQgaW1wbGVtZW50YXRpb24pXG5UaGlzIGVsaW1pbmF0ZXMgbWFudWFsIGludGVydmVudGlvbiBmcm9tIHRoZSBYREMgdmVyc2lvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXN0aW5nSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlc1B1cmNoYXNlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudE1ldGhvZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4U2xpcHBhZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdG9taWNDcm9zc0JvcmRlclB1cmNoYXNlIiwiZGVzYyI6IkNyb3NzLWJvcmRlciBhdG9taWMgc2V0dGxlbWVudCAoc2ltcGxpZmllZCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ0lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXNQdXJjaGFzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb21DdXJyZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9DdXJyZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhjaGFuZ2VSYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhTbGlwcGFnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldExpc3RpbmdJbmZvIiwiZGVzYyI6IkdldCBsaXN0aW5nIGluZm9ybWF0aW9uIChzaW1wbGlmaWVkKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXN0aW5nSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXR0bGVtZW50SW5mbyIsImRlc2MiOiJHZXQgc2V0dGxlbWVudCBpbmZvcm1hdGlvbiAoc2ltcGxpZmllZCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2V0dGxlbWVudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFya2V0cGxhY2VTdGF0cyIsImRlc2MiOiJHZXQgbWFya2V0cGxhY2Ugc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJTdGF0cyIsImRlc2MiOiJHZXQgdXNlciB0cmFkaW5nIHN0YXRpc3RpY3MgKHNpbXBsaWZpZWQpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsTGlzdGluZyIsImRlc2MiOiJDYW5jZWwgbGlzdGluZyAoc2ltcGxpZmllZCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ0lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTGlzdGluZyIsImRlc2MiOiJVcGRhdGUgbGlzdGluZyBwYXJhbWV0ZXJzIChzaW1wbGlmaWVkKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXN0aW5nSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1ByaWNlUGVyU2hhcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01pblB1cmNoYXNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdNYXhQdXJjaGFzZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeVBhdXNlTWFya2V0cGxhY2UiLCJkZXNjIjoiRW1lcmdlbmN5IHBhdXNlIChzaW1wbGlmaWVkKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc3VtZU1hcmtldHBsYWNlIiwiZGVzYyI6IlJlc3VtZSBvcGVyYXRpb25zIChzaW1wbGlmaWVkKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3TWFya2V0cGxhY2VGZWVzIiwiZGVzYyI6IldpdGhkcmF3IGNvbGxlY3RlZCBmZWVzIChzaW1wbGlmaWVkKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRNZXRob2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MTAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNzAsMzI3LDM1MSwzNzUsNDQ1LDQ5Myw1NjAsNjM0LDcwNCw3ODUsODI2LDg1OSw5MDBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsMzMwLDM1NCwzNzgsNDQ4LDQ5Niw1NjMsNjM3LDcwNyw3ODgsODI5LDg2Miw5MDNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4NCwxMTkzLDExOTgsMTI2MiwxMjcxLDEyODYsMTI5OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QWlaVzFsY21kbGJtTjVVR0YxYzJVaUlDSnNhWE4wYVc1blEyOTFiblJsY2lJZ0luTmxkSFJzWlcxbGJuUkRiM1Z1ZEdWeUlpQXdlREUxTVdZM1l6YzFJQ0owYjNSaGJFeHBjM1JwYm1keklpQWlkRzkwWVd4V2IyeDFiV1VpSUNKMGIzUmhiRVpsWlhORGIyeHNaV04wWldRaUlDSnRZWEpyWlhSd2JHRmpaVVpsWlZKaGRHVWlJQ0ppYkVOdmJuUnlZV04wU1dRaUlDSjFjMlJqUVhOelpYUkpaQ0lnSW5WelpIUkJjM05sZEVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCZEc5dGFXTk5ZWEpyWlhSd2JHRmpaVll5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFNENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpUbGpNR0l4TkRFZ01IaG1ZamcxWmprNU5DQXdlRE5tTXpneVpqWTNJREI0TnpRd056WmhNRElnTUhoak1UTmlORFUzTnlBd2VEVXhNalpsWldRd0lEQjROelpqTXpsaVlUUWdNSGd5TW1VeE1tSTNZeUF3ZUdJMU56azVORFprSURCNE5HWTFOamd3T0dRZ01IZzRZVEU1WTJSaVpDQXdlRE5pT1RWak5EaGpJREI0WkRReVptUXpPV1lnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbFRXRnlhMlYwY0d4aFkyVW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlV4cGMzUnBibWNvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmhkRzl0YVdOUWRYSmphR0Z6WlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaGRHOXRhV05EY205emMwSnZjbVJsY2xCMWNtTm9ZWE5sS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVEdsemRHbHVaMGx1Wm04b2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFUyVjBkR3hsYldWdWRFbHVabThvZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVFdGeWEyVjBjR3hoWTJWVGRHRjBjeWdwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlVM1JoZEhNb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTJGdVkyVnNUR2x6ZEdsdVp5aDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZNYVhOMGFXNW5LSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbVZ0WlhKblpXNWplVkJoZFhObFRXRnlhMlYwY0d4aFkyVW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljbVZ6ZFcxbFRXRnlhMlYwY0d4aFkyVW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZE5ZWEpyWlhSd2JHRmpaVVpsWlhNb2RXbHVkRFkwTEhWcGJuUTJOQ2x6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgybHVhWFJwWVd4cGVtVk5ZWEpyWlhSd2JHRmpaVjl5YjNWMFpVQXpJRzFoYVc1ZlkzSmxZWFJsVEdsemRHbHVaMTl5YjNWMFpVQTBJRzFoYVc1ZllYUnZiV2xqVUhWeVkyaGhjMlZmY205MWRHVkFOU0J0WVdsdVgyRjBiMjFwWTBOeWIzTnpRbTl5WkdWeVVIVnlZMmhoYzJWZmNtOTFkR1ZBTmlCdFlXbHVYMmRsZEV4cGMzUnBibWRKYm1adlgzSnZkWFJsUURjZ2JXRnBibDluWlhSVFpYUjBiR1Z0Wlc1MFNXNW1iMTl5YjNWMFpVQTRJRzFoYVc1ZloyVjBUV0Z5YTJWMGNHeGhZMlZUZEdGMGMxOXliM1YwWlVBNUlHMWhhVzVmWjJWMFZYTmxjbE4wWVhSelgzSnZkWFJsUURFd0lHMWhhVzVmWTJGdVkyVnNUR2x6ZEdsdVoxOXliM1YwWlVBeE1TQnRZV2x1WDNWd1pHRjBaVXhwYzNScGJtZGZjbTkxZEdWQU1USWdiV0ZwYmw5bGJXVnlaMlZ1WTNsUVlYVnpaVTFoY210bGRIQnNZV05sWDNKdmRYUmxRREV6SUcxaGFXNWZjbVZ6ZFcxbFRXRnlhMlYwY0d4aFkyVmZjbTkxZEdWQU1UUWdiV0ZwYmw5M2FYUm9aSEpoZDAxaGNtdGxkSEJzWVdObFJtVmxjMTl5YjNWMFpVQXhOUW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCZEc5dGFXTk5ZWEpyWlhSd2JHRmpaVll5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkzYVhSb1pISmhkMDFoY210bGRIQnNZV05sUm1WbGMxOXliM1YwWlVBeE5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNelFLSUNBZ0lDOHZJSGRwZEdoa2NtRjNUV0Z5YTJWMGNHeGhZMlZHWldWektHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCd1lYbHRaVzUwVFdWMGFHOWtPaUIxYVc1ME5qUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNamMwWkRZeE56STJZalkxTnpRM01EWmpOakUyTXpZMU1qQTJOalkxTmpVM016SXdOemMyT1RjME5qZzJORGN5TmpFM056WmxNakEzTXpjMU5qTTJNelkxTnpNM016WTJOelUyWXpaak56a0tJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5eVpYTjFiV1ZOWVhKclpYUndiR0ZqWlY5eWIzVjBaVUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklISmxjM1Z0WlUxaGNtdGxkSEJzWVdObEtDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY21WemRXMWxUV0Z5YTJWMGNHeGhZMlVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnRaWEpuWlc1amVWQmhkWE5sVFdGeWEyVjBjR3hoWTJWZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRXlDaUFnSUNBdkx5QmxiV1Z5WjJWdVkzbFFZWFZ6WlUxaGNtdGxkSEJzWVdObEtDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWlcxbGNtZGxibU41VUdGMWMyVk5ZWEpyWlhSd2JHRmpaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVEdsemRHbHVaMTl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURBdE1qQTFDaUFnSUNBdkx5QjFjR1JoZEdWTWFYTjBhVzVuS0FvZ0lDQWdMeThnSUNCc2FYTjBhVzVuU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JtVjNVSEpwWTJWUVpYSlRhR0Z5WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdVpYZE5hVzVRZFhKamFHRnpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J1WlhkTllYaFFkWEpqYUdGelpUb2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd016UTBZelk1TnpNM05EWTVObVUyTnpJd056VTNNRFkwTmpFM05EWTFOalF5TURjM05qazNORFk0TWpBMlpUWTFOemN5TURjd056STJPVFl6TmprMlpUWTNNakEyTVRabE5qUXlNRGN3TnpVM01qWXpOamcyTVRjek5qVXlNRFpqTmprMlpEWTVOelEzTXdvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYm1ObGJFeHBjM1JwYm1kZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3pDaUFnSUNBdkx5QmpZVzVqWld4TWFYTjBhVzVuS0d4cGMzUnBibWRKWkRvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURGbE5HTTJPVGN6TnpRMk9UWmxOamN5TURZek5qRTJaVFl6TmpVMll6WmpOalUyTkRJd056TTNOVFl6TmpNMk5UY3pOek0yTmpjMU5tTTJZemM1Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVlhObGNsTjBZWFJ6WDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5nb2dJQ0FnTHk4Z1oyVjBWWE5sY2xOMFlYUnpLSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TXpFMU5UY3pOalUzTWpJd05UTTNORFl4TnpRM016TmhNakExTkRjeU5qRTJORFk1Tm1VMk56SXdOek0zTkRZeE56UTJPVGN6TnpRMk9UWXpOek15TURZeE56WTJNVFk1Tm1NMk1UWXlObU0yTlRJd05qWTJaamN5TWpBM05UY3pOalUzTWdvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEUxaGNtdGxkSEJzWVdObFUzUmhkSE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUdkbGRFMWhjbXRsZEhCc1lXTmxVM1JoZEhNb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ETTROR1EyTVRjeU5tSTJOVGMwTnpBMll6WXhOak0yTlRJd05UTTNORFl4TnpRM016TmhNakExTkRjeU5qRTJORFk1Tm1VMk56SXdOelkyWmpaak56VTJaRFkxTWpBMk1UWmxOalF5TURZMk5qVTJOVEl3TmpRMk1UYzBOakV5TURZeE56WTJNVFk1Tm1NMk1UWXlObU0yTlFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZObGRIUnNaVzFsYm5SSmJtWnZYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJuWlhSVFpYUjBiR1Z0Wlc1MFNXNW1ieWh6WlhSMGJHVnRaVzUwU1dRNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBek5EVXpOalUzTkRjME5tTTJOVFprTmpVMlpUYzBNMkV5TURReE56UTJaalprTmprMk16SXdOek0yTlRjME56UTJZelkxTm1RMk5UWmxOelF5TURZek5tWTJaRGN3Tm1NMk5UYzBOalUyTkRJd056TTNOVFl6TmpNMk5UY3pOek0yTmpjMU5tTTJZemM1Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVEdsemRHbHVaMGx1Wm05ZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qVUtJQ0FnSUM4dklHZGxkRXhwYzNScGJtZEpibVp2S0d4cGMzUnBibWRKWkRvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURObU5HTTJPVGN6TnpRMk9UWmxOamN6WVRJd05ERTJNemMwTmprM05qWTFNakEyWkRZeE56STJZalkxTnpRM01EWmpOakUyTXpZMU1qQTJZelk1TnpNM05EWTVObVUyTnpJd056YzJPVGMwTmpneU1EWTJOelUyWXpaak1qQTJORFkxTnpRMk1UWTVObU0zTXpJd05qRTNOall4TmprMll6WXhOakkyWXpZMUNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhSdmJXbGpRM0p2YzNOQ2IzSmtaWEpRZFhKamFHRnpaVjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTUMweE5UY0tJQ0FnSUM4dklHRjBiMjFwWTBOeWIzTnpRbTl5WkdWeVVIVnlZMmhoYzJVb0NpQWdJQ0F2THlBZ0lHeHBjM1JwYm1kSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnphR0Z5WlhOUWRYSmphR0Z6WldRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1puSnZiVU4xY25KbGJtTjVPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSFJ2UTNWeWNtVnVZM2s2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWlhoamFHRnVaMlZTWVhSbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHMWhlRk5zYVhCd1lXZGxPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhSdmJXbGpUV0Z5YTJWMGNHeGhZMlZXTWlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UQXRNVFUzQ2lBZ0lDQXZMeUJoZEc5dGFXTkRjbTl6YzBKdmNtUmxjbEIxY21Ob1lYTmxLQW9nSUNBZ0x5OGdJQ0JzYVhOMGFXNW5TV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYzJoaGNtVnpVSFZ5WTJoaGMyVmtPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR1p5YjIxRGRYSnlaVzVqZVRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMGIwTjFjbkpsYm1ONU9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHVjRZMmhoYm1kbFVtRjBaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0WVhoVGJHbHdjR0ZuWlRvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdZMkZzYkhOMVlpQmhkRzl0YVdORGNtOXpjMEp2Y21SbGNsQjFjbU5vWVhObENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGMGIyMXBZMUIxY21Ob1lYTmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0TFRFeE13b2dJQ0FnTHk4Z1lYUnZiV2xqVUhWeVkyaGhjMlVvQ2lBZ0lDQXZMeUFnSUd4cGMzUnBibWRKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCemFHRnlaWE5RZFhKamFHRnpaV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY0dGNWJXVnVkRTFsZEdodlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRZWGhUYkdsd2NHRm5aVG9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGMGIyMXBZMDFoY210bGRIQnNZV05sVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTRMVEV4TXdvZ0lDQWdMeThnWVhSdmJXbGpVSFZ5WTJoaGMyVW9DaUFnSUNBdkx5QWdJR3hwYzNScGJtZEpaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6YUdGeVpYTlFkWEpqYUdGelpXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjR0Y1YldWdWRFMWxkR2h2WkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdFlYaFRiR2x3Y0dGblpUb2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWTJGc2JITjFZaUJoZEc5dGFXTlFkWEpqYUdGelpRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZNYVhOMGFXNW5YM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemN0T0RRS0lDQWdJQzh2SUdOeVpXRjBaVXhwYzNScGJtY29DaUFnSUNBdkx5QWdJR0pzU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NISnBZMlZRWlhKVGFHRnlaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0IwYjNSaGJGTm9ZWEpsY3pvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdGFXNVFkWEpqYUdGelpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRZWGhRZFhKamFHRnpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J3WVhsdFpXNTBUV1YwYUc5a2N6b2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUYwYjIxcFkwMWhjbXRsZEhCc1lXTmxWaklnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjdE9EUUtJQ0FnSUM4dklHTnlaV0YwWlV4cGMzUnBibWNvQ2lBZ0lDQXZMeUFnSUdKc1NXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjSEpwWTJWUVpYSlRhR0Z5WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMGIzUmhiRk5vWVhKbGN6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRhVzVRZFhKamFHRnpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0WVhoUWRYSmphR0Z6WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCd1lYbHRaVzUwVFdWMGFHOWtjem9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZNYVhOMGFXNW5DaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHVhWFJwWVd4cGVtVk5ZWEpyWlhSd2JHRmpaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TFRJNUNpQWdJQ0F2THlCcGJtbDBhV0ZzYVhwbFRXRnlhMlYwY0d4aFkyVW9DaUFnSUNBdkx5QWdJR0ZrYldsdVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaWJFTnZiblJ5WVdOMFNXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiV0Z5YTJWMGNHeGhZMlZHWldWU1lYUmxPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSFZ6WkdOQmMzTmxkRWxrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhWelpIUkJjM05sZEVsa09pQjFhVzUwTmpRS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWFJ2YldsalRXRnlhMlYwY0d4aFkyVldNaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak10TWprS0lDQWdJQzh2SUdsdWFYUnBZV3hwZW1WTllYSnJaWFJ3YkdGalpTZ0tJQ0FnSUM4dklDQWdZV1J0YVc1QlpHUnlaWE56T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUdKc1EyOXVkSEpoWTNSSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRZWEpyWlhSd2JHRmpaVVpsWlZKaGRHVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkWE5rWTBGemMyVjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZFhOa2RFRnpjMlYwU1dRNklIVnBiblEyTkFvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdhVzVwZEdsaGJHbDZaVTFoY210bGRIQnNZV05sQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUYwYjIxcFkwMWhjbXRsZEhCc1lXTmxWaklnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFYUnZiV2xqVFdGeWEyVjBjR3hoWTJWV01pNXBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlVvWVdSdGFXNUJaR1J5WlhOek9pQmllWFJsY3l3Z1lteERiMjUwY21GamRFbGtPaUIxYVc1ME5qUXNJRzFoY210bGRIQnNZV05sUm1WbFVtRjBaVG9nZFdsdWREWTBMQ0IxYzJSalFYTnpaWFJKWkRvZ2RXbHVkRFkwTENCMWMyUjBRWE56WlhSSlpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0thVzVwZEdsaGJHbDZaVTFoY210bGRIQnNZV05sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekxUSTVDaUFnSUNBdkx5QnBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlVvQ2lBZ0lDQXZMeUFnSUdGa2JXbHVRV1JrY21WemN6b2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQmliRU52Ym5SeVlXTjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYldGeWEyVjBjR3hoWTJWR1pXVlNZWFJsT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhWelpHTkJjM05sZEVsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lIVnpaSFJCYzNObGRFbGtPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUExSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCc2FYTjBhVzVuUTI5MWJuUmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW14cGMzUnBibWREYjNWdWRHVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11YkdsemRHbHVaME52ZFc1MFpYSXVhR0Z6Vm1Gc2RXVXBJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQnBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdiR2x6ZEdsdVowTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXhwYzNScGJtZERiM1Z1ZEdWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBhR2x6TG14cGMzUnBibWREYjNWdWRHVnlMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BwYm1sMGFXRnNhWHBsVFdGeWEyVjBjR3hoWTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhObGRIUnNaVzFsYm5SRGIzVnVkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMyVjBkR3hsYldWdWRFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXpaWFIwYkdWdFpXNTBRMjkxYm5SbGNpNW9ZWE5XWVd4MVpTa2dld29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHbHVhWFJwWVd4cGVtVk5ZWEpyWlhSd2JHRmpaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QnpaWFIwYkdWdFpXNTBRMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzJWMGRHeGxiV1Z1ZEVOdmRXNTBaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVjMlYwZEd4bGJXVnVkRU52ZFc1MFpYSXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbWx1YVhScFlXeHBlbVZOWVhKclpYUndiR0ZqWlY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnZEc5MFlXeE1hWE4wYVc1bmN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJ2ZEdGc1RHbHpkR2x1WjNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHbG1JQ2doZEdocGN5NTBiM1JoYkV4cGMzUnBibWR6TG1oaGMxWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYVc1cGRHbGhiR2w2WlUxaGNtdGxkSEJzWVdObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUhSdmRHRnNUR2x6ZEdsdVozTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNUR2x6ZEdsdVozTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hNYVhOMGFXNW5jeTUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYVc1cGRHbGhiR2w2WlUxaGNtdGxkSEJzWVdObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCMGIzUmhiRlp2YkhWdFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1ZtOXNkVzFsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWRHOTBZV3hXYjJ4MWJXVXVhR0Z6Vm1Gc2RXVXBJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQnBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdkRzkwWVd4V2IyeDFiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzVm05c2RXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVm05c2RXMWxMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BwYm1sMGFXRnNhWHBsVFdGeWEyVjBjR3hoWTJWZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhSdmRHRnNSbVZsYzBOdmJHeGxZM1JsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnZkR0ZzUm1WbGMwTnZiR3hsWTNSbFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMblJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaQzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR2x1YVhScFlXeHBlbVZOWVhKclpYUndiR0ZqWlY5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEdaV1Z6UTI5c2JHVmpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkVabFpYTkRiMnhzWldOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0xuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlZmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWR1pXVlNZWFJsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SUVKaGMybHpJSEJ2YVc1MGN5QW9NVEF3SUQwZ01TVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJXRnlhMlYwY0d4aFkyVkdaV1ZTWVhSbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXViV0Z5YTJWMGNHeGhZMlZHWldWU1lYUmxMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dhVzVwZEdsaGJHbDZaVTFoY210bGRIQnNZV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWR1pXVlNZWFJsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SUVKaGMybHpJSEJ2YVc1MGN5QW9NVEF3SUQwZ01TVXBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnRZWEpyWlhSd2JHRmpaVVpsWlZKaGRHVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSFJvYVhNdWJXRnlhMlYwY0d4aFkyVkdaV1ZTWVhSbExuWmhiSFZsSUQwZ2JXRnlhMlYwY0d4aFkyVkdaV1ZTWVhSbENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlZmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWW14RGIyNTBjbUZqZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlZbXhEYjI1MGNtRmpkRWxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVlteERiMjUwY21GamRFbGtMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dhVzVwZEdsaGJHbDZaVTFoY210bGRIQnNZV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWW14RGIyNTBjbUZqZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0ppYkVOdmJuUnlZV04wU1dRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklIUm9hWE11WW14RGIyNTBjbUZqZEVsa0xuWmhiSFZsSUQwZ1lteERiMjUwY21GamRFbGtDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BwYm1sMGFXRnNhWHBsVFdGeWEyVjBjR3hoWTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2RYTmtZMEZ6YzJWMFNXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0oxYzJSalFYTnpaWFJKWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxuVnpaR05CYzNObGRFbGtMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dhVzVwZEdsaGJHbDZaVTFoY210bGRIQnNZV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnZFhOa1kwRnpjMlYwU1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblZ6WkdOQmMzTmxkRWxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCMGFHbHpMblZ6WkdOQmMzTmxkRWxrTG5aaGJIVmxJRDBnZFhOa1kwRnpjMlYwU1dRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtbHVhWFJwWVd4cGVtVk5ZWEpyWlhSd2JHRmpaVjloWm5SbGNsOXBabDlsYkhObFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIxYzJSMFFYTnpaWFJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjFjMlIwUVhOelpYUkpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5WelpIUkJjM05sZEVsa0xtaGhjMVpoYkhWbEtTQjdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ2FXNXBkR2xoYkdsNlpVMWhjbXRsZEhCc1lXTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdkWE5rZEVGemMyVjBTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjFjMlIwUVhOelpYUkpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnZEdocGN5NTFjMlIwUVhOelpYUkpaQzUyWVd4MVpTQTlJSFZ6WkhSQmMzTmxkRWxrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwcGJtbDBhV0ZzYVhwbFRXRnlhMlYwY0d4aFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdaVzFsY21kbGJtTjVVR0YxYzJVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxiV1Z5WjJWdVkzbFFZWFZ6WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxtVnRaWEpuWlc1amVWQmhkWE5sTG1oaGMxWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYVc1cGRHbGhiR2w2WlUxaGNtdGxkSEJzWVdObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1pXMWxjbWRsYm1ONVVHRjFjMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnRaWEpuWlc1amVWQmhkWE5sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCMGFHbHpMbVZ0WlhKblpXNWplVkJoZFhObExuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHBibWwwYVdGc2FYcGxUV0Z5YTJWMGNHeGhZMlZmWVdaMFpYSmZhV1pmWld4elpVQXlNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnY21WMGRYSnVJR0JCZEc5dGFXTWdUV0Z5YTJWMGNHeGhZMlVnVmpJZ2FXNXBkR2xoYkdsNlpXUWdkMmwwYUNCaFpHMXBiaUJoYm1RZ1ptVmxJR052Ym1acFozVnlZWFJwYjI1Z0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGMGIyMXBZeUJOWVhKclpYUndiR0ZqWlNCV01pQnBibWwwYVdGc2FYcGxaQ0IzYVhSb0lHRmtiV2x1SUdGdVpDQm1aV1VnWTI5dVptbG5kWEpoZEdsdmJpSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRWFJ2YldsalRXRnlhMlYwY0d4aFkyVldNaTVqY21WaGRHVk1hWE4wYVc1bktHSnNTV1E2SUhWcGJuUTJOQ3dnY0hKcFkyVlFaWEpUYUdGeVpUb2dkV2x1ZERZMExDQjBiM1JoYkZOb1lYSmxjem9nZFdsdWREWTBMQ0J0YVc1UWRYSmphR0Z6WlRvZ2RXbHVkRFkwTENCdFlYaFFkWEpqYUdGelpUb2dkV2x1ZERZMExDQndZWGx0Wlc1MFRXVjBhRzlrY3pvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtTnlaV0YwWlV4cGMzUnBibWM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjdE9EUUtJQ0FnSUM4dklHTnlaV0YwWlV4cGMzUnBibWNvQ2lBZ0lDQXZMeUFnSUdKc1NXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjSEpwWTJWUVpYSlRhR0Z5WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMGIzUmhiRk5vWVhKbGN6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnRhVzVRZFhKamFHRnpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J0WVhoUWRYSmphR0Z6WlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCd1lYbHRaVzUwVFdWMGFHOWtjem9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTmlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z2JHbHpkR2x1WjBOdmRXNTBaWElnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc2FYTjBhVzVuUTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG14cGMzUnBibWREYjNWdWRHVnlMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dZM0psWVhSbFRHbHpkR2x1WjE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJzYVhOMGFXNW5RMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYkdsemRHbHVaME52ZFc1MFpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJSFJvYVhNdWJHbHpkR2x1WjBOdmRXNTBaWEl1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ21OeVpXRjBaVXhwYzNScGJtZGZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklIUnZkR0ZzVEdsemRHbHVaM01nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRXhwYzNScGJtZHpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11ZEc5MFlXeE1hWE4wYVc1bmN5NW9ZWE5XWVd4MVpTa2dld29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHTnlaV0YwWlV4cGMzUnBibWRmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdkRzkwWVd4TWFYTjBhVzVuY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkRzkwWVd4TWFYTjBhVzVuY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFeHBjM1JwYm1kekxuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGpjbVZoZEdWTWFYTjBhVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJzYVhOMGFXNW5RMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXhwYzNScGJtZERiM1Z1ZEdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z2RHaHBjeTVzYVhOMGFXNW5RMjkxYm5SbGNpNTJZV3gxWlNBOUlIUm9hWE11YkdsemRHbHVaME52ZFc1MFpYSXVkbUZzZFdVZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUd4cGMzUnBibWREYjNWdWRHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc2FYTjBhVzVuUTI5MWJuUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TlFvZ0lDQWdMeThnZEdocGN5NXNhWE4wYVc1blEyOTFiblJsY2k1MllXeDFaU0E5SUhSb2FYTXViR2x6ZEdsdVowTnZkVzUwWlhJdWRtRnNkV1VnS3lBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHeHBjM1JwYm1kRGIzVnVkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJHbHpkR2x1WjBOdmRXNTBaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSFJ2ZEdGc1RHbHpkR2x1WjNNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiM1JoYkV4cGMzUnBibWR6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkV4cGMzUnBibWR6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkV4cGMzUnBibWR6TG5aaGJIVmxJQ3NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QjBiM1JoYkV4cGMzUnBibWR6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiM1JoYkV4cGMzUnBibWR6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1RHbHpkR2x1WjNNdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1RHbHpkR2x1WjNNdWRtRnNkV1VnS3lBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkMHhwYzNScGJtZEpaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCZEc5dGFXTk5ZWEpyWlhSd2JHRmpaVll5TG1GMGIyMXBZMUIxY21Ob1lYTmxLR3hwYzNScGJtZEpaRG9nZFdsdWREWTBMQ0J6YUdGeVpYTlFkWEpqYUdGelpXUTZJSFZwYm5RMk5Dd2djR0Y1YldWdWRFMWxkR2h2WkRvZ2RXbHVkRFkwTENCdFlYaFRiR2x3Y0dGblpUb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbUYwYjIxcFkxQjFjbU5vWVhObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPQzB4TVRNS0lDQWdJQzh2SUdGMGIyMXBZMUIxY21Ob1lYTmxLQW9nSUNBZ0x5OGdJQ0JzYVhOMGFXNW5TV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYzJoaGNtVnpVSFZ5WTJoaGMyVmtPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEJoZVcxbGJuUk5aWFJvYjJRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXRjRVMnhwY0hCaFoyVTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhObGRIUnNaVzFsYm5SRGIzVnVkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMyVjBkR3hsYldWdWRFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVjMlYwZEd4bGJXVnVkRU52ZFc1MFpYSXVhR0Z6Vm1Gc2RXVXBJSHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmhkRzl0YVdOUWRYSmphR0Z6WlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwUTI5MWJuUmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMyVjBkR3hsYldWdWRFTnZkVzUwWlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTJDaUFnSUNBdkx5QjBhR2x6TG5ObGRIUnNaVzFsYm5SRGIzVnVkR1Z5TG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwaGRHOXRhV05RZFhKamFHRnpaVjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdkRzkwWVd4V2IyeDFiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRlp2YkhWdFpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVGtLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTUwYjNSaGJGWnZiSFZ0WlM1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdGMGIyMXBZMUIxY21Ob1lYTmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklIUnZkR0ZzVm05c2RXMWxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRlp2YkhWdFpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hXYjJ4MWJXVXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbUYwYjIxcFkxQjFjbU5vWVhObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMGIzUmhiRVpsWlhORGIyeHNaV04wWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkVabFpYTkRiMnhzWldOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11ZEc5MFlXeEdaV1Z6UTI5c2JHVmpkR1ZrTG1oaGMxWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWVhSdmJXbGpVSFZ5WTJoaGMyVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjNSaGJFWmxaWE5EYjJ4c1pXTjBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaQzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWVhSdmJXbGpVSFZ5WTJoaGMyVmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVVpsWlZKaGRHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0x5OGdRbUZ6YVhNZ2NHOXBiblJ6SUNneE1EQWdQU0F4SlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p0WVhKclpYUndiR0ZqWlVabFpWSmhkR1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdWJXRnlhMlYwY0d4aFkyVkdaV1ZTWVhSbExtaGhjMVpoYkhWbEtTQjdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1lYUnZiV2xqVUhWeVkyaGhjMlZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sUm1WbFVtRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tTQXZMeUJDWVhOcGN5QndiMmx1ZEhNZ0tERXdNQ0E5SURFbEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJXRnlhMlYwY0d4aFkyVkdaV1ZTWVhSbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdkR2hwY3k1dFlYSnJaWFJ3YkdGalpVWmxaVkpoZEdVdWRtRnNkV1VnUFNBeE1EQWdMeThnUkdWbVlYVnNkQ0F4SlFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtRjBiMjFwWTFCMWNtTm9ZWE5sWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwUTI5MWJuUmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5ObGRIUnNaVzFsYm5SRGIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUhSb2FYTXVjMlYwZEd4bGJXVnVkRU52ZFc1MFpYSXVkbUZzZFdVZ1BTQjBhR2x6TG5ObGRIUnNaVzFsYm5SRGIzVnVkR1Z5TG5aaGJIVmxJQ3NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QnpaWFIwYkdWdFpXNTBRMjkxYm5SbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzJWMGRHeGxiV1Z1ZEVOdmRXNTBaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeUNpQWdJQ0F2THlCMGFHbHpMbk5sZEhSc1pXMWxiblJEYjNWdWRHVnlMblpoYkhWbElEMGdkR2hwY3k1elpYUjBiR1Z0Wlc1MFEyOTFiblJsY2k1MllXeDFaU0FySURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2MyVjBkR3hsYldWdWRFTnZkVzUwWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpaWFIwYkdWdFpXNTBRMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmpiMjV6ZENCMGIzUmhiRkJ5YVdObE9pQjFhVzUwTmpRZ1BTQnphR0Z5WlhOUWRYSmphR0Z6WldRZ0tpQndjbWxqWlZCbGNsTm9ZWEpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpZS0lDQWdJQzh2SUdOdmJuTjBJSEJ5YVdObFVHVnlVMmhoY21VNklIVnBiblEyTkNBOUlESXdNREF3TURBZ0x5OGdNaUJCVEVkUElIQmxjaUJ6YUdGeVpRb2dJQ0FnY0hWemFHbHVkQ0F5TURBd01EQXdJQzh2SURJd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdOdmJuTjBJSFJ2ZEdGc1VISnBZMlU2SUhWcGJuUTJOQ0E5SUhOb1lYSmxjMUIxY21Ob1lYTmxaQ0FxSUhCeWFXTmxVR1Z5VTJoaGNtVUtJQ0FnSUNvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHTnZibk4wSUdabFpVRnRiM1Z1ZERvZ2RXbHVkRFkwSUQwZ2RHOTBZV3hRY21salpTQXZJREV3TUNBdkx5QlRhVzF3YkdVZ01TVWdabVZsSUdOaGJHTjFiR0YwYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUIwYjNSaGJGWnZiSFZ0WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzVm05c2RXMWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREVLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hXYjJ4MWJXVXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNWbTlzZFcxbExuWmhiSFZsSUNzZ2RHOTBZV3hRY21salpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdkRzkwWVd4V2IyeDFiV1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzVm05c2RXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZadmJIVnRaUzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hXYjJ4MWJXVXVkbUZzZFdVZ0t5QjBiM1JoYkZCeWFXTmxDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSFJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmRHRnNSbVZsYzBOdmJHeGxZM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JtVmxjME52Ykd4bFkzUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHWldWelEyOXNiR1ZqZEdWa0xuWmhiSFZsSUNzZ1ptVmxRVzF2ZFc1MENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEc5MFlXeEdaV1Z6UTI5c2JHVmpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkVabFpYTkRiMnhzWldOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYUnZiV2xqWDIxaGNtdGxkSEJzWVdObFgzWXlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF5Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUm1WbGMwTnZiR3hsWTNSbFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeEdaV1Z6UTI5c2JHVmpkR1ZrTG5aaGJIVmxJQ3NnWm1WbFFXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGRIUnNaVzFsYm5SSlpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJkRzl0YVdOTllYSnJaWFJ3YkdGalpWWXlMbUYwYjIxcFkwTnliM056UW05eVpHVnlVSFZ5WTJoaGMyVW9iR2x6ZEdsdVowbGtPaUIxYVc1ME5qUXNJSE5vWVhKbGMxQjFjbU5vWVhObFpEb2dkV2x1ZERZMExDQm1jbTl0UTNWeWNtVnVZM2s2SUhWcGJuUTJOQ3dnZEc5RGRYSnlaVzVqZVRvZ2RXbHVkRFkwTENCbGVHTm9ZVzVuWlZKaGRHVTZJSFZwYm5RMk5Dd2diV0Y0VTJ4cGNIQmhaMlU2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwaGRHOXRhV05EY205emMwSnZjbVJsY2xCMWNtTm9ZWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1DMHhOVGNLSUNBZ0lDOHZJR0YwYjIxcFkwTnliM056UW05eVpHVnlVSFZ5WTJoaGMyVW9DaUFnSUNBdkx5QWdJR3hwYzNScGJtZEpaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6YUdGeVpYTlFkWEpqYUdGelpXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdabkp2YlVOMWNuSmxibU41T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhSdlEzVnljbVZ1WTNrNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1pYaGphR0Z1WjJWU1lYUmxPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJRzFoZUZOc2FYQndZV2RsT2lCMWFXNTBOalFLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQndjbTkwYnlBMklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1GMGIyMXBZMUIxY21Ob1lYTmxLR3hwYzNScGJtZEpaQ3dnYzJoaGNtVnpVSFZ5WTJoaGMyVmtMQ0F5TENCdFlYaFRiR2x3Y0dGblpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJR0YwYjIxcFkxQjFjbU5vWVhObENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRjBiMjFwWTAxaGNtdGxkSEJzWVdObFZqSXVaVzFsY21kbGJtTjVVR0YxYzJWTllYSnJaWFJ3YkdGalpTZ3BJQzArSUdKNWRHVnpPZ3BsYldWeVoyVnVZM2xRWVhWelpVMWhjbXRsZEhCc1lXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xRWVhWelpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ0WlhKblpXNWplVkJoZFhObElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbVZ0WlhKblpXNWplVkJoZFhObExtaGhjMVpoYkhWbEtTQjdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1pXMWxjbWRsYm1ONVVHRjFjMlZOWVhKclpYUndiR0ZqWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWlcxbGNtZGxibU41VUdGMWMyVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WdFpYSm5aVzVqZVZCaGRYTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TkFvZ0lDQWdMeThnZEdocGN5NWxiV1Z5WjJWdVkzbFFZWFZ6WlM1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1pXMWxjbWRsYm1ONVVHRjFjMlZOWVhKclpYUndiR0ZqWlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWFJ2YldsalgyMWhjbXRsZEhCc1lXTmxYM1l5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdWdFpYSm5aVzVqZVZCaGRYTmxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGJXVnlaMlZ1WTNsUVlYVnpaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhkRzl0YVdOZmJXRnlhMlYwY0d4aFkyVmZkakl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRZS0lDQWdJQzh2SUhSb2FYTXVaVzFsY21kbGJtTjVVR0YxYzJVdWRtRnNkV1VnUFNBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklISmxkSFZ5YmlCZ1RXRnlhMlYwY0d4aFkyVWdjR0YxYzJWa0lHWnZjaUJsYldWeVoyVnVZM2xnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJazFoY210bGRIQnNZV05sSUhCaGRYTmxaQ0JtYjNJZ1pXMWxjbWRsYm1ONUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJkRzl0YVdOTllYSnJaWFJ3YkdGalpWWXlMbkpsYzNWdFpVMWhjbXRsZEhCc1lXTmxLQ2tnTFQ0Z1lubDBaWE02Q25KbGMzVnRaVTFoY210bGRIQnNZV05sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkYwYjIxcFkxOXRZWEpyWlhSd2JHRmpaVjkyTWk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCbGJXVnlaMlZ1WTNsUVlYVnpaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WdFpYSm5aVzVqZVZCaGRYTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TkFvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1WdFpYSm5aVzVqZVZCaGRYTmxMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2djbVZ6ZFcxbFRXRnlhMlYwY0d4aFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhSdmJXbGpYMjFoY210bGRIQnNZV05sWDNZeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHVnRaWEpuWlc1amVWQmhkWE5sSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxiV1Z5WjJWdVkzbFFZWFZ6WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloZEc5dGFXTmZiV0Z5YTJWMGNHeGhZMlZmZGpJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qVUtJQ0FnSUM4dklIUm9hWE11WlcxbGNtZGxibU41VUdGMWMyVXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbkpsYzNWdFpVMWhjbXRsZEhCc1lXTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGRHOXRhV05mYldGeWEyVjBjR3hoWTJWZmRqSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdaVzFsY21kbGJtTjVVR0YxYzJVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVZ0WlhKblpXNWplVkJoZFhObElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGMGIyMXBZMTl0WVhKclpYUndiR0ZqWlY5Mk1pOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOd29nSUNBZ0x5OGdkR2hwY3k1bGJXVnlaMlZ1WTNsUVlYVnpaUzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRjBiMjFwWTE5dFlYSnJaWFJ3YkdGalpWOTJNaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5T0FvZ0lDQWdMeThnY21WMGRYSnVJR0JOWVhKclpYUndiR0ZqWlNCdmNHVnlZWFJwYjI1eklISmxjM1Z0WldSZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWsxaGNtdGxkSEJzWVdObElHOXdaWEpoZEdsdmJuTWdjbVZ6ZFcxbFpDSUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFGa0pnc09aVzFsY21kbGJtTjVVR0YxYzJVT2JHbHpkR2x1WjBOdmRXNTBaWElSYzJWMGRHeGxiV1Z1ZEVOdmRXNTBaWElFRlI5OGRRMTBiM1JoYkV4cGMzUnBibWR6QzNSdmRHRnNWbTlzZFcxbEVuUnZkR0ZzUm1WbGMwTnZiR3hsWTNSbFpCSnRZWEpyWlhSd2JHRmpaVVpsWlZKaGRHVU1ZbXhEYjI1MGNtRmpkRWxrQzNWelpHTkJjM05sZEVsa0MzVnpaSFJCYzNObGRFbGtNUnRCQXdpQ0RRVHB3TEZCQlB1RitaUUVQemd2WndSMEIyb0NCTUU3UlhjRVVTYnUwQVIydzV1a0JDTGhLM3dFdFhtVWJRUlBWb0NOQklvWnpiMEVPNVhFakFUVUw5T2ZOaG9BamcwQ2VBSlBBaTRDQlFHMEFXNEJKQURoQUxFQWF3QlRBRHNBQWlKRE1Sa1VSREVZUklBdEZSOThkUUFuVFdGeWEyVjBjR3hoWTJVZ1ptVmxjeUIzYVhSb1pISmhkMjRnYzNWalkyVnpjMloxYkd4NXNDTkRNUmtVUkRFWVJJZ0VDMGtWRmxjR0FreFFLMHhRc0NORE1Sa1VSREVZUklnRHdra1ZGbGNHQWt4UUsweFFzQ05ETVJrVVJERVlSSUE2RlI5OGRRQTBUR2x6ZEdsdVp5QjFjR1JoZEdWa0lIZHBkR2dnYm1WM0lIQnlhV05wYm1jZ1lXNWtJSEIxY21Ob1lYTmxJR3hwYldsMGM3QWpRekVaRkVReEdFU0FKQlVmZkhVQUhreHBjM1JwYm1jZ1kyRnVZMlZzYkdWa0lITjFZMk5sYzNObWRXeHNlYkFqUXpFWkZFUXhHRVNBTnhVZmZIVUFNVlZ6WlhJZ1UzUmhkSE02SUZSeVlXUnBibWNnYzNSaGRHbHpkR2xqY3lCaGRtRnBiR0ZpYkdVZ1ptOXlJSFZ6WlhLd0kwTXhHUlJFTVJoRWdENFZIM3gxQURoTllYSnJaWFJ3YkdGalpTQlRkR0YwY3pvZ1ZISmhaR2x1WnlCMmIyeDFiV1VnWVc1a0lHWmxaU0JrWVhSaElHRjJZV2xzWVdKc1piQWpRekVaRkVReEdFU0FPaFVmZkhVQU5GTmxkSFJzWlcxbGJuUTZJRUYwYjIxcFl5QnpaWFIwYkdWdFpXNTBJR052YlhCc1pYUmxaQ0J6ZFdOalpYTnpablZzYkhtd0kwTXhHUlJFTVJoRWdFVVZIM3gxQUQ5TWFYTjBhVzVuT2lCQlkzUnBkbVVnYldGeWEyVjBjR3hoWTJVZ2JHbHpkR2x1WnlCM2FYUm9JR1oxYkd3Z1pHVjBZV2xzY3lCaGRtRnBiR0ZpYkdXd0kwTXhHUlJFTVJoRU5ob0JGellhQWhjMkdnTVhOaG9FRnpZYUJSYzJHZ1lYaUFIcEZpdE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQXhjMkdnUVhpQUZsRml0TVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Z6WWFBeGMyR2dRWE5ob0ZGellhQmhlSUFRZ1dLMHhRc0NORE1Sa1VSREVZUkRZYUFWY0NBRFlhQWhjMkdnTVhOaG9FRnpZYUJSZUlBQmxKRlJaWEJnSk1VQ3RNVUxBalF6RVpRUDFWTVJnVVJDTkRpZ1VCSWlsbFJRRkFBQU1wSW1jaUttVkZBVUFBQXlvaVp5SW5CR1ZGQVVBQUJDY0VJbWNpSndWbFJRRkFBQVFuQlNKbklpY0daVVVCUUFBRUp3WWlaeUluQjJWRkFVQUFCU2NIaS8xbklpY0laVVVCUUFBRkp3aUwvR2NpSndsbFJRRkFBQVVuQ1l2K1p5SW5DbVZGQVVBQUJTY0tpLzluSWlobFJRRkFBQU1vSW1lQVFrRjBiMjFwWXlCTllYSnJaWFJ3YkdGalpTQldNaUJwYm1sMGFXRnNhWHBsWkNCM2FYUm9JR0ZrYldsdUlHRnVaQ0JtWldVZ1kyOXVabWxuZFhKaGRHbHZib21LQmdFaUtXVkZBVUFBQXlraVp5SW5CR1ZGQVVBQUJDY0VJbWNpS1dWRUl3Z3BUR2NpS1dWRUlpY0VaVVFqQ0NjRVRHZUppZ1FCSWlwbFJRRkFBQU1xSW1jaUp3VmxSUUZBQUFRbkJTSm5JaWNHWlVVQlFBQUVKd1lpWnlJbkIyVkZBVUFBQkNjSEpHY2lLbVZFSXdncVRHY2lLbVZFaS8yQmdJbDZDMGtrQ2lJbkJXVkVUd0lJSndWTVp5SW5CbVZFQ0NjR1RHZUppZ1lCaS9xTCs0RUNpLytJLzQrSklpaGxSUUZBQUFNb0ltY29JMmVBSUUxaGNtdGxkSEJzWVdObElIQmhkWE5sWkNCbWIzSWdaVzFsY21kbGJtTjVpU0lvWlVVQlFBQURLQ0puS0NKbmdCNU5ZWEpyWlhSd2JHRmpaU0J2Y0dWeVlYUnBiMjV6SUhKbGMzVnRaV1NKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
