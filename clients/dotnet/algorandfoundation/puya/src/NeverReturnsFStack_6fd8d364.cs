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

namespace Arc56.Generated.algorandfoundation.puya.NeverReturnsFStack_6fd8d364
{


    public class NeverReturnsFStackProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NeverReturnsFStackProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Method(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 39, 244, 164 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Method_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 39, 244, 164 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmV2ZXJSZXR1cm5zRlN0YWNrIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Im1ldGhvZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZibVYyWlhKZmNtVjBkWEp1Y3k1d2VUb3hOZ29nSUNBZ0x5OGdZMnhoYzNNZ1RtVjJaWEpTWlhSMWNtNXpSbE4wWVdOcktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnelpqSTNaalJoTkNBdkx5QnRaWFJvYjJRZ0ltMWxkR2h2WkNncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl0WlhSb2IyUmZjbTkxZEdWQU13b2dJQ0FnWlhKeUNncHRZV2x1WDIxbGRHaHZaRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXVaWFpsY2w5eVpYUjFjbTV6TG5CNU9qRTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHMWxkR2h2WkFvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQTFPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbkpsWjNKbGMzTnBiMjVmZEdWemRITXVibVYyWlhKZmNtVjBkWEp1Y3k1T1pYWmxjbEpsZEhWeWJuTkdVM1JoWTJzdWJXVjBhRzlrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXVjBhRzlrT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTl1WlhabGNsOXlaWFIxY201ekxuQjVPakkxQ2lBZ0lDQXZMeUI0SUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZibVYyWlhKZmNtVjBkWEp1Y3k1d2VUb3lOZ29nSUNBZ0x5OGdhV1lnVkhodUxtNTFiVjloY0hCZllYSm5jeUErSURBNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXVjBhRzlrWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OXVaWFpsY2w5eVpYUjFjbTV6TG5CNU9qSTNDaUFnSUNBdkx5QjRJRDBnVlVsdWREWTBLRElwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdKMWNua2dNUW9LYldWMGFHOWtYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJtVjJaWEpmY21WMGRYSnVjeTV3ZVRvek1Bb2dJQ0FnTHk4Z1ptOXlJR2xrZUNCcGJpQjFjbUZ1WjJVb1ZIaHVMbTUxYlY5aGNIQmZZWEpuY3lrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5dVpYWmxjbDl5WlhSMWNtNXpMbkI1T2pJNUNpQWdJQ0F2THlCdmJtVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5dVpYWmxjbDl5WlhSMWNtNXpMbkI1T2pNd0NpQWdJQ0F2THlCbWIzSWdhV1I0SUdsdUlIVnlZVzVuWlNoVWVHNHViblZ0WDJGd2NGOWhjbWR6S1RvS0lDQWdJR1IxY0FvS2JXVjBhRzlrWDJadmNsOW9aV0ZrWlhKQU5Eb0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmJtVjJaWEpmY21WMGRYSnVjeTV3ZVRvek1Bb2dJQ0FnTHk4Z1ptOXlJR2xrZUNCcGJpQjFjbUZ1WjJVb1ZIaHVMbTUxYlY5aGNIQmZZWEpuY3lrNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WlhSb2IyUmZZV1owWlhKZlptOXlRRGdLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZibVYyWlhKZmNtVjBkWEp1Y3k1d2VUb3pNUW9nSUNBZ0x5OGdlQ0FyUFNCcFpIZ0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRFVLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZibVYyWlhKZmNtVjBkWEp1Y3k1d2VUb3pNZ29nSUNBZ0x5OGdhV1lnYVdSNElEMDlJREE2Q2lBZ0lDQmlibm9nYldWMGFHOWtYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5dVpYWmxjbDl5WlhSMWNtNXpMbkI1T2pNekNpQWdJQ0F2THlCdmJtVWdLejBnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NncHRaWFJvYjJSZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTl1WlhabGNsOXlaWFIxY201ekxuQjVPak13Q2lBZ0lDQXZMeUJtYjNJZ2FXUjRJR2x1SUhWeVlXNW5aU2hVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpLVG9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnS3dvZ0lDQWdZaUJ0WlhSb2IyUmZabTl5WDJobFlXUmxja0EwQ2dwdFpYUm9iMlJmWVdaMFpYSmZabTl5UURnNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12Ym1WMlpYSmZjbVYwZFhKdWN5NXdlVG96TlFvZ0lDQWdMeThnYkc5bktDSjViM1VnZDI5dUozUWdjMlZsSUhSb2FYTWlMQ0J2Ym1VcENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW5sdmRTQjNiMjRuZENCelpXVWdkR2hwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDI1bGRtVnlYM0psZEhWeWJuTXVjSGs2TXpZS0lDQWdJQzh2SUc5d0xtVnljaWdwQ2lBZ0lDQmxjbklLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3pFYlFRQVlnQVEvSi9Ta05ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVPQkFURWJRUUFFZ1FKRkFURWJnUUJKU1VzRERFRUFHRXNEU3dGSlRnSUlSUVZBQUFWTWdRRUlUSUVCQ0VMLzRVZ1dnQko1YjNVZ2QyOXVKM1FnYzJWbElIUm9hWE5NVUxBQSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
