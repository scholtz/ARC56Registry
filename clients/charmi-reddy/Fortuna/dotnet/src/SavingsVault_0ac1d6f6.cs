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

namespace Arc56.Generated.charmi_reddy.Fortuna.SavingsVault_0ac1d6f6
{


    public class SavingsVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SavingsVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Deposit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 224, 59, 28 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 224, 59, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lockDays"> </param>
        public async Task LockIn(ulong lockDays, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 31, 190, 128 };
            var lockDaysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lockDaysAbi.From(lockDays);

            var result = await base.CallApp(new List<object> { abiHandle, lockDaysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LockIn_Transactions(ulong lockDays, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 31, 190, 128 };
            var lockDaysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lockDaysAbi.From(lockDays);

            return await base.MakeTransactionList(new List<object> { abiHandle, lockDaysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2F2aW5nc1ZhdWx0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iLCJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2NrSW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9ja0RheXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjIsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIG9uZSBvZiBPcHRJbiwgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3LDE3MSwyMTAsMjI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgTG9jYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjQsMTk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJblJ2ZEdGc1UyRjJaV1FpSUNKc2IyTnJSWGh3YVhKNUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVTJGMmFXNW5jMVpoZFd4MElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5T1RNeE5HUTVOU0F2THlCdFpYUm9iMlFnSW05d2RFbHVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5dmNIUkpibDl5YjNWMFpVQXpDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOaGRtbHVaM05XWVhWc2RDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPVEpsTUROaU1XTWdNSGd6WVRGbVltVTRNQ0F3ZURJeFpqRmtaR1ptSUM4dklHMWxkR2h2WkNBaVpHVndiM05wZENncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYkc5amEwbHVLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR1JsY0c5emFYUWdiRzlqYTBsdUlIZHBkR2hrY21GM0NpQWdJQ0JsY25JS0NtMWhhVzVmYjNCMFNXNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVDNCMFNXNG5MQ0FuVG05UGNDZGRJSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjMmhzQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnTXdvZ0lDQWdKZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnYjI1bElHOW1JRTl3ZEVsdUxDQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdiM0IwU1c0S0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVMkYyYVc1bmMxWmhkV3gwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUWVhacGJtZHpWbUYxYkhRdWIzQjBTVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUkpiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VFlYWmxaQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUIwYjNSaGJGTmhkbVZrSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzVTJGMlpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTJGMlpXUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUIwYUdsekxteHZZMnRGZUhCcGNua29WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdiRzlqYTBWNGNHbHllU0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncElDQXZMeUJNYjJOcklHVjRjR2x5WVhScGIyNGdkR2x0WlNBb01DQTlJRzV2ZENCc2IyTnJaV1FwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pzYjJOclJYaHdhWEo1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOclJYaHdhWEo1S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1ZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFBjSFJKYmljc0lDZE9iMDl3SjEwZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRZWFpwYm1kelZtRjFiSFF1WkdWd2IzTnBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGNHOXphWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCamIyNXpkQ0J3WVhsdFpXNTBWSGh1SUQwZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S0ZSNGJpNW5jbTkxY0VsdVpHVjRJQzBnTVNrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUlVlRzR1WVcxdmRXNTBJRDRnTUNrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVXMWxiblJVZUc0dWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOektRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MElEMGdkR2hwY3k1MGIzUmhiRk5oZG1Wa0tGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUIwYjNSaGJGTmhkbVZrSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzVTJGMlpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MElEMGdkR2hwY3k1MGIzUmhiRk5oZG1Wa0tGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbENpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VFlYWmxaQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOMWNuSmxiblFnS3lCd1lYbHRaVzUwVkhodUxtRnRiM1Z1ZEFvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QjBiM1JoYkZOaGRtVmtJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNVMkYyWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNVMkYyWldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmpkWEp5Wlc1MElDc2djR0Y1YldWdWRGUjRiaTVoYlc5MWJuUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMkYyYVc1bmMxWmhkV3gwTG14dlkydEpibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dlkydEpiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRHOTBZV3hUWVhabFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQStJREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QjBiM1JoYkZOaGRtVmtJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNVMkYyWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwYjNSaGJGTmhkbVZrS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQ0Z01Da0tJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QmpiMjV6ZENCc2IyTnJSSFZ5WVhScGIyNU5hV055YjNObFkyOXVaSE02SUhWcGJuUTJOQ0E5SUd4dlkydEVZWGx6SUNvZ1ZXbHVkRFkwS0RnMk5EQXdNREF3TURBd0tRb2dJQ0FnY0hWemFHbHVkQ0E0TmpRd01EQXdNREF3TUNBdkx5QTROalF3TURBd01EQXdNQW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdkR2hwY3k1c2IyTnJSWGh3YVhKNUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NBcklHeHZZMnRFZFhKaGRHbHZiazFwWTNKdmMyVmpiMjVrY3dvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QnNiMk5yUlhod2FYSjVJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0lDOHZJRXh2WTJzZ1pYaHdhWEpoZEdsdmJpQjBhVzFsSUNnd0lEMGdibTkwSUd4dlkydGxaQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXh2WTJ0RmVIQnBjbmtpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbXh2WTJ0RmVIQnBjbmtvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJQ3NnYkc5amEwUjFjbUYwYVc5dVRXbGpjbTl6WldOdmJtUnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE5oZG1sdVozTldZWFZzZEM1M2FYUm9aSEpoZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmpiMjV6ZENCamRYSnlaVzUwVEc5amEwVjRjR2x5ZVNBOUlIUm9hWE11Ykc5amEwVjRjR2x5ZVNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdiRzlqYTBWNGNHbHllU0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncElDQXZMeUJNYjJOcklHVjRjR2x5WVhScGIyNGdkR2x0WlNBb01DQTlJRzV2ZENCc2IyTnJaV1FwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pzYjJOclJYaHdhWEo1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTNWeWNtVnVkRXh2WTJ0RmVIQnBjbmtnUFNCMGFHbHpMbXh2WTJ0RmVIQnBjbmtvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFhKeVpXNTBURzlqYTBWNGNHbHllU0E5UFQwZ1ZXbHVkRFkwS0RBcElIeDhJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBZ1BpQmpkWEp5Wlc1MFRHOWphMFY0Y0dseWVTa0tJQ0FnSUdKNklIZHBkR2hrY21GM1gySnZiMnhmZEhKMVpVQXpDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWW5vZ2QybDBhR1J5WVhkZlltOXZiRjltWVd4elpVQTBDZ3AzYVhSb1pISmhkMTlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwM2FYUm9aSEpoZDE5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z5Y21WdWRFeHZZMnRGZUhCcGNua2dQVDA5SUZWcGJuUTJOQ2d3S1NCOGZDQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3SUQ0Z1kzVnljbVZ1ZEV4dlkydEZlSEJwY25rcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR052Ym5OMElIVnpaWEpUWVhacGJtZHpJRDBnZEdocGN5NTBiM1JoYkZOaGRtVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCMGIzUmhiRk5oZG1Wa0lEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1UyRjJaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCamIyNXpkQ0IxYzJWeVUyRjJhVzVuY3lBOUlIUm9hWE11ZEc5MFlXeFRZWFpsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZVzF2ZFc1MElENGdNQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dGdGIzVnVkQ0E4UFNCMWMyVnlVMkYyYVc1bmN5a0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hUWVhabFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSFZ6WlhKVFlYWnBibWR6SUMwZ1lXMXZkVzUwQ2lBZ0lDQXRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklIUnZkR0ZzVTJGMlpXUWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeFRZWFpsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFRZWFpsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIVnpaWEpUWVhacGJtZHpJQzBnWVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZDJsMGFHUnlZWGRmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnZDJsMGFHUnlZWGRmWW05dmJGOXRaWEpuWlVBMUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUUFJSmdJS2RHOTBZV3hUWVhabFpBcHNiMk5yUlhod2FYSjVNUnRCQUQrQUJDa3hUWlUyR2dDT0FRQWtNUmtVUkRFWVJJSURCSkxnT3h3RU9oKytnQVFoOGQzL05ob0FqZ01BSlFCS0FHMEFJakVaa0lFREdqRVlFRVJDQUFveEdSUXhHQlFRUkNKRE1RQW9JMll4QUNralppSkRNUllpQ1VrNEVDSVNSRWs0Q0VsRVREZ0hNZ29TUkRFQUl5aGpSQWd4QUNoUEFtWWlRellhQVVrVkpCSkVGekVBSXloalJFU0JnTURkN3NFQ0N6SUhDREVBS1U4Q1ppSkROaG9CU1JVa0VrUVhNUUFqS1dOTVNVOENSRUVBQ0RJSFN3RU5RUUFhSWtReEFDTW9ZMFJMQWtsRVNVc0NEa1FKTVFBb1R3Sm1Ja01qUXYvaiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
