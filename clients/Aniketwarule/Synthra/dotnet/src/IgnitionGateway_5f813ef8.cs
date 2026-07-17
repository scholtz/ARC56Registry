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

namespace Arc56.Generated.Aniketwarule.Synthra.IgnitionGateway_5f813ef8
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSWduaXRpb25HYXRld2F5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheUZvckFpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlGb3JHZW1pbmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5VHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheUZvckdwdDRvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlGb3JDbGF1ZGVPcHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1N10sImVycm9yTWVzc2FnZSI6IkludmFsaWQgdHJlYXN1cnkgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjVdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFtb3VudCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MywxOTQsMjE1LDIzNywyNTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjksMTkwLDIxMSwyMzJdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKUVFVbEVYMEpCVTBWZlRVOUVSVXdpSUNKblpXMXBibWxmY0hKcFkyVWlJQ0owY21WaGMzVnllVjloWkdSeVpYTnpJaUFpWjNCMFgzQnlhV05sSWlBaVkyeGhkV1JsWDNCeWFXTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkpaMjVwZEdsdmJrZGhkR1YzWVhrZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBT0FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdJNU9UUmtOREpqSURCNFkySTBOall3TkdJZ01IZ3lPR1ZpWWpNME15QXdlRGRtTkRaaE5EazBJQzh2SUcxbGRHaHZaQ0FpY0dGNVJtOXlRV2tvY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5CaGVVWnZja2RsYldsdWFTaHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWljR0Y1Um05eVIzQjBORzhvY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5CaGVVWnZja05zWVhWa1pVOXdkWE1vY0dGNUtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCd1lYbEdiM0pCYVNCd1lYbEdiM0pIWlcxcGJta2djR0Y1Um05eVIzQjBORzhnY0dGNVJtOXlRMnhoZFdSbFQzQjFjd29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWxuYm1sMGFXOXVSMkYwWlhkaGVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk9rbG5ibWwwYVc5dVIyRjBaWGRoZVM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSFJ5WldGemRYSjVRV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuZEhKbFlYTjFjbmxmWVdSa2NtVnpjeWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SeVpXRnpkWEo1WDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z2RHaHBjeTUwY21WaGMzVnllVUZrWkhKbGMzTXVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR2RsYldsdWFWQnlhV05sSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyZGxiV2x1YVY5d2NtbGpaU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kbGJXbHVhVjl3Y21salpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUIwYUdsekxtZGxiV2x1YVZCeWFXTmxMblpoYkhWbElEMGdWV2x1ZERZMEtERXdNRjh3TURBcENpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01DQXZMeUF4TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnWjNCMFVISnBZMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblozQjBYM0J5YVdObEp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlaM0IwWDNCeWFXTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhSb2FYTXVaM0IwVUhKcFkyVXVkbUZzZFdVZ1BTQlZhVzUwTmpRb05UQXdYekF3TUNrS0lDQWdJSEIxYzJocGJuUWdOVEF3TURBd0lDOHZJRFV3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJqYkdGMVpHVlFjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGpiR0YxWkdWZmNISnBZMlVuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKamJHRjFaR1ZmY0hKcFkyVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnZEdocGN5NWpiR0YxWkdWUWNtbGpaUzUyWVd4MVpTQTlJRlZwYm5RMk5DZzRNREJmTURBd0tRb2dJQ0FnY0hWemFHbHVkQ0E0TURBd01EQWdMeThnT0RBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem82U1dkdWFYUnBiMjVIWVhSbGQyRjVMbkJoZVVadmNrRnBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0dGNVJtOXlRV2s2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGVVWnZja0ZwS0hCaGVWUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRlJ5WldGemRYSjVVR0Y1YldWdWRDaHdZWGxVZUc0c0lIUm9hWE11WjJWdGFXNXBVSEpwWTJVdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdkbGJXbHVhVkJ5YVdObElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMmRsYldsdWFWOXdjbWxqWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltZGxiV2x1YVY5d2NtbGpaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRGUnlaV0Z6ZFhKNVVHRjViV1Z1ZENod1lYbFVlRzRzSUhSb2FYTXVaMlZ0YVc1cFVISnBZMlV1ZG1Gc2RXVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlVjbVZoYzNWeWVWQmhlVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QnNiMmNvSjFCQlNVUmZRa0ZUUlY5TlQwUkZUQ2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pRUVVsRVgwSkJVMFZmVFU5RVJVd2lDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Y1Um05eVFXa29jR0Y1VkhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvNlNXZHVhWFJwYjI1SFlYUmxkMkY1TG5CaGVVWnZja2RsYldsdWFWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJoZVVadmNrZGxiV2x1YVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjVSbTl5UjJWdGFXNXBLSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRGUnlaV0Z6ZFhKNVVHRjViV1Z1ZENod1lYbFVlRzRzSUhSb2FYTXVaMlZ0YVc1cFVISnBZMlV1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR2RsYldsdWFWQnlhV05sSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyZGxiV2x1YVY5d2NtbGpaU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kbGJXbHVhVjl3Y21salpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5bllYUmxkMkY1TDBsbmJtbDBhVzl1UjJGMFpYZGhlUzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEZSeVpXRnpkWEo1VUdGNWJXVnVkQ2h3WVhsVWVHNHNJSFJvYVhNdVoyVnRhVzVwVUhKcFkyVXVkbUZzZFdVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQmhjM05sY25SVWNtVmhjM1Z5ZVZCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCc2IyY29KMUJCU1VSZlFrRlRSVjlOVDBSRlRDY3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSlFRVWxFWDBKQlUwVmZUVTlFUlV3aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjVSbTl5UjJWdGFXNXBLSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk9rbG5ibWwwYVc5dVIyRjBaWGRoZVM1d1lYbEdiM0pIY0hRMGIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJoZVVadmNrZHdkRFJ2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIQjFZbXhwWXlCd1lYbEdiM0pIY0hRMGJ5aHdZWGxVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnZEdocGN5NWhjM05sY25SVWNtVmhjM1Z5ZVZCaGVXMWxiblFvY0dGNVZIaHVMQ0IwYUdsekxtZHdkRkJ5YVdObExuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbmNIUlFjbWxqWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZG5jSFJmY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0puY0hSZmNISnBZMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2RHaHBjeTVoYzNObGNuUlVjbVZoYzNWeWVWQmhlVzFsYm5Rb2NHRjVWSGh1TENCMGFHbHpMbWR3ZEZCeWFXTmxMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFZISmxZWE4xY25sUVlYbHRaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z2JHOW5LQ2RRUVVsRVgwSkJVMFZmVFU5RVJVd25LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlVRUZKUkY5Q1FWTkZYMDFQUkVWTUlnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhlVVp2Y2tkd2REUnZLSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMmRoZEdWM1lYa3ZTV2R1YVhScGIyNUhZWFJsZDJGNUxtRnNaMjh1ZEhNNk9rbG5ibWwwYVc5dVIyRjBaWGRoZVM1d1lYbEdiM0pEYkdGMVpHVlBjSFZ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NHRjVSbTl5UTJ4aGRXUmxUM0IxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjVSbTl5UTJ4aGRXUmxUM0IxY3lod1lYbFVlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJVY21WaGMzVnllVkJoZVcxbGJuUW9jR0Y1VkhodUxDQjBhR2x6TG1Oc1lYVmtaVkJ5YVdObExuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCamJHRjFaR1ZRY21salpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqYkdGMVpHVmZjSEpwWTJVbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpiR0YxWkdWZmNISnBZMlVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2RHaHBjeTVoYzNObGNuUlVjbVZoYzNWeWVWQmhlVzFsYm5Rb2NHRjVWSGh1TENCMGFHbHpMbU5zWVhWa1pWQnlhV05sTG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdOaGJHeHpkV0lnWVhOelpYSjBWSEpsWVhOMWNubFFZWGx0Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdiRzluS0NkUVFVbEVYMEpCVTBWZlRVOUVSVXduS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpVUVGSlJGOUNRVk5GWDAxUFJFVk1JZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZloyRjBaWGRoZVM5SloyNXBkR2x2YmtkaGRHVjNZWGt1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZVVadmNrTnNZWFZrWlU5d2RYTW9jR0Y1VkhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZaMkYwWlhkaGVTOUpaMjVwZEdsdmJrZGhkR1YzWVhrdVlXeG5ieTUwY3pvNlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1GemMyVnlkRlJ5WldGemRYSjVVR0Y1YldWdWRDaHdZWGxVZUc0NklIVnBiblEyTkN3Z1pYaHdaV04wWldSQmJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWVhOelpYSjBWSEpsWVhOMWNubFFZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJkaGRHVjNZWGt2U1dkdWFYUnBiMjVIWVhSbGQyRjVMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdZWE56WlhKMFZISmxZWE4xY25sUVlYbHRaVzUwS0hCaGVWUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JsZUhCbFkzUmxaRUZ0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOW5ZWFJsZDJGNUwwbG5ibWwwYVc5dVIyRjBaWGRoZVM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCaGMzTmxjblFvY0dGNVZIaHVMbkpsWTJWcGRtVnlJRDA5UFNCMGFHbHpMblJ5WldGemRYSjVRV1JrY21WemN5NTJZV3gxWlN3Z0owbHVkbUZzYVdRZ2RISmxZWE4xY25rZ2NtVmpaV2wyWlhJbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDluWVhSbGQyRjVMMGxuYm1sMGFXOXVSMkYwWlhkaGVTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QjBjbVZoYzNWeWVVRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKM1J5WldGemRYSjVYMkZrWkhKbGMzTW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owY21WaGMzVnllVjloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyZGhkR1YzWVhrdlNXZHVhWFJwYjI1SFlYUmxkMkY1TG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsVWVHNHVjbVZqWldsMlpYSWdQVDA5SUhSb2FYTXVkSEpsWVhOMWNubEJaR1J5WlhOekxuWmhiSFZsTENBblNXNTJZV3hwWkNCMGNtVmhjM1Z5ZVNCeVpXTmxhWFpsY2ljcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIUnlaV0Z6ZFhKNUlISmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWjJGMFpYZGhlUzlKWjI1cGRHbHZia2RoZEdWM1lYa3VZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdZWE56WlhKMEtIQmhlVlI0Ymk1aGJXOTFiblFnUFQwOUlHVjRjR1ZqZEdWa1FXMXZkVzUwTENBblVHRjViV1Z1ZENCaGJXOTFiblFnYldsemJXRjBZMmduS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUdGdGIzVnVkQ0J0YVhOdFlYUmphQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRQW1CUTlRUVVsRVgwSkJVMFZmVFU5RVJVd01aMlZ0YVc1cFgzQnlhV05sRUhSeVpXRnpkWEo1WDJGa1pISmxjM01KWjNCMFgzQnlhV05sREdOc1lYVmtaVjl3Y21salpURVpGRVF4R0VFQUpJSUVCTG1VMUN3RXkwWmdTd1FvNjdOREJIOUdwSlEyR2dDT0JBQW9BRDBBVWdCbkFJQUV1RVI3TmpZYUFJNEJBQUVBS2pFQVp5bUJvSTBHWnl1Qm9NSWVaeWNFZ1lEcU1HY2lRekVXSWdsSk9CQWlFa1FqS1dWRWlBQkVLTEFpUXpFV0lnbEpPQkFpRWtRaktXVkVpQUF2S0xBaVF6RVdJZ2xKT0JBaUVrUWpLMlZFaUFBYUtMQWlRekVXSWdsSk9CQWlFa1FqSndSbFJJZ0FCQ2l3SWtPS0FnQ0wvamdISXlwbFJCSkVpLzQ0Q0l2L0VrU0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
