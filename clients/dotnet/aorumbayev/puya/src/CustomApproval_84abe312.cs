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

namespace Arc56.Generated.aorumbayev.puya.CustomApproval_84abe312
{


    public class CustomApprovalProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CustomApprovalProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<ulong> AddOne(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 181, 192, 175 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddOne_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 181, 192, 175 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3VzdG9tQXBwcm92YWwiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYWRkX29uZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTFdLCJlcnJvck1lc3NhZ2UiOiJub25zZW5zZSBhc3NlcnQganVzdCB0byBnZW5lcmF0ZSBhbiBpbml0IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBYMk5oYzJWekxtRmlhVjl5YjNWMGFXNW5MbU4xYzNSdmJWOWhjSEJ5YjNaaGJDNURkWE4wYjIxQmNIQnliM1poYkM1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWVdKcFgzSnZkWFJwYm1jdlkzVnpkRzl0WDJGd2NISnZkbUZzTG5CNU9qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVZWEJ3YkdsallYUnBiMjVmYVdRZ1BUMGdNQ3dnSW01dmJuTmxibk5sSUdGemMyVnlkQ0JxZFhOMElIUnZJR2RsYm1WeVlYUmxJR0Z1SUdsdWFYUWdiV1YwYUc5a0lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIyNXpaVzV6WlNCaGMzTmxjblFnYW5WemRDQjBieUJuWlc1bGNtRjBaU0JoYmlCcGJtbDBJRzFsZEdodlpBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJoWW1sZmNtOTFkR2x1Wnk5amRYTjBiMjFmWVhCd2NtOTJZV3d1Y0hrNk1UTUtJQ0FnSUM4dklHbG1JRlI0Ymk1dWRXMWZZWEJ3WDJGeVozTWdQVDBnTWlCaGJtUWdWSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrZ1BUMGdiM0F1YVhSdllpZzBNaWs2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdjSFZ6YUdsdWRDQTBNaUF2THlBME1nb2dJQ0FnYVhSdllnb2dJQ0FnUFQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCaFltbGZjbTkxZEdsdVp5OWpkWE4wYjIxZllYQndjbTkyWVd3dWNIazZNVFFLSUNBZ0lDOHZJR3h2WnlnaThKK09pZkNmam9ud240NkpJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlYSGhtTUZ4NE9XWmNlRGhsWEhnNE9WeDRaakJjZURsbVhIZzRaVng0T0RsY2VHWXdYSGc1Wmx4NE9HVmNlRGc1SWdvZ0lDQWdiRzluQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklHRmlhVjl5YjNWMGFXNW5MMk4xYzNSdmJWOWhjSEJ5YjNaaGJDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5QkRkWE4wYjIxQmNIQnliM1poYkNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TTJJMVl6QmhaaUF2THlCdFpYUm9iMlFnSW1Ga1pGOXZibVVvZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZllXUmtYMjl1WlY5eWIzVjBaVUF4TVFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ0x5OGdZV0pwWDNKdmRYUnBibWN2WTNWemRHOXRYMkZ3Y0hKdmRtRnNMbkI1T2pZS0lDQWdJQzh2SUdOc1lYTnpJRU4xYzNSdmJVRndjSEp2ZG1Gc0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vYVc1MElEQWdMeThnTUFvZ0lDQWdZblZ5ZVNBeENncHRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEY5allYTmxjeTVoWW1sZmNtOTFkR2x1Wnk1amRYTjBiMjFmWVhCd2NtOTJZV3d1UTNWemRHOXRRWEJ3Y205MllXd3VYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlBTVRVNkNpQWdJQ0F2THlCaFltbGZjbTkxZEdsdVp5OWpkWE4wYjIxZllYQndjbTkyWVd3dWNIazZNVFlLSUNBZ0lDOHZJR2xtSUc1dmRDQnlaWE4xYkhRNkNpQWdJQ0JrZFhBS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z1lXSnBYM0p2ZFhScGJtY3ZZM1Z6ZEc5dFgyRndjSEp2ZG1Gc0xuQjVPakU0TFRFNUNpQWdJQ0F2THlBaWRHaHBjeUIzYVd4c0lHNWxkbVZ5SUdKbElITmxaVzRnZFc1c1pYTnpJSGx2ZFNkeVpTQnlkVzV1YVc1bklHbHVJSE5wYlhWc1lYUnBiMjRnYlc5a1pTQmhibmwzWVhraUNpQWdJQ0F2THlBaUlITnZJRWtnWTJGdUlITmhlU0IzYUdGMFpYWmxjaUJKSUhkaGJuUWdhR1Z5WlNJS0lDQWdJSEIxYzJoaWVYUmxjeUFpZEdocGN5QjNhV3hzSUc1bGRtVnlJR0psSUhObFpXNGdkVzVzWlhOeklIbHZkU2R5WlNCeWRXNXVhVzVuSUdsdUlITnBiWFZzWVhScGIyNGdiVzlrWlNCaGJubDNZWGtnYzI4Z1NTQmpZVzRnYzJGNUlIZG9ZWFJsZG1WeUlFa2dkMkZ1ZENCb1pYSmxJZ29nSUNBZ0x5OGdZV0pwWDNKdmRYUnBibWN2WTNWemRHOXRYMkZ3Y0hKdmRtRnNMbkI1T2pFM0xUSXdDaUFnSUNBdkx5QnNiMmNvQ2lBZ0lDQXZMeUFnSUNBZ0luUm9hWE1nZDJsc2JDQnVaWFpsY2lCaVpTQnpaV1Z1SUhWdWJHVnpjeUI1YjNVbmNtVWdjblZ1Ym1sdVp5QnBiaUJ6YVcxMWJHRjBhVzl1SUcxdlpHVWdZVzU1ZDJGNUlnb2dJQ0FnTHk4Z0lDQWdJQ0lnYzI4Z1NTQmpZVzRnYzJGNUlIZG9ZWFJsZG1WeUlFa2dkMkZ1ZENCb1pYSmxJZ29nSUNBZ0x5OGdLUW9nSUNBZ2JHOW5DZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJR1IxY0FvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGa1pGOXZibVZmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJoWW1sZmNtOTFkR2x1Wnk5amRYTjBiMjFmWVhCd2NtOTJZV3d1Y0hrNk1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJoWW1sZmNtOTFkR2x1Wnk5amRYTjBiMjFmWVhCd2NtOTJZV3d1Y0hrNk5nb2dJQ0FnTHk4Z1kyeGhjM01nUTNWemRHOXRRWEJ3Y205MllXd29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdGaWFWOXliM1YwYVc1bkwyTjFjM1J2YlY5aGNIQnliM1poYkM1d2VUb3lNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0ZrWkY5dmJtVUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEY5allYTmxjeTVoWW1sZmNtOTFkR2x1Wnk1amRYTjBiMjFmWVhCd2NtOTJZV3d1UTNWemRHOXRRWEJ3Y205MllXd3VYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlBTVRVS0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXlPZ29nSUNBZ0x5OGdZV0pwWDNKdmRYUnBibWN2WTNWemRHOXRYMkZ3Y0hKdmRtRnNMbkI1T2pZS0lDQWdJQzh2SUdOc1lYTnpJRU4xYzNSdmJVRndjSEp2ZG1Gc0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEY5allYTmxjeTVoWW1sZmNtOTFkR2x1Wnk1amRYTjBiMjFmWVhCd2NtOTJZV3d1UTNWemRHOXRRWEJ3Y205MllXd3VYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlBTVRVS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GaWFWOXliM1YwYVc1bkxtTjFjM1J2YlY5aGNIQnliM1poYkM1RGRYTjBiMjFCY0hCeWIzWmhiQzVoWkdSZmIyNWxLSGc2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwaFpHUmZiMjVsT2dvZ0lDQWdMeThnWVdKcFgzSnZkWFJwYm1jdlkzVnpkRzl0WDJGd2NISnZkbUZzTG5CNU9qSXpMVEkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJoWkdSZmIyNWxLSE5sYkdZc0lIZzZJRlZKYm5RMk5Da2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCaFltbGZjbTkxZEdsdVp5OWpkWE4wYjIxZllYQndjbTkyWVd3dWNIazZNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQjRJQ3NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdLd29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDb0FBTVJoQUFBUXhHQlJFTVJ1QkFoSkJBQmsyR2dHQktoWVNRUUFQZ0F6d240Nko4SitPaWZDZmpvbXdNUnRCQUtLQUJBTzF3SzgyR2dDT0FRQjJnUUJGQVVsQUFHeUFhWFJvYVhNZ2QybHNiQ0J1WlhabGNpQmlaU0J6WldWdUlIVnViR1Z6Y3lCNWIzVW5jbVVnY25WdWJtbHVaeUJwYmlCemFXMTFiR0YwYVc5dUlHMXZaR1VnWVc1NWQyRjVJSE52SUVrZ1kyRnVJSE5oZVNCM2FHRjBaWFpsY2lCSklIZGhiblFnYUdWeVpiQkpRekVaRkVReEdFUTJHZ0VYaUFBaEZvQUVGUjk4ZFV4UXNJRUJSUUZDLzI4eEdVRC9aakVZRkVTQkFVVUJRdjlmaWdFQmkvK0JBUWlKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
