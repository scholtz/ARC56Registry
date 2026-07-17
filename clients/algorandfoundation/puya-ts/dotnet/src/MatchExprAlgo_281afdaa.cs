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

namespace Arc56.Generated.algorandfoundation.puya_ts.MatchExprAlgo_281afdaa
{


    public class MatchExprAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MatchExprAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task TestMatches(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 126, 114, 154 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMatches_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 126, 114, 154 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWF0Y2hFeHByQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TWF0Y2hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjoieCBzaG91bGQgYmUgNSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoieCBzaG91bGQgbm90IGJlIDMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ05TQXdJRFFnTmdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5Qk5ZWFJqYUVWNGNISkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEa3pOMlUzTWpsaElDOHZJRzFsZEdodlpDQWlkR1Z6ZEUxaGRHTm9aWE1vZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUk5ZWFJqYUdWelgzSnZkWFJsUURNS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFRXRjBZMmhsYzE5eWIzVjBaVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEUxaGRHTm9aWE1vZURvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjBaWE4wVFdGMFkyaGxjd29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dFlYUmphQzFsZUhCeUxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nVFdGMFkyaEZlSEJ5UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxaGRHTm9MV1Y0Y0hJdVlXeG5ieTUwY3pvNlRXRjBZMmhGZUhCeVFXeG5ieTUwWlhOMFRXRjBZMmhsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JOWVhSamFHVnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMWhkR05vTFdWNGNISXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QndkV0pzYVdNZ2RHVnpkRTFoZEdOb1pYTW9lRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJqYjI1emRDQjRUMkpxSUQwZ2V5QjRJSDBLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRZWFJqYUMxbGVIQnlMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvZUU5aWFpd2dleUI0T2lBMUlIMHNJQ2Q0SUhOb2IzVnNaQ0JpWlNBMUp5a0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUExQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIZ2djMmh2ZFd4a0lHSmxJRFVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRZWFJqYUMxbGVIQnlMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvZUU5aWFpd2dleUI0T2lCN0lHNXZkRG9nTXlCOUlIMHNJQ2Q0SUhOb2IzVnNaQ0J1YjNRZ1ltVWdNeWNwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUI0SUhOb2IzVnNaQ0J1YjNRZ1ltVWdNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMWhkR05vTFdWNGNISXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hVZUc0c0lIc2djMlZ1WkdWeU9pQjdJRzV2ZERvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOeklIMGdmU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXRjBZMmd0Wlhod2NpNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QmhjM05sY25Rb2JXRjBZMmdvZUU5aWFpd2dleUI0T2lCN0lHZHlaV0YwWlhKVWFHRnVPaUEwSUgwZ2ZTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBMENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0WVhSamFDMWxlSEJ5TG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhSamFDaDRUMkpxTENCN0lIZzZJSHNnYkdWemMxUm9ZVzQ2SURZZ2ZTQjlLU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxaGRHTm9MV1Y0Y0hJdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaGRHTm9LSGhQWW1vc0lIc2dlRG9nZXlCbmNtVmhkR1Z5VkdoaGJrVnhPaUExSUgwZ2ZTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YldGMFkyZ3RaWGh3Y2k1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCaGMzTmxjblFvYldGMFkyZ29lRTlpYWl3Z2V5QjRPaUI3SUd4bGMzTlVhR0Z1UlhFNklEVWdmU0I5S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUExQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiV0YwWTJndFpYaHdjaTVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJqYjI1emRDQjRRWEp5WVhrZ1BTQmJlRjBLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxaGRHTm9MV1Y0Y0hJdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1lYTnpaWEowS0cxaGRHTm9LSGhCY25KaGVTd2dXelZkS1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdQVDBLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURVS0lDQWdJRDA5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWVhOelpYSjBLRzFoZEdOb0tIaEJjbkpoZVN3Z1czc2daM0psWVhSbGNsUm9ZVzQ2SURRZ2ZWMHBLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z05Bb2dJQ0FnUGdvZ0lDQWdaR2xuSURJS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0WVhSamFDMWxlSEJ5TG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhSamFDaDRRWEp5WVhrc0lGdDdJR3hsYzNOVWFHRnVPaUEySUgxZEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJRHdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiV0YwWTJndFpYaHdjaTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJoYzNObGNuUW9iV0YwWTJnb2VFRnljbUY1TENCYmV5Qm5jbVZoZEdWeVZHaGhia1Z4T2lBMUlIMWRLU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEVUtJQ0FnSUQ0OUNpQWdJQ0JrYVdjZ01nb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxaGRHTm9MV1Y0Y0hJdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaGRHTm9LSGhCY25KaGVTd2dXM3NnYkdWemMxUm9ZVzVGY1RvZ05TQjlYU2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOUW9nSUNBZ1BEMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dFlYUmphQzFsZUhCeUxtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUk5ZWFJqYUdWektIZzZJSFZwYm5RMk5Da2dld29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQlFBRUJqRWJRUUFZZ0FTVGZuS2FOaG9BamdFQUFRQXhHUlF4R0JCRVFnQUlNUmtVTVJnVUVFTTJHZ0ZKRllFSUVrUVhGa2tqVzBraUVrUkpnUU1UUkRFQU1nTVRSRWtrRFVSSkpReEVTU0lQUkNJT1JJQUNBQUZNVUVraldZRUJFa3lCQWx0SkloSkxBaEJFU1NRTlN3SVFSRWtsREVzQ0VFUkpJZzlMQWhCRUlnNFFSSUVCUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
