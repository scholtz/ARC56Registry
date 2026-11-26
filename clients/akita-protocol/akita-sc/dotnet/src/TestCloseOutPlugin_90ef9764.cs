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

namespace Arc56.Generated.akita_protocol.akita_sc.TestCloseOutPlugin_90ef9764
{


    //
    // Test plugin for close-out scenarios.
    //
    //This plugin can:
    //- Close out ALGO balance to a specified address
    //- Close out ASA balance to a specified address
    //
    public class TestCloseOutPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestCloseOutPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Close out ALGO balance of the spending account.
        ///Sends `amount` to `receiver` and optionally closes the remaining ALGO balance to `closeTo`.
        ///If closeTo equals the sender (wallet address), no close-out is performed.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        /// <param name="closeTo"> </param>
        public async Task CloseOutAlgo(ulong wallet, bool rekeyBack, Algorand.Address receiver, ulong amount, Algorand.Address closeTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 127, 207, 17 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var closeToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeToAbi.From(closeTo);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, receiverAbi, amountAbi, closeToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOutAlgo_Transactions(ulong wallet, bool rekeyBack, Algorand.Address receiver, ulong amount, Algorand.Address closeTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 127, 207, 17 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var closeToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeToAbi.From(closeTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, receiverAbi, amountAbi, closeToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Close out an ASA balance of the spending account.
        ///Sends `amount` to `receiver` and closes the remaining asset balance to `assetCloseTo`.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        /// <param name="assetCloseTo"> </param>
        public async Task CloseOutAsset(ulong wallet, bool rekeyBack, ulong asset, Algorand.Address receiver, Algorand.Address assetCloseTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 212, 84, 14 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetCloseToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); assetCloseToAbi.From(assetCloseTo);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetAbi, receiverAbi, assetCloseToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOutAsset_Transactions(ulong wallet, bool rekeyBack, ulong asset, Algorand.Address receiver, Algorand.Address assetCloseTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 212, 84, 14 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetCloseToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); assetCloseToAbi.From(assetCloseTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetAbi, receiverAbi, assetCloseToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdENsb3NlT3V0UGx1Z2luIiwiZGVzYyI6IlRlc3QgcGx1Z2luIGZvciBjbG9zZS1vdXQgc2NlbmFyaW9zLlxuXG5UaGlzIHBsdWdpbiBjYW46XG4tIENsb3NlIG91dCBBTEdPIGJhbGFuY2UgdG8gYSBzcGVjaWZpZWQgYWRkcmVzc1xuLSBDbG9zZSBvdXQgQVNBIGJhbGFuY2UgdG8gYSBzcGVjaWZpZWQgYWRkcmVzcyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjbG9zZU91dEFsZ28iLCJkZXNjIjoiQ2xvc2Ugb3V0IEFMR08gYmFsYW5jZSBvZiB0aGUgc3BlbmRpbmcgYWNjb3VudC5cblNlbmRzIGBhbW91bnRgIHRvIGByZWNlaXZlcmAgYW5kIG9wdGlvbmFsbHkgY2xvc2VzIHRoZSByZW1haW5pbmcgQUxHTyBiYWxhbmNlIHRvIGBjbG9zZVRvYC5cbklmIGNsb3NlVG8gZXF1YWxzIHRoZSBzZW5kZXIgKHdhbGxldCBhZGRyZXNzKSwgbm8gY2xvc2Utb3V0IGlzIHBlcmZvcm1lZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VPdXRBc3NldCIsImRlc2MiOiJDbG9zZSBvdXQgYW4gQVNBIGJhbGFuY2Ugb2YgdGhlIHNwZW5kaW5nIGFjY291bnQuXG5TZW5kcyBgYW1vdW50YCB0byBgcmVjZWl2ZXJgIGFuZCBjbG9zZXMgdGhlIHJlbWFpbmluZyBhc3NldCBiYWxhbmNlIHRvIGBhc3NldENsb3NlVG9gLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldENsb3NlVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMSwxNzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExLDEyOCwxOTcsMjA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyLDExOSwxNjksMTg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVOc2IzTmxUM1YwVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZek4yWmpaakV4SURCNFpETmtORFUwTUdVZ0x5OGdiV1YwYUc5a0lDSmpiRzl6WlU5MWRFRnNaMjhvZFdsdWREWTBMR0p2YjJ3c1lXUmtjbVZ6Y3l4MWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpiRzl6WlU5MWRFRnpjMlYwS0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR05zYjNObFQzVjBRV3huYnlCamJHOXpaVTkxZEVGemMyVjBDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVOc2IzTmxUM1YwVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QkFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXpvZ2RXbHVkRFkwTENCM1lXeHNaWFE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25KbGEyVjVRV1JrY21WemN6b0tJQ0FnSUM4dklDNHVMeTR1TDI1dlpHVmZiVzlrZFd4bGN5OUFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6b3hORE1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQm1kVzVqZEdsdmJpQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yT2lCaWIyOXNaV0Z1TENCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dRV05qYjNWdWRDQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveE5EUUtJQ0FnSUM4dklHbG1JQ2doY21WclpYbENZV05yS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p1ZWlCeVpXdGxlVUZrWkhKbGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlBdUxpOHVMaTl1YjJSbFgyMXZaSFZzWlhNdlFHRnJhWFJoTFhCeWIzUnZZMjlzTDNCc2RXZHBiaTltZFc1amRHbHZibk11ZEhNNk1UUTFDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lISmxkSE4xWWdvS2NtVnJaWGxCWkdSeVpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklDNHVMeTR1TDI1dlpHVmZiVzlrZFd4bGN5OUFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6b3hORGNLSUNBZ0lDOHZJSEpsZEhWeWJpQjNZV3hzWlhRdVlXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFEyeHZjMlZQZFhSUWJIVm5hVzR1WTJ4dmMyVlBkWFJCYkdkdlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnh2YzJWUGRYUkJiR2R2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzFqYkc5elpTMXZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0MweU5Bb2dJQ0FnTHk4Z1kyeHZjMlZQZFhSQmJHZHZLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZVYnpvZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklDNHVMeTR1TDI1dlpHVmZiVzlrZFd4bGN5OUFZV3RwZEdFdGNISnZkRzlqYjJ3dmNHeDFaMmx1TDJaMWJtTjBhVzl1Y3k1MGN6b3hPUzB5TWdvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZTUXpVNFgxTlFSVTVFU1U1SFgwRkVSRkpGVTFOZlMwVlpLUW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lDOHZJQzR1THk0dUwyNXZaR1ZmYlc5a2RXeGxjeTlBWVd0cGRHRXRjSEp2ZEc5amIyd3ZjR3gxWjJsdUwyWjFibU4wYVc5dWN5NTBjem95TVFvZ0lDQWdMeThnUW5sMFpYTW9RVkpETlRoZlUxQkZUa1JKVGtkZlFVUkVVa1ZUVTE5TFJWa3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpjR1Z1WkdsdVoxOWhaR1J5WlhOeklnb2dJQ0FnTHk4Z0xpNHZMaTR2Ym05a1pWOXRiMlIxYkdWekwwQmhhMmwwWVMxd2NtOTBiMk52YkM5d2JIVm5hVzR2Wm5WdVkzUnBiMjV6TG5Sek9qRTVMVEl5Q2lBZ0lDQXZMeUJqYjI1emRDQmJjM0JsYm1ScGJtZEJaR1J5WlhOelFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkQ3dLSUNBZ0lDOHZJQ0FnUW5sMFpYTW9RVkpETlRoZlUxQkZUa1JKVGtkZlFVUkVVa1ZUVTE5TFJWa3BDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTFRNMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJR05zYjNObFZHOHNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqWVd4c2MzVmlJSEpsYTJWNVFXUmtjbVZ6Y3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWld0bGVWUnZDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOeTB6TkFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQmpiRzl6WlZSdkxBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTFRNMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJR05zYjNObFZHOHNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNSbGMzUXRZMnh2YzJVdGIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd0TWpRS0lDQWdJQzh2SUdOc2IzTmxUM1YwUVd4bmJ5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnY21WclpYbENZV05yT2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdOc2IzTmxWRzg2SUVGalkyOTFiblFLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM1JsYzNRdFkyeHZjMlV0YjNWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmxjM1JEYkc5elpVOTFkRkJzZFdkcGJpNWpiRzl6WlU5MWRFRnpjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyeHZjMlZQZFhSQmMzTmxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNSbGMzUXRZMnh2YzJVdGIzVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREl0TkRnS0lDQWdJQzh2SUdOc2IzTmxUM1YwUVhOelpYUW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFE2SUVGemMyVjBMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWVhOelpYUkRiRzl6WlZSdk9pQkJZMk52ZFc1MENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdMaTR2TGk0dmJtOWtaVjl0YjJSMWJHVnpMMEJoYTJsMFlTMXdjbTkwYjJOdmJDOXdiSFZuYVc0dlpuVnVZM1JwYjI1ekxuUnpPakU1TFRJeUNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVZKRE5UaGZVMUJGVGtSSlRrZGZRVVJFVWtWVFUxOUxSVmtwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdMeThnTGk0dkxpNHZibTlrWlY5dGIyUjFiR1Z6TDBCaGEybDBZUzF3Y205MGIyTnZiQzl3YkhWbmFXNHZablZ1WTNScGIyNXpMblJ6T2pJeENpQWdJQ0F2THlCQ2VYUmxjeWhCVWtNMU9GOVRVRVZPUkVsT1IxOUJSRVJTUlZOVFgwdEZXU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk53Wlc1a2FXNW5YMkZrWkhKbGMzTWlDaUFnSUNBdkx5QXVMaTh1TGk5dWIyUmxYMjF2WkhWc1pYTXZRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZNVGt0TWpJS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCVWtNMU9GOVRVRVZPUkVsT1IxOUJSRVJTUlZOVFgwdEZXU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0WTJ4dmMyVXRiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFdE5qQUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUTJ4dmMyVlVieXdLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcExBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOaGJHeHpkV0lnY21WclpYbEJaR1J5WlhOekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGEyVjVWRzhLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSRGJHOXpaVlJ2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeExUVTVDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nY21WalpXbDJaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVOc2IzTmxWRzhzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeExUWXdDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nY21WalpXbDJaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVOc2IzTmxWRzhzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0WTJ4dmMyVXRiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJdE5EZ0tJQ0FnSUM4dklHTnNiM05sVDNWMFFYTnpaWFFvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZWE56WlhRNklFRnpjMlYwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1lYTnpaWFJEYkc5elpWUnZPaUJCWTJOdmRXNTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUlDWUJFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTXhHMEVBSFRFWkZFUXhHRVNDQWdUemY4OFJCTlBVVkE0MkdnQ09BZ0FhQUdjQU1Sa1VNUmdVRUVPS0FnR0wva0FBQXpJRGlZdi9jZ2hFaVRZYUFVa1ZKQkpFRnpZYUFra1ZJaEpFSTFNMkdnTkpGU1VTUkRZYUJFa1ZKQkpFRnpZYUJVa1ZKUkpFU3dRb1pVaE1zVThFVHdXSS83V3lJTElKc2dDeUNMSUhJcklRSTdJQnN5SkROaG9CU1JVa0VrUVhOaG9DU1JVaUVrUWpVellhQTBrVkpCSkVGellhQkVrVkpSSkVOaG9GU1JVbEVrUkxCQ2hsU0V5eFR3UlBCWWovYUxJZ3NoVlBBcklSSTdJU3NnQ3lGSUVFc2hBanNnR3pJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
