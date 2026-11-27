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

namespace Arc56.Generated.akita_protocol.akita_sc.MockFakeDAO_eccfe804
{


    //
    // TEST-ONLY (E26/T43). A fake DAO whose `AkitaAppList.wallet` names a rogue "wallet factory":
    //this app itself, which spawns `MockFakeWallet` children (creator = this app). A wallet admin can
    //point a genuine wallet's `akita_dao` here (`setAkitaDAO`), so any consumer that took the wallet
    //factory from `W.akita_dao` would accept the rogue children as genuine. Never deploy outside tests.
    //
    public class MockFakeDAOProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockFakeDAOProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AkitaAppList : AVMObjectType
            {
                public ulong Staking { get; set; }

                public ulong Rewards { get; set; }

                public ulong Pool { get; set; }

                public ulong PrizeBox { get; set; }

                public ulong Subscriptions { get; set; }

                public ulong Gate { get; set; }

                public ulong Auction { get; set; }

                public ulong HyperSwap { get; set; }

                public ulong Raffle { get; set; }

                public ulong MetaMerkles { get; set; }

                public ulong Marketplace { get; set; }

                public ulong Wallet { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStaking = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStaking.From(Staking);
                    ret.AddRange(vStaking.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewards = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRewards.From(Rewards);
                    ret.AddRange(vRewards.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPool.From(Pool);
                    ret.AddRange(vPool.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrizeBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrizeBox.From(PrizeBox);
                    ret.AddRange(vPrizeBox.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSubscriptions.From(Subscriptions);
                    ret.AddRange(vSubscriptions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGate.From(Gate);
                    ret.AddRange(vGate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAuction.From(Auction);
                    ret.AddRange(vAuction.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHyperSwap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHyperSwap.From(HyperSwap);
                    ret.AddRange(vHyperSwap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRaffle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRaffle.From(Raffle);
                    ret.AddRange(vRaffle.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetaMerkles = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMetaMerkles.From(MetaMerkles);
                    ret.AddRange(vMetaMerkles.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMarketplace.From(Marketplace);
                    ret.AddRange(vMarketplace.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AkitaAppList Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AkitaAppList();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStaking = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStaking.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStaking = vStaking.ToValue();
                    if (valueStaking is ulong vStakingValue) { ret.Staking = vStakingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRewards = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRewards.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRewards = vRewards.ToValue();
                    if (valueRewards is ulong vRewardsValue) { ret.Rewards = vRewardsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePool = vPool.ToValue();
                    if (valuePool is ulong vPoolValue) { ret.Pool = vPoolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrizeBox = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrizeBox.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrizeBox = vPrizeBox.ToValue();
                    if (valuePrizeBox is ulong vPrizeBoxValue) { ret.PrizeBox = vPrizeBoxValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSubscriptions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSubscriptions = vSubscriptions.ToValue();
                    if (valueSubscriptions is ulong vSubscriptionsValue) { ret.Subscriptions = vSubscriptionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGate = vGate.ToValue();
                    if (valueGate is ulong vGateValue) { ret.Gate = vGateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAuction.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuction = vAuction.ToValue();
                    if (valueAuction is ulong vAuctionValue) { ret.Auction = vAuctionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHyperSwap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHyperSwap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHyperSwap = vHyperSwap.ToValue();
                    if (valueHyperSwap is ulong vHyperSwapValue) { ret.HyperSwap = vHyperSwapValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRaffle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRaffle.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRaffle = vRaffle.ToValue();
                    if (valueRaffle is ulong vRaffleValue) { ret.Raffle = vRaffleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetaMerkles = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMetaMerkles.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetaMerkles = vMetaMerkles.ToValue();
                    if (valueMetaMerkles is ulong vMetaMerklesValue) { ret.MetaMerkles = vMetaMerklesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMarketplace.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMarketplace = vMarketplace.ToValue();
                    if (valueMarketplace is ulong vMarketplaceValue) { ret.Marketplace = vMarketplaceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is ulong vWalletValue) { ret.Wallet = vWalletValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AkitaAppList);
                }
                public bool Equals(AkitaAppList? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AkitaAppList left, AkitaAppList right)
                {
                    return EqualityComparer<AkitaAppList>.Default.Equals(left, right);
                }
                public static bool operator !=(AkitaAppList left, AkitaAppList right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Point `AkitaAppList.gate` at `gate` (gateCheckCtx tests use an approve-all stand-in gate).
        ///</summary>
        /// <param name="gate"> </param>
        public async Task SetGate(ulong gate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 168, 196, 144 };
            var gateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAbi.From(gate);

            var result = await base.CallApp(new List<object> { abiHandle, gateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGate_Transactions(ulong gate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 168, 196, 144 };
            var gateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAbi.From(gate);

            return await base.MakeTransactionList(new List<object> { abiHandle, gateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a fake wallet child (creator = this app, the rogue factory). Fund this app first.
        ///</summary>
        /// <param name="controlledAddress"> </param>
        /// <param name="referrer"> </param>
        /// <param name="spendingAddress"> </param>
        public async Task<ulong> Spawn(Algorand.Address controlledAddress, Algorand.Address referrer, Algorand.Address spendingAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 241, 54, 193 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var spendingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spendingAddressAbi.From(spendingAddress);

            var result = await base.CallApp(new List<object> { abiHandle, controlledAddressAbi, referrerAbi, spendingAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Spawn_Transactions(Algorand.Address controlledAddress, Algorand.Address referrer, Algorand.Address spendingAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 241, 54, 193 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var spendingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spendingAddressAbi.From(spendingAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, controlledAddressAbi, referrerAbi, spendingAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0Zha2VEQU8iLCJkZXNjIjoiVEVTVC1PTkxZIChFMjYvVDQzKS4gQSBmYWtlIERBTyB3aG9zZSBgQWtpdGFBcHBMaXN0LndhbGxldGAgbmFtZXMgYSByb2d1ZSBcIndhbGxldCBmYWN0b3J5XCI6XG50aGlzIGFwcCBpdHNlbGYsIHdoaWNoIHNwYXducyBgTW9ja0Zha2VXYWxsZXRgIGNoaWxkcmVuIChjcmVhdG9yID0gdGhpcyBhcHApLiBBIHdhbGxldCBhZG1pbiBjYW5cbnBvaW50IGEgZ2VudWluZSB3YWxsZXQncyBgYWtpdGFfZGFvYCBoZXJlIChgc2V0QWtpdGFEQU9gKSwgc28gYW55IGNvbnN1bWVyIHRoYXQgdG9vayB0aGUgd2FsbGV0XG5mYWN0b3J5IGZyb20gYFcuYWtpdGFfZGFvYCB3b3VsZCBhY2NlcHQgdGhlIHJvZ3VlIGNoaWxkcmVuIGFzIGdlbnVpbmUuIE5ldmVyIGRlcGxveSBvdXRzaWRlIHRlc3RzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBa2l0YUFwcExpc3QiOlt7Im5hbWUiOiJzdGFraW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJld2FyZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicG9vbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcml6ZUJveCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdWJzY3JpcHRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImdhdGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXVjdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJoeXBlclN3YXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmFmZmxlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGFNZXJrbGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1hcmtldHBsYWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndhbGxldCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEdhdGUiLCJkZXNjIjoiUG9pbnQgYEFraXRhQXBwTGlzdC5nYXRlYCBhdCBgZ2F0ZWAgKGdhdGVDaGVja0N0eCB0ZXN0cyB1c2UgYW4gYXBwcm92ZS1hbGwgc3RhbmQtaW4gZ2F0ZSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Bhd24iLCJkZXNjIjoiQ3JlYXRlIGEgZmFrZSB3YWxsZXQgY2hpbGQgKGNyZWF0b3IgPSB0aGlzIGFwcCwgdGhlIHJvZ3VlIGZhY3RvcnkpLiBGdW5kIHRoaXMgYXBwIGZpcnN0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJvbGxlZEFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZlcnJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kaW5nQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1LDE5MywyMDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaFlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Wm1GclpTMWtZVzh2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXZZMnRHWVd0bFJFRlBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlqUmhPR00wT1RBZ01IaGlNR1l4TXpaak1TQXZMeUJ0WlhSb2IyUWdJbk5sZEVkaGRHVW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Od1lYZHVLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOektYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkRWRoZEdVZ2MzQmhkMjRLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0WkdGdkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOYjJOclJtRnJaVVJCVHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSak5XTTJNV0poSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZabUZyWlMxa1lXOHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTBaaGEyVkVRVTh1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRaR0Z2TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhkaGJHeGxkRG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1sa0xBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzFrWVc4dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9DMHpNUW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVUZ3Y0V4cGMzUXVkbUZzZFdVZ1BTQjdDaUFnSUNBdkx5QWdJSE4wWVd0cGJtYzZJREFzQ2lBZ0lDQXZMeUFnSUhKbGQyRnlaSE02SURBc0NpQWdJQ0F2THlBZ0lIQnZiMnc2SURBc0NpQWdJQ0F2THlBZ0lIQnlhWHBsUW05NE9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZFdKelkzSnBjSFJwYjI1ek9pQXdMQW9nSUNBZ0x5OGdJQ0JuWVhSbE9pQXdMQW9nSUNBZ0x5OGdJQ0JoZFdOMGFXOXVPaUF3TEFvZ0lDQWdMeThnSUNCb2VYQmxjbE4zWVhBNklEQXNDaUFnSUNBdkx5QWdJSEpoWm1ac1pUb2dNQ3dLSUNBZ0lDOHZJQ0FnYldWMFlVMWxjbXRzWlhNNklEQXNDaUFnSUNBdkx5QWdJRzFoY210bGRIQnNZV05sT2lBd0xBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ3dLSUNBZ0lDOHZJSDBLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExXUmhieTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJoYTJsMFlVRndjRXhwYzNRZ1BTQkhiRzlpWVd4VGRHRjBaVHhCYTJsMFlVRndjRXhwYzNRK0tIc2dhMlY1T2lCQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFFYQndUR2x6ZENCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXRnNJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRaR0Z2TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRndE16RUtJQ0FnSUM4dklIUm9hWE11WVd0cGRHRkJjSEJNYVhOMExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQnpkR0ZyYVc1bk9pQXdMQW9nSUNBZ0x5OGdJQ0J5WlhkaGNtUnpPaUF3TEFvZ0lDQWdMeThnSUNCd2IyOXNPaUF3TEFvZ0lDQWdMeThnSUNCd2NtbDZaVUp2ZURvZ01Dd0tJQ0FnSUM4dklDQWdjM1ZpYzJOeWFYQjBhVzl1Y3pvZ01Dd0tJQ0FnSUM4dklDQWdaMkYwWlRvZ01Dd0tJQ0FnSUM4dklDQWdZWFZqZEdsdmJqb2dNQ3dLSUNBZ0lDOHZJQ0FnYUhsd1pYSlRkMkZ3T2lBd0xBb2dJQ0FnTHk4Z0lDQnlZV1ptYkdVNklEQXNDaUFnSUNBdkx5QWdJRzFsZEdGTlpYSnJiR1Z6T2lBd0xBb2dJQ0FnTHk4Z0lDQnRZWEpyWlhSd2JHRmpaVG9nTUN3S0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXNDaUFnSUNBdkx5QjlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRaR0Z2TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRaR0Z2TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydEdZV3RsUkVGUExuTmxkRWRoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJIWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMlpoYTJVdFpHRnZMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJSE5sZEVkaGRHVW9aMkYwWlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0WkdGdkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHTnZibk4wSUd4cGMzUWdQU0JqYkc5dVpTaDBhR2x6TG1GcmFYUmhRWEJ3VEdsemRDNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzFrWVc4dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1lXdHBkR0ZCY0hCTWFYTjBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXdHBkR0ZCY0hCTWFYTjBQaWg3SUd0bGVUb2dRV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ3Y0V4cGMzUWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFdSaGJ5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QmpiMjV6ZENCc2FYTjBJRDBnWTJ4dmJtVW9kR2hwY3k1aGEybDBZVUZ3Y0V4cGMzUXVkbUZzZFdVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0WkdGdkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHeHBjM1F1WjJGMFpTQTlJR2RoZEdVS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRFF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzFrWVc4dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1lXdHBkR0ZCY0hCTWFYTjBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXdHBkR0ZCY0hCTWFYTjBQaWg3SUd0bGVUb2dRV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ3Y0V4cGMzUWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZoYkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFdSaGJ5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG1GcmFYUmhRWEJ3VEdsemRDNTJZV3gxWlNBOUlHTnNiMjVsS0d4cGMzUXBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRaR0Z2TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhObGRFZGhkR1VvWjJGMFpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0WkdGdkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRHWVd0bFJFRlBMbk53WVhkdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjM0JoZDI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZabUZyWlMxa1lXOHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdjM0JoZDI0b1kyOXVkSEp2Ykd4bFpFRmtaSEpsYzNNNklFRmpZMjkxYm5Rc0lISmxabVZ5Y21WeU9pQkJZMk52ZFc1MExDQnpjR1Z1WkdsdVowRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0WkdGdkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETXRORFVLSUNBZ0lDOHZJSEpsZEhWeWJpQmpiMjF3YVd4bFFYSmpOQ2hOYjJOclJtRnJaVmRoYkd4bGRDa3VZMkZzYkM1amNtVmhkR1VvZXdvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWTI5dWRISnZiR3hsWkVGa1pISmxjM01zSUhKbFptVnljbVZ5TENCemNHVnVaR2x1WjBGa1pISmxjM05kTEFvZ0lDQWdMeThnZlNrdWFYUjRiaTVqY21WaGRHVmtRWEJ3TG1sa0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzFrWVc4dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdOdmJYQnBiR1ZCY21NMEtFMXZZMnRHWVd0bFYyRnNiR1YwS1M1allXeHNMbU55WldGMFpTaDdDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUjJ4dlltRnNUblZ0UW5sMFpWTnNhV05sQ2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRZMEtFTTBSVUpSZHowOUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlZCaFoyVnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVFkwS0VONVFVVkJRVVZKUVdsWlJFVnRUblppYmxKNVlqSjRjMXBYVW1aWlYxSnJZMjFXZW1OM2FIbGFWMXBzWTI1S2JHTm5VVlpJTTNneFRWSnJWVkpFUlZsUlVVRnRaMmRSUldoVk0zUTBRVkp5WlhaMlYwSlBjM05FTTNORlQxZFdaVXRxV1dGQlNUUkZRVUZGUVZOblEwZEJXbWRCU1RCUFFVSkdWVFZyZUZFeVIyZERUMEZSUVVKQlJGbGhRVlZyVm1kVFFWTlNSRmxoUVd0clZtZFRRVk5TUkZsaFFUQnJWbWRUUVZOU1EyaFFRVEpqY0ZSM1NtNW5Ra0o2WTBkV2RWcEhiSFZhTVRsb1drZFNlVnBZVG5wVVIyTnFVWHBaWVVGVmExWktRa3BGUm5wWllVRnJhMVpLUWtwRlJqZEdURUZZU1VsU1RFbEljMmRuYW5Ob1FXbHpaMGN5U1doYVRYTm9hVUZDUjBJclkwVmhlVWR5U1dGblVXRjVSVU5MZVVGaVRXcFJlVWt5UjJkR1NrWlRVVk5TUW1NeVIyZEtTbFJuU2twR1dVVm5SV3RTVEVGWlFVUmlNa1p6V2xWcFFrZEdkRkJCYjBGRVdWZEdjMXBWYVVKWFJuUlBRVGRIZVVkSlFVVlFRbkIyVFRkSllYTm9jVUpDY2tsUlNYSkpRbk0zVVN0VFZtTkZRVVZ6UWxaM1FVVkxhRXBGVTFOS1drcFJhRTFHVWtwRlZuZFpRVk5TVld0Rk1FVkJaR3RuYVZOVlFVRklSRWxFVTNkR1FVRkJNVTFHYXpoRFZVVjRVVXRyZUZGelEwNUVVMFZyY0ZwVmFFTXZLM1JLUzBkV1RWUm5Ta0pCUldSTVFWSlhRa2xDU2tKQlJEUnFVVUZCVUdkQmRFWlZiRWsyV2xoS2VWTllaSE5rVEVGQlUxaEpTVkpGYzBORk1FVkJSekJ6UWsxUlFWUlJVVUZVVTNkR2VrRnJVa3hCV0VsSlVrSk9Ra0ZCVmtaQlZVd3ZiV3M0UTFORlRDOXNRMHBETHpjNFdGTlZSVUZDVlhORFVVRkJTVWxwU2s5QmF6RkRMek53U21OblpFMVNVVlpDUVVKa1RFRm9ZVUZDVjBaM1kwVnNSVlJHUVVSVGQxRlRVVkZCUlVrd1RDOHlVMHBETHpsVk1rZG5Sa3BHVTFGVFVrSmpNa2RuU2twR1UxRlRVa0pqTWtkblRrcEdXVVZuUld0Uk1rZG5Va3BHVTFGVFVrSmpNa2RuVmtoQmFVcGFVMVUwUTBwUmRFMVRVbFpQUVd4alEwRkRTa3BUZDFWTlVWRkJhRk5UVlV4VGQwcEtWSGRLV2xOVk9FWlRWVFJGUld0U1RFRlNWbE5KYkd0c1EwRm9UMEZwVFVsUmRpOVpVbWRKYkVOQ1NrVk9hRzlIVTFKVmEwVnJVVmhPYUc5SVUxVTBRMU5UU2xwVFZUUkRTbEYwVFZOU1ZrOUJiR05EUVVOS1NsTjNWVTFSVVVGNlUxTlZURk4zU2twVWQwcGFVMVU0UmxOVk5FVkZhMUpNUVZKV1UxTlNWa3hCV1VWUlYxVnRRa1ZvU2tWVVJrbHBWMWxGWjBNMFJWVkRRV2hQUVdsTlNWRjJMMGRTWjBwUVFXdG5iRU5DU2tWelZYTklVMWhKU1ZKRk9FTnpaMmw1UW5sUGVVVkRTM2xCWWxwTVFrSmhRVUpGVDFOS2JGZDVSMnR6UjNOb2NYbEhhM05FYzJod1RFSnlTVmxuVVdGNVJVTkxlVUZpWVhsSFNVRkZMMk12WmpseVNXRnphSEZDUW5KSlVVbHlTVUp6ZVU1RUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzFRWVdkbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMlpoYTJVdFpHRnZMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE10TkRVS0lDQWdJQzh2SUhKbGRIVnliaUJqYjIxd2FXeGxRWEpqTkNoTmIyTnJSbUZyWlZkaGJHeGxkQ2t1WTJGc2JDNWpjbVZoZEdVb2V3b2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlkyOXVkSEp2Ykd4bFpFRmtaSEpsYzNNc0lISmxabVZ5Y21WeUxDQnpjR1Z1WkdsdVowRmtaSEpsYzNOZExBb2dJQ0FnTHk4Z2ZTa3VhWFI0Ymk1amNtVmhkR1ZrUVhCd0xtbGtDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTFNems1TXpFMElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1oybDBlRzRnTUNCRGNtVmhkR1ZrUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMlpoYTJVdFpHRnZMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSE53WVhkdUtHTnZiblJ5YjJ4c1pXUkJaR1J5WlhOek9pQkJZMk52ZFc1MExDQnlaV1psY25KbGNqb2dRV05qYjNWdWRDd2djM0JsYm1ScGJtZEJaR1J5WlhOek9pQkJZMk52ZFc1MEtUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBZ0pnRURZV0ZzTVJrVVJERVlRUUFXZ2dJRXRLakVrQVN3OFRiQk5ob0FqZ0lBY3dDSUFJQUVURnhodWpZYUFJNEJBQUVBTWdnV2dGZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVRGQW9UR2NpUXpZYUFVa1ZnUWdTUkNNb1pVUk1YQ2dvVEdjaVF6WWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGU1FTUkxHQkE3STFnQVFMZ1FGRHNrS0Fnd1lMSUFRQUFRZ0NKZ01TWTI5dWRISnZiR3hsWkY5aFpHUnlaWE56Q0hKbFptVnljbVZ5QkJVZmZIVXhHUlJFTVJoQkFDYUNCQVNGVGUzZ0JHdDYrOVlFNnl3UGV3UTVaVjRxTmhvQWpnUUFBUUJLQUlZQm1BQWpRNEFFVlRtVEZEWWFBSTRCQUFFQU5ob0JTUldCSUJKRU5ob0NTUldCSUJKRU5ob0RTUldCSUJKRUtFOERaeWxQQW1lQUVITndaVzVrYVc1blgyRmtaSEpsYzNOTVp5TkROaG9CU1JVa0VrUVhOaG9DU1JVa0VrUVhzVXNCY2doRXNnZXlDQ095RUNLeUFiWWlGa3l5R0lBRVlINXdScklhc2hxQkJySVFJcklCc3lORElqWWFBVWtWSkJKRUZ6WWFBa2xPQWtrVmdTQVNSRXNCZ0FOdllXeGxTSUVZVzA4Q2dBTmhZV3hsU0lGWVcwNERzYklZZ0FROEdtOHpzaHF5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFTd0ZYQUFRcUVrUkpJbGtsQ0V3VkVrUlhCZ0JKRlNRVFFRQjJTQ0pKUUFBY01nTkxBVUFBRFV3V1R3SlFURkFxVEZDd0kwTklTU2xsU0VMLzYwa29aVXhPQWtFQVIwc0JGWUVnRWtFQVBpTkFBQStBQzBWU1VqcGxjbkpKZDJ4MHNBQkpjZ2hFU3dJVFFRQWJTd0V4QUJOQkFCTkxBWE1DUkVzQmNnaEVFMEVBQlVVQlF2K2FUd0pJUXYrVUlrTC92eGRKUVFBRlN3SkFBQWdpSWs0Q1RVTC9la2x5QjB4RkJVRUFGMHNDRm9BRllYQndTVVJNVUFOTEJCSkJBQVFqUXYvWklrTC8xVFlhQVVrVkpCSkVGellhQWtrVkpCSkVGellhQTBrVmdTQVNSRFlhQkVrVkpCSkVGellhQlVjQ0lsbEpUZ0lsQzB4SkZVNENWd0lBSWtsTEJReEJBQ0ZKSlF0TEFrbFBBbGxKVHdWSlRnUVNSRXNCRlZJaVdTVUlDRTRDSXdoQy85aEdBaVVJRWtRMkdnWkpGU1FTUkJjMkdnZEpUZ0pKSWxsSlRnSWxDMHhKRlU0Q1Z3SUFJa2xMQlF4QkFETkpKUXRMQWtsUEFsbEpUd1ZKVGdRU1JFc0JGVkpKRlVzQmdSQlpTWUVTRWtSTVVpSlpnU0FMZ1JRSUNFNENJd2hDLzhaR0FrOENTQ1VJRWtTeFN3ZEpjZ2hFVHdLeUNMSUhJN0lRSXJJQnRrc0VGb0FFUTVJbVZiSWFTd2F5R3JJYVN3T3lHa3NHc2hpQkJySVFJcklCdHJJWWdBVDl6OS8yc2hxeUdvRUdzaEFpc2dHekkwT3lRQ095R1lBRVZUbVRGTElhVHdLeUdreXlHcklhZ1FheUVDT3lBYk8zQUQwV2dBUVZIM3gxVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
