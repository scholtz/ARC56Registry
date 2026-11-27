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

namespace Arc56.Generated.akita_protocol.akita_sc.Arc58AgentProbePlugin_ab9a4aff
{


    //
    // Test-only ARC-58 plugin with two distinct, harmless ABI selectors.
    //
    //Both methods perform a zero-value self-payment and restore wallet authority.
    //Keeping the effects identical lets the conformance suite isolate method
    //allowlisting from payment and asset semantics.
    //
    //`removeGrant` is the hostile case: from inside its own window it asks the wallet,
    //as the spending account, to remove a plugin grant. The wallet must refuse.
    //
    public class Arc58AgentProbePluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc58AgentProbePluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        public async Task Allowed(ulong wallet, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 47, 114, 155 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Allowed_Transactions(ulong wallet, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 47, 114, 155 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        public async Task Forbidden(ulong wallet, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 2, 47, 184 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Forbidden_Transactions(ulong wallet, bool rekeyBack, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 2, 47, 184 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="plugin"> </param>
        /// <param name="caller"> </param>
        /// <param name="escrow"> </param>
        public async Task RemoveGrant(ulong wallet, bool rekeyBack, ulong plugin, Algorand.Address caller, string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 47, 55, 41 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, pluginAbi, callerAbi, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveGrant_Transactions(ulong wallet, bool rekeyBack, ulong plugin, Algorand.Address caller, string escrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 47, 55, 41 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var pluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pluginAbi.From(plugin);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var escrowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); escrowAbi.From(escrow);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, pluginAbi, callerAbi, escrowAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNThBZ2VudFByb2JlUGx1Z2luIiwiZGVzYyI6IlRlc3Qtb25seSBBUkMtNTggcGx1Z2luIHdpdGggdHdvIGRpc3RpbmN0LCBoYXJtbGVzcyBBQkkgc2VsZWN0b3JzLlxuXG5Cb3RoIG1ldGhvZHMgcGVyZm9ybSBhIHplcm8tdmFsdWUgc2VsZi1wYXltZW50IGFuZCByZXN0b3JlIHdhbGxldCBhdXRob3JpdHkuXG5LZWVwaW5nIHRoZSBlZmZlY3RzIGlkZW50aWNhbCBsZXRzIHRoZSBjb25mb3JtYW5jZSBzdWl0ZSBpc29sYXRlIG1ldGhvZFxuYWxsb3dsaXN0aW5nIGZyb20gcGF5bWVudCBhbmQgYXNzZXQgc2VtYW50aWNzLlxuXG5gcmVtb3ZlR3JhbnRgIGlzIHRoZSBob3N0aWxlIGNhc2U6IGZyb20gaW5zaWRlIGl0cyBvd24gd2luZG93IGl0IGFza3MgdGhlIHdhbGxldCxcbmFzIHRoZSBzcGVuZGluZyBhY2NvdW50LCB0byByZW1vdmUgYSBwbHVnaW4gZ3JhbnQuIFRoZSB3YWxsZXQgbXVzdCByZWZ1c2UuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImFsbG93ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZvcmJpZGRlbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlR3JhbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbHVnaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3JvdyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3LDE1NywyMDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OCwxNDgsMTk4LDIxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpOVGhCWjJWdWRGQnliMkpsVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoa016Sm1Oekk1WWlBd2VEUTBNREl5Wm1JNElEQjROek15WmpNM01qa2dMeThnYldWMGFHOWtJQ0poYkd4dmQyVmtLSFZwYm5RMk5DeGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVp2Y21KcFpHUmxiaWgxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlcxdmRtVkhjbUZ1ZENoMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4emRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0ZzYkc5M1pXUWdabTl5WW1sa1pHVnVJSEpsYlc5MlpVZHlZVzUwQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WVdkbGJuUXRjSEp2WW1VdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpVNFFXZGxiblJRY205aVpWQnNkV2RwYmlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem82Y21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF6b2dkV2x1ZERZMExDQjNZV3hzWlhRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuSmxhMlY1UVdSa2NtVnpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOVFkwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdablZ1WTNScGIyNGdjbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpazZJRUZqWTI5MWJuUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pVMk5Rb2dJQ0FnTHk4Z2FXWWdLQ0Z5Wld0bGVVSmhZMnNwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTU2SUhKbGEyVjVRV1JrY21WemMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRZMkNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUhKbGRITjFZZ29LY21WclpYbEJaR1J5WlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRZNUNpQWdJQ0F2THlCeVpYUjFjbTRnZDJGc2JHVjBMbUZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZV2RsYm5RdGNISnZZbVV1WVd4bmJ5NTBjem82UVhKak5UaEJaMlZ1ZEZCeWIySmxVR3gxWjJsdUxtRnNiRzkzWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhiR3h2ZDJWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZV2RsYm5RdGNISnZZbVV1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWVd4c2IzZGxaQ2gzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0cE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUTVOeTAxTURBS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT1RrS0lDQWdJQzh2SUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk53Wlc1a2FXNW5YMkZrWkhKbGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUTVOeTAxTURBS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0dWdVpHbHVaMEZrWkhKbGMzTkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3lnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzloWjJWdWRDMXdjbTlpWlM1aGJHZHZMblJ6T2pJeExUSTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklITndaVzVrYVc1blFXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2djM0JsYm1ScGJtZEJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJGblpXNTBMWEJ5YjJKbExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV3RsZVZSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyRm5aVzUwTFhCeWIySmxMbUZzWjI4dWRITTZNakV0TWpjS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nYzNCbGJtUnBibWRCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCemNHVnVaR2x1WjBGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aFoyVnVkQzF3Y205aVpTNWhiR2R2TG5Sek9qSXhMVEk0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJSE53Wlc1a2FXNW5RV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nYzNCbGJtUnBibWRCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJoYkd4dmQyVmtLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5aFkyTnZkVzUwTDJGblpXNTBMWEJ5YjJKbExtRnNaMjh1ZEhNNk9rRnlZelU0UVdkbGJuUlFjbTlpWlZCc2RXZHBiaTVtYjNKaWFXUmtaVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWIzSmlhV1JrWlc0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJtYjNKaWFXUmtaVzRvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVGN0TlRBd0NpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrNUNpQWdJQ0F2THlCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6Y0dWdVpHbHVaMTloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVGN0TlRBd0NpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJGalkyOTFiblF2WVdkbGJuUXRjSEp2WW1VdVlXeG5ieTUwY3pvek5DMDBNUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQnpjR1Z1WkdsdVowRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSE53Wlc1a2FXNW5RV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aFoyVnVkQzF3Y205aVpTNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQnlaV3RsZVVGa1pISmxjM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZV2RsYm5RdGNISnZZbVV1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWVcxdmRXNTBPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPak0wTFRRd0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUhOd1pXNWthVzVuUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2MzQmxibVJwYm1kQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0J5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdllXZGxiblF0Y0hKdlltVXVZV3huYnk1MGN6b3pOQzAwTVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlPaUJ6Y0dWdVpHbHVaMEZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhOd1pXNWthVzVuUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMkZqWTI5MWJuUXZZV2RsYm5RdGNISnZZbVV1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWm05eVltbGtaR1Z1S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWhZMk52ZFc1MEwyRm5aVzUwTFhCeWIySmxMbUZzWjI4dWRITTZPa0Z5WXpVNFFXZGxiblJRY205aVpWQnNkV2RwYmk1eVpXMXZkbVZIY21GdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYlc5MlpVZHlZVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyRmpZMjkxYm5RdllXZGxiblF0Y0hKdlltVXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdjbVZ0YjNabFIzSmhiblFvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxDQndiSFZuYVc0NklIVnBiblEyTkN3Z1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCbGMyTnliM2M2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzloWjJWdWRDMXdjbTlpWlM1aGJHZHZMblJ6T2pRMUxUVXdDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCQlluTjBjbUZqZEdWa1FXTmpiM1Z1ZEM1d2NtOTBiM1I1Y0dVdVlYSmpOVGhmY21WdGIzWmxVR3gxWjJsdVBpaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2daMlYwVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa3NDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0d2JIVm5hVzRzSUdOaGJHeGxjaXdnWlhOamNtOTNYU3dLSUNBZ0lDOHZJQ0FnY21WclpYbFViem9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtTd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRNU55MDFNREFLSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVowRmtaSEpsYzNOQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVGtLSUNBZ0lDOHZJRUo1ZEdWektFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjMU53Wlc1a2FXNW5RV1JrY21WemN5a0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRNU55MDFNREFLSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVowRmtaSEpsYzNOQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndllXTmpiM1Z1ZEM5aFoyVnVkQzF3Y205aVpTNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyRnNiSE4xWWlCeVpXdGxlVUZrWkhKbGMzTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVnJaWGxVYndvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZZV05qYjNWdWRDOWhaMlZ1ZEMxd2NtOWlaUzVoYkdkdkxuUnpPalExTFRVd0NpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJCWW5OMGNtRmpkR1ZrUVdOamIzVnVkQzV3Y205MGIzUjVjR1V1WVhKak5UaGZjbVZ0YjNabFVHeDFaMmx1UGloN0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1oyVjBVM0JsYm1ScGJtZEJZMk52ZFc1MEtIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR3YkhWbmFXNHNJR05oYkd4bGNpd2daWE5qY205M1hTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobFpXWTBORGhtWkNBdkx5QnRaWFJvYjJRZ0ltRnlZelU0WDNKbGJXOTJaVkJzZFdkcGJpaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4emRISnBibWNwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WVdOamIzVnVkQzloWjJWdWRDMXdjbTlpWlM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCeVpXMXZkbVZIY21GdWRDaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzSUhCc2RXZHBiam9nZFdsdWREWTBMQ0JqWVd4c1pYSTZJRUZqWTI5MWJuUXNJR1Z6WTNKdmR6b2djM1J5YVc1bktUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSUpnRVFjM0JsYm1ScGJtZGZZV1JrY21WemN6RWJRUUFrTVJrVVJERVlSSUlEQk5NdmNwc0VSQUl2dUFSekx6Y3BOaG9BamdNQUdnQk1BSDRBTVJrVU1SZ1VFRU9LQWdHTC9rQUFBeklEaVl2L2NnaEVpVFlhQVVrVkpCSkVGellhQWtrVkl4SkVJbE5MQVNobFNFNENzVXlJLzlDeUlDS3lDRW15QjdJQUk3SVFJcklCc3lORE5ob0JTUlVrRWtRWE5ob0NTUlVqRWtRaVUwc0JLR1ZJVGdLeFRJai9ucklnSXJJSVNiSUhzZ0Fqc2hBaXNnR3pJME0yR2dGSkZTUVNSQmMyR2dKSkZTTVNSQ0pUTmhvRFNSVWtFa1EyR2dSSkZZRWdFa1EyR2dWSklsbUJBZ2hMQVJVU1JMRkxCQ2hsU0V4UEJFc0ZpUDlMc2lCUEJMSVlUTElBZ0FUdTlFajlzaHBQQXJJYVRMSWFzaHFCQnJJUUlySUJzeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
