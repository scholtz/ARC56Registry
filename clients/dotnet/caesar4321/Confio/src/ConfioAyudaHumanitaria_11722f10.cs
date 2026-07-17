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

namespace Arc56.Generated.caesar4321.Confio.ConfioAyudaHumanitaria_11722f10
{


    //
    // cUSD humanitarian aid vault.
    //
    //    Donations are public cUSD asset transfers into the app account. Releases are
    //    admin/operator-triggered cUSD transfers to approved volunteers. Proof links
    //    are intentionally off-chain and added by the backend after the volunteer has
    //    bought and distributed supplies.
    //    
    //
    public class ConfioAyudaHumanitariaProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConfioAyudaHumanitariaProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="cusd_asset_id"> </param>
        /// <param name="admin"> </param>
        /// <param name="release_operator"> </param>
        public async Task Create(ulong cusd_asset_id, Algorand.Address admin, Algorand.Address release_operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 30, 115, 130 };
            var cusd_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cusd_asset_idAbi.From(cusd_asset_id);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var release_operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); release_operatorAbi.From(release_operator);

            var result = await base.CallApp(new List<object> { abiHandle, cusd_asset_idAbi, adminAbi, release_operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong cusd_asset_id, Algorand.Address admin, Algorand.Address release_operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 30, 115, 130 };
            var cusd_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cusd_asset_idAbi.From(cusd_asset_id);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var release_operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); release_operatorAbi.From(release_operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, cusd_asset_idAbi, adminAbi, release_operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInCusd(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 194, 106, 179 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInCusd_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 194, 106, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="donation"> </param>
        /// <param name="donation_ref"> </param>
        public async Task Donate(AssetTransferTransaction donation, string donation_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { donation });
            byte[] abiHandle = { 178, 98, 143, 227 };
            var donation_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); donation_refAbi.From(donation_ref);

            var result = await base.CallApp(new List<object> { abiHandle, donation, donation_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Donate_Transactions(AssetTransferTransaction donation, string donation_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { donation });
            byte[] abiHandle = { 178, 98, 143, 227 };
            var donation_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); donation_refAbi.From(donation_ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, donation, donation_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="release_ref"> </param>
        public async Task Release(Algorand.Address recipient, ulong amount, string release_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 252, 175, 103 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var release_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); release_refAbi.From(release_ref);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi, release_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Release_Transactions(Algorand.Address recipient, ulong amount, string release_ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 252, 175, 103 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var release_refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); release_refAbi.From(release_ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi, release_refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task SetAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 242, 193, 190 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 242, 193, 190 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_operator"> </param>
        public async Task SetReleaseOperator(Algorand.Address new_operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 108, 68, 155 };
            var new_operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_operatorAbi.From(new_operator);

            var result = await base.CallApp(new List<object> { abiHandle, new_operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetReleaseOperator_Transactions(Algorand.Address new_operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 108, 68, 155 };
            var new_operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_operatorAbi.From(new_operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        public async Task EmergencyWithdraw(Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 171, 83, 152 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(Algorand.Address recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 171, 83, 152 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uZmlvQXl1ZGFIdW1hbml0YXJpYSIsImRlc2MiOiJjVVNEIGh1bWFuaXRhcmlhbiBhaWQgdmF1bHQuXG5cbiAgICBEb25hdGlvbnMgYXJlIHB1YmxpYyBjVVNEIGFzc2V0IHRyYW5zZmVycyBpbnRvIHRoZSBhcHAgYWNjb3VudC4gUmVsZWFzZXMgYXJlXG4gICAgYWRtaW4vb3BlcmF0b3ItdHJpZ2dlcmVkIGNVU0QgdHJhbnNmZXJzIHRvIGFwcHJvdmVkIHZvbHVudGVlcnMuIFByb29mIGxpbmtzXG4gICAgYXJlIGludGVudGlvbmFsbHkgb2ZmLWNoYWluIGFuZCBhZGRlZCBieSB0aGUgYmFja2VuZCBhZnRlciB0aGUgdm9sdW50ZWVyIGhhc1xuICAgIGJvdWdodCBhbmQgZGlzdHJpYnV0ZWQgc3VwcGxpZXMuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXNkX2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWxlYXNlX29wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl9jdXNkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRvbmF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvbmF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkb25hdGlvbl9yZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlbGVhc2VfcmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3JlbGVhc2Vfb3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lfd2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjYsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MTksNjAyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTIsMzUzLDQ0OSw1NzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmN1c2RfYXNzZXRfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kb25hdGlvbl9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODUsMzM3LDQzOSw1NjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlbGVhc2VfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWxlYXNlX29wZXJhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZG9uYXRlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3JlbGVhc2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNiw0MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzMsNDEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzOSwyNDcsMzkwLDUxNyw1MzMsNTQ5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMCwzOTksNTU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNHRjFjMlZrSWlBaVkzVnpaRjloYzNObGRGOXBaQ0lnSW1Ga2JXbHVJaUFpY21Wc1pXRnpaVjl2Y0dWeVlYUnZjaUlnSW5SdmRHRnNYMlJ2Ym1GMFpXUWlJQ0owYjNSaGJGOXlaV3hsWVhObFpDSWdJbVJ2Ym1GMGFXOXVYMk52ZFc1MElpQWljbVZzWldGelpWOWpiM1Z1ZENJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5b2RXMWhibWwwWVhKcFlXNHZZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1Wm1sdlFYbDFaR0ZJZFcxaGJtbDBZWEpwWVNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEJsT0RFNE56SWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQXlDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU16b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dVptbHZRWGwxWkdGSWRXMWhibWwwWVhKcFlTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFUyWXpJMllXSXpJREI0WWpJMk1qaG1aVE1nTUhnMU4yWmpZV1kyTnlBd2VEQXhOemhtT1RSaUlEQjRNV0kxTWpsa1pUZ2dNSGcwTkdZeVl6RmlaU0F3ZURabE5tTTBORGxpSURCNE5qZGhZalV6T1RnZ0x5OGdiV1YwYUc5a0lDSnZjSFJmYVc1ZlkzVnpaQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlaRzl1WVhSbEtHRjRabVZ5TEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV3hsWVhObEtHRmtaSEpsYzNNc2RXbHVkRFkwTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSndZWFZ6WlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFc1d1lYVnpaU2dwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJGa2JXbHVLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYM0psYkdWaGMyVmZiM0JsY21GMGIzSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGJXVnlaMlZ1WTNsZmQybDBhR1J5WVhjb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzl3ZEY5cGJsOWpkWE5rSUdSdmJtRjBaU0J5Wld4bFlYTmxJSEJoZFhObElIVnVjR0YxYzJVZ2MyVjBYMkZrYldsdUlITmxkRjl5Wld4bFlYTmxYMjl3WlhKaGRHOXlJR1Z0WlhKblpXNWplVjkzYVhSb1pISmhkd29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkRiMjVtYVc5QmVYVmtZVWgxYldGdWFYUmhjbWxoS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNREZsTnpNNE1pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MWNHUmhkR1ZmY205MWRHVkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZPVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTXlBdkx5QlZjR1JoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlIVndaR0YwWlFvS0NpOHZJR2gxYldGdWFYUmhjbWxoYmk1aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1RGIyNW1hVzlCZVhWa1lVaDFiV0Z1YVhSaGNtbGhMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk1qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SjNKbGNYVnBjbVVuS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPakkwQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1SUQwZ1lXUnRhVzRLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNXlaV3hsWVhObFgyOXdaWEpoZEc5eUlEMGdjbVZzWldGelpWOXZjR1Z5WVhSdmNnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVnNaV0Z6WlY5dmNHVnlZWFJ2Y2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pJMkNpQWdJQ0F2THlCelpXeG1MbU4xYzJSZllYTnpaWFJmYVdRZ1BTQmpkWE5rWDJGemMyVjBYMmxrQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqZFhOa1gyRnpjMlYwWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk1qY0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaRzl1WVhSbFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkRzkwWVd4ZlpHOXVZWFJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG95T0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5eVpXeGxZWE5sWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmY21Wc1pXRnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZNamtLSUNBZ0lDOHZJSE5sYkdZdVpHOXVZWFJwYjI1ZlkyOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1SdmJtRjBhVzl1WDJOdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qTXdDaUFnSUNBdkx5QnpaV3htTG5KbGJHVmhjMlZmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbkpsYkdWaGMyVmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5b2RXMWhibWwwWVhKcFlXNHZZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVjSGs2TXpFS0lDQWdJQzh2SUhObGJHWXVjR0YxYzJWa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5b2RXMWhibWwwWVhKcFlXNHZZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVjSGs2TWpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlKM0psY1hWcGNtVW5LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHaDFiV0Z1YVhSaGNtbGhiaTVoZVhWa1lWOW9kVzFoYm1sMFlYSnBZUzVEYjI1bWFXOUJlWFZrWVVoMWJXRnVhWFJoY21saExtOXdkRjlwYmw5amRYTmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCMFgybHVYMk4xYzJRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pNMUNpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMkZrYldsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pNMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXdZWFZ6WldRZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUb3pOeTAwTVFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVqZFhOa1gyRnpjMlYwWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPak00Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkzVnpaRjloYzNObGRGOXBaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM1Z6WkY5aGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpkWE5rWDJGemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUb3pPUW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pRd0NpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk16Y0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pNM0xUUXhDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtTjFjMlJmWVhOelpYUmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdoMWJXRnVhWFJoY21saGJpNWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNURiMjVtYVc5QmVYVmtZVWgxYldGdWFYUmhjbWxoTG1SdmJtRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SdmJtRjBaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk15QXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPalExQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1d1lYVnpaV1FnUFQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRYTmxaQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyaDFiV0Z1YVhSaGNtbGhiaTloZVhWa1lWOW9kVzFoYm1sMFlYSnBZUzV3ZVRvME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdSdmJtRjBhVzl1TG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk5EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCa2IyNWhkR2x2Ymk1NFptVnlYMkZ6YzJWMExtbGtJRDA5SUhObGJHWXVZM1Z6WkY5aGMzTmxkRjlwWkFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqZFhOa1gyRnpjMlYwWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU4xYzJSZllYTnpaWFJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPalE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdaRzl1WVhScGIyNHVZWE56WlhSZllXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcENpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZORGtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWkc5dVlYUmxaQ0FyUFNCa2IyNWhkR2x2Ymk1aGMzTmxkRjloYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjlrYjI1aGRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlJ2Ym1GMFpXUWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYjNSaGJGOWtiMjVoZEdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk5UQUtJQ0FnSUM4dklITmxiR1l1Wkc5dVlYUnBiMjVmWTI5MWJuUWdLejBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlaRzl1WVhScGIyNWZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaRzl1WVhScGIyNWZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOaUF2THlBaVpHOXVZWFJwYjI1ZlkyOTFiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG8wTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5Qm9kVzFoYm1sMFlYSnBZVzR1WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1UTI5dVptbHZRWGwxWkdGSWRXMWhibWwwWVhKcFlTNXlaV3hsWVhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZzWldGelpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk5USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qRXdOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmlCdmNpQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVjbVZzWldGelpWOXZjR1Z5WVhSdmNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5Wld4bFlYTmxYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVnNaV0Z6WlY5dmNHVnlZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV3hsWVhObFgyOXdaWEpoZEc5eUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsYkdWaGMyVmZZbTl2YkY5bVlXeHpaVUEwQ2dweVpXeGxZWE5sWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuSmxiR1ZoYzJWZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUb3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0Z2IzSWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbkpsYkdWaGMyVmZiM0JsY21GMGIzSUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzFOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y0dGMWMyVmtJRDA5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhWelpXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5b2RXMWhibWwwWVhKcFlXNHZZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVjSGs2TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pVM0xUWXhDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtTjFjMlJmWVhOelpYUmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyaDFiV0Z1YVhSaGNtbGhiaTloZVhWa1lWOW9kVzFoYm1sMFlYSnBZUzV3ZVRvMU9Bb2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbU4xYzJSZllYTnpaWFJmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OMWMyUmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNWelpGOWhjM05sZEY5cFpDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrYVdjZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyaDFiV0Z1YVhSaGNtbGhiaTloZVhWa1lWOW9kVzFoYm1sMFlYSnBZUzV3ZVRvMU53b2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5b2RXMWhibWwwWVhKcFlXNHZZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVjSGs2TlRjdE5qRUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkzVnpaRjloYzNObGRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5Y21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyaDFiV0Z1YVhSaGNtbGhiaTloZVhWa1lWOW9kVzFoYm1sMFlYSnBZUzV3ZVRvMk1nb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXlaV3hsWVhObFpDQXJQU0JoYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRjl5Wld4bFlYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl5Wld4bFlYTmxaQ0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNYM0psYkdWaGMyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZOak1LSUNBZ0lDOHZJSE5sYkdZdWNtVnNaV0Z6WlY5amIzVnVkQ0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p5Wld4bFlYTmxYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsYkdWaGMyVmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOeUF2THlBaWNtVnNaV0Z6WlY5amIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPalV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21Wc1pXRnpaVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ5Wld4bFlYTmxYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJR2gxYldGdWFYUmhjbWxoYmk1aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1RGIyNW1hVzlCZVhWa1lVaDFiV0Z1YVhSaGNtbGhMbkJoZFhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0YxYzJVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMkZrYldsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pZNENpQWdJQ0F2THlCelpXeG1MbkJoZFhObFpDQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR2gxYldGdWFYUmhjbWxoYmk1aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1RGIyNW1hVzlCZVhWa1lVaDFiV0Z1YVhSaGNtbGhMblZ1Y0dGMWMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxYm5CaGRYTmxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzNNZ29nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDJGa2JXbHVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5aFpHMXBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzNNd29nSUNBZ0x5OGdjMlZzWmk1d1lYVnpaV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzNNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCb2RXMWhibWwwWVhKcFlXNHVZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVRMjl1Wm1sdlFYbDFaR0ZJZFcxaGJtbDBZWEpwWVM1elpYUmZZV1J0YVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmWVdSdGFXNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qYzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pjM0NpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMkZrYldsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pjNENpQWdJQ0F2THlCelpXeG1MbUZrYldsdUlEMGdibVYzWDJGa2JXbHVDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaRzFwYmlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pjMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR2gxYldGdWFYUmhjbWxoYmk1aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1RGIyNW1hVzlCZVhWa1lVaDFiV0Z1YVhSaGNtbGhMbk5sZEY5eVpXeGxZWE5sWDI5d1pYSmhkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYM0psYkdWaGMyVmZiM0JsY21GMGIzSTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pneUNpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMkZrYldsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFIVnRZVzVwZEdGeWFXRnVMMkY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMbkI1T2pnekNpQWdJQ0F2THlCelpXeG1MbkpsYkdWaGMyVmZiM0JsY21GMGIzSWdQU0J1WlhkZmIzQmxjbUYwYjNJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGJHVmhjMlZmYjNCbGNtRjBiM0lpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG80TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5Qm9kVzFoYm1sMFlYSnBZVzR1WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1UTI5dVptbHZRWGwxWkdGSWRXMWhibWwwWVhKcFlTNWxiV1Z5WjJWdVkzbGZkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsYldWeVoyVnVZM2xmZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPamcxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzROd29nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDJGa2JXbHVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5aFpHMXBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzRPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y0dGMWMyVmtJRDA5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhWelpXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJoMWJXRnVhWFJoY21saGJpOWhlWFZrWVY5b2RXMWhibWwwWVhKcFlTNXdlVG80T1FvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRDQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlvZFcxaGJtbDBZWEpwWVc0dllYbDFaR0ZmYUhWdFlXNXBkR0Z5YVdFdWNIazZPVEF0T1RRS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WTNWelpGOWhjM05sZEY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPamt4Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkzVnpaRjloYzNObGRGOXBaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM1Z6WkY5aGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpkWE5rWDJGemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzVNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OW9kVzFoYm1sMFlYSnBZVzR2WVhsMVpHRmZhSFZ0WVc1cGRHRnlhV0V1Y0hrNk9UQXRPVFFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZM1Z6WkY5aGMzTmxkRjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmgxYldGdWFYUmhjbWxoYmk5aGVYVmtZVjlvZFcxaGJtbDBZWEpwWVM1d2VUbzROUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCb2RXMWhibWwwWVhKcFlXNHVZWGwxWkdGZmFIVnRZVzVwZEdGeWFXRXVRMjl1Wm1sdlFYbDFaR0ZJZFcxaGJtbDBZWEpwWVM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPams0Q2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZllXUnRhVzRvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgyRmtiV2x1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YUhWdFlXNXBkR0Z5YVdGdUwyRjVkV1JoWDJoMWJXRnVhWFJoY21saExuQjVPamsyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2FIVnRZVzVwZEdGeWFXRnVMbUY1ZFdSaFgyaDFiV0Z1YVhSaGNtbGhMa052Ym1acGIwRjVkV1JoU0hWdFlXNXBkR0Z5YVdFdVgyRnpjMlZ5ZEY5aFpHMXBiaWdwSUMwK0lIWnZhV1E2Q2w5aGMzTmxjblJmWVdSdGFXNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhSFZ0WVc1cGRHRnlhV0Z1TDJGNWRXUmhYMmgxYldGdWFYUmhjbWxoTG5CNU9qRXdNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQkNZSUJuQmhkWE5sWkExamRYTmtYMkZ6YzJWMFgybGtCV0ZrYldsdUVISmxiR1ZoYzJWZmIzQmxjbUYwYjNJTmRHOTBZV3hmWkc5dVlYUmxaQTUwYjNSaGJGOXlaV3hsWVhObFpBNWtiMjVoZEdsdmJsOWpiM1Z1ZEExeVpXeGxZWE5sWDJOdmRXNTBnQVNnNkJoeU5ob0FqZ0VBVnpFWkZFUXhHRUVBUUlJSUJGYkNhck1Fc21LUDR3UlgvSzluQkFGNCtVc0VHMUtkNkFSRThzRytCRzVzUkpzRVo2dFRtRFlhQUk0SUFGTUFjd0M3QVNvQk1nRTZBVW9CV2dDQUJKQWVjNEkyR2dDT0FRQU1BREVaSlJJeEdCQkVRZ0Z5TmhvQlNSV0JDQkpFRnpZYUFra1ZKQkpFTmhvRFNSVWtFa1FxVHdKbksweG5LVXhuSndRaVp5Y0ZJbWNuQmlKbkp3Y2laeWdpWnlORGlBRTdJaWhsUkJSRXNTSXBaVVF5Q2lLeUVySVVzaEVsc2hBaXNnR3pJME14RmlNSlNUZ1FKUkpFTmhvQlNTSlpnUUlJVEJVU1JDSW9aVVFVUkVrNEZESUtFa1JKT0JFaUtXVkVFa1E0RWtsRUlpY0VaVVFJSndSTVp5SW5CbVZFSXdnbkJreG5JME0yR2dGSkZTUVNSRFlhQWtrVmdRZ1NSQmMyR2dOSklsbUJBZ2hNRlJKRU1RQWlLbVZFRWtBQUNqRUFJaXRsUkJKQkFEZ2pSQ0lvWlVRVVJFY0NSTEVpS1dWRVN3R3lFa3NEc2hTeUVTV3lFQ0t5QWJNaUp3VmxSQWduQlV4bklpY0haVVFqQ0NjSFRHY2pReUpDLzhXSUFHUW9JMmNqUTRnQVhDZ2laeU5ETmhvQlNSVWtFa1NJQUV3cVRHY2pRellhQVVrVkpCSkVpQUE4SzB4bkkwTTJHZ0ZKRlNRU1JEWWFBa2tWZ1FnU1JCZUlBQ0lpS0dWRUl4SkVTVVN4SWlsbFJMSVJzaEt5RkNXeUVDS3lBYk1qUTRnQUFpTkRNUUFpS21WRUVrU0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
