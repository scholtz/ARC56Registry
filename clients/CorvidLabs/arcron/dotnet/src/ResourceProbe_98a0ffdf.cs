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

namespace Arc56.Generated.CorvidLabs.arcron.ResourceProbe_98a0ffdf
{


    //
    // Reaches for an account, an asset and an app that no argument names.
    //
    public class ResourceProbeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ResourceProbeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Point the probes at an account, an asset and an app.
        ///</summary>
        /// <param name="subject"> </param>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        public async Task Configure(Algorand.Address subject, ulong asset, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 96, 84, 3 };
            var subjectAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); subjectAbi.From(subject);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, subjectAbi, assetAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(Algorand.Address subject, ulong asset, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 96, 84, 3 };
            var subjectAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); subjectAbi.From(subject);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, subjectAbi, assetAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Hold the asset, so a transfer probe fails on availability alone.
        ///</summary>
        public async Task OptInToAsset(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 199, 20, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 199, 20, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Inner payment to an address named nowhere in the call.
        ///</summary>
        public async Task<ulong> ProbePayment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 70, 33, 177 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbePayment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 70, 33, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Inner asset transfer to that same address.
        ///</summary>
        public async Task<ulong> ProbeAssetTransfer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 203, 215, 70 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbeAssetTransfer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 203, 215, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read another account's ALGO balance.
        ///</summary>
        public async Task<ulong> ProbeReadBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 45, 102, 112 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbeReadBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 45, 102, 112 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read another account's holding of an asset.
        ///</summary>
        public async Task<ulong> ProbeReadHolding(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 23, 26, 79 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbeReadHolding_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 23, 26, 79 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record the opcode budget available to this call.
        ///Called directly it reports what any app call gets; called through an Arcron upkeep it reports what a *target* gets, which is the number an integrator actually has to design against.
        ///</summary>
        public async Task<ulong> ReportBudget(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 25, 127, 108 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReportBudget_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 25, 127, 108 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///A hook with arguments of its own — the shape Arcron cannot call.
        ///Arcron stores one blob and sends it as one app arg, and an ARC-4 method with arguments needs the selector and each argument in an app arg of its own. So this method is unreachable through an upkeep today. `scripts/spike_multiarg.py` uses it to measure what a multi-arg call shape would cost, and records both arguments so that a call which loses one is distinguishable from a call that works.
        ///</summary>
        /// <param name="number"> </param>
        /// <param name="text"> </param>
        public async Task<ulong> Absorb(ulong number, string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 120, 42, 72 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, numberAbi, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Absorb_Transactions(ulong number, string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 120, 42, 72 };
            var numberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numberAbi.From(number);
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, numberAbi, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record who the target sees as its caller.
        ///Decides whether a target can pay the keeper itself: an Arcron-executed call arrives as an inner transaction, and an inner transaction's sender is the app that submitted it. Measured rather than assumed, because a whole class of design depends on it.
        ///</summary>
        public async Task<Algorand.Address> ReportCaller(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 32, 74, 169 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> ReportCaller_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 32, 74, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Point `reenter` at a keeper app and one of its upkeeps.
        ///</summary>
        /// <param name="keeper_app"> </param>
        /// <param name="upkeep_id"> </param>
        public async Task ConfigureReentry(ulong keeper_app, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 141, 144, 64 };
            var keeper_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keeper_appAbi.From(keeper_app);
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            var result = await base.CallApp(new List<object> { abiHandle, keeper_appAbi, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureReentry_Transactions(ulong keeper_app, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 141, 144, 64 };
            var keeper_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keeper_appAbi.From(keeper_app);
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, keeper_appAbi, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Call the keeper's `execute` back, from inside its own execution.
        ///Arcron writes an upkeep's state before submitting the inner call, so a re-entrant execution has to satisfy the schedule afresh. Whether that is enough to stop one — and who a nested execution pays, given the sender it sees is this app rather than the keeper — is measured in `scripts/spike_reentrancy.py` rather than argued about.
        ///Re-enters once and only once: unconditional recursion would just hit the AVM's depth limit and tell us nothing.
        ///</summary>
        public async Task<ulong> Reenter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 107, 74, 13 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Reenter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 107, 74, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Call a third app that no argument names.
        ///</summary>
        public async Task<ulong> ProbeAppCall(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 161, 218, 71 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbeAppCall_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 161, 218, 71 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVzb3VyY2VQcm9iZSIsImRlc2MiOiJSZWFjaGVzIGZvciBhbiBhY2NvdW50LCBhbiBhc3NldCBhbmQgYW4gYXBwIHRoYXQgbm8gYXJndW1lbnQgbmFtZXMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOiJQb2ludCB0aGUgcHJvYmVzIGF0IGFuIGFjY291bnQsIGFuIGFzc2V0IGFuZCBhbiBhcHAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdWJqZWN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOiJIb2xkIHRoZSBhc3NldCwgc28gYSB0cmFuc2ZlciBwcm9iZSBmYWlscyBvbiBhdmFpbGFiaWxpdHkgYWxvbmUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlX3BheW1lbnQiLCJkZXNjIjoiSW5uZXIgcGF5bWVudCB0byBhbiBhZGRyZXNzIG5hbWVkIG5vd2hlcmUgaW4gdGhlIGNhbGwuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvYmVfYXNzZXRfdHJhbnNmZXIiLCJkZXNjIjoiSW5uZXIgYXNzZXQgdHJhbnNmZXIgdG8gdGhhdCBzYW1lIGFkZHJlc3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvYmVfcmVhZF9iYWxhbmNlIiwiZGVzYyI6IlJlYWQgYW5vdGhlciBhY2NvdW50J3MgQUxHTyBiYWxhbmNlLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlX3JlYWRfaG9sZGluZyIsImRlc2MiOiJSZWFkIGFub3RoZXIgYWNjb3VudCdzIGhvbGRpbmcgb2YgYW4gYXNzZXQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVwb3J0X2J1ZGdldCIsImRlc2MiOiJSZWNvcmQgdGhlIG9wY29kZSBidWRnZXQgYXZhaWxhYmxlIHRvIHRoaXMgY2FsbC5cbkNhbGxlZCBkaXJlY3RseSBpdCByZXBvcnRzIHdoYXQgYW55IGFwcCBjYWxsIGdldHM7IGNhbGxlZCB0aHJvdWdoIGFuIEFyY3JvbiB1cGtlZXAgaXQgcmVwb3J0cyB3aGF0IGEgKnRhcmdldCogZ2V0cywgd2hpY2ggaXMgdGhlIG51bWJlciBhbiBpbnRlZ3JhdG9yIGFjdHVhbGx5IGhhcyB0byBkZXNpZ24gYWdhaW5zdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhYnNvcmIiLCJkZXNjIjoiQSBob29rIHdpdGggYXJndW1lbnRzIG9mIGl0cyBvd24g4oCUIHRoZSBzaGFwZSBBcmNyb24gY2Fubm90IGNhbGwuXG5BcmNyb24gc3RvcmVzIG9uZSBibG9iIGFuZCBzZW5kcyBpdCBhcyBvbmUgYXBwIGFyZywgYW5kIGFuIEFSQy00IG1ldGhvZCB3aXRoIGFyZ3VtZW50cyBuZWVkcyB0aGUgc2VsZWN0b3IgYW5kIGVhY2ggYXJndW1lbnQgaW4gYW4gYXBwIGFyZyBvZiBpdHMgb3duLiBTbyB0aGlzIG1ldGhvZCBpcyB1bnJlYWNoYWJsZSB0aHJvdWdoIGFuIHVwa2VlcCB0b2RheS4gYHNjcmlwdHMvc3Bpa2VfbXVsdGlhcmcucHlgIHVzZXMgaXQgdG8gbWVhc3VyZSB3aGF0IGEgbXVsdGktYXJnIGNhbGwgc2hhcGUgd291bGQgY29zdCwgYW5kIHJlY29yZHMgYm90aCBhcmd1bWVudHMgc28gdGhhdCBhIGNhbGwgd2hpY2ggbG9zZXMgb25lIGlzIGRpc3Rpbmd1aXNoYWJsZSBmcm9tIGEgY2FsbCB0aGF0IHdvcmtzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1iZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBvcnRfY2FsbGVyIiwiZGVzYyI6IlJlY29yZCB3aG8gdGhlIHRhcmdldCBzZWVzIGFzIGl0cyBjYWxsZXIuXG5EZWNpZGVzIHdoZXRoZXIgYSB0YXJnZXQgY2FuIHBheSB0aGUga2VlcGVyIGl0c2VsZjogYW4gQXJjcm9uLWV4ZWN1dGVkIGNhbGwgYXJyaXZlcyBhcyBhbiBpbm5lciB0cmFuc2FjdGlvbiwgYW5kIGFuIGlubmVyIHRyYW5zYWN0aW9uJ3Mgc2VuZGVyIGlzIHRoZSBhcHAgdGhhdCBzdWJtaXR0ZWQgaXQuIE1lYXN1cmVkIHJhdGhlciB0aGFuIGFzc3VtZWQsIGJlY2F1c2UgYSB3aG9sZSBjbGFzcyBvZiBkZXNpZ24gZGVwZW5kcyBvbiBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZmlndXJlX3JlZW50cnkiLCJkZXNjIjoiUG9pbnQgYHJlZW50ZXJgIGF0IGEga2VlcGVyIGFwcCBhbmQgb25lIG9mIGl0cyB1cGtlZXBzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZWVwZXJfYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGtlZXBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVlbnRlciIsImRlc2MiOiJDYWxsIHRoZSBrZWVwZXIncyBgZXhlY3V0ZWAgYmFjaywgZnJvbSBpbnNpZGUgaXRzIG93biBleGVjdXRpb24uXG5BcmNyb24gd3JpdGVzIGFuIHVwa2VlcCdzIHN0YXRlIGJlZm9yZSBzdWJtaXR0aW5nIHRoZSBpbm5lciBjYWxsLCBzbyBhIHJlLWVudHJhbnQgZXhlY3V0aW9uIGhhcyB0byBzYXRpc2Z5IHRoZSBzY2hlZHVsZSBhZnJlc2guIFdoZXRoZXIgdGhhdCBpcyBlbm91Z2ggdG8gc3RvcCBvbmUg4oCUIGFuZCB3aG8gYSBuZXN0ZWQgZXhlY3V0aW9uIHBheXMsIGdpdmVuIHRoZSBzZW5kZXIgaXQgc2VlcyBpcyB0aGlzIGFwcCByYXRoZXIgdGhhbiB0aGUga2VlcGVyIOKAlCBpcyBtZWFzdXJlZCBpbiBgc2NyaXB0cy9zcGlrZV9yZWVudHJhbmN5LnB5YCByYXRoZXIgdGhhbiBhcmd1ZWQgYWJvdXQuXG5SZS1lbnRlcnMgb25jZSBhbmQgb25seSBvbmNlOiB1bmNvbmRpdGlvbmFsIHJlY3Vyc2lvbiB3b3VsZCBqdXN0IGhpdCB0aGUgQVZNJ3MgZGVwdGggbGltaXQgYW5kIHRlbGwgdXMgbm90aGluZy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9iZV9hcHBfY2FsbCIsImRlc2MiOiJDYWxsIGEgdGhpcmQgYXBwIHRoYXQgbm8gYXJndW1lbnQgbmFtZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjcsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MzVdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MV0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgb3B0ZWQgaW50byBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYua2VlcGVyX2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmtlZXBlcl91cGtlZXAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxLDQ4Nyw1MTEsNTcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sYXN0X3JlYWRpbmcgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0LDQxNSw0NDIsNDc4LDUwMiw1NjEsNTg2LDYzMSw2NDYsNjkyLDcyNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJvYmVzX3J1biBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTgsMzk3LDQzMiw0NjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN1YmplY3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdWJqZWN0X2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzUsMzkzLDQ2M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3ViamVjdF9hc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNCwzMTMsNTI2LDYwNiw2MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQTBDaUFnSUNCaWVYUmxZMkpzYjJOcklDSndjbTlpWlhOZmNuVnVJaUFpYkdGemRGOXlaV0ZrYVc1bklpQXdlREUxTVdZM1l6YzFJQ0p6ZFdKcVpXTjBJaUFpYzNWaWFtVmpkRjloYzNObGRDSWdJbk4xWW1wbFkzUmZZWEJ3SWlBaWEyVmxjR1Z5WDJGd2NDSWdJbXRsWlhCbGNsOTFjR3RsWlhBaUlDSnNZWE4wWDI1MWJXSmxjaUlnSW14aGMzUmZkR1Y0ZENJZ0lteGhjM1JmWTJGc2JHVnlJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pNMUxUTTRDaUFnSUNBdkx5QWpJRlJvWlNCeVpYTnZkWEpqWlhNZ2RHOGdjbVZoWTJnZ1ptOXlMQ0JtYVhobFpDQmhkQ0JqYjI1bWFXZDFjbUYwYVc5dUlIUnBiV1VnYzI4Z2RHaGhkQ0JoQ2lBZ0lDQXZMeUFqSUhCeWIySmxJR05oYkd3Z1kyRnljbWxsY3lCdWIzUm9hVzVuSUdKMWRDQnBkSE1nYjNkdUlITmxiR1ZqZEc5eUlPS0FsQ0JsZUdGamRHeDVJSFJvWlNCemFHRndaUW9nSUNBZ0x5OGdJeUJCY21OeWIyNGdZMkZ1SUhObGJtUXVDaUFnSUNBdkx5QnpaV3htTG5OMVltcGxZM1FnUFNCSGJHOWlZV3hUZEdGMFpTaEJZMk52ZFc1MEtDa3BDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpkV0pxWldOMElnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPak01Q2lBZ0lDQXZMeUJ6Wld4bUxuTjFZbXBsWTNSZllYTnpaWFFnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnpkV0pxWldOMFgyRnpjMlYwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJSE5sYkdZdWMzVmlhbVZqZEY5aGNIQWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKemRXSnFaV04wWDJGd2NDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pReExUUXlDaUFnSUNBdkx5QWpJRVYyYVdSbGJtTmxJR0VnY0hKdlltVWdjbUZ1TENCbWIzSWdkR2hsSUdOaGMyVnpJSGRvWlhKbElITjFZMk5sYzNNZ2FYTWdjMmxzWlc1MExnb2dJQ0FnTHk4Z2MyVnNaaTV3Y205aVpYTmZjblZ1SUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljSEp2WW1WelgzSjFiaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjbVZoWkdsdVp5QTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW14aGMzUmZjbVZoWkdsdVp5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pRMExUUTJDaUFnSUNBdkx5QWpJRmRvWVhRZ1lHRmljMjl5WW1BZ2QyRnpJR2hoYm1SbFpDd2djMjhnWVNCdGRXeDBhUzFoY21jZ1kyRnNiQ0JqWVc0Z1ltVWdZMmhsWTJ0bFpDQm1iM0lLSUNBZ0lDOHZJQ01nYUdGMmFXNW5JR1JsYkdsMlpYSmxaQ0JsZG1WeWVTQmhjbWQxYldWdWRDQnlZWFJvWlhJZ2RHaGhiaUJ0WlhKbGJIa2djM1ZqWTJWbFpHbHVaeTRLSUNBZ0lDOHZJSE5sYkdZdWJHRnpkRjl1ZFcxaVpYSWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKc1lYTjBYMjUxYldKbGNpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCelpXeG1MbXhoYzNSZmRHVjRkQ0E5SUVkc2IySmhiRk4wWVhSbEtGTjBjbWx1WnlnaUlpa3BDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnNZWE4wWDNSbGVIUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5EZ3ROVEFLSUNBZ0lDOHZJQ01nVjJodklIUm9aU0IwWVhKblpYUWdjMlZsY3lCaGN5QnBkSE1nWTJGc2JHVnlMQ0IzYUdsamFDQnBjeUJ1YjNRZ2QyaHZJSE5sYm5RZ2RHaGxDaUFnSUNBdkx5QWpJSFJ5WVc1ellXTjBhVzl1SUc5dVkyVWdRWEpqY205dUlHbHpJR2x1SUhSb1pTQnRhV1JrYkdVdUNpQWdJQ0F2THlCelpXeG1MbXhoYzNSZlkyRnNiR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVW9RV05qYjNWdWRDZ3BLUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbXhoYzNSZlkyRnNiR1Z5SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qVXhMVFV5Q2lBZ0lDQXZMeUFqSUVFZ2EyVmxjR1Z5SUdGd2NDQmhibVFnYjI1bElHOW1JR2wwY3lCMWNHdGxaWEJ6TENCbWIzSWdkR2hsSUhKbExXVnVkSEpoYm1ONUlIQnliMkpsTGdvZ0lDQWdMeThnYzJWc1ppNXJaV1Z3WlhKZllYQndJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWEyVmxjR1Z5WDJGd2NDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCelpXeG1MbXRsWlhCbGNsOTFjR3RsWlhBZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pyWldWd1pYSmZkWEJyWldWd0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VtVnpiM1Z5WTJWUWNtOWlaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGc0TmpBMU5EQXpJREI0TkRWak56RTBNVGtnTUhnME5qUTJNakZpTVNBd2VESXhZMkprTnpRMklEQjRZMlF5WkRZMk56QWdNSGhtWVRFM01XRTBaaUF3ZUdSak1UazNaalpqSURCNFkySTNPREpoTkRnZ01IaGtaREl3TkdGaE9TQXdlRGN4T0dRNU1EUXdJREI0WWpVMllqUmhNR1FnTUhobFpHRXhaR0UwTnlBdkx5QnRaWFJvYjJRZ0ltTnZibVpwWjNWeVpTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0IwWDJsdVgzUnZYMkZ6YzJWMEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKd2NtOWlaVjl3WVhsdFpXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkJ5YjJKbFgyRnpjMlYwWDNSeVlXNXpabVZ5S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5CeWIySmxYM0psWVdSZlltRnNZVzVqWlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKd2NtOWlaVjl5WldGa1gyaHZiR1JwYm1jb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNtVndiM0owWDJKMVpHZGxkQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0poWW5OdmNtSW9kV2x1ZERZMExITjBjbWx1WnlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5KbGNHOXlkRjlqWVd4c1pYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbU52Ym1acFozVnlaVjl5WldWdWRISjVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbGJuUmxjaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p3Y205aVpWOWhjSEJmWTJGc2JDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZMjl1Wm1sbmRYSmxJRzl3ZEY5cGJsOTBiMTloYzNObGRDQndjbTlpWlY5d1lYbHRaVzUwSUhCeWIySmxYMkZ6YzJWMFgzUnlZVzV6Wm1WeUlIQnliMkpsWDNKbFlXUmZZbUZzWVc1alpTQndjbTlpWlY5eVpXRmtYMmh2YkdScGJtY2djbVZ3YjNKMFgySjFaR2RsZENCaFluTnZjbUlnY21Wd2IzSjBYMk5oYkd4bGNpQmpiMjVtYVdkMWNtVmZjbVZsYm5SeWVTQnlaV1Z1ZEdWeUlIQnliMkpsWDJGd2NGOWpZV3hzQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qRTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpYTnZkWEpqWlY5d2NtOWlaUzVqYjI1MGNtRmpkQzVTWlhOdmRYSmpaVkJ5YjJKbExtTnZibVpwWjNWeVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52Ym1acFozVnlaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUhObGJHWXVjM1ZpYW1WamRDNTJZV3gxWlNBOUlITjFZbXBsWTNRdWJtRjBhWFpsQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZFdKcVpXTjBJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCelpXeG1Mbk4xWW1wbFkzUmZZWE56WlhRdWRtRnNkV1VnUFNCaGMzTmxkQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljM1ZpYW1WamRGOWhjM05sZENJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjMlZzWmk1emRXSnFaV04wWDJGd2NDNTJZV3gxWlNBOUlHRndjQW9nSUNBZ1lubDBaV01nTlNBdkx5QWljM1ZpYW1WamRGOWhjSEFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ6YjNWeVkyVmZjSEp2WW1VdVkyOXVkSEpoWTNRdVVtVnpiM1Z5WTJWUWNtOWlaUzV2Y0hSZmFXNWZkRzlmWVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSZmFXNWZkRzlmWVhOelpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5qY3ROekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYTmxiR1l1YzNWaWFtVmpkRjloYzNObGRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QjRabVZ5WDJGemMyVjBQWE5sYkdZdWMzVmlhbVZqZEY5aGMzTmxkQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKemRXSnFaV04wWDJGemMyVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMVltcGxZM1JmWVhOelpYUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5qY3ROekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYTmxiR1l1YzNWaWFtVmpkRjloYzNObGRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVjSEp2WW1WZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnliMkpsWDNCaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENoeVpXTmxhWFpsY2oxelpXeG1Mbk4xWW1wbFkzUXVkbUZzZFdVc0lHRnRiM1Z1ZEQwd0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk4xWW1wbFkzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNWaWFtVmpkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QnpaV3htTG5CeWIySmxjMTl5ZFc0dWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3Y205aVpYTmZjblZ1SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOdmRYSmpaVjl3Y205aVpTNWpiMjUwY21GamRDNVNaWE52ZFhKalpWQnliMkpsTG5CeWIySmxYMkZ6YzJWMFgzUnlZVzV6Wm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2WW1WZllYTnpaWFJmZEhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZPRE10T0RjS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdWMzVmlhbVZqZEY5aGMzTmxkQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMXpaV3htTG5OMVltcGxZM1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROWMyVnNaaTV6ZFdKcVpXTjBYMkZ6YzJWMExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbk4xWW1wbFkzUmZZWE56WlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1ZpYW1WamRGOWhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOWMyVnNaaTV6ZFdKcVpXTjBMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5OMVltcGxZM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzVmlhbVZqZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qZ3pMVGczQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG5OMVltcGxZM1JmWVhOelpYUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWMyVnNaaTV6ZFdKcVpXTjBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIySmxjMTl5ZFc0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVnpiM1Z5WTJWZmNISnZZbVV1WTI5dWRISmhZM1F1VW1WemIzVnlZMlZRY205aVpTNXdjbTlpWlY5eVpXRmtYMkpoYkdGdVkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3Y205aVpWOXlaV0ZrWDJKaGJHRnVZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJSE5sYkdZdWJHRnpkRjl5WldGa2FXNW5MblpoYkhWbElEMGdjMlZzWmk1emRXSnFaV04wTG5aaGJIVmxMbUpoYkdGdVkyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRXSnFaV04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjFZbXBsWTNRZ1pYaHBjM1J6Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliR0Z6ZEY5eVpXRmthVzVuSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIySmxjMTl5ZFc0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbXhoYzNSZmNtVmhaR2x1Wnk1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lteGhjM1JmY21WaFpHbHVaeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c1lYTjBYM0psWVdScGJtY2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOdmRYSmpaVjl3Y205aVpTNWpiMjUwY21GamRDNVNaWE52ZFhKalpWQnliMkpsTG5CeWIySmxYM0psWVdSZmFHOXNaR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnliMkpsWDNKbFlXUmZhRzlzWkdsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlYwSUQwZ1FYTnpaWFFvYzJWc1ppNXpkV0pxWldOMFgyRnpjMlYwTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTjFZbXBsWTNSZllYTnpaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzVmlhbVZqZEY5aGMzTmxkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklITmxiR1l1YkdGemRGOXlaV0ZrYVc1bkxuWmhiSFZsSUQwZ1lYTnpaWFF1WW1Gc1lXNWpaU2h6Wld4bUxuTjFZbXBsWTNRdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljM1ZpYW1WamRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZFdKcVpXTjBJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0J2Y0hSbFpDQnBiblJ2SUdGemMyVjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnNZWE4wWDNKbFlXUnBibWNpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIySmxjMTl5ZFc0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVzWVhOMFgzSmxZV1JwYm1jdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnNZWE4wWDNKbFlXUnBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHRnpkRjl5WldGa2FXNW5JR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21WemIzVnlZMlZmY0hKdlltVXVZMjl1ZEhKaFkzUXVVbVZ6YjNWeVkyVlFjbTlpWlM1eVpYQnZjblJmWW5Wa1oyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21Wd2IzSjBYMkoxWkdkbGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklITmxiR1l1YkdGemRGOXlaV0ZrYVc1bkxuWmhiSFZsSUQwZ1IyeHZZbUZzTG05d1kyOWtaVjlpZFdSblpYUW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliR0Z6ZEY5eVpXRmthVzVuSWdvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJSE5sYkdZdWNISnZZbVZ6WDNKMWJpNTJZV3gxWlNBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205aVpYTmZjblZ1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXViR0Z6ZEY5eVpXRmthVzVuTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJHRnpkRjl5WldGa2FXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14aGMzUmZjbVZoWkdsdVp5QmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOdmRYSmpaVjl3Y205aVpTNWpiMjUwY21GamRDNVNaWE52ZFhKalpWQnliMkpsTG1GaWMyOXlZbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GaWMyOXlZam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hNamt0TVRNeENpQWdJQ0F2THlBaklGSmxZV1FnZEdobElHSjFaR2RsZENCbWFYSnpkQ3dnYzI4Z2RHaHBjeUJwY3lCamIyMXdZWEpoWW14bElIZHBkR2dnWUhKbGNHOXlkRjlpZFdSblpYUmdPZ29nSUNBZ0x5OGdJeUJpYjNSb0lISmxjRzl5ZENCM2FHRjBJSFJvWlNCMFlYSm5aWFFnZDJGeklHaGhibVJsWkN3Z2JtOTBJSGRvWVhRZ2FYUWdhR0Z6SUd4bFpuUXVDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjbVZoWkdsdVp5NTJZV3gxWlNBOUlFZHNiMkpoYkM1dmNHTnZaR1ZmWW5Wa1oyVjBLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXhoYzNSZmNtVmhaR2x1WnlJS0lDQWdJR2RzYjJKaGJDQlBjR052WkdWQ2RXUm5aWFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVE15Q2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmYm5WdFltVnlMblpoYkhWbElEMGdiblZ0WW1WeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKc1lYTjBYMjUxYldKbGNpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUhObGJHWXViR0Z6ZEY5MFpYaDBMblpoYkhWbElEMGdkR1Y0ZEM1dVlYUnBkbVVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnNZWE4wWDNSbGVIUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRXpOQW9nSUNBZ0x5OGdjMlZzWmk1d2NtOWlaWE5mY25WdUxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOWlaWE5mY25WdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjJKbGMxOXlkVzRnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXNZWE4wWDNKbFlXUnBibWN1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc1lYTjBYM0psWVdScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YkdGemRGOXlaV0ZrYVc1bklHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsYzI5MWNtTmxYM0J5YjJKbExtTnZiblJ5WVdOMExsSmxjMjkxY21ObFVISnZZbVV1Y21Wd2IzSjBYMk5oYkd4bGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsY0c5eWRGOWpZV3hzWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRRMkNpQWdJQ0F2THlCelpXeG1MbXhoYzNSZlkyRnNiR1Z5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW14aGMzUmZZMkZzYkdWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUhObGJHWXVjSEp2WW1WelgzSjFiaTUyWVd4MVpTQXJQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljSEp2WW1WelgzSjFiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtOWlaWE5mY25WdUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luQnliMkpsYzE5eWRXNGlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ6YjNWeVkyVmZjSEp2WW1VdVkyOXVkSEpoWTNRdVVtVnpiM1Z5WTJWUWNtOWlaUzVqYjI1bWFXZDFjbVZmY21WbGJuUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJtWnBaM1Z5WlY5eVpXVnVkSEo1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVFV6Q2lBZ0lDQXZMeUJ6Wld4bUxtdGxaWEJsY2w5aGNIQXVkbUZzZFdVZ1BTQnJaV1Z3WlhKZllYQndDaUFnSUNCaWVYUmxZeUEySUM4dklDSnJaV1Z3WlhKZllYQndJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFMU5Bb2dJQ0FnTHk4Z2MyVnNaaTVyWldWd1pYSmZkWEJyWldWd0xuWmhiSFZsSUQwZ2RYQnJaV1Z3WDJsa0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKclpXVndaWEpmZFhCclpXVndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE52ZFhKalpWOXdjbTlpWlM1amIyNTBjbUZqZEM1U1pYTnZkWEpqWlZCeWIySmxMbkpsWlc1MFpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldWdWRHVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdjMlZzWmk1d2NtOWlaWE5mY25WdUxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOWlaWE5mY25WdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjJKbGMxOXlkVzRnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFM01Bb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1d2NtOWlaWE5mY25WdUxuWmhiSFZsSUQ0Z01Ub0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0ErQ2lBZ0lDQmllaUJ5WldWdWRHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFM01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjSEp2WW1WelgzSjFiaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtDbkpsWlc1MFpYSmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11Y21WemIzVnlZMlZmY0hKdlltVXVZMjl1ZEhKaFkzUXVVbVZ6YjNWeVkyVlFjbTlpWlM1eVpXVnVkR1Z5UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRVMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsWlc1MFpYSmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFM01pMHhOemtLSUNBZ0lDOHZJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG10bFpYQmxjbDloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2laWGhsWTNWMFpTaDFhVzUwTmpRcGRXbHVkRFkwSWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtbDBiMklvYzJWc1ppNXJaV1Z3WlhKZmRYQnJaV1Z3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJRzl1WDJOdmJYQnNaWFJwYjI0OVQyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFM013b2dJQ0FnTHk4Z1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1YTJWbGNHVnlYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlhMlZsY0dWeVgyRndjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1clpXVndaWEpmWVhCd0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakUzTmdvZ0lDQWdMeThnYjNBdWFYUnZZaWh6Wld4bUxtdGxaWEJsY2w5MWNHdGxaWEF1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltdGxaWEJsY2w5MWNHdGxaWEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWEyVmxjR1Z5WDNWd2EyVmxjQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE56Z0tJQ0FnSUM4dklHOXVYMk52YlhCc1pYUnBiMjQ5VDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0xBb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UYzFDaUFnSUNBdkx5QmhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0psZUdWamRYUmxLSFZwYm5RMk5DbDFhVzUwTmpRaUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVmlORGxqWXpWaklDOHZJRzFsZEdodlpDQWlaWGhsWTNWMFpTaDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TnpJS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFM01pMHhOemtLSUNBZ0lDOHZJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG10bFpYQmxjbDloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2laWGhsWTNWMFpTaDFhVzUwTmpRcGRXbHVkRFkwSWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtbDBiMklvYzJWc1ppNXJaV1Z3WlhKZmRYQnJaV1Z3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJRzl1WDJOdmJYQnNaWFJwYjI0OVQyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbkJ5YjJKbGMxOXlkVzR1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOWlaWE5mY25WdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjJKbGMxOXlkVzRnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdjbVZsYm5SbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOdmRYSmpaVjl3Y205aVpTNWpiMjUwY21GamRDNVNaWE52ZFhKalpWQnliMkpsTG5KbFpXNTBaWEpBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE52ZFhKalpWOXdjbTlpWlM1amIyNTBjbUZqZEM1U1pYTnZkWEpqWlZCeWIySmxMbkJ5YjJKbFgyRndjRjlqWVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2WW1WZllYQndYMk5oYkd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRnMUxURTRPUW9nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1YzNWaWFtVmpkRjloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTaGhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0owYVdOcktDbDFhVzUwTmpRaUtTd3BMQW9nSUNBZ0x5OGdJQ0FnSUc5dVgyTnZiWEJzWlhScGIyNDlUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSE5sYkdZdWMzVmlhbVZqZEY5aGNIQXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5OMVltcGxZM1JmWVhCd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4xWW1wbFkzUmZZWEJ3SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTRPQW9nSUNBZ0x5OGdiMjVmWTI5dGNHeGxkR2x2YmoxUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQXNDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hPRGNLSUNBZ0lDOHZJR0Z3Y0Y5aGNtZHpQU2hoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0NKMGFXTnJLQ2wxYVc1ME5qUWlLU3dwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdRMFpEVm1NR0lnTHk4Z2JXVjBhRzlrSUNKMGFXTnJLQ2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRnMUNpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE9EVXRNVGc1Q2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1emRXSnFaV04wWDJGd2NDNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJGeVozTTlLR0Z5WXpRdVlYSmpORjl6YVdkdVlYUjFjbVVvSW5ScFkyc29LWFZwYm5RMk5DSXBMQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2IyNWZZMjl0Y0d4bGRHbHZiajFQYmtOdmJYQnNaWFJsUVdOMGFXOXVMazV2VDNBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIySmxjMTl5ZFc0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJQkNZTENuQnliMkpsYzE5eWRXNE1iR0Z6ZEY5eVpXRmthVzVuQkJVZmZIVUhjM1ZpYW1WamRBMXpkV0pxWldOMFgyRnpjMlYwQzNOMVltcGxZM1JmWVhCd0NtdGxaWEJsY2w5aGNIQU5hMlZsY0dWeVgzVndhMlZsY0F0c1lYTjBYMjUxYldKbGNnbHNZWE4wWDNSbGVIUUxiR0Z6ZEY5allXeHNaWEl4R0VBQUtDc3lBMmNuQkNKbkp3VWlaeWdpWnlraVp5Y0lJbWNuQ1lBQVp5Y0tNZ05uSndZaVp5Y0hJbWN4RzBFQVl6RVpGRVF4R0VTQ0RBU0lZRlFEQkVYSEZCa0VSa1loc1FRaHk5ZEdCTTB0Wm5BRStoY2FUd1RjR1g5c0JNdDRLa2dFM1NCS3FRUnhqWkJBQkxWclNnMEU3YUhhUnpZYUFJNE1BQWtBTXdCTEFHMEFsZ0MwQU5nQThBRXJBVUFCWFFHaEFERVpGREVZRkJCRE5ob0JTUldCSUJKRU5ob0NTUlVrRWtRWE5ob0RTUlVrRWtRWEswOERaeWNFVHdKbkp3Vk1aeU5Ec1NJbkJHVkVNZ29pc2hLeUZMSVJKYklRSXJJQnN5TkRzU0lyWlVRaXNnaXlCeU95RUNLeUFiTWlLR1ZFSXdnb1N3Rm5GaXBNVUxBalE3RWlKd1JsUkNJclpVUWlzaEt5RkxJUkpiSVFJcklCc3lJb1pVUWpDQ2hMQVdjV0treFFzQ05ESWl0bFJITUFSQ2xNWnlJb1pVUWpDQ2hNWnlJcFpVUVdLa3hRc0NORElpY0VaVVFpSzJWRVRIQUFSQ2xNWnlJb1pVUWpDQ2hNWnlJcFpVUVdLa3hRc0NOREtUSU1aeUlvWlVRakNDaE1aeUlwWlVRV0treFFzQ05ETmhvQlNSVWtFa1FYTmhvQ1NTSlpnUUlJU3dFVkVrUXBNZ3huSndoUEFtZFhBZ0FuQ1V4bklpaGxSQ01JS0V4bklpbGxSQllxVEZDd0kwTW5DakVBWnlJb1pVUWpDQ2hNWnlveEFGQ3dJME0yR2dGSkZTUVNSQmMyR2dKSkZTUVNSQmNuQms4Q1p5Y0hUR2NqUXlJb1pVUWpDQ2hMQVdjakRVRUFDeUlvWlVRV0treFFzQ05Ec1NJbkJtVkVJaWNIWlVRV0lySVpnQVJiU2N4Y3NocXlHcklZZ1FheUVDS3lBYk1pS0dWRVF2L1BzU0luQldWRUlySVpnQVJOVFY4THNocXlHSUVHc2hBaXNnR3pJaWhsUkNNSUtFc0JaeFlxVEZDd0kwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
