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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJzdHJhY3RlZEFjY291bnRCYWxhbmNlUmVhZGVyIiwiZGVzYyI6IkltbXV0YWJsZSByZWFkb25seSBoZWxwZXIgdGhhdCByZXBvcnRzIHRoZSBjb21iaW5lZCBiYWxhbmNlXG4od2FsbGV0IGhvbGRpbmdzICsgc3Rha2VkIGhhcmQgKyBzdGFrZWQgbG9jaykgZm9yIGFuIGFkZHJlc3MuXG5cblRoaXMgd2FzIGV4dHJhY3RlZCBmcm9tIGBBYnN0cmFjdGVkQWNjb3VudC5iYWxhbmNlKClgIHRvIGtlZXAgdGhhdCBsb2dpY1xuYXZhaWxhYmxlIGZvciBkb3duc3RyZWFtIGNvbnRyYWN0cyB3aXRob3V0IGtlZXBpbmcgaXQgb24tY2hhaW4gaW4gdGhlXG53YWxsZXQgYnl0ZWNvZGUuIFRoZSBjb250cmFjdCBpbnRlbnRpb25hbGx5IGhhcyBubyBVcGRhdGVBcHBsaWNhdGlvblxuaGFuZGxlciwgc28gb25jZSBkZXBsb3llZCBpdCBjYW5ub3QgYmUgcmUta2V5ZWQgLyB1cGdyYWRlZCBhbmQgY2FsbGVyc1xuY2FuIHRydXN0IGl0cyByZXNwb25zZSBzaGFwZSBvdmVyIHRpbWUuXG5cbkEgYmFsYW5jZSByZXR1cm5lZCBieSB0aGlzIGNvbnRyYWN0IGlzIHN0aWxsIG9ubHkgYXMgdHJ1c3R3b3J0aHkgYXNcbnRoZSB1bmRlcmx5aW5nIEFraXRhREFPICsgU3Rha2luZyBhcHBzIGl0IHF1ZXJpZXMg4oCUIGRvIG5vdCB1c2UgaXQgYXNcbmEgc2VjdXJpdHktY3JpdGljYWwgYmFsYW5jZSBzb3VyY2UgZm9yIGFuIGFkdmVyc2FyaWFsIHdhbGxldC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6IlRoZSBhcHAgSUQgb2YgdGhlIEFraXRhIERBTyB1c2VkIHRvIHJlc29sdmUgZGVwZW5kZW50IGFwcHMiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZSIsImRlc2MiOiJHZXQgYmFsYW5jZXMgZm9yIHRoZSBzdXBwbGllZCBhc3NldHMsIGluY2x1ZGluZyBoYXJkIGFuZCBsb2NrZWQgc3Rha2UuXG5Bc3NldCBJRCB6ZXJvIHJlcHJlc2VudHMgQUxHTy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjA0XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NCwyMzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc3Rha2luZy90eXBlcy50czo6RXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0E0SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW1GcmFYUmhYMlJoYnlJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvek15MHpOZ29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNLSUNBZ0lDOHZJQ0FnYzNSaGRHVlViM1JoYkhNNklIc2daMnh2WW1Gc1FubDBaWE02SURFc0lHZHNiMkpoYkZWcGJuUnpPaUF3SUgwS0lDQWdJQzh2SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUkNZV3hoYm1ObFVtVmhaR1Z5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxPV00xTldReU5pQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVW9ZV1JrY21WemN5eDFhVzUwTmpSYlhTbDFhVzUwTmpSYlhTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0poYkdGdVkyVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6b3pNeTB6TmdvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzS0lDQWdJQzh2SUNBZ2MzUmhkR1ZVYjNSaGJITTZJSHNnWjJ4dlltRnNRbmwwWlhNNklERXNJR2RzYjJKaGJGVnBiblJ6T2lBd0lIMEtJQ0FnSUM4dklIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVdKemRISmhZM1JsWkVGalkyOTFiblJDWVd4aGJtTmxVbVZoWkdWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qUXdaREptTmpjZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02T2tGaWMzUnlZV04wWldSQlkyTnZkVzUwUW1Gc1lXNWpaVkpsWVdSbGNpNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VnUFNCQmNIQnNhV05oZEdsdmJpaGhhMmwwWVVSQlR5a0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02T2tGaWMzUnlZV04wWldSQlkyTnZkVzUwUW1Gc1lXNWpaVkpsWVdSbGNpNWlZV3hoYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbUZzWVc1alpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIVnBiblEyTkQ0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4bGRDQmhiVzkxYm5Sek9pQjFhVzUwTmpSYlhTQTlJRnRkQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWW1Gc1lXNWpaVjkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCaGMzTmxkSE11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklHSmhiR0Z1WTJWZllXWjBaWEpmZDJocGJHVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR3hsZENCaGJXOTFiblE2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwySmhiR0Z1WTJVdGNtVmhaR1Z5TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdOdmJuTjBJR0Z6YzJWMElEMGdRWE56WlhRb1lYTnpaWFJ6VzJsZEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQ29LSUNBZ0lHUjFjRElLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2FXWWdLR0Z6YzJWMExtbGtJRDA5UFNBd0tTQjdDaUFnSUNCaWJub2dZbUZzWVc1alpWOWxiSE5sWDJKdlpIbEFOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WW1Gc1lXNWpaUzF5WldGa1pYSXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdZVzF2ZFc1MElEMGdZV1JrY21WemN5NWlZV3hoYm1ObENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSQ1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb0tZbUZzWVc1alpWOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pZNExUY3hDaUFnSUNBdkx5QmpiMjV6ZENCbGMyTnliM2RKYm1adklEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1UzUmhhMmx1Wnk1d2NtOTBiM1I1Y0dVdVoyVjBSWE5qY205M1NXNW1iejRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nWjJWMFFXdHBkR0ZCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG5OMFlXdHBibWNzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRoWkdSeVpYTnpMQ0JoYzNObGRDNXBaRjBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aVlXeGhibU5sTFhKbFlXUmxjaTVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJoY0hCSlpEb2daMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbk4wWVd0cGJtY3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZbUZzWVc1alpTMXlaV0ZrWlhJdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRMENpQWdJQ0F2THlCamIyNXpkQ0JiWVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFFYQndUR2x6ZENrcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1GaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VjM1JoYTJsdVp5d0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qWTRMVGN4Q2lBZ0lDQXZMeUJqYjI1emRDQmxjMk55YjNkSmJtWnZJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1JoYTJsdVp5NXdjbTkwYjNSNWNHVXVaMlYwUlhOamNtOTNTVzVtYno0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuTjBZV3RwYm1jc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aFpHUnlaWE56TENCaGMzTmxkQzVwWkYwS0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZemc0WldGalpTQXZMeUJ0WlhSb2IyUWdJbWRsZEVWelkzSnZkMGx1Wm04b1lXUmtjbVZ6Y3l4MWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRGdLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDNSNWNHVnpMblJ6T2pwRmMyTnliM2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR0Z0YjNWdWRITWdQU0JiTGk0dVlXMXZkVzUwY3l3Z1lXMXZkVzUwSUNzZ1pYTmpjbTkzU1c1bWJ5NW9ZWEprSUNzZ1pYTmpjbTkzU1c1bWJ5NXNiMk5yWFFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dPUW9nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1ltRnNZVzVqWlY5M2FHbHNaVjkwYjNCQU1nb0tZbUZzWVc1alpWOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJKaGJHRnVZMlV0Y21WaFpHVnlMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJR052Ym5OMElGdG9iMnhrYVc1blFXMXZkVzUwTENCdmNIUmxaRWx1WFNBOUlFRnpjMlYwU0c5c1pHbHVaeTVoYzNObGRFSmhiR0Z1WTJVb1lXUmtjbVZ6Y3l3Z1lYTnpaWFFwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaR2xuSURjS0lDQWdJR0Z6YzJWMFgyaHZiR1JwYm1kZloyVjBJRUZ6YzJWMFFtRnNZVzVqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWlZV3hoYm1ObExYSmxZV1JsY2k1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCcFppQW9iM0IwWldSSmJpa2dld29nSUNBZ1lub2dZbUZzWVc1alpWOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJR1JwWnlBMUNpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUdJZ1ltRnNZVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRRGdLQ21KaGJHRnVZMlZmWVdaMFpYSmZkMmhwYkdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzlpWVd4aGJtTmxMWEpsWVdSbGNpNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQWdCSmdJSllXdHBkR0ZmWkdGdkJCVWZmSFV4R1JSRU1SaEJBQTZBQk9uRlhTWTJHZ0NPQVFBZEFJQUVKQTB2WnpZYUFJNEJBQUVBTmhvQlNSVWpFa1FYS0V4bkpFTWlnQUJIQWpZYUFVa1ZnU0FTUkRZYUFrY0NJbGxKVGdJakM0RUNDRXdWRWtTQUFnQUFJa2xMQXd4QkFLSWlSUWhMQTFjQ0FFc0JJd3RLSTFoRkMxdEpSUWhBQUhkTEJITUFURVVKUkxFaUtHVkVnQU5oWVd4bFNDSmJzaGlBQkV5STZzNnlHa3NFc2hwTENMSWFnUWF5RUNLeUFiTzBQa2xYQkFCTEFWY0FCQ2tTUkJXQkVCSkVTWUVFVzBzSkNFeUJERnNJRm9BQ0FBRk1VRWxYQWdCTUlsbExBMGxPQWlKWkNCWlhCZ0JjQUV4UVJRSkpKQWhGQVVML2Frc0VTd2R3QUV4RkIwSC9oVXNGUlFoQy8zNHBTd0pRc0NSRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
