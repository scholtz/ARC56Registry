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

namespace Arc56.Generated.algorandfoundation.TEALScript.AVM11_e72d9899
{


    public class AVM11Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AVM11Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task VoterOpcodes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 193, 41, 246 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoterOpcodes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 193, 41, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task IncentiveGlobals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 139, 248, 103 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncentiveGlobals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 139, 248, 103 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OnlineStakeOp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 58, 29, 212 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OnlineStakeOp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 58, 29, 212 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task AccountParams(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 178, 254, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AccountParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 178, 254, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task BlockParams(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 101, 129, 245 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BlockParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 101, 129, 245 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBVk0xMSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidm90ZXJPcGNvZGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJpbmNlbnRpdmVHbG9iYWxzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJvbmxpbmVTdGFrZU9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJhY2NvdW50UGFyYW1zIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJibG9ja1BhcmFtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q21sdWRHTmliRzlqYXlBeENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdkbTkwWlhKUGNHTnZaR1Z6S0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmZG05MFpYSlBjR052WkdWek9nb0pMeThnWlhobFkzVjBaU0IyYjNSbGNrOXdZMjlrWlhNb0tYWnZhV1FLQ1dOaGJHeHpkV0lnZG05MFpYSlBjR052WkdWekNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCMmIzUmxjazl3WTI5a1pYTW9LVG9nZG05cFpBcDJiM1JsY2s5d1kyOWtaWE02Q2dsd2NtOTBieUF3SURBS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZWFp0TVRFdVlXeG5ieTUwY3pvM0Nna3ZMeUJoYzNObGNuUW9kR2hwY3k1MGVHNHVjMlZ1WkdWeUxuWnZkR1Z5UW1Gc1lXNWpaU2tLQ1hSNGJpQlRaVzVrWlhJS0NYWnZkR1Z5WDNCaGNtRnRjMTluWlhRZ1ZtOTBaWEpDWVd4aGJtTmxDZ2xoYzNObGNuUUtDWEpsZEhOMVlnb0tMeThnYVc1alpXNTBhWFpsUjJ4dlltRnNjeWdwZG05cFpBb3FZV0pwWDNKdmRYUmxYMmx1WTJWdWRHbDJaVWRzYjJKaGJITTZDZ2t2THlCbGVHVmpkWFJsSUdsdVkyVnVkR2wyWlVkc2IySmhiSE1vS1hadmFXUUtDV05oYkd4emRXSWdhVzVqWlc1MGFYWmxSMnh2WW1Gc2N3b0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2FXNWpaVzUwYVhabFIyeHZZbUZzY3lncE9pQjJiMmxrQ21sdVkyVnVkR2wyWlVkc2IySmhiSE02Q2dsd2NtOTBieUF3SURBS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZWFp0TVRFdVlXeG5ieTUwY3pveE1nb0pMeThnWVhOelpYSjBLR2RzYjJKaGJITXVjR0Y1YjNWMGMwVnVZV0pzWldRcENnbG5iRzlpWVd3Z1VHRjViM1YwYzBWdVlXSnNaV1FLQ1dGemMyVnlkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aGRtMHhNUzVoYkdkdkxuUnpPakV6Q2drdkx5QmhjM05sY25Rb1oyeHZZbUZzY3k1d1lYbHZkWFJ6UjI5UGJteHBibVZHWldVcENnbG5iRzlpWVd3Z1VHRjViM1YwYzBkdlQyNXNhVzVsUm1WbENnbGhjM05sY25RS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZWFp0TVRFdVlXeG5ieTUwY3pveE5Bb0pMeThnWVhOelpYSjBLR2RzYjJKaGJITXVjR0Y1YjNWMGMxQmxjbU5sYm5RcENnbG5iRzlpWVd3Z1VHRjViM1YwYzFCbGNtTmxiblFLQ1dGemMyVnlkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aGRtMHhNUzVoYkdkdkxuUnpPakUxQ2drdkx5QmhjM05sY25Rb1oyeHZZbUZzY3k1d1lYbHZkWFJ6VFdsdVFtRnNZVzVqWlNrS0NXZHNiMkpoYkNCUVlYbHZkWFJ6VFdsdVFtRnNZVzVqWlFvSllYTnpaWEowQ2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyRjJiVEV4TG1Gc1oyOHVkSE02TVRZS0NTOHZJR0Z6YzJWeWRDaG5iRzlpWVd4ekxuQmhlVzkxZEhOTllYaENZV3hoYm1ObEtRb0paMnh2WW1Gc0lGQmhlVzkxZEhOTllYaENZV3hoYm1ObENnbGhjM05sY25RS0NYSmxkSE4xWWdvS0x5OGdiMjVzYVc1bFUzUmhhMlZQY0NncGRtOXBaQW9xWVdKcFgzSnZkWFJsWDI5dWJHbHVaVk4wWVd0bFQzQTZDZ2t2THlCbGVHVmpkWFJsSUc5dWJHbHVaVk4wWVd0bFQzQW9LWFp2YVdRS0NXTmhiR3h6ZFdJZ2IyNXNhVzVsVTNSaGEyVlBjQW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdiMjVzYVc1bFUzUmhhMlZQY0NncE9pQjJiMmxrQ205dWJHbHVaVk4wWVd0bFQzQTZDZ2x3Y205MGJ5QXdJREFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllYWnRNVEV1WVd4bmJ5NTBjem95TUFvSkx5OGdZWE56WlhKMEtHOXViR2x1WlZOMFlXdGxLQ2twQ2dsdmJteHBibVZmYzNSaGEyVUtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJoWTJOdmRXNTBVR0Z5WVcxektDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZllXTmpiM1Z1ZEZCaGNtRnRjem9LQ1M4dklHVjRaV04xZEdVZ1lXTmpiM1Z1ZEZCaGNtRnRjeWdwZG05cFpBb0pZMkZzYkhOMVlpQmhZMk52ZFc1MFVHRnlZVzF6Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJoWTJOdmRXNTBVR0Z5WVcxektDazZJSFp2YVdRS1lXTmpiM1Z1ZEZCaGNtRnRjem9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhkbTB4TVM1aGJHZHZMblJ6T2pJMENna3ZMeUJoYzNObGNuUW9kR2hwY3k1MGVHNHVjMlZ1WkdWeUxtbHVZMlZ1ZEdsMlpVVnNhV2RwWW14bEtRb0pkSGh1SUZObGJtUmxjZ29KWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSSmJtTmxiblJwZG1WRmJHbG5hV0pzWlFvSmNHOXdDZ2xoYzNObGNuUUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVhadE1URXVZV3huYnk1MGN6b3lOUW9KTHk4Z1lYTnpaWEowS0hSb2FYTXVkSGh1TG5ObGJtUmxjaTVzWVhOMFNHVmhjblJpWldGMEtRb0pkSGh1SUZObGJtUmxjZ29KWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTVlYTjBTR1ZoY25SaVpXRjBDZ2x3YjNBS0NXRnpjMlZ5ZEFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhkbTB4TVM1aGJHZHZMblJ6T2pJMkNna3ZMeUJoYzNObGNuUW9kR2hwY3k1MGVHNHVjMlZ1WkdWeUxteGhjM1JRY205d2IzTmxaQ2tLQ1hSNGJpQlRaVzVrWlhJS0NXRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUR0Z6ZEZCeWIzQnZjMlZrQ2dsd2IzQUtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJpYkc5amExQmhjbUZ0Y3lncGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJKc2IyTnJVR0Z5WVcxek9nb0pMeThnWlhobFkzVjBaU0JpYkc5amExQmhjbUZ0Y3lncGRtOXBaQW9KWTJGc2JITjFZaUJpYkc5amExQmhjbUZ0Y3dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWW14dlkydFFZWEpoYlhNb0tUb2dkbTlwWkFwaWJHOWphMUJoY21GdGN6b0tDWEJ5YjNSdklEQWdNQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aGRtMHhNUzVoYkdkdkxuUnpPak13Q2drdkx5QnNiMmNvWW14dlkydHpXMmRzYjJKaGJITXVjbTkxYm1RZ0xTQXhYUzV3Y205d2IzTmxjaWtLQ1dkc2IySmhiQ0JTYjNWdVpBb0phVzUwWXlBd0lDOHZJREVLQ1MwS0NXSnNiMk5ySUVKc2ExQnliM0J2YzJWeUNnbHNiMmNLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllYWnRNVEV1WVd4bmJ5NTBjem96TVFvSkx5OGdZWE56WlhKMEtHSnNiMk5yYzF0bmJHOWlZV3h6TG5KdmRXNWtJQzBnTVYwdVptVmxjME52Ykd4bFkzUmxaQ2tLQ1dkc2IySmhiQ0JTYjNWdVpBb0phVzUwWXlBd0lDOHZJREVLQ1MwS0NXSnNiMk5ySUVKc2EwWmxaWE5EYjJ4c1pXTjBaV1FLQ1dGemMyVnlkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aGRtMHhNUzVoYkdkdkxuUnpPak15Q2drdkx5QmhjM05sY25Rb1lteHZZMnR6VzJkc2IySmhiSE11Y205MWJtUWdMU0F4WFM1aWIyNTFjeWtLQ1dkc2IySmhiQ0JTYjNWdVpBb0phVzUwWXlBd0lDOHZJREVLQ1MwS0NXSnNiMk5ySUVKc2EwSnZiblZ6Q2dsaGMzTmxjblFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllYWnRNVEV1WVd4bmJ5NTBjem96TXdvSkx5OGdiRzluS0dKc2IyTnJjMXRuYkc5aVlXeHpMbkp2ZFc1a0lDMGdNVjB1WW5KaGJtTm9LUW9KWjJ4dlltRnNJRkp2ZFc1a0NnbHBiblJqSURBZ0x5OGdNUW9KTFFvSllteHZZMnNnUW14clFuSmhibU5vQ2dsc2IyY0tDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVhadE1URXVZV3huYnk1MGN6b3pOQW9KTHk4Z2JHOW5LR0pzYjJOcmMxdG5iRzlpWVd4ekxuSnZkVzVrSUMwZ01WMHVabVZsVTJsdWF5a0tDV2RzYjJKaGJDQlNiM1Z1WkFvSmFXNTBZeUF3SUM4dklERUtDUzBLQ1dKc2IyTnJJRUpzYTBabFpWTnBibXNLQ1d4dlp3b0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloZG0weE1TNWhiR2R2TG5Sek9qTTFDZ2t2THlCc2IyY29ZbXh2WTJ0elcyZHNiMkpoYkhNdWNtOTFibVFnTFNBeFhTNXdjbTkwYjJOdmJDa0tDV2RzYjJKaGJDQlNiM1Z1WkFvSmFXNTBZeUF3SUM4dklERUtDUzBLQ1dKc2IyTnJJRUpzYTFCeWIzUnZZMjlzQ2dsc2IyY0tDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVhadE1URXVZV3huYnk1MGN6b3pOZ29KTHk4Z1lYTnpaWEowS0dKc2IyTnJjMXRuYkc5aVlXeHpMbkp2ZFc1a0lDMGdNVjB1ZEhodVEyOTFiblJsY2lrS0NXZHNiMkpoYkNCU2IzVnVaQW9KYVc1MFl5QXdJQzh2SURFS0NTMEtDV0pzYjJOcklFSnNhMVI0YmtOdmRXNTBaWElLQ1dGemMyVnlkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aGRtMHhNUzVoYkdkdkxuUnpPak0zQ2drdkx5QmhjM05sY25Rb1lteHZZMnR6VzJkc2IySmhiSE11Y205MWJtUWdMU0F4WFM1d2NtOXdiM05sY2xCaGVXOTFkQ2tLQ1dkc2IySmhiQ0JTYjNWdVpBb0phVzUwWXlBd0lDOHZJREVLQ1MwS0NXSnNiMk5ySUVKc2ExQnliM0J2YzJWeVVHRjViM1YwQ2dsaGMzTmxjblFLQ1hKbGRITjFZZ29LS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaXBqY21WaGRHVmZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTnlaV0YwWlNCT2IwOXdDZ2xsY25JS0NpcGpZV3hzWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhnNFpHTXhNamxtTmlBdkx5QnRaWFJvYjJRZ0luWnZkR1Z5VDNCamIyUmxjeWdwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZUdFNE9HSm1PRFkzSUM4dklHMWxkR2h2WkNBaWFXNWpaVzUwYVhabFIyeHZZbUZzY3lncGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEa3hNMkV4WkdRMElDOHZJRzFsZEdodlpDQWliMjVzYVc1bFUzUmhhMlZQY0NncGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VHRTFZakptWldOaUlDOHZJRzFsZEdodlpDQWlZV05qYjNWdWRGQmhjbUZ0Y3lncGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VETm1OalU0TVdZMUlDOHZJRzFsZEdodlpDQWlZbXh2WTJ0UVlYSmhiWE1vS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgzWnZkR1Z5VDNCamIyUmxjeUFxWVdKcFgzSnZkWFJsWDJsdVkyVnVkR2wyWlVkc2IySmhiSE1nS21GaWFWOXliM1YwWlY5dmJteHBibVZUZEdGclpVOXdJQ3BoWW1sZmNtOTFkR1ZmWVdOamIzVnVkRkJoY21GdGN5QXFZV0pwWDNKdmRYUmxYMkpzYjJOclVHRnlZVzF6Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dUbTlQY0FvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeCJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
