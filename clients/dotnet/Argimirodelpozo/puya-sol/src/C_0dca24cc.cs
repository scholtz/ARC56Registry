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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_0dca24cc
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task FillArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 191, 1, 153 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FillArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 191, 1, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PartialAssignArrayBeforeStorageBoundary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 71, 218, 74 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PartialAssignArrayBeforeStorageBoundary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 71, 218, 74 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PartialAssignArrayCrossStorageBoundary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 168, 113, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PartialAssignArrayCrossStorageBoundary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 168, 113, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClearArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 48, 144, 175 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 48, 144, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256[]> X(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 64, 20, 79 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> X_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 64, 20, 79 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmaWxsQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFydGlhbEFzc2lnbkFycmF5QmVmb3JlU3RvcmFnZUJvdW5kYXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhcnRpYWxBc3NpZ25BcnJheUNyb3NzU3RvcmFnZUJvdW5kYXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsZWFyQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoieCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2WzEwXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NywyNjAsMzc1LDUwNCw2MjVdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzNSdmNtRm5aUzl6ZEc5eVlXZGxYMkp2ZFc1a1lYSjVYMkZ5Y21GNVgyRnVaRjl3WVhKMGFXRnNYMkZ6YzJsbmJtMWxiblJmZDJsMGFGOXNZWGx2ZFhRdWMyOXNMa011WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VDQWlYMTlrZVc1ZmMzUnZjbUZuWlNJZ01IZ3dNU0FpWVNJZ01IZ3dNaUF3ZURBeklEQjRNRFFnTUhnd05TQXdlREEySURCNE1EY2dNSGd3T0NBd2VEQTVDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnY0hWemFHbHVkQ0EwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0J6ZEc5eVpTQTFDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3T0RBS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNbUppWmpBeE9Ua2dNSGc0WWpRM1pHRTBZU0F3ZURVMVlUZzNNVGRoSURCNE9UWXpNRGt3WVdZZ01IZ3paVFF3TVRRMFppQXZMeUJ0WlhSb2IyUWdJbVpwYkd4QmNuSmhlU2dwZG05cFpDSXNJRzFsZEdodlpDQWljR0Z5ZEdsaGJFRnpjMmxuYmtGeWNtRjVRbVZtYjNKbFUzUnZjbUZuWlVKdmRXNWtZWEo1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p3WVhKMGFXRnNRWE56YVdkdVFYSnlZWGxEY205emMxTjBiM0poWjJWQ2IzVnVaR0Z5ZVNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJ4bFlYSkJjbkpoZVNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZUNncGRXbHVkREkxTmxzeE1GMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyWnBiR3hCY25KaGVWOXliM1YwWlVBMUlHMWhhVzVmY0dGeWRHbGhiRUZ6YzJsbmJrRnljbUY1UW1WbWIzSmxVM1J2Y21GblpVSnZkVzVrWVhKNVgzSnZkWFJsUURZZ2JXRnBibDl3WVhKMGFXRnNRWE56YVdkdVFYSnlZWGxEY205emMxTjBiM0poWjJWQ2IzVnVaR0Z5ZVY5eWIzVjBaVUEzSUcxaGFXNWZZMnhsWVhKQmNuSmhlVjl5YjNWMFpVQTRJRzFoYVc1ZmVGOXliM1YwWlVBNUNpQWdJQ0JsY25JS0NtMWhhVzVmZUY5eWIzVjBaVUE1T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElETXlNQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR0p1ZWlCdFlXbHVYMlZzYzJWZlltOWtlVUEwTWdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0NtMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOWZYM0IxZVdGemIyeGZYMTl6ZEc5eVlXZGxYM0psWVdSQU5ETTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXeHpaVjlpYjJSNVFEUXlPZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlYMTlrZVc1ZmMzUnZjbUZuWlNJS0lDQWdJSEIxYzJocGJuUWdPREU1TWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpVMkNpQWdJQ0FsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZaSGx1WDNOMGIzSmhaMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOWZYM0IxZVdGemIyeGZYMTl6ZEc5eVlXZGxYM0psWVdSQU5ETUtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TlRvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TmdvS2JXRnBibDlqYkdWaGNrRnljbUY1WDNKdmRYUmxRRGc2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJd0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJeE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnNiMkZrSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ETUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TkFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQTFDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURZS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dOd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd09Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3T1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNakE2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakVLQ20xaGFXNWZjR0Z5ZEdsaGJFRnpjMmxuYmtGeWNtRjVRM0p2YzNOVGRHOXlZV2RsUW05MWJtUmhjbmxmY205MWRHVkFOem9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpZNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3daZ29nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE1Bb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TVFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd05Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hNZ29nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TlFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE13b2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TkFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd053b2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3T0FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dPUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qVTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qWUtDbTFoYVc1ZmNHRnlkR2xoYkVGemMybG5ia0Z5Y21GNVFtVm1iM0psVTNSdmNtRm5aVUp2ZFc1a1lYSjVYM0p2ZFhSbFFEWTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE13Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE14T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCc2IyRmtJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmlDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HTUtJQ0FnSUdOaGJHeHpkV0lnWDE5emRHOXlZV2RsWDNkeWFYUmxDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdRS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ETUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TkFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQTFDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURZS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dOd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd09Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3T1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNekE2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNekVLQ20xaGFXNWZabWxzYkVGeWNtRjVYM0p2ZFhSbFFEVTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE0xQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE0yT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCc2IyRmtJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlkWEo1SURJS0NtMWhhVzVmZDJocGJHVmZkRzl3UURNM09nb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmhDaUFnSUNCaVBBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBek9Rb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ01nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUF6TndvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBek9Ub0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TlRvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TmdvS0NpOHZJRjlmY0hWNVlYTnZiRjlmWDNOMGIzSmhaMlZmZDNKcGRHVW9YMTl6Ykc5ME9pQjFhVzUwTmpRc0lGOWZkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZlgzTjBiM0poWjJWZmQzSnBkR1U2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW01NklGOWZjM1J2Y21GblpWOTNjbWwwWlY5bGJITmxYMkp2WkhsQU1nb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3BmWDNOMGIzSmhaMlZmZDNKcGRHVmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmWDJSNWJsOXpkRzl5WVdkbElnb2dJQ0FnY0hWemFHbHVkQ0E0TVRreUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeU5UWUtJQ0FnSUNVS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOWZaSGx1WDNOMGIzSmhaMlVpQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmMzUnZjbUZuWlM5emRHOXlZV2RsWDJKdmRXNWtZWEo1WDJGeWNtRjVYMkZ1WkY5d1lYSjBhV0ZzWDJGemMybG5ibTFsYm5SZmQybDBhRjlzWVhsdmRYUXVjMjlzTGtNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVNBQUNDWU1BQTFmWDJSNWJsOXpkRzl5WVdkbEFRRUJZUUVDQVFNQkJBRUZBUVlCQndFSUFRa2tLSUdBSUs5Sk5RVTFBRFFBZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnRnhBTlFBeEdFQUFCU3NvWnlKRE1Sa1VSREVZUklJRkJDdS9BWmtFaTBmYVNnUlZxSEY2QkpZd2tLOEVQa0FVVHpZYUFJNEZBY3NCVWdEUkFGNEFBUUF4RmtFQVZERVdJZ2s0Q0JSRU5BQ0JHSzlMQVlGWVc0SEFBZ2dXVUZ4QU5RQTBBRFVBS0lFWVcwbEZBa0FBRmlPdksyUlFTUlVqQ1NOWWdBUVZIM3gxVEZDd0lrTXBnWUJBdVVoSmdZQUNHQ01MS1V3anVrTC80U1JDLzY0eEZrRUFhakVXSWdrNENCUkVOQUExQUNRbENTaE1XeWlJQVl3aUpRa3FTd0ZiS0lnQmdTY0VTd0ZiS0lnQmVDY0ZTd0ZiS0lnQmJ5Y0dTd0ZiS0lnQlppY0hTd0ZiS0lnQlhTY0lTd0ZiS0lnQlZDY0pTd0ZiS0lnQlN5Y0tTd0ZiS0lnQlFpY0xURnNvaUFFNklrTWtRditZTVJaQkFIZ3hGaUlKT0FnVVJEUUFOUUFrSlFrb1RGdUFBUTZJQVJjaUpRa3FTd0ZiZ0FFUGlBRUtKd1JMQVZ1QUFSQ0lBUDhuQlVzQlc0QUJFWWdBOUNjR1N3RmJnQUVTaUFEcEp3ZExBVnVBQVJPSUFONG5DRXNCVzRBQkZJZ0EweWNKU3dGYktJZ0F5aWNLU3dGYktJZ0F3U2NMVEZzb2lBQzVJa01rUXYrS01SWkJBSEF4RmlJSk9BZ1VSRFFBTlFBa0pRa29URnVBQVF1SUFKWWlKUWtxU3dGYmdBRU1pQUNKSndSTEFWdUFBUTJJQUg0bkJVc0JXeWlJQUhVbkJrc0JXeWlJQUd3bkIwc0JXeWlJQUdNbkNFc0JXeWlJQUZvbkNVc0JXeWlJQUZFbkNrc0JXeWlJQUVnbkMweGJLSWdBUUNKREpFTC9rakVXUVFBeE1SWWlDVGdJRkVRMEFEVUFJaFpGQWtzQmdBRUtwRUVBRmtzQlNSVWxDVXNCVEZ0TEFZZ0FEU3FnUlFKQy8rRWlReVJDLzlHS0FnQ0wva0FBRHlPdmkvOVFTUlVqQ1NOWUsweG5pU21CZ0VDNVNJditnWUFDR0NNTEk2K0wvMUJKRlNNSkkxZ3BUZ0s3aVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
