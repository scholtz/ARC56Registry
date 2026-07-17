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

namespace Arc56.Generated.algorandfoundation.puya_ts.DoLoopsAlgo_d8896726
{


    public class DoLoopsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DoLoopsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stop"> </param>
        public async Task<ulong> TestDo(ulong stop, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 35, 151, 146 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);

            var result = await base.CallApp(new List<object> { abiHandle, stopAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestDo_Transactions(ulong stop, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 35, 151, 146 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stop"> </param>
        /// <param name="breakMod"> </param>
        public async Task<ulong> TestDoBreak(ulong stop, ulong breakMod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 226, 235, 33 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var breakModAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); breakModAbi.From(breakMod);

            var result = await base.CallApp(new List<object> { abiHandle, stopAbi, breakModAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestDoBreak_Transactions(ulong stop, ulong breakMod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 226, 235, 33 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var breakModAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); breakModAbi.From(breakMod);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAbi, breakModAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stop"> </param>
        /// <param name="mod"> </param>
        public async Task<ulong> TestDoContinue(ulong stop, ulong mod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 232, 213, 22 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var modAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); modAbi.From(mod);

            var result = await base.CallApp(new List<object> { abiHandle, stopAbi, modAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestDoContinue_Transactions(ulong stop, ulong mod, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 232, 213, 22 };
            var stopAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAbi.From(stop);
            var modAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); modAbi.From(mod);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAbi, modAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRG9Mb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdERvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0RG9CcmVhayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJicmVha01vZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3REb0NvbnRpbnVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1vZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjksOTUsMTA0LDE1NCwxNjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUnZMV3h2YjNCekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVJ2VEc5dmNITkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pPVEl6T1RjNU1pQXdlR0ZqWlRKbFlqSXhJREI0TnpobE9HUTFNVFlnTHk4Z2JXVjBhRzlrSUNKMFpYTjBSRzhvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEVSdlFuSmxZV3NvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luUmxjM1JFYjBOdmJuUnBiblZsS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkR1Z6ZEVSdklIUmxjM1JFYjBKeVpXRnJJSFJsYzNSRWIwTnZiblJwYm5WbENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVSdlRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wkc4dGJHOXZjSE11WVd4bmJ5NTBjem82Ukc5TWIyOXdjMEZzWjI4dWRHVnpkRVJ2VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRVJ2T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdkR1Z6ZEVSdktITjBiM0E2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSdkxXeHZiM0J6TG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnYkdWMElHa2dQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDZ3AwWlhOMFJHOWZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaRzh0Ykc5dmNITXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QnBJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUgwZ2QyaHBiR1VnS0drZ1BDQnpkRzl3S1FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSnVlaUIwWlhOMFJHOWZkMmhwYkdWZmRHOXdRRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUmxjM1JFYnloemRHOXdPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pvNlJHOU1iMjl3YzBGc1oyOHVkR1Z6ZEVSdlFuSmxZV3RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBSRzlDY21WaGF6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCMFpYTjBSRzlDY21WaGF5aHpkRzl3T2lCMWFXNTBOalFzSUdKeVpXRnJUVzlrT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnNaWFFnZEc5MFlXd2dQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2JHVjBJR2tnUFNCVmFXNTBOalFvTUNrS0lDQWdJR1IxY0FvS2RHVnpkRVJ2UW5KbFlXdGZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaRzh0Ykc5dmNITXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdhV1lnS0drZ1BpQXdJQ1ltSUdrZ0pTQmljbVZoYTAxdlpDQTlQVDBnTUNrZ1luSmxZV3NLSUNBZ0lHUjFjQW9nSUNBZ1lub2dkR1Z6ZEVSdlFuSmxZV3RmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBbENpQWdJQ0JpZWlCMFpYTjBSRzlDY21WaGExOWliRzlqYTBBeE1Bb0tkR1Z6ZEVSdlFuSmxZV3RmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUnZMV3h2YjNCekxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHa2dLejBnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSdkxXeHZiM0J6TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUgwZ2QyaHBiR1VnS0drZ1BDQnpkRzl3S1FvZ0lDQWdaR2xuSURRS0lDQWdJRHdLSUNBZ0lHSnVlaUIwWlhOMFJHOUNjbVZoYTE5M2FHbHNaVjkwYjNCQU1nb0tkR1Z6ZEVSdlFuSmxZV3RmWW14dlkydEFNVEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaRzh0Ykc5dmNITXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkR1Z6ZEVSdlFuSmxZV3NvYzNSdmNEb2dkV2x1ZERZMExDQmljbVZoYTAxdlpEb2dkV2x1ZERZMEtTQjdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pwRWIweHZiM0J6UVd4bmJ5NTBaWE4wUkc5RGIyNTBhVzUxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JFYjBOdmJuUnBiblZsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSFJsYzNSRWIwTnZiblJwYm5WbEtITjBiM0E2SUhWcGJuUTJOQ3dnYlc5a09pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrYnkxc2IyOXdjeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJzWlhRZ2FTQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCc1pYUWdkRzkwWVd3Z1BTQlZhVzUwTmpRb01Da0tJQ0FnSUdSMWNBb0tkR1Z6ZEVSdlEyOXVkR2x1ZFdWZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2FXWWdLR2tnUGlBd0lDWW1JR2tnSlNCdGIyUWdQVDA5SURBcElIc0tJQ0FnSUdScFp5QXhDaUFnSUNCaWVpQjBaWE4wUkc5RGIyNTBhVzUxWlY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdKUW9nSUNBZ1ltNTZJSFJsYzNSRWIwTnZiblJwYm5WbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrYnkxc2IyOXdjeTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJwSUNzOUlERUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNncDBaWE4wUkc5RGIyNTBhVzUxWlY5aWJHOWphMEEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSDBnZDJocGJHVWdLR2tnUENCemRHOXdLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWJub2dkR1Z6ZEVSdlEyOXVkR2x1ZFdWZmQyaHBiR1ZmZEc5d1FESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCMFpYTjBSRzlEYjI1MGFXNTFaU2h6ZEc5d09pQjFhVzUwTmpRc0lHMXZaRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25SbGMzUkViME52Ym5ScGJuVmxYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QnBJQ3M5SURFS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F5Q2lBZ0lDQmlJSFJsYzNSRWIwTnZiblJwYm5WbFgySnNiMk5yUURjSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUWdBSmdFRUZSOThkVEViUVFBa01Sa1VSREVZUklJREJEa2psNUlFck9McklRUjQ2TlVXTmhvQWpnTUFDUUFqQUY0QU1Sa1VNUmdVRUVNMkdnRkpGU01TUkJja0lnaEpTd0lNUVAvM0ZpaE1VTEFpUXpZYUFVa1ZJeEpFRnpZYUFra1ZJeEpFRnlSSlNVRUFCMGxMQXhoQkFCTkpJZ2hKUlFKTEFrc0JDRVVEU3dRTVFQL2lTd0VXS0V4UXNDSkROaG9CU1JVakVrUVhOaG9DU1JVakVrUVhKRWxMQVVFQUpFc0JTd01ZUUFBY1NZRUNDRVVCU3dFaUNFVUNTd0ZMQkF4QS85OUpGaWhNVUxBaVEwa2lDRVVCU3dFaUNFVUNRdi9pIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
