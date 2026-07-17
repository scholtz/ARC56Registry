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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.DynamicArrayInitContract_fcd0da68
{


    public class DynamicArrayInitContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DynamicArrayInitContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHluYW1pY0FycmF5SW5pdENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfaW1tdXRhYmxlX2FycmF5X2luaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9pbW11dGFibGVfYXJyYXlfaW5pdF93aXRob3V0X3R5cGVfZ2VuZXJpYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X3JlZmVyZW5jZV9hcnJheV9pbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcmVmZXJlbmNlX2FycmF5X2luaXRfd2l0aG91dF90eXBlX2dlbmVyaWMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEZ2dNeUF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESXdNREF3TURBd01EQXdNREF3TURBekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvME9EQUtJQ0FnSUM4dklHTnNZWE56SUVSNWJtRnRhV05CY25KaGVVbHVhWFJEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9EUXpOR0poTW1FZ01IZzJNMkZoWW1KaE1DQXdlR1JpWVdZd016UmxJREI0WVRsa01UUTFOVFFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBYMmx0YlhWMFlXSnNaVjloY25KaGVWOXBibWwwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFgybHRiWFYwWVdKc1pWOWhjbkpoZVY5cGJtbDBYM2RwZEdodmRYUmZkSGx3WlY5blpXNWxjbWxqS0NsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFgzSmxabVZ5Wlc1alpWOWhjbkpoZVY5cGJtbDBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wWDNKbFptVnlaVzVqWlY5aGNuSmhlVjlwYm1sMFgzZHBkR2h2ZFhSZmRIbHdaVjluWlc1bGNtbGpLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkR1Z6ZEY5cGJXMTFkR0ZpYkdWZllYSnlZWGxmYVc1cGRDQjBaWE4wWDJsdGJYVjBZV0pzWlY5aGNuSmhlVjlwYm1sMFgzZHBkR2h2ZFhSZmRIbHdaVjluWlc1bGNtbGpJSFJsYzNSZmNtVm1aWEpsYm1ObFgyRnljbUY1WDJsdWFYUWdkR1Z6ZEY5eVpXWmxjbVZ1WTJWZllYSnlZWGxmYVc1cGRGOTNhWFJvYjNWMFgzUjVjR1ZmWjJWdVpYSnBZd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11UVhKeVlYbHpMbWx0YlhWMFlXSnNaUzVFZVc1aGJXbGpRWEp5WVhsSmJtbDBRMjl1ZEhKaFkzUXVkR1Z6ZEY5cGJXMTFkR0ZpYkdWZllYSnlZWGxmYVc1cGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZmFXMXRkWFJoWW14bFgyRnljbUY1WDJsdWFYUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzBPREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtGeWNtRjVjeTVwYlcxMWRHRmliR1V1UkhsdVlXMXBZMEZ5Y21GNVNXNXBkRU52Ym5SeVlXTjBMblJsYzNSZmFXMXRkWFJoWW14bFgyRnljbUY1WDJsdWFYUmZkMmwwYUc5MWRGOTBlWEJsWDJkbGJtVnlhV05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMmx0YlhWMFlXSnNaVjloY25KaGVWOXBibWwwWDNkcGRHaHZkWFJmZEhsd1pWOW5aVzVsY21sak9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UQXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVCY25KaGVYTXVhVzF0ZFhSaFlteGxMa1I1Ym1GdGFXTkJjbkpoZVVsdWFYUkRiMjUwY21GamRDNTBaWE4wWDNKbFptVnlaVzVqWlY5aGNuSmhlVjlwYm1sMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5eVpXWmxjbVZ1WTJWZllYSnlZWGxmYVc1cGREb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXlOd29nSUNBZ0x5OGdZVEVnUFNCU1pXWmxjbVZ1WTJWQmNuSmhlVnRWU1c1ME5qUmRLQ2hWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1N3Z1ZVbHVkRFkwS0RNcEtTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNRE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmFXMXRkWFJoWW14bExuQjVPalV6TUFvZ0lDQWdMeThnWVhOelpYSjBJR0V4TG14bGJtZDBhQ0E5UFNCaE1pNXNaVzVuZEdnS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdMd29nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXpNUW9nSUNBZ0x5OGdZWE56WlhKMElHRXhXekJkSUQwOUlHRXlXekJkQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXpNZ29nSUNBZ0x5OGdZWE56WlhKMElHRXhXekZkSUQwOUlHRXlXekZkQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU16TUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3lYU0E5UFNCaE1sc3lYUW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXpOd29nSUNBZ0x5OGdZWE56WlhKMElHRXhXekJkSUQwOUlHRXpXekJkQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN4WFNBOVBTQmhNMXN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UTTVDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNbDBnUFQwZ1lUTmJNbDBLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UUXlDaUFnSUNBdkx5QmhjM05sY25RZ1lURXViR1Z1WjNSb0lEMDlJR0UwTG14bGJtZDBhQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTUYwZ1BUMGdZVFJiTUYwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTVYwZ1BUMGdZVFJiTVYwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVTBOUW9nSUNBZ0x5OGdZWE56WlhKMElHRXhXekpkSUQwOUlHRTBXekpkQ2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXlOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11UVhKeVlYbHpMbWx0YlhWMFlXSnNaUzVFZVc1aGJXbGpRWEp5WVhsSmJtbDBRMjl1ZEhKaFkzUXVkR1Z6ZEY5eVpXWmxjbVZ1WTJWZllYSnlZWGxmYVc1cGRGOTNhWFJvYjNWMFgzUjVjR1ZmWjJWdVpYSnBZMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZjbVZtWlhKbGJtTmxYMkZ5Y21GNVgybHVhWFJmZDJsMGFHOTFkRjkwZVhCbFgyZGxibVZ5YVdNNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU5Ea0tJQ0FnSUM4dklHRXhJRDBnVW1WbVpYSmxibU5sUVhKeVlYa29LRlZKYm5RMk5DZ3hLU3dnVlVsdWREWTBLRElwTENCVlNXNTBOalFvTXlrcEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5TURBd01EQXdNREF3TURBd01EQXdNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEV1YkdWdVozUm9JRDA5SUdFeUxteGxibWQwYUFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXZDaUFnSUNCcGJuUmpYeklnTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UVXpDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNRjBnUFQwZ1lUSmJNRjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UVTBDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNVjBnUFQwZ1lUSmJNVjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZhVzF0ZFhSaFlteGxMbkI1T2pVMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdFeFd6SmRJRDA5SUdFeVd6SmRDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UVTVDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNRjBnUFQwZ1lUTmJNRjBLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVTJNQW9nSUNBZ0x5OGdZWE56WlhKMElHRXhXekZkSUQwOUlHRXpXekZkQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU5qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3lYU0E5UFNCaE0xc3lYUW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU5qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1TNXNaVzVuZEdnZ1BUMGdZVFF1YkdWdVozUm9DaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQzhLSUNBZ0lHbHVkR05mTWlBdkx5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN3WFNBOVBTQmhORnN3WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN4WFNBOVBTQmhORnN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UWTNDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNbDBnUFQwZ1lUUmJNbDBLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UUTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFnREFDWUJHQUFBQUFBQUFBQUJBQUFBQUFBQUFBSUFBQUFBQUFBQUF6RWJRUUFyTVJrVVJERVlSSUlFQklRMHVpb0VZNnE3b0FUYnJ3Tk9CS25SUlZRMkdnQ09CQUFKQUFzQURRQlpBREVaRkRFWUZCQkRJa01pUXloSEFoVWpDaVFTUkVrbFd5SVNSRWtqVzRFQ0VrU0JFRnNrRWtSSEFpVmJJaEpFU1NOYmdRSVNSSUVRV3lRU1JFa1ZJd29rRWtSSkpWc2lFa1JKSTF1QkFoSkVnUkJiSkJKRUlrTW9Sd0lWSXdva0VrUkpKVnNpRWtSSkkxdUJBaEpFZ1JCYkpCSkVSd0lsV3lJU1JFa2pXNEVDRWtTQkVGc2tFa1JKRlNNS0pCSkVTU1ZiSWhKRVNTTmJnUUlTUklFUVd5UVNSQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
