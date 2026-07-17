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

namespace Arc56.Generated.devndesigner6.saveup.SaveUpVault_5231858b
{


    //
    // On-chain gamified savings vault with tiered milestone badges.
    //
    public class SaveUpVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SaveUpVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy the contract and seed milestone thresholds in global state.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Initialise local state so a user can start depositing.
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
        ///Record a deposit.
        ///Must be called as part of a 2-transaction atomic group:     txn[0] — PaymentTransaction  (user → app address)     txn[1] — ApplicationCall     (this method)
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Deposit(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 46, 188, 155 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 46, 188, 155 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw ALGO back to the user's wallet.
        ///Reverts if the vault lock period has not yet expired.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw before the lock period expires, paying a 10% penalty.
        ///The penalty stays in the contract; only the net amount is returned.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawEarly(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 87, 145, 240 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawEarly_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 87, 145, 240 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lock the vault until a specific Algorand round number.
        ///</summary>
        /// <param name="lock_until_round"> </param>
        public async Task SetLock(ulong lock_until_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 81, 9, 214 };
            var lock_until_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_until_roundAbi.From(lock_until_round);

            var result = await base.CallApp(new List<object> { abiHandle, lock_until_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLock_Transactions(ulong lock_until_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 81, 9, 214 };
            var lock_until_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_until_roundAbi.From(lock_until_round);

            return await base.MakeTransactionList(new List<object> { abiHandle, lock_until_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2F2ZVVwVmF1bHQiLCJkZXNjIjoiT24tY2hhaW4gZ2FtaWZpZWQgc2F2aW5ncyB2YXVsdCB3aXRoIHRpZXJlZCBtaWxlc3RvbmUgYmFkZ2VzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiRGVwbG95IHRoZSBjb250cmFjdCBhbmQgc2VlZCBtaWxlc3RvbmUgdGhyZXNob2xkcyBpbiBnbG9iYWwgc3RhdGUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOiJJbml0aWFsaXNlIGxvY2FsIHN0YXRlIHNvIGEgdXNlciBjYW4gc3RhcnQgZGVwb3NpdGluZy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiUmVjb3JkIGEgZGVwb3NpdC5cbk11c3QgYmUgY2FsbGVkIGFzIHBhcnQgb2YgYSAyLXRyYW5zYWN0aW9uIGF0b21pYyBncm91cDogICAgIHR4blswXSDigJQgUGF5bWVudFRyYW5zYWN0aW9uICAodXNlciDihpIgYXBwIGFkZHJlc3MpICAgICB0eG5bMV0g4oCUIEFwcGxpY2F0aW9uQ2FsbCAgICAgKHRoaXMgbWV0aG9kKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXcgQUxHTyBiYWNrIHRvIHRoZSB1c2VyJ3Mgd2FsbGV0LlxuUmV2ZXJ0cyBpZiB0aGUgdmF1bHQgbG9jayBwZXJpb2QgaGFzIG5vdCB5ZXQgZXhwaXJlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2Vhcmx5IiwiZGVzYyI6IldpdGhkcmF3IGJlZm9yZSB0aGUgbG9jayBwZXJpb2QgZXhwaXJlcywgcGF5aW5nIGEgMTAlIHBlbmFsdHkuXG5UaGUgcGVuYWx0eSBzdGF5cyBpbiB0aGUgY29udHJhY3Q7IG9ubHkgdGhlIG5ldCBhbW91bnQgaXMgcmV0dXJuZWQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfbG9jayIsImRlc2MiOiJMb2NrIHRoZSB2YXVsdCB1bnRpbCBhIHNwZWNpZmljIEFsZ29yYW5kIHJvdW5kIG51bWJlci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9ja191bnRpbF9yb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjo0LCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxMSw0NzJdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgdmF1bHQgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBnbyB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzZdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNl0sImVycm9yTWVzc2FnZSI6IlJlcXVpcmVzIGEgMi10eG4gYXRvbWljIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAxXSwiZXJyb3JNZXNzYWdlIjoiVmF1bHQgaXMgc3RpbGwgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb3VudCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxvY2sgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tMSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm0yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubTMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tNCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm01IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NSwyODYsNDA3LDQzMyw0NjgsNTAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zYXZlZCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsNDQ2LDUxM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWwgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExLDM4OSw0NjEsNTI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnpZWFpsWkNJZ0luUnZkR0ZzSWlBaWJHVjJaV3dpSUNKamIzVnVkQ0lnSW14dlkyc2lJQ0p0TVNJZ0ltMHlJaUFpYlRNaUlDSnROQ0lnSW0wMUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnWTJ4aGMzTWdVMkYyWlZWd1ZtRjFiSFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VETXdZelprTlRoaElDOHZJRzFsZEdodlpDQWliM0IwWDJsdUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU5Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJqYkdGemN5QlRZWFpsVlhCV1lYVnNkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TWdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURabE1tVmlZemxpSURCNE1qRm1NV1JrWm1ZZ01IaGlPRFUzT1RGbU1DQXdlRFUxTlRFd09XUTJJQzh2SUcxbGRHaHZaQ0FpWkdWd2IzTnBkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhjb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNYMlZoY214NUtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmJHOWpheWgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHUmxjRzl6YVhRZ2QybDBhR1J5WVhjZ2QybDBhR1J5WVhkZlpXRnliSGtnYzJWMFgyeHZZMnNLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR05zWVhOeklGTmhkbVZWY0ZaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdkRjlwYmw5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdiM0IwWDJsdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1WMWNGOTJZWFZzZEM1amIyNTBjbUZqZEM1VFlYWmxWWEJXWVhWc2RDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJ6Wld4bUxtMHhMblpoYkhWbElEMGdWVWx1ZERZMEtFMHhLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWliVEVpQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnYzJWc1ppNXRNaTUyWVd4MVpTQTlJRlZKYm5RMk5DaE5NaWtLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTB5SWdvZ0lDQWdjSFZ6YUdsdWRDQTFNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUhObGJHWXViVE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9UVE1wQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p0TXlJS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvM053b2dJQ0FnTHk4Z2MyVnNaaTV0TkM1MllXeDFaU0E5SUZWSmJuUTJOQ2hOTkNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW0wMElnb2dJQ0FnY0hWemFHbHVkQ0F5TlRBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyWlhWd1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnpaV3htTG0wMUxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0UwMUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJUVWlDaUFnSUNCd2RYTm9hVzUwSURVd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOemtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3d1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJGMlpYVndYM1poZFd4MExtTnZiblJ5WVdOMExsTmhkbVZWY0ZaaGRXeDBMbTl3ZEY5cGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVjMkYyWldSYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTmhkbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklITmxiR1l1WTI5MWJuUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJSE5sYkdZdWJHOWphMXRVZUc0dWMyVnVaR1Z5WFNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYkc5amF5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJ6Wld4bUxteGxkbVZzVzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc1pYWmxiQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJaWFZ3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pneENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazl3ZEVsdUlsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtVjFjRjkyWVhWc2RDNWpiMjUwY21GamRDNVRZWFpsVlhCV1lYVnNkQzVrWlhCdmMybDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2IzTnBkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbWR5YjNWd1gzTnBlbVVnUFQwZ1ZVbHVkRFkwS0RJcExDQWlVbVZ4ZFdseVpYTWdZU0F5TFhSNGJpQmhkRzl0YVdNZ1ozSnZkWEFpQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEYxYVhKbGN5QmhJREl0ZEhodUlHRjBiMjFwWXlCbmNtOTFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklIQmhlU0E5SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJaWFZ3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVTNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUdGd2NDSUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z1lYQndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJaWFZ3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z2NHRjVJRDBnWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNG9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJaWFZ3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVTNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjaXdnSWxCaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnWTJGc2JHVnlJZ29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dZMkZzYkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnY0dGNUlEMGdaM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0b01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnWkdWd2IzTnBkR1ZrSUQwZ2NHRjVMbUZ0YjNWdWRBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnYzJWc1ppNXpZWFpsWkZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYkdZdWMyRjJaV1JiVkhodUxuTmxibVJsY2wwZ0t5QmtaWEJ2YzJsMFpXUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6WVhabFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5oZG1Wa0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk5oZG1Wa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyWlhWd1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdjMlZzWmk1amIzVnVkRnRVZUc0dWMyVnVaR1Z5WFNBOUlITmxiR1l1WTI5MWJuUmJWSGh1TG5ObGJtUmxjbDBnS3lCVlNXNTBOalFvTVNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZkVzUwSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OdmRXNTBJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3T1FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkM1MllXeDFaU0E5SUhObGJHWXVkRzkwWVd3dWRtRnNkV1VnS3lCa1pYQnZjMmwwWldRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJDQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCaVlXeGhibU5sSUQwZ2MyVnNaaTV6WVhabFpGdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OaGRtVmtJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmhkbVZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJR2xtSUdKaGJHRnVZMlVnUGowZ2MyVnNaaTV0TlM1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnROU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dE5TQmxlR2x6ZEhNS0lDQWdJRDQ5Q2lBZ0lDQmllaUJrWlhCdmMybDBYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyWlhWd1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTJOQW9nSUNBZ0x5OGdjMlZzWmk1c1pYWmxiRnRVZUc0dWMyVnVaR1Z5WFNBOUlGVkpiblEyTkNnMUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkdWMlpXd2lDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taR1Z3YjNOcGRGOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QmxiR2xtSUdKaGJHRnVZMlVnUGowZ2MyVnNaaTV0TkM1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnROQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dE5DQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdZbm9nWkdWd2IzTnBkRjlsYkhObFgySnZaSGxBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJSE5sYkdZdWJHVjJaV3hiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb05Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14bGRtVnNJZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0JpSUdSbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9LWkdWd2IzTnBkRjlsYkhObFgySnZaSGxBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVFkzQ2lBZ0lDQXZMeUJsYkdsbUlHSmhiR0Z1WTJVZ1BqMGdjMlZzWmk1dE15NTJZV3gxWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p0TXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRNeUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWW5vZ1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TmpnS0lDQWdJQzh2SUhObGJHWXViR1YyWld4YlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGxkbVZzSWdvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCaUlHUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCbGJHbG1JR0poYkdGdVkyVWdQajBnYzJWc1ppNXRNaTUyWVd4MVpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdE1pSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0TWlCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQThQUW9nSUNBZ1lub2daR1Z3YjNOcGRGOWxiSE5sWDJKdlpIbEFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklITmxiR1l1YkdWMlpXeGJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTWlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXhsZG1Wc0lnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJR0lnWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFERXhDZ3BrWlhCdmMybDBYMlZzYzJWZlltOWtlVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOekVLSUNBZ0lDOHZJR1ZzYVdZZ1ltRnNZVzVqWlNBK1BTQnpaV3htTG0weExuWmhiSFZsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbTB4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMHhJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUR3OUNpQWdJQ0JpZWlCa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UY3lDaUFnSUNBdkx5QnpaV3htTG14bGRtVnNXMVI0Ymk1elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzWlhabGJDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0JpSUdSbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1ellYWmxkWEJmZG1GMWJIUXVZMjl1ZEhKaFkzUXVVMkYyWlZWd1ZtRjFiSFF1ZDJsMGFHUnlZWGRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVzYjJOclcxUjRiaTV6Wlc1a1pYSmRJRHc5SUVkc2IySmhiQzV5YjNWdVpDd2dJbFpoZFd4MElHbHpJSE4wYVd4c0lHeHZZMnRsWkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnNiMk5ySWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHOWpheUJsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0JwY3lCemRHbHNiQ0JzYjJOclpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpZWFpsWkZ0VWVHNHVjMlZ1WkdWeVhTQStQU0JoYlc5MWJuUXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2RtRjFiSFFnWW1Gc1lXNWpaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKellYWmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OaGRtVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJSFpoZFd4MElHSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEl5TFRFeU5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpJdE1USTJDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJSE5sYkdZdWMyRjJaV1JiVkhodUxuTmxibVJsY2wwZ1BTQnpaV3htTG5OaGRtVmtXMVI0Ymk1elpXNWtaWEpkSUMwZ1lXMXZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMyRjJaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1ellYWmxaQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKellYWmxaQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd3dWRtRnNkV1VnUFNCelpXeG1MblJ2ZEdGc0xuWmhiSFZsSUMwZ1lXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd3Z1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtVjFjRjkyWVhWc2RDNWpiMjUwY21GamRDNVRZWFpsVlhCV1lYVnNkQzUzYVhSb1pISmhkMTlsWVhKc2VWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNYMlZoY214NU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OaGRtVmtXMVI0Ymk1elpXNWtaWEpkSUQ0OUlHRnRiM1Z1ZEN3Z0lrbHVjM1ZtWm1samFXVnVkQ0IyWVhWc2RDQmlZV3hoYm1ObElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk5oZG1Wa0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjMkYyWldRZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ2RtRjFiSFFnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklIQmxibUZzZEhrZ1BTQmhiVzkxYm5RZ0x5OGdWVWx1ZERZMEtGQkZUa0ZNVkZsZlJFbFdTVk5QVWlrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUc1bGRDQTlJR0Z0YjNWdWRDQXRJSEJsYm1Gc2RIa0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMlpYVndYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakUwTWkweE5EWUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXVaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWmxkWEJmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhabGRYQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyWlhWd1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOREl0TVRRMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWJtVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUhObGJHWXVjMkYyWldSYlZIaHVMbk5sYm1SbGNsMGdQU0J6Wld4bUxuTmhkbVZrVzFSNGJpNXpaVzVrWlhKZElDMGdZVzF2ZFc1MENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljMkYyWldRaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpZWFpsWkNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpZWFpsWkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbVYxY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXd3VkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNMblpoYkhWbElDMGdZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXd2daWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJaWFZ3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbVYxY0Y5MllYVnNkQzVqYjI1MGNtRmpkQzVUWVhabFZYQldZWFZzZEM1elpYUmZiRzlqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlzYjJOck9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtVjFjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1WMWNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOVFFLSUNBZ0lDOHZJSE5sYkdZdWJHOWphMXRVZUc0dWMyVnVaR1Z5WFNBOUlHeHZZMnRmZFc1MGFXeGZjbTkxYm1RS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WTJzaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpsZFhCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJQWlZS0JYTmhkbVZrQlhSdmRHRnNCV3hsZG1Wc0JXTnZkVzUwQkd4dlkyc0NiVEVDYlRJQ2JUTUNiVFFDYlRXQUJEREcxWW8yR2dDT0FRQTdNUmtVUkRFWVFRQWtnZ1FFYmk2OG13UWg4ZDMvQkxoWGtmQUVWVkVKMWpZYUFJNEVBRjhCRUFGWUFac0FnQVJNWEdHNk5ob0FqZ0VBREFBeEdTTVNNUmdRUkVJQUxpY0ZnWUN0NGdSbkp3YUJnT0hyRjJjbkI0R0F3dGN2WnljSWdZRGxtbmRuSndtQmdNcTE3Z0ZuS1NKbkkwTXhBQ2dpWmpFQUt5Sm1NUUFuQkNKbU1RQXFJbVlqUXpZYUFSVWtFa1F5QkNVU1JDSTRFQ01TUkNJNEJ6SUtFa1FpT0FBeEFCSkVJamdJTVFBaUtHTkVTd0VJTVFBb1R3Sm1NUUFpSzJORUl3Z3hBQ3RQQW1ZaUtXVkVDQ2xNWnpFQUlpaGpURWxQQWtRaUp3bGxSQTlCQUFneEFDcUJCV1lqUXlJbkNHVkVTd0VPUVFBSk1RQXFnUVJtUXYvcUlpY0haVVJMQVE1QkFBa3hBQ3FCQTJaQy85WWlKd1psUkVzQkRrRUFDREVBS2lWbVF2L0RJaWNGWlVSTEFRNUIvN2d4QUNvalprTC9zRFlhQVVrVkpCSkVGekVBSWljRVkwUXlCZzVFTVFBaUtHTkVTd0VQUkxFeEFFc0JzZ2l5QnlPeUVDS3lBYk14QUNJb1kwUkxBUWt4QUNoUEFtWWlLV1ZFVEFrcFRHY2pRellhQVVrVkpCSkVGekVBSWloalJFc0JEMFJKZ1FvS1N3Rk1DYkV4QUxJSHNnZ2pzaEFpc2dHek1RQWlLR05FU3dFSk1RQW9Ud0ptSWlsbFJFd0pLVXhuSTBNMkdnRkpGU1FTUkJjeEFDY0VUd0ptSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
