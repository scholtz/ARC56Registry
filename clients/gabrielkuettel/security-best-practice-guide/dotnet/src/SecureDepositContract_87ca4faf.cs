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

namespace Arc56.Generated.gabrielkuettel.security_best_practice_guide.SecureDepositContract_87ca4faf
{


    public class SecureDepositContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SecureDepositContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task SetAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 114, 111, 134 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 114, 111, 134 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInToAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 233, 175, 133 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 233, 175, 133 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(AssetTransferTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 147, 53, 49, 134 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(AssetTransferTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 147, 53, 49, 134 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2VjdXJlRGVwb3NpdENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNldEFzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdEluVG9Bc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0OF0sImVycm9yTWVzc2FnZSI6Ik11c3Qgc2VuZCBub256ZXJvIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6Ik11c3Qgc2VuZCB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHNldCBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6Ildyb25nIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMsOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ05Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlYTnpaWFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZOQzEwY21GdWMyRmpkR2x2YmkxcGJuQjFkQzEyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRaV04xY21WRVpYQnZjMmwwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNMlEzTWpabU9EWWdNSGcyWm1VNVlXWTROU0F3ZURrek16VXpNVGcySUM4dklHMWxkR2h2WkNBaWMyVjBRWE56WlhRb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3ZEVsdVZHOUJjM05sZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaGhlR1psY2lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFFYTnpaWFFnYjNCMFNXNVViMEZ6YzJWMElHUmxjRzl6YVhRS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZOQzEwY21GdWMyRmpkR2x2YmkxcGJuQjFkQzEyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRaV04xY21WRVpYQnZjMmwwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k4MExYUnlZVzV6WVdOMGFXOXVMV2x1Y0hWMExYWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMlZqZFhKbFJHVndiM05wZEVOdmJuUnlZV04wTG5ObGRFRnpjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBRWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TkMxMGNtRnVjMkZqZEdsdmJpMXBibkIxZEMxMllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUkJjM05sZENoaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODBMWFJ5WVc1ellXTjBhVzl1TFdsdWNIVjBMWFpoYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeXdnSjA5dWJIa2dZM0psWVhSdmNpQmpZVzRnYzJWMElHRnpjMlYwSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUhObGRDQmhjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMelF0ZEhKaGJuTmhZM1JwYjI0dGFXNXdkWFF0ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCd2RXSnNhV01nWVdOalpYQjBaV1JCYzNObGRDQTlJRWRzYjJKaGJGTjBZWFJsUEVGemMyVjBQaWg3SUd0bGVUb2dKMkZ6YzJWMEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE56WlhRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TkMxMGNtRnVjMkZqZEdsdmJpMXBibkIxZEMxMllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklIUm9hWE11WVdOalpYQjBaV1JCYzNObGRDNTJZV3gxWlNBOUlHRnpjMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMelF0ZEhKaGJuTmhZM1JwYjI0dGFXNXdkWFF0ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFFYTnpaWFFvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMelF0ZEhKaGJuTmhZM1JwYjI0dGFXNXdkWFF0ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVFpXTjFjbVZFWlhCdmMybDBRMjl1ZEhKaFkzUXViM0IwU1c1VWIwRnpjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQjBTVzVVYjBGemMyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6UXRkSEpoYm5OaFkzUnBiMjR0YVc1d2RYUXRkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0IwU1c1VWIwRnpjMlYwS0dGemMyVjBPaUJCYzNObGRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6UXRkSEpoYm5OaFkzUnBiMjR0YVc1d2RYUXRkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQ0FuVDI1c2VTQmpjbVZoZEc5eUp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODBMWFJ5WVc1ellXTjBhVzl1TFdsdWNIVjBMWFpoYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnYVhSNGJpNWhjM05sZEZSeVlXNXpabVZ5S0hzZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNJR0Z6YzJWMFFXMXZkVzUwT2lBd0xDQm1aV1U2SURBZ2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgwTFhSeVlXNXpZV04wYVc5dUxXbHVjSFYwTFhaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUc5d2RFbHVWRzlCYzNObGRDaGhjM05sZERvZ1FYTnpaWFFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk5DMTBjbUZ1YzJGamRHbHZiaTFwYm5CMWRDMTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbE5sWTNWeVpVUmxjRzl6YVhSRGIyNTBjbUZqZEM1a1pYQnZjMmwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVndiM05wZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgwTFhSeVlXNXpZV04wYVc5dUxXbHVjSFYwTFhaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbGNHOXphWFFvY0dGNWJXVnVkRG9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TkMxMGNtRnVjMkZqZEdsdmJpMXBibkIxZEMxMllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG1GemMyVjBVbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0FuVFhWemRDQnpaVzVrSUhSdklHRndjQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxMWMzUWdjMlZ1WkNCMGJ5QmhjSEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5ODBMWFJ5WVc1ellXTjBhVzl1TFdsdWNIVjBMWFpoYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVlR1psY2tGemMyVjBMbWxrSUQwOVBTQjBhR2x6TG1GalkyVndkR1ZrUVhOelpYUXVkbUZzZFdVdWFXUXNJQ2RYY205dVp5QmhjM05sZENjcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTgwTFhSeVlXNXpZV04wYVc5dUxXbHVjSFYwTFhaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdGalkyVndkR1ZrUVhOelpYUWdQU0JIYkc5aVlXeFRkR0YwWlR4QmMzTmxkRDRvZXlCclpYazZJQ2RoYzNObGRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ6YzJWMElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpRdGRISmhibk5oWTNScGIyNHRhVzV3ZFhRdGRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1NFptVnlRWE56WlhRdWFXUWdQVDA5SUhSb2FYTXVZV05qWlhCMFpXUkJjM05sZEM1MllXeDFaUzVwWkN3Z0oxZHliMjVuSUdGemMyVjBKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZkeWIyNW5JR0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TkMxMGNtRnVjMkZqZEdsdmJpMXBibkIxZEMxMllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG1GemMyVjBRVzF2ZFc1MElENGdWV2x1ZERZMEtEQXBMQ0FuVFhWemRDQnpaVzVrSUc1dmJucGxjbThnWVcxdmRXNTBKeWtLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUc1dmJucGxjbThnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk5DMTBjbUZ1YzJGamRHbHZiaTFwYm5CMWRDMTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSEIxWW14cFl5QmtaWEJ2YzJsMEtIQmhlVzFsYm5RNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUJDWUJCV0Z6YzJWME1SdEJBQ1F4R1JSRU1SaEVnZ01FUFhKdmhnUnY2YStGQkpNMU1ZWTJHZ0NPQXdBTEFCOEFRUUF4R1JReEdCUVFSQ0pETmhvQlNSVWtFa1FYTVFBeUNSSkVLRXhuSWtNMkdnRkpGU1FTUkJjeEFESUpFa1N4TWdvanNoS3lGTElSSmJJUUk3SUJzeUpETVJZaUNVazRFQ1VTUkVrNEZESUtFa1JKT0JFaktHVkVFa1E0RWtRaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
