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

namespace Arc56.Generated.BGope025.meditrace.AccessManager_a81927d2
{


    public class AccessManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccessManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Called once on app creation. Sets the creator as admin.
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
        ///Grant a role (by bit) to an account. Admin-only.
        ///</summary>
        /// <param name="role">The role bit to grant (1, 2, 4, 8, or 16). </param>
        /// <param name="account">The target account address. </param>
        public async Task GrantRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 241, 164, 117 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 241, 164, 117 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a role (by bit) from an account. Admin-only.
        ///</summary>
        /// <param name="role">The role bit to revoke. </param>
        /// <param name="account">The target account address. </param>
        public async Task RevokeRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantManufacturerRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 232, 130, 85 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantManufacturerRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 232, 130, 85 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantDistributorRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 48, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantDistributorRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 48, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantPharmacyRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 126, 147, 202 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantPharmacyRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 126, 147, 202 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantTelemetryOracleRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 24, 126, 101 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantTelemetryOracleRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 24, 126, 101 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeManufacturerRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 79, 10, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeManufacturerRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 79, 10, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeDistributorRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 223, 157, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeDistributorRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 223, 157, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokePharmacyRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 104, 242, 186 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokePharmacyRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 104, 242, 186 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeTelemetryOracleRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 245, 181, 150 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeTelemetryOracleRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 245, 181, 150 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether an account holds a specific role.
        ///</summary>
        /// <param name="role">The role bit to check. </param>
        /// <param name="account">The account address. </param>
        public async Task<bool> HasRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 53, 240, 92 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 53, 240, 92 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the full role bitmask for an account.
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> GetRoleMask(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 249, 218, 116 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRoleMask_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 249, 218, 116 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the admin address.
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBY2Nlc3NNYW5hZ2VyIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJDYWxsZWQgb25jZSBvbiBhcHAgY3JlYXRpb24uIFNldHMgdGhlIGNyZWF0b3IgYXMgYWRtaW4uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJncmFudFJvbGUiLCJkZXNjIjoiR3JhbnQgYSByb2xlIChieSBiaXQpIHRvIGFuIGFjY291bnQuIEFkbWluLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjoiVGhlIHJvbGUgYml0IHRvIGdyYW50ICgxLCAyLCA0LCA4LCBvciAxNikuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOiJUaGUgdGFyZ2V0IGFjY291bnQgYWRkcmVzcy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InJldm9rZVJvbGUiLCJkZXNjIjoiUmV2b2tlIGEgcm9sZSAoYnkgYml0KSBmcm9tIGFuIGFjY291bnQuIEFkbWluLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjoiVGhlIHJvbGUgYml0IHRvIHJldm9rZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6IlRoZSB0YXJnZXQgYWNjb3VudCBhZGRyZXNzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ3JhbnRNYW51ZmFjdHVyZXJSb2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJncmFudERpc3RyaWJ1dG9yUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ3JhbnRQaGFybWFjeVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdyYW50VGVsZW1ldHJ5T3JhY2xlUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmV2b2tlTWFudWZhY3R1cmVyUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmV2b2tlRGlzdHJpYnV0b3JSb2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJyZXZva2VQaGFybWFjeVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InJldm9rZVRlbGVtZXRyeU9yYWNsZVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQ2hlY2sgd2hldGhlciBhbiBhY2NvdW50IGhvbGRzIGEgc3BlY2lmaWMgcm9sZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOiJUaGUgcm9sZSBiaXQgdG8gY2hlY2suIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOiJUaGUgYWNjb3VudCBhZGRyZXNzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoidHJ1ZSBpZiB0aGUgYWNjb3VudCBob2xkcyB0aGUgcm9sZS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0Um9sZU1hc2siLCJkZXNjIjoiUmV0dXJucyB0aGUgZnVsbCByb2xlIGJpdG1hc2sgZm9yIGFuIGFjY291bnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldEFkbWluIiwiZGVzYyI6IlJldHVybnMgdGhlIGFkbWluIGFkZHJlc3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhJRE15SURBS1lubDBaV05pYkc5amF5QXdlRGN5SURCNE5HWTFNalF4TkRNMFl6UTFOV1kwTWpRNU5UUWdNSGcxTURRNE5ERTFNalJrTldZME1qUTVOVFFnTUhnME5EUTVOVE0xTkRWbU5ESTBPVFUwSURCNE5HUTBOalV5TldZME1qUTVOVFFnTUhnMk1UWTBObVEyT1RabElEQjRNVFV4Wmpkak56VWdNSGcwTVRRME5HUTBPVFJsTldZME1qUTVOVFFLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBMkxqTUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENuQjFjMmhwYm5RZ05nb3FDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtLd3B6ZDJsMFkyZ2dLbU5oYkd4ZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0ttTnlaV0YwWlY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkFvS0trNVBWRjlKVFZCTVJVMUZUbFJGUkRvS0NTOHZJRlJvWlNCeVpYRjFaWE4wWldRZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR2x6SUdOdmJuUnlZV04wTGlCQmNtVWdlVzkxSUhWemFXNW5JSFJvWlNCamIzSnlaV04wSUU5dVEyOXRjR3hsZEdVL0lFUnBaQ0I1YjNVZ2MyVjBJSGx2ZFhJZ1lYQndJRWxFUHdvSlpYSnlDZ292THlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSkx5OGdaWGhsWTNWMFpTQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkFvSlkyRnNiSE4xWWlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQW92THdvdkx5QkRZV3hzWldRZ2IyNWpaU0J2YmlCaGNIQWdZM0psWVhScGIyNHVJRk5sZEhNZ2RHaGxJR055WldGMGIzSWdZWE1nWVdSdGFXNHVDbU55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KY0hKdmRHOGdNQ0F3Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZqWTJWemMwMWhibUZuWlhJdWRITTZORElLQ1M4dklIUm9hWE11WVdSdGFXNHVkbUZzZFdVZ1BTQjBhR2x6TG5SNGJpNXpaVzVrWlhJS0NXSjVkR1ZqSURVZ0x5OGdJQ0poWkcxcGJpSUtDWFI0YmlCVFpXNWtaWElLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRmpZMlZ6YzAxaGJtRm5aWEl1ZEhNNk5ETUtDUzh2SUhSb2FYTXVRVVJOU1U1ZlFrbFVMblpoYkhWbElEMGdNUW9KWW5sMFpXTWdOeUF2THlBZ0lrRkVUVWxPWDBKSlZDSUtDV2x1ZEdNZ01DQXZMeUF4Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJZMk5sYzNOTllXNWhaMlZ5TG5Sek9qUTBDZ2t2THlCMGFHbHpMazFCVGxWR1FVTlVWVkpGVWw5Q1NWUXVkbUZzZFdVZ1BTQXlDZ2xpZVhSbFl5QTBJQzh2SUNBaVRVWlNYMEpKVkNJS0NYQjFjMmhwYm5RZ01nb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem8wTlFvSkx5OGdkR2hwY3k1RVNWTlVVa2xDVlZSUFVsOUNTVlF1ZG1Gc2RXVWdQU0EwQ2dsaWVYUmxZeUF6SUM4dklDQWlSRWxUVkY5Q1NWUWlDZ2x3ZFhOb2FXNTBJRFFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRmpZMlZ6YzAxaGJtRm5aWEl1ZEhNNk5EWUtDUzh2SUhSb2FYTXVVRWhCVWsxQlExbGZRa2xVTG5aaGJIVmxJRDBnT0FvSllubDBaV01nTWlBdkx5QWdJbEJJUVZKTlgwSkpWQ0lLQ1hCMWMyaHBiblFnT0FvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRV05qWlhOelRXRnVZV2RsY2k1MGN6bzBOd29KTHk4Z2RHaHBjeTVQVWtGRFRFVmZRa2xVTG5aaGJIVmxJRDBnTVRZS0NXSjVkR1ZqSURFZ0x5OGdJQ0pQVWtGRFRFVmZRa2xVSWdvSmNIVnphR2x1ZENBeE5nb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0NYSmxkSE4xWWdvS0x5OGdZWE56WlhKMFFXUnRhVzRvS1RvZ2RtOXBaQW92THdvdkx5QkJjM05sY25RZ2RHaGhkQ0IwYUdVZ2RISmhibk5oWTNScGIyNGdjMlZ1WkdWeUlHbHpJR0Z1SUdGa2JXbHVMZ3BoYzNObGNuUkJaRzFwYmpvS0NYQnliM1J2SURBZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4QlkyTmxjM05OWVc1aFoyVnlMblJ6T2pVMENna3ZMeUJoYzNObGNuUW9DZ2t2THlBZ0lDQWdJQ0IwYUdsekxuUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnZkh3S0NTOHZJQ0FnSUNBZ0lDQWdLSFJvYVhNdWNtOXNaWE1vZEdocGN5NTBlRzR1YzJWdVpHVnlLUzVsZUdsemRITWdKaVlLQ1M4dklDQWdJQ0FnSUNBZ0lDQW9kR2hwY3k1eWIyeGxjeWgwYUdsekxuUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElDWWdkR2hwY3k1QlJFMUpUbDlDU1ZRdWRtRnNkV1VwSUNFOVBTQXdLU3dLQ1M4dklDQWdJQ0FnSUNkRFlXeHNaWElnYVhNZ2JtOTBJR0Z1SUdGa2JXbHVKd29KTHk4Z0lDQWdJQ2tLQ1hSNGJpQlRaVzVrWlhJS0NXSjVkR1ZqSURVZ0x5OGdJQ0poWkcxcGJpSUtDV0Z3Y0Y5bmJHOWlZV3hmWjJWMENnazlQUW9KWkhWd0NnbGlibm9nS25OcmFYQmZiM0l3Q2dsaWVYUmxZeUF3SUM4dklDQWljaUlLQ1hSNGJpQlRaVzVrWlhJS0NXTnZibU5oZEFvSlltOTRYMnhsYmdvSmMzZGhjQW9KY0c5d0NnbGtkWEFLQ1dKNklDcHphMmx3WDJGdVpEQUtDV0o1ZEdWaklEQWdMeThnSUNKeUlnb0pkSGh1SUZObGJtUmxjZ29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbkp2YkdWektIUm9hWE11ZEhodUxuTmxibVJsY2lrdWRtRnNkV1VLQ1dGemMyVnlkQW9KWW5SdmFRb0pZbmwwWldNZ055QXZMeUFnSWtGRVRVbE9YMEpKVkNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2drbUNnbHBiblJqSURJZ0x5OGdNQW9KSVQwS0NTWW1DZ29xYzJ0cGNGOWhibVF3T2dvSmZId0tDaXB6YTJsd1gyOXlNRG9LQ1M4dklFTmhiR3hsY2lCcGN5QnViM1FnWVc0Z1lXUnRhVzRLQ1dGemMyVnlkQW9KY21WMGMzVmlDZ292THlCaFpHUnlaWE56U0dGelVtOXNaU2hoWTJOdmRXNTBPaUJCWkdSeVpYTnpMQ0J5YjJ4bFFtbDBPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVDaTh2Q2k4dklFTm9aV05ySUhkb1pYUm9aWElnWVc0Z1lXUmtjbVZ6Y3lCb2IyeGtjeUJoSUhOd1pXTnBabWxqSUhKdmJHVWdZbWwwTGdwaFpHUnlaWE56U0dGelVtOXNaVG9LQ1hCeWIzUnZJRElnTVFvS0NTOHZJQ3BwWmpCZlkyOXVaR2wwYVc5dUNna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem8yTkFvSkx5OGdJWFJvYVhNdWNtOXNaWE1vWVdOamIzVnVkQ2t1WlhocGMzUnpDZ2xpZVhSbFl5QXdJQzh2SUNBaWNpSUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGpiMjVqWVhRS0NXSnZlRjlzWlc0S0NYTjNZWEFLQ1hCdmNBb0pJUW9KWW5vZ0ttbG1NRjlsYm1RS0Nna3ZMeUFxYVdZd1gyTnZibk5sY1hWbGJuUUtDUzh2SUdOdmJuUnlZV04wYzF4QlkyTmxjM05OWVc1aFoyVnlMblJ6T2pZMENna3ZMeUJ5WlhSMWNtNGdabUZzYzJVN0NnbHBiblJqSURJZ0x5OGdNQW9KY21WMGMzVmlDZ29xYVdZd1gyVnVaRG9LQ1M4dklHTnZiblJ5WVdOMGMxeEJZMk5sYzNOTllXNWhaMlZ5TG5Sek9qWTFDZ2t2THlCeVpYUjFjbTRnS0hSb2FYTXVjbTlzWlhNb1lXTmpiM1Z1ZENrdWRtRnNkV1VnSmlCeWIyeGxRbWwwS1NBaFBUMGdNRHNLQ1dKNWRHVmpJREFnTHk4Z0lDSnlJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NXliMnhsY3loaFkyTnZkVzUwS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2NtOXNaVUpwZERvZ2RXbHVkRFkwQ2drbUNnbHBiblJqSURJZ0x5OGdNQW9KSVQwS0NYSmxkSE4xWWdvS0x5OGdaM0poYm5SU2IyeGxLSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FLS21GaWFWOXliM1YwWlY5bmNtRnVkRkp2YkdVNkNna3ZMeUJoWTJOdmRXNTBPaUJoWkdSeVpYTnpDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGtkWEFLQ1d4bGJnb0phVzUwWXlBeElDOHZJRE15Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURBZ0tHRmpZMjkxYm5RcElHWnZjaUJuY21GdWRGSnZiR1VnYlhWemRDQmlaU0JoSUdGa1pISmxjM01LQ1dGemMyVnlkQW9LQ1M4dklISnZiR1U2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdaM0poYm5SU2IyeGxLSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FLQ1dOaGJHeHpkV0lnWjNKaGJuUlNiMnhsQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJuY21GdWRGSnZiR1VvY205c1pUb2dkV2x1ZERZMExDQmhZMk52ZFc1ME9pQkJaR1J5WlhOektUb2dkbTlwWkFvdkx3b3ZMeUJIY21GdWRDQmhJSEp2YkdVZ0tHSjVJR0pwZENrZ2RHOGdZVzRnWVdOamIzVnVkQzRnUVdSdGFXNHRiMjVzZVM0S0x5OEtMeThnUUhCaGNtRnRJSEp2YkdVZ0xTQlVhR1VnY205c1pTQmlhWFFnZEc4Z1ozSmhiblFnS0RFc0lESXNJRFFzSURnc0lHOXlJREUyS1M0S0x5OGdRSEJoY21GdElHRmpZMjkxYm5RZ0xTQlVhR1VnZEdGeVoyVjBJR0ZqWTI5MWJuUWdZV1JrY21WemN5NEtaM0poYm5SU2IyeGxPZ29KY0hKdmRHOGdNaUF3Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NYQjFjMmhpZVhSbGN5QXdlQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJZMk5sYzNOTllXNWhaMlZ5TG5Sek9qYzNDZ2t2THlCMGFHbHpMbUZ6YzJWeWRFRmtiV2x1S0NrS0NXTmhiR3h6ZFdJZ1lYTnpaWEowUVdSdGFXNEtDZ2t2THlCamIyNTBjbUZqZEhOY1FXTmpaWE56VFdGdVlXZGxjaTUwY3pvM09Bb0pMeThnWVhOelpYSjBLR0ZqWTI5MWJuUWdJVDA5SUdkc2IySmhiSE11ZW1WeWIwRmtaSEpsYzNNc0lDZERZVzV1YjNRZ1ozSmhiblFnY205c1pTQjBieUI2WlhKdklHRmtaSEpsYzNNbktRb0pabkpoYldWZlpHbG5JQzB5SUM4dklHRmpZMjkxYm5RNklFRmtaSEpsYzNNS0NXZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b0pJVDBLQ2drdkx5QkRZVzV1YjNRZ1ozSmhiblFnY205c1pTQjBieUI2WlhKdklHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWTJObGMzTk5ZVzVoWjJWeUxuUnpPamd3Q2drdkx5QmpkWEp5Wlc1ME9pQjFhVzUwTmpRZ1BTQXdDZ2xwYm5SaklESWdMeThnTUFvSlpuSmhiV1ZmWW5WeWVTQXdJQzh2SUdOMWNuSmxiblE2SUhWcGJuUTJOQW9LQ1M4dklDcHBaakZmWTI5dVpHbDBhVzl1Q2drdkx5QmpiMjUwY21GamRITmNRV05qWlhOelRXRnVZV2RsY2k1MGN6bzRNUW9KTHk4Z2RHaHBjeTV5YjJ4bGN5aGhZMk52ZFc1MEtTNWxlR2x6ZEhNS0NXSjVkR1ZqSURBZ0x5OGdJQ0p5SWdvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGalkyOTFiblE2SUVGa1pISmxjM01LQ1dOdmJtTmhkQW9KWW05NFgyeGxiZ29KYzNkaGNBb0pjRzl3Q2dsaWVpQXFhV1l4WDJWdVpBb0tDUzh2SUNwcFpqRmZZMjl1YzJWeGRXVnVkQW9KTHk4Z1kyOXVkSEpoWTNSelhFRmpZMlZ6YzAxaGJtRm5aWEl1ZEhNNk9ESUtDUzh2SUdOMWNuSmxiblFnUFNCMGFHbHpMbkp2YkdWektHRmpZMjkxYm5RcExuWmhiSFZsQ2dsaWVYUmxZeUF3SUM4dklDQWljaUlLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJoWTJOdmRXNTBPaUJCWkdSeVpYTnpDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVjbTlzWlhNb1lXTmpiM1Z1ZENrdWRtRnNkV1VLQ1dGemMyVnlkQW9KWW5SdmFRb0pabkpoYldWZlluVnllU0F3SUM4dklHTjFjbkpsYm5RNklIVnBiblEyTkFvS0ttbG1NVjlsYm1RNkNna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem80TkFvSkx5OGdkR2hwY3k1eWIyeGxjeWhoWTJOdmRXNTBLUzUyWVd4MVpTQTlJR04xY25KbGJuUWdmQ0J5YjJ4bENnbGllWFJsWXlBd0lDOHZJQ0FpY2lJS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaFkyTnZkVzUwT2lCQlpHUnlaWE56Q2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR04xY25KbGJuUTZJSFZwYm5RMk5Bb0pabkpoYldWZlpHbG5JQzB4SUM4dklISnZiR1U2SUhWcGJuUTJOQW9KZkFvSmFYUnZZZ29KWW05NFgzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJZMk5sYzNOTllXNWhaMlZ5TG5Sek9qZzJDZ2t2THlCc2IyY29KMUp2YkdWSGNtRnVkR1ZrSnlrS0NYQjFjMmhpZVhSbGN5QXdlRFV5Tm1ZMll6WTFORGMzTWpZeE5tVTNORFkxTmpRZ0x5OGdJbEp2YkdWSGNtRnVkR1ZrSWdvSmJHOW5DZ2x5WlhSemRXSUtDaTh2SUhKbGRtOXJaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpBb3FZV0pwWDNKdmRYUmxYM0psZG05clpWSnZiR1U2Q2drdkx5QmhZMk52ZFc1ME9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF4SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0dGalkyOTFiblFwSUdadmNpQnlaWFp2YTJWU2IyeGxJRzExYzNRZ1ltVWdZU0JoWkdSeVpYTnpDZ2xoYzNObGNuUUtDZ2t2THlCeWIyeGxPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElISmxkbTlyWlZKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQW9KWTJGc2JITjFZaUJ5WlhadmEyVlNiMnhsQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJ5WlhadmEyVlNiMnhsS0hKdmJHVTZJSFZwYm5RMk5Dd2dZV05qYjNWdWREb2dRV1JrY21WemN5azZJSFp2YVdRS0x5OEtMeThnVW1WMmIydGxJR0VnY205c1pTQW9ZbmtnWW1sMEtTQm1jbTl0SUdGdUlHRmpZMjkxYm5RdUlFRmtiV2x1TFc5dWJIa3VDaTh2Q2k4dklFQndZWEpoYlNCeWIyeGxJQzBnVkdobElISnZiR1VnWW1sMElIUnZJSEpsZG05clpTNEtMeThnUUhCaGNtRnRJR0ZqWTI5MWJuUWdMU0JVYUdVZ2RHRnlaMlYwSUdGalkyOTFiblFnWVdSa2NtVnpjeTRLY21WMmIydGxVbTlzWlRvS0NYQnliM1J2SURJZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4QlkyTmxjM05OWVc1aFoyVnlMblJ6T2prMkNna3ZMeUIwYUdsekxtRnpjMlZ5ZEVGa2JXbHVLQ2tLQ1dOaGJHeHpkV0lnWVhOelpYSjBRV1J0YVc0S0Nna3ZMeUFxYVdZeVgyTnZibVJwZEdsdmJnb0pMeThnWTI5dWRISmhZM1J6WEVGalkyVnpjMDFoYm1GblpYSXVkSE02T1RnS0NTOHZJSFJvYVhNdWNtOXNaWE1vWVdOamIzVnVkQ2t1WlhocGMzUnpDZ2xpZVhSbFl5QXdJQzh2SUNBaWNpSUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGpiMjVqWVhRS0NXSnZlRjlzWlc0S0NYTjNZWEFLQ1hCdmNBb0pZbm9nS21sbU1sOWxibVFLQ2drdkx5QXFhV1l5WDJOdmJuTmxjWFZsYm5RS0NTOHZJR052Ym5SeVlXTjBjMXhCWTJObGMzTk5ZVzVoWjJWeUxuUnpPams1Q2drdkx5QjBhR2x6TG5KdmJHVnpLR0ZqWTI5MWJuUXBMblpoYkhWbElEMGdkR2hwY3k1eWIyeGxjeWhoWTJOdmRXNTBLUzUyWVd4MVpTQW1JSDV5YjJ4bENnbGllWFJsWXlBd0lDOHZJQ0FpY2lJS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaFkyTnZkVzUwT2lCQlpHUnlaWE56Q2dsamIyNWpZWFFLQ1dKNWRHVmpJREFnTHk4Z0lDSnlJZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NXliMnhsY3loaFkyTnZkVzUwS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2NtOXNaVG9nZFdsdWREWTBDZ2wrQ2drbUNnbHBkRzlpQ2dsaWIzaGZjSFYwQ2dvcWFXWXlYMlZ1WkRvS0NTOHZJR052Ym5SeVlXTjBjMXhCWTJObGMzTk5ZVzVoWjJWeUxuUnpPakV3TWdvSkx5OGdiRzluS0NkU2IyeGxVbVYyYjJ0bFpDY3BDZ2x3ZFhOb1lubDBaWE1nTUhnMU1qWm1ObU0yTlRVeU5qVTNOalptTm1JMk5UWTBJQzh2SUNKU2IyeGxVbVYyYjJ0bFpDSUtDV3h2WndvSmNtVjBjM1ZpQ2dvdkx5Qm5jbUZ1ZEUxaGJuVm1ZV04wZFhKbGNsSnZiR1VvWVdSa2NtVnpjeWwyYjJsa0NpcGhZbWxmY205MWRHVmZaM0poYm5STllXNTFabUZqZEhWeVpYSlNiMnhsT2dvSkx5OGdZV05qYjNWdWREb2dZV1JrY21WemN3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NXbHVkR01nTVNBdkx5QXpNZ29KUFQwS0Nna3ZMeUJoY21kMWJXVnVkQ0F3SUNoaFkyTnZkVzUwS1NCbWIzSWdaM0poYm5STllXNTFabUZqZEhWeVpYSlNiMnhsSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QmxlR1ZqZFhSbElHZHlZVzUwVFdGdWRXWmhZM1IxY21WeVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0NXTmhiR3h6ZFdJZ1ozSmhiblJOWVc1MVptRmpkSFZ5WlhKU2IyeGxDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5Qm5jbUZ1ZEUxaGJuVm1ZV04wZFhKbGNsSnZiR1VvWVdOamIzVnVkRG9nUVdSa2NtVnpjeWs2SUhadmFXUUtaM0poYm5STllXNTFabUZqZEhWeVpYSlNiMnhsT2dvSmNISnZkRzhnTVNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGalkyVnpjMDFoYm1GblpYSXVkSE02TVRBNENna3ZMeUIwYUdsekxtZHlZVzUwVW05c1pTaDBhR2x6TGsxQlRsVkdRVU5VVlZKRlVsOUNTVlF1ZG1Gc2RXVXNJR0ZqWTI5MWJuUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZV05qYjNWdWREb2dRV1JrY21WemN3b0pZbmwwWldNZ05DQXZMeUFnSWsxR1VsOUNTVlFpQ2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KWTJGc2JITjFZaUJuY21GdWRGSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z1ozSmhiblJFYVhOMGNtbGlkWFJ2Y2xKdmJHVW9ZV1JrY21WemN5bDJiMmxrQ2lwaFltbGZjbTkxZEdWZlozSmhiblJFYVhOMGNtbGlkWFJ2Y2xKdmJHVTZDZ2t2THlCaFkyTnZkVzUwT2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR0ZqWTI5MWJuUXBJR1p2Y2lCbmNtRnVkRVJwYzNSeWFXSjFkRzl5VW05c1pTQnRkWE4wSUdKbElHRWdZV1JrY21WemN3b0pZWE56WlhKMENnb0pMeThnWlhobFkzVjBaU0JuY21GdWRFUnBjM1J5YVdKMWRHOXlVbTlzWlNoaFpHUnlaWE56S1hadmFXUUtDV05oYkd4emRXSWdaM0poYm5SRWFYTjBjbWxpZFhSdmNsSnZiR1VLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR2R5WVc1MFJHbHpkSEpwWW5WMGIzSlNiMnhsS0dGalkyOTFiblE2SUVGa1pISmxjM01wT2lCMmIybGtDbWR5WVc1MFJHbHpkSEpwWW5WMGIzSlNiMnhsT2dvSmNISnZkRzhnTVNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVGalkyVnpjMDFoYm1GblpYSXVkSE02TVRFeUNna3ZMeUIwYUdsekxtZHlZVzUwVW05c1pTaDBhR2x6TGtSSlUxUlNTVUpWVkU5U1gwSkpWQzUyWVd4MVpTd2dZV05qYjNWdWRDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGllWFJsWXlBeklDOHZJQ0FpUkVsVFZGOUNTVlFpQ2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KWTJGc2JITjFZaUJuY21GdWRGSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z1ozSmhiblJRYUdGeWJXRmplVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWjNKaGJuUlFhR0Z5YldGamVWSnZiR1U2Q2drdkx5QmhZMk52ZFc1ME9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF4SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0dGalkyOTFiblFwSUdadmNpQm5jbUZ1ZEZCb1lYSnRZV041VW05c1pTQnRkWE4wSUdKbElHRWdZV1JrY21WemN3b0pZWE56WlhKMENnb0pMeThnWlhobFkzVjBaU0JuY21GdWRGQm9ZWEp0WVdONVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0NXTmhiR3h6ZFdJZ1ozSmhiblJRYUdGeWJXRmplVkp2YkdVS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdkeVlXNTBVR2hoY20xaFkzbFNiMnhsS0dGalkyOTFiblE2SUVGa1pISmxjM01wT2lCMmIybGtDbWR5WVc1MFVHaGhjbTFoWTNsU2IyeGxPZ29KY0hKdmRHOGdNU0F3Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUZqWTJWemMwMWhibUZuWlhJdWRITTZNVEUyQ2drdkx5QjBhR2x6TG1keVlXNTBVbTlzWlNoMGFHbHpMbEJJUVZKTlFVTlpYMEpKVkM1MllXeDFaU3dnWVdOamIzVnVkQ2tLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJoWTJOdmRXNTBPaUJCWkdSeVpYTnpDZ2xpZVhSbFl5QXlJQzh2SUNBaVVFaEJVazFmUWtsVUlnb0pZWEJ3WDJkc2IySmhiRjluWlhRS0NXTmhiR3h6ZFdJZ1ozSmhiblJTYjJ4bENnbHlaWFJ6ZFdJS0NpOHZJR2R5WVc1MFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTaGhaR1J5WlhOektYWnZhV1FLS21GaWFWOXliM1YwWlY5bmNtRnVkRlJsYkdWdFpYUnllVTl5WVdOc1pWSnZiR1U2Q2drdkx5QmhZMk52ZFc1ME9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF4SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0dGalkyOTFiblFwSUdadmNpQm5jbUZ1ZEZSbGJHVnRaWFJ5ZVU5eVlXTnNaVkp2YkdVZ2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJR1Y0WldOMWRHVWdaM0poYm5SVVpXeGxiV1YwY25sUGNtRmpiR1ZTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQW9KWTJGc2JITjFZaUJuY21GdWRGUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVUtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHZHlZVzUwVkdWc1pXMWxkSEo1VDNKaFkyeGxVbTlzWlNoaFkyTnZkVzUwT2lCQlpHUnlaWE56S1RvZ2RtOXBaQXBuY21GdWRGUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVTZDZ2x3Y205MGJ5QXhJREFLQ2drdkx5QmpiMjUwY21GamRITmNRV05qWlhOelRXRnVZV2RsY2k1MGN6b3hNakFLQ1M4dklIUm9hWE11WjNKaGJuUlNiMnhsS0hSb2FYTXVUMUpCUTB4RlgwSkpWQzUyWVd4MVpTd2dZV05qYjNWdWRDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGllWFJsWXlBeElDOHZJQ0FpVDFKQlEweEZYMEpKVkNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2dsallXeHNjM1ZpSUdkeVlXNTBVbTlzWlFvSmNtVjBjM1ZpQ2dvdkx5QnlaWFp2YTJWTllXNTFabUZqZEhWeVpYSlNiMnhsS0dGa1pISmxjM01wZG05cFpBb3FZV0pwWDNKdmRYUmxYM0psZG05clpVMWhiblZtWVdOMGRYSmxjbEp2YkdVNkNna3ZMeUJoWTJOdmRXNTBPaUJoWkdSeVpYTnpDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGtkWEFLQ1d4bGJnb0phVzUwWXlBeElDOHZJRE15Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURBZ0tHRmpZMjkxYm5RcElHWnZjaUJ5WlhadmEyVk5ZVzUxWm1GamRIVnlaWEpTYjJ4bElHMTFjM1FnWW1VZ1lTQmhaR1J5WlhOekNnbGhjM05sY25RS0Nna3ZMeUJsZUdWamRYUmxJSEpsZG05clpVMWhiblZtWVdOMGRYSmxjbEp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDZ2xqWVd4c2MzVmlJSEpsZG05clpVMWhiblZtWVdOMGRYSmxjbEp2YkdVS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhKbGRtOXJaVTFoYm5WbVlXTjBkWEpsY2xKdmJHVW9ZV05qYjNWdWREb2dRV1JrY21WemN5azZJSFp2YVdRS2NtVjJiMnRsVFdGdWRXWmhZM1IxY21WeVVtOXNaVG9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWTJObGMzTk5ZVzVoWjJWeUxuUnpPakV5TmdvSkx5OGdkR2hwY3k1eVpYWnZhMlZTYjJ4bEtIUm9hWE11VFVGT1ZVWkJRMVJWVWtWU1gwSkpWQzUyWVd4MVpTd2dZV05qYjNWdWRDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGllWFJsWXlBMElDOHZJQ0FpVFVaU1gwSkpWQ0lLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xqWVd4c2MzVmlJSEpsZG05clpWSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z2NtVjJiMnRsUkdsemRISnBZblYwYjNKU2IyeGxLR0ZrWkhKbGMzTXBkbTlwWkFvcVlXSnBYM0p2ZFhSbFgzSmxkbTlyWlVScGMzUnlhV0oxZEc5eVVtOXNaVG9LQ1M4dklHRmpZMjkxYm5RNklHRmtaSEpsYzNNS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dSMWNBb0piR1Z1Q2dscGJuUmpJREVnTHk4Z016SUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNQ0FvWVdOamIzVnVkQ2tnWm05eUlISmxkbTlyWlVScGMzUnlhV0oxZEc5eVVtOXNaU0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCeVpYWnZhMlZFYVhOMGNtbGlkWFJ2Y2xKdmJHVW9ZV1JrY21WemN5bDJiMmxrQ2dsallXeHNjM1ZpSUhKbGRtOXJaVVJwYzNSeWFXSjFkRzl5VW05c1pRb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2NtVjJiMnRsUkdsemRISnBZblYwYjNKU2IyeGxLR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTXBPaUIyYjJsa0NuSmxkbTlyWlVScGMzUnlhV0oxZEc5eVVtOXNaVG9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhCWTJObGMzTk5ZVzVoWjJWeUxuUnpPakV6TUFvSkx5OGdkR2hwY3k1eVpYWnZhMlZTYjJ4bEtIUm9hWE11UkVsVFZGSkpRbFZVVDFKZlFrbFVMblpoYkhWbExDQmhZMk52ZFc1MEtRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHRmpZMjkxYm5RNklFRmtaSEpsYzNNS0NXSjVkR1ZqSURNZ0x5OGdJQ0pFU1ZOVVgwSkpWQ0lLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xqWVd4c2MzVmlJSEpsZG05clpWSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z2NtVjJiMnRsVUdoaGNtMWhZM2xTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDNKbGRtOXJaVkJvWVhKdFlXTjVVbTlzWlRvS0NTOHZJR0ZqWTI5MWJuUTZJR0ZrWkhKbGMzTUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXUjFjQW9KYkdWdUNnbHBiblJqSURFZ0x5OGdNeklLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb1lXTmpiM1Z1ZENrZ1ptOXlJSEpsZG05clpWQm9ZWEp0WVdONVVtOXNaU0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCeVpYWnZhMlZRYUdGeWJXRmplVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDZ2xqWVd4c2MzVmlJSEpsZG05clpWQm9ZWEp0WVdONVVtOXNaUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjbVYyYjJ0bFVHaGhjbTFoWTNsU2IyeGxLR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTXBPaUIyYjJsa0NuSmxkbTlyWlZCb1lYSnRZV041VW05c1pUb0tDWEJ5YjNSdklERWdNQW9LQ1M4dklHTnZiblJ5WVdOMGMxeEJZMk5sYzNOTllXNWhaMlZ5TG5Sek9qRXpOQW9KTHk4Z2RHaHBjeTV5WlhadmEyVlNiMnhsS0hSb2FYTXVVRWhCVWsxQlExbGZRa2xVTG5aaGJIVmxMQ0JoWTJOdmRXNTBLUW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV0o1ZEdWaklESWdMeThnSUNKUVNFRlNUVjlDU1ZRaUNnbGhjSEJmWjJ4dlltRnNYMmRsZEFvSlkyRnNiSE4xWWlCeVpYWnZhMlZTYjJ4bENnbHlaWFJ6ZFdJS0NpOHZJSEpsZG05clpWUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVW9ZV1JrY21WemN5bDJiMmxrQ2lwaFltbGZjbTkxZEdWZmNtVjJiMnRsVkdWc1pXMWxkSEo1VDNKaFkyeGxVbTlzWlRvS0NTOHZJR0ZqWTI5MWJuUTZJR0ZrWkhKbGMzTUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXUjFjQW9KYkdWdUNnbHBiblJqSURFZ0x5OGdNeklLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb1lXTmpiM1Z1ZENrZ1ptOXlJSEpsZG05clpWUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVWdiWFZ6ZENCaVpTQmhJR0ZrWkhKbGMzTUtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnY21WMmIydGxWR1ZzWlcxbGRISjVUM0poWTJ4bFVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0NXTmhiR3h6ZFdJZ2NtVjJiMnRsVkdWc1pXMWxkSEo1VDNKaFkyeGxVbTlzWlFvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnY21WMmIydGxWR1ZzWlcxbGRISjVUM0poWTJ4bFVtOXNaU2hoWTJOdmRXNTBPaUJCWkdSeVpYTnpLVG9nZG05cFpBcHlaWFp2YTJWVVpXeGxiV1YwY25sUGNtRmpiR1ZTYjJ4bE9nb0pjSEp2ZEc4Z01TQXdDZ29KTHk4Z1kyOXVkSEpoWTNSelhFRmpZMlZ6YzAxaGJtRm5aWEl1ZEhNNk1UTTRDZ2t2THlCMGFHbHpMbkpsZG05clpWSnZiR1VvZEdocGN5NVBVa0ZEVEVWZlFrbFVMblpoYkhWbExDQmhZMk52ZFc1MEtRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHRmpZMjkxYm5RNklFRmtaSEpsYzNNS0NXSjVkR1ZqSURFZ0x5OGdJQ0pQVWtGRFRFVmZRa2xVSWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1dOaGJHeHpkV0lnY21WMmIydGxVbTlzWlFvSmNtVjBjM1ZpQ2dvdkx5Qm9ZWE5TYjJ4bEtIVnBiblEyTkN4aFpHUnlaWE56S1dKdmIyd0tLbUZpYVY5eWIzVjBaVjlvWVhOU2IyeGxPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2xpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJoWTJOdmRXNTBPaUJoWkdSeVpYTnpDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGtkWEFLQ1d4bGJnb0phVzUwWXlBeElDOHZJRE15Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURBZ0tHRmpZMjkxYm5RcElHWnZjaUJvWVhOU2IyeGxJRzExYzNRZ1ltVWdZU0JoWkdSeVpYTnpDZ2xoYzNObGNuUUtDZ2t2THlCeWIyeGxPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHaGhjMUp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wWW05dmJBb0pZMkZzYkhOMVlpQm9ZWE5TYjJ4bENnbHdkWE5vWW5sMFpYTWdNSGd3TUFvSmFXNTBZeUF5SUM4dklEQUtDWFZ1WTI5MlpYSWdNZ29KYzJWMFltbDBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnYUdGelVtOXNaU2h5YjJ4bE9pQjFhVzUwTmpRc0lHRmpZMjkxYm5RNklFRmtaSEpsYzNNcE9pQmliMjlzWldGdUNpOHZDaTh2SUVOb1pXTnJJSGRvWlhSb1pYSWdZVzRnWVdOamIzVnVkQ0JvYjJ4a2N5QmhJSE53WldOcFptbGpJSEp2YkdVdUNpOHZDaTh2SUVCd1lYSmhiU0J5YjJ4bElDMGdWR2hsSUhKdmJHVWdZbWwwSUhSdklHTm9aV05yTGdvdkx5QkFjR0Z5WVcwZ1lXTmpiM1Z1ZENBdElGUm9aU0JoWTJOdmRXNTBJR0ZrWkhKbGMzTXVDaTh2SUVCeVpYUjFjbTV6SUhSeWRXVWdhV1lnZEdobElHRmpZMjkxYm5RZ2FHOXNaSE1nZEdobElISnZiR1V1Q21oaGMxSnZiR1U2Q2dsd2NtOTBieUF5SURFS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem94TlRFS0NTOHZJSEpsZEhWeWJpQjBhR2x6TG1Ga1pISmxjM05JWVhOU2IyeGxLR0ZqWTI5MWJuUXNJSEp2YkdVcE93b0pabkpoYldWZlpHbG5JQzB4SUM4dklISnZiR1U2SUhWcGJuUTJOQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV05oYkd4emRXSWdZV1JrY21WemMwaGhjMUp2YkdVS0NYSmxkSE4xWWdvS0x5OGdaMlYwVW05c1pVMWhjMnNvWVdSa2NtVnpjeWwxYVc1ME5qUUtLbUZpYVY5eWIzVjBaVjluWlhSU2IyeGxUV0Z6YXpvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSllubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1lXTmpiM1Z1ZERvZ1lXUmtjbVZ6Y3dvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWkhWd0NnbHNaVzRLQ1dsdWRHTWdNU0F2THlBek1nb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXdJQ2hoWTJOdmRXNTBLU0JtYjNJZ1oyVjBVbTlzWlUxaGMyc2diWFZ6ZENCaVpTQmhJR0ZrWkhKbGMzTUtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnWjJWMFVtOXNaVTFoYzJzb1lXUmtjbVZ6Y3lsMWFXNTBOalFLQ1dOaGJHeHpkV0lnWjJWMFVtOXNaVTFoYzJzS0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCblpYUlNiMnhsVFdGemF5aGhZMk52ZFc1ME9pQkJaR1J5WlhOektUb2dkV2x1ZERZMENpOHZDaTh2SUZKbGRIVnlibk1nZEdobElHWjFiR3dnY205c1pTQmlhWFJ0WVhOcklHWnZjaUJoYmlCaFkyTnZkVzUwTGdwblpYUlNiMnhsVFdGemF6b0tDWEJ5YjNSdklERWdNUW9LQ1M4dklDcHBaak5mWTI5dVpHbDBhVzl1Q2drdkx5QmpiMjUwY21GamRITmNRV05qWlhOelRXRnVZV2RsY2k1MGN6b3hOVGdLQ1M4dklDRjBhR2x6TG5KdmJHVnpLR0ZqWTI5MWJuUXBMbVY0YVhOMGN3b0pZbmwwWldNZ01DQXZMeUFnSW5JaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1lXTmpiM1Z1ZERvZ1FXUmtjbVZ6Y3dvSlkyOXVZMkYwQ2dsaWIzaGZiR1Z1Q2dsemQyRndDZ2x3YjNBS0NTRUtDV0o2SUNwcFpqTmZaVzVrQ2dvSkx5OGdLbWxtTTE5amIyNXpaWEYxWlc1MENna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem94TlRnS0NTOHZJSEpsZEhWeWJpQXdPd29KYVc1MFl5QXlJQzh2SURBS0NYSmxkSE4xWWdvS0ttbG1NMTlsYm1RNkNna3ZMeUJqYjI1MGNtRmpkSE5jUVdOalpYTnpUV0Z1WVdkbGNpNTBjem94TlRrS0NTOHZJSEpsZEhWeWJpQjBhR2x6TG5KdmJHVnpLR0ZqWTI5MWJuUXBMblpoYkhWbE93b0pZbmwwWldNZ01DQXZMeUFnSW5JaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1lXTmpiM1Z1ZERvZ1FXUmtjbVZ6Y3dvSlkyOXVZMkYwQ2dsaWIzaGZaMlYwQ2dvSkx5OGdZbTk0SUhaaGJIVmxJR1J2WlhNZ2JtOTBJR1Y0YVhOME9pQjBhR2x6TG5KdmJHVnpLR0ZqWTI5MWJuUXBMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1hKbGRITjFZZ29LTHk4Z1oyVjBRV1J0YVc0b0tXRmtaSEpsYzNNS0ttRmlhVjl5YjNWMFpWOW5aWFJCWkcxcGJqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdaWGhsWTNWMFpTQm5aWFJCWkcxcGJpZ3BZV1JrY21WemN3b0pZMkZzYkhOMVlpQm5aWFJCWkcxcGJnb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR2RsZEVGa2JXbHVLQ2s2SUVGa1pISmxjM01LTHk4S0x5OGdVbVYwZFhKdWN5QjBhR1VnWVdSdGFXNGdZV1JrY21WemN5NEtaMlYwUVdSdGFXNDZDZ2x3Y205MGJ5QXdJREVLQ2drdkx5QmpiMjUwY21GamRITmNRV05qWlhOelRXRnVZV2RsY2k1MGN6b3hOallLQ1M4dklISmxkSFZ5YmlCMGFHbHpMbUZrYldsdUxuWmhiSFZsT3dvSllubDBaV01nTlNBdkx5QWdJbUZrYldsdUlnb0pZWEJ3WDJkc2IySmhiRjluWlhRS0NYSmxkSE4xWWdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRE0yWmpGaE5EYzFJQzh2SUcxbGRHaHZaQ0FpWjNKaGJuUlNiMnhsS0hWcGJuUTJOQ3hoWkdSeVpYTnpLWFp2YVdRaUNnbHdkWE5vWW5sMFpYTWdNSGhtTVRoaE9ETmhPQ0F2THlCdFpYUm9iMlFnSW5KbGRtOXJaVkp2YkdVb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZURNeVpUZzRNalUxSUM4dklHMWxkR2h2WkNBaVozSmhiblJOWVc1MVptRmpkSFZ5WlhKU2IyeGxLR0ZrWkhKbGMzTXBkbTlwWkNJS0NYQjFjMmhpZVhSbGN5QXdlR0UyWm1Zek1EVmxJQzh2SUcxbGRHaHZaQ0FpWjNKaGJuUkVhWE4wY21saWRYUnZjbEp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNFkyRTNaVGt6WTJFZ0x5OGdiV1YwYUc5a0lDSm5jbUZ1ZEZCb1lYSnRZV041VW05c1pTaGhaR1J5WlhOektYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IaG1NVEU0TjJVMk5TQXZMeUJ0WlhSb2IyUWdJbWR5WVc1MFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTaGhaR1J5WlhOektYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IaGpNRFJtTUdFMVpTQXZMeUJ0WlhSb2IyUWdJbkpsZG05clpVMWhiblZtWVdOMGRYSmxjbEp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNE16SmtaamxrTkRNZ0x5OGdiV1YwYUc5a0lDSnlaWFp2YTJWRWFYTjBjbWxpZFhSdmNsSnZiR1VvWVdSa2NtVnpjeWwyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0TWpRMk9HWXlZbUVnTHk4Z2JXVjBhRzlrSUNKeVpYWnZhMlZRYUdGeWJXRmplVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNE9XTm1OV0kxT1RZZ0x5OGdiV1YwYUc5a0lDSnlaWFp2YTJWVVpXeGxiV1YwY25sUGNtRmpiR1ZTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VHRTJNelZtTURWaklDOHZJRzFsZEdodlpDQWlhR0Z6VW05c1pTaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsaWIyOXNJZ29KY0hWemFHSjVkR1Z6SURCNFpUWm1PV1JoTnpRZ0x5OGdiV1YwYUc5a0lDSm5aWFJTYjJ4bFRXRnpheWhoWkdSeVpYTnpLWFZwYm5RMk5DSUtDWEIxYzJoaWVYUmxjeUF3ZUdGak9HSXlOR1JsSUM4dklHMWxkR2h2WkNBaVoyVjBRV1J0YVc0b0tXRmtaSEpsYzNNaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJkeVlXNTBVbTlzWlNBcVlXSnBYM0p2ZFhSbFgzSmxkbTlyWlZKdmJHVWdLbUZpYVY5eWIzVjBaVjluY21GdWRFMWhiblZtWVdOMGRYSmxjbEp2YkdVZ0ttRmlhVjl5YjNWMFpWOW5jbUZ1ZEVScGMzUnlhV0oxZEc5eVVtOXNaU0FxWVdKcFgzSnZkWFJsWDJkeVlXNTBVR2hoY20xaFkzbFNiMnhsSUNwaFltbGZjbTkxZEdWZlozSmhiblJVWld4bGJXVjBjbmxQY21GamJHVlNiMnhsSUNwaFltbGZjbTkxZEdWZmNtVjJiMnRsVFdGdWRXWmhZM1IxY21WeVVtOXNaU0FxWVdKcFgzSnZkWFJsWDNKbGRtOXJaVVJwYzNSeWFXSjFkRzl5VW05c1pTQXFZV0pwWDNKdmRYUmxYM0psZG05clpWQm9ZWEp0WVdONVVtOXNaU0FxWVdKcFgzSnZkWFJsWDNKbGRtOXJaVlJsYkdWdFpYUnllVTl5WVdOc1pWSnZiR1VnS21GaWFWOXliM1YwWlY5b1lYTlNiMnhsSUNwaFltbGZjbTkxZEdWZloyVjBVbTlzWlUxaGMyc2dLbUZpYVY5eWIzVjBaVjluWlhSQlpHMXBiZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
