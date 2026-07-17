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

namespace Arc56.Generated.algorandfoundation.puya.Issue434_3821ce83
{


    public class Issue434Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Issue434Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="c"> </param>
        public async Task Method(ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 173, 122, 85 };
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Method_Transactions(ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 173, 122, 85 };
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSXNzdWU0MzQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoibWV0aG9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZhWE56ZFdWZk5ETTBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRWx6YzNWbE5ETTBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtNMkZrTjJFMU5TQXZMeUJ0WlhSb2IyUWdJbTFsZEdodlpDaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZiV1YwYUc5a1gzSnZkWFJsUURNS0lDQWdJR1Z5Y2dvS2JXRnBibDl0WlhSb2IyUmZjbTkxZEdWQU16b0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmFYTnpkV1ZmTkRNMExuQjVPalV0TmdvZ0lDQWdMeThnSXlCeVpXWTZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2Y0hWNVlTOXBjM04xWlhNdk5ETTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHMWxkR2h2WkFvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQTFPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbkpsWjNKbGMzTnBiMjVmZEdWemRITXVhWE56ZFdWZk5ETTBMa2x6YzNWbE5ETTBMbTFsZEdodlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFsZEdodlpEb0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmFYTnpkV1ZmTkRNMExuQjVPalV0TmdvZ0lDQWdMeThnSXlCeVpXWTZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2Y0hWNVlTOXBjM04xWlhNdk5ETTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENncHRaWFJvYjJSZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwybHpjM1ZsWHpRek5DNXdlVG80Q2lBZ0lDQXZMeUIzYUdsc1pTQkhiRzlpWVd3dWIzQmpiMlJsWDJKMVpHZGxkQ2dwSUQ0Z016VXdPZ29nSUNBZ1oyeHZZbUZzSUU5d1kyOWtaVUoxWkdkbGRBb2dJQ0FnY0hWemFHbHVkQ0F6TlRBS0lDQWdJRDRLSUNBZ0lHSjZJRzFsZEdodlpGOWhablJsY2w5M2FHbHNaVUEwQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMmx6YzNWbFh6UXpOQzV3ZVRvNUNpQWdJQ0F2THlCaGMzTmxjblFnYjNBdWMyaGhNMTh5TlRZb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lrZ0lUMGdWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjMmhoTTE4eU5UWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnYldWMGFHOWtYM2RvYVd4bFgzUnZjRUF5Q2dwdFpYUm9iMlJmWVdaMFpYSmZkMmhwYkdWQU5Eb0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdmFYTnpkV1ZmTkRNMExuQjVPakV4Q2lBZ0lDQXZMeUJwWmlCaklENGdNRG9LSUNBZ0lHUjFjQW9nSUNBZ1lub2diV1YwYUc5a1gyVnNjMlZmWW05a2VVQTJDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwybHpjM1ZsWHpRek5DNXdlVG94TWdvZ0lDQWdMeThnZUNBOUlHTWdLeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvS2JXVjBhRzlrWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZhWE56ZFdWZk5ETTBMbkI1T2pFMkNpQWdJQ0F2THlCaGMzTmxjblFnZUNBdElESWdQVDBnWXdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJsemMzVmxYelF6TkM1d2VUbzFMVFlLSUNBZ0lDOHZJQ01nY21WbU9pQm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMM0IxZVdFdmFYTnpkV1Z6THpRek5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ29LYldWMGFHOWtYMlZzYzJWZlltOWtlVUEyT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlwYzNOMVpWODBNelF1Y0hrNk1UUUtJQ0FnSUM4dklIZ2dQU0JqSUNzZ01nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdJZ2JXVjBhRzlrWDJGbWRHVnlYMmxtWDJWc2MyVkFOd289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3pFYlFRQVlnQVRUclhwVk5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRkpGWUVJRWtRWE1neUIzZ0lOUVFBS01RQ1lNUUFUUkVMLzdVbEJBQXhKZ1FJSWdRSUpFa1NCQVVOSmdRSUlRdi94IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
