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

namespace Arc56.Generated.devndesigner6.unsubly.DisputeEscrow_e80e5824
{


    //
    // 
    //    Dispute-Resolution Escrow Vault (ARC-4 compliant).
    //
    //    A neutral arbitrator is designated at creation. Either the original
    //    creator OR the arbitrator can call release() or kill() to resolve a
    //    dispute — giving the arbitrator power to decide the outcome.
    //
    //    GlobalState:
    //        creator     — account that deployed and funded the vault
    //        recipient   — account that receives funds on release
    //        arbitrator  — neutral third party with release/kill powers
    //        status      — 0 = locked, 1 = released, 2 = killed
    //    
    //
    public class DisputeEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DisputeEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy the vault with a designated arbitrator.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="arbitrator"> </param>
        public async Task Create(Algorand.Address recipient, Algorand.Address arbitrator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var arbitratorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbitratorAbi.From(arbitrator);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, arbitratorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address recipient, Algorand.Address arbitrator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var arbitratorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbitratorAbi.From(arbitrator);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, arbitratorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release funds to recipient. Callable by creator or arbitrator.
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
        ///Reclaim funds to creator. Callable by creator or arbitrator.
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
        ///Delete the application after it is no longer locked.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlzcHV0ZUVzY3JvdyIsImRlc2MiOiJcbiAgICBEaXNwdXRlLVJlc29sdXRpb24gRXNjcm93IFZhdWx0IChBUkMtNCBjb21wbGlhbnQpLlxuXG4gICAgQSBuZXV0cmFsIGFyYml0cmF0b3IgaXMgZGVzaWduYXRlZCBhdCBjcmVhdGlvbi4gRWl0aGVyIHRoZSBvcmlnaW5hbFxuICAgIGNyZWF0b3IgT1IgdGhlIGFyYml0cmF0b3IgY2FuIGNhbGwgcmVsZWFzZSgpIG9yIGtpbGwoKSB0byByZXNvbHZlIGFcbiAgICBkaXNwdXRlIOKAlCBnaXZpbmcgdGhlIGFyYml0cmF0b3IgcG93ZXIgdG8gZGVjaWRlIHRoZSBvdXRjb21lLlxuXG4gICAgR2xvYmFsU3RhdGU6XG4gICAgICAgIGNyZWF0b3IgICAgIOKAlCBhY2NvdW50IHRoYXQgZGVwbG95ZWQgYW5kIGZ1bmRlZCB0aGUgdmF1bHRcbiAgICAgICAgcmVjaXBpZW50ICAg4oCUIGFjY291bnQgdGhhdCByZWNlaXZlcyBmdW5kcyBvbiByZWxlYXNlXG4gICAgICAgIGFyYml0cmF0b3IgIOKAlCBuZXV0cmFsIHRoaXJkIHBhcnR5IHdpdGggcmVsZWFzZS9raWxsIHBvd2Vyc1xuICAgICAgICBzdGF0dXMgICAgICDigJQgMCA9IGxvY2tlZCwgMSA9IHJlbGVhc2VkLCAyID0ga2lsbGVkXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3kgdGhlIHZhdWx0IHdpdGggYSBkZXNpZ25hdGVkIGFyYml0cmF0b3IuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmJpdHJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2UiLCJkZXNjIjoiUmVsZWFzZSBmdW5kcyB0byByZWNpcGllbnQuIENhbGxhYmxlIGJ5IGNyZWF0b3Igb3IgYXJiaXRyYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoia2lsbCIsImRlc2MiOiJSZWNsYWltIGZ1bmRzIHRvIGNyZWF0b3IuIENhbGxhYmxlIGJ5IGNyZWF0b3Igb3IgYXJiaXRyYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlIiwiZGVzYyI6IkRlbGV0ZSB0aGUgYXBwbGljYXRpb24gYWZ0ZXIgaXQgaXMgbm8gbG9uZ2VyIGxvY2tlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjU2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBkZWxldGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3Igb3IgYXJiaXRyYXRvciBjYW4ga2lsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBvciBhcmJpdHJhdG9yIGNhbiByZWxlYXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5LDIyMF0sImVycm9yTWVzc2FnZSI6IlZhdWx0IGlzIG5vdCBsb2NrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjFdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBzdGlsbCBsb2NrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTgsMjA5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcmJpdHJhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MSwyMDMsMjUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jcmVhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVjaXBpZW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NywyMTgsMjYwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxLDEyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTjBZWFIxY3lJZ0ltTnlaV0YwYjNJaUlDSmhjbUpwZEhKaGRHOXlJaUFpY21WamFYQnBaVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUdOc1lYTnpJRVJwYzNCMWRHVkZjMk55YjNjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwTXpjNFpETmpJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5a1pXeGxkR1ZmY205MWRHVkFOQW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdZMnhoYzNNZ1JHbHpjSFYwWlVWelkzSnZkeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TUFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBM05tSmlaRFJrSURCNFlqbGpNakV4TlRVZ0x5OGdiV1YwYUc5a0lDSnlaV3hsWVhObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcmFXeHNLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djbVZzWldGelpTQnJhV3hzQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveE13b2dJQ0FnTHk4Z1kyeGhjM01nUkdsemNIVjBaVVZ6WTNKdmR5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dFNU5qazRNR1VnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQmtaV3hsZEdVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2x6Y0hWMFpTNWpiMjUwY21GamRDNUVhWE53ZFhSbFJYTmpjbTkzTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFN3Z1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG5KbFkybHdhV1Z1ZEM1MllXeDFaU0E5SUhKbFkybHdhV1Z1ZEFvZ0lDQWdZbmwwWldOZk15QXZMeUFpY21WamFYQnBaVzUwSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdVlYSmlhWFJ5WVhSdmNpNTJZV3gxWlNBOUlHRnlZbWwwY21GMGIzSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRnlZbWwwY21GMGIzSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlM1amIyNTBjbUZqZEM1RWFYTndkWFJsUlhOamNtOTNMbkpsYkdWaGMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5Wld4bFlYTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBOZ29nSUNBZ0x5OGdhWE5mWTNKbFlYUnZjaUE5SUhObGJtUmxjbDloWkdSeUlEMDlJSE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUdselgyRnlZbWwwY21GMGIzSWdQU0J6Wlc1a1pYSmZZV1JrY2lBOVBTQnpaV3htTG1GeVltbDBjbUYwYjNJdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbUpwZEhKaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GeVltbDBjbUYwYjNJZ1pYaHBjM1J6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdselgyTnlaV0YwYjNJZ2IzSWdhWE5mWVhKaWFYUnlZWFJ2Y2l3Z0lrOXViSGtnWTNKbFlYUnZjaUJ2Y2lCaGNtSnBkSEpoZEc5eUlHTmhiaUJ5Wld4bFlYTmxJZ29nSUNBZ2ZId0tJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdiM0lnWVhKaWFYUnlZWFJ2Y2lCallXNGdjbVZzWldGelpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pXWVhWc2RDQnBjeUJ1YjNRZ2JHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ2FYTWdibTkwSUd4dlkydGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR0Z3Y0Y5aFpHUnlJRDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJpWVd4aGJtTmxJRDBnYjNBdVltRnNZVzVqWlNoaGNIQmZZV1JrY2lrS0lDQWdJR1IxY0FvZ0lDQWdZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHMXBibDlpWVd4aGJtTmxJRDBnYjNBdWJXbHVYMkpoYkdGdVkyVW9ZWEJ3WDJGa1pISXBDaUFnSUNCemQyRndDaUFnSUNCdGFXNWZZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklIQmhlVzkxZENBOUlHSmhiR0Z1WTJVZ0xTQnRhVzVmWW1Gc1lXNWpaUW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5UWXROakFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG5KbFkybHdhV1Z1ZEM1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEJoZVc5MWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCeVpXTmxhWFpsY2oxelpXeG1MbkpsWTJsd2FXVnVkQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpY21WamFYQnBaVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxZMmx3YVdWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTmkwMk1Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjbVZqYVhCcFpXNTBMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNHRjViM1YwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVJHbHpjSFYwWlVWelkzSnZkeTVyYVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thMmxzYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCelpXNWtaWEpmWVdSa2NpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUdselgyTnlaV0YwYjNJZ1BTQnpaVzVrWlhKZllXUmtjaUE5UFNCelpXeG1MbU55WldGMGIzSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXRjBiM0lnWlhocGMzUnpDaUFnSUNCa2RYQXlDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklHbHpYMkZ5WW1sMGNtRjBiM0lnUFNCelpXNWtaWEpmWVdSa2NpQTlQU0J6Wld4bUxtRnlZbWwwY21GMGIzSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY21KcGRISmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnlZbWwwY21GMGIzSWdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdZWE56WlhKMElHbHpYMk55WldGMGIzSWdiM0lnYVhOZllYSmlhWFJ5WVhSdmNpd2dJazl1YkhrZ1kzSmxZWFJ2Y2lCdmNpQmhjbUpwZEhKaGRHOXlJR05oYmlCcmFXeHNJZ29nSUNBZ2ZId0tJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdiM0lnWVhKaWFYUnlZWFJ2Y2lCallXNGdhMmxzYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrc0lDSldZWFZzZENCcGN5QnViM1FnYkc5amEyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtRjFiSFFnYVhNZ2JtOTBJR3h2WTJ0bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklHRndjRjloWkdSeUlEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmlZV3hoYm1ObElEMGdiM0F1WW1Gc1lXNWpaU2hoY0hCZllXUmtjaWtLSUNBZ0lHUjFjQW9nSUNBZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUcxcGJsOWlZV3hoYm1ObElEMGdiM0F1YldsdVgySmhiR0Z1WTJVb1lYQndYMkZrWkhJcENpQWdJQ0J6ZDJGd0NpQWdJQ0J0YVc1ZlltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUhCaGVXOTFkQ0E5SUdKaGJHRnVZMlVnTFNCdGFXNWZZbUZzWVc1alpRb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpndE9ESUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbU55WldGMGIzSXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxd1lYbHZkWFFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk56Z3RPRElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVJHbHpjSFYwWlVWelkzSnZkeTVrWld4bGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdZWE56WlhKMElHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR1JsYkdWMFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXRjBiM0lnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdSbGJHVjBaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQWhQU0JWU1c1ME5qUW9NQ2tzSUNKV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2preUxUazNDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5YzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWVcxdmRXNTBQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qa3lMVGszQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCamJHOXpaVjl5WlcxaGFXNWtaWEpmZEc4OWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRWdKZ1FHYzNSaGRIVnpCMk55WldGMGIzSUtZWEppYVhSeVlYUnZjZ2x5WldOcGNHbGxiblNBQkNRM2pUdzJHZ0NPQVFBdE1Sa1VSREVZUVFBV2dnSUVCMnU5VFFTNXdoRlZOaG9BamdJQU93QnZBSUFFaXBhWURqWWFBSTRCQUEwQU1SbUJCUkl4R0JCRVFnQ0VOaG9CU1JVa0VrUTJHZ0pKRlNRU1JDa3hBR2NyVHdKbktreG5LQ0puSTBNeEFDSXBaVVJMQVJJaUttVkVUd0lTRVVRaUtHVkVGRVF5Q2tsZ1RIZ0pzU0lyWlVTeUI3SUlJN0lRSXJJQnN5Z2paeU5ETVFBaUtXVkVTaElpS21WRVR3TVNFVVFpS0dWRUZFUXlDa2xnVEhnSnNiSUlzZ2Nqc2hBaXNnR3pLSUVDWnlORE1RQWlLV1ZFVEVzQkVrUWlLR1ZFUkxGSnNna2lzZ2l5QnlPeUVDS3lBYk1qUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
