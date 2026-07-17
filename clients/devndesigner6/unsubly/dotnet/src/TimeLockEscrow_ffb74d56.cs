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

namespace Arc56.Generated.devndesigner6.unsubly.TimeLockEscrow_ffb74d56
{


    //
    // 
    //    Time-Locked Escrow Vault (ARC-4 compliant).
    //
    //    Identical to standard escrow but release() is blocked until
    //    Global.latest_timestamp >= unlock_time.
    //
    //    GlobalState:
    //        creator      — account that deployed and funded the vault
    //        recipient    — account that receives funds on release
    //        status       — 0 = locked, 1 = released, 2 = killed
    //        unlock_time  — Unix timestamp after which release is allowed
    //    
    //
    public class TimeLockEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TimeLockEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy the vault with a time-lock.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="unlock_time"> </param>
        public async Task Create(Algorand.Address recipient, ulong unlock_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var unlock_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unlock_timeAbi.From(unlock_time);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, unlock_timeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address recipient, ulong unlock_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var unlock_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unlock_timeAbi.From(unlock_time);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, unlock_timeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release funds to recipient after time-lock expires.
        ///</summary>
        public async Task Release(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 107, 189, 77 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Release_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 7, 107, 189, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reclaim funds back to creator (no time restriction on kill).
        ///</summary>
        public async Task Kill(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Kill_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the application after release or kill.
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGltZUxvY2tFc2Nyb3ciLCJkZXNjIjoiXG4gICAgVGltZS1Mb2NrZWQgRXNjcm93IFZhdWx0IChBUkMtNCBjb21wbGlhbnQpLlxuXG4gICAgSWRlbnRpY2FsIHRvIHN0YW5kYXJkIGVzY3JvdyBidXQgcmVsZWFzZSgpIGlzIGJsb2NrZWQgdW50aWxcbiAgICBHbG9iYWwubGF0ZXN0X3RpbWVzdGFtcCA+PSB1bmxvY2tfdGltZS5cblxuICAgIEdsb2JhbFN0YXRlOlxuICAgICAgICBjcmVhdG9yICAgICAg4oCUIGFjY291bnQgdGhhdCBkZXBsb3llZCBhbmQgZnVuZGVkIHRoZSB2YXVsdFxuICAgICAgICByZWNpcGllbnQgICAg4oCUIGFjY291bnQgdGhhdCByZWNlaXZlcyBmdW5kcyBvbiByZWxlYXNlXG4gICAgICAgIHN0YXR1cyAgICAgICDigJQgMCA9IGxvY2tlZCwgMSA9IHJlbGVhc2VkLCAyID0ga2lsbGVkXG4gICAgICAgIHVubG9ja190aW1lICDigJQgVW5peCB0aW1lc3RhbXAgYWZ0ZXIgd2hpY2ggcmVsZWFzZSBpcyBhbGxvd2VkXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3kgdGhlIHZhdWx0IHdpdGggYSB0aW1lLWxvY2suIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVubG9ja190aW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2UiLCJkZXNjIjoiUmVsZWFzZSBmdW5kcyB0byByZWNpcGllbnQgYWZ0ZXIgdGltZS1sb2NrIGV4cGlyZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImtpbGwiLCJkZXNjIjoiUmVjbGFpbSBmdW5kcyBiYWNrIHRvIGNyZWF0b3IgKG5vIHRpbWUgcmVzdHJpY3Rpb24gb24ga2lsbCkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZSIsImRlc2MiOiJEZWxldGUgdGhlIGFwcGxpY2F0aW9uIGFmdGVyIHJlbGVhc2Ugb3Iga2lsbC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjUxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBkZWxldGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGtpbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHJlbGVhc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOiJUaW1lLWxvY2sgbm90IGV4cGlyZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyLDIxNV0sImVycm9yTWVzc2FnZSI6IlZhdWx0IGlzIG5vdCBsb2NrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTZdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBzdGlsbCBsb2NrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTQsMjA0LDI0Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY3JlYXRvciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlY2lwaWVudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjAsMjEzLDI1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhdHVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudW5sb2NrX3RpbWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbk4wWVhSMWN5SWdJbU55WldGMGIzSWlJQ0p5WldOcGNHbGxiblFpSUNKMWJteHZZMnRmZEdsdFpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG94TXdvZ0lDQWdMeThnWTJ4aGMzTWdWR2x0WlV4dlkydEZjMk55YjNjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwTXpjNFpETmpJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5a1pXeGxkR1ZmY205MWRHVkFOQW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbHRaVjlzYjJOclpXUXZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUdOc1lYTnpJRlJwYldWTWIyTnJSWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNRGMyWW1Ka05HUWdNSGhpT1dNeU1URTFOU0F2THlCdFpYUm9iMlFnSW5KbGJHVmhjMlVvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbXRwYkd3b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXeGxZWE5sSUd0cGJHd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhVzFsWDJ4dlkydGxaQzlqYjI1MGNtRmpkQzV3ZVRveE13b2dJQ0FnTHk4Z1kyeGhjM01nVkdsdFpVeHZZMnRGYzJOeWIzY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdNd1lqWTBNelV5SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnWkdWc1pYUmxDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5ScGJXVmZiRzlqYTJWa0xtTnZiblJ5WVdOMExsUnBiV1ZNYjJOclJYTmpjbTkzTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhVzFsWDJ4dlkydGxaQzlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNJR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScGJXVmZiRzlqYTJWa0wyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScGJXVmZiRzlqYTJWa0wyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxZMmx3YVdWdWRDNTJZV3gxWlNBOUlISmxZMmx3YVdWdWRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVmphWEJwWlc1MElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwYldWZmJHOWphMlZrTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsdFpWOXNiMk5yWldRdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdWRXNXNiMk5yWDNScGJXVXVkbUZzZFdVZ1BTQjFibXh2WTJ0ZmRHbHRaUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkVzVzYjJOclgzUnBiV1VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwYldWZmJHOWphMlZrTDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHbHRaVjlzYjJOclpXUXVZMjl1ZEhKaFkzUXVWR2x0WlV4dlkydEZjMk55YjNjdWNtVnNaV0Z6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxiR1ZoYzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsdFpWOXNiMk5yWldRdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMGdjMlZzWmk1amNtVmhkRzl5TG5aaGJIVmxMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ5Wld4bFlYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OeVpXRjBiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkzSmxZWFJ2Y2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCeVpXeGxZWE5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2x0WlY5c2IyTnJaV1F2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pXWVhWc2RDQnBjeUJ1YjNRZ2JHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ2FYTWdibTkwSUd4dlkydGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQajBnYzJWc1ppNTFibXh2WTJ0ZmRHbHRaUzUyWVd4MVpTd2dJbFJwYldVdGJHOWpheUJ1YjNRZ1pYaHdhWEpsWkNCNVpYUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRXNXNiMk5yWDNScGJXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZFc1c2IyTnJYM1JwYldVZ1pYaHBjM1J6Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklGUnBiV1V0Ykc5amF5QnViM1FnWlhod2FYSmxaQ0I1WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdZWEJ3WDJGa1pISWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCaVlXeGhibU5sSUQwZ2IzQXVZbUZzWVc1alpTaGhjSEJmWVdSa2Npa0tJQ0FnSUdSMWNBb2dJQ0FnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCdGFXNWZZbUZzWVc1alpTQTlJRzl3TG0xcGJsOWlZV3hoYm1ObEtHRndjRjloWkdSeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnYldsdVgySmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdjR0Y1YjNWMElEMGdZbUZzWVc1alpTQXRJRzFwYmw5aVlXeGhibU5sQ2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbHRaVjlzYjJOclpXUXZZMjl1ZEhKaFkzUXVjSGs2TlRNdE5UY0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbkpsWTJsd2FXVnVkQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhVzFsWDJ4dlkydGxaQzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWMyVnNaaTV5WldOcGNHbGxiblF1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5KbFkybHdhV1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV05wY0dsbGJuUWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScGJXVmZiRzlqYTJWa0wyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2x0WlY5c2IyTnJaV1F2WTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2x0WlY5c2IyTnJaV1F2WTI5dWRISmhZM1F1Y0hrNk5UTXROVGNLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG5KbFkybHdhV1Z1ZEM1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJoZVc5MWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdsdFpWOXNiMk5yWldRdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJwYldWZmJHOWphMlZrTG1OdmJuUnlZV04wTGxScGJXVk1iMk5yUlhOamNtOTNMbXRwYkd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHJhV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwYldWZmJHOWphMlZrTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QmhjM05sY25RZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOUlITmxiR1l1WTNKbFlYUnZjaTUyWVd4MVpTd2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdhMmxzYkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU55WldGMGIzSWdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR3RwYkd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLU3dnSWxaaGRXeDBJR2x6SUc1dmRDQnNiMk5yWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWVhWc2RDQnBjeUJ1YjNRZ2JHOWphMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2x0WlY5c2IyTnJaV1F2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklHRndjRjloWkdSeUlEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnWW1Gc1lXNWpaU0E5SUc5d0xtSmhiR0Z1WTJVb1lYQndYMkZrWkhJcENpQWdJQ0JrZFhBS0lDQWdJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnYldsdVgySmhiR0Z1WTJVZ1BTQnZjQzV0YVc1ZlltRnNZVzVqWlNoaGNIQmZZV1JrY2lrS0lDQWdJSE4zWVhBS0lDQWdJRzFwYmw5aVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR2x0WlY5c2IyTnJaV1F2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklIQmhlVzkxZENBOUlHSmhiR0Z1WTJVZ0xTQnRhVzVmWW1Gc1lXNWpaUW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNScGJXVmZiRzlqYTJWa0wyTnZiblJ5WVdOMExuQjVPamN5TFRjMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y0dGNWIzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGFXMWxYMnh2WTJ0bFpDOWpiMjUwY21GamRDNXdlVG8zTWdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwYldWZmJHOWphMlZrTDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JwYldWZmJHOWphMlZrTDJOdmJuUnlZV04wTG5CNU9qY3lMVGMyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1YjNWMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnBiV1ZmYkc5amEyVmtMbU52Ym5SeVlXTjBMbFJwYldWTWIyTnJSWE5qY205M0xtUmxiR1YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdZWE56WlhKMElHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR1JsYkdWMFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXRjBiM0lnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdSbGJHVjBaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnSVQwZ1ZVbHVkRFkwS0RBcExDQWlWbUYxYkhRZ2MzUnBiR3dnYkc5amEyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ2MzUnBiR3dnYkc5amEyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbHRaVjlzYjJOclpXUXZZMjl1ZEhKaFkzUXVjSGs2T0RZdE9URUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbU55WldGMGIzSXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFgzSmxiV0ZwYm1SbGNsOTBiejF6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBhVzFsWDJ4dlkydGxaQzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1lXMXZkVzUwUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYVcxbFgyeHZZMnRsWkM5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnBiV1ZmYkc5amEyVmtMMk52Ym5SeVlXTjBMbkI1T2pnMkxUa3hDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5YzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHbHRaVjlzYjJOclpXUXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1CQVp6ZEdGMGRYTUhZM0psWVhSdmNnbHlaV05wY0dsbGJuUUxkVzVzYjJOclgzUnBiV1dBQkNRM2pUdzJHZ0NPQVFBdE1Sa1VSREVZUVFBV2dnSUVCMnU5VFFTNXdoRlZOaG9BamdJQVBnQndBSUFFd0xaRFVqWWFBSTRCQUEwQU1SbUJCUkl4R0JCRVFnQi9OaG9CU1JXQklCSkVOaG9DU1JXQkNCSkVGeWt4QUdjcVR3Sm5LQ0puSzB4bkkwTXhBQ0lwWlVRU1JDSW9aVVFVUkRJSElpdGxSQTlFTWdwSllFeDRDYkVpS21WRXNnZXlDQ095RUNLeUFiTW9JMmNqUXpFQUlpbGxSRXhMQVJKRUlpaGxSQlJFTWdwSllFeDRDYkd5Q0xJSEk3SVFJcklCc3lpQkFtY2pRekVBSWlsbFJFeExBUkpFSWlobFJFU3hTYklKSXJJSXNnY2pzaEFpc2dHekkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
