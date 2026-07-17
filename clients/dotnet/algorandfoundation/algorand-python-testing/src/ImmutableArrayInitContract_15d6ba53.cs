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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.ImmutableArrayInitContract_15d6ba53
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW1tdXRhYmxlQXJyYXlJbml0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9pbW11dGFibGVfYXJyYXlfaW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2ltbXV0YWJsZV9hcnJheV9pbml0X3dpdGhvdXRfdHlwZV9nZW5lcmljIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcmVmZXJlbmNlX2FycmF5X2luaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9yZWZlcmVuY2VfYXJyYXlfaW5pdF93aXRob3V0X3R5cGVfZ2VuZXJpYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURNZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwybHRiWFYwWVdKc1pTNXdlVG8wTnprS0lDQWdJQzh2SUdOc1lYTnpJRWx0YlhWMFlXSnNaVUZ5Y21GNVNXNXBkRU52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEZzBNelJpWVRKaElEQjROak5oWVdKaVlUQWdNSGhrWW1GbU1ETTBaU0F3ZUdFNVpERTBOVFUwSUM4dklHMWxkR2h2WkNBaWRHVnpkRjlwYlcxMWRHRmliR1ZmWVhKeVlYbGZhVzVwZENncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOXBiVzExZEdGaWJHVmZZWEp5WVhsZmFXNXBkRjkzYVhSb2IzVjBYM1I1Y0dWZloyVnVaWEpwWXlncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOXlaV1psY21WdVkyVmZZWEp5WVhsZmFXNXBkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEY5eVpXWmxjbVZ1WTJWZllYSnlZWGxmYVc1cGRGOTNhWFJvYjNWMFgzUjVjR1ZmWjJWdVpYSnBZeWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSFJsYzNSZmFXMXRkWFJoWW14bFgyRnljbUY1WDJsdWFYUWdkR1Z6ZEY5cGJXMTFkR0ZpYkdWZllYSnlZWGxmYVc1cGRGOTNhWFJvYjNWMFgzUjVjR1ZmWjJWdVpYSnBZeUIwWlhOMFgzSmxabVZ5Wlc1alpWOWhjbkpoZVY5cGJtbDBJSFJsYzNSZmNtVm1aWEpsYm1ObFgyRnljbUY1WDJsdWFYUmZkMmwwYUc5MWRGOTBlWEJsWDJkbGJtVnlhV01LSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVJQzh2SUc5dUlHVnljbTl5T2lCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVCY25KaGVYTXVhVzF0ZFhSaFlteGxMa2x0YlhWMFlXSnNaVUZ5Y21GNVNXNXBkRU52Ym5SeVlXTjBMblJsYzNSZmFXMXRkWFJoWW14bFgyRnljbUY1WDJsdWFYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgybHRiWFYwWVdKc1pWOWhjbkpoZVY5cGJtbDBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZORGt3Q2lBZ0lDQXZMeUJoTXlBOUlFbHRiWFYwWVdKc1pVRnljbUY1VzFWSmJuUTJORjBvVW1WbVpYSmxibU5sUVhKeVlYa29LRlZKYm5RMk5DZ3hLU3dnVlVsdWREWTBLRElwTENCVlNXNTBOalFvTXlrcEtTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNRE1LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZORGd3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNuSmhlWE11YVcxdGRYUmhZbXhsTGtsdGJYVjBZV0pzWlVGeWNtRjVTVzVwZEVOdmJuUnlZV04wTG5SbGMzUmZhVzF0ZFhSaFlteGxYMkZ5Y21GNVgybHVhWFJmZDJsMGFHOTFkRjkwZVhCbFgyZGxibVZ5YVdOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJsdGJYVjBZV0pzWlY5aGNuSmhlVjlwYm1sMFgzZHBkR2h2ZFhSZmRIbHdaVjluWlc1bGNtbGpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVEV5Q2lBZ0lDQXZMeUJoTXlBOUlFbHRiWFYwWVdKc1pVRnljbUY1S0ZKbFptVnlaVzVqWlVGeWNtRjVLQ2hWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1N3Z1ZVbHVkRFkwS0RNcEtTa3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmFXMXRkWFJoWW14bExuQjVPalV3TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVFYSnlZWGx6TG1sdGJYVjBZV0pzWlM1SmJXMTFkR0ZpYkdWQmNuSmhlVWx1YVhSRGIyNTBjbUZqZEM1MFpYTjBYM0psWm1WeVpXNWpaVjloY25KaGVWOXBibWwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjl5WldabGNtVnVZMlZmWVhKeVlYbGZhVzVwZERvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZhVzF0ZFhSaFlteGxMbkI1T2pVeU5nb2dJQ0FnTHk4Z1lURWdQU0JTWldabGNtVnVZMlZCY25KaGVWdFZTVzUwTmpSZEtDaFZTVzUwTmpRb01Ta3NJRlZKYm5RMk5DZ3lLU3dnVlVsdWREWTBLRE1wS1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNakF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXlPQW9nSUNBZ0x5OGdZVElnUFNCU1pXWmxjbVZ1WTJWQmNuSmhlVnRWU1c1ME5qUmRLRVpwZUdWa1FYSnlZWGtvS0ZWSmJuUTJOQ2d4S1N3Z1ZVbHVkRFkwS0RJcExDQlZTVzUwTmpRb015a3BLU2tLSUNBZ0lHUjFjQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmFXMXRkWFJoWW14bExuQjVPalV5T1FvZ0lDQWdMeThnWVhOelpYSjBJR0V4TG14bGJtZDBhQ0E5UFNCaE1pNXNaVzVuZEdnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdsdWRHTmZNU0F2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3dYU0E5UFNCaE1sc3dYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU16RUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1Wc3hYU0E5UFNCaE1sc3hYUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN5WFNBOVBTQmhNbHN5WFFvZ0lDQWdjSFZ6YUdsdWRDQXhOaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU16UUtJQ0FnSUM4dklHRXpJRDBnVW1WbVpYSmxibU5sUVhKeVlYbGJWVWx1ZERZMFhTaEpiVzExZEdGaWJHVkJjbkpoZVNnb1ZVbHVkRFkwS0RFcExDQlZTVzUwTmpRb01pa3NJRlZKYm5RMk5DZ3pLU2twS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXlNREF3TURBd01EQXdNREF3TURBd013b2dJQ0FnY0c5d0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVXpOZ29nSUNBZ0x5OGdZWE56WlhKMElHRXhXekJkSUQwOUlHRXpXekJkQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhNVnN4WFNBOVBTQmhNMXN4WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwybHRiWFYwWVdKc1pTNXdlVG8xTXpnS0lDQWdJQzh2SUdGemMyVnlkQ0JoTVZzeVhTQTlQU0JoTTFzeVhRb2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDJsdGJYVjBZV0pzWlM1d2VUbzFNallLSUNBZ0lDOHZJR0V4SUQwZ1VtVm1aWEpsYm1ObFFYSnlZWGxiVlVsdWREWTBYU2dvVlVsdWREWTBLREVwTENCVlNXNTBOalFvTWlrc0lGVkpiblEyTkNnektTa3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01qQXdNREF3TURBd01EQXdNREF3TURNS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXBiVzExZEdGaWJHVXVjSGs2TlRReENpQWdJQ0F2THlCaGMzTmxjblFnWVRFdWJHVnVaM1JvSUQwOUlHRTBMbXhsYm1kMGFBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXZDaUFnSUNCcGJuUmpYekVnTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UUXlDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNRjBnUFQwZ1lUUmJNRjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UUXpDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNVjBnUFQwZ1lUUmJNVjBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTWwwZ1BUMGdZVFJiTWwwS0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z013b2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZhVzF0ZFhSaFlteGxMbkI1T2pVeU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVCY25KaGVYTXVhVzF0ZFhSaFlteGxMa2x0YlhWMFlXSnNaVUZ5Y21GNVNXNXBkRU52Ym5SeVlXTjBMblJsYzNSZmNtVm1aWEpsYm1ObFgyRnljbUY1WDJsdWFYUmZkMmwwYUc5MWRGOTBlWEJsWDJkbGJtVnlhV05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYM0psWm1WeVpXNWpaVjloY25KaGVWOXBibWwwWDNkcGRHaHZkWFJmZEhsd1pWOW5aVzVsY21sak9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UUTRDaUFnSUNBdkx5QmhNU0E5SUZKbFptVnlaVzVqWlVGeWNtRjVLQ2hWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1N3Z1ZVbHVkRFkwS0RNcEtTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNRE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmFXMXRkWFJoWW14bExuQjVPalUxTUFvZ0lDQWdMeThnWVRJZ1BTQlNaV1psY21WdVkyVkJjbkpoZVNoR2FYaGxaRUZ5Y21GNUtDaFZTVzUwTmpRb01Ta3NJRlZKYm5RMk5DZ3lLU3dnVlVsdWREWTBLRE1wS1NrcENpQWdJQ0JrZFhBS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMMmx0YlhWMFlXSnNaUzV3ZVRvMU5URUtJQ0FnSUM4dklHRnpjMlZ5ZENCaE1TNXNaVzVuZEdnZ1BUMGdZVEl1YkdWdVozUm9DaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0F2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTUYwZ1BUMGdZVEpiTUYwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEZiTVYwZ1BUMGdZVEpiTVYwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXBiVzExZEdGaWJHVXVjSGs2TlRVMENpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1sMGdQVDBnWVRKYk1sMEtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFUyQ2lBZ0lDQXZMeUJoTXlBOUlGSmxabVZ5Wlc1alpVRnljbUY1S0VsdGJYVjBZV0pzWlVGeWNtRjVLQ2hWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1N3Z1ZVbHVkRFkwS0RNcEtTa3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6Q2lBZ0lDQndiM0FLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXBiVzExZEdGaWJHVXVjSGs2TlRVNENpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1GMGdQVDBnWVROYk1GMEtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZhVzF0ZFhSaFlteGxMbkI1T2pVMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdFeFd6RmRJRDA5SUdFeld6RmRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YVcxdGRYUmhZbXhsTG5CNU9qVTJNQW9nSUNBZ0x5OGdZWE56WlhKMElHRXhXekpkSUQwOUlHRXpXekpkQ2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZhVzF0ZFhSaFlteGxMbkI1T2pVME9Bb2dJQ0FnTHk4Z1lURWdQU0JTWldabGNtVnVZMlZCY25KaGVTZ29WVWx1ZERZMEtERXBMQ0JWU1c1ME5qUW9NaWtzSUZWSmJuUTJOQ2d6S1NrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREl3TURBd01EQXdNREF3TURBd01EQXpDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWpBd01EQXdNREF3TURBd01EQXdNRE1LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5cGJXMTFkR0ZpYkdVdWNIazZOVFl6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVEV1YkdWdVozUm9JRDA5SUdFMExteGxibWQwYUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBdkNpQWdJQ0JwYm5Salh6RWdMeThnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXBiVzExZEdGaWJHVXVjSGs2TlRZMENpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1GMGdQVDBnWVRSYk1GMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXBiVzExZEdGaWJHVXVjSGs2TlRZMUNpQWdJQ0F2THlCaGMzTmxjblFnWVRGYk1WMGdQVDBnWVRSYk1WMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTlwYlcxMWRHRmliR1V1Y0hrNk5UWTJDaUFnSUNBdkx5QmhjM05sY25RZ1lURmJNbDBnUFQwZ1lUUmJNbDBLSUNBZ0lIQjFjMmhwYm5RZ01UWWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTXdvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmFXMXRkWFJoWW14bExuQjVPalUwTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQ0FNQkFDWUJHQUFBQUFBQUFBQUJBQUFBQUFBQUFBSUFBQUFBQUFBQUF6RWJRUUFyTVJrVVJERVlSSUlFQklRMHVpb0VZNnE3b0FUYnJ3Tk9CS25SUlZRMkdnQ09CQUFKQUEwQUVRQmpBREVaRkRFWUZCQkRLRWdrUXloSUpFTW9TVWhIQWhVaUNpTVNSRWtsV3lRU1JFa2lXNEVDRWtTQkVGc2pFa1FvU0VjQ0pWc2tFa1JKSWx1QkFoSkVnUkJiSXhKRUtFZ29TRWtWSWdvakVrUkpKVnNrRWtSSklsdUJBaEpFZ1JCYkl4SkRLRWxJUndJVklnb2pFa1JKSlZza0VrUkpJbHVCQWhKRWdSQmJJeEpFS0VoSEFpVmJKQkpFU1NKYmdRSVNSSUVRV3lNU1JDaElLRWhKRlNJS0l4SkVTU1ZiSkJKRVNTSmJnUUlTUklFUVd5TVNRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
