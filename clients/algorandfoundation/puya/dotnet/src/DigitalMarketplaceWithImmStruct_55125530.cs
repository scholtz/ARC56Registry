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

namespace Arc56.Generated.algorandfoundation.puya.DigitalMarketplaceWithImmStruct_55125530
{


    public class DigitalMarketplaceWithImmStructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DigitalMarketplaceWithImmStructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="mbr_pay"> </param>
        /// <param name="asset"> </param>
        public async Task AllowAsset(PaymentTransaction mbr_pay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 106, 78, 127, 202 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, mbr_pay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AllowAsset_Transactions(PaymentTransaction mbr_pay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 106, 78, 127, 202 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_pay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbr_pay"> </param>
        /// <param name="xfer"> </param>
        /// <param name="unitary_price"> </param>
        /// <param name="nonce"> </param>
        public async Task FirstDeposit(PaymentTransaction mbr_pay, AssetTransferTransaction xfer, ulong unitary_price, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay, xfer });
            byte[] abiHandle = { 18, 240, 140, 152 };
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            var result = await base.CallApp(new List<object> { abiHandle, mbr_pay, xfer, unitary_priceAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FirstDeposit_Transactions(PaymentTransaction mbr_pay, AssetTransferTransaction xfer, ulong unitary_price, ulong nonce, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay, xfer });
            byte[] abiHandle = { 18, 240, 140, 152 };
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_pay, xfer, unitary_priceAbi, nonceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        /// <param name="unitary_price"> </param>
        public async Task SetPrice(ulong asset, ulong nonce, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 139, 35, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, nonceAbi, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPrice_Transactions(ulong asset, ulong nonce, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 139, 35, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, nonceAbi, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="asset"> </param>
        /// <param name="nonce"> </param>
        /// <param name="buy_pay"> </param>
        /// <param name="quantity"> </param>
        public async Task Buy(PaymentTransaction buy_pay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buy_pay });
            byte[] abiHandle = { 82, 172, 93, 247 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, buy_pay, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Buy_Transactions(PaymentTransaction buy_pay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buy_pay });
            byte[] abiHandle = { 82, 172, 93, 247 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, buy_pay, quantityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        /// <param name="bid_pay"> </param>
        /// <param name="quantity"> </param>
        /// <param name="unitary_price"> </param>
        public async Task Bid(PaymentTransaction bid_pay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { bid_pay });
            byte[] abiHandle = { 50, 52, 183, 17 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, bid_pay, quantityAbi, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(PaymentTransaction bid_pay, Algorand.Address owner, ulong asset, ulong nonce, ulong quantity, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { bid_pay });
            byte[] abiHandle = { 50, 52, 183, 17 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nonceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nonceAbi.From(nonce);
            var quantityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quantityAbi.From(quantity);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, assetAbi, nonceAbi, bid_pay, quantityAbi, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbE1hcmtldHBsYWNlV2l0aEltbVN0cnVjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMaXN0aW5nS2V5IjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiTGlzdGluZ1ZhbHVlIjpbeyJuYW1lIjoiZGVwb3NpdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InVuaXRhcnlQcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWRkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWRVbml0YXJ5UHJpY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldExpc3RpbmdzTWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGxvd0Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpcnN0RGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXlfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWRfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdGFyeV9wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRCaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTczLDcyOCw5MTQsOTQ3LDEwOTldLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODcsNDY5LDU2NSw3MDIsODgyLDEwNTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxpc3RpbmdzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMSw4MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4LDIzMiwyNDEsMzQ3LDQzNCw0NDMsNDUyLDUxOSw1MjgsNTQ3LDY3Miw2ODIsODE0LDgyNiw4NDcsODU4LDEwMjMsMTAzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwzMzldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwLDIxNCw1MzksODM5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURnZ01DQTBJRFV3TlRBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5tTTJPVGN6TnpRMk9UWmxOamMzTXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNemtLSUNBZ0lDOHZJR3h2WnlnaWFXNXBkQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWx1YVhRaUNpQWdJQ0JzYjJjS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNemNLSUNBZ0lDOHZJR05zWVhOeklFUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpWZHBkR2hKYlcxVGRISjFZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UZ0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHUTVPR1ZtTm1FNUlEQjRObUUwWlRkbVkyRWdNSGd4TW1Zd09HTTVPQ0F3ZURsaU5HSTRNak0wSURCNE5HUTRZakl6WkRnZ01IZzFNbUZqTldSbU55QXdlR1V6WVdWaU1qVmpJREI0TXpJek5HSTNNVEVnTUhoall6Z3lOak0wTmlBdkx5QnRaWFJvYjJRZ0ltZGxkRXhwYzNScGJtZHpUV0p5S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Gc2JHOTNRWE56WlhRb2NHRjVMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbWFYSnpkRVJsY0c5emFYUW9jR0Y1TEdGNFptVnlMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWd2IzTnBkQ2hoZUdabGNpeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFVISnBZMlVvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWW5WNUtHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3h3WVhrc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWW1sa0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3h3WVhrc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhZMk5sY0hSQ2FXUW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOW5aWFJNYVhOMGFXNW5jMDFpY2w5eWIzVjBaVUEySUdGc2JHOTNYMkZ6YzJWMElHWnBjbk4wWDJSbGNHOXphWFFnWkdWd2IzTnBkQ0J6WlhSZmNISnBZMlVnWW5WNUlIZHBkR2hrY21GM0lHSnBaQ0JoWTJObGNIUmZZbWxrQ2lBZ0lDQmxjbklLQ20xaGFXNWZaMlYwVEdsemRHbHVaM05OWW5KZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2dibUZ0WlQwaVoyVjBUR2x6ZEdsdVozTk5ZbklpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURCak5UUTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRnNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk1dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1UkdsbmFYUmhiRTFoY210bGRIQnNZV05sVjJsMGFFbHRiVk4wY25WamRDNWhiR3h2ZDE5aGMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Gc2JHOTNYMkZ6YzJWME9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk9ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNodVlXMWxQU0poYkd4dmQwRnpjMlYwSWlrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1cGMxOXZjSFJsWkY5cGJpaGhjM05sZENrS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFluSmZjR0Y1TG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZzNDaUFnSUNBdkx5QmhjM05sY25RZ2JXSnlYM0JoZVM1aGJXOTFiblFnUFQwZ1IyeHZZbUZzTG1GemMyVjBYMjl3ZEY5cGJsOXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCbmJHOWlZV3dnUVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pnNUxUa3hDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dZWE56WlhSZllXMXZkVzUwUFRBS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamt3Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQmhjM05sZEY5aGJXOTFiblE5TUFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG80T1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eklDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamc1TFRreENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd2dZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z1lYTnpaWFJmWVcxdmRXNTBQVEFLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW1Gc2JHOTNRWE56WlhRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk1dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1UkdsbmFYUmhiRTFoY210bGRIQnNZV05sVjJsMGFFbHRiVk4wY25WamRDNW1hWEp6ZEY5a1pYQnZjMmwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ptbHljM1JmWkdWd2IzTnBkRG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaVptbHljM1JFWlhCdmMybDBJaWtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV3TVFvZ0lDQWdMeThnWVhOelpYSjBJRzFpY2w5d1lYa3VjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWkdsbklETUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5WDNCaGVTNWhiVzkxYm5RZ1BUMGdjMlZzWmk1c2FYTjBhVzVuYzE5aWIzaGZiV0p5S0NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzBOQzAyTlFvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0F5WHpVd01Bb2dJQ0FnTHk4Z0lDQWdJQ3NLSUNBZ0lDOHZJQ0FnSUNBaklHWnRkRG9nYjJabUNpQWdJQ0F2THlBZ0lDQWdJeUJMWlhrZ2JHVnVaM1JvQ2lBZ0lDQXZMeUFnSUNBZ0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBNENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ016SUtJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t5QTRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dPQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDTWdWbUZzZFdVZ2JHVnVaM1JvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJRGdLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLeUE0Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NnTXpJS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS3lBNENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ09Bb2dJQ0FnTHk4Z0lDQWdJQ2tLSUNBZ0lDOHZJQ0FnSUNBcUNpQWdJQ0F2THlBZ0lDQWdJeUJtYlhRNklHOXVDaUFnSUNBdkx5QWdJQ0FnTkRBd0NpQWdJQ0F2THlBcENpQWdJQ0JwYm5SaklEUWdMeThnTlRBMU1EQUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdVlXMXZkVzUwSUQwOUlITmxiR1l1YkdsemRHbHVaM05mWW05NFgyMWljaWdwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TURVS0lDQWdJQzh2SUd0bGVTQTlJRXhwYzNScGJtZExaWGtvYjNkdVpYSTlWSGh1TG5ObGJtUmxjaXdnWVhOelpYUTllR1psY2k1NFptVnlYMkZ6YzJWMExtbGtMQ0J1YjI1alpUMXViMjVqWlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnJaWGtnYm05MElHbHVJSE5sYkdZdWJHbHpkR2x1WjNNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV3T1FvZ0lDQWdMeThnWVhOelpYSjBJSGhtWlhJdVlYTnpaWFJmY21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0I0Wm1WeUxtRnpjMlYwWDJGdGIzVnVkQ0ErSURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHSnBaR1JsY2oxQlkyTnZkVzUwS0Nrc0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV4TWkweE1UZ0tJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTQTlJRXhwYzNScGJtZFdZV3gxWlNnS0lDQWdJQzh2SUNBZ0lDQmtaWEJ2YzJsMFpXUTllR1psY2k1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRHRnllVkJ5YVdObFBYVnVhWFJoY25sZmNISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtaR1Z5UFVGalkyOTFiblFvS1N3S0lDQWdJQzh2SUNBZ0lDQmlhV1E5VlVsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFZWSmJuUTJOQ2dwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRFMkNpQWdJQ0F2THlCaWFXUTlWVWx1ZERZMEtDa3NDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1URXlMVEV4T0FvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkSUQwZ1RHbHpkR2x1WjFaaGJIVmxLQW9nSUNBZ0x5OGdJQ0FnSUdSbGNHOXphWFJsWkQxNFptVnlMbUZ6YzJWMFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWVhKNVVISnBZMlU5ZFc1cGRHRnllVjl3Y21salpTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSTlRV05qYjNWdWRDZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpEMVZTVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSVmJtbDBZWEo1VUhKcFkyVTlWVWx1ZERZMEtDa3NDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWm1seWMzUkVaWEJ2YzJsMElpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMWhjbXRsZEhCc1lXTmxYMlJsYlc4dWJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTGtScFoybDBZV3hOWVhKclpYUndiR0ZqWlZkcGRHaEpiVzFUZEhKMVkzUXVaR1Z3YjNOcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsY0c5emFYUTZDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJyWlhrZ1BTQk1hWE4wYVc1blMyVjVLRzkzYm1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFBYaG1aWEl1ZUdabGNsOWhjM05sZEM1cFpDd2dibTl1WTJVOWJtOXVZMlVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNZ29nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1USTBDaUFnSUNBdkx5QmhjM05sY25RZ2VHWmxjaTV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdlR1psY2k1aGMzTmxkRjl5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV5TmdvZ0lDQWdMeThnWVhOelpYSjBJSGhtWlhJdVlYTnpaWFJmWVcxdmRXNTBJRDRnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJR1Y0YVhOMGFXNW5JRDBnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Tm1NMk9UY3pOelEyT1RabE5qYzNNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR2x6ZEdsdVozTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TXpBS0lDQWdJQzh2SUdKcFpEMWxlR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05EZ2dPQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJpYVdSVmJtbDBZWEo1VUhKcFkyVTlaWGhwYzNScGJtY3VZbWxrVlc1cGRHRnllVkJ5YVdObExBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTlRZZ09Bb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QmlhV1JrWlhJOVpYaHBjM1JwYm1jdVltbGtaR1Z5TEFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTXpJS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z2RXNXBkR0Z5ZVZCeWFXTmxQV1Y0YVhOMGFXNW5MblZ1YVhSaGNubFFjbWxqWlN3S0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRGdnT0FvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRNMENpQWdJQ0F2THlCa1pYQnZjMmwwWldROVpYaHBjM1JwYm1jdVpHVndiM05wZEdWa0lDc2dlR1psY2k1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1qa3RNVE0xQ2lBZ0lDQXZMeUJ6Wld4bUxteHBjM1JwYm1kelcydGxlVjBnUFNCTWFYTjBhVzVuVm1Gc2RXVW9DaUFnSUNBdkx5QWdJQ0FnWW1sa1BXVjRhWE4wYVc1bkxtSnBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaWFXUlZibWwwWVhKNVVISnBZMlU5WlhocGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpHUmxjajFsZUdsemRHbHVaeTVpYVdSa1pYSXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRHRnllVkJ5YVdObFBXVjRhWE4wYVc1bkxuVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCa1pYQnZjMmwwWldROVpYaHBjM1JwYm1jdVpHVndiM05wZEdWa0lDc2dlR1psY2k1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xaGNtdGxkSEJzWVdObFgyUmxiVzh1YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaVmRwZEdoSmJXMVRkSEoxWTNRdWMyVjBYM0J5YVdObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNCeWFXTmxPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaWMyVjBVSEpwWTJVaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QnJaWGtnUFNCTWFYTjBhVzVuUzJWNUtHOTNibVZ5UFZSNGJpNXpaVzVrWlhJc0lHRnpjMlYwUFdGemMyVjBMbWxrTENCdWIyNWpaVDF1YjI1alpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVFF4Q2lBZ0lDQXZMeUJsZUdsemRHbHVaeUE5SUhObGJHWXViR2x6ZEdsdVozTmJhMlY1WFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak5qazNNemMwTmprMlpUWTNOek1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2FYTjBhVzVuY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdZbWxrUFdWNGFYTjBhVzVuTG1KcFpDd0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwT0NBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE5EUUtJQ0FnSUM4dklHSnBaRlZ1YVhSaGNubFFjbWxqWlQxbGVHbHpkR2x1Wnk1aWFXUlZibWwwWVhKNVVISnBZMlVzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTFOaUE0Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TkRVS0lDQWdJQzh2SUdKcFpHUmxjajFsZUdsemRHbHVaeTVpYVdSa1pYSXNDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVFEyQ2lBZ0lDQXZMeUJrWlhCdmMybDBaV1E5WlhocGMzUnBibWN1WkdWd2IzTnBkR1ZrTEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UUXlMVEUwT0FvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkSUQwZ1RHbHpkR2x1WjFaaGJIVmxLQW9nSUNBZ0x5OGdJQ0FnSUdKcFpEMWxlR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFdWNGFYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCaWFXUmtaWEk5WlhocGMzUnBibWN1WW1sa1pHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdSbGNHOXphWFJsWkQxbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEdGeWVWQnlhV05sUFhWdWFYUmhjbmxmY0hKcFkyVXNDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TXpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBTSnpaWFJRY21salpTSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRZWEpyWlhSd2JHRmpaVjlrWlcxdkxtMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1RWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJWWGFYUm9TVzF0VTNSeWRXTjBMbUoxZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSjFlVG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUxT1FvZ0lDQWdMeThnYTJWNUlEMGdUR2x6ZEdsdVowdGxlU2h2ZDI1bGNqMXZkMjVsY2l3Z1lYTnpaWFE5WVhOelpYUXVhV1FzSUc1dmJtTmxQVzV2Ym1ObEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOakVLSUNBZ0lDOHZJR3hwYzNScGJtY2dQU0J6Wld4bUxteHBjM1JwYm1kelcydGxlVjBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyWXpZNU56TTNORFk1Tm1VMk56Y3pDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YkdsemRHbHVaM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE5qTUtJQ0FnSUM4dklHRnRiM1Z1ZEY5MGIxOWlaVjl3WVdsa0lEMGdjMlZzWmk1eGRXRnVkR2wwZVY5d2NtbGpaU2h4ZFdGdWRHbDBlU3dnYkdsemRHbHVaeTUxYm1sMFlYSjVVSEpwWTJVc0lHRnpjMlYwTG1SbFkybHRZV3h6S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalk1Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibTkwWDNOallXeGxaRjlvYVdkb0xDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOXNiM2NnUFNCdmNDNXRkV3gzS0hCeWFXTmxMQ0J4ZFdGdWRHbDBlU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdiWFZzZHdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpBS0lDQWdJQzh2SUhOallXeHBibWRmWm1GamRHOXlYMmhwWjJnc0lITmpZV3hwYm1kZlptRmpkRzl5WDJ4dmR5QTlJRzl3TG1WNGNIY29NVEFzSUdGemMyVjBYMlJsWTJsdFlXeHpLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG8zTVMwM013b2dJQ0FnTHk4Z1gzRjFiM1JwWlc1MFgyaHBaMmdzSUdGdGIzVnVkRjkwYjE5aVpWOXdZV2xrTENCZmNtVnRZV2x1WkdWeVgyaHBaMmdzSUY5eVpXMWhhVzVrWlhKZmJHOTNJRDBnYjNBdVpHbDJiVzlrZHlnS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOW9hV2RvTENCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5c2IzY3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyaHBaMmdzSUhOallXeHBibWRmWm1GamRHOXlYMnh2ZHdvZ0lDQWdMeThnS1FvZ0lDQWdaR2wyYlc5a2R3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCemQyRndDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdZWE56WlhKMElGOXhkVzkwYVdWdWRGOW9hV2RvSUQwOUlEQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QmhjM05sY25RZ1luVjVYM0JoZVM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWkdsbklEVUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCaGMzTmxjblFnWW5WNVgzQmhlUzV5WldObGFYWmxjaUE5UFNCdmQyNWxjZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdZWE56WlhKMElHSjFlVjl3WVhrdVlXMXZkVzUwSUQwOUlHRnRiM1Z1ZEY5MGIxOWlaVjl3WVdsa0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGN3Q2lBZ0lDQXZMeUJpYVdROWJHbHpkR2x1Wnk1aWFXUXNDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBME9DQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOekVLSUNBZ0lDOHZJR0pwWkZWdWFYUmhjbmxRY21salpUMXNhWE4wYVc1bkxtSnBaRlZ1YVhSaGNubFFjbWxqWlN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFUySURnS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFM01nb2dJQ0FnTHk4Z1ltbGtaR1Z5UFd4cGMzUnBibWN1WW1sa1pHVnlMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01UWWdNeklLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUzTkFvZ0lDQWdMeThnWkdWd2IzTnBkR1ZrUFd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUMwZ2NYVmhiblJwZEhrc0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lDMEtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTJPUzB4TnpVS0lDQWdJQzh2SUhObGJHWXViR2x6ZEdsdVozTmJhMlY1WFNBOUlFeHBjM1JwYm1kV1lXeDFaU2dLSUNBZ0lDOHZJQ0FnSUNCaWFXUTliR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpHUmxjajFzYVhOMGFXNW5MbUpwWkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFlYSjVVSEpwWTJVOWJHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWkdWd2IzTnBkR1ZrUFd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUMwZ2NYVmhiblJwZEhrc0NpQWdJQ0F2THlBcENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOemN0TVRjNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd2dZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd2dZWE56WlhSZllXMXZkVzUwUFhGMVlXNTBhWFI1Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFgyRnRiM1Z1ZEQxeGRXRnVkR2wwZVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGMzQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGMzTFRFM09Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFgyRnRiM1Z1ZEQxeGRXRnVkR2wwZVFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRZWEpyWlhSd2JHRmpaVjlrWlcxdkxtMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1RWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJWWGFYUm9TVzF0VTNSeWRXTjBMbmRwZEdoa2NtRjNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE9ETUtJQ0FnSUM4dklHdGxlU0E5SUV4cGMzUnBibWRMWlhrb2IzZHVaWEk5VkhodUxuTmxibVJsY2l3Z1lYTnpaWFE5WVhOelpYUXVhV1FzSUc1dmJtTmxQVzV2Ym1ObEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRnMUNpQWdJQ0F2THlCc2FYTjBhVzVuSUQwZ2MyVnNaaTVzYVhOMGFXNW5jMXRyWlhsZENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5tTTJPVGN6TnpRMk9UWmxOamMzTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYVhOMGFXNW5jeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFNE5nb2dJQ0FnTHk4Z2FXWWdiR2x6ZEdsdVp5NWlhV1JrWlhJZ0lUMGdRV05qYjNWdWRDZ3BPZ29nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JpZWlCM2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakU0T0FvZ0lDQWdMeThnYkdsemRHbHVaeTVpYVdRc0lHeHBjM1JwYm1jdVltbGtWVzVwZEdGeWVWQnlhV05sTENCaGMzTmxkQzVrWldOcGJXRnNjd29nSUNBZ1pIVndiaUF5Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBMU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QTBDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0JsZUdsemRITUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qWTVDaUFnSUNBdkx5QmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOW9hV2RvTENCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5c2IzY2dQU0J2Y0M1dGRXeDNLSEJ5YVdObExDQnhkV0Z1ZEdsMGVTa0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiWFZzZHdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpBS0lDQWdJQzh2SUhOallXeHBibWRmWm1GamRHOXlYMmhwWjJnc0lITmpZV3hwYm1kZlptRmpkRzl5WDJ4dmR5QTlJRzl3TG1WNGNIY29NVEFzSUdGemMyVjBYMlJsWTJsdFlXeHpLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG8zTVMwM013b2dJQ0FnTHk4Z1gzRjFiM1JwWlc1MFgyaHBaMmdzSUdGdGIzVnVkRjkwYjE5aVpWOXdZV2xrTENCZmNtVnRZV2x1WkdWeVgyaHBaMmdzSUY5eVpXMWhhVzVrWlhKZmJHOTNJRDBnYjNBdVpHbDJiVzlrZHlnS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOW9hV2RvTENCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5c2IzY3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyaHBaMmdzSUhOallXeHBibWRmWm1GamRHOXlYMnh2ZHdvZ0lDQWdMeThnS1FvZ0lDQWdaR2wyYlc5a2R3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCemQyRndDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdZWE56WlhKMElGOXhkVzkwYVdWdWRGOW9hV2RvSUQwOUlEQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvY21WalpXbDJaWEk5YkdsemRHbHVaeTVpYVdSa1pYSXNJR0Z0YjNWdWREMWpkWEp5Wlc1MFgySnBaRjlrWlhCdmMybDBLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwM2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94T1RJS0lDQWdJQzh2SUdSbGJDQnpaV3htTG14cGMzUnBibWR6VzJ0bGVWMEtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGswQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd2dZVzF2ZFc1MFBYTmxiR1l1YkdsemRHbHVaM05mWW05NFgyMWljaWdwS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5EUXROalVLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdNbDgxTURBS0lDQWdJQzh2SUNBZ0lDQXJDaUFnSUNBdkx5QWdJQ0FnSXlCbWJYUTZJRzltWmdvZ0lDQWdMeThnSUNBZ0lDTWdTMlY1SUd4bGJtZDBhQW9nSUNBZ0x5OGdJQ0FnSUNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURNeUNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ09Bb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcklEZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t3b2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaklGWmhiSFZsSUd4bGJtZDBhQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQTRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dPQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJJRE15Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURnS0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QWdJQ0FnS2dvZ0lDQWdMeThnSUNBZ0lDTWdabTEwT2lCdmJnb2dJQ0FnTHk4Z0lDQWdJRFF3TUFvZ0lDQWdMeThnS1FvZ0lDQWdhVzUwWXlBMElDOHZJRFV3TlRBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1lXMXZkVzUwUFhObGJHWXViR2x6ZEdsdVozTmZZbTk0WDIxaWNpZ3BLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRrMkxURTVPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzSUdGemMyVjBYMkZ0YjNWdWREMXNhWE4wYVc1bkxtUmxjRzl6YVhSbFpBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTENCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjloYlc5MWJuUTliR2x6ZEdsdVp5NWtaWEJ2YzJsMFpXUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRrMkxURTVPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzSUdGemMyVjBYMkZ0YjNWdWREMXNhWE4wYVc1bkxtUmxjRzl6YVhSbFpBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0WVhKclpYUndiR0ZqWlY5a1pXMXZMbTFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNUVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVlhhWFJvU1cxdFUzUnlkV04wTG1KcFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUpwWkRvS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJd01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUJyWlhrZ1BTQk1hWE4wYVc1blMyVjVLRzkzYm1WeVBXOTNibVZ5TENCaGMzTmxkRDFoYzNObGRDNXBaQ3dnYm05dVkyVTlibTl1WTJVcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU1USUtJQ0FnSUM4dklHeHBjM1JwYm1jZ1BTQnpaV3htTG14cGMzUnBibWR6VzJ0bGVWMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZelk1TnpNM05EWTVObVUyTnpjekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHBjM1JwYm1keklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNakV6Q2lBZ0lDQXZMeUJwWmlCc2FYTjBhVzVuTG1KcFpHUmxjaUFoUFNCQlkyTnZkVzUwS0NrNkNpQWdJQ0JsZUhSeVlXTjBJREUySURNeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHSjZJR0pwWkY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakl4TkFvZ0lDQWdMeThnWVhOelpYSjBJSFZ1YVhSaGNubGZjSEpwWTJVZ1BpQnNhWE4wYVc1bkxtSnBaRlZ1YVhSaGNubFFjbWxqWlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJeE53b2dJQ0FnTHk4Z2JHbHpkR2x1Wnk1aWFXUXNJR3hwYzNScGJtY3VZbWxrVlc1cGRHRnllVkJ5YVdObExDQmhjM05sZEM1a1pXTnBiV0ZzY3dvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalk1Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibTkwWDNOallXeGxaRjlvYVdkb0xDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOXNiM2NnUFNCdmNDNXRkV3gzS0hCeWFXTmxMQ0J4ZFdGdWRHbDBlU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRzExYkhjS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjd0NpQWdJQ0F2THlCelkyRnNhVzVuWDJaaFkzUnZjbDlvYVdkb0xDQnpZMkZzYVc1blgyWmhZM1J2Y2w5c2IzY2dQU0J2Y0M1bGVIQjNLREV3TENCaGMzTmxkRjlrWldOcGJXRnNjeWtLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGh3ZHdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpFdE56TUtJQ0FnSUM4dklGOXhkVzkwYVdWdWRGOW9hV2RvTENCaGJXOTFiblJmZEc5ZlltVmZjR0ZwWkN3Z1gzSmxiV0ZwYm1SbGNsOW9hV2RvTENCZmNtVnRZV2x1WkdWeVgyeHZkeUE5SUc5d0xtUnBkbTF2Wkhjb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZhR2xuYUN3Z1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmJHOTNMQ0J6WTJGc2FXNW5YMlpoWTNSdmNsOW9hV2RvTENCelkyRnNhVzVuWDJaaFkzUnZjbDlzYjNjS0lDQWdJQzh2SUNrS0lDQWdJR1JwZG0xdlpIY0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmZjWFZ2ZEdsbGJuUmZhR2xuYUNBOVBTQXdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSXlNQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0hKbFkyVnBkbVZ5UFd4cGMzUnBibWN1WW1sa1pHVnlMQ0JoYlc5MWJuUTlZM1Z5Y21WdWRGOWlhV1JmWVcxdmRXNTBLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwaWFXUmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QmhiVzkxYm5SZmRHOWZZbVZmWW1sa0lEMGdjMlZzWmk1eGRXRnVkR2wwZVY5d2NtbGpaU2h4ZFdGdWRHbDBlU3dnZFc1cGRHRnllVjl3Y21salpTd2dZWE56WlhRdVpHVmphVzFoYkhNcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJFWldOcGJXRnNjd29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOamtLSUNBZ0lDOHZJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMmhwWjJnc0lHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyeHZkeUE5SUc5d0xtMTFiSGNvY0hKcFkyVXNJSEYxWVc1MGFYUjVLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYUdsbmFDd2djMk5oYkdsdVoxOW1ZV04wYjNKZmJHOTNJRDBnYjNBdVpYaHdkeWd4TUN3Z1lYTnpaWFJmWkdWamFXMWhiSE1wQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0Y0hjS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjeExUY3pDaUFnSUNBdkx5QmZjWFZ2ZEdsbGJuUmZhR2xuYUN3Z1lXMXZkVzUwWDNSdlgySmxYM0JoYVdRc0lGOXlaVzFoYVc1a1pYSmZhR2xuYUN3Z1gzSmxiV0ZwYm1SbGNsOXNiM2NnUFNCdmNDNWthWFp0YjJSM0tBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMmhwWjJnc0lHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyeHZkeXdnYzJOaGJHbHVaMTltWVdOMGIzSmZhR2xuYUN3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYkc5M0NpQWdJQ0F2THlBcENpQWdJQ0JrYVhadGIyUjNDaUFnSUNCd2IzQnVJRElLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdYM0YxYjNScFpXNTBYMmhwWjJnZ1BUMGdNQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlhV1JmY0dGNUxuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlhV1JmY0dGNUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNallLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlhV1JmY0dGNUxtRnRiM1Z1ZENBOVBTQmhiVzkxYm5SZmRHOWZZbVZmWW1sa0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1pHVndiM05wZEdWa1BXeHBjM1JwYm1jdVpHVndiM05wZEdWa0xBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJSFZ1YVhSaGNubFFjbWxqWlQxc2FYTjBhVzVuTG5WdWFYUmhjbmxRY21salpTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU16RUtJQ0FnSUM4dklHSnBaR1JsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TWpJNExUSXpOQW9nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRJRDBnVEdsemRHbHVaMVpoYkhWbEtBb2dJQ0FnTHk4Z0lDQWdJR1JsY0c5emFYUmxaRDFzYVhOMGFXNW5MbVJsY0c5emFYUmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBZWEo1VUhKcFkyVTliR2x6ZEdsdVp5NTFibWwwWVhKNVVISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtaR1Z5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZbWxrUFhGMVlXNTBhWFI1TEFvZ0lDQWdMeThnSUNBZ0lHSnBaRlZ1YVhSaGNubFFjbWxqWlQxMWJtbDBZWEo1WDNCeWFXTmxMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU1EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YldGeWEyVjBjR3hoWTJWZlpHVnRieTV0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxWMmwwYUVsdGJWTjBjblZqZEM1aFkyTmxjSFJmWW1sa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV05qWlhCMFgySnBaRG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakl6TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOUltRmpZMlZ3ZEVKcFpDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJek9Bb2dJQ0FnTHk4Z2EyVjVJRDBnVEdsemRHbHVaMHRsZVNodmQyNWxjajFVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRDFoYzNObGRDNXBaQ3dnYm05dVkyVTlibTl1WTJVcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TkRBS0lDQWdJQzh2SUd4cGMzUnBibWNnUFNCelpXeG1MbXhwYzNScGJtZHpXMnRsZVYwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUnBibWR6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qUXhDaUFnSUNBdkx5QmhjM05sY25RZ2JHbHpkR2x1Wnk1aWFXUmtaWElnSVQwZ1FXTmpiM1Z1ZENncENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TkRNS0lDQWdJQzh2SUcxcGJsOXhkV0Z1ZEdsMGVTQTlJR3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtJR2xtSUd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUR3Z2JHbHpkR2x1Wnk1aWFXUWdaV3h6WlNCc2FYTjBhVzVuTG1KcFpBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2NIVnphR2x1ZENBME9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1BBb2dJQ0FnWW5vZ1lXTmpaWEIwWDJKcFpGOTBaWEp1WVhKNVgyWmhiSE5sUURNS0lDQWdJR1JwWnlBeUNncGhZMk5sY0hSZlltbGtYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSTBOZ29nSUNBZ0x5OGdiV2x1WDNGMVlXNTBhWFI1TENCc2FYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaU3dnWVhOelpYUXVaR1ZqYVcxaGJITUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0ExTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjM05sZEY5d1lYSmhiWE5mWjJWMElFRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalk1Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibTkwWDNOallXeGxaRjlvYVdkb0xDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOXNiM2NnUFNCdmNDNXRkV3gzS0hCeWFXTmxMQ0J4ZFdGdWRHbDBlU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JYVnNkd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOekFLSUNBZ0lDOHZJSE5qWVd4cGJtZGZabUZqZEc5eVgyaHBaMmdzSUhOallXeHBibWRmWm1GamRHOXlYMnh2ZHlBOUlHOXdMbVY0Y0hjb01UQXNJR0Z6YzJWMFgyUmxZMmx0WVd4ektRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIQjNDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNNUzAzTXdvZ0lDQWdMeThnWDNGMWIzUnBaVzUwWDJocFoyZ3NJR0Z0YjNWdWRGOTBiMTlpWlY5d1lXbGtMQ0JmY21WdFlXbHVaR1Z5WDJocFoyZ3NJRjl5WlcxaGFXNWtaWEpmYkc5M0lEMGdiM0F1WkdsMmJXOWtkeWdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5b2FXZG9MQ0JoYlc5MWJuUmZibTkwWDNOallXeGxaRjlzYjNjc0lITmpZV3hwYm1kZlptRmpkRzl5WDJocFoyZ3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyeHZkd29nSUNBZ0x5OGdLUW9nSUNBZ1pHbDJiVzlrZHdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUY5eGRXOTBhV1Z1ZEY5b2FXZG9JRDA5SURBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TWpRNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9jbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdnWVcxdmRXNTBQV0psYzNSZlltbGtYMkZ0YjNWdWRDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU5URXRNalV6Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5YkdsemRHbHVaeTVpYVdSa1pYSXNJR0Z6YzJWMFgyRnRiM1Z1ZEQxdGFXNWZjWFZoYm5ScGRIa0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qVXhDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qVXhMVEkxTXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFd4cGMzUnBibWN1WW1sa1pHVnlMQ0JoYzNObGRGOWhiVzkxYm5ROWJXbHVYM0YxWVc1MGFYUjVDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qVTRDaUFnSUNBdkx5QjFibWwwWVhKNVVISnBZMlU5YkdsemRHbHVaeTUxYm1sMFlYSjVVSEpwWTJVc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lOVGtLSUNBZ0lDOHZJR1JsY0c5emFYUmxaRDFzYVhOMGFXNW5MbVJsY0c5emFYUmxaQ0F0SUcxcGJsOXhkV0Z1ZEdsMGVTd0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakkyTUFvZ0lDQWdMeThnWW1sa1BXeHBjM1JwYm1jdVltbGtJQzBnYldsdVgzRjFZVzUwYVhSNUxBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUMwS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJMU5TMHlOakVLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjNOYmEyVjVYU0E5SUV4cGMzUnBibWRXWVd4MVpTZ0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSTliR2x6ZEdsdVp5NWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZbWxrVlc1cGRHRnllVkJ5YVdObFBXeHBjM1JwYm1jdVltbGtWVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJoY25sUWNtbGpaVDFzYVhOMGFXNW5MblZ1YVhSaGNubFFjbWxqWlN3S0lDQWdJQzh2SUNBZ0lDQmtaWEJ2YzJsMFpXUTliR2x6ZEdsdVp5NWtaWEJ2YzJsMFpXUWdMU0J0YVc1ZmNYVmhiblJwZEhrc0NpQWdJQ0F2THlBZ0lDQWdZbWxrUFd4cGMzUnBibWN1WW1sa0lDMGdiV2x1WDNGMVlXNTBhWFI1TEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qTTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWVdOalpYQjBRbWxrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtRmpZMlZ3ZEY5aWFXUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnWkdsbklERUtJQ0FnSUdJZ1lXTmpaWEIwWDJKcFpGOTBaWEp1WVhKNVgyMWxjbWRsUURRSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBUWdBQk1TS0F5WUJDR3hwYzNScGJtZHpNUmhBQUFlQUJHbHVhWFN3TVJ0QkFGOHhHUlJFTVJoRWdna0UyWTcycVFScVRuL0tCQkx3akpnRW0wdUNOQVJOaXlQWUJGS3NYZmNFNDY2eVhBUXlOTGNSQk15Q1kwWTJHZ0NPQ1FBQkFCb0FXUURYQVRnQmhBSW1BcXNEaFFDQURCVWZmSFVBQUFBQUFBREZSTEFpUXpFWkZERVlGQkJETVJZaUNVazRFQ0lTUkRZYUFVa1ZJeEpFRnpJS1N3RndBRVVCRkVSTEFUZ0hNZ29TUkV3NENESVFFa1N4TWdva3NoS3lGTElSSmJJUUpMSUJzeUpETVJhQkFnbEpPQkFpRWtReEZpSUpTVGdRSlJKRU5ob0JTUlVqRWtRWE5ob0NTUlVqRWtRWFN3TTRBREVBRWtSTEF6Z0hNZ29TUkU4RE9BZ2hCQkpFTVFCTEF6Z1JGbEJNRmxBb1RGQkp2VVVCRkVSTEFqZ0FNUUFTUkVzQ09CUXlDaEpFVHdJNEVrbEVNZ05NRms4REZsQk1VQ1FXVEVzQlVFeFF2eUpETVJZaUNVazRFQ1VTUkRZYUFVa1ZJeEpFRnpFQVN3STRFUlpRVEJaUVN3RTRBREVBRWtSTEFUZ1VNZ29TUkV3NEVrbEVLRThDVUVtK1JFbFhNQWhMQVZjNENFc0NWeEFnU3dOWENBaFBCQ1JiVHdZSUZreFFURkJQQWxCTVVMOGlRellhQVVrVkl4SkVGellhQWtrVkl4SkVGellhQTBrVkl4SkVGekVBVHdNV1VFOENGbEFvVEZCSnZrUkpWekFJU3dGWE9BaExBbGNRSUU4RFZ3QUlUd1VXVUV4UVR3SlFURkMvSWtNMkdnRkpGWUVnRWtRMkdnSkpGU01TUkJjMkdnTkpGU01TUkJjeEZpSUpTVGdRSWhKRU5ob0VTUlVqRWtRWFN3TVdTd1ZNVUU4REZsQW9URkJKdmtSSkkxdExCWEVCUkVzQlN3VWRnUXBQQTVVZlJnSk1GRVJMQlRnQU1RQVNSRXNGT0FkUENCSkVUd1U0Q0JKRVN3RlhNQWhMQWxjNENFc0RWeEFnVHdRa1cwc0dDUlpQQkJaUVRGQlBBbEJNVUwreE1RQ3lGTElTc2hFbHNoQWtzZ0d6SWtNMkdnRkpGU01TUkJkSk5ob0NTUlVqRWtRWE1RQlBBaFpRVEJaUUtFeFFTYjVNU1U4Q1JGY1FJRWxPQkRJREUwRUFLMGNDZ1RCYlRJRTRXMHNFY1FGRVRFOENIWUVLVHdPVkgwWUNUQlJFc2JJSVN3T3lCeUt5RUNTeUFiTk12RWl4TVFBaEJMSUlzZ2Npc2hBa3NnR3pzVEVBVENSYnNoS3lGTElSSmJJUUpMSUJzeUpETmhvQlNSV0JJQkpFTmhvQ1NSVWpFa1FYU1U0Q05ob0RTUlVqRWtRWE1SWWlDVWxPQlRnUUloSkVOaG9FU1JVakVrUVhUZ1EyR2dWSkZTTVNSQmRPQTB3V1R3Sk1VRXdXVUNoTVVFbE9CTDVNU1U4Q1JGY1FJRWxPQnpJREUwRUFNRWNDZ1RoYlN3TkxBUTFFVElFd1cwc0VjUUZFVGdJZGdRcFBBNVVmUmdKTUZFU3hzZ2hMQnJJSElySVFKTElCczA4Q2NRRkVUd0pKVGdKUEJFbE9BeDJCQ2s4RGxSOUdBa3dVUkU4RlNUZ0FNUUFTUkVrNEJ6SUtFa1E0Q0JKRVR3SkpWd0FJVEZjSUNERUFUZ0pRVEZCTUZsQk1GbEMvSWtNMkdnRkpGU01TUkJkSk5ob0NTUlVqRWtRWE1RQlBBaFpRVEJaUUtFeFFTVTRDdmt4SlR3SkVTVmNRSUVsT0F6SURFMFJKSkZ0SlRnSk9BNEV3VzBsT0F3eEJBR1pMQWt4SmdUaGJUd1pKVGdKeEFVUkxBVThGU1U0REhZRUtUd09WSDBZQ1RCUkVzVEVBc2dleUNDS3lFQ1N5QWJPeFNiSVNUd1pKVGdLeUZFOERzaEVsc2hBa3NnR3pUd05YQ0FoUEJVc0NDVThGVHdNSlRCWlBBbEJQQWxCTUZsQk1GbEMvSWtOTEFVTC9sdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
