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

namespace Arc56.Generated.algorandfoundation.puya_ts.BoxCreate_2715203f
{


    public class BoxCreateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxCreateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 32, 16, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 32, 16, 193 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94Q3JlYXRlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUJveGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHTnNZWE56SUVKdmVFTnlaV0YwWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNekl3TVRCak1TQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVSnZlR1Z6S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQ2IzaGxjMTl5YjNWMFpVQXpDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsUW05NFpYTmZjbTkxZEdWQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTBPQW9nSUNBZ0x5OGdZM0psWVhSbFFtOTRaWE1vS1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVFF5Q2lBZ0lDQXZMeUJpYjNoVGRISWdQU0JDYjNnOGMzUnlhVzVuUGloN0lHdGxlVG9nSjJFbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hORGtLSUNBZ0lDOHZJSFJvYVhNdVltOTRVM1J5TG1OeVpXRjBaU2g3SUhOcGVtVTZJREV3SUgwcENpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTBNd29nSUNBZ0x5OGdZbTk0VldsdWRDQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWWljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlpSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaFZhVzUwTG1OeVpXRjBaU2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pveE5EUUtJQ0FnSUM4dklHSnZlRk4wWVhScFkwRnljbUY1SUQwZ1FtOTRQR0Z5WXpRdVUzUmhkR2xqUVhKeVlYazhZWEpqTkM1VmFXNTBNeklzSURFd1BqNG9leUJyWlhrNklDZGpKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pqSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCMGFHbHpMbUp2ZUZOMFlYUnBZMEZ5Y21GNUxtTnlaV0YwWlNncENpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdZbTk0UkhsdVlXMXBZMEZ5Y21GNUlEMGdRbTk0UEdGeVl6UXVSSGx1WVcxcFkwRnljbUY1UEdGeVl6UXVWV2x1ZERnK1BpaDdJR3RsZVRvZ0oyUW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbVFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TlRVS0lDQWdJQzh2SUhSb2FYTXVZbTk0UkhsdVlXMXBZMEZ5Y21GNUxtTnlaV0YwWlNoN0lITnBlbVU2SURJZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hORFlLSUNBZ0lDOHZJR0p2ZUZSMWNHeGxJRDBnUW05NFBHRnlZelF1VkhWd2JHVThXMkZ5WXpRdVZXbHVkRGdzSUdGeVl6UXVWV2x1ZERnc0lHRnlZelF1UW05dmJDd2dZWEpqTkM1Q2IyOXNYVDQrS0hzZ2EyVjVPaUFuWlNjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVpTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdkR2hwY3k1aWIzaFVkWEJzWlM1amNtVmhkR1VvS1FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z1ltOTRRbTl2YkNBOUlFSnZlRHhpYjI5c1pXRnVQaWg3SUd0bGVUb2dKMkp2YjJ3bklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltSnZiMndpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem94TlRrS0lDQWdJQzh2SUhSb2FYTXVZbTk0UW05dmJDNWpjbVZoZEdVb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNVFF4Q2lBZ0lDQXZMeUJpYjNoQmNtTTBRbTl2YkNBOUlFSnZlRHhoY21NMExrSnZiMncrS0hzZ2EyVjVPaUFuWVhKak5HSW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZ5WXpSaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk1UWXhDaUFnSUNBdkx5QjBhR2x6TG1KdmVFRnlZelJDYjI5c0xtTnlaV0YwWlNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJR055WldGMFpVSnZlR1Z6S0NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z1kyeGhjM01nUW05NFEzSmxZWFJsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNDQUV4RzBFQVRJQUVreUFRd1RZYUFJNEJBQUVBTVJrVU1SZ1FSSUFCWVlFS3VVaUFBV0lpdVVpQUFXT0JLTGxJZ0FGa2dRSzVTSUFCWllFRHVVaUFCR0p2YjJ3aXVVaUFCV0Z5WXpSaUk3bElJME14R1JReEdCUVFRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
