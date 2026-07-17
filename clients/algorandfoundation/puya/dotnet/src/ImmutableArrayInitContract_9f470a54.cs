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

namespace Arc56.Generated.algorandfoundation.puya.ImmutableArrayInitContract_9f470a54
{


    public class ImmutableArrayInitContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ImmutableArrayInitContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestImmutableArrayInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 52, 186, 42 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestImmutableArrayInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 52, 186, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestImmutableArrayInitWithoutTypeGeneric(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 170, 187, 160 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestImmutableArrayInitWithoutTypeGeneric_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 170, 187, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestReferenceArrayInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 175, 3, 78 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestReferenceArrayInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 175, 3, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestReferenceArrayInitWithoutTypeGeneric(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 209, 69, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestReferenceArrayInitWithoutTypeGeneric_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 209, 69, 84 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW1tdXRhYmxlQXJyYXlJbml0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9pbW11dGFibGVfYXJyYXlfaW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2ltbXV0YWJsZV9hcnJheV9pbml0X3dpdGhvdXRfdHlwZV9nZW5lcmljIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcmVmZXJlbmNlX2FycmF5X2luaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9yZWZlcmVuY2VfYXJyYXlfaW5pdF93aXRob3V0X3R5cGVfZ2VuZXJpYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURnZ015QXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQXZMeUJoY25KaGVTOXBiVzExZEdGaWJHVmZhVzVwZEM1d2VUb3hNQW9nSUNBZ0x5OGdZMnhoYzNNZ1NXMXRkWFJoWW14bFFYSnlZWGxKYm1sMFEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGcwTXpSaVlUSmhJREI0TmpOaFlXSmlZVEFnTUhoa1ltRm1NRE0wWlNBd2VHRTVaREUwTlRVMElDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5cGJXMTFkR0ZpYkdWZllYSnlZWGxmYVc1cGRDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjlwYlcxMWRHRmliR1ZmWVhKeVlYbGZhVzVwZEY5M2FYUm9iM1YwWDNSNWNHVmZaMlZ1WlhKcFl5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjl5WldabGNtVnVZMlZmWVhKeVlYbGZhVzVwZENncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOXlaV1psY21WdVkyVmZZWEp5WVhsZmFXNXBkRjkzYVhSb2IzVjBYM1I1Y0dWZloyVnVaWEpwWXlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZhVzF0ZFhSaFlteGxYMkZ5Y21GNVgybHVhWFFnZEdWemRGOXBiVzExZEdGaWJHVmZZWEp5WVhsZmFXNXBkRjkzYVhSb2IzVjBYM1I1Y0dWZloyVnVaWEpwWXlCMFpYTjBYM0psWm1WeVpXNWpaVjloY25KaGVWOXBibWwwSUhSbGMzUmZjbVZtWlhKbGJtTmxYMkZ5Y21GNVgybHVhWFJmZDJsMGFHOTFkRjkwZVhCbFgyZGxibVZ5YVdNS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY25KaGVTNXBiVzExZEdGaWJHVmZhVzVwZEM1SmJXMTFkR0ZpYkdWQmNuSmhlVWx1YVhSRGIyNTBjbUZqZEM1MFpYTjBYMmx0YlhWMFlXSnNaVjloY25KaGVWOXBibWwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjlwYlcxMWRHRmliR1ZmWVhKeVlYbGZhVzVwZERvS0lDQWdJQzh2SUdGeWNtRjVMMmx0YlhWMFlXSnNaVjlwYm1sMExuQjVPakV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEp5WVhrdWFXMXRkWFJoWW14bFgybHVhWFF1U1cxdGRYUmhZbXhsUVhKeVlYbEpibWwwUTI5dWRISmhZM1F1ZEdWemRGOXBiVzExZEdGaWJHVmZZWEp5WVhsZmFXNXBkRjkzYVhSb2IzVjBYM1I1Y0dWZloyVnVaWEpwWTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmYVcxdGRYUmhZbXhsWDJGeWNtRjVYMmx1YVhSZmQybDBhRzkxZEY5MGVYQmxYMmRsYm1WeWFXTTZDaUFnSUNBdkx5QmhjbkpoZVM5cGJXMTFkR0ZpYkdWZmFXNXBkQzV3ZVRvek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeWNtRjVMbWx0YlhWMFlXSnNaVjlwYm1sMExrbHRiWFYwWVdKc1pVRnljbUY1U1c1cGRFTnZiblJ5WVdOMExuUmxjM1JmY21WbVpYSmxibU5sWDJGeWNtRjVYMmx1YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDNKbFptVnlaVzVqWlY5aGNuSmhlVjlwYm1sME9nb2dJQ0FnTHk4Z1lYSnlZWGt2YVcxdGRYUmhZbXhsWDJsdWFYUXVjSGs2TlRjS0lDQWdJQzh2SUdFeElEMGdVbVZtWlhKbGJtTmxRWEp5WVhsYlZVbHVkRFkwWFNnb1ZVbHVkRFkwS0RFcExDQlZTVzUwTmpRb01pa3NJRlZKYm5RMk5DZ3pLU2twQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESXdNREF3TURBd01EQXdNREF3TURBekNpQWdJQ0F2THlCaGNuSmhlUzlwYlcxMWRHRmliR1ZmYVc1cGRDNXdlVG8yTUFvZ0lDQWdMeThnWVhOelpYSjBJR0V4TG14bGJtZDBhQ0E5UFNCaE1pNXNaVzVuZEdnS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdMd29nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRnljbUY1TDJsdGJYVjBZV0pzWlY5cGJtbDBMbkI1T2pZeENpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1GMGdQVDBnWVRKYk1GMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhKeVlYa3ZhVzF0ZFhSaFlteGxYMmx1YVhRdWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN4WFNBOVBTQmhNbHN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSnlZWGt2YVcxdGRYUmhZbXhsWDJsdWFYUXVjSGs2TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JoTVZzeVhTQTlQU0JoTWxzeVhRb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUdGeWNtRjVMMmx0YlhWMFlXSnNaVjlwYm1sMExuQjVPalkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTUYwZ1BUMGdZVE5iTUYwS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5Y21GNUwybHRiWFYwWVdKc1pWOXBibWwwTG5CNU9qWTRDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNVjBnUFQwZ1lUTmJNVjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGeWNtRjVMMmx0YlhWMFlXSnNaVjlwYm1sMExuQjVPalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTWwwZ1BUMGdZVE5iTWwwS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEp5WVhrdmFXMXRkWFJoWW14bFgybHVhWFF1Y0hrNk56SUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1TNXNaVzVuZEdnZ1BUMGdZVFF1YkdWdVozUm9DaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQzhLSUNBZ0lHbHVkR05mTWlBdkx5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbkpoZVM5cGJXMTFkR0ZpYkdWZmFXNXBkQzV3ZVRvM013b2dJQ0FnTHk4Z1lYTnpaWEowSUdFeFd6QmRJRDA5SUdFMFd6QmRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGeWNtRjVMMmx0YlhWMFlXSnNaVjlwYm1sMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTVYwZ1BUMGdZVFJiTVYwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRnljbUY1TDJsdGJYVjBZV0pzWlY5cGJtbDBMbkI1T2pjMUNpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1sMGdQVDBnWVRSYk1sMEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhKeVlYa3ZhVzF0ZFhSaFlteGxYMmx1YVhRdWNIazZOVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhjbkpoZVM1cGJXMTFkR0ZpYkdWZmFXNXBkQzVKYlcxMWRHRmliR1ZCY25KaGVVbHVhWFJEYjI1MGNtRmpkQzUwWlhOMFgzSmxabVZ5Wlc1alpWOWhjbkpoZVY5cGJtbDBYM2RwZEdodmRYUmZkSGx3WlY5blpXNWxjbWxqVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjl5WldabGNtVnVZMlZmWVhKeVlYbGZhVzVwZEY5M2FYUm9iM1YwWDNSNWNHVmZaMlZ1WlhKcFl6b0tJQ0FnSUM4dklHRnljbUY1TDJsdGJYVjBZV0pzWlY5cGJtbDBMbkI1T2pjNUNpQWdJQ0F2THlCaE1TQTlJRkpsWm1WeVpXNWpaVUZ5Y21GNUtDaFZTVzUwTmpRb01Ta3NJRlZKYm5RMk5DZ3lLU3dnVlVsdWREWTBLRE1wS1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNakF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUM4dklHRnljbUY1TDJsdGJYVjBZV0pzWlY5cGJtbDBMbkI1T2pneUNpQWdJQ0F2THlCaGMzTmxjblFnWVRFdWJHVnVaM1JvSUQwOUlHRXlMbXhsYm1kMGFBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEp5WVhrdmFXMXRkWFJoWW14bFgybHVhWFF1Y0hrNk9ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3dYU0E5UFNCaE1sc3dYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGNuSmhlUzlwYlcxMWRHRmliR1ZmYVc1cGRDNXdlVG80TkFvZ0lDQWdMeThnWVhOelpYSjBJR0V4V3pGZElEMDlJR0V5V3pGZENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbkpoZVM5cGJXMTFkR0ZpYkdWZmFXNXBkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdFeFd6SmRJRDA5SUdFeVd6SmRDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z1lYSnlZWGt2YVcxdGRYUmhZbXhsWDJsdWFYUXVjSGs2T0RrS0lDQWdJQzh2SUdGemMyVnlkQ0JoTVZzd1hTQTlQU0JoTTFzd1hRb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhKeVlYa3ZhVzF0ZFhSaFlteGxYMmx1YVhRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN4WFNBOVBTQmhNMXN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSnlZWGt2YVcxdGRYUmhZbXhsWDJsdWFYUXVjSGs2T1RFS0lDQWdJQzh2SUdGemMyVnlkQ0JoTVZzeVhTQTlQU0JoTTFzeVhRb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoY25KaGVTOXBiVzExZEdGaWJHVmZhVzVwZEM1d2VUbzVOQW9nSUNBZ0x5OGdZWE56WlhKMElHRXhMbXhsYm1kMGFDQTlQU0JoTkM1c1pXNW5kR2dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5Y21GNUwybHRiWFYwWVdKc1pWOXBibWwwTG5CNU9qazFDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNRjBnUFQwZ1lUUmJNRjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSnlZWGt2YVcxdGRYUmhZbXhsWDJsdWFYUXVjSGs2T1RZS0lDQWdJQzh2SUdGemMyVnlkQ0JoTVZzeFhTQTlQU0JoTkZzeFhRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEp5WVhrdmFXMXRkWFJoWW14bFgybHVhWFF1Y0hrNk9UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3lYU0E5UFNCaE5Gc3lYUW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGNuSmhlUzlwYlcxMWRHRmliR1ZmYVc1cGRDNXdlVG8zTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0RBQ1lCR0FBQUFBQUFBQUFCQUFBQUFBQUFBQUlBQUFBQUFBQUFBekViUVFBck1Sa1VSREVZUklJRUJJUTB1aW9FWTZxN29BVGJyd05PQktuUlJWUTJHZ0NPQkFBSkFBc0FEUUJaQURFWkZERVlGQkJESWtNaVF5aEhBaFVqQ2lRU1JFa2xXeUlTUkVralc0RUNFa1NCRUZza0VrUkhBaVZiSWhKRVNTTmJnUUlTUklFUVd5UVNSRWtWSXdva0VrUkpKVnNpRWtSSkkxdUJBaEpFZ1JCYkpCSkVJa01vUndJVkl3b2tFa1JKSlZzaUVrUkpJMXVCQWhKRWdSQmJKQkpFUndJbFd5SVNSRWtqVzRFQ0VrU0JFRnNrRWtSSkZTTUtKQkpFU1NWYkloSkVTU05iZ1FJU1JJRVFXeVFTUkNKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
