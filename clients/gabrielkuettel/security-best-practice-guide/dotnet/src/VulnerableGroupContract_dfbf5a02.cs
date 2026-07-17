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

namespace Arc56.Generated.gabrielkuettel.security_best_practice_guide.VulnerableGroupContract_dfbf5a02
{


    public class VulnerableGroupContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VulnerableGroupContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
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
        ///
        ///</summary>
        public async Task BuyCredit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 229, 69, 111 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyCredit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 229, 69, 111 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVnVsbmVyYWJsZUdyb3VwQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5Q3JlZGl0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHBheSBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmpjbVZrYVhSeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpjdFozSnZkWEF0ZEhKaGJuTmhZM1JwYjI0dGMyVmpkWEpwZEhrdlozSnZkWEF0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWblZzYm1WeVlXSnNaVWR5YjNWd1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRkbE5UUTFObVlnTHk4Z2JXVjBhRzlrSUNKaWRYbERjbVZrYVhRb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWRYbERjbVZrYVhRS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpjdFozSnZkWEF0ZEhKaGJuTmhZM1JwYjI0dGMyVmpkWEpwZEhrdlozSnZkWEF0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWblZzYm1WeVlXSnNaVWR5YjNWd1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQTJDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgzTFdkeWIzVndMWFJ5WVc1ellXTjBhVzl1TFhObFkzVnlhWFI1TDJkeWIzVndMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1EzSmxaR2wwY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDSmpjbVZrYVhSeklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU55WldScGRITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk55MW5jbTkxY0MxMGNtRnVjMkZqZEdsdmJpMXpaV04xY21sMGVTOW5jbTkxY0MxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeERjbVZrYVhSekxuWmhiSFZsSUQwZ01Ec0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpjdFozSnZkWEF0ZEhKaGJuTmhZM1JwYjI0dGMyVmpkWEpwZEhrdlozSnZkWEF0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6Y3RaM0p2ZFhBdGRISmhibk5oWTNScGIyNHRjMlZqZFhKcGRIa3ZaM0p2ZFhBdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qcFdkV3h1WlhKaFlteGxSM0p2ZFhCRGIyNTBjbUZqZEM1aWRYbERjbVZrYVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlkWGxEY21Wa2FYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk55MW5jbTkxY0MxMGNtRnVjMkZqZEdsdmJpMXpaV04xY21sMGVTOW5jbTkxY0MxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHTnZibk4wSUhCaGVXMWxiblFnUFNCbmRIaHVMbEJoZVcxbGJuUlVlRzRvVldsdWREWTBLREFwS1RzZ0x5OGdRV3gzWVhseklISmxZV1J6SUdsdVpHVjRJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4M0xXZHliM1Z3TFhSeVlXNXpZV04wYVc5dUxYTmxZM1Z5YVhSNUwyZHliM1Z3TFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TnkxbmNtOTFjQzEwY21GdWMyRmpkR2x2YmkxelpXTjFjbWwwZVM5bmNtOTFjQzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TWpJdE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDSk5kWE4wSUhCaGVTQmhjSEFpTEFvZ0lDQWdMeThnS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElIQmhlU0JoY0hBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgzTFdkeWIzVndMWFJ5WVc1ellXTjBhVzl1TFhObFkzVnlhWFI1TDJkeWIzVndMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVOeVpXUnBkSE11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUTNKbFpHbDBjeTUyWVd4MVpTQXJJRlZwYm5RMk5DZ3hLVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk55MW5jbTkxY0MxMGNtRnVjMkZqZEdsdmJpMXpaV04xY21sMGVTOW5jbTkxY0MxMllXeHBaR0YwYVc5dUxtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRU55WldScGRITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFpWTNKbFpHbDBjeUlnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamNtVmthWFJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMemN0WjNKdmRYQXRkSEpoYm5OaFkzUnBiMjR0YzJWamRYSnBkSGt2WjNKdmRYQXRkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUTNKbFpHbDBjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hEY21Wa2FYUnpMblpoYkhWbElDc2dWV2x1ZERZMEtERXBPd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZOeTFuY205MWNDMTBjbUZ1YzJGamRHbHZiaTF6WldOMWNtbDBlUzluY205MWNDMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkVOeVpXUnBkSE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBaVkzSmxaR2wwY3lJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpjbVZrYVhSeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpjdFozSnZkWEF0ZEhKaGJuTmhZM1JwYjI0dGMyVmpkWEpwZEhrdlozSnZkWEF0ZG1Gc2FXUmhkR2x2Ymk1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1EzSmxaR2wwY3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4RGNtVmthWFJ6TG5aaGJIVmxJQ3NnVldsdWREWTBLREVwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgzTFdkeWIzVndMWFJ5WVc1ellXTjBhVzl1TFhObFkzVnlhWFI1TDJkeWIzVndMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnY0hWaWJHbGpJR0oxZVVOeVpXUnBkQ2dwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUFRZGpjbVZrYVhSek1Sa1VSREVZUVFBT2dBUlg1VVZ2TmhvQWpnRUFGQUNBQkxoRWV6WTJHZ0NPQVFBQkFDZ2laeU5ESWpnUUl4SkVJamdITWdvU1JDSW9aVVFqQ0NoTVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
