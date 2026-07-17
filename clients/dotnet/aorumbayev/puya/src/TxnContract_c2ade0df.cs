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

namespace Arc56.Generated.aorumbayev.puya.TxnContract_c2ade0df
{


    public class TxnContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TxnContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="acfg"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> CallWithTxn(Transaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 161, 245, 4, 13 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallWithTxn_Transactions(Transaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 161, 245, 4, 13 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="acfg"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> CallWithAcfg(AssetConfigurationTransaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 109, 71, 0, 173 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallWithAcfg_Transactions(AssetConfigurationTransaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 109, 71, 0, 173 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="acfg"> </param>
        /// <param name="b"> </param>
        public async Task CallWithAcfgNoReturn(AssetConfigurationTransaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 200, 64, 7, 125 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CallWithAcfgNoReturn_Transactions(AssetConfigurationTransaction acfg, byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { acfg });
            byte[] abiHandle = { 200, 64, 7, 125 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, acfg, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHhuQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FsbF93aXRoX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ0eG4iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2ZnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF93aXRoX2FjZmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNmZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjZmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX3dpdGhfYWNmZ19ub19yZXR1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNmZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjZmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NSw4OSwxMjhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMjAzLDIyM10sImVycm9yTWVzc2FnZSI6ImEgaXMgbm90IGEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODEsMjA4LDIyOF0sImVycm9yTWVzc2FnZSI6ImIgaXMgbm90IGIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjZdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OCw5MiwxMzFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXNzZXQgY29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0LDIxNCwyMzNdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0LDEwOF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYWNmZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE1LSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGcyTVNBd2VEWXlJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTkwZUc1ZlkyOXVkSEpoWTNRdWNIazZNVEVLSUNBZ0lDOHZJR05zWVhOeklGUjRia052Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU9Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRXhaalV3TkRCa0lEQjRObVEwTnpBd1lXUWdNSGhqT0RRd01EYzNaQ0F2THlCdFpYUm9iMlFnSW1OaGJHeGZkMmwwYUY5MGVHNG9ZbmwwWlZ0ZExIUjRiaXhpZVhSbFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpZV3hzWDNkcGRHaGZZV05tWnloaWVYUmxXMTBzWVdObVp5eGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKallXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRvWW5sMFpWdGRMR0ZqWm1jc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTmhiR3hmZDJsMGFGOTBlRzVmY205MWRHVkFNeUJ0WVdsdVgyTmhiR3hmZDJsMGFGOWhZMlpuWDNKdmRYUmxRRFFnYldGcGJsOWpZV3hzWDNkcGRHaGZZV05tWjE5dWIxOXlaWFIxY201ZmNtOTFkR1ZBTlFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMM1I0Ymw5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZIaHVRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJocGJuUWdNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNiRjkzYVhSb1gyRmpabWRmYm05ZmNtVjBkWEp1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR2ZEhodVgyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwzUjRibDlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhodVEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJoWTJabkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVdObVp3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5MGVHNWZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCallXeHNYM2RwZEdoZllXTm1aMTl1YjE5eVpYUjFjbTRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZzYkY5M2FYUm9YMkZqWm1kZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5MGVHNWZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZkSGh1WDJOdmJuUnlZV04wTG5CNU9qRXhDaUFnSUNBdkx5QmpiR0Z6Y3lCVWVHNURiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUdGalptY0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaFkyWm5DaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwzUjRibDlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHTmhiR3hmZDJsMGFGOWhZMlpuQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYkd4ZmQybDBhRjkwZUc1ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5MGVHNWZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZkSGh1WDJOdmJuUnlZV04wTG5CNU9qRXhDaUFnSUNBdkx5QmpiR0Z6Y3lCVWVHNURiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5MGVHNWZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCallXeHNYM2RwZEdoZmRIaHVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEE0T2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDNSNGJsOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdWSGh1UTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR1ZEhodVgyTnZiblJ5WVdOMExsUjRia052Ym5SeVlXTjBMbU5oYkd4ZmQybDBhRjkwZUc0b1lUb2dZbmwwWlhNc0lHRmpabWM2SUhWcGJuUTJOQ3dnWWpvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1kyRnNiRjkzYVhSb1gzUjRiam9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTkwZUc1ZlkyOXVkSEpoWTNRdWNIazZNVEl0TVRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdOaGJHeGZkMmwwYUY5MGVHNG9jMlZzWml3Z1lUb2dRbmwwWlhNc0lHRmpabWM2SUdkMGVHNHVWSEpoYm5OaFkzUnBiMjRzSUdJNklFSjVkR1Z6S1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTkwZUc1ZlkyOXVkSEpoWTNRdWNIazZNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhJRDA5SUdJaVlTSXNJQ0poSUdseklHNXZkQ0JoSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZU0JwY3lCdWIzUWdZUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMM1I0Ymw5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdZWE56WlhKMElHSWdQVDBnWWlKaUlpd2dJbUlnYVhNZ2JtOTBJR0lpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmlJR2x6SUc1dmRDQmlDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkY5MGVHNHZkSGh1WDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmhjM05sY25RZ1lXTm1aeTUwZVhCbElEMDlJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjM05sZEVOdmJtWnBaeXdnSW1WNGNHVmpkR1ZrSUdGemMyVjBJR052Ym1acFp5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCaFkyWm5DaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGemMyVjBJR052Ym1acFp3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwzUjRibDlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1lYTnpaWEowSUdGalptY3VZM0psWVhSbFpGOWhjM05sZEM1cFpDd2dJbVY0Y0dWamRHVmtJR0Z6YzJWMElHbGtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhOelpYUWdhV1FLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c1gzUjRiaTkwZUc1ZlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZMlpuTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TG5SNGJsOWpiMjUwY21GamRDNVVlRzVEYjI1MGNtRmpkQzVqWVd4c1gzZHBkR2hmWVdObVp5aGhPaUJpZVhSbGN5d2dZV05tWnpvZ2RXbHVkRFkwTENCaU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGpZV3hzWDNkcGRHaGZZV05tWnpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNYM1I0Ymk5MGVHNWZZMjl1ZEhKaFkzUXVjSGs2TWpBdE1qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHTmhiR3hmZDJsMGFGOWhZMlpuS0hObGJHWXNJR0U2SUVKNWRHVnpMQ0JoWTJabk9pQm5kSGh1TGtGemMyVjBRMjl1Wm1sblZISmhibk5oWTNScGIyNHNJR0k2SUVKNWRHVnpLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOTBlRzVmWTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCaElEMDlJR0lpWVNJc0lDSmhJR2x6SUc1dmRDQmhJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lTQnBjeUJ1YjNRZ1lRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwzUjRibDlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdJZ1BUMGdZaUppSWl3Z0ltSWdhWE1nYm05MElHSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaUlHbHpJRzV2ZENCaUNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dmRIaHVYMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCaGMzTmxjblFnWVdObVp5NWpjbVZoZEdWa1gyRnpjMlYwTG1sa0xDQWlaWGh3WldOMFpXUWdZWE56WlhRZ2FXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQnBaQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd4ZmRIaHVMM1I0Ymw5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRmpabWN1WTNKbFlYUmxaRjloYzNObGRDNXBaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JGOTBlRzR1ZEhodVgyTnZiblJ5WVdOMExsUjRia052Ym5SeVlXTjBMbU5oYkd4ZmQybDBhRjloWTJablgyNXZYM0psZEhWeWJpaGhPaUJpZVhSbGN5d2dZV05tWnpvZ2RXbHVkRFkwTENCaU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1kyRnNiRjkzYVhSb1gyRmpabWRmYm05ZmNtVjBkWEp1T2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHeGZkSGh1TDNSNGJsOWpiMjUwY21GamRDNXdlVG95Tnkwek1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1kyRnNiRjkzYVhSb1gyRmpabWRmYm05ZmNtVjBkWEp1S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzSUdFNklFSjVkR1Z6TENCaFkyWm5PaUJuZEhodUxrRnpjMlYwUTI5dVptbG5WSEpoYm5OaFkzUnBiMjRzSUdJNklFSjVkR1Z6Q2lBZ0lDQXZMeUFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzWDNSNGJpOTBlRzVmWTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklHRnpjMlZ5ZENCaElEMDlJR0lpWVNJc0lDSmhJR2x6SUc1dmRDQmhJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lTQnBjeUJ1YjNRZ1lRb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3hmZEhodUwzUjRibDlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdJZ1BUMGdZaUppSWl3Z0ltSWdhWE1nYm05MElHSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaUlHbHpJRzV2ZENCaUNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiRjkwZUc0dmRIaHVYMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWVdObVp5NWpjbVZoZEdWa1gyRnpjMlYwTG1sa0xDQWlaWGh3WldOMFpXUWdZWE56WlhRZ2FXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhOelpYUWdhV1FLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFNbUF3RmhBV0lFRlI5OGRURWJRUUNKZ2dNRW9mVUVEUVJ0UndDdEJNaEFCMzAyR2dDT0F3Qk1BQ1VBQTRFQVF6RVpGRVF4R0VRMkdnRlhBZ0F4RmlJSlNUZ1FJeEpFTmhvQ1Z3SUFpQUNFSWtNeEdSUkVNUmhFTmhvQlZ3SUFNUllpQ1VrNEVDTVNSRFlhQWxjQ0FJZ0FUaFlxVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTVJZaUNUWWFBbGNDQUlnQUVoWXFURkN3SWtNeEdVRC9qakVZRkVRaVE0b0RBWXY5S0JKRWkvOHBFa1NML2pnUUl4SkVpLzQ0UEVsRWlZb0RBWXY5S0JKRWkvOHBFa1NML2pnOFNVU0ppZ01BaS8wb0VrU0wveWtTUkl2K09EeEVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
