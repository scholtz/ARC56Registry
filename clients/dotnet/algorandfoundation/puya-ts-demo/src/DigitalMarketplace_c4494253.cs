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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.DigitalMarketplace_c4494253
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
            public class ListingKey : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong Asset { get; set; }

                public ulong Nonce { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ListingKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ListingKey();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ListingKey);
                }
                public bool Equals(ListingKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ListingKey left, ListingKey right)
                {
                    return EqualityComparer<ListingKey>.Default.Equals(left, right);
                }
                public static bool operator !=(ListingKey left, ListingKey right)
                {
                    return !(left == right);
                }

            }

            public class ListingValue : AVMObjectType
            {
                public ulong Deposited { get; set; }

                public ulong UnitaryPrice { get; set; }

                public Algorand.Address Bidder { get; set; }

                public ulong Bid { get; set; }

                public ulong BidUnitaryPrice { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeposited = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDeposited.From(Deposited);
                    ret.AddRange(vDeposited.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitaryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUnitaryPrice.From(UnitaryPrice);
                    ret.AddRange(vUnitaryPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBidder.From(Bidder);
                    ret.AddRange(vBidder.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBid.From(Bid);
                    ret.AddRange(vBid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidUnitaryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBidUnitaryPrice.From(BidUnitaryPrice);
                    ret.AddRange(vBidUnitaryPrice.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ListingValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ListingValue();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeposited = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDeposited.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeposited = vDeposited.ToValue();
                    if (valueDeposited is ulong vDepositedValue) { ret.Deposited = vDepositedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitaryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUnitaryPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnitaryPrice = vUnitaryPrice.ToValue();
                    if (valueUnitaryPrice is ulong vUnitaryPriceValue) { ret.UnitaryPrice = vUnitaryPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidder = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBidder.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBidder = vBidder.ToValue();
                    if (valueBidder is Algorand.Address vBidderValue) { ret.Bidder = vBidderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBid = vBid.ToValue();
                    if (valueBid is ulong vBidValue) { ret.Bid = vBidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidUnitaryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBidUnitaryPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBidUnitaryPrice = vBidUnitaryPrice.ToValue();
                    if (valueBidUnitaryPrice is ulong vBidUnitaryPriceValue) { ret.BidUnitaryPrice = vBidUnitaryPriceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ListingValue);
                }
                public bool Equals(ListingValue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ListingValue left, ListingValue right)
                {
                    return EqualityComparer<ListingValue>.Default.Equals(left, right);
                }
                public static bool operator !=(ListingValue left, ListingValue right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> ListingsBoxMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 75, 49, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListingsBoxMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 75, 49, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="quantity"> </param>
        /// <param name="price"> </param>
        /// <param name="assetDecimals"> </param>
        public async Task<ulong> QuantityPrice(ulong quantity, ulong price, ulong assetDecimals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 203, 54, 147 };
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var assetDecimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetDecimalsAbi.From(assetDecimals);

            var result = await base.CallApp(new List<object> { abiHandle, quantityAbi, priceAbi, assetDecimalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> QuantityPrice_Transactions(ulong quantity, ulong price, ulong assetDecimals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 203, 54, 147 };
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var assetDecimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetDecimalsAbi.From(assetDecimals);

            return await base.MakeTransactionList(new List<object> { abiHandle, quantityAbi, priceAbi, assetDecimalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetListingsMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 142, 246, 169 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetListingsMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 142, 246, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPay"> </param>
        /// <param name="asset"> </param>
        public async Task AllowAsset(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 106, 78, 127, 202 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AllowAsset_Transactions(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 106, 78, 127, 202 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPay"> </param>
        /// <param name="xfer"> </param>
        /// <param name="unitaryPrice"> </param>
        /// <param name="nonce"> </param>
        public async Task FirstDeposit(PaymentTransaction mbrPay, AssetTransferTransaction xfer, ulong unitaryPrice, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay, xfer });
            byte[] abiHandle = { 18, 240, 140, 152 };
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, xfer, unitaryPriceAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FirstDeposit_Transactions(PaymentTransaction mbrPay, AssetTransferTransaction xfer, ulong unitaryPrice, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay, xfer });
            byte[] abiHandle = { 18, 240, 140, 152 };
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, xfer, unitaryPriceAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xfer"> </param>
        /// <param name="nonce"> </param>
        public async Task Deposit(AssetTransferTransaction xfer, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 155, 75, 130, 52 };
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, xfer, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(AssetTransferTransaction xfer, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 155, 75, 130, 52 };
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, xfer, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        /// <param name="unitaryPrice"> </param>
        public async Task SetPrice(ulong asset, ulong nonce, ulong unitaryPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 139, 35, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, nonceAbi, unitaryPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPrice_Transactions(ulong asset, ulong nonce, ulong unitaryPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 139, 35, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, nonceAbi, unitaryPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        /// <param name="buyPay"> </param>
        /// <param name="quantity"> </param>
        public async Task Buy(PaymentTransaction buyPay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyPay });
            byte[] abiHandle = { 82, 172, 93, 247 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, buyPay, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Buy_Transactions(PaymentTransaction buyPay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyPay });
            byte[] abiHandle = { 82, 172, 93, 247 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, buyPay, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        public async Task Withdraw(ulong asset, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 174, 178, 92 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong asset, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 174, 178, 92 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        /// <param name="bidPay"> </param>
        /// <param name="quantity"> </param>
        /// <param name="unitaryPrice"> </param>
        public async Task Bid(PaymentTransaction bidPay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, ulong unitaryPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { bidPay });
            byte[] abiHandle = { 50, 52, 183, 17 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, bidPay, quantityAbi, unitaryPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(PaymentTransaction bidPay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, ulong unitaryPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { bidPay });
            byte[] abiHandle = { 50, 52, 183, 17 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var unitaryPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitaryPriceAbi.From(unitaryPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, bidPay, quantityAbi, unitaryPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        public async Task AcceptBid(ulong asset, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 99, 70 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptBid_Transactions(ulong asset, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 99, 70 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbE1hcmtldHBsYWNlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ikxpc3RpbmdLZXkiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In1dLCJMaXN0aW5nVmFsdWUiOlt7Im5hbWUiOiJkZXBvc2l0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidW5pdGFyeVByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJpZGRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYmlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJpZFVuaXRhcnlQcmljZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoibGlzdGluZ3NCb3hNYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJxdWFudGl0eVByaWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InF1YW50aXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXREZWNpbWFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldExpc3RpbmdzTWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGxvd0Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmlyc3REZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0YXJ5UHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eVBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVhbnRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmlkUGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdGFyeVByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjY2VwdEJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NzYsNTM2LDYwNyw3MzUsODgwLDEwNDJdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjEsNzU5LDkxNCw5NTUsMTA4OV0sImVycm9yTWVzc2FnZSI6ImFzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Niw0MzVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI3LDI4Niw1ODksODU1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJREV3SURRZ05UQTFNREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbXhwYzNScGJtZHpJaUJpWVhObE16SW9RVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFTa2dNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TUdNMU5EUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5QkVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVWdaWGgwWlc1a2N5QmhjbU0wTGtOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhPQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpWlRSaU16RmxNeUF3ZUdFd1kySXpOamt6SURCNFpEazRaV1kyWVRrZ01IZzJZVFJsTjJaallTQXdlREV5WmpBNFl6azRJREI0T1dJMFlqZ3lNelFnTUhnMFpEaGlNak5rT0NBd2VEVXlZV00xWkdZM0lEQjRaVE5oWldJeU5XTWdNSGd6TWpNMFlqY3hNU0F3ZUdOak9ESTJNelEySUM4dklHMWxkR2h2WkNBaWJHbHpkR2x1WjNOQ2IzaE5ZbklvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY1hWaGJuUnBkSGxRY21salpTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEV4cGMzUnBibWR6VFdKeUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltRnNiRzkzUVhOelpYUW9jR0Y1TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm1hWEp6ZEVSbGNHOXphWFFvY0dGNUxHRjRabVZ5TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVndiM05wZENoaGVHWmxjaXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVSEpwWTJVb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVluVjVLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4d1lYa3NkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVltbGtLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4d1lYa3NkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poWTJObGNIUkNhV1FvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlzYVhOMGFXNW5jMEp2ZUUxaWNsOXliM1YwWlVBMElIRjFZVzUwYVhSNVVISnBZMlVnYldGcGJsOW5aWFJNYVhOMGFXNW5jMDFpY2w5eWIzVjBaVUEySUdGc2JHOTNRWE56WlhRZ1ptbHljM1JFWlhCdmMybDBJR1JsY0c5emFYUWdjMlYwVUhKcFkyVWdZblY1SUhkcGRHaGtjbUYzSUdKcFpDQmhZMk5sY0hSQ2FXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUk1hWE4wYVc1bmMwMWljbDl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQmpOVFEwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiR2x6ZEdsdVozTkNiM2hOWW5KZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJzYVhOMGFXNW5jMEp2ZUUxaWNpZ3BPaUIxYVc1ME5qUWdld29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3WXpVME5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4T0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCRWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVZ1pYaDBaVzVrY3lCaGNtTTBMa052Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1SUM4dklHOXVJR1Z5Y205eU9pQlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29LQ2k4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pwRWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVdWNYVmhiblJwZEhsUWNtbGpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25GMVlXNTBhWFI1VUhKcFkyVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMU5DMDFPQW9nSUNBZ0x5OGdjWFZoYm5ScGRIbFFjbWxqWlNnS0lDQWdJQzh2SUNBZ2NYVmhiblJwZEhrNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NISnBZMlU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWVhOelpYUkVaV05wYldGc2N6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCamIyNXpkQ0JiWVcxdmRXNTBUbTkwVTJOaGJHVmtTR2xuYUN3Z1lXMXZkVzUwVG05MFUyTmhiR1ZrVEc5M1hTQTlJRzl3TG0xMWJIY29jSEpwWTJVc0lIRjFZVzUwYVhSNUtUc0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiWFZzZHdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR052Ym5OMElGdHpZMkZzYVc1blJtRmpkRzl5U0dsbmFDd2djMk5oYkdsdVowWmhZM1J2Y2t4dmQxMGdQU0J2Y0M1bGVIQjNLREV3TENCaGMzTmxkRVJsWTJsdFlXeHpLVHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhCM0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem8yTWkwMk53b2dJQ0FnTHk4Z2IzQXVaR2wyYlc5a2R5Z0tJQ0FnSUM4dklDQWdZVzF2ZFc1MFRtOTBVMk5oYkdWa1NHbG5hQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBUbTkwVTJOaGJHVmtURzkzTEFvZ0lDQWdMeThnSUNCelkyRnNhVzVuUm1GamRHOXlTR2xuYUN3S0lDQWdJQzh2SUNBZ2MyTmhiR2x1WjBaaFkzUnZja3h2ZHl3S0lDQWdJQzh2SUNrN0NpQWdJQ0JrYVhadGIyUjNDaUFnSUNCd2IzQnVJRElLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QmhjM05sY25Rb1gzRjFiM1JwWlc1MFNHbG5hQ0E5UFQwZ01DazdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pVMExUVTRDaUFnSUNBdkx5QnhkV0Z1ZEdsMGVWQnlhV05sS0FvZ0lDQWdMeThnSUNCeGRXRnVkR2wwZVRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCd2NtbGpaVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFUmxZMmx0WVd4ek9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZPa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaUzVoYkd4dmQwRnpjMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXeHNiM2RCYzNObGREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeTVwYzA5d2RHVmtTVzRvWVhOelpYUXBLVHNLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZbkpRWVhrdWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOektUc0tJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QmhjM05sY25Rb2JXSnlVR0Y1TG1GdGIzVnVkQ0E5UFQwZ1IyeHZZbUZzTG1GemMyVjBUM0IwU1c1TmFXNUNZV3hoYm1ObEtUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWjJ4dlltRnNJRUZ6YzJWMFQzQjBTVzVOYVc1Q1lXeGhibU5sQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzROUzA1TVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvNE5TMDVNQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pnMUxUa3hDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T2tScFoybDBZV3hOWVhKclpYUndiR0ZqWlM1bWFYSnpkRVJsY0c5emFYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtYVhKemRFUmxjRzl6YVhRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QmhjM05sY25Rb2JXSnlVR0Y1TG5ObGJtUmxjaUE5UFQwZ1ZIaHVMbk5sYm1SbGNpazdDaUFnSUNCa2FXY2dNd29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUdGemMyVnlkQ2h0WW5KUVlYa3VjbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpLVHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnWVhOelpYSjBLRzFpY2xCaGVTNWhiVzkxYm5RZ1BUMDlJSFJvYVhNdWJHbHpkR2x1WjNOQ2IzaE5ZbklvS1NrN0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk16WXROVEFLSUNBZ0lDOHZJREpmTlRBd0lDc0tJQ0FnSUM4dklDOHZJR1p0ZERvZ2IyWm1DaUFnSUNBdkx5QXZMeUJMWlhrZ2JHVnVaM1JvQ2lBZ0lDQXZMeUFvT0NBckNpQWdJQ0F2THlBZ0lETXlJQ3NLSUNBZ0lDOHZJQ0FnT0NBckNpQWdJQ0F2THlBZ0lEZ2dLd29nSUNBZ0x5OGdJQ0F2THlCV1lXeDFaU0JzWlc1bmRHZ0tJQ0FnSUM4dklDQWdPQ0FyQ2lBZ0lDQXZMeUFnSURnZ0t3b2dJQ0FnTHk4Z0lDQXpNaUFyQ2lBZ0lDQXZMeUFnSURnZ0t3b2dJQ0FnTHk4Z0lDQTRLU0FxQ2lBZ0lDQXZMeUFnSUM4dklHWnRkRG9nYjI0S0lDQWdJQzh2SUNBZ05EQXdDaUFnSUNCcGJuUmpJRFFnTHk4Z05UQTFNREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMEtHMWljbEJoZVM1aGJXOTFiblFnUFQwOUlIUm9hWE11YkdsemRHbHVaM05DYjNoTlluSW9LU2s3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJRzkzYm1WeU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCaGMzTmxkRG9nYm1WM0lHRnlZelF1VldsdWREWTBLSGhtWlhJdWVHWmxja0Z6YzJWMExtbGtLU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV3TlMweE1Ea0tJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCTWFYTjBhVzVuUzJWNUtIc0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb2VHWmxjaTU0Wm1WeVFYTnpaWFF1YVdRcExBb2dJQ0FnTHk4Z0lDQnViMjVqWlRvZ2JtOXVZMlVzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2JHbHpkR2x1WjNNZ1BTQkNiM2hOWVhBOFRHbHpkR2x1WjB0bGVTd2dUR2x6ZEdsdVoxWmhiSFZsUGloN0lHdGxlVkJ5WldacGVEb2dJbXhwYzNScGJtZHpJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW14cGMzUnBibWR6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXNhWE4wYVc1bmN5aHJaWGtwTG1WNGFYTjBjeWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TVRJS0lDQWdJQzh2SUdGemMyVnlkQ2g0Wm1WeUxuTmxibVJsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaWs3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoNFptVnlMbUZ6YzJWMFVtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOektUc0tJQ0FnSUdScFp5QXlDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCaGMzTmxjblFvZUdabGNpNWhjM05sZEVGdGIzVnVkQ0ErSURBcE93b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1pHVndiM05wZEdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb2VHWmxjaTVoYzNObGRFRnRiM1Z1ZENrc0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TVRZdE1USXlDaUFnSUNBdkx5QjBhR2x6TG14cGMzUnBibWR6S0d0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnVEdsemRHbHVaMVpoYkhWbEtIc0tJQ0FnSUM4dklDQWdaR1Z3YjNOcGRHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9lR1psY2k1aGMzTmxkRUZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJSFZ1YVhSaGNubFFjbWxqWlRvZ2RXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0JpYVdSa1pYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU3dLSUNBZ0lDOHZJQ0FnWW1sa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZbWxrVlc1cGRHRnllVkJ5YVdObE9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxNeklvUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pwRWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVdVpHVndiM05wZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjRzl6YVhRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJRzkzYm1WeU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRJNUNpQWdJQ0F2THlCaGMzTmxkRG9nYm1WM0lHRnlZelF1VldsdWREWTBLSGhtWlhJdWVHWmxja0Z6YzJWMExtbGtLU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV5TnkweE16RUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCTWFYTjBhVzVuUzJWNUtIc0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb2VHWmxjaTU0Wm1WeVFYTnpaWFF1YVdRcExBb2dJQ0FnTHk4Z0lDQnViMjVqWlRvZ2JtOXVZMlVzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE16TUtJQ0FnSUM4dklHRnpjMlZ5ZENoNFptVnlMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2lrN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDRabVZ5TG1GemMyVjBVbVZqWldsMlpYSWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpLVHNLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UTTFDaUFnSUNBdkx5QmhjM05sY25Rb2VHWmxjaTVoYzNObGRFRnRiM1Z1ZENBK0lEQXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnYkdsemRHbHVaM01nUFNCQ2IzaE5ZWEE4VEdsemRHbHVaMHRsZVN3Z1RHbHpkR2x1WjFaaGJIVmxQaWg3SUd0bGVWQnlaV1pwZURvZ0lteHBjM1JwYm1keklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXhwYzNScGJtZHpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1kyOXVjM1FnWlhocGMzUnBibWNnUFNCamJHOXVaU2gwYUdsekxteHBjM1JwYm1kektHdGxlU2t1ZG1Gc2RXVXBPd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UTTVDaUFnSUNBdkx5QmlhV1E2SUdWNGFYTjBhVzVuTG1KcFpDd0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwT0NBNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUdKcFpGVnVhWFJoY25sUWNtbGpaVG9nWlhocGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05UWWdPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5QmlhV1JrWlhJNklHVjRhWE4wYVc1bkxtSnBaR1JsY2l3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREUySURNeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUhWdWFYUmhjbmxRY21salpUb2daWGhwYzNScGJtY3VkVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdPQ0E0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJR1Y0YVhOMGFXNW5MbVJsY0c5emFYUmxaQzVoYzFWcGJuUTJOQ2dwSUNzZ2VHWmxjaTVoYzNObGRFRnRiM1Z1ZEN3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRTBNeTB4TkRVS0lDQWdJQzh2SUdSbGNHOXphWFJsWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0FvZ0lDQWdMeThnSUNCbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRdVlYTlZhVzUwTmpRb0tTQXJJSGhtWlhJdVlYTnpaWFJCYlc5MWJuUXNDaUFnSUNBdkx5QXBMQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UTTRMVEUwTmdvZ0lDQWdMeThnZEdocGN5NXNhWE4wYVc1bmN5aHJaWGtwTG5aaGJIVmxJRDBnYm1WM0lFeHBjM1JwYm1kV1lXeDFaU2g3Q2lBZ0lDQXZMeUFnSUdKcFpEb2daWGhwYzNScGJtY3VZbWxrTEFvZ0lDQWdMeThnSUNCaWFXUlZibWwwWVhKNVVISnBZMlU2SUdWNGFYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnWW1sa1pHVnlPaUJsZUdsemRHbHVaeTVpYVdSa1pYSXNDaUFnSUNBdkx5QWdJSFZ1YVhSaGNubFFjbWxqWlRvZ1pYaHBjM1JwYm1jdWRXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0JrWlhCdmMybDBaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRdVlYTlZhVzUwTmpRb0tTQXJJSGhtWlhJdVlYTnpaWFJCYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ2tzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T2tScFoybDBZV3hOWVhKclpYUndiR0ZqWlM1elpYUlFjbWxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRkJ5YVdObE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJ2ZDI1bGNqb2dibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakUxTVMweE5UVUtJQ0FnSUM4dklHTnZibk4wSUd0bGVTQTlJRzVsZHlCTWFYTjBhVzVuUzJWNUtIc0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJR0Z6YzJWME9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb1lYTnpaWFF1YVdRcExBb2dJQ0FnTHk4Z0lDQnViMjVqWlRvZ2JtOXVZMlVzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJzYVhOMGFXNW5jeUE5SUVKdmVFMWhjRHhNYVhOMGFXNW5TMlY1TENCTWFYTjBhVzVuVm1Gc2RXVStLSHNnYTJWNVVISmxabWw0T2lBaWJHbHpkR2x1WjNNaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWliR2x6ZEdsdVozTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRTFOd29nSUNBZ0x5OGdZMjl1YzNRZ1pYaHBjM1JwYm1jZ1BTQmpiRzl1WlNoMGFHbHpMbXhwYzNScGJtZHpLR3RsZVNrdWRtRnNkV1VwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFU1Q2lBZ0lDQXZMeUJpYVdRNklHVjRhWE4wYVc1bkxtSnBaQ3dLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBME9DQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklHSnBaRlZ1YVhSaGNubFFjbWxqWlRvZ1pYaHBjM1JwYm1jdVltbGtWVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOVFlnT0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJpYVdSa1pYSTZJR1Y0YVhOMGFXNW5MbUpwWkdSbGNpd0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURFMklETXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklHUmxjRzl6YVhSbFpEb2daWGhwYzNScGJtY3VaR1Z3YjNOcGRHVmtMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFU0TFRFMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVzYVhOMGFXNW5jeWhyWlhrcExuWmhiSFZsSUQwZ2JtVjNJRXhwYzNScGJtZFdZV3gxWlNoN0NpQWdJQ0F2THlBZ0lHSnBaRG9nWlhocGMzUnBibWN1WW1sa0xBb2dJQ0FnTHk4Z0lDQmlhV1JWYm1sMFlYSjVVSEpwWTJVNklHVjRhWE4wYVc1bkxtSnBaRlZ1YVhSaGNubFFjbWxqWlN3S0lDQWdJQzh2SUNBZ1ltbGtaR1Z5T2lCbGVHbHpkR2x1Wnk1aWFXUmtaWElzQ2lBZ0lDQXZMeUFnSUdSbGNHOXphWFJsWkRvZ1pYaHBjM1JwYm1jdVpHVndiM05wZEdWa0xBb2dJQ0FnTHk4Z0lDQjFibWwwWVhKNVVISnBZMlU2SUhWdWFYUmhjbmxRY21salpTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pwRWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVdVluVjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW5WNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRZM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFM05TMHhOemtLSUNBZ0lDOHZJR052Ym5OMElHdGxlU0E5SUc1bGR5Qk1hWE4wYVc1blMyVjVLSHNLSUNBZ0lDOHZJQ0FnYjNkdVpYSTZJRzkzYm1WeUxBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0dGemMyVjBMbWxrS1N3S0lDQWdJQzh2SUNBZ2JtOXVZMlU2SUc1dmJtTmxMQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2JHbHpkR2x1WjNNZ1BTQkNiM2hOWVhBOFRHbHpkR2x1WjB0bGVTd2dUR2x6ZEdsdVoxWmhiSFZsUGloN0lHdGxlVkJ5WldacGVEb2dJbXhwYzNScGJtZHpJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW14cGMzUnBibWR6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUdOdmJuTjBJR3hwYzNScGJtY2dQU0JqYkc5dVpTaDBhR2x6TG14cGMzUnBibWR6S0d0bGVTa3VkbUZzZFdVcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCc2FYTjBhVzVuTG5WdWFYUmhjbmxRY21salpTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UZzJDaUFnSUNBdkx5QmhjM05sZEM1a1pXTnBiV0ZzY3l3S0lDQWdJR1JwWnlBMkNpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZVzF2ZFc1MFRtOTBVMk5oYkdWa1NHbG5hQ3dnWVcxdmRXNTBUbTkwVTJOaGJHVmtURzkzWFNBOUlHOXdMbTExYkhjb2NISnBZMlVzSUhGMVlXNTBhWFI1S1RzS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMUNpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWTI5dWMzUWdXM05qWVd4cGJtZEdZV04wYjNKSWFXZG9MQ0J6WTJGc2FXNW5SbUZqZEc5eVRHOTNYU0E5SUc5d0xtVjRjSGNvTVRBc0lHRnpjMlYwUkdWamFXMWhiSE1wT3dvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdWNGNIY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pZeUxUWTNDaUFnSUNBdkx5QnZjQzVrYVhadGIyUjNLQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUk9iM1JUWTJGc1pXUklhV2RvTEFvZ0lDQWdMeThnSUNCaGJXOTFiblJPYjNSVFkyRnNaV1JNYjNjc0NpQWdJQ0F2THlBZ0lITmpZV3hwYm1kR1lXTjBiM0pJYVdkb0xBb2dJQ0FnTHk4Z0lDQnpZMkZzYVc1blJtRmpkRzl5VEc5M0xBb2dJQ0FnTHk4Z0tUc0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGZjWFZ2ZEdsbGJuUklhV2RvSUQwOVBTQXdLVHNLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QmhjM05sY25Rb1luVjVVR0Y1TG5ObGJtUmxjaUE5UFQwZ1ZIaHVMbk5sYm1SbGNpazdDaUFnSUNCa2FXY2dOUW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94T1RBS0lDQWdJQzh2SUdGemMyVnlkQ2hpZFhsUVlYa3VjbVZqWldsMlpYSXVZbmwwWlhNZ1BUMDlJRzkzYm1WeUxtSjVkR1Z6S1RzS0lDQWdJR1JwWnlBMUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGlkWGxRWVhrdVlXMXZkVzUwSUQwOVBTQmhiVzkxYm5SVWIwSmxVR0ZwWkNrN0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UazBDaUFnSUNBdkx5QmlhV1E2SUd4cGMzUnBibWN1WW1sa0xBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTkRnZ09Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCaWFXUlZibWwwWVhKNVVISnBZMlU2SUd4cGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05UWWdPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UazJDaUFnSUNBdkx5QmlhV1JrWlhJNklHeHBjM1JwYm1jdVltbGtaR1Z5TEFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTXpJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakU1T0FvZ0lDQWdMeThnWkdWd2IzTnBkR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvYkdsemRHbHVaeTVrWlhCdmMybDBaV1F1WVhOVmFXNTBOalFvS1NBdElIRjFZVzUwYVhSNUtTd0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1Ua3pMVEU1T1FvZ0lDQWdMeThnZEdocGN5NXNhWE4wYVc1bmN5aHJaWGtwTG5aaGJIVmxJRDBnYm1WM0lFeHBjM1JwYm1kV1lXeDFaU2g3Q2lBZ0lDQXZMeUFnSUdKcFpEb2diR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQXZMeUFnSUdKcFpGVnVhWFJoY25sUWNtbGpaVG9nYkdsemRHbHVaeTVpYVdSVmJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJR0pwWkdSbGNqb2diR2x6ZEdsdVp5NWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lIVnVhWFJoY25sUWNtbGpaVG9nYkdsemRHbHVaeTUxYm1sMFlYSjVVSEpwWTJVc0NpQWdJQ0F2THlBZ0lHUmxjRzl6YVhSbFpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtHeHBjM1JwYm1jdVpHVndiM05wZEdWa0xtRnpWV2x1ZERZMEtDa2dMU0J4ZFdGdWRHbDBlU2tzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJd01TMHlNRGNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2NYVmhiblJwZEhrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJd05Bb2dJQ0FnTHk4Z1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSXdNUzB5TURZS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2djWFZoYm5ScGRIa3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem95TURFdE1qQTNDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUhGMVlXNTBhWFI1TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRZM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qcEVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVXVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSXhNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TWpFekNpQWdJQ0F2THlCdmQyNWxjam9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSXhNaTB5TVRZS0lDQWdJQzh2SUdOdmJuTjBJR3RsZVNBOUlHNWxkeUJNYVhOMGFXNW5TMlY1S0hzS0lDQWdJQzh2SUNBZ2IzZHVaWEk2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvWVhOelpYUXVhV1FwTEFvZ0lDQWdMeThnSUNCdWIyNWpaVG9nYm05dVkyVXNDaUFnSUNBdkx5QjlLVHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QnNhWE4wYVc1bmN5QTlJRUp2ZUUxaGNEeE1hWE4wYVc1blMyVjVMQ0JNYVhOMGFXNW5WbUZzZFdVK0tIc2dhMlY1VUhKbFptbDRPaUFpYkdsemRHbHVaM01pSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJHbHpkR2x1WjNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TWpFNENpQWdJQ0F2THlCamIyNXpkQ0JzYVhOMGFXNW5JRDBnWTJ4dmJtVW9kR2hwY3k1c2FYTjBhVzVuY3loclpYa3BMblpoYkhWbEtUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNakU1Q2lBZ0lDQXZMeUJwWmlBb2JHbHpkR2x1Wnk1aWFXUmtaWElnSVQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTa2dld29nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR0o2SUhkcGRHaGtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qSXhDaUFnSUNBdkx5QnNhWE4wYVc1bkxtSnBaQzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBPQ0F2THlBME9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJeU1nb2dJQ0FnTHk4Z2JHbHpkR2x1Wnk1aWFXUlZibWwwWVhKNVVISnBZMlV1WVhOVmFXNTBOalFvS1N3S0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOVFlnTHk4Z05UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklHRnpjMlYwTG1SbFkybHRZV3h6TEFvZ0lDQWdaR2xuSURVS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR052Ym5OMElGdGhiVzkxYm5ST2IzUlRZMkZzWldSSWFXZG9MQ0JoYlc5MWJuUk9iM1JUWTJGc1pXUk1iM2RkSUQwZ2IzQXViWFZzZHlod2NtbGpaU3dnY1hWaGJuUnBkSGtwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCdGRXeDNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNOallXeHBibWRHWVdOMGIzSklhV2RvTENCelkyRnNhVzVuUm1GamRHOXlURzkzWFNBOUlHOXdMbVY0Y0hjb01UQXNJR0Z6YzJWMFJHVmphVzFoYkhNcE93b2dJQ0FnYVc1MFkxOHlJQzh2SURFd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRjSGNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qWXlMVFkzQ2lBZ0lDQXZMeUJ2Y0M1a2FYWnRiMlIzS0FvZ0lDQWdMeThnSUNCaGJXOTFiblJPYjNSVFkyRnNaV1JJYVdkb0xBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5ST2IzUlRZMkZzWldSTWIzY3NDaUFnSUNBdkx5QWdJSE5qWVd4cGJtZEdZV04wYjNKSWFXZG9MQW9nSUNBZ0x5OGdJQ0J6WTJGc2FXNW5SbUZqZEc5eVRHOTNMQW9nSUNBZ0x5OGdLVHNLSUNBZ0lHUnBkbTF2WkhjS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdGemMyVnlkQ2hmY1hWdmRHbGxiblJJYVdkb0lEMDlQU0F3S1RzS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNakkxTFRJeU53b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3SUhKbFkyVnBkbVZ5T2lCc2FYTjBhVzVuTG1KcFpHUmxjaTV1WVhScGRtVXNJR0Z0YjNWdWREb2dZM1Z5Y21WdWRFSnBaRVJsY0c5emFYUWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qSTFMVEl5TmdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJzYVhOMGFXNW5MbUpwWkdSbGNpNXVZWFJwZG1Vc0lHRnRiM1Z1ZERvZ1kzVnljbVZ1ZEVKcFpFUmxjRzl6YVhRZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSXlOUzB5TWpjS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nYkdsemRHbHVaeTVpYVdSa1pYSXVibUYwYVhabExDQmhiVzkxYm5RNklHTjFjbkpsYm5SQ2FXUkVaWEJ2YzJsMElIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3AzYVhSb1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU16QUtJQ0FnSUM4dklIUm9hWE11YkdsemRHbHVaM01vYTJWNUtTNWtaV3hsZEdVb0tUc0tJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSXpNaTB5TXpRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3Z1lXMXZkVzUwT2lCMGFHbHpMbXhwYzNScGJtZHpRbTk0VFdKeUtDa2dmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qTXpDaUFnSUNBdkx5QXVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TENCaGJXOTFiblE2SUhSb2FYTXViR2x6ZEdsdVozTkNiM2hOWW5Jb0tTQjlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpZdE5UQUtJQ0FnSUM4dklESmZOVEF3SUNzS0lDQWdJQzh2SUM4dklHWnRkRG9nYjJabUNpQWdJQ0F2THlBdkx5QkxaWGtnYkdWdVozUm9DaUFnSUNBdkx5QW9PQ0FyQ2lBZ0lDQXZMeUFnSURNeUlDc0tJQ0FnSUM4dklDQWdPQ0FyQ2lBZ0lDQXZMeUFnSURnZ0t3b2dJQ0FnTHk4Z0lDQXZMeUJXWVd4MVpTQnNaVzVuZEdnS0lDQWdJQzh2SUNBZ09DQXJDaUFnSUNBdkx5QWdJRGdnS3dvZ0lDQWdMeThnSUNBek1pQXJDaUFnSUNBdkx5QWdJRGdnS3dvZ0lDQWdMeThnSUNBNEtTQXFDaUFnSUNBdkx5QWdJQzh2SUdadGREb2diMjRLSUNBZ0lDOHZJQ0FnTkRBd0NpQWdJQ0JwYm5SaklEUWdMeThnTlRBMU1EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU16SXRNak16Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc2djbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzSUdGdGIzVnVkRG9nZEdocGN5NXNhWE4wYVc1bmMwSnZlRTFpY2lncElIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3lNekl0TWpNMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0lHRnRiM1Z1ZERvZ2RHaHBjeTVzYVhOMGFXNW5jMEp2ZUUxaWNpZ3BJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3lNell0TWpReUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakl6T1FvZ0lDQWdMeThnWVhOelpYUlNaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJME1Bb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJR3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNak0yTFRJME1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJzYVhOMGFXNW5MbVJsY0c5emFYUmxaQzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qTTJMVEkwTWdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQnNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNakV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pwRWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJVdVltbGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW1sa09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TWpRMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSTFOQzB5TlRnS0lDQWdJQzh2SUdOdmJuTjBJR3RsZVNBOUlHNWxkeUJNYVhOMGFXNW5TMlY1S0hzS0lDQWdJQzh2SUNBZ2IzZHVaWElzQ2lBZ0lDQXZMeUFnSUdGemMyVjBPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9ZWE56WlhRdWFXUXBMQW9nSUNBZ0x5OGdJQ0J1YjI1alpTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCc2FYTjBhVzVuY3lBOUlFSnZlRTFoY0R4TWFYTjBhVzVuUzJWNUxDQk1hWE4wYVc1blZtRnNkV1UrS0hzZ2EyVjVVSEpsWm1sNE9pQWliR2x6ZEdsdVozTWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkdsemRHbHVaM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNall3Q2lBZ0lDQXZMeUJqYjI1emRDQnNhWE4wYVc1bklEMGdZMnh2Ym1Vb2RHaHBjeTVzYVhOMGFXNW5jeWhyWlhrcExuWmhiSFZsS1RzS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qWXhDaUFnSUNBdkx5QnBaaUFvYkdsemRHbHVaeTVpYVdSa1pYSWdJVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1NrZ2V3b2dJQ0FnWlhoMGNtRmpkQ0F4TmlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHSjZJR0pwWkY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSTJNZ29nSUNBZ0x5OGdZWE56WlhKMEtIVnVhWFJoY25sUWNtbGpaUzVoYzFWcGJuUTJOQ2dwSUQ0Z2JHbHpkR2x1Wnk1aWFXUlZibWwwWVhKNVVISnBZMlV1WVhOVmFXNTBOalFvS1NrN0NpQWdJQ0JrYVdjZ013b2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBMU5pQXZMeUExTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakkyTlFvZ0lDQWdMeThnYkdsemRHbHVaeTVpYVdRdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTkRnZ0x5OGdORGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3lOamNLSUNBZ0lDOHZJR0Z6YzJWMExtUmxZMmx0WVd4ekxBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdOdmJuTjBJRnRoYlc5MWJuUk9iM1JUWTJGc1pXUklhV2RvTENCaGJXOTFiblJPYjNSVFkyRnNaV1JNYjNkZElEMGdiM0F1YlhWc2R5aHdjbWxqWlN3Z2NYVmhiblJwZEhrcE93b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JYVnNkd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHTnZibk4wSUZ0elkyRnNhVzVuUm1GamRHOXlTR2xuYUN3Z2MyTmhiR2x1WjBaaFkzUnZja3h2ZDEwZ1BTQnZjQzVsZUhCM0tERXdMQ0JoYzNObGRFUmxZMmx0WVd4ektUc0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzJNaTAyTndvZ0lDQWdMeThnYjNBdVpHbDJiVzlrZHlnS0lDQWdJQzh2SUNBZ1lXMXZkVzUwVG05MFUyTmhiR1ZrU0dsbmFDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MFRtOTBVMk5oYkdWa1RHOTNMQW9nSUNBZ0x5OGdJQ0J6WTJGc2FXNW5SbUZqZEc5eVNHbG5hQ3dLSUNBZ0lDOHZJQ0FnYzJOaGJHbHVaMFpoWTNSdmNreHZkeXdLSUNBZ0lDOHZJQ2s3Q2lBZ0lDQmthWFp0YjJSM0NpQWdJQ0J3YjNCdUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCaGMzTmxjblFvWDNGMWIzUnBaVzUwU0dsbmFDQTlQVDBnTUNrN0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakkzTUMweU56SUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXlCeVpXTmxhWFpsY2pvZ2JHbHpkR2x1Wnk1aWFXUmtaWEl1Ym1GMGFYWmxMQ0JoYlc5MWJuUTZJR04xY25KbGJuUkNhV1JCYlc5MWJuUWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qY3dMVEkzTVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJzYVhOMGFXNW5MbUpwWkdSbGNpNXVZWFJwZG1Vc0lHRnRiM1Z1ZERvZ1kzVnljbVZ1ZEVKcFpFRnRiM1Z1ZENCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qY3dMVEkzTWdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJzYVhOMGFXNW5MbUpwWkdSbGNpNXVZWFJwZG1Vc0lHRnRiM1Z1ZERvZ1kzVnljbVZ1ZEVKcFpFRnRiM1Z1ZENCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tZbWxrWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSTNOZ29nSUNBZ0x5OGdjWFZoYm5ScGRIa3VZWE5WYVc1ME5qUW9LU3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qSTNOd29nSUNBZ0x5OGdkVzVwZEdGeWVWQnlhV05sTG1GelZXbHVkRFkwS0Nrc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU56Z0tJQ0FnSUM4dklHRnpjMlYwTG1SbFkybHRZV3h6TEFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZVzF2ZFc1MFRtOTBVMk5oYkdWa1NHbG5hQ3dnWVcxdmRXNTBUbTkwVTJOaGJHVmtURzkzWFNBOUlHOXdMbTExYkhjb2NISnBZMlVzSUhGMVlXNTBhWFI1S1RzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2JYVnNkd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHTnZibk4wSUZ0elkyRnNhVzVuUm1GamRHOXlTR2xuYUN3Z2MyTmhiR2x1WjBaaFkzUnZja3h2ZDEwZ1BTQnZjQzVsZUhCM0tERXdMQ0JoYzNObGRFUmxZMmx0WVd4ektUc0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzJNaTAyTndvZ0lDQWdMeThnYjNBdVpHbDJiVzlrZHlnS0lDQWdJQzh2SUNBZ1lXMXZkVzUwVG05MFUyTmhiR1ZrU0dsbmFDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MFRtOTBVMk5oYkdWa1RHOTNMQW9nSUNBZ0x5OGdJQ0J6WTJGc2FXNW5SbUZqZEc5eVNHbG5hQ3dLSUNBZ0lDOHZJQ0FnYzJOaGJHbHVaMFpoWTNSdmNreHZkeXdLSUNBZ0lDOHZJQ2s3Q2lBZ0lDQmthWFp0YjJSM0NpQWdJQ0J3YjNCdUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCaGMzTmxjblFvWDNGMWIzUnBaVzUwU0dsbmFDQTlQVDBnTUNrN0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakk0TVFvZ0lDQWdMeThnWVhOelpYSjBLR0pwWkZCaGVTNXpaVzVrWlhJZ1BUMDlJRlI0Ymk1elpXNWtaWElwT3dvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENoaWFXUlFZWGt1Y21WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56S1RzS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmJXRnlhMlYwY0d4aFkyVXZiV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem95T0RNS0lDQWdJQzh2SUdGemMyVnlkQ2hpYVdSUVlYa3VZVzF2ZFc1MElEMDlQU0JoYlc5MWJuUlViMEpsUW1sa0tUc0tJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TWpnMkNpQWdJQ0F2THlCa1pYQnZjMmwwWldRNklHeHBjM1JwYm1jdVpHVndiM05wZEdWa0xBb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakk0TndvZ0lDQWdMeThnZFc1cGRHRnllVkJ5YVdObE9pQnNhWE4wYVc1bkxuVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU9EZ0tJQ0FnSUM4dklHSnBaR1JsY2pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakk0TlMweU9URUtJQ0FnSUM4dklIUm9hWE11YkdsemRHbHVaM01vYTJWNUtTNTJZV3gxWlNBOUlHNWxkeUJNYVhOMGFXNW5WbUZzZFdVb2V3b2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsMFpXUTZJR3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtMQW9nSUNBZ0x5OGdJQ0IxYm1sMFlYSjVVSEpwWTJVNklHeHBjM1JwYm1jdWRXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0JpYVdSa1pYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUdKcFpEb2djWFZoYm5ScGRIa3NDaUFnSUNBdkx5QWdJR0pwWkZWdWFYUmhjbmxRY21salpUb2dkVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3lORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T2tScFoybDBZV3hOWVhKclpYUndiR0ZqWlM1aFkyTmxjSFJDYVdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZMk5sY0hSQ2FXUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU9UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakk1TndvZ0lDQWdMeThnYjNkdVpYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU9UWXRNekF3Q2lBZ0lDQXZMeUJqYjI1emRDQnJaWGtnUFNCdVpYY2dUR2x6ZEdsdVowdGxlU2g3Q2lBZ0lDQXZMeUFnSUc5M2JtVnlPaUJ1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRG9nYm1WM0lHRnlZelF1VldsdWREWTBLR0Z6YzJWMExtbGtLU3dLSUNBZ0lDOHZJQ0FnYm05dVkyVXNDaUFnSUNBdkx5QjlLVHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QnNhWE4wYVc1bmN5QTlJRUp2ZUUxaGNEeE1hWE4wYVc1blMyVjVMQ0JNYVhOMGFXNW5WbUZzZFdVK0tIc2dhMlY1VUhKbFptbDRPaUFpYkdsemRHbHVaM01pSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJHbHpkR2x1WjNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpBeUNpQWdJQ0F2THlCamIyNXpkQ0JzYVhOMGFXNW5JRDBnWTJ4dmJtVW9kR2hwY3k1c2FYTjBhVzVuY3loclpYa3BMblpoYkhWbEtUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNekF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9iR2x6ZEdsdVp5NWlhV1JrWlhJZ0lUMDlJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9LU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qTXdOZ29nSUNBZ0x5OGdiR2x6ZEdsdVp5NWtaWEJ2YzJsMFpXUXVZWE5WYVc1ME5qUW9LU0E4SUd4cGMzUnBibWN1WW1sa0xtRnpWV2x1ZERZMEtDa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBME9DQXZMeUEwT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnUEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDIxaGNtdGxkSEJzWVdObEwyMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNekEyTFRNd09Bb2dJQ0FnTHk4Z2JHbHpkR2x1Wnk1a1pYQnZjMmwwWldRdVlYTlZhVzUwTmpRb0tTQThJR3hwYzNScGJtY3VZbWxrTG1GelZXbHVkRFkwS0NrS0lDQWdJQzh2SUNBZ1B5QnNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDNWhjMVZwYm5RMk5DZ3BDaUFnSUNBdkx5QWdJRG9nYkdsemRHbHVaeTVpYVdRdVlYTlZhVzUwTmpRb0tUc0tJQ0FnSUdKNklHRmpZMlZ3ZEVKcFpGOTBaWEp1WVhKNVgyWmhiSE5sUURNS0lDQWdJR1JwWnlBeENncGhZMk5sY0hSQ2FXUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpFeUNpQWdJQ0F2THlCc2FYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaUzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTFOaUE0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTFOaUF2THlBMU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXRZWEpyWlhSd2JHRmpaUzl0WVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pNeE13b2dJQ0FnTHk4Z1lYTnpaWFF1WkdWamFXMWhiSE1zQ2lBZ0lDQmthV2NnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZVzF2ZFc1MFRtOTBVMk5oYkdWa1NHbG5hQ3dnWVcxdmRXNTBUbTkwVTJOaGJHVmtURzkzWFNBOUlHOXdMbTExYkhjb2NISnBZMlVzSUhGMVlXNTBhWFI1S1RzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnRkV3gzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czTmpZV3hwYm1kR1lXTjBiM0pJYVdkb0xDQnpZMkZzYVc1blJtRmpkRzl5VEc5M1hTQTlJRzl3TG1WNGNIY29NVEFzSUdGemMyVjBSR1ZqYVcxaGJITXBPd29nSUNBZ2FXNTBZMTh5SUM4dklERXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0Y0hjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPall5TFRZM0NpQWdJQ0F2THlCdmNDNWthWFp0YjJSM0tBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5ST2IzUlRZMkZzWldSSWFXZG9MQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUk9iM1JUWTJGc1pXUk1iM2NzQ2lBZ0lDQXZMeUFnSUhOallXeHBibWRHWVdOMGIzSklhV2RvTEFvZ0lDQWdMeThnSUNCelkyRnNhVzVuUm1GamRHOXlURzkzTEFvZ0lDQWdMeThnS1RzS0lDQWdJR1JwZG0xdlpIY0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoZmNYVnZkR2xsYm5SSWFXZG9JRDA5UFNBd0tUc0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyMWhjbXRsZEhCc1lXTmxMMjFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpFMkNpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3Z1lXMXZkVzUwT2lCaVpYTjBRbWxrUVcxdmRXNTBJSDBwTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvek1UZ3RNekkwQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHeHBjM1JwYm1jdVltbGtaR1Z5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2diV2x1VVhWaGJuUnBkSGtzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3pNVGd0TXpJekNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR3hwYzNScGJtY3VZbWxrWkdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nYldsdVVYVmhiblJwZEhrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YldGeWEyVjBjR3hoWTJVdmJXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3pNVGd0TXpJMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR3hwYzNScGJtY3VZbWxrWkdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nYldsdVVYVmhiblJwZEhrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvek1qa0tJQ0FnSUM4dklIVnVhWFJoY25sUWNtbGpaVG9nYkdsemRHbHVaeTUxYm1sMFlYSjVVSEpwWTJVc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZiV0Z5YTJWMGNHeGhZMlV2YldGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvek16QUtJQ0FnSUM4dklHUmxjRzl6YVhSbFpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtHeHBjM1JwYm1jdVpHVndiM05wZEdWa0xtRnpWV2x1ZERZMEtDa2dMU0J0YVc1UmRXRnVkR2wwZVNrc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5dFlYSnJaWFJ3YkdGalpTOXRZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPak16TVFvZ0lDQWdMeThnWW1sa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb2JHbHpkR2x1Wnk1aWFXUXVZWE5WYVc1ME5qUW9LU0F0SUcxcGJsRjFZVzUwYVhSNUtTd0tJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl0WVhKclpYUndiR0ZqWlM5dFlYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qTXlOaTB6TXpJS0lDQWdJQzh2SUhSb2FYTXViR2x6ZEdsdVozTW9hMlY1S1M1MllXeDFaU0E5SUc1bGR5Qk1hWE4wYVc1blZtRnNkV1VvZXdvZ0lDQWdMeThnSUNCaWFXUmtaWEk2SUd4cGMzUnBibWN1WW1sa1pHVnlMQW9nSUNBZ0x5OGdJQ0JpYVdSVmJtbDBZWEo1VUhKcFkyVTZJR3hwYzNScGJtY3VZbWxrVlc1cGRHRnllVkJ5YVdObExBb2dJQ0FnTHk4Z0lDQjFibWwwWVhKNVVISnBZMlU2SUd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsMFpXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DaHNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDNWhjMVZwYm5RMk5DZ3BJQzBnYldsdVVYVmhiblJwZEhrcExBb2dJQ0FnTHk4Z0lDQmlhV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2hzYVhOMGFXNW5MbUpwWkM1aGMxVnBiblEyTkNncElDMGdiV2x1VVhWaGJuUnBkSGtwTEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMjFoY210bGRIQnNZV05sTDIxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qazBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZV05qWlhCMFFtbGtYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUdSMWNBb2dJQ0FnWWlCaFkyTmxjSFJDYVdSZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFRQUtCTVNLQXlZRENHeHBjM1JwYm1keklBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBREJVZmZIVUFBQUFBQUFERlJERWJRUUJrTVJrVVJERVlSSUlMQkw1TE1lTUVvTXMya3dUWmp2YXBCR3BPZjhvRUV2Q01tQVNiUzRJMEJFMkxJOWdFVXF4ZDl3VGpyckpjQkRJMHR4RUV6SUpqUmpZYUFJNExBQVVBRVFBQkFEY0FjUUVIQVdFQmxnSWpBcHdEVmdBcXNDSkRLckFpUXpFWkZERVlGQkJETmhvQkZ6WWFBaGMyR2dNWFRFOENIU1JQQTVVZlJnSk1GRVFXZ0FRVkgzeDFURkN3SWtNeEZpSUpTVGdRSWhKRU5ob0JGeklLU3dGd0FFVUJGRVJMQVRnSE1nb1NSRXc0Q0RJUUVrU3hNZ29qc2hLeUZMSVJKYklRSTdJQnN5SkRNUmFCQWdsSk9CQWlFa1F4RmlJSlNUZ1FKUkpFTmhvQk5ob0NTd000QURFQUVrUkxBemdITWdvU1JFOERPQWdoQkJKRU1RQkxBemdSRmxCTVVDaE1VRW05UlFFVVJFc0NPQUF4QUJKRVN3STRGRElLRWtSUEFqZ1NTVVFXVHdKUWdEQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJRdnlKRE1SWWlDVWs0RUNVU1JEWWFBVEVBU3dJNEVSWlFURkJMQVRnQU1RQVNSRXNCT0JReUNoSkVURGdTU1VRb1R3SlFTYjVFU1Zjd0NFc0JWemdJU3dKWEVDQkxBMWNJQ0U4RUkxdFBCZ2dXVEZCTVVFOENVRXhRdnlKRE5ob0NOaG9ETVFBMkdnRlFUd0pRS0V4UVNiNUVTVmN3Q0VzQlZ6Z0lTd0pYRUNCUEExY0FDRThGVUV4UVR3SlFURkMvSWtNMkdnRTJHZ0pKRnpZYUF6RVdJZ2xKT0JBaUVrUTJHZ1FYU3dWUEJWQlBBMUFvVEZCSnZrUkpWd2dJU3dHQkNGdExCbkVCUkV4TEJSMGtUd09WSDBZQ1RCUkVTd1U0QURFQUVrUkxCVGdIVHdnU1JFOEZPQWdTUkVzQlZ6QUlTd0pYT0FoTEExY1FJRThFSTF0TEJna1dUd1JRVEZCUEFsQk1VTCt4TVFDeUZMSVNzaEVsc2hBanNnR3pJa00yR2dGSkYwdzJHZ0l4QUU4Q1VFeFFLRXhRU2I1TVNVOENSRmNRSUVrcEUwRUFLa3NCU1lFd1cweUJPRnRMQlhFQlJFeFBBaDBrVHdPVkgwWUNUQlJFc2JJSVNiSUhJcklRSTdJQnMwc0N2RWl4TVFBaEJMSUlzZ2Npc2hBanNnR3pzVEVBU3dJalc3SVNzaFJMQTdJUkpiSVFJN0lCc3lKRE5ob0JOaG9DU1JkT0FqWWFBekVXSWdsSlRnUTRFQ0lTUkRZYUJFNEROaG9GVGdOT0FsQk1VQ2hNVUVtK1RFbFBBa1JYRUNCSktSTkJBRE5MQXhkTEFrbE9Bb0U0VzB4TEFRMUVUSUV3VzBzSWNRRkVUZ0lkSkU4RGxSOUdBa3dVUkxHeUNFbXlCeUt5RUNPeUFiTkxCRWtYU3dWSlRnTVhTd3B4QVVSTVR3SWRKRThEbFI5R0Frd1VSRXNJU1RnQU1RQVNSRWs0QnpJS0VrUTRDQkpFU3dOSlZ3QUlURmNJQ0RFQVRnSlFURkJNVUV4UVN3Tk12eUpETmhvQlNSZE1OaG9DTVFCUEFsQk1VQ2hNVUVtK1RFbFBBa1JKVnhBZ1NVNENLUk5FU1NOYlNVOENnVEJiU1U0Q0RFRUFiRXNCU3dSSlZ6Z0lTd0dCT0Z0TENVbE9BbkVCUkV4UEJVbE9BeDBrVHdPVkgwWUNUQlJFc1RFQXNnZXlDQ0t5RUNPeUFiT3hTYklTU3daSlRnS3lGRThDc2hFbHNoQWpzZ0d6VHdOWENBaExCVXNDQ1JaTEJVOERDUlpNVHdKUVR3SlFURkJNVUVzRlRMOGlRMGxDLzVJPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
