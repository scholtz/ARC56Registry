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
        ///Get balances for the supplied assets, including hard and locked stake.
        ///Asset ID zero represents ALGO.
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="assets"> </param>
        public async Task<ulong[]> Balance(Algorand.Address address, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 197, 93, 38 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
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
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJzdHJhY3RlZEFjY291bnRCYWxhbmNlUmVhZGVyIiwiZGVzYyI6IkltbXV0YWJsZSByZWFkb25seSBoZWxwZXIgdGhhdCByZXBvcnRzIHRoZSBjb21iaW5lZCBiYWxhbmNlXG4od2FsbGV0IGhvbGRpbmdzICsgc3Rha2VkIGhhcmQgKyBzdGFrZWQgbG9jaykgZm9yIGFuIGFkZHJlc3MuXG5cblRoaXMgd2FzIGV4dHJhY3RlZCBmcm9tIGBBYnN0cmFjdGVkQWNjb3VudC5iYWxhbmNlKClgIHRvIGtlZXAgdGhhdCBsb2dpY1xuYXZhaWxhYmxlIGZvciBkb3duc3RyZWFtIGNvbnRyYWN0cyB3aXRob3V0IGtlZXBpbmcgaXQgb24tY2hhaW4gaW4gdGhlXG53YWxsZXQgYnl0ZWNvZGUuIFRoZSBjb250cmFjdCBpbnRlbnRpb25hbGx5IGhhcyBubyBVcGRhdGVBcHBsaWNhdGlvblxuaGFuZGxlciwgc28gb25jZSBkZXBsb3llZCBpdCBjYW5ub3QgYmUgcmUta2V5ZWQgLyB1cGdyYWRlZCBhbmQgY2FsbGVyc1xuY2FuIHRydXN0IGl0cyByZXNwb25zZSBzaGFwZSBvdmVyIHRpbWUuXG5cbkEgYmFsYW5jZSByZXR1cm5lZCBieSB0aGlzIGNvbnRyYWN0IGlzIHN0aWxsIG9ubHkgYXMgdHJ1c3R3b3J0aHkgYXNcbnRoZSB1bmRlcmx5aW5nIEFraXRhREFPICsgU3Rha2luZyBhcHBzIGl0IHF1ZXJpZXMg4oCUIGRvIG5vdCB1c2UgaXQgYXNcbmEgc2VjdXJpdHktY3JpdGljYWwgYmFsYW5jZSBzb3VyY2UgZm9yIGFuIGFkdmVyc2FyaWFsIHdhbGxldC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6IlRoZSBhcHAgSUQgb2YgdGhlIEFraXRhIERBTyB1c2VkIHRvIHJlc29sdmUgZGVwZW5kZW50IGFwcHMiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZSIsImRlc2MiOiJHZXQgYmFsYW5jZXMgZm9yIHRoZSBzdXBwbGllZCBhc3NldHMsIGluY2x1ZGluZyBoYXJkIGFuZCBsb2NrZWQgc3Rha2UuXG5Bc3NldCBJRCB6ZXJvIHJlcHJlc2VudHMgQUxHTy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQsMjMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3N0YWtpbmcvdHlwZXMudHM6OkVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBNElERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRnJhWFJoWDJSaGJ5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGaWMzUnlZV04wWldSQlkyTnZkVzUwUW1Gc1lXNWpaVkpsWVdSbGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WlRsak5UVmtNallnTHk4Z2JXVjBhRzlrSUNKaVlXeGhibU5sS0dGa1pISmxjM01zZFdsdWREWTBXMTBwZFdsdWREWTBXMTBpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaVlXeGhibU5sQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJZbk4wY21GamRHVmtRV05qYjNWdWRFSmhiR0Z1WTJWU1pXRmtaWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TkRCa01tWTJOeUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzZRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUkNZV3hoYm1ObFVtVmhaR1Z5TG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTQTlJRUZ3Y0d4cFkyRjBhVzl1S0dGcmFYUmhSRUZQS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzZRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUkNZV3hoYm1ObFVtVmhaR1Z5TG1KaGJHRnVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaVlXeGhibU5sT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHeGxkQ0JoYlc5MWJuUnpPaUIxYVc1ME5qUmJYU0E5SUZ0ZENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWE56WlhSekxteGxibWQwYURzZ2FTQXJQU0F4S1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1ltRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcElDczlJREVwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJRHdLSUNBZ0lHSjZJR0poYkdGdVkyVmZZV1owWlhKZmQyaHBiR1ZBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUd4bGRDQmhiVzkxYm5RNklIVnBiblEyTkNBOUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBJRDBnUVhOelpYUW9ZWE56WlhSelcybGRLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1IxY0RJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHbG1JQ2hoYzNObGRDNXBaQ0E5UFQwZ01Da2dld29nSUNBZ1ltNTZJR0poYkdGdVkyVmZaV3h6WlY5aWIyUjVRRFVLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRnNaMjlkSUQwZ1FXTmpkRkJoY21GdGN5NWhZMk4wUW1Gc1lXNWpaU2hoWkdSeVpYTnpLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnY0c5d0NpQWdJQ0JpZFhKNUlEZ0tDbUpoYkdGdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvMk55MDNNQW9nSUNBZ0x5OGdZMjl1YzNRZ1pYTmpjbTkzU1c1bWJ5QTlJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlGTjBZV3RwYm1jdWNISnZkRzkwZVhCbExtZGxkRVZ6WTNKdmQwbHVabTgrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1emRHRnJhVzVuTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWVdSa2NtVnpjeXdnWVhOelpYUXVhV1JkQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdlltRnNZVzVqWlMxeVpXRmtaWEl1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWVhCd1NXUTZJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV6ZEdGcmFXNW5MQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMMkpoYkdGdVkyVXRjbVZoWkdWeUxtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJoY0hCSlpEb2daMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbk4wWVd0cGJtY3NDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU1EWUtJQ0FnSUM4dklHTnZibk4wSUZ0aGNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6UVd0cGRHRkJjSEJNYVhOMEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlXRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdlltRnNZVzVqWlMxeVpXRmtaWEl1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWVhCd1NXUTZJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzV6ZEdGcmFXNW5MQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOamN0TnpBS0lDQWdJQzh2SUdOdmJuTjBJR1Z6WTNKdmQwbHVabThnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJUZEdGcmFXNW5MbkJ5YjNSdmRIbHdaUzVuWlhSRmMyTnliM2RKYm1adlBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyRmtaSEpsYzNNc0lHRnpjMlYwTG1sa1hRb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqT0RobFlXTmxJQzh2SUcxbGRHaHZaQ0FpWjJWMFJYTmpjbTkzU1c1bWJ5aGhaR1J5WlhOekxIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5MGVYQmxjeTUwY3pvNlJYTmpjbTkzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJoYlc5MWJuUnpJRDBnV3k0dUxtRnRiM1Z1ZEhNc0lHRnRiM1Z1ZENBcklHVnpZM0p2ZDBsdVptOHVhR0Z5WkNBcklHVnpZM0p2ZDBsdVptOHViRzlqYTEwS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRGdLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWVhOelpYUnpMbXhsYm1kMGFEc2dhU0FyUFNBeEtTQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJpWVd4aGJtTmxYM2RvYVd4bFgzUnZjRUF5Q2dwaVlXeGhibU5sWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJodmJHUnBibWRCYlc5MWJuUXNJRzl3ZEdWa1NXNWRJRDBnUVhOelpYUkliMnhrYVc1bkxtRnpjMlYwUW1Gc1lXNWpaU2hoWkdSeVpYTnpMQ0JoYzNObGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdhV1lnS0c5d2RHVmtTVzRwSUhzS0lDQWdJR0o2SUdKaGJHRnVZMlZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNCa2FXY2dOZ29nSUNBZ1luVnllU0E0Q2lBZ0lDQmlJR0poYkdGdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBNENncGlZV3hoYm1ObFgyRm1kR1Z5WDNkb2FXeGxRREV3T2dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFnQkpnSUpZV3RwZEdGZlpHRnZCQlVmZkhVeEdSUkVNUmhCQUE2QUJPbkZYU1kyR2dDT0FRQWRBSUFFSkEwdlp6WWFBSTRCQUFFQU5ob0JTUlVqRWtRWEtFeG5KRU9BQUVrMkdnRkpGWUVnRWtRMkdnSkpUZ0pKSWxsSlRnTWpDNEVDQ0V3VkVrU0FBZ0FBVENKSlN3UU1RUUNiSWtVSFN3UlhBZ0JMQVNNTFNpTllUZ05iU1VBQWMwaExBbk1BU0VVSXNTSW9aVVNBQTJGaGJHVklJbHV5R0lBRVRJanF6cklhU3dLeUdreXlHb0VHc2hBaXNnR3p0RDVKVndRQVN3RlhBQVFwRWtRVmdSQVNSRW1CQkZ0TENBaE1nUXhiQ0JhQUFnQUJURkJKVndJQVRDSlpUd1JKVGdJaVdRZ1dWd1lBWEFCTVVFNENKQWhDLzNCTEEweHdBRXhGQ0VIL2lrc0dSUWhDLzROR0FpbE1VTEFrUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
