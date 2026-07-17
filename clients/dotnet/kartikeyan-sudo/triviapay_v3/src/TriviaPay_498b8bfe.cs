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

namespace Arc56.Generated.kartikeyan_sudo.triviapay_v3.TriviaPay_498b8bfe
{


    //
    // TriviaPay escrow / payment-pool contract (Algorand TypeScript / Puya).
    //
    //Methods:
    //- createApplication(): bootstrap owner + counters
    //- deposit(payment): group with a PaymentTxn to app address
    //- pay(recipient, amount, note): owner-only payout from escrow
    //- withdraw(amount): owner-only withdrawal back to owner
    //- balance(): view total escrowed microAlgos
    //- get_owner(): view owner account
    //
    public class TriviaPayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TriviaPayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deposit ALGO via grouped PaymentTxn to the app address.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner pays a recipient from escrow.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="note"> </param>
        public async Task Pay(Algorand.Address recipient, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 71, 205, 113 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pay_Transactions(Algorand.Address recipient, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 71, 205, 113 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner withdraws funds back to themselves.
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
        ///
        ///</summary>
        public async Task<ulong> Balance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 91, 2, 137 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Balance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 91, 2, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 43, 165, 197 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 43, 165, 197 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJpdmlhUGF5IiwiZGVzYyI6IlRyaXZpYVBheSBlc2Nyb3cgLyBwYXltZW50LXBvb2wgY29udHJhY3QgKEFsZ29yYW5kIFR5cGVTY3JpcHQgLyBQdXlhKS5cclxuXHJcbk1ldGhvZHM6XHJcbi0gY3JlYXRlQXBwbGljYXRpb24oKTogYm9vdHN0cmFwIG93bmVyICsgY291bnRlcnNcclxuLSBkZXBvc2l0KHBheW1lbnQpOiBncm91cCB3aXRoIGEgUGF5bWVudFR4biB0byBhcHAgYWRkcmVzc1xyXG4tIHBheShyZWNpcGllbnQsIGFtb3VudCwgbm90ZSk6IG93bmVyLW9ubHkgcGF5b3V0IGZyb20gZXNjcm93XHJcbi0gd2l0aGRyYXcoYW1vdW50KTogb3duZXItb25seSB3aXRoZHJhd2FsIGJhY2sgdG8gb3duZXJcclxuLSBiYWxhbmNlKCk6IHZpZXcgdG90YWwgZXNjcm93ZWQgbWljcm9BbGdvc1xyXG4tIGdldF9vd25lcigpOiB2aWV3IG93bmVyIGFjY291bnQiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOiJEZXBvc2l0IEFMR08gdmlhIGdyb3VwZWQgUGF5bWVudFR4biB0byB0aGUgYXBwIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5IiwiZGVzYyI6Ik93bmVyIHBheXMgYSByZWNpcGllbnQgZnJvbSBlc2Nyb3cuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibm90ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJPd25lciB3aXRoZHJhd3MgZnVuZHMgYmFjayB0byB0aGVtc2VsdmVzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X293bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzMsMjMxXSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3XSwiZXJyb3JNZXNzYWdlIjoiRGVwb3NpdCBhbW91bnQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODIsMjQwXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGVzY3JvdyBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIGNhbGwgcGF5KCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiB3aXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExM10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBnbyB0byB0aGlzIGNvbnRyYWN0IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjEsMTY4LDE3NywyMjMsMjM1LDI2NiwyNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NCwyMTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luUnZkR0ZzSWlBaWIzZHVaWElpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjbWwyYVdGUVlYa2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmtBeE1nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pOakkxWlRSbFlpQXdlRFE0TkRkalpEY3hJREI0TWpGbU1XUmtabVlnTUhnM1l6VmlNREk0T1NBd2VHWm1NbUpoTldNMUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWljR0Y1S0dGa1pISmxjM01zZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZbUZzWVc1alpTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYjNkdVpYSW9LV0ZrWkhKbGMzTWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWlhCdmMybDBJSEJoZVNCM2FYUm9aSEpoZHlCaVlXeGhibU5sSUdkbGRGOXZkMjVsY2dvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnUUdKaGNtVnRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkT2IwOXdKeXdnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNkdmQyNWxjaWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QjBiM1JoYkVSbGNHOXphWFJsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBiM1JoYkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVSbGNHOXphWFJsWkM1MllXeDFaU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJBWW1GeVpXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5MQ0J2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkhKcGRtbGhVR0Y1TG1SbGNHOXphWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0c5emFYUW9jR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dKMUJoZVcxbGJuUWdiWFZ6ZENCbmJ5QjBieUIwYUdseklHTnZiblJ5WVdOMElHRmtaSEpsYzNNbktRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUhSb2FYTWdZMjl1ZEhKaFkzUWdZV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVXMWxiblF1WVcxdmRXNTBJRDRnVldsdWREWTBLREFwTENBblJHVndiM05wZENCaGJXOTFiblFnYlhWemRDQmlaU0ErSURBbktRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJFWlhCdmMybDBJR0Z0YjNWdWRDQnRkWE4wSUdKbElENGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRVJsY0c5emFYUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hFWlhCdmMybDBaV1F1ZG1Gc2RXVWdLeUJ3WVhsdFpXNTBMbUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSdmRHRnNSR1Z3YjNOcGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNSdmRHRnNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSR1Z3YjNOcGRHVmtMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRVJsY0c5emFYUmxaQzUyWVd4MVpTQXJJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkRzkwWVd4RVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RVpYQnZjMmwwWldRdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1JHVndiM05wZEdWa0xuWmhiSFZsSUNzZ2NHRjViV1Z1ZEM1aGJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1Z3YjNOcGRDaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVY21sMmFXRlFZWGt1Y0dGNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZVNoeVpXTnBjR2xsYm5RNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCdWIzUmxPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnYjNkdVpYSWdZMkZ1SUdOaGJHd2djR0Y1S0NrbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJRzkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2R2ZDI1bGNpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNJQ2RQYm14NUlHOTNibVZ5SUdOaGJpQmpZV3hzSUhCaGVTZ3BKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJZ1kyRnVJR05oYkd3Z2NHRjVLQ2tLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5RZ1BpQlZhVzUwTmpRb01Da3NJQ2RCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5SdmRHRnNSR1Z3YjNOcGRHVmtMblpoYkhWbElENDlJR0Z0YjNWdWRDd2dKMGx1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NnWW1Gc1lXNWpaU2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkRzkwWVd4RVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDQ5SUdGdGIzVnVkQ3dnSjBsdWMzVm1abWxqYVdWdWRDQmxjMk55YjNjZ1ltRnNZVzVqWlNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnWlhOamNtOTNJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTXROVGdLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQnViM1JsT2lCdWIzUmxMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNdE5UZ0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCdWIzUmxPaUJ1YjNSbExBb2dJQ0FnTHk4Z0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVSbGNHOXphWFJsWkM1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4RVpYQnZjMmwwWldRdWRtRnNkV1VnTFNCaGJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUnZkR0ZzUkdWd2IzTnBkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozUnZkR0ZzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVSbGNHOXphWFJsWkM1MllXeDFaU0F0SUdGdGIzVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSEIxWW14cFl5QndZWGtvY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwTENCaGJXOTFiblE2SUhWcGJuUTJOQ3dnYm05MFpUb2djM1J5YVc1bktUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkhKcGRtbGhVR0Y1TG5kcGRHaGtjbUYzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2QybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGNvWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0J2ZDI1bGNpQmpZVzRnZDJsMGFHUnlZWGNuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHZkMjVsY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lDZFBibXg1SUc5M2JtVnlJR05oYmlCM2FYUm9aSEpoZHljcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCdmQyNWxjaUJqWVc0Z2QybDBhR1J5WVhjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUWdQaUJWYVc1ME5qUW9NQ2tzSUNkQmJXOTFiblFnYlhWemRDQmlaU0ErSURBbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblFnYlhWemRDQmlaU0ErSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDQ5SUdGdGIzVnVkQ3dnSjBsdWMzVm1abWxqYVdWdWRDQmxjMk55YjNjZ1ltRnNZVzVqWlNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEc5MFlXeEVaWEJ2YzJsMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZEc5MFlXd25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblJ2ZEdGc1JHVndiM05wZEdWa0xuWmhiSFZsSUQ0OUlHRnRiM1Z1ZEN3Z0owbHVjM1ZtWm1samFXVnVkQ0JsYzJOeWIzY2dZbUZzWVc1alpTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1pYTmpjbTkzSUdKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamt0TnpNS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUIwYUdsekxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNZ29nSUNBZ0x5OGdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprdE56TUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEVaWEJ2YzJsMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNSR1Z3YjNOcGRHVmtMblpoYkhWbElDMGdZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUIwYjNSaGJFUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFUmxjRzl6YVhSbFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeEVaWEJ2YzJsMFpXUXVkbUZzZFdVZ0xTQmhiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCd2RXSnNhV01nZDJsMGFHUnlZWGNvWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVWNtbDJhV0ZRWVhrdVltRnNZVzVqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSmhiR0Z1WTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTBiM1JoYkVSbGNHOXphWFJsWkM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUnZkR0ZzUkdWd2IzTnBkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozUnZkR0ZzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MGIzUmhiRVJsY0c5emFYUmxaQzUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWFYWnBZVkJoZVM1blpYUmZiM2R1WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYjNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJRzkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2R2ZDI1bGNpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSUpnTUZkRzkwWVd3RmIzZHVaWElFRlI5OGRURWJRUUF5TVJrVVJERVlSSUlGQkRZbDVPc0VTRWZOY1FRaDhkMy9CSHhiQW9rRS95dWx4VFlhQUk0RkFCSUFNUUNDQUxnQXd3QXhHUlF4R0JRUVJDa3hBR2NvSW1jalF6RVdJd2xKT0JBakVrUkpPQWN5Q2hKRU9BaEpSQ0lvWlVRSUtFeG5JME0yR2dGSkZZRWdFa1EyR2dKSkZTUVNSQmMyR2dOSklsbUJBZ2hMQVJVU1JGY0NBREVBSWlsbFJCSkVTd0ZFSWlobFJFbExBdzlFc1V5eUJVc0JzZ2hQQXJJSEk3SVFJcklCczB3SktFeG5JME0yR2dGSkZTUVNSQmN4QUNJcFpVUk1Td0VTUkVzQlJDSW9aVVJKU3dNUFJMRkxBcklJVExJSEk3SVFJcklCczB3SktFeG5JME1pS0dWRUZpcE1VTEFqUXlJcFpVUXFURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
