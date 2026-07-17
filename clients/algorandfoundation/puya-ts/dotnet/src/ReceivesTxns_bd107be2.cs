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

namespace Arc56.Generated.algorandfoundation.puya_ts.ReceivesTxns_bd107be2
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVjZWl2ZXNUeG5zIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE9uZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQW55VHhuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InR4biIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVzQXNzZXRDb25maWciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNmZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0Q2ZnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjZWl2ZXNBc3NldENvbmZpZ0FuZFBheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRDZmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2OCwxOTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFjZmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVmpaV2wyWlhOVWVHNXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNFpqWTRPVEpsWmlBd2VEbGpaRGczWkdVeklEQjRaRE0yTm1NNE5qa2dNSGc0TVdJMk56TTFNaUF2THlCdFpYUm9iMlFnSW1kbGRFOXVaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldObGFYWmxjMEZ1ZVZSNGJpaDBlRzRwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldObGFYWmxjMEZ6YzJWMFEyOXVabWxuS0dGalptY3BZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSnlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5RVzVrVUdGNUtHRmpabWNzY0dGNUtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmRsZEU5dVpWOXliM1YwWlVBMElISmxZMlZwZG1WelFXNTVWSGh1SUhKbFkyVnBkbVZ6UVhOelpYUkRiMjVtYVdjZ2NtVmpaV2wyWlhOQmMzTmxkRU52Ym1acFowRnVaRkJoZVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMmRsZEU5dVpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWjJWMFQyNWxLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVmpaV2wyWlhOVWVHNXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV05sYVhabGMwRnVlVlI0YmpvS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QnlaV05sYVhabGMwRnVlVlI0YmloMGVHNDZJR2QwZUc0dVZISmhibk5oWTNScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJSE4zYVhSamFDQW9kSGh1TG5SNWNHVXBJSHNLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z6YzJWMFEyOXVabWxuT2dvZ0lDQWdhVzUwWTE4eElDOHZJRE1LSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2preUxUa3pDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRFTnZibVpwWnpvS0lDQWdJQzh2SUNBZ2NtVjBkWEp1SUhSNGJpNWpjbVZoZEdWa1FYTnpaWFF1YVdRZ2ZId2dkSGh1TG1OdmJtWnBaMEZ6YzJWMExtbGtDaUFnSUNCaWVpQnlaV05sYVhabGMwRnVlVlI0Ymw5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCMGVHNHVZM0psWVhSbFpFRnpjMlYwTG1sa0lIeDhJSFI0Ymk1amIyNW1hV2RCYzNObGRDNXBaQW9nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUVOeVpXRjBaV1JCYzNObGRFbEVDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ1lub2djbVZqWldsMlpYTkJibmxVZUc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExQ2lBZ0lDQmthV2NnTXdvS2NtVmpaV2wyWlhOQmJubFVlRzVmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1QU1UVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCeVpXTmxhWFpsYzBGdWVWUjRiaWgwZUc0NklHZDBlRzR1VkhKaGJuTmhZM1JwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHlaV05sYVhabGMwRnVlVlI0Ymw5MFpYSnVZWEo1WDJaaGJITmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QnlaWFIxY200Z2RIaHVMbU55WldGMFpXUkJjM05sZEM1cFpDQjhmQ0IwZUc0dVkyOXVabWxuUVhOelpYUXVhV1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCRGIyNW1hV2RCYzNObGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnY21WalpXbDJaWE5CYm5sVWVHNG9kSGh1T2lCbmRIaHVMbFJ5WVc1ellXTjBhVzl1S1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0lnY21WalpXbDJaWE5CYm5sVWVHNWZZV1owWlhKZmFXNXNhVzVsWkY5MFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBTWldObGFYWmxjMVI0Ym5NdWNtVmpaV2wyWlhOQmJubFVlRzVBTVRVS0NuSmxZMlZwZG1WelFXNTVWSGh1WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JEb0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU5DMDVOUW9nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhCd2JHbGpZWFJwYjI1RFlXeHNPZ29nSUNBZ0x5OGdJQ0J5WlhSMWNtNGdkSGh1TG1OeVpXRjBaV1JCY0hBdWFXUWdmSHdnZEhodUxtRndjRWxrTG1sa0NpQWdJQ0JpZWlCeVpXTmxhWFpsYzBGdWVWUjRibDloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCeVpYUjFjbTRnZEhodUxtTnlaV0YwWldSQmNIQXVhV1FnZkh3Z2RIaHVMbUZ3Y0Vsa0xtbGtDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JpZWlCeVpXTmxhWFpsYzBGdWVWUjRibDkwWlhKdVlYSjVYMlpoYkhObFFERXhDaUFnSUNCa2FXY2dNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhOQmJubFVlRzRvZEhodU9pQm5kSGh1TGxSeVlXNXpZV04wYVc5dUtUb2dkV2x1ZERZMElIc0tJQ0FnSUdJZ2NtVmpaV2wyWlhOQmJubFVlRzVmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFSNGJuTXVjbVZqWldsMlpYTkJibmxVZUc1QU1UVUtDbkpsWTJWcGRtVnpRVzU1VkhodVgzUmxjbTVoY25sZlptRnNjMlZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkSGh1TG1OeVpXRjBaV1JCY0hBdWFXUWdmSHdnZEhodUxtRndjRWxrTG1sa0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdjbVZqWldsMlpYTkJibmxVZUc0b2RIaHVPaUJuZEhodUxsUnlZVzV6WVdOMGFXOXVLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSWdjbVZqWldsMlpYTkJibmxVZUc1ZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxUjRibk11Y21WalpXbDJaWE5CYm5sVWVHNUFNVFVLQ25KbFkyVnBkbVZ6UVc1NVZIaHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCeVpYUjFjbTRnTUFvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCeVpXTmxhWFpsYzBGdWVWUjRiaWgwZUc0NklHZDBlRzR1VkhKaGJuTmhZM1JwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWWlCeVpXTmxhWFpsYzBGdWVWUjRibDloWm5SbGNsOXBibXhwYm1Wa1gzUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VkhodWN5NXlaV05sYVhabGMwRnVlVlI0YmtBeE5Rb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpWSGh1Y3k1eVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZqWldsMlpYTkJjM05sZEVOdmJtWnBaem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QnlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5LR0Z6YzJWMFEyWm5PaUJuZEhodUxrRnpjMlYwUTI5dVptbG5WSGh1S1RvZ1lubDBaWE1nZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z1lXTm1ad29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRmpabWNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QnlaWFIxY200Z1lYTnpaWFJEWm1jdWRIaHVTV1FLSUNBZ0lHZDBlRzV6SUZSNFNVUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCeVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sbktHRnpjMlYwUTJabk9pQm5kSGh1TGtGemMyVjBRMjl1Wm1sblZIaHVLVG9nWW5sMFpYTWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk9sSmxZMlZwZG1WelZIaHVjeTV5WldObGFYWmxjMEZ6YzJWMFEyOXVabWxuUVc1a1VHRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WalpXbDJaWE5CYzNObGRFTnZibVpwWjBGdVpGQmhlVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QnlaV05sYVhabGMwRnpjMlYwUTI5dVptbG5RVzVrVUdGNUtHRnpjMlYwUTJabk9pQm5kSGh1TGtGemMyVjBRMjl1Wm1sblZIaHVMQ0J3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklHRmpabWNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhZMlpuQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCaGMzTmxjblFvWVhOelpYUkRabWN1ZEhsd1pTQTlQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z6YzJWMFEyOXVabWxuS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjVWSGh1TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCeVpXTmxhWFpsYzBGemMyVjBRMjl1Wm1sblFXNWtVR0Y1S0dGemMyVjBRMlpuT2lCbmRIaHVMa0Z6YzJWMFEyOXVabWxuVkhodUxDQndZWGxVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUU14RzBFQVBERVpGRVF4R0VTQ0JBU1BhSkx2Qkp6WWZlTUUwMmJJYVFTQnRuTlNOaG9BamdRQUFRQWFBR3NBaEFDQURCVWZmSFVBQUFBQUFBQUFBYkFpUXpFWkZERVlGQkJEZ0FCSk1SWWlDVWs0RUVrakVrRUFIMHNCT0R4SlJRVkJBQTVMQXhhQUJCVWZmSFZNVUxBaVEwc0JPQ0ZDLysxSmdRWVNRUUFXU3dFNFBVbEZCRUVBQlVzQ1F2L1hTd0U0R0VMLzBJRUFRdi9MTVJZaUNVazRFQ01TUkRnWGdBWVZIM3gxQUNCTVVMQWlRekVXZ1FJSk9CQkpJeEpFTVJZaUNUZ1FTU0lTUkV3akVrUWlFa1FpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
