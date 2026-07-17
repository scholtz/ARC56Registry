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

namespace Arc56.Generated.SomehowLiving.find_your_sugar.SugarDaddyPlatform_0e4387a2
{


    public class SugarDaddyPlatformProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SugarDaddyPlatformProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the contract
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new user
        ///</summary>
        public async Task RegisterUser(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 190, 224, 168 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterUser_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 190, 224, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user reputation
        ///</summary>
        public async Task<ulong> GetUserReputation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 56, 238, 36 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserReputation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 56, 238, 36 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a funding request - simplified
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> RecordFundingRequest(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 37, 231, 201 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordFundingRequest_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 37, 231, 201 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform statistics
        ///</summary>
        public async Task<ulong> GetPlatformStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 96, 126, 95 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 96, 126, 95 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3VnYXJEYWRkeVBsYXRmb3JtIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyVXNlciIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyB1c2VyIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJSZXB1dGF0aW9uIiwiZGVzYyI6IkdldCB1c2VyIHJlcHV0YXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRGdW5kaW5nUmVxdWVzdCIsImRlc2MiOiJSZWNvcmQgYSBmdW5kaW5nIHJlcXVlc3QgLSBzaW1wbGlmaWVkIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsYXRmb3JtU3RhdHMiLCJkZXNjIjoiR2V0IHBsYXRmb3JtIHN0YXRpc3RpY3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMwMF0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5LDEzNiwxNTcsMTc0LDE4Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMF0sImVycm9yTWVzc2FnZSI6IlVzZXIgYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxLDI5MCwyOTddLCJlcnJvck1lc3NhZ2UiOiJVc2VyIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyLDEzOSwxNjAsMTc3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NiwzMDQsMzA4LDMxOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOCwyNzAsMjc4LDI5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0oxYzJWeVVtVm5hWE4wWlhKbFpDSWdJblJ2ZEdGc1ZYTmxjbk1pSUNKMGIzUmhiRkpsY1hWbGMzUnpJaUF3ZURFMU1XWTNZemMxSUNKMWMyVnlVbVZ3ZFhSaGRHbHZiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRXZGhja1JoWkdSNVVHeGhkR1p2Y20wZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZamcwTkRkaU16WWdNSGc0T1dKbFpUQmhPQ0F3ZUdWbU16aGxaVEkwSURCNE5USXlOV1UzWXprZ01IaGpaRFl3TjJVMVppQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV2RwYzNSbGNsVnpaWElvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEZWelpYSlNaWEIxZEdGMGFXOXVLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpFWjFibVJwYm1kU1pYRjFaWE4wS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZCc1lYUm1iM0p0VTNSaGRITW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTXlCdFlXbHVYM0psWjJsemRHVnlWWE5sY2w5eWIzVjBaVUEwSUcxaGFXNWZaMlYwVlhObGNsSmxjSFYwWVhScGIyNWZjbTkxZEdWQU5TQnRZV2x1WDNKbFkyOXlaRVoxYm1ScGJtZFNaWEYxWlhOMFgzSnZkWFJsUURZZ2JXRnBibDluWlhSUWJHRjBabTl5YlZOMFlYUnpYM0p2ZFhSbFFEY0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRkV2RoY2tSaFpHUjVVR3hoZEdadmNtMGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJzWVhSbWIzSnRVM1JoZEhOZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCblpYUlFiR0YwWm05eWJWTjBZWFJ6S0NrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVUd4aGRHWnZjbTFUZEdGMGN3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5eVpXTnZjbVJHZFc1a2FXNW5VbVZ4ZFdWemRGOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklISmxZMjl5WkVaMWJtUnBibWRTWlhGMVpYTjBLR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRk4xWjJGeVJHRmtaSGxRYkdGMFptOXliU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJ5WldOdmNtUkdkVzVrYVc1blVtVnhkV1Z6ZENoaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlISmxZMjl5WkVaMWJtUnBibWRTWlhGMVpYTjBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlZ6WlhKU1pYQjFkR0YwYVc5dVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xKbGNIVjBZWFJwYjI0b0tUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSVmMyVnlVbVZ3ZFhSaGRHbHZiZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV2RwYzNSbGNsVnpaWEpmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJ5WldkcGMzUmxjbFZ6WlhJb0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdjbVZuYVhOMFpYSlZjMlZ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUZFdkaGNrUmhaR1I1VUd4aGRHWnZjbTB1WTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVdSdGFXNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMGIzUmhiRlZ6WlhKeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGVnpaWEp6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VmMyVnljeTUyWVd4MVpTQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdkRzkwWVd4U1pYRjFaWE4wY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4U1pYRjFaWE4wY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1VtVnhkV1Z6ZEhNdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRXZGhja1JoWkdSNVVHeGhkR1p2Y20wdWNtVm5hWE4wWlhKVmMyVnlLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpWYzJWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxuVnpaWEpTWldkcGMzUmxjbVZrS0ZSNGJpNXpaVzVrWlhJcExtaGhjMVpoYkhWbEtTQjdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhWelpYSlNaV2RwYzNSbGNtVmtJRDBnVEc5allXeFRkR0YwWlR4aWIyOXNaV0Z1UGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWMyVnlVbVZuYVhOMFpYSmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTUxYzJWeVVtVm5hWE4wWlhKbFpDaFVlRzR1YzJWdVpHVnlLUzVvWVhOV1lXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnlaV2RwYzNSbGNsVnpaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG5WelpYSlNaV2RwYzNSbGNtVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQ0FuVlhObGNpQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCMWMyVnlVbVZuYVhOMFpYSmxaQ0E5SUV4dlkyRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxjbEpsWjJsemRHVnlaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuVnpaWEpTWldkcGMzUmxjbVZrS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTENBblZYTmxjaUJoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FuS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVlhObGNpQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtDbkpsWjJsemRHVnlWWE5sY2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnZEdocGN5NTFjMlZ5VW1WbmFYTjBaWEpsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIUnlkV1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjFjMlZ5VW1WbmFYTjBaWEpsWkNBOUlFeHZZMkZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2xKbFoybHpkR1Z5WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVVtVm5hWE4wWlhKbFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZEdocGN5NTFjMlZ5VW1Wd2RYUmhkR2x2YmloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlERXdNQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklIVnpaWEpTWlhCMWRHRjBhVzl1SUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luVnpaWEpTWlhCMWRHRjBhVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhSb2FYTXVkWE5sY2xKbGNIVjBZWFJwYjI0b1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQXhNREFLSUNBZ0lIQjFjMmhwYm5RZ01UQXdJQzh2SURFd01Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RHOTBZV3hWYzJWeWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1ZYTmxjbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hWYzJWeWN5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFZjMlZ5Y3k1MllXeDFaU0FySURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjBiM1JoYkZWelpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRlZ6WlhKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFZjMlZ5Y3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4VmMyVnljeTUyWVd4MVpTQXJJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTNWbllYSkVZV1JrZVZCc1lYUm1iM0p0TG1kbGRGVnpaWEpTWlhCMWRHRjBhVzl1S0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJWYzJWeVVtVndkWFJoZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVkWE5sY2xKbFoybHpkR1Z5WldRb1ZIaHVMbk5sYm1SbGNpa3VhR0Z6Vm1Gc2RXVXBJSHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2RYTmxjbEpsWjJsemRHVnlaV1FnUFNCTWIyTmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEpTWldkcGMzUmxjbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1MWMyVnlVbVZuYVhOMFpYSmxaQ2hVZUc0dWMyVnVaR1Z5S1M1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWjJWMFZYTmxjbEpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdjbVYwZFhKdUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEZWelpYSlNaWEIxZEdGMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUxYzJWeVVtVm5hWE4wWlhKbFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd2dKMVZ6WlhJZ2JtOTBJSEpsWjJsemRHVnlaV1FuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjFjMlZ5VW1WbmFYTjBaWEpsWkNBOUlFeHZZMkZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkWE5sY2xKbFoybHpkR1Z5WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkWE5sY2xKbFoybHpkR1Z5WldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0lDZFZjMlZ5SUc1dmRDQnlaV2RwYzNSbGNtVmtKeWtLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUZWelpYSWdibTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTFjMlZ5VW1Wd2RYUmhkR2x2YmloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QjFjMlZ5VW1Wd2RYUmhkR2x2YmlBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjFjMlZ5VW1Wd2RYUmhkR2x2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTFjMlZ5VW1Wd2RYUmhkR2x2YmloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlFvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1ZuWVhKRVlXUmtlVkJzWVhSbWIzSnRMbkpsWTI5eVpFWjFibVJwYm1kU1pYRjFaWE4wS0dGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q25KbFkyOXlaRVoxYm1ScGJtZFNaWEYxWlhOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklISmxZMjl5WkVaMWJtUnBibWRTWlhGMVpYTjBLR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1MWMyVnlVbVZuYVhOMFpYSmxaQ2hVZUc0dWMyVnVaR1Z5S1M1b1lYTldZV3gxWlNrZ2V3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUIxYzJWeVVtVm5hWE4wWlhKbFpDQTlJRXh2WTJGc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFhObGNsSmxaMmx6ZEdWeVpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMblZ6WlhKU1pXZHBjM1JsY21Wa0tGUjRiaTV6Wlc1a1pYSXBMbWhoYzFaaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVmMyVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkWE5sY2xKbFoybHpkR1Z5WldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0lDZFZjMlZ5SUc1dmRDQnlaV2RwYzNSbGNtVmtKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2RYTmxjbEpsWjJsemRHVnlaV1FnUFNCTWIyTmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEpTWldkcGMzUmxjbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuVnpaWEpTWldkcGMzUmxjbVZrS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTENBblZYTmxjaUJ1YjNRZ2NtVm5hWE4wWlhKbFpDY3BDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYzJWeUlHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWVhOelpYSjBLR0Z0YjNWdWRDQStJREFzSUNkQmJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z2RHOTBZV3hTWlhGMVpYTjBjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNVbVZ4ZFdWemRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNVbVZ4ZFdWemRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFNaWEYxWlhOMGN5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFNaWEYxWlhOMGN5NTJZV3gxWlNBcklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUIwYjNSaGJGSmxjWFZsYzNSeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGSmxjWFZsYzNSeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFNaWEYxWlhOMGN5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFNaWEYxWlhOMGN5NTJZV3gxWlNBcklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxjWFZsYzNSSlpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sTjFaMkZ5UkdGa1pIbFFiR0YwWm05eWJTNW5aWFJRYkdGMFptOXliVk4wWVhSektDa2dMVDRnZFdsdWREWTBPZ3BuWlhSUWJHRjBabTl5YlZOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdkRzkwWVd4VmMyVnljeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNWWE5sY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzVlhObGNuTXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQlE1MWMyVnlVbVZuYVhOMFpYSmxaQXAwYjNSaGJGVnpaWEp6RFhSdmRHRnNVbVZ4ZFdWemRITUVGUjk4ZFE1MWMyVnlVbVZ3ZFhSaGRHbHZiakViUVFBcWdnVUV1RVI3TmdTSnZ1Q29CTzg0N2lRRVVpWG55UVROWUg1Zk5ob0FqZ1VBUlFBNUFDZ0FFd0FDSWtNeEdSUkVNUmhFaUFDOUZpdE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBQ0ZGaXRNVUxBalF6RVpGRVF4R0VTSUFGa1dLMHhRc0NORE1Sa1VSREVZUklnQUlDTkRNUmtVUkRFWUZFU0lBQUlqUTRBRllXUnRhVzR4QUdjcEltY3FJbWVKTVFBaUtHTkZBVUVBQ0RFQUlpaGpSQlJFTVFBb0kyWXhBQ2NFZ1dSbUlpbGxSQ01JS1V4bmlURUFJaWhqUlFGQUFBSWlpVEVBSWloalJFUXhBQ0luQkdORWlZb0JBVEVBSWloalJRRkVNUUFpS0dORVJJdi9SQ0lxWlVRaUttVkVJd2dxVEdlSklpbGxSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
