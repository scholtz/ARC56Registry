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

namespace Arc56.Generated.mitchhall16._2birds_open.StealthRegistry_0cc51ab4
{


    public class StealthRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StealthRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

        ///<summary>
        ///Register a stealth meta-address (spending pub 64B + viewing pub 64B = 128B).
        ///</summary>
        /// <param name="label"> </param>
        /// <param name="metaAddress"> </param>
        public async Task Register(byte[] label, byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 56, 21, 222 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); labelAbi.From(label);
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metaAddressAbi.From(metaAddress);

            var result = await base.CallApp(new List<object> { abiHandle, labelAbi, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(byte[] label, byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 56, 21, 222 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); labelAbi.From(label);
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metaAddressAbi.From(metaAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, labelAbi, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Publish a stealth payment announcement.
        ///Data: ephemeral_pub (64B) + stealth_addr (32B) + view_tag (1B) + metadata
        ///</summary>
        /// <param name="announcementData"> </param>
        public async Task Announce(byte[] announcementData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 94, 60, 215 };
            var announcementDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); announcementDataAbi.From(announcementData);

            var result = await base.CallApp(new List<object> { abiHandle, announcementDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Announce_Transactions(byte[] announcementData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 94, 60, 215 };
            var announcementDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); announcementDataAbi.From(announcementData);

            return await base.MakeTransactionList(new List<object> { abiHandle, announcementDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove a meta-address registration. Reclaims box MBR.
        ///</summary>
        /// <param name="label"> </param>
        public async Task Deregister(byte[] label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 114, 22, 162 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); labelAbi.From(label);

            var result = await base.CallApp(new List<object> { abiHandle, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deregister_Transactions(byte[] label, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 114, 22, 162 };
            var labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); labelAbi.From(label);

            return await base.MakeTransactionList(new List<object> { abiHandle, labelAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJTdGVhbHRoUmVnaXN0cnkiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJyZWdpc3RlciIsImRlc2MiOiJSZWdpc3RlciBhIHN0ZWFsdGggbWV0YS1hZGRyZXNzIChzcGVuZGluZyBwdWIgNjRCICsgdmlld2luZyBwdWIgNjRCID0gMTI4QikuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxhYmVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiYW5ub3VuY2UiLCJkZXNjIjoiUHVibGlzaCBhIHN0ZWFsdGggcGF5bWVudCBhbm5vdW5jZW1lbnQuXG5EYXRhOiBlcGhlbWVyYWxfcHViICg2NEIpICsgc3RlYWx0aF9hZGRyICgzMkIpICsgdmlld190YWcgKDFCKSArIG1ldGFkYXRhIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFubm91bmNlbWVudERhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlcmVnaXN0ZXIiLCJkZXNjIjoiUmVtb3ZlIGEgbWV0YS1hZGRyZXNzIHJlZ2lzdHJhdGlvbi4gUmVjbGFpbXMgYm94IE1CUi4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElEQUtZbmwwWldOaWJHOWpheUF3ZURZek5tWTNOVFpsTnpRZ01IZzJaRFkxTnpRMk1Rb0tMeThnVkdocGN5QlVSVUZNSUhkaGN5Qm5aVzVsY21GMFpXUWdZbmtnVkVWQlRGTmpjbWx3ZENCMk1DNHhNRGN1TWdvdkx5Qm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMVJGUVV4VFkzSnBjSFFLQ2k4dklGUm9hWE1nWTI5dWRISmhZM1FnYVhNZ1kyOXRjR3hwWVc1MElIZHBkR2dnWVc1a0wyOXlJR2x0Y0d4bGJXVnVkSE1nZEdobElHWnZiR3h2ZDJsdVp5QkJVa056T2lCYklFRlNRelFnWFFvS0x5OGdWR2hsSUdadmJHeHZkMmx1WnlCMFpXNGdiR2x1WlhNZ2IyWWdWRVZCVENCb1lXNWtiR1VnYVc1cGRHbGhiQ0J3Y205bmNtRnRJR1pzYjNjS0x5OGdWR2hwY3lCd1lYUjBaWEp1SUdseklIVnpaV1FnZEc4Z2JXRnJaU0JwZENCbFlYTjVJR1p2Y2lCaGJubHZibVVnZEc4Z2NHRnljMlVnZEdobElITjBZWEowSUc5bUlIUm9aU0J3Y205bmNtRnRJR0Z1WkNCa1pYUmxjbTFwYm1VZ2FXWWdZU0J6Y0dWamFXWnBZeUJoWTNScGIyNGdhWE1nWVd4c2IzZGxaQW92THlCSVpYSmxMQ0JoWTNScGIyNGdjbVZtWlhKeklIUnZJSFJvWlNCUGJrTnZiWEJzWlhSbElHbHVJR052YldKcGJtRjBhVzl1SUhkcGRHZ2dkMmhsZEdobGNpQjBhR1VnWVhCd0lHbHpJR0psYVc1bklHTnlaV0YwWldRZ2IzSWdZMkZzYkdWa0NpOHZJRVYyWlhKNUlIQnZjM05wWW14bElHRmpkR2x2YmlCbWIzSWdkR2hwY3lCamIyNTBjbUZqZENCcGN5QnlaWEJ5WlhObGJuUmxaQ0JwYmlCMGFHVWdjM2RwZEdOb0lITjBZWFJsYldWdWRBb3ZMeUJKWmlCMGFHVWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdVZ1kyOXVkSEpoWTNRc0lHbDBjeUJ5WlhOd1pXTjBhWFpsSUdKeVlXNWphQ0IzYVd4c0lHSmxJQ0lxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJaUIzYUdsamFDQnFkWE4wSUdOdmJuUmhhVzV6SUNKbGNuSWlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUVLY0hWemFHbHVkQ0EyQ2lvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvckNuTjNhWFJqYUNBcVkyRnNiRjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxWTNKbFlYUmxYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVDZ29xVGs5VVgwbE5VRXhGVFVWT1ZFVkVPZ29KTHk4Z1ZHaGxJSEpsY1hWbGMzUmxaQ0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb2FYTWdZMjl1ZEhKaFkzUXVJRUZ5WlNCNWIzVWdkWE5wYm1jZ2RHaGxJR052Y25KbFkzUWdUMjVEYjIxd2JHVjBaVDhnUkdsa0lIbHZkU0J6WlhRZ2VXOTFjaUJoY0hBZ1NVUS9DZ2xsY25JS0NpOHZJR055WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2t2THlCbGVHVmpkWFJsSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtDZ2xqWVd4c2MzVmlJR055WldGMFpVRndjR3hwWTJGMGFXOXVDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BPaUIyYjJsa0NtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0pjSEp2ZEc4Z01DQXdDZ29KTHk4Z1kyOXVkSEpoWTNSekwzTjBaV0ZzZEdndGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1Rb0pMeThnZEdocGN5NWhibTV2ZFc1alpXMWxiblJEYjNWdWRDNTJZV3gxWlNBOUlEQUtDV0o1ZEdWaklEQWdMeThnSUNKamIzVnVkQ0lLQ1dsdWRHTWdNU0F2THlBd0NnbGhjSEJmWjJ4dlltRnNYM0IxZEFvSmNtVjBjM1ZpQ2dvdkx5QnlaV2RwYzNSbGNpaGllWFJsVzEwc1lubDBaVnRkS1hadmFXUUtLbUZpYVY5eWIzVjBaVjl5WldkcGMzUmxjam9LQ1M4dklHMWxkR0ZCWkdSeVpYTnpPaUJpZVhSbFcxMEtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2JHRmlaV3c2SUdKNWRHVmJYUW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0paWGgwY21GamRDQXlJREFLQ2drdkx5QmxlR1ZqZFhSbElISmxaMmx6ZEdWeUtHSjVkR1ZiWFN4aWVYUmxXMTBwZG05cFpBb0pZMkZzYkhOMVlpQnlaV2RwYzNSbGNnb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2NtVm5hWE4wWlhJb2JHRmlaV3c2SUdKNWRHVnpMQ0J0WlhSaFFXUmtjbVZ6Y3pvZ1lubDBaWE1wT2lCMmIybGtDaTh2Q2k4dklGSmxaMmx6ZEdWeUlHRWdjM1JsWVd4MGFDQnRaWFJoTFdGa1pISmxjM01nS0hOd1pXNWthVzVuSUhCMVlpQTJORUlnS3lCMmFXVjNhVzVuSUhCMVlpQTJORUlnUFNBeE1qaENLUzRLY21WbmFYTjBaWEk2Q2dsd2NtOTBieUF5SURBS0Nna3ZMeUJqYjI1MGNtRmpkSE12YzNSbFlXeDBhQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakU0Q2drdkx5QmhjM05sY25Rb2JHVnVLRzFsZEdGQlpHUnlaWE56S1NBOVBUMGdNVEk0S1FvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUcxbGRHRkJaR1J5WlhOek9pQmllWFJsY3dvSmJHVnVDZ2x3ZFhOb2FXNTBJREV5T0FvSlBUMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wY3k5emRHVmhiSFJvTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRrS0NTOHZJR0Z6YzJWeWRDaHNaVzRvYkdGaVpXd3BJRDRnTUNrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCc1lXSmxiRG9nWW5sMFpYTUtDV3hsYmdvSmFXNTBZeUF4SUM4dklEQUtDVDRLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGN5OXpkR1ZoYkhSb0xYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qQUtDUzh2SUhSb2FYTXViV1YwWVVGa1pISmxjM05sY3loc1lXSmxiQ2t1ZG1Gc2RXVWdQU0J0WlhSaFFXUmtjbVZ6Y3dvSllubDBaV01nTVNBdkx5QWdJbTFsZEdFaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2JHRmlaV3c2SUdKNWRHVnpDZ2xqYjI1allYUUtDV1IxY0FvSlltOTRYMlJsYkFvSmNHOXdDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdiV1YwWVVGa1pISmxjM002SUdKNWRHVnpDZ2xpYjNoZmNIVjBDZ2x5WlhSemRXSUtDaTh2SUdGdWJtOTFibU5sS0dKNWRHVmJYU2wyYjJsa0NpcGhZbWxmY205MWRHVmZZVzV1YjNWdVkyVTZDZ2t2THlCaGJtNXZkVzVqWlcxbGJuUkVZWFJoT2lCaWVYUmxXMTBLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV1Y0ZEhKaFkzUWdNaUF3Q2dvSkx5OGdaWGhsWTNWMFpTQmhibTV2ZFc1alpTaGllWFJsVzEwcGRtOXBaQW9KWTJGc2JITjFZaUJoYm01dmRXNWpaUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdZVzV1YjNWdVkyVW9ZVzV1YjNWdVkyVnRaVzUwUkdGMFlUb2dZbmwwWlhNcE9pQjJiMmxrQ2k4dkNpOHZJRkIxWW14cGMyZ2dZU0J6ZEdWaGJIUm9JSEJoZVcxbGJuUWdZVzV1YjNWdVkyVnRaVzUwTGdvdkx5QkVZWFJoT2lCbGNHaGxiV1Z5WVd4ZmNIVmlJQ2cyTkVJcElDc2djM1JsWVd4MGFGOWhaR1J5SUNnek1rSXBJQ3NnZG1sbGQxOTBZV2NnS0RGQ0tTQXJJRzFsZEdGa1lYUmhDbUZ1Ym05MWJtTmxPZ29KY0hKdmRHOGdNU0F3Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NYQjFjMmhpZVhSbGN5QXdlQW9LQ1M4dklHTnZiblJ5WVdOMGN5OXpkR1ZoYkhSb0xYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qZ0tDUzh2SUdGemMyVnlkQ2hzWlc0b1lXNXViM1Z1WTJWdFpXNTBSR0YwWVNrZ1BqMGdPVGNwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVc1dWIzVnVZMlZ0Wlc1MFJHRjBZVG9nWW5sMFpYTUtDV3hsYmdvSmNIVnphR2x1ZENBNU53b0pQajBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGN5OXpkR1ZoYkhSb0xYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16QUtDUzh2SUdOdmRXNTBJRDBnZEdocGN5NWhibTV2ZFc1alpXMWxiblJEYjNWdWRDNTJZV3gxWlFvSllubDBaV01nTUNBdkx5QWdJbU52ZFc1MElnb0pZWEJ3WDJkc2IySmhiRjluWlhRS0NXWnlZVzFsWDJKMWNua2dNQ0F2THlCamIzVnVkRG9nZFdsdWREWTBDZ29KTHk4Z1kyOXVkSEpoWTNSekwzTjBaV0ZzZEdndGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvek1Rb0pMeThnZEdocGN5NWhibTV2ZFc1alpXMWxiblJ6S0dOdmRXNTBLUzUyWVd4MVpTQTlJR0Z1Ym05MWJtTmxiV1Z1ZEVSaGRHRUtDWEIxYzJoaWVYUmxjeUF3ZURZeE5tVTJaU0F2THlBaVlXNXVJZ29KWm5KaGJXVmZaR2xuSURBZ0x5OGdZMjkxYm5RNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xrZFhBS0NXSnZlRjlrWld3S0NYQnZjQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR0Z1Ym05MWJtTmxiV1Z1ZEVSaGRHRTZJR0o1ZEdWekNnbGliM2hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6TDNOMFpXRnNkR2d0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem96TWdvSkx5OGdkR2hwY3k1aGJtNXZkVzVqWlcxbGJuUkRiM1Z1ZEM1MllXeDFaU0E5SUdOdmRXNTBJQ3NnTVFvSllubDBaV01nTUNBdkx5QWdJbU52ZFc1MElnb0pabkpoYldWZlpHbG5JREFnTHk4Z1kyOTFiblE2SUhWcGJuUTJOQW9KYVc1MFl5QXdJQzh2SURFS0NTc0tDV0Z3Y0Y5bmJHOWlZV3hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6TDNOMFpXRnNkR2d0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem96TkFvSkx5OGdiRzluS0dOdmJtTmhkQ2hvWlhnb0p6WXhObVUyWlRabU56VTJaVFl6TmpVbktTd2dhWFJ2WWloamIzVnVkQ2twS1FvSmNIVnphR0o1ZEdWeklEQjROakUyWlRabE5tWTNOVFpsTmpNMk5Rb0pabkpoYldWZlpHbG5JREFnTHk4Z1kyOTFiblE2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbHNiMmNLQ1hKbGRITjFZZ29LTHk4Z1pHVnlaV2RwYzNSbGNpaGllWFJsVzEwcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJSbGNtVm5hWE4wWlhJNkNna3ZMeUJzWVdKbGJEb2dZbmwwWlZ0ZENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsbGVIUnlZV04wSURJZ01Bb0tDUzh2SUdWNFpXTjFkR1VnWkdWeVpXZHBjM1JsY2loaWVYUmxXMTBwZG05cFpBb0pZMkZzYkhOMVlpQmtaWEpsWjJsemRHVnlDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmtaWEpsWjJsemRHVnlLR3hoWW1Wc09pQmllWFJsY3lrNklIWnZhV1FLTHk4S0x5OGdVbVZ0YjNabElHRWdiV1YwWVMxaFpHUnlaWE56SUhKbFoybHpkSEpoZEdsdmJpNGdVbVZqYkdGcGJYTWdZbTk0SUUxQ1VpNEtaR1Z5WldkcGMzUmxjam9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjeTl6ZEdWaGJIUm9MWEpsWjJsemRISjVMbUZzWjI4dWRITTZOREVLQ1M4dklHRnpjMlZ5ZENoMGFHbHpMbTFsZEdGQlpHUnlaWE56WlhNb2JHRmlaV3dwTG1WNGFYTjBjeWtLQ1dKNWRHVmpJREVnTHk4Z0lDSnRaWFJoSWdvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUd4aFltVnNPaUJpZVhSbGN3b0pZMjl1WTJGMENnbGliM2hmYkdWdUNnbHpkMkZ3Q2dsd2IzQUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wY3k5emRHVmhiSFJvTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TkRJS0NTOHZJSFJvYVhNdWJXVjBZVUZrWkhKbGMzTmxjeWhzWVdKbGJDa3VaR1ZzWlhSbEtDa0tDV0o1ZEdWaklERWdMeThnSUNKdFpYUmhJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJR3hoWW1Wc09pQmllWFJsY3dvSlkyOXVZMkYwQ2dsaWIzaGZaR1ZzQ2dseVpYUnpkV0lLQ2lwamNtVmhkR1ZmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR055WldGMFpTQk9iMDl3Q2dsbGNuSUtDaXBqWVd4c1gwNXZUM0E2Q2dsd2RYTm9ZbmwwWlhNZ01IZzNPVE00TVRWa1pTQXZMeUJ0WlhSb2IyUWdJbkpsWjJsemRHVnlLR0o1ZEdWYlhTeGllWFJsVzEwcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEWTBOV1V6WTJRM0lDOHZJRzFsZEdodlpDQWlZVzV1YjNWdVkyVW9ZbmwwWlZ0ZEtYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IZzVNRGN5TVRaaE1pQXZMeUJ0WlhSb2IyUWdJbVJsY21WbmFYTjBaWElvWW5sMFpWdGRLWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDNKbFoybHpkR1Z5SUNwaFltbGZjbTkxZEdWZllXNXViM1Z1WTJVZ0ttRmlhVjl5YjNWMFpWOWtaWEpsWjJsemRHVnlDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOm51bGwsImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
