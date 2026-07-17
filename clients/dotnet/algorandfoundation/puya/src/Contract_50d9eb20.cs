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

namespace Arc56.Generated.algorandfoundation.puya.Contract_50d9eb20
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9uZXdfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjNdLCJlcnJvck1lc3NhZ2UiOiJib251cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjoiZmVlIHNpbmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6ImZlZXMgY29sbGVjdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX2VuYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6InBheW91dHNfZ29fb25saW5lX2ZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19tYXhfYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19taW5fYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19wZXJjZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOiJwcm9wb3NlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zZXIgcGF5b3V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOiJwcm90b2NvbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5XSwiZXJyb3JNZXNzYWdlIjoidHhuIGNvdW50ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3Q2lBZ0lDQXZMeUJoZG0xZk1URXZZMjl1ZEhKaFkzUXVjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wTENCaGRtMWZkbVZ5YzJsdmJqMHhNU2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoak1tSTRaR1E0WVNBdkx5QnRaWFJvYjJRZ0luUmxjM1JmYm1WM1gyOXdjeWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRjl1WlhkZmIzQnpYM0p2ZFhSbFFETUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBYMjVsZDE5dmNITmZjbTkxZEdWQU16b0tJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlIUmxjM1JmYm1WM1gyOXdjd29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRjJiVjh4TVM1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1MFpYTjBYMjVsZDE5dmNITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgyNWxkMTl2Y0hNNkNpQWdJQ0F2THlCaGRtMWZNVEV2WTI5dWRISmhZM1F1Y0hrNk55MDRDaUFnSUNBdkx5QWpJRzl3SUdaMWJtTjBhVzl1Y3dvZ0lDQWdMeThnWVhOelpYSjBJRzl3TG05dWJHbHVaVjl6ZEdGclpTZ3BDaUFnSUNCdmJteHBibVZmYzNSaGEyVUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFeEwyTnZiblJ5WVdOMExuQjVPamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzV0YVcxaktHOXdMazFwVFVORGIyNW1hV2QxY21GMGFXOXVjeTVDVGpJMU5FMXdNVEV3TENCdmNDNWllbVZ5Ynlnek1pa3BDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYldsdFl5QkNUakkxTkUxd01URXdDaUFnSUNCd2IzQUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUb3hOaTB4TndvZ0lDQWdMeThnSXlCQ2JHOWphd29nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0J2Y0M1Q2JHOWpheTVpYkd0ZmNISnZjRzl6WlhJb01Da3NJQ0p3Y205d2IzTmxjaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWJHOWpheUJDYkd0UWNtOXdiM05sY2dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWIzQnZjMlZ5Q2lBZ0lDQXZMeUJoZG0xZk1URXZZMjl1ZEhKaFkzUXVjSGs2TVRnS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1Q2JHOWpheTVpYkd0ZlptVmxjMTlqYjJ4c1pXTjBaV1FvTUNrc0lDSm1aV1Z6SUdOdmJHeGxZM1JsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdEdaV1Z6UTI5c2JHVmpkR1ZrQ2lBZ0lDQmhjM05sY25RZ0x5OGdabVZsY3lCamIyeHNaV04wWldRS0lDQWdJQzh2SUdGMmJWOHhNUzlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrSnNiMk5yTG1Kc2ExOWliMjUxY3lnd0tTd2dJbUp2Ym5Weklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0pzYjJOcklFSnNhMEp2Ym5WekNpQWdJQ0JoYzNObGNuUWdMeThnWW05dWRYTUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdZWE56WlhKMElHOXdMa0pzYjJOckxtSnNhMTltWldWZmMybHVheWd3S1N3Z0ltWmxaU0J6YVc1cklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0pzYjJOcklFSnNhMFpsWlZOcGJtc0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm1aV1VnYzJsdWF3b2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRbXh2WTJzdVlteHJYM0J5YjNSdlkyOXNLREFwTENBaWNISnZkRzlqYjJ3aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJVSEp2ZEc5amIyd0tJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWIzUnZZMjlzQ2lBZ0lDQXZMeUJoZG0xZk1URXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1Q2JHOWpheTVpYkd0ZmRIaHVYMk52ZFc1MFpYSW9NQ2tzSUNKMGVHNGdZMjkxYm5SbGNpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RVZUc1RGIzVnVkR1Z5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSGh1SUdOdmRXNTBaWElLSUNBZ0lDOHZJR0YyYlY4eE1TOWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnWVhOelpYSjBJRzl3TGtKc2IyTnJMbUpzYTE5d2NtOXdiM05sY2w5d1lYbHZkWFFvTUNrc0lDSndjbTl3YjNObGNpQndZWGx2ZFhRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJVSEp2Y0c5elpYSlFZWGx2ZFhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmxjaUJ3WVhsdmRYUUtJQ0FnSUM4dklHRjJiVjh4TVM5amIyNTBjbUZqZEM1d2VUb3lOaTB5TndvZ0lDQWdMeThnSXlCSGJHOWlZV3dLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMxOWxibUZpYkdWa0xDQWljR0Y1YjNWMGMxOWxibUZpYkdWa0lnb2dJQ0FnWjJ4dlltRnNJRkJoZVc5MWRITkZibUZpYkdWa0NpQWdJQ0JoYzNObGNuUWdMeThnY0dGNWIzVjBjMTlsYm1GaWJHVmtDaUFnSUNBdkx5QmhkbTFmTVRFdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMxOW5iMTl2Ym14cGJtVmZabVZsTENBaWNHRjViM1YwYzE5bmIxOXZibXhwYm1WZlptVmxJZ29nSUNBZ1oyeHZZbUZzSUZCaGVXOTFkSE5IYjA5dWJHbHVaVVpsWlFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVc5MWRITmZaMjlmYjI1c2FXNWxYMlpsWlFvZ0lDQWdMeThnWVhadFh6RXhMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCaGMzTmxjblFnYjNBdVIyeHZZbUZzTG5CaGVXOTFkSE5mY0dWeVkyVnVkQ3dnSW5CaGVXOTFkSE5mY0dWeVkyVnVkQ0lLSUNBZ0lHZHNiMkpoYkNCUVlYbHZkWFJ6VUdWeVkyVnVkQW9nSUNBZ1lYTnpaWEowSUM4dklIQmhlVzkxZEhOZmNHVnlZMlZ1ZEFvZ0lDQWdMeThnWVhadFh6RXhMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCaGMzTmxjblFnYjNBdVIyeHZZbUZzTG5CaGVXOTFkSE5mYldsdVgySmhiR0Z1WTJVc0lDSndZWGx2ZFhSelgyMXBibDlpWVd4aGJtTmxJZ29nSUNBZ1oyeHZZbUZzSUZCaGVXOTFkSE5OYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YjNWMGMxOXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ0x5OGdZWFp0WHpFeEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1UjJ4dlltRnNMbkJoZVc5MWRITmZiV0Y0WDJKaGJHRnVZMlVzSUNKd1lYbHZkWFJ6WDIxaGVGOWlZV3hoYm1ObElnb2dJQ0FnWjJ4dlltRnNJRkJoZVc5MWRITk5ZWGhDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViM1YwYzE5dFlYaGZZbUZzWVc1alpRb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qTXpMVE0wQ2lBZ0lDQXZMeUFqSUZadmRHVnlJSEJoY21GdGN3b2dJQ0FnTHk4Z1p5d2dhQ0E5SUc5d0xsWnZkR1Z5VUdGeVlXMXpSMlYwTG5admRHVnlYMkpoYkdGdVkyVW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMmIzUmxjbDl3WVhKaGJYTmZaMlYwSUZadmRHVnlRbUZzWVc1alpRb2dJQ0FnY0c5d2JpQXlDaUFnSUNBdkx5QmhkbTFmTVRFdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR2tzSUdvZ1BTQnZjQzVXYjNSbGNsQmhjbUZ0YzBkbGRDNTJiM1JsY2w5cGJtTmxiblJwZG1WZlpXeHBaMmxpYkdVb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IyYjNSbGNsOXdZWEpoYlhOZloyVjBJRlp2ZEdWeVNXNWpaVzUwYVhabFJXeHBaMmxpYkdVS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnTHk4Z1lYWnRYekV4TDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQkFERWJRUUFZZ0FUQ3VOMktOaG9BamdFQUFRQXhHUlF4R0JCRVFnQUlNUmtVTVJnVUVFTjFSSUVncitZQVNDTFJBaklERWtRaTBRTkVJdEVFUkNMUkJqSURFMFFpMFFjVlJDTFJDRVFpMFFsRU1oSkVNaE5FTWhSRU1oVkVNaFpFSW5RQVJnSWlkQUZHQW9FQlF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
