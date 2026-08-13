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

namespace Arc56.Generated.algorandfoundation.puya.Contract_a4124001
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestPoseidon2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 52, 158, 173 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestPoseidon2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 52, 158, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestAppParams(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 220, 5, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 220, 5, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestAppBoxOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 146, 189, 237 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppBoxOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 146, 189, 237 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBlock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 242, 29, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBlock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 242, 29, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9uZXdfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcG9zZWlkb24yIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXBwX3BhcmFtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2FwcF9ib3hfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYmxvY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXpDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdPQ0EwQ2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TmpJM09DQXdlR1ptQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TVRRS0lDQWdJQzh2SUdOc1lYTnpJRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZEN3Z1lYWnRYM1psY25OcGIyNDlNVE1wT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1USUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHTXlZamhrWkRoaElEQjRNR0l6TkRsbFlXUWdNSGhsWTJSak1EVmpOaUF3ZUdWak9USmlaR1ZrSURCNE9HTm1NakZrT0dZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wWDI1bGQxOXZjSE1vS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSZmNHOXpaV2xrYjI0eUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMkZ3Y0Y5d1lYSmhiWE1vS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSZllYQndYMkp2ZUY5dmNITW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JmWW14dlkyc29LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjBaWE4wWDI1bGQxOXZjSE1nZEdWemRGOXdiM05sYVdSdmJqSWdkR1Z6ZEY5aGNIQmZjR0Z5WVcxeklIUmxjM1JmWVhCd1gySnZlRjl2Y0hNZ2RHVnpkRjlpYkc5amF3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GMmJWOHhNeTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzUwWlhOMFgyNWxkMTl2Y0hOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDI1bGQxOXZjSE02Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1emFHRTFNVElvWWlJaUtTQWhQU0J2Y0M1emFHRTFNVElvWWlKaElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnYzJoaE5URXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJNUW9nSUNBZ2MyaGhOVEV5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWFp0WHpFekxtTnZiblJ5WVdOMExrTnZiblJ5WVdOMExuUmxjM1JmY0c5elpXbGtiMjR5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjl3YjNObGFXUnZiakk2Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUhOallXeGhjaUE5SUc5d0xtSjZaWEp2S0RNeUtRb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZbnBsY204S0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1ltNGdQU0J2Y0M1d2IzTmxhV1J2YmpJb2IzQXVVRzl6Wldsa2IyNHlRMjl1Wm1sbmRYSmhkR2x2Ym5NdVFrNHlOVFIwTWl3Z2MyTmhiR0Z5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndiM05sYVdSdmJqSWdRazR5TlRSME1nb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QmliSE1nUFNCdmNDNXdiM05sYVdSdmJqSW9iM0F1VUc5elpXbGtiMjR5UTI5dVptbG5kWEpoZEdsdmJuTXVRa3hUTVRKZk16Z3hkRElzSUhOallXeGhjaWtLSUNBZ0lITjNZWEFLSUNBZ0lIQnZjMlZwWkc5dU1pQkNURk14TWw4ek9ERjBNZ29nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPakkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZbTRnSVQwZ1lteHpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYWnRYekV6TG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG5SbGMzUmZZWEJ3WDNCaGNtRnRjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZZWEJ3WDNCaGNtRnRjem9LSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnWVhCd0lEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1FLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QnpjRzl1YzI5eUxDQmxlR2x6ZEhNZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYM05wZW1WZmMzQnZibk52Y2loaGNIQXBDaUFnSUNCa2RYQUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0ZOcGVtVlRjRzl1YzI5eUNpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnYzNCdmJuTnZjaUE5UFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWm1KeUxDQmxlR2x6ZEhNZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYMlp2Y21WcFoyNWZZbTk0WDNKbFlXUnpLR0Z3Y0NrS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndSbTl5WldsbmJrSnZlRkpsWVdSekNpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCaGMzTmxjblFnYm05MElHWmljZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJR1ppWVN3Z1pYaHBjM1J6SUQwZ2IzQXVRWEJ3VUdGeVlXMXpSMlYwTG1Gd2NGOW1ZVzFwYkhsZlltOTRYMkZqWTJWemN5aGhjSEFwQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFWmhiV2xzZVVKdmVFRmpZMlZ6Y3dvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCbVltRUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QnZjQzVCY0hCUVlYSmhiWE5UWlhRdVlYQndYMlp2Y21WcFoyNWZZbTk0WDNKbFlXUnpLRlJ5ZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTl6WlhRZ1FYQndSbTl5WldsbmJrSnZlRkpsWVdSekNpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklHOXdMa0Z3Y0ZCaGNtRnRjMU5sZEM1aGNIQmZabUZ0YVd4NVgySnZlRjloWTJObGMzTW9WSEoxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYM05sZENCQmNIQkdZVzFwYkhsQ2IzaEJZMk5sYzNNS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z1ptSnlMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQlFZWEpoYlhOSFpYUXVZWEJ3WDJadmNtVnBaMjVmWW05NFgzSmxZV1J6S0dGd2NDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3Um05eVpXbG5ia0p2ZUZKbFlXUnpDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QmhjM05sY25RZ1ptSnlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnWm1KaExDQmxlR2x6ZEhNZ1BTQnZjQzVCY0hCUVlYSmhiWE5IWlhRdVlYQndYMlpoYldsc2VWOWliM2hmWVdOalpYTnpLR0Z3Y0NrS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRVpoYldsc2VVSnZlRUZqWTJWemN3b2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1lYTnpaWEowSUdaaVlRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYWnRYekV6TG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG5SbGMzUmZZWEJ3WDJKdmVGOXZjSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMkZ3Y0Y5aWIzaGZiM0J6T2dvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCaGNIQWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDlwWkFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzVCY0hCQ2IzZ3VZM0psWVhSbEtHRndjQ3dnYm1GdFpTd2dPQ2tLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ1WVcxbElEMGdRbmwwWlhNb1lpSmllQ0lwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJM09Bb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRWEJ3UW05NExtTnlaV0YwWlNoaGNIQXNJRzVoYldVc0lEZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWVhCd1gySnZlRjlqY21WaGRHVUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJ2Y0M1QmNIQkNiM2d1Y0hWMEtHRndjQ3dnYm1GdFpTd2diM0F1WW5wbGNtOG9PQ2twQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUc1aGJXVWdQU0JDZVhSbGN5aGlJbUo0SWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1qYzRDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJRzl3TGtGd2NFSnZlQzV3ZFhRb1lYQndMQ0J1WVcxbExDQnZjQzVpZW1WeWJ5ZzRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWW05NFgzQjFkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUIyWVd4MVpTd2daWGhwYzNSeklEMGdiM0F1UVhCd1FtOTRMbWRsZENoaGNIQXNJRzVoYldVcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QnVZVzFsSUQwZ1FubDBaWE1vWWlKaWVDSXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakkzT0FvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCMllXeDFaU3dnWlhocGMzUnpJRDBnYjNBdVFYQndRbTk0TG1kbGRDaGhjSEFzSUc1aGJXVXBDaUFnSUNCaGNIQmZZbTk0WDJkbGRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxJRDA5SUc5d0xtSjZaWEp2S0RncENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHOXdMa0Z3Y0VKdmVDNXlaWEJzWVdObEtHRndjQ3dnYm1GdFpTd2dNQ3dnWWlKY2VHWm1JaWtLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ1WVcxbElEMGdRbmwwWlhNb1lpSmllQ0lwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJM09Bb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QnZjQzVCY0hCQ2IzZ3VjbVZ3YkdGalpTaGhjSEFzSUc1aGJXVXNJREFzSUdJaVhIaG1aaUlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlR1ptQ2lBZ0lDQmhjSEJmWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrRndjRUp2ZUM1bGVIUnlZV04wS0dGd2NDd2dibUZ0WlN3Z01Dd2dNU2tnUFQwZ1lpSmNlR1ptSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUc1aGJXVWdQU0JDZVhSbGN5aGlJbUo0SWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1qYzRDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjQzVCY0hCQ2IzZ3VaWGgwY21GamRDaGhjSEFzSUc1aGJXVXNJREFzSURFcElEMDlJR0lpWEhobVppSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDJKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNFptWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdiM0F1UVhCd1FtOTRMbk53YkdsalpTaGhjSEFzSUc1aGJXVXNJREVzSURNc0lHSWlZV0pqSWlrS0lDQWdJR1IxY0FvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCdVlXMWxJRDBnUW5sMFpYTW9ZaUppZUNJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qSTNPQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJ2Y0M1QmNIQkNiM2d1YzNCc2FXTmxLR0Z3Y0N3Z2JtRnRaU3dnTVN3Z015d2dZaUpoWW1NaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjROakUyTWpZekNpQWdJQ0JoY0hCZlltOTRYM053YkdsalpRb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnZjQzVCY0hCQ2IzZ3VjbVZ6YVhwbEtHRndjQ3dnYm1GdFpTd2dOQ2tLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ1WVcxbElEMGdRbmwwWlhNb1lpSmllQ0lwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJM09Bb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnZjQzVCY0hCQ2IzZ3VjbVZ6YVhwbEtHRndjQ3dnYm1GdFpTd2dOQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCaGNIQmZZbTk0WDNKbGMybDZaUW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJzWlc1bmRHZ3NJR1Y0YVhOMGN5QTlJRzl3TGtGd2NFSnZlQzVzWlc1bmRHZ29ZWEJ3TENCdVlXMWxLUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRzVoYldVZ1BTQkNlWFJsY3loaUltSjRJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWpjNENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklHeGxibWQwYUN3Z1pYaHBjM1J6SUQwZ2IzQXVRWEJ3UW05NExteGxibWQwYUNoaGNIQXNJRzVoYldVcENpQWdJQ0JoY0hCZlltOTRYMnhsYmdvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnWVhOelpYSjBJR3hsYm1kMGFDQTlQU0EwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ1WVcxbElEMGdRbmwwWlhNb1lpSmllQ0lwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJM09Bb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRWEJ3UW05NExtUmxiR1YwWlNoaGNIQXNJRzVoYldVcENpQWdJQ0JoY0hCZlltOTRYMlJsYkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhadFh6RXpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMblJsYzNSZllteHZZMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMkpzYjJOck9nb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QmljbUZ1WTJnMU1USWdQU0J2Y0M1Q2JHOWpheTVpYkd0ZlluSmhibU5vTlRFeUtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyUW5KaGJtTm9OVEV5Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUhOb1lUVXhNbDh5TlRaZlkyOXRiV2wwYldWdWRDQTlJRzl3TGtKc2IyTnJMbUpzYTE5emFHRTFNVEpmTWpVMlgzUjRibDlqYjIxdGFYUnRaVzUwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJVMmhoTlRFeVh6STFObFI0YmtOdmJXMXBkRzFsYm5RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z2MyaGhNalUyWDJOdmJXMXBkRzFsYm5RZ1BTQnZjQzVDYkc5amF5NWliR3RmYzJoaE1qVTJYM1I0Ymw5amIyMXRhWFJ0Wlc1MEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyVTJoaE1qVTJWSGh1UTI5dGJXbDBiV1Z1ZEFvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCemFHRTFNVEpmWTI5dGJXbDBiV1Z1ZENBOUlHOXdMa0pzYjJOckxtSnNhMTl6YUdFMU1USmZkSGh1WDJOdmJXMXBkRzFsYm5Rb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RUYUdFMU1USlVlRzVEYjIxdGFYUnRaVzUwQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0JpY21GdVkyZzFNVElnSVQwZ2MyaGhOVEV5WDJOdmJXMXBkRzFsYm5RS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMmhoTlRFeVh6STFObDlqYjIxdGFYUnRaVzUwSUNFOUlITm9ZVEkxTmw5amIyMXRhWFJ0Wlc1MENpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRTQUVBUUFJQkNZQ0FtSjRBZjh4RzBGa01Sa1VSREVZUklJRkJNSzQzWW9FQ3pTZXJRVHMzQVhHQk95U3ZlMEVqUElkanpZYUFJNEZBQWtBRkFBaEFFZ0Fqd0F4R1JReEdCUVFRNEFBaDRBQllZY1RSQ0pEZ1NDdlNlY0FUT2NCRTBRaVF6SUlTWElLUkRJREVrUkpjZ3RFRkVSSmNneEVGRVFpZGdzaWRneEpjZ3RFUkhJTVJFUWlReklJU1NnazFBRkVKSzlMQVNoTEF0UUhTd0VvMUFaRUVrUkpLQ01wMUFOSktDTWkxQUlwRWtSSktDS0JBNEFEWVdKajFBaEpLQ1hVQ1VrbzFBVkVKUkpFS05RRVJDSkRJOUVLSTlFTEk5RU1JOUVOVHdNVFJCTkVJa009IiwiY2xlYXIiOiJEWUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
