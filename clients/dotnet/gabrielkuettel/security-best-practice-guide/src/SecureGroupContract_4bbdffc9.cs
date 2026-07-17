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

namespace Arc56.Generated.gabrielkuettel.security_best_practice_guide.SecureGroupContract_4bbdffc9
{


    public class SecureGroupContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SecureGroupContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="payment"> </param>
        public async Task BuyCredit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 238, 117, 81, 215 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyCredit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 238, 117, 81, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2VjdXJlR3JvdXBDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlDcmVkaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBheW1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6Ik11c3QgcGF5IGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKamNtVmthWFJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMemN0WjNKdmRYQXRkSEpoYm5OaFkzUnBiMjR0YzJWamRYSnBkSGt2WjNKdmRYQXRkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UyVmpkWEpsUjNKdmRYQkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobFpUYzFOVEZrTnlBdkx5QnRaWFJvYjJRZ0ltSjFlVU55WldScGRDaHdZWGtwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0oxZVVOeVpXUnBkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZOeTFuY205MWNDMTBjbUZ1YzJGamRHbHZiaTF6WldOMWNtbDBlUzluY205MWNDMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVFpXTjFjbVZIY205MWNFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFOZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TnkxbmNtOTFjQzEwY21GdWMyRmpkR2x2YmkxelpXTjFjbWwwZVM5bmNtOTFjQzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhCMVlteHBZeUIwYjNSaGJFTnlaV1JwZEhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQWlZM0psWkdsMGN5SWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqY21Wa2FYUnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6Y3RaM0p2ZFhBdGRISmhibk5oWTNScGIyNHRjMlZqZFhKcGRIa3ZaM0p2ZFhBdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNRM0psWkdsMGN5NTJZV3gxWlNBOUlEQTdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4M0xXZHliM1Z3TFhSeVlXNXpZV04wYVc5dUxYTmxZM1Z5YVhSNUwyZHliM1Z3TFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODNMV2R5YjNWd0xYUnlZVzV6WVdOMGFXOXVMWE5sWTNWeWFYUjVMMmR5YjNWd0xYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzZVMlZqZFhKbFIzSnZkWEJEYjI1MGNtRmpkQzVpZFhsRGNtVmthWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYbERjbVZrYVhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TnkxbmNtOTFjQzEwY21GdWMyRmpkR2x2YmkxelpXTjFjbWwwZVM5bmNtOTFjQzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhCMVlteHBZeUJpZFhsRGNtVmthWFFvY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgzTFdkeWIzVndMWFJ5WVc1ellXTjBhVzl1TFhObFkzVnlhWFI1TDJkeWIzVndMWFpoYkdsa1lYUnBiMjR1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODNMV2R5YjNWd0xYUnlZVzV6WVdOMGFXOXVMWE5sWTNWeWFYUjVMMmR5YjNWd0xYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6bzBNaTAwTlFvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSWsxMWMzUWdjR0Y1SUdGd2NDSXNDaUFnSUNBdkx5QXBPd29nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnY0dGNUlHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6Y3RaM0p2ZFhBdGRISmhibk5oWTNScGIyNHRjMlZqZFhKcGRIa3ZaM0p2ZFhBdGRtRnNhV1JoZEdsdmJpNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1aGJXOTFiblFnUGowZ1ZXbHVkRFkwS0RGZk1EQXdYekF3TUNrc0lDSkpibk4xWm1acFkybGxiblFnY0dGNWJXVnVkQ0lwT3dvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBZ0x5OGdNVEF3TURBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ2NHRjViV1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMemN0WjNKdmRYQXRkSEpoYm5OaFkzUnBiMjR0YzJWamRYSnBkSGt2WjNKdmRYQXRkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUTNKbFpHbDBjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hEY21Wa2FYUnpMblpoYkhWbElDc2dWV2x1ZERZMEtERXBPd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4M0xXZHliM1Z3TFhSeVlXNXpZV04wYVc5dUxYTmxZM1Z5YVhSNUwyZHliM1Z3TFhaaGJHbGtZWFJwYjI0dVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNRM0psWkdsMGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ0pqY21Wa2FYUnpJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OeVpXUnBkSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZOeTFuY205MWNDMTBjbUZ1YzJGamRHbHZiaTF6WldOMWNtbDBlUzluY205MWNDMTJZV3hwWkdGMGFXOXVMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hEY21Wa2FYUnpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRU55WldScGRITXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01TazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODNMV2R5YjNWd0xYUnlZVzV6WVdOMGFXOXVMWE5sWTNWeWFYUjVMMmR5YjNWd0xYWmhiR2xrWVhScGIyNHVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnZkR0ZzUTNKbFpHbDBjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNKamNtVmthWFJ6SWlCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV1JwZEhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TnkxbmNtOTFjQzEwY21GdWMyRmpkR2x2YmkxelpXTjFjbWwwZVM5bmNtOTFjQzEyWVd4cFpHRjBhVzl1TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RGNtVmthWFJ6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVOeVpXUnBkSE11ZG1Gc2RXVWdLeUJWYVc1ME5qUW9NU2s3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMemN0WjNKdmRYQXRkSEpoYm5OaFkzUnBiMjR0YzJWamRYSnBkSGt2WjNKdmRYQXRkbUZzYVdSaGRHbHZiaTVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZblY1UTNKbFpHbDBLSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUFtQVFkamNtVmthWFJ6TVJrVVJERVlRUUFPZ0FUdWRWSFhOaG9BamdFQUZBQ0FCTGhFZXpZMkdnQ09BUUFCQUNnalp5SkRNUllpQ1VrNEVDSVNSRWs0QnpJS0VrUTRDSUhBaEQwUFJDTW9aVVFpQ0NoTVp5SkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
