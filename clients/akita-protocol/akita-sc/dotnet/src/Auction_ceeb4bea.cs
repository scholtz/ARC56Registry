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

namespace Arc56.Generated.akita_protocol.akita_sc.Auction_ceeb4bea
{


    public class AuctionProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AuctionProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AuctionMbrData : AVMObjectType
            {
                public ulong Bids { get; set; }

                public ulong Weights { get; set; }

                public ulong BidsByAddress { get; set; }

                public ulong Locations { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBids.From(Bids);
                    ret.AddRange(vBids.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeights = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeights.From(Weights);
                    ret.AddRange(vWeights.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidsByAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBidsByAddress.From(BidsByAddress);
                    ret.AddRange(vBidsByAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocations.From(Locations);
                    ret.AddRange(vLocations.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AuctionMbrData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AuctionMbrData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBids = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBids.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBids = vBids.ToValue();
                    if (valueBids is ulong vBidsValue) { ret.Bids = vBidsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeights = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeights.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeights = vWeights.ToValue();
                    if (valueWeights is ulong vWeightsValue) { ret.Weights = vWeightsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBidsByAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBidsByAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBidsByAddress = vBidsByAddress.ToValue();
                    if (valueBidsByAddress is ulong vBidsByAddressValue) { ret.BidsByAddress = vBidsByAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocations = vLocations.ToValue();
                    if (valueLocations is ulong vLocationsValue) { ret.Locations = vLocationsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AuctionMbrData);
                }
                public bool Equals(AuctionMbrData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AuctionMbrData left, AuctionMbrData right)
                {
                    return EqualityComparer<AuctionMbrData>.Default.Equals(left, right);
                }
                public static bool operator !=(AuctionMbrData left, AuctionMbrData right)
                {
                    return !(left == right);
                }

            }

            public class BidInfo : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public ulong Amount { get; set; }

                public Algorand.Address Marketplace { get; set; }

                public bool Refunded { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vMarketplace.From(Marketplace);
                    ret.AddRange(vMarketplace.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefunded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vRefunded.From(Refunded);
                    ret.AddRange(vRefunded.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BidInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BidInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vMarketplace.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMarketplace = vMarketplace.ToValue();
                    if (valueMarketplace is Algorand.Address vMarketplaceValue) { ret.Marketplace = vMarketplaceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefunded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vRefunded.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRefunded = vRefunded.ToValue();
                    if (valueRefunded is bool vRefundedValue) { ret.Refunded = vRefundedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BidInfo);
                }
                public bool Equals(BidInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BidInfo left, BidInfo right)
                {
                    return EqualityComparer<BidInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(BidInfo left, BidInfo right)
                {
                    return !(left == right);
                }

            }

            public class FindWinnerCursors : AVMObjectType
            {
                public ulong StartingIndex { get; set; }

                public ulong CurrentRangeStart { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartingIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartingIndex.From(StartingIndex);
                    ret.AddRange(vStartingIndex.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentRangeStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCurrentRangeStart.From(CurrentRangeStart);
                    ret.AddRange(vCurrentRangeStart.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FindWinnerCursors Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FindWinnerCursors();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartingIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartingIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartingIndex = vStartingIndex.ToValue();
                    if (valueStartingIndex is ulong vStartingIndexValue) { ret.StartingIndex = vStartingIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentRangeStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCurrentRangeStart.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrentRangeStart = vCurrentRangeStart.ToValue();
                    if (valueCurrentRangeStart is ulong vCurrentRangeStartValue) { ret.CurrentRangeStart = vCurrentRangeStartValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FindWinnerCursors);
                }
                public bool Equals(FindWinnerCursors? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FindWinnerCursors left, FindWinnerCursors right)
                {
                    return EqualityComparer<FindWinnerCursors>.Default.Equals(left, right);
                }
                public static bool operator !=(FindWinnerCursors left, FindWinnerCursors right)
                {
                    return !(left == right);
                }

            }

            public class AkitaConfig : AVMObjectType
            {
                public ulong AkitaDao { get; set; }

                public Structs.EscrowConfig AkitaDaoEscrow { get; set; } = new Structs.EscrowConfig();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAkitaDao = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAkitaDao.From(AkitaDao);
                    ret.AddRange(vAkitaDao.Encode());
                    stringRef[ret.Count] = AkitaDaoEscrow.ToByteArray();
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

                public static AkitaConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AkitaConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAkitaDao = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAkitaDao.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAkitaDao = vAkitaDao.ToValue();
                    if (valueAkitaDao is ulong vAkitaDaoValue) { ret.AkitaDao = vAkitaDaoValue; }
                    var indexAkitaDaoEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.AkitaDaoEscrow = Structs.EscrowConfig.Parse(bytes.Skip(indexAkitaDaoEscrow + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AkitaConfig);
                }
                public bool Equals(AkitaConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AkitaConfig left, AkitaConfig right)
                {
                    return EqualityComparer<AkitaConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(AkitaConfig left, AkitaConfig right)
                {
                    return !(left == right);
                }

            }

            public class EscrowConfig : AVMObjectType
            {
                public string Name { get; set; }

                public ulong App { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EscrowConfig();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowConfig);
                }
                public bool Equals(EscrowConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowConfig left, EscrowConfig right)
                {
                    return EqualityComparer<EscrowConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowConfig left, EscrowConfig right)
                {
                    return !(left == right);
                }

            }

            public class FunderInfo : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public ulong Amount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
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

                public static FunderInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FunderInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
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
                    return Equals(obj as FunderInfo);
                }
                public bool Equals(FunderInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FunderInfo left, FunderInfo right)
                {
                    return EqualityComparer<FunderInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(FunderInfo left, FunderInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="prize"> </param>
        /// <param name="isPrizeBox"> </param>
        /// <param name="bidAsset"> </param>
        /// <param name="bidFee"> </param>
        /// <param name="startingBid"> </param>
        /// <param name="bidMinimumIncrease"> </param>
        /// <param name="startTimestamp"> </param>
        /// <param name="endTimestamp"> </param>
        /// <param name="funder"> FunderInfo</param>
        /// <param name="seller"> </param>
        /// <param name="creatorRoyalty"> </param>
        /// <param name="gateID"> </param>
        /// <param name="marketplace"> </param>
        /// <param name="version"> </param>
        /// <param name="akitaConfig"> AkitaConfig</param>
        public async Task Create(ulong prize, bool isPrizeBox, ulong bidAsset, ulong bidFee, ulong startingBid, ulong bidMinimumIncrease, ulong startTimestamp, ulong endTimestamp, Structs.FunderInfo funder, Algorand.Address seller, ulong creatorRoyalty, ulong gateID, Algorand.Address marketplace, string version, Structs.AkitaConfig akitaConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 255, 162, 206 };
            var prizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); prizeAbi.From(prize);
            var isPrizeBoxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); isPrizeBoxAbi.From(isPrizeBox);
            var bidAssetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidAssetAbi.From(bidAsset);
            var bidFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidFeeAbi.From(bidFee);
            var startingBidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startingBidAbi.From(startingBid);
            var bidMinimumIncreaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidMinimumIncreaseAbi.From(bidMinimumIncrease);
            var startTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimestampAbi.From(startTimestamp);
            var endTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endTimestampAbi.From(endTimestamp);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var creatorRoyaltyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creatorRoyaltyAbi.From(creatorRoyalty);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            var result = await base.CallApp(new List<object> { abiHandle, prizeAbi, isPrizeBoxAbi, bidAssetAbi, bidFeeAbi, startingBidAbi, bidMinimumIncreaseAbi, startTimestampAbi, endTimestampAbi, funder, sellerAbi, creatorRoyaltyAbi, gateIDAbi, marketplaceAbi, versionAbi, akitaConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong prize, bool isPrizeBox, ulong bidAsset, ulong bidFee, ulong startingBid, ulong bidMinimumIncrease, ulong startTimestamp, ulong endTimestamp, Structs.FunderInfo funder, Algorand.Address seller, ulong creatorRoyalty, ulong gateID, Algorand.Address marketplace, string version, Structs.AkitaConfig akitaConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 255, 162, 206 };
            var prizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); prizeAbi.From(prize);
            var isPrizeBoxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); isPrizeBoxAbi.From(isPrizeBox);
            var bidAssetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidAssetAbi.From(bidAsset);
            var bidFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidFeeAbi.From(bidFee);
            var startingBidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startingBidAbi.From(startingBid);
            var bidMinimumIncreaseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bidMinimumIncreaseAbi.From(bidMinimumIncrease);
            var startTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimestampAbi.From(startTimestamp);
            var endTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endTimestampAbi.From(endTimestamp);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var creatorRoyaltyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creatorRoyaltyAbi.From(creatorRoyalty);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            return await base.MakeTransactionList(new List<object> { abiHandle, prizeAbi, isPrizeBoxAbi, bidAssetAbi, bidFeeAbi, startingBidAbi, bidMinimumIncreaseAbi, startTimestampAbi, endTimestampAbi, funder, sellerAbi, creatorRoyaltyAbi, gateIDAbi, marketplaceAbi, versionAbi, akitaConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="weightListLength"> </param>
        public async Task Init(PaymentTransaction payment, ulong weightListLength, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 189, 113, 72, 208 };
            var weightListLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); weightListLengthAbi.From(weightListLength);

            var result = await base.CallApp(new List<object> { abiHandle, payment, weightListLengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(PaymentTransaction payment, ulong weightListLength, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 189, 113, 72, 208 };
            var weightListLengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); weightListLengthAbi.From(weightListLength);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, weightListLengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///deletes the application & returns the mbr + asset
        ///to the seller IF the auction hasn't started
        ///</summary>
        public async Task Cancel(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 242, 106, 155 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Cancel_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 242, 106, 155 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="gateTxn"> </param>
        /// <param name="marketplace"> </param>
        public async Task GatedBid(PaymentTransaction payment, ApplicationCallTransaction gateTxn, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, gateTxn });
            byte[] abiHandle = { 152, 54, 200, 159 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, gateTxn, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedBid_Transactions(PaymentTransaction payment, ApplicationCallTransaction gateTxn, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, gateTxn });
            byte[] abiHandle = { 152, 54, 200, 159 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, gateTxn, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="marketplace"> </param>
        public async Task Bid(PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 77, 88, 86, 151 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 77, 88, 86, 151 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="assetXfer"> </param>
        /// <param name="gateTxn"> </param>
        /// <param name="marketplace"> </param>
        public async Task GatedBidAsa(PaymentTransaction payment, AssetTransferTransaction assetXfer, ApplicationCallTransaction gateTxn, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer, gateTxn });
            byte[] abiHandle = { 217, 244, 240, 58 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetXfer, gateTxn, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedBidAsa_Transactions(PaymentTransaction payment, AssetTransferTransaction assetXfer, ApplicationCallTransaction gateTxn, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer, gateTxn });
            byte[] abiHandle = { 217, 244, 240, 58 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetXfer, gateTxn, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="assetXfer"> </param>
        /// <param name="marketplace"> </param>
        public async Task BidAsa(PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer });
            byte[] abiHandle = { 118, 149, 41, 49 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BidAsa_Transactions(PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer });
            byte[] abiHandle = { 118, 149, 41, 49 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task RefundBid(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 227, 156, 92 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundBid_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 227, 156, 92 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Raffle(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 101, 1, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Raffle_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 101, 1, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="iterationAmount"> </param>
        public async Task FindWinner(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 27, 39, 209 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            var result = await base.CallApp(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FindWinner_Transactions(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 27, 39, 209 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="iterationAmount"> </param>
        public async Task RefundMbr(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 206, 47, 70 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            var result = await base.CallApp(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundMbr_Transactions(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 206, 47, 70 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimPrize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 175, 5, 10 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimPrize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 175, 5, 10 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimRafflePrize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 252, 169, 139 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimRafflePrize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 252, 169, 139 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="iterationAmount"> </param>
        public async Task<ulong> ClearWeightsBoxes(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 229, 222, 77 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            var result = await base.CallApp(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ClearWeightsBoxes_Transactions(ulong iterationAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 229, 222, 77 };
            var iterationAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iterationAmountAbi.From(iterationAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, iterationAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> IsLive(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 164, 161, 96 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsLive_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 164, 161, 96 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> HasBid(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 130, 48, 60 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasBid_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 130, 48, 60 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMinimumBidAmount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 137, 94, 38 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMinimumBidAmount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 137, 94, 38 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="config"> EscrowConfig</param>
        public async Task UpdateAkitaDaoEscrow(Structs.EscrowConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 132, 203, 216 };

            var result = await base.CallApp(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDaoEscrow_Transactions(Structs.EscrowConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 132, 203, 216 };

            return await base.MakeTransactionList(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newVersion"> </param>
        public async Task Update(string newVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 145, 128, 221 };
            var newVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newVersionAbi.From(newVersion);

            var result = await base.CallApp(new List<object> { abiHandle, newVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(string newVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 145, 128, 221 };
            var newVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newVersionAbi.From(newVersion);

            return await base.MakeTransactionList(new List<object> { abiHandle, newVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task UpdateAkitaDao(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDao_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///optin tells the contract to opt into an asa
        ///</summary>
        /// <param name="payment">The payment transaction </param>
        /// <param name="asset">The asset to be opted into </param>
        public async Task Optin(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 62, 161, 24, 50 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Optin_Transactions(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 62, 161, 24, 50 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.AuctionMbrData> Mbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 17, 16, 112 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AuctionMbrData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Mbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 17, 16, 112 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXVjdGlvbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBdWN0aW9uTUJSRGF0YSI6W3sibmFtZSI6ImJpZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2VpZ2h0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiaWRzQnlBZGRyZXNzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxvY2F0aW9ucyIsInR5cGUiOiJ1aW50NjQifV0sIkJpZEluZm8iOlt7Im5hbWUiOiJhY2NvdW50IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWFya2V0cGxhY2UiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlZnVuZGVkIiwidHlwZSI6ImJvb2wifV0sIkZpbmRXaW5uZXJDdXJzb3JzIjpbeyJuYW1lIjoic3RhcnRpbmdJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjdXJyZW50UmFuZ2VTdGFydCIsInR5cGUiOiJ1aW50NjQifV0sIkFraXRhQ29uZmlnIjpbeyJuYW1lIjoiYWtpdGFEQU8iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWtpdGFEQU9Fc2Nyb3ciLCJ0eXBlIjoiRXNjcm93Q29uZmlnIn1dLCJFc2Nyb3dDb25maWciOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFwcCIsInR5cGUiOiJ1aW50NjQifV0sIkZ1bmRlckluZm8iOlt7Im5hbWUiOiJhY2NvdW50IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcml6ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzUHJpemVCb3giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpZEFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWRGZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0aW5nQmlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWRNaW5pbXVtSW5jcmVhc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRUaW1lc3RhbXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGdW5kZXJJbmZvIiwibmFtZSI6ImZ1bmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvclJveWFsdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGVJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LChzdHJpbmcsdWludDY0KSkiLCJzdHJ1Y3QiOiJBa2l0YUNvbmZpZyIsIm5hbWUiOiJha2l0YUNvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndlaWdodExpc3RMZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbCIsImRlc2MiOiJkZWxldGVzIHRoZSBhcHBsaWNhdGlvbiAmIHJldHVybnMgdGhlIG1iciArIGFzc2V0XG50byB0aGUgc2VsbGVyIElGIHRoZSBhdWN0aW9uIGhhc24ndCBzdGFydGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXRlZEJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2F0ZWRCaWRBc2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldFhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmlkQXNhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRYZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kQmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJhZmZsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5kV2lubmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZXJhdGlvbkFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1bmRNQlIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlcmF0aW9uQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltUHJpemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1SYWZmbGVQcml6ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGVhcldlaWdodHNCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVyYXRpb25BbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0xpdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6ImEgYm9vbGVhbiBvZiB3aGV0aGVyIHRoZSBhdWN0aW9uIGlzIGxpdmUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc0JpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiYSBib29sZWFuIG9mIHdoZXRoZXIgdGhlIGFkZHJlc3MgaGFzIGJpZCBpbiB0aGUgYXVjdGlvbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWluaW11bUJpZEFtb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU9Fc2Nyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiRXNjcm93Q29uZmlnIiwibmFtZSI6ImNvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRpbiIsImRlc2MiOiJvcHRpbiB0ZWxscyB0aGUgY29udHJhY3QgdG8gb3B0IGludG8gYW4gYXNhIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byBiZSBvcHRlZCBpbnRvIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkF1Y3Rpb25NQlJEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MjUsImJ5dGVzIjoxMH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjpudWxsLCJzb3VyY2UiOm51bGwsImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBUEFBRUlCS0NOQm9BZy8vLy8vLy8vLy8vL0FhMysxZVRVaGYyb1dNK0NucnZ2Nzk2Q0ZOR0NucnZ2Nzk2Q0ZOU1FBcGloQSt5MEJQLy8vLzhQMUsrZ0JpWS9DV0pwWkY5aGMzTmxkQWxoYTJsMFlWOWtZVzhBQlhCeWFYcGxEV1Z1WkY5MGFXMWxjM1JoYlhBR1ltbGtYMmxrQjJKcFpGOW1aV1VFRlI5OGRRRmhER2x6WDNCeWFYcGxYMkp2ZUFaelpXeHNaWElJZDE5MGIzUmhiSE1SZDJWcFoyaDBjMTlpYjNoZlkyOTFiblFPZDJsdWJtbHVaMTkwYVdOclpYUUNBQUVNWVd0cGRHRmZaWE5qY205M0RYSmhabVpzWlY5M2FXNXVaWElTZDJWcFoyaDBaV1JmWW1sa1gzUnZkR0ZzQzJocFoyaGxjM1JmWW1sa0RYSmhabVpzWlY5aGJXOTFiblFSY21WbWRXNWtYMjFpY2w5amRYSnpiM0lOY0hKcGVtVmZZMnhoYVcxbFpBaEZVbEk2U1ZCQldSRjJjbVpmWm1GcGJIVnlaVjlqYjNWdWRCUnlZV1ptYkdWZmNISnBlbVZmWTJ4aGFXMWxaQlIxYm1seGRXVmZZV1JrY21WemMxOWpiM1Z1ZEFkbllYUmxYMmxrQzIxaGNtdGxkSEJzWVdObEFYY0dkMkZzYkdWMERISmxablZ1WkY5amIzVnVkQXh5WVdabWJHVmZjbTkxYm1RSVJWSlNPazFDUmtZUFkzSmxZWFJ2Y2w5eWIzbGhiSFI1RlcxaGNtdGxkSEJzWVdObFgzSnZlV0ZzZEdsbGN3aEZVbEk2UVU1TVZnaEZVbEk2UVVoT1JRRmlEM04wWVhKMFgzUnBiV1Z6ZEdGdGNCTm1hVzVrWDNkcGJtNWxjbDlqZFhKemIzSnpDRzVtZEY5bVpXVnpDRVZTVWpwUVdrNURBV3dCQUFoRlVsSTZUa1JCVHdoRlVsSTZTVmhHVWdNR2dRRURiMkZzQTJGaGJBeHpkR0Z5ZEdsdVoxOWlhV1FVWW1sa1gyMXBibWx0ZFcxZmFXNWpjbVZoYzJVSGRtVnljMmx2YmdSellXeDBDRVZTVWpwT1FWQlFDRVZTVWpwT1FWSkRDRVZTVWpwVFNFSkNCSzM1S3VRSVJWSlNPa1pIVkVVSVJWSlNPa2hIVkVVQ0FBQUlSVkpTT2tsU1FrUUlSVkpTT2xkT1JrUURjR0ZzTVJoQUFDd25GeUpuSng0aVp5Y1JJbWNuRWlKbkp3VWpaeWNUSW1jbkdDSm5KeGtpWnljVUkyY25EU0puSng4aVo0SURCQ1NId3l3RU1mSnFtd1Rxa1lEZE5ob0FqZ01BN1FEaEFOWXhHUlJFTVJoQkFMK0NGQVM5Y1VqUUJKZzJ5SjhFVFZoV2x3VFo5UEE2QkhhVktURUV1ZU9jWEFScFpRSGVCTDBiSjlFRThzNHZSZ1NkcndVS0JHWDhxWXNFQmVYZVRRU1BwS0ZnQkdDQ01Ed0VJSWxlSmdTdWhNdllCRFBwTEpRRWhVM3Q0QVErb1JneUJITVJFSEEyR2dDT0ZBVVJCdGdITVFkZ0I4WUlCUWdUQ2tzTHRnelBFYW9TWFJMckV2c1RHQk1qRTZVQUtoUEpBQUVBZ0NRVkgzeDFBQUFBQUFBQWlGUUFBQUFBQU1nWDFBQUFBQUFBQUVoRUFBQUFBQUFBU2RTd0kwTWpRNEFFZ3YraXpqWWFBSTRCQTFnQU1Sa2xFakVZRUVSQ0V4WXhHWUVGRWpFWUVFUkNCZmN4R1lFRkVqRVlFRVJDQlQyS0FnQ0wvb0VLQ0lzQU1nd05RUUFxc1lFR3NoQ0JCYklaSnk2eUhpY3VzaCtMLzQwQ0FBc0FCTE5DLzlzeUFMSUJRdi8xSXJJQlF2L3ZpWW9CQVl2L2dSS1JpLzhiZ1J1UklRMGFpLytCTzVGS2tVd2NJeDVGQVlFZkdrOENUSkFoRFJvWmlZb0JBVEVBaS85QUFBU0xBRXlKaS8rQUVtTnZiblJ5YjJ4c1pXUmZZV1JrY21WemMyVklRdi9qaWdJQmkvNG5MMlZJZ1JoYnNiSVlnQVE4R204enNocUwvN0lhZ1FheUVDS3lBYk8wUGtsWEJBQkxBVmNBQkNjSEVrUkpJbG1CQWdoTUZSSkVWd1lBU1JWSlFRQUhpd0VrRTBFQUJDS01BSW1MQUJkQy8vZUtCQUdML0RnWWkvMG5NR1ZJZ1NoYkVrRUFPWXY4T0JsQUFES0wvRGdiSlJKQkFDbUwvQ0xDR29BRVE1SW1WUkpCQUJxTC9DUENHb3YrRWtFQUQ0djhnUUxDR292L0ZoSkJBQUlqaVNLSmlnY0NJaXBIQXlLTCtrQUFCWXYvUUFGS0kwU0wrU2N3WlVna1c0d0RpLzBpV1lIVXhRRUxnZVRGQWdpTUFZdjZRQUJhc1lzRFNYSUlSSXNCaS80SXNnaXlCeU95RUNLeUFiYUwreGFML0JaUEFySVlnQVI3ZmNYOHNocE1zaHF5R292OXNocUJCcklRSXJJQnM3UStTVmNFQUV4WEFBUW5CeEpFU1JVa0VrUVhGb3NCRmxDTC9Zd0JqQUNKaXdOeUNFU0wrbkFBUlFGQkFJdUxBWXdDaXdOeUNFeU1BRVFpakFTTC8wRUFDb3NEY2doRUk0d0VqQVd4aXdOeUNFU0xBYklJc2djanNoQWlzZ0cyaXdSQkFBU0xCYklWaS9xeUVZditzaEtMQUxJVUpiSVFJcklCdG92N0ZvdjhGb3NEc2hpQUJLOGFGUEt5R2t5eUdySWFpLzJ5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNjSEVrUkpGU1FTUkJlTEFvd0JRdjliaXdFeUVBaU1BckdMQTBseUNFUXlFTElJc2djanNoQWlzZ0cyaS9vV1RMSVlnQVE1VHE2eXNocXlHb0VHc2hBaXNnR3pRdjlESWtMK3M0b0RBU0lxaS8weEFJajk3MGt5QTB4QUFIdUxBNHdBaS85QkFHbUxBRElERTBFQVlZdjlnQXQzWVd4c1pYUmZabVZsYzJWSUpGdEpJUVFPUkl2L0hTRUVsMG1NQVVBQUNJdi9RUUFESTR3Qk1nZEpnWUQxSkFpTEFVbE9BaGFMQUV4UUp3NU1VSXY5aS81UEJVOEVUd1JMQlNLSS9pcElWd2dJaS85UEFna1dURkNNQUltTC94WWlGbENNQUltTEFvQUljbVZtWlhKeVpYSmxTSXdBUXY5MktqWWFBVWtWSkJKRUZ6WWFBa2tWSXhKRUlsTTJHZ05KRlNRU1JCYzJHZ1JKRlNRU1JCYzJHZ1ZKRlNRU1JCYzJHZ1pKRlNRU1JCYzJHZ2RKRlNRU1JCYzJHZ2hKRlNRU1JCYzJHZ2xKRllFb0VrUTJHZ3BKRllFZ0VrUTJHZ3RKRlNRU1JCYzJHZ3hKRlNRU1JCYzJHZzFKRllFZ0VrUTJHZzVKSWxtQkFnaExBUlVTUkZjQ0FEWWFEMGNDRlVzQkpGbEpnUW9TUkU4Q1RFc0NVa2xPQWtrVlN3RWlXVW1CQ2hKRVRGSWlXWUVXQ0JKRU1nMUFBQVFuSUxBQUswc1FaeWNKU3c5bkp4VWlaMHNOUVFBVVN3MXhBRVJBQUF5QUNFVlNVanBKUVZOVXNBQW9TdzVuSndaTERXY25NVXNNWnljeVN3dG5KeVpMQ21jbkJFc0paNEFHWm5WdVpHVnlTd2huSndwTEIyY25JVXNHWnljYVN3Vm5KeHRMQkdkTEFTSmJTVVVTY2doRU1nTVRRQUFNZ0FoRlVsSTZTVUZRVUxBQUtVc1JaeWNQU3dGbkp6TkxBMmVCZUs4bkMweG5KeWVBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZuSnhBeUEyY25OREVYWnlJcFpVUW5LR1ZJZ1VoYkp5Sk1aeU5ES2treEZpTUpTVGdRSXhKRU5ob0JTUlVrRWtRWE1RQXlDUkpBQUFRbklMQUFJaWNHWlVSQUFBUW5OYkFBU1lFREQwQUFESUFJUlZKU09rMHpTRUt3QUVraERndEZBMHNCT0FjeUNoSkFBQVFuRnJBQVN3RTRDRXNERWtBQUJDY1dzQUFpUlFSTEEwc0JERUVBRlVzRFNSWW5IRXhRZ1lDQUFybElJd2hGQkVMLzR5Y01Td0ZuSTBNeEFESUpFa0FBQkNjZ3NBQWlKd1ZsUkNNTlFRQ1VJaWNGWlVTQkFna2lKeDVsUkJKQUFBUW5OckFBSWljVlpVUkFBQVFuS2JBQUlpY1laVVJBQUF5QUNFVlNVanBTVjBoRHNBQWlKd1ZsUkNJbkZHVkVFa0FBQkNjMnNBQWlKd3hsUkVFQUJDYzNzQUFpSndsbFJFQUFFckV5Q1NJclpVU3lFYklWSmJJUUlySUJzeUlvWlVSQkFCS3hNZ2tpS0dWRXNoR3lGU1d5RUNLeUFiT3hNZ215Q1NPeUVDS3lBYk1qUXlKQy8zQXhBRElKRWtBQUJDY2dzQUF5QnlJbkptVkVERUFBRElBSVJWSlNPa0ZCVTFTd0FDSW5ER1ZFUVFBRUp6ZXdBQ0luQ1dWRVFRQkJzU0luQ21WRUlpdGxSTElZSnppeUdySWFnUWF5RUNLeUFiTWlLR1ZFUVFBU3NUSUpJaWhsUkxJUnNoVWxzaEFpc2dHenNUSUpzZ2tqc2hBaXNnR3pJME94SWljS1pVUWlLMlZFc2hHeUZTV3lFQ0t5QWJOQy84RXhGb0VDQ1VrNEVDTVNSREVXSXdsSk9CQ0JCaEpFTmhvQlNSV0JJQkpFSWlsbFJERUFpUG5yaVBtL2lCR2pRQUFFSnlPd0FDSXBaVVFpSnhwbFJFc0VUd0pMQTA4RGlQb2dRQUFFSnptd0FFc0RTd0tJRDNJalF6RVdJd2xKT0JBakVrUTJHZ0ZKRllFZ0VrU0lFV0pBQUFRbkk3QUFJaWNhWlVSQkFBUW5PckFBU29nUFF5TkRNUmFCQXdsSk9CQWpFa1F4Rm9FQ0NVazRFQ1VTUkRFV0l3bEpPQkNCQmhKRU5ob0JTUldCSUJKRUlpbGxSREVBaVBsWWlQa3NpQkVRUUFBRUp5T3dBQ0lwWlVRaUp4cGxSRXNFVHdKTEEwOERpUG1OUUFBRUp6bXdBRXNFU3dSTEE0Z1BlU05ETVJhQkFnbEpPQkFqRWtReEZpTUpTVGdRSlJKRU5ob0JTUldCSUJKRWlCRENRQUFFSnlPd0FDSW5HbVZFUVFBRUp6cXdBRXNDU3dKTEFvZ1BPaU5ETmhvQlNSVWtFa1FYaUEvckkwTWlSd01xUndreUJ5SW5CR1ZFRFVBQUJDY2tzQUFpSncxbFJFRUFESUFJUlZKU09sZEJSRkt3QUNJbkgyVkVRQUFJTWdZa0NTY2ZUR2NpSng5bFJDSW5GMlZFSlFzSVNVVUhNZ1pNSkFnUFFBQU1nQWhGVWxJNlRrVlVUYkFBc1VzRkZpSW5OR1ZFU1JVV1Z3WUNURkFpS1dWRUp5OWxTQ0pic2hpQUJCaVRrc1d5R2t5eUdySWFnUWF5RUNLeUFiTzBQa2xYQkFCTEFWY0FCQ2NIRWtSSklsbUJBZ2hNRlJKRVZ3WUFTVVVORlVsRkEwQUFEU0luRjJWRUl3Z25GMHhuSTBNaVN3SkpUZ0lQSWtzQ1R3Sk5nUkJMQWcrQkVFOERUd0pOU3cxT0FsSkpSUTBWZ1JBU1FBQU1nQWhGVWxJNlNWSlRSTEFBU3d0Sklsc2lJUWNkUlFGSklRZ2VSUUZQQWg1RkFTRUhIVVVCSVFnZVRnSklUd0lrVzB3aENSNUZBUjVGQVNFSEhVVUJJUWtlUlFGTUZrd1dVRVVOSWljUlpVeEpUZ0pGQTBRaEJneEJBQVZKSXdoRkFTYzdSUTVKUVFEZFNTTU5RQUFFSnp5d0FFa2pDVWxGQ3lNTlFBQUVKenl3QUVzSlNSd2pIa1VCVEJoRkF5SkZCMHNNUlF0TEJpTU1RUUNLU3dwSklsdEpSUVloQngxRkFTRUlIa2xPQWtVTVNFd2tXMFVHUUFCbmdhS0Z2UGJlMzcyRktFc0ZTU0VISFVVQlR3SWVSUUZMQ2haTUZsQkxCWWoydm9FZ2tFOENpUGEyR1JaUVNWY0FFRXlCRUZ0SlJRcExCQTlCQUNSTENFc0xHQ01JRmtzUFNTSlpJd2dXVndZQVhBQk1VRVVQU3djakNFVUlSUXRDLzNsRkMwTC9leUVKUXYrZVN3cUFBZ0FTVUVzT1VFbUJFRmxMQVJWU2dRSmJKdzFNWnljWEltZEMvcEFoQmtVS1F2ODFJaXBIQmpZYUFVa1ZKQkpFRnlJbkJtVkVRQUFFSnpXd0FESUhJaWNFWlVRTlFBQUVKeVN3QUNJbkRXVkVRQUFNZ0FoRlVsSTZWMDVPUnJBQUlpY1FaVVF5QXhKQUFBeUFDRVZTVWpwWFFVWkVzQUFpSnlkbFJFa2lXMFVESkZ0RkJpSkZCQ0luREdWRVN3UU5RUUR5SWljTFpVUkxCQ1FMV3lJbkRXVkVTd2RQQWdoSlJRY01RUUREU3dFV1N3WVdVRWtpVzBsT0FrVUVKRnRGQnlJbkdXVkVTd0VKU1VzRFNVNEREVXhPQWsxSlJRTk1JUVVZU1VVS0lRVk1DVWxGQlExQkFBUkxBa1VCU3dFaEJRb1dKeHhNVUVVSlNZRThDeUtJOVRVaVJRUkxBMHNCREVFQVdFc0hTd1FJSkF0TENVd2t1aGRKSWljU1pVUVNRUUFPU3dZSVJRWkxBeU1JUlFSQy85TkxCa2xQQWdoRkNDSW5EV1ZFRGtFQUd5SW5EV1ZFU3djTVFRQVFTd0ZMQkFnV0p5cE1VTDVFSnhCTVowc0dSUVpDLzhSS0NCWkxCaFpRSnlkTVp5TkRTd0VoQlFoRkFrc0RJd2hGQkVzRVJRWkMvd05MQVJaTEJoWlFRdjhtSWtjREtrY0ROaG9CU1JVa0VrUVhJaWNWWlVSQUFBUW5LYkFBSWljR1pVUkJBQXNpSnhCbFJESURFMEVBNXlOQUFBUW5QYkFBSWljRlpVUWlKeFJsUkJOQUFBeUFDRVZTVWpwQlVrWkRzQUFpSnhSbFRFbE9Ba1VFUkNJbkJXVkVTd0VKU1VzRFNVNEREVXhPQWsxSlJRT0JQQXNpaVBRdklRcEZCa1VFU2doTEJBMUJBSUZMQXhZbkpVeFFTVVVKdmtSSmdjQUVVMHhYQUNCRkNrQUFFaUluQldWRUl3bExCQk5CQUFWTEE0Z0xsRXNIdkVnbkNFc0pVRWxGQ0wxRkFVQUFIVXNFUlFPeFN3S3lDRXNJc2djanNoQWlzZ0d6U3dNakNFVUVRditkU3daSnZrUVhUTHhJSVF0RkJCWW5La3hRU1VVSHZVVUJRZi9NU3dXOFNDRU1SUU5DLzhFaUp4UmxSRXNCQ0NjVVRHY2pReUpDL3hZaVJ3VXFSdzB5QnlJbkJHVkVEVUFBQkNja3NBQWlKeFZsUkVFQURJQUlSVkpTT2xCQlEweXdBQ0luQldWRUl3a1dKeVZNVUw1RVNWY0FJRVVWU1lFZ1cwVU5WeWdnUlE4aUp3bGxSRUVFTkxFaUsyVkVzaGduT0xJYVN4T3lHb0VHc2hBaXNnR3pJaWhsUkVBQXVFc0xpQWhGU1NKYlJRcEpKRnRNU1lFUVcwVUlnUmhiUlFRaUp3bGxSRUVBa2tzSkNFVU9TdzFBQUhkTERVVUhzU0luRDJWRWdRSmJjZ2hFU3dleUNMSUhJN0lRSXJJQnM3RWlKeHRsUkVzR1NVNENzZ2l5QnlPeUVDS3lBYk94c2doTERySUhJN0lRSXJJQnM3RWlKd3BsUkVzRHNnaXlCeU95RUNLeUFiTWlKd2xsUkVBQUZiRWlLMlZFY1F0RVN3bXlDTElISTdJUUlySUJzeWNWSTJjalF5SXBaVVFpU3crSTlRY2lXMFVIUXY5OFJRNUMvMjVMQzRnSGpVa2lXMFVLU1NSYlRFbUJFRnRGQ0lFWVcwVUVJaWNKWlVSQkF6aExDUWhGRGtzTlFBTWFTdzFGQnlJbkQyVkVnUUpiY2doRUlpaGxSSEFBUlFGQkFYbXhJaWxsUkhJSVJDSW9aVVN5RVVzSHNoS3lGQ1d5RUNLeUFiTWlKeHRsUkNJb1pVUndBRVVCUVFFaXNTSW5HMlZFSWlobFJMSVJTd2F5RXJJVUpiSVFJcklCc3lJb1pVUkxEMHh3QUVVQlFRRFJzU0lvWlVTeUVVc0ZzaEpMRHJJVUpiSVFJcklCc3lJbkNtVkVJaWhsUkhBQVJRRkJBSCt4SWljS1pVUWlLR1ZFc2hGTEE3SVNzaFFsc2hBaXNnR3pJaWNKWlVSQS93WWlLMlZFY1F0RUlpaGxSSEFBUlFGQkFCNnhJaXRsUkhFTFJDSW9aVVN5RVVzSnNoS3lGQ1d5RUNLeUFiTkMvdFlpS1dWRUlpaGxSQ0lyWlVSeEMwUkxDMGxPQWhaUUp3NU1VRThEVHdNaUlRWlBCRThGSW9qeVpFWUNRdjZvSWlsbFJDSW9aVVFpSndwbFJFc0ZTVTRDRmxBbkRreFFUd05QQXlJaEJrOEVUd1VpaVBJNFJnSkMvMjRpS1dWRUlpaGxSRXNIU1U0Q0Zrc1NURkFuRGt4UVR3TlBBaUloQms4RVR3VWlpUElPUmdKQy94c2lLV1ZFSWlobFJDSW5HMlZFU3doSlRnSVdVQ2NPVEZCUEEwOERJaUVHVHdSUEJTS0k4ZUpHQWtMK3l5SW9aVXhGREVRaUtXVkVTU2NkWlVoRkFra25QbVZJU1ZjSUNFVVVKRnRGQlNJbkQyVk1TVTRDUlJORVNTSlpTd0VWVWtsRkUxY0NBRXduSFdWSVRMRWpGa1VWU1JVV1Z3WUNURkNBQkFBQkFBSk1VRXl5R0lBRU9yS0pXN0lhc2hxQkJySVFJcklCczdRK1NWY0VBRXNCVndBRUp3Y1NSRWtpV1lFcEM0RUNDRXdWRWtSWEJpa2lXMGxGQ1VBQURJQUlSVkpTT2s1RlUwT3dBRXNQZ1FKYlNVVURTd2dTUUFBTWdBaEZVbEk2VjBWVFE3QUFzVW15R0lBRVd0OHpqN0lhU3hHeUdrc1NzaHBMRUxJYWdBb0FBUUFBQUFBQUFBQUFzaG9uTzdJYWdRYXlFQ0t5QVNJcFpVeEZEa1JMQVhJSVJDSkZDMHNMY0FCRkFVQUFHa3NNZ0E1eVpYWmxiblZsWDNOd2JHbDBjMlZJSWxrakNFVUtNaEJMQ2d1MlN3SnlDRVN5QjdJSUk3SVFJcklCdGtjQ0Zrc01GaWNPVEZCTEJySVlnQVJvTmVPOHNocE1zaHFBQVlDeUdySWFnUWF5RUNLeUFiYXlHSUFFYk1QMkJySWFnUWF5RUNLeUFVc0dRUUFXdGtzQmNnaEVTd3V5RVVzSHNoS3lGQ1d5RUNLeUFiTkMvUnNpS1dWRUlpaGxSRXNQaVBHcElsdEZCMEw4MWtVT1F2eklNZ29pSzJWRVRFc0JjQUJJUlFaTEZFeHdBRVVCUVFBVnNTSXJaVVN5RVVzVHNoVWxzaEFpc2dHelF2dTJJaWxsUkNJclpVUkxCa2xPQWhaTEYweFFKdzVNVUU4RFR3SWlJUVpQQkU4Rkk0anY2MFlDUXZ1TUtpSW5FR1ZFTWdNVFFBQUVKejJ3QUNJbkdHVkVRUUFNZ0FoRlVsSTZVa0ZRUTdBQUlpbGxSQ2NvWlVpQlVGc2lKeE5sUkVzQklRUU9SRWxQQWgwaEJKZEpSUU1KSWlobFJFQUFNTEVpSnc5bFJJRUNXM0lJUkVzQ3NnaXlCeU95RUNLeUFiT3hJaWNRWlVTeUI3SUlJN0lRSXJJQnN5Y1lJMmNqUTdFaUp3OWxSSUVDVzNJSVJDSW9aVVJKc2hGTEE3SVNUTElVSmJJUUlySUJzN0VpSnhCbFJMSVVzaEd5RWlXeUVDS3lBYk5DLzhNcU5ob0JTUlVrRWtRWE1nY2lKd1JsUkExQUFBUW5KTEFBSWljVlpVUkFBQVFuS2JBQUlpY1laVVJBQUF5QUNFVlNVanBTVGxCRHNBQkpnUjRMSW9qdHZ5SkZBa29NUVFBYklpY01aVVFqQ1VzQ1NVNENDUlluSEV4UXZFZ2pDRVVDUXYvZ0lpY01aVVJMQVVsT0Fna25ERXhuSVE0THNUSUpTd0d5Q0xJSEk3SVFJcklCc3hZbkIweFFzQ05EaUFXN0p5c2lUd0pVSndkTVVMQWpRellhQVVrVmdTQVNSQ2NJVEZDOVJRRW5LeUpQQWxRbkIweFFzQ05EaUFXb0ZpY0hURkN3STBNMkdnRkhBaFZMQVNKWlNZRUtFa1JQQWt4TEFsSWlXWUVNQ0JKRU1RQWlLV1ZFSngxbFNISUlSQkpBQUFRbkxMQUFKdzlMQVdjalF6WWFBVWtpV1lFQ0NFc0JGUkpFVndJQU1RQWlLV1ZFSngxbFNISUlSQkpBQUFRbkxMQUFJaWxsUkNjK1pVaUJFRnN5RFJKQUFBeUFDRVZTVWpwSlZWQkhzQUFuTTBzQlp5TkROaG9CU1JVa0VrUVhNUUFpS1dWRUp4MWxTSElJUkJKQUFBUW5MTEFBS1VzQlp5TkRNUllqQ1VrNEVDTVNSRFlhQVVrVkpCSkVGekVBTWdrU1FBQU1nQWhGVWxJNlJrOVNRckFBU3dFNEJ6SUtFa0FBRElBSVJWSlNPa2xRVFZLd0FFc0JPQWd5RUJKQUFBeUFDRVZTVWpwSlVFMUJzQUN4TWdwTEFiSVJJcklTc2hRbHNoQWlzZ0d6STBNaUp3VmxSRWtqQ0NjRlRHZUppZ01BS2pFQWkvNFdTVTRDVUl2L1VDY3JVSXY5RmljbFRGQk12eUluQm1WRVFRRG1Kd2d4QUZDOVJRRkJBRkluQ0RFQVVMNUVGMGtoQlFwSkZpY2NURkJQQWlFRkdDUUxTaVM2RjR2K1RBa2lKd3RsUkU4RUpBdE1Td0ZiSWljUlpVUkxBd2duRVV4blR3UlBCSXNCdTA4Q0NCWWlKd3RsUkU0Q1hTY0xUR2VKSWljWlpVeEpUZ0tNQUVRaUp3eGxSQ0VGQ3d4QUFBeUFDRVZTVWpwVVRWQlVzQUFpSnd0bFJJc0FTVTRDSVFVS1NTUUxUd0pMQVZzaUp4RmxSSXYrQ0NjUlRHY25DREVBVUVzRUZreExBYjlQQXhZbkhFeFFUd1FoQlJna0M0c0J1MHlML2dnV0lpY0xaVVJQQTA4Q1hTY0xUR2N4QUNjcVR3SlFUTDhpSnhsbFJDTUlKeGxNWjRrbkNERUFVTDFGQVVEL2F5Y0lNUUJRSWhhL2lZb0JBU0luQm1WRVNTRUVEa1NML3gwaEJKZEpRQUFRSWljR1pVUkJBQWlMLzBFQUF5Tk1pWXNBVEltS0FRRXFSd1FpU1NjaFpVUkJBQ1lpSnlGbFJFa2hCQTVFaS84ZElRU1hTWXdGUUFBUUlpY2haVVJCQUFpTC8wRUFBeU9NQlNJcFpVUW5LR1ZJU1lFNFc0d0VnVUJiU1l3RElvd0FRUUJ3SWlsbFJDSW5DbVZFc1V5QUEzTmhiR1ZJZ1JCYnNoaUFCTlYwdXhDeUdySWFnUWF5RUNLeUFiTzBQa2xYQkFCTVZ3QUVKd2NTUkVrVkpCSkVGMG1NQVNNTlFRQ0Npd0VqQ1lzRFNZc0VDVThDQzRIb0J3b0pTU0VFRGtTTC94MGhCSmRKakFCQUFBaUwvMEVBQXlPTUFDS01BaUluSW1WRVFRQW1JaWNpWlVSSklRUU9SSXYvSFNFRWwwbU1Ba0FBRUNJbkltVkVRUUFJaS85QkFBTWpqQUtMQlVtTEFFbE9Bd2lCQW9zQ1NVNEZDd2lMLzB3SlRCWlBBaFpRVHdJV1VFd1dVSXdBaVNOQy8zNktBZ0FxUndPSS9ZY2hDaWNJTVFCUXZVVUJRUUJ6aXdXTUFZditPQWhKakFPTEFRbU1BSWdCK1l3Q2kvNDRCeklLRWtBQUJDY1dzQUNMQW9zQkNJc0REa0FBQkNjV3NBQ0xCSXNBaS8rSS9Vd3lCeUluQkdWRWdYZ0pEVUVBRFNJbkJHVkVnYXdDQ0NjRVRHY2lKd1psUkVFQUQ0c0FpUDVDSWljVFpVUUlKeE5NWnljU2l3Qm5pU0VMakFFaUp3WmxSRUgvaFNFTWpBRkMvMzZLQXdBcVJ3S0kvT3NoQ2ljSU1RQlF2VVVCUVFDV2l3U01BWXY5T0FjeUNoSkFBQVFuRnJBQWkvMDRDSXNCRWtBQUJDY1dzQUNML2pnU2pBQ0lBVWVNQW92K09CUXlDaEpBQUFRbkxiQUFpd0NMQWc5QUFBUW5MYkFBaS80NEVTSW9aVVFTUUFBRUp5MndBSXNEaXdDTC80ajhqVElISWljRVpVU0JlQWtOUVFBTklpY0VaVVNCckFJSUp3Uk1aeUluQm1WRVFRQVBpd0NJL1lNaUp4TmxSQWduRTB4bkp4S0xBR2VKSVF1TUFTSW5CbVZFUWY5aUlReU1BVUwvVzRvQkFDSkpLaUluQldWRUl3bUwvdzFBQUF5QUNFVlNVanBEVWsxU3NBQ0wveFluSlV4UVNZd0F2VVVCUUFBTWdBaEZVbEk2UWs1R1JMQUFpd0MrUkVtQndBUlRTd0dCSUZ1TUFreFhBQ0NNQVVFQURJQUlSVkpTT2tKQlVrYXdBSXNBU1lGSUk3b2lJMVNCU0V5N2l3SkppUHpzQ1NJb1pVUkFBQnF4aXdHeUI3SUlJN0lRSXJJQnN5SW5IbVZFSXdnbkhreG5pYkVpS0dWRXNoR0xBYklVc2hJbHNoQWlzZ0d6UXYvZE1nY2lKeVpsUkE5QkFBMHlCeUluQkdWRURrRUFBaU9KSW9raUp4SmxSRUVBRENJbkVtVkVJaWN5WlVRSWlTSW5NV1ZFaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
