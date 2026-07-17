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

namespace Arc56.Generated.algorandfoundation.puya_ts.ReceivesTxns_ce12a457
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVjZWl2ZXNUeG5zIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE9uZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQW55VHhuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InR4biIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQXNzZXRDb25maWciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNmZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0Q2ZnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjZWl2ZXNBc3NldENvbmZpZ0FuZFBheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRDZmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4MCwyMTNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFjZmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lETUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lpSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXhDZ3B0WVdsdVgySnNiMk5yUURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVmpaV2wyWlhOVWVHNXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEVLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1WalpXbDJaWE5VZUc1eklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPUW9nSUNBZ1lpQnRZV2x1WDJOaGJHeGZUbTlQY0VBekNncHRZV2x1WDJOaGJHeGZUbTlQY0VBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGSmxZMlZwZG1WelZIaHVjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGhtTmpnNU1tVm1JQzh2SUcxbGRHaHZaQ0FpWjJWMFQyNWxLQ2wxYVc1ME5qUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVZMlE0TjJSbE15QXZMeUJ0WlhSb2IyUWdJbkpsWTJWcGRtVnpRVzU1VkhodUtIUjRiaWwxYVc1ME5qUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtNelkyWXpnMk9TQXZMeUJ0WlhSb2IyUWdJbkpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2NvWVdObVp5bGllWFJsVzEwaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1XSTJOek0xTWlBdkx5QnRaWFJvYjJRZ0luSmxZMlZwZG1WelFYTnpaWFJEYjI1bWFXZEJibVJRWVhrb1lXTm1aeXh3WVhrcGRtOXBaQ0lLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5blpYUlBibVZmY205MWRHVkFOQ0J0WVdsdVgzSmxZMlZwZG1WelFXNTVWSGh1WDNKdmRYUmxRRFVnYldGcGJsOXlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5YM0p2ZFhSbFFEWWdiV0ZwYmw5eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblFXNWtVR0Y1WDNKdmRYUmxRRGNLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE0T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVbVZqWldsMlpYTlVlRzV6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM0psWTJWcGRtVnpRWE56WlhSRGIyNW1hV2RCYm1SUVlYbGZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCeVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblFXNWtVR0Y1S0dGemMyVjBRMlpuT2lCbmRIaHVMa0Z6YzJWMFEyOXVabWxuVkhodUxDQndZWGxVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQnlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5RVzVrVUdGNUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgzSmxZMlZwZG1WelFYTnpaWFJEYjI1bWFXZGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCeVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sbktHRnpjMlYwUTJabk9pQm5kSGh1TGtGemMyVjBRMjl1Wm1sblZIaHVLVG9nWW5sMFpYTWdld29nSUNBZ1kyRnNiSE4xWWlCeVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sbkNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgzSmxZMlZwZG1WelFXNTVWSGh1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QnlaV05sYVhabGMwRnVlVlI0YmloMGVHNDZJR2QwZUc0dVZISmhibk5oWTNScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ1kyRnNiSE4xWWlCeVpXTmxhWFpsYzBGdWVWUjRiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDluWlhSUGJtVmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdkbGRFOXVaU2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJQYm1VS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJTWldObGFYWmxjMVI0Ym5NZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxtZGxkRTl1WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRTl1WlRvS0lDQWdJR0lnWjJWMFQyNWxYMkpzYjJOclFEQUtDbWRsZEU5dVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWjJWMFQyNWxLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NW5aWFJQYm1VS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMlZwZG1WelFXNTVWSGh1T2dvZ0lDQWdZaUJ5WldObGFYWmxjMEZ1ZVZSNGJsOWliRzlqYTBBd0NncHlaV05sYVhabGMwRnVlVlI0Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdjbVZqWldsMlpYTkJibmxVZUc0b2RIaHVPaUJuZEhodUxsUnlZVzV6WVdOMGFXOXVLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9sSmxZMlZwZG1WelZIaHVjeTV5WldObGFYWmxjMEZ6YzJWMFEyOXVabWxuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmpaV2wyWlhOQmMzTmxkRU52Ym1acFp6b0tJQ0FnSUdJZ2NtVmpaV2wyWlhOQmMzTmxkRU52Ym1acFoxOWliRzlqYTBBd0NncHlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhOQmMzTmxkRU52Ym1acFp5aGhjM05sZEVObVp6b2daM1I0Ymk1QmMzTmxkRU52Ym1acFoxUjRiaWs2SUdKNWRHVnpJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SUdGalptY0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaFkyWm5DaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sbkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYzNObGRFTnZibVpwWjBGdVpGQmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdkQmJtUlFZWGs2Q2lBZ0lDQmlJSEpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2RCYm1SUVlYbGZZbXh2WTJ0QU1Bb0tjbVZqWldsMlpYTkJjM05sZEVOdmJtWnBaMEZ1WkZCaGVWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem94TURRS0lDQWdJQzh2SUhKbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdkQmJtUlFZWGtvWVhOelpYUkRabWM2SUdkMGVHNHVRWE56WlhSRGIyNW1hV2RVZUc0c0lIQmhlVlI0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnWVdObVp3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGalptY0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJjM05sZEVOdmJtWnBaMEZ1WkZCaGVRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1blpYUlBibVVvS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NW5aWFJQYm1VNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1blpYUlBibVZmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG1kbGRFOXVaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNG9kSGh1T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxuSmxZMlZwZG1WelFXNTVWSGh1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdjbVZqWldsMlpYTkJibmxVZUc0b2RIaHVPaUJuZEhodUxsUnlZVzV6WVdOMGFXOXVLVG9nZFdsdWREWTBJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBTWldObGFYWmxjMVI0Ym5NdWNtVmpaV2wyWlhOQmJubFVlRzVmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG5KbFkyVnBkbVZ6UVc1NVZIaHVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCemQybDBZMmdnS0hSNGJpNTBlWEJsS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJR05oYzJVZ1ZISmhibk5oWTNScGIyNVVlWEJsTGtGemMyVjBRMjl1Wm1sbk9nb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3lMVGt6Q2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmMzTmxkRU52Ym1acFp6b0tJQ0FnSUM4dklDQWdjbVYwZFhKdUlIUjRiaTVqY21WaGRHVmtRWE56WlhRdWFXUWdmSHdnZEhodUxtTnZibVpwWjBGemMyVjBMbWxrQ2lBZ0lDQmllaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNWZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGdWVWUjRibDlwWmw5aWIyUjVRREVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGdWVWUjRibDlwWmw5aWIyUjVRREU2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9sSmxZMlZwZG1WelZIaHVjeTV5WldObGFYWmxjMEZ1ZVZSNGJsOWliRzlqYTBBeUNncDBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1ZllteHZZMnRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBlRzR1WTNKbFlYUmxaRUZ6YzJWMExtbGtJSHg4SUhSNGJpNWpiMjVtYVdkQmMzTmxkQzVwWkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKNklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0Ymw5MFpYSnVZWEo1WDJaaGJITmxRRFFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRVzU1VkhodVgzUmxjbTVoY25sZmRISjFaVUF6Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBTWldObGFYWmxjMVI0Ym5NdWNtVmpaV2wyWlhOQmJubFVlRzVmZEdWeWJtRnllVjkwY25WbFFETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCeVpYUjFjbTRnZEhodUxtTnlaV0YwWldSQmMzTmxkQzVwWkNCOGZDQjBlRzR1WTI5dVptbG5RWE56WlhRdWFXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG5KbFkyVnBkbVZ6UVc1NVZIaHVYM1JsY201aGNubGZiV1Z5WjJWQU5Rb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRVzU1VkhodVgzUmxjbTVoY25sZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBlRzR1WTNKbFlYUmxaRUZ6YzJWMExtbGtJSHg4SUhSNGJpNWpiMjVtYVdkQmMzTmxkQzVwWkFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBTWldObGFYWmxjMVI0Ym5NdWNtVmpaV2wyWlhOQmJubFVlRzVmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSNGJpNWpjbVZoZEdWa1FYTnpaWFF1YVdRZ2ZId2dkSGh1TG1OdmJtWnBaMEZ6YzJWMExtbGtDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRVzU1VkhodVgzUmxjbTVoY25sZmJXVnlaMlZBTlFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxuSmxZMlZwZG1WelFXNTVWSGh1WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JEb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prMExUazFDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHdzZDaUFnSUNBdkx5QWdJSEpsZEhWeWJpQjBlRzR1WTNKbFlYUmxaRUZ3Y0M1cFpDQjhmQ0IwZUc0dVlYQndTV1F1YVdRS0lDQWdJR0o2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGdWVWUjRibDloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0Ymw5cFpsOWliMlI1UURjS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0Ymw5cFpsOWliMlI1UURjNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGdWVWUjRibDlpYkc5amEwQTRDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNWZZbXh2WTJ0QU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhKbGRIVnliaUIwZUc0dVkzSmxZWFJsWkVGd2NDNXBaQ0I4ZkNCMGVHNHVZWEJ3U1dRdWFXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRM0psWVhSbFpFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaWVpQjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNWZkR1Z5Ym1GeWVWOTBjblZsUURrS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0Ymw5MFpYSnVZWEo1WDNSeWRXVkFPVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklISmxkSFZ5YmlCMGVHNHVZM0psWVhSbFpFRndjQzVwWkNCOGZDQjBlRzR1WVhCd1NXUXVhV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxuSmxZMlZwZG1WelFXNTVWSGh1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGdWVWUjRibDkwWlhKdVlYSjVYMjFsY21kbFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSNGJpNWpjbVZoZEdWa1FYQndMbWxrSUh4OElIUjRiaTVoY0hCSlpDNXBaQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhKbGRIVnliaUIwZUc0dVkzSmxZWFJsWkVGd2NDNXBaQ0I4ZkNCMGVHNHVZWEJ3U1dRdWFXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9sSmxZMlZwZG1WelZIaHVjeTV5WldObGFYWmxjMEZ1ZVZSNGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeENncDBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG5KbFkyVnBkbVZ6UVc1NVZIaHVYMkpzYjJOclFERXpDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNWZZbXh2WTJ0QU1UTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCeVpYUjFjbTRnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2NvWVhOelpYUkRabWM2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sbk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhKbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdjb1lYTnpaWFJEWm1jNklHZDBlRzR1UVhOelpYUkRiMjVtYVdkVWVHNHBPaUJpZVhSbGN5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG5KbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdkZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5VZUc1ekxuSmxZMlZwZG1WelFYTnpaWFJEYjI1bWFXZGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhOelpYUkRabWN1ZEhodVNXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdWSGhKUkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzZVbVZqWldsMlpYTlVlRzV6TG5KbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdkQmJtUlFZWGtvWVhOelpYUkRabWM2SUhWcGJuUTJOQ3dnY0dGNVZIaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9sSmxZMlZwZG1WelZIaHVjeTV5WldObGFYWmxjMEZ6YzJWMFEyOXVabWxuUVc1a1VHRjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklISmxZMlZwZG1WelFYTnpaWFJEYjI1bWFXZEJibVJRWVhrb1lYTnpaWFJEWm1jNklHZDBlRzR1UVhOelpYUkRiMjVtYVdkVWVHNHNJSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2RCYm1SUVlYbGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOVWVHNXpMbkpsWTJWcGRtVnpRWE56WlhSRGIyNW1hV2RCYm1SUVlYbGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCaGMzTmxjblFvWVhOelpYUkRabWN1ZEhsd1pTQTlQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z6YzJWMFEyOXVabWxuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eUlDOHZJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjVWSGh1TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBREpnSUFCQlVmZkhWQ0FBQkNBQUF4R3lNVFFRQmVRZ0FBTVJrakVrUXhHQ01UUVFCTVFnQUFOaG9BZ0FTUGFKTHZnQVNjMkgzamdBVFRac2hwZ0FTQnRuTlNUd1NPQkFBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQVowTC84NGdBUVVMLzdZZ0FLVUwvNTRnQUZVTC80VUwvNFRFWkl4SXhHQ01TRUVTSUFQY2lRMElBQUlnQVZ4WXBUd0ZRc0NKRFFnQUFNUllpQ1lnQVNoWXBUd0ZRc0NKRFFnQUFNUllpQ1VrNEVDUVNSSWdBcFVrVkZsY0dBazhCVUNsUEFWQ3dJa05DQUFBeEZvRUNDVWs0RUNRU1JERVdJZ2xKT0JBaUVrU0lBSVVpUTBJQUFDS0ppZ0VCS0Nnb0tFSUFBSXYvT0JCSkpCSkJBQ2hDQUFCQ0FBQ0wvemc4U1l3QVFRQVBRZ0FBaXdDTUFrSUFBSXNDakFDSmkvODRJWXdDUXYveWl3U0JCaEpCQUNoQ0FBQkNBQUNML3pnOVNZd0JRUUFQUWdBQWl3R01BMElBQUlzRGpBQ0ppLzg0R0l3RFF2L3lRZ0FBSTR3QWlZb0JBVUlBQUl2L09CZUppZ0lBUWdBQWkvNDRFQ1FTUkl2L09CQWlFa1NKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
