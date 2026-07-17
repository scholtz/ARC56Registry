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

namespace Arc56.Generated.algorandfoundation.puya_ts.UrangeAlgo_9de068e4
{


    public class UrangeAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UrangeAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> TestSingleArg(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 50, 154, 50 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> TestSingleArg_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 50, 154, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> TestTwoArg(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 99, 212, 172 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> TestTwoArg_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 99, 212, 172 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> TestThreeArg(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 46, 31, 14 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> TestThreeArg_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 46, 31, 14 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVXJhbmdlQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0U2luZ2xlQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0VHdvQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0VGhyZWVBcmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODksMTQyLDE5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEVWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3TURBZ01IZ3dNREF4SURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmpiR0Z6Y3lCVmNtRnVaMlZCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TVRNeU9XRXpNaUF3ZUdWaE5qTmtOR0ZqSURCNFlXUXlaVEZtTUdVZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVTJsdVoyeGxRWEpuS0NsMWFXNTBOalJiWFNJc0lHMWxkR2h2WkNBaWRHVnpkRlIzYjBGeVp5Z3BkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJblJsYzNSVWFISmxaVUZ5WnlncGRXbHVkRFkwVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjBaWE4wVTJsdVoyeGxRWEpuSUhSbGMzUlVkMjlCY21jZ2RHVnpkRlJvY21WbFFYSm5DaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWeVlXNW5aUzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR05zWVhOeklGVnlZVzVuWlVGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem82VlhKaGJtZGxRV3huYnk1MFpYTjBVMmx1WjJ4bFFYSm5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGTnBibWRzWlVGeVp6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJzWlhRZ2NtVnpkV3gwY3pvZ2RXbHVkRFkwVzEwZ1BTQmJYUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2tnYjJZZ2RYSmhibWRsS0RVcEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tkR1Z6ZEZOcGJtZHNaVUZ5WjE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRYSmhibWRsTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcElHOW1JSFZ5WVc1blpTZzFLU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOUW9nSUNBZ1BBb2dJQ0FnWW5vZ2RHVnpkRk5wYm1kc1pVRnlaMTloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1Z5WVc1blpTNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklISmxjM1ZzZEhNZ1BTQmJMaTR1Y21WemRXeDBjeXdnYVYwS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkWEpoYm1kbExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQnBJRzltSUhWeVlXNW5aU2cxS1NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFUybHVaMnhsUVhKblgyWnZjbDlvWldGa1pYSkFNZ29LZEdWemRGTnBibWRzWlVGeVoxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTFjbUZ1WjJVdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCMFpYTjBVMmx1WjJ4bFFYSm5LQ2tnZXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkWEpoYm1kbExtRnNaMjh1ZEhNNk9sVnlZVzVuWlVGc1oyOHVkR1Z6ZEZSM2IwRnlaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUlVkMjlCY21jNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZFhKaGJtZGxMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR3hsZENCeVpYTjFiSFJ6T2lCMWFXNTBOalJiWFNBOUlGdGRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1Z5WVc1blpTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2tnYjJZZ2RYSmhibWRsS0RJc0lEVXBLU0I3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29LZEdWemRGUjNiMEZ5WjE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRYSmhibWRsTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FTQnZaaUIxY21GdVoyVW9NaXdnTlNrcElIc0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURVS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSVWQyOUJjbWRmWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjbVZ6ZFd4MGN5QTlJRnN1TGk1eVpYTjFiSFJ6TENCcFhRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwSUc5bUlIVnlZVzVuWlNneUxDQTFLU2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQjBaWE4wVkhkdlFYSm5YMlp2Y2w5b1pXRmtaWEpBTWdvS2RHVnpkRlIzYjBGeVoxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTFjbUZ1WjJVdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2RHVnpkRlIzYjBGeVp5Z3BJSHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzVnlZVzVuWlM1aGJHZHZMblJ6T2pwVmNtRnVaMlZCYkdkdkxuUmxjM1JVYUhKbFpVRnlaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUlVhSEpsWlVGeVp6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnYkdWMElISmxjM1ZzZEhNNklIVnBiblEyTkZ0ZElEMGdXMTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZFhKaGJtZGxMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb01pd2dNVEFzSURNcEtTQjdDaUFnSUNCcGJuUmpYek1nTHk4Z01nb0tkR1Z6ZEZSb2NtVmxRWEpuWDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcElHOW1JSFZ5WVc1blpTZ3lMQ0F4TUN3Z015a3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGUm9jbVZsUVhKblgyRm1kR1Z5WDJadmNrQTFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRYSmhibWRsTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhKbGMzVnNkSE1nUFNCYkxpNHVjbVZ6ZFd4MGN5d2dhVjBLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01ERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRYSmhibWRsTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FTQnZaaUIxY21GdVoyVW9NaXdnTVRBc0lETXBLU0I3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCMFpYTjBWR2h5WldWQmNtZGZabTl5WDJobFlXUmxja0F5Q2dwMFpYTjBWR2h5WldWQmNtZGZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkWEpoYm1kbExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIUmxjM1JVYUhKbFpVRnlaeWdwSUhzS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFRkFpWURBZ0FBQWdBQkJCVWZmSFV4RzBFQUpERVpGRVF4R0VTQ0F3UUJNcG95Qk9wajFLd0VyUzRmRGpZYUFJNERBQWtBUGdCekFERVpGREVZRkJCREtDSkpKQXhCQUNaSEFoWXBURkJKVndJQVRDSlpTd1JKVGdJaVdRZ1dWd1lBWEFCTVVFVURJd2hGQVVMLzFDcExBbEN3STBNb0pVa2tERUVBSmtjQ0ZpbE1VRWxYQWdCTUlsbExCRWxPQWlKWkNCWlhCZ0JjQUV4UVJRTWpDRVVCUXYvVUtrc0NVTEFqUXlnbFNZRUtERUVBSjBjQ0ZpbE1VRWxYQWdCTUlsbExCRWxPQWlKWkNCWlhCZ0JjQUV4UVJRT0JBd2hGQVVMLzBpcExBbEN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
