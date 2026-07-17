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

namespace Arc56.Generated.algorandfoundation.puya.FixedBytesABI_d3125674
{


    public class FixedBytesABIProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FixedBytesABIProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="checker"> </param>
        /// <param name="val"> </param>
        public async Task TestItxnValidateCallerBytes(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 224, 144, 154, 254 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestItxnValidateCallerBytes_Transactions(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 224, 144, 154, 254 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="checker"> </param>
        /// <param name="val"> </param>
        public async Task TestItxnValidateCalleeManual(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 182, 235, 68, 64 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestItxnValidateCalleeManual_Transactions(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 182, 235, 68, 64 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="checker"> </param>
        /// <param name="val"> </param>
        public async Task TestItxnValidateCalleeRouter(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 146, 84, 16, 176 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestItxnValidateCalleeRouter_Transactions(ulong checker, byte[] val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 146, 84, 16, 176 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, checkerRefIndex, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="checker"> </param>
        public async Task TestStaticToDynamicEncoding(ulong checker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 242, 120, 121, 140 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);

            var result = await base.CallApp(new List<object> { abiHandle, checkerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestStaticToDynamicEncoding_Transactions(ulong checker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { checker });
            byte checkerRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 242, 120, 121, 140 };
            var checkerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); checkerAbi.From(checker);

            return await base.MakeTransactionList(new List<object> { abiHandle, checkerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRml4ZWRCeXRlc0FCSSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0X2l0eG5fdmFsaWRhdGVfY2FsbGVyX2J5dGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hlY2tlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXR4bl92YWxpZGF0ZV9jYWxsZWVfbWFudWFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hlY2tlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXR4bl92YWxpZGF0ZV9jYWxsZWVfcm91dGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hlY2tlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3Rfc3RhdGljX3RvX2R5bmFtaWNfZW5jb2RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGVja2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODYsMTM3LDE4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzLDE0NCwxODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzcsMTI4LDE3MywyMjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTmlBeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UWTFNVFE0TjJJS0lDQWdJQzh2SUdacGVHVmtYMko1ZEdWelgyOXdjeTloWW1sZmRtRnNkV1Z6TG5CNU9qZ0tJQ0FnSUM4dklHTnNZWE56SUVacGVHVmtRbmwwWlhOQlFra29ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdVd09UQTVZV1psSURCNFlqWmxZalEwTkRBZ01IZzVNalUwTVRCaU1DQXdlR1l5TnpnM09UaGpJQzh2SUcxbGRHaHZaQ0FpZEdWemRGOXBkSGh1WDNaaGJHbGtZWFJsWDJOaGJHeGxjbDlpZVhSbGN5aGhjSEJzYVdOaGRHbHZiaXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjlwZEhodVgzWmhiR2xrWVhSbFgyTmhiR3hsWlY5dFlXNTFZV3dvWVhCd2JHbGpZWFJwYjI0c1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSZmFYUjRibDkyWVd4cFpHRjBaVjlqWVd4c1pXVmZjbTkxZEdWeUtHRndjR3hwWTJGMGFXOXVMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBYM04wWVhScFkxOTBiMTlrZVc1aGJXbGpYMlZ1WTI5a2FXNW5LR0Z3Y0d4cFkyRjBhVzl1S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0IwWlhOMFgybDBlRzVmZG1Gc2FXUmhkR1ZmWTJGc2JHVnlYMko1ZEdWeklIUmxjM1JmYVhSNGJsOTJZV3hwWkdGMFpWOWpZV3hzWldWZmJXRnVkV0ZzSUhSbGMzUmZhWFI0Ymw5MllXeHBaR0YwWlY5allXeHNaV1ZmY205MWRHVnlJSFJsYzNSZmMzUmhkR2xqWDNSdlgyUjVibUZ0YVdOZlpXNWpiMlJwYm1jS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVtYVhobFpGOWllWFJsYzE5dmNITXVZV0pwWDNaaGJIVmxjeTVHYVhobFpFSjVkR1Z6UVVKSkxuUmxjM1JmYVhSNGJsOTJZV3hwWkdGMFpWOWpZV3hzWlhKZllubDBaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMmwwZUc1ZmRtRnNhV1JoZEdWZlkyRnNiR1Z5WDJKNWRHVnpPZ29nSUNBZ0x5OGdabWw0WldSZllubDBaWE5mYjNCekwyRmlhVjkyWVd4MVpYTXVjSGs2T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsYzI5MWNtTmxYMlZ1WTI5a2FXNW5QU0pwYm1SbGVDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGd2NHeHBZMkYwYVc5dWN3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR1pwZUdWa1gySjVkR1Z6WDI5d2N5OWhZbWxmZG1Gc2RXVnpMbkI1T2pFeExURTJDaUFnSUNBdkx5QWpJSFJvYVhNZ1ltVWdkbUZzYVdSaGRHVmtJR2x1SUhSb1pTQmpZV3hzWlhJZ1lYTWdhWFFnZDJsc2JDQmhkSFJsYlhCMElIUnZJR1Z1WTI5a1pTQjJZV3dnZEc4Z1JtbDRaV1JDZVhSbGN6RXhDaUFnSUNBdkx5QmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lFTm9aV05yUVVKSlFYQndMbTFoYm5WaGJGOTJZV3hwWkdGMFpTd0tJQ0FnSUM4dklDQWdJQ0IyWVd3c0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BXTm9aV05yWlhJc0NpQWdJQ0F2THlBcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJtYVhobFpGOWllWFJsYzE5dmNITXZZV0pwWDNaaGJIVmxjeTV3ZVRveE5Bb2dJQ0FnTHk4Z2RtRnNMQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUdacGVHVmtYMko1ZEdWelgyOXdjeTloWW1sZmRtRnNkV1Z6TG5CNU9qRXpDaUFnSUNBdkx5QkRhR1ZqYTBGQ1NVRndjQzV0WVc1MVlXeGZkbUZzYVdSaGRHVXNDaUFnSUNCaWVYUmxZMTh3SUM4dklHMWxkR2h2WkNBaWJXRnVkV0ZzWDNaaGJHbGtZWFJsS0dKNWRHVmJNVEZkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklHWnBlR1ZrWDJKNWRHVnpYMjl3Y3k5aFltbGZkbUZzZFdWekxuQjVPakV4TFRFMkNpQWdJQ0F2THlBaklIUm9hWE1nWW1VZ2RtRnNhV1JoZEdWa0lHbHVJSFJvWlNCallXeHNaWElnWVhNZ2FYUWdkMmxzYkNCaGRIUmxiWEIwSUhSdklHVnVZMjlrWlNCMllXd2dkRzhnUm1sNFpXUkNlWFJsY3pFeENpQWdJQ0F2THlCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUVOb1pXTnJRVUpKUVhCd0xtMWhiblZoYkY5MllXeHBaR0YwWlN3S0lDQWdJQzh2SUNBZ0lDQjJZV3dzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFdOb1pXTnJaWElzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1ptbDRaV1JmWW5sMFpYTmZiM0J6TDJGaWFWOTJZV3gxWlhNdWNIazZPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1bWFYaGxaRjlpZVhSbGMxOXZjSE11WVdKcFgzWmhiSFZsY3k1R2FYaGxaRUo1ZEdWelFVSkpMblJsYzNSZmFYUjRibDkyWVd4cFpHRjBaVjlqWVd4c1pXVmZiV0Z1ZFdGc1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5cGRIaHVYM1poYkdsa1lYUmxYMk5oYkd4bFpWOXRZVzUxWVd3NkNpQWdJQ0F2THlCbWFYaGxaRjlpZVhSbGMxOXZjSE12WVdKcFgzWmhiSFZsY3k1d2VUb3hPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZ3Y0d4cFkyRjBhVzl1Y3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHWnBlR1ZrWDJKNWRHVnpYMjl3Y3k5aFltbGZkbUZzZFdWekxuQjVPakl4TFRJMkNpQWdJQ0F2THlBaklIUm9hWE1nZDJsc2JDQmlaU0IyWVd4cFpHRjBaV1FnYVc0Z2RHaGxJR05oYkd4bFpTQnRaWFJvYjJRZ1lYTWdkSGx3WlhNZ2JXRjBZMmdLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdRMmhsWTJ0QlFrbEJjSEF1YldGdWRXRnNYM1poYkdsa1lYUmxMQW9nSUNBZ0x5OGdJQ0FnSUdaaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWphR1ZqYTJWeUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCbWFYaGxaRjlpZVhSbGMxOXZjSE12WVdKcFgzWmhiSFZsY3k1d2VUb3lNd29nSUNBZ0x5OGdRMmhsWTJ0QlFrbEJjSEF1YldGdWRXRnNYM1poYkdsa1lYUmxMQW9nSUNBZ1lubDBaV05mTUNBdkx5QnRaWFJvYjJRZ0ltMWhiblZoYkY5MllXeHBaR0YwWlNoaWVYUmxXekV4WFNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5Qm1hWGhsWkY5aWVYUmxjMTl2Y0hNdllXSnBYM1poYkhWbGN5NXdlVG95TVMweU5nb2dJQ0FnTHk4Z0l5QjBhR2x6SUhkcGJHd2dZbVVnZG1Gc2FXUmhkR1ZrSUdsdUlIUm9aU0JqWVd4c1pXVWdiV1YwYUc5a0lHRnpJSFI1Y0dWeklHMWhkR05vQ2lBZ0lDQXZMeUJoY21NMExtRmlhVjlqWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJRU5vWldOclFVSkpRWEJ3TG0xaGJuVmhiRjkyWVd4cFpHRjBaU3dLSUNBZ0lDOHZJQ0FnSUNCbVlpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZMmhsWTJ0bGNpd0tJQ0FnSUM4dklDa0tJQ0FnSUdsdWRHTmZNaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJtYVhobFpGOWllWFJsYzE5dmNITXZZV0pwWDNaaGJIVmxjeTV3ZVRveE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVtYVhobFpGOWllWFJsYzE5dmNITXVZV0pwWDNaaGJIVmxjeTVHYVhobFpFSjVkR1Z6UVVKSkxuUmxjM1JmYVhSNGJsOTJZV3hwWkdGMFpWOWpZV3hzWldWZmNtOTFkR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjlwZEhodVgzWmhiR2xrWVhSbFgyTmhiR3hsWlY5eWIzVjBaWEk2Q2lBZ0lDQXZMeUJtYVhobFpGOWllWFJsYzE5dmNITXZZV0pwWDNaaGJIVmxjeTV3ZVRveU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKcGJtUmxlQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdacGVHVmtYMko1ZEdWelgyOXdjeTloWW1sZmRtRnNkV1Z6TG5CNU9qTXhMVE0yQ2lBZ0lDQXZMeUFqSUhSb2FYTWdkMmxzYkNCaVpTQjJZV3hwWkdGMFpXUWdhVzRnZEdobElHTmhiR3hsWlNCeWIzVjBaWElnWVhNZ2RIbHdaWE1nYldGMFkyZ0tJQ0FnSUM4dklHRnlZelF1WVdKcFgyTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1EyaGxZMnRCUWtsQmNIQXVjbTkxZEdWeVgzWmhiR2xrWVhSbExBb2dJQ0FnTHk4Z0lDQWdJR1ppTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxamFHVmphMlZ5TEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJtYVhobFpGOWllWFJsYzE5dmNITXZZV0pwWDNaaGJIVmxjeTV3ZVRvek13b2dJQ0FnTHk4Z1EyaGxZMnRCUWtsQmNIQXVjbTkxZEdWeVgzWmhiR2xrWVhSbExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpUVXdZams0TmpBZ0x5OGdiV1YwYUc5a0lDSnliM1YwWlhKZmRtRnNhV1JoZEdVb1lubDBaVnN4TVYwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdabWw0WldSZllubDBaWE5mYjNCekwyRmlhVjkyWVd4MVpYTXVjSGs2TXpFdE16WUtJQ0FnSUM4dklDTWdkR2hwY3lCM2FXeHNJR0psSUhaaGJHbGtZWFJsWkNCcGJpQjBhR1VnWTJGc2JHVmxJSEp2ZFhSbGNpQmhjeUIwZVhCbGN5QnRZWFJqYUFvZ0lDQWdMeThnWVhKak5DNWhZbWxmWTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0JEYUdWamEwRkNTVUZ3Y0M1eWIzVjBaWEpmZG1Gc2FXUmhkR1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptSXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV05vWldOclpYSXNDaUFnSUNBdkx5QXBDaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWm1sNFpXUmZZbmwwWlhOZmIzQnpMMkZpYVY5MllXeDFaWE11Y0hrNk1qZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpYTnZkWEpqWlY5bGJtTnZaR2x1WnowaWFXNWtaWGdpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11Wm1sNFpXUmZZbmwwWlhOZmIzQnpMbUZpYVY5MllXeDFaWE11Um1sNFpXUkNlWFJsYzBGQ1NTNTBaWE4wWDNOMFlYUnBZMTkwYjE5a2VXNWhiV2xqWDJWdVkyOWthVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjl6ZEdGMGFXTmZkRzlmWkhsdVlXMXBZMTlsYm1OdlpHbHVaem9LSUNBZ0lDOHZJR1pwZUdWa1gySjVkR1Z6WDI5d2N5OWhZbWxmZG1Gc2RXVnpMbkI1T2pNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WemIzVnlZMlZmWlc1amIyUnBibWM5SW1sdVpHVjRJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYQndiR2xqWVhScGIyNXpDaUFnSUNBdkx5Qm1hWGhsWkY5aWVYUmxjMTl2Y0hNdllXSnBYM1poYkhWbGN5NXdlVG8wTVMwME5Rb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCRGFHVmphMEZDU1VGd2NDNXBYMkZ0WDJGZlpIbHVZVzFwWTE5d1pYSnpiMjVoYkdsMGVTd0tJQ0FnSUM4dklDQWdJQ0JtWWl3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVkyaGxZMnRsY2l3S0lDQWdJQzh2SUNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWm1sNFpXUmZZbmwwWlhOZmIzQnpMMkZpYVY5MllXeDFaWE11Y0hrNk5ESUtJQ0FnSUM4dklFTm9aV05yUVVKSlFYQndMbWxmWVcxZllWOWtlVzVoYldsalgzQmxjbk52Ym1Gc2FYUjVMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPVFptTjJZMFpXUWdMeThnYldWMGFHOWtJQ0pwWDJGdFgyRmZaSGx1WVcxcFkxOXdaWEp6YjI1aGJHbDBlU2hpZVhSbFcxMHBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5Qm1hWGhsWkY5aWVYUmxjMTl2Y0hNdllXSnBYM1poYkhWbGN5NXdlVG8wTXdvZ0lDQWdMeThnWm1Jc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQmlOamcyTlRaak5tTTJaakl3TnpjMlpqY3lObU0yTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklHWnBlR1ZrWDJKNWRHVnpYMjl3Y3k5aFltbGZkbUZzZFdWekxuQjVPalF4TFRRMUNpQWdJQ0F2THlCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUVOb1pXTnJRVUpKUVhCd0xtbGZZVzFmWVY5a2VXNWhiV2xqWDNCbGNuTnZibUZzYVhSNUxBb2dJQ0FnTHk4Z0lDQWdJR1ppTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxamFHVmphMlZ5TEFvZ0lDQWdMeThnS1FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHWnBlR1ZrWDJKNWRHVnpYMjl3Y3k5aFltbGZkbUZzZFdWekxuQjVPak00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBR0FpWUJCQlpSU0hzeEcwRUFLekVaRkVReEdFU0NCQVRna0pyK0JMYnJSRUFFa2xRUXNBVHllSG1NTmhvQWpnUUFDUUE4QUdrQW13QXhHUlF4R0JRUVF6WWFBVWtWSWhKRUY4QXlOaG9DU1NOWkpRaExBUlVTUkZjQ0FMRkpGWUVMRWtSTXNoZ29zaHF5R2lTeUVDT3lBYk1pUXpZYUFVa1ZJaEpFRjhBeU5ob0NTU05aSlFoTEFSVVNSRmNDQUxGTXNoZ29zaHF5R2lTeUVDT3lBYk1pUXpZYUFVa1ZJaEpFRjhBeU5ob0NTU05aSlFoTEFSVVNSRmNDQUxGTXNoaUFCT1VMbUdDeUdySWFKTElRSTdJQnN5SkROaG9CU1JVaUVrUVh3REt4c2hpQUJKYjM5TzJ5R29BTkFBdG9aV3hzYnlCM2IzSnNaTElhSkxJUUk3SUJzeUpEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
