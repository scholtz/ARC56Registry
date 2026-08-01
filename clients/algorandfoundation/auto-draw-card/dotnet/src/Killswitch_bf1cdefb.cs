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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2lsbHN3aXRjaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkZXBsb3kiLCJkZXNjIjoiRGVwbG95IHRoZSBjb250cmFjdCwgc2V0dGluZyB0aGUgb3duZXIgYXMgcHJvdmlkZWQgYW5kIGluaXRpYWxpemluZyBnbG9iYWwgc3RhdGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBzZXQgYXMgdGhlIGNvbnRyYWN0IG93bmVyLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFpbiIsImRlc2MiOiJUaGUgTWFpbiBjb250cmFjdCB1c2VkIHRvIHZlcmlmeSBjYXJkIG93bmVyc2hpcCB3aGVuIGVuYWJsaW5nIGRlbGVnYXRpb24uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImF1dGhvcml6ZSIsImRlc2MiOiJDaGVja3MgaWYgdGhlIGRlbGVnYXRpb24gaXMgYXV0aG9yaXplZCBmb3IgdGhlIChhY2NvdW50LCBhc3NldCkgcGFpci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIHVzZXIgdG8gY2hlY2suIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdGhlIGRlbGVnYXRpb24gbXVzdCBiZSBlbmFibGVkIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlIiwiZGVzYyI6IkVuYWJsZXMgQXV0b0RyYXcgZGVsZWdhdGlvbiBvZiB0aGUgZ2l2ZW4gYXNzZXQgZm9yIHRoZSBjYWxsZXIuXG5cblRoZSBkZWxlZ2F0aW9uIGlzIGtleWVkIGJ5IChUeG4uc2VuZGVyLCBhc3NldCkg4oCUIHRoZSBzYW1lIGtleSBgYXV0aG9yaXplYCBhbmQgYGtpbGxgXG51c2UsIGFuZCB0aGUgYWNjb3VudCB0aGUgQXV0b0RyYXcgTHNpZyBiaW5kcyB0byB0aGUgYXhmZXIgc2VuZGVyLlxuXG5HYXRlZCB0byBhY2NvdW50cyB0aGF0IG93biBhIGNhcmQgaW4gdGhlIE1haW4gY29udHJhY3QsIHRvIHByZXZlbnQgYWJ1c2Ugb2YgdGhlXG5vd25lci1mdW5kZWQgYm94IE1CUi4gVGhlIGNhbGxlciBtdXN0IHN1cHBseSBhIGNhcmQgYWRkcmVzcyB0aGV5IG93bjsgb3duZXJzaGlwIGlzXG52ZXJpZmllZCBhZ2FpbnN0IHRoZSBNYWluIGNvbnRyYWN0IHZpYSBhIGNyb3NzLWNvbnRyYWN0IGNhbGwuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXJkIiwiZGVzYyI6IkEgY2FyZCBhZGRyZXNzIG93bmVkIGJ5IHRoZSBjYWxsZXIsIHVzZWQgdG8gcHJvdmUgY2FyZCBvd25lcnNoaXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZW5hYmxlIGRlbGVnYXRpb24gZm9yLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJraWxsIiwiZGVzYyI6IkRpc2FibGVzIEF1dG9EcmF3IGRlbGVnYXRpb24gb2YgdGhlIGdpdmVuIGFzc2V0IGZvciB0aGUgY2FsbGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gZGlzYWJsZSBkZWxlZ2F0aW9uIGZvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlck93bmVyc2hpcCIsImRlc2MiOiJUcmFuc2ZlcnMgdGhlIG93bmVyc2hpcCBvZiB0aGUgY29udHJhY3QgdG8gYSBuZXcgb3duZXIuXG5SZXF1aXJlcyB0aGUgY2FsbGVyIHRvIGJlIHRoZSBjdXJyZW50IG93bmVyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG5ldyBvd25lci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJQYXVzZXIncyBhZGRyZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQYXVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9uZXdQYXVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvdmVyQXNzZXQiLCJkZXNjIjoiUmVjb3ZlciBhbiBhc3NldCBzZW50IHRvIHRoZSBjb250cmFjdCBieSBtaXN0YWtlLiBPbmx5IHRoZSBvd25lciBjYW4gY2FsbCB0aGlzIGZ1bmN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJBc3NldCBJRCBvZiB0aGUgYXNzZXQgdG8gcmVjb3Zlci4gSWYgMCwgQWxnbyB3aWxsIGJlIHJlY292ZXJlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJBbW91bnQgb2YgdGhlIGFzc2V0IHRvIHJlY292ZXIuIElmIEFsZ29zLCByZW1lbWJlciB0aGUgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOiJBZGRyZXNzIHRvIHNlbmQgdGhlIHJlY292ZXJlZCBhc3NldCB0by4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMTRdLCJlcnJvck1lc3NhZ2UiOiJBTFJFQURZX0RJU0FCTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3XSwiZXJyb3JNZXNzYWdlIjoiQUxSRUFEWV9FTkFCTEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc4XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MF0sImVycm9yTWVzc2FnZSI6Ik5PVF9DQVJEX09XTkVSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3XSwiZXJyb3JNZXNzYWdlIjoiUkVGVVNFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5NF0sImVycm9yTWVzc2FnZSI6IlNFTkRFUl9OT1RfQUxMT1dFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwyNDMsMzIyLDM0OCw0OTIsNTEwLDUzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NywxODYsMjE3LDMzNiwzOTIsNDQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSwxOTQsMjI1LDMwMyw0MjMsNDMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9tYWluL2NvbnRyYWN0LmFsZ28udHM6OkNhcmREYXRhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lsOXZkMjVsY2lJZ0lsOXdZWFZ6WlhJaUlDSndZWFZ6WldRaUlEQjRNVFV4Wmpkak56VWdJbTFoSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFdHBiR3h6ZDJsMFkyZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0U1TXpFeVpXWXhJREI0WkRNMU9HUXhaVEFnTUhnNE9HTmtOVEkwWVNBd2VHSXhZbUppTUdFNElEQjRaVEUzWW1GbVlqUWdNSGhpTUdRNU5UTmlNeUF3ZURBeE56aG1PVFJpSURCNE1XSTFNamxrWlRnZ01IZ3dZMkZrWkRFMk15QXdlRGM0TldFeFltWTVJQzh2SUcxbGRHaHZaQ0FpWVhWMGFHOXlhWHBsS0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVnVZV0pzWlNoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnJhV3hzS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZkMjVsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKUGQyNWxjbk5vYVhBb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p3WVhWelpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbkJoZFhObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWJuQmhkWE5sS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVlFZWFZ6WlhJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldOdmRtVnlRWE56WlhRb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmhkWFJvYjNKcGVtVWdaVzVoWW14bElHdHBiR3dnYjNkdVpYSWdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQWdjR0YxYzJWeUlIQmhkWE5sSUhWdWNHRjFjMlVnZFhCa1lYUmxVR0YxYzJWeUlISmxZMjkyWlhKQmMzTmxkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFdHBiR3h6ZDJsMFkyZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektFOTNibUZpYkdVc0lGQmhkWE5oWW14bExDQlNaV052ZG1WeVlXSnNaU2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpabVpUWTRORFFnTHk4Z2JXVjBhRzlrSUNKa1pYQnNiM2tvWVdSa2NtVnpjeXgxYVc1ME5qUXBZV1JrY21WemN5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR1JsY0d4dmVRb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UzJsc2JITjNhWFJqYUM1a1pYQnNiM2xiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pYQnNiM2s2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjA1dlQzQW5YU3dnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QjBhR2x6TGw5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodmQyNWxjaWtLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklGOXdZWFZ6WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmY0dGMWMyVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdkR2hwY3k1ZmNHRjFjMlZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnZEdocGN5NXdZWFZ6WldRdWRtRnNkV1VnUFNCbVlXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2JXRnBibDloY0hBZ1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUNkdFlTY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTFoSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnZEdocGN5NXRZV2x1WDJGd2NDNTJZV3gxWlNBOUlHMWhhVzRLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjA1dlQzQW5YU3dnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMDV2VDNBblhTd2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBMYVd4c2MzZHBkR05vTG1GMWRHaHZjbWw2WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRjFkR2h2Y21sNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIQjFZbXhwWXlCaGRYUm9iM0pwZW1Vb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTV3WVhWelpXUXVkbUZzZFdVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aFkyTnZkVzUwUVhOelpYUlFZV2x5Y3loYllXTmpiM1Z1ZEN3Z1lYTnpaWFJkS1M1bGVHbHpkSE1zSUNkU1JVWlZVMFZFSnlrS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVa1ZHVlZORlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdGMWRHaHZjbWw2WlNoaFkyTnZkVzUwT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsc2JITjNhWFJqYUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTGFXeHNjM2RwZEdOb0xtVnVZV0pzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtVnVZV0pzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RNS0lDQWdJQzh2SUhCMVlteHBZeUJsYm1GaWJHVW9ZMkZ5WkRvZ1FXTmpiM1Z1ZEN3Z1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUZ0VWVHNHVjMlZ1WkdWeUxDQmhjM05sZEYwZ1lYTWdRV05qYjNWdWRFRnpjMlYwUzJWNUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NWhZMk52ZFc1MFFYTnpaWFJRWVdseWN5aHJaWGtwTG1WNGFYTjBjeXdnSjBGTVVrVkJSRmxmUlU1QlFreEZSQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZNVWtWQlJGbGZSVTVCUWt4RlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU55MHhNREFLSUNBZ0lDOHZJR052Ym5OMElHTmhjbVJFWVhSaElEMGdZWEpqTkM1aFltbERZV3hzUEhSNWNHVnZaaUJOWVdsdUxuQnliM1J2ZEhsd1pTNW5aWFJEWVhKa1JHRjBZVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NXRZV2x1WDJGd2NDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJOaGNtUmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR0Z3Y0Vsa09pQjBhR2x6TG0xaGFXNWZZWEJ3TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXeHNjM2RwZEdOb0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCdFlXbHVYMkZ3Y0NBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nSjIxaEp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliV0VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJoY0hCSlpEb2dkR2hwY3k1dFlXbHVYMkZ3Y0M1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGN0TVRBd0NpQWdJQ0F2THlCamIyNXpkQ0JqWVhKa1JHRjBZU0E5SUdGeVl6UXVZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXRnBiaTV3Y205MGIzUjVjR1V1WjJWMFEyRnlaRVJoZEdFK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11YldGcGJsOWhjSEF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGpZWEprWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNORFZrWW1ZeE5pQXZMeUJ0WlhSb2IyUWdJbWRsZEVOaGNtUkVZWFJoS0dGa1pISmxjM01wS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEWVhKa1JHRjBZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBiR3h6ZDJsMFkyZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpZWEprUkdGMFlTNXZkMjVsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjA1UFZGOURRVkpFWDA5WFRrVlNKeWtLSUNBZ0lHVjRkSEpoWTNRZ05DQXpNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPVDFSZlEwRlNSRjlQVjA1RlVnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJHeHpkMmwwWTJndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklIUm9hWE11WVdOamIzVnVkRUZ6YzJWMFVHRnBjbk1vYTJWNUtTNWpjbVZoZEdVb2V5QnphWHBsT2lBd0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmxzYkhOM2FYUmphQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaVzVoWW14bEtHTmhjbVE2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVd4c2MzZHBkR05vTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t0cGJHeHpkMmwwWTJndWEybHNiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q210cGJHdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNUW9nSUNBZ0x5OGdjSFZpYkdsaklHdHBiR3dvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHNiSE4zYVhSamFDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNZ29nSUNBZ0x5OGdZMjl1YzNRZ2EyVjVJRDBnVzFSNGJpNXpaVzVrWlhJc0lHRnpjMlYwWFNCaGN5QkJZMk52ZFc1MFFYTnpaWFJMWlhrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRmpZMjkxYm5SQmMzTmxkRkJoYVhKektHdGxlU2t1WlhocGMzUnpMQ0FuUVV4U1JVRkVXVjlFU1ZOQlFreEZSQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGTVVrVkJSRmxmUkVsVFFVSk1SVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhV3hzYzNkcGRHTm9MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUIwYUdsekxtRmpZMjkxYm5SQmMzTmxkRkJoYVhKektHdGxlU2t1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYkd4emQybDBZMmd2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhCMVlteHBZeUJyYVd4c0tHRnpjMlYwT2lCQmMzTmxkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZPazkzYm1GaWJHVXViM2R1WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZkMjVsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbDl2ZDI1bGNpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJmYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZmIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pwUGQyNWhZbXhsTG5SeVlXNXpabVZ5VDNkdVpYSnphR2x3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RISmhibk5tWlhKUGQyNWxjbk5vYVhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QndkV0pzYVdNZ2RISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z2RHaHBjeTV2Ym14NVQzZHVaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VDNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJSFJvYVhNdVgzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0tHNWxkMDkzYm1WeUtRb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhCMVlteHBZeUIwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPanBRWVhWellXSnNaUzV3WVhWelpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3WVhWelpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVgzQmhkWE5sY2k1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYM0JoZFhObGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5d1lYVnpaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM0JoZFhObGNpNTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCd2RXSnNhV01nY0dGMWMyVnlLQ2s2SUVGalkyOTFiblFnZXdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1d1lYVnpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGRYTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSb2FYTXViMjVzZVZCaGRYTmxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxRWVhWelpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl3WVhWellXSnNaUzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDNCaGRYTmhZbXhsTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSb2FYTXVjR0YxYzJWa0xuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnWlcxcGREeFFZWFZ6WlQ0b2UzMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpaakl6WVRNd1pnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdjSFZpYkdsaklIQmhkWE5sS0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1MWJuQmhkWE5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RXNXdZWFZ6WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QjBhR2x6TG05dWJIbFFZWFZ6WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVVHRjFjMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGRYTmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhkWE5sWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QjBhR2x6TG5CaGRYTmxaQzUyWVd4MVpTQTlJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXdZWFZ6WVdKc1pTNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QmxiV2wwUEZWdWNHRjFjMlUrS0h0OUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqRTJNMlZsTUdJS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklIQjFZbXhwWXlCMWJuQmhkWE5sS0NrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pwUVlYVnpZV0pzWlM1MWNHUmhkR1ZRWVhWelpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVlFZWFZ6WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjR0YxYzJGaWJHVXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlZCaGRYTmxjaWhmYm1WM1VHRjFjMlZ5T2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCMGFHbHpMbTl1YkhsUVlYVnpaWElvS1FvZ0lDQWdZMkZzYkhOMVlpQnZibXg1VUdGMWMyVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWVhOelpYSjBLRjl1WlhkUVlYVnpaWElnSVQwOUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5a0tJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNHRjFjMkZpYkdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUY5d1lYVnpaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZjR0YxYzJWeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJSFJvYVhNdVgzQmhkWE5sY2k1MllXeDFaU0E5SUY5dVpYZFFZWFZ6WlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR1Z0YVhROFVHRjFjMlZ5UTJoaGJtZGxaRDRvZXlCdVpYZEJaR1J5WlhOek9pQjBhR2x6TGw5d1lYVnpaWEl1ZG1Gc2RXVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR05qTkRBNU1qTmpJQzh2SUcxbGRHaHZaQ0FpVUdGMWMyVnlRMmhoYm1kbFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y0dGMWMyRmliR1V1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWQmhkWE5sY2loZmJtVjNVR0YxYzJWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzSmxZMjkyWlhKaFlteGxMbUZzWjI4dWRITTZPbEpsWTI5MlpYSmhZbXhsTG5KbFkyOTJaWEpCYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWTI5MlpYSkJjM05sZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVZqYjNabGNrRnpjMlYwS0dGemMyVjBPaUJCYzNObGRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRc0lISmxZMmx3YVdWdWREb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl5WldOdmRtVnlZV0pzWlM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbTl1YkhsUGQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxQZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0psWTI5MlpYSmhZbXhsTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUdsbUlDaGhjM05sZEM1cFpDa2dld29nSUNBZ1lub2djbVZqYjNabGNrRnpjMlYwWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem8wTWkwME9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvME1pMDBOd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZjbVZqYjNabGNtRmliR1V1WVd4bmJ5NTBjem8wTWkwME9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LY21WamIzWmxja0Z6YzJWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXlaV052ZG1WeVlXSnNaUzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVZqYjNabGNrRnpjMlYwS0dGemMyVjBPaUJCYzNObGRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRc0lISmxZMmx3YVdWdWREb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZqYjNabGNrRnpjMlYwWDJWc2MyVmZZbTlrZVVBME9nb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12Y21WamIzWmxjbUZpYkdVdVlXeG5ieTUwY3pvMU1DMDFOUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzSmxZMjkyWlhKaFlteGxMbUZzWjI4dWRITTZOVEF0TlRRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmNtVmpiM1psY21GaWJHVXVZV3huYnk1MGN6bzFNQzAxTlFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWWlCeVpXTnZkbVZ5UVhOelpYUmZZV1owWlhKZmFXWmZaV3h6WlVBMkNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvNlQzZHVZV0pzWlM1dmJteDVUM2R1WlhJb0tTQXRQaUIyYjJsa09ncHZibXg1VDNkdVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVc0lDZFRSVTVFUlZKZlRrOVVYMEZNVEU5WFJVUW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCZmIzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZiM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y205c1pYTXZiM2R1WVdKc1pTNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VzSUNkVFJVNUVSVkpmVGs5VVgwRk1URTlYUlVRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMFZPUkVWU1gwNVBWRjlCVEV4UFYwVkVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPanBQZDI1aFlteGxMbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nWW5sMFpYTXBJQzArSUhadmFXUTZDbDkwY21GdWMyWmxjazkzYm1WeWMyaHBjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5dmQyNWhZbXhsTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhCeWIzUmxZM1JsWkNCZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbTlzWlhNdmIzZHVZV0pzWlM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCd2RXSnNhV01nWDI5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVgyOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKbGRtbHZkWE5QZDI1bGNpQTlJSFJvYVhNdVgyOTNibVZ5TG1oaGMxWmhiSFZsSUQ4Z2RHaHBjeTVmYjNkdVpYSXVkbUZzZFdVZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtOXNaWE12YjNkdVlXSnNaUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdYMjkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWDI5M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2dwZmRISmhibk5tWlhKUGQyNWxjbk5vYVhCZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwyOTNibUZpYkdVdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUY5dmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOXZkMjVsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5YjJ4bGN5OXZkMjVoWW14bExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklIUm9hWE11WDI5M2JtVnlMblpoYkhWbElEMGdibVYzVDNkdVpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eWIyeGxjeTl2ZDI1aFlteGxMbUZzWjI4dWRITTZOemd0T0RFS0lDQWdJQzh2SUdWdGFYUThUM2R1WlhKemFHbHdWSEpoYm5ObVpYSnlaV1ErS0hzS0lDQWdJQzh2SUNBZ2NISmxkbWx2ZFhOUGQyNWxjam9nY0hKbGRtbHZkWE5QZDI1bGNpd0tJQ0FnSUM4dklDQWdibVYzVDNkdVpYSTZJRzVsZDA5M2JtVnlMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WVRJeU0yVm1ZaUF2THlCdFpYUm9iMlFnSWs5M2JtVnljMmhwY0ZSeVlXNXpabVZ5Y21Wa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ3BmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEJmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSnZiR1Z6TDI5M2JtRmliR1V1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWTI5dWMzUWdjSEpsZG1sdmRYTlBkMjVsY2lBOUlIUm9hWE11WDI5M2JtVnlMbWhoYzFaaGJIVmxJRDhnZEdocGN5NWZiM2R1WlhJdWRtRnNkV1VnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lpQmZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk9sQmhkWE5oWW14bExtOXViSGxRWVhWelpYSW9LU0F0UGlCMmIybGtPZ3B2Ym14NVVHRjFjMlZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0p2YkdWekwzQmhkWE5oWW14bExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxsOXdZWFZ6WlhJdWRtRnNkV1VwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKdmJHVnpMM0JoZFhOaFlteGxMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEIxWW14cFl5QmZjR0YxYzJWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDNCaGRYTmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXliMnhsY3k5d1lYVnpZV0pzWlM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1ZmNHRjFjMlZ5TG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lGQmw5dmQyNWxjZ2RmY0dGMWMyVnlCbkJoZFhObFpBUVZIM3gxQW0xaE1Sa1VSREVZUVFCT2dnb0VxVEV1OFFUVFdOSGdCSWpOVWtvRXNidXdxQVRoZTYrMEJMRFpVN01FQVhqNVN3UWJVcDNvQkF5dDBXTUVlRm9iK1RZYUFJNEtBRFlBVlFDckFNSUF6QURjQU9ZQTlRRUVBU01BZ0FSMi9taEVOaG9BamdFQUFRQTJHZ0ZKRlNRU1JEWWFBa2tWSlJKRUYweUlBVThwTVFCbktpSm5Kd1JNWnlzeUNsQ3dJME0yR2dGSkZTUVNSRFlhQWtrVkpSSkVGeUlxWlVRVVJCWlF2VVVCUkNORE5ob0JTUlVrRWtRMkdnSkpGU1VTUkJjeEFFd1dVRW05UlFFVVJMRWlKd1JsUkxJWWdBUjBYYjhXc2hwTXNocUJCcklRSXJJQnM3UStTVmNFQUVzQlZ3QUVLeEpFRllGUUVrUlhCQ0F4QUJKRUlybElJME0yR2dGSkZTVVNSQmN4QUV3V1VFbTlSUUZFdkVnalF5SW9aVVFyVEZDd0kwTTJHZ0ZKRlNRU1JJZ0FrNGdBbVNORElpbGxSQ3RNVUxBalE0Z0FyeW9qWjRBRXp5T2pEN0FqUTRnQW9Db2laNEFFc1dQdUM3QWpRellhQVVrVkpCSkVpQUNKU1RJREUwUXBTd0ZuZ0FUTVFKSThURkN3STBNMkdnRkpGU1VTUkJkSk5ob0NTUlVsRWtRWFRnSTJHZ05KVGdJVkpCSkVpQUFsUVFBUnNiSVVzaEd5RW9FRXNoQWlzZ0d6STBORkFiR3lCN0lJSTdJUUlySUJzMEwvN1RFQUlpaGxSQkpFaVlvQkFDSW9aVVVCUVFBVklpaGxSQ2lMLzJlTC8xQ0FCSm9pUHZ0TVVMQ0pNZ05DLytveEFDSXBaVVFTUklrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdfSx7Im5hbWUiOiJVbnBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W119LHsibmFtZSI6IlBhdXNlckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0FkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
