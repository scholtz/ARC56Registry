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

namespace Arc56.Generated.monojitgoswami69.FundMySkill.EducateChainVault_d973b16d
{


    //
    // Vault that manages education donations, course payouts, and AI billing.
    //
    public class EducateChainVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EducateChainVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialise the vault with a treasury wallet and accepted stablecoin ASA.
        ///</summary>
        /// <param name="treasury_wallet"> </param>
        /// <param name="accepted_asset_id"> </param>
        public async Task Create(Algorand.Address treasury_wallet, ulong accepted_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var treasury_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasury_walletAbi.From(treasury_wallet);
            var accepted_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); accepted_asset_idAbi.From(accepted_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, treasury_walletAbi, accepted_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address treasury_wallet, ulong accepted_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var treasury_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasury_walletAbi.From(treasury_wallet);
            var accepted_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); accepted_asset_idAbi.From(accepted_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasury_walletAbi, accepted_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Bootstrap the vault — call after funding the app account.
        ///Sets the admin as the first reviewer (requires box MBR).
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Contract opts into the accepted stablecoin so it can receive donations.
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInToAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Accept a stablecoin donation.
        ///The caller must send a grouped ASA transfer immediately before this app call.  We verify:   • The ASA matches our accepted asset   • The receiver is the contract address   • The amount is > 0
        ///</summary>
        /// <param name="payment"> </param>
        public async Task DepositDonation(AssetTransferTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 185, 23, 121, 220 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositDonation_Transactions(AssetTransferTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 185, 23, 121, 220 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a course for payout review.
        ///</summary>
        /// <param name="course_id"> </param>
        /// <param name="seller_wallet"> </param>
        /// <param name="amount"> </param>
        public async Task RequestCoursePayout(ulong course_id, Algorand.Address seller_wallet, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 211, 147, 203 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);
            var seller_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); seller_walletAbi.From(seller_wallet);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, course_idAbi, seller_walletAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestCoursePayout_Transactions(ulong course_id, Algorand.Address seller_wallet, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 211, 147, 203 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);
            var seller_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); seller_walletAbi.From(seller_wallet);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, course_idAbi, seller_walletAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reviewer approves a course — contract auto-sends ASA to seller.
        ///</summary>
        /// <param name="course_id"> </param>
        /// <param name="asset"> </param>
        public async Task ApproveCoursePayout(ulong course_id, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 209, 177, 34 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, course_idAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveCoursePayout_Transactions(ulong course_id, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 209, 177, 34 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, course_idAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reviewer rejects a course — escrow is deleted.
        ///</summary>
        /// <param name="course_id"> </param>
        public async Task RejectCoursePayout(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 169, 241, 89 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            var result = await base.CallApp(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectCoursePayout_Transactions(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 169, 241, 89 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Treasury withdraws the AI-billing amount (read from oracle off-chain).
        ///</summary>
        /// <param name="amount_owed"> </param>
        /// <param name="asset"> </param>
        public async Task WithdrawMonthlyOracleAmount(ulong amount_owed, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 240, 165, 130 };
            var amount_owedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_owedAbi.From(amount_owed);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, amount_owedAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawMonthlyOracleAmount_Transactions(ulong amount_owed, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 240, 165, 130 };
            var amount_owedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_owedAbi.From(amount_owed);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_owedAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reset the monthly withdrawal tracker (called at month start).
        ///</summary>
        public async Task ResetMonthlyCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 253, 223, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResetMonthlyCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 253, 223, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a new reviewer (admin only).
        ///</summary>
        /// <param name="reviewer"> </param>
        public async Task AddReviewer(Algorand.Address reviewer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 1, 252, 108 };
            var reviewerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reviewerAbi.From(reviewer);

            var result = await base.CallApp(new List<object> { abiHandle, reviewerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddReviewer_Transactions(Algorand.Address reviewer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 1, 252, 108 };
            var reviewerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reviewerAbi.From(reviewer);

            return await base.MakeTransactionList(new List<object> { abiHandle, reviewerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove a reviewer (admin only).
        ///</summary>
        /// <param name="reviewer"> </param>
        public async Task RemoveReviewer(Algorand.Address reviewer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 157, 255, 113 };
            var reviewerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reviewerAbi.From(reviewer);

            var result = await base.CallApp(new List<object> { abiHandle, reviewerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveReviewer_Transactions(Algorand.Address reviewer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 157, 255, 113 };
            var reviewerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reviewerAbi.From(reviewer);

            return await base.MakeTransactionList(new List<object> { abiHandle, reviewerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the total donations held in the vault.
        ///</summary>
        public async Task<ulong> GetTotalDonations(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 214, 201, 120 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalDonations_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 214, 201, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return amount withdrawn this month for AI billing.
        ///</summary>
        public async Task<ulong> GetWithdrawnThisMonth(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 123, 174, 201 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetWithdrawnThisMonth_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 123, 174, 201 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the accepted stablecoin ASA ID.
        ///</summary>
        public async Task<ulong> GetAcceptedAssetId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 165, 130, 188 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAcceptedAssetId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 165, 130, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the escrowed amount for a course (0 if none).
        ///</summary>
        /// <param name="course_id"> </param>
        public async Task<ulong> GetCourseEscrowAmount(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 68, 27, 99 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            var result = await base.SimApp(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCourseEscrowAmount_Transactions(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 68, 27, 99 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return whether a course escrow has been approved (1) or not (0).
        ///</summary>
        /// <param name="course_id"> </param>
        public async Task<ulong> GetCourseEscrowApproved(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 236, 42, 223 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            var result = await base.SimApp(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCourseEscrowApproved_Transactions(ulong course_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 236, 42, 223 };
            var course_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); course_idAbi.From(course_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, course_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address is a reviewer.
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> IsReviewer(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 66, 97, 84 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsReviewer_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 66, 97, 84 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRWR1Y2F0ZUNoYWluVmF1bHQiLCJkZXNjIjoiVmF1bHQgdGhhdCBtYW5hZ2VzIGVkdWNhdGlvbiBkb25hdGlvbnMsIGNvdXJzZSBwYXlvdXRzLCBhbmQgQUkgYmlsbGluZy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpc2UgdGhlIHZhdWx0IHdpdGggYSB0cmVhc3VyeSB3YWxsZXQgYW5kIGFjY2VwdGVkIHN0YWJsZWNvaW4gQVNBLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnlfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NlcHRlZF9hc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjoiQm9vdHN0cmFwIHRoZSB2YXVsdCDigJQgY2FsbCBhZnRlciBmdW5kaW5nIHRoZSBhcHAgYWNjb3VudC5cblNldHMgdGhlIGFkbWluIGFzIHRoZSBmaXJzdCByZXZpZXdlciAocmVxdWlyZXMgYm94IE1CUikuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOiJDb250cmFjdCBvcHRzIGludG8gdGhlIGFjY2VwdGVkIHN0YWJsZWNvaW4gc28gaXQgY2FuIHJlY2VpdmUgZG9uYXRpb25zLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0X2RvbmF0aW9uIiwiZGVzYyI6IkFjY2VwdCBhIHN0YWJsZWNvaW4gZG9uYXRpb24uXG5UaGUgY2FsbGVyIG11c3Qgc2VuZCBhIGdyb3VwZWQgQVNBIHRyYW5zZmVyIGltbWVkaWF0ZWx5IGJlZm9yZSB0aGlzIGFwcCBjYWxsLiAgV2UgdmVyaWZ5OiAgIOKAoiBUaGUgQVNBIG1hdGNoZXMgb3VyIGFjY2VwdGVkIGFzc2V0ICAg4oCiIFRoZSByZWNlaXZlciBpcyB0aGUgY29udHJhY3QgYWRkcmVzcyAgIOKAoiBUaGUgYW1vdW50IGlzID4gMCIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdF9jb3Vyc2VfcGF5b3V0IiwiZGVzYyI6IlJlZ2lzdGVyIGEgY291cnNlIGZvciBwYXlvdXQgcmV2aWV3LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb3Vyc2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXJfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZV9jb3Vyc2VfcGF5b3V0IiwiZGVzYyI6IlJldmlld2VyIGFwcHJvdmVzIGEgY291cnNlIOKAlCBjb250cmFjdCBhdXRvLXNlbmRzIEFTQSB0byBzZWxsZXIuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvdXJzZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVqZWN0X2NvdXJzZV9wYXlvdXQiLCJkZXNjIjoiUmV2aWV3ZXIgcmVqZWN0cyBhIGNvdXJzZSDigJQgZXNjcm93IGlzIGRlbGV0ZWQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvdXJzZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19tb250aGx5X29yYWNsZV9hbW91bnQiLCJkZXNjIjoiVHJlYXN1cnkgd2l0aGRyYXdzIHRoZSBBSS1iaWxsaW5nIGFtb3VudCAocmVhZCBmcm9tIG9yYWNsZSBvZmYtY2hhaW4pLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfb3dlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzZXRfbW9udGhseV9jb3VudGVyIiwiZGVzYyI6IlJlc2V0IHRoZSBtb250aGx5IHdpdGhkcmF3YWwgdHJhY2tlciAoY2FsbGVkIGF0IG1vbnRoIHN0YXJ0KS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3Jldmlld2VyIiwiZGVzYyI6IkFkZCBhIG5ldyByZXZpZXdlciAoYWRtaW4gb25seSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXZpZXdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfcmV2aWV3ZXIiLCJkZXNjIjoiUmVtb3ZlIGEgcmV2aWV3ZXIgKGFkbWluIG9ubHkpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV2aWV3ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2RvbmF0aW9ucyIsImRlc2MiOiJSZXR1cm4gdGhlIHRvdGFsIGRvbmF0aW9ucyBoZWxkIGluIHRoZSB2YXVsdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF93aXRoZHJhd25fdGhpc19tb250aCIsImRlc2MiOiJSZXR1cm4gYW1vdW50IHdpdGhkcmF3biB0aGlzIG1vbnRoIGZvciBBSSBiaWxsaW5nLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FjY2VwdGVkX2Fzc2V0X2lkIiwiZGVzYyI6IlJldHVybiB0aGUgYWNjZXB0ZWQgc3RhYmxlY29pbiBBU0EgSUQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY291cnNlX2VzY3Jvd19hbW91bnQiLCJkZXNjIjoiUmV0dXJuIHRoZSBlc2Nyb3dlZCBhbW91bnQgZm9yIGEgY291cnNlICgwIGlmIG5vbmUpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb3Vyc2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb3Vyc2VfZXNjcm93X2FwcHJvdmVkIiwiZGVzYyI6IlJldHVybiB3aGV0aGVyIGEgY291cnNlIGVzY3JvdyBoYXMgYmVlbiBhcHByb3ZlZCAoMSkgb3Igbm90ICgwKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY291cnNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19yZXZpZXdlciIsImRlc2MiOiJDaGVjayBpZiBhbiBhZGRyZXNzIGlzIGEgcmV2aWV3ZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNTldLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1Ml0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgcHJvY2Vzc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM5XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEzXSwiZXJyb3JNZXNzYWdlIjoiQXNzZXQgZG9lcyBub3QgbWF0Y2ggYWNjZXB0ZWQgQVNBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYwXSwiZXJyb3JNZXNzYWdlIjoiQ291cnNlIGFscmVhZHkgcGVuZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0MSw3NTBdLCJlcnJvck1lc3NhZ2UiOiJFc2Nyb3cgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGRvbmF0ZWQgZnVuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjVdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgZnVuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzldLCJlcnJvck1lc3NhZ2UiOiJNdXN0IGRvbmF0ZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzVdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTRdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYSByZXZpZXdlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Miw5NDQsOTg1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIG9wdCBpbiB0byBhc3NldHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzAsNzM5XSwiZXJyb3JNZXNzYWdlIjoiT25seSByZXZpZXdlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTUsOTAwXSwiZXJyb3JNZXNzYWdlIjoiT25seSB0cmVhc3VyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2OCw2NjAsODMzXSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgQVNBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA5LDQ2Niw2NTYsODI5LDEwNDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjY2VwdGVkX2Fzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MCw0MDMsOTQyLDk4M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib290c3RyYXBwZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcwLDEwNzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd19hbW91bnQgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ5LDExMTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd19hcHByb3ZlZCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODMsNTQzLDcwMCw4MTksMTAyMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZG9uYXRpb25zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxMCw4OThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRyZWFzdXJ5X3dhbGxldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NjQsMTAzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud2l0aGRyYXduX3RoaXNfbW9udGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA2LDUyNCw5MzYsOTc3LDExMzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE0LDM5Niw1MTYsNTMyLDYxMyw2MjEsNzMyLDc5Miw4MDAsMTA1OCwxMDk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3hmWkc5dVlYUnBiMjV6SWlBaVlXTmpaWEIwWldSZllYTnpaWFJmYVdRaUlDSmhaRzFwYmlJZ01IZ3hOVEZtTjJNM05TQWlkMmwwYUdSeVlYZHVYM1JvYVhOZmJXOXVkR2dpSUNKMGNtVmhjM1Z5ZVY5M1lXeHNaWFFpSURCNE56STFaaUF3ZURZMU5qRTFaaUF3ZURZMU56QTFaaUFpWW05dmRITjBjbUZ3Y0dWa0lpQXdlRFkxTnpNMVppQXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3pNUzB6TWdvZ0lDQWdMeThnSXlEaWxJRGlsSUFnUjJ4dlltRnNJSE4wWVhSbElPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlrYjI1aGRHbHZibk1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMlJ2Ym1GMGFXOXVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pNekNpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVYM2RoYkd4bGRDQTlJRUZqWTI5MWJuUW9LUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkSEpsWVhOMWNubGZkMkZzYkdWMElnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qTTBDaUFnSUNBdkx5QnpaV3htTG1GalkyVndkR1ZrWDJGemMyVjBYMmxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFkyTmxjSFJsWkY5aGMzTmxkRjlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qTTFDaUFnSUNBdkx5QnpaV3htTG5kcGRHaGtjbUYzYmw5MGFHbHpYMjF2Ym5Sb0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjNhWFJvWkhKaGQyNWZkR2hwYzE5dGIyNTBhQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pNMkNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUlEMGdRV05qYjNWdWRDZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaRzFwYmlJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRvek53b2dJQ0FnTHk4Z2MyVnNaaTVpYjI5MGMzUnlZWEJ3WldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltSnZiM1J6ZEhKaGNIQmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNamNLSUNBZ0lDOHZJR05zWVhOeklFVmtkV05oZEdWRGFHRnBibFpoZFd4MEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXlDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbVZqTnpaa09EY2dNSGhrWmpVMFpUaGhZU0F3ZUdJNU1UYzNPV1JqSURCNE9UUmtNemt6WTJJZ01IZzBaR1F4WWpFeU1pQXdlRFU0WVRsbU1UVTVJREI0WXpkbU1HRTFPRElnTUhobVptWmtaR1pqTmlBd2VHRmlNREZtWXpaaklEQjRPVEU1WkdabU56RWdNSGc1Wm1RMll6azNPQ0F3ZUdZNU4ySmhaV001SURCNFpUZGhOVGd5WW1NZ01IZzVORFEwTVdJMk15QXdlR0ZqWldNeVlXUm1JREI0TURNME1qWXhOVFFnTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW05d2RGOXBibDkwYjE5aGMzTmxkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVndiM05wZEY5a2IyNWhkR2x2YmloaGVHWmxjaWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaWEYxWlhOMFgyTnZkWEp6WlY5d1lYbHZkWFFvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVZmWTI5MWNuTmxYM0JoZVc5MWRDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYW1WamRGOWpiM1Z5YzJWZmNHRjViM1YwS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjNhWFJvWkhKaGQxOXRiMjUwYUd4NVgyOXlZV05zWlY5aGJXOTFiblFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYTmxkRjl0YjI1MGFHeDVYMk52ZFc1MFpYSW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjl5WlhacFpYZGxjaWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiVzkyWlY5eVpYWnBaWGRsY2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGIzUmhiRjlrYjI1aGRHbHZibk1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzZHBkR2hrY21GM2JsOTBhR2x6WDIxdmJuUm9LQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aFkyTmxjSFJsWkY5aGMzTmxkRjlwWkNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZZMjkxY25ObFgyVnpZM0p2ZDE5aGJXOTFiblFvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDJOdmRYSnpaVjlsYzJOeWIzZGZZWEJ3Y205MlpXUW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWFYTmZjbVYyYVdWM1pYSW9ZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0lHOXdkRjlwYmw5MGIxOWhjM05sZENCa1pYQnZjMmwwWDJSdmJtRjBhVzl1SUhKbGNYVmxjM1JmWTI5MWNuTmxYM0JoZVc5MWRDQmhjSEJ5YjNabFgyTnZkWEp6WlY5d1lYbHZkWFFnY21WcVpXTjBYMk52ZFhKelpWOXdZWGx2ZFhRZ2QybDBhR1J5WVhkZmJXOXVkR2hzZVY5dmNtRmpiR1ZmWVcxdmRXNTBJSEpsYzJWMFgyMXZiblJvYkhsZlkyOTFiblJsY2lCaFpHUmZjbVYyYVdWM1pYSWdjbVZ0YjNabFgzSmxkbWxsZDJWeUlHZGxkRjkwYjNSaGJGOWtiMjVoZEdsdmJuTWdaMlYwWDNkcGRHaGtjbUYzYmw5MGFHbHpYMjF2Ym5Sb0lHZGxkRjloWTJObGNIUmxaRjloYzNObGRGOXBaQ0JuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUWdaMlYwWDJOdmRYSnpaVjlsYzJOeWIzZGZZWEJ3Y205MlpXUWdhWE5mY21WMmFXVjNaWElLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF5TWpvS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3lOd29nSUNBZ0x5OGdZMnhoYzNNZ1JXUjFZMkYwWlVOb1lXbHVWbUYxYkhRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR013WWpZME16VXlJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNUZaSFZqWVhSbFEyaGhhVzVXWVhWc2RDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TlRZS0lDQWdJQzh2SUhObGJHWXVkSEpsWVhOMWNubGZkMkZzYkdWMElEMGdkSEpsWVhOMWNubGZkMkZzYkdWMExtNWhkR2wyWlFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEhKbFlYTjFjbmxmZDJGc2JHVjBJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPalUzQ2lBZ0lDQXZMeUJ6Wld4bUxtRmpZMlZ3ZEdWa1gyRnpjMlYwWDJsa0lEMGdZV05qWlhCMFpXUmZZWE56WlhSZmFXUXVibUYwYVhabENpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFkyTmxjSFJsWkY5aGMzTmxkRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZOVGdLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzRnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFpHMXBiaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TlRrS0lDQWdJQzh2SUd4dlp5aGlJbFpoZFd4MFEzSmxZWFJsWkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU5qWXhOelUyWXpjME5ETTNNalkxTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVSV1IxWTJGMFpVTm9ZV2x1Vm1GMWJIUXVZbTl2ZEhOMGNtRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qWTJDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVQyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliMjkwYzNSeVlYQndaV1FnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRV3h5WldGa2VTQmliMjkwYzNSeVlYQndaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlZbTl2ZEhOMGNtRndjR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZiM1J6ZEhKaGNIQmxaQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYkhKbFlXUjVJR0p2YjNSemRISmhjSEJsWkFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qWTRDaUFnSUNBdkx5QnpaV3htTG5KbGRtbGxkMlZ5YzF0VWVHNHVjMlZ1WkdWeVhTQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlRGN5TldZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUbzJPUW9nSUNBZ0x5OGdjMlZzWmk1aWIyOTBjM1J5WVhCd1pXUWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUp2YjNSemRISmhjSEJsWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qY3dDaUFnSUNBdkx5QnNiMmNvWWlKQ2IyOTBjM1J5WVhCd1pXUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROREkyWmpabU56UTNNemMwTnpJMk1UY3dOekEyTlRZMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUbzJNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTGtWa2RXTmhkR1ZEYUdGcGJsWmhkV3gwTG05d2RGOXBibDkwYjE5aGMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RGOXBibDkwYjE5aGMzTmxkRG9LSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZOemNLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0c0lDSlBibXg1SUdGa2JXbHVJR05oYmlCdmNIUWdhVzRnZEc4Z1lYTnpaWFJ6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUJ2Y0hRZ2FXNGdkRzhnWVhOelpYUnpDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TnpnS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRDNXBaQ0E5UFNCelpXeG1MbUZqWTJWd2RHVmtYMkZ6YzJWMFgybGtMQ0FpUVhOelpYUWdaRzlsY3lCdWIzUWdiV0YwWTJnZ1lXTmpaWEIwWldRZ1FWTkJJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmpZMlZ3ZEdWa1gyRnpjMlYwWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZqWTJWd2RHVmtYMkZ6YzJWMFgybGtJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVhOelpYUWdaRzlsY3lCdWIzUWdiV0YwWTJnZ1lXTmpaWEIwWldRZ1FWTkJDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2T0RBdE9EVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZPRElLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPamd6Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZPREFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qZzBDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qZ3dMVGcxQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRvNE5nb2dJQ0FnTHk4Z2JHOW5LR0lpUVhOelpYUlBjSFJsWkVsdUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUXhOek0zTXpZMU56UTBaamN3TnpRMk5UWTBORGsyWlFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk56UUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzVGWkhWallYUmxRMmhoYVc1V1lYVnNkQzVrWlhCdmMybDBYMlJ2Ym1GMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2IzTnBkRjlrYjI1aGRHbHZiam9LSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNTRabVZ5WDJGemMyVjBMbWxrSUQwOUlITmxiR1l1WVdOalpYQjBaV1JmWVhOelpYUmZhV1FzSUNKWGNtOXVaeUJCVTBFaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVndkR1ZrWDJGemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpZMlZ3ZEdWa1gyRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhjbTl1WnlCQlUwRUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94TURVS0lDQWdJQzh2SUhCaGVXMWxiblF1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hNRFF0TVRBMkNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lIQmhlVzFsYm5RdVlYTnpaWFJmY21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lrMTFjM1FnYzJWdVpDQjBieUJqYjI1MGNtRmpkQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5kWE4wSUhObGJtUWdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GemMyVjBYMkZ0YjNWdWRDQStJREFzSUNKTmRYTjBJR1J2Ym1GMFpTQStJREFpQ2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQmtiMjVoZEdVZ1BpQXdDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRBNUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUnZibUYwYVc5dWN5QXJQU0J3WVhsdFpXNTBMbUZ6YzJWMFgyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyUnZibUYwYVc5dWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWtiMjVoZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWtiMjVoZEdsdmJuTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFeE1Bb2dJQ0FnTHk4Z2JHOW5LR0lpUkc5dVlYUnBiMjVTWldObGFYWmxaQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTkRabU5tVTJNVGMwTmprMlpqWmxOVEkyTlRZek5qVTJPVGMyTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZPVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1RlpIVmpZWFJsUTJoaGFXNVdZWFZzZEM1eVpYRjFaWE4wWDJOdmRYSnpaVjl3WVhsdmRYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhGMVpYTjBYMk52ZFhKelpWOXdZWGx2ZFhRNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVEUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qRXlNZ29nSUNBZ0x5OGdZMmxrSUQwZ1kyOTFjbk5sWDJsa0xtNWhkR2wyWlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRJekNpQWdJQ0F2THlCaGJYUWdQU0JoYlc5MWJuUXVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVEkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzEwSUQ0Z01Dd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElENGdNQ0lLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakV5TndvZ0lDQWdMeThnWVhOelpYSjBJR0Z0ZENBOFBTQnpaV3htTG5SdmRHRnNYMlJ2Ym1GMGFXOXVjeXdnSWtsdWMzVm1abWxqYVdWdWRDQmtiMjVoZEdWa0lHWjFibVJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyUnZibUYwYVc5dWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWtiMjVoZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1pHOXVZWFJsWkNCbWRXNWtjd29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFeU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOcFpDQnViM1FnYVc0Z2MyVnNaaTVsYzJOeWIzZGZjMlZzYkdWeUxDQWlRMjkxY25ObElHRnNjbVZoWkhrZ2NHVnVaR2x1WnlJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE5qVTNNelZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmRYSnpaU0JoYkhKbFlXUjVJSEJsYm1ScGJtY0tJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94TXpBS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M1gzTmxiR3hsY2x0amFXUmRJRDBnYzJWc2JHVnlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94TXpFS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M1gyRnRiM1Z1ZEZ0amFXUmRJRDBnWVcxMENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE5qVTJNVFZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hNeklLSUNBZ0lDOHZJSE5sYkdZdVpYTmpjbTkzWDJGd2NISnZkbVZrVzJOcFpGMGdQU0JWU1c1ME5qUW9NQ2tnSUNNZ01DQTlJSEJsYm1ScGJtY0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzJOVGN3TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94TXpNS0lDQWdJQzh2SUd4dlp5aGlJa052ZFhKelpWQmhlVzkxZEZKbGNYVmxjM1JsWkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME16Wm1OelUzTWpjek5qVTFNRFl4TnprMlpqYzFOelExTWpZMU56RTNOVFkxTnpNM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMa1ZrZFdOaGRHVkRhR0ZwYmxaaGRXeDBMbUZ3Y0hKdmRtVmZZMjkxY25ObFgzQmhlVzkxZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRndjSEp2ZG1WZlkyOTFjbk5sWDNCaGVXOTFkRG9LSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFME1nb2dJQ0FnTHk4Z1kybGtJRDBnWTI5MWNuTmxYMmxrTG01aGRHbDJaUW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFME13b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVYMmx6WDNKbGRtbGxkMlZ5S0ZSNGJpNXpaVzVrWlhJcExDQWlUMjVzZVNCeVpYWnBaWGRsY25NaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMTl5WlhacFpYZGxjZ29nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY21WMmFXVjNaWEp6Q2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1UUTBDaUFnSUNBdkx5QmhjM05sY25RZ1kybGtJR2x1SUhObGJHWXVaWE5qY205M1gzTmxiR3hsY2l3Z0lrVnpZM0p2ZHlCdWIzUWdabTkxYm1RaUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEWTFOek0xWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZjMk55YjNjZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVFExQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bGMyTnliM2RmWVhCd2NtOTJaV1JiWTJsa1hTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKQmJISmxZV1I1SUhCeWIyTmxjM05sWkNJS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnMk5UY3dOV1lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTmpjbTkzWDJGd2NISnZkbVZrSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2djSEp2WTJWemMyVmtDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRRMkNpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUXVhV1FnUFQwZ2MyVnNaaTVoWTJObGNIUmxaRjloYzNObGRGOXBaQ3dnSWxkeWIyNW5JRUZUUVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWTJObGNIUmxaRjloYzNObGRGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFkyTmxjSFJsWkY5aGMzTmxkRjlwWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGZHliMjVuSUVGVFFRb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakUwT0FvZ0lDQWdMeThnYzJWc2JHVnlJRDBnYzJWc1ppNWxjMk55YjNkZmMyVnNiR1Z5VzJOcFpGMEtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFME9Rb2dJQ0FnTHk4Z1lXMTBJRDBnYzJWc1ppNWxjMk55YjNkZllXMXZkVzUwVzJOcFpGMEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzJOVFl4TldZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGMyTnliM2RmWVcxdmRXNTBJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qRTFNUzB4TlRjS0lDQWdJQzh2SUNNZ1UyVnVaQ0J6ZEdGaWJHVmpiMmx1SUhSdklITmxiR3hsY2dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMyVnNiR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakUxTVMweE5USUtJQ0FnSUM4dklDTWdVMlZ1WkNCemRHRmliR1ZqYjJsdUlIUnZJSE5sYkd4bGNnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRVMkNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFMU1TMHhOVGNLSUNBZ0lDOHZJQ01nVTJWdVpDQnpkR0ZpYkdWamIybHVJSFJ2SUhObGJHeGxjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzJWc2JHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMWhiWFFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFMU9Rb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZGZZWEJ3Y205MlpXUmJZMmxrWFNBOUlGVkpiblEyTkNneEtTQWdJeUF4SUQwZ1lYQndjbTkyWldRZ0ppQndZV2xrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRZd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUnZibUYwYVc5dWN5QXRQU0JoYlhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWtiMjVoZEdsdmJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZaRzl1WVhScGIyNXpJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZaRzl1WVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE5qRUtJQ0FnSUM4dklHeHZaeWhpSWtOdmRYSnpaVUZ3Y0hKdmRtVmtJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF6Tm1ZM05UY3lOek0yTlRReE56QTNNRGN5Tm1ZM05qWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMa1ZrZFdOaGRHVkRhR0ZwYmxaaGRXeDBMbkpsYW1WamRGOWpiM1Z5YzJWZmNHRjViM1YwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnFaV04wWDJOdmRYSnpaVjl3WVhsdmRYUTZDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hOallLSUNBZ0lDOHZJR05wWkNBOUlHTnZkWEp6WlY5cFpDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTGw5cGMxOXlaWFpwWlhkbGNpaFVlRzR1YzJWdVpHVnlLU3dnSWs5dWJIa2djbVYyYVdWM1pYSnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJmYVhOZmNtVjJhV1YzWlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlISmxkbWxsZDJWeWN3b2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakUyT0FvZ0lDQWdMeThnWVhOelpYSjBJR05wWkNCcGJpQnpaV3htTG1WelkzSnZkMTl6Wld4c1pYSXNJQ0pGYzJOeWIzY2dibTkwSUdadmRXNWtJZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGcyTlRjek5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUlhOamNtOTNJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFM01Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVpYTmpjbTkzWDNObGJHeGxjbHRqYVdSZENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94TnpFS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1WelkzSnZkMTloYlc5MWJuUmJZMmxrWFFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURZMU5qRTFaZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVGN5Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVsYzJOeWIzZGZZWEJ3Y205MlpXUmJZMmxrWFFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURZMU56QTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hOek1LSUNBZ0lDOHZJR3h2WnloaUlrTnZkWEp6WlZKbGFtVmpkR1ZrSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRek5tWTNOVGN5TnpNMk5UVXlOalUyWVRZMU5qTTNORFkxTmpRS0lDQWdJR3h2WndvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qRTJNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTGtWa2RXTmhkR1ZEYUdGcGJsWmhkV3gwTG5kcGRHaGtjbUYzWDIxdmJuUm9iSGxmYjNKaFkyeGxYMkZ0YjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNYMjF2Ym5Sb2JIbGZiM0poWTJ4bFgyRnRiM1Z1ZERvS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qRTROQW9nSUNBZ0x5OGdZVzEwSUQwZ1lXMXZkVzUwWDI5M1pXUXVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNVGcxQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MblJ5WldGemRYSjVYM2RoYkd4bGRDd2dJazl1YkhrZ2RISmxZWE4xY25raUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkSEpsWVhOMWNubGZkMkZzYkdWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ5WldGemRYSjVYM2RoYkd4bGRDQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RISmxZWE4xY25rS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3hPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiWFFnUEQwZ2MyVnNaaTUwYjNSaGJGOWtiMjVoZEdsdmJuTXNJQ0pKYm5OMVptWnBZMmxsYm5RZ1puVnVaSE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlpHOXVZWFJwYjI1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUnZibUYwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1puVnVaSE1LSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGMzTmxkQzVwWkNBOVBTQnpaV3htTG1GalkyVndkR1ZrWDJGemMyVjBYMmxrTENBaVYzSnZibWNnUVZOQklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GalkyVndkR1ZrWDJGemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpZMlZ3ZEdWa1gyRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWM0p2Ym1jZ1FWTkJDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRnNUxURTVOQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzJWc1ppNTBjbVZoYzNWeWVWOTNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdGdGRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE9Ea0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pFNU13b2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveE9Ea3RNVGswQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MblJ5WldGemRYSjVYM2RoYkd4bGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVlXMTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG94T1RZS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlpHOXVZWFJwYjI1eklDMDlJR0Z0ZEFvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyUnZibUYwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TVRrM0NpQWdJQ0F2THlCelpXeG1MbmRwZEdoa2NtRjNibDkwYUdselgyMXZiblJvSUNzOUlHRnRkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luZHBkR2hrY21GM2JsOTBhR2x6WDIxdmJuUm9JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5kcGRHaGtjbUYzYmw5MGFHbHpYMjF2Ym5Sb0lHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV01nTkNBdkx5QWlkMmwwYUdSeVlYZHVYM1JvYVhOZmJXOXVkR2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qRTVPQW9nSUNBZ0x5OGdiRzluS0dJaVRXOXVkR2hzZVZkcGRHaGtjbUYzWVd3aUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HUTJaalpsTnpRMk9EWmpOemsxTnpZNU56UTJPRFkwTnpJMk1UYzNOakUyWXdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1UYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1UldSMVkyRjBaVU5vWVdsdVZtRjFiSFF1Y21WelpYUmZiVzl1ZEdoc2VWOWpiM1Z1ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ6WlhSZmJXOXVkR2hzZVY5amIzVnVkR1Z5T2dvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qSXdNd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNTBjbVZoYzNWeWVWOTNZV3hzWlhRc0lDSlBibXg1SUhSeVpXRnpkWEo1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnlaV0Z6ZFhKNVgzZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBjbVZoYzNWeWVWOTNZV3hzWlhRZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEhKbFlYTjFjbmtLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveU1EUUtJQ0FnSUM4dklITmxiR1l1ZDJsMGFHUnlZWGR1WDNSb2FYTmZiVzl1ZEdnZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luZHBkR2hrY21GM2JsOTBhR2x6WDIxdmJuUm9JZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpBMUNpQWdJQ0F2THlCc2IyY29ZaUpOYjI1MGFHeDVRMjkxYm5SbGNsSmxjMlYwSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSa05tWTJaVGMwTmpnMll6YzVORE0yWmpjMU5tVTNORFkxTnpJMU1qWTFOek0yTlRjMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3lNREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1RlpIVmpZWFJsUTJoaGFXNVdZWFZzZEM1aFpHUmZjbVYyYVdWM1pYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSZmNtVjJhV1YzWlhJNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNakE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakl4TWdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpd2dJazl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSE5sYkdZdWNtVjJhV1YzWlhKelczSmxkbWxsZDJWeUxtNWhkR2wyWlYwZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzNNalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNakUwQ2lBZ0lDQXZMeUJzYjJjb1lpSlNaWFpwWlhkbGNrRmtaR1ZrSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeU5qVTNOalk1TmpVM056WTFOekkwTVRZME5qUTJOVFkwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveU1Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzVGWkhWallYUmxRMmhoYVc1V1lYVnNkQzV5WlcxdmRtVmZjbVYyYVdWM1pYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlcxdmRtVmZjbVYyYVdWM1pYSTZDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpFMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG95TWpFS0lDQWdJQzh2SUdGemMyVnlkQ0JoWkdSeUlHbHVJSE5sYkdZdWNtVjJhV1YzWlhKekxDQWlUbTkwSUdFZ2NtVjJhV1YzWlhJaUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE56STFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmhJSEpsZG1sbGQyVnlDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpJeUNpQWdJQ0F2THlCa1pXd2djMlZzWmk1eVpYWnBaWGRsY25OYllXUmtjbDBLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWldSMVkyRjBaV05vWVdsdVgzWmhkV3gwTG5CNU9qSXlNd29nSUNBZ0x5OGdiRzluS0dJaVVtVjJhV1YzWlhKU1pXMXZkbVZrSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeU5qVTNOalk1TmpVM056WTFOekkxTWpZMU5tUTJaamMyTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNakUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdVJXUjFZMkYwWlVOb1lXbHVWbUYxYkhRdVoyVjBYM1J2ZEdGc1gyUnZibUYwYVc5dWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MGIzUmhiRjlrYjI1aGRHbHZibk02Q2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1qTXdDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlrYjI1aGRHbHZibk1wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlpHOXVZWFJwYjI1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUnZibUYwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3lNamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzVGWkhWallYUmxRMmhoYVc1V1lYVnNkQzVuWlhSZmQybDBhR1J5WVhkdVgzUm9hWE5mYlc5dWRHaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmQybDBhR1J5WVhkdVgzUm9hWE5mYlc5dWRHZzZDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpNMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUzYVhSb1pISmhkMjVmZEdocGMxOXRiMjUwYUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ozYVhSb1pISmhkMjVmZEdocGMxOXRiMjUwYUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTNhWFJvWkhKaGQyNWZkR2hwYzE5dGIyNTBhQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG95TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1RlpIVmpZWFJsUTJoaGFXNVdZWFZzZEM1blpYUmZZV05qWlhCMFpXUmZZWE56WlhSZmFXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZllXTmpaWEIwWldSZllYTnpaWFJmYVdRNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNalF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWhZMk5sY0hSbFpGOWhjM05sZEY5cFpDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFkyTmxjSFJsWkY5aGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhZMk5sY0hSbFpGOWhjM05sZEY5cFpDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdWa2RXTmhkR1ZqYUdGcGJsOTJZWFZzZEM1d2VUb3lNemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzVGWkhWallYUmxRMmhoYVc1V1lYVnNkQzVuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUTZDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveU5EVUtJQ0FnSUM4dklHTnBaQ0E5SUdOdmRYSnpaVjlwWkM1dVlYUnBkbVVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveU5EWUtJQ0FnSUM4dklHbG1JR05wWkNCcGJpQnpaV3htTG1WelkzSnZkMTloYlc5MWJuUTZDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjROalUyTVRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNalEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWxjMk55YjNkZllXMXZkVzUwVzJOcFpGMHBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6WTNKdmQxOWhiVzkxYm5RZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDZ3BuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUmZZV1owWlhKZmFXNXNhVzVsWkY5bFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdVJXUjFZMkYwWlVOb1lXbHVWbUYxYkhRdVoyVjBYMk52ZFhKelpWOWxjMk55YjNkZllXMXZkVzUwUURRNkNpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNalF5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjlqYjNWeWMyVmZaWE5qY205M1gyRnRiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1qUTRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pJME1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlHZGxkRjlqYjNWeWMyVmZaWE5qY205M1gyRnRiM1Z1ZEY5aFpuUmxjbDlwYm14cGJtVmtYMlZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzVGWkhWallYUmxRMmhoYVc1V1lYVnNkQzVuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloYlc5MWJuUkFOQW9LQ2k4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNUZaSFZqWVhSbFEyaGhhVzVXWVhWc2RDNW5aWFJmWTI5MWNuTmxYMlZ6WTNKdmQxOWhjSEJ5YjNabFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5amIzVnljMlZmWlhOamNtOTNYMkZ3Y0hKdmRtVmtPZ29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pJMU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1qVXpDaUFnSUNBdkx5QmphV1FnUFNCamIzVnljMlZmYVdRdWJtRjBhWFpsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1qVTBDaUFnSUNBdkx5QnBaaUJqYVdRZ2FXNGdjMlZzWmk1bGMyTnliM2RmWVhCd2NtOTJaV1E2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TmpVM01EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUmZZMjkxY25ObFgyVnpZM0p2ZDE5aGNIQnliM1psWkY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR1ZrZFdOaGRHVmphR0ZwYmw5MllYVnNkQzV3ZVRveU5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1WelkzSnZkMTloY0hCeWIzWmxaRnRqYVdSZEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxjMk55YjNkZllYQndjbTkyWldRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDZ3BuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloY0hCeWIzWmxaRjloWm5SbGNsOXBibXhwYm1Wa1gyVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNUZaSFZqWVhSbFEyaGhhVzVXWVhWc2RDNW5aWFJmWTI5MWNuTmxYMlZ6WTNKdmQxOWhjSEJ5YjNabFpFQTBPZ29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pJMU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSZlkyOTFjbk5sWDJWelkzSnZkMTloY0hCeWIzWmxaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpVMkNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z1pXUjFZMkYwWldOb1lXbHVYM1poZFd4MExuQjVPakkxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOWpiM1Z5YzJWZlpYTmpjbTkzWDJGd2NISnZkbVZrWDJGbWRHVnlYMmx1YkdsdVpXUmZaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMa1ZrZFdOaGRHVkRhR0ZwYmxaaGRXeDBMbWRsZEY5amIzVnljMlZmWlhOamNtOTNYMkZ3Y0hKdmRtVmtRRFFLQ2dvdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVSV1IxWTJGMFpVTm9ZV2x1Vm1GMWJIUXVhWE5mY21WMmFXVjNaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxOXlaWFpwWlhkbGNqb0tJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG95TlRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCbFpIVmpZWFJsWTJoaGFXNWZkbUYxYkhRdWNIazZNall4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSE5sYkdZdVgybHpYM0psZG1sbGQyVnlLR0ZrWkhKbGMzTXVibUYwYVhabEtTa0tJQ0FnSUdOaGJHeHpkV0lnWDJselgzSmxkbWxsZDJWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJsWkhWallYUmxZMmhoYVc1ZmRtRjFiSFF1Y0hrNk1qVTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVSV1IxWTJGMFpVTm9ZV2x1Vm1GMWJIUXVYMmx6WDNKbGRtbGxkMlZ5S0dGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2w5cGMxOXlaWFpwWlhkbGNqb0tJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG95TmpVdE1qWTJDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5cGMxOXlaWFpwWlhkbGNpaHpaV3htTENCaFpHUnlaWE56T2lCQlkyTnZkVzUwS1NBdFBpQmliMjlzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmxaSFZqWVhSbFkyaGhhVzVmZG1GMWJIUXVjSGs2TWpZNENpQWdJQ0F2THlCcFppQmhaR1J5WlhOeklHbHVJSE5sYkdZdWNtVjJhV1YzWlhKek9nb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEY3lOV1lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklGOXBjMTl5WlhacFpYZGxjbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHVmtkV05oZEdWamFHRnBibDkyWVhWc2RDNXdlVG95TmprS0lDQWdJQzh2SUhKbGRIVnliaUJVY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwYzNWaUNncGZhWE5mY21WMmFXVjNaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdaV1IxWTJGMFpXTm9ZV2x1WDNaaGRXeDBMbkI1T2pJM01Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUVaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lNRDNSdmRHRnNYMlJ2Ym1GMGFXOXVjeEZoWTJObGNIUmxaRjloYzNObGRGOXBaQVZoWkcxcGJnUVZIM3gxRkhkcGRHaGtjbUYzYmw5MGFHbHpYMjF2Ym5Sb0QzUnlaV0Z6ZFhKNVgzZGhiR3hsZEFKeVh3TmxZVjhEWlhCZkRHSnZiM1J6ZEhKaGNIQmxaQU5sYzE4SUFBQUFBQUFBQUFBeEdFQUFGeWdpWnljRk1nTm5LU0puSndRaVp5b3lBMmNuQ1NKbk1Sa1VSREVZUVFCNGdoQUV2c2R0aHdUZlZPaXFCTGtYZWR3RWxOT1R5d1JOMGJFaUJGaXA4VmtFeC9DbGdnVC8vZC9HQktzQi9Hd0VrWjMvY1FTZjFzbDRCUGw3cnNrRTU2V0N2QVNVUkJ0akJLenNLdDhFQTBKaFZEWWFBSTRRQUQwQWFRQ2xBT0VCUWdHNUFmVUNZQUtGQXE0QzNRTG9BdlFDL3dNa0Ewa0FnQVRBdGtOU05ob0FqZ0VBQVFBMkdnRkpGU1VTUkRZYUFra1ZKQkpFSndWUEFtY1hLVXhuS2pFQVo0QU1WbUYxYkhSRGNtVmhkR1Zrc0NORE1RQWlLbVZFRWtRaUp3bGxSQlJFSndZeEFGQWpGcjhuQ1NObmdBeENiMjkwYzNSeVlYQndaV1N3STBNMkdnRkpGU1FTUkJjeEFDSXFaVVFTUkNJcFpVUkxBUkpFc1RJS0lySVNzaFN5RVlFRXNoQWlzZ0d6Z0F4QmMzTmxkRTl3ZEdWa1NXNndJME14RmlNSlNUZ1FnUVFTUkVrNEVTSXBaVVFTUkVrNEZESUtFa1E0RWtsRUlpaGxSQWdvVEdlQUVFUnZibUYwYVc5dVVtVmpaV2wyWldTd0kwTTJHZ0ZKRlNRU1JEWWFBa2tWSlJKRU5ob0RTUlVrRWtSUEFoZE1GMGxFSWlobFJFc0JEMFJNRmljS1N3RlFTYjFGQVJSRVR3Ty9Kd2RMQVZCUEFoYS9Kd2hNVUNJV3Y0QVZRMjkxY25ObFVHRjViM1YwVW1WeGRXVnpkR1Zrc0NORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkJkTUZ6RUFpQUlIUkJZbkNrc0JVRW05UlFGRUp3aExBbEJKdmtRWEZFUWlLV1ZFU3dRU1JFeStTQ2NIVHdOUXZrUVhzVW15RWt5eUZFOENzaEdCQkxJUUlySUJzeU1XVHdKTXZ5SW9aVVJNQ1NoTVo0QU9RMjkxY25ObFFYQndjbTkyWldTd0kwTTJHZ0ZKRlNRU1JCY3hBSWdCbWtRV0p3cExBVkJKdlVVQlJMeElKd2RMQVZDOFNDY0lURkM4U0lBT1EyOTFjbk5sVW1WcVpXTjBaV1N3STBNMkdnRkpGU1FTUkRZYUFra1ZKQkpFRjB3WE1RQWlKd1ZsUkV4TEFSSkVJaWhsUkVzQ1N3RU9SQ0lwWlVSTEJCSkVzVXNDc2hKTXNoUlBBcklSZ1FTeUVDS3lBYk5MQVFrb1RHY2lKd1JsUkFnbkJFeG5nQkZOYjI1MGFHeDVWMmwwYUdSeVlYZGhiTEFqUXpFQUlpY0ZaVVFTUkNjRUltZUFFMDF2Ym5Sb2JIbERiM1Z1ZEdWeVVtVnpaWFN3STBNMkdnRkpGU1VTUkRFQUlpcGxSQkpFSndaTVVDTVd2NEFOVW1WMmFXVjNaWEpCWkdSbFpMQWpRellhQVVrVkpSSkVNUUFpS21WRUVrUW5Ca3hRU2IxRkFVUzhTSUFQVW1WMmFXVjNaWEpTWlcxdmRtVmtzQ05ESWlobFJCWXJURkN3STBNaUp3UmxSQllyVEZDd0kwTWlLV1ZFRml0TVVMQWpRellhQVVrVkpCSkVGeFluQjB4UVNiMUZBVUVBQzBtK1JCY1dLMHhRc0NOREp3dEMvL1UyR2dGSkZTUVNSQmNXSndoTVVFbTlSUUZCQUF0SnZrUVhGaXRNVUxBalF5Y0xRdi8xTmhvQlNSVWxFa1NJQUEyQUFRQWlUd0pVSzB4UXNDTkRpZ0VCSndhTC8xQzlSUUZCQUFJamlTS0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
