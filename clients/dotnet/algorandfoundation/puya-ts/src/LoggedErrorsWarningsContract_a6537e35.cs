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

namespace Arc56.Generated.algorandfoundation.puya_ts.LoggedErrorsWarningsContract_a6537e35
{


    public class LoggedErrorsWarningsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoggedErrorsWarningsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestInvalidCode(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 11, 194, 85 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestInvalidCode_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 11, 194, 85 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestCamelCaseCode(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 220, 252, 132 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCamelCaseCode_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 220, 252, 132 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestAerPrefix(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 212, 38, 196 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAerPrefix_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 212, 38, 196 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task TestLongMessage(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 133, 83, 105 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestLongMessage_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 133, 83, 105 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task Test8ByteMessage(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 59, 27, 126 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test8ByteMessage_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 59, 27, 126 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task Test32ByteMessage(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 166, 208, 103 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test32ByteMessage_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 166, 208, 103 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VkRXJyb3JzV2FybmluZ3NDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0SW52YWxpZENvZGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RDYW1lbENhc2VDb2RlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QUVSUHJlZml4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TG9uZ01lc3NhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Q4Qnl0ZU1lc3NhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QzMkJ5dGVNZXNzYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMwOSwzMTJdLCJlcnJvck1lc3NhZ2UiOiJBRVI6MDEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjksMzMyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOjAxOkkgd2lsbCBub3cgcHJvdmlkZSBhIHN1Y2NpbnQgZGVzY3JpcHRpb24gb2YgdGhlIGVycm9yLiBJIGd1ZXNzIGl0IGFsbCBzdGFydGVkIHdoZW4gSSB3YXMgNS4uLiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MiwzNzZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6MDE6YWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OSwyOTJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6TXlDb2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUwLDM1NF0sImVycm9yTWVzc2FnZSI6IkVSUjphYmNkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY5LDI3Ml0sImVycm9yTWVzc2FnZSI6IkVSUjpub3QtYWxudW0hIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYwLDI4MCwzMDAsMzIwLDM0MCwzNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSkZVbEk2Ym05MExXRnNiblZ0SVNJZ0lrVlNVanBOZVVOdlpHVWlJQ0pCUlZJNk1ERWlJQ0pGVWxJNk1ERTZTU0IzYVd4c0lHNXZkeUJ3Y205MmFXUmxJR0VnYzNWalkybHVkQ0JrWlhOamNtbHdkR2x2YmlCdlppQjBhR1VnWlhKeWIzSXVJRWtnWjNWbGMzTWdhWFFnWVd4c0lITjBZWEowWldRZ2QyaGxiaUJKSUhkaGN5QTFMaTR1SWlBaVJWSlNPbUZpWTJRaUlDSkZVbEk2TURFNllXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxYZGhjbTVwYm1kekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRXh2WjJkbFpFVnljbTl5YzFkaGNtNXBibWR6UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UTUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHSmxNR0pqTWpVMUlEQjROek5rWTJaak9EUWdNSGcyTUdRME1qWmpOQ0F3ZUdZME9EVTFNelk1SURCNE1HVXpZakZpTjJVZ01IZ3lNbUUyWkRBMk55QXZMeUJ0WlhSb2IyUWdJblJsYzNSSmJuWmhiR2xrUTI5a1pTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFTmhiV1ZzUTJGelpVTnZaR1VvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JCUlZKUWNtVm1hWGdvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JNYjI1blRXVnpjMkZuWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZERoQ2VYUmxUV1Z6YzJGblpTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRETXlRbmwwWlUxbGMzTmhaMlVvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjBaWE4wU1c1MllXeHBaRU52WkdVZ2RHVnpkRU5oYldWc1EyRnpaVU52WkdVZ2RHVnpkRUZGVWxCeVpXWnBlQ0IwWlhOMFRHOXVaMDFsYzNOaFoyVWdkR1Z6ZERoQ2VYUmxUV1Z6YzJGblpTQjBaWE4wTXpKQ2VYUmxUV1Z6YzJGblpRb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxYZGhjbTVwYm1kekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRXh2WjJkbFpFVnljbTl5YzFkaGNtNXBibWR6UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMmRuWldRdFpYSnliM0p6TFhkaGNtNXBibWR6TG1Gc1oyOHVkSE02T2t4dloyZGxaRVZ5Y205eWMxZGhjbTVwYm1kelEyOXVkSEpoWTNRdWRHVnpkRWx1ZG1Gc2FXUkRiMlJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRWx1ZG1Gc2FXUkRiMlJsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdGQyRnlibWx1WjNNdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRFbHVkbUZzYVdSRGIyUmxLR0Z5WnpvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5MTNZWEp1YVc1bmN5NWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hoY21jZ0lUMDlJREVzSUNkdWIzUXRZV3h1ZFcwaEp5a0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FoUFFvZ0lDQWdZbTU2SUhSbGMzUkpiblpoYkdsa1EyOWtaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVJWSlNPbTV2ZEMxaGJHNTFiU0VpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZibTkwTFdGc2JuVnRJUW9LZEdWemRFbHVkbUZzYVdSRGIyUmxYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXRkMkZ5Ym1sdVozTXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QnNiMmRuWldSRmNuSW9KMjV2ZEMxaGJHNTFiU0VuS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUlZKU09tNXZkQzFoYkc1MWJTRWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNmJtOTBMV0ZzYm5WdElRb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxYZGhjbTVwYm1kekxtRnNaMjh1ZEhNNk9reHZaMmRsWkVWeWNtOXljMWRoY201cGJtZHpRMjl1ZEhKaFkzUXVkR1Z6ZEVOaGJXVnNRMkZ6WlVOdlpHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFEyRnRaV3hEWVhObFEyOWtaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMmRuWldRdFpYSnliM0p6TFhkaGNtNXBibWR6TG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhCMVlteHBZeUIwWlhOMFEyRnRaV3hEWVhObFEyOWtaU2hoY21jNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXRkMkZ5Ym1sdVozTXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dGeVp5QWhQVDBnTVN3Z0owMTVRMjlrWlNjcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUIwWlhOMFEyRnRaV3hEWVhObFEyOWtaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVJWSlNPazE1UTI5a1pTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwTmVVTnZaR1VLQ25SbGMzUkRZVzFsYkVOaGMyVkRiMlJsWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk10ZDJGeWJtbHVaM011WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYkc5bloyVmtSWEp5S0NkTmVVTnZaR1VuS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpUlZKU09rMTVRMjlrWlNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBOZVVOdlpHVUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5MTNZWEp1YVc1bmN5NWhiR2R2TG5Sek9qcE1iMmRuWldSRmNuSnZjbk5YWVhKdWFXNW5jME52Ym5SeVlXTjBMblJsYzNSQlJWSlFjbVZtYVhoYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUVVWU1VISmxabWw0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdGQyRnlibWx1WjNNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUkJSVkpRY21WbWFYZ29ZWEpuT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxYZGhjbTVwYm1kekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hoY21jZ0lUMDlJREVzSUNjd01TY3NJSHNnY0hKbFptbDRPaUFuUVVWU0p5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNFOUNpQWdJQ0JpYm5vZ2RHVnpkRUZGVWxCeVpXWnBlRjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVFVVlNPakF4SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1FVVlNPakF4Q2dwMFpYTjBRVVZTVUhKbFptbDRYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXRkMkZ5Ym1sdVozTXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdiRzluWjJWa1JYSnlLQ2N3TVNjc0lIc2djSEpsWm1sNE9pQW5RVVZTSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVFVVlNPakF4SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1FVVlNPakF4Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZaMmRsWkMxbGNuSnZjbk10ZDJGeWJtbHVaM011WVd4bmJ5NTBjem82VEc5bloyVmtSWEp5YjNKelYyRnlibWx1WjNORGIyNTBjbUZqZEM1MFpYTjBURzl1WjAxbGMzTmhaMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBURzl1WjAxbGMzTmhaMlU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzluWjJWa0xXVnljbTl5Y3kxM1lYSnVhVzVuY3k1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRFeHZibWROWlhOellXZGxLR0Z5WnpvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5bloyVmtMV1Z5Y205eWN5MTNZWEp1YVc1bmN5NWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWVhKbklDRTlQU0F4TENBbk1ERW5MQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0lUMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMWGRoY201cGJtZHpMbUZzWjI4dWRITTZNakV0TWpNS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhjbWNnSVQwOUlERXNJQ2N3TVNjc0lIc0tJQ0FnSUM4dklDQWdiV1Z6YzJGblpUb2dKMGtnZDJsc2JDQnViM2NnY0hKdmRtbGtaU0JoSUhOMVkyTnBiblFnWkdWelkzSnBjSFJwYjI0Z2IyWWdkR2hsSUdWeWNtOXlMaUJKSUdkMVpYTnpJR2wwSUdGc2JDQnpkR0Z5ZEdWa0lIZG9aVzRnU1NCM1lYTWdOUzR1TGljc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWW01NklIUmxjM1JNYjI1blRXVnpjMkZuWlY5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV05mTXlBdkx5QWlSVkpTT2pBeE9ra2dkMmxzYkNCdWIzY2djSEp2ZG1sa1pTQmhJSE4xWTJOcGJuUWdaR1Z6WTNKcGNIUnBiMjRnYjJZZ2RHaGxJR1Z5Y205eUxpQkpJR2QxWlhOeklHbDBJR0ZzYkNCemRHRnlkR1ZrSUhkb1pXNGdTU0IzWVhNZ05TNHVMaUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1Vqb3dNVHBKSUhkcGJHd2dibTkzSUhCeWIzWnBaR1VnWVNCemRXTmphVzUwSUdSbGMyTnlhWEIwYVc5dUlHOW1JSFJvWlNCbGNuSnZjaTRnU1NCbmRXVnpjeUJwZENCaGJHd2djM1JoY25SbFpDQjNhR1Z1SUVrZ2QyRnpJRFV1TGk0S0NuUmxjM1JNYjI1blRXVnpjMkZuWlY5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMmRuWldRdFpYSnliM0p6TFhkaGNtNXBibWR6TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUd4dloyZGxaRVZ5Y2lnbk1ERW5MQ0I3SUcxbGMzTmhaMlU2SUNkSklIZHBiR3dnYm05M0lIQnliM1pwWkdVZ1lTQnpkV05qYVc1MElHUmxjMk55YVhCMGFXOXVJRzltSUhSb1pTQmxjbkp2Y2k0Z1NTQm5kV1Z6Y3lCcGRDQmhiR3dnYzNSaGNuUmxaQ0IzYUdWdUlFa2dkMkZ6SURVdUxpNG5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNk1ERTZTU0IzYVd4c0lHNXZkeUJ3Y205MmFXUmxJR0VnYzNWalkybHVkQ0JrWlhOamNtbHdkR2x2YmlCdlppQjBhR1VnWlhKeWIzSXVJRWtnWjNWbGMzTWdhWFFnWVd4c0lITjBZWEowWldRZ2QyaGxiaUJKSUhkaGN5QTFMaTR1SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPakF4T2trZ2QybHNiQ0J1YjNjZ2NISnZkbWxrWlNCaElITjFZMk5wYm5RZ1pHVnpZM0pwY0hScGIyNGdiMllnZEdobElHVnljbTl5TGlCSklHZDFaWE56SUdsMElHRnNiQ0J6ZEdGeWRHVmtJSGRvWlc0Z1NTQjNZWE1nTlM0dUxnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJkblpXUXRaWEp5YjNKekxYZGhjbTVwYm1kekxtRnNaMjh1ZEhNNk9reHZaMmRsWkVWeWNtOXljMWRoY201cGJtZHpRMjl1ZEhKaFkzUXVkR1Z6ZERoQ2VYUmxUV1Z6YzJGblpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRNFFubDBaVTFsYzNOaFoyVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTEzWVhKdWFXNW5jeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZERoQ2VYUmxUV1Z6YzJGblpTaGhjbWM2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdGQyRnlibWx1WjNNdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR0Z5WnlBaFBUMGdNU3dnSjJGaVkyUW5LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNFOUNpQWdJQ0JpYm5vZ2RHVnpkRGhDZVhSbFRXVnpjMkZuWlY5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTkNBdkx5QWlSVkpTT21GaVkyUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNllXSmpaQW9LZEdWemREaENlWFJsVFdWemMyRm5aVjloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyZG5aV1F0WlhKeWIzSnpMWGRoY201cGJtZHpMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR3h2WjJkbFpFVnljaWduWVdKalpDY3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSkZVbEk2WVdKalpDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwaFltTmtDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dloyZGxaQzFsY25KdmNuTXRkMkZ5Ym1sdVozTXVZV3huYnk1MGN6bzZURzluWjJWa1JYSnliM0p6VjJGeWJtbHVaM05EYjI1MGNtRmpkQzUwWlhOME16SkNlWFJsVFdWemMyRm5aVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUXpNa0o1ZEdWTlpYTnpZV2RsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdGQyRnlibWx1WjNNdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUXpNa0o1ZEdWTlpYTnpZV2RsS0dGeVp6b2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOW5aMlZrTFdWeWNtOXljeTEzWVhKdWFXNW5jeTVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1lYSm5JQ0U5UFNBeExDQW5NREVuTENCN0lHMWxjM05oWjJVNklDZGhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNFOUNpQWdJQ0JpYm5vZ2RHVnpkRE15UW5sMFpVMWxjM05oWjJWZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJa1ZTVWpvd01UcGhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2pBeE9tRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdFS0NuUmxjM1F6TWtKNWRHVk5aWE56WVdkbFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WjJkbFpDMWxjbkp2Y25NdGQyRnlibWx1WjNNdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2JHOW5aMlZrUlhKeUtDY3dNU2NzSUhzZ2JXVnpjMkZuWlRvZ0oyRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdFbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSkZVbEk2TURFNllXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVam93TVRwaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNDQUVtQmc1RlVsSTZibTkwTFdGc2JuVnRJUXBGVWxJNlRYbERiMlJsQmtGRlVqb3dNV1JGVWxJNk1ERTZTU0IzYVd4c0lHNXZkeUJ3Y205MmFXUmxJR0VnYzNWalkybHVkQ0JrWlhOamNtbHdkR2x2YmlCdlppQjBhR1VnWlhKeWIzSXVJRWtnWjNWbGMzTWdhWFFnWVd4c0lITjBZWEowWldRZ2QyaGxiaUJKSUhkaGN5QTFMaTR1Q0VWU1VqcGhZbU5rSUVWU1Vqb3dNVHBoWVdGaFlXRmhZV0ZoWVdGaFlXRmhZV0ZoWVdGaFlXRmhNUnRCQURreEdSUkVNUmhFZ2dZRXZndkNWUVJ6M1B5RUJHRFVKc1FFOUlWVGFRUU9PeHQrQkNLbTBHYzJHZ0NPQmdBSkFCMEFNUUJGQUZrQWJ3QXhHUlF4R0JRUVF6WWFBVWtWSWhKRUZ5TVRRQUFES0xBQUtMQUFOaG9CU1JVaUVrUVhJeE5BQUFNcHNBQXBzQUEyR2dGSkZTSVNSQmNqRTBBQUF5cXdBQ3F3QURZYUFVa1ZJaEpFRnlNVFFBQURLN0FBSzdBQU5ob0JTUlVpRWtRWEl4TkFBQVFuQkxBQUp3U3dBRFlhQVVrVkloSkVGeU1UUUFBRUp3V3dBQ2NGc0FBPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
