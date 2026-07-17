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

namespace Arc56.Generated.algorandfoundation.puya_ts.LoggedErrorsValidContract_4cabfea1
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VkRXJyb3JzVmFsaWRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VmFsaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI2XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjA0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyXSwiZXJyb3JNZXNzYWdlIjoiQUVSOjA1OmFyZyBpcyA1IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0XSwiZXJyb3JNZXNzYWdlIjoiQUVSOjEwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxXSwiZXJyb3JNZXNzYWdlIjoiQUVSOjExOmFyZyBpcyAxMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOjAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDldLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDM6YXJnIGlzIDMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDY6YXJnIGlzIDYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTFdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzddLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDk6YXJnIGlzIDkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MTI6YXJnIGlzIDEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR05zWVhOeklFeHZaMmRsWkVWeWNtOXljMVpoYkdsa1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFOUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVFE1T1RReU5EVWdMeThnYldWMGFHOWtJQ0owWlhOMFZtRnNhV1FvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUldZV3hwWkY5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEZaaGJHbGtYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEIxWW14cFl5QjBaWE4wVm1Gc2FXUW9ZWEpuT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUhSbGMzUldZV3hwWkFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMmRuWldRdFpYSnliM0p6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWTJ4aGMzTWdURzluWjJWa1JYSnliM0p6Vm1Gc2FXUkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6bzZURzluWjJWa1JYSnliM0p6Vm1Gc2FXUkRiMjUwY21GamRDNTBaWE4wVm1Gc2FXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFZtRnNhV1E2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUhCMVlteHBZeUIwWlhOMFZtRnNhV1FvWVhKbk9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbklDRTlQU0F4TENBbk1ERW5LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNFOUNpQWdJQ0JpYm5vZ2RHVnpkRlpoYkdsa1gyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpvd01TSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpvd01Rb0tkR1Z6ZEZaaGJHbGtYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbklDRTlQU0F5TENBbk1ESW5MQ0I3ZlNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBaFBRb2dJQ0FnWW01NklIUmxjM1JXWVd4cFpGOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNk1ESWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNk1ESUtDblJsYzNSV1lXeHBaRjloWm5SbGNsOWhjM05sY25SQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVp5QWhQVDBnTXl3Z0p6QXpKeXdnZXlCdFpYTnpZV2RsT2lBbllYSm5JR2x6SURNbklIMHBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdJVDBLSUNBZ0lHSnVlaUIwWlhOMFZtRnNhV1JmWVdaMFpYSmZZWE56WlhKMFFEY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPakF6T21GeVp5QnBjeUF6SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPakF6T21GeVp5QnBjeUF6Q2dwMFpYTjBWbUZzYVdSZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3k1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhjbWNnSVQwOUlEUXNJQ2N3TkNjc0lIc2djSEpsWm1sNE9pQW5RVVZTSnlCOUtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lDRTlDaUFnSUNCaWJub2dkR1Z6ZEZaaGJHbGtYMkZtZEdWeVgyRnpjMlZ5ZEVBNUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGRlVqb3dOQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVGRlVqb3dOQW9LZEdWemRGWmhiR2xrWDJGbWRHVnlYMkZ6YzJWeWRFQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk11WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHRnlaeUFoUFQwZ05Td2dKekExSnl3Z2V5QnRaWE56WVdkbE9pQW5ZWEpuSUdseklEVW5MQ0J3Y21WbWFYZzZJQ2RCUlZJbklIMHBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUIwWlhOMFZtRnNhV1JmWVdaMFpYSmZZWE56WlhKMFFERXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRkZVam93TlRwaGNtY2dhWE1nTlNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFRkZVam93TlRwaGNtY2dhWE1nTlFvS2RHVnpkRlpoYkdsa1gyRm1kR1Z5WDJGemMyVnlkRUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hoY21jZ0lUMDlJRFlzSUNjd05pY3NJQ2RoY21jZ2FYTWdOaWNwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnSVQwS0lDQWdJR0p1ZWlCMFpYTjBWbUZzYVdSZllXWjBaWEpmWVhOelpYSjBRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpvd05qcGhjbWNnYVhNZ05pSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpvd05qcGhjbWNnYVhNZ05nb0tkR1Z6ZEZaaGJHbGtYMkZtZEdWeVgyRnpjMlZ5ZEVBeE16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR2xtSUNoaGNtY2dQVDA5SURjcElIc0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQTlQUW9nSUNBZ1lub2dkR1Z6ZEZaaGJHbGtYMkZtZEdWeVgybG1YMlZzYzJWQU1UVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR3h2WjJkbFpFVnljaWduTURjbktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZNRGNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZNRGNLQ25SbGMzUldZV3hwWkY5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2FXWWdLR0Z5WnlBOVBUMGdPQ2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdKNklIUmxjM1JXWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnNiMmRuWldSRmNuSW9KekE0Snl3Z2UzMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVam93T0NJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVam93T0FvS2RHVnpkRlpoYkdsa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QnBaaUFvWVhKbklEMDlQU0E1S1NCN0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1BUMEtJQ0FnSUdKNklIUmxjM1JXWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURFNUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QnNiMmRuWldSRmNuSW9KekE1Snl3Z2V5QnRaWE56WVdkbE9pQW5ZWEpuSUdseklEa25JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpvd09UcGhjbWNnYVhNZ09TSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpvd09UcGhjbWNnYVhNZ09Rb0tkR1Z6ZEZaaGJHbGtYMkZtZEdWeVgybG1YMlZzYzJWQU1UazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJwWmlBb1lYSm5JRDA5UFNBeE1Da2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0E5UFFvZ0lDQWdZbm9nZEdWemRGWmhiR2xrWDJGbWRHVnlYMmxtWDJWc2MyVkFNakVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMmRuWldRdFpYSnliM0p6TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUd4dloyZGxaRVZ5Y2lnbk1UQW5MQ0I3SUhCeVpXWnBlRG9nSjBGRlVpY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRVVZTT2pFd0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdRVVZTT2pFd0NncDBaWE4wVm1Gc2FXUmZZV1owWlhKZmFXWmZaV3h6WlVBeU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR2xtSUNoaGNtY2dQVDA5SURFeEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRFS0lDQWdJRDA5Q2lBZ0lDQmllaUIwWlhOMFZtRnNhV1JmWVdaMFpYSmZhV1pmWld4elpVQXlNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk11WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnYkc5bloyVmtSWEp5S0NjeE1TY3NJSHNnYldWemMyRm5aVG9nSjJGeVp5QnBjeUF4TVNjc0lIQnlaV1pwZURvZ0owRkZVaWNnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVVWU09qRXhPbUZ5WnlCcGN5QXhNU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVGRlVqb3hNVHBoY21jZ2FYTWdNVEVLQ25SbGMzUldZV3hwWkY5aFpuUmxjbDlwWmw5bGJITmxRREl6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2FXWWdLR0Z5WnlBOVBUMGdNVElwSUhzS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNZ29nSUNBZ1BUMEtJQ0FnSUdKNklIUmxjM1JXWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURJMUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnNiMmRuWldSRmNuSW9KekV5Snl3Z0oyRnlaeUJwY3lBeE1pY3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVam94TWpwaGNtY2dhWE1nTVRJaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2TVRJNllYSm5JR2x6SURFeUNncDBaWE4wVm1Gc2FXUmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JXWVd4cFpDaGhjbWM2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0NBRXhHMEVBR0lBRXBKbENSVFlhQUk0QkFBRUFNUmtVTVJnUVJFSUFDREVaRkRFWUZCQkROaG9CU1JVaUVrUVhTU01UUUFBS2dBWkZVbEk2TURHd0FFbUJBaE5BQUFxQUJrVlNVam93TXJBQVNZRURFMEFBRTRBUFJWSlNPakF6T21GeVp5QnBjeUF6c0FCSmdRUVRRQUFLZ0FaQlJWSTZNRFN3QUVtQkJSTkFBQk9BRDBGRlVqb3dOVHBoY21jZ2FYTWdOYkFBU1lFR0UwQUFFNEFQUlZKU09qQTJPbUZ5WnlCcGN5QTJzQUJKZ1FjU1FRQUtnQVpGVWxJNk1EZXdBRWtpRWtFQUNvQUdSVkpTT2pBNHNBQkpnUWtTUVFBVGdBOUZVbEk2TURrNllYSm5JR2x6SURtd0FFbUJDaEpCQUFxQUJrRkZVam94TUxBQVNZRUxFa0VBRklBUVFVVlNPakV4T21GeVp5QnBjeUF4TWJBQVNZRU1Fa0VBRklBUVJWSlNPakV5T21GeVp5QnBjeUF4TXJBQUkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
