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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdENsb3NlT3V0UGx1Z2luIiwiZGVzYyI6IlRlc3QgcGx1Z2luIGZvciBjbG9zZS1vdXQgc2NlbmFyaW9zLlxuXG5UaGlzIHBsdWdpbiBjYW46XG4tIENsb3NlIG91dCBBTEdPIGJhbGFuY2UgdG8gYSBzcGVjaWZpZWQgYWRkcmVzc1xuLSBDbG9zZSBvdXQgQVNBIGJhbGFuY2UgdG8gYSBzcGVjaWZpZWQgYWRkcmVzcyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjbG9zZU91dEFsZ28iLCJkZXNjIjoiQ2xvc2Ugb3V0IEFMR08gYmFsYW5jZSBvZiB0aGUgc3BlbmRpbmcgYWNjb3VudC5cblNlbmRzIGBhbW91bnRgIHRvIGByZWNlaXZlcmAgYW5kIG9wdGlvbmFsbHkgY2xvc2VzIHRoZSByZW1haW5pbmcgQUxHTyBiYWxhbmNlIHRvIGBjbG9zZVRvYC5cbklmIGNsb3NlVG8gZXF1YWxzIHRoZSBzZW5kZXIgKHdhbGxldCBhZGRyZXNzKSwgbm8gY2xvc2Utb3V0IGlzIHBlcmZvcm1lZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VPdXRBc3NldCIsImRlc2MiOiJDbG9zZSBvdXQgYW4gQVNBIGJhbGFuY2Ugb2YgdGhlIHNwZW5kaW5nIGFjY291bnQuXG5TZW5kcyBgYW1vdW50YCB0byBgcmVjZWl2ZXJgIGFuZCBjbG9zZXMgdGhlIHJlbWFpbmluZyBhc3NldCBiYWxhbmNlIHRvIGBhc3NldENsb3NlVG9gLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldENsb3NlVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMSwxNzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExLDEyOCwxOTcsMjA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyLDExOSwxNjksMTg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVOc2IzTmxUM1YwVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZek4yWmpaakV4SURCNFpETmtORFUwTUdVZ0x5OGdiV1YwYUc5a0lDSmpiRzl6WlU5MWRFRnNaMjhvZFdsdWREWTBMR0p2YjJ3c1lXUmtjbVZ6Y3l4MWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpiRzl6WlU5MWRFRnpjMlYwS0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR05zYjNObFQzVjBRV3huYnlCamJHOXpaVTkxZEVGemMyVjBDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OTBaWE4wTFdOc2IzTmxMVzkxZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVOc2IzTmxUM1YwVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcHlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yT2lCMWFXNTBOalFzSUhkaGJHeGxkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LY21WclpYbEJaR1J5WlhOek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvek5ERUtJQ0FnSUM4dklHVjRjRzl5ZENCbWRXNWpkR2x2YmlCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNelF5Q2lBZ0lDQXZMeUJwWmlBb0lYSmxhMlY1UW1GamF5a2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWJub2djbVZyWlhsQlpHUnlaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3pORE1LSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdjbVYwYzNWaUNncHlaV3RsZVVGa1pISmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3pORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQjNZV3hzWlhRdVlXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFEyeHZjMlZQZFhSUWJIVm5hVzR1WTJ4dmMyVlBkWFJCYkdkdlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnh2YzJWUGRYUkJiR2R2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzFqYkc5elpTMXZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0MweU5Bb2dJQ0FnTHk4Z1kyeHZjMlZQZFhSQmJHZHZLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZVYnpvZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qZzJMVEk0T1FvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakk0T0FvZ0lDQWdMeThnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qZzJMVEk0T1FvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0WTJ4dmMyVXRiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjdE16VUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nWTJ4dmMyVlVieXdLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcExBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOaGJHeHpkV0lnY21WclpYbEJaR1J5WlhOekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGEyVjVWRzhLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMV05zYjNObExXOTFkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTFRNMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJR05zYjNObFZHOHNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0WTJ4dmMyVXRiM1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjdE16VUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nWTJ4dmMyVlVieXdLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzFqYkc5elpTMXZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0MweU5Bb2dJQ0FnTHk4Z1kyeHZjMlZQZFhSQmJHZHZLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZVYnpvZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWR1Z6ZEVOc2IzTmxUM1YwVUd4MVoybHVMbU5zYjNObFQzVjBRWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiRzl6WlU5MWRFRnpjMlYwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzFqYkc5elpTMXZkWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWkwME9Bb2dJQ0FnTHk4Z1kyeHZjMlZQZFhSQmMzTmxkQ2dLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ1FYTnpaWFFzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRU5zYjNObFZHODZJRUZqWTI5MWJuUUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakk0TmkweU9Ea0tJQ0FnSUM4dklHTnZibk4wSUZ0emNHVnVaR2x1WjBGa1pISmxjM05DZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTlRjR1Z1WkdsdVowRmtaSEpsYzNNcENpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU9EZ0tJQ0FnSUM4dklFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5Od1pXNWthVzVuWDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakk0TmkweU9Ea0tJQ0FnSUM4dklHTnZibk4wSUZ0emNHVnVaR2x1WjBGa1pISmxjM05DZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTlRjR1Z1WkdsdVowRmtaSEpsYzNNcENpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTkwWlhOMExXTnNiM05sTFc5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhMVFl3Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ2NtVmpaV2wyWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFTnNiM05sVkc4c0NpQWdJQ0F2THlBZ0lDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZkR1Z6ZEMxamJHOXpaUzF2ZFhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV3RsZVZSdkNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUzAxT1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkRiRzl6WlZSdkxBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMWpiRzl6WlMxdmRYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUzAyTUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkRiRzl6WlZSdkxBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTkwWlhOMExXTnNiM05sTFc5MWRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlMVFE0Q2lBZ0lDQXZMeUJqYkc5elpVOTFkRUZ6YzJWMEtBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUdGemMyVjBPaUJCYzNObGRDd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFEyeHZjMlZVYnpvZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJSUNZQkVITndaVzVrYVc1blgyRmtaSEpsYzNNeEcwRUFIVEVaRkVReEdFU0NBZ1R6Zjg4UkJOUFVWQTQyR2dDT0FnQWFBR2NBTVJrVU1SZ1VFRU9LQWdHTC9rQUFBeklEaVl2L2NnaEVpVFlhQVVrVkpCSkVGellhQWtrVkloSkVJMU0yR2dOSkZTVVNSRFlhQkVrVkpCSkVGellhQlVrVkpSSkVTd1FvWlVoTXNVOEVUd1dJLzdXeUlMSUpzZ0N5Q0xJSElySVFJN0lCc3lKRE5ob0JTUlVrRWtRWE5ob0NTUlVpRWtRalV6WWFBMGtWSkJKRUZ6WWFCRWtWSlJKRU5ob0ZTUlVsRWtSTEJDaGxTRXl4VHdSUEJZai9hTElnc2hWUEFySVJJN0lTc2dDeUZJRUVzaEFqc2dHeklrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
