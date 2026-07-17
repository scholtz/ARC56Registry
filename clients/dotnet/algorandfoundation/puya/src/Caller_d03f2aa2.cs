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

namespace Arc56.Generated.algorandfoundation.puya.Caller_d03f2aa2
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FsbGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfY2FsbF93aXRoX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9jYWxsX3dpdGhfYWNmZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9jYWxsX3dpdGhfaW5mZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfY2FsbF93aXRoX2FjZmdfbm9fcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2OCwyNjAsMzQ5XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbG9nIHZhbHVlIGlzIG5vdCB0aGUgcmVzdWx0IG9mIGFuIEFCSSByZXR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IHRvIGJlIGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OSwxMDIsMTg2LDE5OSwyNzUsMjg4LDM2NCwzNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NiwxMDksMTkzLDIwNiwyODIsMjk1LDM3MSwzODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3LDIxNCwzMDMsMzkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc2LDI2NywzNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNU0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pVUlZOVUlpQWlWRk5VSWlBd2VERTFNV1kzWXpjMUlEQjRObVEwTnpBd1lXUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNVFFLSUNBZ0lDOHZJR05zWVhOeklFTmhiR3hsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURCaFlqVXpOVFl6SURCNFpXRTJZVFpoWkdVZ01IZ3lNemd4Wm1ZNE1DQXdlREF3WWpVd1pqRmpJQzh2SUcxbGRHaHZaQ0FpZEdWemRGOWpZV3hzWDNkcGRHaGZkSGh1S0dKNWRHVmJYU3hpZVhSbFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5SbGMzUmZZMkZzYkY5M2FYUm9YMkZqWm1jb1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjlqWVd4c1gzZHBkR2hmYVc1bVpYSW9ZbmwwWlZ0ZExHSjVkR1ZiWFN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRvWW5sMFpWdGRMR0o1ZEdWYlhTeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZZMkZzYkY5M2FYUm9YM1I0YmlCMFpYTjBYMk5oYkd4ZmQybDBhRjloWTJabklIUmxjM1JmWTJGc2JGOTNhWFJvWDJsdVptVnlJSFJsYzNSZlkyRnNiRjkzYVhSb1gyRmpabWRmYm05ZmNtVjBkWEp1Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1URTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMbU5oYkd4bGNpNURZV3hzWlhJdWRHVnpkRjlqWVd4c1gzZHBkR2hmZEhodVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5allXeHNYM2RwZEdoZmRIaHVPZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG94TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qSXlMVEk0Q2lBZ0lDQXZMeUJoYzNObGRGOXBaQ3dnWDNSNGJpQTlJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdWSGh1UTI5dWRISmhZM1F1WTJGc2JGOTNhWFJvWDNSNGJpd0tJQ0FnSUM4dklDQWdJQ0JoTEFvZ0lDQWdMeThnSUNBZ0lIUjRiaXdLSUNBZ0lDOHZJQ0FnSUNCaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWhjSEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPakl3Q2lBZ0lDQXZMeUIwYjNSaGJEMHhMQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveE9Rb2dJQ0FnTHk4Z1lYTnpaWFJmYm1GdFpUMGlWRVZUVkNJc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKVVJWTlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1UZ0tJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMGlWRk5VSWl3S0lDQWdJR0o1ZEdWalh6RWdMeThnSWxSVFZDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3hOd29nSUNBZ0x5OGdkSGh1SUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1qSXRNamdLSUNBZ0lDOHZJR0Z6YzJWMFgybGtMQ0JmZEhodUlEMGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0VzQ2lBZ0lDQXZMeUFnSUNBZ2RIaHVMQW9nSUNBZ0x5OGdJQ0FnSUdJc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BXRndjQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPakl6Q2lBZ0lDQXZMeUJVZUc1RGIyNTBjbUZqZEM1allXeHNYM2RwZEdoZmRIaHVMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEZtTlRBME1HUWdMeThnYldWMGFHOWtJQ0pqWVd4c1gzZHBkR2hmZEhodUtHSjVkR1ZiWFN4MGVHNHNZbmwwWlZ0ZEtYVnBiblEyTkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNakl0TWpnS0lDQWdJQzh2SUdGemMyVjBYMmxrTENCZmRIaHVJRDBnWVhKak5DNWhZbWxmWTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0JVZUc1RGIyNTBjbUZqZEM1allXeHNYM2RwZEdoZmRIaHVMQW9nSUNBZ0x5OGdJQ0FnSUdFc0NpQWdJQ0F2THlBZ0lDQWdkSGh1TEFvZ0lDQWdMeThnSUNBZ0lHSXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0N3S0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCc2IyY2dkbUZzZFdVZ2FYTWdibTkwSUhSb1pTQnlaWE4xYkhRZ2IyWWdZVzRnUVVKSklISmxkSFZ5YmdvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPakk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWE56WlhSZmFXUXNJQ0psZUhCbFkzUmxaQ0JoYzNObGRDQnBaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmhjM05sZENCcFpBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3hOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dVkyRnNiR1Z5TGtOaGJHeGxjaTUwWlhOMFgyTmhiR3hmZDJsMGFGOWhZMlpuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjlqWVd4c1gzZHBkR2hmWVdObVp6b0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvek9DMDBOQW9nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmWVdObVp5d0tJQ0FnSUM4dklDQWdJQ0JoTEFvZ0lDQWdMeThnSUNBZ0lIUjRiaXdLSUNBZ0lDOHZJQ0FnSUNCaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWhjSEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPak0yQ2lBZ0lDQXZMeUIwYjNSaGJEMHhMQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvek5Rb2dJQ0FnTHk4Z1lYTnpaWFJmYm1GdFpUMGlWRVZUVkNJc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKVVJWTlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk16UUtJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMGlWRk5VSWl3S0lDQWdJR0o1ZEdWalh6RWdMeThnSWxSVFZDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3pNd29nSUNBZ0x5OGdkSGh1SUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk16Z3RORFFLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdWSGh1UTI5dWRISmhZM1F1WTJGc2JGOTNhWFJvWDJGalptY3NDaUFnSUNBdkx5QWdJQ0FnWVN3S0lDQWdJQzh2SUNBZ0lDQjBlRzRzQ2lBZ0lDQXZMeUFnSUNBZ1lpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZWEJ3TEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5dVpYaDBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TXprS0lDQWdJQzh2SUZSNGJrTnZiblJ5WVdOMExtTmhiR3hmZDJsMGFGOWhZMlpuTEFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJbU5oYkd4ZmQybDBhRjloWTJabktHSjVkR1ZiWFN4aFkyWm5MR0o1ZEdWYlhTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPak00TFRRMENpQWdJQ0F2THlCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJrTnZiblJ5WVdOMExtTmhiR3hmZDJsMGFGOWhZMlpuTEFvZ0lDQWdMeThnSUNBZ0lHRXNDaUFnSUNBdkx5QWdJQ0FnZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQnNiMmNnZG1Gc2RXVWdhWE1nYm05MElIUm9aU0J5WlhOMWJIUWdiMllnWVc0Z1FVSkpJSEpsZEhWeWJnb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIVnBiblEyTkFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR1WTJGc2JHVnlMa05oYkd4bGNpNTBaWE4wWDJOaGJHeGZkMmwwYUY5cGJtWmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZZMkZzYkY5M2FYUm9YMmx1Wm1WeU9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pVekxUVTVDaUFnSUNBdkx5QmhjbU0wTG1GaWFWOWpZV3hzVzFWSmJuUTJORjBvQ2lBZ0lDQXZMeUFnSUNBZ0ltTmhiR3hmZDJsMGFGOWhZMlpuSWl3S0lDQWdJQzh2SUNBZ0lDQmhMQW9nSUNBZ0x5OGdJQ0FnSUhSNGJpd0tJQ0FnSUM4dklDQWdJQ0JpTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaGNIQXNDaUFnSUNBdkx5QXBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qVXhDaUFnSUNBdkx5QjBiM1JoYkQweExBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8xTUFvZ0lDQWdMeThnWVhOelpYUmZibUZ0WlQwaVZFVlRWQ0lzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pVUlZOVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFNWhiV1VLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TkRrS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQwaVZGTlVJaXdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbFJUVkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvME9Bb2dJQ0FnTHk4Z2RIaHVJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUJoWTJabkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TlRNdE5Ua0tJQ0FnSUM4dklHRnlZelF1WVdKcFgyTmhiR3hiVlVsdWREWTBYU2dLSUNBZ0lDOHZJQ0FnSUNBaVkyRnNiRjkzYVhSb1gyRmpabWNpTEFvZ0lDQWdMeThnSUNBZ0lHRXNDaUFnSUNBdkx5QWdJQ0FnZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdGd2NDd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZibVY0ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWTJGc2JGOTNhWFJvWDJGalptY29ZbmwwWlZ0ZExHRmpabWNzWW5sMFpWdGRLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFZwYm5RMk5Bb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dVkyRnNiR1Z5TGtOaGJHeGxjaTUwWlhOMFgyTmhiR3hmZDJsMGFGOWhZMlpuWDI1dlgzSmxkSFZ5Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmWTJGc2JGOTNhWFJvWDJGalptZGZibTlmY21WMGRYSnVPZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8yTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qWTRMVGN3Q2lBZ0lDQXZMeUIwZUc0eElEMGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmWVdObVoxOXViMTl5WlhSMWNtNHNJR0VzSUdGalptY3NJR0lzSUdGd2NGOXBaRDFoY0hBc0lHNXZkR1U5WWlJeElnb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvMk5nb2dJQ0FnTHk4Z2RHOTBZV3c5TVN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZOalVLSUNBZ0lDOHZJR0Z6YzJWMFgyNWhiV1U5SWxSRlUxUWlMQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlWRVZUVkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhST1lXMWxDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPalkwQ2lBZ0lDQXZMeUIxYm1sMFgyNWhiV1U5SWxSVFZDSXNDaUFnSUNCaWVYUmxZMTh4SUM4dklDSlVVMVFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TmpNS0lDQWdJQzh2SUdGalptY2dQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8yT0MwM01Bb2dJQ0FnTHk4Z2RIaHVNU0E5SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnVkhodVEyOXVkSEpoWTNRdVkyRnNiRjkzYVhSb1gyRmpabWRmYm05ZmNtVjBkWEp1TENCaExDQmhZMlpuTENCaUxDQmhjSEJmYVdROVlYQndMQ0J1YjNSbFBXSWlNU0lLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzJPUW9nSUNBZ0x5OGdWSGh1UTI5dWRISmhZM1F1WTJGc2JGOTNhWFJvWDJGalptZGZibTlmY21WMGRYSnVMQ0JoTENCaFkyWm5MQ0JpTENCaGNIQmZhV1E5WVhCd0xDQnViM1JsUFdJaU1TSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZkR1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpnME1EQTNOMlFnTHk4Z2JXVjBhRzlrSUNKallXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRvWW5sMFpWdGRMR0ZqWm1jc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pZNExUY3dDaUFnSUNBdkx5QjBlRzR4SUQwZ1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNURiMjUwY21GamRDNWpZV3hzWDNkcGRHaGZZV05tWjE5dWIxOXlaWFIxY200c0lHRXNJR0ZqWm1jc0lHSXNJR0Z3Y0Y5cFpEMWhjSEFzSUc1dmRHVTlZaUl4SWdvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVG05MFpRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzNNUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiakV1Ym05MFpTQTlQU0JpSWpFaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzNOQW9nSUNBZ0x5OGdZWE56WlhSZmFXUWdQU0J2Y0M1SFNWUjRiaTVqY21WaGRHVmtYMkZ6YzJWMFgybGtLREFwQ2lBZ0lDQm5hWFI0YmlBd0lFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pjMUNpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUmZhV1FzSUNKbGVIQmxZM1JsWkNCaGMzTmxkQ0IwYnlCaVpTQmpjbVZoZEdWa0lnb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGemMyVjBJSFJ2SUdKbElHTnlaV0YwWldRS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCQ0NZRUJGUkZVMVFEVkZOVUJCVWZmSFVFYlVjQXJURWJRUUFyTVJrVVJERVlSSUlFQkFxMU5XTUU2bXBxM2dRamdmK0FCQUMxRHh3MkdnQ09CQUFKQUdvQXd3RWNBREVaRkRFWUZCQkROaG9CU1NKWkl3aExBUlVTUkRZYUFra2lXU01JU3dFVkVrUTJHZ05KRlNVU1JCZXhKTElpS0xJbUtiSWxnUU95RUNLeUFiYXlHSUFFb2ZVRURiSWFUTElhc2hxQkJySVFJcklCczdRK1NWY0FCQ29TUkZjRUFFa1ZKUkpFRjBRa1F6WWFBVWtpV1NNSVN3RVZFa1EyR2dKSklsa2pDRXNCRlJKRU5ob0RTUlVsRWtRWHNTU3lJaWl5SmlteUpZRURzaEFpc2dHMnNoZ3JzaHBNc2hxeUdvRUdzaEFpc2dHenRENUpWd0FFS2hKRVZ3UUFGU1VTUkNSRE5ob0JTU0paSXdoTEFSVVNSRFlhQWtraVdTTUlTd0VWRWtRMkdnTkpGU1VTUkJleEpMSWlLTEltS2JJbGdRT3lFQ0t5QWJheUdDdXlHa3l5R3JJYWdRYXlFQ0t5QWJPMFBrbFhBQVFxRWtSWEJBQVZKUkpFSkVNMkdnRkpJbGtqQ0VzQkZSSkVOaG9DU1NKWkl3aExBUlVTUkRZYUEwa1ZKUkpFRjdFa3NpSW9zaVlwc2lXQkE3SVFJcklCdG9BQk1iSUZzaGlBQk1oQUIzMnlHa3l5R3JJYWdRYXlFQ0t5QWJPMEJZQUJNUkpFdHdBOFJDUkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
