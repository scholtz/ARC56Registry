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
        ///Record the group this call arrived in, as the target sees it.
        ///Arcron puts no constraint on the group its `execute` is submitted in, so a keeper is free to bracket the call it is paid to make with transactions of its own. Whether the target can *tell* is the whole question: if it can see the outer group it can defend itself, and if it cannot then the defence has to be in the target's own state. Recorded rather than asserted, because both answers are possible depending on how the call arrived, and the answer is the measurement.
        ///</summary>
        public async Task<ulong> ReportGroup(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 133, 142, 207 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReportGroup_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 133, 142, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Spend more opcode budget than any keeper could have brought.
        ///A target that costs more than it is worth is the cheapest way to attack a keeper, if failing costs the keeper anything.
        ///</summary>
        public async Task<ulong> ExhaustBudget(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 38, 254, 174 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExhaustBudget_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 38, 254, 174 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reject every call, the way a target with a bug or a grudge would.
        ///</summary>
        public async Task Refuse(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 192, 228, 108 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refuse_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 192, 228, 108 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set how long `guarded` locks itself for after a call.
        ///</summary>
        /// <param name="gap"> </param>
        public async Task SetGap(ulong gap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 133, 94, 1 };
            var gapAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gapAbi.From(gap);

            var result = await base.CallApp(new List<object> { abiHandle, gapAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGap_Transactions(ulong gap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 133, 94, 1 };
            var gapAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gapAbi.From(gap);

            return await base.MakeTransactionList(new List<object> { abiHandle, gapAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Refuse a second call inside `gap` rounds.
        ///Not an exotic target: an oracle that rejects a stale update, a rebalancer that runs once an epoch, a claim that pays once a period. Anything whose call is conditional on state a third party can move. This is the shape that lets somebody manufacture the lateness Arcron's fee escalation pays for, which `scripts/spike_hostile_target.py` measures.
        ///</summary>
        public async Task<ulong> Guarded(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 21, 95, 73 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Guarded_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 21, 95, 73 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVzb3VyY2VQcm9iZSIsImRlc2MiOiJSZWFjaGVzIGZvciBhbiBhY2NvdW50LCBhbiBhc3NldCBhbmQgYW4gYXBwIHRoYXQgbm8gYXJndW1lbnQgbmFtZXMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOiJQb2ludCB0aGUgcHJvYmVzIGF0IGFuIGFjY291bnQsIGFuIGFzc2V0IGFuZCBhbiBhcHAuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdWJqZWN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOiJIb2xkIHRoZSBhc3NldCwgc28gYSB0cmFuc2ZlciBwcm9iZSBmYWlscyBvbiBhdmFpbGFiaWxpdHkgYWxvbmUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlX3BheW1lbnQiLCJkZXNjIjoiSW5uZXIgcGF5bWVudCB0byBhbiBhZGRyZXNzIG5hbWVkIG5vd2hlcmUgaW4gdGhlIGNhbGwuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvYmVfYXNzZXRfdHJhbnNmZXIiLCJkZXNjIjoiSW5uZXIgYXNzZXQgdHJhbnNmZXIgdG8gdGhhdCBzYW1lIGFkZHJlc3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvYmVfcmVhZF9iYWxhbmNlIiwiZGVzYyI6IlJlYWQgYW5vdGhlciBhY2NvdW50J3MgQUxHTyBiYWxhbmNlLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlX3JlYWRfaG9sZGluZyIsImRlc2MiOiJSZWFkIGFub3RoZXIgYWNjb3VudCdzIGhvbGRpbmcgb2YgYW4gYXNzZXQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVwb3J0X2J1ZGdldCIsImRlc2MiOiJSZWNvcmQgdGhlIG9wY29kZSBidWRnZXQgYXZhaWxhYmxlIHRvIHRoaXMgY2FsbC5cbkNhbGxlZCBkaXJlY3RseSBpdCByZXBvcnRzIHdoYXQgYW55IGFwcCBjYWxsIGdldHM7IGNhbGxlZCB0aHJvdWdoIGFuIEFyY3JvbiB1cGtlZXAgaXQgcmVwb3J0cyB3aGF0IGEgKnRhcmdldCogZ2V0cywgd2hpY2ggaXMgdGhlIG51bWJlciBhbiBpbnRlZ3JhdG9yIGFjdHVhbGx5IGhhcyB0byBkZXNpZ24gYWdhaW5zdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhYnNvcmIiLCJkZXNjIjoiQSBob29rIHdpdGggYXJndW1lbnRzIG9mIGl0cyBvd24g4oCUIHRoZSBzaGFwZSBBcmNyb24gY2Fubm90IGNhbGwuXG5BcmNyb24gc3RvcmVzIG9uZSBibG9iIGFuZCBzZW5kcyBpdCBhcyBvbmUgYXBwIGFyZywgYW5kIGFuIEFSQy00IG1ldGhvZCB3aXRoIGFyZ3VtZW50cyBuZWVkcyB0aGUgc2VsZWN0b3IgYW5kIGVhY2ggYXJndW1lbnQgaW4gYW4gYXBwIGFyZyBvZiBpdHMgb3duLiBTbyB0aGlzIG1ldGhvZCBpcyB1bnJlYWNoYWJsZSB0aHJvdWdoIGFuIHVwa2VlcCB0b2RheS4gYHNjcmlwdHMvc3Bpa2VfbXVsdGlhcmcucHlgIHVzZXMgaXQgdG8gbWVhc3VyZSB3aGF0IGEgbXVsdGktYXJnIGNhbGwgc2hhcGUgd291bGQgY29zdCwgYW5kIHJlY29yZHMgYm90aCBhcmd1bWVudHMgc28gdGhhdCBhIGNhbGwgd2hpY2ggbG9zZXMgb25lIGlzIGRpc3Rpbmd1aXNoYWJsZSBmcm9tIGEgY2FsbCB0aGF0IHdvcmtzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1iZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBvcnRfY2FsbGVyIiwiZGVzYyI6IlJlY29yZCB3aG8gdGhlIHRhcmdldCBzZWVzIGFzIGl0cyBjYWxsZXIuXG5EZWNpZGVzIHdoZXRoZXIgYSB0YXJnZXQgY2FuIHBheSB0aGUga2VlcGVyIGl0c2VsZjogYW4gQXJjcm9uLWV4ZWN1dGVkIGNhbGwgYXJyaXZlcyBhcyBhbiBpbm5lciB0cmFuc2FjdGlvbiwgYW5kIGFuIGlubmVyIHRyYW5zYWN0aW9uJ3Mgc2VuZGVyIGlzIHRoZSBhcHAgdGhhdCBzdWJtaXR0ZWQgaXQuIE1lYXN1cmVkIHJhdGhlciB0aGFuIGFzc3VtZWQsIGJlY2F1c2UgYSB3aG9sZSBjbGFzcyBvZiBkZXNpZ24gZGVwZW5kcyBvbiBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZmlndXJlX3JlZW50cnkiLCJkZXNjIjoiUG9pbnQgYHJlZW50ZXJgIGF0IGEga2VlcGVyIGFwcCBhbmQgb25lIG9mIGl0cyB1cGtlZXBzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZWVwZXJfYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGtlZXBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVlbnRlciIsImRlc2MiOiJDYWxsIHRoZSBrZWVwZXIncyBgZXhlY3V0ZWAgYmFjaywgZnJvbSBpbnNpZGUgaXRzIG93biBleGVjdXRpb24uXG5BcmNyb24gd3JpdGVzIGFuIHVwa2VlcCdzIHN0YXRlIGJlZm9yZSBzdWJtaXR0aW5nIHRoZSBpbm5lciBjYWxsLCBzbyBhIHJlLWVudHJhbnQgZXhlY3V0aW9uIGhhcyB0byBzYXRpc2Z5IHRoZSBzY2hlZHVsZSBhZnJlc2guIFdoZXRoZXIgdGhhdCBpcyBlbm91Z2ggdG8gc3RvcCBvbmUg4oCUIGFuZCB3aG8gYSBuZXN0ZWQgZXhlY3V0aW9uIHBheXMsIGdpdmVuIHRoZSBzZW5kZXIgaXQgc2VlcyBpcyB0aGlzIGFwcCByYXRoZXIgdGhhbiB0aGUga2VlcGVyIOKAlCBpcyBtZWFzdXJlZCBpbiBgc2NyaXB0cy9zcGlrZV9yZWVudHJhbmN5LnB5YCByYXRoZXIgdGhhbiBhcmd1ZWQgYWJvdXQuXG5SZS1lbnRlcnMgb25jZSBhbmQgb25seSBvbmNlOiB1bmNvbmRpdGlvbmFsIHJlY3Vyc2lvbiB3b3VsZCBqdXN0IGhpdCB0aGUgQVZNJ3MgZGVwdGggbGltaXQgYW5kIHRlbGwgdXMgbm90aGluZy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBvcnRfZ3JvdXAiLCJkZXNjIjoiUmVjb3JkIHRoZSBncm91cCB0aGlzIGNhbGwgYXJyaXZlZCBpbiwgYXMgdGhlIHRhcmdldCBzZWVzIGl0LlxuQXJjcm9uIHB1dHMgbm8gY29uc3RyYWludCBvbiB0aGUgZ3JvdXAgaXRzIGBleGVjdXRlYCBpcyBzdWJtaXR0ZWQgaW4sIHNvIGEga2VlcGVyIGlzIGZyZWUgdG8gYnJhY2tldCB0aGUgY2FsbCBpdCBpcyBwYWlkIHRvIG1ha2Ugd2l0aCB0cmFuc2FjdGlvbnMgb2YgaXRzIG93bi4gV2hldGhlciB0aGUgdGFyZ2V0IGNhbiAqdGVsbCogaXMgdGhlIHdob2xlIHF1ZXN0aW9uOiBpZiBpdCBjYW4gc2VlIHRoZSBvdXRlciBncm91cCBpdCBjYW4gZGVmZW5kIGl0c2VsZiwgYW5kIGlmIGl0IGNhbm5vdCB0aGVuIHRoZSBkZWZlbmNlIGhhcyB0byBiZSBpbiB0aGUgdGFyZ2V0J3Mgb3duIHN0YXRlLiBSZWNvcmRlZCByYXRoZXIgdGhhbiBhc3NlcnRlZCwgYmVjYXVzZSBib3RoIGFuc3dlcnMgYXJlIHBvc3NpYmxlIGRlcGVuZGluZyBvbiBob3cgdGhlIGNhbGwgYXJyaXZlZCwgYW5kIHRoZSBhbnN3ZXIgaXMgdGhlIG1lYXN1cmVtZW50LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4aGF1c3RfYnVkZ2V0IiwiZGVzYyI6IlNwZW5kIG1vcmUgb3Bjb2RlIGJ1ZGdldCB0aGFuIGFueSBrZWVwZXIgY291bGQgaGF2ZSBicm91Z2h0LlxuQSB0YXJnZXQgdGhhdCBjb3N0cyBtb3JlIHRoYW4gaXQgaXMgd29ydGggaXMgdGhlIGNoZWFwZXN0IHdheSB0byBhdHRhY2sgYSBrZWVwZXIsIGlmIGZhaWxpbmcgY29zdHMgdGhlIGtlZXBlciBhbnl0aGluZy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1c2UiLCJkZXNjIjoiUmVqZWN0IGV2ZXJ5IGNhbGwsIHRoZSB3YXkgYSB0YXJnZXQgd2l0aCBhIGJ1ZyBvciBhIGdydWRnZSB3b3VsZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2dhcCIsImRlc2MiOiJTZXQgaG93IGxvbmcgYGd1YXJkZWRgIGxvY2tzIGl0c2VsZiBmb3IgYWZ0ZXIgYSBjYWxsLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ3VhcmRlZCIsImRlc2MiOiJSZWZ1c2UgYSBzZWNvbmQgY2FsbCBpbnNpZGUgYGdhcGAgcm91bmRzLlxuTm90IGFuIGV4b3RpYyB0YXJnZXQ6IGFuIG9yYWNsZSB0aGF0IHJlamVjdHMgYSBzdGFsZSB1cGRhdGUsIGEgcmViYWxhbmNlciB0aGF0IHJ1bnMgb25jZSBhbiBlcG9jaCwgYSBjbGFpbSB0aGF0IHBheXMgb25jZSBhIHBlcmlvZC4gQW55dGhpbmcgd2hvc2UgY2FsbCBpcyBjb25kaXRpb25hbCBvbiBzdGF0ZSBhIHRoaXJkIHBhcnR5IGNhbiBtb3ZlLiBUaGlzIGlzIHRoZSBzaGFwZSB0aGF0IGxldHMgc29tZWJvZHkgbWFudWZhY3R1cmUgdGhlIGxhdGVuZXNzIEFyY3JvbidzIGZlZSBlc2NhbGF0aW9uIHBheXMgZm9yLCB3aGljaCBgc2NyaXB0cy9zcGlrZV9ob3N0aWxlX3RhcmdldC5weWAgbWVhc3VyZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvYmVfYXBwX2NhbGwiLCJkZXNjIjoiQ2FsbCBhIHRoaXJkIGFwcCB0aGF0IG5vIGFyZ3VtZW50IG5hbWVzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo5LCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDk3XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzNdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IG9wdGVkIGludG8gYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdhcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmtlZXBlcl9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5rZWVwZXJfdXBrZWVwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMyw1NDksNTczLDYzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGFzdF9yZWFkaW5nIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyOCw4NTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfYWxsb3dlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzUsNDc3LDUwNCw1NDAsNTY0LDYyMyw2NDgsNjkzLDcwOCw3NTQsNzY1LDg0Niw4OTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByb2Jlc19ydW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE5LDQ1OCw0OTQsNTI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdWJqZWN0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3ViamVjdF9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk1LDQ1NCw1MjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN1YmplY3RfYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjQsMzczLDU4OCw2NjgsNjc3LDgxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MF0sImVycm9yTWVzc2FnZSI6InRoaXMgdGFyZ2V0IHJlZnVzZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzBdLCJlcnJvck1lc3NhZ2UiOiJ0b28gc29vbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNISnZZbVZ6WDNKMWJpSWdNSGd4TlRGbU4yTTNOU0FpYkdGemRGOXlaV0ZrYVc1bklpQWljM1ZpYW1WamRDSWdJbk4xWW1wbFkzUmZZWE56WlhRaUlDSnVaWGgwWDJGc2JHOTNaV1FpSUNKemRXSnFaV04wWDJGd2NDSWdJbXRsWlhCbGNsOWhjSEFpSUNKclpXVndaWEpmZFhCclpXVndJaUFpWjJGd0lpQWliR0Z6ZEY5dWRXMWlaWElpSUNKc1lYTjBYM1JsZUhRaUlDSnNZWE4wWDJOaGJHeGxjaUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRvek5TMHpPQW9nSUNBZ0x5OGdJeUJVYUdVZ2NtVnpiM1Z5WTJWeklIUnZJSEpsWVdOb0lHWnZjaXdnWm1sNFpXUWdZWFFnWTI5dVptbG5kWEpoZEdsdmJpQjBhVzFsSUhOdklIUm9ZWFFnWVFvZ0lDQWdMeThnSXlCd2NtOWlaU0JqWVd4c0lHTmhjbkpwWlhNZ2JtOTBhR2x1WnlCaWRYUWdhWFJ6SUc5M2JpQnpaV3hsWTNSdmNpRGlnSlFnWlhoaFkzUnNlU0IwYUdVZ2MyaGhjR1VLSUNBZ0lDOHZJQ01nUVhKamNtOXVJR05oYmlCelpXNWtMZ29nSUNBZ0x5OGdjMlZzWmk1emRXSnFaV04wSUQwZ1IyeHZZbUZzVTNSaGRHVW9RV05qYjNWdWRDZ3BLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljM1ZpYW1WamRDSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNXpkV0pxWldOMFgyRnpjMlYwSUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljM1ZpYW1WamRGOWhjM05sZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJ6Wld4bUxuTjFZbXBsWTNSZllYQndJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWMzVmlhbVZqZEY5aGNIQWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRvME1TMDBNZ29nSUNBZ0x5OGdJeUJGZG1sa1pXNWpaU0JoSUhCeWIySmxJSEpoYml3Z1ptOXlJSFJvWlNCallYTmxjeUIzYUdWeVpTQnpkV05qWlhOeklHbHpJSE5wYkdWdWRDNEtJQ0FnSUM4dklITmxiR1l1Y0hKdlltVnpYM0oxYmlBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjJKbGMxOXlkVzRpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdjMlZzWmk1c1lYTjBYM0psWVdScGJtY2dQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc1lYTjBYM0psWVdScGJtY2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRvME5DMDBOZ29nSUNBZ0x5OGdJeUJYYUdGMElHQmhZbk52Y21KZ0lIZGhjeUJvWVc1a1pXUXNJSE52SUdFZ2JYVnNkR2t0WVhKbklHTmhiR3dnWTJGdUlHSmxJR05vWldOclpXUWdabTl5Q2lBZ0lDQXZMeUFqSUdoaGRtbHVaeUJrWld4cGRtVnlaV1FnWlhabGNua2dZWEpuZFcxbGJuUWdjbUYwYUdWeUlIUm9ZVzRnYldWeVpXeDVJSE4xWTJObFpXUnBibWN1Q2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmYm5WdFltVnlJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lteGhjM1JmYm5WdFltVnlJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1YkdGemRGOTBaWGgwSUQwZ1IyeHZZbUZzVTNSaGRHVW9VM1J5YVc1bktDSWlLU2tLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pzWVhOMFgzUmxlSFFpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZORGd0TlRBS0lDQWdJQzh2SUNNZ1YyaHZJSFJvWlNCMFlYSm5aWFFnYzJWbGN5QmhjeUJwZEhNZ1kyRnNiR1Z5TENCM2FHbGphQ0JwY3lCdWIzUWdkMmh2SUhObGJuUWdkR2hsQ2lBZ0lDQXZMeUFqSUhSeVlXNXpZV04wYVc5dUlHOXVZMlVnUVhKamNtOXVJR2x6SUdsdUlIUm9aU0J0YVdSa2JHVXVDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZZMkZzYkdWeUlEMGdSMnh2WW1Gc1UzUmhkR1VvUVdOamIzVnVkQ2dwS1FvZ0lDQWdZbmwwWldNZ01USWdMeThnSW14aGMzUmZZMkZzYkdWeUlnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPalV4TFRVeUNpQWdJQ0F2THlBaklFRWdhMlZsY0dWeUlHRndjQ0JoYm1RZ2IyNWxJRzltSUdsMGN5QjFjR3RsWlhCekxDQm1iM0lnZEdobElISmxMV1Z1ZEhKaGJtTjVJSEJ5YjJKbExnb2dJQ0FnTHk4Z2MyVnNaaTVyWldWd1pYSmZZWEJ3SUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlhMlZsY0dWeVgyRndjQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QnpaV3htTG10bFpYQmxjbDkxY0d0bFpYQWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKclpXVndaWEpmZFhCclpXVndJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5UUXROVFlLSUNBZ0lDOHZJQ01nWUdkMVlYSmtaV1JnSUhKbFpuVnpaWE1nWVNCelpXTnZibVFnWTJGc2JDQnBibk5wWkdVZ2RHaHBjeUJ0WVc1NUlISnZkVzVrY3l3Z1lXNWtJSEpsWTI5eVpITUtJQ0FnSUM4dklDTWdkR2hsSUhKdmRXNWtJR2wwSUhkcGJHd2dibVY0ZENCaFkyTmxjSFFnYjI1bExnb2dJQ0FnTHk4Z2MyVnNaaTVuWVhBZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0puWVhBaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG8xTndvZ0lDQWdMeThnYzJWc1ppNXVaWGgwWDJGc2JHOTNaV1FnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSnVaWGgwWDJGc2JHOTNaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCamJHRnpjeUJTWlhOdmRYSmpaVkJ5YjJKbEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU5nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9EZzJNRFUwTURNZ01IZzBOV00zTVRReE9TQXdlRFEyTkRZeU1XSXhJREI0TWpGalltUTNORFlnTUhoalpESmtOalkzTUNBd2VHWmhNVGN4WVRSbUlEQjRaR014T1RkbU5tTWdNSGhqWWpjNE1tRTBPQ0F3ZUdSa01qQTBZV0U1SURCNE56RTRaRGt3TkRBZ01IaGlOVFppTkdFd1pDQXdlR015T0RVNFpXTm1JREI0T0RNeU5tWmxZV1VnTUhnd01tTXdaVFEyWXlBd2VEYzVPRFUxWlRBeElEQjRaR1l4TlRWbU5Ea2dNSGhsWkdFeFpHRTBOeUF2THlCdFpYUm9iMlFnSW1OdmJtWnBaM1Z5WlNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBYMmx1WDNSdlgyRnpjMlYwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0p3Y205aVpWOXdZWGx0Wlc1MEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luQnliMkpsWDJGemMyVjBYM1J5WVc1elptVnlLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkJ5YjJKbFgzSmxZV1JmWW1Gc1lXNWpaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p3Y205aVpWOXlaV0ZrWDJodmJHUnBibWNvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21Wd2IzSjBYMkoxWkdkbGRDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmhZbk52Y21Jb2RXbHVkRFkwTEhOMGNtbHVaeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsY0c5eWRGOWpZV3hzWlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltTnZibVpwWjNWeVpWOXlaV1Z1ZEhKNUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZsYm5SbGNpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlaWEJ2Y25SZlozSnZkWEFvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWlhob1lYVnpkRjlpZFdSblpYUW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZtZFhObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUmZaMkZ3S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5kV0Z5WkdWa0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luQnliMkpsWDJGd2NGOWpZV3hzS0NsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIyNW1hV2QxY21VZ2IzQjBYMmx1WDNSdlgyRnpjMlYwSUhCeWIySmxYM0JoZVcxbGJuUWdjSEp2WW1WZllYTnpaWFJmZEhKaGJuTm1aWElnY0hKdlltVmZjbVZoWkY5aVlXeGhibU5sSUhCeWIySmxYM0psWVdSZmFHOXNaR2x1WnlCeVpYQnZjblJmWW5Wa1oyVjBJR0ZpYzI5eVlpQnlaWEJ2Y25SZlkyRnNiR1Z5SUdOdmJtWnBaM1Z5WlY5eVpXVnVkSEo1SUhKbFpXNTBaWElnY21Wd2IzSjBYMmR5YjNWd0lHVjRhR0YxYzNSZlluVmtaMlYwSUcxaGFXNWZjbVZtZFhObFgzSnZkWFJsUURFNUlITmxkRjluWVhBZ1ozVmhjbVJsWkNCd2NtOWlaVjloY0hCZlkyRnNiQW9nSUNBZ1pYSnlDZ3B0WVdsdVgzSmxablZ6WlY5eWIzVjBaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG95TVRrS0lDQWdJQzh2SUdGemMyVnlkQ0JHWVd4elpTd2dJblJvYVhNZ2RHRnlaMlYwSUhKbFpuVnpaWE1pQ2lBZ0lDQmxjbklnTHk4Z2RHaHBjeUIwWVhKblpYUWdjbVZtZFhObGN3b0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TmpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsYzI5MWNtTmxYM0J5YjJKbExtTnZiblJ5WVdOMExsSmxjMjkxY21ObFVISnZZbVV1WTI5dVptbG5kWEpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVabWxuZFhKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ6Wld4bUxuTjFZbXBsWTNRdWRtRnNkV1VnUFNCemRXSnFaV04wTG01aGRHbDJaUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljM1ZpYW1WamRDSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnYzJWc1ppNXpkV0pxWldOMFgyRnpjMlYwTG5aaGJIVmxJRDBnWVhOelpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTjFZbXBsWTNSZllYTnpaWFFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklITmxiR1l1YzNWaWFtVmpkRjloY0hBdWRtRnNkV1VnUFNCaGNIQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luTjFZbXBsWTNSZllYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXViM0IwWDJsdVgzUnZYMkZ6YzJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwWDJsdVgzUnZYMkZ6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pjeExUYzFDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1Mbk4xWW1wbFkzUmZZWE56WlhRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMXpaV3htTG5OMVltcGxZM1JmWVhOelpYUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzNWaWFtVmpkRjloYzNObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZFdKcVpXTjBYMkZ6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qY3hMVGMxQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG5OMVltcGxZM1JmWVhOelpYUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE52ZFhKalpWOXdjbTlpWlM1amIyNTBjbUZqZEM1U1pYTnZkWEpqWlZCeWIySmxMbkJ5YjJKbFgzQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbTlpWlY5d1lYbHRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb2NtVmpaV2wyWlhJOWMyVnNaaTV6ZFdKcVpXTjBMblpoYkhWbExDQmhiVzkxYm5ROU1Da3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZFdKcVpXTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMVltcGxZM1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdjMlZzWmk1d2NtOWlaWE5mY25WdUxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOWlaWE5mY25WdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjJKbGMxOXlkVzRnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21WemIzVnlZMlZmY0hKdlltVXVZMjl1ZEhKaFkzUXVVbVZ6YjNWeVkyVlFjbTlpWlM1d2NtOWlaVjloYzNObGRGOTBjbUZ1YzJabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjJKbFgyRnpjMlYwWDNSeVlXNXpabVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPamczTFRreENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF6Wld4bUxuTjFZbXBsWTNSZllYTnpaWFF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljMlZzWmk1emRXSnFaV04wTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBYTmxiR1l1YzNWaWFtVmpkRjloYzNObGRDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p6ZFdKcVpXTjBYMkZ6YzJWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4xWW1wbFkzUmZZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1YzNWaWFtVmpkQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRXSnFaV04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjFZbXBsWTNRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG80TndvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG80TnkwNU1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5YzJWc1ppNXpkV0pxWldOMFgyRnpjMlYwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdWMzVmlhbVZqZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklITmxiR1l1Y0hKdlltVnpYM0oxYmk1MllXeDFaU0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTlpWlhOZmNuVnVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjJKbGMxOXlkVzRpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG80TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsYzI5MWNtTmxYM0J5YjJKbExtTnZiblJ5WVdOMExsSmxjMjkxY21ObFVISnZZbVV1Y0hKdlltVmZjbVZoWkY5aVlXeGhibU5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NISnZZbVZmY21WaFpGOWlZV3hoYm1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCelpXeG1MbXhoYzNSZmNtVmhaR2x1Wnk1MllXeDFaU0E5SUhObGJHWXVjM1ZpYW1WamRDNTJZV3gxWlM1aVlXeGhibU5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljM1ZpYW1WamRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZFdKcVpXTjBJR1Y0YVhOMGN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSQ1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14aGMzUmZjbVZoWkdsdVp5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklITmxiR1l1Y0hKdlltVnpYM0oxYmk1MllXeDFaU0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTlpWlhOZmNuVnVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjJKbGMxOXlkVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWJHRnpkRjl5WldGa2FXNW5MblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkdGemRGOXlaV0ZrYVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhoYzNSZmNtVmhaR2x1WnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUbzVOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVjSEp2WW1WZmNtVmhaRjlvYjJ4a2FXNW5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKdlltVmZjbVZoWkY5b2IyeGthVzVuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnWVhOelpYUWdQU0JCYzNObGRDaHpaV3htTG5OMVltcGxZM1JmWVhOelpYUXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzNWaWFtVmpkRjloYzNObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZFdKcVpXTjBYMkZ6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYzJWc1ppNXNZWE4wWDNKbFlXUnBibWN1ZG1Gc2RXVWdQU0JoYzNObGRDNWlZV3hoYm1ObEtITmxiR1l1YzNWaWFtVmpkQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRXSnFaV04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjFZbXBsWTNRZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sZEY5b2IyeGthVzVuWDJkbGRDQkJjM05sZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHOXdkR1ZrSUdsdWRHOGdZWE56WlhRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14aGMzUmZjbVZoWkdsdVp5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QnpaV3htTG5CeWIySmxjMTl5ZFc0dWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3Y205aVpYTmZjblZ1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TURnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxteGhjM1JmY21WaFpHbHVaeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14aGMzUmZjbVZoWkdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzWVhOMFgzSmxZV1JwYm1jZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ6YjNWeVkyVmZjSEp2WW1VdVkyOXVkSEpoWTNRdVVtVnpiM1Z5WTJWUWNtOWlaUzV5WlhCdmNuUmZZblZrWjJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ3YjNKMFgySjFaR2RsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUhObGJHWXViR0Z6ZEY5eVpXRmthVzVuTG5aaGJIVmxJRDBnUjJ4dlltRnNMbTl3WTI5a1pWOWlkV1JuWlhRb0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHRnpkRjl5WldGa2FXNW5JZ29nSUNBZ1oyeHZZbUZzSUU5d1kyOWtaVUoxWkdkbGRBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklITmxiR1l1Y0hKdlltVnpYM0oxYmk1MllXeDFaU0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTlpWlhOZmNuVnVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjJKbGMxOXlkVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWJHRnpkRjl5WldGa2FXNW5MblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkdGemRGOXlaV0ZrYVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhoYzNSZmNtVmhaR2x1WnlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE52ZFhKalpWOXdjbTlpWlM1amIyNTBjbUZqZEM1U1pYTnZkWEpqWlZCeWIySmxMbUZpYzI5eVlsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZpYzI5eVlqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE16TXRNVE0xQ2lBZ0lDQXZMeUFqSUZKbFlXUWdkR2hsSUdKMVpHZGxkQ0JtYVhKemRDd2djMjhnZEdocGN5QnBjeUJqYjIxd1lYSmhZbXhsSUhkcGRHZ2dZSEpsY0c5eWRGOWlkV1JuWlhSZ09nb2dJQ0FnTHk4Z0l5QmliM1JvSUhKbGNHOXlkQ0IzYUdGMElIUm9aU0IwWVhKblpYUWdkMkZ6SUdoaGJtUmxaQ3dnYm05MElIZG9ZWFFnYVhRZ2FHRnpJR3hsWm5RdUNpQWdJQ0F2THlCelpXeG1MbXhoYzNSZmNtVmhaR2x1Wnk1MllXeDFaU0E5SUVkc2IySmhiQzV2Y0dOdlpHVmZZblZrWjJWMEtDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGhjM1JmY21WaFpHbHVaeUlLSUNBZ0lHZHNiMkpoYkNCUGNHTnZaR1ZDZFdSblpYUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UTTJDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZiblZ0WW1WeUxuWmhiSFZsSUQwZ2JuVnRZbVZ5Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYkdGemRGOXVkVzFpWlhJaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmZEdWNGRDNTJZV3gxWlNBOUlIUmxlSFF1Ym1GMGFYWmxDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lteGhjM1JmZEdWNGRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QnpaV3htTG5CeWIySmxjMTl5ZFc0dWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3Y205aVpYTmZjblZ1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TXprS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxteGhjM1JmY21WaFpHbHVaeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14aGMzUmZjbVZoWkdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzWVhOMFgzSmxZV1JwYm1jZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ6YjNWeVkyVmZjSEp2WW1VdVkyOXVkSEpoWTNRdVVtVnpiM1Z5WTJWUWNtOWlaUzV5WlhCdmNuUmZZMkZzYkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ3YjNKMFgyTmhiR3hsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhObGJHWXViR0Z6ZEY5allXeHNaWEl1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpYkdGemRGOWpZV3hzWlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakUxTVFvZ0lDQWdMeThnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIySmxjMTl5ZFc0Z1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWE52ZFhKalpWOXdjbTlpWlM1amIyNTBjbUZqZEM1U1pYTnZkWEpqWlZCeWIySmxMbU52Ym1acFozVnlaVjl5WldWdWRISjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5dVptbG5kWEpsWDNKbFpXNTBjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJSE5sYkdZdWEyVmxjR1Z5WDJGd2NDNTJZV3gxWlNBOUlHdGxaWEJsY2w5aGNIQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltdGxaWEJsY2w5aGNIQWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCelpXeG1MbXRsWlhCbGNsOTFjR3RsWlhBdWRtRnNkV1VnUFNCMWNHdGxaWEJmYVdRS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW10bFpYQmxjbDkxY0d0bFpYQWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVjbVZsYm5SbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWlc1MFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UY3pDaUFnSUNBdkx5QnpaV3htTG5CeWIySmxjMTl5ZFc0dWRtRnNkV1VnS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3Y205aVpYTmZjblZ1SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMENpQWdJQ0F2THlCcFppQnpaV3htTG5CeWIySmxjMTl5ZFc0dWRtRnNkV1VnUGlBeE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDRLSUNBZ0lHSjZJSEpsWlc1MFpYSmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXdjbTlpWlhOZmNuVnVMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY0hKdlltVnpYM0oxYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTlpWlhOZmNuVnVJR1Y0YVhOMGN3b0tjbVZsYm5SbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhOdmRYSmpaVjl3Y205aVpTNWpiMjUwY21GamRDNVNaWE52ZFhKalpWQnliMkpsTG5KbFpXNTBaWEpBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZsYm5SbGNsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTRNd29nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1YTJWbGNHVnlYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMkZ5WjNNOUtBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSmxlR1ZqZFhSbEtIVnBiblEyTkNsMWFXNTBOalFpS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYjNBdWFYUnZZaWh6Wld4bUxtdGxaWEJsY2w5MWNHdGxaWEF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdiMjVmWTI5dGNHeGxkR2x2YmoxUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRjM0NpQWdJQ0F2THlCaGNIQmZhV1E5UVhCd2JHbGpZWFJwYjI0b2MyVnNaaTVyWldWd1pYSmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnJaV1Z3WlhKZllYQndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG10bFpYQmxjbDloY0hBZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ6YjNWeVkyVmZjSEp2WW1VdlkyOXVkSEpoWTNRdWNIazZNVGd3Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLSE5sYkdZdWEyVmxjR1Z5WDNWd2EyVmxjQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWEyVmxjR1Z5WDNWd2EyVmxjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1clpXVndaWEpmZFhCclpXVndJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z2IyNWZZMjl0Y0d4bGRHbHZiajFQYmtOdmJYQnNaWFJsUVdOMGFXOXVMazV2VDNBc0NpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE56a0tJQ0FnSUM4dklHRnlZelF1WVhKak5GOXphV2R1WVhSMWNtVW9JbVY0WldOMWRHVW9kV2x1ZERZMEtYVnBiblEyTkNJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XSTBPV05qTldNZ0x5OGdiV1YwYUc5a0lDSmxlR1ZqZFhSbEtIVnBiblEyTkNsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakUzTmdvZ0lDQWdMeThnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTRNd29nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1YTJWbGNHVnlYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMkZ5WjNNOUtBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSmxlR1ZqZFhSbEtIVnBiblEyTkNsMWFXNTBOalFpS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYjNBdWFYUnZZaWh6Wld4bUxtdGxaWEJsY2w5MWNHdGxaWEF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdiMjVmWTI5dGNHeGxkR2x2YmoxUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGMyOTFjbU5sWDNCeWIySmxMMk52Ym5SeVlXTjBMbkI1T2pFNE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjSEp2WW1WelgzSjFiaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2WW1WelgzSjFiaUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQnlaV1Z1ZEdWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsYzI5MWNtTmxYM0J5YjJKbExtTnZiblJ5WVdOMExsSmxjMjkxY21ObFVISnZZbVV1Y21WbGJuUmxja0ExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVjbVZ3YjNKMFgyZHliM1Z3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVndiM0owWDJkeWIzVndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qRTVPQW9nSUNBZ0x5OGdjMlZzWmk1c1lYTjBYM0psWVdScGJtY3VkbUZzZFdVZ1BTQkhiRzlpWVd3dVozSnZkWEJmYzJsNlpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJHRnpkRjl5WldGa2FXNW5JZ29nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG94T1RrS0lDQWdJQzh2SUhObGJHWXVjSEp2WW1WelgzSjFiaTUyWVd4MVpTQXJQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljSEp2WW1WelgzSjFiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtOWlaWE5mY25WdUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luQnliMkpsYzE5eWRXNGlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qSXdNQW9nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1bmNtOTFjRjl6YVhwbENpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1UZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVnpiM1Z5WTJWZmNISnZZbVV1WTI5dWRISmhZM1F1VW1WemIzVnlZMlZRY205aVpTNWxlR2hoZFhOMFgySjFaR2RsZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtVjRhR0YxYzNSZlluVmtaMlYwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnZEc5MFlXd2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1qRXdDaUFnSUNBdkx5QnBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmtkWEFLQ21WNGFHRjFjM1JmWW5Wa1oyVjBYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakl4TVFvZ0lDQWdMeThnZDJocGJHVWdhU0E4SURWZk1EQXdPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVd01EQUtJQ0FnSUR3S0lDQWdJR0o2SUdWNGFHRjFjM1JmWW5Wa1oyVjBYMkZtZEdWeVgzZG9hV3hsUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG95TVRJS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUc5d0xuTm9ZVEkxTmlodmNDNXBkRzlpS0drcEtTNXNaVzVuZEdnS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qSXhNd29nSUNBZ0x5OGdhU0FyUFNBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQmxlR2hoZFhOMFgySjFaR2RsZEY5M2FHbHNaVjkwYjNCQU1nb0taWGhvWVhWemRGOWlkV1JuWlhSZllXWjBaWEpmZDJocGJHVkFORG9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qSXdNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVjMlYwWDJkaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5bllYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1qSXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhOdmRYSmpaVjl3Y205aVpTOWpiMjUwY21GamRDNXdlVG95TWpRS0lDQWdJQzh2SUhObGJHWXVaMkZ3TG5aaGJIVmxJRDBnWjJGd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKbllYQWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qSXlNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjMjkxY21ObFgzQnliMkpsTG1OdmJuUnlZV04wTGxKbGMyOTFjbU5sVUhKdlltVXVaM1ZoY21SbFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWQxWVhKa1pXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1qTTNDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG5KdmRXNWtJRDQ5SUhObGJHWXVibVY0ZEY5aGJHeHZkMlZrTG5aaGJIVmxMQ0FpZEc5dklITnZiMjRpQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSnVaWGgwWDJGc2JHOTNaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVjRkRjloYkd4dmQyVmtJR1Y0YVhOMGN3b2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUIwYjI4Z2MyOXZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjMjkxY21ObFgzQnliMkpsTDJOdmJuUnlZV04wTG5CNU9qSXpPQW9nSUNBZ0x5OGdjMlZzWmk1dVpYaDBYMkZzYkc5M1pXUXVkbUZzZFdVZ1BTQkhiRzlpWVd3dWNtOTFibVFnS3lCelpXeG1MbWRoY0M1MllXeDFaUW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaVoyRndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kaGNDQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbTVsZUhSZllXeHNiM2RsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TWpNNUNpQWdJQ0F2THlCelpXeG1MbkJ5YjJKbGMxOXlkVzR1ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjJKbGMxOXlkVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNISnZZbVZ6WDNKMWJpQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTlpWlhOZmNuVnVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3lOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG01bGVIUmZZV3hzYjNkbFpDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbTVsZUhSZllXeHNiM2RsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWGgwWDJGc2JHOTNaV1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1qSTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVnpiM1Z5WTJWZmNISnZZbVV1WTI5dWRISmhZM1F1VW1WemIzVnlZMlZRY205aVpTNXdjbTlpWlY5aGNIQmZZMkZzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnliMkpsWDJGd2NGOWpZV3hzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakkwTlMweU5Ea0tJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDFCY0hCc2FXTmhkR2x2YmloelpXeG1Mbk4xWW1wbFkzUmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZZWEpuY3owb1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2lkR2xqYXlncGRXbHVkRFkwSWlrc0tTd0tJQ0FnSUM4dklDQWdJQ0J2Ymw5amIyMXdiR1YwYVc5dVBVOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveU5EWUtJQ0FnSUM4dklHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG5OMVltcGxZM1JmWVhCd0xuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p6ZFdKcVpXTjBYMkZ3Y0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkV0pxWldOMFgyRndjQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklHOXVYMk52YlhCc1pYUnBiMjQ5VDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0xBb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVnpiM1Z5WTJWZmNISnZZbVV2WTI5dWRISmhZM1F1Y0hrNk1qUTNDaUFnSUNBdkx5QmhjSEJmWVhKbmN6MG9ZWEpqTkM1aGNtTTBYM05wWjI1aGRIVnlaU2dpZEdsamF5Z3BkV2x1ZERZMElpa3NLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJrTkdRMVpqQmlJQzh2SUcxbGRHaHZaQ0FpZEdsamF5Z3BkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psYzI5MWNtTmxYM0J5YjJKbEwyTnZiblJ5WVdOMExuQjVPakkwTlFvZ0lDQWdMeThnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WemIzVnlZMlZmY0hKdlltVXZZMjl1ZEhKaFkzUXVjSGs2TWpRMUxUSTBPUW9nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1YzNWaWFtVmpkRjloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTaGhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0owYVdOcktDbDFhVzUwTmpRaUtTd3BMQW9nSUNBZ0x5OGdJQ0FnSUc5dVgyTnZiWEJzWlhScGIyNDlUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWE52ZFhKalpWOXdjbTlpWlM5amIyNTBjbUZqZEM1d2VUb3lOVEFLSUNBZ0lDOHZJSE5sYkdZdWNISnZZbVZ6WDNKMWJpNTJZV3gxWlNBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZZbVZ6WDNKMWJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205aVpYTmZjblZ1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5CeWIySmxjMTl5ZFc0aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYTnZkWEpqWlY5d2NtOWlaUzlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lOQ25CeWIySmxjMTl5ZFc0RUZSOThkUXhzWVhOMFgzSmxZV1JwYm1jSGMzVmlhbVZqZEExemRXSnFaV04wWDJGemMyVjBERzVsZUhSZllXeHNiM2RsWkF0emRXSnFaV04wWDJGd2NBcHJaV1Z3WlhKZllYQndEV3RsWlhCbGNsOTFjR3RsWlhBRFoyRndDMnhoYzNSZmJuVnRZbVZ5Q1d4aGMzUmZkR1Y0ZEF0c1lYTjBYMk5oYkd4bGNqRVlRQUF3S3pJRFp5Y0VJbWNuQmlKbktDSm5LaUpuSndvaVp5Y0xnQUJuSnd3eUEyY25CeUpuSndnaVp5Y0pJbWNuQlNKbk1SdEJBSWN4R1JSRU1SaEVnaEVFaUdCVUF3UkZ4eFFaQkVaR0liRUVJY3ZYUmdUTkxXWndCUG9YR2s4RTNCbC9iQVRMZUNwSUJOMGdTcWtFY1kyUVFBUzFhMG9OQk1LRmpzOEVneWIrcmdRQ3dPUnNCSG1GWGdFRTN4VmZTUVR0b2RwSE5ob0FqaEVBQ2dBekFFd0FiZ0NZQUxZQTJnRHlBUzBCUWdGZkFhTUJ1UUFCQWRRQjR3SU5BQUF4R1JReEdCUVFRellhQVVrVkpSSkVOaG9DU1JVa0VrUVhOaG9EU1JVa0VrUVhLMDhEWnljRVR3Sm5Kd1pNWnlORHNTSW5CR1ZFTWdvaXNoS3lGTElSZ1FTeUVDS3lBYk1qUTdFaUsyVkVJcklJc2djanNoQWlzZ0d6SWlobFJDTUlLRXNCWnhZcFRGQ3dJME94SWljRVpVUWlLMlZFSXJJU3NoU3lFWUVFc2hBaXNnR3pJaWhsUkNNSUtFc0JaeFlwVEZDd0kwTWlLMlZFY3dCRUtreG5JaWhsUkNNSUtFeG5JaXBsUkJZcFRGQ3dJME1pSndSbFJDSXJaVVJNY0FCRUtreG5JaWhsUkNNSUtFeG5JaXBsUkJZcFRGQ3dJME1xTWd4bklpaGxSQ01JS0V4bklpcGxSQllwVEZDd0kwTTJHZ0ZKRlNRU1JCYzJHZ0pKSWxtQkFnaExBUlVTUkNveURHY25DazhDWjFjQ0FDY0xUR2NpS0dWRUl3Z29UR2NpS21WRUZpbE1VTEFqUXljTU1RQm5JaWhsUkNNSUtFeG5LVEVBVUxBalF6WWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUZ5Y0hUd0puSndoTVp5TkRJaWhsUkNNSUtFc0JaeU1OUVFBTElpaGxSQllwVEZDd0kwT3hJaWNIWlVRaUp3aGxSQllpc2htQUJGdEp6Rnl5R3JJYXNoaUJCcklRSXJJQnN5SW9aVVJDLzg4cU1nUm5JaWhsUkNNSUtFeG5NZ1FXS1V4UXNDTkRJa2xKZ1lnbkRFRUFDVXdsQ0V3akNFTC83MGdXS1V4UXNDTkROaG9CU1JVa0VrUVhKd2xNWnlORE1nWWlKd1ZsUkE5RU1nWWlKd2xsUkFnbkJVeG5JaWhsUkNNSUtFeG5JaWNGWlVRV0tVeFFzQ05Ec1NJbkJtVkVJcklaZ0FSTlRWOExzaHF5R0lFR3NoQWlzZ0d6SWlobFJDTUlLRXNCWnhZcFRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
