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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4HybridAlgo_e8e01ae2
{


    public class Arc4HybridAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4HybridAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task SomeMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 88, 70, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SomeMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 88, 70, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SomeOtherMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 173, 249, 187 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SomeOtherMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 173, 249, 187 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEh5YnJpZEFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic29tZU1ldGhvZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzb21lT3RoZXJNZXRob2QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvNlFYSmpORWg1WW5KcFpFRnNaMjh1WVhCd2NtOTJZV3hRY205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNUW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHeHZaeWduWW1WbWIzSmxKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZbVZtYjNKbElnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCamIyNXpkQ0J5WlhOMWJIUWdQU0J6ZFhCbGNpNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tRb2dJQ0FnWTJGc2JITjFZaUJoY0hCeWIzWmhiRkJ5YjJkeVlXMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHeHZaeWduWVdaMFpYSW5LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhablJsY2lJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGFIbGljbWxrTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzNWc2RBb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TG5OdmJXVk5aWFJvYjJSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpiMjFsVFdWMGFHOWtPZ29nSUNBZ1lpQnpiMjFsVFdWMGFHOWtYMkpzYjJOclFEQUtDbk52YldWTlpYUm9iMlJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJ6YjIxbFRXVjBhRzlrS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxb2VXSnlhV1F1WVd4bmJ5NTBjem82UVhKak5FaDVZbkpwWkVGc1oyOHVjMjl0WlUxbGRHaHZaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YUhsaWNtbGtMbUZzWjI4dWRITTZPa0Z5WXpSSWVXSnlhV1JCYkdkdkxuTnZiV1ZQZEdobGNrMWxkR2h2WkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTnZiV1ZQZEdobGNrMWxkR2h2WkRvS0lDQWdJR0lnYzI5dFpVOTBhR1Z5VFdWMGFHOWtYMkpzYjJOclFEQUtDbk52YldWUGRHaGxjazFsZEdodlpGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklITnZiV1ZQZEdobGNrMWxkR2h2WkNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGFIbGljbWxrTG1Gc1oyOHVkSE02T2tGeVl6UkllV0p5YVdSQmJHZHZMbk52YldWUGRHaGxjazFsZEdodlpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TG5Wd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0JpSUhWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1WDJKc2IyTnJRREFLQ25Wd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxb2VXSnlhV1F1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPanBCY21NMFNIbGljbWxrUVd4bmJ5NTFjR1JoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TG5OdmJXVk5aWFJvYjJRb0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFvZVdKeWFXUXVZV3huYnk1MGN6bzZRWEpqTkVoNVluSnBaRUZzWjI4dWMyOXRaVTFsZEdodlpEb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TG5OdmJXVk5aWFJvYjJSZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TG5OdmJXVk5aWFJvYjJSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXaDVZbkpwWkM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCc2IyY29KM052YldVZ2JXVjBhRzlrSnlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpYzI5dFpTQnRaWFJvYjJRaUNpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXaDVZbkpwWkM1aGJHZHZMblJ6T2pwQmNtTTBTSGxpY21sa1FXeG5ieTV6YjIxbFQzUm9aWEpOWlhSb2IyUW9LU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxb2VXSnlhV1F1WVd4bmJ5NTBjem82UVhKak5FaDVZbkpwWkVGc1oyOHVjMjl0WlU5MGFHVnlUV1YwYUc5a09nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvNlFYSmpORWg1WW5KcFpFRnNaMjh1YzI5dFpVOTBhR1Z5VFdWMGFHOWtYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPanBCY21NMFNIbGljbWxrUVd4bmJ5NXpiMjFsVDNSb1pYSk5aWFJvYjJSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXaDVZbkpwWkM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCc2IyY29KM052YldVZ2IzUm9aWElnYldWMGFHOWtKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWljMjl0WlNCdmRHaGxjaUJ0WlhSb2IyUWlDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qcEJjbU0wU0hsaWNtbGtRV3huYnk1MWNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlncElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qcEJjbU0wU0hsaWNtbGtRV3huYnk1MWNHUmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGFIbGljbWxrTG1Gc1oyOHVkSE02T2tGeVl6UkllV0p5YVdSQmJHZHZMblZ3WkdGMFpVRndjR3hwWTJGMGFXOXVYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPanBCY21NMFNIbGljbWxrUVd4bmJ5NTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHeHZaeWduZFhCa1lYUmxKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkWEJrWVhSbElnb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbUZ3Y0hKdmRtRnNVSEp2WjNKaGJUb0tJQ0FnSUhCeWIzUnZJREFnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmlJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJWOWliRzlqYTBBd0NncGhjSEJ5YjNaaGJGQnliMmR5WVcxZllteHZZMnRBTURvS0lDQWdJR0lnWVhCd2NtOTJZV3hRY205bmNtRnRYMkpzYjJOclFERUtDbUZ3Y0hKdmRtRnNVSEp2WjNKaGJWOWliRzlqYTBBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1kyeGhjM01nUVhKak5FaDVZbkpwWkVGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCaGNIQnliM1poYkZCeWIyZHlZVzFmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV4Q2lBZ0lDQmlJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJWOWhZbWxmY205MWRHbHVaMEF5Q2dwaGNIQnliM1poYkZCeWIyZHlZVzFmWVdKcFgzSnZkWFJwYm1kQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHTnNZWE56SUVGeVl6UkllV0p5YVdSQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORFptTnpZMU16TWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdiV0YwWTJnZ1lYQndjbTkyWVd4UWNtOW5jbUZ0WDNWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRE1LSUNBZ0lHSWdZWEJ3Y205MllXeFFjbTluY21GdFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tZWEJ3Y205MllXeFFjbTluY21GdFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV2g1WW5KcFpDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHTnNZWE56SUVGeVl6UkllV0p5YVdSQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUdGd2NISnZkbUZzVUhKdlozSmhiVjlqY21WaGRHVmZUbTlQY0VBNUNpQWdJQ0JpSUdGd2NISnZkbUZzVUhKdlozSmhiVjlqWVd4c1gwNXZUM0JBTlFvS1lYQndjbTkyWVd4UWNtOW5jbUZ0WDJOaGJHeGZUbTlQY0VBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1kyeGhjM01nUVhKak5FaDVZbkpwWkVGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNalU0TkRZNVpTQXZMeUJ0WlhSb2IyUWdJbk52YldWTlpYUm9iMlFvS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJPV0ZrWmpsaVlpQXZMeUJ0WlhSb2IyUWdJbk52YldWUGRHaGxjazFsZEdodlpDZ3BkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JXRjBZMmdnWVhCd2NtOTJZV3hRY205bmNtRnRYM052YldWTlpYUm9iMlJmY205MWRHVkFOaUJoY0hCeWIzWmhiRkJ5YjJkeVlXMWZjMjl0WlU5MGFHVnlUV1YwYUc5a1gzSnZkWFJsUURjS0lDQWdJR0lnWVhCd2NtOTJZV3hRY205bmNtRnRYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LWVhCd2NtOTJZV3hRY205bmNtRnRYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPRG9LSUNBZ0lHSWdZWEJ3Y205MllXeFFjbTluY21GdFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtRndjSEp2ZG1Gc1VISnZaM0poYlY5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdZaUJoY0hCeWIzWmhiRkJ5YjJkeVlXMWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb0tZWEJ3Y205MllXeFFjbTluY21GdFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCamJHRnpjeUJCY21NMFNIbGljbWxrUVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnWVhCd2NtOTJZV3hRY205bmNtRnRYMkZtZEdWeVgybHViR2x1WldSZmRHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRhSGxpY21sa0xtRnNaMjh1ZEhNNk9rRnlZelJJZVdKeWFXUkJiR2R2TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlFERXpDZ3BoY0hCeWIzWmhiRkJ5YjJkeVlXMWZZV1owWlhKZmFXNXNhVzVsWkY5MFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvNlFYSmpORWg1WW5KcFpFRnNaMjh1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5QU1UTTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnlaWFJ6ZFdJS0NtRndjSEp2ZG1Gc1VISnZaM0poYlY5emIyMWxUM1JvWlhKTlpYUm9iMlJmY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJ6YjIxbFQzUm9aWEpOWlhSb2IyUW9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlITnZiV1ZQZEdobGNrMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQmhjSEJ5YjNaaGJGQnliMmR5WVcxZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxb2VXSnlhV1F1WVd4bmJ5NTBjem82UVhKak5FaDVZbkpwWkVGc1oyOHVYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlBTVRNS0NtRndjSEp2ZG1Gc1VISnZaM0poYlY5emIyMWxUV1YwYUc5a1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2MyOXRaVTFsZEdodlpDZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2MyOXRaVTFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJoY0hCeWIzWmhiRkJ5YjJkeVlXMWZZV1owWlhKZmFXNXNhVzVsWkY5MFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pvNlFYSmpORWg1WW5KcFpFRnNaMjh1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5QU1UTUtDbUZ3Y0hKdmRtRnNVSEp2WjNKaGJWOWpjbVZoZEdWZlRtOVBjRUE1T2dvZ0lDQWdZaUJoY0hCeWIzWmhiRkJ5YjJkeVlXMWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tZWEJ3Y205MllXeFFjbTluY21GdFgzVndaR0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMW9lV0p5YVdRdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2RYQmtZWFJsUVhCd2JHbGpZWFJwYjI0b0tTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaUlHRndjSEp2ZG1Gc1VISnZaM0poYlY5aFpuUmxjbDlwYm14cGJtVmtYM1JsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdoNVluSnBaQzVoYkdkdkxuUnpPanBCY21NMFNIbGljbWxrUVd4bmJ5NWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYMEF4TXdvS1lYQndjbTkyWVd4UWNtOW5jbUZ0WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXaDVZbkpwWkM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSSWVXSnlhV1JCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCaGNIQnliM1poYkZCeWIyZHlZVzFmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFvZVdKeWFXUXVZV3huYnk1MGN6bzZRWEpqTkVoNVluSnBaRUZzWjI4dVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOUFNVE1LQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFvZVdKeWFXUXVZV3huYnk1MGN6bzZRWEpqTkVoNVluSnBaRUZzWjI4dVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFvZVdKeWFXUXVZV3huYnk1MGN6bzZRWEpqTkVoNVluSnBaRUZzWjI4dVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGFIbGljbWxrTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUd4dlp5Z25ZMnhsWVhKcGJtY2djM1JoZEdVbktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKamJHVmhjbWx1WnlCemRHRjBaU0lLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YUhsaWNtbGtMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBjblZsQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRkNBQUNBQm1KbFptOXlaYkNJQUZXQUJXRm1kR1Z5c0VOQ0FBQ0lBQStKUWdBQWlBQWFpVUlBQUlnQUs0bENBQUNBQzNOdmJXVWdiV1YwYUc5a3NJbENBQUNBRVhOdmJXVWdiM1JvWlhJZ2JXVjBhRzlrc0lsQ0FBQ0FCblZ3WkdGMFpiQ0ppZ0FCZ0FCQ0FBQkNBQUF4R3lJVFFRQjRRZ0FBTmhvQWdBUkc5MlV6VHdHT0FRQlNRZ0FBTVJraUVrUXhHQ0lUUVFCQVFnQUFOaG9BZ0FUQ1dFYWVnQVJwcmZtN1R3S09BZ0FkQUJSQ0FBQkNBQUJDQUFBaWpBQkNBQUNMQUU4QmlZai9WeU9NQUVMLzhvai9SeU9NQUVMLzZVTC8zVEVaZ1FRU01SZ2lFeEJFaVA4K0k0d0FRdi9TTVJraUVqRVlJaElRUklnQUJpT01BRUwvdjBJQUFJaz0iLCJjbGVhciI6IkMwSUFBSUFPWTJ4bFlYSnBibWNnYzNSaGRHV3dnUUZEIn0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
