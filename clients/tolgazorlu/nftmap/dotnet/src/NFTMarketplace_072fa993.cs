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

namespace Arc56.Generated.tolgazorlu.nftmap.NFTMarketplace_072fa993
{


    //
    // NFT Marketplace Contract
    //
    //This contract manages an NFT marketplace where users can:
    //- Create NFTs for their art
    //- List NFTs for sale with Algo payments
    //- Buy NFTs from other users
    //- View marketplace listings
    //
    //Features:
    //- Asset creation and management
    //- Marketplace listings with pricing
    //- Secure payment handling
    //- Metadata storage for art information
    //- Location-based NFT discovery
    //
    public class NFTMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFTMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetListingInfoResult : AVMObjectType
            {
                public ulong Price { get; set; }

                public ulong Status { get; set; }

                public string Creator { get; set; }

                public string ArtTitle { get; set; }

                public string ArtDescription { get; set; }

                public ulong LocationLat { get; set; }

                public ulong LocationLng { get; set; }

                public string ImageUrl { get; set; }

                public string Category { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreator.From(Creator);
                    stringRef[ret.Count] = vCreator.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArtTitle.From(ArtTitle);
                    stringRef[ret.Count] = vArtTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArtDescription.From(ArtDescription);
                    stringRef[ret.Count] = vArtDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocationLat = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocationLat.From(LocationLat);
                    ret.AddRange(vLocationLat.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocationLng = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocationLng.From(LocationLng);
                    ret.AddRange(vLocationLng.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImageUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vImageUrl.From(ImageUrl);
                    stringRef[ret.Count] = vImageUrl.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.From(Category);
                    stringRef[ret.Count] = vCategory.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetListingInfoResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetListingInfoResult();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    var indexCreator = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreator.Decode(bytes.Skip(indexCreator + prefixOffset).ToArray());
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is string vCreatorValue) { ret.Creator = vCreatorValue; }
                    var indexArtTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArtTitle.Decode(bytes.Skip(indexArtTitle + prefixOffset).ToArray());
                    var valueArtTitle = vArtTitle.ToValue();
                    if (valueArtTitle is string vArtTitleValue) { ret.ArtTitle = vArtTitleValue; }
                    var indexArtDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArtDescription.Decode(bytes.Skip(indexArtDescription + prefixOffset).ToArray());
                    var valueArtDescription = vArtDescription.ToValue();
                    if (valueArtDescription is string vArtDescriptionValue) { ret.ArtDescription = vArtDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocationLat = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocationLat.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocationLat = vLocationLat.ToValue();
                    if (valueLocationLat is ulong vLocationLatValue) { ret.LocationLat = vLocationLatValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocationLng = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocationLng.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocationLng = vLocationLng.ToValue();
                    if (valueLocationLng is ulong vLocationLngValue) { ret.LocationLng = vLocationLngValue; }
                    var indexImageUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImageUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vImageUrl.Decode(bytes.Skip(indexImageUrl + prefixOffset).ToArray());
                    var valueImageUrl = vImageUrl.ToValue();
                    if (valueImageUrl is string vImageUrlValue) { ret.ImageUrl = vImageUrlValue; }
                    var indexCategory = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.Decode(bytes.Skip(indexCategory + prefixOffset).ToArray());
                    var valueCategory = vCategory.ToValue();
                    if (valueCategory is string vCategoryValue) { ret.Category = vCategoryValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetListingInfoResult);
                }
                public bool Equals(GetListingInfoResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetListingInfoResult left, GetListingInfoResult right)
                {
                    return EqualityComparer<GetListingInfoResult>.Default.Equals(left, right);
                }
                public static bool operator !=(GetListingInfoResult left, GetListingInfoResult right)
                {
                    return !(left == right);
                }

            }

            public class GetMarketplaceStatsResult : AVMObjectType
            {
                public ulong TotalListings { get; set; }

                public ulong FeePercentage { get; set; }

                public string MarketplaceOwner { get; set; }

                public string FeeAccount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalListings = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalListings.From(TotalListings);
                    ret.AddRange(vTotalListings.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeePercentage.From(FeePercentage);
                    ret.AddRange(vFeePercentage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplaceOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMarketplaceOwner.From(MarketplaceOwner);
                    stringRef[ret.Count] = vMarketplaceOwner.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vFeeAccount.From(FeeAccount);
                    stringRef[ret.Count] = vFeeAccount.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetMarketplaceStatsResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetMarketplaceStatsResult();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalListings = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalListings.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalListings = vTotalListings.ToValue();
                    if (valueTotalListings is ulong vTotalListingsValue) { ret.TotalListings = vTotalListingsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePercentage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeePercentage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeePercentage = vFeePercentage.ToValue();
                    if (valueFeePercentage is ulong vFeePercentageValue) { ret.FeePercentage = vFeePercentageValue; }
                    var indexMarketplaceOwner = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplaceOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMarketplaceOwner.Decode(bytes.Skip(indexMarketplaceOwner + prefixOffset).ToArray());
                    var valueMarketplaceOwner = vMarketplaceOwner.ToValue();
                    if (valueMarketplaceOwner is string vMarketplaceOwnerValue) { ret.MarketplaceOwner = vMarketplaceOwnerValue; }
                    var indexFeeAccount = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vFeeAccount.Decode(bytes.Skip(indexFeeAccount + prefixOffset).ToArray());
                    var valueFeeAccount = vFeeAccount.ToValue();
                    if (valueFeeAccount is string vFeeAccountValue) { ret.FeeAccount = vFeeAccountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMarketplaceStatsResult);
                }
                public bool Equals(GetMarketplaceStatsResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMarketplaceStatsResult left, GetMarketplaceStatsResult right)
                {
                    return EqualityComparer<GetMarketplaceStatsResult>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMarketplaceStatsResult left, GetMarketplaceStatsResult right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the marketplace contract
        ///</summary>
        /// <param name="marketplaceOwner">- Address of the marketplace owner </param>
        /// <param name="feePercentage">- Marketplace fee percentage (0-100) </param>
        /// <param name="feeAccount">- Account to receive marketplace fees </param>
        public async Task<string> Initialize(string marketplaceOwner, ulong feePercentage, string feeAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 198, 26, 24 };
            var marketplaceOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); marketplaceOwnerAbi.From(marketplaceOwner);
            var feePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageAbi.From(feePercentage);
            var feeAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); feeAccountAbi.From(feeAccount);

            var result = await base.CallApp(new List<object> { abiHandle, marketplaceOwnerAbi, feePercentageAbi, feeAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(string marketplaceOwner, ulong feePercentage, string feeAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 198, 26, 24 };
            var marketplaceOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); marketplaceOwnerAbi.From(marketplaceOwner);
            var feePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePercentageAbi.From(feePercentage);
            var feeAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); feeAccountAbi.From(feeAccount);

            return await base.MakeTransactionList(new List<object> { abiHandle, marketplaceOwnerAbi, feePercentageAbi, feeAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new NFT listing
        ///</summary>
        /// <param name="assetId">- The asset ID of the NFT </param>
        /// <param name="price">- Price in microAlgos </param>
        /// <param name="artTitle">- Title of the artwork </param>
        /// <param name="artDescription">- Description of the artwork </param>
        /// <param name="locationLat">- Latitude of the art location </param>
        /// <param name="locationLng">- Longitude of the art location </param>
        /// <param name="imageUrl">- URL of the art image </param>
        /// <param name="category">- Category of the art </param>
        public async Task<string> CreateListing(ulong assetId, ulong price, string artTitle, string artDescription, ulong locationLat, ulong locationLng, string imageUrl, string category, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 255, 176, 221 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var artTitleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); artTitleAbi.From(artTitle);
            var artDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); artDescriptionAbi.From(artDescription);
            var locationLatAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locationLatAbi.From(locationLat);
            var locationLngAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locationLngAbi.From(locationLng);
            var imageUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); imageUrlAbi.From(imageUrl);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, priceAbi, artTitleAbi, artDescriptionAbi, locationLatAbi, locationLngAbi, imageUrlAbi, categoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateListing_Transactions(ulong assetId, ulong price, string artTitle, string artDescription, ulong locationLat, ulong locationLng, string imageUrl, string category, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 255, 176, 221 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var artTitleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); artTitleAbi.From(artTitle);
            var artDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); artDescriptionAbi.From(artDescription);
            var locationLatAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locationLatAbi.From(locationLat);
            var locationLngAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locationLngAbi.From(locationLng);
            var imageUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); imageUrlAbi.From(imageUrl);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, priceAbi, artTitleAbi, artDescriptionAbi, locationLatAbi, locationLngAbi, imageUrlAbi, categoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy an NFT from the marketplace
        ///</summary>
        /// <param name="assetId">- The asset ID of the NFT to buy </param>
        /// <param name="seller">- Address of the seller </param>
        public async Task<string> BuyNft(ulong assetId, string seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 36, 40, 157 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sellerAbi.From(seller);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> BuyNft_Transactions(ulong assetId, string seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 36, 40, 157 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sellerAbi.From(seller);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel a listing
        ///</summary>
        /// <param name="assetId">- The asset ID of the NFT </param>
        public async Task<string> CancelListing(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 121, 148, 109 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CancelListing_Transactions(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 121, 148, 109 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update listing price
        ///</summary>
        /// <param name="assetId">- The asset ID of the NFT </param>
        /// <param name="newPrice">- New price in microAlgos </param>
        public async Task<string> UpdateListingPrice(ulong assetId, ulong newPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 232, 162, 204 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var newPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceAbi.From(newPrice);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, newPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateListingPrice_Transactions(ulong assetId, ulong newPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 232, 162, 204 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var newPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceAbi.From(newPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, newPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get listing information
        ///</summary>
        /// <param name="assetId">- The asset ID of the NFT </param>
        public async Task<Structs.GetListingInfoResult> GetListingInfo(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 4, 79, 251 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetListingInfoResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetListingInfo_Transactions(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 4, 79, 251 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get marketplace statistics
        ///</summary>
        public async Task<Structs.GetMarketplaceStatsResult> GetMarketplaceStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 15, 226, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMarketplaceStatsResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarketplaceStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 15, 226, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Search listings by location (within radius)
        ///</summary>
        /// <param name="centerLat">- Center latitude </param>
        /// <param name="centerLng">- Center longitude </param>
        /// <param name="radiusKm">- Search radius in kilometers </param>
        public async Task<ulong[]> SearchListingsByLocation(ulong centerLat, ulong centerLng, ulong radiusKm, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 171, 21, 241 };
            var centerLatAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); centerLatAbi.From(centerLat);
            var centerLngAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); centerLngAbi.From(centerLng);
            var radiusKmAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); radiusKmAbi.From(radiusKm);

            var result = await base.CallApp(new List<object> { abiHandle, centerLatAbi, centerLngAbi, radiusKmAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> SearchListingsByLocation_Transactions(ulong centerLat, ulong centerLng, ulong radiusKm, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 171, 21, 241 };
            var centerLatAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); centerLatAbi.From(centerLat);
            var centerLngAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); centerLngAbi.From(centerLng);
            var radiusKmAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); radiusKmAbi.From(radiusKm);

            return await base.MakeTransactionList(new List<object> { abiHandle, centerLatAbi, centerLngAbi, radiusKmAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Search listings by category
        ///</summary>
        /// <param name="category">- Category to search for </param>
        public async Task<ulong[]> SearchListingsByCategory(string category, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 29, 239, 195 };
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);

            var result = await base.CallApp(new List<object> { abiHandle, categoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> SearchListingsByCategory_Transactions(string category, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 29, 239, 195 };
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);

            return await base.MakeTransactionList(new List<object> { abiHandle, categoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update marketplace fee (only marketplace owner)
        ///</summary>
        /// <param name="newFeePercentage">- New fee percentage (0-100) </param>
        public async Task<string> UpdateMarketplaceFee(ulong newFeePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 200, 18, 172 };
            var newFeePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeePercentageAbi.From(newFeePercentage);

            var result = await base.CallApp(new List<object> { abiHandle, newFeePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateMarketplaceFee_Transactions(ulong newFeePercentage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 200, 18, 172 };
            var newFeePercentageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeePercentageAbi.From(newFeePercentage);

            return await base.MakeTransactionList(new List<object> { abiHandle, newFeePercentageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer marketplace ownership (only current owner)
        ///</summary>
        /// <param name="newOwner">- Address of the new owner </param>
        public async Task<string> TransferOwnership(string newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 55, 79, 102 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(string newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 55, 79, 102 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency function to withdraw Algo (only marketplace owner)
        ///</summary>
        /// <param name="amount">- Amount to withdraw in microAlgos </param>
        /// <param name="recipient">- Address to receive the Algo </param>
        public async Task<string> EmergencyWithdraw(ulong amount, string recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 217, 36, 145 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(ulong amount, string recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 217, 36, 145 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTkZUTWFya2V0cGxhY2UiLCJkZXNjIjoiTkZUIE1hcmtldHBsYWNlIENvbnRyYWN0XG5cblRoaXMgY29udHJhY3QgbWFuYWdlcyBhbiBORlQgbWFya2V0cGxhY2Ugd2hlcmUgdXNlcnMgY2FuOlxuLSBDcmVhdGUgTkZUcyBmb3IgdGhlaXIgYXJ0XG4tIExpc3QgTkZUcyBmb3Igc2FsZSB3aXRoIEFsZ28gcGF5bWVudHNcbi0gQnV5IE5GVHMgZnJvbSBvdGhlciB1c2Vyc1xuLSBWaWV3IG1hcmtldHBsYWNlIGxpc3RpbmdzXG5cbkZlYXR1cmVzOlxuLSBBc3NldCBjcmVhdGlvbiBhbmQgbWFuYWdlbWVudFxuLSBNYXJrZXRwbGFjZSBsaXN0aW5ncyB3aXRoIHByaWNpbmdcbi0gU2VjdXJlIHBheW1lbnQgaGFuZGxpbmdcbi0gTWV0YWRhdGEgc3RvcmFnZSBmb3IgYXJ0IGluZm9ybWF0aW9uXG4tIExvY2F0aW9uLWJhc2VkIE5GVCBkaXNjb3ZlcnkiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiZ2V0TGlzdGluZ0luZm9SZXN1bHQiOlt7Im5hbWUiOiJwcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhcnRUaXRsZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhcnREZXNjcmlwdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJsb2NhdGlvbkxhdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsb2NhdGlvbkxuZyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbWFnZVVybCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjYXRlZ29yeSIsInR5cGUiOiJzdHJpbmcifV0sImdldE1hcmtldHBsYWNlU3RhdHNSZXN1bHQiOlt7Im5hbWUiOiJ0b3RhbExpc3RpbmdzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZlZVBlcmNlbnRhZ2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWFya2V0cGxhY2VPd25lciIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmZWVBY2NvdW50IiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIG1hcmtldHBsYWNlIGNvbnRyYWN0IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlT3duZXIiLCJkZXNjIjoiLSBBZGRyZXNzIG9mIHRoZSBtYXJrZXRwbGFjZSBvd25lciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlUGVyY2VudGFnZSIsImRlc2MiOiItIE1hcmtldHBsYWNlIGZlZSBwZXJjZW50YWdlICgwLTEwMCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZUFjY291bnQiLCJkZXNjIjoiLSBBY2NvdW50IHRvIHJlY2VpdmUgbWFya2V0cGxhY2UgZmVlcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUxpc3RpbmciLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IE5GVCBsaXN0aW5nIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjoiLSBUaGUgYXNzZXQgSUQgb2YgdGhlIE5GVCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjoiLSBQcmljZSBpbiBtaWNyb0FsZ29zIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnRUaXRsZSIsImRlc2MiOiItIFRpdGxlIG9mIHRoZSBhcnR3b3JrIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnREZXNjcmlwdGlvbiIsImRlc2MiOiItIERlc2NyaXB0aW9uIG9mIHRoZSBhcnR3b3JrIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NhdGlvbkxhdCIsImRlc2MiOiItIExhdGl0dWRlIG9mIHRoZSBhcnQgbG9jYXRpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvY2F0aW9uTG5nIiwiZGVzYyI6Ii0gTG9uZ2l0dWRlIG9mIHRoZSBhcnQgbG9jYXRpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImltYWdlVXJsIiwiZGVzYyI6Ii0gVVJMIG9mIHRoZSBhcnQgaW1hZ2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhdGVnb3J5IiwiZGVzYyI6Ii0gQ2F0ZWdvcnkgb2YgdGhlIGFydCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eU5GVCIsImRlc2MiOiJCdXkgYW4gTkZUIGZyb20gdGhlIG1hcmtldHBsYWNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjoiLSBUaGUgYXNzZXQgSUQgb2YgdGhlIE5GVCB0byBidXkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxlciIsImRlc2MiOiItIEFkZHJlc3Mgb2YgdGhlIHNlbGxlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbExpc3RpbmciLCJkZXNjIjoiQ2FuY2VsIGEgbGlzdGluZyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldElkIiwiZGVzYyI6Ii0gVGhlIGFzc2V0IElEIG9mIHRoZSBORlQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVMaXN0aW5nUHJpY2UiLCJkZXNjIjoiVXBkYXRlIGxpc3RpbmcgcHJpY2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOiItIFRoZSBhc3NldCBJRCBvZiB0aGUgTkZUIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdQcmljZSIsImRlc2MiOiItIE5ldyBwcmljZSBpbiBtaWNyb0FsZ29zIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TGlzdGluZ0luZm8iLCJkZXNjIjoiR2V0IGxpc3RpbmcgaW5mb3JtYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOiItIFRoZSBhc3NldCBJRCBvZiB0aGUgTkZUIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQsc3RyaW5nLHN0cmluZykiLCJzdHJ1Y3QiOiJnZXRMaXN0aW5nSW5mb1Jlc3VsdCIsImRlc2MiOiJMaXN0aW5nIGluZm9ybWF0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFya2V0cGxhY2VTdGF0cyIsImRlc2MiOiJHZXQgbWFya2V0cGxhY2Ugc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCxzdHJpbmcsc3RyaW5nKSIsInN0cnVjdCI6ImdldE1hcmtldHBsYWNlU3RhdHNSZXN1bHQiLCJkZXNjIjoiTWFya2V0cGxhY2Ugc3RhdGlzdGljcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNlYXJjaExpc3RpbmdzQnlMb2NhdGlvbiIsImRlc2MiOiJTZWFyY2ggbGlzdGluZ3MgYnkgbG9jYXRpb24gKHdpdGhpbiByYWRpdXMpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNlbnRlckxhdCIsImRlc2MiOiItIENlbnRlciBsYXRpdHVkZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2VudGVyTG5nIiwiZGVzYyI6Ii0gQ2VudGVyIGxvbmdpdHVkZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmFkaXVzS20iLCJkZXNjIjoiLSBTZWFyY2ggcmFkaXVzIGluIGtpbG9tZXRlcnMiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJBcnJheSBvZiBhc3NldCBJRHMgd2l0aGluIHRoZSByYWRpdXMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZWFyY2hMaXN0aW5nc0J5Q2F0ZWdvcnkiLCJkZXNjIjoiU2VhcmNoIGxpc3RpbmdzIGJ5IGNhdGVnb3J5IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhdGVnb3J5IiwiZGVzYyI6Ii0gQ2F0ZWdvcnkgdG8gc2VhcmNoIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkFycmF5IG9mIGFzc2V0IElEcyBpbiB0aGUgY2F0ZWdvcnkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVNYXJrZXRwbGFjZUZlZSIsImRlc2MiOiJVcGRhdGUgbWFya2V0cGxhY2UgZmVlIChvbmx5IG1hcmtldHBsYWNlIG93bmVyKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdGZWVQZXJjZW50YWdlIiwiZGVzYyI6Ii0gTmV3IGZlZSBwZXJjZW50YWdlICgwLTEwMCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlck93bmVyc2hpcCIsImRlc2MiOiJUcmFuc2ZlciBtYXJrZXRwbGFjZSBvd25lcnNoaXAgKG9ubHkgY3VycmVudCBvd25lcikiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjoiLSBBZGRyZXNzIG9mIHRoZSBuZXcgb3duZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lXaXRoZHJhdyIsImRlc2MiOiJFbWVyZ2VuY3kgZnVuY3Rpb24gdG8gd2l0aGRyYXcgQWxnbyAob25seSBtYXJrZXRwbGFjZSBvd25lcikiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6Ii0gQW1vdW50IHRvIHdpdGhkcmF3IGluIG1pY3JvQWxnb3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOiItIEFkZHJlc3MgdG8gcmVjZWl2ZSB0aGUgQWxnbyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE1LDE2MywxOTgsMjI3LDIzOCwyNDksMzIxLDQ3MSw1MDIsNTM3LDU2OCw2MDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgsMTY2LDIwMSwyMzAsMjQxLDI1MiwzMjQsNDc0LDUwNSw1NDAsNTcxLDYwNF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMU1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUa1pVVFdGeWEyVjBjR3hoWTJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtZbU0yTVdFeE9DQXdlR014Wm1aaU1HUmtJREI0TTJReU5ESTRPV1FnTUhoaU5UYzVPVFEyWkNBd2VESmtaVGhoTW1OaklEQjRNalV3TkRSbVptSWdNSGcxTlRCbVpUSTFOQ0F3ZURsa1lXSXhOV1l4SURCNE16Y3haR1ZtWXpNZ01IaG1OR000TVRKaFl5QXdlRGN3TXpjMFpqWTJJREI0TVdWa09USTBPVEVnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtITjBjbWx1Wnl4MWFXNTBOalFzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZM0psWVhSbFRHbHpkR2x1WnloMWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVluVjVUa1pVS0hWcGJuUTJOQ3h6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmpZVzVqWld4TWFYTjBhVzVuS0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVeHBjM1JwYm1kUWNtbGpaU2gxYVc1ME5qUXNkV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBUR2x6ZEdsdVowbHVabThvZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRc2MzUnlhVzVuTEhOMGNtbHVaeWtpTENCdFpYUm9iMlFnSW1kbGRFMWhjbXRsZEhCc1lXTmxVM1JoZEhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeXh6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0p6WldGeVkyaE1hWE4wYVc1bmMwSjVURzlqWVhScGIyNG9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBXMTBpTENCdFpYUm9iMlFnSW5ObFlYSmphRXhwYzNScGJtZHpRbmxEWVhSbFoyOXllU2h6ZEhKcGJtY3BkV2x1ZERZMFcxMGlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVMWhjbXRsZEhCc1lXTmxSbVZsS0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlUM2R1WlhKemFHbHdLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltVnRaWEpuWlc1amVWZHBkR2hrY21GM0tIVnBiblEyTkN4emRISnBibWNwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXBibWwwYVdGc2FYcGxYM0p2ZFhSbFFETWdiV0ZwYmw5amNtVmhkR1ZNYVhOMGFXNW5YM0p2ZFhSbFFEUWdiV0ZwYmw5aWRYbE9SbFJmY205MWRHVkFOU0J0WVdsdVgyTmhibU5sYkV4cGMzUnBibWRmY205MWRHVkFOaUJ0WVdsdVgzVndaR0YwWlV4cGMzUnBibWRRY21salpWOXliM1YwWlVBM0lHMWhhVzVmWjJWMFRHbHpkR2x1WjBsdVptOWZjbTkxZEdWQU9DQnRZV2x1WDJkbGRFMWhjbXRsZEhCc1lXTmxVM1JoZEhOZmNtOTFkR1ZBT1NCdFlXbHVYM05sWVhKamFFeHBjM1JwYm1kelFubE1iMk5oZEdsdmJsOXliM1YwWlVBeE1DQnRZV2x1WDNObFlYSmphRXhwYzNScGJtZHpRbmxEWVhSbFoyOXllVjl5YjNWMFpVQXhNU0J0WVdsdVgzVndaR0YwWlUxaGNtdGxkSEJzWVdObFJtVmxYM0p2ZFhSbFFERXlJRzFoYVc1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhCZmNtOTFkR1ZBTVRNZ2JXRnBibDlsYldWeVoyVnVZM2xYYVhSb1pISmhkMTl5YjNWMFpVQXhOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bWRGOXRZWEpyWlhSd2JHRmpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RrWlVUV0Z5YTJWMGNHeGhZMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vYVc1MElEQWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWdFpYSm5aVzVqZVZkcGRHaGtjbUYzWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNUW9nSUNBZ0x5OGdjSFZpYkdsaklHVnRaWEpuWlc1amVWZHBkR2hrY21GM0tHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCeVpXTnBjR2xsYm5RNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeFpUUTFObVEyTlRjeU5qYzJOVFpsTmpNM09USXdOemMyT1RjME5qZzJORGN5TmpFM056WXhObU15TURZek5tWTJaRGN3Tm1NMk5UYzBOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1J5WVc1elptVnlUM2R1WlhKemFHbHdYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhSeVlXNXpabVZ5VDNkdVpYSnphR2x3S0c1bGQwOTNibVZ5T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPUmxSTllYSnJaWFJ3YkdGalpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQW9ibVYzVDNkdVpYSTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhSeVlXNXpabVZ5VDNkdVpYSnphR2x3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVndaR0YwWlUxaGNtdGxkSEJzWVdObFJtVmxYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVTFoY210bGRIQnNZV05sUm1WbEtHNWxkMFpsWlZCbGNtTmxiblJoWjJVNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd1lqUTJOalUyTlRJd056VTNNRFkwTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaV0Z5WTJoTWFYTjBhVzVuYzBKNVEyRjBaV2R2Y25sZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlZoY21Ob1RHbHpkR2x1WjNOQ2VVTmhkR1ZuYjNKNUtHTmhkR1ZuYjNKNU9pQnpkSEpwYm1jcE9pQjFhVzUwTmpSYlhTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaV0Z5WTJoTWFYTjBhVzVuYzBKNVRHOWpZWFJwYjI1ZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1aMFgyMWhjbXRsZEhCc1lXTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlZoY21Ob1RHbHpkR2x1WjNOQ2VVeHZZMkYwYVc5dUtHTmxiblJsY2t4aGREb2dkV2x1ZERZMExDQmpaVzUwWlhKTWJtYzZJSFZwYm5RMk5Dd2djbUZrYVhWelMyMDZJSFZwYm5RMk5DazZJSFZwYm5RMk5GdGRJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFNREF3TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEUxaGNtdGxkSEJzWVdObFUzUmhkSE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qWXRNVE14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVFdGeWEyVjBjR3hoWTJWVGRHRjBjeWdwT2lCN0NpQWdJQ0F2THlBZ0lIUnZkR0ZzVEdsemRHbHVaM002SUhWcGJuUTJOQW9nSUNBZ0x5OGdJQ0JtWldWUVpYSmpaVzUwWVdkbE9pQjFhVzUwTmpRS0lDQWdJQzh2SUNBZ2JXRnlhMlYwY0d4aFkyVlBkMjVsY2pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFnSUdabFpVRmpZMjkxYm5RNklITjBjbWx1WndvZ0lDQWdMeThnZlNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EVXdNREUwTURBeU16QXdNR1EwWmpVM05HVTBOVFV5TldZME1UUTBORFExTWpRMU5UTTFNekF3TVRNME5qUTFORFUxWmpReE5ETTBNelJtTlRVMFpUVTBOV1kwTVRRME5EUTFNalExTlRNMU13b2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFeHBjM1JwYm1kSmJtWnZYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtWjBYMjFoY210bGRIQnNZV05sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZdE1UQTJDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBUR2x6ZEdsdVowbHVabThvWVhOelpYUkpaRG9nZFdsdWREWTBLVG9nZXdvZ0lDQWdMeThnSUNCd2NtbGpaVG9nZFdsdWREWTBDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dkV2x1ZERZMENpQWdJQ0F2THlBZ0lHTnlaV0YwYjNJNklITjBjbWx1WndvZ0lDQWdMeThnSUNCaGNuUlVhWFJzWlRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFnSUdGeWRFUmxjMk55YVhCMGFXOXVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDQWdiRzlqWVhScGIyNU1ZWFE2SUhWcGJuUTJOQW9nSUNBZ0x5OGdJQ0JzYjJOaGRHbHZia3h1WnpvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFnSUdsdFlXZGxWWEpzT2lCemRISnBibWNLSUNBZ0lDOHZJQ0FnWTJGMFpXZHZjbms2SUhOMGNtbHVad29nSUNBZ0x5OGdmU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3TURBd01EQXdNREJtTkRJME1EQXdNREF3TURBd01EQXdNREF3TURFd01ESmhNREF6WWpBd05EY3dNREF3TURBd01EQXlObVF6WVRZd01EQXdNREF3TURBd05EWTVNMlJtTURBd05XSXdNRGM0TURBd1pqUXpOVEkwTlRReE5UUTBaalV5TldZME1UUTBORFExTWpRMU5UTTFNekF3TUdFMU16WXhObVEzTURaak5qVXlNRFF4TnpJM05EQXdNVEkxTXpZeE5tUTNNRFpqTmpVeU1EWTBOalUzTXpZek56STJPVGN3TnpRMk9UWm1ObVV3TURGaU5qZzNORGMwTnpBM016TmhNbVl5WmpZMU56ZzJNVFprTnpBMll6WTFNbVUyTXpabU5tUXlaall4TnpJM05ESmxObUUzTURZM01EQXdZalEwTmprMk56WTVOelEyTVRaak1qQTBNVGN5TnpRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVk1hWE4wYVc1blVISnBZMlZmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVXhwYzNScGJtZFFjbWxqWlNoaGMzTmxkRWxrT2lCMWFXNTBOalFzSUc1bGQxQnlhV05sT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TUdRMU1EY3lOamsyTXpZMU1qQTNOVGN3TmpRMk1UYzBOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYm1ObGJFeHBjM1JwYm1kZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdjSFZpYkdsaklHTmhibU5sYkV4cGMzUnBibWNvWVhOelpYUkpaRG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREV4TkdNMk9UY3pOelEyT1RabE5qY3lNRFl6TmpFMlpUWXpOalUyWXpaak5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySjFlVTVHVkY5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVtZEY5dFlYSnJaWFJ3YkdGalpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QndkV0pzYVdNZ1luVjVUa1pVS0dGemMyVjBTV1E2SUhWcGJuUTJOQ3dnYzJWc2JHVnlPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNR1EwWlRRMk5UUXlNRGN3TnpVM01qWXpOamcyTVRjek5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlV4cGMzUnBibWRmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5DMDFNd29nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlV4cGMzUnBibWNvQ2lBZ0lDQXZMeUFnSUdGemMyVjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY0hKcFkyVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZWEowVkdsMGJHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZWEowUkdWelkzSnBjSFJwYjI0NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2JHOWpZWFJwYjI1TVlYUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiRzlqWVhScGIyNU1ibWM2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYVcxaFoyVlZjbXc2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWTJGMFpXZHZjbms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF3WmpSak5qazNNemMwTmprMlpUWTNNakEyTXpjeU5qVTJNVGMwTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1Wm5SZmJXRnlhMlYwY0d4aFkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdjSFZpYkdsaklHbHVhWFJwWVd4cGVtVW9iV0Z5YTJWMGNHeGhZMlZQZDI1bGNqb2djM1J5YVc1bkxDQm1aV1ZRWlhKalpXNTBZV2RsT2lCMWFXNTBOalFzSUdabFpVRmpZMjkxYm5RNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeE56UmtOakUzTWpaaU5qVTNORGN3Tm1NMk1UWXpOalV5TURZNU5tVTJPVGMwTmprMk1UWmpOamszWVRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVowWDIxaGNtdGxkSEJzWVdObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJPUmxSTllYSnJaWFJ3YkdGalpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwT1JsUk5ZWEpyWlhSd2JHRmpaUzUwY21GdWMyWmxjazkzYm1WeWMyaHBjQ2h1WlhkUGQyNWxjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwY21GdWMyWmxjazkzYm1WeWMyaHBjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVablJmYldGeWEyVjBjR3hoWTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EQUtJQ0FnSUM4dklIQjFZbXhwWXlCMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NodVpYZFBkMjVsY2pvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNW1kRjl0WVhKclpYUndiR0ZqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdCUGQyNWxjbk5vYVhBZ2RISmhibk5tWlhKeVpXUWdkRzhnSkh0dVpYZFBkMjVsY24xZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWs5M2JtVnljMmhwY0NCMGNtRnVjMlpsY25KbFpDQjBieUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lCQmhVZmZIVUFBREViUVFKdGdnd0UyOFlhR0FUQi83RGRCRDBrS0owRXRYbVViUVF0NktMTUJDVUVUL3NFVlEvaVZBU2RxeFh4QkRjZDc4TUU5TWdTckFSd04wOW1CQjdaSkpFMkdnQ09EQUhwQWNnQnFRR0dBV2NBMFFDSkFINEFjd0JXQURNQUE0RUFRekVaRkVReEdFU0FKQlVmZkhVQUhrVnRaWEpuWlc1amVTQjNhWFJvWkhKaGQyRnNJR052YlhCc1pYUmxaTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lBZHBKRlJaWEJnSk1VSUFFRlI5OGRVeFFzQ0pETVJrVVJERVlSSUFSRlI5OGRRQUxSbVZsSUhWd1pHRjBaV1N3SWtNeEdSUkVNUmhFS0xBaVF6RVpGRVF4R0VRb3NDSkRNUmtVUkRFWVJJQThGUjk4ZFFBQUFBQUFBQUFBQUFBQUFBQUFBQVVBRkFBakFBMVBWMDVGVWw5QlJFUlNSVk5UQUJOR1JVVmZRVU5EVDFWT1ZGOUJSRVJTUlZOVHNDSkRNUmtVUkRFWVJJQ0pBUlVmZkhVQUFBQUFBQTlDUUFBQUFBQUFBQUFCQUNvQU93QkhBQUFBQUFKdE9tQUFBQUFBQkdrOThBQmJBSGdBRDBOU1JVRlVUMUpmUVVSRVVrVlRVd0FLVTJGdGNHeGxJRUZ5ZEFBU1UyRnRjR3hsSUdSbGMyTnlhWEIwYVc5dUFCdG9kSFJ3Y3pvdkwyVjRZVzF3YkdVdVkyOXRMMkZ5ZEM1cWNHY0FDMFJwWjJsMFlXd2dRWEowc0NKRE1Sa1VSREVZUklBVEZSOThkUUFOVUhKcFkyVWdkWEJrWVhSbFpMQWlRekVaRkVReEdFU0FGeFVmZkhVQUVVeHBjM1JwYm1jZ1kyRnVZMlZzYkdWa3NDSkRNUmtVUkRFWVJJQVRGUjk4ZFFBTlRrWlVJSEIxY21Ob1lYTmxaTEFpUXpFWkZFUXhHRVNBRlJVZmZIVUFEMHhwYzNScGJtY2dZM0psWVhSbFpMQWlRekVaRkVReEdFU0FIUlVmZkhVQUYwMWhjbXRsZEhCc1lXTmxJR2x1YVhScFlXeHBlbVZrc0NKRE1SbEEvZWt4R0JSRUlrT0tBUUdBR1U5M2JtVnljMmhwY0NCMGNtRnVjMlpsY25KbFpDQjBieUNMLzFDSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
