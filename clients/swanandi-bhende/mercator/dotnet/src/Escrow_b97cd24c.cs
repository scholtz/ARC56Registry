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

namespace Arc56.Generated.swanandi_bhende.mercator.Escrow_b97cd24c
{


    //
    // Escrow settlement tracking with fee splitting for x402 micropayments.
    //    
    //    State:
    //        registry_app_id: Global reference to AgentRegistry app (UInt64).
    //        fee_config_app_id: Global reference to FeeConfig app (UInt64).
    //        insight_listing_app_id: Global reference to InsightListing app (UInt64).
    //        unlocked_listings: BoxMap(listing_id => UnlockRecord) recording buyer access + payment details.
    //    
    //    Purpose: Immutable on-chain proof that buyer paid for and accessed specific listing,
    //    with guaranteed fee split between seller and platform treasury.
    //    
    //
    public class EscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UnlockRecord : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public Algorand.Address Seller { get; set; }

                public bool Unlocked { get; set; }

                public ulong PaymentAmountMicroUsdc { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUnlocked.From(Unlocked);
                    ret.AddRange(vUnlocked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaymentAmountMicroUsdc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPaymentAmountMicroUsdc.From(PaymentAmountMicroUsdc);
                    ret.AddRange(vPaymentAmountMicroUsdc.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UnlockRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UnlockRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUnlocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnlocked = vUnlocked.ToValue();
                    if (valueUnlocked is bool vUnlockedValue) { ret.Unlocked = vUnlockedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaymentAmountMicroUsdc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPaymentAmountMicroUsdc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaymentAmountMicroUsdc = vPaymentAmountMicroUsdc.ToValue();
                    if (valuePaymentAmountMicroUsdc is ulong vPaymentAmountMicroUsdcValue) { ret.PaymentAmountMicroUsdc = vPaymentAmountMicroUsdcValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UnlockRecord);
                }
                public bool Equals(UnlockRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UnlockRecord left, UnlockRecord right)
                {
                    return EqualityComparer<UnlockRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(UnlockRecord left, UnlockRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fee_config_app_id"> </param>
        /// <param name="insight_listing_app_id"> </param>
        /// <param name="registry_app_id"> </param>
        public async Task Create(ulong fee_config_app_id, ulong insight_listing_app_id, ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 253, 164, 210 };
            var fee_config_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_config_app_idAbi.From(fee_config_app_id);
            var insight_listing_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); insight_listing_app_idAbi.From(insight_listing_app_id);
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, fee_config_app_idAbi, insight_listing_app_idAbi, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong fee_config_app_id, ulong insight_listing_app_id, ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 253, 164, 210 };
            var fee_config_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_config_app_idAbi.From(fee_config_app_id);
            var insight_listing_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); insight_listing_app_idAbi.From(insight_listing_app_id);
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, fee_config_app_idAbi, insight_listing_app_idAbi, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fee_config_app_id"> </param>
        /// <param name="insight_listing_app_id"> </param>
        /// <param name="registry_app_id"> </param>
        public async Task SetAppIds(ulong fee_config_app_id, ulong insight_listing_app_id, ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 7, 67, 115 };
            var fee_config_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_config_app_idAbi.From(fee_config_app_id);
            var insight_listing_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); insight_listing_app_idAbi.From(insight_listing_app_id);
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, fee_config_app_idAbi, insight_listing_app_idAbi, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAppIds_Transactions(ulong fee_config_app_id, ulong insight_listing_app_id, ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 7, 67, 115 };
            var fee_config_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_config_app_idAbi.From(fee_config_app_id);
            var insight_listing_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); insight_listing_app_idAbi.From(insight_listing_app_id);
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, fee_config_app_idAbi, insight_listing_app_idAbi, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record buyer access and split payment after x402 payment confirmed on-chain.
        ///Purpose: Post-payment gate with fee splitting. Called by post_payment_flow after x402  tx confirmed and indexed. Atomically validates caller is buyer and splits payment.
        ///Actions: 1. Assert tx.sender == buyer (confirms caller is buyer's wallet). 2. Check buyer registered in AgentRegistry (if set). 3. Call FeeConfig.calculate_fee to determine seller payout and treasury fee. 4. Build and submit two inner itxn.AssetTransfer transactions atomically:    a. Transfer seller_payout_micro_usdc to seller wallet    b. Transfer fee_micro_usdc to treasury wallet 5. Call FeeConfig.record_fee_collected to update revenue counter. 6. Call InsightListing to mark listing as purchased by buyer. 7. Store UnlockRecord in boxes: {buyer, seller, unlocked=True, amount}. 8. Return True to signal success.
        ///</summary>
        /// <param name="buyer">Algorand wallet address of the buyer (must match tx sender). </param>
        /// <param name="seller">Algorand wallet address of the insight creator. </param>
        /// <param name="listing_id">InsightListing ID that buyer paid for. </param>
        /// <param name="amount_micro_usdc">Total payment amount in microUSDC before fee split. </param>
        /// <param name="usdc_asset_id">USDC ASA ID for inner transfers. </param>
        /// <param name="treasury_address">Treasury wallet to receive platform fee. </param>
        public async Task<bool> ReleaseAfterPayment(Algorand.Address buyer, Algorand.Address seller, ulong listing_id, ulong amount_micro_usdc, ulong usdc_asset_id, Algorand.Address treasury_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 48, 17, 73 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);
            var treasury_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasury_addressAbi.From(treasury_address);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi, sellerAbi, listing_idAbi, amount_micro_usdcAbi, usdc_asset_idAbi, treasury_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReleaseAfterPayment_Transactions(Algorand.Address buyer, Algorand.Address seller, ulong listing_id, ulong amount_micro_usdc, ulong usdc_asset_id, Algorand.Address treasury_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 48, 17, 73 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);
            var usdc_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_asset_idAbi.From(usdc_asset_id);
            var treasury_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasury_addressAbi.From(treasury_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi, sellerAbi, listing_idAbi, amount_micro_usdcAbi, usdc_asset_idAbi, treasury_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93IiwiZGVzYyI6IkVzY3JvdyBzZXR0bGVtZW50IHRyYWNraW5nIHdpdGggZmVlIHNwbGl0dGluZyBmb3IgeDQwMiBtaWNyb3BheW1lbnRzLlxuICAgIFxuICAgIFN0YXRlOlxuICAgICAgICByZWdpc3RyeV9hcHBfaWQ6IEdsb2JhbCByZWZlcmVuY2UgdG8gQWdlbnRSZWdpc3RyeSBhcHAgKFVJbnQ2NCkuXG4gICAgICAgIGZlZV9jb25maWdfYXBwX2lkOiBHbG9iYWwgcmVmZXJlbmNlIHRvIEZlZUNvbmZpZyBhcHAgKFVJbnQ2NCkuXG4gICAgICAgIGluc2lnaHRfbGlzdGluZ19hcHBfaWQ6IEdsb2JhbCByZWZlcmVuY2UgdG8gSW5zaWdodExpc3RpbmcgYXBwIChVSW50NjQpLlxuICAgICAgICB1bmxvY2tlZF9saXN0aW5nczogQm94TWFwKGxpc3RpbmdfaWQgPT4gVW5sb2NrUmVjb3JkKSByZWNvcmRpbmcgYnV5ZXIgYWNjZXNzICsgcGF5bWVudCBkZXRhaWxzLlxuICAgIFxuICAgIFB1cnBvc2U6IEltbXV0YWJsZSBvbi1jaGFpbiBwcm9vZiB0aGF0IGJ1eWVyIHBhaWQgZm9yIGFuZCBhY2Nlc3NlZCBzcGVjaWZpYyBsaXN0aW5nLFxuICAgIHdpdGggZ3VhcmFudGVlZCBmZWUgc3BsaXQgYmV0d2VlbiBzZWxsZXIgYW5kIHBsYXRmb3JtIHRyZWFzdXJ5LlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJVbmxvY2tSZWNvcmQiOlt7Im5hbWUiOiJidXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic2VsbGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ1bmxvY2tlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoicGF5bWVudF9hbW91bnRfbWljcm9fdXNkYyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZV9jb25maWdfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnNpZ2h0X2xpc3RpbmdfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeV9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2FwcF9pZHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX2NvbmZpZ19hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imluc2lnaHRfbGlzdGluZ19hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX2FmdGVyX3BheW1lbnQiLCJkZXNjIjoiUmVjb3JkIGJ1eWVyIGFjY2VzcyBhbmQgc3BsaXQgcGF5bWVudCBhZnRlciB4NDAyIHBheW1lbnQgY29uZmlybWVkIG9uLWNoYWluLlxuUHVycG9zZTogUG9zdC1wYXltZW50IGdhdGUgd2l0aCBmZWUgc3BsaXR0aW5nLiBDYWxsZWQgYnkgcG9zdF9wYXltZW50X2Zsb3cgYWZ0ZXIgeDQwMiAgdHggY29uZmlybWVkIGFuZCBpbmRleGVkLiBBdG9taWNhbGx5IHZhbGlkYXRlcyBjYWxsZXIgaXMgYnV5ZXIgYW5kIHNwbGl0cyBwYXltZW50LlxuQWN0aW9uczogMS4gQXNzZXJ0IHR4LnNlbmRlciA9PSBidXllciAoY29uZmlybXMgY2FsbGVyIGlzIGJ1eWVyJ3Mgd2FsbGV0KS4gMi4gQ2hlY2sgYnV5ZXIgcmVnaXN0ZXJlZCBpbiBBZ2VudFJlZ2lzdHJ5IChpZiBzZXQpLiAzLiBDYWxsIEZlZUNvbmZpZy5jYWxjdWxhdGVfZmVlIHRvIGRldGVybWluZSBzZWxsZXIgcGF5b3V0IGFuZCB0cmVhc3VyeSBmZWUuIDQuIEJ1aWxkIGFuZCBzdWJtaXQgdHdvIGlubmVyIGl0eG4uQXNzZXRUcmFuc2ZlciB0cmFuc2FjdGlvbnMgYXRvbWljYWxseTogICAgYS4gVHJhbnNmZXIgc2VsbGVyX3BheW91dF9taWNyb191c2RjIHRvIHNlbGxlciB3YWxsZXQgICAgYi4gVHJhbnNmZXIgZmVlX21pY3JvX3VzZGMgdG8gdHJlYXN1cnkgd2FsbGV0IDUuIENhbGwgRmVlQ29uZmlnLnJlY29yZF9mZWVfY29sbGVjdGVkIHRvIHVwZGF0ZSByZXZlbnVlIGNvdW50ZXIuIDYuIENhbGwgSW5zaWdodExpc3RpbmcgdG8gbWFyayBsaXN0aW5nIGFzIHB1cmNoYXNlZCBieSBidXllci4gNy4gU3RvcmUgVW5sb2NrUmVjb3JkIGluIGJveGVzOiB7YnV5ZXIsIHNlbGxlciwgdW5sb2NrZWQ9VHJ1ZSwgYW1vdW50fS4gOC4gUmV0dXJuIFRydWUgdG8gc2lnbmFsIHN1Y2Nlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXllciIsImRlc2MiOiJBbGdvcmFuZCB3YWxsZXQgYWRkcmVzcyBvZiB0aGUgYnV5ZXIgKG11c3QgbWF0Y2ggdHggc2VuZGVyKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjoiQWxnb3JhbmQgd2FsbGV0IGFkZHJlc3Mgb2YgdGhlIGluc2lnaHQgY3JlYXRvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxpc3RpbmdfaWQiLCJkZXNjIjoiSW5zaWdodExpc3RpbmcgSUQgdGhhdCBidXllciBwYWlkIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9taWNyb191c2RjIiwiZGVzYyI6IlRvdGFsIHBheW1lbnQgYW1vdW50IGluIG1pY3JvVVNEQyBiZWZvcmUgZmVlIHNwbGl0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19hc3NldF9pZCIsImRlc2MiOiJVU0RDIEFTQSBJRCBmb3IgaW5uZXIgdHJhbnNmZXJzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyZWFzdXJ5X2FkZHJlc3MiLCJkZXNjIjoiVHJlYXN1cnkgd2FsbGV0IHRvIHJlY2VpdmUgcGxhdGZvcm0gZmVlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiB1bmxvY2sgcmVjb3JkZWQgYW5kIHBheW1lbnQgc3BsaXQgc3VjY2Vzc2Z1bGx5LiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzUzXSwiZXJyb3JNZXNzYWdlIjoiQnV5ZXIgbXVzdCBiZSByZWdpc3RlcmVkIGluIEFnZW50UmVnaXN0cnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTRdLCJlcnJvck1lc3NhZ2UiOiJGZWUgc3BsaXQgaW52YXJpYW50IHZpb2xhdGVkOiBmZWUgKyBwYXlvdXQgIT0gYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gdXBkYXRlIGFwcCBpZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBidXllciBjYW4gcmVsZWFzZSBhZnRlciBwYXltZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQwLDM5Ml0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5mZWVfY29uZmlnX2FwcF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMCwzMDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlZ2lzdHJ5X2FwcF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQyLDI1MiwyOTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3LDE1NSwxNjMsMTkyLDIwMCwyMDgsMjYyLDI3MiwyODIsNDAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lEZ2dNU0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpY21WbmFYTjBjbmxmWVhCd1gybGtJaUFpWm1WbFgyTnZibVpwWjE5aGNIQmZhV1FpSUNKdmQyNWxjaUlnSW1sdWMybG5hSFJmYkdsemRHbHVaMTloY0hCZmFXUWlJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklITmxiR1l1YjNkdVpYSXVkbUZzZFdVZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW05M2JtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklITmxiR1l1Wm1WbFgyTnZibVpwWjE5aGNIQmZhV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVpsWlY5amIyNW1hV2RmWVhCd1gybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QnpaV3htTG1sdWMybG5hSFJmYkdsemRHbHVaMTloY0hCZmFXUXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltbHVjMmxuYUhSZmJHbHpkR2x1WjE5aGNIQmZhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJSE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldkcGMzUnllVjloY0hCZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnWTJ4aGMzTWdSWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtOREEzTkRNM015QXdlREl4TXpBeE1UUTVJQzh2SUcxbGRHaHZaQ0FpYzJWMFgyRndjRjlwWkhNb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnNaV0Z6WlY5aFpuUmxjbDl3WVhsdFpXNTBLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpaWFJmWVhCd1gybGtjeUJ5Wld4bFlYTmxYMkZtZEdWeVgzQmhlVzFsYm5RS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1kyeGhjM01nUlhOamNtOTNLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM1pXWmtZVFJrTWlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYTmpjbTkzTG1OdmJuUnlZV04wTGtWelkzSnZkeTVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWl3Z1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJSE5sYkdZdVptVmxYMk52Ym1acFoxOWhjSEJmYVdRdWRtRnNkV1VnUFNCbVpXVmZZMjl1Wm1sblgyRndjRjlwWkM1aGMxOTFhVzUwTmpRb0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ptWldWZlkyOXVabWxuWDJGd2NGOXBaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJ6Wld4bUxtbHVjMmxuYUhSZmJHbHpkR2x1WjE5aGNIQmZhV1F1ZG1Gc2RXVWdQU0JwYm5OcFoyaDBYMnhwYzNScGJtZGZZWEJ3WDJsa0xtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnBibk5wWjJoMFgyeHBjM1JwYm1kZllYQndYMmxrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUhObGJHWXVjbVZuYVhOMGNubGZZWEJ3WDJsa0xuWmhiSFZsSUQwZ2NtVm5hWE4wY25sZllYQndYMmxrTG1GelgzVnBiblEyTkNncENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeVpXZHBjM1J5ZVY5aGNIQmZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8zTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVZ6WTNKdmR5NWpiMjUwY21GamRDNUZjMk55YjNjdWMyVjBYMkZ3Y0Y5cFpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZllYQndYMmxrY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTkzYm1WeUxuWmhiSFZsTG01aGRHbDJaU3dnSWs5dWJIa2diM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQmhjSEFnYVdSeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUc5M2JtVnlJR05oYmlCMWNHUmhkR1VnWVhCd0lHbGtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdjMlZzWmk1bVpXVmZZMjl1Wm1sblgyRndjRjlwWkM1MllXeDFaU0E5SUdabFpWOWpiMjVtYVdkZllYQndYMmxrTG1GelgzVnBiblEyTkNncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVpsWlY5amIyNW1hV2RmWVhCd1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJSE5sYkdZdWFXNXphV2RvZEY5c2FYTjBhVzVuWDJGd2NGOXBaQzUyWVd4MVpTQTlJR2x1YzJsbmFIUmZiR2x6ZEdsdVoxOWhjSEJmYVdRdVlYTmZkV2x1ZERZMEtDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltbHVjMmxuYUhSZmJHbHpkR2x1WjE5aGNIQmZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEJmYVdRdWRtRnNkV1VnUFNCeVpXZHBjM1J5ZVY5aGNIQmZhV1F1WVhOZmRXbHVkRFkwS0NrS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbFoybHpkSEo1WDJGd2NGOXBaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bGMyTnliM2N1WTI5dWRISmhZM1F1UlhOamNtOTNMbkpsYkdWaGMyVmZZV1owWlhKZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxiR1ZoYzJWZllXWjBaWEpmY0dGNWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5Ea3RNVFV3Q2lBZ0lDQXZMeUFqSUZCdmMzUXRjR0Y1YldWdWRDQnlaV3hsWVhObElIQmhkR2c2SUdKMWVXVnlJR1JwY21WamRHeDVJR05oYkd4eklHVnpZM0p2ZHlCaFpuUmxjaUJ3WVhsdFpXNTBJR052Ym1acGNtMWhkR2x2Ymk0S0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlHSjFlV1Z5TG01aGRHbDJaU3dnSWs5dWJIa2dkR2hsSUdKMWVXVnlJR05oYmlCeVpXeGxZWE5sSUdGbWRHVnlJSEJoZVcxbGJuUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR0oxZVdWeUlHTmhiaUJ5Wld4bFlYTmxJR0ZtZEdWeUlIQmhlVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeUxURTFNd29nSUNBZ0x5OGdJeUJQY0hScGIyNWhiR3g1SUdOb1pXTnJJR0oxZVdWeUlHbHpJSEpsWjJsemRHVnlaV1FnYVc0Z1FXZGxiblJTWldkcGMzUnllU0FvYVdZZ2NtVm5hWE4wY25sZllYQndYMmxrSUdseklITmxkQ2tLSUNBZ0lDOHZJR2xtSUhObGJHWXVjbVZuYVhOMGNubGZZWEJ3WDJsa0xuWmhiSFZsSUNFOUlGVkpiblEyTkNnd0tUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeVpXZHBjM1J5ZVY5aGNIQmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrSUdWNGFYTjBjd29nSUNBZ1lub2djbVZzWldGelpWOWhablJsY2w5d1lYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVFF0TVRVNENpQWdJQ0F2THlCcGMxOXlaV2RwYzNSbGNtVmtMQ0J5WldkcGMzUnlZWFJwYjI1ZlkyaGxZMnRmZEhodUlEMGdZWEpqTkM1aFltbGZZMkZzYkZ0aGNtTTBMa0p2YjJ4ZEtBb2dJQ0FnTHk4Z0lDQWdJQ0pwYzE5eVpXZHBjM1JsY21Wa0tHRmtaSEpsYzNNcFltOXZiQ0lzQ2lBZ0lDQXZMeUFnSUNBZ1luVjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFhObGJHWXVjbVZuYVhOMGNubGZZWEJ3WDJsa0xuWmhiSFZsTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJR0Z3Y0Y5cFpEMXpaV3htTG5KbFoybHpkSEo1WDJGd2NGOXBaQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeVpXZHBjM1J5ZVY5aGNIQmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrSUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUxTkMweE5UZ0tJQ0FnSUM4dklHbHpYM0psWjJsemRHVnlaV1FzSUhKbFoybHpkSEpoZEdsdmJsOWphR1ZqYTE5MGVHNGdQU0JoY21NMExtRmlhVjlqWVd4c1cyRnlZelF1UW05dmJGMG9DaUFnSUNBdkx5QWdJQ0FnSW1selgzSmxaMmx6ZEdWeVpXUW9ZV1JrY21WemN5bGliMjlzSWl3S0lDQWdJQzh2SUNBZ0lDQmlkWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROWMyVnNaaTV5WldkcGMzUnllVjloY0hCZmFXUXVkbUZzZFdVc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU1UbGpNREprWmlBdkx5QnRaWFJvYjJRZ0ltbHpYM0psWjJsemRHVnlaV1FvWVdSa2NtVnpjeWxpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHeHZaeUIyWVd4MVpTQnBjeUJ1YjNRZ2RHaGxJSEpsYzNWc2RDQnZaaUJoYmlCQlFra2djbVYwZFhKdUNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCaGMzTmxjblFnYVhOZmNtVm5hWE4wWlhKbFpDd2dJa0oxZVdWeUlHMTFjM1FnWW1VZ2NtVm5hWE4wWlhKbFpDQnBiaUJCWjJWdWRGSmxaMmx6ZEhKNUlnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5WNVpYSWdiWFZ6ZENCaVpTQnlaV2RwYzNSbGNtVmtJR2x1SUVGblpXNTBVbVZuYVhOMGNua0tDbkpsYkdWaGMyVmZZV1owWlhKZmNHRjViV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyTVMweE5qWUtJQ0FnSUM4dklDTWdRMkZzYkNCR1pXVkRiMjVtYVdjZ2RHOGdaMlYwSUdabFpTQmpZV3hqZFd4aGRHbHZiZ29nSUNBZ0x5OGdabVZsWDIxcFkzSnZYM1Z6WkdNc0lHWmxaVjlqWVd4amRXeGhkR2x2Ymw5MGVHNGdQU0JoY21NMExtRmlhVjlqWVd4c1cyRnlZelF1VlVsdWREWTBYU2dLSUNBZ0lDOHZJQ0FnSUNBaVkyRnNZM1ZzWVhSbFgyWmxaU2gxYVc1ME5qUXBkV2x1ZERZMElpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZiV2xqY205ZmRYTmtZeXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5YzJWc1ppNW1aV1ZmWTI5dVptbG5YMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFkxQ2lBZ0lDQXZMeUJoY0hCZmFXUTljMlZzWmk1bVpXVmZZMjl1Wm1sblgyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm1aV1ZmWTI5dVptbG5YMkZ3Y0Y5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVtWldWZlkyOXVabWxuWDJGd2NGOXBaQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJNUzB4TmpZS0lDQWdJQzh2SUNNZ1EyRnNiQ0JHWldWRGIyNW1hV2NnZEc4Z1oyVjBJR1psWlNCallXeGpkV3hoZEdsdmJnb2dJQ0FnTHk4Z1ptVmxYMjFwWTNKdlgzVnpaR01zSUdabFpWOWpZV3hqZFd4aGRHbHZibDkwZUc0Z1BTQmhjbU0wTG1GaWFWOWpZV3hzVzJGeVl6UXVWVWx1ZERZMFhTZ0tJQ0FnSUM4dklDQWdJQ0FpWTJGc1kzVnNZWFJsWDJabFpTaDFhVzUwTmpRcGRXbHVkRFkwSWl3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmJXbGpjbTlmZFhOa1l5d0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTljMlZzWmk1bVpXVmZZMjl1Wm1sblgyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUwWkRjeU5UWXlJQzh2SUcxbGRHaHZaQ0FpWTJGc1kzVnNZWFJsWDJabFpTaDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnYkc5bklIWmhiSFZsSUdseklHNXZkQ0IwYUdVZ2NtVnpkV3gwSUc5bUlHRnVJRUZDU1NCeVpYUjFjbTRLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyT0MweE5qa0tJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSE5sYkd4bGNpQndZWGx2ZFhRS0lDQWdJQzh2SUdGdGIzVnVkQ0E5SUdGdGIzVnVkRjl0YVdOeWIxOTFjMlJqTG1GelgzVnBiblEyTkNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklHWmxaU0E5SUdabFpWOXRhV055YjE5MWMyUmpMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUhObGJHeGxjbDl3WVhsdmRYUmZiV2xqY205ZmRYTmtZeUE5SUdGdGIzVnVkQ0F0SUdabFpRb2dJQ0FnWkhWd01nb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUdabFpTQXJJSE5sYkd4bGNsOXdZWGx2ZFhSZmJXbGpjbTlmZFhOa1l5QTlQU0JoYlc5MWJuUUtJQ0FnSUdSMWNESUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UY3pMVEUzTmdvZ0lDQWdMeThnSXlCSmJuWmhjbWxoYm5RZ1kyaGxZMnM2SUdabFpTQXJJSEJoZVc5MWRDQnRkWE4wSUdWeGRXRnNJR0Z0YjNWdWRDQW9iRzl6YzJ4bGMzTWdjM0JzYVhRcENpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lHWmxaU0FySUhObGJHeGxjbDl3WVhsdmRYUmZiV2xqY205ZmRYTmtZeUE5UFNCaGJXOTFiblFLSUNBZ0lDOHZJQ2tzSUNKR1pXVWdjM0JzYVhRZ2FXNTJZWEpwWVc1MElIWnBiMnhoZEdWa09pQm1aV1VnS3lCd1lYbHZkWFFnSVQwZ1lXMXZkVzUwSWdvZ0lDQWdZWE56WlhKMElDOHZJRVpsWlNCemNHeHBkQ0JwYm5aaGNtbGhiblFnZG1sdmJHRjBaV1E2SUdabFpTQXJJSEJoZVc5MWRDQWhQU0JoYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UZ3dDaUFnSUNBdkx5QjRabVZ5WDJGemMyVjBQWFZ6WkdOZllYTnpaWFJmYVdRdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNCa2FXY2dOZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hPRGtLSUNBZ0lDOHZJR2wwZUc0dWMzVmliV2wwWDNSNGJuTW9jMlZzYkdWeVgzUnlZVzV6Wm1WeUxDQjBjbVZoYzNWeWVWOTBjbUZ1YzJabGNpa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1JwWnlBNUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE56Z3RNVGM1Q2lBZ0lDQXZMeUFqSUVKMWFXeGtJR0p2ZEdnZ2RISmhibk5tWlhKekxDQjBhR1Z1SUhOMVltMXBkQ0J2Ym1ObElHWnZjaUJoZEc5dGFXTWdhVzV1WlhJdFozSnZkWEFnYzJWdFlXNTBhV056TGdvZ0lDQWdMeThnYzJWc2JHVnlYM1J5WVc1elptVnlJRDBnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCcGRIaHVMbk4xWW0xcGRGOTBlRzV6S0hObGJHeGxjbDkwY21GdWMyWmxjaXdnZEhKbFlYTjFjbmxmZEhKaGJuTm1aWElwQ2lBZ0lDQnBkSGh1WDI1bGVIUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdScFp5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTROQW9nSUNBZ0x5OGdkSEpsWVhOMWNubGZkSEpoYm5ObVpYSWdQU0JwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUdsMGVHNHVjM1ZpYldsMFgzUjRibk1vYzJWc2JHVnlYM1J5WVc1elptVnlMQ0IwY21WaGMzVnllVjkwY21GdWMyWmxjaWtLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTVNUzB4T1RZS0lDQWdJQzh2SUNNZ1VtVmpiM0prSUdabFpTQmpiMnhzWldOMGFXOXVJR2x1SUVabFpVTnZibVpwWndvZ0lDQWdMeThnWVhKak5DNWhZbWxmWTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0FpY21WamIzSmtYMlpsWlY5amIyeHNaV04wWldRb2RXbHVkRFkwS1NJc0NpQWdJQ0F2THlBZ0lDQWdabVZsWDIxcFkzSnZYM1Z6WkdNc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BYTmxiR1l1Wm1WbFgyTnZibVpwWjE5aGNIQmZhV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QXBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TjJNM1kyTTFOeklnTHk4Z2JXVjBhRzlrSUNKeVpXTnZjbVJmWm1WbFgyTnZiR3hsWTNSbFpDaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qQXhMVEl3TndvZ0lDQWdMeThnSXlCVGRHOXlaU0IxYm14dlkyc2djbVZqYjNKa0lIZHBkR2dnY0dGNWJXVnVkQ0JrWlhSaGFXeHpDaUFnSUNBdkx5QnpaV3htTG5WdWJHOWphMlZrWDJ4cGMzUnBibWR6VzJ4cGMzUnBibWRmYVdSZElEMGdWVzVzYjJOclVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5UFdKMWVXVnlMQW9nSUNBZ0x5OGdJQ0FnSUhObGJHeGxjajF6Wld4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnZFc1c2IyTnJaV1E5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblJmWVcxdmRXNTBYMjFwWTNKdlgzVnpaR005WVcxdmRXNTBYMjFwWTNKdlgzVnpaR01zQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTndvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd05Rb2dJQ0FnTHk4Z2RXNXNiMk5yWldROVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeExUSXdOd29nSUNBZ0x5OGdJeUJUZEc5eVpTQjFibXh2WTJzZ2NtVmpiM0prSUhkcGRHZ2djR0Y1YldWdWRDQmtaWFJoYVd4ekNpQWdJQ0F2THlCelpXeG1MblZ1Ykc5amEyVmtYMnhwYzNScGJtZHpXMnhwYzNScGJtZGZhV1JkSUQwZ1ZXNXNiMk5yVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdKMWVXVnlQV0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSE5sYkd4bGNqMXpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdkVzVzYjJOclpXUTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUmZZVzF2ZFc1MFgyMXBZM0p2WDNWelpHTTlZVzF2ZFc1MFgyMXBZM0p2WDNWelpHTXNDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TURFdE1qQXlDaUFnSUNBdkx5QWpJRk4wYjNKbElIVnViRzlqYXlCeVpXTnZjbVFnZDJsMGFDQndZWGx0Wlc1MElHUmxkR0ZwYkhNS0lDQWdJQzh2SUhObGJHWXVkVzVzYjJOclpXUmZiR2x6ZEdsdVozTmJiR2x6ZEdsdVoxOXBaRjBnUFNCVmJteHZZMnRTWldOdmNtUW9DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNOVFpsTm1NMlpqWXpObUlLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeExUSXdOd29nSUNBZ0x5OGdJeUJUZEc5eVpTQjFibXh2WTJzZ2NtVmpiM0prSUhkcGRHZ2djR0Y1YldWdWRDQmtaWFJoYVd4ekNpQWdJQ0F2THlCelpXeG1MblZ1Ykc5amEyVmtYMnhwYzNScGJtZHpXMnhwYzNScGJtZGZhV1JkSUQwZ1ZXNXNiMk5yVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdKMWVXVnlQV0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSE5sYkd4bGNqMXpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdkVzVzYjJOclpXUTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUmZZVzF2ZFc1MFgyMXBZM0p2WDNWelpHTTlZVzF2ZFc1MFgyMXBZM0p2WDNWelpHTXNDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0JJQ1lGRDNKbFoybHpkSEo1WDJGd2NGOXBaQkZtWldWZlkyOXVabWxuWDJGd2NGOXBaQVZ2ZDI1bGNoWnBibk5wWjJoMFgyeHBjM1JwYm1kZllYQndYMmxrQkJVZmZIVXhHRUFBRFNveEFHY3BJbWNySW1jb0ltY3hHUlJFTVJoQkFCYUNBZ1RVQjBOekJDRXdFVWsyR2dDT0FnQThBRzBBZ0FSKy9hVFNOaG9BamdFQUFRQTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRU5ob0RTUlVqRWtRcU1RQm5Ud0lYS1V4blRCY3JUR2NYS0V4bkpFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRU5ob0RTUlVqRWtReEFDSXFaVVFTUkU4Q0Z5bE1aMHdYSzB4bkZ5aE1aeVJETmhvQlJ3SVZKUkpFTmhvQ1NVNENGU1VTUkRZYUEwbE9BaFVqRWtRMkdnUkpUZ0lWSXhKRU5ob0ZTVTRDRlNNU1JEWWFCa2xPQWhVbEVrUXhBQkpFSWlobFJFRUFNckVpS0dWRXNoaUFCSkdjQXQreUdrc0ZzaHFCQnJJUUlySUJzN1ErU1ZjQUJDY0VFa1JYQkFCSkZTUVNSSUFCQUJORXNTSXBaVVJKc2hpQUJCVFhKV0t5R2tzRFNiSWFnUWF5RUNLeUFiTzBQa2xYQUFRbkJCSkVWd1FBU1JVakVrUkxBUmRMQVJkS0NVb0lUd01TUkVzR0Y3Rk1zaEpMQ1VsT0E3SVVTYklSZ1FTeUVDS3lBYlpNc2hKTEJiSVVzaEdCQkxJUUlySUJzN0ZQQTdJWWdBUjhmTVZ5c2hwTXNocUJCcklRSXJJQnMwc0hURkNBQVlCUVRGQ0FCblZ1Ykc5amEwc0ZVRXkvZ0FVVkgzeDFnTEFrUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
