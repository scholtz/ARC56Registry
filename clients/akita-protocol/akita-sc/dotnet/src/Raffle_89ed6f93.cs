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

namespace Arc56.Generated.akita_protocol.akita_sc.Raffle_89ed6f93
{


    public class RaffleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RaffleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EntryData : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public Algorand.Address Marketplace { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vMarketplace.From(Marketplace);
                    ret.AddRange(vMarketplace.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EntryData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EntryData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketplace = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vMarketplace.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMarketplace = vMarketplace.ToValue();
                    if (valueMarketplace is Algorand.Address vMarketplaceValue) { ret.Marketplace = vMarketplaceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EntryData);
                }
                public bool Equals(EntryData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EntryData left, EntryData right)
                {
                    return EqualityComparer<EntryData>.Default.Equals(left, right);
                }
                public static bool operator !=(EntryData left, EntryData right)
                {
                    return !(left == right);
                }

            }

            public class FindWinnerCursors : AVMObjectType
            {
                public ulong Index { get; set; }

                public ulong AmountIndex { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIndex.From(Index);
                    ret.AddRange(vIndex.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountIndex.From(AmountIndex);
                    ret.AddRange(vAmountIndex.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIndex = vIndex.ToValue();
                    if (valueIndex is ulong vIndexValue) { ret.Index = vIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountIndex = vAmountIndex.ToValue();
                    if (valueAmountIndex is ulong vAmountIndexValue) { ret.AmountIndex = vAmountIndexValue; }
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

            public class RaffleMbrData : AVMObjectType
            {
                public ulong Entries { get; set; }

                public ulong Weights { get; set; }

                public ulong EntriesByAddress { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntries = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntries.From(Entries);
                    ret.AddRange(vEntries.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeights = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeights.From(Weights);
                    ret.AddRange(vWeights.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntriesByAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntriesByAddress.From(EntriesByAddress);
                    ret.AddRange(vEntriesByAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RaffleMbrData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RaffleMbrData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntries = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntries.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntries = vEntries.ToValue();
                    if (valueEntries is ulong vEntriesValue) { ret.Entries = vEntriesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeights = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeights.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeights = vWeights.ToValue();
                    if (valueWeights is ulong vWeightsValue) { ret.Weights = vWeightsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntriesByAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntriesByAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntriesByAddress = vEntriesByAddress.ToValue();
                    if (valueEntriesByAddress is ulong vEntriesByAddressValue) { ret.EntriesByAddress = vEntriesByAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RaffleMbrData);
                }
                public bool Equals(RaffleMbrData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RaffleMbrData left, RaffleMbrData right)
                {
                    return EqualityComparer<RaffleMbrData>.Default.Equals(left, right);
                }
                public static bool operator !=(RaffleMbrData left, RaffleMbrData right)
                {
                    return !(left == right);
                }

            }

            public class RaffleState : AVMObjectType
            {
                public ulong TicketAsset { get; set; }

                public ulong StartTimestamp { get; set; }

                public ulong EndTimestamp { get; set; }

                public Algorand.Address Seller { get; set; }

                public ulong MinTickets { get; set; }

                public ulong MaxTickets { get; set; }

                public ulong EntryCount { get; set; }

                public ulong TicketCount { get; set; }

                public ulong WinningTicket { get; set; }

                public Algorand.Address Winner { get; set; }

                public ulong Prize { get; set; }

                public bool PrizeClaimed { get; set; }

                public ulong GateId { get; set; }

                public ulong VrfFailureCount { get; set; }

                public ulong EntryId { get; set; }

                public ulong RefundMbrCursor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTicketAsset.From(TicketAsset);
                    ret.AddRange(vTicketAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartTimestamp.From(StartTimestamp);
                    ret.AddRange(vStartTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndTimestamp.From(EndTimestamp);
                    ret.AddRange(vEndTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinTickets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinTickets.From(MinTickets);
                    ret.AddRange(vMinTickets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxTickets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxTickets.From(MaxTickets);
                    ret.AddRange(vMaxTickets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntryCount.From(EntryCount);
                    ret.AddRange(vEntryCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTicketCount.From(TicketCount);
                    ret.AddRange(vTicketCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinningTicket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWinningTicket.From(WinningTicket);
                    ret.AddRange(vWinningTicket.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWinner.From(Winner);
                    ret.AddRange(vWinner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrize.From(Prize);
                    ret.AddRange(vPrize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrizeClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPrizeClaimed.From(PrizeClaimed);
                    ret.AddRange(vPrizeClaimed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGateId.From(GateId);
                    ret.AddRange(vGateId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVrfFailureCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVrfFailureCount.From(VrfFailureCount);
                    ret.AddRange(vVrfFailureCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntryId.From(EntryId);
                    ret.AddRange(vEntryId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefundMbrCursor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRefundMbrCursor.From(RefundMbrCursor);
                    ret.AddRange(vRefundMbrCursor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RaffleState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RaffleState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTicketAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTicketAsset = vTicketAsset.ToValue();
                    if (valueTicketAsset is ulong vTicketAssetValue) { ret.TicketAsset = vTicketAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartTimestamp = vStartTimestamp.ToValue();
                    if (valueStartTimestamp is ulong vStartTimestampValue) { ret.StartTimestamp = vStartTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndTimestamp = vEndTimestamp.ToValue();
                    if (valueEndTimestamp is ulong vEndTimestampValue) { ret.EndTimestamp = vEndTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinTickets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinTickets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinTickets = vMinTickets.ToValue();
                    if (valueMinTickets is ulong vMinTicketsValue) { ret.MinTickets = vMinTicketsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxTickets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxTickets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxTickets = vMaxTickets.ToValue();
                    if (valueMaxTickets is ulong vMaxTicketsValue) { ret.MaxTickets = vMaxTicketsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntryCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryCount = vEntryCount.ToValue();
                    if (valueEntryCount is ulong vEntryCountValue) { ret.EntryCount = vEntryCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTicketCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTicketCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTicketCount = vTicketCount.ToValue();
                    if (valueTicketCount is ulong vTicketCountValue) { ret.TicketCount = vTicketCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinningTicket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWinningTicket.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinningTicket = vWinningTicket.ToValue();
                    if (valueWinningTicket is ulong vWinningTicketValue) { ret.WinningTicket = vWinningTicketValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWinner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinner = vWinner.ToValue();
                    if (valueWinner is Algorand.Address vWinnerValue) { ret.Winner = vWinnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrize = vPrize.ToValue();
                    if (valuePrize is ulong vPrizeValue) { ret.Prize = vPrizeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrizeClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPrizeClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrizeClaimed = vPrizeClaimed.ToValue();
                    if (valuePrizeClaimed is bool vPrizeClaimedValue) { ret.PrizeClaimed = vPrizeClaimedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGateId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGateId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGateId = vGateId.ToValue();
                    if (valueGateId is ulong vGateIdValue) { ret.GateId = vGateIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVrfFailureCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVrfFailureCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVrfFailureCount = vVrfFailureCount.ToValue();
                    if (valueVrfFailureCount is ulong vVrfFailureCountValue) { ret.VrfFailureCount = vVrfFailureCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntryId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryId = vEntryId.ToValue();
                    if (valueEntryId is ulong vEntryIdValue) { ret.EntryId = vEntryIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefundMbrCursor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRefundMbrCursor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRefundMbrCursor = vRefundMbrCursor.ToValue();
                    if (valueRefundMbrCursor is ulong vRefundMbrCursorValue) { ret.RefundMbrCursor = vRefundMbrCursorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RaffleState);
                }
                public bool Equals(RaffleState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RaffleState left, RaffleState right)
                {
                    return EqualityComparer<RaffleState>.Default.Equals(left, right);
                }
                public static bool operator !=(RaffleState left, RaffleState right)
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
        /// <param name="ticketAsset"> </param>
        /// <param name="startTimestamp"> </param>
        /// <param name="endTimestamp"> </param>
        /// <param name="seller"> </param>
        /// <param name="funder"> FunderInfo</param>
        /// <param name="creatorRoyalty"> </param>
        /// <param name="minTickets"> </param>
        /// <param name="maxTickets"> </param>
        /// <param name="gateID"> </param>
        /// <param name="marketplace"> </param>
        /// <param name="akitaDAO"> </param>
        /// <param name="akitaDAOEscrow"> EscrowConfig</param>
        public async Task Create(ulong prize, bool isPrizeBox, ulong ticketAsset, ulong startTimestamp, ulong endTimestamp, Algorand.Address seller, Structs.FunderInfo funder, ulong creatorRoyalty, ulong minTickets, ulong maxTickets, ulong gateID, Algorand.Address marketplace, ulong akitaDAO, Structs.EscrowConfig akitaDAOEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 35, 39, 21 };
            var prizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); prizeAbi.From(prize);
            var isPrizeBoxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); isPrizeBoxAbi.From(isPrizeBox);
            var ticketAssetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticketAssetAbi.From(ticketAsset);
            var startTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimestampAbi.From(startTimestamp);
            var endTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endTimestampAbi.From(endTimestamp);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var creatorRoyaltyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creatorRoyaltyAbi.From(creatorRoyalty);
            var minTicketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTicketsAbi.From(minTickets);
            var maxTicketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxTicketsAbi.From(maxTickets);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, prizeAbi, isPrizeBoxAbi, ticketAssetAbi, startTimestampAbi, endTimestampAbi, sellerAbi, funder, creatorRoyaltyAbi, minTicketsAbi, maxTicketsAbi, gateIDAbi, marketplaceAbi, akitaDAOAbi, akitaDAOEscrow }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong prize, bool isPrizeBox, ulong ticketAsset, ulong startTimestamp, ulong endTimestamp, Algorand.Address seller, Structs.FunderInfo funder, ulong creatorRoyalty, ulong minTickets, ulong maxTickets, ulong gateID, Algorand.Address marketplace, ulong akitaDAO, Structs.EscrowConfig akitaDAOEscrow, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 35, 39, 21 };
            var prizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); prizeAbi.From(prize);
            var isPrizeBoxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); isPrizeBoxAbi.From(isPrizeBox);
            var ticketAssetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticketAssetAbi.From(ticketAsset);
            var startTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTimestampAbi.From(startTimestamp);
            var endTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endTimestampAbi.From(endTimestamp);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var creatorRoyaltyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creatorRoyaltyAbi.From(creatorRoyalty);
            var minTicketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTicketsAbi.From(minTickets);
            var maxTicketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxTicketsAbi.From(maxTickets);
            var gateIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIDAbi.From(gateID);
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, prizeAbi, isPrizeBoxAbi, ticketAssetAbi, startTimestampAbi, endTimestampAbi, sellerAbi, funder, creatorRoyaltyAbi, minTicketsAbi, maxTicketsAbi, gateIDAbi, marketplaceAbi, akitaDAOAbi, akitaDAOEscrow }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        public async Task<ulong> ClearWeightsBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 148, 37, 20 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ClearWeightsBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 148, 37, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        /// <param name="gateTxn"> </param>
        /// <param name="payment"> </param>
        /// <param name="marketplace"> </param>
        public async Task GatedEnter(ApplicationCallTransaction gateTxn, PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment });
            byte[] abiHandle = { 92, 87, 246, 216 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, gateTxn, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedEnter_Transactions(ApplicationCallTransaction gateTxn, PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment });
            byte[] abiHandle = { 92, 87, 246, 216 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, gateTxn, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="marketplace"> </param>
        public async Task Enter(PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 150, 39, 18, 241 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Enter_Transactions(PaymentTransaction payment, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 150, 39, 18, 241 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gateTxn"> </param>
        /// <param name="payment"> </param>
        /// <param name="assetXfer"> </param>
        /// <param name="marketplace"> </param>
        public async Task GatedEnterAsa(ApplicationCallTransaction gateTxn, PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment, assetXfer });
            byte[] abiHandle = { 56, 230, 36, 51 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, gateTxn, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedEnterAsa_Transactions(ApplicationCallTransaction gateTxn, PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment, assetXfer });
            byte[] abiHandle = { 56, 230, 36, 51 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, gateTxn, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="assetXfer"> </param>
        /// <param name="marketplace"> </param>
        public async Task EnterAsa(PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer });
            byte[] abiHandle = { 67, 165, 62, 78 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EnterAsa_Transactions(PaymentTransaction payment, AssetTransferTransaction assetXfer, Algorand.Address marketplace, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment, assetXfer });
            byte[] abiHandle = { 67, 165, 62, 78 };
            var marketplaceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); marketplaceAbi.From(marketplace);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetXfer, marketplaceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gateTxn"> </param>
        /// <param name="payment"> </param>
        public async Task GatedAdd(ApplicationCallTransaction gateTxn, PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment });
            byte[] abiHandle = { 220, 80, 179, 84 };

            var result = await base.CallApp(new List<object> { abiHandle, gateTxn, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedAdd_Transactions(ApplicationCallTransaction gateTxn, PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, payment });
            byte[] abiHandle = { 220, 80, 179, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle, gateTxn, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Add(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 106, 109, 155, 159 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Add_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 106, 109, 155, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="gateTxn"> </param>
        /// <param name="assetXfer"> </param>
        public async Task GatedAddAsa(ApplicationCallTransaction gateTxn, AssetTransferTransaction assetXfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, assetXfer });
            byte[] abiHandle = { 99, 187, 183, 53 };

            var result = await base.CallApp(new List<object> { abiHandle, gateTxn, assetXfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedAddAsa_Transactions(ApplicationCallTransaction gateTxn, AssetTransferTransaction assetXfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn, assetXfer });
            byte[] abiHandle = { 99, 187, 183, 53 };

            return await base.MakeTransactionList(new List<object> { abiHandle, gateTxn, assetXfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetXfer"> </param>
        public async Task AddAsa(AssetTransferTransaction assetXfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetXfer });
            byte[] abiHandle = { 235, 22, 129, 180 };

            var result = await base.CallApp(new List<object> { abiHandle, assetXfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddAsa_Transactions(AssetTransferTransaction assetXfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { assetXfer });
            byte[] abiHandle = { 235, 22, 129, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle, assetXfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        public async Task<Structs.RaffleState> GetState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 87, 38, 241 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RaffleState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 87, 38, 241 };

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
        ///
        ///</summary>
        public async Task<Structs.RaffleMbrData> Mbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 163, 95, 164 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RaffleMbrData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Mbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 163, 95, 164 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmFmZmxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVudHJ5RGF0YSI6W3sibmFtZSI6ImFjY291bnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1hcmtldHBsYWNlIiwidHlwZSI6ImFkZHJlc3MifV0sIkZpbmRXaW5uZXJDdXJzb3JzIjpbeyJuYW1lIjoiaW5kZXgiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50SW5kZXgiLCJ0eXBlIjoidWludDY0In1dLCJSYWZmbGVNQlJEYXRhIjpbeyJuYW1lIjoiZW50cmllcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3ZWlnaHRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVudHJpZXNCeUFkZHJlc3MiLCJ0eXBlIjoidWludDY0In1dLCJSYWZmbGVTdGF0ZSI6W3sibmFtZSI6InRpY2tldEFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVuZFRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1pblRpY2tldHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4VGlja2V0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbnRyeUNvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpY2tldENvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Indpbm5pbmdUaWNrZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2lubmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwcml6ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcml6ZUNsYWltZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImdhdGVJRCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2cmZGYWlsdXJlQ291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW50cnlJRCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWZ1bmRNQlJDdXJzb3IiLCJ0eXBlIjoidWludDY0In1dLCJFc2Nyb3dDb25maWciOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFwcCIsInR5cGUiOiJ1aW50NjQifV0sIkZ1bmRlckluZm8iOlt7Im5hbWUiOiJhY2NvdW50IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcml6ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzUHJpemVCb3giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldEFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydFRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kVGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQpIiwic3RydWN0IjoiRnVuZGVySW5mbyIsIm5hbWUiOiJmdW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3JSb3lhbHR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5UaWNrZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhUaWNrZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRwbGFjZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IkVzY3Jvd0NvbmZpZyIsIm5hbWUiOiJha2l0YURBT0VzY3JvdyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndlaWdodExpc3RMZW5ndGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kTUJSIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZXJhdGlvbkFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGVhcldlaWdodHNCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXRlZEVudGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW50ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldHBsYWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhdGVkRW50ZXJBc2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGVUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRYZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW50ZXJBc2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldFhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXJrZXRwbGFjZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXRlZEFkZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXRlZEFkZEFzYSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldFhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkQXNhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRYZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJhZmZsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5kV2lubmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZXJhdGlvbkFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbVJhZmZsZVByaXplIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzTGl2ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiYSBib29sZWFuIG9mIHdoZXRoZXIgdGhlIGF1Y3Rpb24gaXMgbGl2ZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzLHVpbnQ2NCxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSYWZmbGVTdGF0ZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPRXNjcm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IkVzY3Jvd0NvbmZpZyIsIm5hbWUiOiJjb25maWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1ZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSYWZmbGVNQlJEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRpbiIsImRlc2MiOiJvcHRpbiB0ZWxscyB0aGUgY29udHJhY3QgdG8gb3B0IGludG8gYW4gYXNhIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byBiZSBvcHRlZCBpbnRvIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyMSwiYnl0ZXMiOjl9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6bnVsbCwic291cmNlIjpudWxsLCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QU5BQUVJQklBZ29JMEcvLy8vLy8vLy8vLy9BYWlMQTYzKzFlVFVoZjJvV00rQ25ydnY3OTZDRk5HQ25ydnY3OTZDRlAvLy8vOFAxSytnQmlZN0RIUnBZMnRsZEY5aGMzTmxkQWxoYTJsMFlWOWtZVzhBQzJWdWRISjVYMk52ZFc1MERIUnBZMnRsZEY5amIzVnVkQVozYVc1dVpYSUZjSEpwZW1VSFoyRjBaVjlwWkFoM1gzUnZkR0ZzY3dGaEJCVWZmSFVPZDJsdWJtbHVaMTkwYVdOclpYUVJkMlZwWjJoMGMxOWliM2hmWTI5MWJuUUlSVkpTT2tsUVFWa05jSEpwZW1WZlkyeGhhVzFsWkJGeVpXWjFibVJmYldKeVgyTjFjbk52Y2dJQUFRWnpaV3hzWlhJQmR3dHRZWGhmZEdsamEyVjBjd3hoYTJsMFlWOWxjMk55YjNjSVJWSlNPa2xZUmxJUmRuSm1YMlpoYVd4MWNtVmZZMjkxYm5RTlpXNWtYM1JwYldWemRHRnRjQXR0WVhKclpYUndiR0ZqWlFGbEJuZGhiR3hsZEF4eVlXWm1iR1ZmY205MWJtUVBZM0psWVhSdmNsOXliM2xoYkhSNUMyMXBibDkwYVdOclpYUnpGVzFoY210bGRIQnNZV05sWDNKdmVXRnNkR2xsY3hObWFXNWtYM2RwYm01bGNsOWpkWEp6YjNKekNFVlNVanBHUjFSRkNFVlNVanBPVEVsV0NFVlNVanBDVFVkT0NFVlNVanBOUWtaR0RHbHpYM0J5YVhwbFgySnZlQTl6ZEdGeWRGOTBhVzFsYzNSaGJYQU5ZV3RwZEdGZmNtOTVZV3gwZVFoRlVsSTZVRTVEVEFoRlVsSTZUa1JCVHdobGJuUnllVjlwWkFSY1YvYllCRGptSkRNRTNGQ3pWQVJqdTdjMUF3YUJBUU5oWVd3RGIyRnNCSE5oYkhRSVJWSlNPbGRPUmtRSVJWSlNPbEpJVGtVQ0FBQUlSVkpTT2tsU1FrUURjR0ZzQ0VWU1VqcFVRVTVCQ0VWU1VqcEJSVTVVQ0VWU1VqcFVRVUZNQ0VWU1VqcEZSRTVGTVJoQUFDTXJJbWNuQkNKbkp3c2laeWNPSW1jbkZpSm5KeWtpWnljTUltY25EeUpuSnhzaVo0SUNCQ1NId3l3RTZwR0EzVFlhQUk0Q0FOa0F6akVaRkVReEdFRUF0NElEQkwxeFNOQUU4czR2UmdRc2xDVVVKeXFBQkpZbkV2RW5LNEFFUTZVK1RpY3NnQVJxYlp1Zkp5MkNDd1RyRm9HMEJHbGxBZDRFdlJzbjBRUmwvS21MQkkra29XQUVubGNtOFFTdWhNdllCRFBwTEpRRWhVM3Q0QVRabzEra0JENmhHREkyR2dDT0ZRVWhCYkFHV3diOEJ6b0hVZ2VpQjhVSCtBZ0hDRG9JU1FwOUM5Z1JSQkZWRWVvU2N3QWlBQUVTbHdDQUhCVWZmSFVBQUFBQUFBQjcxQUFBQUFBQXlCZlVBQUFBQUFBQVNkU3dJME1qUTRBRU9pTW5GVFlhQUk0QkF4NEFNUmtsRWpFWUVFUkNFZVV4R1lFRkVqRVlFRVJDQm15S0FnQ0wvb0VLQ0lzQU1nd05RUUFxc1lFR3NoQ0JCYklaSnk2eUhpY3VzaCtMLzQwQ0FBc0FCTE5DLzlzeUFMSUJRdi8xSXJJQlF2L3ZpWW9CQVl2L2dSS1JpLzhiZ1J1UklRc2FpLytCTzVGS2tVd2NJeDVGQVlFZkdrOENUSkFoQ3hvWmlZb0VBWXY4T0JpTC9TY3ZaVWlCS0ZzU1FRQTVpL3c0R1VBQU1vdjhPQnNsRWtFQUtZdjhJc0lhZ0FSRGtpWlZFa0VBR292OEk4SWFpLzRTUVFBUGkveUJBc0lhaS84V0VrRUFBaU9KSW9tS0J3SWlLa2NESW92NlFBQUZpLzlBQVVvalJJdjVKeTlsU0NSYmpBT0wvU0paZ2RURkFRdUI1TVVDQ0l3QmkvcEFBRnF4aXdOSmNnaEVpd0dML2dpeUNMSUhJN0lRSXJJQnRvdjdGb3Y4Rms4Q3NoaUFCSHQ5eGZ5eUdreXlHcklhaS8yeUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDY0tFa1JKRlNRU1JCY1dpd0VXVUl2OWpBR01BSW1MQTNJSVJJdjZjQUJGQVVFQWk0c0JqQUtMQTNJSVRJd0FSQ0tNQkl2L1FRQUtpd055Q0VRampBU01CYkdMQTNJSVJJc0JzZ2l5QnlPeUVDS3lBYmFMQkVFQUJJc0ZzaFdMK3JJUmkvNnlFb3NBc2hRbHNoQWlzZ0cyaS9zV2kvd1dpd095R0lBRXJ4b1U4cklhVExJYXNocUwvYklhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFSndvU1JFa1ZKQkpFRjRzQ2pBRkMvMXVMQVRJUUNJd0NzWXNEU1hJSVJESVFzZ2l5QnlPeUVDS3lBYmFMK2haTXNoaUFCRGxPcnJLeUdySWFnUWF5RUNLeUFiTkMvME1pUXY2emlnTUJJa2txU1RFQWkvMG5NR1ZJZ1JoYnNiSVlnQVE4R204enNocXlHb0VHc2hBaXNnR3p0RDVKVndRQVN3RlhBQVFuQ2hKRVNTSlpnUUlJVEJVU1JGY0dBRWtWU1VFQUI0c0ZKQk5CQUpvaWpBTXlBNHdBaXdOQUFIdUxBSXdCaS85QkFHbUxBVElERTBFQVlZdjlnQXQzWVd4c1pYUmZabVZsYzJWSUpGdEpJUVVPUkl2L0hTRUZsMG1NQWtBQUNJdi9RUUFESTR3Q01nZEpnWUQxSkFpTEFrbE9BaGFMQVV4UUp4Qk1VSXY5aS81UEJVOEVUd1JMQlNLSS9lRklWd2dJaS85UEFna1dURkNNQUltTC94WWlGbENNQUltTEE0QUljbVZtWlhKeVpYSmxTSXdCUXY5Mml3UVhqQU5DLzJFcVJ3STJHZ0ZKRlNRU1JCYzJHZ0pKRlNNU1JDSlROaG9EU1JVa0VrUVhOaG9FU1JVa0VrUVhOaG9GU1JVa0VrUVhOaG9HU1JXQklCSkVOaG9IU1JXQktCSkVOaG9JU1JVa0VrUVhOaG9KU1JVa0VrUVhOaG9LU1JVa0VrUVhOaG9MU1JVa0VrUVhOaG9NU1JXQklCSkVOaG9OU1JVa0VrUVhOaG9PUndJVlN3RWlXVW1CQ2hKRVR3Sk1Td0pTSWxtQkRBZ1NSRElOUUFBRUp5T3dBQ2NHU3c1bkp5UkxEV2RMQzBFQUZFc0xjUUJFUUFBTWdBaEZVbEk2U1VGVFZMQUFLRXNNWnljbFN3dEpUZ0puU3dvTVFRRDdTd2t5QncxQkFQTWpRQUFNZ0FoRlVsSTZTVVZPVXJBQUp4ZExDbWNuRVVzSlo0QUdablZ1WkdWeVN3aG5KeHhMQjJjbkhVc0daeWNUU3dWbkp3VXlBMmNuQjBzRVp5Y1lTd05uS1VzQ1p5Y1VTd0ZuSWlsbFJJQUlibVowWDJabFpYTmxTRW1CY0ZzbkhreG5JaWxsUkNJbkVXVkVzVXlBQTNOaGJHVklnUkJic2hpQUJOVjB1eEN5R3JJYWdRYXlFQ0t5QWJPMFBrbFhCQUJNVndBRUp3b1NSRWtWSkJKRUYwbEZFMHNCZ1dCYlJSRk1nV2hiUlJFakRVRUFPVXNRSXdsTEVFbExFUWxQQWd1QjZBY0tDU2NtVEdlQmVLOG5DRXhuSnpFeEYyY25INEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBV2NqUXlOQy84Y2lRdjhLS2treEZpTUpTVGdRSXhKRU5ob0JTUlVrRWtRWE1RQXlDUkpBQUFRbkk3QUFTU1VQUUFBTWdBaEZVbEk2VFVGTVJyQUFTWUVRREVBQURJQUlSVkpTT2sxQlRVYXdBRWtoREF0RkEwc0JPQWN5Q2hKQUFBUW5EYkFBU3dFNENFc0RFa0FBQkNjTnNBQW5ERXNCWnlKRkJFc0RTd0VNUVFBVlN3TkpGaWNTVEZDQmdJQUN1VWdqQ0VVRVF2L2pJME1xU1RZYUFVa1ZKQkpFRnlJbkRtVkVRQUFFSnlld0FDSW5CV1ZFTWdNVFFBQUVKekt3QUNJclpVUWlKdzlsUkJOQUFBeUFDRVZTVWpwQlVrWkRzQUFpSnc5bFRFbE9Ba1VFUkNJclpVUkxBUWxKU3dOSlRnTU5URTRDVFVsRkE0RmtDeUtJK2pORkEwb0lTd01OUVFBdFN3SkpGaWNaVEZCSnZrUlhBQ0JNdkVnbkNVc0JVTHhJc2JJSElRZXlDQ095RUNLeUFiTWpDRVVEUXYvTElpY1BaVVJMQVFnbkQweG5JME1xSWljT1pVUkFBQVFuSjdBQUlrVUJJaWNNWlVSTEFRMUJBQnNpSnd4bFJDTUpTd0ZKVGdJSkZpY1NURkM4U0NNSVJRRkMvOW9pSnd4bFJDRU1DN0V5Q1VzQnNnaXlCeU95RUNLeUFiTW5EQ0puRmljS1RGQ3dJME14QURJSkVrQUFCQ2Nqc0FBaUp3NWxSRUFBQkNjbnNBQWlLMlZFSWljUFpVUVNRQUFNZ0FoRlVsSTZVa1pPUTdBQUlpY01aVVJCQUF5QUNFVlNVanBUU0ZkQ3NBQWpRekVXZ1FJSlNUZ1FnUVlTUkRFV0l3bEpUZ0k0RUNNU1JEWWFBVWxPQWhXQklCSkVJaWxsUkRFQUlpY0haVVNJK1lGQUFBUW5JTEFBU29nTHh5TkRNUllqQ1VrNEVDTVNSRFlhQVVrVmdTQVNSSWdMcnlORE1SYUJBd2xKT0JDQkJoSkVNUmFCQWdsSlRnSTRFQ01TUkRFV0l3bEpUZ0k0RUNVU1JEWWFBVWxPQWhXQklCSkVJaWxsUkRFQUlpY0haVVNJK1I1QUFBUW5JTEFBU3dKTEFrc0NpQXcxSTBNeEZvRUNDVWs0RUNNU1JERVdJd2xKT0JBbEVrUTJHZ0ZKRllFZ0VrU0lEQklqUXpFV2dRSUpTVGdRZ1FZU1JERVdJd2xKVGdJNEVDTVNSQ0lwWlVReEFDSW5CMlZFaVBqRFFBQUVKeUN3QUVtSUROb2pRekVXSXdsSk9CQWpFa1NJRE1zalF6RVdnUUlKU1RnUWdRWVNSREVXSXdsSlRnSTRFQ1VTUkNJcFpVUXhBQ0luQjJWRWlQaUJRQUFFSnlDd0FFbUlEVmdqUXpFV0l3bEpPQkFsRWtTSURVa2pReUpIQXlwSENUSUhJaWNYWlVRTlFBQUVKek93QUNJbkMyVkVRUUFNZ0FoRlVsSTZWMEZFVXJBQUlpY2JaVVJBQUFneUJpUUpKeHRNWnlJbkcyVkVJaWNXWlVRbEN3aEpSUWN5Qmt3a0NBOUFBQXlBQ0VWU1VqcE9SVlJOc0FDeFN3VVdJaWN4WlVSSkZSWlhCZ0pNVUNJcFpVUW5NR1ZJSWx1eUdJQUVHSk9TeGJJYVRMSWFzaHFCQnJJUUlySUJzN1ErU1ZjRUFFc0JWd0FFSndvU1JFa2lXWUVDQ0V3VkVrUlhCZ0JKUlEwVlNVVURRQUFOSWljV1pVUWpDQ2NXVEdjalF5SkxBa2xPQWc4aVN3SlBBazJCRUVzQ0Q0RVFUd05QQWsxTERVNENVa2xGRFJXQkVCSkFBQXlBQ0VWU1VqcEpVbE5Fc0FCTEMwa2lXeUloQ0IxRkFVa2hDUjVGQVU4Q0hrVUJJUWdkUlFFaENSNU9Ba2hQQWlSYlRDRUtIa1VCSGtVQklRZ2RSUUVoQ2g1RkFVd1dUQlpRUlEwaUp3UmxURWxPQWtVRFJDRUdERUVBQlVrakNFVUJKelJGRGtsQkFObEpJdzFBQUFRbk5iQUFTU01KU1VVTEl3MUFBQVFuTmJBQVN3bEpIQ01lUlFGTUdFVURJa1VIU3d4RkMwc0dJd3hCQUlwTENra2lXMGxGQmlFSUhVVUJJUWtlU1U0Q1JReElUQ1JiUlFaQUFHZUJvb1c4OXQ3ZnZZVW9Td1ZKSVFnZFJRRlBBaDVGQVVzS0Zrd1dVRXNGaVBaMGdTQ1FUd0tJOW13WkZsQkpWd0FRVElFUVcwbEZDa3NFRDBFQUpFc0lTd3NZSXdnV1N3OUpJbGtqQ0JaWEJnQmNBRXhRUlE5TEJ5TUlSUWhGQzBML2VVVUxRdjk3SVFwQy81NUxDb0FDQUJKUVN3NVFTWUVRV1VzQkZWS0JBbHNuQzB4blF2NlVJUVpGQ2tML09TSXFSd1kyR2dGSkZTUVNSQmN5QnlJbkYyVkVEVUFBQkNjenNBQWlKd3RsUkVBQURJQUlSVkpTT2s1WFZGbXdBQ0luQldWRU1nTVNRQUFNZ0FoRlVsSTZWMEZHUkxBQUlpY2ZaVVJKSWx0RkF5UmJSUVlpUlFRaUp3eGxSRXNFRFVFQTdpSW5DR1ZFU3dRa0Mxc2lKd3RsUkVzSFR3SUlTVVVIREVFQXYwc0JGa3NHRmxCSklsdEpUZ0pGQkNSYlJRY2lLMlZFU3dFSlNVc0RTVTRERFV4T0FrMUpSUU5NSVFRWVNVVUtJUVJNQ1VsRkJRMUJBQVJMQWtVQlN3RWhCQW9XSnhKTVVFVUpTWUVvQ3lLSTlQd2lSUVJMQTBzQkRFRUFTVXNIU3dRSUpBdExDVXdrdWhkTEJrbFBBZ2hGQ0NJbkMyVkVEa0VBSGlJbkMyVkVTd2NNUVFBVFN3RkxCQWdXSnhsTVVMNUVWd0FnSndWTVowc0RJd2hGQkVzR1JRWkMvNjhpSng5bFJFa2lXMHNDQ0JaY0FFc0dGbHdJSng5TVp5TkRTd0VoQkFoRkFrc0RJd2hGQkVzRVJRWkMvd2RMQVJaTEJoWlFRdjhxSWtjRktrY09JaWNGWlVReUF4TkFBQVFuTXJBQUlpY09aVVJCQUF5QUNFVlNVanBRUVVOTXNBQWlKeVJsUkVFRTJiRWlKd1ZsUkNJbkJtVkVzaGlBQkszNUt1U3lHcklhZ1FheUVDS3lBYk1pSndSbFRFVU9SQ0luSkdWRUlrVUxRQUF1SWljY1pVUkJBQ1lpSnh4bFJFa2hCUTVFU3cwZElRV1hTVVVMUUFBUUlpY2NaVVJCQUFoTERFRUFBeU5GQ2lKRkR5SW5KbVZFUVFBZUlpY21aVVJKSVFVT1JFc05IU0VGbDBsRkVFQUFDRXNNUVFBREkwVVBJa1VISWljZVpVUkJBQ1lpSng1bFJFa2hCUTVFU3cwZElRV1hTVVVJUUFBUUlpY2VaVVJCQUFoTERFRUFBeU5GQjBzSlNVc1FTVTREQ0lFQ1N3cEpUZ1VMQ0VzUVRBbE1GazhDRmxCUEFoWlFUQlpRUlJJaUp3VmxSQ2NKVEZDK1JCY1dKeGxNVUw1RVZ5QWdSUkFpS0dWRVFBQ1BTeEVpVzBsRkJVRUFGckVpSndabFJIRUxSRXNFc2dpeUJ5T3lFQ0t5QWJOTEVTUmJTVUVBRENJcFpVUWlUd0tJOVNRaVc3RWlKeFJsUklFQ1czSUlSTElIc2dnanNoQWlzZ0d6c1NJbkdHVkVTeEpKVGdLQkVGdEpzZ2hNc2djanNoQWlzZ0d6c2JJSVN4Q3lCeU95RUNLeUFiT3hJaWNSWlVSTWdSaGJzZ2l5QnlPeUVDS3lBYk1uRGlObkkwTkxFU0piU1VVRVFRQXZJaWNHWlVSeEMwUWlLR1ZFY0FCRkFVRURBTEVpSndabFJIRUxSQ0lvWlVTeUVVc0RzaEt5RkNXeUVDS3lBYk5MRVNSYlNVVUpRUUFSSWlsbFJDSW9aVVJMQ1lqMGR5SmJSUWdpSnhSbFJJRUNXM0lJUkNJb1pVUndBRVVCUVFFc3NTSW5GR1ZFZ1FKYmNnaEVJaWhsUkxJUlN3aXlFcklVSmJJUUlySUJzeUluR0dWRUlpaGxSSEFBUlFGQkFNMnhJaWNZWlVSTEVvRVFXeUlvWlVTeUViSVNzaFFsc2hBaXNnR3pJaWhsUkVzUVRIQUFSUUZCQUhpeFN4R0JFRnNpS0dWRXNoR3lFa3NQc2hRbHNoQWlzZ0d6SWljUlpVUWlLR1ZFY0FCRkFVRUFIN0VpSnhGbFJFc1NnUmhiSWlobFJMSVJzaEt5RkNXeUVDS3lBYk5DL3U4aUtXVkVJaWhsUkNJbkVXVkVTeFNCR0Z0SkZrOENURkFuRUV4UVR3TlBBeUloQms4RVR3VWlpUEl4UmdKQy9yOGlLV1ZFSWlobFJFc1RnUkJiU1JaTEUweFFKeEJNVUU4RFR3TWlJUVpQQkU4RklvanlCa1lDUXY5MklpbGxSQ0lvWlVRaUp4aGxSRXNVZ1JCYlNSWlBBa3hRSnhCTVVFOERUd01pSVFaUEJFOEZJb2p4MWtZQ1F2OGZJaWhsVEVVTlJDSXBaVVJKSnhwbFNFVUNTU2MyWlVoSlZ3Z0lSUllrVzBVR0lpY1VaVXhKVGdKRkZFUkpJbGxMQVJWU1NVVVZWd0lBVENjYVpVaE1zU01XUlJkSkZSWlhCZ0pNVUlBRUFBRUFBa3hRVExJWWdBUTZzb2xic2hxeUdvRUdzaEFpc2dHenRENUpWd1FBU3dGWEFBUW5DaEpFU1NKWmdTa0xnUUlJVEJVU1JGY0dLU0piU1VVS1FBQU1nQWhGVWxJNlRrVlRRN0FBU3hDQkFsdEpSUU5MQ1JKQUFBeUFDRVZTVWpwWFJWTkRzQUN4U2JJWWdBUmEzek9Qc2hwTEU3SWFTeFN5R2tzU3NocUFDZ0FCQUFBQUFBQUFBQUN5R2ljMHNocUJCcklRSXJJQklpbGxURVVQUkVzQmNnaEVJa1VNU3d4d0FFVUJRQUFhU3cyQURuSmxkbVZ1ZFdWZmMzQnNhWFJ6WlVnaVdTTUlSUXN5RUVzTEM3WkxBbklJUkxJSHNnZ2pzaEFpc2dHMlJ3SVdTdzBXSnhCTVVFc0hzaGlBQkdnMTQ3eXlHa3l5R29BQmdMSWFzaHFCQnJJUUlySUJ0cklZZ0FSc3cvWUdzaHFCQnJJUUlySUJTd2RCQUJhMlN3RnlDRVJMRExJUlN3aXlFcklVSmJJUUlySUJzMEw5YkNJcFpVUWlLR1ZFSWljR1pVUnhDMFJMQlVsT0FoWlFKeEJNVUU4RFR3TWlJUVpQQkU4RklvandJRVlDUXZ6dE1nb2lKd1psUkV4TEFYQUFTRVVISWljRlpVUk1jQUJGQVVFQUdiRWlKd1ZsUkNJbkJtVkVzaEd5RlNXeUVDS3lBYk5DK3hFaUtXVkVJaWNHWlVRaUp3VmxSRXNJU1U0Q0ZsQW5FRXhRVHdOUEF5SWhCazhFVHdVamlPKytSZ0pDK3VTSUJSbUFBUUFpVHdKVUp3cE1VTEFqUXlJb1pVUWlKeVZsUkNJbkYyVkVJaWNSWlVRaUp4MWxSQ0luRTJWRUlpdGxSQ0luQkdWRUlpY0xaVVFpSndWbFJDSW5CbVZFSWljT1pVUWlKd2RsUkNJbkZtVkVJaWNwWlVRaUp3OWxSRThQRms4UEZsQlBEaFpRVHcxUVR3d1dVRThMRmxCUENoWlFUd2tXVUU4SUZsQlBCMUJQQmhaUWdBRUFJazhIVkZCUEJCWlFUd01XVUU4Q0ZsQk1GbEFuQ2t4UXNDTkROaG9CUndJVlN3RWlXVW1CQ2hKRVR3Sk1Td0pTSWxtQkRBZ1NSREVBSWlsbFJDY2FaVWh5Q0VRU1FBQUVKeWl3QUNjVVN3Rm5JME0yR2dGSklsbUJBZ2hMQVJVU1JGY0NBREVBSWlsbFJDY2FaVWh5Q0VRU1FBQUVKeWl3QUNJcFpVUW5ObVZJZ1JCYk1nMFNRQUFNZ0FoRlVsSTZTVlZRUjdBQWdBZDJaWEp6YVc5dVN3Rm5JME0yR2dGSkZTUVNSQmN4QUNJcFpVUW5HbVZJY2doRUVrQUFCQ2Nvc0FBcFN3Rm5JME14RmlNSlNUZ1FJeEpFTmhvQlNSVWtFa1FYTVFBeUNSSkFBQXlBQ0VWU1VqcEdUMUpDc0FCTEFUZ0hNZ29TUUFBTWdBaEZVbEk2U1ZCTlVyQUFTd0U0Q0RJUUVrQUFESUFJUlZKU09rbFFUVUd3QUxFeUNrc0JzaEVpc2hLeUZDV3lFQ0t5QWJNalE0b0NBQ3FJQTFwQUFBUW5JYkFBSWlobFJFRUFCQ2Mzc0FBaUp3ZGxSRUVBRFNMQUdpY3FFa0FBQkNjaXNBQW5DVEVBVUwxRkFVRUFCQ2M0c0FDTC9qZ0hNZ29TUUFBRUp3MndBSXYrT0FoSmpBQWlKeDFsUkNFSENBOUJBSFFpSnhObFJDRUhDSXNBRDBFQVppTkFBQVFuRGJBQUlpdGxSREVBaS85UVN3RVdKeGxMQVZCUEFyOG5DVEVBVUV5L2l3QWhCd2xKRmtzQ0lRUUtTUlluRWt4UVR3UWhCQmdrQzA4RHV5SW5DR1ZFVENRTFNsdExBd2dXWFNjSVRHY2lLMlZFSXdnclRHY2lKd1JsUkFnbkJFeG5pU0pDLzVlS0F3QXFpQUtFUUFBRUp5R3dBQ0lvWlVSQUFBUW5PYkFBSWljSFpVUkJBQTBpd0Jvbkt4SkFBQVFuSXJBQUp3a3hBRkM5UlFGQkFBUW5PTEFBaS8wNEJ6SUtFa0FBQkNjTnNBQ0wvVGdJSVFjU1FBQUVKdzJ3QUl2K09CUXlDaEpBQUFRbkZiQUFpLzQ0RVNJb1pVUVNRQUFFSnhXd0FJditPQkpKakFBaUp4MWxSQTlCQUhBaUp4TmxSSXNBRDBFQVpTTkFBQVFuRmJBQUlpdGxSREVBaS85UVN3RVdKeGxMQVZCUEFyOG5DVEVBVUV5L2l3QkpUZ0lXU3dFaEJBcEpGaWNTVEZCUEF5RUVHQ1FMVHdPN0lpY0laVVJNSkF0S1cwc0RDQlpkSndoTVp5SXJaVVFqQ0N0TVp5SW5CR1ZFQ0NjRVRHZUpJa0wvbUlvQkFDSkpLa2NDaUFHRlFBQUVKeUd3QUNJb1pVUkJBQVFuTjdBQUlpY0haVVJCQUEwaXdCb25MQkpBQUFRbklyQUFKd2t4QUZDOVJRRkFBQVFuT3JBQUp3a3hBRkMrUkJkSklRUUtTWXdERmljU1RGQkpqQUZNSVFRWUpBdEpqQUlrdW93QWkvODRCeklLRWtBQUJDY05zQUNML3pnSVNZd0VJaWNUWlVTTEFCY0pEa0FBQkNjTnNBQ0xBVW1MQWtsT0F5UzZGNHNFU1U0RUNCWk1UZ0s3SWljSVpVU0xBeVFMU2x0TEF3Z1dYU2NJVEdjaUp3UmxSQWduQkV4bmlZb0JBQ0pKS2tjQ2lBREZRQUFFSnlHd0FDSW9aVVJBQUFRbk9iQUFJaWNIWlVSQkFBMGl3Qm9uTFJKQUFBUW5JckFBSndreEFGQzlSUUZBQUFRbk9yQUFKd2t4QUZDK1JCZEpJUVFLU1l3REZpY1NURkJKakFGTUlRUVlKQXRKakFJa3Vvd0FpLzg0RkRJS0VrQUFCQ2NWc0FDTC96Z1JJaWhsUkJKQUFBUW5GYkFBaS84NEVrbU1CQ0luRTJWRWl3QVhDUTVBQUFRbkZiQUFpd0ZKaXdKSlRnTWt1aGVMQkVsT0JBZ1dURTRDdXlJbkNHVkVpd01rQzBwYlN3TUlGbDBuQ0V4bklpY0VaVVFJSndSTVo0a3lCeUluSldWRUQwRUFEVElISWljWFpVUU9RUUFDSTRraWlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6bnVsbCwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
