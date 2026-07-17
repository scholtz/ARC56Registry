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

namespace Arc56.Generated.aorumbayev.puya.Caller_e89abb29
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
        public async Task TestCallWithTxn(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 40, 76, 30, 97 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithTxn_Transactions(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 40, 76, 30, 97 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithAcfg(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 170, 51, 193, 186 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithAcfg_Transactions(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 170, 51, 193, 186 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithInfer(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 79, 150, 7, 26 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithInfer_Transactions(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 79, 150, 7, 26 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="app"> </param>
        public async Task TestCallWithAcfgNoReturn(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 187, 0, 152, 162 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestCallWithAcfgNoReturn_Transactions(ulong app, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 187, 0, 152, 162 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FsbGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfY2FsbF93aXRoX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsaWNhdGlvbiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2NhbGxfd2l0aF9hY2ZnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfY2FsbF93aXRoX2luZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfY2FsbF93aXRoX2FjZmdfbm9fcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjc4LDM0OSw0MThdLCJlcnJvck1lc3NhZ2UiOiJBUkM0IHByZWZpeCBpcyB2YWxpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczLDEwMywxMzMsMTYzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzYsMTA2LDEzNiwxNjZdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXNzZXQgaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCB0byBiZSBjcmVhdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeUEyQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pVUlZOVUlpQWlWRk5VSWlBd2VERTFNV1kzWXpjMUlEQjRObVEwTnpBd1lXUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNVFFLSUNBZ0lDOHZJR05zWVhOeklFTmhiR3hsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGtLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd5T0RSak1XVTJNU0F3ZUdGaE16TmpNV0poSURCNE5HWTVOakEzTVdFZ01IaGlZakF3T1RoaE1pQXZMeUJ0WlhSb2IyUWdJblJsYzNSZlkyRnNiRjkzYVhSb1gzUjRiaWhpZVhSbFcxMHNZbmwwWlZ0ZExHRndjR3hwWTJGMGFXOXVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JmWTJGc2JGOTNhWFJvWDJGalptY29ZbmwwWlZ0ZExHSjVkR1ZiWFN4aGNIQnNhV05oZEdsdmJpbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMk5oYkd4ZmQybDBhRjlwYm1abGNpaGllWFJsVzEwc1lubDBaVnRkTEdGd2NHeHBZMkYwYVc5dUtYWnZhV1FpTENCdFpYUm9iMlFnSW5SbGMzUmZZMkZzYkY5M2FYUm9YMkZqWm1kZmJtOWZjbVYwZFhKdUtHSjVkR1ZiWFN4aWVYUmxXMTBzWVhCd2JHbGpZWFJwYjI0cGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5allXeHNYM2RwZEdoZmRIaHVYM0p2ZFhSbFFETWdiV0ZwYmw5MFpYTjBYMk5oYkd4ZmQybDBhRjloWTJablgzSnZkWFJsUURRZ2JXRnBibDkwWlhOMFgyTmhiR3hmZDJsMGFGOXBibVpsY2w5eWIzVjBaVUExSUcxaGFXNWZkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTVmY205MWRHVkFOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFek9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnNiR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWTJGc2JGOTNhWFJvWDJGalptZGZibTlmY21WMGRYSnVYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnNiR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVjd29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8yTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhSbGMzUmZZMkZzYkY5M2FYUm9YMkZqWm1kZmJtOWZjbVYwZFhKdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUmZZMkZzYkY5M2FYUm9YMmx1Wm1WeVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qUTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveE5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTJGc2JHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGd2NHeHBZMkYwYVc5dWN3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSZlkyRnNiRjkzYVhSb1gybHVabVZ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSZlkyRnNiRjkzYVhSb1gyRmpabWRmY205MWRHVkFORG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPakUwQ2lBZ0lDQXZMeUJqYkdGemN5QkRZV3hzWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRWEJ3YkdsallYUnBiMjV6Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pNeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRjlqWVd4c1gzZHBkR2hmWVdObVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBYMk5oYkd4ZmQybDBhRjkwZUc1ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pFMENpQWdJQ0F2THlCamJHRnpjeUJEWVd4c1pYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhCd2JHbGpZWFJwYjI1ekNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qRTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5allXeHNYM2RwZEdoZmRIaHVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1T2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveE5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTJGc2JHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMbU5oYkd4bGNpNURZV3hzWlhJdWRHVnpkRjlqWVd4c1gzZHBkR2hmZEhodUtHRTZJR0o1ZEdWekxDQmlPaUJpZVhSbGN5d2dZWEJ3T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUmZZMkZzYkY5M2FYUm9YM1I0YmpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1UVXRNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSFJsYzNSZlkyRnNiRjkzYVhSb1gzUjRiaWh6Wld4bUxDQmhPaUJDZVhSbGN5d2dZam9nUW5sMFpYTXNJR0Z3Y0RvZ1FYQndiR2xqWVhScGIyNHBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk1qSXRNamdLSUNBZ0lDOHZJR0Z6YzJWMFgybGtMQ0JmZEhodUlEMGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR0VzQ2lBZ0lDQXZMeUFnSUNBZ2RIaHVMQW9nSUNBZ0x5OGdJQ0FnSUdJc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BXRndjQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNakFLSUNBZ0lDOHZJSFJ2ZEdGc1BURXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pFNUNpQWdJQ0F2THlCaGMzTmxkRjl1WVcxbFBTSlVSVk5VSWl3S0lDQWdJR0o1ZEdWalh6QWdMeThnSWxSRlUxUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveE9Bb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBTSlVVMVFpTEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVkZOVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qRTNDaUFnSUNBdkx5QjBlRzRnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG95TWkweU9Bb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRc0lGOTBlRzRnUFNCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJrTnZiblJ5WVdOMExtTmhiR3hmZDJsMGFGOTBlRzRzQ2lBZ0lDQXZMeUFnSUNBZ1lTd0tJQ0FnSUM4dklDQWdJQ0IwZUc0c0NpQWdJQ0F2THlBZ0lDQWdZaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5WVhCd0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOXVaWGgwQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pJMENpQWdJQ0F2THlCaExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRveU5nb2dJQ0FnTHk4Z1lpd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qSXlMVEk0Q2lBZ0lDQXZMeUJoYzNObGRGOXBaQ3dnWDNSNGJpQTlJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdWSGh1UTI5dWRISmhZM1F1WTJGc2JGOTNhWFJvWDNSNGJpd0tJQ0FnSUM4dklDQWdJQ0JoTEFvZ0lDQWdMeThnSUNBZ0lIUjRiaXdLSUNBZ0lDOHZJQ0FnSUNCaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWhjSEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoTVdZMU1EUXdaQ0F2THlCdFpYUm9iMlFnSW1OaGJHeGZkMmwwYUY5MGVHNG9ZbmwwWlZ0ZExIUjRiaXhpZVhSbFcxMHBkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh6SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2RwZEhodUlERWdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlVrTTBJSEJ5WldacGVDQnBjeUIyWVd4cFpBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUb3lPUW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDJsa0xDQWlaWGh3WldOMFpXUWdZWE56WlhRZ2FXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lYTnpaWFFnYVdRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUxtTmhiR3hsY2k1RFlXeHNaWEl1ZEdWemRGOWpZV3hzWDNkcGRHaGZZV05tWnloaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNc0lHRndjRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AwWlhOMFgyTmhiR3hmZDJsMGFGOWhZMlpuT2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvek1TMHpNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aeWh6Wld4bUxDQmhPaUJDZVhSbGN5d2dZam9nUW5sMFpYTXNJR0Z3Y0RvZ1FYQndiR2xqWVhScGIyNHBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk16Z3RORFFLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdWSGh1UTI5dWRISmhZM1F1WTJGc2JGOTNhWFJvWDJGalptY3NDaUFnSUNBdkx5QWdJQ0FnWVN3S0lDQWdJQzh2SUNBZ0lDQjBlRzRzQ2lBZ0lDQXZMeUFnSUNBZ1lpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZWEJ3TEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG96TmdvZ0lDQWdMeThnZEc5MFlXdzlNU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk16VUtJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVTlJbFJGVTFRaUxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVZFVlRWQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qTTBDaUFnSUNBdkx5QjFibWwwWDI1aGJXVTlJbFJUVkNJc0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKVVUxUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZNek1LSUNBZ0lDOHZJSFI0YmlBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6SWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pNNExUUTBDaUFnSUNBdkx5QmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lGUjRia052Ym5SeVlXTjBMbU5oYkd4ZmQybDBhRjloWTJabkxBb2dJQ0FnTHk4Z0lDQWdJR0VzQ2lBZ0lDQXZMeUFnSUNBZ2RIaHVMQW9nSUNBZ0x5OGdJQ0FnSUdJc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BXRndjQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBNQW9nSUNBZ0x5OGdZU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZORElLSUNBZ0lDOHZJR0lzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG96T0MwME5Bb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCVWVHNURiMjUwY21GamRDNWpZV3hzWDNkcGRHaGZZV05tWnl3S0lDQWdJQzh2SUNBZ0lDQmhMQW9nSUNBZ0x5OGdJQ0FnSUhSNGJpd0tJQ0FnSUM4dklDQWdJQ0JpTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaGNIQXNDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaVkyRnNiRjkzYVhSb1gyRmpabWNvWW5sMFpWdGRMR0ZqWm1jc1lubDBaVnRkS1hWcGJuUTJOQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk15QXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCbmFYUjRiaUF4SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVZKRE5DQndjbVZtYVhnZ2FYTWdkbUZzYVdRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUxtTmhiR3hsY2k1RFlXeHNaWEl1ZEdWemRGOWpZV3hzWDNkcGRHaGZhVzVtWlhJb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWekxDQmhjSEE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOWpZV3hzWDNkcGRHaGZhVzVtWlhJNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qUTJMVFEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUIwWlhOMFgyTmhiR3hmZDJsMGFGOXBibVpsY2loelpXeG1MQ0JoT2lCQ2VYUmxjeXdnWWpvZ1FubDBaWE1zSUdGd2NEb2dRWEJ3YkdsallYUnBiMjRwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZOVE10TlRrS0lDQWdJQzh2SUdGeVl6UXVZV0pwWDJOaGJHeGJWVWx1ZERZMFhTZ0tJQ0FnSUM4dklDQWdJQ0FpWTJGc2JGOTNhWFJvWDJGalptY2lMQW9nSUNBZ0x5OGdJQ0FnSUdFc0NpQWdJQ0F2THlBZ0lDQWdkSGh1TEFvZ0lDQWdMeThnSUNBZ0lHSXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TlRFS0lDQWdJQzh2SUhSdmRHRnNQVEVzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qVXdDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pVUlZOVUlpd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsUkZVMVFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzBPUW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pVVTFRaUxBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVZGTlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPalE0Q2lBZ0lDQXZMeUIwZUc0Z1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnYVc1MFkxOHlJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDJOaGJHeGxjaTV3ZVRvMU15MDFPUW9nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkZ0VlNXNTBOalJkS0FvZ0lDQWdMeThnSUNBZ0lDSmpZV3hzWDNkcGRHaGZZV05tWnlJc0NpQWdJQ0F2THlBZ0lDQWdZU3dLSUNBZ0lDOHZJQ0FnSUNCMGVHNHNDaUFnSUNBdkx5QWdJQ0FnWWl3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVlYQndMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qVTFDaUFnSUNBdkx5QmhMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzFOd29nSUNBZ0x5OGdZaXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZZMkZzYkdWeUxuQjVPalV6TFRVNUNpQWdJQ0F2THlCaGNtTTBMbUZpYVY5allXeHNXMVZKYm5RMk5GMG9DaUFnSUNBdkx5QWdJQ0FnSW1OaGJHeGZkMmwwYUY5aFkyWm5JaXdLSUNBZ0lDOHZJQ0FnSUNCaExBb2dJQ0FnTHk4Z0lDQWdJSFI0Yml3S0lDQWdJQzh2SUNBZ0lDQmlMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDFoY0hBc0NpQWdJQ0F2THlBcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpWTJGc2JGOTNhWFJvWDJGalptY29ZbmwwWlZ0ZExHRmpabWNzWW5sMFpWdGRLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTXlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JuYVhSNGJpQXhJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVkpETkNCd2NtVm1hWGdnYVhNZ2RtRnNhV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TG1OaGJHeGxjaTVEWVd4c1pYSXVkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6TENCaGNIQTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEY5allXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTQ2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pZeExUWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQjBaWE4wWDJOaGJHeGZkMmwwYUY5aFkyWm5YMjV2WDNKbGRIVnliaWh6Wld4bUxDQmhPaUJDZVhSbGN5d2dZam9nUW5sMFpYTXNJR0Z3Y0RvZ1FYQndiR2xqWVhScGIyNHBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5allXeHNaWEl1Y0hrNk5qZ3ROekFLSUNBZ0lDOHZJSFI0YmpFZ1BTQmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lGUjRia052Ym5SeVlXTjBMbU5oYkd4ZmQybDBhRjloWTJablgyNXZYM0psZEhWeWJpd2dZU3dnWVdObVp5d2dZaXdnWVhCd1gybGtQV0Z3Y0N3Z2JtOTBaVDFpSWpFaUNpQWdJQ0F2THlBcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pZMkNpQWdJQ0F2THlCMGIzUmhiRDB4TEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJVYjNSaGJBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDBpVkVWVFZDSXNDaUFnSUNCaWVYUmxZMTh3SUM4dklDSlVSVk5VSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOWpZV3hzWlhJdWNIazZOalFLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpVkZOVUlpd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsUlRWQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMMk5oYkd4bGNpNXdlVG8yTXdvZ0lDQWdMeThnWVdObVp5QTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCcGJuUmpYeklnTHk4Z1lXTm1ad29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dlkyRnNiR1Z5TG5CNU9qWTRMVGN3Q2lBZ0lDQXZMeUIwZUc0eElEMGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQlVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmWVdObVoxOXViMTl5WlhSMWNtNHNJR0VzSUdGalptY3NJR0lzSUdGd2NGOXBaRDFoY0hBc0lHNXZkR1U5WWlJeElnb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOXVaWGgwQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2WTJGc2JHVnlMbkI1T2pZNUNpQWdJQ0F2THlCVWVHNURiMjUwY21GamRDNWpZV3hzWDNkcGRHaGZZV05tWjE5dWIxOXlaWFIxY200c0lHRXNJR0ZqWm1jc0lHSXNJR0Z3Y0Y5cFpEMWhjSEFzSUc1dmRHVTlZaUl4SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16RUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RtOTBaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TmpndE56QUtJQ0FnSUM4dklIUjRiakVnUFNCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUZSNGJrTnZiblJ5WVdOMExtTmhiR3hmZDJsMGFGOWhZMlpuWDI1dlgzSmxkSFZ5Yml3Z1lTd2dZV05tWnl3Z1lpd2dZWEJ3WDJsa1BXRndjQ3dnYm05MFpUMWlJakVpQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqT0RRd01EYzNaQ0F2THlCdFpYUm9iMlFnSW1OaGJHeGZkMmwwYUY5aFkyWm5YMjV2WDNKbGRIVnliaWhpZVhSbFcxMHNZV05tWnl4aWVYUmxXMTBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTXlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFNXZkR1VLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0eExtNXZkR1VnUFQwZ1lpSXhJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTlqWVd4c1pYSXVjSGs2TnpRS0lDQWdJQzh2SUdGemMyVjBYMmxrSUQwZ2IzQXVSMGxVZUc0dVkzSmxZWFJsWkY5aGMzTmxkRjlwWkNnd0tRb2dJQ0FnWjJsMGVHNGdNQ0JEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwyTmhiR3hsY2k1d2VUbzNOUW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDJsa0xDQWlaWGh3WldOMFpXUWdZWE56WlhRZ2RHOGdZbVVnWTNKbFlYUmxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmhjM05sZENCMGJ5QmlaU0JqY21WaGRHVmtDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVEQmlZRUJGUkZVMVFEVkZOVUJCVWZmSFVFYlVjQXJURWJRUUNkZ2dRRUtFd2VZUVNxTThHNkJFK1dCeG9FdXdDWW9qWWFBSTRFQUZ3QVBnQWdBQUlpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTVh3REtJQVVJalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ01Yd0RLSUFOOGpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0EyR2dNWHdES0lBSHdqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTVh3REtJQUEwalF6RVpRUCtCTVJnVVJDTkRpZ01Bc1NPeUlpaXlKaW15SlNTeUVDS3lBYmFML1JVV1Z3WUNpLzFRaS80VkZsY0dBb3YrVUl2L3NoaUFCS0gxQkEyeUdreXlHcklhSmJJUUlySUJzN2NCUGtsWEJBQk1Wd0FFS2hKRUYwU0ppZ01Bc1NPeUlpaXlKaW15SlNTeUVDS3lBYmFML1JVV1Z3WUNpLzFRaS80VkZsY0dBb3YrVUl2L3NoZ3JzaHBNc2hxeUdpV3lFQ0t5QWJPM0FUNVhBQVFxRWtTSmlnTUFzU095SWlpeUppbXlKU1N5RUNLeUFiYUwvUlVXVndZQ2kvMVFpLzRWRmxjR0FvditVSXYvc2hncnNocE1zaHF5R2lXeUVDS3lBYk8zQVQ1WEFBUXFFa1NKaWdNQXNTT3lJaWl5SmlteUpTU3lFQ0t5QWJhTC9SVVdWd1lDaS8xUWkvNFZGbGNHQW92K1VJQUJNYklGaS8reUdJQUV5RUFIZmJJYVRMSWFzaG9sc2hBaXNnR3p0QVdBQVRFU1JMY0FQRVNKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
