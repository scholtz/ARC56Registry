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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_15f46de6
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmaWxsQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoieCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2WzEwXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXJ0aWFsQXNzaWduQXJyYXlCZWZvcmVTdG9yYWdlQm91bmRhcnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFydGlhbEFzc2lnbkFycmF5Q3Jvc3NTdG9yYWdlQm91bmRhcnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxODUsMjc5LDM2NSw0MjldLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzNSdmNtRm5aUzl6ZEc5eVlXZGxYMkp2ZFc1a1lYSjVYMkZ5Y21GNVgzQmhjblJwWVd4ZllYTnphV2R1YldWdWRDNXpiMnd1UXk1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUNBek1pQXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhNU0F4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TWlBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE15QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhOQ0F4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TlFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUNBaVgxOWtlVzVmYzNSdmNtRm5aU0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNbUppWmpBeE9Ua2dNSGd6WlRRd01UUTBaaUF3ZURoaU5EZGtZVFJoSURCNE5UVmhPRGN4TjJFZ0x5OGdiV1YwYUc5a0lDSm1hV3hzUVhKeVlYa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0luZ29LWFZwYm5ReU5UWmJNVEJkSWl3Z2JXVjBhRzlrSUNKd1lYSjBhV0ZzUVhOemFXZHVRWEp5WVhsQ1pXWnZjbVZUZEc5eVlXZGxRbTkxYm1SaGNua29LWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhjblJwWVd4QmMzTnBaMjVCY25KaGVVTnliM056VTNSdmNtRm5aVUp2ZFc1a1lYSjVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5bWFXeHNRWEp5WVhsZmNtOTFkR1ZBTlNCdFlXbHVYM2hmY205MWRHVkFOaUJ0WVdsdVgzQmhjblJwWVd4QmMzTnBaMjVCY25KaGVVSmxabTl5WlZOMGIzSmhaMlZDYjNWdVpHRnllVjl5YjNWMFpVQTNJRzFoYVc1ZmNHRnlkR2xoYkVGemMybG5ia0Z5Y21GNVEzSnZjM05UZEc5eVlXZGxRbTkxYm1SaGNubGZjbTkxZEdWQU9Bb2dJQ0FnWlhKeUNncHRZV2x1WDNCaGNuUnBZV3hCYzNOcFoyNUJjbkpoZVVOeWIzTnpVM1J2Y21GblpVSnZkVzVrWVhKNVgzSnZkWFJsUURnNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHbHVkR05mTXlBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR0lLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJqQ2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdhVzUwWXlBMUlDOHZJREU0TkRRMk56UTBNRGN6TnpBNU5UVXhOakV6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WkFvZ0lDQWdZMkZzYkhOMVlpQmZYM04wYjNKaFoyVmZkM0pwZEdVS0lDQWdJR2x1ZEdNZ05pQXZMeUF4T0RRME5qYzBOREEzTXpjd09UVTFNVFl4TkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdVS0lDQWdJR05oYkd4emRXSWdYMTl6ZEc5eVlXZGxYM2R5YVhSbENpQWdJQ0JwYm5SaklEY2dMeThnTVRnME5EWTNORFF3TnpNM01EazFOVEUyTVRVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCbUNpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFd0NpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFeENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUxQ2dwdFlXbHVYM0JoY25ScFlXeEJjM05wWjI1QmNuSmhlVUpsWm05eVpWTjBiM0poWjJWQ2IzVnVaR0Z5ZVY5eWIzVjBaVUEzT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCcGJuUmpYek1nTHk4Z01UZzBORFkzTkRRd056TTNNRGsxTlRFMk1URUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2FXNTBZeUEwSUM4dklERTRORFEyTnpRME1EY3pOekE1TlRVeE5qRXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOZ29nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHbHVkR01nTlNBdkx5QXhPRFEwTmpjME5EQTNNemN3T1RVMU1UWXhNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVGNLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqSURZZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqSURjZ0x5OGdNVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTmhiR3h6ZFdJZ1gxOXpkRzl5WVdkbFgzZHlhWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTjBiM0poWjJWZmQzSnBkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqWVd4c2MzVmlJRjlmYzNSdmNtRm5aVjkzY21sMFpRb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlGOWZjM1J2Y21GblpWOTNjbWwwWlFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCallXeHNjM1ZpSUY5ZmMzUnZjbUZuWlY5M2NtbDBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFNU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJd0NncHRZV2x1WDNoZmNtOTFkR1ZBTmpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qVTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXpNakFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOWtlVzVmYzNSdmNtRm5aU0lLSUNBZ0lIQjFjMmhwYm5RZ09ERTVNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyUjVibDl6ZEc5eVlXZGxJZ29nSUNBZ2NIVnphR2x1ZENBNE1ETXlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlORG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LYldGcGJsOW1hV3hzUVhKeVlYbGZjbTkxZEdWQU5Ub0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNamtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNekE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjFjbmtnTVFvS2JXRnBibDkzYUdsc1pWOTBiM0JBTXpFNkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0JpUEFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5M2FHbHNaVUF6TXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWWdvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWWlzS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJmWDNOMGIzSmhaMlZmZDNKcGRHVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhDaUFnSUNCaUt3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURNeENncHRZV2x1WDJGbWRHVnlYM2RvYVd4bFFETXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNd0Nnb0tMeThnWDE5d2RYbGhjMjlzWDE5ZmMzUnZjbUZuWlY5M2NtbDBaU2hmWDNOc2IzUTZJSFZwYm5RMk5Dd2dYMTkyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOWZjM1J2Y21GblpWOTNjbWwwWlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYMTlrZVc1ZmMzUnZjbUZuWlNJS0lDQWdJSEIxYzJocGJuUWdPREU1TWdvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTWpVMkNpQWdJQ0FsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyUjVibDl6ZEc5eVlXZGxJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzNSdmNtRm5aUzl6ZEc5eVlXZGxYMkp2ZFc1a1lYSjVYMkZ5Y21GNVgzQmhjblJwWVd4ZllYTnphV2R1YldWdWRDNXpiMnd1UXk1amJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUlBUUFnKy8vLy8vLy8vLy8vQWZ6Ly8vLy8vLy8vL3dIOS8vLy8vLy8vLy84Qi92Ly8vLy8vLy8vL0FmLy8vLy8vLy8vLy93RW1BZ0FOWDE5a2VXNWZjM1J2Y21GblpTT0JnQ0N2U1RVRk5RQTBBSUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQmNRRFVBTVJoQUFBSWlRekVaRkVReEdFU0NCQVFydndHWkJENUFGRThFaTBmYVNnUlZxSEY2TmhvQWpnUUE5UUMxQUY4QUFRQXhGa0VBVlRFV0lnazRDQlJFTkFBMUFDV0FBUXVJQVRzaEJJQUJESWdCTXlFRmdBRU5pQUVySVFhQUFRNklBU01oQjRBQkQ0Z0JHeU9BQVJDSUFSUWlnQUVSaUFFTmdRSW9pQUVIZ1FNb2lBRUJnUVFvaUFEN0lrTWpRdit0TVJaQkFFMHhGaUlKT0FnVVJEUUFOUUFsZ0FFVmlBRGRJUVNBQVJhSUFOVWhCWUFCRjRnQXpTRUdLSWdBeHlFSEtJZ0F3U01vaUFDOElpaUlBTGVCQWlpSUFMR0JBeWlJQUt1QkJDaUlBS1VpUXlOQy83VXhGa0VBTnpFV0lnazRDQlJFTkFDQkdLOUxBWUZZVzRIQUFnZ1dVRnhBTlFBMEFEVUFLWUdBUUxsSUtZSGdQaVM2Z0FRVkgzeDFURkN3SWtNalF2L0xNUlpCQUZZeEZpSUpPQWdVUkRRQU5RQWlGa1VCU1lBQkNxUkJBRHlBSVAvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLzdTd0ZKVGdLZ1NSV0JDQWxiU3dHSUFBK0FBUUdnUlFGQy83d2lReU5DLzZ5S0FnQXBnWUJBdVVpTC9vR0FBaGdrQ3lTdmkvOVFTUlVrQ1NSWUtVNEN1NGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
