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

namespace Arc56.Generated.murat48.PayLinkAlgo.InstantCheckout_ab849a0c
{


    public class InstantCheckoutProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public InstantCheckoutProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="merchant"> </param>
        /// <param name="feePercentage"> </param>
        public async Task Create(byte[] merchant, ulong feePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 130, 27, 65 };
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); merchantAbi.From(merchant);
            var feePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageAbi.From(feePercentage);

            var result = await base.CallApp(new List<object> { abiHandle, merchantAbi, feePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(byte[] merchant, ulong feePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 130, 27, 65 };
            var merchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); merchantAbi.From(merchant);
            var feePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageAbi.From(feePercentage);

            return await base.MakeTransactionList(new List<object> { abiHandle, merchantAbi, feePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="checkoutId"> </param>
        /// <param name="amount"> </param>
        /// <param name="assetId"> </param>
        /// <param name="description"> </param>
        /// <param name="expiresAt"> </param>
        public async Task CreateCheckout(string checkoutId, ulong amount, ulong assetId, string description, ulong expiresAt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 79, 176, 195 };
            var checkoutIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); checkoutIdAbi.From(checkoutId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);

            var result = await base.CallApp(new List<object> { abiHandle, checkoutIdAbi, amountAbi, assetIdAbi, descriptionAbi, expiresAtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateCheckout_Transactions(string checkoutId, ulong amount, ulong assetId, string description, ulong expiresAt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 79, 176, 195 };
            var checkoutIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); checkoutIdAbi.From(checkoutId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);

            return await base.MakeTransactionList(new List<object> { abiHandle, checkoutIdAbi, amountAbi, assetIdAbi, descriptionAbi, expiresAtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetCheckoutDetails(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 157, 233, 78 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetCheckoutDetails_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 157, 233, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MarkAsPaid(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 228, 210, 115 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkAsPaid_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 228, 210, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="paymentAmount"> </param>
        /// <param name="paymentSender"> </param>
        public async Task VerifyAndMarkPaid(ulong paymentAmount, byte[] paymentSender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 72, 50, 62 };
            var paymentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAmountAbi.From(paymentAmount);
            var paymentSenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); paymentSenderAbi.From(paymentSender);

            var result = await base.CallApp(new List<object> { abiHandle, paymentAmountAbi, paymentSenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyAndMarkPaid_Transactions(ulong paymentAmount, byte[] paymentSender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 72, 50, 62 };
            var paymentAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAmountAbi.From(paymentAmount);
            var paymentSenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); paymentSenderAbi.From(paymentSender);

            return await base.MakeTransactionList(new List<object> { abiHandle, paymentAmountAbi, paymentSenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetPaymentStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 111, 252, 207 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPaymentStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 111, 252, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CancelCheckout(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 242, 101, 210 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelCheckout_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 242, 101, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newMerchant"> </param>
        public async Task UpdateMerchant(byte[] newMerchant, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 184, 65, 62 };
            var newMerchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newMerchantAbi.From(newMerchant);

            var result = await base.CallApp(new List<object> { abiHandle, newMerchantAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateMerchant_Transactions(byte[] newMerchant, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 184, 65, 62 };
            var newMerchantAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newMerchantAbi.From(newMerchant);

            return await base.MakeTransactionList(new List<object> { abiHandle, newMerchantAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newFeePercentage"> </param>
        public async Task UpdateFeePercentage(ulong newFeePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 54, 32, 7 };
            var newFeePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeePercentageAbi.From(newFeePercentage);

            var result = await base.CallApp(new List<object> { abiHandle, newFeePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateFeePercentage_Transactions(ulong newFeePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 54, 32, 7 };
            var newFeePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeePercentageAbi.From(newFeePercentage);

            return await base.MakeTransactionList(new List<object> { abiHandle, newFeePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Deactivate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 145, 83, 39 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deactivate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 145, 83, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW5zdGFudENoZWNrb3V0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXJjaGFudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlUGVyY2VudGFnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVDaGVja291dCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGVja291dElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzQXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Q2hlY2tvdXREZXRhaWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya0FzUGFpZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlBbmRNYXJrUGFpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50U2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBheW1lbnRTdGF0dXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxDaGVja291dCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVNZXJjaGFudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdNZXJjaGFudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVGZWVQZXJjZW50YWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0ZlZVBlcmNlbnRhZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVhY3RpdmF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxN10sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IGNhbmNlbCBwYWlkIGNoZWNrb3V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAxLDUyMV0sImVycm9yTWVzc2FnZSI6IkNoZWNrb3V0IGFscmVhZHkgbWFya2VkIGFzIHBhaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTRdLCJlcnJvck1lc3NhZ2UiOiJDb250cmFjdCBpcyBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAyXSwiZXJyb3JNZXNzYWdlIjoiRmVlIHBlcmNlbnRhZ2UgY2Fubm90IGV4Y2VlZCAxMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTUsNTE1XSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIGNoZWNrb3V0IHNlc3Npb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODcsMTk5LDIxNSwyMzMsMjQ1LDI2MywyODUsMjk3LDMyMiwzNThdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFtb3VudCBpbnN1ZmZpY2llbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTAsMjAyLDIxOCwyMzYsMjQ4LDI2NiwyODgsMzAwLDMyNSwzNjFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDExLDQ0OSw0ODcsNDkyLDQ5OSw1MTIsNTE5LDUyNiw1MzgsNTQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pwYzFCaGFXUWlJQ0pqYUdWamEyOTFkRWxrSWlBaUlpQWlhWE5CWTNScGRtVWlJQ0poYlc5MWJuUWlJREI0TVRVeFpqZGpOelVnSW0xbGNtTm9ZVzUwSWlBaVptVmxVR1Z5WTJWdWRHRm5aU0lnSW1GemMyVjBTV1FpSUNKa1pYTmpjbWx3ZEdsdmJpSWdJbVY0Y0dseVpYTkJkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWx1YzNSaGJuUkRhR1ZqYTI5MWRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0l5T0RJeFlqUXhJREI0WWpNMFptSXdZek1nTUhnellqbGtaVGswWlNBd2VHRXpaVFJrTWpjeklEQjRZVGMwT0RNeU0yVWdNSGhqWmpabVptTmpaaUF3ZURneVpqSTJOV1F5SURCNFpqbGlPRFF4TTJVZ01IZ3dORE0yTWpBd055QXdlRGszT1RFMU16STNJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLR0o1ZEdWYlhTeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTNKbFlYUmxRMmhsWTJ0dmRYUW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5MSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUkRhR1ZqYTI5MWRFUmxkR0ZwYkhNb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWJXRnlhMEZ6VUdGcFpDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRtVnlhV1o1UVc1a1RXRnlhMUJoYVdRb2RXbHVkRFkwTEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJRWVhsdFpXNTBVM1JoZEhWektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTmhibU5sYkVOb1pXTnJiM1YwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVk5aWEpqYUdGdWRDaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxSbVZsVUdWeVkyVnVkR0ZuWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1ZoWTNScGRtRjBaU2dwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsWDNKdmRYUmxRRE1nYldGcGJsOWpjbVZoZEdWRGFHVmphMjkxZEY5eWIzVjBaVUEwSUcxaGFXNWZaMlYwUTJobFkydHZkWFJFWlhSaGFXeHpYM0p2ZFhSbFFEVWdiV0ZwYmw5dFlYSnJRWE5RWVdsa1gzSnZkWFJsUURZZ2JXRnBibDkyWlhKcFpubEJibVJOWVhKclVHRnBaRjl5YjNWMFpVQTNJRzFoYVc1ZloyVjBVR0Y1YldWdWRGTjBZWFIxYzE5eWIzVjBaVUE0SUcxaGFXNWZZMkZ1WTJWc1EyaGxZMnR2ZFhSZmNtOTFkR1ZBT1NCdFlXbHVYM1Z3WkdGMFpVMWxjbU5vWVc1MFgzSnZkWFJsUURFd0lHMWhhVzVmZFhCa1lYUmxSbVZsVUdWeVkyVnVkR0ZuWlY5eWIzVjBaVUF4TVNCdFlXbHVYMlJsWVdOMGFYWmhkR1ZmY205MWRHVkFNVElLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFbHVjM1JoYm5SRGFHVmphMjkxZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWkdWaFkzUnBkbUYwWlY5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEyQ2lBZ0lDQXZMeUJrWldGamRHbDJZWFJsS0NrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHUmxZV04wYVhaaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsUm1WbFVHVnlZMlZ1ZEdGblpWOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBd0NpQWdJQ0F2THlCMWNHUmhkR1ZHWldWUVpYSmpaVzUwWVdkbEtHNWxkMFpsWlZCbGNtTmxiblJoWjJVNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJKYm5OMFlXNTBRMmhsWTJ0dmRYUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2RYQmtZWFJsUm1WbFVHVnlZMlZ1ZEdGblpTaHVaWGRHWldWUVpYSmpaVzUwWVdkbE9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFJtVmxVR1Z5WTJWdWRHRm5aUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWTlpYSmphR0Z1ZEY5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJSFZ3WkdGMFpVMWxjbU5vWVc1MEtHNWxkMDFsY21Ob1lXNTBPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSmJuTjBZVzUwUTJobFkydHZkWFFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsVFdWeVkyaGhiblFvYm1WM1RXVnlZMmhoYm5RNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlUxbGNtTm9ZVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYm1ObGJFTm9aV05yYjNWMFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJqWVc1alpXeERhR1ZqYTI5MWRDZ3BPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJqWVc1alpXeERhR1ZqYTI5MWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlFZWGx0Wlc1MFUzUmhkSFZ6WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5Qm5aWFJRWVhsdFpXNTBVM1JoZEhWektDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVHRjViV1Z1ZEZOMFlYUjFjd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTJaWEpwWm5sQmJtUk5ZWEpyVUdGcFpGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzUmhiblJmWTJobFkydHZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnZG1WeWFXWjVRVzVrVFdGeWExQmhhV1FvY0dGNWJXVnVkRUZ0YjNWdWREb2dkV2x1ZERZMExDQndZWGx0Wlc1MFUyVnVaR1Z5T2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qkpibk4wWVc1MFEyaGxZMnR2ZFhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdkbVZ5YVdaNVFXNWtUV0Z5YTFCaGFXUW9jR0Y1YldWdWRFRnRiM1Z1ZERvZ2RXbHVkRFkwTENCd1lYbHRaVzUwVTJWdVpHVnlPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnWTJGc2JITjFZaUIyWlhKcFpubEJibVJOWVhKclVHRnBaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXRZWEpyUVhOUVlXbGtYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCdFlYSnJRWE5RWVdsa0tDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJRzFoY210QmMxQmhhV1FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwUTJobFkydHZkWFJFWlhSaGFXeHpYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCblpYUkRhR1ZqYTI5MWRFUmxkR0ZwYkhNb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSRGFHVmphMjkxZEVSbGRHRnBiSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlVOb1pXTnJiM1YwWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFMVE14Q2lBZ0lDQXZMeUJqY21WaGRHVkRhR1ZqYTI5MWRDZ0tJQ0FnSUM4dklDQWdZMmhsWTJ0dmRYUkpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZWE56WlhSSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmtaWE5qY21sd2RHbHZiam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JsZUhCcGNtVnpRWFE2SUhWcGJuUTJOQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFbHVjM1JoYm5SRGFHVmphMjkxZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5TMHpNUW9nSUNBZ0x5OGdZM0psWVhSbFEyaGxZMnR2ZFhRb0NpQWdJQ0F2THlBZ0lHTm9aV05yYjNWMFNXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHRnpjMlYwU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1pHVnpZM0pwY0hScGIyNDZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdaWGh3YVhKbGMwRjBPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVkRhR1ZqYTI5MWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHTnlaV0YwWlNodFpYSmphR0Z1ZERvZ1lubDBaWE1zSUdabFpWQmxjbU5sYm5SaFoyVTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSmJuTjBZVzUwUTJobFkydHZkWFFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1kzSmxZWFJsS0cxbGNtTm9ZVzUwT2lCaWVYUmxjeXdnWm1WbFVHVnlZMlZ1ZEdGblpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJKYm5OMFlXNTBRMmhsWTJ0dmRYUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFNUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rbHVjM1JoYm5SRGFHVmphMjkxZEM1amNtVmhkR1VvYldWeVkyaGhiblE2SUdKNWRHVnpMQ0JtWldWUVpYSmpaVzUwWVdkbE9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR055WldGMFpTaHRaWEpqYUdGdWREb2dZbmwwWlhNc0lHWmxaVkJsY21ObGJuUmhaMlU2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJRzFsY21Ob1lXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xbGNtTm9ZVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdkR2hwY3k1dFpYSmphR0Z1ZEM1MllXeDFaU0E5SUcxbGNtTm9ZVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHWmxaVkJsY21ObGJuUmhaMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltWmxaVkJsY21ObGJuUmhaMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QjBhR2x6TG1abFpWQmxjbU5sYm5SaFoyVXVkbUZzZFdVZ1BTQm1aV1ZRWlhKalpXNTBZV2RsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHbHpRV04wYVhabElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzBGamRHbDJaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUm9hWE11YVhOQlkzUnBkbVV1ZG1Gc2RXVWdQU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rbHVjM1JoYm5SRGFHVmphMjkxZEM1amNtVmhkR1ZEYUdWamEyOTFkQ2hqYUdWamEyOTFkRWxrT2lCaWVYUmxjeXdnWVcxdmRXNTBPaUIxYVc1ME5qUXNJR0Z6YzJWMFNXUTZJSFZwYm5RMk5Dd2daR1Z6WTNKcGNIUnBiMjQ2SUdKNWRHVnpMQ0JsZUhCcGNtVnpRWFE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxRMmhsWTJ0dmRYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUxUTXhDaUFnSUNBdkx5QmpjbVZoZEdWRGFHVmphMjkxZENnS0lDQWdJQzh2SUNBZ1kyaGxZMnR2ZFhSSlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1lYTnpaWFJKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCa1pYTmpjbWx3ZEdsdmJqb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQmxlSEJwY21WelFYUTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z2FYTkJZM1JwZG1VZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnBjMEZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMwRmpkR2wyWlM1MllXeDFaU0E5UFQwZ01Td2dKME52Ym5SeVlXTjBJR2x6SUc1dmRDQmhZM1JwZG1VbktRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMjl1ZEhKaFkzUWdhWE1nYm05MElHRmpkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZENBK0lEQXNJQ2RCYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdZMmhsWTJ0dmRYUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyaGxZMnR2ZFhSSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhSb2FYTXVZMmhsWTJ0dmRYUkpaQzUyWVd4MVpTQTlJR05vWldOcmIzVjBTV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzUmhiblJmWTJobFkydHZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnZEdocGN5NWhiVzkxYm5RdWRtRnNkV1VnUFNCaGJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHRnpjMlYwU1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbUZ6YzJWMFNXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWMFNXUXVkbUZzZFdVZ1BTQmhjM05sZEVsa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJrWlhOamNtbHdkR2x2YmlBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9LUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlaR1Z6WTNKcGNIUnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG1SbGMyTnlhWEIwYVc5dUxuWmhiSFZsSUQwZ1pHVnpZM0pwY0hScGIyNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdWNGNHbHlaWE5CZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbVY0Y0dseVpYTkJkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUm9hWE11Wlhod2FYSmxjMEYwTG5aaGJIVmxJRDBnWlhod2FYSmxjMEYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMUJoYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx6VUdGcFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXVhWE5RWVdsa0xuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBKYm5OMFlXNTBRMmhsWTJ0dmRYUXVaMlYwUTJobFkydHZkWFJFWlhSaGFXeHpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRFTm9aV05yYjNWMFJHVjBZV2xzY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR05vWldOcmIzVjBTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamFHVmphMjkxZEVsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbU5vWldOcmIzVjBTV1F1ZG1Gc2RXVWdQVDA5SUNjbktTQjdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ1oyVjBRMmhsWTJ0dmRYUkVaWFJoYVd4elgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdjbVYwZFhKdUlDZE9ieUJoWTNScGRtVWdZMmhsWTJ0dmRYUWdjMlZ6YzJsdmJpY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRtOGdZV04wYVhabElHTm9aV05yYjNWMElITmxjM05wYjI0aUNpQWdJQ0J5WlhSemRXSUtDbWRsZEVOb1pXTnJiM1YwUkdWMFlXbHNjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCamFHVmphMjkxZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMmhsWTJ0dmRYUkpaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWphR1ZqYTI5MWRFbGtMblpoYkhWbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBKYm5OMFlXNTBRMmhsWTJ0dmRYUXViV0Z5YTBGelVHRnBaQ2dwSUMwK0lIWnZhV1E2Q20xaGNtdEJjMUJoYVdRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJqYUdWamEyOTFkRWxrSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyaGxZMnR2ZFhSSlpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1amFHVmphMjkxZEVsa0xuWmhiSFZsSUNFOVBTQW5KeXdnSjA1dklHRmpkR2wyWlNCamFHVmphMjkxZENCelpYTnphVzl1SnlrS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWVdOMGFYWmxJR05vWldOcmIzVjBJSE5sYzNOcGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdselVHRnBaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1selVHRnBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBjMUJoYVdRdWRtRnNkV1VnUFQwOUlEQXNJQ2REYUdWamEyOTFkQ0JoYkhKbFlXUjVJRzFoY210bFpDQmhjeUJ3WVdsa0p5a0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdWamEyOTFkQ0JoYkhKbFlXUjVJRzFoY210bFpDQmhjeUJ3WVdsa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJwYzFCaGFXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1selVHRnBaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11YVhOUVlXbGtMblpoYkhWbElEMGdNUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSmJuTjBZVzUwUTJobFkydHZkWFF1ZG1WeWFXWjVRVzVrVFdGeWExQmhhV1FvY0dGNWJXVnVkRUZ0YjNWdWREb2dkV2x1ZERZMExDQndZWGx0Wlc1MFUyVnVaR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVRVzVrVFdGeWExQmhhV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QjJaWEpwWm5sQmJtUk5ZWEpyVUdGcFpDaHdZWGx0Wlc1MFFXMXZkVzUwT2lCMWFXNTBOalFzSUhCaGVXMWxiblJUWlc1a1pYSTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHTm9aV05yYjNWMFNXUWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqYUdWamEyOTFkRWxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbU5vWldOcmIzVjBTV1F1ZG1Gc2RXVWdJVDA5SUNjbkxDQW5UbThnWVdOMGFYWmxJR05vWldOcmIzVjBJSE5sYzNOcGIyNG5LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlJZ29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmhZM1JwZG1VZ1kyaGxZMnR2ZFhRZ2MyVnpjMmx2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5RWVdsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE5RWVdsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selVHRnBaQzUyWVd4MVpTQTlQVDBnTUN3Z0owTm9aV05yYjNWMElHRnNjbVZoWkhrZ2JXRnlhMlZrSUdGeklIQmhhV1FuS1FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9aV05yYjNWMElHRnNjbVZoWkhrZ2JXRnlhMlZrSUdGeklIQmhhV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRnRiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEVGdGIzVnVkQ0ErUFNCMGFHbHpMbUZ0YjNWdWRDNTJZV3gxWlN3Z0oxQmhlVzFsYm5RZ1lXMXZkVzUwSUdsdWMzVm1abWxqYVdWdWRDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0JoYlc5MWJuUWdhVzV6ZFdabWFXTnBaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBjMUJoYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx6VUdGcFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhSb2FYTXVhWE5RWVdsa0xuWmhiSFZsSUQwZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBKYm5OMFlXNTBRMmhsWTJ0dmRYUXVaMlYwVUdGNWJXVnVkRk4wWVhSMWN5Z3BJQzArSUhWcGJuUTJORG9LWjJWMFVHRjViV1Z1ZEZOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHbHpVR0ZwWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpVR0ZwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVwYzFCaGFXUXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa2x1YzNSaGJuUkRhR1ZqYTI5MWRDNWpZVzVqWld4RGFHVmphMjkxZENncElDMCtJSFp2YVdRNkNtTmhibU5sYkVOb1pXTnJiM1YwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhWE5RWVdsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE5RWVdsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMFlXNTBYMk5vWldOcmIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selVHRnBaQzUyWVd4MVpTQTlQVDBnTUN3Z0owTmhibTV2ZENCallXNWpaV3dnY0dGcFpDQmphR1ZqYTI5MWRDY3BDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJR05oYm1ObGJDQndZV2xrSUdOb1pXTnJiM1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QmphR1ZqYTI5MWRFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamFHVmphMjkxZEVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzUmhiblJmWTJobFkydHZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnZEdocGN5NWphR1ZqYTI5MWRFbGtMblpoYkhWbElEMGdKeWNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QmhiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZ0YjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhSb2FYTXVZVzF2ZFc1MExuWmhiSFZsSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJoYzNObGRFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKaGMzTmxkRWxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxkRWxrTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QmtaWE5qY21sd2RHbHZiaUE5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVpHVnpZM0pwY0hScGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNENpQWdJQ0F2THlCMGFHbHpMbVJsYzJOeWFYQjBhVzl1TG5aaGJIVmxJRDBnSnljS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsZUhCcGNtVnpRWFFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmxlSEJwY21WelFYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCMGFHbHpMbVY0Y0dseVpYTkJkQzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2FYTlFZV2xrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjMUJoYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxtbHpVR0ZwWkM1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdjR0Y1YldWdWRGUjRia2xrSUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luQmhlVzFsYm5SVWVHNUpaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4wWVc1MFgyTm9aV05yYjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIUm9hWE11Y0dGNWJXVnVkRlI0Ymtsa0xuWmhiSFZsSUQwZ0p5Y0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSmJuTjBZVzUwUTJobFkydHZkWFF1ZFhCa1lYUmxUV1Z5WTJoaGJuUW9ibVYzVFdWeVkyaGhiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3AxY0dSaGRHVk5aWEpqYUdGdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjBZVzUwWDJOb1pXTnJiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhWd1pHRjBaVTFsY21Ob1lXNTBLRzVsZDAxbGNtTm9ZVzUwT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJRzFsY21Ob1lXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xbGNtTm9ZVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdkR2hwY3k1dFpYSmphR0Z1ZEM1MllXeDFaU0E5SUc1bGQwMWxjbU5vWVc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBKYm5OMFlXNTBRMmhsWTJ0dmRYUXVkWEJrWVhSbFJtVmxVR1Z5WTJWdWRHRm5aU2h1WlhkR1pXVlFaWEpqWlc1MFlXZGxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblZ3WkdGMFpVWmxaVkJsY21ObGJuUmhaMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZEdGdWRGOWphR1ZqYTI5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdkWEJrWVhSbFJtVmxVR1Z5WTJWdWRHRm5aU2h1WlhkR1pXVlFaWEpqWlc1MFlXZGxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNSaGJuUmZZMmhsWTJ0dmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRHWldWUVpYSmpaVzUwWVdkbElEdzlJREV3TENBblJtVmxJSEJsY21ObGJuUmhaMlVnWTJGdWJtOTBJR1Y0WTJWbFpDQXhNQ1VuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRVpsWlNCd1pYSmpaVzUwWVdkbElHTmhibTV2ZENCbGVHTmxaV1FnTVRBbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1psWlZCbGNtTmxiblJoWjJVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbVpsWlZCbGNtTmxiblJoWjJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRHRnVkRjlqYUdWamEyOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnZEdocGN5NW1aV1ZRWlhKalpXNTBZV2RsTG5aaGJIVmxJRDBnYm1WM1JtVmxVR1Z5WTJWdWRHRm5aUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlNXNXpkR0Z1ZEVOb1pXTnJiM1YwTG1SbFlXTjBhWFpoZEdVb0tTQXRQaUIyYjJsa09ncGtaV0ZqZEdsMllYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1JoYm5SZlkyaGxZMnR2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCcGMwRmpkR2wyWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlhWE5CWTNScGRtVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkR0Z1ZEY5amFHVmphMjkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z2RHaHBjeTVwYzBGamRHbDJaUzUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1Dd1pwYzFCaGFXUUtZMmhsWTJ0dmRYUkpaQUFJYVhOQlkzUnBkbVVHWVcxdmRXNTBCQlVmZkhVSWJXVnlZMmhoYm5RTlptVmxVR1Z5WTJWdWRHRm5aUWRoYzNObGRFbGtDMlJsYzJOeWFYQjBhVzl1Q1dWNGNHbHlaWE5CZERFYlFRRVFnZ29Fc29JYlFRU3pUN0REQkR1ZDZVNEVvK1RTY3dTblNESStCTTl2L004RWd2SmwwZ1Q1dUVFK0JBUTJJQWNFbDVGVEp6WWFBSTRLQUswQWlRQndBR1FBVGdBOEFEQUFIZ0FPQUFJaVF6RVpGRVF4R0VTSUFaOGpRekVaRkVReEdFUTJHZ0VYaUFHQUkwTXhHUlJFTVJoRU5ob0JWd0lBaUFGbEkwTXhHUlJFTVJoRWlBRXNJME14R1JSRU1SaEVpQUViRmljRlRGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFsY0NBSWdBNGlORE1Sa1VSREVZUklnQXhTTkRNUmtVUkRFWVJJZ0Fqa2tWRmxjR0FreFFKd1ZNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWE5ob0RGellhQkZjQ0FEWWFCUmVJQURRalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBQU5JME14R1VEL09ERVlGRVFqUTRvQ0FDY0dpLzVuSndlTC8yY3JJMmVKaWdVQUlpdGxSQ01TUkl2OFJDbUwrMmNuQkl2OFp5Y0lpLzFuSndtTC9tY25Db3YvWnlnaVo0a2lLV1ZFS2hKQkFCMkFHazV2SUdGamRHbDJaU0JqYUdWamEyOTFkQ0J6WlhOemFXOXVpU0lwWlVTSklpbGxSQ29UUkNJb1pVUVVSQ2dqWjRtS0FnQWlLV1ZFS2hORUlpaGxSQlJFSWljRVpVU0wvZzVFS0NObmlTSW9aVVNKSWlobFJCUkVLU3BuSndRaVp5Y0lJbWNuQ1Nwbkp3b2laeWdpWjRBTWNHRjViV1Z1ZEZSNGJrbGtLbWVKaWdFQUp3YUwvMmVKaWdFQWkvK0JDZzVFSndlTC8yZUpLeUpuaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
