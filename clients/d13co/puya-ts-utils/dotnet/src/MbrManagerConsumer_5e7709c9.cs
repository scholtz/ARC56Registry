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

namespace Arc56.Generated.d13co.puya_ts_utils.MbrManagerConsumer_5e7709c9
{


    //
    // A minimal registry charging its boxes to the sender's MBR credits — something for
    //the test suite to call, and the worked example for `MbrManager`. Each account owns
    //the one entry keyed by its address, so only its owner can resize or delete it and
    //claim the refund.
    //
    public class MbrManagerConsumerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MbrManagerConsumerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Store the sender's value, charging any box MBR increase to their credits.
        ///</summary>
        /// <param name="value"> </param>
        public async Task Put(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 52, 5, 14 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Put_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 52, 5, 14 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the sender's value, refunding the freed box MBR to their credits.
        ///</summary>
        public async Task Remove(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 30, 196, 86 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Remove_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 30, 196, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit MBR credits for an account. The payment amount becomes the credit; opening
        ///the creditor's credit box is paid out of the deposit itself, so a first deposit nets
        ///amount minus the box MBR — whoever sends it.
        ///</summary>
        /// <param name="creditor">Account to credit (need not be the sender) </param>
        /// <param name="txn">Payment to the contract; its amount is the credit received </param>
        public async Task DepositCredits(PaymentTransaction txn, Algorand.Address creditor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 61, 117, 240, 196 };
            var creditorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creditorAbi.From(creditor);

            var result = await base.CallApp(new List<object> { abiHandle, creditorAbi, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositCredits_Transactions(PaymentTransaction txn, Algorand.Address creditor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 61, 117, 240, 196 };
            var creditorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creditorAbi.From(creditor);

            return await base.MakeTransactionList(new List<object> { abiHandle, creditorAbi, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Log each account's credit balance (a big-endian uint64) in input order — an empty
        ///log line means the account has no credit box (unambiguous: an existing box logs 8
        ///bytes even at zero balance). Readonly; meant to be simulated with allowMoreLogging
        ///to batch-fetch many balances in one call.
        ///</summary>
        /// <param name="accounts"> </param>
        public async Task LogCredits(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 29, 164, 229 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.SimApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogCredits_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 29, 164, 229 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw all remaining MBR credits for the sender. Deletes the credit box, so the
        ///MBR locked for the box itself is refunded too. The inner payment carries zero fee —
        ///callers must cover it with fee pooling (1000 µA extra fee).
        ///</summary>
        public async Task WithdrawCredits(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 238, 127, 189 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawCredits_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 238, 127, 189 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWJyTWFuYWdlckNvbnN1bWVyIiwiZGVzYyI6IkEgbWluaW1hbCByZWdpc3RyeSBjaGFyZ2luZyBpdHMgYm94ZXMgdG8gdGhlIHNlbmRlcidzIE1CUiBjcmVkaXRzIOKAlCBzb21ldGhpbmcgZm9yXG50aGUgdGVzdCBzdWl0ZSB0byBjYWxsLCBhbmQgdGhlIHdvcmtlZCBleGFtcGxlIGZvciBgTWJyTWFuYWdlcmAuIEVhY2ggYWNjb3VudCBvd25zXG50aGUgb25lIGVudHJ5IGtleWVkIGJ5IGl0cyBhZGRyZXNzLCBzbyBvbmx5IGl0cyBvd25lciBjYW4gcmVzaXplIG9yIGRlbGV0ZSBpdCBhbmRcbmNsYWltIHRoZSByZWZ1bmQuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InB1dCIsImRlc2MiOiJTdG9yZSB0aGUgc2VuZGVyJ3MgdmFsdWUsIGNoYXJnaW5nIGFueSBib3ggTUJSIGluY3JlYXNlIHRvIHRoZWlyIGNyZWRpdHMuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZSIsImRlc2MiOiJEZWxldGUgdGhlIHNlbmRlcidzIHZhbHVlLCByZWZ1bmRpbmcgdGhlIGZyZWVkIGJveCBNQlIgdG8gdGhlaXIgY3JlZGl0cy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdENyZWRpdHMiLCJkZXNjIjoiRGVwb3NpdCBNQlIgY3JlZGl0cyBmb3IgYW4gYWNjb3VudC4gVGhlIHBheW1lbnQgYW1vdW50IGJlY29tZXMgdGhlIGNyZWRpdDsgb3BlbmluZ1xudGhlIGNyZWRpdG9yJ3MgY3JlZGl0IGJveCBpcyBwYWlkIG91dCBvZiB0aGUgZGVwb3NpdCBpdHNlbGYsIHNvIGEgZmlyc3QgZGVwb3NpdCBuZXRzXG5hbW91bnQgbWludXMgdGhlIGJveCBNQlIg4oCUIHdob2V2ZXIgc2VuZHMgaXQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVkaXRvciIsImRlc2MiOiJBY2NvdW50IHRvIGNyZWRpdCAobmVlZCBub3QgYmUgdGhlIHNlbmRlcikiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOiJQYXltZW50IHRvIHRoZSBjb250cmFjdDsgaXRzIGFtb3VudCBpcyB0aGUgY3JlZGl0IHJlY2VpdmVkIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ0NyZWRpdHMiLCJkZXNjIjoiTG9nIGVhY2ggYWNjb3VudCdzIGNyZWRpdCBiYWxhbmNlIChhIGJpZy1lbmRpYW4gdWludDY0KSBpbiBpbnB1dCBvcmRlciDigJQgYW4gZW1wdHlcbmxvZyBsaW5lIG1lYW5zIHRoZSBhY2NvdW50IGhhcyBubyBjcmVkaXQgYm94ICh1bmFtYmlndW91czogYW4gZXhpc3RpbmcgYm94IGxvZ3MgOFxuYnl0ZXMgZXZlbiBhdCB6ZXJvIGJhbGFuY2UpLiBSZWFkb25seTsgbWVhbnQgdG8gYmUgc2ltdWxhdGVkIHdpdGggYWxsb3dNb3JlTG9nZ2luZ1xudG8gYmF0Y2gtZmV0Y2ggbWFueSBiYWxhbmNlcyBpbiBvbmUgY2FsbC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd0NyZWRpdHMiLCJkZXNjIjoiV2l0aGRyYXcgYWxsIHJlbWFpbmluZyBNQlIgY3JlZGl0cyBmb3IgdGhlIHNlbmRlci4gRGVsZXRlcyB0aGUgY3JlZGl0IGJveCwgc28gdGhlXG5NQlIgbG9ja2VkIGZvciB0aGUgYm94IGl0c2VsZiBpcyByZWZ1bmRlZCB0b28uIFRoZSBpbm5lciBwYXltZW50IGNhcnJpZXMgemVybyBmZWUg4oCUXG5jYWxsZXJzIG11c3QgY292ZXIgaXQgd2l0aCBmZWUgcG9vbGluZyAoMTAwMCDCtUEgZXh0cmEgZmVlKS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNzIsMzEzLDQzNl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODgsMzA3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmFtdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwOV0sImVycm9yTWVzc2FnZSI6IkVSUjpjcmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzksNDMzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOnJjdiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMiwxMzUsMjA5LDI5NCwzMjUsMzU4XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3LDIzMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YWNjb3VudD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUlESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltTWlJQ0psSWlBaVJWSlNPbkpqZGlJZ0lrVlNVanBoYlhRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldKeVgyMWhibUZuWlhJdlkyOXVjM1Z0WlhJdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTFpY2sxaGJtRm5aWEpEYjI1emRXMWxjaUJsZUhSbGJtUnpJRTFpY2sxaGJtRm5aWElnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3hOek0wTURVd1pTQXdlREJrTVdWak5EVTJJREI0TTJRM05XWXdZelFnTUhnNU5ERmtZVFJsTlNBd2VHVmhaV1UzWm1Ka0lDOHZJRzFsZEdodlpDQWljSFYwS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaVzF2ZG1Vb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGNHOXphWFJEY21Wa2FYUnpLR0ZrWkhKbGMzTXNjR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbXh2WjBOeVpXUnBkSE1vWVdSa2NtVnpjMXRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNRM0psWkdsMGN5Z3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lIQjFkQ0J5WlcxdmRtVWdaR1Z3YjNOcGRFTnlaV1JwZEhNZ2JHOW5RM0psWkdsMGN5QjNhWFJvWkhKaGQwTnlaV1JwZEhNS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0p5WDIxaGJtRm5aWEl2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMWljazFoYm1GblpYSkRiMjV6ZFcxbGNpQmxlSFJsYm1SeklFMWljazFoYm1GblpYSWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXSnlYMjFoYm1GblpYSXZZMjl1YzNWdFpYSXVZV3huYnk1MGN6bzZUV0p5VFdGdVlXZGxja052Ym5OMWJXVnlMbkIxZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQjFkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZbkpmYldGdVlXZGxjaTlqYjI1emRXMWxjaTVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjSFYwS0haaGJIVmxPaUJpZVhSbGN5a2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WW5KZmJXRnVZV2RsY2k5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCamIyNXpkQ0J0WW5KQ1pXWnZjbVVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeTV0YVc1Q1lXeGhibU5sQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WW5KZmJXRnVZV2RsY2k5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGJuUnlhV1Z6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUdKNWRHVnpQaWg3SUd0bGVWQnlaV1pwZURvZ0oyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0psSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFpY2w5dFlXNWhaMlZ5TDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhSb2FYTXVaVzUwY21sbGN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSFpoYkhWbENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0p5WDIxaGJtRm5aWEl2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnWlc1MGNtbGxjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JpZVhSbGN6NG9leUJyWlhsUWNtVm1hWGc2SUNkbEp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0p5WDIxaGJtRm5aWEl2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnZEdocGN5NWxiblJ5YVdWektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJSFJvYVhNdWMyVjBkR3hsVFdKeVEzSmxaR2wwY3loVWVHNHVjMlZ1WkdWeUxDQnRZbkpDWldadmNtVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEhSc1pVMWlja055WldScGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFluSmZiV0Z1WVdkbGNpOWpiMjV6ZFcxbGNpNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QndkV0pzYVdNZ2NIVjBLSFpoYkhWbE9pQmllWFJsY3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WW5KZmJXRnVZV2RsY2k5amIyNXpkVzFsY2k1aGJHZHZMblJ6T2pwTlluSk5ZVzVoWjJWeVEyOXVjM1Z0WlhJdWNtVnRiM1psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnRiM1psT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFpY2w5dFlXNWhaMlZ5TDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUdOdmJuTjBJRzFpY2tKbFptOXlaU0E5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMbTFwYmtKaGJHRnVZMlVLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFpY2w5dFlXNWhaMlZ5TDJOdmJuTjFiV1Z5TG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUdWdWRISnBaWE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnWW5sMFpYTStLSHNnYTJWNVVISmxabWw0T2lBblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0p5WDIxaGJtRm5aWEl2WTI5dWMzVnRaWEl1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnZEdocGN5NWxiblJ5YVdWektGUjRiaTV6Wlc1a1pYSXBMbVJsYkdWMFpTZ3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldKeVgyMWhibUZuWlhJdlkyOXVjM1Z0WlhJdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1pXNTBjbWxsY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCaWVYUmxjejRvZXlCclpYbFFjbVZtYVhnNklDZGxKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldKeVgyMWhibUZuWlhJdlkyOXVjM1Z0WlhJdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2RHaHBjeTVsYm5SeWFXVnpLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJSFJvYVhNdWMyVjBkR3hsVFdKeVEzSmxaR2wwY3loVWVHNHVjMlZ1WkdWeUxDQnRZbkpDWldadmNtVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEhSc1pVMWlja055WldScGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFluSmZiV0Z1WVdkbGNpOWpiMjV6ZFcxbGNpNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVnRiM1psS0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZPazFpY2sxaGJtRm5aWEl1WkdWd2IzTnBkRU55WldScGRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCdmMybDBRM0psWkdsMGN6b0tJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhCMVlteHBZeUJrWlhCdmMybDBRM0psWkdsMGN5aGpjbVZrYVhSdmNqb2dRV05qYjNWdWRDd2dkSGh1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQnVJRElLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6Y21NdmJXSnlUV0Z1WVdkbGNpNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEhodUxuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2daWEp5VW1WalpXbDJaWElwQ2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWkdWd2IzTnBkRU55WldScGRITmZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6SWdMeThnSWtWU1VqcHlZM1lpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZjbU4yQ2dwa1pYQnZjMmwwUTNKbFpHbDBjMTloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBlRzR1WVcxdmRXNTBJRDRnTUN3Z1pYSnlRVzEwS1FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnVlaUJrWlhCdmMybDBRM0psWkdsMGMxOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldOZk15QXZMeUFpUlZKU09tRnRkQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGhiWFFLQ21SbGNHOXphWFJEY21Wa2FYUnpYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKRGNtVmthWFJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGpKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWXlJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZPRGtLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5RZ1BTQjBhR2x6TG5WelpYSkRjbVZrYVhSektHTnlaV1JwZEc5eUtTNW5aWFFvZXlCa1pXWmhkV3gwT2lBd0lIMHBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem81TVFvZ0lDQWdMeThnWTI5dWMzUWdiV0p5UW1WbWIzSmxJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXViV2x1UW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUJ6Y21NdmJXSnlUV0Z1WVdkbGNpNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QjBhR2x6TG5WelpYSkRjbVZrYVhSektHTnlaV1JwZEc5eUtTNTJZV3gxWlNBOUlHTjFjbkpsYm5RZ0t5QjBlRzR1WVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjM0pqTDIxaWNrMWhibUZuWlhJdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2RHaHBjeTV6WlhSMGJHVk5ZbkpEY21Wa2FYUnpLR055WldScGRHOXlMQ0J0WW5KQ1pXWnZjbVVwQ2lBZ0lDQmpZV3hzYzNWaUlITmxkSFJzWlUxaWNrTnlaV1JwZEhNS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSEIxWW14cFl5QmtaWEJ2YzJsMFEzSmxaR2wwY3loamNtVmthWFJ2Y2pvZ1FXTmpiM1Z1ZEN3Z2RIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pwTlluSk5ZVzVoWjJWeUxteHZaME55WldScGRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjJkRGNtVmthWFJ6T2dvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6b3hNREl0TVRBekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJzYjJkRGNtVmthWFJ6S0dGalkyOTFiblJ6T2lCQlkyTnZkVzUwVzEwcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZV05qYjNWdWRENEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncHNiMmREY21Wa2FYUnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdGalkyOTFiblFnYjJZZ1lXTmpiM1Z1ZEhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUd4dlowTnlaV1JwZEhOZllXWjBaWEpmWm05eVFEZ0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5UTNKbFpHbDBjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBbll5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJR2xtSUNoaWIzZ3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUd4dlowTnlaV1JwZEhOZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCc2IyY29iM0F1YVhSdllpaGliM2d1ZG1Gc2RXVXBLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29LYkc5blEzSmxaR2wwYzE5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCc2IyZERjbVZrYVhSelgyWnZjbDlvWldGa1pYSkFNZ29LYkc5blEzSmxaR2wwYzE5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem94TURrS0lDQWdJQzh2SUd4dlp5aENlWFJsY3lncEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JzYjJjS0lDQWdJR0lnYkc5blEzSmxaR2wwYzE5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ214dlowTnlaV1JwZEhOZllXWjBaWEpmWm05eVFEZzZDaUFnSUNBdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pFd01pMHhNRE1LSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHeHZaME55WldScGRITW9ZV05qYjNWdWRITTZJRUZqWTI5MWJuUmJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02T2sxaWNrMWhibUZuWlhJdWQybDBhR1J5WVhkRGNtVmthWFJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2QybDBhR1J5WVhkRGNtVmthWFJ6T2dvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJR052Ym5OMElHMWlja0psWm05eVpTQTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtMXBia0poYkdGdVkyVUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdjM0pqTDIxaWNrMWhibUZuWlhJdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhWelpYSkRjbVZrYVhSeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVl5SUtJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02TVRJeUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1MWMyVnlRM0psWkdsMGN5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJR1Z5Y2tGdGRDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5UTNKbFpHbDBjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBbll5Y2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6b3hNaklLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMblZ6WlhKRGNtVmthWFJ6S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3l3Z1pYSnlRVzEwS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dkMmwwYUdSeVlYZERjbVZrYVhSelgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNllXMTBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tRnRkQW9LZDJsMGFHUnlZWGREY21Wa2FYUnpYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKRGNtVmthWFJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGpKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWXlJS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJqYjI1emRDQmpjbVZrYVhRNklIVnBiblEyTkNBOUlIUm9hWE11ZFhObGNrTnlaV1JwZEhNb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE55WXk5dFluSk5ZVzVoWjJWeUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMWMyVnlRM0psWkdsMGN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjM0pqTDIxaWNrMWhibUZuWlhJdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklHTnZibk4wSUdOeVpXUnBkRG9nZFdsdWREWTBJRDBnZEdocGN5NTFjMlZ5UTNKbFpHbDBjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE55WXk5dFluSk5ZVzVoWjJWeUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMWMyVnlRM0psWkdsMGN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTWlDaUFnSUNBdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pFeU5Rb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVEzSmxaR2wwY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIVnpaWEpEY21Wa2FYUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkakp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6Y21NdmJXSnlUV0Z1WVdkbGNpNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnlRM0psWkdsMGN5aFVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6Y21NdmJXSnlUV0Z1WVdkbGNpNWhiR2R2TG5Sek9qRXlOZ29nSUNBZ0x5OGdZMjl1YzNRZ2JXSnlRV1owWlhJZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3k1dGFXNUNZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02TVRJM0NpQWdJQ0F2THlCamIyNXpkQ0JtYVc1aGJFTnlaV1JwZERvZ2RXbHVkRFkwSUQwZ1kzSmxaR2wwSUNzZ0tHMWlja0psWm05eVpTQXRJRzFpY2tGbWRHVnlLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXJDaUFnSUNBdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pFeU9TMHhNelFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ptbHVZV3hEY21Wa2FYUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjM0pqTDIxaWNrMWhibUZuWlhJdVlXeG5ieTUwY3pveE16RUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02TVRJNUxURXpNd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCbWFXNWhiRU55WldScGRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZNVEk1TFRFek5Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJtYVc1aGJFTnlaV1JwZEN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUhCMVlteHBZeUIzYVhSb1pISmhkME55WldScGRITW9LU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0pqTDIxaWNrMWhibUZuWlhJdVlXeG5ieTUwY3pvNlRXSnlUV0Z1WVdkbGNpNXpaWFIwYkdWTlluSkRjbVZrYVhSektHRmpZMjkxYm5RNklHSjVkR1Z6TENCdFluSkNaV1p2Y21VNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2MyVjBkR3hsVFdKeVEzSmxaR2wwY3pvS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSEJ5YjNSbFkzUmxaQ0J6WlhSMGJHVk5ZbkpEY21Wa2FYUnpLR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJRzFpY2tKbFptOXlaVG9nZFdsdWREWTBLU0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnlZeTl0WW5KTllXNWhaMlZ5TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdOdmJuTjBJRzFpY2tGbWRHVnlJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXViV2x1UW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYVdZZ0tHMWlja0ZtZEdWeUlEMDlQU0J0WW5KQ1pXWnZjbVVwSUhKbGRIVnliZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVjBkR3hsVFdKeVEzSmxaR2wwYzE5bGJITmxYMkp2WkhsQU1nb2dJQ0FnY21WMGMzVmlDZ3B6WlhSMGJHVk5ZbkpEY21Wa2FYUnpYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdaV3h6WlNCcFppQW9iV0p5UVdaMFpYSWdQaUJ0WW5KQ1pXWnZjbVVwSUhzS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStDaUFnSUNCaWVpQnpaWFIwYkdWTlluSkRjbVZrYVhSelgyVnNjMlZmWW05a2VVQTJDaUFnSUNBdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCamIyNXpkQ0JqY21Wa2FYUk9aV1ZrWldRNklIVnBiblEyTkNBOUlHMWlja0ZtZEdWeUlDMGdiV0p5UW1WbWIzSmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIVnpaWEpEY21Wa2FYUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkakp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR052Ym5OMElIVnpaWEpEY21Wa2FYUWdQU0IwYUdsekxuVnpaWEpEY21Wa2FYUnpLR0ZqWTI5MWJuUXBMbWRsZENoN0lHUmxabUYxYkhRNklEQWdmU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMWMyVnlRM0psWkdsMElENDlJR055WldScGRFNWxaV1JsWkN3Z1pYSnlRM0psWkdsMEtRb2dJQ0FnUGowS0lDQWdJR0p1ZWlCelpYUjBiR1ZOWW5KRGNtVmthWFJ6WDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBqY21RaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WTNKa0NncHpaWFIwYkdWTlluSkRjbVZrYVhSelgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzNKakwyMWljazFoYm1GblpYSXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnlRM0psWkdsMGN5aGhZMk52ZFc1MEtTNTJZV3gxWlNBOUlIVnpaWEpEY21Wa2FYUWdMU0JqY21Wa2FYUk9aV1ZrWldRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwelpYUjBiR1ZOWW5KRGNtVmthWFJ6WDJWc2MyVmZZbTlrZVVBMk9nb2dJQ0FnTHk4Z2MzSmpMMjFpY2sxaGJtRm5aWEl1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnWTI5dWMzUWdZM0psWkdsMFZHOVNaWFIxY200NklIVnBiblEyTkNBOUlHMWlja0psWm05eVpTQXRJRzFpY2tGbWRHVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhOeVl5OXRZbkpOWVc1aFoyVnlMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5UTNKbFpHbDBjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBbll5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6Y21NdmJXSnlUV0Z1WVdkbGNpNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NTFjMlZ5UTNKbFpHbDBjeWhoWTJOdmRXNTBLUzVsZUdsemRITXNJR1Z5Y2xKbFkyVnBkbVZ5S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2djMlYwZEd4bFRXSnlRM0psWkdsMGMxOWhablJsY2w5aGMzTmxjblJBT0FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpUlZKU09uSmpkaUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcHlZM1lLQ25ObGRIUnNaVTFpY2tOeVpXUnBkSE5mWVdaMFpYSmZZWE56WlhKMFFEZzZDaUFnSUNBdkx5QnpjbU12YldKeVRXRnVZV2RsY2k1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCMGFHbHpMblZ6WlhKRGNtVmthWFJ6S0dGalkyOTFiblFwTG5aaGJIVmxJQ3M5SUdOeVpXUnBkRlJ2VW1WMGRYSnVDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBZ0FpWUVBV01CWlFkRlVsSTZjbU4yQjBWU1VqcGhiWFF4RzBFQU1qRVpGRVF4R0VTQ0JRUVhOQVVPQkEwZXhGWUVQWFh3eEFTVUhhVGxCT3J1ZjcwMkdnQ09CUUFKQURBQVF3Q05BTThBTVJrVU1SZ1VFRU0yR2dGSkkxa2xDRXNCRlJKRVZ3SUFNZ3B6QVVRcE1RQlFTYnhJVHdLL01RQk1pQURhSWtNeUNuTUJSQ2t4QUZDOFNERUFUSWdBeHlKRE5ob0JTUlVrRWtReEZpSUpSd0k0RUNJU1JEZ0hNZ29TUUFBREtyQUFPQWhKUUFBREs3QUFLRThDU1U0Q1VFbStUQmNqVEU4Q1RUSUtjd0ZFVEU4RUNCWlBBa3kvaUFCOUlrTTJHZ0ZIQWlOWlNVNENKQXNsQ0V3VkVrUWpTVXNDREVFQUprc0NWd0lBU3dFa0N5UllLRXhRU2IxRkFVRUFDcjVFRnhhd0lnaEMvOXBJZ0FDd1F2LzBJa015Q25NQlJDZ3hBRkM5UlFGQUFBTXJzQUFvTVFCUXZrUVhLREVBVUx4SU1ncHpBVVJQQWt3SkNMRXhBTElIc2dnaXNoQWpzZ0d6SWtPS0FnQXlDbk1CVEVsUEFrU0wveEpCQUFHSlNZdi9EVUVBSzR2L0NVa29pLzVRU1U0Q3Zrd1hJMHhQQWsxSlR3SVBRQUFMZ0FkRlVsSTZZM0prc0FCUEFna1d2NG1MLzB3SktJditVRW05UlFGQUFBTXFzQUJKdmtRWFR3SUlGcitKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
