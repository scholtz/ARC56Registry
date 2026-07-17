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

namespace Arc56.Generated.algorandfoundation.puya_ts.DemoContract_94377c90
{


    public class DemoContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DemoContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stop"> </param>
        public async Task<ulong> TestWhile(ulong stop, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 165, 45, 115 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);

            var result = await base.CallApp(new List<object> { abiHandle, stopAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestWhile_Transactions(ulong stop, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 165, 45, 115 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVtb0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RXaGlsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTNhR2xzWlMxc2IyOXdjeTVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR05zWVhOeklFUmxiVzlEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkMmhwYkdVdGJHOXZjSE11WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5QkVaVzF2UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5T0dFMU1tUTNNeUF2THlCdFpYUm9iMlFnSW5SbGMzUlhhR2xzWlNoMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUlhhR2xzWlY5eWIzVjBaVUF6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURZS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1JHVnRiME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgzUmxjM1JYYUdsc1pWOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNkb2FXeGxMV3h2YjNCekxtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUlhhR2xzWlNoemRHOXdPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wVjJocGJHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFFLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmQyaHBiR1V0Ykc5dmNITXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmpiR0Z6Y3lCRVpXMXZRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZPa1JsYlc5RGIyNTBjbUZqZEM1MFpYTjBWMmhwYkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVjJocGJHVTZDaUFnSUNCaUlIUmxjM1JYYUdsc1pWOWliRzlqYTBBd0NncDBaWE4wVjJocGJHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5M2FHbHNaUzFzYjI5d2N5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBWMmhwYkdVb2MzUnZjRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmQyaHBiR1V0Ykc5dmNITXVZV3huYnk1MGN6bzZSR1Z0YjBOdmJuUnlZV04wTG5SbGMzUlhhR2xzWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZDJocGJHVXRiRzl2Y0hNdVlXeG5ieTUwY3pvNlJHVnRiME52Ym5SeVlXTjBMblJsYzNSWGFHbHNaU2h6ZEc5d09pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZPa1JsYlc5RGIyNTBjbUZqZEM1MFpYTjBWMmhwYkdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZDJocGJHVXRiRzl2Y0hNdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGZG9hV3hsS0hOMGIzQTZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkzYUdsc1pTMXNiMjl3Y3k1aGJHZHZMblJ6T2pwRVpXMXZRMjl1ZEhKaFkzUXVkR1Z6ZEZkb2FXeGxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OTNhR2xzWlMxc2IyOXdjeTVoYkdkdkxuUnpPanBFWlcxdlEyOXVkSEpoWTNRdWRHVnpkRmRvYVd4bFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZDJocGJHVXRiRzl2Y0hNdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCc1pYUWdhU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZPa1JsYlc5RGIyNTBjbUZqZEM1MFpYTjBWMmhwYkdWZmQyaHBiR1ZmZEc5d1FERUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OTNhR2xzWlMxc2IyOXdjeTVoYkdkdkxuUnpPanBFWlcxdlEyOXVkSEpoWTNRdWRHVnpkRmRvYVd4bFgzZG9hV3hsWDNSdmNFQXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdkMmhwYkdVZ0tHa2dQQ0J6ZEc5d0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkMmhwYkdVdGJHOXZjSE11WVd4bmJ5NTBjem8zTFRrS0lDQWdJQzh2SUhkb2FXeGxJQ2hwSUR3Z2MzUnZjQ2tnZXdvZ0lDQWdMeThnSUNCcElDczlJREVLSUNBZ0lDOHZJSDBLSUNBZ0lHSjZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTNhR2xzWlMxc2IyOXdjeTVoYkdkdkxuUnpPanBFWlcxdlEyOXVkSEpoWTNRdWRHVnpkRmRvYVd4bFgyRm1kR1Z5WDNkb2FXeGxRRE1LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZPa1JsYlc5RGIyNTBjbUZqZEM1MFpYTjBWMmhwYkdWZmQyaHBiR1ZmWW05a2VVQXlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZkMmhwYkdVdGJHOXZjSE11WVd4bmJ5NTBjem82UkdWdGIwTnZiblJ5WVdOMExuUmxjM1JYYUdsc1pWOTNhR2xzWlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkMmhwYkdVdGJHOXZjSE11WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJwSUNzOUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5M2FHbHNaUzFzYjI5d2N5NWhiR2R2TG5Sek9qcEVaVzF2UTI5dWRISmhZM1F1ZEdWemRGZG9hV3hsWDNkb2FXeGxYM1J2Y0VBeENncDBaWE4wY3k5aGNIQnliM1poYkhNdmQyaHBiR1V0Ykc5dmNITXVZV3huYnk1MGN6bzZSR1Z0YjBOdmJuUnlZV04wTG5SbGMzUlhhR2xzWlY5aFpuUmxjbDkzYUdsc1pVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzZG9hV3hsTFd4dmIzQnpMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQnBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkMmhwYkdVdGJHOXZjSE11WVd4bmJ5NTBjem82UkdWdGIwTnZiblJ5WVdOMExsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlNncElDMCtJSFp2YVdRNkNsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlRvS0lDQWdJR0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQUtDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFGQ0FBQkNBQUF4R3lJVFFRQXBRZ0FBTmhvQWdBUW9wUzF6VHdHT0FRQUhRZ0FBUWdBQUFERVpJaEl4R0NJVEVFU0lBQkpDLyt3eEdTSVNNUmdpRWhCRWlBQkNJME5DQUFBMkdnRkpGWUVJRWtRWGlBQU5Gb0FFRlI5OGRVOEJVTEFqUTRvQkFVSUFBQ0pDQUFDTEFJdi9ERUVBREVJQUFJc0FJd2lNQUVMLzdJc0FUd0dKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
