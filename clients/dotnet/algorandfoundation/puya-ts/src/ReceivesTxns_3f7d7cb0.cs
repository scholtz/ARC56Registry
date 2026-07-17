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

namespace Arc56.Generated.algorandfoundation.puya_ts.ReceivesTxns_3f7d7cb0
{


    public class ReceivesTxnsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReceivesTxnsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetOne(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 104, 146, 239 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetOne_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 104, 146, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task<ulong> ReceivesAnyTxn(Transaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 156, 216, 125, 227 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReceivesAnyTxn_Transactions(Transaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 156, 216, 125, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetCfg"> </param>
        public async Task<byte[]> ReceivesAssetConfig(AssetConfigurationTransaction assetCfg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetCfg });
            byte[] abiHandle = { 211, 102, 200, 105 };

            var result = await base.CallApp(new List<object> { abiHandle, assetCfg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ReceivesAssetConfig_Transactions(AssetConfigurationTransaction assetCfg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetCfg });
            byte[] abiHandle = { 211, 102, 200, 105 };

            return await base.MakeTransactionList(new List<object> { abiHandle, assetCfg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetCfg"> </param>
        /// <param name="payTxn"> </param>
        public async Task ReceivesAssetConfigAndPay(AssetConfigurationTransaction assetCfg, PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetCfg, payTxn });
            byte[] abiHandle = { 129, 182, 115, 82 };

            var result = await base.CallApp(new List<object> { abiHandle, assetCfg, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceivesAssetConfigAndPay_Transactions(AssetConfigurationTransaction assetCfg, PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetCfg, payTxn });
            byte[] abiHandle = { 129, 182, 115, 82 };

            return await base.MakeTransactionList(new List<object> { abiHandle, assetCfg, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVjZWl2ZXNUeG5zIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE9uZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQW55VHhuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InR4biIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQXNzZXRDb25maWciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNmZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0Q2ZnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjZWl2ZXNBc3NldENvbmZpZ0FuZFBheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRDZmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY3LDk2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhY2ZnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGSmxZMlZwZG1WelZIaHVjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9HWTJPRGt5WldZZ01IZzVZMlE0TjJSbE15QXdlR1F6Tmpaak9EWTVJREI0T0RGaU5qY3pOVElnTHk4Z2JXVjBhRzlrSUNKblpYUlBibVVvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WalpXbDJaWE5CYm5sVWVHNG9kSGh1S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WalpXbDJaWE5CYzNObGRFTnZibVpwWnloaFkyWm5LV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWljbVZqWldsMlpYTkJjM05sZEVOdmJtWnBaMEZ1WkZCaGVTaGhZMlpuTEhCaGVTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDluWlhSUGJtVmZjbTkxZEdWQU5DQnRZV2x1WDNKbFkyVnBkbVZ6UVc1NVZIaHVYM0p2ZFhSbFFEVWdiV0ZwYmw5eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblgzSnZkWFJsUURZZ2JXRnBibDl5WldObGFYWmxjMEZ6YzJWMFEyOXVabWxuUVc1a1VHRjVYM0p2ZFhSbFFEY0tJQ0FnSUdWeWNnb0tiV0ZwYmw5eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblFXNWtVR0Y1WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qRXdOQW9nSUNBZ0x5OGdjbVZqWldsMlpYTkJjM05sZEVOdmJtWnBaMEZ1WkZCaGVTaGhjM05sZEVObVp6b2daM1I0Ymk1QmMzTmxkRU52Ym1acFoxUjRiaXdnY0dGNVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QmhZMlpuQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZV05tWndvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dGemMyVjBRMlpuTG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRFTnZibVpwWnlrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdZWE56WlhKMEtIQmhlVlI0Ymk1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1VUdGNWJXVnVkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhOQmMzTmxkRU52Ym1acFowRnVaRkJoZVNoaGMzTmxkRU5tWnpvZ1ozUjRiaTVCYzNObGRFTnZibVpwWjFSNGJpd2djR0Y1VkhodU9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WalpXbDJaWE5CYzNObGRFTnZibVpwWjE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJSEpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2NvWVhOelpYUkRabWM2SUdkMGVHNHVRWE56WlhSRGIyNW1hV2RVZUc0cE9pQmllWFJsY3lCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QmhZMlpuQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZV05tWndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjM05sZEVObVp5NTBlRzVKWkFvZ0lDQWdaM1I0Ym5NZ1ZIaEpSQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklISmxZMlZwZG1WelFYTnpaWFJEYjI1bWFXY29ZWE56WlhSRFptYzZJR2QwZUc0dVFYTnpaWFJEYjI1bWFXZFVlRzRwT2lCaWVYUmxjeUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFkyVnBkbVZ6UVc1NVZIaHVYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCeVpXTmxhWFpsYzBGdWVWUjRiaWgwZUc0NklHZDBlRzR1VkhKaGJuTmhZM1JwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdjM2RwZEdOb0lDaDBlRzR1ZEhsd1pTa2dld29nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRFTnZibVpwWnpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU1pMDVNd29nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhOelpYUkRiMjVtYVdjNkNpQWdJQ0F2THlBZ0lISmxkSFZ5YmlCMGVHNHVZM0psWVhSbFpFRnpjMlYwTG1sa0lIeDhJSFI0Ymk1amIyNW1hV2RCYzNObGRDNXBaQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QnlaWFIxY200Z2RIaHVMbU55WldGMFpXUkJjM05sZEM1cFpDQjhmQ0IwZUc0dVkyOXVabWxuUVhOelpYUXVhV1FLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNakVLSUNBZ0lHUnBaeUF5Q2dwdFlXbHVYMkZtZEdWeVgybHViR2x1WldSZmRHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxuSmxZMlZwZG1WelFXNTVWSGh1UURJNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnY21WalpXbDJaWE5CYm5sVWVHNG9kSGh1T2lCbmRIaHVMbFJ5WVc1ellXTjBhVzl1S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSNGJpNWpjbVZoZEdWa1FYTnpaWFF1YVdRZ2ZId2dkSGh1TG1OdmJtWnBaMEZ6YzJWMExtbGtDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QnlaV05sYVhabGMwRnVlVlI0YmloMGVHNDZJR2QwZUc0dVZISmhibk5oWTNScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRVzU1VkhodVFESTVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3c2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem81TkMwNU5Rb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWEJ3YkdsallYUnBiMjVEWVd4c09nb2dJQ0FnTHk4Z0lDQnlaWFIxY200Z2RIaHVMbU55WldGMFpXUkJjSEF1YVdRZ2ZId2dkSGh1TG1Gd2NFbGtMbWxrQ2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpnS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBlRzR1WTNKbFlYUmxaRUZ3Y0M1cFpDQjhmQ0IwZUc0dVlYQndTV1F1YVdRS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1EzSmxZWFJsWkVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNallLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QnlaV05sYVhabGMwRnVlVlI0YmloMGVHNDZJR2QwZUc0dVZISmhibk5oWTNScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRVzU1VkhodVFESTVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkSGh1TG1OeVpXRjBaV1JCY0hBdWFXUWdmSHdnZEhodUxtRndjRWxrTG1sa0NpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklISmxZMlZwZG1WelFXNTVWSGh1S0hSNGJqb2daM1I0Ymk1VWNtRnVjMkZqZEdsdmJpazZJSFZwYm5RMk5DQjdDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1QU1qa0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQXdDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJSEpsWTJWcGRtVnpRVzU1VkhodUtIUjRiam9nWjNSNGJpNVVjbUZ1YzJGamRHbHZiaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNUFNamtLQ20xaGFXNWZaMlYwVDI1bFgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJuWlhSUGJtVW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pXTmxhWFpsYzFSNGJuTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRT0FBRWNETVJ0QkFNSXhHUlJFTVJoRWdnUUVqMmlTN3dTYzJIM2pCTk5teUdrRWdiWnpVallhQUk0RUFJY0FPQUFmQUFFQU1SYUJBZ2s0RUVrakVrUXhGaUlKT0JCSkloSkVUQ01TUkNJU1JDSkRNUllpQ1VrNEVDTVNSRGdYZ0FZVkgzeDFBQ0JNVUxBaVF6RVdJZ2xKUlFJNEVFbEZCU01TUVFBZFNUZzhTVVVFUVFBT1N3SVdnQVFWSDN4MVRGQ3dJa05KT0NGQy8rNUxBNEVHRWtFQUZFazRQVWxGQTBFQUJVc0JRdi9ZU1RnWVF2L1NnUUJDLzgyQURCVWZmSFVBQUFBQUFBQUFBYkFpUXpFWkZERVlGQkJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
