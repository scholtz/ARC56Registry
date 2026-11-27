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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildAkitaDAO_488ad59c
{


    //
    // Minimal Akita DAO fee and app-list state used by GuildFactory integration tests.
    //
    public class MockGuildAkitaDAOProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildAkitaDAOProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class GuildFees : AVMObjectType
            {
                public ulong CreateFee { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreateFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreateFee.From(CreateFee);
                    ret.AddRange(vCreateFee.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GuildFees Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GuildFees();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreateFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreateFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreateFee = vCreateFee.ToValue();
                    if (valueCreateFee is ulong vCreateFeeValue) { ret.CreateFee = vCreateFeeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GuildFees);
                }
                public bool Equals(GuildFees? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GuildFees left, GuildFees right)
                {
                    return EqualityComparer<GuildFees>.Default.Equals(left, right);
                }
                public static bool operator !=(GuildFees left, GuildFees right)
                {
                    return !(left == right);
                }

            }

            public class WalletFees : AVMObjectType
            {
                public ulong CreateFee { get; set; }

                public ulong ReferrerPercentage { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreateFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreateFee.From(CreateFee);
                    ret.AddRange(vCreateFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrerPercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReferrerPercentage.From(ReferrerPercentage);
                    ret.AddRange(vReferrerPercentage.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static WalletFees Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WalletFees();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreateFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreateFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreateFee = vCreateFee.ToValue();
                    if (valueCreateFee is ulong vCreateFeeValue) { ret.CreateFee = vCreateFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrerPercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReferrerPercentage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReferrerPercentage = vReferrerPercentage.ToValue();
                    if (valueReferrerPercentage is ulong vReferrerPercentageValue) { ret.ReferrerPercentage = vReferrerPercentageValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as WalletFees);
                }
                public bool Equals(WalletFees? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WalletFees left, WalletFees right)
                {
                    return EqualityComparer<WalletFees>.Default.Equals(left, right);
                }
                public static bool operator !=(WalletFees left, WalletFees right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="createFee"> </param>
        public async Task Create(ulong createFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var createFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createFeeAbi.From(createFee);

            var result = await base.CallApp(new List<object> { abiHandle, createFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong createFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var createFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createFeeAbi.From(createFee);

            return await base.MakeTransactionList(new List<object> { abiHandle, createFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Point Guild wallet creation at a wallet factory, as the DAO's app list does in production.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task SetWalletFactory(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 188, 192, 187 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWalletFactory_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 188, 192, 187 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkQWtpdGFEQU8iLCJkZXNjIjoiTWluaW1hbCBBa2l0YSBEQU8gZmVlIGFuZCBhcHAtbGlzdCBzdGF0ZSB1c2VkIGJ5IEd1aWxkRmFjdG9yeSBpbnRlZ3JhdGlvbiB0ZXN0cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWtpdGFBcHBMaXN0IjpbeyJuYW1lIjoic3Rha2luZyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXdhcmRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvb2wiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJpemVCb3giLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3Vic2NyaXB0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJnYXRlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF1Y3Rpb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaHlwZXJTd2FwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJhZmZsZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtZXRhTWVya2xlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXJrZXRwbGFjZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3YWxsZXQiLCJ0eXBlIjoidWludDY0In1dLCJHdWlsZEZlZXMiOlt7Im5hbWUiOiJjcmVhdGVGZWUiLCJ0eXBlIjoidWludDY0In1dLCJXYWxsZXRGZWVzIjpbeyJuYW1lIjoiY3JlYXRlRmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlZmVycmVyUGVyY2VudGFnZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0ZUZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXYWxsZXRGYWN0b3J5IiwiZGVzYyI6IlBvaW50IEd1aWxkIHdhbGxldCBjcmVhdGlvbiBhdCBhIHdhbGxldCBmYWN0b3J5LCBhcyB0aGUgREFPJ3MgYXBwIGxpc3QgZG9lcyBpbiBwcm9kdWN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NSwyMTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmhZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXdHBkR0V0WkdGdkxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOYjJOclIzVnBiR1JCYTJsMFlVUkJUeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqWmlZMk13WW1JZ0x5OGdiV1YwYUc5a0lDSnpaWFJYWVd4c1pYUkdZV04wYjNKNUtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFYyRnNiR1YwUm1GamRHOXllUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXdHBkR0V0WkdGdkxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOYjJOclIzVnBiR1JCYTJsMFlVUkJUeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwTUdReVpqWTNJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WVd0cGRHRXRaR0Z2TG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkVGcmFYUmhSRUZQTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxaGEybDBZUzFrWVc4dVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoYTJsMFlTMWtZVzh1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnZEdocGN5NW5kV2xzWkVabFpYTXVkbUZzZFdVZ1BTQjdJR055WldGMFpVWmxaU0I5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXdHBkR0V0WkdGdkxtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHZDFhV3hrUm1WbGN5QTlJRWRzYjJKaGJGTjBZWFJsUEVkMWFXeGtSbVZsY3o0b2V5QnJaWGs2SUVGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpSM1ZwYkdSR1pXVnpJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWQxYVd4a1gyWmxaWE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXdHBkR0V0WkdGdkxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIUm9hWE11WjNWcGJHUkdaV1Z6TG5aaGJIVmxJRDBnZXlCamNtVmhkR1ZHWldVZ2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoYTJsMFlTMWtZVzh1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnZDJGc2JHVjBSbVZsY3lBOUlFZHNiMkpoYkZOMFlYUmxQRmRoYkd4bGRFWmxaWE0rS0hzZ2EyVjVPaUJCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZEVabFpYTWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbmRoYkd4bGRGOW1aV1Z6SWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXdHBkR0V0WkdGdkxtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIUm9hWE11ZDJGc2JHVjBSbVZsY3k1MllXeDFaU0E5SUhzZ1kzSmxZWFJsUm1WbE9pQXdMQ0J5WldabGNuSmxjbEJsY21ObGJuUmhaMlU2SURBZ2ZRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoYTJsMFlTMWtZVzh1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWVd0cGRHRkJjSEJNYVhOMElEMGdSMnh2WW1Gc1UzUmhkR1U4UVd0cGRHRkJjSEJNYVhOMFBpaDdJR3RsZVRvZ1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5CYTJsMFlVRndjRXhwYzNRZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmhiQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxaGEybDBZUzFrWVc4dVlXeG5ieTUwY3pveU5TMHpPQW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVUZ3Y0V4cGMzUXVkbUZzZFdVZ1BTQjdDaUFnSUNBdkx5QWdJSE4wWVd0cGJtYzZJREFzQ2lBZ0lDQXZMeUFnSUhKbGQyRnlaSE02SURBc0NpQWdJQ0F2THlBZ0lIQnZiMnc2SURBc0NpQWdJQ0F2THlBZ0lIQnlhWHBsUW05NE9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZFdKelkzSnBjSFJwYjI1ek9pQXdMQW9nSUNBZ0x5OGdJQ0JuWVhSbE9pQXdMQW9nSUNBZ0x5OGdJQ0JoZFdOMGFXOXVPaUF3TEFvZ0lDQWdMeThnSUNCb2VYQmxjbE4zWVhBNklEQXNDaUFnSUNBdkx5QWdJSEpoWm1ac1pUb2dNQ3dLSUNBZ0lDOHZJQ0FnYldWMFlVMWxjbXRzWlhNNklEQXNDaUFnSUNBdkx5QWdJRzFoY210bGRIQnNZV05sT2lBd0xBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WVd0cGRHRXRaR0Z2TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdGcmFYUmhMV1JoYnk1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSQmEybDBZVVJCVHk1elpYUlhZV3hzWlhSR1lXTjBiM0o1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBWMkZzYkdWMFJtRmpkRzl5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWhhMmwwWVMxa1lXOHVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdjMlYwVjJGc2JHVjBSbUZqZEc5eWVTaDNZV3hzWlhRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV0ZyYVhSaExXUmhieTVoYkdkdkxuUnpPakkxTFRNNENpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFFYQndUR2x6ZEM1MllXeDFaU0E5SUhzS0lDQWdJQzh2SUNBZ2MzUmhhMmx1WnpvZ01Dd0tJQ0FnSUM4dklDQWdjbVYzWVhKa2N6b2dNQ3dLSUNBZ0lDOHZJQ0FnY0c5dmJEb2dNQ3dLSUNBZ0lDOHZJQ0FnY0hKcGVtVkNiM2c2SURBc0NpQWdJQ0F2THlBZ0lITjFZbk5qY21sd2RHbHZibk02SURBc0NpQWdJQ0F2THlBZ0lHZGhkR1U2SURBc0NpQWdJQ0F2THlBZ0lHRjFZM1JwYjI0NklEQXNDaUFnSUNBdkx5QWdJR2g1Y0dWeVUzZGhjRG9nTUN3S0lDQWdJQzh2SUNBZ2NtRm1abXhsT2lBd0xBb2dJQ0FnTHk4Z0lDQnRaWFJoVFdWeWEyeGxjem9nTUN3S0lDQWdJQzh2SUNBZ2JXRnlhMlYwY0d4aFkyVTZJREFzQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkQ3dLSUNBZ0lDOHZJSDBLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoYTJsMFlTMWtZVzh1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWVd0cGRHRkJjSEJNYVhOMElEMGdSMnh2WW1Gc1UzUmhkR1U4UVd0cGRHRkJjSEJNYVhOMFBpaDdJR3RsZVRvZ1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5CYTJsMFlVRndjRXhwYzNRZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmhiQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxaGEybDBZUzFrWVc4dVlXeG5ieTUwY3pveU5TMHpPQW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVUZ3Y0V4cGMzUXVkbUZzZFdVZ1BTQjdDaUFnSUNBdkx5QWdJSE4wWVd0cGJtYzZJREFzQ2lBZ0lDQXZMeUFnSUhKbGQyRnlaSE02SURBc0NpQWdJQ0F2THlBZ0lIQnZiMnc2SURBc0NpQWdJQ0F2THlBZ0lIQnlhWHBsUW05NE9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZFdKelkzSnBjSFJwYjI1ek9pQXdMQW9nSUNBZ0x5OGdJQ0JuWVhSbE9pQXdMQW9nSUNBZ0x5OGdJQ0JoZFdOMGFXOXVPaUF3TEFvZ0lDQWdMeThnSUNCb2VYQmxjbE4zWVhBNklEQXNDaUFnSUNBdkx5QWdJSEpoWm1ac1pUb2dNQ3dLSUNBZ0lDOHZJQ0FnYldWMFlVMWxjbXRzWlhNNklEQXNDaUFnSUNBdkx5QWdJRzFoY210bGRIQnNZV05sT2lBd0xBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRc0NpQWdJQ0F2THlCOUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV0ZyYVhSaExXUmhieTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJ6WlhSWFlXeHNaWFJHWVdOMGIzSjVLSGRoYkd4bGREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQ0FFbUFRTmhZV3d4R1JSRU1SaEJBQTZBQkxhOHdMczJHZ0NPQVFDdEFJQUVKQTB2WnpZYUFJNEJBQUVBTmhvQlNSVWlFa1FYRm9BS1ozVnBiR1JmWm1WbGMweG5nZ0lMZDJGc2JHVjBYMlpsWlhNUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUdjb2dHQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCbkkwTTJHZ0ZKRlNJU1JCY1dnRmdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFURkFvVEdjalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
