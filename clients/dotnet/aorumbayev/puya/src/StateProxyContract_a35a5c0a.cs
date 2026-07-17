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

namespace Arc56.Generated.aorumbayev.puya.StateProxyContract_a35a5c0a
{


    public class StateProxyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateProxyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVQcm94eUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiT3B0SW4iXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgT3B0SW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBYMk5oYzJWekxuTjBZWFJsWDNCeWIzaHBaWE11WTI5dWRISmhZM1F1VTNSaGRHVlFjbTk0ZVVOdmJuUnlZV04wTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnYzJWc1ppNW5iRzlpWVd3eUlEMGdSMnh2WW1Gc1UzUmhkR1ZiVlVsdWREWTBYU2hWU1c1ME5qUW9NQ2tzSUd0bGVUMWlJbWN5SWl3Z1pHVnpZM0pwY0hScGIyNDlJbWN5SUdSbGMyTnlhWEIwYVc5dUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWTNNeklLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdaV3h6WlNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRc0lHdGxlVDBpZEc5M2JpSXBDaUFnSUNCd2RYTm9ZbmwwWlhOeklDSjBiM2R1SWlBaVpuVnVhM2tpSUM4dklDSjBiM2R1SWl3Z0ltWjFibXQ1SWdvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnYVdZZ1ZIaHVMbTUxYlY5aGNIQmZZWEpuY3dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJQzh2SUhOMFlYUmxYM0J5YjNocFpYTXZZMjl1ZEhKaFkzUXVjSGs2TVRrdE1qRUtJQ0FnSUM4dklFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5Dd2dhMlY1UFNKbWRXNXJlU0lwQ2lBZ0lDQXZMeUJwWmlCVWVHNHViblZ0WDJGd2NGOWhjbWR6Q2lBZ0lDQXZMeUJsYkhObElFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5Dd2dhMlY1UFNKMGIzZHVJaWtLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWm5WdWEzbGZkRzkzYmk1MllXeDFaU0E5SUZWSmJuUTJOQ2d4TWpNcENpQWdJQ0J3ZFhOb2FXNTBJREV5TXlBdkx5QXhNak1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITjBZWFJsWDNCeWIzaHBaWE12WTI5dWRISmhZM1F1Y0hrNk1USUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxVSEp2ZUhsRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXNJSE4wWVhSbFgzUnZkR0ZzY3oxVGRHRjBaVlJ2ZEdGc2N5aG5iRzlpWVd4ZmRXbHVkSE05TXlrcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZelZqTmpGaVlTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzNSaGRHVmZjSEp2ZUdsbGN5OWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdWUWNtOTRlVU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZEN3Z2MzUmhkR1ZmZEc5MFlXeHpQVk4wWVhSbFZHOTBZV3h6S0dkc2IySmhiRjkxYVc1MGN6MHpLU2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MzUmhkR1ZmY0hKdmVHbGxjeTlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTl3ZEVsdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVDNCMFNXNEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWMzUmhkR1ZmY0hKdmVHbGxjeTVqYjI1MGNtRmpkQzVUZEdGMFpWQnliM2g1UTI5dWRISmhZM1F1WTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjM1JoZEdWZmNISnZlR2xsY3k5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdjMlZzWmk1bmJHOWlZV3d4TG5aaGJIVmxJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWN4SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6ZEdGMFpWOXdjbTk0YVdWekwyTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzTVZ0VWVHNHVjMlZ1WkdWeVhTQTlJRlZKYm5RMk5DZ3lLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKc01TSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpkR0YwWlY5d2NtOTRhV1Z6TDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QnpaV3htTG14dlkyRnNNbHRVZUc0dWMyVnVaR1Z5WFNBOUlGVkpiblEyTkNnektRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Tm1Nek1nb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklETUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUF4R0VBQUdZQUNaeklqWjRJQ0JIUnZkMjRGWm5WdWEza3hHMDJCZTJjeEcwRUFEWUFFVEZ4aHVqWWFBSTRCQUFJalF6RVpJaEpFTVJnVVJJZ0FBaUpEZ0FKbk1TSm5NUUNBQW13eGdRSm1NUUNBQW13eWdRTm1pUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
