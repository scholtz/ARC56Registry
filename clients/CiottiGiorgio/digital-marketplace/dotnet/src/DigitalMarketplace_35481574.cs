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

namespace Arc56.Generated.CiottiGiorgio.digital_marketplace.DigitalMarketplace_35481574
{


    public class DigitalMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DigitalMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Bid : AVMObjectType
            {
                public Algorand.Address Bidder { get; set; }

                public ulong Amount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBidder.From(Bidder);
                    ret.AddRange(vBidder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Bid Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Bid();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBidder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBidder = vBidder.ToValue();
                    if (valueBidder is Algorand.Address vBidderValue) { ret.Bidder = vBidderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Bid);
                }
                public bool Equals(Bid? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Bid left, Bid right)
                {
                    return EqualityComparer<Bid>.Default.Equals(left, right);
                }
                public static bool operator !=(Bid left, Bid right)
                {
                    return !(left == right);
                }

            }

            public class Sale : AVMObjectType
            {
                public ulong Amount { get; set; }

                public ulong Cost { get; set; }

                public Structs.Bid Bid { get; set; } = new Structs.Bid();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCost.From(Cost);
                    ret.AddRange(vCost.Encode());
                    ret.AddRange(Bid.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Sale Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Sale();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCost = vCost.ToValue();
                    if (valueCost is ulong vCostValue) { ret.Cost = vCostValue; }
                    ret.Bid = Structs.Bid.Parse(queue.ToArray());
                    { var consumedBid = ret.Bid.ToByteArray().Length; for (int i = 0; i < consumedBid && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Sale);
                }
                public bool Equals(Sale? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Sale left, Sale right)
                {
                    return EqualityComparer<Sale>.Default.Equals(left, right);
                }
                public static bool operator !=(Sale left, Sale right)
                {
                    return !(left == right);
                }

            }

            public class SaleKey : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong Asset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SaleKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SaleKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SaleKey);
                }
                public bool Equals(SaleKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SaleKey left, SaleKey right)
                {
                    return EqualityComparer<SaleKey>.Default.Equals(left, right);
                }
                public static bool operator !=(SaleKey left, SaleKey right)
                {
                    return !(left == right);
                }

            }

            public class UnencumberedBidsReceipt : AVMObjectType
            {
                public ulong TotalBids { get; set; }

                public ulong UnencumberedBids { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBids.From(TotalBids);
                    ret.AddRange(vTotalBids.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnencumberedBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUnencumberedBids.From(UnencumberedBids);
                    ret.AddRange(vUnencumberedBids.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UnencumberedBidsReceipt Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UnencumberedBidsReceipt();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBids.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBids = vTotalBids.ToValue();
                    if (valueTotalBids is ulong vTotalBidsValue) { ret.TotalBids = vTotalBidsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnencumberedBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUnencumberedBids.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnencumberedBids = vUnencumberedBids.ToValue();
                    if (valueUnencumberedBids is ulong vUnencumberedBidsValue) { ret.UnencumberedBids = vUnencumberedBidsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UnencumberedBidsReceipt);
                }
                public bool Equals(UnencumberedBidsReceipt? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UnencumberedBidsReceipt left, UnencumberedBidsReceipt right)
                {
                    return EqualityComparer<UnencumberedBidsReceipt>.Default.Equals(left, right);
                }
                public static bool operator !=(UnencumberedBidsReceipt left, UnencumberedBidsReceipt right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task SponsorAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 19, 0, 10, 148 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SponsorAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 19, 0, 10, 148 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_deposit"> </param>
        /// <param name="cost"> </param>
        public async Task OpenSale(AssetTransferTransaction asset_deposit, ulong cost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_deposit });
            byte[] abiHandle = { 166, 146, 0, 102 };
            var costAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); costAbi.From(cost);

            var result = await base.CallApp(new List<object> { abiHandle, asset_deposit, costAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenSale_Transactions(AssetTransferTransaction asset_deposit, ulong cost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_deposit });
            byte[] abiHandle = { 166, 146, 0, 102 };
            var costAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); costAbi.From(cost);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_deposit, costAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task CloseSale(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 9, 84, 72, 16 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseSale_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 9, 84, 72, 16 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sale_key"> SaleKey</param>
        public async Task Buy(Structs.SaleKey sale_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 154, 198, 14 };

            var result = await base.CallApp(new List<object> { abiHandle, sale_key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Buy_Transactions(Structs.SaleKey sale_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 154, 198, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle, sale_key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sale_key"> SaleKey</param>
        /// <param name="new_bid_amount"> </param>
        public async Task Bid(Structs.SaleKey sale_key, ulong new_bid_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 143, 31, 252 };
            var new_bid_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_bid_amountAbi.From(new_bid_amount);

            var result = await base.CallApp(new List<object> { abiHandle, sale_key, new_bid_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(Structs.SaleKey sale_key, ulong new_bid_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 143, 31, 252 };
            var new_bid_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_bid_amountAbi.From(new_bid_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, sale_key, new_bid_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimUnencumberedBids(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 110, 57, 117 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimUnencumberedBids_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 110, 57, 117 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.UnencumberedBidsReceipt> GetTotalAndUnencumberedBids(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 171, 187, 88 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.UnencumberedBidsReceipt.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTotalAndUnencumberedBids_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 171, 187, 88 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AcceptBid(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 224, 239, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptBid_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 224, 239, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbE1hcmtldHBsYWNlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkJpZCI6W3sibmFtZSI6ImJpZGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9XSwiU2FsZSI6W3sibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb3N0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJpZCIsInR5cGUiOiJCaWQifV0sIlNhbGVLZXkiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In1dLCJVbmVuY3VtYmVyZWRCaWRzUmVjZWlwdCI6W3sibmFtZSI6InRvdGFsX2JpZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidW5lbmN1bWJlcmVkX2JpZHMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3BvbnNvcl9hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wZW5fc2FsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2RlcG9zaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvc3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2Vfc2FsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQpIiwic3RydWN0IjoiU2FsZUtleSIsIm5hbWUiOiJzYWxlX2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IlNhbGVLZXkiLCJuYW1lIjoic2FsZV9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19iaWRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX3VuZW5jdW1iZXJlZF9iaWRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9hbmRfdW5lbmN1bWJlcmVkX2JpZHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVW5lbmN1bWJlcmVkQmlkc1JlY2VpcHQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjY2VwdF9iaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1MDVdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IG9wdGVkIGluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE0XSwiZXJyb3JNZXNzYWdlIjoiQ2xhd2JhY2sgQVNBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkxLDU2MF0sImVycm9yTWVzc2FnZSI6IkRpZmZlcmVudCBzZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDcsMzQ4LDc0Myw4NTUsODczLDg3Nyw4OTksOTAzLDk4MSwxMDAwLDEwOTksMTExMSwxMTE0LDExNzksMTM0NSwxNDI0LDE0MjgsMTU0NCwxNTU1XSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjksMTQ0LDE3MCwxODIsMjAwLDIxNSwyMzMsMjU4LDI3NiwyOTFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODVdLCJlcnJvck1lc3NhZ2UiOiJTYWxlIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYxXSwiZXJyb3JNZXNzYWdlIjoiU2VsbGVyIGNhbm5vdCBiZSBiaWRkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTBdLCJlcnJvck1lc3NhZ2UiOiJTZWxsZXIgY2Fubm90IGJlIGJ1eWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk1XSwiZXJyb3JNZXNzYWdlIjoiV29yc2UgYmlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk5LDU2OF0sImVycm9yTWVzc2FnZSI6Ildyb25nIHJlY2VpdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0LDQzNCw1OTAsNjUwLDcxMCw3MTgsNzg3LDc5Niw5MjEsMTAyMCwxMjQzLDEyNjUsMTQ0MCwxNDQ5LDE2MDQsMTYyNF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEwXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyLDE0NywxNzMsMTg1LDIwMywyMTgsMjM2LDI2MSwyNzksMjk0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Niw0NjUsNTI0LDY2Miw3MjksODA3LDgzMSw5NjEsMTAzMywxMjI0LDEyNzksMTQ2MCwxNjM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZXBvc2l0ZWQgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1NywxNTA3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWNlaXB0X2Jvb2sgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg3LDc1Nyw4NzIsMTQyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2FsZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzVqYjI1MGNtRmpkQzVFYVdkcGRHRnNUV0Z5YTJWMGNHeGhZMlV1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEUTRJRFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbVJsY0c5emFYUmxaQ0lnSW5KbFkyVnBjSFJmWW05dmF5SWdJbk5oYkdWeklpQWlJaUF3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJqYkdGemN5QkVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE5Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VETTJNalZsTkdWaUlEQjRNakZtTVdSa1ptWWdNSGd4TXpBd01HRTVOQ0F3ZUdFMk9USXdNRFkySURCNE1EazFORFE0TVRBZ01IaGtORGxoWXpZd1pTQXdlR0V4T0dZeFptWmpJREI0TkRVMlpUTTVOelVnTUhneFpXRmlZbUkxT0NBd2VHWTRaVEJsWm1GbUlDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRDaHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Od2IyNXpiM0pmWVhOelpYUW9ZWE56WlhRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYjNCbGJsOXpZV3hsS0dGNFptVnlMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHOXpaVjl6WVd4bEtHRnpjMlYwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUoxZVNnb1lXUmtjbVZ6Y3l4MWFXNTBOalFwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUpwWkNnb1lXUmtjbVZ6Y3l4MWFXNTBOalFwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiR0ZwYlY5MWJtVnVZM1Z0WW1WeVpXUmZZbWxrY3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzUnZkR0ZzWDJGdVpGOTFibVZ1WTNWdFltVnlaV1JmWW1sa2N5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmhZMk5sY0hSZlltbGtLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlrWlhCdmMybDBYM0p2ZFhSbFFEVWdiV0ZwYmw5M2FYUm9aSEpoZDE5eWIzVjBaVUEySUcxaGFXNWZjM0J2Ym5OdmNsOWhjM05sZEY5eWIzVjBaVUEzSUcxaGFXNWZiM0JsYmw5ellXeGxYM0p2ZFhSbFFEZ2diV0ZwYmw5amJHOXpaVjl6WVd4bFgzSnZkWFJsUURrZ2JXRnBibDlpZFhsZmNtOTFkR1ZBTVRBZ2JXRnBibDlpYVdSZmNtOTFkR1ZBTVRFZ2JXRnBibDlqYkdGcGJWOTFibVZ1WTNWdFltVnlaV1JmWW1sa2MxOXliM1YwWlVBeE1pQnRZV2x1WDJkbGRGOTBiM1JoYkY5aGJtUmZkVzVsYm1OMWJXSmxjbVZrWDJKcFpITmZjbTkxZEdWQU1UTWdiV0ZwYmw5aFkyTmxjSFJmWW1sa1gzSnZkWFJsUURFMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1kyeGhjM01nUkdsbmFYUmhiRTFoY210bGRIQnNZV05sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRmpZMlZ3ZEY5aWFXUmZjbTkxZEdWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHTnNZWE56SUVScFoybDBZV3hOWVhKclpYUndiR0ZqWlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0ZqWTJWd2RGOWlhV1FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNSdmRHRnNYMkZ1WkY5MWJtVnVZM1Z0WW1WeVpXUmZZbWxrYzE5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSXdPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MGIzUmhiRjloYm1SZmRXNWxibU4xYldKbGNtVmtYMkpwWkhNS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOc1lXbHRYM1Z1Wlc1amRXMWlaWEpsWkY5aWFXUnpYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZMnhoYVcxZmRXNWxibU4xYldKbGNtVmtYMkpwWkhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1sa1gzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVFUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCamJHRnpjeUJFYVdkcGRHRnNUV0Z5YTJWMGNHeGhZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUxTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmlhV1FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZblY1WDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJqYkdGemN5QkVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCaWRYa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyeHZjMlZmYzJGc1pWOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCamJHRnpjeUJFYVdkcGRHRnNUV0Z5YTJWMGNHeGhZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZ6YzJWMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHTnNiM05sWDNOaGJHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQmxibDl6WVd4bFgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWTJ4aGMzTWdSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCdmNHVnVYM05oYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzNCdmJuTnZjbDloYzNObGRGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUdOc1lYTnpJRVJwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRWE56WlhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCemNHOXVjMjl5WDJGemMyVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzZHBkR2hrY21GM1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWTJ4aGMzTWdSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCM2FYUm9aSEpoZHdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWlhCdmMybDBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1kyeGhjM01nUkdsbmFYUmhiRTFoY210bGRIQnNZV05sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdSbGNHOXphWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR05zWVhOeklFUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOd29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM1emRXSnliM1YwYVc1bGN5NW1hVzVrWDJKcFpGOXlaV05sYVhCMEtISmxZMlZwY0hSek9pQmllWFJsY3l3Z2EyVjVPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUTZDbVpwYm1SZlltbGtYM0psWTJWcGNIUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOXpkV0p5YjNWMGFXNWxjeTV3ZVRvMkxUa0tJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWm1sdVpGOWlhV1JmY21WalpXbHdkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWEIwY3pvZ1NXMXRkWFJoWW14bFFYSnlZWGxiUW1sa1VtVmpaV2x3ZEYwc0lHdGxlVG9nVTJGc1pVdGxlUW9nSUNBZ0x5OGdLU0F0UGlCMGRYQnNaVnRpYjI5c0xDQlZTVzUwTmpSZE9nb2dJQ0FnY0hKdmRHOGdNaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzl6ZFdKeWIzVjBhVzVsY3k1d2VUb3hNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtISmxZMlZwY0hSekxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21acGJtUmZZbWxrWDNKbFkyVnBjSFJmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdmMzVmljbTkxZEdsdVpYTXVjSGs2TVRBS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h5WldObGFYQjBjeTVzWlc1bmRHZ3BPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJtYVc1a1gySnBaRjl5WldObGFYQjBYMkZtZEdWeVgyWnZja0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzl6ZFdKeWIzVjBhVzVsY3k1d2VUb3hNUW9nSUNBZ0x5OGdhV1lnY21WalpXbHdkSE5iYVYwdWMyRnNaVjlyWlhrZ1BUMGdhMlY1T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBME9Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRFE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwTUNBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdKNklHWnBibVJmWW1sa1gzSmxZMlZwY0hSZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzl6ZFdKeWIzVjBhVzVsY3k1d2VUb3hNZ29nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VzSUdrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS1ptbHVaRjlpYVdSZmNtVmpaV2x3ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzl6ZFdKeWIzVjBhVzVsY3k1d2VUb3hNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtISmxZMlZwY0hSekxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCbWFXNWtYMkpwWkY5eVpXTmxhWEIwWDJadmNsOW9aV0ZrWlhKQU1Rb0tabWx1WkY5aWFXUmZjbVZqWldsd2RGOWhablJsY2w5bWIzSkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMM04xWW5KdmRYUnBibVZ6TG5CNU9qRXpDaUFnSUNBdkx5QnlaWFIxY200Z1JtRnNjMlVzSUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMbU52Ym5SeVlXTjBMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaUzVrWlhCdmMybDBLSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0taR1Z3YjNOcGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPall5TFRZekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdaR1Z3YjNOcGRDaHpaV3htTENCd1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlMQ0JsY25JdVJFbEdSa1ZTUlU1VVgxTkZUa1JGVWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUkdsbVptVnlaVzUwSUhObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TmpZS0lDQWdJQzh2SUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvMk5TMDJOd29nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUdWeWNpNVhVazlPUjE5U1JVTkZTVlpGVWdvZ0lDQWdZWE56WlhKMElDOHZJRmR5YjI1bklISmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdiV0p5WDJKaGMyVnNhVzVsSUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1dGFXNWZZbUZzWVc1alpRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnYzJWc1ppNWtaWEJ2YzJsMFpXUXVaMlYwS0ZSNGJpNXpaVzVrWlhJc0lHUmxabUYxYkhROVZVbHVkRFkwS0RBcEtTQXJJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwWldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCelpXeG1MbVJsY0c5emFYUmxaRnRVZUc0dWMyVnVaR1Z5WFNBOUlDZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmxjRzl6YVhSbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEdWa0xtZGxkQ2hVZUc0dWMyVnVaR1Z5TENCa1pXWmhkV3gwUFZWSmJuUTJOQ2d3S1NrZ0t5QndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk56QXROeklLSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJRDBnS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1l1WkdWd2IzTnBkR1ZrTG1kbGRDaFVlRzR1YzJWdVpHVnlMQ0JrWldaaGRXeDBQVlZKYm5RMk5DZ3dLU2tnS3lCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklHMWljbDlrYVdabUlEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaU0F0SUcxaWNsOWlZWE5sYkdsdVpRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdjMlZzWmk1a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMGdMVDBnYldKeVgyUnBabVlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJsY0c5emFYUmxaQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrWlhCdmMybDBaV1FnWlc1MGNua2daWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMbU52Ym5SeVlXTjBMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaUzUzYVhSb1pISmhkeWhoYlc5MWJuUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPamMyTFRjM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkMmwwYUdSeVlYY29jMlZzWml3Z1lXMXZkVzUwT2lCaGNtTTBMbFZKYm5RMk5Da2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZElDMDlJR0Z0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SbGNHOXphWFJsWkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a1pYQnZjMmwwWldRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1lXMXZkVzUwUFdGdGIzVnVkQzV1WVhScGRtVXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdVkyOXVkSEpoWTNRdVJHbG5hWFJoYkUxaGNtdGxkSEJzWVdObExuTndiMjV6YjNKZllYTnpaWFFvWVhOelpYUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tjM0J2Ym5OdmNsOWhjM05sZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qZ3lMVGd6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2MzQnZibk52Y2w5aGMzTmxkQ2h6Wld4bUxDQmhjM05sZERvZ1FYTnpaWFFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM011YVhOZmIzQjBaV1JmYVc0b0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZPRFF0T0RZS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1cGMxOXZjSFJsWkY5cGJpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRBb2dJQ0FnTHk4Z0tTd2daWEp5TGtGTVVrVkJSRmxmVDFCVVJVUmZTVTRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUc5d2RHVmtJR2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBMbU5zWVhkaVlXTnJJRDA5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lHVnljaTVEVEVGWFFrRkRTMTlCVTBFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVOc1lYZGlZV05yQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUTJ4aGQySmhZMnNnUVZOQkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdjMlZzWmk1a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMGdMVDBnUjJ4dlltRnNMbUZ6YzJWMFgyOXdkRjlwYmw5dGFXNWZZbUZzWVc1alpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHVndiM05wZEdWa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSbFpDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCQmMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZPVEV0T1RVS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG81TVFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eklDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2preExUazFDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObExtTnZiblJ5WVdOMExrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpTNXZjR1Z1WDNOaGJHVW9ZWE56WlhSZlpHVndiM05wZERvZ2RXbHVkRFkwTENCamIzTjBPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tiM0JsYmw5ellXeGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2T1RjdE1UQXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYjNCbGJsOXpZV3hsS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzSUdGemMyVjBYMlJsY0c5emFYUTZJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFJ5WVc1ellXTjBhVzl1TENCamIzTjBPaUJoY21NMExsVkpiblEyTkFvZ0lDQWdMeThnS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRGOWtaWEJ2YzJsMExuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlMQ0JsY25JdVJFbEdSa1ZTUlU1VVgxTkZUa1JGVWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUkdsbVptVnlaVzUwSUhObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCaGMzTmxkRjlrWlhCdmMybDBMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE1ESXRNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMlJsY0c5emFYUXVZWE56WlhSZmNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2daWEp5TGxkU1QwNUhYMUpGUTBWSlZrVlNDaUFnSUNCaGMzTmxjblFnTHk4Z1YzSnZibWNnY21WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTENCaGNtTTBMbFZKYm5RMk5DaGhjM05sZEY5a1pYQnZjMmwwTG5obVpYSmZZWE56WlhRdWFXUXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVEEyTFRFd09Bb2dJQ0FnTHk4Z2MyRnNaVjlyWlhrZ1BTQlRZV3hsUzJWNUtBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd2dZWEpqTkM1VlNXNTBOalFvWVhOelpYUmZaR1Z3YjNOcGRDNTRabVZ5WDJGemMyVjBMbWxrS1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpZV3hsWDJ0bGVTQnViM1FnYVc0Z2MyVnNaaTV6WVd4bGN5d2daWEp5TGxOQlRFVmZRVXhTUlVGRVdWOUZXRWxUVkZNS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OaGJHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRk5oYkdVZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z2JXSnlYMkpoYzJWc2FXNWxJRDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeTV0YVc1ZlltRnNZVzVqWlFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0dGemMyVjBYMlJsY0c5emFYUXVZWE56WlhSZllXMXZkVzUwS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV4TWkweE1UWUtJQ0FnSUM4dklITmxiR1l1YzJGc1pYTmJjMkZzWlY5clpYbGRJRDBnVTJGc1pTZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoaGMzTmxkRjlrWlhCdmMybDBMbUZ6YzJWMFgyRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdZMjl6ZEN3S0lDQWdJQzh2SUNBZ0lDQkNhV1FvWVhKak5DNUJaR1J5WlhOektDa3NJR0Z5WXpRdVZVbHVkRFkwS0NrcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnUW1sa0tHRnlZelF1UVdSa2NtVnpjeWdwTENCaGNtTTBMbFZKYm5RMk5DZ3BLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTXpJb1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFTa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV4TWkweE1UWUtJQ0FnSUM4dklITmxiR1l1YzJGc1pYTmJjMkZzWlY5clpYbGRJRDBnVTJGc1pTZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoaGMzTmxkRjlrWlhCdmMybDBMbUZ6YzJWMFgyRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdZMjl6ZEN3S0lDQWdJQzh2SUNBZ0lDQkNhV1FvWVhKak5DNUJaR1J5WlhOektDa3NJR0Z5WXpRdVZVbHVkRFkwS0NrcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnYldKeVgyUnBabVlnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObElDMGdiV0p5WDJKaGMyVnNhVzVsQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFeE9Rb2dJQ0FnTHk4Z2MyVnNaaTVrWlhCdmMybDBaV1JiVkhodUxuTmxibVJsY2wwZ0xUMGdiV0p5WDJScFptWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmxjRzl6YVhSbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtaWEJ2YzJsMFpXUWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObExtTnZiblJ5WVdOMExrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpTNWpiRzl6WlY5ellXeGxLR0Z6YzJWME9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtTnNiM05sWDNOaGJHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TWpFdE1USXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWTJ4dmMyVmZjMkZzWlNoelpXeG1MQ0JoYzNObGREb2dRWE56WlhRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFeU13b2dJQ0FnTHk4Z2MyRnNaVjlyWlhrZ1BTQlRZV3hsUzJWNUtHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3Z1lYSmpOQzVWU1c1ME5qUW9ZWE56WlhRdWFXUXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV5TlMweE1qa0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWE5sYkdZdWMyRnNaWE5iYzJGc1pWOXJaWGxkTG1GdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNamNLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQxelpXeG1Mbk5oYkdWelczTmhiR1ZmYTJWNVhTNWhiVzkxYm5RdWJtRjBhWFpsTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzJGc1pYTWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpZV3hsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TWpVdE1USTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF6Wld4bUxuTmhiR1Z6VzNOaGJHVmZhMlY1WFM1aGJXOTFiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnYldKeVgySmhjMlZzYVc1bElEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklHUmxiQ0J6Wld4bUxuTmhiR1Z6VzNOaGJHVmZhMlY1WFFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJRzFpY2w5a2FXWm1JRDBnYldKeVgySmhjMlZzYVc1bElDMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TXpRS0lDQWdJQzh2SUhObGJHWXVaR1Z3YjNOcGRHVmtXMVI0Ymk1elpXNWtaWEpkSUNzOUlHMWljbDlrYVdabUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwWldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVndiM05wZEdWa0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM1amIyNTBjbUZqZEM1RWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVdVluVjVLSE5oYkdWZmEyVjVPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZblY1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTJMVEV6TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHSjFlU2h6Wld4bUxDQnpZV3hsWDJ0bGVUb2dVMkZzWlV0bGVTa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQWhQU0J6WVd4bFgydGxlUzV2ZDI1bGNpNXVZWFJwZG1Vc0lHVnljaTVUUlV4TVJWSmZRMEZPVkY5Q1JWOUNWVmxGVWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURBZ016SWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWld4c1pYSWdZMkZ1Ym05MElHSmxJR0oxZVdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJSE5oYkdVZ1BTQnpaV3htTG5OaGJHVnpXM05oYkdWZmEyVjVYUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljMkZzWlhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpZV3hsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUwTVMweE5EVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhOaGJHVmZhMlY1TG1GemMyVjBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXpZV3hsTG1GdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5YzJGc1pWOXJaWGt1WVhOelpYUXVibUYwYVhabExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTljMkZzWlM1aGJXOTFiblF1Ym1GMGFYWmxMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UUXhMVEUwTlFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTljMkZzWlY5clpYa3VZWE56WlhRdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhOaGJHVXVZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE5EY0tJQ0FnSUM4dklHMWljbDlpWVhObGJHbHVaU0E5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM011YldsdVgySmhiR0Z1WTJVS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEUxcGJrSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV6WVd4bGMxdHpZV3hsWDJ0bGVWMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJRzFpY2w5a2FXWm1JRDBnYldKeVgySmhjMlZzYVc1bElDMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TlRFS0lDQWdJQzh2SUhObGJHWXVaR1Z3YjNOcGRHVmtXMVI0Ymk1elpXNWtaWEpkSUMwOUlITmhiR1V1WTI5emRDNXVZWFJwZG1VS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SbGNHOXphWFJsWkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a1pYQnZjMmwwWldRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UVXlDaUFnSUNBdkx5QnpaV3htTG1SbGNHOXphWFJsWkZ0ellXeGxYMnRsZVM1dmQyNWxjaTV1WVhScGRtVmRJQ3M5SUhOaGJHVXVZMjl6ZEM1dVlYUnBkbVVnS3lCdFluSmZaR2xtWmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdWd2IzTnBkR1ZrSWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWd2IzTnBkR1ZrSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTG1OdmJuUnlZV04wTGtScFoybDBZV3hOWVhKclpYUndiR0ZqWlM1aWFXUW9jMkZzWlY5clpYazZJR0o1ZEdWekxDQnVaWGRmWW1sa1gyRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21KcFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUxTkMweE5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJpYVdRb2MyVnNaaXdnYzJGc1pWOXJaWGs2SUZOaGJHVkxaWGtzSUc1bGQxOWlhV1JmWVcxdmRXNTBPaUJoY21NMExsVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaUlnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJRzVsZDE5aWFXUWdQU0JDYVdRb1ltbGtaR1Z5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dnWVcxdmRXNTBQVzVsZDE5aWFXUmZZVzF2ZFc1MEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdJVDBnYzJGc1pWOXJaWGt1YjNkdVpYSXNJR1Z5Y2k1VFJVeE1SVkpmUTBGT1ZGOUNSVjlDU1VSRVJWSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVFpXeHNaWElnWTJGdWJtOTBJR0psSUdKcFpHUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCellXeGxJRDBnYzJWc1ppNXpZV3hsYzF0ellXeGxYMnRsZVYwS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OaGJHVnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmhiR1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJwWmlCellXeGxMbUpwWkM1aWFXUmtaWEk2Q2lBZ0lDQmxlSFJ5WVdOMElERTJJRFF3SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaWVpQmlhV1JmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUdGemMyVnlkQ0J6WVd4bExtSnBaQzVoYlc5MWJuUXVibUYwYVhabElEd2dibVYzWDJKcFpGOWhiVzkxYm5RdWJtRjBhWFpsTENCbGNuSXVWMDlTVTBWZlFrbEVDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUZkdmNuTmxJR0pwWkFvS1ltbGtYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnYzJWc1ppNXpZV3hsYzF0ellXeGxYMnRsZVYwZ1BTQnpZV3hsTGw5eVpYQnNZV05sS0dKcFpEMXVaWGRmWW1sa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURnZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUyTmdvZ0lDQWdMeThnYldKeVgySmhjMlZzYVc1bElEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z2JtVjNYMkpwWkY5eVpXTmxhWEIwSUQwZ1FtbGtVbVZqWldsd2RDaHpZV3hsWDJ0bGVTd2dibVYzWDJKcFpGOWhiVzkxYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRTJPQW9nSUNBZ0x5OGdjbVZqWldsd2RGOWliMjlyTENCbGVHbHpkSE1nUFNCelpXeG1MbkpsWTJWcGNIUmZZbTl2YXk1dFlYbGlaU2hVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WalpXbHdkRjlpYjI5cklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakUyT1FvZ0lDQWdMeThnYVdZZ1pYaHBjM1J6T2dvZ0lDQWdZbm9nWW1sa1gyVnNjMlZmWW05a2VVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUdadmRXNWtMQ0JwYm1SbGVDQTlJR1pwYm1SZlltbGtYM0psWTJWcGNIUW9jbVZqWldsd2RGOWliMjlyTENCellXeGxYMnRsZVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1ptbHVaRjlpYVdSZmNtVmpaV2x3ZEFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE56RUtJQ0FnSUM4dklHbG1JR1p2ZFc1a09nb2dJQ0FnWW5vZ1ltbGtYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZElDczlJSEpsWTJWcGNIUmZZbTl2YTF0cGJtUmxlRjB1WVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHVndiM05wZEdWa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSbFpDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCcGJuUmpYeklnTHk4Z05EZ0tJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY0hWemFHbHVkQ0EwTUNBdkx5QTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE56TXRNVGMxQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxZMlZwY0hSZlltOXZhMXRVZUc0dWMyVnVaR1Z5WFNBOUlISmxZMlZwY0hSZlltOXZheTV5WlhCc1lXTmxLQW9nSUNBZ0x5OGdJQ0FnSUdsdVpHVjRMQ0J1WlhkZlltbGtYM0psWTJWcGNIUUtJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94TnpNS0lDQWdJQzh2SUhObGJHWXVjbVZqWldsd2RGOWliMjlyVzFSNGJpNXpaVzVrWlhKZElEMGdjbVZqWldsd2RGOWliMjlyTG5KbGNHeGhZMlVvQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldObGFYQjBYMkp2YjJzaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRTNNeTB4TnpVS0lDQWdJQzh2SUhObGJHWXVjbVZqWldsd2RGOWliMjlyVzFSNGJpNXpaVzVrWlhKZElEMGdjbVZqWldsd2RGOWliMjlyTG5KbGNHeGhZMlVvQ2lBZ0lDQXZMeUFnSUNBZ2FXNWtaWGdzSUc1bGQxOWlhV1JmY21WalpXbHdkQW9nSUNBZ0x5OGdLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0NtSnBaRjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUcxaWNsOWthV1ptSUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1dGFXNWZZbUZzWVc1alpTQXRJRzFpY2w5aVlYTmxiR2x1WlFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJR0ZqWTI5MWJuUWdablZ1WkdWa0NpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRneUNpQWdJQ0F2THlCelpXeG1MbVJsY0c5emFYUmxaRnRVZUc0dWMyVnVaR1Z5WFNBdFBTQnVaWGRmWW1sa1gyRnRiM1Z1ZEM1dVlYUnBkbVVnS3lCdFluSmZaR2xtWmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdWd2IzTnBkR1ZrSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SbGNHOXphWFJsWkNCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ21KcFpGOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFM053b2dJQ0FnTHk4Z2MyVnNaaTV5WldObGFYQjBYMkp2YjJ0YlZIaHVMbk5sYm1SbGNsMGdQU0J5WldObGFYQjBYMkp2YjJzdVlYQndaVzVrS0c1bGQxOWlhV1JmY21WalpXbHdkQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUEwT0FvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZqWldsd2RGOWliMjlySWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCaWFXUmZZV1owWlhKZmFXWmZaV3h6WlVBNENncGlhV1JmWld4elpWOWliMlI1UURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJSE5sYkdZdWNtVmpaV2x3ZEY5aWIyOXJXMVI0Ymk1elpXNWtaWEpkSUQwZ1NXMXRkWFJoWW14bFFYSnlZWGtvYm1WM1gySnBaRjl5WldObGFYQjBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WalpXbHdkRjlpYjI5cklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQmlhV1JmWVdaMFpYSmZhV1pmWld4elpVQTRDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdVkyOXVkSEpoWTNRdVJHbG5hWFJoYkUxaGNtdGxkSEJzWVdObExtbHpYMlZ1WTNWdFltVnlaV1FvWW1sa09pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncHBjMTlsYm1OMWJXSmxjbVZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UZzBMVEU0TlFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQnBjMTlsYm1OMWJXSmxjbVZrS0hObGJHWXNJR0pwWkRvZ1FtbGtVbVZqWldsd2RDa2dMVDRnWW05dmJEb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pFNE5nb2dJQ0FnTHk4Z2MyRnNaU3dnWlhocGMzUnpJRDBnYzJWc1ppNXpZV3hsY3k1dFlYbGlaU2hpYVdRdWMyRnNaVjlyWlhrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwTUNBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk5oYkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveE9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCbGVHbHpkSE1nWVc1a0lHSnZiMndvYzJGc1pTNWlhV1F1WW1sa1pHVnlLU0JoYm1RZ2MyRnNaUzVpYVdRdVltbGtaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNklHbHpYMlZ1WTNWdFltVnlaV1JmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhOaUEwTUNBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaWVpQnBjMTlsYm1OMWJXSmxjbVZrWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWVpQnBjMTlsYm1OMWJXSmxjbVZrWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtbHpYMlZ1WTNWdFltVnlaV1JmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNVGczQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdaWGhwYzNSeklHRnVaQ0JpYjI5c0tITmhiR1V1WW1sa0xtSnBaR1JsY2lrZ1lXNWtJSE5oYkdVdVltbGtMbUpwWkdSbGNpQTlQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2FYTmZaVzVqZFcxaVpYSmxaRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJwYzE5bGJtTjFiV0psY21Wa1gySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObExtTnZiblJ5WVdOMExrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpTNWpiR0ZwYlY5MWJtVnVZM1Z0WW1WeVpXUmZZbWxrY3lncElDMCtJSFp2YVdRNkNtTnNZV2x0WDNWdVpXNWpkVzFpWlhKbFpGOWlhV1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UZzVMVEU1TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHTnNZV2x0WDNWdVpXNWpkVzFpWlhKbFpGOWlhV1J6S0hObGJHWXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF3SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdaVzVqZFcxaVpYSmxaRjl5WldObGFYQjBjeUE5SUVsdGJYVjBZV0pzWlVGeWNtRjVXMEpwWkZKbFkyVnBjSFJkS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUdadmNpQnlaV05sYVhCMElHbHVJSE5sYkdZdWNtVmpaV2x3ZEY5aWIyOXJXMVI0Ymk1elpXNWtaWEpkT2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WalpXbHdkRjlpYjI5cklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WalpXbHdkRjlpYjI5cklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tZMnhoYVcxZmRXNWxibU4xYldKbGNtVmtYMkpwWkhOZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrekNpQWdJQ0F2THlCbWIzSWdjbVZqWldsd2RDQnBiaUJ6Wld4bUxuSmxZMlZwY0hSZlltOXZhMXRVZUc0dWMyVnVaR1Z5WFRvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ1kyeGhhVzFmZFc1bGJtTjFiV0psY21Wa1gySnBaSE5mWVdaMFpYSmZabTl5UURjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdsdWRHTmZNaUF2THlBME9Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRFE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtbHpYMlZ1WTNWdFltVnlaV1FvY21WalpXbHdkQ2s2Q2lBZ0lDQmpZV3hzYzNWaUlHbHpYMlZ1WTNWdFltVnlaV1FLSUNBZ0lHSjZJR05zWVdsdFgzVnVaVzVqZFcxaVpYSmxaRjlpYVdSelgyVnNjMlZmWW05a2VVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG94T1RVS0lDQWdJQzh2SUdWdVkzVnRZbVZ5WldSZmNtVmpaV2x3ZEhNZ1BTQmxibU4xYldKbGNtVmtYM0psWTJWcGNIUnpMbUZ3Y0dWdVpDaHlaV05sYVhCMEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdORGdLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0tZMnhoYVcxZmRXNWxibU4xYldKbGNtVmtYMkpwWkhOZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR0lnWTJ4aGFXMWZkVzVsYm1OMWJXSmxjbVZrWDJKcFpITmZabTl5WDJobFlXUmxja0F4Q2dwamJHRnBiVjkxYm1WdVkzVnRZbVZ5WldSZlltbGtjMTlsYkhObFgySnZaSGxBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdjMlZzWmk1a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMGdLejBnY21WalpXbHdkQzVoYlc5MWJuUXVibUYwYVhabENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwWldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVndiM05wZEdWa0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJRFF3SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQmpiR0ZwYlY5MWJtVnVZM1Z0WW1WeVpXUmZZbWxrYzE5aFpuUmxjbDlwWmw5bGJITmxRRFVLQ21Oc1lXbHRYM1Z1Wlc1amRXMWlaWEpsWkY5aWFXUnpYMkZtZEdWeVgyWnZja0EzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1UazVDaUFnSUNBdkx5QnRZbkpmWW1GelpXeHBibVVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJwWmlCbGJtTjFiV0psY21Wa1gzSmxZMlZwY0hSek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdZbm9nWTJ4aGFXMWZkVzVsYm1OMWJXSmxjbVZrWDJKcFpITmZaV3h6WlY5aWIyUjVRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJd01Rb2dJQ0FnTHk4Z2MyVnNaaTV5WldObGFYQjBYMkp2YjJ0YlZIaHVMbk5sYm1SbGNsMGdQU0JsYm1OMWJXSmxjbVZrWDNKbFkyVnBjSFJ6Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WldObGFYQjBYMkp2YjJzaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb0tZMnhoYVcxZmRXNWxibU4xYldKbGNtVmtYMkpwWkhOZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSXdOQW9nSUNBZ0x5OGdiV0p5WDJScFptWWdQU0J0WW5KZlltRnpaV3hwYm1VZ0xTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtMXBibDlpWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lNRFlLSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJQ3M5SUcxaWNsOWthV1ptQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWlhCdmMybDBaV1FpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWd2IzTnBkR1ZrSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0NtTnNZV2x0WDNWdVpXNWpkVzFpWlhKbFpGOWlhV1J6WDJWc2MyVmZZbTlrZVVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV5WldObGFYQjBYMkp2YjJ0YlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxZMlZwY0hSZlltOXZheUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmlJR05zWVdsdFgzVnVaVzVqZFcxaVpYSmxaRjlpYVdSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzVqYjI1MGNtRmpkQzVFYVdkcGRHRnNUV0Z5YTJWMGNHeGhZMlV1WjJWMFgzUnZkR0ZzWDJGdVpGOTFibVZ1WTNWdFltVnlaV1JmWW1sa2N5Z3BJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BuWlhSZmRHOTBZV3hmWVc1a1gzVnVaVzVqZFcxaVpYSmxaRjlpYVdSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNakE0TFRJd09Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjkwYjNSaGJGOWhibVJmZFc1bGJtTjFiV0psY21Wa1gySnBaSE1vYzJWc1ppa2dMVDRnVlc1bGJtTjFiV0psY21Wa1FtbGtjMUpsWTJWcGNIUTZDaUFnSUNCd2NtOTBieUF3SURJS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUIwYjNSaGJGOWlhV1J6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1qRXdMVEl4TVFvZ0lDQWdMeThnZEc5MFlXeGZZbWxrY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z2RXNWxibU4xYldKbGNtVmtYMkpwWkhNZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdSMWNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFekNpQWdJQ0F2THlCeVpXTmxhWEIwWDJKdmIyc3NJR1Y0YVhOMGN5QTlJSE5sYkdZdWNtVmpaV2x3ZEY5aWIyOXJMbTFoZVdKbEtGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaV05sYVhCMFgySnZiMnNpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJeE5Bb2dJQ0FnTHk4Z2FXWWdaWGhwYzNSek9nb2dJQ0FnWW5vZ1oyVjBYM1J2ZEdGc1gyRnVaRjkxYm1WdVkzVnRZbVZ5WldSZlltbGtjMTloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakl4TlFvZ0lDQWdMeThnWm05eUlISmxZMlZwY0hRZ2FXNGdjbVZqWldsd2RGOWliMjlyT2dvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENncG5aWFJmZEc5MFlXeGZZVzVrWDNWdVpXNWpkVzFpWlhKbFpGOWlhV1J6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakl4TlFvZ0lDQWdMeThnWm05eUlISmxZMlZwY0hRZ2FXNGdjbVZqWldsd2RGOWliMjlyT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBOENpQWdJQ0JpZWlCblpYUmZkRzkwWVd4ZllXNWtYM1Z1Wlc1amRXMWlaWEpsWkY5aWFXUnpYMkZtZEdWeVgyWnZja0EzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QTBPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveU1UWUtJQ0FnSUM4dklIUnZkR0ZzWDJKcFpITWdLejBnY21WalpXbHdkQzVoYlc5MWJuUXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOREFnTHk4Z05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCcFppQnViM1FnYzJWc1ppNXBjMTlsYm1OMWJXSmxjbVZrS0hKbFkyVnBjSFFwT2dvZ0lDQWdZMkZzYkhOMVlpQnBjMTlsYm1OMWJXSmxjbVZrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCaWJub2daMlYwWDNSdmRHRnNYMkZ1WkY5MWJtVnVZM1Z0WW1WeVpXUmZZbWxrYzE5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z2RXNWxibU4xYldKbGNtVmtYMkpwWkhNZ0t6MGdjbVZqWldsd2RDNWhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvS1oyVjBYM1J2ZEdGc1gyRnVaRjkxYm1WdVkzVnRZbVZ5WldSZlltbGtjMTloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCblpYUmZkRzkwWVd4ZllXNWtYM1Z1Wlc1amRXMWlaWEpsWkY5aWFXUnpYMlp2Y2w5b1pXRmtaWEpBTWdvS1oyVjBYM1J2ZEdGc1gyRnVaRjkxYm1WdVkzVnRZbVZ5WldSZlltbGtjMTloWm5SbGNsOW1iM0pBTnpvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEY0tDbWRsZEY5MGIzUmhiRjloYm1SZmRXNWxibU4xYldKbGNtVmtYMkpwWkhOZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG95TWpBS0lDQWdJQzh2SUhKbGRIVnliaUJWYm1WdVkzVnRZbVZ5WldSQ2FXUnpVbVZqWldsd2RDaDBiM1JoYkY5aWFXUnpMQ0IxYm1WdVkzVnRZbVZ5WldSZlltbGtjeWtLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTNWpiMjUwY21GamRDNUVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVXVZV05qWlhCMFgySnBaQ2hoYzNObGREb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRmpZMlZ3ZEY5aWFXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbG5hWFJoYkY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNXdlVG95TWpJdE1qSXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWVdOalpYQjBYMkpwWkNoelpXeG1MQ0JoYzNObGREb2dZWEpqTkM1VlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdjMkZzWlY5clpYa2dQU0JUWVd4bFMyVjVLRzkzYm1WeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3Z1lYTnpaWFE5WVhOelpYUXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNakkxQ2lBZ0lDQXZMeUJ6WVd4bElEMGdjMlZzWmk1ellXeGxjMXR6WVd4bFgydGxlVjBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk5oYkdWeklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6WVd4bGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJeU5nb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aVpYTjBYMkpwWkNBOUlITmhiR1V1WW1sa0NpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTkRBZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2xuYVhSaGJGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzV3ZVRveU1qY0tJQ0FnSUM4dklHTjFjbkpsYm5SZlltVnpkRjlpYVdSa1pYSWdQU0JqZFhKeVpXNTBYMkpsYzNSZlltbGtMbUpwWkdSbGNpNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lNamtLSUNBZ0lDOHZJSE5sYkd4bGNsOXRZbkpmWW1GelpXeHBibVVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnWkdWc0lITmxiR1l1YzJGc1pYTmJjMkZzWlY5clpYbGRDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNak15Q2lBZ0lDQXZMeUJ6Wld4c1pYSmZiV0p5WDJKaGMyVnNhVzVsSUMwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1dGFXNWZZbUZzWVc1alpRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lNelVLSUNBZ0lDOHZJSE5sYkdZdVpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJQ3M5SUdOMWNuSmxiblJmWW1WemRGOWlhV1F1WVcxdmRXNTBMbTVoZEdsMlpTQXJJSE5sYkd4bGNsOXRZbkpmWkdsbVpnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpHVndiM05wZEdWa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSbFpDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1qTTJMVEkwTUFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFdOMWNuSmxiblJmWW1WemRGOWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhOaGJHVXVZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMWhjM05sZEM1dVlYUnBkbVVzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQWE5oYkdVdVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSXpOaTB5TkRBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxamRYSnlaVzUwWDJKbGMzUmZZbWxrWkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxellXeGxMbUZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1qUXlDaUFnSUNBdkx5QnlaV05sYVhCMFgySnZiMnNnUFNCelpXeG1MbkpsWTJWcGNIUmZZbTl2YTF0amRYSnlaVzUwWDJKbGMzUmZZbWxrWkdWeVhRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNtVmpaV2x3ZEY5aWIyOXJJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WalpXbHdkRjlpYjI5cklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpRekNpQWdJQ0F2THlCbWIzVnVaQ3dnYVc1a1pYZ2dQU0JtYVc1a1gySnBaRjl5WldObGFYQjBLSEpsWTJWcGNIUmZZbTl2YXl3Z2MyRnNaVjlyWlhrcENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCbWFXNWtYMkpwWkY5eVpXTmxhWEIwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lORFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1iM1Z1WkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lORFlLSUNBZ0lDOHZJR1Z1WTNWdFltVnlaV1JmY21WalpXbHdkSE1nUFNCSmJXMTFkR0ZpYkdWQmNuSmhlVnRDYVdSU1pXTmxhWEIwWFNncENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpRM0NpQWdJQ0F2THlCbWIzSWdjbVZqWldsd2RDQnBiaUJ5WldObGFYQjBYMkp2YjJzNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwaFkyTmxjSFJmWW1sa1gyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJME53b2dJQ0FnTHk4Z1ptOXlJSEpsWTJWcGNIUWdhVzRnY21WalpXbHdkRjlpYjI5ck9nb2dJQ0FnWm5KaGJXVmZaR2xuSURrS0lDQWdJR1p5WVcxbFgyUnBaeUE0Q2lBZ0lDQThDaUFnSUNCaWVpQmhZMk5sY0hSZlltbGtYMkZtZEdWeVgyWnZja0EzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBNUNpQWdJQ0JwYm5Salh6SWdMeThnTkRnS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdORGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSTBPQW9nSUNBZ0x5OGdhV1lnY21WalpXbHdkQ0FoUFNCeVpXTmxhWEIwWDJKdmIydGJhVzVrWlhoZE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR2x1ZEdOZk1pQXZMeUEwT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklEUTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDRTlDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpZWlCaFkyTmxjSFJmWW1sa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwWjJsMFlXeGZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1Y0hrNk1qUTVDaUFnSUNBdkx5QmxibU4xYldKbGNtVmtYM0psWTJWcGNIUnpJRDBnWlc1amRXMWlaWEpsWkY5eVpXTmxhWEIwY3k1aGNIQmxibVFvY21WalpXbHdkQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUEwT0FvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDZ3BoWTJObGNIUmZZbWxrWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBNUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTVDaUFnSUNCaUlHRmpZMlZ3ZEY5aWFXUmZabTl5WDJobFlXUmxja0F5Q2dwaFkyTmxjSFJmWW1sa1gyRm1kR1Z5WDJadmNrQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBaMmwwWVd4ZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpVeENpQWdJQ0F2THlCaWFXUmtaWEpmYldKeVgySmhjMlZzYVc1bElEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJMU1nb2dJQ0FnTHk4Z2FXWWdaVzVqZFcxaVpYSmxaRjl5WldObGFYQjBjem9LSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdKNklHRmpZMlZ3ZEY5aWFXUmZaV3h6WlY5aWIyUjVRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z2MyVnNaaTV5WldObGFYQjBYMkp2YjJ0YlkzVnljbVZ1ZEY5aVpYTjBYMkpwWkdSbGNsMGdQU0JsYm1OMWJXSmxjbVZrWDNKbFkyVnBjSFJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCaWIzaGZjSFYwQ2dwaFkyTmxjSFJmWW1sa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsbmFYUmhiRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1d2VUb3lOVGNLSUNBZ0lDOHZJR0pwWkdSbGNsOXRZbkpmWW1GelpXeHBibVVnTFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FXZHBkR0ZzWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExuQjVPakkxTmkweU5UZ0tJQ0FnSUM4dklHSnBaR1JsY2w5dFluSmZaR2xtWmlBOUlDZ0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSmZiV0p5WDJKaGMyVnNhVzVsSUMwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1dGFXNWZZbUZzWVc1alpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVdkcGRHRnNYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG5CNU9qSTFOd29nSUNBZ0x5OGdZbWxrWkdWeVgyMWljbDlpWVhObGJHbHVaU0F0SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM011YldsdVgySmhiR0Z1WTJVS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthV2RwZEdGc1gyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbkI1T2pJMk1Bb2dJQ0FnTHk4Z2MyVnNaaTVrWlhCdmMybDBaV1JiWTNWeWNtVnVkRjlpWlhOMFgySnBaR1JsY2wwZ0t6MGdZbWxrWkdWeVgyMWljbDlrYVdabUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1pYQnZjMmwwWldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSbFpDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3BoWTJObGNIUmZZbWxrWDJWc2MyVmZZbTlrZVVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScFoybDBZV3hmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdWNIazZNalUxQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV5WldObGFYQjBYMkp2YjJ0YlkzVnljbVZ1ZEY5aVpYTjBYMkpwWkdSbGNsMEtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdJZ1lXTmpaWEIwWDJKcFpGOWhablJsY2w5cFpsOWxiSE5sUURFd0NnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRXdCQ1lGQ1dSbGNHOXphWFJsWkF4eVpXTmxhWEIwWDJKdmIyc0ZjMkZzWlhNQUFnQUFNUnRCQVFlQ0NnUTJKZVRyQkNIeDNmOEVFd0FLbEFTbWtnQm1CQWxVU0JBRTFKckdEZ1NoangvOEJFVnVPWFVFSHF1N1dBVDQ0Tyt2TmhvQWpnb0FwQUNWQUlNQWFnQllBRWtBTndBckFCRUFBaUpETVJrVVJERVlSRFlhQVlnRThpTkRNUmtVUkRFWVJJZ0VlRXdXVEJaUWdBUVZIM3gxVEZDd0kwTXhHUlJFTVJoRWlBUEZJME14R1JSRU1SaEVOaG9CTmhvQ2lBS0dJME14R1JSRU1SaEVOaG9CaUFJT0kwTXhHUlJFTVJoRU5ob0JGOEF3aUFHNUkwTXhHUlJFTVJoRU1SWWpDVWs0RUNVU1JEWWFBWWdCS1NORE1Sa1VSREVZUkRZYUFSZkFNSWdBM2lORE1Sa1VSREVZUkRZYUFZZ0FweU5ETVJrVVJERVlSREVXSXdsSk9CQWpFa1NJQUVralF6RVpRUDlCTVJnVVJDTkRpZ0lDaS80aVdTS0xBWXNBREVFQUpZditWd0lBaXdFa0N5UllWd0FvaS84U1FRQUlJNHNCVHdOUEE0bUxBU01JakFGQy85TWlTVThEVHdPSmlnRUFpLzg0QURFQUVrU0wvemdITWdvU1JESUtjd0ZFS0RFQVVMNU1GeUpNVHdKTmkvODRDQ2d4QUZCT0FnZ1d2eklLY3dGRVRBa29NUUJRU2I1TUYweEVUd0lKRnIrSmlnRUFLREVBVUVtK1RCZE1SSXYvRjB4TEFRa1dUd0pNdjdFeEFMSUhzZ2dqc2hBaXNnR3ppWW9CQURJS2kvOXdBRVVCRkVTTC8zRUtSRElERWtRb01RQlFTYjVNRjB4RU1oQUpGcit4TWdvaXNoS3lGSXYvc2hFbHNoQWlzZ0d6aVlvQ0FJditPQUF4QUJKRWkvNDRGRElLRWtReEFJditPQkVXVUNwTVVFbTlSUUVVUkRJS2N3RkVpLzQ0RWhhTC8xQ0FLQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCUVR3Sk12eklLY3dGRVRBa29NUUJRU2I1TUYweEVUd0lKRnIrSmlnRUFNUUNML3haUXNURUFLazhDVUVtK1JDSmJzaEpNc2hTTC83SVJKYklRSXJJQnN6SUtjd0ZFVEx4SU1ncHpBVVFKS0RFQVVFbStUQmRNUkU4Q0NCYS9pWW9CQURFQWkvOVhBQ0JNU3dFVFJDcUwvMUJKdmtTeGkvK0JJRnN4QUVzQ0lsdXlFcklVc2hFbHNoQWlzZ0d6TWdwekFVUlBBcnhJTWdwekFVUUpLREVBVUVtK1RCZE1SRThEZ1FoYlRFc0JDUlpQQWt5L0tFOERVRW0rVEJkTVJFOENUd01JQ0JhL2lZb0NBQ0pKSzBreEFJdi9VSXYrVndBZ01RQVRSQ3FML2xCSnZreEpUd0pFVnhBb1NWY0FJRElERTBFQUNvc0hnU0JiaS84WERFU0xCa2xYQUFoTVZ3Z0lVSXNFVUlzRlRMOHlDbk1CVEl3RFJJditpLzlRakFBcE1RQlF2a3lNQVVFQWhvc0JpLzZJL1k2TUFrRUFYQ2d4QUZCSnZrd1hURVNMQVVsT0FsY0NBSXNDU1U0RUpBdE1Td0VrV0lFb1cwOENDQlpQQkV5L1N3RWlXVThERFVTQkFnaUxBRjBwTVFCUVNieElUTDh5Q25NQlJJc0RDU2d4QUZCSnZrd1hURVNML3hkUEF3Z0pGcitKaXdGWEFnQ0xBRkJKRlNRS0ZsY0dBa3hRS1RFQVVFbThTRXkvUXYvR2dBSUFBWXNBVUNreEFGQkp2RWhNdjBML3M0b0JBU0tMLzFjQUtDcE1VTDVCQUIyTEFWY1FLRmNBSUVtTUFESURFMEVBRElzQU1RQVNRUUFFSTR3QWlTSkMvL21LQUFBckp3UXBNUUJRdmt4SlR3SkVJbGtpaXdTTEF3eEJBRU9MQWxjQ0FJc0VKQXNrV0VtSS82VkJBQnlMQVZjQ0FFeFFTUlVrQ2haWEJnSk1VSXdCaXdRakNJd0VRdi9LS0RFQVVFbStUQmRNUkU4Q2dTaGJDQmEvUXYvaU1ncHpBVXlNQUVTTEFTSlpRUUFqS1RFQVVFbThTSXNCdnpJS2N3RkVpd0JNQ1NneEFGQkp2a3dYVEVSUEFnZ1d2NGtwTVFCUXZFaEMvOTZLQUFJclJ3SWlSd01wTVFCUXZreE9BMHhPQWtFQVRvc0ZJbG1NQUNLTUFZc0Jpd0FNUVFBMWl3VlhBZ0NMQVNRTEpGaEpnU2hiU1l3Q2l3TUlqQU9JL3ZTTEJJd0dRQUFIaXdTTEFnaU1Cb3NHakFTTEFTTUlqQUZDLzhPTEJJd0dpd09NQjRzSGl3YU1BWXdBaVlvQkFDSkpLekVBaS85UUtrc0JVRW0rUkVsWEVDaEpWd0FnU1U0RVRnVXlDbk1CUkU4RHZFZ3lDbk1CUkFrb01RQlFTYjVNRjB4RVR3T0JJRnRQQXdnSUZyK3hpLzhYVENKYnNoSkxBYklVc2hFbHNoQWlzZ0d6S1V4UVNVNEN2a3hKVGdKT0EwUkpUd0tJKzFkT0FrUW5CRXdpV1NLTENZc0lERUVBUW9zRlZ3SUFpd2trQzBzQlRDUllTVTRDakFHTEJpUUxKRmdUaXdlTUFFRUFGSXNIVndJQWl3RlFTUlVrQ2haWEJnSk1VSXdBaXdDTUI0c0pJd2lNQ1VML3RqSUtjd0ZNakFKRWl3Y2lXVUVBSVlzRVNieElpd2UvTWdwekFVU0xBa3dKS0lzRFVFbStUQmRNUkU4Q0NCYS9pWXNFdkVoQy8rQT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
