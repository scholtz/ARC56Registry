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

namespace Arc56.Generated.algorandfoundation.algokit_utils_ts.ExampleARC4Contract_7ba2a22e
{


    public class ExampleARC4ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ExampleARC4ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXhhbXBsZUFSQzRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOltdLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNV0sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyBkZWxldGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNV0sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyB1cGRhdGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRlJOVUV4ZlJFVk1SVlJCUWt4RklGUk5VRXhmVlZCRVFWUkJRa3hGQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z1kyeGhjM01nUlhoaGJYQnNaVUZTUXpSRGIyNTBjbUZqZENoSmJXMTFkR0ZpYVd4cGRIbERiMjUwY205c1FWSkRORU52Ym5SeVlXTjBMQ0JRWlhKdFlXNWxibU5sUTI5dWRISnZiRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQybDBZMmdnYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMElHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNElHMWhhVzVmZFhCa1lYUmxRRFVnYldGcGJsOWtaV3hsZEdWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z1kyeGhjM01nUlhoaGJYQnNaVUZTUXpSRGIyNTBjbUZqZENoSmJXMTFkR0ZpYVd4cGRIbERiMjUwY205c1FWSkRORU52Ym5SeVlXTjBMQ0JRWlhKdFlXNWxibU5sUTI5dWRISnZiRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JsY25JS0NtMWhhVzVmWkdWc1pYUmxRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCaGMzTmxjblFnVkdWdGNHeGhkR1ZXWVhKYlltOXZiRjBvUkVWTVJWUkJRa3hGWDFSRlRWQk1RVlJGWDA1QlRVVXBMQ0FpUTJobFkyc2dZWEJ3SUdseklHUmxiR1YwWVdKc1pTSUtJQ0FnSUdsdWRHTmZNU0F2THlCVVRWQk1YMFJGVEVWVVFVSk1SUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9aV05ySUdGd2NDQnBjeUJrWld4bGRHRmliR1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCVVpXMXdiR0YwWlZaaGNsdGliMjlzWFNoVlVFUkJWRUZDVEVWZlZFVk5VRXhCVkVWZlRrRk5SU2tzSUNKRGFHVmpheUJoY0hBZ2FYTWdkWEJrWVhSaFlteGxJZ29nSUNBZ2FXNTBZMTh5SUM4dklGUk5VRXhmVlZCRVFWUkJRa3hGQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhsWTJzZ1lYQndJR2x6SUhWd1pHRjBZV0pzWlFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklITmxiR1l1WVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvYjNKcGVtVmZZM0psWVhSdmNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURRNkNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVFtRnpaVUZTUXpSRGIyNTBjbUZqZEM1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncElDMCtJSFp2YVdRNkNtRjFkR2h2Y21sNlpWOWpjbVZoZEc5eU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0oxYm1GMWRHaHZjbWw2WldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RXNWhkWFJvYjNKcGVtVmtDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUFNUnNVUkRFWmpRWUFGUUFBQUFBQUFBQUxBQUVBTVJoRUkwU0lBQkFpUXpFWVJDUkVpQUFHSWtNeEdCUkRNUUF5Q1JKRWlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo1LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJERUxFVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfSwiVVBEQVRBQkxFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
