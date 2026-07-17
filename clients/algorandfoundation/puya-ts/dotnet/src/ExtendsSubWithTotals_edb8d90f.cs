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

namespace Arc56.Generated.algorandfoundation.puya_ts.ExtendsSubWithTotals_edb8d90f
{


    public class ExtendsSubWithTotalsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ExtendsSubWithTotalsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXh0ZW5kc1N1YldpdGhUb3RhbHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnZibVZIYkc5aVlXd2lDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZaUJ0WVdsdVgybG1YMkp2WkhsQU1Rb0tiV0ZwYmw5cFpsOWliMlI1UURFNkNpQWdJQ0JqWVd4c2MzVmlJR052Ym5OMGNuVmpkRzl5Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXpDZ3B0WVdsdVgySnNiMk5yUURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk1qY3RNamdLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUhOMFlYUmxWRzkwWVd4ek9pQjdmU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVjRkR1Z1WkhOVGRXSlhhWFJvVkc5MFlXeHpJR1Y0ZEdWdVpITWdVM1ZpUTJ4aGMzTlhhWFJvUlhod2JHbGphWFJVYjNSaGJITWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFOd29nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFEUUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem95TnkweU9Bb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUh0OUlIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhoMFpXNWtjMU4xWWxkcGRHaFViM1JoYkhNZ1pYaDBaVzVrY3lCVGRXSkRiR0Z6YzFkcGRHaEZlSEJzYVdOcGRGUnZkR0ZzY3lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVkyUTVOV0ZoTVNBdkx5QnRaWFJvYjJRZ0luTmxkRk4wWVhSbEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J0WVhSamFDQnRZV2x1WDNObGRGTjBZWFJsWDNKdmRYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURZS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZNamN0TWpnS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3ZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVY0ZEdWdVpITlRkV0pYYVhSb1ZHOTBZV3h6SUdWNGRHVnVaSE1nVTNWaVEyeGhjM05YYVhSb1JYaHdiR2xqYVhSVWIzUmhiSE1nZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM05sZEZOMFlYUmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RQY0hSSmJpY2dmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUJQY0hSSmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdjMlYwVTNSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFlLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZNamN0TWpnS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3ZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVY0ZEdWdVpITlRkV0pYYVhSb1ZHOTBZV3h6SUdWNGRHVnVaSE1nVTNWaVEyeGhjM05YYVhSb1JYaHdiR2xqYVhSVWIzUmhiSE1nZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pvNlJYaDBaVzVrYzFOMVlsZHBkR2hVYjNSaGJITXVjMlYwVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSVGRHRjBaVG9LSUNBZ0lHSWdjMlYwVTNSaGRHVmZZbXh2WTJ0QU1Bb0tjMlYwVTNSaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMDl3ZEVsdUp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOMFlYUmxMWFJ2ZEdGc2N5NWhiR2R2TG5Sek9qcEZlSFJsYm1SelUzVmlWMmwwYUZSdmRHRnNjeTV6WlhSVGRHRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzZSWGgwWlc1a2MxTjFZbGRwZEdoVWIzUmhiSE11YzJWMFUzUmhkR1VvYmpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9rVjRkR1Z1WkhOVGRXSlhhWFJvVkc5MFlXeHpMbk5sZEZOMFlYUmxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPak14TFRNeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblQzQjBTVzRuSUgwcENpQWdJQ0F2THlCelpYUlRkR0YwWlNodU9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02T2tWNGRHVnVaSE5UZFdKWGFYUm9WRzkwWVd4ekxuTmxkRk4wWVhSbFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzZSWGgwWlc1a2MxTjFZbGRwZEdoVWIzUmhiSE11YzJWMFUzUmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnYzNWd1pYSXVjMlYwVTNSaGRHVW9iaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9rSmhjMlZYYVhSb1UzUmhkR1V1YzJWMFUzUmhkR1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEdocGN5NXZibVZNYjJOaGJDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdiMjVsVEc5allXd2dQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p2Ym1WTWIyTmhiQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEdocGN5NXZibVZNYjJOaGJDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPanBDWVhObFYybDBhRk4wWVhSbExuTmxkRk4wWVhSbEtHNDZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPanBDWVhObFYybDBhRk4wWVhSbExuTmxkRk4wWVhSbE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOMFlYUmxMWFJ2ZEdGc2N5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklITmxkRk4wWVhSbEtHNDZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pvNlFtRnpaVmRwZEdoVGRHRjBaUzV6WlhSVGRHRjBaVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02T2tKaGMyVlhhWFJvVTNSaGRHVXVjMlYwVTNSaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QnZibVZIYkc5aVlXd2dQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREVwSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmJtVkhiRzlpWVd3aUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklIUm9hWE11YjI1bFIyeHZZbUZzTG5aaGJIVmxJRDBnYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhSM2IwZHNiMkpoYkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSjBkMjlIYkc5aVlXd2lDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSFJvYVhNdWRIZHZSMnh2WW1Gc0xuWmhiSFZsSUQwZ2Jnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOMFlYUmxMWFJ2ZEdGc2N5NWhiR2R2TG5Sek9qcEZlSFJsYm1SelUzVmlWMmwwYUZSdmRHRnNjeTVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem82UW1GelpWZHBkR2hUZEdGMFpTNWpiMjV6ZEhKMVkzUnZjaWdwSUMwK0lIWnZhV1E2Q21OdmJuTjBjblZqZEc5eU9nb2dJQ0FnWWlCamIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd0NncGpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ1lYTmxWMmwwYUZOMFlYUmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1lpQmpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXhDZ3BqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWE5sVjJsMGFGTjBZWFJsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdZaUJqYjI1emRISjFZM1J2Y2w5aFpuUmxjbDlwYm14cGJtVmtYMEJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYjI1emRISjFZM1J2Y2tBeUNncGpiMjV6ZEhKMVkzUnZjbDloWm5SbGNsOXBibXhwYm1Wa1gwQmhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZZV3huYjNKaGJtUXRkSGx3WlhOamNtbHdkQzlpWVhObExXTnZiblJ5WVdOMExtUXVkSE02T2tKaGMyVkRiMjUwY21GamRDNWpiMjV6ZEhKMVkzUnZja0F5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUc5dVpVZHNiMkpoYkNBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Ta2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTl1WlVkc2IySmhiQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1BUWx2Ym1WSGJHOWlZV3hDQUFBeEdFQUFDVUlBQUlnQWowSUFBRUlBQURFYkloTkJBQ2xDQUFBMkdnQ0FCQ3paV3FGUEFZNEJBQWRDQUFCQ0FBQUFNUmtqRWpFWUloTVFSSWdBRWtMLzdERVpJaEl4R0NJU0VFU0lBRWdqUTBJQUFEWWFBVWtWZ1FnU1JCZUlBQUlqUTRvQkFFSUFBSXYvaUFBUU1RQ0FDRzl1WlV4dlkyRnNpLzltaVlvQkFFSUFBQ2lMLzJlQUNYUjNiMGRzYjJKaGJJdi9aNGxDQUFDSlFnQUFRZ0FBUWdBQUtDTm5pUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
