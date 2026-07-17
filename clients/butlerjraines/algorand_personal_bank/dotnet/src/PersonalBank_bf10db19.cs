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

namespace Arc56.Generated.butlerjraines.algorand_personal_bank.PersonalBank_bf10db19
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
        /// <param name="pay_txn">The payment transaction containing deposit information </param>
        public async Task<ulong> Deposit(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 50, 152, 231, 192 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 50, 152, 231, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVyc29uYWxCYW5rIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdHMgZnVuZHMgaW50byB0aGUgcGVyc29uYWwgYmFua1xuVGhpcyBtZXRob2QgYWNjZXB0cyBhIHBheW1lbnQgdHJhbnNhY3Rpb24gYW5kIHJlY29yZHMgdGhlIGRlcG9zaXQgYW1vdW50IGluIHRoZSBzZW5kZXIncyBCb3hNYXAuIElmIHRoZSBzZW5kZXIgYWxyZWFkeSBoYXMgYSBkZXBvc2l0LCB0aGUgYW1vdW50IGlzIGFkZGVkIHRvIHRoZWlyIGV4aXN0aW5nIGJhbGFuY2UuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY29udGFpbmluZyBkZXBvc2l0IGluZm9ybWF0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSB0b3RhbCBhbW91bnQgZGVwb3NpdGVkIGJ5IHRoZSBzZW5kZXIgYWZ0ZXIgdGhpcyB0cmFuc2FjdGlvbiAoYXMgVUludDY0KSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IldpdGhkcmF3cyBhbGwgZnVuZHMgZnJvbSB0aGUgc2VuZGVyJ3MgYWNjb3VudFxuVGhpcyBtZXRob2QgdHJhbnNmZXJzIHRoZSBlbnRpcmUgYmFsYW5jZSBvZiB0aGUgc2VuZGVyJ3MgYWNjb3VudCBiYWNrIHRvIHRoZW0sIGFuZCByZXNldHMgdGhlaXIgYmFsYW5jZSB0byB6ZXJvLiBUaGUgc2VuZGVyIG11c3QgaGF2ZSBhIGRlcG9zaXQgdG8gd2l0aGRyYXcuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgd2l0aGRyYXduIChhcyBVSW50NjQpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiTm8gZGVwb3NpdHMgZm91bmQgZm9yIHRoaXMgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzLDYwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1XSwiZXJyb3JNZXNzYWdlIjoiUmVjZWl2ZXIgbXVzdCBiZSB0aGUgY29udHJhY3QgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYsNjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwLDE0Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVwb3NpdG9ycyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjR1Z5YzI5dVlXeGZZbUZ1YXk1amIyNTBjbUZqZEM1UVpYSnpiMjVoYkVKaGJtc3VYMTloYkdkdmNIbGZaVzUwY25sd2IybHVkRjkzYVhSb1gybHVhWFFvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZCbGNuTnZibUZzUW1GdWF5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnek1qazRaVGRqTUNBd2VETmhNemsxWmpKaUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaHdZWGtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkeWdwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWtaWEJ2YzJsMFgzSnZkWFJsUURVZ2JXRnBibDkzYVhSb1pISmhkMTl5YjNWMFpVQTJDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklGQmxjbk52Ym1Gc1FtRnVheWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5M2FYUm9aSEpoZDE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlIZHBkR2hrY21GM0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSbGNHOXphWFJmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVUdWeWMyOXVZV3hDWVc1cktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pFMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWkdWd2IzTnBkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklGQmxjbk52Ym1Gc1FtRnVheWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d1pYSnpiMjVoYkY5aVlXNXJMbU52Ym5SeVlXTjBMbEJsY25OdmJtRnNRbUZ1YXk1a1pYQnZjMmwwS0hCaGVWOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNVFV0TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR1JsY0c5emFYUW9jMlZzWml3Z2NHRjVYM1I0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklIQmhlVjkwZUc0dWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNXdlVG95T0Mwek1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQndZWGxmZEhodUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pTWldObGFYWmxjaUJ0ZFhOMElHSmxJSFJvWlNCamIyNTBjbUZqZENCaFpHUnlaWE56SWdvZ0lDQWdZWE56WlhKMElDOHZJRkpsWTJWcGRtVnlJRzExYzNRZ1ltVWdkR2hsSUdOdmJuUnlZV04wSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1aGJXOTFiblFnUGlBd0xDQWlSR1Z3YjNOcGRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5YnlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaWEJ2YzJsMElHRnRiM1Z1ZENCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQjZaWEp2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdaR1Z3YjNOcGRGOWhiWFFzSUdSbGNHOXphWFJsWkNBOUlITmxiR1l1WkdWd2IzTnBkRzl5Y3k1dFlYbGlaU2h3WVhsZmRIaHVMbk5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxjbk52Ym1Gc1gySmhibXN2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHbG1JR1JsY0c5emFYUmxaRG9LSUNBZ0lHSjZJR1JsY0c5emFYUmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaWEp6YjI1aGJGOWlZVzVyTDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QnpaV3htTG1SbGNHOXphWFJ2Y25OYmNHRjVYM1I0Ymk1elpXNWtaWEpkSUNzOUlIQmhlVjkwZUc0dVlXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrWlhCdmMybDBiM0p6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1SbGNHOXphWFJ2Y25OYmNHRjVYM1I0Ymk1elpXNWtaWEpkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWd2IzTnBkRzl5Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BrWlhCdmMybDBYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsY25OdmJtRnNYMkpoYm1zdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEc5eWMxdHdZWGxmZEhodUxuTmxibVJsY2wwZ1BTQndZWGxmZEhodUxtRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJR1JsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBekNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJsY25OdmJtRnNYMkpoYm1zdVkyOXVkSEpoWTNRdVVHVnljMjl1WVd4Q1lXNXJMbmRwZEdoa2NtRjNLQ2tnTFQ0Z2RXbHVkRFkwT2dwM2FYUm9aSEpoZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJrWlhCdmMybDBYMkZ0ZEN3Z1pHVndiM05wZEdWa0lEMGdjMlZzWmk1a1pYQnZjMmwwYjNKekxtMWhlV0psS0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWeWMyOXVZV3hmWW1GdWF5OWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnWVhOelpYSjBJR1JsY0c5emFYUmxaQ3dnSWs1dklHUmxjRzl6YVhSeklHWnZkVzVrSUdadmNpQjBhR2x6SUdGalkyOTFiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWkdWd2IzTnBkSE1nWm05MWJtUWdabTl5SUhSb2FYTWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbGNuTnZibUZzWDJKaGJtc3ZZMjl1ZEhKaFkzUXVjSGs2TlRVdE5Ua0tJQ0FnSUM4dklISmxjM1ZzZENBOUlHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWtaWEJ2YzJsMFgyRnRkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pYSnpiMjVoYkY5aVlXNXJMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPalUxTFRVNUNpQWdJQ0F2THlCeVpYTjFiSFFnUFNCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVpHVndiM05wZEY5aGJYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WlhKemIyNWhiRjlpWVc1ckwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJ6Wld4bUxtUmxjRzl6YVhSdmNuTmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1Z5YzI5dVlXeGZZbUZ1YXk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdjbVYwZFhKdUlISmxjM1ZzZEM1aGJXOTFiblFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUFRUVZIM3gxTVJ0QkFFT0NBZ1F5bU9mQUJEbzVYeXMyR2dDT0FnQVRBQUlqUXpFWkZFUXhHRVNJQUdvV0tFeFFzQ0pETVJrVVJERVlSREVXSWdsSk9CQWlFa1NJQUJJV0tFeFFzQ0pETVJsQS84MHhHQlJFSWtPS0FRR0wvemdITWdvU1JJdi9PQWhKUkl2L09BQkp2a1VCUVFBWGl3Rkp2a3dYVEVTTEFBZ1d2NHNCdmt3WFRFU01BSW1MQUJhTEFVeS9Rdi9zTVFDK1RCZE1STEV4QUxJSHNnZ2lzaEFqc2dHenRBZ3hBQ01XdjRrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
