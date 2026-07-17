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

namespace Arc56.Generated.Potti1234.PottiSwap.Auction_b45a3265
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
            public class AuctionInstance : AVMObjectType
            {
                public ulong EscrowId { get; set; }

                public ulong EscrowAppId { get; set; }

                public ulong AuctionId { get; set; }

                public ulong StartPrice { get; set; }

                public ulong MinPrice { get; set; }

                public ulong Duration { get; set; }

                public Algorand.Address Creator { get; set; }

                public Algorand.Address Taker { get; set; }

                public ulong StartTime { get; set; }

                public ulong Sold { get; set; }

                public ulong SoldPrice { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrowId.From(EscrowId);
                    ret.AddRange(vEscrowId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrowAppId.From(EscrowAppId);
                    ret.AddRange(vEscrowAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuctionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAuctionId.From(AuctionId);
                    ret.AddRange(vAuctionId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartPrice.From(StartPrice);
                    ret.AddRange(vStartPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinPrice.From(MinPrice);
                    ret.AddRange(vMinPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDuration.From(Duration);
                    ret.AddRange(vDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTaker = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTaker.From(Taker);
                    ret.AddRange(vTaker.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartTime.From(StartTime);
                    ret.AddRange(vStartTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSold.From(Sold);
                    ret.AddRange(vSold.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSoldPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSoldPrice.From(SoldPrice);
                    ret.AddRange(vSoldPrice.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AuctionInstance Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AuctionInstance();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrowId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowId = vEscrowId.ToValue();
                    if (valueEscrowId is ulong vEscrowIdValue) { ret.EscrowId = vEscrowIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrowAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowAppId = vEscrowAppId.ToValue();
                    if (valueEscrowAppId is ulong vEscrowAppIdValue) { ret.EscrowAppId = vEscrowAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuctionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAuctionId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuctionId = vAuctionId.ToValue();
                    if (valueAuctionId is ulong vAuctionIdValue) { ret.AuctionId = vAuctionIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartPrice = vStartPrice.ToValue();
                    if (valueStartPrice is ulong vStartPriceValue) { ret.StartPrice = vStartPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinPrice = vMinPrice.ToValue();
                    if (valueMinPrice is ulong vMinPriceValue) { ret.MinPrice = vMinPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDuration = vDuration.ToValue();
                    if (valueDuration is ulong vDurationValue) { ret.Duration = vDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTaker = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTaker.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTaker = vTaker.ToValue();
                    if (valueTaker is Algorand.Address vTakerValue) { ret.Taker = vTakerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartTime = vStartTime.ToValue();
                    if (valueStartTime is ulong vStartTimeValue) { ret.StartTime = vStartTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSold.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSold = vSold.ToValue();
                    if (valueSold is ulong vSoldValue) { ret.Sold = vSoldValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSoldPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSoldPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSoldPrice = vSoldPrice.ToValue();
                    if (valueSoldPrice is ulong vSoldPriceValue) { ret.SoldPrice = vSoldPriceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AuctionInstance);
                }
                public bool Equals(AuctionInstance? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AuctionInstance left, AuctionInstance right)
                {
                    return EqualityComparer<AuctionInstance>.Default.Equals(left, right);
                }
                public static bool operator !=(AuctionInstance left, AuctionInstance right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="startPrice">Start Price of the auction </param>
        /// <param name="minPrice">Minimum Price of the auction </param>
        /// <param name="duration">Duration of the auction in seconds </param>
        /// <param name="escrowId">ID of the escrow </param>
        /// <param name="escrowAppId">ID of the escrow application </param>
        public async Task<ulong> CreateAuction(ulong startPrice, ulong minPrice, ulong duration, ulong escrowId, ulong escrowAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 86, 80, 163 };
            var startPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startPriceAbi.From(startPrice);
            var minPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minPriceAbi.From(minPrice);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);
            var escrowAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowAppIdAbi.From(escrowAppId);

            var result = await base.CallApp(new List<object> { abiHandle, startPriceAbi, minPriceAbi, durationAbi, escrowIdAbi, escrowAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateAuction_Transactions(ulong startPrice, ulong minPrice, ulong duration, ulong escrowId, ulong escrowAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 86, 80, 163 };
            var startPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startPriceAbi.From(startPrice);
            var minPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minPriceAbi.From(minPrice);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);
            var escrowAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowAppIdAbi.From(escrowAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, startPriceAbi, minPriceAbi, durationAbi, escrowIdAbi, escrowAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="auctionId"> </param>
        public async Task<ulong> GetCurrentPrice(ulong auctionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 80, 56, 25 };
            var auctionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); auctionIdAbi.From(auctionId);

            var result = await base.SimApp(new List<object> { abiHandle, auctionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCurrentPrice_Transactions(ulong auctionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 80, 56, 25 };
            var auctionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); auctionIdAbi.From(auctionId);

            return await base.MakeTransactionList(new List<object> { abiHandle, auctionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="auctionId"> </param>
        public async Task Bid(ulong auctionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 223, 229, 152 };
            var auctionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); auctionIdAbi.From(auctionId);

            var result = await base.CallApp(new List<object> { abiHandle, auctionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bid_Transactions(ulong auctionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 223, 229, 152 };
            var auctionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); auctionIdAbi.From(auctionId);

            return await base.MakeTransactionList(new List<object> { abiHandle, auctionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current time
        ///</summary>
        public async Task<ulong> LatestTimestamp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 204, 217, 48 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LatestTimestamp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 204, 217, 48 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXVjdGlvbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBdWN0aW9uSW5zdGFuY2UiOlt7Im5hbWUiOiJlc2Nyb3dJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlc2Nyb3dBcHBJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhdWN0aW9uSWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhcnRQcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5QcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkdXJhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0YWtlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3RhcnRUaW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNvbGQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic29sZFByaWNlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBdWN0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0UHJpY2UiLCJkZXNjIjoiU3RhcnQgUHJpY2Ugb2YgdGhlIGF1Y3Rpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pblByaWNlIiwiZGVzYyI6Ik1pbmltdW0gUHJpY2Ugb2YgdGhlIGF1Y3Rpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR1cmF0aW9uIiwiZGVzYyI6IkR1cmF0aW9uIG9mIHRoZSBhdWN0aW9uIGluIHNlY29uZHMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0lkIiwiZGVzYyI6IklEIG9mIHRoZSBlc2Nyb3ciLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0FwcElkIiwiZGVzYyI6IklEIG9mIHRoZSBlc2Nyb3cgYXBwbGljYXRpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiSUQgb2YgdGhlIGF1Y3Rpb25cclxuQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBSZWxheWVyLiBJZiB5b3UgYmlkIG9uIGFuIGF1Y3Rpb24gdGhlIHRha2VyIG9mIHRoZSBlc2Nyb3cgaXMgY2hhbmdlZCB0byB0aGUgYmlkZGVyLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEN1cnJlbnRQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdWN0aW9uSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdWN0aW9uSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGF0ZXN0VGltZXN0YW1wIiwiZGVzYyI6IkdldCBjdXJyZW50IHRpbWUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiQ3VycmVudCB0aW1lIG9mIHRoZSBibG9ja2NoYWluIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMyMywzNzBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI0XSwiZXJyb3JNZXNzYWdlIjoiRHVyYXRpb24gbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMV0sImVycm9yTWVzc2FnZSI6Ik1pbiBwcmljZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0LDEzMSwxNDcsMTY4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMwXSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgUmVsYXllciBjYW4gY3JlYXRlIGFuIGF1Y3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMThdLCJlcnJvck1lc3NhZ2UiOiJTdGFydCBwcmljZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3LDEzNCwxNTAsMTcxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MCwyOTAsMzAwLDMwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaGRXTjBhVzl1U1c1emRHRnVZMlZ6UVcxdmRXNTBJaUF3ZURFMU1XWTNZemMxSUNKaGRXTjBhVzl1U1c1emRHRnVZMlZ6SWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJR0YxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhWamRHbHZia2x1YzNSaGJtTmxjMEZ0YjNWdWRDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJkV04wYVc5dUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXhDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPRGsxTmpVd1lUTWdNSGd4T1RVd016Z3hPU0F3ZUdWa1pHWmxOVGs0SURCNE5qUmpZMlE1TXpBZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmRXTjBhVzl1S0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSRGRYSnlaVzUwVUhKcFkyVW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVltbGtLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKc1lYUmxjM1JVYVcxbGMzUmhiWEFvS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFFYVmpkR2x2Ymw5eWIzVjBaVUExSUcxaGFXNWZaMlYwUTNWeWNtVnVkRkJ5YVdObFgzSnZkWFJsUURZZ2JXRnBibDlpYVdSZmNtOTFkR1ZBTnlCdFlXbHVYMnhoZEdWemRGUnBiV1Z6ZEdGdGNGOXliM1YwWlVBNENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJkV04wYVc5dUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5c1lYUmxjM1JVYVcxbGMzUmhiWEJmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ2JHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpwWkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJkV04wYVc5dUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJpYVdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFEzVnljbVZ1ZEZCeWFXTmxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGMVkzUnBiMjRnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU4xY25KbGJuUlFjbWxqWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVkJkV04wYVc5dVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyRjFZM1JwYjI0dVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUYxWTNScGIyNGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVUYxWTNScGIyNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWFZqZEdsdmJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WVhWamRHbHZiaTVoYkdkdkxuUnpPanBCZFdOMGFXOXVMbU55WldGMFpVRjFZM1JwYjI0b2MzUmhjblJRY21salpUb2dkV2x1ZERZMExDQnRhVzVRY21salpUb2dkV2x1ZERZMExDQmtkWEpoZEdsdmJqb2dkV2x1ZERZMExDQmxjMk55YjNkSlpEb2dkV2x1ZERZMExDQmxjMk55YjNkQmNIQkpaRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21OeVpXRjBaVUYxWTNScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZORGN0TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYVmpkR2x2YmloemRHRnlkRkJ5YVdObE9pQjFhVzUwTmpRc0lHMXBibEJ5YVdObE9pQjFhVzUwTmpRc0lHUjFjbUYwYVc5dU9pQjFhVzUwTmpRc0lHVnpZM0p2ZDBsa09pQjFhVzUwTmpRc0lHVnpZM0p2ZDBGd2NFbGtPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoemRHRnlkRkJ5YVdObElENGdNQ3dnSWxOMFlYSjBJSEJ5YVdObElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUtUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWVhOelpYSjBJQzh2SUZOMFlYSjBJSEJ5YVdObElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyRjFZM1JwYjI0dVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxcGJsQnlhV05sSUQ0Z01Dd2dJazFwYmlCd2NtbGpaU0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxJaWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5hVzRnY0hKcFkyVWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmhjM05sY25Rb1pIVnlZWFJwYjI0Z1BpQXdMQ0FpUkhWeVlYUnBiMjRnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmhjM05sY25RZ0x5OGdSSFZ5WVhScGIyNGdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOekxDQWlUMjVzZVNCMGFHVWdVbVZzWVhsbGNpQmpZVzRnWTNKbFlYUmxJR0Z1SUdGMVkzUnBiMjRpS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCU1pXeGhlV1Z5SUdOaGJpQmpjbVZoZEdVZ1lXNGdZWFZqZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmxjMk55YjNkSlpEb2dibVYzSUZWcGJuUk9OalFvWlhOamNtOTNTV1FwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUdWelkzSnZkMEZ3Y0Vsa09pQnVaWGNnVldsdWRFNDJOQ2hsYzJOeWIzZEJjSEJKWkNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyRjFZM1JwYjI0dVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGMVkzUnBiMjVKYm5OMFlXNWpaWE5CYlc5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF3SUgwcE93b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GMVkzUnBiMjVKYm5OMFlXNWpaWE5CYlc5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmhkV04wYVc5dVNXUTZJRzVsZHlCVmFXNTBUalkwS0hSb2FYTXVZWFZqZEdsdmJrbHVjM1JoYm1ObGMwRnRiM1Z1ZEM1MllXeDFaU2tzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhOMFlYSjBVSEpwWTJVNklHNWxkeUJWYVc1MFRqWTBLSE4wWVhKMFVISnBZMlVwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUcxcGJsQnlhV05sT2lCdVpYY2dWV2x1ZEU0Mk5DaHRhVzVRY21salpTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdaSFZ5WVhScGIyNDZJRzVsZHlCVmFXNTBUalkwS0dSMWNtRjBhVzl1S1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCamNtVmhkRzl5T2lCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdkR0ZyWlhJNklHNWxkeUJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhOMFlYSjBWR2x0WlRvZ2JtVjNJRlZwYm5ST05qUW9kR2hwY3k1c1lYUmxjM1JVYVcxbGMzUmhiWEFvS1Nrc0NpQWdJQ0JqWVd4c2MzVmlJR3hoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qVTBMVFkyQ2lBZ0lDQXZMeUJqYjI1emRDQnVaWGRCZFdOMGFXOXVTVzV6ZEdGdVkyVWdQU0J1WlhjZ1FYVmpkR2x2YmtsdWMzUmhibU5sS0hzS0lDQWdJQzh2SUNBZ1pYTmpjbTkzU1dRNklHNWxkeUJWYVc1MFRqWTBLR1Z6WTNKdmQwbGtLU3dLSUNBZ0lDOHZJQ0FnWlhOamNtOTNRWEJ3U1dRNklHNWxkeUJWYVc1MFRqWTBLR1Z6WTNKdmQwRndjRWxrS1N3S0lDQWdJQzh2SUNBZ1lYVmpkR2x2Ymtsa09pQnVaWGNnVldsdWRFNDJOQ2gwYUdsekxtRjFZM1JwYjI1SmJuTjBZVzVqWlhOQmJXOTFiblF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGQnlhV05sT2lCdVpYY2dWV2x1ZEU0Mk5DaHpkR0Z5ZEZCeWFXTmxLU3dLSUNBZ0lDOHZJQ0FnYldsdVVISnBZMlU2SUc1bGR5QlZhVzUwVGpZMEtHMXBibEJ5YVdObEtTd0tJQ0FnSUM4dklDQWdaSFZ5WVhScGIyNDZJRzVsZHlCVmFXNTBUalkwS0dSMWNtRjBhVzl1S1N3S0lDQWdJQzh2SUNBZ1kzSmxZWFJ2Y2pvZ2JtVjNJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUhSaGEyVnlPaUJ1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdjM1JoY25SVWFXMWxPaUJ1WlhjZ1ZXbHVkRTQyTkNoMGFHbHpMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDZ3BLU3dLSUNBZ0lDOHZJQ0FnYzI5c1pEb2dibVYzSUZWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lITnZiR1JRY21salpUb2dibVYzSUZWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WVhWamRHbHZiaTVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJ6YjJ4a09pQnVaWGNnVldsdWRFNDJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02TlRRdE5qWUtJQ0FnSUM4dklHTnZibk4wSUc1bGQwRjFZM1JwYjI1SmJuTjBZVzVqWlNBOUlHNWxkeUJCZFdOMGFXOXVTVzV6ZEdGdVkyVW9ld29nSUNBZ0x5OGdJQ0JsYzJOeWIzZEpaRG9nYm1WM0lGVnBiblJPTmpRb1pYTmpjbTkzU1dRcExBb2dJQ0FnTHk4Z0lDQmxjMk55YjNkQmNIQkpaRG9nYm1WM0lGVnBiblJPTmpRb1pYTmpjbTkzUVhCd1NXUXBMQW9nSUNBZ0x5OGdJQ0JoZFdOMGFXOXVTV1E2SUc1bGR5QlZhVzUwVGpZMEtIUm9hWE11WVhWamRHbHZia2x1YzNSaGJtTmxjMEZ0YjNWdWRDNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lITjBZWEowVUhKcFkyVTZJRzVsZHlCVmFXNTBUalkwS0hOMFlYSjBVSEpwWTJVcExBb2dJQ0FnTHk4Z0lDQnRhVzVRY21salpUb2dibVYzSUZWcGJuUk9OalFvYldsdVVISnBZMlVwTEFvZ0lDQWdMeThnSUNCa2RYSmhkR2x2YmpvZ2JtVjNJRlZwYm5ST05qUW9aSFZ5WVhScGIyNHBMQW9nSUNBZ0x5OGdJQ0JqY21WaGRHOXlPaUJ1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdkR0ZyWlhJNklHNWxkeUJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNCemRHRnlkRlJwYldVNklHNWxkeUJWYVc1MFRqWTBLSFJvYVhNdWJHRjBaWE4wVkdsdFpYTjBZVzF3S0NrcExBb2dJQ0FnTHk4Z0lDQnpiMnhrT2lCdVpYY2dWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnYzI5c1pGQnlhV05sT2lCdVpYY2dWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklITnZiR1JRY21salpUb2dibVYzSUZWcGJuUk9OalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pVMExUWTJDaUFnSUNBdkx5QmpiMjV6ZENCdVpYZEJkV04wYVc5dVNXNXpkR0Z1WTJVZ1BTQnVaWGNnUVhWamRHbHZia2x1YzNSaGJtTmxLSHNLSUNBZ0lDOHZJQ0FnWlhOamNtOTNTV1E2SUc1bGR5QlZhVzUwVGpZMEtHVnpZM0p2ZDBsa0tTd0tJQ0FnSUM4dklDQWdaWE5qY205M1FYQndTV1E2SUc1bGR5QlZhVzUwVGpZMEtHVnpZM0p2ZDBGd2NFbGtLU3dLSUNBZ0lDOHZJQ0FnWVhWamRHbHZia2xrT2lCdVpYY2dWV2x1ZEU0Mk5DaDBhR2x6TG1GMVkzUnBiMjVKYm5OMFlXNWpaWE5CYlc5MWJuUXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQnpkR0Z5ZEZCeWFXTmxPaUJ1WlhjZ1ZXbHVkRTQyTkNoemRHRnlkRkJ5YVdObEtTd0tJQ0FnSUM4dklDQWdiV2x1VUhKcFkyVTZJRzVsZHlCVmFXNTBUalkwS0cxcGJsQnlhV05sS1N3S0lDQWdJQzh2SUNBZ1pIVnlZWFJwYjI0NklHNWxkeUJWYVc1MFRqWTBLR1IxY21GMGFXOXVLU3dLSUNBZ0lDOHZJQ0FnWTNKbFlYUnZjam9nYm1WM0lFRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJSFJoYTJWeU9pQnVaWGNnUVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ2MzUmhjblJVYVcxbE9pQnVaWGNnVldsdWRFNDJOQ2gwYUdsekxteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NncEtTd0tJQ0FnSUM4dklDQWdjMjlzWkRvZ2JtVjNJRlZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhOdmJHUlFjbWxqWlRvZ2JtVjNJRlZwYm5ST05qUW9NQ2tzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYVmpkR2x2YmtsdWMzUmhibU5sYzBGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURBZ2ZTazdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYVmpkR2x2YmtsdWMzUmhibU5sYzBGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSFJvYVhNdVlYVmpkR2x2YmtsdWMzUmhibU5sY3loMGFHbHpMbUYxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RdWRtRnNkV1VwTG5aaGJIVmxJRDBnYm1WM1FYVmpkR2x2YmtsdWMzUmhibU5sTG1OdmNIa29LVHNLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnY0hWaWJHbGpJR0YxWTNScGIyNUpibk4wWVc1alpYTWdQU0JDYjNoTllYQThkV2x1ZERZMExDQkJkV04wYVc5dVNXNXpkR0Z1WTJVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVhWamRHbHZia2x1YzNSaGJtTmxjeUlnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGRXTjBhVzl1U1c1emRHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11WVhWamRHbHZia2x1YzNSaGJtTmxjeWgwYUdsekxtRjFZM1JwYjI1SmJuTjBZVzVqWlhOQmJXOTFiblF1ZG1Gc2RXVXBMblpoYkhWbElEMGdibVYzUVhWamRHbHZia2x1YzNSaGJtTmxMbU52Y0hrb0tUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJR0YxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUYxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCMGFHbHpMbUYxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RdWRtRnNkV1VyS3pzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEIxWW14cFl5QmhkV04wYVc5dVNXNXpkR0Z1WTJWelFXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUYxWTNScGIyNUpibk4wWVc1alpYTkJiVzkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUm9hWE11WVhWamRHbHZia2x1YzNSaGJtTmxjMEZ0YjNWdWRDNTJZV3gxWlNzck93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklHRjFZM1JwYjI1SmJuTjBZVzVqWlhOQmJXOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBd0lIMHBPd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRjFZM1JwYjI1SmJuTjBZVzVqWlhOQmJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WVhWamRHbHZiaTVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aGRXTjBhVzl1U1c1emRHRnVZMlZ6UVcxdmRXNTBMblpoYkhWbElDMGdNVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk9rRjFZM1JwYjI0dVoyVjBRM1Z5Y21WdWRGQnlhV05sS0dGMVkzUnBiMjVKWkRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtZGxkRU4xY25KbGJuUlFjbWxqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyRjFZM1JwYjI0dVlXeG5ieTUwY3pvM05TMDNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUkRkWEp5Wlc1MFVISnBZMlVvWVhWamRHbHZia2xrT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR052Ym5OMElHRjFZM1JwYjI1SmJuTjBZVzVqWlNBOUlIUm9hWE11WVhWamRHbHZia2x1YzNSaGJtTmxjeWhoZFdOMGFXOXVTV1FwTG5aaGJIVmxMbU52Y0hrb0tUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZWFZqZEdsdmJpNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QndkV0pzYVdNZ1lYVmpkR2x2YmtsdWMzUmhibU5sY3lBOUlFSnZlRTFoY0R4MWFXNTBOalFzSUVGMVkzUnBiMjVKYm5OMFlXNWpaVDRvZXlCclpYbFFjbVZtYVhnNklDSmhkV04wYVc5dVNXNXpkR0Z1WTJWeklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUYxWTNScGIyNUpibk4wWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWTI5dWMzUWdZWFZqZEdsdmJrbHVjM1JoYm1ObElEMGdkR2hwY3k1aGRXTjBhVzl1U1c1emRHRnVZMlZ6S0dGMVkzUnBiMjVKWkNrdWRtRnNkV1V1WTI5d2VTZ3BPd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJGMVkzUnBiMjR1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnWTI5dWMzUWdaV3hoY0hObFpGUnBiV1U2SUhWcGJuUTJOQ0E5SUhSb2FYTXViR0YwWlhOMFZHbHRaWE4wWVcxd0tDa2dMU0JoZFdOMGFXOXVTVzV6ZEdGdVkyVXVjM1JoY25SVWFXMWxMbTVoZEdsMlpUc0tJQ0FnSUdOaGJHeHpkV0lnYkdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE1USWdMeThnTVRFeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCaGRXTjBhVzl1U1c1emRHRnVZMlV1YzNSaGNuUlFjbWxqWlM1dVlYUnBkbVVnTFFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJQ2hoZFdOMGFXOXVTVzV6ZEdGdVkyVXVjM1JoY25SUWNtbGpaUzV1WVhScGRtVWdMU0JoZFdOMGFXOXVTVzV6ZEdGdVkyVXViV2x1VUhKcFkyVXVibUYwYVhabEtTQXFJQ2hsYkdGd2MyVmtWR2x0WlNBdklHRjFZM1JwYjI1SmJuTjBZVzVqWlM1a2RYSmhkR2x2Ymk1dVlYUnBkbVVwT3dvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElEUXdJQzh2SURRd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk9EQXRPREVLSUNBZ0lDOHZJR0YxWTNScGIyNUpibk4wWVc1alpTNXpkR0Z5ZEZCeWFXTmxMbTVoZEdsMlpTQXRDaUFnSUNBdkx5QW9ZWFZqZEdsdmJrbHVjM1JoYm1ObExuTjBZWEowVUhKcFkyVXVibUYwYVhabElDMGdZWFZqZEdsdmJrbHVjM1JoYm1ObExtMXBibEJ5YVdObExtNWhkR2wyWlNrZ0tpQW9aV3hoY0hObFpGUnBiV1VnTHlCaGRXTjBhVzl1U1c1emRHRnVZMlV1WkhWeVlYUnBiMjR1Ym1GMGFYWmxLVHNLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIQnlhV05sT3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pwQmRXTjBhVzl1TG1KcFpDaGhkV04wYVc5dVNXUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbWxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2pnMUxUa3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z0x5b3FDaUFnSUNBdkx5QWdLaUJDYVdRZ2IyNGdZVzRnWVhWamRHbHZiZ29nSUNBZ0x5OGdJQ29LSUNBZ0lDOHZJQ0FxSUVCd1lYSmhiU0JoZFdOMGFXOXVTV1FnU1VRZ2IyWWdkR2hsSUdGMVkzUnBiMjRLSUNBZ0lDOHZJQ0FxSUVOaGJpQnZibXg1SUdKbElHTmhiR3hsWkNCaWVTQjBhR1VnZDJocGRHVnNhWE4wWldRZ2NtVnpiMngyWlhKekxpQkpaaUI1YjNVZ1ltbGtJRzl1SUdGdUlHRjFZM1JwYjI0Z2RHaGxJSFJoYTJWeUlHOW1JSFJvWlNCbGMyTnliM2NnYVhNZ1kyaGhibWRsWkNCMGJ5QjBhR1VnWW1sa1pHVnlMZ29nSUNBZ0x5OGdJQ292Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbWxrS0dGMVkzUnBiMjVKWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdZMjl1YzNRZ1lYVmpkR2x2YmtsdWMzUmhibU5sSUQwZ2RHaHBjeTVoZFdOMGFXOXVTVzV6ZEdGdVkyVnpLR0YxWTNScGIyNUpaQ2t1ZG1Gc2RXVXVZMjl3ZVNncE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWhkV04wYVc5dUxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIQjFZbXhwWXlCaGRXTjBhVzl1U1c1emRHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnUVhWamRHbHZia2x1YzNSaGJtTmxQaWg3SUd0bGVWQnlaV1pwZURvZ0ltRjFZM1JwYjI1SmJuTjBZVzVqWlhNaUlIMHBPd29nSUNBZ1lubDBaV05mTWlBdkx5QWlZWFZqZEdsdmJrbHVjM1JoYm1ObGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WVhWamRHbHZiaTVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUJqYjI1emRDQmhkV04wYVc5dVNXNXpkR0Z1WTJVZ1BTQjBhR2x6TG1GMVkzUnBiMjVKYm5OMFlXNWpaWE1vWVhWamRHbHZia2xrS1M1MllXeDFaUzVqYjNCNUtDazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5SUWNtbGpaU0E5SUhSb2FYTXVaMlYwUTNWeWNtVnVkRkJ5YVdObEtHRjFZM1JwYjI1SlpDazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFEzVnljbVZ1ZEZCeWFXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTloZFdOMGFXOXVMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR0YxWTNScGIyNUpibk4wWVc1alpTNTBZV3RsY2lBOUlHNWxkeUJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUE0TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdllYVmpkR2x2Ymk1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCaGRXTjBhVzl1U1c1emRHRnVZMlV1YzI5c1pDQTlJRzVsZHlCVmFXNTBUalkwS0RFcE93b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdjbVZ3YkdGalpUSWdNVEl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUdGMVkzUnBiMjVKYm5OMFlXNWpaUzV6YjJ4a1VISnBZMlVnUFNCdVpYY2dWV2x1ZEU0Mk5DaGpkWEp5Wlc1MFVISnBZMlVwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVEk0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5aGRXTjBhVzl1TG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhSb2FYTXVZWFZqZEdsdmJrbHVjM1JoYm1ObGN5aGhkV04wYVc5dVNXUXBMblpoYkhWbElEMGdZWFZqZEdsdmJrbHVjM1JoYm1ObExtTnZjSGtvS1RzS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6bzZRWFZqZEdsdmJpNXNZWFJsYzNSVWFXMWxjM1JoYlhBb0tTQXRQaUIxYVc1ME5qUTZDbXhoZEdWemRGUnBiV1Z6ZEdGdGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMkYxWTNScGIyNHVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3T3dvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQkJaaGRXTjBhVzl1U1c1emRHRnVZMlZ6UVcxdmRXNTBCQlVmZkhVUVlYVmpkR2x2YmtsdWMzUmhibU5sY3dnQUFBQUFBQUFBQURFWVFBQURLQ05uTVJ0QkFJQ0NCQVNKVmxDakJCbFFPQmtFN2QvbG1BUmt6Tmt3TmhvQWpnUUFPQUFqQUJNQUFpTkRNUmtVUkRFWVJJZ0JHQllwVEZDd0lrTXhHUlJFTVJoRU5ob0JGNGdBMlNKRE1Sa1VSREVZUkRZYUFSZUlBSnNXS1V4UXNDSkRNUmtVUkRFWVJEWWFBUmMyR2dJWE5ob0RGellhQkJjMkdnVVhpQUFTRmlsTVVMQWlRekVaUVArZU1SZ1VSQ0pEaWdVQmkvdEVpL3hFaS8xRU1RQXlDUkpFaS80V2kvOFdJeWhsUkJhTCt4YUwvQmFML1JZeEFFbUlBSkFXVHdoUENGQlBCMUJQQmxCUEJWQlBCRkJQQTFCUEFsQk1VQ3RRSzFBaktHVkVGaXBNVUV5L0l5aGxSQ0lJS0V4bkl5aGxSQ0lKaVlvQkFZdi9GaXBNVUw1RWlBQktTd0dCY0ZzSlN3R0JHRnRMQW9FZ1cwc0JUQWxQQTRFb1cwOERUQW9MQ1ltS0FRQ0wveFlxVEZCSnZrU0wvNGovd1RFQVR3Sk1YRkNBQ0FBQUFBQUFBQUFCWEhoTUZseUF2NGt5QjRrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
