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

namespace Arc56.Generated.TxnLab.nfd_sdk.NFDRegistry_7fe53358
{


    public class NFDRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFDRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PriceInfo : AVMObjectType
            {
                public ulong OneYearPrice { get; set; }

                public ulong CarryCost { get; set; }

                public bool Exists { get; set; }

                public bool IsExpired { get; set; }

                public bool InAuction { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOneYearPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOneYearPrice.From(OneYearPrice);
                    ret.AddRange(vOneYearPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCarryCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCarryCost.From(CarryCost);
                    ret.AddRange(vCarryCost.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsExpired.From(IsExpired);
                    ret.AddRange(vIsExpired.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInAuction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vInAuction.From(InAuction);
                    ret.AddRange(vInAuction.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PriceInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PriceInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOneYearPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOneYearPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOneYearPrice = vOneYearPrice.ToValue();
                    if (valueOneYearPrice is ulong vOneYearPriceValue) { ret.OneYearPrice = vOneYearPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCarryCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCarryCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCarryCost = vCarryCost.ToValue();
                    if (valueCarryCost is ulong vCarryCostValue) { ret.CarryCost = vCarryCostValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsExpired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsExpired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsExpired = vIsExpired.ToValue();
                    if (valueIsExpired is bool vIsExpiredValue) { ret.IsExpired = vIsExpiredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInAuction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vInAuction.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInAuction = vInAuction.ToValue();
                    if (valueInAuction is bool vInAuctionValue) { ret.InAuction = vInAuctionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PriceInfo);
                }
                public bool Equals(PriceInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PriceInfo left, PriceInfo right)
                {
                    return EqualityComparer<PriceInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PriceInfo left, PriceInfo right)
                {
                    return !(left == right);
                }

            }

            public class Constraints : AVMObjectType
            {
                public ulong SegmentPlatformCostInUsd { get; set; }

                public ulong SegmentPlatformCostInAlgo { get; set; }

                public ulong MaxYearsAllowed { get; set; }

                public Algorand.Address TreasuryAddress { get; set; }

                public ulong ExpiredAuctionDuration { get; set; }

                public ulong ExpiredStartingPrice { get; set; }

                public ulong MaxMintCarryCost { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentPlatformCostInUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSegmentPlatformCostInUsd.From(SegmentPlatformCostInUsd);
                    ret.AddRange(vSegmentPlatformCostInUsd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentPlatformCostInAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSegmentPlatformCostInAlgo.From(SegmentPlatformCostInAlgo);
                    ret.AddRange(vSegmentPlatformCostInAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxYearsAllowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxYearsAllowed.From(MaxYearsAllowed);
                    ret.AddRange(vMaxYearsAllowed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasuryAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTreasuryAddress.From(TreasuryAddress);
                    ret.AddRange(vTreasuryAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiredAuctionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiredAuctionDuration.From(ExpiredAuctionDuration);
                    ret.AddRange(vExpiredAuctionDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiredStartingPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiredStartingPrice.From(ExpiredStartingPrice);
                    ret.AddRange(vExpiredStartingPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxMintCarryCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxMintCarryCost.From(MaxMintCarryCost);
                    ret.AddRange(vMaxMintCarryCost.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Constraints Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Constraints();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentPlatformCostInUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSegmentPlatformCostInUsd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSegmentPlatformCostInUsd = vSegmentPlatformCostInUsd.ToValue();
                    if (valueSegmentPlatformCostInUsd is ulong vSegmentPlatformCostInUsdValue) { ret.SegmentPlatformCostInUsd = vSegmentPlatformCostInUsdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentPlatformCostInAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSegmentPlatformCostInAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSegmentPlatformCostInAlgo = vSegmentPlatformCostInAlgo.ToValue();
                    if (valueSegmentPlatformCostInAlgo is ulong vSegmentPlatformCostInAlgoValue) { ret.SegmentPlatformCostInAlgo = vSegmentPlatformCostInAlgoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxYearsAllowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxYearsAllowed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxYearsAllowed = vMaxYearsAllowed.ToValue();
                    if (valueMaxYearsAllowed is ulong vMaxYearsAllowedValue) { ret.MaxYearsAllowed = vMaxYearsAllowedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasuryAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTreasuryAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTreasuryAddress = vTreasuryAddress.ToValue();
                    if (valueTreasuryAddress is Algorand.Address vTreasuryAddressValue) { ret.TreasuryAddress = vTreasuryAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiredAuctionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiredAuctionDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiredAuctionDuration = vExpiredAuctionDuration.ToValue();
                    if (valueExpiredAuctionDuration is ulong vExpiredAuctionDurationValue) { ret.ExpiredAuctionDuration = vExpiredAuctionDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiredStartingPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiredStartingPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiredStartingPrice = vExpiredStartingPrice.ToValue();
                    if (valueExpiredStartingPrice is ulong vExpiredStartingPriceValue) { ret.ExpiredStartingPrice = vExpiredStartingPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxMintCarryCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxMintCarryCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxMintCarryCost = vMaxMintCarryCost.ToValue();
                    if (valueMaxMintCarryCost is ulong vMaxMintCarryCostValue) { ret.MaxMintCarryCost = vMaxMintCarryCostValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Constraints);
                }
                public bool Equals(Constraints? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Constraints left, Constraints right)
                {
                    return EqualityComparer<Constraints>.Default.Equals(left, right);
                }
                public static bool operator !=(Constraints left, Constraints right)
                {
                    return !(left == right);
                }

            }

            public class LinkOnMintExtraMbrCosts : AVMObjectType
            {
                public ulong LinkingNfdMbrCost { get; set; }

                public ulong LinkingRegistryMbrCost { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLinkingNfdMbrCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLinkingNfdMbrCost.From(LinkingNfdMbrCost);
                    ret.AddRange(vLinkingNfdMbrCost.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLinkingRegistryMbrCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLinkingRegistryMbrCost.From(LinkingRegistryMbrCost);
                    ret.AddRange(vLinkingRegistryMbrCost.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LinkOnMintExtraMbrCosts Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LinkOnMintExtraMbrCosts();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLinkingNfdMbrCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLinkingNfdMbrCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLinkingNfdMbrCost = vLinkingNfdMbrCost.ToValue();
                    if (valueLinkingNfdMbrCost is ulong vLinkingNfdMbrCostValue) { ret.LinkingNfdMbrCost = vLinkingNfdMbrCostValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLinkingRegistryMbrCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLinkingRegistryMbrCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLinkingRegistryMbrCost = vLinkingRegistryMbrCost.ToValue();
                    if (valueLinkingRegistryMbrCost is ulong vLinkingRegistryMbrCostValue) { ret.LinkingRegistryMbrCost = vLinkingRegistryMbrCostValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LinkOnMintExtraMbrCosts);
                }
                public bool Equals(LinkOnMintExtraMbrCosts? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LinkOnMintExtraMbrCosts left, LinkOnMintExtraMbrCosts right)
                {
                    return EqualityComparer<LinkOnMintExtraMbrCosts>.Default.Equals(left, right);
                }
                public static bool operator !=(LinkOnMintExtraMbrCosts left, LinkOnMintExtraMbrCosts right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class NfdRegistryMintedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 53, 197, 148, 24 };
                public const string Signature = "nfdRegistry_minted(uint64,string,uint64,uint64,uint64,address,address,address,uint64,uint64,address,uint64,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public ulong PriceOneYear { get; set; }
                public ulong PaidAmount { get; set; }
                public ulong CarryCost { get; set; }
                public Algorand.Address Seller { get; set; }
                public Algorand.Address Buyer { get; set; }
                public Algorand.Address Owner { get; set; }
                public ulong ExpTime { get; set; }
                public ulong AmountToSeller { get; set; }
                public Algorand.Address CommissionAddress { get; set; }
                public ulong AmountToCommission { get; set; }
                public Algorand.Address SegmentRootOwner { get; set; }
                public ulong AmountToSegmentRoot { get; set; }

                public static NfdRegistryMintedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdRegistryMintedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppId = vAppId.ToValue();
                    if (valueAppId is ulong vAppIdValue) { ret.AppId = vAppIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(eventData.Skip(indexName).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceOneYear = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceOneYear.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceOneYear = vPriceOneYear.ToValue();
                    if (valuePriceOneYear is ulong vPriceOneYearValue) { ret.PriceOneYear = vPriceOneYearValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaidAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPaidAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaidAmount = vPaidAmount.ToValue();
                    if (valuePaidAmount is ulong vPaidAmountValue) { ret.PaidAmount = vPaidAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCarryCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCarryCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCarryCost = vCarryCost.ToValue();
                    if (valueCarryCost is ulong vCarryCostValue) { ret.CarryCost = vCarryCostValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpTime = vExpTime.ToValue();
                    if (valueExpTime is ulong vExpTimeValue) { ret.ExpTime = vExpTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountToSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountToSeller = vAmountToSeller.ToValue();
                    if (valueAmountToSeller is ulong vAmountToSellerValue) { ret.AmountToSeller = vAmountToSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommissionAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCommissionAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommissionAddress = vCommissionAddress.ToValue();
                    if (valueCommissionAddress is Algorand.Address vCommissionAddressValue) { ret.CommissionAddress = vCommissionAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToCommission = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountToCommission.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountToCommission = vAmountToCommission.ToValue();
                    if (valueAmountToCommission is ulong vAmountToCommissionValue) { ret.AmountToCommission = vAmountToCommissionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentRootOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSegmentRootOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSegmentRootOwner = vSegmentRootOwner.ToValue();
                    if (valueSegmentRootOwner is Algorand.Address vSegmentRootOwnerValue) { ret.SegmentRootOwner = vSegmentRootOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToSegmentRoot = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountToSegmentRoot.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountToSegmentRoot = vAmountToSegmentRoot.ToValue();
                    if (valueAmountToSegmentRoot is ulong vAmountToSegmentRootValue) { ret.AmountToSegmentRoot = vAmountToSegmentRootValue; }
                    return ret;

                }

            }

            public class NfdRegistryAddressPrimaryNfdChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 81, 114, 207, 1 };
                public const string Signature = "nfdRegistry_addressPrimaryNfdChanged(uint64,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Address { get; set; }

                public static NfdRegistryAddressPrimaryNfdChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdRegistryAddressPrimaryNfdChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppId = vAppId.ToValue();
                    if (valueAppId is ulong vAppIdValue) { ret.AppId = vAppIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(eventData.Skip(indexName).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Gas(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Gas_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the price for a given NFD (single year), the max # of years allowed (Name for Display),
        ///and extra algo required to cover MBR when purchasing.
        ///</summary>
        /// <param name="nfdName">The NFD name for which to retrieve the price. </param>
        /// <param name="caller">the address this request is on behalf of (since an nfd contract might call us it
        ///needs to be able to pass on the request on behalf of ITS caller - ie: getting price for an expired nfd will be
        ///different if its owner ir asking.
        /// PriceInfo Type containing the price, carry cost, etc. </param>
        public async Task<Structs.PriceInfo> GetPrice(string nfdName, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 194, 48, 60 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PriceInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPrice_Transactions(string nfdName, Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 194, 48, 60 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Constraints> GetConstraints(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 59, 140, 231 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Constraints.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConstraints_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 59, 140, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the MBR amounts needed to MINT an nfd.
        ///This value needs to be added to purchase price in mintNfd call.
        ///getPrice() returns it though.
        ///</summary>
        /// <param name="nfdName"> </param>
        public async Task<ulong> GetNfdMbrCost(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 224, 46, 119 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNfdMbrCost_Transactions(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 224, 46, 119 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task<Structs.LinkOnMintExtraMbrCosts> GetNfdLinkOnMintExtraMbrCost(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 20, 182, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LinkOnMintExtraMbrCosts.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetNfdLinkOnMintExtraMbrCost_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 20, 182, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mint an NFD (NFT) and create a new NFD instance.
        ///</summary>
        /// <param name="purchaseTxn">The payment transaction covering the purchase amount of the nfd </param>
        /// <param name="nfdName">The name of the NFD to mint </param>
        /// <param name="reservedFor">The address that will own the NFD once minted (so you can buy for someone else) </param>
        /// <param name="linkOnMint">whether to auto-link the address (reserved for MUST MATCH payer!) at mint
        /// uint64 - The ID of the newly created NFD instance. </param>
        public async Task<ulong> MintNfd(PaymentTransaction purchaseTxn, string nfdName, Algorand.Address reservedFor, bool linkOnMint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { purchaseTxn });
            byte[] abiHandle = { 62, 142, 75, 118 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reservedForAbi.From(reservedFor);
            var linkOnMintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); linkOnMintAbi.From(linkOnMint);

            var result = await base.CallApp(new List<object> { abiHandle, purchaseTxn, nfdNameAbi, reservedForAbi, linkOnMintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MintNfd_Transactions(PaymentTransaction purchaseTxn, string nfdName, Algorand.Address reservedFor, bool linkOnMint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { purchaseTxn });
            byte[] abiHandle = { 62, 142, 75, 118 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reservedForAbi.From(reservedFor);
            var linkOnMintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); linkOnMintAbi.From(linkOnMint);

            return await base.MakeTransactionList(new List<object> { abiHandle, purchaseTxn, nfdNameAbi, reservedForAbi, linkOnMintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        /// <param name="addrToVerify"> </param>
        public async Task LinkNfdAddress(string nfdName, ulong nfdAppId, Algorand.Address addrToVerify, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 15, 164, 113 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrToVerifyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrToVerifyAbi.From(addrToVerify);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrToVerifyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LinkNfdAddress_Transactions(string nfdName, ulong nfdAppId, Algorand.Address addrToVerify, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 15, 164, 113 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrToVerifyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrToVerifyAbi.From(addrToVerify);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrToVerifyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        /// <param name="addrToUnlink"> </param>
        public async Task UnlinkNfdAddress(string nfdName, ulong nfdAppId, Algorand.Address addrToUnlink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 216, 245, 204 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrToUnlinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrToUnlinkAbi.From(addrToUnlink);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrToUnlinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnlinkNfdAddress_Transactions(string nfdName, ulong nfdAppId, Algorand.Address addrToUnlink, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 216, 245, 204 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrToUnlinkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrToUnlinkAbi.From(addrToUnlink);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrToUnlinkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        public async Task OwnershipAssign(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 89, 143, 2 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OwnershipAssign_Transactions(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 89, 143, 2 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///This method is triggered when the ownership of an NFD (Non-Fungible Domain) changes.
        ///It is called by the NFD via the purchase method.  It can also be called by TxnLab admin for older 3.3
        ///NFDs when it detects purchased events for 3.3
        ///</summary>
        /// <param name="nfdName">The name of the NFD. </param>
        /// <param name="nfdAppId">The unique application ID of the NFD. </param>
        /// <param name="seller">The address of the prior owner (seller) of the nfd </param>
        /// <param name="buyer">The address of the new owner of the NFD. </param>
        public async Task OwnershipChanged(string nfdName, ulong nfdAppId, Algorand.Address seller, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 44, 87, 242 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, sellerAbi, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OwnershipChanged_Transactions(string nfdName, ulong nfdAppId, Algorand.Address seller, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 44, 87, 242 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, sellerAbi, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Makes the specified NFD the 'first' NFD in the reverse-address set so its the primary NFD for this address.
        ///The NFD must be valid, and the sender must be the address (or nfd owner if vault).  The NFD wouldn't already be
        ///in the reverse-lookup set if it wasn't already valid.
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        /// <param name="addrBeingModified"> </param>
        public async Task SetAddressPrimaryNfd(string nfdName, ulong nfdAppId, Algorand.Address addrBeingModified, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 113, 21, 91 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrBeingModifiedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrBeingModifiedAbi.From(addrBeingModified);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrBeingModifiedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAddressPrimaryNfd_Transactions(string nfdName, ulong nfdAppId, Algorand.Address addrBeingModified, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 113, 21, 91 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);
            var addrBeingModifiedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrBeingModifiedAbi.From(addrBeingModified);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi, addrBeingModifiedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        public async Task<string> UpgradeNfd(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 237, 106, 94 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpgradeNfd_Transactions(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 237, 106, 94 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="nfdAppId"> </param>
        public async Task<bool> IsValidNfdAppId(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 226, 47, 198 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsValidNfdAppId_Transactions(string nfdName, ulong nfdAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 226, 47, 198 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var nfdAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nfdAppIdAbi.From(nfdAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, nfdAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        public async Task<ulong> GetNameAppId(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 131, 21, 67 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNameAppId_Transactions(string nfdName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 131, 21, 67 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lookupAddress"> </param>
        public async Task<ulong[]> GetAddressAppIds(Algorand.Address lookupAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 235, 149, 85 };
            var lookupAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lookupAddressAbi.From(lookupAddress);

            var result = await base.CallApp(new List<object> { abiHandle, lookupAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetAddressAppIds_Transactions(Algorand.Address lookupAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 235, 149, 85 };
            var lookupAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lookupAddressAbi.From(lookupAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, lookupAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Initializes the NFD contract bytecode into the registry
        ///</summary>
        /// <param name="version">The version of the contract. </param>
        /// <param name="size">exact byte size of contract to load </param>
        /// <param name="clearCode">bytes of clear code </param>
        public async Task NfdContractInit(string version, ulong size, byte[] clearCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 77, 200, 176 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var clearCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); clearCodeAbi.From(clearCode);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, sizeAbi, clearCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NfdContractInit_Transactions(string version, ulong size, byte[] clearCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 77, 200, 176 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var clearCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); clearCodeAbi.From(clearCode);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, sizeAbi, clearCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Loads contract data into the  box at the specified offset.
        ///</summary>
        /// <param name="version">The version of the contract. </param>
        /// <param name="offset">The offset at which to replace the contract data within the box. </param>
        /// <param name="data">The contract data to be loaded. </param>
        public async Task NfdContractLoad(string version, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 137, 168, 204 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NfdContractLoad_Transactions(string version, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 137, 168, 204 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Commit a new version of the contract.
        ///</summary>
        /// <param name="version">The version number of the contract to be committed. </param>
        public async Task NfdContractCommit(string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 48, 180, 133 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NfdContractCommit_Transactions(string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 48, 180, 133 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="usdCost"> </param>
        public async Task<ulong> UsdInMicroAlgo(ulong usdCost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 104, 8, 1 };
            var usdCostAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdCostAbi.From(usdCost);

            var result = await base.CallApp(new List<object> { abiHandle, usdCostAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UsdInMicroAlgo_Transactions(ulong usdCost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 104, 8, 1 };
            var usdCostAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdCostAbi.From(usdCost);

            return await base.MakeTransactionList(new List<object> { abiHandle, usdCostAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the cost to add an NFD to the reverse-lookup data
        ///</summary>
        /// <param name="lookupAddress">The address to add the NFD app id to </param>
        public async Task<ulong> CostToAddToAddress(Algorand.Address lookupAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 99, 255, 246 };
            var lookupAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lookupAddressAbi.From(lookupAddress);

            var result = await base.CallApp(new List<object> { abiHandle, lookupAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CostToAddToAddress_Transactions(Algorand.Address lookupAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 99, 255, 246 };
            var lookupAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lookupAddressAbi.From(lookupAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, lookupAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculates the future price based on the current price and the number of years.
        ///</summary>
        /// <param name="curPrice">The current price in USD (in decimals). For example, if the current price is $2.00, the value should be 200. </param>
        /// <param name="forTime">The timestamp to calc the future price based on - ie: 1 year past 'go live date' the price would have inflated by 1 year.
        ///
        ///
        /// uint64 The future price calculated based on the current price and the specified number of years. </param>
        public async Task<ulong> CalcFuturePrice(ulong curPrice, ulong forTime, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 200, 93, 173 };
            var curPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); curPriceAbi.From(curPrice);
            var forTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); forTimeAbi.From(forTime);

            var result = await base.CallApp(new List<object> { abiHandle, curPriceAbi, forTimeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalcFuturePrice_Transactions(ulong curPrice, ulong forTime, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 200, 93, 173 };
            var curPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); curPriceAbi.From(curPrice);
            var forTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); forTimeAbi.From(forTime);

            return await base.MakeTransactionList(new List<object> { abiHandle, curPriceAbi, forTimeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJORkRSZWdpc3RyeSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJpY2VJbmZvIjpbeyJuYW1lIjoib25lWWVhclByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhcnJ5Q29zdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGlzdHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImlzRXhwaXJlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaW5BdWN0aW9uIiwidHlwZSI6ImJvb2wifV0sIkNvbnN0cmFpbnRzIjpbeyJuYW1lIjoic2VnbWVudFBsYXRmb3JtQ29zdEluVXNkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNlZ21lbnRQbGF0Zm9ybUNvc3RJbkFsZ28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4WWVhcnNBbGxvd2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRyZWFzdXJ5QWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZXhwaXJlZEF1Y3Rpb25EdXJhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleHBpcmVkU3RhcnRpbmdQcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhNaW50Q2FycnlDb3N0IiwidHlwZSI6InVpbnQ2NCJ9XSwiTGlua09uTWludEV4dHJhTWJyQ29zdHMiOlt7Im5hbWUiOiJsaW5raW5nTmZkTWJyQ29zdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsaW5raW5nUmVnaXN0cnlNYnJDb3N0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1cGRhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdhcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0UHJpY2UiLCJkZXNjIjoiUmV0dXJucyB0aGUgcHJpY2UgZm9yIGEgZ2l2ZW4gTkZEIChzaW5nbGUgeWVhciksIHRoZSBtYXggIyBvZiB5ZWFycyBhbGxvd2VkIChOYW1lIGZvciBEaXNwbGF5KSxcbmFuZCBleHRyYSBhbGdvIHJlcXVpcmVkIHRvIGNvdmVyIE1CUiB3aGVuIHB1cmNoYXNpbmcuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5mZE5hbWUiLCJkZXNjIjoiVGhlIE5GRCBuYW1lIGZvciB3aGljaCB0byByZXRyaWV2ZSB0aGUgcHJpY2UuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyIiwiZGVzYyI6InRoZSBhZGRyZXNzIHRoaXMgcmVxdWVzdCBpcyBvbiBiZWhhbGYgb2YgKHNpbmNlIGFuIG5mZCBjb250cmFjdCBtaWdodCBjYWxsIHVzIGl0XG5uZWVkcyB0byBiZSBhYmxlIHRvIHBhc3Mgb24gdGhlIHJlcXVlc3Qgb24gYmVoYWxmIG9mIElUUyBjYWxsZXIgLSBpZTogZ2V0dGluZyBwcmljZSBmb3IgYW4gZXhwaXJlZCBuZmQgd2lsbCBiZVxuZGlmZmVyZW50IGlmIGl0cyBvd25lciBpciBhc2tpbmcuXG4gUHJpY2VJbmZvIFR5cGUgY29udGFpbmluZyB0aGUgcHJpY2UsIGNhcnJ5IGNvc3QsIGV0Yy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiUHJpY2VJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldENvbnN0cmFpbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkNvbnN0cmFpbnRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldE5mZE1ickNvc3QiLCJkZXNjIjoiUmV0dXJucyB0aGUgTUJSIGFtb3VudHMgbmVlZGVkIHRvIE1JTlQgYW4gbmZkLlxuVGhpcyB2YWx1ZSBuZWVkcyB0byBiZSBhZGRlZCB0byBwdXJjaGFzZSBwcmljZSBpbiBtaW50TmZkIGNhbGwuXG5nZXRQcmljZSgpIHJldHVybnMgaXQgdGhvdWdoLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldE5mZExpbmtPbk1pbnRFeHRyYU1ickNvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTGlua09uTWludEV4dHJhTWJyQ29zdHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibWludE5mZCIsImRlc2MiOiJNaW50IGFuIE5GRCAoTkZUKSBhbmQgY3JlYXRlIGEgbmV3IE5GRCBpbnN0YW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVyY2hhc2VUeG4iLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY292ZXJpbmcgdGhlIHB1cmNoYXNlIGFtb3VudCBvZiB0aGUgbmZkIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSBORkQgdG8gbWludCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmVkRm9yIiwiZGVzYyI6IlRoZSBhZGRyZXNzIHRoYXQgd2lsbCBvd24gdGhlIE5GRCBvbmNlIG1pbnRlZCAoc28geW91IGNhbiBidXkgZm9yIHNvbWVvbmUgZWxzZSkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaW5rT25NaW50IiwiZGVzYyI6IndoZXRoZXIgdG8gYXV0by1saW5rIHRoZSBhZGRyZXNzIChyZXNlcnZlZCBmb3IgTVVTVCBNQVRDSCBwYXllciEpIGF0IG1pbnRcbiB1aW50NjQgLSBUaGUgSUQgb2YgdGhlIG5ld2x5IGNyZWF0ZWQgTkZEIGluc3RhbmNlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W3sibmFtZSI6Im5mZFJlZ2lzdHJ5X21pbnRlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VPbmVZZWFyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFpZEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcnJ5Q29zdCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBUaW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50VG9TZWxsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWlzc2lvbkFkZHJlc3MiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRUb0NvbW1pc3Npb24iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VnbWVudFJvb3RPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudFRvU2VnbWVudFJvb3QiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJsaW5rTmZkQWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJUb1ZlcmlmeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidW5saW5rTmZkQWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJUb1VubGluayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoib3duZXJzaGlwQXNzaWduIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5mZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5mZEFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJvd25lcnNoaXBDaGFuZ2VkIiwiZGVzYyI6IlRoaXMgbWV0aG9kIGlzIHRyaWdnZXJlZCB3aGVuIHRoZSBvd25lcnNoaXAgb2YgYW4gTkZEIChOb24tRnVuZ2libGUgRG9tYWluKSBjaGFuZ2VzLlxuSXQgaXMgY2FsbGVkIGJ5IHRoZSBORkQgdmlhIHRoZSBwdXJjaGFzZSBtZXRob2QuICBJdCBjYW4gYWxzbyBiZSBjYWxsZWQgYnkgVHhuTGFiIGFkbWluIGZvciBvbGRlciAzLjNcbk5GRHMgd2hlbiBpdCBkZXRlY3RzIHB1cmNoYXNlZCBldmVudHMgZm9yIDMuMyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSBORkQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOiJUaGUgdW5pcXVlIGFwcGxpY2F0aW9uIElEIG9mIHRoZSBORkQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSBwcmlvciBvd25lciAoc2VsbGVyKSBvZiB0aGUgbmZkIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG5ldyBvd25lciBvZiB0aGUgTkZELiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoic2V0QWRkcmVzc1ByaW1hcnlOZmQiLCJkZXNjIjoiTWFrZXMgdGhlIHNwZWNpZmllZCBORkQgdGhlICdmaXJzdCcgTkZEIGluIHRoZSByZXZlcnNlLWFkZHJlc3Mgc2V0IHNvIGl0cyB0aGUgcHJpbWFyeSBORkQgZm9yIHRoaXMgYWRkcmVzcy5cblRoZSBORkQgbXVzdCBiZSB2YWxpZCwgYW5kIHRoZSBzZW5kZXIgbXVzdCBiZSB0aGUgYWRkcmVzcyAob3IgbmZkIG93bmVyIGlmIHZhdWx0KS4gIFRoZSBORkQgd291bGRuJ3QgYWxyZWFkeSBiZVxuaW4gdGhlIHJldmVyc2UtbG9va3VwIHNldCBpZiBpdCB3YXNuJ3QgYWxyZWFkeSB2YWxpZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmZkTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmZkQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyQmVpbmdNb2RpZmllZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRSZWdpc3RyeV9hZGRyZXNzUHJpbWFyeU5mZENoYW5nZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidXBncmFkZU5mZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImlzVmFsaWROZmRBcHBJZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmRBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0TmFtZUFwcElkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5mZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0QWRkcmVzc0FwcElkcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9va3VwQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Im5mZENvbnRyYWN0SW5pdCIsImRlc2MiOiJJbml0aWFsaXplcyB0aGUgTkZEIGNvbnRyYWN0IGJ5dGVjb2RlIGludG8gdGhlIHJlZ2lzdHJ5IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjoiVGhlIHZlcnNpb24gb2YgdGhlIGNvbnRyYWN0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2l6ZSIsImRlc2MiOiJleGFjdCBieXRlIHNpemUgb2YgY29udHJhY3QgdG8gbG9hZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xlYXJDb2RlIiwiZGVzYyI6ImJ5dGVzIG9mIGNsZWFyIGNvZGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Im5mZENvbnRyYWN0TG9hZCIsImRlc2MiOiJMb2FkcyBjb250cmFjdCBkYXRhIGludG8gdGhlICBib3ggYXQgdGhlIHNwZWNpZmllZCBvZmZzZXQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjoiVGhlIHZlcnNpb24gb2YgdGhlIGNvbnRyYWN0LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6IlRoZSBvZmZzZXQgYXQgd2hpY2ggdG8gcmVwbGFjZSB0aGUgY29udHJhY3QgZGF0YSB3aXRoaW4gdGhlIGJveC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjoiVGhlIGNvbnRyYWN0IGRhdGEgdG8gYmUgbG9hZGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibmZkQ29udHJhY3RDb21taXQiLCJkZXNjIjoiQ29tbWl0IGEgbmV3IHZlcnNpb24gb2YgdGhlIGNvbnRyYWN0LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6IlRoZSB2ZXJzaW9uIG51bWJlciBvZiB0aGUgY29udHJhY3QgdG8gYmUgY29tbWl0dGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidXNkSW5NaWNyb0FsZ28iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkQ29zdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjb3N0VG9BZGRUb0FkZHJlc3MiLCJkZXNjIjoiUmV0dXJucyB0aGUgY29zdCB0byBhZGQgYW4gTkZEIHRvIHRoZSByZXZlcnNlLWxvb2t1cCBkYXRhIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb29rdXBBZGRyZXNzIiwiZGVzYyI6IlRoZSBhZGRyZXNzIHRvIGFkZCB0aGUgTkZEIGFwcCBpZCB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjYWxjRnV0dXJlUHJpY2UiLCJkZXNjIjoiQ2FsY3VsYXRlcyB0aGUgZnV0dXJlIHByaWNlIGJhc2VkIG9uIHRoZSBjdXJyZW50IHByaWNlIGFuZCB0aGUgbnVtYmVyIG9mIHllYXJzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXJQcmljZSIsImRlc2MiOiJUaGUgY3VycmVudCBwcmljZSBpbiBVU0QgKGluIGRlY2ltYWxzKS4gRm9yIGV4YW1wbGUsIGlmIHRoZSBjdXJyZW50IHByaWNlIGlzICQyLjAwLCB0aGUgdmFsdWUgc2hvdWxkIGJlIDIwMC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvclRpbWUiLCJkZXNjIjoiVGhlIHRpbWVzdGFtcCB0byBjYWxjIHRoZSBmdXR1cmUgcHJpY2UgYmFzZWQgb24gLSBpZTogMSB5ZWFyIHBhc3QgJ2dvIGxpdmUgZGF0ZScgdGhlIHByaWNlIHdvdWxkIGhhdmUgaW5mbGF0ZWQgYnkgMSB5ZWFyLlxuXG5cbiB1aW50NjQgVGhlIGZ1dHVyZSBwcmljZSBjYWxjdWxhdGVkIGJhc2VkIG9uIHRoZSBjdXJyZW50IHByaWNlIGFuZCB0aGUgc3BlY2lmaWVkIG51bWJlciBvZiB5ZWFycy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjoxNn19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM1XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjUxIn0seyJwYyI6WzUxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQiLCJ0ZWFsIjo0MTQsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjE3OSJ9LHsicGMiOls2MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG1ldGhvZCIsInRlYWwiOjUxMCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTk4In0seyJwYyI6WzYzOF0sImVycm9yTWVzc2FnZSI6InVua25vd24gbWV0aG9kIiwidGVhbCI6NTE0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyMDAifSx7InBjIjpbNjU4XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAoY2FsbGVyKSBmb3IgZ2V0UHJpY2UgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjo1NDIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjIxNiJ9LHsicGMiOls5MDldLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCAwIChhZGRyZXNzKSBmb3IgZ2V0TmZkTGlua09uTWludEV4dHJhTWJyQ29zdCBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjczNiwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MjU2In0seyJwYyI6Wzk0N10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGxpbmtPbk1pbnQpIGZvciBtaW50TmZkIG11c3QgYmUgYSBib29sIiwidGVhbCI6NzgwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyNzIifSx7InBjIjpbOTU4XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMSAocmVzZXJ2ZWRGb3IpIGZvciBtaW50TmZkIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6NzkyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyNzIifSx7InBjIjpbOTc0XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMyAocHVyY2hhc2VUeG4pIGZvciBtaW50TmZkIG11c3QgYmUgYSBwYXkgdHJhbnNhY3Rpb24iLCJ0ZWFsIjo4MDgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjI3MiJ9LHsicGMiOls5OTZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB2ZXJpZmljYXRpb24gZmFpbGVkOiB7XCJ0eG5cIjpcInB1cmNoYXNlVHhuXCIsXCJmaWVsZFwiOlwicmVjZWl2ZXJcIixcImV4cGVjdGVkXCI6XCJ0aGlzLmFwcC5hZGRyZXNzXCJ9IiwidGVhbCI6ODQzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyNzMifSx7InBjIjpbMTA4NV0sImVycm9yTWVzc2FnZSI6InBhcmVudCBuZmQvaWQgbXVzdCBiZSBmb3VuZCIsInRlYWwiOjkzMSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MjkwIn0seyJwYyI6WzExMTRdLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQocGFyZW50QXBwSWQpLmdsb2JhbFN0YXRlKE5GRF9LRVlfU0VMTEVSKSIsInRlYWwiOjk1MSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6Mjk0In0seyJwYyI6WzExMjhdLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQocGFyZW50QXBwSWQpLmdsb2JhbFN0YXRlKE5GRF9LRVlfT1dORVIpIiwidGVhbCI6OTY4LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyOTgifSx7InBjIjpbMTEzMF0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3duZXIgb2Ygcm9vdCBjYW4gbWludCBzZWdtZW50cyBpZiBzZWdtZW50cyBhcmUgbG9ja2VkIiwidGVhbCI6OTcyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoyOTcifSx7InBjIjpbMTE1NF0sImVycm9yTWVzc2FnZSI6InByaWNlIGNhbiBuZXZlciBiZSAwIiwidGVhbCI6OTk2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMDYifSx7InBjIjpbMTIwOF0sImVycm9yTWVzc2FnZSI6ImlmIGxpbmtpbmcgb24gbWludCwgdGhlIGJ1eWVyIE1VU1QgYmUgd2hvIHdpbGwgYmUgdGhlIG93bmVyIChyZXNlcnZlZEZvcikiLCJ0ZWFsIjoxMDUyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMTUifSx7InBjIjpbMTIzMl0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgdHJhbnNhY3Rpb24gbXVzdCBiZSBhdCBsZWFzdCBlbm91Z2ggdG8gY292ZXIgMzAgZGF5cyBvZiBuZmQgY29zdCArIGNhcnJ5IGNvc3QiLCJ0ZWFsIjoxMDgxLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMjIifSx7InBjIjpbMTIzNl0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhSRUdJU1RSWV9DT05UUkFDVF9CT1hfQ1VSUkVOVF9DT05UUkFDVCkudmFsdWUiLCJ0ZWFsIjoxMDkwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMzAifSx7InBjIjpbMTI0NF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhSRUdJU1RSWV9DT05UUkFDVF9CT1hfQ1VSUkVOVF9DT05UUkFDVCkudmFsdWUiLCJ0ZWFsIjoxMTAzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMzMifSx7InBjIjpbMTI1NF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhjb25jYXQoUkVHSVNUUllfQ09OVFJBQ1RfQk9YX0NMRUFSX05BTUVQUkVGSVgsIGN1cnJlbnRDb250cmFjdFZlcikpLnZhbHVlIiwidGVhbCI6MTExNSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MzM1In0seyJwYyI6WzEyNjBdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoYXBwcm92UHJvZ05hbWUpLnNpemUiLCJ0ZWFsIjoxMTI0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czozMzYifSx7InBjIjpbMTYwMl0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NChwYXJlbnRBcHBJZCkuZ2xvYmFsU3RhdGUoTkZEX0tFWV9WRVJTSU9OKSIsInRlYWwiOjE0NzAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjQyNSJ9LHsicGMiOlsxNjEwXSwiZXJyb3JNZXNzYWdlIjoibmZkIHJvb3Qgbm90IDMueCBtdXN0IGJlIHZlcnNpb24gMi4xMiBpbiBvcmRlciBmb3Igc2VnbWVudCBtaW50aW5nIHRvIHN1Y2NlZWQiLCJ0ZWFsIjoxNDc1LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo0MjQifSx7InBjIjpbMTk2N10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGFkZHJUb1ZlcmlmeSkgZm9yIGxpbmtOZmRBZGRyZXNzIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6MTc2OCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NDc5In0seyJwYyI6WzE5OTldLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQobmZkQXBwSWQpLmdsb2JhbFN0YXRlKE5GRF9LRVlfT1dORVIpIiwidGVhbCI6MTgwNCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NDgxIn0seyJwYyI6WzIwMDldLCJlcnJvck1lc3NhZ2UiOiJyZWZlcmVuY2VkIE5GRCBuYW1lL2lkIG11c3QgYmUgdmFsaWQiLCJ0ZWFsIjoxODE0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo0ODMifSx7InBjIjpbMjAyNl0sImVycm9yTWVzc2FnZSI6InZlcmlmeWluZyB2YXVsdCBhY2NvdW50LCBzZW5kZXIgbXVzdCBiZSBORkQgb3duZXIiLCJ0ZWFsIjoxODM0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo0ODkifSx7InBjIjpbMjAzNV0sImVycm9yTWVzc2FnZSI6ImFwcCBjYWxsIHNlbmRlciBtdXN0IG1hdGNoIGFkZHJlc3MgYmVpbmcgYWRkZWQvcmVtb3ZlZCIsInRlYWwiOjE4NDUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjQ5MiJ9LHsicGMiOlsyMDQ1XSwiZXJyb3JNZXNzYWdlIjoibmZkIHZlcmlmaWVkIGNhQWxnby4wLmFzIG11c3QgY29udGFpbiBhZGRyZXNzIGJlaW5nIGFkZGVkL3JlbW92ZWQiLCJ0ZWFsIjoxODU5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo0OTUifSx7InBjIjpbMjA2NF0sImVycm9yTWVzc2FnZSI6InNob3VsZCBhZGQgbmZkIHRvIHJldmVyc2UgYWRkcmVzcyIsInRlYWwiOjE4NzgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjUxMCJ9LHsicGMiOlsyMDgzXSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAoYWRkclRvVW5saW5rKSBmb3IgdW5saW5rTmZkQWRkcmVzcyBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjE4OTksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjUyMCJ9LHsicGMiOlsyMTA4XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX09XTkVSKSIsInRlYWwiOjE5MjksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjUyMSJ9LHsicGMiOlsyMTE4XSwiZXJyb3JNZXNzYWdlIjoicmVmZXJlbmNlZCBORkQgbmFtZS9pZCBtdXN0IGJlIHZhbGlkIiwidGVhbCI6MTkzOSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTIzIn0seyJwYyI6WzIxNDhdLCJlcnJvck1lc3NhZ2UiOiJTZW5kZXIgdW5saW5raW5nIG11c3QgYmUgTkZEIG93bmVyIE9SIGFkZHJlc3MgcmVtb3ZpbmcgaXRzZWxmIiwidGVhbCI6MTk2OSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTI5In0seyJwYyI6WzIxNThdLCJlcnJvck1lc3NhZ2UiOiJuZmQgdmVyaWZpZWQgY2FBbGdvLjAuYXMgbXVzdCBjb250YWluIGFkZHJlc3MgYmVpbmcgcmVtb3ZlZCIsInRlYWwiOjE5ODMsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjUzNCJ9LHsicGMiOlsyMjU3XSwiZXJyb3JNZXNzYWdlIjoicmVmZXJlbmNlZCBORkQgbmFtZS9pZCBtdXN0IGJlIHZhbGlkIiwidGVhbCI6MjA4NSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTU4In0seyJwYyI6WzIyNjRdLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQobmZkQXBwSWQpLmdsb2JhbFN0YXRlKE5GRF9LRVlfT1dORVIpIiwidGVhbCI6MjA5OCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTYwIn0seyJwYyI6WzIyOTFdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCAwIChidXllcikgZm9yIG93bmVyc2hpcENoYW5nZWQgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjoyMTI4LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo1NzkifSx7InBjIjpbMjMwMF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKHNlbGxlcikgZm9yIG93bmVyc2hpcENoYW5nZWQgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjoyMTM4LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo1NzkifSx7InBjIjpbMjMzN10sImVycm9yTWVzc2FnZSI6InJlZmVyZW5jZWQgTkZEIG5hbWUvaWQgbXVzdCBiZSB2YWxpZCIsInRlYWwiOjIxOTEsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjU4MyJ9LHsicGMiOlsyMzQzXSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX1ZFUlNJT04pIiwidGVhbCI6MjIwMSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTg0In0seyJwYyI6WzIzNThdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHR4bmxhYiBjYW4gY2FsbCB0aGlzIG1ldGhvZCB0byBiYWNrZmlsbCBvd25lcnNoaXAsIDMuNCsgaGFuZGxlcyBpdCBieSBjYWxsaW5nIGZyb20gdGhlIG5mZCBpdHNlbGYiLCJ0ZWFsIjoyMjE2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo1ODYifSx7InBjIjpbMjQwNl0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGFkZHJCZWluZ01vZGlmaWVkKSBmb3Igc2V0QWRkcmVzc1ByaW1hcnlOZmQgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjoyMjY2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo2MDkifSx7InBjIjpbMjQzM10sImVycm9yTWVzc2FnZSI6InJlZmVyZW5jZWQgTkZEIG5hbWUvaWQgbXVzdCBiZSB2YWxpZCIsInRlYWwiOjIzMDIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjYxMCJ9LHsicGMiOlsyNDM4XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX09XTkVSKSIsInRlYWwiOjIzMTEsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjYxMSJ9LHsicGMiOlsyNDU3XSwiZXJyb3JNZXNzYWdlIjoiaWYgY2hhbmdpbmcgcHJpbWFyeSBuZmQgZm9yIHZhdWx0IGFjY291bnQsIHNlbmRlciBtdXN0IGJlIE5GRCBvd25lciIsInRlYWwiOjIzMzIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjYxNyJ9LHsicGMiOlsyNDY2XSwiZXJyb3JNZXNzYWdlIjoiYXBwIGNhbGwgc2VuZGVyIG11c3QgbWF0Y2ggYWRkcmVzcyBiZWluZyB1cGRhdGVkIHRvIGNoYW5nZSBwcmltYXJ5IE5GRCIsInRlYWwiOjIzNDYsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjYyMCJ9LHsicGMiOlsyNTU4XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX09XTkVSKSIsInRlYWwiOjI0MjgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjY0MSJ9LHsicGMiOlsyNTY2XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX05BTUUpIiwidGVhbCI6MjQzOCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjQyIn0seyJwYyI6WzI1ODZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IE5GRCBvd25lciBvciBUeG5MYWIgY2FuIHVwZ3JhZGUgTkZEIiwidGVhbCI6MjQ1OSwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjQzIn0seyJwYyI6WzI1OThdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoUkVHSVNUUllfQ09OVFJBQ1RfQk9YX0NVUlJFTlRfQ09OVFJBQ1QpLnZhbHVlIiwidGVhbCI6MjQ3Niwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjUyIn0seyJwYyI6WzI2MDZdLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQobmZkQXBwSWQpLmdsb2JhbFN0YXRlKE5GRF9LRVlfVkVSU0lPTikiLCJ0ZWFsIjoyNDg5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo2NTQifSx7InBjIjpbMjYxMF0sImVycm9yTWVzc2FnZSI6ImNvbnRyYWN0IGFscmVhZHkgYXQgdGhpcyB2ZXJzaW9uIiwidGVhbCI6MjQ5NCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjUzIn0seyJwYyI6WzI2MTZdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoUkVHSVNUUllfQ09OVFJBQ1RfQk9YX0NVUlJFTlRfQ09OVFJBQ1QpLnZhbHVlIiwidGVhbCI6MjUwNiwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjU5In0seyJwYyI6WzI2MjZdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoY29uY2F0KFJFR0lTVFJZX0NPTlRSQUNUX0JPWF9DTEVBUl9OQU1FUFJFRklYLCBjdXJyZW50Q29udHJhY3RWZXIpKS52YWx1ZSIsInRlYWwiOjI1MTgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjY2MSJ9LHsicGMiOlsyNjMyXSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGFwcHJvdlByb2dOYW1lKS5zaXplIiwidGVhbCI6MjUyNywic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NjYyIn0seyJwYyI6WzI4MDldLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoYm94TmFtZSkudmFsdWUiLCJ0ZWFsIjoyNzMwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo2OTcifSx7InBjIjpbMjgzN10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGxvb2t1cEFkZHJlc3MpIGZvciBnZXRBZGRyZXNzQXBwSWRzIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6Mjc2OCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NzAyIn0seyJwYyI6WzI4ODhdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoYm94TmFtZSkudmFsdWUiLCJ0ZWFsIjoyODI3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo3MDgifSx7InBjIjpbMzA4NF0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NCh0aGlzLmFsZ29Vc2RPcmFjbGVBcHBJZCkuZ2xvYmFsU3RhdGUoJ3RzJykiLCJ0ZWFsIjozMDU2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo3NTgifSx7InBjIjpbMzEwMF0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NCh0aGlzLmFsZ29Vc2RPcmFjbGVBcHBJZCkuZ2xvYmFsU3RhdGUoJ2RlY2ltYWxzJykiLCJ0ZWFsIjozMDY2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo3NTkifSx7InBjIjpbMzExM10sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NCh0aGlzLmFsZ29Vc2RPcmFjbGVBcHBJZCkuZ2xvYmFsU3RhdGUoJ3ByaWNlJykiLCJ0ZWFsIjozMDc2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo3NjAifSx7InBjIjpbMzE5NV0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGxvb2t1cEFkZHJlc3MpIGZvciBjb3N0VG9BZGRUb0FkZHJlc3MgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjozMTQxLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo3NzcifSx7InBjIjpbMzQyOV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhrZXkpLnZhbHVlIiwidGVhbCI6MzM4Mywic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6ODQ3In0seyJwYyI6WzM1MTZdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoa2V5KS52YWx1ZSIsInRlYWwiOjM0OTQsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjg2NCJ9LHsicGMiOlszOTE4XSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGJveE5hbWUpLnZhbHVlIiwidGVhbCI6MzkwMCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6OTY1In0seyJwYyI6WzM5MzVdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIGV4aXN0aW5nIHYxIG5hbWUiLCJ0ZWFsIjozOTIyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czo5NzQifSx7InBjIjpbMzk1MF0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NChidG9pKHRoaXMudHhuLmFwcGxpY2F0aW9uQXJncyFbMl0pKS5nbG9iYWxTdGF0ZShSRUdJU1RSWV9LRVlfQVNBSUQpIiwidGVhbCI6MzkzMiwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6OTc5In0seyJwYyI6WzQxMDJdLCJlcnJvck1lc3NhZ2UiOiJORkQgYWxyZWFkeSBleGlzdHMgd2l0aCB0aGlzIG5hbWUiLCJ0ZWFsIjo0MTA2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoxMDMyIn0seyJwYyI6WzQxMjJdLCJlcnJvck1lc3NhZ2UiOiJORkQgaGFzIGFscmVhZHkgYmVlbiBtaW50ZWQhIiwidGVhbCI6NDEzNCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTAzOCJ9LHsicGMiOls0MTg0XSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGtleSkudmFsdWUiLCJ0ZWFsIjo0MjA2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoxMDU1In0seyJwYyI6WzQxOThdLCJlcnJvck1lc3NhZ2UiOiJpbnQgKGFwcGlkKSAnc2V0JyBzaG91bGQgYWxyZWFkeSBoYXZlIGF0IGxlYXN0IHR3byB2YWx1ZXMiLCJ0ZWFsIjo0MjI0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoxMDU5In0seyJwYyI6WzQyNjddLCJlcnJvck1lc3NhZ2UiOiJpbnQgKGFwcCBpZCkgbXVzdCBiZSBmb3VuZCBpbiBzZXQgaW4gb3JkZXIgdG8gbW92ZSBpdCIsInRlYWwiOjQzMDcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEwNzMifSx7InBjIjpbNDMxMV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhrZXkpLnZhbHVlIiwidGVhbCI6NDM2Mywic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTA4NCJ9LHsicGMiOls0NjM3XSwiZXJyb3JNZXNzYWdlIjoiaWYgbm90IGF0IGxlYXN0IDYgY2hhcnMgY2FuJ3QgYmUgdmFsaWQgLSBtaW5pbXVtIGxlbmd0aCB0byBoYXZlIC5hbGdvIiwidGVhbCI6NDc0Miwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTE2NiJ9LHsicGMiOls0NjU2XSwiZXJyb3JNZXNzYWdlIjoic3RyaW5nIG11c3QgZW5kIHcvIC5hbGdvIiwidGVhbCI6NDc1Niwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTE2NyJ9LHsicGMiOls0NzM5XSwiZXJyb3JNZXNzYWdlIjoibXVzdCBiZSAxLTI3IGNoYXJzIGluIG5mZCByb290IG9yIHNlZ21lbnQgbmFtZSIsInRlYWwiOjQ4NTEsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjExODIifSx7InBjIjpbNDc4MV0sImVycm9yTWVzc2FnZSI6Im11c3QgYmUgMS0yNyBjaGFycyBhbmQgYXQgZW5kIG9mIHN0cmluZyIsInRlYWwiOjQ4OTUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjExODUifSx7InBjIjpbNDc4NV0sImVycm9yTWVzc2FnZSI6InRvbyBtYW55ICcuJyBjaGFycyBpbiBuYW1lIiwidGVhbCI6NDkwMCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTE5MCJ9LHsicGMiOls0ODM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBjaGFyYWN0ZXIgaW4gbmFtZSIsInRlYWwiOjQ5NDksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjExOTgifSx7InBjIjpbNDk3MV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhib3hOYW1lKS52YWx1ZSIsInRlYWwiOjUwODksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEyMTkifSx7InBjIjpbNTAzMV0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NChhcHBJZCkuZ2xvYmFsU3RhdGUoa2V5KSIsInRlYWwiOjUxNjAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEyMzIifSx7InBjIjpbNTA1NF0sImVycm9yTWVzc2FnZSI6Imdsb2JhbCBzdGF0ZSB2YWx1ZSBkb2VzIG5vdCBleGlzdDogQXBwSUQuZnJvbVVpbnQ2NChhcHBJZCkuZ2xvYmFsU3RhdGUoa2V5KSIsInRlYWwiOjUxOTIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEyMzkifSx7InBjIjpbNTA5NV0sImVycm9yTWVzc2FnZSI6InBhcmVudCBuZmQvaWQgbXVzdCBiZSBmb3VuZCIsInRlYWwiOjUyNTgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEyNzIifSx7InBjIjpbNTE3OF0sImVycm9yTWVzc2FnZSI6InNlZ21lbnQgbWludCBjb3N0IG11c3QgYmUgYXQgbGVhc3QgTkZEX01JTl9TRUdNRU5UX1VTRCIsInRlYWwiOjUzMjUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEyODcifSx7InBjIjpbNTI4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgY29zdCBjYWxjIiwidGVhbCI6NTQyNiwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTMwOSJ9LHsicGMiOls1MzI3XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX09XTkVSKSIsInRlYWwiOjU0NzYsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjEzMjAifSx7InBjIjpbNTQ4MF0sImVycm9yTWVzc2FnZSI6InByaWNlIGFsd2F5cyBuZWVkcyB0byBiZSBhdCBsZWFzdCAxIGFsZ28iLCJ0ZWFsIjo1NjMzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZEUmVnaXN0cnkuYWxnby50czoxMzUxIn0seyJwYyI6WzU5NTFdLCJlcnJvck1lc3NhZ2UiOiJsc2lnIGhhcyB0byBoYXZlIGkuYXBwaWQgbG9jYWxzdGF0ZSIsInRlYWwiOjYwODYsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjE0NTYifSx7InBjIjpbNjAyNF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhib3hOYW1lKS52YWx1ZSIsInRlYWwiOjYxNTksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRSZWdpc3RyeS5hbGdvLnRzOjE0NzkifSx7InBjIjpbNjAzMF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhib3hOYW1lKS5zaXplIiwidGVhbCI6NjE2OCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTQ4MCJ9LHsicGMiOls2MDc2XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KG5mZEFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX05BTUUpIiwidGVhbCI6NjIyNywic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTQ4NyJ9LHsicGMiOls2MTM4XSwiZXJyb3JNZXNzYWdlIjoibWF4IGV4cGlyYXRpb24gZXhjZWVkZWQgcGFyYW1ldGVycyBkZWZpbmVkIGJ5IHJlZ2lzdHJ5IiwidGVhbCI6NjMwNiwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTUwNSJ9LHsicGMiOls2MTU1XSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBBcHBJRC5mcm9tVWludDY0KGFwcElkKS5nbG9iYWxTdGF0ZShORkRfS0VZX1ZFUlNJT04pIiwidGVhbCI6NjMzMywic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6MTUxMyJ9LHsicGMiOls2MTk4XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6NjM2NCwic291cmNlIjoiY29udHJhY3RzL05GRFJlZ2lzdHJ5LmFsZ28udHM6NTEifV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOm51bGwsImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6MywibWlub3IiOjI3LCJwYXRjaCI6MjM3MjE3LCJjb21taXRIYXNoIjoiMGJjM2Q3ZTQifX0sImV2ZW50cyI6W3sibmFtZSI6Im5mZFJlZ2lzdHJ5X21pbnRlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VPbmVZZWFyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFpZEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcnJ5Q29zdCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBUaW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50VG9TZWxsZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWlzc2lvbkFkZHJlc3MiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRUb0NvbW1pc3Npb24iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VnbWVudFJvb3RPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudFRvU2VnbWVudFJvb3QiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Im5mZFJlZ2lzdHJ5X2FkZHJlc3NQcmltYXJ5TmZkQ2hhbmdlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnsiYWRtaW5Bc2FJZCI6eyJ0eXBlIjoidWludDY0IiwidmFsdWUiOm51bGx9LCJuZmRUcmVhc3VyeUFkZHIiOnsidHlwZSI6ImFkZHJlc3MiLCJ2YWx1ZSI6bnVsbH0sIm5mZENvbW1pc3Npb24xQWRkciI6eyJ0eXBlIjoiYWRkcmVzcyIsInZhbHVlIjpudWxsfSwibmZkQ29tbWlzc2lvbjFSYXRlIjp7InR5cGUiOiJ1aW50NjQiLCJ2YWx1ZSI6bnVsbH0sImFsZ29Vc2RPcmFjbGVBcHBJZCI6eyJ0eXBlIjoidWludDY0IiwidmFsdWUiOm51bGx9LCJkZXZlbG9wbWVudEFsbG93U2hvcnRNaW50cyI6eyJ0eXBlIjoidWludDY0IiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6eyJhZG1pbkFzYUlkIjp7InNsb3QiOjIwMCwidHlwZSI6InVpbnQ2NCJ9LCJuZmRUcmVhc3VyeUFkZHIiOnsic2xvdCI6MjAxLCJ0eXBlIjoiYWRkcmVzcyJ9LCJuZmRDb21taXNzaW9uMUFkZHIiOnsic2xvdCI6MjAyLCJ0eXBlIjoiYWRkcmVzcyJ9LCJuZmRDb21taXNzaW9uMVJhdGUiOnsic2xvdCI6MjAzLCJ0eXBlIjoidWludDY0In0sImFsZ29Vc2RPcmFjbGVBcHBJZCI6eyJzbG90IjoyMDQsInR5cGUiOiJ1aW50NjQifSwiZGV2ZWxvcG1lbnRBbGxvd1Nob3J0TWludHMiOnsic2xvdCI6MjA1LCJ0eXBlIjoidWludDY0In19fQ==";
    }

}
