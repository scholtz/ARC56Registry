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

namespace Arc56.Generated.SHIVAJIJAMADAR.Hackspiration.ScholarStream_9b4a544d
{


    public class ScholarStreamProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ScholarStreamProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        /// <param name="total_amount"> </param>
        /// <param name="duration_seconds"> </param>
        public async Task CreateStream(Algorand.Address beneficiary, ulong total_amount, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 251, 166, 107 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, beneficiaryAbi, total_amountAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateStream_Transactions(Algorand.Address beneficiary, ulong total_amount, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 251, 166, 107 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi, total_amountAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Withdraw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 53, 95, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 53, 95, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DelegateWithdraw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 31, 193, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelegateWithdraw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 31, 193, 158 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2Nob2xhclN0cmVhbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfc3RyZWFtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkdXJhdGlvbl9zZWNvbmRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGVnYXRlX3dpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQ3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdHJlYW1zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzLDEwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREU0TkRRMk56UTBNRGN6TnpBNU5UVXhOakUxSURZMElERXlPQW9nSUNBZ1lubDBaV05pYkc5amF5QWljM1J5WldGdGN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJUWTJodmJHRnlVM1J5WldGdEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56bG1ZbUUyTm1JZ01IaGlOek0xTldaa01TQXdlR1ZpTVdaak1UbGxJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYM04wY21WaGJTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR1ZuWVhSbFgzZHBkR2hrY21GM0tDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsWDNOMGNtVmhiU0IzYVhSb1pISmhkeUJrWld4bFoyRjBaVjkzYVhSb1pISmhkd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJOb2IyeGhjbDl6ZEhKbFlXMHVZMjl1ZEhKaFkzUXVVMk5vYjJ4aGNsTjBjbVZoYlM1amNtVmhkR1ZmYzNSeVpXRnRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYM04wY21WaGJUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRveE1pMHhOUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJRU55WldGMFpTQlRkSEpsWVcwS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRveU5nb2dJQ0FnTHk4Z2ZDQW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BEd2dOalFwQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOalFLSUNBZ0lITm9iQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmphRzlzWVhKZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTFMVEkyQ2lBZ0lDQXZMeUIwYjNSaGJGOWhiVzkxYm5RS0lDQWdJQzh2SUh3Z0tFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3OElEWTBLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0I4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMk5vYjJ4aGNsOXpkSEpsWVcwdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJSHdnS0dSMWNtRjBhVzl1WDNObFkyOXVaSE1nUER3Z01USTRLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklERXlPQW9nSUNBZ2MyaHNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyTm9iMnhoY2w5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk1qVXRNamNLSUNBZ0lDOHZJSFJ2ZEdGc1gyRnRiM1Z1ZEFvZ0lDQWdMeThnZkNBb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUER3Z05qUXBDaUFnSUNBdkx5QjhJQ2hrZFhKaGRHbHZibDl6WldOdmJtUnpJRHc4SURFeU9Da0tJQ0FnSUh3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WTJodmJHRnlYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnZkNBb1ZVbHVkRFkwS0RBcElEdzhJREU1TWlrS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmphRzlzWVhKZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qSTFMVEk0Q2lBZ0lDQXZMeUIwYjNSaGJGOWhiVzkxYm5RS0lDQWdJQzh2SUh3Z0tFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3OElEWTBLUW9nSUNBZ0x5OGdmQ0FvWkhWeVlYUnBiMjVmYzJWamIyNWtjeUE4UENBeE1qZ3BDaUFnSUNBdkx5QjhJQ2hWU1c1ME5qUW9NQ2tnUER3Z01Ua3lLUW9nSUNBZ2ZBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOamFHOXNZWEpmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCelpXeG1Mbk4wY21WaGJYTmJZbVZ1WldacFkybGhjbmxkSUQwZ2NHRmphMlZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEhKbFlXMXpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZMmh2YkdGeVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUb3hNaTB4TlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0JUZEhKbFlXMEtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTmphRzlzWVhKZmMzUnlaV0Z0TG1OdmJuUnlZV04wTGxOamFHOXNZWEpUZEhKbFlXMHVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZMmh2YkdGeVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUb3pNeTB6TmdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZkcGRHaGtjbUYzSUZOMGNtVmhiV1ZrSUVaMWJtUnpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyTm9iMnhoY2w5emRISmxZVzB1WTI5dWRISmhZM1F1VTJOb2IyeGhjbE4wY21WaGJTNTNhWFJvWkhKaGR3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WTJodmJHRnlYM04wY21WaGJTNWpiMjUwY21GamRDNVRZMmh2YkdGeVUzUnlaV0Z0TG1SbGJHVm5ZWFJsWDNkcGRHaGtjbUYzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaV2RoZEdWZmQybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJOb2IyeGhjbDl6ZEhKbFlXMHZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUhObGJHWXVkMmwwYUdSeVlYY29LUW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzJOb2IyeGhjbDl6ZEhKbFlXMHVZMjl1ZEhKaFkzUXVVMk5vYjJ4aGNsTjBjbVZoYlM1M2FYUm9aSEpoZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05qYUc5c1lYSmZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPamMyTFRjNUNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1JHVnNaV2RoZEdWa0lGZHBkR2hrY21GM0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elkyaHZiR0Z5WDNOMGNtVmhiUzVqYjI1MGNtRmpkQzVUWTJodmJHRnlVM1J5WldGdExuZHBkR2hrY21GM0tDa2dMVDRnZG05cFpEb0tjMjFoY25SZlkyOXVkSEpoWTNSekxuTmphRzlzWVhKZmMzUnlaV0Z0TG1OdmJuUnlZV04wTGxOamFHOXNZWEpUZEhKbFlXMHVkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyTm9iMnhoY2w5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk16TXRNemNLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJYYVhSb1pISmhkeUJUZEhKbFlXMWxaQ0JHZFc1a2N3b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCM2FYUm9aSEpoZHloelpXeG1LU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTUNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJOb2IyeGhjbDl6ZEhKbFlXMHZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhOMGNtVmhiU0E5SUhObGJHWXVjM1J5WldGdGMxdHpaVzVrWlhKZllXUmtjbVZ6YzEwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMGNtVmhiWE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMk5vYjJ4aGNsOXpkSEpsWVcwdlkyOXVkSEpoWTNRdWNIazZNemt0TkRBS0lDQWdJQzh2SUNNZ1EyOXVkbVZ5ZENCelpXNWtaWElnYVc1MGJ5QkJVa00wSUVGa1pISmxjM01LSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5WlhOeklEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMk5vYjJ4aGNsOXpkSEpsWVcwdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJSE4wY21WaGJTQTlJSE5sYkdZdWMzUnlaV0Z0YzF0elpXNWtaWEpmWVdSa2NtVnpjMTBLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRISmxZVzF6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOamFHOXNZWEpmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCMGIzUmhiQ0E5SUhOMGNtVmhiU0FtSUNnb01TQThQQ0EyTkNrZ0xTQXhLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01UZzBORFkzTkRRd056TTNNRGsxTlRFMk1UVUtJQ0FnSUNZS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WTJodmJHRnlYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnYzNSaGNuUmZkR2x0WlNBOUlDaHpkSEpsWVcwZ1BqNGdOalFwSUNZZ0tDZ3hJRHc4SURZMEtTQXRJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTJOQW9nSUNBZ2MyaHlDaUFnSUNCcGJuUmpYekVnTHk4Z01UZzBORFkzTkRRd056TTNNRGsxTlRFMk1UVUtJQ0FnSUNZS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyTm9iMnhoY2w5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklHUjFjbUYwYVc5dUlEMGdLSE4wY21WaGJTQStQaUF4TWpncElDWWdLQ2d4SUR3OElEWTBLU0F0SURFcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF4TWpnS0lDQWdJSE5vY2dvZ0lDQWdhVzUwWTE4eElDOHZJREU0TkRRMk56UTBNRGN6TnpBNU5UVXhOakUxQ2lBZ0lDQW1DaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WTJodmJHRnlYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnZDJsMGFHUnlZWGR1SUQwZ0tITjBjbVZoYlNBK1BpQXhPVElwSUNZZ0tDZ3hJRHc4SURZMEtTQXRJREVwQ2lBZ0lDQndkWE5vYVc1MElERTVNZ29nSUNBZ2MyaHlDaUFnSUNCcGJuUmpYekVnTHk4Z01UZzBORFkzTkRRd056TTNNRGsxTlRFMk1UVUtJQ0FnSUNZS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1pXeGhjSE5sWkNBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUMwZ2MzUmhjblJmZEdsdFpRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05qYUc5c1lYSmZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalV4TFRVeUNpQWdJQ0F2THlBaklFTnNZVzF3SUdWc1lYQnpaV1FnZEdsdFpRb2dJQ0FnTHk4Z2FXWWdaV3hoY0hObFpDQStJR1IxY21GMGFXOXVPZ29nSUNBZ1Bnb2dJQ0FnWW5vZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5OamFHOXNZWEpmYzNSeVpXRnRMbU52Ym5SeVlXTjBMbE5qYUc5c1lYSlRkSEpsWVcwdWQybDBhR1J5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTFDZ3B6YldGeWRGOWpiMjUwY21GamRITXVjMk5vYjJ4aGNsOXpkSEpsWVcwdVkyOXVkSEpoWTNRdVUyTm9iMnhoY2xOMGNtVmhiUzUzYVhSb1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyTm9iMnhoY2w5emRISmxZVzB2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklIWmxjM1JsWkNBOUlDaDBiM1JoYkNBcUlHVnNZWEJ6WldRcElDOHZJR1IxY21GMGFXOXVDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOamFHOXNZWEpmYzNSeVpXRnRMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCM2FYUm9aSEpoZDJGaWJHVWdQU0IyWlhOMFpXUWdMU0IzYVhSb1pISmhkMjRLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhkcGRHaGtjbUYzWVdKc1pTQStJREFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMk5vYjJ4aGNsOXpkSEpsWVcwdlkyOXVkSEpoWTNRdWNIazZOakF0TmpRS0lDQWdJQzh2SUNNZ1NXNXVaWElnY0dGNWJXVnVkQ0IwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhkcGRHaGtjbUYzWVdKc1pTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WTJodmJHRnlYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05qYUc5c1lYSmZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPall3TFRZeENpQWdJQ0F2THlBaklFbHVibVZ5SUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZMmh2YkdGeVgzTjBjbVZoYlM5amIyNTBjbUZqZEM1d2VUbzJNQzAyTkFvZ0lDQWdMeThnSXlCSmJtNWxjaUJ3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5ZDJsMGFHUnlZWGRoWW14bExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WTJodmJHRnlYM04wY21WaGJTOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnZkNBb2MzUmhjblJmZEdsdFpTQThQQ0EyTkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOalFLSUNBZ0lITm9iQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmphRzlzWVhKZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qWTRMVFk1Q2lBZ0lDQXZMeUIwYjNSaGJBb2dJQ0FnTHk4Z2ZDQW9jM1JoY25SZmRHbHRaU0E4UENBMk5Da0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdmQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmphRzlzWVhKZmMzUnlaV0Z0TDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QjhJQ2hrZFhKaGRHbHZiaUE4UENBeE1qZ3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF4TWpnS0lDQWdJSE5vYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05qYUc5c1lYSmZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalk0TFRjd0NpQWdJQ0F2THlCMGIzUmhiQW9nSUNBZ0x5OGdmQ0FvYzNSaGNuUmZkR2x0WlNBOFBDQTJOQ2tLSUNBZ0lDOHZJSHdnS0dSMWNtRjBhVzl1SUR3OElERXlPQ2tLSUNBZ0lId0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z2ZDQW9LSGRwZEdoa2NtRjNiaUFySUhkcGRHaGtjbUYzWVdKc1pTa2dQRHdnTVRreUtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnY0hWemFHbHVkQ0F4T1RJS0lDQWdJSE5vYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05qYUc5c1lYSmZjM1J5WldGdEwyTnZiblJ5WVdOMExuQjVPalk0TFRjeENpQWdJQ0F2THlCMGIzUmhiQW9nSUNBZ0x5OGdmQ0FvYzNSaGNuUmZkR2x0WlNBOFBDQTJOQ2tLSUNBZ0lDOHZJSHdnS0dSMWNtRjBhVzl1SUR3OElERXlPQ2tLSUNBZ0lDOHZJSHdnS0NoM2FYUm9aSEpoZDI0Z0t5QjNhWFJvWkhKaGQyRmliR1VwSUR3OElERTVNaWtLSUNBZ0lId0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5elkyaHZiR0Z5WDNOMGNtVmhiUzlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEhKbFlXMXpXM05sYm1SbGNsOWhaR1J5WlhOelhTQTlJRzVsZDE5d1lXTnJaV1FLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBZi8vLy8vLy8vLy8vd0ZBZ0FFbUFRZHpkSEpsWVcxek1SdEJBQ1F4R1JSRU1SaEVnZ01FZWZ1bWF3UzNOVi9SQk9zZndaNDJHZ0NPQXdBSkFEMEFRZ0F4R1JReEdCUVFRellhQVVrVmdTQVNSRFlhQWtrVmdRZ1NSQmMyR2dOSkZZRUlFa1FYTWdja2tFOENHVXdsa0JtQkFCa29Ud0pRVEJhL0lrT0lBQWNpUTRnQUFpSkRpZ0FBS0RFQVVFbStSQmRKSXhwTVNTU1JJeHBKVHdKSkpaRWpHa2xPQWs0RGdjQUJrU01hVGdJeUIwOENDVWxQQWcxQkFBU0xBNHdGaXdGSml3VUxpd05KVGdJS2l3UkpUZ1FKU1VTeE1RQkxBYklJc2djaXNoQ0JBTElCczRzQ0pKQlBBeGxQQWlXUUdVNENDSUhBQVpBWkZvc0FUTCtKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
