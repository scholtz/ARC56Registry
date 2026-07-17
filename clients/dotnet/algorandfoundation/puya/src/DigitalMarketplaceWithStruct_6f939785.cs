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

namespace Arc56.Generated.algorandfoundation.puya.DigitalMarketplaceWithStruct_6f939785
{


    public class DigitalMarketplaceWithStructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DigitalMarketplaceWithStructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbE1hcmtldHBsYWNlV2l0aFN0cnVjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMaXN0aW5nS2V5IjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiTGlzdGluZ1ZhbHVlIjpbeyJuYW1lIjoiZGVwb3NpdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InVuaXRhcnlQcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWRkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWRVbml0YXJ5UHJpY2UiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldExpc3RpbmdzTWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGxvd0Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpcnN0RGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXlfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWRfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJxdWFudGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdGFyeV9wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRCaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTczLDcyOCw5MTQsOTQ3LDEwOTldLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODcsNDY5LDU2NSw3MDIsODgyLDEwNTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxpc3RpbmdzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMSw4MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4LDIzMiwyNDEsMzQ3LDQzNCw0NDMsNDUyLDUxOSw1MjgsNTQ3LDY3Miw2ODIsODE0LDgyNiw4NDcsODU4LDEwMjMsMTAzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwzMzldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwLDIxNCw1MzksODM5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURnZ01DQTBJRFV3TlRBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5tTTJPVGN6TnpRMk9UWmxOamMzTXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qTTVDaUFnSUNBdkx5QnNiMmNvSW1sdWFYUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnBibWwwSWdvZ0lDQWdiRzluQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvek53b2dJQ0FnTHk4Z1kyeGhjM01nUkdsbmFYUmhiRTFoY210bGRIQnNZV05sVjJsMGFGTjBjblZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhPQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaRGs0WldZMllUa2dNSGcyWVRSbE4yWmpZU0F3ZURFeVpqQTRZems0SURCNE9XSTBZamd5TXpRZ01IZzBaRGhpTWpOa09DQXdlRFV5WVdNMVpHWTNJREI0WlROaFpXSXlOV01nTUhnek1qTTBZamN4TVNBd2VHTmpPREkyTXpRMklDOHZJRzFsZEdodlpDQWlaMlYwVEdsemRHbHVaM05OWW5Jb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlXeHNiM2RCYzNObGRDaHdZWGtzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltWnBjbk4wUkdWd2IzTnBkQ2h3WVhrc1lYaG1aWElzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pYQnZjMmwwS0dGNFptVnlMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlFjbWxqWlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaWRYa29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhCaGVTeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZDJsMGFHUnlZWGNvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaWFXUW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhCaGVTeDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZqWTJWd2RFSnBaQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmRsZEV4cGMzUnBibWR6VFdKeVgzSnZkWFJsUURZZ1lXeHNiM2RmWVhOelpYUWdabWx5YzNSZlpHVndiM05wZENCa1pYQnZjMmwwSUhObGRGOXdjbWxqWlNCaWRYa2dkMmwwYUdSeVlYY2dZbWxrSUdGalkyVndkRjlpYVdRS0lDQWdJR1Z5Y2dvS2JXRnBibDluWlhSTWFYTjBhVzVuYzAxaWNsOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2dibUZ0WlQwaVoyVjBUR2x6ZEdsdVozTk5ZbklpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURCak5UUTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRnNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk1dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaVmRwZEdoVGRISjFZM1F1WVd4c2IzZGZZWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhiR3h2ZDE5aGMzTmxkRG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW1Gc2JHOTNRWE56WlhRaUtRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3k1cGMxOXZjSFJsWkY5cGJpaGhjM05sZENrS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pnMkNpQWdJQ0F2THlCaGMzTmxjblFnYldKeVgzQmhlUzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RjS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5KZmNHRjVMbUZ0YjNWdWRDQTlQU0JIYkc5aVlXd3VZWE56WlhSZmIzQjBYMmx1WDIxcGJsOWlZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2RzYjJKaGJDQkJjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZzVMVGt4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnWVhOelpYUmZZVzF2ZFc1MFBUQUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG81TUFvZ0lDQWdMeThnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dZWE56WlhSZllXMXZkVzUwUFRBS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamc1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZzVMVGt4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnWVhOelpYUmZZVzF2ZFc1MFBUQUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBTSmhiR3h2ZDBGemMyVjBJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTFoY210bGRIQnNZV05sWDJSbGJXOHViV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1RWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJWWGFYUm9VM1J5ZFdOMExtWnBjbk4wWDJSbGNHOXphWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWFYSnpkRjlrWlhCdmMybDBPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWm1seWMzUkVaWEJ2YzJsMElpa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCdFluSmZjR0Y1TG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5WDNCaGVTNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCa2FXY2dNd29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5WDNCaGVTNWhiVzkxYm5RZ1BUMGdjMlZzWmk1c2FYTjBhVzVuYzE5aWIzaGZiV0p5S0NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5EUXROalVLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdNbDgxTURBS0lDQWdJQzh2SUNBZ0lDQXJDaUFnSUNBdkx5QWdJQ0FnSXlCbWJYUTZJRzltWmdvZ0lDQWdMeThnSUNBZ0lDTWdTMlY1SUd4bGJtZDBhQW9nSUNBZ0x5OGdJQ0FnSUNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURNeUNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ09Bb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcklEZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t3b2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaklGWmhiSFZsSUd4bGJtZDBhQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQTRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dPQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJJRE15Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURnS0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QWdJQ0FnS2dvZ0lDQWdMeThnSUNBZ0lDTWdabTEwT2lCdmJnb2dJQ0FnTHk4Z0lDQWdJRFF3TUFvZ0lDQWdMeThnS1FvZ0lDQWdhVzUwWXlBMElDOHZJRFV3TlRBd0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRBekNpQWdJQ0F2THlCaGMzTmxjblFnYldKeVgzQmhlUzVoYlc5MWJuUWdQVDBnYzJWc1ppNXNhWE4wYVc1bmMxOWliM2hmYldKeUtDa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklHdGxlU0E5SUV4cGMzUnBibWRMWlhrb2IzZHVaWEk5VkhodUxuTmxibVJsY2l3Z1lYTnpaWFE5ZUdabGNpNTRabVZ5WDJGemMyVjBMbWxrTENCdWIyNWpaVDF1YjI1alpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdhMlY1SUc1dmRDQnBiaUJ6Wld4bUxteHBjM1JwYm1kekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5tTTJPVGN6TnpRMk9UWmxOamMzTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QmhjM05sY25RZ2VHWmxjaTV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1URXdDaUFnSUNBdkx5QmhjM05sY25RZ2VHWmxjaTVoYzNObGRGOWhiVzkxYm5RZ1BpQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZbWxrWkdWeVBVRmpZMjkxYm5Rb0tTd0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV4TWkweE1UZ0tJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTQTlJRXhwYzNScGJtZFdZV3gxWlNnS0lDQWdJQzh2SUNBZ0lDQmtaWEJ2YzJsMFpXUTllR1psY2k1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRHRnllVkJ5YVdObFBYVnVhWFJoY25sZmNISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtaR1Z5UFVGalkyOTFiblFvS1N3S0lDQWdJQzh2SUNBZ0lDQmlhV1E5VlVsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFZWSmJuUTJOQ2dwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV4TmdvZ0lDQWdMeThnWW1sa1BWVkpiblEyTkNncExBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TVRJdE1URTRDaUFnSUNBdkx5QnpaV3htTG14cGMzUnBibWR6VzJ0bGVWMGdQU0JNYVhOMGFXNW5WbUZzZFdVb0NpQWdJQ0F2THlBZ0lDQWdaR1Z3YjNOcGRHVmtQWGhtWlhJdVlYTnpaWFJmWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmhjbmxRY21salpUMTFibWwwWVhKNVgzQnlhV05sTEFvZ0lDQWdMeThnSUNBZ0lHSnBaR1JsY2oxQlkyTnZkVzUwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdZbWxrUFZWSmJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lHSnBaRlZ1YVhSaGNubFFjbWxqWlQxVlNXNTBOalFvS1N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaVptbHljM1JFWlhCdmMybDBJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTFoY210bGRIQnNZV05sWDJSbGJXOHViV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1RWFXZHBkR0ZzVFdGeWEyVjBjR3hoWTJWWGFYUm9VM1J5ZFdOMExtUmxjRzl6YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWEJ2YzJsME9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFeU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCclpYa2dQU0JNYVhOMGFXNW5TMlY1S0c5M2JtVnlQVlI0Ymk1elpXNWtaWElzSUdGemMyVjBQWGhtWlhJdWVHWmxjbDloYzNObGRDNXBaQ3dnYm05dVkyVTlibTl1WTJVcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjRabVZ5TG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1WVhOelpYUmZZVzF2ZFc1MElENGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRJNENpQWdJQ0F2THlCbGVHbHpkR2x1WnlBOUlITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTNWpiM0I1S0NrZ0lDTWdiMjVzZVNCdGRYUmhZbXhsSUhOMGNuVmpkSE1nWVhKbElHTnZjR2xsWkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaak5qazNNemMwTmprMlpUWTNOek1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhwYzNScGJtZHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV6TUFvZ0lDQWdMeThnWW1sa1BXVjRhWE4wYVc1bkxtSnBaQ3dLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBME9DQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QmlhV1JWYm1sMFlYSjVVSEpwWTJVOVpYaHBjM1JwYm1jdVltbGtWVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOVFlnT0FvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV6TWdvZ0lDQWdMeThnWW1sa1pHVnlQV1Y0YVhOMGFXNW5MbUpwWkdSbGNpd0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURFMklETXlDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QjFibWwwWVhKNVVISnBZMlU5WlhocGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRNMENpQWdJQ0F2THlCa1pYQnZjMmwwWldROVpYaHBjM1JwYm1jdVpHVndiM05wZEdWa0lDc2dlR1psY2k1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRJNUxURXpOUW9nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRJRDBnVEdsemRHbHVaMVpoYkhWbEtBb2dJQ0FnTHk4Z0lDQWdJR0pwWkQxbGVHbHpkR2x1Wnk1aWFXUXNDaUFnSUNBdkx5QWdJQ0FnWW1sa1ZXNXBkR0Z5ZVZCeWFXTmxQV1Y0YVhOMGFXNW5MbUpwWkZWdWFYUmhjbmxRY21salpTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSTlaWGhwYzNScGJtY3VZbWxrWkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSaGNubFFjbWxqWlQxbGVHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWkdWd2IzTnBkR1ZrUFdWNGFYTjBhVzVuTG1SbGNHOXphWFJsWkNBcklIaG1aWEl1WVhOelpYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5NXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTGtScFoybDBZV3hOWVhKclpYUndiR0ZqWlZkcGRHaFRkSEoxWTNRdWMyVjBYM0J5YVdObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNCeWFXTmxPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW5ObGRGQnlhV05sSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TXprS0lDQWdJQzh2SUd0bGVTQTlJRXhwYzNScGJtZExaWGtvYjNkdVpYSTlWSGh1TG5ObGJtUmxjaXdnWVhOelpYUTlZWE56WlhRdWFXUXNJRzV2Ym1ObFBXNXZibU5sS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRReENpQWdJQ0F2THlCbGVHbHpkR2x1WnlBOUlITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QmlhV1E5WlhocGMzUnBibWN1WW1sa0xBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFE0SURnS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TkRRS0lDQWdJQzh2SUdKcFpGVnVhWFJoY25sUWNtbGpaVDFsZUdsemRHbHVaeTVpYVdSVmJtbDBZWEo1VUhKcFkyVXNDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMU5pQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QmlhV1JrWlhJOVpYaHBjM1JwYm1jdVltbGtaR1Z5TEFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTXpJS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TkRZS0lDQWdJQzh2SUdSbGNHOXphWFJsWkQxbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UUXlMVEUwT0FvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkSUQwZ1RHbHpkR2x1WjFaaGJIVmxLQW9nSUNBZ0x5OGdJQ0FnSUdKcFpEMWxlR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFdWNGFYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCaWFXUmtaWEk5WlhocGMzUnBibWN1WW1sa1pHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdSbGNHOXphWFJsWkQxbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEdGeWVWQnlhV05sUFhWdWFYUmhjbmxmY0hKcFkyVXNDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaWMyVjBVSEpwWTJVaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk1dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaVmRwZEdoVGRISjFZM1F1WW5WNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblY1T2dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR3RsZVNBOUlFeHBjM1JwYm1kTFpYa29iM2R1WlhJOWIzZHVaWElzSUdGemMyVjBQV0Z6YzJWMExtbGtMQ0J1YjI1alpUMXViMjVqWlNrS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFMk1Rb2dJQ0FnTHk4Z2JHbHpkR2x1WnlBOUlITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UWXpDaUFnSUNBdkx5QmhiVzkxYm5SZmRHOWZZbVZmY0dGcFpDQTlJSE5sYkdZdWNYVmhiblJwZEhsZmNISnBZMlVvY1hWaGJuUnBkSGtzSUd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExDQmhjM05sZEM1a1pXTnBiV0ZzY3lrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOamtLSUNBZ0lDOHZJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMmhwWjJnc0lHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyeHZkeUE5SUc5d0xtMTFiSGNvY0hKcFkyVXNJSEYxWVc1MGFYUjVLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOekFLSUNBZ0lDOHZJSE5qWVd4cGJtZGZabUZqZEc5eVgyaHBaMmdzSUhOallXeHBibWRmWm1GamRHOXlYMnh2ZHlBOUlHOXdMbVY0Y0hjb01UQXNJR0Z6YzJWMFgyUmxZMmx0WVd4ektRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIQjNDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56RXROek1LSUNBZ0lDOHZJRjl4ZFc5MGFXVnVkRjlvYVdkb0xDQmhiVzkxYm5SZmRHOWZZbVZmY0dGcFpDd2dYM0psYldGcGJtUmxjbDlvYVdkb0xDQmZjbVZ0WVdsdVpHVnlYMnh2ZHlBOUlHOXdMbVJwZG0xdlpIY29DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMjV2ZEY5elkyRnNaV1JmYUdsbmFDd2dZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZiRzkzTENCelkyRnNhVzVuWDJaaFkzUnZjbDlvYVdkb0xDQnpZMkZzYVc1blgyWmhZM1J2Y2w5c2IzY0tJQ0FnSUM4dklDa0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdYM0YxYjNScFpXNTBYMmhwWjJnZ1BUMGdNQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QmhjM05sY25RZ1luVjVYM0JoZVM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWkdsbklEVUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUyTmdvZ0lDQWdMeThnWVhOelpYSjBJR0oxZVY5d1lYa3VjbVZqWldsMlpYSWdQVDBnYjNkdVpYSUtJQ0FnSUdScFp5QTFDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRZM0NpQWdJQ0F2THlCaGMzTmxjblFnWW5WNVgzQmhlUzVoYlc5MWJuUWdQVDBnWVcxdmRXNTBYM1J2WDJKbFgzQmhhV1FLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCaWFXUTliR2x6ZEdsdVp5NWlhV1FzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTBPQ0E0Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGN4Q2lBZ0lDQXZMeUJpYVdSVmJtbDBZWEo1VUhKcFkyVTliR2x6ZEdsdVp5NWlhV1JWYm1sMFlYSjVVSEpwWTJVc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0ExTmlBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRjeUNpQWdJQ0F2THlCaWFXUmtaWEk5YkdsemRHbHVaeTVpYVdSa1pYSXNDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTNOQW9nSUNBZ0x5OGdaR1Z3YjNOcGRHVmtQV3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtJQzBnY1hWaGJuUnBkSGtzQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEWUtJQ0FnSUMwS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TmprdE1UYzFDaUFnSUNBdkx5QnpaV3htTG14cGMzUnBibWR6VzJ0bGVWMGdQU0JNYVhOMGFXNW5WbUZzZFdVb0NpQWdJQ0F2THlBZ0lDQWdZbWxrUFd4cGMzUnBibWN1WW1sa0xBb2dJQ0FnTHk4Z0lDQWdJR0pwWkZWdWFYUmhjbmxRY21salpUMXNhWE4wYVc1bkxtSnBaRlZ1YVhSaGNubFFjbWxqWlN3S0lDQWdJQzh2SUNBZ0lDQmlhV1JrWlhJOWJHbHpkR2x1Wnk1aWFXUmtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkR0Z5ZVZCeWFXTmxQV3hwYzNScGJtY3VkVzVwZEdGeWVWQnlhV05sTEFvZ0lDQWdMeThnSUNBZ0lHUmxjRzl6YVhSbFpEMXNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDQXRJSEYxWVc1MGFYUjVMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakUzTnkweE56a0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JoYzNObGRGOWhiVzkxYm5ROWNYVmhiblJwZEhrS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFgyRnRiM1Z1ZEQxeGRXRnVkR2wwZVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTNOd29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE56Y3RNVGM1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1lYTnpaWFJmWVcxdmRXNTBQWEYxWVc1MGFYUjVDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFMU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0WVhKclpYUndiR0ZqWlY5a1pXMXZMbTFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdVJHbG5hWFJoYkUxaGNtdGxkSEJzWVdObFYybDBhRk4wY25WamRDNTNhWFJvWkhKaGQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJR3RsZVNBOUlFeHBjM1JwYm1kTFpYa29iM2R1WlhJOVZIaHVMbk5sYm1SbGNpd2dZWE56WlhROVlYTnpaWFF1YVdRc0lHNXZibU5sUFc1dmJtTmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z2JHbHpkR2x1WnlBOUlITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhwYzNScGJtZHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakU0TmdvZ0lDQWdMeThnYVdZZ2JHbHpkR2x1Wnk1aWFXUmtaWElnSVQwZ1FXTmpiM1Z1ZENncE9nb2dJQ0FnWlhoMGNtRmpkQ0F4TmlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmllaUIzYVhSb1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklHeHBjM1JwYm1jdVltbGtMQ0JzYVhOMGFXNW5MbUpwWkZWdWFYUmhjbmxRY21salpTd2dZWE56WlhRdVpHVmphVzFoYkhNS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOamtLSUNBZ0lDOHZJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMmhwWjJnc0lHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyeHZkeUE5SUc5d0xtMTFiSGNvY0hKcFkyVXNJSEYxWVc1MGFYUjVLUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpBS0lDQWdJQzh2SUhOallXeHBibWRmWm1GamRHOXlYMmhwWjJnc0lITmpZV3hwYm1kZlptRmpkRzl5WDJ4dmR5QTlJRzl3TG1WNGNIY29NVEFzSUdGemMyVjBYMlJsWTJsdFlXeHpLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOekV0TnpNS0lDQWdJQzh2SUY5eGRXOTBhV1Z1ZEY5b2FXZG9MQ0JoYlc5MWJuUmZkRzlmWW1WZmNHRnBaQ3dnWDNKbGJXRnBibVJsY2w5b2FXZG9MQ0JmY21WdFlXbHVaR1Z5WDJ4dmR5QTlJRzl3TG1ScGRtMXZaSGNvQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmFHbG5hQ3dnWVcxdmRXNTBYMjV2ZEY5elkyRnNaV1JmYkc5M0xDQnpZMkZzYVc1blgyWmhZM1J2Y2w5b2FXZG9MQ0J6WTJGc2FXNW5YMlpoWTNSdmNsOXNiM2NLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBkbTF2WkhjS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjMENpQWdJQ0F2THlCaGMzTmxjblFnWDNGMWIzUnBaVzUwWDJocFoyZ2dQVDBnTUFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVGt3Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb2NtVmpaV2wyWlhJOWJHbHpkR2x1Wnk1aWFXUmtaWElzSUdGdGIzVnVkRDFqZFhKeVpXNTBYMkpwWkY5a1pYQnZjMmwwS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENncDNhWFJvWkhKaGQxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRreUNpQWdJQ0F2THlCa1pXd2djMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hPVFFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENoeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxDQmhiVzkxYm5ROWMyVnNaaTVzYVhOMGFXNW5jMTlpYjNoZmJXSnlLQ2twTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TkRRdE5qVUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvQ2lBZ0lDQXZMeUFnSUNBZ01sODFNREFLSUNBZ0lDOHZJQ0FnSUNBckNpQWdJQ0F2THlBZ0lDQWdJeUJtYlhRNklHOW1aZ29nSUNBZ0x5OGdJQ0FnSUNNZ1MyVjVJR3hsYm1kMGFBb2dJQ0FnTHk4Z0lDQWdJQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdPQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJJRE15Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS3dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FqSUZaaGJIVmxJR3hsYm1kMGFBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBNENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ09Bb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcklETXlDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dPQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJJRGdLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBZ0lDQWdLZ29nSUNBZ0x5OGdJQ0FnSUNNZ1ptMTBPaUJ2YmdvZ0lDQWdMeThnSUNBZ0lEUXdNQW9nSUNBZ0x5OGdLUW9nSUNBZ2FXNTBZeUEwSUM4dklEVXdOVEF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakU1TkFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z0YjNWdWREMXpaV3htTG14cGMzUnBibWR6WDJKdmVGOXRZbklvS1NrdWMzVmliV2wwS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE9UWXRNVGs0Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1lYTnpaWFJmWVcxdmRXNTBQV3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTENCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjloYlc5MWJuUTliR2x6ZEdsdVp5NWtaWEJ2YzJsMFpXUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakU1TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eklDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hPVFl0TVRrNENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRDd2dZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd2dZWE56WlhSZllXMXZkVzUwUFd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRTRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dFlYSnJaWFJ3YkdGalpWOWtaVzF2TG0xaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxWMmwwYUZOMGNuVmpkQzVpYVdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlhV1E2Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TWpFd0NpQWdJQ0F2THlCclpYa2dQU0JNYVhOMGFXNW5TMlY1S0c5M2JtVnlQVzkzYm1WeUxDQmhjM05sZEQxaGMzTmxkQzVwWkN3Z2JtOXVZMlU5Ym05dVkyVXBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5QnNhWE4wYVc1bklEMGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWmpOamszTXpjME5qazJaVFkzTnpNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qRXpDaUFnSUNBdkx5QnBaaUJzYVhOMGFXNW5MbUpwWkdSbGNpQWhQU0JCWTJOdmRXNTBLQ2s2Q2lBZ0lDQmxlSFJ5WVdOMElERTJJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURjS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdKNklHSnBaRjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU1UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCMWJtbDBZWEo1WDNCeWFXTmxJRDRnYkdsemRHbHVaeTVpYVdSVmJtbDBZWEo1VUhKcFkyVUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2NIVnphR2x1ZENBMU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QnNhWE4wYVc1bkxtSnBaQ3dnYkdsemRHbHVaeTVpYVdSVmJtbDBZWEo1VUhKcFkyVXNJR0Z6YzJWMExtUmxZMmx0WVd4ekNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalk1Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibTkwWDNOallXeGxaRjlvYVdkb0xDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOXNiM2NnUFNCdmNDNXRkV3gzS0hCeWFXTmxMQ0J4ZFdGdWRHbDBlU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRzExYkhjS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8zTUFvZ0lDQWdMeThnYzJOaGJHbHVaMTltWVdOMGIzSmZhR2xuYUN3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYkc5M0lEMGdiM0F1Wlhod2R5Z3hNQ3dnWVhOelpYUmZaR1ZqYVcxaGJITXBDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRjSGNLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNNUzAzTXdvZ0lDQWdMeThnWDNGMWIzUnBaVzUwWDJocFoyZ3NJR0Z0YjNWdWRGOTBiMTlpWlY5d1lXbGtMQ0JmY21WdFlXbHVaR1Z5WDJocFoyZ3NJRjl5WlcxaGFXNWtaWEpmYkc5M0lEMGdiM0F1WkdsMmJXOWtkeWdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5b2FXZG9MQ0JoYlc5MWJuUmZibTkwWDNOallXeGxaRjlzYjNjc0lITmpZV3hwYm1kZlptRmpkRzl5WDJocFoyZ3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyeHZkd29nSUNBZ0x5OGdLUW9nSUNBZ1pHbDJiVzlrZHdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpRS0lDQWdJQzh2SUdGemMyVnlkQ0JmY1hWdmRHbGxiblJmYUdsbmFDQTlQU0F3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNakFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENoeVpXTmxhWFpsY2oxc2FYTjBhVzVuTG1KcFpHUmxjaXdnWVcxdmRXNTBQV04xY25KbGJuUmZZbWxrWDJGdGIzVnVkQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1ltbGtYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU1qSUtJQ0FnSUM4dklHRnRiM1Z1ZEY5MGIxOWlaVjlpYVdRZ1BTQnpaV3htTG5GMVlXNTBhWFI1WDNCeWFXTmxLSEYxWVc1MGFYUjVMQ0IxYm1sMFlYSjVYM0J5YVdObExDQmhjM05sZEM1a1pXTnBiV0ZzY3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5qa0tJQ0FnSUM4dklHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyaHBaMmdzSUdGdGIzVnVkRjl1YjNSZmMyTmhiR1ZrWDJ4dmR5QTlJRzl3TG0xMWJIY29jSEpwWTJVc0lIRjFZVzUwYVhSNUtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnRkV3gzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOekFLSUNBZ0lDOHZJSE5qWVd4cGJtZGZabUZqZEc5eVgyaHBaMmdzSUhOallXeHBibWRmWm1GamRHOXlYMnh2ZHlBOUlHOXdMbVY0Y0hjb01UQXNJR0Z6YzJWMFgyUmxZMmx0WVd4ektRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCbGVIQjNDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56RXROek1LSUNBZ0lDOHZJRjl4ZFc5MGFXVnVkRjlvYVdkb0xDQmhiVzkxYm5SZmRHOWZZbVZmY0dGcFpDd2dYM0psYldGcGJtUmxjbDlvYVdkb0xDQmZjbVZ0WVdsdVpHVnlYMnh2ZHlBOUlHOXdMbVJwZG0xdlpIY29DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMjV2ZEY5elkyRnNaV1JmYUdsbmFDd2dZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZiRzkzTENCelkyRnNhVzVuWDJaaFkzUnZjbDlvYVdkb0xDQnpZMkZzYVc1blgyWmhZM1J2Y2w5c2IzY0tJQ0FnSUM4dklDa0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdYM0YxYjNScFpXNTBYMmhwWjJnZ1BUMGdNQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QmhjM05sY25RZ1ltbGtYM0JoZVM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pJeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdKcFpGOXdZWGt1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TWpZS0lDQWdJQzh2SUdGemMyVnlkQ0JpYVdSZmNHRjVMbUZ0YjNWdWRDQTlQU0JoYlc5MWJuUmZkRzlmWW1WZlltbGtDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU1qa0tJQ0FnSUM4dklHUmxjRzl6YVhSbFpEMXNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSXpNQW9nSUNBZ0x5OGdkVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0E0SURnS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TXpFS0lDQWdJQzh2SUdKcFpHUmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSXlPQzB5TXpRS0lDQWdJQzh2SUhObGJHWXViR2x6ZEdsdVozTmJhMlY1WFNBOUlFeHBjM1JwYm1kV1lXeDFaU2dLSUNBZ0lDOHZJQ0FnSUNCa1pYQnZjMmwwWldROWJHbHpkR2x1Wnk1a1pYQnZjMmwwWldRc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnTHk4Z0lDQWdJR0pwWkdSbGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpEMXhkV0Z1ZEdsMGVTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSVmJtbDBZWEo1VUhKcFkyVTlkVzVwZEdGeWVWOXdjbWxqWlN3S0lDQWdJQzh2SUNrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSXdNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dFlYSnJaWFJ3YkdGalpWOWtaVzF2TG0xaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxWMmwwYUZOMGNuVmpkQzVoWTJObGNIUmZZbWxrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXTmpaWEIwWDJKcFpEb0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNodVlXMWxQU0poWTJObGNIUkNhV1FpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QnJaWGtnUFNCTWFYTjBhVzVuUzJWNUtHOTNibVZ5UFZSNGJpNXpaVzVrWlhJc0lHRnpjMlYwUFdGemMyVjBMbWxrTENCdWIyNWpaVDF1YjI1alpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TkRBS0lDQWdJQzh2SUd4cGMzUnBibWNnUFNCelpXeG1MbXhwYzNScGJtZHpXMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Tm1NMk9UY3pOelEyT1RabE5qYzNNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYVhOMGFXNW5jeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0JzYVhOMGFXNW5MbUpwWkdSbGNpQWhQU0JCWTJOdmRXNTBLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveU5ETUtJQ0FnSUM4dklHMXBibDl4ZFdGdWRHbDBlU0E5SUd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUdsbUlHeHBjM1JwYm1jdVpHVndiM05wZEdWa0lEd2diR2x6ZEdsdVp5NWlhV1FnWld4elpTQnNhWE4wYVc1bkxtSnBaQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdjSFZ6YUdsdWRDQTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdQQW9nSUNBZ1lub2dZV05qWlhCMFgySnBaRjkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUdScFp5QXlDZ3BoWTJObGNIUmZZbWxrWDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lORFlLSUNBZ0lDOHZJRzFwYmw5eGRXRnVkR2wwZVN3Z2JHbHpkR2x1Wnk1aWFXUlZibWwwWVhKNVVISnBZMlVzSUdGemMyVjBMbVJsWTJsdFlXeHpDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOamtLSUNBZ0lDOHZJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMmhwWjJnc0lHRnRiM1Z1ZEY5dWIzUmZjMk5oYkdWa1gyeHZkeUE5SUc5d0xtMTFiSGNvY0hKcFkyVXNJSEYxWVc1MGFYUjVLUW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCdGRXeDNDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56QUtJQ0FnSUM4dklITmpZV3hwYm1kZlptRmpkRzl5WDJocFoyZ3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyeHZkeUE5SUc5d0xtVjRjSGNvTVRBc0lHRnpjMlYwWDJSbFkybHRZV3h6S1FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhCM0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpFdE56TUtJQ0FnSUM4dklGOXhkVzkwYVdWdWRGOW9hV2RvTENCaGJXOTFiblJmZEc5ZlltVmZjR0ZwWkN3Z1gzSmxiV0ZwYm1SbGNsOW9hV2RvTENCZmNtVnRZV2x1WkdWeVgyeHZkeUE5SUc5d0xtUnBkbTF2Wkhjb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZhR2xuYUN3Z1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmJHOTNMQ0J6WTJGc2FXNW5YMlpoWTNSdmNsOW9hV2RvTENCelkyRnNhVzVuWDJaaFkzUnZjbDlzYjNjS0lDQWdJQzh2SUNrS0lDQWdJR1JwZG0xdlpIY0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qYzBDaUFnSUNBdkx5QmhjM05sY25RZ1gzRjFiM1JwWlc1MFgyaHBaMmdnUFQwZ01Bb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TWpRNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9jbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdnWVcxdmRXNTBQV0psYzNSZlltbGtYMkZ0YjNWdWRDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TWpVeExUSTFNd29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzSUdGemMyVjBYM0psWTJWcGRtVnlQV3hwYzNScGJtY3VZbWxrWkdWeUxDQmhjM05sZEY5aGJXOTFiblE5YldsdVgzRjFZVzUwYVhSNUNpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG95TlRFS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJR2x1ZEdOZk15QXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNalV4TFRJMU13b2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBXeHBjM1JwYm1jdVltbGtaR1Z5TENCaGMzTmxkRjloYlc5MWJuUTliV2x1WDNGMVlXNTBhWFI1Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSTFPQW9nSUNBZ0x5OGdkVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSTFPUW9nSUNBZ0x5OGdaR1Z3YjNOcGRHVmtQV3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtJQzBnYldsdVgzRjFZVzUwYVhSNUxBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmthV2NnTWdvZ0lDQWdMUW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qSTJNQW9nSUNBZ0x5OGdZbWxrUFd4cGMzUnBibWN1WW1sa0lDMGdiV2x1WDNGMVlXNTBhWFI1TEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQzBLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lOVFV0TWpZeENpQWdJQ0F2THlCelpXeG1MbXhwYzNScGJtZHpXMnRsZVYwZ1BTQk1hWE4wYVc1blZtRnNkV1VvQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtaR1Z5UFd4cGMzUnBibWN1WW1sa1pHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpGVnVhWFJoY25sUWNtbGpaVDFzYVhOMGFXNW5MbUpwWkZWdWFYUmhjbmxRY21salpTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFlYSjVVSEpwWTJVOWJHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWkdWd2IzTnBkR1ZrUFd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUMwZ2JXbHVYM0YxWVc1MGFYUjVMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpEMXNhWE4wYVc1bkxtSnBaQ0F0SUcxcGJsOXhkV0Z1ZEdsMGVTd0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3lNellLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFNKaFkyTmxjSFJDYVdRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZV05qWlhCMFgySnBaRjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpQmhZMk5sY0hSZlltbGtYM1JsY201aGNubGZiV1Z5WjJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFnQUJNU0tBeVlCQ0d4cGMzUnBibWR6TVJoQUFBZUFCR2x1YVhTd01SdEJBRjh4R1JSRU1SaEVnZ2tFMlk3MnFRUnFUbi9LQkJMd2pKZ0VtMHVDTkFSTml5UFlCRktzWGZjRTQ2NnlYQVF5TkxjUkJNeUNZMFkyR2dDT0NRQUJBQm9BV1FEWEFUZ0JoQUltQXFzRGhRQ0FEQlVmZkhVQUFBQUFBQURGUkxBaVF6RVpGREVZRkJCRE1SWWlDVWs0RUNJU1JEWWFBVWtWSXhKRUZ6SUtTd0Z3QUVVQkZFUkxBVGdITWdvU1JFdzRDRElRRWtTeE1nb2tzaEt5RkxJUkpiSVFKTElCc3lKRE1SYUJBZ2xKT0JBaUVrUXhGaUlKU1RnUUpSSkVOaG9CU1JVakVrUVhOaG9DU1JVakVrUVhTd000QURFQUVrUkxBemdITWdvU1JFOERPQWdoQkJKRU1RQkxBemdSRmxCTUZsQW9URkJKdlVVQkZFUkxBamdBTVFBU1JFc0NPQlF5Q2hKRVR3STRFa2xFTWdOTUZrOERGbEJNVUNRV1RFc0JVRXhRdnlKRE1SWWlDVWs0RUNVU1JEWWFBVWtWSXhKRUZ6RUFTd0k0RVJaUVRCWlFTd0U0QURFQUVrUkxBVGdVTWdvU1JFdzRFa2xFS0U4Q1VFbStSRWxYTUFoTEFWYzRDRXNDVnhBZ1N3TlhDQWhQQkNSYlR3WUlGa3hRVEZCUEFsQk1VTDhpUXpZYUFVa1ZJeEpFRnpZYUFra1ZJeEpFRnpZYUEwa1ZJeEpFRnpFQVR3TVdVRThDRmxBb1RGQkp2a1JKVnpBSVN3RlhPQWhMQWxjUUlFOERWd0FJVHdVV1VFeFFUd0pRVEZDL0lrTTJHZ0ZKRllFZ0VrUTJHZ0pKRlNNU1JCYzJHZ05KRlNNU1JCY3hGaUlKU1RnUUloSkVOaG9FU1JVakVrUVhTd01XU3dWTVVFOERGbEFvVEZCSnZrUkpJMXRMQlhFQlJFc0JTd1VkZ1FwUEE1VWZSZ0pNRkVSTEJUZ0FNUUFTUkVzRk9BZFBDQkpFVHdVNENCSkVTd0ZYTUFoTEFsYzRDRXNEVnhBZ1R3UWtXMHNHQ1JaUEJCWlFURkJQQWxCTVVMK3hNUUN5RkxJU3NoRWxzaEFrc2dHeklrTTJHZ0ZKRlNNU1JCZEpOaG9DU1JVakVrUVhNUUJQQWhaUVRCWlFLRXhRU2I1TVNVOENSRmNRSUVsT0JESURFMEVBSzBjQ2dUQmJUSUU0VzBzRWNRRkVURThDSFlFS1R3T1ZIMFlDVEJSRXNiSUlTd095QnlLeUVDU3lBYk5NdkVpeE1RQWhCTElJc2djaXNoQWtzZ0d6c1RFQVRDUmJzaEt5RkxJUkpiSVFKTElCc3lKRE5ob0JTUldCSUJKRU5ob0NTUlVqRWtRWFNVNENOaG9EU1JVakVrUVhNUllpQ1VsT0JUZ1FJaEpFTmhvRVNSVWpFa1FYVGdRMkdnVkpGU01TUkJkT0Ewd1dUd0pNVUV3V1VDaE1VRWxPQkw1TVNVOENSRmNRSUVsT0J6SURFMEVBTUVjQ2dUaGJTd05MQVExRVRJRXdXMHNFY1FGRVRnSWRnUXBQQTVVZlJnSk1GRVN4c2doTEJySUhJcklRSkxJQnMwOENjUUZFVHdKSlRnSlBCRWxPQXgyQkNrOERsUjlHQWt3VVJFOEZTVGdBTVFBU1JFazRCeklLRWtRNENCSkVUd0pKVndBSVRGY0lDREVBVGdKUVRGQk1GbEJNRmxDL0lrTTJHZ0ZKRlNNU1JCZEpOaG9DU1JVakVrUVhNUUJQQWhaUVRCWlFLRXhRU1U0Q3ZreEpUd0pFU1ZjUUlFbE9BeklERTBSSkpGdEpUZ0pPQTRFd1cwbE9Bd3hCQUdaTEFreEpnVGhiVHdaSlRnSnhBVVJMQVU4RlNVNERIWUVLVHdPVkgwWUNUQlJFc1RFQXNnZXlDQ0t5RUNTeUFiT3hTYklTVHdaSlRnS3lGRThEc2hFbHNoQWtzZ0d6VHdOWENBaFBCVXNDQ1U4RlR3TUpUQlpQQWxCUEFsQk1GbEJNRmxDL0lrTkxBVUwvbHc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
