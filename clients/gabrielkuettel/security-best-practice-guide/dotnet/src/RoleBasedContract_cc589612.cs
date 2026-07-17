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

namespace Arc56.Generated.gabrielkuettel.security_best_practice_guide.RoleBasedContract_cc589612
{


    public class RoleBasedContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RoleBasedContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
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
        ///
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task GrantRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 127, 12, 228 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 127, 12, 228 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task RevokeRole(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 44, 97, 116 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeRole_Transactions(byte[] role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 44, 97, 116 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PerformOperation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 75, 236, 241 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PerformOperation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 75, 236, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUm9sZUJhc2VkQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3JhbnRSb2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGVyZm9ybU9wZXJhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjQ4XSwiZXJyb3JNZXNzYWdlIjoiTWlzc2luZyByZXF1aXJlZCByb2xlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgRGVsZXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIFVwZGF0ZUFwcGxpY2F0aW9uICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQsMTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxLDE2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDIsMTc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lESWdNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUZrYldsdUlpQWljbTlzWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTh5TFdGalkyVnpjeTFqYjI1MGNtOXNMM0p2YkdVdFltRnpaV1F0WVdOalpYTnpMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZKdmJHVkNZWE5sWkVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURRMlpqYzJOVE16SURCNE1qUTROMk16TW1NZ0x5OGdiV1YwYUc5a0lDSjFjR1JoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z3WkdGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFESWdiV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkp2YkdWQ1lYTmxaRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaR0UzWmpCalpUUWdNSGhqTWpKak5qRTNOQ0F3ZUdFNU5HSmxZMll4SUM4dklHMWxkR2h2WkNBaVozSmhiblJTYjJ4bEtHSjVkR1ZiWFN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsZG05clpWSnZiR1VvWW5sMFpWdGRMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNHVnlabTl5YlU5d1pYSmhkR2x2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdkeVlXNTBVbTlzWlNCeVpYWnZhMlZTYjJ4bElIQmxjbVp2Y20xUGNHVnlZWFJwYjI0S0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4eUxXRmpZMlZ6Y3kxamIyNTBjbTlzTDNKdmJHVXRZbUZ6WldRdFlXTmpaWE56TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGSnZiR1ZDWVhObFpFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNVEVLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4eUxXRmpZMlZ6Y3kxamIyNTBjbTlzTDNKdmJHVXRZbUZ6WldRdFlXTmpaWE56TG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaR1ZzWlhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4eUxXRmpZMlZ6Y3kxamIyNTBjbTlzTDNKdmJHVXRZbUZ6WldRdFlXTmpaWE56TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhCMVlteHBZeUJrWld4bGRHVkJjSEJzYVdOaGRHbHZiaWdwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOU0F2THlCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtDbTFoYVc1ZmRYQmtZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTh5TFdGalkyVnpjeTFqYjI1MGNtOXNMM0p2YkdVdFltRnpaV1F0WVdOalpYTnpMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJSEIxWW14cFl5QjFjR1JoZEdWQmNIQnNhV05oZEdsdmJpZ3BPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJWY0dSaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdJZ2RYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZNaTFoWTJObGMzTXRZMjl1ZEhKdmJDOXliMnhsTFdKaGMyVmtMV0ZqWTJWemN5NWhiR2R2TG5Sek9qcFNiMnhsUW1GelpXUkRiMjUwY21GamRDNW5jbUZ1ZEZKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuY21GdWRGSnZiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZNaTFoWTJObGMzTXRZMjl1ZEhKdmJDOXliMnhsTFdKaGMyVmtMV0ZqWTJWemN5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QndkV0pzYVdNZ1ozSmhiblJTYjJ4bEtISnZiR1U2SUdKNWRHVnpMQ0JoWTJOdmRXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZNaTFoWTJObGMzTXRZMjl1ZEhKdmJDOXliMnhsTFdKaGMyVmtMV0ZqWTJWemN5NWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QjBhR2x6TG5KbGNYVnBjbVZTYjJ4bEtGSlBURVZmUVVSTlNVNHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJR05oYkd4emRXSWdjbVZ4ZFdseVpWSnZiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIUm9hWE11Y205c1pYTW9jbTlzWlM1amIyNWpZWFFvWVdOamIzVnVkQzVpZVhSbGN5a3BMblpoYkhWbElEMGdWV2x1ZERZMEtERXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhKdmJHVnpJRDBnUW05NFRXRndQR0o1ZEdWekxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuY205c1pTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkp2YkdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4eUxXRmpZMlZ6Y3kxamIyNTBjbTlzTDNKdmJHVXRZbUZ6WldRdFlXTmpaWE56TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhSb2FYTXVjbTlzWlhNb2NtOXNaUzVqYjI1allYUW9ZV05qYjNWdWRDNWllWFJsY3lrcExuWmhiSFZsSUQwZ1ZXbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnY0hWaWJHbGpJR2R5WVc1MFVtOXNaU2h5YjJ4bE9pQmllWFJsY3l3Z1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk9sSnZiR1ZDWVhObFpFTnZiblJ5WVdOMExuSmxkbTlyWlZKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhadmEyVlNiMnhsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxkbTlyWlZKdmJHVW9jbTlzWlRvZ1lubDBaWE1zSUdGalkyOTFiblE2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTh5TFdGalkyVnpjeTFqYjI1MGNtOXNMM0p2YkdVdFltRnpaV1F0WVdOalpYTnpMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSFJvYVhNdWNtVnhkV2x5WlZKdmJHVW9VazlNUlY5QlJFMUpUaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWTJGc2JITjFZaUJ5WlhGMWFYSmxVbTlzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnY205c1pTNWpiMjVqWVhRb1lXTmpiM1Z1ZEM1aWVYUmxjeWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QndkV0pzYVdNZ2NtOXNaWE1nUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkeWIyeGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY205c1pTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk1pMWhZMk5sYzNNdFkyOXVkSEp2YkM5eWIyeGxMV0poYzJWa0xXRmpZMlZ6Y3k1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCcFppQW9kR2hwY3k1eWIyeGxjeWhyWlhrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ5WlhadmEyVlNiMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6SXRZV05qWlhOekxXTnZiblJ5YjJ3dmNtOXNaUzFpWVhObFpDMWhZMk5sYzNNdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2RHaHBjeTV5YjJ4bGN5aHJaWGtwTG1SbGJHVjBaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvS2NtVjJiMnRsVW05c1pWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TWkxaFkyTmxjM010WTI5dWRISnZiQzl5YjJ4bExXSmhjMlZrTFdGalkyVnpjeTVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVYyYjJ0bFVtOXNaU2h5YjJ4bE9pQmllWFJsY3l3Z1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk9sSnZiR1ZDWVhObFpFTnZiblJ5WVdOMExuQmxjbVp2Y20xUGNHVnlZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdaWEptYjNKdFQzQmxjbUYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnZEdocGN5NXlaWEYxYVhKbFVtOXNaU2hTVDB4RlgwOVFSVkpCVkU5U0tRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdmNHVnlZWFJ2Y2lJS0lDQWdJR05oYkd4emRXSWdjbVZ4ZFdseVpWSnZiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIQjFZbXhwWXlCd1pYSm1iM0p0VDNCbGNtRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk9sSnZiR1ZDWVhObFpFTnZiblJ5WVdOMExuVndaR0YwWlVGd2NHeHBZMkYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk1pMWhZMk5sYzNNdFkyOXVkSEp2YkM5eWIyeGxMV0poYzJWa0xXRmpZMlZ6Y3k1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCMGFHbHpMbkpsY1hWcGNtVlNiMnhsS0ZKUFRFVmZRVVJOU1U0cENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnhkV2x5WlZKdmJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k4eUxXRmpZMlZ6Y3kxamIyNTBjbTlzTDNKdmJHVXRZbUZ6WldRdFlXTmpaWE56TG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVkJjSEJzYVdOaGRHbHZiaWdwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk1pMWhZMk5sYzNNdFkyOXVkSEp2YkM5eWIyeGxMV0poYzJWa0xXRmpZMlZ6Y3k1aGJHZHZMblJ6T2pwU2IyeGxRbUZ6WldSRGIyNTBjbUZqZEM1a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnZEdocGN5NXlaWEYxYVhKbFVtOXNaU2hTVDB4RlgwRkVUVWxPS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNCallXeHNjM1ZpSUhKbGNYVnBjbVZTYjJ4bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TWkxaFkyTmxjM010WTI5dWRISnZiQzl5YjJ4bExXSmhjMlZrTFdGalkyVnpjeTVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem82VW05c1pVSmhjMlZrUTI5dWRISmhZM1F1Y21WeGRXbHlaVkp2YkdVb2NtOXNaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbkpsY1hWcGNtVlNiMnhsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjSEpwZG1GMFpTQnlaWEYxYVhKbFVtOXNaU2h5YjJ4bE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdk1pMWhZMk5sYzNNdFkyOXVkSEp2YkM5eWIyeGxMV0poYzJWa0xXRmpZMlZ6Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NW9ZWE5TYjJ4bEtISnZiR1VzSUZSNGJpNXpaVzVrWlhJcExDQW5UV2x6YzJsdVp5QnlaWEYxYVhKbFpDQnliMnhsSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHbG1JQ2h5YjJ4bElEMDlQU0JTVDB4RlgwRkVUVWxPSUNZbUlHRmpZMjkxYm5RZ1BUMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3lrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaFpHMXBiaUlLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaWEYxYVhKbFVtOXNaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ5WlhGMWFYSmxVbTlzWlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OHlMV0ZqWTJWemN5MWpiMjUwY205c0wzSnZiR1V0WW1GelpXUXRZV05qWlhOekxtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklISmxkSFZ5YmlCMGNuVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tjbVZ4ZFdseVpWSnZiR1ZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdk1pMWhZMk5sYzNNdFkyOXVkSEp2YkM5eWIyeGxMV0poYzJWa0xXRmpZMlZ6Y3k1aGJHZHZMblJ6T2pwU2IyeGxRbUZ6WldSRGIyNTBjbUZqZEM1b1lYTlNiMnhsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12TWkxaFkyTmxjM010WTI5dWRISnZiQzl5YjJ4bExXSmhjMlZrTFdGalkyVnpjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1b1lYTlNiMnhsS0hKdmJHVXNJRlI0Ymk1elpXNWtaWElwTENBblRXbHpjMmx1WnlCeVpYRjFhWEpsWkNCeWIyeGxKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5hWE56YVc1bklISmxjWFZwY21Wa0lISnZiR1VLSUNBZ0lISmxkSE4xWWdvS2NtVnhkV2x5WlZKdmJHVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnWTI5dWMzUWdhMlY1SUQwZ2NtOXNaUzVqYjI1allYUW9ZV05qYjNWdWRDNWllWFJsY3lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QndkV0pzYVdNZ2NtOXNaWE1nUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUNkeWIyeGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY205c1pTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekx6SXRZV05qWlhOekxXTnZiblJ5YjJ3dmNtOXNaUzFpWVhObFpDMWhZMk5sYzNNdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjbTlzWlhNb2EyVjVLUzVsZUdsemRITUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMekl0WVdOalpYTnpMV052Ym5SeWIyd3ZjbTlzWlMxaVlYTmxaQzFoWTJObGMzTXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YUdGelVtOXNaU2h5YjJ4bExDQlVlRzR1YzJWdVpHVnlLU3dnSjAxcGMzTnBibWNnY21WeGRXbHlaV1FnY205c1pTY3BDaUFnSUNCaUlISmxjWFZwY21WU2IyeGxYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6THpJdFlXTmpaWE56TFdOdmJuUnliMnd2Y205c1pTMWlZWE5sWkMxaFkyTmxjM011WVd4bmJ5NTBjem82VW05c1pVSmhjMlZrUTI5dWRISmhZM1F1YUdGelVtOXNaVUExQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUNJQ1lDQldGa2JXbHVCSEp2YkdXQ0FnUkc5MlV6QkNTSHd5dzJHZ0NPQWdCQ0FEWXhHUlJFTVJoQkFCMkNBd1RhZnd6a0JNSXNZWFFFcVV2czhUWWFBSTREQUNrQVRnQjZBSUFFdUVSN05qWWFBSTRCQUFFQUlrTXhHWUVGRWpFWUVFUkNBSEl4R1lFRUVqRVlFRVJDQUdBMkdnRkpJMWtrQ0VzQkZSSkVWd0lBTmhvQ1NSVWxFa1FvaUFCUVVDbE1VQ0lXdnlKRE5ob0JTU05aSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFS0lnQUsxQXBURkJKdlVVQlFRQURTYnhJSWtPQUNHOXdaWEpoZEc5eWlBQU9Ja01vaUFBSUlrTW9pQUFDSWtPS0FRQXhBSXYvS0JKQkFBdUxBRElKRWtFQUF5SkVpWXYvaXdCUUtVeFF2VVVCUXYvdyIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
