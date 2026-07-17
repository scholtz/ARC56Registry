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

namespace Arc56.Generated.algorandfoundation.puya_ts.DoLoopsAlgo_df701176
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRG9Mb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdERvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0RG9CcmVhayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJicmVha01vZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3REb0NvbnRpbnVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3AiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1vZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjUsNzYsMTQ4LDE1OSwyMTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJFYjB4dmIzQnpRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNemt5TXprM09USWdNSGhoWTJVeVpXSXlNU0F3ZURjNFpUaGtOVEUySUM4dklHMWxkR2h2WkNBaWRHVnpkRVJ2S0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSRWIwSnlaV0ZyS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBaWE4wUkc5RGIyNTBhVzUxWlNoMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRVJ2WDNKdmRYUmxRRFFnYldGcGJsOTBaWE4wUkc5Q2NtVmhhMTl5YjNWMFpVQTFJRzFoYVc1ZmRHVnpkRVJ2UTI5dWRHbHVkV1ZmY205MWRHVkFOZ29nSUNBZ1pYSnlDZ3B0WVdsdVgzUmxjM1JFYjBOdmJuUnBiblZsWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaRzh0Ykc5dmNITXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR1Z6ZEVSdlEyOXVkR2x1ZFdVb2MzUnZjRG9nZFdsdWREWTBMQ0J0YjJRNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0F5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCc1pYUWdhU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlJ2TFd4dmIzQnpMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJR3hsZENCMGIzUmhiQ0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTVFvS2JXRnBibDkzYUdsc1pWOTBiM0JBTVRRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wkc4dGJHOXZjSE11WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnYVdZZ0tHa2dQaUF3SUNZbUlHa2dKU0J0YjJRZ1BUMDlJREFwSUhzS0lDQWdJR1JwWnlBekNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ0pRb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUnZMV3h2YjNCekxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlESUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QnBJQ3M5SURFS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0EwQ2dwdFlXbHVYMkpzYjJOclFERTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyUnZMV3h2YjNCekxtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIMGdkMmhwYkdVZ0tHa2dQQ0J6ZEc5d0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpYm5vZ2JXRnBibDkzYUdsc1pWOTBiM0JBTVRRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrYnkxc2IyOXdjeTVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUIwWlhOMFJHOURiMjUwYVc1MVpTaHpkRzl3T2lCMWFXNTBOalFzSUcxdlpEb2dkV2x1ZERZMEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrYnkxc2IyOXdjeTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCcElDczlJREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNVGdLQ20xaGFXNWZkR1Z6ZEVSdlFuSmxZV3RmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QjBaWE4wUkc5Q2NtVmhheWh6ZEc5d09pQjFhVzUwTmpRc0lHSnlaV0ZyVFc5a09pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc0lEMGdWV2x1ZERZMEtEQXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2JHVjBJR2tnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlkWEo1SURRS0NtMWhhVzVmZDJocGJHVmZkRzl3UURJME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSdkxXeHZiM0J6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdsbUlDaHBJRDRnTUNBbUppQnBJQ1VnWW5KbFlXdE5iMlFnUFQwOUlEQXBJR0p5WldGckNpQWdJQ0JrYVdjZ013b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTNDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRFVLSUNBZ0lDVUtJQ0FnSUdKNklHMWhhVzVmWW14dlkydEFNekFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCcElDczlJREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcENpQWdJQ0JrZFhBeUNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlrYnkxc2IyOXdjeTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUI5SUhkb2FXeGxJQ2hwSUR3Z2MzUnZjQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWJub2diV0ZwYmw5M2FHbHNaVjkwYjNCQU1qUUtDbTFoYVc1ZllteHZZMnRBTXpBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wkc4dGJHOXZjSE11WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnZEdWemRFUnZRbkpsWVdzb2MzUnZjRG9nZFdsdWREWTBMQ0JpY21WaGEwMXZaRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEVSdlgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wkc4dGJHOXZjSE11WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUIwWlhOMFJHOG9jM1J2Y0RvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWtieTFzYjI5d2N5NWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklHeGxkQ0JwSUQwZ1ZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZblZ5ZVNBMENncHRZV2x1WDNkb2FXeGxYM1J2Y0VBek16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5a2J5MXNiMjl3Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdrZ0t6MGdNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJSdkxXeHZiM0J6TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZlNCM2FHbHNaU0FvYVNBOElITjBiM0FwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1ltNTZJRzFoYVc1ZmQyaHBiR1ZmZEc5d1FETXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCMFpYTjBSRzhvYzNSdmNEb2dkV2x1ZERZMEtTQjdDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlpHOHRiRzl2Y0hNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSRzlNYjI5d2MwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUWdBSmdFRUZSOThkWUFBUndReEcwRUEzVEVaRkVReEdFU0NBd1E1STVlU0JLemk2eUVFZU9qVkZqWWFBSTREQUpZQVZBQUJBRFlhQVVrVkl4SkVGMFVDTmhvQ1NSVWpFa1FYUlFNa1JRUWtSUUZMQTBFQUpFc0RTd01ZUUFBY1NZRUNDRVVCU3dNaUNFVUVTd05MQWd4QS85OUpGaWhNVUxBaVEwa2lDRVVCU3dNaUNFVUVRdi9pTmhvQlNSVWpFa1FYUlFJMkdnSkpGU01TUkJkRkJTUkZBU1JGQkVzRFFRQUlTd05MQlJoQkFCRkxBeUlJU1VVRlNnaEZBa3NDREVELzRra1dLRXhRc0NKRE5ob0JTUlVqRWtRWFJRSWtSUVJMQXlJSVNVVUZTd0lNUVAvelN3TVdLRXhRc0NKRE1Sa1VNUmdVRUVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
