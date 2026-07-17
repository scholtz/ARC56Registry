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

namespace Arc56.Generated.algorandfoundation.puya_ts.TealScriptConventionsAlgo_b71037e4
{


    public class TealScriptConventionsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TealScriptConventionsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> </param>
        public async Task<ulong> NoMoreThanks(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 106, 101, 126 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NoMoreThanks_Transactions(ulong arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 106, 101, 126 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task CreateApplication(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 43, 229, 23 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 43, 229, 23 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task SetLocal(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 115, 0, 187 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLocal_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 115, 0, 187 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInToApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVhbFNjcmlwdENvbnZlbnRpb25zQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJub01vcmVUaGFua3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJDbG9zZU91dCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIiwiRGVsZXRlQXBwbGljYXRpb24iXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0TG9jYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Ub0FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjE3LDI0M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNiwyNTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBd0NncHRZV2x1WDJKc2IyTnJRREE2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTVFvS2JXRnBibDlpYkc5amEwQXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUmxZV3hUWTNKcGNIUkRiMjUyWlc1MGFXOXVjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCcGJYQnNaVzFsYm5SeklFTnZiblpsYm5ScGIyNWhiRkp2ZFhScGJtY2dld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlrWld4bGRHVkJjSEJzYVdOaGRHbHZia0E1Q2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNZ29LYldGcGJsOWhZbWxmY205MWRHbHVaMEF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1JsWVd3dGMyTnlhWEIwTFdOdmJuWmxiblJwYjI1ekxtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsWVd4VFkzSnBjSFJEYjI1MlpXNTBhVzl1YzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQnBiWEJzWlcxbGJuUnpJRU52Ym5abGJuUnBiMjVoYkZKdmRYUnBibWNnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpZMllUWTFOMlVnTHk4Z2JXVjBhRzlrSUNKdWIwMXZjbVZVYUdGdWEzTW9kV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURKbU1tSmxOVEUzSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b1lubDBaVnRkS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNV0V6WVRObVppQXZMeUJ0WlhSb2IyUWdJbTl3ZEVsdVZHOUJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTJaamMyTlRNeklDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa1pqY3pNREJpWWlBdkx5QnRaWFJvYjJRZ0luTmxkRXh2WTJGc0tITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J0WVhSamFDQnRZV2x1WDI1dlRXOXlaVlJvWVc1cmMxOXliM1YwWlVBeklHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFOQ0J0WVdsdVgyOXdkRWx1Vkc5QmNIQnNhV05oZEdsdmJsOXliM1YwWlVBMUlHMWhhVzVmZFhCa1lYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFOaUJ0WVdsdVgzTmxkRXh2WTJGc1gzSnZkWFJsUURjS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNE9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWldGc1UyTnlhWEIwUTI5dWRtVnVkR2x2Ym5OQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdhVzF3YkdWdFpXNTBjeUJEYjI1MlpXNTBhVzl1WVd4U2IzVjBhVzVuSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDl6WlhSTWIyTmhiRjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUhObGRFeHZZMkZzS0haaGJIVmxPaUJ6ZEhKcGJtY3BJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQnpaWFJNYjJOaGJBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVLQ2tnZTMwS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QlZjR1JoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGdLQ20xaGFXNWZiM0IwU1c1VWIwRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnYjNCMFNXNVViMEZ3Y0d4cFkyRjBhVzl1S0NrZ2UzMEtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QlBjSFJKYmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ2IzQjBTVzVVYjBGd2NHeHBZMkYwYVc5dUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRPYjA5d0p5d2dKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lITm9iQW9nSUNBZ2NIVnphR2x1ZENBek13b2dJQ0FnSmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNENncHRZV2x1WDI1dlRXOXlaVlJvWVc1cmMxOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ2R1YjAxdmNtVlVhR0Z1YTNNbklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdRMnh2YzJWUGRYUUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJR05zYjNObFQzVjBUMlpCY0hCc2FXTmhkR2x2YmdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2YmtBNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJRUJpWVhKbGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QkVaV3hsZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6bzZWR1ZoYkZOamNtbHdkRU52Ym5abGJuUnBiMjV6UVd4bmJ5NWpiRzl6WlU5MWRFOW1RWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHOXpaVTkxZEU5bVFYQndiR2xqWVhScGIyNDZDaUFnSUNCaUlHTnNiM05sVDNWMFQyWkJjSEJzYVdOaGRHbHZibDlpYkc5amEwQXdDZ3BqYkc5elpVOTFkRTltUVhCd2JHbGpZWFJwYjI1ZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQW5ibTlOYjNKbFZHaGhibXR6SnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMM1JsWVd3dGMyTnlhWEIwTFdOdmJuWmxiblJwYjI1ekxtRnNaMjh1ZEhNNk9sUmxZV3hUWTNKcGNIUkRiMjUyWlc1MGFXOXVjMEZzWjI4dVkyeHZjMlZQZFhSUFprRndjR3hwWTJGMGFXOXVDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaV0ZzTFhOamNtbHdkQzFqYjI1MlpXNTBhVzl1Y3k1aGJHZHZMblJ6T2pwVVpXRnNVMk55YVhCMFEyOXVkbVZ1ZEdsdmJuTkJiR2R2TG1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0JpSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDJKc2IyTnJRREFLQ21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZE9iMDl3Snl3Z0owUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUoxMGdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6bzZWR1ZoYkZOamNtbHdkRU52Ym5abGJuUnBiMjV6UVd4bmJ5NWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qcFVaV0ZzVTJOeWFYQjBRMjl1ZG1WdWRHbHZibk5CYkdkdkxuTmxkRXh2WTJGc1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVEc5allXdzZDaUFnSUNCaUlITmxkRXh2WTJGc1gySnNiMk5yUURBS0NuTmxkRXh2WTJGc1gySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdjMlYwVEc5allXd29kbUZzZFdVNklITjBjbWx1WnlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaV0ZzTFhOamNtbHdkQzFqYjI1MlpXNTBhVzl1Y3k1aGJHZHZMblJ6T2pwVVpXRnNVMk55YVhCMFEyOXVkbVZ1ZEdsdmJuTkJiR2R2TG5ObGRFeHZZMkZzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02T2xSbFlXeFRZM0pwY0hSRGIyNTJaVzUwYVc5dWMwRnNaMjh1YjNCMFNXNVViMEZ3Y0d4cFkyRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQjBTVzVVYjBGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnWWlCdmNIUkpibFJ2UVhCd2JHbGpZWFJwYjI1ZllteHZZMnRBTUFvS2IzQjBTVzVVYjBGd2NHeHBZMkYwYVc5dVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdiM0IwU1c1VWIwRndjR3hwWTJGMGFXOXVLQ2tnZTMwS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02T2xSbFlXeFRZM0pwY0hSRGIyNTJaVzUwYVc5dWMwRnNaMjh1YjNCMFNXNVViMEZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02T2xSbFlXeFRZM0pwY0hSRGIyNTJaVzUwYVc5dWMwRnNaMjh1ZFhCa1lYUmxRWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJR0lnZFhCa1lYUmxRWEJ3YkdsallYUnBiMjVmWW14dlkydEFNQW9LZFhCa1lYUmxRWEJ3YkdsallYUnBiMjVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaV0ZzTFhOamNtbHdkQzFqYjI1MlpXNTBhVzl1Y3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCMWNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlncElIdDlDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qcFVaV0ZzVTJOeWFYQjBRMjl1ZG1WdWRHbHZibk5CYkdkdkxuVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1JsWVd3dGMyTnlhWEIwTFdOdmJuWmxiblJwYjI1ekxtRnNaMjh1ZEhNNk9sUmxZV3hUWTNKcGNIUkRiMjUyWlc1MGFXOXVjMEZzWjI4dVkyeHZjMlZQZFhSUFprRndjR3hwWTJGMGFXOXVLR0Z5WnpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXRnNMWE5qY21sd2RDMWpiMjUyWlc1MGFXOXVjeTVoYkdkdkxuUnpPanBVWldGc1UyTnlhWEIwUTI5dWRtVnVkR2x2Ym5OQmJHZHZMbU5zYjNObFQzVjBUMlpCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qZ3RPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ2R1YjAxdmNtVlVhR0Z1YTNNbklIMHBDaUFnSUNBdkx5QmpiRzl6WlU5MWRFOW1RWEJ3YkdsallYUnBiMjRvWVhKbk9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pvNlZHVmhiRk5qY21sd2RFTnZiblpsYm5ScGIyNXpRV3huYnk1amJHOXpaVTkxZEU5bVFYQndiR2xqWVhScGIyNWZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02T2xSbFlXeFRZM0pwY0hSRGIyNTJaVzUwYVc5dWMwRnNaMjh1WTJ4dmMyVlBkWFJQWmtGd2NHeHBZMkYwYVc5dVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlad29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem82VkdWaGJGTmpjbWx3ZEVOdmJuWmxiblJwYjI1elFXeG5ieTVqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXRnNMWE5qY21sd2RDMWpiMjUyWlc1MGFXOXVjeTVoYkdkdkxuUnpPanBVWldGc1UyTnlhWEIwUTI5dWRtVnVkR2x2Ym5OQmJHZHZMbU55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02TVRJdE1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25UbTlQY0Njc0lDZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQXZMeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWgyWVd4MVpUb2dZbmwwWlhNcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pvNlZHVmhiRk5qY21sd2RFTnZiblpsYm5ScGIyNXpRV3huYnk1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6bzZWR1ZoYkZOamNtbHdkRU52Ym5abGJuUnBiMjV6UVd4bmJ5NWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaMnh2WW1Gc0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlaMnh2WW1Gc0lnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSFJvYVhNdVoyeHZZbUZzTG5aaGJIVmxJRDBnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXRnNMWE5qY21sd2RDMWpiMjUyWlc1MGFXOXVjeTVoYkdkdkxuUnpPanBVWldGc1UyTnlhWEIwUTI5dWRtVnVkR2x2Ym5OQmJHZHZMbk5sZEV4dlkyRnNLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZPbFJsWVd4VFkzSnBjSFJEYjI1MlpXNTBhVzl1YzBGc1oyOHVjMlYwVEc5allXdzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnYzJWMFRHOWpZV3dvZG1Gc2RXVTZJSE4wY21sdVp5a2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkwWldGc0xYTmpjbWx3ZEMxamIyNTJaVzUwYVc5dWN5NWhiR2R2TG5Sek9qcFVaV0ZzVTJOeWFYQjBRMjl1ZG1WdWRHbHZibk5CYkdkdkxuTmxkRXh2WTJGc1gySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5MFpXRnNMWE5qY21sd2RDMWpiMjUyWlc1MGFXOXVjeTVoYkdkdkxuUnpPanBVWldGc1UyTnlhWEIwUTI5dWRtVnVkR2x2Ym5OQmJHZHZMbk5sZEV4dlkyRnNYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIWmhiSFZsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJzYjJOaGJDQTlJRXh2WTJGc1UzUmhkR1U4YzNSeWFXNW5QaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbXh2WTJGc0lnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3dvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem82VkdWaGJGTmpjbWx3ZEVOdmJuWmxiblJwYjI1elFXeG5ieTVrWld4bGRHVkJjSEJzYVdOaGRHbHZiaWdwSUMwK0lIWnZhV1E2Q21SbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdZaUJrWld4bGRHVkJjSEJzYVdOaGRHbHZibDlpYkc5amEwQXdDZ3BrWld4bGRHVkJjSEJzYVdOaGRHbHZibDlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzUmxZV3d0YzJOeWFYQjBMV052Ym5abGJuUnBiMjV6TG1Gc1oyOHVkSE02T2xSbFlXeFRZM0pwY0hSRGIyNTJaVzUwYVc5dWMwRnNaMjh1YjNCMFNXNVViMEZ3Y0d4cFkyRjBhVzl1S0NrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNSbFlXd3RjMk55YVhCMExXTnZiblpsYm5ScGIyNXpMbUZzWjI4dWRITTZPbFJsWVd4VFkzSnBjSFJEYjI1MlpXNTBhVzl1YzBGc1oyOHViM0IwU1c1VWIwRndjR3hwWTJGMGFXOXVPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmRHVmhiQzF6WTNKcGNIUXRZMjl1ZG1WdWRHbHZibk11WVd4bmJ5NTBjem82VkdWaGJGTmpjbWx3ZEVOdmJuWmxiblJwYjI1elFXeG5ieTV2Y0hSSmJsUnZRWEJ3YkdsallYUnBiMjVmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM1JsWVd3dGMyTnlhWEIwTFdOdmJuWmxiblJwYjI1ekxtRnNaMjh1ZEhNNk9sUmxZV3hUWTNKcGNIUkRiMjUyWlc1MGFXOXVjMEZzWjI4dWIzQjBTVzVVYjBGd2NHeHBZMkYwYVc5dVgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6bzZWR1ZoYkZOamNtbHdkRU52Ym5abGJuUnBiMjV6UVd4bmJ5NTFjR1JoZEdWQmNIQnNhV05oZEdsdmJpZ3BJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OTBaV0ZzTFhOamNtbHdkQzFqYjI1MlpXNTBhVzl1Y3k1aGJHZHZMblJ6T2pwVVpXRnNVMk55YVhCMFEyOXVkbVZ1ZEdsdmJuTkJiR2R2TG5Wd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pvNlZHVmhiRk5qY21sd2RFTnZiblpsYm5ScGIyNXpRV3huYnk1MWNHUmhkR1ZCY0hCc2FXTmhkR2x2Ymw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12ZEdWaGJDMXpZM0pwY0hRdFkyOXVkbVZ1ZEdsdmJuTXVZV3huYnk1MGN6bzZWR1ZoYkZOamNtbHdkRU52Ym5abGJuUnBiMjV6UVd4bmJ5NTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pvNlZHVmhiRk5qY21sd2RFTnZiblpsYm5ScGIyNXpRV3huYnk1amJHVmhjbE4wWVhSbFVISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBd0NncHRZV2x1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkR1ZoYkMxelkzSnBjSFF0WTI5dWRtVnVkR2x2Ym5NdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSeWRXVUtJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFQ1FnQUFRZ0FBTVJzaUUwRUFrVUlBQURZYUFJQUVkbXBsZm9BRUx5dmxGNEFFQWFPai80QUVSdmRsTTRBRTMzTUF1MDhGamdVQVR3QTRBQ2dBRndBSFFnQUFRZ0FBQURFWkloSXhHQ0lURUVTSUFKSkMvK3d4R1lFRUVqRVlJaE1RUklnQW8wTC8yekVaSXhJeEdDSVRFRVNJQUl0Qy84c3hHU05QQVpDQklSb2lFekVZSWhJUVJJZ0FRRUwvdERFWkpCSXhHQ0lURUVTSUFCTkMvNlF4R1lFRkVqRVlJaE1RUklnQWtTTkRRZ0FBTmhvQlNSV0JDQkpFRjRnQVVSYUFCQlVmZkhWUEFWQ3dJME5DQUFBMkdnRkpJbGtqQ3lRSVN3RVZFa1JYQWdDSUFEVWpRMElBQURZYUFVa2lXU01MSkFoTEFSVVNSRmNDQUlnQUxTTkRRZ0FBaUFBOEkwTkNBQUNJQURnalE0b0JBVUlBQUl2L2lZb0JBRUlBQUlBR1oyeHZZbUZzaS85bmlZb0JBRUlBQURFQWdBVnNiMk5oYkl2L1pvbENBQUNKUWdBQWlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
