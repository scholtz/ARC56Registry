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

namespace Arc56.Generated.joeesteves.algorand_typescript_workshop.PersonalBank_9553664b
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
        /// <param name="githubHandle"> </param>
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVyc29uYWxCYW5rIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdHMgZnVuZHMgaW50byB0aGUgcGVyc29uYWwgYmFuay5cblRoZSBkZXBvc2l0IGFtb3VudCBpcyByZWNvcmRlZCBpbiB0aGUgc2VuZGVyJ3MgQm94TWFwLlxuSWYgdGhlIHNlbmRlciBhbHJlYWR5IGhhcyBhIGRlcG9zaXQsIHRoZSBhbW91bnQgaXMgYWRkZWQgdG8gdGhlaXIgZXhpc3RpbmcgYmFsYW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5VHhuIiwiZGVzYyI6Ii0gVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY29udGFpbmluZyBkZXBvc2l0IGluZm9ybWF0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnaXRodWJIYW5kbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHRvdGFsIGFtb3VudCBkZXBvc2l0ZWQgYnkgdGhlIHNlbmRlciBhZnRlciB0aGlzIHRyYW5zYWN0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXdzIGFsbCBmdW5kcyBmcm9tIHRoZSBzZW5kZXIncyBhY2NvdW50LlxuVGhpcyBtZXRob2QgdHJhbnNmZXJzIHRoZSBlbnRpcmUgYmFsYW5jZSBvZiB0aGUgc2VuZGVyJ3MgYWNjb3VudCBiYWNrIHRvIHRoZW0sXG5hbmQgcmVzZXRzIHRoZWlyIGJhbGFuY2UgdG8gemVyby4gVGhlIHNlbmRlciBtdXN0IGhhdmUgYSBkZXBvc2l0IHRvIHdpdGhkcmF3LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYW1vdW50IHdpdGhkcmF3biAoYXMgVUludDY0KSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTUxLDE2M10sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoiTm8gZGVwb3NpdHMgZm91bmQgZm9yIHRoaXMgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0LDcxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyXSwiZXJyb3JNZXNzYWdlIjoiUmVjZWl2ZXIgbXVzdCBiZSB0aGUgY29udHJhY3QgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3LDc0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmtaWEJ2YzJsMGIzSnpJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVR1Z5YzI5dVlXeENZVzVySUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoa09ESXlabVpsWmlBd2VETmhNemsxWmpKaUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaHdZWGtzYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpHVndiM05wZEY5eWIzVjBaVUF6SUcxaGFXNWZkMmwwYUdSeVlYZGZjbTkxZEdWQU5Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJsY25OdmJtRnNRbUZ1YXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZDJsMGFHUnlZWGRmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJSGRwZEdoa2NtRjNDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxjRzl6YVhSZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHVnljMjl1WVd4Q1lXNXJJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdSbGNHOXphWFFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUdWeWMyOXVZV3hDWVc1cklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRWlhKemIyNWhiRUpoYm1zdVpHVndiM05wZENod1lYbFVlRzQ2SUhWcGJuUTJOQ3dnWjJsMGFIVmlTR0Z1Wkd4bE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGtaWEJ2YzJsME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUzB5TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWkdWd2IzTnBkQ2h3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2daMmwwYUhWaVNHRnVaR3hsT2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVZSNGJpNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ2RTWldObGFYWmxjaUJ0ZFhOMElHSmxJSFJvWlNCamIyNTBjbUZqZENCaFpHUnlaWE56SnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkpsWTJWcGRtVnlJRzExYzNRZ1ltVWdkR2hsSUdOdmJuUnlZV04wSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsVWVHNHVZVzF2ZFc1MElENGdNQ3dnSjBSbGNHOXphWFFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOG5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVSbGNHOXphWFFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR052Ym5OMElHbHpSR1Z3YjNOcGRHVmtJRDBnZEdocGN5NWtaWEJ2YzJsMGIzSnpLSEJoZVZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0c5emFYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyUmxjRzl6YVhSdmNuTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWlhCdmMybDBiM0p6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHTnZibk4wSUdselJHVndiM05wZEdWa0lEMGdkR2hwY3k1a1pYQnZjMmwwYjNKektIQmhlVlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QnBaaUFvYVhORVpYQnZjMmwwWldRcElIc0tJQ0FnSUdKNklHUmxjRzl6YVhSZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSFJvYVhNdVpHVndiM05wZEc5eWN5aHdZWGxVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0FyUFNCa1pYQnZjMmwwUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaR1Z3YjNOcGRHOXljeWh3WVhsVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSFJvYVhNdVpHVndiM05wZEc5eWN5aHdZWGxVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdSbGNHOXphWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdjSFZpYkdsaklHZHBkR2gxWWlBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCemRISnBibWMrS0hzZ2EyVjVVSEpsWm1sNE9pQW5aMmwwYUhWaUp5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSm5hWFJvZFdJaUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QjBhR2x6TG1kcGRHaDFZaWh3WVhsVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHZHBkR2gxWWtoaGJtUnNaUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZaUJrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQmxjbk52Ym1Gc1FtRnVheTUzYVhSb1pISmhkeWdwSUMwK0lIVnBiblEyTkRvS2QybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QndkV0pzYVdNZ1pHVndiM05wZEc5eWN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWkdWd2IzTnBkRzl5Y3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmxjRzl6YVhSdmNuTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJqYjI1emRDQmJaR1Z3YjNOcGRHVmtRVzF2ZFc1MExDQnBjMFJsY0c5emFYUmxaRjBnUFNCMGFHbHpMbVJsY0c5emFYUnZjbk1vVkhodUxuTmxibVJsY2lrdWJXRjVZbVVvS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0c5emFYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyUmxjRzl6YVhSdmNuTW5JSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHTnZibk4wSUZ0a1pYQnZjMmwwWldSQmJXOTFiblFzSUdselJHVndiM05wZEdWa1hTQTlJSFJvYVhNdVpHVndiM05wZEc5eWN5aFVlRzR1YzJWdVpHVnlLUzV0WVhsaVpTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCaGMzTmxjblFvYVhORVpYQnZjMmwwWldRc0lDZE9ieUJrWlhCdmMybDBjeUJtYjNWdVpDQm1iM0lnZEdocGN5QmhZMk52ZFc1MEp5a0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmtaWEJ2YzJsMGN5Qm1iM1Z1WkNCbWIzSWdkR2hwY3lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMExUWXdDaUFnSUNBdkx5QmpiMjV6ZENCeVpYTjFiSFFnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR1JsY0c5emFYUmxaRUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5DMDFPUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVnpkV3gwSUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJrWlhCdmMybDBaV1JCYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJR1psWlRvZ01Dd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQzAyTUFvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6ZFd4MElEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCa1pYQnZjMmwwWldSQmJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbGNHOXphWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKMlJsY0c5emFYUnZjbk1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwYjNKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdkR2hwY3k1a1pYQnZjMmwwYjNKektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdNQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjSFZpYkdsaklHUmxjRzl6YVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjJSbGNHOXphWFJ2Y25NbklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhSb2FYTXVaR1Z3YjNOcGRHOXljeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnpkV3gwTG1GdGIzVnVkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BZ3BrWlhCdmMybDBiM0p6QkJVZmZIVXhHMEVBU1lJQ0JOZ2kvKzhFT2psZkt6WWFBSTRDQUJNQUFpTkRNUmtVUkRFWVJJZ0FoUllwVEZDd0lrTXhHUlJFTVJoRU1SWWlDVWs0RUNJU1JEWWFBVmNDQUlnQUVoWXBURkN3SWtNeEdVRC94ekVZRkVRaVE0b0NBWXYrT0FjeUNoSkVpLzQ0Q0VsRWkvNDRBRWtvVEZCSnZVVUJRUUFYaXdKSnZrd1hURVNMQUFnV3Y0c0N2a3dYVEVTTUFJbUxBQmFMQWt5L2dBWm5hWFJvZFdLTEFWQkp2RWlMLzc5Qy85c29NUUJRdmt3WFRFU3hNUUN5QjdJSUlySVFJN0lCczdRSUtERUFVQ01XdjRrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
