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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAccountApp_d76d667e
{


    //
    // A contract that demonstrates how to reference accounts and applications
    //to access local state from external contracts
    //
    public class ReferenceAccountAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAccountAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Get the counter value from another account's local state with hardcoded values
        ///</summary>
        public async Task<ulong> GetMyCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 173, 112, 191 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 173, 112, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the counter value from another account's local state with provided parameters
        ///</summary>
        /// <param name="account">The account to check </param>
        /// <param name="app">The application to query </param>
        public async Task<ulong> GetMyCounterWithArg(Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 92, 68, 25 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMyCounterWithArg_Transactions(Algorand.Address account, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 92, 68, 25 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQWNjb3VudEFwcCIsImRlc2MiOiJBIGNvbnRyYWN0IHRoYXQgZGVtb25zdHJhdGVzIGhvdyB0byByZWZlcmVuY2UgYWNjb3VudHMgYW5kIGFwcGxpY2F0aW9uc1xudG8gYWNjZXNzIGxvY2FsIHN0YXRlIGZyb20gZXh0ZXJuYWwgY29udHJhY3RzIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE15Q291bnRlciIsImRlc2MiOiJHZXQgdGhlIGNvdW50ZXIgdmFsdWUgZnJvbSBhbm90aGVyIGFjY291bnQncyBsb2NhbCBzdGF0ZSB3aXRoIGhhcmRjb2RlZCB2YWx1ZXMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGNvdW50ZXIgdmFsdWUgb3IgMCBpZiBpdCBkb2Vzbid0IGV4aXN0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRNeUNvdW50ZXJXaXRoQXJnIiwiZGVzYyI6IkdldCB0aGUgY291bnRlciB2YWx1ZSBmcm9tIGFub3RoZXIgYWNjb3VudCdzIGxvY2FsIHN0YXRlIHdpdGggcHJvdmlkZWQgcGFyYW1ldGVycyIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBjaGVjayIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6IlRoZSBhcHBsaWNhdGlvbiB0byBxdWVyeSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgY291bnRlciB2YWx1ZSBvciAwIGlmIGl0IGRvZXNuJ3QgZXhpc3QifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKdGVWOWpiM1Z1ZEdWeUlpQXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCU1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhCd0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRGtLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T0RkaFpEY3dZbVlnTUhnMk1EVmpORFF4T1NBdkx5QnRaWFJvYjJRZ0ltZGxkRTE1UTI5MWJuUmxjaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSTmVVTnZkVzUwWlhKWGFYUm9RWEpuS0dGa1pISmxjM01zZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2RsZEUxNVEyOTFiblJsY2lCblpYUk5lVU52ZFc1MFpYSlhhWFJvUVhKbkNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5QlNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRnTHk4Z2IyNGdaWEp5YjNJNklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DZ29LTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzVuWlhSTmVVTnZkVzUwWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJOZVVOdmRXNTBaWEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCamIyNXpkQ0JoWkdSeVpYTnpRbmwwWlhNZ1BTQmhaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtGZE5TRVkwUmt4S1RrdFpNa0pRUmtzM1dWQldOVWxFTms5YU4weFdSRUl5UWpZMldsUllSVUZOVEV3eVRsZzBWMHBhVWtFcElDOHZJR0ZrWkhJZ1YwMUlSalJHVEVwT1Mxa3lRbEJHU3pkWlVGWTFTVVEyVDFvM1RGWkVRakpDTmpaYVZGaEZRVTFNVERKT1dEUlhTbHBTU2taV1dEWTJUUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3SUQwZ1FYQndiR2xqWVhScGIyNG9NVGN4TnlrZ0x5OGdVbVZ3YkdGalpTQjNhWFJvSUhsdmRYSWdZWEJ3YkdsallYUnBiMjRnYVdRS0lDQWdJSEIxYzJocGJuUWdNVGN4TnlBdkx5QXhOekUzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCamIyNXpkQ0JiZG1Gc2RXVXNJR2hoYzFaaGJIVmxYU0E5SUc5d0xrRndjRXh2WTJGc0xtZGxkRVY0VldsdWREWTBLR0ZqWTI5MWJuUXNJR0Z3Y0N3Z1FubDBaWE1vSjIxNVgyTnZkVzUwWlhJbktTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMTVYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VW1WbVpYSmxibU5sUVdOamIzVnVkRUZ3Y0M5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCcFppQW9JV2hoYzFaaGJIVmxLU0I3Q2lBZ0lDQmlibm9nWjJWMFRYbERiM1Z1ZEdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwblpYUk5lVU52ZFc1MFpYSmZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGd2NDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMbWRsZEUxNVEyOTFiblJsY2tBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUzAxTmdvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVFhsRGIzVnVkR1Z5S0NrNklIVnBiblEyTkNCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJOZVVOdmRXNTBaWEpmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxTFRVMkNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSTmVVTnZkVzUwWlhJb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdJZ1oyVjBUWGxEYjNWdWRHVnlYMkZtZEdWeVgybHViR2x1WldSZlkyOXVkSEpoWTNSekwxSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzVuWlhSTmVVTnZkVzUwWlhKQU5Bb0tDaTh2SUdOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhCd0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXVaMlYwVFhsRGIzVnVkR1Z5VjJsMGFFRnlaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFMTVRMjkxYm5SbGNsZHBkR2hCY21jNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVtVm1aWEpsYm1ObFFXTmpiM1Z1ZEVGd2NDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRMVGM1Q2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJOZVVOdmRXNTBaWEpYYVhSb1FYSm5LR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJR0Z3Y0RvZ1FYQndiR2xqWVhScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWTI5dWMzUWdXM1poYkhWbExDQm9ZWE5XWVd4MVpWMGdQU0J2Y0M1QmNIQk1iMk5oYkM1blpYUkZlRlZwYm5RMk5DaGhZMk52ZFc1MExDQmhjSEFzSUVKNWRHVnpLQ2R0ZVY5amIzVnVkR1Z5SnlrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdGVWOWpiM1Z1ZEdWeUlnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUpsWm1WeVpXNWpaVUZqWTI5MWJuUkJjSEF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnYVdZZ0tDRm9ZWE5XWVd4MVpTa2dld29nSUNBZ1ltNTZJR2RsZEUxNVEyOTFiblJsY2xkcGRHaEJjbWRmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbWRsZEUxNVEyOTFiblJsY2xkcGRHaEJjbWRmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZVbVZtWlhKbGJtTmxRV05qYjNWdWRFRndjQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWldabGNtVnVZMlZCWTJOdmRXNTBRWEJ3TG1kbGRFMTVRMjkxYm5SbGNsZHBkR2hCY21kQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVNaV1psY21WdVkyVkJZMk52ZFc1MFFYQndMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemd0TnprS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEUxNVEyOTFiblJsY2xkcGRHaEJjbWNvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWVhCd09pQkJjSEJzYVdOaGRHbHZiaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUk5lVU52ZFc1MFpYSlhhWFJvUVhKblgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFKbFptVnlaVzVqWlVGalkyOTFiblJCY0hBdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09DMDNPUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBUWGxEYjNWdWRHVnlWMmwwYUVGeVp5aGhZMk52ZFc1ME9pQkJZMk52ZFc1MExDQmhjSEE2SUVGd2NHeHBZMkYwYVc5dUtUb2dkV2x1ZERZMElIc0tJQ0FnSUdJZ1oyVjBUWGxEYjNWdWRHVnlWMmwwYUVGeVoxOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wY3k5U1pXWmxjbVZ1WTJWQlkyTnZkVzUwUVhCd0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxabVZ5Wlc1alpVRmpZMjkxYm5SQmNIQXVaMlYwVFhsRGIzVnVkR1Z5VjJsMGFFRnlaMEEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1BZ3B0ZVY5amIzVnVkR1Z5QkJVZmZIVXhHMEVBSFRFWkZFUXhHRVNDQWdTSHJYQy9CR0JjUkJrMkdnQ09BZ0FKQUQ4QU1Sa1VNUmdVRUVPQUlMTU9YaFZwYXJHZ3ZLcitIMTZnZm5aK3VvdzZENzJaM0lCaTE2YmZsazVpZ2JVTktHTkFBQWdpRmlsTVVMQWpRMGxDLy9VMkdnRTJHZ0lYS0dOQUFBZ2lGaWxNVUxBalEwbEMvL1U9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
