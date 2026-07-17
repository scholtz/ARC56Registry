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

namespace Arc56.Generated.algorandfoundation.puya_ts.BaseWithState_7e1f1d82
{


    public class BaseWithStateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BaseWithStateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task SetState(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 217, 90, 161 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            var result = await base.CallApp(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetState_Transactions(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 217, 90, 161 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            return await base.MakeTransactionList(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFzZVdpdGhTdGF0ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjoxfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p2Ym1WSGJHOWlZV3dpQ2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWWlCdFlXbHVYMmxtWDJKdlpIbEFNUW9LYldGcGJsOXBabDlpYjJSNVFERTZDaUFnSUNCallXeHNjM1ZpSUdOdmJuTjBjblZqZEc5eUNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF6Q2dwdFlXbHVYMkpzYjJOclFETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKaGMyVlhhWFJvVTNSaGRHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTNDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU5Bb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ1lYTmxWMmwwYUZOMFlYUmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNbU5rT1RWaFlURWdMeThnYldWMGFHOWtJQ0p6WlhSVGRHRjBaU2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2JXRjBZMmdnYldGcGJsOXpaWFJUZEdGMFpWOXliM1YwWlVBMUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5qb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWE5sVjJsMGFGTjBZWFJsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM05sZEZOMFlYUmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdjMlYwVTNSaGRHVW9iam9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdjMlYwVTNSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFlLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKaGMyVlhhWFJvVTNSaGRHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPanBDWVhObFYybDBhRk4wWVhSbExuTmxkRk4wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVTNSaGRHVTZDaUFnSUNCaUlITmxkRk4wWVhSbFgySnNiMk5yUURBS0NuTmxkRk4wWVhSbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2MyVjBVM1JoZEdVb2Jqb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9rSmhjMlZYYVhSb1UzUmhkR1V1YzJWMFUzUmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZPa0poYzJWWGFYUm9VM1JoZEdVdWMyVjBVM1JoZEdVb2Jqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZPa0poYzJWWGFYUm9VM1JoZEdVdWMyVjBVM1JoZEdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2MyVjBVM1JoZEdVb2Jqb2dkV2x1ZERZMEtTQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pwQ1lYTmxWMmwwYUZOMFlYUmxMbk5sZEZOMFlYUmxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem82UW1GelpWZHBkR2hUZEdGMFpTNXpaWFJUZEdGMFpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOMFlYUmxMWFJ2ZEdGc2N5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHOXVaVWRzYjJKaGJDQTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NU2tnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05dVpVZHNiMkpoYkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2RHaHBjeTV2Ym1WSGJHOWlZV3d1ZG1Gc2RXVWdQU0J1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnZEhkdlIyeHZZbUZzSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luUjNiMGRzYjJKaGJDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdkR2hwY3k1MGQyOUhiRzlpWVd3dWRtRnNkV1VnUFNCdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9rSmhjMlZYYVhSb1UzUmhkR1V1WDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxPZ29nSUNBZ1lpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTUFvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02T2tKaGMyVlhhWFJvVTNSaGRHVXVZMjl1YzNSeWRXTjBiM0lvS1NBdFBpQjJiMmxrT2dwamIyNXpkSEoxWTNSdmNqb0tJQ0FnSUdJZ1kyOXVjM1J5ZFdOMGIzSmZZbXh2WTJ0QU1Bb0tZMjl1YzNSeWRXTjBiM0pmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FtRnpaVmRwZEdoVGRHRjBaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHSWdZMjl1YzNSeWRXTjBiM0pmWW14dlkydEFNUW9LWTI5dWMzUnlkV04wYjNKZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbUZ6WlZkcGRHaFRkR0YwWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR0lnWTI5dWMzUnlkV04wYjNKZllXWjBaWEpmYVc1c2FXNWxaRjlBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTI5dWMzUnlkV04wYjNKQU1nb0tZMjl1YzNSeWRXTjBiM0pmWVdaMFpYSmZhVzVzYVc1bFpGOUFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMjl1YzNSeWRXTjBiM0pBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCdmJtVkhiRzlpWVd3Z1BTQkhiRzlpWVd4VGRHRjBaU2g3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtERXBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2Ym1WSGJHOWlZV3dpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1BUWx2Ym1WSGJHOWlZV3hDQUFBeEdFQUFDVUlBQUlnQWRFSUFBRUlBQURFYkloTkJBQ2xDQUFBMkdnQ0FCQ3paV3FGUEFZNEJBQWRDQUFCQ0FBQUFNUmtpRWpFWUloTVFSSWdBRWtMLzdERVpJaEl4R0NJU0VFU0lBQzBqUTBJQUFEWWFBVWtWZ1FnU1JCZUlBQUlqUTRvQkFFSUFBQ2lMLzJlQUNYUjNiMGRzYjJKaGJJdi9aNGxDQUFDSlFnQUFRZ0FBUWdBQUtDTm5pUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
