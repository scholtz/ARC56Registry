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

namespace Arc56.Generated.TxnLab.nfd_sdk.NFDInstance_9b7fcf89
{


    public class NFDInstanceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFDInstanceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PayoutInfo : AVMObjectType
            {
                public ulong AmountToSeller { get; set; }

                public Algorand.Address CommissionAddress { get; set; }

                public ulong AmountToCommission { get; set; }

                public Algorand.Address SegmentRootOwner { get; set; }

                public ulong AmountToSegmentRoot { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountToSeller.From(AmountToSeller);
                    ret.AddRange(vAmountToSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommissionAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCommissionAddress.From(CommissionAddress);
                    ret.AddRange(vCommissionAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToCommission = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountToCommission.From(AmountToCommission);
                    ret.AddRange(vAmountToCommission.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSegmentRootOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSegmentRootOwner.From(SegmentRootOwner);
                    ret.AddRange(vSegmentRootOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountToSegmentRoot = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountToSegmentRoot.From(AmountToSegmentRoot);
                    ret.AddRange(vAmountToSegmentRoot.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PayoutInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PayoutInfo();
                    uint count = 0;
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

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PayoutInfo);
                }
                public bool Equals(PayoutInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PayoutInfo left, PayoutInfo right)
                {
                    return EqualityComparer<PayoutInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PayoutInfo left, PayoutInfo right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class NfdOfferForSaleEvent
            {
                public static readonly byte[] Selector = new byte[4] { 194, 75, 90, 214 };
                public const string Signature = "nfd_offerForSale(uint64,string,address,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Seller { get; set; }
                public ulong Amount { get; set; }
                public Algorand.Address ReservedFor { get; set; }

                public static NfdOfferForSaleEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdOfferForSaleEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReservedFor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReservedFor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReservedFor = vReservedFor.ToValue();
                    if (valueReservedFor is Algorand.Address vReservedForValue) { ret.ReservedFor = vReservedForValue; }
                    return ret;

                }

            }

            public class NfdSaleCancelledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 67, 101, 237, 144 };
                public const string Signature = "nfd_saleCancelled(uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }

                public static NfdSaleCancelledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdSaleCancelledEvent();
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
                    return ret;

                }

            }

            public class NfdPostedOfferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 82, 83, 43, 112 };
                public const string Signature = "nfd_postedOffer(uint64,string,address,uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Sender { get; set; }
                public ulong Amount { get; set; }
                public string Note { get; set; }

                public static NfdPostedOfferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdPostedOfferEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is Algorand.Address vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    var indexNote = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNote.Decode(eventData.Skip(indexNote).ToArray());
                    var valueNote = vNote.ToValue();
                    if (valueNote is string vNoteValue) { ret.Note = vNoteValue; }
                    return ret;

                }

            }

            public class NfdPurchasedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 120, 220, 137, 227 };
                public const string Signature = "nfd_purchased(uint64,string,address,address,uint64,uint64,uint64,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Seller { get; set; }
                public Algorand.Address Buyer { get; set; }
                public ulong SellAmount { get; set; }
                public ulong OfferAmount { get; set; }
                public ulong OverpaymentRefund { get; set; }
                public Algorand.Address ConvFeeAddr { get; set; }
                public ulong ConvFeeAmount { get; set; }

                public static NfdPurchasedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdPurchasedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSellAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSellAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSellAmount = vSellAmount.ToValue();
                    if (valueSellAmount is ulong vSellAmountValue) { ret.SellAmount = vSellAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOfferAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOfferAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOfferAmount = vOfferAmount.ToValue();
                    if (valueOfferAmount is ulong vOfferAmountValue) { ret.OfferAmount = vOfferAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOverpaymentRefund = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOverpaymentRefund.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOverpaymentRefund = vOverpaymentRefund.ToValue();
                    if (valueOverpaymentRefund is ulong vOverpaymentRefundValue) { ret.OverpaymentRefund = vOverpaymentRefundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConvFeeAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vConvFeeAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConvFeeAddr = vConvFeeAddr.ToValue();
                    if (valueConvFeeAddr is Algorand.Address vConvFeeAddrValue) { ret.ConvFeeAddr = vConvFeeAddrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConvFeeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vConvFeeAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConvFeeAmount = vConvFeeAmount.ToValue();
                    if (valueConvFeeAmount is ulong vConvFeeAmountValue) { ret.ConvFeeAmount = vConvFeeAmountValue; }
                    return ret;

                }

            }

            public class NfdRenewedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 20, 167, 106, 62 };
                public const string Signature = "nfd_renewed(uint64,string,address,address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address OrigOwner { get; set; }
                public Algorand.Address Buyer { get; set; }
                public ulong PriceOneYear { get; set; }
                public ulong RenewAmount { get; set; }
                public ulong ExpTime { get; set; }

                public static NfdRenewedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdRenewedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrigOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrigOwner = vOrigOwner.ToValue();
                    if (valueOrigOwner is Algorand.Address vOrigOwnerValue) { ret.OrigOwner = vOrigOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceOneYear = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceOneYear.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceOneYear = vPriceOneYear.ToValue();
                    if (valuePriceOneYear is ulong vPriceOneYearValue) { ret.PriceOneYear = vPriceOneYearValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRenewAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRenewAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRenewAmount = vRenewAmount.ToValue();
                    if (valueRenewAmount is ulong vRenewAmountValue) { ret.RenewAmount = vRenewAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpTime = vExpTime.ToValue();
                    if (valueExpTime is ulong vExpTimeValue) { ret.ExpTime = vExpTimeValue; }
                    return ret;

                }

            }

            public class NfdAddressLinkedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 207, 157, 30, 36 };
                public const string Signature = "nfd_addressLinked(uint64,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Address { get; set; }

                public static NfdAddressLinkedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdAddressLinkedEvent();
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

            public class NfdAddressUnlinkedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 164, 211, 185, 167 };
                public const string Signature = "nfd_addressUnlinked(uint64,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AppId { get; set; }
                public string Name { get; set; }
                public Algorand.Address Address { get; set; }

                public static NfdAddressUnlinkedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new NfdAddressUnlinkedEvent();
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
        /// <param name="nfdName"> </param>
        /// <param name="seller"> </param>
        /// <param name="buyer"> </param>
        /// <param name="purchaseAmount"> </param>
        /// <param name="expTime"> </param>
        /// <param name="commission1Addr"> </param>
        /// <param name="commission1Pct"> </param>
        /// <param name="commission2Addr"> </param>
        /// <param name="commission2Pct"> </param>
        /// <param name="segmentRootAppId"> </param>
        /// <param name="segmentRootCommissionAddr"> </param>
        public async Task CreateApplication(string nfdName, Algorand.Address seller, Algorand.Address buyer, ulong purchaseAmount, ulong expTime, Algorand.Address commission1Addr, ulong commission1Pct, Algorand.Address commission2Addr, ulong commission2Pct, ulong segmentRootAppId, Algorand.Address segmentRootCommissionAddr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 202, 82, 193 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var purchaseAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); purchaseAmountAbi.From(purchaseAmount);
            var expTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expTimeAbi.From(expTime);
            var commission1AddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commission1AddrAbi.From(commission1Addr);
            var commission1PctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); commission1PctAbi.From(commission1Pct);
            var commission2AddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commission2AddrAbi.From(commission2Addr);
            var commission2PctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); commission2PctAbi.From(commission2Pct);
            var segmentRootAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); segmentRootAppIdAbi.From(segmentRootAppId);
            var segmentRootCommissionAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); segmentRootCommissionAddrAbi.From(segmentRootCommissionAddr);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, sellerAbi, buyerAbi, purchaseAmountAbi, expTimeAbi, commission1AddrAbi, commission1PctAbi, commission2AddrAbi, commission2PctAbi, segmentRootAppIdAbi, segmentRootCommissionAddrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(string nfdName, Algorand.Address seller, Algorand.Address buyer, ulong purchaseAmount, ulong expTime, Algorand.Address commission1Addr, ulong commission1Pct, Algorand.Address commission2Addr, ulong commission2Pct, ulong segmentRootAppId, Algorand.Address segmentRootCommissionAddr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 202, 82, 193 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var purchaseAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); purchaseAmountAbi.From(purchaseAmount);
            var expTimeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expTimeAbi.From(expTime);
            var commission1AddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commission1AddrAbi.From(commission1Addr);
            var commission1PctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); commission1PctAbi.From(commission1Pct);
            var commission2AddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); commission2AddrAbi.From(commission2Addr);
            var commission2PctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); commission2PctAbi.From(commission2Pct);
            var segmentRootAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); segmentRootAppIdAbi.From(segmentRootAppId);
            var segmentRootCommissionAddrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); segmentRootCommissionAddrAbi.From(segmentRootCommissionAddr);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, sellerAbi, buyerAbi, purchaseAmountAbi, expTimeAbi, commission1AddrAbi, commission1PctAbi, commission2AddrAbi, commission2PctAbi, segmentRootAppIdAbi, segmentRootCommissionAddrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="versionNum"> </param>
        public async Task UpdateApplication(string versionNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 71, 64, 91 };
            var versionNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionNumAbi.From(versionNum);

            var result = await base.CallApp(new List<object> { abiHandle, versionNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(string versionNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 71, 64, 91 };
            var versionNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionNumAbi.From(versionNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        /// <param name="nfdName"> </param>
        /// <param name="url"> </param>
        public async Task MintAsa(string nfdName, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 223, 46, 91 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            var result = await base.CallApp(new List<object> { abiHandle, nfdNameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MintAsa_Transactions(string nfdName, string url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 223, 46, 91 };
            var nfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nfdNameAbi.From(nfdName);
            var urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); urlAbi.From(url);

            return await base.MakeTransactionList(new List<object> { abiHandle, nfdNameAbi, urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldNames"> </param>
        public async Task DeleteFields(byte[][] fieldNames, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 50, 223, 117 };
            var fieldNamesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldNamesAbi.From(fieldNames);

            var result = await base.CallApp(new List<object> { abiHandle, fieldNamesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteFields_Transactions(byte[][] fieldNames, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 50, 223, 117 };
            var fieldNamesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldNamesAbi.From(fieldNames);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldNamesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="childNfdName"> </param>
        /// <param name="childNfdAppID"> </param>
        public async Task UpdateSegmentCount(string childNfdName, ulong childNfdAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 38, 197, 145 };
            var childNfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); childNfdNameAbi.From(childNfdName);
            var childNfdAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); childNfdAppIDAbi.From(childNfdAppID);

            var result = await base.CallApp(new List<object> { abiHandle, childNfdNameAbi, childNfdAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateSegmentCount_Transactions(string childNfdName, ulong childNfdAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 38, 197, 145 };
            var childNfdNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); childNfdNameAbi.From(childNfdName);
            var childNfdAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); childNfdAppIDAbi.From(childNfdAppID);

            return await base.MakeTransactionList(new List<object> { abiHandle, childNfdNameAbi, childNfdAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldAndVals"> </param>
        public async Task<ulong> GetFieldUpdateCost(byte[][] fieldAndVals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 90, 228, 149 };
            var fieldAndValsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldAndValsAbi.From(fieldAndVals);

            var result = await base.SimApp(new List<object> { abiHandle, fieldAndValsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetFieldUpdateCost_Transactions(byte[][] fieldAndVals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 90, 228, 149 };
            var fieldAndValsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldAndValsAbi.From(fieldAndVals);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldAndValsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldAndVals"> </param>
        public async Task UpdateFields(byte[][] fieldAndVals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 244, 39, 17 };
            var fieldAndValsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldAndValsAbi.From(fieldAndVals);

            var result = await base.CallApp(new List<object> { abiHandle, fieldAndValsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateFields_Transactions(byte[][] fieldAndVals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 244, 39, 17 };
            var fieldAndValsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); fieldAndValsAbi.From(fieldAndVals);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldAndValsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldName"> </param>
        public async Task<byte[]> ReadField(byte[] fieldName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 19, 237, 228 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); fieldNameAbi.From(fieldName);

            var result = await base.SimApp(new List<object> { abiHandle, fieldNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ReadField_Transactions(byte[] fieldName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 19, 237, 228 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); fieldNameAbi.From(fieldName);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sellAmount"> </param>
        /// <param name="reservedFor"> </param>
        public async Task OfferForSale(ulong sellAmount, Algorand.Address reservedFor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 118, 217, 202 };
            var sellAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sellAmountAbi.From(sellAmount);
            var reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reservedForAbi.From(reservedFor);

            var result = await base.CallApp(new List<object> { abiHandle, sellAmountAbi, reservedForAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OfferForSale_Transactions(ulong sellAmount, Algorand.Address reservedFor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 118, 217, 202 };
            var sellAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sellAmountAbi.From(sellAmount);
            var reservedForAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); reservedForAbi.From(reservedFor);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellAmountAbi, reservedForAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CancelSale(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 245, 213, 13 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelSale_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 245, 213, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="offer"> </param>
        /// <param name="note"> </param>
        public async Task PostOffer(ulong offer, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 49, 18, 239 };
            var offerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerAbi.From(offer);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, offerAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostOffer_Transactions(ulong offer, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 49, 18, 239 };
            var offerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerAbi.From(offer);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, offerAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="oneYearPrice"> </param>
        /// <param name="segmentPlatformCostInAlgo"> </param>
        public async Task<Structs.PayoutInfo> MintPayout(ulong oneYearPrice, ulong segmentPlatformCostInAlgo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 83, 55, 196 };
            var oneYearPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oneYearPriceAbi.From(oneYearPrice);
            var segmentPlatformCostInAlgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); segmentPlatformCostInAlgoAbi.From(segmentPlatformCostInAlgo);

            var result = await base.CallApp(new List<object> { abiHandle, oneYearPriceAbi, segmentPlatformCostInAlgoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PayoutInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MintPayout_Transactions(ulong oneYearPrice, ulong segmentPlatformCostInAlgo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 83, 55, 196 };
            var oneYearPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oneYearPriceAbi.From(oneYearPrice);
            var segmentPlatformCostInAlgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); segmentPlatformCostInAlgoAbi.From(segmentPlatformCostInAlgo);

            return await base.MakeTransactionList(new List<object> { abiHandle, oneYearPriceAbi, segmentPlatformCostInAlgoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Purchase(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 163, 146, 174, 130 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Purchase_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 163, 146, 174, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldName"> </param>
        /// <param name="address"> </param>
        public async Task<bool> IsAddressInField(string fieldName, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 67, 149, 42 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldNameAbi.From(fieldName);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, fieldNameAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAddressInField_Transactions(string fieldName, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 67, 149, 42 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldNameAbi.From(fieldName);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldNameAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetRenewPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRenewPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="hash"> </param>
        public async Task UpdateHash(byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 46, 130, 218 };
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            var result = await base.CallApp(new List<object> { abiHandle, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateHash_Transactions(byte[] hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 46, 130, 218 };
            var hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashAbi.From(hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lock"> </param>
        public async Task ContractLock(bool @lock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 188, 44, 131 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);

            var result = await base.CallApp(new List<object> { abiHandle, lockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ContractLock_Transactions(bool @lock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 188, 44, 131 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);

            return await base.MakeTransactionList(new List<object> { abiHandle, lockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lock"> </param>
        /// <param name="usdPrice"> </param>
        public async Task SegmentLock(bool @lock, ulong usdPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 83, 88, 166 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);
            var usdPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdPriceAbi.From(usdPrice);

            var result = await base.CallApp(new List<object> { abiHandle, lockAbi, usdPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SegmentLock_Transactions(bool @lock, ulong usdPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 83, 88, 166 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);
            var usdPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdPriceAbi.From(usdPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, lockAbi, usdPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="lock"> </param>
        public async Task VaultOptInLock(bool @lock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 101, 125, 119 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);

            var result = await base.CallApp(new List<object> { abiHandle, lockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VaultOptInLock_Transactions(bool @lock, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 101, 125, 119 };
            var lockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lockAbi.From(@lock);

            return await base.MakeTransactionList(new List<object> { abiHandle, lockAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task VaultOptIn(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 61, 21, 35 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VaultOptIn_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 61, 21, 35 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="receiver"> </param>
        /// <param name="note"> </param>
        /// <param name="asset"> </param>
        /// <param name="otherAssets"> </param>
        public async Task VaultSend(ulong amount, Algorand.Address receiver, string note, ulong asset, ulong[] otherAssets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 130, 28, 26 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var otherAssetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); otherAssetsAbi.From(otherAssets);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, receiverAbi, noteAbi, assetAbi, otherAssetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VaultSend_Transactions(ulong amount, Algorand.Address receiver, string note, ulong asset, ulong[] otherAssets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 130, 28, 26 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var otherAssetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); otherAssetsAbi.From(otherAssets);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, receiverAbi, noteAbi, assetAbi, otherAssetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Renew adds more time to an existing NFDs expiration, or renews it if expired.
        ///
        ///
        ///As part of v2-v3 upgrade, the NFDs are converted from lifetime NFDs to renewal NFDs. The v2 contract is upgraded
        ///to v3, then renew is called on the (now v3) nfd to turn it into a renewal (note the if curExpiration === 0 check)
        ///
        ///
        ///If already renewal, then it extends the current expiration time by the time specified (minimum 1 yr) (365 / price paid * mint price)
        ///Expirations can never be more than NFD_MAX_EXPIRATION_DAYS days in the future.
        ///
        ///
        ///IF the NFD is expired:
        ///    x The current owner can take it back over at base price - and NFD metadata doesn't have to be cleared - they
        ///    get it back as-is.
        ///    x If not current owner, then the price goes from high of base price * 10,000 down to base price over 24 hrs where
        ///    'buyer' has to pay at least that price.  The NFD MUST ALREADY HAVE ITS METADATA CLEARED!
        ///</summary>
        /// <param name="payment">The payment transaction from which the renewal period is determined.. </param>
        public async Task Renew(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Renew_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fieldName"> </param>
        /// <param name="address"> </param>
        public async Task SetPrimaryAddress(string fieldName, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 182, 216, 108 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldNameAbi.From(fieldName);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, fieldNameAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPrimaryAddress_Transactions(string fieldName, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 182, 216, 108 };
            var fieldNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldNameAbi.From(fieldName);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldNameAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approved call from registry instructing us to move the specified u.cav.xx field and add to the specified
        ///verified field.
        ///</summary>
        /// <param name="fieldBeingVerified">- MUST START with u.cav. (!)
        ///gets 'added' to 'set' in next arg - must be fixed-sized bytes </param>
        /// <param name="fieldSetName">(must BE v.ca[...].as) </param>
        public async Task<bool> RegistryAddingVerifiedAddress(string fieldBeingVerified, string fieldSetName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 204, 237, 87 };
            var fieldBeingVerifiedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldBeingVerifiedAbi.From(fieldBeingVerified);
            var fieldSetNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldSetNameAbi.From(fieldSetName);

            var result = await base.CallApp(new List<object> { abiHandle, fieldBeingVerifiedAbi, fieldSetNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegistryAddingVerifiedAddress_Transactions(string fieldBeingVerified, string fieldSetName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 204, 237, 87 };
            var fieldBeingVerifiedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldBeingVerifiedAbi.From(fieldBeingVerified);
            var fieldSetNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldSetNameAbi.From(fieldSetName);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldBeingVerifiedAbi, fieldSetNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approved call from registry instructing us to REMOVE an address from the specified verified address set
        ///</summary>
        /// <param name="fieldBeingChanged">The field being changed in the address registry. </param>
        /// <param name="address">The address to be removed from the field. </param>
        /// <param name="mbrRefundDest">the address to send reclaimed MBR (if any)
        /// boolean - true if valid removed </param>
        public async Task<bool> RegistryRemovingVerifiedAddress(string fieldBeingChanged, Algorand.Address address, Algorand.Address mbrRefundDest, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 137, 10, 117 };
            var fieldBeingChangedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldBeingChangedAbi.From(fieldBeingChanged);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var mbrRefundDestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); mbrRefundDestAbi.From(mbrRefundDest);

            var result = await base.CallApp(new List<object> { abiHandle, fieldBeingChangedAbi, addressAbi, mbrRefundDestAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegistryRemovingVerifiedAddress_Transactions(string fieldBeingChanged, Algorand.Address address, Algorand.Address mbrRefundDest, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 137, 10, 117 };
            var fieldBeingChangedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); fieldBeingChangedAbi.From(fieldBeingChanged);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var mbrRefundDestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); mbrRefundDestAbi.From(mbrRefundDest);

            return await base.MakeTransactionList(new List<object> { abiHandle, fieldBeingChangedAbi, addressAbi, mbrRefundDestAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJORkRJbnN0YW5jZSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGF5b3V0SW5mbyI6W3sibmFtZSI6ImFtb3VudFRvU2VsbGVyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvbW1pc3Npb25BZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnRUb0NvbW1pc3Npb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2VnbWVudFJvb3RPd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50VG9TZWdtZW50Um9vdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmZkTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJjaGFzZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwVGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pc3Npb24xQWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWlzc2lvbjFQY3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXNzaW9uMkFkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pc3Npb24yUGN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWdtZW50Um9vdEFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VnbWVudFJvb3RDb21taXNzaW9uQWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidXBkYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbk51bSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdhcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibWludEFzYSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZmROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlbGV0ZUZpZWxkcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkTmFtZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InVwZGF0ZVNlZ21lbnRDb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGlsZE5mZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoaWxkTmZkQXBwSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldEZpZWxkVXBkYXRlQ29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkQW5kVmFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ1cGRhdGVGaWVsZHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZEFuZFZhbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InJlYWRGaWVsZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoib2ZmZXJGb3JTYWxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlZEZvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRfb2ZmZXJGb3JTYWxlIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmVkRm9yIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY2FuY2VsU2FsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRfc2FsZUNhbmNlbGxlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicG9zdE9mZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W3sibmFtZSI6Im5mZF9wb3N0ZWRPZmZlciIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vdGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJtaW50UGF5b3V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uZVllYXJQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VnbWVudFBsYXRmb3JtQ29zdEluQWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsdWludDY0LGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IlBheW91dEluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicHVyY2hhc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRfcHVyY2hhc2VkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZmVyQW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3ZlcnBheW1lbnRSZWZ1bmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udkZlZUFkZHIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb252RmVlQW1vdW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiaXNBZGRyZXNzSW5GaWVsZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJnZXRSZW5ld1ByaWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InVwZGF0ZUhhc2giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY29udHJhY3RMb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJzZWdtZW50TG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9jayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkUHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InZhdWx0T3B0SW5Mb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ2YXVsdE9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ2YXVsdFNlbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyQXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJyZW5ldyIsImRlc2MiOiJSZW5ldyBhZGRzIG1vcmUgdGltZSB0byBhbiBleGlzdGluZyBORkRzIGV4cGlyYXRpb24sIG9yIHJlbmV3cyBpdCBpZiBleHBpcmVkLlxuXG5cbkFzIHBhcnQgb2YgdjItdjMgdXBncmFkZSwgdGhlIE5GRHMgYXJlIGNvbnZlcnRlZCBmcm9tIGxpZmV0aW1lIE5GRHMgdG8gcmVuZXdhbCBORkRzLiBUaGUgdjIgY29udHJhY3QgaXMgdXBncmFkZWRcbnRvIHYzLCB0aGVuIHJlbmV3IGlzIGNhbGxlZCBvbiB0aGUgKG5vdyB2MykgbmZkIHRvIHR1cm4gaXQgaW50byBhIHJlbmV3YWwgKG5vdGUgdGhlIGlmIGN1ckV4cGlyYXRpb24gPT09IDAgY2hlY2spXG5cblxuSWYgYWxyZWFkeSByZW5ld2FsLCB0aGVuIGl0IGV4dGVuZHMgdGhlIGN1cnJlbnQgZXhwaXJhdGlvbiB0aW1lIGJ5IHRoZSB0aW1lIHNwZWNpZmllZCAobWluaW11bSAxIHlyKSAoMzY1IC8gcHJpY2UgcGFpZCAqIG1pbnQgcHJpY2UpXG5FeHBpcmF0aW9ucyBjYW4gbmV2ZXIgYmUgbW9yZSB0aGFuIE5GRF9NQVhfRVhQSVJBVElPTl9EQVlTIGRheXMgaW4gdGhlIGZ1dHVyZS5cblxuXG5JRiB0aGUgTkZEIGlzIGV4cGlyZWQ6XG4gICAgeCBUaGUgY3VycmVudCBvd25lciBjYW4gdGFrZSBpdCBiYWNrIG92ZXIgYXQgYmFzZSBwcmljZSAtIGFuZCBORkQgbWV0YWRhdGEgZG9lc24ndCBoYXZlIHRvIGJlIGNsZWFyZWQgLSB0aGV5XG4gICAgZ2V0IGl0IGJhY2sgYXMtaXMuXG4gICAgeCBJZiBub3QgY3VycmVudCBvd25lciwgdGhlbiB0aGUgcHJpY2UgZ29lcyBmcm9tIGhpZ2ggb2YgYmFzZSBwcmljZSAqIDEwLDAwMCBkb3duIHRvIGJhc2UgcHJpY2Ugb3ZlciAyNCBocnMgd2hlcmVcbiAgICAnYnV5ZXInIGhhcyB0byBwYXkgYXQgbGVhc3QgdGhhdCBwcmljZS4gIFRoZSBORkQgTVVTVCBBTFJFQURZIEhBVkUgSVRTIE1FVEFEQVRBIENMRUFSRUQhIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gZnJvbSB3aGljaCB0aGUgcmVuZXdhbCBwZXJpb2QgaXMgZGV0ZXJtaW5lZC4uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W3sibmFtZSI6Im5mZF9zYWxlQ2FuY2VsbGVkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Im5mZF9yZW5ld2VkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JpZ093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VPbmVZZWFyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVuZXdBbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBUaW1lIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoic2V0UHJpbWFyeUFkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmVnaXN0cnlBZGRpbmdWZXJpZmllZEFkZHJlc3MiLCJkZXNjIjoiQXBwcm92ZWQgY2FsbCBmcm9tIHJlZ2lzdHJ5IGluc3RydWN0aW5nIHVzIHRvIG1vdmUgdGhlIHNwZWNpZmllZCB1LmNhdi54eCBmaWVsZCBhbmQgYWRkIHRvIHRoZSBzcGVjaWZpZWRcbnZlcmlmaWVkIGZpZWxkLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZEJlaW5nVmVyaWZpZWQiLCJkZXNjIjoiLSBNVVNUIFNUQVJUIHdpdGggdS5jYXYuICghKVxuZ2V0cyAnYWRkZWQnIHRvICdzZXQnIGluIG5leHQgYXJnIC0gbXVzdCBiZSBmaXhlZC1zaXplZCBieXRlcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGRTZXROYW1lIiwiZGVzYyI6IihtdXN0IEJFIHYuY2FbLi4uXS5hcykiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6InRydWUgaWYgYWRkZWQgb3IgYWxyZWFkeSBwcmVzZW50LCBmYWxzZSBvdGhlcndpc2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRfYWRkcmVzc0xpbmtlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJyZWdpc3RyeVJlbW92aW5nVmVyaWZpZWRBZGRyZXNzIiwiZGVzYyI6IkFwcHJvdmVkIGNhbGwgZnJvbSByZWdpc3RyeSBpbnN0cnVjdGluZyB1cyB0byBSRU1PVkUgYW4gYWRkcmVzcyBmcm9tIHRoZSBzcGVjaWZpZWQgdmVyaWZpZWQgYWRkcmVzcyBzZXQiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGRCZWluZ0NoYW5nZWQiLCJkZXNjIjoiVGhlIGZpZWxkIGJlaW5nIGNoYW5nZWQgaW4gdGhlIGFkZHJlc3MgcmVnaXN0cnkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOiJUaGUgYWRkcmVzcyB0byBiZSByZW1vdmVkIGZyb20gdGhlIGZpZWxkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclJlZnVuZERlc3QiLCJkZXNjIjoidGhlIGFkZHJlc3MgdG8gc2VuZCByZWNsYWltZWQgTUJSIChpZiBhbnkpXG4gYm9vbGVhbiAtIHRydWUgaWYgdmFsaWQgcmVtb3ZlZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJuZmRfYWRkcmVzc1VubGlua2VkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MzB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM2XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE3In0seyJwYyI6WzQ0XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAoc2VnbWVudFJvb3RDb21taXNzaW9uQWRkcikgZm9yIGNyZWF0ZUFwcGxpY2F0aW9uIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6MzcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjQzIn0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMyAoY29tbWlzc2lvbjJBZGRyKSBmb3IgY3JlYXRlQXBwbGljYXRpb24gbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjo1NSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NDAifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCA1IChjb21taXNzaW9uMUFkZHIpIGZvciBjcmVhdGVBcHBsaWNhdGlvbiBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjY5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozOCJ9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDggKGJ1eWVyKSBmb3IgY3JlYXRlQXBwbGljYXRpb24gbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjo4Nywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MzUifSx7InBjIjpbOTZdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCA5IChzZWxsZXIpIGZvciBjcmVhdGVBcHBsaWNhdGlvbiBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjk3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozNCJ9LHsicGMiOlsxMTddLCJlcnJvck1lc3NhZ2UiOiJjYWxsZXIgbXVzdCBiZSBORkQgcmVnaXN0cnkhIiwidGVhbCI6MTIyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0NSJ9LHsicGMiOlsyMTddLCJlcnJvck1lc3NhZ2UiOiJjb21taXNzaW9uIG11c3QgYmUgYmV0d2VlbiAxIGFuZCA1MCUiLCJ0ZWFsIjoyMjQsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjYwIn0seyJwYyI6WzI1MV0sImVycm9yTWVzc2FnZSI6ImNvbW1pc3Npb24gbXVzdCBiZSBiZXR3ZWVuIDEgYW5kIDUwJSIsInRlYWwiOjI2Miwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NjQifSx7InBjIjpbMzgyXSwiZXJyb3JNZXNzYWdlIjoicGFyZW50IGNvbW1pc3Npb24gYWRkcmVzcyBtdXN0IGJlIHNldCBpZiBwYXJlbnQgYXBwIGlkIGlzIHNldCBhbmQgcGFyZW50IGlzIHVubG9ja2VkIiwidGVhbCI6MzcwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo5MCJ9LHsicGMiOlszOTNdLCJlcnJvck1lc3NhZ2UiOiJ0aGUgc2VnbWVudCBjb21taXNzaW9uIGFnZW50IHNob3VsZCBiZSB0aGUgcGFyZW50IG5mZCdzIHNlbGxlciIsInRlYWwiOjM4NCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6OTcifSx7InBjIjpbNDIwXSwiZXJyb3JNZXNzYWdlIjoiY29udHJhY3QgbXVzdCBiZSB1bmxvY2tlZCB0byB1cGdyYWRlIiwidGVhbCI6NDIwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTAifSx7InBjIjpbNDI2XSwiZXJyb3JNZXNzYWdlIjoiY2FsbGVyIG11c3QgYmUgTkZEIHJlZ2lzdHJ5ISIsInRlYWwiOjQyOSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTEzIn0seyJwYyI6WzQ0OV0sImVycm9yTWVzc2FnZSI6ImNhbid0IHN0aWxsIGJlIGluIG1pbnRpbmcgc3RhdGUiLCJ0ZWFsIjo0NTksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEyMCJ9LHsicGMiOls0NjddLCJlcnJvck1lc3NhZ2UiOiJORkQgY2FuJ3QgYmUgZXhwaXJlZCBmb3IgdGhlc2UgdjEvdjIgb3BlcmF0aW9ucyIsInRlYWwiOjQ4MSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTI1In0seyJwYyI6WzczMV0sImVycm9yTWVzc2FnZSI6InVua25vd24gbWV0aG9kIiwidGVhbCI6Njc3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxODAifSx7InBjIjpbNzY4XSwiZXJyb3JNZXNzYWdlIjoiY2FsbGVyIG11c3QgYmUgTkZEIHJlZ2lzdHJ5ISIsInRlYWwiOjcyMSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTkwIn0seyJwYyI6Wzk1OV0sImVycm9yTWVzc2FnZSI6ImZpZWxkIG5vdCByZW1vdmFibGUgb3Igbm8gcGVybWlzc2lvbnMgdG8gcmVtb3ZlIiwidGVhbCI6OTQyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoyMjQifSx7InBjIjpbOTYzXSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKG5hbWUpLnNpemUiLCJ0ZWFsIjo5NTAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjIyNSJ9LHsicGMiOlsxMDY3XSwiZXJyb3JNZXNzYWdlIjoiZmllbGQgbm90IHJlbW92YWJsZSBvciBubyBwZXJtaXNzaW9ucyB0byByZW1vdmUiLCJ0ZWFsIjoxMDc1LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoyNDQifSx7InBjIjpbMTExMV0sImVycm9yTWVzc2FnZSI6ImNhbGxlciBtdXN0IGJlIE5GRCByZWdpc3RyeSEiLCJ0ZWFsIjoxMTMwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoyNTgifSx7InBjIjpbMTEyMV0sImVycm9yTWVzc2FnZSI6ImNoaWxkIE5GRCBNVVNUIHN0aWxsIGJlIGluIHByZS1jbGFpbSBzdGF0ZSEiLCJ0ZWFsIjoxMTQ0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoyNTkifSx7InBjIjpbMTE0NF0sImVycm9yTWVzc2FnZSI6InBhc3NlZCBpbiBjaGlsZCBuYW1lIG11c3QgbWF0Y2ggbmFtZSBpbiBjcmVhdGVkIG5mZCBzdGF0ZSIsInRlYWwiOjExNzIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjI2NiJ9LHsicGMiOlsxMTc3XSwiZXJyb3JNZXNzYWdlIjoicGFyZW50IG11c3QgYmUgc3VmZml4IG9mIGNoaWxkIiwidGVhbCI6MTIwOSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6Mjc2In0seyJwYyI6WzEzNDZdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMobmFtZSkuc2l6ZSIsInRlYWwiOjEzODEsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjI5OCJ9LHsicGMiOlsxMzg2XSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKG5hbWUpLnNpemUiLCJ0ZWFsIjoxNDIzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozMDcifSx7InBjIjpbMTQ4N10sImVycm9yTWVzc2FnZSI6ImNhbid0IHVwZGF0ZSBmaWVsZHMgaWYgTkZEIGV4cGlyZWQiLCJ0ZWFsIjoxNTM3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozMjMifSx7InBjIjpbMTYxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdXBkYXRlIGNhbGwgYnkgcmVnaXN0cnkiLCJ0ZWFsIjoxNjQ0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozMzMifSx7InBjIjpbMTcxN10sImVycm9yTWVzc2FnZSI6ImZpZWxkIG5vdCB1cGRhdGFibGUgb3Igbm8gcGVybWlzc2lvbnMgdG8gdXBkYXRlIiwidGVhbCI6MTczOCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MzQwIn0seyJwYyI6WzE3NjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4ndCB1cGRhdGUgZmllbGRzIGlmIE5GRCBleHBpcmVkIiwidGVhbCI6MTc5OSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MzUzIn0seyJwYyI6WzE4MDNdLCJlcnJvck1lc3NhZ2UiOiJmaWVsZCBub3QgdXBkYXRhYmxlIG9yIG5vIHBlcm1pc3Npb25zIHRvIHVwZGF0ZSIsInRlYWwiOjE4NDQsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjM1OSJ9LHsicGMiOlsxOTAyXSwiZXJyb3JNZXNzYWdlIjoibXVzdCBiZSB1c2VyLWRlZmluZWQgb3IgdmVyaWZpZWQgZmllbGQgdG8gZmV0Y2giLCJ0ZWFsIjoxOTUzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozNzkifSx7InBjIjpbMTkxNF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhmaWVsZE5hbWUpLnZhbHVlIiwidGVhbCI6MTk3MSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6Mzg0In0seyJwYyI6WzE5NDRdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoYm94TmFtZSkudmFsdWUiLCJ0ZWFsIjoyMDA1LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czozOTIifSx7InBjIjpbMTk5NF0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhib3hOYW1lKS52YWx1ZSIsInRlYWwiOjIwNTcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjQwMCJ9LHsicGMiOlsyMDIxXSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAocmVzZXJ2ZWRGb3IpIGZvciBvZmZlckZvclNhbGUgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjoyMDkzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0MDcifSx7InBjIjpbMjAzOV0sImVycm9yTWVzc2FnZSI6ImNhbid0IHNlbGwgaWYgTkZEIGV4cGlyZWQiLCJ0ZWFsIjoyMTE3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0MDgifSx7InBjIjpbMjA4OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGJlIHNvbGQgaWYgbm8gdXNlci1kZWZpbmVkIG9yIHZlcmlmaWVkIHByb3BlcnRpZXMgcmVtYWluIiwidGVhbCI6MjE2NSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NDE5In0seyJwYyI6WzIxMDZdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIHNvbGQgZm9yIGF0IGxlYXN0IE1JTiBhbW91bnQiLCJ0ZWFsIjoyMTg1LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0MjMifSx7InBjIjpbMjI1Ml0sImVycm9yTWVzc2FnZSI6ImNhbid0IHVwZGF0ZSBmaWVsZHMgaWYgTkZEIGV4cGlyZWQiLCJ0ZWFsIjoyMzIzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0NjUifSx7InBjIjpbMjI2NV0sImVycm9yTWVzc2FnZSI6Im11c3QgYmUgZm9yIHNhbGUiLCJ0ZWFsIjoyMzQwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0NjcifSx7InBjIjpbMjQyMF0sImVycm9yTWVzc2FnZSI6ImNhbGxlciBtdXN0IGJlIE5GRCByZWdpc3RyeSEiLCJ0ZWFsIjoyNDg0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo0OTIifSx7InBjIjpbMjY1Ml0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKHBheW1lbnQpIGZvciBwdXJjaGFzZSBtdXN0IGJlIGEgcGF5IHRyYW5zYWN0aW9uIiwidGVhbCI6Mjc1MSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NTczIn0seyJwYyI6WzI2NzddLCJlcnJvck1lc3NhZ2UiOiJjYW4ndCBiZSBleHBpcmVkIiwidGVhbCI6Mjc4Miwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NTc1In0seyJwYyI6WzI2ODFdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIGZvciBzYWxlIiwidGVhbCI6Mjc4OSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NTc2In0seyJwYyI6WzI3MzNdLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IHNlbmRlciBtdXN0IGJlIHNhbWUgYXMgcHVyY2hhc2UgY2FsbGVyIiwidGVhbCI6MjgzMCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NTgzIn0seyJwYyI6WzI3NDldLCJlcnJvck1lc3NhZ2UiOiJSZXNlcnZlZCBvd25lciBzZXQsIGJ1dCBzZW5kZXIgaXNuJ3QgdGhlIHJlc2VydmVkIGFkZHJlc3MiLCJ0ZWFsIjoyODUzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo1ODYifSx7InBjIjpbMjc5NV0sImVycm9yTWVzc2FnZSI6Im9mZmVyIG11c3QgYmUgYXQgbGVhc3QgbWluIGFtb3VudCIsInRlYWwiOjI5MDAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjYwNCJ9LHsicGMiOlsyODAxXSwiZXJyb3JNZXNzYWdlIjoib2ZmZXIgbXVzdCBiZSBhdCBsZWFzdCBzZWxsIGFtb3VudCIsInRlYWwiOjI5MTAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjYwNyJ9LHsicGMiOlsyODIzXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdmVyaWZpY2F0aW9uIGZhaWxlZDoge1widHhuXCI6XCJwYXltZW50XCIsXCJmaWVsZFwiOlwiYW1vdW50XCIsXCJleHBlY3RlZFwiOlwib3JpZ09mZmVyYW10XCJ9IiwidGVhbCI6MjkzNSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NjE0In0seyJwYyI6WzI4MzFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB2ZXJpZmljYXRpb24gZmFpbGVkOiB7XCJ0eG5cIjpcInBheW1lbnRcIixcImZpZWxkXCI6XCJyZWNlaXZlclwiLFwiZXhwZWN0ZWRcIjpcInRoaXMuYXBwLmFkZHJlc3NcIn0iLCJ0ZWFsIjoyOTQ0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo2MTQifSx7InBjIjpbMzI5MV0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGFkZHJlc3MpIGZvciBpc0FkZHJlc3NJbkZpZWxkIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6MzQwNiwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6NzMwIn0seyJwYyI6WzMzMzZdLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoZmllbGROYW1lKS52YWx1ZSIsInRlYWwiOjM0NTgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjczNSJ9LHsicGMiOlszNTUzXSwiZXJyb3JNZXNzYWdlIjoibXVzdCBwYXNzIDMyLWJ5dGUgaGFzaCB0aGF0IGlzbid0IDAiLCJ0ZWFsIjozNzExLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo4NTYifSx7InBjIjpbMzU2N10sImVycm9yTWVzc2FnZSI6Im9ubHkgdHhubGFiIG9yIG93bmVyIGNhbiByZXF1ZXN0IGFuIG5mZCBuZnQgaGFzaCB1cGRhdGUiLCJ0ZWFsIjozNzI5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo4NjEifSx7InBjIjpbMzYwM10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGxvY2spIGZvciBjb250cmFjdExvY2sgbXVzdCBiZSBhIGJvb2wiLCJ0ZWFsIjozNzgyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo4NzYifSx7InBjIjpbMzY0OV0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKGxvY2spIGZvciBzZWdtZW50TG9jayBtdXN0IGJlIGEgYm9vbCIsInRlYWwiOjM4MzUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjg4NCJ9LHsicGMiOlszNzMyXSwiZXJyb3JNZXNzYWdlIjoiYW1vdW50IG11c3QgYmUgYXQgbGVhc3QgTkZEX01JTl9TRUdNRU5UX1VTRCBkb2xsYXJzIGluIGFsZ28iLCJ0ZWFsIjozOTMwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo4OTUifSx7InBjIjpbMzc0N10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGxvY2spIGZvciB2YXVsdE9wdEluTG9jayBtdXN0IGJlIGEgYm9vbCIsInRlYWwiOjM5NTIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjkwNyJ9LHsicGMiOlszODEyXSwiZXJyb3JNZXNzYWdlIjoic2VuZGVyIG11c3QgYmUgb3duZXIgd2hlbiB2YXVsdCBsb2NrZWQiLCJ0ZWFsIjo0MDMyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo5MjUifSx7InBjIjpbMzgxN10sImVycm9yTWVzc2FnZSI6InBhcnQgb2Ygb3B0LWluIGZvciBuZXcgYXNzZXQsIG11c3QgaGF2ZSBwcmlvciB0eG4gcGF5aW5nIE1CUiIsInRlYWwiOjQwNDIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjkzMSJ9LHsicGMiOlszODMwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdmVyaWZpY2F0aW9uIGZhaWxlZDoge1widHhuXCI6XCJ0aGlzLnR4bkdyb3VwW3RoaXMudHhuLmdyb3VwSW5kZXggLSAxXVwiLFwiZmllbGRcIjpcInR5cGVFbnVtXCIsXCJleHBlY3RlZFwiOlwicGF5XCJ9IiwidGVhbCI6NDA2MSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6OTMzIn0seyJwYyI6WzM4MzhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB2ZXJpZmljYXRpb24gZmFpbGVkOiB7XCJ0eG5cIjpcInRoaXMudHhuR3JvdXBbdGhpcy50eG4uZ3JvdXBJbmRleCAtIDFdXCIsXCJmaWVsZFwiOlwicmVjZWl2ZXJcIixcImV4cGVjdGVkXCI6XCJ0aGlzLmFwcC5hZGRyZXNzXCJ9IiwidGVhbCI6NDA3MCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6OTM0In0seyJwYyI6WzM4NTNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB2ZXJpZmljYXRpb24gZmFpbGVkOiB7XCJ0eG5cIjpcInRoaXMudHhuR3JvdXBbdGhpcy50eG4uZ3JvdXBJbmRleCAtIDFdXCIsXCJmaWVsZFwiOlwiYW1vdW50XCIsXCJleHBlY3RlZFwiOlwiMTAwXzAwMCAqIGFzc2V0cy5sZW5ndGhcIn0iLCJ0ZWFsIjo0MDg0LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo5MzUifSx7InBjIjpbMzk1NF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDMgKHJlY2VpdmVyKSBmb3IgdmF1bHRTZW5kIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6NDE5OCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6OTU4In0seyJwYyI6WzM5OTRdLCJlcnJvck1lc3NhZ2UiOiJjYW4ndCBzcGVjaWZ5IG90aGVyIGFzc2V0cyBpZiBzZW5kaW5nIGFsZ28gZnJvbSB2YXVsdCIsInRlYWwiOjQyNDcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjk2OCJ9LHsicGMiOls0MDYxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgc2VuZCBvbmUgYXNzZXQgaWYgYW1vdW50ID09IDAiLCJ0ZWFsIjo0MzI5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo5ODAifSx7InBjIjpbNDEyOF0sImVycm9yTWVzc2FnZSI6InJlY2VpdmVyIG11c3QgYmUgb3duZXIiLCJ0ZWFsIjo0NDAyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czo5OTMifSx7InBjIjpbNDIzN10sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKHBheW1lbnQpIGZvciByZW5ldyBtdXN0IGJlIGEgcGF5IHRyYW5zYWN0aW9uIiwidGVhbCI6NDUzNywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTAyOSJ9LHsicGMiOls0MjU2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdmVyaWZpY2F0aW9uIGZhaWxlZDoge1widHhuXCI6XCJwYXltZW50XCIsXCJmaWVsZFwiOlwicmVjZWl2ZXJcIixcImV4cGVjdGVkXCI6XCJ0aGlzLmFwcC5hZGRyZXNzXCJ9IiwidGVhbCI6NDU3Nywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTAzMCJ9LHsicGMiOls0Mzg2XSwiZXJyb3JNZXNzYWdlIjoiY2FuJ3QgY2xhaW0gZXhwaXJlZCBuZmQgdW5sZXNzIGFsbCBtZXRhZGF0YSBpcyBjbGVhcmVkIiwidGVhbCI6NDcwNiwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTA1MiJ9LHsicGMiOls0Mzk0XSwiZXJyb3JNZXNzYWdlIjoibXVzdCBwYXkgYXQgbGVhc3QgbWluaW11bSByZW5ld2FsIHByaWNlIiwidGVhbCI6NDcxOSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTA1OCJ9LHsicGMiOls0NTUwXSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsIHN0YXRlIHZhbHVlIGRvZXMgbm90IGV4aXN0OiBwYXJlbnRBcHBJZC5nbG9iYWxTdGF0ZShORkRfS0VZX09XTkVSKSIsInRlYWwiOjQ4OTIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEwOTgifSx7InBjIjpbNDcxNl0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGFkZHJlc3MpIGZvciBzZXRQcmltYXJ5QWRkcmVzcyBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjUwMzksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjExMzcifSx7InBjIjpbNDgwMl0sImVycm9yTWVzc2FnZSI6ImNhbGxlciBtdXN0IGJlIE5GRCByZWdpc3RyeSEiLCJ0ZWFsIjo1MTI2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTU2In0seyJwYyI6WzQ4MjBdLCJlcnJvck1lc3NhZ2UiOiJmaWVsZCBiZWluZyB2ZXJpZmllZCBNVVNUIFNUQVJUIHdpdGggdS5jYXYiLCJ0ZWFsIjo1MTQwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTU4In0seyJwYyI6WzQ4MjldLCJlcnJvck1lc3NhZ2UiOiJkZXN0aW5hdGlvbiBmaWVsZCBNVVNUIFNUQVJUIHdpdGggdi5jYVsuLi4uXSIsInRlYWwiOjUxNTAsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjExNTkifSx7InBjIjpbNDg0NF0sImVycm9yTWVzc2FnZSI6ImRlc3RpbmF0aW9uIGZpZWxkIG11c3QgZW5kIEVORCB3aXRoIC5hcyIsInRlYWwiOjUxNjUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjExNjAifSx7InBjIjpbNDg1MF0sImVycm9yTWVzc2FnZSI6InJlZmVyZW5jZWQgZmllbGQgdG8gYWRkIGFzIHZlcmlmaWVkIGFkZHJlc3MgbXVzdCBoYXZlIHZhbHVlIGluIGJveCBzdG9yYWdlIiwidGVhbCI6NTE3OCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTE2MSJ9LHsicGMiOls0ODU5XSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGZpZWxkQmVpbmdWZXJpZmllZCkudmFsdWUiLCJ0ZWFsIjo1MTkzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTY3In0seyJwYyI6WzQ5MjRdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCAwIChtYnJSZWZ1bmREZXN0KSBmb3IgcmVnaXN0cnlSZW1vdmluZ1ZlcmlmaWVkQWRkcmVzcyBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjUyNTMsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjExODcifSx7InBjIjpbNDkzMl0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKGFkZHJlc3MpIGZvciByZWdpc3RyeVJlbW92aW5nVmVyaWZpZWRBZGRyZXNzIG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6NTI2Mywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTE4NyJ9LHsicGMiOls0OTYyXSwiZXJyb3JNZXNzYWdlIjoiY2FsbGVyIG11c3QgYmUgTkZEIHJlZ2lzdHJ5ISIsInRlYWwiOjUzMDIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjExODgifSx7InBjIjpbNDk3NF0sImVycm9yTWVzc2FnZSI6ImNhbid0IGJlIGZvciBzYWxlIiwidGVhbCI6NTMxOCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTE5MSJ9LHsicGMiOls0OTgzXSwiZXJyb3JNZXNzYWdlIjoidmVyaWZpZWQgZmllbGQgTVVTVCBTVEFSVCB3aXRoIHYuY2FbLi4uLl0iLCJ0ZWFsIjo1MzI5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTkzIn0seyJwYyI6WzQ5OThdLCJlcnJvck1lc3NhZ2UiOiJ2ZXJpZmllZCBmaWVsZCBtdXN0IGVuZCBFTkQgd2l0aCAuYXMiLCJ0ZWFsIjo1MzQ3LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMTk0In0seyJwYyI6WzUwMDddLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94ZXMoZmllbGRCZWluZ0NoYW5nZWQpLnNpemUiLCJ0ZWFsIjo1MzYyLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMjAwIn0seyJwYyI6WzUxNzVdLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgbXVzdCBiZSBvd25lciIsInRlYWwiOjU1NDIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEyNDcifSx7InBjIjpbNTE4MF0sImVycm9yTWVzc2FnZSI6InBhcnQgb2Ygb3B0LWluIGZvciBuZXcgYXNzZXQsIG11c3QgaGF2ZSBwcmlvciB0eG4gcGF5aW5nIE1CUiIsInRlYWwiOjU1NTIsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEyNTAifSx7InBjIjpbNTE5M10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHZlcmlmaWNhdGlvbiBmYWlsZWQ6IHtcInR4blwiOlwidGhpcy50eG5Hcm91cFt0aGlzLnR4bi5ncm91cEluZGV4IC0gMV1cIixcImZpZWxkXCI6XCJ0eXBlRW51bVwiLFwiZXhwZWN0ZWRcIjpcInBheVwifSIsInRlYWwiOjU1NzEsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEyNTIifSx7InBjIjpbNTIwMV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHZlcmlmaWNhdGlvbiBmYWlsZWQ6IHtcInR4blwiOlwidGhpcy50eG5Hcm91cFt0aGlzLnR4bi5ncm91cEluZGV4IC0gMV1cIixcImZpZWxkXCI6XCJyZWNlaXZlclwiLFwiZXhwZWN0ZWRcIjpcInRoaXMuYXBwLmFkZHJlc3NcIn0iLCJ0ZWFsIjo1NTgwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMjUzIn0seyJwYyI6WzUyMTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB2ZXJpZmljYXRpb24gZmFpbGVkOiB7XCJ0eG5cIjpcInRoaXMudHhuR3JvdXBbdGhpcy50eG4uZ3JvdXBJbmRleCAtIDFdXCIsXCJmaWVsZFwiOlwiYW1vdW50XCIsXCJleHBlY3RlZFwiOlwiMTAwXzAwMCAqICh0aGlzLnR4bi5udW1BcHBBcmdzIC0gMSlcIn0iLCJ0ZWFsIjo1NTkzLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMjU0In0seyJwYyI6WzUzMTddLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWwgc3RhdGUgdmFsdWUgZG9lcyBub3QgZXhpc3Q6IEFwcElELmZyb21VaW50NjQoYXBwSWQpLmdsb2JhbFN0YXRlKGtleSkiLCJ0ZWFsIjo1NzMwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMjgwIn0seyJwYyI6WzUzNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnRlcm5hbCBmaWVsZHMgY2FuIG5ldmVyIGJlIGRlbGV0ZWQiLCJ0ZWFsIjo1Nzk2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMzEzIn0seyJwYyI6WzUzODhdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIG93bmVkIiwidGVhbCI6NTgyMCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTMyMCJ9LHsicGMiOls1NDAwXSwiZXJyb3JNZXNzYWdlIjoiY2FuJ3QgYmUgZm9yIHNhbGUiLCJ0ZWFsIjo1ODM2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMzIzIn0seyJwYyI6WzU0NzFdLCJlcnJvck1lc3NhZ2UiOiJpbnRlcm5hbCBmaWVsZHMgY2FuIG5ldmVyIGJlIHVwZGF0ZWQiLCJ0ZWFsIjo1OTIwLCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMzU3In0seyJwYyI6WzU1MjZdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIG93bmVkIiwidGVhbCI6NTk3Nywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTM2NSJ9LHsicGMiOls1NTMxXSwiZXJyb3JNZXNzYWdlIjoiY2FuJ3QgYmUgZm9yIHNhbGUiLCJ0ZWFsIjo1OTg1LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxMzY2In0seyJwYyI6WzU1MzddLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgbXVzdCBiZSBvd25lciIsInRlYWwiOjU5OTUsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjEzNjcifSx7InBjIjpbNTU2N10sImVycm9yTWVzc2FnZSI6InVwZGF0aW5nIHYuY2FBbGdvIGZpZWxkIGlzbid0IGFsbG93ZWQgdmlhIHJlZ3VsYXIgZmllbGQgdXBkYXRlIiwidGVhbCI6NjAzMSwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTM3NSJ9LHsicGMiOls1Njg4XSwiZXJyb3JNZXNzYWdlIjoiY2FuJ3QgYmUgZm9yIHNhbGUiLCJ0ZWFsIjo2MTc2LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxNDI2In0seyJwYyI6WzU2OTNdLCJlcnJvck1lc3NhZ2UiOiJjYW4ndCBiZSBleHBpcmVkIiwidGVhbCI6NjE4NCwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTQyNyJ9LHsicGMiOls1Nzc4XSwiZXJyb3JNZXNzYWdlIjoibWF4IGV4cGlyYXRpb24gZXhjZWVkZWQgcGFyYW1ldGVycyBkZWZpbmVkIGJ5IHJlZ2lzdHJ5IiwidGVhbCI6NjI5Niwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTQ1NCJ9LHsicGMiOls1OTQ2XSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGtleSkudmFsdWUiLCJ0ZWFsIjo2NTI5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxNTA4In0seyJwYyI6WzU5NjFdLCJlcnJvck1lc3NhZ2UiOiJhZGRyZXNzICdzZXQnIHNob3VsZCBhbHJlYWR5IGhhdmUgYXQgbGVhc3QgdHdvIHZhbHVlcyIsInRlYWwiOjY1NDcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE1MTIifSx7InBjIjpbNjAyOV0sImVycm9yTWVzc2FnZSI6ImFkZHJlc3MgbXVzdCBiZSBmb3VuZCBpbiBzZXQgaW4gb3JkZXIgdG8gbW92ZSBpdCIsInRlYWwiOjY2MjksInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE1MjgifSx7InBjIjpbNjA5NV0sImVycm9yTWVzc2FnZSI6ImJveCB2YWx1ZSBkb2VzIG5vdCBleGlzdDogdGhpcy5ib3hlcyhrZXkpLnZhbHVlIiwidGVhbCI6NjcxMiwic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTU1MiJ9LHsicGMiOls2MTE0XSwiZXJyb3JNZXNzYWdlIjoiZXhpc3Rpbmcgc2V0IG11c3QgYmUgbXVsdGlwbGUgb2Yga2V5IGJlaW5nIGFkZGVkIiwidGVhbCI6NjczMywic291cmNlIjoiY29udHJhY3RzL05GREluc3RhbmNlLmFsZ28udHM6MTU1NSJ9LHsicGMiOls2MjIxXSwiZXJyb3JNZXNzYWdlIjoiYm94IHZhbHVlIGRvZXMgbm90IGV4aXN0OiB0aGlzLmJveGVzKGtleSkudmFsdWUiLCJ0ZWFsIjo2ODY5LCJzb3VyY2UiOiJjb250cmFjdHMvTkZESW5zdGFuY2UuYWxnby50czoxNTg2In0seyJwYyI6WzYzOTBdLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgbXVzdCBiZSBvd25lciIsInRlYWwiOjcwNzgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE2MjQifSx7InBjIjpbNjQwNV0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjcwODcsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE3In0seyJwYyI6WzY2MjFdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBVcGRhdGVBcHBsaWNhdGlvbiIsInRlYWwiOjcxMjgsInNvdXJjZSI6ImNvbnRyYWN0cy9ORkRJbnN0YW5jZS5hbGdvLnRzOjE3In1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjpudWxsLCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjMsIm1pbm9yIjoyNywicGF0Y2giOjIzNzIxNywiY29tbWl0SGFzaCI6IjBiYzNkN2U0In19LCJldmVudHMiOlt7Im5hbWUiOiJuZmRfb2ZmZXJGb3JTYWxlIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmVkRm9yIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJuZmRfc2FsZUNhbmNlbGxlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJuZmRfcG9zdGVkT2ZmZXIiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub3RlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJuZmRfcHVyY2hhc2VkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbEFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZmVyQW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3ZlcnBheW1lbnRSZWZ1bmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udkZlZUFkZHIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb252RmVlQW1vdW50IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJuZmRfcmVuZXdlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yaWdPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlT25lWWVhciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlbmV3QW1vdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwVGltZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoibmZkX2FkZHJlc3NMaW5rZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJuZmRfYWRkcmVzc1VubGlua2VkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJhZG1pbkFzYUlkIjp7InR5cGUiOiJ1aW50NjQiLCJ2YWx1ZSI6bnVsbH0sInJlZ2lzdHJ5QXBwSWQiOnsidHlwZSI6InVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnsiYWRtaW5Bc2FJZCI6eyJzbG90IjoyMDAsInR5cGUiOiJ1aW50NjQifSwicmVnaXN0cnlBcHBJZCI6eyJzbG90IjoyMDEsInR5cGUiOiJ1aW50NjQifX19";
    }

}
