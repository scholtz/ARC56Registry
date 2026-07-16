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

namespace Arc56.Generated.Aniketwarule.Crazy8_Ignition.IgnitionGateway_9462fdf3
{


    public class IgnitionGatewayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IgnitionGatewayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task PayForAi(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 185, 148, 212, 44 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayForAi_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 185, 148, 212, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task PayForGemini(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 203, 70, 96, 75 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayForGemini_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 203, 70, 96, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task PayForGpt4O(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 40, 235, 179, 67 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayForGpt4O_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 40, 235, 179, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task PayForClaudeOpus(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 127, 70, 164, 148 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayForClaudeOpus_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 127, 70, 164, 148 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSWduaXRpb25HYXRld2F5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheUZvckFpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlGb3JHZW1pbmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5VHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheUZvckdwdDRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlGb3JDbGF1ZGVPcHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2NV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBwYXltZW50IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdHJlYXN1cnkgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzMsMTk0LDIxNSwyMzcsMjU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5LDE5MCwyMTEsMjMyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSlFRVWxFWDBKQlUwVmZUVTlFUlV3aUlDSm5aVzFwYm1sZmNISnBZMlVpSUNKMGNtVmhjM1Z5ZVY5aFpHUnlaWE56SWlBaVozQjBYM0J5YVdObElpQWlZMnhoZFdSbFgzQnlhV05sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJKWjI1cGRHbHZia2RoZEdWM1lYa2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHSTVPVFJrTkRKaklEQjRZMkkwTmpZd05HSWdNSGd5T0dWaVlqTTBNeUF3ZURkbU5EWmhORGswSUM4dklHMWxkR2h2WkNBaWNHRjVSbTl5UVdrb2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhlVVp2Y2tkbGJXbHVhU2h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY0dGNVJtOXlSM0IwTkc4b2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhlVVp2Y2tOc1lYVmtaVTl3ZFhNb2NHRjVLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQndZWGxHYjNKQmFTQndZWGxHYjNKSFpXMXBibWtnY0dGNVJtOXlSM0IwTkc4Z2NHRjVSbTl5UTJ4aGRXUmxUM0IxY3dvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVsbmJtbDBhVzl1UjJGMFpYZGhlU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZPa2xuYm1sMGFXOXVSMkYwWlhkaGVTNWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhSeVpXRnpkWEo1UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBbmRISmxZWE4xY25sZllXUmtjbVZ6Y3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdkR2hwY3k1MGNtVmhjM1Z5ZVVGa1pISmxjM011ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdkbGJXbHVhVkJ5YVdObElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMmRsYldsdWFWOXdjbWxqWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltZGxiV2x1YVY5d2NtbGpaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMGFHbHpMbWRsYldsdWFWQnlhV05sTG5aaGJIVmxJRDBnVldsdWREWTBLREV3TUY4d01EQXBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNQ0F2THlBeE1EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1ozQjBVSEpwWTJVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5aM0IwWDNCeWFXTmxKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWjNCMFgzQnlhV05sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklIUm9hWE11WjNCMFVISnBZMlV1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9OREF3WHpBd01Da0tJQ0FnSUhCMWMyaHBiblFnTkRBd01EQXdJQzh2SURRd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCamJHRjFaR1ZRY21salpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqYkdGMVpHVmZjSEpwWTJVbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpiR0YxWkdWZmNISnBZMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2RHaHBjeTVqYkdGMVpHVlFjbWxqWlM1MllXeDFaU0E5SUZWcGJuUTJOQ2c0TURCZk1EQXdLUW9nSUNBZ2NIVnphR2x1ZENBNE1EQXdNREFnTHk4Z09EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvNlNXZHVhWFJwYjI1SFlYUmxkMkY1TG5CaGVVWnZja0ZwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NHRjVSbTl5UVdrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjSFZpYkdsaklIQmhlVVp2Y2tGcEtIQmhlVlI0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEZSeVpXRnpkWEo1VUdGNWJXVnVkQ2h3WVhsVWVHNHNJSFJvYVhNdVoyVnRhVzVwVUhKcFkyVXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHZGxiV2x1YVZCeWFXTmxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJkbGJXbHVhVjl3Y21salpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWRsYldsdWFWOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRlJ5WldGemRYSjVVR0Y1YldWdWRDaHdZWGxVZUc0c0lIUm9hWE11WjJWdGFXNXBVSEpwWTJVdWRtRnNkV1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCaGMzTmxjblJVY21WaGMzVnllVkJoZVcxbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJzYjJjb0oxQkJTVVJmUWtGVFJWOU5UMFJGVENjcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKUVFVbEVYMEpCVTBWZlRVOUVSVXdpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCd2RXSnNhV01nY0dGNVJtOXlRV2tvY0dGNVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzZTV2R1YVhScGIyNUhZWFJsZDJGNUxuQmhlVVp2Y2tkbGJXbHVhVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGVVWnZja2RsYldsdWFUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Y1Um05eVIyVnRhVzVwS0hCaGVWUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRlJ5WldGemRYSjVVR0Y1YldWdWRDaHdZWGxVZUc0c0lIUm9hWE11WjJWdGFXNXBVSEpwWTJVdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdkbGJXbHVhVkJ5YVdObElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMmRsYldsdWFWOXdjbWxqWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltZGxiV2x1YVY5d2NtbGpaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRGUnlaV0Z6ZFhKNVVHRjViV1Z1ZENod1lYbFVlRzRzSUhSb2FYTXVaMlZ0YVc1cFVISnBZMlV1ZG1Gc2RXVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlVjbVZoYzNWeWVWQmhlVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QnNiMmNvSjFCQlNVUmZRa0ZUUlY5TlQwUkZUQ2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pRUVVsRVgwSkJVMFZmVFU5RVJVd2lDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Y1Um05eVIyVnRhVzVwS0hCaGVWUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZPa2xuYm1sMGFXOXVSMkYwWlhkaGVTNXdZWGxHYjNKSGNIUTBiMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGVVWnZja2R3ZERSdk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSEIxWW14cFl5QndZWGxHYjNKSGNIUTBieWh3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z2RHaHBjeTVoYzNObGNuUlVjbVZoYzNWeWVWQmhlVzFsYm5Rb2NHRjVWSGh1TENCMGFHbHpMbWR3ZEZCeWFXTmxMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5Qm5jSFJRY21salpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RuY0hSZmNISnBZMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKbmNIUmZjSEpwWTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJVY21WaGMzVnllVkJoZVcxbGJuUW9jR0Y1VkhodUxDQjBhR2x6TG1kd2RGQnlhV05sTG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnWVhOelpYSjBWSEpsWVhOMWNubFFZWGx0Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdiRzluS0NkUVFVbEVYMEpCVTBWZlRVOUVSVXduS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpVUVGSlJGOUNRVk5GWDAxUFJFVk1JZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZVVadmNrZHdkRFJ2S0hCaGVWUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZPa2xuYm1sMGFXOXVSMkYwWlhkaGVTNXdZWGxHYjNKRGJHRjFaR1ZQY0hWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1Um05eVEyeGhkV1JsVDNCMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Y1Um05eVEyeGhkV1JsVDNCMWN5aHdZWGxVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnZEdocGN5NWhjM05sY25SVWNtVmhjM1Z5ZVZCaGVXMWxiblFvY0dGNVZIaHVMQ0IwYUdsekxtTnNZWFZrWlZCeWFXTmxMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmpiR0YxWkdWUWNtbGpaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkamJHRjFaR1ZmY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYkdGMVpHVmZjSEpwWTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJVY21WaGMzVnllVkJoZVcxbGJuUW9jR0Y1VkhodUxDQjBhR2x6TG1Oc1lYVmtaVkJ5YVdObExuWmhiSFZsS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1lYTnpaWEowVkhKbFlYTjFjbmxRWVhsdFpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnYkc5bktDZFFRVWxFWDBKQlUwVmZUVTlFUlV3bktRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVVFRkpSRjlDUVZORlgwMVBSRVZNSWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGVVWnZja05zWVhWa1pVOXdkWE1vY0dGNVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnpjMlZ5ZEZSeVpXRnpkWEo1VUdGNWJXVnVkQ2h3WVhsVWVHNDZJSFZwYm5RMk5Dd2diV2x1UVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbUZ6YzJWeWRGUnlaV0Z6ZFhKNVVHRjViV1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QndjbWwyWVhSbElHRnpjMlZ5ZEZSeVpXRnpkWEo1VUdGNWJXVnVkQ2h3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2diV2x1UVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbFVlRzR1Y21WalpXbDJaWElnUFQwOUlIUm9hWE11ZEhKbFlYTjFjbmxCWkdSeVpYTnpMblpoYkhWbExDQW5TVzUyWVd4cFpDQjBjbVZoYzNWeWVTQnlaV05sYVhabGNpY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSFJ5WldGemRYSjVRV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuZEhKbFlYTjFjbmxmWVdSa2NtVnpjeWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SeVpXRnpkWEo1WDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVWUjRiaTV5WldObGFYWmxjaUE5UFQwZ2RHaHBjeTUwY21WaGMzVnllVUZrWkhKbGMzTXVkbUZzZFdVc0lDZEpiblpoYkdsa0lIUnlaV0Z6ZFhKNUlISmxZMlZwZG1WeUp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdkSEpsWVhOMWNua2djbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1VkhodUxtRnRiM1Z1ZENBK1BTQnRhVzVCYlc5MWJuUXNJQ2RKYm5OMVptWnBZMmxsYm5RZ2NHRjViV1Z1ZENCaGJXOTFiblFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdjR0Y1YldWdWRDQmhiVzkxYm5RS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUFtQlE5UVFVbEVYMEpCVTBWZlRVOUVSVXdNWjJWdGFXNXBYM0J5YVdObEVIUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNSlozQjBYM0J5YVdObERHTnNZWFZrWlY5d2NtbGpaVEVaRkVReEdFRUFKSUlFQkxtVTFDd0V5MFpnU3dRbzY3TkRCSDlHcEpRMkdnQ09CQUFvQUQwQVVnQm5BSUFFdUVSN05qWWFBSTRCQUFFQUtqRUFaeW1Cb0kwR1p5dUJnTFVZWnljRWdZRHFNR2NpUXpFV0lnbEpPQkFpRWtRaktXVkVpQUJFS0xBaVF6RVdJZ2xKT0JBaUVrUWpLV1ZFaUFBdktMQWlRekVXSWdsSk9CQWlFa1FqSzJWRWlBQWFLTEFpUXpFV0lnbEpPQkFpRWtRakp3UmxSSWdBQkNpd0lrT0tBZ0NML2pnSEl5cGxSQkpFaS80NENJdi9EMFNKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
