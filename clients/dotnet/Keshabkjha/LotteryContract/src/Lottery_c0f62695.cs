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

namespace Arc56.Generated.Keshabkjha.LotteryContract.Lottery_c0f62695
{


    public class LotteryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LotteryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the lottery contract with an entry fee.
        ///</summary>
        /// <param name="entry_fee"> </param>
        public async Task CreateApplication(ulong entry_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 59, 129, 210 };
            var entry_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_feeAbi.From(entry_fee);

            var result = await base.CallApp(new List<object> { abiHandle, entry_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong entry_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 59, 129, 210 };
            var entry_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); entry_feeAbi.From(entry_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, entry_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow users to enter the lottery by sending the entry fee.
        ///</summary>
        /// <param name="payment_txn"> </param>
        public async Task EnterLottery(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 135, 234, 73, 215 };

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EnterLottery_Transactions(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 135, 234, 73, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the contract creator to randomly pick a winner.
        ///</summary>
        public async Task PickWinner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 11, 222, 191 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PickWinner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 11, 222, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allows the creator to delete the application.
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 179, 73, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 179, 73, 158 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG90dGVyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYXBwbGljYXRpb24iLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgbG90dGVyeSBjb250cmFjdCB3aXRoIGFuIGVudHJ5IGZlZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW50cnlfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVudGVyX2xvdHRlcnkiLCJkZXNjIjoiQWxsb3cgdXNlcnMgdG8gZW50ZXIgdGhlIGxvdHRlcnkgYnkgc2VuZGluZyB0aGUgZW50cnkgZmVlLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwaWNrX3dpbm5lciIsImRlc2MiOiJBbGxvd3MgdGhlIGNvbnRyYWN0IGNyZWF0b3IgdG8gcmFuZG9tbHkgcGljayBhIHdpbm5lci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6IkFsbG93cyB0aGUgY3JlYXRvciB0byBkZWxldGUgdGhlIGFwcGxpY2F0aW9uLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgRGVsZXRlQXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDgsMTIwLDE0Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNl0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTksMTExLDEyM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDcsMjU5LDI2NiwyNzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWF0b3JfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVudHJ5X2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTUsMjEzLDIyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZW50cmllcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTVRBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVkzSmxZWFJ2Y2w5aFpHUnlaWE56SWlBaWRHOTBZV3hmWlc1MGNtbGxjeUlnSW1WdWRISjVYMlpsWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjNSMFpYSjVMMk52Ym5SeVlXTjBMbkI1T2pFeUxURXpDaUFnSUNBdkx5QWpJRmRsSUhkaGJuUWdkR2hsSUcxbGRHaHZaSE1nYVc0Z2IzVnlJR052Ym5SeVlXTjBJSFJ2SUdadmJHeHZkeUIwYUdVZ1FWSkROQ0J6ZEdGdVpHRnlaQW9nSUNBZ0x5OGdZMnhoYzNNZ1RHOTBkR1Z5ZVNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdFd00ySTRNV1F5SURCNE9EZGxZVFE1WkRjZ01IaGlaVEJpWkdWaVppQXdlRE16WWpNME9UbGxJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmxiblJsY2w5c2IzUjBaWEo1S0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKd2FXTnJYM2RwYm01bGNpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsWDJGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgyVnVkR1Z5WDJ4dmRIUmxjbmxmY205MWRHVkFOQ0J0WVdsdVgzQnBZMnRmZDJsdWJtVnlYM0p2ZFhSbFFEVWdiV0ZwYmw5a1pXeGxkR1ZmWVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZNVEl0TVRNS0lDQWdJQzh2SUNNZ1YyVWdkMkZ1ZENCMGFHVWdiV1YwYUc5a2N5QnBiaUJ2ZFhJZ1kyOXVkSEpoWTNRZ2RHOGdabTlzYkc5M0lIUm9aU0JCVWtNMElITjBZVzVrWVhKa0NpQWdJQ0F2THlCamJHRnpjeUJNYjNSMFpYSjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSbGJHVjBaVjloY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2ZEhSbGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RJdE9EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNnS0lDQWdJQzh2SUNBZ0lDQmhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhRb2dJQ0FnTHk4Z0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCa1pXeGxkR1ZmWVhCd2JHbGpZWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY0dsamExOTNhVzV1WlhKZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjNSMFpYSjVMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCd2FXTnJYM2RwYm01bGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bGJuUmxjbDlzYjNSMFpYSjVYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOTBkR1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjNSMFpYSjVMMk52Ym5SeVlXTjBMbkI1T2pFeUxURXpDaUFnSUNBdkx5QWpJRmRsSUhkaGJuUWdkR2hsSUcxbGRHaHZaSE1nYVc0Z2IzVnlJR052Ym5SeVlXTjBJSFJ2SUdadmJHeHZkeUIwYUdVZ1FWSkROQ0J6ZEdGdVpHRnlaQW9nSUNBZ0x5OGdZMnhoYzNNZ1RHOTBkR1Z5ZVNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5MGRHVnllUzlqYjI1MGNtRmpkQzV3ZVRvek9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHVnVkR1Z5WDJ4dmRIUmxjbmtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOTBkR1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3lNeTB5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaXdLSUNBZ0lDOHZJQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG94TWkweE13b2dJQ0FnTHk4Z0l5QlhaU0IzWVc1MElIUm9aU0J0WlhSb2IyUnpJR2x1SUc5MWNpQmpiMjUwY21GamRDQjBieUJtYjJ4c2IzY2dkR2hsSUVGU1F6UWdjM1JoYm1SaGNtUUtJQ0FnSUM4dklHTnNZWE56SUV4dmRIUmxjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IzUjBaWEo1TDJOdmJuUnlZV04wTG5CNU9qSXpMVEkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9DaUFnSUNBdkx5QWdJQ0FnWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzkwZEdWeWVTNWpiMjUwY21GamRDNU1iM1IwWlhKNUxtTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJpaGxiblJ5ZVY5bVpXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZNak10TXpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dLSUNBZ0lDOHZJQ0FnSUNCaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQXZMeUJrWldZZ1kzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdaVzUwY25sZlptVmxPaUJWU1c1ME5qUXNJQ0FqSUZSb1pTQmxiblJ5ZVNCbVpXVWdjbVZ4ZFdseVpXUWdkRzhnY0dGeWRHbGphWEJoZEdVZ2FXNGdkR2hsSUd4dmRIUmxjbmtLSUNBZ0lDOHZJQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dmRIUmxjbmt2WTI5dWRISmhZM1F1Y0hrNk16UXRNelVLSUNBZ0lDOHZJQ01nU1c1cGRHbGhiR2w2WlNCMGFHVWdaVzUwY25rZ1ptVmxJR0Z1WkNCamNtVmhkRzl5SUdGa1pISmxjM01nYVc0Z2RHaGxJR052Ym5SeVlXTjBKM01nYzNSaGRHVUtJQ0FnSUM4dklITmxiR1l1Wlc1MGNubGZabVZsSUQwZ1pXNTBjbmxmWm1WbENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbGJuUnllVjltWldVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5MGRHVnllUzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z2MyVnNaaTVqY21WaGRHOXlYMkZrWkhKbGMzTWdQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamNtVmhkRzl5WDJGa1pISmxjM01pQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5bGJuUnlhV1Z6SUQwZ1ZVbHVkRFkwS0RBcElDQWpJRWx1YVhScFlXeHBlbVVnZEdobElIUnZkR0ZzSUc1MWJXSmxjaUJ2WmlCbGJuUnlhV1Z6SUhSdklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJWdWRISnBaWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiM1IwWlhKNUxtTnZiblJ5WVdOMExreHZkSFJsY25rdVpXNTBaWEpmYkc5MGRHVnllU2h3WVhsdFpXNTBYM1I0YmpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwbGJuUmxjbDlzYjNSMFpYSjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZNemt0TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdWdWRHVnlYMnh2ZEhSbGNua29jMlZzWml3Z2NHRjViV1Z1ZEY5MGVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG8wTkMwME5Rb2dJQ0FnTHk4Z0l5QkZibk4xY21VZ2RHaGhkQ0IwYUdVZ2NHRjViV1Z1ZENCcGN5QnpaVzUwSUhSdklIUm9aU0JoY0hCc2FXTmhkR2x2YmlCaFpHUnlaWE56Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRGOTBlRzR1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjNSMFpYSjVMMk52Ym5SeVlXTjBMbkI1T2pRM0xUUTRDaUFnSUNBdkx5QWpJQ01nUlc1emRYSmxJSFJvWVhRZ2RHaGxJSEJoZVcxbGJuUWdZVzF2ZFc1MEtHMXBZM0p2WVd4bmJ5a2dhWE1nWlhGMVlXd2dkRzhnZEdobElHVnVkSEo1SUdabFpRb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblJmZEhodUxtRnRiM1Z1ZENBOVBTQnpaV3htTG1WdWRISjVYMlpsWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmxiblJ5ZVY5bVpXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wlc1MGNubGZabVZsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWlc1MGNtbGxjeUFyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOWxiblJ5YVdWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyVnVkSEpwWlhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmWlc1MGNtbGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzkwZEdWeWVTNWpiMjUwY21GamRDNU1iM1IwWlhKNUxuQnBZMnRmZDJsdWJtVnlLQ2tnTFQ0Z2RtOXBaRG9LY0dsamExOTNhVzV1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5MGRHVnllUzlqYjI1MGNtRmpkQzV3ZVRvMU55MDFPQW9nSUNBZ0x5OGdJeUFqSUVWdWMzVnlaU0IwYUdGMElHOXViSGtnZEdobElHTnlaV0YwYjNJZ1kyRnVJR05oYkd3Z2RHaHBjeUJtZFc1amRHbHZiZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpjbVZoZEc5eVgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNsOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2ZEhSbGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpBdE5qRUtJQ0FnSUM4dklDTWdSVzV6ZFhKbElIUm9aWEpsSUdseklHRjBJR3hsWVhOMElHOXVaU0J3WVhKMGFXTnBjR0Z1ZEFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWRHOTBZV3hmWlc1MGNtbGxjeUErSUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyVnVkSEpwWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZlpXNTBjbWxsY3lCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2ZEhSbGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpNdE5qUUtJQ0FnSUM4dklDTWdVMmx0Y0d4bElIQnpaWFZrYnkxeVlXNWtiMjBnYm5WdFltVnlJR2RsYm1WeVlYUnZjaUIxYzJsdVp5QnliM1Z1WkNCaGJtUWdhVzVrWlhnS0lDQWdJQzh2SUhKdmRXNWtYMjUxYldKbGNpQTlJRWRzYjJKaGJDNXliM1Z1WkFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnWjNKdmRYQmZjMmw2WlNBOUlFZHNiMkpoYkM1bmNtOTFjRjl6YVhwbENpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOTBkR1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzJOeTAyT0FvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2NITmxkV1J2TFhKaGJtUnZiU0JwYm1SbGVDQmlZWE5sWkNCdmJpQnliM1Z1WkNCdWRXMWlaWElnWVc1a0lHZHliM1Z3SUhOcGVtVUtJQ0FnSUM4dklISmhibVJ2YlY5dWRXMWlaWElnUFNCeWIzVnVaRjl1ZFcxaVpYSWdKU0J6Wld4bUxuUnZkR0ZzWDJWdWRISnBaWE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5bGJuUnlhV1Z6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJWdWRISnBaWE1nWlhocGMzUnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJQ1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiM1IwWlhKNUwyTnZiblJ5WVdOMExuQjVPamN3TFRjeENpQWdJQ0F2THlBaklFZGxkQ0IwYUdVZ2QybHVibVZ5SjNNZ1lXUmtjbVZ6Y3lCbWNtOXRJSFJvWlNCMGNtRnVjMkZqZEdsdmJpQmhkQ0IwYUdVZ1kyRnNZM1ZzWVhSbFpDQnBibVJsZUFvZ0lDQWdMeThnZDJsdWJtVnlYMmx1WkdWNElEMGdjbUZ1Wkc5dFgyNTFiV0psY2lBbElHZHliM1Z3WDNOcGVtVUtJQ0FnSUhOM1lYQUtJQ0FnSUNVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjNSMFpYSjVMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCM2FXNXVaWEpmWVdSa2NtVnpjeUE5SUdkMGVHNHVWSEpoYm5OaFkzUnBiMjRvZDJsdWJtVnlYMmx1WkdWNEtTNXpaVzVrWlhJS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2ZEhSbGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpRdE9EQUtJQ0FnSUM4dklDTWdhWFI0Ymk1bVpXVW9WVWx1ZERZMEtERXdNREFwS1FvZ0lDQWdMeThnSXlCVWNtRnVjMlpsY2lCaGJHd2dRVXhIVDNNZ1kyOXNiR1ZqZEdWa0lIUnZJSFJvWlNCM2FXNXVaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1aVlXeGhibU5sSUMwZ1ZVbHVkRFkwS0RFd01GOHdNRjh3TUNrc0lDTWdNU0JCYkdkdklEMGdNVEF3TURBd01DQnRhV055YjJGc1oyOXpDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5ZDJsdWJtVnlYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLUW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dmRIUmxjbmt2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklHRnRiM1Z1ZEQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG1KaGJHRnVZMlVnTFNCVlNXNTBOalFvTVRBd1h6QXdYekF3S1N3Z0l5QXhJRUZzWjI4Z1BTQXhNREF3TURBd0lHMXBZM0p2WVd4bmIzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdJQzh2SURFd01EQXdNREFLSUNBZ0lDMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOTBkR1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzNOQzAzTmdvZ0lDQWdMeThnSXlCcGRIaHVMbVpsWlNoVlNXNTBOalFvTVRBd01Da3BDaUFnSUNBdkx5QWpJRlJ5WVc1elptVnlJR0ZzYkNCQlRFZFBjeUJqYjJ4c1pXTjBaV1FnZEc4Z2RHaGxJSGRwYm01bGNnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dmRIUmxjbmt2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NVEF3TUNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dmRIUmxjbmt2WTI5dWRISmhZM1F1Y0hrNk56UXRPREFLSUNBZ0lDOHZJQ01nYVhSNGJpNW1aV1VvVlVsdWREWTBLREV3TURBcEtRb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQmhiR3dnUVV4SFQzTWdZMjlzYkdWamRHVmtJSFJ2SUhSb1pTQjNhVzV1WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NWlZV3hoYm1ObElDMGdWVWx1ZERZMEtERXdNRjh3TUY4d01Da3NJQ01nTVNCQmJHZHZJRDBnTVRBd01EQXdNQ0J0YVdOeWIyRnNaMjl6Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWQybHVibVZ5WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3hNREF3S1FvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiM1IwWlhKNUxtTnZiblJ5WVdOMExreHZkSFJsY25rdVpHVnNaWFJsWDJGd2NHeHBZMkYwYVc5dUtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFgyRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZPRGt0T1RBS0lDQWdJQzh2SUNNZ1QyNXNlU0JoYkd4dmR5QjBhR1VnWTNKbFlYUnZjaUIwYnlCa1pXeGxkR1VnZEdobElHRndjR3hwWTJGMGFXOXVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnlaV0YwYjNKZllXUmtjbVZ6Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZoZEc5eVgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG81TWkwNU9Bb2dJQ0FnTHk4Z0l5QlRaVzVrSUhSb1pTQnlaVzFoYVc1cGJtY2dZbUZzWVc1alpTQjBieUIwYUdVZ1kzSmxZWFJ2Y2dvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFgzSmxiV0ZwYm1SbGNsOTBiejF6Wld4bUxtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREV3TURBcENpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzkwZEdWeWVTOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnY21WalpXbDJaWEk5YzJWc1ppNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNKbFlYUnZjbDloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXRjBiM0pmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IzUjBaWEo1TDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QmpiRzl6WlY5eVpXMWhhVzVrWlhKZmRHODljMlZzWmk1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZM0psWVhSdmNsOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU55WldGMGIzSmZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4dmMyVlNaVzFoYVc1a1pYSlVid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJR0Z0YjNWdWREMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOTBkR1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzVNaTA1TXdvZ0lDQWdMeThnSXlCVFpXNWtJSFJvWlNCeVpXMWhhVzVwYm1jZ1ltRnNZVzVqWlNCMGJ5QjBhR1VnWTNKbFlYUnZjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTVRBd01Da0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZkSFJsY25rdlkyOXVkSEpoWTNRdWNIazZPVEl0T1RnS0lDQWdJQzh2SUNNZ1UyVnVaQ0IwYUdVZ2NtVnRZV2x1YVc1bklHSmhiR0Z1WTJVZ2RHOGdkR2hsSUdOeVpXRjBiM0lLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5TUN3S0lDQWdJQzh2SUNBZ0lDQmpiRzl6WlY5eVpXMWhhVzVrWlhKZmRHODljMlZzWmk1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3hNREF3S1FvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFIb0J5WUREMk55WldGMGIzSmZZV1JrY21WemN3MTBiM1JoYkY5bGJuUnlhV1Z6Q1dWdWRISjVYMlpsWlRFYlFRQWpnZ1FFb0R1QjBnU0g2a25YQkw0TDNyOEVNN05KbmpZYUFJNEVBRElBSEFBUUFBSWlRekVaZ1FVU1JERVlSSWdBbHlORE1Sa1VSREVZUklnQVZ5TkRNUmtVUkRFWVJERVdJd2xKT0JBakVrU0lBQ0lqUXpFWkZFUXhHQlJFTmhvQkY0Z0FBaU5EaWdFQUtvdi9aeWd5Q1djcEltZUppZ0VBaS84NEJ6SUtFa1NML3pnSUlpcGxSQkpFSWlsbFJDTUlLVXhuaVRFQUlpaGxSQkpFSWlsbFJFUXlCaklFSWlsbFJFOENUQmhNR0RnQXNUSUtjd0JFZ2NDRVBRbXlDTElISTdJUUpMSUJzNGt4QUNJb1pVUVNSTEVpS0dWRUlpaGxSTElKSXJJSXNnY2pzaEFrc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
