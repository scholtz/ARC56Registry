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

namespace Arc56.Generated.algorandfoundation.puya.DigitalMarketplaceWithTups_c68651c7
{


    public class DigitalMarketplaceWithTupsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DigitalMarketplaceWithTupsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlnaXRhbE1hcmtldHBsYWNlV2l0aFR1cHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTGlzdGluZ0tleSI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50NjQifV0sIkxpc3RpbmdWYWx1ZSI6W3sibmFtZSI6ImRlcG9zaXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1bml0YXJ5UHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmlkZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJiaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmlkVW5pdGFyeVByaWNlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRMaXN0aW5nc01iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWxsb3dBc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaXJzdERlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0YXJ5X3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0YXJ5X3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5X3BheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVhbnRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmlkX3BheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVhbnRpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXRhcnlfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0QmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub25jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYwNSw3NDksOTQ4LDk4MSwxMTI1XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyLDQ3OCw1NzgsNzE0LDg5NywxMDc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5saXN0aW5ncyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjQsODI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OCwyMzIsMjQxLDM0Nyw0NDMsNDUyLDQ2MSw1MzIsNTQxLDU2MCw2ODgsNjk4LDgzMyw4NDUsODY2LDg3NywxMDQ2LDEwNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjQsMzM5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwyMTQsNTUyLDg1OF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEZ2dNQ0EwSURVd05UQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRObU0yT1Rjek56UTJPVFpsTmpjM013b2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZOREFLSUNBZ0lDOHZJR3h2WnlnaWFXNXBkQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWx1YVhRaUNpQWdJQ0JzYjJjS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk16Z0tJQ0FnSUM4dklHTnNZWE56SUVScFoybDBZV3hOWVhKclpYUndiR0ZqWlZkcGRHaFVkWEJ6S0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTRDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtPVGhsWmpaaE9TQXdlRFpoTkdVM1ptTmhJREI0TVRKbU1EaGpPVGdnTUhnNVlqUmlPREl6TkNBd2VEUmtPR0l5TTJRNElEQjROVEpoWXpWa1pqY2dNSGhsTTJGbFlqSTFZeUF3ZURNeU16UmlOekV4SURCNFkyTTRNall6TkRZZ0x5OGdiV1YwYUc5a0lDSm5aWFJNYVhOMGFXNW5jMDFpY2lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaGJHeHZkMEZ6YzJWMEtIQmhlU3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVptbHljM1JFWlhCdmMybDBLSEJoZVN4aGVHWmxjaXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGNHOXphWFFvWVhobVpYSXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGQnlhV05sS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1KMWVTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzY0dGNUxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkeWgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1KcFpDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFzY0dGNUxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV05qWlhCMFFtbGtLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZaMlYwVEdsemRHbHVaM05OWW5KZmNtOTFkR1ZBTmlCaGJHeHZkMTloYzNObGRDQm1hWEp6ZEY5a1pYQnZjMmwwSUdSbGNHOXphWFFnYzJWMFgzQnlhV05sSUdKMWVTQjNhWFJvWkhKaGR5QmlhV1FnWVdOalpYQjBYMkpwWkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMmRsZEV4cGMzUnBibWR6VFdKeVgzSnZkWFJsUURZNkNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG8zT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVc0lHNWhiV1U5SW1kbGRFeHBjM1JwYm1kelRXSnlJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREF3WXpVME5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU0T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xaGNtdGxkSEJzWVdObFgyUmxiVzh1YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpWZHBkR2hVZFhCekxtRnNiRzkzWDJGemMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVd4c2IzZGZZWE56WlhRNkNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG80TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOUltRnNiRzkzUVhOelpYUWlLUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRvNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtbHpYMjl3ZEdWa1gybHVLR0Z6YzJWMEtRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRvNE53b2dJQ0FnTHk4Z1lYTnpaWEowSUcxaWNsOXdZWGt1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5KZmNHRjVMbUZ0YjNWdWRDQTlQU0JIYkc5aVlXd3VZWE56WlhSZmIzQjBYMmx1WDIxcGJsOWlZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2RzYjJKaGJDQkJjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk9UQXRPVElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTENCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0JoYzNObGRGOWhiVzkxYm5ROU1Bb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZPVEVLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lHRnpjMlYwWDJGdGIzVnVkRDB3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qa3dDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2T1RBdE9USUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQmhjM05sZEY5aGJXOTFiblE5TUFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qZ3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWVd4c2IzZEJjM05sZENJcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dFlYSnJaWFJ3YkdGalpWOWtaVzF2TG0xaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NUVhV2RwZEdGc1RXRnlhMlYwY0d4aFkyVlhhWFJvVkhWd2N5NW1hWEp6ZEY5a1pYQnZjMmwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ptbHljM1JmWkdWd2IzTnBkRG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qazBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWm1seWMzUkVaWEJ2YzJsMElpa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pFd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUcxaWNsOXdZWGt1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWkdsbklETUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1UQTBDaUFnSUNBdkx5QmhjM05sY25RZ2JXSnlYM0JoZVM1aGJXOTFiblFnUFQwZ2MyVnNaaTVzYVhOMGFXNW5jMTlpYjNoZmJXSnlLQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG8wTlMwMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNBeVh6VXdNQW9nSUNBZ0x5OGdJQ0FnSUNzS0lDQWdJQzh2SUNBZ0lDQWpJR1p0ZERvZ2IyWm1DaUFnSUNBdkx5QWdJQ0FnSXlCTFpYa2diR1Z1WjNSb0NpQWdJQ0F2THlBZ0lDQWdLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQTRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dNeklLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLeUE0Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FyQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ01nVm1Gc2RXVWdiR1Z1WjNSb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSURnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS3lBNENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNzZ016SUtJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t5QTRDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDc2dPQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNBZ0lDQXFDaUFnSUNBdkx5QWdJQ0FnSXlCbWJYUTZJRzl1Q2lBZ0lDQXZMeUFnSUNBZ05EQXdDaUFnSUNBdkx5QXBDaUFnSUNCcGJuUmpJRFFnTHk4Z05UQTFNREFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXdOQW9nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdVlXMXZkVzUwSUQwOUlITmxiR1l1YkdsemRHbHVaM05mWW05NFgyMWljaWdwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZkSFZ3Y3k1d2VUb3hNRFlLSUNBZ0lDOHZJR3RsZVNBOUlFeHBjM1JwYm1kTFpYa29iM2R1WlhJOVZIaHVMbk5sYm1SbGNpd2dZWE56WlhROWVHWmxjaTU0Wm1WeVgyRnpjMlYwTG1sa0xDQnViMjVqWlQxdWIyNWpaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCbmRIaHVjeUJZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXdOd29nSUNBZ0x5OGdZWE56WlhKMElHdGxlU0J1YjNRZ2FXNGdjMlZzWmk1c2FYTjBhVzVuY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZelk1TnpNM05EWTVObVUyTnpjekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXdPUW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXhNQW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCNFptVnlMbUZ6YzJWMFgyRnRiM1Z1ZENBK0lEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE1UWUtJQ0FnSUM4dklHSnBaR1JsY2oxQlkyTnZkVzUwS0Nrc0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXhNd29nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRJRDBnVEdsemRHbHVaMVpoYkhWbEtBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRFM0NpQWdJQ0F2THlCaWFXUTlWVWx1ZERZMEtDa3NDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRFekNpQWdJQ0F2THlCelpXeG1MbXhwYzNScGJtZHpXMnRsZVYwZ1BTQk1hWE4wYVc1blZtRnNkV1VvQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pFeE15MHhNVGtLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjNOYmEyVjVYU0E5SUV4cGMzUnBibWRXWVd4MVpTZ0tJQ0FnSUM4dklDQWdJQ0JrWlhCdmMybDBaV1E5ZUdabGNpNWhjM05sZEY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkR0Z5ZVZCeWFXTmxQWFZ1YVhSaGNubGZjSEpwWTJVc0NpQWdJQ0F2THlBZ0lDQWdZbWxrWkdWeVBVRmpZMjkxYm5Rb0tTd0tJQ0FnSUM4dklDQWdJQ0JpYVdROVZVbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdZbWxrVlc1cGRHRnllVkJ5YVdObFBWVkpiblEyTkNncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk9UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNodVlXMWxQU0ptYVhKemRFUmxjRzl6YVhRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk1dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVSR2xuYVhSaGJFMWhjbXRsZEhCc1lXTmxWMmwwYUZSMWNITXVaR1Z3YjNOcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsY0c5emFYUTZDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE1qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRJekNpQWdJQ0F2THlCclpYa2dQU0JNYVhOMGFXNW5TMlY1S0c5M2JtVnlQVlI0Ymk1elpXNWtaWElzSUdGemMyVjBQWGhtWlhJdWVHWmxjbDloYzNObGRDNXBaQ3dnYm05dVkyVTlibTl1WTJVcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0I0Wm1WeUxuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94TWpZS0lDQWdJQzh2SUdGemMyVnlkQ0I0Wm1WeUxtRnpjMlYwWDNKbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR1JwWnlBekNpQWdJQ0JuZEhodWN5QkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVEkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdlR1psY2k1aGMzTmxkRjloYlc5MWJuUWdQaUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVEk1Q2lBZ0lDQXZMeUJsZUdsemRHbHVaeUE5SUhObGJHWXViR2x6ZEdsdVozTmJhMlY1WFFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRObU0yT1Rjek56UTJPVFpsTmpjM013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhwYzNScGJtZHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ01UWWdNeklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEUTRJRGdLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWlhoMGNtRmpkQ0ExTmlBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94TXpVS0lDQWdJQzh2SUdSbGNHOXphWFJsWkQxbGVHbHpkR2x1Wnk1a1pYQnZjMmwwWldRZ0t5QjRabVZ5TG1GemMyVjBYMkZ0YjNWdWRDd0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94TXpBS0lDQWdJQzh2SUhObGJHWXViR2x6ZEdsdVozTmJhMlY1WFNBOUlFeHBjM1JwYm1kV1lXeDFaU2dLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRNd0xURXpOZ29nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRJRDBnVEdsemRHbHVaMVpoYkhWbEtBb2dJQ0FnTHk4Z0lDQWdJR0pwWkQxbGVHbHpkR2x1Wnk1aWFXUXNDaUFnSUNBdkx5QWdJQ0FnWW1sa1ZXNXBkR0Z5ZVZCeWFXTmxQV1Y0YVhOMGFXNW5MbUpwWkZWdWFYUmhjbmxRY21salpTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSTlaWGhwYzNScGJtY3VZbWxrWkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSaGNubFFjbWxqWlQxbGVHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWkdWd2IzTnBkR1ZrUFdWNGFYTjBhVzVuTG1SbGNHOXphWFJsWkNBcklIaG1aWEl1WVhOelpYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1USXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xaGNtdGxkSEJzWVdObFgyUmxiVzh1YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpWZHBkR2hVZFhCekxuTmxkRjl3Y21salpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5d2NtbGpaVG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRXpPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW5ObGRGQnlhV05sSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakUwTUFvZ0lDQWdMeThnYTJWNUlEMGdUR2x6ZEdsdVowdGxlU2h2ZDI1bGNqMVVlRzR1YzJWdVpHVnlMQ0JoYzNObGREMWhjM05sZEM1cFpDd2dibTl1WTJVOWJtOXVZMlVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE5ESUtJQ0FnSUM4dklHVjRhWE4wYVc1bklEMGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4TmlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTkRnZ09Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMElEVTJJRGdLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRTBNd29nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRJRDBnVEdsemRHbHVaMVpoYkhWbEtBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pFME15MHhORGtLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjNOYmEyVjVYU0E5SUV4cGMzUnBibWRXWVd4MVpTZ0tJQ0FnSUM4dklDQWdJQ0JpYVdROVpYaHBjM1JwYm1jdVltbGtMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpGVnVhWFJoY25sUWNtbGpaVDFsZUdsemRHbHVaeTVpYVdSVmJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWW1sa1pHVnlQV1Y0YVhOMGFXNW5MbUpwWkdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JrWlhCdmMybDBaV1E5WlhocGMzUnBibWN1WkdWd2IzTnBkR1ZrTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJoY25sUWNtbGpaVDExYm1sMFlYSjVYM0J5YVdObExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1UTTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpYzJWMFVISnBZMlVpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YldGeWEyVjBjR3hoWTJWZlpHVnRieTV0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdVJHbG5hWFJoYkUxaGNtdGxkSEJzWVdObFYybDBhRlIxY0hNdVluVjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW5WNU9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRVeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVFl5Q2lBZ0lDQXZMeUJzYVhOMGFXNW5JRDBnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRZNU5tVTJOemN6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTVRZZ016SUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURRNElEZ0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaWGgwY21GamRDQTFOaUE0Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZkSFZ3Y3k1d2VUb3hOalFLSUNBZ0lDOHZJR0Z0YjNWdWRGOTBiMTlpWlY5d1lXbGtJRDBnYzJWc1ppNXhkV0Z1ZEdsMGVWOXdjbWxqWlNoeGRXRnVkR2wwZVN3Z2JHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNJR0Z6YzJWMExtUmxZMmx0WVd4ektRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TnpBS0lDQWdJQzh2SUdGdGIzVnVkRjl1YjNSZmMyTmhiR1ZrWDJocFoyZ3NJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMnh2ZHlBOUlHOXdMbTExYkhjb2NISnBZMlVzSUhGMVlXNTBhWFI1S1FvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBNENpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG8zTVFvZ0lDQWdMeThnYzJOaGJHbHVaMTltWVdOMGIzSmZhR2xuYUN3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYkc5M0lEMGdiM0F1Wlhod2R5Z3hNQ3dnWVhOelpYUmZaR1ZqYVcxaGJITXBDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRjSGNLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qY3lMVGMwQ2lBZ0lDQXZMeUJmY1hWdmRHbGxiblJmYUdsbmFDd2dZVzF2ZFc1MFgzUnZYMkpsWDNCaGFXUXNJRjl5WlcxaGFXNWtaWEpmYUdsbmFDd2dYM0psYldGcGJtUmxjbDlzYjNjZ1BTQnZjQzVrYVhadGIyUjNLQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjl1YjNSZmMyTmhiR1ZrWDJocFoyZ3NJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMnh2ZHl3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYUdsbmFDd2djMk5oYkdsdVoxOW1ZV04wYjNKZmJHOTNDaUFnSUNBdkx5QXBDaUFnSUNCa2FYWnRiMlIzQ2lBZ0lDQndiM0J1SURJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdYM0YxYjNScFpXNTBYMmhwWjJnZ1BUMGdNQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCaWRYbGZjR0Y1TG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZkSFZ3Y3k1d2VUb3hOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmlkWGxmY0dGNUxuSmxZMlZwZG1WeUlEMDlJRzkzYm1WeUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUhWdVkyOTJaWElnTVRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakUyT0FvZ0lDQWdMeThnWVhOelpYSjBJR0oxZVY5d1lYa3VZVzF2ZFc1MElEMDlJR0Z0YjNWdWRGOTBiMTlpWlY5d1lXbGtDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVGMxQ2lBZ0lDQXZMeUJrWlhCdmMybDBaV1E5YkdsemRHbHVaeTVrWlhCdmMybDBaV1FnTFNCeGRXRnVkR2wwZVN3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lDMEtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pFM01Bb2dJQ0FnTHk4Z2MyVnNaaTVzYVhOMGFXNW5jMXRyWlhsZElEMGdUR2x6ZEdsdVoxWmhiSFZsS0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE56QXRNVGMyQ2lBZ0lDQXZMeUJ6Wld4bUxteHBjM1JwYm1kelcydGxlVjBnUFNCTWFYTjBhVzVuVm1Gc2RXVW9DaUFnSUNBdkx5QWdJQ0FnWW1sa1BXeHBjM1JwYm1jdVltbGtMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpGVnVhWFJoY25sUWNtbGpaVDFzYVhOMGFXNW5MbUpwWkZWdWFYUmhjbmxRY21salpTd0tJQ0FnSUM4dklDQWdJQ0JpYVdSa1pYSTliR2x6ZEdsdVp5NWlhV1JrWlhJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1ZFc1cGRHRnllVkJ5YVdObExBb2dJQ0FnTHk4Z0lDQWdJR1JsY0c5emFYUmxaRDFzYVhOMGFXNW5MbVJsY0c5emFYUmxaQ0F0SUhGMVlXNTBhWFI1TEFvZ0lDQWdMeThnS1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRjNExURTRNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzSUdGemMyVjBYMkZ0YjNWdWREMXhkV0Z1ZEdsMGVRb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVGM1Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JoYzNObGRGOWhiVzkxYm5ROWNYVmhiblJwZEhrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRTNPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pFM09DMHhPREFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTENCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TENCaGMzTmxkRjloYlc5MWJuUTljWFZoYm5ScGRIa0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5NXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11UkdsbmFYUmhiRTFoY210bGRIQnNZV05sVjJsMGFGUjFjSE11ZDJsMGFHUnlZWGRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZHpvS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakU0TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakU0TkFvZ0lDQWdMeThnYTJWNUlEMGdUR2x6ZEdsdVowdGxlU2h2ZDI1bGNqMVVlRzR1YzJWdVpHVnlMQ0JoYzNObGREMWhjM05sZEM1cFpDd2dibTl1WTJVOWJtOXVZMlVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE9EWUtJQ0FnSUM4dklHeHBjM1JwYm1jZ1BTQnpaV3htTG14cGMzUnBibWR6VzJ0bGVWMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZelk1TnpNM05EWTVObVUyTnpjekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR2x6ZEdsdVozTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFMklETXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJSEIxYzJocGJuUWdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94T0RjS0lDQWdJQzh2SUdsbUlHeHBjM1JwYm1jdVltbGtaR1Z5SUNFOUlFRmpZMjkxYm5Rb0tUb0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHSjZJSGRwZEdoa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRnNUNpQWdJQ0F2THlCc2FYTjBhVzVuTG1KcFpDd2diR2x6ZEdsdVp5NWlhV1JWYm1sMFlYSjVVSEpwWTJVc0lHRnpjMlYwTG1SbFkybHRZV3h6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZkSFZ3Y3k1d2VUbzNNQW9nSUNBZ0x5OGdZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZhR2xuYUN3Z1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmJHOTNJRDBnYjNBdWJYVnNkeWh3Y21salpTd2djWFZoYm5ScGRIa3BDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHMTFiSGNLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qY3hDaUFnSUNBdkx5QnpZMkZzYVc1blgyWmhZM1J2Y2w5b2FXZG9MQ0J6WTJGc2FXNW5YMlpoWTNSdmNsOXNiM2NnUFNCdmNDNWxlSEIzS0RFd0xDQmhjM05sZEY5a1pXTnBiV0ZzY3lrS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhod2R3b2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TnpJdE56UUtJQ0FnSUM4dklGOXhkVzkwYVdWdWRGOW9hV2RvTENCaGJXOTFiblJmZEc5ZlltVmZjR0ZwWkN3Z1gzSmxiV0ZwYm1SbGNsOW9hV2RvTENCZmNtVnRZV2x1WkdWeVgyeHZkeUE5SUc5d0xtUnBkbTF2Wkhjb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZhR2xuYUN3Z1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmJHOTNMQ0J6WTJGc2FXNW5YMlpoWTNSdmNsOW9hV2RvTENCelkyRnNhVzVuWDJaaFkzUnZjbDlzYjNjS0lDQWdJQzh2SUNrS0lDQWdJR1JwZG0xdlpIY0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk56VUtJQ0FnSUM4dklHRnpjMlZ5ZENCZmNYVnZkR2xsYm5SZmFHbG5hQ0E5UFNBd0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakU1TVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtISmxZMlZwZG1WeVBXeHBjM1JwYm1jdVltbGtaR1Z5TENCaGJXOTFiblE5WTNWeWNtVnVkRjlpYVdSZlpHVndiM05wZENrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tkMmwwYUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TVRrekNpQWdJQ0F2THlCa1pXd2djMlZzWmk1c2FYTjBhVzVuYzF0clpYbGRDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRTVOUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0hKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0lHRnRiM1Z1ZEQxelpXeG1MbXhwYzNScGJtZHpYMkp2ZUY5dFluSW9LU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPalExTFRZMkNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSURKZk5UQXdDaUFnSUNBdkx5QWdJQ0FnS3dvZ0lDQWdMeThnSUNBZ0lDTWdabTEwT2lCdlptWUtJQ0FnSUM4dklDQWdJQ0FqSUV0bGVTQnNaVzVuZEdnS0lDQWdJQzh2SUNBZ0lDQW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lEZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t5QXpNZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXJJRGdLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLeUE0Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ3NLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJeUJXWVd4MVpTQnNaVzVuZEdnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnT0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FySURnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS3lBek1nb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcklEZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0t5QTRDaUFnSUNBdkx5QWdJQ0FnS1FvZ0lDQWdMeThnSUNBZ0lDb0tJQ0FnSUM4dklDQWdJQ0FqSUdadGREb2diMjRLSUNBZ0lDOHZJQ0FnSUNBME1EQUtJQ0FnSUM4dklDa0tJQ0FnSUdsdWRHTWdOQ0F2THlBMU1EVXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRTVOUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0hKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0lHRnRiM1Z1ZEQxelpXeG1MbXhwYzNScGJtZHpYMkp2ZUY5dFluSW9LU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakU1TnkweE9Ua0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JoYzNObGRGOWhiVzkxYm5ROWJHbHpkR2x1Wnk1a1pYQnZjMmwwWldRS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qRTVPQW9nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFoYzNObGRDd2dZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd2dZWE56WlhSZllXMXZkVzUwUFd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveE9UY0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG94T1RjdE1UazVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdnWVhOelpYUmZZVzF2ZFc1MFBXeHBjM1JwYm1jdVpHVndiM05wZEdWa0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNVGd5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMWhjbXRsZEhCc1lXTmxYMlJsYlc4dWJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMa1JwWjJsMFlXeE5ZWEpyWlhSd2JHRmpaVmRwZEdoVWRYQnpMbUpwWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnBaRG9LSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qSXdNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNakV6Q2lBZ0lDQXZMeUJzYVhOMGFXNW5JRDBnYzJWc1ppNXNhWE4wYVc1bmMxdHJaWGxkQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Tm1NMk9UY3pOelEyT1RabE5qYzNNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHBjM1JwYm1keklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURFMklETXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURrS0lDQWdJSEIxYzJocGJuUWdOVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBNENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG95TVRRS0lDQWdJQzh2SUdsbUlHeHBjM1JwYm1jdVltbGtaR1Z5SUNFOUlFRmpZMjkxYm5Rb0tUb0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHSjZJR0pwWkY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qSXhOUW9nSUNBZ0x5OGdZWE56WlhKMElIVnVhWFJoY25sZmNISnBZMlVnUGlCc2FYTjBhVzVuTG1KcFpGVnVhWFJoY25sUWNtbGpaUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qSXhPQW9nSUNBZ0x5OGdiR2x6ZEdsdVp5NWlhV1FzSUd4cGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQ0JoYzNObGRDNWtaV05wYldGc2N3b2dJQ0FnWkdsbklESUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TnpBS0lDQWdJQzh2SUdGdGIzVnVkRjl1YjNSZmMyTmhiR1ZrWDJocFoyZ3NJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMnh2ZHlBOUlHOXdMbTExYkhjb2NISnBZMlVzSUhGMVlXNTBhWFI1S1FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFd0NpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG8zTVFvZ0lDQWdMeThnYzJOaGJHbHVaMTltWVdOMGIzSmZhR2xuYUN3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYkc5M0lEMGdiM0F1Wlhod2R5Z3hNQ3dnWVhOelpYUmZaR1ZqYVcxaGJITXBDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRjSGNLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qY3lMVGMwQ2lBZ0lDQXZMeUJmY1hWdmRHbGxiblJmYUdsbmFDd2dZVzF2ZFc1MFgzUnZYMkpsWDNCaGFXUXNJRjl5WlcxaGFXNWtaWEpmYUdsbmFDd2dYM0psYldGcGJtUmxjbDlzYjNjZ1BTQnZjQzVrYVhadGIyUjNLQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjl1YjNSZmMyTmhiR1ZrWDJocFoyZ3NJR0Z0YjNWdWRGOXViM1JmYzJOaGJHVmtYMnh2ZHl3Z2MyTmhiR2x1WjE5bVlXTjBiM0pmYUdsbmFDd2djMk5oYkdsdVoxOW1ZV04wYjNKZmJHOTNDaUFnSUNBdkx5QXBDaUFnSUNCa2FYWnRiMlIzQ2lBZ0lDQndiM0J1SURJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdYM0YxYjNScFpXNTBYMmhwWjJnZ1BUMGdNQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveU1qRUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2h5WldObGFYWmxjajFzYVhOMGFXNW5MbUpwWkdSbGNpd2dZVzF2ZFc1MFBXTjFjbkpsYm5SZlltbGtYMkZ0YjNWdWRDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2FXY2dPUW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWW1sa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakl5TXdvZ0lDQWdMeThnWVcxdmRXNTBYM1J2WDJKbFgySnBaQ0E5SUhObGJHWXVjWFZoYm5ScGRIbGZjSEpwWTJVb2NYVmhiblJwZEhrc0lIVnVhWFJoY25sZmNISnBZMlVzSUdGemMyVjBMbVJsWTJsdFlXeHpLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRvM01Bb2dJQ0FnTHk4Z1lXMXZkVzUwWDI1dmRGOXpZMkZzWldSZmFHbG5hQ3dnWVcxdmRXNTBYMjV2ZEY5elkyRnNaV1JmYkc5M0lEMGdiM0F1YlhWc2R5aHdjbWxqWlN3Z2NYVmhiblJwZEhrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJRzExYkhjS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPamN4Q2lBZ0lDQXZMeUJ6WTJGc2FXNW5YMlpoWTNSdmNsOW9hV2RvTENCelkyRnNhVzVuWDJaaFkzUnZjbDlzYjNjZ1BTQnZjQzVsZUhCM0tERXdMQ0JoYzNObGRGOWtaV05wYldGc2N5a0tJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pYaHdkd29nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk56SXROelFLSUNBZ0lDOHZJRjl4ZFc5MGFXVnVkRjlvYVdkb0xDQmhiVzkxYm5SZmRHOWZZbVZmY0dGcFpDd2dYM0psYldGcGJtUmxjbDlvYVdkb0xDQmZjbVZ0WVdsdVpHVnlYMnh2ZHlBOUlHOXdMbVJwZG0xdlpIY29DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMjV2ZEY5elkyRnNaV1JmYUdsbmFDd2dZVzF2ZFc1MFgyNXZkRjl6WTJGc1pXUmZiRzkzTENCelkyRnNhVzVuWDJaaFkzUnZjbDlvYVdkb0xDQnpZMkZzYVc1blgyWmhZM1J2Y2w5c2IzY0tJQ0FnSUM4dklDa0tJQ0FnSUdScGRtMXZaSGNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZOelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmZjWFZ2ZEdsbGJuUmZhR2xuYUNBOVBTQXdDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pJeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdKcFpGOXdZWGt1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakl5TmdvZ0lDQWdMeThnWVhOelpYSjBJR0pwWkY5d1lYa3VjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzFoY210bGRIQnNZV05sWDJSbGJXOHZiV0Z5YTJWMGNHeGhZMlZmZDJsMGFGOTBkWEJ6TG5CNU9qSXlOd29nSUNBZ0x5OGdZWE56WlhKMElHSnBaRjl3WVhrdVlXMXZkVzUwSUQwOUlHRnRiM1Z1ZEY5MGIxOWlaVjlpYVdRS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNak15Q2lBZ0lDQXZMeUJpYVdSa1pYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pJeU9Rb2dJQ0FnTHk4Z2MyVnNaaTVzYVhOMGFXNW5jMXRyWlhsZElEMGdUR2x6ZEdsdVoxWmhiSFZsS0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNakk1TFRJek5Rb2dJQ0FnTHk4Z2MyVnNaaTVzYVhOMGFXNW5jMXRyWlhsZElEMGdUR2x6ZEdsdVoxWmhiSFZsS0FvZ0lDQWdMeThnSUNBZ0lHUmxjRzl6YVhSbFpEMXNhWE4wYVc1bkxtUmxjRzl6YVhSbFpDd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFlYSjVVSEpwWTJVOWJHbHpkR2x1Wnk1MWJtbDBZWEo1VUhKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWW1sa1pHVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtQWEYxWVc1MGFYUjVMQW9nSUNBZ0x5OGdJQ0FnSUdKcFpGVnVhWFJoY25sUWNtbGpaVDExYm1sMFlYSjVYM0J5YVdObExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1qQXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xaGNtdGxkSEJzWVdObFgyUmxiVzh1YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxrUnBaMmwwWVd4TllYSnJaWFJ3YkdGalpWZHBkR2hVZFhCekxtRmpZMlZ3ZEY5aWFXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWTJObGNIUmZZbWxrT2dvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaVlXTmpaWEIwUW1sa0lpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNak01Q2lBZ0lDQXZMeUJyWlhrZ1BTQk1hWE4wYVc1blMyVjVLRzkzYm1WeVBWUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFBXRnpjMlYwTG1sa0xDQnViMjVqWlQxdWIyNWpaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHMWhjbXRsZEhCc1lXTmxYMlJsYlc4dmJXRnlhMlYwY0d4aFkyVmZkMmwwYUY5MGRYQnpMbkI1T2pJME1Rb2dJQ0FnTHk4Z2JHbHpkR2x1WnlBOUlITmxiR1l1YkdsemRHbHVaM05iYTJWNVhRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWmpOamszTXpjME5qazJaVFkzTnpNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzYVhOMGFXNW5jeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRGdnT0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUySURNeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdjSFZ6YUdsdWRDQTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakkwTWdvZ0lDQWdMeThnWVhOelpYSjBJR3hwYzNScGJtY3VZbWxrWkdWeUlDRTlJRUZqWTI5MWJuUW9LUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG95TkRRS0lDQWdJQzh2SUcxcGJsOXhkV0Z1ZEdsMGVTQTlJR3hwYzNScGJtY3VaR1Z3YjNOcGRHVmtJR2xtSUd4cGMzUnBibWN1WkdWd2IzTnBkR1ZrSUR3Z2JHbHpkR2x1Wnk1aWFXUWdaV3h6WlNCc2FYTjBhVzVuTG1KcFpBb2dJQ0FnUEFvZ0lDQWdZbm9nWVdOalpYQjBYMkpwWkY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lHUnBaeUF6Q2dwaFkyTmxjSFJmWW1sa1gzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakkwTndvZ0lDQWdMeThnYldsdVgzRjFZVzUwYVhSNUxDQnNhWE4wYVc1bkxtSnBaRlZ1YVhSaGNubFFjbWxqWlN3Z1lYTnpaWFF1WkdWamFXMWhiSE1LSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPamN3Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibTkwWDNOallXeGxaRjlvYVdkb0xDQmhiVzkxYm5SZmJtOTBYM05qWVd4bFpGOXNiM2NnUFNCdmNDNXRkV3gzS0hCeWFXTmxMQ0J4ZFdGdWRHbDBlU2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYlhWc2R3b2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TnpFS0lDQWdJQzh2SUhOallXeHBibWRmWm1GamRHOXlYMmhwWjJnc0lITmpZV3hwYm1kZlptRmpkRzl5WDJ4dmR5QTlJRzl3TG1WNGNIY29NVEFzSUdGemMyVjBYMlJsWTJsdFlXeHpLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmxlSEIzQ2lBZ0lDQXZMeUJ0WVhKclpYUndiR0ZqWlY5a1pXMXZMMjFoY210bGRIQnNZV05sWDNkcGRHaGZkSFZ3Y3k1d2VUbzNNaTAzTkFvZ0lDQWdMeThnWDNGMWIzUnBaVzUwWDJocFoyZ3NJR0Z0YjNWdWRGOTBiMTlpWlY5d1lXbGtMQ0JmY21WdFlXbHVaR1Z5WDJocFoyZ3NJRjl5WlcxaGFXNWtaWEpmYkc5M0lEMGdiM0F1WkdsMmJXOWtkeWdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYm05MFgzTmpZV3hsWkY5b2FXZG9MQ0JoYlc5MWJuUmZibTkwWDNOallXeGxaRjlzYjNjc0lITmpZV3hwYm1kZlptRmpkRzl5WDJocFoyZ3NJSE5qWVd4cGJtZGZabUZqZEc5eVgyeHZkd29nSUNBZ0x5OGdLUW9nSUNBZ1pHbDJiVzlrZHdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCdFlYSnJaWFJ3YkdGalpWOWtaVzF2TDIxaGNtdGxkSEJzWVdObFgzZHBkR2hmZEhWd2N5NXdlVG8zTlFvZ0lDQWdMeThnWVhOelpYSjBJRjl4ZFc5MGFXVnVkRjlvYVdkb0lEMDlJREFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1qVXdDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1lXMXZkVzUwUFdKbGMzUmZZbWxrWDJGdGIzVnVkQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveU5USXRNalUwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3Z1lYTnpaWFJmY21WalpXbDJaWEk5YkdsemRHbHVaeTVpYVdSa1pYSXNJR0Z6YzJWMFgyRnRiM1Z1ZEQxdGFXNWZjWFZoYm5ScGRIa0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2JXRnlhMlYwY0d4aFkyVmZaR1Z0Ynk5dFlYSnJaWFJ3YkdGalpWOTNhWFJvWDNSMWNITXVjSGs2TWpVeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNalV5TFRJMU5Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBXeHBjM1JwYm1jdVltbGtaR1Z5TENCaGMzTmxkRjloYlc5MWJuUTliV2x1WDNGMVlXNTBhWFI1Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdiV0Z5YTJWMGNHeGhZMlZmWkdWdGJ5OXRZWEpyWlhSd2JHRmpaVjkzYVhSb1gzUjFjSE11Y0hrNk1qWXdDaUFnSUNBdkx5QmtaWEJ2YzJsMFpXUTliR2x6ZEdsdVp5NWtaWEJ2YzJsMFpXUWdMU0J0YVc1ZmNYVmhiblJwZEhrc0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveU5qRUtJQ0FnSUM4dklHSnBaRDFzYVhOMGFXNW5MbUpwWkNBdElHMXBibDl4ZFdGdWRHbDBlU3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNBdkx5QnRZWEpyWlhSd2JHRmpaVjlrWlcxdkwyMWhjbXRsZEhCc1lXTmxYM2RwZEdoZmRIVndjeTV3ZVRveU5UWUtJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTQTlJRXhwYzNScGJtZFdZV3gxWlNnS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUcxaGNtdGxkSEJzWVdObFgyUmxiVzh2YldGeWEyVjBjR3hoWTJWZmQybDBhRjkwZFhCekxuQjVPakkxTmkweU5qSUtJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iYTJWNVhTQTlJRXhwYzNScGJtZFdZV3gxWlNnS0lDQWdJQzh2SUNBZ0lDQmlhV1JrWlhJOWJHbHpkR2x1Wnk1aWFXUmtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtWVzVwZEdGeWVWQnlhV05sUFd4cGMzUnBibWN1WW1sa1ZXNXBkR0Z5ZVZCeWFXTmxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmhjbmxRY21salpUMXNhWE4wYVc1bkxuVnVhWFJoY25sUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCa1pYQnZjMmwwWldROWJHbHpkR2x1Wnk1a1pYQnZjMmwwWldRZ0xTQnRhVzVmY1hWaGJuUnBkSGtzQ2lBZ0lDQXZMeUFnSUNBZ1ltbGtQV3hwYzNScGJtY3VZbWxrSUMwZ2JXbHVYM0YxWVc1MGFYUjVMQW9nSUNBZ0x5OGdLUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYldGeWEyVjBjR3hoWTJWZlpHVnRieTl0WVhKclpYUndiR0ZqWlY5M2FYUm9YM1IxY0hNdWNIazZNak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaVlXTmpaWEIwUW1sa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUZqWTJWd2RGOWlhV1JmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSWdZV05qWlhCMFgySnBaRjkwWlhKdVlYSjVYMjFsY21kbFFEUUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFnQUJNU0tBeVlCQ0d4cGMzUnBibWR6TVJoQUFBZUFCR2x1YVhTd01SdEJBRjh4R1JSRU1SaEVnZ2tFMlk3MnFRUnFUbi9LQkJMd2pKZ0VtMHVDTkFSTml5UFlCRktzWGZjRTQ2NnlYQVF5TkxjUkJNeUNZMFkyR2dDT0NRQUJBQm9BV1FEWEFVRUJrUUkyQXI0RG5BQ0FEQlVmZkhVQUFBQUFBQURGUkxBaVF6RVpGREVZRkJCRE1SWWlDVWs0RUNJU1JEWWFBVWtWSXhKRUZ6SUtTd0Z3QUVVQkZFUkxBVGdITWdvU1JFdzRDRElRRWtTeE1nb2tzaEt5RkxJUkpiSVFKTElCc3lKRE1SYUJBZ2xKT0JBaUVrUXhGaUlKU1RnUUpSSkVOaG9CU1JVakVrUVhOaG9DU1JVakVrUVhTd000QURFQUVrUkxBemdITWdvU1JFOERPQWdoQkJKRU1RQkxBemdSRmxCTUZsQW9URkJKdlVVQkZFUkxBamdBTVFBU1JFc0NPQlF5Q2hKRVR3STRFa2xFTWdOTUZrOERGbEJNVUNRV1RFc0JVRXhRdnlKRE1SWWlDVWs0RUNVU1JEWWFBVWtWSXhKRUZ6RUFTd0k0RVVzRE9BQXhBQkpFU3dNNEZESUtFa1JQQXpnU1NVUk1GazhDVEZCUEFoWlFLRXhRU2I1RVNTUmJTd0ZYQ0FoTEFsY1FJRXNEVnpBSVR3UlhPQWhQQkU4R0NCWlBCRkJQQTFCUEFsQk1VTDhpUXpZYUFVa1ZJeEpFRnpZYUFra1ZJeEpFRnpZYUEwa1ZJeEpFRnpFQVR3TVdVRThDRmxBb1RGQkp2a1JKVndBSVN3RlhFQ0JMQWxjd0NFOERWemdJVHdVV1R3Uk1VRThEVUU4Q1VFeFF2eUpETmhvQlNSV0JJQkpFTmhvQ1NSVWpFa1FYTmhvRFNSVWpFa1FYTVJZaUNVazRFQ0lTUkRZYUJFa1ZJeEpFRjBzREZrc0ZURkJQQXhaUUtFeFFTYjVFU1NSYlN3RWpXMHNDVnhBZ1N3TlhNQWhQQkZjNENFc0ljUUZFU3dSTENCMkJDazhEbFI5R0Frd1VSRXNJT0FBeEFCSkVTd2c0QjA4TEVrUlBDRGdJRWtSUEJFc0dDUlpQQkJaUVR3TlFUd0pRVEZDL3NURUFzaFN5RXJJUkpiSVFKTElCc3lKRE5ob0JTUlVqRWtRWFNUWWFBa2tWSXhKRUZ6RUFUd0lXVUV3V1VDaE1VRW0rUkVra1cweEpWeEFnU1U0Q1RnVkpnVEJiVGdXQk9GdE9CRElERTBFQUkwc0NjUUZFU3dSTEJoMkJDazhEbFI5R0Frd1VSTEd5Q0VzRnNnY2lzaEFrc2dHelRMeElzVEVBSVFTeUNMSUhJcklRSkxJQnM3RXhBTElVc2hLeUVTV3lFQ1N5QWJNaVF6WWFBVWtWZ1NBU1JEWWFBa2tWSXhKRUYwbE9BallhQTBrVkl4SkVGekVXSWdsSlRnVTRFQ0lTUkRZYUJFa1ZJeEpFRjA0RU5ob0ZTUlVqRWtRWFRnTk1GazhDVEZCTUZsQW9URkJKVGdTK1JFbFhBQWhPQTBsWENBaE9BMGxYRUNCSlRnSk9DVW1CTUZ0T0NZRTRXMDRJTWdNVFFRQXFTVXNJU1U0Q0RVUkxBbkVCUkV4TENoMkJDazhEbFI5R0Frd1VSTEd5Q0VzSnNnY2lzaEFrc2dHelRIRUJSRXNCVHdWSlRnTWRnUXBQQTVVZlJnSk1GRVJQQmtrNEFERUFFa1JKT0FjeUNoSkVPQWdTUkRFQVR3UlBCRkJNVUV3V1VFd1dVTDhpUXpZYUFVa1ZJeEpFRjBrMkdnSkpGU01TUkJjeEFFOENGbEJNRmxBb1RGQkpUZ0srUkVra1cwbFBBa2xYQ0FoT0JFbFhFQ0JKVGdKT0EwbUJNRnRKVGdOT0JJRTRXMDRETWdNVFJBeEJBRjFMQTA4RlNYRUJSRThEU1U0RFR3UkpUZ01kZ1FwUEE1VWZSZ0pNRkVTeE1RQ3lCN0lJSXJJUUpMSUJzN0ZKc2hKUEJFbE9BcklVVHdLeUVTV3lFQ1N5QWJOUEJFc0JDVThFVHdJSlRCWlBCRkJQQWxCTUZsQk1GbEMvSWtOTEFVTC9vQT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
