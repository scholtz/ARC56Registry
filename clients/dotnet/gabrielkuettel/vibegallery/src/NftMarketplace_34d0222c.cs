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

namespace Arc56.Generated.gabrielkuettel.vibegallery.NftMarketplace_34d0222c
{


    public class NftMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NftMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Listing : AVMObjectType
            {
                public Algorand.Address Seller { get; set; }

                public ulong Price { get; set; }

                public bool IsActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Listing Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Listing();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is bool vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Listing);
                }
                public bool Equals(Listing? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Listing left, Listing right)
                {
                    return EqualityComparer<Listing>.Default.Equals(left, right);
                }
                public static bool operator !=(Listing left, Listing right)
                {
                    return !(left == right);
                }

            }

            public class ListingKey : AVMObjectType
            {
                public Algorand.Address Seller { get; set; }

                public ulong AssetId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
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

        }

        ///<summary>
        ///Initialize the marketplace with the creator as admin
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the application into an NFT asset so it can receive transfers
        ///</summary>
        /// <param name="mbrPay">Payment to cover the 0.1 ALGO asset MBR </param>
        /// <param name="asset">The NFT asset to opt into </param>
        public async Task OptInToAsset(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 105, 87, 91, 64 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 105, 87, 91, 64 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///List an NFT for sale on the marketplace
        ///</summary>
        /// <param name="mbrPay">Payment to cover box storage MBR </param>
        /// <param name="nftXfer">Asset transfer of the NFT to the contract </param>
        /// <param name="price">Sale price in microALGO </param>
        public async Task ListNft(PaymentTransaction mbrPay, AssetTransferTransaction nftXfer, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay, nftXfer });
            byte[] abiHandle = { 39, 179, 62, 197 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, nftXfer, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ListNft_Transactions(PaymentTransaction mbrPay, AssetTransferTransaction nftXfer, ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay, nftXfer });
            byte[] abiHandle = { 39, 179, 62, 197 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, nftXfer, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy an NFT from the marketplace
        ///</summary>
        /// <param name="payment">Payment for the NFT purchase </param>
        /// <param name="seller">The seller's account </param>
        /// <param name="asset">The NFT asset to purchase </param>
        public async Task BuyNft(PaymentTransaction payment, Algorand.Address seller, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 240, 188, 118, 124 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, payment, sellerAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyNft_Transactions(PaymentTransaction payment, Algorand.Address seller, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 240, 188, 118, 124 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, sellerAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel a listing and reclaim the NFT
        ///</summary>
        /// <param name="asset">The NFT asset to reclaim </param>
        public async Task CancelListing(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 57, 212, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelListing_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 57, 212, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the price of an existing listing
        ///</summary>
        /// <param name="asset">The NFT asset to update price for </param>
        /// <param name="newPrice">The new price in microALGO </param>
        public async Task UpdatePrice(ulong asset, ulong newPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 82, 89, 55 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var newPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceAbi.From(newPrice);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, newPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePrice_Transactions(ulong asset, ulong newPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 82, 89, 55 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var newPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceAbi.From(newPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, newPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin withdraws collected commission
        ///</summary>
        public async Task WithdrawCommission(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 108, 73, 80 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawCommission_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 108, 73, 80 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get listing information (readonly)
        ///</summary>
        /// <param name="seller">The seller's account </param>
        /// <param name="assetId">The NFT asset ID </param>
        public async Task<Structs.Listing> GetListing(Algorand.Address seller, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 106, 16, 166 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.SimApp(new List<object> { abiHandle, sellerAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Listing.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetListing_Transactions(Algorand.Address seller, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 106, 16, 166 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a listing exists
        ///</summary>
        /// <param name="seller">The seller's account </param>
        /// <param name="assetId">The NFT asset ID </param>
        public async Task<bool> ListingExists(Algorand.Address seller, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 180, 27, 166 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.SimApp(new List<object> { abiHandle, sellerAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListingExists_Transactions(Algorand.Address seller, ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 180, 27, 166 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the collected commission amount
        ///</summary>
        public async Task<ulong> GetCollectedCommission(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 53, 83, 102 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCollectedCommission_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 53, 83, 102 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the admin address
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmZ0TWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTGlzdGluZyI6W3sibmFtZSI6InNlbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNBY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9XSwiTGlzdGluZ0tleSI6W3sibmFtZSI6InNlbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXNzZXRJZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgbWFya2V0cGxhY2Ugd2l0aCB0aGUgY3JlYXRvciBhcyBhZG1pbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJblRvQXNzZXQiLCJkZXNjIjoiT3B0IHRoZSBhcHBsaWNhdGlvbiBpbnRvIGFuIE5GVCBhc3NldCBzbyBpdCBjYW4gcmVjZWl2ZSB0cmFuc2ZlcnMiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5IiwiZGVzYyI6IlBheW1lbnQgdG8gY292ZXIgdGhlIDAuMSBBTEdPIGFzc2V0IE1CUiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIE5GVCBhc3NldCB0byBvcHQgaW50byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsaXN0TmZ0IiwiZGVzYyI6Ikxpc3QgYW4gTkZUIGZvciBzYWxlIG9uIHRoZSBtYXJrZXRwbGFjZSIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXkiLCJkZXNjIjoiUGF5bWVudCB0byBjb3ZlciBib3ggc3RvcmFnZSBNQlIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmZ0WGZlciIsImRlc2MiOiJBc3NldCB0cmFuc2ZlciBvZiB0aGUgTkZUIHRvIHRoZSBjb250cmFjdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjoiU2FsZSBwcmljZSBpbiBtaWNyb0FMR08iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5TmZ0IiwiZGVzYyI6IkJ1eSBhbiBORlQgZnJvbSB0aGUgbWFya2V0cGxhY2UiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJQYXltZW50IGZvciB0aGUgTkZUIHB1cmNoYXNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6IlRoZSBzZWxsZXIncyBhY2NvdW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgTkZUIGFzc2V0IHRvIHB1cmNoYXNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbExpc3RpbmciLCJkZXNjIjoiQ2FuY2VsIGEgbGlzdGluZyBhbmQgcmVjbGFpbSB0aGUgTkZUIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBORlQgYXNzZXQgdG8gcmVjbGFpbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQcmljZSIsImRlc2MiOiJVcGRhdGUgdGhlIHByaWNlIG9mIGFuIGV4aXN0aW5nIGxpc3RpbmciLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIE5GVCBhc3NldCB0byB1cGRhdGUgcHJpY2UgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdQcmljZSIsImRlc2MiOiJUaGUgbmV3IHByaWNlIGluIG1pY3JvQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd0NvbW1pc3Npb24iLCJkZXNjIjoiQWRtaW4gd2l0aGRyYXdzIGNvbGxlY3RlZCBjb21taXNzaW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldExpc3RpbmciLCJkZXNjIjoiR2V0IGxpc3RpbmcgaW5mb3JtYXRpb24gKHJlYWRvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6IlRoZSBzZWxsZXIncyBhY2NvdW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkIiwiZGVzYyI6IlRoZSBORlQgYXNzZXQgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LGJvb2wpIiwic3RydWN0IjoiTGlzdGluZyIsImRlc2MiOiJUaGUgbGlzdGluZyBkZXRhaWxzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsaXN0aW5nRXhpc3RzIiwiZGVzYyI6IkNoZWNrIGlmIGEgbGlzdGluZyBleGlzdHMiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxlciIsImRlc2MiOiJUaGUgc2VsbGVyJ3MgYWNjb3VudCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOiJUaGUgTkZUIGFzc2V0IElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUcnVlIGlmIGxpc3RpbmcgZXhpc3RzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb2xsZWN0ZWRDb21taXNzaW9uIiwiZGVzYyI6IkdldCB0aGUgY29sbGVjdGVkIGNvbW1pc3Npb24gYW1vdW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSB0b3RhbCBjb21taXNzaW9uIGNvbGxlY3RlZCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWRtaW4iLCJkZXNjIjoiR2V0IHRoZSBhZG1pbiBhZGRyZXNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYWRtaW4gYWNjb3VudCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDldLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgYnV5IHlvdXIgb3duIE5GVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMl0sImVycm9yTWVzc2FnZSI6Ikxpc3RpbmcgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTcsNDkxLDU3NCw2NjZdLCJlcnJvck1lc3NhZ2UiOiJMaXN0aW5nIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY2LDU5Ml0sImVycm9yTWVzc2FnZSI6Ikxpc3RpbmcgaXMgbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2Ml0sImVycm9yTWVzc2FnZSI6Ik1CUiBwYXltZW50IGluc3VmZmljaWVudCBmb3IgYm94IHN0b3JhZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTRdLCJlcnJvck1lc3NhZ2UiOiJNQlIgcGF5bWVudCBtdXN0IGJlIHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3N10sImVycm9yTWVzc2FnZSI6Ik11c3QgdHJhbnNmZXIgZXhhY3RseSAxIE5GVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MF0sImVycm9yTWVzc2FnZSI6Ik5GVCBtdXN0IGJlIHNlbnQgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg1XSwiZXJyb3JNZXNzYWdlIjoiTkZUIHNlbmRlciBtdXN0IGJlIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxN10sImVycm9yTWVzc2FnZSI6Ik5vIGNvbW1pc3Npb24gdG8gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB3aXRoZHJhdyBjb21taXNzaW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBzZWxsZXIgY2FuIGNhbmNlbCBsaXN0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBzZWxsZXIgY2FuIHVwZGF0ZSBwcmljZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgaW5zdWZmaWNpZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2LDM5NV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgYXNzZXQgTUJSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ2LDU2MF0sImVycm9yTWVzc2FnZSI6IlByaWNlIG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzRdLCJlcnJvck1lc3NhZ2UiOiJTZWxsZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDYsNjA5LDYxNSw2MjUsNzE3LDcyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNCw2NDcsNjgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NywyNDMsMzQyLDQ3Niw1NDgsNTU3LDY1NSw2OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5LDIyNSwzMjVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dOQ0F6TlRNd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVkyOXNiR1ZqZEdWa1EyOXRiV2x6YzJsdmJpSWdJbXdpSUNKaFpHMXBiaUlnTUhneE5URm1OMk0zTlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCamIyeHNaV04wWldSRGIyMXRhWE56YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjJ4c1pXTjBaV1JEYjIxdGFYTnphVzl1SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXkwME5Bb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzVldsdWRITTZJRElzSUdkc2IySmhiRUo1ZEdWek9pQXhJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk9ablJOWVhKclpYUndiR0ZqWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURZNU5UYzFZalF3SURCNE1qZGlNek5sWXpVZ01IaG1NR0pqTnpZM1l5QXdlR0kyTXpsa05HSmpJREI0T1RJMU1qVTVNemNnTUhnek5qWmpORGsxTUNBd2VEbGxObUV4TUdFMklEQjRNVEZpTkRGaVlUWWdNSGd4WXpNMU5UTTJOaUF3ZUdGak9HSXlOR1JsSUM4dklHMWxkR2h2WkNBaWIzQjBTVzVVYjBGemMyVjBLSEJoZVN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliR2x6ZEU1bWRDaHdZWGtzWVhobVpYSXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1KMWVVNW1kQ2h3WVhrc1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMkZ1WTJWc1RHbHpkR2x1WnloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFVISnBZMlVvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZDBOdmJXMXBjM05wYjI0b0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRFeHBjM1JwYm1jb1lXUmtjbVZ6Y3l4MWFXNTBOalFwS0dGa1pISmxjM01zZFdsdWREWTBMR0p2YjJ3cElpd2diV1YwYUc5a0lDSnNhWE4wYVc1blJYaHBjM1J6S0dGa1pISmxjM01zZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRU52Ykd4bFkzUmxaRU52YlcxcGMzTnBiMjRvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFFXUnRhVzRvS1dGa1pISmxjM01pQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdmNIUkpibFJ2UVhOelpYUWdiR2x6ZEU1bWRDQmlkWGxPWm5RZ1kyRnVZMlZzVEdsemRHbHVaeUIxY0dSaGRHVlFjbWxqWlNCM2FYUm9aSEpoZDBOdmJXMXBjM05wYjI0Z1oyVjBUR2x6ZEdsdVp5QnNhWE4wYVc1blJYaHBjM1J6SUdkbGRFTnZiR3hsWTNSbFpFTnZiVzFwYzNOcGIyNGdaMlYwUVdSdGFXNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME15MDBOQW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2daMnh2WW1Gc1ZXbHVkSE02SURJc0lHZHNiMkpoYkVKNWRHVnpPaUF4SUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPWm5STllYSnJaWFJ3YkdGalpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJoWkcxcGJpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ga2JXbHVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBPWm5STllYSnJaWFJ3YkdGalpTNXZjSFJKYmxSdlFYTnpaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUkpibFJ2UVhOelpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUc5d2RFbHVWRzlCYzNObGRDaHRZbkpRWVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWVhOelpYSjBLRzFpY2xCaGVTNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ2RRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWVhCd0p5a0tJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCaGMzTmxjblFvYldKeVVHRjVMbUZ0YjNWdWRDQStQU0F4TURCZk1EQXdMQ0FuVUdGNWJXVnVkQ0J0ZFhOMElHTnZkbVZ5SUdGemMyVjBJRTFDVWljcENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd0lDOHZJREV3TURBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1kyOTJaWElnWVhOelpYUWdUVUpTQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56SXROemtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56SXROemdLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56SXROemtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJRzl3ZEVsdVZHOUJjM05sZENodFluSlFZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1c2FYTjBUbVowVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JHbHpkRTVtZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdiR2x6ZEU1bWRDaHRZbkpRWVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z2JtWjBXR1psY2pvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVMQ0J3Y21salpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnWVhOelpYSjBLSEJ5YVdObElENGdNQ3dnSjFCeWFXTmxJRzExYzNRZ1ltVWdjRzl6YVhScGRtVW5LUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnBZMlVnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvYldKeVVHRjVMbkpsWTJWcGRtVnlJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnSjAxQ1VpQndZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZWEJ3SnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVFVKU0lIQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmhjSEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaWNsQmhlUzVoYlc5MWJuUWdQajBnUWs5WVgwMUNVaXdnSjAxQ1VpQndZWGx0Wlc1MElHbHVjM1ZtWm1samFXVnVkQ0JtYjNJZ1ltOTRJSE4wYjNKaFoyVW5LUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2x1ZEdNZ05DQXZMeUF6TlRNd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJOUWxJZ2NHRjViV1Z1ZENCcGJuTjFabVpwWTJsbGJuUWdabTl5SUdKdmVDQnpkRzl5WVdkbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVablJZWm1WeUxtRnpjMlYwVW1WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENBblRrWlVJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QmhjSEFuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNUdWQ0J0ZFhOMElHSmxJSE5sYm5RZ2RHOGdZWEJ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENodVpuUllabVZ5TG1GemMyVjBRVzF2ZFc1MElEMDlQU0JWYVc1ME5qUW9NU2tzSUNkTmRYTjBJSFJ5WVc1elptVnlJR1Y0WVdOMGJIa2dNU0JPUmxRbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSFJ5WVc1elptVnlJR1Y0WVdOMGJIa2dNU0JPUmxRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZWE56WlhKMEtHNW1kRmhtWlhJdWMyVnVaR1Z5SUQwOVBTQlVlRzR1YzJWdVpHVnlMQ0FuVGtaVUlITmxibVJsY2lCdGRYTjBJR0psSUdOaGJHeGxjaWNwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1R1ZDQnpaVzVrWlhJZ2JYVnpkQ0JpWlNCallXeHNaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBJRDBnYm1aMFdHWmxjaTU0Wm1WeVFYTnpaWFFLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdZMjl1YzNRZ2JHbHpkR2x1WjB0bGVUb2dUR2x6ZEdsdVowdGxlU0E5SUhzZ2MyVnNiR1Z5T2lCVWVHNHVjMlZ1WkdWeUxDQmhjM05sZEVsa09pQmhjM05sZEM1cFpDQjlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnYkdsemRHbHVaM01nUFNCQ2IzaE5ZWEE4VEdsemRHbHVaMHRsZVN3Z1RHbHpkR2x1Wno0b2V5QnJaWGxRY21WbWFYZzZJQ2RzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbXhwYzNScGJtZHpLR3hwYzNScGJtZExaWGtwTG1WNGFYTjBjeXdnSjB4cGMzUnBibWNnWVd4eVpXRmtlU0JsZUdsemRITW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1hWE4wYVc1bklHRnNjbVZoWkhrZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QnpaV3hzWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0TFRFeE1nb2dJQ0FnTHk4Z2RHaHBjeTVzYVhOMGFXNW5jeWhzYVhOMGFXNW5TMlY1S1M1MllXeDFaU0E5SUhzS0lDQWdJQzh2SUNBZ2MyVnNiR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQndjbWxqWlRvZ2NISnBZMlVzQ2lBZ0lDQXZMeUFnSUdselFXTjBhWFpsT2lCMGNuVmxMQW9nSUNBZ0x5OGdmUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdiR2x6ZEU1bWRDaHRZbkpRWVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z2JtWjBXR1psY2pvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVMQ0J3Y21salpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1aWRYbE9ablJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYbE9ablE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXhDaUFnSUNBdkx5QmlkWGxPWm5Rb2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCelpXeHNaWEk2SUVGalkyOTFiblFzSUdGemMyVjBPaUJCYzNObGRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeUNpQWdJQ0F2THlCamIyNXpkQ0JzYVhOMGFXNW5TMlY1T2lCTWFYTjBhVzVuUzJWNUlEMGdleUJ6Wld4c1pYSTZJSE5sYkd4bGNpd2dZWE56WlhSSlpEb2dZWE56WlhRdWFXUWdmUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHeHBjM1JwYm1keklEMGdRbTk0VFdGd1BFeHBjM1JwYm1kTFpYa3NJRXhwYzNScGJtYytLSHNnYTJWNVVISmxabWw0T2lBbmJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG14cGMzUnBibWR6S0d4cGMzUnBibWRMWlhrcExtVjRhWE4wY3l3Z0oweHBjM1JwYm1jZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCTWFYTjBhVzVuSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCamIyNXpkQ0JzYVhOMGFXNW5JRDBnWTJ4dmJtVW9kR2hwY3k1c2FYTjBhVzVuY3loc2FYTjBhVzVuUzJWNUtTNTJZV3gxWlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9iR2x6ZEdsdVp5NXBjMEZqZEdsMlpTd2dKMHhwYzNScGJtY2dhWE1nYm05MElHRmpkR2wyWlNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNekl3SUM4dklETXlNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR2x6ZEdsdVp5QnBjeUJ1YjNRZ1lXTjBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QmhjM05sY25Rb2JHbHpkR2x1Wnk1elpXeHNaWElnUFQwOUlITmxiR3hsY2l3Z0oxTmxiR3hsY2lCdGFYTnRZWFJqYUNjcENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMlZzYkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE14Q2lBZ0lDQXZMeUJqYjI1emRDQndjbWxqWlNBOUlHeHBjM1JwYm1jdWNISnBZMlVLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJqYjI1emRDQmpiMjF0YVhOemFXOXVPaUIxYVc1ME5qUWdQU0FvY0hKcFkyVWdLaUJWYVc1ME5qUW9RMDlOVFVsVFUwbFBUbDlPVlUxRlVrRlVUMUlwS1NBdklGVnBiblEyTkNoRFQwMU5TVk5UU1U5T1gwUkZUazlOU1U1QlZFOVNLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMUlDOHZJREkxQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURFd01EQWdMeThnTVRBd01Bb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdZMjl1YzNRZ2MyVnNiR1Z5VUhKdlkyVmxaSE02SUhWcGJuUTJOQ0E5SUhCeWFXTmxJQzBnWTI5dGJXbHpjMmx2YmdvZ0lDQWdaSFZ3TWdvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENBblVHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjQ2NwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJoY0hBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQndjbWxqWlN3Z0oxQmhlVzFsYm5RZ2FXNXpkV1ptYVdOcFpXNTBKeWtLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCcGJuTjFabVpwWTJsbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUNFOVBTQnpaV3hzWlhJc0lDZERZVzV1YjNRZ1luVjVJSGx2ZFhJZ2IzZHVJRTVHVkNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRZVzV1YjNRZ1luVjVJSGx2ZFhJZ2IzZHVJRTVHVkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNeTB4TlRBS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGNLSUNBZ0lDOHZJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME15MHhORGtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Td0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRekxURTFNQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU15MHhOVGtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJ6Wld4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6Wld4c1pYSlFjbTlqWldWa2N5d0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXpMVEUxT0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhObGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhObGJHeGxjbEJ5YjJObFpXUnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVM0NpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UTXRNVFU1Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nYzJWc2JHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nYzJWc2JHVnlVSEp2WTJWbFpITXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QjBhR2x6TG1OdmJHeGxZM1JsWkVOdmJXMXBjM05wYjI0dWRtRnNkV1VnUFNCMGFHbHpMbU52Ykd4bFkzUmxaRU52YlcxcGMzTnBiMjR1ZG1Gc2RXVWdLeUJqYjIxdGFYTnphVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCamIyeHNaV04wWldSRGIyMXRhWE56YVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjJ4c1pXTjBaV1JEYjIxdGFYTnphVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNZ29nSUNBZ0x5OGdkR2hwY3k1amIyeHNaV04wWldSRGIyMXRhWE56YVc5dUxuWmhiSFZsSUQwZ2RHaHBjeTVqYjJ4c1pXTjBaV1JEYjIxdGFYTnphVzl1TG5aaGJIVmxJQ3NnWTI5dGJXbHpjMmx2YmdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnWTI5c2JHVmpkR1ZrUTI5dGJXbHpjMmx2YmlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjlzYkdWamRHVmtRMjl0YldsemMybHZiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklIUm9hWE11WTI5c2JHVmpkR1ZrUTI5dGJXbHpjMmx2Ymk1MllXeDFaU0E5SUhSb2FYTXVZMjlzYkdWamRHVmtRMjl0YldsemMybHZiaTUyWVd4MVpTQXJJR052YlcxcGMzTnBiMjRLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QjBhR2x6TG14cGMzUnBibWR6S0d4cGMzUnBibWRMWlhrcExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpndE1UYzBDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2djMlZzYkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dRazlZWDAxQ1Vpd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01Rb2dJQ0FnTHk4Z1lXMXZkVzUwT2lCQ1QxaGZUVUpTTEFvZ0lDQWdhVzUwWXlBMElDOHZJRE0xTXpBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyT0MweE56TUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQnpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQkNUMWhmVFVKU0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpndE1UYzBDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2djMlZzYkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dRazlZWDAxQ1Vpd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklHSjFlVTVtZENod1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUhObGJHeGxjam9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1allXNWpaV3hNYVhOMGFXNW5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGdVkyVnNUR2x6ZEdsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUdOaGJtTmxiRXhwYzNScGJtY29ZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJqYjI1emRDQnNhWE4wYVc1blMyVjVPaUJNYVhOMGFXNW5TMlY1SUQwZ2V5QnpaV3hzWlhJNklGUjRiaTV6Wlc1a1pYSXNJR0Z6YzJWMFNXUTZJR0Z6YzJWMExtbGtJSDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2JHbHpkR2x1WjNNZ1BTQkNiM2hOWVhBOFRHbHpkR2x1WjB0bGVTd2dUR2x6ZEdsdVp6NG9leUJyWlhsUWNtVm1hWGc2SUNkc0p5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YkdsemRHbHVaM01vYkdsemRHbHVaMHRsZVNrdVpYaHBjM1J6TENBblRHbHpkR2x1WnlCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUV4cGMzUnBibWNnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RZS0lDQWdJQzh2SUdOdmJuTjBJR3hwYzNScGJtY2dQU0JqYkc5dVpTaDBhR2x6TG14cGMzUnBibWR6S0d4cGMzUnBibWRMWlhrcExuWmhiSFZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHNhWE4wYVc1bkxuTmxiR3hsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjA5dWJIa2djMlZzYkdWeUlHTmhiaUJqWVc1alpXd2diR2x6ZEdsdVp5Y3BDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCelpXeHNaWElnWTJGdUlHTmhibU5sYkNCc2FYTjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3dMVEU1TndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQXhMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3lDaUFnSUNBdkx5QmhjM05sZEZKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOQW9nSUNBZ0x5OGdZWE56WlhSQmJXOTFiblE2SURFc0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrd0xURTVOZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGsxQ2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RBdE1UazNDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURFc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBd0NpQWdJQ0F2THlCMGFHbHpMbXhwYzNScGJtZHpLR3hwYzNScGJtZExaWGtwTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRE10TWpBNUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJRUpQV0Y5TlFsSXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EVUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnWVcxdmRXNTBPaUJDVDFoZlRVSlNMQW9nSUNBZ2FXNTBZeUEwSUM4dklETTFNekF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdNeTB5TURnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dRazlZWDAxQ1Vpd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TndvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBekxUSXdPUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCQ1QxaGZUVUpTTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TVFvZ0lDQWdMeThnWTJGdVkyVnNUR2x6ZEdsdVp5aGhjM05sZERvZ1FYTnpaWFFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s1bWRFMWhjbXRsZEhCc1lXTmxMblZ3WkdGMFpWQnlhV05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsVUhKcFkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFM0NpQWdJQ0F2THlCMWNHUmhkR1ZRY21salpTaGhjM05sZERvZ1FYTnpaWFFzSUc1bGQxQnlhV05sT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRnS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkUWNtbGpaU0ErSURBc0lDZFFjbWxqWlNCdGRYTjBJR0psSUhCdmMybDBhWFpsSnlrS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRkJ5YVdObElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNakFLSUNBZ0lDOHZJR052Ym5OMElHeHBjM1JwYm1kTFpYazZJRXhwYzNScGJtZExaWGtnUFNCN0lITmxiR3hsY2pvZ1ZIaHVMbk5sYm1SbGNpd2dZWE56WlhSSlpEb2dZWE56WlhRdWFXUWdmUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdiR2x6ZEdsdVozTWdQU0JDYjNoTllYQThUR2x6ZEdsdVowdGxlU3dnVEdsemRHbHVaejRvZXlCclpYbFFjbVZtYVhnNklDZHNKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYkNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJHbHpkR2x1WjNNb2JHbHpkR2x1WjB0bGVTa3VaWGhwYzNSekxDQW5UR2x6ZEdsdVp5QmtiMlZ6SUc1dmRDQmxlR2x6ZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFeHBjM1JwYm1jZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qUUtJQ0FnSUM4dklHTnZibk4wSUd4cGMzUnBibWNnUFNCamJHOXVaU2gwYUdsekxteHBjM1JwYm1kektHeHBjM1JwYm1kTFpYa3BMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUdGemMyVnlkQ2hzYVhOMGFXNW5Mbk5sYkd4bGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0owOXViSGtnYzJWc2JHVnlJR05oYmlCMWNHUmhkR1VnY0hKcFkyVW5LUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdSMWNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhObGJHeGxjaUJqWVc0Z2RYQmtZWFJsSUhCeWFXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMkNpQWdJQ0F2THlCaGMzTmxjblFvYkdsemRHbHVaeTVwYzBGamRHbDJaU3dnSjB4cGMzUnBibWNnYVhNZ2JtOTBJR0ZqZEdsMlpTY3BDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURNeU1DQXZMeUF6TWpBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWVhOelpYSjBJQzh2SUV4cGMzUnBibWNnYVhNZ2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5T1MweU16TUtJQ0FnSUM4dklIUm9hWE11YkdsemRHbHVaM01vYkdsemRHbHVaMHRsZVNrdWRtRnNkV1VnUFNCN0NpQWdJQ0F2THlBZ0lITmxiR3hsY2pvZ2JHbHpkR2x1Wnk1elpXeHNaWElzQ2lBZ0lDQXZMeUFnSUhCeWFXTmxPaUJ1WlhkUWNtbGpaU3dLSUNBZ0lDOHZJQ0FnYVhOQlkzUnBkbVU2SUhSeWRXVXNDaUFnSUNBdkx5QjlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOd29nSUNBZ0x5OGdkWEJrWVhSbFVISnBZMlVvWVhOelpYUTZJRUZ6YzJWMExDQnVaWGRRY21salpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1M2FYUm9aSEpoZDBOdmJXMXBjM05wYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGQwTnZiVzFwYzNOcGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpReENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTd2dKMDl1YkhrZ1lXUnRhVzRnWTJGdUlIZHBkR2hrY21GM0lHTnZiVzFwYzNOcGIyNG5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExDQW5UMjVzZVNCaFpHMXBiaUJqWVc0Z2QybDBhR1J5WVhjZ1kyOXRiV2x6YzJsdmJpY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjNhWFJvWkhKaGR5QmpiMjF0YVhOemFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRekNpQWdJQ0F2THlCamIyNXpkQ0JqYjIxdGFYTnphVzl1SUQwZ2RHaHBjeTVqYjJ4c1pXTjBaV1JEYjIxdGFYTnphVzl1TG5aaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJqYjJ4c1pXTjBaV1JEYjIxdGFYTnphVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiMnhzWldOMFpXUkRiMjF0YVhOemFXOXVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME13b2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dGJXbHpjMmx2YmlBOUlIUm9hWE11WTI5c2JHVmpkR1ZrUTI5dGJXbHpjMmx2Ymk1MllXeDFaUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRRS0lDQWdJQzh2SUdGemMyVnlkQ2hqYjIxdGFYTnphVzl1SUQ0Z01Dd2dKMDV2SUdOdmJXMXBjM05wYjI0Z2RHOGdkMmwwYUdSeVlYY25LUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdZMjl0YldsemMybHZiaUIwYnlCM2FYUm9aSEpoZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QmpiMnhzWldOMFpXUkRiMjF0YVhOemFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamIyeHNaV04wWldSRGIyMXRhWE56YVc5dUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTndvZ0lDQWdMeThnZEdocGN5NWpiMnhzWldOMFpXUkRiMjF0YVhOemFXOXVMblpoYkhWbElEMGdWV2x1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRBdE1qVTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkR2hwY3k1aFpHMXBiaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR052YlcxcGMzTnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVElLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFpHMXBiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5USUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV3TFRJMU5Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmpiMjF0YVhOemFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVMENpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UQXRNalUyQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nZEdocGN5NWhaRzFwYmk1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdOdmJXMXBjM05wYjI0c0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNNUNpQWdJQ0F2THlCM2FYUm9aSEpoZDBOdmJXMXBjM05wYjI0b0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1blpYUk1hWE4wYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVEdsemRHbHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qVXRNalkyQ2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJR2RsZEV4cGMzUnBibWNvYzJWc2JHVnlPaUJCWTJOdmRXNTBMQ0JoYzNObGRFbGtPaUIxYVc1ME5qUXBPaUJNYVhOMGFXNW5JSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpjS0lDQWdJQzh2SUdOdmJuTjBJR3hwYzNScGJtZExaWGs2SUV4cGMzUnBibWRMWlhrZ1BTQjdJSE5sYkd4bGNqb2djMlZzYkdWeUxDQmhjM05sZEVsa09pQmhjM05sZEVsa0lIMEtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCc2FYTjBhVzVuY3lBOUlFSnZlRTFoY0R4TWFYTjBhVzVuUzJWNUxDQk1hWE4wYVc1blBpaDdJR3RsZVZCeVpXWnBlRG9nSjJ3bklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnNJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVzYVhOMGFXNW5jeWhzYVhOMGFXNW5TMlY1S1M1bGVHbHpkSE1zSUNkTWFYTjBhVzVuSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVEdsemRHbHVaeUJrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyT1FvZ0lDQWdMeThnY21WMGRYSnVJR05zYjI1bEtIUm9hWE11YkdsemRHbHVaM01vYkdsemRHbHVaMHRsZVNrdWRtRnNkV1VwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOalV0TWpZMkNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUdkbGRFeHBjM1JwYm1jb2MyVnNiR1Z5T2lCQlkyTnZkVzUwTENCaGMzTmxkRWxrT2lCMWFXNTBOalFwT2lCTWFYTjBhVzVuSUhzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rNW1kRTFoY210bGRIQnNZV05sTG14cGMzUnBibWRGZUdsemRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYVhOMGFXNW5SWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzT0MweU56a0tJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2JHbHpkR2x1WjBWNGFYTjBjeWh6Wld4c1pYSTZJRUZqWTI5MWJuUXNJR0Z6YzJWMFNXUTZJSFZwYm5RMk5DazZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0TUFvZ0lDQWdMeThnWTI5dWMzUWdiR2x6ZEdsdVowdGxlVG9nVEdsemRHbHVaMHRsZVNBOUlIc2djMlZzYkdWeU9pQnpaV3hzWlhJc0lHRnpjMlYwU1dRNklHRnpjMlYwU1dRZ2ZRb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUd4cGMzUnBibWR6SUQwZ1FtOTRUV0Z3UEV4cGMzUnBibWRMWlhrc0lFeHBjM1JwYm1jK0tIc2dhMlY1VUhKbFptbDRPaUFuYkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltd2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9ERUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbXhwYzNScGJtZHpLR3hwYzNScGJtZExaWGtwTG1WNGFYTjBjd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamM0TFRJM09Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCc2FYTjBhVzVuUlhocGMzUnpLSE5sYkd4bGNqb2dRV05qYjNWdWRDd2dZWE56WlhSSlpEb2dkV2x1ZERZMEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE9ablJOWVhKclpYUndiR0ZqWlM1blpYUkRiMnhzWldOMFpXUkRiMjF0YVhOemFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFEyOXNiR1ZqZEdWa1EyOXRiV2x6YzJsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RBS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtTnZiR3hsWTNSbFpFTnZiVzFwYzNOcGIyNHVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHTnZiR3hsWTNSbFpFTnZiVzFwYzNOcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmJHeGxZM1JsWkVOdmJXMXBjM05wYjI0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1amIyeHNaV04wWldSRGIyMXRhWE56YVc5dUxuWmhiSFZsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9DMHlPRGtLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdaMlYwUTI5c2JHVmpkR1ZrUTI5dGJXbHpjMmx2YmlncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUbVowVFdGeWEyVjBjR3hoWTJVdVoyVjBRV1J0YVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpuUmZiV0Z5YTJWMGNHeGhZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RrS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJoWkcxcGJpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ga2JXbHVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprM0xUSTVPQW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5Qm5aWFJCWkcxcGJpZ3BPaUJCWTJOdmRXNTBJSHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBSUJPU1RBaVlFRTJOdmJHeGxZM1JsWkVOdmJXMXBjM05wYjI0QmJBVmhaRzFwYmdRVkgzeDFNUmhBQUFNb0kyY3hHUlJFTVJoQkFFNkNDZ1JwVjF0QUJDZXpQc1VFOEx4MmZBUzJPZFM4QkpKU1dUY0VObXhKVUFTZWFoQ21CQkcwRzZZRUhEVlRaZ1NzaXlUZU5ob0FqZ29BRlFCTUFMRUJTZ0dTQWRFQjlBSVlBajhDU2dDQUJMaEVlelkyR2dDT0FRQUJBQ294QUdjaVF6RVdJZ2xKT0JBaUVrUTJHZ0ZKRlNRU1JCZExBVGdITWdvU1JFdzRDSUdnalFZUFJMRXlDaU95RXJJVXNoRWxzaEFqc2dHeklrTXhGb0VDQ1VrNEVDSVNSREVXSWdsSk9CQWxFa1EyR2dGSkZTUVNSQmRKUkVzQ09BY3lDaEpFVHdJNENDRUVEMFJMQVRnVU1nb1NSRXNCT0JJaUVrUkxBVGdBTVFBU1JFdzRFVEVBVEJaUUtVeFFTYjFGQVJSRU1RQlBBaFpRZ0FHQVVMOGlRekVXSWdsSk9CQWlFa1EyR2dGSkZZRWdFa1EyR2dKSkZTUVNSQmRKRmtzQ1RGQXBURkJKdlVVQlJFbStTRW1Cd0FKVFJFbFhBQ0JMQkJKRWdTQmJTWUVaQzRIb0J3cEtDVXNHT0FjeUNoSkVUd1k0Q0U4REQwUXhBRXNGRTBTeE1RQWlzaEpQQkxJUnNoUWxzaEFqc2dHenNiSUlTd0t5QnlLeUVDT3lBYk1qS0dWRUNDaE1aN3hJc1NFRXNnaXlCeUt5RUNPeUFiTWlRellhQVVrVkpCSkVGekVBU3dFV1VDbE1VRW05UlFGRVNiNUlWd0FnTVFBU1JMRXhBQ0t5RWs4Q3NoR3lGQ1d5RUNPeUFiTzhTTEV4QUNFRXNnaXlCeUt5RUNPeUFiTWlRellhQVVrVkpCSkVGellhQWtrVkpCSkVGMGxFTVFCUEFoWlFLVXhRU2IxRkFVUkp2a2hKVndBZ1NURUFFa1JNZ2NBQ1UwUlBBaFpRZ0FHQVVMOGlRekVBSXlwbFJCSkVJeWhsUkVsRUtDTm5zU01xWlVTeUI3SUlJcklRSTdJQnN5SkROaG9CU1JXQklCSkVOaG9DU1JVa0VrUVhGbEFwVEZCSnZVVUJSTDVJSzB4UXNDSkROaG9CU1JXQklCSkVOaG9DU1JVa0VrUVhGbEFwVEZDOVJRR0FBUUFqVHdKVUsweFFzQ0pESXlobFJCWXJURkN3SWtNakttVkVLMHhRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
