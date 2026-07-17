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

namespace Arc56.Generated.algorandfoundation.puya.Caller_54e8ca28
{


    public class CallerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CallerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithTxn(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 181, 53, 99 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithTxn_Transactions(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 181, 53, 99 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithAcfg(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 106, 106, 222 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithAcfg_Transactions(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 106, 106, 222 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithInfer(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 129, 255, 128 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithInfer_Transactions(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 129, 255, 128 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithAcfgNoReturn(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 181, 15, 28 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithAcfgNoReturn_Transactions(byte[] a, byte[] b, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 181, 15, 28 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FsbGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfY2FsbF93aXRoX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9jYWxsX3dpdGhfYWNmZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9jYWxsX3dpdGhfaW5mZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfY2FsbF93aXRoX2FjZmdfbm9fcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXNzZXQgaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTZdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCB0byBiZSBjcmVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYsOTksMTg4LDIwMSwyNjEsMjc0LDMzNCwzNDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MywxMDYsMTk1LDIwOCwyNjgsMjgxLDM0MSwzNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0LDIxNiwyODksMzYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKVVJWTlVJaUFpVkZOVUlpQXdlRFprTkRjd01HRmtJREI0TXpFS0lDQWdJQzh2SUhSNWNHVmtYMmwwZUc1ZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG94TkFvZ0lDQWdMeThnWTJ4aGMzTWdRMkZzYkdWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1HRmlOVE0xTmpNZ01IaGxZVFpoTm1Ga1pTQXdlREl6T0RGbVpqZ3dJREI0TURCaU5UQm1NV01nTHk4Z2JXVjBhRzlrSUNKMFpYTjBYMk5oYkd4ZmQybDBhRjkwZUc0b1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjlqWVd4c1gzZHBkR2hmWVdObVp5aGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wWDJOaGJHeGZkMmwwYUY5cGJtWmxjaWhpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFgyTmhiR3hmZDJsMGFGOWhZMlpuWDI1dlgzSmxkSFZ5YmloaWVYUmxXMTBzWW5sMFpWdGRMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2RHVnpkRjlqWVd4c1gzZHBkR2hmZEhodUlIUmxjM1JmWTJGc2JGOTNhWFJvWDJGalptY2dkR1Z6ZEY5allXeHNYM2RwZEdoZmFXNW1aWElnZEdWemRGOWpZV3hzWDNkcGRHaGZZV05tWjE5dWIxOXlaWFIxY200S0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpNWpZV3hzWlhJdVEyRnNiR1Z5TG5SbGMzUmZZMkZzYkY5M2FYUm9YM1I0Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmWTJGc2JGOTNhWFJvWDNSNGJqb0tJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1qa0tJQ0FnSUM4dklHRndjRjlqWVd4c1gzUjRiaUE5SUdGd2NGOWpZV3hzTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1qQUtJQ0FnSUM4dklIUnZkR0ZzUFRFc0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1Ua0tJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVTlJbFJGVTFRaUxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVZFVlRWQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TVRnS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQwaVZGTlVJaXdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbFJUVkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPakUzQ2lBZ0lDQXZMeUIwZUc0Z1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2RIbHdaV1JmYVhSNGJsOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pJNUNpQWdJQ0F2THlCaGNIQmZZMkZzYkY5MGVHNGdQU0JoY0hCZlkyRnNiQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveU13b2dJQ0FnTHk4Z1ZIaHVRMjl1ZEhKaFkzUXVZMkZzYkY5M2FYUm9YM1I0Yml3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFeFpqVXdOREJrSUM4dklHMWxkR2h2WkNBaVkyRnNiRjkzYVhSb1gzUjRiaWhpZVhSbFcxMHNkSGh1TEdKNWRHVmJYU2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNakl0TWpnS0lDQWdJQzh2SUdGd2NGOWpZV3hzSUQwZ2FYUjRiaTVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNURiMjUwY21GamRDNWpZV3hzWDNkcGRHaGZkSGh1TEFvZ0lDQWdMeThnSUNBZ0lHRXNDaUFnSUNBdkx5QWdJQ0FnZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveU9Rb2dJQ0FnTHk4Z1lYQndYMk5oYkd4ZmRIaHVJRDBnWVhCd1gyTmhiR3d1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvek1Bb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQmhjSEJmWTJGc2JGOTBlRzR1Y21WemRXeDBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TXpFS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRGOXBaQ3dnSW1WNGNHVmpkR1ZrSUdGemMyVjBJR2xrSWdvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z6YzJWMElHbGtDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHVZMkZzYkdWeUxrTmhiR3hsY2k1MFpYTjBYMk5oYkd4ZmQybDBhRjloWTJablczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aem9LSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3pNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZORGNLSUNBZ0lDOHZJR0Z3Y0Y5allXeHNMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TXpnS0lDQWdJQzh2SUhSdmRHRnNQVEVzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TXpjS0lDQWdJQzh2SUdGemMyVjBYMjVoYldVOUlsUkZVMVFpTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpVkVWVFZDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNellLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpVkZOVUlpd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsUlRWQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ0x5OGdkSGx3WldSZmFYUjRibDloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qTTFDaUFnSUNBdkx5QjBlRzRnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPalEzQ2lBZ0lDQXZMeUJoY0hCZlkyRnNiQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvME1Rb2dJQ0FnTHk4Z1ZIaHVRMjl1ZEhKaFkzUXVZMkZzYkY5M2FYUm9YMkZqWm1jc0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpWTJGc2JGOTNhWFJvWDJGalptY29ZbmwwWlZ0ZExHRmpabWNzWW5sMFpWdGRLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBNQzAwTmdvZ0lDQWdMeThnWVhCd1gyTmhiR3dnUFNCcGRIaHVMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJrTnZiblJ5WVdOMExtTmhiR3hmZDJsMGFGOWhZMlpuTEFvZ0lDQWdMeThnSUNBZ0lHRXNDaUFnSUNBdkx5QWdJQ0FnZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvME53b2dJQ0FnTHk4Z1lYQndYMk5oYkd3dWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmYVhSNGJsOWhZbWxmWTJGc2JGOTBlRzR1WTJGc2JHVnlMa05oYkd4bGNpNTBaWE4wWDJOaGJHeGZkMmwwYUY5cGJtWmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZZMkZzYkY5M2FYUm9YMmx1Wm1WeU9nb2dJQ0FnTHk4Z2RIbHdaV1JmYVhSNGJsOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvMk13b2dJQ0FnTHk4Z1lYQndYMk5oYkd3dWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzFOQW9nSUNBZ0x5OGdkRzkwWVd3OU1Td0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzFNd29nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDBpVkVWVFZDSXNDaUFnSUNCaWVYUmxZMTh3SUM4dklDSlVSVk5VSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvMU1nb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBTSlVVMVFpTEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVkZOVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TlRFS0lDQWdJQzh2SUhSNGJpQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk5qTUtJQ0FnSUM4dklHRndjRjlqWVd4c0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPalUyTFRZeUNpQWdJQ0F2THlCaGNIQmZZMkZzYkNBOUlHbDBlRzR1WVdKcFgyTmhiR3hiVlVsdWREWTBYU2dLSUNBZ0lDOHZJQ0FnSUNBaVkyRnNiRjkzYVhSb1gyRmpabWNpTEFvZ0lDQWdMeThnSUNBZ0lHRXNDaUFnSUNBdkx5QWdJQ0FnZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z2JXVjBhRzlrSUNKallXeHNYM2RwZEdoZllXTm1aeWhpZVhSbFcxMHNZV05tWnl4aWVYUmxXMTBwZFdsdWREWTBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPall6Q2lBZ0lDQXZMeUJoY0hCZlkyRnNiQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklIUjVjR1ZrWDJsMGVHNWZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpNWpZV3hzWlhJdVEyRnNiR1Z5TG5SbGMzUmZZMkZzYkY5M2FYUm9YMkZqWm1kZmJtOWZjbVYwZFhKdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTQ2Q2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPamMxQ2lBZ0lDQXZMeUIwZUc0eElEMGdZWEJ3WDJOaGJHd3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhSNWNHVmtYMmwwZUc1ZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8zTUFvZ0lDQWdMeThnZEc5MFlXdzlNU3dLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhSNWNHVmtYMmwwZUc1ZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8yT1FvZ0lDQWdMeThnWVhOelpYUmZibUZ0WlQwaVZFVlRWQ0lzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pVUlZOVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFNWhiV1VLSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzJPQW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pVVTFRaUxBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVZGTlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QjBlWEJsWkY5cGRIaHVYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk5qY0tJQ0FnSUM4dklHRmpabWNnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPamMxQ2lBZ0lDQXZMeUIwZUc0eElEMGdZWEJ3WDJOaGJHd3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZibVY0ZEFvZ0lDQWdMeThnZEhsd1pXUmZhWFI0Ymw5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPamN6Q2lBZ0lDQXZMeUJVZUc1RGIyNTBjbUZqZEM1allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRzSUdFc0lHRmpabWNzSUdJc0lHRndjRjlwWkQxaGNIQXNJRzV2ZEdVOVlpSXhJZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRE14Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6ZzBNREEzTjJRZ0x5OGdiV1YwYUc5a0lDSmpZV3hzWDNkcGRHaGZZV05tWjE5dWIxOXlaWFIxY200b1lubDBaVnRkTEdGalptY3NZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCMGVYQmxaRjlwZEhodVgyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TnpJdE56UUtJQ0FnSUM4dklHRndjRjlqWVd4c0lEMGdhWFI0Ymk1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmWVdObVoxOXViMTl5WlhSMWNtNHNJR0VzSUdGalptY3NJR0lzSUdGd2NGOXBaRDFoY0hBc0lHNXZkR1U5WWlJeElnb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2RIbHdaV1JmYVhSNGJsOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pjMUNpQWdJQ0F2THlCMGVHNHhJRDBnWVhCd1gyTmhiR3d1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRTV2ZEdVS0lDQWdJQzh2SUhSNWNHVmtYMmwwZUc1ZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8zTmdvZ0lDQWdMeThnWVhOelpYSjBJSFI0YmpFdWJtOTBaU0E5UFNCaUlqRWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNekVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFI1Y0dWa1gybDBlRzVmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzNPUW9nSUNBZ0x5OGdZWE56WlhSZmFXUWdQU0J2Y0M1SFNWUjRiaTVqY21WaGRHVmtYMkZ6YzJWMFgybGtLREFwQ2lBZ0lDQm5hWFI0YmlBd0lFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUIwZVhCbFpGOXBkSGh1WDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZPREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjM05sZEY5cFpDd2dJbVY0Y0dWamRHVmtJR0Z6YzJWMElIUnZJR0psSUdOeVpXRjBaV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZWE56WlhRZ2RHOGdZbVVnWTNKbFlYUmxaQW9nSUNBZ0x5OGdkSGx3WldSZmFYUjRibDloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qWTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCQ0NZRUJGUkZVMVFEVkZOVUJHMUhBSzBCTVRFYlFRQXJNUmtVUkRFWVJJSUVCQXExTldNRTZtcHEzZ1FqZ2YrQUJBQzFEeHcyR2dDT0JBQUpBRzhBdUFFQkFERVpGREVZRkJCRE5ob0JTU0paSXdoTEFSVVNSRFlhQWtraVdTTUlTd0VWRWtRMkdnTkpGU1VTUkJleEpMSWlLTEltS2JJbGdRT3lFQ0t5QWJheUdJQUVvZlVFRGJJYVRMSWFzaHFCQnJJUUlySUJzN1ErU1ZjQUJJQUVGUjk4ZFJKRVZ3UUFTUlVsRWtRWFJDUkROaG9CU1NKWkl3aExBUlVTUkRZYUFra2lXU01JU3dFVkVrUTJHZ05KRlNVU1JCZXhKTElpS0xJbUtiSWxnUU95RUNLeUFiYXlHQ3F5R2t5eUdySWFnUWF5RUNLeUFiTWtRellhQVVraVdTTUlTd0VWRWtRMkdnSkpJbGtqQ0VzQkZSSkVOaG9EU1JVbEVrUVhzU1N5SWlpeUppbXlKWUVEc2hBaXNnRzJzaGdxc2hwTXNocXlHb0VHc2hBaXNnR3pKRU0yR2dGSklsa2pDRXNCRlJKRU5ob0NTU0paSXdoTEFSVVNSRFlhQTBrVkpSSkVGN0Vrc2lJb3NpWXBzaVdCQTdJUUlySUJ0aXV5QmJJWWdBVElRQWQ5c2hwTXNocXlHb0VHc2hBaXNnR3p0QVVyRWtTM0FEeEVKRU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
