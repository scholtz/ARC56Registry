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

namespace Arc56.Generated.Aniketwarule.Synthra.SynthraVault_d3d5a4cd
{


    public class SynthraVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SynthraVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the contract. Sets the deployer as the owner.
        ///Called once when the application is created.
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
        ///Opt-in handler. Initializes the user's local balance to zero.
        ///The user must call this before depositing.
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit ALGO into the vault. The user sends a grouped payment
        ///transaction to the contract address, and this method credits
        ///their local balance.
        ///</summary>
        /// <param name="payTxn">- The grouped payment transaction funding the deposit </param>
        public async Task Deposit(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 54, 37, 228, 235 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 54, 37, 228, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw remaining balance from the vault. Sends the user's full
        ///local balance back to them via an inner transaction.
        ///Resets their balance to zero.
        ///</summary>
        public async Task Withdraw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 53, 95, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 53, 95, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deduct from a user's balance. Only callable by the contract owner.
        ///Used by the backend to charge for each API call.
        ///</summary>
        /// <param name="user">- The account to deduct from </param>
        /// <param name="amount">- Amount in microALGO to deduct </param>
        public async Task Deduct(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 26, 44, 122 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deduct_Transactions(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 26, 44, 122 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a user's current deposited balance.
        ///</summary>
        /// <param name="user">- The account to query </param>
        public async Task<ulong> GetBalance(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 23, 168, 100 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBalance_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 23, 168, 100 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3ludGhyYVZhdWx0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0LiBTZXRzIHRoZSBkZXBsb3llciBhcyB0aGUgb3duZXIuXG5DYWxsZWQgb25jZSB3aGVuIHRoZSBhcHBsaWNhdGlvbiBpcyBjcmVhdGVkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJbiIsImRlc2MiOiJPcHQtaW4gaGFuZGxlci4gSW5pdGlhbGl6ZXMgdGhlIHVzZXIncyBsb2NhbCBiYWxhbmNlIHRvIHplcm8uXG5UaGUgdXNlciBtdXN0IGNhbGwgdGhpcyBiZWZvcmUgZGVwb3NpdGluZy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdCBBTEdPIGludG8gdGhlIHZhdWx0LiBUaGUgdXNlciBzZW5kcyBhIGdyb3VwZWQgcGF5bWVudFxudHJhbnNhY3Rpb24gdG8gdGhlIGNvbnRyYWN0IGFkZHJlc3MsIGFuZCB0aGlzIG1ldGhvZCBjcmVkaXRzXG50aGVpciBsb2NhbCBiYWxhbmNlLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlUeG4iLCJkZXNjIjoiLSBUaGUgZ3JvdXBlZCBwYXltZW50IHRyYW5zYWN0aW9uIGZ1bmRpbmcgdGhlIGRlcG9zaXQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXcgcmVtYWluaW5nIGJhbGFuY2UgZnJvbSB0aGUgdmF1bHQuIFNlbmRzIHRoZSB1c2VyJ3MgZnVsbFxubG9jYWwgYmFsYW5jZSBiYWNrIHRvIHRoZW0gdmlhIGFuIGlubmVyIHRyYW5zYWN0aW9uLlxuUmVzZXRzIHRoZWlyIGJhbGFuY2UgdG8gemVyby4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVkdWN0IiwiZGVzYyI6IkRlZHVjdCBmcm9tIGEgdXNlcidzIGJhbGFuY2UuIE9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IG93bmVyLlxuVXNlZCBieSB0aGUgYmFja2VuZCB0byBjaGFyZ2UgZm9yIGVhY2ggQVBJIGNhbGwuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6Ii0gVGhlIGFjY291bnQgdG8gZGVkdWN0IGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiItIEFtb3VudCBpbiBtaWNyb0FMR08gdG8gZGVkdWN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEJhbGFuY2UiLCJkZXNjIjoiR2V0IGEgdXNlcidzIGN1cnJlbnQgZGVwb3NpdGVkIGJhbGFuY2UuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6Ii0gVGhlIGFjY291bnQgdG8gcXVlcnkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHVzZXIncyBiYWxhbmNlIGluIG1pY3JvQUxHTyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjEsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM3XSwiZXJyb3JNZXNzYWdlIjoiRGVkdWN0aW9uIGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1XSwiZXJyb3JNZXNzYWdlIjoiRGVwb3NpdCBhbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCB1c2VyIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODhdLCJlcnJvck1lc3NhZ2UiOiJObyBiYWxhbmNlIHRvIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgT3B0SW4gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIG93bmVyIGNhbiBkZWR1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgc2VudCB0byB0aGUgdmF1bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMywyNTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzEsMTg2LDI0MywyNzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNywyNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0oxYzJWeVgySmhiR0Z1WTJVaUlDSjBiM1JoYkY5allXeHNjeUlnSW05M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZVc1MGFISmhWbUYxYkhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU9UTXhOR1E1TlNBdkx5QnRaWFJvYjJRZ0ltOXdkRWx1S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXZjSFJKYmw5eWIzVjBaVUF5Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVTNsdWRHaHlZVlpoZFd4MElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFd0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE16WXlOV1UwWldJZ01IaGlOek0xTldaa01TQXdlRFU1TVdFeVl6ZGhJREI0WWpReE4yRTROalFnTHk4Z2JXVjBhRzlrSUNKa1pYQnZjMmwwS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHlncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWa2RXTjBLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRFSmhiR0Z1WTJVb1lXUmtjbVZ6Y3lsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCa1pYQnZjMmwwSUhkcGRHaGtjbUYzSUdSbFpIVmpkQ0JuWlhSQ1lXeGhibU5sQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjViblJvY21GV1lYVnNkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdkRWx1WDNKdmRYUmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRQY0hSSmJpZGRJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVDNCMFNXNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQlBjSFJKYmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJRzl3ZEVsdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZPbE41Ym5Sb2NtRldZWFZzZEM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNkdmQyNWxjaWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW05M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11YjNkdVpYSXVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhSdmRHRnNRMkZzYkhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd4ZlkyRnNiSE1uSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlqWVd4c2N5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1EyRnNiSE11ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzZVM2x1ZEdoeVlWWmhkV3gwTG05d2RFbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCMFNXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzbHVkR2h5WVY5MllYVnNkQzlUZVc1MGFISmhWbUYxYkhRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVFtRnNZVzVqWlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlGVnBiblEyTkNnd0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSFZ6WlhKQ1lXeGhibU5sSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmRYTmxjbDlpWVd4aGJtTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFhObGNsOWlZV3hoYm1ObElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSb2FYTXVkWE5sY2tKaGJHRnVZMlVvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRQY0hSSmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk9sTjViblJvY21GV1lYVnNkQzVrWlhCdmMybDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2IzTnBkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5QndkV0pzYVdNZ1pHVndiM05wZENod1lYbFVlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVZSNGJpNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ2RRWVhsdFpXNTBJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QjBhR1VnZG1GMWJIUW5LUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR0psSUhObGJuUWdkRzhnZEdobElIWmhkV3gwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdZWE56WlhKMEtIQmhlVlI0Ymk1elpXNWtaWElnUFQwOUlGUjRiaTV6Wlc1a1pYSXNJQ2RRWVhsdFpXNTBJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JR05oYkd4bGNpY3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lHTmhiR3hsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGxVZUc0dVlXMXZkVzUwSUQ0Z1ZXbHVkRFkwS0RBcExDQW5SR1Z3YjNOcGRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5YnljcENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRVJsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpDWVd4aGJtTmxLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJQ3NnY0dGNVZIaHVMbUZ0YjNWdWRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QjFjMlZ5UW1Gc1lXNWpaU0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNWelpYSmZZbUZzWVc1alpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKZlltRnNZVzVqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpDWVd4aGJtTmxLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJQ3NnY0dGNVZIaHVMbUZ0YjNWdWRBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzbHVkR2h5WVY5MllYVnNkQzlUZVc1MGFISmhWbUYxYkhRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVFtRnNZVzVqWlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkWE5sY2tKaGJHRnVZMlVnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMWMyVnlYMkpoYkdGdVkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVgySmhiR0Z1WTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem80T0MwNE9Rb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVFtRnNZVzVqWlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUNpQWdJQ0F2THlBZ0lIUm9hWE11ZFhObGNrSmhiR0Z1WTJVb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ0t5QndZWGxVZUc0dVlXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCd2RXSnNhV01nWkdWd2IzTnBkQ2h3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPanBUZVc1MGFISmhWbUYxYkhRdWQybDBhR1J5WVhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCamIyNXpkQ0JpWVd4aGJtTmxJRDBnZEdocGN5NTFjMlZ5UW1Gc1lXNWpaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIxYzJWeVFtRnNZVzVqWlNBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozVnpaWEpmWW1Gc1lXNWpaU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WelpYSmZZbUZzWVc1alpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCamIyNXpkQ0JpWVd4aGJtTmxJRDBnZEdocGN5NTFjMlZ5UW1Gc1lXNWpaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaUW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnWVhOelpYSjBLR0poYkdGdVkyVWdQaUJWYVc1ME5qUW9NQ2tzSUNkT2J5QmlZV3hoYm1ObElIUnZJSGRwZEdoa2NtRjNKeWtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFNXZJR0poYkdGdVkyVWdkRzhnZDJsMGFHUnlZWGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qRXdNaTB4TURnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzbHVkR2h5WVY5MllYVnNkQzlUZVc1MGFISmhWbUYxYkhRdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2pFd01pMHhNRGNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ltRnNZVzVqWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem94TURJdE1UQTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdKaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnZEdocGN5NTFjMlZ5UW1Gc1lXNWpaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklIVnpaWEpDWVd4aGJtTmxJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZFhObGNsOWlZV3hoYm1ObEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2w5aVlXeGhibU5sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpDWVd4aGJtTmxLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnVldsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZHlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzZVM2x1ZEdoeVlWWmhkV3gwTG1SbFpIVmpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFpIVmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qRXlNZ29nSUNBZ0x5OGdjSFZpYkdsaklHUmxaSFZqZENoMWMyVnlPaUJCWTJOdmRXNTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0IwYUdVZ2IzZHVaWElnWTJGdUlHUmxaSFZqZENjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHZkMjVsY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnZEdobElHOTNibVZ5SUdOaGJpQmtaV1IxWTNRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdiM2R1WlhJZ1kyRnVJR1JsWkhWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCaGMzTmxjblFvWVcxdmRXNTBJRDRnVldsdWREWTBLREFwTENBblJHVmtkV04wYVc5dUlHRnRiM1Z1ZENCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQjZaWEp2SnlrS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRVJsWkhWamRHbHZiaUJoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBRbUZzWVc1alpTQTlJSFJvYVhNdWRYTmxja0poYkdGdVkyVW9kWE5sY2lrdWRtRnNkV1VLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklIVnpaWEpDWVd4aGJtTmxJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZFhObGNsOWlZV3hoYm1ObEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2w5aVlXeGhibU5sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZNVEkyQ2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MFFtRnNZVzVqWlNBOUlIUm9hWE11ZFhObGNrSmhiR0Z1WTJVb2RYTmxjaWt1ZG1Gc2RXVUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z5Y21WdWRFSmhiR0Z1WTJVZ1BqMGdZVzF2ZFc1MExDQW5TVzV6ZFdabWFXTnBaVzUwSUhWelpYSWdZbUZzWVc1alpTY3BDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQjFjMlZ5SUdKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnlRbUZzWVc1alpTaDFjMlZ5S1M1MllXeDFaU0E5SUdOMWNuSmxiblJDWVd4aGJtTmxJQzBnWVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnZFhObGNrSmhiR0Z1WTJVZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDFjMlZ5WDJKaGJHRnVZMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWMyVnlYMkpoYkdGdVkyVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzbHVkR2h5WVY5MllYVnNkQzlUZVc1MGFISmhWbUYxYkhRdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklIUm9hWE11ZFhObGNrSmhiR0Z1WTJVb2RYTmxjaWt1ZG1Gc2RXVWdQU0JqZFhKeVpXNTBRbUZzWVc1alpTQXRJR0Z0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TVRNd0NpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1EyRnNiSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUTJGc2JITXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnZEc5MFlXeERZV3hzY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBiM1JoYkY5allXeHNjeWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMk5oYkd4eklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02TVRNd0NpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1EyRnNiSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUTJGc2JITXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01Ta0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjViblJvY21GZmRtRjFiSFF2VTNsdWRHaHlZVlpoZFd4MExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIUnZkR0ZzUTJGc2JITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZEc5MFlXeGZZMkZzYkhNbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5allXeHNjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXplVzUwYUhKaFgzWmhkV3gwTDFONWJuUm9jbUZXWVhWc2RDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRU5oYkd4ekxuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFTmhiR3h6TG5aaGJIVmxJQ3NnVldsdWREWTBLREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM041Ym5Sb2NtRmZkbUYxYkhRdlUzbHVkR2h5WVZaaGRXeDBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZrZFdOMEtIVnpaWEk2SUVGalkyOTFiblFzSUdGdGIzVnVkRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNONWJuUm9jbUZmZG1GMWJIUXZVM2x1ZEdoeVlWWmhkV3gwTG1Gc1oyOHVkSE02T2xONWJuUm9jbUZXWVhWc2RDNW5aWFJDWVd4aGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFFtRnNZVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZVc1MGFISmhYM1poZFd4MEwxTjViblJvY21GV1lYVnNkQzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVKaGJHRnVZMlVvZFhObGNqb2dRV05qYjNWdWRDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2pFME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkWE5sY2tKaGJHRnVZMlVvZFhObGNpa3VkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM2x1ZEdoeVlWOTJZWFZzZEM5VGVXNTBhSEpoVm1GMWJIUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkWE5sY2tKaGJHRnVZMlVnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMWMyVnlYMkpoYkdGdVkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVgySmhiR0Z1WTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNsdWRHaHlZVjkyWVhWc2RDOVRlVzUwYUhKaFZtRjFiSFF1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuVnpaWEpDWVd4aGJtTmxLSFZ6WlhJcExuWmhiSFZsQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emVXNTBhSEpoWDNaaGRXeDBMMU41Ym5Sb2NtRldZWFZzZEM1aGJHZHZMblJ6T2pFME1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFSmhiR0Z1WTJVb2RYTmxjam9nUVdOamIzVnVkQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBZ0pnTU1kWE5sY2w5aVlXeGhibU5sQzNSdmRHRnNYMk5oYkd4ekJXOTNibVZ5Z0FRcE1VMlZOaG9BamdFQU96RVpGRVF4R0VFQUpJSUVCRFlsNU9zRXR6VmYwUVJaR2l4NkJMUVhxR1EyR2dDT0JBQXFBRlVBY2dDcEFJQUV1RVI3TmpZYUFJNEJBQXdBTVJraUVqRVlFRVJDQUFrcU1RQm5LU05uSWtNeEFDZ2paaUpETVJZaUNVazRFQ0lTUkVrNEJ6SUtFa1JKT0FBeEFCSkVPQWhKUkRFQUl5aGpSQWd4QUNoUEFtWWlRekVBSXloalJFbEVzVEVBc2dleUNDS3lFQ095QWJNeEFDZ2paaUpETmhvQlNSVWtFa1EyR2dKSkZZRUlFa1FYTVFBakttVkVFa1JKUkVzQkl5aGpSRWxMQWc5RVRBa29UR1lqS1dWRUlnZ3BUR2NpUXpZYUFVa1ZKQkpFSXloalJCYUFCQlVmZkhWTVVMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
