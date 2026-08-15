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

namespace Arc56.Generated.algorandfoundation.auto_draw_card.Killswitch_bf1cdefb
{


    public class KillswitchProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KillswitchProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 34, 62, 251 };
                public const string Signature = "OwnershipTransferred(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address PreviousOwner { get; set; }
                public Algorand.Address NewOwner { get; set; }

                public static OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is Algorand.Address vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is Algorand.Address vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class PauseEvent
            {
                public static readonly byte[] Selector = new byte[4] { 207, 35, 163, 15 };
                public const string Signature = "Pause()";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }

                public static PauseEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PauseEvent();
                    var eventData = log.Skip(4).ToArray();
                    return ret;

                }

            }

            public class UnpauseEvent
            {
                public static readonly byte[] Selector = new byte[4] { 177, 99, 238, 11 };
                public const string Signature = "Unpause()";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }

                public static UnpauseEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new UnpauseEvent();
                    var eventData = log.Skip(4).ToArray();
                    return ret;

                }

            }

            public class PauserChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 204, 64, 146, 60 };
                public const string Signature = "PauserChanged(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address NewAddress { get; set; }

                public static PauserChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PauserChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vNewAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewAddress = vNewAddress.ToValue();
                    if (valueNewAddress is Algorand.Address vNewAddressValue) { ret.NewAddress = vNewAddressValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Deploy the contract, setting the owner as provided and initializing global state.
        ///</summary>
        /// <param name="owner">The account to set as the contract owner. </param>
        /// <param name="main">The Main contract used to verify card ownership when enabling delegation. </param>
        public async Task<Algorand.Address> Deploy(Algorand.Address owner, ulong main, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 254, 104, 68 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var mainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mainAbi.From(main);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, mainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Deploy_Transactions(Algorand.Address owner, ulong main, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 254, 104, 68 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var mainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mainAbi.From(main);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, mainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Checks if the delegation is authorized for the (account, asset) pair.
        ///</summary>
        /// <param name="account">The address of the user to check. </param>
        /// <param name="asset">The asset the delegation must be enabled for. </param>
        public async Task Authorize(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 49, 46, 241 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Authorize_Transactions(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 49, 46, 241 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enables AutoDraw delegation of the given asset for the caller.
        ///
        ///The delegation is keyed by (Txn.sender, asset) — the same key `authorize` and `kill`
        ///use, and the account the AutoDraw Lsig binds to the axfer sender.
        ///
        ///Gated to accounts that own a card in the Main contract, to prevent abuse of the
        ///owner-funded box MBR. The caller must supply a card address they own; ownership is
        ///verified against the Main contract via a cross-contract call.
        ///</summary>
        /// <param name="card">A card address owned by the caller, used to prove card ownership. </param>
        /// <param name="asset">The asset to enable delegation for. </param>
        public async Task Enable(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 88, 209, 224 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Enable_Transactions(Algorand.Address card, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 88, 209, 224 };
            var cardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); cardAbi.From(card);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, cardAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Disables AutoDraw delegation of the given asset for the caller.
        ///</summary>
        /// <param name="asset">The asset to disable delegation for. </param>
        public async Task Kill(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 205, 82, 74 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Kill_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 205, 82, 74 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Disables AutoDraw delegation of the given asset on behalf of `account`.
        ///
        ///Unlike `kill`, a delegation that is not enabled is not an error. Main revokes on every
        ///asset opt-out and cannot tell which assets the holder actually delegated, so failing here
        ///would block opting a card out of an asset it never delegated.
        ///</summary>
        /// <param name="account">The account whose delegation is being revoked. </param>
        /// <param name="asset">The asset to disable delegation for. </param>
        public async Task KillFor(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 185, 61, 162 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> KillFor_Transactions(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 185, 61, 162 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers the ownership of the contract to a new owner.
        ///Requires the caller to be the current owner.
        ///</summary>
        /// <param name="newOwner">The address of the new owner. </param>
        public async Task TransferOwnership(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Pauser(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 217, 83, 179 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Pauser_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 217, 83, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_newPauser"> </param>
        public async Task UpdatePauser(Algorand.Address _newPauser, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 173, 209, 99 };
            var _newPauserAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _newPauserAbi.From(_newPauser);

            var result = await base.CallApp(new List<object> { abiHandle, _newPauserAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePauser_Transactions(Algorand.Address _newPauser, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 173, 209, 99 };
            var _newPauserAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _newPauserAbi.From(_newPauser);

            return await base.MakeTransactionList(new List<object> { abiHandle, _newPauserAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recover an asset sent to the contract by mistake. Only the owner can call this function.
        ///</summary>
        /// <param name="asset">Asset ID of the asset to recover. If 0, Algo will be recovered. </param>
        /// <param name="amount">Amount of the asset to recover. If Algos, remember the minimum balance requirement. </param>
        /// <param name="recipient">Address to send the recovered asset to. </param>
        public async Task RecoverAsset(ulong asset, ulong amount, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 90, 27, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecoverAsset_Transactions(ulong asset, ulong amount, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 90, 27, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2lsbHN3aXRjaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBsb3kiLCJkZXNjIjoiRGVwbG95IHRoZSBjb250cmFjdCwgc2V0dGluZyB0aGUgb3duZXIgYXMgcHJvdmlkZWQgYW5kIGluaXRpYWxpemluZyBnbG9iYWwgc3RhdGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBzZXQgYXMgdGhlIGNvbnRyYWN0IG93bmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFpbiIsImRlc2MiOiJUaGUgTWFpbiBjb250cmFjdCB1c2VkIHRvIHZlcmlmeSBjYXJkIG93bmVyc2hpcCB3aGVuIGVuYWJsaW5nIGRlbGVnYXRpb24uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImF1dGhvcml6ZSIsImRlc2MiOiJDaGVja3MgaWYgdGhlIGRlbGVnYXRpb24gaXMgYXV0aG9yaXplZCBmb3IgdGhlIChhY2NvdW50LCBhc3NldCkgcGFpci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIHVzZXIgdG8gY2hlY2suIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdGhlIGRlbGVnYXRpb24gbXVzdCBiZSBlbmFibGVkIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlIiwiZGVzYyI6IkVuYWJsZXMgQXV0b0RyYXcgZGVsZWdhdGlvbiBvZiB0aGUgZ2l2ZW4gYXNzZXQgZm9yIHRoZSBjYWxsZXIuXG5cblRoZSBkZWxlZ2F0aW9uIGlzIGtleWVkIGJ5IChUeG4uc2VuZGVyLCBhc3NldCkg4oCUIHRoZSBzYW1lIGtleSBgYXV0aG9yaXplYCBhbmQgYGtpbGxgXG51c2UsIGFuZCB0aGUgYWNjb3VudCB0aGUgQXV0b0RyYXcgTHNpZyBiaW5kcyB0byB0aGUgYXhmZXIgc2VuZGVyLlxuXG5HYXRlZCB0byBhY2NvdW50cyB0aGF0IG93biBhIGNhcmQgaW4gdGhlIE1haW4gY29udHJhY3QsIHRvIHByZXZlbnQgYWJ1c2Ugb2YgdGhlXG5vd25lci1mdW5kZWQgYm94IE1CUi4gVGhlIGNhbGxlciBtdXN0IHN1cHBseSBhIGNhcmQgYWRkcmVzcyB0aGV5IG93bjsgb3duZXJzaGlwIGlzXG52ZXJpZmllZCBhZ2FpbnN0IHRoZSBNYWluIGNvbnRyYWN0IHZpYSBhIGNyb3NzLWNvbnRyYWN0IGNhbGwuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkEgY2FyZCBhZGRyZXNzIG93bmVkIGJ5IHRoZSBjYWxsZXIsIHVzZWQgdG8gcHJvdmUgY2FyZCBvd25lcnNoaXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZW5hYmxlIGRlbGVnYXRpb24gZm9yLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJraWxsIiwiZGVzYyI6IkRpc2FibGVzIEF1dG9EcmF3IGRlbGVnYXRpb24gb2YgdGhlIGdpdmVuIGFzc2V0IGZvciB0aGUgY2FsbGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZGlzYWJsZSBkZWxlZ2F0aW9uIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoia2lsbEZvciIsImRlc2MiOiJEaXNhYmxlcyBBdXRvRHJhdyBkZWxlZ2F0aW9uIG9mIHRoZSBnaXZlbiBhc3NldCBvbiBiZWhhbGYgb2YgYGFjY291bnRgLlxuXG5Vbmxpa2UgYGtpbGxgLCBhIGRlbGVnYXRpb24gdGhhdCBpcyBub3QgZW5hYmxlZCBpcyBub3QgYW4gZXJyb3IuIE1haW4gcmV2b2tlcyBvbiBldmVyeVxuYXNzZXQgb3B0LW91dCBhbmQgY2Fubm90IHRlbGwgd2hpY2ggYXNzZXRzIHRoZSBob2xkZXIgYWN0dWFsbHkgZGVsZWdhdGVkLCBzbyBmYWlsaW5nIGhlcmVcbndvdWxkIGJsb2NrIG9wdGluZyBhIGNhcmQgb3V0IG9mIGFuIGFzc2V0IGl0IG5ldmVyIGRlbGVnYXRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjoiVGhlIGFjY291bnQgd2hvc2UgZGVsZWdhdGlvbiBpcyBiZWluZyByZXZva2VkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIGFzc2V0IHRvIGRpc2FibGUgZGVsZWdhdGlvbiBmb3IuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJPd25lcnNoaXAiLCJkZXNjIjoiVHJhbnNmZXJzIHRoZSBvd25lcnNoaXAgb2YgdGhlIGNvbnRyYWN0IHRvIGEgbmV3IG93bmVyLlxuUmVxdWlyZXMgdGhlIGNhbGxlciB0byBiZSB0aGUgY3VycmVudCBvd25lci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSBuZXcgb3duZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjoiUGF1c2VyJ3MgYWRkcmVzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVW5wYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlUGF1c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfbmV3UGF1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQYXVzZXJDaGFuZ2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZGRyZXNzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3ZlckFzc2V0IiwiZGVzYyI6IlJlY292ZXIgYW4gYXNzZXQgc2VudCB0byB0aGUgY29udHJhY3QgYnkgbWlzdGFrZS4gT25seSB0aGUgb3duZXIgY2FuIGNhbGwgdGhpcyBmdW5jdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiQXNzZXQgSUQgb2YgdGhlIGFzc2V0IHRvIHJlY292ZXIuIElmIDAsIEFsZ28gd2lsbCBiZSByZWNvdmVyZWQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiQW1vdW50IG9mIHRoZSBhc3NldCB0byByZWNvdmVyLiBJZiBBbGdvcywgcmVtZW1iZXIgdGhlIG1pbmltdW0gYmFsYW5jZSByZXF1aXJlbWVudC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjoiQWRkcmVzcyB0byBzZW5kIHRoZSByZWNvdmVyZWQgYXNzZXQgdG8uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDU3XSwiZXJyb3JNZXNzYWdlIjoiQUREUkVTU19OT1RfQUxMT1dFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6IkFMUkVBRFlfRElTQUJMRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDVdLCJlcnJvck1lc3NhZ2UiOiJBTFJFQURZX0VOQUJMRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTRdLCJlcnJvck1lc3NhZ2UiOiJBU1NFVF9OT1RfQUxMT1dFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDhdLCJlcnJvck1lc3NhZ2UiOiJDT05UUkFDVF9QQVVTRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDddLCJlcnJvck1lc3NhZ2UiOiJOT1RfQ0FSRF9PV05FUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6IlJFRlVTRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjEsNTUxLDU5N10sImVycm9yTWVzc2FnZSI6IlNFTkRFUl9OT1RfQUxMT1dFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNiwyNjAsMzU5LDM3OSw0MDUsNTQ5LDU2Nyw1OTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTQsMTkzLDIyNCwzNDMsMzkzLDQ0OSw1MDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyLDIwMSwyMzIsMzIwLDM1MSw0ODAsNDkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9tYWluL2NvbnRyYWN0LmFsZ28udHM6OkNhcmREYXRhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lsOXZkMjVsY2lJZ0lsOXdZWFZ6WlhJaUlDSndZWFZ6WldRaUlEQjRNVFV4Wmpkak56VWdJbTFoSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFdHBiR3h6ZDJsMFkyZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0U1TXpFeVpXWXhJREI0WkRNMU9HUXhaVEFnTUhnNE9HTmtOVEkwWVNBd2VEZGlZamt6WkdFeUlEQjRZakZpWW1Jd1lUZ2dNSGhsTVRkaVlXWmlOQ0F3ZUdJd1pEazFNMkl6SURCNE1ERTNPR1k1TkdJZ01IZ3hZalV5T1dSbE9DQXdlREJqWVdSa01UWXpJREI0TnpnMVlURmlaamtnTHk4Z2JXVjBhRzlrSUNKaGRYUm9iM0pwZW1Vb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaVzVoWW14bEtHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbXRwYkd3b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbXRwYkd4R2IzSW9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYjNkdVpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlUM2R1WlhKemFHbHdLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNHRjFjMlZ5S0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKd1lYVnpaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlkVzV3WVhWelpTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsVUdGMWMyVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmpiM1psY2tGemMyVjBLSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWVhWMGFHOXlhWHBsSUdWdVlXSnNaU0JyYVd4c0lHdHBiR3hHYjNJZ2IzZHVaWElnZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFnY0dGMWMyVnlJSEJoZFhObElIVnVjR0YxYzJVZ2RYQmtZWFJsVUdGMWMyVnlJSEpsWTI5MlpYSkJjM05sZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRXRwYkd4emQybDBZMmdnWlhoMFpXNWtjeUJqYkdGemMyVnpLRTkzYm1GaWJHVXNJRkJoZFhOaFlteGxMQ0JTWldOdmRtVnlZV0pzWlNrZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56Wm1aVFk0TkRRZ0x5OGdiV1YwYUc5a0lDSmtaWEJzYjNrb1lXUmtjbVZ6Y3l4MWFXNTBOalFwWVdSa2NtVnpjeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdSbGNHeHZlUW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlMybHNiSE4zYVhSamFDNWtaWEJzYjNsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWEJzYjNrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkowNXZUM0FuWFN3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxsOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNDaHZkMjVsY2lrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdYM1J5WVc1elptVnlUM2R1WlhKemFHbHdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnY0hWaWJHbGpJRjl3WVhWelpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZmNHRjFjMlZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnZEdocGN5NWZjR0YxYzJWeUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljR0YxYzJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2RHaHBjeTV3WVhWelpXUXVkbUZzZFdVZ1BTQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiV0ZwYmw5aGNIQWdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklDZHRZU2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xaElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2RHaHBjeTV0WVdsdVgyRndjQzUyWVd4MVpTQTlJRzFoYVc0S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkowNXZUM0FuWFN3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjA1dlQzQW5YU3dnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTGFXeHNjM2RwZEdOb0xtRjFkR2h2Y21sNlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUYxZEdodmNtbDZaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSEIxWW14cFl5QmhkWFJvYjNKcGVtVW9ZV05qYjNWdWREb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11Y0dGMWMyVmtMblpoYkhWbExDQW5RMDlPVkZKQlExUmZVRUZWVTBWRUp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxMQ0FuUTA5T1ZGSkJRMVJmVUVGVlUwVkVKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTA5T1ZGSkJRMVJmVUVGVlUwVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoWTJOdmRXNTBRWE56WlhSUVlXbHljeWhiWVdOamIzVnVkQ3dnWVhOelpYUmRLUzVsZUdsemRITXNJQ2RTUlVaVlUwVkVKeWtLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1VrVkdWVk5GUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnY0hWaWJHbGpJR0YxZEdodmNtbDZaU2hoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBMYVd4c2MzZHBkR05vTG1WdVlXSnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WdVlXSnNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJSEIxWW14cFl5QmxibUZpYkdVb1kyRnlaRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRnRVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjBnWVhNZ1FXTmpiM1Z1ZEVGemMyVjBTMlY1Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVlXTmpiM1Z1ZEVGemMyVjBVR0ZwY25Nb2EyVjVLUzVsZUdsemRITXNJQ2RCVEZKRlFVUlpYMFZPUVVKTVJVUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJURkpGUVVSWlgwVk9RVUpNUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUdGemMyVnlkQ2hqWVhKa0xtbHpUM0IwWldSSmJpaGhjM05sZENrc0lDZEJVMU5GVkY5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGVFUwVlVYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TVMweE1EUUtJQ0FnSUM4dklHTnZibk4wSUdOaGNtUkVZWFJoSUQwZ1lYSmpOQzVoWW1sRFlXeHNQSFI1Y0dWdlppQk5ZV2x1TG5CeWIzUnZkSGx3WlM1blpYUkRZWEprUkdGMFlUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR2hwY3k1dFlXbHVYMkZ3Y0M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMk5oY21SZExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QmhjSEJKWkRvZ2RHaHBjeTV0WVdsdVgyRndjQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCd2RXSnNhV01nYldGcGJsOWhjSEFnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJQ2R0WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMWhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJR0Z3Y0Vsa09pQjBhR2x6TG0xaGFXNWZZWEJ3TG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREV0TVRBMENpQWdJQ0F2THlCamIyNXpkQ0JqWVhKa1JHRjBZU0E5SUdGeVl6UXVZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXRnBiaTV3Y205MGIzUjVjR1V1WjJWMFEyRnlaRVJoZEdFK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11YldGcGJsOWhjSEF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGpZWEprWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNORFZrWW1ZeE5pQXZMeUJ0WlhSb2IyUWdJbWRsZEVOaGNtUkVZWFJoS0dGa1pISmxjM01wS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEWVhKa1JHRjBZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpZWEprUkdGMFlTNXZkMjVsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjA1UFZGOURRVkpFWDA5WFRrVlNKeWtLSUNBZ0lHVjRkSEpoWTNRZ05DQXpNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPVDFSZlEwRlNSRjlQVjA1RlVnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklIUm9hWE11WVdOamIzVnVkRUZ6YzJWMFVHRnBjbk1vYTJWNUtTNWpjbVZoZEdVb2V5QnphWHBsT2lBd0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaVzVoWW14bEtHTmhjbVE2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t0cGJHeHpkMmwwWTJndWEybHNiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q210cGJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOUW9nSUNBZ0x5OGdjSFZpYkdsaklHdHBiR3dvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnVzFSNGJpNXpaVzVrWlhJc0lHRnpjMlYwWFNCaGN5QkJZMk52ZFc1MFFYTnpaWFJMWlhrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRmpZMjkxYm5SQmMzTmxkRkJoYVhKektHdGxlU2t1WlhocGMzUnpMQ0FuUVV4U1JVRkVXVjlFU1ZOQlFreEZSQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGTVVrVkJSRmxmUkVsVFFVSk1SVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU0Q2lBZ0lDQXZMeUIwYUdsekxtRmpZMjkxYm5SQmMzTmxkRkJoYVhKektHdGxlU2t1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUhCMVlteHBZeUJyYVd4c0tHRnpjMlYwT2lCQmMzTmxkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rdHBiR3h6ZDJsMFkyZ3VhMmxzYkVadmNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXRwYkd4R2IzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdjSFZpYkdsaklHdHBiR3hHYjNJb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJoYzNObGNuUW9SMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNXUWdQVDA5SUhSb2FYTXViV0ZwYmw5aGNIQXVkbUZzZFdVdWFXUXNJQ2RUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFuS1FvZ0lDQWdaMnh2WW1Gc0lFTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCd2RXSnNhV01nYldGcGJsOWhjSEFnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJQ2R0WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMWhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaEhiRzlpWVd3dVkyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlpDQTlQVDBnZEdocGN5NXRZV2x1WDJGd2NDNTJZV3gxWlM1cFpDd2dKMU5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQmJZV05qYjNWdWRDd2dZWE56WlhSZElHRnpJRUZqWTI5MWJuUkJjM05sZEV0bGVRb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTFDaUFnSUNBdkx5QnBaaUFvZEdocGN5NWhZMk52ZFc1MFFYTnpaWFJRWVdseWN5aHJaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnJhV3hzUm05eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpZS0lDQWdJQzh2SUhSb2FYTXVZV05qYjNWdWRFRnpjMlYwVUdGcGNuTW9hMlY1S1M1a1pXeGxkR1VvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0NtdHBiR3hHYjNKZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpFS0lDQWdJQzh2SUhCMVlteHBZeUJyYVd4c1JtOXlLR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJR0Z6YzJWME9pQkJjM05sZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T2s5M2JtRmliR1V1YjNkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2ZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qcFBkMjVoWW14bExuUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1dmJteDVUM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVQzZHVaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUhSb2FYTXVYM1J5WVc1elptVnlUM2R1WlhKemFHbHdLRzVsZDA5M2JtVnlLUW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklIQjFZbXhwWXlCMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodVpYZFBkMjVsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1d1lYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYVnpaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCd2RXSnNhV01nWDNCaGRYTmxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsOXdZWFZ6WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WDNCaGRYTmxjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QndkV0pzYVdNZ2NHRjFjMlZ5S0NrNklFRmpZMjkxYm5RZ2V3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11YjI1c2VWQmhkWE5sY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUVlYVnpaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMGdkSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z1pXMXBkRHhRWVhWelpUNG9lMzBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWmpJellUTXdaZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFibkJoZFhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkVzV3WVhWelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxRWVhWelpYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVVR0YxYzJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdjSFZpYkdsaklIQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxuQmhkWE5sWkM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUJsYldsMFBGVnVjR0YxYzJVK0tIdDlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakUyTTJWbE1HSUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJSEIxWW14cFl5QjFibkJoZFhObEtDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qcFFZWFZ6WVdKc1pTNTFjR1JoZEdWUVlYVnpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZRWVhWelpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWQmhkWE5sY2loZmJtVjNVR0YxYzJWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFBkMjVsY2lncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsUGQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUdGemMyVnlkQ2hmYm1WM1VHRjFjMlZ5SUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNJQ2RCUkVSU1JWTlRYMDVQVkY5QlRFeFBWMFZFSnlrS0lDQWdJR1IxY0FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGRVJGSkZVMU5mVGs5VVgwRk1URTlYUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QndkV0pzYVdNZ1gzQmhkWE5sY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDl3WVhWelpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem81TVFvZ0lDQWdMeThnZEdocGN5NWZjR0YxYzJWeUxuWmhiSFZsSUQwZ1gyNWxkMUJoZFhObGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnWlcxcGREeFFZWFZ6WlhKRGFHRnVaMlZrUGloN0lHNWxkMEZrWkhKbGMzTTZJSFJvYVhNdVgzQmhkWE5sY2k1MllXeDFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJNME1Ea3lNMk1nTHk4Z2JXVjBhRzlrSUNKUVlYVnpaWEpEYUdGdVoyVmtLR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxVR0YxYzJWeUtGOXVaWGRRWVhWelpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem82VW1WamIzWmxjbUZpYkdVdWNtVmpiM1psY2tGemMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WamIzWmxja0Z6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldOdmRtVnlRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2djbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVU5M2JtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2FXWWdLR0Z6YzJWMExtbGtLU0I3Q2lBZ0lDQmllaUJ5WldOdmRtVnlRWE56WlhSZlpXeHpaVjlpYjJSNVFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pReUxUUTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qUXlMVFEzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pReUxUUTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dweVpXTnZkbVZ5UVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldOdmRtVnlRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5Dd2djbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldOdmRtVnlRWE56WlhSZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qVXdMVFUxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nY21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem8xTUMwMU5Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklISmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPalV3TFRVMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaUlISmxZMjkyWlhKQmMzTmxkRjloWm5SbGNsOXBabDlsYkhObFFEWUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qcFBkMjVoWW14bExtOXViSGxQZDI1bGNpZ3BJQzArSUhadmFXUTZDbTl1YkhsUGQyNWxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTd2dKMU5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdjSFZpYkdsaklGOXZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDl2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlN3Z0oxTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlU1RVJWSmZUazlVWDBGTVRFOVhSVVFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T2s5M2JtRmliR1V1WDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3S0c1bGQwOTNibVZ5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2NISnZkR1ZqZEdWa0lGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNDaHVaWGRQZDI1bGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVjJhVzkxYzA5M2JtVnlJRDBnZEdocGN5NWZiM2R1WlhJdWFHRnpWbUZzZFdVZ1B5QjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1gzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1gzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJmYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZmIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0NsOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNGOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QndkV0pzYVdNZ1gyOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlYMjkzYm1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdkR2hwY3k1ZmIzZHVaWEl1ZG1Gc2RXVWdQU0J1WlhkUGQyNWxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zT0MwNE1Rb2dJQ0FnTHk4Z1pXMXBkRHhQZDI1bGNuTm9hWEJVY21GdWMyWmxjbkpsWkQ0b2V3b2dJQ0FnTHk4Z0lDQndjbVYyYVc5MWMwOTNibVZ5T2lCd2NtVjJhVzkxYzA5M2JtVnlMQW9nSUNBZ0x5OGdJQ0J1WlhkUGQyNWxjam9nYm1WM1QzZHVaWElzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURsaE1qSXpaV1ppSUM4dklHMWxkR2h2WkNBaVQzZHVaWEp6YUdsd1ZISmhibk5tWlhKeVpXUW9ZV1JrY21WemN5eGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2w5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J3Y21WMmFXOTFjMDkzYm1WeUlEMGdkR2hwY3k1ZmIzZHVaWEl1YUdGelZtRnNkV1VnUHlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmlJRjkwY21GdWMyWmxjazkzYm1WeWMyaHBjRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzZVR0YxYzJGaWJHVXViMjVzZVZCaGRYTmxjaWdwSUMwK0lIWnZhV1E2Q205dWJIbFFZWFZ6WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlN3Z0oxTkZUa1JGVWw5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklIQjFZbXhwWXlCZmNHRjFjMlZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYM0JoZFhObGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVmY0dGMWMyVnlMblpoYkhWbExDQW5VMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZORlRrUkZVbDlPVDFSZlFVeE1UMWRGUkFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0NDWUZCbDl2ZDI1bGNnZGZjR0YxYzJWeUJuQmhkWE5sWkFRVkgzeDFBbTFoTVJrVVJERVlRUUJWZ2dzRXFURXU4UVRUV05IZ0JJak5Va29FZTdrOW9nU3h1N0NvQk9GN3I3UUVzTmxUc3dRQmVQbExCQnRTbmVnRURLM1JZd1I0V2h2NU5ob0FqZ3NBTmdCVkFMVUF6QUQwQVA0QkRnRVlBU2NCTmdGVkFJQUVkdjVvUkRZYUFJNEJBQUVBTmhvQlNSVWtFa1EyR2dKSkZTVVNSQmRNaUFHQktURUFaeW9pWnljRVRHY3JNZ3BRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1VTUkJjaUttVkVGRVFXVUwxRkFVUWpRellhQVVrVkpCSkVOaG9DU1JVbEVrUVhNUUJMQVJaUVNiMUZBUlJFU3dKUEFuQUFSUUZFc1NJbkJHVkVzaGlBQkhSZHZ4YXlHa3l5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFTd0ZYQUFRckVrUVZnVkFTUkZjRUlERUFFa1FpdVVnalF6WWFBVWtWSlJKRUZ6RUFUQlpRU2IxRkFVUzhTQ05ETmhvQlNSVWtFa1EyR2dKSkZTVVNSQmN5RFNJbkJHVkVFa1FXVUVtOVJRRkJBQU5KdkVnalF5SW9aVVFyVEZDd0kwTTJHZ0ZKRlNRU1JJZ0FrNGdBbVNORElpbGxSQ3RNVUxBalE0Z0FyeW9qWjRBRXp5T2pEN0FqUTRnQW9Db2laNEFFc1dQdUM3QWpRellhQVVrVkpCSkVpQUJiU1RJREUwUXBTd0ZuZ0FUTVFKSThURkN3STBNMkdnRkpGU1VTUkJkSk5ob0NTUlVsRWtRWFRnSTJHZ05KVGdJVkpCSkVpQUFsUVFBUnNiSVVzaEd5RW9FRXNoQWlzZ0d6STBORkFiR3lCN0lJSTdJUUlySUJzMEwvN1RFQUlpaGxSQkpFaVlvQkFDSW9aVVVCUVFBVklpaGxSQ2lMLzJlTC8xQ0FCSm9pUHZ0TVVMQ0pNZ05DLytveEFDSXBaVVFTUklrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfSx7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
