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

namespace Arc56.Generated.aorumbayev.puya.AbiCallContract_003bc3f4
{


    public class AbiCallContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbiCallContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> </param>
        /// <param name="app"> </param>
        public async Task TestImplicitConversionAbiCall(ulong app, ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 231, 57, 21, 142 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestImplicitConversionAbiCall_Transactions(ulong app, ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 231, 57, 21, 142 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJpQ2FsbENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfaW1wbGljaXRfY29udmVyc2lvbl9hYmlfY2FsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUEyQ2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0SURCNE1EQXdNZ29nSUNBZ0x5OGdZWEp5WVhrdmRXNTFjMlZrWDI5d2RGOWhiR3h2ZDJWa0xuQjVPakV5Q2lBZ0lDQXZMeUJqYkdGemN5QkJZbWxEWVd4c1EyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEWUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVTNNemt4TlRobElDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5cGJYQnNhV05wZEY5amIyNTJaWEp6YVc5dVgyRmlhVjlqWVd4c0tIVnBiblEyTkZ0ZExHRndjR3hwWTJGMGFXOXVLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUmZhVzF3YkdsamFYUmZZMjl1ZG1WeWMybHZibDloWW1sZlkyRnNiRjl5YjNWMFpVQXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCaGNuSmhlUzkxYm5WelpXUmZiM0IwWDJGc2JHOTNaV1F1Y0hrNk1USUtJQ0FnSUM4dklHTnNZWE56SUVGaWFVTmhiR3hEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSZmFXMXdiR2xqYVhSZlkyOXVkbVZ5YzJsdmJsOWhZbWxmWTJGc2JGOXliM1YwWlVBek9nb2dJQ0FnTHk4Z1lYSnlZWGt2ZFc1MWMyVmtYMjl3ZEY5aGJHeHZkMlZrTG5CNU9qRXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaGNuSmhlUzkxYm5WelpXUmZiM0IwWDJGc2JHOTNaV1F1Y0hrNk1USUtJQ0FnSUM4dklHTnNZWE56SUVGaWFVTmhiR3hEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmNIQnNhV05oZEdsdmJuTUtJQ0FnSUM4dklHRnljbUY1TDNWdWRYTmxaRjl2Y0hSZllXeHNiM2RsWkM1d2VUb3hNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEEyT2dvZ0lDQWdMeThnWVhKeVlYa3ZkVzUxYzJWa1gyOXdkRjloYkd4dmQyVmtMbkI1T2pFeUNpQWdJQ0F2THlCamJHRnpjeUJCWW1sRFlXeHNRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUW9ZWEp5WVhsZmFYUmxiWE5mWTI5MWJuUTZJSFZwYm5RMk5Dd2dZWEp5WVhsZmFHVmhaRjloYm1SZmRHRnBiRG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQnVaWGRmYUdWaFpGOWhibVJmZEdGcGJEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbVI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJadmNsOW9aV0ZrWlhKQU1Rb0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTlRvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBMUNncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZZV1owWlhKZlptOXlRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxtRnljbUY1TG5WdWRYTmxaRjl2Y0hSZllXeHNiM2RsWkM1QlltbERZV3hzUTI5dWRISmhZM1F1ZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNLR0Z5Y2pvZ1lubDBaWE1zSUdGd2NEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDBaWE4wWDJsdGNHeHBZMmwwWDJOdmJuWmxjbk5wYjI1ZllXSnBYMk5oYkd3NkNpQWdJQ0F2THlCaGNuSmhlUzkxYm5WelpXUmZiM0IwWDJGc2JHOTNaV1F1Y0hrNk1UTXRNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNJR0Z5Y2pvZ1NXMXRkWFJoWW14bFFYSnlZWGxiVlVsdWREWTBYU3dnWVhCd09pQkJjSEJzYVdOaGRHbHZiZ29nSUNBZ0x5OGdLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCaGNuSmhlUzkxYm5WelpXUmZiM0IwWDJGc2JHOTNaV1F1Y0hrNk1UY3RNVGdLSUNBZ0lDOHZJQ01nYVhSNGJpQnlaWEYxYVhKbGN5QnlaVzF2ZG1WZmRXNTFjMlZrWDNaaGNtbGhZbXhsY3dvZ0lDQWdMeThnWVhKak5DNWhZbWxmWTJGc2JDZ2laRzl1ZEY5allXeHNLSFZwYm5RMk5GdGRLWFZwYm5RMk5DSXNJR0Z5Y2l3Z1lYQndYMmxrUFdGd2NDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM05XSTJPVFJtTXlBdkx5QnRaWFJvYjJRZ0ltUnZiblJmWTJGc2JDaDFhVzUwTmpSYlhTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHRnljbUY1TDNWdWRYTmxaRjl2Y0hSZllXeHNiM2RsWkM1d2VUb3lNUW9nSUNBZ0x5OGdibVZ6ZEdWa1gyRnljaUE5SUc1bGMzUmxaRjloY25JdVlYQndaVzVrS0dGeWNpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNBdkx5QmhjbkpoZVM5MWJuVnpaV1JmYjNCMFgyRnNiRzkzWldRdWNIazZNaklLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0ltUnZiblJmWTJGc2JDaDFhVzUwTmpSYlhWdGRLWFZwYm5RMk5DSXNJRzVsYzNSbFpGOWhjbklzSUdGd2NGOXBaRDFoY0hBcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WlRreVlqRmtOVE1nTHk4Z2JXVjBhRzlrSUNKa2IyNTBYMk5oYkd3b2RXbHVkRFkwVzExYlhTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk15QXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmhjbkpoZVM5MWJuVnpaV1JmYjNCMFgyRnNiRzkzWldRdWNIazZNalVLSUNBZ0lDOHZJR2x1WkdseVpXTjBYMjVsYzNSbFpGOWhjbkl1WVhCd1pXNWtLRTE1VkhWd2JHVW9abTl2UFdGeWNpd2dZbUZ5UFdGeWNpNXNaVzVuZEdncEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJoY25KaGVTOTFiblZ6WldSZmIzQjBYMkZzYkc5M1pXUXVjSGs2TWpZS0lDQWdJQzh2SUdGeVl6UXVZV0pwWDJOaGJHd29JbVJ2Ym5SZlkyRnNiQ2dvZFdsdWREWTBXMTBzZFdsdWREWTBLVnRkS1hWcGJuUTJOQ0lzSUdsdVpHbHlaV04wWDI1bGMzUmxaRjloY25Jc0lHRndjRjlwWkQxaGNIQXBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UWTFNekV5WkRnZ0x5OGdiV1YwYUc5a0lDSmtiMjUwWDJOaGJHd29LSFZwYm5RMk5GdGRMSFZwYm5RMk5DbGJYU2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnWVhKeVlYa3ZkVzUxYzJWa1gyOXdkRjloYkd4dmQyVmtMbkI1T2pJMENpQWdJQ0F2THlCcGJtUnBjbVZqZEY5dVpYTjBaV1JmWVhKeUlEMGdTVzF0ZFhSaFlteGxRWEp5WVhsYlRYbFVkWEJzWlYwb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUdGeWNtRjVMM1Z1ZFhObFpGOXZjSFJmWVd4c2IzZGxaQzV3ZVRveU5nb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dpWkc5dWRGOWpZV3hzS0NoMWFXNTBOalJiWFN4MWFXNTBOalFwVzEwcGRXbHVkRFkwSWl3Z2FXNWthWEpsWTNSZmJtVnpkR1ZrWDJGeWNpd2dZWEJ3WDJsa1BXRndjQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUNCaVlDQUFJQUFqRWJRUUFrZ0FUbk9SV09OaG9BamdFQUFpSkRNUmtVUkRFWVJEWWFBVFlhQWhmQU1vZ0FqU05ETVJsQS8rUXhHQlJFSTBPS0JBRW9TWXYrSkF1TC9DUUxJb3NFaXdNTVFRQWNpLzJMQkVsT0FsbUxBZ2dXVndZQ2l3Rk1VSXdCSkFpTUJFTC8zSXY5Rll3QUlvd0Vpd1NMQWd4QkFCeUwvNHNFU1U0Q1dZc0FDQlpYQmdLTEFVeFFqQUVrQ0l3RVF2L2NpL3lML2dnV1Z3WUNpd0ZRaS8yTEE0c0FVbENML3hXTC80c0NUd0pTVUl3QWlZb0NBTEdMLzdJWWdBUjF0cFR6c2hxTC9ySWFKYklRSXJJQnN5bUwvbEFpS0NOUEE0ai9XYkdMLzdJWWdBVHBLeDFUc2hxeUdpV3lFQ0t5QWJPTC9pSlpGb0FDQUFwTVVJditVQ2xNVUNJb0kwOERpUDhxU0xHTC83SVlnQVFXVXhMWXNocUFBZ0FBc2hvbHNoQWlzZ0d6aVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
