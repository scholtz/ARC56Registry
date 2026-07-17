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

namespace Arc56.Generated.algorandfoundation.puya_ts.LoggedErrorsValidContract_d6c273da
{


    public class LoggedErrorsValidContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoggedErrorsValidContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestValid(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 153, 66, 69 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestValid_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 153, 66, 69 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VkRXJyb3JzVmFsaWRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VmFsaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE5XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjA0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ1XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjA1OmFyZyBpcyA1IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjEwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjExOmFyZyBpcyAxMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjoiRVJSOjAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDM6YXJnIGlzIDMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzFdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDY6YXJnIGlzIDYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDk6YXJnIGlzIDkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDFdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MTI6YXJnIGlzIDEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1RHOW5aMlZrUlhKeWIzSnpWbUZzYVdSRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhORGs1TkRJME5TQXZMeUJ0WlhSb2IyUWdJblJsYzNSV1lXeHBaQ2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGWmhiR2xrWDNKdmRYUmxRRE1LSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wVm1Gc2FXUmZjbTkxZEdWQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JXWVd4cFpDaGhjbWM2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtY2dJVDA5SURFc0lDY3dNU2NwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMkZ6YzJWeWRFQXhNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2TURFaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2TURFS0NtMWhhVzVmWVdaMFpYSmZZWE56WlhKMFFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk11WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5JQ0U5UFNBeUxDQW5NREluTENCN2ZTa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQWhQUW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmWVhOelpYSjBRREV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpvd01pSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpvd01nb0tiV0ZwYmw5aFpuUmxjbDloYzNObGNuUkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhjbWNnSVQwOUlETXNJQ2N3TXljc0lIc2diV1Z6YzJGblpUb2dKMkZ5WnlCcGN5QXpKeUI5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUNFOUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOWhjM05sY25SQU1UUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPakF6T21GeVp5QnBjeUF6SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPakF6T21GeVp5QnBjeUF6Q2dwdFlXbHVYMkZtZEdWeVgyRnpjMlZ5ZEVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVp5QWhQVDBnTkN3Z0p6QTBKeXdnZXlCd2NtVm1hWGc2SUNkQlJWSW5JSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnSVQwS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgyRnpjMlZ5ZEVBeE5nb2dJQ0FnY0hWemFHSjVkR1Z6SUNKQlJWSTZNRFFpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCQlJWSTZNRFFLQ20xaGFXNWZZV1owWlhKZllYTnpaWEowUURFMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVp5QWhQVDBnTlN3Z0p6QTFKeXdnZXlCdFpYTnpZV2RsT2lBbllYSm5JR2x6SURVbkxDQndjbVZtYVhnNklDZEJSVkluSUgwcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMkZ6YzJWeWRFQXhPQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkJSVkk2TURVNllYSm5JR2x6SURVaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkJSVkk2TURVNllYSm5JR2x6SURVS0NtMWhhVzVmWVdaMFpYSmZZWE56WlhKMFFERTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk11WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHRnlaeUFoUFQwZ05pd2dKekEySnl3Z0oyRnlaeUJwY3lBMkp5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQWhQUW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmWVhOelpYSjBRREl3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpvd05qcGhjbWNnYVhNZ05pSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpvd05qcGhjbWNnYVhNZ05nb0tiV0ZwYmw5aFpuUmxjbDloYzNObGNuUkFNakE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCcFppQW9ZWEpuSUQwOVBTQTNLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnUFQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdiRzluWjJWa1JYSnlLQ2N3TnljcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1Vqb3dOeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1Vqb3dOd29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhV1lnS0dGeVp5QTlQVDBnT0NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2JHOW5aMlZrUlhKeUtDY3dPQ2NzSUh0OUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZNRGdpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZNRGdLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR2xtSUNoaGNtY2dQVDA5SURrcElIc0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREkyQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCc2IyZG5aV1JGY25Jb0p6QTVKeXdnZXlCdFpYTnpZV2RsT2lBbllYSm5JR2x6SURrbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVam93T1RwaGNtY2dhWE1nT1NJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVam93T1RwaGNtY2dhWE1nT1FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk11WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnYVdZZ0tHRnlaeUE5UFQwZ01UQXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnUFQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdiRzluWjJWa1JYSnlLQ2N4TUNjc0lIc2djSEpsWm1sNE9pQW5RVVZTSnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKQlJWSTZNVEFpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCQlJWSTZNVEFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR2xtSUNoaGNtY2dQVDA5SURFeEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRFS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHeHZaMmRsWkVWeWNpZ25NVEVuTENCN0lHMWxjM05oWjJVNklDZGhjbWNnYVhNZ01URW5MQ0J3Y21WbWFYZzZJQ2RCUlZJbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRkZVam94TVRwaGNtY2dhWE1nTVRFaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkJSVkk2TVRFNllYSm5JR2x6SURFeENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNekE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCcFppQW9ZWEpuSUQwOVBTQXhNaWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJzYjJkblpXUkZjbklvSnpFeUp5d2dKMkZ5WnlCcGN5QXhNaWNwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpveE1qcGhjbWNnYVhNZ01USWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNk1USTZZWEpuSUdseklERXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBWbUZzYVdRb1lYSm5PaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHTnNZWE56SUV4dloyZGxaRVZ5Y205eWMxWmhiR2xrUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNDQUdBQURFYlFRRWtnQVNrbVVKRk5ob0FqZ0VBQVFBeEdSUXhHQkJFTmhvQlNSVWlFa1FYU1VVQ0l4TkFBQXFBQmtWU1Vqb3dNYkFBU1lFQ0UwQUFDb0FHUlZKU09qQXlzQUJKZ1FNVFFBQVRnQTlGVWxJNk1ETTZZWEpuSUdseklET3dBRW1CQkJOQUFBcUFCa0ZGVWpvd05MQUFTWUVGRTBBQUU0QVBRVVZTT2pBMU9tRnlaeUJwY3lBMXNBQkpnUVlUUUFBVGdBOUZVbEk2TURZNllYSm5JR2x6SURhd0FFbUJCeEpCQUFxQUJrVlNVam93TjdBQVNTSVNRUUFLZ0FaRlVsSTZNRGl3QUVtQkNSSkJBQk9BRDBWU1Vqb3dPVHBoY21jZ2FYTWdPYkFBU1lFS0VrRUFDb0FHUVVWU09qRXdzQUJKZ1FzU1FRQVVnQkJCUlZJNk1URTZZWEpuSUdseklERXhzQUJKZ1F3U1FRQVVnQkJGVWxJNk1USTZZWEpuSUdseklERXlzQUFqUXpFWkZERVlGQkJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
