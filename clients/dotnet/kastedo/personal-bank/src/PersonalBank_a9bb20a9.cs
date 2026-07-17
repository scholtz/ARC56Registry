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

namespace Arc56.Generated.kastedo.personal_bank.PersonalBank_a9bb20a9
{


    public class PersonalBankProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PersonalBankProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deposits funds into the personal bank.
        ///The deposit amount is recorded in the sender's BoxMap.
        ///If the sender already has a deposit, the amount is added to their existing balance.
        ///</summary>
        /// <param name="payTxn">- The payment transaction containing deposit information </param>
        /// <param name="githubHandle">- A GitHub handle </param>
        public async Task<ulong> Deposit(PaymentTransaction payTxn, string githubHandle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 216, 34, 255, 239 };
            var githubHandleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); githubHandleAbi.From(githubHandle);

            var result = await base.CallApp(new List<object> { abiHandle, payTxn, githubHandleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payTxn, string githubHandle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 216, 34, 255, 239 };
            var githubHandleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); githubHandleAbi.From(githubHandle);

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn, githubHandleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraws all funds from the sender's account.
        ///This method transfers the entire balance of the sender's account back to them,
        ///and resets their balance to zero. The sender must have a deposit to withdraw.
        ///</summary>
        public async Task<ulong> Withdraw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 57, 95, 43 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 57, 95, 43 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVyc29uYWxCYW5rIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdHMgZnVuZHMgaW50byB0aGUgcGVyc29uYWwgYmFuay5cblRoZSBkZXBvc2l0IGFtb3VudCBpcyByZWNvcmRlZCBpbiB0aGUgc2VuZGVyJ3MgQm94TWFwLlxuSWYgdGhlIHNlbmRlciBhbHJlYWR5IGhhcyBhIGRlcG9zaXQsIHRoZSBhbW91bnQgaXMgYWRkZWQgdG8gdGhlaXIgZXhpc3RpbmcgYmFsYW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5VHhuIiwiZGVzYyI6Ii0gVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY29udGFpbmluZyBkZXBvc2l0IGluZm9ybWF0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnaXRodWJIYW5kbGUiLCJkZXNjIjoiLSBBIEdpdEh1YiBoYW5kbGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHRvdGFsIGFtb3VudCBkZXBvc2l0ZWQgYnkgdGhlIHNlbmRlciBhZnRlciB0aGlzIHRyYW5zYWN0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXdzIGFsbCBmdW5kcyBmcm9tIHRoZSBzZW5kZXIncyBhY2NvdW50LlxuVGhpcyBtZXRob2QgdHJhbnNmZXJzIHRoZSBlbnRpcmUgYmFsYW5jZSBvZiB0aGUgc2VuZGVyJ3MgYWNjb3VudCBiYWNrIHRvIHRoZW0sXG5hbmQgcmVzZXRzIHRoZWlyIGJhbGFuY2UgdG8gemVyby4gVGhlIHNlbmRlciBtdXN0IGhhdmUgYSBkZXBvc2l0IHRvIHdpdGhkcmF3LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYW1vdW50IHdpdGhkcmF3biAoYXMgVUludDY0KSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTYzLDE4Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA0XSwiZXJyb3JNZXNzYWdlIjoiTm8gZGVwb3NpdHMgZm91bmQgZm9yIHRoaXMgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3LDg0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1XSwiZXJyb3JNZXNzYWdlIjoiUmVjZWl2ZXIgbXVzdCBiZSB0aGUgY29udHJhY3QgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwLDg3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmtaWEJ2YzJsMGIzSnpJaUF3ZURFMU1XWTNZemMxSUNKbmFYUm9kV0pJWVc1a2JHVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHVnljMjl1WVd4Q1lXNXJJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhrT0RJeVptWmxaaUF3ZUROaE16azFaakppSUM4dklHMWxkR2h2WkNBaVpHVndiM05wZENod1lYa3NjM1J5YVc1bktYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhjb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWkdWd2IzTnBkRjl5YjNWMFpVQXpJRzFoYVc1ZmQybDBhR1J5WVhkZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQmxjbk52Ym1Gc1FtRnVheUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkMmwwYUdSeVlYZGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2hrY21GM0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSbGNHOXphWFJmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUdWeWMyOXVZV3hDWVc1cklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR1JsY0c5emFYUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVR1Z5YzI5dVlXeENZVzVySUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFaWEp6YjI1aGJFSmhibXN1WkdWd2IzTnBkQ2h3WVhsVWVHNDZJSFZwYm5RMk5Dd2daMmwwYUhWaVNHRnVaR3hsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU55MHlPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1Z3YjNOcGRDaHdZWGxVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1oybDBhSFZpU0dGdVpHeGxPaUJ6ZEhKcGJtY3BJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdZWE56WlhKMEtIQmhlVlI0Ymk1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lDZFNaV05sYVhabGNpQnRkWE4wSUdKbElIUm9aU0JqYjI1MGNtRmpkQ0JoWkdSeVpYTnpKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxZMlZwZG1WeUlHMTFjM1FnWW1VZ2RHaGxJR052Ym5SeVlXTjBJR0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGxVZUc0dVlXMXZkVzUwSUQ0Z01Dd2dKMFJsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204bktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRVJsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJSHBsY204S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHTnZibk4wSUdselJHVndiM05wZEdWa0lEMGdkR2hwY3k1a1pYQnZjMmwwYjNKektIQmhlVlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSEIxWW14cFl5QmtaWEJ2YzJsMGIzSnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNka1pYQnZjMmwwYjNKekp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaR1Z3YjNOcGRHOXljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCamIyNXpkQ0JwYzBSbGNHOXphWFJsWkNBOUlIUm9hWE11WkdWd2IzTnBkRzl5Y3lod1lYbFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2FXWWdLR2x6UkdWd2IzTnBkR1ZrS1NCN0NpQWdJQ0JpZWlCa1pYQnZjMmwwWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBhR2x6TG1SbGNHOXphWFJ2Y25Nb2NHRjVWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdLejBnWkdWd2IzTnBkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2dwa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhCMVlteHBZeUJuYVhSb2RXSWdQU0JDYjNnOGMzUnlhVzVuUGloN0lHdGxlVG9nSjJkcGRHaDFZa2hoYm1Sc1pTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbWRwZEdoMVlraGhibVJzWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklIUm9hWE11WjJsMGFIVmlMblpoYkhWbElEMGdaMmwwYUhWaVNHRnVaR3hsQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIQjFZbXhwWXlCbmFYUm9kV0lnUFNCQ2IzZzhjM1J5YVc1blBpaDdJR3RsZVRvZ0oyZHBkR2gxWWtoaGJtUnNaU2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1kcGRHaDFZa2hoYm1Sc1pTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJSFJvYVhNdVoybDBhSFZpTG5aaGJIVmxJRDBnWjJsMGFIVmlTR0Z1Wkd4bENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1SbGNHOXphWFJ2Y25Nb2NHRjVWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbVJsY0c5emFYUmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbVJsY0c5emFYUnZjbk1vY0dGNVZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmtaWEJ2YzJsMFFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHSWdaR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURNS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUVpYSnpiMjVoYkVKaGJtc3VkMmwwYUdSeVlYY29LU0F0UGlCMWFXNTBOalE2Q25kcGRHaGtjbUYzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbGNHOXphWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKMlJsY0c5emFYUnZjbk1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwYjNKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ1cyUmxjRzl6YVhSbFpFRnRiM1Z1ZEN3Z2FYTkVaWEJ2YzJsMFpXUmRJRDBnZEdocGN5NWtaWEJ2YzJsMGIzSnpLRlI0Ymk1elpXNWtaWElwTG0xaGVXSmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSEIxWW14cFl5QmtaWEJ2YzJsMGIzSnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNka1pYQnZjMmwwYjNKekp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCamIyNXpkQ0JiWkdWd2IzTnBkR1ZrUVcxdmRXNTBMQ0JwYzBSbGNHOXphWFJsWkYwZ1BTQjBhR2x6TG1SbGNHOXphWFJ2Y25Nb1ZIaHVMbk5sYm1SbGNpa3ViV0Y1WW1Vb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWVhOelpYSjBLR2x6UkdWd2IzTnBkR1ZrTENBblRtOGdaR1Z3YjNOcGRITWdabTkxYm1RZ1ptOXlJSFJvYVhNZ1lXTmpiM1Z1ZENjcENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1pHVndiM05wZEhNZ1ptOTFibVFnWm05eUlIUm9hWE1nWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTnkwMk13b2dJQ0FnTHk4Z1kyOXVjM1FnY21WemRXeDBJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmtaWEJ2YzJsMFpXUkJiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qSUtJQ0FnSUM4dklHTnZibk4wSUhKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2daR1Z3YjNOcGRHVmtRVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY3ROak1LSUNBZ0lDOHZJR052Ym5OMElISmxjM1ZzZENBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWkdWd2IzTnBkR1ZrUVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUhCMVlteHBZeUJrWlhCdmMybDBiM0p6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZGtaWEJ2YzJsMGIzSnpKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdWd2IzTnBkRzl5Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklIUm9hWE11WkdWd2IzTnBkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlEQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklIQjFZbXhwWXlCa1pYQnZjMmwwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RrWlhCdmMybDBiM0p6SnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxtUmxjRzl6YVhSdmNuTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGMzVnNkQzVoYlc5MWJuUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUF3cGtaWEJ2YzJsMGIzSnpCQlVmZkhVTVoybDBhSFZpU0dGdVpHeGxNUnRCQUVtQ0FnVFlJdi92QkRvNVh5czJHZ0NPQWdBVEFBSWpRekVaRkVReEdFU0lBSG9XS1V4UXNDSkRNUmtVUkRFWVJERVdJZ2xKT0JBaUVrUTJHZ0ZYQWdDSUFCSVdLVXhRc0NKRE1SbEEvOGN4R0JSRUlrT0tBZ0dML2pnSE1nb1NSSXYrT0FoSlJJditPQUFvVEZCSnZVVUJRUUFlaXdGSnZrd1hURVNMQUFnV3Z5cThTQ3FMLzcrTEFiNU1GMHhFakFDSml3QVdpd0ZNdjBMLzVTZ3hBRkMrVEJkTVJMRXhBTElIc2dnaXNoQWpzZ0d6dEFnb01RQlFJeGEvaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
