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

namespace Arc56.Generated.devndesigner6.unsubly.ASAEscrow_2f46d130
{


    //
    // 
    //    Algorand Standard Asset (ASA / Token) Escrow Vault (ARC-4 compliant).
    //
    //    Handles escrow of ASA tokens instead of native ALGO. The application
    //    must opt in to the ASA before tokens can be transferred to it.
    //
    //    GlobalState:
    //        creator    — account that deployed the vault
    //        recipient  — account that receives tokens on release
    //        asa_id     — ASA / token ID being held in escrow
    //        status     — 0 = locked, 1 = released, 2 = killed
    //    
    //
    public class ASAEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ASAEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy the ASA vault and record creator, recipient, and asset.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="asa_id"> </param>
        public async Task Create(Algorand.Address recipient, ulong asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address recipient, ulong asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 182, 67, 82 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asa_idAbi.From(asa_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the application account into the ASA so it can receive tokens.
        ///Must be called (and funded) by creator before transferring tokens.
        ///</summary>
        public async Task Optin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 13, 231, 235 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Optin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 13, 231, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer all held ASA tokens to recipient. Only callable by creator.
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
        ///Return all held ASA tokens to creator. Only callable by creator.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVNBRXNjcm93IiwiZGVzYyI6IlxuICAgIEFsZ29yYW5kIFN0YW5kYXJkIEFzc2V0IChBU0EgLyBUb2tlbikgRXNjcm93IFZhdWx0IChBUkMtNCBjb21wbGlhbnQpLlxuXG4gICAgSGFuZGxlcyBlc2Nyb3cgb2YgQVNBIHRva2VucyBpbnN0ZWFkIG9mIG5hdGl2ZSBBTEdPLiBUaGUgYXBwbGljYXRpb25cbiAgICBtdXN0IG9wdCBpbiB0byB0aGUgQVNBIGJlZm9yZSB0b2tlbnMgY2FuIGJlIHRyYW5zZmVycmVkIHRvIGl0LlxuXG4gICAgR2xvYmFsU3RhdGU6XG4gICAgICAgIGNyZWF0b3IgICAg4oCUIGFjY291bnQgdGhhdCBkZXBsb3llZCB0aGUgdmF1bHRcbiAgICAgICAgcmVjaXBpZW50ICDigJQgYWNjb3VudCB0aGF0IHJlY2VpdmVzIHRva2VucyBvbiByZWxlYXNlXG4gICAgICAgIGFzYV9pZCAgICAg4oCUIEFTQSAvIHRva2VuIElEIGJlaW5nIGhlbGQgaW4gZXNjcm93XG4gICAgICAgIHN0YXR1cyAgICAg4oCUIDAgPSBsb2NrZWQsIDEgPSByZWxlYXNlZCwgMiA9IGtpbGxlZFxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiRGVwbG95IHRoZSBBU0EgdmF1bHQgYW5kIHJlY29yZCBjcmVhdG9yLCByZWNpcGllbnQsIGFuZCBhc3NldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNhX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdGluIiwiZGVzYyI6Ik9wdCB0aGUgYXBwbGljYXRpb24gYWNjb3VudCBpbnRvIHRoZSBBU0Egc28gaXQgY2FuIHJlY2VpdmUgdG9rZW5zLlxuTXVzdCBiZSBjYWxsZWQgKGFuZCBmdW5kZWQpIGJ5IGNyZWF0b3IgYmVmb3JlIHRyYW5zZmVycmluZyB0b2tlbnMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2UiLCJkZXNjIjoiVHJhbnNmZXIgYWxsIGhlbGQgQVNBIHRva2VucyB0byByZWNpcGllbnQuIE9ubHkgY2FsbGFibGUgYnkgY3JlYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoia2lsbCIsImRlc2MiOiJSZXR1cm4gYWxsIGhlbGQgQVNBIHRva2VucyB0byBjcmVhdG9yLiBPbmx5IGNhbGxhYmxlIGJ5IGNyZWF0b3IuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZSIsImRlc2MiOiJEZWxldGUgdGhlIGFwcGxpY2F0aW9uIGFmdGVyIHJlbGVhc2Ugb3Iga2lsbC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjk2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBkZWxldGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGtpbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIG9wdCBpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gcmVsZWFzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NiwyNTBdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBpcyBub3QgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAxXSwiZXJyb3JNZXNzYWdlIjoiVmF1bHQgc3RpbGwgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzLDIwMCwyNTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzYV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTcsMTg4LDIzOSwyOTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWNpcGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0LDI0OCwzMDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YXR1cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdOQW9nSUNBZ1lubDBaV05pYkc5amF5QWljM1JoZEhWeklpQWlZM0psWVhSdmNpSWdJbUZ6WVY5cFpDSWdJbkpsWTJsd2FXVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjMkZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCamJHRnpjeUJCVTBGRmMyTnliM2NvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBNemM0WkROaklDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlrWld4bGRHVmZjbTkxZEdWQU5Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1FWTkJSWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXhDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaR013WkdVM1pXSWdNSGd3TnpaaVltUTBaQ0F3ZUdJNVl6SXhNVFUxSUM4dklHMWxkR2h2WkNBaWIzQjBhVzRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYkdWaGMyVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltdHBiR3dvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J2Y0hScGJpQnlaV3hsWVhObElHdHBiR3dLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QmpiR0Z6Y3lCQlUwRkZjMk55YjNjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR013WWpZME16VXlJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LYldGcGJsOWtaV3hsZEdWZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQmtaV3hsZEdVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE5oWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVCVTBGRmMyTnliM2N1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklITmxiR1l1Y21WamFYQnBaVzUwTG5aaGJIVmxJRDBnY21WamFYQnBaVzUwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p5WldOcGNHbGxiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNWhjMkZmYVdRdWRtRnNkV1VnUFNCaGMyRmZhV1FLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ6WVY5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYzJGZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtGVFFVVnpZM0p2ZHk1dmNIUnBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RHbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUdGemMyVnlkQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDBnYzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCdmNIUWdhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzSmxZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZoZEc5eUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHOXdkQ0JwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklHRnpjMlYwSUQwZ1FYTnpaWFFvYzJWc1ppNWhjMkZmYVdRdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWE5oWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ6WVY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qVXlMVFUzQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPalV5TFRVM0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGMyRmZaWE5qY205M0xtTnZiblJ5WVdOMExrRlRRVVZ6WTNKdmR5NXlaV3hsWVhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZzWldGelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaU3dnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnY21Wc1pXRnpaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV0YwYjNJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2NtVnNaV0Z6WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ6WVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pXWVhWc2RDQnBjeUJ1YjNRZ2JHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ2FYTWdibTkwSUd4dlkydGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVjBJRDBnUVhOelpYUW9jMlZzWmk1aGMyRmZhV1F1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlYTmhYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpZVjlwWkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjMkZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGNIQmZZV1JrY21WemN5QTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnZEc5clpXNWZZbUZzWVc1alpTd2dZWE56WlhSZlpYaHBjM1J6SUQwZ2IzQXVRWE56WlhSSWIyeGthVzVuUjJWMExtRnpjMlYwWDJKaGJHRnVZMlVvWVhCd1gyRmtaSEpsYzNNc0lHRnpjMlYwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWMFgyaHZiR1JwYm1kZloyVjBJRUZ6YzJWMFFtRnNZVzVqWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWE5oWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvMk9TMDNOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzJWc1ppNXlaV05wY0dsbGJuUXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDEwYjJ0bGJsOWlZV3hoYm1ObExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyTnNiM05sWDNSdlBYTmxiR1l1Y21WamFYQnBaVzUwTG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MbkpsWTJsd2FXVnVkQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpY21WamFYQnBaVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxZMmx3YVdWdWRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFTnNiM05sVkc4S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGellWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOamt0TnpVS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1Y21WamFYQnBaVzUwTG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWRHOXJaVzVmWW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjlqYkc5elpWOTBiejF6Wld4bUxuSmxZMmx3YVdWdWRDNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjMkZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVhOaFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1QlUwRkZjMk55YjNjdWEybHNiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q210cGJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnWVhOelpYSjBJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VzSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUd0cGJHd2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNKbFlYUnZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amNtVmhkRzl5SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCcmFXeHNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TXdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lsWmhkV3gwSUdseklHNXZkQ0JzYjJOclpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFIxY3lCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0JwY3lCdWIzUWdiRzlqYTJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdZWE56WlhRZ1BTQkJjM05sZENoelpXeG1MbUZ6WVY5cFpDNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poYzJGZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhOaFgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGellWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJR0Z3Y0Y5aFpHUnlaWE56SUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QjBiMnRsYmw5aVlXeGhibU5sTENCaGMzTmxkRjlsZUdsemRITWdQU0J2Y0M1QmMzTmxkRWh2YkdScGJtZEhaWFF1WVhOelpYUmZZbUZzWVc1alpTaGhjSEJmWVdSa2NtVnpjeXdnWVhOelpYUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamc1TFRrMUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMXpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxMGIydGxibDlpWVd4aGJtTmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMk5zYjNObFgzUnZQWE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRU5zYjNObFZHOEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjMkZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T0RrdE9UVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYUnZhMlZ1WDJKaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWTJ4dmMyVmZkRzg5YzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYTmhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFNCVlNXNTBOalFvTWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZWE5oWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVCVTBGRmMyTnliM2N1WkdWc1pYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnpZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCaGMzTmxjblFnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5SUhObGJHWXVZM0psWVhSdmNpNTJZV3gxWlN3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z1pHVnNaWFJsSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdaR1ZzWlhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhOaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQWhQU0JWU1c1ME5qUW9NQ2tzSUNKV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYzJGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXdOUzB4TVRBS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sWDNKbGJXRnBibVJsY2w5MGJ6MXpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zYjNObFVtVnRZV2x1WkdWeVZHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGMyRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnWVcxdmRXNTBQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjMkZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGellWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGellWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEExTFRFeE1Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVZM0psWVhSdmNpNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWZmNtVnRZV2x1WkdWeVgzUnZQWE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGellWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFRUpnUUdjM1JoZEhWekIyTnlaV0YwYjNJR1lYTmhYMmxrQ1hKbFkybHdhV1Z1ZElBRUpEZU5QRFlhQUk0QkFEUXhHUlJFTVJoQkFCMkNBd1RjRGVmckJBZHJ2VTBFdWNJUlZUWWFBSTREQUQ0QVhRQ1FBSUFFd0xaRFVqWWFBSTRCQUEwQU1SbUJCUkl4R0JCRVFnQ3BOaG9CU1JXQklCSkVOaG9DU1JXQkNCSkVGeWt4QUdjclR3Sm5La3huS0NKbkkwTXhBQ0lwWlVRU1JDSXFaVVN4TWdvaXNoS3lGTElSSkxJUUlySUJzeU5ETVFBaUtXVkVFa1FpS0dWRUZFUWlLbVZFTWdwTEFYQUFTTEVpSzJWRVNiSVZzaFN5RXJJUkpMSVFJcklCc3lnalp5TkRNUUFpS1dWRVRFc0JFa1FpS0dWRUZFUWlLbVZFTWdwTEFYQUFTTEZMQXJJVnNoS3lFYklVSkxJUUlySUJzeWlCQW1jalF6RUFJaWxsUkV4TEFSSkVJaWhsUkVTeFNiSUpJcklJc2djanNoQWlzZ0d6STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
