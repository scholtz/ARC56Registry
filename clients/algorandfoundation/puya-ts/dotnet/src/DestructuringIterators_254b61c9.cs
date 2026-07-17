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

namespace Arc56.Generated.algorandfoundation.puya_ts.DestructuringIterators_254b61c9
{


    public class DestructuringIteratorsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DestructuringIteratorsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVzdHJ1Y3R1cmluZ0l0ZXJhdG9ycyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESUtJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXdDZ3B0WVdsdVgySnNiMk5yUURBNkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Rb0tiV0ZwYmw5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpwYm1jdGFYUmxjbUYwYjNKekxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHTnNZWE56SUVSbGMzUnlkV04wZFhKcGJtZEpkR1Z5WVhSdmNuTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSnBibWN0YVhSbGNtRjBiM0p6TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdOc1lYTnpJRVJsYzNSeWRXTjBkWEpwYm1kSmRHVnlZWFJ2Y25NZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaE56Z3dNREJrWlNBdkx5QnRaWFJvYjJRZ0luUmxjM1FvS1hadmFXUWlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXliM1YwWlVBekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTBDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Eb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEWUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpwYm1jdGFYUmxjbUYwYjNKekxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHTnNZWE56SUVSbGMzUnlkV04wZFhKcGJtZEpkR1Z5WVhSdmNuTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSnBibWN0YVhSbGNtRjBiM0p6TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhSbGMzUW9LU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5YVc1bkxXbDBaWEpoZEc5eWN5NWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmpiR0Z6Y3lCRVpYTjBjblZqZEhWeWFXNW5TWFJsY21GMGIzSnpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmpZV3hzYzNWaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlhVzVuTFdsMFpYSmhkRzl5Y3k1aGJHZHZMblJ6T2pwMFpYTjBYMmx0YlhWMFlXSnNaU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZhVzF0ZFhSaFlteGxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSnBibWN0YVhSbGNtRjBiM0p6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWm5WdVkzUnBiMjRnZEdWemRGOXBiVzExZEdGaWJHVW9LU0I3Q2lBZ0lDQndjbTkwYnlBd0lEQUtJQ0FnSUdJZ2RHVnpkRjlwYlcxMWRHRmliR1ZmWW14dlkydEFNQW9LZEdWemRGOXBiVzExZEdGaWJHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeWFXNW5MV2wwWlhKaGRHOXljeTVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUmxjM1J5ZFdOMGRYSnBibWN0YVhSbGNtRjBiM0p6TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnZXlCaE9pQlZhVzUwTmpRb01Ta3NJR0k2SUZWcGJuUTJOQ2d5S1NCOUxBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0lnZEdWemRGOXBiVzExZEdGaWJHVmZabTl5WDJKdlpIbEFNUW9LZEdWemRGOXBiVzExZEdGaWJHVmZabTl5WDJKdlpIbEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtaWE4wY25WamRIVnlhVzVuTFdsMFpYSmhkRzl5Y3k1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElIc2dZU0I5SUc5bUlHbDBaVzF6S1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJsYzNSeWRXTjBkWEpwYm1jdGFYUmxjbUYwYjNKekxtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHRUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSWdkR1Z6ZEY5cGJXMTFkR0ZpYkdWZlptOXlYMlp2YjNSbGNrQXlDZ3AwWlhOMFgybHRiWFYwWVdKc1pWOW1iM0pmWm05dmRHVnlRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbWx1WnkxcGRHVnlZWFJ2Y25NdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQjdJR0VnZlNCdlppQnBkR1Z0Y3lrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zYVhSamFDQjBaWE4wWDJsdGJYVjBZV0pzWlY5bWIzSmZhR1ZoWkdWeVh6RkFNeUIwWlhOMFgybHRiWFYwWVdKc1pWOW1iM0pmYUdWaFpHVnlYekpBTkFvZ0lDQWdZaUIwWlhOMFgybHRiWFYwWVdKc1pWOWhablJsY2w5bWIzSkFOUW9LZEdWemRGOXBiVzExZEdGaWJHVmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbWx1WnkxcGRHVnlZWFJ2Y25NdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSdmRHRnNJRDA5UFNBMktRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2dwMFpYTjBYMmx0YlhWMFlXSnNaVjltYjNKZmFHVmhaR1Z5WHpKQU5Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5YVc1bkxXbDBaWEpoZEc5eWN5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklIc2dZVG9nVldsdWREWTBLRE1wTENCaU9pQlZhVzUwTmpRb01pa2dmU3dLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKcGJtY3RhWFJsY21GMGIzSnpMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZXlCaElIMGdiMllnYVhSbGJYTXBJSHNLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1lpQjBaWE4wWDJsdGJYVjBZV0pzWlY5bWIzSmZZbTlrZVVBeENncDBaWE4wWDJsdGJYVjBZV0pzWlY5bWIzSmZhR1ZoWkdWeVh6RkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeWFXNW5MV2wwWlhKaGRHOXljeTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJSHNnWVRvZ1ZXbHVkRFkwS0RJcExDQmlPaUJWYVc1ME5qUW9NaWtnZlN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaR1Z6ZEhKMVkzUjFjbWx1WnkxcGRHVnlZWFJ2Y25NdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQjdJR0VnZlNCdlppQnBkR1Z0Y3lrZ2V3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUhSbGMzUmZhVzF0ZFhSaFlteGxYMlp2Y2w5aWIyUjVRREVLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtbHVaeTFwZEdWeVlYUnZjbk11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21sdVowbDBaWEpoZEc5eWN5NTBaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRG9LSUNBZ0lHSWdkR1Z6ZEY5aWJHOWphMEF3Q2dwMFpYTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtbHVaeTFwZEdWeVlYUnZjbk11WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnZEdWemRDZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSbGMzUnlkV04wZFhKcGJtY3RhWFJsY21GMGIzSnpMbUZzWjI4dWRITTZPa1JsYzNSeWRXTjBkWEpwYm1kSmRHVnlZWFJ2Y25NdWRHVnpkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeWFXNW5MV2wwWlhKaGRHOXljeTVoYkdkdkxuUnpPanBFWlhOMGNuVmpkSFZ5YVc1blNYUmxjbUYwYjNKekxuUmxjM1FvS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WkdWemRISjFZM1IxY21sdVp5MXBkR1Z5WVhSdmNuTXVZV3huYnk1MGN6bzZSR1Z6ZEhKMVkzUjFjbWx1WjBsMFpYSmhkRzl5Y3k1MFpYTjBPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtbHVaeTFwZEdWeVlYUnZjbk11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21sdVowbDBaWEpoZEc5eWN5NTBaWE4wWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrWlhOMGNuVmpkSFZ5YVc1bkxXbDBaWEpoZEc5eWN5NWhiR2R2TG5Sek9qcEVaWE4wY25WamRIVnlhVzVuU1hSbGNtRjBiM0p6TG5SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a1pYTjBjblZqZEhWeWFXNW5MV2wwWlhKaGRHOXljeTVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUIwWlhOMFgybHRiWFYwWVdKc1pTZ3BDaUFnSUNCallXeHNjM1ZpSUhSbGMzUmZhVzF0ZFhSaFlteGxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHVnpkSEoxWTNSMWNtbHVaeTFwZEdWeVlYUnZjbk11WVd4bmJ5NTBjem82UkdWemRISjFZM1IxY21sdVowbDBaWEpoZEc5eWN5NWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFQ1FnQUFRZ0FBTVJzaUUwRUFLVUlBQURZYUFJQUVwNEFBM2s4QmpnRUFCMElBQUVJQUFBQXhHU0lTTVJnaUV4QkVpQUJOUXYvc01Sa2lFakVZSWhJUVJJZ0FUQ05EaWdBQVFnQUFJaUlqUWdBQWl3S0xBQWlNQUVJQUFJc0JqUUlBRkFBS1FnQUFpd0NCQmhKRWlTU01BWUVEakFKQy85b2pqQUVrakFKQy85RkNBQUNJQUFJalEwSUFBSWovdDRsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
