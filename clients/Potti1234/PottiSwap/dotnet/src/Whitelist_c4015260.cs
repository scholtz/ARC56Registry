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

namespace Arc56.Generated.Potti1234.PottiSwap.Whitelist_c4015260
{


    public class WhitelistProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public WhitelistProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="factoryAppId"> </param>
        public async Task CreateWhitelist(ulong factoryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 99, 10, 53 };
            var factoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAppIdAbi.From(factoryAppId);

            var result = await base.CallApp(new List<object> { abiHandle, factoryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateWhitelist_Transactions(ulong factoryAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 99, 10, 53 };
            var factoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAppIdAbi.From(factoryAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, factoryAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task AddToWhitelist(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 243, 160, 182 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddToWhitelist_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 243, 160, 182 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task RemoveFromWhitelist(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 136, 51, 157 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveFromWhitelist_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 136, 51, 157 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task<bool> IsWhitelisted(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 107, 235, 227 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.SimApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsWhitelisted_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 107, 235, 227 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiV2hpdGVsaXN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZVdoaXRlbGlzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmYWN0b3J5QXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVG9XaGl0ZWxpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlRnJvbVdoaXRlbGlzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1doaXRlbGlzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODFdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYXV0aG9yaXplZCB0byBhZGQgdG8gd2hpdGVsaXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoiTm90IGF1dGhvcml6ZWQgdG8gcmVtb3ZlIGZyb20gd2hpdGVsaXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUsMTA3LDEyMywxMzldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OCwxMTAsMTI2LDE0Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzcsMTk4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ptWVdOMGIzSjVRWEJ3U1dRaUlDSjNhR2wwWld4cGMzUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTkzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1YyaHBkR1ZzYVhOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pOall6TUdFek5TQXdlRGMzWmpOaE1HSTJJREI0TWpnNE9ETXpPV1FnTUhobVpqWmlaV0psTXlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlZkb2FYUmxiR2x6ZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrVkc5WGFHbDBaV3hwYzNRb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYlc5MlpVWnliMjFYYUdsMFpXeHBjM1FvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpWMmhwZEdWc2FYTjBaV1FvZFdsdWREWTBLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVmRvYVhSbGJHbHpkRjl5YjNWMFpVQXpJRzFoYVc1ZllXUmtWRzlYYUdsMFpXeHBjM1JmY205MWRHVkFOQ0J0WVdsdVgzSmxiVzkyWlVaeWIyMVhhR2wwWld4cGMzUmZjbTkxZEdWQU5TQnRZV2x1WDJselYyaHBkR1ZzYVhOMFpXUmZjbTkxZEdWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmRvYVhSbGJHbHpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhWE5YYUdsMFpXeHBjM1JsWkY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTkzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1YyaHBkR1ZzYVhOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQnBjMWRvYVhSbGJHbHpkR1ZrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVnRiM1psUm5KdmJWZG9hWFJsYkdsemRGOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5M2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWMmhwZEdWc2FYTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ5WlcxdmRtVkdjbTl0VjJocGRHVnNhWE4wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZrWkZSdlYyaHBkR1ZzYVhOMFgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlhhR2wwWld4cGMzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTkzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0ZrWkZSdlYyaHBkR1ZzYVhOMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVmRvYVhSbGJHbHpkRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJYYUdsMFpXeHBjM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5M2FHbDBaV3hwYzNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxWMmhwZEdWc2FYTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmRvYVhSbGJHbHpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UTUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk9sZG9hWFJsYkdsemRDNWpjbVZoZEdWWGFHbDBaV3hwYzNRb1ptRmpkRzl5ZVVGd2NFbGtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbU55WldGMFpWZG9hWFJsYkdsemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM2RvYVhSbGJHbHpkQzVoYkdkdkxuUnpPamd0T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxWMmhwZEdWc2FYTjBLR1poWTNSdmNubEJjSEJKWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMM2RvYVhSbGJHbHpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1poWTNSdmNubEJjSEJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVpoWTNSdmNubEJjSEJKWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QjBhR2x6TG1aaFkzUnZjbmxCY0hCSlpDNTJZV3gxWlNBOUlHWmhZM1J2Y25sQmNIQkpaRHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pwWGFHbDBaV3hwYzNRdVlXUmtWRzlYYUdsMFpXeHBjM1FvWVhCd1NXUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZV1JrVkc5WGFHbDBaV3hwYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3hNeTB4TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nWVdSa1ZHOVhhR2wwWld4cGMzUW9ZWEJ3U1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTkzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJtWVdOMGIzSjVRWEJ3U1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlabUZqZEc5eWVVRndjRWxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NW1ZV04wYjNKNVFYQndTV1F1ZG1Gc2RXVWdQVDA5SUZSNGJpNWhjSEJzYVdOaGRHbHZia2xrTG1sa0xDQWlUbTkwSUdGMWRHaHZjbWw2WldRZ2RHOGdZV1JrSUhSdklIZG9hWFJsYkdsemRDSXBPd29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGMWRHaHZjbWw2WldRZ2RHOGdZV1JrSUhSdklIZG9hWFJsYkdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSFJvYVhNdWQyaHBkR1ZzYVhOMEtHRndjRWxrS1M1MllXeDFaU0E5SURFN0lDOHZJREVnYldWaGJuTWdkMmhwZEdWc2FYTjBaV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnZDJocGRHVnNhWE4wSUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0luZG9hWFJsYkdsemRDSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ozYUdsMFpXeHBjM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QjBhR2x6TG5kb2FYUmxiR2x6ZENoaGNIQkpaQ2t1ZG1Gc2RXVWdQU0F4T3lBdkx5QXhJRzFsWVc1eklIZG9hWFJsYkdsemRHVmtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02T2xkb2FYUmxiR2x6ZEM1eVpXMXZkbVZHY205dFYyaHBkR1ZzYVhOMEtHRndjRWxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25KbGJXOTJaVVp5YjIxWGFHbDBaV3hwYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OTNhR2wwWld4cGMzUXVZV3huYnk1MGN6b3hPUzB5TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nY21WdGIzWmxSbkp2YlZkb2FYUmxiR2x6ZENoaGNIQkpaRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHWmhZM1J2Y25sQmNIQkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbVlXTjBiM0o1UVhCd1NXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1aaFkzUnZjbmxCY0hCSlpDNTJZV3gxWlNBOVBUMGdWSGh1TG1Gd2NHeHBZMkYwYVc5dVNXUXVhV1FzSUNKT2IzUWdZWFYwYUc5eWFYcGxaQ0IwYnlCeVpXMXZkbVVnWm5KdmJTQjNhR2wwWld4cGMzUWlLVHNLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCaGRYUm9iM0pwZW1Wa0lIUnZJSEpsYlc5MlpTQm1jbTl0SUhkb2FYUmxiR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdmQyaHBkR1ZzYVhOMExtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklIUm9hWE11ZDJocGRHVnNhWE4wS0dGd2NFbGtLUzVrWld4bGRHVW9LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012ZDJocGRHVnNhWE4wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnZDJocGRHVnNhWE4wSUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0luZG9hWFJsYkdsemRDSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ozYUdsMFpXeHBjM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QjBhR2x6TG5kb2FYUmxiR2x6ZENoaGNIQkpaQ2t1WkdWc1pYUmxLQ2s3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qcFhhR2wwWld4cGMzUXVhWE5YYUdsMFpXeHBjM1JsWkNoaGNIQkpaRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21selYyaHBkR1ZzYVhOMFpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTkzYUdsMFpXeHBjM1F1WVd4bmJ5NTBjem95TlMweU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5QndkV0pzYVdNZ2FYTlhhR2wwWld4cGMzUmxaQ2hoY0hCSlpEb2dkV2x1ZERZMEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwzZG9hWFJsYkdsemRDNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUzYUdsMFpXeHBjM1FvWVhCd1NXUXBMbVY0YVhOMGN6c0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZkMmhwZEdWc2FYTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdkMmhwZEdWc2FYTjBJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW5kb2FYUmxiR2x6ZENJZ2ZTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNhR2wwWld4cGMzUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDNkb2FYUmxiR2x6ZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTNhR2wwWld4cGMzUW9ZWEJ3U1dRcExtVjRhWE4wY3pzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BZ3htWVdOMGIzSjVRWEJ3U1dRSmQyaHBkR1ZzYVhOME1SdEJBSFdDQkFRMll3bzFCSGZ6b0xZRUtJZ3puUVQvYSt2ak5ob0FqZ1FBUWdBeUFDSUFBaU5ETVJrVVJERVlSRFlhQVJlSUFINkFBUUFqVHdKVWdBUVZIM3gxVEZDd0lrTXhHUlJFTVJoRU5ob0JGNGdBU2lKRE1Sa1VSREVZUkRZYUFSZUlBQ1VpUXpFWkZFUXhHRVEyR2dFWGlBQU5Ja014R1VEL3FURVlGRVFpUTRvQkFDaUwvMmVKaWdFQUl5aGxSREVZRWtTTC94WXBURkFpRnIrSmlnRUFJeWhsUkRFWUVrU0wveFlwVEZDOFNJbUtBUUdML3hZcFRGQzlSUUdKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
