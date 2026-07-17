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

namespace Arc56.Generated.algorandfoundation.puya.BranchElimination_481297ca
{


    public class BranchEliminationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BranchEliminationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Umm(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 194, 80, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Umm_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 194, 80, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Umm2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 75, 34, 63 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Umm2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 75, 34, 63 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nested_list"> </param>
        /// <param name="threshold"> </param>
        public async Task Calculate(ulong[][] nested_list, ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 127, 119, 95 };
            var nested_listAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); nested_listAbi.From(nested_list);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            var result = await base.CallApp(new List<object> { abiHandle, nested_listAbi, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Calculate_Transactions(ulong[][] nested_list, ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 127, 119, 95 };
            var nested_listAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); nested_listAbi.From(nested_list);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, nested_listAbi, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQnJhbmNoRWxpbWluYXRpb24iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidW1tIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW1tMiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5lc3RlZF9saXN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMDQsMzM4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NiwyMTAsMjczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50NjQ+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rdWludDY0W10pW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUE0Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkNjbUZ1WTJoRmJHbHRhVzVoZEdsdmJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRmxZekkxTUdWbUlEQjRZbVEwWWpJeU0yWWdNSGc0TkRkbU56YzFaaUF2THlCdFpYUm9iMlFnSW5WdGJTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSjFiVzB5S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqWVd4amRXeGhkR1VvZFdsdWREWTBXMTFiWFN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSFZ0YlNCMWJXMHlJR05oYkdOMWJHRjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFd09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuSmxaM0psYzNOcGIyNWZkR1Z6ZEhNdWJHVm1kRzkyWlhKZlluSmhibU5vTG1odGJTZ3BJQzArSUhWcGJuUTJORG9LYUcxdE9nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCR1lXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVjbVZuY21WemMybHZibDkwWlhOMGN5NXNaV1owYjNabGNsOWljbUZ1WTJndWFHMXRYM1ZwYm5RMk5DZ3BJQzArSUhWcGJuUTJORG9LYUcxdFgzVnBiblEyTkRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pZd0NpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbXhsWm5SdmRtVnlYMkp5WVc1amFDNUNjbUZ1WTJoRmJHbHRhVzVoZEdsdmJpNTFiVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWJXMDZDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzNDaUFnSUNBdkx5QmhhSFZvSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2RXMXRYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2T1FvZ0lDQWdMeThnWm05eUlGOXBJR2x1SUhWeVlXNW5aU2hvYlcxZmRXbHVkRFkwS0NrcE9nb2dJQ0FnWTJGc2JITjFZaUJvYlcxZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LZFcxdFgyWnZjbDlvWldGa1pYSkFORG9LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPamtLSUNBZ0lDOHZJR1p2Y2lCZmFTQnBiaUIxY21GdVoyVW9hRzF0WDNWcGJuUTJOQ2dwS1RvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFZ0YlY5aFpuUmxjbDltYjNKQU1UTUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qRXdDaUFnSUNBdkx5QnBaaUJvYlcwb0tUb2dJQ01nYm05eFlUb2dVMGxOTVRBeUNpQWdJQ0JqWVd4c2MzVmlJR2h0YlFvZ0lDQWdZbm9nZFcxdFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pFeENpQWdJQ0F2THlCcFppQm9iVzBvS1RvZ0lDTWdibTl4WVRvZ1UwbE5NVEF5Q2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1lub2dkVzF0WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPakV5Q2lBZ0lDQXZMeUJwWmlCb2JXMG9LVG9LSUNBZ0lHTmhiR3h6ZFdJZ2FHMXRDaUFnSUNCaWVpQjFiVzFmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZNVE1LSUNBZ0lDOHZJR0ZvZFdnZ0t6MGdhRzF0S0NrS0lDQWdJR05oYkd4emRXSWdhRzF0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0NuVnRiVjloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZPUW9nSUNBZ0x5OGdabTl5SUY5cElHbHVJSFZ5WVc1blpTaG9iVzFmZFdsdWREWTBLQ2twT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2RXMXRYMlp2Y2w5b1pXRmtaWEpBTkFvS2RXMXRYMkZtZEdWeVgyWnZja0F4TXpvS0lDQWdJSEJ2Y0FvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveE5Bb2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNkNpQWdJQ0JqWVd4c2MzVmlJR2h0YlFvZ0lDQWdZbm9nZFcxdFgzZG9hV3hsWDNSdmNFQXlDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11Y21WbmNtVnpjMmx2Ymw5MFpYTjBjeTVzWldaMGIzWmxjbDlpY21GdVkyZ3VRbkpoYm1Ob1JXeHBiV2x1WVhScGIyNHVkVzF0TWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnRiVEk2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG95TUFvZ0lDQWdMeThnWVdoMWFDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDblZ0YlRKZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUb3lNZ29nSUNBZ0x5OGdhV1lnYUcxdEtDazZJQ0FqSUc1dmNXRTZJRk5KVFRFd01nb2dJQ0FnWTJGc2JITjFZaUJvYlcwS0lDQWdJR0o2SUhWdGJUSmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU13b2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNklDQWpJRzV2Y1dFNklGTkpUVEV3TWdvZ0lDQWdZMkZzYkhOMVlpQm9iVzBLSUNBZ0lHSjZJSFZ0YlRKZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG95TkFvZ0lDQWdMeThnYVdZZ2FHMXRLQ2s2Q2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1lub2dkVzF0TWw5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPakkxQ2lBZ0lDQXZMeUJoYUhWb0lDczlJR2h0YlNncENpQWdJQ0JqWVd4c2MzVmlJR2h0YlFvZ0lDQWdLd29LZFcxdE1sOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU5nb2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNkNpQWdJQ0JqWVd4c2MzVmlJR2h0YlFvZ0lDQWdZbm9nZFcxdE1sOTNhR2xzWlY5MGIzQkFNZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWNtVm5jbVZ6YzJsdmJsOTBaWE4wY3k1c1pXWjBiM1psY2w5aWNtRnVZMmd1UW5KaGJtTm9SV3hwYldsdVlYUnBiMjR1WTJGc1kzVnNZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnNZM1ZzWVhSbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z013b2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbU5oYkdOMWJHRjBaVjltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQmpZV3hqZFd4aGRHVmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktHeGxiaXQxYVc1ME5qUmJYU2xiWFNrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHTmhiR04xYkdGMFpWOW1iM0pmYUdWaFpHVnlRREVLQ21OaGJHTjFiR0YwWlY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk1qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0K0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ053b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPak0yQ2lBZ0lDQXZMeUJ1ZFcxZlltOXZjM1J6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TXpVS0lDQWdJQzh2SUhSdmRHRnNJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmtkWEJ1SURJS0NtTmhiR04xYkdGMFpWOW1iM0pmYUdWaFpHVnlRRFk2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG96T0FvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLRzVsYzNSbFpGOXNhWE4wTG14bGJtZDBhQ2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCa2RYQUtJQ0FnSUdKNklHTmhiR04xYkdGMFpWOWhablJsY2w5bWIzSkFNVGtLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUb3pPUW9nSUNBZ0x5OGdhVzV1WlhKZmJHbHpkQ0E5SUc1bGMzUmxaRjlzYVhOMFcybGRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TkRBS0lDQWdJQzh2SUd4aGMzUmZhVzV1WlhKZmJHbHpkRjlwYm1SbGVDQTlJR2x1Ym1WeVgyeHBjM1F1YkdWdVozUm9JQzBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRvME1Rb2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0dsdWJtVnlYMnhwYzNRdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2dwallXeGpkV3hoZEdWZlptOXlYMmhsWVdSbGNrQTRPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZOREVLSUNBZ0lDOHZJR1p2Y2lCcUlHbHVJSFZ5WVc1blpTaHBibTVsY2w5c2FYTjBMbXhsYm1kMGFDazZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRGdLSUNBZ0lEd0tJQ0FnSUdKNklHTmhiR04xYkdGMFpWOWhablJsY2w5bWIzSkFNVGNLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPalF5Q2lBZ0lDQXZMeUIyWVd4MVpTQTlJR2x1Ym1WeVgyeHBjM1JiYWwwS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pRekNpQWdJQ0F2THlCcFppQjJZV3gxWlNBK1BTQjBhSEpsYzJodmJHUTZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHSStQUW9nSUNBZ1lub2dZMkZzWTNWc1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UVUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qUTBDaUFnSUNBdkx5Qm9ZWE5mYm1WNGRDQTlJR29nUENCc1lYTjBYMmx1Ym1WeVgyeHBjM1JmYVc1a1pYZ0tJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dOd29nSUNBZ1BBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk5EVUtJQ0FnSUM4dklHbG1JR2hoYzE5dVpYaDBPZ29nSUNBZ1lub2dZMkZzWTNWc1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UVUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qUTJDaUFnSUNBdkx5QjBiM1JoYkNBclBTQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG8wTndvZ0lDQWdMeThnYm1WNGRGOTJZV3gxWlNBOUlHbHVibVZ5WDJ4cGMzUmJhaUFySURGZENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JrYVdjZ01USUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qUTRDaUFnSUNBdkx5QnBaaUIyWVd4MVpTQThJRzVsZUhSZmRtRnNkV1U2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdZajRLSUNBZ0lHSjZJR05oYkdOMWJHRjBaVjloWm5SbGNsOXBabDlsYkhObFFERTFDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzBPUW9nSUNBZ0x5OGdkRzkwWVd3Z0tqMGdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TlRBS0lDQWdJQzh2SUc1MWJWOWliMjl6ZEhNZ0t6MGdNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1kyOTJaWElnTXdvS1kyRnNZM1ZzWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRvME1Rb2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0dsdWJtVnlYMnhwYzNRdWJHVnVaM1JvS1RvS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCaUlHTmhiR04xYkdGMFpWOW1iM0pmYUdWaFpHVnlRRGdLQ21OaGJHTjFiR0YwWlY5aFpuUmxjbDltYjNKQU1UYzZDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPak00Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9ibVZ6ZEdWa1gyeHBjM1F1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUdOaGJHTjFiR0YwWlY5bWIzSmZhR1ZoWkdWeVFEWUtDbU5oYkdOMWJHRjBaVjloWm5SbGNsOW1iM0pBTVRrNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0RFYlFRQWtNUmtVUkRFWVJJSURCSzdDVU84RXZVc2lQd1NFZjNkZk5ob0FqZ01BRFFCTkFHd0FNUmtVTVJnVUVFTWlpU0tKSW9qLytrd2lTVXNEREVFQUhvai83RUVBRTRqLzVrRUFEWWovNEVFQUI0ai8yazhDQ0V3akNFTC8yMGhGQVlqL3kwSC96UmFBQkJVZmZIVk1VTEFqUXlLSS83aEJBQkNJLzdKQkFBcUkvNnhCQUFTSS82WUlpUCtpUWYva0kwTWlSd09BQUVrMkdnRkpJbGxKVGdJa0MweEpGVTRDVndJQUlrbExCUXhCQUNOSkpBdExBa2xQQWxsSlR3VkpUZ1FTUkVzQkZWSWlXU1VMSkFnSVRnSWpDRUwvMWtoTUpBaFBBaEpFTmhvQ1NVVUhGU1VTUkNKSEFrbExCUXhKUVFCM1JFa2tDMHNFU1U4Q1dVcFpKUXNrQ0ZoSlJRc2lXVWxGQ0NNSlJRWWlURXNCU3dnTVFRQkpTd3BYQWdCSlJRMUxBaVVMSlZoSlJRcExDcWRCQUN0TEFVc0hERUVBSTA4Q0l3aE9Ba3NCSXdnbEMwc01UQ1ZZU3dtbFFRQU1Ud0lrQzA0Q1R3TWpDRTREVENNSVRFTC9yMFVCSXdoQy80RWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
