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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2lsbHN3aXRjaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBsb3kiLCJkZXNjIjoiRGVwbG95IHRoZSBjb250cmFjdCwgc2V0dGluZyB0aGUgb3duZXIgYXMgcHJvdmlkZWQgYW5kIGluaXRpYWxpemluZyBnbG9iYWwgc3RhdGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBzZXQgYXMgdGhlIGNvbnRyYWN0IG93bmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFpbiIsImRlc2MiOiJUaGUgTWFpbiBjb250cmFjdCB1c2VkIHRvIHZlcmlmeSBjYXJkIG93bmVyc2hpcCB3aGVuIGVuYWJsaW5nIGRlbGVnYXRpb24uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImF1dGhvcml6ZSIsImRlc2MiOiJDaGVja3MgaWYgdGhlIGRlbGVnYXRpb24gaXMgYXV0aG9yaXplZCBmb3IgdGhlIChhY2NvdW50LCBhc3NldCkgcGFpci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIHVzZXIgdG8gY2hlY2suIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdGhlIGRlbGVnYXRpb24gbXVzdCBiZSBlbmFibGVkIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlIiwiZGVzYyI6IkVuYWJsZXMgQXV0b0RyYXcgZGVsZWdhdGlvbiBvZiB0aGUgZ2l2ZW4gYXNzZXQgZm9yIHRoZSBjYWxsZXIuXG5cblRoZSBkZWxlZ2F0aW9uIGlzIGtleWVkIGJ5IChUeG4uc2VuZGVyLCBhc3NldCkg4oCUIHRoZSBzYW1lIGtleSBgYXV0aG9yaXplYCBhbmQgYGtpbGxgXG51c2UsIGFuZCB0aGUgYWNjb3VudCB0aGUgQXV0b0RyYXcgTHNpZyBiaW5kcyB0byB0aGUgYXhmZXIgc2VuZGVyLlxuXG5HYXRlZCB0byBhY2NvdW50cyB0aGF0IG93biBhIGNhcmQgaW4gdGhlIE1haW4gY29udHJhY3QsIHRvIHByZXZlbnQgYWJ1c2Ugb2YgdGhlXG5vd25lci1mdW5kZWQgYm94IE1CUi4gVGhlIGNhbGxlciBtdXN0IHN1cHBseSBhIGNhcmQgYWRkcmVzcyB0aGV5IG93bjsgb3duZXJzaGlwIGlzXG52ZXJpZmllZCBhZ2FpbnN0IHRoZSBNYWluIGNvbnRyYWN0IHZpYSBhIGNyb3NzLWNvbnRyYWN0IGNhbGwuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkEgY2FyZCBhZGRyZXNzIG93bmVkIGJ5IHRoZSBjYWxsZXIsIHVzZWQgdG8gcHJvdmUgY2FyZCBvd25lcnNoaXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZW5hYmxlIGRlbGVnYXRpb24gZm9yLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJraWxsIiwiZGVzYyI6IkRpc2FibGVzIEF1dG9EcmF3IGRlbGVnYXRpb24gb2YgdGhlIGdpdmVuIGFzc2V0IGZvciB0aGUgY2FsbGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZGlzYWJsZSBkZWxlZ2F0aW9uIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlck93bmVyc2hpcCIsImRlc2MiOiJUcmFuc2ZlcnMgdGhlIG93bmVyc2hpcCBvZiB0aGUgY29udHJhY3QgdG8gYSBuZXcgb3duZXIuXG5SZXF1aXJlcyB0aGUgY2FsbGVyIHRvIGJlIHRoZSBjdXJyZW50IG93bmVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG5ldyBvd25lci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJQYXVzZXIncyBhZGRyZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQYXVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9uZXdQYXVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvdmVyQXNzZXQiLCJkZXNjIjoiUmVjb3ZlciBhbiBhc3NldCBzZW50IHRvIHRoZSBjb250cmFjdCBieSBtaXN0YWtlLiBPbmx5IHRoZSBvd25lciBjYW4gY2FsbCB0aGlzIGZ1bmN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJBc3NldCBJRCBvZiB0aGUgYXNzZXQgdG8gcmVjb3Zlci4gSWYgMCwgQWxnbyB3aWxsIGJlIHJlY292ZXJlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgb2YgdGhlIGFzc2V0IHRvIHJlY292ZXIuIElmIEFsZ29zLCByZW1lbWJlciB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOiJBZGRyZXNzIHRvIHNlbmQgdGhlIHJlY292ZXJlZCBhc3NldCB0by4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMjRdLCJlcnJvck1lc3NhZ2UiOiJBTFJFQURZX0RJU0FCTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM4XSwiZXJyb3JNZXNzYWdlIjoiQUxSRUFEWV9FTkFCTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3XSwiZXJyb3JNZXNzYWdlIjoiQVNTRVRfTk9UX0FMTE9XRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwXSwiZXJyb3JNZXNzYWdlIjoiTk9UX0NBUkRfT1dORVIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDddLCJlcnJvck1lc3NhZ2UiOiJSRUZVU0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA0XSwiZXJyb3JNZXNzYWdlIjoiU0VOREVSX05PVF9BTExPV0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5LDI1MywzMzIsMzU4LDUwMiw1MjAsNTQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3LDE4NiwyMTcsMzQ2LDQwMiw0NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU1LDE5NCwyMjUsMzEzLDQzMyw0NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL21haW4vY29udHJhY3QuYWxnby50czo6Q2FyZERhdGEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSWw5dmQyNWxjaUlnSWw5d1lYVnpaWElpSUNKd1lYVnpaV1FpSURCNE1UVXhaamRqTnpVZ0ltMWhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUV0cGJHeHpkMmwwWTJnZ1pYaDBaVzVrY3lCamJHRnpjMlZ6S0U5M2JtRmliR1VzSUZCaGRYTmhZbXhsTENCU1pXTnZkbVZ5WVdKc1pTa2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE5nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRTVNekV5WldZeElEQjRaRE0xT0dReFpUQWdNSGc0T0dOa05USTBZU0F3ZUdJeFltSmlNR0U0SURCNFpURTNZbUZtWWpRZ01IaGlNR1E1TlROaU15QXdlREF4TnpobU9UUmlJREI0TVdJMU1qbGtaVGdnTUhnd1kyRmtaREUyTXlBd2VEYzROV0V4WW1ZNUlDOHZJRzFsZEdodlpDQWlZWFYwYUc5eWFYcGxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1WdVlXSnNaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcmFXeHNLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmQyNWxjaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSndZWFZ6WlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0luQmhkWE5sS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm5CaGRYTmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWUVlYVnpaWElvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV052ZG1WeVFYTnpaWFFvZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaGRYUm9iM0pwZW1VZ1pXNWhZbXhsSUd0cGJHd2diM2R1WlhJZ2RISmhibk5tWlhKUGQyNWxjbk5vYVhBZ2NHRjFjMlZ5SUhCaGRYTmxJSFZ1Y0dGMWMyVWdkWEJrWVhSbFVHRjFjMlZ5SUhKbFkyOTJaWEpCYzNObGRBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUV0cGJHeHpkMmwwWTJnZ1pYaDBaVzVrY3lCamJHRnpjMlZ6S0U5M2JtRmliR1VzSUZCaGRYTmhZbXhsTENCU1pXTnZkbVZ5WVdKc1pTa2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjROelptWlRZNE5EUWdMeThnYldWMGFHOWtJQ0prWlhCc2Iza29ZV1JrY21WemN5eDFhVzUwTmpRcFlXUmtjbVZ6Y3lJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHUmxjR3h2ZVFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTMmxzYkhOM2FYUmphQzVrWlhCc2IzbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCc2IzazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBblhTd2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCMGFHbHpMbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h2ZDI1bGNpa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDNSeVlXNXpabVZ5VDNkdVpYSnphR2x3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUY5d1lYVnpaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZjR0YxYzJWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2RHaHBjeTVmY0dGMWMyVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVWdQU0JtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCd2RXSnNhV01nYldGcGJsOWhjSEFnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJQ2R0WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMWhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdkR2hwY3k1dFlXbHVYMkZ3Y0M1MllXeDFaU0E5SUcxaGFXNEtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBblhTd2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkowNXZUM0FuWFN3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcExhV3hzYzNkcGRHTm9MbUYxZEdodmNtbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GMWRHaHZjbWw2WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhCMVlteHBZeUJoZFhSb2IzSnBlbVVvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXdZWFZ6WldRdWRtRnNkV1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoWTJOdmRXNTBRWE56WlhSUVlXbHljeWhiWVdOamIzVnVkQ3dnWVhOelpYUmRLUzVsZUdsemRITXNJQ2RTUlVaVlUwVkVKeWtLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1VrVkdWVk5GUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnY0hWaWJHbGpJR0YxZEdodmNtbDZaU2hoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBMYVd4c2MzZHBkR05vTG1WdVlXSnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WdVlXSnNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJSEIxWW14cFl5QmxibUZpYkdVb1kyRnlaRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRnRVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjBnWVhNZ1FXTmpiM1Z1ZEVGemMyVjBTMlY1Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVlXTmpiM1Z1ZEVGemMyVjBVR0ZwY25Nb2EyVjVLUzVsZUdsemRITXNJQ2RCVEZKRlFVUlpYMFZPUVVKTVJVUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJURkpGUVVSWlgwVk9RVUpNUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUdGemMyVnlkQ2hqWVhKa0xtbHpUM0IwWldSSmJpaGhjM05sZENrc0lDZEJVMU5GVkY5T1QxUmZRVXhNVDFkRlJDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGVFUwVlVYMDVQVkY5QlRFeFBWMFZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0TFRFd01Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGeVpFUmhkR0VnUFNCaGNtTTBMbUZpYVVOaGJHdzhkSGx3Wlc5bUlFMWhhVzR1Y0hKdmRHOTBlWEJsTG1kbGRFTmhjbVJFWVhSaFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjBhR2x6TG0xaGFXNWZZWEJ3TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZMkZ5WkYwc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z1lYQndTV1E2SUhSb2FYTXViV0ZwYmw5aGNIQXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnY0hWaWJHbGpJRzFoYVc1ZllYQndJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQW5iV0VuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdFlTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklHRndjRWxrT2lCMGFHbHpMbTFoYVc1ZllYQndMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9DMHhNREVLSUNBZ0lDOHZJR052Ym5OMElHTmhjbVJFWVhSaElEMGdZWEpqTkM1aFltbERZV3hzUEhSNWNHVnZaaUJOWVdsdUxuQnliM1J2ZEhsd1pTNW5aWFJEWVhKa1JHRjBZVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NXRZV2x1WDJGd2NDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJOaGNtUmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjME5XUmlaakUySUM4dklHMWxkR2h2WkNBaVoyVjBRMkZ5WkVSaGRHRW9ZV1JrY21WemN5a29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTmhjbVJFWVhSaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOaGNtUkVZWFJoTG05M2JtVnlJRDA5UFNCVWVHNHVjMlZ1WkdWeUxDQW5UazlVWDBOQlVrUmZUMWRPUlZJbktRb2dJQ0FnWlhoMGNtRmpkQ0EwSURNeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNVBWRjlEUVZKRVgwOVhUa1ZTQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TkFvZ0lDQWdMeThnZEdocGN5NWhZMk52ZFc1MFFYTnpaWFJRWVdseWN5aHJaWGtwTG1OeVpXRjBaU2g3SUhOcGVtVTZJREFnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklIQjFZbXhwWXlCbGJtRmliR1VvWTJGeVpEb2dRV05qYjNWdWRDd2dZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTMmxzYkhOM2FYUmphQzVyYVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thMmxzYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCd2RXSnNhV01nYTJsc2JDaGhjM05sZERvZ1FYTnpaWFFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCamIyNXpkQ0JyWlhrZ1BTQmJWSGh1TG5ObGJtUmxjaXdnWVhOelpYUmRJR0Z6SUVGalkyOTFiblJCYzNObGRFdGxlUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdOamIzVnVkRUZ6YzJWMFVHRnBjbk1vYTJWNUtTNWxlR2x6ZEhNc0lDZEJURkpGUVVSWlgwUkpVMEZDVEVWRUp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVXhTUlVGRVdWOUVTVk5CUWt4RlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklIUm9hWE11WVdOamIzVnVkRUZ6YzJWMFVHRnBjbk1vYTJWNUtTNWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNZ29nSUNBZ0x5OGdjSFZpYkdsaklHdHBiR3dvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNlQzZHVZV0pzWlM1dmQyNWxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205M2JtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVgyOTNibVZ5TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdjSFZpYkdsaklGOXZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDl2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZPazkzYm1GaWJHVXVkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwY21GdWMyWmxjazkzYm1WeWMyaHBjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhCMVlteHBZeUIwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxQZDI1bGNpZ3BDaUFnSUNCallXeHNjM1ZpSUc5dWJIbFBkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2RHaHBjeTVmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvYm1WM1QzZHVaWElwQ2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdjSFZpYkdsaklIUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0tHNWxkMDkzYm1WeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk9sQmhkWE5oWW14bExuQmhkWE5sY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVmY0dGMWMyVnlMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCZmNHRjFjMlZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlYM0JoZFhObGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1ZmNHRjFjMlZ5TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndZWFZ6WlhJb0tUb2dRV05qYjNWdWRDQjdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPbEJoZFhOaFlteGxMbkJoZFhObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0YxYzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdkR2hwY3k1dmJteDVVR0YxYzJWeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VWQmhkWE5sY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklIQjFZbXhwWXlCd1lYVnpaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdkR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVWdQU0IwY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmxiV2wwUEZCaGRYTmxQaWg3ZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdObU1qTmhNekJtQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVW9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPbEJoZFhOaFlteGxMblZ1Y0dGMWMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxYm5CaGRYTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhSb2FYTXViMjVzZVZCaGRYTmxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxRWVhWelpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsSUQwZ1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUdWdGFYUThWVzV3WVhWelpUNG9lMzBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpTVRZelpXVXdZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnY0hWaWJHbGpJSFZ1Y0dGMWMyVW9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPbEJoZFhOaFlteGxMblZ3WkdGMFpWQmhkWE5sY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlZCaGRYTmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxVR0YxYzJWeUtGOXVaWGRRWVhWelpYSTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVkJoZFhObGNpZ3BDaUFnSUNCallXeHNjM1ZpSUc5dWJIbFFZWFZ6WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QmhjM05sY25Rb1gyNWxkMUJoZFhObGNpQWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56S1FvZ0lDQWdaSFZ3Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYM0JoZFhObGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5d1lYVnpaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z2RHaHBjeTVmY0dGMWMyVnlMblpoYkhWbElEMGdYMjVsZDFCaGRYTmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z1pXMXBkRHhRWVhWelpYSkRhR0Z1WjJWa1BpaDdJRzVsZDBGa1pISmxjM002SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFkyTTBNRGt5TTJNZ0x5OGdiV1YwYUc5a0lDSlFZWFZ6WlhKRGFHRnVaMlZrS0dGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QndkV0pzYVdNZ2RYQmtZWFJsVUdGMWMyVnlLRjl1WlhkUVlYVnpaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvNlVtVmpiM1psY21GaWJHVXVjbVZqYjNabGNrRnpjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmpiM1psY2tGemMyVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIQjFZbXhwWXlCeVpXTnZkbVZ5UVhOelpYUW9ZWE56WlhRNklFRnpjMlYwTENCaGJXOTFiblE2SUhWcGJuUTJOQ3dnY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzSmxZMjkyWlhKaFlteGxMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVTkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNtVmpiM1psY21GaWJHVXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdhV1lnS0dGemMyVjBMbWxrS1NCN0NpQWdJQ0JpZWlCeVpXTnZkbVZ5UVhOelpYUmZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qUXlMVFE0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPalF5TFRRM0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5eVpXTnZkbVZ5WVdKc1pTNWhiR2R2TG5Sek9qUXlMVFE0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncHlaV052ZG1WeVFYTnpaWFJmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNKbFkyOTJaWEpoWW14bExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIQjFZbXhwWXlCeVpXTnZkbVZ5UVhOelpYUW9ZWE56WlhRNklFRnpjMlYwTENCaGJXOTFiblE2SUhWcGJuUTJOQ3dnY21WamFYQnBaVzUwT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXTnZkbVZ5UVhOelpYUmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPalV3TFRVMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvMU1DMDFOQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pVd0xUVTFDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2djbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmlJSEpsWTI5MlpYSkJjM05sZEY5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPanBQZDI1aFlteGxMbTl1YkhsUGQyNWxjaWdwSUMwK0lIWnZhV1E2Q205dWJIbFBkMjVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxsOXZkMjVsY2k1MllXeDFaU3dnSjFORlRrUkZVbDlPVDFSZlFVeE1UMWRGUkNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnY0hWaWJHbGpJRjl2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWw5dmQyNWxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTd2dKMU5GVGtSRlVsOU9UMVJmUVV4TVQxZEZSQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk9rOTNibUZpYkdVdVgzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0tHNWxkMDkzYm1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMMjkzYm1GaWJHVXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdjSEp2ZEdWamRHVmtJRjkwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVjJhVzkxYzA5M2JtVnlJRDBnZEdocGN5NWZiM2R1WlhJdWFHRnpWbUZzZFdVZ1B5QjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSEIxWW14cFl5QmZiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pmYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJqYjI1emRDQndjbVYyYVc5MWMwOTNibVZ5SUQwZ2RHaHBjeTVmYjNkdVpYSXVhR0Z6Vm1Gc2RXVWdQeUIwYUdsekxsOXZkMjVsY2k1MllXeDFaU0E2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dYM1J5WVc1elptVnlUM2R1WlhKemFHbHdYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVjJhVzkxYzA5M2JtVnlJRDBnZEdocGN5NWZiM2R1WlhJdWFHRnpWbUZzZFdVZ1B5QjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtDbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjRjkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYMjkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWDI5M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnUFNCdVpYZFBkMjVsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvM09DMDRNUW9nSUNBZ0x5OGdaVzFwZER4UGQyNWxjbk5vYVhCVWNtRnVjMlpsY25KbFpENG9ld29nSUNBZ0x5OGdJQ0J3Y21WMmFXOTFjMDkzYm1WeU9pQndjbVYyYVc5MWMwOTNibVZ5TEFvZ0lDQWdMeThnSUNCdVpYZFBkMjVsY2pvZ2JtVjNUM2R1WlhJc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEbGhNakl6WldaaUlDOHZJRzFsZEdodlpDQWlUM2R1WlhKemFHbHdWSEpoYm5ObVpYSnlaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0NsOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVjJhVzkxYzA5M2JtVnlJRDBnZEdocGN5NWZiM2R1WlhJdWFHRnpWbUZzZFdVZ1B5QjBhR2x6TGw5dmQyNWxjaTUyWVd4MVpTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem82VUdGMWMyRmliR1V1YjI1c2VWQmhkWE5sY2lncElDMCtJSFp2YVdRNkNtOXViSGxRWVhWelpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WDNCaGRYTmxjaTUyWVd4MVpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUY5d1lYVnpaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZjR0YxYzJWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbDl3WVhWelpYSXVkbUZzZFdVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0NDWUZCbDl2ZDI1bGNnZGZjR0YxYzJWeUJuQmhkWE5sWkFRVkgzeDFBbTFoTVJrVVJERVlRUUJPZ2dvRXFURXU4UVRUV05IZ0JJak5Va29Fc2J1d3FBVGhlNiswQkxEWlU3TUVBWGo1U3dRYlVwM29CQXl0MFdNRWVGb2IrVFlhQUk0S0FEWUFWUUMxQU13QTFnRG1BUEFBL3dFT0FTMEFnQVIyL21oRU5ob0FqZ0VBQVFBMkdnRkpGU1FTUkRZYUFra1ZKUkpFRjB5SUFWa3BNUUJuS2lKbkp3Uk1aeXN5Q2xDd0kwTTJHZ0ZKRlNRU1JEWWFBa2tWSlJKRUZ5SXFaVVFVUkJaUXZVVUJSQ05ETmhvQlNSVWtFa1EyR2dKSkZTVVNSQmN4QUVzQkZsQkp2VVVCRkVSTEFrOENjQUJGQVVTeElpY0VaVVN5R0lBRWRGMi9GcklhVExJYWdRYXlFQ0t5QWJPMFBrbFhCQUJMQVZjQUJDc1NSQldCVUJKRVZ3UWdNUUFTUkNLNVNDTkROaG9CU1JVbEVrUVhNUUJNRmxCSnZVVUJSTHhJSTBNaUtHVkVLMHhRc0NORE5ob0JTUlVrRWtTSUFKT0lBSmtqUXlJcFpVUXJURkN3STBPSUFLOHFJMmVBQk04am93K3dJME9JQUtBcUltZUFCTEZqN2d1d0kwTTJHZ0ZKRlNRU1JJZ0FpVWt5QXhORUtVc0JaNEFFekVDU1BFeFFzQ05ETmhvQlNSVWxFa1FYU1RZYUFra1ZKUkpFRjA0Q05ob0RTVTRDRlNRU1JJZ0FKVUVBRWJHeUZMSVJzaEtCQkxJUUlySUJzeU5EUlFHeHNnZXlDQ095RUNLeUFiTkMvKzB4QUNJb1pVUVNSSW1LQVFBaUtHVkZBVUVBRlNJb1pVUW9pLzluaS85UWdBU2FJajc3VEZDd2lUSURRdi9xTVFBaUtXVkVFa1NKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXX0seyJuYW1lIjoiUGF1c2VyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
