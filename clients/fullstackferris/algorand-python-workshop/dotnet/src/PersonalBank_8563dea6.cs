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

namespace Arc56.Generated.fullstackferris.algorand_python_workshop.PersonalBank_8563dea6
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
        ///Deposits funds into the personal bank
        ///This method accepts a payment transaction and records the deposit amount in the sender's BoxMap. If the sender already has a deposit, the amount is added to their existing balance.
        ///</summary>
        /// <param name="github_handle"> </param>
        /// <param name="pay_txn">The payment transaction containing deposit information </param>
        public async Task<ulong> Deposit(PaymentTransaction pay_txn, string github_handle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var github_handleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); github_handleAbi.From(github_handle);

            var result = await base.CallApp(new List<object> { abiHandle, github_handleAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction pay_txn, string github_handle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 89, 124, 50 };
            var github_handleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); github_handleAbi.From(github_handle);

            return await base.MakeTransactionList(new List<object> { abiHandle, github_handleAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraws all funds from the sender's account
        ///This method transfers the entire balance of the sender's account back to them, and resets their balance to zero. The sender must have a deposit to withdraw.
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVyc29uYWxCYW5rIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdHMgZnVuZHMgaW50byB0aGUgcGVyc29uYWwgYmFua1xuVGhpcyBtZXRob2QgYWNjZXB0cyBhIHBheW1lbnQgdHJhbnNhY3Rpb24gYW5kIHJlY29yZHMgdGhlIGRlcG9zaXQgYW1vdW50IGluIHRoZSBzZW5kZXIncyBCb3hNYXAuIElmIHRoZSBzZW5kZXIgYWxyZWFkeSBoYXMgYSBkZXBvc2l0LCB0aGUgYW1vdW50IGlzIGFkZGVkIHRvIHRoZWlyIGV4aXN0aW5nIGJhbGFuY2UuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdpdGh1Yl9oYW5kbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY29udGFpbmluZyBkZXBvc2l0IGluZm9ybWF0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSB0b3RhbCBhbW91bnQgZGVwb3NpdGVkIGJ5IHRoZSBzZW5kZXIgYWZ0ZXIgdGhpcyB0cmFuc2FjdGlvbiAoYXMgVUludDY0KSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IldpdGhkcmF3cyBhbGwgZnVuZHMgZnJvbSB0aGUgc2VuZGVyJ3MgYWNjb3VudFxuVGhpcyBtZXRob2QgdHJhbnNmZXJzIHRoZSBlbnRpcmUgYmFsYW5jZSBvZiB0aGUgc2VuZGVyJ3MgYWNjb3VudCBiYWNrIHRvIHRoZW0sIGFuZCByZXNldHMgdGhlaXIgYmFsYW5jZSB0byB6ZXJvLiBUaGUgc2VuZGVyIG11c3QgaGF2ZSBhIGRlcG9zaXQgdG8gd2l0aGRyYXcuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgd2l0aGRyYXduIChhcyBVSW50NjQpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzFdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyXSwiZXJyb3JNZXNzYWdlIjoiTm8gZGVwb3NpdHMgZm91bmQgZm9yIHRoaXMgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwLDY3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1XSwiZXJyb3JNZXNzYWdlIjoiUmVjZWl2ZXIgbXVzdCBiZSB0aGUgY29udHJhY3QgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzLDcwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwxNjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRlcG9zaXRvcnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0dWeWMyOXVZV3hmWW1GdWF5NWpiMjUwY21GamRDNVFaWEp6YjI1aGJFSmhibXN1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZzJOelk1TnpRMk9EYzFOaklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZCbGNuTnZibUZzUW1GdWF5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNVpqVTVOMk16TWlBd2VETmhNemsxWmpKaUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaHpkSEpwYm1jc2NHRjVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpHVndiM05wZEY5eWIzVjBaVUExSUcxaGFXNWZkMmwwYUdSeVlYZGZjbTkxZEdWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCUVpYSnpiMjVoYkVKaGJtc29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZDJsMGFHUnlZWGRmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCM2FYUm9aSEpoZHdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWlhCdmMybDBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRkJsY25OdmJtRnNRbUZ1YXloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmtaWEJ2YzJsMENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVUdWeWMyOXVZV3hDWVc1cktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJsY25OdmJtRnNYMkpoYm1zdVkyOXVkSEpoWTNRdVVHVnljMjl1WVd4Q1lXNXJMbVJsY0c5emFYUW9aMmwwYUhWaVgyaGhibVJzWlRvZ1lubDBaWE1zSUhCaGVWOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNVFl0TVRjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR1JsY0c5emFYUW9jMlZzWml3Z1oybDBhSFZpWDJoaGJtUnNaVG9nVTNSeWFXNW5JQ3h3WVhsZmRIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWNtRnVjMkZqZEdsdmJpa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnYzJWc1ppNW5hWFJvZFdKZlltOTRMblpoYkhWbElEMGdaMmwwYUhWaVgyaGhibVJzWlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZM05qazNORFk0TnpVMk1nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROamMyT1RjME5qZzNOVFl5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJ3WVhsZmRIaHVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk16SXRNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVgzUjRiaTV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENBaVVtVmpaV2wyWlhJZ2JYVnpkQ0JpWlNCMGFHVWdZMjl1ZEhKaFkzUWdZV1JrY21WemN5SUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXTmxhWFpsY2lCdGRYTjBJR0psSUhSb1pTQmpiMjUwY21GamRDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVZVzF2ZFc1MElENGdNQ3dnSWtSbGNHOXphWFFnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnUkdWd2IzTnBkQ0JoYlc5MWJuUWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TXpjS0lDQWdJQzh2SUdSbGNHOXphWFJmWVcxMExDQmtaWEJ2YzJsMFpXUWdQU0J6Wld4bUxtUmxjRzl6YVhSdmNuTXViV0Y1WW1Vb2NHRjVYM1I0Ymk1elpXNWtaWElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPak01Q2lBZ0lDQXZMeUJwWmlCa1pYQnZjMmwwWldRNkNpQWdJQ0JpZWlCa1pYQnZjMmwwWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnYzJWc1ppNWtaWEJ2YzJsMGIzSnpXM0JoZVY5MGVHNHVjMlZ1WkdWeVhTQXJQU0J3WVhsZmRIaHVMbUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVndiM05wZEc5eWN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDZ3BrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWtaWEJ2YzJsMGIzSnpXM0JoZVY5MGVHNHVjMlZ1WkdWeVhRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSdmNuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCelpXeG1MbVJsY0c5emFYUnZjbk5iY0dGNVgzUjRiaTV6Wlc1a1pYSmRJRDBnY0dGNVgzUjRiaTVoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d1pYSnpiMjVoYkY5aVlXNXJMbU52Ym5SeVlXTjBMbEJsY25OdmJtRnNRbUZ1YXk1M2FYUm9aSEpoZHlncElDMCtJSFZwYm5RMk5Eb0tkMmwwYUdSeVlYYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z1pHVndiM05wZEY5aGJYUXNJR1JsY0c5emFYUmxaQ0E5SUhObGJHWXVaR1Z3YjNOcGRHOXljeTV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCa1pYQnZjMmwwWldRc0lDSk9ieUJrWlhCdmMybDBjeUJtYjNWdVpDQm1iM0lnZEdocGN5QmhZMk52ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHUmxjRzl6YVhSeklHWnZkVzVrSUdadmNpQjBhR2x6SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qVTVMVFl6Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WkdWd2IzTnBkRjloYlhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z2NtVnpkV3gwSUQwZ2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMU9TMDJNd29nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV1JsY0c5emFYUmZZVzEwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVnljMjl1WVd4ZlltRnVheTlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2MyVnNaaTVrWlhCdmMybDBiM0p6VzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUhKbGRIVnliaUJ5WlhOMWJIUXVZVzF2ZFc1MENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BZ1FWSDN4MUJtZHBkR2gxWWpFYlFRQkpnZ0lFbjFsOE1nUTZPVjhyTmhvQWpnSUFFd0FDSTBNeEdSUkVNUmhFaUFCM0ZpaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQXhGaUlKU1RnUUloSkVpQUFTRmloTVVMQWlRekVaUVAvSE1SZ1VSQ0pEaWdJQktieElLWXYrdjR2L09BY3lDaEpFaS84NENFbEVpLzg0QUVtK1JRRkJBQmVMQVVtK1RCZE1SSXNBQ0JhL2l3RytUQmRNUkl3QWlZc0FGb3NCVEw5Qy8rd3hBTDVNRjB4RXNURUFzZ2V5Q0NLeUVDT3lBYk8wQ0RFQUl4YS9pUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
