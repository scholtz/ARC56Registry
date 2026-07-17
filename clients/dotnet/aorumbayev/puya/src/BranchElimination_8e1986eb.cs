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

namespace Arc56.Generated.aorumbayev.puya.BranchElimination_8e1986eb
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQnJhbmNoRWxpbWluYXRpb24iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidW1tIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW1tMiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5lc3RlZF9saXN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODUsMzM3LDM4OF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUsNjMsNzVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OCw2Niw3OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXlDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQ2NtRnVZMmhGYkdsdGFXNWhkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGdLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoWldNeU5UQmxaaUF3ZUdKa05HSXlNak5tSURCNE9EUTNaamMzTldZZ0x5OGdiV1YwYUc5a0lDSjFiVzBvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFcxdE1pZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyRnNZM1ZzWVhSbEtIVnBiblEyTkZ0ZFcxMHNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z0YlY5eWIzVjBaVUF6SUcxaGFXNWZkVzF0TWw5eWIzVjBaVUEwSUcxaGFXNWZZMkZzWTNWc1lYUmxYM0p2ZFhSbFFEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUp5WVc1amFFVnNhVzFwYm1GMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJHTjFiR0YwWlY5eWIzVjBaVUExT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TWprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQ2NtRnVZMmhGYkdsdGFXNWhkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJqWVd4amRXeGhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkVzF0TWw5eWIzVjBaVUEwT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhWdGJUSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRXMXRYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQjFiVzBLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT0RvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUp5WVc1amFFVnNhVzFwYm1GMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVjbVZuY21WemMybHZibDkwWlhOMGN5NXNaV1owYjNabGNsOWljbUZ1WTJndWFHMXRLQ2tnTFQ0Z2RXbHVkRFkwT2dwb2JXMDZDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzFOUW9nSUNBZ0x5OGdjbVYwZFhKdUlFWmhiSE5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbXhsWm5SdmRtVnlYMkp5WVc1amFDNW9iVzFmZFdsdWREWTBLQ2tnTFQ0Z2RXbHVkRFkwT2dwb2JXMWZkV2x1ZERZME9nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5KbFozSmxjM05wYjI1ZmRHVnpkSE11YkdWbWRHOTJaWEpmWW5KaGJtTm9Ma0p5WVc1amFFVnNhVzFwYm1GMGFXOXVMblZ0YlNncElDMCtJSFZwYm5RMk5Eb0tkVzF0T2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TlMwMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMWJXMG9jMlZzWmlrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNQ0F4Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TndvZ0lDQWdMeThnWVdoMWFDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDblZ0YlY5M2FHbHNaVjkwYjNCQU1Ub0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qa0tJQ0FnSUM4dklHWnZjaUJmYVNCcGJpQjFjbUZ1WjJVb2FHMXRYM1ZwYm5RMk5DZ3BLVG9LSUNBZ0lHTmhiR3h6ZFdJZ2FHMXRYM1ZwYm5RMk5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwMWJXMWZabTl5WDJobFlXUmxja0F6T2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2T1FvZ0lDQWdMeThnWm05eUlGOXBJR2x1SUhWeVlXNW5aU2hvYlcxZmRXbHVkRFkwS0NrcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQjFiVzFmWVdaMFpYSmZabTl5UURFeUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveE1Bb2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNklDQWpJRzV2Y1dFNklGTkpUVEV3TWdvZ0lDQWdZMkZzYkhOMVlpQm9iVzBLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdKNklIVnRiVjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUb3hNUW9nSUNBZ0x5OGdhV1lnYUcxdEtDazZJQ0FqSUc1dmNXRTZJRk5KVFRFd01nb2dJQ0FnWTJGc2JITjFZaUJvYlcwS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSjZJSFZ0YlY5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG94TWdvZ0lDQWdMeThnYVdZZ2FHMXRLQ2s2Q2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWW5vZ2RXMXRYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qRXpDaUFnSUNBdkx5QmhhSFZvSUNzOUlHaHRiU2dwQ2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvS2RXMXRYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRvNUNpQWdJQ0F2THlCbWIzSWdYMmtnYVc0Z2RYSmhibWRsS0dodGJWOTFhVzUwTmpRb0tTazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQjFiVzFmWm05eVgyaGxZV1JsY2tBekNncDFiVzFmWVdaMFpYSmZabTl5UURFeU9nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk1UUUtJQ0FnSUM4dklHbG1JR2h0YlNncE9nb2dJQ0FnWTJGc2JITjFZaUJvYlcwS0lDQWdJR0o2SUhWdGJWOTNhR2xzWlY5MGIzQkFNUW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZNVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmhhSFZvQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbkpsWjNKbGMzTnBiMjVmZEdWemRITXViR1ZtZEc5MlpYSmZZbkpoYm1Ob0xrSnlZVzVqYUVWc2FXMXBibUYwYVc5dUxuVnRiVElvS1NBdFBpQjJiMmxrT2dwMWJXMHlPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZNVGd0TVRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhWdGJUSW9jMlZzWmlrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklEQWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUb3lNQW9nSUNBZ0x5OGdZV2gxYUNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuVnRiVEpmZDJocGJHVmZkRzl3UURFNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU1nb2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNklDQWpJRzV2Y1dFNklGTkpUVEV3TWdvZ0lDQWdZMkZzYkhOMVlpQm9iVzBLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKNklIVnRiVEpmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUb3lNd29nSUNBZ0x5OGdhV1lnYUcxdEtDazZJQ0FqSUc1dmNXRTZJRk5KVFRFd01nb2dJQ0FnWTJGc2JITjFZaUJvYlcwS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSjZJSFZ0YlRKZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG95TkFvZ0lDQWdMeThnYVdZZ2FHMXRLQ2s2Q2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW5vZ2RXMXRNbDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qSTFDaUFnSUNBdkx5QmhhSFZvSUNzOUlHaHRiU2dwQ2lBZ0lDQmpZV3hzYzNWaUlHaHRiUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS2RXMXRNbDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRveU5nb2dJQ0FnTHk4Z2FXWWdhRzF0S0NrNkNpQWdJQ0JqWVd4c2MzVmlJR2h0YlFvZ0lDQWdZbm9nZFcxdE1sOTNhR2xzWlY5MGIzQkFNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbXhsWm5SdmRtVnlYMkp5WVc1amFDNUNjbUZ1WTJoRmJHbHRhVzVoZEdsdmJpNWpZV3hqZFd4aGRHVW9ibVZ6ZEdWa1gyeHBjM1E2SUdKNWRHVnpMQ0IwYUhKbGMyaHZiR1E2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BqWVd4amRXeGhkR1U2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG95T1Mwek5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1kyRnNZM1ZzWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdibVZ6ZEdWa1gyeHBjM1E2SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVWVWx1ZERZMFhWMHNDaUFnSUNBdkx5QWdJQ0FnZEdoeVpYTm9iMnhrT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURVS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pNMUNpQWdJQ0F2THlCMGIzUmhiQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPak0yQ2lBZ0lDQXZMeUJ1ZFcxZlltOXZjM1J6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12YkdWbWRHOTJaWEpmWW5KaGJtTm9MbkI1T2pNNENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYm1WemRHVmtYMnhwYzNRdWJHVnVaM1JvS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWTJGc1kzVnNZWFJsWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qTTRDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2JtVnpkR1ZrWDJ4cGMzUXViR1Z1WjNSb0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE1nb2dJQ0FnWm5KaGJXVmZaR2xuSURFeENpQWdJQ0E4Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lub2dZMkZzWTNWc1lYUmxYMkZtZEdWeVgyWnZja0F4TkFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TXprS0lDQWdJQzh2SUdsdWJtVnlYMnhwYzNRZ1BTQnVaWE4wWldSZmJHbHpkRnRwWFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JoYzNObGNuUWdMeThnU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF4TWdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG8wTUFvZ0lDQWdMeThnYkdGemRGOXBibTVsY2w5c2FYTjBYMmx1WkdWNElEMGdhVzV1WlhKZmJHbHpkQzVzWlc1bmRHZ2dMU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG8wTVFvZ0lDQWdMeThnWm05eUlHb2dhVzRnZFhKaGJtZGxLR2x1Ym1WeVgyeHBjM1F1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtDbU5oYkdOMWJHRjBaVjltYjNKZmFHVmhaR1Z5UURNNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJ4bFpuUnZkbVZ5WDJKeVlXNWphQzV3ZVRvME1Rb2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0dsdWJtVnlYMnhwYzNRdWJHVnVaM1JvS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOd29nSUNBZ1BBb2dJQ0FnWW5vZ1kyRnNZM1ZzWVhSbFgyRm1kR1Z5WDJadmNrQXhNZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZORElLSUNBZ0lDOHZJSFpoYkhWbElEMGdhVzV1WlhKZmJHbHpkRnRxWFFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk5ETUtJQ0FnSUM4dklHbG1JSFpoYkhWbElENDlJSFJvY21WemFHOXNaRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lqNDlDaUFnSUNCbWNtRnRaVjlrYVdjZ01UQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnWm5KaGJXVmZaR2xuSURrS0lDQWdJR1p5WVcxbFgySjFjbmtnT0FvZ0lDQWdZbm9nWTJGc1kzVnNZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZiR1ZtZEc5MlpYSmZZbkpoYm1Ob0xuQjVPalEwQ2lBZ0lDQXZMeUJvWVhOZmJtVjRkQ0E5SUdvZ1BDQnNZWE4wWDJsdWJtVnlYMnhwYzNSZmFXNWtaWGdLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdabkpoYldWZlpHbG5JREV3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEZ0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qUTFDaUFnSUNBdkx5QnBaaUJvWVhOZmJtVjRkRG9LSUNBZ0lHSjZJR05oYkdOMWJHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJHVm1kRzkyWlhKZlluSmhibU5vTG5CNU9qUTJDaUFnSUNBdkx5QjBiM1JoYkNBclBTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ09Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTVDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwyeGxablJ2ZG1WeVgySnlZVzVqYUM1d2VUbzBOd29nSUNBZ0x5OGdibVY0ZEY5MllXeDFaU0E5SUdsdWJtVnlYMnhwYzNSYmFpQXJJREZkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5c1pXWjBiM1psY2w5aWNtRnVZMmd1Y0hrNk5EZ0tJQ0FnSUM4dklHbG1JSFpoYkhWbElEd2dibVY0ZEY5MllXeDFaVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaVBnb2dJQ0FnWm5KaGJXVmZaR2xuSURFd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURZS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnT0FvZ0lDQWdZbm9nWTJGc1kzVnNZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXNaV1owYjNabGNsOWljbUZ1WTJndWNIazZORGtLSUNBZ0lDOHZJSFJ2ZEdGc0lDbzlJRElLSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlzWldaMGIzWmxjbDlpY21GdVkyZ3VjSGs2TlRBS0lDQWdJQzh2SUc1MWJWOWliMjl6ZEhNZ0t6MGdNUW9nSUNBZ1puSmhiV1ZmWkdsbklERXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGdLQ21OaGJHTjFiR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQmlJR05oYkdOMWJHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEa0tDbU5oYkdOMWJHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNCaUlHTmhiR04xYkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURFd0NncGpZV3hqZFd4aGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0JtY21GdFpWOWlkWEo1SURFd0NpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdabkpoYldWZlluVnllU0E1Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG8wTVFvZ0lDQWdMeThnWm05eUlHb2dhVzRnZFhKaGJtZGxLR2x1Ym1WeVgyeHBjM1F1YkdWdVozUm9LVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR05oYkdOMWJHRjBaVjltYjNKZmFHVmhaR1Z5UURNS0NtTmhiR04xYkdGMFpWOWhablJsY2w5bWIzSkFNVEk2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMnhsWm5SdmRtVnlYMkp5WVc1amFDNXdlVG96T0FvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLRzVsYzNSbFpGOXNhWE4wTG14bGJtZDBhQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFeUNpQWdJQ0JpSUdOaGJHTjFiR0YwWlY5bWIzSmZhR1ZoWkdWeVFERUtDbU5oYkdOMWJHRjBaVjloWm5SbGNsOW1iM0pBTVRRNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUlBakViUVFCU2dnTUVyc0pRN3dTOVN5SS9CSVIvZDE4MkdnQ09Bd0FnQUJRQUFpSkRNUmtVUkRFWVJEWWFBVFlhQW9nQXdDTkRNUmtVUkRFWVJJZ0FmU05ETVJrVVJERVlSSWdBR3hhQUJCVWZmSFZNVUxBalF6RVpRUC9GTVJnVVJDTkRJb2tpaVlvQUFZQUFSd0lpaVAvempBSWlqQUNMQUlzQ0RFRUFNNGovNFlzRGpBRkJBQnlJLzllTEE0d0JRUUFTaVAvTml3T01BVUVBQ0lqL3c0c0RDSXdCaXdHTUE0c0FJd2lNQUVML3hZai9ya0gvdDRzRGpBQ0ppZ0FBZ0FBaWlQK2Rpd0dNQUVFQUhJai9rNHNCakFCQkFCS0kvNG1MQVl3QVFRQUlpUDkvaXdFSWpBQ0xBSXdCaVA5elFmL1FpWW9DQUNKSEFvQUFSd1VpU1l2K0lsa2lpd3lMQ3d4SmpBTkJBS2lML2xjQ0FJc0RSSXNNSlF0TEFVeFpTbGtrQ3lVSVdFbU1BU0paU1l3SEl3bU1CU0tNQklzRWl3Y01RUUJ4aXdGWEFnQkpqQUNMQkNRTEpGaEpqQUtMLzZlTENvd0dpd21NQ0VFQVFZc0Vpd1VNaXdxTUJvc0pqQWhCQUM2TENTTUlTWXdKaXdRakNDUUxpd0JNSkZpTEFxV0xDb3dHVEl3SVFRQU1pd2tsQzRzS0l3aU1Cb3dJUWdBQVFnQUFpd2FNQ29zSWpBbUxCQ01JakFSQy80ZUxEQ01JakF4Qy8wMkoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
