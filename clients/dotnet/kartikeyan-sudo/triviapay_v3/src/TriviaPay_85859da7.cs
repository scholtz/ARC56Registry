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

namespace Arc56.Generated.kartikeyan_sudo.triviapay_v3.TriviaPay_85859da7
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
        ///Application creation
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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJpdmlhUGF5IiwiZGVzYyI6IlRyaXZpYVBheSBlc2Nyb3cgLyBwYXltZW50LXBvb2wgY29udHJhY3QgKEFsZ29yYW5kIFR5cGVTY3JpcHQgLyBQdXlhKS5cclxuXHJcbk1ldGhvZHM6XHJcbi0gY3JlYXRlQXBwbGljYXRpb24oKTogYm9vdHN0cmFwIG93bmVyICsgY291bnRlcnNcclxuLSBkZXBvc2l0KHBheW1lbnQpOiBncm91cCB3aXRoIGEgUGF5bWVudFR4biB0byBhcHAgYWRkcmVzc1xyXG4tIHBheShyZWNpcGllbnQsIGFtb3VudCwgbm90ZSk6IG93bmVyLW9ubHkgcGF5b3V0IGZyb20gZXNjcm93XHJcbi0gd2l0aGRyYXcoYW1vdW50KTogb3duZXItb25seSB3aXRoZHJhd2FsIGJhY2sgdG8gb3duZXJcclxuLSBiYWxhbmNlKCk6IHZpZXcgdG90YWwgZXNjcm93ZWQgbWljcm9BbGdvc1xyXG4tIGdldF9vd25lcigpOiB2aWV3IG93bmVyIGFjY291bnQiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjoiQXBwbGljYXRpb24gY3JlYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOiJEZXBvc2l0IEFMR08gdmlhIGdyb3VwZWQgUGF5bWVudFR4biB0byB0aGUgYXBwIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5IiwiZGVzYyI6Ik93bmVyIHBheXMgYSByZWNpcGllbnQgZnJvbSBlc2Nyb3cuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibm90ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJPd25lciB3aXRoZHJhd3MgZnVuZHMgYmFjayB0byB0aGVtc2VsdmVzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X293bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzYsMjM0XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwXSwiZXJyb3JNZXNzYWdlIjoiRGVwb3NpdCBhbW91bnQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODUsMjQzXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGVzY3JvdyBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gY2FsbCBwYXkoKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGdvIHRvIHRoaXMgY29udHJhY3QgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwxNzEsMTgwLDIyNiwyMzgsMjY5LDI4MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3LDIxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSW5SdmRHRnNJaUFpYjNkdVpYSWlJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWNtbDJhV0ZRWVhrZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBT1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURNMk1qVmxOR1ZpSURCNE5EZzBOMk5rTnpFZ01IZ3lNV1l4WkdSbVppQXdlRGRqTldJd01qZzVJREI0Wm1ZeVltRTFZelVnTHk4Z2JXVjBhRzlrSUNKa1pYQnZjMmwwS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKd1lYa29ZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaVlXeGhibU5sS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXZkMjVsY2lncFlXUmtjbVZ6Y3lJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHUmxjRzl6YVhRZ2NHRjVJSGRwZEdoa2NtRjNJR0poYkdGdVkyVWdaMlYwWDI5M2JtVnlDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWNtbDJhV0ZRWVhrZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJ5YVhacFlWQmhlUzVqY21WaGRHVkJjSEJzYVdOaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjI5M2JtVnlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklIUnZkR0ZzUkdWd2IzTnBkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozUnZkR0ZzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDBnVldsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVWNtbDJhV0ZRWVhrdVpHVndiM05wZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjRzl6YVhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCd2RXSnNhV01nWkdWd2IzTnBkQ2h3WVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0FuVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUhSb2FYTWdZMjl1ZEhKaFkzUWdZV1JrY21WemN5Y3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JoWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1aGJXOTFiblFnUGlCVmFXNTBOalFvTUNrc0lDZEVaWEJ2YzJsMElHRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01DY3BDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVSbGNHOXphWFFnWVcxdmRXNTBJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVSbGNHOXphWFJsWkM1MllXeDFaU0FySUhCaGVXMWxiblF1WVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RHOTBZV3hFWlhCdmMybDBaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmRHOTBZV3duSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hFWlhCdmMybDBaV1F1ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxJQ3NnY0dGNWJXVnVkQzVoYlc5MWJuUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYjNSaGJFUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFUmxjRzl6YVhSbFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeEVaWEJ2YzJsMFpXUXVkbUZzZFdVZ0t5QndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhCMVlteHBZeUJrWlhCdmMybDBLSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSeWFYWnBZVkJoZVM1d1lYbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3WVhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCd2RXSnNhV01nY0dGNUtISmxZMmx3YVdWdWREb2dRV05qYjNWdWRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRc0lHNXZkR1U2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG05M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCdmQyNWxjaUJqWVc0Z1kyRnNiQ0J3WVhrb0tTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjI5M2JtVnlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2diM2R1WlhJZ1kyRnVJR05oYkd3Z2NHRjVLQ2tuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNpQmpZVzRnWTJGc2JDQndZWGtvS1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDQStJRlZwYm5RMk5DZ3dLU3dnSjBGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRHOTBZV3hFWlhCdmMybDBaV1F1ZG1Gc2RXVWdQajBnWVcxdmRXNTBMQ0FuU1c1emRXWm1hV05wWlc1MElHVnpZM0p2ZHlCaVlXeGhibU5sSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYjNSaGJFUmxjRzl6YVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRzkwWVd4RVpYQnZjMmwwWldRdWRtRnNkV1VnUGowZ1lXMXZkVzUwTENBblNXNXpkV1ptYVdOcFpXNTBJR1Z6WTNKdmR5QmlZV3hoYm1ObEp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUzAxTmdvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJRzV2ZEdVNklHNXZkR1VzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RtOTBaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1TMDFOZ29nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lHNXZkR1U2SUc1dmRHVXNDaUFnSUNBdkx5QWdJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JHVndiM05wZEdWa0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFUmxjRzl6YVhSbFpDNTJZV3gxWlNBdElHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkRzkwWVd4RVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RVpYQnZjMmwwWldRdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1JHVndiM05wZEdWa0xuWmhiSFZsSUMwZ1lXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZVNoeVpXTnBjR2xsYm5RNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCdWIzUmxPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVWNtbDJhV0ZRWVhrdWQybDBhR1J5WVhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZHloaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lDZFBibXg1SUc5M2JtVnlJR05oYmlCM2FYUm9aSEpoZHljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMjkzYm1WeUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2dKMDl1YkhrZ2IzZHVaWElnWTJGdUlIZHBkR2hrY21GM0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHOTNibVZ5SUdOaGJpQjNhWFJvWkhKaGR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dGdGIzVnVkQ0ErSUZWcGJuUTJOQ2d3S1N3Z0owRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01DY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkRzkwWVd4RVpYQnZjMmwwWldRdWRtRnNkV1VnUGowZ1lXMXZkVzUwTENBblNXNXpkV1ptYVdOcFpXNTBJR1Z6WTNKdmR5QmlZV3hoYm1ObEp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKcGRtbGhYM0JoZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCMGIzUmhiRVJsY0c5emFYUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMGIzUmhiQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZEc5MFlXeEVaWEJ2YzJsMFpXUXVkbUZzZFdVZ1BqMGdZVzF2ZFc1MExDQW5TVzV6ZFdabWFXTnBaVzUwSUdWelkzSnZkeUJpWVd4aGJtTmxKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQmxjMk55YjNjZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTnkwM01Rb2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpwZG1saFgzQmhlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk55MDNNUW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCbVpXVTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRVJsY0c5emFYUmxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hFWlhCdmMybDBaV1F1ZG1Gc2RXVWdMU0JoYlc5MWJuUUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhSdmRHRnNSR1Z3YjNOcGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNSdmRHRnNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNSR1Z3YjNOcGRHVmtMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRVJsY0c5emFYUmxaQzUyWVd4MVpTQXRJR0Z0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZHloaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUnlhWFpwWVZCaGVTNWlZV3hoYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbUZzWVc1alpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtbDJhV0ZmY0dGNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblJ2ZEdGc1JHVndiM05wZEdWa0xuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlhWFpwWVY5d1lYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkRzkwWVd4RVpYQnZjMmwwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd3bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21sMmFXRmZjR0Y1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzUkdWd2IzTnBkR1ZrTG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWFYWnBZVjl3WVhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZISnBkbWxoVUdGNUxtZGxkRjl2ZDI1bGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5dmQyNWxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG05M2JtVnlMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5YVhacFlWOXdZWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjI5M2JtVnlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISnBkbWxoWDNCaGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbWwyYVdGZmNHRjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUlKZ01GZEc5MFlXd0ZiM2R1WlhJRUZSOThkVEVaRkVReEdFRUFLNElGQkRZbDVPc0VTRWZOY1FRaDhkMy9CSHhiQW9rRS95dWx4VFlhQUk0RkFCZ0FOd0NJQUw0QXlRQ0FCTGhFZXpZMkdnQ09BUUFCQUNreEFHY29JbWNqUXpFV0l3bEpPQkFqRWtSSk9BY3lDaEpFT0FoSlJDSW9aVVFJS0V4bkkwTTJHZ0ZKRllFZ0VrUTJHZ0pKRlNRU1JCYzJHZ05KSWxtQkFnaExBUlVTUkZjQ0FERUFJaWxsUkJKRVN3RkVJaWhsUkVsTEF3OUVzVXl5QlVzQnNnaFBBcklISTdJUUlySUJzMHdKS0V4bkkwTTJHZ0ZKRlNRU1JCY3hBQ0lwWlVSTVN3RVNSRXNCUkNJb1pVUkpTd01QUkxGTEFySUlUTElISTdJUUlySUJzMHdKS0V4bkkwTWlLR1ZFRmlwTVVMQWpReUlwWlVRcVRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
