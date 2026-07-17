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

namespace Arc56.Generated.algorandfoundation.puya_ts.VerifierContract_2414a41b
{


    public class VerifierContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VerifierContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Verify(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 169, 174, 204 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 169, 174, 204 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmVyaWZpZXJDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTBdLCJlcnJvck1lc3NhZ2UiOiJUeG4gbXVzdCBiZSBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlwZEhodUxXTnZiWEJ2YzJVdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1kyeGhjM01nVm1WeWFXWnBaWEpEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZhWFI0YmkxamIyMXdiM05sTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUdOc1lYTnpJRlpsY21sbWFXVnlRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJOV0U1WVdWall5QXZMeUJ0WlhSb2IyUWdJblpsY21sbWVTZ3BkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2JXRjBZMmdnYldGcGJsOTJaWEpwWm5sZmNtOTFkR1ZBTXdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURRNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMkNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXBkSGh1TFdOdmJYQnZjMlV1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTJ4aGMzTWdWbVZ5YVdacFpYSkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdWeWNnb0tiV0ZwYmw5MlpYSnBabmxmY205MWRHVkFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXBkSGh1TFdOdmJYQnZjMlV1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnZG1WeWFXWjVLQ2tnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJSFpsY21sbWVRb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGRIaHVMV052YlhCdmMyVXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZtVnlhV1pwWlhKRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YVhSNGJpMWpiMjF3YjNObExtRnNaMjh1ZEhNNk9sWmxjbWxtYVdWeVEyOXVkSEpoWTNRdWRtVnlhV1o1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1T2dvZ0lDQWdZaUIyWlhKcFpubGZZbXh2WTJ0QU1Bb0tkbVZ5YVdaNVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YVhSNGJpMWpiMjF3YjNObExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIWmxjbWxtZVNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmwwZUc0dFkyOXRjRzl6WlM1aGJHZHZMblJ6T2pwV1pYSnBabWxsY2tOdmJuUnlZV04wTG5abGNtbG1lUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGRIaHVMV052YlhCdmMyVXVZV3huYnk1MGN6bzZWbVZ5YVdacFpYSkRiMjUwY21GamRDNTJaWEpwWm5rb0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmFYUjRiaTFqYjIxd2IzTmxMbUZzWjI4dWRITTZPbFpsY21sbWFXVnlRMjl1ZEhKaFkzUXVkbVZ5YVdaNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJsMGVHNHRZMjl0Y0c5elpTNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QjJaWEpwWm5rb0tTQjdDaUFnSUNCd2NtOTBieUF3SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmwwZUc0dFkyOXRjRzl6WlM1aGJHZHZMblJ6T2pwV1pYSnBabWxsY2tOdmJuUnlZV04wTG5abGNtbG1lVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZhWFI0YmkxamIyMXdiM05sTG1Gc1oyOHVkSE02T2xabGNtbG1hV1Z5UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmFYUjRiaTFqYjIxd2IzTmxMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JVZUc0dVozSnZkWEJKYm1SbGVEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZhWFI0YmkxamIyMXdiM05sTG1Gc1oyOHVkSE02T2xabGNtbG1hV1Z5UTI5dWRISmhZM1F1ZG1WeWFXWjVYM2RvYVd4bFgzUnZjRUF4Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YVhSNGJpMWpiMjF3YjNObExtRnNaMjh1ZEhNNk9sWmxjbWxtYVdWeVEyOXVkSEpoWTNRdWRtVnlhV1o1WDNkb2FXeGxYM1J2Y0VBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJsMGVHNHRZMjl0Y0c5elpTNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dWSGh1TG1keWIzVndTVzVrWlhnN0lHa3JLeWtnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQStDaUFnSUNCaWVpQjBaWE4wY3k5aGNIQnliM1poYkhNdmFYUjRiaTFqYjIxd2IzTmxMbUZzWjI4dWRITTZPbFpsY21sbWFXVnlRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgyRm1kR1Z5WDNkb2FXeGxRRE1LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybDBlRzR0WTI5dGNHOXpaUzVoYkdkdkxuUnpPanBXWlhKcFptbGxja052Ym5SeVlXTjBMblpsY21sbWVWOTNhR2xzWlY5aWIyUjVRRElLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlwZEhodUxXTnZiWEJ2YzJVdVlXeG5ieTUwY3pvNlZtVnlhV1pwWlhKRGIyNTBjbUZqZEM1MlpYSnBabmxmZDJocGJHVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJsMGVHNHRZMjl0Y0c5elpTNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QmpiMjV6ZENCMGVHNGdQU0JuZEhodUxsUnlZVzV6WVdOMGFXOXVLR2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmFYUjRiaTFqYjIxd2IzTmxMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBlRzR1ZEhsd1pTQTlQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMbEJoZVcxbGJuUXNJQ2RVZUc0Z2JYVnpkQ0JpWlNCd1lYa25LUW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZSNGJpQnRkWE4wSUdKbElIQmhlUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybDBlRzR0WTI5dGNHOXpaUzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnVkhodUxtZHliM1Z3U1c1a1pYZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmFYUjRiaTFqYjIxd2IzTmxMbUZzWjI4dWRITTZPbFpsY21sbWFXVnlRMjl1ZEhKaFkzUXVkbVZ5YVdaNVgzZG9hV3hsWDNSdmNFQXhDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZhWFI0YmkxamIyMXdiM05sTG1Gc1oyOHVkSE02T2xabGNtbG1hV1Z5UTI5dWRISmhZM1F1ZG1WeWFXWjVYMkZtZEdWeVgzZG9hV3hsUURNNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YVhSNGJpMWpiMjF3YjNObExtRnNaMjh1ZEhNNk9sWmxjbWxtYVdWeVEyOXVkSEpoWTNRdVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUZDQUFCQ0FBQXhHeUlUUVFBcFFnQUFOaG9BZ0FSbHFhN01Ud0dPQVFBSFFnQUFRZ0FBQURFWkloSXhHQ0lURUVTSUFCSkMvK3d4R1NJU01SZ2lFaEJFaUFBdkkwTkNBQUNJQUFJalE0b0FBRUlBQUNKQ0FBQXhGb3NBRFVFQUVrSUFBSXNBU1RnUUl4SkVJd2lNQUVMLzVvbENBQUNKIiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
