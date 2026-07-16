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

namespace Arc56.Generated.akita_protocol.akita_sc.AbstractedAccountBalanceReader_995b041f
{


    //
    // Immutable readonly helper that reports the combined balance
    //(wallet holdings + staked hard + staked lock) for an address.
    //
    //This was extracted from `AbstractedAccount.balance()` to keep that logic
    //available for downstream contracts without keeping it on-chain in the
    //wallet bytecode. The contract intentionally has no UpdateApplication
    //handler, so once deployed it cannot be re-keyed / upgraded and callers
    //can trust its response shape over time.
    //
    //A balance returned by this contract is still only as trustworthy as
    //the underlying AkitaDAO + Staking apps it queries — do not use it as
    //a security-critical balance source for an adversarial wallet.
    //
    public class AbstractedAccountBalanceReaderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbstractedAccountBalanceReaderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO">The app ID of the Akita DAO used to resolve dependent apps </param>
        public async Task Create(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the balance of a set of assets at the given address, including any
        ///amounts that address has staked in the Akita staking contract.
        ///</summary>
        /// <param name="address">The address to look up balances for </param>
        /// <param name="assets">The asset IDs to check balances for (0 for ALGO) </param>
        public async Task<ulong[]> Balance(Algorand.Address address, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 197, 93, 38 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> Balance_Transactions(Algorand.Address address, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 197, 93, 38 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJzdHJhY3RlZEFjY291bnRCYWxhbmNlUmVhZGVyIiwiZGVzYyI6IkltbXV0YWJsZSByZWFkb25seSBoZWxwZXIgdGhhdCByZXBvcnRzIHRoZSBjb21iaW5lZCBiYWxhbmNlXG4od2FsbGV0IGhvbGRpbmdzICsgc3Rha2VkIGhhcmQgKyBzdGFrZWQgbG9jaykgZm9yIGFuIGFkZHJlc3MuXG5cblRoaXMgd2FzIGV4dHJhY3RlZCBmcm9tIGBBYnN0cmFjdGVkQWNjb3VudC5iYWxhbmNlKClgIHRvIGtlZXAgdGhhdCBsb2dpY1xuYXZhaWxhYmxlIGZvciBkb3duc3RyZWFtIGNvbnRyYWN0cyB3aXRob3V0IGtlZXBpbmcgaXQgb24tY2hhaW4gaW4gdGhlXG53YWxsZXQgYnl0ZWNvZGUuIFRoZSBjb250cmFjdCBpbnRlbnRpb25hbGx5IGhhcyBubyBVcGRhdGVBcHBsaWNhdGlvblxuaGFuZGxlciwgc28gb25jZSBkZXBsb3llZCBpdCBjYW5ub3QgYmUgcmUta2V5ZWQgLyB1cGdyYWRlZCBhbmQgY2FsbGVyc1xuY2FuIHRydXN0IGl0cyByZXNwb25zZSBzaGFwZSBvdmVyIHRpbWUuXG5cbkEgYmFsYW5jZSByZXR1cm5lZCBieSB0aGlzIGNvbnRyYWN0IGlzIHN0aWxsIG9ubHkgYXMgdHJ1c3R3b3J0aHkgYXNcbnRoZSB1bmRlcmx5aW5nIEFraXRhREFPICsgU3Rha2luZyBhcHBzIGl0IHF1ZXJpZXMg4oCUIGRvIG5vdCB1c2UgaXQgYXNcbmEgc2VjdXJpdHktY3JpdGljYWwgYmFsYW5jZSBzb3VyY2UgZm9yIGFuIGFkdmVyc2FyaWFsIHdhbGxldC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6IlRoZSBhcHAgSUQgb2YgdGhlIEFraXRhIERBTyB1c2VkIHRvIHJlc29sdmUgZGVwZW5kZW50IGFwcHMiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZSIsImRlc2MiOiJHZXQgdGhlIGJhbGFuY2Ugb2YgYSBzZXQgb2YgYXNzZXRzIGF0IHRoZSBnaXZlbiBhZGRyZXNzLCBpbmNsdWRpbmcgYW55XG5hbW91bnRzIHRoYXQgYWRkcmVzcyBoYXMgc3Rha2VkIGluIHRoZSBBa2l0YSBzdGFraW5nIGNvbnRyYWN0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyB0byBsb29rIHVwIGJhbGFuY2VzIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjoiVGhlIGFzc2V0IElEcyB0byBjaGVjayBiYWxhbmNlcyBmb3IgKDAgZm9yIEFMR08pIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHRvdGFsIGJhbGFuY2UgZm9yIGVhY2ggYXNzZXQgKHdhbGxldCArIHN0YWtlZCBoYXJkICsgc3Rha2VkIGxvY2spIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTBdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQsMjM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OkVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBNElERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRnJhWFJoWDJSaGJ5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6b3pNeTB6TmdvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzS0lDQWdJQzh2SUNBZ2MzUmhkR1ZVYjNSaGJITTZJSHNnWjJ4dlltRnNRbmwwWlhNNklERXNJR2RzYjJKaGJGVnBiblJ6T2lBd0lIMEtJQ0FnSUM4dklIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVdKemRISmhZM1JsWkVGalkyOTFiblJDWVd4aGJtTmxVbVZoWkdWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhsT1dNMU5XUXlOaUF2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlVvWVdSa2NtVnpjeXgxYVc1ME5qUmJYU2wxYVc1ME5qUmJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKaGJHRnVZMlVLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdlltRnNZVzVqWlMxeVpXRmtaWEl1WVd4bmJ5NTBjem96TXkwek5nb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc0tJQ0FnSUM4dklDQWdjM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzUW5sMFpYTTZJREVzSUdkc2IySmhiRlZwYm5Sek9pQXdJSDBLSUNBZ0lDOHZJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXSnpkSEpoWTNSbFpFRmpZMjkxYm5SQ1lXeGhibU5sVW1WaFpHVnlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF3WkRKbU5qY2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk9rRmljM1J5WVdOMFpXUkJZMk52ZFc1MFFtRnNZVzVqWlZKbFlXUmxjaTVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQkJjSEJzYVdOaGRHbHZiaWhoYTJsMFlVUkJUeWtLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk9rRmljM1J5WVdOMFpXUkJZMk52ZFc1MFFtRnNZVzVqWlZKbFlXUmxjaTVpWVd4aGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW1Gc1lXNWpaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHeGxkQ0JoYlc5MWJuUnpPaUIxYVc1ME5qUmJYU0E5SUZ0ZENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWE56WlhSekxteGxibWQwYURzZ2FTQXJQU0F4S1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1ltRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcElDczlJREVwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJR0poYkdGdVkyVmZZV1owWlhKZmQyaHBiR1ZBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUd4bGRDQmhiVzkxYm5RNklIVnBiblEyTkNBOUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBJRDBnUVhOelpYUW9ZWE56WlhSelcybGRLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1IxY0RJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdhV1lnS0dGemMyVjBMbWxrSUQwOVBTQXdLU0I3Q2lBZ0lDQmlibm9nWW1Gc1lXNWpaVjlsYkhObFgySnZaSGxBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdlltRnNZVzVqWlMxeVpXRmtaWEl1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVcxdmRXNTBJRDBnWVdSa2NtVnpjeTVpWVd4aGJtTmxDaUFnSUNCa2FXY2dOQW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkNZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlEa0tJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9LWW1Gc1lXNWpaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qY3lMVGM0Q2lBZ0lDQXZMeUJqYjI1emRDQmxjMk55YjNkSmJtWnZJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1JoYTJsdVp5NXdjbTkwYjNSNWNHVXVaMlYwUlhOamNtOTNTVzVtYno0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuTjBZV3RwYm1jc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQmhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMExtbGtDaUFnSUNBdkx5QWdJRjBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUJoY0hCSlpEb2daMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbk4wWVd0cGJtY3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRMENpQWdJQ0F2THlCamIyNXpkQ0JiWVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFFYQndUR2x6ZENrcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1GaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qY3lMVGM0Q2lBZ0lDQXZMeUJqYjI1emRDQmxjMk55YjNkSmJtWnZJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1JoYTJsdVp5NXdjbTkwYjNSNWNHVXVaMlYwUlhOamNtOTNTVzVtYno0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuTjBZV3RwYm1jc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQmhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMExtbGtDaUFnSUNBdkx5QWdJRjBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6ZzRaV0ZqWlNBdkx5QnRaWFJvYjJRZ0ltZGxkRVZ6WTNKdmQwbHVabThvWVdSa2NtVnpjeXgxYVc1ME5qUXBLSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MM1I1Y0dWekxuUnpPanBGYzJOeWIzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHRnRiM1Z1ZEhNZ1BTQmJMaTR1WVcxdmRXNTBjeXdnS0dGdGIzVnVkQ0FySUdWelkzSnZkMGx1Wm04dWFHRnlaQ0FySUdWelkzSnZkMGx1Wm04dWJHOWpheWxkQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QTVDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCaGMzTmxkSE11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCaVlXeGhibU5sWDNkb2FXeGxYM1J2Y0VBeUNncGlZV3hoYm1ObFgyVnNjMlZmWW05a2VVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZMjl1YzNRZ1cyaHZiR1JwYm1kQmJXOTFiblFzSUc5d2RHVmtTVzVkSUQwZ1FYTnpaWFJJYjJ4a2FXNW5MbUZ6YzJWMFFtRnNZVzVqWlNoaFpHUnlaWE56TENCaGMzTmxkQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmthV2NnTndvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdsbUlDaHZjSFJsWkVsdUtTQjdDaUFnSUNCaWVpQmlZV3hoYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdaR2xuSURVS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWWlCaVlXeGhibU5sWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9LWW1Gc1lXNWpaVjloWm5SbGNsOTNhR2xzWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBZ0JKZ0lKWVd0cGRHRmZaR0Z2QkJVZmZIVXhHUlJFTVJoQkFBNkFCT25GWFNZMkdnQ09BUUFkQUlBRUpBMHZaellhQUk0QkFBRUFOaG9CU1JVakVrUVhLRXhuSkVNaWdBQkhBallhQVVrVmdTQVNSRFlhQWtjQ0lsbEpUZ0lqQzRFQ0NFd1ZFa1NBQWdBQUlrbExBd3hCQUtJaVJRaExBMWNDQUVzQkl3dEtJMWhGQzF0SlJRaEFBSGRMQkhNQVRFVUpSTEVpS0dWRWdBTmhZV3hsU0NKYnNoaUFCRXlJNnM2eUdrc0VzaHBMQ0xJYWdRYXlFQ0t5QWJPMFBrbFhCQUJMQVZjQUJDa1NSQldCRUJKRVNZRUVXMHNKQ0V5QkRGc0lGb0FDQUFGTVVFbFhBZ0JNSWxsTEEwbE9BaUpaQ0JaWEJnQmNBRXhRUlFKSkpBaEZBVUwvYWtzRVN3ZHdBRXhGQjBIL2hVc0ZSUWhDLzM0cFN3SlFzQ1JEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
