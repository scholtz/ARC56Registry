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

namespace Arc56.Generated.algorandfoundation.puya_ts.UrangeAlgo_13f52371
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVXJhbmdlQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0U2luZ2xlQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0VHdvQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0VGhyZWVBcmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODQsMTQ3LDE5N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdOUW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3TURBZ01IZ3dNREF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRYSmhibWRsTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWTJ4aGMzTWdWWEpoYm1kbFFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1ERXpNamxoTXpJZ01IaGxZVFl6WkRSaFl5QXdlR0ZrTW1VeFpqQmxJQzh2SUcxbGRHaHZaQ0FpZEdWemRGTnBibWRzWlVGeVp5Z3BkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJblJsYzNSVWQyOUJjbWNvS1hWcGJuUTJORnRkSWl3Z2JXVjBhRzlrSUNKMFpYTjBWR2h5WldWQmNtY29LWFZwYm5RMk5GdGRJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wVTJsdVoyeGxRWEpuWDNKdmRYUmxRRFFnYldGcGJsOTBaWE4wVkhkdlFYSm5YM0p2ZFhSbFFEVWdiV0ZwYmw5MFpYTjBWR2h5WldWQmNtZGZjbTkxZEdWQU5nb2dJQ0FnWlhKeUNncHRZV2x1WDNSbGMzUlVhSEpsWlVGeVoxOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWeVlXNW5aUzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJzWlhRZ2NtVnpkV3gwY3pvZ2RXbHVkRFkwVzEwZ1BTQmJYUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBS0lDQWdJR0oxY25rZ01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWeVlXNW5aUzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdrZ2IyWWdkWEpoYm1kbEtESXNJREV3TENBektTa2dld29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdKMWNua2dNUW9LYldGcGJsOW1iM0pmYUdWaFpHVnlRREUwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1Z5WVc1blpTNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2tnYjJZZ2RYSmhibWRsS0RJc0lERXdMQ0F6S1NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBeU5nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWeVlXNW5aUzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJ5WlhOMWJIUnpJRDBnV3k0dUxuSmxjM1ZzZEhNc0lHbGRDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWeVlXNW5aUzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdrZ2IyWWdkWEpoYm1kbEtESXNJREV3TENBektTa2dld29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnYldGcGJsOW1iM0pmYUdWaFpHVnlRREUwQ2dwdFlXbHVYMkZtZEdWeVgyWnZja0F5TmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QjBaWE4wVTJsdVoyeGxRWEpuS0NrZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBWSGR2UVhKblgzSnZkWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZFhKaGJtZGxMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR3hsZENCeVpYTjFiSFJ6T2lCMWFXNTBOalJiWFNBOUlGdGRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TUFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZFhKaGJtZGxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb01pd2dOU2twSUhzS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmlkWEo1SURFS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBeE9Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcElHOW1JSFZ5WVc1blpTZ3lMQ0ExS1NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTlFvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDltYjNKQU1qWUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnY21WemRXeDBjeUE5SUZzdUxpNXlaWE4xYkhSekxDQnBYUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWNtRnVaMlV1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcElHOW1JSFZ5WVc1blpTZ3lMQ0ExS1NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUJ0WVdsdVgyWnZjbDlvWldGa1pYSkFNVGtLQ20xaGFXNWZkR1Z6ZEZOcGJtZHNaVUZ5WjE5eWIzVjBaVUEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1Z5WVc1blpTNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHeGxkQ0J5WlhOMWJIUnpPaUIxYVc1ME5qUmJYU0E5SUZ0ZENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkWEpoYm1kbExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQnBJRzltSUhWeVlXNW5aU2cxS1NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01Rb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFESTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzVnlZVzVuWlM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FTQnZaaUIxY21GdVoyVW9OU2twSUhzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRFVLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURJMkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZFhKaGJtZGxMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdjbVZ6ZFd4MGN5QTlJRnN1TGk1eVpYTjFiSFJ6TENCcFhRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxY21GdVoyVXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2tnYjJZZ2RYSmhibWRsS0RVcEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0F5TkFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkWEpoYm1kbExtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nVlhKaGJtZGxRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0JTWUNBZ0FBQWdBQklvQUFNUnRCQU1neEdSUkVNUmhFZ2dNRUFUS2FNZ1RxWTlTc0JLMHVIdzQyR2dDT0F3QnpBRUVBQVFBb1JRSWtSUUZKZ1FvTVFRQW5Sd0lXS1V4UVNWY0NBRXdpV1VzRVNVNENJbGtJRmxjR0FGd0FURkJGQTRFRENFVUJRdi9TZ0FRVkgzeDFTd0pRc0NOREtFVUNKRVVCU1NVTVFmL29Sd0lXS1V4UVNWY0NBRXdpV1VzRVNVNENJbGtJRmxjR0FGd0FURkJGQXlNSVJRRkMvOVFvUlFJaVJRRkpKUXhCLzdaSEFoWXBURkJKVndJQVRDSlpTd1JKVGdJaVdRZ1dWd1lBWEFCTVVFVURJd2hGQVVMLzFERVpGREVZRkJCRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
